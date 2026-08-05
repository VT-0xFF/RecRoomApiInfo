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
		[Cpp2IlInjected.Address(RVA = "0x8D39D0", Offset = "0x8D2DD0", VA = "0x1808D39D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6EB2810", Offset = "0x6EB1C10", VA = "0x186EB2810")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8D4610", Offset = "0x8D3A10", VA = "0x1808D4610")]
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
		[Cpp2IlInjected.Address(RVA = "0x8D4650", Offset = "0x8D3A50", VA = "0x1808D4650")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class EBNIDGOOOBH
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
	protected EBNIDGOOOBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class DCMBEHDLAHJ<T> : EBNIDGOOOBH
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	protected struct LEEPHILENBG
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public enum JAPINJHEJJH
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
		public JAPINJHEJJH DPOLEDLIAMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public T HJOAJFDFEDM;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private int EAGHPKMKCDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool HFCLPNJLCKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	protected readonly bool LOINMGHGEJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	protected List<T>? FDHPADBGKPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<LEEPHILENBG>? ACPHAKANIJH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool IBPNMFBBLDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5C934B0", Offset = "0x5C928B0", VA = "0x185C934B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5C93BA0", Offset = "0x5C92FA0", VA = "0x185C93BA0")]
	protected DCMBEHDLAHJ(bool LOINMGHGEJM, bool HFCLPNJLCKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5C93410", Offset = "0x5C92810", VA = "0x185C93410")]
	protected bool GLKLECOJBHA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5C932E0", Offset = "0x5C926E0", VA = "0x185C932E0")]
	protected void DGBOFGCFNJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5C93900", Offset = "0x5C92D00", VA = "0x185C93900")]
	protected void NCPHLFFJJNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2CFE840", Offset = "0x2CFDC40", VA = "0x182CFE840")]
	private static void BHLGJIDALBO<U>(List<U>? KDBAFFDDPME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5C936E0", Offset = "0x5C92AE0", VA = "0x185C936E0", Slot = "4")]
	public void LEFBGNCKNFL(T HJOAJFDFEDM, bool GLGGGAFGHCE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5C93100", Offset = "0x5C92500", VA = "0x185C93100", Slot = "5")]
	public void BJFEGIDGDBE(T HJOAJFDFEDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5C93520", Offset = "0x5C92920", VA = "0x185C93520")]
	public void KMNEPMPOIBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class LDNMACGBDLI : DCMBEHDLAHJ<Action>
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6EB2470", Offset = "0x6EB1870", VA = "0x186EB2470")]
	public LDNMACGBDLI(bool LOINMGHGEJM = false, bool HFCLPNJLCKO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6EB2270", Offset = "0x6EB1670", VA = "0x186EB2270")]
	public void NCEDFJEFMFN()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6EB21B0", Offset = "0x6EB15B0", VA = "0x186EB21B0")]
	public static LDNMACGBDLI HPADCFAMCHC(LDNMACGBDLI LNNOFGKOFMO, Action HJOAJFDFEDM)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6EB2210", Offset = "0x6EB1610", VA = "0x186EB2210")]
	public static LDNMACGBDLI LIBMFNJNPOF(LDNMACGBDLI LNNOFGKOFMO, Action HJOAJFDFEDM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface PJKFGNFNJNN<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LEFBGNCKNFL(Action<T> HJOAJFDFEDM, bool GLGGGAFGHCE = false);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BJFEGIDGDBE(Action<T> HJOAJFDFEDM);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class PJFDJKKNHLD<T> : DCMBEHDLAHJ<Action<T>>, PJKFGNFNJNN<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4090C80", Offset = "0x4090080", VA = "0x184090C80")]
	public PJFDJKKNHLD(bool LOINMGHGEJM = false, bool HFCLPNJLCKO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4B209F0", Offset = "0x4B1FDF0", VA = "0x184B209F0")]
	public void NCEDFJEFMFN(T KBFPLGGGODF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x40C51E0", Offset = "0x40C45E0", VA = "0x1840C51E0")]
	public static PJFDJKKNHLD<T> HPADCFAMCHC(PJFDJKKNHLD<T> LNNOFGKOFMO, Action<T> HJOAJFDFEDM)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x40C5290", Offset = "0x40C4690", VA = "0x1840C5290")]
	public static PJFDJKKNHLD<T> LIBMFNJNPOF(PJFDJKKNHLD<T> LNNOFGKOFMO, Action<T> HJOAJFDFEDM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface AGAGCDPBJKK<T, U> where T : notnull where U : notnull
{
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class HBLLMAEIFAH<T, U> : DCMBEHDLAHJ<Action<T, U>>, AGAGCDPBJKK<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4090C80", Offset = "0x4090080", VA = "0x184090C80")]
	public HBLLMAEIFAH(bool LOINMGHGEJM = false, bool HFCLPNJLCKO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x41157E0", Offset = "0x4114BE0", VA = "0x1841157E0")]
	public void NCEDFJEFMFN(T KBFPLGGGODF, U CHDNPGFKAOK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x40C51E0", Offset = "0x40C45E0", VA = "0x1840C51E0")]
	public static HBLLMAEIFAH<T, U> HPADCFAMCHC(HBLLMAEIFAH<T, U> LNNOFGKOFMO, Action<T, U> HJOAJFDFEDM)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x40C5290", Offset = "0x40C4690", VA = "0x1840C5290")]
	public static HBLLMAEIFAH<T, U> LIBMFNJNPOF(HBLLMAEIFAH<T, U> LNNOFGKOFMO, Action<T, U> HJOAJFDFEDM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class AOBPLAOOIGJ<T, U, V> : DCMBEHDLAHJ<Action<T, U, V>> where T : notnull where U : notnull where V : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4090C80", Offset = "0x4090080", VA = "0x184090C80")]
	public AOBPLAOOIGJ(bool LOINMGHGEJM = false, bool HFCLPNJLCKO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x40D6F60", Offset = "0x40D6360", VA = "0x1840D6F60")]
	public void NCEDFJEFMFN(T KBFPLGGGODF, U CHDNPGFKAOK, V IFLBFOHFIEP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x40C51E0", Offset = "0x40C45E0", VA = "0x1840C51E0")]
	public static AOBPLAOOIGJ<T, U, V> HPADCFAMCHC(AOBPLAOOIGJ<T, U, V> LNNOFGKOFMO, Action<T, U, V> HJOAJFDFEDM)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x40C5290", Offset = "0x40C4690", VA = "0x1840C5290")]
	public static AOBPLAOOIGJ<T, U, V> LIBMFNJNPOF(AOBPLAOOIGJ<T, U, V> LNNOFGKOFMO, Action<T, U, V> HJOAJFDFEDM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface LEBJAOODACH<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public sealed class OOIOLHEPBHE<T, U, V, W> : DCMBEHDLAHJ<Action<T, U, V, W>>, LEBJAOODACH<T, U, V, W> where T : notnull where U : notnull where V : notnull where W : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x4090C80", Offset = "0x4090080", VA = "0x184090C80")]
	public OOIOLHEPBHE(bool LOINMGHGEJM = false, bool HFCLPNJLCKO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4A1DDD0", Offset = "0x4A1D1D0", VA = "0x184A1DDD0")]
	public void NCEDFJEFMFN(T KBFPLGGGODF, U CHDNPGFKAOK, V IFLBFOHFIEP, W PNJGKAECJEF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x40C51E0", Offset = "0x40C45E0", VA = "0x1840C51E0")]
	public static OOIOLHEPBHE<T, U, V, W> HPADCFAMCHC(OOIOLHEPBHE<T, U, V, W> LNNOFGKOFMO, Action<T, U, V, W> HJOAJFDFEDM)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x40C5290", Offset = "0x40C4690", VA = "0x1840C5290")]
	public static OOIOLHEPBHE<T, U, V, W> LIBMFNJNPOF(OOIOLHEPBHE<T, U, V, W> LNNOFGKOFMO, Action<T, U, V, W> HJOAJFDFEDM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class GPFIFMHFHFN<T, U, V, W, X> : DCMBEHDLAHJ<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4090C80", Offset = "0x4090080", VA = "0x184090C80")]
	public GPFIFMHFHFN(bool LOINMGHGEJM = false, bool HFCLPNJLCKO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x40C5740", Offset = "0x40C4B40", VA = "0x1840C5740")]
	public void NCEDFJEFMFN(T KBFPLGGGODF, U CHDNPGFKAOK, V IFLBFOHFIEP, W PNJGKAECJEF, X LBEGFJJGJFP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x40C51E0", Offset = "0x40C45E0", VA = "0x1840C51E0")]
	public static GPFIFMHFHFN<T, U, V, W, X> HPADCFAMCHC(GPFIFMHFHFN<T, U, V, W, X> LNNOFGKOFMO, Action<T, U, V, W, X> HJOAJFDFEDM)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x40C5290", Offset = "0x40C4690", VA = "0x1840C5290")]
	public static GPFIFMHFHFN<T, U, V, W, X> LIBMFNJNPOF(GPFIFMHFHFN<T, U, V, W, X> LNNOFGKOFMO, Action<T, U, V, W, X> HJOAJFDFEDM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class ANBLMEOJGPN<T, U, V, W, X, Y> : DCMBEHDLAHJ<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4090C80", Offset = "0x4090080", VA = "0x184090C80")]
	public ANBLMEOJGPN(bool LOINMGHGEJM = false, bool HFCLPNJLCKO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x40D4F80", Offset = "0x40D4380", VA = "0x1840D4F80")]
	public void NCEDFJEFMFN(T KBFPLGGGODF, U CHDNPGFKAOK, V IFLBFOHFIEP, W PNJGKAECJEF, X LBEGFJJGJFP, Y GAMIAAAKNPF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x40C51E0", Offset = "0x40C45E0", VA = "0x1840C51E0")]
	public static ANBLMEOJGPN<T, U, V, W, X, Y> HPADCFAMCHC(ANBLMEOJGPN<T, U, V, W, X, Y> LNNOFGKOFMO, Action<T, U, V, W, X, Y> HJOAJFDFEDM)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x40C5290", Offset = "0x40C4690", VA = "0x1840C5290")]
	public static ANBLMEOJGPN<T, U, V, W, X, Y> LIBMFNJNPOF(ANBLMEOJGPN<T, U, V, W, X, Y> LNNOFGKOFMO, Action<T, U, V, W, X, Y> HJOAJFDFEDM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class CDOIOENGADD<TKey, TVal> where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly NILNFLHOEJA<TKey, TVal> AGIMIHMEEOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly Dictionary<TKey, (TVal value, int size)> ODEPCNOPCDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly NILNFLHOEJA<TKey, TVal>.CAKIPGNJPAL? MPEABJCLCJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly int LAGKEJMFGHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly NILNFLHOEJA<TKey, TVal>.AKPPNPHILHK? HHDMJJNNBEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private int JFCAFIPEHKH;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal int IGFCFHENHCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x548F270", Offset = "0x548E670", VA = "0x18548F270")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int GNOFLAKLIMD
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8A8A30", Offset = "0x8A7E30", VA = "0x1808A8A30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x548F930", Offset = "0x548ED30", VA = "0x18548F930")]
	public CDOIOENGADD(int LAGKEJMFGHF, [Optional] NILNFLHOEJA<TKey, TVal>.AKPPNPHILHK? HHDMJJNNBEE, [Optional] IEqualityComparer<TKey>? DJAEONLNJJN, [Optional] NILNFLHOEJA<TKey, TVal>.CAKIPGNJPAL? MPEABJCLCJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x548E950", Offset = "0x548DD50", VA = "0x18548E950")]
	public void FPHFHKEBADB(TKey OEOMDKHBDFI, TVal EEPLCHCGAIN, bool AOGNDGAHFJA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x548E560", Offset = "0x548D960", VA = "0x18548E560")]
	public bool AJMNFLBAJDO(TKey OEOMDKHBDFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x548F660", Offset = "0x548EA60", VA = "0x18548F660")]
	public bool LCKMIEGKAOE(TKey JFMMGIJOFEJ, [Out] TVal EEPLCHCGAIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x548F2D0", Offset = "0x548E6D0", VA = "0x18548F2D0")]
	private void JHHFIANPOJM(TKey OEOMDKHBDFI, TVal EEPLCHCGAIN, int IKJKAFPPDBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x548F760", Offset = "0x548EB60", VA = "0x18548F760")]
	public bool LLAHIHHEJPN(TKey OEOMDKHBDFI, TVal EEPLCHCGAIN, bool AOGNDGAHFJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x548F5B0", Offset = "0x548E9B0", VA = "0x18548F5B0")]
	public void KMNEPMPOIBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x548ECD0", Offset = "0x548E0D0", VA = "0x18548ECD0")]
	private void HEOAOHGMEPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x548E800", Offset = "0x548DC00", VA = "0x18548E800")]
	private bool FJPEOKGKFMD(TKey OEOMDKHBDFI, MBBBJNILNCE ENJPANJMAJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x548E6D0", Offset = "0x548DAD0", VA = "0x18548E6D0")]
	private void EKOEGPBEIMD(TKey OEOMDKHBDFI, TVal EEPLCHCGAIN, MBBBJNILNCE ENJPANJMAJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x548EBA0", Offset = "0x548DFA0", VA = "0x18548EBA0")]
	private void GGECMPEEPKP(TKey OEOMDKHBDFI, TVal OAKJBMEGCLP, MBBBJNILNCE ENJPANJMAJE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class EMKMPCEGJKD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly Action DALHKNMLENC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool OGHMMJCABAD;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8B47B0", Offset = "0x8B3BB0", VA = "0x1808B47B0")]
	public EMKMPCEGJKD(Action LCFBAKMEMIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6EB04B0", Offset = "0x6EAF8B0", VA = "0x186EB04B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2C63150", Offset = "0x2C62550", VA = "0x182C63150")]
	public static KEACOJOOGKI<T> JMOKCOIDHBC<T>(T EEPLCHCGAIN, Action LCFBAKMEMIB) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class KEACOJOOGKI<T> : EMKMPCEGJKD where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public T EEMLDMGPOLA
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8A89D0", Offset = "0x8A7DD0", VA = "0x1808A89D0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x44FFFA0", Offset = "0x44FF3A0", VA = "0x1844FFFA0")]
	public KEACOJOOGKI(T EEPLCHCGAIN, Action LCFBAKMEMIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class LFFLJOGCMEB<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly MDILDGBKIOC<T>? HHFIPIBHCPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly ReadOnlySequence<T> MEPAIPDPEJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private bool OGHMMJCABAD;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly LFFLJOGCMEB<T> JFFGEEEAJID;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ReadOnlySequence<T> FHKEJNAFBNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x459D9A0", Offset = "0x459CDA0", VA = "0x18459D9A0")]
		get
		{
			return default(ReadOnlySequence<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long AEFILNEPPMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x459D720", Offset = "0x459CB20", VA = "0x18459D720")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool HNBCNJGJEII
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x459D4E0", Offset = "0x459C8E0", VA = "0x18459D4E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x459E1F0", Offset = "0x459D5F0", VA = "0x18459E1F0")]
	public LFFLJOGCMEB(MDILDGBKIOC<T> GEHAOCHHHBC, MDILDGBKIOC<T> OKOBFANIEDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x459E2F0", Offset = "0x459D6F0", VA = "0x18459E2F0")]
	public LFFLJOGCMEB(MDILDGBKIOC<T> GEHAOCHHHBC, int PGAHHGFJKBL, MDILDGBKIOC<T> OKOBFANIEDC, int HILPPJEFBDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x459DD70", Offset = "0x459D170", VA = "0x18459DD70")]
	private LFFLJOGCMEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x459D7E0", Offset = "0x459CBE0", VA = "0x18459D7E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x459DB60", Offset = "0x459CF60", VA = "0x18459DB60")]
	public T[] KHNNMIAFACK()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x459D870", Offset = "0x459CC70", VA = "0x18459D870")]
	public static ReadOnlySequence<T> EGFECENGKHG(LFFLJOGCMEB<T>? JNDDGFBGMGM)
	{
		return default(ReadOnlySequence<T>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct BMHLGBBDJOD : IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct CDHAAKCJCEK : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8F2CF0", Offset = "0x8F20F0", VA = "0x1808F2CF0")]
		public static CDHAAKCJCEK AHLALEPNKFA()
		{
			return default(CDHAAKCJCEK);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2BF5F20", Offset = "0x2BF5320", VA = "0x182BF5F20")]
	public static string? NHCPJJEOCOJ<T>([Optional] string? GEDJGMEKCOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2BF5FA0", Offset = "0x2BF53A0", VA = "0x182BF5FA0")]
	public static string? OALBKBDPLAO<T>([Optional] string? PGOEBANGGFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8F2CF0", Offset = "0x8F20F0", VA = "0x1808F2CF0")]
	public static BMHLGBBDJOD IIAGPKIJJME(string GEDJGMEKCOL, string? PGOEBANGGFI)
	{
		return default(BMHLGBBDJOD);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct GLMBEIECJOO
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate bool FHHEPCDKACK(string IPONCMNFLPL, GLMBEIECJOO ENPLICNPEBO);

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class EBDEDCDJEGN<T> where T : notnull, Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public List<int> enumValuesSubset;

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public EBDEDCDJEGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x3B4AB00", Offset = "0x3B49F00", VA = "0x183B4AB00")]
		internal void KHJAKLAELAE(T x)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public int GLEGKLPKAOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public string JMKMHGAOAPO;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6EB1070", Offset = "0x6EB0470", VA = "0x186EB1070")]
	public static Dictionary<string, GLMBEIECJOO> IDDPLJLBELH(Type NELLBAIPLJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2E665D0", Offset = "0x2E659D0", VA = "0x182E665D0")]
	public static Dictionary<string, GLMBEIECJOO> IDDPLJLBELH<T>(Type NELLBAIPLJI, IReadOnlyDictionary<T, string> ABMJHHAMDJA) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2E66E00", Offset = "0x2E66200", VA = "0x182E66E00")]
	public static Dictionary<string, GLMBEIECJOO> KHADEMKCIFF<T>(List<T> ELGKLHOFPPE) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6EB0AF0", Offset = "0x6EAFEF0", VA = "0x186EB0AF0")]
	public static Dictionary<string, GLMBEIECJOO> AIEINGEKFCI(Type NELLBAIPLJI, FHHEPCDKACK DPJIPOCMGHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6EB0EB0", Offset = "0x6EB02B0", VA = "0x186EB0EB0")]
	public static Dictionary<int, string> GGNJOPHADBH(Dictionary<string, GLMBEIECJOO> GHEAAGKLGOO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class CIIOJBGFHGE : HGFLKMEKLGL
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static bool AHDEMOHLMGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly string? NAIOGPHPNEF;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public virtual HGFLKMEKLGL? NHGNJELEAPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8AA280", Offset = "0x8A9680", VA = "0x1808AA280", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6EAFDB0", Offset = "0x6EAF1B0", VA = "0x186EAFDB0")]
	protected CIIOJBGFHGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string AHEFLPEKLMA();

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6EAFBD0", Offset = "0x6EAEFD0", VA = "0x186EAFBD0", Slot = "8")]
	public virtual string JBGGFJCFHHH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6EAF820", Offset = "0x6EAEC20", VA = "0x186EAF820", Slot = "9")]
	public void EOBBOFPAEOD(StringBuilder FBFONFAKGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6EAFAD0", Offset = "0x6EAEED0", VA = "0x186EAFAD0", Slot = "10")]
	public void FOJLCEHJAFJ(StringBuilder FBFONFAKGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6EAF700", Offset = "0x6EAEB00", VA = "0x186EAF700", Slot = "11")]
	public void BDAFJDDIKFJ(StringBuilder FBFONFAKGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6EAFC50", Offset = "0x6EAF050", VA = "0x186EAFC50", Slot = "12")]
	public void MDJJOCBNJLN(StringBuilder FBFONFAKGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6EAFB30", Offset = "0x6EAEF30", VA = "0x186EAFB30")]
	public static void IIHBNPJIMLE(StringBuilder FBFONFAKGFF, string FGIMPLFHDGE, string CPFEJEDBKCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x60532E0", Offset = "0x60526E0", VA = "0x1860532E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class PBLHEMJHLHM : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6EB2B80", Offset = "0x6EB1F80", VA = "0x186EB2B80")]
	public PBLHEMJHLHM(string MOKGCFCFCPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class POPCMDAEELE<TErr> : PBLHEMJHLHM where TErr : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly TErr GDJHJGLALOB;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x4B30C20", Offset = "0x4B30020", VA = "0x184B30C20")]
	private POPCMDAEELE([In] TErr DODFJFOJLKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x4B30B40", Offset = "0x4B2FF40", VA = "0x184B30B40")]
	public static POPCMDAEELE<TErr> AHLALEPNKFA([In] TErr DODFJFOJLKJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class DEAGHIBOGIP : Stream
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly HashAlgorithm LDIFGAJBAMI;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public override bool GPCKNOIDJDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8F2CF0", Offset = "0x8F20F0", VA = "0x1808F2CF0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public override bool LPMMEKDPLED
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8F2CF0", Offset = "0x8F20F0", VA = "0x1808F2CF0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public override bool BCAMLIKIPEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8C4810", Offset = "0x8C3C10", VA = "0x1808C4810", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override long AEFILNEPPMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6EB0180", Offset = "0x6EAF580", VA = "0x186EB0180", Slot = "12")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override long DPFKDMMBOHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6EB01F0", Offset = "0x6EAF5F0", VA = "0x186EB01F0", Slot = "13")]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6EB0260", Offset = "0x6EAF660", VA = "0x186EB0260", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6EB0110", Offset = "0x6EAF510", VA = "0x186EB0110")]
	public DEAGHIBOGIP(HashAlgorithm LDIFGAJBAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6EAFF40", Offset = "0x6EAF340", VA = "0x186EAFF40", Slot = "35")]
	public override int Read(byte[] PCJDGFHBJBI, int OLMEFNCLGNG, int HMELIAGANNM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6EB00E0", Offset = "0x6EAF4E0", VA = "0x186EB00E0", Slot = "38")]
	public override void Write(byte[] PCJDGFHBJBI, int OLMEFNCLGNG, int HMELIAGANNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6EAFFE0", Offset = "0x6EAF3E0", VA = "0x186EAFFE0", Slot = "33")]
	public override long Seek(long OLMEFNCLGNG, SeekOrigin JMGPOCBLPOM)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6EB0070", Offset = "0x6EAF470", VA = "0x186EB0070", Slot = "34")]
	public override void SetLength(long EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "23")]
	public override void Flush()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6EAFE70", Offset = "0x6EAF270", VA = "0x186EAFE70")]
	public byte[] MDLDHGICKDD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface HGFLKMEKLGL
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string JBGGFJCFHHH();

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string AHEFLPEKLMA();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface FBEEFNEHFPG<out TOptions> where TOptions : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	TOptions EEMLDMGPOLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface HPOKKIEAKAO
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	string MCPEOGIBNEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class MDILDGBKIOC<T> : ReadOnlySequenceSegment<T>, IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private static MDILDGBKIOC<T>? KOOOBKCNIED;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private static object LFDJFPCKEHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private IMemoryOwner<T>? CPMLIGFNJEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private bool OGHMMJCABAD;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool ANJBFCDOFPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x92DDA0", Offset = "0x92D1A0", VA = "0x18092DDA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x47B92F0", Offset = "0x47B86F0", VA = "0x1847B92F0")]
	private static MDILDGBKIOC<T> DALKCIAEALG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x47BA5F0", Offset = "0x47B99F0", VA = "0x1847BA5F0")]
	private static void LFNNKINHKFE(MDILDGBKIOC<T> FLGDDOCOGIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x426C960", Offset = "0x426BD60", VA = "0x18426C960")]
	private MDILDGBKIOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x47BA010", Offset = "0x47B9410", VA = "0x1847BA010")]
	public static MDILDGBKIOC<T> JMOKCOIDHBC(ReadOnlyMemory<T> MAFOCOFGAPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x47BA1F0", Offset = "0x47B95F0", VA = "0x1847BA1F0")]
	public static MDILDGBKIOC<T> JMOKCOIDHBC(IMemoryOwner<T> OPEHNHLOPKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x47BABF0", Offset = "0x47B9FF0", VA = "0x1847BABF0")]
	public static void PCPGIMEHOAP(MDILDGBKIOC<T> GEHAOCHHHBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x47B9A60", Offset = "0x47B8E60", VA = "0x1847B9A60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x47B9CF0", Offset = "0x47B90F0", VA = "0x1847B9CF0")]
	public MDILDGBKIOC<T> EBIPGPONPOF(IMemoryOwner<T> OPEHNHLOPKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x47B9F10", Offset = "0x47B9310", VA = "0x1847B9F10")]
	private void JIJELFHJCNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x47B9190", Offset = "0x47B8590", VA = "0x1847B9190")]
	private MDILDGBKIOC<T> CNEMAIDDBBG(MDILDGBKIOC<T> FLGDDOCOGIM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class MBCEJKENHDG : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6EB27B0", Offset = "0x6EB1BB0", VA = "0x186EB27B0")]
	public MBCEJKENHDG(string MOKGCFCFCPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class BLJACCNDEBL<TOk> : MBCEJKENHDG where TOk : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly TOk MLNBAGJDMAG;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x52809A0", Offset = "0x527FDA0", VA = "0x1852809A0")]
	private BLJACCNDEBL([In] TOk APCOPGKCKLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x44F7240", Offset = "0x44F6640", VA = "0x1844F7240")]
	public static BLJACCNDEBL<TOk> AHLALEPNKFA([In] TOk APCOPGKCKLB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public readonly struct LMFFMMPMNDB<TOk, TErr> : IEquatable<LMFFMMPMNDB<TOk, TErr>> where TOk : notnull where TErr : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static readonly EqualityComparer<TErr> LNDMNECEKHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	internal readonly TErr GDJHJGLALOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	internal readonly TOk MLNBAGJDMAG;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool MJELNFAPBGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x45DC320", Offset = "0x45DB720", VA = "0x1845DC320")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool EEIKKINPFFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x45DCA20", Offset = "0x45DBE20", VA = "0x1845DCA20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x45E21C0", Offset = "0x45E15C0", VA = "0x1845E21C0")]
	internal LMFFMMPMNDB([In] TErr DODFJFOJLKJ, [In] TOk APCOPGKCKLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x45D9B60", Offset = "0x45D8F60", VA = "0x1845D9B60")]
	public static LMFFMMPMNDB<TOk, TErr> DEEPMIJIDPB([In] TErr DODFJFOJLKJ)
	{
		return default(LMFFMMPMNDB<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x45DD270", Offset = "0x45DC670", VA = "0x1845DD270")]
	public static LMFFMMPMNDB<TOk, TErr> KJLEKIHFLGK([In] TOk APCOPGKCKLB)
	{
		return default(LMFFMMPMNDB<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x2DA3AF0", Offset = "0x2DA2EF0", VA = "0x182DA3AF0")]
	public LMFFMMPMNDB<TOk?, UErr?> ENPOBDLOBFM<UErr>()
	{
		return default(LMFFMMPMNDB<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2DA3550", Offset = "0x2DA2950", VA = "0x182DA3550")]
	public LMFFMMPMNDB<UOk?, TErr?> EEGFNLIOGLC<UOk>()
	{
		return default(LMFFMMPMNDB<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x2DA4BB0", Offset = "0x2DA3FB0", VA = "0x182DA4BB0")]
	public LMFFMMPMNDB<UOk?, TErr?> NKBHMPMHNBN<UOk>()
	{
		return default(LMFFMMPMNDB<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2DA43B0", Offset = "0x2DA37B0", VA = "0x182DA43B0")]
	public LMFFMMPMNDB<TOk?, UErr?> NFNGHAJHFGE<UErr>()
	{
		return default(LMFFMMPMNDB<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x45D9230", Offset = "0x45D8630", VA = "0x1845D9230")]
	public LMFFMMPMNDB<IOADHBFKJOJ, TErr> BHOPEILHNFC()
	{
		return default(LMFFMMPMNDB<IOADHBFKJOJ, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x45DDA00", Offset = "0x45DCE00", VA = "0x1845DDA00")]
	public static bool LBFMGPFDJNL([In] LMFFMMPMNDB<TOk, TErr> OPJKGPJPNJJ, [In] LMFFMMPMNDB<TOk, TErr> EANFIEEELEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x45DA7A0", Offset = "0x45D9BA0", VA = "0x1845DA7A0", Slot = "4")]
	public bool Equals(LMFFMMPMNDB<TOk, TErr> KNLMODPGFOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x45DA450", Offset = "0x45D9850", VA = "0x1845DA450", Slot = "0")]
	public override bool Equals(object KNLMODPGFOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x45DB920", Offset = "0x45DAD20", VA = "0x1845DB920", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x45DF9C0", Offset = "0x45DEDC0", VA = "0x1845DF9C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class BIBFKJMCJJN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct LMAHOMLDCBE<TOk, TErr> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public AsyncTaskMethodBuilder<TOk> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public Task<LMFFMMPMNDB<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private TaskAwaiter<LMFFMMPMNDB<TOk, TErr>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x45D8300", Offset = "0x45D7700", VA = "0x1845D8300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x45D8980", Offset = "0x45D7D80", VA = "0x1845D8980", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2BF01A0", Offset = "0x2BEF5A0", VA = "0x182BF01A0")]
	public static LMFFMMPMNDB<TOk?, TErr?> MLNBAGJDMAG<TOk, TErr>([In] this LMFFMMPMNDB<TOk, TErr> MCPMOAEEEOJ, [In] TOk APCOPGKCKLB)
	{
		return default(LMFFMMPMNDB<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2BF1D40", Offset = "0x2BF1140", VA = "0x182BF1D40")]
	public static LMFFMMPMNDB<IOADHBFKJOJ, TErr?> MLNBAGJDMAG<TErr>([In] this LMFFMMPMNDB<IOADHBFKJOJ, TErr> MCPMOAEEEOJ)
	{
		return default(LMFFMMPMNDB<IOADHBFKJOJ, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2BF01A0", Offset = "0x2BEF5A0", VA = "0x182BF01A0")]
	public static LMFFMMPMNDB<TOk?, TErr?> GDJHJGLALOB<TOk, TErr>([In] this LMFFMMPMNDB<TOk, TErr> MCPMOAEEEOJ, [In] TErr DODFJFOJLKJ)
	{
		return default(LMFFMMPMNDB<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2BEFDA0", Offset = "0x2BEF1A0", VA = "0x182BEFDA0")]
	public static TOk? EMPDLFKCJPN<TOk, TErr>([In] this LMFFMMPMNDB<TOk, TErr> MCPMOAEEEOJ)
	{
		return (TOk?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2BF15E0", Offset = "0x2BF09E0", VA = "0x182BF15E0")]
	[AsyncStateMachine(typeof(LMAHOMLDCBE<, >))]
	public static Task<TOk?>? JBKIEODIPNH<TOk, TErr>(this Task<LMFFMMPMNDB<TOk, TErr>> MCPMOAEEEOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x2BEF4D0", Offset = "0x2BEE8D0", VA = "0x182BEF4D0")]
	public static TErr? APCAIINHAOF<TErr, TOk>([In] this LMFFMMPMNDB<TOk, TErr> MCPMOAEEEOJ)
	{
		return (TErr?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x2BF0400", Offset = "0x2BEF800", VA = "0x182BF0400")]
	public static bool HBBENILGLLH<TOk, TErr, UErr, UOk>([In] this LMFFMMPMNDB<TOk, TErr> MCPMOAEEEOJ, [Out] LMFFMMPMNDB<UOk, UErr> KLDGHNLKHJA) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x2BF0310", Offset = "0x2BEF710", VA = "0x182BF0310")]
	public static bool GOFJDKNLLJF<TOk, TErr>([In] this LMFFMMPMNDB<TOk, TErr> MCPMOAEEEOJ, [Out][NotNullWhen(true)] TOk APCOPGKCKLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x2BEFAC0", Offset = "0x2BEEEC0", VA = "0x182BEFAC0")]
	public static bool DGMEMHFBCDL<TOk, TErr>([In] this LMFFMMPMNDB<TOk, TErr> MCPMOAEEEOJ, [Out][NotNullWhen(true)] TErr DODFJFOJLKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x2BF1F80", Offset = "0x2BF1380", VA = "0x182BF1F80")]
	public static bool NCFGKOGNABJ<TOk, TErr>([In] this LMFFMMPMNDB<TOk, TErr> MCPMOAEEEOJ, [Out][NotNullWhen(true)] TOk APCOPGKCKLB, [Out][NotNullWhen(false)] TErr DODFJFOJLKJ) where TOk : notnull where TErr : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x2BF2000", Offset = "0x2BF1400", VA = "0x182BF2000")]
	public static bool NJJKACLLECB<TOk, TErr>([In] this LMFFMMPMNDB<TOk, TErr> MCPMOAEEEOJ, [Out][NotNullWhen(true)] TOk APCOPGKCKLB, [Out] LMFFMMPMNDB<TOk, TErr> KLDGHNLKHJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x2BF07A0", Offset = "0x2BEFBA0", VA = "0x182BF07A0")]
	public static bool HBBENILGLLH<TOk, TErr, UErr, UOk>([In] this LMFFMMPMNDB<TOk, TErr> MCPMOAEEEOJ, [Out][NotNullWhen(true)] TOk APCOPGKCKLB, [Out] LMFFMMPMNDB<UOk, UErr> KLDGHNLKHJA) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x2BF1990", Offset = "0x2BF0D90", VA = "0x182BF1990")]
	public static bool MFHGEPHHDCH<TOk, TErr>([In] this LMFFMMPMNDB<TOk, TErr> MCPMOAEEEOJ, [Out][NotNullWhen(true)] TOk APCOPGKCKLB, [Out] LMFFMMPMNDB<IOADHBFKJOJ, TErr> KLDGHNLKHJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x2BEEF50", Offset = "0x2BEE350", VA = "0x182BEEF50")]
	public static LMFFMMPMNDB<UOk, UErr> ANIHEEMDABN<UOk, UErr, TOk, TErr>([In] this LMFFMMPMNDB<TOk, TErr> MCPMOAEEEOJ, [In] LMFFMMPMNDB<UOk, UErr> EFCBJHHANBC) where TOk : UOk where TErr : UErr
	{
		return default(LMFFMMPMNDB<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x2BEF6E0", Offset = "0x2BEEAE0", VA = "0x182BEF6E0")]
	public static LMFFMMPMNDB<TOk?[]?, TErr?> BPIFABLPCNP<TOk, TErr>(this IEnumerable<LMFFMMPMNDB<TOk, TErr>> MCPMOAEEEOJ)
	{
		return default(LMFFMMPMNDB<TOk[], TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class PEEPEEKIPBM<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x2EF1BF0", Offset = "0x2EF0FF0", VA = "0x182EF1BF0")]
	public static LMFFMMPMNDB<TOk, T> MLNBAGJDMAG<TOk>([In] TOk APCOPGKCKLB) where TOk : notnull
	{
		return default(LMFFMMPMNDB<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x4AD6D20", Offset = "0x4AD6120", VA = "0x184AD6D20")]
	public static LMFFMMPMNDB<IOADHBFKJOJ, T> MLNBAGJDMAG()
	{
		return default(LMFFMMPMNDB<IOADHBFKJOJ, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x2EF1BF0", Offset = "0x2EF0FF0", VA = "0x182EF1BF0")]
	public static LMFFMMPMNDB<T, TErr> GDJHJGLALOB<TErr>([In] TErr DODFJFOJLKJ) where TErr : notnull
	{
		return default(LMFFMMPMNDB<T, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public readonly struct DAAHKLNFALJ<TKey, TValue> where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly DJEIJHONINJ IPDNFNMKFEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly Dictionary<TKey, TValue> INLFPJIAFAC;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x3F63810", Offset = "0x3F62C10", VA = "0x183F63810")]
	public static DAAHKLNFALJ<TKey, TValue> AHLALEPNKFA(string OMHMFLHBNDJ)
	{
		return default(DAAHKLNFALJ<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x3F639F0", Offset = "0x3F62DF0", VA = "0x183F639F0")]
	internal DAAHKLNFALJ(Dictionary<TKey, TValue> EEPLCHCGAIN, DJEIJHONINJ ONBJDHLPALG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x3F63940", Offset = "0x3F62D40", VA = "0x183F63940")]
	public KHFNBKIEHAO<TKey, TValue> CAOCIMPIIFI([Out] Dictionary<TKey, TValue> EEPLCHCGAIN)
	{
		return default(KHFNBKIEHAO<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public readonly struct KHFNBKIEHAO<TKey, TValue> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly Dictionary<TKey, TValue> INLFPJIAFAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly CHKEPPGCIDH KFJCBBPMHHI;

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x23DA7C0", Offset = "0x23D9BC0", VA = "0x1823DA7C0")]
	internal KHFNBKIEHAO(Dictionary<TKey, TValue> EEPLCHCGAIN, CHKEPPGCIDH PAHEBJGCEMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x40BE370", Offset = "0x40BD770", VA = "0x1840BE370", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public readonly struct LDBJCHOCKJD<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly DJEIJHONINJ IPDNFNMKFEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly HashSet<T> INLFPJIAFAC;

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x3F63810", Offset = "0x3F62C10", VA = "0x183F63810")]
	public static LDBJCHOCKJD<T> AHLALEPNKFA(string OMHMFLHBNDJ)
	{
		return default(LDBJCHOCKJD<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x3F639F0", Offset = "0x3F62DF0", VA = "0x183F639F0")]
	internal LDBJCHOCKJD(HashSet<T> EEPLCHCGAIN, DJEIJHONINJ ONBJDHLPALG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x3F63940", Offset = "0x3F62D40", VA = "0x183F63940")]
	public JDLDJLFIONJ<T> CAOCIMPIIFI([Out] HashSet<T> EEPLCHCGAIN)
	{
		return default(JDLDJLFIONJ<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public readonly struct JDLDJLFIONJ<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly HashSet<T> INLFPJIAFAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly CHKEPPGCIDH KFJCBBPMHHI;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x23DA7C0", Offset = "0x23D9BC0", VA = "0x1823DA7C0")]
	internal JDLDJLFIONJ(HashSet<T> EEPLCHCGAIN, CHKEPPGCIDH PAHEBJGCEMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x40BE370", Offset = "0x40BD770", VA = "0x1840BE370", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct FNJGLPGEDEN<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly DJEIJHONINJ IPDNFNMKFEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly Stack<T> INLFPJIAFAC;

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x3F63810", Offset = "0x3F62C10", VA = "0x183F63810")]
	public static FNJGLPGEDEN<T> AHLALEPNKFA(string OMHMFLHBNDJ)
	{
		return default(FNJGLPGEDEN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x3F639F0", Offset = "0x3F62DF0", VA = "0x183F639F0")]
	internal FNJGLPGEDEN(Stack<T> EEPLCHCGAIN, DJEIJHONINJ ONBJDHLPALG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3F63940", Offset = "0x3F62D40", VA = "0x183F63940")]
	public GNIBMEIEKJJ<T> CAOCIMPIIFI([Out] Stack<T> EEPLCHCGAIN)
	{
		return default(GNIBMEIEKJJ<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct GNIBMEIEKJJ<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly Stack<T> INLFPJIAFAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly CHKEPPGCIDH KFJCBBPMHHI;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x23DA7C0", Offset = "0x23D9BC0", VA = "0x1823DA7C0")]
	internal GNIBMEIEKJJ(Stack<T> EEPLCHCGAIN, CHKEPPGCIDH PAHEBJGCEMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x40BE370", Offset = "0x40BD770", VA = "0x1840BE370", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[DefaultMember("Item")]
public sealed class PODIGMFMMHK<T> : IEnumerable<T>, IEnumerable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private readonly struct KIEOPBHCKDC : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly PODIGMFMMHK<T> BAIKAGNNDHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly int PNNGGMMGIDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly bool KMCMGDFGBCF;

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x2114150", Offset = "0x2113550", VA = "0x182114150")]
		public KIEOPBHCKDC(PODIGMFMMHK<T> JPNNGBEFPIE, int LLBDFDFGJGK, bool JIHCCFOLBKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x4508C40", Offset = "0x4508040", VA = "0x184508C40")]
		public PODIGMFMMHK<T>.HKBPDCJPOJJ JLDAKMOMDIF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x4508D40", Offset = "0x4508140", VA = "0x184508D40", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x4508D40", Offset = "0x4508140", VA = "0x184508D40", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public sealed class HKBPDCJPOJJ : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly PODIGMFMMHK<T> BAIKAGNNDHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly int IDIJLCPKGAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private int FCILIKFJDIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly bool KMCMGDFGBCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private bool FAOMMOPDEOL;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public T GKCMOMIKDKD
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x4169E90", Offset = "0x4169290", VA = "0x184169E90")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x4169FC0", Offset = "0x41693C0", VA = "0x184169FC0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x416A140", Offset = "0x4169540", VA = "0x18416A140", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x416A840", Offset = "0x4169C40", VA = "0x18416A840")]
		public HKBPDCJPOJJ(PODIGMFMMHK<T> JPNNGBEFPIE, int LLBDFDFGJGK, bool JIHCCFOLBKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x4169DB0", Offset = "0x41691B0", VA = "0x184169DB0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x4169F50", Offset = "0x4169350", VA = "0x184169F50", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class CMPMBHPDBNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public CMPMBHPDBNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x5A77970", Offset = "0x5A76D70", VA = "0x185A77970")]
		internal T LDLJEKOJOFM(int _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly T[] BMKCKOPDOEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int FCILIKFJDIG;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int KFCPKIEAGMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x4B2FF90", Offset = "0x4B2F390", VA = "0x184B2FF90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public T GKCMOMIKDKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x3F26AA0", Offset = "0x3F25EA0", VA = "0x183F26AA0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public T NMKLPFBIAMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x4B300C0", Offset = "0x4B2F4C0", VA = "0x184B300C0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public T MGACFGHHFEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x4B30320", Offset = "0x4B2F720", VA = "0x184B30320")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int AEFILNEPPMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x1DD16E0", Offset = "0x1DD0AE0", VA = "0x181DD16E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x1476080", Offset = "0x1475480", VA = "0x181476080")]
	private static int GIJCNGIJALM(int HAJICDLBEKC, int LOKMFEIHLAN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x4B30390", Offset = "0x4B2F790", VA = "0x184B30390")]
	public PODIGMFMMHK(int IKJKAFPPDBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x4B30420", Offset = "0x4B2F820", VA = "0x184B30420")]
	public PODIGMFMMHK(int IKJKAFPPDBP, Func<T> CDAHMCKNDJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x4B30870", Offset = "0x4B2FC70", VA = "0x184B30870")]
	public PODIGMFMMHK(T[] JHBKFOICCJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x4B301A0", Offset = "0x4B2F5A0", VA = "0x184B301A0")]
	public void OAJGBINGJKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x4B2FFF0", Offset = "0x4B2F3F0", VA = "0x184B2FFF0")]
	public IEnumerable<T> HIOPHIGOEHA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x4B30100", Offset = "0x4B2F500", VA = "0x184B30100")]
	public PODIGMFMMHK<T>.HKBPDCJPOJJ JLDAKMOMDIF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x3FADDF0", Offset = "0x3FAD1F0", VA = "0x183FADDF0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x3FADDF0", Offset = "0x3FAD1F0", VA = "0x183FADDF0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class DFNBAMPOHPF
{
	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x2CA1A80", Offset = "0x2CA0E80", VA = "0x182CA1A80")]
	public static PODIGMFMMHK<T> AHLALEPNKFA<T>(int IKJKAFPPDBP, Func<T> CDAHMCKNDJF) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public sealed class DPHJFGCHALP<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public readonly struct JNNGGHIAFIN : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly DPHJFGCHALP<T> DCHFKCKCGCA;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public T EEMLDMGPOLA
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x442CBD0", Offset = "0x442BFD0", VA = "0x18442CBD0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x442CBA0", Offset = "0x442BFA0", VA = "0x18442CBA0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0xBF8A90", Offset = "0xBF7E90", VA = "0x180BF8A90")]
		public JNNGGHIAFIN(DPHJFGCHALP<T> DCHFKCKCGCA)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct FLEKFMHBJFK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public AsyncTaskMethodBuilder<JNNGGHIAFIN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public DPHJFGCHALP<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x3F52BF0", Offset = "0x3F51FF0", VA = "0x183F52BF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x3F530D0", Offset = "0x3F524D0", VA = "0x183F530D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly SemaphoreSlim FFAGCFOPDAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private T INOPIMDINAD;

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x5CD5610", Offset = "0x5CD4A10", VA = "0x185CD5610")]
	public DPHJFGCHALP([In] T INOPIMDINAD, int CDFHLJFCALB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x5CD5530", Offset = "0x5CD4930", VA = "0x185CD5530")]
	public DPHJFGCHALP([In] T INOPIMDINAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x5CD4F40", Offset = "0x5CD4340", VA = "0x185CD4F40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x5CD5440", Offset = "0x5CD4840", VA = "0x185CD5440")]
	public JNNGGHIAFIN KLCAJKCGFGI()
	{
		return default(JNNGGHIAFIN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5CD50B0", Offset = "0x5CD44B0", VA = "0x185CD50B0")]
	[AsyncStateMachine(typeof(DPHJFGCHALP<>.FLEKFMHBJFK))]
	public Task<DPHJFGCHALP<T>.JNNGGHIAFIN> EDHAHECOIKH(CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5CD4F20", Offset = "0x5CD4320", VA = "0x185CD4F20")]
	public void BCFNDPFOMPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class CGGLCAEKDHE
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6EAF670", Offset = "0x6EAEA70", VA = "0x186EAF670")]
	public static DPHJFGCHALP<IOADHBFKJOJ> AHLALEPNKFA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x2C61870", Offset = "0x2C60C70", VA = "0x182C61870")]
	public static DPHJFGCHALP<T> AHLALEPNKFA<T>([In] T INOPIMDINAD) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class JJJLCGMINHK<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public readonly struct KDFBLPDCOGD : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private readonly JJJLCGMINHK<T> IMADGGODDAO;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public T EEMLDMGPOLA
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x3FD64A0", Offset = "0x3FD58A0", VA = "0x183FD64A0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x44FC0A0", Offset = "0x44FB4A0", VA = "0x1844FC0A0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0xBF8A90", Offset = "0xBF7E90", VA = "0x180BF8A90")]
		internal KDFBLPDCOGD(JJJLCGMINHK<T> DCHFKCKCGCA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public readonly struct AFEFDGFEPIK : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private readonly JJJLCGMINHK<T> IMADGGODDAO;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public T EEMLDMGPOLA
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x3FD64A0", Offset = "0x3FD58A0", VA = "0x183FD64A0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x3FD63B0", Offset = "0x3FD57B0", VA = "0x183FD63B0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0xBF8A90", Offset = "0xBF7E90", VA = "0x180BF8A90")]
		internal AFEFDGFEPIK(JJJLCGMINHK<T> DCHFKCKCGCA)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct ICKNDHJNMIJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public AsyncTaskMethodBuilder<AFEFDGFEPIK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public JJJLCGMINHK<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private DPHJFGCHALP<IOADHBFKJOJ>.JNNGGHIAFIN <writeLock>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private TaskAwaiter<DPHJFGCHALP<IOADHBFKJOJ>.JNNGGHIAFIN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x4233ED0", Offset = "0x42332D0", VA = "0x184233ED0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x3F530D0", Offset = "0x3F524D0", VA = "0x183F530D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly DPHJFGCHALP<int> BDPGGCABBJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly DPHJFGCHALP<IOADHBFKJOJ> OAPKDLHMPAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly DPHJFGCHALP<IOADHBFKJOJ> HODGNAEEMMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private T JJJEFNDPACF;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x44229C0", Offset = "0x4421DC0", VA = "0x1844229C0")]
	internal JJJLCGMINHK(DPHJFGCHALP<int> FNPBJFEMMMK, DPHJFGCHALP<IOADHBFKJOJ> LGJGEFLMOFM, DPHJFGCHALP<IOADHBFKJOJ> BMEBDPJMMGA, [In] T INOPIMDINAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x4421ED0", Offset = "0x44212D0", VA = "0x184421ED0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x4422720", Offset = "0x4421B20", VA = "0x184422720")]
	public KDFBLPDCOGD OKBDMFOHPEL()
	{
		return default(KDFBLPDCOGD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x4421AA0", Offset = "0x4420EA0", VA = "0x184421AA0")]
	public AFEFDGFEPIK DPGCHBPIEOI()
	{
		return default(AFEFDGFEPIK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x44221B0", Offset = "0x44215B0", VA = "0x1844221B0")]
	[AsyncStateMachine(typeof(JJJLCGMINHK<>.ICKNDHJNMIJ))]
	public Task<JJJLCGMINHK<T>.AFEFDGFEPIK> ICOODKJLLJM(CancellationToken NBBCMDKGJKI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class JNMNIMNIEON
{
	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x6EB2040", Offset = "0x6EB1440", VA = "0x186EB2040")]
	public static JJJLCGMINHK<IOADHBFKJOJ> AHLALEPNKFA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x2EB8B20", Offset = "0x2EB7F20", VA = "0x182EB8B20")]
	public static JJJLCGMINHK<T> AHLALEPNKFA<T>([In] T INOPIMDINAD) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public sealed class GOMBJPOKDFF<TData> : CIIOJBGFHGE where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly string LIEABGFDIKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly TData LMIMGNACAMD;

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x8A89C0", Offset = "0x8A7DC0", VA = "0x1808A89C0", Slot = "7")]
	public override string AHEFLPEKLMA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x40C3830", Offset = "0x40C2C30", VA = "0x1840C3830")]
	internal GOMBJPOKDFF(string MOKGCFCFCPE, [In] TData AIKOCCMKKAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class FDENBOIFDJF
{
	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x6EB05D0", Offset = "0x6EAF9D0", VA = "0x186EB05D0")]
	public static GOMBJPOKDFF<IOADHBFKJOJ> AHLALEPNKFA(string MOKGCFCFCPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x2C63150", Offset = "0x2C62550", VA = "0x182C63150")]
	public static GOMBJPOKDFF<TData> AHLALEPNKFA<TData>(string MOKGCFCFCPE, [In] TData AIKOCCMKKAE) where TData : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public sealed class DJEIJHONINJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	internal bool KDGFBCJKJAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly string MDFEEMJGKLE;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x969640", Offset = "0x968A40", VA = "0x180969640")]
	private DJEIJHONINJ(bool ABKKOCMFAMC, string LHFNHAMHDEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x6EB02D0", Offset = "0x6EAF6D0", VA = "0x186EB02D0")]
	public static DJEIJHONINJ AHLALEPNKFA(string LHFNHAMHDEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x6EB0340", Offset = "0x6EAF740", VA = "0x186EB0340")]
	public CHKEPPGCIDH CAOCIMPIIFI()
	{
		return default(CHKEPPGCIDH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public readonly struct CHKEPPGCIDH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly DJEIJHONINJ APABKECOCIH;

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0xBF8A90", Offset = "0xBF7E90", VA = "0x180BF8A90")]
	internal CHKEPPGCIDH(DJEIJHONINJ OMHMFLHBNDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x6EAF6E0", Offset = "0x6EAEAE0", VA = "0x186EAF6E0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[Obsolete("Use SimpleTokenFlag or WeakTokenFlag<T> instead")]
public sealed class FHOLMMGHBAH<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class DJPMECHOOOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public DJPMECHOOOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x5CA8420", Offset = "0x5CA7820", VA = "0x185CA8420")]
		internal int JIHBGMGNKEO(int i, T token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private HashSet<T>? EIPMOHNHPJH;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public IReadOnlyCollection<T> BOKJLCAEEIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x3F45F30", Offset = "0x3F45330", VA = "0x183F45F30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool KNOHPCPGHDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x3F45D10", Offset = "0x3F45110", VA = "0x183F45D10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int ICBOPDBFFOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x8AACD0", Offset = "0x8AA0D0", VA = "0x1808AACD0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x8AACE0", Offset = "0x8AA0E0", VA = "0x1808AACE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x3F45F70", Offset = "0x3F45370", VA = "0x183F45F70")]
	public bool LEFBGNCKNFL(T ABHFNNFMPHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x3F45D60", Offset = "0x3F45160", VA = "0x183F45D60")]
	public bool BJFEGIDGDBE(T ABHFNNFMPHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x3F45EE0", Offset = "0x3F452E0", VA = "0x183F45EE0")]
	public bool FLEJEGPKCKH(T ABHFNNFMPHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x3F46150", Offset = "0x3F45550", VA = "0x183F46150")]
	public void OCBFFHDJJHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x3F46240", Offset = "0x3F45640", VA = "0x183F46240", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
	public FHOLMMGHBAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public sealed class GDCNMJIEPIF
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class EKKMCNOJLCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public EKKMCNOJLCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x6EB0400", Offset = "0x6EAF800", VA = "0x186EB0400")]
		internal int JIHBGMGNKEO(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private HashSet<object>? EIPMOHNHPJH;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public IReadOnlyCollection<object> BOKJLCAEEIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x6EB0760", Offset = "0x6EAFB60", VA = "0x186EB0760")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool KNOHPCPGHDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x6EB0650", Offset = "0x6EAFA50", VA = "0x186EB0650")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int ICBOPDBFFOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x8AACD0", Offset = "0x8AA0D0", VA = "0x1808AACD0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x8AACE0", Offset = "0x8AA0E0", VA = "0x1808AACE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6EB07F0", Offset = "0x6EAFBF0", VA = "0x186EB07F0")]
	public bool LEFBGNCKNFL(object ABHFNNFMPHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6EB0660", Offset = "0x6EAFA60", VA = "0x186EB0660")]
	public bool BJFEGIDGDBE(object ABHFNNFMPHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6EB0700", Offset = "0x6EAFB00", VA = "0x186EB0700")]
	public bool FLEJEGPKCKH(object ABHFNNFMPHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6EB08D0", Offset = "0x6EAFCD0", VA = "0x186EB08D0")]
	public void OCBFFHDJJHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6EB0940", Offset = "0x6EAFD40", VA = "0x186EB0940", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
	public GDCNMJIEPIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class JGNIEIOFKJG<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private struct LHEDIIMBAAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public float LFAIHDPAPLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public T EEMLDMGPOLA;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly Dictionary<object, LHEDIIMBAAN> BNDGLAGJGHN;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public virtual T KOJFFFDGDBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x13630E0", Offset = "0x13624E0", VA = "0x1813630E0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x1361AF0", Offset = "0x1360EF0", VA = "0x181361AF0", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public object? LEDGCHHLECF
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x8AAD10", Offset = "0x8AA110", VA = "0x1808AAD10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x8AAD00", Offset = "0x8AA100", VA = "0x1808AAD00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool JHLGCKKMJOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x441DE50", Offset = "0x441D250", VA = "0x18441DE50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x441DAD0", Offset = "0x441CED0", VA = "0x18441DAD0")]
	public bool GJNKIFOCKMF(T EEPLCHCGAIN, object ABHFNNFMPHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x40C22D0", Offset = "0x40C16D0", VA = "0x1840C22D0")]
	public bool BGGIECNKLKA(object ABHFNNFMPHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x4123E20", Offset = "0x4123220", VA = "0x184123E20")]
	public void KMNEPMPOIBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x441E190", Offset = "0x441D590", VA = "0x18441E190")]
	public bool LCKMIEGKAOE(object ABHFNNFMPHA, [Out] T EEPLCHCGAIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x441BEB0", Offset = "0x441B2B0", VA = "0x18441BEB0")]
	[BFAKOGDFABI("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool ECFHIGPMJOD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x40C2BA0", Offset = "0x40C1FA0", VA = "0x1840C2BA0")]
	public JGNIEIOFKJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public sealed class DDAANIDIMGM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly string KKDDKGKCAGB;

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x8B47B0", Offset = "0x8B3BB0", VA = "0x1808B47B0")]
	public DDAANIDIMGM(string KKDDKGKCAGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6EAFE20", Offset = "0x6EAF220", VA = "0x186EAFE20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public sealed class MJALCEKKLBP<T> where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private List<WeakReference<T>>? EIPMOHNHPJH;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool KNOHPCPGHDI
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x47EF5A0", Offset = "0x47EE9A0", VA = "0x1847EF5A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public int ICBOPDBFFOG
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x47EF880", Offset = "0x47EEC80", VA = "0x1847EF880")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x47EFA30", Offset = "0x47EEE30", VA = "0x1847EFA30")]
	public void LEFBGNCKNFL(T ABHFNNFMPHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x47EF6D0", Offset = "0x47EEAD0", VA = "0x1847EF6D0")]
	public void BJFEGIDGDBE(T ABHFNNFMPHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x47EFCC0", Offset = "0x47EF0C0", VA = "0x1847EFCC0")]
	public void OCBFFHDJJHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x47EFD10", Offset = "0x47EF110", VA = "0x1847EFD10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
	public MJALCEKKLBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal static class OFAADHEHCPA
{
	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x2F24810", Offset = "0x2F23C10", VA = "0x182F24810")]
	public static void HOMCHKJBOIP<T>(this List<T> KDBAFFDDPME, int HAJICDLBEKC) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public class OPPFMDKPODC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly Dictionary<object, float> BNDGLAGJGHN;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public float FKGPMOGFKIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0xA2AE70", Offset = "0xA2A270", VA = "0x180A2AE70")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xA2AAD0", Offset = "0xA29ED0", VA = "0x180A2AAD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6EB2900", Offset = "0x6EB1D00", VA = "0x186EB2900")]
	public void GJNKIFOCKMF(float EEPLCHCGAIN, object ABHFNNFMPHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6EB2890", Offset = "0x6EB1C90", VA = "0x186EB2890")]
	public void BGGIECNKLKA(object ABHFNNFMPHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6EB2970", Offset = "0x6EB1D70", VA = "0x186EB2970")]
	public void KMNEPMPOIBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x6EB29C0", Offset = "0x6EB1DC0", VA = "0x186EB29C0")]
	private void MLNCKNIOAMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6EB2AF0", Offset = "0x6EB1EF0", VA = "0x186EB2AF0")]
	public OPPFMDKPODC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public interface ADPKMNDFFIC
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event KDLDBEDPPNM ONNPBDAPDLN;
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class GPJADLBIKFB : ADPKMNDFFIC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public readonly struct LGHCEEGNJHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public readonly float FMHCNCBOPAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public readonly float KNNOOCDGMKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		internal readonly bool CPKPPJFCLGP;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public float GDNEEEAIONI
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x6EB24D0", Offset = "0x6EB18D0", VA = "0x186EB24D0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x6EB2650", Offset = "0x6EB1A50", VA = "0x186EB2650")]
		public LGHCEEGNJHB(float IJLPKFECKFC, float LELDIOMELDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x6EB24E0", Offset = "0x6EB18E0", VA = "0x186EB24E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class KPJOOGDNHAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public GPJADLBIKFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public KPJOOGDNHAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x6EB2110", Offset = "0x6EB1510", VA = "0x186EB2110")]
		internal void CKLIECPCFMF(float innerProgress)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly int BIMLHBENMHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private int AKIOAGLJFCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly ADPKMNDFFIC[] OLHGHFGENGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly KDLDBEDPPNM[] BLDEOEOIGBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly LGHCEEGNJHB[] EAOKKELJEFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private LGHCEEGNJHB CALKJKPLPDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly HGBMDJBMOFN JHCJLHGEBIC;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event KDLDBEDPPNM ONNPBDAPDLN
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x6EB1A90", Offset = "0x6EB0E90", VA = "0x186EB1A90", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x6EB13B0", Offset = "0x6EB07B0", VA = "0x186EB13B0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x6EB1B50", Offset = "0x6EB0F50", VA = "0x186EB1B50")]
	public GPJADLBIKFB(int BIMLHBENMHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x6EB18F0", Offset = "0x6EB0CF0", VA = "0x186EB18F0")]
	public HGBMDJBMOFN APMOKMGCFPG(LGHCEEGNJHB HAIEMBCHPMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6EB1470", Offset = "0x6EB0870", VA = "0x186EB1470")]
	public void APLGJENGDBN(ADPKMNDFFIC PFGONNKILCA, [Optional] LGHCEEGNJHB JMLIFGCDONL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x6EB1980", Offset = "0x6EB0D80", VA = "0x186EB1980", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public delegate void KDLDBEDPPNM(float DPLFOEEOPEB);
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class JFHICKGBJIN
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class EPKDAPNAMFP : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private readonly ADPKMNDFFIC FEBENODHHAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private readonly KDLDBEDPPNM JMKLCPOKHHP;

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x6EB0540", Offset = "0x6EAF940", VA = "0x186EB0540")]
		public EPKDAPNAMFP(ADPKMNDFFIC FEBENODHHAD, KDLDBEDPPNM JMKLCPOKHHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x6EB04F0", Offset = "0x6EAF8F0", VA = "0x186EB04F0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x6EB1FD0", Offset = "0x6EB13D0", VA = "0x186EB1FD0")]
	internal static bool OJIDDOIEFPJ(float NIPIGODEADI, float BCMPBHCEGGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x6E9EDC0", Offset = "0x6E9E1C0", VA = "0x186E9EDC0")]
	internal static float CFJIHAEGDJO(float NIPIGODEADI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x6EB1F10", Offset = "0x6EB1310", VA = "0x186EB1F10")]
	public static IDisposable OEOCOJPJLCA(this ADPKMNDFFIC FEBENODHHAD, KDLDBEDPPNM JMKLCPOKHHP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class HGBMDJBMOFN : ADPKMNDFFIC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private float DPLFOEEOPEB;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public float OBOEBGMFKKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x6EB1E20", Offset = "0x6EB1220", VA = "0x186EB1E20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event KDLDBEDPPNM? ONNPBDAPDLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x6EB1D80", Offset = "0x6EB1180", VA = "0x186EB1D80", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x6EB1CE0", Offset = "0x6EB10E0", VA = "0x186EB1CE0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
	public HGBMDJBMOFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public interface LGILLMLJFAF<T> where T : class, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MPMAOOEDDFA<T> BJKLPNDFDNG([Out] T EEPLCHCGAIN);

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KMNEPMPOIBK();
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class BELDPKKKEKC<T> : LGILLMLJFAF<T> where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly ConcurrentStack<T> IOPKJBKGLAB;

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x5233370", Offset = "0x5232770", VA = "0x185233370", Slot = "4")]
	public MPMAOOEDDFA<T> BJKLPNDFDNG([Out] T EEPLCHCGAIN)
	{
		return default(MPMAOOEDDFA<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x52334C0", Offset = "0x52328C0", VA = "0x1852334C0")]
	public void HNEMOMPNNFO(T FCCMKMKPGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x3F3A920", Offset = "0x3F39D20", VA = "0x183F3A920", Slot = "5")]
	public void KMNEPMPOIBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "6")]
	protected virtual void AFOEJBPJONN(T PAKKFLLCGCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x5233410", Offset = "0x5232810", VA = "0x185233410")]
	private T CADKKGPFCDD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x5233540", Offset = "0x5232940", VA = "0x185233540")]
	public BELDPKKKEKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public readonly struct MPMAOOEDDFA<T> : IDisposable where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly T FCCMKMKPGFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly BELDPKKKEKC<T> OKEFGGEHACK;

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0xD74C00", Offset = "0xD74000", VA = "0x180D74C00")]
	internal MPMAOOEDDFA(T EEPLCHCGAIN, BELDPKKKEKC<T> OKEFGGEHACK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x4857C60", Offset = "0x4857060", VA = "0x184857C60", Slot = "4")]
	void IDisposable.Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public class AOONCKGCJCE : BELDPKKKEKC<StringBuilder>
{
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public static readonly AOONCKGCJCE GJPJBBHLIHD;

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6EAF500", Offset = "0x6EAE900", VA = "0x186EAF500")]
	public static MPMAOOEDDFA<StringBuilder> CADKKGPFCDD([Out] StringBuilder EEPLCHCGAIN)
	{
		return default(MPMAOOEDDFA<StringBuilder>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x6EAF4E0", Offset = "0x6EAE8E0", VA = "0x186EAF4E0", Slot = "6")]
	protected override void AFOEJBPJONN(StringBuilder PAKKFLLCGCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6EAF630", Offset = "0x6EAEA30", VA = "0x186EAF630")]
	public AOONCKGCJCE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class IIKGPKFECGA : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x68FD1B0", Offset = "0x68FC5B0", VA = "0x1868FD1B0")]
	public IIKGPKFECGA(string MOKGCFCFCPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[DefaultMember("Item")]
public class ENEMJFEDALG<TKey, TValue> : BIFOCOBKOJN<TKey, TValue>, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, LDGPNDOEGHO where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class HMNCKMCFBKF : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private KeyValuePair<TKey, TValue> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public ENEMJFEDALG<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private IEnumerator<KeyValuePair<TKey, TValue>> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		KeyValuePair<TKey, TValue> IEnumerator<KeyValuePair<TKey, TValue>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x13630E0", Offset = "0x13624E0", VA = "0x1813630E0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x41739E0", Offset = "0x4172DE0", VA = "0x1841739E0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x8B2270", Offset = "0x8B1670", VA = "0x1808B2270")]
		[DebuggerHidden]
		public HMNCKMCFBKF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x3EA2B30", Offset = "0x3EA1F30", VA = "0x183EA2B30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x4173500", Offset = "0x4172900", VA = "0x184173500", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x4172AC0", Offset = "0x4171EC0", VA = "0x184172AC0")]
		private void CPDIPGODGJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x4172B60", Offset = "0x4171F60", VA = "0x184172B60")]
		private void FKMGMNDEOBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x4173990", Offset = "0x4172D90", VA = "0x184173990", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly BIFOCOBKOJN<TKey, TValue> FABIOCEMIGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly IDictionary<TKey, TValue> HJJIMJOKDEB;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int ICBOPDBFFOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x3BAD5F0", Offset = "0x3BAC9F0", VA = "0x183BAD5F0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool IHEEMPBAFPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x8F2CF0", Offset = "0x8F20F0", VA = "0x1808F2CF0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public TValue MGACFGHHFEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x3BAD8A0", Offset = "0x3BACCA0", VA = "0x183BAD8A0", Slot = "4")]
		get
		{
			return (TValue)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x3BADB90", Offset = "0x3BACF90", VA = "0x183BADB90", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public ICollection<TKey> HDCGPPCFMPE
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x3BAD8F0", Offset = "0x3BACCF0", VA = "0x183BAD8F0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public ICollection<TValue> ENHONGHAPHM
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x3BADA20", Offset = "0x3BACE20", VA = "0x183BADA20", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x3BAD520", Offset = "0x3BAC920", VA = "0x183BAD520")]
	public ENEMJFEDALG(BIFOCOBKOJN<TKey, TValue> FABIOCEMIGG, [Optional] IDictionary<TKey, TValue>? HJJIMJOKDEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x3BAAF80", Offset = "0x3BAA380", VA = "0x183BAAF80", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x3BABDC0", Offset = "0x3BAB1C0", VA = "0x183BABDC0")]
	public void GELJFIBGACC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x3BAAA30", Offset = "0x3BA9E30", VA = "0x183BAAA30", Slot = "9")]
	public void Add(TKey OEOMDKHBDFI, TValue EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x3BAB880", Offset = "0x3BAAC80", VA = "0x183BAB880")]
	public void DDCMNNCGODC(TKey OEOMDKHBDFI, TValue EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x3BAC190", Offset = "0x3BAB590", VA = "0x183BAC190")]
	public void LNHHPFGFPIK(TKey OEOMDKHBDFI, TValue EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x3BAC670", Offset = "0x3BABA70", VA = "0x183BAC670")]
	public void ONGKOGEGMJB(TKey OEOMDKHBDFI, TValue EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x3BAAE80", Offset = "0x3BAA280", VA = "0x183BAAE80")]
	public void CNCLOFIEEAL(TKey OEOMDKHBDFI, TValue EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x3BACB50", Offset = "0x3BABF50", VA = "0x183BACB50", Slot = "14")]
	void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> HHDONFMCNBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x3BACD40", Offset = "0x3BAC140", VA = "0x183BACD40", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> HHDONFMCNBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x3BACF00", Offset = "0x3BAC300", VA = "0x183BACF00", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> HHDONFMCNBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x3BAB010", Offset = "0x3BAA410", VA = "0x183BAB010", Slot = "8")]
	public bool ContainsKey(TKey OEOMDKHBDFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x3BAACC0", Offset = "0x3BAA0C0", VA = "0x183BAACC0")]
	public bool BLDEGDGIOGH(TKey OEOMDKHBDFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x3BAC0C0", Offset = "0x3BAB4C0", VA = "0x183BAC0C0")]
	public bool KJGEKAOFANE(TKey OEOMDKHBDFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x3BAC960", Offset = "0x3BABD60", VA = "0x183BAC960", Slot = "10")]
	public bool Remove(TKey OEOMDKHBDFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x3BAD380", Offset = "0x3BAC780", VA = "0x183BAD380", Slot = "11")]
	public bool TryGetValue(TKey OEOMDKHBDFI, [Out] TValue EEPLCHCGAIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x3BAB190", Offset = "0x3BAA590", VA = "0x183BAB190", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TValue>[] IGGIDMIPNHL, int GJALKOIBMBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x3BAD260", Offset = "0x3BAC660", VA = "0x183BAD260", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x3BABFB0", Offset = "0x3BAB3B0", VA = "0x183BABFB0", Slot = "19")]
	[IteratorStateMachine(typeof(ENEMJFEDALG<, >.HMNCKMCFBKF))]
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x3BABE60", Offset = "0x3BAB260", VA = "0x183BABE60", Slot = "21")]
	public bool GKMBNLPAKOK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x3BABBB0", Offset = "0x3BAAFB0", VA = "0x183BABBB0")]
	private TValue EFCIEKLKIDM(TKey OEOMDKHBDFI)
	{
		return (TValue)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public interface LDGPNDOEGHO
{
	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GKMBNLPAKOK();
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public interface BIFOCOBKOJN<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, LDGPNDOEGHO
{
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
[DefaultMember("Item")]
public sealed class NILNFLHOEJA<TKey, TVal> : BIFOCOBKOJN<TKey, TVal>, IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, LDGPNDOEGHO where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public delegate int AKPPNPHILHK(TKey OEOMDKHBDFI, TVal EEPLCHCGAIN);

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public delegate void CAKIPGNJPAL(TKey OEOMDKHBDFI, TVal EEPLCHCGAIN, MBBBJNILNCE ENJPANJMAJE);

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	private class MLJPCNHKMGB
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public TKey KJHFJLCNKKI
		{
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0xA9B260", Offset = "0xA9A660", VA = "0x180A9B260")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public TVal EEMLDMGPOLA
		{
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x92A830", Offset = "0x929C30", VA = "0x18092A830")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0xA39D70", Offset = "0xA39170", VA = "0x180A39D70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public int GDNEEEAIONI
		{
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x8E9CC0", Offset = "0x8E90C0", VA = "0x1808E9CC0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x8E93A0", Offset = "0x8E87A0", VA = "0x1808E93A0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public DateTimeOffset NFHNMAOEEHO
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0xF173D0", Offset = "0xF167D0", VA = "0x180F173D0")]
			[CompilerGenerated]
			get
			{
				return default(DateTimeOffset);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x1989AC0", Offset = "0x1988EC0", VA = "0x181989AC0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x4818670", Offset = "0x4817A70", VA = "0x184818670")]
		public MLJPCNHKMGB(TKey OEOMDKHBDFI, TVal OAKJBMEGCLP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private sealed class GEDDNNJMJDG : IEnumerator<KeyValuePair<TKey, TVal>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private KeyValuePair<TKey, TVal> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public NILNFLHOEJA<TKey, TVal> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private LinkedList<MLJPCNHKMGB>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		KeyValuePair<TKey, TVal> IEnumerator<KeyValuePair<TKey, TVal>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x13630E0", Offset = "0x13624E0", VA = "0x1813630E0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x408AD40", Offset = "0x408A140", VA = "0x18408AD40", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x8B2270", Offset = "0x8B1670", VA = "0x1808B2270")]
		[DebuggerHidden]
		public GEDDNNJMJDG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x3B6DAA0", Offset = "0x3B6CEA0", VA = "0x183B6DAA0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x40898B0", Offset = "0x4088CB0", VA = "0x1840898B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x4087F70", Offset = "0x4087370", VA = "0x184087F70")]
		private void CPDIPGODGJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x408AB10", Offset = "0x4089F10", VA = "0x18408AB10", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public const int NBDLPOBLMHO = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly Dictionary<TKey, LinkedListNode<MLJPCNHKMGB>> DPEKFEEJOFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly LinkedList<MLJPCNHKMGB> PBKMDNGMHBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly AKPPNPHILHK? HHDMJJNNBEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly TimeSpan DMDBHMKMIGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly CAKIPGNJPAL? MPEABJCLCJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly OIIGLLLMHIB AAFNGPNEJPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private bool POEODJOKKMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly List<TKey> KKDOCJFKKAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly List<TVal> PEPEFILOFHK;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int GNOFLAKLIMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x8B9060", Offset = "0x8B8460", VA = "0x1808B9060")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	internal int IGFCFHENHCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x9B7610", Offset = "0x9B6A10", VA = "0x1809B7610")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x9B78B0", Offset = "0x9B6CB0", VA = "0x1809B78B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int ICBOPDBFFOG
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x48F9AB0", Offset = "0x48F8EB0", VA = "0x1848F9AB0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	internal int AGDACCDAKFG
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x4123E20", Offset = "0x4123220", VA = "0x184123E20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public ICollection<TVal> ENHONGHAPHM
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x48F9C60", Offset = "0x48F9060", VA = "0x1848F9C60", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	ICollection<TKey> IDictionary<TKey, TVal>.OLPECONINKI
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x48F4080", Offset = "0x48F3480", VA = "0x1848F4080", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool IHEEMPBAFPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x8F2CF0", Offset = "0x8F20F0", VA = "0x1808F2CF0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public TVal MGACFGHHFEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x48F9B90", Offset = "0x48F8F90", VA = "0x1848F9B90", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x48F9D50", Offset = "0x48F9150", VA = "0x1848F9D50", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x48E3D90", Offset = "0x48E3190", VA = "0x1848E3D90")]
	private bool EHKHLLJHBAC(int BIMLHBENMHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x48E7E90", Offset = "0x48E7290", VA = "0x1848E7E90")]
	private void KHIINKOACDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x48F8370", Offset = "0x48F7770", VA = "0x1848F8370")]
	public NILNFLHOEJA(int BIMLHBENMHO, [Optional] AKPPNPHILHK? HHDMJJNNBEE, [Optional] IEqualityComparer<TKey>? DJAEONLNJJN, [Optional] CAKIPGNJPAL? MPEABJCLCJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x48F5D50", Offset = "0x48F5150", VA = "0x1848F5D50")]
	public NILNFLHOEJA(TimeSpan DMDBHMKMIGP, [Optional] IEqualityComparer<TKey>? DJAEONLNJJN, [Optional] CAKIPGNJPAL? MPEABJCLCJH, [Optional] OIIGLLLMHIB? AAFNGPNEJPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x48F5850", Offset = "0x48F4C50", VA = "0x1848F5850")]
	public NILNFLHOEJA(int BIMLHBENMHO, TimeSpan DMDBHMKMIGP, [Optional] IEqualityComparer<TKey>? DJAEONLNJJN, [Optional] CAKIPGNJPAL? MPEABJCLCJH, [Optional] OIIGLLLMHIB? AAFNGPNEJPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x48F6330", Offset = "0x48F5730", VA = "0x1848F6330")]
	public NILNFLHOEJA(int BIMLHBENMHO, AKPPNPHILHK? HHDMJJNNBEE, TimeSpan DMDBHMKMIGP, [Optional] IEqualityComparer<TKey>? DJAEONLNJJN, [Optional] CAKIPGNJPAL? MPEABJCLCJH, [Optional] OIIGLLLMHIB? AAFNGPNEJPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x48E7B20", Offset = "0x48E6F20", VA = "0x1848E7B20", Slot = "21")]
	public bool GKMBNLPAKOK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x48DCAE0", Offset = "0x48DBEE0", VA = "0x1848DCAE0", Slot = "22")]
	public bool BKFLEHNBJDB(int IKJKAFPPDBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x48ECD00", Offset = "0x48EC100", VA = "0x1848ECD00")]
	private bool KOAHGOGMMII(int IKJKAFPPDBP, MBBBJNILNCE ENJPANJMAJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x48ED5C0", Offset = "0x48EC9C0", VA = "0x1848ED5C0")]
	public void MCAKFOHFDBM(TKey OEOMDKHBDFI, TVal EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x48DB950", Offset = "0x48DAD50", VA = "0x1848DB950", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> HHDONFMCNBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x48DB9A0", Offset = "0x48DADA0", VA = "0x1848DB9A0", Slot = "9")]
	public void Add(TKey OEOMDKHBDFI, TVal EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x48E0EC0", Offset = "0x48E02C0", VA = "0x1848E0EC0", Slot = "8")]
	public bool ContainsKey(TKey OEOMDKHBDFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x48F3880", Offset = "0x48F2C80", VA = "0x1848F3880", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Contains(KeyValuePair<TKey, TVal> HHDONFMCNBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x48F2AD0", Offset = "0x48F1ED0", VA = "0x1848F2AD0", Slot = "10")]
	public bool Remove(TKey OEOMDKHBDFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x48F3DE0", Offset = "0x48F31E0", VA = "0x1848F3DE0", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Remove(KeyValuePair<TKey, TVal> HHDONFMCNBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x48DFD20", Offset = "0x48DF120", VA = "0x1848DFD20")]
	private bool CPHLKMEGGFA(TKey OEOMDKHBDFI, [Out] TVal EEPLCHCGAIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x48DDA40", Offset = "0x48DCE40", VA = "0x1848DDA40")]
	private TVal CADKKGPFCDD(TKey JFMMGIJOFEJ)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x48F4980", Offset = "0x48F3D80", VA = "0x1848F4980", Slot = "11")]
	public bool TryGetValue(TKey JFMMGIJOFEJ, [Out] TVal EEPLCHCGAIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x48E0D30", Offset = "0x48E0130", VA = "0x1848E0D30", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x48E3350", Offset = "0x48E2750", VA = "0x1848E3350", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] IGGIDMIPNHL, int GJALKOIBMBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x48E46C0", Offset = "0x48E3AC0", VA = "0x1848E46C0")]
	private void GGECMPEEPKP(TKey OEOMDKHBDFI, TVal OAKJBMEGCLP, MBBBJNILNCE ENJPANJMAJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x48DEEB0", Offset = "0x48DE2B0", VA = "0x1848DEEB0")]
	private bool CCDHNLBMCMK(MLJPCNHKMGB CKBPAAPOBAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x48F0BC0", Offset = "0x48EFFC0", VA = "0x1848F0BC0")]
	private void MOHBECFEPNP(LinkedListNode<MLJPCNHKMGB> PPDFJJJNCAE, TVal JFKJABAPEAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x48E7420", Offset = "0x48E6820", VA = "0x1848E7420")]
	private void GJNKIFOCKMF(TKey OEOMDKHBDFI, TVal EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x48DB0A0", Offset = "0x48DA4A0", VA = "0x1848DB0A0")]
	private void ABGHIBHCIPF(MLJPCNHKMGB CKBPAAPOBAF, TVal JFKJABAPEAB, int BAGLADIDOGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x48E7DE0", Offset = "0x48E71E0", VA = "0x1848E7DE0", Slot = "19")]
	[IteratorStateMachine(typeof(NILNFLHOEJA<, >.GEDDNNJMJDG))]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x48F40D0", Offset = "0x48F34D0", VA = "0x1848F40D0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public enum MBBBJNILNCE : byte
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
public class AKOPJIIMPIN<TKey> : Exception where TKey : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public readonly TKey OHPPOBIEMJE;

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x400ADC0", Offset = "0x400A1C0", VA = "0x18400ADC0")]
	public AKOPJIIMPIN(TKey JEIAONOIJGB, Exception GPPNMDMLEIO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public class COAJHCBCPOM : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x61CF5C0", Offset = "0x61CE9C0", VA = "0x1861CF5C0")]
	public COAJHCBCPOM(string MOKGCFCFCPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class IPJNHCBKGPM<TId, TResource> : IEnumerable<(TId, Task<TResource>, int)>, IEnumerable where TId : notnull where TResource : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class JLMKPNINAOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public Func<TId, CancellationToken, Task<TResource>> factory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public IPJNHCBKGPM<TId, TResource> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public JLMKPNINAOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x4428240", Offset = "0x4427640", VA = "0x184428240")]
		internal Task<TResource> MBGPBIBJJAL(TId _id)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private struct NKEKKKPHMNJ : IAsyncStateMachine
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
		public IPJNHCBKGPM<TId, TResource> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x4905D60", Offset = "0x4905160", VA = "0x184905D60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x4906960", Offset = "0x4905D60", VA = "0x184906960", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private struct GGODOIDFALF : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x4099880", Offset = "0x4098C80", VA = "0x184099880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x4099F00", Offset = "0x4099300", VA = "0x184099F00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private readonly IBIAHHNAJBM<TId, Task<TResource>> GANGLIJHHFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly Dictionary<Task<TResource>, CancellationTokenSource> ODEIHCIBPGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private readonly Func<TId, CancellationToken, Task<TResource>>? CFEHLENBNKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private readonly Action<TResource>? KBFNAFHAEMI;

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x4267BE0", Offset = "0x4266FE0", VA = "0x184267BE0")]
	public IPJNHCBKGPM(int GGAMCBCCCPF = 0, [Optional] IEqualityComparer<TId>? KMJDMPGFELC, [Optional] Func<TId, CancellationToken, Task<TResource>>? HAMCBAGBBLB, [Optional] Action<TResource>? MMFCIOCBMKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x4267160", Offset = "0x4266560", VA = "0x184267160")]
	public KEACOJOOGKI<Task<TResource>> LHBELHOKPEJ(TId NKPCGMJMEIE, [Optional] Func<TId, CancellationToken, Task<TResource>>? HAMCBAGBBLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x4267530", Offset = "0x4266930", VA = "0x184267530")]
	private void PKGFFKOHEMB(Task<TResource> IALOMLEGCDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x42667A0", Offset = "0x4265BA0", VA = "0x1842667A0")]
	[AsyncStateMachine(typeof(IPJNHCBKGPM<, >.NKEKKKPHMNJ))]
	private Task GAOGMNDECJP(Task<TResource> IALOMLEGCDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x4266D20", Offset = "0x4266120", VA = "0x184266D20")]
	public void JNBIDEBDAON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x4266BA0", Offset = "0x4265FA0", VA = "0x184266BA0")]
	public IBIAHHNAJBM<TId, Task<TResource>>.PJAHPNKDAJI JLDAKMOMDIF()
	{
		return default(IBIAHHNAJBM<TId, Task<TResource>>.PJAHPNKDAJI);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x4267AA0", Offset = "0x4266EA0", VA = "0x184267AA0", Slot = "4")]
	private IEnumerator<(TId, Task<TResource>, int)> System.Collections.Generic.IEnumerable<(TIdId,System.Threading.Tasks.Task<TResource>LoadResourceTask,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x4267AA0", Offset = "0x4266EA0", VA = "0x184267AA0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x4266410", Offset = "0x4265810", VA = "0x184266410")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(IPJNHCBKGPM<, >.GGODOIDFALF))]
	internal static Task FOBFLIPBLPG(Task<TResource> IALOMLEGCDH, CancellationTokenSource PBPNOGJAAMP, Dictionary<Task<TResource>, CancellationTokenSource> KOGKIDMBBPA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class IBIAHHNAJBM<TKey, TValue> : IEnumerable<(TKey, TValue, int)>, IEnumerable where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	private sealed class EBLMPGADCBI : IEquatable<EBLMPGADCBI>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public readonly TValue EEMLDMGPOLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public int KGAOIDPLPLO;

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0xC26CF0", Offset = "0xC260F0", VA = "0x180C26CF0")]
		public EBLMPGADCBI(TValue EEPLCHCGAIN, int IDPJLCHBMKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x3B4C510", Offset = "0x3B4B910", VA = "0x183B4C510", Slot = "4")]
		public bool Equals(EBLMPGADCBI? KNLMODPGFOA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x3B4C5A0", Offset = "0x3B4B9A0", VA = "0x183B4C5A0", Slot = "0")]
		public override bool Equals(object? FMAFBHGACNM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x3B4C650", Offset = "0x3B4BA50", VA = "0x183B4C650", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public struct PJAHPNKDAJI : IEnumerator<(TKey, TValue, int)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private Dictionary<TKey, EBLMPGADCBI>.Enumerator ELMPNGIJBEK;

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x4B1EF80", Offset = "0x4B1E380", VA = "0x184B1EF80", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public (TKey Key, TValue Value, int RefCount) GKCMOMIKDKD
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x4B1F2A0", Offset = "0x4B1E6A0", VA = "0x184B1F2A0", Slot = "4")]
			get
			{
				return default((TKey, TValue, int));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x4B1F020", Offset = "0x4B1E420", VA = "0x184B1F020")]
		public PJAHPNKDAJI(IBIAHHNAJBM<TKey, TValue> BNDGLAGJGHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x4B1EA70", Offset = "0x4B1DE70", VA = "0x184B1EA70", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x4B1EAF0", Offset = "0x4B1DEF0", VA = "0x184B1EAF0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x4B1EB70", Offset = "0x4B1DF70", VA = "0x184B1EB70", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private sealed class HECCDBLKDJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public IBIAHHNAJBM<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public TKey key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public EBLMPGADCBI refCountedValue;

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public HECCDBLKDJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x4120540", Offset = "0x411F940", VA = "0x184120540")]
		internal void MBGPBIBJJAL()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private readonly Dictionary<TKey, EBLMPGADCBI> AGCMMPNAKFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private readonly Func<TKey, TValue>? PGNDPNHBJID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private readonly Action<TValue>? HKIGHLPPMNE;

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x4228680", Offset = "0x4227A80", VA = "0x184228680")]
	public IBIAHHNAJBM(int GGAMCBCCCPF = 0, [Optional] IEqualityComparer<TKey>? DJAEONLNJJN, [Optional] Func<TKey, TValue>? CFEMAHCEBDO, [Optional] Action<TValue>? HAOHKKFHECF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x4227AE0", Offset = "0x4226EE0", VA = "0x184227AE0")]
	public KEACOJOOGKI<TValue> LHBELHOKPEJ(TKey OEOMDKHBDFI, [Optional] Func<TKey, TValue>? LPBPBKJEJPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x4226C80", Offset = "0x4226080", VA = "0x184226C80")]
	private void HNEMOMPNNFO(TKey OEOMDKHBDFI, EBLMPGADCBI IDHFDCEFKLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x4227360", Offset = "0x4226760", VA = "0x184227360")]
	public void JNBIDEBDAON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x4227090", Offset = "0x4226490", VA = "0x184227090")]
	public PJAHPNKDAJI JLDAKMOMDIF()
	{
		return default(PJAHPNKDAJI);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x4228490", Offset = "0x4227890", VA = "0x184228490", Slot = "4")]
	private IEnumerator<(TKey, TValue, int)> System.Collections.Generic.IEnumerable<(TKeyKey,TValueValue,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x4228490", Offset = "0x4227890", VA = "0x184228490", Slot = "5")]
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
