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
		[Cpp2IlInjected.Address(RVA = "0x8E06A0", Offset = "0x8DEEA0", VA = "0x1808E06A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7051830", Offset = "0x7050030", VA = "0x187051830")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8E0B60", Offset = "0x8DF360", VA = "0x1808E0B60")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8E0BA0", Offset = "0x8DF3A0", VA = "0x1808E0BA0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class GKJDLOAADIL
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
	protected GKJDLOAADIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class BCMMDICDGBL<T> : GKJDLOAADIL
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	protected struct ILLEBGCJGKM
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public enum BFLKJPHFADL
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
		public BFLKJPHFADL OCLAPBNMMGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public T ILIPDNLABEN;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private int PBJBOEJAJMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool AFNEAPFGEGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	protected readonly bool PGFOPKAHOCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	protected List<T>? GOMOLAONBEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<ILLEBGCJGKM>? BEFMNPFPEGH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool HCEHAFHFBGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x539B550", Offset = "0x5399D50", VA = "0x18539B550")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x539B5B0", Offset = "0x5399DB0", VA = "0x18539B5B0")]
	protected BCMMDICDGBL(bool PGFOPKAHOCD, bool AFNEAPFGEGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x539B4B0", Offset = "0x5399CB0", VA = "0x18539B4B0")]
	protected bool NHKPHFDGEKB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x539B390", Offset = "0x5399B90", VA = "0x18539B390")]
	protected void KECHJBKOGID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x539AF10", Offset = "0x5399710", VA = "0x18539AF10")]
	protected void IHIMIPCMPBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2F53F50", Offset = "0x2F52750", VA = "0x182F53F50")]
	private static void NINEIEFIAPA<U>(List<U>? OCHGNEGGEPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x539B180", Offset = "0x5399980", VA = "0x18539B180", Slot = "4")]
	public void JGCMIIMCCFC(T ILIPDNLABEN, bool LNCEKLGMDEO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x539AB90", Offset = "0x5399390", VA = "0x18539AB90", Slot = "5")]
	public void CGFLGFPAOEK(T ILIPDNLABEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x539AD60", Offset = "0x5399560", VA = "0x18539AD60")]
	public void CPGLBCDJJEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class GCOJJNPJFGN : BCMMDICDGBL<Action>
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x704F890", Offset = "0x704E090", VA = "0x18704F890")]
	public GCOJJNPJFGN(bool PGFOPKAHOCD = false, bool AFNEAPFGEGO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x704F630", Offset = "0x704DE30", VA = "0x18704F630")]
	public void JOEKNDNMBGL()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x704F830", Offset = "0x704E030", VA = "0x18704F830")]
	public static GCOJJNPJFGN PPMHJPEALBG(GCOJJNPJFGN KJFODGCOFEE, Action ILIPDNLABEN)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x704F5D0", Offset = "0x704DDD0", VA = "0x18704F5D0")]
	public static GCOJJNPJFGN FDMMOLNNABM(GCOJJNPJFGN KJFODGCOFEE, Action ILIPDNLABEN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface MGBMPGMPPHD<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JGCMIIMCCFC(Action<T> ILIPDNLABEN, bool LNCEKLGMDEO = false);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CGFLGFPAOEK(Action<T> ILIPDNLABEN);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class ANHAMBLCGDC<T> : BCMMDICDGBL<Action<T>>, MGBMPGMPPHD<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3CC4350", Offset = "0x3CC2B50", VA = "0x183CC4350")]
	public ANHAMBLCGDC(bool PGFOPKAHOCD = false, bool AFNEAPFGEGO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x447D2C0", Offset = "0x447BAC0", VA = "0x18447D2C0")]
	public void JOEKNDNMBGL(T EBDGHJJPDEM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4304970", Offset = "0x4303170", VA = "0x184304970")]
	public static ANHAMBLCGDC<T> PPMHJPEALBG(ANHAMBLCGDC<T> KJFODGCOFEE, Action<T> ILIPDNLABEN)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x43016F0", Offset = "0x42FFEF0", VA = "0x1843016F0")]
	public static ANHAMBLCGDC<T> FDMMOLNNABM(ANHAMBLCGDC<T> KJFODGCOFEE, Action<T> ILIPDNLABEN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface KIAAHJGKPKK<T, U> where T : notnull where U : notnull
{
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class BHNOANLGPMK<T, U> : BCMMDICDGBL<Action<T, U>>, KIAAHJGKPKK<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3CC4350", Offset = "0x3CC2B50", VA = "0x183CC4350")]
	public BHNOANLGPMK(bool PGFOPKAHOCD = false, bool AFNEAPFGEGO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x53B7630", Offset = "0x53B5E30", VA = "0x1853B7630")]
	public void JOEKNDNMBGL(T EBDGHJJPDEM, U KMEANNAONJP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4304970", Offset = "0x4303170", VA = "0x184304970")]
	public static BHNOANLGPMK<T, U> PPMHJPEALBG(BHNOANLGPMK<T, U> KJFODGCOFEE, Action<T, U> ILIPDNLABEN)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x43016F0", Offset = "0x42FFEF0", VA = "0x1843016F0")]
	public static BHNOANLGPMK<T, U> FDMMOLNNABM(BHNOANLGPMK<T, U> KJFODGCOFEE, Action<T, U> ILIPDNLABEN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class IDHKLCOGGHN<T, U, V> : BCMMDICDGBL<Action<T, U, V>> where T : notnull where U : notnull where V : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3CC4350", Offset = "0x3CC2B50", VA = "0x183CC4350")]
	public IDHKLCOGGHN(bool PGFOPKAHOCD = false, bool AFNEAPFGEGO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4302520", Offset = "0x4300D20", VA = "0x184302520")]
	public void JOEKNDNMBGL(T EBDGHJJPDEM, U KMEANNAONJP, V JBEGGBDGOGM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4304970", Offset = "0x4303170", VA = "0x184304970")]
	public static IDHKLCOGGHN<T, U, V> PPMHJPEALBG(IDHKLCOGGHN<T, U, V> KJFODGCOFEE, Action<T, U, V> ILIPDNLABEN)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x43016F0", Offset = "0x42FFEF0", VA = "0x1843016F0")]
	public static IDHKLCOGGHN<T, U, V> FDMMOLNNABM(IDHKLCOGGHN<T, U, V> KJFODGCOFEE, Action<T, U, V> ILIPDNLABEN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface FJBMELOOKNB<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public sealed class IOGHHIEMKCD<T, U, V, W> : BCMMDICDGBL<Action<T, U, V, W>>, FJBMELOOKNB<T, U, V, W> where T : notnull where U : notnull where V : notnull where W : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3CC4350", Offset = "0x3CC2B50", VA = "0x183CC4350")]
	public IOGHHIEMKCD(bool PGFOPKAHOCD = false, bool AFNEAPFGEGO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x43401F0", Offset = "0x433E9F0", VA = "0x1843401F0")]
	public void JOEKNDNMBGL(T EBDGHJJPDEM, U KMEANNAONJP, V JBEGGBDGOGM, W PFAJNAEPBBJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4304970", Offset = "0x4303170", VA = "0x184304970")]
	public static IOGHHIEMKCD<T, U, V, W> PPMHJPEALBG(IOGHHIEMKCD<T, U, V, W> KJFODGCOFEE, Action<T, U, V, W> ILIPDNLABEN)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x43016F0", Offset = "0x42FFEF0", VA = "0x1843016F0")]
	public static IOGHHIEMKCD<T, U, V, W> FDMMOLNNABM(IOGHHIEMKCD<T, U, V, W> KJFODGCOFEE, Action<T, U, V, W> ILIPDNLABEN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class LDGIJMMOLCA<T, U, V, W, X> : BCMMDICDGBL<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3CC4350", Offset = "0x3CC2B50", VA = "0x183CC4350")]
	public LDGIJMMOLCA(bool PGFOPKAHOCD = false, bool AFNEAPFGEGO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x471FA10", Offset = "0x471E210", VA = "0x18471FA10")]
	public void JOEKNDNMBGL(T EBDGHJJPDEM, U KMEANNAONJP, V JBEGGBDGOGM, W PFAJNAEPBBJ, X KHINBLFKKED)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x4304970", Offset = "0x4303170", VA = "0x184304970")]
	public static LDGIJMMOLCA<T, U, V, W, X> PPMHJPEALBG(LDGIJMMOLCA<T, U, V, W, X> KJFODGCOFEE, Action<T, U, V, W, X> ILIPDNLABEN)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x43016F0", Offset = "0x42FFEF0", VA = "0x1843016F0")]
	public static LDGIJMMOLCA<T, U, V, W, X> FDMMOLNNABM(LDGIJMMOLCA<T, U, V, W, X> KJFODGCOFEE, Action<T, U, V, W, X> ILIPDNLABEN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class OKPMINHCCMO<T, U, V, W, X, Y> : BCMMDICDGBL<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3CC4350", Offset = "0x3CC2B50", VA = "0x183CC4350")]
	public OKPMINHCCMO(bool PGFOPKAHOCD = false, bool AFNEAPFGEGO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4B5CB10", Offset = "0x4B5B310", VA = "0x184B5CB10")]
	public void JOEKNDNMBGL(T EBDGHJJPDEM, U KMEANNAONJP, V JBEGGBDGOGM, W PFAJNAEPBBJ, X KHINBLFKKED, Y NCCBPIFKDGE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4304970", Offset = "0x4303170", VA = "0x184304970")]
	public static OKPMINHCCMO<T, U, V, W, X, Y> PPMHJPEALBG(OKPMINHCCMO<T, U, V, W, X, Y> KJFODGCOFEE, Action<T, U, V, W, X, Y> ILIPDNLABEN)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x43016F0", Offset = "0x42FFEF0", VA = "0x1843016F0")]
	public static OKPMINHCCMO<T, U, V, W, X, Y> FDMMOLNNABM(OKPMINHCCMO<T, U, V, W, X, Y> KJFODGCOFEE, Action<T, U, V, W, X, Y> ILIPDNLABEN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class PEINGMLPAFA<TKey, TVal> where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly LAMAMKMDIIM<TKey, TVal> CMDMBJBPFPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly Dictionary<TKey, (TVal value, int size)> EOGKGKMHBMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly LAMAMKMDIIM<TKey, TVal>.HCEEJBDOAFG? PDMDLIHHHLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly int JDJJHONOFGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly LAMAMKMDIIM<TKey, TVal>.PGMHGKOGJAH? BGBBEFDHFKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private int IHOALDNCHHG;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal int MGMPPEIGDHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x4C31750", Offset = "0x4C2FF50", VA = "0x184C31750")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int LMJANDOFNOO
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8B5250", Offset = "0x8B3A50", VA = "0x1808B5250")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4C31A60", Offset = "0x4C30260", VA = "0x184C31A60")]
	public PEINGMLPAFA(int JDJJHONOFGJ, [Optional] LAMAMKMDIIM<TKey, TVal>.PGMHGKOGJAH? BGBBEFDHFKE, [Optional] IEqualityComparer<TKey>? NDICNLPGKMA, [Optional] LAMAMKMDIIM<TKey, TVal>.HCEEJBDOAFG? PDMDLIHHHLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4C31520", Offset = "0x4C2FD20", VA = "0x184C31520")]
	public void NIDMBLPHGEJ(TKey KCGKBDGKIOP, TVal INDENPJBLHO, bool NOCNCNOGLCO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4C30CD0", Offset = "0x4C2F4D0", VA = "0x184C30CD0")]
	public bool BAANCJLIPEH(TKey KCGKBDGKIOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x4C31140", Offset = "0x4C2F940", VA = "0x184C31140")]
	public bool HDDNHEKKGGH(TKey IMKLPELFAIL, [Out] TVal INDENPJBLHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4C317A0", Offset = "0x4C2FFA0", VA = "0x184C317A0")]
	private void NNHGEHHCCGJ(TKey KCGKBDGKIOP, TVal INDENPJBLHO, int BOOADEANLJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x4C31370", Offset = "0x4C2FB70", VA = "0x184C31370")]
	public bool MKHNHHKDBNK(TKey KCGKBDGKIOP, TVal INDENPJBLHO, bool NOCNCNOGLCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4C30E30", Offset = "0x4C2F630", VA = "0x184C30E30")]
	public void CPGLBCDJJEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4C30770", Offset = "0x4C2EF70", VA = "0x184C30770")]
	private void AHCDFBDDCKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4C31000", Offset = "0x4C2F800", VA = "0x184C31000")]
	private bool GDDANKPFFKI(TKey KCGKBDGKIOP, FLLCJGJOAOM HLONLEDABCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4C30EE0", Offset = "0x4C2F6E0", VA = "0x184C30EE0")]
	private void EELFHLEPAOH(TKey KCGKBDGKIOP, TVal INDENPJBLHO, FLLCJGJOAOM HLONLEDABCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4C31240", Offset = "0x4C2FA40", VA = "0x184C31240")]
	private void MFPGHOHMHMN(TKey KCGKBDGKIOP, TVal DBIIPNGMHFP, FLLCJGJOAOM HLONLEDABCF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class DKFCAFHPGLL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly Action JHBKMBOJAKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool ICKDNMFPFOF;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8C0090", Offset = "0x8BE890", VA = "0x1808C0090")]
	public DKFCAFHPGLL(Action KCPLAHHONOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x704EAD0", Offset = "0x704D2D0", VA = "0x18704EAD0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2DE93A0", Offset = "0x2DE7BA0", VA = "0x182DE93A0")]
	public static DPGJMAFIAMJ<T> JHEOKMMJDLF<T>(T INDENPJBLHO, Action KCPLAHHONOI) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class DPGJMAFIAMJ<T> : DKFCAFHPGLL where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public T MHFLHGKPHDB
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8B5260", Offset = "0x8B3A60", VA = "0x1808B5260")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5E05820", Offset = "0x5E04020", VA = "0x185E05820")]
	public DPGJMAFIAMJ(T INDENPJBLHO, Action KCPLAHHONOI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class CLOMBNDLNMP<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly HJEIJKOEBKL<T>? JKLJAJDAACN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly ReadOnlySequence<T> JKOOBOKHFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private bool ICKDNMFPFOF;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly CLOMBNDLNMP<T> PNJBLIJBOPG;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ReadOnlySequence<T> KOKDNNGFGNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5938AF0", Offset = "0x59372F0", VA = "0x185938AF0")]
		get
		{
			return default(ReadOnlySequence<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long NALHPIPMEMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x5938DA0", Offset = "0x59375A0", VA = "0x185938DA0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool KMEJBLAIFGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5939140", Offset = "0x5937940", VA = "0x185939140")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5939350", Offset = "0x5937B50", VA = "0x185939350")]
	public CLOMBNDLNMP(HJEIJKOEBKL<T> EOJELGAMOAE, HJEIJKOEBKL<T> JEBDEGOEMMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x59398A0", Offset = "0x59380A0", VA = "0x1859398A0")]
	public CLOMBNDLNMP(HJEIJKOEBKL<T> EOJELGAMOAE, int PPAKOENBJHH, HJEIJKOEBKL<T> JEBDEGOEMMD, int GNFBLGKLCKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5939440", Offset = "0x5937C40", VA = "0x185939440")]
	private CLOMBNDLNMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5938BF0", Offset = "0x59373F0", VA = "0x185938BF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x5938F20", Offset = "0x5937720", VA = "0x185938F20")]
	public T[] KDPLNHBOMLF()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5938C80", Offset = "0x5937480", VA = "0x185938C80")]
	public static ReadOnlySequence<T> FMEIMHFCNHG(CLOMBNDLNMP<T>? EAHPMEANBNE)
	{
		return default(ReadOnlySequence<T>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct HHODKGAPNCI : IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct HFKPDKBGOHN : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8FF830", Offset = "0x8FE030", VA = "0x1808FF830")]
		public static HFKPDKBGOHN DFLBOLBHLFN()
		{
			return default(HFKPDKBGOHN);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7050890", Offset = "0x704F090", VA = "0x187050890")]
	public static string LGMPPNBDFLB(Type OCLAPBNMMGE, [Optional] string? ACLENDLFIDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3086FD0", Offset = "0x30857D0", VA = "0x183086FD0")]
	public static string? LGMPPNBDFLB<T>([Optional] string? ACLENDLFIDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3086F50", Offset = "0x3085750", VA = "0x183086F50")]
	public static string? ECFOAFLPONE<T>([Optional] string? DCFHPLGFJIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8FF830", Offset = "0x8FE030", VA = "0x1808FF830")]
	public static HHODKGAPNCI PJGGPIGEKEG(string ACLENDLFIDF, string? DCFHPLGFJIL)
	{
		return default(HHODKGAPNCI);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct GMEKKAAMOLN
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate bool BOLGGGNECOG(string IFPDKDOPOPC, GMEKKAAMOLN DEFMMAMBALG);

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class DKNADDLGPGJ<T> where T : notnull, Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public List<int> enumValuesSubset;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public DKNADDLGPGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5DEE550", Offset = "0x5DECD50", VA = "0x185DEE550")]
		internal void DMECLNMLMOP(T x)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public int HGBJJIKLGEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public string FMJFJAPGAHB;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7050140", Offset = "0x704E940", VA = "0x187050140")]
	public static Dictionary<string, GMEKKAAMOLN> LBJDPPOOFCH(Type MODDFHBPPIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x307FEF0", Offset = "0x307E6F0", VA = "0x18307FEF0")]
	public static Dictionary<string, GMEKKAAMOLN> LBJDPPOOFCH<T>(Type MODDFHBPPIC, IReadOnlyDictionary<T, string> CJIEJBOAAAG) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x307F770", Offset = "0x307DF70", VA = "0x18307F770")]
	public static Dictionary<string, GMEKKAAMOLN> JLNABPLBDFK<T>(List<T> MFHLEFPHIAI) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x704FD80", Offset = "0x704E580", VA = "0x18704FD80")]
	public static Dictionary<string, GMEKKAAMOLN> JLHOLOHKLDA(Type MODDFHBPPIC, BOLGGGNECOG EPLBIKNEHOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x704FBC0", Offset = "0x704E3C0", VA = "0x18704FBC0")]
	public static Dictionary<int, string> FMCCLLDDFKH(Dictionary<string, GMEKKAAMOLN> IHDNMHOODCP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class LHIOHJOJEEI : EPICLACHOCO
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static bool EEDKCNBGCIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly string? HMADNIGODCA;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public virtual EPICLACHOCO? ECLNMKGKLBK
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8B6AB0", Offset = "0x8B52B0", VA = "0x1808B6AB0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7051760", Offset = "0x704FF60", VA = "0x187051760")]
	protected LHIOHJOJEEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string DHOBPLNCIMP();

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x70516E0", Offset = "0x704FEE0", VA = "0x1870516E0", Slot = "8")]
	public virtual string NNDGOLOOFBK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x70510C0", Offset = "0x704F8C0", VA = "0x1870510C0", Slot = "9")]
	public void APHOFIDDGJO(StringBuilder LOJNKOBMJOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7051360", Offset = "0x704FB60", VA = "0x187051360", Slot = "10")]
	public void EKDJOGMHCLG(StringBuilder LOJNKOBMJOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x70513C0", Offset = "0x704FBC0", VA = "0x1870513C0", Slot = "11")]
	public void JJCHOPICLCN(StringBuilder LOJNKOBMJOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7051580", Offset = "0x704FD80", VA = "0x187051580", Slot = "12")]
	public void KDDKPMBPKGJ(StringBuilder LOJNKOBMJOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x70514E0", Offset = "0x704FCE0", VA = "0x1870514E0")]
	public static void JLNDNEGINEC(StringBuilder LOJNKOBMJOO, string AKOODCKDDHP, string DEGNNBGHFEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6160950", Offset = "0x615F150", VA = "0x186160950", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class OGAKEFPAIEI : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7051980", Offset = "0x7050180", VA = "0x187051980")]
	public OGAKEFPAIEI(string PJFOMDHJLBF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class MCJNEMGKPDM<TErr> : OGAKEFPAIEI where TErr : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly TErr PAGKODENKBA;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x49412D0", Offset = "0x493FAD0", VA = "0x1849412D0")]
	private MCJNEMGKPDM([In] TErr FPHJDMEEHDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x4941200", Offset = "0x493FA00", VA = "0x184941200")]
	public static MCJNEMGKPDM<TErr> DFLBOLBHLFN([In] TErr FPHJDMEEHDA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class JAAJKIHBHCB : Stream
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly HashAlgorithm FGLALIMJPGE;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public override bool CCKHMNBAMNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8FF830", Offset = "0x8FE030", VA = "0x1808FF830", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public override bool IMEPKENKJBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8FF830", Offset = "0x8FE030", VA = "0x1808FF830", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public override bool FONEKKBNKNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8D13B0", Offset = "0x8CFBB0", VA = "0x1808D13B0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override long NALHPIPMEMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7050D30", Offset = "0x704F530", VA = "0x187050D30", Slot = "12")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override long CMIONGHAGGG
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7050DA0", Offset = "0x704F5A0", VA = "0x187050DA0", Slot = "13")]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7050E10", Offset = "0x704F610", VA = "0x187050E10", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7050CC0", Offset = "0x704F4C0", VA = "0x187050CC0")]
	public JAAJKIHBHCB(HashAlgorithm FGLALIMJPGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7050AE0", Offset = "0x704F2E0", VA = "0x187050AE0", Slot = "35")]
	public override int Read(byte[] ENCIEGIIIHM, int MHPJBPKHONI, int NELOIEKKMHO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7050C90", Offset = "0x704F490", VA = "0x187050C90", Slot = "38")]
	public override void Write(byte[] ENCIEGIIIHM, int MHPJBPKHONI, int NELOIEKKMHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7050B80", Offset = "0x704F380", VA = "0x187050B80", Slot = "33")]
	public override long Seek(long MHPJBPKHONI, SeekOrigin EJDLMDEMKCD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7050C10", Offset = "0x704F410", VA = "0x187050C10", Slot = "34")]
	public override void SetLength(long INDENPJBLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "23")]
	public override void Flush()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7050A00", Offset = "0x704F200", VA = "0x187050A00")]
	public byte[] LJHGKFEJEFN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface EPICLACHOCO
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string NNDGOLOOFBK();

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string DHOBPLNCIMP();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface HGCDCJGPAJF<out TOptions> where TOptions : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	TOptions MHFLHGKPHDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface MEEJIMAJCOI
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	string BMPOBFBPAOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class HJEIJKOEBKL<T> : ReadOnlySequenceSegment<T>, IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private static HJEIJKOEBKL<T>? PLNHLELGHAM;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private static object BNOGHLCNHPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private IMemoryOwner<T>? JIMPCGAAGEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private bool ICKDNMFPFOF;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool LJDEGIELPAP
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x9EA050", Offset = "0x9E8850", VA = "0x1809EA050")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x422BF40", Offset = "0x422A740", VA = "0x18422BF40")]
	private static HJEIJKOEBKL<T> HEADKDEKPCG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x422B170", Offset = "0x4229970", VA = "0x18422B170")]
	private static void AGHDEDMLLBK(HJEIJKOEBKL<T> GPILFHBJAHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x3CE7EA0", Offset = "0x3CE66A0", VA = "0x183CE7EA0")]
	private HJEIJKOEBKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x422C8A0", Offset = "0x422B0A0", VA = "0x18422C8A0")]
	public static HJEIJKOEBKL<T> JHEOKMMJDLF(ReadOnlyMemory<T> BKDAKGNGKBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x422C690", Offset = "0x422AE90", VA = "0x18422C690")]
	public static HJEIJKOEBKL<T> JHEOKMMJDLF(IMemoryOwner<T> OHLHLDBKAFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x422C400", Offset = "0x422AC00", VA = "0x18422C400")]
	public static void HEMBCDOPLJI(HJEIJKOEBKL<T> EOJELGAMOAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x422BAC0", Offset = "0x422A2C0", VA = "0x18422BAC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x422B730", Offset = "0x4229F30", VA = "0x18422B730")]
	public HJEIJKOEBKL<T> BDGOPCJIDAH(IMemoryOwner<T> OHLHLDBKAFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x422BE40", Offset = "0x422A640", VA = "0x18422BE40")]
	private void FDHDLIKEGMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x422C540", Offset = "0x422AD40", VA = "0x18422C540")]
	private HJEIJKOEBKL<T> IKMGOAMDKIP(HJEIJKOEBKL<T> GPILFHBJAHJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class NIECAPMKDOH : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x70517D0", Offset = "0x704FFD0", VA = "0x1870517D0")]
	public NIECAPMKDOH(string PJFOMDHJLBF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class LGPMECNHHOC<TOk> : NIECAPMKDOH where TOk : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly TOk FIBBLNMFPHI;

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x4733400", Offset = "0x4731C00", VA = "0x184733400")]
	private LGPMECNHHOC([In] TOk MPPLGFCLBCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x43A3030", Offset = "0x43A1830", VA = "0x1843A3030")]
	public static LGPMECNHHOC<TOk> DFLBOLBHLFN([In] TOk MPPLGFCLBCJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public readonly struct DNFCNMKAMCE<TOk, TErr> : IEquatable<DNFCNMKAMCE<TOk, TErr>> where TOk : notnull where TErr : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static readonly EqualityComparer<TErr> HOODGHMNNAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	internal readonly TErr PAGKODENKBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	internal readonly TOk FIBBLNMFPHI;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool EMCGPADBPMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x5DF8200", Offset = "0x5DF6A00", VA = "0x185DF8200")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool DMCEKCBCEGI
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x5DF8520", Offset = "0x5DF6D20", VA = "0x185DF8520")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5DF8D50", Offset = "0x5DF7550", VA = "0x185DF8D50")]
	internal DNFCNMKAMCE([In] TErr FPHJDMEEHDA, [In] TOk MPPLGFCLBCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5DF85B0", Offset = "0x5DF6DB0", VA = "0x185DF85B0")]
	public static DNFCNMKAMCE<TOk, TErr> LCNAMCJHAOA([In] TErr FPHJDMEEHDA)
	{
		return default(DNFCNMKAMCE<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5DF7D40", Offset = "0x5DF6540", VA = "0x185DF7D40")]
	public static DNFCNMKAMCE<TOk, TErr> ECJEOBNEEOF([In] TOk MPPLGFCLBCJ)
	{
		return default(DNFCNMKAMCE<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3008090", Offset = "0x3006890", VA = "0x183008090")]
	public DNFCNMKAMCE<TOk?, UErr?> IBEAEEOGNPG<UErr>()
	{
		return default(DNFCNMKAMCE<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3009110", Offset = "0x3007910", VA = "0x183009110")]
	public DNFCNMKAMCE<UOk?, TErr?> LNNICNJIHOG<UOk>()
	{
		return default(DNFCNMKAMCE<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3006E50", Offset = "0x3005650", VA = "0x183006E50")]
	public DNFCNMKAMCE<UOk?, TErr?> DEKPGMOEJAG<UOk>()
	{
		return default(DNFCNMKAMCE<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x3007E50", Offset = "0x3006650", VA = "0x183007E50")]
	public DNFCNMKAMCE<TOk?, UErr?> HKCGBEFEPLP<UErr>()
	{
		return default(DNFCNMKAMCE<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5DF8480", Offset = "0x5DF6C80", VA = "0x185DF8480")]
	public DNFCNMKAMCE<DOPPLCFNMND, TErr> INFNEJGNHII()
	{
		return default(DNFCNMKAMCE<DOPPLCFNMND, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5DF87B0", Offset = "0x5DF6FB0", VA = "0x185DF87B0")]
	public static bool PCBECHOJFKF([In] DNFCNMKAMCE<TOk, TErr> CBNNCMPLCDK, [In] DNFCNMKAMCE<TOk, TErr> OKJLFDLNFEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5DF7FB0", Offset = "0x5DF67B0", VA = "0x185DF7FB0", Slot = "4")]
	public bool Equals(DNFCNMKAMCE<TOk, TErr> LIHCAHPMPHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5DF7E20", Offset = "0x5DF6620", VA = "0x185DF7E20", Slot = "0")]
	public override bool Equals(object LIHCAHPMPHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x5DF8340", Offset = "0x5DF6B40", VA = "0x185DF8340", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x5DF8B40", Offset = "0x5DF7340", VA = "0x185DF8B40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class HMEGLABCDCA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct NKIDNDLGKCA<TOk, TErr> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public AsyncTaskMethodBuilder<TOk> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public Task<DNFCNMKAMCE<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private TaskAwaiter<DNFCNMKAMCE<TOk, TErr>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x4A52150", Offset = "0x4A50950", VA = "0x184A52150", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x4A52AB0", Offset = "0x4A512B0", VA = "0x184A52AB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x308CDD0", Offset = "0x308B5D0", VA = "0x18308CDD0")]
	public static DNFCNMKAMCE<TOk?, TErr?> FIBBLNMFPHI<TOk, TErr>([In] this DNFCNMKAMCE<TOk, TErr> EGGDEECAALI, [In] TOk MPPLGFCLBCJ)
	{
		return default(DNFCNMKAMCE<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x308CCD0", Offset = "0x308B4D0", VA = "0x18308CCD0")]
	public static DNFCNMKAMCE<DOPPLCFNMND, TErr?> FIBBLNMFPHI<TErr>([In] this DNFCNMKAMCE<DOPPLCFNMND, TErr> EGGDEECAALI)
	{
		return default(DNFCNMKAMCE<DOPPLCFNMND, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x308CDD0", Offset = "0x308B5D0", VA = "0x18308CDD0")]
	public static DNFCNMKAMCE<TOk?, TErr?> PAGKODENKBA<TOk, TErr>([In] this DNFCNMKAMCE<TOk, TErr> EGGDEECAALI, [In] TErr FPHJDMEEHDA)
	{
		return default(DNFCNMKAMCE<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x308EA20", Offset = "0x308D220", VA = "0x18308EA20")]
	public static TOk? MPCDDNPCNPH<TOk, TErr>([In] this DNFCNMKAMCE<TOk, TErr> EGGDEECAALI)
	{
		return (TOk?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x308C150", Offset = "0x308A950", VA = "0x18308C150")]
	[AsyncStateMachine(typeof(NKIDNDLGKCA<, >))]
	public static Task<TOk?>? DGBNDMFKLGC<TOk, TErr>(this Task<DNFCNMKAMCE<TOk, TErr>> EGGDEECAALI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x308C6E0", Offset = "0x308AEE0", VA = "0x18308C6E0")]
	public static TErr? EJNHHNEBAJK<TErr, TOk>([In] this DNFCNMKAMCE<TOk, TErr> EGGDEECAALI)
	{
		return (TErr?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x308D4E0", Offset = "0x308BCE0", VA = "0x18308D4E0")]
	public static bool JIBDDOLIKHA<TOk, TErr, UErr, UOk>([In] this DNFCNMKAMCE<TOk, TErr> EGGDEECAALI, [Out] DNFCNMKAMCE<UOk, UErr> CLHCJOJLFOO) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x308D2B0", Offset = "0x308BAB0", VA = "0x18308D2B0")]
	public static bool IHGFPKDJEMA<TOk, TErr>([In] this DNFCNMKAMCE<TOk, TErr> EGGDEECAALI, [Out] TOk MPPLGFCLBCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x308EFF0", Offset = "0x308D7F0", VA = "0x18308EFF0")]
	public static bool NIGCGFCPCKJ<TOk, TErr>([In] this DNFCNMKAMCE<TOk, TErr> EGGDEECAALI, [Out][NotNullWhen(true)] TErr FPHJDMEEHDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x308C0D0", Offset = "0x308A8D0", VA = "0x18308C0D0")]
	public static bool BFEHNHLAOBC<TOk, TErr>([In] this DNFCNMKAMCE<TOk, TErr> EGGDEECAALI, [Out][NotNullWhen(true)] TOk MPPLGFCLBCJ, [Out][NotNullWhen(false)] TErr FPHJDMEEHDA) where TOk : notnull where TErr : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x308BE30", Offset = "0x308A630", VA = "0x18308BE30")]
	public static bool AGDCHCBFCAB<TOk, TErr>([In] this DNFCNMKAMCE<TOk, TErr> EGGDEECAALI, [Out][NotNullWhen(true)] TOk MPPLGFCLBCJ, [Out] DNFCNMKAMCE<TOk, TErr> CLHCJOJLFOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x308D880", Offset = "0x308C080", VA = "0x18308D880")]
	public static bool JIBDDOLIKHA<TOk, TErr, UErr, UOk>([In] this DNFCNMKAMCE<TOk, TErr> EGGDEECAALI, [Out][NotNullWhen(true)] TOk MPPLGFCLBCJ, [Out] DNFCNMKAMCE<UOk, UErr> CLHCJOJLFOO) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x308C920", Offset = "0x308B120", VA = "0x18308C920")]
	public static bool EKDJKNLINHD<TOk, TErr>([In] this DNFCNMKAMCE<TOk, TErr> EGGDEECAALI, [Out][NotNullWhen(true)] TOk MPPLGFCLBCJ, [Out] DNFCNMKAMCE<DOPPLCFNMND, TErr> CLHCJOJLFOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x308F3B0", Offset = "0x308DBB0", VA = "0x18308F3B0")]
	public static DNFCNMKAMCE<UOk, UErr> PIDMDMNCIKG<UOk, UErr, TOk, TErr>([In] this DNFCNMKAMCE<TOk, TErr> EGGDEECAALI, [In] DNFCNMKAMCE<UOk, UErr> FNGOEBINDAF) where TOk : UOk where TErr : UErr
	{
		return default(DNFCNMKAMCE<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x308CF40", Offset = "0x308B740", VA = "0x18308CF40")]
	public static DNFCNMKAMCE<TOk?[]?, TErr?> GPEHIIPMIPN<TOk, TErr>(this IEnumerable<DNFCNMKAMCE<TOk, TErr>> EGGDEECAALI)
	{
		return default(DNFCNMKAMCE<TOk[], TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x308E6C0", Offset = "0x308CEC0", VA = "0x18308E6C0")]
	public static DNFCNMKAMCE<UOk?, TErr?> LONJNDPEGFF<UOk, TErr, TOk>([In] this DNFCNMKAMCE<TOk, TErr> EGGDEECAALI, Func<TOk, UOk> PCHMJDAJHOA)
	{
		return default(DNFCNMKAMCE<UOk, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class JGPDDCBHEAE<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x31444D0", Offset = "0x3142CD0", VA = "0x1831444D0")]
	public static DNFCNMKAMCE<TOk, T> FIBBLNMFPHI<TOk>([In] TOk MPPLGFCLBCJ) where TOk : notnull
	{
		return default(DNFCNMKAMCE<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x45319E0", Offset = "0x45301E0", VA = "0x1845319E0")]
	public static DNFCNMKAMCE<DOPPLCFNMND, T> FIBBLNMFPHI()
	{
		return default(DNFCNMKAMCE<DOPPLCFNMND, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x31444D0", Offset = "0x3142CD0", VA = "0x1831444D0")]
	public static DNFCNMKAMCE<T, TErr> PAGKODENKBA<TErr>([In] TErr FPHJDMEEHDA) where TErr : notnull
	{
		return default(DNFCNMKAMCE<T, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public readonly struct ODGDKAHGOHM<TKey, TValue> where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly HHIENLMDNPO LBHNIOKENCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly Dictionary<TKey, TValue> NOHKGMPJFCD;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x4071F40", Offset = "0x4070740", VA = "0x184071F40")]
	public static ODGDKAHGOHM<TKey, TValue> DFLBOLBHLFN(string IKGPEBFFMPK)
	{
		return default(ODGDKAHGOHM<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x4072100", Offset = "0x4070900", VA = "0x184072100")]
	internal ODGDKAHGOHM(Dictionary<TKey, TValue> INDENPJBLHO, HHIENLMDNPO CIKAJENLNJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x4072060", Offset = "0x4070860", VA = "0x184072060")]
	public FOHKLIPOEJA<TKey, TValue> PPPHIDAOAGM([Out] Dictionary<TKey, TValue> INDENPJBLHO)
	{
		return default(FOHKLIPOEJA<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public readonly struct FOHKLIPOEJA<TKey, TValue> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly Dictionary<TKey, TValue> NOHKGMPJFCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly POGPBMOLBMI OPHPONMNPDB;

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x251A010", Offset = "0x2518810", VA = "0x18251A010")]
	internal FOHKLIPOEJA(Dictionary<TKey, TValue> INDENPJBLHO, POGPBMOLBMI JDCNPFMFDMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x405C410", Offset = "0x405AC10", VA = "0x18405C410", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public readonly struct OJEAFEIBFIA<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly HHIENLMDNPO LBHNIOKENCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly HashSet<T> NOHKGMPJFCD;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x4071F40", Offset = "0x4070740", VA = "0x184071F40")]
	public static OJEAFEIBFIA<T> DFLBOLBHLFN(string IKGPEBFFMPK)
	{
		return default(OJEAFEIBFIA<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x4072100", Offset = "0x4070900", VA = "0x184072100")]
	internal OJEAFEIBFIA(HashSet<T> INDENPJBLHO, HHIENLMDNPO CIKAJENLNJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x4072060", Offset = "0x4070860", VA = "0x184072060")]
	public KABJFBJNKFD<T> PPPHIDAOAGM([Out] HashSet<T> INDENPJBLHO)
	{
		return default(KABJFBJNKFD<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public readonly struct KABJFBJNKFD<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly HashSet<T> NOHKGMPJFCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly POGPBMOLBMI OPHPONMNPDB;

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x251A010", Offset = "0x2518810", VA = "0x18251A010")]
	internal KABJFBJNKFD(HashSet<T> INDENPJBLHO, POGPBMOLBMI JDCNPFMFDMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x405C410", Offset = "0x405AC10", VA = "0x18405C410", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct FLJAAHEPILO<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly HHIENLMDNPO LBHNIOKENCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly Stack<T> NOHKGMPJFCD;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x4071F40", Offset = "0x4070740", VA = "0x184071F40")]
	public static FLJAAHEPILO<T> DFLBOLBHLFN(string IKGPEBFFMPK)
	{
		return default(FLJAAHEPILO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x4072100", Offset = "0x4070900", VA = "0x184072100")]
	internal FLJAAHEPILO(Stack<T> INDENPJBLHO, HHIENLMDNPO CIKAJENLNJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x4072060", Offset = "0x4070860", VA = "0x184072060")]
	public FBOKNDBGKGE<T> PPPHIDAOAGM([Out] Stack<T> INDENPJBLHO)
	{
		return default(FBOKNDBGKGE<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct FBOKNDBGKGE<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly Stack<T> NOHKGMPJFCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly POGPBMOLBMI OPHPONMNPDB;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x251A010", Offset = "0x2518810", VA = "0x18251A010")]
	internal FBOKNDBGKGE(Stack<T> INDENPJBLHO, POGPBMOLBMI JDCNPFMFDMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x405C410", Offset = "0x405AC10", VA = "0x18405C410", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[DefaultMember("Item")]
public sealed class LKMDLGFLOGC<T> : IEnumerable<T>, IEnumerable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private readonly struct EAFPENGHEFP : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly LKMDLGFLOGC<T> IHHCJAPPENJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly int OJCBACEFCLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly bool JFGKOLDFOKH;

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x2209CF0", Offset = "0x22084F0", VA = "0x182209CF0")]
		public EAFPENGHEFP(LKMDLGFLOGC<T> CLCEHBDJMEK, int NBGOIGEMKJJ, bool DJJBAEHDNAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x3CBE720", Offset = "0x3CBCF20", VA = "0x183CBE720")]
		public LKMDLGFLOGC<T>.HFBJCOFMMGM IGEPHCDGPEC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x3CBE810", Offset = "0x3CBD010", VA = "0x183CBE810", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x3CBE810", Offset = "0x3CBD010", VA = "0x183CBE810", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public sealed class HFBJCOFMMGM : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly LKMDLGFLOGC<T> IHHCJAPPENJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly int OKMOKLMDLKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private int BLOCPDDJGHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly bool JFGKOLDFOKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private bool BNMAJJGNPHI;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public T NEPDGMBEJHL
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x421F390", Offset = "0x421DB90", VA = "0x18421F390")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x421F5F0", Offset = "0x421DDF0", VA = "0x18421F5F0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x421F760", Offset = "0x421DF60", VA = "0x18421F760", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x421FB00", Offset = "0x421E300", VA = "0x18421FB00")]
		public HFBJCOFMMGM(LKMDLGFLOGC<T> CLCEHBDJMEK, int NBGOIGEMKJJ, bool DJJBAEHDNAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x421F410", Offset = "0x421DC10", VA = "0x18421F410", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x421F4A0", Offset = "0x421DCA0", VA = "0x18421F4A0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class MADPPOCHBCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public MADPPOCHBCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x4936620", Offset = "0x4934E20", VA = "0x184936620")]
		internal T AKIKFAPLAOA(int _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly T[] GEEGAJLPFAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int BLOCPDDJGHD;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int NPLBOAEMGPH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x47476E0", Offset = "0x4745EE0", VA = "0x1847476E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public T NEPDGMBEJHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x404BF10", Offset = "0x404A710", VA = "0x18404BF10")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public T EOOLHCAJLBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x47478A0", Offset = "0x47460A0", VA = "0x1847478A0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public T DBNKEBOPCEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x4747A60", Offset = "0x4746260", VA = "0x184747A60")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int NALHPIPMEMO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x1EC2A90", Offset = "0x1EC1290", VA = "0x181EC2A90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x1561CA0", Offset = "0x15604A0", VA = "0x181561CA0")]
	private static int GICPGCHKGCN(int ECDOOAABOPD, int OANKAJFHCKB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x4747B70", Offset = "0x4746370", VA = "0x184747B70")]
	public LKMDLGFLOGC(int BOOADEANLJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x4747BF0", Offset = "0x47463F0", VA = "0x184747BF0")]
	public LKMDLGFLOGC(int BOOADEANLJB, Func<T> GMKJHOADGDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x4747DB0", Offset = "0x47465B0", VA = "0x184747DB0")]
	public LKMDLGFLOGC(T[] HEMCJGBMGKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x47478E0", Offset = "0x47460E0", VA = "0x1847478E0")]
	public void KGJKAIFAAGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x4747740", Offset = "0x4745F40", VA = "0x184747740")]
	public IEnumerable<T> BCOOKIMPDDJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x4747800", Offset = "0x4746000", VA = "0x184747800")]
	public LKMDLGFLOGC<T>.HFBJCOFMMGM IGEPHCDGPEC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x40DED10", Offset = "0x40DD510", VA = "0x1840DED10", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x40DED10", Offset = "0x40DD510", VA = "0x1840DED10", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class CIIFAFLCAKJ
{
	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x2E65990", Offset = "0x2E64190", VA = "0x182E65990")]
	public static LKMDLGFLOGC<T> DFLBOLBHLFN<T>(int BOOADEANLJB, Func<T> GMKJHOADGDJ) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public sealed class HKMJPPKGPBB<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public readonly struct LEGDDLALLPK : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly HKMJPPKGPBB<T> FKBGFHIMMAN;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public T MHFLHGKPHDB
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x4722980", Offset = "0x4721180", VA = "0x184722980")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x4722950", Offset = "0x4721150", VA = "0x184722950", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x95E8E0", Offset = "0x95D0E0", VA = "0x18095E8E0")]
		public LEGDDLALLPK(HKMJPPKGPBB<T> FKBGFHIMMAN)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct IFLAEJKHFPF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public AsyncTaskMethodBuilder<LEGDDLALLPK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public HKMJPPKGPBB<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x430DA10", Offset = "0x430C210", VA = "0x18430DA10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x40802A0", Offset = "0x407EAA0", VA = "0x1840802A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly SemaphoreSlim GABMMHCLDME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private T GGLGPCDDEHG;

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x4235830", Offset = "0x4234030", VA = "0x184235830")]
	public HKMJPPKGPBB([In] T GGLGPCDDEHG, int HEICJDCGPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x4235750", Offset = "0x4233F50", VA = "0x184235750")]
	public HKMJPPKGPBB([In] T GGLGPCDDEHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x4235270", Offset = "0x4233A70", VA = "0x184235270", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x4235230", Offset = "0x4233A30", VA = "0x184235230")]
	public LEGDDLALLPK BJLEGAIACAC()
	{
		return default(LEGDDLALLPK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x42352B0", Offset = "0x4233AB0", VA = "0x1842352B0")]
	[AsyncStateMachine(typeof(HKMJPPKGPBB<>.IFLAEJKHFPF))]
	public Task<HKMJPPKGPBB<T>.LEGDDLALLPK> NHBAIJDFKGN(CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x4235730", Offset = "0x4233F30", VA = "0x184235730")]
	public void OCGKFMEKPBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class CHNAIJDBCOO
{
	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x704E490", Offset = "0x704CC90", VA = "0x18704E490")]
	public static HKMJPPKGPBB<DOPPLCFNMND> DFLBOLBHLFN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x2E619A0", Offset = "0x2E601A0", VA = "0x182E619A0")]
	public static HKMJPPKGPBB<T> DFLBOLBHLFN<T>([In] T GGLGPCDDEHG) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class LPNIHPOCMJG<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public readonly struct HFAGDFGOIMM : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private readonly LPNIHPOCMJG<T> ABKBNFABPEI;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public T MHFLHGKPHDB
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x421E080", Offset = "0x421C880", VA = "0x18421E080")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x421DE40", Offset = "0x421C640", VA = "0x18421DE40", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x95E8E0", Offset = "0x95D0E0", VA = "0x18095E8E0")]
		internal HFAGDFGOIMM(LPNIHPOCMJG<T> FKBGFHIMMAN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public readonly struct IECDMKPMLPO : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private readonly LPNIHPOCMJG<T> ABKBNFABPEI;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public T MHFLHGKPHDB
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x421E080", Offset = "0x421C880", VA = "0x18421E080")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x4305B90", Offset = "0x4304390", VA = "0x184305B90", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x95E8E0", Offset = "0x95D0E0", VA = "0x18095E8E0")]
		internal IECDMKPMLPO(LPNIHPOCMJG<T> FKBGFHIMMAN)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct FOKOFIBKAIC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public AsyncTaskMethodBuilder<IECDMKPMLPO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public LPNIHPOCMJG<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private HKMJPPKGPBB<DOPPLCFNMND>.LEGDDLALLPK <writeLock>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private TaskAwaiter<HKMJPPKGPBB<DOPPLCFNMND>.LEGDDLALLPK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x407F860", Offset = "0x407E060", VA = "0x18407F860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x40802A0", Offset = "0x407EAA0", VA = "0x1840802A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly HKMJPPKGPBB<int> MNAPGGNCNOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly HKMJPPKGPBB<DOPPLCFNMND> PJDMGPPIHEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly HKMJPPKGPBB<DOPPLCFNMND> NJLIBKMIMNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private T LLDAPFHDOGL;

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x4762C20", Offset = "0x4761420", VA = "0x184762C20")]
	internal LPNIHPOCMJG(HKMJPPKGPBB<int> EJPELABLFLI, HKMJPPKGPBB<DOPPLCFNMND> AEFEMOJGBAC, HKMJPPKGPBB<DOPPLCFNMND> HFPPMNIDEPP, [In] T GGLGPCDDEHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x4761F20", Offset = "0x4760720", VA = "0x184761F20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x47625D0", Offset = "0x4760DD0", VA = "0x1847625D0")]
	public HFAGDFGOIMM OBHBFJEPBAH()
	{
		return default(HFAGDFGOIMM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x4762090", Offset = "0x4760890", VA = "0x184762090")]
	public IECDMKPMLPO IIOAHNKJIPB()
	{
		return default(IECDMKPMLPO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x4762390", Offset = "0x4760B90", VA = "0x184762390")]
	[AsyncStateMachine(typeof(LPNIHPOCMJG<>.FOKOFIBKAIC))]
	public Task<LPNIHPOCMJG<T>.IECDMKPMLPO> OBDNCBMKKAH(CancellationToken ALKEMFHOMCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class OELJJOLAOMK
{
	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x70518B0", Offset = "0x70500B0", VA = "0x1870518B0")]
	public static LPNIHPOCMJG<DOPPLCFNMND> DFLBOLBHLFN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x31F5140", Offset = "0x31F3940", VA = "0x1831F5140")]
	public static LPNIHPOCMJG<T> DFLBOLBHLFN<T>([In] T GGLGPCDDEHG) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public sealed class OOODEMCEFAA<TData> : LHIOHJOJEEI where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly string NCOGKFNMLFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly TData OPIJNNAEPFH;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0", Slot = "7")]
	public override string DHOBPLNCIMP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x4B70F60", Offset = "0x4B6F760", VA = "0x184B70F60")]
	internal OOODEMCEFAA(string PJFOMDHJLBF, [In] TData EBNFOODJNOB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class BJLNBACDBOK
{
	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x704E2D0", Offset = "0x704CAD0", VA = "0x18704E2D0")]
	public static OOODEMCEFAA<DOPPLCFNMND> DFLBOLBHLFN(string PJFOMDHJLBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x2DE93A0", Offset = "0x2DE7BA0", VA = "0x182DE93A0")]
	public static OOODEMCEFAA<TData> DFLBOLBHLFN<TData>(string PJFOMDHJLBF, [In] TData EBNFOODJNOB) where TData : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public sealed class HHIENLMDNPO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	internal bool CMOAFFOOOJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly string KFMGBNKBKCI;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0xA27870", Offset = "0xA26070", VA = "0x180A27870")]
	private HHIENLMDNPO(bool NHBJDHJAEDA, string BADJFCDHMPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x7050760", Offset = "0x704EF60", VA = "0x187050760")]
	public static HHIENLMDNPO DFLBOLBHLFN(string BADJFCDHMPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x70507D0", Offset = "0x704EFD0", VA = "0x1870507D0")]
	public POGPBMOLBMI PPPHIDAOAGM()
	{
		return default(POGPBMOLBMI);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public readonly struct POGPBMOLBMI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly HHIENLMDNPO EJLDGMJBAHG;

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x95E8E0", Offset = "0x95D0E0", VA = "0x18095E8E0")]
	internal POGPBMOLBMI(HHIENLMDNPO IKGPEBFFMPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x7051C40", Offset = "0x7050440", VA = "0x187051C40", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[Obsolete("Use SimpleTokenFlag or WeakTokenFlag<T> instead")]
public sealed class FMGCKCADPPB<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class GANOBFDKEAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public GANOBFDKEAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x411D150", Offset = "0x411B950", VA = "0x18411D150")]
		internal int OPLEHHNIEKD(int i, T token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private HashSet<T>? JPBHECHKDOH;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public IReadOnlyCollection<T> IHEAFKOFJOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x40760A0", Offset = "0x40748A0", VA = "0x1840760A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool CLCNPCLLHPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x4076330", Offset = "0x4074B30", VA = "0x184076330")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int BMBFHPLNLGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x8BC040", Offset = "0x8BA840", VA = "0x1808BC040")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x8C38D0", Offset = "0x8C20D0", VA = "0x1808C38D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x4076380", Offset = "0x4074B80", VA = "0x184076380")]
	public bool JGCMIIMCCFC(T DJIMHLGHFGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x40760E0", Offset = "0x40748E0", VA = "0x1840760E0")]
	public bool CGFLGFPAOEK(T DJIMHLGHFGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x4076540", Offset = "0x4074D40", VA = "0x184076540")]
	public bool OFHJLFLDBLP(T DJIMHLGHFGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x4076250", Offset = "0x4074A50", VA = "0x184076250")]
	public void EKLFCOEGAHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x4076590", Offset = "0x4074D90", VA = "0x184076590", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
	public FMGCKCADPPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public sealed class COKMJHAKPPF
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class BGBLAMAFMBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public BGBLAMAFMBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x704E220", Offset = "0x704CA20", VA = "0x18704E220")]
		internal int OPLEHHNIEKD(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private HashSet<object>? JPBHECHKDOH;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public IReadOnlyCollection<object> IHEAFKOFJOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x704E500", Offset = "0x704CD00", VA = "0x18704E500")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool CLCNPCLLHPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x704E6A0", Offset = "0x704CEA0", VA = "0x18704E6A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int BMBFHPLNLGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x8BC040", Offset = "0x8BA840", VA = "0x1808BC040")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x8C38D0", Offset = "0x8C20D0", VA = "0x1808C38D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x704E6B0", Offset = "0x704CEB0", VA = "0x18704E6B0")]
	public bool JGCMIIMCCFC(object DJIMHLGHFGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x704E590", Offset = "0x704CD90", VA = "0x18704E590")]
	public bool CGFLGFPAOEK(object DJIMHLGHFGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x704E790", Offset = "0x704CF90", VA = "0x18704E790")]
	public bool OFHJLFLDBLP(object DJIMHLGHFGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x704E630", Offset = "0x704CE30", VA = "0x18704E630")]
	public void EKLFCOEGAHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x704E7F0", Offset = "0x704CFF0", VA = "0x18704E7F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
	public COKMJHAKPPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class EFAGCHENKHK<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private struct BHGFABIJPAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public float PCOALHOAMMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public T MHFLHGKPHDB;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly Dictionary<object, BHGFABIJPAI> BGEPJDBLALA;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public virtual T BENJJCDJPIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x146BBD0", Offset = "0x146A3D0", VA = "0x18146BBD0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x14699C0", Offset = "0x14681C0", VA = "0x1814699C0", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public object? ONBJONIIENB
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x8BB240", Offset = "0x8B9A40", VA = "0x1808BB240")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x8BE310", Offset = "0x8BCB10", VA = "0x1808BE310")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool JLJFJEGABND
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x3CD07F0", Offset = "0x3CCEFF0", VA = "0x183CD07F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x3CD0330", Offset = "0x3CCEB30", VA = "0x183CD0330")]
	public bool IHBACDHKKON(T INDENPJBLHO, object DJIMHLGHFGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x3CD0850", Offset = "0x3CCF050", VA = "0x183CD0850")]
	public bool LDLHHJBCJKM(object DJIMHLGHFGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x3CCF240", Offset = "0x3CCDA40", VA = "0x183CCF240")]
	public void CPGLBCDJJEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x3CD0080", Offset = "0x3CCE880", VA = "0x183CD0080")]
	public bool HDDNHEKKGGH(object DJIMHLGHFGI, [Out] T INDENPJBLHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x3CCF290", Offset = "0x3CCDA90", VA = "0x183CCF290")]
	[HFPGIODOIKD("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool DABBBMGHNDG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x3CD08F0", Offset = "0x3CCF0F0", VA = "0x183CD08F0")]
	public EFAGCHENKHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public sealed class PANGGMGFJOH : BIPBADNDKPC<DEAMBOJPKEE>
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	internal class CCPMBJPDINL : IEqualityComparer<DEAMBOJPKEE>
	{
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		internal static readonly CCPMBJPDINL ODDIIHPHFEL;

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x704E350", Offset = "0x704CB50", VA = "0x18704E350", Slot = "4")]
		public bool Equals(DEAMBOJPKEE KHINBLFKKED, DEAMBOJPKEE NCCBPIFKDGE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x634C340", Offset = "0x634AB40", VA = "0x18634C340", Slot = "5")]
		public int GetHashCode(DEAMBOJPKEE INCBEIDOHDO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public CCPMBJPDINL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x7051BD0", Offset = "0x70503D0", VA = "0x187051BD0")]
	public PANGGMGFJOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x7051B20", Offset = "0x7050320", VA = "0x187051B20", Slot = "4")]
	public override bool JGCMIIMCCFC(DEAMBOJPKEE DJIMHLGHFGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x7051A70", Offset = "0x7050270", VA = "0x187051A70", Slot = "5")]
	public override bool CGFLGFPAOEK(DEAMBOJPKEE DJIMHLGHFGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x70519E0", Offset = "0x70501E0", VA = "0x1870519E0")]
	private static void ALCGAKFKGNA(DEAMBOJPKEE DJIMHLGHFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x136A7C0", Offset = "0x1368FC0", VA = "0x18136A7C0", Slot = "6")]
	protected override string ONHFNPGHGMF(DEAMBOJPKEE DJIMHLGHFGI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public sealed class DEAMBOJPKEE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly string LNACDENDFCN;

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x8C0090", Offset = "0x8BE890", VA = "0x1808C0090")]
	public DEAMBOJPKEE(string LNACDENDFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x704E9A0", Offset = "0x704D1A0", VA = "0x18704E9A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public abstract class BIPBADNDKPC<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly IEqualityComparer<T> HADPFNKGDNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private HashSet<T>? JPBHECHKDOH;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool CLCNPCLLHPG
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x4FBBA10", Offset = "0x4FBA210", VA = "0x184FBBA10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public int BMBFHPLNLGE
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x958980", Offset = "0x957180", VA = "0x180958980")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x95C4E0", Offset = "0x95ACE0", VA = "0x18095C4E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x53BBE30", Offset = "0x53BA630", VA = "0x1853BBE30")]
	internal BIPBADNDKPC(IEqualityComparer<T> HADPFNKGDNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x53BB970", Offset = "0x53BA170", VA = "0x1853BB970", Slot = "4")]
	public virtual bool JGCMIIMCCFC(T DJIMHLGHFGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x53BB720", Offset = "0x53B9F20", VA = "0x1853BB720", Slot = "5")]
	public virtual bool CGFLGFPAOEK(T DJIMHLGHFGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x53BB890", Offset = "0x53BA090", VA = "0x1853BB890")]
	public void EKLFCOEGAHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract string ONHFNPGHGMF(T DJIMHLGHFGI);

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x53BBB40", Offset = "0x53BA340", VA = "0x1853BBB40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public sealed class HNBPJCMIGFD<T> where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private List<WeakReference<T>>? JPBHECHKDOH;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool CLCNPCLLHPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x423FD10", Offset = "0x423E510", VA = "0x18423FD10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int BMBFHPLNLGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x42400A0", Offset = "0x423E8A0", VA = "0x1842400A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x423FE30", Offset = "0x423E630", VA = "0x18423FE30")]
	public void JGCMIIMCCFC(T DJIMHLGHFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x423FB30", Offset = "0x423E330", VA = "0x18423FB30")]
	public void CGFLGFPAOEK(T DJIMHLGHFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x423FCD0", Offset = "0x423E4D0", VA = "0x18423FCD0")]
	public void EKLFCOEGAHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x4240240", Offset = "0x423EA40", VA = "0x184240240", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
	public HNBPJCMIGFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal static class GELBHCIBNHI
{
	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x307A740", Offset = "0x3078F40", VA = "0x18307A740")]
	public static void GGEAHALPHLA<T>(this List<T> OCHGNEGGEPP, int ECDOOAABOPD) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class HDDFNIOODIF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly Dictionary<object, float> BGEPJDBLALA;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public float GAEJGPLGIGK
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0xB07540", Offset = "0xB05D40", VA = "0x180B07540")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0xB074D0", Offset = "0xB05CD0", VA = "0x180B074D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x70505F0", Offset = "0x704EDF0", VA = "0x1870505F0")]
	public void IHBACDHKKON(float INDENPJBLHO, object DJIMHLGHFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x7050660", Offset = "0x704EE60", VA = "0x187050660")]
	public void LDLHHJBCJKM(object DJIMHLGHFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x7050470", Offset = "0x704EC70", VA = "0x187050470")]
	public void CPGLBCDJJEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x70504C0", Offset = "0x704ECC0", VA = "0x1870504C0")]
	private void EHDECINGLKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x70506D0", Offset = "0x704EED0", VA = "0x1870506D0")]
	public HDDFNIOODIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public interface CIFIJBDIPIG
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event AJDCEPFFECP LLDDOJBPBHK;
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class EGEKMEJJJIB : CIFIJBDIPIG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public readonly struct GIKDAACIOPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public readonly float CIICEFGCNDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public readonly float LFOFFNOPOIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		internal readonly bool LNCHMIOPEFL;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public float LJIEDMFFEMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x704F8F0", Offset = "0x704E0F0", VA = "0x18704F8F0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x704FA60", Offset = "0x704E260", VA = "0x18704FA60")]
		public GIKDAACIOPL(float EEPGNNLBJAH, float GNDBPGCEJCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x704F900", Offset = "0x704E100", VA = "0x18704F900", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class CHFIEMKPNNI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public EGEKMEJJJIB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public CHFIEMKPNNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x704E3F0", Offset = "0x704CBF0", VA = "0x18704E3F0")]
		internal void NENGAGLMGDC(float innerProgress)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly int DEOEMPAJCCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private int ONOIDKKJFJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly CIFIJBDIPIG[] HCCOJNJMBMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly AJDCEPFFECP[] BIJBPNIFOLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly GIKDAACIOPL[] PAPAMCNICAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private GIKDAACIOPL MPJJJMCHMNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly KFOEIFPHEMO EHDDFNGJKMO;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event AJDCEPFFECP LLDDOJBPBHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x704F120", Offset = "0x704D920", VA = "0x18704F120", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x704F1E0", Offset = "0x704D9E0", VA = "0x18704F1E0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x704F2A0", Offset = "0x704DAA0", VA = "0x18704F2A0")]
	public EGEKMEJJJIB(int DEOEMPAJCCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x704EF80", Offset = "0x704D780", VA = "0x18704EF80")]
	public KFOEIFPHEMO CHAIHNDCKKO(GIKDAACIOPL DGMMIIPLMEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x704EB10", Offset = "0x704D310", VA = "0x18704EB10")]
	public void ALKKLDHOPDA(CIFIJBDIPIG LFNLANBGFJM, [Optional] GIKDAACIOPL FMPCHBCIHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x704F010", Offset = "0x704D810", VA = "0x18704F010", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public delegate void AJDCEPFFECP(float KCBBFMGKHFJ);
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class IFOMAHALJHA
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private class DJNLKKJGNBH : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private readonly CIFIJBDIPIG DGCDCAJEHLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private readonly AJDCEPFFECP KNMHMBJIFMM;

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x704EA40", Offset = "0x704D240", VA = "0x18704EA40")]
		public DJNLKKJGNBH(CIFIJBDIPIG DGCDCAJEHLB, AJDCEPFFECP KNMHMBJIFMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x704E9F0", Offset = "0x704D1F0", VA = "0x18704E9F0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x70508D0", Offset = "0x704F0D0", VA = "0x1870508D0")]
	internal static bool ILAMDNJBIIM(float DAOGAHJCGEC, float NBDADAEEFHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x703B820", Offset = "0x703A020", VA = "0x18703B820")]
	internal static float COAHOHDEGOD(float DAOGAHJCGEC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x7050940", Offset = "0x704F140", VA = "0x187050940")]
	public static IDisposable MBCHJIJKDEB(this CIFIJBDIPIG DGCDCAJEHLB, AJDCEPFFECP KNMHMBJIFMM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class KFOEIFPHEMO : CIFIJBDIPIG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private float KCBBFMGKHFJ;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public float AKDJJCFEAHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x7050F30", Offset = "0x704F730", VA = "0x187050F30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event AJDCEPFFECP? LLDDOJBPBHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x7050E90", Offset = "0x704F690", VA = "0x187050E90", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x7051020", Offset = "0x704F820", VA = "0x187051020", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
	public KFOEIFPHEMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public interface KHMCALICHFA<T> where T : class, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PEKLCBBEBHF<T> ANDLJNEIADF([Out] T INDENPJBLHO);

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CPGLBCDJJEJ();
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class ODOBILHMEBB<T> : KHMCALICHFA<T> where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly ConcurrentStack<T> MLKKFJPDCDF;

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x4B42880", Offset = "0x4B41080", VA = "0x184B42880", Slot = "4")]
	public PEKLCBBEBHF<T> ANDLJNEIADF([Out] T INDENPJBLHO)
	{
		return default(PEKLCBBEBHF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x4B429C0", Offset = "0x4B411C0", VA = "0x184B429C0")]
	public void JGKHHIOHILA(T HGAMPHGJNJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x422D830", Offset = "0x422C030", VA = "0x18422D830", Slot = "5")]
	public void CPGLBCDJJEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "6")]
	protected virtual void HNPEOEKOLIC(T NMBOMNBMPCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x4B42920", Offset = "0x4B41120", VA = "0x184B42920")]
	private T EFGCOGNKKLM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x4B42A40", Offset = "0x4B41240", VA = "0x184B42A40")]
	public ODOBILHMEBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public readonly struct PEKLCBBEBHF<T> : IDisposable where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly T HGAMPHGJNJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly ODOBILHMEBB<T> OLCLKINJODJ;

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0xE64E60", Offset = "0xE63660", VA = "0x180E64E60")]
	internal PEKLCBBEBHF(T INDENPJBLHO, ODOBILHMEBB<T> OLCLKINJODJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x4C32540", Offset = "0x4C30D40", VA = "0x184C32540", Slot = "4")]
	void IDisposable.Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class GCEEKJNGMGG : ODOBILHMEBB<StringBuilder>
{
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public static readonly GCEEKJNGMGG ODDIIHPHFEL;

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x704F430", Offset = "0x704DC30", VA = "0x18704F430")]
	public static PEKLCBBEBHF<StringBuilder> EFGCOGNKKLM([Out] StringBuilder INDENPJBLHO)
	{
		return default(PEKLCBBEBHF<StringBuilder>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x704F4D0", Offset = "0x704DCD0", VA = "0x18704F4D0", Slot = "6")]
	protected override void HNPEOEKOLIC(StringBuilder NMBOMNBMPCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x704F590", Offset = "0x704DD90", VA = "0x18704F590")]
	public GCEEKJNGMGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class DPDNODNNCPN : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x6A1A090", Offset = "0x6A18890", VA = "0x186A1A090")]
	public DPDNODNNCPN(string PJFOMDHJLBF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
[DefaultMember("Item")]
public class EGHCKPGECEF<TKey, TValue> : EFMBBGBPKKB<TKey, TValue>, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, DGJCGLBLBNM where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class CLDLBOPALGF : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private KeyValuePair<TKey, TValue> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public EGHCKPGECEF<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private IEnumerator<KeyValuePair<TKey, TValue>> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		KeyValuePair<TKey, TValue> IEnumerator<KeyValuePair<TKey, TValue>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x146BBD0", Offset = "0x146A3D0", VA = "0x18146BBD0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TValue>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x5936CD0", Offset = "0x59354D0", VA = "0x185936CD0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x8BAB50", Offset = "0x8B9350", VA = "0x1808BAB50")]
		[DebuggerHidden]
		public CLDLBOPALGF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x40A1AE0", Offset = "0x40A02E0", VA = "0x1840A1AE0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x5936210", Offset = "0x5934A10", VA = "0x185936210", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x5936AF0", Offset = "0x59352F0", VA = "0x185936AF0")]
		private void PPNAIGJNIFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x5935CC0", Offset = "0x59344C0", VA = "0x185935CC0")]
		private void DIDCIHLHMHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x5936C80", Offset = "0x5935480", VA = "0x185936C80", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly EFMBBGBPKKB<TKey, TValue> OHJJGAOOAPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly IDictionary<TKey, TValue> ONJFNENCEPB;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int BMBFHPLNLGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x3CD5850", Offset = "0x3CD4050", VA = "0x183CD5850", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool CDFNJCJNLIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x8FF830", Offset = "0x8FE030", VA = "0x1808FF830", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public TValue DBNKEBOPCEB
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x3CD5A30", Offset = "0x3CD4230", VA = "0x183CD5A30", Slot = "4")]
		get
		{
			return (TValue)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x3CD5D00", Offset = "0x3CD4500", VA = "0x183CD5D00", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public ICollection<TKey> GAAJPNHEALD
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x3CD5A80", Offset = "0x3CD4280", VA = "0x183CD5A80", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public ICollection<TValue> BACFIAEHIEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x3CD5BA0", Offset = "0x3CD43A0", VA = "0x183CD5BA0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x3CD56C0", Offset = "0x3CD3EC0", VA = "0x183CD56C0")]
	public EGHCKPGECEF(EFMBBGBPKKB<TKey, TValue> OHJJGAOOAPP, [Optional] IDictionary<TKey, TValue>? ONJFNENCEPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x3CD2FF0", Offset = "0x3CD17F0", VA = "0x183CD2FF0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x3CD2A10", Offset = "0x3CD1210", VA = "0x183CD2A10")]
	public void ANBFAGOPHKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x3CD2CD0", Offset = "0x3CD14D0", VA = "0x183CD2CD0", Slot = "9")]
	public void Add(TKey KCGKBDGKIOP, TValue INDENPJBLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x3CD3B10", Offset = "0x3CD2310", VA = "0x183CD3B10")]
	public void EOPFPKKEABP(TKey KCGKBDGKIOP, TValue INDENPJBLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x3CD3980", Offset = "0x3CD2180", VA = "0x183CD3980")]
	public void DOLOKPAFHGD(TKey KCGKBDGKIOP, TValue INDENPJBLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x3CD4380", Offset = "0x3CD2B80", VA = "0x183CD4380")]
	public void KMODPDMGINF(TKey KCGKBDGKIOP, TValue INDENPJBLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x3CD3FB0", Offset = "0x3CD27B0", VA = "0x183CD3FB0")]
	public void HKEJHOJOPEM(TKey KCGKBDGKIOP, TValue INDENPJBLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x3CD4D00", Offset = "0x3CD3500", VA = "0x183CD4D00", Slot = "14")]
	void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> DEDDGCENOOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x3CD4EF0", Offset = "0x3CD36F0", VA = "0x183CD4EF0", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> DEDDGCENOOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x3CD5250", Offset = "0x3CD3A50", VA = "0x183CD5250", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> DEDDGCENOOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x3CD3130", Offset = "0x3CD1930", VA = "0x183CD3130", Slot = "8")]
	public bool ContainsKey(TKey KCGKBDGKIOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x3CD4880", Offset = "0x3CD3080", VA = "0x183CD4880")]
	public bool PGNPKJBKDDA(TKey KCGKBDGKIOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x3CD49A0", Offset = "0x3CD31A0", VA = "0x183CD49A0")]
	public bool PHDJJLPIBHI(TKey KCGKBDGKIOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x3CD4B20", Offset = "0x3CD3320", VA = "0x183CD4B20", Slot = "10")]
	public bool Remove(TKey KCGKBDGKIOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x3CD5450", Offset = "0x3CD3C50", VA = "0x183CD5450", Slot = "11")]
	public bool TryGetValue(TKey KCGKBDGKIOP, [Out] TValue INDENPJBLHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x3CD31F0", Offset = "0x3CD19F0", VA = "0x183CD31F0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TValue>[] GHAIAFELBIF, int KHBFEFGODGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x3CD5410", Offset = "0x3CD3C10", VA = "0x183CD5410", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x3CD3D70", Offset = "0x3CD2570", VA = "0x183CD3D70", Slot = "19")]
	[IteratorStateMachine(typeof(EGHCKPGECEF<, >.CLDLBOPALGF))]
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x3CD2F00", Offset = "0x3CD1700", VA = "0x183CD2F00", Slot = "21")]
	public bool CBOOAJLFGKO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x3CD40A0", Offset = "0x3CD28A0", VA = "0x183CD40A0")]
	private TValue IDCADAAFLON(TKey KCGKBDGKIOP)
	{
		return (TValue)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public interface DGJCGLBLBNM
{
	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CBOOAJLFGKO();
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public interface EFMBBGBPKKB<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, DGJCGLBLBNM
{
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[DefaultMember("Item")]
public sealed class LAMAMKMDIIM<TKey, TVal> : EFMBBGBPKKB<TKey, TVal>, IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, DGJCGLBLBNM where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public delegate int PGMHGKOGJAH(TKey KCGKBDGKIOP, TVal INDENPJBLHO);

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public delegate void HCEEJBDOAFG(TKey KCGKBDGKIOP, TVal INDENPJBLHO, FLLCJGJOAOM HLONLEDABCF);

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	private class DEMAHIEPPPF
	{
		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public TKey GCHHHJJPOEP
		{
			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0xB2DD30", Offset = "0xB2C530", VA = "0x180B2DD30")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public TVal MHFLHGKPHDB
		{
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x958980", Offset = "0x957180", VA = "0x180958980")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x95C4E0", Offset = "0x95ACE0", VA = "0x18095C4E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public int LJIEDMFFEMK
		{
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x8F6DE0", Offset = "0x8F55E0", VA = "0x1808F6DE0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x8F63E0", Offset = "0x8F4BE0", VA = "0x1808F63E0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public DateTimeOffset ALBHDBJEAMB
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0xE30630", Offset = "0xE2EE30", VA = "0x180E30630")]
			[CompilerGenerated]
			get
			{
				return default(DateTimeOffset);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0xE31020", Offset = "0xE2F820", VA = "0x180E31020")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x5D95670", Offset = "0x5D93E70", VA = "0x185D95670")]
		public DEMAHIEPPPF(TKey KCGKBDGKIOP, TVal DBIIPNGMHFP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private sealed class LLEPPALCBJF : IEnumerator<KeyValuePair<TKey, TVal>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private KeyValuePair<TKey, TVal> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public LAMAMKMDIIM<TKey, TVal> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private LinkedList<DEMAHIEPPPF>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		KeyValuePair<TKey, TVal> IEnumerator<KeyValuePair<TKey, TVal>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x146BBD0", Offset = "0x146A3D0", VA = "0x18146BBD0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TVal>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x47487C0", Offset = "0x4746FC0", VA = "0x1847487C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x8BAB50", Offset = "0x8B9350", VA = "0x1808BAB50")]
		[DebuggerHidden]
		public LLEPPALCBJF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x409C5E0", Offset = "0x409ADE0", VA = "0x18409C5E0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x47483F0", Offset = "0x4746BF0", VA = "0x1847483F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x4748700", Offset = "0x4746F00", VA = "0x184748700")]
		private void PPNAIGJNIFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x4748720", Offset = "0x4746F20", VA = "0x184748720", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public const int HLKEDLIHKCB = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly Dictionary<TKey, LinkedListNode<DEMAHIEPPPF>> MMOCGNFAJFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly LinkedList<DEMAHIEPPPF> NAFHAGLOGAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly PGMHGKOGJAH? BGBBEFDHFKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly TimeSpan HBGHEBDAGMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly HCEEJBDOAFG? PDMDLIHHHLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly PIAKAKLALCN MEMBIEFCPPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private bool IAEALADBMFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly List<TKey> DPDJCJKBDMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly List<TVal> AGOFCAJHPME;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int LMJANDOFNOO
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x8C5EE0", Offset = "0x8C46E0", VA = "0x1808C5EE0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	internal int MGMPPEIGDHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x95B900", Offset = "0x95A100", VA = "0x18095B900")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0xA88430", Offset = "0xA86C30", VA = "0x180A88430")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int BMBFHPLNLGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x470C4A0", Offset = "0x470ACA0", VA = "0x18470C4A0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	internal int EIBFEEKHAEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x3CCF240", Offset = "0x3CCDA40", VA = "0x183CCF240")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public ICollection<TVal> BACFIAEHIEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x470C620", Offset = "0x470AE20", VA = "0x18470C620", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	ICollection<TKey> IDictionary<TKey, TVal>.JBHJLKKLFMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x4707B70", Offset = "0x4706370", VA = "0x184707B70", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool CDFNJCJNLIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x8FF830", Offset = "0x8FE030", VA = "0x1808FF830", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public TVal DBNKEBOPCEB
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x470C590", Offset = "0x470AD90", VA = "0x18470C590", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x470C710", Offset = "0x470AF10", VA = "0x18470C710", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x47060A0", Offset = "0x47048A0", VA = "0x1847060A0")]
	private bool NHLLMNJNAJI(int DEOEMPAJCCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x46FB420", Offset = "0x46F9C20", VA = "0x1846FB420")]
	private void DKCKKPIPCHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x470C2E0", Offset = "0x470AAE0", VA = "0x18470C2E0")]
	public LAMAMKMDIIM(int DEOEMPAJCCC, [Optional] PGMHGKOGJAH? BGBBEFDHFKE, [Optional] IEqualityComparer<TKey>? NDICNLPGKMA, [Optional] HCEEJBDOAFG? PDMDLIHHHLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x4708FB0", Offset = "0x47077B0", VA = "0x184708FB0")]
	public LAMAMKMDIIM(TimeSpan HBGHEBDAGMH, [Optional] IEqualityComparer<TKey>? NDICNLPGKMA, [Optional] HCEEJBDOAFG? PDMDLIHHHLK, [Optional] PIAKAKLALCN? MEMBIEFCPPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x4708AD0", Offset = "0x47072D0", VA = "0x184708AD0")]
	public LAMAMKMDIIM(int DEOEMPAJCCC, TimeSpan HBGHEBDAGMH, [Optional] IEqualityComparer<TKey>? NDICNLPGKMA, [Optional] HCEEJBDOAFG? PDMDLIHHHLK, [Optional] PIAKAKLALCN? MEMBIEFCPPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x470A600", Offset = "0x4708E00", VA = "0x18470A600")]
	public LAMAMKMDIIM(int DEOEMPAJCCC, PGMHGKOGJAH? BGBBEFDHFKE, TimeSpan HBGHEBDAGMH, [Optional] IEqualityComparer<TKey>? NDICNLPGKMA, [Optional] HCEEJBDOAFG? PDMDLIHHHLK, [Optional] PIAKAKLALCN? MEMBIEFCPPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x46F4A20", Offset = "0x46F3220", VA = "0x1846F4A20", Slot = "21")]
	public bool CBOOAJLFGKO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x4706300", Offset = "0x4704B00", VA = "0x184706300", Slot = "22")]
	public bool NMFHKGHBPIF(int BOOADEANLJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x46F84C0", Offset = "0x46F6CC0", VA = "0x1846F84C0")]
	private bool DAPPOEAPIKF(int BOOADEANLJB, FLLCJGJOAOM HLONLEDABCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x47050E0", Offset = "0x47038E0", VA = "0x1847050E0")]
	public void KLHHFEENEBM(TKey KCGKBDGKIOP, TVal INDENPJBLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x46F4100", Offset = "0x46F2900", VA = "0x1846F4100", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> DEDDGCENOOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x46F4760", Offset = "0x46F2F60", VA = "0x1846F4760", Slot = "9")]
	public void Add(TKey KCGKBDGKIOP, TVal INDENPJBLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x46F4BE0", Offset = "0x46F33E0", VA = "0x1846F4BE0", Slot = "8")]
	public bool ContainsKey(TKey KCGKBDGKIOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x47074C0", Offset = "0x4705CC0", VA = "0x1847074C0", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Contains(KeyValuePair<TKey, TVal> DEDDGCENOOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x4706E70", Offset = "0x4705670", VA = "0x184706E70", Slot = "10")]
	public bool Remove(TKey KCGKBDGKIOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x47076D0", Offset = "0x4705ED0", VA = "0x1847076D0", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Remove(KeyValuePair<TKey, TVal> DEDDGCENOOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x47045A0", Offset = "0x4702DA0", VA = "0x1847045A0")]
	private bool JMIJJJBOIBE(TKey KCGKBDGKIOP, [Out] TVal INDENPJBLHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x46FFD40", Offset = "0x46FE540", VA = "0x1846FFD40")]
	private TVal EFGCOGNKKLM(TKey IMKLPELFAIL)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x4707C00", Offset = "0x4706400", VA = "0x184707C00", Slot = "11")]
	public bool TryGetValue(TKey IMKLPELFAIL, [Out] TVal INDENPJBLHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x46F4AC0", Offset = "0x46F32C0", VA = "0x1846F4AC0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x46F6FF0", Offset = "0x46F57F0", VA = "0x1846F6FF0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] GHAIAFELBIF, int KHBFEFGODGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x47056E0", Offset = "0x4703EE0", VA = "0x1847056E0")]
	private void MFPGHOHMHMN(TKey KCGKBDGKIOP, TVal DBIIPNGMHFP, FLLCJGJOAOM HLONLEDABCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x4702780", Offset = "0x4700F80", VA = "0x184702780")]
	private bool JFIAGIIDPIM(DEMAHIEPPPF AFPMAPGDAME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x46FD470", Offset = "0x46FBC70", VA = "0x1846FD470")]
	private void DNADMJHCECN(LinkedListNode<DEMAHIEPPPF> FHFJFOOBEGH, TVal HJMMFMOBFMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x4701710", Offset = "0x46FFF10", VA = "0x184701710")]
	private void IHBACDHKKON(TKey KCGKBDGKIOP, TVal INDENPJBLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x46F2C20", Offset = "0x46F1420", VA = "0x1846F2C20")]
	private void ABCLDDEJFAF(DEMAHIEPPPF AFPMAPGDAME, TVal HJMMFMOBFMP, int CNAOMLJPIFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x4700190", Offset = "0x46FE990", VA = "0x184700190", Slot = "19")]
	[IteratorStateMachine(typeof(LAMAMKMDIIM<, >.LLEPPALCBJF))]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x4707BC0", Offset = "0x47063C0", VA = "0x184707BC0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public enum FLLCJGJOAOM : byte
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
public class FMOHEGFNAEL<TKey> : Exception where TKey : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public readonly TKey HIDGDDPEKPA;

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x4076C90", Offset = "0x4075490", VA = "0x184076C90")]
	public FMOHEGFNAEL(TKey PJMCIBMCJBJ, Exception OIFLGCNHIPA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public class AKNBFMMEHIP : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x62DD040", Offset = "0x62DB840", VA = "0x1862DD040")]
	public AKNBFMMEHIP(string PJFOMDHJLBF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class LFBBGDCJOMI<TId, TResource> : IEnumerable<(TId, Task<TResource>, int)>, IEnumerable where TId : notnull where TResource : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class INPFGNOOJMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public Func<TId, CancellationToken, Task<TResource>> factory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public LFBBGDCJOMI<TId, TResource> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public INPFGNOOJMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x4338F30", Offset = "0x4337730", VA = "0x184338F30")]
		internal Task<TResource> CMIGMNOBGBO(TId _id)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private struct JBLMHGLGNNF : IAsyncStateMachine
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
		public LFBBGDCJOMI<TId, TResource> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x4522E60", Offset = "0x4521660", VA = "0x184522E60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x4523700", Offset = "0x4521F00", VA = "0x184523700", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private struct GJDHMGABMBK : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x4134070", Offset = "0x4132870", VA = "0x184134070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x4134AF0", Offset = "0x41332F0", VA = "0x184134AF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private readonly CLCIPLDHMAD<TId, Task<TResource>> PFFAGENFIOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private readonly Dictionary<Task<TResource>, CancellationTokenSource> DDHIPKANCFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly Func<TId, CancellationToken, Task<TResource>>? GAMDOFIJFJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly Action<TResource>? NLCINBPEDAN;

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x4724190", Offset = "0x4722990", VA = "0x184724190")]
	public LFBBGDCJOMI(int MIEHFACIEHL = 0, [Optional] IEqualityComparer<TId>? DEKBHKAHJGK, [Optional] Func<TId, CancellationToken, Task<TResource>>? NKHLDLEOOHA, [Optional] Action<TResource>? PGBAJGOCKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x47229A0", Offset = "0x47211A0", VA = "0x1847229A0")]
	public DPGJMAFIAMJ<Task<TResource>> FPMCBLLCGJK(TId DOBPKLNCBDO, [Optional] Func<TId, CancellationToken, Task<TResource>>? NKHLDLEOOHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x4723740", Offset = "0x4721F40", VA = "0x184723740")]
	private void KILLBIPFPJM(Task<TResource> DIGFCMIOIEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x4723DC0", Offset = "0x47225C0", VA = "0x184723DC0")]
	[AsyncStateMachine(typeof(LFBBGDCJOMI<, >.JBLMHGLGNNF))]
	private Task MOJKNKHOLGH(Task<TResource> DIGFCMIOIEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x4244F60", Offset = "0x4243760", VA = "0x184244F60")]
	public void PFJBPCIOPEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x4723190", Offset = "0x4721990", VA = "0x184723190")]
	public CLCIPLDHMAD<TId, Task<TResource>>.KNGLAHLGIIG IGEPHCDGPEC()
	{
		return default(CLCIPLDHMAD<TId, Task<TResource>>.KNGLAHLGIIG);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x4724050", Offset = "0x4722850", VA = "0x184724050", Slot = "4")]
	private IEnumerator<(TId, Task<TResource>, int)> System.Collections.Generic.IEnumerable<(TIdId,System.Threading.Tasks.Task<TResource>LoadResourceTask,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x4724050", Offset = "0x4722850", VA = "0x184724050", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x4723610", Offset = "0x4721E10", VA = "0x184723610")]
	[AsyncStateMachine(typeof(LFBBGDCJOMI<, >.GJDHMGABMBK))]
	[CompilerGenerated]
	internal static Task IHCNALGCPPJ(Task<TResource> DIGFCMIOIEB, CancellationTokenSource JPKOIJILKHI, Dictionary<Task<TResource>, CancellationTokenSource> DEPAJNNMNLE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class CLCIPLDHMAD<TKey, TValue> : IEnumerable<(TKey, TValue, int)>, IEnumerable where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	private sealed class GEPGLOBCOOP : IEquatable<GEPGLOBCOOP>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public readonly TValue MHFLHGKPHDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public int PLMCFMPKADG;

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0xD2DF20", Offset = "0xD2C720", VA = "0x180D2DF20")]
		public GEPGLOBCOOP(TValue INDENPJBLHO, int HFBBOKCMKLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x4126370", Offset = "0x4124B70", VA = "0x184126370", Slot = "4")]
		public bool Equals(GEPGLOBCOOP? LIHCAHPMPHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x41262D0", Offset = "0x4124AD0", VA = "0x1841262D0", Slot = "0")]
		public override bool Equals(object? INCBEIDOHDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x41265B0", Offset = "0x4124DB0", VA = "0x1841265B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public struct KNGLAHLGIIG : IEnumerator<(TKey, TValue, int)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private Dictionary<TKey, GEPGLOBCOOP>.Enumerator PCMIGKPBKCL;

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x4672130", Offset = "0x4670930", VA = "0x184672130", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public (TKey Key, TValue Value, int RefCount) NEPDGMBEJHL
		{
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x46726F0", Offset = "0x4670EF0", VA = "0x1846726F0", Slot = "4")]
			get
			{
				return default((TKey, TValue, int));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x4672270", Offset = "0x4670A70", VA = "0x184672270")]
		public KNGLAHLGIIG(CLCIPLDHMAD<TKey, TValue> BGEPJDBLALA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x4671CE0", Offset = "0x46704E0", VA = "0x184671CE0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x4671DA0", Offset = "0x46705A0", VA = "0x184671DA0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x4671F30", Offset = "0x4670730", VA = "0x184671F30", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private sealed class PEIEPBIMACG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public CLCIPLDHMAD<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public TKey key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public GEPGLOBCOOP refCountedValue;

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public PEIEPBIMACG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x4C30650", Offset = "0x4C2EE50", VA = "0x184C30650")]
		internal void CMIGMNOBGBO()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private readonly Dictionary<TKey, GEPGLOBCOOP> NJNNOCEHKLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly Func<TKey, TValue>? CCGPHJIPFGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private readonly Action<TValue>? MDBJIKCLJDI;

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x59346C0", Offset = "0x5932EC0", VA = "0x1859346C0")]
	public CLCIPLDHMAD(int MIEHFACIEHL = 0, [Optional] IEqualityComparer<TKey>? NDICNLPGKMA, [Optional] Func<TKey, TValue>? KNOKIEFBIKD, [Optional] Action<TValue>? BBHFPFNLKEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x5932DC0", Offset = "0x59315C0", VA = "0x185932DC0")]
	public DPGJMAFIAMJ<TValue> FPMCBLLCGJK(TKey KCGKBDGKIOP, [Optional] Func<TKey, TValue>? PONFGODFOKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x5933C20", Offset = "0x5932420", VA = "0x185933C20")]
	private void JGKHHIOHILA(TKey KCGKBDGKIOP, GEPGLOBCOOP JPCGFHJJGJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x5933E70", Offset = "0x5932670", VA = "0x185933E70")]
	public void PFJBPCIOPEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x5933A90", Offset = "0x5932290", VA = "0x185933A90")]
	public KNGLAHLGIIG IGEPHCDGPEC()
	{
		return default(KNGLAHLGIIG);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x59344F0", Offset = "0x5932CF0", VA = "0x1859344F0", Slot = "4")]
	private IEnumerator<(TKey, TValue, int)> System.Collections.Generic.IEnumerable<(TKeyKey,TValueValue,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x59344F0", Offset = "0x5932CF0", VA = "0x1859344F0", Slot = "5")]
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
