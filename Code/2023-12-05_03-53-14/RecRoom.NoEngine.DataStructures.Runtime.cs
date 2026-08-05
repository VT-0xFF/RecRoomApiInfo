using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x79B610", Offset = "0x79AA10", VA = "0x18079B610")]
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
		[Cpp2IlInjected.Address(RVA = "0x5E93E80", Offset = "0x5E93280", VA = "0x185E93E80")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x79C170", Offset = "0x79B570", VA = "0x18079C170")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x79C1B0", Offset = "0x79B5B0", VA = "0x18079C1B0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class NMLIJLAHPJC
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	protected NMLIJLAHPJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class FFAONFMDJEC<T> : NMLIJLAHPJC
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	protected struct IGFAFFAIBPE
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public enum PFJIBPNHJDI
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
		public PFJIBPNHJDI LFLAEPCPMDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public T ONCLGAMIHNG;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private int EMMJBEDLKOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool JNGALKIGKCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	protected readonly bool EHPCDPHKLPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	protected List<T>? PDLIFBCDHGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<IGFAFFAIBPE>? LOKHMAEMHLM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool IJEGHAKKAGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x34629D0", Offset = "0x3461DD0", VA = "0x1834629D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x34632B0", Offset = "0x34626B0", VA = "0x1834632B0")]
	protected FFAONFMDJEC(bool EHPCDPHKLPH, bool JNGALKIGKCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3463210", Offset = "0x3462610", VA = "0x183463210")]
	protected bool OKFGCECFIBK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3463110", Offset = "0x3462510", VA = "0x183463110")]
	protected void NKENIIIDAOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3462C00", Offset = "0x3462000", VA = "0x183462C00")]
	protected void ELMMFKFAOHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2E2BB70", Offset = "0x2E2AF70", VA = "0x182E2BB70")]
	private static void GDNIJGCMFMP<U>(List<U>? HAPGAOAPCEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3462A20", Offset = "0x3461E20", VA = "0x183462A20", Slot = "4")]
	public void BKKEPFPDOJH(T ONCLGAMIHNG, bool NHEKGMBGOLE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3462DE0", Offset = "0x34621E0", VA = "0x183462DE0", Slot = "5")]
	public void HBMDGHADMGB(T ONCLGAMIHNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3462F90", Offset = "0x3462390", VA = "0x183462F90")]
	public void ILNOFIHDCKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface KOIFHENFCJB
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BKKEPFPDOJH(Action ONCLGAMIHNG, bool NHEKGMBGOLE = false);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HBMDGHADMGB(Action ONCLGAMIHNG);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class FCJKIAIKOOM : FFAONFMDJEC<Action>, KOIFHENFCJB
{
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5E921E0", Offset = "0x5E915E0", VA = "0x185E921E0")]
	public FCJKIAIKOOM(bool EHPCDPHKLPH = false, bool JNGALKIGKCC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5E91FE0", Offset = "0x5E913E0", VA = "0x185E91FE0")]
	public void ONBNGEINIKI()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5E91F20", Offset = "0x5E91320", VA = "0x185E91F20")]
	public static FCJKIAIKOOM EHMNDHCEEPM(FCJKIAIKOOM JNCEFHNMODP, Action ONCLGAMIHNG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5E91F80", Offset = "0x5E91380", VA = "0x185E91F80")]
	public static FCJKIAIKOOM HNODHDMLJNN(FCJKIAIKOOM JNCEFHNMODP, Action ONCLGAMIHNG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface DCFBJELDMDC<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BKKEPFPDOJH(Action<T> ONCLGAMIHNG, bool NHEKGMBGOLE = false);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HBMDGHADMGB(Action<T> ONCLGAMIHNG);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public sealed class CFBCANLCDFG<T> : FFAONFMDJEC<Action<T>>, DCFBJELDMDC<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x352BD60", Offset = "0x352B160", VA = "0x18352BD60")]
	public CFBCANLCDFG(bool EHPCDPHKLPH = false, bool JNGALKIGKCC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x48062F0", Offset = "0x48056F0", VA = "0x1848062F0")]
	public void ONBNGEINIKI(T AINBOEMJDAE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x355A110", Offset = "0x3559510", VA = "0x18355A110")]
	public static CFBCANLCDFG<T> EHMNDHCEEPM(CFBCANLCDFG<T> JNCEFHNMODP, Action<T> ONCLGAMIHNG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x355A1A0", Offset = "0x35595A0", VA = "0x18355A1A0")]
	public static CFBCANLCDFG<T> HNODHDMLJNN(CFBCANLCDFG<T> JNCEFHNMODP, Action<T> ONCLGAMIHNG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface OLOMJJMGOMK<T, U> where T : notnull where U : notnull
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class HHJEIKBAAJF<T, U> : FFAONFMDJEC<Action<T, U>>, OLOMJJMGOMK<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x352BD60", Offset = "0x352B160", VA = "0x18352BD60")]
	public HHJEIKBAAJF(bool EHPCDPHKLPH = false, bool JNGALKIGKCC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x35F8FD0", Offset = "0x35F83D0", VA = "0x1835F8FD0")]
	public void ONBNGEINIKI(T AINBOEMJDAE, U OJAHNNLBPHJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x355A110", Offset = "0x3559510", VA = "0x18355A110")]
	public static HHJEIKBAAJF<T, U> EHMNDHCEEPM(HHJEIKBAAJF<T, U> JNCEFHNMODP, Action<T, U> ONCLGAMIHNG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x355A1A0", Offset = "0x35595A0", VA = "0x18355A1A0")]
	public static HHJEIKBAAJF<T, U> HNODHDMLJNN(HHJEIKBAAJF<T, U> JNCEFHNMODP, Action<T, U> ONCLGAMIHNG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class MKFPLDNDPJC<T, U, V> : FFAONFMDJEC<Action<T, U, V>> where T : notnull where U : notnull where V : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x352BD60", Offset = "0x352B160", VA = "0x18352BD60")]
	public MKFPLDNDPJC(bool EHPCDPHKLPH = false, bool JNGALKIGKCC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3CCC2C0", Offset = "0x3CCB6C0", VA = "0x183CCC2C0")]
	public void ONBNGEINIKI(T AINBOEMJDAE, U OJAHNNLBPHJ, V JEEPLNLHGDO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x355A110", Offset = "0x3559510", VA = "0x18355A110")]
	public static MKFPLDNDPJC<T, U, V> EHMNDHCEEPM(MKFPLDNDPJC<T, U, V> JNCEFHNMODP, Action<T, U, V> ONCLGAMIHNG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x355A1A0", Offset = "0x35595A0", VA = "0x18355A1A0")]
	public static MKFPLDNDPJC<T, U, V> HNODHDMLJNN(MKFPLDNDPJC<T, U, V> JNCEFHNMODP, Action<T, U, V> ONCLGAMIHNG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface IEOOPFMKFKP<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class LJOCJHMBDOA<T, U, V, W> : FFAONFMDJEC<Action<T, U, V, W>>, IEOOPFMKFKP<T, U, V, W> where T : notnull where U : notnull where V : notnull where W : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x352BD60", Offset = "0x352B160", VA = "0x18352BD60")]
	public LJOCJHMBDOA(bool EHPCDPHKLPH = false, bool JNGALKIGKCC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3A9C1F0", Offset = "0x3A9B5F0", VA = "0x183A9C1F0")]
	public void ONBNGEINIKI(T AINBOEMJDAE, U OJAHNNLBPHJ, V JEEPLNLHGDO, W IKENEDAFBLJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x355A110", Offset = "0x3559510", VA = "0x18355A110")]
	public static LJOCJHMBDOA<T, U, V, W> EHMNDHCEEPM(LJOCJHMBDOA<T, U, V, W> JNCEFHNMODP, Action<T, U, V, W> ONCLGAMIHNG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x355A1A0", Offset = "0x35595A0", VA = "0x18355A1A0")]
	public static LJOCJHMBDOA<T, U, V, W> HNODHDMLJNN(LJOCJHMBDOA<T, U, V, W> JNCEFHNMODP, Action<T, U, V, W> ONCLGAMIHNG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class AGOLPMCJDAN<T, U, V, W, X> : FFAONFMDJEC<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x352BD60", Offset = "0x352B160", VA = "0x18352BD60")]
	public AGOLPMCJDAN(bool EHPCDPHKLPH = false, bool JNGALKIGKCC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x355A230", Offset = "0x3559630", VA = "0x18355A230")]
	public void ONBNGEINIKI(T AINBOEMJDAE, U OJAHNNLBPHJ, V JEEPLNLHGDO, W IKENEDAFBLJ, X OPHKAEHAFCM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x355A110", Offset = "0x3559510", VA = "0x18355A110")]
	public static AGOLPMCJDAN<T, U, V, W, X> EHMNDHCEEPM(AGOLPMCJDAN<T, U, V, W, X> JNCEFHNMODP, Action<T, U, V, W, X> ONCLGAMIHNG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x355A1A0", Offset = "0x35595A0", VA = "0x18355A1A0")]
	public static AGOLPMCJDAN<T, U, V, W, X> HNODHDMLJNN(AGOLPMCJDAN<T, U, V, W, X> JNCEFHNMODP, Action<T, U, V, W, X> ONCLGAMIHNG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class JJAMGCILBBJ<T, U, V, W, X, Y> : FFAONFMDJEC<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x352BD60", Offset = "0x352B160", VA = "0x18352BD60")]
	public JJAMGCILBBJ(bool EHPCDPHKLPH = false, bool JNGALKIGKCC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3900830", Offset = "0x38FFC30", VA = "0x183900830")]
	public void ONBNGEINIKI(T AINBOEMJDAE, U OJAHNNLBPHJ, V JEEPLNLHGDO, W IKENEDAFBLJ, X OPHKAEHAFCM, Y CLGLFIMLHLG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x355A110", Offset = "0x3559510", VA = "0x18355A110")]
	public static JJAMGCILBBJ<T, U, V, W, X, Y> EHMNDHCEEPM(JJAMGCILBBJ<T, U, V, W, X, Y> JNCEFHNMODP, Action<T, U, V, W, X, Y> ONCLGAMIHNG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x355A1A0", Offset = "0x35595A0", VA = "0x18355A1A0")]
	public static JJAMGCILBBJ<T, U, V, W, X, Y> HNODHDMLJNN(JJAMGCILBBJ<T, U, V, W, X, Y> JNCEFHNMODP, Action<T, U, V, W, X, Y> ONCLGAMIHNG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class AFMFHCKIJME<TKey, TVal> where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly PFHIIKDLFKF<TKey, TVal> IJNLAABEOAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly Dictionary<TKey, (TVal value, int size)> IAIKENDOEHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly int FJCFPJLAMKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly PFHIIKDLFKF<TKey, TVal>.KHGEMMGKPAC? AFODKDLIOIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private int KFDGCJBFACB;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal int BELEGCFENPP
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3559E60", Offset = "0x3559260", VA = "0x183559E60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int CGFFPDNHFCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x896580", Offset = "0x895980", VA = "0x180896580")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3559EB0", Offset = "0x35592B0", VA = "0x183559EB0")]
	public AFMFHCKIJME(int FJCFPJLAMKO, [Optional] PFHIIKDLFKF<TKey, TVal>.KHGEMMGKPAC? AFODKDLIOIH, [Optional] IEqualityComparer<TKey>? ODLNOKIOIEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3559A40", Offset = "0x3558E40", VA = "0x183559A40")]
	public void JBGMCBLNFLD(TKey MIMFBLPNKOG, TVal NMENOOMOOJP, bool PIFKGCKKCCK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x35599A0", Offset = "0x3558DA0", VA = "0x1835599A0")]
	public bool GDOHHJFBJKJ(TKey MIMFBLPNKOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x35596A0", Offset = "0x3558AA0", VA = "0x1835596A0")]
	public bool AFCHMNEGHNL(TKey NGGIFCJNAHC, [Out] TVal NMENOOMOOJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3559780", Offset = "0x3558B80", VA = "0x183559780")]
	private void FHBBFMBENAA(TKey MIMFBLPNKOG, TVal NMENOOMOOJP, int PEGIIHFIAHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3559C10", Offset = "0x3559010", VA = "0x183559C10")]
	public bool LHKNKJAHFFJ(TKey MIMFBLPNKOG, TVal NMENOOMOOJP, bool PIFKGCKKCCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3559DA0", Offset = "0x35591A0", VA = "0x183559DA0")]
	private bool NANKAGKMLDM(TKey MIMFBLPNKOG)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
public readonly struct EOJHLDCAFED : IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public readonly struct NBBPEDMICMN : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7BA6E0", VA = "0x1807BB2E0")]
		public static NBBPEDMICMN PBDMNAJCIOP()
		{
			return default(NBBPEDMICMN);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7BA6E0", VA = "0x1807BB2E0")]
	public static EOJHLDCAFED OFLNOBBDGFA(Type LFLAEPCPMDG, [Optional] string? CFKIICBEILF, [Optional] string? KHFKACOCIPP, bool FNGMFEAPMPD = false)
	{
		return default(EOJHLDCAFED);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7BA6E0", VA = "0x1807BB2E0")]
	public static EOJHLDCAFED OFLNOBBDGFA<T>([Optional] string? CFKIICBEILF, [Optional] string? KHFKACOCIPP, bool FNGMFEAPMPD = false)
	{
		return default(EOJHLDCAFED);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct JGFJPPAAAPI
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public delegate bool ANEJHOCLIEO(string MIJAKIJPFOO, JGFJPPAAAPI FIEPOENHCPL);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public int PNHGPNJINIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public string GJBKICBGHDF;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5E926F0", Offset = "0x5E91AF0", VA = "0x185E926F0")]
	public static Dictionary<string, JGFJPPAAAPI> ACDPIPBJLJL(Type EOJNCJPELFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5E92A20", Offset = "0x5E91E20", VA = "0x185E92A20")]
	public static Dictionary<string, JGFJPPAAAPI> FBOHGHMALDK(Type EOJNCJPELFD, ANEJHOCLIEO PAIJOIHPKCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5E92F10", Offset = "0x5E92310", VA = "0x185E92F10")]
	public static Dictionary<int, string> GFBPNOCFPBP(Dictionary<string, JGFJPPAAAPI> HFLNDIDMJFD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[AttributeUsage(AttributeTargets.Enum)]
public abstract class OHDDOIODODA : PreserveAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string CDGLHMLMIMK(string HPOCFKLBOCM);

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x781100", Offset = "0x780500", VA = "0x180781100")]
	protected OHDDOIODODA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public abstract class CKLCFGGMCDD : MLDPNJCMKGI
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public static bool EEJLHAIMCJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly string? PMEEPAHKJLG;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public virtual MLDPNJCMKGI? BFELCPMOINL
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x772DC0", Offset = "0x7721C0", VA = "0x180772DC0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5E91770", Offset = "0x5E90B70", VA = "0x185E91770")]
	protected CKLCFGGMCDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string KHDKMLPELIF();

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5E91280", Offset = "0x5E90680", VA = "0x185E91280", Slot = "8")]
	public virtual string NGCHPAOPEPM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5E91360", Offset = "0x5E90760", VA = "0x185E91360", Slot = "9")]
	public void OBODOIKNNON(StringBuilder EPCOKKKGDLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5E91300", Offset = "0x5E90700", VA = "0x185E91300", Slot = "10")]
	public void NLCFMCCMEHL(StringBuilder EPCOKKKGDLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5E91160", Offset = "0x5E90560", VA = "0x185E91160", Slot = "11")]
	public void LGGFINIJLDA(StringBuilder EPCOKKKGDLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5E91610", Offset = "0x5E90A10", VA = "0x185E91610", Slot = "12")]
	public void OMBNBKILJNC(StringBuilder EPCOKKKGDLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5E910C0", Offset = "0x5E904C0", VA = "0x185E910C0")]
	public static void KLFGDHIMOHB(StringBuilder EPCOKKKGDLF, string NADJOGPFAND, string NOFDPIGDGDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x51D3FE0", Offset = "0x51D33E0", VA = "0x1851D3FE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class FPPLLKOFFNP : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5E92590", Offset = "0x5E91990", VA = "0x185E92590")]
	public FPPLLKOFFNP(string KCFFPPIEBHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class GBOIBAOEPBG<TErr> : FPPLLKOFFNP where TErr : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly TErr JBGILKIJDAK;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x35248C0", Offset = "0x3523CC0", VA = "0x1835248C0")]
	private GBOIBAOEPBG([In] TErr OIMLEIJKDPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x35247F0", Offset = "0x3523BF0", VA = "0x1835247F0")]
	public static GBOIBAOEPBG<TErr> PBDMNAJCIOP([In] TErr OIMLEIJKDPB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface MLDPNJCMKGI
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string NGCHPAOPEPM();

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string KHDKMLPELIF();
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface NHELDJDFIBJ<out TOptions> where TOptions : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	TOptions ILNPCEAPFCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface PHABCIIAOFO
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	string IMEHFGDIKLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class IGKNDCOFHIP : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5E92690", Offset = "0x5E91A90", VA = "0x185E92690")]
	public IGKNDCOFHIP(string KCFFPPIEBHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class IPCBOIPFOBI<TOk> : IGKNDCOFHIP where TOk : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly TOk FOHKNAEBDEB;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x376E250", Offset = "0x376D650", VA = "0x18376E250")]
	private IPCBOIPFOBI([In] TOk LNPBFFMMNAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x376DFA0", Offset = "0x376D3A0", VA = "0x18376DFA0")]
	public static IPCBOIPFOBI<TOk> PBDMNAJCIOP([In] TOk LNPBFFMMNAG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public readonly struct EFPDAHOJLMO<TOk, TErr> : IEquatable<EFPDAHOJLMO<TOk, TErr>> where TOk : notnull where TErr : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private static readonly EqualityComparer<TErr> LAPCFMOLJBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	internal readonly TErr JBGILKIJDAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal readonly TOk FOHKNAEBDEB;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool JAGBAGNHAAC
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x30EC180", Offset = "0x30EB580", VA = "0x1830EC180")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool GCOONHNJENK
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x30EBD00", Offset = "0x30EB100", VA = "0x1830EBD00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x30F29F0", Offset = "0x30F1DF0", VA = "0x1830F29F0")]
	internal EFPDAHOJLMO([In] TErr OIMLEIJKDPB, [In] TOk LNPBFFMMNAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x30EFB70", Offset = "0x30EEF70", VA = "0x1830EFB70")]
	public static EFPDAHOJLMO<TOk, TErr> MIHDOOEEEOM([In] TErr OIMLEIJKDPB)
	{
		return default(EFPDAHOJLMO<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x30F0400", Offset = "0x30EF800", VA = "0x1830F0400")]
	public static EFPDAHOJLMO<TOk, TErr> OPOAPDLMKBO([In] TOk LNPBFFMMNAG)
	{
		return default(EFPDAHOJLMO<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2E2A100", Offset = "0x2E29500", VA = "0x182E2A100")]
	public EFPDAHOJLMO<TOk?, UErr?> LENMJLLIIFB<UErr>()
	{
		return default(EFPDAHOJLMO<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2E2A5D0", Offset = "0x2E299D0", VA = "0x182E2A5D0")]
	public EFPDAHOJLMO<UOk?, TErr?> NMOHLCLBDED<UOk>()
	{
		return default(EFPDAHOJLMO<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2E2AF30", Offset = "0x2E2A330", VA = "0x182E2AF30")]
	public EFPDAHOJLMO<UOk?, TErr?> PDCAHJHDAFP<UOk>()
	{
		return default(EFPDAHOJLMO<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2E29B20", Offset = "0x2E28F20", VA = "0x182E29B20")]
	public EFPDAHOJLMO<TOk?, UErr?> FIPGHKKEJNL<UErr>()
	{
		return default(EFPDAHOJLMO<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x30EF4D0", Offset = "0x30EE8D0", VA = "0x1830EF4D0")]
	public EFPDAHOJLMO<CPIOBHNHOJN, TErr> IMNGPEMMFEM()
	{
		return default(EFPDAHOJLMO<CPIOBHNHOJN, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x30EDFE0", Offset = "0x30ED3E0", VA = "0x1830EDFE0")]
	public static bool FCHDBNDMOOD([In] EFPDAHOJLMO<TOk, TErr> OJKFAPKLEMA, [In] EFPDAHOJLMO<TOk, TErr> BBHLJNIGCPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x30ECE60", Offset = "0x30EC260", VA = "0x1830ECE60", Slot = "4")]
	public bool Equals(EFPDAHOJLMO<TOk, TErr> LFMLAKDHEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x30EC780", Offset = "0x30EBB80", VA = "0x1830EC780", Slot = "0")]
	public override bool Equals(object LFMLAKDHEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x30EEFC0", Offset = "0x30EE3C0", VA = "0x1830EEFC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x30F0FD0", Offset = "0x30F03D0", VA = "0x1830F0FD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class MPJPPHCKGLF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private struct GCLAGHANMIF<TOk, TErr> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public AsyncTaskMethodBuilder<TOk> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public Task<EFPDAHOJLMO<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private TaskAwaiter<EFPDAHOJLMO<TOk, TErr>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x352A550", Offset = "0x3529950", VA = "0x18352A550", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x352AEB0", Offset = "0x352A2B0", VA = "0x18352AEB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class JPMDPCFJLNG<TOk, TErr> : IEnumerable<TOk>, IEnumerable, IEnumerator<TOk>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private TOk <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private IEnumerable<EFPDAHOJLMO<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public IEnumerable<EFPDAHOJLMO<TOk, TErr>> <>3__self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private IEnumerator<EFPDAHOJLMO<TOk, TErr>> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		TOk? IEnumerator<TOk>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return (TOk?)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8ECB00", Offset = "0x8EBF00", VA = "0x1808ECB00")]
		[DebuggerHidden]
		public JPMDPCFJLNG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x33C5DB0", Offset = "0x33C51B0", VA = "0x1833C5DB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x391F730", Offset = "0x391EB30", VA = "0x18391F730", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x391FA60", Offset = "0x391EE60", VA = "0x18391FA60")]
		private void OEJNKOJDKLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x391FB70", Offset = "0x391EF70", VA = "0x18391FB70", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x391FAB0", Offset = "0x391EEB0", VA = "0x18391FAB0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TOk?>? IEnumerable<TOk>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x33CB230", Offset = "0x33CA630", VA = "0x1833CB230", Slot = "5")]
		[DebuggerHidden]
		IEnumerator? IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x25ABEF0", Offset = "0x25AB2F0", VA = "0x1825ABEF0")]
	public static EFPDAHOJLMO<TOk?, TErr?> FOHKNAEBDEB<TOk, TErr>([In] this EFPDAHOJLMO<TOk, TErr> EAODMOEAJOC, [In] TOk LNPBFFMMNAG)
	{
		return default(EFPDAHOJLMO<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x25ABFC0", Offset = "0x25AB3C0", VA = "0x1825ABFC0")]
	public static EFPDAHOJLMO<CPIOBHNHOJN, TErr?> FOHKNAEBDEB<TErr>([In] this EFPDAHOJLMO<CPIOBHNHOJN, TErr> EAODMOEAJOC)
	{
		return default(EFPDAHOJLMO<CPIOBHNHOJN, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x25ABEF0", Offset = "0x25AB2F0", VA = "0x1825ABEF0")]
	public static EFPDAHOJLMO<TOk?, TErr?> JBGILKIJDAK<TOk, TErr>([In] this EFPDAHOJLMO<TOk, TErr> EAODMOEAJOC, [In] TErr OIMLEIJKDPB)
	{
		return default(EFPDAHOJLMO<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x25AC310", Offset = "0x25AB710", VA = "0x1825AC310")]
	public static TOk? GIFDMHBAMJP<TOk, TErr>([In] this EFPDAHOJLMO<TOk, TErr> EAODMOEAJOC)
	{
		return (TOk?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x25AC540", Offset = "0x25AB940", VA = "0x1825AC540")]
	[AsyncStateMachine(typeof(GCLAGHANMIF<, >))]
	public static Task<TOk?>? IEBAIHFBNLM<TOk, TErr>(this Task<EFPDAHOJLMO<TOk, TErr>> EAODMOEAJOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x25AD380", Offset = "0x25AC780", VA = "0x1825AD380")]
	public static TErr? MFAPFDMAMJM<TErr, TOk>([In] this EFPDAHOJLMO<TOk, TErr> EAODMOEAJOC)
	{
		return (TErr?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x25AB220", Offset = "0x25AA620", VA = "0x1825AB220")]
	public static bool BJAFPBFMKIC<TOk, TErr, UErr, UOk>([In] this EFPDAHOJLMO<TOk, TErr> EAODMOEAJOC, [Out] EFPDAHOJLMO<UOk, UErr> EKECIOADHED) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x25AD770", Offset = "0x25ACB70", VA = "0x1825AD770")]
	public static bool POILACOLNFL<TOk, TErr>([In] this EFPDAHOJLMO<TOk, TErr> EAODMOEAJOC, [Out][NotNullWhen(true)] TOk LNPBFFMMNAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x25AD590", Offset = "0x25AC990", VA = "0x1825AD590")]
	public static bool NNLJHFOPFIH<TOk, TErr>([In] this EFPDAHOJLMO<TOk, TErr> EAODMOEAJOC, [Out][NotNullWhen(true)] TErr OIMLEIJKDPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x25ACB20", Offset = "0x25ABF20", VA = "0x1825ACB20")]
	public static bool IMCKJFNLNIM<TOk, TErr>([In] this EFPDAHOJLMO<TOk, TErr> EAODMOEAJOC, [Out][NotNullWhen(true)] TOk LNPBFFMMNAG, [Out][NotNullWhen(false)] TErr OIMLEIJKDPB) where TOk : notnull where TErr : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x25AD670", Offset = "0x25ACA70", VA = "0x1825AD670")]
	public static bool OKHEMKHPJJE<TOk, TErr>([In] this EFPDAHOJLMO<TOk, TErr> EAODMOEAJOC, [Out][NotNullWhen(true)] TOk LNPBFFMMNAG, [Out] EFPDAHOJLMO<TOk, TErr> EKECIOADHED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x25AB450", Offset = "0x25AA850", VA = "0x1825AB450")]
	public static bool BJAFPBFMKIC<TOk, TErr, UErr, UOk>([In] this EFPDAHOJLMO<TOk, TErr> EAODMOEAJOC, [Out][NotNullWhen(true)] TOk LNPBFFMMNAG, [Out] EFPDAHOJLMO<UOk, UErr> EKECIOADHED) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x25AAFA0", Offset = "0x25AA3A0", VA = "0x1825AAFA0")]
	public static bool AIOGIKEFLCF<TOk, TErr>([In] this EFPDAHOJLMO<TOk, TErr> EAODMOEAJOC, [Out][NotNullWhen(true)] TOk LNPBFFMMNAG, [Out] EFPDAHOJLMO<CPIOBHNHOJN, TErr> EKECIOADHED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x25ACE40", Offset = "0x25AC240", VA = "0x1825ACE40")]
	public static EFPDAHOJLMO<UOk, UErr> LMJKFJJFJPN<UOk, UErr, TOk, TErr>([In] this EFPDAHOJLMO<TOk, TErr> EAODMOEAJOC, [In] EFPDAHOJLMO<UOk, UErr> FPOCHAEKMIE) where TOk : UOk where TErr : UErr
	{
		return default(EFPDAHOJLMO<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x25AC7E0", Offset = "0x25ABBE0", VA = "0x1825AC7E0")]
	public static EFPDAHOJLMO<TOk?[]?, TErr?> IFEJCOEEGHM<TOk, TErr>(this IEnumerable<EFPDAHOJLMO<TOk, TErr>> EAODMOEAJOC)
	{
		return default(EFPDAHOJLMO<TOk[], TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x2347200", Offset = "0x2346600", VA = "0x182347200")]
	[IteratorStateMachine(typeof(JPMDPCFJLNG<, >))]
	public static IEnumerable<TOk?>? ABEGPELOBHD<TOk, TErr>(this IEnumerable<EFPDAHOJLMO<TOk, TErr>> EAODMOEAJOC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class FFFBKPKNFBK<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x2E2BBF0", Offset = "0x2E2AFF0", VA = "0x182E2BBF0")]
	public static EFPDAHOJLMO<TOk, T> FOHKNAEBDEB<TOk>([In] TOk LNPBFFMMNAG) where TOk : notnull
	{
		return default(EFPDAHOJLMO<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3464A20", Offset = "0x3463E20", VA = "0x183464A20")]
	public static EFPDAHOJLMO<CPIOBHNHOJN, T> FOHKNAEBDEB()
	{
		return default(EFPDAHOJLMO<CPIOBHNHOJN, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x2E2BBF0", Offset = "0x2E2AFF0", VA = "0x182E2BBF0")]
	public static EFPDAHOJLMO<T, TErr> JBGILKIJDAK<TErr>([In] TErr OIMLEIJKDPB) where TErr : notnull
	{
		return default(EFPDAHOJLMO<T, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[DefaultMember("Item")]
public sealed class BPLKPPEEMEJ<T> : IEnumerable<T>, IEnumerable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	private readonly struct NPKLDHNPEJH : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly BPLKPPEEMEJ<T> NKCPJPHPCKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly int KPDDHGOBJBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly bool BLNEPADEJOJ;

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x1BE3D20", Offset = "0x1BE3120", VA = "0x181BE3D20")]
		public NPKLDHNPEJH(BPLKPPEEMEJ<T> KAAAMIPABJJ, int ANLDOMENFNF, bool GADPMHIKPIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x3D38EF0", Offset = "0x3D382F0", VA = "0x183D38EF0")]
		public BPLKPPEEMEJ<T>.FOFPMCCJNFP HMFAGAOEPDF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x3D38FE0", Offset = "0x3D383E0", VA = "0x183D38FE0", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x3D38FE0", Offset = "0x3D383E0", VA = "0x183D38FE0", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public sealed class FOFPMCCJNFP : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private readonly BPLKPPEEMEJ<T> NKCPJPHPCKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private readonly int HGBHIOKFLHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private int BHDGBODGAEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private readonly bool BLNEPADEJOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private bool FNLKDILOPOJ;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public T ADHFGEBEBLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x347D030", Offset = "0x347C430", VA = "0x18347D030")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x347D220", Offset = "0x347C620", VA = "0x18347D220", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x347D460", Offset = "0x347C860", VA = "0x18347D460", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x347D9F0", Offset = "0x347CDF0", VA = "0x18347D9F0")]
		public FOFPMCCJNFP(BPLKPPEEMEJ<T> KAAAMIPABJJ, int ANLDOMENFNF, bool GADPMHIKPIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x347D070", Offset = "0x347C470", VA = "0x18347D070", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x347D100", Offset = "0x347C500", VA = "0x18347D100", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class FGINDAFFHNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public FGINDAFFHNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x3468C00", Offset = "0x3468000", VA = "0x183468C00")]
		internal T GIDILCEAPKA(int _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly T[] PNLFFNMLKIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private int BHDGBODGAEC;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int DPINIMKONNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x458DA60", Offset = "0x458CE60", VA = "0x18458DA60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public T ADHFGEBEBLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x3437DD0", Offset = "0x34371D0", VA = "0x183437DD0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public T JGBDDJFAKIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x458DA00", Offset = "0x458CE00", VA = "0x18458DA00")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public T BPKONBPIDNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x458DB90", Offset = "0x458CF90", VA = "0x18458DB90")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int NAHNDBFADBN
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x15DE770", Offset = "0x15DDB70", VA = "0x1815DE770")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0xEBAC50", Offset = "0xEBA050", VA = "0x180EBAC50")]
	private static int AEODHHCKODN(int DIENMHDGFGP, int HKIFHAEDDHO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x458DDA0", Offset = "0x458D1A0", VA = "0x18458DDA0")]
	public BPLKPPEEMEJ(int PEGIIHFIAHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x458DE10", Offset = "0x458D210", VA = "0x18458DE10")]
	public BPLKPPEEMEJ(int PEGIIHFIAHP, Func<T> LHGJJBKLHAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x458E0D0", Offset = "0x458D4D0", VA = "0x18458E0D0")]
	public BPLKPPEEMEJ(T[] JAAOHPHONMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x458DA30", Offset = "0x458CE30", VA = "0x18458DA30")]
	public void CCIBHIGJLCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x458DC40", Offset = "0x458D040", VA = "0x18458DC40")]
	public IEnumerable<T> KKJJFDBFKDA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x458DAB0", Offset = "0x458CEB0", VA = "0x18458DAB0")]
	public BPLKPPEEMEJ<T>.FOFPMCCJNFP HMFAGAOEPDF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x3442420", Offset = "0x3441820", VA = "0x183442420", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3442420", Offset = "0x3441820", VA = "0x183442420", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public static class EDEPNLOGPLL
{
	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x23B8BA0", Offset = "0x23B7FA0", VA = "0x1823B8BA0")]
	public static BPLKPPEEMEJ<T> PBDMNAJCIOP<T>(int PEGIIHFIAHP, Func<T> LHGJJBKLHAA) where T : notnull
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
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private const float kEpsilon = 1E-05f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public float r;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public float g;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public float b;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public float a;

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x1CC5CC0", Offset = "0x1CC50C0", VA = "0x181CC5CC0")]
		public RRColor(float BCPCCCLDBKN, float EKGAMFAEBGC, float MLKGDIFPGGI, float JMHOJIPAIMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x5E93FB0", Offset = "0x5E933B0", VA = "0x185E93FB0", Slot = "4")]
		public bool Equals(RRColor LFMLAKDHEFO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x5E94030", Offset = "0x5E93430", VA = "0x185E94030", Slot = "0")]
		public override bool Equals(object LFMLAKDHEFO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x5E94130", Offset = "0x5E93530", VA = "0x185E94130", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x5E941B0", Offset = "0x5E935B0", VA = "0x185E941B0", Slot = "5")]
		public string ToString(string GIAELHONAOK, IFormatProvider JFCBHOOPEIO)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public sealed class OMMJNDDNFDL<TData> : CKLCFGGMCDD where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly string DGGOMFECFGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly TData CEKPCFBCLAM;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850", Slot = "7")]
	public override string KHDKMLPELIF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x3E18ED0", Offset = "0x3E182D0", VA = "0x183E18ED0")]
	internal OMMJNDDNFDL(string KCFFPPIEBHH, [In] TData KKOACPFFAML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class FHNIICAMPIP
{
	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x5E92510", Offset = "0x5E91910", VA = "0x185E92510")]
	public static OMMJNDDNFDL<CPIOBHNHOJN> PBDMNAJCIOP(string KCFFPPIEBHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x2332170", Offset = "0x2331570", VA = "0x182332170")]
	public static OMMJNDDNFDL<TData> PBDMNAJCIOP<TData>(string KCFFPPIEBHH, [In] TData KKOACPFFAML) where TData : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class DPGMDLPADOG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly Dictionary<object, float> MJJMEPPKPMG;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float PNPCMNHIMDK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8710E0", Offset = "0x8704E0", VA = "0x1808710E0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x871180", Offset = "0x870580", VA = "0x180871180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x5E91850", Offset = "0x5E90C50", VA = "0x185E91850")]
	public void KAFAPEAADGC(float NMENOOMOOJP, object NOEAHPPKHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x5E917E0", Offset = "0x5E90BE0", VA = "0x185E917E0")]
	public void DADDPKGOCCP(object NOEAHPPKHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x5E918C0", Offset = "0x5E90CC0", VA = "0x185E918C0")]
	private void MMFENIFJBDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x5E919F0", Offset = "0x5E90DF0", VA = "0x185E919F0")]
	public DPGMDLPADOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public sealed class HNKCHOLMMMA<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class OOLAINPEDGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public OOLAINPEDGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x3E1D170", Offset = "0x3E1C570", VA = "0x183E1D170")]
		internal int GPDMFPPFABA(int i, T token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private HashSet<T>? BJDILCBNPMC;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public IReadOnlyCollection<T> IAIGJIGPPGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x361C3C0", Offset = "0x361B7C0", VA = "0x18361C3C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool ECGMHLLIGMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x361C0B0", Offset = "0x361B4B0", VA = "0x18361C0B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int AEFHJLMLIJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x770C30", Offset = "0x770030", VA = "0x180770C30")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x77ABA0", Offset = "0x779FA0", VA = "0x18077ABA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x361C0F0", Offset = "0x361B4F0", VA = "0x18361C0F0")]
	public bool BKKEPFPDOJH(T NOEAHPPKHNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x361C2A0", Offset = "0x361B6A0", VA = "0x18361C2A0")]
	public bool HBMDGHADMGB(T NOEAHPPKHNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x361C260", Offset = "0x361B660", VA = "0x18361C260")]
	public bool CCJBPIIMLHG(T NOEAHPPKHNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x361C3F0", Offset = "0x361B7F0", VA = "0x18361C3F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public HNKCHOLMMMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public class JHKAELLEKMH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly string HCOHMNKJFFG;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x77CC90", Offset = "0x77C090", VA = "0x18077CC90")]
	public JHKAELLEKMH(string HCOHMNKJFFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x5E939F0", Offset = "0x5E92DF0", VA = "0x185E939F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public sealed class EFHEONJKJKH
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private sealed class POAHKPPOCLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public POAHKPPOCLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x5E93F00", Offset = "0x5E93300", VA = "0x185E93F00")]
		internal int GPDMFPPFABA(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private HashSet<object>? BJDILCBNPMC;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public IReadOnlyCollection<object> IAIGJIGPPGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x5E91CE0", Offset = "0x5E910E0", VA = "0x185E91CE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool ECGMHLLIGMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x5E91A80", Offset = "0x5E90E80", VA = "0x185E91A80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public int AEFHJLMLIJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x770C30", Offset = "0x770030", VA = "0x180770C30")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x77ABA0", Offset = "0x779FA0", VA = "0x18077ABA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x5E91A90", Offset = "0x5E90E90", VA = "0x185E91A90")]
	public bool BKKEPFPDOJH(object NOEAHPPKHNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x5E91BD0", Offset = "0x5E90FD0", VA = "0x185E91BD0")]
	public bool HBMDGHADMGB(object NOEAHPPKHNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5E91B70", Offset = "0x5E90F70", VA = "0x185E91B70")]
	public bool CCJBPIIMLHG(object NOEAHPPKHNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5E91C70", Offset = "0x5E91070", VA = "0x185E91C70")]
	public void OFHIPKKHFGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5E91D70", Offset = "0x5E91170", VA = "0x185E91D70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public EFHEONJKJKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class CPFKHKPFLOI<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private struct HOAILAEFEGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public float FEMKAMBIIKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public T ILNPCEAPFCH;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly Dictionary<object, HOAILAEFEGO> MJJMEPPKPMG;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public virtual T ILKHLHGGGDG
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0xDF9B30", Offset = "0xDF8F30", VA = "0x180DF9B30", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0xDF8580", Offset = "0xDF7980", VA = "0x180DF8580", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public object? FKKCIKFNGCH
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x773AC0", Offset = "0x772EC0", VA = "0x180773AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x77A180", Offset = "0x779580", VA = "0x18077A180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public bool OEJIBJJBPAI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x49D9FD0", Offset = "0x49D93D0", VA = "0x1849D9FD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x49DA580", Offset = "0x49D9980", VA = "0x1849DA580")]
	public bool KAFAPEAADGC(T NMENOOMOOJP, object NOEAHPPKHNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x3D30930", Offset = "0x3D2FD30", VA = "0x183D30930")]
	public bool DADDPKGOCCP(object NOEAHPPKHNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x49DA020", Offset = "0x49D9420", VA = "0x1849DA020")]
	public void ILNOFIHDCKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x49D9CB0", Offset = "0x49D90B0", VA = "0x1849D9CB0")]
	public bool AFCHMNEGHNL(object NOEAHPPKHNC, [Out] T NMENOOMOOJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x49DABA0", Offset = "0x49D9FA0", VA = "0x1849DABA0")]
	[FHEEPLFHPDM("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool KLIPCFOONOC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x49DBE50", Offset = "0x49DB250", VA = "0x1849DBE50")]
	public CPFKHKPFLOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface NJBNGAGMBGJ
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event ADEEFCLAPAP GABFPEABAID;
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class JHBFJHOGKGD : NJBNGAGMBGJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public readonly struct FGHDPMGDHHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public readonly float MBHHAMKDCLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public readonly float DGNONMCIIPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		internal readonly bool ECMFHABJICO;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float DIHNPGKKGFH
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x5E92240", Offset = "0x5E91640", VA = "0x185E92240")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x5E923B0", Offset = "0x5E917B0", VA = "0x185E923B0")]
		public FGHDPMGDHHO(float DFOEGCCLIEM, float CBMPBFEPCHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x5E92250", Offset = "0x5E91650", VA = "0x185E92250", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class HPPOJPAHFOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public JHBFJHOGKGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public HPPOJPAHFOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x5E925F0", Offset = "0x5E919F0", VA = "0x185E925F0")]
		internal void EKPNKNMPFLA(float innerProgress)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly int EKJEIMGCNCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private int JIPGLBJEGPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly NJBNGAGMBGJ[] BNOKHPFFGAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly ADEEFCLAPAP[] MNLFLOOOFMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly FGHDPMGDHHO[] ABMBECFJHNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private FGHDPMGDHHO OAOMIACIEDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private readonly JKPHFFJEKJC EFNONHMFDDI;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event ADEEFCLAPAP GABFPEABAID
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x5E930D0", Offset = "0x5E924D0", VA = "0x185E930D0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x5E93190", Offset = "0x5E92590", VA = "0x185E93190", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5E93860", Offset = "0x5E92C60", VA = "0x185E93860")]
	public JHBFJHOGKGD(int EKJEIMGCNCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5E93360", Offset = "0x5E92760", VA = "0x185E93360")]
	public JKPHFFJEKJC EDOBPMJKEFM(FGHDPMGDHHO KPDNJGBDHCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x5E933F0", Offset = "0x5E927F0", VA = "0x185E933F0")]
	public void FOPEEGGBAKG(NJBNGAGMBGJ DJGEGECLOOG, [Optional] FGHDPMGDHHO MNBDHEMPDHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5E93250", Offset = "0x5E92650", VA = "0x185E93250", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public delegate void ADEEFCLAPAP(float IFNEGJEKLJC);
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class JIAAKOIMLLF
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private class MELMPAJOKBP : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private readonly NJBNGAGMBGJ LOINEFDGIPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private readonly ADEEFCLAPAP PDECDCHNHMC;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x5E93DF0", Offset = "0x5E931F0", VA = "0x185E93DF0")]
		public MELMPAJOKBP(NJBNGAGMBGJ LOINEFDGIPC, ADEEFCLAPAP PDECDCHNHMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x5E93DA0", Offset = "0x5E931A0", VA = "0x185E93DA0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x5E93A40", Offset = "0x5E92E40", VA = "0x185E93A40")]
	internal static bool CGKCLJPBKNG(float JMHOJIPAIMC, float MLKGDIFPGGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x5E86870", Offset = "0x5E85C70", VA = "0x185E86870")]
	internal static float DLGBOGKIPEI(float JMHOJIPAIMC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x5E93AB0", Offset = "0x5E92EB0", VA = "0x185E93AB0")]
	public static IDisposable JEKOJHIHPDG(this NJBNGAGMBGJ LOINEFDGIPC, ADEEFCLAPAP PDECDCHNHMC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class JKPHFFJEKJC : NJBNGAGMBGJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private float IFNEGJEKLJC;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public float EKCDOIECAKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x5E93CB0", Offset = "0x5E930B0", VA = "0x185E93CB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event ADEEFCLAPAP? GABFPEABAID
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x5E93B70", Offset = "0x5E92F70", VA = "0x185E93B70", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x5E93C10", Offset = "0x5E93010", VA = "0x185E93C10", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public JKPHFFJEKJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class MLHMEDNDBFB : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x5A099B0", Offset = "0x5A08DB0", VA = "0x185A099B0")]
	public MLHMEDNDBFB(string KCFFPPIEBHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[DefaultMember("Item")]
public class DLHEPFMCLKJ<TKey, TValue> : LKILEELBOGD<TKey, TValue>, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, LMEOJAIMNMD where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class CENGEBBJANG : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private KeyValuePair<TKey, TValue> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public DLHEPFMCLKJ<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private IEnumerator<KeyValuePair<TKey, TValue>> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		KeyValuePair<TKey, TValue> IEnumerator<KeyValuePair<TKey, TValue>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0xDF9B30", Offset = "0xDF8F30", VA = "0x180DF9B30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TValue>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x472CA10", Offset = "0x472BE10", VA = "0x18472CA10", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x77C2A0", Offset = "0x77B6A0", VA = "0x18077C2A0")]
		[DebuggerHidden]
		public CENGEBBJANG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x33CB9E0", Offset = "0x33CADE0", VA = "0x1833CB9E0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x472BCF0", Offset = "0x472B0F0", VA = "0x18472BCF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x472C8D0", Offset = "0x472BCD0", VA = "0x18472C8D0")]
		private void OEJNKOJDKLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x472BCA0", Offset = "0x472B0A0", VA = "0x18472BCA0")]
		private void AHMEHKPBADP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x472C920", Offset = "0x472BD20", VA = "0x18472C920", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly LKILEELBOGD<TKey, TValue> PJGHEFAECMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly IDictionary<TKey, TValue> LBMOEPHIFMD;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int AEFHJLMLIJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x4DE2C40", Offset = "0x4DE2040", VA = "0x184DE2C40", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool AHEALAJHHIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7BA6E0", VA = "0x1807BB2E0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public TValue BPKONBPIDNA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x4DE2D10", Offset = "0x4DE2110", VA = "0x184DE2D10", Slot = "4")]
		get
		{
			return (TValue)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x4DE2FA0", Offset = "0x4DE23A0", VA = "0x184DE2FA0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public ICollection<TKey> LAIPAOGLJAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x4DE2D80", Offset = "0x4DE2180", VA = "0x184DE2D80", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public ICollection<TValue> CAKFANLNPIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x4DE2E90", Offset = "0x4DE2290", VA = "0x184DE2E90", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x4DE29F0", Offset = "0x4DE1DF0", VA = "0x184DE29F0")]
	public DLHEPFMCLKJ(LKILEELBOGD<TKey, TValue> PJGHEFAECMK, [Optional] IDictionary<TKey, TValue>? LBMOEPHIFMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x4DE02E0", Offset = "0x4DDF6E0", VA = "0x184DE02E0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x4DE0290", Offset = "0x4DDF690", VA = "0x184DE0290")]
	public void CALCLNCNOND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x4DDFF20", Offset = "0x4DDF320", VA = "0x184DDFF20", Slot = "9")]
	public void Add(TKey MIMFBLPNKOG, TValue NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x4DE0C60", Offset = "0x4DE0060", VA = "0x184DE0C60")]
	public void FMFPNKJMEGE(TKey MIMFBLPNKOG, TValue NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x4DE0EE0", Offset = "0x4DE02E0", VA = "0x184DE0EE0")]
	public void GBKLBJKHDEA(TKey MIMFBLPNKOG, TValue NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x4DE1300", Offset = "0x4DE0700", VA = "0x184DE1300")]
	public void HHAJMEJKBDB(TKey MIMFBLPNKOG, TValue NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x4DE1700", Offset = "0x4DE0B00", VA = "0x184DE1700")]
	public void HPLEIHNGMJL(TKey MIMFBLPNKOG, TValue NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x4DE2030", Offset = "0x4DE1430", VA = "0x184DE2030", Slot = "14")]
	void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> EDPLJLLHNEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x4DE2210", Offset = "0x4DE1610", VA = "0x184DE2210", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> EDPLJLLHNEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x4DE2570", Offset = "0x4DE1970", VA = "0x184DE2570", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> EDPLJLLHNEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x4DE0350", Offset = "0x4DDF750", VA = "0x184DE0350", Slot = "8")]
	public bool ContainsKey(TKey MIMFBLPNKOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x4DE1CD0", Offset = "0x4DE10D0", VA = "0x184DE1CD0")]
	public bool MLEONNFAMNI(TKey MIMFBLPNKOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x4DE1BA0", Offset = "0x4DE0FA0", VA = "0x184DE1BA0")]
	public bool KOOOLACEJPE(TKey MIMFBLPNKOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x4DE1E60", Offset = "0x4DE1260", VA = "0x184DE1E60", Slot = "10")]
	public bool Remove(TKey MIMFBLPNKOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x4DE2760", Offset = "0x4DE1B60", VA = "0x184DE2760", Slot = "11")]
	public bool TryGetValue(TKey MIMFBLPNKOG, [Out] TValue NMENOOMOOJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x4DE06F0", Offset = "0x4DDFAF0", VA = "0x184DE06F0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TValue>[] NCABOBFFNFK, int EKDLGEADDMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x4DE2730", Offset = "0x4DE1B30", VA = "0x184DE2730", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x4DE1120", Offset = "0x4DE0520", VA = "0x184DE1120", Slot = "19")]
	[IteratorStateMachine(typeof(DLHEPFMCLKJ<, >.CENGEBBJANG))]
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x4DE1840", Offset = "0x4DE0C40", VA = "0x184DE1840", Slot = "21")]
	public bool IHFIPJJMBFF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x4DE1A40", Offset = "0x4DE0E40", VA = "0x184DE1A40")]
	private TValue JGKDGNBMGPI(TKey MIMFBLPNKOG)
	{
		return (TValue)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public interface LMEOJAIMNMD
{
	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IHFIPJJMBFF();
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface LKILEELBOGD<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, LMEOJAIMNMD
{
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
[DefaultMember("Item")]
public sealed class PFHIIKDLFKF<TKey, TVal> : LKILEELBOGD<TKey, TVal>, IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, LMEOJAIMNMD where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public delegate int KHGEMMGKPAC(TKey MIMFBLPNKOG, TVal NMENOOMOOJP);

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private class MCNAIOINLOB
	{
		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public TKey BOGLOOJGMOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0xB18F40", Offset = "0xB18340", VA = "0x180B18F40")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public TVal ILNPCEAPFCH
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x896580", Offset = "0x895980", VA = "0x180896580")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x896590", Offset = "0x895990", VA = "0x180896590")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public int DIHNPGKKGFH
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x7B2310", Offset = "0x7B1710", VA = "0x1807B2310")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x7B1970", Offset = "0x7B0D70", VA = "0x1807B1970")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public DateTimeOffset KIEEKHANPOB
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x9FCA80", Offset = "0x9FBE80", VA = "0x1809FCA80")]
			[CompilerGenerated]
			get
			{
				return default(DateTimeOffset);
			}
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x1226A40", Offset = "0x1225E40", VA = "0x181226A40")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x3C9F4C0", Offset = "0x3C9E8C0", VA = "0x183C9F4C0")]
		public MCNAIOINLOB(TKey MIMFBLPNKOG, TVal OKHKFFGCACL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class JLFNKKABHLN : IEnumerator<KeyValuePair<TKey, TVal>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private KeyValuePair<TKey, TVal> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public PFHIIKDLFKF<TKey, TVal> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private LinkedList<MCNAIOINLOB>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		KeyValuePair<TKey, TVal> IEnumerator<KeyValuePair<TKey, TVal>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0xDF9B30", Offset = "0xDF8F30", VA = "0x180DF9B30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TVal>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x390A670", Offset = "0x3909A70", VA = "0x18390A670", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x77C2A0", Offset = "0x77B6A0", VA = "0x18077C2A0")]
		[DebuggerHidden]
		public JLFNKKABHLN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x33C5DB0", Offset = "0x33C51B0", VA = "0x1833C5DB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x3908150", Offset = "0x3907550", VA = "0x183908150", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x390A170", Offset = "0x3909570", VA = "0x18390A170")]
		private void OEJNKOJDKLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x390A620", Offset = "0x3909A20", VA = "0x18390A620", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public const int DCIIDKPGNLK = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly Dictionary<TKey, LinkedListNode<MCNAIOINLOB>> LCODPGHFDLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly LinkedList<MCNAIOINLOB> ACELOBMJLPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly KHGEMMGKPAC? AFODKDLIOIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly TimeSpan PFOAAGGMJMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly HFJCPICEHAL HOAPOIEFGNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private bool LKKHEMOGLCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly List<TKey> JCCDLHDAOEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly List<TVal> ICNBLONGBOH;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public int CGFFPDNHFCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x78F4E0", Offset = "0x78E8E0", VA = "0x18078F4E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	internal int BELEGCFENPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x78F4F0", Offset = "0x78E8F0", VA = "0x18078F4F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0xDE9C20", Offset = "0xDE9020", VA = "0x180DE9C20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public int AEFHJLMLIJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x3ED4C30", Offset = "0x3ED4030", VA = "0x183ED4C30", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	internal int BCBKHLEFBID
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x30E5F40", Offset = "0x30E5340", VA = "0x1830E5F40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public ICollection<TVal> CAKFANLNPIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x3ED4D60", Offset = "0x3ED4160", VA = "0x183ED4D60", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	ICollection<TKey> IDictionary<TKey, TVal>.AKBHKCLLIML
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x3ED2600", Offset = "0x3ED1A00", VA = "0x183ED2600", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool AHEALAJHHIM
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7BA6E0", VA = "0x1807BB2E0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public TVal BPKONBPIDNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x3ED4C90", Offset = "0x3ED4090", VA = "0x183ED4C90", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x3ED4DB0", Offset = "0x3ED41B0", VA = "0x183ED4DB0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x3ECC940", Offset = "0x3ECBD40", VA = "0x183ECC940")]
	private bool GEOMPJIKGND(int EKJEIMGCNCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x3ED1780", Offset = "0x3ED0B80", VA = "0x183ED1780")]
	private void PNIDBDDIHGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x3ED3930", Offset = "0x3ED2D30", VA = "0x183ED3930")]
	public PFHIIKDLFKF(int EKJEIMGCNCB, [Optional] KHGEMMGKPAC? AFODKDLIOIH, [Optional] IEqualityComparer<TKey>? ODLNOKIOIEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x3ED3430", Offset = "0x3ED2830", VA = "0x183ED3430")]
	public PFHIIKDLFKF(TimeSpan PFOAAGGMJMN, [Optional] IEqualityComparer<TKey>? ODLNOKIOIEG, [Optional] HFJCPICEHAL? HOAPOIEFGNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x3ED2F30", Offset = "0x3ED2330", VA = "0x183ED2F30")]
	public PFHIIKDLFKF(int EKJEIMGCNCB, TimeSpan PFOAAGGMJMN, [Optional] IEqualityComparer<TKey>? ODLNOKIOIEG, [Optional] HFJCPICEHAL? HOAPOIEFGNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x3ED46B0", Offset = "0x3ED3AB0", VA = "0x183ED46B0")]
	public PFHIIKDLFKF(int EKJEIMGCNCB, KHGEMMGKPAC? AFODKDLIOIH, TimeSpan PFOAAGGMJMN, [Optional] IEqualityComparer<TKey>? ODLNOKIOIEG, [Optional] HFJCPICEHAL? HOAPOIEFGNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x3ECF870", Offset = "0x3ECEC70", VA = "0x183ECF870", Slot = "21")]
	public bool IHFIPJJMBFF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x3ECBF90", Offset = "0x3ECB390", VA = "0x183ECBF90", Slot = "22")]
	public bool EAEKDGPNGFG(int PEGIIHFIAHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x3ECD710", Offset = "0x3ECCB10", VA = "0x183ECD710")]
	private bool HAIMAEFCJPC(int PEGIIHFIAHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x3ECF3D0", Offset = "0x3ECE7D0", VA = "0x183ECF3D0")]
	public void HPDCNGOHBJP(TKey MIMFBLPNKOG, TVal NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x3ECA540", Offset = "0x3EC9940", VA = "0x183ECA540", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> EDPLJLLHNEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x3ECA720", Offset = "0x3EC9B20", VA = "0x183ECA720", Slot = "9")]
	public void Add(TKey MIMFBLPNKOG, TVal NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x3ECAAD0", Offset = "0x3EC9ED0", VA = "0x183ECAAD0", Slot = "8")]
	public bool ContainsKey(TKey MIMFBLPNKOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x3ED1FC0", Offset = "0x3ED13C0", VA = "0x183ED1FC0", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Contains(KeyValuePair<TKey, TVal> EDPLJLLHNEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x3ED1CD0", Offset = "0x3ED10D0", VA = "0x183ED1CD0", Slot = "10")]
	public bool Remove(TKey MIMFBLPNKOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x3ED2280", Offset = "0x3ED1680", VA = "0x183ED2280", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Remove(KeyValuePair<TKey, TVal> EDPLJLLHNEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x3ECF8E0", Offset = "0x3ECECE0", VA = "0x183ECF8E0")]
	private bool JDNPPFNHIOL(TKey MIMFBLPNKOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x3ECC750", Offset = "0x3ECBB50", VA = "0x183ECC750")]
	private TVal EHGHEBAOCHM(TKey NGGIFCJNAHC)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x3ED2D70", Offset = "0x3ED2170", VA = "0x183ED2D70", Slot = "11")]
	public bool TryGetValue(TKey NGGIFCJNAHC, [Out] TVal NMENOOMOOJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x3ECA990", Offset = "0x3EC9D90", VA = "0x183ECA990", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x3ECAF20", Offset = "0x3ECA320", VA = "0x183ECAF20", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] NCABOBFFNFK, int EKDLGEADDMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x3ED0590", Offset = "0x3ECF990", VA = "0x183ED0590")]
	private bool JKDGKPNABJL(MCNAIOINLOB IFBIJHJINAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x3ECE560", Offset = "0x3ECD960", VA = "0x183ECE560")]
	private void HEPKCBICNKK(LinkedListNode<MCNAIOINLOB> OMEGIHLLCPL, TVal HHMFGBLJOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x3ED0710", Offset = "0x3ECFB10", VA = "0x183ED0710")]
	private void KAFAPEAADGC(TKey MIMFBLPNKOG, TVal NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x3ECD110", Offset = "0x3ECC510", VA = "0x183ECD110")]
	private void GNECFMHIOBO(MCNAIOINLOB IFBIJHJINAE, TVal HHMFGBLJOPM, int KPPJFIPBECF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x3ECD5F0", Offset = "0x3ECC9F0", VA = "0x183ECD5F0", Slot = "19")]
	[IteratorStateMachine(typeof(PFHIIKDLFKF<, >.JLFNKKABHLN))]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x3ED2630", Offset = "0x3ED1A30", VA = "0x183ED2630", Slot = "20")]
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
