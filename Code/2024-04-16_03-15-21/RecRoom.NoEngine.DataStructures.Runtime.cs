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
		[Cpp2IlInjected.Address(RVA = "0x7DEA50", Offset = "0x7DDC50", VA = "0x1807DEA50")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x61EB190", Offset = "0x61EA390", VA = "0x1861EB190")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7DED90", Offset = "0x7DDF90", VA = "0x1807DED90")]
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
		[Cpp2IlInjected.Address(RVA = "0x7DEDD0", Offset = "0x7DDFD0", VA = "0x1807DEDD0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class AMMLKJPGHGN
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	protected AMMLKJPGHGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class CPHLFPAHDJA<T> : AMMLKJPGHGN
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	protected struct AEFBLPDEKNM
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public enum NEALKNGOEFL
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
		public NEALKNGOEFL MJMAEGDPBNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public T OFOIHENMFDE;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private int FPFIBCNFFEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool OKIIPEENJOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	protected readonly bool AGANDGFGPKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	protected List<T>? NCJNHBKOGJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<AEFBLPDEKNM>? GOABJOEHNIP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool OMHKPPJELPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4BEF870", Offset = "0x4BEEA70", VA = "0x184BEF870")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4BEF960", Offset = "0x4BEEB60", VA = "0x184BEF960")]
	protected CPHLFPAHDJA(bool AGANDGFGPKD, bool OKIIPEENJOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4BEF8C0", Offset = "0x4BEEAC0", VA = "0x184BEF8C0")]
	protected bool HMCKAFEOEOF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4BEF0E0", Offset = "0x4BEE2E0", VA = "0x184BEF0E0")]
	protected void AKPFIKGPIPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4BEF1D0", Offset = "0x4BEE3D0", VA = "0x184BEF1D0")]
	protected void CEDBPCILBIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2666CB0", Offset = "0x2665EB0", VA = "0x182666CB0")]
	private static void HPOEHOKLFGJ<U>(List<U>? LBDHFFKKBHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4BEF6B0", Offset = "0x4BEE8B0", VA = "0x184BEF6B0", Slot = "4")]
	public void GHBEENLPKLN(T OFOIHENMFDE, bool DEOLHONPAMN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4BEF510", Offset = "0x4BEE710", VA = "0x184BEF510", Slot = "5")]
	public void FBCLMIGJMFH(T OFOIHENMFDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4BEF3A0", Offset = "0x4BEE5A0", VA = "0x184BEF3A0")]
	public void DBHKOJLPIHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface IJANLEIAENC
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GHBEENLPKLN(Action OFOIHENMFDE, bool DEOLHONPAMN = false);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FBCLMIGJMFH(Action OFOIHENMFDE);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class DPAIEAIPOBP : CPHLFPAHDJA<Action>, IJANLEIAENC
{
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x61E9670", Offset = "0x61E8870", VA = "0x1861E9670")]
	public DPAIEAIPOBP(bool AGANDGFGPKD = false, bool OKIIPEENJOF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x61E9410", Offset = "0x61E8610", VA = "0x1861E9410")]
	public void LKEHCEHOLJP()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x61E9610", Offset = "0x61E8810", VA = "0x1861E9610")]
	public static DPAIEAIPOBP OLHFJEIKJLB(DPAIEAIPOBP JOOGPGJMKJF, Action OFOIHENMFDE)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x61E93B0", Offset = "0x61E85B0", VA = "0x1861E93B0")]
	public static DPAIEAIPOBP BCJDOINJGCB(DPAIEAIPOBP JOOGPGJMKJF, Action OFOIHENMFDE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface GGMNKAPLACO<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GHBEENLPKLN(Action<T> OFOIHENMFDE, bool DEOLHONPAMN = false);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FBCLMIGJMFH(Action<T> OFOIHENMFDE);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public sealed class CNGIJFFLIEN<T> : CPHLFPAHDJA<Action<T>>, GGMNKAPLACO<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x342B930", Offset = "0x342AB30", VA = "0x18342B930")]
	public CNGIJFFLIEN(bool AGANDGFGPKD = false, bool OKIIPEENJOF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4BE53E0", Offset = "0x4BE45E0", VA = "0x184BE53E0")]
	public void LKEHCEHOLJP(T EEEPNFLJEFK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x342B8A0", Offset = "0x342AAA0", VA = "0x18342B8A0")]
	public static CNGIJFFLIEN<T> OLHFJEIKJLB(CNGIJFFLIEN<T> JOOGPGJMKJF, Action<T> OFOIHENMFDE)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x342B060", Offset = "0x342A260", VA = "0x18342B060")]
	public static CNGIJFFLIEN<T> BCJDOINJGCB(CNGIJFFLIEN<T> JOOGPGJMKJF, Action<T> OFOIHENMFDE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface BDAFNGKNFGB<T, U> where T : notnull where U : notnull
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class DOEOOCEHEOD<T, U> : CPHLFPAHDJA<Action<T, U>>, BDAFNGKNFGB<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x342B930", Offset = "0x342AB30", VA = "0x18342B930")]
	public DOEOOCEHEOD(bool AGANDGFGPKD = false, bool OKIIPEENJOF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x50AFFB0", Offset = "0x50AF1B0", VA = "0x1850AFFB0")]
	public void LKEHCEHOLJP(T EEEPNFLJEFK, U HKBEGEFJFEE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x342B8A0", Offset = "0x342AAA0", VA = "0x18342B8A0")]
	public static DOEOOCEHEOD<T, U> OLHFJEIKJLB(DOEOOCEHEOD<T, U> JOOGPGJMKJF, Action<T, U> OFOIHENMFDE)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x342B060", Offset = "0x342A260", VA = "0x18342B060")]
	public static DOEOOCEHEOD<T, U> BCJDOINJGCB(DOEOOCEHEOD<T, U> JOOGPGJMKJF, Action<T, U> OFOIHENMFDE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class HCBENJCDKAD<T, U, V> : CPHLFPAHDJA<Action<T, U, V>> where T : notnull where U : notnull where V : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x342B930", Offset = "0x342AB30", VA = "0x18342B930")]
	public HCBENJCDKAD(bool AGANDGFGPKD = false, bool OKIIPEENJOF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3941FD0", Offset = "0x39411D0", VA = "0x183941FD0")]
	public void LKEHCEHOLJP(T EEEPNFLJEFK, U HKBEGEFJFEE, V EACOJHAMHEA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x342B8A0", Offset = "0x342AAA0", VA = "0x18342B8A0")]
	public static HCBENJCDKAD<T, U, V> OLHFJEIKJLB(HCBENJCDKAD<T, U, V> JOOGPGJMKJF, Action<T, U, V> OFOIHENMFDE)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x342B060", Offset = "0x342A260", VA = "0x18342B060")]
	public static HCBENJCDKAD<T, U, V> BCJDOINJGCB(HCBENJCDKAD<T, U, V> JOOGPGJMKJF, Action<T, U, V> OFOIHENMFDE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface KBFCEIDKPFM<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class MMLJOFDDCKJ<T, U, V, W> : CPHLFPAHDJA<Action<T, U, V, W>>, KBFCEIDKPFM<T, U, V, W> where T : notnull where U : notnull where V : notnull where W : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x342B930", Offset = "0x342AB30", VA = "0x18342B930")]
	public MMLJOFDDCKJ(bool AGANDGFGPKD = false, bool OKIIPEENJOF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3F488D0", Offset = "0x3F47AD0", VA = "0x183F488D0")]
	public void LKEHCEHOLJP(T EEEPNFLJEFK, U HKBEGEFJFEE, V EACOJHAMHEA, W HDJLHPPJJLL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x342B8A0", Offset = "0x342AAA0", VA = "0x18342B8A0")]
	public static MMLJOFDDCKJ<T, U, V, W> OLHFJEIKJLB(MMLJOFDDCKJ<T, U, V, W> JOOGPGJMKJF, Action<T, U, V, W> OFOIHENMFDE)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x342B060", Offset = "0x342A260", VA = "0x18342B060")]
	public static MMLJOFDDCKJ<T, U, V, W> BCJDOINJGCB(MMLJOFDDCKJ<T, U, V, W> JOOGPGJMKJF, Action<T, U, V, W> OFOIHENMFDE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class EKDMNLHGBKA<T, U, V, W, X> : CPHLFPAHDJA<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x342B930", Offset = "0x342AB30", VA = "0x18342B930")]
	public EKDMNLHGBKA(bool AGANDGFGPKD = false, bool OKIIPEENJOF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x342B0F0", Offset = "0x342A2F0", VA = "0x18342B0F0")]
	public void LKEHCEHOLJP(T EEEPNFLJEFK, U HKBEGEFJFEE, V EACOJHAMHEA, W HDJLHPPJJLL, X EFCGILCAOIA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x342B8A0", Offset = "0x342AAA0", VA = "0x18342B8A0")]
	public static EKDMNLHGBKA<T, U, V, W, X> OLHFJEIKJLB(EKDMNLHGBKA<T, U, V, W, X> JOOGPGJMKJF, Action<T, U, V, W, X> OFOIHENMFDE)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x342B060", Offset = "0x342A260", VA = "0x18342B060")]
	public static EKDMNLHGBKA<T, U, V, W, X> BCJDOINJGCB(EKDMNLHGBKA<T, U, V, W, X> JOOGPGJMKJF, Action<T, U, V, W, X> OFOIHENMFDE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class NDNGLGHMJHK<T, U, V, W, X, Y> : CPHLFPAHDJA<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x342B930", Offset = "0x342AB30", VA = "0x18342B930")]
	public NDNGLGHMJHK(bool AGANDGFGPKD = false, bool OKIIPEENJOF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3FC81A0", Offset = "0x3FC73A0", VA = "0x183FC81A0")]
	public void LKEHCEHOLJP(T EEEPNFLJEFK, U HKBEGEFJFEE, V EACOJHAMHEA, W HDJLHPPJJLL, X EFCGILCAOIA, Y DDIIOJEJOLI)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x342B8A0", Offset = "0x342AAA0", VA = "0x18342B8A0")]
	public static NDNGLGHMJHK<T, U, V, W, X, Y> OLHFJEIKJLB(NDNGLGHMJHK<T, U, V, W, X, Y> JOOGPGJMKJF, Action<T, U, V, W, X, Y> OFOIHENMFDE)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x342B060", Offset = "0x342A260", VA = "0x18342B060")]
	public static NDNGLGHMJHK<T, U, V, W, X, Y> BCJDOINJGCB(NDNGLGHMJHK<T, U, V, W, X, Y> JOOGPGJMKJF, Action<T, U, V, W, X, Y> OFOIHENMFDE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class JIGENFAIAHE<TKey, TVal> where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly JHKFGGFKAGI<TKey, TVal> JKKCCIAAPAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly Dictionary<TKey, (TVal value, int size)> FBHLEJBJOLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly JHKFGGFKAGI<TKey, TVal>.KPNGLIIOJBN? FMMCGINNFCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly int JIFCNOMHKDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly JHKFGGFKAGI<TKey, TVal>.OIFPIHHMEAJ? GJEFFEJFJOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private int NKMNMHFKOFG;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal int NONGMFFHBBG
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3C1DB50", Offset = "0x3C1CD50", VA = "0x183C1DB50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int FAELIKCPPHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7B8F30", Offset = "0x7B8130", VA = "0x1807B8F30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3C1DB90", Offset = "0x3C1CD90", VA = "0x183C1DB90")]
	public JIGENFAIAHE(int JIFCNOMHKDO, [Optional] JHKFGGFKAGI<TKey, TVal>.OIFPIHHMEAJ? GJEFFEJFJOP, [Optional] IEqualityComparer<TKey>? IBOGJPCPHFK, [Optional] JHKFGGFKAGI<TKey, TVal>.KPNGLIIOJBN? FMMCGINNFCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3C1D9A0", Offset = "0x3C1CBA0", VA = "0x183C1D9A0")]
	public void MFLBDJOHJMF(TKey GHBNLDGJPCB, TVal EKDDCPALANJ, bool BEFPOKICDPA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3C1D880", Offset = "0x3C1CA80", VA = "0x183C1D880")]
	public bool MALDEJFOHAC(TKey GHBNLDGJPCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3C1D100", Offset = "0x3C1C300", VA = "0x183C1D100")]
	public bool JNNFGFKBPPN(TKey PNIEBCEGDKL, [Out] TVal EKDDCPALANJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3C1CD60", Offset = "0x3C1BF60", VA = "0x183C1CD60")]
	private void GEHCPKGIDLG(TKey GHBNLDGJPCB, TVal EKDDCPALANJ, int ANCJPCFOHBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3C1CF90", Offset = "0x3C1C190", VA = "0x183C1CF90")]
	public bool GFJINBEBBOE(TKey GHBNLDGJPCB, TVal EKDDCPALANJ, bool BEFPOKICDPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3C1CD00", Offset = "0x3C1BF00", VA = "0x183C1CD00")]
	public void DBHKOJLPIHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3C1D1D0", Offset = "0x3C1C3D0", VA = "0x183C1D1D0")]
	private void KDJCALDHNOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3C1CC20", Offset = "0x3C1BE20", VA = "0x183C1CC20")]
	private bool ALMIFCIOLKH(TKey GHBNLDGJPCB, HJOFDHDDDPK LPMJIGEBKFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3C1D7B0", Offset = "0x3C1C9B0", VA = "0x183C1D7B0")]
	private void KIDEECNPBFD(TKey GHBNLDGJPCB, TVal EKDDCPALANJ, HJOFDHDDDPK LPMJIGEBKFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3C1D690", Offset = "0x3C1C890", VA = "0x183C1D690")]
	private void KHMONLHCALK(TKey GHBNLDGJPCB, TVal FKBAIKAGEHB, HJOFDHDDDPK LPMJIGEBKFN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class MPFHBOMAHMC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly Action COMLCNABDGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool NLPFOABILHI;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7C19B0", Offset = "0x7C0BB0", VA = "0x1807C19B0")]
	public MPFHBOMAHMC(Action JJKIGLNGDKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x61EAEB0", Offset = "0x61EA0B0", VA = "0x1861EAEB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2750150", Offset = "0x274F350", VA = "0x182750150")]
	public static MLDGFFPINMO<T> DMOLILFLBFL<T>(T EKDDCPALANJ, Action JJKIGLNGDKA) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class MLDGFFPINMO<T> : MPFHBOMAHMC where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public T LJLHDNLHLNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7B40E0", Offset = "0x7B32E0", VA = "0x1807B40E0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3F41250", Offset = "0x3F40450", VA = "0x183F41250")]
	public MLDGFFPINMO(T EKDDCPALANJ, Action JJKIGLNGDKA)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct IGCMLGNPGHK : IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct EKCMCHAAKAG : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7FCE90", Offset = "0x7FC090", VA = "0x1807FCE90")]
		public static EKCMCHAAKAG DHBNKMCPKNO()
		{
			return default(EKCMCHAAKAG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x28B9400", Offset = "0x28B8600", VA = "0x1828B9400")]
	public static string? IDLAMBDIOBO<T>([Optional] string? NJHOLIFCGDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x28B9380", Offset = "0x28B8580", VA = "0x1828B9380")]
	public static string? EJDEBLGOKLF<T>([Optional] string? MLCFDLJDIKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7FCE90", Offset = "0x7FC090", VA = "0x1807FCE90")]
	public static IGCMLGNPGHK HKBPDPEAAFF(string NJHOLIFCGDO, string? MLCFDLJDIKL)
	{
		return default(IGCMLGNPGHK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct EIEGMJHHHDC
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate bool PEPBFGPFHCH(string MIGDJBIPHHI, EIEGMJHHHDC PMOLJOHIOHA);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public int CDEGJDLAKFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public string EKAHHFGICHL;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x61E96D0", Offset = "0x61E88D0", VA = "0x1861E96D0")]
	public static Dictionary<string, EIEGMJHHHDC> HEOFGDLBIAE(Type KEMEMMCADIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x61E9BC0", Offset = "0x61E8DC0", VA = "0x1861E9BC0")]
	public static Dictionary<string, EIEGMJHHHDC> MECGFINMBDD(Type KEMEMMCADIG, PEPBFGPFHCH MJDFGEHNBKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x61E9A00", Offset = "0x61E8C00", VA = "0x1861E9A00")]
	public static Dictionary<int, string> LANBADPCHEC(Dictionary<string, EIEGMJHHHDC> HEEIDJMADFG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class EPJKOMMHEAH : GJOBCCNBLIC
{
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static bool IMALGJMBDFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly string? AEFFFMPLFAO;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public virtual GJOBCCNBLIC? ILPNIGJDBGH
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7B3610", Offset = "0x7B2810", VA = "0x1807B3610", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x61EA630", Offset = "0x61E9830", VA = "0x1861EA630")]
	protected EPJKOMMHEAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string OFOGPFNLIGE();

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x61EA450", Offset = "0x61E9650", VA = "0x1861EA450", Slot = "8")]
	public virtual string KEHEMEJOCJO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x61E9F80", Offset = "0x61E9180", VA = "0x1861E9F80", Slot = "9")]
	public void AAINKCELFLM(StringBuilder MEPJNPBNIEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x61EA350", Offset = "0x61E9550", VA = "0x1861EA350", Slot = "10")]
	public void EOCIEMNOMEK(StringBuilder MEPJNPBNIEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x61EA230", Offset = "0x61E9430", VA = "0x1861EA230", Slot = "11")]
	public void BJNLJOOCNOI(StringBuilder MEPJNPBNIEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x61EA4D0", Offset = "0x61E96D0", VA = "0x1861EA4D0", Slot = "12")]
	public void PJMNGBKDDCC(StringBuilder MEPJNPBNIEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x61EA3B0", Offset = "0x61E95B0", VA = "0x1861EA3B0")]
	public static void HMGAFCKNCKL(StringBuilder MEPJNPBNIEI, string EHPOPJJLHME, string HBGEEDFCKAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5458790", Offset = "0x5457990", VA = "0x185458790", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class GGNFADNADBL : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x61EAA30", Offset = "0x61E9C30", VA = "0x1861EAA30")]
	public GGNFADNADBL(string FFDOAJJEAOK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class EACGBPGIIGN<TErr> : GGNFADNADBL where TErr : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly TErr OKIHAMDEOGN;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x33F9F60", Offset = "0x33F9160", VA = "0x1833F9F60")]
	private EACGBPGIIGN([In] TErr BBLCGLKFLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x33F9EA0", Offset = "0x33F90A0", VA = "0x1833F9EA0")]
	public static EACGBPGIIGN<TErr> DHBNKMCPKNO([In] TErr BBLCGLKFLKL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface GJOBCCNBLIC
{
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string KEHEMEJOCJO();

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string OFOGPFNLIGE();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface AIOJNCBMNNH<out TOptions> where TOptions : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	TOptions LJLHDNLHLNB
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface LEJLFBOILLK
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	string CAFEHLGHFOH
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class MMEBCHDNCGJ : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x61EAE50", Offset = "0x61EA050", VA = "0x1861EAE50")]
	public MMEBCHDNCGJ(string FFDOAJJEAOK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class LODCHEMLHPA<TOk> : MMEBCHDNCGJ where TOk : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly TOk OHOHEKGLDJF;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x3D68E90", Offset = "0x3D68090", VA = "0x183D68E90")]
	private LODCHEMLHPA([In] TOk GGBOAAAHPCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3778AA0", Offset = "0x3777CA0", VA = "0x183778AA0")]
	public static LODCHEMLHPA<TOk> DHBNKMCPKNO([In] TOk GGBOAAAHPCL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public readonly struct OAAHAKNOJDO<TOk, TErr> : IEquatable<OAAHAKNOJDO<TOk, TErr>> where TOk : notnull where TErr : notnull
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private static readonly EqualityComparer<TErr> EABLDEADPCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal readonly TErr OKIHAMDEOGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal readonly TOk OHOHEKGLDJF;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool NNIKGJJMJKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x40CD890", Offset = "0x40CCA90", VA = "0x1840CD890")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool EIHEBJDACGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x40CDF60", Offset = "0x40CD160", VA = "0x1840CDF60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x40D15E0", Offset = "0x40D07E0", VA = "0x1840D15E0")]
	internal OAAHAKNOJDO([In] TErr BBLCGLKFLKL, [In] TOk GGBOAAAHPCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x40CC590", Offset = "0x40CB790", VA = "0x1840CC590")]
	public static OAAHAKNOJDO<TOk, TErr> GKLKFJJOMBK([In] TErr BBLCGLKFLKL)
	{
		return default(OAAHAKNOJDO<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x40CE860", Offset = "0x40CDA60", VA = "0x1840CE860")]
	public static OAAHAKNOJDO<TOk, TErr> PCBNLMBDIIM([In] TOk GGBOAAAHPCL)
	{
		return default(OAAHAKNOJDO<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2839850", Offset = "0x2838A50", VA = "0x182839850")]
	public OAAHAKNOJDO<TOk?, UErr?> ALCFAOLJEJH<UErr>()
	{
		return default(OAAHAKNOJDO<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x283B530", Offset = "0x283A730", VA = "0x18283B530")]
	public OAAHAKNOJDO<UOk?, TErr?> EBLGCMJHONB<UOk>()
	{
		return default(OAAHAKNOJDO<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x283ABC0", Offset = "0x2839DC0", VA = "0x18283ABC0")]
	public OAAHAKNOJDO<UOk?, TErr?> CPHAPBOCJAP<UOk>()
	{
		return default(OAAHAKNOJDO<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2839FD0", Offset = "0x28391D0", VA = "0x182839FD0")]
	public OAAHAKNOJDO<TOk?, UErr?> BGEMBGGDLJJ<UErr>()
	{
		return default(OAAHAKNOJDO<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x40CE470", Offset = "0x40CD670", VA = "0x1840CE470")]
	public OAAHAKNOJDO<NFDBFOHCHGK, TErr> KOKOCDPAJHB()
	{
		return default(OAAHAKNOJDO<NFDBFOHCHGK, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x40CB130", Offset = "0x40CA330", VA = "0x1840CB130")]
	public static bool FPIEKNKMEBM([In] OAAHAKNOJDO<TOk, TErr> EAIBKNOIIGG, [In] OAAHAKNOJDO<TOk, TErr> PKGAILNKPEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x40CA1E0", Offset = "0x40C93E0", VA = "0x1840CA1E0", Slot = "4")]
	public bool Equals(OAAHAKNOJDO<TOk, TErr> MEJMHKPOODP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x40CA8B0", Offset = "0x40C9AB0", VA = "0x1840CA8B0", Slot = "0")]
	public override bool Equals(object MEJMHKPOODP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x40CCA20", Offset = "0x40CBC20", VA = "0x1840CCA20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x40D0CA0", Offset = "0x40CFEA0", VA = "0x1840D0CA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class NFACEEBDJJA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private struct GGBPHOBNLKN<TOk, TErr> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AsyncTaskMethodBuilder<TOk> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public Task<OAAHAKNOJDO<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private TaskAwaiter<OAAHAKNOJDO<TOk, TErr>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x3862900", Offset = "0x3861B00", VA = "0x183862900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x3862C00", Offset = "0x3861E00", VA = "0x183862C00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x29C9DC0", Offset = "0x29C8FC0", VA = "0x1829C9DC0")]
	public static OAAHAKNOJDO<TOk?, TErr?> OHOHEKGLDJF<TOk, TErr>([In] this OAAHAKNOJDO<TOk, TErr> AOFIGDLFNLH, [In] TOk GGBOAAAHPCL)
	{
		return default(OAAHAKNOJDO<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x29C9E50", Offset = "0x29C9050", VA = "0x1829C9E50")]
	public static OAAHAKNOJDO<NFDBFOHCHGK, TErr?> OHOHEKGLDJF<TErr>([In] this OAAHAKNOJDO<NFDBFOHCHGK, TErr> AOFIGDLFNLH)
	{
		return default(OAAHAKNOJDO<NFDBFOHCHGK, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x29C9DC0", Offset = "0x29C8FC0", VA = "0x1829C9DC0")]
	public static OAAHAKNOJDO<TOk?, TErr?> OKIHAMDEOGN<TOk, TErr>([In] this OAAHAKNOJDO<TOk, TErr> AOFIGDLFNLH, [In] TErr BBLCGLKFLKL)
	{
		return default(OAAHAKNOJDO<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x29C8CF0", Offset = "0x29C7EF0", VA = "0x1829C8CF0")]
	public static TOk? KMBIFKEOFKC<TOk, TErr>([In] this OAAHAKNOJDO<TOk, TErr> AOFIGDLFNLH)
	{
		return (TOk?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x29C72A0", Offset = "0x29C64A0", VA = "0x1829C72A0")]
	[AsyncStateMachine(typeof(GGBPHOBNLKN<, >))]
	public static Task<TOk?>? BBEAPPKHODI<TOk, TErr>(this Task<OAAHAKNOJDO<TOk, TErr>> AOFIGDLFNLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x29C9350", Offset = "0x29C8550", VA = "0x1829C9350")]
	public static TErr? LKGCIOBLPJA<TErr, TOk>([In] this OAAHAKNOJDO<TOk, TErr> AOFIGDLFNLH)
	{
		return (TErr?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x29C7620", Offset = "0x29C6820", VA = "0x1829C7620")]
	public static bool GLGFONIGLHF<TOk, TErr, UErr, UOk>([In] this OAAHAKNOJDO<TOk, TErr> AOFIGDLFNLH, [Out] OAAHAKNOJDO<UOk, UErr> BKHFGIKBFNG) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x29C8BD0", Offset = "0x29C7DD0", VA = "0x1829C8BD0")]
	public static bool HKIBCNNFKKG<TOk, TErr>([In] this OAAHAKNOJDO<TOk, TErr> AOFIGDLFNLH, [Out][NotNullWhen(true)] TOk GGBOAAAHPCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x29C7540", Offset = "0x29C6740", VA = "0x1829C7540")]
	public static bool CMAGEHJLNEH<TOk, TErr>([In] this OAAHAKNOJDO<TOk, TErr> AOFIGDLFNLH, [Out][NotNullWhen(true)] TErr BBLCGLKFLKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x29CA010", Offset = "0x29C9210", VA = "0x1829CA010")]
	public static bool PINBJAOJKJA<TOk, TErr>([In] this OAAHAKNOJDO<TOk, TErr> AOFIGDLFNLH, [Out][NotNullWhen(true)] TOk GGBOAAAHPCL, [Out][NotNullWhen(false)] TErr BBLCGLKFLKL) where TOk : notnull where TErr : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x29C9F10", Offset = "0x29C9110", VA = "0x1829C9F10")]
	public static bool PDHPDLCHKAB<TOk, TErr>([In] this OAAHAKNOJDO<TOk, TErr> AOFIGDLFNLH, [Out][NotNullWhen(true)] TOk GGBOAAAHPCL, [Out] OAAHAKNOJDO<TOk, TErr> BKHFGIKBFNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x29C7850", Offset = "0x29C6A50", VA = "0x1829C7850")]
	public static bool GLGFONIGLHF<TOk, TErr, UErr, UOk>([In] this OAAHAKNOJDO<TOk, TErr> AOFIGDLFNLH, [Out][NotNullWhen(true)] TOk GGBOAAAHPCL, [Out] OAAHAKNOJDO<UOk, UErr> BKHFGIKBFNG) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x29C9A20", Offset = "0x29C8C20", VA = "0x1829C9A20")]
	public static bool NPILLGCDIDA<TOk, TErr>([In] this OAAHAKNOJDO<TOk, TErr> AOFIGDLFNLH, [Out][NotNullWhen(true)] TOk GGBOAAAHPCL, [Out] OAAHAKNOJDO<NFDBFOHCHGK, TErr> BKHFGIKBFNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x29C88B0", Offset = "0x29C7AB0", VA = "0x1829C88B0")]
	public static OAAHAKNOJDO<UOk, UErr> HGNPJFIFGAL<UOk, UErr, TOk, TErr>([In] this OAAHAKNOJDO<TOk, TErr> AOFIGDLFNLH, [In] OAAHAKNOJDO<UOk, UErr> KCEAHMBEPHE) where TOk : UOk where TErr : UErr
	{
		return default(OAAHAKNOJDO<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x29C9610", Offset = "0x29C8810", VA = "0x1829C9610")]
	public static OAAHAKNOJDO<TOk?[]?, TErr?> LMFCEALGOID<TOk, TErr>(this IEnumerable<OAAHAKNOJDO<TOk, TErr>> AOFIGDLFNLH)
	{
		return default(OAAHAKNOJDO<TOk[], TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class EOIJDAIAANC<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x266C260", Offset = "0x266B460", VA = "0x18266C260")]
	public static OAAHAKNOJDO<TOk, T> OHOHEKGLDJF<TOk>([In] TOk GGBOAAAHPCL) where TOk : notnull
	{
		return default(OAAHAKNOJDO<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x342E750", Offset = "0x342D950", VA = "0x18342E750")]
	public static OAAHAKNOJDO<NFDBFOHCHGK, T> OHOHEKGLDJF()
	{
		return default(OAAHAKNOJDO<NFDBFOHCHGK, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x266C260", Offset = "0x266B460", VA = "0x18266C260")]
	public static OAAHAKNOJDO<T, TErr> OKIHAMDEOGN<TErr>([In] TErr BBLCGLKFLKL) where TErr : notnull
	{
		return default(OAAHAKNOJDO<T, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[DefaultMember("Item")]
public sealed class ODHLLOELCDE<T> : IEnumerable<T>, IEnumerable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	private readonly struct BENAGELIMCJ : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly ODHLLOELCDE<T> LELKBKGFBNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly int APBMBEFHCNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly bool MCEDNHMNCHJ;

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x1D12320", Offset = "0x1D11520", VA = "0x181D12320")]
		public BENAGELIMCJ(ODHLLOELCDE<T> HMEKKAINJCD, int KAOBOPAJNDH, bool NEKBAGDKHEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x47BB040", Offset = "0x47BA240", VA = "0x1847BB040")]
		public ODHLLOELCDE<T>.MBLNNOMDLNK LEPKJMNOIOO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x47BB120", Offset = "0x47BA320", VA = "0x1847BB120", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x47BB120", Offset = "0x47BA320", VA = "0x1847BB120", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public sealed class MBLNNOMDLNK : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly ODHLLOELCDE<T> LELKBKGFBNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly int EPKBNFAOPKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private int LAEFOIONEKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private readonly bool MCEDNHMNCHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private bool ALPECAMGPFE;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public T KOOHOOFHLKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x3F08460", Offset = "0x3F07660", VA = "0x183F08460")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x3F085F0", Offset = "0x3F077F0", VA = "0x183F085F0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x3F08710", Offset = "0x3F07910", VA = "0x183F08710", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x3F08C40", Offset = "0x3F07E40", VA = "0x183F08C40")]
		public MBLNNOMDLNK(ODHLLOELCDE<T> HMEKKAINJCD, int KAOBOPAJNDH, bool NEKBAGDKHEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x3F08520", Offset = "0x3F07720", VA = "0x183F08520", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x3F085A0", Offset = "0x3F077A0", VA = "0x183F085A0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class DKHAMCHOCMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		public DKHAMCHOCMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x509F2F0", Offset = "0x509E4F0", VA = "0x18509F2F0")]
		internal T GKHFFIHJBKA(int _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly T[] NIMDLJEAODK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private int LAEFOIONEKA;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int EFNJOBEHAMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x40E9DF0", Offset = "0x40E8FF0", VA = "0x1840E9DF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public T KOOHOOFHLKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x37514B0", Offset = "0x37506B0", VA = "0x1837514B0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public T CECLBNHPHAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x40EA0F0", Offset = "0x40E92F0", VA = "0x1840EA0F0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public T KFIAMJJGJCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x40E9F70", Offset = "0x40E9170", VA = "0x1840E9F70")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int OECJFLODMOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x1723520", Offset = "0x1722720", VA = "0x181723520")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0xFCB5E0", Offset = "0xFCA7E0", VA = "0x180FCB5E0")]
	private static int HBDKKJFOMOL(int MBGANDEDPDN, int EAMNBPDOIFO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x40EA120", Offset = "0x40E9320", VA = "0x1840EA120")]
	public ODHLLOELCDE(int ANCJPCFOHBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x40EA230", Offset = "0x40E9430", VA = "0x1840EA230")]
	public ODHLLOELCDE(int ANCJPCFOHBG, Func<T> ELAHNPEHBED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x40EA570", Offset = "0x40E9770", VA = "0x1840EA570")]
	public ODHLLOELCDE(T[] CNMJLBIMKJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x40EA0C0", Offset = "0x40E92C0", VA = "0x1840EA0C0")]
	public void OBKFFDHGIDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x40E9E30", Offset = "0x40E9030", VA = "0x1840E9E30")]
	public IEnumerable<T> KDECNFDHDAE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x40E9EF0", Offset = "0x40E90F0", VA = "0x1840E9EF0")]
	public ODHLLOELCDE<T>.MBLNNOMDLNK LEPKJMNOIOO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x380BF70", Offset = "0x380B170", VA = "0x18380BF70", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x380BF70", Offset = "0x380B170", VA = "0x18380BF70", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public static class PKFELGAJOLE
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x2A11FC0", Offset = "0x2A111C0", VA = "0x182A11FC0")]
	public static ODHLLOELCDE<T> DHBNKMCPKNO<T>(int ANCJPCFOHBG, Func<T> ELAHNPEHBED) where T : notnull
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
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private const float kEpsilon = 1E-05f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public float r;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public float g;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public float b;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public float a;

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x1DFEFF0", Offset = "0x1DFE1F0", VA = "0x181DFEFF0")]
		public RRColor(float COLCKPIEBCC, float NDCMJAMCMKG, float HIOEJKGFIKI, float LLLCBODKBAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x61EB4E0", Offset = "0x61EA6E0", VA = "0x1861EB4E0", Slot = "4")]
		public bool Equals(RRColor MEJMHKPOODP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x61EB560", Offset = "0x61EA760", VA = "0x1861EB560", Slot = "0")]
		public override bool Equals(object MEJMHKPOODP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x61EB660", Offset = "0x61EA860", VA = "0x1861EB660", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x61EB6E0", Offset = "0x61EA8E0", VA = "0x1861EB6E0", Slot = "5")]
		public string ToString(string NBHCKGNBPIL, IFormatProvider KIDBMGNIFLM)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public sealed class MDLLBGEJILO<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public readonly struct GPDBDPCFMDI : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly MDLLBGEJILO<T> BJDBEIHKGMO;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public T LJLHDNLHLNB
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x389F980", Offset = "0x389EB80", VA = "0x18389F980")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x389F950", Offset = "0x389EB50", VA = "0x18389F950", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x93E850", Offset = "0x93DA50", VA = "0x18093E850")]
		public GPDBDPCFMDI(MDLLBGEJILO<T> BJDBEIHKGMO)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct PHHOBJPIKDD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public AsyncTaskMethodBuilder<GPDBDPCFMDI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public MDLLBGEJILO<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x41AE070", Offset = "0x41AD270", VA = "0x1841AE070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x321EF90", Offset = "0x321E190", VA = "0x18321EF90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly SemaphoreSlim DAHFHBEGJEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private T EJNFBNAINJF;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x3F0F640", Offset = "0x3F0E840", VA = "0x183F0F640")]
	public MDLLBGEJILO([In] T EJNFBNAINJF, int HHMAAHHEIGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x3F0F780", Offset = "0x3F0E980", VA = "0x183F0F780")]
	public MDLLBGEJILO([In] T EJNFBNAINJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x3F0F1A0", Offset = "0x3F0E3A0", VA = "0x183F0F1A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x3F0F160", Offset = "0x3F0E360", VA = "0x183F0F160")]
	public GPDBDPCFMDI DHNCNNMJMAJ()
	{
		return default(GPDBDPCFMDI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x3F0F510", Offset = "0x3F0E710", VA = "0x183F0F510")]
	[AsyncStateMachine(typeof(MDLLBGEJILO<>.PHHOBJPIKDD))]
	public Task<MDLLBGEJILO<T>.GPDBDPCFMDI> GLKHOBCMGAB(CancellationToken IOOGCHJMBIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x3F0F620", Offset = "0x3F0E820", VA = "0x183F0F620")]
	public void LBNAPAJNEGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class FPBBOBPHIGA
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x61EA9C0", Offset = "0x61E9BC0", VA = "0x1861EA9C0")]
	public static MDLLBGEJILO<NFDBFOHCHGK> DHBNKMCPKNO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x26C4DD0", Offset = "0x26C3FD0", VA = "0x1826C4DD0")]
	public static MDLLBGEJILO<T> DHBNKMCPKNO<T>([In] T EJNFBNAINJF) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public sealed class NOBEPPKHDKO<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public readonly struct HFIAHKOHEAH : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly NOBEPPKHDKO<T> EHDHHMMNLDK;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public T LJLHDNLHLNB
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x3963DA0", Offset = "0x3962FA0", VA = "0x183963DA0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x3963A40", Offset = "0x3962C40", VA = "0x183963A40", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x93E850", Offset = "0x93DA50", VA = "0x18093E850")]
		internal HFIAHKOHEAH(NOBEPPKHDKO<T> BJDBEIHKGMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public readonly struct BDKAKJCKNIF : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly NOBEPPKHDKO<T> EHDHHMMNLDK;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public T LJLHDNLHLNB
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x3963DA0", Offset = "0x3962FA0", VA = "0x183963DA0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x47B6CB0", Offset = "0x47B5EB0", VA = "0x1847B6CB0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x93E850", Offset = "0x93DA50", VA = "0x18093E850")]
		internal BDKAKJCKNIF(NOBEPPKHDKO<T> BJDBEIHKGMO)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct MMKPBBMOMOA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public AsyncTaskMethodBuilder<BDKAKJCKNIF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public NOBEPPKHDKO<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private MDLLBGEJILO<NFDBFOHCHGK>.GPDBDPCFMDI <writeLock>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private TaskAwaiter<MDLLBGEJILO<NFDBFOHCHGK>.GPDBDPCFMDI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x3F47040", Offset = "0x3F46240", VA = "0x183F47040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x321EF90", Offset = "0x321E190", VA = "0x18321EF90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly MDLLBGEJILO<int> OJKGAFOKHFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly MDLLBGEJILO<NFDBFOHCHGK> ENDCBDHEIKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly MDLLBGEJILO<NFDBFOHCHGK> HIIBBABAPFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private T EMNNMOGNLLP;

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x400E230", Offset = "0x400D430", VA = "0x18400E230")]
	internal NOBEPPKHDKO(MDLLBGEJILO<int> LDDDBBDIFKN, MDLLBGEJILO<NFDBFOHCHGK> EBKGJCMDPMC, MDLLBGEJILO<NFDBFOHCHGK> AJHBLLGCAOG, [In] T EJNFBNAINJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x400DA00", Offset = "0x400CC00", VA = "0x18400DA00", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x400D840", Offset = "0x400CA40", VA = "0x18400D840")]
	public HFIAHKOHEAH AJMADNCBCCK()
	{
		return default(HFIAHKOHEAH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x400DFD0", Offset = "0x400D1D0", VA = "0x18400DFD0")]
	public BDKAKJCKNIF PFJFMDMNKPF()
	{
		return default(BDKAKJCKNIF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x400DCA0", Offset = "0x400CEA0", VA = "0x18400DCA0")]
	[AsyncStateMachine(typeof(NOBEPPKHDKO<>.MMKPBBMOMOA))]
	public Task<NOBEPPKHDKO<T>.BDKAKJCKNIF> NLFJDFMOPKP(CancellationToken IOOGCHJMBIE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class NEEKBINKICE
{
	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x61EAEF0", Offset = "0x61EA0F0", VA = "0x1861EAEF0")]
	public static NOBEPPKHDKO<NFDBFOHCHGK> DHBNKMCPKNO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x29C6280", Offset = "0x29C5480", VA = "0x1829C6280")]
	public static NOBEPPKHDKO<T> DHBNKMCPKNO<T>([In] T EJNFBNAINJF) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public sealed class LBAAPCAKDFA<TData> : EPJKOMMHEAH where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly string NMCIIMABILJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly TData FHDMPGOGOOJ;

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x7B4160", Offset = "0x7B3360", VA = "0x1807B4160", Slot = "7")]
	public override string OFOGPFNLIGE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x3D4AFE0", Offset = "0x3D4A1E0", VA = "0x183D4AFE0")]
	internal LBAAPCAKDFA(string FFDOAJJEAOK, [In] TData MJGHOBDIDHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class EPOOOLPCMEN
{
	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x61EA6A0", Offset = "0x61E98A0", VA = "0x1861EA6A0")]
	public static LBAAPCAKDFA<NFDBFOHCHGK> DHBNKMCPKNO(string FFDOAJJEAOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x2750150", Offset = "0x274F350", VA = "0x182750150")]
	public static LBAAPCAKDFA<TData> DHBNKMCPKNO<TData>(string FFDOAJJEAOK, [In] TData MJGHOBDIDHD) where TData : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class FDJOGGCGKEP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly Dictionary<object, float> DMIBENMKHKO;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public float DMPMPHHCAAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x939B60", Offset = "0x938D60", VA = "0x180939B60")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x939C00", Offset = "0x938E00", VA = "0x180939C00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x61EA790", Offset = "0x61E9990", VA = "0x1861EA790")]
	public void JIKFOBMFIPM(float EKDDCPALANJ, object GMMJMENGHCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x61EA720", Offset = "0x61E9920", VA = "0x1861EA720")]
	public void FPDJGBKEMHG(object GMMJMENGHCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x61EA800", Offset = "0x61E9A00", VA = "0x1861EA800")]
	private void PPPFIDBBCKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x61EA930", Offset = "0x61E9B30", VA = "0x1861EA930")]
	public FDJOGGCGKEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class LOOLBEHOCGK<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class DINOEPKBPMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		public DINOEPKBPMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x509CF30", Offset = "0x509C130", VA = "0x18509CF30")]
		internal int AHODEHDEHJL(int i, T token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private HashSet<T>? IAEMJEPFLHF;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public IReadOnlyCollection<T> CNFNDAGLIKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x3D6D410", Offset = "0x3D6C610", VA = "0x183D6D410")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool IJICBJLOJNN
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x3D6D290", Offset = "0x3D6C490", VA = "0x183D6D290")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int GIHIJMKOGEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x7B8F20", Offset = "0x7B8120", VA = "0x1807B8F20")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x7B9670", Offset = "0x7B8870", VA = "0x1807B9670")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x3D6D440", Offset = "0x3D6C640", VA = "0x183D6D440")]
	public bool GHBEENLPKLN(T GMMJMENGHCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x3D6D2C0", Offset = "0x3D6C4C0", VA = "0x183D6D2C0")]
	public bool FBCLMIGJMFH(T GMMJMENGHCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x3D6D3D0", Offset = "0x3D6C5D0", VA = "0x183D6D3D0")]
	public bool FFANKOOFEPM(T GMMJMENGHCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x3D6D590", Offset = "0x3D6C790", VA = "0x183D6D590", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public LOOLBEHOCGK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class CIEPIIDPHFK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly string DFMBDEBKEJC;

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x7C19B0", Offset = "0x7C0BB0", VA = "0x1807C19B0")]
	public CIEPIIDPHFK(string DFMBDEBKEJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x61E9360", Offset = "0x61E8560", VA = "0x1861E9360", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public sealed class AHHBNJJODED
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class LBAKAEDBFBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		public LBAKAEDBFBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x61EADA0", Offset = "0x61E9FA0", VA = "0x1861EADA0")]
		internal int AHODEHDEHJL(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private HashSet<object>? IAEMJEPFLHF;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public IReadOnlyCollection<object> CNFNDAGLIKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x61E8720", Offset = "0x61E7920", VA = "0x1861E8720")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool IJICBJLOJNN
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x61E8610", Offset = "0x61E7810", VA = "0x1861E8610")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int GIHIJMKOGEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x7B8F20", Offset = "0x7B8120", VA = "0x1807B8F20")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x7B9670", Offset = "0x7B8870", VA = "0x1807B9670")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x61E87B0", Offset = "0x61E79B0", VA = "0x1861E87B0")]
	public bool GHBEENLPKLN(object GMMJMENGHCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x61E8620", Offset = "0x61E7820", VA = "0x1861E8620")]
	public bool FBCLMIGJMFH(object GMMJMENGHCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x61E86C0", Offset = "0x61E78C0", VA = "0x1861E86C0")]
	public bool FFANKOOFEPM(object GMMJMENGHCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x61E85A0", Offset = "0x61E77A0", VA = "0x1861E85A0")]
	public void AIOCHMNHNPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x61E8890", Offset = "0x61E7A90", VA = "0x1861E8890", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public AHHBNJJODED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class CBGGGINCELM<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private struct CMPLMLKBHCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public float KEEFJHFLJBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public T LJLHDNLHLNB;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly Dictionary<object, CMPLMLKBHCJ> DMIBENMKHKO;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public virtual T ELAMNIPIMNP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0xEC98F0", Offset = "0xEC8AF0", VA = "0x180EC98F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0xEC8310", Offset = "0xEC7510", VA = "0x180EC8310", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public object? IDJBNODBFFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x7B4170", Offset = "0x7B3370", VA = "0x1807B4170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x7B4100", Offset = "0x7B3300", VA = "0x1807B4100")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool HKKPLCHHKIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x492AAA0", Offset = "0x4929CA0", VA = "0x18492AAA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x492A640", Offset = "0x4929840", VA = "0x18492A640")]
	public bool JIKFOBMFIPM(T EKDDCPALANJ, object GMMJMENGHCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x384E4C0", Offset = "0x384D6C0", VA = "0x18384E4C0")]
	public bool FPDJGBKEMHG(object GMMJMENGHCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x4929F60", Offset = "0x4929160", VA = "0x184929F60")]
	public void DBHKOJLPIHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x492A920", Offset = "0x4929B20", VA = "0x18492A920")]
	public bool JNNFGFKBPPN(object GMMJMENGHCD, [Out] T EKDDCPALANJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x4929610", Offset = "0x4928810", VA = "0x184929610")]
	[FFHGPDJOEEK("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool AOBDIMNJBGO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x492AAE0", Offset = "0x4929CE0", VA = "0x18492AAE0")]
	public CBGGGINCELM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface AOBJDOJCKPK
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event OEFKHBBOIED DAOOCHNHDCH;
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class BIMEFCBBDJD : AOBJDOJCKPK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public readonly struct PJLCFDOPEND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public readonly float EOFOFFHJEOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public readonly float EBBDGOIFBGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		internal readonly bool DJHIIBCIELN;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float ODOBGAEOPBA
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x61EB210", Offset = "0x61EA410", VA = "0x1861EB210")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x61EB380", Offset = "0x61EA580", VA = "0x1861EB380")]
		public PJLCFDOPEND(float GGLMJACONBL, float HOMODAIKDLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x61EB220", Offset = "0x61EA420", VA = "0x1861EB220", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class NICHHPBJKBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public BIMEFCBBDJD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		public NICHHPBJKBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x61EB0F0", Offset = "0x61EA2F0", VA = "0x1861EB0F0")]
		internal void JNDDBHJDHMK(float innerProgress)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly int ONEEJBCNCKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private int GOLIJGMNABJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly AOBJDOJCKPK[] EKFPCJHMJII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly OEFKHBBOIED[] CHEOCJAKLBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly PJLCFDOPEND[] IHLABPKOGFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private PJLCFDOPEND GDNLDGPCGDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly JIOFHEIKFGN NAJOMHLAFII;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event OEFKHBBOIED DAOOCHNHDCH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x61E8BE0", Offset = "0x61E7DE0", VA = "0x1861E8BE0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x61E8CA0", Offset = "0x61E7EA0", VA = "0x1861E8CA0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x61E91D0", Offset = "0x61E83D0", VA = "0x1861E91D0")]
	public BIMEFCBBDJD(int ONEEJBCNCKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x61E8B50", Offset = "0x61E7D50", VA = "0x1861E8B50")]
	public JIOFHEIKFGN IBHNMGABJDM(PJLCFDOPEND IEEEBFLAPMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x61E8D60", Offset = "0x61E7F60", VA = "0x1861E8D60")]
	public void OJBJJOGFADA(AOBJDOJCKPK GKILEDPIIII, [Optional] PJLCFDOPEND BAHJKJDBDBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x61E8A40", Offset = "0x61E7C40", VA = "0x1861E8A40", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public delegate void OEFKHBBOIED(float CIJPAKCCINC);
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class NHDNGHMAIAP
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private class KCANNBBBEIE : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly AOBJDOJCKPK POMNHANFBDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private readonly OEFKHBBOIED CMMPHMKBCDC;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x61EAD10", Offset = "0x61E9F10", VA = "0x1861EAD10")]
		public KCANNBBBEIE(AOBJDOJCKPK POMNHANFBDD, OEFKHBBOIED CMMPHMKBCDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x61EACC0", Offset = "0x61E9EC0", VA = "0x1861EACC0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x61EB080", Offset = "0x61EA280", VA = "0x1861EB080")]
	internal static bool LAOCPBMBNON(float LLLCBODKBAN, float HIOEJKGFIKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x61D9BC0", Offset = "0x61D8DC0", VA = "0x1861D9BC0")]
	internal static float FFPCANENLJC(float LLLCBODKBAN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x61EAFC0", Offset = "0x61EA1C0", VA = "0x1861EAFC0")]
	public static IDisposable JKEADBMEJND(this AOBJDOJCKPK POMNHANFBDD, OEFKHBBOIED CMMPHMKBCDC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class JIOFHEIKFGN : AOBJDOJCKPK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private float CIJPAKCCINC;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public float BKNDMLHKIHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x61EAA90", Offset = "0x61E9C90", VA = "0x1861EAA90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event OEFKHBBOIED? DAOOCHNHDCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x61EAB80", Offset = "0x61E9D80", VA = "0x1861EAB80", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x61EAC20", Offset = "0x61E9E20", VA = "0x1861EAC20", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public JIOFHEIKFGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class NACKCKMMBJM : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x5CC7170", Offset = "0x5CC6370", VA = "0x185CC7170")]
	public NACKCKMMBJM(string FFDOAJJEAOK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
[DefaultMember("Item")]
public class KHLENKOKPFI<TKey, TValue> : EMIMAEGGEOO<TKey, TValue>, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, FPCNEPLPECI where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private sealed class CIOLCEMPBCP : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private KeyValuePair<TKey, TValue> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public KHLENKOKPFI<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private IEnumerator<KeyValuePair<TKey, TValue>> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		KeyValuePair<TKey, TValue> IEnumerator<KeyValuePair<TKey, TValue>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0xEC98F0", Offset = "0xEC8AF0", VA = "0x180EC98F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TValue>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x4A225D0", Offset = "0x4A217D0", VA = "0x184A225D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x7BBC90", Offset = "0x7BAE90", VA = "0x1807BBC90")]
		[DebuggerHidden]
		public CIOLCEMPBCP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x3789EF0", Offset = "0x37890F0", VA = "0x183789EF0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x4A21870", Offset = "0x4A20A70", VA = "0x184A21870", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x4A217D0", Offset = "0x4A209D0", VA = "0x184A217D0")]
		private void KNOPPBKNOBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x4A21730", Offset = "0x4A20930", VA = "0x184A21730")]
		private void KEKJABDJFPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x4A22580", Offset = "0x4A21780", VA = "0x184A22580", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly EMIMAEGGEOO<TKey, TValue> AMHJDGPHDHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly IDictionary<TKey, TValue> JDIPFIHJOJF;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public int GIHIJMKOGEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x3CB90E0", Offset = "0x3CB82E0", VA = "0x183CB90E0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool APKLFGKPCKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7FCE90", Offset = "0x7FC090", VA = "0x1807FCE90", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public TValue KFIAMJJGJCP
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x3CB9370", Offset = "0x3CB8570", VA = "0x183CB9370", Slot = "4")]
		get
		{
			return (TValue)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x3CB95D0", Offset = "0x3CB87D0", VA = "0x183CB95D0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public ICollection<TKey> OKELJLLLMNB
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x3CB93B0", Offset = "0x3CB85B0", VA = "0x183CB93B0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public ICollection<TValue> DNHPKLHNLHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x3CB94B0", Offset = "0x3CB86B0", VA = "0x183CB94B0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x3CB9030", Offset = "0x3CB8230", VA = "0x183CB9030")]
	public KHLENKOKPFI(EMIMAEGGEOO<TKey, TValue> AMHJDGPHDHP, [Optional] IDictionary<TKey, TValue>? JDIPFIHJOJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x3CB6B30", Offset = "0x3CB5D30", VA = "0x183CB6B30", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x3CB83D0", Offset = "0x3CB75D0", VA = "0x183CB83D0")]
	public void OPNOJEHLNNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x3CB6690", Offset = "0x3CB5890", VA = "0x183CB6690", Slot = "9")]
	public void Add(TKey GHBNLDGJPCB, TValue EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x3CB7800", Offset = "0x3CB6A00", VA = "0x183CB7800")]
	public void INIPNLNIBHA(TKey GHBNLDGJPCB, TValue EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x3CB7430", Offset = "0x3CB6630", VA = "0x183CB7430")]
	public void FNOLLHIELDA(TKey GHBNLDGJPCB, TValue EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x3CB7DF0", Offset = "0x3CB6FF0", VA = "0x183CB7DF0")]
	public void MCCPHNMLNPL(TKey GHBNLDGJPCB, TValue EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x3CB7640", Offset = "0x3CB6840", VA = "0x183CB7640")]
	public void GLIHOABDJEE(TKey GHBNLDGJPCB, TValue EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x3CB8680", Offset = "0x3CB7880", VA = "0x183CB8680", Slot = "14")]
	void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> KBNEJAIFICP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x3CB86D0", Offset = "0x3CB78D0", VA = "0x183CB86D0", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> KBNEJAIFICP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3CB8A30", Offset = "0x3CB7C30", VA = "0x183CB8A30", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> KBNEJAIFICP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x3CB6C30", Offset = "0x3CB5E30", VA = "0x183CB6C30", Slot = "8")]
	public bool ContainsKey(TKey GHBNLDGJPCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x3CB8080", Offset = "0x3CB7280", VA = "0x183CB8080")]
	public bool MOONJKBJLFO(TKey GHBNLDGJPCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x3CB7AC0", Offset = "0x3CB6CC0", VA = "0x183CB7AC0")]
	public bool KGBIPDJNEOB(TKey GHBNLDGJPCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x3CB84E0", Offset = "0x3CB76E0", VA = "0x183CB84E0", Slot = "10")]
	public bool Remove(TKey GHBNLDGJPCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x3CB8E90", Offset = "0x3CB8090", VA = "0x183CB8E90", Slot = "11")]
	public bool TryGetValue(TKey GHBNLDGJPCB, [Out] TValue EKDDCPALANJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x3CB6F00", Offset = "0x3CB6100", VA = "0x183CB6F00", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TValue>[] BLGDAGLONDD, int IMCGHBJCPCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x3CB8D90", Offset = "0x3CB7F90", VA = "0x183CB8D90", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x3CB7770", Offset = "0x3CB6970", VA = "0x183CB7770", Slot = "19")]
	[IteratorStateMachine(typeof(KHLENKOKPFI<, >.CIOLCEMPBCP))]
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x3CB65A0", Offset = "0x3CB57A0", VA = "0x183CB65A0", Slot = "21")]
	public bool AFEOCJPKAOF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x3CB8220", Offset = "0x3CB7420", VA = "0x183CB8220")]
	private TValue OHJJNLBGHMH(TKey GHBNLDGJPCB)
	{
		return (TValue)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public interface FPCNEPLPECI
{
	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AFEOCJPKAOF();
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public interface EMIMAEGGEOO<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, FPCNEPLPECI
{
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[DefaultMember("Item")]
public sealed class JHKFGGFKAGI<TKey, TVal> : EMIMAEGGEOO<TKey, TVal>, IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, FPCNEPLPECI where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public delegate int OIFPIHHMEAJ(TKey GHBNLDGJPCB, TVal EKDDCPALANJ);

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public delegate void KPNGLIIOJBN(TKey GHBNLDGJPCB, TVal EKDDCPALANJ, HJOFDHDDDPK LPMJIGEBKFN);

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class ALICOLFFDLP
	{
		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public TKey NFEHEBDHPKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x853EA0", Offset = "0x8530A0", VA = "0x180853EA0")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public TVal LJLHDNLHLNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x95D910", Offset = "0x95CB10", VA = "0x18095D910")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x95D920", Offset = "0x95CB20", VA = "0x18095D920")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public int ODOBGAEOPBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x7F41B0", Offset = "0x7F33B0", VA = "0x1807F41B0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x7F3FE0", Offset = "0x7F31E0", VA = "0x1807F3FE0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public DateTimeOffset AAFFPFGMAGH
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0xAD7300", Offset = "0xAD6500", VA = "0x180AD7300")]
			[CompilerGenerated]
			get
			{
				return default(DateTimeOffset);
			}
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x133ECD0", Offset = "0x133DED0", VA = "0x18133ECD0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x38B6450", Offset = "0x38B5650", VA = "0x1838B6450")]
		public ALICOLFFDLP(TKey GHBNLDGJPCB, TVal FKBAIKAGEHB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class BKEHNJBMDGA : IEnumerator<KeyValuePair<TKey, TVal>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private KeyValuePair<TKey, TVal> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public JHKFGGFKAGI<TKey, TVal> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private LinkedList<ALICOLFFDLP>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		KeyValuePair<TKey, TVal> IEnumerator<KeyValuePair<TKey, TVal>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0xEC98F0", Offset = "0xEC8AF0", VA = "0x180EC98F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TVal>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x378D1A0", Offset = "0x378C3A0", VA = "0x18378D1A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x7BBC90", Offset = "0x7BAE90", VA = "0x1807BBC90")]
		[DebuggerHidden]
		public BKEHNJBMDGA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x36544B0", Offset = "0x36536B0", VA = "0x1836544B0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x47CA230", Offset = "0x47C9430", VA = "0x1847CA230", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x47C8C70", Offset = "0x47C7E70", VA = "0x1847C8C70")]
		private void KNOPPBKNOBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x47CB3C0", Offset = "0x47CA5C0", VA = "0x1847CB3C0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public const int JPKNILACEIA = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly Dictionary<TKey, LinkedListNode<ALICOLFFDLP>> FDEHBMJJNNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly LinkedList<ALICOLFFDLP> PDDPABOOHOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly OIFPIHHMEAJ? GJEFFEJFJOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly TimeSpan KGOBIOJGGCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly KPNGLIIOJBN? FMMCGINNFCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly PPKNINPFDGC NJNKMMLMOBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private bool NMHFNDNPEGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private readonly List<TKey> MFFHALDGKCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private readonly List<TVal> AEJOPFPAPCF;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public int FAELIKCPPHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x7C3F50", Offset = "0x7C3150", VA = "0x1807C3F50")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	internal int NONGMFFHBBG
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x9B4AB0", Offset = "0x9B3CB0", VA = "0x1809B4AB0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x9B43C0", Offset = "0x9B35C0", VA = "0x1809B43C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int GIHIJMKOGEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x3C0A340", Offset = "0x3C09540", VA = "0x183C0A340", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	internal int BOFKNPJJHKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x3C05820", Offset = "0x3C04A20", VA = "0x183C05820")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public ICollection<TVal> DNHPKLHNLHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x3C0A4B0", Offset = "0x3C096B0", VA = "0x183C0A4B0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	ICollection<TKey> IDictionary<TKey, TVal>.LNMKFENBOEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x3C08400", Offset = "0x3C07600", VA = "0x183C08400", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool APKLFGKPCKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x7FCE90", Offset = "0x7FC090", VA = "0x1807FCE90", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public TVal KFIAMJJGJCP
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x3C0A390", Offset = "0x3C09590", VA = "0x183C0A390", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x3C0A520", Offset = "0x3C09720", VA = "0x183C0A520", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x3C036F0", Offset = "0x3C028F0", VA = "0x183C036F0")]
	private bool FIKIOGIOEKP(int ONEEJBCNCKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x3C00330", Offset = "0x3BFF530", VA = "0x183C00330")]
	private void AOJPECAJIEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x3C099E0", Offset = "0x3C08BE0", VA = "0x183C099E0")]
	public JHKFGGFKAGI(int ONEEJBCNCKG, [Optional] OIFPIHHMEAJ? GJEFFEJFJOP, [Optional] IEqualityComparer<TKey>? IBOGJPCPHFK, [Optional] KPNGLIIOJBN? FMMCGINNFCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x3C08F70", Offset = "0x3C08170", VA = "0x183C08F70")]
	public JHKFGGFKAGI(TimeSpan KGOBIOJGGCD, [Optional] IEqualityComparer<TKey>? IBOGJPCPHFK, [Optional] KPNGLIIOJBN? FMMCGINNFCB, [Optional] PPKNINPFDGC? NJNKMMLMOBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x3C08B30", Offset = "0x3C07D30", VA = "0x183C08B30")]
	public JHKFGGFKAGI(int ONEEJBCNCKG, TimeSpan KGOBIOJGGCD, [Optional] IEqualityComparer<TKey>? IBOGJPCPHFK, [Optional] KPNGLIIOJBN? FMMCGINNFCB, [Optional] PPKNINPFDGC? NJNKMMLMOBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x3C08B80", Offset = "0x3C07D80", VA = "0x183C08B80")]
	public JHKFGGFKAGI(int ONEEJBCNCKG, OIFPIHHMEAJ? GJEFFEJFJOP, TimeSpan KGOBIOJGGCD, [Optional] IEqualityComparer<TKey>? IBOGJPCPHFK, [Optional] KPNGLIIOJBN? FMMCGINNFCB, [Optional] PPKNINPFDGC? NJNKMMLMOBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x3C002D0", Offset = "0x3BFF4D0", VA = "0x183C002D0", Slot = "21")]
	public bool AFEOCJPKAOF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x3C06610", Offset = "0x3C05810", VA = "0x183C06610", Slot = "22")]
	public bool JOHGBMOEPJJ(int ANCJPCFOHBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x3C04D50", Offset = "0x3C03F50", VA = "0x183C04D50")]
	private bool GPKNJNAIBMF(int ANCJPCFOHBG, HJOFDHDDDPK LPMJIGEBKFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x3C05740", Offset = "0x3C04940", VA = "0x183C05740")]
	public void HPPDEOLAJNB(TKey GHBNLDGJPCB, TVal EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x3C00B20", Offset = "0x3BFFD20", VA = "0x183C00B20", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> KBNEJAIFICP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x3C00B50", Offset = "0x3BFFD50", VA = "0x183C00B50", Slot = "9")]
	public void Add(TKey GHBNLDGJPCB, TVal EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x3C01D20", Offset = "0x3C00F20", VA = "0x183C01D20", Slot = "8")]
	public bool ContainsKey(TKey GHBNLDGJPCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x3C07E60", Offset = "0x3C07060", VA = "0x183C07E60", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Contains(KeyValuePair<TKey, TVal> KBNEJAIFICP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x3C07A60", Offset = "0x3C06C60", VA = "0x183C07A60", Slot = "10")]
	public bool Remove(TKey GHBNLDGJPCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x3C082D0", Offset = "0x3C074D0", VA = "0x183C082D0", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Remove(KeyValuePair<TKey, TVal> KBNEJAIFICP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x3C034F0", Offset = "0x3C026F0", VA = "0x183C034F0")]
	private bool ECHAEMOBOCA(TKey GHBNLDGJPCB, [Out] TVal EKDDCPALANJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x3C00F00", Offset = "0x3C00100", VA = "0x183C00F00")]
	private TVal CEIMJGKDJPN(TKey PNIEBCEGDKL)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x3C08610", Offset = "0x3C07810", VA = "0x183C08610", Slot = "11")]
	public bool TryGetValue(TKey PNIEBCEGDKL, [Out] TVal EKDDCPALANJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x3C01B40", Offset = "0x3C00D40", VA = "0x183C01B40", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x3C02400", Offset = "0x3C01600", VA = "0x183C02400", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] BLGDAGLONDD, int IMCGHBJCPCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x3C06E70", Offset = "0x3C06070", VA = "0x183C06E70")]
	private void KHMONLHCALK(TKey GHBNLDGJPCB, TVal FKBAIKAGEHB, HJOFDHDDDPK LPMJIGEBKFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x3C01880", Offset = "0x3C00A80", VA = "0x183C01880")]
	private bool CNBBFBIAGAB(ALICOLFFDLP PGEKIENJLKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x3BFF890", Offset = "0x3BFEA90", VA = "0x183BFF890")]
	private void ADMGGEGAJJF(LinkedListNode<ALICOLFFDLP> MHHDGDEOMJN, TVal CICAFALGPCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x3C05AF0", Offset = "0x3C04CF0", VA = "0x183C05AF0")]
	private void JIKFOBMFIPM(TKey GHBNLDGJPCB, TVal EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x3C06FA0", Offset = "0x3C061A0", VA = "0x183C06FA0")]
	private void LJEAENADAIM(ALICOLFFDLP PGEKIENJLKI, TVal CICAFALGPCA, int HKOEPOIJDGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x3C05250", Offset = "0x3C04450", VA = "0x183C05250", Slot = "19")]
	[IteratorStateMachine(typeof(JHKFGGFKAGI<, >.BKEHNJBMDGA))]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x3C08430", Offset = "0x3C07630", VA = "0x183C08430", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public enum HJOFDHDDDPK : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	Evicted,
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	RemovedViaRemove,
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	RemovedViaClear
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class COHLLLJEILB<TKey> : Exception where TKey : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public readonly TKey EEEOCAMDOMD;

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x4BE7290", Offset = "0x4BE6490", VA = "0x184BE7290")]
	public COHLLLJEILB(TKey LPOODEDIGEP, Exception JLLLHGKGCGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class EICONIPAEBL : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x55C5190", Offset = "0x55C4390", VA = "0x1855C5190")]
	public EICONIPAEBL(string FFDOAJJEAOK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class KBNDKHGPCCD<TId, TResource> : IEnumerable<(TId, Task<TResource>, int)>, IEnumerable where TId : notnull where TResource : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class GHIMPGNLDGE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public Func<TId, CancellationToken, Task<TResource>> factory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public KBNDKHGPCCD<TId, TResource> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		public GHIMPGNLDGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x38645E0", Offset = "0x38637E0", VA = "0x1838645E0")]
		internal Task<TResource> LHGOPEKGGIG(TId _id)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private struct MJIMFJPEHFF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public KBNDKHGPCCD<TId, TResource> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x3F2A310", Offset = "0x3F29510", VA = "0x183F2A310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x3F2A630", Offset = "0x3F29830", VA = "0x183F2A630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private struct MBLAMBPHAAA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public Dictionary<Task<TResource>, CancellationTokenSource> cancellationTokenSources;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public CancellationTokenSource cts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x3F07FF0", Offset = "0x3F071F0", VA = "0x183F07FF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x3F08300", Offset = "0x3F07500", VA = "0x183F08300", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly GOMMEHKPNLK<TId, Task<TResource>> MELJMCEOBFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly Dictionary<Task<TResource>, CancellationTokenSource> AINFAKAJMHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly Func<TId, CancellationToken, Task<TResource>>? DCBGHPGKCFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly Action<TResource>? FCLHPMIFDEB;

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x3CA8FB0", Offset = "0x3CA81B0", VA = "0x183CA8FB0")]
	public KBNDKHGPCCD(int HMLMMJABKEB = 0, [Optional] IEqualityComparer<TId>? IEHEJIGDGEB, [Optional] Func<TId, CancellationToken, Task<TResource>>? DBDKHHKHBCD, [Optional] Action<TResource>? DHALKIEIOGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x3CA8140", Offset = "0x3CA7340", VA = "0x183CA8140")]
	public MLDGFFPINMO<Task<TResource>> BEPGFLIMGIM(TId POAELFIOKHK, [Optional] Func<TId, CancellationToken, Task<TResource>>? DBDKHHKHBCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x3CA8610", Offset = "0x3CA7810", VA = "0x183CA8610")]
	private void KIEMHKGFADM(Task<TResource> PNJMCNKOIDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x3CA8310", Offset = "0x3CA7510", VA = "0x183CA8310")]
	[AsyncStateMachine(typeof(KBNDKHGPCCD<, >.MJIMFJPEHFF))]
	private Task DJMMPOHJKNH(Task<TResource> PNJMCNKOIDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x3CA82E0", Offset = "0x3CA74E0", VA = "0x183CA82E0")]
	public void CBLFFALJFDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x3CA8980", Offset = "0x3CA7B80", VA = "0x183CA8980")]
	public GOMMEHKPNLK<TId, Task<TResource>>.AHPHKFCCCAB LEPKJMNOIOO()
	{
		return default(GOMMEHKPNLK<TId, Task<TResource>>.AHPHKFCCCAB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x3CA8F20", Offset = "0x3CA8120", VA = "0x183CA8F20", Slot = "4")]
	private IEnumerator<(TId, Task<TResource>, int)> System.Collections.Generic.IEnumerable<(TIdId,System.Threading.Tasks.Task<TResource>LoadResourceTask,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x3CA8F20", Offset = "0x3CA8120", VA = "0x183CA8F20", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x3CA8B90", Offset = "0x3CA7D90", VA = "0x183CA8B90")]
	[AsyncStateMachine(typeof(KBNDKHGPCCD<, >.MBLAMBPHAAA))]
	[CompilerGenerated]
	internal static Task MNACDIDHFKH(Task<TResource> PNJMCNKOIDP, CancellationTokenSource JKPAOLOMHMO, Dictionary<Task<TResource>, CancellationTokenSource> CEDLMEFIEAE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class GOMMEHKPNLK<TKey, TValue> : IEnumerable<(TKey, TValue, int)>, IEnumerable where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	private sealed class BNJBMBHOMMJ : IEquatable<BNJBMBHOMMJ>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public readonly TValue LJLHDNLHLNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public int LDPAJBJFPML;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x1CD0FA0", Offset = "0x1CD01A0", VA = "0x181CD0FA0")]
		public BNJBMBHOMMJ(TValue EKDDCPALANJ, int OLNKPBMJOMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x47D6F70", Offset = "0x47D6170", VA = "0x1847D6F70", Slot = "4")]
		public bool Equals(BNJBMBHOMMJ? MEJMHKPOODP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x47D6FF0", Offset = "0x47D61F0", VA = "0x1847D6FF0", Slot = "0")]
		public override bool Equals(object? GLMGCMELGFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x47D7080", Offset = "0x47D6280", VA = "0x1847D7080", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public struct AHPHKFCCCAB : IEnumerator<(TKey, TValue, int)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private Dictionary<TKey, BNJBMBHOMMJ>.Enumerator PFHNBIPOOLG;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x38AF140", Offset = "0x38AE340", VA = "0x1838AF140", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public (TKey Key, TValue Value, int RefCount) KOOHOOFHLKE
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x38AF540", Offset = "0x38AE740", VA = "0x1838AF540", Slot = "4")]
			get
			{
				return default((TKey, TValue, int));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x38AF2A0", Offset = "0x38AE4A0", VA = "0x1838AF2A0")]
		public AHPHKFCCCAB(GOMMEHKPNLK<TKey, TValue> DMIBENMKHKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x38AECF0", Offset = "0x38ADEF0", VA = "0x1838AECF0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x38AEDB0", Offset = "0x38ADFB0", VA = "0x1838AEDB0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x38AEEA0", Offset = "0x38AE0A0", VA = "0x1838AEEA0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class CJBKHLOHPPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public GOMMEHKPNLK<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public TKey key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public BNJBMBHOMMJ refCountedValue;

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		public CJBKHLOHPPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x4A229E0", Offset = "0x4A21BE0", VA = "0x184A229E0")]
		internal void LHGOPEKGGIG()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly Dictionary<TKey, BNJBMBHOMMJ> KNFHNMHEJJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly Func<TKey, TValue>? JDNDLEIAEON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly Action<TValue>? HDBDBJNPGAP;

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x389C610", Offset = "0x389B810", VA = "0x18389C610")]
	public GOMMEHKPNLK(int HMLMMJABKEB = 0, [Optional] IEqualityComparer<TKey>? IBOGJPCPHFK, [Optional] Func<TKey, TValue>? JEEPIMKMDKI, [Optional] Action<TValue>? BHOHHKFFAIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x389B8A0", Offset = "0x389AAA0", VA = "0x18389B8A0")]
	public MLDGFFPINMO<TValue> BEPGFLIMGIM(TKey GHBNLDGJPCB, [Optional] Func<TKey, TValue>? IMEMIFKABGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x389C2A0", Offset = "0x389B4A0", VA = "0x18389C2A0")]
	private void JKJINJEHPOI(TKey GHBNLDGJPCB, BNJBMBHOMMJ LGJGBMPKANA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x389BD30", Offset = "0x389AF30", VA = "0x18389BD30")]
	public void CBLFFALJFDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x389C3D0", Offset = "0x389B5D0", VA = "0x18389C3D0")]
	public AHPHKFCCCAB LEPKJMNOIOO()
	{
		return default(AHPHKFCCCAB);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x389C4F0", Offset = "0x389B6F0", VA = "0x18389C4F0", Slot = "4")]
	private IEnumerator<(TKey, TValue, int)> System.Collections.Generic.IEnumerable<(TKeyKey,TValueValue,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x389C4F0", Offset = "0x389B6F0", VA = "0x18389C4F0", Slot = "5")]
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
