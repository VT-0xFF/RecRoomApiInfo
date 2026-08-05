using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
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
		[Cpp2IlInjected.Address(RVA = "0x79B4F0", Offset = "0x79A0F0", VA = "0x18079B4F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5E3B070", Offset = "0x5E39C70", VA = "0x185E3B070")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x79BDE0", Offset = "0x79A9E0", VA = "0x18079BDE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x79BE20", Offset = "0x79AA20", VA = "0x18079BE20")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface EBFFJKHBCGF<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ClearHoverTarget(MMEOHFGFNHH MCIHGKOIHAC);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool SetHoverTarget(TData JIGKIEPHJOJ, Collider HBCGCBBLPED, MMEOHFGFNHH MCIHGKOIHAC, [Optional] KFHCMIPAIKD? NCIICAOJEHP);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool TryGetHoverTarget([Out] TData JIGKIEPHJOJ);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface OAFGKCNNHKK<TData> : DPJHEAHIILJ, BEKEHKCFKKN<TData>, BDAHKACPOEH<TData>, CDDPGBNDLGF<TData>, MANDEIFMFJN, GEDEGAGJIKK<TData>, GALCAJDGMJI, BMBBLPDJMMM
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface GEDEGAGJIKK<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 KJENPMGNNIG, Vector3 DIFJPIHEJAN, float KIMLGCJBKME, [Out] T FFMFBGKEHBH, [Out] Vector3 ADCHJKBNMAJ, [Out] Collider HBCGCBBLPED);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 KJENPMGNNIG, Vector3 DIFJPIHEJAN, float LBNJALFDOCE, float KIMLGCJBKME, T[] MPDKHDOGJJJ, [Out] Vector3 LOEKBFPHDCJ, [Out] Collider CDNMCJKEFCO);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 KJENPMGNNIG, float LBNJALFDOCE, Vector3 ICOFNFHIEEI, T[] MPDKHDOGJJJ);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface DPJHEAHIILJ
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Bounds LENECKNGHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Transform AAGFIEMJELP
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Bounds KEJABPCEENM
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Transform IDCFAGFFGFF
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Vector3 HNNJIKJJHHP
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void SetSelectionBoundsDirty(bool KNOJACLECKC = true, int JMLEFNDNHOG = 0);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ShouldHideSelectionBoundsPreview(bool GDKPMAJIAFP, object KJCAGLABEME);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface BMBBLPDJMMM
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	NGHNHLLDGBJ JPKNMGHDBPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface CDDPGBNDLGF<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool APIAKOJIBLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	int IFNKLANHLBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	IEnumerable<TData> NFCJNNHAJLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData KADOGPFLCFA);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData KADOGPFLCFA);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface BEKEHKCFKKN<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T IIFJCGIHMIN, [Optional] KFHCMIPAIKD? HDALIMNEKHP, bool IOLFECEMEDA = true);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int EMHEDPDPEMP, IEnumerable<T> GAHOHIBHCJI, bool IOLFECEMEDA = true);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int EMHEDPDPEMP, IEnumerable<T> GAHOHIBHCJI, KFHCMIPAIKD HDALIMNEKHP, bool IOLFECEMEDA = true);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface GALCAJDGMJI
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface MANDEIFMFJN
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool BLLEILOHGND
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool OOBHJPBLBCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool JLLPPOMFELA
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool JFBENOFOIID
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class EKDFCINEFKL<TReceiver> : NHPOCNMKDJG<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x314F920", Offset = "0x314E520", VA = "0x18314F920")]
	public EKDFCINEFKL(TReceiver BHEBCLOMFGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public abstract class BAFKNJKCDJE<TReceiver, TFromTask> : NHPOCNMKDJG<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x314F920", Offset = "0x314E520", VA = "0x18314F920")]
	public BAFKNJKCDJE(TReceiver BHEBCLOMFGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class NHPOCNMKDJG<TReceiver, TFromExecute> where TReceiver : notnull where TFromExecute : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	protected TReceiver BHEBCLOMFGA;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3D20CD0", Offset = "0x3D1F8D0", VA = "0x183D20CD0")]
	public NHPOCNMKDJG(TReceiver BHEBCLOMFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute DHAKHJIICCG();
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class PBKEHKMCAMA<TReceiver, TResult> : NHPOCNMKDJG<TReceiver, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x314F920", Offset = "0x314E520", VA = "0x18314F920")]
	public PBKEHKMCAMA(TReceiver BHEBCLOMFGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct MFLEMIHACBM<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public TGroup CCHBILLGKHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public TData KICFICFDFOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public IEnumerable<TData> HBLAOCPDIOP;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x19B4E20", Offset = "0x19B3A20", VA = "0x1819B4E20")]
	public MFLEMIHACBM(TGroup HMPELPIDDHJ, TData LIABHCFEHDJ, IEnumerable<TData> EPNFMOIFHJC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct LNFOFKEDKAO<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public TGroup CCHBILLGKHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public IEnumerable<TData> HBLAOCPDIOP;

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x835CA0", Offset = "0x8348A0", VA = "0x180835CA0")]
	public LNFOFKEDKAO(TGroup HMPELPIDDHJ, IEnumerable<TData> EPNFMOIFHJC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct MOJJHEBHIBJ<TGroup> where TGroup : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public TGroup CCHBILLGKHP;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x8739C0", Offset = "0x8725C0", VA = "0x1808739C0")]
	public MOJJHEBHIBJ(TGroup HMPELPIDDHJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct ACPNLHDKACC<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public IEnumerable<TData> HBLAOCPDIOP;

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x8739C0", Offset = "0x8725C0", VA = "0x1808739C0")]
	public ACPNLHDKACC(IEnumerable<TData> EPNFMOIFHJC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface EBJAFJCNCHE<TGroup, TData>
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EJMFPPCMLBF BDPKGGJLOAP(MFLEMIHACBM<TGroup, TData> GGDDEKDNNKM);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	EJMFPPCMLBF CLNMOGIILJP(MFLEMIHACBM<TGroup, TData> GGDDEKDNNKM);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EJMFPPCMLBF FKDBNJFGIFM(LNFOFKEDKAO<TGroup, TData> GGDDEKDNNKM);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	EJMFPPCMLBF IMHJIGENPGI(MOJJHEBHIBJ<TGroup> GGDDEKDNNKM);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface LECCIKJNEMB<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<EJMFPPCMLBF> BDPKGGJLOAP(ACPNLHDKACC<TData> GGDDEKDNNKM);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class APLAJJMHCIL<TGroup, TData> : PBKEHKMCAMA<EBJAFJCNCHE<TGroup, TData>, EJMFPPCMLBF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly LNFOFKEDKAO<TGroup, TData> GGDDEKDNNKM;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x372FB00", Offset = "0x372E700", VA = "0x18372FB00")]
	public APLAJJMHCIL(TGroup HMPELPIDDHJ, IEnumerable<TData> EPNFMOIFHJC, EBJAFJCNCHE<TGroup, TData> BHEBCLOMFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x372FA30", Offset = "0x372E630", VA = "0x18372FA30", Slot = "4")]
	public override EJMFPPCMLBF DHAKHJIICCG()
	{
		return default(EJMFPPCMLBF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class JDJABMPFFJD<TGroup, TData> : PBKEHKMCAMA<EBJAFJCNCHE<TGroup, TData>, EJMFPPCMLBF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly MFLEMIHACBM<TGroup, TData> GGDDEKDNNKM;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x38E8890", Offset = "0x38E7490", VA = "0x1838E8890")]
	public JDJABMPFFJD(TGroup HMPELPIDDHJ, TData LEGAMHJNIDL, IEnumerable<TData> EPNFMOIFHJC, EBJAFJCNCHE<TGroup, TData> BHEBCLOMFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x38E87B0", Offset = "0x38E73B0", VA = "0x1838E87B0", Slot = "4")]
	public override EJMFPPCMLBF DHAKHJIICCG()
	{
		return default(EJMFPPCMLBF);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class BOJHBEDLIJI<TGroup, TData> : PBKEHKMCAMA<EBJAFJCNCHE<TGroup, TData>, EJMFPPCMLBF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly MOJJHEBHIBJ<TGroup> GGDDEKDNNKM;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3191310", Offset = "0x318FF10", VA = "0x183191310")]
	public BOJHBEDLIJI(TGroup HMPELPIDDHJ, EBJAFJCNCHE<TGroup, TData> BHEBCLOMFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x4687CB0", Offset = "0x46868B0", VA = "0x184687CB0", Slot = "4")]
	public override EJMFPPCMLBF DHAKHJIICCG()
	{
		return default(EJMFPPCMLBF);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class BPBOHHLIHKB<TGroup, TData> : PBKEHKMCAMA<EBJAFJCNCHE<TGroup, TData>, EJMFPPCMLBF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly MFLEMIHACBM<TGroup, TData> GGDDEKDNNKM;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x38E8890", Offset = "0x38E7490", VA = "0x1838E8890")]
	public BPBOHHLIHKB(TGroup HMPELPIDDHJ, TData LIABHCFEHDJ, IEnumerable<TData> EPNFMOIFHJC, EBJAFJCNCHE<TGroup, TData> BHEBCLOMFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4687DB0", Offset = "0x46869B0", VA = "0x184687DB0", Slot = "4")]
	public override EJMFPPCMLBF DHAKHJIICCG()
	{
		return default(EJMFPPCMLBF);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class EOLMOBGJOFJ<TData> : BAFKNJKCDJE<LECCIKJNEMB<TData>, EJMFPPCMLBF> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct CJBJCHBHPJJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AsyncTaskMethodBuilder<EJMFPPCMLBF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public EOLMOBGJOFJ<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private TaskAwaiter<EJMFPPCMLBF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x4A39890", Offset = "0x4A38490", VA = "0x184A39890", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x4A39B30", Offset = "0x4A38730", VA = "0x184A39B30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private ACPNLHDKACC<TData> GGDDEKDNNKM;

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3191310", Offset = "0x318FF10", VA = "0x183191310")]
	public EOLMOBGJOFJ(IEnumerable<TData> IEJAKKBNHED, LECCIKJNEMB<TData> BHEBCLOMFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3191210", Offset = "0x318FE10", VA = "0x183191210", Slot = "4")]
	[AsyncStateMachine(typeof(EOLMOBGJOFJ<>.CJBJCHBHPJJ))]
	public override Task<EJMFPPCMLBF> DHAKHJIICCG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct ILCGMCCLGOK<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public TNode CEFOGKCGMKO;

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3742180", Offset = "0x3740D80", VA = "0x183742180")]
	public ILCGMCCLGOK(TNode CEFOGKCGMKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct HBOIBDGBFNL<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public TNode KEAACHJLBFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public JBKKEGNALBM ICLNHLGJNJK;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3621430", Offset = "0x3620030", VA = "0x183621430")]
	public HBOIBDGBFNL(TNode KEAACHJLBFG, JBKKEGNALBM ICLNHLGJNJK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface AJFNHIBADEC<TNode>
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NELOFGEKGFC([In] ILCGMCCLGOK<TNode> PJPBHKBEKED);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BENJMKAKOLG([In] HBOIBDGBFNL<TNode> BHPHJICJBGN);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PFEHLOCMJML();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class MFNNKMFMBPJ<TNode> : EKDFCINEFKL<AJFNHIBADEC<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x314F920", Offset = "0x314E520", VA = "0x18314F920")]
	public MFNNKMFMBPJ(AJFNHIBADEC<TNode> BHEBCLOMFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x318CBC0", Offset = "0x318B7C0", VA = "0x18318CBC0", Slot = "4")]
	public override bool DHAKHJIICCG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class CBBKHCIEKAA<TNode> : EKDFCINEFKL<AJFNHIBADEC<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly HBOIBDGBFNL<TNode> BHPHJICJBGN;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x4880140", Offset = "0x487ED40", VA = "0x184880140")]
	public CBBKHCIEKAA(TNode KEAACHJLBFG, JBKKEGNALBM ICLNHLGJNJK, AJFNHIBADEC<TNode> BHEBCLOMFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3962490", Offset = "0x3961090", VA = "0x183962490", Slot = "4")]
	public override bool DHAKHJIICCG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class BBAPFMJCECE<TNode> : EKDFCINEFKL<AJFNHIBADEC<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly ILCGMCCLGOK<TNode> PJPBHKBEKED;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x45826C0", Offset = "0x45812C0", VA = "0x1845826C0")]
	public BBAPFMJCECE(TNode KAHNFNOPKDB, AJFNHIBADEC<TNode> BHEBCLOMFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x34CBB90", Offset = "0x34CA790", VA = "0x1834CBB90", Slot = "4")]
	public override bool DHAKHJIICCG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct GCAKGMFBPHD<TSpawnInfo> where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public TSpawnInfo HGLAKDEEFJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public Vector3 CFCLFCDKKPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public Quaternion HFKFMHAMLPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public float JIFOIDNONIC;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0xDF5CF0", Offset = "0xDF48F0", VA = "0x180DF5CF0")]
	public GCAKGMFBPHD(TSpawnInfo HGLAKDEEFJB, Vector3 CFCLFCDKKPD, Quaternion HFKFMHAMLPE, float JIFOIDNONIC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface OHENNPAFEAD<TSpawnType, TSpawnInfo>
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> HJMPNMGHBOC([In] GCAKGMFBPHD<TSpawnInfo> LJNMILMFKKJ, CancellationToken BJFJMBIBKLL);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class NNONOLICCLD<TSpawnType, TSpawnInfo> : BAFKNJKCDJE<OHENNPAFEAD<TSpawnType, TSpawnInfo>, TSpawnType> where TSpawnType : notnull where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly GCAKGMFBPHD<TSpawnInfo> ODENEMACEPI;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3D33FF0", Offset = "0x3D32BF0", VA = "0x183D33FF0")]
	public NNONOLICCLD(TSpawnInfo CEAGMILFGCE, Vector3 CFCLFCDKKPD, Quaternion HFKFMHAMLPE, float JIFOIDNONIC, OHENNPAFEAD<TSpawnType, TSpawnInfo> BHEBCLOMFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x35FF300", Offset = "0x35FDF00", VA = "0x1835FF300", Slot = "4")]
	public override Task<TSpawnType> DHAKHJIICCG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public readonly struct KNEOLOHBICP<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly IEnumerable<TData> HBLAOCPDIOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly bool MNAIFCPCDGK;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x39C40A0", Offset = "0x39C2CA0", VA = "0x1839C40A0")]
	public KNEOLOHBICP(IEnumerable<TData> EPNFMOIFHJC, bool CBOCKKBECNF = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface KIBKKCDPEIE<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<EJMFPPCMLBF> GKBLICANAAJ([In] KNEOLOHBICP<TData> EACHCCCGOFC, CancellationToken BJFJMBIBKLL);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class AIPGIBHMJOD<TData> : BAFKNJKCDJE<KIBKKCDPEIE<TData>, EJMFPPCMLBF> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly KNEOLOHBICP<TData> NKHEADGOMGK;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x35FF3E0", Offset = "0x35FDFE0", VA = "0x1835FF3E0")]
	public AIPGIBHMJOD(IEnumerable<TData> EPNFMOIFHJC, bool CBOCKKBECNF, KIBKKCDPEIE<TData> BHEBCLOMFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x35FF300", Offset = "0x35FDF00", VA = "0x1835FF300", Slot = "4")]
	public override Task<EJMFPPCMLBF> DHAKHJIICCG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct OCFMNLMKOLO<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly T JIGKIEPHJOJ;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3DE7C50", Offset = "0x3DE6850", VA = "0x183DE7C50")]
	public OCFMNLMKOLO(T ACONBKEHEFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface KIEGBACIEPH<T>
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NELOFGEKGFC([In] OCFMNLMKOLO<T> LAGCNIKJFOA);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BENJMKAKOLG();
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface OBEFJGCMALE<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DHAKHJIICCG([In] KGHIFOKPAGF<T> IOELILFLFJN);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public struct KGHIFOKPAGF<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly T JIGKIEPHJOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly bool HDKFODEFIJE;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x397B9C0", Offset = "0x397A5C0", VA = "0x18397B9C0")]
	public KGHIFOKPAGF(T ACONBKEHEFH, bool DIMGGFJJADH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class OONDCFICOOO<T> : EKDFCINEFKL<KIEGBACIEPH<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x314F920", Offset = "0x314E520", VA = "0x18314F920")]
	public OONDCFICOOO(KIEGBACIEPH<T> BHEBCLOMFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3CED090", Offset = "0x3CEBC90", VA = "0x183CED090", Slot = "4")]
	public override bool DHAKHJIICCG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class PCJBFGOFBPH<T> : EKDFCINEFKL<KIEGBACIEPH<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly OCFMNLMKOLO<T> LAGCNIKJFOA;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3E93930", Offset = "0x3E92530", VA = "0x183E93930")]
	public PCJBFGOFBPH(T JIGKIEPHJOJ, KIEGBACIEPH<T> BHEBCLOMFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x34CBB90", Offset = "0x34CA790", VA = "0x1834CBB90", Slot = "4")]
	public override bool DHAKHJIICCG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class NLEDAFKLMMA<T> : EKDFCINEFKL<OBEFJGCMALE<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly KGHIFOKPAGF<T> IOELILFLFJN;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3D251F0", Offset = "0x3D23DF0", VA = "0x183D251F0")]
	public NLEDAFKLMMA(T JIGKIEPHJOJ, bool DIMGGFJJADH, OBEFJGCMALE<T> BHEBCLOMFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x34CBB90", Offset = "0x34CA790", VA = "0x1834CBB90", Slot = "4")]
	public override bool DHAKHJIICCG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct MPBCLFDPOOP<TData> where TData : notnull, EEIFDEMPLPG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public IEnumerable<TData> HBLAOCPDIOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public bool NJLCBNIENLC;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3CC3790", Offset = "0x3CC2390", VA = "0x183CC3790")]
	public MPBCLFDPOOP(IEnumerable<TData> IJBGMCLMECD, bool LPIIHALABKN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct OMHBGGDKLPE<TData> where TData : notnull, EEIFDEMPLPG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public List<TData> HBLAOCPDIOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public List<bool> ENLMEKLKMDJ;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3E05420", Offset = "0x3E04020", VA = "0x183E05420")]
	public OMHBGGDKLPE(List<TData> IJBGMCLMECD, List<bool> FNHGDBLGCOJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface EEIFDEMPLPG
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool HKLDAHKLAGI
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface HCEJDHHGINP<TData> where TData : EEIFDEMPLPG
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DHAKHJIICCG([In] MPBCLFDPOOP<TData> OBEDANJCGEK);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DHAKHJIICCG([In] OMHBGGDKLPE<TData> OBEDANJCGEK);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class FMONEDPKMPG<TData> : EKDFCINEFKL<HCEJDHHGINP<TData>> where TData : notnull, EEIFDEMPLPG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly MPBCLFDPOOP<TData> OBEDANJCGEK;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x34F2450", Offset = "0x34F1050", VA = "0x1834F2450")]
	public FMONEDPKMPG(List<TData> EPNFMOIFHJC, bool NJLCBNIENLC, HCEJDHHGINP<TData> BHEBCLOMFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x34CBB90", Offset = "0x34CA790", VA = "0x1834CBB90", Slot = "4")]
	public override bool DHAKHJIICCG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class KKIHDHNHHNI<TData> : EKDFCINEFKL<HCEJDHHGINP<TData>> where TData : notnull, EEIFDEMPLPG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly OMHBGGDKLPE<TData> OBEDANJCGEK;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x3986AD0", Offset = "0x39856D0", VA = "0x183986AD0")]
	public KKIHDHNHHNI(List<TData> EPNFMOIFHJC, List<bool> ENLMEKLKMDJ, HCEJDHHGINP<TData> BHEBCLOMFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x3976880", Offset = "0x3975480", VA = "0x183976880", Slot = "4")]
	public override bool DHAKHJIICCG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface CNIDDJJNPDD : EEIFDEMPLPG
{
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface LHIBFMNEPOC<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<EJMFPPCMLBF> DHAKHJIICCG(JNLHDJDNJIF<TData> NKBIGMPCIND);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class GHENOOLKHHC<TData> : BAFKNJKCDJE<LHIBFMNEPOC<TData>, EJMFPPCMLBF> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct GKJKKGMCELM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public AsyncTaskMethodBuilder<EJMFPPCMLBF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public GHENOOLKHHC<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private TaskAwaiter<EJMFPPCMLBF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x35D1660", Offset = "0x35D0260", VA = "0x1835D1660", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x35D1950", Offset = "0x35D0550", VA = "0x1835D1950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly JNLHDJDNJIF<TData> MBFDLLBHJJD;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x35BB040", Offset = "0x35B9C40", VA = "0x1835BB040")]
	public GHENOOLKHHC(TData CKCCAABIPEL, IReadOnlyList<TData> DNMPAJLODMA, bool CBOCKKBECNF, LHIBFMNEPOC<TData> BHEBCLOMFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x35BAF40", Offset = "0x35B9B40", VA = "0x1835BAF40", Slot = "4")]
	[AsyncStateMachine(typeof(GHENOOLKHHC<>.GKJKKGMCELM))]
	public override Task<EJMFPPCMLBF> DHAKHJIICCG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public struct JNLHDJDNJIF<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public TData PBINOCKMKGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public IReadOnlyList<TData> DAECJCKCKCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public bool MNAIFCPCDGK;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x391DC30", Offset = "0x391C830", VA = "0x18391DC30")]
	public JNLHDJDNJIF(TData CKCCAABIPEL, IReadOnlyList<TData> DNMPAJLODMA, bool CBOCKKBECNF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface MIMECACKOEL<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DHAKHJIICCG([In] PGHFBLOPODG<TData> GCLGLPAJGJJ);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface NICFCNNCNLA<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DHAKHJIICCG([In] HPFMCDEMMKI<TData> GCLGLPAJGJJ);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface BBNBBHGIBHH<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CLEFFOMOJLJ([In] JLHNAIGFIAK<TData> GCLGLPAJGJJ);

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BENJMKAKOLG();
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class NLAGGMMKEKD<TData> : EKDFCINEFKL<MIMECACKOEL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly PGHFBLOPODG<TData> GCLGLPAJGJJ;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x3D245D0", Offset = "0x3D231D0", VA = "0x183D245D0")]
	public NLAGGMMKEKD(IEnumerable<TData> EPNFMOIFHJC, HCBALDOAEED EFLLOODPMDH, BHBFAPMEJPD ELHBBBNEEAK, float KFGMOBNNEDG, bool CBOCKKBECNF, MIMECACKOEL<TData> BHEBCLOMFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x34CBB90", Offset = "0x34CA790", VA = "0x1834CBB90", Slot = "4")]
	public override bool DHAKHJIICCG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public class AIHMPMAMMMB<TData> : EKDFCINEFKL<NICFCNNCNLA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly HPFMCDEMMKI<TData> GCLGLPAJGJJ;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x35F9370", Offset = "0x35F7F70", VA = "0x1835F9370")]
	public AIHMPMAMMMB(TData[] EPNFMOIFHJC, HCBALDOAEED[] EFLLOODPMDH, BHBFAPMEJPD[] ELHBBBNEEAK, float[] KFGMOBNNEDG, NICFCNNCNLA<TData> BHEBCLOMFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x35F91E0", Offset = "0x35F7DE0", VA = "0x1835F91E0", Slot = "4")]
	public override bool DHAKHJIICCG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class LPLPLFPJFHL<TData> : EKDFCINEFKL<BBNBBHGIBHH<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x314F920", Offset = "0x314E520", VA = "0x18314F920")]
	public LPLPLFPJFHL(BBNBBHGIBHH<TData> BHEBCLOMFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x3A96040", Offset = "0x3A94C40", VA = "0x183A96040", Slot = "4")]
	public override bool DHAKHJIICCG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class PLJOCAIPPLP<TData> : EKDFCINEFKL<BBNBBHGIBHH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly JLHNAIGFIAK<TData> GCLGLPAJGJJ;

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x3EAE200", Offset = "0x3EACE00", VA = "0x183EAE200")]
	public PLJOCAIPPLP(IEnumerable<TData> EPNFMOIFHJC, HCBALDOAEED EFLLOODPMDH, BHBFAPMEJPD ELHBBBNEEAK, float KFGMOBNNEDG, BBNBBHGIBHH<TData> BHEBCLOMFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x35F91E0", Offset = "0x35F7DE0", VA = "0x1835F91E0", Slot = "4")]
	public override bool DHAKHJIICCG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public struct PGHFBLOPODG<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public IEnumerable<TData> HBLAOCPDIOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public HCBALDOAEED CNEODCOCNAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public BHBFAPMEJPD EHABNMABMAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public float KFGMOBNNEDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public bool CBOCKKBECNF;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x3E9CCC0", Offset = "0x3E9B8C0", VA = "0x183E9CCC0")]
	public PGHFBLOPODG(IEnumerable<TData> EPNFMOIFHJC, HCBALDOAEED EFLLOODPMDH, BHBFAPMEJPD ELHBBBNEEAK, float KFGMOBNNEDG, bool CBOCKKBECNF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public struct HPFMCDEMMKI<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public TData[] HBLAOCPDIOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public HCBALDOAEED[] CNEODCOCNAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public BHBFAPMEJPD[] EHABNMABMAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public float[] KFGMOBNNEDG;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x36926F0", Offset = "0x36912F0", VA = "0x1836926F0")]
	public HPFMCDEMMKI(TData[] EPNFMOIFHJC, HCBALDOAEED[] EFLLOODPMDH, BHBFAPMEJPD[] ELHBBBNEEAK, float[] KFGMOBNNEDG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public struct JLHNAIGFIAK<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public IEnumerable<TData> HBLAOCPDIOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public HCBALDOAEED CNEODCOCNAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public BHBFAPMEJPD EHABNMABMAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public float KFGMOBNNEDG;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x391AC20", Offset = "0x3919820", VA = "0x18391AC20")]
	public JLHNAIGFIAK(IEnumerable<TData> EPNFMOIFHJC, HCBALDOAEED EFLLOODPMDH, BHBFAPMEJPD ELHBBBNEEAK, float KFGMOBNNEDG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface BDAHKACPOEH<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FKDBNJFGIFM([In] PJLFBACIMAL<TData> EACHCCCGOFC);

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IMHJIGENPGI([In] PJLFBACIMAL<TData> EACHCCCGOFC);

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EDDBJNCHCBP([In] bool CGMNDGACAGG);

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool AFEGNMIPAOM([In] PJLFBACIMAL<TData> EACHCCCGOFC);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LIHKICCFGHF();

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool AMBGFDGCAKM([In] TData GKHKKJAJKAG);
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class ALFAIKLJNOP<TData> : EKDFCINEFKL<BDAHKACPOEH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly PJLFBACIMAL<TData> EACHCCCGOFC;

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x371CF80", Offset = "0x371BB80", VA = "0x18371CF80")]
	public ALFAIKLJNOP(List<TData> OALAPCBMCII, BDAHKACPOEH<TData> BHEBCLOMFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x34CBB90", Offset = "0x34CA790", VA = "0x1834CBB90", Slot = "4")]
	public override bool DHAKHJIICCG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class AJGKGAMPONG<TData> : EKDFCINEFKL<BDAHKACPOEH<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x314F920", Offset = "0x314E520", VA = "0x18314F920")]
	public AJGKGAMPONG(BDAHKACPOEH<TData> BHEBCLOMFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x35FFD00", Offset = "0x35FE900", VA = "0x1835FFD00", Slot = "4")]
	public override bool DHAKHJIICCG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class FJFIKOADPHI<TData> : EKDFCINEFKL<BDAHKACPOEH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly bool CBOCKKBECNF;

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x34E34D0", Offset = "0x34E20D0", VA = "0x1834E34D0")]
	public FJFIKOADPHI(bool CBOCKKBECNF, BDAHKACPOEH<TData> BHEBCLOMFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x34E3470", Offset = "0x34E2070", VA = "0x1834E3470", Slot = "4")]
	public override bool DHAKHJIICCG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class KDIDOBBJODE<TData> : EKDFCINEFKL<BDAHKACPOEH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly PJLFBACIMAL<TData> EACHCCCGOFC;

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3976940", Offset = "0x3975540", VA = "0x183976940")]
	public KDIDOBBJODE(List<TData> OALAPCBMCII, bool CBOCKKBECNF, BDAHKACPOEH<TData> BHEBCLOMFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3976880", Offset = "0x3975480", VA = "0x183976880", Slot = "4")]
	public override bool DHAKHJIICCG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public class FIEFHFNKAIM<TData> : EKDFCINEFKL<BDAHKACPOEH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly TData GKHKKJAJKAG;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x34E2960", Offset = "0x34E1560", VA = "0x1834E2960")]
	public FIEFHFNKAIM(TData GKHKKJAJKAG, BDAHKACPOEH<TData> BHEBCLOMFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x34E2890", Offset = "0x34E1490", VA = "0x1834E2890", Slot = "4")]
	public override bool DHAKHJIICCG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class PJKPCGJILDD<TData> : EKDFCINEFKL<BDAHKACPOEH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly PJLFBACIMAL<TData> EACHCCCGOFC;

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3EAACF0", Offset = "0x3EA98F0", VA = "0x183EAACF0")]
	public PJKPCGJILDD(List<TData> OALAPCBMCII, BDAHKACPOEH<TData> BHEBCLOMFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3EAAC20", Offset = "0x3EA9820", VA = "0x183EAAC20", Slot = "4")]
	public override bool DHAKHJIICCG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public struct PJLFBACIMAL<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public IEnumerable<TData> HBLAOCPDIOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public bool CBOCKKBECNF;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3EAAE10", Offset = "0x3EA9A10", VA = "0x183EAAE10")]
	public PJLFBACIMAL(IEnumerable<TData> IJBGMCLMECD, bool AJHGAOMMMMJ = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface ANBABFKPFEL
{
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<EJMFPPCMLBF> DHAKHJIICCG(LCBNNGKFCFI CEBLDKDECKN);
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class HMAMIHGFJJP : BAFKNJKCDJE<ANBABFKPFEL, EJMFPPCMLBF>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private struct COHJLAJOAEF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public AsyncTaskMethodBuilder<EJMFPPCMLBF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public HMAMIHGFJJP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private TaskAwaiter<EJMFPPCMLBF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x5E3A960", Offset = "0x5E39560", VA = "0x185E3A960", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x5E3ABE0", Offset = "0x5E397E0", VA = "0x185E3ABE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly LCBNNGKFCFI LCHMIHOMCGN;

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5E3B010", Offset = "0x5E39C10", VA = "0x185E3B010")]
	public HMAMIHGFJJP(bool CBOCKKBECNF, ANBABFKPFEL BHEBCLOMFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5E3AF20", Offset = "0x5E39B20", VA = "0x185E3AF20", Slot = "4")]
	[AsyncStateMachine(typeof(COHJLAJOAEF))]
	public override Task<EJMFPPCMLBF> DHAKHJIICCG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public struct LCBNNGKFCFI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public bool MNAIFCPCDGK;

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0xBBFA70", Offset = "0xBBE670", VA = "0x180BBFA70")]
	public LCBNNGKFCFI(bool CBOCKKBECNF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface OHMCLGMHKGC<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NELOFGEKGFC([In] HIFBJGEDNDC<TData> PJPBHKBEKED);

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CLEFFOMOJLJ([In] DKFAKEMAGHM NHGNFOFDCGN);

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CLEFFOMOJLJ([In] DHGFEKMHKBN NHGNFOFDCGN);

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool BENJMKAKOLG();
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class NFKJDMBNKCJ<TData> : EKDFCINEFKL<OHMCLGMHKGC<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x314F920", Offset = "0x314E520", VA = "0x18314F920")]
	public NFKJDMBNKCJ(OHMCLGMHKGC<TData> BHEBCLOMFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3D14090", Offset = "0x3D12C90", VA = "0x183D14090", Slot = "4")]
	public override bool DHAKHJIICCG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class GGNGPOGCBBB<TData> : EKDFCINEFKL<OHMCLGMHKGC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly DKFAKEMAGHM ECJJBFILDCI;

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x35BAE70", Offset = "0x35B9A70", VA = "0x1835BAE70")]
	public GGNGPOGCBBB(Vector3 OOIDOCDKKDB, bool EPPDAPLCBAD, OHMCLGMHKGC<TData> BHEBCLOMFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x35BAE10", Offset = "0x35B9A10", VA = "0x1835BAE10", Slot = "4")]
	public override bool DHAKHJIICCG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class EIMIPLOLCEG<TData> : EKDFCINEFKL<OHMCLGMHKGC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly DHGFEKMHKBN ECJJBFILDCI;

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3179900", Offset = "0x3178500", VA = "0x183179900")]
	public EIMIPLOLCEG(Guid LFIHNDEGCBA, int DCGGFHOCGGH, Vector3 CFCLFCDKKPD, Quaternion HFKFMHAMLPE, float JBOECICKFAJ, bool EPPDAPLCBAD, OHMCLGMHKGC<TData> BHEBCLOMFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x31798A0", Offset = "0x31784A0", VA = "0x1831798A0", Slot = "4")]
	public override bool DHAKHJIICCG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class HOFDEFEDHEI<TData> : EKDFCINEFKL<OHMCLGMHKGC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly HIFBJGEDNDC<TData> ECJJBFILDCI;

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x368CE20", Offset = "0x368BA20", VA = "0x18368CE20")]
	public HOFDEFEDHEI(TData JIGKIEPHJOJ, bool CBOCKKBECNF, OHMCLGMHKGC<TData> BHEBCLOMFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x34CBB90", Offset = "0x34CA790", VA = "0x1834CBB90", Slot = "4")]
	public override bool DHAKHJIICCG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public struct DKFAKEMAGHM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly Vector3 OOIDOCDKKDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly bool EPPDAPLCBAD;

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x5E3AC90", Offset = "0x5E39890", VA = "0x185E3AC90")]
	public DKFAKEMAGHM(Vector3 OOIDOCDKKDB, bool EPPDAPLCBAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct DHGFEKMHKBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly Guid LFIHNDEGCBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly int DCGGFHOCGGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly Vector3 CFCLFCDKKPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly Quaternion HFKFMHAMLPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly float JBOECICKFAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly bool EPPDAPLCBAD;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x5E3AC50", Offset = "0x5E39850", VA = "0x185E3AC50")]
	public DHGFEKMHKBN(Guid LFIHNDEGCBA, int DCGGFHOCGGH, Vector3 CFCLFCDKKPD, Quaternion HFKFMHAMLPE, float JBOECICKFAJ, bool EPPDAPLCBAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public struct HIFBJGEDNDC<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly TData JIGKIEPHJOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly bool CBOCKKBECNF;

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x366B6B0", Offset = "0x366A2B0", VA = "0x18366B6B0")]
	public HIFBJGEDNDC(TData JIGKIEPHJOJ, bool CBOCKKBECNF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface APLKBNILHEO<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DHAKHJIICCG([In] AEDKEENIEJE<TData> FEEBOPHDIGH);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DHAKHJIICCG([In] MMFHHHONDDE<TData> FEEBOPHDIGH);
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public interface GICFGNAGDIL<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NELOFGEKGFC([In] BJPKHGKCDEO<TData> PPLMNDCJAIP);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CLEFFOMOJLJ([In] DEIDHJOCOEF NHGNFOFDCGN);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BENJMKAKOLG();
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class CGDHPDLICHP<TData> : EKDFCINEFKL<APLKBNILHEO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly AEDKEENIEJE<TData> FEEBOPHDIGH;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x496C3E0", Offset = "0x496AFE0", VA = "0x18496C3E0")]
	public CGDHPDLICHP(IEnumerable<TData> EPNFMOIFHJC, Vector3 HAKCGIJEKDL, bool CBOCKKBECNF, APLKBNILHEO<TData> BHEBCLOMFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x34CBB90", Offset = "0x34CA790", VA = "0x1834CBB90", Slot = "4")]
	public override bool DHAKHJIICCG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class EOBHKFOCLJL<TData> : EKDFCINEFKL<GICFGNAGDIL<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x314F920", Offset = "0x314E520", VA = "0x18314F920")]
	public EOBHKFOCLJL(GICFGNAGDIL<TData> BHEBCLOMFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x318CBC0", Offset = "0x318B7C0", VA = "0x18318CBC0", Slot = "4")]
	public override bool DHAKHJIICCG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class FDPBEMAAHOP<TData> : EKDFCINEFKL<GICFGNAGDIL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly BJPKHGKCDEO<TData> FEEBOPHDIGH;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x34CBCE0", Offset = "0x34CA8E0", VA = "0x1834CBCE0")]
	public FDPBEMAAHOP(IEnumerable<TData> EPNFMOIFHJC, bool CBOCKKBECNF, GICFGNAGDIL<TData> BHEBCLOMFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x34CBB90", Offset = "0x34CA790", VA = "0x1834CBB90", Slot = "4")]
	public override bool DHAKHJIICCG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class KCDGIJHDMPJ<TData> : EKDFCINEFKL<APLKBNILHEO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly MMFHHHONDDE<TData> FEEBOPHDIGH;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x396DDE0", Offset = "0x396C9E0", VA = "0x18396DDE0")]
	public KCDGIJHDMPJ(IEnumerable<TData> EPNFMOIFHJC, Vector3 OBFEJNDDHHI, EALOODNEBJA KEINHEAAHJM, bool CBOCKKBECNF, APLKBNILHEO<TData> BHEBCLOMFGA, Space EBAHEALPFCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3962490", Offset = "0x3961090", VA = "0x183962490", Slot = "4")]
	public override bool DHAKHJIICCG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class JEMBBGKDCLL<TData> : EKDFCINEFKL<GICFGNAGDIL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly DEIDHJOCOEF FEEBOPHDIGH;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x38EA860", Offset = "0x38E9460", VA = "0x1838EA860")]
	public JEMBBGKDCLL(Vector3 HAKCGIJEKDL, GICFGNAGDIL<TData> BHEBCLOMFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x35BAE10", Offset = "0x35B9A10", VA = "0x1835BAE10", Slot = "4")]
	public override bool DHAKHJIICCG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public struct AEDKEENIEJE<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public readonly IEnumerable<TData> EPNFMOIFHJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public readonly Vector3 HAKCGIJEKDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public readonly bool CBOCKKBECNF;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x3569200", Offset = "0x3567E00", VA = "0x183569200")]
	public AEDKEENIEJE(IEnumerable<TData> EPNFMOIFHJC, Vector3 HAKCGIJEKDL, bool CBOCKKBECNF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public struct BJPKHGKCDEO<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public readonly IEnumerable<TData> EPNFMOIFHJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly bool CBOCKKBECNF;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x459DF70", Offset = "0x459CB70", VA = "0x18459DF70")]
	public BJPKHGKCDEO(IEnumerable<TData> EPNFMOIFHJC, bool CBOCKKBECNF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public struct MMFHHHONDDE<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public readonly IEnumerable<TData> EPNFMOIFHJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public readonly Vector3 OBFEJNDDHHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public readonly EALOODNEBJA KEINHEAAHJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public readonly bool CBOCKKBECNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public readonly Space EBAHEALPFCB;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x3CB9240", Offset = "0x3CB7E40", VA = "0x183CB9240")]
	public MMFHHHONDDE(IEnumerable<TData> EPNFMOIFHJC, Vector3 OBFEJNDDHHI, EALOODNEBJA KEINHEAAHJM, bool CBOCKKBECNF, Space EBAHEALPFCB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public struct DEIDHJOCOEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public readonly Vector3 HAKCGIJEKDL;

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x2022070", Offset = "0x2020C70", VA = "0x182022070")]
	public DEIDHJOCOEF(Vector3 HAKCGIJEKDL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public enum EALOODNEBJA
{
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	XYZ,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	X_only,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	Y_only,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	Z_only
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public interface NOKLKELMANP<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DHAKHJIICCG([In] DBLNBNJKJKL<TData> LPEOPAHLPHJ);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DHAKHJIICCG([In] CHAKJPKJMHJ<TData> LPEOPAHLPHJ);
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public interface HANDFKEECNL<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NELOFGEKGFC([In] LOBFCGMHLDG<TData> PJPBHKBEKED);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CLEFFOMOJLJ([In] IMKGKECMMHB NHGNFOFDCGN);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BENJMKAKOLG();
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public class IHKEACBFNLJ<TData> : EKDFCINEFKL<NOKLKELMANP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly DBLNBNJKJKL<TData> LPEOPAHLPHJ;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x3736FF0", Offset = "0x3735BF0", VA = "0x183736FF0")]
	public IHKEACBFNLJ(IEnumerable<TData> EPNFMOIFHJC, Quaternion HAKCGIJEKDL, Vector3? PENLLPOHPJA, bool DDBFIDFDGDK, bool CBOCKKBECNF, NOKLKELMANP<TData> BHEBCLOMFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x34CBB90", Offset = "0x34CA790", VA = "0x1834CBB90", Slot = "4")]
	public override bool DHAKHJIICCG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class ICBBHPCCBHP<TData> : EKDFCINEFKL<HANDFKEECNL<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x314F920", Offset = "0x314E520", VA = "0x18314F920")]
	public ICBBHPCCBHP(HANDFKEECNL<TData> BHEBCLOMFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x318CBC0", Offset = "0x318B7C0", VA = "0x18318CBC0", Slot = "4")]
	public override bool DHAKHJIICCG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class CKJANKLIDMO<TData> : EKDFCINEFKL<HANDFKEECNL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly LOBFCGMHLDG<TData> LPEOPAHLPHJ;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x4C573C0", Offset = "0x4C55FC0", VA = "0x184C573C0")]
	public CKJANKLIDMO(IEnumerable<TData> EPNFMOIFHJC, bool CBOCKKBECNF, HANDFKEECNL<TData> BHEBCLOMFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x34CBB90", Offset = "0x34CA790", VA = "0x1834CBB90", Slot = "4")]
	public override bool DHAKHJIICCG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class KAAFEAJOEDI<TData> : EKDFCINEFKL<NOKLKELMANP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly CHAKJPKJMHJ<TData> LPEOPAHLPHJ;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x3962560", Offset = "0x3961160", VA = "0x183962560")]
	public KAAFEAJOEDI(IEnumerable<TData> EPNFMOIFHJC, Quaternion LDEEDGMDHIC, EALOODNEBJA FEOHCDCALHO, Vector3? PENLLPOHPJA, bool DDBFIDFDGDK, bool CBOCKKBECNF, Space EBAHEALPFCB, NOKLKELMANP<TData> BHEBCLOMFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x3962490", Offset = "0x3961090", VA = "0x183962490", Slot = "4")]
	public override bool DHAKHJIICCG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class KMLPEGGCFHD<TData> : EKDFCINEFKL<HANDFKEECNL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly IMKGKECMMHB LPEOPAHLPHJ;

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x39955F0", Offset = "0x39941F0", VA = "0x1839955F0")]
	public KMLPEGGCFHD(Quaternion HAKCGIJEKDL, Vector3? PENLLPOHPJA, bool DDBFIDFDGDK, HANDFKEECNL<TData> BHEBCLOMFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x35BAE10", Offset = "0x35B9A10", VA = "0x1835BAE10", Slot = "4")]
	public override bool DHAKHJIICCG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public struct DBLNBNJKJKL<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public readonly IEnumerable<TData> EPNFMOIFHJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public readonly Quaternion HAKCGIJEKDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public readonly Vector3? PENLLPOHPJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public readonly bool DDBFIDFDGDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public readonly bool CBOCKKBECNF;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x4DE6350", Offset = "0x4DE4F50", VA = "0x184DE6350")]
	public DBLNBNJKJKL(IEnumerable<TData> EPNFMOIFHJC, Quaternion HAKCGIJEKDL, Vector3? PENLLPOHPJA, bool DDBFIDFDGDK, bool CBOCKKBECNF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct LOBFCGMHLDG<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly IEnumerable<TData> EPNFMOIFHJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public readonly bool CBOCKKBECNF;

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x3A8B770", Offset = "0x3A8A370", VA = "0x183A8B770")]
	public LOBFCGMHLDG(IEnumerable<TData> EPNFMOIFHJC, bool CBOCKKBECNF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct CHAKJPKJMHJ<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly IEnumerable<TData> EPNFMOIFHJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public readonly Quaternion LDEEDGMDHIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public readonly EALOODNEBJA FEOHCDCALHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public readonly Vector3? PENLLPOHPJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public readonly bool DDBFIDFDGDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public readonly bool CBOCKKBECNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public readonly Space EBAHEALPFCB;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x4A35E00", Offset = "0x4A34A00", VA = "0x184A35E00")]
	public CHAKJPKJMHJ(IEnumerable<TData> EPNFMOIFHJC, Quaternion LDEEDGMDHIC, EALOODNEBJA FEOHCDCALHO, Vector3? PENLLPOHPJA, bool DDBFIDFDGDK, bool CBOCKKBECNF, Space EBAHEALPFCB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct IMKGKECMMHB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public readonly Quaternion HAKCGIJEKDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public readonly Vector3? PENLLPOHPJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public readonly bool DDBFIDFDGDK;

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x43593B0", Offset = "0x4357FB0", VA = "0x1843593B0")]
	public IMKGKECMMHB(Quaternion HAKCGIJEKDL, Vector3? PENLLPOHPJA, bool DDBFIDFDGDK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public interface AMICDIOPOLG<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NELOFGEKGFC([In] FCPJAOGFNMJ<TData> PJPBHKBEKED);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CLEFFOMOJLJ([In] OMPPHGALFNH NHGNFOFDCGN);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CLEFFOMOJLJ([In] OFGKELCJNOA NHGNFOFDCGN);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CLEFFOMOJLJ([In] HGKHCPKNLDB NHGNFOFDCGN);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool BENJMKAKOLG();
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public class LIFIFIBEGJI<TData> : EKDFCINEFKL<AMICDIOPOLG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly HGKHCPKNLDB JAOJICCKBDA;

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3A40B40", Offset = "0x3A3F740", VA = "0x183A40B40")]
	public LIFIFIBEGJI(Vector3 PNMMMNMJHCI, float MFAAODEGFEP, Vector3 PENLLPOHPJA, bool CPKADOPLGCD, bool ENHODKIEDCB, AMICDIOPOLG<TData> BHEBCLOMFGA, Space EBAHEALPFCB = Space.Self)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x3A40AE0", Offset = "0x3A3F6E0", VA = "0x183A40AE0", Slot = "4")]
	public override bool DHAKHJIICCG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public class KBNHDPKLKBE<TData> : EKDFCINEFKL<AMICDIOPOLG<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x314F920", Offset = "0x314E520", VA = "0x18314F920")]
	public KBNHDPKLKBE(AMICDIOPOLG<TData> BHEBCLOMFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x396D180", Offset = "0x396BD80", VA = "0x18396D180", Slot = "4")]
	public override bool DHAKHJIICCG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public class JJHFADBILMP<TData> : EKDFCINEFKL<AMICDIOPOLG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly FCPJAOGFNMJ<TData> JAOJICCKBDA;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x3913C60", Offset = "0x3912860", VA = "0x183913C60")]
	public JJHFADBILMP(IEnumerable<TData> EPNFMOIFHJC, bool CBOCKKBECNF, AMICDIOPOLG<TData> BHEBCLOMFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x34CBB90", Offset = "0x34CA790", VA = "0x1834CBB90", Slot = "4")]
	public override bool DHAKHJIICCG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class HBIPHBOIKIL<TData> : EKDFCINEFKL<AMICDIOPOLG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly OFGKELCJNOA JAOJICCKBDA;

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x3620D10", Offset = "0x361F910", VA = "0x183620D10")]
	public HBIPHBOIKIL(float KDJDNNNJDBP, bool GNNNPPDANJP, Vector3 PENLLPOHPJA, AMICDIOPOLG<TData> BHEBCLOMFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x3620C40", Offset = "0x361F840", VA = "0x183620C40", Slot = "4")]
	public override bool DHAKHJIICCG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public class CNANEFGPLFL<TData> : EKDFCINEFKL<AMICDIOPOLG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly OMPPHGALFNH JAOJICCKBDA;

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x4C73040", Offset = "0x4C71C40", VA = "0x184C73040")]
	public CNANEFGPLFL(float MFAAODEGFEP, Vector3 PENLLPOHPJA, AMICDIOPOLG<TData> BHEBCLOMFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x35BAE10", Offset = "0x35B9A10", VA = "0x1835BAE10", Slot = "4")]
	public override bool DHAKHJIICCG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct HGKHCPKNLDB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public readonly Vector3 PNMMMNMJHCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public readonly float MFAAODEGFEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public readonly Vector3 PENLLPOHPJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public readonly bool EPPDAPLCBAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public readonly Space EBAHEALPFCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly bool ENHODKIEDCB;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x5E3AEE0", Offset = "0x5E39AE0", VA = "0x185E3AEE0")]
	public HGKHCPKNLDB(Vector3 PNMMMNMJHCI, float MFAAODEGFEP, Vector3 PENLLPOHPJA, bool EPPDAPLCBAD, bool KLMPBHLNMCF, Space EBAHEALPFCB = Space.Self)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public struct FCPJAOGFNMJ<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public readonly IEnumerable<TData> EPNFMOIFHJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public readonly bool CBOCKKBECNF;

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x34CA470", Offset = "0x34C9070", VA = "0x1834CA470")]
	public FCPJAOGFNMJ(IEnumerable<TData> EPNFMOIFHJC, bool CBOCKKBECNF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public struct OFGKELCJNOA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public readonly float KDJDNNNJDBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public readonly bool GNNNPPDANJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public readonly Vector3 PENLLPOHPJA;

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x5E3B0F0", Offset = "0x5E39CF0", VA = "0x185E3B0F0")]
	public OFGKELCJNOA(float KDJDNNNJDBP, bool GNNNPPDANJP, Vector3 PENLLPOHPJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct OMPPHGALFNH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public readonly float MFAAODEGFEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public readonly Vector3 PENLLPOHPJA;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x43318B0", Offset = "0x43304B0", VA = "0x1843318B0")]
	public OMPPHGALFNH(float MFAAODEGFEP, Vector3 PENLLPOHPJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public static class PHHAPJDMDNL
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	private struct PJECOJHNPDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public bool FAPPMPKOGLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public OKOCNPPIKGG PKDGHBNAHKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public OKOCNPPIKGG EEGNDJMCGLD;
	}

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private static PJECOJHNPDH AFIFCDFCAME;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static CancellationToken FEFKHFILIEO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x5E3B420", Offset = "0x5E3A020", VA = "0x185E3B420")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	internal static OKOCNPPIKGG PKDGHBNAHKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x5E3B440", Offset = "0x5E3A040", VA = "0x185E3B440")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x5E3B360", Offset = "0x5E39F60", VA = "0x185E3B360")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5E3B110", Offset = "0x5E39D10", VA = "0x185E3B110")]
	[GFMBCOBENIN(MGPIABHDDAF.Room, CDPNEOMLNDL.None)]
	private static void BCNNFLKPKKL(OKOCNPPIKGG JGCNIKJHBLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5E3B210", Offset = "0x5E39E10", VA = "0x185E3B210")]
	public static void GPJBDIFOFCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x5E3B3D0", Offset = "0x5E39FD0", VA = "0x185E3B3D0")]
	private static OKOCNPPIKGG LMAKPKLLHID(OKOCNPPIKGG LCEIFJPLPAL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public static class ALMJLPIPIBD
{
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public enum FDOKILFNEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		ICreationContextObject,
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		Guid
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x2B1D7D0", Offset = "0x2B1C3D0", VA = "0x182B1D7D0")]
	public static void BFKPNFJIDCN<T>(T BJMIJNLECJK, FDOKILFNEKJ OMKEAAPIABA) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x2B1D910", Offset = "0x2B1C510", VA = "0x182B1D910")]
	public static void BFKPNFJIDCN<T>(T BJMIJNLECJK) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x2B1DA50", Offset = "0x2B1C650", VA = "0x182B1DA50")]
	public static void IAHLIIJPEMF<T>(T BJMIJNLECJK) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x2B1DAC0", Offset = "0x2B1C6C0", VA = "0x182B1DAC0")]
	public static T IOOJPMIEEDI<T>(FDOKILFNEKJ OMKEAAPIABA) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x2B1D970", Offset = "0x2B1C570", VA = "0x182B1D970")]
	public static bool CMPKPHKKMMI<T>(FDOKILFNEKJ OMKEAAPIABA) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x2B1DA10", Offset = "0x2B1C610", VA = "0x182B1DA10")]
	public static T IOOJPMIEEDI<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x2B1DA10", Offset = "0x2B1C610", VA = "0x182B1DA10")]
	public static bool CMPKPHKKMMI<T>() where T : class
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
internal static class EGEMOCEOJOG
{
	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x5E3ACB0", Offset = "0x5E398B0", VA = "0x185E3ACB0")]
	public static void EHLOEALOKOD(IEnumerable KDFNJKLNPNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x23CE240", Offset = "0x23CCE40", VA = "0x1823CE240")]
	public static void EHLOEALOKOD<T>(T[] DAJPKFPFPMI) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x23CE330", Offset = "0x23CCF30", VA = "0x1823CE330")]
	public static void EHLOEALOKOD<T>(T DACFGCGDCAC) where T : notnull, Enum
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
