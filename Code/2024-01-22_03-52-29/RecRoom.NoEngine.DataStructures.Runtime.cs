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
		[Cpp2IlInjected.Address(RVA = "0x7BAB50", Offset = "0x7B9F50", VA = "0x1807BAB50")]
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
		[Cpp2IlInjected.Address(RVA = "0x609A890", Offset = "0x6099C90", VA = "0x18609A890")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7BB450", Offset = "0x7BA850", VA = "0x1807BB450")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7BB490", Offset = "0x7BA890", VA = "0x1807BB490")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class LKKKMJPMANI
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
	protected LKKKMJPMANI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class BBNGLKOKHFG<T> : LKKKMJPMANI
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	protected struct OMFFLFPONCK
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public enum JACFBHGLPHM
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
		public JACFBHGLPHM KHENBEDBKDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public T EEEBGEOHFMI;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private int LIOAHAJANMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool MKDFJKMEOEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	protected readonly bool FHINFMJDNMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	protected List<T>? HCFMJDLMIMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<OMFFLFPONCK>? IAOLHJBGHAL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool KKFGNMGBJHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x46C27B0", Offset = "0x46C1BB0", VA = "0x1846C27B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x46C2B80", Offset = "0x46C1F80", VA = "0x1846C2B80")]
	protected BBNGLKOKHFG(bool FHINFMJDNMM, bool MKDFJKMEOEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x46C2AE0", Offset = "0x46C1EE0", VA = "0x1846C2AE0")]
	protected bool PGICJGADKPG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x46C2800", Offset = "0x46C1C00", VA = "0x1846C2800")]
	protected void JLKIKFEPDCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x46C2900", Offset = "0x46C1D00", VA = "0x1846C2900")]
	protected void NDJCEBGALGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2F27570", Offset = "0x2F26970", VA = "0x182F27570")]
	private static void PPHBAIHMIBO<U>(List<U>? EPAFMCCJAFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x46C22A0", Offset = "0x46C16A0", VA = "0x1846C22A0", Slot = "4")]
	public void DEAIBIAHPPK(T EEEBGEOHFMI, bool PHHLDCLFPLG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x46C2600", Offset = "0x46C1A00", VA = "0x1846C2600", Slot = "5")]
	public void FKMFNEFKHJM(T EEEBGEOHFMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x46C2480", Offset = "0x46C1880", VA = "0x1846C2480")]
	public void EKABOMHIFDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface PPGOLPCGKFN
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DEAIBIAHPPK(Action EEEBGEOHFMI, bool PHHLDCLFPLG = false);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FKMFNEFKHJM(Action EEEBGEOHFMI);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class DECPPMKECOG : BBNGLKOKHFG<Action>, PPGOLPCGKFN
{
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6098A00", Offset = "0x6097E00", VA = "0x186098A00")]
	public DECPPMKECOG(bool FHINFMJDNMM = false, bool MKDFJKMEOEE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x60987A0", Offset = "0x6097BA0", VA = "0x1860987A0")]
	public void KDMCKBPMJJN()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x60989A0", Offset = "0x6097DA0", VA = "0x1860989A0")]
	public static DECPPMKECOG NCIEHHPGKAB(DECPPMKECOG ECEOHHKKABB, Action EEEBGEOHFMI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6098740", Offset = "0x6097B40", VA = "0x186098740")]
	public static DECPPMKECOG AFOKPAGMHPB(DECPPMKECOG ECEOHHKKABB, Action EEEBGEOHFMI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface DBDNPJHECGH<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DEAIBIAHPPK(Action<T> EEEBGEOHFMI, bool PHHLDCLFPLG = false);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FKMFNEFKHJM(Action<T> EEEBGEOHFMI);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public sealed class NFAKNFEBDCB<T> : BBNGLKOKHFG<Action<T>>, DBDNPJHECGH<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x32BE040", Offset = "0x32BD440", VA = "0x1832BE040")]
	public NFAKNFEBDCB(bool FHINFMJDNMM = false, bool MKDFJKMEOEE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3E8EFF0", Offset = "0x3E8E3F0", VA = "0x183E8EFF0")]
	public void KDMCKBPMJJN(T DMIDIFJGAKP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x32BDFB0", Offset = "0x32BD3B0", VA = "0x1832BDFB0")]
	public static NFAKNFEBDCB<T> NCIEHHPGKAB(NFAKNFEBDCB<T> ECEOHHKKABB, Action<T> EEEBGEOHFMI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x32BD700", Offset = "0x32BCB00", VA = "0x1832BD700")]
	public static NFAKNFEBDCB<T> AFOKPAGMHPB(NFAKNFEBDCB<T> ECEOHHKKABB, Action<T> EEEBGEOHFMI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface EBDEKKDCPHP<T, U> where T : notnull where U : notnull
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class PLDMPICEDLM<T, U> : BBNGLKOKHFG<Action<T, U>>, EBDEKKDCPHP<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x32BE040", Offset = "0x32BD440", VA = "0x1832BE040")]
	public PLDMPICEDLM(bool FHINFMJDNMM = false, bool MKDFJKMEOEE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x406C5C0", Offset = "0x406B9C0", VA = "0x18406C5C0")]
	public void KDMCKBPMJJN(T DMIDIFJGAKP, U CEAKONIJLOF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x32BDFB0", Offset = "0x32BD3B0", VA = "0x1832BDFB0")]
	public static PLDMPICEDLM<T, U> NCIEHHPGKAB(PLDMPICEDLM<T, U> ECEOHHKKABB, Action<T, U> EEEBGEOHFMI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x32BD700", Offset = "0x32BCB00", VA = "0x1832BD700")]
	public static PLDMPICEDLM<T, U> AFOKPAGMHPB(PLDMPICEDLM<T, U> ECEOHHKKABB, Action<T, U> EEEBGEOHFMI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class BJLFCGIDNLA<T, U, V> : BBNGLKOKHFG<Action<T, U, V>> where T : notnull where U : notnull where V : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x32BE040", Offset = "0x32BD440", VA = "0x1832BE040")]
	public BJLFCGIDNLA(bool FHINFMJDNMM = false, bool MKDFJKMEOEE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4710CC0", Offset = "0x47100C0", VA = "0x184710CC0")]
	public void KDMCKBPMJJN(T DMIDIFJGAKP, U CEAKONIJLOF, V KEKNEOLOBCH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x32BDFB0", Offset = "0x32BD3B0", VA = "0x1832BDFB0")]
	public static BJLFCGIDNLA<T, U, V> NCIEHHPGKAB(BJLFCGIDNLA<T, U, V> ECEOHHKKABB, Action<T, U, V> EEEBGEOHFMI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x32BD700", Offset = "0x32BCB00", VA = "0x1832BD700")]
	public static BJLFCGIDNLA<T, U, V> AFOKPAGMHPB(BJLFCGIDNLA<T, U, V> ECEOHHKKABB, Action<T, U, V> EEEBGEOHFMI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface LMIOOMLBEAF<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class JAMFAJBIMJB<T, U, V, W> : BBNGLKOKHFG<Action<T, U, V, W>>, LMIOOMLBEAF<T, U, V, W> where T : notnull where U : notnull where V : notnull where W : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x32BE040", Offset = "0x32BD440", VA = "0x1832BE040")]
	public JAMFAJBIMJB(bool FHINFMJDNMM = false, bool MKDFJKMEOEE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3AA5160", Offset = "0x3AA4560", VA = "0x183AA5160")]
	public void KDMCKBPMJJN(T DMIDIFJGAKP, U CEAKONIJLOF, V KEKNEOLOBCH, W GMIOCALJPJN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x32BDFB0", Offset = "0x32BD3B0", VA = "0x1832BDFB0")]
	public static JAMFAJBIMJB<T, U, V, W> NCIEHHPGKAB(JAMFAJBIMJB<T, U, V, W> ECEOHHKKABB, Action<T, U, V, W> EEEBGEOHFMI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x32BD700", Offset = "0x32BCB00", VA = "0x1832BD700")]
	public static JAMFAJBIMJB<T, U, V, W> AFOKPAGMHPB(JAMFAJBIMJB<T, U, V, W> ECEOHHKKABB, Action<T, U, V, W> EEEBGEOHFMI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class EHFGGFOMABH<T, U, V, W, X> : BBNGLKOKHFG<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x32BE040", Offset = "0x32BD440", VA = "0x1832BE040")]
	public EHFGGFOMABH(bool FHINFMJDNMM = false, bool MKDFJKMEOEE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x32BDBF0", Offset = "0x32BCFF0", VA = "0x1832BDBF0")]
	public void KDMCKBPMJJN(T DMIDIFJGAKP, U CEAKONIJLOF, V KEKNEOLOBCH, W GMIOCALJPJN, X FHDILOGEHPC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x32BDFB0", Offset = "0x32BD3B0", VA = "0x1832BDFB0")]
	public static EHFGGFOMABH<T, U, V, W, X> NCIEHHPGKAB(EHFGGFOMABH<T, U, V, W, X> ECEOHHKKABB, Action<T, U, V, W, X> EEEBGEOHFMI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x32BD700", Offset = "0x32BCB00", VA = "0x1832BD700")]
	public static EHFGGFOMABH<T, U, V, W, X> AFOKPAGMHPB(EHFGGFOMABH<T, U, V, W, X> ECEOHHKKABB, Action<T, U, V, W, X> EEEBGEOHFMI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class NNIJGFNFBKD<T, U, V, W, X, Y> : BBNGLKOKHFG<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x32BE040", Offset = "0x32BD440", VA = "0x1832BE040")]
	public NNIJGFNFBKD(bool FHINFMJDNMM = false, bool MKDFJKMEOEE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3EBB3A0", Offset = "0x3EBA7A0", VA = "0x183EBB3A0")]
	public void KDMCKBPMJJN(T DMIDIFJGAKP, U CEAKONIJLOF, V KEKNEOLOBCH, W GMIOCALJPJN, X FHDILOGEHPC, Y ICKJJDCCMFI)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x32BDFB0", Offset = "0x32BD3B0", VA = "0x1832BDFB0")]
	public static NNIJGFNFBKD<T, U, V, W, X, Y> NCIEHHPGKAB(NNIJGFNFBKD<T, U, V, W, X, Y> ECEOHHKKABB, Action<T, U, V, W, X, Y> EEEBGEOHFMI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x32BD700", Offset = "0x32BCB00", VA = "0x1832BD700")]
	public static NNIJGFNFBKD<T, U, V, W, X, Y> AFOKPAGMHPB(NNIJGFNFBKD<T, U, V, W, X, Y> ECEOHHKKABB, Action<T, U, V, W, X, Y> EEEBGEOHFMI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class LLCKEFJGCEI<TKey, TVal> where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly AJMFJCPHOPA<TKey, TVal> MMHDHEHGFMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly Dictionary<TKey, (TVal value, int size)> DOKOMOHCHJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly int KLGPJFNIBLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly AJMFJCPHOPA<TKey, TVal>.CNIGAGDGCOO? CMJHMEMCAIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private int DCPNNEMHBIM;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal int IGJIOPKGDOC
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3C366A0", Offset = "0x3C35AA0", VA = "0x183C366A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int PGLEDIIDNKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8C5130", Offset = "0x8C4530", VA = "0x1808C5130")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3C36EB0", Offset = "0x3C362B0", VA = "0x183C36EB0")]
	public LLCKEFJGCEI(int KLGPJFNIBLL, [Optional] AJMFJCPHOPA<TKey, TVal>.CNIGAGDGCOO? CMJHMEMCAIC, [Optional] IEqualityComparer<TKey>? IDDBJPNFLPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3C366F0", Offset = "0x3C35AF0", VA = "0x183C366F0")]
	public void EJGFMEGMCOO(TKey CONEAMPCFEL, TVal PAHKKNONPEO, bool NJMNCHOEENA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3C36E10", Offset = "0x3C36210", VA = "0x183C36E10")]
	public bool PPOCPBDGAGN(TKey CONEAMPCFEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3C368C0", Offset = "0x3C35CC0", VA = "0x183C368C0")]
	public bool KDHJGKFFEEJ(TKey MFKIEOAPBHA, [Out] TVal PAHKKNONPEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3C369A0", Offset = "0x3C35DA0", VA = "0x183C369A0")]
	private void LOPEHJLPKBD(TKey CONEAMPCFEL, TVal PAHKKNONPEO, int KKEOKHMHDHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3C36C80", Offset = "0x3C36080", VA = "0x183C36C80")]
	public bool POBLODFCAAO(TKey CONEAMPCFEL, TVal PAHKKNONPEO, bool NJMNCHOEENA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3C36BC0", Offset = "0x3C35FC0", VA = "0x183C36BC0")]
	private bool MEGONBLMLJE(TKey CONEAMPCFEL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class BBBMKIJHFNP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly Action MLHMALKFKNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private bool APGFNPJPPLE;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7967D0", Offset = "0x795BD0", VA = "0x1807967D0")]
	public BBBMKIJHFNP(Action MLLHGDLMPHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6098640", Offset = "0x6097A40", VA = "0x186098640", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x23E9D40", Offset = "0x23E9140", VA = "0x1823E9D40")]
	public static LPCLHFEGNKE<T> CNMCABBAMHK<T>(T PAHKKNONPEO, Action MLLHGDLMPHI) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class LPCLHFEGNKE<T> : BBBMKIJHFNP where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public T BFBAIKCHJBC
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x796850", Offset = "0x795C50", VA = "0x180796850")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3C46CD0", Offset = "0x3C460D0", VA = "0x183C46CD0")]
	public LPCLHFEGNKE(T PAHKKNONPEO, Action MLLHGDLMPHI)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct FNFBFDKENLK : IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct GKPGOJHHDAD : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7D85C0", Offset = "0x7D79C0", VA = "0x1807D85C0")]
		public static GKPGOJHHDAD PIJMMFMEPKL()
		{
			return default(GKPGOJHHDAD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7D85C0", Offset = "0x7D79C0", VA = "0x1807D85C0")]
	public static FNFBFDKENLK CIBIAGDOKMN(Type KHENBEDBKDI, [Optional] string? EOJINFKGANM, [Optional] string? OJJCBDGCDAH, bool EJCADIBNNPI = false)
	{
		return default(FNFBFDKENLK);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7D85C0", Offset = "0x7D79C0", VA = "0x1807D85C0")]
	public static FNFBFDKENLK CIBIAGDOKMN<T>([Optional] string? EOJINFKGANM, [Optional] string? OJJCBDGCDAH, bool EJCADIBNNPI = false)
	{
		return default(FNFBFDKENLK);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct GHCNICPGDBB
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate bool FENNOGKOHGF(string EGBINEBNPBN, GHCNICPGDBB NMEFHMHLGGO);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public int ADBOOOJIIPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public string IJCNMFCIKEK;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6099B30", Offset = "0x6098F30", VA = "0x186099B30")]
	public static Dictionary<string, GHCNICPGDBB> NGFBMGCKPGK(Type MFEEBGMHKNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6099480", Offset = "0x6098880", VA = "0x186099480")]
	public static Dictionary<string, GHCNICPGDBB> BONCFDHAFEM(Type MFEEBGMHKNE, FENNOGKOHGF IPDDMAKBFPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6099970", Offset = "0x6098D70", VA = "0x186099970")]
	public static Dictionary<int, string> HIDBAANAGLC(Dictionary<string, GHCNICPGDBB> GDMGHBDKKDG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[AttributeUsage(AttributeTargets.Enum)]
public abstract class ONFEEJJLMPN : PreserveAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string FFILKOANIAP(string NODLFLFFLNG);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7A0100", Offset = "0x79F500", VA = "0x1807A0100")]
	protected ONFEEJJLMPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class JIBPJLBDKCG : IGBINOOJKPE
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public static bool GIGNCLCFKPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly string? DKJDKJJEHDO;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public virtual IGBINOOJKPE? KHBCIABPKNG
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x791450", Offset = "0x790850", VA = "0x180791450", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x609A610", Offset = "0x6099A10", VA = "0x18609A610")]
	protected JIBPJLBDKCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string GPDEFFKCMGK();

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x609A0C0", Offset = "0x60994C0", VA = "0x18609A0C0", Slot = "8")]
	public virtual string DDANPFJGOGG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x609A360", Offset = "0x6099760", VA = "0x18609A360", Slot = "9")]
	public void OGLBCJMPAFF(StringBuilder EODFEFKGPAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x609A140", Offset = "0x6099540", VA = "0x18609A140", Slot = "10")]
	public void JBINJNIKJBP(StringBuilder EODFEFKGPAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x609A240", Offset = "0x6099640", VA = "0x18609A240", Slot = "11")]
	public void NLKPEGDEIFF(StringBuilder EODFEFKGPAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6099F60", Offset = "0x6099360", VA = "0x186099F60", Slot = "12")]
	public void DBAEHBMMOGA(StringBuilder EODFEFKGPAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x609A1A0", Offset = "0x60995A0", VA = "0x18609A1A0")]
	public static void LBILHKJFOJG(StringBuilder EODFEFKGPAN, string NMBGAFOPKJF, string BHNFFFNPBAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x536B200", Offset = "0x536A600", VA = "0x18536B200", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class CPMKHCAMFFN : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x60986E0", Offset = "0x6097AE0", VA = "0x1860986E0")]
	public CPMKHCAMFFN(string AGOKDCAFCLN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class IJBMAGNKHNA<TErr> : CPMKHCAMFFN where TErr : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly TErr FGGCILAIGEO;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x38E44A0", Offset = "0x38E38A0", VA = "0x1838E44A0")]
	private IJBMAGNKHNA([In] TErr IPCOJAKAILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x38E43D0", Offset = "0x38E37D0", VA = "0x1838E43D0")]
	public static IJBMAGNKHNA<TErr> PIJMMFMEPKL([In] TErr IPCOJAKAILG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface IGBINOOJKPE
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string DDANPFJGOGG();

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string GPDEFFKCMGK();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface BKBGJNIINHN<out TOptions> where TOptions : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	TOptions BFBAIKCHJBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface AOLJENOADLF
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	string KJDNHMFJFFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class BJDAKBMMMOC : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6098680", Offset = "0x6097A80", VA = "0x186098680")]
	public BJDAKBMMMOC(string AGOKDCAFCLN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class PLKJFHNGBAK<TOk> : BJDAKBMMMOC where TOk : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly TOk CAIACGMOEKE;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x4073C30", Offset = "0x4073030", VA = "0x184073C30")]
	private PLKJFHNGBAK([In] TOk KEOEOPDNMDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x377C690", Offset = "0x377BA90", VA = "0x18377C690")]
	public static PLKJFHNGBAK<TOk> PIJMMFMEPKL([In] TOk KEOEOPDNMDN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public readonly struct EGECKPFNJNE<TOk, TErr> : IEquatable<EGECKPFNJNE<TOk, TErr>> where TOk : notnull where TErr : notnull
{
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private static readonly EqualityComparer<TErr> ONOJNEKGMLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal readonly TErr FGGCILAIGEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal readonly TOk CAIACGMOEKE;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool NFKDDMFLGGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x32B8250", Offset = "0x32B7650", VA = "0x1832B8250")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool KILADIMPANB
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x32B9000", Offset = "0x32B8400", VA = "0x1832B9000")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x32BB7A0", Offset = "0x32BABA0", VA = "0x1832BB7A0")]
	internal EGECKPFNJNE([In] TErr IPCOJAKAILG, [In] TOk KEOEOPDNMDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x32B4DA0", Offset = "0x32B41A0", VA = "0x1832B4DA0")]
	public static EGECKPFNJNE<TOk, TErr> AGFOAHPDKGK([In] TErr IPCOJAKAILG)
	{
		return default(EGECKPFNJNE<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x32B8D20", Offset = "0x32B8120", VA = "0x1832B8D20")]
	public static EGECKPFNJNE<TOk, TErr> PHPCPNDHCCJ([In] TOk KEOEOPDNMDN)
	{
		return default(EGECKPFNJNE<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2474250", Offset = "0x2473650", VA = "0x182474250")]
	public EGECKPFNJNE<TOk?, UErr?> PMEIPBBNLNE<UErr>()
	{
		return default(EGECKPFNJNE<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2473A50", Offset = "0x2472E50", VA = "0x182473A50")]
	public EGECKPFNJNE<UOk?, TErr?> MHDDOOIKPLA<UOk>()
	{
		return default(EGECKPFNJNE<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2472B60", Offset = "0x2471F60", VA = "0x182472B60")]
	public EGECKPFNJNE<UOk?, TErr?> DLNHKGKOBNG<UOk>()
	{
		return default(EGECKPFNJNE<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x24733E0", Offset = "0x24727E0", VA = "0x1824733E0")]
	public EGECKPFNJNE<TOk?, UErr?> KFDPOFBGFEK<UErr>()
	{
		return default(EGECKPFNJNE<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x32B50C0", Offset = "0x32B44C0", VA = "0x1832B50C0")]
	public EGECKPFNJNE<JDDDAABNCFI, TErr> AHCBOOJFLME()
	{
		return default(EGECKPFNJNE<JDDDAABNCFI, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x32B5DB0", Offset = "0x32B51B0", VA = "0x1832B5DB0")]
	public static bool AODPLFIFGHC([In] EGECKPFNJNE<TOk, TErr> NAJACJFDALM, [In] EGECKPFNJNE<TOk, TErr> AKBGGCAJIBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x32B69C0", Offset = "0x32B5DC0", VA = "0x1832B69C0", Slot = "4")]
	public bool Equals(EGECKPFNJNE<TOk, TErr> JLCJEDAFKJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x32B6520", Offset = "0x32B5920", VA = "0x1832B6520", Slot = "0")]
	public override bool Equals(object JLCJEDAFKJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x32B7DA0", Offset = "0x32B71A0", VA = "0x1832B7DA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x32B9CE0", Offset = "0x32B90E0", VA = "0x1832B9CE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class BPOLDJBGJEN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private struct EJNPJLLHFLL<TOk, TErr> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public AsyncTaskMethodBuilder<TOk> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public Task<EGECKPFNJNE<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private TaskAwaiter<EGECKPFNJNE<TOk, TErr>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x32DC630", Offset = "0x32DBA30", VA = "0x1832DC630", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x32DCF90", Offset = "0x32DC390", VA = "0x1832DCF90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x23FE110", Offset = "0x23FD510", VA = "0x1823FE110")]
	public static EGECKPFNJNE<TOk?, TErr?> CAIACGMOEKE<TOk, TErr>([In] this EGECKPFNJNE<TOk, TErr> LHCHBOKBAPK, [In] TOk KEOEOPDNMDN)
	{
		return default(EGECKPFNJNE<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x23FE1E0", Offset = "0x23FD5E0", VA = "0x1823FE1E0")]
	public static EGECKPFNJNE<JDDDAABNCFI, TErr?> CAIACGMOEKE<TErr>([In] this EGECKPFNJNE<JDDDAABNCFI, TErr> LHCHBOKBAPK)
	{
		return default(EGECKPFNJNE<JDDDAABNCFI, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x23FE110", Offset = "0x23FD510", VA = "0x1823FE110")]
	public static EGECKPFNJNE<TOk?, TErr?> FGGCILAIGEO<TOk, TErr>([In] this EGECKPFNJNE<TOk, TErr> LHCHBOKBAPK, [In] TErr IPCOJAKAILG)
	{
		return default(EGECKPFNJNE<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x23FDD30", Offset = "0x23FD130", VA = "0x1823FDD30")]
	public static TOk? AKPKJEKKHAA<TOk, TErr>([In] this EGECKPFNJNE<TOk, TErr> LHCHBOKBAPK)
	{
		return (TOk?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x23FECE0", Offset = "0x23FE0E0", VA = "0x1823FECE0")]
	[AsyncStateMachine(typeof(EJNPJLLHFLL<, >))]
	public static Task<TOk?>? HAONMPGPKFE<TOk, TErr>(this Task<EGECKPFNJNE<TOk, TErr>> LHCHBOKBAPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x24000F0", Offset = "0x23FF4F0", VA = "0x1824000F0")]
	public static TErr? MIDCBIBJFKL<TErr, TOk>([In] this EGECKPFNJNE<TOk, TErr> LHCHBOKBAPK)
	{
		return (TErr?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x23FF540", Offset = "0x23FE940", VA = "0x1823FF540")]
	public static bool JMHHIECDLKM<TOk, TErr, UErr, UOk>([In] this EGECKPFNJNE<TOk, TErr> LHCHBOKBAPK, [Out] EGECKPFNJNE<UOk, UErr> KFIMCGKKPCL) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x23FEF80", Offset = "0x23FE380", VA = "0x1823FEF80")]
	public static bool INGEHNJDIBI<TOk, TErr>([In] this EGECKPFNJNE<TOk, TErr> LHCHBOKBAPK, [Out][NotNullWhen(true)] TOk KEOEOPDNMDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x23FEC00", Offset = "0x23FE000", VA = "0x1823FEC00")]
	public static bool GCENFGNLKBP<TOk, TErr>([In] this EGECKPFNJNE<TOk, TErr> LHCHBOKBAPK, [Out][NotNullWhen(true)] TErr IPCOJAKAILG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x23FE260", Offset = "0x23FD660", VA = "0x1823FE260")]
	public static bool DCINIBDLAFB<TOk, TErr>([In] this EGECKPFNJNE<TOk, TErr> LHCHBOKBAPK, [Out][NotNullWhen(true)] TOk KEOEOPDNMDN, [Out][NotNullWhen(false)] TErr IPCOJAKAILG) where TOk : notnull where TErr : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x23FE010", Offset = "0x23FD410", VA = "0x1823FE010")]
	public static bool APPHJJFODHJ<TOk, TErr>([In] this EGECKPFNJNE<TOk, TErr> LHCHBOKBAPK, [Out][NotNullWhen(true)] TOk KEOEOPDNMDN, [Out] EGECKPFNJNE<TOk, TErr> KFIMCGKKPCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x23FF420", Offset = "0x23FE820", VA = "0x1823FF420")]
	public static bool JMHHIECDLKM<TOk, TErr, UErr, UOk>([In] this EGECKPFNJNE<TOk, TErr> LHCHBOKBAPK, [Out][NotNullWhen(true)] TOk KEOEOPDNMDN, [Out] EGECKPFNJNE<UOk, UErr> KFIMCGKKPCL) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x23FE980", Offset = "0x23FDD80", VA = "0x1823FE980")]
	public static bool FAMKJFEIMBO<TOk, TErr>([In] this EGECKPFNJNE<TOk, TErr> LHCHBOKBAPK, [Out][NotNullWhen(true)] TOk KEOEOPDNMDN, [Out] EGECKPFNJNE<JDDDAABNCFI, TErr> KFIMCGKKPCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x23FE350", Offset = "0x23FD750", VA = "0x1823FE350")]
	public static EGECKPFNJNE<UOk, UErr> DDMJNEJNCKA<UOk, UErr, TOk, TErr>([In] this EGECKPFNJNE<TOk, TErr> LHCHBOKBAPK, [In] EGECKPFNJNE<UOk, UErr> IBGLEOLMNIG) where TOk : UOk where TErr : UErr
	{
		return default(EGECKPFNJNE<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x23FEFF0", Offset = "0x23FE3F0", VA = "0x1823FEFF0")]
	public static EGECKPFNJNE<TOk?[]?, TErr?> JKKHEHLDENL<TOk, TErr>(this IEnumerable<EGECKPFNJNE<TOk, TErr>> LHCHBOKBAPK)
	{
		return default(EGECKPFNJNE<TOk[], TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class HPIEOGCFJKM<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x247D7A0", Offset = "0x247CBA0", VA = "0x18247D7A0")]
	public static EGECKPFNJNE<TOk, T> CAIACGMOEKE<TOk>([In] TOk KEOEOPDNMDN) where TOk : notnull
	{
		return default(EGECKPFNJNE<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x383FBC0", Offset = "0x383EFC0", VA = "0x18383FBC0")]
	public static EGECKPFNJNE<JDDDAABNCFI, T> CAIACGMOEKE()
	{
		return default(EGECKPFNJNE<JDDDAABNCFI, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x247D7A0", Offset = "0x247CBA0", VA = "0x18247D7A0")]
	public static EGECKPFNJNE<T, TErr> FGGCILAIGEO<TErr>([In] TErr IPCOJAKAILG) where TErr : notnull
	{
		return default(EGECKPFNJNE<T, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[DefaultMember("Item")]
public sealed class JPGGFGAALLI<T> : IEnumerable<T>, IEnumerable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	private readonly struct GCHDJCIJHPF : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly JPGGFGAALLI<T> NELFDJGOCDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly int BDOMONEGBCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly bool KEPGPDCHIAO;

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x1C339C0", Offset = "0x1C32DC0", VA = "0x181C339C0")]
		public GCHDJCIJHPF(JPGGFGAALLI<T> ABLKMCPEJAG, int EFKONCNFHKC, bool BLECAPHJJPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x3771840", Offset = "0x3770C40", VA = "0x183771840")]
		public JPGGFGAALLI<T>.GGHLPOJNGNG FPDPCEFPILF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x3771930", Offset = "0x3770D30", VA = "0x183771930", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x3771930", Offset = "0x3770D30", VA = "0x183771930", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public sealed class GGHLPOJNGNG : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly JPGGFGAALLI<T> NELFDJGOCDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly int NAPAOJNKKOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private int KHJOFDOKFFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private readonly bool KEPGPDCHIAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private bool PPBDGKJLDBC;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public T POOCHKNOAMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x377C920", Offset = "0x377BD20", VA = "0x18377C920")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x377CB10", Offset = "0x377BF10", VA = "0x18377CB10", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x377CCB0", Offset = "0x377C0B0", VA = "0x18377CCB0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x377D120", Offset = "0x377C520", VA = "0x18377D120")]
		public GGHLPOJNGNG(JPGGFGAALLI<T> ABLKMCPEJAG, int EFKONCNFHKC, bool BLECAPHJJPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x377C9A0", Offset = "0x377BDA0", VA = "0x18377C9A0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x377CA30", Offset = "0x377BE30", VA = "0x18377CA30", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class LOIHOBCJODK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
		public LOIHOBCJODK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x3C3CAB0", Offset = "0x3C3BEB0", VA = "0x183C3CAB0")]
		internal T FKOOKHGDJIJ(int _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly T[] KGAPIMKGDCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private int KHJOFDOKFFL;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int BJJCAOBMNMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x3AF7490", Offset = "0x3AF6890", VA = "0x183AF7490")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public T POOCHKNOAMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x363AD20", Offset = "0x363A120", VA = "0x18363AD20")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public T PBNNGCBPFCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x3AF77B0", Offset = "0x3AF6BB0", VA = "0x183AF77B0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public T GDDPFDKAEND
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x3AF7580", Offset = "0x3AF6980", VA = "0x183AF7580")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int KNKPDIOFOKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x16399E0", Offset = "0x1638DE0", VA = "0x1816399E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0xF12BB0", Offset = "0xF11FB0", VA = "0x180F12BB0")]
	private static int NAJBEKECBEB(int FGBBDGJMFEH, int OGHJPGGPGJL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3AF7AA0", Offset = "0x3AF6EA0", VA = "0x183AF7AA0")]
	public JPGGFGAALLI(int KKEOKHMHDHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3AF7880", Offset = "0x3AF6C80", VA = "0x183AF7880")]
	public JPGGFGAALLI(int KKEOKHMHDHC, Func<T> BNGEOMMPOND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3AF7A00", Offset = "0x3AF6E00", VA = "0x183AF7A00")]
	public JPGGFGAALLI(T[] MEKGNJLOKAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3AF7780", Offset = "0x3AF6B80", VA = "0x183AF7780")]
	public void LIMPIFFDMJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3AF76C0", Offset = "0x3AF6AC0", VA = "0x183AF76C0")]
	public IEnumerable<T> IEFGBPMMPOG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3AF7630", Offset = "0x3AF6A30", VA = "0x183AF7630")]
	public JPGGFGAALLI<T>.GGHLPOJNGNG FPDPCEFPILF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3702540", Offset = "0x3701940", VA = "0x183702540", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x3702540", Offset = "0x3701940", VA = "0x183702540", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class CKACPHGHOFH
{
	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x24606D0", Offset = "0x245FAD0", VA = "0x1824606D0")]
	public static JPGGFGAALLI<T> PIJMMFMEPKL<T>(int KKEOKHMHDHC, Func<T> BNGEOMMPOND) where T : notnull
	{
		return null;
	}
}
namespace RecRoom.NoEngine.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
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

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x1D169C0", Offset = "0x1D15DC0", VA = "0x181D169C0")]
		public RRColor(float LFEGGLDFJIF, float IPFKNKCPIED, float BLEBDLHLENH, float OJBODDLNJNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x609B570", Offset = "0x609A970", VA = "0x18609B570", Slot = "4")]
		public bool Equals(RRColor JLCJEDAFKJL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x609B5F0", Offset = "0x609A9F0", VA = "0x18609B5F0", Slot = "0")]
		public override bool Equals(object JLCJEDAFKJL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x609B6F0", Offset = "0x609AAF0", VA = "0x18609B6F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x609B770", Offset = "0x609AB70", VA = "0x18609B770", Slot = "5")]
		public string ToString(string NBMOIMOKFPB, IFormatProvider DFMJCLPKAHF)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public sealed class MIGBDPFLPDB<TData> : JIBPJLBDKCG where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly string ICOADANDNDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly TData LGDPHHJAFJI;

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x793EC0", Offset = "0x7932C0", VA = "0x180793EC0", Slot = "7")]
	public override string GPDEFFKCMGK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3E0AA00", Offset = "0x3E09E00", VA = "0x183E0AA00")]
	internal MIGBDPFLPDB(string AGOKDCAFCLN, [In] TData GMLIPIALCHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class EMPHPEFCICP
{
	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6098D30", Offset = "0x6098130", VA = "0x186098D30")]
	public static MIGBDPFLPDB<JDDDAABNCFI> PIJMMFMEPKL(string AGOKDCAFCLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x23E9D40", Offset = "0x23E9140", VA = "0x1823E9D40")]
	public static MIGBDPFLPDB<TData> PIJMMFMEPKL<TData>(string AGOKDCAFCLN, [In] TData GMLIPIALCHN) where TData : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class PODDOBLFBIB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly Dictionary<object, float> LOKAOHHOFAP;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public float OMMPECGNAPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x8A0F70", Offset = "0x8A0370", VA = "0x1808A0F70")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x8A1010", Offset = "0x8A0410", VA = "0x1808A1010")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x609B470", Offset = "0x609A870", VA = "0x18609B470")]
	public void HNKEHLMINJB(float PAHKKNONPEO, object KNOHBODGPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x609B2D0", Offset = "0x609A6D0", VA = "0x18609B2D0")]
	public void EMCDLAEMKII(object KNOHBODGPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x609B340", Offset = "0x609A740", VA = "0x18609B340")]
	private void FHJDBFKGDNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x609B4E0", Offset = "0x609A8E0", VA = "0x18609B4E0")]
	public PODDOBLFBIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public sealed class ONHCAMDALAP<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class AIDFCEOBBCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
		public AIDFCEOBBCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x374DD60", Offset = "0x374D160", VA = "0x18374DD60")]
		internal int PNIBGIOOAPB(int i, T token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private HashSet<T>? NILKAJKBLMF;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public IReadOnlyCollection<T> IDGPCEJAJLM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x3FAAC90", Offset = "0x3FAA090", VA = "0x183FAAC90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool FIKLBLKEBCH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x3FAAC50", Offset = "0x3FAA050", VA = "0x183FAAC50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int IGPGGFCOPJC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x78F1D0", Offset = "0x78E5D0", VA = "0x18078F1D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x7979D0", Offset = "0x796DD0", VA = "0x1807979D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x3FAA980", Offset = "0x3FA9D80", VA = "0x183FAA980")]
	public bool DEAIBIAHPPK(T KNOHBODGPLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x3FAAAF0", Offset = "0x3FA9EF0", VA = "0x183FAAAF0")]
	public bool FKMFNEFKHJM(T KNOHBODGPLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x3FAAC10", Offset = "0x3FAA010", VA = "0x183FAAC10")]
	public bool GHNKANFLKPF(T KNOHBODGPLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x3FAACC0", Offset = "0x3FAA0C0", VA = "0x183FAACC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
	public ONHCAMDALAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class GPDAMFONJMC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly string OOMEKMNFMCJ;

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7967D0", Offset = "0x795BD0", VA = "0x1807967D0")]
	public GPDAMFONJMC(string OOMEKMNFMCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6099E60", Offset = "0x6099260", VA = "0x186099E60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class GDJEDKCANMC
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class HIPCLNGONNM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
		public HIPCLNGONNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6099EB0", Offset = "0x60992B0", VA = "0x186099EB0")]
		internal int PNIBGIOOAPB(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private HashSet<object>? NILKAJKBLMF;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public IReadOnlyCollection<object> IDGPCEJAJLM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x60991D0", Offset = "0x60985D0", VA = "0x1860991D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool FIKLBLKEBCH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x60991C0", Offset = "0x60985C0", VA = "0x1860991C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int IGPGGFCOPJC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x78F1D0", Offset = "0x78E5D0", VA = "0x18078F1D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7979D0", Offset = "0x796DD0", VA = "0x1807979D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6098FE0", Offset = "0x60983E0", VA = "0x186098FE0")]
	public bool DEAIBIAHPPK(object KNOHBODGPLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x60990C0", Offset = "0x60984C0", VA = "0x1860990C0")]
	public bool FKMFNEFKHJM(object KNOHBODGPLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6099160", Offset = "0x6098560", VA = "0x186099160")]
	public bool GHNKANFLKPF(object KNOHBODGPLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6099260", Offset = "0x6098660", VA = "0x186099260")]
	public void LAFEPOJIFPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x60992D0", Offset = "0x60986D0", VA = "0x1860992D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
	public GDJEDKCANMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class MHNCAMLBMKD<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private struct ODDLJBGELME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public float FGAALGIIBJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public T BFBAIKCHJBC;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly Dictionary<object, ODDLJBGELME> LOKAOHHOFAP;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public virtual T CPFDPGEMNJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0xE38C70", Offset = "0xE38070", VA = "0x180E38C70", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0xE38240", Offset = "0xE37640", VA = "0x180E38240", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public object? HHLOEBMOMPB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x793FD0", Offset = "0x7933D0", VA = "0x180793FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x796860", Offset = "0x795C60", VA = "0x180796860")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public bool HAFMNCCMIFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x3E08830", Offset = "0x3E07C30", VA = "0x183E08830")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x3E08E40", Offset = "0x3E08240", VA = "0x183E08E40")]
	public bool HNKEHLMINJB(T PAHKKNONPEO, object KNOHBODGPLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x3775170", Offset = "0x3774570", VA = "0x183775170")]
	public bool EMCDLAEMKII(object KNOHBODGPLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3E07200", Offset = "0x3E06600", VA = "0x183E07200")]
	public void EKABOMHIFDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x3E09080", Offset = "0x3E08480", VA = "0x183E09080")]
	public bool KDHJGKFFEEJ(object KNOHBODGPLL, [Out] T PAHKKNONPEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x3E07550", Offset = "0x3E06950", VA = "0x183E07550")]
	[LHMPCJOJBFM("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool FNEAALJKELJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x3E09410", Offset = "0x3E08810", VA = "0x183E09410")]
	public MHNCAMLBMKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface NBHLHONPKNH
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event BHFCABIBPNA KPPIAPPLEHP;
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class PJKCKLMBKOA : NBHLHONPKNH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public readonly struct EGONKJOIEDP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public readonly float OFAAPPLMKAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly float BKNLDEHFEEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		internal readonly bool FOPNCONIKJO;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public float KKKENMPFNFM
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x6098A60", Offset = "0x6097E60", VA = "0x186098A60")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x6098BD0", Offset = "0x6097FD0", VA = "0x186098BD0")]
		public EGONKJOIEDP(float ANFKDBDICOO, float JICHEHMFLAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x6098A70", Offset = "0x6097E70", VA = "0x186098A70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class PGNLMMNLAJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public PJKCKLMBKOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
		public PGNLMMNLAJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x609A910", Offset = "0x6099D10", VA = "0x18609A910")]
		internal void MCKIAJPJPFJ(float innerProgress)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly int BPEPAFIGLCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private int GIMDJCADMAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly NBHLHONPKNH[] NFCCDNAJCKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly BHFCABIBPNA[] HLPGFGOCKFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly EGONKJOIEDP[] NBBGILMHDJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private EGONKJOIEDP GGOLKDJKHMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly FJHLKFIPKIB ADKCELLCHGC;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event BHFCABIBPNA KPPIAPPLEHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x609AAC0", Offset = "0x6099EC0", VA = "0x18609AAC0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x609AFF0", Offset = "0x609A3F0", VA = "0x18609AFF0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x609B140", Offset = "0x609A540", VA = "0x18609B140")]
	public PJKCKLMBKOA(int BPEPAFIGLCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x609B0B0", Offset = "0x609A4B0", VA = "0x18609B0B0")]
	public FJHLKFIPKIB PEOAKDCILHD(EGONKJOIEDP FDKIOAEOHPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x609AB80", Offset = "0x6099F80", VA = "0x18609AB80")]
	public void KMEIDIMBPIN(NBHLHONPKNH PMPOGHNMELN, [Optional] EGONKJOIEDP IKHOOPCICNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x609A9B0", Offset = "0x6099DB0", VA = "0x18609A9B0", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public delegate void BHFCABIBPNA(float MJLMFKDAGFL);
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class JMMDOKIKNIF
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	private class LBIBOHHIIMC : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private readonly NBHLHONPKNH HIKLMAEJIHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private readonly BHFCABIBPNA COPFOFGFOAL;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x609A800", Offset = "0x6099C00", VA = "0x18609A800")]
		public LBIBOHHIIMC(NBHLHONPKNH HIKLMAEJIHE, BHFCABIBPNA COPFOFGFOAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x609A7B0", Offset = "0x6099BB0", VA = "0x18609A7B0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x609A680", Offset = "0x6099A80", VA = "0x18609A680")]
	internal static bool AKCNGJFKPHG(float OJBODDLNJNK, float BLEBDLHLENH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x608E3F0", Offset = "0x608D7F0", VA = "0x18608E3F0")]
	internal static float CEGLGBKFCKA(float OJBODDLNJNK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x609A6F0", Offset = "0x6099AF0", VA = "0x18609A6F0")]
	public static IDisposable OEIHMKEABMF(this NBHLHONPKNH HIKLMAEJIHE, BHFCABIBPNA COPFOFGFOAL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class FJHLKFIPKIB : NBHLHONPKNH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private float MJLMFKDAGFL;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public float PPFNDDNLFBG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6098E50", Offset = "0x6098250", VA = "0x186098E50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event BHFCABIBPNA? KPPIAPPLEHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x6098DB0", Offset = "0x60981B0", VA = "0x186098DB0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6098F40", Offset = "0x6098340", VA = "0x186098F40", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
	public FJHLKFIPKIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public class LIDFOCLHLCK : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x5BBF1C0", Offset = "0x5BBE5C0", VA = "0x185BBF1C0")]
	public LIDFOCLHLCK(string AGOKDCAFCLN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[DefaultMember("Item")]
public class HBEJFLHGGHD<TKey, TValue> : IEDLIFHBAJC<TKey, TValue>, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, PAIBAMPJJNM where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class HFAMOMHIPIC : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private KeyValuePair<TKey, TValue> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public HBEJFLHGGHD<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private IEnumerator<KeyValuePair<TKey, TValue>> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		KeyValuePair<TKey, TValue> IEnumerator<KeyValuePair<TKey, TValue>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0xE38C70", Offset = "0xE38070", VA = "0x180E38C70", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TValue>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x381C450", Offset = "0x381B850", VA = "0x18381C450", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x7953B0", Offset = "0x7947B0", VA = "0x1807953B0")]
		[DebuggerHidden]
		public HFAMOMHIPIC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x34BBA40", Offset = "0x34BAE40", VA = "0x1834BBA40", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x381B730", Offset = "0x381AB30", VA = "0x18381B730", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x381C310", Offset = "0x381B710", VA = "0x18381C310")]
		private void OPFNICOLGEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x381B640", Offset = "0x381AA40", VA = "0x18381B640")]
		private void JJCMEKBDGNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x381C3B0", Offset = "0x381B7B0", VA = "0x18381C3B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly IEDLIFHBAJC<TKey, TValue> COJGFDLMFLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private readonly IDictionary<TKey, TValue> GAHAOFAMDFK;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int IGPGGFCOPJC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x3802CD0", Offset = "0x38020D0", VA = "0x183802CD0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool JMFGLNFGMFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x7D85C0", Offset = "0x7D79C0", VA = "0x1807D85C0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public TValue GDDPFDKAEND
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x3802F70", Offset = "0x3802370", VA = "0x183802F70", Slot = "4")]
		get
		{
			return (TValue)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x38031F0", Offset = "0x38025F0", VA = "0x1838031F0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public ICollection<TKey> MPIHEDMFMMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x3802FB0", Offset = "0x38023B0", VA = "0x183802FB0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public ICollection<TValue> DBCDJIFOCAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x38030C0", Offset = "0x38024C0", VA = "0x1838030C0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x3802C20", Offset = "0x3802020", VA = "0x183802C20")]
	public HBEJFLHGGHD(IEDLIFHBAJC<TKey, TValue> COJGFDLMFLN, [Optional] IDictionary<TKey, TValue>? GAHAOFAMDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x3800E60", Offset = "0x3800260", VA = "0x183800E60", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x38019C0", Offset = "0x3800DC0", VA = "0x1838019C0")]
	public void GCHOMCOFPBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x3800000", Offset = "0x37FF400", VA = "0x183800000", Slot = "9")]
	public void Add(TKey CONEAMPCFEL, TValue PAHKKNONPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x3801A10", Offset = "0x3800E10", VA = "0x183801A10")]
	public void GDBHGGIGJMA(TKey CONEAMPCFEL, TValue PAHKKNONPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x38004C0", Offset = "0x37FF8C0", VA = "0x1838004C0")]
	public void BABNGNCDADF(TKey CONEAMPCFEL, TValue PAHKKNONPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x3800AD0", Offset = "0x37FFED0", VA = "0x183800AD0")]
	public void CCGCMEEHACH(TKey CONEAMPCFEL, TValue PAHKKNONPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x38007D0", Offset = "0x37FFBD0", VA = "0x1838007D0")]
	public void BHJFALIMOBA(TKey CONEAMPCFEL, TValue PAHKKNONPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x3802260", Offset = "0x3801660", VA = "0x183802260", Slot = "14")]
	void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> JCBFPBHHLOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x3802440", Offset = "0x3801840", VA = "0x183802440", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> JCBFPBHHLOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x38027A0", Offset = "0x3801BA0", VA = "0x1838027A0", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> JCBFPBHHLOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x3800ED0", Offset = "0x38002D0", VA = "0x183800ED0", Slot = "8")]
	public bool ContainsKey(TKey CONEAMPCFEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x38008D0", Offset = "0x37FFCD0", VA = "0x1838008D0")]
	public bool CABCNPKKOGL(TKey CONEAMPCFEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x3801F00", Offset = "0x3801300", VA = "0x183801F00")]
	public bool OMFOCPKOGJG(TKey CONEAMPCFEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x3802090", Offset = "0x3801490", VA = "0x183802090", Slot = "10")]
	public bool Remove(TKey CONEAMPCFEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x3802A70", Offset = "0x3801E70", VA = "0x183802A70", Slot = "11")]
	public bool TryGetValue(TKey CONEAMPCFEL, [Out] TValue PAHKKNONPEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x38014C0", Offset = "0x38008C0", VA = "0x1838014C0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TValue>[] CBCBEPHCJOP, int LNMJODKMHJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x3802960", Offset = "0x3801D60", VA = "0x183802960", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x3801D20", Offset = "0x3801120", VA = "0x183801D20", Slot = "19")]
	[IteratorStateMachine(typeof(HBEJFLHGGHD<, >.HFAMOMHIPIC))]
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x3801E50", Offset = "0x3801250", VA = "0x183801E50", Slot = "21")]
	public bool LOBMLIGBLPN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x38018C0", Offset = "0x3800CC0", VA = "0x1838018C0")]
	private TValue DOFBBEEPNDJ(TKey CONEAMPCFEL)
	{
		return (TValue)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface PAIBAMPJJNM
{
	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LOBMLIGBLPN();
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface IEDLIFHBAJC<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, PAIBAMPJJNM
{
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
[DefaultMember("Item")]
public sealed class AJMFJCPHOPA<TKey, TVal> : IEDLIFHBAJC<TKey, TVal>, IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, PAIBAMPJJNM where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public delegate int CNIGAGDGCOO(TKey CONEAMPCFEL, TVal PAHKKNONPEO);

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private class FFKPNFAOHML
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public TKey EALKNHCDKOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0xB5FAF0", Offset = "0xB5EEF0", VA = "0x180B5FAF0")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public TVal BFBAIKCHJBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x8C5130", Offset = "0x8C4530", VA = "0x1808C5130")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x8C5120", Offset = "0x8C4520", VA = "0x1808C5120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public int KKKENMPFNFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x7CF690", Offset = "0x7CEA90", VA = "0x1807CF690")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x7CED20", Offset = "0x7CE120", VA = "0x1807CED20")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public DateTimeOffset CHFPKDFBBKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0xA31AA0", Offset = "0xA30EA0", VA = "0x180A31AA0")]
			[CompilerGenerated]
			get
			{
				return default(DateTimeOffset);
			}
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x1291F40", Offset = "0x1291340", VA = "0x181291F40")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x3695F60", Offset = "0x3695360", VA = "0x183695F60")]
		public FFKPNFAOHML(TKey CONEAMPCFEL, TVal OFNBMJMBJHA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private sealed class LFJBKJALDIN : IEnumerator<KeyValuePair<TKey, TVal>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private KeyValuePair<TKey, TVal> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public AJMFJCPHOPA<TKey, TVal> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private LinkedList<FFKPNFAOHML>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		KeyValuePair<TKey, TVal> IEnumerator<KeyValuePair<TKey, TVal>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0xE38C70", Offset = "0xE38070", VA = "0x180E38C70", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TVal>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x3C11ED0", Offset = "0x3C112D0", VA = "0x183C11ED0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x7953B0", Offset = "0x7947B0", VA = "0x1807953B0")]
		[DebuggerHidden]
		public LFJBKJALDIN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x32B3190", Offset = "0x32B2590", VA = "0x1832B3190", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x3C10CF0", Offset = "0x3C100F0", VA = "0x183C10CF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x3C11980", Offset = "0x3C10D80", VA = "0x183C11980")]
		private void OPFNICOLGEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x3C11CF0", Offset = "0x3C110F0", VA = "0x183C11CF0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public const int HKBPGGFMGAE = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly Dictionary<TKey, LinkedListNode<FFKPNFAOHML>> PJLKNBMCHBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly LinkedList<FFKPNFAOHML> CNEMNGPFGJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly CNIGAGDGCOO? CMJHMEMCAIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly TimeSpan NNBHCPEALFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly OMCFMCIBMJI IIDIPINGLPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private bool LLHKFCDCPDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly List<TKey> APHAAPOLIIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly List<TVal> BKMLEJHIPHH;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public int PGLEDIIDNKM
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x7AEBC0", Offset = "0x7ADFC0", VA = "0x1807AEBC0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	internal int IGJIOPKGDOC
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x7AEBD0", Offset = "0x7ADFD0", VA = "0x1807AEBD0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0xE2BAF0", Offset = "0xE2AEF0", VA = "0x180E2BAF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public int IGPGGFCOPJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x3760660", Offset = "0x375FA60", VA = "0x183760660", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	internal int BFJEDNFIFKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x375BE10", Offset = "0x375B210", VA = "0x18375BE10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public ICollection<TVal> DBCDJIFOCAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x3760790", Offset = "0x375FB90", VA = "0x183760790", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	ICollection<TKey> IDictionary<TKey, TVal>.PFFKICIHMCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x375D500", Offset = "0x375C900", VA = "0x18375D500", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool JMFGLNFGMFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x7D85C0", Offset = "0x7D79C0", VA = "0x1807D85C0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public TVal GDDPFDKAEND
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x3760740", Offset = "0x375FB40", VA = "0x183760740", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x3760820", Offset = "0x375FC20", VA = "0x183760820", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x3757A60", Offset = "0x3756E60", VA = "0x183757A60")]
	private bool FGGHLADMCOC(int BPEPAFIGLCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x375BEC0", Offset = "0x375B2C0", VA = "0x18375BEC0")]
	private void MNHIHCCNKDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x375E5E0", Offset = "0x375D9E0", VA = "0x18375E5E0")]
	public AJMFJCPHOPA(int BPEPAFIGLCD, [Optional] CNIGAGDGCOO? CMJHMEMCAIC, [Optional] IEqualityComparer<TKey>? IDDBJPNFLPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x375DFE0", Offset = "0x375D3E0", VA = "0x18375DFE0")]
	public AJMFJCPHOPA(TimeSpan NNBHCPEALFP, [Optional] IEqualityComparer<TKey>? IDDBJPNFLPF, [Optional] OMCFMCIBMJI? IIDIPINGLPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x375E420", Offset = "0x375D820", VA = "0x18375E420")]
	public AJMFJCPHOPA(int BPEPAFIGLCD, TimeSpan NNBHCPEALFP, [Optional] IEqualityComparer<TKey>? IDDBJPNFLPF, [Optional] OMCFMCIBMJI? IIDIPINGLPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x375EC20", Offset = "0x375E020", VA = "0x18375EC20")]
	public AJMFJCPHOPA(int BPEPAFIGLCD, CNIGAGDGCOO? CMJHMEMCAIC, TimeSpan NNBHCPEALFP, [Optional] IEqualityComparer<TKey>? IDDBJPNFLPF, [Optional] OMCFMCIBMJI? IIDIPINGLPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x375BE50", Offset = "0x375B250", VA = "0x18375BE50", Slot = "21")]
	public bool LOBMLIGBLPN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x3752C40", Offset = "0x3752040", VA = "0x183752C40", Slot = "22")]
	public bool AKHDPJCFOPO(int KKEOKHMHDHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x3754030", Offset = "0x3753430", VA = "0x183754030")]
	private bool BIEKEDLIIBH(int KKEOKHMHDHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x375C4D0", Offset = "0x375B8D0", VA = "0x18375C4D0")]
	public void NIEAIDPCAEB(TKey CONEAMPCFEL, TVal PAHKKNONPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x3753790", Offset = "0x3752B90", VA = "0x183753790", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> JCBFPBHHLOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x37537D0", Offset = "0x3752BD0", VA = "0x1837537D0", Slot = "9")]
	public void Add(TKey CONEAMPCFEL, TVal PAHKKNONPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x3754320", Offset = "0x3753720", VA = "0x183754320", Slot = "8")]
	public bool ContainsKey(TKey CONEAMPCFEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x375CA70", Offset = "0x375BE70", VA = "0x18375CA70", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Contains(KeyValuePair<TKey, TVal> JCBFPBHHLOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x375C880", Offset = "0x375BC80", VA = "0x18375C880", Slot = "10")]
	public bool Remove(TKey CONEAMPCFEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x375CF40", Offset = "0x375C340", VA = "0x18375CF40", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Remove(KeyValuePair<TKey, TVal> JCBFPBHHLOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x375AF70", Offset = "0x375A370", VA = "0x18375AF70")]
	private bool KNJEJHMMHNE(TKey CONEAMPCFEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x375BD10", Offset = "0x375B110", VA = "0x18375BD10")]
	private TVal LBFOALNGCEO(TKey MFKIEOAPBHA)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x375D730", Offset = "0x375CB30", VA = "0x18375D730", Slot = "11")]
	public bool TryGetValue(TKey MFKIEOAPBHA, [Out] TVal PAHKKNONPEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x3754290", Offset = "0x3753690", VA = "0x183754290", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x3754860", Offset = "0x3753C60", VA = "0x183754860", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] CBCBEPHCJOP, int LNMJODKMHJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x3756FE0", Offset = "0x37563E0", VA = "0x183756FE0")]
	private bool DMFJCAOKKFG(FFKPNFAOHML LOKHPLPDKGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x37587B0", Offset = "0x3757BB0", VA = "0x1837587B0")]
	private void HHEOFLEHCPM(LinkedListNode<FFKPNFAOHML> OHFAPAIPJPD, TVal NKJNNAKEBHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x3759C70", Offset = "0x3759070", VA = "0x183759C70")]
	private void HNKEHLMINJB(TKey CONEAMPCFEL, TVal PAHKKNONPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x3756320", Offset = "0x3755720", VA = "0x183756320")]
	private void DCIEHPENFOM(FFKPNFAOHML LOKHPLPDKGE, TVal NKJNNAKEBHP, int DMNOACHOKOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x3757C60", Offset = "0x3757060", VA = "0x183757C60", Slot = "19")]
	[IteratorStateMachine(typeof(AJMFJCPHOPA<, >.LFJBKJALDIN))]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x375D530", Offset = "0x375C930", VA = "0x18375D530", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class GIJILKJICNB<TId, TResource> : IEnumerable<(TId, Task<TResource>, int)>, IEnumerable where TId : notnull where TResource : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private sealed class ELJPHLKEFAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public Func<TId, CancellationToken, Task<TResource>> factory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public GIJILKJICNB<TId, TResource> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
		public ELJPHLKEFAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x32E3670", Offset = "0x32E2A70", VA = "0x1832E3670")]
		internal Task<TResource> KCIMEODDBMO(TId _id)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private struct KHPEONFLDNB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public Dictionary<Task<TResource>, CancellationTokenSource> cancellationTokenSources;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public CancellationTokenSource cts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x3B43520", Offset = "0x3B42920", VA = "0x183B43520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x3B43F40", Offset = "0x3B43340", VA = "0x183B43F40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private struct DAMEPEHMBPA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public Action<TResource> cleanup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x4F84C60", Offset = "0x4F84060", VA = "0x184F84C60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x4F853E0", Offset = "0x4F847E0", VA = "0x184F853E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly HMFGHCCNCHK<TId, Task<TResource>> HKIEKAFGKEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly Dictionary<Task<TResource>, CancellationTokenSource> IFADOGPMCHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly Func<TId, CancellationToken, Task<TResource>>? KJLHILKMMFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly Action<TResource>? OCIOPJDOIJE;

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x3780190", Offset = "0x377F590", VA = "0x183780190")]
	public GIJILKJICNB(int BMGOHACPBOO = 0, [Optional] IEqualityComparer<TId>? DPJBCJFMNLG, [Optional] Func<TId, CancellationToken, Task<TResource>>? EDLFAJLJLJG, [Optional] Action<TResource>? CGCCIMIJPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x377F630", Offset = "0x377EA30", VA = "0x18377F630")]
	public LPCLHFEGNKE<Task<TResource>> FEALGKNPPLN(TId NONJEEALACK, [Optional] Func<TId, CancellationToken, Task<TResource>>? EDLFAJLJLJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x377F4F0", Offset = "0x377E8F0", VA = "0x18377F4F0")]
	private void DDANGDLIKOG(Task<TResource> ADFIKOFONEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x377F600", Offset = "0x377EA00", VA = "0x18377F600")]
	public void EIANEHKDKLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x377FB40", Offset = "0x377EF40", VA = "0x18377FB40")]
	public HMFGHCCNCHK<TId, Task<TResource>>.OEDANGCIAHD FPDPCEFPILF()
	{
		return default(HMFGHCCNCHK<TId, Task<TResource>>.OEDANGCIAHD);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x37800F0", Offset = "0x377F4F0", VA = "0x1837800F0", Slot = "4")]
	private IEnumerator<(TId, Task<TResource>, int)> System.Collections.Generic.IEnumerable<(TIdId,System.Threading.Tasks.Task<TResource>LoadResourceTask,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x37800F0", Offset = "0x377F4F0", VA = "0x1837800F0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x377EF40", Offset = "0x377E340", VA = "0x18377EF40")]
	[AsyncStateMachine(typeof(GIJILKJICNB<, >.KHPEONFLDNB))]
	[CompilerGenerated]
	internal static Task BLMOOPKOILL(Task<TResource> ADFIKOFONEM, CancellationTokenSource EEFEMHDDMBG, Dictionary<Task<TResource>, CancellationTokenSource> BOHDADPDCDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x377FC90", Offset = "0x377F090", VA = "0x18377FC90")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(GIJILKJICNB<, >.DAMEPEHMBPA))]
	internal static Task GKJDDFBHIGJ(Task<TResource> ADFIKOFONEM, Action<TResource> BOOCBLKFPHD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class HMFGHCCNCHK<TKey, TValue> : IEnumerable<(TKey, TValue, int)>, IEnumerable where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private sealed class MFKHOGAFPBC : IEquatable<MFKHOGAFPBC>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public readonly TValue BFBAIKCHJBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public int PPFDFGCJGEK;

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x1BA93A0", Offset = "0x1BA87A0", VA = "0x181BA93A0")]
		public MFKHOGAFPBC(TValue PAHKKNONPEO, int IDCHLNOBICO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x3E02980", Offset = "0x3E01D80", VA = "0x183E02980", Slot = "4")]
		public bool Equals(MFKHOGAFPBC? JLCJEDAFKJL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x3E02A10", Offset = "0x3E01E10", VA = "0x183E02A10", Slot = "0")]
		public override bool Equals(object? DFFBALIDCLL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x3E02AB0", Offset = "0x3E01EB0", VA = "0x183E02AB0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public struct OEDANGCIAHD : IEnumerator<(TKey, TValue, int)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private Dictionary<TKey, MFKHOGAFPBC>.Enumerator LPNMKPGOKHO;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x3F8C2C0", Offset = "0x3F8B6C0", VA = "0x183F8C2C0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public (TKey Key, TValue Value, int RefCount) POOCHKNOAMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x3F8C780", Offset = "0x3F8BB80", VA = "0x183F8C780", Slot = "4")]
			get
			{
				return default((TKey, TValue, int));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x3F8C400", Offset = "0x3F8B800", VA = "0x183F8C400")]
		public OEDANGCIAHD(HMFGHCCNCHK<TKey, TValue> LOKAOHHOFAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x3F8BF00", Offset = "0x3F8B300", VA = "0x183F8BF00", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x3F8BF80", Offset = "0x3F8B380", VA = "0x183F8BF80", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x3F8C000", Offset = "0x3F8B400", VA = "0x183F8C000", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private sealed class AOIJNCJGAMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public HMFGHCCNCHK<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public TKey key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public MFKHOGAFPBC refCountedValue;

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
		public AOIJNCJGAMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x38A1CA0", Offset = "0x38A10A0", VA = "0x1838A1CA0")]
		internal void KCIMEODDBMO()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly Dictionary<TKey, MFKHOGAFPBC> IHEOJJJKDKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly Func<TKey, TValue>? GHNDCKNGOIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly Action<TValue>? IOIHFFHDMLA;

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x3833410", Offset = "0x3832810", VA = "0x183833410")]
	public HMFGHCCNCHK(int BMGOHACPBOO = 0, [Optional] IEqualityComparer<TKey>? IDDBJPNFLPF, [Optional] Func<TKey, TValue>? HEFIFELKEAG, [Optional] Action<TValue>? JEBKEALAGKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x3832610", Offset = "0x3831A10", VA = "0x183832610")]
	public LPCLHFEGNKE<TValue> FEALGKNPPLN(TKey CONEAMPCFEL, [Optional] Func<TKey, TValue>? EHNNNBBKENE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x3833080", Offset = "0x3832480", VA = "0x183833080")]
	private void FEPCPPOBHNL(TKey CONEAMPCFEL, MFKHOGAFPBC JOJJFGABBDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x3832430", Offset = "0x3831830", VA = "0x183832430")]
	public void EIANEHKDKLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x38331C0", Offset = "0x38325C0", VA = "0x1838331C0")]
	public OEDANGCIAHD FPDPCEFPILF()
	{
		return default(OEDANGCIAHD);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x3833370", Offset = "0x3832770", VA = "0x183833370", Slot = "4")]
	private IEnumerator<(TKey, TValue, int)> System.Collections.Generic.IEnumerable<(TKeyKey,TValueValue,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x3833370", Offset = "0x3832770", VA = "0x183833370", Slot = "5")]
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
