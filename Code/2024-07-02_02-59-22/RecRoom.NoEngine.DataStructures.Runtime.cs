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
		[Cpp2IlInjected.Address(RVA = "0x88F9F0", Offset = "0x88E9F0", VA = "0x18088F9F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6A46C20", Offset = "0x6A45C20", VA = "0x186A46C20")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x890740", Offset = "0x88F740", VA = "0x180890740")]
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
		[Cpp2IlInjected.Address(RVA = "0x890780", Offset = "0x88F780", VA = "0x180890780")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class CIBEEGBDBMG
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
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
		[Cpp2IlInjected.Address(RVA = "0x4231AD0", Offset = "0x4230AD0", VA = "0x184231AD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4231B40", Offset = "0x4230B40", VA = "0x184231B40")]
	protected KOFDCNCFNJJ(bool NHOMMLLHLNF, bool NPMOODIKICM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x42310E0", Offset = "0x42300E0", VA = "0x1842310E0")]
	protected bool BGOAMONHMCO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4231180", Offset = "0x4230180", VA = "0x184231180")]
	protected void FEABPMMKFGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4231830", Offset = "0x4230830", VA = "0x184231830")]
	protected void PEOFIJOMIGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2A97E20", Offset = "0x2A96E20", VA = "0x182A97E20")]
	private static void INMCPEHJGNP<U>(List<U>? DNOAHHGKGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4231470", Offset = "0x4230470", VA = "0x184231470", Slot = "4")]
	public void MJFEDCBJOBF(T OGLJLDNLGIJ, bool AOPDJHHPDEE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x42312A0", Offset = "0x42302A0", VA = "0x1842312A0", Slot = "5")]
	public void GAGDAFIMOPK(T OGLJLDNLGIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4231680", Offset = "0x4230680", VA = "0x184231680")]
	public void OAIAOCAHOEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class BGECMLEGDCD : KOFDCNCFNJJ<Action>
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6A440B0", Offset = "0x6A430B0", VA = "0x186A440B0")]
	public BGECMLEGDCD(bool NHOMMLLHLNF = false, bool NPMOODIKICM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6A43EB0", Offset = "0x6A42EB0", VA = "0x186A43EB0")]
	public void NGOOLELHLHP()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6A43E50", Offset = "0x6A42E50", VA = "0x186A43E50")]
	public static BGECMLEGDCD DABBFBOOFEB(BGECMLEGDCD LHGHPIKEDFN, Action OGLJLDNLGIJ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6A43DF0", Offset = "0x6A42DF0", VA = "0x186A43DF0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3800EE0", Offset = "0x37FFEE0", VA = "0x183800EE0")]
	public GFLPBNMBKPD(bool NHOMMLLHLNF = false, bool NPMOODIKICM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3D39E80", Offset = "0x3D38E80", VA = "0x183D39E80")]
	public void NGOOLELHLHP(T LBKJPGMAINP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3D37EB0", Offset = "0x3D36EB0", VA = "0x183D37EB0")]
	public static GFLPBNMBKPD<T> DABBFBOOFEB(GFLPBNMBKPD<T> LHGHPIKEDFN, Action<T> OGLJLDNLGIJ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3D37E10", Offset = "0x3D36E10", VA = "0x183D37E10")]
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
	[Cpp2IlInjected.Address(RVA = "0x3800EE0", Offset = "0x37FFEE0", VA = "0x183800EE0")]
	public MLMADGFCCJE(bool NHOMMLLHLNF = false, bool NPMOODIKICM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x44FC5C0", Offset = "0x44FB5C0", VA = "0x1844FC5C0")]
	public void NGOOLELHLHP(T LBKJPGMAINP, U KPCGDJJONPF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3D37EB0", Offset = "0x3D36EB0", VA = "0x183D37EB0")]
	public static MLMADGFCCJE<T, U> DABBFBOOFEB(MLMADGFCCJE<T, U> LHGHPIKEDFN, Action<T, U> OGLJLDNLGIJ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3D37E10", Offset = "0x3D36E10", VA = "0x183D37E10")]
	public static MLMADGFCCJE<T, U> CPEBBFJPNJI(MLMADGFCCJE<T, U> LHGHPIKEDFN, Action<T, U> OGLJLDNLGIJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class NLMLNFBKPBM<T, U, V> : KOFDCNCFNJJ<Action<T, U, V>> where T : notnull where U : notnull where V : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3800EE0", Offset = "0x37FFEE0", VA = "0x183800EE0")]
	public NLMLNFBKPBM(bool NHOMMLLHLNF = false, bool NPMOODIKICM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4598470", Offset = "0x4597470", VA = "0x184598470")]
	public void NGOOLELHLHP(T LBKJPGMAINP, U KPCGDJJONPF, V DCMJEJAEEHK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3D37EB0", Offset = "0x3D36EB0", VA = "0x183D37EB0")]
	public static NLMLNFBKPBM<T, U, V> DABBFBOOFEB(NLMLNFBKPBM<T, U, V> LHGHPIKEDFN, Action<T, U, V> OGLJLDNLGIJ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3D37E10", Offset = "0x3D36E10", VA = "0x183D37E10")]
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
	[Cpp2IlInjected.Address(RVA = "0x3800EE0", Offset = "0x37FFEE0", VA = "0x183800EE0")]
	public CLDFNPCBGJJ(bool NHOMMLLHLNF = false, bool NPMOODIKICM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5257D20", Offset = "0x5256D20", VA = "0x185257D20")]
	public void NGOOLELHLHP(T LBKJPGMAINP, U KPCGDJJONPF, V DCMJEJAEEHK, W FHNDBKCMHNE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3D37EB0", Offset = "0x3D36EB0", VA = "0x183D37EB0")]
	public static CLDFNPCBGJJ<T, U, V, W> DABBFBOOFEB(CLDFNPCBGJJ<T, U, V, W> LHGHPIKEDFN, Action<T, U, V, W> OGLJLDNLGIJ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3D37E10", Offset = "0x3D36E10", VA = "0x183D37E10")]
	public static CLDFNPCBGJJ<T, U, V, W> CPEBBFJPNJI(CLDFNPCBGJJ<T, U, V, W> LHGHPIKEDFN, Action<T, U, V, W> OGLJLDNLGIJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class PANDAMDIBCM<T, U, V, W, X> : KOFDCNCFNJJ<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3800EE0", Offset = "0x37FFEE0", VA = "0x183800EE0")]
	public PANDAMDIBCM(bool NHOMMLLHLNF = false, bool NPMOODIKICM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x475FAF0", Offset = "0x475EAF0", VA = "0x18475FAF0")]
	public void NGOOLELHLHP(T LBKJPGMAINP, U KPCGDJJONPF, V DCMJEJAEEHK, W FHNDBKCMHNE, X OOALEDCPNBJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3D37EB0", Offset = "0x3D36EB0", VA = "0x183D37EB0")]
	public static PANDAMDIBCM<T, U, V, W, X> DABBFBOOFEB(PANDAMDIBCM<T, U, V, W, X> LHGHPIKEDFN, Action<T, U, V, W, X> OGLJLDNLGIJ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3D37E10", Offset = "0x3D36E10", VA = "0x183D37E10")]
	public static PANDAMDIBCM<T, U, V, W, X> CPEBBFJPNJI(PANDAMDIBCM<T, U, V, W, X> LHGHPIKEDFN, Action<T, U, V, W, X> OGLJLDNLGIJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class NPCLPKJKFHH<T, U, V, W, X, Y> : KOFDCNCFNJJ<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3800EE0", Offset = "0x37FFEE0", VA = "0x183800EE0")]
	public NPCLPKJKFHH(bool NHOMMLLHLNF = false, bool NPMOODIKICM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x45B6F10", Offset = "0x45B5F10", VA = "0x1845B6F10")]
	public void NGOOLELHLHP(T LBKJPGMAINP, U KPCGDJJONPF, V DCMJEJAEEHK, W FHNDBKCMHNE, X OOALEDCPNBJ, Y HDFOCKKCOOF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3D37EB0", Offset = "0x3D36EB0", VA = "0x183D37EB0")]
	public static NPCLPKJKFHH<T, U, V, W, X, Y> DABBFBOOFEB(NPCLPKJKFHH<T, U, V, W, X, Y> LHGHPIKEDFN, Action<T, U, V, W, X, Y> OGLJLDNLGIJ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3D37E10", Offset = "0x3D36E10", VA = "0x183D37E10")]
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
		[Cpp2IlInjected.Address(RVA = "0x3CEA5C0", Offset = "0x3CE95C0", VA = "0x183CEA5C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int BDJKBNBIKDN
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x868830", Offset = "0x867830", VA = "0x180868830")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3CEB980", Offset = "0x3CEA980", VA = "0x183CEB980")]
	public AEBNPKNJGIJ(int HMMCJLOPMAB, [Optional] FMHCEMJFILO<TKey, TVal>.LHIDMCLNDKJ? KJIMOENDFEO, [Optional] IEqualityComparer<TKey>? BJLAODBBCMC, [Optional] FMHCEMJFILO<TKey, TVal>.FIAPIJMBIFO? OEIKNGELFAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3CEABA0", Offset = "0x3CE9BA0", VA = "0x183CEABA0")]
	public void DANFKACECPB(TKey BHEIPBKEDLG, TVal CBAEIEAPLIH, bool LEJFFACJNFH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3CEA750", Offset = "0x3CE9750", VA = "0x183CEA750")]
	public bool BCCLAFGNCOP(TKey BHEIPBKEDLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3CEB7D0", Offset = "0x3CEA7D0", VA = "0x183CEB7D0")]
	public bool MMCLNKMOKEF(TKey LAGEFHPKEIC, [Out] TVal CBAEIEAPLIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3CEA8C0", Offset = "0x3CE98C0", VA = "0x183CEA8C0")]
	private void BFBPLCJFCEB(TKey BHEIPBKEDLG, TVal CBAEIEAPLIH, int ENCFHCJIMBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3CEB380", Offset = "0x3CEA380", VA = "0x183CEB380")]
	public bool KCBMGCHNHLC(TKey BHEIPBKEDLG, TVal CBAEIEAPLIH, bool LEJFFACJNFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3CEB8D0", Offset = "0x3CEA8D0", VA = "0x183CEB8D0")]
	public void OAIAOCAHOEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3CEADF0", Offset = "0x3CE9DF0", VA = "0x183CEADF0")]
	private void EMPNOKCGNKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3CEB680", Offset = "0x3CEA680", VA = "0x183CEB680")]
	private bool MLJCMENCKND(TKey BHEIPBKEDLG, PFILCAPGHIC CLPBFEAPBCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3CEB550", Offset = "0x3CEA550", VA = "0x183CEB550")]
	private void KKBLLMBBKEN(TKey BHEIPBKEDLG, TVal CBAEIEAPLIH, PFILCAPGHIC CLPBFEAPBCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3CEA620", Offset = "0x3CE9620", VA = "0x183CEA620")]
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
	[Cpp2IlInjected.Address(RVA = "0x86CB90", Offset = "0x86BB90", VA = "0x18086CB90")]
	public ABIAJLLBGGH(Action DPHFDCIPJAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6A430E0", Offset = "0x6A420E0", VA = "0x186A430E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x29351C0", Offset = "0x29341C0", VA = "0x1829351C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8687D0", Offset = "0x8677D0", VA = "0x1808687D0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4E74800", Offset = "0x4E73800", VA = "0x184E74800")]
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
		[Cpp2IlInjected.Address(RVA = "0x3803AA0", Offset = "0x3802AA0", VA = "0x183803AA0")]
		get
		{
			return default(ReadOnlySequence<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long DNIPBCBOHOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3804060", Offset = "0x3803060", VA = "0x183804060")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool DFLAHLKBLGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x3803D60", Offset = "0x3802D60", VA = "0x183803D60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x38043F0", Offset = "0x38033F0", VA = "0x1838043F0")]
	public EFIOHGGEHFL(MEMGCDILONA<T> KDLEODPAOCJ, MEMGCDILONA<T> JOLHDIMIKNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x38044F0", Offset = "0x38034F0", VA = "0x1838044F0")]
	public EFIOHGGEHFL(MEMGCDILONA<T> KDLEODPAOCJ, int GEIGDPFELPO, MEMGCDILONA<T> JOLHDIMIKNH, int FJLMFNONBHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3804340", Offset = "0x3803340", VA = "0x183804340")]
	private EFIOHGGEHFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3803CD0", Offset = "0x3802CD0", VA = "0x183803CD0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3803EE0", Offset = "0x3802EE0", VA = "0x183803EE0")]
	public T[] JNKPEPBDKEI()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3803BA0", Offset = "0x3802BA0", VA = "0x183803BA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8ADFC0", Offset = "0x8ACFC0", VA = "0x1808ADFC0")]
		public static NCCDDLMPFHN HCLFOFEHDJP()
		{
			return default(NCCDDLMPFHN);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x31BCED0", Offset = "0x31BBED0", VA = "0x1831BCED0")]
	public static string? FPJNKIGMBBG<T>([Optional] string? BGOMCHAPJDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x31BCF50", Offset = "0x31BBF50", VA = "0x1831BCF50")]
	public static string? PIENIEOGKAK<T>([Optional] string? HLJIEIMNHBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8ADFC0", Offset = "0x8ACFC0", VA = "0x1808ADFC0")]
	public static AJJOLPGOGOH ICICDJFMCPH(string BGOMCHAPJDJ, string? HLJIEIMNHBC)
	{
		return default(AJJOLPGOGOH);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
		public LJLOAOFANGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x42E7FF0", Offset = "0x42E6FF0", VA = "0x1842E7FF0")]
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
	[Cpp2IlInjected.Address(RVA = "0x6A45780", Offset = "0x6A44780", VA = "0x186A45780")]
	public static Dictionary<string, HGBNDFBPIAF> DLDAMGPOKNN(Type LDPJJJAKFIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2B21600", Offset = "0x2B20600", VA = "0x182B21600")]
	public static Dictionary<string, HGBNDFBPIAF> DLDAMGPOKNN<T>(Type LDPJJJAKFIJ, IReadOnlyDictionary<T, string> PNEAGCLGIPI) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2B21E40", Offset = "0x2B20E40", VA = "0x182B21E40")]
	public static Dictionary<string, HGBNDFBPIAF> JJCKBJLDMIE<T>(List<T> DFAONOBAFJC) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6A45C70", Offset = "0x6A44C70", VA = "0x186A45C70")]
	public static Dictionary<string, HGBNDFBPIAF> MMHDKGIOKMC(Type LDPJJJAKFIJ, GPOOCBFDCDL BCMOMEKAMOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6A45AB0", Offset = "0x6A44AB0", VA = "0x186A45AB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x866360", Offset = "0x865360", VA = "0x180866360", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6A448D0", Offset = "0x6A438D0", VA = "0x186A448D0")]
	protected FNFMNGCMHCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string MKLJNMAODHM();

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6A44320", Offset = "0x6A43320", VA = "0x186A44320", Slot = "8")]
	public virtual string IDAPNHHOMNC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6A443A0", Offset = "0x6A433A0", VA = "0x186A443A0", Slot = "9")]
	public void MDIOIACOKHP(StringBuilder FDCDLEKJNHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6A44220", Offset = "0x6A43220", VA = "0x186A44220", Slot = "10")]
	public void GAJFAEEDINH(StringBuilder FDCDLEKJNHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6A447B0", Offset = "0x6A437B0", VA = "0x186A447B0", Slot = "11")]
	public void OOCFADFICFG(StringBuilder FDCDLEKJNHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6A44650", Offset = "0x6A43650", VA = "0x186A44650", Slot = "12")]
	public void MECPPGIPLBF(StringBuilder FDCDLEKJNHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6A44280", Offset = "0x6A43280", VA = "0x186A44280")]
	public static void GKCMEMJCFBH(StringBuilder FDCDLEKJNHH, string GCLKHFDGKHA, string BFKDNAGJNMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5C22A20", Offset = "0x5C21A20", VA = "0x185C22A20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class LLNBNMCCIGN : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6A46610", Offset = "0x6A45610", VA = "0x186A46610")]
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
	[Cpp2IlInjected.Address(RVA = "0x46A8410", Offset = "0x46A7410", VA = "0x1846A8410")]
	private OJADFOHOIFM([In] TErr DBJNGIIJNDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x46A8330", Offset = "0x46A7330", VA = "0x1846A8330")]
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
		[Cpp2IlInjected.Address(RVA = "0x9ED240", Offset = "0x9EC240", VA = "0x1809ED240")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x44E41F0", Offset = "0x44E31F0", VA = "0x1844E41F0")]
	private static MEMGCDILONA<T> GCLPKNPDHCJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x44E5000", Offset = "0x44E4000", VA = "0x1844E5000")]
	private static void IIMEBHFDDPO(MEMGCDILONA<T> BFNHIAMOFIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x3856D10", Offset = "0x3855D10", VA = "0x183856D10")]
	private MEMGCDILONA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x44E48E0", Offset = "0x44E38E0", VA = "0x1844E48E0")]
	public static MEMGCDILONA<T> GIGNPOIHFIA(ReadOnlyMemory<T> KKGILNKDEBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x44E46C0", Offset = "0x44E36C0", VA = "0x1844E46C0")]
	public static MEMGCDILONA<T> GIGNPOIHFIA(IMemoryOwner<T> DLECHHFKLPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x44E5710", Offset = "0x44E4710", VA = "0x1844E5710")]
	public static void OLMHAJPOEMA(MEMGCDILONA<T> KDLEODPAOCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x44E3F60", Offset = "0x44E2F60", VA = "0x1844E3F60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x44E55F0", Offset = "0x44E45F0", VA = "0x1844E55F0")]
	public MEMGCDILONA<T> LFJDNNPAPPK(IMemoryOwner<T> DLECHHFKLPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x44E4E00", Offset = "0x44E3E00", VA = "0x1844E4E00")]
	private void HGNLNDANBJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x44E4CA0", Offset = "0x44E3CA0", VA = "0x1844E4CA0")]
	private MEMGCDILONA<T> GPDEMOPAMCM(MEMGCDILONA<T> BFNHIAMOFIP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class DPMFOCJPCKE : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6A44110", Offset = "0x6A43110", VA = "0x186A44110")]
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
	[Cpp2IlInjected.Address(RVA = "0x45973A0", Offset = "0x45963A0", VA = "0x1845973A0")]
	private NLKOFMLNBKP([In] TOk AEDNHEBBEIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x3EB7D70", Offset = "0x3EB6D70", VA = "0x183EB7D70")]
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
		[Cpp2IlInjected.Address(RVA = "0x880530", Offset = "0x87F530", VA = "0x180880530", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override bool PCJONPNOBND
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x880530", Offset = "0x87F530", VA = "0x180880530", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public override bool LJMCBCALEKP
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8ADFC0", Offset = "0x8ACFC0", VA = "0x1808ADFC0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public override long DNIPBCBOHOO
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6A43B80", Offset = "0x6A42B80", VA = "0x186A43B80", Slot = "12")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public override long KBHBDHIEKKP
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6A43BE0", Offset = "0x6A42BE0", VA = "0x186A43BE0", Slot = "13")]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6A43CB0", Offset = "0x6A42CB0", VA = "0x186A43CB0", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6A43AB0", Offset = "0x6A42AB0", VA = "0x186A43AB0")]
	public AILDPMCFPMB(ReadOnlySequence<byte> LEJKAHCECBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6A43660", Offset = "0x6A42660", VA = "0x186A43660", Slot = "33")]
	public override long Seek(long ANNLKNNLIGI, SeekOrigin AKJEKBLKOGB)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6A431C0", Offset = "0x6A421C0", VA = "0x186A431C0", Slot = "35")]
	public override int Read(byte[] EPBKIHMMALG, int ANNLKNNLIGI, int JPBPNOCHNLG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350", Slot = "23")]
	public override void Flush()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6A439F0", Offset = "0x6A429F0", VA = "0x186A439F0", Slot = "34")]
	public override void SetLength(long CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6A43A50", Offset = "0x6A42A50", VA = "0x186A43A50", Slot = "38")]
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
		[Cpp2IlInjected.Address(RVA = "0x477A8C0", Offset = "0x47798C0", VA = "0x18477A8C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool INHDJHENBKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x477B910", Offset = "0x477A910", VA = "0x18477B910")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x4783180", Offset = "0x4782180", VA = "0x184783180")]
	internal PIJKHLBEMKP([In] TErr DBJNGIIJNDD, [In] TOk AEDNHEBBEIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x477AFB0", Offset = "0x4779FB0", VA = "0x18477AFB0")]
	public static PIJKHLBEMKP<TOk, TErr> CDLOABFODLB([In] TErr DBJNGIIJNDD)
	{
		return default(PIJKHLBEMKP<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x477C410", Offset = "0x477B410", VA = "0x18477C410")]
	public static PIJKHLBEMKP<TOk, TErr> EJKHGMKHOEK([In] TOk AEDNHEBBEIN)
	{
		return default(PIJKHLBEMKP<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x2BC1320", Offset = "0x2BC0320", VA = "0x182BC1320")]
	public PIJKHLBEMKP<TOk?, UErr?> KKOHDJDGHDO<UErr>()
	{
		return default(PIJKHLBEMKP<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x2BBFD90", Offset = "0x2BBED90", VA = "0x182BBFD90")]
	public PIJKHLBEMKP<UOk?, TErr?> ADBBEJGBHHC<UOk>()
	{
		return default(PIJKHLBEMKP<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2BC0C10", Offset = "0x2BBFC10", VA = "0x182BC0C10")]
	public PIJKHLBEMKP<UOk?, TErr?> CACEPGJCPAG<UOk>()
	{
		return default(PIJKHLBEMKP<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x2BC1200", Offset = "0x2BC0200", VA = "0x182BC1200")]
	public PIJKHLBEMKP<TOk?, UErr?> HILDIFPCEAA<UErr>()
	{
		return default(PIJKHLBEMKP<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x477FFE0", Offset = "0x477EFE0", VA = "0x18477FFE0")]
	public PIJKHLBEMKP<HNKFFDNJINI, TErr> KCPHKICLFIF()
	{
		return default(PIJKHLBEMKP<HNKFFDNJINI, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x477ED40", Offset = "0x477DD40", VA = "0x18477ED40")]
	public static bool JEKPEIKHIPM([In] PIJKHLBEMKP<TOk, TErr> KKEPMPAJLEA, [In] PIJKHLBEMKP<TOk, TErr> HIEMMBKCCDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x477CD80", Offset = "0x477BD80", VA = "0x18477CD80", Slot = "4")]
	public bool Equals(PIJKHLBEMKP<TOk, TErr> LJAAPFIIPOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x477CA40", Offset = "0x477BA40", VA = "0x18477CA40", Slot = "0")]
	public override bool Equals(object LJAAPFIIPOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x477D890", Offset = "0x477C890", VA = "0x18477D890", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x4782030", Offset = "0x4781030", VA = "0x184782030", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x41F0C50", Offset = "0x41EFC50", VA = "0x1841F0C50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x41F12D0", Offset = "0x41F02D0", VA = "0x1841F12D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x2CAA8E0", Offset = "0x2CA98E0", VA = "0x182CAA8E0")]
	public static PIJKHLBEMKP<TOk?, TErr?> JMFJMAHDDOM<TOk, TErr>([In] this PIJKHLBEMKP<TOk, TErr> OLDDCPCBGIL, [In] TOk AEDNHEBBEIN)
	{
		return default(PIJKHLBEMKP<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2CAA990", Offset = "0x2CA9990", VA = "0x182CAA990")]
	public static PIJKHLBEMKP<HNKFFDNJINI, TErr?> JMFJMAHDDOM<TErr>([In] this PIJKHLBEMKP<HNKFFDNJINI, TErr> OLDDCPCBGIL)
	{
		return default(PIJKHLBEMKP<HNKFFDNJINI, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2CAA8E0", Offset = "0x2CA98E0", VA = "0x182CAA8E0")]
	public static PIJKHLBEMKP<TOk?, TErr?> OIGIKKOKENE<TOk, TErr>([In] this PIJKHLBEMKP<TOk, TErr> OLDDCPCBGIL, [In] TErr DBJNGIIJNDD)
	{
		return default(PIJKHLBEMKP<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2CAA610", Offset = "0x2CA9610", VA = "0x182CAA610")]
	public static TOk? GFKPGNBAEEK<TOk, TErr>([In] this PIJKHLBEMKP<TOk, TErr> OLDDCPCBGIL)
	{
		return (TOk?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2CAAD60", Offset = "0x2CA9D60", VA = "0x182CAAD60")]
	[AsyncStateMachine(typeof(KDDCGPIEOJM<, >))]
	public static Task<TOk?>? MBNKCOLLGNG<TOk, TErr>(this Task<PIJKHLBEMKP<TOk, TErr>> OLDDCPCBGIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2CAB840", Offset = "0x2CAA840", VA = "0x182CAB840")]
	public static TErr? MKHLLDCHNPM<TErr, TOk>([In] this PIJKHLBEMKP<TOk, TErr> OLDDCPCBGIL)
	{
		return (TErr?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x2CA9190", Offset = "0x2CA8190", VA = "0x182CA9190")]
	public static bool COOOHOJNPIN<TOk, TErr, UErr, UOk>([In] this PIJKHLBEMKP<TOk, TErr> OLDDCPCBGIL, [Out] PIJKHLBEMKP<UOk, UErr> KMMBFOLKINI) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x2CABB00", Offset = "0x2CAAB00", VA = "0x182CABB00")]
	public static bool NDBFBJGBPEG<TOk, TErr>([In] this PIJKHLBEMKP<TOk, TErr> OLDDCPCBGIL, [Out][NotNullWhen(true)] TOk AEDNHEBBEIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x2CA8BA0", Offset = "0x2CA7BA0", VA = "0x182CA8BA0")]
	public static bool ALHMFBPIHKB<TOk, TErr>([In] this PIJKHLBEMKP<TOk, TErr> OLDDCPCBGIL, [Out][NotNullWhen(true)] TErr DBJNGIIJNDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x2CAABE0", Offset = "0x2CA9BE0", VA = "0x182CAABE0")]
	public static bool JOEPMLFFJGC<TOk, TErr>([In] this PIJKHLBEMKP<TOk, TErr> OLDDCPCBGIL, [Out][NotNullWhen(true)] TOk AEDNHEBBEIN, [Out][NotNullWhen(false)] TErr DBJNGIIJNDD) where TOk : notnull where TErr : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x2CAA230", Offset = "0x2CA9230", VA = "0x182CAA230")]
	public static bool DIHIBNDOJCE<TOk, TErr>([In] this PIJKHLBEMKP<TOk, TErr> OLDDCPCBGIL, [Out][NotNullWhen(true)] TOk AEDNHEBBEIN, [Out] PIJKHLBEMKP<TOk, TErr> KMMBFOLKINI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x2CA92C0", Offset = "0x2CA82C0", VA = "0x182CA92C0")]
	public static bool COOOHOJNPIN<TOk, TErr, UErr, UOk>([In] this PIJKHLBEMKP<TOk, TErr> OLDDCPCBGIL, [Out][NotNullWhen(true)] TOk AEDNHEBBEIN, [Out] PIJKHLBEMKP<UOk, UErr> KMMBFOLKINI) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x2CA87F0", Offset = "0x2CA77F0", VA = "0x182CA87F0")]
	public static bool AKFOLJNOKOK<TOk, TErr>([In] this PIJKHLBEMKP<TOk, TErr> OLDDCPCBGIL, [Out][NotNullWhen(true)] TOk AEDNHEBBEIN, [Out] PIJKHLBEMKP<HNKFFDNJINI, TErr> KMMBFOLKINI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x2CAB270", Offset = "0x2CAA270", VA = "0x182CAB270")]
	public static PIJKHLBEMKP<UOk, UErr> MKCJMCHDHKH<UOk, UErr, TOk, TErr>([In] this PIJKHLBEMKP<TOk, TErr> OLDDCPCBGIL, [In] PIJKHLBEMKP<UOk, UErr> JLMICGLMAKN) where TOk : UOk where TErr : UErr
	{
		return default(PIJKHLBEMKP<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x2CA8CE0", Offset = "0x2CA7CE0", VA = "0x182CA8CE0")]
	public static PIJKHLBEMKP<TOk?[]?, TErr?> BIPMOADMDKF<TOk, TErr>(this IEnumerable<PIJKHLBEMKP<TOk, TErr>> OLDDCPCBGIL)
	{
		return default(PIJKHLBEMKP<TOk[], TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class MEJFDNCHGOE<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x2AA2600", Offset = "0x2AA1600", VA = "0x182AA2600")]
	public static PIJKHLBEMKP<TOk, T> JMFJMAHDDOM<TOk>([In] TOk AEDNHEBBEIN) where TOk : notnull
	{
		return default(PIJKHLBEMKP<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x44E3840", Offset = "0x44E2840", VA = "0x1844E3840")]
	public static PIJKHLBEMKP<HNKFFDNJINI, T> JMFJMAHDDOM()
	{
		return default(PIJKHLBEMKP<HNKFFDNJINI, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x2AA2570", Offset = "0x2AA1570", VA = "0x182AA2570")]
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
		[Cpp2IlInjected.Address(RVA = "0x1EB1300", Offset = "0x1EB0300", VA = "0x181EB1300")]
		public DBLLGFMCPFL(EJLMCKJBBPD<T> LIGKCFOOPNO, int BNCNFIFKBEF, bool FNKHKAPNONC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x57F6E80", Offset = "0x57F5E80", VA = "0x1857F6E80")]
		public EJLMCKJBBPD<T>.KOJDKHIMKFN AKHPNFMFJMK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x57F6F80", Offset = "0x57F5F80", VA = "0x1857F6F80", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x57F6F80", Offset = "0x57F5F80", VA = "0x1857F6F80", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4232200", Offset = "0x4231200", VA = "0x184232200")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x4232410", Offset = "0x4231410", VA = "0x184232410", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x4232510", Offset = "0x4231510", VA = "0x184232510", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x4232A80", Offset = "0x4231A80", VA = "0x184232A80")]
		public KOJDKHIMKFN(EJLMCKJBBPD<T> LIGKCFOOPNO, int BNCNFIFKBEF, bool FNKHKAPNONC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x4232300", Offset = "0x4231300", VA = "0x184232300", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x42323A0", Offset = "0x42313A0", VA = "0x1842323A0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
		public DBAHBHOLKIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x57F5140", Offset = "0x57F4140", VA = "0x1857F5140")]
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
		[Cpp2IlInjected.Address(RVA = "0x3815080", Offset = "0x3814080", VA = "0x183815080")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public T NKNICMABPJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x3814E80", Offset = "0x3813E80", VA = "0x183814E80")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public T AOODDNLKEHF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x3815110", Offset = "0x3814110", VA = "0x183815110")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public T PGDICMLLHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x3814FA0", Offset = "0x3813FA0", VA = "0x183814FA0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int DNIPBCBOHOO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x192A9A0", Offset = "0x19299A0", VA = "0x18192A9A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x1173B80", Offset = "0x1172B80", VA = "0x181173B80")]
	private static int INDADLDEPLA(int LLPJHIPCNFD, int DOIKAIEGGLD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x3815490", Offset = "0x3814490", VA = "0x183815490")]
	public EJLMCKJBBPD(int ENCFHCJIMBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x3815220", Offset = "0x3814220", VA = "0x183815220")]
	public EJLMCKJBBPD(int ENCFHCJIMBE, Func<T> MPNLFCFIOHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x38155C0", Offset = "0x38145C0", VA = "0x1838155C0")]
	public EJLMCKJBBPD(T[] ONEIHMPFJKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x38150E0", Offset = "0x38140E0", VA = "0x1838150E0")]
	public void LHOLGILJODE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x3815150", Offset = "0x3814150", VA = "0x183815150")]
	public IEnumerable<T> PIADOEHDGNK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x3814DE0", Offset = "0x3813DE0", VA = "0x183814DE0")]
	public EJLMCKJBBPD<T>.KOJDKHIMKFN AKHPNFMFJMK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x37E0950", Offset = "0x37DF950", VA = "0x1837E0950", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x37E0950", Offset = "0x37DF950", VA = "0x1837E0950", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class PAIHLMLAIMH
{
	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x2CC31E0", Offset = "0x2CC21E0", VA = "0x182CC31E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1FB5EA0", Offset = "0x1FB4EA0", VA = "0x181FB5EA0")]
		public RRColor(float LJNBPEFJOFE, float KPEPPJDBMBI, float HEOHCJKCOLM, float FAGKOOGCGBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6A46E40", Offset = "0x6A45E40", VA = "0x186A46E40", Slot = "4")]
		public bool Equals(RRColor LJAAPFIIPOF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6A46EC0", Offset = "0x6A45EC0", VA = "0x186A46EC0", Slot = "0")]
		public override bool Equals(object LJAAPFIIPOF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x6A46FC0", Offset = "0x6A45FC0", VA = "0x186A46FC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x6A47040", Offset = "0x6A46040", VA = "0x186A47040", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x4220160", Offset = "0x421F160", VA = "0x184220160")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x4220130", Offset = "0x421F130", VA = "0x184220130", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x93A5E0", Offset = "0x9395E0", VA = "0x18093A5E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x478E150", Offset = "0x478D150", VA = "0x18478E150", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x3EB98E0", Offset = "0x3EB88E0", VA = "0x183EB98E0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x422D130", Offset = "0x422C130", VA = "0x18422D130")]
	public KLKPDHKDKII([In] T HHMLOJPFGAO, int JGPAJEHOAMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x422D040", Offset = "0x422C040", VA = "0x18422D040")]
	public KLKPDHKDKII([In] T HHMLOJPFGAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x422CB20", Offset = "0x422BB20", VA = "0x18422CB20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x422CAE0", Offset = "0x422BAE0", VA = "0x18422CAE0")]
	public KIFLODGFIOF BDENGGEBLEB()
	{
		return default(KIFLODGFIOF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x422CF10", Offset = "0x422BF10", VA = "0x18422CF10")]
	[AsyncStateMachine(typeof(KLKPDHKDKII<>.PKIOBLLLAGF))]
	public Task<KLKPDHKDKII<T>.KIFLODGFIOF> PFGHGGHILCN(CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x422CB60", Offset = "0x422BB60", VA = "0x18422CB60")]
	public void FHKCCBGJELG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class LAKKLIIFOPH
{
	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6A465A0", Offset = "0x6A455A0", VA = "0x186A465A0")]
	public static KLKPDHKDKII<HNKFFDNJINI> HCLFOFEHDJP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x2930300", Offset = "0x292F300", VA = "0x182930300")]
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
			[Cpp2IlInjected.Address(RVA = "0x3DC5830", Offset = "0x3DC4830", VA = "0x183DC5830")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x4790E40", Offset = "0x478FE40", VA = "0x184790E40", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x93A5E0", Offset = "0x9395E0", VA = "0x18093A5E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3DC5830", Offset = "0x3DC4830", VA = "0x183DC5830")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x3DC5740", Offset = "0x3DC4740", VA = "0x183DC5740", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x93A5E0", Offset = "0x9395E0", VA = "0x18093A5E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3EB93A0", Offset = "0x3EB83A0", VA = "0x183EB93A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x3EB98E0", Offset = "0x3EB88E0", VA = "0x183EB98E0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x384BB60", Offset = "0x384AB60", VA = "0x18384BB60")]
	internal EJPHOJLNABO(KLKPDHKDKII<int> KLGAADGHFPA, KLKPDHKDKII<HNKFFDNJINI> EBBIBMMBNMB, KLKPDHKDKII<HNKFFDNJINI> DHABPAFOLHE, [In] T HHMLOJPFGAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x384B180", Offset = "0x384A180", VA = "0x18384B180", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x384B3C0", Offset = "0x384A3C0", VA = "0x18384B3C0")]
	public PLEJNLGJDEH JPBHPDIMEHI()
	{
		return default(PLEJNLGJDEH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x384AF90", Offset = "0x3849F90", VA = "0x18384AF90")]
	public HAPDLLGIAIN BHGJGDNIHGJ()
	{
		return default(HAPDLLGIAIN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x384B9A0", Offset = "0x384A9A0", VA = "0x18384B9A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x6A46670", Offset = "0x6A45670", VA = "0x186A46670")]
	public static EJPHOJLNABO<HNKFFDNJINI> HCLFOFEHDJP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x2C00330", Offset = "0x2BFF330", VA = "0x182C00330")]
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
	[Cpp2IlInjected.Address(RVA = "0x869510", Offset = "0x868510", VA = "0x180869510", Slot = "7")]
	public override string MKLJNMAODHM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x4E75860", Offset = "0x4E74860", VA = "0x184E75860")]
	internal BCHLFGKJAEG(string NFOHONOFFAP, [In] TData FHNKDHIILBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class GOHMJHMILKC
{
	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x6A45700", Offset = "0x6A44700", VA = "0x186A45700")]
	public static BCHLFGKJAEG<HNKFFDNJINI> HCLFOFEHDJP(string NFOHONOFFAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x29351C0", Offset = "0x29341C0", VA = "0x1829351C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8D0B70", Offset = "0x8CFB70", VA = "0x1808D0B70")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0xEE23B0", Offset = "0xEE13B0", VA = "0x180EE23B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x6A46450", Offset = "0x6A45450", VA = "0x186A46450")]
	public void PBGBCGOCNGM(float CBAEIEAPLIH, object OEDJKICDDGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x6A46390", Offset = "0x6A45390", VA = "0x186A46390")]
	public void JHPDIDIEFLE(object OEDJKICDDGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x6A46400", Offset = "0x6A45400", VA = "0x186A46400")]
	public void OAIAOCAHOEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x6A46260", Offset = "0x6A45260", VA = "0x186A46260")]
	private void GKFIOCGAJPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x6A464C0", Offset = "0x6A454C0", VA = "0x186A464C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
		public MNPGDNPLOMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x4506200", Offset = "0x4505200", VA = "0x184506200")]
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
		[Cpp2IlInjected.Address(RVA = "0x411DBE0", Offset = "0x411CBE0", VA = "0x18411DBE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool OIAGGLCOINL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x411D830", Offset = "0x411C830", VA = "0x18411D830")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public int FGAKKPCAMNO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x8687F0", Offset = "0x8677F0", VA = "0x1808687F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x868080", Offset = "0x867080", VA = "0x180868080")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x411DA00", Offset = "0x411CA00", VA = "0x18411DA00")]
	public bool MJFEDCBJOBF(T OEDJKICDDGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x411D880", Offset = "0x411C880", VA = "0x18411D880")]
	public bool GAGDAFIMOPK(T OEDJKICDDGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x411DD10", Offset = "0x411CD10", VA = "0x18411DD10")]
	public bool PMELAKIMKGE(T OEDJKICDDGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x411DC20", Offset = "0x411CC20", VA = "0x18411DC20")]
	public void PMEFIDEFMLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x411DD60", Offset = "0x411CD60", VA = "0x18411DD60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
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
	[Cpp2IlInjected.Address(RVA = "0x86CB90", Offset = "0x86BB90", VA = "0x18086CB90")]
	public KHCGFHKKCLN(string HDPINCHBJIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x6A46550", Offset = "0x6A45550", VA = "0x186A46550", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
		public FGGMMBELEKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x6A44170", Offset = "0x6A43170", VA = "0x186A44170")]
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
		[Cpp2IlInjected.Address(RVA = "0x6A44AD0", Offset = "0x6A43AD0", VA = "0x186A44AD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool OIAGGLCOINL
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x6A44940", Offset = "0x6A43940", VA = "0x186A44940")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public int FGAKKPCAMNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x8687F0", Offset = "0x8677F0", VA = "0x1808687F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x868080", Offset = "0x867080", VA = "0x180868080")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6A449F0", Offset = "0x6A439F0", VA = "0x186A449F0")]
	public bool MJFEDCBJOBF(object OEDJKICDDGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6A44950", Offset = "0x6A43950", VA = "0x186A44950")]
	public bool GAGDAFIMOPK(object OEDJKICDDGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6A44BD0", Offset = "0x6A43BD0", VA = "0x186A44BD0")]
	public bool PMELAKIMKGE(object OEDJKICDDGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6A44B60", Offset = "0x6A43B60", VA = "0x186A44B60")]
	public void PMEFIDEFMLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6A44C30", Offset = "0x6A43C30", VA = "0x186A44C30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
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
		[Cpp2IlInjected.Address(RVA = "0x107FB40", Offset = "0x107EB40", VA = "0x18107FB40", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x107F110", Offset = "0x107E110", VA = "0x18107F110", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public object? NEDEMIOEJCP
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x868820", Offset = "0x867820", VA = "0x180868820")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x868800", Offset = "0x867800", VA = "0x180868800")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool OFLLKLACFCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x3D941E0", Offset = "0x3D931E0", VA = "0x183D941E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x3D965B0", Offset = "0x3D955B0", VA = "0x183D965B0")]
	public bool PBGBCGOCNGM(T CBAEIEAPLIH, object OEDJKICDDGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x3C9AFF0", Offset = "0x3C99FF0", VA = "0x183C9AFF0")]
	public bool JHPDIDIEFLE(object OEDJKICDDGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x3C7A0E0", Offset = "0x3C790E0", VA = "0x183C7A0E0")]
	public void OAIAOCAHOEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x3D94360", Offset = "0x3D93360", VA = "0x183D94360")]
	public bool MMCLNKMOKEF(object OEDJKICDDGA, [Out] T CBAEIEAPLIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x3D950D0", Offset = "0x3D940D0", VA = "0x183D950D0")]
	[DMMOHDONLFE("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool OHFJJEKHMLL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x3C9B880", Offset = "0x3C9A880", VA = "0x183C9B880")]
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
		[Cpp2IlInjected.Address(RVA = "0x37FE8D0", Offset = "0x37FD8D0", VA = "0x1837FE8D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int FGAKKPCAMNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x37FEE40", Offset = "0x37FDE40", VA = "0x1837FEE40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x37FEBB0", Offset = "0x37FDBB0", VA = "0x1837FEBB0")]
	public void MJFEDCBJOBF(T OEDJKICDDGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x37FEA00", Offset = "0x37FDA00", VA = "0x1837FEA00")]
	public void GAGDAFIMOPK(T OEDJKICDDGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x37FEFF0", Offset = "0x37FDFF0", VA = "0x1837FEFF0")]
	public void PMEFIDEFMLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x37FF040", Offset = "0x37FE040", VA = "0x1837FF040", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
	public EDKHENFJMJA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal static class MNCGBCHEDHH
{
	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x294C230", Offset = "0x294B230", VA = "0x18294C230")]
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
			[Cpp2IlInjected.Address(RVA = "0x6A46740", Offset = "0x6A45740", VA = "0x186A46740")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x6A468B0", Offset = "0x6A458B0", VA = "0x186A468B0")]
		public MHPFDPCMAMA(float ODFMKGCLIGE, float EACEIFBMGMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x6A46750", Offset = "0x6A45750", VA = "0x186A46750", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
		public AHEIKOFAOEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x6A43120", Offset = "0x6A42120", VA = "0x186A43120")]
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
		[Cpp2IlInjected.Address(RVA = "0x6A454B0", Offset = "0x6A444B0", VA = "0x186A454B0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x6A45360", Offset = "0x6A44360", VA = "0x186A45360", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x6A45570", Offset = "0x6A44570", VA = "0x186A45570")]
	public GHDHKPLGDOG(int NAFKLJDAKHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6A45420", Offset = "0x6A44420", VA = "0x186A45420")]
	public JPGEAIOKJKE IMLOHDIIMHN(MHPFDPCMAMA FKCOHIKICFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6A44DE0", Offset = "0x6A43DE0", VA = "0x186A44DE0")]
	public void AALNDFPBAFO(CEMIAKLHGHA JEDCNCCGILG, [Optional] MHPFDPCMAMA LJODCGNMGJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6A45250", Offset = "0x6A44250", VA = "0x186A45250", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x6A46B90", Offset = "0x6A45B90", VA = "0x186A46B90")]
		public NPKAOBIDIHB(CEMIAKLHGHA ALKCKHEPNOC, KFLGADPIJKL AHJILKLLLDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x6A46B40", Offset = "0x6A45B40", VA = "0x186A46B40", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6A46AD0", Offset = "0x6A45AD0", VA = "0x186A46AD0")]
	internal static bool FAGPFPCNDCM(float FAGKOOGCGBH, float HEOHCJKCOLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6A35D40", Offset = "0x6A34D40", VA = "0x186A35D40")]
	internal static float FONGDGFCKBB(float FAGKOOGCGBH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x6A46A10", Offset = "0x6A45A10", VA = "0x186A46A10")]
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
		[Cpp2IlInjected.Address(RVA = "0x6A460D0", Offset = "0x6A450D0", VA = "0x186A460D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event KFLGADPIJKL? BPLPOHONNBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x6A461C0", Offset = "0x6A451C0", VA = "0x186A461C0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x6A46030", Offset = "0x6A45030", VA = "0x186A46030", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
	public JPGEAIOKJKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public interface EABICGABAJG<T> where T : class, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ICOHMMKHIOI<T> EBAPBDCJHHO([Out] T CBAEIEAPLIH);

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OAIAOCAHOEL();
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class DNOMMKCACED<T> : EABICGABAJG<T> where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly ConcurrentStack<T> MMOEOOCGGML;

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x5867120", Offset = "0x5866120", VA = "0x185867120", Slot = "4")]
	public ICOHMMKHIOI<T> EBAPBDCJHHO([Out] T CBAEIEAPLIH)
	{
		return default(ICOHMMKHIOI<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x58671C0", Offset = "0x58661C0", VA = "0x1858671C0")]
	public void HLGENIPLFCF(T IPFOIOFKBGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x3805480", Offset = "0x3804480", VA = "0x183805480", Slot = "5")]
	public void OAIAOCAHOEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350", Slot = "6")]
	protected virtual void DCGPHBMHIEM(T IDFHDFCLMOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x5867070", Offset = "0x5866070", VA = "0x185867070")]
	private T BDJJCDMMBKL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x5867240", Offset = "0x5866240", VA = "0x185867240")]
	public DNOMMKCACED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public readonly struct ICOHMMKHIOI<T> : IDisposable where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly T IPFOIOFKBGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly DNOMMKCACED<T> LELPBFPMPGI;

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0xAB8760", Offset = "0xAB7760", VA = "0x180AB8760")]
	internal ICOHMMKHIOI(T CBAEIEAPLIH, DNOMMKCACED<T> LELPBFPMPGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x3EBC7F0", Offset = "0x3EBB7F0", VA = "0x183EBC7F0", Slot = "4")]
	void IDisposable.Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class OMFMIDNIIHK : DNOMMKCACED<StringBuilder>
{
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public static readonly OMFMIDNIIHK IBMHAACFGKI;

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x6A46CA0", Offset = "0x6A45CA0", VA = "0x186A46CA0")]
	public static ICOHMMKHIOI<StringBuilder> BDJJCDMMBKL([Out] StringBuilder CBAEIEAPLIH)
	{
		return default(ICOHMMKHIOI<StringBuilder>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x6A46D40", Offset = "0x6A45D40", VA = "0x186A46D40", Slot = "6")]
	protected override void DCGPHBMHIEM(StringBuilder IDFHDFCLMOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x6A46E00", Offset = "0x6A45E00", VA = "0x186A46E00")]
	public OMFMIDNIIHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class PCDDOABCJHI : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x64B82C0", Offset = "0x64B72C0", VA = "0x1864B82C0")]
	public PCDDOABCJHI(string NFOHONOFFAP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
[DefaultMember("Item")]
public class MDKJBFLFJFI<TKey, TValue> : NOLCBHKJIPA<TKey, TValue>, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, KKLHPJOJDDH where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private sealed class BMIPDMIICAA : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private KeyValuePair<TKey, TValue> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public MDKJBFLFJFI<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private IEnumerator<KeyValuePair<TKey, TValue>> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		KeyValuePair<TKey, TValue> IEnumerator<KeyValuePair<TKey, TValue>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x107FB40", Offset = "0x107EB40", VA = "0x18107FB40", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TValue>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x4EA6E30", Offset = "0x4EA5E30", VA = "0x184EA6E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x86B3A0", Offset = "0x86A3A0", VA = "0x18086B3A0")]
		[DebuggerHidden]
		public BMIPDMIICAA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x3983E30", Offset = "0x3982E30", VA = "0x183983E30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x4EA69A0", Offset = "0x4EA59A0", VA = "0x184EA69A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x4EA6D90", Offset = "0x4EA5D90", VA = "0x184EA6D90")]
		private void PEOGCCBKFKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x4EA6950", Offset = "0x4EA5950", VA = "0x184EA6950")]
		private void LAOHPFDNJCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x4EA6DE0", Offset = "0x4EA5DE0", VA = "0x184EA6DE0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private readonly NOLCBHKJIPA<TKey, TValue> GNNMGPOCMJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private readonly IDictionary<TKey, TValue> ODEDDGDDBPJ;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int FGAKKPCAMNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x44D97C0", Offset = "0x44D87C0", VA = "0x1844D97C0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool FAOLOMOFDJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x8ADFC0", Offset = "0x8ACFC0", VA = "0x1808ADFC0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public TValue PGDICMLLHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x44D9A70", Offset = "0x44D8A70", VA = "0x1844D9A70", Slot = "4")]
		get
		{
			return (TValue)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x44D9D20", Offset = "0x44D8D20", VA = "0x1844D9D20", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public ICollection<TKey> NHIDLCIOKPK
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x44D9AC0", Offset = "0x44D8AC0", VA = "0x1844D9AC0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public ICollection<TValue> HLMNKOOFAJL
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x44D9BF0", Offset = "0x44D8BF0", VA = "0x1844D9BF0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x44D96F0", Offset = "0x44D86F0", VA = "0x1844D96F0")]
	public MDKJBFLFJFI(NOLCBHKJIPA<TKey, TValue> GNNMGPOCMJN, [Optional] IDictionary<TKey, TValue>? ODEDDGDDBPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x44D6EF0", Offset = "0x44D5EF0", VA = "0x1844D6EF0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x44D7D00", Offset = "0x44D6D00", VA = "0x1844D7D00")]
	public void JMHFJGOIEKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x44D6B60", Offset = "0x44D5B60", VA = "0x1844D6B60", Slot = "9")]
	public void Add(TKey BHEIPBKEDLG, TValue CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x44D78C0", Offset = "0x44D68C0", VA = "0x1844D78C0")]
	public void DOEFGCOLLOD(TKey BHEIPBKEDLG, TValue CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x44D7E20", Offset = "0x44D6E20", VA = "0x1844D7E20")]
	public void KEBPLJPJLLP(TKey BHEIPBKEDLG, TValue CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x44D8250", Offset = "0x44D7250", VA = "0x1844D8250")]
	public void KNLFOCJOHAK(TKey BHEIPBKEDLG, TValue CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x44D8990", Offset = "0x44D7990", VA = "0x1844D8990")]
	public void NJCPONHEKDL(TKey BHEIPBKEDLG, TValue CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x44D8D00", Offset = "0x44D7D00", VA = "0x1844D8D00", Slot = "14")]
	void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> OPNLGJFHDEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x44D8F40", Offset = "0x44D7F40", VA = "0x1844D8F40", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> OPNLGJFHDEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x44D9100", Offset = "0x44D8100", VA = "0x1844D9100", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> OPNLGJFHDEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x44D7030", Offset = "0x44D6030", VA = "0x1844D7030", Slot = "8")]
	public bool ContainsKey(TKey BHEIPBKEDLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x44D7C30", Offset = "0x44D6C30", VA = "0x1844D7C30")]
	public bool JHIIJIGBEMK(TKey BHEIPBKEDLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x44D87D0", Offset = "0x44D77D0", VA = "0x1844D87D0")]
	public bool LCHPLHMCCPK(TKey BHEIPBKEDLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x44D8B50", Offset = "0x44D7B50", VA = "0x1844D8B50", Slot = "10")]
	public bool Remove(TKey BHEIPBKEDLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x44D9540", Offset = "0x44D8540", VA = "0x1844D9540", Slot = "11")]
	public bool TryGetValue(TKey BHEIPBKEDLG, [Out] TValue CBAEIEAPLIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x44D75A0", Offset = "0x44D65A0", VA = "0x1844D75A0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TValue>[] GGEMIJICFPG, int MCEFCKDGOEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x41C1760", Offset = "0x41C0760", VA = "0x1841C1760", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x44D7B20", Offset = "0x44D6B20", VA = "0x1844D7B20", Slot = "19")]
	[IteratorStateMachine(typeof(MDKJBFLFJFI<, >.BMIPDMIICAA))]
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x44D69E0", Offset = "0x44D59E0", VA = "0x1844D69E0", Slot = "21")]
	public bool AEACFPILGAI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x44D8660", Offset = "0x44D7660", VA = "0x1844D8660")]
	private TValue KPEJMDONECH(TKey BHEIPBKEDLG)
	{
		return (TValue)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public interface KKLHPJOJDDH
{
	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AEACFPILGAI();
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public interface NOLCBHKJIPA<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, KKLHPJOJDDH
{
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[DefaultMember("Item")]
public sealed class FMHCEMJFILO<TKey, TVal> : NOLCBHKJIPA<TKey, TVal>, IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, KKLHPJOJDDH where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public delegate int LHIDMCLNDKJ(TKey BHEIPBKEDLG, TVal CBAEIEAPLIH);

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public delegate void FIAPIJMBIFO(TKey BHEIPBKEDLG, TVal CBAEIEAPLIH, PFILCAPGHIC CLPBFEAPBCA);

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private class EPDBGJBGGGG
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public TKey IGAHPOGKKJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x8D74E0", Offset = "0x8D64E0", VA = "0x1808D74E0")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public TVal BLBBIKKJHJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x8DB860", Offset = "0x8DA860", VA = "0x1808DB860")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x8DBE20", Offset = "0x8DAE20", VA = "0x1808DBE20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public int PMILGDKKIIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x8A4FC0", Offset = "0x8A3FC0", VA = "0x1808A4FC0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x8A4DF0", Offset = "0x8A3DF0", VA = "0x1808A4DF0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public DateTimeOffset DBIOPIAJPME
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0xC43C10", Offset = "0xC42C10", VA = "0x180C43C10")]
			[CompilerGenerated]
			get
			{
				return default(DateTimeOffset);
			}
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x14E7010", Offset = "0x14E6010", VA = "0x1814E7010")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x3858370", Offset = "0x3857370", VA = "0x183858370")]
		public EPDBGJBGGGG(TKey BHEIPBKEDLG, TVal LECBAKCNNCK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class FANADKEGHAB : IEnumerator<KeyValuePair<TKey, TVal>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private KeyValuePair<TKey, TVal> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public FMHCEMJFILO<TKey, TVal> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private LinkedList<EPDBGJBGGGG>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		KeyValuePair<TKey, TVal> IEnumerator<KeyValuePair<TKey, TVal>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x107FB40", Offset = "0x107EB40", VA = "0x18107FB40", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TVal>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x3ADAD10", Offset = "0x3AD9D10", VA = "0x183ADAD10", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x86B3A0", Offset = "0x86A3A0", VA = "0x18086B3A0")]
		[DebuggerHidden]
		public FANADKEGHAB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x397F010", Offset = "0x397E010", VA = "0x18397F010", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x3C31F10", Offset = "0x3C30F10", VA = "0x183C31F10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x3C32EA0", Offset = "0x3C31EA0", VA = "0x183C32EA0")]
		private void PEOGCCBKFKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x3C33130", Offset = "0x3C32130", VA = "0x183C33130", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public const int KCAOCJIHKJK = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly Dictionary<TKey, LinkedListNode<EPDBGJBGGGG>> ELLEMHLLLLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly LinkedList<EPDBGJBGGGG> GIEKMDKBHKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly LHIDMCLNDKJ? KJIMOENDFEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly TimeSpan GMHPGPEGHBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly FIAPIJMBIFO? OEIKNGELFAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly JICBKFOJJHG FPCJDOBMIEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private bool LLDGLDJDHMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly List<TKey> EEOHBOMFBNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly List<TVal> AAKMCHIMLJB;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int BDJKBNBIKDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x8753F0", Offset = "0x8743F0", VA = "0x1808753F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	internal int IHEILCDDDHM
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0xB11D20", Offset = "0xB10D20", VA = "0x180B11D20")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0xB11740", Offset = "0xB10740", VA = "0x180B11740")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int FGAKKPCAMNO
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x3C80F60", Offset = "0x3C7FF60", VA = "0x183C80F60", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	internal int IGCGNKBIMMF
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x3C7A0E0", Offset = "0x3C790E0", VA = "0x183C7A0E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public ICollection<TVal> HLMNKOOFAJL
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x3C810D0", Offset = "0x3C800D0", VA = "0x183C810D0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	ICollection<TKey> IDictionary<TKey, TVal>.GGNGAMNIDCA
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x3C7EC90", Offset = "0x3C7DC90", VA = "0x183C7EC90", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool FAOLOMOFDJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x8ADFC0", Offset = "0x8ACFC0", VA = "0x1808ADFC0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public TVal PGDICMLLHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x3C81070", Offset = "0x3C80070", VA = "0x183C81070", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x3C81120", Offset = "0x3C80120", VA = "0x183C81120", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x3C7A520", Offset = "0x3C79520", VA = "0x183C7A520")]
	private bool NECAJNIOEOB(int NAFKLJDAKHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x3C7DE90", Offset = "0x3C7CE90", VA = "0x183C7DE90")]
	private void PIKDCHONFDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x3C7FD80", Offset = "0x3C7ED80", VA = "0x183C7FD80")]
	public FMHCEMJFILO(int NAFKLJDAKHD, [Optional] LHIDMCLNDKJ? KJIMOENDFEO, [Optional] IEqualityComparer<TKey>? BJLAODBBCMC, [Optional] FIAPIJMBIFO? OEIKNGELFAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x3C7FD00", Offset = "0x3C7ED00", VA = "0x183C7FD00")]
	public FMHCEMJFILO(TimeSpan GMHPGPEGHBB, [Optional] IEqualityComparer<TKey>? BJLAODBBCMC, [Optional] FIAPIJMBIFO? OEIKNGELFAK, [Optional] JICBKFOJJHG? FPCJDOBMIEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x3C7F800", Offset = "0x3C7E800", VA = "0x183C7F800")]
	public FMHCEMJFILO(int NAFKLJDAKHD, TimeSpan GMHPGPEGHBB, [Optional] IEqualityComparer<TKey>? BJLAODBBCMC, [Optional] FIAPIJMBIFO? OEIKNGELFAK, [Optional] JICBKFOJJHG? FPCJDOBMIEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x3C80AE0", Offset = "0x3C7FAE0", VA = "0x183C80AE0")]
	public FMHCEMJFILO(int NAFKLJDAKHD, LHIDMCLNDKJ? KJIMOENDFEO, TimeSpan GMHPGPEGHBB, [Optional] IEqualityComparer<TKey>? BJLAODBBCMC, [Optional] FIAPIJMBIFO? OEIKNGELFAK, [Optional] JICBKFOJJHG? FPCJDOBMIEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x3C743A0", Offset = "0x3C733A0", VA = "0x183C743A0", Slot = "21")]
	public bool AEACFPILGAI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x3C76D70", Offset = "0x3C75D70", VA = "0x183C76D70", Slot = "22")]
	public bool CAIHABGDKBM(int ENCFHCJIMBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x3C7C6D0", Offset = "0x3C7B6D0", VA = "0x183C7C6D0")]
	private bool OKFEINFCBKK(int ENCFHCJIMBE, PFILCAPGHIC CLPBFEAPBCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x3C7A280", Offset = "0x3C79280", VA = "0x183C7A280")]
	public void LHLEJLJODIO(TKey BHEIPBKEDLG, TVal CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x3C75D60", Offset = "0x3C74D60", VA = "0x183C75D60", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> OPNLGJFHDEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x3C76160", Offset = "0x3C75160", VA = "0x183C76160", Slot = "9")]
	public void Add(TKey BHEIPBKEDLG, TVal CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x3C770E0", Offset = "0x3C760E0", VA = "0x183C770E0", Slot = "8")]
	public bool ContainsKey(TKey BHEIPBKEDLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x3C7E900", Offset = "0x3C7D900", VA = "0x183C7E900", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Contains(KeyValuePair<TKey, TVal> OPNLGJFHDEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x3C7E600", Offset = "0x3C7D600", VA = "0x183C7E600", Slot = "10")]
	public bool Remove(TKey BHEIPBKEDLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x3C7E9F0", Offset = "0x3C7D9F0", VA = "0x183C7E9F0", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Remove(KeyValuePair<TKey, TVal> OPNLGJFHDEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x3C7A570", Offset = "0x3C79570", VA = "0x183C7A570")]
	private bool NMOOPAJILOI(TKey BHEIPBKEDLG, [Out] TVal CBAEIEAPLIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x3C765F0", Offset = "0x3C755F0", VA = "0x183C765F0")]
	private TVal BDJJCDMMBKL(TKey LAGEFHPKEIC)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x3C7F170", Offset = "0x3C7E170", VA = "0x183C7F170", Slot = "11")]
	public bool TryGetValue(TKey LAGEFHPKEIC, [Out] TVal CBAEIEAPLIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x3C76ED0", Offset = "0x3C75ED0", VA = "0x183C76ED0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x3C77BC0", Offset = "0x3C76BC0", VA = "0x183C77BC0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] GGEMIJICFPG, int MCEFCKDGOEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x3C75820", Offset = "0x3C74820", VA = "0x183C75820")]
	private void AKNOHBLJEHO(TKey BHEIPBKEDLG, TVal LECBAKCNNCK, PFILCAPGHIC CLPBFEAPBCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x3C75210", Offset = "0x3C74210", VA = "0x183C75210")]
	private bool AKLNIJOKMML(EPDBGJBGGGG HCCGMGOAADA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x3C79400", Offset = "0x3C78400", VA = "0x183C79400")]
	private void EJJNNKPEOND(LinkedListNode<EPDBGJBGGGG> BKFBCMIDLBG, TVal KPJPGFGPJMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x3C7DB10", Offset = "0x3C7CB10", VA = "0x183C7DB10")]
	private void PBGBCGOCNGM(TKey BHEIPBKEDLG, TVal CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x3C74CD0", Offset = "0x3C73CD0", VA = "0x183C74CD0")]
	private void AFEKELPIMGF(EPDBGJBGGGG HCCGMGOAADA, TVal KPJPGFGPJMK, int IACFIIENNFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x3C79F80", Offset = "0x3C78F80", VA = "0x183C79F80", Slot = "19")]
	[IteratorStateMachine(typeof(FMHCEMJFILO<, >.FANADKEGHAB))]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x3C7ECE0", Offset = "0x3C7DCE0", VA = "0x183C7ECE0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public enum PFILCAPGHIC : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	Evicted,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	RemovedViaRemove,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	RemovedViaClear,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	Overwritten
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class DMHOGDEDNNL<TKey> : Exception where TKey : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public readonly TKey HEJJPONMPBK;

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x58612D0", Offset = "0x58602D0", VA = "0x1858612D0")]
	public DMHOGDEDNNL(TKey MEBIPHMLPPI, Exception EEOIAMFNMDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class JJLDDCOIEKM : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x5DA0490", Offset = "0x5D9F490", VA = "0x185DA0490")]
	public JJLDDCOIEKM(string NFOHONOFFAP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class KMPILIIFONB<TId, TResource> : IEnumerable<(TId, Task<TResource>, int)>, IEnumerable where TId : notnull where TResource : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class LHMINFBOHMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public Func<TId, CancellationToken, Task<TResource>> factory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public KMPILIIFONB<TId, TResource> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
		public LHMINFBOHMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x42DF680", Offset = "0x42DE680", VA = "0x1842DF680")]
		internal Task<TResource> HKNMCBOJGLL(TId _id)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private struct MDGJNAKKHGE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public KMPILIIFONB<TId, TResource> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x44D5EC0", Offset = "0x44D4EC0", VA = "0x1844D5EC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x44D6820", Offset = "0x44D5820", VA = "0x1844D6820", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private struct BDEJKNDDOBA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public Dictionary<Task<TResource>, CancellationTokenSource> cancellationTokenSources;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public CancellationTokenSource cts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x4E78670", Offset = "0x4E77670", VA = "0x184E78670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x4E793D0", Offset = "0x4E783D0", VA = "0x184E793D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly DNONAAAOGON<TId, Task<TResource>> OLOAKIJKJEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly Dictionary<Task<TResource>, CancellationTokenSource> KFOCGPKLMBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly Func<TId, CancellationToken, Task<TResource>>? JMPNHJHFBNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly Action<TResource>? HDAKLKBMOLP;

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x422F840", Offset = "0x422E840", VA = "0x18422F840")]
	public KMPILIIFONB(int MFMBBAGJHLE = 0, [Optional] IEqualityComparer<TId>? NBBHDALODBG, [Optional] Func<TId, CancellationToken, Task<TResource>>? JFILKDJICOM, [Optional] Action<TResource>? FNJOBPDOPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x422EB40", Offset = "0x422DB40", VA = "0x18422EB40")]
	public BCBDLBGONLF<Task<TResource>> ECLIHBNIDDO(TId BLCJLIJFBDL, [Optional] Func<TId, CancellationToken, Task<TResource>>? JFILKDJICOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x422E1F0", Offset = "0x422D1F0", VA = "0x18422E1F0")]
	private void DNKELGKLJFP(Task<TResource> PEBIPFJADEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x422F550", Offset = "0x422E550", VA = "0x18422F550")]
	[AsyncStateMachine(typeof(KMPILIIFONB<, >.MDGJNAKKHGE))]
	private Task OACFFOJBLDB(Task<TResource> PEBIPFJADEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x422F1F0", Offset = "0x422E1F0", VA = "0x18422F1F0")]
	public void MNLMFOIGPCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x422DF40", Offset = "0x422CF40", VA = "0x18422DF40")]
	public DNONAAAOGON<TId, Task<TResource>>.ACMIKNAKBHK AKHPNFMFJMK()
	{
		return default(DNONAAAOGON<TId, Task<TResource>>.ACMIKNAKBHK);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x422F650", Offset = "0x422E650", VA = "0x18422F650", Slot = "4")]
	private IEnumerator<(TId, Task<TResource>, int)> System.Collections.Generic.IEnumerable<(TIdId,System.Threading.Tasks.Task<TResource>LoadResourceTask,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x422F650", Offset = "0x422E650", VA = "0x18422F650", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x422EF90", Offset = "0x422DF90", VA = "0x18422EF90")]
	[AsyncStateMachine(typeof(KMPILIIFONB<, >.BDEJKNDDOBA))]
	[CompilerGenerated]
	internal static Task KNMIOCNPLHH(Task<TResource> PEBIPFJADEI, CancellationTokenSource BICNBDHNPOJ, Dictionary<Task<TResource>, CancellationTokenSource> MEFJHCPPDPL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class DNONAAAOGON<TKey, TValue> : IEnumerable<(TKey, TValue, int)>, IEnumerable where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	private sealed class IPMDDBFOELB : IEquatable<IPMDDBFOELB>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public readonly TValue BLBBIKKJHJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public int FCDPDIPEECD;

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x964440", Offset = "0x963440", VA = "0x180964440")]
		public IPMDDBFOELB(TValue CBAEIEAPLIH, int KMEOGCMHOFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x3EE9A90", Offset = "0x3EE8A90", VA = "0x183EE9A90", Slot = "4")]
		public bool Equals(IPMDDBFOELB? LJAAPFIIPOF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x3EE9B20", Offset = "0x3EE8B20", VA = "0x183EE9B20", Slot = "0")]
		public override bool Equals(object? HBFCGFKGCAF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x3EE9CF0", Offset = "0x3EE8CF0", VA = "0x183EE9CF0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct ACMIKNAKBHK : IEnumerator<(TKey, TValue, int)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private Dictionary<TKey, IPMDDBFOELB>.Enumerator MIGHOOOGKDF;

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x3CE3DF0", Offset = "0x3CE2DF0", VA = "0x183CE3DF0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public (TKey Key, TValue Value, int RefCount) NKNICMABPJA
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x3CE4260", Offset = "0x3CE3260", VA = "0x183CE4260", Slot = "4")]
			get
			{
				return default((TKey, TValue, int));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x3CE40B0", Offset = "0x3CE30B0", VA = "0x183CE40B0")]
		public ACMIKNAKBHK(DNONAAAOGON<TKey, TValue> OLGJECBHAKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x3CE3A30", Offset = "0x3CE2A30", VA = "0x183CE3A30", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x3CE3AF0", Offset = "0x3CE2AF0", VA = "0x183CE3AF0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x3CE3C90", Offset = "0x3CE2C90", VA = "0x183CE3C90", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private sealed class LJCDPDJJDNH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public DNONAAAOGON<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public TKey key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public IPMDDBFOELB refCountedValue;

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
		public LJCDPDJJDNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x42E6EB0", Offset = "0x42E5EB0", VA = "0x1842E6EB0")]
		internal void HKNMCBOJGLL()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly Dictionary<TKey, IPMDDBFOELB> IECLMOBPIPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly Func<TKey, TValue>? ICIJINHEOAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly Action<TValue>? EKFKLAIPPPG;

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x5868CB0", Offset = "0x5867CB0", VA = "0x185868CB0")]
	public DNONAAAOGON(int MFMBBAGJHLE = 0, [Optional] IEqualityComparer<TKey>? BJLAODBBCMC, [Optional] Func<TKey, TValue>? GHPLGDEIDED, [Optional] Action<TValue>? GOIILIGLGED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x5867D50", Offset = "0x5866D50", VA = "0x185867D50")]
	public BCBDLBGONLF<TValue> ECLIHBNIDDO(TKey BHEIPBKEDLG, [Optional] Func<TKey, TValue>? GHIDHABMDKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x5868080", Offset = "0x5867080", VA = "0x185868080")]
	private void HLGENIPLFCF(TKey BHEIPBKEDLG, IPMDDBFOELB LAHBJEMCMJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x5868450", Offset = "0x5867450", VA = "0x185868450")]
	public void MNLMFOIGPCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x58672F0", Offset = "0x58662F0", VA = "0x1858672F0")]
	public ACMIKNAKBHK AKHPNFMFJMK()
	{
		return default(ACMIKNAKBHK);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x5868AC0", Offset = "0x5867AC0", VA = "0x185868AC0", Slot = "4")]
	private IEnumerator<(TKey, TValue, int)> System.Collections.Generic.IEnumerable<(TKeyKey,TValueValue,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x5868AC0", Offset = "0x5867AC0", VA = "0x185868AC0", Slot = "5")]
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
