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
		[Cpp2IlInjected.Address(RVA = "0x7DEA50", Offset = "0x7DDC50", VA = "0x1807DEA50")]
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
		[Cpp2IlInjected.Address(RVA = "0x6170BB0", Offset = "0x616FDB0", VA = "0x186170BB0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7DED90", Offset = "0x7DDF90", VA = "0x1807DED90")]
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
		[Cpp2IlInjected.Address(RVA = "0x7DEDD0", Offset = "0x7DDFD0", VA = "0x1807DEDD0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface EAPBADNEMFD<TData, TReturn>
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TReturn HPNKIELCDCC(TData GLMGCMELGFD);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface LLHMHBGNCJA<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ClearHoverTarget(CDAILGBJIGB IOFHHOOFNLB);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool SetHoverTarget(TData JGFCAMDGBLE, Collider PMGLOFIJLLH, CDAILGBJIGB IOFHHOOFNLB, [Optional] NJFLAEHPIGP? IMIKDBHLPBK);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool TryGetHoverTarget([Out] TData JGFCAMDGBLE);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetHoverCollider([Out] Collider PMGLOFIJLLH);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface OMLLHBFIAML<TData> : KGDLBKPKNMK, CIBEJDBGJGA<TData>, BJDMPMAAMGE<TData>, MJLLOFPPJOO<TData>, IILAJOOPKJG, MIHIFKGCKMF<TData>, KAGBCPPGFOB, FMKFNIIDJDF
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface MIHIFKGCKMF<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 BNOKKIEBDEJ, Vector3 HIMAANDEJKI, float NHMHEGFGMMF, [Out] T CJHCPEDEHCD, [Out] Vector3 JIDIGMFEPAA, [Out] Collider PMGLOFIJLLH);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 BNOKKIEBDEJ, Vector3 HIMAANDEJKI, float MNBGEFCAPPH, float NHMHEGFGMMF, T[] AAILCCNOBPL, [Out] Vector3 NPABLDNDKEI, [Out] Collider DJALNMIKILJ);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 BNOKKIEBDEJ, float MNBGEFCAPPH, Vector3 EKLKLKONIOE, T[] AAILCCNOBPL);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetObjectFromColliderInCurrentScope(Collider IGKJJBGCJAA, [Out] T GEBAJIMFIEO);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface KGDLBKPKNMK
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Bounds COMPMEEJAJA
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Transform KHEDOAHLBMK
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Bounds IAHPHOMLGMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Transform BJKOABMNIEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Vector3 LKIIDMNBEIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool KJHBPKOGFDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void SetSelectionBoundsDirty(bool LGFDPCFIJDP = true, int KEJOLBIECHC = 0);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ShouldHideSelectionBoundsPreview(bool HBFNKNPHGNB, object GMMJMENGHCD);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface FMKFNIIDJDF
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	DPAIEAIPOBP GLFEOLMNDBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface EOMEONFKDNM
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool DCDFOKMDDCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool BJKINMMANMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool PILABKBELAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Dictionary<Guid, Guid> TryGetPreviousCloneMapping();

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void TrySetPreviousCloneMapping(Dictionary<Guid, Guid> EPAHKHACKIP);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface MJLLOFPPJOO<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool PGIMADCEAKG
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int JJIBEGJPAFB
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<TData> PIBJFDMBHJN
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData KBNEJAIFICP);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData KBNEJAIFICP);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface CIBEJDBGJGA<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T GLMGCMELGFD, [Optional] NJFLAEHPIGP? NBINPNLDMFM, bool PAIGIKEGFND = true);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int KMJOEPJMADC, IEnumerable<T> HDHGOBOIDNG, bool PAIGIKEGFND = true);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int KMJOEPJMADC, IEnumerable<T> HDHGOBOIDNG, NJFLAEHPIGP NBINPNLDMFM, bool PAIGIKEGFND = true);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface KAGBCPPGFOB
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface IILAJOOPKJG
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool GCPDDIEDLJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool DFAPEAHELFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool DGMCDCIFKLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool IGMPNIDBJEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class HNHNDOBBMPF<TReceiver> : ABGAHKJELHF<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3400FA0", Offset = "0x34001A0", VA = "0x183400FA0")]
	public HNHNDOBBMPF(TReceiver INAHCHDLNPA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class GPMIJNPHHEG<TReceiver, TFromTask> : ABGAHKJELHF<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3400FA0", Offset = "0x34001A0", VA = "0x183400FA0")]
	public GPMIJNPHHEG(TReceiver INAHCHDLNPA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public abstract class ABGAHKJELHF<TReceiver, TFromExecute> where TReceiver : notnull where TFromExecute : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	protected TReceiver INAHCHDLNPA;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3832D80", Offset = "0x3831F80", VA = "0x183832D80")]
	public ABGAHKJELHF(TReceiver INAHCHDLNPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute GNDGKBBHPCI();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public abstract class NGFGKLHJBKD<TReceiver, TResult> : ABGAHKJELHF<TReceiver, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3400FA0", Offset = "0x34001A0", VA = "0x183400FA0")]
	public NGFGKLHJBKD(TReceiver INAHCHDLNPA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct AKPLIMPOOMJ<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public TGroup FGHILOIHNBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public TData OCPCBJPDLIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public IEnumerable<TData> IEJEJLFKEOO;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1B34B80", Offset = "0x1B33D80", VA = "0x181B34B80")]
	public AKPLIMPOOMJ(TGroup HBNKLMINKGI, TData PFIGCOEEHJO, IEnumerable<TData> LGHFGMAEMIL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct KEOJJINAHBL<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public TGroup FGHILOIHNBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public IEnumerable<TData> IEJEJLFKEOO;

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x90BB40", Offset = "0x90AD40", VA = "0x18090BB40")]
	public KEOJJINAHBL(TGroup HBNKLMINKGI, IEnumerable<TData> LGHFGMAEMIL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct BFINMGGMECB<TGroup> where TGroup : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public TGroup FGHILOIHNBO;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x93E850", Offset = "0x93DA50", VA = "0x18093E850")]
	public BFINMGGMECB(TGroup HBNKLMINKGI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct BIKJNKPEHKB<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public IEnumerable<TData> IEJEJLFKEOO;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x93E850", Offset = "0x93DA50", VA = "0x18093E850")]
	public BIKJNKPEHKB(IEnumerable<TData> LGHFGMAEMIL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface PNHPMNEBMLM<TGroup, TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OLALPPDDFPO KGHGEEDINPG(AKPLIMPOOMJ<TGroup, TData> BIJKGLAJIML);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OLALPPDDFPO FNHOLIBACCE(AKPLIMPOOMJ<TGroup, TData> BIJKGLAJIML);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "2")]
	OLALPPDDFPO HAGNECCJNMB(KEOJJINAHBL<TGroup, TData> BIJKGLAJIML);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "3")]
	OLALPPDDFPO LCHNFPKIKJN(BFINMGGMECB<TGroup> BIJKGLAJIML);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface GLOIKIPBKIO<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<OLALPPDDFPO> KGHGEEDINPG(BIKJNKPEHKB<TData> BIJKGLAJIML);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class FGJLODCAMHE<TGroup, TData> : NGFGKLHJBKD<PNHPMNEBMLM<TGroup, TData>, OLALPPDDFPO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly KEOJJINAHBL<TGroup, TData> BIJKGLAJIML;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x377AB30", Offset = "0x3779D30", VA = "0x18377AB30")]
	public FGJLODCAMHE(TGroup HBNKLMINKGI, IEnumerable<TData> LGHFGMAEMIL, PNHPMNEBMLM<TGroup, TData> INAHCHDLNPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x377AA70", Offset = "0x3779C70", VA = "0x18377AA70", Slot = "4")]
	public override OLALPPDDFPO GNDGKBBHPCI()
	{
		return default(OLALPPDDFPO);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class PGOKIOJCAJN<TGroup, TData> : NGFGKLHJBKD<PNHPMNEBMLM<TGroup, TData>, OLALPPDDFPO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly AKPLIMPOOMJ<TGroup, TData> BIJKGLAJIML;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3945200", Offset = "0x3944400", VA = "0x183945200")]
	public PGOKIOJCAJN(TGroup HBNKLMINKGI, TData BAPJBBPBNBG, IEnumerable<TData> LGHFGMAEMIL, PNHPMNEBMLM<TGroup, TData> INAHCHDLNPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x41A93E0", Offset = "0x41A85E0", VA = "0x1841A93E0", Slot = "4")]
	public override OLALPPDDFPO GNDGKBBHPCI()
	{
		return default(OLALPPDDFPO);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class JECCNKFKIDO<TGroup, TData> : NGFGKLHJBKD<PNHPMNEBMLM<TGroup, TData>, OLALPPDDFPO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly BFINMGGMECB<TGroup> BIJKGLAJIML;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3BED230", Offset = "0x3BEC430", VA = "0x183BED230")]
	public JECCNKFKIDO(TGroup HBNKLMINKGI, PNHPMNEBMLM<TGroup, TData> INAHCHDLNPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3BED170", Offset = "0x3BEC370", VA = "0x183BED170", Slot = "4")]
	public override OLALPPDDFPO GNDGKBBHPCI()
	{
		return default(OLALPPDDFPO);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class HDHMKGGKKDC<TGroup, TData> : NGFGKLHJBKD<PNHPMNEBMLM<TGroup, TData>, OLALPPDDFPO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly AKPLIMPOOMJ<TGroup, TData> BIJKGLAJIML;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3945200", Offset = "0x3944400", VA = "0x183945200")]
	public HDHMKGGKKDC(TGroup HBNKLMINKGI, TData PFIGCOEEHJO, IEnumerable<TData> LGHFGMAEMIL, PNHPMNEBMLM<TGroup, TData> INAHCHDLNPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3945120", Offset = "0x3944320", VA = "0x183945120", Slot = "4")]
	public override OLALPPDDFPO GNDGKBBHPCI()
	{
		return default(OLALPPDDFPO);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class OEBLIMEODMN<TData> : GPMIJNPHHEG<GLOIKIPBKIO<TData>, OLALPPDDFPO> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private struct ILKKEHGPGJL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AsyncTaskMethodBuilder<OLALPPDDFPO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public OEBLIMEODMN<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private TaskAwaiter<OLALPPDDFPO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x3A4E730", Offset = "0x3A4D930", VA = "0x183A4E730", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3A4E9D0", Offset = "0x3A4DBD0", VA = "0x183A4E9D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private BIKJNKPEHKB<TData> BIJKGLAJIML;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3BED230", Offset = "0x3BEC430", VA = "0x183BED230")]
	public OEBLIMEODMN(IEnumerable<TData> MEEHIIHHFGA, GLOIKIPBKIO<TData> INAHCHDLNPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x40F1840", Offset = "0x40F0A40", VA = "0x1840F1840", Slot = "4")]
	[AsyncStateMachine(typeof(OEBLIMEODMN<>.ILKKEHGPGJL))]
	public override Task<OLALPPDDFPO> GNDGKBBHPCI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct AMMACNOFJAI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly HGJLMMMNHFO NNCIEHNFPAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly bool GJIOMHKLCIN;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x616F850", Offset = "0x616EA50", VA = "0x18616F850")]
	public AMMACNOFJAI(HGJLMMMNHFO DMNEHKOGBFN, bool CPCHOJDPJNK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface LMDCDFEOABI<TSpawnType> where TSpawnType : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> GNDGKBBHPCI(AMMACNOFJAI FHPFLNCCJLL);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class IHHMGBAEMLN<TSpawnType> : GPMIJNPHHEG<LMDCDFEOABI<TSpawnType>, TSpawnType> where TSpawnType : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private struct HCLBEKCACJP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public AsyncTaskMethodBuilder<TSpawnType> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public IHHMGBAEMLN<TSpawnType> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskAwaiter<TSpawnType> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x3944360", Offset = "0x3943560", VA = "0x183944360", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x39446F0", Offset = "0x39438F0", VA = "0x1839446F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly AMMACNOFJAI FHPFLNCCJLL;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3A456B0", Offset = "0x3A448B0", VA = "0x183A456B0")]
	public IHHMGBAEMLN(HGJLMMMNHFO DMNEHKOGBFN, bool CPCHOJDPJNK, LMDCDFEOABI<TSpawnType> INAHCHDLNPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3A455C0", Offset = "0x3A447C0", VA = "0x183A455C0", Slot = "4")]
	[AsyncStateMachine(typeof(IHHMGBAEMLN<>.HCLBEKCACJP))]
	public override Task<TSpawnType> GNDGKBBHPCI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public readonly struct HGJLMMMNHFO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly bool GCKCLPCDCHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly Vector3 NIACMFOKBJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly Vector3 BKEJMFAHMFG;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x616FBD0", Offset = "0x616EDD0", VA = "0x18616FBD0")]
	public HGJLMMMNHFO(Transform HPNBHMPBEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x616FB20", Offset = "0x616ED20", VA = "0x18616FB20")]
	public HGJLMMMNHFO(Vector3 KBHLNPNINOC, Vector3 JCMPCLFLJHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x616FAF0", Offset = "0x616ECF0", VA = "0x18616FAF0")]
	public static HGJLMMMNHFO OALMEMACFAC()
	{
		return default(HGJLMMMNHFO);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x616FB50", Offset = "0x616ED50", VA = "0x18616FB50")]
	private HGJLMMMNHFO(bool PPIPALAADID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct PEGHLJADOJH<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public TNode IMJLNPGOAPB;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x41A2E10", Offset = "0x41A2010", VA = "0x1841A2E10")]
	public PEGHLJADOJH(TNode IMJLNPGOAPB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct CAJMAHMFCDO<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public TNode ACMCHNJIAMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public LPPIADKCKMK NHNDPLINGBN;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x4926330", Offset = "0x4925530", VA = "0x184926330")]
	public CAJMAHMFCDO(TNode ACMCHNJIAMG, LPPIADKCKMK NHNDPLINGBN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface LGJOMMAEHJM<TNode>
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PGDJLHBBBDL([In] PEGHLJADOJH<TNode> LGNOPBEPMKC);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CLAFBOMKDCA([In] CAJMAHMFCDO<TNode> BMCPCENFINE);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LIPIPHJGIBF();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class LCFELKNOFFB<TNode> : HNHNDOBBMPF<LGJOMMAEHJM<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3400FA0", Offset = "0x34001A0", VA = "0x183400FA0")]
	public LCFELKNOFFB(LGJOMMAEHJM<TNode> INAHCHDLNPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3A5D2C0", Offset = "0x3A5C4C0", VA = "0x183A5D2C0", Slot = "4")]
	public override bool GNDGKBBHPCI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class ILHGFNHAKOF<TNode> : HNHNDOBBMPF<LGJOMMAEHJM<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly CAJMAHMFCDO<TNode> BMCPCENFINE;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3A4E6A0", Offset = "0x3A4D8A0", VA = "0x183A4E6A0")]
	public ILHGFNHAKOF(TNode ACMCHNJIAMG, LPPIADKCKMK NHNDPLINGBN, LGJOMMAEHJM<TNode> INAHCHDLNPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x37C8670", Offset = "0x37C7870", VA = "0x1837C8670", Slot = "4")]
	public override bool GNDGKBBHPCI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class NEEMKEMHJHC<TNode> : HNHNDOBBMPF<LGJOMMAEHJM<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly PEGHLJADOJH<TNode> LGNOPBEPMKC;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3FC8C90", Offset = "0x3FC7E90", VA = "0x183FC8C90")]
	public NEEMKEMHJHC(TNode LEABLLPKOMM, LGJOMMAEHJM<TNode> INAHCHDLNPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3863BF0", Offset = "0x3862DF0", VA = "0x183863BF0", Slot = "4")]
	public override bool GNDGKBBHPCI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct EJGOHDIMPLJ<TSpawnInfo> where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public TSpawnInfo CABPFMCOGKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public Vector3 JCMPCLFLJHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public Quaternion ECLCOOPOABI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public float OFBFBKPELML;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3429200", Offset = "0x3428400", VA = "0x183429200")]
	public EJGOHDIMPLJ(TSpawnInfo CABPFMCOGKP, Vector3 JCMPCLFLJHD, Quaternion ECLCOOPOABI, float OFBFBKPELML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface IDPKALPKAEE<TSpawnType, TSpawnInfo>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> JHAJJAIGKOK([In] EJGOHDIMPLJ<TSpawnInfo> JOIMOJKGIFD, CancellationToken IOOGCHJMBIE);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class PKCIIHPKIJL<TSpawnType, TSpawnInfo> : GPMIJNPHHEG<IDPKALPKAEE<TSpawnType, TSpawnInfo>, TSpawnType> where TSpawnType : notnull where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly EJGOHDIMPLJ<TSpawnInfo> FJIDAJDLPID;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x41B8AA0", Offset = "0x41B7CA0", VA = "0x1841B8AA0")]
	public PKCIIHPKIJL(TSpawnInfo GECLEKIOMFI, Vector3 JCMPCLFLJHD, Quaternion ECLCOOPOABI, float OFBFBKPELML, IDPKALPKAEE<TSpawnType, TSpawnInfo> INAHCHDLNPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3D61F50", Offset = "0x3D61150", VA = "0x183D61F50", Slot = "4")]
	public override Task<TSpawnType> GNDGKBBHPCI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct KDPIBDENJJB<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly IEnumerable<TData> IEJEJLFKEOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly bool GJIOMHKLCIN;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x3CAAEE0", Offset = "0x3CAA0E0", VA = "0x183CAAEE0")]
	public KDPIBDENJJB(IEnumerable<TData> LGHFGMAEMIL, bool CPCHOJDPJNK = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface IDOGJCFDJOD<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<OLALPPDDFPO> APDFPFAKFCM([In] KDPIBDENJJB<TData> PAFHNGHNABO, CancellationToken IOOGCHJMBIE);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class LIMLIFPAHIH<TData> : GPMIJNPHHEG<IDOGJCFDJOD<TData>, OLALPPDDFPO> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly KDPIBDENJJB<TData> BMDCFICONNA;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3D62030", Offset = "0x3D61230", VA = "0x183D62030")]
	public LIMLIFPAHIH(IEnumerable<TData> LGHFGMAEMIL, bool CPCHOJDPJNK, IDOGJCFDJOD<TData> INAHCHDLNPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3D61F50", Offset = "0x3D61150", VA = "0x183D61F50", Slot = "4")]
	public override Task<OLALPPDDFPO> GNDGKBBHPCI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct DOJNFCLPELH<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly T JGFCAMDGBLE;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x37BF810", Offset = "0x37BEA10", VA = "0x1837BF810")]
	public DOJNFCLPELH(T HNBMEHFPBGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface NPJIMGAOMND<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PGDJLHBBBDL([In] DOJNFCLPELH<T> CFLBENENODK);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CLAFBOMKDCA();
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface LJFMBCGGDLG<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GNDGKBBHPCI([In] AGIPAGAHCJN<T> JBAKKDGAGJF);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct AGIPAGAHCJN<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public readonly T JGFCAMDGBLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public readonly bool EFCCJJHAHDP;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x38AC040", Offset = "0x38AB240", VA = "0x1838AC040")]
	public AGIPAGAHCJN(T HNBMEHFPBGJ, bool ONACHNCDDCD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class HLHAOPPKIEO<T> : HNHNDOBBMPF<NPJIMGAOMND<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x3400FA0", Offset = "0x34001A0", VA = "0x183400FA0")]
	public HLHAOPPKIEO(NPJIMGAOMND<T> INAHCHDLNPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x397BE80", Offset = "0x397B080", VA = "0x18397BE80", Slot = "4")]
	public override bool GNDGKBBHPCI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class BAAJJFNALHN<T> : HNHNDOBBMPF<NPJIMGAOMND<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly DOJNFCLPELH<T> CFLBENENODK;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x47A7AE0", Offset = "0x47A6CE0", VA = "0x1847A7AE0")]
	public BAAJJFNALHN(T JGFCAMDGBLE, NPJIMGAOMND<T> INAHCHDLNPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x3863BF0", Offset = "0x3862DF0", VA = "0x183863BF0", Slot = "4")]
	public override bool GNDGKBBHPCI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class CJHBDHGMKGB<T> : HNHNDOBBMPF<LJFMBCGGDLG<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly AGIPAGAHCJN<T> JBAKKDGAGJF;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x4A22A20", Offset = "0x4A21C20", VA = "0x184A22A20")]
	public CJHBDHGMKGB(T JGFCAMDGBLE, bool ONACHNCDDCD, LJFMBCGGDLG<T> INAHCHDLNPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x3863BF0", Offset = "0x3862DF0", VA = "0x183863BF0", Slot = "4")]
	public override bool GNDGKBBHPCI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct JGNHEDCMDMB<TData> where TData : notnull, FKOKJJENDEG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public IEnumerable<TData> IEJEJLFKEOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public bool IICPIGMLNDH;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x3BFE8E0", Offset = "0x3BFDAE0", VA = "0x183BFE8E0")]
	public JGNHEDCMDMB(IEnumerable<TData> BKIKHFHHKEJ, bool FILBCEJHOGI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct HDADHOFHGPD<TData> where TData : notnull, FKOKJJENDEG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public List<TData> IEJEJLFKEOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public List<bool> KGICMDAFFKL;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x3944780", Offset = "0x3943980", VA = "0x183944780")]
	public HDADHOFHGPD(List<TData> BKIKHFHHKEJ, List<bool> JMGPKLAAPGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface FKOKJJENDEG
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool KOBIKAIIBOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface DKKIKGGDJIE<TData> where TData : FKOKJJENDEG
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GNDGKBBHPCI([In] JGNHEDCMDMB<TData> IFGCGNNGDCJ);

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GNDGKBBHPCI([In] HDADHOFHGPD<TData> IFGCGNNGDCJ);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface JOJDKBGLKOL<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NCNBDMEMCGI(T JGFCAMDGBLE);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class LICDCCIFNGI<TData> : HNHNDOBBMPF<DKKIKGGDJIE<TData>> where TData : notnull, FKOKJJENDEG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly JGNHEDCMDMB<TData> IFGCGNNGDCJ;

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x3D5F8A0", Offset = "0x3D5EAA0", VA = "0x183D5F8A0")]
	public LICDCCIFNGI(List<TData> LGHFGMAEMIL, bool IICPIGMLNDH, DKKIKGGDJIE<TData> INAHCHDLNPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x3863BF0", Offset = "0x3862DF0", VA = "0x183863BF0", Slot = "4")]
	public override bool GNDGKBBHPCI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class HKGLJAJEGPK<TData> : HNHNDOBBMPF<DKKIKGGDJIE<TData>> where TData : notnull, FKOKJJENDEG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly HDADHOFHGPD<TData> IFGCGNNGDCJ;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x39752C0", Offset = "0x39744C0", VA = "0x1839752C0")]
	public HKGLJAJEGPK(List<TData> LGHFGMAEMIL, List<bool> KGICMDAFFKL, DKKIKGGDJIE<TData> INAHCHDLNPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x3975200", Offset = "0x3974400", VA = "0x183975200", Slot = "4")]
	public override bool GNDGKBBHPCI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface GIGFJNDDJKB<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<OLALPPDDFPO> GNDGKBBHPCI(MFNLFBHPEDF<TData> PBFMAJIFILN);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public class MMCHHEJEDJH<TData> : GPMIJNPHHEG<GIGFJNDDJKB<TData>, OLALPPDDFPO> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct NEBMHFLBHNO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public AsyncTaskMethodBuilder<OLALPPDDFPO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public MMCHHEJEDJH<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<OLALPPDDFPO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x3FC88E0", Offset = "0x3FC7AE0", VA = "0x183FC88E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x3FC8BC0", Offset = "0x3FC7DC0", VA = "0x183FC8BC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly MFNLFBHPEDF<TData> EECMJFFIIMB;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x3F45E10", Offset = "0x3F45010", VA = "0x183F45E10")]
	public MMCHHEJEDJH(TData ICKBELEKNFH, IReadOnlyList<TData> IBBBHIMMIDI, bool CPCHOJDPJNK, GIGFJNDDJKB<TData> INAHCHDLNPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x3F45D10", Offset = "0x3F44F10", VA = "0x183F45D10", Slot = "4")]
	[AsyncStateMachine(typeof(MMCHHEJEDJH<>.NEBMHFLBHNO))]
	public override Task<OLALPPDDFPO> GNDGKBBHPCI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public struct MFNLFBHPEDF<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public TData JGMMJLJDLMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public IReadOnlyList<TData> LBCIBPJCAMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public bool GJIOMHKLCIN;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x3F14790", Offset = "0x3F13990", VA = "0x183F14790")]
	public MFNLFBHPEDF(TData ICKBELEKNFH, IReadOnlyList<TData> IBBBHIMMIDI, bool CPCHOJDPJNK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface LFIKJFOONHA<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GNDGKBBHPCI([In] AIFDPNKFKHE<TData> NCCDCEOHGBP);
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface KJCKNLHDLNC<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GNDGKBBHPCI([In] OPNGIDKEKCL<TData> NCCDCEOHGBP);
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface BKFFMCALNPF<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LFJGMPHOBFF([In] JGDPNMFDANF<TData> NCCDCEOHGBP);

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CLAFBOMKDCA();
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class CECDMHMEJJL<TData> : HNHNDOBBMPF<LFIKJFOONHA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly AIFDPNKFKHE<TData> NCCDCEOHGBP;

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x4A12550", Offset = "0x4A11750", VA = "0x184A12550")]
	public CECDMHMEJJL(IEnumerable<TData> LGHFGMAEMIL, LJFEFAMPPFH CMIODFEAKCF, FPEFJDMPECH ODNKEDBIBDH, float AMICNHPLMAJ, bool CPCHOJDPJNK, LFIKJFOONHA<TData> INAHCHDLNPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x3863BF0", Offset = "0x3862DF0", VA = "0x183863BF0", Slot = "4")]
	public override bool GNDGKBBHPCI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class OMDCBNFKLDL<TData> : HNHNDOBBMPF<KJCKNLHDLNC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly OPNGIDKEKCL<TData> NCCDCEOHGBP;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x410B8B0", Offset = "0x410AAB0", VA = "0x18410B8B0")]
	public OMDCBNFKLDL(TData[] LGHFGMAEMIL, LJFEFAMPPFH[] CMIODFEAKCF, FPEFJDMPECH[] ODNKEDBIBDH, float[] AMICNHPLMAJ, KJCKNLHDLNC<TData> INAHCHDLNPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x410B800", Offset = "0x410AA00", VA = "0x18410B800", Slot = "4")]
	public override bool GNDGKBBHPCI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class IOKNOEDKEBK<TData> : HNHNDOBBMPF<BKFFMCALNPF<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3400FA0", Offset = "0x34001A0", VA = "0x183400FA0")]
	public IOKNOEDKEBK(BKFFMCALNPF<TData> INAHCHDLNPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x3A5D270", Offset = "0x3A5C470", VA = "0x183A5D270", Slot = "4")]
	public override bool GNDGKBBHPCI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class DADFFGOMGLK<TData> : HNHNDOBBMPF<BKFFMCALNPF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly JGDPNMFDANF<TData> NCCDCEOHGBP;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x506DA70", Offset = "0x506CC70", VA = "0x18506DA70")]
	public DADFFGOMGLK(IEnumerable<TData> LGHFGMAEMIL, LJFEFAMPPFH CMIODFEAKCF, FPEFJDMPECH ODNKEDBIBDH, float AMICNHPLMAJ, BKFFMCALNPF<TData> INAHCHDLNPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x410B800", Offset = "0x410AA00", VA = "0x18410B800", Slot = "4")]
	public override bool GNDGKBBHPCI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public struct AIFDPNKFKHE<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public IEnumerable<TData> IEJEJLFKEOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public LJFEFAMPPFH BGOBLBNPHCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public FPEFJDMPECH IEABADFPIFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public float AMICNHPLMAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public bool CPCHOJDPJNK;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x38AF730", Offset = "0x38AE930", VA = "0x1838AF730")]
	public AIFDPNKFKHE(IEnumerable<TData> LGHFGMAEMIL, LJFEFAMPPFH CMIODFEAKCF, FPEFJDMPECH ODNKEDBIBDH, float AMICNHPLMAJ, bool CPCHOJDPJNK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct OPNGIDKEKCL<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public TData[] IEJEJLFKEOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public LJFEFAMPPFH[] BGOBLBNPHCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public FPEFJDMPECH[] IEABADFPIFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public float[] AMICNHPLMAJ;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x4110C90", Offset = "0x410FE90", VA = "0x184110C90")]
	public OPNGIDKEKCL(TData[] LGHFGMAEMIL, LJFEFAMPPFH[] CMIODFEAKCF, FPEFJDMPECH[] ODNKEDBIBDH, float[] AMICNHPLMAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public struct JGDPNMFDANF<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public IEnumerable<TData> IEJEJLFKEOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public LJFEFAMPPFH BGOBLBNPHCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public FPEFJDMPECH IEABADFPIFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public float AMICNHPLMAJ;

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3BFA0D0", Offset = "0x3BF92D0", VA = "0x183BFA0D0")]
	public JGDPNMFDANF(IEnumerable<TData> LGHFGMAEMIL, LJFEFAMPPFH CMIODFEAKCF, FPEFJDMPECH ODNKEDBIBDH, float AMICNHPLMAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public interface BJDMPMAAMGE<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HAGNECCJNMB([In] NKLCECDDMIG<TData> PAFHNGHNABO);

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LCHNFPKIKJN([In] NKLCECDDMIG<TData> PAFHNGHNABO);

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void APGJLHDONHE([In] bool NLLLALCMCNC);

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JACMHLAIPFK([In] NKLCECDDMIG<TData> PAFHNGHNABO);

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GPGCALFDOOG();

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool CDNPDFBCBCO([In] TData DDKHHBHCDLG);
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class HCIJHEDBHLH<TData> : HNHNDOBBMPF<BJDMPMAAMGE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly NKLCECDDMIG<TData> PAFHNGHNABO;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x3943B60", Offset = "0x3942D60", VA = "0x183943B60")]
	public HCIJHEDBHLH(List<TData> CNMJLBIMKJD, BJDMPMAAMGE<TData> INAHCHDLNPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3863BF0", Offset = "0x3862DF0", VA = "0x183863BF0", Slot = "4")]
	public override bool GNDGKBBHPCI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class BOILGMIIMKD<TData> : HNHNDOBBMPF<BJDMPMAAMGE<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3400FA0", Offset = "0x34001A0", VA = "0x183400FA0")]
	public BOILGMIIMKD(BJDMPMAAMGE<TData> INAHCHDLNPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x47EEB60", Offset = "0x47EDD60", VA = "0x1847EEB60", Slot = "4")]
	public override bool GNDGKBBHPCI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class OGDEADIBNMB<TData> : HNHNDOBBMPF<BJDMPMAAMGE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly bool CPCHOJDPJNK;

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x40F6D50", Offset = "0x40F5F50", VA = "0x1840F6D50")]
	public OGDEADIBNMB(bool CPCHOJDPJNK, BJDMPMAAMGE<TData> INAHCHDLNPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x40F6CF0", Offset = "0x40F5EF0", VA = "0x1840F6CF0", Slot = "4")]
	public override bool GNDGKBBHPCI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class OFADPMOBBKC<TData> : HNHNDOBBMPF<BJDMPMAAMGE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly NKLCECDDMIG<TData> PAFHNGHNABO;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x40F1940", Offset = "0x40F0B40", VA = "0x1840F1940")]
	public OFADPMOBBKC(List<TData> CNMJLBIMKJD, bool CPCHOJDPJNK, BJDMPMAAMGE<TData> INAHCHDLNPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3975200", Offset = "0x3974400", VA = "0x183975200", Slot = "4")]
	public override bool GNDGKBBHPCI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class BPACCJGMKNM<TData> : HNHNDOBBMPF<BJDMPMAAMGE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly TData DDKHHBHCDLG;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x47EEDC0", Offset = "0x47EDFC0", VA = "0x1847EEDC0")]
	public BPACCJGMKNM(TData DDKHHBHCDLG, BJDMPMAAMGE<TData> INAHCHDLNPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x47EEC50", Offset = "0x47EDE50", VA = "0x1847EEC50", Slot = "4")]
	public override bool GNDGKBBHPCI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class ENBIOOLGEEE<TData> : HNHNDOBBMPF<BJDMPMAAMGE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly NKLCECDDMIG<TData> PAFHNGHNABO;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x342C330", Offset = "0x342B530", VA = "0x18342C330")]
	public ENBIOOLGEEE(IEnumerable<TData> CNMJLBIMKJD, BJDMPMAAMGE<TData> INAHCHDLNPA, bool CPCHOJDPJNK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x342C270", Offset = "0x342B470", VA = "0x18342C270", Slot = "4")]
	public override bool GNDGKBBHPCI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public struct NKLCECDDMIG<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public IEnumerable<TData> IEJEJLFKEOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public bool CPCHOJDPJNK;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x3FF90D0", Offset = "0x3FF82D0", VA = "0x183FF90D0")]
	public NKLCECDDMIG(IEnumerable<TData> BKIKHFHHKEJ, bool ILOPCJADNNA = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public interface FOHAJJCCHCK
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<OLALPPDDFPO> GNDGKBBHPCI(HHEBOCDOGIO HCBFLLIGNEP);
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class CCCHDNKGADG : GPMIJNPHHEG<FOHAJJCCHCK, OLALPPDDFPO>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private struct JJGJMFLFEBB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public AsyncTaskMethodBuilder<OLALPPDDFPO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public CCCHDNKGADG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private TaskAwaiter<OLALPPDDFPO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x616FD70", Offset = "0x616EF70", VA = "0x18616FD70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x616FFE0", Offset = "0x616F1E0", VA = "0x18616FFE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly HHEBOCDOGIO MKMOOKFNDCG;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x616F960", Offset = "0x616EB60", VA = "0x18616F960")]
	public CCCHDNKGADG(bool CPCHOJDPJNK, FOHAJJCCHCK INAHCHDLNPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x616F870", Offset = "0x616EA70", VA = "0x18616F870", Slot = "4")]
	[AsyncStateMachine(typeof(JJGJMFLFEBB))]
	public override Task<OLALPPDDFPO> GNDGKBBHPCI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct HHEBOCDOGIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public bool GJIOMHKLCIN;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0xCC1420", Offset = "0xCC0620", VA = "0x180CC1420")]
	public HHEBOCDOGIO(bool CPCHOJDPJNK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public readonly struct NMOPIMGBDGI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly bool GCOAAHHKGKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly bool DLMBPEJIPEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly bool OFBFBKPELML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public readonly bool CPCHOJDPJNK;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x46759A0", Offset = "0x4674BA0", VA = "0x1846759A0")]
	public NMOPIMGBDGI(bool GCOAAHHKGKH, bool DLMBPEJIPEH, bool OFBFBKPELML, bool CPCHOJDPJNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6170BA0", Offset = "0x616FDA0", VA = "0x186170BA0")]
	public NMOPIMGBDGI(bool DLMBPEJIPEH, bool CPCHOJDPJNK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface IKEHKLAHOIK
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IILGIFPILHA(NMOPIMGBDGI CDBEAFCBNNA);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KCDGKGCIKBL(NMOPIMGBDGI CDBEAFCBNNA);
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class MJMINOGJKBG : HNHNDOBBMPF<IKEHKLAHOIK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly NMOPIMGBDGI CDBEAFCBNNA;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x61706B0", Offset = "0x616F8B0", VA = "0x1861706B0")]
	public MJMINOGJKBG(bool DIFJEPLFOKN, bool DLMBPEJIPEH, bool OFBFBKPELML, bool CPCHOJDPJNK, IKEHKLAHOIK INAHCHDLNPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6170660", Offset = "0x616F860", VA = "0x186170660", Slot = "4")]
	public override bool GNDGKBBHPCI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class JCKCPDHMMDB : HNHNDOBBMPF<IKEHKLAHOIK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly NMOPIMGBDGI CDBEAFCBNNA;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x616FCF0", Offset = "0x616EEF0", VA = "0x18616FCF0")]
	public JCKCPDHMMDB(bool DLMBPEJIPEH, bool CPCHOJDPJNK, IKEHKLAHOIK INAHCHDLNPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x616FCA0", Offset = "0x616EEA0", VA = "0x18616FCA0", Slot = "4")]
	public override bool GNDGKBBHPCI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public interface HKKMCJHJHFA
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GNDGKBBHPCI([In] NMNEMDKFJGL CNMPNKFOLIG);
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class ALFHPHPFKBO : HNHNDOBBMPF<HKKMCJHJHFA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly NMNEMDKFJGL CNMPNKFOLIG;

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x616F670", Offset = "0x616E870", VA = "0x18616F670")]
	public ALFHPHPFKBO(Guid[] JGAGOIBCOMN, Vector3[] HAKLOIHDLFN, Quaternion[] MEGMJKCFGAA, float[] OFGFGKLJBHD, Dictionary<Guid, Vector3> OKCBCPLFMCO, HKKMCJHJHFA INAHCHDLNPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x616F5C0", Offset = "0x616E7C0", VA = "0x18616F5C0", Slot = "4")]
	public override bool GNDGKBBHPCI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public interface JGACIPNMIIA<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PGDJLHBBBDL([In] OMCEHNNOCOJ<TData> LGNOPBEPMKC);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LFJGMPHOBFF([In] DBFEHOPMCBG NELHNOAJONN);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LFJGMPHOBFF([In] LIIEFBPGBOJ NELHNOAJONN);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CLAFBOMKDCA();
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class KCDMKOKFACB<TData> : HNHNDOBBMPF<JGACIPNMIIA<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x3400FA0", Offset = "0x34001A0", VA = "0x183400FA0")]
	public KCDMKOKFACB(JGACIPNMIIA<TData> INAHCHDLNPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3CAA770", Offset = "0x3CA9970", VA = "0x183CAA770", Slot = "4")]
	public override bool GNDGKBBHPCI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class AFLHGADEBDM<TData> : HNHNDOBBMPF<JGACIPNMIIA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly DBFEHOPMCBG BOKOKKOPHBH;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x383CBE0", Offset = "0x383BDE0", VA = "0x18383CBE0")]
	public AFLHGADEBDM(Vector3 AJPFLFBBPAH, bool IBGGMHNCEIK, JGACIPNMIIA<TData> INAHCHDLNPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x340B870", Offset = "0x340AA70", VA = "0x18340B870", Slot = "4")]
	public override bool GNDGKBBHPCI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class LPBNPLEKPME<TData> : HNHNDOBBMPF<JGACIPNMIIA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly LIIEFBPGBOJ BOKOKKOPHBH;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x3D6D810", Offset = "0x3D6CA10", VA = "0x183D6D810")]
	public LPBNPLEKPME(Guid LGJFLMHKOKC, int MBGANDEDPDN, Vector3 JCMPCLFLJHD, Quaternion ECLCOOPOABI, float MBFEDEOEGOE, bool IBGGMHNCEIK, JGACIPNMIIA<TData> INAHCHDLNPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x3D6D7B0", Offset = "0x3D6C9B0", VA = "0x183D6D7B0", Slot = "4")]
	public override bool GNDGKBBHPCI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class HBJKAHLJJAM<TData> : HNHNDOBBMPF<JGACIPNMIIA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly OMCEHNNOCOJ<TData> BOKOKKOPHBH;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x393F240", Offset = "0x393E440", VA = "0x18393F240")]
	public HBJKAHLJJAM(TData JGFCAMDGBLE, bool CPCHOJDPJNK, JGACIPNMIIA<TData> INAHCHDLNPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x3863BF0", Offset = "0x3862DF0", VA = "0x183863BF0", Slot = "4")]
	public override bool GNDGKBBHPCI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public struct DBFEHOPMCBG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public readonly Vector3 AJPFLFBBPAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly bool IBGGMHNCEIK;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x616F9C0", Offset = "0x616EBC0", VA = "0x18616F9C0")]
	public DBFEHOPMCBG(Vector3 AJPFLFBBPAH, bool IBGGMHNCEIK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public struct LIIEFBPGBOJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public readonly Guid LGJFLMHKOKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public readonly int MBGANDEDPDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public readonly Vector3 JCMPCLFLJHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public readonly Quaternion ECLCOOPOABI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public readonly float MBFEDEOEGOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public readonly bool IBGGMHNCEIK;

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6170620", Offset = "0x616F820", VA = "0x186170620")]
	public LIIEFBPGBOJ(Guid LGJFLMHKOKC, int MBGANDEDPDN, Vector3 JCMPCLFLJHD, Quaternion ECLCOOPOABI, float MBFEDEOEGOE, bool IBGGMHNCEIK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public struct OMCEHNNOCOJ<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public readonly TData JGFCAMDGBLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public readonly bool CPCHOJDPJNK;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x410B6D0", Offset = "0x410A8D0", VA = "0x18410B6D0")]
	public OMCEHNNOCOJ(TData JGFCAMDGBLE, bool CPCHOJDPJNK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public interface PNOEEBJBEPE<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GNDGKBBHPCI([In] AIHOLKHABGP<TData> HNJEGPNOHBH);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GNDGKBBHPCI([In] GABPLLHABPL<TData> HNJEGPNOHBH);
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public interface JAEOCKJFADI<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PGDJLHBBBDL([In] FJEOAKPLEOP<TData> FCGENLIFJLJ);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LFJGMPHOBFF([In] ADHBEOMNAHO NELHNOAJONN);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CLAFBOMKDCA();
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class PFCILIPDNKK<TData> : HNHNDOBBMPF<PNOEEBJBEPE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly AIHOLKHABGP<TData> HNJEGPNOHBH;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x41A3C40", Offset = "0x41A2E40", VA = "0x1841A3C40")]
	public PFCILIPDNKK(IEnumerable<TData> LGHFGMAEMIL, Vector3 CLJOGAEGMMN, bool CPCHOJDPJNK, PNOEEBJBEPE<TData> INAHCHDLNPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x3863BF0", Offset = "0x3862DF0", VA = "0x183863BF0", Slot = "4")]
	public override bool GNDGKBBHPCI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class OHHFMAHLKOP<TData> : HNHNDOBBMPF<JAEOCKJFADI<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x3400FA0", Offset = "0x34001A0", VA = "0x183400FA0")]
	public OHHFMAHLKOP(JAEOCKJFADI<TData> INAHCHDLNPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x3A5D2C0", Offset = "0x3A5C4C0", VA = "0x183A5D2C0", Slot = "4")]
	public override bool GNDGKBBHPCI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class DLJFIPMLACG<TData> : HNHNDOBBMPF<JAEOCKJFADI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly FJEOAKPLEOP<TData> HNJEGPNOHBH;

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x50A2030", Offset = "0x50A1230", VA = "0x1850A2030")]
	public DLJFIPMLACG(IEnumerable<TData> LGHFGMAEMIL, bool CPCHOJDPJNK, JAEOCKJFADI<TData> INAHCHDLNPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x3863BF0", Offset = "0x3862DF0", VA = "0x183863BF0", Slot = "4")]
	public override bool GNDGKBBHPCI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class KEEPBIHPDEF<TData> : HNHNDOBBMPF<PNOEEBJBEPE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly GABPLLHABPL<TData> HNJEGPNOHBH;

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x3CAB2C0", Offset = "0x3CAA4C0", VA = "0x183CAB2C0")]
	public KEEPBIHPDEF(IEnumerable<TData> LGHFGMAEMIL, Vector3 KPNIDOJCJOG, KAGGCBNJJIJ EJKICJDNKNK, bool CPCHOJDPJNK, PNOEEBJBEPE<TData> INAHCHDLNPA, Space ENIEFBAFDLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x37C8670", Offset = "0x37C7870", VA = "0x1837C8670", Slot = "4")]
	public override bool GNDGKBBHPCI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class BHKCGHOJECE<TData> : HNHNDOBBMPF<JAEOCKJFADI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly ADHBEOMNAHO HNJEGPNOHBH;

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x47C3530", Offset = "0x47C2730", VA = "0x1847C3530")]
	public BHKCGHOJECE(Vector3 CLJOGAEGMMN, JAEOCKJFADI<TData> INAHCHDLNPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x340B870", Offset = "0x340AA70", VA = "0x18340B870", Slot = "4")]
	public override bool GNDGKBBHPCI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct AIHOLKHABGP<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public readonly IEnumerable<TData> LGHFGMAEMIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public readonly Vector3 CLJOGAEGMMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public readonly bool CPCHOJDPJNK;

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x38AF840", Offset = "0x38AEA40", VA = "0x1838AF840")]
	public AIHOLKHABGP(IEnumerable<TData> LGHFGMAEMIL, Vector3 CLJOGAEGMMN, bool CPCHOJDPJNK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct FJEOAKPLEOP<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public readonly IEnumerable<TData> LGHFGMAEMIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public readonly bool CPCHOJDPJNK;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x37B3230", Offset = "0x37B2430", VA = "0x1837B3230")]
	public FJEOAKPLEOP(IEnumerable<TData> LGHFGMAEMIL, bool CPCHOJDPJNK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct GABPLLHABPL<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public readonly IEnumerable<TData> LGHFGMAEMIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public readonly Vector3 KPNIDOJCJOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public readonly KAGGCBNJJIJ EJKICJDNKNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly bool CPCHOJDPJNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public readonly Space ENIEFBAFDLI;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x384D0C0", Offset = "0x384C2C0", VA = "0x18384D0C0")]
	public GABPLLHABPL(IEnumerable<TData> LGHFGMAEMIL, Vector3 KPNIDOJCJOG, KAGGCBNJJIJ EJKICJDNKNK, bool CPCHOJDPJNK, Space ENIEFBAFDLI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct ADHBEOMNAHO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly Vector3 CLJOGAEGMMN;

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x1FB3B50", Offset = "0x1FB2D50", VA = "0x181FB3B50")]
	public ADHBEOMNAHO(Vector3 CLJOGAEGMMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public enum KAGGCBNJJIJ
{
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	XYZ,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	X_only,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	Y_only,
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	Z_only
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public interface ODPGNCFEBPB
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GNDGKBBHPCI([In] EPCDFIKBGIO AKCDPIPBMKO);
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public class DHPPMFJBBGE : HNHNDOBBMPF<ODPGNCFEBPB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly EPCDFIKBGIO AKCDPIPBMKO;

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x616FA90", Offset = "0x616EC90", VA = "0x18616FA90")]
	public DHPPMFJBBGE(bool CPCHOJDPJNK, ODPGNCFEBPB INAHCHDLNPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x616F9E0", Offset = "0x616EBE0", VA = "0x18616F9E0", Slot = "4")]
	public override bool GNDGKBBHPCI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public readonly struct EPCDFIKBGIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public readonly bool CPCHOJDPJNK;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0xCC1420", Offset = "0xCC0620", VA = "0x180CC1420")]
	public EPCDFIKBGIO(bool CPCHOJDPJNK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public interface NIPFKJALDJI<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GNDGKBBHPCI([In] FAMKAJFDHNM<TData> DOBECMEGHBJ);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GNDGKBBHPCI([In] IPMGBEBKPDI<TData> DOBECMEGHBJ);
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public interface EGEHKGEGDAH<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PGDJLHBBBDL([In] ADHMLIBNNON<TData> LGNOPBEPMKC);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LFJGMPHOBFF([In] IFMOBDGPPFE NELHNOAJONN);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CLAFBOMKDCA();
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class GGPLFGBBLFN<TData> : HNHNDOBBMPF<NIPFKJALDJI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly FAMKAJFDHNM<TData> DOBECMEGHBJ;

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x3863CA0", Offset = "0x3862EA0", VA = "0x183863CA0")]
	public GGPLFGBBLFN(IEnumerable<TData> LGHFGMAEMIL, Quaternion CLJOGAEGMMN, Vector3? BHIPLNAGMDE, bool ECNPDOJKAML, bool CPCHOJDPJNK, NIPFKJALDJI<TData> INAHCHDLNPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x3863BF0", Offset = "0x3862DF0", VA = "0x183863BF0", Slot = "4")]
	public override bool GNDGKBBHPCI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class IONEFKHGAPA<TData> : HNHNDOBBMPF<EGEHKGEGDAH<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x3400FA0", Offset = "0x34001A0", VA = "0x183400FA0")]
	public IONEFKHGAPA(EGEHKGEGDAH<TData> INAHCHDLNPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x3A5D2C0", Offset = "0x3A5C4C0", VA = "0x183A5D2C0", Slot = "4")]
	public override bool GNDGKBBHPCI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class CGCPBPPKDKD<TData> : HNHNDOBBMPF<EGEHKGEGDAH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly ADHMLIBNNON<TData> DOBECMEGHBJ;

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x4A1AD00", Offset = "0x4A19F00", VA = "0x184A1AD00")]
	public CGCPBPPKDKD(IEnumerable<TData> LGHFGMAEMIL, bool CPCHOJDPJNK, EGEHKGEGDAH<TData> INAHCHDLNPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x3863BF0", Offset = "0x3862DF0", VA = "0x183863BF0", Slot = "4")]
	public override bool GNDGKBBHPCI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class FOGAALGGPPK<TData> : HNHNDOBBMPF<NIPFKJALDJI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly IPMGBEBKPDI<TData> DOBECMEGHBJ;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x37C8730", Offset = "0x37C7930", VA = "0x1837C8730")]
	public FOGAALGGPPK(IEnumerable<TData> LGHFGMAEMIL, Quaternion ICLAIABHOFI, KAGGCBNJJIJ ENAJDLDLCGD, Vector3? BHIPLNAGMDE, bool ECNPDOJKAML, bool CPCHOJDPJNK, Space ENIEFBAFDLI, NIPFKJALDJI<TData> INAHCHDLNPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x37C8670", Offset = "0x37C7870", VA = "0x1837C8670", Slot = "4")]
	public override bool GNDGKBBHPCI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class EFDOJNCNCFF<TData> : HNHNDOBBMPF<EGEHKGEGDAH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly IFMOBDGPPFE DOBECMEGHBJ;

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x340B8D0", Offset = "0x340AAD0", VA = "0x18340B8D0")]
	public EFDOJNCNCFF(Quaternion CLJOGAEGMMN, Vector3? BHIPLNAGMDE, bool ECNPDOJKAML, EGEHKGEGDAH<TData> INAHCHDLNPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x340B870", Offset = "0x340AA70", VA = "0x18340B870", Slot = "4")]
	public override bool GNDGKBBHPCI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public struct FAMKAJFDHNM<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public readonly IEnumerable<TData> LGHFGMAEMIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public readonly Quaternion CLJOGAEGMMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public readonly Vector3? BHIPLNAGMDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public readonly bool ECNPDOJKAML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public readonly bool CPCHOJDPJNK;

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x3759D60", Offset = "0x3758F60", VA = "0x183759D60")]
	public FAMKAJFDHNM(IEnumerable<TData> LGHFGMAEMIL, Quaternion CLJOGAEGMMN, Vector3? BHIPLNAGMDE, bool ECNPDOJKAML, bool CPCHOJDPJNK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public struct ADHMLIBNNON<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public readonly IEnumerable<TData> LGHFGMAEMIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public readonly bool CPCHOJDPJNK;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x3837C70", Offset = "0x3836E70", VA = "0x183837C70")]
	public ADHMLIBNNON(IEnumerable<TData> LGHFGMAEMIL, bool CPCHOJDPJNK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public struct IPMGBEBKPDI<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly IEnumerable<TData> LGHFGMAEMIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public readonly Quaternion ICLAIABHOFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public readonly KAGGCBNJJIJ ENAJDLDLCGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public readonly Vector3? BHIPLNAGMDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public readonly bool ECNPDOJKAML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public readonly bool CPCHOJDPJNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public readonly Space ENIEFBAFDLI;

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x3A5E7D0", Offset = "0x3A5D9D0", VA = "0x183A5E7D0")]
	public IPMGBEBKPDI(IEnumerable<TData> LGHFGMAEMIL, Quaternion ICLAIABHOFI, KAGGCBNJJIJ ENAJDLDLCGD, Vector3? BHIPLNAGMDE, bool ECNPDOJKAML, bool CPCHOJDPJNK, Space ENIEFBAFDLI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public struct IFMOBDGPPFE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public readonly Quaternion CLJOGAEGMMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public readonly Vector3? BHIPLNAGMDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public readonly bool ECNPDOJKAML;

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x462DB30", Offset = "0x462CD30", VA = "0x18462DB30")]
	public IFMOBDGPPFE(Quaternion CLJOGAEGMMN, Vector3? BHIPLNAGMDE, bool ECNPDOJKAML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public interface EFLFOBCDCDE<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PGDJLHBBBDL([In] OFHAJMPKNGE<TData> LGNOPBEPMKC);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LFJGMPHOBFF([In] MNMFJFFHGLL NELHNOAJONN);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LFJGMPHOBFF([In] IBMMNHPIHHJ NELHNOAJONN);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool LFJGMPHOBFF([In] IEBFECICDLF NELHNOAJONN);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool CLAFBOMKDCA();
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public class IAJDJPNLLCM<TData> : HNHNDOBBMPF<EFLFOBCDCDE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly IEBFECICDLF CNBFEIBKIOE;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x3A15BD0", Offset = "0x3A14DD0", VA = "0x183A15BD0")]
	public IAJDJPNLLCM(Vector3 HKCAAJOEMGN, float GGHLFGGDEEP, Vector3 BHIPLNAGMDE, bool CBDINGEBPFJ, bool PIMBHGFGCFD, EFLFOBCDCDE<TData> INAHCHDLNPA, Space ENIEFBAFDLI = Space.Self)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x3A15B70", Offset = "0x3A14D70", VA = "0x183A15B70", Slot = "4")]
	public override bool GNDGKBBHPCI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public class PFGLKFGKKNA<TData> : HNHNDOBBMPF<EFLFOBCDCDE<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x3400FA0", Offset = "0x34001A0", VA = "0x183400FA0")]
	public PFGLKFGKKNA(EFLFOBCDCDE<TData> INAHCHDLNPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x41A49F0", Offset = "0x41A3BF0", VA = "0x1841A49F0", Slot = "4")]
	public override bool GNDGKBBHPCI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class GNDCEPIMMLJ<TData> : HNHNDOBBMPF<EFLFOBCDCDE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly OFHAJMPKNGE<TData> CNBFEIBKIOE;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x38904A0", Offset = "0x388F6A0", VA = "0x1838904A0")]
	public GNDCEPIMMLJ(IEnumerable<TData> LGHFGMAEMIL, bool CPCHOJDPJNK, EFLFOBCDCDE<TData> INAHCHDLNPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x3863BF0", Offset = "0x3862DF0", VA = "0x183863BF0", Slot = "4")]
	public override bool GNDGKBBHPCI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class OGMOLBHDHGL<TData> : HNHNDOBBMPF<EFLFOBCDCDE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly IBMMNHPIHHJ CNBFEIBKIOE;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x40FEC10", Offset = "0x40FDE10", VA = "0x1840FEC10")]
	public OGMOLBHDHGL(float NBPIKOBPFGA, bool PBAICEHIABK, Vector3 BHIPLNAGMDE, EFLFOBCDCDE<TData> INAHCHDLNPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x40FEB50", Offset = "0x40FDD50", VA = "0x1840FEB50", Slot = "4")]
	public override bool GNDGKBBHPCI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class BEEKPAEPIOE<TData> : HNHNDOBBMPF<EFLFOBCDCDE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly MNMFJFFHGLL CNBFEIBKIOE;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x47B9BE0", Offset = "0x47B8DE0", VA = "0x1847B9BE0")]
	public BEEKPAEPIOE(float GGHLFGGDEEP, Vector3 BHIPLNAGMDE, EFLFOBCDCDE<TData> INAHCHDLNPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x340B870", Offset = "0x340AA70", VA = "0x18340B870", Slot = "4")]
	public override bool GNDGKBBHPCI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public struct IEBFECICDLF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public readonly Vector3 HKCAAJOEMGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public readonly float GGHLFGGDEEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public readonly Vector3 BHIPLNAGMDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public readonly bool IBGGMHNCEIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public readonly Space ENIEFBAFDLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public readonly bool PIMBHGFGCFD;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x616FC60", Offset = "0x616EE60", VA = "0x18616FC60")]
	public IEBFECICDLF(Vector3 HKCAAJOEMGN, float GGHLFGGDEEP, Vector3 BHIPLNAGMDE, bool IBGGMHNCEIK, bool MAKIFCADGAE, Space ENIEFBAFDLI = Space.Self)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public struct OFHAJMPKNGE<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public readonly IEnumerable<TData> LGHFGMAEMIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public readonly bool CPCHOJDPJNK;

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x40F3E30", Offset = "0x40F3030", VA = "0x1840F3E30")]
	public OFHAJMPKNGE(IEnumerable<TData> LGHFGMAEMIL, bool CPCHOJDPJNK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct IBMMNHPIHHJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public readonly float NBPIKOBPFGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public readonly bool PBAICEHIABK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public readonly Vector3 BHIPLNAGMDE;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x616FC40", Offset = "0x616EE40", VA = "0x18616FC40")]
	public IBMMNHPIHHJ(float NBPIKOBPFGA, bool PBAICEHIABK, Vector3 BHIPLNAGMDE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public struct MNMFJFFHGLL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public readonly float GGHLFGGDEEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public readonly Vector3 BHIPLNAGMDE;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x4604D80", Offset = "0x4603F80", VA = "0x184604D80")]
	public MNMFJFFHGLL(float GGHLFGGDEEP, Vector3 BHIPLNAGMDE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct NMNEMDKFJGL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public readonly Guid[] LGHFGMAEMIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public readonly bool CBGHFHGHAME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public readonly bool JFECJKBNCNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public readonly bool BPOOBBEECGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public readonly Vector3[] HAKLOIHDLFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public readonly Quaternion[] MEGMJKCFGAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public readonly float[] OFGFGKLJBHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly Dictionary<Guid, Vector3> OKCBCPLFMCO;

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6170910", Offset = "0x616FB10", VA = "0x186170910")]
	public NMNEMDKFJGL(Guid[] JGAGOIBCOMN, Vector3[] HAKLOIHDLFN, Quaternion[] MEGMJKCFGAA, float[] OFGFGKLJBHD, Dictionary<Guid, Vector3> OKCBCPLFMCO, bool CBGHFHGHAME = true, bool JFECJKBNCNM = true, bool BPOOBBEECGG = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x6170740", Offset = "0x616F940", VA = "0x186170740")]
	private static void MCAPGAOCMFC(Dictionary<Guid, Vector3> OKCBCPLFMCO, int JDAONAILHNE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public static class KPAEAPHCODD
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	private struct BKGPNMHBCEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public bool CDKCGCDABFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public JGBEMAKPOMJ GCOFCILIFCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public JGBEMAKPOMJ IGCDHMNGMMC;
	}

	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private static BKGPNMHBCEH MACIBHHIBEH;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static CancellationToken LODBFGJKKPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x6170560", Offset = "0x616F760", VA = "0x186170560")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	internal static JGBEMAKPOMJ GCOFCILIFCM
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x6170580", Offset = "0x616F780", VA = "0x186170580")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6170500", Offset = "0x616F700", VA = "0x186170500")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x61702D0", Offset = "0x616F4D0", VA = "0x1861702D0")]
	[BDCLMMIIFOD(AILNDCKFLHJ.Room, CIJFMPALMOO.None)]
	private static void DBEDDFAOJOD(JGBEMAKPOMJ CKJCDKDICNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x61703C0", Offset = "0x616F5C0", VA = "0x1861703C0")]
	public static void GKFNPGBHNDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6170280", Offset = "0x616F480", VA = "0x186170280")]
	private static JGBEMAKPOMJ BHLFHMEEGEB(JGBEMAKPOMJ PCLGCNBMJAC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public static class NJJHCOCKBBK
{
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public enum DMDPHIAMPPC
	{
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		ICreationContextObject,
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		Guid
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x29CECA0", Offset = "0x29CDEA0", VA = "0x1829CECA0")]
	public static void OCJIDNKCFMC<T>(T KLPCJKOHLOK, DMDPHIAMPPC MJMAEGDPBNJ) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x29CEDE0", Offset = "0x29CDFE0", VA = "0x1829CEDE0")]
	public static void OCJIDNKCFMC<T>(T KLPCJKOHLOK) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x29CEE40", Offset = "0x29CE040", VA = "0x1829CEE40")]
	public static void OOLBHJMNJHK<T>(T KLPCJKOHLOK) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x29CEB60", Offset = "0x29CDD60", VA = "0x1829CEB60")]
	public static T CEIMJGKDJPN<T>(DMDPHIAMPPC MJMAEGDPBNJ) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x29CE950", Offset = "0x29CDB50", VA = "0x1829CE950")]
	public static bool AMEEOJPNNKO<T>(DMDPHIAMPPC MJMAEGDPBNJ, T KGICBPFKGNP, [Out] T EHNBDBNBKKJ) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x29CEC00", Offset = "0x29CDE00", VA = "0x1829CEC00")]
	public static bool IIPPNFAKGOF<T>(DMDPHIAMPPC MJMAEGDPBNJ) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x29CEB20", Offset = "0x29CDD20", VA = "0x1829CEB20")]
	public static T CEIMJGKDJPN<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x29CEA80", Offset = "0x29CDC80", VA = "0x1829CEA80")]
	public static bool AMEEOJPNNKO<T>(T KGICBPFKGNP, [Out] T EHNBDBNBKKJ) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x29CEB20", Offset = "0x29CDD20", VA = "0x1829CEB20")]
	public static bool IIPPNFAKGOF<T>() where T : class
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
internal static class KOBFPHGHKEL
{
	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6170050", Offset = "0x616F250", VA = "0x186170050")]
	public static void GGBCPGHMBDN(IEnumerable DJNGLGGADLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x2904FF0", Offset = "0x29041F0", VA = "0x182904FF0")]
	public static void GGBCPGHMBDN<T>(T[] BLGDAGLONDD) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x29050E0", Offset = "0x29042E0", VA = "0x1829050E0")]
	public static void GGBCPGHMBDN<T>(T CDEGJDLAKFC) where T : notnull, Enum
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
