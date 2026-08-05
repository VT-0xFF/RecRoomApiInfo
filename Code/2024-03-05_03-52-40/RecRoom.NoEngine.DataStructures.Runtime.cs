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
		[Cpp2IlInjected.Address(RVA = "0x7E3470", Offset = "0x7E2270", VA = "0x1807E3470")]
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
		[Cpp2IlInjected.Address(RVA = "0x61886F0", Offset = "0x61874F0", VA = "0x1861886F0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7E43F0", Offset = "0x7E31F0", VA = "0x1807E43F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E4430", Offset = "0x7E3230", VA = "0x1807E4430")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class PNMECHGFGGI
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	protected PNMECHGFGGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class PMPLNHLOBMF<T> : PNMECHGFGGI
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	protected struct AJHIGNPGKGE
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public enum JHJAHFJNEIP
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
		public JHJAHFJNEIP LPFFKBBBCBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public T CJMBDOEJJJI;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private int LGGBIIKNPCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool HLPLKIDDFMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	protected readonly bool PKJAIEAPMLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	protected List<T>? CALPLJHIIJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<AJHIGNPGKGE>? MMAKBPHMLBK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool NMBPPPKHHGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x40C4D20", Offset = "0x40C3B20", VA = "0x1840C4D20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x40C5600", Offset = "0x40C4400", VA = "0x1840C5600")]
	protected PMPLNHLOBMF(bool PKJAIEAPMLN, bool HLPLKIDDFMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x40C4D70", Offset = "0x40C3B70", VA = "0x1840C4D70")]
	protected bool COIKJJNBHLE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x40C5380", Offset = "0x40C4180", VA = "0x1840C5380")]
	protected void JDAGDMBOEMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x40C4E10", Offset = "0x40C3C10", VA = "0x1840C4E10")]
	protected void EOMJJCFEIAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2698260", Offset = "0x2697060", VA = "0x182698260")]
	private static void LLPIMHDDFAP<U>(List<U>? MOAFNEBEDKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x40C51A0", Offset = "0x40C3FA0", VA = "0x1840C51A0", Slot = "4")]
	public void GALNLGNAACN(T CJMBDOEJJJI, bool COADGNCJCNP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x40C4FF0", Offset = "0x40C3DF0", VA = "0x1840C4FF0", Slot = "5")]
	public void FIJOKOAGLFM(T CJMBDOEJJJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x40C5480", Offset = "0x40C4280", VA = "0x1840C5480")]
	public void OCIHDBDLDKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface IGCDCOOAKBE
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GALNLGNAACN(Action CJMBDOEJJJI, bool COADGNCJCNP = false);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FIJOKOAGLFM(Action CJMBDOEJJJI);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class CGNODMPJOCB : PMPLNHLOBMF<Action>, IGCDCOOAKBE
{
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6185E30", Offset = "0x6184C30", VA = "0x186185E30")]
	public CGNODMPJOCB(bool PKJAIEAPMLN = false, bool HLPLKIDDFMN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6185B70", Offset = "0x6184970", VA = "0x186185B70")]
	public void HNBNIEBFDJB()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6185D70", Offset = "0x6184B70", VA = "0x186185D70")]
	public static CGNODMPJOCB LAOAHLPDKDH(CGNODMPJOCB AFNJOEINFHL, Action CJMBDOEJJJI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6185DD0", Offset = "0x6184BD0", VA = "0x186185DD0")]
	public static CGNODMPJOCB PMCFGOFDBNP(CGNODMPJOCB AFNJOEINFHL, Action CJMBDOEJJJI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface DOEDBAABKIE<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GALNLGNAACN(Action<T> CJMBDOEJJJI, bool COADGNCJCNP = false);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FIJOKOAGLFM(Action<T> CJMBDOEJJJI);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public sealed class AIHFEFKAOFF<T> : PMPLNHLOBMF<Action<T>>, DOEDBAABKIE<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x32AC270", Offset = "0x32AB070", VA = "0x1832AC270")]
	public AIHFEFKAOFF(bool PKJAIEAPMLN = false, bool HLPLKIDDFMN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x38C2F40", Offset = "0x38C1D40", VA = "0x1838C2F40")]
	public void HNBNIEBFDJB(T BHBDNAGLKEL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x32AC150", Offset = "0x32AAF50", VA = "0x1832AC150")]
	public static AIHFEFKAOFF<T> LAOAHLPDKDH(AIHFEFKAOFF<T> AFNJOEINFHL, Action<T> CJMBDOEJJJI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x32AC1E0", Offset = "0x32AAFE0", VA = "0x1832AC1E0")]
	public static AIHFEFKAOFF<T> PMCFGOFDBNP(AIHFEFKAOFF<T> AFNJOEINFHL, Action<T> CJMBDOEJJJI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface MDKGNBOKMMG<T, U> where T : notnull where U : notnull
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class EKPMNGLHMHM<T, U> : PMPLNHLOBMF<Action<T, U>>, MDKGNBOKMMG<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x32AC270", Offset = "0x32AB070", VA = "0x1832AC270")]
	public EKPMNGLHMHM(bool PKJAIEAPMLN = false, bool HLPLKIDDFMN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x32ABDF0", Offset = "0x32AABF0", VA = "0x1832ABDF0")]
	public void HNBNIEBFDJB(T BHBDNAGLKEL, U IOAGJOKPHPD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x32AC150", Offset = "0x32AAF50", VA = "0x1832AC150")]
	public static EKPMNGLHMHM<T, U> LAOAHLPDKDH(EKPMNGLHMHM<T, U> AFNJOEINFHL, Action<T, U> CJMBDOEJJJI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x32AC1E0", Offset = "0x32AAFE0", VA = "0x1832AC1E0")]
	public static EKPMNGLHMHM<T, U> PMCFGOFDBNP(EKPMNGLHMHM<T, U> AFNJOEINFHL, Action<T, U> CJMBDOEJJJI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class KJAEILIDEKD<T, U, V> : PMPLNHLOBMF<Action<T, U, V>> where T : notnull where U : notnull where V : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x32AC270", Offset = "0x32AB070", VA = "0x1832AC270")]
	public KJAEILIDEKD(bool PKJAIEAPMLN = false, bool HLPLKIDDFMN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3B22480", Offset = "0x3B21280", VA = "0x183B22480")]
	public void HNBNIEBFDJB(T BHBDNAGLKEL, U IOAGJOKPHPD, V FJKGEGOOFKM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x32AC150", Offset = "0x32AAF50", VA = "0x1832AC150")]
	public static KJAEILIDEKD<T, U, V> LAOAHLPDKDH(KJAEILIDEKD<T, U, V> AFNJOEINFHL, Action<T, U, V> CJMBDOEJJJI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x32AC1E0", Offset = "0x32AAFE0", VA = "0x1832AC1E0")]
	public static KJAEILIDEKD<T, U, V> PMCFGOFDBNP(KJAEILIDEKD<T, U, V> AFNJOEINFHL, Action<T, U, V> CJMBDOEJJJI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface NKGHJKELJCB<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class MPANJACMMGO<T, U, V, W> : PMPLNHLOBMF<Action<T, U, V, W>>, NKGHJKELJCB<T, U, V, W> where T : notnull where U : notnull where V : notnull where W : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x32AC270", Offset = "0x32AB070", VA = "0x1832AC270")]
	public MPANJACMMGO(bool PKJAIEAPMLN = false, bool HLPLKIDDFMN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3E37A40", Offset = "0x3E36840", VA = "0x183E37A40")]
	public void HNBNIEBFDJB(T BHBDNAGLKEL, U IOAGJOKPHPD, V FJKGEGOOFKM, W LFPADPMEJPL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x32AC150", Offset = "0x32AAF50", VA = "0x1832AC150")]
	public static MPANJACMMGO<T, U, V, W> LAOAHLPDKDH(MPANJACMMGO<T, U, V, W> AFNJOEINFHL, Action<T, U, V, W> CJMBDOEJJJI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x32AC1E0", Offset = "0x32AAFE0", VA = "0x1832AC1E0")]
	public static MPANJACMMGO<T, U, V, W> PMCFGOFDBNP(MPANJACMMGO<T, U, V, W> AFNJOEINFHL, Action<T, U, V, W> CJMBDOEJJJI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class GBNOENNGKNO<T, U, V, W, X> : PMPLNHLOBMF<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x32AC270", Offset = "0x32AB070", VA = "0x1832AC270")]
	public GBNOENNGKNO(bool PKJAIEAPMLN = false, bool HLPLKIDDFMN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x36E3550", Offset = "0x36E2350", VA = "0x1836E3550")]
	public void HNBNIEBFDJB(T BHBDNAGLKEL, U IOAGJOKPHPD, V FJKGEGOOFKM, W LFPADPMEJPL, X BJKAJHEJDMP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x32AC150", Offset = "0x32AAF50", VA = "0x1832AC150")]
	public static GBNOENNGKNO<T, U, V, W, X> LAOAHLPDKDH(GBNOENNGKNO<T, U, V, W, X> AFNJOEINFHL, Action<T, U, V, W, X> CJMBDOEJJJI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x32AC1E0", Offset = "0x32AAFE0", VA = "0x1832AC1E0")]
	public static GBNOENNGKNO<T, U, V, W, X> PMCFGOFDBNP(GBNOENNGKNO<T, U, V, W, X> AFNJOEINFHL, Action<T, U, V, W, X> CJMBDOEJJJI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class IOHHLOMPDOI<T, U, V, W, X, Y> : PMPLNHLOBMF<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x32AC270", Offset = "0x32AB070", VA = "0x1832AC270")]
	public IOHHLOMPDOI(bool PKJAIEAPMLN = false, bool HLPLKIDDFMN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x38A26F0", Offset = "0x38A14F0", VA = "0x1838A26F0")]
	public void HNBNIEBFDJB(T BHBDNAGLKEL, U IOAGJOKPHPD, V FJKGEGOOFKM, W LFPADPMEJPL, X BJKAJHEJDMP, Y FPNMMAJHCIF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x32AC150", Offset = "0x32AAF50", VA = "0x1832AC150")]
	public static IOHHLOMPDOI<T, U, V, W, X, Y> LAOAHLPDKDH(IOHHLOMPDOI<T, U, V, W, X, Y> AFNJOEINFHL, Action<T, U, V, W, X, Y> CJMBDOEJJJI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x32AC1E0", Offset = "0x32AAFE0", VA = "0x1832AC1E0")]
	public static IOHHLOMPDOI<T, U, V, W, X, Y> PMCFGOFDBNP(IOHHLOMPDOI<T, U, V, W, X, Y> AFNJOEINFHL, Action<T, U, V, W, X, Y> CJMBDOEJJJI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class JGLCBCGDGPB<TKey, TVal> where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly GOLHBDPOKKL<TKey, TVal> BLBMIANIHLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly Dictionary<TKey, (TVal value, int size)> BIELCJMGAPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly int LFGDMCKEHAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly GOLHBDPOKKL<TKey, TVal>.MKJDLFFLPKH? CDOCHKBEDKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private int KHPPNIKNHGC;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal int COJAKAIMJJC
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3A5BC00", Offset = "0x3A5AA00", VA = "0x183A5BC00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int LACGIBAEEFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x91FAD0", Offset = "0x91E8D0", VA = "0x18091FAD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3A5C110", Offset = "0x3A5AF10", VA = "0x183A5C110")]
	public JGLCBCGDGPB(int LFGDMCKEHAN, [Optional] GOLHBDPOKKL<TKey, TVal>.MKJDLFFLPKH? CDOCHKBEDKH, [Optional] IEqualityComparer<TKey>? NIACMHLGFMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3A5BDB0", Offset = "0x3A5ABB0", VA = "0x183A5BDB0")]
	public void NIAPBJHAFPN(TKey ONOECNHBCDA, TVal MAEBFBHFPDE, bool HFEHHDPABBF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3A5BC50", Offset = "0x3A5AA50", VA = "0x183A5BC50")]
	public bool LCLBGIPPDFN(TKey ONOECNHBCDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3A5BB20", Offset = "0x3A5A920", VA = "0x183A5BB20")]
	public bool EMHKBCLCPNM(TKey MIEIIDHDNFL, [Out] TVal MAEBFBHFPDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3A5B900", Offset = "0x3A5A700", VA = "0x183A5B900")]
	private void BJCIIKHPBPL(TKey ONOECNHBCDA, TVal MAEBFBHFPDE, int JEOEJJBKODC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3A5BF80", Offset = "0x3A5AD80", VA = "0x183A5BF80")]
	public bool NNIFPHJGPDA(TKey ONOECNHBCDA, TVal MAEBFBHFPDE, bool HFEHHDPABBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3A5BCF0", Offset = "0x3A5AAF0", VA = "0x183A5BCF0")]
	private bool MBCGFNFLHLD(TKey ONOECNHBCDA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class FLJNCHGFOKM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly Action OKIBAAHDHKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private bool IKBCNICKLMA;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7C8480", Offset = "0x7C7280", VA = "0x1807C8480")]
	public FLJNCHGFOKM(Action AMBAFDPADKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6186E20", Offset = "0x6185C20", VA = "0x186186E20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2732F10", Offset = "0x2731D10", VA = "0x182732F10")]
	public static LOHPMIAJHKJ<T> KNBFKAAGFFE<T>(T MAEBFBHFPDE, Action AMBAFDPADKK) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class LOHPMIAJHKJ<T> : FLJNCHGFOKM where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public T CIONEDGAKHL
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7B8B60", Offset = "0x7B7960", VA = "0x1807B8B60")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3C461E0", Offset = "0x3C44FE0", VA = "0x183C461E0")]
	public LOHPMIAJHKJ(T MAEBFBHFPDE, Action AMBAFDPADKK)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct KCKOIHMNECF : IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct KKJBEBBGEIF : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x801AA0", Offset = "0x8008A0", VA = "0x180801AA0")]
		public static KKJBEBBGEIF IKCDCJJCDKO()
		{
			return default(KKJBEBBGEIF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x801AA0", Offset = "0x8008A0", VA = "0x180801AA0")]
	public static KCKOIHMNECF KHOJGIEPAJJ(Type LPFFKBBBCBL, [Optional] string? IFFFGGGLFGO, [Optional] string? JDKGCLPANKF, bool MJDNFCLHLCG = false)
	{
		return default(KCKOIHMNECF);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x801AA0", Offset = "0x8008A0", VA = "0x180801AA0")]
	public static KCKOIHMNECF KHOJGIEPAJJ<T>([Optional] string? IFFFGGGLFGO, [Optional] string? JDKGCLPANKF, bool MJDNFCLHLCG = false)
	{
		return default(KCKOIHMNECF);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct HPAOIMDDOHC
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate bool JLEBCCNMJAM(string CNAHGOPJMCG, HPAOIMDDOHC HIHHFEPOEPE);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public int HNNEPCFDHAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public string PABGBGGAHDE;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6187220", Offset = "0x6186020", VA = "0x186187220")]
	public static Dictionary<string, HPAOIMDDOHC> DAHEMAHEDND(Type KOMADIOKPDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6186E60", Offset = "0x6185C60", VA = "0x186186E60")]
	public static Dictionary<string, HPAOIMDDOHC> CEJDKIGMHAG(Type KOMADIOKPDI, JLEBCCNMJAM IMKKLMNCEPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6187550", Offset = "0x6186350", VA = "0x186187550")]
	public static Dictionary<int, string> EEAAOGHAGJG(Dictionary<string, HPAOIMDDOHC> CCBBNNMCBIL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class NLLFNEOCDJB : NCKLHJJKDCC
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public static bool PIILALBOECA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly string? DIAJPNMBEBO;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public virtual NCKLHJJKDCC? NGLNKPGOLIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7BADE0", Offset = "0x7B9BE0", VA = "0x1807BADE0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6188680", Offset = "0x6187480", VA = "0x186188680")]
	protected NLLFNEOCDJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string LFKJGAHPPDN();

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6188440", Offset = "0x6187240", VA = "0x186188440", Slot = "8")]
	public virtual string IHHHACKPFHM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6187FD0", Offset = "0x6186DD0", VA = "0x186187FD0", Slot = "9")]
	public void DAFJHDFICAA(StringBuilder GNKEDKBIMAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6188620", Offset = "0x6187420", VA = "0x186188620", Slot = "10")]
	public void ONHIELOBHDM(StringBuilder GNKEDKBIMAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6188320", Offset = "0x6187120", VA = "0x186188320", Slot = "11")]
	public void HIDCFAPGKFA(StringBuilder GNKEDKBIMAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x61884C0", Offset = "0x61872C0", VA = "0x1861884C0", Slot = "12")]
	public void NEBHJODDKLA(StringBuilder GNKEDKBIMAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6188280", Offset = "0x6187080", VA = "0x186188280")]
	public static void GHOPCPDEKJC(StringBuilder GNKEDKBIMAC, string FCPJJBHPCDL, string EFDHFEKLJCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x53F3850", Offset = "0x53F2650", VA = "0x1853F3850", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class MLNJEENOACD : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6187F20", Offset = "0x6186D20", VA = "0x186187F20")]
	public MLNJEENOACD(string LJCDGDONMLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class KKJBOCICJOK<TErr> : MLNJEENOACD where TErr : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly TErr IFJMJHNLPHI;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3B26A60", Offset = "0x3B25860", VA = "0x183B26A60")]
	private KKJBOCICJOK([In] TErr BJGICADCANP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3B26990", Offset = "0x3B25790", VA = "0x183B26990")]
	public static KKJBOCICJOK<TErr> IKCDCJJCDKO([In] TErr BJGICADCANP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface NCKLHJJKDCC
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string IHHHACKPFHM();

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string LFKJGAHPPDN();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface IGACGHIPBKF<out TOptions> where TOptions : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	TOptions CIONEDGAKHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface EADHOHOCBPN
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	string CCDCOOPFJHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class FJILGNLBGMP : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6186DC0", Offset = "0x6185BC0", VA = "0x186186DC0")]
	public FJILGNLBGMP(string LJCDGDONMLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class GCHPFCICGLG<TOk> : FJILGNLBGMP where TOk : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly TOk AOKFGPEDNEK;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x36E3C60", Offset = "0x36E2A60", VA = "0x1836E3C60")]
	private GCHPFCICGLG([In] TOk IDAEPBMNFIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x36E39B0", Offset = "0x36E27B0", VA = "0x1836E39B0")]
	public static GCHPFCICGLG<TOk> IKCDCJJCDKO([In] TOk IDAEPBMNFIG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public readonly struct BOHHCOEKANF<TOk, TErr> : IEquatable<BOHHCOEKANF<TOk, TErr>> where TOk : notnull where TErr : notnull
{
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private static readonly EqualityComparer<TErr> KFPAGHPFCOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal readonly TErr IFJMJHNLPHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal readonly TOk AOKFGPEDNEK;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool DMNJBAOOGGA
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x48B7C90", Offset = "0x48B6A90", VA = "0x1848B7C90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool LEEECJFLHNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x48B76C0", Offset = "0x48B64C0", VA = "0x1848B76C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x48BAE00", Offset = "0x48B9C00", VA = "0x1848BAE00")]
	internal BOHHCOEKANF([In] TErr BJGICADCANP, [In] TOk IDAEPBMNFIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x48B6F50", Offset = "0x48B5D50", VA = "0x1848B6F50")]
	public static BOHHCOEKANF<TOk, TErr> IFMFMODKBOA([In] TErr BJGICADCANP)
	{
		return default(BOHHCOEKANF<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x48B3CB0", Offset = "0x48B2AB0", VA = "0x1848B3CB0")]
	public static BOHHCOEKANF<TOk, TErr> CHIFMOFFCKF([In] TOk IDAEPBMNFIG)
	{
		return default(BOHHCOEKANF<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x229F8B0", Offset = "0x229E6B0", VA = "0x18229F8B0")]
	public BOHHCOEKANF<TOk?, UErr?> NPMENALPEEG<UErr>()
	{
		return default(BOHHCOEKANF<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x229F460", Offset = "0x229E260", VA = "0x18229F460")]
	public BOHHCOEKANF<UOk?, TErr?> IBKOBPDOAGE<UOk>()
	{
		return default(BOHHCOEKANF<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x229E7E0", Offset = "0x229D5E0", VA = "0x18229E7E0")]
	public BOHHCOEKANF<UOk?, TErr?> BEHMDPPLMEG<UOk>()
	{
		return default(BOHHCOEKANF<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x229EF10", Offset = "0x229DD10", VA = "0x18229EF10")]
	public BOHHCOEKANF<TOk?, UErr?> EPPKGCOAODB<UErr>()
	{
		return default(BOHHCOEKANF<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x48B82C0", Offset = "0x48B70C0", VA = "0x1848B82C0")]
	public BOHHCOEKANF<CFLPFJJKMFI, TErr> OLJCFFDHBHO()
	{
		return default(BOHHCOEKANF<CFLPFJJKMFI, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x48B4DB0", Offset = "0x48B3BB0", VA = "0x1848B4DB0")]
	public static bool EILLJGMDDAM([In] BOHHCOEKANF<TOk, TErr> LDPIALBNJEB, [In] BOHHCOEKANF<TOk, TErr> HLCIAKLFNHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x48B5610", Offset = "0x48B4410", VA = "0x1848B5610", Slot = "4")]
	public bool Equals(BOHHCOEKANF<TOk, TErr> EDOEJIMPOFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x48B5AD0", Offset = "0x48B48D0", VA = "0x1848B5AD0", Slot = "0")]
	public override bool Equals(object EDOEJIMPOFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x48B6CF0", Offset = "0x48B5AF0", VA = "0x1848B6CF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x48BA590", Offset = "0x48B9390", VA = "0x1848BA590", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class HLJOBBPANDI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private struct MCKBCFBKMKG<TOk, TErr> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public AsyncTaskMethodBuilder<TOk> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public Task<BOHHCOEKANF<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private TaskAwaiter<BOHHCOEKANF<TOk, TErr>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x3E0A890", Offset = "0x3E09690", VA = "0x183E0A890", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x3E0ABB0", Offset = "0x3E099B0", VA = "0x183E0ABB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2769680", Offset = "0x2768480", VA = "0x182769680")]
	public static BOHHCOEKANF<TOk?, TErr?> AOKFGPEDNEK<TOk, TErr>([In] this BOHHCOEKANF<TOk, TErr> OELHNDCFEMO, [In] TOk IDAEPBMNFIG)
	{
		return default(BOHHCOEKANF<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2769750", Offset = "0x2768550", VA = "0x182769750")]
	public static BOHHCOEKANF<CFLPFJJKMFI, TErr?> AOKFGPEDNEK<TErr>([In] this BOHHCOEKANF<CFLPFJJKMFI, TErr> OELHNDCFEMO)
	{
		return default(BOHHCOEKANF<CFLPFJJKMFI, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2769680", Offset = "0x2768480", VA = "0x182769680")]
	public static BOHHCOEKANF<TOk?, TErr?> IFJMJHNLPHI<TOk, TErr>([In] this BOHHCOEKANF<TOk, TErr> OELHNDCFEMO, [In] TErr BJGICADCANP)
	{
		return default(BOHHCOEKANF<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x276A130", Offset = "0x2768F30", VA = "0x18276A130")]
	public static TOk? FGLKICKPMHJ<TOk, TErr>([In] this BOHHCOEKANF<TOk, TErr> OELHNDCFEMO)
	{
		return (TOk?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2769B50", Offset = "0x2768950", VA = "0x182769B50")]
	[AsyncStateMachine(typeof(MCKBCFBKMKG<, >))]
	public static Task<TOk?>? EBKNCKNEDBA<TOk, TErr>(this Task<BOHHCOEKANF<TOk, TErr>> OELHNDCFEMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x276A620", Offset = "0x2769420", VA = "0x18276A620")]
	public static TErr? FKAHDDPJIFD<TErr, TOk>([In] this BOHHCOEKANF<TOk, TErr> OELHNDCFEMO)
	{
		return (TErr?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x276A970", Offset = "0x2769770", VA = "0x18276A970")]
	public static bool MHPFIHFMNMA<TOk, TErr, UErr, UOk>([In] this BOHHCOEKANF<TOk, TErr> OELHNDCFEMO, [Out] BOHHCOEKANF<UOk, UErr> FNJCKGAFLIC) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2769DF0", Offset = "0x2768BF0", VA = "0x182769DF0")]
	public static bool ECEEBNKCMOL<TOk, TErr>([In] this BOHHCOEKANF<TOk, TErr> OELHNDCFEMO, [Out][NotNullWhen(true)] TOk IDAEPBMNFIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x276C350", Offset = "0x276B150", VA = "0x18276C350")]
	public static bool OCOPKLIIEAL<TOk, TErr>([In] this BOHHCOEKANF<TOk, TErr> OELHNDCFEMO, [Out][NotNullWhen(true)] TErr BJGICADCANP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x276A780", Offset = "0x2769580", VA = "0x18276A780")]
	public static bool KDIIKEJPBKM<TOk, TErr>([In] this BOHHCOEKANF<TOk, TErr> OELHNDCFEMO, [Out][NotNullWhen(true)] TOk IDAEPBMNFIG, [Out][NotNullWhen(false)] TErr BJGICADCANP) where TOk : notnull where TErr : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x276A870", Offset = "0x2769670", VA = "0x18276A870")]
	public static bool KFEEMJAOCCF<TOk, TErr>([In] this BOHHCOEKANF<TOk, TErr> OELHNDCFEMO, [Out][NotNullWhen(true)] TOk IDAEPBMNFIG, [Out] BOHHCOEKANF<TOk, TErr> FNJCKGAFLIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x276ACC0", Offset = "0x2769AC0", VA = "0x18276ACC0")]
	public static bool MHPFIHFMNMA<TOk, TErr, UErr, UOk>([In] this BOHHCOEKANF<TOk, TErr> OELHNDCFEMO, [Out][NotNullWhen(true)] TOk IDAEPBMNFIG, [Out] BOHHCOEKANF<UOk, UErr> FNJCKGAFLIC) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x276BFF0", Offset = "0x276ADF0", VA = "0x18276BFF0")]
	public static bool NAPIAODGCAL<TOk, TErr>([In] this BOHHCOEKANF<TOk, TErr> OELHNDCFEMO, [Out][NotNullWhen(true)] TOk IDAEPBMNFIG, [Out] BOHHCOEKANF<CFLPFJJKMFI, TErr> FNJCKGAFLIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x276BD10", Offset = "0x276AB10", VA = "0x18276BD10")]
	public static BOHHCOEKANF<UOk, UErr> MOFMFBLBLBJ<UOk, UErr, TOk, TErr>([In] this BOHHCOEKANF<TOk, TErr> OELHNDCFEMO, [In] BOHHCOEKANF<UOk, UErr> FGIPEOJEGND) where TOk : UOk where TErr : UErr
	{
		return default(BOHHCOEKANF<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x2769810", Offset = "0x2768610", VA = "0x182769810")]
	public static BOHHCOEKANF<TOk?[]?, TErr?> BPILJMDJFFP<TOk, TErr>(this IEnumerable<BOHHCOEKANF<TOk, TErr>> OELHNDCFEMO)
	{
		return default(BOHHCOEKANF<TOk[], TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class BCIADAHMBPB<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x229D950", Offset = "0x229C750", VA = "0x18229D950")]
	public static BOHHCOEKANF<TOk, T> AOKFGPEDNEK<TOk>([In] TOk IDAEPBMNFIG) where TOk : notnull
	{
		return default(BOHHCOEKANF<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x4768030", Offset = "0x4766E30", VA = "0x184768030")]
	public static BOHHCOEKANF<CFLPFJJKMFI, T> AOKFGPEDNEK()
	{
		return default(BOHHCOEKANF<CFLPFJJKMFI, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x229D950", Offset = "0x229C750", VA = "0x18229D950")]
	public static BOHHCOEKANF<T, TErr> IFJMJHNLPHI<TErr>([In] TErr BJGICADCANP) where TErr : notnull
	{
		return default(BOHHCOEKANF<T, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[DefaultMember("Item")]
public sealed class HEPCLJLOAPE<T> : IEnumerable<T>, IEnumerable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	private readonly struct FJGFEAECABF : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly HEPCLJLOAPE<T> IENLMEMGLFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly int CNMPLBKBFFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly bool NKCGKBLECGB;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x1CB8A30", Offset = "0x1CB7830", VA = "0x181CB8A30")]
		public FJGFEAECABF(HEPCLJLOAPE<T> EJHNGBHNBFP, int EDMEAIIPJFK, bool KEGGJONIKFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x3613FC0", Offset = "0x3612DC0", VA = "0x183613FC0")]
		public HEPCLJLOAPE<T>.PDLFIDBJLHI GGNEAJGHJIC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x36140B0", Offset = "0x3612EB0", VA = "0x1836140B0", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x36140B0", Offset = "0x3612EB0", VA = "0x1836140B0", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public sealed class PDLFIDBJLHI : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly HEPCLJLOAPE<T> IENLMEMGLFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly int OHFJAHOACLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private int FBJKKAIPHPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private readonly bool NKCGKBLECGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private bool IEELINMEHIL;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public T OGCIBGAMGCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x409B1B0", Offset = "0x4099FB0", VA = "0x18409B1B0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x409B320", Offset = "0x409A120", VA = "0x18409B320", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x409B390", Offset = "0x409A190", VA = "0x18409B390", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x409B7F0", Offset = "0x409A5F0", VA = "0x18409B7F0")]
		public PDLFIDBJLHI(HEPCLJLOAPE<T> EJHNGBHNBFP, int EDMEAIIPJFK, bool KEGGJONIKFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x409B230", Offset = "0x409A030", VA = "0x18409B230", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x409B2C0", Offset = "0x409A0C0", VA = "0x18409B2C0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class HOBJABICOJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		public HOBJABICOJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x37D9CC0", Offset = "0x37D8AC0", VA = "0x1837D9CC0")]
		internal T PGMNNJIKNNC(int _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly T[] EOCFJLHLPIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private int FBJKKAIPHPA;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int APIMOAHGOPI
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x37AE510", Offset = "0x37AD310", VA = "0x1837AE510")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public T OGCIBGAMGCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x35E9F90", Offset = "0x35E8D90", VA = "0x1835E9F90")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public T JNLGPAPFKNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x37AE210", Offset = "0x37AD010", VA = "0x1837AE210")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public T GKAMGCEMFBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x37AE300", Offset = "0x37AD100", VA = "0x1837AE300")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int EINKGEEBGAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x16C6500", Offset = "0x16C5300", VA = "0x1816C6500")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0xF9DDE0", Offset = "0xF9CBE0", VA = "0x180F9DDE0")]
	private static int LHAHKJCFIHN(int OHINPGIGDNE, int AKCMMEDPGHB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x37AE820", Offset = "0x37AD620", VA = "0x1837AE820")]
	public HEPCLJLOAPE(int JEOEJJBKODC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x37AE560", Offset = "0x37AD360", VA = "0x1837AE560")]
	public HEPCLJLOAPE(int JEOEJJBKODC, Func<T> DFOFPNIDGHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x37AE890", Offset = "0x37AD690", VA = "0x1837AE890")]
	public HEPCLJLOAPE(T[] EGCLMNAPIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x37AE240", Offset = "0x37AD040", VA = "0x1837AE240")]
	public void FGLMJPBOLDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x37AE450", Offset = "0x37AD250", VA = "0x1837AE450")]
	public IEnumerable<T> LCDDHIIELLD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x37AE270", Offset = "0x37AD070", VA = "0x1837AE270")]
	public HEPCLJLOAPE<T>.PDLFIDBJLHI GGNEAJGHJIC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x369DD50", Offset = "0x369CB50", VA = "0x18369DD50", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x369DD50", Offset = "0x369CB50", VA = "0x18369DD50", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public static class CGMBIEDOGNE
{
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x258FE00", Offset = "0x258EC00", VA = "0x18258FE00")]
	public static HEPCLJLOAPE<T> IKCDCJJCDKO<T>(int JEOEJJBKODC, Func<T> DFOFPNIDGHE) where T : notnull
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
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private const float kEpsilon = 1E-05f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public float r;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public float g;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public float b;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public float a;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x1DA06C0", Offset = "0x1D9F4C0", VA = "0x181DA06C0")]
		public RRColor(float HLPGBAHMLPL, float OGBLOILFBDF, float FNDBFMFAGPH, float AOHIFIJNOBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x61889D0", Offset = "0x61877D0", VA = "0x1861889D0", Slot = "4")]
		public bool Equals(RRColor EDOEJIMPOFP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6188A50", Offset = "0x6187850", VA = "0x186188A50", Slot = "0")]
		public override bool Equals(object EDOEJIMPOFP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6188B50", Offset = "0x6187950", VA = "0x186188B50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6188BD0", Offset = "0x61879D0", VA = "0x186188BD0", Slot = "5")]
		public string ToString(string JNKFGFMNPLJ, IFormatProvider OCFKLIPGOAM)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public sealed class JCCLOHPKMIE<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public readonly struct JPGLHFKDKKK : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private readonly JCCLOHPKMIE<T> ODDHEKAPKKE;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public T CIONEDGAKHL
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x3A87DB0", Offset = "0x3A86BB0", VA = "0x183A87DB0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x3A87D80", Offset = "0x3A86B80", VA = "0x183A87D80", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x9288D0", Offset = "0x9276D0", VA = "0x1809288D0")]
		public JPGLHFKDKKK(JCCLOHPKMIE<T> ODDHEKAPKKE)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct AINLPDAOCBK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public AsyncTaskMethodBuilder<JPGLHFKDKKK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public JCCLOHPKMIE<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x38C4400", Offset = "0x38C3200", VA = "0x1838C4400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x3092BC0", Offset = "0x30919C0", VA = "0x183092BC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly SemaphoreSlim NJODCKGPJEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private T KLLBKOCNIMJ;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3A4FB80", Offset = "0x3A4E980", VA = "0x183A4FB80")]
	public JCCLOHPKMIE([In] T KLLBKOCNIMJ, int ACJNCPGHLMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3A4FB60", Offset = "0x3A4E960", VA = "0x183A4FB60")]
	public JCCLOHPKMIE([In] T KLLBKOCNIMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3A4F660", Offset = "0x3A4E460", VA = "0x183A4F660", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3A4FB00", Offset = "0x3A4E900", VA = "0x183A4FB00")]
	public JPGLHFKDKKK NDMANGDKGKN()
	{
		return default(JPGLHFKDKKK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3A4F680", Offset = "0x3A4E480", VA = "0x183A4F680")]
	[AsyncStateMachine(typeof(JCCLOHPKMIE<>.AINLPDAOCBK))]
	public Task<JCCLOHPKMIE<T>.JPGLHFKDKKK> IEDICMEBOPN(CancellationToken MBHHHCCHBAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x3A4FB40", Offset = "0x3A4E940", VA = "0x183A4FB40")]
	public void NOMOIBCFALN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class CLEFJBNHIEJ
{
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6185E90", Offset = "0x6184C90", VA = "0x186185E90")]
	public static JCCLOHPKMIE<CFLPFJJKMFI> IKCDCJJCDKO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x25947E0", Offset = "0x25935E0", VA = "0x1825947E0")]
	public static JCCLOHPKMIE<T> IKCDCJJCDKO<T>([In] T KLLBKOCNIMJ) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public sealed class LINIABMOEMG<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public readonly struct LGLFBLCECEE : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly LINIABMOEMG<T> BHHLPLBFIOC;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public T CIONEDGAKHL
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x3A73020", Offset = "0x3A71E20", VA = "0x183A73020")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x3C1A490", Offset = "0x3C19290", VA = "0x183C1A490", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x9288D0", Offset = "0x9276D0", VA = "0x1809288D0")]
		internal LGLFBLCECEE(LINIABMOEMG<T> ODDHEKAPKKE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public readonly struct JMCHFBNALLL : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly LINIABMOEMG<T> BHHLPLBFIOC;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public T CIONEDGAKHL
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x3A73020", Offset = "0x3A71E20", VA = "0x183A73020")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x3A72F30", Offset = "0x3A71D30", VA = "0x183A72F30", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x9288D0", Offset = "0x9276D0", VA = "0x1809288D0")]
		internal JMCHFBNALLL(LINIABMOEMG<T> ODDHEKAPKKE)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct DDPACKKOCNB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public AsyncTaskMethodBuilder<JMCHFBNALLL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public LINIABMOEMG<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private JCCLOHPKMIE<CFLPFJJKMFI>.JPGLHFKDKKK <writeLock>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter<JCCLOHPKMIE<CFLPFJJKMFI>.JPGLHFKDKKK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x5028E80", Offset = "0x5027C80", VA = "0x185028E80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x3092BC0", Offset = "0x30919C0", VA = "0x183092BC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly JCCLOHPKMIE<int> HJKPGJNGKLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly JCCLOHPKMIE<CFLPFJJKMFI> LOBHCFEIJOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly JCCLOHPKMIE<CFLPFJJKMFI> LNJHOFCDOLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private T BHIMADODMII;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x3C1E190", Offset = "0x3C1CF90", VA = "0x183C1E190")]
	internal LINIABMOEMG(JCCLOHPKMIE<int> OKLLOBOGPPJ, JCCLOHPKMIE<CFLPFJJKMFI> HLNGLJGNEEG, JCCLOHPKMIE<CFLPFJJKMFI> IGEONDIHNJH, [In] T KLLBKOCNIMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x3C1DA30", Offset = "0x3C1C830", VA = "0x183C1DA30", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x3C1D5B0", Offset = "0x3C1C3B0", VA = "0x183C1D5B0")]
	public LGLFBLCECEE BLJDLJPIDLI()
	{
		return default(LGLFBLCECEE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x3C1DBA0", Offset = "0x3C1C9A0", VA = "0x183C1DBA0")]
	public JMCHFBNALLL IAJGBDBCFBH()
	{
		return default(JMCHFBNALLL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x3C1DFE0", Offset = "0x3C1CDE0", VA = "0x183C1DFE0")]
	[AsyncStateMachine(typeof(LINIABMOEMG<>.DDPACKKOCNB))]
	public Task<LINIABMOEMG<T>.JMCHFBNALLL> KFEOPBEHOMB(CancellationToken MBHHHCCHBAO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class DKECGIAOBGC
{
	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x6186820", Offset = "0x6185620", VA = "0x186186820")]
	public static LINIABMOEMG<CFLPFJJKMFI> IKCDCJJCDKO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x25C24D0", Offset = "0x25C12D0", VA = "0x1825C24D0")]
	public static LINIABMOEMG<T> IKCDCJJCDKO<T>([In] T KLLBKOCNIMJ) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public sealed class APCNBBBHEJC<TData> : NLLFNEOCDJB where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly string OEIBPMLCGID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly TData LBOALCIJNPP;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7B8F10", Offset = "0x7B7D10", VA = "0x1807B8F10", Slot = "7")]
	public override string LFKJGAHPPDN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x39AC4F0", Offset = "0x39AB2F0", VA = "0x1839AC4F0")]
	internal APCNBBBHEJC(string LJCDGDONMLD, [In] TData EEDANCJJEPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class PDNBGCHMJJN
{
	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x61888A0", Offset = "0x61876A0", VA = "0x1861888A0")]
	public static APCNBBBHEJC<CFLPFJJKMFI> IKCDCJJCDKO(string LJCDGDONMLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x2732F10", Offset = "0x2731D10", VA = "0x182732F10")]
	public static APCNBBBHEJC<TData> IKCDCJJCDKO<TData>(string LJCDGDONMLD, [In] TData EEDANCJJEPL) where TData : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class EDICKEAJPNA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly Dictionary<object, float> GLAIHHBGMMC;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public float CDGLJEDBNOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x922D40", Offset = "0x921B40", VA = "0x180922D40")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x922DE0", Offset = "0x921BE0", VA = "0x180922DE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6186960", Offset = "0x6185760", VA = "0x186186960")]
	public void KAIAEIFBMCN(float MAEBFBHFPDE, object BNAJMHPOOCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x61868F0", Offset = "0x61856F0", VA = "0x1861868F0")]
	public void FFEMLCJDOBK(object BNAJMHPOOCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x61869D0", Offset = "0x61857D0", VA = "0x1861869D0")]
	private void NMCHMPNNKFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x6186B00", Offset = "0x6185900", VA = "0x186186B00")]
	public EDICKEAJPNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class NEHJFKPALBC<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class EBCJNMKGAFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		public EBCJNMKGAFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x3292EB0", Offset = "0x3291CB0", VA = "0x183292EB0")]
		internal int OOLEIBOHALM(int i, T token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private HashSet<T>? MGPHGOMELLO;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public IReadOnlyCollection<T> AHBEGCHJMCL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x3E945A0", Offset = "0x3E933A0", VA = "0x183E945A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool NMFGLEGMAEE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x3E943F0", Offset = "0x3E931F0", VA = "0x183E943F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int EDOFPONLMHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7BFB30", Offset = "0x7BE930", VA = "0x1807BFB30")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x7C24C0", Offset = "0x7C12C0", VA = "0x1807C24C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x3E94430", Offset = "0x3E93230", VA = "0x183E94430")]
	public bool GALNLGNAACN(T BNAJMHPOOCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3E942D0", Offset = "0x3E930D0", VA = "0x183E942D0")]
	public bool FIJOKOAGLFM(T BNAJMHPOOCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x3E94290", Offset = "0x3E93090", VA = "0x183E94290")]
	public bool ADCHJIHGBAF(T BNAJMHPOOCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x3E945D0", Offset = "0x3E933D0", VA = "0x183E945D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public NEHJFKPALBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class NLCCPNDEHAC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly string JKJEOCCFEHH;

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7C8480", Offset = "0x7C7280", VA = "0x1807C8480")]
	public NLCCPNDEHAC(string JKJEOCCFEHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6187F80", Offset = "0x6186D80", VA = "0x186187F80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public sealed class IGJOIAOJFFC
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class PKCIMHCOGKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		public PKCIMHCOGKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x6188920", Offset = "0x6187720", VA = "0x186188920")]
		internal int OOLEIBOHALM(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private HashSet<object>? MGPHGOMELLO;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public IReadOnlyCollection<object> AHBEGCHJMCL
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x6187A10", Offset = "0x6186810", VA = "0x186187A10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool NMFGLEGMAEE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x61878B0", Offset = "0x61866B0", VA = "0x1861878B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int EDOFPONLMHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x7BFB30", Offset = "0x7BE930", VA = "0x1807BFB30")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x7C24C0", Offset = "0x7C12C0", VA = "0x1807C24C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x61878C0", Offset = "0x61866C0", VA = "0x1861878C0")]
	public bool GALNLGNAACN(object BNAJMHPOOCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6187810", Offset = "0x6186610", VA = "0x186187810")]
	public bool FIJOKOAGLFM(object BNAJMHPOOCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x61877B0", Offset = "0x61865B0", VA = "0x1861877B0")]
	public bool ADCHJIHGBAF(object BNAJMHPOOCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x61879A0", Offset = "0x61867A0", VA = "0x1861879A0")]
	public void LAJDIEDJAGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6187AA0", Offset = "0x61868A0", VA = "0x186187AA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public IGJOIAOJFFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class BCHMIAILHAN<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private struct GFDIIBFBCFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public float FPJHHLINNJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public T CIONEDGAKHL;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly Dictionary<object, GFDIIBFBCFI> GLAIHHBGMMC;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public virtual T BKMNILGEIOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0xE93260", Offset = "0xE92060", VA = "0x180E93260", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0xE92840", Offset = "0xE91640", VA = "0x180E92840", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public object? PACMOIFPHFD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x7BE940", Offset = "0x7BD740", VA = "0x1807BE940")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x7C24E0", Offset = "0x7C12E0", VA = "0x1807C24E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool BGPNPDHMLAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x4767F10", Offset = "0x4766D10", VA = "0x184767F10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x47665F0", Offset = "0x47653F0", VA = "0x1847665F0")]
	public bool KAIAEIFBMCN(T MAEBFBHFPDE, object BNAJMHPOOCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x3878F10", Offset = "0x3877D10", VA = "0x183878F10")]
	public bool FFEMLCJDOBK(object BNAJMHPOOCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x4767F60", Offset = "0x4766D60", VA = "0x184767F60")]
	public void OCIHDBDLDKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x4765D60", Offset = "0x4764B60", VA = "0x184765D60")]
	public bool EMHKBCLCPNM(object BNAJMHPOOCG, [Out] T MAEBFBHFPDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x4766910", Offset = "0x4765710", VA = "0x184766910")]
	[LMBEPMMPKGL("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool MIDMMOGIFPO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x4767F90", Offset = "0x4766D90", VA = "0x184767F90")]
	public BCHMIAILHAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface HKHKPIAKCNH
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event NDBMDIPNGNK KAIEACMOBLB;
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class CNGLPPGOMJK : HKHKPIAKCNH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public readonly struct JPBGHMKMOKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public readonly float FPLLGBFFFEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public readonly float OJGKBEINDOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		internal readonly bool ADIMDPHMPCJ;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float LGOFLDBOEMA
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x6187C50", Offset = "0x6186A50", VA = "0x186187C50")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6187DC0", Offset = "0x6186BC0", VA = "0x186187DC0")]
		public JPBGHMKMOKL(float CJNJFDOAKGB, float INMKHBKJJMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x6187C60", Offset = "0x6186A60", VA = "0x186187C60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class HPCKNLEEDDE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public CNGLPPGOMJK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		public HPCKNLEEDDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x6187710", Offset = "0x6186510", VA = "0x186187710")]
		internal void NPHIIBIJAML(float innerProgress)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly int DKDCFCAKJAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private int JKBODNJHEJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly HKHKPIAKCNH[] PAALGMLCMKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly NDBMDIPNGNK[] GKPFGLIAHLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly JPBGHMKMOKL[] OGIELLMHGIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private JPBGHMKMOKL MBLKJKELBPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly FHCEMJOKEEH NAJJEAHOEGJ;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event NDBMDIPNGNK KAIEACMOBLB
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x6185F00", Offset = "0x6184D00", VA = "0x186185F00", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x6186540", Offset = "0x6185340", VA = "0x186186540", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x6186690", Offset = "0x6185490", VA = "0x186186690")]
	public CNGLPPGOMJK(int DKDCFCAKJAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x6186600", Offset = "0x6185400", VA = "0x186186600")]
	public FHCEMJOKEEH NLLJALOPPMP(JPBGHMKMOKL GIFOAEGNIGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x61860D0", Offset = "0x6184ED0", VA = "0x1861860D0")]
	public void KHGAODKGCCL(HKHKPIAKCNH NMHKOODOABI, [Optional] JPBGHMKMOKL BMHPHMKMDKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x6185FC0", Offset = "0x6184DC0", VA = "0x186185FC0", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public delegate void NDBMDIPNGNK(float JBNJBBLEAKL);
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class OEEENDKABGG
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private class ANFLFGGCAII : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private readonly HKHKPIAKCNH OLHLMMOHHJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly NDBMDIPNGNK NHPEKKMOHMO;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x6185AE0", Offset = "0x61848E0", VA = "0x186185AE0")]
		public ANFLFGGCAII(HKHKPIAKCNH OLHLMMOHHJI, NDBMDIPNGNK NHPEKKMOHMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x6185A90", Offset = "0x6184890", VA = "0x186185A90", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x6188770", Offset = "0x6187570", VA = "0x186188770")]
	internal static bool GOIPPPAAHAK(float AOHIFIJNOBB, float FNDBFMFAGPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x61784D0", Offset = "0x61772D0", VA = "0x1861784D0")]
	internal static float GJLDONPJEID(float AOHIFIJNOBB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x61887E0", Offset = "0x61875E0", VA = "0x1861887E0")]
	public static IDisposable LKJPBDBMAOM(this HKHKPIAKCNH OLHLMMOHHJI, NDBMDIPNGNK NHPEKKMOHMO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class FHCEMJOKEEH : HKHKPIAKCNH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private float JBNJBBLEAKL;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public float APAGMAGPELJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6186B90", Offset = "0x6185990", VA = "0x186186B90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event NDBMDIPNGNK? KAIEACMOBLB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x6186C80", Offset = "0x6185A80", VA = "0x186186C80", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x6186D20", Offset = "0x6185B20", VA = "0x186186D20", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public FHCEMJOKEEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class PBOILBNICIC : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x5C6CD70", Offset = "0x5C6BB70", VA = "0x185C6CD70")]
	public PBOILBNICIC(string LJCDGDONMLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
[DefaultMember("Item")]
public class PGNKICCDAKF<TKey, TValue> : KFGNONPHHKK<TKey, TValue>, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, GKDAIFBJIHG where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private sealed class DCFFMCEHBID : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private KeyValuePair<TKey, TValue> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public PGNKICCDAKF<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private IEnumerator<KeyValuePair<TKey, TValue>> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		KeyValuePair<TKey, TValue> IEnumerator<KeyValuePair<TKey, TValue>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0xE93260", Offset = "0xE92060", VA = "0x180E93260", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TValue>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x501F8F0", Offset = "0x501E6F0", VA = "0x18501F8F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x7C10A0", Offset = "0x7BFEA0", VA = "0x1807C10A0")]
		[DebuggerHidden]
		public DCFFMCEHBID(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x363E960", Offset = "0x363D760", VA = "0x18363E960", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x501F330", Offset = "0x501E130", VA = "0x18501F330", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x501EB30", Offset = "0x501D930", VA = "0x18501EB30")]
		private void FHJCGBCHLDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x501F7B0", Offset = "0x501E5B0", VA = "0x18501F7B0")]
		private void PDHPDAEENHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x501F8A0", Offset = "0x501E6A0", VA = "0x18501F8A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly KFGNONPHHKK<TKey, TValue> FADKNLIHCDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly IDictionary<TKey, TValue> AAFGEKMJLHP;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public int EDOFPONLMHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x40A7F30", Offset = "0x40A6D30", VA = "0x1840A7F30", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool OJMEMOAMNDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x801AA0", Offset = "0x8008A0", VA = "0x180801AA0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public TValue GKAMGCEMFBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x40A8100", Offset = "0x40A6F00", VA = "0x1840A8100", Slot = "4")]
		get
		{
			return (TValue)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x40A8360", Offset = "0x40A7160", VA = "0x1840A8360", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public ICollection<TKey> EEEKPMFOBHF
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x40A8140", Offset = "0x40A6F40", VA = "0x1840A8140", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public ICollection<TValue> LHIKNJNINIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x40A8250", Offset = "0x40A7050", VA = "0x1840A8250", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x40A7DB0", Offset = "0x40A6BB0", VA = "0x1840A7DB0")]
	public PGNKICCDAKF(KFGNONPHHKK<TKey, TValue> FADKNLIHCDG, [Optional] IDictionary<TKey, TValue>? AAFGEKMJLHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x40A5680", Offset = "0x40A4480", VA = "0x1840A5680", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x40A6640", Offset = "0x40A5440", VA = "0x1840A6640")]
	public void HMLLEOJKFGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x40A5310", Offset = "0x40A4110", VA = "0x1840A5310", Slot = "9")]
	public void Add(TKey ONOECNHBCDA, TValue MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x40A6760", Offset = "0x40A5560", VA = "0x1840A6760")]
	public void IEGOFIANCIJ(TKey ONOECNHBCDA, TValue MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x40A6C00", Offset = "0x40A5A00", VA = "0x1840A6C00")]
	public void MAMKNMMJHPE(TKey ONOECNHBCDA, TValue MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x40A6080", Offset = "0x40A4E80", VA = "0x1840A6080")]
	public void DEPPBNLNNJH(TKey ONOECNHBCDA, TValue MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x40A6DB0", Offset = "0x40A5BB0", VA = "0x1840A6DB0")]
	public void MEGGIMPNEFM(TKey ONOECNHBCDA, TValue MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x40A7400", Offset = "0x40A6200", VA = "0x1840A7400", Slot = "14")]
	void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> IFKPOCGDKDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x40A7600", Offset = "0x40A6400", VA = "0x1840A7600", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> IFKPOCGDKDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x40A77C0", Offset = "0x40A65C0", VA = "0x1840A77C0", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> IFKPOCGDKDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x40A56F0", Offset = "0x40A44F0", VA = "0x1840A56F0", Slot = "8")]
	public bool ContainsKey(TKey ONOECNHBCDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x40A6450", Offset = "0x40A5250", VA = "0x1840A6450")]
	public bool GAMCGINCIMD(TKey ONOECNHBCDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x40A6A60", Offset = "0x40A5860", VA = "0x1840A6A60")]
	public bool KKCPKGNPPPE(TKey ONOECNHBCDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x40A7250", Offset = "0x40A6050", VA = "0x1840A7250", Slot = "10")]
	public bool Remove(TKey ONOECNHBCDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x40A7B20", Offset = "0x40A6920", VA = "0x1840A7B20", Slot = "11")]
	public bool TryGetValue(TKey ONOECNHBCDA, [Out] TValue MAEBFBHFPDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x40A5840", Offset = "0x40A4640", VA = "0x1840A5840", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TValue>[] HHAMBPGBENG, int ABBBMAHIKNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x3AE1640", Offset = "0x3AE0440", VA = "0x183AE1640", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x40A6520", Offset = "0x40A5320", VA = "0x1840A6520", Slot = "19")]
	[IteratorStateMachine(typeof(PGNKICCDAKF<, >.DCFFMCEHBID))]
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x40A6910", Offset = "0x40A5710", VA = "0x1840A6910", Slot = "21")]
	public bool IJLEJAOLBAA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x40A6EE0", Offset = "0x40A5CE0", VA = "0x1840A6EE0")]
	private TValue NMMCGMNEJHN(TKey ONOECNHBCDA)
	{
		return (TValue)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public interface GKDAIFBJIHG
{
	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IJLEJAOLBAA();
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public interface KFGNONPHHKK<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, GKDAIFBJIHG
{
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[DefaultMember("Item")]
public sealed class GOLHBDPOKKL<TKey, TVal> : KFGNONPHHKK<TKey, TVal>, IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, GKDAIFBJIHG where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public delegate int MKJDLFFLPKH(TKey ONOECNHBCDA, TVal MAEBFBHFPDE);

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private class HDNIKKHAEJD
	{
		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public TKey HBMNMFEKKLA
		{
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x825D70", Offset = "0x824B70", VA = "0x180825D70")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public TVal CIONEDGAKHL
		{
			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x91FAD0", Offset = "0x91E8D0", VA = "0x18091FAD0")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x91FAE0", Offset = "0x91E8E0", VA = "0x18091FAE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public int LGOFLDBOEMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x7F8A10", Offset = "0x7F7810", VA = "0x1807F8A10")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x7F8010", Offset = "0x7F6E10", VA = "0x1807F8010")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public DateTimeOffset PBJOAGHHLJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0xA88000", Offset = "0xA86E00", VA = "0x180A88000")]
			[CompilerGenerated]
			get
			{
				return default(DateTimeOffset);
			}
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x12EFC70", Offset = "0x12EEA70", VA = "0x1812EFC70")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x37A8AC0", Offset = "0x37A78C0", VA = "0x1837A8AC0")]
		public HDNIKKHAEJD(TKey ONOECNHBCDA, TVal KJBIGJEIABL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private sealed class OAMMEOHPLIC : IEnumerator<KeyValuePair<TKey, TVal>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private KeyValuePair<TKey, TVal> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public GOLHBDPOKKL<TKey, TVal> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private LinkedList<HDNIKKHAEJD>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		KeyValuePair<TKey, TVal> IEnumerator<KeyValuePair<TKey, TVal>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0xE93260", Offset = "0xE92060", VA = "0x180E93260", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TVal>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x3FB3770", Offset = "0x3FB2570", VA = "0x183FB3770", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x7C10A0", Offset = "0x7BFEA0", VA = "0x1807C10A0")]
		[DebuggerHidden]
		public OAMMEOHPLIC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x34F6D40", Offset = "0x34F5B40", VA = "0x1834F6D40", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x3FB1490", Offset = "0x3FB0290", VA = "0x183FB1490", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x3FB0E70", Offset = "0x3FAFC70", VA = "0x183FB0E70")]
		private void FHJCGBCHLDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x3FB3360", Offset = "0x3FB2160", VA = "0x183FB3360", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public const int IDNJNKGEPJB = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private readonly Dictionary<TKey, LinkedListNode<HDNIKKHAEJD>> EPECHNFDGHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly LinkedList<HDNIKKHAEJD> IIPICLFBALG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly MKJDLFFLPKH? CDOCHKBEDKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly TimeSpan GKJHADBJAJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly JMILILIFPKG ELEKNHDEEPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private bool FLCKNCIAAOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly List<TKey> ABDPBEAOMAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly List<TVal> GNGOKKGAIAM;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public int LACGIBAEEFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x7D74E0", Offset = "0x7D62E0", VA = "0x1807D74E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	internal int COJAKAIMJJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x7D74F0", Offset = "0x7D62F0", VA = "0x1807D74F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0xEB7A60", Offset = "0xEB6860", VA = "0x180EB7A60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int EDOFPONLMHN
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x3725780", Offset = "0x3724580", VA = "0x183725780", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	internal int FNIGFAIAPGD
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x3721B40", Offset = "0x3720940", VA = "0x183721B40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public ICollection<TVal> LHIKNJNINIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x37258B0", Offset = "0x37246B0", VA = "0x1837258B0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	ICollection<TKey> IDictionary<TKey, TVal>.CNKLKGEKDKI
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x3722C90", Offset = "0x3721A90", VA = "0x183722C90", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool OJMEMOAMNDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x801AA0", Offset = "0x8008A0", VA = "0x180801AA0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public TVal GKAMGCEMFBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x37257E0", Offset = "0x37245E0", VA = "0x1837257E0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x3725900", Offset = "0x3724700", VA = "0x183725900", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x371DA90", Offset = "0x371C890", VA = "0x18371DA90")]
	private bool DMJJAELNOBL(int DKDCFCAKJAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x3720370", Offset = "0x371F170", VA = "0x183720370")]
	private void HFBHCIGEMJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x3724380", Offset = "0x3723180", VA = "0x183724380")]
	public GOLHBDPOKKL(int DKDCFCAKJAJ, [Optional] MKJDLFFLPKH? CDOCHKBEDKH, [Optional] IEqualityComparer<TKey>? NIACMHLGFMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x3724440", Offset = "0x3723240", VA = "0x183724440")]
	public GOLHBDPOKKL(TimeSpan GKJHADBJAJH, [Optional] IEqualityComparer<TKey>? NIACMHLGFMK, [Optional] JMILILIFPKG? ELEKNHDEEPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x37241C0", Offset = "0x3722FC0", VA = "0x1837241C0")]
	public GOLHBDPOKKL(int DKDCFCAKJAJ, TimeSpan GKJHADBJAJH, [Optional] IEqualityComparer<TKey>? NIACMHLGFMK, [Optional] JMILILIFPKG? ELEKNHDEEPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x3724E00", Offset = "0x3723C00", VA = "0x183724E00")]
	public GOLHBDPOKKL(int DKDCFCAKJAJ, MKJDLFFLPKH? CDOCHKBEDKH, TimeSpan GKJHADBJAJH, [Optional] IEqualityComparer<TKey>? NIACMHLGFMK, [Optional] JMILILIFPKG? ELEKNHDEEPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x37207C0", Offset = "0x371F5C0", VA = "0x1837207C0", Slot = "21")]
	public bool IJLEJAOLBAA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x371D370", Offset = "0x371C170", VA = "0x18371D370", Slot = "22")]
	public bool DBBLMIHOPPJ(int JEOEJJBKODC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x371CA70", Offset = "0x371B870", VA = "0x18371CA70")]
	private bool DAEJEAMCMJN(int JEOEJJBKODC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x371D7C0", Offset = "0x371C5C0", VA = "0x18371D7C0")]
	public void DFGFKLLLOGA(TKey ONOECNHBCDA, TVal MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x371A080", Offset = "0x3718E80", VA = "0x18371A080", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> IFKPOCGDKDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x3719F30", Offset = "0x3718D30", VA = "0x183719F30", Slot = "9")]
	public void Add(TKey ONOECNHBCDA, TVal MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x371B200", Offset = "0x371A000", VA = "0x18371B200", Slot = "8")]
	public bool ContainsKey(TKey ONOECNHBCDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x37223E0", Offset = "0x37211E0", VA = "0x1837223E0", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Contains(KeyValuePair<TKey, TVal> IFKPOCGDKDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x37222D0", Offset = "0x37210D0", VA = "0x1837222D0", Slot = "10")]
	public bool Remove(TKey ONOECNHBCDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x37227F0", Offset = "0x37215F0", VA = "0x1837227F0", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Remove(KeyValuePair<TKey, TVal> IFKPOCGDKDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x3719960", Offset = "0x3718760", VA = "0x183719960")]
	private bool AAFLANCEHGK(TKey ONOECNHBCDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x3721D90", Offset = "0x3720B90", VA = "0x183721D90")]
	private TVal MHEOMGMBJHC(TKey MIEIIDHDNFL)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x3723250", Offset = "0x3722050", VA = "0x183723250", Slot = "11")]
	public bool TryGetValue(TKey MIEIIDHDNFL, [Out] TVal MAEBFBHFPDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x371B120", Offset = "0x3719F20", VA = "0x18371B120", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x371B670", Offset = "0x371A470", VA = "0x18371B670", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] HHAMBPGBENG, int ABBBMAHIKNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x371AB20", Offset = "0x3719920", VA = "0x18371AB20")]
	private bool CENOJDJNJNM(HDNIKKHAEJD GAHFDNCHHJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x371FD90", Offset = "0x371EB90", VA = "0x18371FD90")]
	private void GOEOJOFLEDC(LinkedListNode<HDNIKKHAEJD> HILCGCHNGOL, TVal BAFHHLIGKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x3720DC0", Offset = "0x371FBC0", VA = "0x183720DC0")]
	private void KAIAEIFBMCN(TKey ONOECNHBCDA, TVal MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x371DCC0", Offset = "0x371CAC0", VA = "0x18371DCC0")]
	private void FHNBPNJMDIB(HDNIKKHAEJD GAHFDNCHHJC, TVal BAFHHLIGKHL, int KKABCLALAJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x3720250", Offset = "0x371F050", VA = "0x183720250", Slot = "19")]
	[IteratorStateMachine(typeof(GOLHBDPOKKL<, >.OAMMEOHPLIC))]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x3722CC0", Offset = "0x3721AC0", VA = "0x183722CC0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class EJNDJMGJEDH<TId, TResource> : IEnumerable<(TId, Task<TResource>, int)>, IEnumerable where TId : notnull where TResource : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private sealed class NKIPDLGHKEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public Func<TId, CancellationToken, Task<TResource>> factory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public EJNDJMGJEDH<TId, TResource> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		public NKIPDLGHKEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x3EDFAB0", Offset = "0x3EDE8B0", VA = "0x183EDFAB0")]
		internal Task<TResource> MIJLAMDCJNK(TId _id)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private struct CDJKNFDFKGH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public Dictionary<Task<TResource>, CancellationTokenSource> cancellationTokenSources;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public CancellationTokenSource cts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x4B88560", Offset = "0x4B87360", VA = "0x184B88560", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x4B88F80", Offset = "0x4B87D80", VA = "0x184B88F80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private struct GPAGIPBHDPN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public Action<TResource> cleanup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x3730D80", Offset = "0x372FB80", VA = "0x183730D80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x3730FE0", Offset = "0x372FDE0", VA = "0x183730FE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly AFOOFNJOOKK<TId, Task<TResource>> BLAJMJMAOLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly Dictionary<Task<TResource>, CancellationTokenSource> EDJAAOFJHEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly Func<TId, CancellationToken, Task<TResource>>? CMGFPJBLJLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly Action<TResource>? FCEAOOOOCPA;

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x329D950", Offset = "0x329C750", VA = "0x18329D950")]
	public EJNDJMGJEDH(int NCDEKMLOLDF = 0, [Optional] IEqualityComparer<TId>? GAGJKLLBJDO, [Optional] Func<TId, CancellationToken, Task<TResource>>? LCDEBFHFAHI, [Optional] Action<TResource>? LJCNMFBDBMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x329D100", Offset = "0x329BF00", VA = "0x18329D100")]
	public LOHPMIAJHKJ<Task<TResource>> NJLMLDPHJOK(TId FJIJLBIGEAH, [Optional] Func<TId, CancellationToken, Task<TResource>>? LCDEBFHFAHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x329D670", Offset = "0x329C470", VA = "0x18329D670")]
	private void NNBGAKBJGII(Task<TResource> NPDMMHKHJDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x329C700", Offset = "0x329B500", VA = "0x18329C700")]
	public void EFHCPNNIJHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x329CAD0", Offset = "0x329B8D0", VA = "0x18329CAD0")]
	public AFOOFNJOOKK<TId, Task<TResource>>.DPJKFKPMKCM GGNEAJGHJIC()
	{
		return default(AFOOFNJOOKK<TId, Task<TResource>>.DPJKFKPMKCM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x329D820", Offset = "0x329C620", VA = "0x18329D820", Slot = "4")]
	private IEnumerator<(TId, Task<TResource>, int)> System.Collections.Generic.IEnumerable<(TIdId,System.Threading.Tasks.Task<TResource>LoadResourceTask,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x329D820", Offset = "0x329C620", VA = "0x18329D820", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x329CCE0", Offset = "0x329BAE0", VA = "0x18329CCE0")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(EJNDJMGJEDH<, >.CDJKNFDFKGH))]
	internal static Task LECEOLPHCDJ(Task<TResource> NPDMMHKHJDL, CancellationTokenSource JPDOMBFNMPN, Dictionary<Task<TResource>, CancellationTokenSource> JDJLBGPPKIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x329C840", Offset = "0x329B640", VA = "0x18329C840")]
	[AsyncStateMachine(typeof(EJNDJMGJEDH<, >.GPAGIPBHDPN))]
	[CompilerGenerated]
	internal static Task GBLCNPGANKB(Task<TResource> NPDMMHKHJDL, Action<TResource> BBGAPMMAFNI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class AFOOFNJOOKK<TKey, TValue> : IEnumerable<(TKey, TValue, int)>, IEnumerable where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private sealed class MFDHKPJMDGN : IEquatable<MFDHKPJMDGN>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public readonly TValue CIONEDGAKHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public int COLGFECKFBE;

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x1C525D0", Offset = "0x1C513D0", VA = "0x181C525D0")]
		public MFDHKPJMDGN(TValue MAEBFBHFPDE, int IFPIGJGLBNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x3E0F860", Offset = "0x3E0E660", VA = "0x183E0F860", Slot = "4")]
		public bool Equals(MFDHKPJMDGN? EDOEJIMPOFP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x3E0F8F0", Offset = "0x3E0E6F0", VA = "0x183E0F8F0", Slot = "0")]
		public override bool Equals(object? KDHDNCADFDJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x3E0FA20", Offset = "0x3E0E820", VA = "0x183E0FA20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public struct DPJKFKPMKCM : IEnumerator<(TKey, TValue, int)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private Dictionary<TKey, MFDHKPJMDGN>.Enumerator FBBKICMGHPF;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x5052F90", Offset = "0x5051D90", VA = "0x185052F90", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public (TKey Key, TValue Value, int RefCount) OGCIBGAMGCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x50533D0", Offset = "0x50521D0", VA = "0x1850533D0", Slot = "4")]
			get
			{
				return default((TKey, TValue, int));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x5053180", Offset = "0x5051F80", VA = "0x185053180")]
		public DPJKFKPMKCM(AFOOFNJOOKK<TKey, TValue> GLAIHHBGMMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x5052C80", Offset = "0x5051A80", VA = "0x185052C80", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x5052D40", Offset = "0x5051B40", VA = "0x185052D40", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x5052EE0", Offset = "0x5051CE0", VA = "0x185052EE0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class CEIAIIGKCCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public AFOOFNJOOKK<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public TKey key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public MFDHKPJMDGN refCountedValue;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		public CEIAIIGKCCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x4C549C0", Offset = "0x4C537C0", VA = "0x184C549C0")]
		internal void MIJLAMDCJNK()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly Dictionary<TKey, MFDHKPJMDGN> HPCAIGHJJLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly Func<TKey, TValue>? NLEJPKPGLLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly Action<TValue>? KNFAHDNEKGO;

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x38BC3B0", Offset = "0x38BB1B0", VA = "0x1838BC3B0")]
	public AFOOFNJOOKK(int NCDEKMLOLDF = 0, [Optional] IEqualityComparer<TKey>? NIACMHLGFMK, [Optional] Func<TKey, TValue>? POGBMLOODAG, [Optional] Action<TValue>? MPPCCIEFMOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x38BB960", Offset = "0x38BA760", VA = "0x1838BB960")]
	public LOHPMIAJHKJ<TValue> NJLMLDPHJOK(TKey ONOECNHBCDA, [Optional] Func<TKey, TValue>? FNACGKJEGFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x38BB860", Offset = "0x38BA660", VA = "0x1838BB860")]
	private void KKLNFJEOADM(TKey ONOECNHBCDA, MFDHKPJMDGN GOAAGAGLCPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x38BB3D0", Offset = "0x38BA1D0", VA = "0x1838BB3D0")]
	public void EFHCPNNIJHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x38BB5F0", Offset = "0x38BA3F0", VA = "0x1838BB5F0")]
	public DPJKFKPMKCM GGNEAJGHJIC()
	{
		return default(DPJKFKPMKCM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x38BC1E0", Offset = "0x38BAFE0", VA = "0x1838BC1E0", Slot = "4")]
	private IEnumerator<(TKey, TValue, int)> System.Collections.Generic.IEnumerable<(TKeyKey,TValueValue,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x38BC1E0", Offset = "0x38BAFE0", VA = "0x1838BC1E0", Slot = "5")]
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
