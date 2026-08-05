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
		[Cpp2IlInjected.Address(RVA = "0x98C9C0", Offset = "0x98BBC0", VA = "0x18098C9C0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7713B40", Offset = "0x7712D40", VA = "0x187713B40")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x98D6C0", Offset = "0x98C8C0", VA = "0x18098D6C0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x98D700", Offset = "0x98C900", VA = "0x18098D700")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class JHEPJEMCGKP
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	protected JHEPJEMCGKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class JMMHBHLAIGI<T> : JHEPJEMCGKP
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	protected struct BKMAOMDNEOD
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public enum PKGCMOKEDFN
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
		public PKGCMOKEDFN NNILCBOLNDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public T GJDAMJHNAPC;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private int AHKNBCOIBFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool HIGPGBCLMLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	protected readonly bool GKGDLBNPLLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	protected List<T>? HOINGJPIMPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<BKMAOMDNEOD>? CIMBBAJOCHO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool BFOIJCMMPHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x498E4D0", Offset = "0x498D6D0", VA = "0x18498E4D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x498EAA0", Offset = "0x498DCA0", VA = "0x18498EAA0")]
	protected JMMHBHLAIGI(bool GKGDLBNPLLE, bool HIGPGBCLMLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x498E0A0", Offset = "0x498D2A0", VA = "0x18498E0A0")]
	protected bool AOGPGDJIDIL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x498E140", Offset = "0x498D340", VA = "0x18498E140")]
	protected void BBOBHBBDHBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x498E260", Offset = "0x498D460", VA = "0x18498E260")]
	protected void EFHHELLLLJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3836320", Offset = "0x3835520", VA = "0x183836320")]
	private static void KEFNGCCNMLA<U>(List<U>? KBPAKCCMOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x498E6D0", Offset = "0x498D8D0", VA = "0x18498E6D0", Slot = "4")]
	public void OFEFHMDJLMD(T GJDAMJHNAPC, bool DGCMMCEPHEA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x498E8D0", Offset = "0x498DAD0", VA = "0x18498E8D0", Slot = "5")]
	public void OGPGHNCGHLC(T GJDAMJHNAPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x498E530", Offset = "0x498D730", VA = "0x18498E530")]
	public void NLADMABHKNO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class MIOEGIOIKAG : JMMHBHLAIGI<Action>
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x77137E0", Offset = "0x77129E0", VA = "0x1877137E0")]
	public MIOEGIOIKAG(bool GKGDLBNPLLE = false, bool HIGPGBCLMLL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7713520", Offset = "0x7712720", VA = "0x187713520")]
	public void LKNMLKMEAKD()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7713720", Offset = "0x7712920", VA = "0x187713720")]
	public static MIOEGIOIKAG NDMCJKDJPCM(MIOEGIOIKAG FPHDBHBGMKH, Action GJDAMJHNAPC)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7713780", Offset = "0x7712980", VA = "0x187713780")]
	public static MIOEGIOIKAG NNNKHLOOJNE(MIOEGIOIKAG FPHDBHBGMKH, Action GJDAMJHNAPC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface EFDKEBPKKMM<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OFEFHMDJLMD(Action<T> GJDAMJHNAPC, bool DGCMMCEPHEA = false);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OGPGHNCGHLC(Action<T> GJDAMJHNAPC);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class CHAOMIGHCFG<T> : JMMHBHLAIGI<Action<T>>, EFDKEBPKKMM<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4102120", Offset = "0x4101320", VA = "0x184102120")]
	public CHAOMIGHCFG(bool GKGDLBNPLLE = false, bool HIGPGBCLMLL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5AE5540", Offset = "0x5AE4740", VA = "0x185AE5540")]
	public void LKNMLKMEAKD(T FDDEDLKEPIJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x44B6440", Offset = "0x44B5640", VA = "0x1844B6440")]
	public static CHAOMIGHCFG<T> NDMCJKDJPCM(CHAOMIGHCFG<T> FPHDBHBGMKH, Action<T> GJDAMJHNAPC)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x44B64E0", Offset = "0x44B56E0", VA = "0x1844B64E0")]
	public static CHAOMIGHCFG<T> NNNKHLOOJNE(CHAOMIGHCFG<T> FPHDBHBGMKH, Action<T> GJDAMJHNAPC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface LMPONAIBOKE<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OFEFHMDJLMD(Action<T, U> GJDAMJHNAPC, bool DGCMMCEPHEA = false);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OGPGHNCGHLC(Action<T, U> GJDAMJHNAPC);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class NENPGIPFKEI<T, U> : JMMHBHLAIGI<Action<T, U>>, LMPONAIBOKE<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4102120", Offset = "0x4101320", VA = "0x184102120")]
	public NENPGIPFKEI(bool GKGDLBNPLLE = false, bool HIGPGBCLMLL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4E23C30", Offset = "0x4E22E30", VA = "0x184E23C30")]
	public void LKNMLKMEAKD(T FDDEDLKEPIJ, U HPIAJENJMNE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x44B6440", Offset = "0x44B5640", VA = "0x1844B6440")]
	public static NENPGIPFKEI<T, U> NDMCJKDJPCM(NENPGIPFKEI<T, U> FPHDBHBGMKH, Action<T, U> GJDAMJHNAPC)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x44B64E0", Offset = "0x44B56E0", VA = "0x1844B64E0")]
	public static NENPGIPFKEI<T, U> NNNKHLOOJNE(NENPGIPFKEI<T, U> FPHDBHBGMKH, Action<T, U> GJDAMJHNAPC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class FDIMHAPMLGB<T, U, V> : JMMHBHLAIGI<Action<T, U, V>> where T : notnull where U : notnull where V : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4102120", Offset = "0x4101320", VA = "0x184102120")]
	public FDIMHAPMLGB(bool GKGDLBNPLLE = false, bool HIGPGBCLMLL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x44B6100", Offset = "0x44B5300", VA = "0x1844B6100")]
	public void LKNMLKMEAKD(T FDDEDLKEPIJ, U HPIAJENJMNE, V OKAELCMAFHA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x44B6440", Offset = "0x44B5640", VA = "0x1844B6440")]
	public static FDIMHAPMLGB<T, U, V> NDMCJKDJPCM(FDIMHAPMLGB<T, U, V> FPHDBHBGMKH, Action<T, U, V> GJDAMJHNAPC)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x44B64E0", Offset = "0x44B56E0", VA = "0x1844B64E0")]
	public static FDIMHAPMLGB<T, U, V> NNNKHLOOJNE(FDIMHAPMLGB<T, U, V> FPHDBHBGMKH, Action<T, U, V> GJDAMJHNAPC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface BIOMAMAFIPK<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public sealed class JHBOFCGNMIE<T, U, V, W> : JMMHBHLAIGI<Action<T, U, V, W>>, BIOMAMAFIPK<T, U, V, W> where T : notnull where U : notnull where V : notnull where W : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4102120", Offset = "0x4101320", VA = "0x184102120")]
	public JHBOFCGNMIE(bool GKGDLBNPLLE = false, bool HIGPGBCLMLL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x49829D0", Offset = "0x4981BD0", VA = "0x1849829D0")]
	public void LKNMLKMEAKD(T FDDEDLKEPIJ, U HPIAJENJMNE, V OKAELCMAFHA, W IGJBFOFDOME)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x44B6440", Offset = "0x44B5640", VA = "0x1844B6440")]
	public static JHBOFCGNMIE<T, U, V, W> NDMCJKDJPCM(JHBOFCGNMIE<T, U, V, W> FPHDBHBGMKH, Action<T, U, V, W> GJDAMJHNAPC)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x44B64E0", Offset = "0x44B56E0", VA = "0x1844B64E0")]
	public static JHBOFCGNMIE<T, U, V, W> NNNKHLOOJNE(JHBOFCGNMIE<T, U, V, W> FPHDBHBGMKH, Action<T, U, V, W> GJDAMJHNAPC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class JHFGJFHPNLH<T, U, V, W, X> : JMMHBHLAIGI<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x4102120", Offset = "0x4101320", VA = "0x184102120")]
	public JHFGJFHPNLH(bool GKGDLBNPLLE = false, bool HIGPGBCLMLL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4984190", Offset = "0x4983390", VA = "0x184984190")]
	public void LKNMLKMEAKD(T FDDEDLKEPIJ, U HPIAJENJMNE, V OKAELCMAFHA, W IGJBFOFDOME, X NNDJDIFFAID)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x44B6440", Offset = "0x44B5640", VA = "0x1844B6440")]
	public static JHFGJFHPNLH<T, U, V, W, X> NDMCJKDJPCM(JHFGJFHPNLH<T, U, V, W, X> FPHDBHBGMKH, Action<T, U, V, W, X> GJDAMJHNAPC)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x44B64E0", Offset = "0x44B56E0", VA = "0x1844B64E0")]
	public static JHFGJFHPNLH<T, U, V, W, X> NNNKHLOOJNE(JHFGJFHPNLH<T, U, V, W, X> FPHDBHBGMKH, Action<T, U, V, W, X> GJDAMJHNAPC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class DDBHFKKIABH<T, U, V, W, X, Y> : JMMHBHLAIGI<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4102120", Offset = "0x4101320", VA = "0x184102120")]
	public DDBHFKKIABH(bool GKGDLBNPLLE = false, bool HIGPGBCLMLL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x637E170", Offset = "0x637D370", VA = "0x18637E170")]
	public void LKNMLKMEAKD(T FDDEDLKEPIJ, U HPIAJENJMNE, V OKAELCMAFHA, W IGJBFOFDOME, X NNDJDIFFAID, Y AMFIBFNKFFJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x44B6440", Offset = "0x44B5640", VA = "0x1844B6440")]
	public static DDBHFKKIABH<T, U, V, W, X, Y> NDMCJKDJPCM(DDBHFKKIABH<T, U, V, W, X, Y> FPHDBHBGMKH, Action<T, U, V, W, X, Y> GJDAMJHNAPC)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x44B64E0", Offset = "0x44B56E0", VA = "0x1844B64E0")]
	public static DDBHFKKIABH<T, U, V, W, X, Y> NNNKHLOOJNE(DDBHFKKIABH<T, U, V, W, X, Y> FPHDBHBGMKH, Action<T, U, V, W, X, Y> GJDAMJHNAPC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class NIKJKIOHLMH<TKey, TVal> where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly OFPMMIIHGKO<TKey, TVal> NGIAGHAMPOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly Dictionary<TKey, (TVal value, int size)> JOPKADKOIMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly OFPMMIIHGKO<TKey, TVal>.HLPEEFKIDBK? HGBKHPMHMHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly int ECEODOHDPNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly OFPMMIIHGKO<TKey, TVal>.PPMLNBHNDNO? CEKAEEOPHKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private int EKFMGEFMLJJ;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal int LEJPOJCFAMF
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x4E376F0", Offset = "0x4E368F0", VA = "0x184E376F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int AABBHHFGOKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x96C080", Offset = "0x96B280", VA = "0x18096C080")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4E380A0", Offset = "0x4E372A0", VA = "0x184E380A0")]
	public NIKJKIOHLMH(int ECEODOHDPNB, [Optional] OFPMMIIHGKO<TKey, TVal>.PPMLNBHNDNO? CEKAEEOPHKA, [Optional] IEqualityComparer<TKey>? EOOAJNLHDMI, [Optional] OFPMMIIHGKO<TKey, TVal>.HLPEEFKIDBK? HGBKHPMHMHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x4E37900", Offset = "0x4E36B00", VA = "0x184E37900")]
	public void OAKLINKEAMM(TKey MBDBONINAPC, TVal OMFJNFBDJCA, bool FKPMANAMBAC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4E37380", Offset = "0x4E36580", VA = "0x184E37380")]
	public bool FECLJACADOC(TKey MBDBONINAPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x4E37600", Offset = "0x4E36800", VA = "0x184E37600")]
	public bool JGIAJCMJDDJ(TKey EEJEPADMFFI, [Out] TVal OMFJNFBDJCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4E370D0", Offset = "0x4E362D0", VA = "0x184E370D0")]
	private void EEINJMOCHJJ(TKey MBDBONINAPC, TVal OMFJNFBDJCA, int IAGJHPFNLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4E36F20", Offset = "0x4E36120", VA = "0x184E36F20")]
	public bool AMBKPPGGNNF(TKey MBDBONINAPC, TVal OMFJNFBDJCA, bool FKPMANAMBAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4E37860", Offset = "0x4E36A60", VA = "0x184E37860")]
	public void NLADMABHKNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4E37B40", Offset = "0x4E36D40", VA = "0x184E37B40")]
	private void OMNHLJNIKJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4E36DF0", Offset = "0x4E35FF0", VA = "0x184E36DF0")]
	private bool AEKGGAFPGIK(TKey MBDBONINAPC, MBKBPMMFHLC HIIOCAFDBNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4E374E0", Offset = "0x4E366E0", VA = "0x184E374E0")]
	private void FOMAPKBLGDN(TKey MBDBONINAPC, TVal OMFJNFBDJCA, MBKBPMMFHLC HIIOCAFDBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4E37740", Offset = "0x4E36940", VA = "0x184E37740")]
	private void MDNPHOAOBGF(TKey MBDBONINAPC, TVal HBMPJOCKNNL, MBKBPMMFHLC HIIOCAFDBNN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class EHOFIMOFKID : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly Action HHOPCPJCIOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool MMPPABGHOOI;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x970550", Offset = "0x96F750", VA = "0x180970550")]
	public EHOFIMOFKID(Action JMDPHDEMCAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7711BD0", Offset = "0x7710DD0", VA = "0x187711BD0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3209070", Offset = "0x3208270", VA = "0x183209070")]
	public static OABDMFMONOH<T> JENMMFKNHKF<T>(T OMFJNFBDJCA, Action JMDPHDEMCAN) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class OABDMFMONOH<T> : EHOFIMOFKID where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public T CADNOMLIGCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x968CD0", Offset = "0x967ED0", VA = "0x180968CD0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4F43400", Offset = "0x4F42600", VA = "0x184F43400")]
	public OABDMFMONOH(T OMFJNFBDJCA, Action JMDPHDEMCAN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class JPMFBJELOEG<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly AFIIDKMNDAI<T>? NPNGFFAEECA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly ReadOnlySequence<T> HOABCIKNJPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private bool MMPPABGHOOI;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly JPMFBJELOEG<T> CENLOHBLGNG;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ReadOnlySequence<T> CJFHCMPAEKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x49A9D20", Offset = "0x49A8F20", VA = "0x1849A9D20")]
		get
		{
			return default(ReadOnlySequence<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long MCIABBAIGFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x49AA190", Offset = "0x49A9390", VA = "0x1849AA190")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool KHBFGBFEAPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x49AA010", Offset = "0x49A9210", VA = "0x1849AA010")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x49AA800", Offset = "0x49A9A00", VA = "0x1849AA800")]
	public JPMFBJELOEG(AFIIDKMNDAI<T> IIGFLGGBPJH, AFIIDKMNDAI<T> IBMJCICMCMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x49AA450", Offset = "0x49A9650", VA = "0x1849AA450")]
	public JPMFBJELOEG(AFIIDKMNDAI<T> IIGFLGGBPJH, int JMHJAFCGEDO, AFIIDKMNDAI<T> IBMJCICMCMI, int LPCCFPHDMLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x49AACA0", Offset = "0x49A9EA0", VA = "0x1849AACA0")]
	private JPMFBJELOEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x49A9E20", Offset = "0x49A9020", VA = "0x1849A9E20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x49A9F60", Offset = "0x49A9160", VA = "0x1849A9F60")]
	public T[] GAFBHFGGNLH()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x49A9C00", Offset = "0x49A8E00", VA = "0x1849A9C00")]
	public static ReadOnlySequence<T> AJAOLMPMCKD(JPMFBJELOEG<T>? GKFEAOLLEBA)
	{
		return default(ReadOnlySequence<T>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct BCBDICAALGE : IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct FFINGPDKDPO : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9ACBB0", Offset = "0x9ABDB0", VA = "0x1809ACBB0")]
		public static FFINGPDKDPO PEFMILKIAFF()
		{
			return default(FFINGPDKDPO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x77111E0", Offset = "0x77103E0", VA = "0x1877111E0")]
	public static string GMNAOODMEHC(Type NNILCBOLNDI, [Optional] string? LDBCMPGCAJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x31F0F30", Offset = "0x31F0130", VA = "0x1831F0F30")]
	public static string? GMNAOODMEHC<T>([Optional] string? LDBCMPGCAJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x31F0FB0", Offset = "0x31F01B0", VA = "0x1831F0FB0")]
	public static string? OOEIFIAFELK<T>([Optional] string? OIJCLFGFCJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x9ACBB0", Offset = "0x9ABDB0", VA = "0x1809ACBB0")]
	public static BCBDICAALGE DALNKPHMLDL(string LDBCMPGCAJK, string? OIJCLFGFCJG)
	{
		return default(BCBDICAALGE);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct LGFGNMFJLDG
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate bool MGNKNDJGHLC(string BBFDHKGOJEA, LGFGNMFJLDG MEHJFMCIANB);

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class GNOEDDGMDFJ<T> where T : notnull, Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public List<int> enumValuesSubset;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public GNOEDDGMDFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x462CCD0", Offset = "0x462BED0", VA = "0x18462CCD0")]
		internal void CNLCOFKGFKB(T x)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public int PMBHGOELOML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public string KCGGOHLDMFO;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x77131F0", Offset = "0x77123F0", VA = "0x1877131F0")]
	public static Dictionary<string, LGFGNMFJLDG> PJNJNJININL(Type GHOKLIOMHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3530C40", Offset = "0x352FE40", VA = "0x183530C40")]
	public static Dictionary<string, LGFGNMFJLDG> PJNJNJININL<T>(Type GHOKLIOMHCH, IReadOnlyDictionary<T, string> CBBKONAEMNN) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x35304E0", Offset = "0x352F6E0", VA = "0x1835304E0")]
	public static Dictionary<string, LGFGNMFJLDG> BDJAHHNFPMP<T>(List<T> KFABCCPIJBE) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7712E30", Offset = "0x7712030", VA = "0x187712E30")]
	public static Dictionary<string, LGFGNMFJLDG> OCPOPGAEDPG(Type GHOKLIOMHCH, MGNKNDJGHLC HGOOAAIPOCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7712C70", Offset = "0x7711E70", VA = "0x187712C70")]
	public static Dictionary<int, string> FICDKNECBGO(Dictionary<string, LGFGNMFJLDG> DPCGKOGCCDM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class ILEHMOEGHGD : GNOCHPEDIKN
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static bool EJLIPAECKJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly string? LKJFJMHHICP;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public virtual GNOCHPEDIKN? OMLPMJIPDPC
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x962E10", Offset = "0x962010", VA = "0x180962E10", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7712760", Offset = "0x7711960", VA = "0x187712760")]
	protected ILEHMOEGHGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string JBKGPNGEPEM();

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7712640", Offset = "0x7711840", VA = "0x187712640", Slot = "8")]
	public virtual string KBJJJNLHPGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x77123A0", Offset = "0x77115A0", VA = "0x1877123A0", Slot = "9")]
	public void JIELHHKNOEC(StringBuilder HAEDHINIEDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x77120C0", Offset = "0x77112C0", VA = "0x1877120C0", Slot = "10")]
	public void AKLFGKNPMNM(StringBuilder HAEDHINIEDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7712280", Offset = "0x7711480", VA = "0x187712280", Slot = "11")]
	public void GACKIIBIAOD(StringBuilder HAEDHINIEDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7712120", Offset = "0x7711320", VA = "0x187712120", Slot = "12")]
	public void DCGCIJHLHIB(StringBuilder HAEDHINIEDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x77126C0", Offset = "0x77118C0", VA = "0x1877126C0")]
	public static void PFJBBFCKMBG(StringBuilder HAEDHINIEDK, string AHMEOBJEAJP, string CGNNPGJFADH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x677EAB0", Offset = "0x677DCB0", VA = "0x18677EAB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class ACPIJNBFJNG : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7711010", Offset = "0x7710210", VA = "0x187711010")]
	public ACPIJNBFJNG(string DCEACFEGBDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class GCNCDOOHNJP<TErr> : ACPIJNBFJNG where TErr : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly TErr AABOHKKCDOP;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x45F27F0", Offset = "0x45F19F0", VA = "0x1845F27F0")]
	private GCNCDOOHNJP([In] TErr MIPBDJJHJCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x45F2720", Offset = "0x45F1920", VA = "0x1845F2720")]
	public static GCNCDOOHNJP<TErr> PEFMILKIAFF([In] TErr MIPBDJJHJCL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class DPPIKNGMKLK : Stream
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly HashAlgorithm FDHBGFJGEPO;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public override bool DCFOAAIHDCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x9ACBB0", Offset = "0x9ABDB0", VA = "0x1809ACBB0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public override bool LHCIPCGAGGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x9ACBB0", Offset = "0x9ABDB0", VA = "0x1809ACBB0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public override bool CDJIJONCGOC
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x97D6F0", Offset = "0x97C8F0", VA = "0x18097D6F0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override long MCIABBAIGFN
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7711A80", Offset = "0x7710C80", VA = "0x187711A80", Slot = "12")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override long LAHGFMKGHMK
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7711AF0", Offset = "0x7710CF0", VA = "0x187711AF0", Slot = "13")]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7711B60", Offset = "0x7710D60", VA = "0x187711B60", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7711A10", Offset = "0x7710C10", VA = "0x187711A10")]
	public DPPIKNGMKLK(HashAlgorithm FDHBGFJGEPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7711840", Offset = "0x7710A40", VA = "0x187711840", Slot = "35")]
	public override int Read(byte[] LPBGEKCBGMP, int DCNPLBBIONO, int IPBKHOJKHLJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x77119E0", Offset = "0x7710BE0", VA = "0x1877119E0", Slot = "38")]
	public override void Write(byte[] LPBGEKCBGMP, int DCNPLBBIONO, int IPBKHOJKHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x77118E0", Offset = "0x7710AE0", VA = "0x1877118E0", Slot = "33")]
	public override long Seek(long DCNPLBBIONO, SeekOrigin MEPDDJJJJDK)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7711970", Offset = "0x7710B70", VA = "0x187711970", Slot = "34")]
	public override void SetLength(long OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "23")]
	public override void Flush()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7711770", Offset = "0x7710970", VA = "0x187711770")]
	public byte[] KHKNDEFBPEA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface GNOCHPEDIKN
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string KBJJJNLHPGA();

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string JBKGPNGEPEM();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface CDCIKMKCJGM<out TOptions> where TOptions : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	TOptions CADNOMLIGCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface DHFPMGBPJKO
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	string KNJIHJDNPCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class AFIIDKMNDAI<T> : ReadOnlySequenceSegment<T>, IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private static AFIIDKMNDAI<T>? FKOKLMGKJOG;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private static object PIGHDAOGCDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private IMemoryOwner<T>? FCCLLLFLCDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private bool MMPPABGHOOI;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool HMMGIGDCPMP
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xC6B200", Offset = "0xC6A400", VA = "0x180C6B200")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x4654A30", Offset = "0x4653C30", VA = "0x184654A30")]
	private static AFIIDKMNDAI<T> EDKKHJFHBNL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x4653B80", Offset = "0x4652D80", VA = "0x184653B80")]
	private static void BPEHNLJMJDM(AFIIDKMNDAI<T> JEGCJIJPAHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x4655850", Offset = "0x4654A50", VA = "0x184655850")]
	private AFIIDKMNDAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x46551F0", Offset = "0x46543F0", VA = "0x1846551F0")]
	public static AFIIDKMNDAI<T> JENMMFKNHKF(ReadOnlyMemory<T> DPJNDOLAGIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x46553C0", Offset = "0x46545C0", VA = "0x1846553C0")]
	public static AFIIDKMNDAI<T> JENMMFKNHKF(IMemoryOwner<T> BDPNGEOHOJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x4654120", Offset = "0x4653320", VA = "0x184654120")]
	public static void CBMDNJCHCEL(AFIIDKMNDAI<T> IIGFLGGBPJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x4654550", Offset = "0x4653750", VA = "0x184654550", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x4654450", Offset = "0x4653650", VA = "0x184654450")]
	public AFIIDKMNDAI<T> CJGOCCAKNMF(IMemoryOwner<T> BDPNGEOHOJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x4654350", Offset = "0x4653550", VA = "0x184654350")]
	private void CDPGJOGJHFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x4654EE0", Offset = "0x46540E0", VA = "0x184654EE0")]
	private AFIIDKMNDAI<T> GCJBLFIAFEA(AFIIDKMNDAI<T> JEGCJIJPAHE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class NMLHKGNIBLD : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7713AE0", Offset = "0x7712CE0", VA = "0x187713AE0")]
	public NMLHKGNIBLD(string DCEACFEGBDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class FGGDCKAPFBI<TOk> : NMLHKGNIBLD where TOk : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly TOk HFPGBPGBPEP;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x44C0A00", Offset = "0x44BFC00", VA = "0x1844C0A00")]
	private FGGDCKAPFBI([In] TOk CONGEMGLMKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x44C0870", Offset = "0x44BFA70", VA = "0x1844C0870")]
	public static FGGDCKAPFBI<TOk> PEFMILKIAFF([In] TOk CONGEMGLMKN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public readonly struct CPEANPEHCAG<TOk, TErr> : IEquatable<CPEANPEHCAG<TOk, TErr>> where TOk : notnull where TErr : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static readonly EqualityComparer<TErr> GOBAIJDLHDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	internal readonly TErr AABOHKKCDOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	internal readonly TOk HFPGBPGBPEP;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool GOAHIFMKIHF
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x5DC8C20", Offset = "0x5DC7E20", VA = "0x185DC8C20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool CHIGLBBCFDK
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5DC9C40", Offset = "0x5DC8E40", VA = "0x185DC9C40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5DCD730", Offset = "0x5DCC930", VA = "0x185DCD730")]
	internal CPEANPEHCAG([In] TErr MIPBDJJHJCL, [In] TOk CONGEMGLMKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5DC97C0", Offset = "0x5DC89C0", VA = "0x185DC97C0")]
	public static CPEANPEHCAG<TOk, TErr> LCDBPBIBLND([In] TErr MIPBDJJHJCL)
	{
		return default(CPEANPEHCAG<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5DC81D0", Offset = "0x5DC73D0", VA = "0x185DC81D0")]
	public static CPEANPEHCAG<TOk, TErr> IMACNCMADAO([In] TOk CONGEMGLMKN)
	{
		return default(CPEANPEHCAG<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x34451E0", Offset = "0x34443E0", VA = "0x1834451E0")]
	public CPEANPEHCAG<TOk?, UErr?> OJGOJMODCHO<UErr>()
	{
		return default(CPEANPEHCAG<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x34438A0", Offset = "0x3442AA0", VA = "0x1834438A0")]
	public CPEANPEHCAG<UOk?, TErr?> HIJOMOLMPCP<UOk>()
	{
		return default(CPEANPEHCAG<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x3444970", Offset = "0x3443B70", VA = "0x183444970")]
	public CPEANPEHCAG<UOk?, TErr?> OGBBABPIMLK<UOk>()
	{
		return default(CPEANPEHCAG<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x34456C0", Offset = "0x34448C0", VA = "0x1834456C0")]
	public CPEANPEHCAG<TOk?, UErr?> PDDBIKHALPB<UErr>()
	{
		return default(CPEANPEHCAG<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5DC4080", Offset = "0x5DC3280", VA = "0x185DC4080")]
	public CPEANPEHCAG<OJADAPCHIGK, TErr> CIMFBELDBAL()
	{
		return default(CPEANPEHCAG<OJADAPCHIGK, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5DC5880", Offset = "0x5DC4A80", VA = "0x185DC5880")]
	public static bool GJNOMHNHJKL([In] CPEANPEHCAG<TOk, TErr> MGBGOAGHGOJ, [In] CPEANPEHCAG<TOk, TErr> FCFMBBJABHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x5DC4710", Offset = "0x5DC3910", VA = "0x185DC4710", Slot = "4")]
	public bool Equals(CPEANPEHCAG<TOk, TErr> LDKNLBHIGFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x5DC4580", Offset = "0x5DC3780", VA = "0x185DC4580", Slot = "0")]
	public override bool Equals(object LDKNLBHIGFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5DC6C80", Offset = "0x5DC5E80", VA = "0x185DC6C80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x5DCD040", Offset = "0x5DCC240", VA = "0x185DCD040", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class IAAMOOLININ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct HCLEAODKMCB<TOk, TErr> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public AsyncTaskMethodBuilder<TOk> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public Task<CPEANPEHCAG<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private TaskAwaiter<CPEANPEHCAG<TOk, TErr>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x469A280", Offset = "0x4699480", VA = "0x18469A280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x469A8C0", Offset = "0x4699AC0", VA = "0x18469A8C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x34CCDD0", Offset = "0x34CBFD0", VA = "0x1834CCDD0")]
	public static CPEANPEHCAG<TOk?, TErr?> HFPGBPGBPEP<TOk, TErr>([In] this CPEANPEHCAG<TOk, TErr> NAELBAPCKEH, [In] TOk CONGEMGLMKN)
	{
		return default(CPEANPEHCAG<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x34CF670", Offset = "0x34CE870", VA = "0x1834CF670")]
	public static CPEANPEHCAG<OJADAPCHIGK, TErr?> HFPGBPGBPEP<TErr>([In] this CPEANPEHCAG<OJADAPCHIGK, TErr> NAELBAPCKEH)
	{
		return default(CPEANPEHCAG<OJADAPCHIGK, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x34CCDD0", Offset = "0x34CBFD0", VA = "0x1834CCDD0")]
	public static CPEANPEHCAG<TOk?, TErr?> AABOHKKCDOP<TOk, TErr>([In] this CPEANPEHCAG<TOk, TErr> NAELBAPCKEH, [In] TErr MIPBDJJHJCL)
	{
		return default(CPEANPEHCAG<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x34CFC80", Offset = "0x34CEE80", VA = "0x1834CFC80")]
	public static TOk? JOACNCJFAAF<TOk, TErr>([In] this CPEANPEHCAG<TOk, TErr> NAELBAPCKEH)
	{
		return (TOk?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x34CCF80", Offset = "0x34CC180", VA = "0x1834CCF80")]
	[AsyncStateMachine(typeof(HCLEAODKMCB<, >))]
	public static Task<TOk?>? BIKODCNNFGB<TOk, TErr>(this Task<CPEANPEHCAG<TOk, TErr>> NAELBAPCKEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x34D04E0", Offset = "0x34CF6E0", VA = "0x1834D04E0")]
	public static TErr? NADAODNLIFE<TErr, TOk>([In] this CPEANPEHCAG<TOk, TErr> NAELBAPCKEH)
	{
		return (TErr?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x34CE140", Offset = "0x34CD340", VA = "0x1834CE140")]
	public static bool DGEKBIAPLDA<TOk, TErr, UErr, UOk>([In] this CPEANPEHCAG<TOk, TErr> NAELBAPCKEH, [Out] CPEANPEHCAG<UOk, UErr> MBCLMNPGAKK) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x34CD250", Offset = "0x34CC450", VA = "0x1834CD250")]
	public static bool BNDDHGNMJAE<TOk, TErr>([In] this CPEANPEHCAG<TOk, TErr> NAELBAPCKEH, [Out] TOk CONGEMGLMKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x34D07F0", Offset = "0x34CF9F0", VA = "0x1834D07F0")]
	public static bool PGFKOKOKIFI<TOk, TErr>([In] this CPEANPEHCAG<TOk, TErr> NAELBAPCKEH, [Out][NotNullWhen(true)] TErr MIPBDJJHJCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x34CF470", Offset = "0x34CE670", VA = "0x1834CF470")]
	public static bool HCGGMAGNGGG<TOk, TErr>([In] this CPEANPEHCAG<TOk, TErr> NAELBAPCKEH, [Out][NotNullWhen(true)] TOk CONGEMGLMKN, [Out][NotNullWhen(false)] TErr MIPBDJJHJCL) where TOk : notnull where TErr : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x34D06F0", Offset = "0x34CF8F0", VA = "0x1834D06F0")]
	public static bool ONMFOBDHIFN<TOk, TErr>([In] this CPEANPEHCAG<TOk, TErr> NAELBAPCKEH, [Out][NotNullWhen(true)] TOk CONGEMGLMKN, [Out] CPEANPEHCAG<TOk, TErr> MBCLMNPGAKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x34CDEE0", Offset = "0x34CD0E0", VA = "0x1834CDEE0")]
	public static bool DGEKBIAPLDA<TOk, TErr, UErr, UOk>([In] this CPEANPEHCAG<TOk, TErr> NAELBAPCKEH, [Out][NotNullWhen(true)] TOk CONGEMGLMKN, [Out] CPEANPEHCAG<UOk, UErr> MBCLMNPGAKK) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x34CF030", Offset = "0x34CE230", VA = "0x1834CF030")]
	public static bool GBOELFFBKAN<TOk, TErr>([In] this CPEANPEHCAG<TOk, TErr> NAELBAPCKEH, [Out][NotNullWhen(true)] TOk CONGEMGLMKN, [Out] CPEANPEHCAG<OJADAPCHIGK, TErr> MBCLMNPGAKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x34CD6C0", Offset = "0x34CC8C0", VA = "0x1834CD6C0")]
	public static CPEANPEHCAG<UOk, UErr> DANLDJPLDHP<UOk, UErr, TOk, TErr>([In] this CPEANPEHCAG<TOk, TErr> NAELBAPCKEH, [In] CPEANPEHCAG<UOk, UErr> JEBOOCGPANP) where TOk : UOk where TErr : UErr
	{
		return default(CPEANPEHCAG<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x34CFF60", Offset = "0x34CF160", VA = "0x1834CFF60")]
	public static CPEANPEHCAG<TOk?[]?, TErr?> LKMLIFHGOBI<TOk, TErr>(this IEnumerable<CPEANPEHCAG<TOk, TErr>> NAELBAPCKEH)
	{
		return default(CPEANPEHCAG<TOk[], TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x34CF700", Offset = "0x34CE900", VA = "0x1834CF700")]
	public static CPEANPEHCAG<UOk?, TErr?> JDODKOHLKAP<UOk, TErr, TOk>([In] this CPEANPEHCAG<TOk, TErr> NAELBAPCKEH, Func<TOk, UOk> IPKAJEHADHC)
	{
		return default(CPEANPEHCAG<UOk, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class GCFJBCCJHNG<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x36D2C10", Offset = "0x36D1E10", VA = "0x1836D2C10")]
	public static CPEANPEHCAG<TOk, T> HFPGBPGBPEP<TOk>([In] TOk CONGEMGLMKN) where TOk : notnull
	{
		return default(CPEANPEHCAG<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x45F2090", Offset = "0x45F1290", VA = "0x1845F2090")]
	public static CPEANPEHCAG<OJADAPCHIGK, T> HFPGBPGBPEP()
	{
		return default(CPEANPEHCAG<OJADAPCHIGK, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x36D2C10", Offset = "0x36D1E10", VA = "0x1836D2C10")]
	public static CPEANPEHCAG<T, TErr> AABOHKKCDOP<TErr>([In] TErr MIPBDJJHJCL) where TErr : notnull
	{
		return default(CPEANPEHCAG<T, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public readonly struct DJMMBHJLCCB<TKey, TValue> where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly BDEAIILHJGA KIHCILKGOCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly Dictionary<TKey, TValue> POIKBKLOBIK;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x411A680", Offset = "0x4119880", VA = "0x18411A680")]
	public static DJMMBHJLCCB<TKey, TValue> PEFMILKIAFF(string IBLIOEFMDMM)
	{
		return default(DJMMBHJLCCB<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x411A7A0", Offset = "0x41199A0", VA = "0x18411A7A0")]
	internal DJMMBHJLCCB(Dictionary<TKey, TValue> OMFJNFBDJCA, BDEAIILHJGA KHBGDJAAGOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x411A5E0", Offset = "0x41197E0", VA = "0x18411A5E0")]
	public NOAEPBMFNNN<TKey, TValue> GNCFFOAFAFP([Out] Dictionary<TKey, TValue> OMFJNFBDJCA)
	{
		return default(NOAEPBMFNNN<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public readonly struct NOAEPBMFNNN<TKey, TValue> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly Dictionary<TKey, TValue> POIKBKLOBIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly NCKCPDBLNIG CFBJEDONLPL;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x27CC590", Offset = "0x27CB790", VA = "0x1827CC590")]
	internal NOAEPBMFNNN(Dictionary<TKey, TValue> OMFJNFBDJCA, NCKCPDBLNIG ACGAJBANLGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x4E5A2F0", Offset = "0x4E594F0", VA = "0x184E5A2F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public readonly struct EMLFFJFOOLN<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly BDEAIILHJGA KIHCILKGOCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly HashSet<T> POIKBKLOBIK;

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x411A680", Offset = "0x4119880", VA = "0x18411A680")]
	public static EMLFFJFOOLN<T> PEFMILKIAFF(string IBLIOEFMDMM)
	{
		return default(EMLFFJFOOLN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x411A7A0", Offset = "0x41199A0", VA = "0x18411A7A0")]
	internal EMLFFJFOOLN(HashSet<T> OMFJNFBDJCA, BDEAIILHJGA KHBGDJAAGOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x411A5E0", Offset = "0x41197E0", VA = "0x18411A5E0")]
	public DPNODGGIACJ<T> GNCFFOAFAFP([Out] HashSet<T> OMFJNFBDJCA)
	{
		return default(DPNODGGIACJ<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public readonly struct DPNODGGIACJ<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly HashSet<T> POIKBKLOBIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly NCKCPDBLNIG CFBJEDONLPL;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x27CC590", Offset = "0x27CB790", VA = "0x1827CC590")]
	internal DPNODGGIACJ(HashSet<T> OMFJNFBDJCA, NCKCPDBLNIG ACGAJBANLGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x4E5A2F0", Offset = "0x4E594F0", VA = "0x184E5A2F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct FNEOCFJCOLO<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly BDEAIILHJGA KIHCILKGOCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly Stack<T> POIKBKLOBIK;

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x411A680", Offset = "0x4119880", VA = "0x18411A680")]
	public static FNEOCFJCOLO<T> PEFMILKIAFF(string IBLIOEFMDMM)
	{
		return default(FNEOCFJCOLO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x411A7A0", Offset = "0x41199A0", VA = "0x18411A7A0")]
	internal FNEOCFJCOLO(Stack<T> OMFJNFBDJCA, BDEAIILHJGA KHBGDJAAGOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x411A5E0", Offset = "0x41197E0", VA = "0x18411A5E0")]
	public BEDFJOPOOLJ<T> GNCFFOAFAFP([Out] Stack<T> OMFJNFBDJCA)
	{
		return default(BEDFJOPOOLJ<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct BEDFJOPOOLJ<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly Stack<T> POIKBKLOBIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly NCKCPDBLNIG CFBJEDONLPL;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x27CC590", Offset = "0x27CB790", VA = "0x1827CC590")]
	internal BEDFJOPOOLJ(Stack<T> OMFJNFBDJCA, NCKCPDBLNIG ACGAJBANLGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x4E5A2F0", Offset = "0x4E594F0", VA = "0x184E5A2F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[DefaultMember("Item")]
public sealed class FCDINAOBNNI<T> : IEnumerable<T>, IEnumerable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private readonly struct INGOOBNELGE : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly FCDINAOBNNI<T> GEBLDODDHJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly int HKBOLJILBEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly bool EMLONBBHKNA;

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x24A99F0", Offset = "0x24A8BF0", VA = "0x1824A99F0")]
		public INGOOBNELGE(FCDINAOBNNI<T> PIJKIPKKMLF, int LEBLNPMDCPF, bool PCPKAKAIKKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x4784680", Offset = "0x4783880", VA = "0x184784680")]
		public FCDINAOBNNI<T>.PJPECLBDOHA PACLDABBHPO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x4784770", Offset = "0x4783970", VA = "0x184784770", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x4784770", Offset = "0x4783970", VA = "0x184784770", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public sealed class PJPECLBDOHA : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly FCDINAOBNNI<T> GEBLDODDHJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly int LOLMKKBHHBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private int HCBPNJECLDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly bool EMLONBBHKNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private bool CCJMCINGJAF;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public T PEOKKFBMNKJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x512EE40", Offset = "0x512E040", VA = "0x18512EE40")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x512EEE0", Offset = "0x512E0E0", VA = "0x18512EEE0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x512EF90", Offset = "0x512E190", VA = "0x18512EF90", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x512F430", Offset = "0x512E630", VA = "0x18512F430")]
		public PJPECLBDOHA(FCDINAOBNNI<T> PIJKIPKKMLF, int LEBLNPMDCPF, bool PCPKAKAIKKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x512ED30", Offset = "0x512DF30", VA = "0x18512ED30", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x512EEC0", Offset = "0x512E0C0", VA = "0x18512EEC0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class LKMDKBLOLAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public LKMDKBLOLAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x4B890F0", Offset = "0x4B882F0", VA = "0x184B890F0")]
		internal T GGGHCEFPACF(int _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly T[] APDKFLJACDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int HCBPNJECLDC;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int KEFCCPNHNNI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x44B1300", Offset = "0x44B0500", VA = "0x1844B1300")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public T PEOKKFBMNKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x44A2700", Offset = "0x44A1900", VA = "0x1844A2700")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public T GOKBCIEPFDC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x44B1290", Offset = "0x44B0490", VA = "0x1844B1290")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public T EPCJHJAGLJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x44B11B0", Offset = "0x44B03B0", VA = "0x1844B11B0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int MCIABBAIGFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x100BD90", Offset = "0x100AF90", VA = "0x18100BD90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x18A32E0", Offset = "0x18A24E0", VA = "0x1818A32E0")]
	private static int MJJLMEFENCF(int KOOLKCPAFBB, int EEBDBIBAAFF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x44B1640", Offset = "0x44B0840", VA = "0x1844B1640")]
	public FCDINAOBNNI(int IAGJHPFNLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x44B16C0", Offset = "0x44B08C0", VA = "0x1844B16C0")]
	public FCDINAOBNNI(int IAGJHPFNLHJ, Func<T> EDOOAPKOJBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x44B1500", Offset = "0x44B0700", VA = "0x1844B1500")]
	public FCDINAOBNNI(T[] IDDPONMNMLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x44B12D0", Offset = "0x44B04D0", VA = "0x1844B12D0")]
	public void KGFNKPNNKFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x44B1360", Offset = "0x44B0560", VA = "0x1844B1360")]
	public IEnumerable<T> NHCDHLMONGP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x44B1420", Offset = "0x44B0620", VA = "0x1844B1420")]
	public FCDINAOBNNI<T>.PJPECLBDOHA PACLDABBHPO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x44B14C0", Offset = "0x44B06C0", VA = "0x1844B14C0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x44B14C0", Offset = "0x44B06C0", VA = "0x1844B14C0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class LJOMIADCNAJ
{
	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x353B3C0", Offset = "0x353A5C0", VA = "0x18353B3C0")]
	public static FCDINAOBNNI<T> PEFMILKIAFF<T>(int IAGJHPFNLHJ, Func<T> EDOOAPKOJBG) where T : notnull
	{
		return null;
	}
}
namespace RecRoom.NoEngine.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public struct RRColor : IEquatable<RRColor>, IFormattable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public float r;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public float g;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public float b;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public float a;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static RRColor White
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x77151B0", Offset = "0x77143B0", VA = "0x1877151B0")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static RRColor Green
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x7715170", Offset = "0x7714370", VA = "0x187715170")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public static RRColor Red
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x7715190", Offset = "0x7714390", VA = "0x187715190")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public static RRColor Yellow
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x77151D0", Offset = "0x77143D0", VA = "0x1877151D0")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public static RRColor Cyan
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x7715150", Offset = "0x7714350", VA = "0x187715150")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x25B1800", Offset = "0x25B0A00", VA = "0x1825B1800")]
		public RRColor(float LIBECIMLPKK, float MMKDKMMHEOO, float FHOBAJOBBGC, float IHGFIECIOLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x75E5EB0", Offset = "0x75E50B0", VA = "0x1875E5EB0", Slot = "4")]
		public bool Equals(RRColor LDKNLBHIGFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x7714D90", Offset = "0x7713F90", VA = "0x187714D90", Slot = "0")]
		public override bool Equals(object LDKNLBHIGFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x7714E90", Offset = "0x7714090", VA = "0x187714E90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x7714F10", Offset = "0x7714110", VA = "0x187714F10", Slot = "5")]
		public string ToString(string FLMAPKGOONP, IFormatProvider DKKCLFCLIHE)
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public struct RRColor32 : IEquatable<RRColor32>, IFormattable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private int rgba;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public byte r;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public byte g;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public byte b;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public byte a;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public static RRColor32 White
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x7714D30", Offset = "0x7713F30", VA = "0x187714D30")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public static RRColor32 Green
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x7714CD0", Offset = "0x7713ED0", VA = "0x187714CD0")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public static RRColor32 Red
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x7714D00", Offset = "0x7713F00", VA = "0x187714D00")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public static RRColor32 Yellow
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x7714D60", Offset = "0x7713F60", VA = "0x187714D60")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public static RRColor32 Cyan
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x7714CA0", Offset = "0x7713EA0", VA = "0x187714CA0")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x5714440", Offset = "0x5713640", VA = "0x185714440")]
		public RRColor32(byte LIBECIMLPKK, byte MMKDKMMHEOO, byte FHOBAJOBBGC, byte IHGFIECIOLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x1F61D20", Offset = "0x1F60F20", VA = "0x181F61D20", Slot = "4")]
		public bool Equals(RRColor32 LDKNLBHIGFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x77149A0", Offset = "0x7713BA0", VA = "0x1877149A0", Slot = "0")]
		public override bool Equals(object LDKNLBHIGFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x1152400", Offset = "0x1151600", VA = "0x181152400", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x7714850", Offset = "0x7713A50", VA = "0x187714850")]
		public static RRColor32 AJAOLMPMCKD(RRColor CPCFIJBFPJB)
		{
			return default(RRColor32);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x77147E0", Offset = "0x77139E0", VA = "0x1877147E0")]
		public static RRColor AJAOLMPMCKD(RRColor32 CPCFIJBFPJB)
		{
			return default(RRColor);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x7714A30", Offset = "0x7713C30", VA = "0x187714A30", Slot = "5")]
		public string ToString(string FLMAPKGOONP, IFormatProvider DKKCLFCLIHE)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public sealed class LKDFKHANNJN<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public readonly struct KNHKOJLPJAA : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private readonly LKDFKHANNJN<T> AFMPLHCNALG;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public T CADNOMLIGCM
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x4AA1EE0", Offset = "0x4AA10E0", VA = "0x184AA1EE0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x4AA1F00", Offset = "0x4AA1100", VA = "0x184AA1F00", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xC1A5C0", Offset = "0xC197C0", VA = "0x180C1A5C0")]
		public KNHKOJLPJAA(LKDFKHANNJN<T> AFMPLHCNALG)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct NHEMNJCAPFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder<KNHKOJLPJAA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public LKDFKHANNJN<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x4E32E70", Offset = "0x4E32070", VA = "0x184E32E70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x45F1B90", Offset = "0x45F0D90", VA = "0x1845F1B90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly SemaphoreSlim NKNBFHNNOLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private T DMCBANBGNBP;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x4B89050", Offset = "0x4B88250", VA = "0x184B89050")]
	public LKDFKHANNJN([In] T DMCBANBGNBP, int CDAJBDBFMCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x4B88E20", Offset = "0x4B88020", VA = "0x184B88E20")]
	public LKDFKHANNJN([In] T DMCBANBGNBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x4B88D80", Offset = "0x4B87F80", VA = "0x184B88D80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x4B88DE0", Offset = "0x4B87FE0", VA = "0x184B88DE0")]
	public KNHKOJLPJAA PAOJBFPFPKA()
	{
		return default(KNHKOJLPJAA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x4B88B40", Offset = "0x4B87D40", VA = "0x184B88B40")]
	[AsyncStateMachine(typeof(LKDFKHANNJN<>.NHEMNJCAPFC))]
	public Task<LKDFKHANNJN<T>.KNHKOJLPJAA> DEEGBENDLJM(CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x4B88DC0", Offset = "0x4B87FC0", VA = "0x184B88DC0")]
	public void EBKIHNKKLNB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class DJHCFPEIHHG
{
	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x7711700", Offset = "0x7710900", VA = "0x187711700")]
	public static LKDFKHANNJN<OJADAPCHIGK> PEFMILKIAFF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x32C8ED0", Offset = "0x32C80D0", VA = "0x1832C8ED0")]
	public static LKDFKHANNJN<T> PEFMILKIAFF<T>([In] T DMCBANBGNBP) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public sealed class FGKMBNODPOE<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public readonly struct BJLPKKCGOGA : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly FGKMBNODPOE<T> COOJMLEHKOH;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public T CADNOMLIGCM
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x4E59CB0", Offset = "0x4E58EB0", VA = "0x184E59CB0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x58C23E0", Offset = "0x58C15E0", VA = "0x1858C23E0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0xC1A5C0", Offset = "0xC197C0", VA = "0x180C1A5C0")]
		internal BJLPKKCGOGA(FGKMBNODPOE<T> AFMPLHCNALG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public readonly struct NNLHMJGDEBL : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private readonly FGKMBNODPOE<T> COOJMLEHKOH;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public T CADNOMLIGCM
		{
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x4E59CB0", Offset = "0x4E58EB0", VA = "0x184E59CB0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x4E59CD0", Offset = "0x4E58ED0", VA = "0x184E59CD0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0xC1A5C0", Offset = "0xC197C0", VA = "0x180C1A5C0")]
		internal NNLHMJGDEBL(FGKMBNODPOE<T> AFMPLHCNALG)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct NMBLIJOKPKI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public AsyncTaskMethodBuilder<NNLHMJGDEBL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public FGKMBNODPOE<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private LKDFKHANNJN<OJADAPCHIGK>.KNHKOJLPJAA <writeLock>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private TaskAwaiter<LKDFKHANNJN<OJADAPCHIGK>.KNHKOJLPJAA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x4E433D0", Offset = "0x4E425D0", VA = "0x184E433D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x45F1B90", Offset = "0x45F0D90", VA = "0x1845F1B90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly LKDFKHANNJN<int> NLFMAFBCBPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly LKDFKHANNJN<OJADAPCHIGK> GNEPGKFHCPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly LKDFKHANNJN<OJADAPCHIGK> GJNKBIFOFCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private T KMIPANFPOPH;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x44C25D0", Offset = "0x44C17D0", VA = "0x1844C25D0")]
	internal FGKMBNODPOE(LKDFKHANNJN<int> FKJDCJMIGJI, LKDFKHANNJN<OJADAPCHIGK> NMGPHOKJLFK, LKDFKHANNJN<OJADAPCHIGK> MCLJDINLECO, [In] T DMCBANBGNBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x44C2010", Offset = "0x44C1210", VA = "0x1844C2010", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x44C2410", Offset = "0x44C1610", VA = "0x1844C2410")]
	public BJLPKKCGOGA PFEJMKEAOBH()
	{
		return default(BJLPKKCGOGA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x44C18E0", Offset = "0x44C0AE0", VA = "0x1844C18E0")]
	public NNLHMJGDEBL BKDLAHCGGNN()
	{
		return default(NNLHMJGDEBL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x44C1BB0", Offset = "0x44C0DB0", VA = "0x1844C1BB0")]
	[AsyncStateMachine(typeof(FGKMBNODPOE<>.NMBLIJOKPKI))]
	public Task<FGKMBNODPOE<T>.NNLHMJGDEBL> CBEFHLEFJFK(CancellationToken KPIINMODKFJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class DEGENICHDDI
{
	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x7711630", Offset = "0x7710830", VA = "0x187711630")]
	public static FGKMBNODPOE<OJADAPCHIGK> PEFMILKIAFF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x32C7FD0", Offset = "0x32C71D0", VA = "0x1832C7FD0")]
	public static FGKMBNODPOE<T> PEFMILKIAFF<T>([In] T DMCBANBGNBP) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public sealed class GEIDKIHPJPA<TData> : ILEHMOEGHGD where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public readonly string OHPLCOFMPCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public readonly TData GGCAPNOPJKL;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50", Slot = "7")]
	public override string JBKGPNGEPEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x45F4000", Offset = "0x45F3200", VA = "0x1845F4000")]
	internal GEIDKIHPJPA(string DCEACFEGBDC, [In] TData LJELDKAOCJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class BMKOPLGBBEJ
{
	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x7711350", Offset = "0x7710550", VA = "0x187711350")]
	public static GEIDKIHPJPA<OJADAPCHIGK> PEFMILKIAFF(string DCEACFEGBDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x3209070", Offset = "0x3208270", VA = "0x183209070")]
	public static GEIDKIHPJPA<TData> PEFMILKIAFF<TData>(string DCEACFEGBDC, [In] TData LJELDKAOCJM) where TData : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public sealed class BDEAIILHJGA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	internal bool ALELHBMPMIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly string MNLGMKKMPMF;

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0xD080E0", Offset = "0xD072E0", VA = "0x180D080E0")]
	private BDEAIILHJGA(bool DBHJDOJHOBJ, string OCJGCEALEMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x77112E0", Offset = "0x77104E0", VA = "0x1877112E0")]
	public static BDEAIILHJGA PEFMILKIAFF(string OCJGCEALEMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x7711220", Offset = "0x7710420", VA = "0x187711220")]
	public NCKCPDBLNIG GNCFFOAFAFP()
	{
		return default(NCKCPDBLNIG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public readonly struct NCKCPDBLNIG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly BDEAIILHJGA FJCCFLLDMIM;

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0xC1A5C0", Offset = "0xC197C0", VA = "0x180C1A5C0")]
	internal NCKCPDBLNIG(BDEAIILHJGA IBLIOEFMDMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x7713A70", Offset = "0x7712C70", VA = "0x187713A70", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
[Obsolete("Use SimpleTokenFlag or WeakTokenFlag<T> instead")]
public sealed class NGDNHDGJEAN<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class PMPGIFGOHEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public PMPGIFGOHEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x5134E10", Offset = "0x5134010", VA = "0x185134E10")]
		internal int JNFAFFNFADI(int i, T token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private HashSet<T>? AGGJGDJPGCD;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public IReadOnlyCollection<T> DPLNMLPJHAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x4E2D7D0", Offset = "0x4E2C9D0", VA = "0x184E2D7D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool ELLNGJKGEBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x4E2D6C0", Offset = "0x4E2C8C0", VA = "0x184E2D6C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int ABNMPHLJIIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x96C090", Offset = "0x96B290", VA = "0x18096C090")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x96C060", Offset = "0x96B260", VA = "0x18096C060")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x4E2D860", Offset = "0x4E2CA60", VA = "0x184E2D860")]
	public bool OFEFHMDJLMD(T GIIKHLJPAKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x4E2DA30", Offset = "0x4E2CC30", VA = "0x184E2DA30")]
	public bool OGPGHNCGHLC(T GIIKHLJPAKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x4E2D810", Offset = "0x4E2CA10", VA = "0x184E2D810")]
	public bool JMGJGLJLLLB(T GIIKHLJPAKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x4E2D700", Offset = "0x4E2C900", VA = "0x184E2D700")]
	public void CGLMEGKMKEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x4E2DB90", Offset = "0x4E2CD90", VA = "0x184E2DB90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	public NGDNHDGJEAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public sealed class JIKBJNLDAIP
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class ABLBMLNHDFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public ABLBMLNHDFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x7710F60", Offset = "0x7710160", VA = "0x187710F60")]
		internal int JNFAFFNFADI(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private HashSet<object>? AGGJGDJPGCD;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public IReadOnlyCollection<object> DPLNMLPJHAK
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x7712850", Offset = "0x7711A50", VA = "0x187712850")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool ELLNGJKGEBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x77127D0", Offset = "0x77119D0", VA = "0x1877127D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int ABNMPHLJIIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x96C090", Offset = "0x96B290", VA = "0x18096C090")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x96C060", Offset = "0x96B260", VA = "0x18096C060")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x7712940", Offset = "0x7711B40", VA = "0x187712940")]
	public bool OFEFHMDJLMD(object GIIKHLJPAKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x7712A20", Offset = "0x7711C20", VA = "0x187712A20")]
	public bool OGPGHNCGHLC(object GIIKHLJPAKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x77128E0", Offset = "0x7711AE0", VA = "0x1877128E0")]
	public bool JMGJGLJLLLB(object GIIKHLJPAKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x77127E0", Offset = "0x77119E0", VA = "0x1877127E0")]
	public void CGLMEGKMKEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x7712AC0", Offset = "0x7711CC0", VA = "0x187712AC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	public JIKBJNLDAIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class DCGDIAMFCNJ<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private struct ODMBKBGAJLH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public float OGGHJKLPAOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public T CADNOMLIGCM;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly Dictionary<object, ODMBKBGAJLH> AJOKDFPIHEH;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public virtual T HEJEDAKJCFL
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x1769E00", Offset = "0x1769000", VA = "0x181769E00", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x17689A0", Offset = "0x1767BA0", VA = "0x1817689A0", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public object? GKDEFFFKNPC
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x964EC0", Offset = "0x9640C0", VA = "0x180964EC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x968CE0", Offset = "0x967EE0", VA = "0x180968CE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool CHIHKFCFCHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x4AA0CC0", Offset = "0x4A9FEC0", VA = "0x184AA0CC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x637AD50", Offset = "0x6379F50", VA = "0x18637AD50")]
	public bool GGOLBHOOOCA(T OMFJNFBDJCA, object GIIKHLJPAKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x4AA1610", Offset = "0x4AA0810", VA = "0x184AA1610")]
	public bool PHNPAMJAFEM(object GIIKHLJPAKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x4A523A0", Offset = "0x4A515A0", VA = "0x184A523A0")]
	public void NLADMABHKNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x637B6C0", Offset = "0x637A8C0", VA = "0x18637B6C0")]
	public bool JGIAJCMJDDJ(object GIIKHLJPAKH, [Out] T OMFJNFBDJCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x637BE70", Offset = "0x637B070", VA = "0x18637BE70")]
	[FMCICLBDIIN("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool JHGLDLOBCBA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x4DB1EE0", Offset = "0x4DB10E0", VA = "0x184DB1EE0")]
	public DCGDIAMFCNJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public sealed class DDDECGPJCPM : BPDPHDLCHFL<NIMCCIBCNBA>
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	internal class AMGLKCJLOOI : IEqualityComparer<NIMCCIBCNBA>
	{
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		internal static readonly AMGLKCJLOOI JLGHKLNHGNO;

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x7711070", Offset = "0x7710270", VA = "0x187711070", Slot = "4")]
		public bool Equals(NIMCCIBCNBA NNDJDIFFAID, NIMCCIBCNBA AMFIBFNKFFJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x696D5A0", Offset = "0x696C7A0", VA = "0x18696D5A0", Slot = "5")]
		public int GetHashCode(NIMCCIBCNBA ONELFPFEALD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public AMGLKCJLOOI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x77115C0", Offset = "0x77107C0", VA = "0x1877115C0")]
	public DDDECGPJCPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x7711460", Offset = "0x7710660", VA = "0x187711460", Slot = "4")]
	public override bool OFEFHMDJLMD(NIMCCIBCNBA GIIKHLJPAKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x7711510", Offset = "0x7710710", VA = "0x187711510", Slot = "5")]
	public override bool OGPGHNCGHLC(NIMCCIBCNBA GIIKHLJPAKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x77113D0", Offset = "0x77105D0", VA = "0x1877113D0")]
	private static void HHJEDBMKDFP(NIMCCIBCNBA GIIKHLJPAKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x1689F40", Offset = "0x1689140", VA = "0x181689F40", Slot = "6")]
	protected override string TokenToString(NIMCCIBCNBA GIIKHLJPAKH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public sealed class NIMCCIBCNBA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly string PJEFELLEAHI;

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x970550", Offset = "0x96F750", VA = "0x180970550")]
	public NIMCCIBCNBA(string PJEFELLEAHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x7713A90", Offset = "0x7712C90", VA = "0x187713A90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public abstract class BPDPHDLCHFL<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly IEqualityComparer<T> DIHIGKEAOAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private HashSet<T>? AGGJGDJPGCD;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool ELLNGJKGEBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x548D3B0", Offset = "0x548C5B0", VA = "0x18548D3B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int ABNMPHLJIIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0xAE2F30", Offset = "0xAE2130", VA = "0x180AE2F30")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0xB96CB0", Offset = "0xB95EB0", VA = "0x180B96CB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x58D8C00", Offset = "0x58D7E00", VA = "0x1858D8C00")]
	public BPDPHDLCHFL(IEqualityComparer<T> DIHIGKEAOAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x58D7F10", Offset = "0x58D7110", VA = "0x1858D7F10", Slot = "4")]
	public virtual bool OFEFHMDJLMD(T GIIKHLJPAKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x58D8400", Offset = "0x58D7600", VA = "0x1858D8400", Slot = "5")]
	public virtual bool OGPGHNCGHLC(T GIIKHLJPAKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x58D7E40", Offset = "0x58D7040", VA = "0x1858D7E40")]
	public void CGLMEGKMKEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract string TokenToString(T GIIKHLJPAKH);

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x58D8580", Offset = "0x58D7780", VA = "0x1858D8580", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public sealed class FMFGKDIPDJB<T> where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private List<WeakReference<T>>? AGGJGDJPGCD;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool ELLNGJKGEBA
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x4544990", Offset = "0x4543B90", VA = "0x184544990")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public int ABNMPHLJIIM
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x4544AF0", Offset = "0x4543CF0", VA = "0x184544AF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x4544CA0", Offset = "0x4543EA0", VA = "0x184544CA0")]
	public void OFEFHMDJLMD(T GIIKHLJPAKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x4544F10", Offset = "0x4544110", VA = "0x184544F10")]
	public void OGPGHNCGHLC(T GIIKHLJPAKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x4544AB0", Offset = "0x4543CB0", VA = "0x184544AB0")]
	public void CGLMEGKMKEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x45450B0", Offset = "0x45442B0", VA = "0x1845450B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	public FMFGKDIPDJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
internal static class PLLMGBDOIJF
{
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x35392F0", Offset = "0x35384F0", VA = "0x1835392F0")]
	public static void LLIFKGKFHNH<T>(this List<T> KBPAKCCMOCP, int KOOLKCPAFBB) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class KMLNKKEIAEB<T> where T : notnull, IEquatable<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private struct CKFGOCGEMDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public float OGGHJKLPAOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public T CADNOMLIGCM;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private readonly Dictionary<NIMCCIBCNBA, CKFGOCGEMDO> AJOKDFPIHEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private readonly EqualityComparer<T> CHLMLBNOGKF;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public virtual T HEJEDAKJCFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x964F10", Offset = "0x964110", VA = "0x180964F10", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x964F50", Offset = "0x964150", VA = "0x180964F50", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	private NIMCCIBCNBA? GKDEFFFKNPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x968CF0", Offset = "0x967EF0", VA = "0x180968CF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool CHIHKFCFCHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x4AA0CC0", Offset = "0x4A9FEC0", VA = "0x184AA0CC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x4AA0D20", Offset = "0x4A9FF20", VA = "0x184AA0D20")]
	public bool GGOLBHOOOCA(T OMFJNFBDJCA, NIMCCIBCNBA GIIKHLJPAKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x4AA1610", Offset = "0x4AA0810", VA = "0x184AA1610")]
	public bool PHNPAMJAFEM(NIMCCIBCNBA GIIKHLJPAKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x4A523A0", Offset = "0x4A515A0", VA = "0x184A523A0")]
	public void NLADMABHKNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x4AA0F40", Offset = "0x4AA0140", VA = "0x184AA0F40")]
	public bool JGIAJCMJDDJ(NIMCCIBCNBA GIIKHLJPAKH, [Out] T OMFJNFBDJCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x4AA1360", Offset = "0x4AA0560", VA = "0x184AA1360")]
	[FMCICLBDIIN("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool JHGLDLOBCBA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x4AA16A0", Offset = "0x4AA08A0", VA = "0x184AA16A0")]
	public KMLNKKEIAEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class OKPDJKOPNBG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly Dictionary<object, float> AJOKDFPIHEH;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public float AJGICDGJIME
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0xDE8360", Offset = "0xDE7560", VA = "0x180DE8360")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0xDE8350", Offset = "0xDE7550", VA = "0x180DE8350")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x7714620", Offset = "0x7713820", VA = "0x187714620")]
	public void GGOLBHOOOCA(float OMFJNFBDJCA, object GIIKHLJPAKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x77146E0", Offset = "0x77138E0", VA = "0x1877146E0")]
	public void PHNPAMJAFEM(object GIIKHLJPAKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x7714690", Offset = "0x7713890", VA = "0x187714690")]
	public void NLADMABHKNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x77144F0", Offset = "0x77136F0", VA = "0x1877144F0")]
	private void AOFALMGEAAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x7714750", Offset = "0x7713950", VA = "0x187714750")]
	public OKPDJKOPNBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public interface FMLIAHBLCPL
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event CKOAIHNFKKN IPPLKGHMBDI;
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class OKGFHNJKKJH : FMLIAHBLCPL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public readonly struct IDCNNKCNJPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public readonly float CHDCILGNCOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public readonly float LEJEEGJNHCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		internal readonly bool IEIFJCLJNMH;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public float HNAECDILAKE
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x7711DE0", Offset = "0x7710FE0", VA = "0x187711DE0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x7711F60", Offset = "0x7711160", VA = "0x187711F60")]
		public IDCNNKCNJPD(float MGKDKECOLOJ, float ANMKOMFFHBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x7711DF0", Offset = "0x7710FF0", VA = "0x187711DF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class HLKIIMEGCGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public OKGFHNJKKJH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public HLKIIMEGCGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x7711D40", Offset = "0x7710F40", VA = "0x187711D40")]
		internal void FANMAKPECIH(float innerProgress)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly int ECPBKIMJCKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private int KMLPPFHEGNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly FMLIAHBLCPL[] LJCJEGEECKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly CKOAIHNFKKN[] EKJOCLHFECK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly IDCNNKCNJPD[] EDCGKHBDGDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private IDCNNKCNJPD NNHIKCIGDKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly MLLBPDODABK KKNDKKNKJNL;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event CKOAIHNFKKN IPPLKGHMBDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x77142A0", Offset = "0x77134A0", VA = "0x1877142A0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x77141E0", Offset = "0x77133E0", VA = "0x1877141E0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x7714360", Offset = "0x7713560", VA = "0x187714360")]
	public OKGFHNJKKJH(int ECPBKIMJCKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x7714150", Offset = "0x7713350", VA = "0x187714150")]
	public MLLBPDODABK GPPABMNGEGJ(IDCNNKCNJPD GFOLFGHIKIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x7713BC0", Offset = "0x7712DC0", VA = "0x187713BC0")]
	public void AEFNBKALMIC(FMLIAHBLCPL NFDOPCCPKGL, [Optional] IDCNNKCNJPD DDGKPFGGKLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x7714040", Offset = "0x7713240", VA = "0x187714040", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public delegate void CKOAIHNFKKN(float DNNMNKNHFJD);
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class EJABKCPELBM
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private class AMPONFCLKEB : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private readonly FMLIAHBLCPL JNJGPPJNPON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private readonly CKOAIHNFKKN GIIPLELNBKP;

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x7711150", Offset = "0x7710350", VA = "0x187711150")]
		public AMPONFCLKEB(FMLIAHBLCPL JNJGPPJNPON, CKOAIHNFKKN GIIPLELNBKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x7711100", Offset = "0x7710300", VA = "0x187711100", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x7711CD0", Offset = "0x7710ED0", VA = "0x187711CD0")]
	internal static bool EHDKIJIIBCF(float IHGFIECIOLJ, float FHOBAJOBBGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x76FF4C0", Offset = "0x76FE6C0", VA = "0x1876FF4C0")]
	internal static float DJBHEAOABHC(float IHGFIECIOLJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x7711C10", Offset = "0x7710E10", VA = "0x187711C10")]
	public static IDisposable AEAPIPFGDHJ(this FMLIAHBLCPL JNJGPPJNPON, CKOAIHNFKKN GIIPLELNBKP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class MLLBPDODABK : FMLIAHBLCPL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private float DNNMNKNHFJD;

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public float AIIPIENFPDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x7713840", Offset = "0x7712A40", VA = "0x187713840")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event CKOAIHNFKKN? IPPLKGHMBDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x77139D0", Offset = "0x7712BD0", VA = "0x1877139D0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x7713930", Offset = "0x7712B30", VA = "0x187713930", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	public MLLBPDODABK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public interface GNPKMDCNIIC<T> where T : class, new()
{
	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DDKLHAOKPLC<T> KFHNOPODNCM([Out] T OMFJNFBDJCA);

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NLADMABHKNO();
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class LJMNKKHDPKA<T> : GNPKMDCNIIC<T> where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly ConcurrentStack<T> COBPLEOHDGA;

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x4B86F20", Offset = "0x4B86120", VA = "0x184B86F20", Slot = "4")]
	public DDKLHAOKPLC<T> KFHNOPODNCM([Out] T OMFJNFBDJCA)
	{
		return default(DDKLHAOKPLC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x4B86EA0", Offset = "0x4B860A0", VA = "0x184B86EA0")]
	public void FANKGHIJBAH(T IHADIFECEAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x4852F80", Offset = "0x4852180", VA = "0x184852F80", Slot = "5")]
	public void NLADMABHKNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "6")]
	protected virtual void BFLOGIDLJFF(T OHMGFJDGOKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x4B86FC0", Offset = "0x4B861C0", VA = "0x184B86FC0")]
	private T NKAAMPBENGI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x4B87060", Offset = "0x4B86260", VA = "0x184B87060")]
	public LJMNKKHDPKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public readonly struct DDKLHAOKPLC<T> : IDisposable where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly T IHADIFECEAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly LJMNKKHDPKA<T> OAOKGDDADJC;

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x9E2EE0", Offset = "0x9E20E0", VA = "0x1809E2EE0")]
	internal DDKLHAOKPLC(T OMFJNFBDJCA, LJMNKKHDPKA<T> OAOKGDDADJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x6382B60", Offset = "0x6381D60", VA = "0x186382B60", Slot = "4")]
	void IDisposable.Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class AAHDNJEMEJM : LJMNKKHDPKA<StringBuilder>
{
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public static readonly AAHDNJEMEJM JLGHKLNHGNO;

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x7710DF0", Offset = "0x770FFF0", VA = "0x187710DF0")]
	public static DDKLHAOKPLC<StringBuilder> NKAAMPBENGI([Out] StringBuilder OMFJNFBDJCA)
	{
		return default(DDKLHAOKPLC<StringBuilder>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x7710DD0", Offset = "0x770FFD0", VA = "0x187710DD0", Slot = "6")]
	protected override void BFLOGIDLJFF(StringBuilder OHMGFJDGOKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x7710F20", Offset = "0x7710120", VA = "0x187710F20")]
	public AAHDNJEMEJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class AALNEMFJAOO : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x70817D0", Offset = "0x70809D0", VA = "0x1870817D0")]
	public AALNEMFJAOO(string DCEACFEGBDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[DefaultMember("Item")]
public class OEDGNECDMGA<TKey, TValue> : ENGDGHPLFPD<TKey, TValue>, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, LPIJNGCHPJL where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class HKIOILABOPL : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private KeyValuePair<TKey, TValue> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public OEDGNECDMGA<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private IEnumerator<KeyValuePair<TKey, TValue>> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		KeyValuePair<TKey, TValue> IEnumerator<KeyValuePair<TKey, TValue>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x1769E00", Offset = "0x1769000", VA = "0x181769E00", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TValue>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x45927E0", Offset = "0x45919E0", VA = "0x1845927E0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x963B40", Offset = "0x962D40", VA = "0x180963B40")]
		[DebuggerHidden]
		public HKIOILABOPL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x4592940", Offset = "0x4591B40", VA = "0x184592940", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x46B45C0", Offset = "0x46B37C0", VA = "0x1846B45C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x46B4DA0", Offset = "0x46B3FA0", VA = "0x1846B4DA0")]
		private void PIKGOAEJJIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x46B4120", Offset = "0x46B3320", VA = "0x1846B4120")]
		private void HEIMKCGCNNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x46B4EE0", Offset = "0x46B40E0", VA = "0x1846B4EE0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly ENGDGHPLFPD<TKey, TValue> AEHHAGHOPJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly IDictionary<TKey, TValue> PFGKHJLNCHC;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int ABNMPHLJIIM
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x4FC2730", Offset = "0x4FC1930", VA = "0x184FC2730", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool KNKMFKKGHON
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x9ACBB0", Offset = "0x9ABDB0", VA = "0x1809ACBB0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public TValue EPCJHJAGLJO
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x4FC28D0", Offset = "0x4FC1AD0", VA = "0x184FC28D0", Slot = "4")]
		get
		{
			return (TValue)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x4FC2B80", Offset = "0x4FC1D80", VA = "0x184FC2B80", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public ICollection<TKey> PFMMGLFCDHP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x4FC2960", Offset = "0x4FC1B60", VA = "0x184FC2960", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public ICollection<TValue> EIIIMHCDFFM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x4FC2A70", Offset = "0x4FC1C70", VA = "0x184FC2A70", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x4FC25A0", Offset = "0x4FC17A0", VA = "0x184FC25A0")]
	public OEDGNECDMGA(ENGDGHPLFPD<TKey, TValue> AEHHAGHOPJH, [Optional] IDictionary<TKey, TValue>? PFGKHJLNCHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x4FC04A0", Offset = "0x4FBF6A0", VA = "0x184FC04A0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x4FC1930", Offset = "0x4FC0B30", VA = "0x184FC1930")]
	public void NJJMLPBNJEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x4FBFF10", Offset = "0x4FBF110", VA = "0x184FBFF10", Slot = "9")]
	public void Add(TKey MBDBONINAPC, TValue OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x4FBFA00", Offset = "0x4FBEC00", VA = "0x184FBFA00")]
	public void AEGOFLKDAML(TKey MBDBONINAPC, TValue OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x4FBFC60", Offset = "0x4FBEE60", VA = "0x184FBFC60")]
	public void ALCNMHDMGFJ(TKey MBDBONINAPC, TValue OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x4FC15D0", Offset = "0x4FC07D0", VA = "0x184FC15D0")]
	public void MNKBNCHFJGL(TKey MBDBONINAPC, TValue OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x4FC13A0", Offset = "0x4FC05A0", VA = "0x184FC13A0")]
	public void MCJHDIILCOB(TKey MBDBONINAPC, TValue OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x4FC1C20", Offset = "0x4FC0E20", VA = "0x184FC1C20", Slot = "14")]
	void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> LOKFKJLCEOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x4FC1E10", Offset = "0x4FC1010", VA = "0x184FC1E10", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> LOKFKJLCEOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x4FC2170", Offset = "0x4FC1370", VA = "0x184FC2170", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> LOKFKJLCEOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x4FC0530", Offset = "0x4FBF730", VA = "0x184FC0530", Slot = "8")]
	public bool ContainsKey(TKey MBDBONINAPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x4FBFE50", Offset = "0x4FBF050", VA = "0x184FBFE50")]
	public bool AOJEHABNIKB(TKey MBDBONINAPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x4FC0EE0", Offset = "0x4FC00E0", VA = "0x184FC0EE0")]
	public bool IDDBMBFLBPI(TKey MBDBONINAPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x4FC1A40", Offset = "0x4FC0C40", VA = "0x184FC1A40", Slot = "10")]
	public bool Remove(TKey MBDBONINAPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x4FC2400", Offset = "0x4FC1600", VA = "0x184FC2400", Slot = "11")]
	public bool TryGetValue(TKey MBDBONINAPC, [Out] TValue OMFJNFBDJCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x4FC08E0", Offset = "0x4FBFAE0", VA = "0x184FC08E0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TValue>[] LGLFHJLCKKH, int BOCNEABHGNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x4A27FE0", Offset = "0x4A271E0", VA = "0x184A27FE0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x4FC0E30", Offset = "0x4FC0030", VA = "0x184FC0E30", Slot = "19")]
	[IteratorStateMachine(typeof(OEDGNECDMGA<, >.HKIOILABOPL))]
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x4FC03B0", Offset = "0x4FBF5B0", VA = "0x184FC03B0", Slot = "21")]
	public bool BJFMBJGLNCE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x4FC1000", Offset = "0x4FC0200", VA = "0x184FC1000")]
	private TValue JDEDLKOIDLE(TKey MBDBONINAPC)
	{
		return (TValue)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public interface AGHOAHJNFOO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	string GJECLAOMHPH
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public interface LPIJNGCHPJL
{
	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BJFMBJGLNCE();
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public interface ENGDGHPLFPD<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, LPIJNGCHPJL
{
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
[DefaultMember("Item")]
public sealed class OFPMMIIHGKO<TKey, TVal> : ENGDGHPLFPD<TKey, TVal>, IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, LPIJNGCHPJL where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public delegate int PPMLNBHNDNO(TKey MBDBONINAPC, TVal OMFJNFBDJCA);

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public delegate void HLPEEFKIDBK(TKey MBDBONINAPC, TVal OMFJNFBDJCA, MBKBPMMFHLC HIIOCAFDBNN);

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	private class LPJAHNKFLLK
	{
		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public TKey MPHEPKMCCCO
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0xB45CB0", Offset = "0xB44EB0", VA = "0x180B45CB0")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public TVal CADNOMLIGCM
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0xAE2F30", Offset = "0xAE2130", VA = "0x180AE2F30")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0xB96CB0", Offset = "0xB95EB0", VA = "0x180B96CB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public int HNAECDILAKE
		{
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0xC156D0", Offset = "0xC148D0", VA = "0x180C156D0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0xDB4A90", Offset = "0xDB3C90", VA = "0x180DB4A90")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public DateTimeOffset CICPMGNALIN
		{
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0xE11FB0", Offset = "0xE111B0", VA = "0x180E11FB0")]
			[CompilerGenerated]
			get
			{
				return default(DateTimeOffset);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0xE11FA0", Offset = "0xE111A0", VA = "0x180E11FA0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x4B9A160", Offset = "0x4B99360", VA = "0x184B9A160")]
		public LPJAHNKFLLK(TKey MBDBONINAPC, TVal HBMPJOCKNNL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class OEDNOOHCJEE : IEnumerator<KeyValuePair<TKey, TVal>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private KeyValuePair<TKey, TVal> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public OFPMMIIHGKO<TKey, TVal> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private LinkedList<LPJAHNKFLLK>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		KeyValuePair<TKey, TVal> IEnumerator<KeyValuePair<TKey, TVal>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x1769E00", Offset = "0x1769000", VA = "0x181769E00", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TVal>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x4FC57C0", Offset = "0x4FC49C0", VA = "0x184FC57C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x963B40", Offset = "0x962D40", VA = "0x180963B40")]
		[DebuggerHidden]
		public OEDNOOHCJEE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x458D1C0", Offset = "0x458C3C0", VA = "0x18458D1C0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x4FC4F30", Offset = "0x4FC4130", VA = "0x184FC4F30", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x4FC52A0", Offset = "0x4FC44A0", VA = "0x184FC52A0")]
		private void PIKGOAEJJIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x4FC55E0", Offset = "0x4FC47E0", VA = "0x184FC55E0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public const int JKKLJJEPBPI = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly Dictionary<TKey, LinkedListNode<LPJAHNKFLLK>> CFPCPKKBHEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly LinkedList<LPJAHNKFLLK> PIKPJGADHEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly PPMLNBHNDNO? CEKAEEOPHKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly TimeSpan CODIBAHCNNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly HLPEEFKIDBK? HGBKHPMHMHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly ICFBCDCCAGF JNOOHOAFDED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private bool KMPDDMGGKKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private readonly List<TKey> KFEBOJEKJAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly List<TVal> CEBENBCDLBP;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public int AABBHHFGOKK
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x972060", Offset = "0x971260", VA = "0x180972060")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	internal int LEJPOJCFAMF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0xC1E1D0", Offset = "0xC1D3D0", VA = "0x180C1E1D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0xD2F2A0", Offset = "0xD2E4A0", VA = "0x180D2F2A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int ABNMPHLJIIM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x4FD82B0", Offset = "0x4FD74B0", VA = "0x184FD82B0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	internal int BNABJJNEABG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x4A523A0", Offset = "0x4A515A0", VA = "0x184A523A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public ICollection<TVal> EIIIMHCDFFM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x4FD8400", Offset = "0x4FD7600", VA = "0x184FD8400", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	ICollection<TKey> IDictionary<TKey, TVal>.EHFELGPAJNC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x4FD66D0", Offset = "0x4FD58D0", VA = "0x184FD66D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public bool KNKMFKKGHON
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x9ACBB0", Offset = "0x9ABDB0", VA = "0x1809ACBB0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public TVal EPCJHJAGLJO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x4FD83A0", Offset = "0x4FD75A0", VA = "0x184FD83A0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x4FD84A0", Offset = "0x4FD76A0", VA = "0x184FD84A0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x4FD3CE0", Offset = "0x4FD2EE0", VA = "0x184FD3CE0")]
	private bool KALNDHMFNNE(int ECPBKIMJCKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x4FD3830", Offset = "0x4FD2A30", VA = "0x184FD3830")]
	private void IHPMPGDJEDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x4FD6D50", Offset = "0x4FD5F50", VA = "0x184FD6D50")]
	public OFPMMIIHGKO(int ECPBKIMJCKH, [Optional] PPMLNBHNDNO? CEKAEEOPHKA, [Optional] IEqualityComparer<TKey>? EOOAJNLHDMI, [Optional] HLPEEFKIDBK? HGBKHPMHMHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x4FD7340", Offset = "0x4FD6540", VA = "0x184FD7340")]
	public OFPMMIIHGKO(TimeSpan CODIBAHCNNN, [Optional] IEqualityComparer<TKey>? EOOAJNLHDMI, [Optional] HLPEEFKIDBK? HGBKHPMHMHI, [Optional] ICFBCDCCAGF? JNOOHOAFDED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x4FD73B0", Offset = "0x4FD65B0", VA = "0x184FD73B0")]
	public OFPMMIIHGKO(int ECPBKIMJCKH, TimeSpan CODIBAHCNNN, [Optional] IEqualityComparer<TKey>? EOOAJNLHDMI, [Optional] HLPEEFKIDBK? HGBKHPMHMHI, [Optional] ICFBCDCCAGF? JNOOHOAFDED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x4FD75C0", Offset = "0x4FD67C0", VA = "0x184FD75C0")]
	public OFPMMIIHGKO(int ECPBKIMJCKH, PPMLNBHNDNO? CEKAEEOPHKA, TimeSpan CODIBAHCNNN, [Optional] IEqualityComparer<TKey>? EOOAJNLHDMI, [Optional] HLPEEFKIDBK? HGBKHPMHMHI, [Optional] ICFBCDCCAGF? JNOOHOAFDED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x4FCE6D0", Offset = "0x4FCD8D0", VA = "0x184FCE6D0", Slot = "21")]
	public bool BJFMBJGLNCE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x4FD0DE0", Offset = "0x4FCFFE0", VA = "0x184FD0DE0", Slot = "22")]
	public bool FEBLIKHKHGE(int IAGJHPFNLHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x4FD5450", Offset = "0x4FD4650", VA = "0x184FD5450")]
	private bool NHEIEADIPCF(int IAGJHPFNLHJ, MBKBPMMFHLC HIIOCAFDBNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x4FD1130", Offset = "0x4FD0330", VA = "0x184FD1130")]
	public void GFIEJLHFJLN(TKey MBDBONINAPC, TVal OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x4FCE680", Offset = "0x4FCD880", VA = "0x184FCE680", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> LOKFKJLCEOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x4FCE1F0", Offset = "0x4FCD3F0", VA = "0x184FCE1F0", Slot = "9")]
	public void Add(TKey MBDBONINAPC, TVal OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x4FCF120", Offset = "0x4FCE320", VA = "0x184FCF120", Slot = "8")]
	public bool ContainsKey(TKey MBDBONINAPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x4FD6170", Offset = "0x4FD5370", VA = "0x184FD6170", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Contains(KeyValuePair<TKey, TVal> LOKFKJLCEOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x4FD5E50", Offset = "0x4FD5050", VA = "0x184FD5E50", Slot = "10")]
	public bool Remove(TKey MBDBONINAPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x4FD6450", Offset = "0x4FD5650", VA = "0x184FD6450", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Remove(KeyValuePair<TKey, TVal> LOKFKJLCEOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x4FCEA20", Offset = "0x4FCDC20", VA = "0x184FCEA20")]
	private bool COMPPHKPLBC(TKey MBDBONINAPC, [Out] TVal OMFJNFBDJCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x4FD5A10", Offset = "0x4FD4C10", VA = "0x184FD5A10")]
	private TVal NKAAMPBENGI(TKey EEJEPADMFFI)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x4FD6750", Offset = "0x4FD5950", VA = "0x184FD6750", Slot = "11")]
	public bool TryGetValue(TKey EEJEPADMFFI, [Out] TVal OMFJNFBDJCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x4FCEF40", Offset = "0x4FCE140", VA = "0x184FCEF40", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x4FCF840", Offset = "0x4FCEA40", VA = "0x184FCF840", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] LGLFHJLCKKH, int BOCNEABHGNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x4FD4120", Offset = "0x4FD3320", VA = "0x184FD4120")]
	private void MDNPHOAOBGF(TKey MBDBONINAPC, TVal HBMPJOCKNNL, MBKBPMMFHLC HIIOCAFDBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x4FD0BB0", Offset = "0x4FCFDB0", VA = "0x184FD0BB0")]
	private bool FBNKBBNCMMC(LPJAHNKFLLK NHHCNMLDFDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x4FD22B0", Offset = "0x4FD14B0", VA = "0x184FD22B0")]
	private void HCOADCHLNAH(LinkedListNode<LPJAHNKFLLK> GJLECFDBPLG, TVal JIPFKIHJIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x4FD16F0", Offset = "0x4FD08F0", VA = "0x184FD16F0")]
	private void GGOLBHOOOCA(TKey MBDBONINAPC, TVal OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x4FD0520", Offset = "0x4FCF720", VA = "0x184FD0520")]
	private void DLHCHJNNJGB(LPJAHNKFLLK NHHCNMLDFDD, TVal JIPFKIHJIDL, int HILEKMLLNNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x4FD2150", Offset = "0x4FD1350", VA = "0x184FD2150", Slot = "19")]
	[IteratorStateMachine(typeof(OFPMMIIHGKO<, >.OEDNOOHCJEE))]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x4FD6710", Offset = "0x4FD5910", VA = "0x184FD6710", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public enum MBKBPMMFHLC : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	Evicted,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	RemovedViaRemove,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	RemovedViaClear,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	Overwritten
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class ENOEIOIFFKK<TKey> : Exception where TKey : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public readonly TKey OMONDEGDFCD;

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x411EA70", Offset = "0x411DC70", VA = "0x18411EA70")]
	public ENOEIOIFFKK(TKey DPAAEFJGDEB, Exception EBAOCMFIDOB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class AFCDFHCDDBO : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x68F78B0", Offset = "0x68F6AB0", VA = "0x1868F78B0")]
	public AFCDFHCDDBO(string DCEACFEGBDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public class PGEPNDCGIJP<TId, TResource> : IEnumerable<(TId, Task<TResource>, int)>, IEnumerable where TId : notnull where TResource : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private sealed class IOHKOOCLDBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public Func<TId, CancellationToken, Task<TResource>> factory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public PGEPNDCGIJP<TId, TResource> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public IOHKOOCLDBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x478B180", Offset = "0x478A380", VA = "0x18478B180")]
		internal Task<TResource> IKBLBEBNGLN(TId _id)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private struct BCLBDJBEMND : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public PGEPNDCGIJP<TId, TResource> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x58A06E0", Offset = "0x589F8E0", VA = "0x1858A06E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x58A1260", Offset = "0x58A0460", VA = "0x1858A1260", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private struct CIOPOIFFKAK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public Dictionary<Task<TResource>, CancellationTokenSource> cancellationTokenSources;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public CancellationTokenSource cts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x5CD6FC0", Offset = "0x5CD61C0", VA = "0x185CD6FC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x5CD7C40", Offset = "0x5CD6E40", VA = "0x185CD7C40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private readonly GFOBFEDGBJP<TId, Task<TResource>> ANFJLIFADHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private readonly Dictionary<Task<TResource>, CancellationTokenSource> BAHGOAKEGOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private readonly Func<TId, CancellationToken, Task<TResource>>? FFLIJOGEJNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly Action<TResource>? CDMJNDECNDB;

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x50C0D10", Offset = "0x50BFF10", VA = "0x1850C0D10")]
	public PGEPNDCGIJP(int NNCKPODCGGK = 0, [Optional] IEqualityComparer<TId>? BFKCDHLOKBF, [Optional] Func<TId, CancellationToken, Task<TResource>>? JKLIHDNFNHK, [Optional] Action<TResource>? ELLADMMCOAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x50BF9D0", Offset = "0x50BEBD0", VA = "0x1850BF9D0")]
	public OABDMFMONOH<Task<TResource>> EIGKOAGBCIE(TId JDNOHHGIHEO, [Optional] Func<TId, CancellationToken, Task<TResource>>? JKLIHDNFNHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x50BF8B0", Offset = "0x50BEAB0", VA = "0x1850BF8B0")]
	private void AHCOAACLOKB(Task<TResource> JJCLBODJJAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x50C0120", Offset = "0x50BF320", VA = "0x1850C0120")]
	[AsyncStateMachine(typeof(PGEPNDCGIJP<, >.BCLBDJBEMND))]
	private Task HCLGIOLLLKN(Task<TResource> JJCLBODJJAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x4E2FA00", Offset = "0x4E2EC00", VA = "0x184E2FA00")]
	public void FPLCEDCJIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x50C0610", Offset = "0x50BF810", VA = "0x1850C0610")]
	public GFOBFEDGBJP<TId, Task<TResource>>.LJBDHHIDEEG PACLDABBHPO()
	{
		return default(GFOBFEDGBJP<TId, Task<TResource>>.LJBDHHIDEEG);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x50C0B40", Offset = "0x50BFD40", VA = "0x1850C0B40", Slot = "4")]
	private IEnumerator<(TId, Task<TResource>, int)> System.Collections.Generic.IEnumerable<(TIdId,System.Threading.Tasks.Task<TResource>LoadResourceTask,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x50C0B40", Offset = "0x50BFD40", VA = "0x1850C0B40", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x50C08E0", Offset = "0x50BFAE0", VA = "0x1850C08E0")]
	[AsyncStateMachine(typeof(PGEPNDCGIJP<, >.CIOPOIFFKAK))]
	[CompilerGenerated]
	internal static Task PNOAKCCMMDO(Task<TResource> JJCLBODJJAC, CancellationTokenSource MLNGJPIHIMD, Dictionary<Task<TResource>, CancellationTokenSource> KEIIMMLEPOP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public class GFOBFEDGBJP<TKey, TValue> : IEnumerable<(TKey, TValue, int)>, IEnumerable where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	private sealed class JPIEADDALOE : IEquatable<JPIEADDALOE>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public readonly TValue CADNOMLIGCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public int LCBKECGNOMK;

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x101F1D0", Offset = "0x101E3D0", VA = "0x18101F1D0")]
		public JPIEADDALOE(TValue OMFJNFBDJCA, int NPHJNOHJBDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x49A7300", Offset = "0x49A6500", VA = "0x1849A7300", Slot = "4")]
		public bool Equals(JPIEADDALOE? LDKNLBHIGFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x49A7390", Offset = "0x49A6590", VA = "0x1849A7390", Slot = "0")]
		public override bool Equals(object? ONELFPFEALD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x49A7430", Offset = "0x49A6630", VA = "0x1849A7430", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public struct LJBDHHIDEEG : IEnumerator<(TKey, TValue, int)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private Dictionary<TKey, JPIEADDALOE>.Enumerator GFPIPIFBJMF;

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x4B82650", Offset = "0x4B81850", VA = "0x184B82650", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public (TKey Key, TValue Value, int RefCount) PEOKKFBMNKJ
		{
			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x4B82AB0", Offset = "0x4B81CB0", VA = "0x184B82AB0", Slot = "4")]
			get
			{
				return default((TKey, TValue, int));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x4B82910", Offset = "0x4B81B10", VA = "0x184B82910")]
		public LJBDHHIDEEG(GFOBFEDGBJP<TKey, TValue> AJOKDFPIHEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x4B822B0", Offset = "0x4B814B0", VA = "0x184B822B0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x4B822F0", Offset = "0x4B814F0", VA = "0x184B822F0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x4B825B0", Offset = "0x4B817B0", VA = "0x184B825B0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[CompilerGenerated]
	private sealed class NFKNACINLHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public GFOBFEDGBJP<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public TKey key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public JPIEADDALOE refCountedValue;

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public NFKNACINLHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x4E28CC0", Offset = "0x4E27EC0", VA = "0x184E28CC0")]
		internal void IKBLBEBNGLN()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private readonly Dictionary<TKey, JPIEADDALOE> JALPCODNHBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private readonly Func<TKey, TValue>? JEEPAIMIPLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly Action<TValue>? KLLDJMNECOJ;

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x4602F30", Offset = "0x4602130", VA = "0x184602F30")]
	public GFOBFEDGBJP(int NNCKPODCGGK = 0, [Optional] IEqualityComparer<TKey>? EOOAJNLHDMI, [Optional] Func<TKey, TValue>? GAKKFLHDEMO, [Optional] Action<TValue>? FKJDBHAAOFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x46019B0", Offset = "0x4600BB0", VA = "0x1846019B0")]
	public OABDMFMONOH<TValue> EIGKOAGBCIE(TKey MBDBONINAPC, [Optional] Func<TKey, TValue>? NGKLGFEODMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x46022A0", Offset = "0x46014A0", VA = "0x1846022A0")]
	private void FANKGHIJBAH(TKey MBDBONINAPC, JPIEADDALOE DFGAFNBKCCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x4602630", Offset = "0x4601830", VA = "0x184602630")]
	public void FPLCEDCJIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x4602CA0", Offset = "0x4601EA0", VA = "0x184602CA0")]
	public LJBDHHIDEEG PACLDABBHPO()
	{
		return default(LJBDHHIDEEG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x4602E90", Offset = "0x4602090", VA = "0x184602E90", Slot = "4")]
	private IEnumerator<(TKey, TValue, int)> System.Collections.Generic.IEnumerable<(TKeyKey,TValueValue,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x4602E90", Offset = "0x4602090", VA = "0x184602E90", Slot = "5")]
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
