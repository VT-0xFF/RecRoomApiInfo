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
		[Cpp2IlInjected.Address(RVA = "0xA82AE0", Offset = "0xA818E0", VA = "0x180A82AE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x82258E0", Offset = "0x82246E0", VA = "0x1882258E0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA838A0", Offset = "0xA826A0", VA = "0x180A838A0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA838E0", Offset = "0xA826E0", VA = "0x180A838E0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class HMMFACOAMKJ
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	protected HMMFACOAMKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class AFPGLLNCHEI<T> : HMMFACOAMKJ
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	protected struct PEMJGPEBLPH
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public enum BFEMFGHDCJA
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
		public BFEMFGHDCJA DGPNPBEKOOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public T LJIGAFKJJAI;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private int ADLIJCCHAHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool ACEFNCBHJDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	protected readonly bool IOANFJBGFKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	protected List<T>? IBEMBBKDAEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<PEMJGPEBLPH>? CAHHPKPGPDG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool GFHMBGPCEIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4FD5870", Offset = "0x4FD4670", VA = "0x184FD5870")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4FD5AA0", Offset = "0x4FD48A0", VA = "0x184FD5AA0")]
	protected AFPGLLNCHEI(bool IOANFJBGFKB, bool ACEFNCBHJDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4FD5470", Offset = "0x4FD4270", VA = "0x184FD5470")]
	protected bool GKEMAKGCFIJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4FD51A0", Offset = "0x4FD3FA0", VA = "0x184FD51A0")]
	protected void CFKJFGODACE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4FD5690", Offset = "0x4FD4490", VA = "0x184FD5690")]
	protected void MKMIILOAMBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x310E250", Offset = "0x310D050", VA = "0x18310E250")]
	private static void KFFNIPIJACN<U>(List<U>? ECEBLBALENP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4FD58C0", Offset = "0x4FD46C0", VA = "0x184FD58C0", Slot = "4")]
	public void OLHPIGGMIDE(T LJIGAFKJJAI, bool CKLOCKMNGOF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4FD52B0", Offset = "0x4FD40B0", VA = "0x184FD52B0", Slot = "5")]
	public void EBNLHEFHMEO(T LJIGAFKJJAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4FD5510", Offset = "0x4FD4310", VA = "0x184FD5510")]
	public void MKDKKBLDFOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class EPBKGABEMJJ : AFPGLLNCHEI<Action>
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x8223990", Offset = "0x8222790", VA = "0x188223990")]
	public EPBKGABEMJJ(bool IOANFJBGFKB = false, bool ACEFNCBHJDH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x82236D0", Offset = "0x82224D0", VA = "0x1882236D0")]
	public void BOBFGEKALDJ()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x82238D0", Offset = "0x82226D0", VA = "0x1882238D0")]
	public static EPBKGABEMJJ IIPBKEKCMOJ(EPBKGABEMJJ MKJKECGDBBL, Action LJIGAFKJJAI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x8223930", Offset = "0x8222730", VA = "0x188223930")]
	public static EPBKGABEMJJ IPBHEBMDGMP(EPBKGABEMJJ MKJKECGDBBL, Action LJIGAFKJJAI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface FFGHFEJFBDA<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OLHPIGGMIDE(Action<T> LJIGAFKJJAI, bool CKLOCKMNGOF = false);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EBNLHEFHMEO(Action<T> LJIGAFKJJAI);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class IKLFNFDBNDM<T> : AFPGLLNCHEI<Action<T>>, FFGHFEJFBDA<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4CC0D90", Offset = "0x4CBFB90", VA = "0x184CC0D90")]
	public IKLFNFDBNDM(bool IOANFJBGFKB = false, bool ACEFNCBHJDH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4F29E20", Offset = "0x4F28C20", VA = "0x184F29E20")]
	public void BOBFGEKALDJ(T ODOKMLFIJNG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4E34BD0", Offset = "0x4E339D0", VA = "0x184E34BD0")]
	public static IKLFNFDBNDM<T> IIPBKEKCMOJ(IKLFNFDBNDM<T> MKJKECGDBBL, Action<T> LJIGAFKJJAI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4E34C60", Offset = "0x4E33A60", VA = "0x184E34C60")]
	public static IKLFNFDBNDM<T> IPBHEBMDGMP(IKLFNFDBNDM<T> MKJKECGDBBL, Action<T> LJIGAFKJJAI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface IDLEFJOKAJP<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OLHPIGGMIDE(Action<T, U> LJIGAFKJJAI, bool CKLOCKMNGOF = false);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EBNLHEFHMEO(Action<T, U> LJIGAFKJJAI);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class HLGFIGBDGLB<T, U> : AFPGLLNCHEI<Action<T, U>>, IDLEFJOKAJP<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4CC0D90", Offset = "0x4CBFB90", VA = "0x184CC0D90")]
	public HLGFIGBDGLB(bool IOANFJBGFKB = false, bool ACEFNCBHJDH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4E33DC0", Offset = "0x4E32BC0", VA = "0x184E33DC0")]
	public void BOBFGEKALDJ(T ODOKMLFIJNG, U CJONKHGEOJB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4E34BD0", Offset = "0x4E339D0", VA = "0x184E34BD0")]
	public static HLGFIGBDGLB<T, U> IIPBKEKCMOJ(HLGFIGBDGLB<T, U> MKJKECGDBBL, Action<T, U> LJIGAFKJJAI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4E34C60", Offset = "0x4E33A60", VA = "0x184E34C60")]
	public static HLGFIGBDGLB<T, U> IPBHEBMDGMP(HLGFIGBDGLB<T, U> MKJKECGDBBL, Action<T, U> LJIGAFKJJAI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class BMJGKBDHKMP<T, U, V> : AFPGLLNCHEI<Action<T, U, V>> where T : notnull where U : notnull where V : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4CC0D90", Offset = "0x4CBFB90", VA = "0x184CC0D90")]
	public BMJGKBDHKMP(bool IOANFJBGFKB = false, bool ACEFNCBHJDH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x63405C0", Offset = "0x633F3C0", VA = "0x1863405C0")]
	public void BOBFGEKALDJ(T ODOKMLFIJNG, U CJONKHGEOJB, V FPJNLHKNPEA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x4E34BD0", Offset = "0x4E339D0", VA = "0x184E34BD0")]
	public static BMJGKBDHKMP<T, U, V> IIPBKEKCMOJ(BMJGKBDHKMP<T, U, V> MKJKECGDBBL, Action<T, U, V> LJIGAFKJJAI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4E34C60", Offset = "0x4E33A60", VA = "0x184E34C60")]
	public static BMJGKBDHKMP<T, U, V> IPBHEBMDGMP(BMJGKBDHKMP<T, U, V> MKJKECGDBBL, Action<T, U, V> LJIGAFKJJAI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface AKBODIHHLKG<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public sealed class IAAMHDICAKI<T, U, V, W> : AFPGLLNCHEI<Action<T, U, V, W>>, AKBODIHHLKG<T, U, V, W> where T : notnull where U : notnull where V : notnull where W : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4CC0D90", Offset = "0x4CBFB90", VA = "0x184CC0D90")]
	public IAAMHDICAKI(bool IOANFJBGFKB = false, bool ACEFNCBHJDH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4F0BD40", Offset = "0x4F0AB40", VA = "0x184F0BD40")]
	public void BOBFGEKALDJ(T ODOKMLFIJNG, U CJONKHGEOJB, V FPJNLHKNPEA, W DIBMLEMJLNN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4E34BD0", Offset = "0x4E339D0", VA = "0x184E34BD0")]
	public static IAAMHDICAKI<T, U, V, W> IIPBKEKCMOJ(IAAMHDICAKI<T, U, V, W> MKJKECGDBBL, Action<T, U, V, W> LJIGAFKJJAI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4E34C60", Offset = "0x4E33A60", VA = "0x184E34C60")]
	public static IAAMHDICAKI<T, U, V, W> IPBHEBMDGMP(IAAMHDICAKI<T, U, V, W> MKJKECGDBBL, Action<T, U, V, W> LJIGAFKJJAI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class JJNGBFGODDG<T, U, V, W, X> : AFPGLLNCHEI<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x4CC0D90", Offset = "0x4CBFB90", VA = "0x184CC0D90")]
	public JJNGBFGODDG(bool IOANFJBGFKB = false, bool ACEFNCBHJDH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x51ECFC0", Offset = "0x51EBDC0", VA = "0x1851ECFC0")]
	public void BOBFGEKALDJ(T ODOKMLFIJNG, U CJONKHGEOJB, V FPJNLHKNPEA, W DIBMLEMJLNN, X DHOMBGCEEAK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4E34BD0", Offset = "0x4E339D0", VA = "0x184E34BD0")]
	public static JJNGBFGODDG<T, U, V, W, X> IIPBKEKCMOJ(JJNGBFGODDG<T, U, V, W, X> MKJKECGDBBL, Action<T, U, V, W, X> LJIGAFKJJAI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4E34C60", Offset = "0x4E33A60", VA = "0x184E34C60")]
	public static JJNGBFGODDG<T, U, V, W, X> IPBHEBMDGMP(JJNGBFGODDG<T, U, V, W, X> MKJKECGDBBL, Action<T, U, V, W, X> LJIGAFKJJAI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class BNDNGFIKCBA<T, U, V, W, X, Y> : AFPGLLNCHEI<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4CC0D90", Offset = "0x4CBFB90", VA = "0x184CC0D90")]
	public BNDNGFIKCBA(bool IOANFJBGFKB = false, bool ACEFNCBHJDH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6342130", Offset = "0x6340F30", VA = "0x186342130")]
	public void BOBFGEKALDJ(T ODOKMLFIJNG, U CJONKHGEOJB, V FPJNLHKNPEA, W DIBMLEMJLNN, X DHOMBGCEEAK, Y EDBCCDDDLPI)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4E34BD0", Offset = "0x4E339D0", VA = "0x184E34BD0")]
	public static BNDNGFIKCBA<T, U, V, W, X, Y> IIPBKEKCMOJ(BNDNGFIKCBA<T, U, V, W, X, Y> MKJKECGDBBL, Action<T, U, V, W, X, Y> LJIGAFKJJAI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4E34C60", Offset = "0x4E33A60", VA = "0x184E34C60")]
	public static BNDNGFIKCBA<T, U, V, W, X, Y> IPBHEBMDGMP(BNDNGFIKCBA<T, U, V, W, X, Y> MKJKECGDBBL, Action<T, U, V, W, X, Y> LJIGAFKJJAI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class EFLGOLPFEDE<TKey, TVal> where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly DAOBLECFCHP<TKey, TVal> EEJENILODIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly Dictionary<TKey, (TVal value, int size)> NOKAFKGMHHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly DAOBLECFCHP<TKey, TVal>.BDMLHHAHKDN? ENGONDNAIJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly int FKMJJOADJAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly DAOBLECFCHP<TKey, TVal>.KEKIBCGGOOK? AJAIOHJCJGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private int KIJGLJNFFEB;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal int CKBMPPEMGMP
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x4820BA0", Offset = "0x481F9A0", VA = "0x184820BA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int FOILODIMODM
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA5A420", Offset = "0xA59220", VA = "0x180A5A420")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4821C30", Offset = "0x4820A30", VA = "0x184821C30")]
	public EFLGOLPFEDE(int FKMJJOADJAM, [Optional] DAOBLECFCHP<TKey, TVal>.KEKIBCGGOOK? AJAIOHJCJGA, [Optional] IEqualityComparer<TKey>? IIMIJPBCCII, [Optional] DAOBLECFCHP<TKey, TVal>.BDMLHHAHKDN? ENGONDNAIJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x4821980", Offset = "0x4820780", VA = "0x184821980")]
	public void ODEDKPGIPFC(TKey MAHBBBBCDEL, TVal BNECONOIKOE, bool EDPHLPHIGJO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x48214A0", Offset = "0x48202A0", VA = "0x1848214A0")]
	public bool LMNKONLBHDA(TKey MAHBBBBCDEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x4820BF0", Offset = "0x481F9F0", VA = "0x184820BF0")]
	public bool BNILIKGEJAF(TKey ANEBGMAHJJK, [Out] TVal BNECONOIKOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x48215D0", Offset = "0x48203D0", VA = "0x1848215D0")]
	private void MHNOPHOEPPK(TKey MAHBBBBCDEL, TVal BNECONOIKOE, int DFCCCGNJINK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4820CD0", Offset = "0x481FAD0", VA = "0x184820CD0")]
	public bool EJELNGPHGDL(TKey MAHBBBBCDEL, TVal BNECONOIKOE, bool EDPHLPHIGJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4821830", Offset = "0x4820630", VA = "0x184821830")]
	public void MKDKKBLDFOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4820F90", Offset = "0x481FD90", VA = "0x184820F90")]
	private void LLHJFJBMHBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4821890", Offset = "0x4820690", VA = "0x184821890")]
	private bool NCKCMLBFLJL(TKey MAHBBBBCDEL, CCHPPJLHJCE EGLDLGDMAJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4821B50", Offset = "0x4820950", VA = "0x184821B50")]
	private void PLCGNDJAMED(TKey MAHBBBBCDEL, TVal BNECONOIKOE, CCHPPJLHJCE EGLDLGDMAJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4820E60", Offset = "0x481FC60", VA = "0x184820E60")]
	private void JMNJNACBOKH(TKey MAHBBBBCDEL, TVal HBLCHHJHKAF, CCHPPJLHJCE EGLDLGDMAJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class ECEGGHGDMDI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly Action CGAEFNHMPJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool ECPCPMJNGEB;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0xA665B0", Offset = "0xA653B0", VA = "0x180A665B0")]
	public ECEGGHGDMDI(Action NDAMMPOGDLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x82235C0", Offset = "0x82223C0", VA = "0x1882235C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x311BE10", Offset = "0x311AC10", VA = "0x18311BE10")]
	public static BFMFPOLFIAF<T> LDFHHMLGJNG<T>(T BNECONOIKOE, Action NDAMMPOGDLL) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class BFMFPOLFIAF<T> : ECEGGHGDMDI where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public T HBDLGDLEPJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xA59860", Offset = "0xA58660", VA = "0x180A59860")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x62533E0", Offset = "0x62521E0", VA = "0x1862533E0")]
	public BFMFPOLFIAF(T BNECONOIKOE, Action NDAMMPOGDLL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class GFMNDJPOPPF<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly IKFKEMLINGF<T>? FHMKNJLGOLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly ReadOnlySequence<T> FLAKBDLOKPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private bool ECPCPMJNGEB;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly GFMNDJPOPPF<T> MMHNBCKELFI;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ReadOnlySequence<T> FMFDNJBFLBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x4D81B20", Offset = "0x4D80920", VA = "0x184D81B20")]
		get
		{
			return default(ReadOnlySequence<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long PHDDEAOOOBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x4D81D60", Offset = "0x4D80B60", VA = "0x184D81D60")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool NPDDCPKLJPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x4D81F40", Offset = "0x4D80D40", VA = "0x184D81F40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x4D823F0", Offset = "0x4D811F0", VA = "0x184D823F0")]
	public GFMNDJPOPPF(IKFKEMLINGF<T> LBNKDIIBLLM, IKFKEMLINGF<T> IEBLPNHJGLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x4D82860", Offset = "0x4D81660", VA = "0x184D82860")]
	public GFMNDJPOPPF(IKFKEMLINGF<T> LBNKDIIBLLM, int HBNCFIPENFO, IKFKEMLINGF<T> IEBLPNHJGLC, int IOAKGBLJAAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4D82340", Offset = "0x4D81140", VA = "0x184D82340")]
	private GFMNDJPOPPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4D81C20", Offset = "0x4D80A20", VA = "0x184D81C20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x4D820C0", Offset = "0x4D80EC0", VA = "0x184D820C0")]
	public T[] OOHJPFAIEAE()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x4D81E20", Offset = "0x4D80C20", VA = "0x184D81E20")]
	public static ReadOnlySequence<T> JGGBAIGHKJA(GFMNDJPOPPF<T>? NNFLKJPCODF)
	{
		return default(ReadOnlySequence<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct CDJCBPKFMAH<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly IDisposable KNCEGBICJJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public T HBDLGDLEPJD;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x67094C0", Offset = "0x67082C0", VA = "0x1867094C0")]
	public CDJCBPKFMAH(IDisposable PBHKHJPMFCF, [In] T BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3F365B0", Offset = "0x3F353B0", VA = "0x183F365B0")]
	public static CDJCBPKFMAH<U> OBEKJBFFFCC<U>([In] CDJCBPKFMAH<T> PBHKHJPMFCF, [In] U BNECONOIKOE) where U : notnull
	{
		return default(CDJCBPKFMAH<U>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6709340", Offset = "0x6708140", VA = "0x186709340", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class MGFHACJPGCD
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3C7DB40", Offset = "0x3C7C940", VA = "0x183C7DB40")]
	public static CDJCBPKFMAH<T> OGAKBGHEIKK<T>(IDisposable PBHKHJPMFCF, [In] T BNECONOIKOE) where T : notnull
	{
		return default(CDJCBPKFMAH<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3C7DAE0", Offset = "0x3C7C8E0", VA = "0x183C7DAE0")]
	public static CDJCBPKFMAH<T> CBJAODAOPAF<T>([In] this CDJCBPKFMAH<T> FEOFEEGOGIO, [Out] T BNECONOIKOE) where T : notnull
	{
		return default(CDJCBPKFMAH<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x310E430", Offset = "0x310D230", VA = "0x18310E430")]
	public static CDJCBPKFMAH<U?> OBEKJBFFFCC<U, T>([In] CDJCBPKFMAH<T> LHFHPNCEFFC, [In] U BNECONOIKOE)
	{
		return default(CDJCBPKFMAH<U>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public readonly struct CADHCNHOMBK : IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public readonly struct IHKLIIECGIL : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xAA3480", Offset = "0xAA2280", VA = "0x180AA3480")]
		public static IHKLIIECGIL OGAKBGHEIKK()
		{
			return default(IHKLIIECGIL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x8223300", Offset = "0x8222100", VA = "0x188223300")]
	public static string HBPCILOOBPG(Type DGPNPBEKOOD, [Optional] string? FNLMAFIMOEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3991D70", Offset = "0x3990B70", VA = "0x183991D70")]
	public static string? HBPCILOOBPG<T>([Optional] string? FNLMAFIMOEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3991DF0", Offset = "0x3990BF0", VA = "0x183991DF0")]
	public static string? HNIKPPPCEJK<T>([Optional] string? OJDMDLEGOPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xAA3480", Offset = "0xAA2280", VA = "0x180AA3480")]
	public static CADHCNHOMBK LJODEGLIPMG(string FNLMAFIMOEH, string? OJDMDLEGOPH)
	{
		return default(CADHCNHOMBK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct FEPMDMDELPI
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public delegate bool NMGGELPOBKA(string LFMNPEDNDIM, FEPMDMDELPI PKLLFCDDBFF);

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class FAAGNGKGJNN<T> where T : notnull, Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public List<int> enumValuesSubset;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public FAAGNGKGJNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x4C8CB20", Offset = "0x4C8B920", VA = "0x184C8CB20")]
		internal void AIKEDNBMDCP(T x)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public int HECBCEDKAOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public string FJDNHFBHOPH;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x8223BB0", Offset = "0x82229B0", VA = "0x188223BB0")]
	public static Dictionary<string, FEPMDMDELPI> LFDELKGMMIH(Type BOEOHEICOCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3B62E40", Offset = "0x3B61C40", VA = "0x183B62E40")]
	public static Dictionary<string, FEPMDMDELPI> LFDELKGMMIH<T>(Type BOEOHEICOCF, IReadOnlyDictionary<T, string> JJBFIJEDBBO) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3B62780", Offset = "0x3B61580", VA = "0x183B62780")]
	public static Dictionary<string, FEPMDMDELPI> AGPPBJFHCFJ<T>(List<T> GCDPFHBPMHC) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x8223EF0", Offset = "0x8222CF0", VA = "0x188223EF0")]
	public static Dictionary<string, FEPMDMDELPI> OIKHLAIJDLE(Type BOEOHEICOCF, NMGGELPOBKA ECLACMEJMBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x82239F0", Offset = "0x82227F0", VA = "0x1882239F0")]
	public static Dictionary<int, string> KBBJDPMFODB(Dictionary<string, FEPMDMDELPI> PBOOMELBCNJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public abstract class BHGDKCCPEDL : LJGAAONCGFM
{
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public static bool BDIGEFIIJKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly string? PDFFPNGALPI;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public virtual LJGAAONCGFM? CCHPLKGJGEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA58420", Offset = "0xA57220", VA = "0x180A58420", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8223290", Offset = "0x8222090", VA = "0x188223290")]
	protected BHGDKCCPEDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string KMHKNGKODJN();

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x8222C80", Offset = "0x8221A80", VA = "0x188222C80", Slot = "8")]
	public virtual string ANKDBFCMGCP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x8222D00", Offset = "0x8221B00", VA = "0x188222D00", Slot = "9")]
	public void CMCJDHDFEFE(StringBuilder CMOCPACEKCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x8223110", Offset = "0x8221F10", VA = "0x188223110", Slot = "10")]
	public void LFJFGAMPHOB(StringBuilder CMOCPACEKCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8223170", Offset = "0x8221F70", VA = "0x188223170", Slot = "11")]
	public void OIGBHADIPFK(StringBuilder CMOCPACEKCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x8222FB0", Offset = "0x8221DB0", VA = "0x188222FB0", Slot = "12")]
	public void HJIHJMLBAHB(StringBuilder CMOCPACEKCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x8222BE0", Offset = "0x82219E0", VA = "0x188222BE0")]
	public static void AMNLPMEACMO(StringBuilder CMOCPACEKCK, string NCPFIOFEKBK, string EELILKNMDJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x713F4E0", Offset = "0x713E2E0", VA = "0x18713F4E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class COGNKLAHAPJ : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x8223540", Offset = "0x8222340", VA = "0x188223540")]
	public COGNKLAHAPJ(string IIHOFBLPONF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class FJGJOMDGDIK<TErr> : COGNKLAHAPJ where TErr : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly TErr CAEGFIPOKDE;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4CB92E0", Offset = "0x4CB80E0", VA = "0x184CB92E0")]
	private FJGJOMDGDIK([In] TErr EKCIFFOKIPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4CB9210", Offset = "0x4CB8010", VA = "0x184CB9210")]
	public static FJGJOMDGDIK<TErr> OGAKBGHEIKK([In] TErr EKCIFFOKIPC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class ILBPCCFHMHK : Stream
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly HashAlgorithm LDHLGGNFGCK;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public override bool HOBDHNJAEPA
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xAA3480", Offset = "0xAA2280", VA = "0x180AA3480", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public override bool CCAKGDHINBP
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xAA3480", Offset = "0xAA2280", VA = "0x180AA3480", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public override bool IEALOJGHDLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA735B0", Offset = "0xA723B0", VA = "0x180A735B0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override long PHDDEAOOOBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x82251E0", Offset = "0x8223FE0", VA = "0x1882251E0", Slot = "12")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override long BKNMJONCLIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8225250", Offset = "0x8224050", VA = "0x188225250", Slot = "13")]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x82252C0", Offset = "0x82240C0", VA = "0x1882252C0", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x8225170", Offset = "0x8223F70", VA = "0x188225170")]
	public ILBPCCFHMHK(HashAlgorithm LDHLGGNFGCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x8224F90", Offset = "0x8223D90", VA = "0x188224F90", Slot = "35")]
	public override int Read(byte[] NHMENHDBHGG, int DOBKAGHAEBK, int LJEIHABMGGI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x8225140", Offset = "0x8223F40", VA = "0x188225140", Slot = "38")]
	public override void Write(byte[] NHMENHDBHGG, int DOBKAGHAEBK, int LJEIHABMGGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x8225030", Offset = "0x8223E30", VA = "0x188225030", Slot = "33")]
	public override long Seek(long DOBKAGHAEBK, SeekOrigin JKBPBEFFDAH)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x82250C0", Offset = "0x8223EC0", VA = "0x1882250C0", Slot = "34")]
	public override void SetLength(long BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "23")]
	public override void Flush()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x8224EB0", Offset = "0x8223CB0", VA = "0x188224EB0")]
	public byte[] LBMIKJFMMMI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface LJGAAONCGFM
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string ANKDBFCMGCP();

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string KMHKNGKODJN();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface CNAMMMNFFBJ<out TOptions> where TOptions : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	TOptions HBDLGDLEPJD
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface EMFMFKGCAEG
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	string LFMDCHLKDBP
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class IKFKEMLINGF<T> : ReadOnlySequenceSegment<T>, IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static IKFKEMLINGF<T>? BOEBBHHBGKP;

	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private static object HCJBCOKBOND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private IMemoryOwner<T>? GIJOEIOLOEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private bool ECPCPMJNGEB;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool DDMFODGPIEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xAB0CE0", Offset = "0xAAFAE0", VA = "0x180AB0CE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x4F26400", Offset = "0x4F25200", VA = "0x184F26400")]
	private static IKFKEMLINGF<T> DCFCFDPAGMM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x4F25E60", Offset = "0x4F24C60", VA = "0x184F25E60")]
	private static void BFHDGBCJNMI(IKFKEMLINGF<T> EKAIIOHNAOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x480B1E0", Offset = "0x4809FE0", VA = "0x18480B1E0")]
	private IKFKEMLINGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x4F26D00", Offset = "0x4F25B00", VA = "0x184F26D00")]
	public static IKFKEMLINGF<T> LDFHHMLGJNG(ReadOnlyMemory<T> BCHNIEHJGII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x4F27080", Offset = "0x4F25E80", VA = "0x184F27080")]
	public static IKFKEMLINGF<T> LDFHHMLGJNG(IMemoryOwner<T> DFGPPACLAHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x4F27460", Offset = "0x4F26260", VA = "0x184F27460")]
	public static void NKLLOLDINAM(IKFKEMLINGF<T> LBNKDIIBLLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x4F268A0", Offset = "0x4F256A0", VA = "0x184F268A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x4F27280", Offset = "0x4F26080", VA = "0x184F27280")]
	public IKFKEMLINGF<T> LGNINPLOOJF(IMemoryOwner<T> DFGPPACLAHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x4F27580", Offset = "0x4F26380", VA = "0x184F27580")]
	private void PEECBCPMMBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4F27350", Offset = "0x4F26150", VA = "0x184F27350")]
	private IKFKEMLINGF<T> NCDNOLNPFLK(IKFKEMLINGF<T> EKAIIOHNAOG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class AOHCPMGHMGB : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x82229E0", Offset = "0x82217E0", VA = "0x1882229E0")]
	public AOHCPMGHMGB(string IIHOFBLPONF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class HKPLHJCGPEF<TOk> : AOHCPMGHMGB where TOk : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly TOk IPKOLCBGLEG;

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x4E2F3C0", Offset = "0x4E2E1C0", VA = "0x184E2F3C0")]
	private HKPLHJCGPEF([In] TOk KIMFHGNCMNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x4E1BBA0", Offset = "0x4E1A9A0", VA = "0x184E1BBA0")]
	public static HKPLHJCGPEF<TOk> OGAKBGHEIKK([In] TOk KIMFHGNCMNJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public readonly struct CKPFCFEHEPP<TOk, TErr> : IEquatable<CKPFCFEHEPP<TOk, TErr>> where TOk : notnull where TErr : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly EqualityComparer<TErr> INGKBCKBGAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	internal readonly TErr CAEGFIPOKDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	internal readonly TOk IPKOLCBGLEG;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool FGFHAEIDCJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6803B10", Offset = "0x6802910", VA = "0x186803B10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool IONDHDFIPHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6804700", Offset = "0x6803500", VA = "0x186804700")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x68052C0", Offset = "0x68040C0", VA = "0x1868052C0")]
	internal CKPFCFEHEPP([In] TErr EKCIFFOKIPC, [In] TOk KIMFHGNCMNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6804920", Offset = "0x6803720", VA = "0x186804920")]
	public static CKPFCFEHEPP<TOk, TErr> OOPBJJJBAGK([In] TErr EKCIFFOKIPC)
	{
		return default(CKPFCFEHEPP<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6804680", Offset = "0x6803480", VA = "0x186804680")]
	public static CKPFCFEHEPP<TOk, TErr> HGDBEJCPEHB([In] TOk KIMFHGNCMNJ)
	{
		return default(CKPFCFEHEPP<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3F3A910", Offset = "0x3F39710", VA = "0x183F3A910")]
	public CKPFCFEHEPP<TOk?, UErr?> KMFDNNAKLGP<UErr>()
	{
		return default(CKPFCFEHEPP<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3F38F20", Offset = "0x3F37D20", VA = "0x183F38F20")]
	public CKPFCFEHEPP<UOk?, TErr?> IDEKJCGHBEP<UOk>()
	{
		return default(CKPFCFEHEPP<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x3F396A0", Offset = "0x3F384A0", VA = "0x183F396A0")]
	public CKPFCFEHEPP<UOk?, TErr?> JJDADOKADGL<UOk>()
	{
		return default(CKPFCFEHEPP<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3F39140", Offset = "0x3F37F40", VA = "0x183F39140")]
	public CKPFCFEHEPP<TOk?, UErr?> IMDKEPPNANH<UErr>()
	{
		return default(CKPFCFEHEPP<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x68034E0", Offset = "0x68022E0", VA = "0x1868034E0")]
	public CKPFCFEHEPP<CIEOHCAKAMM, TErr> ACFBOOPHKGC()
	{
		return default(CKPFCFEHEPP<CIEOHCAKAMM, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6804000", Offset = "0x6802E00", VA = "0x186804000")]
	public static bool HAHIHKOBLPE([In] CKPFCFEHEPP<TOk, TErr> EIECDDIBOHA, [In] CKPFCFEHEPP<TOk, TErr> AFKLBECCDNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6803570", Offset = "0x6802370", VA = "0x186803570", Slot = "4")]
	public bool Equals(CKPFCFEHEPP<TOk, TErr> LOKLFHKEJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x68037D0", Offset = "0x68025D0", VA = "0x1868037D0", Slot = "0")]
	public override bool Equals(object LOKLFHKEJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6803BD0", Offset = "0x68029D0", VA = "0x186803BD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6804E50", Offset = "0x6803C50", VA = "0x186804E50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class CNOKBMJEJML
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private struct GOCBFJABHNF<TOk, TErr> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public AsyncTaskMethodBuilder<TOk> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public Task<CKPFCFEHEPP<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private TaskAwaiter<CKPFCFEHEPP<TOk, TErr>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x4DD2070", Offset = "0x4DD0E70", VA = "0x184DD2070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x4DD26B0", Offset = "0x4DD14B0", VA = "0x184DD26B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x399E630", Offset = "0x399D430", VA = "0x18399E630")]
	public static CKPFCFEHEPP<TOk?, TErr?> IPKOLCBGLEG<TOk, TErr>([In] this CKPFCFEHEPP<TOk, TErr> FEOFEEGOGIO, [In] TOk KIMFHGNCMNJ)
	{
		return default(CKPFCFEHEPP<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x39A0330", Offset = "0x399F130", VA = "0x1839A0330")]
	public static CKPFCFEHEPP<CIEOHCAKAMM, TErr?> IPKOLCBGLEG<TErr>([In] this CKPFCFEHEPP<CIEOHCAKAMM, TErr> FEOFEEGOGIO)
	{
		return default(CKPFCFEHEPP<CIEOHCAKAMM, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x399E630", Offset = "0x399D430", VA = "0x18399E630")]
	public static CKPFCFEHEPP<TOk?, TErr?> CAEGFIPOKDE<TOk, TErr>([In] this CKPFCFEHEPP<TOk, TErr> FEOFEEGOGIO, [In] TErr EKCIFFOKIPC)
	{
		return default(CKPFCFEHEPP<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x399ED70", Offset = "0x399DB70", VA = "0x18399ED70")]
	public static TOk? EKOEILOGOND<TOk, TErr>([In] this CKPFCFEHEPP<TOk, TErr> FEOFEEGOGIO)
	{
		return (TOk?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x39A0090", Offset = "0x399EE90", VA = "0x1839A0090")]
	[AsyncStateMachine(typeof(GOCBFJABHNF<, >))]
	public static Task<TOk?>? GFDIAPLJGNN<TOk, TErr>(this Task<CKPFCFEHEPP<TOk, TErr>> FEOFEEGOGIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x39A1C50", Offset = "0x39A0A50", VA = "0x1839A1C50")]
	public static TErr? OMNIJKCIEFF<TErr, TOk>([In] this CKPFCFEHEPP<TOk, TErr> FEOFEEGOGIO)
	{
		return (TErr?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x39A06F0", Offset = "0x399F4F0", VA = "0x1839A06F0")]
	public static bool OBLPJNJJALC<TOk, TErr, UErr, UOk>([In] this CKPFCFEHEPP<TOk, TErr> FEOFEEGOGIO, [Out] CKPFCFEHEPP<UOk, UErr> KLLHEIFPGBC) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x39A1F10", Offset = "0x39A0D10", VA = "0x1839A1F10")]
	public static bool PBICBKPIBMC<TOk, TErr>([In] this CKPFCFEHEPP<TOk, TErr> FEOFEEGOGIO, [Out] TOk KIMFHGNCMNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x39A0500", Offset = "0x399F300", VA = "0x1839A0500")]
	public static bool KOGGIPGHLJF<TOk, TErr>([In] this CKPFCFEHEPP<TOk, TErr> FEOFEEGOGIO, [Out][NotNullWhen(true)] TErr EKCIFFOKIPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x39A21A0", Offset = "0x39A0FA0", VA = "0x1839A21A0")]
	public static bool PPJHEGCBNJE<TOk, TErr>([In] this CKPFCFEHEPP<TOk, TErr> FEOFEEGOGIO, [Out][NotNullWhen(true)] TOk KIMFHGNCMNJ, [Out][NotNullWhen(false)] TErr EKCIFFOKIPC) where TOk : notnull where TErr : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x39A03A0", Offset = "0x399F1A0", VA = "0x1839A03A0")]
	public static bool JJPAPAOPAAA<TOk, TErr>([In] this CKPFCFEHEPP<TOk, TErr> FEOFEEGOGIO, [Out][NotNullWhen(true)] TOk KIMFHGNCMNJ, [Out] CKPFCFEHEPP<TOk, TErr> KLLHEIFPGBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x39A0930", Offset = "0x399F730", VA = "0x1839A0930")]
	public static bool OBLPJNJJALC<TOk, TErr, UErr, UOk>([In] this CKPFCFEHEPP<TOk, TErr> FEOFEEGOGIO, [Out][NotNullWhen(true)] TOk KIMFHGNCMNJ, [Out] CKPFCFEHEPP<UOk, UErr> KLLHEIFPGBC) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x399E8B0", Offset = "0x399D6B0", VA = "0x18399E8B0")]
	public static bool DGIHFCIIGPP<TOk, TErr>([In] this CKPFCFEHEPP<TOk, TErr> FEOFEEGOGIO, [Out][NotNullWhen(true)] TOk KIMFHGNCMNJ, [Out] CKPFCFEHEPP<CIEOHCAKAMM, TErr> KLLHEIFPGBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x399F4B0", Offset = "0x399E2B0", VA = "0x18399F4B0")]
	public static CKPFCFEHEPP<UOk, UErr> FECEJECCACC<UOk, UErr, TOk, TErr>([In] this CKPFCFEHEPP<TOk, TErr> FEOFEEGOGIO, [In] CKPFCFEHEPP<UOk, UErr> FCNMCCJKGMG) where TOk : UOk where TErr : UErr
	{
		return default(CKPFCFEHEPP<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x399FB90", Offset = "0x399E990", VA = "0x18399FB90")]
	public static CKPFCFEHEPP<TOk?[]?, TErr?> GEBEDEHMPPB<TOk, TErr>(this IEnumerable<CKPFCFEHEPP<TOk, TErr>> FEOFEEGOGIO)
	{
		return default(CKPFCFEHEPP<TOk[], TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x399E3F0", Offset = "0x399D1F0", VA = "0x18399E3F0")]
	public static CKPFCFEHEPP<UOk?, TErr?> BJJHFEJKNPC<UOk, TErr, TOk>([In] this CKPFCFEHEPP<TOk, TErr> FEOFEEGOGIO, Func<TOk, UOk> IFBNEBPCNGL)
	{
		return default(CKPFCFEHEPP<UOk, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public static class BNNNNFAAKJN<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x3F33FD0", Offset = "0x3F32DD0", VA = "0x183F33FD0")]
	public static CKPFCFEHEPP<TOk, T> IPKOLCBGLEG<TOk>([In] TOk KIMFHGNCMNJ) where TOk : notnull
	{
		return default(CKPFCFEHEPP<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x63484D0", Offset = "0x63472D0", VA = "0x1863484D0")]
	public static CKPFCFEHEPP<CIEOHCAKAMM, T> IPKOLCBGLEG()
	{
		return default(CKPFCFEHEPP<CIEOHCAKAMM, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x3F33FD0", Offset = "0x3F32DD0", VA = "0x183F33FD0")]
	public static CKPFCFEHEPP<T, TErr> CAEGFIPOKDE<TErr>([In] TErr EKCIFFOKIPC) where TErr : notnull
	{
		return default(CKPFCFEHEPP<T, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public readonly struct LKFIIOFIHHG<TKey, TValue> where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly PNMKJACNMHC PHGLMNLIFAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly Dictionary<TKey, TValue> FANAJEGPFJI;

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x4FD0970", Offset = "0x4FCF770", VA = "0x184FD0970")]
	public static LKFIIOFIHHG<TKey, TValue> OGAKBGHEIKK(string IEOOLFDDEEF)
	{
		return default(LKFIIOFIHHG<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x4FD0A90", Offset = "0x4FCF890", VA = "0x184FD0A90")]
	internal LKFIIOFIHHG(Dictionary<TKey, TValue> BNECONOIKOE, PNMKJACNMHC HAEHHCKEGEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x4FD08C0", Offset = "0x4FCF6C0", VA = "0x184FD08C0")]
	public EMGOKPGMGMM<TKey, TValue> EPPILHPGGBJ([Out] Dictionary<TKey, TValue> BNECONOIKOE)
	{
		return default(EMGOKPGMGMM<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public readonly struct EMGOKPGMGMM<TKey, TValue> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly Dictionary<TKey, TValue> FANAJEGPFJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly DPLGKKKCINC KLCDPCGKMCO;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x2C0FB80", Offset = "0x2C0E980", VA = "0x182C0FB80")]
	internal EMGOKPGMGMM(Dictionary<TKey, TValue> BNECONOIKOE, DPLGKKKCINC GANGHIIMMIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x47FE2F0", Offset = "0x47FD0F0", VA = "0x1847FE2F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct ADPONNPCGAO<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly PNMKJACNMHC PHGLMNLIFAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly HashSet<T> FANAJEGPFJI;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x4FD0970", Offset = "0x4FCF770", VA = "0x184FD0970")]
	public static ADPONNPCGAO<T> OGAKBGHEIKK(string IEOOLFDDEEF)
	{
		return default(ADPONNPCGAO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x4FD0A90", Offset = "0x4FCF890", VA = "0x184FD0A90")]
	internal ADPONNPCGAO(HashSet<T> BNECONOIKOE, PNMKJACNMHC HAEHHCKEGEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x4FD08C0", Offset = "0x4FCF6C0", VA = "0x184FD08C0")]
	public EAEHPAKPAJF<T> EPPILHPGGBJ([Out] HashSet<T> BNECONOIKOE)
	{
		return default(EAEHPAKPAJF<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct EAEHPAKPAJF<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly HashSet<T> FANAJEGPFJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly DPLGKKKCINC KLCDPCGKMCO;

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x2C0FB80", Offset = "0x2C0E980", VA = "0x182C0FB80")]
	internal EAEHPAKPAJF(HashSet<T> BNECONOIKOE, DPLGKKKCINC GANGHIIMMIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x47FE2F0", Offset = "0x47FD0F0", VA = "0x1847FE2F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public readonly struct NPFLCEDAGLG<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly PNMKJACNMHC PHGLMNLIFAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly Stack<T> FANAJEGPFJI;

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x4FD0970", Offset = "0x4FCF770", VA = "0x184FD0970")]
	public static NPFLCEDAGLG<T> OGAKBGHEIKK(string IEOOLFDDEEF)
	{
		return default(NPFLCEDAGLG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x4FD0A90", Offset = "0x4FCF890", VA = "0x184FD0A90")]
	internal NPFLCEDAGLG(Stack<T> BNECONOIKOE, PNMKJACNMHC HAEHHCKEGEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x4FD08C0", Offset = "0x4FCF6C0", VA = "0x184FD08C0")]
	public FNDMLOOPFFE<T> EPPILHPGGBJ([Out] Stack<T> BNECONOIKOE)
	{
		return default(FNDMLOOPFFE<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public readonly struct FNDMLOOPFFE<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly Stack<T> FANAJEGPFJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly DPLGKKKCINC KLCDPCGKMCO;

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x2C0FB80", Offset = "0x2C0E980", VA = "0x182C0FB80")]
	internal FNDMLOOPFFE(Stack<T> BNECONOIKOE, DPLGKKKCINC GANGHIIMMIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x47FE2F0", Offset = "0x47FD0F0", VA = "0x1847FE2F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[DefaultMember("Item")]
public sealed class IKNAICCFBJA<T> : IEnumerable<T>, IEnumerable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private readonly struct NHFPECEJIGE : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly IKNAICCFBJA<T> LCGHKMEBHNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly int KDMGFPAKOAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly bool HMMPFOGDDHB;

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x2885150", Offset = "0x2883F50", VA = "0x182885150")]
		public NHFPECEJIGE(IKNAICCFBJA<T> HJPGLGOFFHP, int GDDGEMBMFCJ, bool EAPLGBDEDBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x56EB0F0", Offset = "0x56E9EF0", VA = "0x1856EB0F0")]
		public IKNAICCFBJA<T>.PHEALDEBLAO OMGGHMFPBJO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x56EB1E0", Offset = "0x56E9FE0", VA = "0x1856EB1E0", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x56EB1E0", Offset = "0x56E9FE0", VA = "0x1856EB1E0", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public sealed class PHEALDEBLAO : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly IKNAICCFBJA<T> LCGHKMEBHNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly int MCDPLDBGCPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private int NJCBMBGNEDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private readonly bool HMMPFOGDDHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private bool ELFMGNCBDKI;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public T BNFIAAPBEMM
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x5989BD0", Offset = "0x59889D0", VA = "0x185989BD0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x5989D40", Offset = "0x5988B40", VA = "0x185989D40", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x5989E20", Offset = "0x5988C20", VA = "0x185989E20", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x598A410", Offset = "0x5989210", VA = "0x18598A410")]
		public PHEALDEBLAO(IKNAICCFBJA<T> HJPGLGOFFHP, int GDDGEMBMFCJ, bool EAPLGBDEDBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x5989C50", Offset = "0x5988A50", VA = "0x185989C50", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x5989CE0", Offset = "0x5988AE0", VA = "0x185989CE0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class GPLEAKKBNHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public GPLEAKKBNHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x4DD8A20", Offset = "0x4DD7820", VA = "0x184DD8A20")]
		internal T CABKDCOCKPB(int _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly T[] KKOGLJLLEGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private int NJCBMBGNEDI;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int ABKDBFPGNLG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x4F2AFC0", Offset = "0x4F29DC0", VA = "0x184F2AFC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public T BNFIAAPBEMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x4C89BF0", Offset = "0x4C889F0", VA = "0x184C89BF0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public T CPHACEBIHDG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x4F2B250", Offset = "0x4F2A050", VA = "0x184F2B250")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public T CBMLGEIEAGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x4F2B130", Offset = "0x4F29F30", VA = "0x184F2B130")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int PHDDEAOOOBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x2825B50", Offset = "0x2824950", VA = "0x182825B50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x1C9C150", Offset = "0x1C9AF50", VA = "0x181C9C150")]
	private static int FLFMKFPMILI(int CKFKPOAGPKN, int IDFEOHMGIAF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x4F2B530", Offset = "0x4F2A330", VA = "0x184F2B530")]
	public IKNAICCFBJA(int DFCCCGNJINK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x4F2B310", Offset = "0x4F2A110", VA = "0x184F2B310")]
	public IKNAICCFBJA(int DFCCCGNJINK, Func<T> JLMGLBABBBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x4F2B640", Offset = "0x4F2A440", VA = "0x184F2B640")]
	public IKNAICCFBJA(T[] HPGGKMKJGLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x4F2B010", Offset = "0x4F29E10", VA = "0x184F2B010")]
	public void DCDHBCMKMHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x4F2B190", Offset = "0x4F29F90", VA = "0x184F2B190")]
	public IEnumerable<T> IKPJEHIHDMN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x4F2B280", Offset = "0x4F2A080", VA = "0x184F2B280")]
	public IKNAICCFBJA<T>.PHEALDEBLAO OMGGHMFPBJO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x4D62B50", Offset = "0x4D61950", VA = "0x184D62B50", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x4D62B50", Offset = "0x4D61950", VA = "0x184D62B50", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class IKHJKCIBBPI
{
	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x3BCA100", Offset = "0x3BC8F00", VA = "0x183BCA100")]
	public static IKNAICCFBJA<T> OGAKBGHEIKK<T>(int DFCCCGNJINK, Func<T> JLMGLBABBBN) where T : notnull
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
			[Cpp2IlInjected.Address(RVA = "0x6E48170", Offset = "0x6E46F70", VA = "0x186E48170")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static RRColor Green
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x82264C0", Offset = "0x82252C0", VA = "0x1882264C0")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public static RRColor Red
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x82264E0", Offset = "0x82252E0", VA = "0x1882264E0")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public static RRColor Yellow
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x8226500", Offset = "0x8225300", VA = "0x188226500")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public static RRColor Cyan
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x82264A0", Offset = "0x82252A0", VA = "0x1882264A0")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x29B79E0", Offset = "0x29B67E0", VA = "0x1829B79E0")]
		public RRColor(float GCOEALJJGEI, float JOBOJKEGCOM, float MANCHAKPLNN, float LKPLCEODICL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x80A43C0", Offset = "0x80A31C0", VA = "0x1880A43C0", Slot = "4")]
		public bool Equals(RRColor LOKLFHKEJPC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x82260E0", Offset = "0x8224EE0", VA = "0x1882260E0", Slot = "0")]
		public override bool Equals(object LOKLFHKEJPC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x82261E0", Offset = "0x8224FE0", VA = "0x1882261E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x8226260", Offset = "0x8225060", VA = "0x188226260", Slot = "5")]
		public string ToString(string PEIENLIDFFI, IFormatProvider NJDAMFPAAIO)
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
			[Cpp2IlInjected.Address(RVA = "0x8226080", Offset = "0x8224E80", VA = "0x188226080")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public static RRColor32 Green
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x8226020", Offset = "0x8224E20", VA = "0x188226020")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public static RRColor32 Red
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x8226050", Offset = "0x8224E50", VA = "0x188226050")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public static RRColor32 Yellow
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x82260B0", Offset = "0x8224EB0", VA = "0x1882260B0")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public static RRColor32 Cyan
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x8225FF0", Offset = "0x8224DF0", VA = "0x188225FF0")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x6032940", Offset = "0x6031740", VA = "0x186032940")]
		public RRColor32(byte GCOEALJJGEI, byte JOBOJKEGCOM, byte MANCHAKPLNN, byte LKPLCEODICL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x23CA4D0", Offset = "0x23C92D0", VA = "0x1823CA4D0", Slot = "4")]
		public bool Equals(RRColor32 LOKLFHKEJPC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x8225B30", Offset = "0x8224930", VA = "0x188225B30", Slot = "0")]
		public override bool Equals(object LOKLFHKEJPC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x14F1F20", Offset = "0x14F0D20", VA = "0x1814F1F20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x8225BC0", Offset = "0x82249C0", VA = "0x188225BC0")]
		public static RRColor32 JGGBAIGHKJA(RRColor BEIDDJJHBIM)
		{
			return default(RRColor32);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x8225D10", Offset = "0x8224B10", VA = "0x188225D10")]
		public static RRColor JGGBAIGHKJA(RRColor32 BEIDDJJHBIM)
		{
			return default(RRColor);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x8225D80", Offset = "0x8224B80", VA = "0x188225D80", Slot = "5")]
		public string ToString(string PEIENLIDFFI, IFormatProvider NJDAMFPAAIO)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class AKOFIKDCALI<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public readonly struct KJJHDNIKAEP : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private readonly AKOFIKDCALI<T> HDPNKJLPCAL;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public T HBDLGDLEPJD
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x52DCE20", Offset = "0x52DBC20", VA = "0x1852DCE20")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x52DCDF0", Offset = "0x52DBBF0", VA = "0x1852DCDF0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xE3B7E0", Offset = "0xE3A5E0", VA = "0x180E3B7E0")]
		public KJJHDNIKAEP(AKOFIKDCALI<T> HDPNKJLPCAL)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct MLJDAHKNLCC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public AsyncTaskMethodBuilder<KJJHDNIKAEP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public AKOFIKDCALI<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x5683700", Offset = "0x5682500", VA = "0x185683700", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x482EC90", Offset = "0x482DA90", VA = "0x18482EC90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly SemaphoreSlim DHDNHPGKNEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private T AIAICLJOCPG;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x50B91B0", Offset = "0x50B7FB0", VA = "0x1850B91B0")]
	public AKOFIKDCALI([In] T AIAICLJOCPG, int CEGMKDAKFCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x50B9190", Offset = "0x50B7F90", VA = "0x1850B9190")]
	public AKOFIKDCALI([In] T AIAICLJOCPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x50B90F0", Offset = "0x50B7EF0", VA = "0x1850B90F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x50B9150", Offset = "0x50B7F50", VA = "0x1850B9150")]
	public KJJHDNIKAEP PNBJBBMJIKL()
	{
		return default(KJJHDNIKAEP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x50B8FD0", Offset = "0x50B7DD0", VA = "0x1850B8FD0")]
	[AsyncStateMachine(typeof(AKOFIKDCALI<>.MLJDAHKNLCC))]
	public Task<AKOFIKDCALI<T>.KJJHDNIKAEP> CIIGFJGPOAN(CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x50B9130", Offset = "0x50B7F30", VA = "0x1850B9130")]
	public void IEKOEDLHHAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class GOCNJDAMHGH
{
	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x82247F0", Offset = "0x82235F0", VA = "0x1882247F0")]
	public static AKOFIKDCALI<CIEOHCAKAMM> OGAKBGHEIKK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x3122F60", Offset = "0x3121D60", VA = "0x183122F60")]
	public static AKOFIKDCALI<T> OGAKBGHEIKK<T>([In] T AIAICLJOCPG) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public sealed class POOIOJIMOGP<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public readonly struct IJMCFOJIHFH : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private readonly POOIOJIMOGP<T> CDEJPEBHLAB;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public T HBDLGDLEPJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x4807220", Offset = "0x4806020", VA = "0x184807220")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x4F22FC0", Offset = "0x4F21DC0", VA = "0x184F22FC0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0xE3B7E0", Offset = "0xE3A5E0", VA = "0x180E3B7E0")]
		internal IJMCFOJIHFH(POOIOJIMOGP<T> HDPNKJLPCAL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public readonly struct ECIHOGAFICF : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private readonly POOIOJIMOGP<T> CDEJPEBHLAB;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public T HBDLGDLEPJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x4807220", Offset = "0x4806020", VA = "0x184807220")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x4807180", Offset = "0x4805F80", VA = "0x184807180", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0xE3B7E0", Offset = "0xE3A5E0", VA = "0x180E3B7E0")]
		internal ECIHOGAFICF(POOIOJIMOGP<T> HDPNKJLPCAL)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct HICLFMNGMNJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public AsyncTaskMethodBuilder<ECIHOGAFICF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public POOIOJIMOGP<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private AKOFIKDCALI<CIEOHCAKAMM>.KJJHDNIKAEP <writeLock>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private TaskAwaiter<AKOFIKDCALI<CIEOHCAKAMM>.KJJHDNIKAEP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x4E242C0", Offset = "0x4E230C0", VA = "0x184E242C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x482EC90", Offset = "0x482DA90", VA = "0x18482EC90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly AKOFIKDCALI<int> CHJDLDGODHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly AKOFIKDCALI<CIEOHCAKAMM> DJKFJMDOJPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly AKOFIKDCALI<CIEOHCAKAMM> EAHOCHJDLGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private T HCJHOOFOMCK;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x59D0210", Offset = "0x59CF010", VA = "0x1859D0210")]
	internal POOIOJIMOGP(AKOFIKDCALI<int> POEPGDKJAOG, AKOFIKDCALI<CIEOHCAKAMM> DIGJNKPIIHK, AKOFIKDCALI<CIEOHCAKAMM> GKMHBLHKMMC, [In] T AIAICLJOCPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x59CF3E0", Offset = "0x59CE1E0", VA = "0x1859CF3E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x59CF830", Offset = "0x59CE630", VA = "0x1859CF830")]
	public IJMCFOJIHFH JEJBOKHGDOH()
	{
		return default(IJMCFOJIHFH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x59CF740", Offset = "0x59CE540", VA = "0x1859CF740")]
	public ECIHOGAFICF HFOAKAKOEPN()
	{
		return default(ECIHOGAFICF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x59CFFD0", Offset = "0x59CEDD0", VA = "0x1859CFFD0")]
	[AsyncStateMachine(typeof(POOIOJIMOGP<>.HICLFMNGMNJ))]
	public Task<POOIOJIMOGP<T>.ECIHOGAFICF> JLNDMBCLMMI(CancellationToken HIMDFBHMPLL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class EOGDCGPPHHJ
{
	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x8223600", Offset = "0x8222400", VA = "0x188223600")]
	public static POOIOJIMOGP<CIEOHCAKAMM> OGAKBGHEIKK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x3A1E2A0", Offset = "0x3A1D0A0", VA = "0x183A1E2A0")]
	public static POOIOJIMOGP<T> OGAKBGHEIKK<T>([In] T AIAICLJOCPG) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public sealed class EDPKBFMPPII<TData> : BHGDKCCPEDL where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public readonly string GMFKOEIGBMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public readonly TData HBHDBEHHINN;

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870", Slot = "7")]
	public override string KMHKNGKODJN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x4810890", Offset = "0x480F690", VA = "0x184810890")]
	internal EDPKBFMPPII(string IIHOFBLPONF, [In] TData BOIPFNOKGBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class CDMBFDGCFNE
{
	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x8223340", Offset = "0x8222140", VA = "0x188223340")]
	public static EDPKBFMPPII<CIEOHCAKAMM> OGAKBGHEIKK(string IIHOFBLPONF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x311BE10", Offset = "0x311AC10", VA = "0x18311BE10")]
	public static EDPKBFMPPII<TData> OGAKBGHEIKK<TData>(string IIHOFBLPONF, [In] TData BOIPFNOKGBJ) where TData : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public sealed class PNMKJACNMHC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	internal bool HDKLLDMFLEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly string JGMDEPMIBID;

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0xF37FE0", Offset = "0xF36DE0", VA = "0x180F37FE0")]
	private PNMKJACNMHC(bool NCJBJPFOJGC, string BMIMAJBOJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x8225AC0", Offset = "0x82248C0", VA = "0x188225AC0")]
	public static PNMKJACNMHC OGAKBGHEIKK(string BMIMAJBOJPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x8225A00", Offset = "0x8224800", VA = "0x188225A00")]
	public DPLGKKKCINC EPPILHPGGBJ()
	{
		return default(DPLGKKKCINC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public readonly struct DPLGKKKCINC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly PNMKJACNMHC GKGINDPIHKI;

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0xE3B7E0", Offset = "0xE3A5E0", VA = "0x180E3B7E0")]
	internal DPLGKKKCINC(PNMKJACNMHC IEOOLFDDEEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x82235A0", Offset = "0x82223A0", VA = "0x1882235A0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
[Obsolete("Use SimpleTokenFlag or WeakTokenFlag<T> instead")]
public sealed class PKFDOIPEFBI<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class DABKAFNONCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public DABKAFNONCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x6D9A160", Offset = "0x6D98F60", VA = "0x186D9A160")]
		internal int FMEAHLINCNI(int i, T token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private HashSet<T>? JHPHPGNOFCK;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public IReadOnlyCollection<T> FIEJNALCGJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x59C02B0", Offset = "0x59BF0B0", VA = "0x1859C02B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool BDDBOJMIPKP
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x4F7F890", Offset = "0x4F7E690", VA = "0x184F7F890")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int OOJPJFMJCLH
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0xA5E620", Offset = "0xA5D420", VA = "0x180A5E620")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0xA5E630", Offset = "0xA5D430", VA = "0x180A5E630")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x59C02E0", Offset = "0x59BF0E0", VA = "0x1859C02E0")]
	public bool OLHPIGGMIDE(T OCGDLEBGIMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x59C0190", Offset = "0x59BEF90", VA = "0x1859C0190")]
	public bool EBNLHEFHMEO(T OCGDLEBGIMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x59C00C0", Offset = "0x59BEEC0", VA = "0x1859C00C0")]
	public bool CGCEPCBCCPD(T OCGDLEBGIMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x59C0100", Offset = "0x59BEF00", VA = "0x1859C0100")]
	public void DMIOLEAJPNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x59C0450", Offset = "0x59BF250", VA = "0x1859C0450", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public PKFDOIPEFBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public sealed class JDCOMPLHBHF
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private sealed class MCJFKCMLKAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public MCJFKCMLKAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x82257E0", Offset = "0x82245E0", VA = "0x1882257E0")]
		internal int FMEAHLINCNI(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private HashSet<object>? JHPHPGNOFCK;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public IReadOnlyCollection<object> FIEJNALCGJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x82254B0", Offset = "0x82242B0", VA = "0x1882254B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool BDDBOJMIPKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x8225540", Offset = "0x8224340", VA = "0x188225540")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int OOJPJFMJCLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xA5E620", Offset = "0xA5D420", VA = "0x180A5E620")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0xA5E630", Offset = "0xA5D430", VA = "0x180A5E630")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x8225550", Offset = "0x8224350", VA = "0x188225550")]
	public bool OLHPIGGMIDE(object OCGDLEBGIMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x8225410", Offset = "0x8224210", VA = "0x188225410")]
	public bool EBNLHEFHMEO(object OCGDLEBGIMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x8225340", Offset = "0x8224140", VA = "0x188225340")]
	public bool CGCEPCBCCPD(object OCGDLEBGIMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x82253A0", Offset = "0x82241A0", VA = "0x1882253A0")]
	public void DMIOLEAJPNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x8225630", Offset = "0x8224430", VA = "0x188225630", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public JDCOMPLHBHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class NMLCKLLMNLK<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private struct HKJIOCMBBIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public float KPILEMPIFAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public T HBDLGDLEPJD;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly Dictionary<object, HKJIOCMBBIL> OBJPMEDBNDI;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public virtual T PNGOMFGFBPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x11D39F0", Offset = "0x11D27F0", VA = "0x1811D39F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x1B7EF40", Offset = "0x1B7DD40", VA = "0x181B7EF40", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public object? IAFHGJDJDGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0xA59850", Offset = "0xA58650", VA = "0x180A59850")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0xA59890", Offset = "0xA58690", VA = "0x180A59890")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool KFGGANBJPHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x4F7B440", Offset = "0x4F7A240", VA = "0x184F7B440")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x570EC60", Offset = "0x570DA60", VA = "0x18570EC60")]
	public bool GDOMOJLGIKD(T BNECONOIKOE, object OCGDLEBGIMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x4829D50", Offset = "0x4828B50", VA = "0x184829D50")]
	public bool FGGHDPDBNDA(object OCGDLEBGIMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x4F7B410", Offset = "0x4F7A210", VA = "0x184F7B410")]
	public void MKDKKBLDFOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x570E9C0", Offset = "0x570D7C0", VA = "0x18570E9C0")]
	public bool BNILIKGEJAF(object OCGDLEBGIMO, [Out] T BNECONOIKOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x570D300", Offset = "0x570C100", VA = "0x18570D300")]
	[FKKEMMHLABG("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool ADOFFDCCLFK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x482A2C0", Offset = "0x48290C0", VA = "0x18482A2C0")]
	public NMLCKLLMNLK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public sealed class GKAALNHEDFJ : IPHEKLDCFDC<NLHHJHMMPAF>
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	internal class OJDLCAIGKAA : IEqualityComparer<NLHHJHMMPAF>
	{
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		internal static readonly OJDLCAIGKAA ODAOEPEFKDK;

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x8225960", Offset = "0x8224760", VA = "0x188225960", Slot = "4")]
		public bool Equals(NLHHJHMMPAF DHOMBGCEEAK, NLHHJHMMPAF EDBCCDDDLPI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x7329990", Offset = "0x7328790", VA = "0x187329990", Slot = "5")]
		public int GetHashCode(NLHHJHMMPAF MKPNGAKJFMP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public OJDLCAIGKAA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x8224780", Offset = "0x8223580", VA = "0x188224780")]
	public GKAALNHEDFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x8224640", Offset = "0x8223440", VA = "0x188224640", Slot = "4")]
	public override bool OLHPIGGMIDE(NLHHJHMMPAF OCGDLEBGIMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x8224590", Offset = "0x8223390", VA = "0x188224590", Slot = "5")]
	public override bool EBNLHEFHMEO(NLHHJHMMPAF OCGDLEBGIMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x82246F0", Offset = "0x82234F0", VA = "0x1882246F0")]
	private static void ONOIAEPDLBG(NLHHJHMMPAF OCGDLEBGIMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0xABF380", Offset = "0xABE180", VA = "0x180ABF380", Slot = "6")]
	protected override string TokenToString(NLHHJHMMPAF OCGDLEBGIMO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public sealed class NLHHJHMMPAF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly string MJCLEFMBJHB;

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0xA665B0", Offset = "0xA653B0", VA = "0x180A665B0")]
	public NLHHJHMMPAF(string MJCLEFMBJHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x8225890", Offset = "0x8224690", VA = "0x188225890", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public abstract class IPHEKLDCFDC<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly IEqualityComparer<T> JPJEBIEBIKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private HashSet<T>? JHPHPGNOFCK;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public IReadOnlyCollection<T> FIEJNALCGJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x4F7F860", Offset = "0x4F7E660", VA = "0x184F7F860")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool BDDBOJMIPKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x4F7F890", Offset = "0x4F7E690", VA = "0x184F7F890")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int OOJPJFMJCLH
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0xAAEA50", Offset = "0xAAD850", VA = "0x180AAEA50")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0xAAEA60", Offset = "0xAAD860", VA = "0x180AAEA60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x4F80260", Offset = "0x4F7F060", VA = "0x184F80260")]
	public IPHEKLDCFDC(IEqualityComparer<T> JPJEBIEBIKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x4F7FA50", Offset = "0x4F7E850", VA = "0x184F7FA50", Slot = "4")]
	public virtual bool OLHPIGGMIDE(T OCGDLEBGIMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x4F7F730", Offset = "0x4F7E530", VA = "0x184F7F730", Slot = "5")]
	public virtual bool EBNLHEFHMEO(T OCGDLEBGIMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x4F7F580", Offset = "0x4F7E380", VA = "0x184F7F580")]
	public void DMIOLEAJPNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract string TokenToString(T OCGDLEBGIMO);

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x4F7FEC0", Offset = "0x4F7ECC0", VA = "0x184F7FEC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public sealed class DIOMFFANHLB<T> where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private List<WeakReference<T>>? JHPHPGNOFCK;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool BDDBOJMIPKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x6DE9B00", Offset = "0x6DE8900", VA = "0x186DE9B00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int OOJPJFMJCLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x6DE9820", Offset = "0x6DE8620", VA = "0x186DE9820")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x6DE9C00", Offset = "0x6DE8A00", VA = "0x186DE9C00")]
	public void OLHPIGGMIDE(T OCGDLEBGIMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x6DE99A0", Offset = "0x6DE87A0", VA = "0x186DE99A0")]
	public void EBNLHEFHMEO(T OCGDLEBGIMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x6DE9700", Offset = "0x6DE8500", VA = "0x186DE9700")]
	public bool CGCEPCBCCPD(T OCGDLEBGIMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x6DE9980", Offset = "0x6DE8780", VA = "0x186DE9980")]
	public void DMIOLEAJPNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x6DE9E20", Offset = "0x6DE8C20", VA = "0x186DE9E20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public DIOMFFANHLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal static class MNFHEHHFJPJ
{
	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x3C6C830", Offset = "0x3C6B630", VA = "0x183C6C830")]
	public static void BCJHCFOGIGA<T>(this List<T> ECEBLBALENP, int CKFKPOAGPKN) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class IOEOGJEHMDK<T> where T : notnull, IEquatable<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private struct PJGLPAHEGMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public float KPILEMPIFAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public T HBDLGDLEPJD;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly Dictionary<NLHHJHMMPAF, PJGLPAHEGMP> OBJPMEDBNDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private readonly EqualityComparer<T> CPGDPAJJFOK;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public virtual T PNGOMFGFBPF
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0xA60460", Offset = "0xA5F260", VA = "0x180A60460", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0xA60450", Offset = "0xA5F250", VA = "0x180A60450", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	private NLHHJHMMPAF? IAFHGJDJDGO
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0xA59830", Offset = "0xA58630", VA = "0x180A59830")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public bool KFGGANBJPHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x4F7B440", Offset = "0x4F7A240", VA = "0x184F7B440")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x4F7B230", Offset = "0x4F7A030", VA = "0x184F7B230")]
	public bool GDOMOJLGIKD(T BNECONOIKOE, NLHHJHMMPAF OCGDLEBGIMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x4829D50", Offset = "0x4828B50", VA = "0x184829D50")]
	public bool FGGHDPDBNDA(NLHHJHMMPAF OCGDLEBGIMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x4F7B410", Offset = "0x4F7A210", VA = "0x184F7B410")]
	public void MKDKKBLDFOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x4F7B140", Offset = "0x4F79F40", VA = "0x184F7B140")]
	public bool BNILIKGEJAF(NLHHJHMMPAF OCGDLEBGIMO, [Out] T BNECONOIKOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x4F7AEA0", Offset = "0x4F79CA0", VA = "0x184F7AEA0")]
	[FKKEMMHLABG("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool ADOFFDCCLFK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x4F7B5B0", Offset = "0x4F7A3B0", VA = "0x184F7B5B0")]
	public IOEOGJEHMDK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class HBGJBKCBBNE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly Dictionary<object, float> OBJPMEDBNDI;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public float JLKOJLBHNDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0xAB2D70", Offset = "0xAB1B70", VA = "0x180AB2D70")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x1330C40", Offset = "0x132FA40", VA = "0x181330C40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x82248D0", Offset = "0x82236D0", VA = "0x1882248D0")]
	public void GDOMOJLGIKD(float BNECONOIKOE, object OCGDLEBGIMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x8224860", Offset = "0x8223660", VA = "0x188224860")]
	public void FGGHDPDBNDA(object OCGDLEBGIMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x8224940", Offset = "0x8223740", VA = "0x188224940")]
	public void MKDKKBLDFOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x8224990", Offset = "0x8223790", VA = "0x188224990")]
	private void MNAFEICEOMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x8224AC0", Offset = "0x82238C0", VA = "0x188224AC0")]
	public HBGJBKCBBNE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public interface NHCDFALIEAO
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event NPDDMGKAAIH DPDGIENCCNM;
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class AOCMPNLIOFK : NHCDFALIEAO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public readonly struct FLFKGNIGHEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public readonly float BCBLGFMJHPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public readonly float OJELBMAMOAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		internal readonly bool IHBLCGMONJM;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public float FEILDOFOPCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x82242B0", Offset = "0x82230B0", VA = "0x1882242B0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x8224430", Offset = "0x8223230", VA = "0x188224430")]
		public FLFKGNIGHEG(float DKBLEPBOJIC, float CNDOBMAKBFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x82242C0", Offset = "0x82230C0", VA = "0x1882242C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class CJFFLGNNBGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public AOCMPNLIOFK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public CJFFLGNNBGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x82234A0", Offset = "0x82222A0", VA = "0x1882234A0")]
		internal void PEFGDIGCFAB(float innerProgress)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly int COJMCLGONLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private int IHLOLDGNHHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly NHCDFALIEAO[] NMPLPHJDAME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly NPDDMGKAAIH[] JBNGHMBPLHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly FLFKGNIGHEG[] MCDFHLBLOMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private FLFKGNIGHEG AFFGABJBJLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly HBGMKMHNODB LOPGOBHIICJ;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event NPDDMGKAAIH DPDGIENCCNM
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x82220B0", Offset = "0x8220EB0", VA = "0x1882220B0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x8222280", Offset = "0x8221080", VA = "0x188222280", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x8222850", Offset = "0x8221650", VA = "0x188222850")]
	public AOCMPNLIOFK(int COJMCLGONLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x82227C0", Offset = "0x82215C0", VA = "0x1882227C0")]
	public HBGMKMHNODB OFFOFEOKAGD(FLFKGNIGHEG FANOBLNBIII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x8222340", Offset = "0x8221140", VA = "0x188222340")]
	public void NLMHPFPGIMM(NHCDFALIEAO OOLLDNHGFHL, [Optional] FLFKGNIGHEG JCLBAKGPLHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x8222170", Offset = "0x8220F70", VA = "0x188222170", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public delegate void NPDDMGKAAIH(float CHNKJNHIHIH);
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class IJAKMMCJPLO
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	private class CEGHAKNLNCO : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private readonly NHCDFALIEAO DFNAKNGCEJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private readonly NPDDMGKAAIH JCDKDANAIEK;

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x8223410", Offset = "0x8222210", VA = "0x188223410")]
		public CEGHAKNLNCO(NHCDFALIEAO DFNAKNGCEJE, NPDDMGKAAIH JCDKDANAIEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x82233C0", Offset = "0x82221C0", VA = "0x1882233C0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x8224D80", Offset = "0x8223B80", VA = "0x188224D80")]
	internal static bool HEPLBHNFLJL(float LKPLCEODICL, float MANCHAKPLNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x8212B80", Offset = "0x8211980", VA = "0x188212B80")]
	internal static float CFHKHKKBPDF(float LKPLCEODICL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x8224DF0", Offset = "0x8223BF0", VA = "0x188224DF0")]
	public static IDisposable IDOCLAKBPKJ(this NHCDFALIEAO DFNAKNGCEJE, NPDDMGKAAIH JCDKDANAIEK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class HBGMKMHNODB : NHCDFALIEAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private float CHNKJNHIHIH;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public float MHEFPLLMPAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x8224BF0", Offset = "0x82239F0", VA = "0x188224BF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event NPDDMGKAAIH? DPDGIENCCNM
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x8224B50", Offset = "0x8223950", VA = "0x188224B50", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x8224CE0", Offset = "0x8223AE0", VA = "0x188224CE0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public HBGMKMHNODB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public interface OIAAHCMLKCC<T> where T : class, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BAEBDIENJAP<T> AOBILGBCGBI([Out] T BNECONOIKOE);

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MKDKKBLDFOH();
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class JPBEGPDLPBI<T> : OIAAHCMLKCC<T> where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly ConcurrentStack<T> GBBNLNGFIPH;

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x51F75B0", Offset = "0x51F63B0", VA = "0x1851F75B0", Slot = "4")]
	public BAEBDIENJAP<T> AOBILGBCGBI([Out] T BNECONOIKOE)
	{
		return default(BAEBDIENJAP<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x51F7700", Offset = "0x51F6500", VA = "0x1851F7700")]
	public void NIADOCPAAKN(T MJNEGKMBIFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x51F76D0", Offset = "0x51F64D0", VA = "0x1851F76D0", Slot = "5")]
	public void MKDKKBLDFOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "6")]
	protected virtual void KHGIJLOBBNI(T KJFJONAOKHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x51F7640", Offset = "0x51F6440", VA = "0x1851F7640")]
	private T LHCLHJGACJJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x51F7760", Offset = "0x51F6560", VA = "0x1851F7760")]
	public JPBEGPDLPBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public readonly struct BAEBDIENJAP<T> : IDisposable where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly T MJNEGKMBIFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly JPBEGPDLPBI<T> DLFKJJNLNDE;

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0xBC8270", Offset = "0xBC7070", VA = "0x180BC8270")]
	internal BAEBDIENJAP(T BNECONOIKOE, JPBEGPDLPBI<T> DLFKJJNLNDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x622CA80", Offset = "0x622B880", VA = "0x18622CA80", Slot = "4")]
	void IDisposable.Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class BGJDLDBJFEH : JPBEGPDLPBI<StringBuilder>
{
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public static readonly BGJDLDBJFEH ODAOEPEFKDK;

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x8222A60", Offset = "0x8221860", VA = "0x188222A60")]
	public static BAEBDIENJAP<StringBuilder> LHCLHJGACJJ([Out] StringBuilder BNECONOIKOE)
	{
		return default(BAEBDIENJAP<StringBuilder>);
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x8222A40", Offset = "0x8221840", VA = "0x188222A40", Slot = "6")]
	protected override void KHGIJLOBBNI(StringBuilder KJFJONAOKHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x8222BA0", Offset = "0x82219A0", VA = "0x188222BA0")]
	public BGJDLDBJFEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class FNFHJAKPFII : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x7A94E90", Offset = "0x7A93C90", VA = "0x187A94E90")]
	public FNFHJAKPFII(string IIHOFBLPONF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[DefaultMember("Item")]
public class CGABIIDGDDF<TKey, TValue> : PPBACGAMAMA<TKey, TValue>, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, EMGNDAHIPNA where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private sealed class IBKHFIMJIIB : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private KeyValuePair<TKey, TValue> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public CGABIIDGDDF<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private IEnumerator<KeyValuePair<TKey, TValue>> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		KeyValuePair<TKey, TValue> IEnumerator<KeyValuePair<TKey, TValue>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x11D39F0", Offset = "0x11D27F0", VA = "0x1811D39F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TValue>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x4D29590", Offset = "0x4D28390", VA = "0x184D29590", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0xA5BF60", Offset = "0xA5AD60", VA = "0x180A5BF60")]
		[DebuggerHidden]
		public IBKHFIMJIIB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x4D296C0", Offset = "0x4D284C0", VA = "0x184D296C0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x4F0FB60", Offset = "0x4F0E960", VA = "0x184F0FB60", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x4F0F250", Offset = "0x4F0E050", VA = "0x184F0F250")]
		private void KHMMOEFKMMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x4F0F110", Offset = "0x4F0DF10", VA = "0x184F0F110")]
		private void ICJNGMGPPIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x4F0FF40", Offset = "0x4F0ED40", VA = "0x184F0FF40", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly PPBACGAMAMA<TKey, TValue> BLALMDNDLEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly IDictionary<TKey, TValue> IOFBLMKDDCI;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int OOJPJFMJCLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x6715CB0", Offset = "0x6714AB0", VA = "0x186715CB0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool ECOGGGAIBMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0xAA3480", Offset = "0xAA2280", VA = "0x180AA3480", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public TValue CBMLGEIEAGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x6715D80", Offset = "0x6714B80", VA = "0x186715D80", Slot = "4")]
		get
		{
			return (TValue)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x6716010", Offset = "0x6714E10", VA = "0x186716010", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public ICollection<TKey> JHOIMAJLEIB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x6715DF0", Offset = "0x6714BF0", VA = "0x186715DF0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public ICollection<TValue> HIBGLNGFBED
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x6715F00", Offset = "0x6714D00", VA = "0x186715F00", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x6715A60", Offset = "0x6714860", VA = "0x186715A60")]
	public CGABIIDGDDF(PPBACGAMAMA<TKey, TValue> BLALMDNDLEH, [Optional] IDictionary<TKey, TValue>? IOFBLMKDDCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x6713940", Offset = "0x6712740", VA = "0x186713940", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x67141F0", Offset = "0x6712FF0", VA = "0x1867141F0")]
	public void DGHALNDCKOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x6713710", Offset = "0x6712510", VA = "0x186713710", Slot = "9")]
	public void Add(TKey MAHBBBBCDEL, TValue BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x6714CD0", Offset = "0x6713AD0", VA = "0x186714CD0")]
	public void PPOHGILDJHD(TKey MAHBBBBCDEL, TValue BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x6714430", Offset = "0x6713230", VA = "0x186714430")]
	public void KNGLLMBLNKH(TKey MAHBBBBCDEL, TValue BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x6713170", Offset = "0x6711F70", VA = "0x186713170")]
	public void ADBCGMPMLOE(TKey MAHBBBBCDEL, TValue BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x67145C0", Offset = "0x67133C0", VA = "0x1867145C0")]
	public void KPNNGHDMGJI(TKey MAHBBBBCDEL, TValue BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x67150E0", Offset = "0x6713EE0", VA = "0x1867150E0", Slot = "14")]
	void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> EHKDLJBBGDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x67152C0", Offset = "0x67140C0", VA = "0x1867152C0", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> EHKDLJBBGDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x6715480", Offset = "0x6714280", VA = "0x186715480", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> EHKDLJBBGDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x6713A50", Offset = "0x6712850", VA = "0x186713A50", Slot = "8")]
	public bool ContainsKey(TKey MAHBBBBCDEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x6714750", Offset = "0x6713550", VA = "0x186714750")]
	public bool LFPFJAPFBJH(TKey MAHBBBBCDEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x6714B30", Offset = "0x6713930", VA = "0x186714B30")]
	public bool NICJMLLLNEB(TKey MAHBBBBCDEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x6714E60", Offset = "0x6713C60", VA = "0x186714E60", Slot = "10")]
	public bool Remove(TKey MAHBBBBCDEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x67158C0", Offset = "0x67146C0", VA = "0x1867158C0", Slot = "11")]
	public bool TryGetValue(TKey MAHBBBBCDEL, [Out] TValue BNECONOIKOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x6713D50", Offset = "0x6712B50", VA = "0x186713D50", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TValue>[] COPOPHFGNFG, int PENDJAKLNMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x5276F70", Offset = "0x5275D70", VA = "0x185276F70", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x67142D0", Offset = "0x67130D0", VA = "0x1867142D0", Slot = "19")]
	[IteratorStateMachine(typeof(CGABIIDGDDF<, >.IBKHFIMJIIB))]
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x6713440", Offset = "0x6712240", VA = "0x186713440", Slot = "21")]
	public bool AHHDEJJBMMK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x67148E0", Offset = "0x67136E0", VA = "0x1867148E0")]
	private TValue MBFIJGBHGKG(TKey MAHBBBBCDEL)
	{
		return (TValue)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public interface NEMOPOMPCEN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000043")]
	string LPNLMDDPPGI
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public interface EMGNDAHIPNA
{
	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AHHDEJJBMMK();
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public interface PPBACGAMAMA<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, EMGNDAHIPNA
{
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[DefaultMember("Item")]
public sealed class DAOBLECFCHP<TKey, TVal> : PPBACGAMAMA<TKey, TVal>, IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, EMGNDAHIPNA where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public delegate int KEKIBCGGOOK(TKey MAHBBBBCDEL, TVal BNECONOIKOE);

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public delegate void BDMLHHAHKDN(TKey MAHBBBBCDEL, TVal BNECONOIKOE, CCHPPJLHJCE EGLDLGDMAJN);

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	private class BDGPENIJAHB
	{
		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public TKey PNDHCEECBFI
		{
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0xE4BDD0", Offset = "0xE4ABD0", VA = "0x180E4BDD0")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public TVal HBDLGDLEPJD
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0xAAEA50", Offset = "0xAAD850", VA = "0x180AAEA50")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0xAAEA60", Offset = "0xAAD860", VA = "0x180AAEA60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public int FEILDOFOPCL
		{
			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0xABC820", Offset = "0xABB620", VA = "0x180ABC820")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0xFF7DA0", Offset = "0xFF6BA0", VA = "0x180FF7DA0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public DateTimeOffset OIMKNJHIDIA
		{
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x1373CA0", Offset = "0x1372AA0", VA = "0x181373CA0")]
			[CompilerGenerated]
			get
			{
				return default(DateTimeOffset);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x1481EE0", Offset = "0x1480CE0", VA = "0x181481EE0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x62514F0", Offset = "0x62502F0", VA = "0x1862514F0")]
		public BDGPENIJAHB(TKey MAHBBBBCDEL, TVal HBLCHHJHKAF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private sealed class ECJJOHBAKJC : IEnumerator<KeyValuePair<TKey, TVal>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private KeyValuePair<TKey, TVal> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public DAOBLECFCHP<TKey, TVal> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private LinkedList<BDGPENIJAHB>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		KeyValuePair<TKey, TVal> IEnumerator<KeyValuePair<TKey, TVal>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x11D39F0", Offset = "0x11D27F0", VA = "0x1811D39F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TVal>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x480A1A0", Offset = "0x4808FA0", VA = "0x18480A1A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0xA5BF60", Offset = "0xA5AD60", VA = "0x180A5BF60")]
		[DebuggerHidden]
		public ECJJOHBAKJC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x480A230", Offset = "0x4809030", VA = "0x18480A230", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x4809320", Offset = "0x4808120", VA = "0x184809320", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x48075C0", Offset = "0x48063C0", VA = "0x1848075C0")]
		private void KHMMOEFKMMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x4809EE0", Offset = "0x4808CE0", VA = "0x184809EE0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public const int OCJGKLAIKIL = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly Dictionary<TKey, LinkedListNode<BDGPENIJAHB>> KFIDDBEGBNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly LinkedList<BDGPENIJAHB> JFKNNPPPECC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly KEKIBCGGOOK? AJAIOHJCJGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly TimeSpan PPIDGHLJAJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly BDMLHHAHKDN? ENGONDNAIJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly JANNOHPBADH GENLLHBFOPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private bool BBOHEKOMPAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private readonly List<TKey> EOOPNBGCFMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private readonly List<TVal> IDCJAGLCLJB;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public int FOILODIMODM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0xCFF240", Offset = "0xCFE040", VA = "0x180CFF240")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	internal int CKBMPPEMGMP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0xE41720", Offset = "0xE40520", VA = "0x180E41720")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0xF7F2C0", Offset = "0xF7E0C0", VA = "0x180F7F2C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int OOJPJFMJCLH
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x6D9FAA0", Offset = "0x6D9E8A0", VA = "0x186D9FAA0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	internal int KMNDIMEEHMA
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x6D9D080", Offset = "0x6D9BE80", VA = "0x186D9D080")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public ICollection<TVal> HIBGLNGFBED
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x6D9FB50", Offset = "0x6D9E950", VA = "0x186D9FB50", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	ICollection<TKey> IDictionary<TKey, TVal>.CIEFBLJHMKM
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x6D9EC70", Offset = "0x6D9DA70", VA = "0x186D9EC70", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool ECOGGGAIBMA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0xAA3480", Offset = "0xAA2280", VA = "0x180AA3480", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public TVal CBMLGEIEAGG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x6D9FB00", Offset = "0x6D9E900", VA = "0x186D9FB00", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x6D9FB80", Offset = "0x6D9E980", VA = "0x186D9FB80", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x6D9C970", Offset = "0x6D9B770", VA = "0x186D9C970")]
	private bool KEDKBNIPKDK(int COJMCLGONLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x6D9DB80", Offset = "0x6D9C980", VA = "0x186D9DB80")]
	private void OPOJIPBJLFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x6D9F060", Offset = "0x6D9DE60", VA = "0x186D9F060")]
	public DAOBLECFCHP(int COJMCLGONLG, [Optional] KEKIBCGGOOK? AJAIOHJCJGA, [Optional] IEqualityComparer<TKey>? IIMIJPBCCII, [Optional] BDMLHHAHKDN? ENGONDNAIJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x6D9F990", Offset = "0x6D9E790", VA = "0x186D9F990")]
	public DAOBLECFCHP(TimeSpan PPIDGHLJAJF, [Optional] IEqualityComparer<TKey>? IIMIJPBCCII, [Optional] BDMLHHAHKDN? ENGONDNAIJM, [Optional] JANNOHPBADH? GENLLHBFOPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x6D9F530", Offset = "0x6D9E330", VA = "0x186D9F530")]
	public DAOBLECFCHP(int COJMCLGONLG, TimeSpan PPIDGHLJAJF, [Optional] IEqualityComparer<TKey>? IIMIJPBCCII, [Optional] BDMLHHAHKDN? ENGONDNAIJM, [Optional] JANNOHPBADH? GENLLHBFOPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x6D9F580", Offset = "0x6D9E380", VA = "0x186D9F580")]
	public DAOBLECFCHP(int COJMCLGONLG, KEKIBCGGOOK? AJAIOHJCJGA, TimeSpan PPIDGHLJAJF, [Optional] IEqualityComparer<TKey>? IIMIJPBCCII, [Optional] BDMLHHAHKDN? ENGONDNAIJM, [Optional] JANNOHPBADH? GENLLHBFOPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x6D9AB00", Offset = "0x6D99900", VA = "0x186D9AB00", Slot = "21")]
	public bool AHHDEJJBMMK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x6D9B7B0", Offset = "0x6D9A5B0", VA = "0x186D9B7B0", Slot = "22")]
	public bool CLJIPIMAGOA(int DFCCCGNJINK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x6D9D0C0", Offset = "0x6D9BEC0", VA = "0x186D9D0C0")]
	private bool NOOOEJHILLF(int DFCCCGNJINK, CCHPPJLHJCE EGLDLGDMAJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x6D9C9C0", Offset = "0x6D9B7C0", VA = "0x186D9C9C0")]
	public void LAGAMOKKAFA(TKey MAHBBBBCDEL, TVal BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x6D9AE10", Offset = "0x6D99C10", VA = "0x186D9AE10", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> EHKDLJBBGDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x6D9ACC0", Offset = "0x6D99AC0", VA = "0x186D9ACC0", Slot = "9")]
	public void Add(TKey MAHBBBBCDEL, TVal BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x6D9B9F0", Offset = "0x6D9A7F0", VA = "0x186D9B9F0", Slot = "8")]
	public bool ContainsKey(TKey MAHBBBBCDEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x6D9E9A0", Offset = "0x6D9D7A0", VA = "0x186D9E9A0", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Contains(KeyValuePair<TKey, TVal> EHKDLJBBGDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x6D9E800", Offset = "0x6D9D600", VA = "0x186D9E800", Slot = "10")]
	public bool Remove(TKey MAHBBBBCDEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x6D9EB40", Offset = "0x6D9D940", VA = "0x186D9EB40", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Remove(KeyValuePair<TKey, TVal> EHKDLJBBGDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x6D9E5D0", Offset = "0x6D9D3D0", VA = "0x186D9E5D0")]
	private bool PMPLAMFNABF(TKey MAHBBBBCDEL, [Out] TVal BNECONOIKOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x6D9CBA0", Offset = "0x6D9B9A0", VA = "0x186D9CBA0")]
	private TVal LHCLHJGACJJ(TKey ANEBGMAHJJK)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x6D9EEA0", Offset = "0x6D9DCA0", VA = "0x186D9EEA0", Slot = "11")]
	public bool TryGetValue(TKey ANEBGMAHJJK, [Out] TVal BNECONOIKOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x6D9B8F0", Offset = "0x6D9A6F0", VA = "0x186D9B8F0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x6D9BA40", Offset = "0x6D9A840", VA = "0x186D9BA40", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] COPOPHFGNFG, int PENDJAKLNMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x6D9C830", Offset = "0x6D9B630", VA = "0x186D9C830")]
	private void JMNJNACBOKH(TKey MAHBBBBCDEL, TVal HBLCHHJHKAF, CCHPPJLHJCE EGLDLGDMAJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x6D9CDA0", Offset = "0x6D9BBA0", VA = "0x186D9CDA0")]
	private bool LOMDHENNPIC(BDGPENIJAHB PALLDBBGPIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x6D9B320", Offset = "0x6D9A120", VA = "0x186D9B320")]
	private void BLBNHGCDHHE(LinkedListNode<BDGPENIJAHB> MOOIMOLLDKA, TVal LNNEKAADPNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x6D9C0E0", Offset = "0x6D9AEE0", VA = "0x186D9C0E0")]
	private void GDOMOJLGIKD(TKey MAHBBBBCDEL, TVal BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x6D9DFD0", Offset = "0x6D9CDD0", VA = "0x186D9DFD0")]
	private void PHPALINLDJD(BDGPENIJAHB PALLDBBGPIN, TVal LNNEKAADPNI, int HGDAFHHJFGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x6D9C660", Offset = "0x6D9B460", VA = "0x186D9C660", Slot = "19")]
	[IteratorStateMachine(typeof(DAOBLECFCHP<, >.ECJJOHBAKJC))]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x6D9ECA0", Offset = "0x6D9DAA0", VA = "0x186D9ECA0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public enum CCHPPJLHJCE : byte
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
public class FOLFCBGBDGD<TKey> : Exception where TKey : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public readonly TKey EJACOLMODFI;

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x4CD9B40", Offset = "0x4CD8940", VA = "0x184CD9B40")]
	public FOLFCBGBDGD(TKey CDOFOOAGLJO, Exception CEFEOBEJCIJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class ABOENHKFANF : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x72BDE20", Offset = "0x72BCC20", VA = "0x1872BDE20")]
	public ABOENHKFANF(string IIHOFBLPONF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class OKFFMCIBPAN<TId, TResource> : IEnumerable<(TId, Task<TResource>, int)>, IEnumerable where TId : notnull where TResource : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private sealed class KHHEJGOOGGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public Func<TId, CancellationToken, Task<TResource>> factory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public OKFFMCIBPAN<TId, TResource> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public KHHEJGOOGGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x52CDE20", Offset = "0x52CCC20", VA = "0x1852CDE20")]
		internal Task<TResource> DKJIPOJHMCA(TId _id)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private struct ECFOEDMEHIP : IAsyncStateMachine
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
		public OKFFMCIBPAN<TId, TResource> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x4806470", Offset = "0x4805270", VA = "0x184806470", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x4807010", Offset = "0x4805E10", VA = "0x184807010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private struct CAPMONPCDMC : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x66FCED0", Offset = "0x66FBCD0", VA = "0x1866FCED0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x66FDB50", Offset = "0x66FC950", VA = "0x1866FDB50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private readonly CJOHDGGJDBK<TId, Task<TResource>> NFDPADLKIIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly Dictionary<Task<TResource>, CancellationTokenSource> DOBBOBAEBPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private readonly Func<TId, CancellationToken, Task<TResource>>? PLOEHDNOMDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private readonly Action<TResource>? JMEKIMEKEOH;

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x5862A00", Offset = "0x5861800", VA = "0x185862A00")]
	public OKFFMCIBPAN(int NMCMGBJLDBH = 0, [Optional] IEqualityComparer<TId>? GNGJMJECLPN, [Optional] Func<TId, CancellationToken, Task<TResource>>? HEOFLENKAPP, [Optional] Action<TResource>? KCCEHAKNIFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x5862240", Offset = "0x5861040", VA = "0x185862240")]
	public BFMFPOLFIAF<Task<TResource>> PHAEBEKFBAF(TId PPPFBKMGIMA, [Optional] Func<TId, CancellationToken, Task<TResource>>? HEOFLENKAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x5862610", Offset = "0x5861410", VA = "0x185862610")]
	private void PIMJEPFJMIL(Task<TResource> JNOGJECEFDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x58617E0", Offset = "0x58605E0", VA = "0x1858617E0")]
	[AsyncStateMachine(typeof(OKFFMCIBPAN<, >.ECFOEDMEHIP))]
	private Task OHKMGFDHFBL(Task<TResource> JNOGJECEFDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x58617B0", Offset = "0x58605B0", VA = "0x1858617B0")]
	public void FGIKEBEANOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x5861BE0", Offset = "0x58609E0", VA = "0x185861BE0")]
	public CJOHDGGJDBK<TId, Task<TResource>>.GJCNJBCNNMN OMGGHMFPBJO()
	{
		return default(CJOHDGGJDBK<TId, Task<TResource>>.GJCNJBCNNMN);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x58628C0", Offset = "0x58616C0", VA = "0x1858628C0", Slot = "4")]
	private IEnumerator<(TId, Task<TResource>, int)> System.Collections.Generic.IEnumerable<(TIdId,System.Threading.Tasks.Task<TResource>LoadResourceTask,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x58628C0", Offset = "0x58616C0", VA = "0x1858628C0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x5861680", Offset = "0x5860480", VA = "0x185861680")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(OKFFMCIBPAN<, >.CAPMONPCDMC))]
	internal static Task CPMGNACLNBJ(Task<TResource> JNOGJECEFDN, CancellationTokenSource EFFDKFEIDNL, Dictionary<Task<TResource>, CancellationTokenSource> MMCDJPIKPMG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public class CJOHDGGJDBK<TKey, TValue> : IEnumerable<(TKey, TValue, int)>, IEnumerable where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	private sealed class COJIDFAKLNC : IEquatable<COJIDFAKLNC>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public readonly TValue HBDLGDLEPJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public int ECGNLNGMAHA;

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x12DBED0", Offset = "0x12DACD0", VA = "0x1812DBED0")]
		public COJIDFAKLNC(TValue BNECONOIKOE, int CNHMEMACEOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x68E3E60", Offset = "0x68E2C60", VA = "0x1868E3E60", Slot = "4")]
		public bool Equals(COJIDFAKLNC? LOKLFHKEJPC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x68E3EF0", Offset = "0x68E2CF0", VA = "0x1868E3EF0", Slot = "0")]
		public override bool Equals(object? MKPNGAKJFMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x68E3F90", Offset = "0x68E2D90", VA = "0x1868E3F90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public struct GJCNJBCNNMN : IEnumerator<(TKey, TValue, int)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private Dictionary<TKey, COJIDFAKLNC>.Enumerator BNICPHDFHIJ;

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0x4D94B10", Offset = "0x4D93910", VA = "0x184D94B10", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public (TKey Key, TValue Value, int RefCount) BNFIAAPBEMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x4D94E00", Offset = "0x4D93C00", VA = "0x184D94E00", Slot = "4")]
			get
			{
				return default((TKey, TValue, int));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x4D94D40", Offset = "0x4D93B40", VA = "0x184D94D40")]
		public GJCNJBCNNMN(CJOHDGGJDBK<TKey, TValue> OBJPMEDBNDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x4D94600", Offset = "0x4D93400", VA = "0x184D94600", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x4D94680", Offset = "0x4D93480", VA = "0x184D94680", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x4D94910", Offset = "0x4D93710", VA = "0x184D94910", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private sealed class ALBLHCJKLDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public CJOHDGGJDBK<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public TKey key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public COJIDFAKLNC refCountedValue;

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public ALBLHCJKLDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x50BA690", Offset = "0x50B9490", VA = "0x1850BA690")]
		internal void DKJIPOJHMCA()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly Dictionary<TKey, COJIDFAKLNC> EMHBLJANFAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly Func<TKey, TValue>? IFPLGMOENFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private readonly Action<TValue>? BNAEHHLIKJN;

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x67FF5F0", Offset = "0x67FE3F0", VA = "0x1867FF5F0")]
	public CJOHDGGJDBK(int NMCMGBJLDBH = 0, [Optional] IEqualityComparer<TKey>? IIMIJPBCCII, [Optional] Func<TKey, TValue>? DCBINKBEPKI, [Optional] Action<TValue>? AIOCLMDCIII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x67FEE50", Offset = "0x67FDC50", VA = "0x1867FEE50")]
	public BFMFPOLFIAF<TValue> PHAEBEKFBAF(TKey MAHBBBBCDEL, [Optional] Func<TKey, TValue>? CLBLOBNKJOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x67FE520", Offset = "0x67FD320", VA = "0x1867FE520")]
	private void NIADOCPAAKN(TKey MAHBBBBCDEL, COJIDFAKLNC CEHNEALCFGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x67FDF40", Offset = "0x67FCD40", VA = "0x1867FDF40")]
	public void FGIKEBEANOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x67FE810", Offset = "0x67FD610", VA = "0x1867FE810")]
	public GJCNJBCNNMN OMGGHMFPBJO()
	{
		return default(GJCNJBCNNMN);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x67FF420", Offset = "0x67FE220", VA = "0x1867FF420", Slot = "4")]
	private IEnumerator<(TKey, TValue, int)> System.Collections.Generic.IEnumerable<(TKeyKey,TValueValue,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x67FF420", Offset = "0x67FE220", VA = "0x1867FF420", Slot = "5")]
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
