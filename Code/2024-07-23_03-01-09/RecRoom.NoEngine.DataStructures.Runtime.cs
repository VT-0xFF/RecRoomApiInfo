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
		[Cpp2IlInjected.Address(RVA = "0x87C5D0", Offset = "0x87B7D0", VA = "0x18087C5D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x69C9990", Offset = "0x69C8B90", VA = "0x1869C9990")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x87D8D0", Offset = "0x87CAD0", VA = "0x18087D8D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x87D910", Offset = "0x87CB10", VA = "0x18087D910")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class EONDKOPFHGB
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
	protected EONDKOPFHGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class PCHDCLFEEDF<T> : EONDKOPFHGB
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	protected struct PCJAGCCKAOK
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public enum FELGLHHHPEF
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
		public FELGLHHHPEF NCMHJNKFAGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public T ENGMCBPHJGL;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private int GINAKNKLLNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool IIPKBLOGIFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	protected readonly bool JEMOMFALLKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	protected List<T>? HOMBGNNIPKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<PCJAGCCKAOK>? FDLBMGFOMGG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool FKFJFBEAEPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4768460", Offset = "0x4767660", VA = "0x184768460")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x47686C0", Offset = "0x47678C0", VA = "0x1847686C0")]
	protected PCHDCLFEEDF(bool JEMOMFALLKL, bool IIPKBLOGIFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4768060", Offset = "0x4767260", VA = "0x184768060")]
	protected bool IMIEBMALNFH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4767CE0", Offset = "0x4766EE0", VA = "0x184767CE0")]
	protected void ENNFPLJBMDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4767DF0", Offset = "0x4766FF0", VA = "0x184767DF0")]
	protected void ICGFNMKKNCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2BCF4F0", Offset = "0x2BCE6F0", VA = "0x182BCF4F0")]
	private static void PPFNMNMGADK<U>(List<U>? CGIFJALMJMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x47684C0", Offset = "0x47676C0", VA = "0x1847684C0", Slot = "4")]
	public void PBLNBBGFGAP(T ENGMCBPHJGL, bool LKEHFOHKDKI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x47682A0", Offset = "0x47674A0", VA = "0x1847682A0", Slot = "5")]
	public void MFKDEBIIBOM(T ENGMCBPHJGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4768100", Offset = "0x4767300", VA = "0x184768100")]
	public void IMJJLGNDCEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class EHODCIMNDCH : PCHDCLFEEDF<Action>
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x69C7140", Offset = "0x69C6340", VA = "0x1869C7140")]
	public EHODCIMNDCH(bool JEMOMFALLKL = false, bool IIPKBLOGIFD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x69C6E80", Offset = "0x69C6080", VA = "0x1869C6E80")]
	public void APPOJKGPLJE()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x69C70E0", Offset = "0x69C62E0", VA = "0x1869C70E0")]
	public static EHODCIMNDCH PJMNGAAAFLI(EHODCIMNDCH IBKBKIOEMKH, Action ENGMCBPHJGL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x69C7080", Offset = "0x69C6280", VA = "0x1869C7080")]
	public static EHODCIMNDCH BOIEBIFOEJM(EHODCIMNDCH IBKBKIOEMKH, Action ENGMCBPHJGL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface EHNLMLDPBEP<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PBLNBBGFGAP(Action<T> ENGMCBPHJGL, bool LKEHFOHKDKI = false);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MFKDEBIIBOM(Action<T> ENGMCBPHJGL);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class ODIOBOMGOFD<T> : PCHDCLFEEDF<Action<T>>, EHNLMLDPBEP<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3C657F0", Offset = "0x3C649F0", VA = "0x183C657F0")]
	public ODIOBOMGOFD(bool JEMOMFALLKL = false, bool IIPKBLOGIFD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x462E400", Offset = "0x462D600", VA = "0x18462E400")]
	public void APPOJKGPLJE(T DOGPFNGIKMO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3E4AC40", Offset = "0x3E49E40", VA = "0x183E4AC40")]
	public static ODIOBOMGOFD<T> PJMNGAAAFLI(ODIOBOMGOFD<T> IBKBKIOEMKH, Action<T> ENGMCBPHJGL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3E4ABA0", Offset = "0x3E49DA0", VA = "0x183E4ABA0")]
	public static ODIOBOMGOFD<T> BOIEBIFOEJM(ODIOBOMGOFD<T> IBKBKIOEMKH, Action<T> ENGMCBPHJGL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface LBBAKIKAAMK<T, U> where T : notnull where U : notnull
{
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class OPLNKFOLMMC<T, U> : PCHDCLFEEDF<Action<T, U>>, LBBAKIKAAMK<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3C657F0", Offset = "0x3C649F0", VA = "0x183C657F0")]
	public OPLNKFOLMMC(bool JEMOMFALLKL = false, bool IIPKBLOGIFD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x46C4060", Offset = "0x46C3260", VA = "0x1846C4060")]
	public void APPOJKGPLJE(T DOGPFNGIKMO, U AICJBILPPGK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3E4AC40", Offset = "0x3E49E40", VA = "0x183E4AC40")]
	public static OPLNKFOLMMC<T, U> PJMNGAAAFLI(OPLNKFOLMMC<T, U> IBKBKIOEMKH, Action<T, U> ENGMCBPHJGL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3E4ABA0", Offset = "0x3E49DA0", VA = "0x183E4ABA0")]
	public static OPLNKFOLMMC<T, U> BOIEBIFOEJM(OPLNKFOLMMC<T, U> IBKBKIOEMKH, Action<T, U> ENGMCBPHJGL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class IEBCNEDNECP<T, U, V> : PCHDCLFEEDF<Action<T, U, V>> where T : notnull where U : notnull where V : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3C657F0", Offset = "0x3C649F0", VA = "0x183C657F0")]
	public IEBCNEDNECP(bool JEMOMFALLKL = false, bool IIPKBLOGIFD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3E49BB0", Offset = "0x3E48DB0", VA = "0x183E49BB0")]
	public void APPOJKGPLJE(T DOGPFNGIKMO, U AICJBILPPGK, V NJJHKDBJDAC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3E4AC40", Offset = "0x3E49E40", VA = "0x183E4AC40")]
	public static IEBCNEDNECP<T, U, V> PJMNGAAAFLI(IEBCNEDNECP<T, U, V> IBKBKIOEMKH, Action<T, U, V> ENGMCBPHJGL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3E4ABA0", Offset = "0x3E49DA0", VA = "0x183E4ABA0")]
	public static IEBCNEDNECP<T, U, V> BOIEBIFOEJM(IEBCNEDNECP<T, U, V> IBKBKIOEMKH, Action<T, U, V> ENGMCBPHJGL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface FNMGHCNMHDJ<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public sealed class PBCEHIPJNNH<T, U, V, W> : PCHDCLFEEDF<Action<T, U, V, W>>, FNMGHCNMHDJ<T, U, V, W> where T : notnull where U : notnull where V : notnull where W : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3C657F0", Offset = "0x3C649F0", VA = "0x183C657F0")]
	public PBCEHIPJNNH(bool JEMOMFALLKL = false, bool IIPKBLOGIFD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4762CA0", Offset = "0x4761EA0", VA = "0x184762CA0")]
	public void APPOJKGPLJE(T DOGPFNGIKMO, U AICJBILPPGK, V NJJHKDBJDAC, W HNFNJDLDBDO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3E4AC40", Offset = "0x3E49E40", VA = "0x183E4AC40")]
	public static PBCEHIPJNNH<T, U, V, W> PJMNGAAAFLI(PBCEHIPJNNH<T, U, V, W> IBKBKIOEMKH, Action<T, U, V, W> ENGMCBPHJGL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3E4ABA0", Offset = "0x3E49DA0", VA = "0x183E4ABA0")]
	public static PBCEHIPJNNH<T, U, V, W> BOIEBIFOEJM(PBCEHIPJNNH<T, U, V, W> IBKBKIOEMKH, Action<T, U, V, W> ENGMCBPHJGL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class NDLBBAPPBDD<T, U, V, W, X> : PCHDCLFEEDF<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3C657F0", Offset = "0x3C649F0", VA = "0x183C657F0")]
	public NDLBBAPPBDD(bool JEMOMFALLKL = false, bool IIPKBLOGIFD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4511BC0", Offset = "0x4510DC0", VA = "0x184511BC0")]
	public void APPOJKGPLJE(T DOGPFNGIKMO, U AICJBILPPGK, V NJJHKDBJDAC, W HNFNJDLDBDO, X IPBJLCONKPC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3E4AC40", Offset = "0x3E49E40", VA = "0x183E4AC40")]
	public static NDLBBAPPBDD<T, U, V, W, X> PJMNGAAAFLI(NDLBBAPPBDD<T, U, V, W, X> IBKBKIOEMKH, Action<T, U, V, W, X> ENGMCBPHJGL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3E4ABA0", Offset = "0x3E49DA0", VA = "0x183E4ABA0")]
	public static NDLBBAPPBDD<T, U, V, W, X> BOIEBIFOEJM(NDLBBAPPBDD<T, U, V, W, X> IBKBKIOEMKH, Action<T, U, V, W, X> ENGMCBPHJGL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class MDJDBMCPDBN<T, U, V, W, X, Y> : PCHDCLFEEDF<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3C657F0", Offset = "0x3C649F0", VA = "0x183C657F0")]
	public MDJDBMCPDBN(bool JEMOMFALLKL = false, bool IIPKBLOGIFD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x44965B0", Offset = "0x44957B0", VA = "0x1844965B0")]
	public void APPOJKGPLJE(T DOGPFNGIKMO, U AICJBILPPGK, V NJJHKDBJDAC, W HNFNJDLDBDO, X IPBJLCONKPC, Y FACAKAOOAJP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3E4AC40", Offset = "0x3E49E40", VA = "0x183E4AC40")]
	public static MDJDBMCPDBN<T, U, V, W, X, Y> PJMNGAAAFLI(MDJDBMCPDBN<T, U, V, W, X, Y> IBKBKIOEMKH, Action<T, U, V, W, X, Y> ENGMCBPHJGL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3E4ABA0", Offset = "0x3E49DA0", VA = "0x183E4ABA0")]
	public static MDJDBMCPDBN<T, U, V, W, X, Y> BOIEBIFOEJM(MDJDBMCPDBN<T, U, V, W, X, Y> IBKBKIOEMKH, Action<T, U, V, W, X, Y> ENGMCBPHJGL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class KFNLCMGOLPI<TKey, TVal> where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly LKJHFGDNFFP<TKey, TVal> GDMPCGEPPGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly Dictionary<TKey, (TVal value, int size)> GJKHGJBFPHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly LKJHFGDNFFP<TKey, TVal>.KFPHOPMGLCO? DKBFFBLIJNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly int EEOEDOGAIMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly LKJHFGDNFFP<TKey, TVal>.DMEMAHLHJCO? NLFLNFMHLBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private int GFOOCGNPAMK;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal int LMCNBEECMEG
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x418EC20", Offset = "0x418DE20", VA = "0x18418EC20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int DBFNDBELIMD
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x852880", Offset = "0x851A80", VA = "0x180852880")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x418EF30", Offset = "0x418E130", VA = "0x18418EF30")]
	public KFNLCMGOLPI(int EEOEDOGAIMO, [Optional] LKJHFGDNFFP<TKey, TVal>.DMEMAHLHJCO? NLFLNFMHLBJ, [Optional] IEqualityComparer<TKey>? PMELJJPGANC, [Optional] LKJHFGDNFFP<TKey, TVal>.KFPHOPMGLCO? DKBFFBLIJNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x418E0F0", Offset = "0x418D2F0", VA = "0x18418E0F0")]
	public void IFBGAKJKFOE(TKey NDDCLPHCEEO, TVal JMDCGOKJIDA, bool PGNPAGKNOJL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x418EAC0", Offset = "0x418DCC0", VA = "0x18418EAC0")]
	public bool LHFKLFJGKLM(TKey NDDCLPHCEEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x418DC80", Offset = "0x418CE80", VA = "0x18418DC80")]
	public bool AKPHPFIGELN(TKey LEPFMLOCOKH, [Out] TVal JMDCGOKJIDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x418EC70", Offset = "0x418DE70", VA = "0x18418EC70")]
	private void PCOIPMNNHFL(TKey NDDCLPHCEEO, TVal JMDCGOKJIDA, int ECGAAJFODGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x418E310", Offset = "0x418D510", VA = "0x18418E310")]
	public bool IKGLBGGMAKG(TKey NDDCLPHCEEO, TVal JMDCGOKJIDA, bool PGNPAGKNOJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x418E4D0", Offset = "0x418D6D0", VA = "0x18418E4D0")]
	public void IMJJLGNDCEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x418E570", Offset = "0x418D770", VA = "0x18418E570")]
	private void KFMIFKKBNID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x418DFB0", Offset = "0x418D1B0", VA = "0x18418DFB0")]
	private bool HEPPGGBHHJP(TKey NDDCLPHCEEO, JAEDDHFIPOE NPGFMGMHJJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x418DD70", Offset = "0x418CF70", VA = "0x18418DD70")]
	private void BIMMJAIOPGC(TKey NDDCLPHCEEO, TVal JMDCGOKJIDA, JAEDDHFIPOE NPGFMGMHJJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x418DE90", Offset = "0x418D090", VA = "0x18418DE90")]
	private void DJLDEBECLKL(TKey NDDCLPHCEEO, TVal GPBAFILNEOM, JAEDDHFIPOE NPGFMGMHJJL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class JOHMLMDFHNO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly Action JNKKLOOAFLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool KEPMKGNJNOJ;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8531E0", Offset = "0x8523E0", VA = "0x1808531E0")]
	public JOHMLMDFHNO(Action BDILBDIGJFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x69C8340", Offset = "0x69C7540", VA = "0x1869C8340", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x28D5900", Offset = "0x28D4B00", VA = "0x1828D5900")]
	public static PIKIJNPLMPM<T> JGIIBNEOBDO<T>(T JMDCGOKJIDA, Action BDILBDIGJFD) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class PIKIJNPLMPM<T> : JOHMLMDFHNO where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public T JNHPIMBJPMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8528A0", Offset = "0x851AA0", VA = "0x1808528A0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x477A5F0", Offset = "0x47797F0", VA = "0x18477A5F0")]
	public PIKIJNPLMPM(T JMDCGOKJIDA, Action BDILBDIGJFD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class KICDLLEGEEI<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly CLNHAANMJHP<T>? GFCNECHHGBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly ReadOnlySequence<T> EFONMOCCNEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private bool KEPMKGNJNOJ;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly KICDLLEGEEI<T> ENKECPBOOIC;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ReadOnlySequence<T> MCGINMOJIDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x4192310", Offset = "0x4191510", VA = "0x184192310")]
		get
		{
			return default(ReadOnlySequence<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long PBLCBJADLHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x4191FB0", Offset = "0x41911B0", VA = "0x184191FB0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool CFHDDGLKNCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x4191C80", Offset = "0x4190E80", VA = "0x184191C80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4192580", Offset = "0x4191780", VA = "0x184192580")]
	public KICDLLEGEEI(CLNHAANMJHP<T> JEKOHDNPLBC, CLNHAANMJHP<T> BJALNJNECHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x4192670", Offset = "0x4191870", VA = "0x184192670")]
	public KICDLLEGEEI(CLNHAANMJHP<T> JEKOHDNPLBC, int JHEGPJBDKAJ, CLNHAANMJHP<T> BJALNJNECHB, int MLNHFJAKLHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x41924D0", Offset = "0x41916D0", VA = "0x1841924D0")]
	private KICDLLEGEEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x4191E00", Offset = "0x4191000", VA = "0x184191E00", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x41921E0", Offset = "0x41913E0", VA = "0x1841921E0")]
	public T[] MCENKMDFCLO()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x4191E90", Offset = "0x4191090", VA = "0x184191E90")]
	public static ReadOnlySequence<T> GCLAHEGAFFN(KICDLLEGEEI<T>? BJMHIIGPDHE)
	{
		return default(ReadOnlySequence<T>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct AHNPDBJIDJD : IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct IPFCNNLNOGP : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x89B030", Offset = "0x89A230", VA = "0x18089B030")]
		public static IPFCNNLNOGP FJAAFKPDAIA()
		{
			return default(IPFCNNLNOGP);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x31DFA00", Offset = "0x31DEC00", VA = "0x1831DFA00")]
	public static string? CDBGPHHBDGD<T>([Optional] string? OCJCANJDIPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x31DFA80", Offset = "0x31DEC80", VA = "0x1831DFA80")]
	public static string? NFHIGCMPAPO<T>([Optional] string? GHAMCPDDCOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x89B030", Offset = "0x89A230", VA = "0x18089B030")]
	public static AHNPDBJIDJD AIJAFPFEFCM(string OCJCANJDIPB, string? GHAMCPDDCOM)
	{
		return default(AHNPDBJIDJD);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct OALIALIPGJK
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate bool CPINKONIOII(string JNOFCOPAOHP, OALIALIPGJK CGGHNOOFCEE);

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class OMAKALHAOGF<T> where T : notnull, Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public List<int> enumValuesSubset;

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public OMAKALHAOGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x4681B20", Offset = "0x4680D20", VA = "0x184681B20")]
		internal void CFNEHBFDECH(T x)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public int NKEPPGPEFAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public string EKLCLOAEABE;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x69C9A10", Offset = "0x69C8C10", VA = "0x1869C9A10")]
	public static Dictionary<string, OALIALIPGJK> BNKAOPAALJI(Type JKIBILAAALJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2CBC4D0", Offset = "0x2CBB6D0", VA = "0x182CBC4D0")]
	public static Dictionary<string, OALIALIPGJK> BNKAOPAALJI<T>(Type JKIBILAAALJ, IReadOnlyDictionary<T, string> FEJKFBNDGOM) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2CBCD00", Offset = "0x2CBBF00", VA = "0x182CBCD00")]
	public static Dictionary<string, OALIALIPGJK> DJLOBENCLDB<T>(List<T> LDEKPKHKINC) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x69C9F00", Offset = "0x69C9100", VA = "0x1869C9F00")]
	public static Dictionary<string, OALIALIPGJK> NPJHABBCENL(Type JKIBILAAALJ, CPINKONIOII NPOCAOPDPCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x69C9D40", Offset = "0x69C8F40", VA = "0x1869C9D40")]
	public static Dictionary<int, string> GKGHGIPKFHD(Dictionary<string, OALIALIPGJK> LDPKCIGIIMG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class EGADAFAJMEN : IKKDIOOIDLA
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static bool ODEEPDCCGBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly string? JNPPBFGLAPC;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public virtual IKKDIOOIDLA? EKBGLLACPJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8542A0", Offset = "0x8534A0", VA = "0x1808542A0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x69C6E10", Offset = "0x69C6010", VA = "0x1869C6E10")]
	protected EGADAFAJMEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string AGNLMABPEGN();

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x69C6B10", Offset = "0x69C5D10", VA = "0x1869C6B10", Slot = "8")]
	public virtual string FMEGILNGHGC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x69C67D0", Offset = "0x69C59D0", VA = "0x1869C67D0", Slot = "9")]
	public void BLIMGKEMFLN(StringBuilder OJCNGLLCFAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x69C6770", Offset = "0x69C5970", VA = "0x1869C6770", Slot = "10")]
	public void AEKHJNONJBN(StringBuilder OJCNGLLCFAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x69C6B90", Offset = "0x69C5D90", VA = "0x1869C6B90", Slot = "11")]
	public void GNKJOIOJAFE(StringBuilder OJCNGLLCFAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x69C6CB0", Offset = "0x69C5EB0", VA = "0x1869C6CB0", Slot = "12")]
	public void LHLKIDPFGOK(StringBuilder OJCNGLLCFAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x69C6A70", Offset = "0x69C5C70", VA = "0x1869C6A70")]
	public static void CFHHCGPHJND(StringBuilder OJCNGLLCFAA, string LBDIAILPDCC, string DGBLABHNCMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5B8FA70", Offset = "0x5B8EC70", VA = "0x185B8FA70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class NNLKANOBHEH : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x69C9000", Offset = "0x69C8200", VA = "0x1869C9000")]
	public NNLKANOBHEH(string JNNDBFGKHHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class MMILPAGNPCE<TErr> : NNLKANOBHEH where TErr : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly TErr HNDFFKMDGKI;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x44C1420", Offset = "0x44C0620", VA = "0x1844C1420")]
	private MMILPAGNPCE([In] TErr BIALHEALFLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x44C1350", Offset = "0x44C0550", VA = "0x1844C1350")]
	public static MMILPAGNPCE<TErr> FJAAFKPDAIA([In] TErr BIALHEALFLJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class KNMHLIHKHED : Stream
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly HashAlgorithm MALLOOCGECO;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public override bool KPEFFLFAICA
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x89B030", Offset = "0x89A230", VA = "0x18089B030", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public override bool OBCMKLKNFJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x89B030", Offset = "0x89A230", VA = "0x18089B030", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public override bool IHGOKPEGMPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x86D520", Offset = "0x86C720", VA = "0x18086D520", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override long PBLCBJADLHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x69C86B0", Offset = "0x69C78B0", VA = "0x1869C86B0", Slot = "12")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override long PHJFFHJCDOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x69C8720", Offset = "0x69C7920", VA = "0x1869C8720", Slot = "13")]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x69C8790", Offset = "0x69C7990", VA = "0x1869C8790", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x69C8640", Offset = "0x69C7840", VA = "0x1869C8640")]
	public KNMHLIHKHED(HashAlgorithm MALLOOCGECO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x69C8460", Offset = "0x69C7660", VA = "0x1869C8460", Slot = "35")]
	public override int Read(byte[] PHMDIHEJOGG, int PENDBLHFGOI, int IHGHLPOONHD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x69C8610", Offset = "0x69C7810", VA = "0x1869C8610", Slot = "38")]
	public override void Write(byte[] PHMDIHEJOGG, int PENDBLHFGOI, int IHGHLPOONHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x69C8500", Offset = "0x69C7700", VA = "0x1869C8500", Slot = "33")]
	public override long Seek(long PENDBLHFGOI, SeekOrigin MNCFLKFGCKD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x69C8590", Offset = "0x69C7790", VA = "0x1869C8590", Slot = "34")]
	public override void SetLength(long JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290", Slot = "23")]
	public override void Flush()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x69C8380", Offset = "0x69C7580", VA = "0x1869C8380")]
	public byte[] GLJLINEAPKO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface IKKDIOOIDLA
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string FMEGILNGHGC();

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string AGNLMABPEGN();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface MPPODIJIGFH<out TOptions> where TOptions : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	TOptions JNHPIMBJPMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface IGAPMMDOAFN
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	string HNNDPHAGJCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class CLNHAANMJHP<T> : ReadOnlySequenceSegment<T>, IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private static CLNHAANMJHP<T>? DJIICCIPMKO;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private static object CHELLBMLIGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private IMemoryOwner<T>? NOFKPJCMNOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private bool KEPMKGNJNOJ;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool OJBMAONCMFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x9E24F0", Offset = "0x9E16F0", VA = "0x1809E24F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x51F8440", Offset = "0x51F7640", VA = "0x1851F8440")]
	private static CLNHAANMJHP<T> NKDMLCAILNB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x51F73A0", Offset = "0x51F65A0", VA = "0x1851F73A0")]
	private static void JADCCDCNOLH(CLNHAANMJHP<T> LPOBPOAGFHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x3CD4910", Offset = "0x3CD3B10", VA = "0x183CD4910")]
	private CLNHAANMJHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x51F7940", Offset = "0x51F6B40", VA = "0x1851F7940")]
	public static CLNHAANMJHP<T> JGIIBNEOBDO(ReadOnlyMemory<T> EDNOMKCPEGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x51F7B10", Offset = "0x51F6D10", VA = "0x1851F7B10")]
	public static CLNHAANMJHP<T> JGIIBNEOBDO(IMemoryOwner<T> INNKPDCJHIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x51F8310", Offset = "0x51F7510", VA = "0x1851F8310")]
	public static void NDFMBLMHNHO(CLNHAANMJHP<T> JEKOHDNPLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x51F6EC0", Offset = "0x51F60C0", VA = "0x1851F6EC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x51F8210", Offset = "0x51F7410", VA = "0x1851F8210")]
	public CLNHAANMJHP<T> LBJDLPDBEDK(IMemoryOwner<T> INNKPDCJHIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x51F7EF0", Offset = "0x51F70F0", VA = "0x1851F7EF0")]
	private void JIIKFBPNFND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x51F80D0", Offset = "0x51F72D0", VA = "0x1851F80D0")]
	private CLNHAANMJHP<T> KGEKKJCOPLE(CLNHAANMJHP<T> LPOBPOAGFHD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class BLMECOIIFEK : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x69C6310", Offset = "0x69C5510", VA = "0x1869C6310")]
	public BLMECOIIFEK(string JNNDBFGKHHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class KOKJJOKECLK<TOk> : BLMECOIIFEK where TOk : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly TOk ACEKLHKKIKP;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x41CED70", Offset = "0x41CDF70", VA = "0x1841CED70")]
	private KOKJJOKECLK([In] TOk ANPDLFAPLKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3D19D70", Offset = "0x3D18F70", VA = "0x183D19D70")]
	public static KOKJJOKECLK<TOk> FJAAFKPDAIA([In] TOk ANPDLFAPLKO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class ICOBPIEENIH : Stream
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly ReadOnlySequence<byte> EFONMOCCNEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private SequencePosition IILNLNEPHHI;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public override bool KPEFFLFAICA
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x86D520", Offset = "0x86C720", VA = "0x18086D520", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public override bool OBCMKLKNFJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x86D520", Offset = "0x86C720", VA = "0x18086D520", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public override bool IHGOKPEGMPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x89B030", Offset = "0x89A230", VA = "0x18089B030", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public override long PBLCBJADLHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x69C7C40", Offset = "0x69C6E40", VA = "0x1869C7C40", Slot = "12")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public override long PHJFFHJCDOD
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x69C7CA0", Offset = "0x69C6EA0", VA = "0x1869C7CA0", Slot = "13")]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x69C7D70", Offset = "0x69C6F70", VA = "0x1869C7D70", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x69C7B70", Offset = "0x69C6D70", VA = "0x1869C7B70")]
	public ICOBPIEENIH(ReadOnlySequence<byte> BJMHIIGPDHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x69C7720", Offset = "0x69C6920", VA = "0x1869C7720", Slot = "33")]
	public override long Seek(long PENDBLHFGOI, SeekOrigin MNCFLKFGCKD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x69C7280", Offset = "0x69C6480", VA = "0x1869C7280", Slot = "35")]
	public override int Read(byte[] PHMDIHEJOGG, int PENDBLHFGOI, int IHGHLPOONHD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290", Slot = "23")]
	public override void Flush()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x69C7AB0", Offset = "0x69C6CB0", VA = "0x1869C7AB0", Slot = "34")]
	public override void SetLength(long JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x69C7B10", Offset = "0x69C6D10", VA = "0x1869C7B10", Slot = "38")]
	public override void Write(byte[] PHMDIHEJOGG, int PENDBLHFGOI, int IHGHLPOONHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public readonly struct CIKECDEKJAI<TOk, TErr> : IEquatable<CIKECDEKJAI<TOk, TErr>> where TOk : notnull where TErr : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly EqualityComparer<TErr> MHFOFOHLOBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	internal readonly TErr HNDFFKMDGKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	internal readonly TOk ACEKLHKKIKP;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool HGAPAMNFJGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x510D870", Offset = "0x510CA70", VA = "0x18510D870")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool BKLCFEFPKND
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5111500", Offset = "0x5110700", VA = "0x185111500")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5112F90", Offset = "0x5112190", VA = "0x185112F90")]
	internal CIKECDEKJAI([In] TErr BIALHEALFLJ, [In] TOk ANPDLFAPLKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x510DE90", Offset = "0x510D090", VA = "0x18510DE90")]
	public static CIKECDEKJAI<TOk, TErr> CDNNEODIDEA([In] TErr BIALHEALFLJ)
	{
		return default(CIKECDEKJAI<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x510E280", Offset = "0x510D480", VA = "0x18510E280")]
	public static CIKECDEKJAI<TOk, TErr> COBHGIDCNJO([In] TOk ANPDLFAPLKO)
	{
		return default(CIKECDEKJAI<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x27545C0", Offset = "0x27537C0", VA = "0x1827545C0")]
	public CIKECDEKJAI<TOk?, UErr?> NKOIMMHIKLA<UErr>()
	{
		return default(CIKECDEKJAI<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2753D80", Offset = "0x2752F80", VA = "0x182753D80")]
	public CIKECDEKJAI<UOk?, TErr?> GKPPOACGCNH<UOk>()
	{
		return default(CIKECDEKJAI<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2753150", Offset = "0x2752350", VA = "0x182753150")]
	public CIKECDEKJAI<UOk?, TErr?> ELFDPHOGCFJ<UOk>()
	{
		return default(CIKECDEKJAI<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2752980", Offset = "0x2751B80", VA = "0x182752980")]
	public CIKECDEKJAI<TOk?, UErr?> BPAKFFAOHLN<UErr>()
	{
		return default(CIKECDEKJAI<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x5111030", Offset = "0x5110230", VA = "0x185111030")]
	public CIKECDEKJAI<MOOMEEOMEEK, TErr> OKDFKNDAHLP()
	{
		return default(CIKECDEKJAI<MOOMEEOMEEK, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x5110970", Offset = "0x510FB70", VA = "0x185110970")]
	public static bool KBKLEFBHIDJ([In] CIKECDEKJAI<TOk, TErr> IIILBPDHGHN, [In] CIKECDEKJAI<TOk, TErr> CLEBPGFBBGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x510EB90", Offset = "0x510DD90", VA = "0x18510EB90", Slot = "4")]
	public bool Equals(CIKECDEKJAI<TOk, TErr> OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x510EC60", Offset = "0x510DE60", VA = "0x18510EC60", Slot = "0")]
	public override bool Equals(object OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x510F590", Offset = "0x510E790", VA = "0x18510F590", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x5111990", Offset = "0x5110B90", VA = "0x185111990", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class FJNDMNICLBA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct OOJOEMADILA<TOk, TErr> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public AsyncTaskMethodBuilder<TOk> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public Task<CIKECDEKJAI<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private TaskAwaiter<CIKECDEKJAI<TOk, TErr>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x46BCB40", Offset = "0x46BBD40", VA = "0x1846BCB40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x46BD180", Offset = "0x46BC380", VA = "0x1846BD180", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x2B20920", Offset = "0x2B1FB20", VA = "0x182B20920")]
	public static CIKECDEKJAI<TOk?, TErr?> ACEKLHKKIKP<TOk, TErr>([In] this CIKECDEKJAI<TOk, TErr> HIKEOGPAJAF, [In] TOk ANPDLFAPLKO)
	{
		return default(CIKECDEKJAI<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x2B20970", Offset = "0x2B1FB70", VA = "0x182B20970")]
	public static CIKECDEKJAI<MOOMEEOMEEK, TErr?> ACEKLHKKIKP<TErr>([In] this CIKECDEKJAI<MOOMEEOMEEK, TErr> HIKEOGPAJAF)
	{
		return default(CIKECDEKJAI<MOOMEEOMEEK, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x2B20920", Offset = "0x2B1FB20", VA = "0x182B20920")]
	public static CIKECDEKJAI<TOk?, TErr?> HNDFFKMDGKI<TOk, TErr>([In] this CIKECDEKJAI<TOk, TErr> HIKEOGPAJAF, [In] TErr BIALHEALFLJ)
	{
		return default(CIKECDEKJAI<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x2B23020", Offset = "0x2B22220", VA = "0x182B23020")]
	public static TOk? NOOHCMLJMLC<TOk, TErr>([In] this CIKECDEKJAI<TOk, TErr> HIKEOGPAJAF)
	{
		return (TOk?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x2B21450", Offset = "0x2B20650", VA = "0x182B21450")]
	[AsyncStateMachine(typeof(OOJOEMADILA<, >))]
	public static Task<TOk?>? GPNPLLDKGPP<TOk, TErr>(this Task<CIKECDEKJAI<TOk, TErr>> HIKEOGPAJAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x2B20CC0", Offset = "0x2B1FEC0", VA = "0x182B20CC0")]
	public static TErr? BNJEBNHBGEF<TErr, TOk>([In] this CIKECDEKJAI<TOk, TErr> HIKEOGPAJAF)
	{
		return (TErr?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x2B21B90", Offset = "0x2B20D90", VA = "0x182B21B90")]
	public static bool NJDLJMMPNCJ<TOk, TErr, UErr, UOk>([In] this CIKECDEKJAI<TOk, TErr> HIKEOGPAJAF, [Out] CIKECDEKJAI<UOk, UErr> ECBHJEBBCFH) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x2B21360", Offset = "0x2B20560", VA = "0x182B21360")]
	public static bool DPPIGNPMCOF<TOk, TErr>([In] this CIKECDEKJAI<TOk, TErr> HIKEOGPAJAF, [Out][NotNullWhen(true)] TOk ANPDLFAPLKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x2B23570", Offset = "0x2B22770", VA = "0x182B23570")]
	public static bool ODMHPAAHKFG<TOk, TErr>([In] this CIKECDEKJAI<TOk, TErr> HIKEOGPAJAF, [Out][NotNullWhen(true)] TErr BIALHEALFLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x2B232F0", Offset = "0x2B224F0", VA = "0x182B232F0")]
	public static bool NPIGGPFBBLE<TOk, TErr>([In] this CIKECDEKJAI<TOk, TErr> HIKEOGPAJAF, [Out][NotNullWhen(true)] TOk ANPDLFAPLKO, [Out][NotNullWhen(false)] TErr BIALHEALFLJ) where TOk : notnull where TErr : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x2B21A90", Offset = "0x2B20C90", VA = "0x182B21A90")]
	public static bool MDNNLPHAAPD<TOk, TErr>([In] this CIKECDEKJAI<TOk, TErr> HIKEOGPAJAF, [Out][NotNullWhen(true)] TOk ANPDLFAPLKO, [Out] CIKECDEKJAI<TOk, TErr> ECBHJEBBCFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x2B21CC0", Offset = "0x2B20EC0", VA = "0x182B21CC0")]
	public static bool NJDLJMMPNCJ<TOk, TErr, UErr, UOk>([In] this CIKECDEKJAI<TOk, TErr> HIKEOGPAJAF, [Out][NotNullWhen(true)] TOk ANPDLFAPLKO, [Out] CIKECDEKJAI<UOk, UErr> ECBHJEBBCFH) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x2B20FB0", Offset = "0x2B201B0", VA = "0x182B20FB0")]
	public static bool CKCDDJGGFFI<TOk, TErr>([In] this CIKECDEKJAI<TOk, TErr> HIKEOGPAJAF, [Out][NotNullWhen(true)] TOk ANPDLFAPLKO, [Out] CIKECDEKJAI<MOOMEEOMEEK, TErr> ECBHJEBBCFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x2B23880", Offset = "0x2B22A80", VA = "0x182B23880")]
	public static CIKECDEKJAI<UOk, UErr> OMMHMEKDLEJ<UOk, UErr, TOk, TErr>([In] this CIKECDEKJAI<TOk, TErr> HIKEOGPAJAF, [In] CIKECDEKJAI<UOk, UErr> LMDEKGEENAI) where TOk : UOk where TErr : UErr
	{
		return default(CIKECDEKJAI<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x2B21720", Offset = "0x2B20920", VA = "0x182B21720")]
	public static CIKECDEKJAI<TOk?[]?, TErr?> KADGGBPMBOI<TOk, TErr>(this IEnumerable<CIKECDEKJAI<TOk, TErr>> HIKEOGPAJAF)
	{
		return default(CIKECDEKJAI<TOk[], TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class NFKEGDCPPMJ<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x2BCEAD0", Offset = "0x2BCDCD0", VA = "0x182BCEAD0")]
	public static CIKECDEKJAI<TOk, T> ACEKLHKKIKP<TOk>([In] TOk ANPDLFAPLKO) where TOk : notnull
	{
		return default(CIKECDEKJAI<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x451E050", Offset = "0x451D250", VA = "0x18451E050")]
	public static CIKECDEKJAI<MOOMEEOMEEK, T> ACEKLHKKIKP()
	{
		return default(CIKECDEKJAI<MOOMEEOMEEK, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x2BCEAD0", Offset = "0x2BCDCD0", VA = "0x182BCEAD0")]
	public static CIKECDEKJAI<T, TErr> HNDFFKMDGKI<TErr>([In] TErr BIALHEALFLJ) where TErr : notnull
	{
		return default(CIKECDEKJAI<T, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[DefaultMember("Item")]
public sealed class BJBGFBMCJBH<T> : IEnumerable<T>, IEnumerable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	private readonly struct AEIKIKCLEMK : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private readonly BJBGFBMCJBH<T> LJOEBDOHFJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly int CNOBGFCKEEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private readonly bool GLJICDGDKJD;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x1EB8B80", Offset = "0x1EB7D80", VA = "0x181EB8B80")]
		public AEIKIKCLEMK(BJBGFBMCJBH<T> CIGKBEKHOLC, int FLLONKBAGBA, bool KLDADDHEDFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x3C67920", Offset = "0x3C66B20", VA = "0x183C67920")]
		public BJBGFBMCJBH<T>.BIJODDGHCLA DCPEOMEKOMK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x3C67A10", Offset = "0x3C66C10", VA = "0x183C67A10", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x3C67A10", Offset = "0x3C66C10", VA = "0x183C67A10", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public sealed class BIJODDGHCLA : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private readonly BJBGFBMCJBH<T> LJOEBDOHFJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly int OBEKAGOGIIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private int NDMIKHDBHBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly bool GLJICDGDKJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private bool ADBGOPMFBMH;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public T EBFPDFJFKPC
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x4E41350", Offset = "0x4E40550", VA = "0x184E41350")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x4E414C0", Offset = "0x4E406C0", VA = "0x184E414C0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x4E41530", Offset = "0x4E40730", VA = "0x184E41530", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x4E41AD0", Offset = "0x4E40CD0", VA = "0x184E41AD0")]
		public BIJODDGHCLA(BJBGFBMCJBH<T> CIGKBEKHOLC, int FLLONKBAGBA, bool KLDADDHEDFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x4E413D0", Offset = "0x4E405D0", VA = "0x184E413D0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x4E41460", Offset = "0x4E40660", VA = "0x184E41460", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class GBMFODKENPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public GBMFODKENPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x3CB1600", Offset = "0x3CB0800", VA = "0x183CB1600")]
		internal T GJADKLJHKOE(int _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly T[] BAPNNGNAPBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private int NDMIKHDBHBN;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int LMILKIFEDLC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x4E42E00", Offset = "0x4E42000", VA = "0x184E42E00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public T EBFPDFJFKPC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x3B79160", Offset = "0x3B78360", VA = "0x183B79160")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public T NCDLNIPPHPH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x4E42E60", Offset = "0x4E42060", VA = "0x184E42E60")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public T NBEMKGGOBKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x4E42FF0", Offset = "0x4E421F0", VA = "0x184E42FF0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public int PBLCBJADLHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x1926130", Offset = "0x1925330", VA = "0x181926130")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x1165F00", Offset = "0x1165100", VA = "0x181165F00")]
	private static int ICKPOHFJOGL(int DHNLEFJCEAH, int OMJPDIKPOLO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x4E433F0", Offset = "0x4E425F0", VA = "0x184E433F0")]
	public BJBGFBMCJBH(int ECGAAJFODGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x4E43100", Offset = "0x4E42300", VA = "0x184E43100")]
	public BJBGFBMCJBH(int ECGAAJFODGN, Func<T> PGLPKIPENLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x4E43350", Offset = "0x4E42550", VA = "0x184E43350")]
	public BJBGFBMCJBH(T[] FDPJMKODKPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x4E42DD0", Offset = "0x4E41FD0", VA = "0x184E42DD0")]
	public void GACIJHFPJBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x4E42C70", Offset = "0x4E41E70", VA = "0x184E42C70")]
	public IEnumerable<T> AOPMNJKNHGF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x4E42D30", Offset = "0x4E41F30", VA = "0x184E42D30")]
	public BJBGFBMCJBH<T>.BIJODDGHCLA DCPEOMEKOMK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x3B84560", Offset = "0x3B83760", VA = "0x183B84560", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x3B84560", Offset = "0x3B83760", VA = "0x183B84560", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class NJBPNELOIGJ
{
	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x2CA2880", Offset = "0x2CA1A80", VA = "0x182CA2880")]
	public static BJBGFBMCJBH<T> FJAAFKPDAIA<T>(int ECGAAJFODGN, Func<T> PGLPKIPENLN) where T : notnull
	{
		return null;
	}
}
namespace RecRoom.NoEngine.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public struct RRColor : IEquatable<RRColor>, IFormattable
	{
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private const float kEpsilon = 1E-05f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public float r;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public float g;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public float b;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public float a;

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x1FBED00", Offset = "0x1FBDF00", VA = "0x181FBED00")]
		public RRColor(float DLFEHJOHIIJ, float BAMOLPIILJE, float GANEOONFJPD, float MLFGLJKBOIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x69CA510", Offset = "0x69C9710", VA = "0x1869CA510", Slot = "4")]
		public bool Equals(RRColor OKGBBGMIACH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x69CA590", Offset = "0x69C9790", VA = "0x1869CA590", Slot = "0")]
		public override bool Equals(object OKGBBGMIACH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x69CA690", Offset = "0x69C9890", VA = "0x1869CA690", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x69CA710", Offset = "0x69C9910", VA = "0x1869CA710", Slot = "5")]
		public string ToString(string BGOCEECJDJL, IFormatProvider DIGMEJHHLHM)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public sealed class PMMLOFLPENC<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public readonly struct LONHFAKPBLE : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly PMMLOFLPENC<T> GACENGJCMHB;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public T JNHPIMBJPMJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x42AD570", Offset = "0x42AC770", VA = "0x1842AD570")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x42AD540", Offset = "0x42AC740", VA = "0x1842AD540", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x927530", Offset = "0x926730", VA = "0x180927530")]
		public LONHFAKPBLE(PMMLOFLPENC<T> GACENGJCMHB)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct GCLEECIEJBD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public AsyncTaskMethodBuilder<LONHFAKPBLE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public PMMLOFLPENC<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x3CB2270", Offset = "0x3CB1470", VA = "0x183CB2270", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x3CB2730", Offset = "0x3CB1930", VA = "0x183CB2730", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly SemaphoreSlim PEOGPFLIMIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private T GDBEHNBLALJ;

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x478A030", Offset = "0x4789230", VA = "0x18478A030")]
	public PMMLOFLPENC([In] T GDBEHNBLALJ, int MPBNFFENBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x4789EB0", Offset = "0x47890B0", VA = "0x184789EB0")]
	public PMMLOFLPENC([In] T GDBEHNBLALJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x47898E0", Offset = "0x4788AE0", VA = "0x1847898E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x4789DC0", Offset = "0x4788FC0", VA = "0x184789DC0")]
	public LONHFAKPBLE PIBEABAPEMI()
	{
		return default(LONHFAKPBLE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x4789CA0", Offset = "0x4788EA0", VA = "0x184789CA0")]
	[AsyncStateMachine(typeof(PMMLOFLPENC<>.GCLEECIEJBD))]
	public Task<PMMLOFLPENC<T>.LONHFAKPBLE> ODLINDLJOKA(CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x4789920", Offset = "0x4788B20", VA = "0x184789920")]
	public void KJDHHKBDEND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class JNFJDNKDKFL
{
	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x69C82D0", Offset = "0x69C74D0", VA = "0x1869C82D0")]
	public static PMMLOFLPENC<MOOMEEOMEEK> FJAAFKPDAIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x2B6E440", Offset = "0x2B6D640", VA = "0x182B6E440")]
	public static PMMLOFLPENC<T> FJAAFKPDAIA<T>([In] T GDBEHNBLALJ) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public sealed class BMDAGFILCLG<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public readonly struct HCKAEINKBBL : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly BMDAGFILCLG<T> NELKJFBGENK;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public T JNHPIMBJPMJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x3D17440", Offset = "0x3D16640", VA = "0x183D17440")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x3D170E0", Offset = "0x3D162E0", VA = "0x183D170E0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x927530", Offset = "0x926730", VA = "0x180927530")]
		internal HCKAEINKBBL(BMDAGFILCLG<T> GACENGJCMHB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public readonly struct IHOHBNDOCEO : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private readonly BMDAGFILCLG<T> NELKJFBGENK;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public T JNHPIMBJPMJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x3D17440", Offset = "0x3D16640", VA = "0x183D17440")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x3E73CD0", Offset = "0x3E72ED0", VA = "0x183E73CD0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x927530", Offset = "0x926730", VA = "0x180927530")]
		internal IHOHBNDOCEO(BMDAGFILCLG<T> GACENGJCMHB)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct MBBBCJNLELD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public AsyncTaskMethodBuilder<IHOHBNDOCEO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public BMDAGFILCLG<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private PMMLOFLPENC<MOOMEEOMEEK>.LONHFAKPBLE <writeLock>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private TaskAwaiter<PMMLOFLPENC<MOOMEEOMEEK>.LONHFAKPBLE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x447D010", Offset = "0x447C210", VA = "0x18447D010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x3CB2730", Offset = "0x3CB1930", VA = "0x183CB2730", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly PMMLOFLPENC<int> CJIHNCJMGFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly PMMLOFLPENC<MOOMEEOMEEK> PEIJIIBANCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly PMMLOFLPENC<MOOMEEOMEEK> JNPAMDKNFOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private T OBAIELFNFBN;

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x4E7A330", Offset = "0x4E79530", VA = "0x184E7A330")]
	internal BMDAGFILCLG(PMMLOFLPENC<int> ODPJHCMIMLF, PMMLOFLPENC<MOOMEEOMEEK> JCAFDJJNEKJ, PMMLOFLPENC<MOOMEEOMEEK> COLMIGGKIOD, [In] T GDBEHNBLALJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x4E79F60", Offset = "0x4E79160", VA = "0x184E79F60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x4E799C0", Offset = "0x4E78BC0", VA = "0x184E799C0")]
	public HCKAEINKBBL CLAPPBNJGGL()
	{
		return default(HCKAEINKBBL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x4E7A240", Offset = "0x4E79440", VA = "0x184E7A240")]
	public IHOHBNDOCEO HHIFNKNGNCI()
	{
		return default(IHOHBNDOCEO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x4E79CA0", Offset = "0x4E78EA0", VA = "0x184E79CA0")]
	[AsyncStateMachine(typeof(BMDAGFILCLG<>.MBBBCJNLELD))]
	public Task<BMDAGFILCLG<T>.IHOHBNDOCEO> DDNIPANBGIG(CancellationToken MPLGBOFHPLM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public static class MBJOKOMBGHI
{
	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x69C8810", Offset = "0x69C7A10", VA = "0x1869C8810")]
	public static BMDAGFILCLG<MOOMEEOMEEK> FJAAFKPDAIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x2C2BDB0", Offset = "0x2C2AFB0", VA = "0x182C2BDB0")]
	public static BMDAGFILCLG<T> FJAAFKPDAIA<T>([In] T GDBEHNBLALJ) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public sealed class GAHFFFJJFCN<TData> : EGADAFAJMEN where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly string GKHLDHJLOCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly TData CPPCAMCFLFP;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851B00", VA = "0x180852900", Slot = "7")]
	public override string AGNLMABPEGN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x3CAA5A0", Offset = "0x3CA97A0", VA = "0x183CAA5A0")]
	internal GAHFFFJJFCN(string JNNDBFGKHHD, [In] TData LINJEFIAFHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class DDAFJBKNENI
{
	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x69C6370", Offset = "0x69C5570", VA = "0x1869C6370")]
	public static GAHFFFJJFCN<MOOMEEOMEEK> FJAAFKPDAIA(string JNNDBFGKHHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x28D5900", Offset = "0x28D4B00", VA = "0x1828D5900")]
	public static GAHFFFJJFCN<TData> FJAAFKPDAIA<TData>(string JNNDBFGKHHD, [In] TData LINJEFIAFHO) where TData : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class JKABPFHFGAE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly Dictionary<object, float> ENCKOMKBEOC;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public float MIDLJCFKIHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x8BE910", Offset = "0x8BDB10", VA = "0x1808BE910")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0xECDA60", Offset = "0xECCC60", VA = "0x180ECDA60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x69C8160", Offset = "0x69C7360", VA = "0x1869C8160")]
	public void MBCOGGKHPPK(float JMDCGOKJIDA, object EOCJCEFCOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x69C81D0", Offset = "0x69C73D0", VA = "0x1869C81D0")]
	public void NOOCMPIIMHF(object EOCJCEFCOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x69C8110", Offset = "0x69C7310", VA = "0x1869C8110")]
	public void IMJJLGNDCEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x69C7FE0", Offset = "0x69C71E0", VA = "0x1869C7FE0")]
	private void AKFAJJAJDGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x69C8240", Offset = "0x69C7440", VA = "0x1869C8240")]
	public JKABPFHFGAE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public sealed class AEDIPGNMMIK<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class JCECEGGGKII
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public JCECEGGGKII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x409BB50", Offset = "0x409AD50", VA = "0x18409BB50")]
		internal int LLEKFAPCDJC(int i, T token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private HashSet<T>? IONCGEODICG;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public IReadOnlyCollection<T> PADGCFOCIOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x3C67080", Offset = "0x3C66280", VA = "0x183C67080")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool FBEJJFNJIMN
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x3C67110", Offset = "0x3C66310", VA = "0x183C67110")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public int MELIDLJEANB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x85FD10", Offset = "0x85EF10", VA = "0x18085FD10")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x860F50", Offset = "0x860150", VA = "0x180860F50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x3C67390", Offset = "0x3C66590", VA = "0x183C67390")]
	public bool PBLNBBGFGAP(T EOCJCEFCOOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x3C67220", Offset = "0x3C66420", VA = "0x183C67220")]
	public bool MFKDEBIIBOM(T EOCJCEFCOOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x3C670C0", Offset = "0x3C662C0", VA = "0x183C670C0")]
	public bool DJONJHALGBO(T EOCJCEFCOOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x3C67150", Offset = "0x3C66350", VA = "0x183C67150")]
	public void KJPNELFGJOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x3C67550", Offset = "0x3C66750", VA = "0x183C67550", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
	public AEDIPGNMMIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class NKPKPHIMNEI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly string OKOMKPFKBCE;

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x8531E0", Offset = "0x8523E0", VA = "0x1808531E0")]
	public NKPKPHIMNEI(string OKOMKPFKBCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x69C8FB0", Offset = "0x69C81B0", VA = "0x1869C8FB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public sealed class MJPOGCFKFFN
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class PLFAAGOIDND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public PLFAAGOIDND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x69CA460", Offset = "0x69C9660", VA = "0x1869CA460")]
		internal int LLEKFAPCDJC(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private HashSet<object>? IONCGEODICG;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public IReadOnlyCollection<object> PADGCFOCIOL
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x69C88E0", Offset = "0x69C7AE0", VA = "0x1869C88E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool FBEJJFNJIMN
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x69C89D0", Offset = "0x69C7BD0", VA = "0x1869C89D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int MELIDLJEANB
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x85FD10", Offset = "0x85EF10", VA = "0x18085FD10")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x860F50", Offset = "0x860150", VA = "0x180860F50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x69C8AF0", Offset = "0x69C7CF0", VA = "0x1869C8AF0")]
	public bool PBLNBBGFGAP(object EOCJCEFCOOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x69C8A50", Offset = "0x69C7C50", VA = "0x1869C8A50")]
	public bool MFKDEBIIBOM(object EOCJCEFCOOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x69C8970", Offset = "0x69C7B70", VA = "0x1869C8970")]
	public bool DJONJHALGBO(object EOCJCEFCOOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x69C89E0", Offset = "0x69C7BE0", VA = "0x1869C89E0")]
	public void KJPNELFGJOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x69C8BD0", Offset = "0x69C7DD0", VA = "0x1869C8BD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
	public MJPOGCFKFFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class BDHOMIPIJNO<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	private struct LMEEGMBBICK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public float MOEHEJACJEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public T JNHPIMBJPMJ;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly Dictionary<object, LMEEGMBBICK> ENCKOMKBEOC;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public virtual T OGICGDCLDFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x1073010", Offset = "0x1072210", VA = "0x181073010", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x10725F0", Offset = "0x10717F0", VA = "0x1810725F0", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public object? PHDBNNKJBKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x856BC0", Offset = "0x855DC0", VA = "0x180856BC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x85B4C0", Offset = "0x85A6C0", VA = "0x18085B4C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool BFKHAPKIPIG
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x4E15490", Offset = "0x4E14690", VA = "0x184E15490")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x4E154F0", Offset = "0x4E146F0", VA = "0x184E154F0")]
	public bool MBCOGGKHPPK(T JMDCGOKJIDA, object EOCJCEFCOOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x44A31F0", Offset = "0x44A23F0", VA = "0x1844A31F0")]
	public bool NOOCMPIIMHF(object EOCJCEFCOOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x37F08B0", Offset = "0x37EFAB0", VA = "0x1837F08B0")]
	public void IMJJLGNDCEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x4E13BB0", Offset = "0x4E12DB0", VA = "0x184E13BB0")]
	public bool AKPHPFIGELN(object EOCJCEFCOOA, [Out] T JMDCGOKJIDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x4E14A20", Offset = "0x4E13C20", VA = "0x184E14A20")]
	[PEHALAEOKAF("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool BCHEJMABEAA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x44A3290", Offset = "0x44A2490", VA = "0x1844A3290")]
	public BDHOMIPIJNO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public sealed class MLLDOOHJPFF<T> where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private List<WeakReference<T>>? IONCGEODICG;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool FBEJJFNJIMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x44BCD40", Offset = "0x44BBF40", VA = "0x1844BCD40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int MELIDLJEANB
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x44BD040", Offset = "0x44BC240", VA = "0x1844BD040")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x44BD1E0", Offset = "0x44BC3E0", VA = "0x1844BD1E0")]
	public void PBLNBBGFGAP(T EOCJCEFCOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x44BCEB0", Offset = "0x44BC0B0", VA = "0x1844BCEB0")]
	public void MFKDEBIIBOM(T EOCJCEFCOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x44BCE70", Offset = "0x44BC070", VA = "0x1844BCE70")]
	public void KJPNELFGJOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x44BD450", Offset = "0x44BC650", VA = "0x1844BD450", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
	public MLLDOOHJPFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
internal static class CEJKDFALNHD
{
	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x293C7A0", Offset = "0x293B9A0", VA = "0x18293C7A0")]
	public static void MNACKLLGDEF<T>(this List<T> CGIFJALMJMI, int DHNLEFJCEAH) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface AICOLMPJDDO
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event KPJCHGMHNOH ODCPIOEPMDN;
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class NPFIODHPLCC : AICOLMPJDDO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public readonly struct ECBAIFDOJGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public readonly float PGKLFDNLGPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public readonly float JDLJCBHINAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		internal readonly bool OONANGMADII;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public float LIFKLMGEOHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x69C63F0", Offset = "0x69C55F0", VA = "0x1869C63F0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x69C6570", Offset = "0x69C5770", VA = "0x1869C6570")]
		public ECBAIFDOJGP(float GBALKPFEDAI, float DAOCGKJPECC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x69C6400", Offset = "0x69C5600", VA = "0x1869C6400", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private sealed class ECCJGCFIAMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public NPFIODHPLCC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public ECCJGCFIAMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x69C66D0", Offset = "0x69C58D0", VA = "0x1869C66D0")]
		internal void DPNBHEIPFHA(float innerProgress)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly int HHGNDILCLEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private int BHICNKPLPLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly AICOLMPJDDO[] EIGGDAEBJJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly KPJCHGMHNOH[] EKMGPIDNBAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly ECBAIFDOJGP[] AFPAGHEAJFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private ECBAIFDOJGP NJAKDJEANGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly NKKKGGINLEP BIJPCMFNOOK;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event KPJCHGMHNOH ODCPIOEPMDN
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x69C95A0", Offset = "0x69C87A0", VA = "0x1869C95A0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x69C94E0", Offset = "0x69C86E0", VA = "0x1869C94E0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x69C9800", Offset = "0x69C8A00", VA = "0x1869C9800")]
	public NPFIODHPLCC(int HHGNDILCLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x69C9770", Offset = "0x69C8970", VA = "0x1869C9770")]
	public NKKKGGINLEP OBDBJJNBNHF(ECBAIFDOJGP NHEIBBJGGFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x69C9060", Offset = "0x69C8260", VA = "0x1869C9060")]
	public void AFBGBKGKPHH(AICOLMPJDDO FMNGMAHNJCI, [Optional] ECBAIFDOJGP DHFHKLCGEPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x69C9660", Offset = "0x69C8860", VA = "0x1869C9660", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public delegate void KPJCHGMHNOH(float BLKMGGOFGAD);
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class JGBNFJDMCPK
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class ELIJMGPKDBL : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private readonly AICOLMPJDDO PIPDFIMKOBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly KPJCHGMHNOH HBBMMHKOEKK;

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x69C71F0", Offset = "0x69C63F0", VA = "0x1869C71F0")]
		public ELIJMGPKDBL(AICOLMPJDDO PIPDFIMKOBC, KPJCHGMHNOH HBBMMHKOEKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x69C71A0", Offset = "0x69C63A0", VA = "0x1869C71A0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x69C7F70", Offset = "0x69C7170", VA = "0x1869C7F70")]
	internal static bool JLCEOLFHAMG(float MLFGLJKBOIG, float GANEOONFJPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x69B8D40", Offset = "0x69B7F40", VA = "0x1869B8D40")]
	internal static float BKDOBEFLFEJ(float MLFGLJKBOIG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x69C7EB0", Offset = "0x69C70B0", VA = "0x1869C7EB0")]
	public static IDisposable DEIKNKGANCD(this AICOLMPJDDO PIPDFIMKOBC, KPJCHGMHNOH HBBMMHKOEKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class NKKKGGINLEP : AICOLMPJDDO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private float BLKMGGOFGAD;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public float COLBJJDLGMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x69C8D80", Offset = "0x69C7F80", VA = "0x1869C8D80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event KPJCHGMHNOH? ODCPIOEPMDN
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x69C8F10", Offset = "0x69C8110", VA = "0x1869C8F10", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x69C8E70", Offset = "0x69C8070", VA = "0x1869C8E70", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
	public NKKKGGINLEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface EPPJMDDOJMI<T> where T : class, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GMNMJHGHIHD<T> MCBLJONGBGM([Out] T JMDCGOKJIDA);

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IMJJLGNDCEN();
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class NAJHBLNFFCA<T> : EPPJMDDOJMI<T> where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly ConcurrentStack<T> KCGOCHLMLJL;

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x450B610", Offset = "0x450A810", VA = "0x18450B610", Slot = "4")]
	public GMNMJHGHIHD<T> MCBLJONGBGM([Out] T JMDCGOKJIDA)
	{
		return default(GMNMJHGHIHD<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x450B6B0", Offset = "0x450A8B0", VA = "0x18450B6B0")]
	public void NLCHOINDCPP(T DBGJCBLNMLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x3CD0F40", Offset = "0x3CD0140", VA = "0x183CD0F40", Slot = "5")]
	public void IMJJLGNDCEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290", Slot = "6")]
	protected virtual void EHGNCICKNOA(T MCGIAAMHBOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x450B560", Offset = "0x450A760", VA = "0x18450B560")]
	private T JMJOGDIBBHK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x450B730", Offset = "0x450A930", VA = "0x18450B730")]
	public NAJHBLNFFCA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public readonly struct GMNMJHGHIHD<T> : IDisposable where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly T DBGJCBLNMLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly NAJHBLNFFCA<T> JOPKJIBCCEE;

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0xAB26B0", Offset = "0xAB18B0", VA = "0x180AB26B0")]
	internal GMNMJHGHIHD(T JMDCGOKJIDA, NAJHBLNFFCA<T> JOPKJIBCCEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x3CDC470", Offset = "0x3CDB670", VA = "0x183CDC470", Slot = "4")]
	void IDisposable.Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class PDPKGOLFIGL : NAJHBLNFFCA<StringBuilder>
{
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public static readonly PDPKGOLFIGL MJFJCBEEADM;

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x69CA2E0", Offset = "0x69C94E0", VA = "0x1869CA2E0")]
	public static GMNMJHGHIHD<StringBuilder> JMJOGDIBBHK([Out] StringBuilder JMDCGOKJIDA)
	{
		return default(GMNMJHGHIHD<StringBuilder>);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x69CA2C0", Offset = "0x69C94C0", VA = "0x1869CA2C0", Slot = "6")]
	protected override void EHGNCICKNOA(StringBuilder MCGIAAMHBOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x69CA420", Offset = "0x69C9620", VA = "0x1869CA420")]
	public PDPKGOLFIGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class PNJOODKNOEI : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x642FC50", Offset = "0x642EE50", VA = "0x18642FC50")]
	public PNJOODKNOEI(string JNNDBFGKHHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[DefaultMember("Item")]
public class LEGEPBHINPE<TKey, TValue> : NKDCFEEBFKH<TKey, TValue>, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, HDHCDHAFCCA where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class FMONEAPICLD : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private KeyValuePair<TKey, TValue> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public LEGEPBHINPE<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private IEnumerator<KeyValuePair<TKey, TValue>> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		KeyValuePair<TKey, TValue> IEnumerator<KeyValuePair<TKey, TValue>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x1073010", Offset = "0x1072210", VA = "0x181073010", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TValue>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x3C14E40", Offset = "0x3C14040", VA = "0x183C14E40", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x85C1D0", Offset = "0x85B3D0", VA = "0x18085C1D0")]
		[DebuggerHidden]
		public FMONEAPICLD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x3991FB0", Offset = "0x39911B0", VA = "0x183991FB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x3C14210", Offset = "0x3C13410", VA = "0x183C14210", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x3C140D0", Offset = "0x3C132D0", VA = "0x183C140D0")]
		private void CEOBCCLIKJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x3C141C0", Offset = "0x3C133C0", VA = "0x183C141C0")]
		private void KNPOGHPBEEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x3C14DF0", Offset = "0x3C13FF0", VA = "0x183C14DF0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private readonly NKDCFEEBFKH<TKey, TValue> DEJAOKJBLGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly IDictionary<TKey, TValue> OAMAPMCJJKG;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public int MELIDLJEANB
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x42440D0", Offset = "0x42432D0", VA = "0x1842440D0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool HNPAFAKBDHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x89B030", Offset = "0x89A230", VA = "0x18089B030", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public TValue NBEMKGGOBKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x42441A0", Offset = "0x42433A0", VA = "0x1842441A0", Slot = "4")]
		get
		{
			return (TValue)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x4244490", Offset = "0x4243690", VA = "0x184244490", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public ICollection<TKey> FBJILCMLFAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x4244230", Offset = "0x4243430", VA = "0x184244230", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public ICollection<TValue> PGIKKFOHHOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x4244340", Offset = "0x4243540", VA = "0x184244340", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x4243F40", Offset = "0x4243140", VA = "0x184243F40")]
	public LEGEPBHINPE(NKDCFEEBFKH<TKey, TValue> DEJAOKJBLGD, [Optional] IDictionary<TKey, TValue>? OAMAPMCJJKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x4241C10", Offset = "0x4240E10", VA = "0x184241C10", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x4242290", Offset = "0x4241490", VA = "0x184242290")]
	public void FLMDPFEEJKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x42418A0", Offset = "0x4240AA0", VA = "0x1842418A0", Slot = "9")]
	public void Add(TKey NDDCLPHCEEO, TValue JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x4242510", Offset = "0x4241710", VA = "0x184242510")]
	public void HAHBCCHIPOB(TKey NDDCLPHCEEO, TValue JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x4242890", Offset = "0x4241A90", VA = "0x184242890")]
	public void HOLOFOIHPNP(TKey NDDCLPHCEEO, TValue JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x4242B60", Offset = "0x4241D60", VA = "0x184242B60")]
	public void JIDMKBBBJAG(TKey NDDCLPHCEEO, TValue JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x4242F50", Offset = "0x4242150", VA = "0x184242F50")]
	public void NCKAFCGIAEI(TKey NDDCLPHCEEO, TValue JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x4243570", Offset = "0x4242770", VA = "0x184243570", Slot = "14")]
	void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> JNHGHHKKNBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x4243610", Offset = "0x4242810", VA = "0x184243610", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> JNHGHHKKNBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x4243970", Offset = "0x4242B70", VA = "0x184243970", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> JNHGHHKKNBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x4241CA0", Offset = "0x4240EA0", VA = "0x184241CA0", Slot = "8")]
	public bool ContainsKey(TKey NDDCLPHCEEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x4242E90", Offset = "0x4242090", VA = "0x184242E90")]
	public bool JOCPMELEDOB(TKey NDDCLPHCEEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x4242700", Offset = "0x4241900", VA = "0x184242700")]
	public bool HEICINABDBH(TKey NDDCLPHCEEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x42433D0", Offset = "0x42425D0", VA = "0x1842433D0", Slot = "10")]
	public bool Remove(TKey NDDCLPHCEEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x4243CD0", Offset = "0x4242ED0", VA = "0x184243CD0", Slot = "11")]
	public bool TryGetValue(TKey NDDCLPHCEEO, [Out] TValue JMDCGOKJIDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x4241E10", Offset = "0x4241010", VA = "0x184241E10", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TValue>[] PFKJAOOHGBN, int OMHDEOJLLBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x414E310", Offset = "0x414D510", VA = "0x18414E310", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x4242390", Offset = "0x4241590", VA = "0x184242390", Slot = "19")]
	[IteratorStateMachine(typeof(LEGEPBHINPE<, >.FMONEAPICLD))]
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x4242DE0", Offset = "0x4241FE0", VA = "0x184242DE0", Slot = "21")]
	public bool JMLDPKCDHNJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x4243210", Offset = "0x4242410", VA = "0x184243210")]
	private TValue PCJFBKGIMPL(TKey NDDCLPHCEEO)
	{
		return (TValue)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public interface HDHCDHAFCCA
{
	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JMLDPKCDHNJ();
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface NKDCFEEBFKH<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, HDHCDHAFCCA
{
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[DefaultMember("Item")]
public sealed class LKJHFGDNFFP<TKey, TVal> : NKDCFEEBFKH<TKey, TVal>, IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, HDHCDHAFCCA where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public delegate int DMEMAHLHJCO(TKey NDDCLPHCEEO, TVal JMDCGOKJIDA);

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public delegate void KFPHOPMGLCO(TKey NDDCLPHCEEO, TVal JMDCGOKJIDA, JAEDDHFIPOE NPGFMGMHJJL);

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	private class AJPPGHNDOJF
	{
		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public TKey HJDGBLHMFIH
		{
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x8C9BF0", Offset = "0x8C8DF0", VA = "0x1808C9BF0")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public TVal JNHPIMBJPMJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x8CD9B0", Offset = "0x8CCBB0", VA = "0x1808CD9B0")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x8CD840", Offset = "0x8CCA40", VA = "0x1808CD840")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public int LIFKLMGEOHM
		{
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x891DC0", Offset = "0x890FC0", VA = "0x180891DC0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x8913C0", Offset = "0x8905C0", VA = "0x1808913C0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public DateTimeOffset IGBDCDHLLLC
		{
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0xC36B50", Offset = "0xC35D50", VA = "0x180C36B50")]
			[CompilerGenerated]
			get
			{
				return default(DateTimeOffset);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x1500960", Offset = "0x14FFB60", VA = "0x181500960")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x3C8F600", Offset = "0x3C8E800", VA = "0x183C8F600")]
		public AJPPGHNDOJF(TKey NDDCLPHCEEO, TVal GPBAFILNEOM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class NBBKFPMBLHI : IEnumerator<KeyValuePair<TKey, TVal>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private KeyValuePair<TKey, TVal> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public LKJHFGDNFFP<TKey, TVal> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private LinkedList<AJPPGHNDOJF>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		KeyValuePair<TKey, TVal> IEnumerator<KeyValuePair<TKey, TVal>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x1073010", Offset = "0x1072210", VA = "0x181073010", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TVal>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x3AE73F0", Offset = "0x3AE65F0", VA = "0x183AE73F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x85C1D0", Offset = "0x85B3D0", VA = "0x18085C1D0")]
		[DebuggerHidden]
		public NBBKFPMBLHI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x398CD50", Offset = "0x398BF50", VA = "0x18398CD50", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x450D590", Offset = "0x450C790", VA = "0x18450D590", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x450B900", Offset = "0x450AB00", VA = "0x18450B900")]
		private void CEOBCCLIKJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x450E370", Offset = "0x450D570", VA = "0x18450E370", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public const int NPDDOEBKGJF = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly Dictionary<TKey, LinkedListNode<AJPPGHNDOJF>> GOLICPFOJMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly LinkedList<AJPPGHNDOJF> PNIINJGHECK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly DMEMAHLHJCO? NLFLNFMHLBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly TimeSpan OKBGHIHICMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly KFPHOPMGLCO? DKBFFBLIJNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly FFIMJELAHLM BKIGEIKCIDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private bool KCHBKOJDFHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly List<TKey> EJHCELLAGCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly List<TVal> DPDOFFDPNCI;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int DBFNDBELIMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x8626D0", Offset = "0x8618D0", VA = "0x1808626D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	internal int LMCNBEECMEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0xB01480", Offset = "0xB00680", VA = "0x180B01480")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0xB00BA0", Offset = "0xAFFDA0", VA = "0x180B00BA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public int MELIDLJEANB
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x4285260", Offset = "0x4284460", VA = "0x184285260", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	internal int CGGDCHOJAEP
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x37F08B0", Offset = "0x37EFAB0", VA = "0x1837F08B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public ICollection<TVal> PGIKKFOHHOG
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x42853A0", Offset = "0x42845A0", VA = "0x1842853A0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	ICollection<TKey> IDictionary<TKey, TVal>.GJOLFMICFDB
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x4283B40", Offset = "0x4282D40", VA = "0x184283B40", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool HNPAFAKBDHK
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x89B030", Offset = "0x89A230", VA = "0x18089B030", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public TVal NBEMKGGOBKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x42852F0", Offset = "0x42844F0", VA = "0x1842852F0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x42853E0", Offset = "0x42845E0", VA = "0x1842853E0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x4280C70", Offset = "0x427FE70", VA = "0x184280C70")]
	private bool JAAPFGKMMDO(int HHGNDILCLEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x427EA70", Offset = "0x427DC70", VA = "0x18427EA70")]
	private void DPCEDDJNEHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x42847E0", Offset = "0x42839E0", VA = "0x1842847E0")]
	public LKJHFGDNFFP(int HHGNDILCLEE, [Optional] DMEMAHLHJCO? NLFLNFMHLBJ, [Optional] IEqualityComparer<TKey>? PMELJJPGANC, [Optional] KFPHOPMGLCO? DKBFFBLIJNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x42841C0", Offset = "0x42833C0", VA = "0x1842841C0")]
	public LKJHFGDNFFP(TimeSpan OKBGHIHICMC, [Optional] IEqualityComparer<TKey>? PMELJJPGANC, [Optional] KFPHOPMGLCO? DKBFFBLIJNO, [Optional] FFIMJELAHLM? BKIGEIKCIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x4284770", Offset = "0x4283970", VA = "0x184284770")]
	public LKJHFGDNFFP(int HHGNDILCLEE, TimeSpan OKBGHIHICMC, [Optional] IEqualityComparer<TKey>? PMELJJPGANC, [Optional] KFPHOPMGLCO? DKBFFBLIJNO, [Optional] FFIMJELAHLM? BKIGEIKCIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x4284D20", Offset = "0x4283F20", VA = "0x184284D20")]
	public LKJHFGDNFFP(int HHGNDILCLEE, DMEMAHLHJCO? NLFLNFMHLBJ, TimeSpan OKBGHIHICMC, [Optional] IEqualityComparer<TKey>? PMELJJPGANC, [Optional] KFPHOPMGLCO? DKBFFBLIJNO, [Optional] FFIMJELAHLM? BKIGEIKCIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x42824B0", Offset = "0x42816B0", VA = "0x1842824B0", Slot = "21")]
	public bool JMLDPKCDHNJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x4280B10", Offset = "0x427FD10", VA = "0x184280B10", Slot = "22")]
	public bool IJLBDKMCICC(int ECGAAJFODGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x427F860", Offset = "0x427EA60", VA = "0x18427F860")]
	private bool IBFMCOCMGOF(int ECGAAJFODGN, JAEDDHFIPOE NPGFMGMHJJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x4283090", Offset = "0x4282290", VA = "0x184283090")]
	public void OLOHHMDPKEO(TKey NDDCLPHCEEO, TVal JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x427CEF0", Offset = "0x427C0F0", VA = "0x18427CEF0", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> JNHGHHKKNBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x427D0C0", Offset = "0x427C2C0", VA = "0x18427D0C0", Slot = "9")]
	public void Add(TKey NDDCLPHCEEO, TVal JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x427DB30", Offset = "0x427CD30", VA = "0x18427DB30", Slot = "8")]
	public bool ContainsKey(TKey NDDCLPHCEEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x4283610", Offset = "0x4282810", VA = "0x184283610", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Contains(KeyValuePair<TKey, TVal> JNHGHHKKNBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x4283410", Offset = "0x4282610", VA = "0x184283410", Slot = "10")]
	public bool Remove(TKey NDDCLPHCEEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x4283A00", Offset = "0x4282C00", VA = "0x184283A00", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Remove(KeyValuePair<TKey, TVal> JNHGHHKKNBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x427F470", Offset = "0x427E670", VA = "0x18427F470")]
	private bool FIHONAPKJEP(TKey NDDCLPHCEEO, [Out] TVal JMDCGOKJIDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x42822B0", Offset = "0x42814B0", VA = "0x1842822B0")]
	private TVal JMJOGDIBBHK(TKey LEPFMLOCOKH)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x4283FD0", Offset = "0x42831D0", VA = "0x184283FD0", Slot = "11")]
	public bool TryGetValue(TKey LEPFMLOCOKH, [Out] TVal JMDCGOKJIDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x427DA10", Offset = "0x427CC10", VA = "0x18427DA10", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x427E340", Offset = "0x427D540", VA = "0x18427E340", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] PFKJAOOHGBN, int OMHDEOJLLBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x427E6A0", Offset = "0x427D8A0", VA = "0x18427E6A0")]
	private void DJLDEBECLKL(TKey NDDCLPHCEEO, TVal GPBAFILNEOM, JAEDDHFIPOE NPGFMGMHJJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x4280E40", Offset = "0x4280040", VA = "0x184280E40")]
	private bool JHIFPHEPNGG(AJPPGHNDOJF NMLMGAHKIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x4281C30", Offset = "0x4280E30", VA = "0x184281C30")]
	private void JLBAEEEHCMK(LinkedListNode<AJPPGHNDOJF> MPCILHEMBHP, TVal BOKHJAMHCIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x4282C00", Offset = "0x4281E00", VA = "0x184282C00")]
	private void MBCOGGKHPPK(TKey NDDCLPHCEEO, TVal JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x427D3E0", Offset = "0x427C5E0", VA = "0x18427D3E0")]
	private void COHOGNOBIJP(AJPPGHNDOJF NMLMGAHKIJF, TVal BOKHJAMHCIH, int OBMECBFGAAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x427F700", Offset = "0x427E900", VA = "0x18427F700", Slot = "19")]
	[IteratorStateMachine(typeof(LKJHFGDNFFP<, >.NBBKFPMBLHI))]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x4283B80", Offset = "0x4282D80", VA = "0x184283B80", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public enum JAEDDHFIPOE : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	Evicted,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	RemovedViaRemove,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	RemovedViaClear,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	Overwritten
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class ECICHACFBLB<TKey> : Exception where TKey : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public readonly TKey LPKNFENDJDB;

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x37E7DC0", Offset = "0x37E6FC0", VA = "0x1837E7DC0")]
	public ECICHACFBLB(TKey BAIMBONOPGC, Exception OKPGFIEKFIO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class IJJCLDKMOFD : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x5D04C60", Offset = "0x5D03E60", VA = "0x185D04C60")]
	public IJJCLDKMOFD(string JNNDBFGKHHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class FILEOJEALJN<TId, TResource> : IEnumerable<(TId, Task<TResource>, int)>, IEnumerable where TId : notnull where TResource : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class IHBCNHBCEIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public Func<TId, CancellationToken, Task<TResource>> factory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public FILEOJEALJN<TId, TResource> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public IHBCNHBCEIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x3E6ED80", Offset = "0x3E6DF80", VA = "0x183E6ED80")]
		internal Task<TResource> AAANIEIMFFD(TId _id)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private struct IKMNIBOJEML : IAsyncStateMachine
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
		public FILEOJEALJN<TId, TResource> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x3ED8BB0", Offset = "0x3ED7DB0", VA = "0x183ED8BB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x3ED9850", Offset = "0x3ED8A50", VA = "0x183ED9850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private struct CGBHCKGFPGK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public Dictionary<Task<TResource>, CancellationTokenSource> cancellationTokenSources;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public CancellationTokenSource cts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x510B4D0", Offset = "0x510A6D0", VA = "0x18510B4D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x510B8B0", Offset = "0x510AAB0", VA = "0x18510B8B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly IDJKEBEHJMM<TId, Task<TResource>> BOFMGHJHDBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly Dictionary<Task<TResource>, CancellationTokenSource> DIBHCMBAAJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly Func<TId, CancellationToken, Task<TResource>>? PEGKLFHADPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly Action<TResource>? NIIBEHDFMDD;

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x3BF22B0", Offset = "0x3BF14B0", VA = "0x183BF22B0")]
	public FILEOJEALJN(int AHECCPJHEFF = 0, [Optional] IEqualityComparer<TId>? HBCNIFLBHJC, [Optional] Func<TId, CancellationToken, Task<TResource>>? FLPMJCBHCGB, [Optional] Action<TResource>? ANFANOINHMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x3BF0DB0", Offset = "0x3BEFFB0", VA = "0x183BF0DB0")]
	public PIKIJNPLMPM<Task<TResource>> DIKBKFOJHON(TId DKFNFHGODON, [Optional] Func<TId, CancellationToken, Task<TResource>>? FLPMJCBHCGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x3BF1A80", Offset = "0x3BF0C80", VA = "0x183BF1A80")]
	private void GLGFOCIIMBB(Task<TResource> LEDCCMOCHJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x3BF1FC0", Offset = "0x3BF11C0", VA = "0x183BF1FC0")]
	[AsyncStateMachine(typeof(FILEOJEALJN<, >.IKMNIBOJEML))]
	private Task NABHHEPILNL(Task<TResource> LEDCCMOCHJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x3BF17E0", Offset = "0x3BF09E0", VA = "0x183BF17E0")]
	public void FIKAFFKAEHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x3BF0A50", Offset = "0x3BEFC50", VA = "0x183BF0A50")]
	public IDJKEBEHJMM<TId, Task<TResource>>.JIHOPMBIOGC DCPEOMEKOMK()
	{
		return default(IDJKEBEHJMM<TId, Task<TResource>>.JIHOPMBIOGC);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x3BF2210", Offset = "0x3BF1410", VA = "0x183BF2210", Slot = "4")]
	private IEnumerator<(TId, Task<TResource>, int)> System.Collections.Generic.IEnumerable<(TIdId,System.Threading.Tasks.Task<TResource>LoadResourceTask,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x3BF2210", Offset = "0x3BF1410", VA = "0x183BF2210", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x3BF1580", Offset = "0x3BF0780", VA = "0x183BF1580")]
	[AsyncStateMachine(typeof(FILEOJEALJN<, >.CGBHCKGFPGK))]
	[CompilerGenerated]
	internal static Task ENIOFPBIAOF(Task<TResource> LEDCCMOCHJB, CancellationTokenSource DHOJDEAEIKA, Dictionary<Task<TResource>, CancellationTokenSource> NJAEHHDPBFO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class IDJKEBEHJMM<TKey, TValue> : IEnumerable<(TKey, TValue, int)>, IEnumerable where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	private sealed class MINDGGBPNHG : IEquatable<MINDGGBPNHG>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public readonly TValue JNHPIMBJPMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public int LFIOCCDCBAL;

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x953650", Offset = "0x952850", VA = "0x180953650")]
		public MINDGGBPNHG(TValue JMDCGOKJIDA, int ELDDLGIECEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x44AB470", Offset = "0x44AA670", VA = "0x1844AB470", Slot = "4")]
		public bool Equals(MINDGGBPNHG? OKGBBGMIACH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x44AB500", Offset = "0x44AA700", VA = "0x1844AB500", Slot = "0")]
		public override bool Equals(object? MEAFIMADMKA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x44AB750", Offset = "0x44AA950", VA = "0x1844AB750", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct JIHOPMBIOGC : IEnumerator<(TKey, TValue, int)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private Dictionary<TKey, MINDGGBPNHG>.Enumerator IBPIPGILMJG;

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x40B43C0", Offset = "0x40B35C0", VA = "0x1840B43C0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public (TKey Key, TValue Value, int RefCount) EBFPDFJFKPC
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x40B4780", Offset = "0x40B3980", VA = "0x1840B4780", Slot = "4")]
			get
			{
				return default((TKey, TValue, int));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x40B4510", Offset = "0x40B3710", VA = "0x1840B4510")]
		public JIHOPMBIOGC(IDJKEBEHJMM<TKey, TValue> ENCKOMKBEOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x40B3F80", Offset = "0x40B3180", VA = "0x1840B3F80", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x40B3FC0", Offset = "0x40B31C0", VA = "0x1840B3FC0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x40B4130", Offset = "0x40B3330", VA = "0x1840B4130", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class LBKLPINBCNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public IDJKEBEHJMM<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public TKey key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public MINDGGBPNHG refCountedValue;

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public LBKLPINBCNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x423C310", Offset = "0x423B510", VA = "0x18423C310")]
		internal void AAANIEIMFFD()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly Dictionary<TKey, MINDGGBPNHG> JNNDPPOEGHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly Func<TKey, TValue>? IPKHKCLLOBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly Action<TValue>? PBIIFHPNLNN;

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x3E40970", Offset = "0x3E3FB70", VA = "0x183E40970")]
	public IDJKEBEHJMM(int AHECCPJHEFF = 0, [Optional] IEqualityComparer<TKey>? PMELJJPGANC, [Optional] Func<TKey, TValue>? FLCCMAPPPLL, [Optional] Action<TValue>? PGMJHFAHFOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x3E3F4B0", Offset = "0x3E3E6B0", VA = "0x183E3F4B0")]
	public PIKIJNPLMPM<TValue> DIKBKFOJHON(TKey NDDCLPHCEEO, [Optional] Func<TKey, TValue>? DCGAOGMNBFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x3E40400", Offset = "0x3E3F600", VA = "0x183E40400")]
	private void NLCHOINDCPP(TKey NDDCLPHCEEO, MINDGGBPNHG IFHELEFLFHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x3E3FDC0", Offset = "0x3E3EFC0", VA = "0x183E3FDC0")]
	public void FIKAFFKAEHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x3E3F0C0", Offset = "0x3E3E2C0", VA = "0x183E3F0C0")]
	public JIHOPMBIOGC DCPEOMEKOMK()
	{
		return default(JIHOPMBIOGC);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x3E40820", Offset = "0x3E3FA20", VA = "0x183E40820", Slot = "4")]
	private IEnumerator<(TKey, TValue, int)> System.Collections.Generic.IEnumerable<(TKeyKey,TValueValue,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x3E40820", Offset = "0x3E3FA20", VA = "0x183E40820", Slot = "5")]
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
