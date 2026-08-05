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
		[Cpp2IlInjected.Address(RVA = "0xA149D0", Offset = "0xA12FD0", VA = "0x180A149D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C8A730", Offset = "0x7C88D30", VA = "0x187C8A730")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA154F0", Offset = "0xA13AF0", VA = "0x180A154F0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA15530", Offset = "0xA13B30", VA = "0x180A15530")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C8AB60", Offset = "0x7C89160", VA = "0x187C8AB60", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2645EC0", Offset = "0x26444C0", VA = "0x182645EC0")]
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
	[Cpp2IlInjected.Address(RVA = "0x4AD4AE0", Offset = "0x4AD30E0", VA = "0x184AD4AE0")]
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
	[Cpp2IlInjected.Address(RVA = "0x49AD4B0", Offset = "0x49ABAB0", VA = "0x1849AD4B0")]
	public FIKFAJCCJFO(IEnumerable<TData> LIAECCDAGKL, bool FHJECAEPFID, float? LMHOAGCNJFG, float? OOGHBEFHNIB, float? IEPELDNMGLC, bool HMPJNGKNIOD, LJCLANENGGM<TData> NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x452D9B0", Offset = "0x452BFB0", VA = "0x18452D9B0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x633B660", Offset = "0x6339C60", VA = "0x18633B660")]
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
	[Cpp2IlInjected.Address(RVA = "0x4ABC210", Offset = "0x4ABA810", VA = "0x184ABC210")]
	public GHHFKNFAHKA(IEnumerable<TData> LIAECCDAGKL, string PCHIHCHIMHB, bool GHKGNHCHHJJ, bool HMPJNGKNIOD, EAOFLEDHDMC<TData> NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x452D9B0", Offset = "0x452BFB0", VA = "0x18452D9B0", Slot = "4")]
	public override bool CENANGHIOME()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public abstract class PILNJOAKLEF<TReceiver> : KMIMKIPKFGA<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4963F10", Offset = "0x4962510", VA = "0x184963F10")]
	public PILNJOAKLEF(TReceiver NGKGGMDFKFD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public abstract class CGLNCCHPIIL<TReceiver, TFromTask> : KMIMKIPKFGA<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4963F10", Offset = "0x4962510", VA = "0x184963F10")]
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
	[Cpp2IlInjected.Address(RVA = "0x501AFA0", Offset = "0x50195A0", VA = "0x18501AFA0")]
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
	[Cpp2IlInjected.Address(RVA = "0x4963F10", Offset = "0x4962510", VA = "0x184963F10")]
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
	[Cpp2IlInjected.Address(RVA = "0x2195260", Offset = "0x2193860", VA = "0x182195260")]
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
	[Cpp2IlInjected.Address(RVA = "0xABB7D0", Offset = "0xAB9DD0", VA = "0x180ABB7D0")]
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
	[Cpp2IlInjected.Address(RVA = "0xD2EEF0", Offset = "0xD2D4F0", VA = "0x180D2EEF0")]
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
	[Cpp2IlInjected.Address(RVA = "0x7C89800", Offset = "0x7C87E00", VA = "0x187C89800")]
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
	[Cpp2IlInjected.Address(RVA = "0x2580B10", Offset = "0x257F110", VA = "0x182580B10")]
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
	[Cpp2IlInjected.Address(RVA = "0x53CCFE0", Offset = "0x53CB5E0", VA = "0x1853CCFE0")]
	public NAGLMOJAKAG(TGroup MMDFHIJHCKI, IEnumerable<TData> LIAECCDAGKL, NCCDDHCBBEO<TGroup, TData> NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x53CCF10", Offset = "0x53CB510", VA = "0x1853CCF10", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x4AC1EE0", Offset = "0x4AC04E0", VA = "0x184AC1EE0")]
	public GJCKOIHPGIO(TGroup MMDFHIJHCKI, TData ENJPIPBKKMC, IEnumerable<TData> LIAECCDAGKL, NCCDDHCBBEO<TGroup, TData> NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x4AC1E10", Offset = "0x4AC0410", VA = "0x184AC1E10", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x55149C0", Offset = "0x5512FC0", VA = "0x1855149C0")]
	public POPIDCMGEJL(TGroup MMDFHIJHCKI, NCCDDHCBBEO<TGroup, TData> NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x563B400", Offset = "0x5639A00", VA = "0x18563B400", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x4AC1EE0", Offset = "0x4AC04E0", VA = "0x184AC1EE0")]
	public ANENJKKFMKI(TGroup MMDFHIJHCKI, TData EPPPFGPKGJP, IEnumerable<TData> LIAECCDAGKL, NCCDDHCBBEO<TGroup, TData> NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x4F58BB0", Offset = "0x4F571B0", VA = "0x184F58BB0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C89DA0", Offset = "0x7C883A0", VA = "0x187C89DA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7C8A030", Offset = "0x7C88630", VA = "0x187C8A030", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private DAPHFIIDOLN MMEGIMHACGE;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7C89930", Offset = "0x7C87F30", VA = "0x187C89930")]
	public DIDPLBAIGPI(IEnumerable<Guid> CMDNDNLJFOD, Guid CHIEFBDHPKP, bool HMPJNGKNIOD, NKMIJAMBKBA NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7C89840", Offset = "0x7C87E40", VA = "0x187C89840", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C88CD0", Offset = "0x7C872D0", VA = "0x187C88CD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7C88F70", Offset = "0x7C87570", VA = "0x187C88F70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly OANCLHDCFJN MMEGIMHACGE;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7C88C50", Offset = "0x7C87250", VA = "0x187C88C50")]
	public ACGANKGEKMO(Guid CHIEFBDHPKP, bool HMPJNGKNIOD, NKMIJAMBKBA NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7C88B60", Offset = "0x7C87160", VA = "0x187C88B60", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x7C8A710", Offset = "0x7C88D10", VA = "0x187C8A710")]
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
		[Cpp2IlInjected.Address(RVA = "0x513C040", Offset = "0x513A640", VA = "0x18513C040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x44F3460", Offset = "0x44F1A60", VA = "0x1844F3460", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly NOHGDCJLGKP BNOGNLIBFME;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x4E80530", Offset = "0x4E7EB30", VA = "0x184E80530")]
	public JILNKMLIHJO(GGINLHMMKPC IIICABHNDOI, bool HMPJNGKNIOD, IDDMLBIKGEJ<TSpawnType> NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x4E80230", Offset = "0x4E7E830", VA = "0x184E80230", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x7C89C80", Offset = "0x7C88280", VA = "0x187C89C80")]
	public GGINLHMMKPC(Transform EJFMFHGPPNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7C89CF0", Offset = "0x7C882F0", VA = "0x187C89CF0")]
	public GGINLHMMKPC(Vector3 HPAMHMBDLLL, Vector3 EPCLGOKLIPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7C89C50", Offset = "0x7C88250", VA = "0x187C89C50")]
	public static GGINLHMMKPC OKKBPPIELHH()
	{
		return default(GGINLHMMKPC);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7C89D20", Offset = "0x7C88320", VA = "0x187C89D20")]
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
	[Cpp2IlInjected.Address(RVA = "0x4A7A270", Offset = "0x4A78870", VA = "0x184A7A270")]
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
	[Cpp2IlInjected.Address(RVA = "0x4E79910", Offset = "0x4E77F10", VA = "0x184E79910")]
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
	[Cpp2IlInjected.Address(RVA = "0x4963F10", Offset = "0x4962510", VA = "0x184963F10")]
	public PMCCFFNEOKJ(CBPABPGJHDJ<TNode, TReparentOperations> NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x560DBA0", Offset = "0x560C1A0", VA = "0x18560DBA0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x4B23450", Offset = "0x4B21A50", VA = "0x184B23450")]
	public HHKAELIPAGH(TNode PBOCNBJFHBL, TReparentOperations GFECLHCHFBM, DKEDCAAHGAG CJAOOBBGMFL, CBPABPGJHDJ<TNode, TReparentOperations> NGKGGMDFKFD, bool HMPJNGKNIOD = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x4B23390", Offset = "0x4B21990", VA = "0x184B23390", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x4E6FD80", Offset = "0x4E6E380", VA = "0x184E6FD80")]
	public JDKCNGMDCKA(TNode HFPMCMFACLL, CBPABPGJHDJ<TNode, TReparentOperations> NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x452D9B0", Offset = "0x452BFB0", VA = "0x18452D9B0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x5359250", Offset = "0x5357850", VA = "0x185359250")]
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
	[Cpp2IlInjected.Address(RVA = "0x6411E20", Offset = "0x6410420", VA = "0x186411E20")]
	public BNNGGKBBNJJ(TSpawnInfo PCDOHBFFPJE, Vector3 EPCLGOKLIPO, Quaternion OOBEGCNALKF, float HDLKNIPAJGK, DAEHOMILFJE<TSpawnType, TSpawnInfo> NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4E82FE0", Offset = "0x4E815E0", VA = "0x184E82FE0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x51647C0", Offset = "0x5162DC0", VA = "0x1851647C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x4E83170", Offset = "0x4E81770", VA = "0x184E83170")]
	public JJGGLFAONHK(IEnumerable<TData> LIAECCDAGKL, bool HMPJNGKNIOD, AJAGIEIKFNE<TData> NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x4E82FE0", Offset = "0x4E815E0", VA = "0x184E82FE0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x4A86AA0", Offset = "0x4A850A0", VA = "0x184A86AA0")]
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
	[Cpp2IlInjected.Address(RVA = "0x498EB50", Offset = "0x498D150", VA = "0x18498EB50")]
	public FAPPGLMLKGP(T JEMOCGHLMEI, bool GHDMMGHHCHI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public class FDGCKMBGNFO<T> : PILNJOAKLEF<CHCKPCGOCME<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x4963F10", Offset = "0x4962510", VA = "0x184963F10")]
	public FDGCKMBGNFO(CHCKPCGOCME<T> NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x4999230", Offset = "0x4997830", VA = "0x184999230", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x5514930", Offset = "0x5512F30", VA = "0x185514930")]
	public OBACJNJAENJ(T FCPOJLOEIEO, CHCKPCGOCME<T> NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x452D9B0", Offset = "0x452BFB0", VA = "0x18452D9B0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x5150FC0", Offset = "0x514F5C0", VA = "0x185150FC0")]
	public LMEANKKPIPF(T FCPOJLOEIEO, bool GHDMMGHHCHI, JAEELCMCKOD<T> NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x452D9B0", Offset = "0x452BFB0", VA = "0x18452D9B0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x44FC590", Offset = "0x44FAB90", VA = "0x1844FC590")]
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
	[Cpp2IlInjected.Address(RVA = "0x499BBF0", Offset = "0x499A1F0", VA = "0x18499BBF0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5527740", Offset = "0x5525D40", VA = "0x185527740")]
	public OEEDOOACCIP(List<TData> LIAECCDAGKL, bool KEFOGHGKANA, BNBOMLKEGKJ<TData> NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x452D9B0", Offset = "0x452BFB0", VA = "0x18452D9B0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x49B15A0", Offset = "0x49AFBA0", VA = "0x1849B15A0")]
	public FJFCCFNIMMP(List<TData> LIAECCDAGKL, List<bool> HMJECHNNGDO, BNBOMLKEGKJ<TData> NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x49B14E0", Offset = "0x49AFAE0", VA = "0x1849B14E0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x4C468E0", Offset = "0x4C44EE0", VA = "0x184C468E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x4C46BC0", Offset = "0x4C451C0", VA = "0x184C46BC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly KDHDJNHMOCM<TData> CCHEFNPALBJ;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4C1EB90", Offset = "0x4C1D190", VA = "0x184C1EB90")]
	public IBCLGKNLHIP(TData DNBOJLCFHGA, IReadOnlyList<TData> LFBKCPGGEHL, bool HMPJNGKNIOD, BBEABHPHGEF<TData> NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x4C1EA90", Offset = "0x4C1D090", VA = "0x184C1EA90", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2C8DCA0", Offset = "0x2C8C2A0", VA = "0x182C8DCA0")]
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
	[Cpp2IlInjected.Address(RVA = "0x6A43850", Offset = "0x6A41E50", VA = "0x186A43850")]
	public DJKGGBAPGHG(IEnumerable<TData> LIAECCDAGKL, IHNAGNCLKBF NGGKCKILBNF, MNHJGJHOEHN CANJBFKPEMF, float KPNAELOMDEE, string? PCHIHCHIMHB, bool CFHBAJNBIDK, bool HMPJNGKNIOD, GLPGPJDKODF<TData> NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x452D9B0", Offset = "0x452BFB0", VA = "0x18452D9B0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x6A3EB10", Offset = "0x6A3D110", VA = "0x186A3EB10")]
	public DHMPCFHOMNM(TData[] LIAECCDAGKL, IHNAGNCLKBF[] NGGKCKILBNF, MNHJGJHOEHN[] CANJBFKPEMF, float[] KPNAELOMDEE, ECJNCDPFBII<TData> NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x4E6CB30", Offset = "0x4E6B130", VA = "0x184E6CB30", Slot = "4")]
	public override bool CENANGHIOME()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class BPLOCJKOMLP<TData> : PILNJOAKLEF<CKAEKBLEAOP<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x4963F10", Offset = "0x4962510", VA = "0x184963F10")]
	public BPLOCJKOMLP(CKAEKBLEAOP<TData> NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6423260", Offset = "0x6421860", VA = "0x186423260", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x4E6CBF0", Offset = "0x4E6B1F0", VA = "0x184E6CBF0")]
	public JCHKNKNCBJF(IEnumerable<TData> LIAECCDAGKL, IHNAGNCLKBF NGGKCKILBNF, MNHJGJHOEHN CANJBFKPEMF, float KPNAELOMDEE, CKAEKBLEAOP<TData> NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x4E6CB30", Offset = "0x4E6B130", VA = "0x184E6CB30", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x4A822F0", Offset = "0x4A808F0", VA = "0x184A822F0")]
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
	[Cpp2IlInjected.Address(RVA = "0x4E7ADA0", Offset = "0x4E793A0", VA = "0x184E7ADA0")]
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
	[Cpp2IlInjected.Address(RVA = "0x4522670", Offset = "0x4520C70", VA = "0x184522670")]
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
	[Cpp2IlInjected.Address(RVA = "0x67AF7D0", Offset = "0x67ADDD0", VA = "0x1867AF7D0")]
	public CHJOLFJABBN(List<TData> OLCBBPLHPLC, GBPFLFFEDLC<TData> NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x452D9B0", Offset = "0x452BFB0", VA = "0x18452D9B0", Slot = "4")]
	public override bool CENANGHIOME()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class GNKBIDLNGJN<TData> : PILNJOAKLEF<GBPFLFFEDLC<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4963F10", Offset = "0x4962510", VA = "0x184963F10")]
	public GNKBIDLNGJN(GBPFLFFEDLC<TData> NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x4AD1130", Offset = "0x4ACF730", VA = "0x184AD1130", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x4529DF0", Offset = "0x45283F0", VA = "0x184529DF0")]
	public EMHDILFNDOI(bool HMPJNGKNIOD, GBPFLFFEDLC<TData> NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x4529D90", Offset = "0x4528390", VA = "0x184529D90", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x4F57EB0", Offset = "0x4F564B0", VA = "0x184F57EB0")]
	public ANBAIPADODP(List<TData> OLCBBPLHPLC, bool HMPJNGKNIOD, GBPFLFFEDLC<TData> NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x49B14E0", Offset = "0x49AFAE0", VA = "0x1849B14E0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x51511E0", Offset = "0x514F7E0", VA = "0x1851511E0")]
	public LMEBIGMDCAL(TData KFPIOIGLGHH, GBPFLFFEDLC<TData> NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x5151060", Offset = "0x514F660", VA = "0x185151060", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x4A7E910", Offset = "0x4A7CF10", VA = "0x184A7E910")]
	public AFGMIACLJIA(IEnumerable<TData> OLCBBPLHPLC, GBPFLFFEDLC<TData> NGKGGMDFKFD, bool HMPJNGKNIOD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x4A7E7A0", Offset = "0x4A7CDA0", VA = "0x184A7E7A0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x49B5040", Offset = "0x49B3640", VA = "0x1849B5040")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C8A0C0", Offset = "0x7C886C0", VA = "0x187C8A0C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7C8A340", Offset = "0x7C88940", VA = "0x187C8A340", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly PGOAKHGPGAD MBHLPLIGGCG;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x7C89BF0", Offset = "0x7C881F0", VA = "0x187C89BF0")]
	public FJHHOMFNKCP(bool HMPJNGKNIOD, AEGKCKHMKAJ NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x7C89B00", Offset = "0x7C88100", VA = "0x187C89B00", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x29A9300", Offset = "0x29A7900", VA = "0x1829A9300")]
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
	[Cpp2IlInjected.Address(RVA = "0x5C92E40", Offset = "0x5C91440", VA = "0x185C92E40")]
	public NDFHLGCPNBF(bool DOBHHKPIDED, bool NNHCKDJNEMK, bool HDLKNIPAJGK, bool HMPJNGKNIOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7C8A4D0", Offset = "0x7C88AD0", VA = "0x187C8A4D0")]
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
	[Cpp2IlInjected.Address(RVA = "0x7C8A440", Offset = "0x7C88A40", VA = "0x187C8A440")]
	public MACBBAIFHCH(bool KOOMPFGMBLG, bool NNHCKDJNEMK, bool HDLKNIPAJGK, bool HMPJNGKNIOD, MHCDOLPNDPO NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x7C8A3F0", Offset = "0x7C889F0", VA = "0x187C8A3F0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x7C89A40", Offset = "0x7C88040", VA = "0x187C89A40")]
	public FEMJICEGAJM(bool NNHCKDJNEMK, bool HMPJNGKNIOD, MHCDOLPNDPO NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x7C899F0", Offset = "0x7C87FF0", VA = "0x187C899F0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x7C891A0", Offset = "0x7C877A0", VA = "0x187C891A0")]
	public BGCEACCBGMO(Guid[] DENJFPGMEIJ, Vector3[] BEEPPLKKJCL, Quaternion[] LNMCKDAHFFE, float[] PKINALFPPEB, Dictionary<Guid, Vector3> EHDIBACCOLF, DKIKBKNKNBH NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7C890F0", Offset = "0x7C876F0", VA = "0x187C890F0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x4963F10", Offset = "0x4962510", VA = "0x184963F10")]
	public IEOCJOAALON(IGMNEBIOCDD<TData> NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x4C32610", Offset = "0x4C30C10", VA = "0x184C32610", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x5617B80", Offset = "0x5616180", VA = "0x185617B80")]
	public PGHLPPDIPCE(Vector3 IEOICJNAMOG, bool PMAMFBECNPK, IGMNEBIOCDD<TData> NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x45220C0", Offset = "0x45206C0", VA = "0x1845220C0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x563CEA0", Offset = "0x563B4A0", VA = "0x18563CEA0")]
	public PPGPEAHNBFM(Guid HFBFDILABOM, int OHHMJGCBCKD, Vector3 EPCLGOKLIPO, Quaternion OOBEGCNALKF, float PIBKBDEFJIN, bool PMAMFBECNPK, IGMNEBIOCDD<TData> NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x563CE40", Offset = "0x563B440", VA = "0x18563CE40", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x4C3DFB0", Offset = "0x4C3C5B0", VA = "0x184C3DFB0")]
	public ILDIFDKEBMF(TData FCPOJLOEIEO, bool HMPJNGKNIOD, IGMNEBIOCDD<TData> NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x452D9B0", Offset = "0x452BFB0", VA = "0x18452D9B0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x7C8A0A0", Offset = "0x7C886A0", VA = "0x187C8A0A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x7C89AC0", Offset = "0x7C880C0", VA = "0x187C89AC0")]
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
	[Cpp2IlInjected.Address(RVA = "0x49A05D0", Offset = "0x499EBD0", VA = "0x1849A05D0")]
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
	[Cpp2IlInjected.Address(RVA = "0x4ABD3F0", Offset = "0x4ABB9F0", VA = "0x184ABD3F0")]
	public GIEHDFCEIAE(IEnumerable<TData> LIAECCDAGKL, Vector3 LBOMKCOMMDP, bool HMPJNGKNIOD, MLMNDDIJILE<TData> NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x452D9B0", Offset = "0x452BFB0", VA = "0x18452D9B0", Slot = "4")]
	public override bool CENANGHIOME()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class PDMLDCAJJIN<TData> : PILNJOAKLEF<CGHMLNMODAD<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x4963F10", Offset = "0x4962510", VA = "0x184963F10")]
	public PDMLDCAJJIN(CGHMLNMODAD<TData> NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x560DBA0", Offset = "0x560C1A0", VA = "0x18560DBA0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x452DB10", Offset = "0x452C110", VA = "0x18452DB10")]
	public EOAMFPJNHBE(IEnumerable<TData> LIAECCDAGKL, bool HMPJNGKNIOD, CGHMLNMODAD<TData> NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x452D9B0", Offset = "0x452BFB0", VA = "0x18452D9B0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x552C7C0", Offset = "0x552ADC0", VA = "0x18552C7C0")]
	public OGDIAOPLBKK(IEnumerable<TData> LIAECCDAGKL, Vector3 HPPJIHIHKBL, ILOHMIAHPMC JIJPFCFAMIM, bool HMPJNGKNIOD, MLMNDDIJILE<TData> NGKGGMDFKFD, Space HJHCPMHFCLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x4B23390", Offset = "0x4B21990", VA = "0x184B23390", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x49B16C0", Offset = "0x49AFCC0", VA = "0x1849B16C0")]
	public FJMFIECCAMH(Vector3 LBOMKCOMMDP, CGHMLNMODAD<TData> NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x45220C0", Offset = "0x45206C0", VA = "0x1845220C0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x4E87800", Offset = "0x4E85E00", VA = "0x184E87800")]
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
	[Cpp2IlInjected.Address(RVA = "0x5346110", Offset = "0x5344710", VA = "0x185346110")]
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
	[Cpp2IlInjected.Address(RVA = "0x4A9D410", Offset = "0x4A9BA10", VA = "0x184A9D410")]
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
	[Cpp2IlInjected.Address(RVA = "0xEC65F0", Offset = "0xEC4BF0", VA = "0x180EC65F0")]
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
	[Cpp2IlInjected.Address(RVA = "0x7C89090", Offset = "0x7C87690", VA = "0x187C89090")]
	public BFKIKANMCKE(bool HMPJNGKNIOD, LALNGCBCAKP NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x7C88FE0", Offset = "0x7C875E0", VA = "0x187C88FE0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x29A9300", Offset = "0x29A7900", VA = "0x1829A9300")]
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
	[Cpp2IlInjected.Address(RVA = "0x4C3BBA0", Offset = "0x4C3A1A0", VA = "0x184C3BBA0")]
	public IIJIFLAIGNO(IEnumerable<TData> LIAECCDAGKL, Quaternion LBOMKCOMMDP, Vector3? IHNNKMFJLFA, bool NHBPPONNBAM, bool HMPJNGKNIOD, KNPCODHALMD<TData> NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x452D9B0", Offset = "0x452BFB0", VA = "0x18452D9B0", Slot = "4")]
	public override bool CENANGHIOME()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class DBKGAPGMMPD<TData> : PILNJOAKLEF<DIBAGKLNMAM<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x4963F10", Offset = "0x4962510", VA = "0x184963F10")]
	public DBKGAPGMMPD(DIBAGKLNMAM<TData> NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x560DBA0", Offset = "0x560C1A0", VA = "0x18560DBA0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x4E832C0", Offset = "0x4E818C0", VA = "0x184E832C0")]
	public JJLCGGAAPAI(IEnumerable<TData> LIAECCDAGKL, bool HMPJNGKNIOD, DIBAGKLNMAM<TData> NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x452D9B0", Offset = "0x452BFB0", VA = "0x18452D9B0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x4E7F4D0", Offset = "0x4E7DAD0", VA = "0x184E7F4D0")]
	public JHICLKFNBCL(IEnumerable<TData> LIAECCDAGKL, Quaternion EDAJKKBNMIB, ILOHMIAHPMC LJFIEFKMJFF, Vector3? IHNNKMFJLFA, bool NHBPPONNBAM, bool HMPJNGKNIOD, Space HJHCPMHFCLG, KNPCODHALMD<TData> NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x4B23390", Offset = "0x4B21990", VA = "0x184B23390", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x514F920", Offset = "0x514DF20", VA = "0x18514F920")]
	public LJJHJJABFEL(Quaternion LBOMKCOMMDP, Vector3? IHNNKMFJLFA, bool NHBPPONNBAM, DIBAGKLNMAM<TData> NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x45220C0", Offset = "0x45206C0", VA = "0x1845220C0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x500DAC0", Offset = "0x500C0C0", VA = "0x18500DAC0")]
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
	[Cpp2IlInjected.Address(RVA = "0x514F2F0", Offset = "0x514D8F0", VA = "0x18514F2F0")]
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
	[Cpp2IlInjected.Address(RVA = "0x6A46210", Offset = "0x6A44810", VA = "0x186A46210")]
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
	[Cpp2IlInjected.Address(RVA = "0x5C3B620", Offset = "0x5C39C20", VA = "0x185C3B620")]
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
	[Cpp2IlInjected.Address(RVA = "0x553DB20", Offset = "0x553C120", VA = "0x18553DB20")]
	public OIONBGBDOJH(Vector3 FLODEPDAECF, float KDJJCHBMFBP, Vector3 IHNNKMFJLFA, bool LKHJJGIFAFE, bool NBCCJCHODLO, FBGNAIIFKEF<TData> NGKGGMDFKFD, Space HJHCPMHFCLG = Space.Self)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x553DAC0", Offset = "0x553C0C0", VA = "0x18553DAC0", Slot = "4")]
	public override bool CENANGHIOME()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public class CPCIFMBGMGN<TData> : PILNJOAKLEF<FBGNAIIFKEF<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x4963F10", Offset = "0x4962510", VA = "0x184963F10")]
	public CPCIFMBGMGN(FBGNAIIFKEF<TData> NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x67DE570", Offset = "0x67DCB70", VA = "0x1867DE570", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x6236F50", Offset = "0x6235550", VA = "0x186236F50")]
	public BFHGJFKINDD(IEnumerable<TData> LIAECCDAGKL, bool HMPJNGKNIOD, FBGNAIIFKEF<TData> NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x452D9B0", Offset = "0x452BFB0", VA = "0x18452D9B0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x4E8B480", Offset = "0x4E89A80", VA = "0x184E8B480")]
	public JNAFNJFKCAB(float AMBDJACFHOE, bool JFNKFDNNGED, Vector3 IHNNKMFJLFA, FBGNAIIFKEF<TData> NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x4E8B3C0", Offset = "0x4E899C0", VA = "0x184E8B3C0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x4522120", Offset = "0x4520720", VA = "0x184522120")]
	public EKBICOEKFND(float KDJJCHBMFBP, Vector3 IHNNKMFJLFA, FBGNAIIFKEF<TData> NGKGGMDFKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x45220C0", Offset = "0x45206C0", VA = "0x1845220C0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x7C8A3B0", Offset = "0x7C889B0", VA = "0x187C8A3B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x6152270", Offset = "0x6150870", VA = "0x186152270")]
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
	[Cpp2IlInjected.Address(RVA = "0x7C89380", Offset = "0x7C87980", VA = "0x187C89380")]
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
	[Cpp2IlInjected.Address(RVA = "0x5C0C860", Offset = "0x5C0AE60", VA = "0x185C0C860")]
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
	[Cpp2IlInjected.Address(RVA = "0x7C89570", Offset = "0x7C87B70", VA = "0x187C89570")]
	public CNGGOIFGKLJ(Guid[] DENJFPGMEIJ, Vector3[] BEEPPLKKJCL, Quaternion[] LNMCKDAHFFE, float[] PKINALFPPEB, Dictionary<Guid, Vector3> EHDIBACCOLF, bool HGJDMLMLLGD = true, bool ONDIMGBBPJI = true, bool IHHJNFJPODO = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7C893A0", Offset = "0x7C879A0", VA = "0x187C893A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C8A990", Offset = "0x7C88F90", VA = "0x187C8A990")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	internal static AINJBKKEAIL NMEPAIFHADH
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x7C8A8F0", Offset = "0x7C88EF0", VA = "0x187C8A8F0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x7C8AB00", Offset = "0x7C89100", VA = "0x187C8AB00")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x7C8A7B0", Offset = "0x7C88DB0", VA = "0x187C8A7B0")]
	[AOJMKBDAFKB.IAGHHAMHDJE]
	internal static void CPNCJILCPPN(AINJBKKEAIL NEIFCKNFABK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x7C8A9B0", Offset = "0x7C88FB0", VA = "0x187C8A9B0")]
	public static void KGPJOLOPJJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x7C8A8A0", Offset = "0x7C88EA0", VA = "0x187C8A8A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x35EE160", Offset = "0x35EC760", VA = "0x1835EE160")]
	public static void GGAIDHHKEMK<T>(T ELJDCHFNJGK, BKPBPMPDHEO MLCOGCMJLBB) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x35EE2C0", Offset = "0x35EC8C0", VA = "0x1835EE2C0")]
	public static void GGAIDHHKEMK<T>(T ELJDCHFNJGK) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x35EE070", Offset = "0x35EC670", VA = "0x1835EE070")]
	public static void GGAIDHHKEMK<T, TImpl, T>() where T : class where TImpl : notnull, T where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x35EDEB0", Offset = "0x35EC4B0", VA = "0x1835EDEB0")]
	public static void FBMILLJKCGN<T>(T ELJDCHFNJGK) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x35EE540", Offset = "0x35ECB40", VA = "0x1835EE540")]
	public static T PHDCGNDDLGA<T>(BKPBPMPDHEO MLCOGCMJLBB) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x35EE3F0", Offset = "0x35EC9F0", VA = "0x1835EE3F0")]
	public static bool LEDEGLNAGAD<T>(BKPBPMPDHEO MLCOGCMJLBB, T? EGMOHNBEECK, [Out][MaybeNullWhen(false)][NotNullWhen(true)] T OIIOOCJDPLJ) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x35EDDA0", Offset = "0x35EC3A0", VA = "0x1835EDDA0")]
	public static bool CJHBFGKCIPL<T>(BKPBPMPDHEO MLCOGCMJLBB, [Out][NotNullWhen(true)][MaybeNullWhen(false)] T PGOADNDPNKM) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x35EDFC0", Offset = "0x35EC5C0", VA = "0x1835EDFC0")]
	public static bool FHJCOLKGBCA<T>(BKPBPMPDHEO MLCOGCMJLBB) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x35EDF60", Offset = "0x35EC560", VA = "0x1835EDF60")]
	public static T PHDCGNDDLGA<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x35EE330", Offset = "0x35EC930", VA = "0x1835EE330")]
	public static bool LEDEGLNAGAD<T>(T EGMOHNBEECK, [Out] T OIIOOCJDPLJ) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x35EDF60", Offset = "0x35EC560", VA = "0x1835EDF60")]
	public static bool FHJCOLKGBCA<T>() where T : class
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
internal static class NFLEPBLPCAC
{
	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x7C8A4E0", Offset = "0x7C88AE0", VA = "0x187C8A4E0")]
	public static void OMMAKAKPEOH(IEnumerable HIBAJBJLMJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x39A9C00", Offset = "0x39A8200", VA = "0x1839A9C00")]
	public static void OMMAKAKPEOH<T>(T[] NBBLCIBNPBK) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x39A9DE0", Offset = "0x39A83E0", VA = "0x1839A9DE0")]
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
