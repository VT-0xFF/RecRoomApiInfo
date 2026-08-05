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
using RecRoom.DataLayer.Registration;
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
		[Cpp2IlInjected.Address(RVA = "0xA1A700", Offset = "0xA19700", VA = "0x180A1A700")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CBF280", Offset = "0x7CBE280", VA = "0x187CBF280")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA1B220", Offset = "0xA1A220", VA = "0x180A1B220")]
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
		[Cpp2IlInjected.Address(RVA = "0xA1B260", Offset = "0xA1A260", VA = "0x180A1B260")]
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
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7CBF6E0", Offset = "0x7CBE6E0", VA = "0x187CBF6E0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2643640", Offset = "0x2642640", VA = "0x182643640")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface CHKMEGILCEN<TData, TReturn>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TReturn GCHGAJHCGEK(TData BOMDCGFKGKF);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface ONCGAJFPAHG<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ClearHoverTarget(OGKHCHENOOG LAJHAJGCLKH);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool SetHoverTarget(TData FCPOJLOEIEO, Collider MGKEEEDMPNJ, OGKHCHENOOG LAJHAJGCLKH, [Optional] KIOOHKBHOLJ? NCKAKAACBOA);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool TryGetHoverTarget([Out] TData FCPOJLOEIEO);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetHoverCollider([Out] Collider MGKEEEDMPNJ);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface HFBMACPPINO<TData> : FMJJDCFBFAB, ICOOLBJKEOI<TData>, GBPFLFFEDLC<TData>, LPHEOLGBDML<TData>, NDKOBACMGEB, JFECJGODNPL<TData>, NFICCJGJEPB, GDDCKFCNPGI
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface JFECJGODNPL<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 CKOFKNABLLG, Vector3 IGEMMIGMOOK, float JPGIFEODCKP, [Out] T HKCFOCDCLOH, [Out] Vector3 BNGDLFFCJIK, [Out] Collider MGKEEEDMPNJ);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 CKOFKNABLLG, Vector3 IGEMMIGMOOK, float GDKJNCKDJCB, float JPGIFEODCKP, T[] NJPIJIGBKLP, [Out] Vector3 PFIMDDAPPJB, [Out] Collider DDBOPHLJJEO);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 CKOFKNABLLG, float GDKJNCKDJCB, Vector3 FJEIKKIDODG, T[] NJPIJIGBKLP);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetObjectFromColliderInCurrentScope(Collider LOEOJMJDAPL, [Out] T DBNMMMLPLBE);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface FMJJDCFBFAB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Bounds JNOMCNIPHPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Transform IEGNEFNDOLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Bounds DBFCMENDFIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Transform PDHEGGFGLMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Vector3 LAMAOGKAJPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool NIAHOLGMFBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void UpdateLocalSelectionBounds();

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void SetSelectionBoundsDirty(bool KKBLFCPLODC = true, int BNLNCIGAPHP = 0);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ShouldHideSelectionBoundsPreview(bool LEGKIHAKHLM, object EJJDDFFADPC);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface GDDCKFCNPGI
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	GCADBNOOJOM AKNJBOFNONH
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface IPOBEBLLOGN
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool HICJDBKFJIO
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool JOJPCBNGDJG
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool AHHHOFMMOKH
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Dictionary<Guid, Guid> TryGetPreviousCloneMapping();

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void TrySetPreviousCloneMapping(Dictionary<Guid, Guid> HMACLMHKGNH);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface LPHEOLGBDML<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool FCHILIJCNBM
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int CFJMHBBIKEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<TData> FIFOGJIGIOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData HOJKNIMMINF);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData HOJKNIMMINF);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface ICOOLBJKEOI<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T BOMDCGFKGKF, [Optional] KIOOHKBHOLJ? PNKDOABFNIB, bool NAKNPAJBJHB = true);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int JAALIADHHOC, IEnumerable<T> ENJOLJLINPM, bool NAKNPAJBJHB = true);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int JAALIADHHOC, IEnumerable<T> ENJOLJLINPM, KIOOHKBHOLJ PNKDOABFNIB, bool NAKNPAJBJHB = true);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface NFICCJGJEPB
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface NDKOBACMGEB
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool JJNOPANPIPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool HHBIGKDAEJH
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool NNIABIPMDHO
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool KJAOKCHPKJB
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct LPDBNNENJNL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public bool PAPMOIFIINA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public float? OFNLCKJCNJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public float? OKKFJHCLBFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public float? ODPOIEPEEGC;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct GPPFLEEAMIF<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public IEnumerable<TData> KEEJDCNLHGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public LPDBNNENJNL AJEMBDGPNIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public bool HMPJNGKNIOD;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4A99490", Offset = "0x4A98490", VA = "0x184A99490")]
	public GPPFLEEAMIF(IEnumerable<TData> LIAECCDAGKL, bool FHJECAEPFID, float? LMHOAGCNJFG, float? OOGHBEFHNIB, float? IEPELDNMGLC, bool HMPJNGKNIOD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface LJCLANENGGM<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CENANGHIOME([In] GPPFLEEAMIF<TData> ODJGLJIHJOP);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class FIKFAJCCJFO<TData> : PILNJOAKLEF<LJCLANENGGM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly GPPFLEEAMIF<TData> ODJGLJIHJOP;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x496E570", Offset = "0x496D570", VA = "0x18496E570")]
	public FIKFAJCCJFO(IEnumerable<TData> LIAECCDAGKL, bool FHJECAEPFID, float? LMHOAGCNJFG, float? OOGHBEFHNIB, float? IEPELDNMGLC, bool HMPJNGKNIOD, LJCLANENGGM<TData> NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x44F3690", Offset = "0x44F2690", VA = "0x1844F3690", Slot = "4")]
	public override bool CENANGHIOME()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct BJDKKGMLBNO<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public IEnumerable<TData> KEEJDCNLHGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public string PNHKFKCEKNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public bool KFDAJOPCGMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public bool HMPJNGKNIOD;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x63AB390", Offset = "0x63AA390", VA = "0x1863AB390")]
	public BJDKKGMLBNO(IEnumerable<TData> LIAECCDAGKL, string PCHIHCHIMHB, bool GHKGNHCHHJJ, bool HMPJNGKNIOD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface EAOFLEDHDMC<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CENANGHIOME([In] BJDKKGMLBNO<TData> ODJGLJIHJOP);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class GHHFKNFAHKA<TData> : PILNJOAKLEF<EAOFLEDHDMC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly BJDKKGMLBNO<TData> ODJGLJIHJOP;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4A80AF0", Offset = "0x4A7FAF0", VA = "0x184A80AF0")]
	public GHHFKNFAHKA(IEnumerable<TData> LIAECCDAGKL, string PCHIHCHIMHB, bool GHKGNHCHHJJ, bool HMPJNGKNIOD, EAOFLEDHDMC<TData> NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x44F3690", Offset = "0x44F2690", VA = "0x1844F3690", Slot = "4")]
	public override bool CENANGHIOME()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public abstract class PILNJOAKLEF<TReceiver> : KMIMKIPKFGA<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4924030", Offset = "0x4923030", VA = "0x184924030")]
	public PILNJOAKLEF(TReceiver NGKGGMDFKFD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public abstract class CGLNCCHPIIL<TReceiver, TFromTask> : KMIMKIPKFGA<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4924030", Offset = "0x4923030", VA = "0x184924030")]
	public CGLNCCHPIIL(TReceiver NGKGGMDFKFD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public abstract class KMIMKIPKFGA<TReceiver, TFromExecute> where TReceiver : notnull where TFromExecute : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	protected TReceiver NGKGGMDFKFD;

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4FEA210", Offset = "0x4FE9210", VA = "0x184FEA210")]
	public KMIMKIPKFGA(TReceiver NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute CENANGHIOME();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class FHJNPOJPAEG<TReceiver, TResult> : KMIMKIPKFGA<TReceiver, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4924030", Offset = "0x4923030", VA = "0x184924030")]
	public FHJNPOJPAEG(TReceiver NGKGGMDFKFD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct OBNEBMGPALJ<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public TGroup DHJNCOJICML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public TData PEALJKEGDEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public IEnumerable<TData> KEEJDCNLHGC;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2654370", Offset = "0x2653370", VA = "0x182654370")]
	public OBNEBMGPALJ(TGroup MMDFHIJHCKI, TData EPPPFGPKGJP, IEnumerable<TData> LIAECCDAGKL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct MDHBONJFKEM<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public TGroup DHJNCOJICML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public IEnumerable<TData> KEEJDCNLHGC;

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0xAAAD70", Offset = "0xAA9D70", VA = "0x180AAAD70")]
	public MDHBONJFKEM(TGroup MMDFHIJHCKI, IEnumerable<TData> LIAECCDAGKL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct CFOICHLBEGD<TGroup> where TGroup : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public TGroup DHJNCOJICML;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0xCFF9B0", Offset = "0xCFE9B0", VA = "0x180CFF9B0")]
	public CFOICHLBEGD(TGroup MMDFHIJHCKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct DAPHFIIDOLN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public IEnumerable<Guid> KEEJDCNLHGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public Guid FBIEBKCKMGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public readonly bool FJFIBDDLENC;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7CBE340", Offset = "0x7CBD340", VA = "0x187CBE340")]
	public DAPHFIIDOLN(IEnumerable<Guid> LIAECCDAGKL, Guid CHIEFBDHPKP, bool HMPJNGKNIOD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct OANCLHDCFJN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public Guid FBIEBKCKMGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly bool FJFIBDDLENC;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x25634C0", Offset = "0x25624C0", VA = "0x1825634C0")]
	public OANCLHDCFJN(Guid CHIEFBDHPKP, bool HMPJNGKNIOD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface NCCDDHCBBEO<TGroup, TData>
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GCPOJOMMCKD BAEDHMIBDHO(OBNEBMGPALJ<TGroup, TData> MMEGIMHACGE);

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GCPOJOMMCKD OJLGFBDCIOJ(OBNEBMGPALJ<TGroup, TData> MMEGIMHACGE);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GCPOJOMMCKD DGKEJJDPDCF(MDHBONJFKEM<TGroup, TData> MMEGIMHACGE);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GCPOJOMMCKD FPGHNEIGDGF(CFOICHLBEGD<TGroup> MMEGIMHACGE);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface NKMIJAMBKBA
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<GCPOJOMMCKD> BAEDHMIBDHO(DAPHFIIDOLN MMEGIMHACGE);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<GCPOJOMMCKD> OJLGFBDCIOJ(OANCLHDCFJN MMEGIMHACGE);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class NAGLMOJAKAG<TGroup, TData> : FHJNPOJPAEG<NCCDDHCBBEO<TGroup, TData>, GCPOJOMMCKD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly MDHBONJFKEM<TGroup, TData> MMEGIMHACGE;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x539E210", Offset = "0x539D210", VA = "0x18539E210")]
	public NAGLMOJAKAG(TGroup MMDFHIJHCKI, IEnumerable<TData> LIAECCDAGKL, NCCDDHCBBEO<TGroup, TData> NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x539E140", Offset = "0x539D140", VA = "0x18539E140", Slot = "4")]
	public override GCPOJOMMCKD CENANGHIOME()
	{
		return default(GCPOJOMMCKD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class GJCKOIHPGIO<TGroup, TData> : FHJNPOJPAEG<NCCDDHCBBEO<TGroup, TData>, GCPOJOMMCKD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly OBNEBMGPALJ<TGroup, TData> MMEGIMHACGE;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x4A85AE0", Offset = "0x4A84AE0", VA = "0x184A85AE0")]
	public GJCKOIHPGIO(TGroup MMDFHIJHCKI, TData ENJPIPBKKMC, IEnumerable<TData> LIAECCDAGKL, NCCDDHCBBEO<TGroup, TData> NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x4A85A10", Offset = "0x4A84A10", VA = "0x184A85A10", Slot = "4")]
	public override GCPOJOMMCKD CENANGHIOME()
	{
		return default(GCPOJOMMCKD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class POPIDCMGEJL<TGroup, TData> : FHJNPOJPAEG<NCCDDHCBBEO<TGroup, TData>, GCPOJOMMCKD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly CFOICHLBEGD<TGroup> MMEGIMHACGE;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x54FEC70", Offset = "0x54FDC70", VA = "0x1854FEC70")]
	public POPIDCMGEJL(TGroup MMDFHIJHCKI, NCCDDHCBBEO<TGroup, TData> NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x562E9E0", Offset = "0x562D9E0", VA = "0x18562E9E0", Slot = "4")]
	public override GCPOJOMMCKD CENANGHIOME()
	{
		return default(GCPOJOMMCKD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class ANENJKKFMKI<TGroup, TData> : FHJNPOJPAEG<NCCDDHCBBEO<TGroup, TData>, GCPOJOMMCKD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly OBNEBMGPALJ<TGroup, TData> MMEGIMHACGE;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4A85AE0", Offset = "0x4A84AE0", VA = "0x184A85AE0")]
	public ANENJKKFMKI(TGroup MMDFHIJHCKI, TData EPPPFGPKGJP, IEnumerable<TData> LIAECCDAGKL, NCCDDHCBBEO<TGroup, TData> NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x4F5FE00", Offset = "0x4F5EE00", VA = "0x184F5FE00", Slot = "4")]
	public override GCPOJOMMCKD CENANGHIOME()
	{
		return default(GCPOJOMMCKD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class DIDPLBAIGPI : CGLNCCHPIIL<NKMIJAMBKBA, GCPOJOMMCKD>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct GKCMDMLJFAA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public AsyncTaskMethodBuilder<GCPOJOMMCKD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public DIDPLBAIGPI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private TaskAwaiter<GCPOJOMMCKD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7CBE8F0", Offset = "0x7CBD8F0", VA = "0x187CBE8F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7CBEB80", Offset = "0x7CBDB80", VA = "0x187CBEB80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private DAPHFIIDOLN MMEGIMHACGE;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7CBE470", Offset = "0x7CBD470", VA = "0x187CBE470")]
	public DIDPLBAIGPI(IEnumerable<Guid> CMDNDNLJFOD, Guid CHIEFBDHPKP, bool HMPJNGKNIOD, NKMIJAMBKBA NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7CBE380", Offset = "0x7CBD380", VA = "0x187CBE380", Slot = "4")]
	[AsyncStateMachine(typeof(GKCMDMLJFAA))]
	public override Task<GCPOJOMMCKD> CENANGHIOME()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class ACGANKGEKMO : CGLNCCHPIIL<NKMIJAMBKBA, GCPOJOMMCKD>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private struct BCHLPOAHLGO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public AsyncTaskMethodBuilder<GCPOJOMMCKD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public ACGANKGEKMO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private TaskAwaiter<GCPOJOMMCKD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7CBD810", Offset = "0x7CBC810", VA = "0x187CBD810", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7CBDAB0", Offset = "0x7CBCAB0", VA = "0x187CBDAB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly OANCLHDCFJN MMEGIMHACGE;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7CBD790", Offset = "0x7CBC790", VA = "0x187CBD790")]
	public ACGANKGEKMO(Guid CHIEFBDHPKP, bool HMPJNGKNIOD, NKMIJAMBKBA NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7CBD6A0", Offset = "0x7CBC6A0", VA = "0x187CBD6A0", Slot = "4")]
	[AsyncStateMachine(typeof(BCHLPOAHLGO))]
	public override Task<GCPOJOMMCKD> CENANGHIOME()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public readonly struct NOHGDCJLGKP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly GGINLHMMKPC FDMHGCJBABN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly bool FJFIBDDLENC;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7CBF260", Offset = "0x7CBE260", VA = "0x187CBF260")]
	public NOHGDCJLGKP(GGINLHMMKPC IIICABHNDOI, bool HMPJNGKNIOD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface IDDMLBIKGEJ<TSpawnType> where TSpawnType : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> CENANGHIOME(NOHGDCJLGKP BNOGNLIBFME);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class JILNKMLIHJO<TSpawnType> : CGLNCCHPIIL<IDDMLBIKGEJ<TSpawnType>, TSpawnType> where TSpawnType : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct LGNGMCCAOIH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public AsyncTaskMethodBuilder<TSpawnType> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public JILNKMLIHJO<TSpawnType> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private TaskAwaiter<TSpawnType> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x510C060", Offset = "0x510B060", VA = "0x18510C060", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x44B5600", Offset = "0x44B4600", VA = "0x1844B5600", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly NOHGDCJLGKP BNOGNLIBFME;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x4E38340", Offset = "0x4E37340", VA = "0x184E38340")]
	public JILNKMLIHJO(GGINLHMMKPC IIICABHNDOI, bool HMPJNGKNIOD, IDDMLBIKGEJ<TSpawnType> NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x4E38040", Offset = "0x4E37040", VA = "0x184E38040", Slot = "4")]
	[AsyncStateMachine(typeof(JILNKMLIHJO<>.LGNGMCCAOIH))]
	public override Task<TSpawnType> CENANGHIOME()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct GGINLHMMKPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public readonly bool ENLGFMOOLCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly Vector3 ENMINAOPOCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly Vector3 MJJFMHOFJKF;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7CBE7C0", Offset = "0x7CBD7C0", VA = "0x187CBE7C0")]
	public GGINLHMMKPC(Transform EJFMFHGPPNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7CBE830", Offset = "0x7CBD830", VA = "0x187CBE830")]
	public GGINLHMMKPC(Vector3 HPAMHMBDLLL, Vector3 EPCLGOKLIPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7CBE790", Offset = "0x7CBD790", VA = "0x187CBE790")]
	public static GGINLHMMKPC OKKBPPIELHH()
	{
		return default(GGINLHMMKPC);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7CBE860", Offset = "0x7CBD860", VA = "0x187CBE860")]
	private GGINLHMMKPC(bool NBCAIKIOFKH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct AEPCNLEBODL<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public TNode JEIBOLJJPCE;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x4A5B4D0", Offset = "0x4A5A4D0", VA = "0x184A5B4D0")]
	public AEPCNLEBODL(TNode JEIBOLJJPCE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct JFPCJALBAOE<TNode, TReparentOperations> where TNode : notnull where TReparentOperations : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public TNode PBOCNBJFHBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public TReparentOperations GFECLHCHFBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public DKEDCAAHGAG CJAOOBBGMFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly bool FJFIBDDLENC;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x4E30D00", Offset = "0x4E2FD00", VA = "0x184E30D00")]
	public JFPCJALBAOE(TNode PBOCNBJFHBL, TReparentOperations GFECLHCHFBM, DKEDCAAHGAG CJAOOBBGMFL, bool HMPJNGKNIOD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface CBPABPGJHDJ<TNode, TReparentOperations>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MBCCADHBLDF([In] AEPCNLEBODL<TNode> BJNFPFBDIHI);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool ALNJIMBKPBC([In] JFPCJALBAOE<TNode, TReparentOperations> KGBNLJFINCO);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool EPOBBECAECE();
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class PMCCFFNEOKJ<TNode, TReparentOperations> : PILNJOAKLEF<CBPABPGJHDJ<TNode, TReparentOperations>>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x4924030", Offset = "0x4923030", VA = "0x184924030")]
	public PMCCFFNEOKJ(CBPABPGJHDJ<TNode, TReparentOperations> NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x55FD5D0", Offset = "0x55FC5D0", VA = "0x1855FD5D0", Slot = "4")]
	public override bool CENANGHIOME()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class HHKAELIPAGH<TNode, TReparentOperations> : PILNJOAKLEF<CBPABPGJHDJ<TNode, TReparentOperations>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly JFPCJALBAOE<TNode, TReparentOperations> KGBNLJFINCO;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x4AEB250", Offset = "0x4AEA250", VA = "0x184AEB250")]
	public HHKAELIPAGH(TNode PBOCNBJFHBL, TReparentOperations GFECLHCHFBM, DKEDCAAHGAG CJAOOBBGMFL, CBPABPGJHDJ<TNode, TReparentOperations> NGKGGMDFKFD, bool HMPJNGKNIOD = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x4AEB190", Offset = "0x4AEA190", VA = "0x184AEB190", Slot = "4")]
	public override bool CENANGHIOME()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class JDKCNGMDCKA<TNode, TReparentOperations> : PILNJOAKLEF<CBPABPGJHDJ<TNode, TReparentOperations>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly AEPCNLEBODL<TNode> BJNFPFBDIHI;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x4E26E80", Offset = "0x4E25E80", VA = "0x184E26E80")]
	public JDKCNGMDCKA(TNode HFPMCMFACLL, CBPABPGJHDJ<TNode, TReparentOperations> NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x44F3690", Offset = "0x44F2690", VA = "0x1844F3690", Slot = "4")]
	public override bool CENANGHIOME()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct MHFHHPBCNJE<TSpawnInfo> where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public TSpawnInfo OENEMMJNGNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public Vector3 EPCLGOKLIPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public Quaternion OOBEGCNALKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public float HDLKNIPAJGK;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5335440", Offset = "0x5334440", VA = "0x185335440")]
	public MHFHHPBCNJE(TSpawnInfo OENEMMJNGNL, Vector3 EPCLGOKLIPO, Quaternion OOBEGCNALKF, float HDLKNIPAJGK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface DAEHOMILFJE<TSpawnType, TSpawnInfo>
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> KOBNNHMJDFL([In] MHFHHPBCNJE<TSpawnInfo> KNADDLOMKNB, CancellationToken CBJPDIFOEKF);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class BNNGGKBBNJJ<TSpawnType, TSpawnInfo> : CGLNCCHPIIL<DAEHOMILFJE<TSpawnType, TSpawnInfo>, TSpawnType> where TSpawnType : notnull where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly MHFHHPBCNJE<TSpawnInfo> ODJGLJIHJOP;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x63B2680", Offset = "0x63B1680", VA = "0x1863B2680")]
	public BNNGGKBBNJJ(TSpawnInfo PCDOHBFFPJE, Vector3 EPCLGOKLIPO, Quaternion OOBEGCNALKF, float HDLKNIPAJGK, DAEHOMILFJE<TSpawnType, TSpawnInfo> NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4E3AE90", Offset = "0x4E39E90", VA = "0x184E3AE90", Slot = "4")]
	public override Task<TSpawnType> CENANGHIOME()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public readonly struct LPHAHAFNJNG<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly IEnumerable<TData> KEEJDCNLHGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly bool FJFIBDDLENC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly bool LHKCGEILKJG;

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x51365B0", Offset = "0x51355B0", VA = "0x1851365B0")]
	public LPHAHAFNJNG(IEnumerable<TData> LIAECCDAGKL, bool HMPJNGKNIOD = false, bool HMNOKCEFAFM = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface AJAGIEIKFNE<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<GCPOJOMMCKD> MNBNAKBHGIA([In] LPHAHAFNJNG<TData> GNKCHDPHDIH, CancellationToken CBJPDIFOEKF);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class JJGGLFAONHK<TData> : CGLNCCHPIIL<AJAGIEIKFNE<TData>, GCPOJOMMCKD> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly LPHAHAFNJNG<TData> DNMMHDOMEAD;

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x4E3B020", Offset = "0x4E3A020", VA = "0x184E3B020")]
	public JJGGLFAONHK(IEnumerable<TData> LIAECCDAGKL, bool HMPJNGKNIOD, AJAGIEIKFNE<TData> NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x4E3AE90", Offset = "0x4E39E90", VA = "0x184E3AE90", Slot = "4")]
	public override Task<GCPOJOMMCKD> CENANGHIOME()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct AIJHGJIIAEJ<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly T FCPOJLOEIEO;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x4A65B00", Offset = "0x4A64B00", VA = "0x184A65B00")]
	public AIJHGJIIAEJ(T JEMOCGHLMEI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface CHCKPCGOCME<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MBCCADHBLDF([In] AIJHGJIIAEJ<T> NLOHFOLBOBH);

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool ALNJIMBKPBC();
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface JAEELCMCKOD<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CENANGHIOME([In] FAPPGLMLKGP<T> LPBDNKGKBNJ);
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public struct FAPPGLMLKGP<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly T FCPOJLOEIEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly bool KLICMHIKLHB;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x494FA20", Offset = "0x494EA20", VA = "0x18494FA20")]
	public FAPPGLMLKGP(T JEMOCGHLMEI, bool GHDMMGHHCHI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public class FDGCKMBGNFO<T> : PILNJOAKLEF<CHCKPCGOCME<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x4924030", Offset = "0x4923030", VA = "0x184924030")]
	public FDGCKMBGNFO(CHCKPCGOCME<T> NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x495A820", Offset = "0x4959820", VA = "0x18495A820", Slot = "4")]
	public override bool CENANGHIOME()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class OBACJNJAENJ<T> : PILNJOAKLEF<CHCKPCGOCME<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly AIJHGJIIAEJ<T> NLOHFOLBOBH;

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x54FEBE0", Offset = "0x54FDBE0", VA = "0x1854FEBE0")]
	public OBACJNJAENJ(T FCPOJLOEIEO, CHCKPCGOCME<T> NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x44F3690", Offset = "0x44F2690", VA = "0x1844F3690", Slot = "4")]
	public override bool CENANGHIOME()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class LMEANKKPIPF<T> : PILNJOAKLEF<JAEELCMCKOD<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly FAPPGLMLKGP<T> LPBDNKGKBNJ;

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x51225D0", Offset = "0x51215D0", VA = "0x1851225D0")]
	public LMEANKKPIPF(T FCPOJLOEIEO, bool GHDMMGHHCHI, JAEELCMCKOD<T> NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x44F3690", Offset = "0x44F2690", VA = "0x1844F3690", Slot = "4")]
	public override bool CENANGHIOME()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public struct EDMGBMDHBCG<TData> where TData : notnull, DCMEBIFDIHO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public IEnumerable<TData> KEEJDCNLHGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public bool KEFOGHGKANA;

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x44BE700", Offset = "0x44BD700", VA = "0x1844BE700")]
	public EDMGBMDHBCG(IEnumerable<TData> CCMDDCOGLLP, bool NDBICKMCMJE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public struct FFBENHMJFNI<TData> where TData : notnull, DCMEBIFDIHO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public List<TData> KEEJDCNLHGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public List<bool> HMJECHNNGDO;

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x495D1C0", Offset = "0x495C1C0", VA = "0x18495D1C0")]
	public FFBENHMJFNI(List<TData> CCMDDCOGLLP, List<bool> PFGMNPBOJIE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface DCMEBIFDIHO
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool PCGEAJOBCHI
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface BNBOMLKEGKJ<TData> where TData : DCMEBIFDIHO
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CENANGHIOME([In] EDMGBMDHBCG<TData> IMNKKEJKNMK);

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CENANGHIOME([In] FFBENHMJFNI<TData> IMNKKEJKNMK);
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface DHOJOHEAPHL<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MOBAJOIKPHP(T FCPOJLOEIEO);
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class OEEDOOACCIP<TData> : PILNJOAKLEF<BNBOMLKEGKJ<TData>> where TData : notnull, DCMEBIFDIHO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly EDMGBMDHBCG<TData> IMNKKEJKNMK;

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x5511E30", Offset = "0x5510E30", VA = "0x185511E30")]
	public OEEDOOACCIP(List<TData> LIAECCDAGKL, bool KEFOGHGKANA, BNBOMLKEGKJ<TData> NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x44F3690", Offset = "0x44F2690", VA = "0x1844F3690", Slot = "4")]
	public override bool CENANGHIOME()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class FJFCCFNIMMP<TData> : PILNJOAKLEF<BNBOMLKEGKJ<TData>> where TData : notnull, DCMEBIFDIHO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly FFBENHMJFNI<TData> IMNKKEJKNMK;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x49729E0", Offset = "0x49719E0", VA = "0x1849729E0")]
	public FJFCCFNIMMP(List<TData> LIAECCDAGKL, List<bool> HMJECHNNGDO, BNBOMLKEGKJ<TData> NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x4972920", Offset = "0x4971920", VA = "0x184972920", Slot = "4")]
	public override bool CENANGHIOME()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public interface BBEABHPHGEF<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<GCPOJOMMCKD> CENANGHIOME(KDHDJNHMOCM<TData> NBKGFHKBLJN);
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public class IBCLGKNLHIP<TData> : CGLNCCHPIIL<BBEABHPHGEF<TData>, GCPOJOMMCKD> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private struct IOMBKBMDNDL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public AsyncTaskMethodBuilder<GCPOJOMMCKD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public IBCLGKNLHIP<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private TaskAwaiter<GCPOJOMMCKD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x4C122D0", Offset = "0x4C112D0", VA = "0x184C122D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x4C125B0", Offset = "0x4C115B0", VA = "0x184C125B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly KDHDJNHMOCM<TData> CCHEFNPALBJ;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4BE8740", Offset = "0x4BE7740", VA = "0x184BE8740")]
	public IBCLGKNLHIP(TData DNBOJLCFHGA, IReadOnlyList<TData> LFBKCPGGEHL, bool HMPJNGKNIOD, BBEABHPHGEF<TData> NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x4BE8640", Offset = "0x4BE7640", VA = "0x184BE8640", Slot = "4")]
	[AsyncStateMachine(typeof(IBCLGKNLHIP<>.IOMBKBMDNDL))]
	public override Task<GCPOJOMMCKD> CENANGHIOME()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public struct KDHDJNHMOCM<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public TData ALHJKILMKNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public IReadOnlyList<TData> IANEFJKIMAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public bool FJFIBDDLENC;

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2C8DAF0", Offset = "0x2C8CAF0", VA = "0x182C8DAF0")]
	public KDHDJNHMOCM(TData DNBOJLCFHGA, IReadOnlyList<TData> LFBKCPGGEHL, bool HMPJNGKNIOD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface GLPGPJDKODF<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CENANGHIOME([In] AGPIGGFHDMI<TData> GEADLODONON);
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public interface ECJNCDPFBII<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CENANGHIOME([In] JGGPELANEBH<TData> GEADLODONON);
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public interface CKAEKBLEAOP<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HPGEPBAEDAB([In] EKLPLGKLODB<TData> GEADLODONON);

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ALNJIMBKPBC();
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class DJKGGBAPGHG<TData> : PILNJOAKLEF<GLPGPJDKODF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly AGPIGGFHDMI<TData> GEADLODONON;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6A624D0", Offset = "0x6A614D0", VA = "0x186A624D0")]
	public DJKGGBAPGHG(IEnumerable<TData> LIAECCDAGKL, IHNAGNCLKBF NGGKCKILBNF, MNHJGJHOEHN CANJBFKPEMF, float KPNAELOMDEE, string? PCHIHCHIMHB, bool CFHBAJNBIDK, bool HMPJNGKNIOD, GLPGPJDKODF<TData> NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x44F3690", Offset = "0x44F2690", VA = "0x1844F3690", Slot = "4")]
	public override bool CENANGHIOME()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class DHMPCFHOMNM<TData> : PILNJOAKLEF<ECJNCDPFBII<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly JGGPELANEBH<TData> GEADLODONON;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6A5DA40", Offset = "0x6A5CA40", VA = "0x186A5DA40")]
	public DHMPCFHOMNM(TData[] LIAECCDAGKL, IHNAGNCLKBF[] NGGKCKILBNF, MNHJGJHOEHN[] CANJBFKPEMF, float[] KPNAELOMDEE, ECJNCDPFBII<TData> NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x4E23E80", Offset = "0x4E22E80", VA = "0x184E23E80", Slot = "4")]
	public override bool CENANGHIOME()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class BPLOCJKOMLP<TData> : PILNJOAKLEF<CKAEKBLEAOP<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x4924030", Offset = "0x4923030", VA = "0x184924030")]
	public BPLOCJKOMLP(CKAEKBLEAOP<TData> NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x649ECB0", Offset = "0x649DCB0", VA = "0x18649ECB0", Slot = "4")]
	public override bool CENANGHIOME()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class JCHKNKNCBJF<TData> : PILNJOAKLEF<CKAEKBLEAOP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly EKLPLGKLODB<TData> GEADLODONON;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x4E23F40", Offset = "0x4E22F40", VA = "0x184E23F40")]
	public JCHKNKNCBJF(IEnumerable<TData> LIAECCDAGKL, IHNAGNCLKBF NGGKCKILBNF, MNHJGJHOEHN CANJBFKPEMF, float KPNAELOMDEE, CKAEKBLEAOP<TData> NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x4E23E80", Offset = "0x4E22E80", VA = "0x184E23E80", Slot = "4")]
	public override bool CENANGHIOME()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public struct AGPIGGFHDMI<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public IEnumerable<TData> KEEJDCNLHGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public IHNAGNCLKBF FIGDBNMNPBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public MNHJGJHOEHN FNLBLGEDCDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public float GLOADLJCNMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public string? PNHKFKCEKNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public bool? FKGHMGCBAEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public bool FJFIBDDLENC;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x4A61250", Offset = "0x4A60250", VA = "0x184A61250")]
	public AGPIGGFHDMI(IEnumerable<TData> LIAECCDAGKL, IHNAGNCLKBF NGGKCKILBNF, MNHJGJHOEHN CANJBFKPEMF, float KPNAELOMDEE, string? PCHIHCHIMHB, bool? CFHBAJNBIDK, bool HMPJNGKNIOD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public struct JGGPELANEBH<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public TData[] KEEJDCNLHGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public IHNAGNCLKBF[] FIGDBNMNPBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public MNHJGJHOEHN[] FNLBLGEDCDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public float[] KPNAELOMDEE;

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x4E31EE0", Offset = "0x4E30EE0", VA = "0x184E31EE0")]
	public JGGPELANEBH(TData[] LIAECCDAGKL, IHNAGNCLKBF[] NGGKCKILBNF, MNHJGJHOEHN[] CANJBFKPEMF, float[] KPNAELOMDEE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public struct EKLPLGKLODB<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public IEnumerable<TData> KEEJDCNLHGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public IHNAGNCLKBF FIGDBNMNPBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public MNHJGJHOEHN FNLBLGEDCDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public float KPNAELOMDEE;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x44E5D80", Offset = "0x44E4D80", VA = "0x1844E5D80")]
	public EKLPLGKLODB(IEnumerable<TData> LIAECCDAGKL, IHNAGNCLKBF NGGKCKILBNF, MNHJGJHOEHN CANJBFKPEMF, float KPNAELOMDEE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public interface GBPFLFFEDLC<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DGKEJJDPDCF([In] FKNCBDNMFIF<TData> GNKCHDPHDIH);

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FPGHNEIGDGF([In] FKNCBDNMFIF<TData> GNKCHDPHDIH);

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IBAJJNEMEOM([In] bool EMELOIKHEDN);

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool AGOICKMOCLD([In] FKNCBDNMFIF<TData> GNKCHDPHDIH);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PCLJGJHMCGI();

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool KBOKGGLLHIG([In] TData KFPIOIGLGHH);
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class CHJOLFJABBN<TData> : PILNJOAKLEF<GBPFLFFEDLC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly FKNCBDNMFIF<TData> GNKCHDPHDIH;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x67D2140", Offset = "0x67D1140", VA = "0x1867D2140")]
	public CHJOLFJABBN(List<TData> OLCBBPLHPLC, GBPFLFFEDLC<TData> NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x44F3690", Offset = "0x44F2690", VA = "0x1844F3690", Slot = "4")]
	public override bool CENANGHIOME()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class GNKBIDLNGJN<TData> : PILNJOAKLEF<GBPFLFFEDLC<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4924030", Offset = "0x4923030", VA = "0x184924030")]
	public GNKBIDLNGJN(GBPFLFFEDLC<TData> NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x4A94B40", Offset = "0x4A93B40", VA = "0x184A94B40", Slot = "4")]
	public override bool CENANGHIOME()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class EMHDILFNDOI<TData> : PILNJOAKLEF<GBPFLFFEDLC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly bool HMPJNGKNIOD;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x44EF960", Offset = "0x44EE960", VA = "0x1844EF960")]
	public EMHDILFNDOI(bool HMPJNGKNIOD, GBPFLFFEDLC<TData> NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x44EF900", Offset = "0x44EE900", VA = "0x1844EF900", Slot = "4")]
	public override bool CENANGHIOME()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class ANBAIPADODP<TData> : PILNJOAKLEF<GBPFLFFEDLC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly FKNCBDNMFIF<TData> GNKCHDPHDIH;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x4F5F0F0", Offset = "0x4F5E0F0", VA = "0x184F5F0F0")]
	public ANBAIPADODP(List<TData> OLCBBPLHPLC, bool HMPJNGKNIOD, GBPFLFFEDLC<TData> NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x4972920", Offset = "0x4971920", VA = "0x184972920", Slot = "4")]
	public override bool CENANGHIOME()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class LMEBIGMDCAL<TData> : PILNJOAKLEF<GBPFLFFEDLC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly TData KFPIOIGLGHH;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x5122800", Offset = "0x5121800", VA = "0x185122800")]
	public LMEBIGMDCAL(TData KFPIOIGLGHH, GBPFLFFEDLC<TData> NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x5122680", Offset = "0x5121680", VA = "0x185122680", Slot = "4")]
	public override bool CENANGHIOME()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class AFGMIACLJIA<TData> : PILNJOAKLEF<GBPFLFFEDLC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly FKNCBDNMFIF<TData> GNKCHDPHDIH;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x4A5D780", Offset = "0x4A5C780", VA = "0x184A5D780")]
	public AFGMIACLJIA(IEnumerable<TData> OLCBBPLHPLC, GBPFLFFEDLC<TData> NGKGGMDFKFD, bool HMPJNGKNIOD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x4A5D610", Offset = "0x4A5C610", VA = "0x184A5D610", Slot = "4")]
	public override bool CENANGHIOME()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public struct FKNCBDNMFIF<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public IEnumerable<TData> KEEJDCNLHGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public bool HMPJNGKNIOD;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x4976550", Offset = "0x4975550", VA = "0x184976550")]
	public FKNCBDNMFIF(IEnumerable<TData> CCMDDCOGLLP, bool FLJMNMGPELE = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public interface AEGKCKHMKAJ
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<GCPOJOMMCKD> CENANGHIOME(PGOAKHGPGAD DAFDADLGOAL);
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class FJHHOMFNKCP : CGLNCCHPIIL<AEGKCKHMKAJ, GCPOJOMMCKD>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private struct JCHJAEMMCDA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public AsyncTaskMethodBuilder<GCPOJOMMCKD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public FJHHOMFNKCP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private TaskAwaiter<GCPOJOMMCKD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x7CBEC10", Offset = "0x7CBDC10", VA = "0x187CBEC10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7CBEE90", Offset = "0x7CBDE90", VA = "0x187CBEE90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly PGOAKHGPGAD MBHLPLIGGCG;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x7CBE730", Offset = "0x7CBD730", VA = "0x187CBE730")]
	public FJHHOMFNKCP(bool HMPJNGKNIOD, AEGKCKHMKAJ NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x7CBE640", Offset = "0x7CBD640", VA = "0x187CBE640", Slot = "4")]
	[AsyncStateMachine(typeof(JCHJAEMMCDA))]
	public override Task<GCPOJOMMCKD> CENANGHIOME()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public struct PGOAKHGPGAD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public bool FJFIBDDLENC;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x29A56F0", Offset = "0x29A46F0", VA = "0x1829A56F0")]
	public PGOAKHGPGAD(bool HMPJNGKNIOD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public readonly struct NDFHLGCPNBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public readonly bool DOBHHKPIDED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public readonly bool NNHCKDJNEMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public readonly bool HDLKNIPAJGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public readonly bool HMPJNGKNIOD;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5C7D0A0", Offset = "0x5C7C0A0", VA = "0x185C7D0A0")]
	public NDFHLGCPNBF(bool DOBHHKPIDED, bool NNHCKDJNEMK, bool HDLKNIPAJGK, bool HMPJNGKNIOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7CBF020", Offset = "0x7CBE020", VA = "0x187CBF020")]
	public NDFHLGCPNBF(bool NNHCKDJNEMK, bool HMPJNGKNIOD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public interface MHCDOLPNDPO
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LOFCKCJJHBE(NDFHLGCPNBF GHOOCLMFEMG);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NPGHEJCHFHK(NDFHLGCPNBF GHOOCLMFEMG);
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class MACBBAIFHCH : PILNJOAKLEF<MHCDOLPNDPO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly NDFHLGCPNBF GHOOCLMFEMG;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7CBEF90", Offset = "0x7CBDF90", VA = "0x187CBEF90")]
	public MACBBAIFHCH(bool KOOMPFGMBLG, bool NNHCKDJNEMK, bool HDLKNIPAJGK, bool HMPJNGKNIOD, MHCDOLPNDPO NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x7CBEF40", Offset = "0x7CBDF40", VA = "0x187CBEF40", Slot = "4")]
	public override bool CENANGHIOME()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public class FEMJICEGAJM : PILNJOAKLEF<MHCDOLPNDPO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private readonly NDFHLGCPNBF GHOOCLMFEMG;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7CBE580", Offset = "0x7CBD580", VA = "0x187CBE580")]
	public FEMJICEGAJM(bool NNHCKDJNEMK, bool HMPJNGKNIOD, MHCDOLPNDPO NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x7CBE530", Offset = "0x7CBD530", VA = "0x187CBE530", Slot = "4")]
	public override bool CENANGHIOME()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public interface DKIKBKNKNBH
{
	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CENANGHIOME([In] CNGGOIFGKLJ GHJEBIDJGPM);
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class BGCEACCBGMO : PILNJOAKLEF<DKIKBKNKNBH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private readonly CNGGOIFGKLJ GHJEBIDJGPM;

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x7CBDCE0", Offset = "0x7CBCCE0", VA = "0x187CBDCE0")]
	public BGCEACCBGMO(Guid[] DENJFPGMEIJ, Vector3[] BEEPPLKKJCL, Quaternion[] LNMCKDAHFFE, float[] PKINALFPPEB, Dictionary<Guid, Vector3> EHDIBACCOLF, DKIKBKNKNBH NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7CBDC30", Offset = "0x7CBCC30", VA = "0x187CBDC30", Slot = "4")]
	public override bool CENANGHIOME()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public interface IGMNEBIOCDD<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MBCCADHBLDF([In] FGGDLLLMBPK<TData> BJNFPFBDIHI);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HPGEPBAEDAB([In] GLCOLNFNMCC FHHIPNLCHFF);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HPGEPBAEDAB([In] FJANDNHKPLP FHHIPNLCHFF);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool ALNJIMBKPBC();
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class IEOCJOAALON<TData> : PILNJOAKLEF<IGMNEBIOCDD<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x4924030", Offset = "0x4923030", VA = "0x184924030")]
	public IEOCJOAALON(IGMNEBIOCDD<TData> NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x4BFC810", Offset = "0x4BFB810", VA = "0x184BFC810", Slot = "4")]
	public override bool CENANGHIOME()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class PGHLPPDIPCE<TData> : PILNJOAKLEF<IGMNEBIOCDD<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly GLCOLNFNMCC EKBNBABMKGB;

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x56092A0", Offset = "0x56082A0", VA = "0x1856092A0")]
	public PGHLPPDIPCE(Vector3 IEOICJNAMOG, bool PMAMFBECNPK, IGMNEBIOCDD<TData> NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x44E15D0", Offset = "0x44E05D0", VA = "0x1844E15D0", Slot = "4")]
	public override bool CENANGHIOME()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class PPGPEAHNBFM<TData> : PILNJOAKLEF<IGMNEBIOCDD<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly FJANDNHKPLP EKBNBABMKGB;

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x56304D0", Offset = "0x562F4D0", VA = "0x1856304D0")]
	public PPGPEAHNBFM(Guid HFBFDILABOM, int OHHMJGCBCKD, Vector3 EPCLGOKLIPO, Quaternion OOBEGCNALKF, float PIBKBDEFJIN, bool PMAMFBECNPK, IGMNEBIOCDD<TData> NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5630470", Offset = "0x562F470", VA = "0x185630470", Slot = "4")]
	public override bool CENANGHIOME()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public class ILDIFDKEBMF<TData> : PILNJOAKLEF<IGMNEBIOCDD<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly FGGDLLLMBPK<TData> EKBNBABMKGB;

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x4C09530", Offset = "0x4C08530", VA = "0x184C09530")]
	public ILDIFDKEBMF(TData FCPOJLOEIEO, bool HMPJNGKNIOD, IGMNEBIOCDD<TData> NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x44F3690", Offset = "0x44F2690", VA = "0x1844F3690", Slot = "4")]
	public override bool CENANGHIOME()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct GLCOLNFNMCC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public readonly Vector3 IEOICJNAMOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public readonly bool PMAMFBECNPK;

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7CBEBF0", Offset = "0x7CBDBF0", VA = "0x187CBEBF0")]
	public GLCOLNFNMCC(Vector3 IEOICJNAMOG, bool PMAMFBECNPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct FJANDNHKPLP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public readonly Guid HFBFDILABOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public readonly int OHHMJGCBCKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public readonly Vector3 EPCLGOKLIPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public readonly Quaternion OOBEGCNALKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public readonly float PIBKBDEFJIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public readonly bool PMAMFBECNPK;

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7CBE600", Offset = "0x7CBD600", VA = "0x187CBE600")]
	public FJANDNHKPLP(Guid HFBFDILABOM, int OHHMJGCBCKD, Vector3 EPCLGOKLIPO, Quaternion OOBEGCNALKF, float PIBKBDEFJIN, bool PMAMFBECNPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct FGGDLLLMBPK<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public readonly TData FCPOJLOEIEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public readonly bool HMPJNGKNIOD;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x4960F10", Offset = "0x495FF10", VA = "0x184960F10")]
	public FGGDLLLMBPK(TData FCPOJLOEIEO, bool HMPJNGKNIOD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public interface MLMNDDIJILE<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CENANGHIOME([In] JKPCJFBOKPF<TData> IBGHKOMFHHE);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CENANGHIOME([In] GAKNNBCEFDL<TData> IBGHKOMFHHE);
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public interface CGHMLNMODAD<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MBCCADHBLDF([In] MEMMLAGJJDM<TData> JFLMGBAKOOP);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HPGEPBAEDAB([In] BFEKBJGAIMP FHHIPNLCHFF);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool ALNJIMBKPBC();
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public class GIEHDFCEIAE<TData> : PILNJOAKLEF<MLMNDDIJILE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly JKPCJFBOKPF<TData> IBGHKOMFHHE;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x4A81D40", Offset = "0x4A80D40", VA = "0x184A81D40")]
	public GIEHDFCEIAE(IEnumerable<TData> LIAECCDAGKL, Vector3 LBOMKCOMMDP, bool HMPJNGKNIOD, MLMNDDIJILE<TData> NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x44F3690", Offset = "0x44F2690", VA = "0x1844F3690", Slot = "4")]
	public override bool CENANGHIOME()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class PDMLDCAJJIN<TData> : PILNJOAKLEF<CGHMLNMODAD<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x4924030", Offset = "0x4923030", VA = "0x184924030")]
	public PDMLDCAJJIN(CGHMLNMODAD<TData> NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x55FD5D0", Offset = "0x55FC5D0", VA = "0x1855FD5D0", Slot = "4")]
	public override bool CENANGHIOME()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public class EOAMFPJNHBE<TData> : PILNJOAKLEF<CGHMLNMODAD<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly MEMMLAGJJDM<TData> IBGHKOMFHHE;

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x44F3800", Offset = "0x44F2800", VA = "0x1844F3800")]
	public EOAMFPJNHBE(IEnumerable<TData> LIAECCDAGKL, bool HMPJNGKNIOD, CGHMLNMODAD<TData> NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x44F3690", Offset = "0x44F2690", VA = "0x1844F3690", Slot = "4")]
	public override bool CENANGHIOME()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public class OGDIAOPLBKK<TData> : PILNJOAKLEF<MLMNDDIJILE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly GAKNNBCEFDL<TData> IBGHKOMFHHE;

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x5517010", Offset = "0x5516010", VA = "0x185517010")]
	public OGDIAOPLBKK(IEnumerable<TData> LIAECCDAGKL, Vector3 HPPJIHIHKBL, ILOHMIAHPMC JIJPFCFAMIM, bool HMPJNGKNIOD, MLMNDDIJILE<TData> NGKGGMDFKFD, Space HJHCPMHFCLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x4AEB190", Offset = "0x4AEA190", VA = "0x184AEB190", Slot = "4")]
	public override bool CENANGHIOME()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class FJMFIECCAMH<TData> : PILNJOAKLEF<CGHMLNMODAD<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly BFEKBJGAIMP IBGHKOMFHHE;

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x4972B10", Offset = "0x4971B10", VA = "0x184972B10")]
	public FJMFIECCAMH(Vector3 LBOMKCOMMDP, CGHMLNMODAD<TData> NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x44E15D0", Offset = "0x44E05D0", VA = "0x1844E15D0", Slot = "4")]
	public override bool CENANGHIOME()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public struct JKPCJFBOKPF<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public readonly IEnumerable<TData> LIAECCDAGKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public readonly Vector3 LBOMKCOMMDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly bool HMPJNGKNIOD;

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x4E3F810", Offset = "0x4E3E810", VA = "0x184E3F810")]
	public JKPCJFBOKPF(IEnumerable<TData> LIAECCDAGKL, Vector3 LBOMKCOMMDP, bool HMPJNGKNIOD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct MEMMLAGJJDM<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public readonly IEnumerable<TData> LIAECCDAGKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public readonly bool HMPJNGKNIOD;

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x5321E60", Offset = "0x5320E60", VA = "0x185321E60")]
	public MEMMLAGJJDM(IEnumerable<TData> LIAECCDAGKL, bool HMPJNGKNIOD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public struct GAKNNBCEFDL<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public readonly IEnumerable<TData> LIAECCDAGKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public readonly Vector3 HPPJIHIHKBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public readonly ILOHMIAHPMC JIJPFCFAMIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public readonly bool HMPJNGKNIOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public readonly Space HJHCPMHFCLG;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x4A45BE0", Offset = "0x4A44BE0", VA = "0x184A45BE0")]
	public GAKNNBCEFDL(IEnumerable<TData> LIAECCDAGKL, Vector3 HPPJIHIHKBL, ILOHMIAHPMC JIJPFCFAMIM, bool HMPJNGKNIOD, Space HJHCPMHFCLG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public struct BFEKBJGAIMP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public readonly Vector3 LBOMKCOMMDP;

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0xEB5790", Offset = "0xEB4790", VA = "0x180EB5790")]
	public BFEKBJGAIMP(Vector3 LBOMKCOMMDP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public enum ILOHMIAHPMC
{
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	XYZ,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	X_only,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	Y_only,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	Z_only
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public interface LALNGCBCAKP
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CENANGHIOME([In] NECJIBOFAHN GIBDAOKCBBH);
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public class BFKIKANMCKE : PILNJOAKLEF<LALNGCBCAKP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly NECJIBOFAHN GIBDAOKCBBH;

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x7CBDBD0", Offset = "0x7CBCBD0", VA = "0x187CBDBD0")]
	public BFKIKANMCKE(bool HMPJNGKNIOD, LALNGCBCAKP NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x7CBDB20", Offset = "0x7CBCB20", VA = "0x187CBDB20", Slot = "4")]
	public override bool CENANGHIOME()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public readonly struct NECJIBOFAHN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public readonly bool HMPJNGKNIOD;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x29A56F0", Offset = "0x29A46F0", VA = "0x1829A56F0")]
	public NECJIBOFAHN(bool HMPJNGKNIOD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public interface KNPCODHALMD<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CENANGHIOME([In] KJGNKELLOKA<TData> IDDGPKEJCED);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CENANGHIOME([In] DKOEJIECNAF<TData> IDDGPKEJCED);
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public interface DIBAGKLNMAM<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MBCCADHBLDF([In] LJIPJNHLCKI<TData> BJNFPFBDIHI);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HPGEPBAEDAB([In] GPOHOJJLJCE FHHIPNLCHFF);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool ALNJIMBKPBC();
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public class IIJIFLAIGNO<TData> : PILNJOAKLEF<KNPCODHALMD<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly KJGNKELLOKA<TData> IDDGPKEJCED;

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x4C06350", Offset = "0x4C05350", VA = "0x184C06350")]
	public IIJIFLAIGNO(IEnumerable<TData> LIAECCDAGKL, Quaternion LBOMKCOMMDP, Vector3? IHNNKMFJLFA, bool NHBPPONNBAM, bool HMPJNGKNIOD, KNPCODHALMD<TData> NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x44F3690", Offset = "0x44F2690", VA = "0x1844F3690", Slot = "4")]
	public override bool CENANGHIOME()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class DBKGAPGMMPD<TData> : PILNJOAKLEF<DIBAGKLNMAM<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x4924030", Offset = "0x4923030", VA = "0x184924030")]
	public DBKGAPGMMPD(DIBAGKLNMAM<TData> NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x55FD5D0", Offset = "0x55FC5D0", VA = "0x1855FD5D0", Slot = "4")]
	public override bool CENANGHIOME()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class JJLCGGAAPAI<TData> : PILNJOAKLEF<DIBAGKLNMAM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly LJIPJNHLCKI<TData> IDDGPKEJCED;

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x4E3B180", Offset = "0x4E3A180", VA = "0x184E3B180")]
	public JJLCGGAAPAI(IEnumerable<TData> LIAECCDAGKL, bool HMPJNGKNIOD, DIBAGKLNMAM<TData> NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x44F3690", Offset = "0x44F2690", VA = "0x1844F3690", Slot = "4")]
	public override bool CENANGHIOME()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class JHICLKFNBCL<TData> : PILNJOAKLEF<KNPCODHALMD<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly DKOEJIECNAF<TData> IDDGPKEJCED;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x4E372A0", Offset = "0x4E362A0", VA = "0x184E372A0")]
	public JHICLKFNBCL(IEnumerable<TData> LIAECCDAGKL, Quaternion EDAJKKBNMIB, ILOHMIAHPMC LJFIEFKMJFF, Vector3? IHNNKMFJLFA, bool NHBPPONNBAM, bool HMPJNGKNIOD, Space HJHCPMHFCLG, KNPCODHALMD<TData> NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x4AEB190", Offset = "0x4AEA190", VA = "0x184AEB190", Slot = "4")]
	public override bool CENANGHIOME()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public class LJJHJJABFEL<TData> : PILNJOAKLEF<DIBAGKLNMAM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private readonly GPOHOJJLJCE IDDGPKEJCED;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x5120E70", Offset = "0x511FE70", VA = "0x185120E70")]
	public LJJHJJABFEL(Quaternion LBOMKCOMMDP, Vector3? IHNNKMFJLFA, bool NHBPPONNBAM, DIBAGKLNMAM<TData> NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x44E15D0", Offset = "0x44E05D0", VA = "0x1844E15D0", Slot = "4")]
	public override bool CENANGHIOME()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public struct KJGNKELLOKA<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public readonly IEnumerable<TData> LIAECCDAGKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public readonly Quaternion LBOMKCOMMDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public readonly Vector3? IHNNKMFJLFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public readonly bool NHBPPONNBAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public readonly bool HMPJNGKNIOD;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x4FDEF60", Offset = "0x4FDDF60", VA = "0x184FDEF60")]
	public KJGNKELLOKA(IEnumerable<TData> LIAECCDAGKL, Quaternion LBOMKCOMMDP, Vector3? IHNNKMFJLFA, bool NHBPPONNBAM, bool HMPJNGKNIOD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct LJIPJNHLCKI<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public readonly IEnumerable<TData> LIAECCDAGKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public readonly bool HMPJNGKNIOD;

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x5120820", Offset = "0x511F820", VA = "0x185120820")]
	public LJIPJNHLCKI(IEnumerable<TData> LIAECCDAGKL, bool HMPJNGKNIOD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public struct DKOEJIECNAF<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public readonly IEnumerable<TData> LIAECCDAGKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public readonly Quaternion EDAJKKBNMIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public readonly ILOHMIAHPMC LJFIEFKMJFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public readonly Vector3? IHNNKMFJLFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public readonly bool NHBPPONNBAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public readonly bool HMPJNGKNIOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public readonly Space HJHCPMHFCLG;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x6A64F60", Offset = "0x6A63F60", VA = "0x186A64F60")]
	public DKOEJIECNAF(IEnumerable<TData> LIAECCDAGKL, Quaternion EDAJKKBNMIB, ILOHMIAHPMC LJFIEFKMJFF, Vector3? IHNNKMFJLFA, bool NHBPPONNBAM, bool HMPJNGKNIOD, Space HJHCPMHFCLG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct GPOHOJJLJCE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly Quaternion LBOMKCOMMDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public readonly Vector3? IHNNKMFJLFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly bool NHBPPONNBAM;

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x5C35080", Offset = "0x5C34080", VA = "0x185C35080")]
	public GPOHOJJLJCE(Quaternion LBOMKCOMMDP, Vector3? IHNNKMFJLFA, bool NHBPPONNBAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public interface FBGNAIIFKEF<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MBCCADHBLDF([In] BEBNEHBJIMI<TData> BJNFPFBDIHI);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HPGEPBAEDAB([In] JFOOHHLOKOI FHHIPNLCHFF);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HPGEPBAEDAB([In] CLJKOKEFMEB FHHIPNLCHFF);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HPGEPBAEDAB([In] JHJBPGGAIPA FHHIPNLCHFF);

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool ALNJIMBKPBC();
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public class OIONBGBDOJH<TData> : PILNJOAKLEF<FBGNAIIFKEF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private readonly JHJBPGGAIPA IIKHJJNPBGD;

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x5529030", Offset = "0x5528030", VA = "0x185529030")]
	public OIONBGBDOJH(Vector3 FLODEPDAECF, float KDJJCHBMFBP, Vector3 IHNNKMFJLFA, bool LKHJJGIFAFE, bool NBCCJCHODLO, FBGNAIIFKEF<TData> NGKGGMDFKFD, Space HJHCPMHFCLG = Space.Self)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x5528FD0", Offset = "0x5527FD0", VA = "0x185528FD0", Slot = "4")]
	public override bool CENANGHIOME()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public class CPCIFMBGMGN<TData> : PILNJOAKLEF<FBGNAIIFKEF<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x4924030", Offset = "0x4923030", VA = "0x184924030")]
	public CPCIFMBGMGN(FBGNAIIFKEF<TData> NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x67FCDA0", Offset = "0x67FBDA0", VA = "0x1867FCDA0", Slot = "4")]
	public override bool CENANGHIOME()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public class BFHGJFKINDD<TData> : PILNJOAKLEF<FBGNAIIFKEF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private readonly BEBNEHBJIMI<TData> IIKHJJNPBGD;

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x61C0490", Offset = "0x61BF490", VA = "0x1861C0490")]
	public BFHGJFKINDD(IEnumerable<TData> LIAECCDAGKL, bool HMPJNGKNIOD, FBGNAIIFKEF<TData> NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x44F3690", Offset = "0x44F2690", VA = "0x1844F3690", Slot = "4")]
	public override bool CENANGHIOME()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public class JNAFNJFKCAB<TData> : PILNJOAKLEF<FBGNAIIFKEF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private readonly CLJKOKEFMEB IIKHJJNPBGD;

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x4E429F0", Offset = "0x4E419F0", VA = "0x184E429F0")]
	public JNAFNJFKCAB(float AMBDJACFHOE, bool JFNKFDNNGED, Vector3 IHNNKMFJLFA, FBGNAIIFKEF<TData> NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x4E42930", Offset = "0x4E41930", VA = "0x184E42930", Slot = "4")]
	public override bool CENANGHIOME()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public class EKBICOEKFND<TData> : PILNJOAKLEF<FBGNAIIFKEF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private readonly JFOOHHLOKOI IIKHJJNPBGD;

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x44E1630", Offset = "0x44E0630", VA = "0x1844E1630")]
	public EKBICOEKFND(float KDJJCHBMFBP, Vector3 IHNNKMFJLFA, FBGNAIIFKEF<TData> NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x44E15D0", Offset = "0x44E05D0", VA = "0x1844E15D0", Slot = "4")]
	public override bool CENANGHIOME()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public struct JHJBPGGAIPA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public readonly Vector3 FLODEPDAECF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public readonly float KDJJCHBMFBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public readonly Vector3 IHNNKMFJLFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public readonly bool PMAMFBECNPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public readonly Space HJHCPMHFCLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public readonly bool NBCCJCHODLO;

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x7CBEF00", Offset = "0x7CBDF00", VA = "0x187CBEF00")]
	public JHJBPGGAIPA(Vector3 FLODEPDAECF, float KDJJCHBMFBP, Vector3 IHNNKMFJLFA, bool PMAMFBECNPK, bool EMFLFNBCFBG, Space HJHCPMHFCLG = Space.Self)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public struct BEBNEHBJIMI<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public readonly IEnumerable<TData> LIAECCDAGKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public readonly bool HMPJNGKNIOD;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x61BCC60", Offset = "0x61BBC60", VA = "0x1861BCC60")]
	public BEBNEHBJIMI(IEnumerable<TData> LIAECCDAGKL, bool HMPJNGKNIOD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public struct CLJKOKEFMEB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public readonly float AMBDJACFHOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public readonly bool JFNKFDNNGED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public readonly Vector3 IHNNKMFJLFA;

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x7CBDEC0", Offset = "0x7CBCEC0", VA = "0x187CBDEC0")]
	public CLJKOKEFMEB(float AMBDJACFHOE, bool JFNKFDNNGED, Vector3 IHNNKMFJLFA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public struct JFOOHHLOKOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public readonly float KDJJCHBMFBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public readonly Vector3 IHNNKMFJLFA;

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x5BF5290", Offset = "0x5BF4290", VA = "0x185BF5290")]
	public JFOOHHLOKOI(float KDJJCHBMFBP, Vector3 IHNNKMFJLFA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public struct CNGGOIFGKLJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public readonly Guid[] LIAECCDAGKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public readonly bool HGJDMLMLLGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public readonly bool ONDIMGBBPJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public readonly bool IHHJNFJPODO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public readonly Vector3[] BEEPPLKKJCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public readonly Quaternion[] LNMCKDAHFFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public readonly float[] PKINALFPPEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public readonly Dictionary<Guid, Vector3> EHDIBACCOLF;

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x7CBE0B0", Offset = "0x7CBD0B0", VA = "0x187CBE0B0")]
	public CNGGOIFGKLJ(Guid[] DENJFPGMEIJ, Vector3[] BEEPPLKKJCL, Quaternion[] LNMCKDAHFFE, float[] PKINALFPPEB, Dictionary<Guid, Vector3> EHDIBACCOLF, bool HGJDMLMLLGD = true, bool ONDIMGBBPJI = true, bool IHHJNFJPODO = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7CBDEE0", Offset = "0x7CBCEE0", VA = "0x187CBDEE0")]
	private static void NLIBNBLBMMK(Dictionary<Guid, Vector3> EHDIBACCOLF, int GGOFIHFFDBH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public static class PLPJEICCDBN
{
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	private struct BNENBMBJCPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public bool LHPCJNJIGBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public AINJBKKEAIL NMEPAIFHADH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public AINJBKKEAIL BCHLBJOAPFO;
	}

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static BNENBMBJCPG GHMLEIBEHII;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static CancellationToken IOEHGJLONAP
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x7CBF4F0", Offset = "0x7CBE4F0", VA = "0x187CBF4F0")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	internal static AINJBKKEAIL NMEPAIFHADH
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x7CBF450", Offset = "0x7CBE450", VA = "0x187CBF450")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x7CBF670", Offset = "0x7CBE670", VA = "0x187CBF670")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x7CBF300", Offset = "0x7CBE300", VA = "0x187CBF300")]
	[AOJMKBDAFKB.IAGHHAMHDJE]
	internal static void CPNCJILCPPN(AINJBKKEAIL NEIFCKNFABK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x7CBF510", Offset = "0x7CBE510", VA = "0x187CBF510")]
	public static void KGPJOLOPJJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x7CBF400", Offset = "0x7CBE400", VA = "0x187CBF400")]
	private static AINJBKKEAIL DHKECOHFNEE(AINJBKKEAIL LDALBILPAIG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public static class BOKCJLONMDA
{
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	public enum BKPBPMPDHEO
	{
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		ICreationContextObject,
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		Guid
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x35D09E0", Offset = "0x35CF9E0", VA = "0x1835D09E0")]
	public static void GGAIDHHKEMK<T>(T ELJDCHFNJGK, BKPBPMPDHEO MLCOGCMJLBB) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x35D0B40", Offset = "0x35CFB40", VA = "0x1835D0B40")]
	public static void GGAIDHHKEMK<T>(T ELJDCHFNJGK) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x35D08F0", Offset = "0x35CF8F0", VA = "0x1835D08F0")]
	public static void GGAIDHHKEMK<T, TImpl, T>() where T : class where TImpl : notnull, T where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x35D0730", Offset = "0x35CF730", VA = "0x1835D0730")]
	public static void FBMILLJKCGN<T>(T ELJDCHFNJGK) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x35D0DC0", Offset = "0x35CFDC0", VA = "0x1835D0DC0")]
	public static T PHDCGNDDLGA<T>(BKPBPMPDHEO MLCOGCMJLBB) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x35D0C70", Offset = "0x35CFC70", VA = "0x1835D0C70")]
	public static bool LEDEGLNAGAD<T>(BKPBPMPDHEO MLCOGCMJLBB, T? EGMOHNBEECK, [Out][MaybeNullWhen(false)][NotNullWhen(true)] T OIIOOCJDPLJ) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x35D0620", Offset = "0x35CF620", VA = "0x1835D0620")]
	public static bool CJHBFGKCIPL<T>(BKPBPMPDHEO MLCOGCMJLBB, [Out][NotNullWhen(true)][MaybeNullWhen(false)] T PGOADNDPNKM) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x35D0840", Offset = "0x35CF840", VA = "0x1835D0840")]
	public static bool FHJCOLKGBCA<T>(BKPBPMPDHEO MLCOGCMJLBB) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x35D07E0", Offset = "0x35CF7E0", VA = "0x1835D07E0")]
	public static T PHDCGNDDLGA<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x35D0BB0", Offset = "0x35CFBB0", VA = "0x1835D0BB0")]
	public static bool LEDEGLNAGAD<T>(T EGMOHNBEECK, [Out] T OIIOOCJDPLJ) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x35D07E0", Offset = "0x35CF7E0", VA = "0x1835D07E0")]
	public static bool FHJCOLKGBCA<T>() where T : class
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
internal static class NFLEPBLPCAC
{
	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x7CBF030", Offset = "0x7CBE030", VA = "0x187CBF030")]
	public static void OMMAKAKPEOH(IEnumerable HIBAJBJLMJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x398D660", Offset = "0x398C660", VA = "0x18398D660")]
	public static void OMMAKAKPEOH<T>(T[] NBBLCIBNPBK) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x398D840", Offset = "0x398C840", VA = "0x18398D840")]
	public static void OMMAKAKPEOH<T>(T PCHMHBNEGIN) where T : notnull, Enum
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
