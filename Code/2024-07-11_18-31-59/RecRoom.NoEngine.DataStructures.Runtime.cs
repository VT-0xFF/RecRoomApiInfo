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
		[Cpp2IlInjected.Address(RVA = "0x87C6C0", Offset = "0x87B0C0", VA = "0x18087C6C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x69AEAA0", Offset = "0x69AD4A0", VA = "0x1869AEAA0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x87D9C0", Offset = "0x87C3C0", VA = "0x18087D9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x87DA00", Offset = "0x87C400", VA = "0x18087DA00")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class EONDKOPFHGB
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
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
		[Cpp2IlInjected.Address(RVA = "0x47520C0", Offset = "0x4750AC0", VA = "0x1847520C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4752320", Offset = "0x4750D20", VA = "0x184752320")]
	protected PCHDCLFEEDF(bool JEMOMFALLKL, bool IIPKBLOGIFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4751CC0", Offset = "0x47506C0", VA = "0x184751CC0")]
	protected bool IMIEBMALNFH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4751940", Offset = "0x4750340", VA = "0x184751940")]
	protected void ENNFPLJBMDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4751A50", Offset = "0x4750450", VA = "0x184751A50")]
	protected void ICGFNMKKNCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2BC0AE0", Offset = "0x2BBF4E0", VA = "0x182BC0AE0")]
	private static void PPFNMNMGADK<U>(List<U>? CGIFJALMJMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4752120", Offset = "0x4750B20", VA = "0x184752120", Slot = "4")]
	public void PBLNBBGFGAP(T ENGMCBPHJGL, bool LKEHFOHKDKI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4751F00", Offset = "0x4750900", VA = "0x184751F00", Slot = "5")]
	public void MFKDEBIIBOM(T ENGMCBPHJGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4751D60", Offset = "0x4750760", VA = "0x184751D60")]
	public void IMJJLGNDCEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class EHODCIMNDCH : PCHDCLFEEDF<Action>
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x69AC250", Offset = "0x69AAC50", VA = "0x1869AC250")]
	public EHODCIMNDCH(bool JEMOMFALLKL = false, bool IIPKBLOGIFD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x69ABF90", Offset = "0x69AA990", VA = "0x1869ABF90")]
	public void APPOJKGPLJE()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x69AC1F0", Offset = "0x69AABF0", VA = "0x1869AC1F0")]
	public static EHODCIMNDCH PJMNGAAAFLI(EHODCIMNDCH IBKBKIOEMKH, Action ENGMCBPHJGL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x69AC190", Offset = "0x69AAB90", VA = "0x1869AC190")]
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
	[Cpp2IlInjected.Address(RVA = "0x3C529C0", Offset = "0x3C513C0", VA = "0x183C529C0")]
	public ODIOBOMGOFD(bool JEMOMFALLKL = false, bool IIPKBLOGIFD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4618D70", Offset = "0x4617770", VA = "0x184618D70")]
	public void APPOJKGPLJE(T DOGPFNGIKMO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3E36250", Offset = "0x3E34C50", VA = "0x183E36250")]
	public static ODIOBOMGOFD<T> PJMNGAAAFLI(ODIOBOMGOFD<T> IBKBKIOEMKH, Action<T> ENGMCBPHJGL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3E361B0", Offset = "0x3E34BB0", VA = "0x183E361B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3C529C0", Offset = "0x3C513C0", VA = "0x183C529C0")]
	public OPLNKFOLMMC(bool JEMOMFALLKL = false, bool IIPKBLOGIFD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x46AE000", Offset = "0x46ACA00", VA = "0x1846AE000")]
	public void APPOJKGPLJE(T DOGPFNGIKMO, U AICJBILPPGK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3E36250", Offset = "0x3E34C50", VA = "0x183E36250")]
	public static OPLNKFOLMMC<T, U> PJMNGAAAFLI(OPLNKFOLMMC<T, U> IBKBKIOEMKH, Action<T, U> ENGMCBPHJGL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3E361B0", Offset = "0x3E34BB0", VA = "0x183E361B0")]
	public static OPLNKFOLMMC<T, U> BOIEBIFOEJM(OPLNKFOLMMC<T, U> IBKBKIOEMKH, Action<T, U> ENGMCBPHJGL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class IEBCNEDNECP<T, U, V> : PCHDCLFEEDF<Action<T, U, V>> where T : notnull where U : notnull where V : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3C529C0", Offset = "0x3C513C0", VA = "0x183C529C0")]
	public IEBCNEDNECP(bool JEMOMFALLKL = false, bool IIPKBLOGIFD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3E351C0", Offset = "0x3E33BC0", VA = "0x183E351C0")]
	public void APPOJKGPLJE(T DOGPFNGIKMO, U AICJBILPPGK, V NJJHKDBJDAC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3E36250", Offset = "0x3E34C50", VA = "0x183E36250")]
	public static IEBCNEDNECP<T, U, V> PJMNGAAAFLI(IEBCNEDNECP<T, U, V> IBKBKIOEMKH, Action<T, U, V> ENGMCBPHJGL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3E361B0", Offset = "0x3E34BB0", VA = "0x183E361B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3C529C0", Offset = "0x3C513C0", VA = "0x183C529C0")]
	public PBCEHIPJNNH(bool JEMOMFALLKL = false, bool IIPKBLOGIFD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x474C900", Offset = "0x474B300", VA = "0x18474C900")]
	public void APPOJKGPLJE(T DOGPFNGIKMO, U AICJBILPPGK, V NJJHKDBJDAC, W HNFNJDLDBDO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3E36250", Offset = "0x3E34C50", VA = "0x183E36250")]
	public static PBCEHIPJNNH<T, U, V, W> PJMNGAAAFLI(PBCEHIPJNNH<T, U, V, W> IBKBKIOEMKH, Action<T, U, V, W> ENGMCBPHJGL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3E361B0", Offset = "0x3E34BB0", VA = "0x183E361B0")]
	public static PBCEHIPJNNH<T, U, V, W> BOIEBIFOEJM(PBCEHIPJNNH<T, U, V, W> IBKBKIOEMKH, Action<T, U, V, W> ENGMCBPHJGL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class NDLBBAPPBDD<T, U, V, W, X> : PCHDCLFEEDF<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3C529C0", Offset = "0x3C513C0", VA = "0x183C529C0")]
	public NDLBBAPPBDD(bool JEMOMFALLKL = false, bool IIPKBLOGIFD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x44FC2D0", Offset = "0x44FACD0", VA = "0x1844FC2D0")]
	public void APPOJKGPLJE(T DOGPFNGIKMO, U AICJBILPPGK, V NJJHKDBJDAC, W HNFNJDLDBDO, X IPBJLCONKPC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3E36250", Offset = "0x3E34C50", VA = "0x183E36250")]
	public static NDLBBAPPBDD<T, U, V, W, X> PJMNGAAAFLI(NDLBBAPPBDD<T, U, V, W, X> IBKBKIOEMKH, Action<T, U, V, W, X> ENGMCBPHJGL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3E361B0", Offset = "0x3E34BB0", VA = "0x183E361B0")]
	public static NDLBBAPPBDD<T, U, V, W, X> BOIEBIFOEJM(NDLBBAPPBDD<T, U, V, W, X> IBKBKIOEMKH, Action<T, U, V, W, X> ENGMCBPHJGL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class MDJDBMCPDBN<T, U, V, W, X, Y> : PCHDCLFEEDF<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3C529C0", Offset = "0x3C513C0", VA = "0x183C529C0")]
	public MDJDBMCPDBN(bool JEMOMFALLKL = false, bool IIPKBLOGIFD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4480DA0", Offset = "0x447F7A0", VA = "0x184480DA0")]
	public void APPOJKGPLJE(T DOGPFNGIKMO, U AICJBILPPGK, V NJJHKDBJDAC, W HNFNJDLDBDO, X IPBJLCONKPC, Y FACAKAOOAJP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3E36250", Offset = "0x3E34C50", VA = "0x183E36250")]
	public static MDJDBMCPDBN<T, U, V, W, X, Y> PJMNGAAAFLI(MDJDBMCPDBN<T, U, V, W, X, Y> IBKBKIOEMKH, Action<T, U, V, W, X, Y> ENGMCBPHJGL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3E361B0", Offset = "0x3E34BB0", VA = "0x183E361B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x4179440", Offset = "0x4177E40", VA = "0x184179440")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int DBFNDBELIMD
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x852880", Offset = "0x851280", VA = "0x180852880")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4179750", Offset = "0x4178150", VA = "0x184179750")]
	public KFNLCMGOLPI(int EEOEDOGAIMO, [Optional] LKJHFGDNFFP<TKey, TVal>.DMEMAHLHJCO? NLFLNFMHLBJ, [Optional] IEqualityComparer<TKey>? PMELJJPGANC, [Optional] LKJHFGDNFFP<TKey, TVal>.KFPHOPMGLCO? DKBFFBLIJNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4178910", Offset = "0x4177310", VA = "0x184178910")]
	public void IFBGAKJKFOE(TKey NDDCLPHCEEO, TVal JMDCGOKJIDA, bool PGNPAGKNOJL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x41792E0", Offset = "0x4177CE0", VA = "0x1841792E0")]
	public bool LHFKLFJGKLM(TKey NDDCLPHCEEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x41784A0", Offset = "0x4176EA0", VA = "0x1841784A0")]
	public bool AKPHPFIGELN(TKey LEPFMLOCOKH, [Out] TVal JMDCGOKJIDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4179490", Offset = "0x4177E90", VA = "0x184179490")]
	private void PCOIPMNNHFL(TKey NDDCLPHCEEO, TVal JMDCGOKJIDA, int ECGAAJFODGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x4178B30", Offset = "0x4177530", VA = "0x184178B30")]
	public bool IKGLBGGMAKG(TKey NDDCLPHCEEO, TVal JMDCGOKJIDA, bool PGNPAGKNOJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4178CF0", Offset = "0x41776F0", VA = "0x184178CF0")]
	public void IMJJLGNDCEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4178D90", Offset = "0x4177790", VA = "0x184178D90")]
	private void KFMIFKKBNID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x41787D0", Offset = "0x41771D0", VA = "0x1841787D0")]
	private bool HEPPGGBHHJP(TKey NDDCLPHCEEO, JAEDDHFIPOE NPGFMGMHJJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4178590", Offset = "0x4176F90", VA = "0x184178590")]
	private void BIMMJAIOPGC(TKey NDDCLPHCEEO, TVal JMDCGOKJIDA, JAEDDHFIPOE NPGFMGMHJJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x41786B0", Offset = "0x41770B0", VA = "0x1841786B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x8531E0", Offset = "0x851BE0", VA = "0x1808531E0")]
	public JOHMLMDFHNO(Action BDILBDIGJFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x69AD450", Offset = "0x69ABE50", VA = "0x1869AD450", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x28C7450", Offset = "0x28C5E50", VA = "0x1828C7450")]
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
		[Cpp2IlInjected.Address(RVA = "0x8528A0", Offset = "0x8512A0", VA = "0x1808528A0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4764170", Offset = "0x4762B70", VA = "0x184764170")]
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
		[Cpp2IlInjected.Address(RVA = "0x417CB30", Offset = "0x417B530", VA = "0x18417CB30")]
		get
		{
			return default(ReadOnlySequence<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long PBLCBJADLHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x417C7D0", Offset = "0x417B1D0", VA = "0x18417C7D0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool CFHDDGLKNCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x417C4A0", Offset = "0x417AEA0", VA = "0x18417C4A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x417CDA0", Offset = "0x417B7A0", VA = "0x18417CDA0")]
	public KICDLLEGEEI(CLNHAANMJHP<T> JEKOHDNPLBC, CLNHAANMJHP<T> BJALNJNECHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x417CE90", Offset = "0x417B890", VA = "0x18417CE90")]
	public KICDLLEGEEI(CLNHAANMJHP<T> JEKOHDNPLBC, int JHEGPJBDKAJ, CLNHAANMJHP<T> BJALNJNECHB, int MLNHFJAKLHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x417CCF0", Offset = "0x417B6F0", VA = "0x18417CCF0")]
	private KICDLLEGEEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x417C620", Offset = "0x417B020", VA = "0x18417C620", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x417CA00", Offset = "0x417B400", VA = "0x18417CA00")]
	public T[] MCENKMDFCLO()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x417C6B0", Offset = "0x417B0B0", VA = "0x18417C6B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x89B1F0", Offset = "0x899BF0", VA = "0x18089B1F0")]
		public static IPFCNNLNOGP FJAAFKPDAIA()
		{
			return default(IPFCNNLNOGP);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x31CFE70", Offset = "0x31CE870", VA = "0x1831CFE70")]
	public static string? CDBGPHHBDGD<T>([Optional] string? OCJCANJDIPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x31CFEF0", Offset = "0x31CE8F0", VA = "0x1831CFEF0")]
	public static string? NFHIGCMPAPO<T>([Optional] string? GHAMCPDDCOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x89B1F0", Offset = "0x899BF0", VA = "0x18089B1F0")]
	public static AHNPDBJIDJD AIJAFPFEFCM(string OCJCANJDIPB, string? GHAMCPDDCOM)
	{
		return default(AHNPDBJIDJD);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public OMAKALHAOGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x466C2F0", Offset = "0x466ACF0", VA = "0x18466C2F0")]
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
	[Cpp2IlInjected.Address(RVA = "0x69AEB20", Offset = "0x69AD520", VA = "0x1869AEB20")]
	public static Dictionary<string, OALIALIPGJK> BNKAOPAALJI(Type JKIBILAAALJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2CADAC0", Offset = "0x2CAC4C0", VA = "0x182CADAC0")]
	public static Dictionary<string, OALIALIPGJK> BNKAOPAALJI<T>(Type JKIBILAAALJ, IReadOnlyDictionary<T, string> FEJKFBNDGOM) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2CAE2F0", Offset = "0x2CACCF0", VA = "0x182CAE2F0")]
	public static Dictionary<string, OALIALIPGJK> DJLOBENCLDB<T>(List<T> LDEKPKHKINC) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x69AF010", Offset = "0x69ADA10", VA = "0x1869AF010")]
	public static Dictionary<string, OALIALIPGJK> NPJHABBCENL(Type JKIBILAAALJ, CPINKONIOII NPOCAOPDPCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x69AEE50", Offset = "0x69AD850", VA = "0x1869AEE50")]
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
		[Cpp2IlInjected.Address(RVA = "0x8542A0", Offset = "0x852CA0", VA = "0x1808542A0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x69ABF20", Offset = "0x69AA920", VA = "0x1869ABF20")]
	protected EGADAFAJMEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string AGNLMABPEGN();

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x69ABC20", Offset = "0x69AA620", VA = "0x1869ABC20", Slot = "8")]
	public virtual string FMEGILNGHGC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x69AB8E0", Offset = "0x69AA2E0", VA = "0x1869AB8E0", Slot = "9")]
	public void BLIMGKEMFLN(StringBuilder OJCNGLLCFAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x69AB880", Offset = "0x69AA280", VA = "0x1869AB880", Slot = "10")]
	public void AEKHJNONJBN(StringBuilder OJCNGLLCFAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x69ABCA0", Offset = "0x69AA6A0", VA = "0x1869ABCA0", Slot = "11")]
	public void GNKJOIOJAFE(StringBuilder OJCNGLLCFAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x69ABDC0", Offset = "0x69AA7C0", VA = "0x1869ABDC0", Slot = "12")]
	public void LHLKIDPFGOK(StringBuilder OJCNGLLCFAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x69ABB80", Offset = "0x69AA580", VA = "0x1869ABB80")]
	public static void CFHHCGPHJND(StringBuilder OJCNGLLCFAA, string LBDIAILPDCC, string DGBLABHNCMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5B77A80", Offset = "0x5B76480", VA = "0x185B77A80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class NNLKANOBHEH : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x69AE110", Offset = "0x69ACB10", VA = "0x1869AE110")]
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
	[Cpp2IlInjected.Address(RVA = "0x44ABC80", Offset = "0x44AA680", VA = "0x1844ABC80")]
	private MMILPAGNPCE([In] TErr BIALHEALFLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x44ABBB0", Offset = "0x44AA5B0", VA = "0x1844ABBB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x89B1F0", Offset = "0x899BF0", VA = "0x18089B1F0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public override bool OBCMKLKNFJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x89B1F0", Offset = "0x899BF0", VA = "0x18089B1F0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public override bool IHGOKPEGMPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x86D5A0", Offset = "0x86BFA0", VA = "0x18086D5A0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override long PBLCBJADLHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x69AD7C0", Offset = "0x69AC1C0", VA = "0x1869AD7C0", Slot = "12")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override long PHJFFHJCDOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x69AD830", Offset = "0x69AC230", VA = "0x1869AD830", Slot = "13")]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x69AD8A0", Offset = "0x69AC2A0", VA = "0x1869AD8A0", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x69AD750", Offset = "0x69AC150", VA = "0x1869AD750")]
	public KNMHLIHKHED(HashAlgorithm MALLOOCGECO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x69AD570", Offset = "0x69ABF70", VA = "0x1869AD570", Slot = "35")]
	public override int Read(byte[] PHMDIHEJOGG, int PENDBLHFGOI, int IHGHLPOONHD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x69AD720", Offset = "0x69AC120", VA = "0x1869AD720", Slot = "38")]
	public override void Write(byte[] PHMDIHEJOGG, int PENDBLHFGOI, int IHGHLPOONHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x69AD610", Offset = "0x69AC010", VA = "0x1869AD610", Slot = "33")]
	public override long Seek(long PENDBLHFGOI, SeekOrigin MNCFLKFGCKD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x69AD6A0", Offset = "0x69AC0A0", VA = "0x1869AD6A0", Slot = "34")]
	public override void SetLength(long JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290", Slot = "23")]
	public override void Flush()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x69AD490", Offset = "0x69ABE90", VA = "0x1869AD490")]
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
		[Cpp2IlInjected.Address(RVA = "0x9E1740", Offset = "0x9E0140", VA = "0x1809E1740")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x51F3780", Offset = "0x51F2180", VA = "0x1851F3780")]
	private static CLNHAANMJHP<T> NKDMLCAILNB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x51F26E0", Offset = "0x51F10E0", VA = "0x1851F26E0")]
	private static void JADCCDCNOLH(CLNHAANMJHP<T> LPOBPOAGFHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x3CC0740", Offset = "0x3CBF140", VA = "0x183CC0740")]
	private CLNHAANMJHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x51F2C80", Offset = "0x51F1680", VA = "0x1851F2C80")]
	public static CLNHAANMJHP<T> JGIIBNEOBDO(ReadOnlyMemory<T> EDNOMKCPEGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x51F2E50", Offset = "0x51F1850", VA = "0x1851F2E50")]
	public static CLNHAANMJHP<T> JGIIBNEOBDO(IMemoryOwner<T> INNKPDCJHIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x51F3650", Offset = "0x51F2050", VA = "0x1851F3650")]
	public static void NDFMBLMHNHO(CLNHAANMJHP<T> JEKOHDNPLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x51F2200", Offset = "0x51F0C00", VA = "0x1851F2200", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x51F3550", Offset = "0x51F1F50", VA = "0x1851F3550")]
	public CLNHAANMJHP<T> LBJDLPDBEDK(IMemoryOwner<T> INNKPDCJHIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x51F3230", Offset = "0x51F1C30", VA = "0x1851F3230")]
	private void JIIKFBPNFND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x51F3410", Offset = "0x51F1E10", VA = "0x1851F3410")]
	private CLNHAANMJHP<T> KGEKKJCOPLE(CLNHAANMJHP<T> LPOBPOAGFHD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class BLMECOIIFEK : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x69AB420", Offset = "0x69A9E20", VA = "0x1869AB420")]
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
	[Cpp2IlInjected.Address(RVA = "0x41B95F0", Offset = "0x41B7FF0", VA = "0x1841B95F0")]
	private KOKJJOKECLK([In] TOk ANPDLFAPLKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3D05B30", Offset = "0x3D04530", VA = "0x183D05B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x86D5A0", Offset = "0x86BFA0", VA = "0x18086D5A0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public override bool OBCMKLKNFJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x86D5A0", Offset = "0x86BFA0", VA = "0x18086D5A0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public override bool IHGOKPEGMPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x89B1F0", Offset = "0x899BF0", VA = "0x18089B1F0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public override long PBLCBJADLHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x69ACD50", Offset = "0x69AB750", VA = "0x1869ACD50", Slot = "12")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public override long PHJFFHJCDOD
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x69ACDB0", Offset = "0x69AB7B0", VA = "0x1869ACDB0", Slot = "13")]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x69ACE80", Offset = "0x69AB880", VA = "0x1869ACE80", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x69ACC80", Offset = "0x69AB680", VA = "0x1869ACC80")]
	public ICOBPIEENIH(ReadOnlySequence<byte> BJMHIIGPDHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x69AC830", Offset = "0x69AB230", VA = "0x1869AC830", Slot = "33")]
	public override long Seek(long PENDBLHFGOI, SeekOrigin MNCFLKFGCKD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x69AC390", Offset = "0x69AAD90", VA = "0x1869AC390", Slot = "35")]
	public override int Read(byte[] PHMDIHEJOGG, int PENDBLHFGOI, int IHGHLPOONHD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290", Slot = "23")]
	public override void Flush()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x69ACBC0", Offset = "0x69AB5C0", VA = "0x1869ACBC0", Slot = "34")]
	public override void SetLength(long JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x69ACC20", Offset = "0x69AB620", VA = "0x1869ACC20", Slot = "38")]
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
		[Cpp2IlInjected.Address(RVA = "0x51094B0", Offset = "0x5107EB0", VA = "0x1851094B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool BKLCFEFPKND
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x510D5F0", Offset = "0x510BFF0", VA = "0x18510D5F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x510F270", Offset = "0x510DC70", VA = "0x18510F270")]
	internal CIKECDEKJAI([In] TErr BIALHEALFLJ, [In] TOk ANPDLFAPLKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5109BC0", Offset = "0x51085C0", VA = "0x185109BC0")]
	public static CIKECDEKJAI<TOk, TErr> CDNNEODIDEA([In] TErr BIALHEALFLJ)
	{
		return default(CIKECDEKJAI<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x510A030", Offset = "0x5108A30", VA = "0x18510A030")]
	public static CIKECDEKJAI<TOk, TErr> COBHGIDCNJO([In] TOk ANPDLFAPLKO)
	{
		return default(CIKECDEKJAI<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2745710", Offset = "0x2744110", VA = "0x182745710")]
	public CIKECDEKJAI<TOk?, UErr?> NKOIMMHIKLA<UErr>()
	{
		return default(CIKECDEKJAI<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2744ED0", Offset = "0x27438D0", VA = "0x182744ED0")]
	public CIKECDEKJAI<UOk?, TErr?> GKPPOACGCNH<UOk>()
	{
		return default(CIKECDEKJAI<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x27442A0", Offset = "0x2742CA0", VA = "0x1827442A0")]
	public CIKECDEKJAI<UOk?, TErr?> ELFDPHOGCFJ<UOk>()
	{
		return default(CIKECDEKJAI<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2743AD0", Offset = "0x27424D0", VA = "0x182743AD0")]
	public CIKECDEKJAI<TOk?, UErr?> BPAKFFAOHLN<UErr>()
	{
		return default(CIKECDEKJAI<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x510D070", Offset = "0x510BA70", VA = "0x18510D070")]
	public CIKECDEKJAI<MOOMEEOMEEK, TErr> OKDFKNDAHLP()
	{
		return default(CIKECDEKJAI<MOOMEEOMEEK, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x510C830", Offset = "0x510B230", VA = "0x18510C830")]
	public static bool KBKLEFBHIDJ([In] CIKECDEKJAI<TOk, TErr> IIILBPDHGHN, [In] CIKECDEKJAI<TOk, TErr> CLEBPGFBBGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x510A9B0", Offset = "0x51093B0", VA = "0x18510A9B0", Slot = "4")]
	public bool Equals(CIKECDEKJAI<TOk, TErr> OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x510AA80", Offset = "0x5109480", VA = "0x18510AA80", Slot = "0")]
	public override bool Equals(object OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x510B3B0", Offset = "0x5109DB0", VA = "0x18510B3B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x510DB10", Offset = "0x510C510", VA = "0x18510DB10", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x46A6160", Offset = "0x46A4B60", VA = "0x1846A6160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x46A6480", Offset = "0x46A4E80", VA = "0x1846A6480", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x2B121B0", Offset = "0x2B10BB0", VA = "0x182B121B0")]
	public static CIKECDEKJAI<TOk?, TErr?> ACEKLHKKIKP<TOk, TErr>([In] this CIKECDEKJAI<TOk, TErr> HIKEOGPAJAF, [In] TOk ANPDLFAPLKO)
	{
		return default(CIKECDEKJAI<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x2B12200", Offset = "0x2B10C00", VA = "0x182B12200")]
	public static CIKECDEKJAI<MOOMEEOMEEK, TErr?> ACEKLHKKIKP<TErr>([In] this CIKECDEKJAI<MOOMEEOMEEK, TErr> HIKEOGPAJAF)
	{
		return default(CIKECDEKJAI<MOOMEEOMEEK, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x2B121B0", Offset = "0x2B10BB0", VA = "0x182B121B0")]
	public static CIKECDEKJAI<TOk?, TErr?> HNDFFKMDGKI<TOk, TErr>([In] this CIKECDEKJAI<TOk, TErr> HIKEOGPAJAF, [In] TErr BIALHEALFLJ)
	{
		return default(CIKECDEKJAI<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x2B148B0", Offset = "0x2B132B0", VA = "0x182B148B0")]
	public static TOk? NOOHCMLJMLC<TOk, TErr>([In] this CIKECDEKJAI<TOk, TErr> HIKEOGPAJAF)
	{
		return (TOk?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x2B12CE0", Offset = "0x2B116E0", VA = "0x182B12CE0")]
	[AsyncStateMachine(typeof(OOJOEMADILA<, >))]
	public static Task<TOk?>? GPNPLLDKGPP<TOk, TErr>(this Task<CIKECDEKJAI<TOk, TErr>> HIKEOGPAJAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x2B12550", Offset = "0x2B10F50", VA = "0x182B12550")]
	public static TErr? BNJEBNHBGEF<TErr, TOk>([In] this CIKECDEKJAI<TOk, TErr> HIKEOGPAJAF)
	{
		return (TErr?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x2B13420", Offset = "0x2B11E20", VA = "0x182B13420")]
	public static bool NJDLJMMPNCJ<TOk, TErr, UErr, UOk>([In] this CIKECDEKJAI<TOk, TErr> HIKEOGPAJAF, [Out] CIKECDEKJAI<UOk, UErr> ECBHJEBBCFH) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x2B12BF0", Offset = "0x2B115F0", VA = "0x182B12BF0")]
	public static bool DPPIGNPMCOF<TOk, TErr>([In] this CIKECDEKJAI<TOk, TErr> HIKEOGPAJAF, [Out][NotNullWhen(true)] TOk ANPDLFAPLKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x2B14E00", Offset = "0x2B13800", VA = "0x182B14E00")]
	public static bool ODMHPAAHKFG<TOk, TErr>([In] this CIKECDEKJAI<TOk, TErr> HIKEOGPAJAF, [Out][NotNullWhen(true)] TErr BIALHEALFLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x2B14B80", Offset = "0x2B13580", VA = "0x182B14B80")]
	public static bool NPIGGPFBBLE<TOk, TErr>([In] this CIKECDEKJAI<TOk, TErr> HIKEOGPAJAF, [Out][NotNullWhen(true)] TOk ANPDLFAPLKO, [Out][NotNullWhen(false)] TErr BIALHEALFLJ) where TOk : notnull where TErr : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x2B13320", Offset = "0x2B11D20", VA = "0x182B13320")]
	public static bool MDNNLPHAAPD<TOk, TErr>([In] this CIKECDEKJAI<TOk, TErr> HIKEOGPAJAF, [Out][NotNullWhen(true)] TOk ANPDLFAPLKO, [Out] CIKECDEKJAI<TOk, TErr> ECBHJEBBCFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x2B13550", Offset = "0x2B11F50", VA = "0x182B13550")]
	public static bool NJDLJMMPNCJ<TOk, TErr, UErr, UOk>([In] this CIKECDEKJAI<TOk, TErr> HIKEOGPAJAF, [Out][NotNullWhen(true)] TOk ANPDLFAPLKO, [Out] CIKECDEKJAI<UOk, UErr> ECBHJEBBCFH) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x2B12840", Offset = "0x2B11240", VA = "0x182B12840")]
	public static bool CKCDDJGGFFI<TOk, TErr>([In] this CIKECDEKJAI<TOk, TErr> HIKEOGPAJAF, [Out][NotNullWhen(true)] TOk ANPDLFAPLKO, [Out] CIKECDEKJAI<MOOMEEOMEEK, TErr> ECBHJEBBCFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x2B15110", Offset = "0x2B13B10", VA = "0x182B15110")]
	public static CIKECDEKJAI<UOk, UErr> OMMHMEKDLEJ<UOk, UErr, TOk, TErr>([In] this CIKECDEKJAI<TOk, TErr> HIKEOGPAJAF, [In] CIKECDEKJAI<UOk, UErr> LMDEKGEENAI) where TOk : UOk where TErr : UErr
	{
		return default(CIKECDEKJAI<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x2B12FB0", Offset = "0x2B119B0", VA = "0x182B12FB0")]
	public static CIKECDEKJAI<TOk?[]?, TErr?> KADGGBPMBOI<TOk, TErr>(this IEnumerable<CIKECDEKJAI<TOk, TErr>> HIKEOGPAJAF)
	{
		return default(CIKECDEKJAI<TOk[], TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class NFKEGDCPPMJ<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x2BC00C0", Offset = "0x2BBEAC0", VA = "0x182BC00C0")]
	public static CIKECDEKJAI<TOk, T> ACEKLHKKIKP<TOk>([In] TOk ANPDLFAPLKO) where TOk : notnull
	{
		return default(CIKECDEKJAI<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x4508760", Offset = "0x4507160", VA = "0x184508760")]
	public static CIKECDEKJAI<MOOMEEOMEEK, T> ACEKLHKKIKP()
	{
		return default(CIKECDEKJAI<MOOMEEOMEEK, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x2BC00C0", Offset = "0x2BBEAC0", VA = "0x182BC00C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1EADBC0", Offset = "0x1EAC5C0", VA = "0x181EADBC0")]
		public AEIKIKCLEMK(BJBGFBMCJBH<T> CIGKBEKHOLC, int FLLONKBAGBA, bool KLDADDHEDFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x3C54A90", Offset = "0x3C53490", VA = "0x183C54A90")]
		public BJBGFBMCJBH<T>.BIJODDGHCLA DCPEOMEKOMK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x3C54B80", Offset = "0x3C53580", VA = "0x183C54B80", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x3C54B80", Offset = "0x3C53580", VA = "0x183C54B80", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4E2A450", Offset = "0x4E28E50", VA = "0x184E2A450")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x4E2A5C0", Offset = "0x4E28FC0", VA = "0x184E2A5C0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x4E2A630", Offset = "0x4E29030", VA = "0x184E2A630", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x4E2ABD0", Offset = "0x4E295D0", VA = "0x184E2ABD0")]
		public BIJODDGHCLA(BJBGFBMCJBH<T> CIGKBEKHOLC, int FLLONKBAGBA, bool KLDADDHEDFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x4E2A4D0", Offset = "0x4E28ED0", VA = "0x184E2A4D0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x4E2A560", Offset = "0x4E28F60", VA = "0x184E2A560", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public GBMFODKENPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x3C9E8C0", Offset = "0x3C9D2C0", VA = "0x183C9E8C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x4E2BF00", Offset = "0x4E2A900", VA = "0x184E2BF00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public T EBFPDFJFKPC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x3B652C0", Offset = "0x3B63CC0", VA = "0x183B652C0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public T NCDLNIPPHPH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x4E2BF60", Offset = "0x4E2A960", VA = "0x184E2BF60")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public T NBEMKGGOBKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x4E2C0F0", Offset = "0x4E2AAF0", VA = "0x184E2C0F0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public int PBLCBJADLHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x191CFF0", Offset = "0x191B9F0", VA = "0x18191CFF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x1162B40", Offset = "0x1161540", VA = "0x181162B40")]
	private static int ICKPOHFJOGL(int DHNLEFJCEAH, int OMJPDIKPOLO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x4E2C4F0", Offset = "0x4E2AEF0", VA = "0x184E2C4F0")]
	public BJBGFBMCJBH(int ECGAAJFODGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x4E2C200", Offset = "0x4E2AC00", VA = "0x184E2C200")]
	public BJBGFBMCJBH(int ECGAAJFODGN, Func<T> PGLPKIPENLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x4E2C450", Offset = "0x4E2AE50", VA = "0x184E2C450")]
	public BJBGFBMCJBH(T[] FDPJMKODKPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x4E2BED0", Offset = "0x4E2A8D0", VA = "0x184E2BED0")]
	public void GACIJHFPJBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x4E2BD70", Offset = "0x4E2A770", VA = "0x184E2BD70")]
	public IEnumerable<T> AOPMNJKNHGF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x4E2BE30", Offset = "0x4E2A830", VA = "0x184E2BE30")]
	public BJBGFBMCJBH<T>.BIJODDGHCLA DCPEOMEKOMK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x3BD7D90", Offset = "0x3BD6790", VA = "0x183BD7D90", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x3BD7D90", Offset = "0x3BD6790", VA = "0x183BD7D90", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class NJBPNELOIGJ
{
	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x2C93E70", Offset = "0x2C92870", VA = "0x182C93E70")]
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
		[Cpp2IlInjected.Address(RVA = "0x1FB3D40", Offset = "0x1FB2740", VA = "0x181FB3D40")]
		public RRColor(float DLFEHJOHIIJ, float BAMOLPIILJE, float GANEOONFJPD, float MLFGLJKBOIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x69AF620", Offset = "0x69AE020", VA = "0x1869AF620", Slot = "4")]
		public bool Equals(RRColor OKGBBGMIACH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x69AF6A0", Offset = "0x69AE0A0", VA = "0x1869AF6A0", Slot = "0")]
		public override bool Equals(object OKGBBGMIACH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x69AF7A0", Offset = "0x69AE1A0", VA = "0x1869AF7A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x69AF820", Offset = "0x69AE220", VA = "0x1869AF820", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x4297ED0", Offset = "0x42968D0", VA = "0x184297ED0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x4297EA0", Offset = "0x42968A0", VA = "0x184297EA0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x926780", Offset = "0x925180", VA = "0x180926780")]
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
		[Cpp2IlInjected.Address(RVA = "0x3C9F530", Offset = "0x3C9DF30", VA = "0x183C9F530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x3C9F9F0", Offset = "0x3C9E3F0", VA = "0x183C9F9F0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x4772EA0", Offset = "0x47718A0", VA = "0x184772EA0")]
	public PMMLOFLPENC([In] T GDBEHNBLALJ, int MPBNFFENBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x4772D20", Offset = "0x4771720", VA = "0x184772D20")]
	public PMMLOFLPENC([In] T GDBEHNBLALJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x4772750", Offset = "0x4771150", VA = "0x184772750", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x4772C30", Offset = "0x4771630", VA = "0x184772C30")]
	public LONHFAKPBLE PIBEABAPEMI()
	{
		return default(LONHFAKPBLE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x4772B10", Offset = "0x4771510", VA = "0x184772B10")]
	[AsyncStateMachine(typeof(PMMLOFLPENC<>.GCLEECIEJBD))]
	public Task<PMMLOFLPENC<T>.LONHFAKPBLE> ODLINDLJOKA(CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x4772790", Offset = "0x4771190", VA = "0x184772790")]
	public void KJDHHKBDEND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class JNFJDNKDKFL
{
	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x69AD3E0", Offset = "0x69ABDE0", VA = "0x1869AD3E0")]
	public static PMMLOFLPENC<MOOMEEOMEEK> FJAAFKPDAIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x2B5FCD0", Offset = "0x2B5E6D0", VA = "0x182B5FCD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3D03350", Offset = "0x3D01D50", VA = "0x183D03350")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x3D02FF0", Offset = "0x3D019F0", VA = "0x183D02FF0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x926780", Offset = "0x925180", VA = "0x180926780")]
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
			[Cpp2IlInjected.Address(RVA = "0x3D03350", Offset = "0x3D01D50", VA = "0x183D03350")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x3E5F490", Offset = "0x3E5DE90", VA = "0x183E5F490", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x926780", Offset = "0x925180", VA = "0x180926780")]
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
		[Cpp2IlInjected.Address(RVA = "0x4467960", Offset = "0x4466360", VA = "0x184467960", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x3C9F9F0", Offset = "0x3C9E3F0", VA = "0x183C9F9F0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x4E63430", Offset = "0x4E61E30", VA = "0x184E63430")]
	internal BMDAGFILCLG(PMMLOFLPENC<int> ODPJHCMIMLF, PMMLOFLPENC<MOOMEEOMEEK> JCAFDJJNEKJ, PMMLOFLPENC<MOOMEEOMEEK> COLMIGGKIOD, [In] T GDBEHNBLALJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x4E63060", Offset = "0x4E61A60", VA = "0x184E63060", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x4E62AC0", Offset = "0x4E614C0", VA = "0x184E62AC0")]
	public HCKAEINKBBL CLAPPBNJGGL()
	{
		return default(HCKAEINKBBL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x4E63340", Offset = "0x4E61D40", VA = "0x184E63340")]
	public IHOHBNDOCEO HHIFNKNGNCI()
	{
		return default(IHOHBNDOCEO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x4E62DA0", Offset = "0x4E617A0", VA = "0x184E62DA0")]
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
	[Cpp2IlInjected.Address(RVA = "0x69AD920", Offset = "0x69AC320", VA = "0x1869AD920")]
	public static BMDAGFILCLG<MOOMEEOMEEK> FJAAFKPDAIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x2C1D3A0", Offset = "0x2C1BDA0", VA = "0x182C1D3A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851300", VA = "0x180852900", Slot = "7")]
	public override string AGNLMABPEGN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x3C97860", Offset = "0x3C96260", VA = "0x183C97860")]
	internal GAHFFFJJFCN(string JNNDBFGKHHD, [In] TData LINJEFIAFHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class DDAFJBKNENI
{
	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x69AB480", Offset = "0x69A9E80", VA = "0x1869AB480")]
	public static GAHFFFJJFCN<MOOMEEOMEEK> FJAAFKPDAIA(string JNNDBFGKHHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x28C7450", Offset = "0x28C5E50", VA = "0x1828C7450")]
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
		[Cpp2IlInjected.Address(RVA = "0x8BEAD0", Offset = "0x8BD4D0", VA = "0x1808BEAD0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0xECC000", Offset = "0xECAA00", VA = "0x180ECC000")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x69AD270", Offset = "0x69ABC70", VA = "0x1869AD270")]
	public void MBCOGGKHPPK(float JMDCGOKJIDA, object EOCJCEFCOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x69AD2E0", Offset = "0x69ABCE0", VA = "0x1869AD2E0")]
	public void NOOCMPIIMHF(object EOCJCEFCOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x69AD220", Offset = "0x69ABC20", VA = "0x1869AD220")]
	public void IMJJLGNDCEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x69AD0F0", Offset = "0x69ABAF0", VA = "0x1869AD0F0")]
	private void AKFAJJAJDGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x69AD350", Offset = "0x69ABD50", VA = "0x1869AD350")]
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
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public JCECEGGGKII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x4086490", Offset = "0x4084E90", VA = "0x184086490")]
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
		[Cpp2IlInjected.Address(RVA = "0x3C54250", Offset = "0x3C52C50", VA = "0x183C54250")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool FBEJJFNJIMN
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x3C542E0", Offset = "0x3C52CE0", VA = "0x183C542E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public int MELIDLJEANB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x85FD10", Offset = "0x85E710", VA = "0x18085FD10")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x860F50", Offset = "0x85F950", VA = "0x180860F50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x3C54560", Offset = "0x3C52F60", VA = "0x183C54560")]
	public bool PBLNBBGFGAP(T EOCJCEFCOOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x3C543F0", Offset = "0x3C52DF0", VA = "0x183C543F0")]
	public bool MFKDEBIIBOM(T EOCJCEFCOOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x3C54290", Offset = "0x3C52C90", VA = "0x183C54290")]
	public bool DJONJHALGBO(T EOCJCEFCOOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x3C54320", Offset = "0x3C52D20", VA = "0x183C54320")]
	public void KJPNELFGJOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x3C54720", Offset = "0x3C53120", VA = "0x183C54720", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
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
	[Cpp2IlInjected.Address(RVA = "0x8531E0", Offset = "0x851BE0", VA = "0x1808531E0")]
	public NKPKPHIMNEI(string OKOMKPFKBCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x69AE0C0", Offset = "0x69ACAC0", VA = "0x1869AE0C0", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public PLFAAGOIDND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x69AF570", Offset = "0x69ADF70", VA = "0x1869AF570")]
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
		[Cpp2IlInjected.Address(RVA = "0x69AD9F0", Offset = "0x69AC3F0", VA = "0x1869AD9F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool FBEJJFNJIMN
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x69ADAE0", Offset = "0x69AC4E0", VA = "0x1869ADAE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int MELIDLJEANB
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x85FD10", Offset = "0x85E710", VA = "0x18085FD10")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x860F50", Offset = "0x85F950", VA = "0x180860F50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x69ADC00", Offset = "0x69AC600", VA = "0x1869ADC00")]
	public bool PBLNBBGFGAP(object EOCJCEFCOOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x69ADB60", Offset = "0x69AC560", VA = "0x1869ADB60")]
	public bool MFKDEBIIBOM(object EOCJCEFCOOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x69ADA80", Offset = "0x69AC480", VA = "0x1869ADA80")]
	public bool DJONJHALGBO(object EOCJCEFCOOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x69ADAF0", Offset = "0x69AC4F0", VA = "0x1869ADAF0")]
	public void KJPNELFGJOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x69ADCE0", Offset = "0x69AC6E0", VA = "0x1869ADCE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
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
		[Cpp2IlInjected.Address(RVA = "0x10707A0", Offset = "0x106F1A0", VA = "0x1810707A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x106FD80", Offset = "0x106E780", VA = "0x18106FD80", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public object? PHDBNNKJBKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x856BC0", Offset = "0x8555C0", VA = "0x180856BC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x85B4C0", Offset = "0x859EC0", VA = "0x18085B4C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool BFKHAPKIPIG
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x4DFE590", Offset = "0x4DFCF90", VA = "0x184DFE590")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x4DFE5F0", Offset = "0x4DFCFF0", VA = "0x184DFE5F0")]
	public bool MBCOGGKHPPK(T JMDCGOKJIDA, object EOCJCEFCOOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x448D9E0", Offset = "0x448C3E0", VA = "0x18448D9E0")]
	public bool NOOCMPIIMHF(object EOCJCEFCOOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x37DBBE0", Offset = "0x37DA5E0", VA = "0x1837DBBE0")]
	public void IMJJLGNDCEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x4DFCCB0", Offset = "0x4DFB6B0", VA = "0x184DFCCB0")]
	public bool AKPHPFIGELN(object EOCJCEFCOOA, [Out] T JMDCGOKJIDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x4DFDB20", Offset = "0x4DFC520", VA = "0x184DFDB20")]
	[PEHALAEOKAF("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool BCHEJMABEAA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x448DA80", Offset = "0x448C480", VA = "0x18448DA80")]
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
		[Cpp2IlInjected.Address(RVA = "0x44A75A0", Offset = "0x44A5FA0", VA = "0x1844A75A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int MELIDLJEANB
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x44A78A0", Offset = "0x44A62A0", VA = "0x1844A78A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x44A7A40", Offset = "0x44A6440", VA = "0x1844A7A40")]
	public void PBLNBBGFGAP(T EOCJCEFCOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x44A7710", Offset = "0x44A6110", VA = "0x1844A7710")]
	public void MFKDEBIIBOM(T EOCJCEFCOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x44A76D0", Offset = "0x44A60D0", VA = "0x1844A76D0")]
	public void KJPNELFGJOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x44A7CB0", Offset = "0x44A66B0", VA = "0x1844A7CB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
	public MLLDOOHJPFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
internal static class CEJKDFALNHD
{
	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x292E170", Offset = "0x292CB70", VA = "0x18292E170")]
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
			[Cpp2IlInjected.Address(RVA = "0x69AB500", Offset = "0x69A9F00", VA = "0x1869AB500")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x69AB680", Offset = "0x69AA080", VA = "0x1869AB680")]
		public ECBAIFDOJGP(float GBALKPFEDAI, float DAOCGKJPECC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x69AB510", Offset = "0x69A9F10", VA = "0x1869AB510", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public ECCJGCFIAMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x69AB7E0", Offset = "0x69AA1E0", VA = "0x1869AB7E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x69AE6B0", Offset = "0x69AD0B0", VA = "0x1869AE6B0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x69AE5F0", Offset = "0x69ACFF0", VA = "0x1869AE5F0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x69AE910", Offset = "0x69AD310", VA = "0x1869AE910")]
	public NPFIODHPLCC(int HHGNDILCLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x69AE880", Offset = "0x69AD280", VA = "0x1869AE880")]
	public NKKKGGINLEP OBDBJJNBNHF(ECBAIFDOJGP NHEIBBJGGFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x69AE170", Offset = "0x69ACB70", VA = "0x1869AE170")]
	public void AFBGBKGKPHH(AICOLMPJDDO FMNGMAHNJCI, [Optional] ECBAIFDOJGP DHFHKLCGEPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x69AE770", Offset = "0x69AD170", VA = "0x1869AE770", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x69AC300", Offset = "0x69AAD00", VA = "0x1869AC300")]
		public ELIJMGPKDBL(AICOLMPJDDO PIPDFIMKOBC, KPJCHGMHNOH HBBMMHKOEKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x69AC2B0", Offset = "0x69AACB0", VA = "0x1869AC2B0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x69AD080", Offset = "0x69ABA80", VA = "0x1869AD080")]
	internal static bool JLCEOLFHAMG(float MLFGLJKBOIG, float GANEOONFJPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x699DE50", Offset = "0x699C850", VA = "0x18699DE50")]
	internal static float BKDOBEFLFEJ(float MLFGLJKBOIG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x69ACFC0", Offset = "0x69AB9C0", VA = "0x1869ACFC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x69ADE90", Offset = "0x69AC890", VA = "0x1869ADE90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event KPJCHGMHNOH? ODCPIOEPMDN
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x69AE020", Offset = "0x69ACA20", VA = "0x1869AE020", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x69ADF80", Offset = "0x69AC980", VA = "0x1869ADF80", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
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
	[Cpp2IlInjected.Address(RVA = "0x44F5D20", Offset = "0x44F4720", VA = "0x1844F5D20", Slot = "4")]
	public GMNMJHGHIHD<T> MCBLJONGBGM([Out] T JMDCGOKJIDA)
	{
		return default(GMNMJHGHIHD<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x44F5DC0", Offset = "0x44F47C0", VA = "0x1844F5DC0")]
	public void NLCHOINDCPP(T DBGJCBLNMLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x3CBCF40", Offset = "0x3CBB940", VA = "0x183CBCF40", Slot = "5")]
	public void IMJJLGNDCEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290", Slot = "6")]
	protected virtual void EHGNCICKNOA(T MCGIAAMHBOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x44F5C70", Offset = "0x44F4670", VA = "0x1844F5C70")]
	private T JMJOGDIBBHK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x44F5E40", Offset = "0x44F4840", VA = "0x1844F5E40")]
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
	[Cpp2IlInjected.Address(RVA = "0xAB1600", Offset = "0xAB0000", VA = "0x180AB1600")]
	internal GMNMJHGHIHD(T JMDCGOKJIDA, NAJHBLNFFCA<T> JOPKJIBCCEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x3CC82A0", Offset = "0x3CC6CA0", VA = "0x183CC82A0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x69AF3F0", Offset = "0x69ADDF0", VA = "0x1869AF3F0")]
	public static GMNMJHGHIHD<StringBuilder> JMJOGDIBBHK([Out] StringBuilder JMDCGOKJIDA)
	{
		return default(GMNMJHGHIHD<StringBuilder>);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x69AF3D0", Offset = "0x69ADDD0", VA = "0x1869AF3D0", Slot = "6")]
	protected override void EHGNCICKNOA(StringBuilder MCGIAAMHBOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x69AF530", Offset = "0x69ADF30", VA = "0x1869AF530")]
	public PDPKGOLFIGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class PNJOODKNOEI : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x64137C0", Offset = "0x64121C0", VA = "0x1864137C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x10707A0", Offset = "0x106F1A0", VA = "0x1810707A0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3C021B0", Offset = "0x3C00BB0", VA = "0x183C021B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x85C1D0", Offset = "0x85ABD0", VA = "0x18085C1D0")]
		[DebuggerHidden]
		public FMONEAPICLD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x39875D0", Offset = "0x3985FD0", VA = "0x1839875D0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x3C01580", Offset = "0x3BFFF80", VA = "0x183C01580", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x3C01440", Offset = "0x3BFFE40", VA = "0x183C01440")]
		private void CEOBCCLIKJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x3C01530", Offset = "0x3BFFF30", VA = "0x183C01530")]
		private void KNPOGHPBEEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x3C02160", Offset = "0x3C00B60", VA = "0x183C02160", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x422F5F0", Offset = "0x422DFF0", VA = "0x18422F5F0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool HNPAFAKBDHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x89B1F0", Offset = "0x899BF0", VA = "0x18089B1F0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public TValue NBEMKGGOBKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x422F790", Offset = "0x422E190", VA = "0x18422F790", Slot = "4")]
		get
		{
			return (TValue)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x422FA80", Offset = "0x422E480", VA = "0x18422FA80", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public ICollection<TKey> FBJILCMLFAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x422F820", Offset = "0x422E220", VA = "0x18422F820", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public ICollection<TValue> PGIKKFOHHOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x422F930", Offset = "0x422E330", VA = "0x18422F930", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x422F460", Offset = "0x422DE60", VA = "0x18422F460")]
	public LEGEPBHINPE(NKDCFEEBFKH<TKey, TValue> DEJAOKJBLGD, [Optional] IDictionary<TKey, TValue>? OAMAPMCJJKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x422CCA0", Offset = "0x422B6A0", VA = "0x18422CCA0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x422D560", Offset = "0x422BF60", VA = "0x18422D560")]
	public void FLMDPFEEJKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x422C800", Offset = "0x422B200", VA = "0x18422C800", Slot = "9")]
	public void Add(TKey NDDCLPHCEEO, TValue JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x422D7E0", Offset = "0x422C1E0", VA = "0x18422D7E0")]
	public void HAHBCCHIPOB(TKey NDDCLPHCEEO, TValue JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x422DB60", Offset = "0x422C560", VA = "0x18422DB60")]
	public void HOLOFOIHPNP(TKey NDDCLPHCEEO, TValue JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x422DF60", Offset = "0x422C960", VA = "0x18422DF60")]
	public void JIDMKBBBJAG(TKey NDDCLPHCEEO, TValue JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x422E3A0", Offset = "0x422CDA0", VA = "0x18422E3A0")]
	public void NCKAFCGIAEI(TKey NDDCLPHCEEO, TValue JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x422EA90", Offset = "0x422D490", VA = "0x18422EA90", Slot = "14")]
	void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> JNHGHHKKNBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x422EB30", Offset = "0x422D530", VA = "0x18422EB30", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> JNHGHHKKNBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x422EE90", Offset = "0x422D890", VA = "0x18422EE90", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> JNHGHHKKNBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x422CD30", Offset = "0x422B730", VA = "0x18422CD30", Slot = "8")]
	public bool ContainsKey(TKey NDDCLPHCEEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x422E2E0", Offset = "0x422CCE0", VA = "0x18422E2E0")]
	public bool JOCPMELEDOB(TKey NDDCLPHCEEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x422D9D0", Offset = "0x422C3D0", VA = "0x18422D9D0")]
	public bool HEICINABDBH(TKey NDDCLPHCEEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x422E8F0", Offset = "0x422D2F0", VA = "0x18422E8F0", Slot = "10")]
	public bool Remove(TKey NDDCLPHCEEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x422F2C0", Offset = "0x422DCC0", VA = "0x18422F2C0", Slot = "11")]
	public bool TryGetValue(TKey NDDCLPHCEEO, [Out] TValue JMDCGOKJIDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x422D0E0", Offset = "0x422BAE0", VA = "0x18422D0E0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TValue>[] PFKJAOOHGBN, int OMHDEOJLLBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x4138B40", Offset = "0x4137540", VA = "0x184138B40", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x422D660", Offset = "0x422C060", VA = "0x18422D660", Slot = "19")]
	[IteratorStateMachine(typeof(LEGEPBHINPE<, >.FMONEAPICLD))]
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x422E230", Offset = "0x422CC30", VA = "0x18422E230", Slot = "21")]
	public bool JMLDPKCDHNJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x422E730", Offset = "0x422D130", VA = "0x18422E730")]
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
			[Cpp2IlInjected.Address(RVA = "0x8C9DB0", Offset = "0x8C87B0", VA = "0x1808C9DB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x8CDB30", Offset = "0x8CC530", VA = "0x1808CDB30")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x8CD9C0", Offset = "0x8CC3C0", VA = "0x1808CD9C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public int LIFKLMGEOHM
		{
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x891F80", Offset = "0x890980", VA = "0x180891F80")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x891580", Offset = "0x88FF80", VA = "0x180891580")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public DateTimeOffset IGBDCDHLLLC
		{
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0xC358C0", Offset = "0xC342C0", VA = "0x180C358C0")]
			[CompilerGenerated]
			get
			{
				return default(DateTimeOffset);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x14DAFE0", Offset = "0x14D99E0", VA = "0x1814DAFE0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x3C7C8C0", Offset = "0x3C7B2C0", VA = "0x183C7C8C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x10707A0", Offset = "0x106F1A0", VA = "0x1810707A0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3ADCD40", Offset = "0x3ADB740", VA = "0x183ADCD40", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x85C1D0", Offset = "0x85ABD0", VA = "0x18085C1D0")]
		[DebuggerHidden]
		public NBBKFPMBLHI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x3982370", Offset = "0x3980D70", VA = "0x183982370", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x44F6AC0", Offset = "0x44F54C0", VA = "0x1844F6AC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x44F5FF0", Offset = "0x44F49F0", VA = "0x1844F5FF0")]
		private void CEOBCCLIKJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x44F71A0", Offset = "0x44F5BA0", VA = "0x1844F71A0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x8626D0", Offset = "0x8610D0", VA = "0x1808626D0")]
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
		[Cpp2IlInjected.Address(RVA = "0xB003E0", Offset = "0xAFEDE0", VA = "0x180B003E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0xAFFB00", Offset = "0xAFE500", VA = "0x180AFFB00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public int MELIDLJEANB
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x427A560", Offset = "0x4278F60", VA = "0x18427A560", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	internal int CGGDCHOJAEP
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x37DBBE0", Offset = "0x37DA5E0", VA = "0x1837DBBE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public ICollection<TVal> PGIKKFOHHOG
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x427A780", Offset = "0x4279180", VA = "0x18427A780", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	ICollection<TKey> IDictionary<TKey, TVal>.GJOLFMICFDB
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x4277310", Offset = "0x4275D10", VA = "0x184277310", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool HNPAFAKBDHK
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x89B1F0", Offset = "0x899BF0", VA = "0x18089B1F0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public TVal NBEMKGGOBKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x427A5F0", Offset = "0x4278FF0", VA = "0x18427A5F0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x427A7C0", Offset = "0x42791C0", VA = "0x18427A7C0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x4270710", Offset = "0x426F110", VA = "0x184270710")]
	private bool JAAPFGKMMDO(int HHGNDILCLEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x426BF30", Offset = "0x426A930", VA = "0x18426BF30")]
	private void DPCEDDJNEHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x42794C0", Offset = "0x4277EC0", VA = "0x1842794C0")]
	public LKJHFGDNFFP(int HHGNDILCLEE, [Optional] DMEMAHLHJCO? NLFLNFMHLBJ, [Optional] IEqualityComparer<TKey>? PMELJJPGANC, [Optional] KFPHOPMGLCO? DKBFFBLIJNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x4277FC0", Offset = "0x42769C0", VA = "0x184277FC0")]
	public LKJHFGDNFFP(TimeSpan OKBGHIHICMC, [Optional] IEqualityComparer<TKey>? PMELJJPGANC, [Optional] KFPHOPMGLCO? DKBFFBLIJNO, [Optional] FFIMJELAHLM? BKIGEIKCIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x4278570", Offset = "0x4276F70", VA = "0x184278570")]
	public LKJHFGDNFFP(int HHGNDILCLEE, TimeSpan OKBGHIHICMC, [Optional] IEqualityComparer<TKey>? PMELJJPGANC, [Optional] KFPHOPMGLCO? DKBFFBLIJNO, [Optional] FFIMJELAHLM? BKIGEIKCIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x4279F40", Offset = "0x4278940", VA = "0x184279F40")]
	public LKJHFGDNFFP(int HHGNDILCLEE, DMEMAHLHJCO? NLFLNFMHLBJ, TimeSpan OKBGHIHICMC, [Optional] IEqualityComparer<TKey>? PMELJJPGANC, [Optional] KFPHOPMGLCO? DKBFFBLIJNO, [Optional] FFIMJELAHLM? BKIGEIKCIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x4274040", Offset = "0x4272A40", VA = "0x184274040", Slot = "21")]
	public bool JMLDPKCDHNJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x4270450", Offset = "0x426EE50", VA = "0x184270450", Slot = "22")]
	public bool IJLBDKMCICC(int ECGAAJFODGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x426DD50", Offset = "0x426C750", VA = "0x18426DD50")]
	private bool IBFMCOCMGOF(int ECGAAJFODGN, JAEDDHFIPOE NPGFMGMHJJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x4275C10", Offset = "0x4274610", VA = "0x184275C10")]
	public void OLOHHMDPKEO(TKey NDDCLPHCEEO, TVal JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x42680F0", Offset = "0x4266AF0", VA = "0x1842680F0", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> JNHGHHKKNBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x42682C0", Offset = "0x4266CC0", VA = "0x1842682C0", Slot = "9")]
	public void Add(TKey NDDCLPHCEEO, TVal JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x4269C20", Offset = "0x4268620", VA = "0x184269C20", Slot = "8")]
	public bool ContainsKey(TKey NDDCLPHCEEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x42766E0", Offset = "0x42750E0", VA = "0x1842766E0", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Contains(KeyValuePair<TKey, TVal> JNHGHHKKNBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x4276250", Offset = "0x4274C50", VA = "0x184276250", Slot = "10")]
	public bool Remove(TKey NDDCLPHCEEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x4276DB0", Offset = "0x42757B0", VA = "0x184276DB0", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Remove(KeyValuePair<TKey, TVal> JNHGHHKKNBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x426D160", Offset = "0x426BB60", VA = "0x18426D160")]
	private bool FIHONAPKJEP(TKey NDDCLPHCEEO, [Out] TVal JMDCGOKJIDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x4273AB0", Offset = "0x42724B0", VA = "0x184273AB0")]
	private TVal JMJOGDIBBHK(TKey LEPFMLOCOKH)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x4277980", Offset = "0x4276380", VA = "0x184277980", Slot = "11")]
	public bool TryGetValue(TKey LEPFMLOCOKH, [Out] TVal JMDCGOKJIDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x4269A50", Offset = "0x4268450", VA = "0x184269A50", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x426B2A0", Offset = "0x4269CA0", VA = "0x18426B2A0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] PFKJAOOHGBN, int OMHDEOJLLBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x426B840", Offset = "0x426A240", VA = "0x18426B840")]
	private void DJLDEBECLKL(TKey NDDCLPHCEEO, TVal GPBAFILNEOM, JAEDDHFIPOE NPGFMGMHJJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x4270EE0", Offset = "0x426F8E0", VA = "0x184270EE0")]
	private bool JHIFPHEPNGG(AJPPGHNDOJF NMLMGAHKIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x4272770", Offset = "0x4271170", VA = "0x184272770")]
	private void JLBAEEEHCMK(LinkedListNode<AJPPGHNDOJF> MPCILHEMBHP, TVal BOKHJAMHCIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x4274E10", Offset = "0x4273810", VA = "0x184274E10")]
	private void MBCOGGKHPPK(TKey NDDCLPHCEEO, TVal JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x4268BE0", Offset = "0x42675E0", VA = "0x184268BE0")]
	private void COHOGNOBIJP(AJPPGHNDOJF NMLMGAHKIJF, TVal BOKHJAMHCIH, int OBMECBFGAAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x426D4A0", Offset = "0x426BEA0", VA = "0x18426D4A0", Slot = "19")]
	[IteratorStateMachine(typeof(LKJHFGDNFFP<, >.NBBKFPMBLHI))]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x4277350", Offset = "0x4275D50", VA = "0x184277350", Slot = "20")]
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
	[Cpp2IlInjected.Address(RVA = "0x37D3070", Offset = "0x37D1A70", VA = "0x1837D3070")]
	public ECICHACFBLB(TKey BAIMBONOPGC, Exception OKPGFIEKFIO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class IJJCLDKMOFD : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x5CEB6A0", Offset = "0x5CEA0A0", VA = "0x185CEB6A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public IHBCNHBCEIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x3E5A540", Offset = "0x3E58F40", VA = "0x183E5A540")]
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
		[Cpp2IlInjected.Address(RVA = "0x3EC33D0", Offset = "0x3EC1DD0", VA = "0x183EC33D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x3EC4070", Offset = "0x3EC2A70", VA = "0x183EC4070", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x5107110", Offset = "0x5105B10", VA = "0x185107110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x51074F0", Offset = "0x5105EF0", VA = "0x1851074F0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x3BDDC00", Offset = "0x3BDC600", VA = "0x183BDDC00")]
	public FILEOJEALJN(int AHECCPJHEFF = 0, [Optional] IEqualityComparer<TId>? HBCNIFLBHJC, [Optional] Func<TId, CancellationToken, Task<TResource>>? FLPMJCBHCGB, [Optional] Action<TResource>? ANFANOINHMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x3BDC700", Offset = "0x3BDB100", VA = "0x183BDC700")]
	public PIKIJNPLMPM<Task<TResource>> DIKBKFOJHON(TId DKFNFHGODON, [Optional] Func<TId, CancellationToken, Task<TResource>>? FLPMJCBHCGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x3BDD3D0", Offset = "0x3BDBDD0", VA = "0x183BDD3D0")]
	private void GLGFOCIIMBB(Task<TResource> LEDCCMOCHJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x3BDD910", Offset = "0x3BDC310", VA = "0x183BDD910")]
	[AsyncStateMachine(typeof(FILEOJEALJN<, >.IKMNIBOJEML))]
	private Task NABHHEPILNL(Task<TResource> LEDCCMOCHJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x3BDD130", Offset = "0x3BDBB30", VA = "0x183BDD130")]
	public void FIKAFFKAEHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x3BDC3A0", Offset = "0x3BDADA0", VA = "0x183BDC3A0")]
	public IDJKEBEHJMM<TId, Task<TResource>>.JIHOPMBIOGC DCPEOMEKOMK()
	{
		return default(IDJKEBEHJMM<TId, Task<TResource>>.JIHOPMBIOGC);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x3BDDB60", Offset = "0x3BDC560", VA = "0x183BDDB60", Slot = "4")]
	private IEnumerator<(TId, Task<TResource>, int)> System.Collections.Generic.IEnumerable<(TIdId,System.Threading.Tasks.Task<TResource>LoadResourceTask,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x3BDDB60", Offset = "0x3BDC560", VA = "0x183BDDB60", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x3BDCED0", Offset = "0x3BDB8D0", VA = "0x183BDCED0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9528A0", Offset = "0x9512A0", VA = "0x1809528A0")]
		public MINDGGBPNHG(TValue JMDCGOKJIDA, int ELDDLGIECEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x4495CD0", Offset = "0x44946D0", VA = "0x184495CD0", Slot = "4")]
		public bool Equals(MINDGGBPNHG? OKGBBGMIACH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x4495D60", Offset = "0x4494760", VA = "0x184495D60", Slot = "0")]
		public override bool Equals(object? MEAFIMADMKA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x4495FB0", Offset = "0x44949B0", VA = "0x184495FB0", Slot = "2")]
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
			[Cpp2IlInjected.Address(RVA = "0x409ED70", Offset = "0x409D770", VA = "0x18409ED70", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public (TKey Key, TValue Value, int RefCount) EBFPDFJFKPC
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x409F130", Offset = "0x409DB30", VA = "0x18409F130", Slot = "4")]
			get
			{
				return default((TKey, TValue, int));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x409EEC0", Offset = "0x409D8C0", VA = "0x18409EEC0")]
		public JIHOPMBIOGC(IDJKEBEHJMM<TKey, TValue> ENCKOMKBEOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x409E930", Offset = "0x409D330", VA = "0x18409E930", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x409E970", Offset = "0x409D370", VA = "0x18409E970", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x409EAE0", Offset = "0x409D4E0", VA = "0x18409EAE0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public LBKLPINBCNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x4226B90", Offset = "0x4225590", VA = "0x184226B90")]
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
	[Cpp2IlInjected.Address(RVA = "0x3E2BF80", Offset = "0x3E2A980", VA = "0x183E2BF80")]
	public IDJKEBEHJMM(int AHECCPJHEFF = 0, [Optional] IEqualityComparer<TKey>? PMELJJPGANC, [Optional] Func<TKey, TValue>? FLCCMAPPPLL, [Optional] Action<TValue>? PGMJHFAHFOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x3E2AAC0", Offset = "0x3E294C0", VA = "0x183E2AAC0")]
	public PIKIJNPLMPM<TValue> DIKBKFOJHON(TKey NDDCLPHCEEO, [Optional] Func<TKey, TValue>? DCGAOGMNBFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x3E2BA10", Offset = "0x3E2A410", VA = "0x183E2BA10")]
	private void NLCHOINDCPP(TKey NDDCLPHCEEO, MINDGGBPNHG IFHELEFLFHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x3E2B3D0", Offset = "0x3E29DD0", VA = "0x183E2B3D0")]
	public void FIKAFFKAEHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x3E2A6D0", Offset = "0x3E290D0", VA = "0x183E2A6D0")]
	public JIHOPMBIOGC DCPEOMEKOMK()
	{
		return default(JIHOPMBIOGC);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x3E2BE30", Offset = "0x3E2A830", VA = "0x183E2BE30", Slot = "4")]
	private IEnumerator<(TKey, TValue, int)> System.Collections.Generic.IEnumerable<(TKeyKey,TValueValue,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x3E2BE30", Offset = "0x3E2A830", VA = "0x183E2BE30", Slot = "5")]
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
