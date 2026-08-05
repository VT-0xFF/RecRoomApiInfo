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
		[Cpp2IlInjected.Address(RVA = "0x8C5550", Offset = "0x8C4950", VA = "0x1808C5550")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E2EA40", Offset = "0x6E2DE40", VA = "0x186E2EA40")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8C5B80", Offset = "0x8C4F80", VA = "0x1808C5B80")]
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
		[Cpp2IlInjected.Address(RVA = "0x8C5BC0", Offset = "0x8C4FC0", VA = "0x1808C5BC0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class MBEKKPBFGBG
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
	protected MBEKKPBFGBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class OMPLLJLLDIN<T> : MBEKKPBFGBG
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	protected struct NGNDEGIJFEE
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public enum FLOIHDILGBN
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
		public FLOIHDILGBN EKNPHEPNHJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public T LLIKOHELCCA;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private int NPJHMNICMKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool JKKFFCHJKBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	protected readonly bool DKOGICHCFAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	protected List<T>? ACIMHGGJAEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<NGNDEGIJFEE>? FMGOEIKHMJB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool ELNHMLLDDKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4A7B9C0", Offset = "0x4A7ADC0", VA = "0x184A7B9C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4A7C210", Offset = "0x4A7B610", VA = "0x184A7C210")]
	protected OMPLLJLLDIN(bool DKOGICHCFAN, bool JKKFFCHJKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4A7C170", Offset = "0x4A7B570", VA = "0x184A7C170")]
	protected bool MKAHFFKJCNN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4A7BDE0", Offset = "0x4A7B1E0", VA = "0x184A7BDE0")]
	protected void HNKONIGJHID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4A7BF00", Offset = "0x4A7B300", VA = "0x184A7BF00")]
	protected void KJNEOOKLMAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x31E43A0", Offset = "0x31E37A0", VA = "0x1831E43A0")]
	private static void KCNFLCCEBKJ<U>(List<U>? PBBPHMMFLFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4A7BBD0", Offset = "0x4A7AFD0", VA = "0x184A7BBD0", Slot = "4")]
	public void FNBCENOGBNB(T LLIKOHELCCA, bool BEFCDKMKKFH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4A7B7F0", Offset = "0x4A7ABF0", VA = "0x184A7B7F0", Slot = "5")]
	public void BIJNEFLCHFA(T LLIKOHELCCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4A7BA20", Offset = "0x4A7AE20", VA = "0x184A7BA20")]
	public void FEPOBOIDOBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class BDDIJCFMLKF : OMPLLJLLDIN<Action>
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6E2B6C0", Offset = "0x6E2AAC0", VA = "0x186E2B6C0")]
	public BDDIJCFMLKF(bool DKOGICHCFAN = false, bool JKKFFCHJKBD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6E2B460", Offset = "0x6E2A860", VA = "0x186E2B460")]
	public void IIFNBMCHKOM()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6E2B660", Offset = "0x6E2AA60", VA = "0x186E2B660")]
	public static BDDIJCFMLKF MMCDHOJJGKB(BDDIJCFMLKF AGFKGFEMKHG, Action LLIKOHELCCA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6E2B400", Offset = "0x6E2A800", VA = "0x186E2B400")]
	public static BDDIJCFMLKF HOEFFLFKLEH(BDDIJCFMLKF AGFKGFEMKHG, Action LLIKOHELCCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface PPDBCDKGIPN<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FNBCENOGBNB(Action<T> LLIKOHELCCA, bool BEFCDKMKKFH = false);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BIJNEFLCHFA(Action<T> LLIKOHELCCA);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class EJELNBCCPAC<T> : OMPLLJLLDIN<Action<T>>, PPDBCDKGIPN<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3B9F5C0", Offset = "0x3B9E9C0", VA = "0x183B9F5C0")]
	public EJELNBCCPAC(bool DKOGICHCFAN = false, bool JKKFFCHJKBD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3B9C970", Offset = "0x3B9BD70", VA = "0x183B9C970")]
	public void IIFNBMCHKOM(T BNBMPMKBBFO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3B9F520", Offset = "0x3B9E920", VA = "0x183B9F520")]
	public static EJELNBCCPAC<T> MMCDHOJJGKB(EJELNBCCPAC<T> AGFKGFEMKHG, Action<T> LLIKOHELCCA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3B9C8D0", Offset = "0x3B9BCD0", VA = "0x183B9C8D0")]
	public static EJELNBCCPAC<T> HOEFFLFKLEH(EJELNBCCPAC<T> AGFKGFEMKHG, Action<T> LLIKOHELCCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface IMDJDDKLCOC<T, U> where T : notnull where U : notnull
{
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class PIDJNMEAPLG<T, U> : OMPLLJLLDIN<Action<T, U>>, IMDJDDKLCOC<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3B9F5C0", Offset = "0x3B9E9C0", VA = "0x183B9F5C0")]
	public PIDJNMEAPLG(bool DKOGICHCFAN = false, bool JKKFFCHJKBD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4B35260", Offset = "0x4B34660", VA = "0x184B35260")]
	public void IIFNBMCHKOM(T BNBMPMKBBFO, U PNBHFDPHEAK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3B9F520", Offset = "0x3B9E920", VA = "0x183B9F520")]
	public static PIDJNMEAPLG<T, U> MMCDHOJJGKB(PIDJNMEAPLG<T, U> AGFKGFEMKHG, Action<T, U> LLIKOHELCCA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3B9C8D0", Offset = "0x3B9BCD0", VA = "0x183B9C8D0")]
	public static PIDJNMEAPLG<T, U> HOEFFLFKLEH(PIDJNMEAPLG<T, U> AGFKGFEMKHG, Action<T, U> LLIKOHELCCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class LBBKBHGAHAN<T, U, V> : OMPLLJLLDIN<Action<T, U, V>> where T : notnull where U : notnull where V : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3B9F5C0", Offset = "0x3B9E9C0", VA = "0x183B9F5C0")]
	public LBBKBHGAHAN(bool DKOGICHCFAN = false, bool JKKFFCHJKBD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x45DCAA0", Offset = "0x45DBEA0", VA = "0x1845DCAA0")]
	public void IIFNBMCHKOM(T BNBMPMKBBFO, U PNBHFDPHEAK, V FCBPGONDPJI)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3B9F520", Offset = "0x3B9E920", VA = "0x183B9F520")]
	public static LBBKBHGAHAN<T, U, V> MMCDHOJJGKB(LBBKBHGAHAN<T, U, V> AGFKGFEMKHG, Action<T, U, V> LLIKOHELCCA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3B9C8D0", Offset = "0x3B9BCD0", VA = "0x183B9C8D0")]
	public static LBBKBHGAHAN<T, U, V> HOEFFLFKLEH(LBBKBHGAHAN<T, U, V> AGFKGFEMKHG, Action<T, U, V> LLIKOHELCCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface NHPGHDPHFPN<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public sealed class AFPKEPMMIFD<T, U, V, W> : OMPLLJLLDIN<Action<T, U, V, W>>, NHPGHDPHFPN<T, U, V, W> where T : notnull where U : notnull where V : notnull where W : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3B9F5C0", Offset = "0x3B9E9C0", VA = "0x183B9F5C0")]
	public AFPKEPMMIFD(bool DKOGICHCFAN = false, bool JKKFFCHJKBD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3FDE780", Offset = "0x3FDDB80", VA = "0x183FDE780")]
	public void IIFNBMCHKOM(T BNBMPMKBBFO, U PNBHFDPHEAK, V FCBPGONDPJI, W MAHNIEPOPIG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3B9F520", Offset = "0x3B9E920", VA = "0x183B9F520")]
	public static AFPKEPMMIFD<T, U, V, W> MMCDHOJJGKB(AFPKEPMMIFD<T, U, V, W> AGFKGFEMKHG, Action<T, U, V, W> LLIKOHELCCA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3B9C8D0", Offset = "0x3B9BCD0", VA = "0x183B9C8D0")]
	public static AFPKEPMMIFD<T, U, V, W> HOEFFLFKLEH(AFPKEPMMIFD<T, U, V, W> AGFKGFEMKHG, Action<T, U, V, W> LLIKOHELCCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class PKCGJLCDPGB<T, U, V, W, X> : OMPLLJLLDIN<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3B9F5C0", Offset = "0x3B9E9C0", VA = "0x183B9F5C0")]
	public PKCGJLCDPGB(bool DKOGICHCFAN = false, bool JKKFFCHJKBD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4B40630", Offset = "0x4B3FA30", VA = "0x184B40630")]
	public void IIFNBMCHKOM(T BNBMPMKBBFO, U PNBHFDPHEAK, V FCBPGONDPJI, W MAHNIEPOPIG, X KPPEBBOFEKD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3B9F520", Offset = "0x3B9E920", VA = "0x183B9F520")]
	public static PKCGJLCDPGB<T, U, V, W, X> MMCDHOJJGKB(PKCGJLCDPGB<T, U, V, W, X> AGFKGFEMKHG, Action<T, U, V, W, X> LLIKOHELCCA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3B9C8D0", Offset = "0x3B9BCD0", VA = "0x183B9C8D0")]
	public static PKCGJLCDPGB<T, U, V, W, X> HOEFFLFKLEH(PKCGJLCDPGB<T, U, V, W, X> AGFKGFEMKHG, Action<T, U, V, W, X> LLIKOHELCCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class JIOODPBIKHG<T, U, V, W, X, Y> : OMPLLJLLDIN<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3B9F5C0", Offset = "0x3B9E9C0", VA = "0x183B9F5C0")]
	public JIOODPBIKHG(bool DKOGICHCFAN = false, bool JKKFFCHJKBD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x442DAE0", Offset = "0x442CEE0", VA = "0x18442DAE0")]
	public void IIFNBMCHKOM(T BNBMPMKBBFO, U PNBHFDPHEAK, V FCBPGONDPJI, W MAHNIEPOPIG, X KPPEBBOFEKD, Y EJAKPDCBGAD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3B9F520", Offset = "0x3B9E920", VA = "0x183B9F520")]
	public static JIOODPBIKHG<T, U, V, W, X, Y> MMCDHOJJGKB(JIOODPBIKHG<T, U, V, W, X, Y> AGFKGFEMKHG, Action<T, U, V, W, X, Y> LLIKOHELCCA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3B9C8D0", Offset = "0x3B9BCD0", VA = "0x183B9C8D0")]
	public static JIOODPBIKHG<T, U, V, W, X, Y> HOEFFLFKLEH(JIOODPBIKHG<T, U, V, W, X, Y> AGFKGFEMKHG, Action<T, U, V, W, X, Y> LLIKOHELCCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class NGAFPMBOLDN<TKey, TVal> where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly LHJNOOGBBAM<TKey, TVal> ABHNGMILGLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly Dictionary<TKey, (TVal value, int size)> IJBBNHLCGAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly LHJNOOGBBAM<TKey, TVal>.CMCBADJBHAE? IJAMMGLKIOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly int FLJONELGLOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly LHJNOOGBBAM<TKey, TVal>.OFFHEDGNNKA? DFAAGEHFIGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private int OFIGIKCGJMF;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal int LHIKDEAGEEF
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x4947050", Offset = "0x4946450", VA = "0x184947050")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int BAJAMKMOMOK
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8A6040", Offset = "0x8A5440", VA = "0x1808A6040")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4947D50", Offset = "0x4947150", VA = "0x184947D50")]
	public NGAFPMBOLDN(int FLJONELGLOG, [Optional] LHJNOOGBBAM<TKey, TVal>.OFFHEDGNNKA? DFAAGEHFIGD, [Optional] IEqualityComparer<TKey>? PKNNFPMPJGE, [Optional] LHJNOOGBBAM<TKey, TVal>.CMCBADJBHAE? IJAMMGLKIOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4946BC0", Offset = "0x4945FC0", VA = "0x184946BC0")]
	public void CKFKPBBKNCH(TKey PBFBBOFLBNL, TVal PFKKDHPJFEH, bool GNGPMDKMDOP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4946A60", Offset = "0x4945E60", VA = "0x184946A60")]
	public bool BAHGONFMEEA(TKey PBFBBOFLBNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x4947860", Offset = "0x4946C60", VA = "0x184947860")]
	public bool NKKJANMEMGN(TKey BLBBJJCCKGD, [Out] TVal PFKKDHPJFEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4947A90", Offset = "0x4946E90", VA = "0x184947A90")]
	private void OOGEEIFEHJN(TKey PBFBBOFLBNL, TVal PFKKDHPJFEH, int JKIIGJDNBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x4946EA0", Offset = "0x49462A0", VA = "0x184946EA0")]
	public bool IOPPHNAIKIE(TKey PBFBBOFLBNL, TVal PFKKDHPJFEH, bool GNGPMDKMDOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4946DF0", Offset = "0x49461F0", VA = "0x184946DF0")]
	public void FEPOBOIDOBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4947300", Offset = "0x4946700", VA = "0x184947300")]
	private void MMEIOBNIIOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x49470A0", Offset = "0x49464A0", VA = "0x1849470A0")]
	private bool KDFBFGOBIOJ(TKey PBFBBOFLBNL, IIFNECCGAIB BNIDPJNMOLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x49471E0", Offset = "0x49465E0", VA = "0x1849471E0")]
	private void MGNMCMHLLCA(TKey PBFBBOFLBNL, TVal PFKKDHPJFEH, IIFNECCGAIB BNIDPJNMOLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4947960", Offset = "0x4946D60", VA = "0x184947960")]
	private void OIIHGEGLHCF(TKey PBFBBOFLBNL, TVal KCIHDEINMKL, IIFNECCGAIB BNIDPJNMOLO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class NIBELLPJLJN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly Action FCOCKNNGONO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool ONLLBMEGDLD;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x89A2A0", Offset = "0x8996A0", VA = "0x18089A2A0")]
	public NIBELLPJLJN(Action EIGMGLNDPGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6E2E9A0", Offset = "0x6E2DDA0", VA = "0x186E2E9A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2CDE720", Offset = "0x2CDDB20", VA = "0x182CDE720")]
	public static GHHMJPGPOGF<T> ANJEPJLHJHG<T>(T PFKKDHPJFEH, Action EIGMGLNDPGO) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class GHHMJPGPOGF<T> : NIBELLPJLJN where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public T FDJCHKNOIDG
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x89EF40", Offset = "0x89E340", VA = "0x18089EF40")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x40474E0", Offset = "0x40468E0", VA = "0x1840474E0")]
	public GHHMJPGPOGF(T PFKKDHPJFEH, Action EIGMGLNDPGO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class FECEBLCMAPK<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly FPGJBNJJCJK<T>? FKDKJLJDLNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly ReadOnlySequence<T> OBGDACOGEBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private bool ONLLBMEGDLD;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly FECEBLCMAPK<T> HABKGKOFNKB;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ReadOnlySequence<T> LDFJBECOAHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3F27090", Offset = "0x3F26490", VA = "0x183F27090")]
		get
		{
			return default(ReadOnlySequence<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long OCLEKHGCIDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3F26EC0", Offset = "0x3F262C0", VA = "0x183F26EC0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool FKFNLLHBIGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x3F272F0", Offset = "0x3F266F0", VA = "0x183F272F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3F27660", Offset = "0x3F26A60", VA = "0x183F27660")]
	public FECEBLCMAPK(FPGJBNJJCJK<T> MLNNMIIODFD, FPGJBNJJCJK<T> AAFJIACJCIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3F27BB0", Offset = "0x3F26FB0", VA = "0x183F27BB0")]
	public FECEBLCMAPK(FPGJBNJJCJK<T> MLNNMIIODFD, int PNGCLOMDHAJ, FPGJBNJJCJK<T> AAFJIACJCIF, int FEMNGPHAOJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3F27750", Offset = "0x3F26B50", VA = "0x183F27750")]
	private FECEBLCMAPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3F26F80", Offset = "0x3F26380", VA = "0x183F26F80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3F27460", Offset = "0x3F26860", VA = "0x183F27460")]
	public T[] PHBKKJCGHEL()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3F27110", Offset = "0x3F26510", VA = "0x183F27110")]
	public static ReadOnlySequence<T> NMFIIIJGOAJ(FECEBLCMAPK<T>? ABPICDIBEMO)
	{
		return default(ReadOnlySequence<T>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct HLACFEIODAE : IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct JBDGAJNDAFK : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8E46A0", Offset = "0x8E3AA0", VA = "0x1808E46A0")]
		public static JBDGAJNDAFK GIIIFAJNKEL()
		{
			return default(JBDGAJNDAFK);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6E2C260", Offset = "0x6E2B660", VA = "0x186E2C260")]
	public static string OMBAMHBLDBM(Type EKNPHEPNHJD, [Optional] string? HMLHCELAHLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2ECC790", Offset = "0x2ECBB90", VA = "0x182ECC790")]
	public static string? OMBAMHBLDBM<T>([Optional] string? HMLHCELAHLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x2ECC810", Offset = "0x2ECBC10", VA = "0x182ECC810")]
	public static string? OOECDDDCEGL<T>([Optional] string? LEJOAJLMEEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8E46A0", Offset = "0x8E3AA0", VA = "0x1808E46A0")]
	public static HLACFEIODAE ADLLDKLMDCF(string HMLHCELAHLL, string? LEJOAJLMEEE)
	{
		return default(HLACFEIODAE);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct LEGPHPNPHAK
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate bool GFHLEOGCNDA(string IKAAFIENGIH, LEGPHPNPHAK DJOKBPBNIBD);

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class HIHCKAGFKBL<T> where T : notnull, Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public List<int> enumValuesSubset;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public HIHCKAGFKBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x4156AD0", Offset = "0x4155ED0", VA = "0x184156AD0")]
		internal void BILGICMMBEE(T x)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public int LFKMIMEIEKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public string IMPFIMBAAHH;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6E2DAF0", Offset = "0x6E2CEF0", VA = "0x186E2DAF0")]
	public static Dictionary<string, LEGPHPNPHAK> HGKKLJKGFIB(Type CGMPPMEOEOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2F89870", Offset = "0x2F88C70", VA = "0x182F89870")]
	public static Dictionary<string, LEGPHPNPHAK> HGKKLJKGFIB<T>(Type CGMPPMEOEOF, IReadOnlyDictionary<T, string> DJNAFGEBADC) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2F8A0B0", Offset = "0x2F894B0", VA = "0x182F8A0B0")]
	public static Dictionary<string, LEGPHPNPHAK> IAKPONBNMEL<T>(List<T> OEHLMCJPGNA) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6E2DE20", Offset = "0x6E2D220", VA = "0x186E2DE20")]
	public static Dictionary<string, LEGPHPNPHAK> JNKCJBDMILB(Type CGMPPMEOEOF, GFHLEOGCNDA MHJKIACDCDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6E2D930", Offset = "0x6E2CD30", VA = "0x186E2D930")]
	public static Dictionary<int, string> BOIMENPPDCC(Dictionary<string, LEGPHPNPHAK> LHOBDGJGOHD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class MBCBLBGJNJI : JPIHCAEEFCD
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static bool GPENLPHAFPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly string? AKLONNNCPAA;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public virtual JPIHCAEEFCD? BLEABIALBOK
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x89BD40", Offset = "0x89B140", VA = "0x18089BD40", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6E2E930", Offset = "0x6E2DD30", VA = "0x186E2E930")]
	protected MBCBLBGJNJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string ECJFEDANMLC();

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6E2E320", Offset = "0x6E2D720", VA = "0x186E2E320", Slot = "8")]
	public virtual string LHPIPPNPOBP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6E2E680", Offset = "0x6E2DA80", VA = "0x186E2E680", Slot = "9")]
	public void PIMPBHKIKLP(StringBuilder LHHEFGHPMBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6E2E500", Offset = "0x6E2D900", VA = "0x186E2E500", Slot = "10")]
	public void OCKLAHJKBGI(StringBuilder LHHEFGHPMBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6E2E560", Offset = "0x6E2D960", VA = "0x186E2E560", Slot = "11")]
	public void PBNHBMOKLCK(StringBuilder LHHEFGHPMBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6E2E3A0", Offset = "0x6E2D7A0", VA = "0x186E2E3A0", Slot = "12")]
	public void MLBHBPJAIFP(StringBuilder LHHEFGHPMBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6E2E280", Offset = "0x6E2D680", VA = "0x186E2E280")]
	public static void EDKLHFPCPBF(StringBuilder LHHEFGHPMBF, string MCEDFPCPMCI, string MAPEJGJKAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5FB6DF0", Offset = "0x5FB61F0", VA = "0x185FB6DF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class OOIHMPBGOBL : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6E2EC50", Offset = "0x6E2E050", VA = "0x186E2EC50")]
	public OOIHMPBGOBL(string NFKMLKNHFEM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class FOPGHEPNLAL<TErr> : OOIHMPBGOBL where TErr : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly TErr MNHPPMHGHLE;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x3F57A70", Offset = "0x3F56E70", VA = "0x183F57A70")]
	private FOPGHEPNLAL([In] TErr FFDCOPIKEOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x3F579A0", Offset = "0x3F56DA0", VA = "0x183F579A0")]
	public static FOPGHEPNLAL<TErr> GIIIFAJNKEL([In] TErr FFDCOPIKEOO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class KOLMLPFEPAP : Stream
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly HashAlgorithm IOEABFHAHKB;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public override bool MAGMJPJFKKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8E46A0", Offset = "0x8E3AA0", VA = "0x1808E46A0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public override bool GHKPBLOBOJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8E46A0", Offset = "0x8E3AA0", VA = "0x1808E46A0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public override bool BBKJCKDBFMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8B6510", Offset = "0x8B5910", VA = "0x1808B6510", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override long OCLEKHGCIDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6E2D7D0", Offset = "0x6E2CBD0", VA = "0x186E2D7D0", Slot = "12")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override long NOBECIHIBBE
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6E2D840", Offset = "0x6E2CC40", VA = "0x186E2D840", Slot = "13")]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6E2D8B0", Offset = "0x6E2CCB0", VA = "0x186E2D8B0", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6E2D760", Offset = "0x6E2CB60", VA = "0x186E2D760")]
	public KOLMLPFEPAP(HashAlgorithm IOEABFHAHKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6E2D580", Offset = "0x6E2C980", VA = "0x186E2D580", Slot = "35")]
	public override int Read(byte[] GMKBBDEHIHO, int HHOJFKLGPBP, int GMOPHNCDIJO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6E2D730", Offset = "0x6E2CB30", VA = "0x186E2D730", Slot = "38")]
	public override void Write(byte[] GMKBBDEHIHO, int HHOJFKLGPBP, int GMOPHNCDIJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6E2D620", Offset = "0x6E2CA20", VA = "0x186E2D620", Slot = "33")]
	public override long Seek(long HHOJFKLGPBP, SeekOrigin IPEFBOEAIHM)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6E2D6B0", Offset = "0x6E2CAB0", VA = "0x186E2D6B0", Slot = "34")]
	public override void SetLength(long PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "23")]
	public override void Flush()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6E2D4A0", Offset = "0x6E2C8A0", VA = "0x186E2D4A0")]
	public byte[] OHPIFIEEJCB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface JPIHCAEEFCD
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string LHPIPPNPOBP();

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string ECJFEDANMLC();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface MJGBEPJIPCF<out TOptions> where TOptions : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	TOptions FDJCHKNOIDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface AAAHGIFMNFA
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	string EGNBLFJDHPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class FPGJBNJJCJK<T> : ReadOnlySequenceSegment<T>, IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private static FPGJBNJJCJK<T>? EDIOCECGPGO;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private static object IONFKMNIJNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private IMemoryOwner<T>? LCLPCGLGIFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private bool ONLLBMEGDLD;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool DCPGEINIIPA
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x979FA0", Offset = "0x9793A0", VA = "0x180979FA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x3F58460", Offset = "0x3F57860", VA = "0x183F58460")]
	private static FPGJBNJJCJK<T> ALGNOGNJPPJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x3F59820", Offset = "0x3F58C20", VA = "0x183F59820")]
	private static void JLCMMGFMPJK(FPGJBNJJCJK<T> LIHCCJHEDIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x3F5A1D0", Offset = "0x3F595D0", VA = "0x183F5A1D0")]
	private FPGJBNJJCJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x3F58920", Offset = "0x3F57D20", VA = "0x183F58920")]
	public static FPGJBNJJCJK<T> ANJEPJLHJHG(ReadOnlyMemory<T> BHOJCBPHKOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x3F58AF0", Offset = "0x3F57EF0", VA = "0x183F58AF0")]
	public static FPGJBNJJCJK<T> ANJEPJLHJHG(IMemoryOwner<T> EEAOPJBBMAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x3F594E0", Offset = "0x3F588E0", VA = "0x183F594E0")]
	public static void EMILAGKOLNL(FPGJBNJJCJK<T> MLNNMIIODFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x3F58ED0", Offset = "0x3F582D0", VA = "0x183F58ED0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x3F593D0", Offset = "0x3F587D0", VA = "0x183F593D0")]
	public FPGJBNJJCJK<T> EJPACLHODAH(IMemoryOwner<T> EEAOPJBBMAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x3F59620", Offset = "0x3F58A20", VA = "0x183F59620")]
	private void JBEIACMDCHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x3F59DE0", Offset = "0x3F591E0", VA = "0x183F59DE0")]
	private FPGJBNJJCJK<T> KAGBNJMLOHB(FPGJBNJJCJK<T> LIHCCJHEDIA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class NKDNFHJBCCJ : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6E2E9E0", Offset = "0x6E2DDE0", VA = "0x186E2E9E0")]
	public NKDNFHJBCCJ(string NFKMLKNHFEM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class MHEFIACPPKK<TOk> : NKDNFHJBCCJ where TOk : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly TOk LIMOOHMDFMD;

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x48CBB70", Offset = "0x48CAF70", VA = "0x1848CBB70")]
	private MHEFIACPPKK([In] TOk BMCINJFLHEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3F3C620", Offset = "0x3F3BA20", VA = "0x183F3C620")]
	public static MHEFIACPPKK<TOk> GIIIFAJNKEL([In] TOk BMCINJFLHEP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public readonly struct BMFECDODLAB<TOk, TErr> : IEquatable<BMFECDODLAB<TOk, TErr>> where TOk : notnull where TErr : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static readonly EqualityComparer<TErr> COKCDDPFHNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	internal readonly TErr MNHPPMHGHLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	internal readonly TOk LIMOOHMDFMD;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool CILEODAPMCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x525FA10", Offset = "0x525EE10", VA = "0x18525FA10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool OBBJIOADEFB
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x525EB30", Offset = "0x525DF30", VA = "0x18525EB30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5262BD0", Offset = "0x5261FD0", VA = "0x185262BD0")]
	internal BMFECDODLAB([In] TErr FFDCOPIKEOO, [In] TOk BMCINJFLHEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x525AB90", Offset = "0x5259F90", VA = "0x18525AB90")]
	public static BMFECDODLAB<TOk, TErr> BHBPNLCMHDO([In] TErr FFDCOPIKEOO)
	{
		return default(BMFECDODLAB<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x525F1E0", Offset = "0x525E5E0", VA = "0x18525F1E0")]
	public static BMFECDODLAB<TOk, TErr> NNLBFDOPIHO([In] TOk BMCINJFLHEP)
	{
		return default(BMFECDODLAB<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2D3E010", Offset = "0x2D3D410", VA = "0x182D3E010")]
	public BMFECDODLAB<TOk?, UErr?> GDIMMPIBPLJ<UErr>()
	{
		return default(BMFECDODLAB<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x2D3F700", Offset = "0x2D3EB00", VA = "0x182D3F700")]
	public BMFECDODLAB<UOk?, TErr?> JLKCNNFKGED<UOk>()
	{
		return default(BMFECDODLAB<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2D3E5E0", Offset = "0x2D3D9E0", VA = "0x182D3E5E0")]
	public BMFECDODLAB<UOk?, TErr?> ILBEEDPHNNA<UOk>()
	{
		return default(BMFECDODLAB<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x2D3FEE0", Offset = "0x2D3F2E0", VA = "0x182D3FEE0")]
	public BMFECDODLAB<TOk?, UErr?> MBEMEACBDPD<UErr>()
	{
		return default(BMFECDODLAB<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x525E740", Offset = "0x525DB40", VA = "0x18525E740")]
	public BMFECDODLAB<FHMPKELNMGN, TErr> MFCOFHODPEB()
	{
		return default(BMFECDODLAB<FHMPKELNMGN, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x525D690", Offset = "0x525CA90", VA = "0x18525D690")]
	public static bool LIIBJCIOAJF([In] BMFECDODLAB<TOk, TErr> CGCHNDGEIJH, [In] BMFECDODLAB<TOk, TErr> LEGMFFDGEGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x525B2C0", Offset = "0x525A6C0", VA = "0x18525B2C0", Slot = "4")]
	public bool Equals(BMFECDODLAB<TOk, TErr> OGKFFDCECEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x525B910", Offset = "0x525AD10", VA = "0x18525B910", Slot = "0")]
	public override bool Equals(object OGKFFDCECEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x525C3A0", Offset = "0x525B7A0", VA = "0x18525C3A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x5260B20", Offset = "0x525FF20", VA = "0x185260B20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class GFFFHBMHKDA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct GNAJEKIFLLC<TOk, TErr> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public AsyncTaskMethodBuilder<TOk> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public Task<BMFECDODLAB<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private TaskAwaiter<BMFECDODLAB<TOk, TErr>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x407ABD0", Offset = "0x4079FD0", VA = "0x18407ABD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x407B530", Offset = "0x407A930", VA = "0x18407B530", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2EAFBB0", Offset = "0x2EAEFB0", VA = "0x182EAFBB0")]
	public static BMFECDODLAB<TOk?, TErr?> LIMOOHMDFMD<TOk, TErr>([In] this BMFECDODLAB<TOk, TErr> EAFEIEDNLNL, [In] TOk BMCINJFLHEP)
	{
		return default(BMFECDODLAB<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2EAFC60", Offset = "0x2EAF060", VA = "0x182EAFC60")]
	public static BMFECDODLAB<FHMPKELNMGN, TErr?> LIMOOHMDFMD<TErr>([In] this BMFECDODLAB<FHMPKELNMGN, TErr> EAFEIEDNLNL)
	{
		return default(BMFECDODLAB<FHMPKELNMGN, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2EAFBB0", Offset = "0x2EAEFB0", VA = "0x182EAFBB0")]
	public static BMFECDODLAB<TOk?, TErr?> MNHPPMHGHLE<TOk, TErr>([In] this BMFECDODLAB<TOk, TErr> EAFEIEDNLNL, [In] TErr FFDCOPIKEOO)
	{
		return default(BMFECDODLAB<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2EAF1F0", Offset = "0x2EAE5F0", VA = "0x182EAF1F0")]
	public static TOk? FFKKMLJOHFM<TOk, TErr>([In] this BMFECDODLAB<TOk, TErr> EAFEIEDNLNL)
	{
		return (TOk?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x2EAF7A0", Offset = "0x2EAEBA0", VA = "0x182EAF7A0")]
	[AsyncStateMachine(typeof(GNAJEKIFLLC<, >))]
	public static Task<TOk?>? GLLCNOEDPJM<TOk, TErr>(this Task<BMFECDODLAB<TOk, TErr>> EAFEIEDNLNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x2EB0030", Offset = "0x2EAF430", VA = "0x182EB0030")]
	public static TErr? OKGMGCJIHPI<TErr, TOk>([In] this BMFECDODLAB<TOk, TErr> EAFEIEDNLNL)
	{
		return (TErr?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x2EAE010", Offset = "0x2EAD410", VA = "0x182EAE010")]
	public static bool EIKOIPKPOLG<TOk, TErr, UErr, UOk>([In] this BMFECDODLAB<TOk, TErr> EAFEIEDNLNL, [Out] BMFECDODLAB<UOk, UErr> MNFCCGFCOAP) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x2EACE50", Offset = "0x2EAC250", VA = "0x182EACE50")]
	public static bool ADCLALHPCPA<TOk, TErr>([In] this BMFECDODLAB<TOk, TErr> EAFEIEDNLNL, [Out][NotNullWhen(true)] TOk BMCINJFLHEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x2EAFAD0", Offset = "0x2EAEED0", VA = "0x182EAFAD0")]
	public static bool IOMNKAEMNEB<TOk, TErr>([In] this BMFECDODLAB<TOk, TErr> EAFEIEDNLNL, [Out][NotNullWhen(true)] TErr FFDCOPIKEOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x2EADF90", Offset = "0x2EAD390", VA = "0x182EADF90")]
	public static bool DIMEEJBDAHJ<TOk, TErr>([In] this BMFECDODLAB<TOk, TErr> EAFEIEDNLNL, [Out][NotNullWhen(true)] TOk BMCINJFLHEP, [Out][NotNullWhen(false)] TErr FFDCOPIKEOO) where TOk : notnull where TErr : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x2EB0240", Offset = "0x2EAF640", VA = "0x182EB0240")]
	public static bool PBAHDDLLCHB<TOk, TErr>([In] this BMFECDODLAB<TOk, TErr> EAFEIEDNLNL, [Out][NotNullWhen(true)] TOk BMCINJFLHEP, [Out] BMFECDODLAB<TOk, TErr> MNFCCGFCOAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x2EAE270", Offset = "0x2EAD670", VA = "0x182EAE270")]
	public static bool EIKOIPKPOLG<TOk, TErr, UErr, UOk>([In] this BMFECDODLAB<TOk, TErr> EAFEIEDNLNL, [Out][NotNullWhen(true)] TOk BMCINJFLHEP, [Out] BMFECDODLAB<UOk, UErr> MNFCCGFCOAP) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x2EADA40", Offset = "0x2EACE40", VA = "0x182EADA40")]
	public static bool CIBOLBOLBKL<TOk, TErr>([In] this BMFECDODLAB<TOk, TErr> EAFEIEDNLNL, [Out][NotNullWhen(true)] TOk BMCINJFLHEP, [Out] BMFECDODLAB<FHMPKELNMGN, TErr> MNFCCGFCOAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x2EAD600", Offset = "0x2EACA00", VA = "0x182EAD600")]
	public static BMFECDODLAB<UOk, UErr> BHIMNKOBPFP<UOk, UErr, TOk, TErr>([In] this BMFECDODLAB<TOk, TErr> EAFEIEDNLNL, [In] BMFECDODLAB<UOk, UErr> KGHCPOJBNFM) where TOk : UOk where TErr : UErr
	{
		return default(BMFECDODLAB<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x2EACF40", Offset = "0x2EAC340", VA = "0x182EACF40")]
	public static BMFECDODLAB<TOk?[]?, TErr?> BEEDANNOHAC<TOk, TErr>(this IEnumerable<BMFECDODLAB<TOk, TErr>> EAFEIEDNLNL)
	{
		return default(BMFECDODLAB<TOk[], TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class GJKKGEJKJNM<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x2DD35F0", Offset = "0x2DD29F0", VA = "0x182DD35F0")]
	public static BMFECDODLAB<TOk, T> LIMOOHMDFMD<TOk>([In] TOk BMCINJFLHEP) where TOk : notnull
	{
		return default(BMFECDODLAB<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x4054470", Offset = "0x4053870", VA = "0x184054470")]
	public static BMFECDODLAB<FHMPKELNMGN, T> LIMOOHMDFMD()
	{
		return default(BMFECDODLAB<FHMPKELNMGN, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x2DD35F0", Offset = "0x2DD29F0", VA = "0x182DD35F0")]
	public static BMFECDODLAB<T, TErr> MNHPPMHGHLE<TErr>([In] TErr FFDCOPIKEOO) where TErr : notnull
	{
		return default(BMFECDODLAB<T, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public readonly struct KOMGOMCDNGK<TKey, TValue> where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly IAADNCGJDIJ MMCDEPJKHAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly Dictionary<TKey, TValue> EMPHBAIPABE;

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x453FFB0", Offset = "0x453F3B0", VA = "0x18453FFB0")]
	public static KOMGOMCDNGK<TKey, TValue> GIIIFAJNKEL(string EPLPPJHJIIM)
	{
		return default(KOMGOMCDNGK<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x4540170", Offset = "0x453F570", VA = "0x184540170")]
	internal KOMGOMCDNGK(Dictionary<TKey, TValue> PFKKDHPJFEH, IAADNCGJDIJ NDIGLCBCMDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x45400D0", Offset = "0x453F4D0", VA = "0x1845400D0")]
	public KLAOOJHBKKG<TKey, TValue> LCKFBAFPCJC([Out] Dictionary<TKey, TValue> PFKKDHPJFEH)
	{
		return default(KLAOOJHBKKG<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public readonly struct KLAOOJHBKKG<TKey, TValue> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly Dictionary<TKey, TValue> EMPHBAIPABE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly GFGOHKFEDDC NFIJEFLJGCA;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x2428790", Offset = "0x2427B90", VA = "0x182428790")]
	internal KLAOOJHBKKG(Dictionary<TKey, TValue> PFKKDHPJFEH, GFGOHKFEDDC BKIDCLGHJEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x3F5A7D0", Offset = "0x3F59BD0", VA = "0x183F5A7D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public readonly struct LKIFCKNIHHD<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly IAADNCGJDIJ MMCDEPJKHAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly HashSet<T> EMPHBAIPABE;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x453FFB0", Offset = "0x453F3B0", VA = "0x18453FFB0")]
	public static LKIFCKNIHHD<T> GIIIFAJNKEL(string EPLPPJHJIIM)
	{
		return default(LKIFCKNIHHD<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x4540170", Offset = "0x453F570", VA = "0x184540170")]
	internal LKIFCKNIHHD(HashSet<T> PFKKDHPJFEH, IAADNCGJDIJ NDIGLCBCMDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x45400D0", Offset = "0x453F4D0", VA = "0x1845400D0")]
	public PMKIOGDIFGL<T> LCKFBAFPCJC([Out] HashSet<T> PFKKDHPJFEH)
	{
		return default(PMKIOGDIFGL<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public readonly struct PMKIOGDIFGL<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly HashSet<T> EMPHBAIPABE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly GFGOHKFEDDC NFIJEFLJGCA;

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x2428790", Offset = "0x2427B90", VA = "0x182428790")]
	internal PMKIOGDIFGL(HashSet<T> PFKKDHPJFEH, GFGOHKFEDDC BKIDCLGHJEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x3F5A7D0", Offset = "0x3F59BD0", VA = "0x183F5A7D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct MAIMMDFFIOG<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly IAADNCGJDIJ MMCDEPJKHAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly Stack<T> EMPHBAIPABE;

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x453FFB0", Offset = "0x453F3B0", VA = "0x18453FFB0")]
	public static MAIMMDFFIOG<T> GIIIFAJNKEL(string EPLPPJHJIIM)
	{
		return default(MAIMMDFFIOG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x4540170", Offset = "0x453F570", VA = "0x184540170")]
	internal MAIMMDFFIOG(Stack<T> PFKKDHPJFEH, IAADNCGJDIJ NDIGLCBCMDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x45400D0", Offset = "0x453F4D0", VA = "0x1845400D0")]
	public FPNKOEIADFJ<T> LCKFBAFPCJC([Out] Stack<T> PFKKDHPJFEH)
	{
		return default(FPNKOEIADFJ<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct FPNKOEIADFJ<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly Stack<T> EMPHBAIPABE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly GFGOHKFEDDC NFIJEFLJGCA;

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x2428790", Offset = "0x2427B90", VA = "0x182428790")]
	internal FPNKOEIADFJ(Stack<T> PFKKDHPJFEH, GFGOHKFEDDC BKIDCLGHJEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x3F5A7D0", Offset = "0x3F59BD0", VA = "0x183F5A7D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[DefaultMember("Item")]
public sealed class DAIFAGENGHN<T> : IEnumerable<T>, IEnumerable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private readonly struct JBKBPJNEPGL : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly DAIFAGENGHN<T> KNIELIDNDEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly int HBJMFDCJBNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly bool DEOCIFMDAAI;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x2161D10", Offset = "0x2161110", VA = "0x182161D10")]
		public JBKBPJNEPGL(DAIFAGENGHN<T> KPECMEHKPOJ, int AAHGLNDOENH, bool CLDDOGFAOJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x43D1770", Offset = "0x43D0B70", VA = "0x1843D1770")]
		public DAIFAGENGHN<T>.MCKDFOIPPGO EDIPCEILGGF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x43D1860", Offset = "0x43D0C60", VA = "0x1843D1860", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x43D1860", Offset = "0x43D0C60", VA = "0x1843D1860", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public sealed class MCKDFOIPPGO : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly DAIFAGENGHN<T> KNIELIDNDEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly int BNHJOGHFLMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private int GPHFPNHIPEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly bool DEOCIFMDAAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private bool KKFIHKOMKKJ;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public T LDHKDFDFMKJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x4852540", Offset = "0x4851940", VA = "0x184852540")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x48526B0", Offset = "0x4851AB0", VA = "0x1848526B0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x4852720", Offset = "0x4851B20", VA = "0x184852720", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x4852AC0", Offset = "0x4851EC0", VA = "0x184852AC0")]
		public MCKDFOIPPGO(DAIFAGENGHN<T> KPECMEHKPOJ, int AAHGLNDOENH, bool CLDDOGFAOJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x48525C0", Offset = "0x48519C0", VA = "0x1848525C0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x4852650", Offset = "0x4851A50", VA = "0x184852650", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class IMECICLGCHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public IMECICLGCHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x4219ED0", Offset = "0x42192D0", VA = "0x184219ED0")]
		internal T LJGJHBLLKLC(int _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly T[] DGBPFNGIGGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int GPHFPNHIPEO;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int FKKHGCCOPIP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x5BDB120", Offset = "0x5BDA520", VA = "0x185BDB120")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public T LDHKDFDFMKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x3F13700", Offset = "0x3F12B00", VA = "0x183F13700")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public T LDACBOJGIHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x5BDAFF0", Offset = "0x5BDA3F0", VA = "0x185BDAFF0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public T LGNCPMFFKIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x5BDB2D0", Offset = "0x5BDA6D0", VA = "0x185BDB2D0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int OCLEKHGCIDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x1DCD700", Offset = "0x1DCCB00", VA = "0x181DCD700")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x14C9100", Offset = "0x14C8500", VA = "0x1814C9100")]
	private static int PAFGPLDJMFD(int OBFJPFHENMC, int LGPCCHEOHGO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x5BDB3E0", Offset = "0x5BDA7E0", VA = "0x185BDB3E0")]
	public DAIFAGENGHN(int JKIIGJDNBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x5BDB460", Offset = "0x5BDA860", VA = "0x185BDB460")]
	public DAIFAGENGHN(int JKIIGJDNBMO, Func<T> FKMCNDODDOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x5BDB340", Offset = "0x5BDA740", VA = "0x185BDB340")]
	public DAIFAGENGHN(T[] AKAPKCMHDAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x5BDB0F0", Offset = "0x5BDA4F0", VA = "0x185BDB0F0")]
	public void MIMOGAIEBFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x5BDB030", Offset = "0x5BDA430", VA = "0x185BDB030")]
	public IEnumerable<T> IAOCMPFHGFM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5BDAF50", Offset = "0x5BDA350", VA = "0x185BDAF50")]
	public DAIFAGENGHN<T>.MCKDFOIPPGO EDIPCEILGGF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x3F9D490", Offset = "0x3F9C890", VA = "0x183F9D490", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x3F9D490", Offset = "0x3F9C890", VA = "0x183F9D490", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class POBKFBKMIOK
{
	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x30A6B20", Offset = "0x30A5F20", VA = "0x1830A6B20")]
	public static DAIFAGENGHN<T> GIIIFAJNKEL<T>(int JKIIGJDNBMO, Func<T> FKMCNDODDOP) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public sealed class OBGBEMJONCE<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public readonly struct GNBKGKAMFMB : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly OBGBEMJONCE<T> ANOLFOMNONC;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public T FDJCHKNOIDG
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x407B5F0", Offset = "0x407A9F0", VA = "0x18407B5F0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x407B5C0", Offset = "0x407A9C0", VA = "0x18407B5C0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x948260", Offset = "0x947660", VA = "0x180948260")]
		public GNBKGKAMFMB(OBGBEMJONCE<T> ANOLFOMNONC)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct HDJEDIKKKEF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public AsyncTaskMethodBuilder<GNBKGKAMFMB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public OBGBEMJONCE<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x412B490", Offset = "0x412A890", VA = "0x18412B490", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x3BA6E10", Offset = "0x3BA6210", VA = "0x183BA6E10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly SemaphoreSlim BCGPGDJNEOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private T NPHDACFOFLD;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x4A45220", Offset = "0x4A44620", VA = "0x184A45220")]
	public OBGBEMJONCE([In] T NPHDACFOFLD, int OOGEHLNJNJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x4A45360", Offset = "0x4A44760", VA = "0x184A45360")]
	public OBGBEMJONCE([In] T NPHDACFOFLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x4A44D40", Offset = "0x4A44140", VA = "0x184A44D40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x4A44D00", Offset = "0x4A44100", VA = "0x184A44D00")]
	public GNBKGKAMFMB CHJPMFHOBML()
	{
		return default(GNBKGKAMFMB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x4A44FE0", Offset = "0x4A443E0", VA = "0x184A44FE0")]
	[AsyncStateMachine(typeof(OBGBEMJONCE<>.HDJEDIKKKEF))]
	public Task<OBGBEMJONCE<T>.GNBKGKAMFMB> NPMBCMEPGGF(CancellationToken GBOOEEMCFEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x4A44D80", Offset = "0x4A44180", VA = "0x184A44D80")]
	public void EGKMMDMMBBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class ILOKHMPHJMJ
{
	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6E2CDC0", Offset = "0x6E2C1C0", VA = "0x186E2CDC0")]
	public static OBGBEMJONCE<FHMPKELNMGN> GIIIFAJNKEL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x2C470C0", Offset = "0x2C464C0", VA = "0x182C470C0")]
	public static OBGBEMJONCE<T> GIIIFAJNKEL<T>([In] T NPHDACFOFLD) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class AOGHCGACHFD<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public readonly struct LHIPPIJDOLC : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private readonly AOGHCGACHFD<T> CNIDAKPLGBF;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public T FDJCHKNOIDG
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x406BA50", Offset = "0x406AE50", VA = "0x18406BA50")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x4607F60", Offset = "0x4607360", VA = "0x184607F60", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x948260", Offset = "0x947660", VA = "0x180948260")]
		internal LHIPPIJDOLC(AOGHCGACHFD<T> ANOLFOMNONC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public readonly struct GLHOIJMKNMH : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private readonly AOGHCGACHFD<T> CNIDAKPLGBF;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public T FDJCHKNOIDG
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x406BA50", Offset = "0x406AE50", VA = "0x18406BA50")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x406B9B0", Offset = "0x406ADB0", VA = "0x18406B9B0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x948260", Offset = "0x947660", VA = "0x180948260")]
		internal GLHOIJMKNMH(AOGHCGACHFD<T> ANOLFOMNONC)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct COBHHEPKEIJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public AsyncTaskMethodBuilder<GLHOIJMKNMH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public AOGHCGACHFD<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private OBGBEMJONCE<FHMPKELNMGN>.GNBKGKAMFMB <writeLock>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private TaskAwaiter<OBGBEMJONCE<FHMPKELNMGN>.GNBKGKAMFMB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x57262D0", Offset = "0x57256D0", VA = "0x1857262D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x3BA6E10", Offset = "0x3BA6210", VA = "0x183BA6E10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly OBGBEMJONCE<int> JJHONOCKAFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly OBGBEMJONCE<FHMPKELNMGN> GDMANLHGKOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly OBGBEMJONCE<FHMPKELNMGN> IFOPAJLNHHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private T DJFAKDNIJMI;

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x41081E0", Offset = "0x41075E0", VA = "0x1841081E0")]
	internal AOGHCGACHFD(OBGBEMJONCE<int> BDLHFNPGPAC, OBGBEMJONCE<FHMPKELNMGN> EAOHGMDKCBI, OBGBEMJONCE<FHMPKELNMGN> FPCHHNCLPEM, [In] T NPHDACFOFLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x4107940", Offset = "0x4106D40", VA = "0x184107940", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x4107C00", Offset = "0x4107000", VA = "0x184107C00")]
	public LHIPPIJDOLC ININPHDECDH()
	{
		return default(LHIPPIJDOLC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x4107EB0", Offset = "0x41072B0", VA = "0x184107EB0")]
	public GLHOIJMKNMH JPEPEKDGNLK()
	{
		return default(GLHOIJMKNMH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x4107FA0", Offset = "0x41073A0", VA = "0x184107FA0")]
	[AsyncStateMachine(typeof(AOGHCGACHFD<>.COBHHEPKEIJ))]
	public Task<AOGHCGACHFD<T>.GLHOIJMKNMH> LEPIAGNMNJH(CancellationToken GBOOEEMCFEA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class HLKDHEJHANK
{
	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x6E2C2A0", Offset = "0x6E2B6A0", VA = "0x186E2C2A0")]
	public static AOGHCGACHFD<FHMPKELNMGN> GIIIFAJNKEL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x2ECCC80", Offset = "0x2ECC080", VA = "0x182ECCC80")]
	public static AOGHCGACHFD<T> GIIIFAJNKEL<T>([In] T NPHDACFOFLD) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public sealed class FHKCOEHLEBP<TData> : MBCBLBGJNJI where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly string GMJKGFMAAHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly TData EELMKJIGLGI;

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50", Slot = "7")]
	public override string ECJFEDANMLC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x3F3D7A0", Offset = "0x3F3CBA0", VA = "0x183F3D7A0")]
	internal FHKCOEHLEBP(string NFKMLKNHFEM, [In] TData EIFGKHNPLEK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class GJKLKMOPJKJ
{
	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x6E2C1E0", Offset = "0x6E2B5E0", VA = "0x186E2C1E0")]
	public static FHKCOEHLEBP<FHMPKELNMGN> GIIIFAJNKEL(string NFKMLKNHFEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x2CDE720", Offset = "0x2CDDB20", VA = "0x182CDE720")]
	public static FHKCOEHLEBP<TData> GIIIFAJNKEL<TData>(string NFKMLKNHFEM, [In] TData EIFGKHNPLEK) where TData : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public sealed class IAADNCGJDIJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	internal bool ALDIDAAJNLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly string AHJGANBOHKG;

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x9B8CC0", Offset = "0x9B80C0", VA = "0x1809B8CC0")]
	private IAADNCGJDIJ(bool BNJLMDNPIFG, string HLFPLAMDIAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x6E2C370", Offset = "0x6E2B770", VA = "0x186E2C370")]
	public static IAADNCGJDIJ GIIIFAJNKEL(string HLFPLAMDIAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x6E2C3E0", Offset = "0x6E2B7E0", VA = "0x186E2C3E0")]
	public GFGOHKFEDDC LCKFBAFPCJC()
	{
		return default(GFGOHKFEDDC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public readonly struct GFGOHKFEDDC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly IAADNCGJDIJ OMOHKBAPKFB;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x948260", Offset = "0x947660", VA = "0x180948260")]
	internal GFGOHKFEDDC(IAADNCGJDIJ EPLPPJHJIIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x6E2BF60", Offset = "0x6E2B360", VA = "0x186E2BF60", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[Obsolete("Use SimpleTokenFlag or WeakTokenFlag<T> instead")]
public sealed class CJKNKKAGDAH<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class LFKJAIOFFKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public LFKJAIOFFKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x45ED080", Offset = "0x45EC480", VA = "0x1845ED080")]
		internal int DNBOCCNPNBG(int i, T token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private HashSet<T>? EJIBMEGEPOA;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public IReadOnlyCollection<T> JCPKKOFEOHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x563FDF0", Offset = "0x563F1F0", VA = "0x18563FDF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool KNEJOCHKFGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x563FBE0", Offset = "0x563EFE0", VA = "0x18563FBE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int AHBPDFJLDEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x89FC40", Offset = "0x89F040", VA = "0x18089FC40")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x8A7060", Offset = "0x8A6460", VA = "0x1808A7060")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x563FC30", Offset = "0x563F030", VA = "0x18563FC30")]
	public bool FNBCENOGBNB(T CFGHNHCDKCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x563F990", Offset = "0x563ED90", VA = "0x18563F990")]
	public bool BIJNEFLCHFA(T CFGHNHCDKCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x563F940", Offset = "0x563ED40", VA = "0x18563F940")]
	public bool APJCMBOKLHP(T CFGHNHCDKCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x563FB00", Offset = "0x563EF00", VA = "0x18563FB00")]
	public void EFFDCOFNOID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x563FE30", Offset = "0x563F230", VA = "0x18563FE30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
	public CJKNKKAGDAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public sealed class JLCPCMNKJOG
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class OMJLDDMGAFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public OMJLDDMGAFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6E2EBA0", Offset = "0x6E2DFA0", VA = "0x186E2EBA0")]
		internal int DNBOCCNPNBG(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private HashSet<object>? EJIBMEGEPOA;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public IReadOnlyCollection<object> JCPKKOFEOHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x6E2D090", Offset = "0x6E2C490", VA = "0x186E2D090")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool KNEJOCHKFGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x6E2CFA0", Offset = "0x6E2C3A0", VA = "0x186E2CFA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int AHBPDFJLDEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x89FC40", Offset = "0x89F040", VA = "0x18089FC40")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x8A7060", Offset = "0x8A6460", VA = "0x1808A7060")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6E2CFB0", Offset = "0x6E2C3B0", VA = "0x186E2CFB0")]
	public bool FNBCENOGBNB(object CFGHNHCDKCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6E2CE90", Offset = "0x6E2C290", VA = "0x186E2CE90")]
	public bool BIJNEFLCHFA(object CFGHNHCDKCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6E2CE30", Offset = "0x6E2C230", VA = "0x186E2CE30")]
	public bool APJCMBOKLHP(object CFGHNHCDKCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6E2CF30", Offset = "0x6E2C330", VA = "0x186E2CF30")]
	public void EFFDCOFNOID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x6E2D120", Offset = "0x6E2C520", VA = "0x186E2D120", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
	public JLCPCMNKJOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class GFFOCKKOHAN<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private struct LCADKKMNPIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public float LCDJCJPGOEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public T FDJCHKNOIDG;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly Dictionary<object, LCADKKMNPIK> GCAOPEJPLMF;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public virtual T ALPLJPEMJAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x13BBD40", Offset = "0x13BB140", VA = "0x1813BBD40", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x13BB320", Offset = "0x13BA720", VA = "0x1813BB320", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public object? NCLBPHAOJNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x89EF20", Offset = "0x89E320", VA = "0x18089EF20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x89EF30", Offset = "0x89E330", VA = "0x18089EF30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool CBFBNPMJLOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x4043160", Offset = "0x4042560", VA = "0x184043160")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x40438A0", Offset = "0x4042CA0", VA = "0x1840438A0")]
	public bool LCGHAFHBGIB(T PFKKDHPJFEH, object CFGHNHCDKCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x3B65760", Offset = "0x3B64B60", VA = "0x183B65760")]
	public bool CCHOEKLGFAB(object CFGHNHCDKCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x4043110", Offset = "0x4042510", VA = "0x184043110")]
	public void FEPOBOIDOBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x4043D60", Offset = "0x4043160", VA = "0x184043D60")]
	public bool NKKJANMEMGN(object CFGHNHCDKCN, [Out] T PFKKDHPJFEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x4041C90", Offset = "0x4041090", VA = "0x184041C90")]
	[ICFJKDIIEFO("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool ABBAMLCMCJM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x3B65DE0", Offset = "0x3B651E0", VA = "0x183B65DE0")]
	public GFFOCKKOHAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public sealed class GHJGBJHIFGI : OODEFJAJAJJ<DBMONBFGKOC>
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	internal class KENJNIMIMDI : IEqualityComparer<DBMONBFGKOC>
	{
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		internal static readonly KENJNIMIMDI GHDNHBBFDEB;

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x6E2D2D0", Offset = "0x6E2C6D0", VA = "0x186E2D2D0", Slot = "4")]
		public bool Equals(DBMONBFGKOC KPPEBBOFEKD, DBMONBFGKOC EJAKPDCBGAD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x61A04D0", Offset = "0x619F8D0", VA = "0x1861A04D0", Slot = "5")]
		public int GetHashCode(DBMONBFGKOC FAKGLFFOLFI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public KENJNIMIMDI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6E2C170", Offset = "0x6E2B570", VA = "0x186E2C170")]
	public GHJGBJHIFGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6E2C030", Offset = "0x6E2B430", VA = "0x186E2C030", Slot = "4")]
	public override bool FNBCENOGBNB(DBMONBFGKOC CFGHNHCDKCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6E2BF80", Offset = "0x6E2B380", VA = "0x186E2BF80", Slot = "5")]
	public override bool BIJNEFLCHFA(DBMONBFGKOC CFGHNHCDKCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6E2C0E0", Offset = "0x6E2B4E0", VA = "0x186E2C0E0")]
	private static void NGCCHAPNJNI(DBMONBFGKOC CFGHNHCDKCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x1298160", Offset = "0x1297560", VA = "0x181298160", Slot = "6")]
	protected override string GMAJCBPAPDC(DBMONBFGKOC CFGHNHCDKCN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public sealed class DBMONBFGKOC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly string KJKIJBJKMIJ;

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x89A2A0", Offset = "0x8996A0", VA = "0x18089A2A0")]
	public DBMONBFGKOC(string KJKIJBJKMIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6E2B9F0", Offset = "0x6E2ADF0", VA = "0x186E2B9F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public abstract class OODEFJAJAJJ<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly IEqualityComparer<T> LFBKIIFECDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private HashSet<T>? EJIBMEGEPOA;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool KNEJOCHKFGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x4A81D10", Offset = "0x4A81110", VA = "0x184A81D10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public int AHBPDFJLDEL
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x9741A0", Offset = "0x9735A0", VA = "0x1809741A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0xAA25F0", Offset = "0xAA19F0", VA = "0x180AA25F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x4A82210", Offset = "0x4A81610", VA = "0x184A82210")]
	internal OODEFJAJAJJ(IEqualityComparer<T> LFBKIIFECDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x4A81D50", Offset = "0x4A81150", VA = "0x184A81D50", Slot = "4")]
	public virtual bool FNBCENOGBNB(T CFGHNHCDKCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x4A81BA0", Offset = "0x4A80FA0", VA = "0x184A81BA0", Slot = "5")]
	public virtual bool BIJNEFLCHFA(T CFGHNHCDKCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract string GMAJCBPAPDC(T CFGHNHCDKCN);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x4A81F20", Offset = "0x4A81320", VA = "0x184A81F20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public sealed class ACCGNHMPBMK<T> where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private List<WeakReference<T>>? EJIBMEGEPOA;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool KNEJOCHKFGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x3FBB640", Offset = "0x3FBAA40", VA = "0x183FBB640")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int AHBPDFJLDEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x3FBB460", Offset = "0x3FBA860", VA = "0x183FBB460")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x3FBB760", Offset = "0x3FBAB60", VA = "0x183FBB760")]
	public void FNBCENOGBNB(T CFGHNHCDKCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x3FBB2C0", Offset = "0x3FBA6C0", VA = "0x183FBB2C0")]
	public void BIJNEFLCHFA(T CFGHNHCDKCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x3FBB600", Offset = "0x3FBAA00", VA = "0x183FBB600")]
	public void EFFDCOFNOID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x3FBB9D0", Offset = "0x3FBADD0", VA = "0x183FBB9D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
	public ACCGNHMPBMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal static class DFCJBDGDFGB
{
	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x2CE2140", Offset = "0x2CE1540", VA = "0x182CE2140")]
	public static void LKOJIMEHPFD<T>(this List<T> PBBPHMMFLFN, int OBFJPFHENMC) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class EKBIJGBAKNC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly Dictionary<object, float> GCAOPEJPLMF;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public float GHLLPEJBINI
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0xA89110", Offset = "0xA88510", VA = "0x180A89110")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0xA890E0", Offset = "0xA884E0", VA = "0x180A890E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x6E2BC30", Offset = "0x6E2B030", VA = "0x186E2BC30")]
	public void LCGHAFHBGIB(float PFKKDHPJFEH, object CFGHNHCDKCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x6E2BA40", Offset = "0x6E2AE40", VA = "0x186E2BA40")]
	public void CCHOEKLGFAB(object CFGHNHCDKCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x6E2BAB0", Offset = "0x6E2AEB0", VA = "0x186E2BAB0")]
	public void FEPOBOIDOBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x6E2BB00", Offset = "0x6E2AF00", VA = "0x186E2BB00")]
	private void GMBDAPMLCDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x6E2BCA0", Offset = "0x6E2B0A0", VA = "0x186E2BCA0")]
	public EKBIJGBAKNC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public interface KIMBALENLJP
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event JMELBOCOELE CLDEOJKPJOK;
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class IBNJLAKAACG : KIMBALENLJP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public readonly struct CCKPDIKJFIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public readonly float HEDCOPEMPIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public readonly float KOJLHCDBCGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		internal readonly bool KIGAEJLFEFK;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public float INPFMBGIDBE
		{
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x6E2B720", Offset = "0x6E2AB20", VA = "0x186E2B720")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x6E2B890", Offset = "0x6E2AC90", VA = "0x186E2B890")]
		public CCKPDIKJFIG(float ICLFANODKJK, float CCKNHLLGPCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x6E2B730", Offset = "0x6E2AB30", VA = "0x186E2B730", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class LJEHMKJEJIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public IBNJLAKAACG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public LJEHMKJEJIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x6E2E1E0", Offset = "0x6E2D5E0", VA = "0x186E2E1E0")]
		internal void BNJDGDHDFON(float innerProgress)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly int PCJIPONCEAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private int GIHIADNOFEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly KIMBALENLJP[] AEOGMKGEDIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly JMELBOCOELE[] OJNJHJENDCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly CCKPDIKJFIG[] KDJNMHEPEML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private CCKPDIKJFIG KBCEHIFCNNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly GAFMALEPEJB DBMOKOBNEKB;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event JMELBOCOELE CLDEOJKPJOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x6E2CAB0", Offset = "0x6E2BEB0", VA = "0x186E2CAB0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x6E2CB70", Offset = "0x6E2BF70", VA = "0x186E2CB70", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x6E2CC30", Offset = "0x6E2C030", VA = "0x186E2CC30")]
	public IBNJLAKAACG(int PCJIPONCEAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x6E2C5B0", Offset = "0x6E2B9B0", VA = "0x186E2C5B0")]
	public GAFMALEPEJB EABHCCDBAPN(CCKPDIKJFIG GOLOFNEFPEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x6E2C640", Offset = "0x6E2BA40", VA = "0x186E2C640")]
	public void FEGDEGFANNA(KIMBALENLJP JHANDKNJMJC, [Optional] CCKPDIKJFIG OMCLPCMNFLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x6E2C4A0", Offset = "0x6E2B8A0", VA = "0x186E2C4A0", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public delegate void JMELBOCOELE(float DFDOKAMAMGL);
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class KHHEBNIBIEM
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private class OHAMNFPPDEP : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private readonly KIMBALENLJP OJBNCDAMGAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private readonly JMELBOCOELE NEDFJOJDIHF;

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x6E2EB10", Offset = "0x6E2DF10", VA = "0x186E2EB10")]
		public OHAMNFPPDEP(KIMBALENLJP OJBNCDAMGAO, JMELBOCOELE NEDFJOJDIHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x6E2EAC0", Offset = "0x6E2DEC0", VA = "0x186E2EAC0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x6E2D430", Offset = "0x6E2C830", VA = "0x186E2D430")]
	internal static bool MBFGGABEMAL(float FIGPMCHHKJO, float LLNOONNFEHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6E1A0C0", Offset = "0x6E194C0", VA = "0x186E1A0C0")]
	internal static float OAPJDGLLCEB(float FIGPMCHHKJO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x6E2D370", Offset = "0x6E2C770", VA = "0x186E2D370")]
	public static IDisposable HHKMJCJMEDH(this KIMBALENLJP OJBNCDAMGAO, JMELBOCOELE NEDFJOJDIHF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class GAFMALEPEJB : KIMBALENLJP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private float DFDOKAMAMGL;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public float KMBHJLKCEED
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x6E2BE70", Offset = "0x6E2B270", VA = "0x186E2BE70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event JMELBOCOELE? CLDEOJKPJOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x6E2BD30", Offset = "0x6E2B130", VA = "0x186E2BD30", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x6E2BDD0", Offset = "0x6E2B1D0", VA = "0x186E2BDD0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
	public GAFMALEPEJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public interface NFJAJDIJCKK<T> where T : class, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EHNBKNPJGON<T> PBBCGENJODN([Out] T PFKKDHPJFEH);

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FEPOBOIDOBF();
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class GIGGCDNAAIF<T> : NFJAJDIJCKK<T> where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly ConcurrentStack<T> HHHGCEOOPJB;

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x4050510", Offset = "0x404F910", VA = "0x184050510", Slot = "4")]
	public EHNBKNPJGON<T> PBBCGENJODN([Out] T PFKKDHPJFEH)
	{
		return default(EHNBKNPJGON<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x40503F0", Offset = "0x404F7F0", VA = "0x1840503F0")]
	public void AFNCKMDLBLN(T KCODMICAADF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x3BB43C0", Offset = "0x3BB37C0", VA = "0x183BB43C0", Slot = "5")]
	public void FEPOBOIDOBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "6")]
	protected virtual void JHHBHLLALID(T OLPKAADIPCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x4050470", Offset = "0x404F870", VA = "0x184050470")]
	private T GEKLBPFDDHO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x40505B0", Offset = "0x404F9B0", VA = "0x1840505B0")]
	public GIGGCDNAAIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public readonly struct EHNBKNPJGON<T> : IDisposable where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly T KCODMICAADF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly GIGGCDNAAIF<T> MMFPHFFLLDI;

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0xDEC7B0", Offset = "0xDEBBB0", VA = "0x180DEC7B0")]
	internal EHNBKNPJGON(T PFKKDHPJFEH, GIGGCDNAAIF<T> MMFPHFFLLDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x3B98790", Offset = "0x3B97B90", VA = "0x183B98790", Slot = "4")]
	void IDisposable.Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class ALIMHPNCEOD : GIGGCDNAAIF<StringBuilder>
{
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public static readonly ALIMHPNCEOD GHDNHBBFDEB;

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6E2B260", Offset = "0x6E2A660", VA = "0x186E2B260")]
	public static EHNBKNPJGON<StringBuilder> GEKLBPFDDHO([Out] StringBuilder PFKKDHPJFEH)
	{
		return default(EHNBKNPJGON<StringBuilder>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x6E2B300", Offset = "0x6E2A700", VA = "0x186E2B300", Slot = "6")]
	protected override void JHHBHLLALID(StringBuilder OLPKAADIPCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x6E2B3C0", Offset = "0x6E2A7C0", VA = "0x186E2B3C0")]
	public ALIMHPNCEOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class OHFEANEHGBF : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x686B920", Offset = "0x686AD20", VA = "0x18686B920")]
	public OHFEANEHGBF(string NFKMLKNHFEM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
[DefaultMember("Item")]
public class DCFEKMBEOEH<TKey, TValue> : OAJCDDHMAHH<TKey, TValue>, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, GIEBCFOINOC where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class AFGKKFJNCJL : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private KeyValuePair<TKey, TValue> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public DCFEKMBEOEH<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private IEnumerator<KeyValuePair<TKey, TValue>> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		KeyValuePair<TKey, TValue> IEnumerator<KeyValuePair<TKey, TValue>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x13BBD40", Offset = "0x13BB140", VA = "0x1813BBD40", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TValue>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x3FC6A20", Offset = "0x3FC5E20", VA = "0x183FC6A20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x8A5100", Offset = "0x8A4500", VA = "0x1808A5100")]
		[DebuggerHidden]
		public AFGKKFJNCJL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x3EDD980", Offset = "0x3EDCD80", VA = "0x183EDD980", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x3FC65A0", Offset = "0x3FC59A0", VA = "0x183FC65A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x3FC6550", Offset = "0x3FC5950", VA = "0x183FC6550")]
		private void KAONCANHJBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x3FC6980", Offset = "0x3FC5D80", VA = "0x183FC6980")]
		private void NJJPNOJLCPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x3FC69D0", Offset = "0x3FC5DD0", VA = "0x183FC69D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly OAJCDDHMAHH<TKey, TValue> BPGHEKONDLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly IDictionary<TKey, TValue> IAJDPHKNEHA;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int AHBPDFJLDEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x5BE6CB0", Offset = "0x5BE60B0", VA = "0x185BE6CB0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool FGFOPPEDKMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x8E46A0", Offset = "0x8E3AA0", VA = "0x1808E46A0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public TValue LGNCPMFFKIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x5BE6F20", Offset = "0x5BE6320", VA = "0x185BE6F20", Slot = "4")]
		get
		{
			return (TValue)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x5BE71F0", Offset = "0x5BE65F0", VA = "0x185BE71F0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public ICollection<TKey> NKLGCGCAEDD
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x5BE6FB0", Offset = "0x5BE63B0", VA = "0x185BE6FB0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public ICollection<TValue> KLONAGGGDLL
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x5BE70D0", Offset = "0x5BE64D0", VA = "0x185BE70D0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x5BE6BF0", Offset = "0x5BE5FF0", VA = "0x185BE6BF0")]
	public DCFEKMBEOEH(OAJCDDHMAHH<TKey, TValue> BPGHEKONDLG, [Optional] IDictionary<TKey, TValue>? IAJDPHKNEHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x5BE47C0", Offset = "0x5BE3BC0", VA = "0x185BE47C0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x5BE4770", Offset = "0x5BE3B70", VA = "0x185BE4770")]
	public void CMBHFBGEHNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x5BE42E0", Offset = "0x5BE36E0", VA = "0x185BE42E0", Slot = "9")]
	public void Add(TKey PBFBBOFLBNL, TValue PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x5BE5250", Offset = "0x5BE4650", VA = "0x185BE5250")]
	public void EPOEOOHLLIM(TKey PBFBBOFLBNL, TValue PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x5BE4510", Offset = "0x5BE3910", VA = "0x185BE4510")]
	public void BLMDAJNMDHD(TKey PBFBBOFLBNL, TValue PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x5BE5610", Offset = "0x5BE4A10", VA = "0x185BE5610")]
	public void HJKFFKJAGGL(TKey PBFBBOFLBNL, TValue PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x5BE5080", Offset = "0x5BE4480", VA = "0x185BE5080")]
	public void DAJMLHIDDGC(TKey PBFBBOFLBNL, TValue PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x5BE6270", Offset = "0x5BE5670", VA = "0x185BE6270", Slot = "14")]
	void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> DHLKAMHBBEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x5BE6460", Offset = "0x5BE5860", VA = "0x185BE6460", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> DHLKAMHBBEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x5BE67C0", Offset = "0x5BE5BC0", VA = "0x185BE67C0", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> DHLKAMHBBEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x5BE4900", Offset = "0x5BE3D00", VA = "0x185BE4900", Slot = "8")]
	public bool ContainsKey(TKey PBFBBOFLBNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x5BE5C30", Offset = "0x5BE5030", VA = "0x185BE5C30")]
	public bool OGNKBBNBCNC(TKey PBFBBOFLBNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x5BE5B10", Offset = "0x5BE4F10", VA = "0x185BE5B10")]
	public bool HMDIHJHIGFI(TKey PBFBBOFLBNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x5BE5FD0", Offset = "0x5BE53D0", VA = "0x185BE5FD0", Slot = "10")]
	public bool Remove(TKey PBFBBOFLBNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x5BE6A50", Offset = "0x5BE5E50", VA = "0x185BE6A50", Slot = "11")]
	public bool TryGetValue(TKey PBFBBOFLBNL, [Out] TValue PFKKDHPJFEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x5BE4C00", Offset = "0x5BE4000", VA = "0x185BE4C00", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TValue>[] EFKOIGFMOHD, int KLLAFCJKGMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x44BB6D0", Offset = "0x44BAAD0", VA = "0x1844BB6D0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x5BE5560", Offset = "0x5BE4960", VA = "0x185BE5560", Slot = "19")]
	[IteratorStateMachine(typeof(DCFEKMBEOEH<, >.AFGKKFJNCJL))]
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x5BE3F80", Offset = "0x5BE3380", VA = "0x185BE3F80", Slot = "21")]
	public bool AJHBOLLOBBN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x5BE5CF0", Offset = "0x5BE50F0", VA = "0x185BE5CF0")]
	private TValue PIHMABKHFIA(TKey PBFBBOFLBNL)
	{
		return (TValue)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public interface GIEBCFOINOC
{
	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AJHBOLLOBBN();
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public interface OAJCDDHMAHH<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, GIEBCFOINOC
{
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[DefaultMember("Item")]
public sealed class LHJNOOGBBAM<TKey, TVal> : OAJCDDHMAHH<TKey, TVal>, IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, GIEBCFOINOC where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public delegate int OFFHEDGNNKA(TKey PBFBBOFLBNL, TVal PFKKDHPJFEH);

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public delegate void CMCBADJBHAE(TKey PBFBBOFLBNL, TVal PFKKDHPJFEH, IIFNECCGAIB BNIDPJNMOLO);

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	private class EMKNOGPKJCN
	{
		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public TKey NOMMKAICFPN
		{
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0xAE8210", Offset = "0xAE7610", VA = "0x180AE8210")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public TVal FDJCHKNOIDG
		{
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x9741A0", Offset = "0x9735A0", VA = "0x1809741A0")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0xAA25F0", Offset = "0xAA19F0", VA = "0x180AA25F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public int INPFMBGIDBE
		{
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x8DB7A0", Offset = "0x8DABA0", VA = "0x1808DB7A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x8DADA0", Offset = "0x8DA1A0", VA = "0x1808DADA0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public DateTimeOffset COJEHJGFCPA
		{
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0xF6EC40", Offset = "0xF6E040", VA = "0x180F6EC40")]
			[CompilerGenerated]
			get
			{
				return default(DateTimeOffset);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x196F520", Offset = "0x196E920", VA = "0x18196F520")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x3BAD0D0", Offset = "0x3BAC4D0", VA = "0x183BAD0D0")]
		public EMKNOGPKJCN(TKey PBFBBOFLBNL, TVal KCIHDEINMKL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private sealed class CJEHOGIICNP : IEnumerator<KeyValuePair<TKey, TVal>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private KeyValuePair<TKey, TVal> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public LHJNOOGBBAM<TKey, TVal> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private LinkedList<EMKNOGPKJCN>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		KeyValuePair<TKey, TVal> IEnumerator<KeyValuePair<TKey, TVal>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x13BBD40", Offset = "0x13BB140", VA = "0x1813BBD40", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TVal>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x563F610", Offset = "0x563EA10", VA = "0x18563F610", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x8A5100", Offset = "0x8A4500", VA = "0x1808A5100")]
		[DebuggerHidden]
		public CJEHOGIICNP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x3D87970", Offset = "0x3D86D70", VA = "0x183D87970", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x563D980", Offset = "0x563CD80", VA = "0x18563D980", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x563CA00", Offset = "0x563BE00", VA = "0x18563CA00")]
		private void KAONCANHJBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x563F480", Offset = "0x563E880", VA = "0x18563F480", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public const int LIDEMLNGAME = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly Dictionary<TKey, LinkedListNode<EMKNOGPKJCN>> NGHOKIKOFKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly LinkedList<EMKNOGPKJCN> NNHOIGKBPBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly OFFHEDGNNKA? DFAAGEHFIGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly TimeSpan OEKCBNHEFDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly CMCBADJBHAE? IJAMMGLKIOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly HEAAEJIOBID KINKPDGNDGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private bool JKKIIMKBPLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly List<TKey> OLHABEDHFBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly List<TVal> MHCKEDMKHKI;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int BAJAMKMOMOK
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x8AAEF0", Offset = "0x8AA2F0", VA = "0x1808AAEF0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	internal int LHIKDEAGEEF
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0xA021D0", Offset = "0xA015D0", VA = "0x180A021D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0xA01E90", Offset = "0xA01290", VA = "0x180A01E90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int AHBPDFJLDEL
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x4622720", Offset = "0x4621B20", VA = "0x184622720", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	internal int LBDLBPPOGIG
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x4043110", Offset = "0x4042510", VA = "0x184043110")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public ICollection<TVal> KLONAGGGDLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x46228A0", Offset = "0x4621CA0", VA = "0x1846228A0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	ICollection<TKey> IDictionary<TKey, TVal>.JBOLCIOPLGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x461DDF0", Offset = "0x461D1F0", VA = "0x18461DDF0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool FGFOPPEDKMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x8E46A0", Offset = "0x8E3AA0", VA = "0x1808E46A0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public TVal LGNCPMFFKIH
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x4622850", Offset = "0x4621C50", VA = "0x184622850", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x46228F0", Offset = "0x4621CF0", VA = "0x1846228F0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x4612300", Offset = "0x4611700", VA = "0x184612300")]
	private bool DIPNAIGHLJN(int PCJIPONCEAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x460EDC0", Offset = "0x460E1C0", VA = "0x18460EDC0")]
	private void BJELKJPJALL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x461F460", Offset = "0x461E860", VA = "0x18461F460")]
	public LHJNOOGBBAM(int PCJIPONCEAG, [Optional] OFFHEDGNNKA? DFAAGEHFIGD, [Optional] IEqualityComparer<TKey>? PKNNFPMPJGE, [Optional] CMCBADJBHAE? IJAMMGLKIOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x461F3F0", Offset = "0x461E7F0", VA = "0x18461F3F0")]
	public LHJNOOGBBAM(TimeSpan OEKCBNHEFDG, [Optional] IEqualityComparer<TKey>? PKNNFPMPJGE, [Optional] CMCBADJBHAE? IJAMMGLKIOH, [Optional] HEAAEJIOBID? KINKPDGNDGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x461EE30", Offset = "0x461E230", VA = "0x18461EE30")]
	public LHJNOOGBBAM(int PCJIPONCEAG, TimeSpan OEKCBNHEFDG, [Optional] IEqualityComparer<TKey>? PKNNFPMPJGE, [Optional] CMCBADJBHAE? IJAMMGLKIOH, [Optional] HEAAEJIOBID? KINKPDGNDGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x4620A40", Offset = "0x461FE40", VA = "0x184620A40")]
	public LHJNOOGBBAM(int PCJIPONCEAG, OFFHEDGNNKA? DFAAGEHFIGD, TimeSpan OEKCBNHEFDG, [Optional] IEqualityComparer<TKey>? PKNNFPMPJGE, [Optional] CMCBADJBHAE? IJAMMGLKIOH, [Optional] HEAAEJIOBID? KINKPDGNDGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x4609B10", Offset = "0x4608F10", VA = "0x184609B10", Slot = "21")]
	public bool AJHBOLLOBBN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x460F600", Offset = "0x460EA00", VA = "0x18460F600", Slot = "22")]
	public bool CPFLFMKANGB(int JKIIGJDNBMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x460ACF0", Offset = "0x460A0F0", VA = "0x18460ACF0")]
	private bool BBHIAMAKFHP(int JKIIGJDNBMO, IIFNECCGAIB BNIDPJNMOLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x461A3F0", Offset = "0x46197F0", VA = "0x18461A3F0")]
	public void NBJJIKECOBK(TKey PBFBBOFLBNL, TVal PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x4609ED0", Offset = "0x46092D0", VA = "0x184609ED0", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> DHLKAMHBBEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x4609BF0", Offset = "0x4608FF0", VA = "0x184609BF0", Slot = "9")]
	public void Add(TKey PBFBBOFLBNL, TVal PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x460FD10", Offset = "0x460F110", VA = "0x18460FD10", Slot = "8")]
	public bool ContainsKey(TKey PBFBBOFLBNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x461D590", Offset = "0x461C990", VA = "0x18461D590", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Contains(KeyValuePair<TKey, TVal> DHLKAMHBBEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x461CB00", Offset = "0x461BF00", VA = "0x18461CB00", Slot = "10")]
	public bool Remove(TKey PBFBBOFLBNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x461D950", Offset = "0x461CD50", VA = "0x18461D950", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Remove(KeyValuePair<TKey, TVal> DHLKAMHBBEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x46132C0", Offset = "0x46126C0", VA = "0x1846132C0")]
	private bool EKJOPGPGGCE(TKey PBFBBOFLBNL, [Out] TVal PFKKDHPJFEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x4613760", Offset = "0x4612B60", VA = "0x184613760")]
	private TVal GEKLBPFDDHO(TKey BLBBJJCCKGD)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x461E490", Offset = "0x461D890", VA = "0x18461E490", Slot = "11")]
	public bool TryGetValue(TKey BLBBJJCCKGD, [Out] TVal PFKKDHPJFEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x460FA20", Offset = "0x460EE20", VA = "0x18460FA20", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x4610B20", Offset = "0x460FF20", VA = "0x184610B20", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] EFKOIGFMOHD, int KLLAFCJKGMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x461C9C0", Offset = "0x461BDC0", VA = "0x18461C9C0")]
	private void OIIHGEGLHCF(TKey PBFBBOFLBNL, TVal KCIHDEINMKL, IIFNECCGAIB BNIDPJNMOLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x461B5E0", Offset = "0x461A9E0", VA = "0x18461B5E0")]
	private bool NOLJBIGDNJM(EMKNOGPKJCN NIIKIAPOEKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x46179E0", Offset = "0x4616DE0", VA = "0x1846179E0")]
	private void KMBBCCMJBOL(LinkedListNode<EMKNOGPKJCN> INCEBFDABEP, TVal DCGCMNFFOJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x46199D0", Offset = "0x4618DD0", VA = "0x1846199D0")]
	private void LCGHAFHBGIB(TKey PBFBBOFLBNL, TVal PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x4608A10", Offset = "0x4607E10", VA = "0x184608A10")]
	private void AEIDGFLJILG(EMKNOGPKJCN NIIKIAPOEKD, TVal DCGCMNFFOJI, int HIINENLAIDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x4614090", Offset = "0x4613490", VA = "0x184614090", Slot = "19")]
	[IteratorStateMachine(typeof(LHJNOOGBBAM<, >.CJEHOGIICNP))]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x461DE40", Offset = "0x461D240", VA = "0x18461DE40", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public enum IIFNECCGAIB : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	Evicted,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	RemovedViaRemove,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	RemovedViaClear,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	Overwritten
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public class CBBFJPCKNAG<TKey> : Exception where TKey : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public readonly TKey PLGBEPCMBPF;

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x544E430", Offset = "0x544D830", VA = "0x18544E430")]
	public CBBFJPCKNAG(TKey OPGKADFCAKJ, Exception PEMONHKIEDO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public class GJLDCCIJBMP : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x6129700", Offset = "0x6128B00", VA = "0x186129700")]
	public GJLDCCIJBMP(string NFKMLKNHFEM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class OFMNOCCLPOF<TId, TResource> : IEnumerable<(TId, Task<TResource>, int)>, IEnumerable where TId : notnull where TResource : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class LOJKFEMNAIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public Func<TId, CancellationToken, Task<TResource>> factory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public OFMNOCCLPOF<TId, TResource> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public LOJKFEMNAIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x4686220", Offset = "0x4685620", VA = "0x184686220")]
		internal Task<TResource> MMHBJPPIFDN(TId _id)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private struct AOAAJEHINHK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public OFMNOCCLPOF<TId, TResource> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x4106E80", Offset = "0x4106280", VA = "0x184106E80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x4107500", Offset = "0x4106900", VA = "0x184107500", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private struct JBCEELFLPDP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public Dictionary<Task<TResource>, CancellationTokenSource> cancellationTokenSources;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public CancellationTokenSource cts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x43CFFA0", Offset = "0x43CF3A0", VA = "0x1843CFFA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x43D0C80", Offset = "0x43D0080", VA = "0x1843D0C80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private readonly LFIIJAAJLLP<TId, Task<TResource>> MKPLDBGKGKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private readonly Dictionary<Task<TResource>, CancellationTokenSource> FHCBPCDPDEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly Func<TId, CancellationToken, Task<TResource>>? CDBIBNPGEEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly Action<TResource>? LIPFHBJGMCC;

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x4A51760", Offset = "0x4A50B60", VA = "0x184A51760")]
	public OFMNOCCLPOF(int FFMIFKEEDNO = 0, [Optional] IEqualityComparer<TId>? EINKIPJJAMI, [Optional] Func<TId, CancellationToken, Task<TResource>>? GKOBKPLADJP, [Optional] Action<TResource>? HFCOMHOKJOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x4A50BA0", Offset = "0x4A4FFA0", VA = "0x184A50BA0")]
	public GHHMJPGPOGF<Task<TResource>> HEFOPANDMHO(TId HDCHKIOFILD, [Optional] Func<TId, CancellationToken, Task<TResource>>? GKOBKPLADJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x4A504F0", Offset = "0x4A4F8F0", VA = "0x184A504F0")]
	private void CNDJNKPFHMC(Task<TResource> FFKGFPJNCFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x4A51430", Offset = "0x4A50830", VA = "0x184A51430")]
	[AsyncStateMachine(typeof(OFMNOCCLPOF<, >.AOAAJEHINHK))]
	private Task IAJAJPCHMEH(Task<TResource> FFKGFPJNCFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x4A51530", Offset = "0x4A50930", VA = "0x184A51530")]
	public void PCIELOFAMBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x4A50850", Offset = "0x4A4FC50", VA = "0x184A50850")]
	public LFIIJAAJLLP<TId, Task<TResource>>.PKNGDOKCNHA EDIPCEILGGF()
	{
		return default(LFIIJAAJLLP<TId, Task<TResource>>.PKNGDOKCNHA);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x4A516C0", Offset = "0x4A50AC0", VA = "0x184A516C0", Slot = "4")]
	private IEnumerator<(TId, Task<TResource>, int)> System.Collections.Generic.IEnumerable<(TIdId,System.Threading.Tasks.Task<TResource>LoadResourceTask,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x4A516C0", Offset = "0x4A50AC0", VA = "0x184A516C0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x4A50040", Offset = "0x4A4F440", VA = "0x184A50040")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(OFMNOCCLPOF<, >.JBCEELFLPDP))]
	internal static Task CBPGICKCFIL(Task<TResource> FFKGFPJNCFN, CancellationTokenSource APONDCPFFPJ, Dictionary<Task<TResource>, CancellationTokenSource> PDHGIMCGMFF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class LFIIJAAJLLP<TKey, TValue> : IEnumerable<(TKey, TValue, int)>, IEnumerable where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	private sealed class BEIPFNAMHEE : IEquatable<BEIPFNAMHEE>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public readonly TValue FDJCHKNOIDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public int BIMECKOKNJJ;

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0xC993B0", Offset = "0xC987B0", VA = "0x180C993B0")]
		public BEIPFNAMHEE(TValue PFKKDHPJFEH, int AKJJGOBCJEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x522F4F0", Offset = "0x522E8F0", VA = "0x18522F4F0", Slot = "4")]
		public bool Equals(BEIPFNAMHEE? OGKFFDCECEL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x522F450", Offset = "0x522E850", VA = "0x18522F450", Slot = "0")]
		public override bool Equals(object? FAKGLFFOLFI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x522F730", Offset = "0x522EB30", VA = "0x18522F730", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public struct PKNGDOKCNHA : IEnumerator<(TKey, TValue, int)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private Dictionary<TKey, BEIPFNAMHEE>.Enumerator PGOPFAONFOJ;

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x4B41020", Offset = "0x4B40420", VA = "0x184B41020", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public (TKey Key, TValue Value, int RefCount) LDHKDFDFMKJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x4B41480", Offset = "0x4B40880", VA = "0x184B41480", Slot = "4")]
			get
			{
				return default((TKey, TValue, int));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x4B412E0", Offset = "0x4B406E0", VA = "0x184B412E0")]
		public PKNGDOKCNHA(LFIIJAAJLLP<TKey, TValue> GCAOPEJPLMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x4B40C80", Offset = "0x4B40080", VA = "0x184B40C80", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x4B40D00", Offset = "0x4B40100", VA = "0x184B40D00", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x4B40D80", Offset = "0x4B40180", VA = "0x184B40D80", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private sealed class HHLNGDEHECB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public LFIIJAAJLLP<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public TKey key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public BEIPFNAMHEE refCountedValue;

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public HHLNGDEHECB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x4151380", Offset = "0x4150780", VA = "0x184151380")]
		internal void MMHBJPPIFDN()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private readonly Dictionary<TKey, BEIPFNAMHEE> NPNACKEFHJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly Func<TKey, TValue>? OMHMFDLODEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private readonly Action<TValue>? PEJHDKAEJDP;

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x45ECFA0", Offset = "0x45EC3A0", VA = "0x1845ECFA0")]
	public LFIIJAAJLLP(int FFMIFKEEDNO = 0, [Optional] IEqualityComparer<TKey>? PKNNFPMPJGE, [Optional] Func<TKey, TValue>? IBLOICLIGPK, [Optional] Action<TValue>? KHAPFECDGIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x45EBE40", Offset = "0x45EB240", VA = "0x1845EBE40")]
	public GHHMJPGPOGF<TValue> HEFOPANDMHO(TKey PBFBBOFLBNL, [Optional] Func<TKey, TValue>? PDOKFNEMNNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x45EB6A0", Offset = "0x45EAAA0", VA = "0x1845EB6A0")]
	private void AFNCKMDLBLN(TKey PBFBBOFLBNL, BEIPFNAMHEE KOCGFEODCID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x45ECBB0", Offset = "0x45EBFB0", VA = "0x1845ECBB0")]
	public void PCIELOFAMBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x45EBA40", Offset = "0x45EAE40", VA = "0x1845EBA40")]
	public PKNGDOKCNHA EDIPCEILGGF()
	{
		return default(PKNGDOKCNHA);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x45ECE60", Offset = "0x45EC260", VA = "0x1845ECE60", Slot = "4")]
	private IEnumerator<(TKey, TValue, int)> System.Collections.Generic.IEnumerable<(TKeyKey,TValueValue,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x45ECE60", Offset = "0x45EC260", VA = "0x1845ECE60", Slot = "5")]
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
