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
		[Cpp2IlInjected.Address(RVA = "0x5E93F60", Offset = "0x5E93360", VA = "0x185E93F60")]
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
		[Cpp2IlInjected.Address(RVA = "0x3461280", Offset = "0x3460680", VA = "0x183461280")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3461B60", Offset = "0x3460F60", VA = "0x183461B60")]
	protected FFAONFMDJEC(bool EHPCDPHKLPH, bool JNGALKIGKCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3461AC0", Offset = "0x3460EC0", VA = "0x183461AC0")]
	protected bool OKFGCECFIBK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x34619C0", Offset = "0x3460DC0", VA = "0x1834619C0")]
	protected void NKENIIIDAOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x34614B0", Offset = "0x34608B0", VA = "0x1834614B0")]
	protected void ELMMFKFAOHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2E2BAE0", Offset = "0x2E2AEE0", VA = "0x182E2BAE0")]
	private static void GDNIJGCMFMP<U>(List<U>? HAPGAOAPCEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x34612D0", Offset = "0x34606D0", VA = "0x1834612D0", Slot = "4")]
	public void BKKEPFPDOJH(T ONCLGAMIHNG, bool NHEKGMBGOLE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3461690", Offset = "0x3460A90", VA = "0x183461690", Slot = "5")]
	public void HBMDGHADMGB(T ONCLGAMIHNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3461840", Offset = "0x3460C40", VA = "0x183461840")]
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
	[Cpp2IlInjected.Address(RVA = "0x5E922C0", Offset = "0x5E916C0", VA = "0x185E922C0")]
	public FCJKIAIKOOM(bool EHPCDPHKLPH = false, bool JNGALKIGKCC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5E920C0", Offset = "0x5E914C0", VA = "0x185E920C0")]
	public void ONBNGEINIKI()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5E92000", Offset = "0x5E91400", VA = "0x185E92000")]
	public static FCJKIAIKOOM EHMNDHCEEPM(FCJKIAIKOOM JNCEFHNMODP, Action ONCLGAMIHNG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5E92060", Offset = "0x5E91460", VA = "0x185E92060")]
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
	[Cpp2IlInjected.Address(RVA = "0x352A670", Offset = "0x3529A70", VA = "0x18352A670")]
	public CFBCANLCDFG(bool EHPCDPHKLPH = false, bool JNGALKIGKCC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4804ED0", Offset = "0x48042D0", VA = "0x184804ED0")]
	public void ONBNGEINIKI(T AINBOEMJDAE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x355C670", Offset = "0x355BA70", VA = "0x18355C670")]
	public static CFBCANLCDFG<T> EHMNDHCEEPM(CFBCANLCDFG<T> JNCEFHNMODP, Action<T> ONCLGAMIHNG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x355C700", Offset = "0x355BB00", VA = "0x18355C700")]
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
	[Cpp2IlInjected.Address(RVA = "0x352A670", Offset = "0x3529A70", VA = "0x18352A670")]
	public HHJEIKBAAJF(bool EHPCDPHKLPH = false, bool JNGALKIGKCC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x35F79C0", Offset = "0x35F6DC0", VA = "0x1835F79C0")]
	public void ONBNGEINIKI(T AINBOEMJDAE, U OJAHNNLBPHJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x355C670", Offset = "0x355BA70", VA = "0x18355C670")]
	public static HHJEIKBAAJF<T, U> EHMNDHCEEPM(HHJEIKBAAJF<T, U> JNCEFHNMODP, Action<T, U> ONCLGAMIHNG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x355C700", Offset = "0x355BB00", VA = "0x18355C700")]
	public static HHJEIKBAAJF<T, U> HNODHDMLJNN(HHJEIKBAAJF<T, U> JNCEFHNMODP, Action<T, U> ONCLGAMIHNG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class MKFPLDNDPJC<T, U, V> : FFAONFMDJEC<Action<T, U, V>> where T : notnull where U : notnull where V : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x352A670", Offset = "0x3529A70", VA = "0x18352A670")]
	public MKFPLDNDPJC(bool EHPCDPHKLPH = false, bool JNGALKIGKCC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3CCAE20", Offset = "0x3CCA220", VA = "0x183CCAE20")]
	public void ONBNGEINIKI(T AINBOEMJDAE, U OJAHNNLBPHJ, V JEEPLNLHGDO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x355C670", Offset = "0x355BA70", VA = "0x18355C670")]
	public static MKFPLDNDPJC<T, U, V> EHMNDHCEEPM(MKFPLDNDPJC<T, U, V> JNCEFHNMODP, Action<T, U, V> ONCLGAMIHNG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x355C700", Offset = "0x355BB00", VA = "0x18355C700")]
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
	[Cpp2IlInjected.Address(RVA = "0x352A670", Offset = "0x3529A70", VA = "0x18352A670")]
	public LJOCJHMBDOA(bool EHPCDPHKLPH = false, bool JNGALKIGKCC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3A9AD80", Offset = "0x3A9A180", VA = "0x183A9AD80")]
	public void ONBNGEINIKI(T AINBOEMJDAE, U OJAHNNLBPHJ, V JEEPLNLHGDO, W IKENEDAFBLJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x355C670", Offset = "0x355BA70", VA = "0x18355C670")]
	public static LJOCJHMBDOA<T, U, V, W> EHMNDHCEEPM(LJOCJHMBDOA<T, U, V, W> JNCEFHNMODP, Action<T, U, V, W> ONCLGAMIHNG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x355C700", Offset = "0x355BB00", VA = "0x18355C700")]
	public static LJOCJHMBDOA<T, U, V, W> HNODHDMLJNN(LJOCJHMBDOA<T, U, V, W> JNCEFHNMODP, Action<T, U, V, W> ONCLGAMIHNG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class AGOLPMCJDAN<T, U, V, W, X> : FFAONFMDJEC<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x352A670", Offset = "0x3529A70", VA = "0x18352A670")]
	public AGOLPMCJDAN(bool EHPCDPHKLPH = false, bool JNGALKIGKCC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x355C790", Offset = "0x355BB90", VA = "0x18355C790")]
	public void ONBNGEINIKI(T AINBOEMJDAE, U OJAHNNLBPHJ, V JEEPLNLHGDO, W IKENEDAFBLJ, X OPHKAEHAFCM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x355C670", Offset = "0x355BA70", VA = "0x18355C670")]
	public static AGOLPMCJDAN<T, U, V, W, X> EHMNDHCEEPM(AGOLPMCJDAN<T, U, V, W, X> JNCEFHNMODP, Action<T, U, V, W, X> ONCLGAMIHNG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x355C700", Offset = "0x355BB00", VA = "0x18355C700")]
	public static AGOLPMCJDAN<T, U, V, W, X> HNODHDMLJNN(AGOLPMCJDAN<T, U, V, W, X> JNCEFHNMODP, Action<T, U, V, W, X> ONCLGAMIHNG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class JJAMGCILBBJ<T, U, V, W, X, Y> : FFAONFMDJEC<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x352A670", Offset = "0x3529A70", VA = "0x18352A670")]
	public JJAMGCILBBJ(bool EHPCDPHKLPH = false, bool JNGALKIGKCC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x38FF280", Offset = "0x38FE680", VA = "0x1838FF280")]
	public void ONBNGEINIKI(T AINBOEMJDAE, U OJAHNNLBPHJ, V JEEPLNLHGDO, W IKENEDAFBLJ, X OPHKAEHAFCM, Y CLGLFIMLHLG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x355C670", Offset = "0x355BA70", VA = "0x18355C670")]
	public static JJAMGCILBBJ<T, U, V, W, X, Y> EHMNDHCEEPM(JJAMGCILBBJ<T, U, V, W, X, Y> JNCEFHNMODP, Action<T, U, V, W, X, Y> ONCLGAMIHNG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x355C700", Offset = "0x355BB00", VA = "0x18355C700")]
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
		[Cpp2IlInjected.Address(RVA = "0x355C3C0", Offset = "0x355B7C0", VA = "0x18355C3C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int CGFFPDNHFCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x896540", Offset = "0x895940", VA = "0x180896540")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x355C410", Offset = "0x355B810", VA = "0x18355C410")]
	public AFMFHCKIJME(int FJCFPJLAMKO, [Optional] PFHIIKDLFKF<TKey, TVal>.KHGEMMGKPAC? AFODKDLIOIH, [Optional] IEqualityComparer<TKey>? ODLNOKIOIEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x355BFA0", Offset = "0x355B3A0", VA = "0x18355BFA0")]
	public void JBGMCBLNFLD(TKey MIMFBLPNKOG, TVal NMENOOMOOJP, bool PIFKGCKKCCK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x355BF00", Offset = "0x355B300", VA = "0x18355BF00")]
	public bool GDOHHJFBJKJ(TKey MIMFBLPNKOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x355BC00", Offset = "0x355B000", VA = "0x18355BC00")]
	public bool AFCHMNEGHNL(TKey NGGIFCJNAHC, [Out] TVal NMENOOMOOJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x355BCE0", Offset = "0x355B0E0", VA = "0x18355BCE0")]
	private void FHBBFMBENAA(TKey MIMFBLPNKOG, TVal NMENOOMOOJP, int PEGIIHFIAHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x355C170", Offset = "0x355B570", VA = "0x18355C170")]
	public bool LHKNKJAHFFJ(TKey MIMFBLPNKOG, TVal NMENOOMOOJP, bool PIFKGCKKCCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x355C300", Offset = "0x355B700", VA = "0x18355C300")]
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
	[Cpp2IlInjected.Address(RVA = "0x5E927D0", Offset = "0x5E91BD0", VA = "0x185E927D0")]
	public static Dictionary<string, JGFJPPAAAPI> ACDPIPBJLJL(Type EOJNCJPELFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5E92B00", Offset = "0x5E91F00", VA = "0x185E92B00")]
	public static Dictionary<string, JGFJPPAAAPI> FBOHGHMALDK(Type EOJNCJPELFD, ANEJHOCLIEO PAIJOIHPKCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5E92FF0", Offset = "0x5E923F0", VA = "0x185E92FF0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5E91850", Offset = "0x5E90C50", VA = "0x185E91850")]
	protected CKLCFGGMCDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string KHDKMLPELIF();

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5E91360", Offset = "0x5E90760", VA = "0x185E91360", Slot = "8")]
	public virtual string NGCHPAOPEPM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5E91440", Offset = "0x5E90840", VA = "0x185E91440", Slot = "9")]
	public void OBODOIKNNON(StringBuilder EPCOKKKGDLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5E913E0", Offset = "0x5E907E0", VA = "0x185E913E0", Slot = "10")]
	public void NLCFMCCMEHL(StringBuilder EPCOKKKGDLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5E91240", Offset = "0x5E90640", VA = "0x185E91240", Slot = "11")]
	public void LGGFINIJLDA(StringBuilder EPCOKKKGDLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5E916F0", Offset = "0x5E90AF0", VA = "0x185E916F0", Slot = "12")]
	public void OMBNBKILJNC(StringBuilder EPCOKKKGDLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5E911A0", Offset = "0x5E905A0", VA = "0x185E911A0")]
	public static void KLFGDHIMOHB(StringBuilder EPCOKKKGDLF, string NADJOGPFAND, string NOFDPIGDGDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x51D40C0", Offset = "0x51D34C0", VA = "0x1851D40C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class FPPLLKOFFNP : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5E92670", Offset = "0x5E91A70", VA = "0x185E92670")]
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
	[Cpp2IlInjected.Address(RVA = "0x35231D0", Offset = "0x35225D0", VA = "0x1835231D0")]
	private GBOIBAOEPBG([In] TErr OIMLEIJKDPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x3523100", Offset = "0x3522500", VA = "0x183523100")]
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
	[Cpp2IlInjected.Address(RVA = "0x5E92770", Offset = "0x5E91B70", VA = "0x185E92770")]
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
	[Cpp2IlInjected.Address(RVA = "0x376CCA0", Offset = "0x376C0A0", VA = "0x18376CCA0")]
	private IPCBOIPFOBI([In] TOk LNPBFFMMNAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x376C9F0", Offset = "0x376BDF0", VA = "0x18376C9F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x30EC0F0", Offset = "0x30EB4F0", VA = "0x1830EC0F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool GCOONHNJENK
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x30EBC70", Offset = "0x30EB070", VA = "0x1830EBC70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x30F2960", Offset = "0x30F1D60", VA = "0x1830F2960")]
	internal EFPDAHOJLMO([In] TErr OIMLEIJKDPB, [In] TOk LNPBFFMMNAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x30EFAE0", Offset = "0x30EEEE0", VA = "0x1830EFAE0")]
	public static EFPDAHOJLMO<TOk, TErr> MIHDOOEEEOM([In] TErr OIMLEIJKDPB)
	{
		return default(EFPDAHOJLMO<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x30F0370", Offset = "0x30EF770", VA = "0x1830F0370")]
	public static EFPDAHOJLMO<TOk, TErr> OPOAPDLMKBO([In] TOk LNPBFFMMNAG)
	{
		return default(EFPDAHOJLMO<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2E2A070", Offset = "0x2E29470", VA = "0x182E2A070")]
	public EFPDAHOJLMO<TOk?, UErr?> LENMJLLIIFB<UErr>()
	{
		return default(EFPDAHOJLMO<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2E2A540", Offset = "0x2E29940", VA = "0x182E2A540")]
	public EFPDAHOJLMO<UOk?, TErr?> NMOHLCLBDED<UOk>()
	{
		return default(EFPDAHOJLMO<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2E2AEA0", Offset = "0x2E2A2A0", VA = "0x182E2AEA0")]
	public EFPDAHOJLMO<UOk?, TErr?> PDCAHJHDAFP<UOk>()
	{
		return default(EFPDAHOJLMO<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2E29A90", Offset = "0x2E28E90", VA = "0x182E29A90")]
	public EFPDAHOJLMO<TOk?, UErr?> FIPGHKKEJNL<UErr>()
	{
		return default(EFPDAHOJLMO<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x30EF440", Offset = "0x30EE840", VA = "0x1830EF440")]
	public EFPDAHOJLMO<CPIOBHNHOJN, TErr> IMNGPEMMFEM()
	{
		return default(EFPDAHOJLMO<CPIOBHNHOJN, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x30EDF50", Offset = "0x30ED350", VA = "0x1830EDF50")]
	public static bool FCHDBNDMOOD([In] EFPDAHOJLMO<TOk, TErr> OJKFAPKLEMA, [In] EFPDAHOJLMO<TOk, TErr> BBHLJNIGCPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x30ECDD0", Offset = "0x30EC1D0", VA = "0x1830ECDD0", Slot = "4")]
	public bool Equals(EFPDAHOJLMO<TOk, TErr> LFMLAKDHEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x30EC6F0", Offset = "0x30EBAF0", VA = "0x1830EC6F0", Slot = "0")]
	public override bool Equals(object LFMLAKDHEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x30EEF30", Offset = "0x30EE330", VA = "0x1830EEF30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x30F0F40", Offset = "0x30F0340", VA = "0x1830F0F40", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x3528E60", Offset = "0x3528260", VA = "0x183528E60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x35297C0", Offset = "0x3528BC0", VA = "0x1835297C0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x8ECA50", Offset = "0x8EBE50", VA = "0x1808ECA50")]
		[DebuggerHidden]
		public JPMDPCFJLNG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x33C5C80", Offset = "0x33C5080", VA = "0x1833C5C80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x391E240", Offset = "0x391D640", VA = "0x18391E240", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x391E570", Offset = "0x391D970", VA = "0x18391E570")]
		private void OEJNKOJDKLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x391E680", Offset = "0x391DA80", VA = "0x18391E680", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x391E5C0", Offset = "0x391D9C0", VA = "0x18391E5C0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TOk?>? IEnumerable<TOk>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x33CB100", Offset = "0x33CA500", VA = "0x1833CB100", Slot = "5")]
		[DebuggerHidden]
		IEnumerator? IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x25ABE60", Offset = "0x25AB260", VA = "0x1825ABE60")]
	public static EFPDAHOJLMO<TOk?, TErr?> FOHKNAEBDEB<TOk, TErr>([In] this EFPDAHOJLMO<TOk, TErr> EAODMOEAJOC, [In] TOk LNPBFFMMNAG)
	{
		return default(EFPDAHOJLMO<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x25ABF30", Offset = "0x25AB330", VA = "0x1825ABF30")]
	public static EFPDAHOJLMO<CPIOBHNHOJN, TErr?> FOHKNAEBDEB<TErr>([In] this EFPDAHOJLMO<CPIOBHNHOJN, TErr> EAODMOEAJOC)
	{
		return default(EFPDAHOJLMO<CPIOBHNHOJN, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x25ABE60", Offset = "0x25AB260", VA = "0x1825ABE60")]
	public static EFPDAHOJLMO<TOk?, TErr?> JBGILKIJDAK<TOk, TErr>([In] this EFPDAHOJLMO<TOk, TErr> EAODMOEAJOC, [In] TErr OIMLEIJKDPB)
	{
		return default(EFPDAHOJLMO<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x25AC280", Offset = "0x25AB680", VA = "0x1825AC280")]
	public static TOk? GIFDMHBAMJP<TOk, TErr>([In] this EFPDAHOJLMO<TOk, TErr> EAODMOEAJOC)
	{
		return (TOk?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x25AC4B0", Offset = "0x25AB8B0", VA = "0x1825AC4B0")]
	[AsyncStateMachine(typeof(GCLAGHANMIF<, >))]
	public static Task<TOk?>? IEBAIHFBNLM<TOk, TErr>(this Task<EFPDAHOJLMO<TOk, TErr>> EAODMOEAJOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x25AD2F0", Offset = "0x25AC6F0", VA = "0x1825AD2F0")]
	public static TErr? MFAPFDMAMJM<TErr, TOk>([In] this EFPDAHOJLMO<TOk, TErr> EAODMOEAJOC)
	{
		return (TErr?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x25AB190", Offset = "0x25AA590", VA = "0x1825AB190")]
	public static bool BJAFPBFMKIC<TOk, TErr, UErr, UOk>([In] this EFPDAHOJLMO<TOk, TErr> EAODMOEAJOC, [Out] EFPDAHOJLMO<UOk, UErr> EKECIOADHED) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x25AD6E0", Offset = "0x25ACAE0", VA = "0x1825AD6E0")]
	public static bool POILACOLNFL<TOk, TErr>([In] this EFPDAHOJLMO<TOk, TErr> EAODMOEAJOC, [Out][NotNullWhen(true)] TOk LNPBFFMMNAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x25AD500", Offset = "0x25AC900", VA = "0x1825AD500")]
	public static bool NNLJHFOPFIH<TOk, TErr>([In] this EFPDAHOJLMO<TOk, TErr> EAODMOEAJOC, [Out][NotNullWhen(true)] TErr OIMLEIJKDPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x25ACA90", Offset = "0x25ABE90", VA = "0x1825ACA90")]
	public static bool IMCKJFNLNIM<TOk, TErr>([In] this EFPDAHOJLMO<TOk, TErr> EAODMOEAJOC, [Out][NotNullWhen(true)] TOk LNPBFFMMNAG, [Out][NotNullWhen(false)] TErr OIMLEIJKDPB) where TOk : notnull where TErr : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x25AD5E0", Offset = "0x25AC9E0", VA = "0x1825AD5E0")]
	public static bool OKHEMKHPJJE<TOk, TErr>([In] this EFPDAHOJLMO<TOk, TErr> EAODMOEAJOC, [Out][NotNullWhen(true)] TOk LNPBFFMMNAG, [Out] EFPDAHOJLMO<TOk, TErr> EKECIOADHED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x25AB3C0", Offset = "0x25AA7C0", VA = "0x1825AB3C0")]
	public static bool BJAFPBFMKIC<TOk, TErr, UErr, UOk>([In] this EFPDAHOJLMO<TOk, TErr> EAODMOEAJOC, [Out][NotNullWhen(true)] TOk LNPBFFMMNAG, [Out] EFPDAHOJLMO<UOk, UErr> EKECIOADHED) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x25AAF10", Offset = "0x25AA310", VA = "0x1825AAF10")]
	public static bool AIOGIKEFLCF<TOk, TErr>([In] this EFPDAHOJLMO<TOk, TErr> EAODMOEAJOC, [Out][NotNullWhen(true)] TOk LNPBFFMMNAG, [Out] EFPDAHOJLMO<CPIOBHNHOJN, TErr> EKECIOADHED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x25ACDB0", Offset = "0x25AC1B0", VA = "0x1825ACDB0")]
	public static EFPDAHOJLMO<UOk, UErr> LMJKFJJFJPN<UOk, UErr, TOk, TErr>([In] this EFPDAHOJLMO<TOk, TErr> EAODMOEAJOC, [In] EFPDAHOJLMO<UOk, UErr> FPOCHAEKMIE) where TOk : UOk where TErr : UErr
	{
		return default(EFPDAHOJLMO<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x25AC750", Offset = "0x25ABB50", VA = "0x1825AC750")]
	public static EFPDAHOJLMO<TOk?[]?, TErr?> IFEJCOEEGHM<TOk, TErr>(this IEnumerable<EFPDAHOJLMO<TOk, TErr>> EAODMOEAJOC)
	{
		return default(EFPDAHOJLMO<TOk[], TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x2347150", Offset = "0x2346550", VA = "0x182347150")]
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
	[Cpp2IlInjected.Address(RVA = "0x2E2BB60", Offset = "0x2E2AF60", VA = "0x182E2BB60")]
	public static EFPDAHOJLMO<TOk, T> FOHKNAEBDEB<TOk>([In] TOk LNPBFFMMNAG) where TOk : notnull
	{
		return default(EFPDAHOJLMO<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x34632D0", Offset = "0x34626D0", VA = "0x1834632D0")]
	public static EFPDAHOJLMO<CPIOBHNHOJN, T> FOHKNAEBDEB()
	{
		return default(EFPDAHOJLMO<CPIOBHNHOJN, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x2E2BB60", Offset = "0x2E2AF60", VA = "0x182E2BB60")]
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
		[Cpp2IlInjected.Address(RVA = "0x1BE3B30", Offset = "0x1BE2F30", VA = "0x181BE3B30")]
		public NPKLDHNPEJH(BPLKPPEEMEJ<T> KAAAMIPABJJ, int ANLDOMENFNF, bool GADPMHIKPIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x3D37AA0", Offset = "0x3D36EA0", VA = "0x183D37AA0")]
		public BPLKPPEEMEJ<T>.FOFPMCCJNFP HMFAGAOEPDF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x3D37B90", Offset = "0x3D36F90", VA = "0x183D37B90", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x3D37B90", Offset = "0x3D36F90", VA = "0x183D37B90", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x347B8E0", Offset = "0x347ACE0", VA = "0x18347B8E0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x347BAD0", Offset = "0x347AED0", VA = "0x18347BAD0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x347BD10", Offset = "0x347B110", VA = "0x18347BD10", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x347C2A0", Offset = "0x347B6A0", VA = "0x18347C2A0")]
		public FOFPMCCJNFP(BPLKPPEEMEJ<T> KAAAMIPABJJ, int ANLDOMENFNF, bool GADPMHIKPIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x347B920", Offset = "0x347AD20", VA = "0x18347B920", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x347B9B0", Offset = "0x347ADB0", VA = "0x18347B9B0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x34674B0", Offset = "0x34668B0", VA = "0x1834674B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x458C640", Offset = "0x458BA40", VA = "0x18458C640")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public T ADHFGEBEBLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x3436680", Offset = "0x3435A80", VA = "0x183436680")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public T JGBDDJFAKIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x458C5E0", Offset = "0x458B9E0", VA = "0x18458C5E0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public T BPKONBPIDNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x458C770", Offset = "0x458BB70", VA = "0x18458C770")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int NAHNDBFADBN
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x15DE6C0", Offset = "0x15DDAC0", VA = "0x1815DE6C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0xEBABA0", Offset = "0xEB9FA0", VA = "0x180EBABA0")]
	private static int AEODHHCKODN(int DIENMHDGFGP, int HKIFHAEDDHO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x458C980", Offset = "0x458BD80", VA = "0x18458C980")]
	public BPLKPPEEMEJ(int PEGIIHFIAHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x458C9F0", Offset = "0x458BDF0", VA = "0x18458C9F0")]
	public BPLKPPEEMEJ(int PEGIIHFIAHP, Func<T> LHGJJBKLHAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x458CCB0", Offset = "0x458C0B0", VA = "0x18458CCB0")]
	public BPLKPPEEMEJ(T[] JAAOHPHONMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x458C610", Offset = "0x458BA10", VA = "0x18458C610")]
	public void CCIBHIGJLCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x458C820", Offset = "0x458BC20", VA = "0x18458C820")]
	public IEnumerable<T> KKJJFDBFKDA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x458C690", Offset = "0x458BA90", VA = "0x18458C690")]
	public BPLKPPEEMEJ<T>.FOFPMCCJNFP HMFAGAOEPDF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x3440CD0", Offset = "0x34400D0", VA = "0x183440CD0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3440CD0", Offset = "0x34400D0", VA = "0x183440CD0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public static class EDEPNLOGPLL
{
	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x23B8B10", Offset = "0x23B7F10", VA = "0x1823B8B10")]
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
		[Cpp2IlInjected.Address(RVA = "0x1CC5AD0", Offset = "0x1CC4ED0", VA = "0x181CC5AD0")]
		public RRColor(float BCPCCCLDBKN, float EKGAMFAEBGC, float MLKGDIFPGGI, float JMHOJIPAIMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x5E94090", Offset = "0x5E93490", VA = "0x185E94090", Slot = "4")]
		public bool Equals(RRColor LFMLAKDHEFO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x5E94110", Offset = "0x5E93510", VA = "0x185E94110", Slot = "0")]
		public override bool Equals(object LFMLAKDHEFO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x5E94210", Offset = "0x5E93610", VA = "0x185E94210", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x5E94290", Offset = "0x5E93690", VA = "0x185E94290", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x3E17AB0", Offset = "0x3E16EB0", VA = "0x183E17AB0")]
	internal OMMJNDDNFDL(string KCFFPPIEBHH, [In] TData KKOACPFFAML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class FHNIICAMPIP
{
	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x5E925F0", Offset = "0x5E919F0", VA = "0x185E925F0")]
	public static OMMJNDDNFDL<CPIOBHNHOJN> PBDMNAJCIOP(string KCFFPPIEBHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x23320C0", Offset = "0x23314C0", VA = "0x1823320C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8710A0", Offset = "0x8704A0", VA = "0x1808710A0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x871140", Offset = "0x870540", VA = "0x180871140")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x5E91930", Offset = "0x5E90D30", VA = "0x185E91930")]
	public void KAFAPEAADGC(float NMENOOMOOJP, object NOEAHPPKHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x5E918C0", Offset = "0x5E90CC0", VA = "0x185E918C0")]
	public void DADDPKGOCCP(object NOEAHPPKHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x5E919A0", Offset = "0x5E90DA0", VA = "0x185E919A0")]
	private void MMFENIFJBDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x5E91AD0", Offset = "0x5E90ED0", VA = "0x185E91AD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E1BD50", Offset = "0x3E1B150", VA = "0x183E1BD50")]
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
		[Cpp2IlInjected.Address(RVA = "0x361ADB0", Offset = "0x361A1B0", VA = "0x18361ADB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool ECGMHLLIGMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x361AAA0", Offset = "0x3619EA0", VA = "0x18361AAA0")]
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
	[Cpp2IlInjected.Address(RVA = "0x361AAE0", Offset = "0x3619EE0", VA = "0x18361AAE0")]
	public bool BKKEPFPDOJH(T NOEAHPPKHNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x361AC90", Offset = "0x361A090", VA = "0x18361AC90")]
	public bool HBMDGHADMGB(T NOEAHPPKHNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x361AC50", Offset = "0x361A050", VA = "0x18361AC50")]
	public bool CCJBPIIMLHG(T NOEAHPPKHNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x361ADE0", Offset = "0x361A1E0", VA = "0x18361ADE0", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x5E93AD0", Offset = "0x5E92ED0", VA = "0x185E93AD0", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x5E93FE0", Offset = "0x5E933E0", VA = "0x185E93FE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5E91DC0", Offset = "0x5E911C0", VA = "0x185E91DC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool ECGMHLLIGMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x5E91B60", Offset = "0x5E90F60", VA = "0x185E91B60")]
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
	[Cpp2IlInjected.Address(RVA = "0x5E91B70", Offset = "0x5E90F70", VA = "0x185E91B70")]
	public bool BKKEPFPDOJH(object NOEAHPPKHNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x5E91CB0", Offset = "0x5E910B0", VA = "0x185E91CB0")]
	public bool HBMDGHADMGB(object NOEAHPPKHNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5E91C50", Offset = "0x5E91050", VA = "0x185E91C50")]
	public bool CCJBPIIMLHG(object NOEAHPPKHNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5E91D50", Offset = "0x5E91150", VA = "0x185E91D50")]
	public void OFHIPKKHFGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5E91E50", Offset = "0x5E91250", VA = "0x185E91E50", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0xDF9A80", Offset = "0xDF8E80", VA = "0x180DF9A80", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0xDF84D0", Offset = "0xDF78D0", VA = "0x180DF84D0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x49DA110", Offset = "0x49D9510", VA = "0x1849DA110")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x49DA6C0", Offset = "0x49D9AC0", VA = "0x1849DA6C0")]
	public bool KAFAPEAADGC(T NMENOOMOOJP, object NOEAHPPKHNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x3D2F4E0", Offset = "0x3D2E8E0", VA = "0x183D2F4E0")]
	public bool DADDPKGOCCP(object NOEAHPPKHNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x49DA160", Offset = "0x49D9560", VA = "0x1849DA160")]
	public void ILNOFIHDCKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x49D9DF0", Offset = "0x49D91F0", VA = "0x1849D9DF0")]
	public bool AFCHMNEGHNL(object NOEAHPPKHNC, [Out] T NMENOOMOOJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x49DACE0", Offset = "0x49DA0E0", VA = "0x1849DACE0")]
	[FHEEPLFHPDM("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool KLIPCFOONOC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x49DBF90", Offset = "0x49DB390", VA = "0x1849DBF90")]
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
			[Cpp2IlInjected.Address(RVA = "0x5E92320", Offset = "0x5E91720", VA = "0x185E92320")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x5E92490", Offset = "0x5E91890", VA = "0x185E92490")]
		public FGHDPMGDHHO(float DFOEGCCLIEM, float CBMPBFEPCHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x5E92330", Offset = "0x5E91730", VA = "0x185E92330", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x5E926D0", Offset = "0x5E91AD0", VA = "0x185E926D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5E931B0", Offset = "0x5E925B0", VA = "0x185E931B0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x5E93270", Offset = "0x5E92670", VA = "0x185E93270", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5E93940", Offset = "0x5E92D40", VA = "0x185E93940")]
	public JHBFJHOGKGD(int EKJEIMGCNCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5E93440", Offset = "0x5E92840", VA = "0x185E93440")]
	public JKPHFFJEKJC EDOBPMJKEFM(FGHDPMGDHHO KPDNJGBDHCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x5E934D0", Offset = "0x5E928D0", VA = "0x185E934D0")]
	public void FOPEEGGBAKG(NJBNGAGMBGJ DJGEGECLOOG, [Optional] FGHDPMGDHHO MNBDHEMPDHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5E93330", Offset = "0x5E92730", VA = "0x185E93330", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x5E93ED0", Offset = "0x5E932D0", VA = "0x185E93ED0")]
		public MELMPAJOKBP(NJBNGAGMBGJ LOINEFDGIPC, ADEEFCLAPAP PDECDCHNHMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x5E93E80", Offset = "0x5E93280", VA = "0x185E93E80", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x5E93B20", Offset = "0x5E92F20", VA = "0x185E93B20")]
	internal static bool CGKCLJPBKNG(float JMHOJIPAIMC, float MLKGDIFPGGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x5E86950", Offset = "0x5E85D50", VA = "0x185E86950")]
	internal static float DLGBOGKIPEI(float JMHOJIPAIMC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x5E93B90", Offset = "0x5E92F90", VA = "0x185E93B90")]
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
		[Cpp2IlInjected.Address(RVA = "0x5E93D90", Offset = "0x5E93190", VA = "0x185E93D90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event ADEEFCLAPAP? GABFPEABAID
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x5E93C50", Offset = "0x5E93050", VA = "0x185E93C50", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x5E93CF0", Offset = "0x5E930F0", VA = "0x185E93CF0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x5A09A90", Offset = "0x5A08E90", VA = "0x185A09A90")]
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
			[Cpp2IlInjected.Address(RVA = "0xDF9A80", Offset = "0xDF8E80", VA = "0x180DF9A80", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x472B5F0", Offset = "0x472A9F0", VA = "0x18472B5F0", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x33CB8B0", Offset = "0x33CACB0", VA = "0x1833CB8B0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x472A8D0", Offset = "0x4729CD0", VA = "0x18472A8D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x472B4B0", Offset = "0x472A8B0", VA = "0x18472B4B0")]
		private void OEJNKOJDKLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x472A880", Offset = "0x4729C80", VA = "0x18472A880")]
		private void AHMEHKPBADP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x472B500", Offset = "0x472A900", VA = "0x18472B500", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x4DE2D20", Offset = "0x4DE2120", VA = "0x184DE2D20", Slot = "12")]
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
		[Cpp2IlInjected.Address(RVA = "0x4DE2DF0", Offset = "0x4DE21F0", VA = "0x184DE2DF0", Slot = "4")]
		get
		{
			return (TValue)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x4DE3080", Offset = "0x4DE2480", VA = "0x184DE3080", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public ICollection<TKey> LAIPAOGLJAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x4DE2E60", Offset = "0x4DE2260", VA = "0x184DE2E60", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public ICollection<TValue> CAKFANLNPIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x4DE2F70", Offset = "0x4DE2370", VA = "0x184DE2F70", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x4DE2AD0", Offset = "0x4DE1ED0", VA = "0x184DE2AD0")]
	public DLHEPFMCLKJ(LKILEELBOGD<TKey, TValue> PJGHEFAECMK, [Optional] IDictionary<TKey, TValue>? LBMOEPHIFMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x4DE03C0", Offset = "0x4DDF7C0", VA = "0x184DE03C0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x4DE0370", Offset = "0x4DDF770", VA = "0x184DE0370")]
	public void CALCLNCNOND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x4DE0000", Offset = "0x4DDF400", VA = "0x184DE0000", Slot = "9")]
	public void Add(TKey MIMFBLPNKOG, TValue NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x4DE0D40", Offset = "0x4DE0140", VA = "0x184DE0D40")]
	public void FMFPNKJMEGE(TKey MIMFBLPNKOG, TValue NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x4DE0FC0", Offset = "0x4DE03C0", VA = "0x184DE0FC0")]
	public void GBKLBJKHDEA(TKey MIMFBLPNKOG, TValue NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x4DE13E0", Offset = "0x4DE07E0", VA = "0x184DE13E0")]
	public void HHAJMEJKBDB(TKey MIMFBLPNKOG, TValue NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x4DE17E0", Offset = "0x4DE0BE0", VA = "0x184DE17E0")]
	public void HPLEIHNGMJL(TKey MIMFBLPNKOG, TValue NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x4DE2110", Offset = "0x4DE1510", VA = "0x184DE2110", Slot = "14")]
	void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> EDPLJLLHNEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x4DE22F0", Offset = "0x4DE16F0", VA = "0x184DE22F0", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> EDPLJLLHNEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x4DE2650", Offset = "0x4DE1A50", VA = "0x184DE2650", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> EDPLJLLHNEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x4DE0430", Offset = "0x4DDF830", VA = "0x184DE0430", Slot = "8")]
	public bool ContainsKey(TKey MIMFBLPNKOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x4DE1DB0", Offset = "0x4DE11B0", VA = "0x184DE1DB0")]
	public bool MLEONNFAMNI(TKey MIMFBLPNKOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x4DE1C80", Offset = "0x4DE1080", VA = "0x184DE1C80")]
	public bool KOOOLACEJPE(TKey MIMFBLPNKOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x4DE1F40", Offset = "0x4DE1340", VA = "0x184DE1F40", Slot = "10")]
	public bool Remove(TKey MIMFBLPNKOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x4DE2840", Offset = "0x4DE1C40", VA = "0x184DE2840", Slot = "11")]
	public bool TryGetValue(TKey MIMFBLPNKOG, [Out] TValue NMENOOMOOJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x4DE07D0", Offset = "0x4DDFBD0", VA = "0x184DE07D0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TValue>[] NCABOBFFNFK, int EKDLGEADDMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x4DE2810", Offset = "0x4DE1C10", VA = "0x184DE2810", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x4DE1200", Offset = "0x4DE0600", VA = "0x184DE1200", Slot = "19")]
	[IteratorStateMachine(typeof(DLHEPFMCLKJ<, >.CENGEBBJANG))]
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x4DE1920", Offset = "0x4DE0D20", VA = "0x184DE1920", Slot = "21")]
	public bool IHFIPJJMBFF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x4DE1B20", Offset = "0x4DE0F20", VA = "0x184DE1B20")]
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
			[Cpp2IlInjected.Address(RVA = "0xB18E90", Offset = "0xB18290", VA = "0x180B18E90")]
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
			[Cpp2IlInjected.Address(RVA = "0x896540", Offset = "0x895940", VA = "0x180896540")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x896550", Offset = "0x895950", VA = "0x180896550")]
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
			[Cpp2IlInjected.Address(RVA = "0x9FC9D0", Offset = "0x9FBDD0", VA = "0x1809FC9D0")]
			[CompilerGenerated]
			get
			{
				return default(DateTimeOffset);
			}
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x1226990", Offset = "0x1225D90", VA = "0x181226990")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x3C9E020", Offset = "0x3C9D420", VA = "0x183C9E020")]
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
			[Cpp2IlInjected.Address(RVA = "0xDF9A80", Offset = "0xDF8E80", VA = "0x180DF9A80", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x39090C0", Offset = "0x39084C0", VA = "0x1839090C0", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x33C5C80", Offset = "0x33C5080", VA = "0x1833C5C80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x3906BA0", Offset = "0x3905FA0", VA = "0x183906BA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x3908BC0", Offset = "0x3907FC0", VA = "0x183908BC0")]
		private void OEJNKOJDKLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x3909070", Offset = "0x3908470", VA = "0x183909070", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0xDE9B70", Offset = "0xDE8F70", VA = "0x180DE9B70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public int AEFHJLMLIJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x3ED3810", Offset = "0x3ED2C10", VA = "0x183ED3810", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	internal int BCBKHLEFBID
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x30E5EB0", Offset = "0x30E52B0", VA = "0x1830E5EB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public ICollection<TVal> CAKFANLNPIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x3ED3940", Offset = "0x3ED2D40", VA = "0x183ED3940", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	ICollection<TKey> IDictionary<TKey, TVal>.AKBHKCLLIML
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x3ED11E0", Offset = "0x3ED05E0", VA = "0x183ED11E0", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x3ED3870", Offset = "0x3ED2C70", VA = "0x183ED3870", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x3ED3990", Offset = "0x3ED2D90", VA = "0x183ED3990", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x3ECB520", Offset = "0x3ECA920", VA = "0x183ECB520")]
	private bool GEOMPJIKGND(int EKJEIMGCNCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x3ED0360", Offset = "0x3ECF760", VA = "0x183ED0360")]
	private void PNIDBDDIHGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x3ED2510", Offset = "0x3ED1910", VA = "0x183ED2510")]
	public PFHIIKDLFKF(int EKJEIMGCNCB, [Optional] KHGEMMGKPAC? AFODKDLIOIH, [Optional] IEqualityComparer<TKey>? ODLNOKIOIEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x3ED2010", Offset = "0x3ED1410", VA = "0x183ED2010")]
	public PFHIIKDLFKF(TimeSpan PFOAAGGMJMN, [Optional] IEqualityComparer<TKey>? ODLNOKIOIEG, [Optional] HFJCPICEHAL? HOAPOIEFGNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x3ED1B10", Offset = "0x3ED0F10", VA = "0x183ED1B10")]
	public PFHIIKDLFKF(int EKJEIMGCNCB, TimeSpan PFOAAGGMJMN, [Optional] IEqualityComparer<TKey>? ODLNOKIOIEG, [Optional] HFJCPICEHAL? HOAPOIEFGNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x3ED3290", Offset = "0x3ED2690", VA = "0x183ED3290")]
	public PFHIIKDLFKF(int EKJEIMGCNCB, KHGEMMGKPAC? AFODKDLIOIH, TimeSpan PFOAAGGMJMN, [Optional] IEqualityComparer<TKey>? ODLNOKIOIEG, [Optional] HFJCPICEHAL? HOAPOIEFGNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x3ECE450", Offset = "0x3ECD850", VA = "0x183ECE450", Slot = "21")]
	public bool IHFIPJJMBFF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x3ECAB70", Offset = "0x3EC9F70", VA = "0x183ECAB70", Slot = "22")]
	public bool EAEKDGPNGFG(int PEGIIHFIAHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x3ECC2F0", Offset = "0x3ECB6F0", VA = "0x183ECC2F0")]
	private bool HAIMAEFCJPC(int PEGIIHFIAHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x3ECDFB0", Offset = "0x3ECD3B0", VA = "0x183ECDFB0")]
	public void HPDCNGOHBJP(TKey MIMFBLPNKOG, TVal NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x3EC9120", Offset = "0x3EC8520", VA = "0x183EC9120", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> EDPLJLLHNEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x3EC9300", Offset = "0x3EC8700", VA = "0x183EC9300", Slot = "9")]
	public void Add(TKey MIMFBLPNKOG, TVal NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x3EC96B0", Offset = "0x3EC8AB0", VA = "0x183EC96B0", Slot = "8")]
	public bool ContainsKey(TKey MIMFBLPNKOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x3ED0BA0", Offset = "0x3ECFFA0", VA = "0x183ED0BA0", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Contains(KeyValuePair<TKey, TVal> EDPLJLLHNEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x3ED08B0", Offset = "0x3ECFCB0", VA = "0x183ED08B0", Slot = "10")]
	public bool Remove(TKey MIMFBLPNKOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x3ED0E60", Offset = "0x3ED0260", VA = "0x183ED0E60", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Remove(KeyValuePair<TKey, TVal> EDPLJLLHNEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x3ECE4C0", Offset = "0x3ECD8C0", VA = "0x183ECE4C0")]
	private bool JDNPPFNHIOL(TKey MIMFBLPNKOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x3ECB330", Offset = "0x3ECA730", VA = "0x183ECB330")]
	private TVal EHGHEBAOCHM(TKey NGGIFCJNAHC)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x3ED1950", Offset = "0x3ED0D50", VA = "0x183ED1950", Slot = "11")]
	public bool TryGetValue(TKey NGGIFCJNAHC, [Out] TVal NMENOOMOOJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x3EC9570", Offset = "0x3EC8970", VA = "0x183EC9570", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x3EC9B00", Offset = "0x3EC8F00", VA = "0x183EC9B00", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] NCABOBFFNFK, int EKDLGEADDMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x3ECF170", Offset = "0x3ECE570", VA = "0x183ECF170")]
	private bool JKDGKPNABJL(MCNAIOINLOB IFBIJHJINAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x3ECD140", Offset = "0x3ECC540", VA = "0x183ECD140")]
	private void HEPKCBICNKK(LinkedListNode<MCNAIOINLOB> OMEGIHLLCPL, TVal HHMFGBLJOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x3ECF2F0", Offset = "0x3ECE6F0", VA = "0x183ECF2F0")]
	private void KAFAPEAADGC(TKey MIMFBLPNKOG, TVal NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x3ECBCF0", Offset = "0x3ECB0F0", VA = "0x183ECBCF0")]
	private void GNECFMHIOBO(MCNAIOINLOB IFBIJHJINAE, TVal HHMFGBLJOPM, int KPPJFIPBECF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x3ECC1D0", Offset = "0x3ECB5D0", VA = "0x183ECC1D0", Slot = "19")]
	[IteratorStateMachine(typeof(PFHIIKDLFKF<, >.JLFNKKABHLN))]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x3ED1210", Offset = "0x3ED0610", VA = "0x183ED1210", Slot = "20")]
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
