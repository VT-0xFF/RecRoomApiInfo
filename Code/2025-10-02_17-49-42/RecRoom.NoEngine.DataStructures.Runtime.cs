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
		[Cpp2IlInjected.Address(RVA = "0xAD77F0", Offset = "0xAD61F0", VA = "0x180AD77F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8664640", Offset = "0x8663040", VA = "0x188664640")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAD85C0", Offset = "0xAD6FC0", VA = "0x180AD85C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD8600", Offset = "0xAD7000", VA = "0x180AD8600")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class EIFMBIODCKA
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	protected EIFMBIODCKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class DOMLOHACAFM<T> : EIFMBIODCKA
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	protected struct CIBJGJFCBFJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public enum CDLNADGIOAH
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
		public CDLNADGIOAH DGNODDPLLPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public T FCCCPABHDPG;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private int GPFJDOEPJBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool OOHBFHMFFNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	protected readonly bool ILNFOIBODOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	protected List<T>? NFCNCGFBCNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<CIBJGJFCBFJ>? JNBLOMCANBE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool IDDDMANLGPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4688570", Offset = "0x4686F70", VA = "0x184688570")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4688890", Offset = "0x4687290", VA = "0x184688890")]
	protected DOMLOHACAFM(bool ILNFOIBODOB, bool OOHBFHMFFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4687F90", Offset = "0x4686990", VA = "0x184687F90")]
	protected bool EDHDHJPJIDG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x46885C0", Offset = "0x4686FC0", VA = "0x1846885C0")]
	protected void KCPNIDLNDCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4688030", Offset = "0x4686A30", VA = "0x184688030")]
	protected void EJHOOMFMLIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3F28EA0", Offset = "0x3F278A0", VA = "0x183F28EA0")]
	private static void MIFPBHJJPJC<U>(List<U>? GBEHGKLEJFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4688390", Offset = "0x4686D90", VA = "0x184688390", Slot = "4")]
	public void HMDNMGBNKIA(T FCCCPABHDPG, bool ICPAKIDKMAD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x46886D0", Offset = "0x46870D0", VA = "0x1846886D0", Slot = "5")]
	public void MCKODPOBNPM(T FCCCPABHDPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4688210", Offset = "0x4686C10", VA = "0x184688210")]
	public void EMMOLKMNHIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class EBDGCEEEFPM : DOMLOHACAFM<Action>
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x8661230", Offset = "0x865FC30", VA = "0x188661230")]
	public EBDGCEEEFPM(bool ILNFOIBODOB = false, bool OOHBFHMFFNN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x8660FD0", Offset = "0x865F9D0", VA = "0x188660FD0")]
	public void KDMGDDCNHFD()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x86611D0", Offset = "0x865FBD0", VA = "0x1886611D0")]
	public static EBDGCEEEFPM LGPEJBKKIPP(EBDGCEEEFPM EFICKPAHEEO, Action FCCCPABHDPG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x8660F70", Offset = "0x865F970", VA = "0x188660F70")]
	public static EBDGCEEEFPM AMFDBGPEIDH(EBDGCEEEFPM EFICKPAHEEO, Action FCCCPABHDPG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface CEPCGPGPBGJ<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HMDNMGBNKIA(Action<T> FCCCPABHDPG, bool ICPAKIDKMAD = false);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MCKODPOBNPM(Action<T> FCCCPABHDPG);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class AHDLCNFLGGK<T> : DOMLOHACAFM<Action<T>>, CEPCGPGPBGJ<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4689B60", Offset = "0x4688560", VA = "0x184689B60")]
	public AHDLCNFLGGK(bool ILNFOIBODOB = false, bool OOHBFHMFFNN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x53F7E40", Offset = "0x53F6840", VA = "0x1853F7E40")]
	public void KDMGDDCNHFD(T GGMLEPFJHKP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4FDDD30", Offset = "0x4FDC730", VA = "0x184FDDD30")]
	public static AHDLCNFLGGK<T> LGPEJBKKIPP(AHDLCNFLGGK<T> EFICKPAHEEO, Action<T> FCCCPABHDPG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4FDD490", Offset = "0x4FDBE90", VA = "0x184FDD490")]
	public static AHDLCNFLGGK<T> AMFDBGPEIDH(AHDLCNFLGGK<T> EFICKPAHEEO, Action<T> FCCCPABHDPG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface NEIJBLGPMFN<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HMDNMGBNKIA(Action<T, U> FCCCPABHDPG, bool ICPAKIDKMAD = false);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MCKODPOBNPM(Action<T, U> FCCCPABHDPG);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class FONIFJMDCJB<T, U> : DOMLOHACAFM<Action<T, U>>, NEIJBLGPMFN<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4689B60", Offset = "0x4688560", VA = "0x184689B60")]
	public FONIFJMDCJB(bool ILNFOIBODOB = false, bool OOHBFHMFFNN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5014360", Offset = "0x5012D60", VA = "0x185014360")]
	public void KDMGDDCNHFD(T GGMLEPFJHKP, U CPLMEDPHCON)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4FDDD30", Offset = "0x4FDC730", VA = "0x184FDDD30")]
	public static FONIFJMDCJB<T, U> LGPEJBKKIPP(FONIFJMDCJB<T, U> EFICKPAHEEO, Action<T, U> FCCCPABHDPG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4FDD490", Offset = "0x4FDBE90", VA = "0x184FDD490")]
	public static FONIFJMDCJB<T, U> AMFDBGPEIDH(FONIFJMDCJB<T, U> EFICKPAHEEO, Action<T, U> FCCCPABHDPG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class KPOLDAAHPLJ<T, U, V> : DOMLOHACAFM<Action<T, U, V>> where T : notnull where U : notnull where V : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4689B60", Offset = "0x4688560", VA = "0x184689B60")]
	public KPOLDAAHPLJ(bool ILNFOIBODOB = false, bool OOHBFHMFFNN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5680FD0", Offset = "0x567F9D0", VA = "0x185680FD0")]
	public void KDMGDDCNHFD(T GGMLEPFJHKP, U CPLMEDPHCON, V FEBGNHCBECK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x4FDDD30", Offset = "0x4FDC730", VA = "0x184FDDD30")]
	public static KPOLDAAHPLJ<T, U, V> LGPEJBKKIPP(KPOLDAAHPLJ<T, U, V> EFICKPAHEEO, Action<T, U, V> FCCCPABHDPG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4FDD490", Offset = "0x4FDBE90", VA = "0x184FDD490")]
	public static KPOLDAAHPLJ<T, U, V> AMFDBGPEIDH(KPOLDAAHPLJ<T, U, V> EFICKPAHEEO, Action<T, U, V> FCCCPABHDPG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface ICEMJNCJBGE<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public sealed class PGFEHMPIKEB<T, U, V, W> : DOMLOHACAFM<Action<T, U, V, W>>, ICEMJNCJBGE<T, U, V, W> where T : notnull where U : notnull where V : notnull where W : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4689B60", Offset = "0x4688560", VA = "0x184689B60")]
	public PGFEHMPIKEB(bool ILNFOIBODOB = false, bool OOHBFHMFFNN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5CA9280", Offset = "0x5CA7C80", VA = "0x185CA9280")]
	public void KDMGDDCNHFD(T GGMLEPFJHKP, U CPLMEDPHCON, V FEBGNHCBECK, W LIPBKGAOLBA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4FDDD30", Offset = "0x4FDC730", VA = "0x184FDDD30")]
	public static PGFEHMPIKEB<T, U, V, W> LGPEJBKKIPP(PGFEHMPIKEB<T, U, V, W> EFICKPAHEEO, Action<T, U, V, W> FCCCPABHDPG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4FDD490", Offset = "0x4FDBE90", VA = "0x184FDD490")]
	public static PGFEHMPIKEB<T, U, V, W> AMFDBGPEIDH(PGFEHMPIKEB<T, U, V, W> EFICKPAHEEO, Action<T, U, V, W> FCCCPABHDPG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class FENHLFGKNLG<T, U, V, W, X> : DOMLOHACAFM<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x4689B60", Offset = "0x4688560", VA = "0x184689B60")]
	public FENHLFGKNLG(bool ILNFOIBODOB = false, bool OOHBFHMFFNN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4FDD980", Offset = "0x4FDC380", VA = "0x184FDD980")]
	public void KDMGDDCNHFD(T GGMLEPFJHKP, U CPLMEDPHCON, V FEBGNHCBECK, W LIPBKGAOLBA, X FKPKEFAKAOE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4FDDD30", Offset = "0x4FDC730", VA = "0x184FDDD30")]
	public static FENHLFGKNLG<T, U, V, W, X> LGPEJBKKIPP(FENHLFGKNLG<T, U, V, W, X> EFICKPAHEEO, Action<T, U, V, W, X> FCCCPABHDPG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4FDD490", Offset = "0x4FDBE90", VA = "0x184FDD490")]
	public static FENHLFGKNLG<T, U, V, W, X> AMFDBGPEIDH(FENHLFGKNLG<T, U, V, W, X> EFICKPAHEEO, Action<T, U, V, W, X> FCCCPABHDPG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class BFDFIJCFAPO<T, U, V, W, X, Y> : DOMLOHACAFM<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4689B60", Offset = "0x4688560", VA = "0x184689B60")]
	public BFDFIJCFAPO(bool ILNFOIBODOB = false, bool OOHBFHMFFNN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x668DCD0", Offset = "0x668C6D0", VA = "0x18668DCD0")]
	public void KDMGDDCNHFD(T GGMLEPFJHKP, U CPLMEDPHCON, V FEBGNHCBECK, W LIPBKGAOLBA, X FKPKEFAKAOE, Y KEEMKILMOML)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4FDDD30", Offset = "0x4FDC730", VA = "0x184FDDD30")]
	public static BFDFIJCFAPO<T, U, V, W, X, Y> LGPEJBKKIPP(BFDFIJCFAPO<T, U, V, W, X, Y> EFICKPAHEEO, Action<T, U, V, W, X, Y> FCCCPABHDPG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4FDD490", Offset = "0x4FDBE90", VA = "0x184FDD490")]
	public static BFDFIJCFAPO<T, U, V, W, X, Y> AMFDBGPEIDH(BFDFIJCFAPO<T, U, V, W, X, Y> EFICKPAHEEO, Action<T, U, V, W, X, Y> FCCCPABHDPG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class FFHEHMMDMCO<TKey, TVal> where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly CMLAJHKJHAI<TKey, TVal> NGPKCEPPLMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly Dictionary<TKey, (TVal value, int size)> DKKDCHAEKMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly CMLAJHKJHAI<TKey, TVal>.GMMOIMEAMOI? BNIBENIEOLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly int EIGJLELNLPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly CMLAJHKJHAI<TKey, TVal>.DENKMHLGPPH? KNIBJNPDJHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private int HPHHELAEKIE;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal int MCPOLGLLDOC
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x4FDF070", Offset = "0x4FDDA70", VA = "0x184FDF070")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int EJPLDFLIJEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xAB33E0", Offset = "0xAB1DE0", VA = "0x180AB33E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4FDFFF0", Offset = "0x4FDE9F0", VA = "0x184FDFFF0")]
	public FFHEHMMDMCO(int EIGJLELNLPL, [Optional] CMLAJHKJHAI<TKey, TVal>.DENKMHLGPPH? KNIBJNPDJHI, [Optional] IEqualityComparer<TKey>? ABKMLEEHGLA, [Optional] CMLAJHKJHAI<TKey, TVal>.GMMOIMEAMOI? BNIBENIEOLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x4FDFAA0", Offset = "0x4FDE4A0", VA = "0x184FDFAA0")]
	public void HMOACHJGABB(TKey HPFHOBCPNEF, TVal KMAFNKGMDCF, bool FJJKEPDGODG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4FDF390", Offset = "0x4FDDD90", VA = "0x184FDF390")]
	public bool ENECJGLEMCG(TKey HPFHOBCPNEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x4FDEFA0", Offset = "0x4FDD9A0", VA = "0x184FDEFA0")]
	public bool BMFHANOLGIO(TKey JLGLJMOGAHI, [Out] TVal KMAFNKGMDCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4FDFC70", Offset = "0x4FDE670", VA = "0x184FDFC70")]
	private void JEGLGLJGLBJ(TKey HPFHOBCPNEF, TVal KMAFNKGMDCF, int BCAJFCGHDKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4FDF0C0", Offset = "0x4FDDAC0", VA = "0x184FDF0C0")]
	public bool DBNKIIBONAP(TKey HPFHOBCPNEF, TVal KMAFNKGMDCF, bool FJJKEPDGODG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4FDF330", Offset = "0x4FDDD30", VA = "0x184FDF330")]
	public void EMMOLKMNHIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4FDF4C0", Offset = "0x4FDDEC0", VA = "0x184FDF4C0")]
	private void GKGDLCHJANI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4FDF9C0", Offset = "0x4FDE3C0", VA = "0x184FDF9C0")]
	private bool HKFENEOJHLC(TKey HPFHOBCPNEF, JKMLBGBCOJI LJPPNNLHGCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4FDF250", Offset = "0x4FDDC50", VA = "0x184FDF250")]
	private void DOOGNDPIAIO(TKey HPFHOBCPNEF, TVal KMAFNKGMDCF, JKMLBGBCOJI LJPPNNLHGCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4FDFEC0", Offset = "0x4FDE8C0", VA = "0x184FDFEC0")]
	private void JJGECCADJKO(TKey HPFHOBCPNEF, TVal MKDEBCJNKCE, JKMLBGBCOJI LJPPNNLHGCJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class NIBPLIBKPIO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly Action KNEOKAFDOBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool PHCLLKDBNLF;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0xABA5E0", Offset = "0xAB8FE0", VA = "0x180ABA5E0")]
	public NIBPLIBKPIO(Action CHDFLAOCICG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x8664580", Offset = "0x8662F80", VA = "0x188664580", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x32D1E30", Offset = "0x32D0830", VA = "0x1832D1E30")]
	public static MDANMGHNNOC<T> MLAHKGEEKLJ<T>(T KMAFNKGMDCF, Action CHDFLAOCICG) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class MDANMGHNNOC<T> : NIBPLIBKPIO where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public T AFPBILBCKEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x592F470", Offset = "0x592DE70", VA = "0x18592F470")]
	public MDANMGHNNOC(T KMAFNKGMDCF, Action CHDFLAOCICG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class GKNHKNCNHCH<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly IIGENIOMKIB<T>? MMFIFBMBLHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly ReadOnlySequence<T> AKCCICONGOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private bool PHCLLKDBNLF;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly GKNHKNCNHCH<T> BENGIKOEPPE;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ReadOnlySequence<T> JNFABFBEFAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5131970", Offset = "0x5130370", VA = "0x185131970")]
		get
		{
			return default(ReadOnlySequence<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long EJCBNJPPPEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5131830", Offset = "0x5130230", VA = "0x185131830")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool DGOCJDKBCHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x5131510", Offset = "0x512FF10", VA = "0x185131510")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5131ED0", Offset = "0x51308D0", VA = "0x185131ED0")]
	public GKNHKNCNHCH(IIGENIOMKIB<T> PJALKHMAFHG, IIGENIOMKIB<T> CLKOLLELBAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5131B30", Offset = "0x5130530", VA = "0x185131B30")]
	public GKNHKNCNHCH(IIGENIOMKIB<T> PJALKHMAFHG, int MHADOGLMBLF, IIGENIOMKIB<T> CLKOLLELBAC, int LBJEGLLBLMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5132330", Offset = "0x5130D30", VA = "0x185132330")]
	private GKNHKNCNHCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x51315D0", Offset = "0x512FFD0", VA = "0x1851315D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5131310", Offset = "0x512FD10", VA = "0x185131310")]
	public T[] ABAGCAMAMIA()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5131650", Offset = "0x5130050", VA = "0x185131650")]
	public static ReadOnlySequence<T> HDPJNBPLGPE(GKNHKNCNHCH<T>? DFJFBOBNOAP)
	{
		return default(ReadOnlySequence<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct EAAONHPDFDK<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly IDisposable AHFGKNCNHPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public T AFPBILBCKEL;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4AF1E00", Offset = "0x4AF0800", VA = "0x184AF1E00")]
	public EAAONHPDFDK(IDisposable HJCIABFMGKM, [In] T KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x404D6A0", Offset = "0x404C0A0", VA = "0x18404D6A0")]
	public static EAAONHPDFDK<U> CDMHLJMENAD<U>([In] EAAONHPDFDK<T> HJCIABFMGKM, [In] U KMAFNKGMDCF) where U : notnull
	{
		return default(EAAONHPDFDK<U>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4AF1BE0", Offset = "0x4AF05E0", VA = "0x184AF1BE0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class BBKNEFMNOBF
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3B24020", Offset = "0x3B22A20", VA = "0x183B24020")]
	public static EAAONHPDFDK<T> KDBDJPAJKDJ<T>(IDisposable HJCIABFMGKM, [In] T KMAFNKGMDCF) where T : notnull
	{
		return default(EAAONHPDFDK<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3B24080", Offset = "0x3B22A80", VA = "0x183B24080")]
	public static EAAONHPDFDK<T> LNEPMIJAJCA<T>([In] this EAAONHPDFDK<T> DKGBCFDLMOI, [Out] T KMAFNKGMDCF) where T : notnull
	{
		return default(EAAONHPDFDK<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x32D3360", Offset = "0x32D1D60", VA = "0x1832D3360")]
	public static EAAONHPDFDK<U?> CDMHLJMENAD<U, T>([In] EAAONHPDFDK<T> FBCIKHKDEMB, [In] U KMAFNKGMDCF)
	{
		return default(EAAONHPDFDK<U>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public readonly struct HHIPOMEIBHM : IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public readonly struct LOJCLMCGDHN : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250")]
		public static LOJCLMCGDHN KDBDJPAJKDJ()
		{
			return default(LOJCLMCGDHN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x86634A0", Offset = "0x8661EA0", VA = "0x1886634A0")]
	public static string DBGLFDCDFHG(Type DGNODDPLLPC, [Optional] string? EBIFCOFCGDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3DCBFA0", Offset = "0x3DCA9A0", VA = "0x183DCBFA0")]
	public static string? DBGLFDCDFHG<T>([Optional] string? EBIFCOFCGDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3DCC020", Offset = "0x3DCAA20", VA = "0x183DCC020")]
	public static string? NCJFABCCOPA<T>([Optional] string? ACDMMFFIMNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250")]
	public static HHIPOMEIBHM DIHLONADDEL(string EBIFCOFCGDD, string? ACDMMFFIMNN)
	{
		return default(HHIPOMEIBHM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct MAHLLPPHLEI
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public delegate bool AIKABDHFCON(string ELIGFMBCKJI, MAHLLPPHLEI JFGHHMIIOIB);

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class NBKPHFPPJMK<T> where T : notnull, Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public List<int> enumValuesSubset;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public NBKPHFPPJMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x5A45B80", Offset = "0x5A44580", VA = "0x185A45B80")]
		internal void ACAEKFBIIDC(T x)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public int OGMIMHJKKEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public string ILAEKGJFODM;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x8664020", Offset = "0x8662A20", VA = "0x188664020")]
	public static Dictionary<string, MAHLLPPHLEI> HBPMNFDONPI(Type LIPDCJPBGLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3E86A00", Offset = "0x3E85400", VA = "0x183E86A00")]
	public static Dictionary<string, MAHLLPPHLEI> HBPMNFDONPI<T>(Type LIPDCJPBGLL, IReadOnlyDictionary<T, string> IJADMOPKEBK) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3E86340", Offset = "0x3E84D40", VA = "0x183E86340")]
	public static Dictionary<string, MAHLLPPHLEI> AAJCKLCOBPL<T>(List<T> MLIKPGBPHDO) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x8663C60", Offset = "0x8662660", VA = "0x188663C60")]
	public static Dictionary<string, MAHLLPPHLEI> GFDICCOIMLB(Type LIPDCJPBGLL, AIKABDHFCON ECNIFIDPIJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8663AA0", Offset = "0x86624A0", VA = "0x188663AA0")]
	public static Dictionary<int, string> BLIHLEOKKEE(Dictionary<string, MAHLLPPHLEI> PBOCDEMNFLD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public abstract class EFLAGBIEFMN : NKNFPHMKKGH
{
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public static bool MNOOOMAAHBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly string? IKPKGICKELP;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public virtual NKNFPHMKKGH? MBDOLLKKABN
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xAAD570", Offset = "0xAABF70", VA = "0x180AAD570", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8661940", Offset = "0x8660340", VA = "0x188661940")]
	protected EFLAGBIEFMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string NGBNCIGPFCK();

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x86614B0", Offset = "0x865FEB0", VA = "0x1886614B0", Slot = "8")]
	public virtual string MGMEEDDACBH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x8661690", Offset = "0x8660090", VA = "0x188661690", Slot = "9")]
	public void ONHNFOGKHHD(StringBuilder KKCIBDLDDEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x8661330", Offset = "0x865FD30", VA = "0x188661330", Slot = "10")]
	public void HDBGMMLBDIF(StringBuilder KKCIBDLDDEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8661390", Offset = "0x865FD90", VA = "0x188661390", Slot = "11")]
	public void JGFNOHEKHBF(StringBuilder KKCIBDLDDEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x8661530", Offset = "0x865FF30", VA = "0x188661530", Slot = "12")]
	public void NGDPCAJBDHN(StringBuilder KKCIBDLDDEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x8661290", Offset = "0x865FC90", VA = "0x188661290")]
	public static void BKEDCBLLANO(StringBuilder KKCIBDLDDEH, string NICJKPGGLEM, string MIIAIIDIFHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7512160", Offset = "0x7510B60", VA = "0x187512160", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class CGLIJIMMDDL : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x8660900", Offset = "0x865F300", VA = "0x188660900")]
	public CGLIJIMMDDL(string JEBOHIALEMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class KGOLEMFPMNK<TErr> : CGLIJIMMDDL where TErr : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly TErr KNDOEEHFBJD;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5661920", Offset = "0x5660320", VA = "0x185661920")]
	private KGOLEMFPMNK([In] TErr BLICJMIMONA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5661850", Offset = "0x5660250", VA = "0x185661850")]
	public static KGOLEMFPMNK<TErr> KDBDJPAJKDJ([In] TErr BLICJMIMONA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class DDEHFFPEPDG : Stream
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly HashAlgorithm GLJEDONIPGH;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public override bool AMMOLAMGIGD
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public override bool OEGMIEBPEAC
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public override bool HDMMAPNIABO
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xAC8240", Offset = "0xAC6C40", VA = "0x180AC8240", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override long EJCBNJPPPEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8660D60", Offset = "0x865F760", VA = "0x188660D60", Slot = "12")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override long NGNFCFGNCAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8660DD0", Offset = "0x865F7D0", VA = "0x188660DD0", Slot = "13")]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8660E40", Offset = "0x865F840", VA = "0x188660E40", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x8660CF0", Offset = "0x865F6F0", VA = "0x188660CF0")]
	public DDEHFFPEPDG(HashAlgorithm GLJEDONIPGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x8660B10", Offset = "0x865F510", VA = "0x188660B10", Slot = "35")]
	public override int Read(byte[] FPGJFOLEKAK, int JBCPGNDLJHB, int MHMCOJIKNCI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x8660CC0", Offset = "0x865F6C0", VA = "0x188660CC0", Slot = "38")]
	public override void Write(byte[] FPGJFOLEKAK, int JBCPGNDLJHB, int MHMCOJIKNCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x8660BB0", Offset = "0x865F5B0", VA = "0x188660BB0", Slot = "33")]
	public override long Seek(long JBCPGNDLJHB, SeekOrigin IIBHNKFDNNM)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x8660C40", Offset = "0x865F640", VA = "0x188660C40", Slot = "34")]
	public override void SetLength(long KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "23")]
	public override void Flush()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x8660A30", Offset = "0x865F430", VA = "0x188660A30")]
	public byte[] OFMBKNEAOEA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface NKNFPHMKKGH
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string MGMEEDDACBH();

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string NGBNCIGPFCK();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface BADJDEJKIIJ<out TOptions> where TOptions : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	TOptions AFPBILBCKEL
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface JMACELMAENA
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	string NDOGKHNBKEF
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class IIGENIOMKIB<T> : ReadOnlySequenceSegment<T>, IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static IIGENIOMKIB<T>? ALCGKOBCGIH;

	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private static object AEKKLOCFBLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private IMemoryOwner<T>? MJBFFEPJAME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private bool PHCLLKDBNLF;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool DOGEECCMHOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xB041D0", Offset = "0xB02BD0", VA = "0x180B041D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x52EEFA0", Offset = "0x52ED9A0", VA = "0x1852EEFA0")]
	private static IIGENIOMKIB<T> NHFEDHBMNIB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x52EE1A0", Offset = "0x52ECBA0", VA = "0x1852EE1A0")]
	private static void EHFIAMAIMKP(IIGENIOMKIB<T> ILFKKOOOMDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x52EF700", Offset = "0x52EE100", VA = "0x1852EF700")]
	private IIGENIOMKIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x52EEC20", Offset = "0x52ED620", VA = "0x1852EEC20")]
	public static IIGENIOMKIB<T> MLAHKGEEKLJ(ReadOnlyMemory<T> FLHOBJPLFGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x52EEA20", Offset = "0x52ED420", VA = "0x1852EEA20")]
	public static IIGENIOMKIB<T> MLAHKGEEKLJ(IMemoryOwner<T> PPGKPLHMHIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x52EDB70", Offset = "0x52EC570", VA = "0x1852EDB70")]
	public static void BCJLFMOCMMM(IIGENIOMKIB<T> PJALKHMAFHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x52EDD60", Offset = "0x52EC760", VA = "0x1852EDD60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x52EDC90", Offset = "0x52EC690", VA = "0x1852EDC90")]
	public IIGENIOMKIB<T> CPDPAOLJONG(IMemoryOwner<T> PPGKPLHMHIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x52EE840", Offset = "0x52ED240", VA = "0x1852EE840")]
	private void HDLDKABLPCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x52EE730", Offset = "0x52ED130", VA = "0x1852EE730")]
	private IIGENIOMKIB<T> GPBKOJAHJEP(IIGENIOMKIB<T> ILFKKOOOMDI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class HDDGNODJBJC : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x8663440", Offset = "0x8661E40", VA = "0x188663440")]
	public HDDGNODJBJC(string JEBOHIALEMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class HLIACCKJFJM<TOk> : HDDGNODJBJC where TOk : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly TOk KEOGHOIFMHC;

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x51BE510", Offset = "0x51BCF10", VA = "0x1851BE510")]
	private HLIACCKJFJM([In] TOk IAJPDIHEPIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x51BE440", Offset = "0x51BCE40", VA = "0x1851BE440")]
	public static HLIACCKJFJM<TOk> KDBDJPAJKDJ([In] TOk IAJPDIHEPIP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class EHGFHEDDPAD : Stream
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly ReadOnlySequence<byte> AKCCICONGOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private SequencePosition FDFKLCIEKGG;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public override bool AMMOLAMGIGD
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xAC8240", Offset = "0xAC6C40", VA = "0x180AC8240", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public override bool OEGMIEBPEAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xAC8240", Offset = "0xAC6C40", VA = "0x180AC8240", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public override bool HDMMAPNIABO
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public override long EJCBNJPPPEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8662350", Offset = "0x8660D50", VA = "0x188662350", Slot = "12")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public override long NGNFCFGNCAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x86623B0", Offset = "0x8660DB0", VA = "0x1886623B0", Slot = "13")]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8662480", Offset = "0x8660E80", VA = "0x188662480", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x8662280", Offset = "0x8660C80", VA = "0x188662280")]
	public EHGFHEDDPAD(ReadOnlySequence<byte> DFJFBOBNOAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x8661E30", Offset = "0x8660830", VA = "0x188661E30", Slot = "33")]
	public override long Seek(long JBCPGNDLJHB, SeekOrigin IIBHNKFDNNM)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x86619B0", Offset = "0x86603B0", VA = "0x1886619B0", Slot = "35")]
	public override int Read(byte[] FPGJFOLEKAK, int JBCPGNDLJHB, int MHMCOJIKNCI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "23")]
	public override void Flush()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x86621C0", Offset = "0x8660BC0", VA = "0x1886621C0", Slot = "34")]
	public override void SetLength(long KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x8662220", Offset = "0x8660C20", VA = "0x188662220", Slot = "38")]
	public override void Write(byte[] FPGJFOLEKAK, int JBCPGNDLJHB, int MHMCOJIKNCI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public readonly struct FEENKEDBOAD<TOk, TErr> : IEquatable<FEENKEDBOAD<TOk, TErr>> where TOk : notnull where TErr : notnull
{
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private static readonly EqualityComparer<TErr> PNGHNHHMEMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	internal readonly TErr KNDOEEHFBJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	internal readonly TOk KEOGHOIFMHC;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool GHOGKIKIEJC
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x4FC0F40", Offset = "0x4FBF940", VA = "0x184FC0F40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool AOLOEECGMJB
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x4FBF300", Offset = "0x4FBDD00", VA = "0x184FBF300")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x4FC6010", Offset = "0x4FC4A10", VA = "0x184FC6010")]
	internal FEENKEDBOAD([In] TErr BLICJMIMONA, [In] TOk IAJPDIHEPIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x4FBB9D0", Offset = "0x4FBA3D0", VA = "0x184FBB9D0")]
	public static FEENKEDBOAD<TOk, TErr> AIGDBCJMKIF([In] TErr BLICJMIMONA)
	{
		return default(FEENKEDBOAD<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x4FC1990", Offset = "0x4FC0390", VA = "0x184FC1990")]
	public static FEENKEDBOAD<TOk, TErr> PLOMBFHGCMK([In] TOk IAJPDIHEPIP)
	{
		return default(FEENKEDBOAD<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x430F540", Offset = "0x430DF40", VA = "0x18430F540")]
	public FEENKEDBOAD<TOk?, UErr?> BNJCBBIOLMC<UErr>()
	{
		return default(FEENKEDBOAD<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x4311B60", Offset = "0x4310560", VA = "0x184311B60")]
	public FEENKEDBOAD<UOk?, TErr?> MJCFAHBIOGA<UOk>()
	{
		return default(FEENKEDBOAD<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x4310B20", Offset = "0x430F520", VA = "0x184310B20")]
	public FEENKEDBOAD<UOk?, TErr?> GGPFBJEDMOC<UOk>()
	{
		return default(FEENKEDBOAD<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x430F320", Offset = "0x430DD20", VA = "0x18430F320")]
	public FEENKEDBOAD<TOk?, UErr?> BAEPMAHNOLB<UErr>()
	{
		return default(FEENKEDBOAD<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x4FBC480", Offset = "0x4FBAE80", VA = "0x184FBC480")]
	public FEENKEDBOAD<LJBIGLJNMFO, TErr> BBBIMEIGAFJ()
	{
		return default(FEENKEDBOAD<LJBIGLJNMFO, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x4FBFC80", Offset = "0x4FBE680", VA = "0x184FBFC80")]
	public static bool NOPNAEDOCOI([In] FEENKEDBOAD<TOk, TErr> IIIICGAEODJ, [In] FEENKEDBOAD<TOk, TErr> ELBIKJBAIEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4FBCB40", Offset = "0x4FBB540", VA = "0x184FBCB40", Slot = "4")]
	public bool Equals(FEENKEDBOAD<TOk, TErr> GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x4FBCC10", Offset = "0x4FBB610", VA = "0x184FBCC10", Slot = "0")]
	public override bool Equals(object GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x4FBEBC0", Offset = "0x4FBD5C0", VA = "0x184FBEBC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x4FC35D0", Offset = "0x4FC1FD0", VA = "0x184FC35D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class LLKELCJLMMM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private struct AJFFMLCCPIA<TOk, TErr> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public AsyncTaskMethodBuilder<TOk> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public Task<FEENKEDBOAD<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private TaskAwaiter<FEENKEDBOAD<TOk, TErr>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x5406EB0", Offset = "0x54058B0", VA = "0x185406EB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x5407E50", Offset = "0x5406850", VA = "0x185407E50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private struct PNJPANEKLCN<TOk, TErr> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public AsyncTaskMethodBuilder<FEENKEDBOAD<LJBIGLJNMFO, TErr>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public Task<FEENKEDBOAD<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private TaskAwaiter<FEENKEDBOAD<TOk, TErr>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x5CCDAC0", Offset = "0x5CCC4C0", VA = "0x185CCDAC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x5151590", Offset = "0x514FF90", VA = "0x185151590", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct KCNCIFMFPME<TOk, TErr> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public Task<FEENKEDBOAD<TOk, TErr>> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private TaskAwaiter<FEENKEDBOAD<TOk, TErr>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x56433F0", Offset = "0x5641DF0", VA = "0x1856433F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x5643970", Offset = "0x5642370", VA = "0x185643970", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x3E751E0", Offset = "0x3E73BE0", VA = "0x183E751E0")]
	public static FEENKEDBOAD<TOk?, TErr?> KEOGHOIFMHC<TOk, TErr>([In] this FEENKEDBOAD<TOk, TErr> DKGBCFDLMOI, [In] TOk IAJPDIHEPIP)
	{
		return default(FEENKEDBOAD<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x3E75270", Offset = "0x3E73C70", VA = "0x183E75270")]
	public static FEENKEDBOAD<LJBIGLJNMFO, TErr?> KEOGHOIFMHC<TErr>([In] this FEENKEDBOAD<LJBIGLJNMFO, TErr> DKGBCFDLMOI)
	{
		return default(FEENKEDBOAD<LJBIGLJNMFO, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3E751E0", Offset = "0x3E73BE0", VA = "0x183E751E0")]
	public static FEENKEDBOAD<TOk?, TErr?> KNDOEEHFBJD<TOk, TErr>([In] this FEENKEDBOAD<TOk, TErr> DKGBCFDLMOI, [In] TErr BLICJMIMONA)
	{
		return default(FEENKEDBOAD<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x3E75A40", Offset = "0x3E74440", VA = "0x183E75A40")]
	public static TOk? PKOOICNIEPP<TOk, TErr>([In] this FEENKEDBOAD<TOk, TErr> DKGBCFDLMOI)
	{
		return (TOk?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x3E75610", Offset = "0x3E74010", VA = "0x183E75610")]
	[AsyncStateMachine(typeof(AJFFMLCCPIA<, >))]
	public static Task<TOk?>? OEBPGAGOHBH<TOk, TErr>(this Task<FEENKEDBOAD<TOk, TErr>> DKGBCFDLMOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x3E71F30", Offset = "0x3E70930", VA = "0x183E71F30")]
	public static TErr? BFNPGHMMCLA<TErr, TOk>([In] this FEENKEDBOAD<TOk, TErr> DKGBCFDLMOI)
	{
		return (TErr?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x3E737D0", Offset = "0x3E721D0", VA = "0x183E737D0")]
	public static bool GENPNMOHKAF<TOk, TErr, UErr, UOk>([In] this FEENKEDBOAD<TOk, TErr> DKGBCFDLMOI, [Out] FEENKEDBOAD<UOk, UErr> LLLIPMPKEGE) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x3E72D80", Offset = "0x3E71780", VA = "0x183E72D80")]
	public static bool EMOIKMFMHLI<TOk, TErr>([In] this FEENKEDBOAD<TOk, TErr> DKGBCFDLMOI, [Out] TOk IAJPDIHEPIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x3E74DB0", Offset = "0x3E737B0", VA = "0x183E74DB0")]
	public static bool HKDLDOGHOBH<TOk, TErr>([In] this FEENKEDBOAD<TOk, TErr> DKGBCFDLMOI, [Out][NotNullWhen(true)] TErr BLICJMIMONA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x3E72280", Offset = "0x3E70C80", VA = "0x183E72280")]
	public static bool BIPLBEABIIP<TOk, TErr>([In] this FEENKEDBOAD<TOk, TErr> DKGBCFDLMOI, [Out][NotNullWhen(true)] TOk IAJPDIHEPIP, [Out][NotNullWhen(false)] TErr BLICJMIMONA) where TOk : notnull where TErr : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x3E750C0", Offset = "0x3E73AC0", VA = "0x183E750C0")]
	public static bool JICOIMBKJPF<TOk, TErr>([In] this FEENKEDBOAD<TOk, TErr> DKGBCFDLMOI, [Out][NotNullWhen(true)] TOk IAJPDIHEPIP, [Out] FEENKEDBOAD<TOk, TErr> LLLIPMPKEGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3E73470", Offset = "0x3E71E70", VA = "0x183E73470")]
	public static bool GENPNMOHKAF<TOk, TErr, UErr, UOk>([In] this FEENKEDBOAD<TOk, TErr> DKGBCFDLMOI, [Out][NotNullWhen(true)] TOk IAJPDIHEPIP, [Out] FEENKEDBOAD<UOk, UErr> LLLIPMPKEGE) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3E74800", Offset = "0x3E73200", VA = "0x183E74800")]
	public static bool GHBMBHFIOHC<TOk, TErr>([In] this FEENKEDBOAD<TOk, TErr> DKGBCFDLMOI, [Out][NotNullWhen(true)] TOk IAJPDIHEPIP, [Out] FEENKEDBOAD<LJBIGLJNMFO, TErr> LLLIPMPKEGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x3E725A0", Offset = "0x3E70FA0", VA = "0x183E725A0")]
	public static FEENKEDBOAD<UOk, UErr> EBACNDFLCMA<UOk, UErr, TOk, TErr>([In] this FEENKEDBOAD<TOk, TErr> DKGBCFDLMOI, [In] FEENKEDBOAD<UOk, UErr> HBELCFIJGKE) where TOk : UOk where TErr : UErr
	{
		return default(FEENKEDBOAD<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x3E73010", Offset = "0x3E71A10", VA = "0x183E73010")]
	public static FEENKEDBOAD<TOk?[]?, TErr?> FOGMAKKCMCM<TOk, TErr>(this IEnumerable<FEENKEDBOAD<TOk, TErr>> DKGBCFDLMOI)
	{
		return default(FEENKEDBOAD<TOk[], TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x3E74E80", Offset = "0x3E73880", VA = "0x183E74E80")]
	public static FEENKEDBOAD<UOk?, TErr?> IJOJCFOJHEJ<UOk, TErr, TOk>([In] this FEENKEDBOAD<TOk, TErr> DKGBCFDLMOI, Func<TOk, UOk> NCDJMHIDAKA)
	{
		return default(FEENKEDBOAD<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x3E75370", Offset = "0x3E73D70", VA = "0x183E75370")]
	[AsyncStateMachine(typeof(PNJPANEKLCN<, >))]
	public static Task<FEENKEDBOAD<LJBIGLJNMFO, TErr?>>? MLGHLDNFMBI<TErr, TOk>(this Task<FEENKEDBOAD<TOk, TErr>> DKGBCFDLMOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x3E74B60", Offset = "0x3E73560", VA = "0x183E74B60")]
	[AsyncStateMachine(typeof(KCNCIFMFPME<, >))]
	public static Task<bool>? GHOGKIKIEJC<TOk, TErr>(this Task<FEENKEDBOAD<TOk, TErr>> FLAIIHBKGBI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class JGIHNGMHIPF<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x4479420", Offset = "0x4477E20", VA = "0x184479420")]
	public static FEENKEDBOAD<TOk, T> KEOGHOIFMHC<TOk>([In] TOk IAJPDIHEPIP) where TOk : notnull
	{
		return default(FEENKEDBOAD<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x5538940", Offset = "0x5537340", VA = "0x185538940")]
	public static FEENKEDBOAD<LJBIGLJNMFO, T> KEOGHOIFMHC()
	{
		return default(FEENKEDBOAD<LJBIGLJNMFO, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x4479420", Offset = "0x4477E20", VA = "0x184479420")]
	public static FEENKEDBOAD<T, TErr> KNDOEEHFBJD<TErr>([In] TErr BLICJMIMONA) where TErr : notnull
	{
		return default(FEENKEDBOAD<T, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct HENEDMCKFAC<TKey, TValue> where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly ANDGFGCFNIA IALLBEEIPEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly Dictionary<TKey, TValue> GEKPMNGINKN;

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x51AD910", Offset = "0x51AC310", VA = "0x1851AD910")]
	public static HENEDMCKFAC<TKey, TValue> KDBDJPAJKDJ(string IJNPIDPIBFP)
	{
		return default(HENEDMCKFAC<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x51ADA30", Offset = "0x51AC430", VA = "0x1851ADA30")]
	internal HENEDMCKFAC(Dictionary<TKey, TValue> KMAFNKGMDCF, ANDGFGCFNIA NDAJKEDLMLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x51AD860", Offset = "0x51AC260", VA = "0x1851AD860")]
	public BJDDHJDFAEK<TKey, TValue> GFONGHCDGIM([Out] Dictionary<TKey, TValue> KMAFNKGMDCF)
	{
		return default(BJDDHJDFAEK<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public readonly struct BJDDHJDFAEK<TKey, TValue> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly Dictionary<TKey, TValue> GEKPMNGINKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly GOMNOGFDODI OGIIABLMDFO;

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x2DE3A20", Offset = "0x2DE2420", VA = "0x182DE3A20")]
	internal BJDDHJDFAEK(Dictionary<TKey, TValue> KMAFNKGMDCF, GOMNOGFDODI LCLDMCBAFNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5122DC0", Offset = "0x51217C0", VA = "0x185122DC0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public readonly struct IOPHJMKCGFH<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly ANDGFGCFNIA IALLBEEIPEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly HashSet<T> GEKPMNGINKN;

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x51AD910", Offset = "0x51AC310", VA = "0x1851AD910")]
	public static IOPHJMKCGFH<T> KDBDJPAJKDJ(string IJNPIDPIBFP)
	{
		return default(IOPHJMKCGFH<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x51ADA30", Offset = "0x51AC430", VA = "0x1851ADA30")]
	internal IOPHJMKCGFH(HashSet<T> KMAFNKGMDCF, ANDGFGCFNIA NDAJKEDLMLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x51AD860", Offset = "0x51AC260", VA = "0x1851AD860")]
	public JNKNBMGGKLB<T> GFONGHCDGIM([Out] HashSet<T> KMAFNKGMDCF)
	{
		return default(JNKNBMGGKLB<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public readonly struct JNKNBMGGKLB<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly HashSet<T> GEKPMNGINKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly GOMNOGFDODI OGIIABLMDFO;

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x2DE3A20", Offset = "0x2DE2420", VA = "0x182DE3A20")]
	internal JNKNBMGGKLB(HashSet<T> KMAFNKGMDCF, GOMNOGFDODI LCLDMCBAFNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x5122DC0", Offset = "0x51217C0", VA = "0x185122DC0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public readonly struct ALKGOAFADIC<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly ANDGFGCFNIA IALLBEEIPEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly Stack<T> GEKPMNGINKN;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x51AD910", Offset = "0x51AC310", VA = "0x1851AD910")]
	public static ALKGOAFADIC<T> KDBDJPAJKDJ(string IJNPIDPIBFP)
	{
		return default(ALKGOAFADIC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x51ADA30", Offset = "0x51AC430", VA = "0x1851ADA30")]
	internal ALKGOAFADIC(Stack<T> KMAFNKGMDCF, ANDGFGCFNIA NDAJKEDLMLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x51AD860", Offset = "0x51AC260", VA = "0x1851AD860")]
	public GCJIBNGCPPG<T> GFONGHCDGIM([Out] Stack<T> KMAFNKGMDCF)
	{
		return default(GCJIBNGCPPG<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public readonly struct GCJIBNGCPPG<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly Stack<T> GEKPMNGINKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly GOMNOGFDODI OGIIABLMDFO;

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x2DE3A20", Offset = "0x2DE2420", VA = "0x182DE3A20")]
	internal GCJIBNGCPPG(Stack<T> KMAFNKGMDCF, GOMNOGFDODI LCLDMCBAFNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x5122DC0", Offset = "0x51217C0", VA = "0x185122DC0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[DefaultMember("Item")]
public sealed class DOJGMEHIFAI<T> : IEnumerable<T>, IEnumerable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private readonly struct HMAALFPFLCC : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly DOJGMEHIFAI<T> OKDHLAPLDHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly int AONFAHFCFLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly bool NOKKLCMHAJK;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x29E3BD0", Offset = "0x29E25D0", VA = "0x1829E3BD0")]
		public HMAALFPFLCC(DOJGMEHIFAI<T> FDMAPEJEBGO, int CMMDDBLDGPN, bool GHCCEJLCGIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x51D4270", Offset = "0x51D2C70", VA = "0x1851D4270")]
		public DOJGMEHIFAI<T>.AFLNGPGIHEC FIIFAFDLDFC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x51D4350", Offset = "0x51D2D50", VA = "0x1851D4350", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x51D4350", Offset = "0x51D2D50", VA = "0x1851D4350", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public sealed class AFLNGPGIHEC : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly DOJGMEHIFAI<T> OKDHLAPLDHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly int KOOHJPIKEGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private int PKCPLKGODML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private readonly bool NOKKLCMHAJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private bool MCFPLKFGABP;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public T IGCJDJEKHNM
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x530DCF0", Offset = "0x530C6F0", VA = "0x18530DCF0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x530DED0", Offset = "0x530C8D0", VA = "0x18530DED0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x530E0C0", Offset = "0x530CAC0", VA = "0x18530E0C0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x530E250", Offset = "0x530CC50", VA = "0x18530E250")]
		public AFLNGPGIHEC(DOJGMEHIFAI<T> FDMAPEJEBGO, int CMMDDBLDGPN, bool GHCCEJLCGIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x530DDB0", Offset = "0x530C7B0", VA = "0x18530DDB0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x530DE40", Offset = "0x530C840", VA = "0x18530DE40", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class EJMPIACAONM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public EJMPIACAONM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x4B2F2A0", Offset = "0x4B2DCA0", VA = "0x184B2F2A0")]
		internal T DFKCOOJLNMK(int _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly T[] IHMBMMLLFFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private int PKCPLKGODML;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int APDADFDGIPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x466AED0", Offset = "0x46698D0", VA = "0x18466AED0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public T IGCJDJEKHNM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x466ABA0", Offset = "0x46695A0", VA = "0x18466ABA0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public T BPADAMHNFHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x466AEA0", Offset = "0x46698A0", VA = "0x18466AEA0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public T PCCJLFHFGOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x466AD50", Offset = "0x4669750", VA = "0x18466AD50")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public int EJCBNJPPPEE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x29A0D50", Offset = "0x299F750", VA = "0x1829A0D50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x1DD2680", Offset = "0x1DD1080", VA = "0x181DD2680")]
	private static int LNGHAAJOPOA(int KABGMIEBEFC, int AJDEGEPLAEO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x466AF40", Offset = "0x4669940", VA = "0x18466AF40")]
	public DOJGMEHIFAI(int BCAJFCGHDKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x466B190", Offset = "0x4669B90", VA = "0x18466B190")]
	public DOJGMEHIFAI(int BCAJFCGHDKI, Func<T> CIECMBEFPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x466B3A0", Offset = "0x4669DA0", VA = "0x18466B3A0")]
	public DOJGMEHIFAI(T[] GLPDKCPPLJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x466ADB0", Offset = "0x46697B0", VA = "0x18466ADB0")]
	public void KFJFFLECJPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x466ADE0", Offset = "0x46697E0", VA = "0x18466ADE0")]
	public IEnumerable<T> KIDNGEAIHKP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x466ABD0", Offset = "0x46695D0", VA = "0x18466ABD0")]
	public DOJGMEHIFAI<T>.AFLNGPGIHEC FIIFAFDLDFC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x466AF10", Offset = "0x4669910", VA = "0x18466AF10", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x466AF10", Offset = "0x4669910", VA = "0x18466AF10", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public static class BAJHEELNOIL
{
	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x3B1F7A0", Offset = "0x3B1E1A0", VA = "0x183B1F7A0")]
	public static DOJGMEHIFAI<T> KDBDJPAJKDJ<T>(int BCAJFCGHDKI, Func<T> CIECMBEFPLK) where T : notnull
	{
		return null;
	}
}
namespace RecRoom.NoEngine.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public struct RRColor : IEquatable<RRColor>, IFormattable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public float r;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public float g;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public float b;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public float a;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public static RRColor White
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x7201760", Offset = "0x7200160", VA = "0x187201760")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public static RRColor Green
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x8665640", Offset = "0x8664040", VA = "0x188665640")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public static RRColor Red
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x8665660", Offset = "0x8664060", VA = "0x188665660")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public static RRColor Yellow
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x8665680", Offset = "0x8664080", VA = "0x188665680")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public static RRColor Cyan
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x8665620", Offset = "0x8664020", VA = "0x188665620")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x2B496C0", Offset = "0x2B480C0", VA = "0x182B496C0")]
		public RRColor(float OLMEHKPIJHD, float AMANNJNDJGG, float MIBIEOGGIAP, float EICJFDNFOCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x84DCC10", Offset = "0x84DB610", VA = "0x1884DCC10", Slot = "4")]
		public bool Equals(RRColor GOCNHGEHNFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x8665270", Offset = "0x8663C70", VA = "0x188665270", Slot = "0")]
		public override bool Equals(object GOCNHGEHNFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x8665370", Offset = "0x8663D70", VA = "0x188665370", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x86653F0", Offset = "0x8663DF0", VA = "0x1886653F0", Slot = "5")]
		public string ToString(string JBHFIGLCFLB, IFormatProvider ALDFMPMDBHO)
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public struct RRColor32 : IEquatable<RRColor32>, IFormattable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private int rgba;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public byte r;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public byte g;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public byte b;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public byte a;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public static RRColor32 White
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x8665210", Offset = "0x8663C10", VA = "0x188665210")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public static RRColor32 Green
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x86651B0", Offset = "0x8663BB0", VA = "0x1886651B0")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public static RRColor32 Red
		{
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x86651E0", Offset = "0x8663BE0", VA = "0x1886651E0")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public static RRColor32 Yellow
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x8665240", Offset = "0x8663C40", VA = "0x188665240")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public static RRColor32 Cyan
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x8665180", Offset = "0x8663B80", VA = "0x188665180")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6362370", Offset = "0x6360D70", VA = "0x186362370")]
		public RRColor32(byte OLMEHKPIJHD, byte AMANNJNDJGG, byte MIBIEOGGIAP, byte EICJFDNFOCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x252D260", Offset = "0x252BC60", VA = "0x18252D260", Slot = "4")]
		public bool Equals(RRColor32 GOCNHGEHNFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x8664CE0", Offset = "0x86636E0", VA = "0x188664CE0", Slot = "0")]
		public override bool Equals(object GOCNHGEHNFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x1605710", Offset = "0x1604110", VA = "0x181605710", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x8664DD0", Offset = "0x86637D0", VA = "0x188664DD0")]
		public static RRColor32 HDPJNBPLGPE(RRColor DMCCCPMAFCP)
		{
			return default(RRColor32);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x8664D60", Offset = "0x8663760", VA = "0x188664D60")]
		public static RRColor HDPJNBPLGPE(RRColor32 DMCCCPMAFCP)
		{
			return default(RRColor);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x8664F20", Offset = "0x8663920", VA = "0x188664F20", Slot = "5")]
		public string ToString(string JBHFIGLCFLB, IFormatProvider ALDFMPMDBHO)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public sealed class JJKKPHKIKMD<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public readonly struct IOGHEKGHCMN : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private readonly JJKKPHKIKMD<T> JJNIMMONHFI;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public T AFPBILBCKEL
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x5316E50", Offset = "0x5315850", VA = "0x185316E50")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x5316E70", Offset = "0x5315870", VA = "0x185316E70", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0xECC590", Offset = "0xECAF90", VA = "0x180ECC590")]
		public IOGHEKGHCMN(JJKKPHKIKMD<T> JJNIMMONHFI)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct FAHBGHFBCNO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public AsyncTaskMethodBuilder<IOGHEKGHCMN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public JJKKPHKIKMD<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x4FAB070", Offset = "0x4FA9A70", VA = "0x184FAB070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x4B31420", Offset = "0x4B2FE20", VA = "0x184B31420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly SemaphoreSlim FDMBKFMJDDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private T FOJLDKCOGHI;

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x5544900", Offset = "0x5543300", VA = "0x185544900")]
	public JJKKPHKIKMD([In] T FOJLDKCOGHI, int HMOCMIILBCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x55447A0", Offset = "0x55431A0", VA = "0x1855447A0")]
	public JJKKPHKIKMD([In] T FOJLDKCOGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x5544690", Offset = "0x5543090", VA = "0x185544690", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x55441D0", Offset = "0x5542BD0", VA = "0x1855441D0")]
	public IOGHEKGHCMN BHOPLKILJCH()
	{
		return default(IOGHEKGHCMN);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x5544450", Offset = "0x5542E50", VA = "0x185544450")]
	[AsyncStateMachine(typeof(JJKKPHKIKMD<>.FAHBGHFBCNO))]
	public Task<JJKKPHKIKMD<T>.IOGHEKGHCMN> COECGNOLELD(CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x55446D0", Offset = "0x55430D0", VA = "0x1855446D0")]
	public void OCFKCPCFMCE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class IKGBGNOAEMC
{
	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x8663A30", Offset = "0x8662430", VA = "0x188663A30")]
	public static JJKKPHKIKMD<LJBIGLJNMFO> KDBDJPAJKDJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x32D1CC0", Offset = "0x32D06C0", VA = "0x1832D1CC0")]
	public static JJKKPHKIKMD<T> KDBDJPAJKDJ<T>([In] T FOJLDKCOGHI) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public sealed class GEGGLDDMMHC<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public readonly struct BLKKKKNMAJK : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private readonly GEGGLDDMMHC<T> CILDBEAKMCG;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public T AFPBILBCKEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x5543B60", Offset = "0x5542560", VA = "0x185543B60")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x677B9D0", Offset = "0x677A3D0", VA = "0x18677B9D0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0xECC590", Offset = "0xECAF90", VA = "0x180ECC590")]
		internal BLKKKKNMAJK(GEGGLDDMMHC<T> JJNIMMONHFI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public readonly struct JIKECADILAL : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private readonly GEGGLDDMMHC<T> CILDBEAKMCG;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public T AFPBILBCKEL
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x5543B60", Offset = "0x5542560", VA = "0x185543B60")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x5543B80", Offset = "0x5542580", VA = "0x185543B80", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0xECC590", Offset = "0xECAF90", VA = "0x180ECC590")]
		internal JIKECADILAL(GEGGLDDMMHC<T> JJNIMMONHFI)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private struct KHHMPIJENPA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public AsyncTaskMethodBuilder<JIKECADILAL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public GEGGLDDMMHC<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private JJKKPHKIKMD<LJBIGLJNMFO>.IOGHEKGHCMN <writeLock>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private TaskAwaiter<JJKKPHKIKMD<LJBIGLJNMFO>.IOGHEKGHCMN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x56644B0", Offset = "0x5662EB0", VA = "0x1856644B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x4B31420", Offset = "0x4B2FE20", VA = "0x184B31420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly JJKKPHKIKMD<int> LPAJKDBEDGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly JJKKPHKIKMD<LJBIGLJNMFO> EGDLGFPCBMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly JJKKPHKIKMD<LJBIGLJNMFO> IIKADFLMNBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private T JHFCBDNEEJN;

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x5125F30", Offset = "0x5124930", VA = "0x185125F30")]
	internal GEGGLDDMMHC(JJKKPHKIKMD<int> LBDFAAEOBHJ, JJKKPHKIKMD<LJBIGLJNMFO> JCMICEBIPGH, JJKKPHKIKMD<LJBIGLJNMFO> LNIJKNIFDPJ, [In] T FOJLDKCOGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x51254A0", Offset = "0x5123EA0", VA = "0x1851254A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x51258F0", Offset = "0x51242F0", VA = "0x1851258F0")]
	public BLKKKKNMAJK NDHDDMEPDIA()
	{
		return default(BLKKKKNMAJK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x5125800", Offset = "0x5124200", VA = "0x185125800")]
	public JIKECADILAL MGCEPLPNMLJ()
	{
		return default(JIKECADILAL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x5125240", Offset = "0x5123C40", VA = "0x185125240")]
	[AsyncStateMachine(typeof(GEGGLDDMMHC<>.KHHMPIJENPA))]
	public Task<GEGGLDDMMHC<T>.JIKECADILAL> BPNPFBCJNAC(CancellationToken AHOMALKMHKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class DBMEJFKMHCA
{
	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x8660960", Offset = "0x865F360", VA = "0x188660960")]
	public static GEGGLDDMMHC<LJBIGLJNMFO> KDBDJPAJKDJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x3BCAF50", Offset = "0x3BC9950", VA = "0x183BCAF50")]
	public static GEGGLDDMMHC<T> KDBDJPAJKDJ<T>([In] T FOJLDKCOGHI) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public sealed class LOKOBNLIHCL<TData> : EFLAGBIEFMN where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public readonly string LBGIPDADNFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public readonly TData AMLFHELBNMB;

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "7")]
	public override string NGBNCIGPFCK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x5749680", Offset = "0x5748080", VA = "0x185749680")]
	internal LOKOBNLIHCL(string JEBOHIALEMJ, [In] TData BLPDDGCLNPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class NNCIPAMEHNI
{
	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x86645C0", Offset = "0x8662FC0", VA = "0x1886645C0")]
	public static LOKOBNLIHCL<LJBIGLJNMFO> KDBDJPAJKDJ(string JEBOHIALEMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x32D1E30", Offset = "0x32D0830", VA = "0x1832D1E30")]
	public static LOKOBNLIHCL<TData> KDBDJPAJKDJ<TData>(string JEBOHIALEMJ, [In] TData BLPDDGCLNPE) where TData : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class PDOPCJJNCCK
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public delegate Task GGIEJBEDNPL<in TArg>(TArg MFHBGCBJCJO, CancellationToken MFKHKDDANII);

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public delegate Task<TResult> HMHOPIAIPPH<in TArg, TResult>(TArg MFHBGCBJCJO, CancellationToken MFKHKDDANII);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct GOCKLJDFBLA<TArg> : IAsyncStateMachine where TArg : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public PDOPCJJNCCK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public GGIEJBEDNPL<TArg> taskFactory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public TArg arg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private CancellationTokenSource <newSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x51585A0", Offset = "0x5156FA0", VA = "0x1851585A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x5158BD0", Offset = "0x51575D0", VA = "0x185158BD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct JPMFGMFMOHH<TArg, TResult> : IAsyncStateMachine where TArg : notnull where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public PDOPCJJNCCK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public HMHOPIAIPPH<TArg, TResult> taskFactory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public TArg arg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private CancellationTokenSource <newSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x55911C0", Offset = "0x558FBC0", VA = "0x1855911C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x45F8A80", Offset = "0x45F7480", VA = "0x1845F8A80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private CancellationTokenSource? LFMLMPLANEK;

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x3F64BE0", Offset = "0x3F635E0", VA = "0x183F64BE0")]
	[AsyncStateMachine(typeof(GOCKLJDFBLA<>))]
	public Task AEOBHGFBIDI<TArg>(GGIEJBEDNPL<TArg> EGKHOOGMLHO, TArg MFHBGCBJCJO, [Optional] CancellationToken ICODIHINNBH) where TArg : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x3F64D10", Offset = "0x3F63710", VA = "0x183F64D10")]
	[AsyncStateMachine(typeof(JPMFGMFMOHH<, >))]
	public Task<TResult> AEOBHGFBIDI<TResult, TArg>(HMHOPIAIPPH<TArg, TResult> EGKHOOGMLHO, TArg MFHBGCBJCJO, [Optional] CancellationToken ICODIHINNBH) where TResult : notnull where TArg : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x8664A20", Offset = "0x8663420", VA = "0x188664A20")]
	private static void JIKALMKPJBE(CancellationTokenSource? LFMLMPLANEK, CancellationTokenSource BMAILBPBMBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x86649E0", Offset = "0x86633E0", VA = "0x1886649E0")]
	private void IKFPPOKHOAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x8664A40", Offset = "0x8663440", VA = "0x188664A40")]
	private static CancellationTokenSource MOLHJDGEALM(CancellationToken ICODIHINNBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public PDOPCJJNCCK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public sealed class ANDGFGCFNIA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	internal bool IAFHNDMIALD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly string JOOPCKANDBO;

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0xFC6340", Offset = "0xFC4D40", VA = "0x180FC6340")]
	private ANDGFGCFNIA(bool GMNHJAAIEAN, string BFDAAAKLPOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x86607B0", Offset = "0x865F1B0", VA = "0x1886607B0")]
	public static ANDGFGCFNIA KDBDJPAJKDJ(string BFDAAAKLPOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x86606F0", Offset = "0x865F0F0", VA = "0x1886606F0")]
	public GOMNOGFDODI GFONGHCDGIM()
	{
		return default(GOMNOGFDODI);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public readonly struct GOMNOGFDODI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly ANDGFGCFNIA MLODABLCFGK;

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0xECC590", Offset = "0xECAF90", VA = "0x180ECC590")]
	internal GOMNOGFDODI(ANDGFGCFNIA IJNPIDPIBFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x8663420", Offset = "0x8661E20", VA = "0x188663420", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[Obsolete("Use SimpleTokenFlag or WeakTokenFlag<T> instead")]
public sealed class NPGIIPPFGLB<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class HOKBCKFEPCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public HOKBCKFEPCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x52208C0", Offset = "0x521F2C0", VA = "0x1852208C0")]
		internal int KEJNCMOKAMC(int i, T token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private HashSet<T>? MBCKBFGFKCJ;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public IReadOnlyCollection<T> LJEPEAPMABK
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x5A84F40", Offset = "0x5A83940", VA = "0x185A84F40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool JJKMCPMLANG
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x54D8110", Offset = "0x54D6B10", VA = "0x1854D8110")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public int BEFNAMGOJCC
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0xAB3B20", Offset = "0xAB2520", VA = "0x180AB3B20")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0xAB33F0", Offset = "0xAB1DF0", VA = "0x180AB33F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x5A84DD0", Offset = "0x5A837D0", VA = "0x185A84DD0")]
	public bool HMDNMGBNKIA(T MFKHKDDANII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x5A84F70", Offset = "0x5A83970", VA = "0x185A84F70")]
	public bool MCKODPOBNPM(T MFKHKDDANII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x5A84D00", Offset = "0x5A83700", VA = "0x185A84D00")]
	public bool GMMHHEEELIA(T MFKHKDDANII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x5A84D40", Offset = "0x5A83740", VA = "0x185A84D40")]
	public void HEEKMINFJAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x5A85090", Offset = "0x5A83A90", VA = "0x185A85090", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public NPGIIPPFGLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public sealed class GBIFDHMBLCB
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private sealed class DEENEONLBOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public DEENEONLBOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x8660EC0", Offset = "0x865F8C0", VA = "0x188660EC0")]
		internal int KEJNCMOKAMC(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private HashSet<object>? MBCKBFGFKCJ;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public IReadOnlyCollection<object> LJEPEAPMABK
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x8662820", Offset = "0x8661220", VA = "0x188662820")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool JJKMCPMLANG
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x8662660", Offset = "0x8661060", VA = "0x188662660")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int BEFNAMGOJCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0xAB3B20", Offset = "0xAB2520", VA = "0x180AB3B20")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0xAB33F0", Offset = "0xAB1DF0", VA = "0x180AB33F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x8662740", Offset = "0x8661140", VA = "0x188662740")]
	public bool HMDNMGBNKIA(object MFKHKDDANII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x86628B0", Offset = "0x86612B0", VA = "0x1886628B0")]
	public bool MCKODPOBNPM(object MFKHKDDANII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x8662670", Offset = "0x8661070", VA = "0x188662670")]
	public bool GMMHHEEELIA(object MFKHKDDANII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x86626D0", Offset = "0x86610D0", VA = "0x1886626D0")]
	public void HEEKMINFJAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x8662950", Offset = "0x8661350", VA = "0x188662950", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public GBIFDHMBLCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class BCNGACGHJNM<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private struct HAKGKKCANHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public float LOCFPHLBLIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public T AFPBILBCKEL;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly Dictionary<object, HAKGKKCANHC> DDMHDBLMGFA;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public virtual T IGBAKDDOHDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x12D63C0", Offset = "0x12D4DC0", VA = "0x1812D63C0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x1CABAA0", Offset = "0x1CAA4A0", VA = "0x181CABAA0", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public object? PEKJHOGPGIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0xAAE120", Offset = "0xAACB20", VA = "0x180AAE120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0xAAE160", Offset = "0xAACB60", VA = "0x180AAE160")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool MCCKGLPLJJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x59F2B60", Offset = "0x59F1560", VA = "0x1859F2B60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x6682CE0", Offset = "0x66816E0", VA = "0x186682CE0")]
	public bool BIIEMNLFGJN(T KMAFNKGMDCF, object MFKHKDDANII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x4AF5DD0", Offset = "0x4AF47D0", VA = "0x184AF5DD0")]
	public bool OECGJOECOOH(object MFKHKDDANII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x59F2B30", Offset = "0x59F1530", VA = "0x1859F2B30")]
	public void EMMOLKMNHIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x6683420", Offset = "0x6681E20", VA = "0x186683420")]
	public bool BMFHANOLGIO(object MFKHKDDANII, [Out] T KMAFNKGMDCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x6681380", Offset = "0x667FD80", VA = "0x186681380")]
	[IDEKGIENJJD("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool APLODEHIMMM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x4AF5E40", Offset = "0x4AF4840", VA = "0x184AF5E40")]
	public BCNGACGHJNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public sealed class IGNLLEDJLPA : AMHHJKGOEAK<OMCJCLBFMAA>
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	internal class FMONEJJFPLB : IEqualityComparer<OMCJCLBFMAA>
	{
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		internal static readonly FMONEJJFPLB FLGHCDNLMND;

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x86625C0", Offset = "0x8660FC0", VA = "0x1886625C0", Slot = "4")]
		public bool Equals(OMCJCLBFMAA FKPKEFAKAOE, OMCJCLBFMAA KEEMKILMOML)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x76FC150", Offset = "0x76FAB50", VA = "0x1876FC150", Slot = "5")]
		public int GetHashCode(OMCJCLBFMAA PMNHIPACJLN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public FMONEJJFPLB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x86639C0", Offset = "0x86623C0", VA = "0x1886639C0")]
	public IGNLLEDJLPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x8663860", Offset = "0x8662260", VA = "0x188663860", Slot = "4")]
	public override bool HMDNMGBNKIA(OMCJCLBFMAA MFKHKDDANII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x8663910", Offset = "0x8662310", VA = "0x188663910", Slot = "5")]
	public override bool MCKODPOBNPM(OMCJCLBFMAA MFKHKDDANII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x86637D0", Offset = "0x86621D0", VA = "0x1886637D0")]
	private static void FNLPLNHCPLK(OMCJCLBFMAA MFKHKDDANII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0xB11A30", Offset = "0xB10430", VA = "0x180B11A30", Slot = "6")]
	protected override string TokenToString(OMCJCLBFMAA MFKHKDDANII)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public sealed class OMCJCLBFMAA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly string FCCONFEOHGJ;

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0xABA5E0", Offset = "0xAB8FE0", VA = "0x180ABA5E0")]
	public OMCJCLBFMAA(string FCCONFEOHGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x8664990", Offset = "0x8663390", VA = "0x188664990", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public abstract class AMHHJKGOEAK<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly IEqualityComparer<T> MELOCBAJPHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private HashSet<T>? MBCKBFGFKCJ;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public IReadOnlyCollection<T> LJEPEAPMABK
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x54D84E0", Offset = "0x54D6EE0", VA = "0x1854D84E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool JJKMCPMLANG
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x54D8110", Offset = "0x54D6B10", VA = "0x1854D8110")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int BEFNAMGOJCC
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0xB0E380", Offset = "0xB0CD80", VA = "0x180B0E380")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0xB0D970", Offset = "0xB0C370", VA = "0x180B0D970")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x54D8DE0", Offset = "0x54D77E0", VA = "0x1854D8DE0")]
	public AMHHJKGOEAK(IEqualityComparer<T> MELOCBAJPHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x54D81E0", Offset = "0x54D6BE0", VA = "0x1854D81E0", Slot = "4")]
	public virtual bool HMDNMGBNKIA(T MFKHKDDANII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x54D8630", Offset = "0x54D7030", VA = "0x1854D8630", Slot = "5")]
	public virtual bool MCKODPOBNPM(T MFKHKDDANII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x54D8150", Offset = "0x54D6B50", VA = "0x1854D8150")]
	public void HEEKMINFJAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract string TokenToString(T MFKHKDDANII);

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x54D8760", Offset = "0x54D7160", VA = "0x1854D8760", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public sealed class FGPFCPIHEJA<T> where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private List<WeakReference<T>>? MBCKBFGFKCJ;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool JJKMCPMLANG
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x4FF63A0", Offset = "0x4FF4DA0", VA = "0x184FF63A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public int BEFNAMGOJCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x4FF67F0", Offset = "0x4FF51F0", VA = "0x184FF67F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x4FF65E0", Offset = "0x4FF4FE0", VA = "0x184FF65E0")]
	public void HMDNMGBNKIA(T MFKHKDDANII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x4FF6950", Offset = "0x4FF5350", VA = "0x184FF6950")]
	public void MCKODPOBNPM(T MFKHKDDANII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x4FF64A0", Offset = "0x4FF4EA0", VA = "0x184FF64A0")]
	public bool GMMHHEEELIA(T MFKHKDDANII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x4FF65C0", Offset = "0x4FF4FC0", VA = "0x184FF65C0")]
	public void HEEKMINFJAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x4FF6AA0", Offset = "0x4FF54A0", VA = "0x184FF6AA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public FGPFCPIHEJA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal static class KMNNJHDAJEB
{
	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x3E5E1D0", Offset = "0x3E5CBD0", VA = "0x183E5E1D0")]
	public static void CDDBADFAPIE<T>(this List<T> GBEHGKLEJFE, int KABGMIEBEFC) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class MNFGJAOKMDC<T> where T : notnull, IEquatable<T>
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	private struct HLPOPIOLGDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public float LOCFPHLBLIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public T AFPBILBCKEL;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly Dictionary<OMCJCLBFMAA, HLPOPIOLGDH> DDMHDBLMGFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly EqualityComparer<T> JDOBPCNONNC;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public virtual T IGBAKDDOHDD
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xAB5CA0", Offset = "0xAB46A0", VA = "0x180AB5CA0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0xAB5C80", Offset = "0xAB4680", VA = "0x180AB5C80", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	private OMCJCLBFMAA? PEKJHOGPGIK
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xAAE150", Offset = "0xAACB50", VA = "0x180AAE150")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool MCCKGLPLJJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x59F2B60", Offset = "0x59F1560", VA = "0x1859F2B60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x59F2970", Offset = "0x59F1370", VA = "0x1859F2970")]
	public bool BIIEMNLFGJN(T KMAFNKGMDCF, OMCJCLBFMAA MFKHKDDANII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x4AF5DD0", Offset = "0x4AF47D0", VA = "0x184AF5DD0")]
	public bool OECGJOECOOH(OMCJCLBFMAA MFKHKDDANII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x59F2B30", Offset = "0x59F1530", VA = "0x1859F2B30")]
	public void EMMOLKMNHIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x59F2A50", Offset = "0x59F1450", VA = "0x1859F2A50")]
	public bool BMFHANOLGIO(OMCJCLBFMAA MFKHKDDANII, [Out] T KMAFNKGMDCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x59F25D0", Offset = "0x59F0FD0", VA = "0x1859F25D0")]
	[IDEKGIENJJD("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool APLODEHIMMM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x59F2CD0", Offset = "0x59F16D0", VA = "0x1859F2CD0")]
	public MNFGJAOKMDC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class IFJHMDEAJOB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly Dictionary<object, float> DDMHDBLMGFA;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public float ONIJKCALPJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0xB05990", Offset = "0xB04390", VA = "0x180B05990")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x1405390", Offset = "0x1403D90", VA = "0x181405390")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x86634E0", Offset = "0x8661EE0", VA = "0x1886634E0")]
	public void BIIEMNLFGJN(float KMAFNKGMDCF, object MFKHKDDANII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x86636D0", Offset = "0x86620D0", VA = "0x1886636D0")]
	public void OECGJOECOOH(object MFKHKDDANII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x8663550", Offset = "0x8661F50", VA = "0x188663550")]
	public void EMMOLKMNHIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x86635A0", Offset = "0x8661FA0", VA = "0x1886635A0")]
	private void FKJBKFKBEMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x8663740", Offset = "0x8662140", VA = "0x188663740")]
	public IFJHMDEAJOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public interface ODDEMOLBLEK
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event OADHLNFGHIK NDOACDJDNMO;
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class GGAMAAEOFMM : ODDEMOLBLEK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public readonly struct OKADDPEFIIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public readonly float GLFALCCJJDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public readonly float PKAPPLHNNJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		internal readonly bool OEBGFPNJFBL;

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public float BFHNMDFMCMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x86646C0", Offset = "0x86630C0", VA = "0x1886646C0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x8664830", Offset = "0x8663230", VA = "0x188664830")]
		public OKADDPEFIIM(float NPCHJIPLCII, float IEEBKKJDLGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x86646D0", Offset = "0x86630D0", VA = "0x1886646D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class AMABILNFGCA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public GGAMAAEOFMM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public AMABILNFGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x8660650", Offset = "0x865F050", VA = "0x188660650")]
		internal void DLFHMHPBJHK(float innerProgress)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly int JHAGJEMJCCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private int MNAEFIHMCEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly ODDEMOLBLEK[] DICCHBKFHIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly OADHLNFGHIK[] ADCMGLPBECA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly OKADDPEFIIM[] AFKKIAHACFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private OKADDPEFIIM JEHHHIKHPED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private readonly MEILIGBJNHJ OADFBLBPCCD;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event OADHLNFGHIK NDOACDJDNMO
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x86631D0", Offset = "0x8661BD0", VA = "0x1886631D0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x8662CA0", Offset = "0x86616A0", VA = "0x188662CA0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x8663290", Offset = "0x8661C90", VA = "0x188663290")]
	public GGAMAAEOFMM(int JHAGJEMJCCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x8662C10", Offset = "0x8661610", VA = "0x188662C10")]
	public MEILIGBJNHJ FDOFIBPBJDJ(OKADDPEFIIM FBOHMIMNCKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x8662D60", Offset = "0x8661760", VA = "0x188662D60")]
	public void HILNIJJMEAO(ODDEMOLBLEK HHLEBINEBDA, [Optional] OKADDPEFIIM AEODCPDCHLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x8662B00", Offset = "0x8661500", VA = "0x188662B00", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public delegate void OADHLNFGHIK(float KOOCBNLIKCI);
[Cpp2IlInjected.Token(Token = "0x2000062")]
public static class ABFGJDFEDMB
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	private class CBNNGJLCHDH : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private readonly ODDEMOLBLEK PGGECMCJNDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private readonly OADHLNFGHIK AEPCPKCINPI;

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x8660870", Offset = "0x865F270", VA = "0x188660870")]
		public CBNNGJLCHDH(ODDEMOLBLEK PGGECMCJNDO, OADHLNFGHIK AEPCPKCINPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x8660820", Offset = "0x865F220", VA = "0x188660820", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x86605E0", Offset = "0x865EFE0", VA = "0x1886605E0")]
	internal static bool FCALMBBEHMP(float EICJFDNFOCB, float MIBIEOGGIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x864FF10", Offset = "0x864E910", VA = "0x18864FF10")]
	internal static float IDLECHCCDMM(float EICJFDNFOCB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x8660520", Offset = "0x865EF20", VA = "0x188660520")]
	public static IDisposable AOMPJJFNAGF(this ODDEMOLBLEK PGGECMCJNDO, OADHLNFGHIK AEPCPKCINPI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class MEILIGBJNHJ : ODDEMOLBLEK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private float KOOCBNLIKCI;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public float BKNBNFMONMC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x8664350", Offset = "0x8662D50", VA = "0x188664350")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event OADHLNFGHIK? NDOACDJDNMO
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x86644E0", Offset = "0x8662EE0", VA = "0x1886644E0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x8664440", Offset = "0x8662E40", VA = "0x188664440", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public MEILIGBJNHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public interface LJHECKICFMO<T> where T : class, new()
{
	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LEIGBNDACDH<T> MEFJCANOAEB([Out] T KMAFNKGMDCF);

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EMMOLKMNHIK();
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class JKCMAIJGMJC<T> : LJHECKICFMO<T> where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly ConcurrentStack<T> OMKHBEKOKGG;

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x5545980", Offset = "0x5544380", VA = "0x185545980", Slot = "4")]
	public LEIGBNDACDH<T> MEFJCANOAEB([Out] T KMAFNKGMDCF)
	{
		return default(LEIGBNDACDH<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x5545920", Offset = "0x5544320", VA = "0x185545920")]
	public void KKMANOPBDMJ(T PFBHGMMFEAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x51BCA70", Offset = "0x51BB470", VA = "0x1851BCA70", Slot = "5")]
	public void EMMOLKMNHIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "6")]
	protected virtual void IOMBIGBOBAF(T HAFFKGJEKNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x5545890", Offset = "0x5544290", VA = "0x185545890")]
	private T GFFPJLNAMHB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x5545A10", Offset = "0x5544410", VA = "0x185545A10")]
	public JKCMAIJGMJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public readonly struct LEIGBNDACDH<T> : IDisposable where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly T PFBHGMMFEAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly JKCMAIJGMJC<T> DDFKDPINPIO;

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0xC64140", Offset = "0xC62B40", VA = "0x180C64140")]
	internal LEIGBNDACDH(T KMAFNKGMDCF, JKCMAIJGMJC<T> DDFKDPINPIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x5721FC0", Offset = "0x57209C0", VA = "0x185721FC0", Slot = "4")]
	void IDisposable.Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public class PFEPINNAKLI : JKCMAIJGMJC<StringBuilder>
{
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public static readonly PFEPINNAKLI FLGHCDNLMND;

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x8664B40", Offset = "0x8663540", VA = "0x188664B40")]
	public static LEIGBNDACDH<StringBuilder> GFFPJLNAMHB([Out] StringBuilder KMAFNKGMDCF)
	{
		return default(LEIGBNDACDH<StringBuilder>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x8664BE0", Offset = "0x86635E0", VA = "0x188664BE0", Slot = "6")]
	protected override void IOMBIGBOBAF(StringBuilder HAFFKGJEKNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x8664CA0", Offset = "0x86636A0", VA = "0x188664CA0")]
	public PFEPINNAKLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class POKNECNOLHH : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x7E888E0", Offset = "0x7E872E0", VA = "0x187E888E0")]
	public POKNECNOLHH(string JEBOHIALEMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
[DefaultMember("Item")]
public class GNPPPHFKGOO<TKey, TValue> : OFIHLKJLIFM<TKey, TValue>, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, AKJLAEMPCCN where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private sealed class GMFGMPGKPOC : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private KeyValuePair<TKey, TValue> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public GNPPPHFKGOO<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private IEnumerator<KeyValuePair<TKey, TValue>> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		KeyValuePair<TKey, TValue> IEnumerator<KeyValuePair<TKey, TValue>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x12D63C0", Offset = "0x12D4DC0", VA = "0x1812D63C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TValue>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x5082B60", Offset = "0x5081560", VA = "0x185082B60", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0xAB33A0", Offset = "0xAB1DA0", VA = "0x180AB33A0")]
		[DebuggerHidden]
		public GMFGMPGKPOC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x5082C10", Offset = "0x5081610", VA = "0x185082C10", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x5150090", Offset = "0x514EA90", VA = "0x185150090", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x514FFA0", Offset = "0x514E9A0", VA = "0x18514FFA0")]
		private void LLDKJPCFHKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x5150D30", Offset = "0x514F730", VA = "0x185150D30")]
		private void OCOHJFDHCPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x5150E20", Offset = "0x514F820", VA = "0x185150E20", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private readonly OFIHLKJLIFM<TKey, TValue> KOMKELMGDOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private readonly IDictionary<TKey, TValue> ILKPGGFNEEM;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public int BEFNAMGOJCC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x5156230", Offset = "0x5154C30", VA = "0x185156230", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public bool MECKNDEFNLE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public TValue PCCJLFHFGOC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x51564D0", Offset = "0x5154ED0", VA = "0x1851564D0", Slot = "4")]
		get
		{
			return (TValue)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x5156730", Offset = "0x5155130", VA = "0x185156730", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public ICollection<TKey> OKJNLJDHMBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x5156510", Offset = "0x5154F10", VA = "0x185156510", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public ICollection<TValue> LPDDCCJKGDF
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x5156620", Offset = "0x5155020", VA = "0x185156620", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x5156180", Offset = "0x5154B80", VA = "0x185156180")]
	public GNPPPHFKGOO(OFIHLKJLIFM<TKey, TValue> KOMKELMGDOM, [Optional] IDictionary<TKey, TValue>? ILKPGGFNEEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x5153D40", Offset = "0x5152740", VA = "0x185153D40", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x5154840", Offset = "0x5153240", VA = "0x185154840")]
	public void HJONDNHJNIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x5153710", Offset = "0x5152110", VA = "0x185153710", Slot = "9")]
	public void Add(TKey HPFHOBCPNEF, TValue KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x51552D0", Offset = "0x5153CD0", VA = "0x1851552D0")]
	public void MEADBHFLOEC(TKey HPFHOBCPNEF, TValue KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x5154E70", Offset = "0x5153870", VA = "0x185154E70")]
	public void KJNCAECOBIN(TKey HPFHOBCPNEF, TValue KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x51549E0", Offset = "0x51533E0", VA = "0x1851549E0")]
	public void JAMDADCNEIO(TKey HPFHOBCPNEF, TValue KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x5154680", Offset = "0x5153080", VA = "0x185154680")]
	public void DPEGJLIGCJP(TKey HPFHOBCPNEF, TValue KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x51557D0", Offset = "0x51541D0", VA = "0x1851557D0", Slot = "14")]
	void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> EOJOFJJBHLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x5155810", Offset = "0x5154210", VA = "0x185155810", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> EOJOFJJBHLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x5155B70", Offset = "0x5154570", VA = "0x185155B70", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> EOJOFJJBHLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x5153E50", Offset = "0x5152850", VA = "0x185153E50", Slot = "8")]
	public bool ContainsKey(TKey HPFHOBCPNEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x5154DA0", Offset = "0x51537A0", VA = "0x185154DA0")]
	public bool JNGGANLLIFP(TKey HPFHOBCPNEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x51550D0", Offset = "0x5153AD0", VA = "0x1851550D0")]
	public bool KKFIBJMFGMM(TKey HPFHOBCPNEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x5155610", Offset = "0x5154010", VA = "0x185155610", Slot = "10")]
	public bool Remove(TKey HPFHOBCPNEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x5155F00", Offset = "0x5154900", VA = "0x185155F00", Slot = "11")]
	public bool TryGetValue(TKey HPFHOBCPNEF, [Out] TValue KMAFNKGMDCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x5153F00", Offset = "0x5152900", VA = "0x185153F00", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TValue>[] BHEONMJLANC, int LKIFOIIFCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x5155ED0", Offset = "0x51548D0", VA = "0x185155ED0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x51547B0", Offset = "0x51531B0", VA = "0x1851547B0", Slot = "19")]
	[IteratorStateMachine(typeof(GNPPPHFKGOO<, >.GMFGMPGKPOC))]
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x51554B0", Offset = "0x5153EB0", VA = "0x1851554B0", Slot = "21")]
	public bool NJAGECIBJHH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x5153A90", Offset = "0x5152490", VA = "0x185153A90")]
	private TValue BPGMAJNHDEN(TKey HPFHOBCPNEF)
	{
		return (TValue)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public interface GKFBEHDAKAO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	string ADALLAPCKBB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public interface AKJLAEMPCCN
{
	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NJAGECIBJHH();
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public interface OFIHLKJLIFM<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, AKJLAEMPCCN
{
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[DefaultMember("Item")]
public sealed class CMLAJHKJHAI<TKey, TVal> : OFIHLKJLIFM<TKey, TVal>, IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, AKJLAEMPCCN where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public delegate int DENKMHLGPPH(TKey HPFHOBCPNEF, TVal KMAFNKGMDCF);

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public delegate void GMMOIMEAMOI(TKey HPFHOBCPNEF, TVal KMAFNKGMDCF, JKMLBGBCOJI LJPPNNLHGCJ);

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	private class DDPFGGKEKGG
	{
		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public TKey PHLFNBHNCJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0xED14F0", Offset = "0xECFEF0", VA = "0x180ED14F0")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public TVal AFPBILBCKEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0xB0E380", Offset = "0xB0CD80", VA = "0x180B0E380")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0xB0D970", Offset = "0xB0C370", VA = "0x180B0D970")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public int BFHNMDFMCMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0xC5E970", Offset = "0xC5D370", VA = "0x180C5E970")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x10BA490", Offset = "0x10B8E90", VA = "0x1810BA490")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public DateTimeOffset OCFBDNNHHEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(RVA = "0x14523C0", Offset = "0x1450DC0", VA = "0x1814523C0")]
			[CompilerGenerated]
			get
			{
				return default(DateTimeOffset);
			}
			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0x15AC720", Offset = "0x15AB120", VA = "0x1815AC720")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x45E54C0", Offset = "0x45E3EC0", VA = "0x1845E54C0")]
		public DDPFGGKEKGG(TKey HPFHOBCPNEF, TVal MKDEBCJNKCE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[CompilerGenerated]
	private sealed class MLNIMIOEFHP : IEnumerator<KeyValuePair<TKey, TVal>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private KeyValuePair<TKey, TVal> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public CMLAJHKJHAI<TKey, TVal> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private LinkedList<DDPFGGKEKGG>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		KeyValuePair<TKey, TVal> IEnumerator<KeyValuePair<TKey, TVal>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x12D63C0", Offset = "0x12D4DC0", VA = "0x1812D63C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TVal>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x59ED370", Offset = "0x59EBD70", VA = "0x1859ED370", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0xAB33A0", Offset = "0xAB1DA0", VA = "0x180AB33A0")]
		[DebuggerHidden]
		public MLNIMIOEFHP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x5065630", Offset = "0x5064030", VA = "0x185065630", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x59EB780", Offset = "0x59EA180", VA = "0x1859EB780", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x59EA840", Offset = "0x59E9240", VA = "0x1859EA840")]
		private void LLDKJPCFHKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x59ED000", Offset = "0x59EBA00", VA = "0x1859ED000", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public const int AEIFOFNEDAI = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private readonly Dictionary<TKey, LinkedListNode<DDPFGGKEKGG>> CMHLANGCBIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private readonly LinkedList<DDPFGGKEKGG> JCEBBKGPBAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly DENKMHLGPPH? KNIBJNPDJHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private readonly TimeSpan GPPFHCHAFFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private readonly GMMOIMEAMOI? BNIBENIEOLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private readonly EPDJAOACKCO KABKBEOBJML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private bool NOOCPAHEJEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private readonly List<TKey> AECJPEAPOJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly List<TVal> ICNAELPNKMI;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public int EJPLDFLIJEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0xB2EC70", Offset = "0xB2D670", VA = "0x180B2EC70")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	internal int MCPOLGLLDOC
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0xEC9A70", Offset = "0xEC8470", VA = "0x180EC9A70")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x1001770", Offset = "0x1000170", VA = "0x181001770")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public int BEFNAMGOJCC
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x6DDB4C0", Offset = "0x6DD9EC0", VA = "0x186DDB4C0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	internal int IJNMHABHIBD
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x4FDE180", Offset = "0x4FDCB80", VA = "0x184FDE180")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public ICollection<TVal> LPDDCCJKGDF
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x6DDB5B0", Offset = "0x6DD9FB0", VA = "0x186DDB5B0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	ICollection<TKey> IDictionary<TKey, TVal>.GGDBKMIALBA
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x6DD72D0", Offset = "0x6DD5CD0", VA = "0x186DD72D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool MECKNDEFNLE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public TVal PCCJLFHFGOC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x6DDB570", Offset = "0x6DD9F70", VA = "0x186DDB570", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x6DDB5E0", Offset = "0x6DD9FE0", VA = "0x186DDB5E0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x6DD2CB0", Offset = "0x6DD16B0", VA = "0x186DD2CB0")]
	private bool IMGAOCFJDMH(int JHAGJEMJCCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x6DD4E60", Offset = "0x6DD3860", VA = "0x186DD4E60")]
	private void MCADGEJFCBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x6DD84A0", Offset = "0x6DD6EA0", VA = "0x186DD84A0")]
	public CMLAJHKJHAI(int JHAGJEMJCCP, [Optional] DENKMHLGPPH? KNIBJNPDJHI, [Optional] IEqualityComparer<TKey>? ABKMLEEHGLA, [Optional] GMMOIMEAMOI? BNIBENIEOLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x6DD8450", Offset = "0x6DD6E50", VA = "0x186DD8450")]
	public CMLAJHKJHAI(TimeSpan GPPFHCHAFFA, [Optional] IEqualityComparer<TKey>? ABKMLEEHGLA, [Optional] GMMOIMEAMOI? BNIBENIEOLE, [Optional] EPDJAOACKCO? KABKBEOBJML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x6DD7F30", Offset = "0x6DD6930", VA = "0x186DD7F30")]
	public CMLAJHKJHAI(int JHAGJEMJCCP, TimeSpan GPPFHCHAFFA, [Optional] IEqualityComparer<TKey>? ABKMLEEHGLA, [Optional] GMMOIMEAMOI? BNIBENIEOLE, [Optional] EPDJAOACKCO? KABKBEOBJML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x6DD8AF0", Offset = "0x6DD74F0", VA = "0x186DD8AF0")]
	public CMLAJHKJHAI(int JHAGJEMJCCP, DENKMHLGPPH? KNIBJNPDJHI, TimeSpan GPPFHCHAFFA, [Optional] IEqualityComparer<TKey>? ABKMLEEHGLA, [Optional] GMMOIMEAMOI? BNIBENIEOLE, [Optional] EPDJAOACKCO? KABKBEOBJML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x6DD52B0", Offset = "0x6DD3CB0", VA = "0x186DD52B0", Slot = "21")]
	public bool NJAGECIBJHH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x6DC7510", Offset = "0x6DC5F10", VA = "0x186DC7510", Slot = "22")]
	public bool BMEELMEMLDD(int BCAJFCGHDKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x6DCB880", Offset = "0x6DCA280", VA = "0x186DCB880")]
	private bool ELPNEAHDBBE(int BCAJFCGHDKI, JKMLBGBCOJI LJPPNNLHGCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x6DCED50", Offset = "0x6DCD750", VA = "0x186DCED50")]
	public void FNAEMEPGHFK(TKey HPFHOBCPNEF, TVal KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x6DC5080", Offset = "0x6DC3A80", VA = "0x186DC5080", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> EOJOFJJBHLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x6DC44F0", Offset = "0x6DC2EF0", VA = "0x186DC44F0", Slot = "9")]
	public void Add(TKey HPFHOBCPNEF, TVal KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x6DC7950", Offset = "0x6DC6350", VA = "0x186DC7950", Slot = "8")]
	public bool ContainsKey(TKey HPFHOBCPNEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x6DD6860", Offset = "0x6DD5260", VA = "0x186DD6860", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Contains(KeyValuePair<TKey, TVal> EOJOFJJBHLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x6DD6620", Offset = "0x6DD5020", VA = "0x186DD6620", Slot = "10")]
	public bool Remove(TKey HPFHOBCPNEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x6DD6F60", Offset = "0x6DD5960", VA = "0x186DD6F60", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Remove(KeyValuePair<TKey, TVal> EOJOFJJBHLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x6DD5BD0", Offset = "0x6DD45D0", VA = "0x186DD5BD0")]
	private bool OPCMCPONGFA(TKey HPFHOBCPNEF, [Out] TVal KMAFNKGMDCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x6DCF130", Offset = "0x6DCDB30", VA = "0x186DCF130")]
	private TVal GFFPJLNAMHB(TKey JLGLJMOGAHI)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x6DD74F0", Offset = "0x6DD5EF0", VA = "0x186DD74F0", Slot = "11")]
	public bool TryGetValue(TKey JLGLJMOGAHI, [Out] TVal KMAFNKGMDCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x6DC7830", Offset = "0x6DC6230", VA = "0x186DC7830", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x6DC8E70", Offset = "0x6DC7870", VA = "0x186DC8E70", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] BHEONMJLANC, int LKIFOIIFCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x6DD4480", Offset = "0x6DD2E80", VA = "0x186DD4480")]
	private void JJGECCADJKO(TKey HPFHOBCPNEF, TVal MKDEBCJNKCE, JKMLBGBCOJI LJPPNNLHGCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x6DCE6B0", Offset = "0x6DCD0B0", VA = "0x186DCE6B0")]
	private bool FCEDJOAHMBL(DDPFGGKEKGG EIBMDKHOCCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x6DD0D70", Offset = "0x6DCF770", VA = "0x186DD0D70")]
	private void IGLGCFOOBAC(LinkedListNode<DDPFGGKEKGG> JMPDKPOBDCE, TVal FCPDBBAAIEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x6DC5610", Offset = "0x6DC4010", VA = "0x186DC5610")]
	private void BIIEMNLFGJN(TKey HPFHOBCPNEF, TVal KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x6DD3D50", Offset = "0x6DD2750", VA = "0x186DD3D50")]
	private void IPONLPAJPAL(DDPFGGKEKGG EIBMDKHOCCH, TVal FCPDBBAAIEF, int DCGNAGFNNIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x6DCFA30", Offset = "0x6DCE430", VA = "0x186DCFA30", Slot = "19")]
	[IteratorStateMachine(typeof(CMLAJHKJHAI<, >.MLNIMIOEFHP))]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x6DD7300", Offset = "0x6DD5D00", VA = "0x186DD7300", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public enum JKMLBGBCOJI : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	Evicted,
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	RemovedViaRemove,
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	RemovedViaClear,
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	Overwritten
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public class EGCPLCCKLOG<TKey> : Exception where TKey : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public readonly TKey DNDNIEDHGKC;

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x4B0E080", Offset = "0x4B0CA80", VA = "0x184B0E080")]
	public EGCPLCCKLOG(TKey HPJLKLOJNHD, Exception BFLPFMDLFDO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public class EKIDOKLIBEF : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x768E370", Offset = "0x768CD70", VA = "0x18768E370")]
	public EKIDOKLIBEF(string JEBOHIALEMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class GGPPGEPMEPL<TId, TResource> : IEnumerable<(TId, Task<TResource>, int)>, IEnumerable where TId : notnull where TResource : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private sealed class PAIFLPGGFGE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public Func<TId, CancellationToken, Task<TResource>> factory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public GGPPGEPMEPL<TId, TResource> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public PAIFLPGGFGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x5C8E9D0", Offset = "0x5C8D3D0", VA = "0x185C8E9D0")]
		internal Task<TResource> IHCBFAFPLNC(TId _id)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private struct BHCGBKNLKPB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public GGPPGEPMEPL<TId, TResource> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x66957E0", Offset = "0x66941E0", VA = "0x1866957E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x6695B10", Offset = "0x6694510", VA = "0x186695B10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private struct IMDBMMLBDHO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public Dictionary<Task<TResource>, CancellationTokenSource> cancellationTokenSources;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public CancellationTokenSource cts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x52F3310", Offset = "0x52F1D10", VA = "0x1852F3310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x52F3A10", Offset = "0x52F2410", VA = "0x1852F3A10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly LMEAIPPJOBI<TId, Task<TResource>> DHCGDGMNMNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private readonly Dictionary<Task<TResource>, CancellationTokenSource> ICFJGDIJDLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private readonly Func<TId, CancellationToken, Task<TResource>>? IDNDNGGJMKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private readonly Action<TResource>? HNMEKNKPCMN;

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x512DF30", Offset = "0x512C930", VA = "0x18512DF30")]
	public GGPPGEPMEPL(int AHBOODEOAJF = 0, [Optional] IEqualityComparer<TId>? KPOMHKKJPFM, [Optional] Func<TId, CancellationToken, Task<TResource>>? ENBGCKLPPGL, [Optional] Action<TResource>? BPOAAAKCPNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x512D300", Offset = "0x512BD00", VA = "0x18512D300")]
	public MDANMGHNNOC<Task<TResource>> IPJDHKGAIHO(TId NMAIBBDGPCD, [Optional] Func<TId, CancellationToken, Task<TResource>>? ENBGCKLPPGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x512DC50", Offset = "0x512C650", VA = "0x18512DC50")]
	private void OJPNDDKCELO(Task<TResource> FLAIIHBKGBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x512CC60", Offset = "0x512B660", VA = "0x18512CC60")]
	[AsyncStateMachine(typeof(GGPPGEPMEPL<, >.BHCGBKNLKPB))]
	private Task FEPHNJCAPOA(Task<TResource> FLAIIHBKGBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x512C930", Offset = "0x512B330", VA = "0x18512C930")]
	public void FABDHPDGCNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x512CED0", Offset = "0x512B8D0", VA = "0x18512CED0")]
	public LMEAIPPJOBI<TId, Task<TResource>>.ICIJAALKALI FIIFAFDLDFC()
	{
		return default(LMEAIPPJOBI<TId, Task<TResource>>.ICIJAALKALI);
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x512DD60", Offset = "0x512C760", VA = "0x18512DD60", Slot = "4")]
	private IEnumerator<(TId, Task<TResource>, int)> System.Collections.Generic.IEnumerable<(TIdId,System.Threading.Tasks.Task<TResource>LoadResourceTask,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x512DD60", Offset = "0x512C760", VA = "0x18512DD60", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x512C470", Offset = "0x512AE70", VA = "0x18512C470")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(GGPPGEPMEPL<, >.IMDBMMLBDHO))]
	internal static Task APJEKANMOCM(Task<TResource> FLAIIHBKGBI, CancellationTokenSource OHFCLCGHNMB, Dictionary<Task<TResource>, CancellationTokenSource> MIKHKHEANIB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class LMEAIPPJOBI<TKey, TValue> : IEnumerable<(TKey, TValue, int)>, IEnumerable where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	private sealed class KKAPMANNECN : IEquatable<KKAPMANNECN>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public readonly TValue AFPBILBCKEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public int IOAPLPDMNIF;

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x103FB90", Offset = "0x103E590", VA = "0x18103FB90")]
		public KKAPMANNECN(TValue KMAFNKGMDCF, int JLEJHJMODPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x5674460", Offset = "0x5672E60", VA = "0x185674460", Slot = "4")]
		public bool Equals(KKAPMANNECN? GOCNHGEHNFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x56744E0", Offset = "0x5672EE0", VA = "0x1856744E0", Slot = "0")]
		public override bool Equals(object? PMNHIPACJLN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x5674580", Offset = "0x5672F80", VA = "0x185674580", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public struct ICIJAALKALI : IEnumerator<(TKey, TValue, int)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private Dictionary<TKey, KKAPMANNECN>.Enumerator DMHBCNMMMCA;

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0x52D0EB0", Offset = "0x52CF8B0", VA = "0x1852D0EB0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public (TKey Key, TValue Value, int RefCount) IGCJDJEKHNM
		{
			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0x52D11A0", Offset = "0x52CFBA0", VA = "0x1852D11A0", Slot = "4")]
			get
			{
				return default((TKey, TValue, int));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x52D0F50", Offset = "0x52CF950", VA = "0x1852D0F50")]
		public ICIJAALKALI(LMEAIPPJOBI<TKey, TValue> DDMHDBLMGFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x52D09A0", Offset = "0x52CF3A0", VA = "0x1852D09A0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x52D09E0", Offset = "0x52CF3E0", VA = "0x1852D09E0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x52D0CB0", Offset = "0x52CF6B0", VA = "0x1852D0CB0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private sealed class BGFJJJLMMKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public LMEAIPPJOBI<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public TKey key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public KKAPMANNECN refCountedValue;

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public BGFJJJLMMKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x6693E10", Offset = "0x6692810", VA = "0x186693E10")]
		internal void IHCBFAFPLNC()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private readonly Dictionary<TKey, KKAPMANNECN> MEIFJGEGGMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private readonly Func<TKey, TValue>? CCAIHBOHJMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private readonly Action<TValue>? IDILFGFIIHP;

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x5742EA0", Offset = "0x57418A0", VA = "0x185742EA0")]
	public LMEAIPPJOBI(int AHBOODEOAJF = 0, [Optional] IEqualityComparer<TKey>? ABKMLEEHGLA, [Optional] Func<TKey, TValue>? FFMJCLBHFLI, [Optional] Action<TValue>? MKFJODLPNAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x5742730", Offset = "0x5741130", VA = "0x185742730")]
	public MDANMGHNNOC<TValue> IPJDHKGAIHO(TKey HPFHOBCPNEF, [Optional] Func<TKey, TValue>? OBJFMKIDLLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x5742A00", Offset = "0x5741400", VA = "0x185742A00")]
	private void KKMANOPBDMJ(TKey HPFHOBCPNEF, KKAPMANNECN NDPIHECCLGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x5741830", Offset = "0x5740230", VA = "0x185741830")]
	public void FABDHPDGCNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x5741E40", Offset = "0x5740840", VA = "0x185741E40")]
	public ICIJAALKALI FIIFAFDLDFC()
	{
		return default(ICIJAALKALI);
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x5742CD0", Offset = "0x57416D0", VA = "0x185742CD0", Slot = "4")]
	private IEnumerator<(TKey, TValue, int)> System.Collections.Generic.IEnumerable<(TKeyKey,TValueValue,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x5742CD0", Offset = "0x57416D0", VA = "0x185742CD0", Slot = "5")]
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
