using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.DataLayer.Attributes;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8AE160", Offset = "0x8ACB60", VA = "0x1808AE160")]
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
		[Cpp2IlInjected.Address(RVA = "0x6BDA760", Offset = "0x6BD9160", VA = "0x186BDA760")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8AE5A0", Offset = "0x8ACFA0", VA = "0x1808AE5A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8AE5E0", Offset = "0x8ACFE0", VA = "0x1808AE5E0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Maker_Core_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[Preserve]
	public class _AssemblyIndex : FDEGBGNEMEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6BDA7E0", Offset = "0x6BD91E0", VA = "0x186BDA7E0", Slot = "8")]
		public override void CPJKPCOPIOF(INNEGFJDCKJ registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x626DEE0", Offset = "0x626C8E0", VA = "0x18626DEE0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface IABFFDHGKBE<TData, TReturn>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TReturn DJFENBIFHKD(TData FHFDEAHMMBI);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface GBHOKNJLGHF<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ClearHoverTarget(OPAMNFGEEHC GHMAHAHAOCL);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool SetHoverTarget(TData CDHECNAFHCH, Collider GOMJGCFDIAJ, OPAMNFGEEHC GHMAHAHAOCL, [Optional] OHFCNPENGBB? BOECMKANALC);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool TryGetHoverTarget([Out] TData CDHECNAFHCH);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetHoverCollider([Out] Collider GOMJGCFDIAJ);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface KLNJKFHAAGM<TData> : AJFFMINIOAD, FPOJCCPALAN<TData>, BDMDBJBPFHJ<TData>, DEHNEBNMING<TData>, ELCPNECNDPK, KKFEMMJNJGN<TData>, CFMLNGJIHCJ, OEFDGJLCHAJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface KKFEMMJNJGN<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 AAJPOGDAOAO, Vector3 FJODMBFILLK, float PEAKDEKJAOG, [Out] T KIEPDPBNEKB, [Out] Vector3 GECPFJCOAFI, [Out] Collider GOMJGCFDIAJ);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 AAJPOGDAOAO, Vector3 FJODMBFILLK, float IEEJPALELJG, float PEAKDEKJAOG, T[] MHDEGNFCCGF, [Out] Vector3 KOPMPMKKDIO, [Out] Collider NCKEIJODMNJ);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 AAJPOGDAOAO, float IEEJPALELJG, Vector3 BCALDPLHBLF, T[] MHDEGNFCCGF);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetObjectFromColliderInCurrentScope(Collider CFMHFMLEKHC, [Out] T MMDLLNPGAOO);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface AJFFMINIOAD
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Bounds CKNMIGGINNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Transform JBGOHCHMOJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Bounds NJJFAJLCJHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Transform HJHEIPAJKDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Vector3 GMNEIKPIEGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool LGBGFDPGBKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void SetSelectionBoundsDirty(bool ONLDJHMNMNF = true, int IHDGEJMKFEM = 0);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ShouldHideSelectionBoundsPreview(bool JFENLGMKJKD, object OEELDHBFFAF);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface OEFDGJLCHAJ
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	BPJHNJKJMPB AAFIMIFEHPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface HOJDKPBKGOC
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool MCNFDJNCALD
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool DLMJKJNKBJP
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool JBHHBNMLBGG
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Dictionary<Guid, Guid> TryGetPreviousCloneMapping();

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void TrySetPreviousCloneMapping(Dictionary<Guid, Guid> GKIALIHBJED);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface DEHNEBNMING<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool NEBMGLABFIK
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int KAMGAOPCFGM
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<TData> BBMJPKNJCNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData LHFGBAJKEKO);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData LHFGBAJKEKO);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface FPOJCCPALAN<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T FHFDEAHMMBI, [Optional] OHFCNPENGBB? NNKPOGBBDGK, bool OPCJPCLIGGD = true);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int CMNDBGDABDM, IEnumerable<T> JMHFDCNLPLK, bool OPCJPCLIGGD = true);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int CMNDBGDABDM, IEnumerable<T> JMHFDCNLPLK, OHFCNPENGBB NNKPOGBBDGK, bool OPCJPCLIGGD = true);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface CFMLNGJIHCJ
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface ELCPNECNDPK
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool ABBOIGHJMGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool MMHNNKFGJIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool DFDANCNHLOA
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool PPFFILJAEOL
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class OOCKFDIBJDA<TReceiver> : DGBNLLOCHNL<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3A24380", Offset = "0x3A22D80", VA = "0x183A24380")]
	public OOCKFDIBJDA(TReceiver KEFFHAHOJNE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public abstract class BPPDBANNDMK<TReceiver, TFromTask> : DGBNLLOCHNL<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3A24380", Offset = "0x3A22D80", VA = "0x183A24380")]
	public BPPDBANNDMK(TReceiver KEFFHAHOJNE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public abstract class DGBNLLOCHNL<TReceiver, TFromExecute> where TReceiver : notnull where TFromExecute : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	protected TReceiver KEFFHAHOJNE;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5A94D70", Offset = "0x5A93770", VA = "0x185A94D70")]
	public DGBNLLOCHNL(TReceiver KEFFHAHOJNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute DBFKLINPIFI();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class JFLGAGFPPLC<TReceiver, TResult> : DGBNLLOCHNL<TReceiver, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3A24380", Offset = "0x3A22D80", VA = "0x183A24380")]
	public JFLGAGFPPLC(TReceiver KEFFHAHOJNE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct KAHADIHGCJM<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public TGroup NFNNDCMJNJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public TData PHPGADPCNJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public IEnumerable<TData> NELHOLNAKDG;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2027E50", Offset = "0x2026850", VA = "0x182027E50")]
	public KAHADIHGCJM(TGroup GENKBOCDMHD, TData GBFNFCIKPDA, IEnumerable<TData> PMLDAPGFKFO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct KFAKPKFDBMA<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public TGroup NFNNDCMJNJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public IEnumerable<TData> NELHOLNAKDG;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0xCEC2C0", Offset = "0xCEACC0", VA = "0x180CEC2C0")]
	public KFAKPKFDBMA(TGroup GENKBOCDMHD, IEnumerable<TData> PMLDAPGFKFO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct POHCOMDGPPM<TGroup> where TGroup : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public TGroup NFNNDCMJNJK;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0xB63000", Offset = "0xB61A00", VA = "0x180B63000")]
	public POHCOMDGPPM(TGroup GENKBOCDMHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct CDOMOOMIPFP<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public IEnumerable<TData> NELHOLNAKDG;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0xB63000", Offset = "0xB61A00", VA = "0x180B63000")]
	public CDOMOOMIPFP(IEnumerable<TData> PMLDAPGFKFO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface EOBABFKAIEM<TGroup, TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EEOPJIHIOBE EJDHOFPKGGM(KAHADIHGCJM<TGroup, TData> NLKGKDAPEPF);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "1")]
	EEOPJIHIOBE GDHBCIKLGEI(KAHADIHGCJM<TGroup, TData> NLKGKDAPEPF);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EEOPJIHIOBE HLJKPFAAAPN(KFAKPKFDBMA<TGroup, TData> NLKGKDAPEPF);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "3")]
	EEOPJIHIOBE LMEDHKODKGA(POHCOMDGPPM<TGroup> NLKGKDAPEPF);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface DEHMEKPIDDC<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<EEOPJIHIOBE> EJDHOFPKGGM(CDOMOOMIPFP<TData> NLKGKDAPEPF);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class IMECCBGDGBP<TGroup, TData> : JFLGAGFPPLC<EOBABFKAIEM<TGroup, TData>, EEOPJIHIOBE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly KFAKPKFDBMA<TGroup, TData> NLKGKDAPEPF;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x40A99D0", Offset = "0x40A83D0", VA = "0x1840A99D0")]
	public IMECCBGDGBP(TGroup GENKBOCDMHD, IEnumerable<TData> PMLDAPGFKFO, EOBABFKAIEM<TGroup, TData> KEFFHAHOJNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x40A9900", Offset = "0x40A8300", VA = "0x1840A9900", Slot = "4")]
	public override EEOPJIHIOBE DBFKLINPIFI()
	{
		return default(EEOPJIHIOBE);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class KKOIMCOEJIJ<TGroup, TData> : JFLGAGFPPLC<EOBABFKAIEM<TGroup, TData>, EEOPJIHIOBE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly KAHADIHGCJM<TGroup, TData> NLKGKDAPEPF;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x43DE260", Offset = "0x43DCC60", VA = "0x1843DE260")]
	public KKOIMCOEJIJ(TGroup GENKBOCDMHD, TData LOIFHGMEMII, IEnumerable<TData> PMLDAPGFKFO, EOBABFKAIEM<TGroup, TData> KEFFHAHOJNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x43DE190", Offset = "0x43DCB90", VA = "0x1843DE190", Slot = "4")]
	public override EEOPJIHIOBE DBFKLINPIFI()
	{
		return default(EEOPJIHIOBE);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class JPIHNCOEFGJ<TGroup, TData> : JFLGAGFPPLC<EOBABFKAIEM<TGroup, TData>, EEOPJIHIOBE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly POHCOMDGPPM<TGroup> NLKGKDAPEPF;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3E013E0", Offset = "0x3DFFDE0", VA = "0x183E013E0")]
	public JPIHNCOEFGJ(TGroup GENKBOCDMHD, EOBABFKAIEM<TGroup, TData> KEFFHAHOJNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4310110", Offset = "0x430EB10", VA = "0x184310110", Slot = "4")]
	public override EEOPJIHIOBE DBFKLINPIFI()
	{
		return default(EEOPJIHIOBE);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class DHIAHCPINPH<TGroup, TData> : JFLGAGFPPLC<EOBABFKAIEM<TGroup, TData>, EEOPJIHIOBE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly KAHADIHGCJM<TGroup, TData> NLKGKDAPEPF;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x43DE260", Offset = "0x43DCC60", VA = "0x1843DE260")]
	public DHIAHCPINPH(TGroup GENKBOCDMHD, TData GBFNFCIKPDA, IEnumerable<TData> PMLDAPGFKFO, EOBABFKAIEM<TGroup, TData> KEFFHAHOJNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5A9B240", Offset = "0x5A99C40", VA = "0x185A9B240", Slot = "4")]
	public override EEOPJIHIOBE DBFKLINPIFI()
	{
		return default(EEOPJIHIOBE);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class GCCKPDHMCDM<TData> : BPPDBANNDMK<DEHMEKPIDDC<TData>, EEOPJIHIOBE> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private struct ODKJGEBDCII : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AsyncTaskMethodBuilder<EEOPJIHIOBE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public GCCKPDHMCDM<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private TaskAwaiter<EEOPJIHIOBE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x48D9440", Offset = "0x48D7E40", VA = "0x1848D9440", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x48D96E0", Offset = "0x48D80E0", VA = "0x1848D96E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private CDOMOOMIPFP<TData> NLKGKDAPEPF;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3E013E0", Offset = "0x3DFFDE0", VA = "0x183E013E0")]
	public GCCKPDHMCDM(IEnumerable<TData> NJJHGLLBNHG, DEHMEKPIDDC<TData> KEFFHAHOJNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3EC1A60", Offset = "0x3EC0460", VA = "0x183EC1A60", Slot = "4")]
	[AsyncStateMachine(typeof(GCCKPDHMCDM<>.ODKJGEBDCII))]
	public override Task<EEOPJIHIOBE> DBFKLINPIFI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public readonly struct MLKAEDMKIKL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly CFIAJJIOCAF KLDDGKEOPBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly bool MIOPHAJCBAH;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6BDA5A0", Offset = "0x6BD8FA0", VA = "0x186BDA5A0")]
	public MLKAEDMKIKL(CFIAJJIOCAF FMFLAEIAJAM, bool BGALPFEPBCM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface KCMBLKBEIOD<TSpawnType> where TSpawnType : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> DBFKLINPIFI(MLKAEDMKIKL IHGPGJFIAAC);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class PCDBPKABDKN<TSpawnType> : BPPDBANNDMK<KCMBLKBEIOD<TSpawnType>, TSpawnType> where TSpawnType : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private struct HEOJCLKEHFN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public AsyncTaskMethodBuilder<TSpawnType> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public PCDBPKABDKN<TSpawnType> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskAwaiter<TSpawnType> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x3F4FB90", Offset = "0x3F4E590", VA = "0x183F4FB90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x3EE5BF0", Offset = "0x3EE45F0", VA = "0x183EE5BF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly MLKAEDMKIKL IHGPGJFIAAC;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x499E8D0", Offset = "0x499D2D0", VA = "0x18499E8D0")]
	public PCDBPKABDKN(CFIAJJIOCAF FMFLAEIAJAM, bool BGALPFEPBCM, KCMBLKBEIOD<TSpawnType> KEFFHAHOJNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x499E7D0", Offset = "0x499D1D0", VA = "0x18499E7D0", Slot = "4")]
	[AsyncStateMachine(typeof(PCDBPKABDKN<>.HEOJCLKEHFN))]
	public override Task<TSpawnType> DBFKLINPIFI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public readonly struct CFIAJJIOCAF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly bool NIJGJECGOLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly Vector3 CJCJBFOPPCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly Vector3 EDBNILFNKMN;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6BD95F0", Offset = "0x6BD7FF0", VA = "0x186BD95F0")]
	public CFIAJJIOCAF(Transform DMFFGMIDIPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6BD96E0", Offset = "0x6BD80E0", VA = "0x186BD96E0")]
	public CFIAJJIOCAF(Vector3 MLNCIIKLLEK, Vector3 EJEBFMEPKGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6BD95C0", Offset = "0x6BD7FC0", VA = "0x186BD95C0")]
	public static CFIAJJIOCAF HNCMOJOADMF()
	{
		return default(CFIAJJIOCAF);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6BD9660", Offset = "0x6BD8060", VA = "0x186BD9660")]
	private CFIAJJIOCAF(bool ICFHEFHDMAP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct CCIEEOCINOK<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public TNode IIIHHGEKIHK;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x53E1E50", Offset = "0x53E0850", VA = "0x1853E1E50")]
	public CCIEEOCINOK(TNode IIIHHGEKIHK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct GKKINJLKPIF<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public TNode LDJKGOIGECC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public JOOMPOMCLDB IMIMPEGMEAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly bool MIOPHAJCBAH;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3EDE1F0", Offset = "0x3EDCBF0", VA = "0x183EDE1F0")]
	public GKKINJLKPIF(TNode LDJKGOIGECC, JOOMPOMCLDB IMIMPEGMEAJ, bool BGALPFEPBCM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface ADKDJKHEANG<TNode>
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GACOJCEHCLA([In] CCIEEOCINOK<TNode> PBNLGNIDIDO);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DOACPBHHENC([In] GKKINJLKPIF<TNode> EBEHHJNJNHG);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KAGIAJCMOHE();
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class MFDCEEBCMHC<TNode> : OOCKFDIBJDA<ADKDJKHEANG<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3A24380", Offset = "0x3A22D80", VA = "0x183A24380")]
	public MFDCEEBCMHC(ADKDJKHEANG<TNode> KEFFHAHOJNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x40A0F60", Offset = "0x409F960", VA = "0x1840A0F60", Slot = "4")]
	public override bool DBFKLINPIFI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class EHOLOOMPPLB<TNode> : OOCKFDIBJDA<ADKDJKHEANG<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly GKKINJLKPIF<TNode> EBEHHJNJNHG;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3A18820", Offset = "0x3A17220", VA = "0x183A18820")]
	public EHOLOOMPPLB(TNode LDJKGOIGECC, JOOMPOMCLDB IMIMPEGMEAJ, ADKDJKHEANG<TNode> KEFFHAHOJNE, bool BGALPFEPBCM = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3A18760", Offset = "0x3A17160", VA = "0x183A18760", Slot = "4")]
	public override bool DBFKLINPIFI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class GMNHEEIFFMP<TNode> : OOCKFDIBJDA<ADKDJKHEANG<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly CCIEEOCINOK<TNode> PBNLGNIDIDO;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3EE19E0", Offset = "0x3EE03E0", VA = "0x183EE19E0")]
	public GMNHEEIFFMP(TNode CMLMAEIFNKI, ADKDJKHEANG<TNode> KEFFHAHOJNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3A17560", Offset = "0x3A15F60", VA = "0x183A17560", Slot = "4")]
	public override bool DBFKLINPIFI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct DLDBFFKCHDD<TSpawnInfo> where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public TSpawnInfo HNEHGJKELHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public Vector3 EJEBFMEPKGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Quaternion PCIAHIPKDFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public float FCFDEHNOPJK;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5AA3280", Offset = "0x5AA1C80", VA = "0x185AA3280")]
	public DLDBFFKCHDD(TSpawnInfo HNEHGJKELHF, Vector3 EJEBFMEPKGF, Quaternion PCIAHIPKDFG, float FCFDEHNOPJK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface AKLIJECINOO<TSpawnType, TSpawnInfo>
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> PDBOBIHAFDM([In] DLDBFFKCHDD<TSpawnInfo> JEOPJEDFHNM, CancellationToken LOIOCMLGMKH);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class JCDDENAIIDI<TSpawnType, TSpawnInfo> : BPPDBANNDMK<AKLIJECINOO<TSpawnType, TSpawnInfo>, TSpawnType> where TSpawnType : notnull where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly DLDBFFKCHDD<TSpawnInfo> BBLLNFBCDFH;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x4271F40", Offset = "0x4270940", VA = "0x184271F40")]
	public JCDDENAIIDI(TSpawnInfo BJBCHHKCCFM, Vector3 EJEBFMEPKGF, Quaternion PCIAHIPKDFG, float FCFDEHNOPJK, AKLIJECINOO<TSpawnType, TSpawnInfo> KEFFHAHOJNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x4271D50", Offset = "0x4270750", VA = "0x184271D50", Slot = "4")]
	public override Task<TSpawnType> DBFKLINPIFI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct DFFLLCECGHG<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly IEnumerable<TData> NELHOLNAKDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly bool MIOPHAJCBAH;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5A87930", Offset = "0x5A86330", VA = "0x185A87930")]
	public DFFLLCECGHG(IEnumerable<TData> PMLDAPGFKFO, bool BGALPFEPBCM = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface EMGFLHDHKMG<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<EEOPJIHIOBE> HIHPDFAFMAK([In] DFFLLCECGHG<TData> MFELBCCCKME, CancellationToken LOIOCMLGMKH);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public class BFLGLACANCL<TData> : BPPDBANNDMK<EMGFLHDHKMG<TData>, EEOPJIHIOBE> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly DFFLLCECGHG<TData> LMELGFNMDNK;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x50AD490", Offset = "0x50ABE90", VA = "0x1850AD490")]
	public BFLGLACANCL(IEnumerable<TData> PMLDAPGFKFO, bool BGALPFEPBCM, EMGFLHDHKMG<TData> KEFFHAHOJNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x4271D50", Offset = "0x4270750", VA = "0x184271D50", Slot = "4")]
	public override Task<EEOPJIHIOBE> DBFKLINPIFI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct FLAOJFKCCPJ<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public readonly T CDHECNAFHCH;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x3E013C0", Offset = "0x3DFFDC0", VA = "0x183E013C0")]
	public FLAOJFKCCPJ(T KBGPAEPILJE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface JAMPIJJOLBD<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GACOJCEHCLA([In] FLAOJFKCCPJ<T> PPABOGBHBMO);

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DOACPBHHENC();
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface BPMHAFBFDNH<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DBFKLINPIFI([In] EAMNEPJHOMG<T> GALCDNNAHAJ);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct EAMNEPJHOMG<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public readonly T CDHECNAFHCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public readonly bool PEGABAIBGBD;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x39FB940", Offset = "0x39FA340", VA = "0x1839FB940")]
	public EAMNEPJHOMG(T KBGPAEPILJE, bool GHPIOLPPJDL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class LMOMNNBMHJE<T> : OOCKFDIBJDA<JAMPIJJOLBD<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x3A24380", Offset = "0x3A22D80", VA = "0x183A24380")]
	public LMOMNNBMHJE(JAMPIJJOLBD<T> KEFFHAHOJNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x44A5E40", Offset = "0x44A4840", VA = "0x1844A5E40", Slot = "4")]
	public override bool DBFKLINPIFI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class FLDLAKIOGPH<T> : OOCKFDIBJDA<JAMPIJJOLBD<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly FLAOJFKCCPJ<T> PPABOGBHBMO;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x3E01460", Offset = "0x3DFFE60", VA = "0x183E01460")]
	public FLDLAKIOGPH(T CDHECNAFHCH, JAMPIJJOLBD<T> KEFFHAHOJNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x3A17560", Offset = "0x3A15F60", VA = "0x183A17560", Slot = "4")]
	public override bool DBFKLINPIFI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class AGLJMFNILNE<T> : OOCKFDIBJDA<BPMHAFBFDNH<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly EAMNEPJHOMG<T> GALCDNNAHAJ;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x3E96E20", Offset = "0x3E95820", VA = "0x183E96E20")]
	public AGLJMFNILNE(T CDHECNAFHCH, bool GHPIOLPPJDL, BPMHAFBFDNH<T> KEFFHAHOJNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x3A17560", Offset = "0x3A15F60", VA = "0x183A17560", Slot = "4")]
	public override bool DBFKLINPIFI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct ANFLOKIGNNE<TData> where TData : notnull, GOPGHOEBCAK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public IEnumerable<TData> NELHOLNAKDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public bool PGOOODLCLGG;

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x3EAA110", Offset = "0x3EA8B10", VA = "0x183EAA110")]
	public ANFLOKIGNNE(IEnumerable<TData> GFIHPEJJADF, bool AALPCABDHJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public struct COEPBBBFPNO<TData> where TData : notnull, GOPGHOEBCAK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public List<TData> NELHOLNAKDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public List<bool> JJECILJMGAA;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x57A95D0", Offset = "0x57A7FD0", VA = "0x1857A95D0")]
	public COEPBBBFPNO(List<TData> GFIHPEJJADF, List<bool> OCAODNPHKJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface GOPGHOEBCAK
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool JBJONACBHMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface FODOKLDOEBL<TData> where TData : GOPGHOEBCAK
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DBFKLINPIFI([In] ANFLOKIGNNE<TData> HHIIIGDOKGE);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DBFKLINPIFI([In] COEPBBBFPNO<TData> HHIIIGDOKGE);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface FAHDDONHKIH<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NFNCENJOLPM(T CDHECNAFHCH);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class HPKJLIIOFLH<TData> : OOCKFDIBJDA<FODOKLDOEBL<TData>> where TData : notnull, GOPGHOEBCAK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly ANFLOKIGNNE<TData> HHIIIGDOKGE;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x3FE5280", Offset = "0x3FE3C80", VA = "0x183FE5280")]
	public HPKJLIIOFLH(List<TData> PMLDAPGFKFO, bool PGOOODLCLGG, FODOKLDOEBL<TData> KEFFHAHOJNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x3A17560", Offset = "0x3A15F60", VA = "0x183A17560", Slot = "4")]
	public override bool DBFKLINPIFI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class ODKNFOCFDFE<TData> : OOCKFDIBJDA<FODOKLDOEBL<TData>> where TData : notnull, GOPGHOEBCAK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly COEPBBBFPNO<TData> HHIIIGDOKGE;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x48D9810", Offset = "0x48D8210", VA = "0x1848D9810")]
	public ODKNFOCFDFE(List<TData> PMLDAPGFKFO, List<bool> JJECILJMGAA, FODOKLDOEBL<TData> KEFFHAHOJNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x48D9750", Offset = "0x48D8150", VA = "0x1848D9750", Slot = "4")]
	public override bool DBFKLINPIFI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface AKAJHKDOKLC<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<EEOPJIHIOBE> DBFKLINPIFI(ODIFJHCKJAF<TData> HMPLICACHGF);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class CDDHHNDCFKE<TData> : BPPDBANNDMK<AKAJHKDOKLC<TData>, EEOPJIHIOBE> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct LCHJOCLECJI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public AsyncTaskMethodBuilder<EEOPJIHIOBE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public CDDHHNDCFKE<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter<EEOPJIHIOBE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x4478580", Offset = "0x4476F80", VA = "0x184478580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x4478860", Offset = "0x4477260", VA = "0x184478860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly ODIFJHCKJAF<TData> JBMNMDMOKOH;

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x53E2AC0", Offset = "0x53E14C0", VA = "0x1853E2AC0")]
	public CDDHHNDCFKE(TData CFMBNDJOAGG, IReadOnlyList<TData> EPKNMGOKAIC, bool BGALPFEPBCM, AKAJHKDOKLC<TData> KEFFHAHOJNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x53E29C0", Offset = "0x53E13C0", VA = "0x1853E29C0", Slot = "4")]
	[AsyncStateMachine(typeof(CDDHHNDCFKE<>.LCHJOCLECJI))]
	public override Task<EEOPJIHIOBE> DBFKLINPIFI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public struct ODIFJHCKJAF<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public TData MJLMCPDLFFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public IReadOnlyList<TData> DMAJAMPDCMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public bool MIOPHAJCBAH;

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x48D93F0", Offset = "0x48D7DF0", VA = "0x1848D93F0")]
	public ODIFJHCKJAF(TData CFMBNDJOAGG, IReadOnlyList<TData> EPKNMGOKAIC, bool BGALPFEPBCM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface JAEJDLEAJDG<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DBFKLINPIFI([In] KJJPJDEKLCM<TData> DHFHJFANNEI);
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface CKIEDFNJLPJ<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DBFKLINPIFI([In] LDINDFFNOHJ<TData> DHFHJFANNEI);
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface INNMCPLBAIH<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HGDAMLJHMNE([In] CIKDBNHELON<TData> DHFHJFANNEI);

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DOACPBHHENC();
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class LGFOOCAFHBG<TData> : OOCKFDIBJDA<JAEJDLEAJDG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly KJJPJDEKLCM<TData> DHFHJFANNEI;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x448AED0", Offset = "0x44898D0", VA = "0x18448AED0")]
	public LGFOOCAFHBG(IEnumerable<TData> PMLDAPGFKFO, ILGMMPAEBOD BJCIGJMGMBG, FHMDBDPAHKN PPFNGNPGEKG, float CNOOJLNLLBL, bool BGALPFEPBCM, JAEJDLEAJDG<TData> KEFFHAHOJNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3A17560", Offset = "0x3A15F60", VA = "0x183A17560", Slot = "4")]
	public override bool DBFKLINPIFI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class GNGFCDILGIG<TData> : OOCKFDIBJDA<CKIEDFNJLPJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly LDINDFFNOHJ<TData> DHFHJFANNEI;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3EE2EC0", Offset = "0x3EE18C0", VA = "0x183EE2EC0")]
	public GNGFCDILGIG(TData[] PMLDAPGFKFO, ILGMMPAEBOD[] BJCIGJMGMBG, FHMDBDPAHKN[] PPFNGNPGEKG, float[] CNOOJLNLLBL, CKIEDFNJLPJ<TData> KEFFHAHOJNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x3EE2D20", Offset = "0x3EE1720", VA = "0x183EE2D20", Slot = "4")]
	public override bool DBFKLINPIFI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class EJFFDFJIJNC<TData> : OOCKFDIBJDA<INNMCPLBAIH<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3A24380", Offset = "0x3A22D80", VA = "0x183A24380")]
	public EJFFDFJIJNC(INNMCPLBAIH<TData> KEFFHAHOJNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3A24330", Offset = "0x3A22D30", VA = "0x183A24330", Slot = "4")]
	public override bool DBFKLINPIFI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class GOEHHNHENGG<TData> : OOCKFDIBJDA<INNMCPLBAIH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly CIKDBNHELON<TData> DHFHJFANNEI;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3EE3BB0", Offset = "0x3EE25B0", VA = "0x183EE3BB0")]
	public GOEHHNHENGG(IEnumerable<TData> PMLDAPGFKFO, ILGMMPAEBOD BJCIGJMGMBG, FHMDBDPAHKN PPFNGNPGEKG, float CNOOJLNLLBL, INNMCPLBAIH<TData> KEFFHAHOJNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3EE2D20", Offset = "0x3EE1720", VA = "0x183EE2D20", Slot = "4")]
	public override bool DBFKLINPIFI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct KJJPJDEKLCM<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public IEnumerable<TData> NELHOLNAKDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public ILGMMPAEBOD CBBLFCJPJBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public FHMDBDPAHKN LEJGECJHNOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public float CNOOJLNLLBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public bool BGALPFEPBCM;

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x43DB3C0", Offset = "0x43D9DC0", VA = "0x1843DB3C0")]
	public KJJPJDEKLCM(IEnumerable<TData> PMLDAPGFKFO, ILGMMPAEBOD BJCIGJMGMBG, FHMDBDPAHKN PPFNGNPGEKG, float CNOOJLNLLBL, bool BGALPFEPBCM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public struct LDINDFFNOHJ<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public TData[] NELHOLNAKDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public ILGMMPAEBOD[] CBBLFCJPJBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public FHMDBDPAHKN[] LEJGECJHNOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public float[] CNOOJLNLLBL;

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x447AAB0", Offset = "0x44794B0", VA = "0x18447AAB0")]
	public LDINDFFNOHJ(TData[] PMLDAPGFKFO, ILGMMPAEBOD[] BJCIGJMGMBG, FHMDBDPAHKN[] PPFNGNPGEKG, float[] CNOOJLNLLBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public struct CIKDBNHELON<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public IEnumerable<TData> NELHOLNAKDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public ILGMMPAEBOD CBBLFCJPJBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public FHMDBDPAHKN LEJGECJHNOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public float CNOOJLNLLBL;

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x54DBF50", Offset = "0x54DA950", VA = "0x1854DBF50")]
	public CIKDBNHELON(IEnumerable<TData> PMLDAPGFKFO, ILGMMPAEBOD BJCIGJMGMBG, FHMDBDPAHKN PPFNGNPGEKG, float CNOOJLNLLBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface BDMDBJBPFHJ<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HLJKPFAAAPN([In] NADOJLHLCDF<TData> MFELBCCCKME);

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LMEDHKODKGA([In] NADOJLHLCDF<TData> MFELBCCCKME);

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OOPDBBHDBOM([In] bool GCDOBJOOBEM);

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool ANAFHAHEGOC([In] NADOJLHLCDF<TData> MFELBCCCKME);

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NLFPEEPHKJI();

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool PHNALPBJDDP([In] TData POLIHFPNAEJ);
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class MBAFNCOGPPK<TData> : OOCKFDIBJDA<BDMDBJBPFHJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly NADOJLHLCDF<TData> MFELBCCCKME;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x4671FD0", Offset = "0x46709D0", VA = "0x184671FD0")]
	public MBAFNCOGPPK(List<TData> CCIELLHDDHE, BDMDBJBPFHJ<TData> KEFFHAHOJNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x3A17560", Offset = "0x3A15F60", VA = "0x183A17560", Slot = "4")]
	public override bool DBFKLINPIFI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class MDCHPHHENAF<TData> : OOCKFDIBJDA<BDMDBJBPFHJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3A24380", Offset = "0x3A22D80", VA = "0x183A24380")]
	public MDCHPHHENAF(BDMDBJBPFHJ<TData> KEFFHAHOJNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x46913A0", Offset = "0x468FDA0", VA = "0x1846913A0", Slot = "4")]
	public override bool DBFKLINPIFI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class JAOMNJOLHEM<TData> : OOCKFDIBJDA<BDMDBJBPFHJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly bool BGALPFEPBCM;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x426D4C0", Offset = "0x426BEC0", VA = "0x18426D4C0")]
	public JAOMNJOLHEM(bool BGALPFEPBCM, BDMDBJBPFHJ<TData> KEFFHAHOJNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x426D460", Offset = "0x426BE60", VA = "0x18426D460", Slot = "4")]
	public override bool DBFKLINPIFI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class PIAHGDADMJM<TData> : OOCKFDIBJDA<BDMDBJBPFHJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly NADOJLHLCDF<TData> MFELBCCCKME;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x49AD3E0", Offset = "0x49ABDE0", VA = "0x1849AD3E0")]
	public PIAHGDADMJM(List<TData> CCIELLHDDHE, bool BGALPFEPBCM, BDMDBJBPFHJ<TData> KEFFHAHOJNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x48D9750", Offset = "0x48D8150", VA = "0x1848D9750", Slot = "4")]
	public override bool DBFKLINPIFI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class PMHECEONMON<TData> : OOCKFDIBJDA<BDMDBJBPFHJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly TData POLIHFPNAEJ;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x49BFBA0", Offset = "0x49BE5A0", VA = "0x1849BFBA0")]
	public PMHECEONMON(TData POLIHFPNAEJ, BDMDBJBPFHJ<TData> KEFFHAHOJNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x49BFAE0", Offset = "0x49BE4E0", VA = "0x1849BFAE0", Slot = "4")]
	public override bool DBFKLINPIFI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class BEGEGHNFGOK<TData> : OOCKFDIBJDA<BDMDBJBPFHJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly NADOJLHLCDF<TData> MFELBCCCKME;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x50AB290", Offset = "0x50A9C90", VA = "0x1850AB290")]
	public BEGEGHNFGOK(IEnumerable<TData> CCIELLHDDHE, BDMDBJBPFHJ<TData> KEFFHAHOJNE, bool BGALPFEPBCM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x50AB1D0", Offset = "0x50A9BD0", VA = "0x1850AB1D0", Slot = "4")]
	public override bool DBFKLINPIFI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public struct NADOJLHLCDF<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public IEnumerable<TData> NELHOLNAKDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public bool BGALPFEPBCM;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x4781B50", Offset = "0x4780550", VA = "0x184781B50")]
	public NADOJLHLCDF(IEnumerable<TData> GFIHPEJJADF, bool MJBIDCEANDA = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface LIOAHGPKLMI
{
	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<EEOPJIHIOBE> DBFKLINPIFI(IIGAEIKLHME FOHBDFBENFG);
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public class NCOCNMPLOHK : BPPDBANNDMK<LIOAHGPKLMI, EEOPJIHIOBE>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private struct JFIDLLBHLMM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public AsyncTaskMethodBuilder<EEOPJIHIOBE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public NCOCNMPLOHK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private TaskAwaiter<EEOPJIHIOBE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6BDA1A0", Offset = "0x6BD8BA0", VA = "0x186BDA1A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6BDA420", Offset = "0x6BD8E20", VA = "0x186BDA420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly IIGAEIKLHME AEIKHKEKALO;

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6BDA6B0", Offset = "0x6BD90B0", VA = "0x186BDA6B0")]
	public NCOCNMPLOHK(bool BGALPFEPBCM, LIOAHGPKLMI KEFFHAHOJNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6BDA5C0", Offset = "0x6BD8FC0", VA = "0x186BDA5C0", Slot = "4")]
	[AsyncStateMachine(typeof(JFIDLLBHLMM))]
	public override Task<EEOPJIHIOBE> DBFKLINPIFI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public struct IIGAEIKLHME
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public bool MIOPHAJCBAH;

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x2300B30", Offset = "0x22FF530", VA = "0x182300B30")]
	public IIGAEIKLHME(bool BGALPFEPBCM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public readonly struct NIHJBNPFBDE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly bool KJPGPJOIMCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly bool EMIFOLHECGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public readonly bool FCFDEHNOPJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public readonly bool BGALPFEPBCM;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x4F27510", Offset = "0x4F25F10", VA = "0x184F27510")]
	public NIHJBNPFBDE(bool KJPGPJOIMCK, bool EMIFOLHECGL, bool FCFDEHNOPJK, bool BGALPFEPBCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6BDA710", Offset = "0x6BD9110", VA = "0x186BDA710")]
	public NIHJBNPFBDE(bool EMIFOLHECGL, bool BGALPFEPBCM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public interface KBMNFGKIFMF
{
	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CPBKBIPGAFK(NIHJBNPFBDE OLLPKBJGANO);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GLGGJHEFJMG(NIHJBNPFBDE OLLPKBJGANO);
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class AECCJFMALHA : OOCKFDIBJDA<KBMNFGKIFMF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly NIHJBNPFBDE OLLPKBJGANO;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6BD93E0", Offset = "0x6BD7DE0", VA = "0x186BD93E0")]
	public AECCJFMALHA(bool ICGEMCDDICC, bool EMIFOLHECGL, bool FCFDEHNOPJK, bool BGALPFEPBCM, KBMNFGKIFMF KEFFHAHOJNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6BD9390", Offset = "0x6BD7D90", VA = "0x186BD9390", Slot = "4")]
	public override bool DBFKLINPIFI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class BNBGKKLJBJA : OOCKFDIBJDA<KBMNFGKIFMF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly NIHJBNPFBDE OLLPKBJGANO;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6BD94E0", Offset = "0x6BD7EE0", VA = "0x186BD94E0")]
	public BNBGKKLJBJA(bool EMIFOLHECGL, bool BGALPFEPBCM, KBMNFGKIFMF KEFFHAHOJNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6BD9490", Offset = "0x6BD7E90", VA = "0x186BD9490", Slot = "4")]
	public override bool DBFKLINPIFI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public interface JPGEGLIJHAJ
{
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DBFKLINPIFI([In] HJAFNLGKJNM FPPOENJCOGL);
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class CPBHOBDCPLG : OOCKFDIBJDA<JPGEGLIJHAJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly HJAFNLGKJNM FPPOENJCOGL;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6BD97C0", Offset = "0x6BD81C0", VA = "0x186BD97C0")]
	public CPBHOBDCPLG(Guid[] CJMPNADKJLF, Vector3[] AFJIEILGPHO, Quaternion[] CFGGGKKFNIC, float[] MHIHKAMCGFP, Dictionary<Guid, Vector3> CFKMIMBCPJF, JPGEGLIJHAJ KEFFHAHOJNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6BD9710", Offset = "0x6BD8110", VA = "0x186BD9710", Slot = "4")]
	public override bool DBFKLINPIFI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public interface OGHNHLLAGND<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GACOJCEHCLA([In] DFJBOBOLNJO<TData> PBNLGNIDIDO);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HGDAMLJHMNE([In] BPFEFBGAAEA EDGCHGOCLGF);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HGDAMLJHMNE([In] NLGOKDHNLON EDGCHGOCLGF);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DOACPBHHENC();
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class OFKHGFODEPI<TData> : OOCKFDIBJDA<OGHNHLLAGND<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3A24380", Offset = "0x3A22D80", VA = "0x183A24380")]
	public OFKHGFODEPI(OGHNHLLAGND<TData> KEFFHAHOJNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x48FA420", Offset = "0x48F8E20", VA = "0x1848FA420", Slot = "4")]
	public override bool DBFKLINPIFI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class LMKLDLCPHOB<TData> : OOCKFDIBJDA<OGHNHLLAGND<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly BPFEFBGAAEA CKMKDONKHPE;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x44A4100", Offset = "0x44A2B00", VA = "0x1844A4100")]
	public LMKLDLCPHOB(Vector3 NGNLHFGFNDJ, bool FNFGHGNKPMJ, OGHNHLLAGND<TData> KEFFHAHOJNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x3FE38D0", Offset = "0x3FE22D0", VA = "0x183FE38D0", Slot = "4")]
	public override bool DBFKLINPIFI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class HOFDLOAEJFM<TData> : OOCKFDIBJDA<OGHNHLLAGND<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly NLGOKDHNLON CKMKDONKHPE;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x3FD3940", Offset = "0x3FD2340", VA = "0x183FD3940")]
	public HOFDLOAEJFM(Guid MBFFEBEBKBE, int ENMILGHAHOM, Vector3 EJEBFMEPKGF, Quaternion PCIAHIPKDFG, float KGJKNMNONHN, bool FNFGHGNKPMJ, OGHNHLLAGND<TData> KEFFHAHOJNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x3FD38E0", Offset = "0x3FD22E0", VA = "0x183FD38E0", Slot = "4")]
	public override bool DBFKLINPIFI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class FIPMAKBHDOE<TData> : OOCKFDIBJDA<OGHNHLLAGND<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly DFJBOBOLNJO<TData> CKMKDONKHPE;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x3DFE4C0", Offset = "0x3DFCEC0", VA = "0x183DFE4C0")]
	public FIPMAKBHDOE(TData CDHECNAFHCH, bool BGALPFEPBCM, OGHNHLLAGND<TData> KEFFHAHOJNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x3A17560", Offset = "0x3A15F60", VA = "0x183A17560", Slot = "4")]
	public override bool DBFKLINPIFI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public struct BPFEFBGAAEA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly Vector3 NGNLHFGFNDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public readonly bool FNFGHGNKPMJ;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6BD9560", Offset = "0x6BD7F60", VA = "0x186BD9560")]
	public BPFEFBGAAEA(Vector3 NGNLHFGFNDJ, bool FNFGHGNKPMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public struct NLGOKDHNLON
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public readonly Guid MBFFEBEBKBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public readonly int ENMILGHAHOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public readonly Vector3 EJEBFMEPKGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public readonly Quaternion PCIAHIPKDFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public readonly float KGJKNMNONHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public readonly bool FNFGHGNKPMJ;

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6BDA720", Offset = "0x6BD9120", VA = "0x186BDA720")]
	public NLGOKDHNLON(Guid MBFFEBEBKBE, int ENMILGHAHOM, Vector3 EJEBFMEPKGF, Quaternion PCIAHIPKDFG, float KGJKNMNONHN, bool FNFGHGNKPMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public struct DFJBOBOLNJO<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public readonly TData CDHECNAFHCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public readonly bool BGALPFEPBCM;

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x5A885F0", Offset = "0x5A86FF0", VA = "0x185A885F0")]
	public DFJBOBOLNJO(TData CDHECNAFHCH, bool BGALPFEPBCM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public interface EMFBCEJPGOE<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DBFKLINPIFI([In] KKBDKGJLINO<TData> PDHIPPILMIF);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DBFKLINPIFI([In] EJAMECOMIHC<TData> PDHIPPILMIF);
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public interface IMLJJBLPFDC<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GACOJCEHCLA([In] CIFGBKMBJMP<TData> FLPMDHCCDGA);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HGDAMLJHMNE([In] OFJABJPIGMI EDGCHGOCLGF);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DOACPBHHENC();
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class ICIHOFPJJAP<TData> : OOCKFDIBJDA<EMFBCEJPGOE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly KKBDKGJLINO<TData> PDHIPPILMIF;

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x4078C20", Offset = "0x4077620", VA = "0x184078C20")]
	public ICIHOFPJJAP(IEnumerable<TData> PMLDAPGFKFO, Vector3 FMDLNNNEHFL, bool BGALPFEPBCM, EMFBCEJPGOE<TData> KEFFHAHOJNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x3A17560", Offset = "0x3A15F60", VA = "0x183A17560", Slot = "4")]
	public override bool DBFKLINPIFI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class PDKMAHDAJLI<TData> : OOCKFDIBJDA<IMLJJBLPFDC<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x3A24380", Offset = "0x3A22D80", VA = "0x183A24380")]
	public PDKMAHDAJLI(IMLJJBLPFDC<TData> KEFFHAHOJNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x40A0F60", Offset = "0x409F960", VA = "0x1840A0F60", Slot = "4")]
	public override bool DBFKLINPIFI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class NOLADAGPNNN<TData> : OOCKFDIBJDA<IMLJJBLPFDC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly CIFGBKMBJMP<TData> PDHIPPILMIF;

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x47FC250", Offset = "0x47FAC50", VA = "0x1847FC250")]
	public NOLADAGPNNN(IEnumerable<TData> PMLDAPGFKFO, bool BGALPFEPBCM, IMLJJBLPFDC<TData> KEFFHAHOJNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3A17560", Offset = "0x3A15F60", VA = "0x183A17560", Slot = "4")]
	public override bool DBFKLINPIFI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class HOLGNCLBKCI<TData> : OOCKFDIBJDA<EMFBCEJPGOE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly EJAMECOMIHC<TData> PDHIPPILMIF;

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x3FD7E30", Offset = "0x3FD6830", VA = "0x183FD7E30")]
	public HOLGNCLBKCI(IEnumerable<TData> PMLDAPGFKFO, Vector3 JFLJEBFHHCB, HLGPEMAGDHO FCIJDOJKBIC, bool BGALPFEPBCM, EMFBCEJPGOE<TData> KEFFHAHOJNE, Space IHCAPOOPDME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x3A18760", Offset = "0x3A17160", VA = "0x183A18760", Slot = "4")]
	public override bool DBFKLINPIFI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public class MDIMNBMKMMH<TData> : OOCKFDIBJDA<IMLJJBLPFDC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly OFJABJPIGMI PDHIPPILMIF;

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x4691D80", Offset = "0x4690780", VA = "0x184691D80")]
	public MDIMNBMKMMH(Vector3 FMDLNNNEHFL, IMLJJBLPFDC<TData> KEFFHAHOJNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x3FE38D0", Offset = "0x3FE22D0", VA = "0x183FE38D0", Slot = "4")]
	public override bool DBFKLINPIFI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct KKBDKGJLINO<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public readonly IEnumerable<TData> PMLDAPGFKFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public readonly Vector3 FMDLNNNEHFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public readonly bool BGALPFEPBCM;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x43DD7D0", Offset = "0x43DC1D0", VA = "0x1843DD7D0")]
	public KKBDKGJLINO(IEnumerable<TData> PMLDAPGFKFO, Vector3 FMDLNNNEHFL, bool BGALPFEPBCM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct CIFGBKMBJMP<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public readonly IEnumerable<TData> PMLDAPGFKFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public readonly bool BGALPFEPBCM;

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x54D4A80", Offset = "0x54D3480", VA = "0x1854D4A80")]
	public CIFGBKMBJMP(IEnumerable<TData> PMLDAPGFKFO, bool BGALPFEPBCM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct EJAMECOMIHC<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public readonly IEnumerable<TData> PMLDAPGFKFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public readonly Vector3 JFLJEBFHHCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly HLGPEMAGDHO FCIJDOJKBIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public readonly bool BGALPFEPBCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly Space IHCAPOOPDME;

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x3A22130", Offset = "0x3A20B30", VA = "0x183A22130")]
	public EJAMECOMIHC(IEnumerable<TData> PMLDAPGFKFO, Vector3 JFLJEBFHHCB, HLGPEMAGDHO FCIJDOJKBIC, bool BGALPFEPBCM, Space IHCAPOOPDME)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public struct OFJABJPIGMI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public readonly Vector3 FMDLNNNEHFL;

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x2300840", Offset = "0x22FF240", VA = "0x182300840")]
	public OFJABJPIGMI(Vector3 FMDLNNNEHFL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public enum HLGPEMAGDHO
{
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	XYZ,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	X_only,
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	Y_only,
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	Z_only
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public interface CLECAOBNAIH
{
	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DBFKLINPIFI([In] CEPLPGDJFKL PKEHODKENJB);
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class LBIKJHIFLKH : OOCKFDIBJDA<CLECAOBNAIH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly CEPLPGDJFKL PKEHODKENJB;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6BDA540", Offset = "0x6BD8F40", VA = "0x186BDA540")]
	public LBIKJHIFLKH(bool BGALPFEPBCM, CLECAOBNAIH KEFFHAHOJNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6BDA490", Offset = "0x6BD8E90", VA = "0x186BDA490", Slot = "4")]
	public override bool DBFKLINPIFI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public readonly struct CEPLPGDJFKL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public readonly bool BGALPFEPBCM;

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x2300B30", Offset = "0x22FF530", VA = "0x182300B30")]
	public CEPLPGDJFKL(bool BGALPFEPBCM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public interface BFCIJDEEPFF<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DBFKLINPIFI([In] OLOBEHDOMLJ<TData> FHHFHMFGHOK);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DBFKLINPIFI([In] IEHFLOBMMKJ<TData> FHHFHMFGHOK);
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public interface LFHNHGMGHDH<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GACOJCEHCLA([In] CJMGIFOBABG<TData> PBNLGNIDIDO);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HGDAMLJHMNE([In] INELPNNDJCK EDGCHGOCLGF);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DOACPBHHENC();
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class HEJDEPDAPCO<TData> : OOCKFDIBJDA<BFCIJDEEPFF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly OLOBEHDOMLJ<TData> FHHFHMFGHOK;

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x3F4D920", Offset = "0x3F4C320", VA = "0x183F4D920")]
	public HEJDEPDAPCO(IEnumerable<TData> PMLDAPGFKFO, Quaternion FMDLNNNEHFL, Vector3? NIJMFLAEAIC, bool CAKBJIDFGJC, bool BGALPFEPBCM, BFCIJDEEPFF<TData> KEFFHAHOJNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x3A17560", Offset = "0x3A15F60", VA = "0x183A17560", Slot = "4")]
	public override bool DBFKLINPIFI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class IKHLENOEJCF<TData> : OOCKFDIBJDA<LFHNHGMGHDH<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x3A24380", Offset = "0x3A22D80", VA = "0x183A24380")]
	public IKHLENOEJCF(LFHNHGMGHDH<TData> KEFFHAHOJNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x40A0F60", Offset = "0x409F960", VA = "0x1840A0F60", Slot = "4")]
	public override bool DBFKLINPIFI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class BBPGNIDJCEP<TData> : OOCKFDIBJDA<LFHNHGMGHDH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly CJMGIFOBABG<TData> FHHFHMFGHOK;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x5094710", Offset = "0x5093110", VA = "0x185094710")]
	public BBPGNIDJCEP(IEnumerable<TData> PMLDAPGFKFO, bool BGALPFEPBCM, LFHNHGMGHDH<TData> KEFFHAHOJNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x3A17560", Offset = "0x3A15F60", VA = "0x183A17560", Slot = "4")]
	public override bool DBFKLINPIFI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class OAPMEBPFHID<TData> : OOCKFDIBJDA<BFCIJDEEPFF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly IEHFLOBMMKJ<TData> FHHFHMFGHOK;

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x48D4710", Offset = "0x48D3110", VA = "0x1848D4710")]
	public OAPMEBPFHID(IEnumerable<TData> PMLDAPGFKFO, Quaternion PFOJHBKPLOB, HLGPEMAGDHO JDFAMNGKMBE, Vector3? NIJMFLAEAIC, bool CAKBJIDFGJC, bool BGALPFEPBCM, Space IHCAPOOPDME, BFCIJDEEPFF<TData> KEFFHAHOJNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x3A18760", Offset = "0x3A17160", VA = "0x183A18760", Slot = "4")]
	public override bool DBFKLINPIFI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public class NOCMFAKBBIM<TData> : OOCKFDIBJDA<LFHNHGMGHDH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly INELPNNDJCK FHHFHMFGHOK;

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x47FBB20", Offset = "0x47FA520", VA = "0x1847FBB20")]
	public NOCMFAKBBIM(Quaternion FMDLNNNEHFL, Vector3? NIJMFLAEAIC, bool CAKBJIDFGJC, LFHNHGMGHDH<TData> KEFFHAHOJNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x3FE38D0", Offset = "0x3FE22D0", VA = "0x183FE38D0", Slot = "4")]
	public override bool DBFKLINPIFI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public struct OLOBEHDOMLJ<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public readonly IEnumerable<TData> PMLDAPGFKFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public readonly Quaternion FMDLNNNEHFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public readonly Vector3? NIJMFLAEAIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public readonly bool CAKBJIDFGJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public readonly bool BGALPFEPBCM;

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x4909830", Offset = "0x4908230", VA = "0x184909830")]
	public OLOBEHDOMLJ(IEnumerable<TData> PMLDAPGFKFO, Quaternion FMDLNNNEHFL, Vector3? NIJMFLAEAIC, bool CAKBJIDFGJC, bool BGALPFEPBCM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public struct CJMGIFOBABG<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public readonly IEnumerable<TData> PMLDAPGFKFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly bool BGALPFEPBCM;

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x54DE980", Offset = "0x54DD380", VA = "0x1854DE980")]
	public CJMGIFOBABG(IEnumerable<TData> PMLDAPGFKFO, bool BGALPFEPBCM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public struct IEHFLOBMMKJ<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public readonly IEnumerable<TData> PMLDAPGFKFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public readonly Quaternion PFOJHBKPLOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public readonly HLGPEMAGDHO JDFAMNGKMBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public readonly Vector3? NIJMFLAEAIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public readonly bool CAKBJIDFGJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public readonly bool BGALPFEPBCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public readonly Space IHCAPOOPDME;

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x4086B30", Offset = "0x4085530", VA = "0x184086B30")]
	public IEHFLOBMMKJ(IEnumerable<TData> PMLDAPGFKFO, Quaternion PFOJHBKPLOB, HLGPEMAGDHO JDFAMNGKMBE, Vector3? NIJMFLAEAIC, bool CAKBJIDFGJC, bool BGALPFEPBCM, Space IHCAPOOPDME)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public struct INELPNNDJCK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public readonly Quaternion FMDLNNNEHFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public readonly Vector3? NIJMFLAEAIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public readonly bool CAKBJIDFGJC;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x4EDB020", Offset = "0x4ED9A20", VA = "0x184EDB020")]
	public INELPNNDJCK(Quaternion FMDLNNNEHFL, Vector3? NIJMFLAEAIC, bool CAKBJIDFGJC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public interface PCNMIHALKNP<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GACOJCEHCLA([In] IHJDDKOIBNN<TData> PBNLGNIDIDO);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HGDAMLJHMNE([In] CHGNNLLJFCK EDGCHGOCLGF);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HGDAMLJHMNE([In] AMLFAFCJPBP EDGCHGOCLGF);

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HGDAMLJHMNE([In] CEEJGMOONBG EDGCHGOCLGF);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool DOACPBHHENC();
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public class NMBAFKFPDOB<TData> : OOCKFDIBJDA<PCNMIHALKNP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly CEEJGMOONBG AAPCJKFJAPP;

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x47F6600", Offset = "0x47F5000", VA = "0x1847F6600")]
	public NMBAFKFPDOB(Vector3 GLIOPNCCAFE, float IBDBBIJPGDC, Vector3 NIJMFLAEAIC, bool FDFBNINOAON, bool CGGFAEPJHNI, PCNMIHALKNP<TData> KEFFHAHOJNE, Space IHCAPOOPDME = Space.Self)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x47F65A0", Offset = "0x47F4FA0", VA = "0x1847F65A0", Slot = "4")]
	public override bool DBFKLINPIFI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class MIEMEMOCCCD<TData> : OOCKFDIBJDA<PCNMIHALKNP<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x3A24380", Offset = "0x3A22D80", VA = "0x183A24380")]
	public MIEMEMOCCCD(PCNMIHALKNP<TData> KEFFHAHOJNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x4699E40", Offset = "0x4698840", VA = "0x184699E40", Slot = "4")]
	public override bool DBFKLINPIFI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class EGCHMECAGHD<TData> : OOCKFDIBJDA<PCNMIHALKNP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly IHJDDKOIBNN<TData> AAPCJKFJAPP;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x3A176C0", Offset = "0x3A160C0", VA = "0x183A176C0")]
	public EGCHMECAGHD(IEnumerable<TData> PMLDAPGFKFO, bool BGALPFEPBCM, PCNMIHALKNP<TData> KEFFHAHOJNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x3A17560", Offset = "0x3A15F60", VA = "0x183A17560", Slot = "4")]
	public override bool DBFKLINPIFI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class GJAPCGGOIMN<TData> : OOCKFDIBJDA<PCNMIHALKNP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly AMLFAFCJPBP AAPCJKFJAPP;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x3EDB4E0", Offset = "0x3ED9EE0", VA = "0x183EDB4E0")]
	public GJAPCGGOIMN(float FEPBEBKBMHH, bool FHOJDIHOBCH, Vector3 NIJMFLAEAIC, PCNMIHALKNP<TData> KEFFHAHOJNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x3EDB420", Offset = "0x3ED9E20", VA = "0x183EDB420", Slot = "4")]
	public override bool DBFKLINPIFI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public class HPEFFANHLIO<TData> : OOCKFDIBJDA<PCNMIHALKNP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly CHGNNLLJFCK AAPCJKFJAPP;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x3FE3930", Offset = "0x3FE2330", VA = "0x183FE3930")]
	public HPEFFANHLIO(float IBDBBIJPGDC, Vector3 NIJMFLAEAIC, PCNMIHALKNP<TData> KEFFHAHOJNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x3FE38D0", Offset = "0x3FE22D0", VA = "0x183FE38D0", Slot = "4")]
	public override bool DBFKLINPIFI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public struct CEEJGMOONBG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public readonly Vector3 GLIOPNCCAFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public readonly float IBDBBIJPGDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public readonly Vector3 NIJMFLAEAIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public readonly bool FNFGHGNKPMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public readonly Space IHCAPOOPDME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public readonly bool CGGFAEPJHNI;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x6BD9580", Offset = "0x6BD7F80", VA = "0x186BD9580")]
	public CEEJGMOONBG(Vector3 GLIOPNCCAFE, float IBDBBIJPGDC, Vector3 NIJMFLAEAIC, bool FNFGHGNKPMJ, bool IIGIKMDGGJM, Space IHCAPOOPDME = Space.Self)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct IHJDDKOIBNN<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public readonly IEnumerable<TData> PMLDAPGFKFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public readonly bool BGALPFEPBCM;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x4099830", Offset = "0x4098230", VA = "0x184099830")]
	public IHJDDKOIBNN(IEnumerable<TData> PMLDAPGFKFO, bool BGALPFEPBCM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public struct AMLFAFCJPBP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public readonly float FEPBEBKBMHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public readonly bool FHOJDIHOBCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public readonly Vector3 NIJMFLAEAIC;

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6BD9470", Offset = "0x6BD7E70", VA = "0x186BD9470")]
	public AMLFAFCJPBP(float FEPBEBKBMHH, bool FHOJDIHOBCH, Vector3 NIJMFLAEAIC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct CHGNNLLJFCK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public readonly float IBDBBIJPGDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public readonly Vector3 NIJMFLAEAIC;

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x4E9E950", Offset = "0x4E9D350", VA = "0x184E9E950")]
	public CHGNNLLJFCK(float IBDBBIJPGDC, Vector3 NIJMFLAEAIC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public struct HJAFNLGKJNM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public readonly Guid[] PMLDAPGFKFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public readonly bool IJKJMCINDGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public readonly bool APELEJIKDKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public readonly bool PIOMHFOJKJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public readonly Vector3[] AFJIEILGPHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public readonly Quaternion[] CFGGGKKFNIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly float[] MHIHKAMCGFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public readonly Dictionary<Guid, Vector3> CFKMIMBCPJF;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6BD9B70", Offset = "0x6BD8570", VA = "0x186BD9B70")]
	public HJAFNLGKJNM(Guid[] CJMPNADKJLF, Vector3[] AFJIEILGPHO, Quaternion[] CFGGGKKFNIC, float[] MHIHKAMCGFP, Dictionary<Guid, Vector3> CFKMIMBCPJF, bool IJKJMCINDGJ = true, bool APELEJIKDKE = true, bool PIOMHFOJKJD = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6BD99A0", Offset = "0x6BD83A0", VA = "0x186BD99A0")]
	private static void ENOACDHCCBC(Dictionary<Guid, Vector3> CFKMIMBCPJF, int FDIDOJONCDM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public static class JEAMJCFPNDB
{
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	private struct BHFMMCKJBOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public bool HLPJKLDGCHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public FNNNJBMCDDC FLLHNGMEMOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public FNNNJBMCDDC DPKKIDPEMCB;
	}

	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private static BHFMMCKJBOO HPHNDCMKGBD;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static CancellationToken MFLEEFFMMGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6BD9EF0", Offset = "0x6BD88F0", VA = "0x186BD9EF0")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	internal static FNNNJBMCDDC FLLHNGMEMOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x6BD9FC0", Offset = "0x6BD89C0", VA = "0x186BD9FC0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x6BD9F60", Offset = "0x6BD8960", VA = "0x186BD9F60")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6BD9E00", Offset = "0x6BD8800", VA = "0x186BD9E00")]
	[MDINNNLEANF.KOGFDGIBLGF]
	internal static void FACEOGGPDCB(FNNNJBMCDDC LNLPOFAKAPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6BDA060", Offset = "0x6BD8A60", VA = "0x186BDA060")]
	public static void NJEMNKBBDAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6BD9F10", Offset = "0x6BD8910", VA = "0x186BD9F10")]
	private static FNNNJBMCDDC IDFOBCHNBHF(FNNNJBMCDDC KJJLKBPLCPE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public static class BMIMKAKEDCA
{
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public enum ENLJIAACBPH
	{
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		ICreationContextObject,
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		Guid
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x2AF4E00", Offset = "0x2AF3800", VA = "0x182AF4E00")]
	public static void EDHCDKKPFJE<T>(T MHOPBKMJKKN, ENLJIAACBPH AOGCIMANLIJ) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x2AF4D90", Offset = "0x2AF3790", VA = "0x182AF4D90")]
	public static void EDHCDKKPFJE<T>(T MHOPBKMJKKN) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x2AF4F60", Offset = "0x2AF3960", VA = "0x182AF4F60")]
	public static void EOIEBFHEKGJ<T>(T MHOPBKMJKKN) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x2AF5010", Offset = "0x2AF3A10", VA = "0x182AF5010")]
	public static T GJMIFHLLDMF<T>(ENLJIAACBPH AOGCIMANLIJ) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x2AF50C0", Offset = "0x2AF3AC0", VA = "0x182AF50C0")]
	public static bool OIOKEJAEGIB<T>(ENLJIAACBPH AOGCIMANLIJ, T? PFOLKJHCFLM, [Out][MaybeNullWhen(false)][NotNullWhen(true)] T AKLDLOJHNJB) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x2AF4CE0", Offset = "0x2AF36E0", VA = "0x182AF4CE0")]
	public static bool BKLMLHBOBAD<T>(ENLJIAACBPH AOGCIMANLIJ) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x2AF4C80", Offset = "0x2AF3680", VA = "0x182AF4C80")]
	public static T GJMIFHLLDMF<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x2AF5210", Offset = "0x2AF3C10", VA = "0x182AF5210")]
	public static bool OIOKEJAEGIB<T>(T PFOLKJHCFLM, [Out] T AKLDLOJHNJB) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x2AF4C80", Offset = "0x2AF3680", VA = "0x182AF4C80")]
	public static bool BKLMLHBOBAD<T>() where T : class
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
internal static class AEAIBGCKCKH
{
	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6BD9160", Offset = "0x6BD7B60", VA = "0x186BD9160")]
	public static void CGCFEBCNLFP(IEnumerable JNFNMBKOHBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x3421F60", Offset = "0x3420960", VA = "0x183421F60")]
	public static void CGCFEBCNLFP<T>(T[] FEMJEOMOEIN) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x3422140", Offset = "0x3420B40", VA = "0x183422140")]
	public static void CGCFEBCNLFP<T>(T OEDIDFDHHOH) where T : notnull, Enum
	{
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
