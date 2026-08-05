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
		[Cpp2IlInjected.Address(RVA = "0x88F9F0", Offset = "0x88E9F0", VA = "0x18088F9F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x69B31A0", Offset = "0x69B21A0", VA = "0x1869B31A0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x890740", Offset = "0x88F740", VA = "0x180890740")]
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
		[Cpp2IlInjected.Address(RVA = "0x890780", Offset = "0x88F780", VA = "0x180890780")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface GHBCMHPBIHK<TData, TReturn>
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TReturn FFMLLJBPCIB(TData HBFCGFKGCAF);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface GOCOLPPEJIL<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ClearHoverTarget(HMJGCJEGFLJ JKLALKHMLOO);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool SetHoverTarget(TData PKMPGPJICGL, Collider CMJPFOCDEMC, HMJGCJEGFLJ JKLALKHMLOO, [Optional] JEPJJIBBHEG? GAODIMBCMKK);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool TryGetHoverTarget([Out] TData PKMPGPJICGL);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetHoverCollider([Out] Collider CMJPFOCDEMC);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface HCGPOJEACAE<TData> : GMEPNNGDOGE, AAKBNELLOPB<TData>, PBNGHMPNBCJ<TData>, KPGMAHNJMNK<TData>, BFJMBKOIHIM, EAELCOMKDGH<TData>, AMPICGONEKN, EANPJDFJNID
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface EAELCOMKDGH<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 AKJEKBLKOGB, Vector3 KDJEBHMIDDA, float PNEKGHHAGPJ, [Out] T DAJOBCDPJEL, [Out] Vector3 GNJGLABNGHC, [Out] Collider CMJPFOCDEMC);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 AKJEKBLKOGB, Vector3 KDJEBHMIDDA, float GKIDOBBHHCK, float PNEKGHHAGPJ, T[] LLEGMLAPGJC, [Out] Vector3 ALEFHDDLLEG, [Out] Collider CPAPNPPCHNG);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 AKJEKBLKOGB, float GKIDOBBHHCK, Vector3 MGEPCFCNAGL, T[] LLEGMLAPGJC);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetObjectFromColliderInCurrentScope(Collider MKHCKFPAKLI, [Out] T DLEDEFNCHLL);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface GMEPNNGDOGE
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Bounds GHLMGIHJDDN
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Transform GMDLCMHKNDI
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Bounds CCKCAEOMCIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Transform GPFONFIBEMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Vector3 CFNCOODNODM
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool ODLMHFBIKBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void SetSelectionBoundsDirty(bool CGMDJNCIMMI = true, int NEGOBKBDDJA = 0);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ShouldHideSelectionBoundsPreview(bool HGKKLPJHMEC, object OEDJKICDDGA);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface EANPJDFJNID
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	BGECMLEGDCD GGOADAJMLGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface JOJACIFGPKC
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool LKEFHKPEJMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool JPKENEJOBOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool EBFANEOJFGC
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
	void TrySetPreviousCloneMapping(Dictionary<Guid, Guid> MOOOHKBDOKJ);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface KPGMAHNJMNK<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool MDJACHAILEH
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int GDEAOGKLEGG
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<TData> CMJJMNFMKNO
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData OPNLGJFHDEP);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData OPNLGJFHDEP);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface AAKBNELLOPB<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T HBFCGFKGCAF, [Optional] JEPJJIBBHEG? DHLLILNPCMI, bool KDMNNPCNBIJ = true);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int JPBPNOCHNLG, IEnumerable<T> NECCMDHDJPN, bool KDMNNPCNBIJ = true);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int JPBPNOCHNLG, IEnumerable<T> NECCMDHDJPN, JEPJJIBBHEG DHLLILNPCMI, bool KDMNNPCNBIJ = true);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface AMPICGONEKN
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface BFJMBKOIHIM
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool KPKLGOEJJHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool HDBFMMIOMMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool FBJOGLFLFOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool EDPIMHNDGHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class PENLDNOKIIJ<TReceiver> : NBGHHEGHLKE<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3BBC1B0", Offset = "0x3BBB1B0", VA = "0x183BBC1B0")]
	public PENLDNOKIIJ(TReceiver PMALGFDMMMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class HPANANNKHKH<TReceiver, TFromTask> : NBGHHEGHLKE<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3BBC1B0", Offset = "0x3BBB1B0", VA = "0x183BBC1B0")]
	public HPANANNKHKH(TReceiver PMALGFDMMMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public abstract class NBGHHEGHLKE<TReceiver, TFromExecute> where TReceiver : notnull where TFromExecute : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	protected TReceiver PMALGFDMMMA;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4554750", Offset = "0x4553750", VA = "0x184554750")]
	public NBGHHEGHLKE(TReceiver PMALGFDMMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute KBOIAJIAKAK();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public abstract class MHKMMAKLNOP<TReceiver, TResult> : NBGHHEGHLKE<TReceiver, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3BBC1B0", Offset = "0x3BBB1B0", VA = "0x183BBC1B0")]
	public MHKMMAKLNOP(TReceiver PMALGFDMMMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct JLLMPAPIDJI<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public TGroup NMELAAMLDAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public TData HLGMFEBKAJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public IEnumerable<TData> EPFFEKDEMIG;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1EAC1B0", Offset = "0x1EAB1B0", VA = "0x181EAC1B0")]
	public JLLMPAPIDJI(TGroup PIEFEOLHJAO, TData FDAAIFOACFH, IEnumerable<TData> GDEJEBLJDEH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct MJJDGGOAIIC<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public TGroup NMELAAMLDAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public IEnumerable<TData> EPFFEKDEMIG;

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0xAB8760", Offset = "0xAB7760", VA = "0x180AB8760")]
	public MJJDGGOAIIC(TGroup PIEFEOLHJAO, IEnumerable<TData> GDEJEBLJDEH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct ACEHJPPHPKP<TGroup> where TGroup : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public TGroup NMELAAMLDAG;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x93A5E0", Offset = "0x9395E0", VA = "0x18093A5E0")]
	public ACEHJPPHPKP(TGroup PIEFEOLHJAO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct HFPIDBJIPGD<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public IEnumerable<TData> EPFFEKDEMIG;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x93A5E0", Offset = "0x9395E0", VA = "0x18093A5E0")]
	public HFPIDBJIPGD(IEnumerable<TData> GDEJEBLJDEH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface GMGMDPCLPDC<TGroup, TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HAEHEBEENKB CECNNJNNILG(JLLMPAPIDJI<TGroup, TData> EDOLPFPJPNM);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HAEHEBEENKB PJICLKKPEIO(JLLMPAPIDJI<TGroup, TData> EDOLPFPJPNM);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HAEHEBEENKB LIHHEOEEHLB(MJJDGGOAIIC<TGroup, TData> EDOLPFPJPNM);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "3")]
	HAEHEBEENKB GNOLILHADPA(ACEHJPPHPKP<TGroup> EDOLPFPJPNM);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface CJJFMEBMFPM<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<HAEHEBEENKB> CECNNJNNILG(HFPIDBJIPGD<TData> EDOLPFPJPNM);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class DODEFBKJIJA<TGroup, TData> : MHKMMAKLNOP<GMGMDPCLPDC<TGroup, TData>, HAEHEBEENKB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly MJJDGGOAIIC<TGroup, TData> EDOLPFPJPNM;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x58692D0", Offset = "0x58682D0", VA = "0x1858692D0")]
	public DODEFBKJIJA(TGroup PIEFEOLHJAO, IEnumerable<TData> GDEJEBLJDEH, GMGMDPCLPDC<TGroup, TData> PMALGFDMMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5869200", Offset = "0x5868200", VA = "0x185869200", Slot = "4")]
	public override HAEHEBEENKB KBOIAJIAKAK()
	{
		return default(HAEHEBEENKB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class KDBAIHFNILA<TGroup, TData> : MHKMMAKLNOP<GMGMDPCLPDC<TGroup, TData>, HAEHEBEENKB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly JLLMPAPIDJI<TGroup, TData> EDOLPFPJPNM;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x41EE8F0", Offset = "0x41ED8F0", VA = "0x1841EE8F0")]
	public KDBAIHFNILA(TGroup PIEFEOLHJAO, TData KFMAPGGOPHE, IEnumerable<TData> GDEJEBLJDEH, GMGMDPCLPDC<TGroup, TData> PMALGFDMMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x41EE810", Offset = "0x41ED810", VA = "0x1841EE810", Slot = "4")]
	public override HAEHEBEENKB KBOIAJIAKAK()
	{
		return default(HAEHEBEENKB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class CJPEBHNMPGH<TGroup, TData> : MHKMMAKLNOP<GMGMDPCLPDC<TGroup, TData>, HAEHEBEENKB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly ACEHJPPHPKP<TGroup> EDOLPFPJPNM;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3C3F8B0", Offset = "0x3C3E8B0", VA = "0x183C3F8B0")]
	public CJPEBHNMPGH(TGroup PIEFEOLHJAO, GMGMDPCLPDC<TGroup, TData> PMALGFDMMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x516F520", Offset = "0x516E520", VA = "0x18516F520", Slot = "4")]
	public override HAEHEBEENKB KBOIAJIAKAK()
	{
		return default(HAEHEBEENKB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class KGPOINIMJKK<TGroup, TData> : MHKMMAKLNOP<GMGMDPCLPDC<TGroup, TData>, HAEHEBEENKB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly JLLMPAPIDJI<TGroup, TData> EDOLPFPJPNM;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x41EE8F0", Offset = "0x41ED8F0", VA = "0x1841EE8F0")]
	public KGPOINIMJKK(TGroup PIEFEOLHJAO, TData FDAAIFOACFH, IEnumerable<TData> GDEJEBLJDEH, GMGMDPCLPDC<TGroup, TData> PMALGFDMMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x421D220", Offset = "0x421C220", VA = "0x18421D220", Slot = "4")]
	public override HAEHEBEENKB KBOIAJIAKAK()
	{
		return default(HAEHEBEENKB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class FENEFGHHKDH<TData> : HPANANNKHKH<CJJFMEBMFPM<TData>, HAEHEBEENKB> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private struct JJLDPKABFMO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AsyncTaskMethodBuilder<HAEHEBEENKB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public FENEFGHHKDH<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private TaskAwaiter<HAEHEBEENKB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x4114C20", Offset = "0x4113C20", VA = "0x184114C20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x4114EC0", Offset = "0x4113EC0", VA = "0x184114EC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private HFPIDBJIPGD<TData> EDOLPFPJPNM;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3C3F8B0", Offset = "0x3C3E8B0", VA = "0x183C3F8B0")]
	public FENEFGHHKDH(IEnumerable<TData> MCJPIJODPIJ, CJJFMEBMFPM<TData> PMALGFDMMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3C3FB10", Offset = "0x3C3EB10", VA = "0x183C3FB10", Slot = "4")]
	[AsyncStateMachine(typeof(FENEFGHHKDH<>.JJLDPKABFMO))]
	public override Task<HAEHEBEENKB> KBOIAJIAKAK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct OPOKGMKLOME
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly ONPPLCJJHAA NFLHKGNKJKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly bool PCCAJEBGMMD;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x69B3670", Offset = "0x69B2670", VA = "0x1869B3670")]
	public OPOKGMKLOME(ONPPLCJJHAA OONFMCGLOGI, bool KMHFOADFHFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface DGKIOJPBKFM<TSpawnType> where TSpawnType : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> KBOIAJIAKAK(OPOKGMKLOME DKPIGJMEMCB);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class CDOFEONJCDP<TSpawnType> : HPANANNKHKH<DGKIOJPBKFM<TSpawnType>, TSpawnType> where TSpawnType : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private struct BKPBJOLJHKH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public AsyncTaskMethodBuilder<TSpawnType> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public CDOFEONJCDP<TSpawnType> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskAwaiter<TSpawnType> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x4EA3810", Offset = "0x4EA2810", VA = "0x184EA3810", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x4501DF0", Offset = "0x4500DF0", VA = "0x184501DF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly OPOKGMKLOME DKPIGJMEMCB;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x5060720", Offset = "0x505F720", VA = "0x185060720")]
	public CDOFEONJCDP(ONPPLCJJHAA OONFMCGLOGI, bool KMHFOADFHFE, DGKIOJPBKFM<TSpawnType> PMALGFDMMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5060500", Offset = "0x505F500", VA = "0x185060500", Slot = "4")]
	[AsyncStateMachine(typeof(CDOFEONJCDP<>.BKPBJOLJHKH))]
	public override Task<TSpawnType> KBOIAJIAKAK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public readonly struct ONPPLCJJHAA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly bool PGDLDOBKOAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly Vector3 CGIMAKCEEKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly Vector3 KBHBDHIEKKP;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x69B3540", Offset = "0x69B2540", VA = "0x1869B3540")]
	public ONPPLCJJHAA(Transform OJKIDMBCJIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x69B35B0", Offset = "0x69B25B0", VA = "0x1869B35B0")]
	public ONPPLCJJHAA(Vector3 FFJHDFACBIE, Vector3 MOIICCIPACK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x69B3510", Offset = "0x69B2510", VA = "0x1869B3510")]
	public static ONPPLCJJHAA FCBOIHHPCCD()
	{
		return default(ONPPLCJJHAA);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x69B35E0", Offset = "0x69B25E0", VA = "0x1869B35E0")]
	private ONPPLCJJHAA(bool KIMMCFNLKJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct DPPPCAMABFP<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public TNode DOPCOOFFLHM;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x586E7C0", Offset = "0x586D7C0", VA = "0x18586E7C0")]
	public DPPPCAMABFP(TNode DOPCOOFFLHM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct JKGAJMEGMNE<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public TNode AHBIGFEMLJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public PIMFFKBNAIE LIDCAKAHEOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly bool PCCAJEBGMMD;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x41165B0", Offset = "0x41155B0", VA = "0x1841165B0")]
	public JKGAJMEGMNE(TNode AHBIGFEMLJP, PIMFFKBNAIE LIDCAKAHEOO, bool KMHFOADFHFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface EADNDEHIDPM<TNode>
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GGGOOABCOKG([In] DPPPCAMABFP<TNode> APILJIIHLDC);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JHLPBHMKJHH([In] JKGAJMEGMNE<TNode> EGCFDCFHDJA);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LPKLIFAILII();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class CFHNOIPPJNE<TNode> : PENLDNOKIIJ<EADNDEHIDPM<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3BBC1B0", Offset = "0x3BBB1B0", VA = "0x183BBC1B0")]
	public CFHNOIPPJNE(EADNDEHIDPM<TNode> PMALGFDMMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x412AA20", Offset = "0x4129A20", VA = "0x18412AA20", Slot = "4")]
	public override bool KBOIAJIAKAK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class MIMPNKDMBLN<TNode> : PENLDNOKIIJ<EADNDEHIDPM<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly JKGAJMEGMNE<TNode> EGCFDCFHDJA;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x44F1350", Offset = "0x44F0350", VA = "0x1844F1350")]
	public MIMPNKDMBLN(TNode AHBIGFEMLJP, PIMFFKBNAIE LIDCAKAHEOO, EADNDEHIDPM<TNode> PMALGFDMMMA, bool KMHFOADFHFE = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x42C0AD0", Offset = "0x42BFAD0", VA = "0x1842C0AD0", Slot = "4")]
	public override bool KBOIAJIAKAK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class EALMLPBDAIM<TNode> : PENLDNOKIIJ<EADNDEHIDPM<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly DPPPCAMABFP<TNode> APILJIIHLDC;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x37DFCF0", Offset = "0x37DECF0", VA = "0x1837DFCF0")]
	public EALMLPBDAIM(TNode MMOAALMOGAF, EADNDEHIDPM<TNode> PMALGFDMMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x37DFC30", Offset = "0x37DEC30", VA = "0x1837DFC30", Slot = "4")]
	public override bool KBOIAJIAKAK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct ADKHMHOMNFE<TSpawnInfo> where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public TSpawnInfo OCOKIDBGPJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public Vector3 MOIICCIPACK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Quaternion ADNGPFKNGFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public float GNMLLHFGICG;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3CE7060", Offset = "0x3CE6060", VA = "0x183CE7060")]
	public ADKHMHOMNFE(TSpawnInfo OCOKIDBGPJG, Vector3 MOIICCIPACK, Quaternion ADNGPFKNGFI, float GNMLLHFGICG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface KCEAONOABBD<TSpawnType, TSpawnInfo>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> AIAACOIHFED([In] ADKHMHOMNFE<TSpawnInfo> PDOAGGKCLCG, CancellationToken DADBOHKBJNO);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class HLAAPODPNFK<TSpawnType, TSpawnInfo> : HPANANNKHKH<KCEAONOABBD<TSpawnType, TSpawnInfo>, TSpawnType> where TSpawnType : notnull where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly ADKHMHOMNFE<TSpawnInfo> NENLABMEOHA;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3E03460", Offset = "0x3E02460", VA = "0x183E03460")]
	public HLAAPODPNFK(TSpawnInfo FGEFFBKLBEH, Vector3 MOIICCIPACK, Quaternion ADNGPFKNGFI, float GNMLLHFGICG, KCEAONOABBD<TSpawnType, TSpawnInfo> PMALGFDMMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3E03260", Offset = "0x3E02260", VA = "0x183E03260", Slot = "4")]
	public override Task<TSpawnType> KBOIAJIAKAK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct LCLBJKFBENI<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly IEnumerable<TData> EPFFEKDEMIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly bool PCCAJEBGMMD;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x42C22E0", Offset = "0x42C12E0", VA = "0x1842C22E0")]
	public LCLBJKFBENI(IEnumerable<TData> GDEJEBLJDEH, bool KMHFOADFHFE = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface KLLIPJABEGE<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<HAEHEBEENKB> EEHKJKGPMKA([In] LCLBJKFBENI<TData> EOPMDOKONFP, CancellationToken DADBOHKBJNO);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class COLMDKANJII<TData> : HPANANNKHKH<KLLIPJABEGE<TData>, HAEHEBEENKB> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly LCLBJKFBENI<TData> IHKMAEEOHPK;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5368840", Offset = "0x5367840", VA = "0x185368840")]
	public COLMDKANJII(IEnumerable<TData> GDEJEBLJDEH, bool KMHFOADFHFE, KLLIPJABEGE<TData> PMALGFDMMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3E03260", Offset = "0x3E02260", VA = "0x183E03260", Slot = "4")]
	public override Task<HAEHEBEENKB> KBOIAJIAKAK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct FBEPOGADIGD<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public readonly T PKMPGPJICGL;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x3C334E0", Offset = "0x3C324E0", VA = "0x183C334E0")]
	public FBEPOGADIGD(T NKAHIPKBDLH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface ANDKMFCODNM<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GGGOOABCOKG([In] FBEPOGADIGD<T> MGJJDKNEECF);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JHLPBHMKJHH();
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface FIMCGHDLKEO<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KBOIAJIAKAK([In] IKAIDFPLNLF<T> LOEFBNAMEIN);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct IKAIDFPLNLF<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public readonly T PKMPGPJICGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public readonly bool PFKNOKHIFGL;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x3ECEE80", Offset = "0x3ECDE80", VA = "0x183ECEE80")]
	public IKAIDFPLNLF(T NKAHIPKBDLH, bool FNJJIDLOOFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class IDDJADCPFIC<T> : PENLDNOKIIJ<ANDKMFCODNM<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x3BBC1B0", Offset = "0x3BBB1B0", VA = "0x183BBC1B0")]
	public IDDJADCPFIC(ANDKMFCODNM<T> PMALGFDMMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x3EBEB40", Offset = "0x3EBDB40", VA = "0x183EBEB40", Slot = "4")]
	public override bool KBOIAJIAKAK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class FECFOGEDLCJ<T> : PENLDNOKIIJ<ANDKMFCODNM<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly FBEPOGADIGD<T> MGJJDKNEECF;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x3C3F930", Offset = "0x3C3E930", VA = "0x183C3F930")]
	public FECFOGEDLCJ(T PKMPGPJICGL, ANDKMFCODNM<T> PMALGFDMMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x37DFC30", Offset = "0x37DEC30", VA = "0x1837DFC30", Slot = "4")]
	public override bool KBOIAJIAKAK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class LPDGDBCBHGA<T> : PENLDNOKIIJ<FIMCGHDLKEO<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly IKAIDFPLNLF<T> LOEFBNAMEIN;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x430CA50", Offset = "0x430BA50", VA = "0x18430CA50")]
	public LPDGDBCBHGA(T PKMPGPJICGL, bool FNJJIDLOOFC, FIMCGHDLKEO<T> PMALGFDMMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x37DFC30", Offset = "0x37DEC30", VA = "0x1837DFC30", Slot = "4")]
	public override bool KBOIAJIAKAK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct PAPBGBLNHIL<TData> where TData : notnull, HAJLBODMFAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public IEnumerable<TData> EPFFEKDEMIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public bool POIJMOLLCAH;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x475FF90", Offset = "0x475EF90", VA = "0x18475FF90")]
	public PAPBGBLNHIL(IEnumerable<TData> LKGJNPKEJLF, bool IIFCEANDIPP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct NFHELECAICJ<TData> where TData : notnull, HAJLBODMFAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public List<TData> EPFFEKDEMIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public List<bool> FDJEPHFDEHH;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4566FD0", Offset = "0x4565FD0", VA = "0x184566FD0")]
	public NFHELECAICJ(List<TData> LKGJNPKEJLF, List<bool> IMIIAPIMEDG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface HAJLBODMFAO
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool BHEKOEONKPL
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
public interface CMJHDMBINKN<TData> where TData : HAJLBODMFAO
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KBOIAJIAKAK([In] PAPBGBLNHIL<TData> MCPMNKFHCDM);

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KBOIAJIAKAK([In] NFHELECAICJ<TData> MCPMNKFHCDM);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface GNMPMJPMBPN<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KPJAPAIEKEC(T PKMPGPJICGL);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class AOLIIAJIKFH<TData> : PENLDNOKIIJ<CMJHDMBINKN<TData>> where TData : notnull, HAJLBODMFAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly PAPBGBLNHIL<TData> MCPMNKFHCDM;

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x3E88880", Offset = "0x3E87880", VA = "0x183E88880")]
	public AOLIIAJIKFH(List<TData> GDEJEBLJDEH, bool POIJMOLLCAH, CMJHDMBINKN<TData> PMALGFDMMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x37DFC30", Offset = "0x37DEC30", VA = "0x1837DFC30", Slot = "4")]
	public override bool KBOIAJIAKAK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class PONBENHECCH<TData> : PENLDNOKIIJ<CMJHDMBINKN<TData>> where TData : notnull, HAJLBODMFAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly NFHELECAICJ<TData> MCPMNKFHCDM;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x47B7670", Offset = "0x47B6670", VA = "0x1847B7670")]
	public PONBENHECCH(List<TData> GDEJEBLJDEH, List<bool> FDJEPHFDEHH, CMJHDMBINKN<TData> PMALGFDMMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x3800520", Offset = "0x37FF520", VA = "0x183800520", Slot = "4")]
	public override bool KBOIAJIAKAK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface CIOMFAFEHOF<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<HAEHEBEENKB> KBOIAJIAKAK(MJCIHGBIJMC<TData> BONACGFFABK);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public class AIKHBFLOCLE<TData> : HPANANNKHKH<CIOMFAFEHOF<TData>, HAEHEBEENKB> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct MGMCPIHNCEK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public AsyncTaskMethodBuilder<HAEHEBEENKB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public AIKHBFLOCLE<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter<HAEHEBEENKB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x44EA5D0", Offset = "0x44E95D0", VA = "0x1844EA5D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x44EA8C0", Offset = "0x44E98C0", VA = "0x1844EA8C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly MJCIHGBIJMC<TData> KLLHGOINAFO;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x3D7EBB0", Offset = "0x3D7DBB0", VA = "0x183D7EBB0")]
	public AIKHBFLOCLE(TData IPMLNKNONLN, IReadOnlyList<TData> BLBOEDAMONE, bool KMHFOADFHFE, CIOMFAFEHOF<TData> PMALGFDMMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x3D7EAB0", Offset = "0x3D7DAB0", VA = "0x183D7EAB0", Slot = "4")]
	[AsyncStateMachine(typeof(AIKHBFLOCLE<>.MGMCPIHNCEK))]
	public override Task<HAEHEBEENKB> KBOIAJIAKAK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public struct MJCIHGBIJMC<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public TData KEFOFADOGEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public IReadOnlyList<TData> JHOPLJOLCEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public bool PCCAJEBGMMD;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x44F2A80", Offset = "0x44F1A80", VA = "0x1844F2A80")]
	public MJCIHGBIJMC(TData IPMLNKNONLN, IReadOnlyList<TData> BLBOEDAMONE, bool KMHFOADFHFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface IILCDDADIGN<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KBOIAJIAKAK([In] POFHEHDCOJB<TData> DNEDCBEKFII);
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface IAEKHFGLAAH<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KBOIAJIAKAK([In] IBJGJHMGIPO<TData> DNEDCBEKFII);
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface AFGLDMIPIMB<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MMJHLMPBDMP([In] NIOABCOJHMB<TData> DNEDCBEKFII);

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JHLPBHMKJHH();
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class PMOBHGPBPGO<TData> : PENLDNOKIIJ<IILCDDADIGN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly POFHEHDCOJB<TData> DNEDCBEKFII;

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x47B1E50", Offset = "0x47B0E50", VA = "0x1847B1E50")]
	public PMOBHGPBPGO(IEnumerable<TData> GDEJEBLJDEH, MFEJNOLPLDN MKAJENPGJDK, BDKEFENGGMG EGLABJPOFKK, float CMMGDJGCDKF, bool KMHFOADFHFE, IILCDDADIGN<TData> PMALGFDMMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x37DFC30", Offset = "0x37DEC30", VA = "0x1837DFC30", Slot = "4")]
	public override bool KBOIAJIAKAK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class CEGOJFHAFBK<TData> : PENLDNOKIIJ<IAEKHFGLAAH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly IBJGJHMGIPO<TData> DNEDCBEKFII;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x50607E0", Offset = "0x505F7E0", VA = "0x1850607E0")]
	public CEGOJFHAFBK(TData[] GDEJEBLJDEH, MFEJNOLPLDN[] MKAJENPGJDK, BDKEFENGGMG[] EGLABJPOFKK, float[] CMMGDJGCDKF, IAEKHFGLAAH<TData> PMALGFDMMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x4EBA7E0", Offset = "0x4EB97E0", VA = "0x184EBA7E0", Slot = "4")]
	public override bool KBOIAJIAKAK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class CLGODALFHFI<TData> : PENLDNOKIIJ<AFGLDMIPIMB<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3BBC1B0", Offset = "0x3BBB1B0", VA = "0x183BBC1B0")]
	public CLGODALFHFI(AFGLDMIPIMB<TData> PMALGFDMMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x525A970", Offset = "0x5259970", VA = "0x18525A970", Slot = "4")]
	public override bool KBOIAJIAKAK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class BPAOKLIBKNI<TData> : PENLDNOKIIJ<AFGLDMIPIMB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly NIOABCOJHMB<TData> DNEDCBEKFII;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x4EBA8A0", Offset = "0x4EB98A0", VA = "0x184EBA8A0")]
	public BPAOKLIBKNI(IEnumerable<TData> GDEJEBLJDEH, MFEJNOLPLDN MKAJENPGJDK, BDKEFENGGMG EGLABJPOFKK, float CMMGDJGCDKF, AFGLDMIPIMB<TData> PMALGFDMMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x4EBA7E0", Offset = "0x4EB97E0", VA = "0x184EBA7E0", Slot = "4")]
	public override bool KBOIAJIAKAK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public struct POFHEHDCOJB<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public IEnumerable<TData> EPFFEKDEMIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public MFEJNOLPLDN POKBFINKFOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public BDKEFENGGMG BOCAFGJDKKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public float CMMGDJGCDKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public bool KMHFOADFHFE;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x47B4210", Offset = "0x47B3210", VA = "0x1847B4210")]
	public POFHEHDCOJB(IEnumerable<TData> GDEJEBLJDEH, MFEJNOLPLDN MKAJENPGJDK, BDKEFENGGMG EGLABJPOFKK, float CMMGDJGCDKF, bool KMHFOADFHFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct IBJGJHMGIPO<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public TData[] EPFFEKDEMIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public MFEJNOLPLDN[] POKBFINKFOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public BDKEFENGGMG[] BOCAFGJDKKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public float[] CMMGDJGCDKF;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3EB6CD0", Offset = "0x3EB5CD0", VA = "0x183EB6CD0")]
	public IBJGJHMGIPO(TData[] GDEJEBLJDEH, MFEJNOLPLDN[] MKAJENPGJDK, BDKEFENGGMG[] EGLABJPOFKK, float[] CMMGDJGCDKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public struct NIOABCOJHMB<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public IEnumerable<TData> EPFFEKDEMIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public MFEJNOLPLDN POKBFINKFOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public BDKEFENGGMG BOCAFGJDKKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public float CMMGDJGCDKF;

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x4585350", Offset = "0x4584350", VA = "0x184585350")]
	public NIOABCOJHMB(IEnumerable<TData> GDEJEBLJDEH, MFEJNOLPLDN MKAJENPGJDK, BDKEFENGGMG EGLABJPOFKK, float CMMGDJGCDKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public interface PBNGHMPNBCJ<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LIHHEOEEHLB([In] LGBFBHBBFLK<TData> EOPMDOKONFP);

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GNOLILHADPA([In] LGBFBHBBFLK<TData> EOPMDOKONFP);

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ACNBABIMPFG([In] bool KBLKNAEDMDH);

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool EPJPJKLBJHO([In] LGBFBHBBFLK<TData> EOPMDOKONFP);

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ALPNCEGANCI();

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool HJJAFLHGEMO([In] TData EDAAKLFECOJ);
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class FIAEIGFDFNL<TData> : PENLDNOKIIJ<PBNGHMPNBCJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly LGBFBHBBFLK<TData> EOPMDOKONFP;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x3C43140", Offset = "0x3C42140", VA = "0x183C43140")]
	public FIAEIGFDFNL(List<TData> ONEIHMPFJKE, PBNGHMPNBCJ<TData> PMALGFDMMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x37DFC30", Offset = "0x37DEC30", VA = "0x1837DFC30", Slot = "4")]
	public override bool KBOIAJIAKAK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class BCGDPGAIJHD<TData> : PENLDNOKIIJ<PBNGHMPNBCJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3BBC1B0", Offset = "0x3BBB1B0", VA = "0x183BBC1B0")]
	public BCGDPGAIJHD(PBNGHMPNBCJ<TData> PMALGFDMMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x4E757C0", Offset = "0x4E747C0", VA = "0x184E757C0", Slot = "4")]
	public override bool KBOIAJIAKAK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class EOOPNKEILHA<TData> : PENLDNOKIIJ<PBNGHMPNBCJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly bool KMHFOADFHFE;

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x38575D0", Offset = "0x38565D0", VA = "0x1838575D0")]
	public EOOPNKEILHA(bool KMHFOADFHFE, PBNGHMPNBCJ<TData> PMALGFDMMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3857570", Offset = "0x3856570", VA = "0x183857570", Slot = "4")]
	public override bool KBOIAJIAKAK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class EEBHCOAKIAK<TData> : PENLDNOKIIJ<PBNGHMPNBCJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly LGBFBHBBFLK<TData> EOPMDOKONFP;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x38005E0", Offset = "0x37FF5E0", VA = "0x1838005E0")]
	public EEBHCOAKIAK(List<TData> ONEIHMPFJKE, bool KMHFOADFHFE, PBNGHMPNBCJ<TData> PMALGFDMMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3800520", Offset = "0x37FF520", VA = "0x183800520", Slot = "4")]
	public override bool KBOIAJIAKAK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class LKLAAJMMMFJ<TData> : PENLDNOKIIJ<PBNGHMPNBCJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly TData EDAAKLFECOJ;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x42EA6A0", Offset = "0x42E96A0", VA = "0x1842EA6A0")]
	public LKLAAJMMMFJ(TData EDAAKLFECOJ, PBNGHMPNBCJ<TData> PMALGFDMMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x42EA5D0", Offset = "0x42E95D0", VA = "0x1842EA5D0", Slot = "4")]
	public override bool KBOIAJIAKAK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class DAPPEHKDDMJ<TData> : PENLDNOKIIJ<PBNGHMPNBCJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly LGBFBHBBFLK<TData> EOPMDOKONFP;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x57F5030", Offset = "0x57F4030", VA = "0x1857F5030")]
	public DAPPEHKDDMJ(IEnumerable<TData> ONEIHMPFJKE, PBNGHMPNBCJ<TData> PMALGFDMMMA, bool KMHFOADFHFE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x57F4EB0", Offset = "0x57F3EB0", VA = "0x1857F4EB0", Slot = "4")]
	public override bool KBOIAJIAKAK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public struct LGBFBHBBFLK<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public IEnumerable<TData> EPFFEKDEMIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public bool KMHFOADFHFE;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x42CADB0", Offset = "0x42C9DB0", VA = "0x1842CADB0")]
	public LGBFBHBBFLK(IEnumerable<TData> LKGJNPKEJLF, bool FCDPCOMNPPC = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public interface GCENNHJGALI
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<HAEHEBEENKB> KBOIAJIAKAK(IGGNGOCBCAC KDPCDIJFCNC);
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class GLMJNBHNECA : HPANANNKHKH<GCENNHJGALI, HAEHEBEENKB>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private struct OKJIIIKIMJN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public AsyncTaskMethodBuilder<HAEHEBEENKB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public GLMJNBHNECA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private TaskAwaiter<HAEHEBEENKB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x69B3220", Offset = "0x69B2220", VA = "0x1869B3220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x69B34A0", Offset = "0x69B24A0", VA = "0x1869B34A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly IGGNGOCBCAC DOEEDLJDJAP;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x69B30B0", Offset = "0x69B20B0", VA = "0x1869B30B0")]
	public GLMJNBHNECA(bool KMHFOADFHFE, GCENNHJGALI PMALGFDMMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x69B2FC0", Offset = "0x69B1FC0", VA = "0x1869B2FC0", Slot = "4")]
	[AsyncStateMachine(typeof(OKJIIIKIMJN))]
	public override Task<HAEHEBEENKB> KBOIAJIAKAK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct IGGNGOCBCAC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public bool PCCAJEBGMMD;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x217F560", Offset = "0x217E560", VA = "0x18217F560")]
	public IGGNGOCBCAC(bool KMHFOADFHFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public readonly struct KJAEBEOJDIN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly bool CBBBKJFEKNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly bool GAIBJNDPGIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public readonly bool GNMLLHFGICG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public readonly bool KMHFOADFHFE;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4CFDE40", Offset = "0x4CFCE40", VA = "0x184CFDE40")]
	public KJAEBEOJDIN(bool CBBBKJFEKNI, bool GAIBJNDPGIN, bool GNMLLHFGICG, bool KMHFOADFHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x69B3150", Offset = "0x69B2150", VA = "0x1869B3150")]
	public KJAEBEOJDIN(bool GAIBJNDPGIN, bool KMHFOADFHFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface BAKFGNJHAJG
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HMBJHAAEOPG(KJAEBEOJDIN DBODAKLKAFK);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MIHJIEHFKNN(KJAEBEOJDIN DBODAKLKAFK);
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class ELNMLJFLELB : PENLDNOKIIJ<BAKFGNJHAJG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly KJAEBEOJDIN DBODAKLKAFK;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x69B2F30", Offset = "0x69B1F30", VA = "0x1869B2F30")]
	public ELNMLJFLELB(bool DNPKMJFBJBC, bool GAIBJNDPGIN, bool GNMLLHFGICG, bool KMHFOADFHFE, BAKFGNJHAJG PMALGFDMMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x69B2EE0", Offset = "0x69B1EE0", VA = "0x1869B2EE0", Slot = "4")]
	public override bool KBOIAJIAKAK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class DDHEINHHHMO : PENLDNOKIIJ<BAKFGNJHAJG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly KJAEBEOJDIN DBODAKLKAFK;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x69B2D30", Offset = "0x69B1D30", VA = "0x1869B2D30")]
	public DDHEINHHHMO(bool GAIBJNDPGIN, bool KMHFOADFHFE, BAKFGNJHAJG PMALGFDMMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x69B2CE0", Offset = "0x69B1CE0", VA = "0x1869B2CE0", Slot = "4")]
	public override bool KBOIAJIAKAK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public interface BMAOJEJOBGA
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KBOIAJIAKAK([In] BCMKDBDJAHN AKPOAFFMGBD);
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class AADAKFHJDKC : PENLDNOKIIJ<BMAOJEJOBGA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly BCMKDBDJAHN AKPOAFFMGBD;

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x69B22B0", Offset = "0x69B12B0", VA = "0x1869B22B0")]
	public AADAKFHJDKC(Guid[] HOJMEFOOLEI, Vector3[] DELJCEKPCIN, Quaternion[] DMHIKIGFPHI, float[] OLPJEADMLBL, Dictionary<Guid, Vector3> MDDMLBFMEJB, BMAOJEJOBGA PMALGFDMMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x69B2200", Offset = "0x69B1200", VA = "0x1869B2200", Slot = "4")]
	public override bool KBOIAJIAKAK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public interface POAPELICJMB<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GGGOOABCOKG([In] HHCBNHBLDGO<TData> APILJIIHLDC);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MMJHLMPBDMP([In] EJPAIMLNBNN PAPLJKAAINL);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MMJHLMPBDMP([In] NOPECGLCDOE PAPLJKAAINL);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JHLPBHMKJHH();
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class NNCDHIJFGPF<TData> : PENLDNOKIIJ<POAPELICJMB<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x3BBC1B0", Offset = "0x3BBB1B0", VA = "0x183BBC1B0")]
	public NNCDHIJFGPF(POAPELICJMB<TData> PMALGFDMMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x45AA200", Offset = "0x45A9200", VA = "0x1845AA200", Slot = "4")]
	public override bool KBOIAJIAKAK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class NFGCOJLMCEP<TData> : PENLDNOKIIJ<POAPELICJMB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly EJPAIMLNBNN BDINOABHMNH;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x4566F30", Offset = "0x4565F30", VA = "0x184566F30")]
	public NFGCOJLMCEP(Vector3 FOCIFPOLANJ, bool ADNADFJPKLH, POAPELICJMB<TData> PMALGFDMMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x3814CA0", Offset = "0x3813CA0", VA = "0x183814CA0", Slot = "4")]
	public override bool KBOIAJIAKAK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class DPBPCICPBKM<TData> : PENLDNOKIIJ<POAPELICJMB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly NOPECGLCDOE BDINOABHMNH;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x586A7D0", Offset = "0x58697D0", VA = "0x18586A7D0")]
	public DPBPCICPBKM(Guid FFMBCLIGDBC, int LLPJHIPCNFD, Vector3 MOIICCIPACK, Quaternion ADNGPFKNGFI, float AMCMIGCLHDD, bool ADNADFJPKLH, POAPELICJMB<TData> PMALGFDMMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x586A770", Offset = "0x5869770", VA = "0x18586A770", Slot = "4")]
	public override bool KBOIAJIAKAK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class PGBGCDPKAIA<TData> : PENLDNOKIIJ<POAPELICJMB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly HHCBNHBLDGO<TData> BDINOABHMNH;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x4774950", Offset = "0x4773950", VA = "0x184774950")]
	public PGBGCDPKAIA(TData PKMPGPJICGL, bool KMHFOADFHFE, POAPELICJMB<TData> PMALGFDMMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x37DFC30", Offset = "0x37DEC30", VA = "0x1837DFC30", Slot = "4")]
	public override bool KBOIAJIAKAK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public struct EJPAIMLNBNN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly Vector3 FOCIFPOLANJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public readonly bool ADNADFJPKLH;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x69B2DB0", Offset = "0x69B1DB0", VA = "0x1869B2DB0")]
	public EJPAIMLNBNN(Vector3 FOCIFPOLANJ, bool ADNADFJPKLH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public struct NOPECGLCDOE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public readonly Guid FFMBCLIGDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public readonly int LLPJHIPCNFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public readonly Vector3 MOIICCIPACK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public readonly Quaternion ADNGPFKNGFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public readonly float AMCMIGCLHDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public readonly bool ADNADFJPKLH;

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x69B3160", Offset = "0x69B2160", VA = "0x1869B3160")]
	public NOPECGLCDOE(Guid FFMBCLIGDBC, int LLPJHIPCNFD, Vector3 MOIICCIPACK, Quaternion ADNGPFKNGFI, float AMCMIGCLHDD, bool ADNADFJPKLH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public struct HHCBNHBLDGO<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public readonly TData PKMPGPJICGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public readonly bool KMHFOADFHFE;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x3DE9BC0", Offset = "0x3DE8BC0", VA = "0x183DE9BC0")]
	public HHCBNHBLDGO(TData PKMPGPJICGL, bool KMHFOADFHFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public interface CLHJIDFMHDK<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KBOIAJIAKAK([In] IHLICBKBMIH<TData> FJMIMGNFLKO);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KBOIAJIAKAK([In] DFFJKJIGADC<TData> FJMIMGNFLKO);
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public interface BOAHNOAPKFH<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GGGOOABCOKG([In] AFLEGIDGENL<TData> FOBNGCPANLO);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MMJHLMPBDMP([In] PGBAJGMPIDC PAPLJKAAINL);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JHLPBHMKJHH();
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class FKLCGBEMIMF<TData> : PENLDNOKIIJ<CLHJIDFMHDK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly IHLICBKBMIH<TData> FJMIMGNFLKO;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x3C617C0", Offset = "0x3C607C0", VA = "0x183C617C0")]
	public FKLCGBEMIMF(IEnumerable<TData> GDEJEBLJDEH, Vector3 LCMHBFFBMAA, bool KMHFOADFHFE, CLHJIDFMHDK<TData> PMALGFDMMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x37DFC30", Offset = "0x37DEC30", VA = "0x1837DFC30", Slot = "4")]
	public override bool KBOIAJIAKAK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class KFOFLCHNMKB<TData> : PENLDNOKIIJ<BOAHNOAPKFH<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x3BBC1B0", Offset = "0x3BBB1B0", VA = "0x183BBC1B0")]
	public KFOFLCHNMKB(BOAHNOAPKFH<TData> PMALGFDMMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x412AA20", Offset = "0x4129A20", VA = "0x18412AA20", Slot = "4")]
	public override bool KBOIAJIAKAK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class OLFEFENDAAM<TData> : PENLDNOKIIJ<BOAHNOAPKFH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly AFLEGIDGENL<TData> FJMIMGNFLKO;

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x46B8330", Offset = "0x46B7330", VA = "0x1846B8330")]
	public OLFEFENDAAM(IEnumerable<TData> GDEJEBLJDEH, bool KMHFOADFHFE, BOAHNOAPKFH<TData> PMALGFDMMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x37DFC30", Offset = "0x37DEC30", VA = "0x1837DFC30", Slot = "4")]
	public override bool KBOIAJIAKAK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class NCEGEAKNPHB<TData> : PENLDNOKIIJ<CLHJIDFMHDK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly DFFJKJIGADC<TData> FJMIMGNFLKO;

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x455D280", Offset = "0x455C280", VA = "0x18455D280")]
	public NCEGEAKNPHB(IEnumerable<TData> GDEJEBLJDEH, Vector3 BBFBBJFMGLA, PMIDIFCPDAI KLADCNMINJF, bool KMHFOADFHFE, CLHJIDFMHDK<TData> PMALGFDMMMA, Space DPLJEIGPHDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x42C0AD0", Offset = "0x42BFAD0", VA = "0x1842C0AD0", Slot = "4")]
	public override bool KBOIAJIAKAK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class LCCCJFKHBDF<TData> : PENLDNOKIIJ<BOAHNOAPKFH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly PGBAJGMPIDC FJMIMGNFLKO;

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x42C1A90", Offset = "0x42C0A90", VA = "0x1842C1A90")]
	public LCCCJFKHBDF(Vector3 LCMHBFFBMAA, BOAHNOAPKFH<TData> PMALGFDMMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x3814CA0", Offset = "0x3813CA0", VA = "0x183814CA0", Slot = "4")]
	public override bool KBOIAJIAKAK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct IHLICBKBMIH<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public readonly IEnumerable<TData> GDEJEBLJDEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public readonly Vector3 LCMHBFFBMAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public readonly bool KMHFOADFHFE;

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x3ECCF50", Offset = "0x3ECBF50", VA = "0x183ECCF50")]
	public IHLICBKBMIH(IEnumerable<TData> GDEJEBLJDEH, Vector3 LCMHBFFBMAA, bool KMHFOADFHFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct AFLEGIDGENL<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public readonly IEnumerable<TData> GDEJEBLJDEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public readonly bool KMHFOADFHFE;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x3CEE380", Offset = "0x3CED380", VA = "0x183CEE380")]
	public AFLEGIDGENL(IEnumerable<TData> GDEJEBLJDEH, bool KMHFOADFHFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct DFFJKJIGADC<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public readonly IEnumerable<TData> GDEJEBLJDEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public readonly Vector3 BBFBBJFMGLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly PMIDIFCPDAI KLADCNMINJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public readonly bool KMHFOADFHFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly Space DPLJEIGPHDP;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x57F8510", Offset = "0x57F7510", VA = "0x1857F8510")]
	public DFFJKJIGADC(IEnumerable<TData> GDEJEBLJDEH, Vector3 BBFBBJFMGLA, PMIDIFCPDAI KLADCNMINJF, bool KMHFOADFHFE, Space DPLJEIGPHDP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct PGBAJGMPIDC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public readonly Vector3 LCMHBFFBMAA;

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x2181400", Offset = "0x2180400", VA = "0x182181400")]
	public PGBAJGMPIDC(Vector3 LCMHBFFBMAA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public enum PMIDIFCPDAI
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
[Cpp2IlInjected.Token(Token = "0x2000073")]
public interface IKGLGNNFLOB
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KBOIAJIAKAK([In] PBKEDFKFAHB NJIPPKFHMNF);
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public class ELGCIBNKMLK : PENLDNOKIIJ<IKGLGNNFLOB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly PBKEDFKFAHB NJIPPKFHMNF;

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x69B2E80", Offset = "0x69B1E80", VA = "0x1869B2E80")]
	public ELGCIBNKMLK(bool KMHFOADFHFE, IKGLGNNFLOB PMALGFDMMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x69B2DD0", Offset = "0x69B1DD0", VA = "0x1869B2DD0", Slot = "4")]
	public override bool KBOIAJIAKAK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public readonly struct PBKEDFKFAHB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public readonly bool KMHFOADFHFE;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x217F560", Offset = "0x217E560", VA = "0x18217F560")]
	public PBKEDFKFAHB(bool KMHFOADFHFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public interface LBFPEDNBBND<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KBOIAJIAKAK([In] MFLCMPNNODI<TData> NIOGJGNCPBN);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KBOIAJIAKAK([In] DGJKAFOGIOP<TData> NIOGJGNCPBN);
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public interface DPMDDDGHCEB<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GGGOOABCOKG([In] DGPBCNPIJGB<TData> APILJIIHLDC);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MMJHLMPBDMP([In] PNNGLOJEHFG PAPLJKAAINL);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JHLPBHMKJHH();
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class HHGGHDJADEJ<TData> : PENLDNOKIIJ<LBFPEDNBBND<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly MFLCMPNNODI<TData> NIOGJGNCPBN;

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x3DEAED0", Offset = "0x3DE9ED0", VA = "0x183DEAED0")]
	public HHGGHDJADEJ(IEnumerable<TData> GDEJEBLJDEH, Quaternion LCMHBFFBMAA, Vector3? OLHNLAAHHHJ, bool NKIMNDGNOFF, bool KMHFOADFHFE, LBFPEDNBBND<TData> PMALGFDMMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x37DFC30", Offset = "0x37DEC30", VA = "0x1837DFC30", Slot = "4")]
	public override bool KBOIAJIAKAK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class JMDDKNDMDJE<TData> : PENLDNOKIIJ<DPMDDDGHCEB<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x3BBC1B0", Offset = "0x3BBB1B0", VA = "0x183BBC1B0")]
	public JMDDKNDMDJE(DPMDDDGHCEB<TData> PMALGFDMMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x412AA20", Offset = "0x4129A20", VA = "0x18412AA20", Slot = "4")]
	public override bool KBOIAJIAKAK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class ENEJKLEOFFE<TData> : PENLDNOKIIJ<DPMDDDGHCEB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly DGPBCNPIJGB<TData> NIOGJGNCPBN;

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x3853530", Offset = "0x3852530", VA = "0x183853530")]
	public ENEJKLEOFFE(IEnumerable<TData> GDEJEBLJDEH, bool KMHFOADFHFE, DPMDDDGHCEB<TData> PMALGFDMMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x37DFC30", Offset = "0x37DEC30", VA = "0x1837DFC30", Slot = "4")]
	public override bool KBOIAJIAKAK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class LBEJHGCNKKL<TData> : PENLDNOKIIJ<LBFPEDNBBND<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly DGJKAFOGIOP<TData> NIOGJGNCPBN;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x42C0BA0", Offset = "0x42BFBA0", VA = "0x1842C0BA0")]
	public LBEJHGCNKKL(IEnumerable<TData> GDEJEBLJDEH, Quaternion KGNMJDNIGAC, PMIDIFCPDAI LCONBDBAPFK, Vector3? OLHNLAAHHHJ, bool NKIMNDGNOFF, bool KMHFOADFHFE, Space DPLJEIGPHDP, LBFPEDNBBND<TData> PMALGFDMMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x42C0AD0", Offset = "0x42BFAD0", VA = "0x1842C0AD0", Slot = "4")]
	public override bool KBOIAJIAKAK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class EJJIFLLGNIO<TData> : PENLDNOKIIJ<DPMDDDGHCEB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly PNNGLOJEHFG NIOGJGNCPBN;

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x3814D00", Offset = "0x3813D00", VA = "0x183814D00")]
	public EJJIFLLGNIO(Quaternion LCMHBFFBMAA, Vector3? OLHNLAAHHHJ, bool NKIMNDGNOFF, DPMDDDGHCEB<TData> PMALGFDMMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x3814CA0", Offset = "0x3813CA0", VA = "0x183814CA0", Slot = "4")]
	public override bool KBOIAJIAKAK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public struct MFLCMPNNODI<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public readonly IEnumerable<TData> GDEJEBLJDEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public readonly Quaternion LCMHBFFBMAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public readonly Vector3? OLHNLAAHHHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public readonly bool NKIMNDGNOFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public readonly bool KMHFOADFHFE;

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x44E6230", Offset = "0x44E5230", VA = "0x1844E6230")]
	public MFLCMPNNODI(IEnumerable<TData> GDEJEBLJDEH, Quaternion LCMHBFFBMAA, Vector3? OLHNLAAHHHJ, bool NKIMNDGNOFF, bool KMHFOADFHFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public struct DGPBCNPIJGB<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public readonly IEnumerable<TData> GDEJEBLJDEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly bool KMHFOADFHFE;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x57FA2D0", Offset = "0x57F92D0", VA = "0x1857FA2D0")]
	public DGPBCNPIJGB(IEnumerable<TData> GDEJEBLJDEH, bool KMHFOADFHFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public struct DGJKAFOGIOP<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public readonly IEnumerable<TData> GDEJEBLJDEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public readonly Quaternion KGNMJDNIGAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public readonly PMIDIFCPDAI LCONBDBAPFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public readonly Vector3? OLHNLAAHHHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public readonly bool NKIMNDGNOFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public readonly bool KMHFOADFHFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public readonly Space DPLJEIGPHDP;

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x57F9FF0", Offset = "0x57F8FF0", VA = "0x1857F9FF0")]
	public DGJKAFOGIOP(IEnumerable<TData> GDEJEBLJDEH, Quaternion KGNMJDNIGAC, PMIDIFCPDAI LCONBDBAPFK, Vector3? OLHNLAAHHHJ, bool NKIMNDGNOFF, bool KMHFOADFHFE, Space DPLJEIGPHDP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public struct PNNGLOJEHFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public readonly Quaternion LCMHBFFBMAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public readonly Vector3? OLHNLAAHHHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public readonly bool NKIMNDGNOFF;

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x4CC23C0", Offset = "0x4CC13C0", VA = "0x184CC23C0")]
	public PNNGLOJEHFG(Quaternion LCMHBFFBMAA, Vector3? OLHNLAAHHHJ, bool NKIMNDGNOFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public interface GPOKKAHGIGJ<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GGGOOABCOKG([In] EOOHELKBLCA<TData> APILJIIHLDC);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MMJHLMPBDMP([In] OFCCNLKCHCB PAPLJKAAINL);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MMJHLMPBDMP([In] BFLEBNHFAOH PAPLJKAAINL);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MMJHLMPBDMP([In] JPGPBBOBNKC PAPLJKAAINL);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool JHLPBHMKJHH();
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public class ANCBCDBGNJJ<TData> : PENLDNOKIIJ<GPOKKAHGIGJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly JPGPBBOBNKC OBDPNDHKOAM;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x3E81D90", Offset = "0x3E80D90", VA = "0x183E81D90")]
	public ANCBCDBGNJJ(Vector3 GAHIJONCCDF, float BELNDHOBICH, Vector3 OLHNLAAHHHJ, bool FJJMFINDFLI, bool JACEMPGJING, GPOKKAHGIGJ<TData> PMALGFDMMMA, Space DPLJEIGPHDP = Space.Self)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x3E81D30", Offset = "0x3E80D30", VA = "0x183E81D30", Slot = "4")]
	public override bool KBOIAJIAKAK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public class CHACIFLKFIJ<TData> : PENLDNOKIIJ<GPOKKAHGIGJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x3BBC1B0", Offset = "0x3BBB1B0", VA = "0x183BBC1B0")]
	public CHACIFLKFIJ(GPOKKAHGIGJ<TData> PMALGFDMMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x5166B60", Offset = "0x5165B60", VA = "0x185166B60", Slot = "4")]
	public override bool KBOIAJIAKAK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class AHILGAILPEF<TData> : PENLDNOKIIJ<GPOKKAHGIGJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly EOOHELKBLCA<TData> OBDPNDHKOAM;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x3D7E1F0", Offset = "0x3D7D1F0", VA = "0x183D7E1F0")]
	public AHILGAILPEF(IEnumerable<TData> GDEJEBLJDEH, bool KMHFOADFHFE, GPOKKAHGIGJ<TData> PMALGFDMMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x37DFC30", Offset = "0x37DEC30", VA = "0x1837DFC30", Slot = "4")]
	public override bool KBOIAJIAKAK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class KHJADIIPIBK<TData> : PENLDNOKIIJ<GPOKKAHGIGJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly BFLEBNHFAOH OBDPNDHKOAM;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x421D3D0", Offset = "0x421C3D0", VA = "0x18421D3D0")]
	public KHJADIIPIBK(float DILKFFAGLJP, bool JKENBHJINBO, Vector3 OLHNLAAHHHJ, GPOKKAHGIGJ<TData> PMALGFDMMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x421D300", Offset = "0x421C300", VA = "0x18421D300", Slot = "4")]
	public override bool KBOIAJIAKAK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class BEGLBDEOFLP<TData> : PENLDNOKIIJ<GPOKKAHGIGJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly OFCCNLKCHCB OBDPNDHKOAM;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x4E7A5B0", Offset = "0x4E795B0", VA = "0x184E7A5B0")]
	public BEGLBDEOFLP(float BELNDHOBICH, Vector3 OLHNLAAHHHJ, GPOKKAHGIGJ<TData> PMALGFDMMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x3814CA0", Offset = "0x3813CA0", VA = "0x183814CA0", Slot = "4")]
	public override bool KBOIAJIAKAK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public struct JPGPBBOBNKC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public readonly Vector3 GAHIJONCCDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public readonly float BELNDHOBICH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public readonly Vector3 OLHNLAAHHHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public readonly bool ADNADFJPKLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public readonly Space DPLJEIGPHDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public readonly bool JACEMPGJING;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x69B3110", Offset = "0x69B2110", VA = "0x1869B3110")]
	public JPGPBBOBNKC(Vector3 GAHIJONCCDF, float BELNDHOBICH, Vector3 OLHNLAAHHHJ, bool ADNADFJPKLH, bool APKAOCKAMBI, Space DPLJEIGPHDP = Space.Self)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public struct EOOHELKBLCA<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public readonly IEnumerable<TData> GDEJEBLJDEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public readonly bool KMHFOADFHFE;

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x3857080", Offset = "0x3856080", VA = "0x183857080")]
	public EOOHELKBLCA(IEnumerable<TData> GDEJEBLJDEH, bool KMHFOADFHFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct BFLEBNHFAOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public readonly float DILKFFAGLJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public readonly bool JKENBHJINBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public readonly Vector3 OLHNLAAHHHJ;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x69B28F0", Offset = "0x69B18F0", VA = "0x1869B28F0")]
	public BFLEBNHFAOH(float DILKFFAGLJP, bool JKENBHJINBO, Vector3 OLHNLAAHHHJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public struct OFCCNLKCHCB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public readonly float BELNDHOBICH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public readonly Vector3 OLHNLAAHHHJ;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x4C97840", Offset = "0x4C96840", VA = "0x184C97840")]
	public OFCCNLKCHCB(float BELNDHOBICH, Vector3 OLHNLAAHHHJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct BCMKDBDJAHN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public readonly Guid[] GDEJEBLJDEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public readonly bool LJLOGBBDEEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public readonly bool GHELDINGODD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public readonly bool DMADBMLDILG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public readonly Vector3[] DELJCEKPCIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public readonly Quaternion[] DMHIKIGFPHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly float[] OLPJEADMLBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public readonly Dictionary<Guid, Vector3> MDDMLBFMEJB;

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x69B2660", Offset = "0x69B1660", VA = "0x1869B2660")]
	public BCMKDBDJAHN(Guid[] HOJMEFOOLEI, Vector3[] DELJCEKPCIN, Quaternion[] DMHIKIGFPHI, float[] OLPJEADMLBL, Dictionary<Guid, Vector3> MDDMLBFMEJB, bool LJLOGBBDEEJ = true, bool GHELDINGODD = true, bool DMADBMLDILG = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x69B2490", Offset = "0x69B1490", VA = "0x1869B2490")]
	private static void OCNGBBAMKHL(Dictionary<Guid, Vector3> MDDMLBFMEJB, int JAJCCACOLNO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public static class CNNNILHKJHE
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	private struct BADMEHMBOIA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public bool JOIMFBFEADH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public DIIANKCHAHD DHDPDMODHIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public DIIANKCHAHD CAJMIFMGBPC;
	}

	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private static BADMEHMBOIA NLCLJHBJLDH;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static CancellationToken EANNOFDJPJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x69B2BC0", Offset = "0x69B1BC0", VA = "0x1869B2BC0")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	internal static DIIANKCHAHD DHDPDMODHIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x69B2B20", Offset = "0x69B1B20", VA = "0x1869B2B20")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x69B2A60", Offset = "0x69B1A60", VA = "0x1869B2A60")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x69B2BE0", Offset = "0x69B1BE0", VA = "0x1869B2BE0")]
	[PECFDJPHGEK(HCAAGBIMBOB.Room, BOIKMOKIOJG.None)]
	private static void POFEHEPFKAG(DIIANKCHAHD DELHDABLJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x69B2910", Offset = "0x69B1910", VA = "0x1869B2910")]
	public static void FDHFDDAAOOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x69B2AD0", Offset = "0x69B1AD0", VA = "0x1869B2AD0")]
	private static DIIANKCHAHD JHKCKAIEKBM(DIIANKCHAHD HPJLCLBLBCC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public static class CJBEJAGHKOB
{
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public enum POGFDNEKFEK
	{
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		ICreationContextObject,
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		Guid
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x292FB30", Offset = "0x292EB30", VA = "0x18292FB30")]
	public static void HKGDEJODFFN<T>(T MGNNEDNHDBJ, POGFDNEKFEK PBLNJHEPKAE) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x292FAC0", Offset = "0x292EAC0", VA = "0x18292FAC0")]
	public static void HKGDEJODFFN<T>(T MGNNEDNHDBJ) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x292F900", Offset = "0x292E900", VA = "0x18292F900")]
	public static void AKELNDCLOKG<T>(T MGNNEDNHDBJ) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x292FA10", Offset = "0x292EA10", VA = "0x18292FA10")]
	public static T BDJJCDMMBKL<T>(POGFDNEKFEK PBLNJHEPKAE) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x292FC30", Offset = "0x292EC30", VA = "0x18292FC30")]
	public static bool KCOKGBINLEI<T>(POGFDNEKFEK PBLNJHEPKAE, T? LPEIPCLMPEJ, [Out][NotNullWhen(true)][MaybeNullWhen(false)] T GCLHNCKIKBF) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x292FE40", Offset = "0x292EE40", VA = "0x18292FE40")]
	public static bool OEGHEEFPNBN<T>(POGFDNEKFEK PBLNJHEPKAE) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x292F9B0", Offset = "0x292E9B0", VA = "0x18292F9B0")]
	public static T BDJJCDMMBKL<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x292FD80", Offset = "0x292ED80", VA = "0x18292FD80")]
	public static bool KCOKGBINLEI<T>(T LPEIPCLMPEJ, [Out] T GCLHNCKIKBF) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x292F9B0", Offset = "0x292E9B0", VA = "0x18292F9B0")]
	public static bool OEGHEEFPNBN<T>() where T : class
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
internal static class PDNMKAJONKH
{
	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x69B3690", Offset = "0x69B2690", VA = "0x1869B3690")]
	public static void ELOAINHJMHG(IEnumerable GNLOFBLAPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x2CD2250", Offset = "0x2CD1250", VA = "0x182CD2250")]
	public static void ELOAINHJMHG<T>(T[] GGEMIJICFPG) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x2CD2430", Offset = "0x2CD1430", VA = "0x182CD2430")]
	public static void ELOAINHJMHG<T>(T HEJFAMNFDIC) where T : notnull, Enum
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
