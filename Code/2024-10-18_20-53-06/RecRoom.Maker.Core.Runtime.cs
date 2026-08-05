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
		[Cpp2IlInjected.Address(RVA = "0x8D39D0", Offset = "0x8D2DD0", VA = "0x1808D39D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E21680", Offset = "0x6E20A80", VA = "0x186E21680")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8D4610", Offset = "0x8D3A10", VA = "0x1808D4610")]
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
		[Cpp2IlInjected.Address(RVA = "0x8D4650", Offset = "0x8D3A50", VA = "0x1808D4650")]
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
	public class _AssemblyIndex : PPJBMGKOMFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6E21B60", Offset = "0x6E20F60", VA = "0x186E21B60", Slot = "8")]
		public override void JFOOIIGPHCJ(GHGEJHAEAMC registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x648F4C0", Offset = "0x648E8C0", VA = "0x18648F4C0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface IHLGAFCJALK<TData, TReturn>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TReturn AMKMCKAPOBL(TData FMAFBHGACNM);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface KCOIKBKGKMK<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ClearHoverTarget(BDNGOMIGPJL BCKFKPBOJJJ);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool SetHoverTarget(TData KDGMCPCFIID, Collider AEACLPDJJBH, BDNGOMIGPJL BCKFKPBOJJJ, [Optional] OIBFOBLKIEF? OKMCAAAMHFN);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool TryGetHoverTarget([Out] TData KDGMCPCFIID);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetHoverCollider([Out] Collider AEACLPDJJBH);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface BBFJHLGKHHJ<TData> : MHFABAJEAML, PPDJAOMKOJG<TData>, OKBKBDDJNLH<TData>, HJCOPFJIDHL<TData>, CKHFDJBICFD, PELGNGGKOBN<TData>, ODIHEKLKKKH, IAMDJMLOIMJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface PELGNGGKOBN<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 JMGPOCBLPOM, Vector3 PAAGAJJEHGO, float NHDEHMAPALH, [Out] T PCOBGNCFFFP, [Out] Vector3 EICBNLLDDBL, [Out] Collider AEACLPDJJBH);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 JMGPOCBLPOM, Vector3 PAAGAJJEHGO, float NAGFMKHALGO, float NHDEHMAPALH, T[] AEEPDALAKEN, [Out] Vector3 GJJILNKHPEP, [Out] Collider BICGBCDBNMI);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 JMGPOCBLPOM, float NAGFMKHALGO, Vector3 INJAJMHHGPE, T[] AEEPDALAKEN);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetObjectFromColliderInCurrentScope(Collider BHILPBPJHNM, [Out] T AKAEHBOCLIB);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface MHFABAJEAML
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Bounds LOFIMIMKIAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Transform KECIGCGDLDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Bounds IEHCPELNBGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Transform ALABPGKMJMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Vector3 KFMAAAEEEBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool NOHJNIJEPBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void SetSelectionBoundsDirty(bool NOFCNHFIAKJ = true, int DFPDKDNEPML = 0);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ShouldHideSelectionBoundsPreview(bool FDJGPOMFFAD, object ABHFNNFMPHA);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface IAMDJMLOIMJ
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	LDNMACGBDLI JMEHGPGBAEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface EOJOBHEFEJC
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool KKLEMOBDEIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool GCPJPDFMLBM
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool PHKGCJAOADK
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
	void TrySetPreviousCloneMapping(Dictionary<Guid, Guid> FAGCIOKMKCB);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface HJCOPFJIDHL<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool BMEJJCOABDL
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int PMBKPDDDOOB
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<TData> ALHFNBKGHML
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData HHDONFMCNBA);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData HHDONFMCNBA);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface PPDJAOMKOJG<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T FMAFBHGACNM, [Optional] OIBFOBLKIEF? HOJKJKJCBGO, bool EIGBNHDKHFO = true);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int HMELIAGANNM, IEnumerable<T> JJGPKFAMMFF, bool EIGBNHDKHFO = true);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int HMELIAGANNM, IEnumerable<T> JJGPKFAMMFF, OIBFOBLKIEF HOJKJKJCBGO, bool EIGBNHDKHFO = true);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface ODIHEKLKKKH
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface CKHFDJBICFD
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool IHNEBDKHBBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool JPIOHEAHPNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool EKOEOPCLKAE
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool JLGCONEKAGF
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class BFJMPBGBOJP<TReceiver> : CKDHCPHELOB<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3B4C4D0", Offset = "0x3B4B8D0", VA = "0x183B4C4D0")]
	public BFJMPBGBOJP(TReceiver JEMODPNNLCP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public abstract class KOJOMBLLECK<TReceiver, TFromTask> : CKDHCPHELOB<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3B4C4D0", Offset = "0x3B4B8D0", VA = "0x183B4C4D0")]
	public KOJOMBLLECK(TReceiver JEMODPNNLCP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public abstract class CKDHCPHELOB<TReceiver, TFromExecute> where TReceiver : notnull where TFromExecute : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	protected TReceiver JEMODPNNLCP;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x596F6A0", Offset = "0x596EAA0", VA = "0x18596F6A0")]
	public CKDHCPHELOB(TReceiver JEMODPNNLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute DNJGMMIDFGL();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class PFLCBELNCCD<TReceiver, TResult> : CKDHCPHELOB<TReceiver, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3B4C4D0", Offset = "0x3B4B8D0", VA = "0x183B4C4D0")]
	public PFLCBELNCCD(TReceiver JEMODPNNLCP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct AADLGMDEBHA<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public TGroup BMOIIKCCNGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public TData AGLLPAODDMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public IEnumerable<TData> EMDFJJLABKL;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x210F020", Offset = "0x210E420", VA = "0x18210F020")]
	public AADLGMDEBHA(TGroup MGLLJCBPMIK, TData AGDBNDAAPMP, IEnumerable<TData> MMMAPKKENHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct JBPBBNGLMJO<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public TGroup BMOIIKCCNGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public IEnumerable<TData> EMDFJJLABKL;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0xD74C00", Offset = "0xD74000", VA = "0x180D74C00")]
	public JBPBBNGLMJO(TGroup MGLLJCBPMIK, IEnumerable<TData> MMMAPKKENHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct AKDKFBJJJFI<TGroup> where TGroup : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public TGroup BMOIIKCCNGC;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0xBF8A90", Offset = "0xBF7E90", VA = "0x180BF8A90")]
	public AKDKFBJJJFI(TGroup MGLLJCBPMIK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct ECPFIEGNIMI<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public IEnumerable<TData> EMDFJJLABKL;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0xBF8A90", Offset = "0xBF7E90", VA = "0x180BF8A90")]
	public ECPFIEGNIMI(IEnumerable<TData> MMMAPKKENHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface FGFPMNCNOGD<TGroup, TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FENNEGIAEFC EPJPNMFBOJP(AADLGMDEBHA<TGroup, TData> OPFAMLFFDHG);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FENNEGIAEFC HDFFLMDBKLG(AADLGMDEBHA<TGroup, TData> OPFAMLFFDHG);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FENNEGIAEFC IEODODEKFHP(JBPBBNGLMJO<TGroup, TData> OPFAMLFFDHG);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FENNEGIAEFC DHEIGKEOOKO(AKDKFBJJJFI<TGroup> OPFAMLFFDHG);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface OGPFICJMGGG<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<FENNEGIAEFC> EPJPNMFBOJP(ECPFIEGNIMI<TData> OPFAMLFFDHG);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class LBEADNCOECG<TGroup, TData> : PFLCBELNCCD<FGFPMNCNOGD<TGroup, TData>, FENNEGIAEFC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly JBPBBNGLMJO<TGroup, TData> OPFAMLFFDHG;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x458AC80", Offset = "0x458A080", VA = "0x18458AC80")]
	public LBEADNCOECG(TGroup MGLLJCBPMIK, IEnumerable<TData> MMMAPKKENHO, FGFPMNCNOGD<TGroup, TData> JEMODPNNLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x458ABB0", Offset = "0x4589FB0", VA = "0x18458ABB0", Slot = "4")]
	public override FENNEGIAEFC DNJGMMIDFGL()
	{
		return default(FENNEGIAEFC);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class LCOCJPEIOGJ<TGroup, TData> : PFLCBELNCCD<FGFPMNCNOGD<TGroup, TData>, FENNEGIAEFC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly AADLGMDEBHA<TGroup, TData> OPFAMLFFDHG;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x45901B0", Offset = "0x458F5B0", VA = "0x1845901B0")]
	public LCOCJPEIOGJ(TGroup MGLLJCBPMIK, TData PKNIJCDCOBH, IEnumerable<TData> MMMAPKKENHO, FGFPMNCNOGD<TGroup, TData> JEMODPNNLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x45900E0", Offset = "0x458F4E0", VA = "0x1845900E0", Slot = "4")]
	public override FENNEGIAEFC DNJGMMIDFGL()
	{
		return default(FENNEGIAEFC);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class JOOKFEDCDKE<TGroup, TData> : PFLCBELNCCD<FGFPMNCNOGD<TGroup, TData>, FENNEGIAEFC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly AKDKFBJJJFI<TGroup> OPFAMLFFDHG;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x4431960", Offset = "0x4430D60", VA = "0x184431960")]
	public JOOKFEDCDKE(TGroup MGLLJCBPMIK, FGFPMNCNOGD<TGroup, TData> JEMODPNNLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4431890", Offset = "0x4430C90", VA = "0x184431890", Slot = "4")]
	public override FENNEGIAEFC DNJGMMIDFGL()
	{
		return default(FENNEGIAEFC);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class MDDAGFJAPEB<TGroup, TData> : PFLCBELNCCD<FGFPMNCNOGD<TGroup, TData>, FENNEGIAEFC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly AADLGMDEBHA<TGroup, TData> OPFAMLFFDHG;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x45901B0", Offset = "0x458F5B0", VA = "0x1845901B0")]
	public MDDAGFJAPEB(TGroup MGLLJCBPMIK, TData AGDBNDAAPMP, IEnumerable<TData> MMMAPKKENHO, FGFPMNCNOGD<TGroup, TData> JEMODPNNLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x47B8630", Offset = "0x47B7A30", VA = "0x1847B8630", Slot = "4")]
	public override FENNEGIAEFC DNJGMMIDFGL()
	{
		return default(FENNEGIAEFC);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class PACNCHIGCAP<TData> : KOJOMBLLECK<OGPFICJMGGG<TData>, FENNEGIAEFC> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private struct BMNHBEBBNEP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AsyncTaskMethodBuilder<FENNEGIAEFC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public PACNCHIGCAP<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private TaskAwaiter<FENNEGIAEFC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x52852C0", Offset = "0x52846C0", VA = "0x1852852C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5285560", Offset = "0x5284960", VA = "0x185285560", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private ECPFIEGNIMI<TData> OPFAMLFFDHG;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x4431960", Offset = "0x4430D60", VA = "0x184431960")]
	public PACNCHIGCAP(IEnumerable<TData> CMJAGKOGINM, OGPFICJMGGG<TData> JEMODPNNLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4ACB400", Offset = "0x4ACA800", VA = "0x184ACB400", Slot = "4")]
	[AsyncStateMachine(typeof(PACNCHIGCAP<>.BMNHBEBBNEP))]
	public override Task<FENNEGIAEFC> DNJGMMIDFGL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public readonly struct FHOANGGLJHL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly HFLJCLOJFIO PIMBEFDLJDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly bool OFHAMLIHBLH;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6E20DA0", Offset = "0x6E201A0", VA = "0x186E20DA0")]
	public FHOANGGLJHL(HFLJCLOJFIO NJBJGBNIIOI, bool EHGOLFMIEOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface KPCPOHAAIFO<TSpawnType> where TSpawnType : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> DNJGMMIDFGL(FHOANGGLJHL EKAHBBJDHLF);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class NEKEHLJMAFD<TSpawnType> : KOJOMBLLECK<KPCPOHAAIFO<TSpawnType>, TSpawnType> where TSpawnType : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private struct HEEPGJACGPF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public AsyncTaskMethodBuilder<TSpawnType> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public NEKEHLJMAFD<TSpawnType> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskAwaiter<TSpawnType> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x41214A0", Offset = "0x41208A0", VA = "0x1841214A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x3B6B700", Offset = "0x3B6AB00", VA = "0x183B6B700", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly FHOANGGLJHL EKAHBBJDHLF;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x48CED30", Offset = "0x48CE130", VA = "0x1848CED30")]
	public NEKEHLJMAFD(HFLJCLOJFIO NJBJGBNIIOI, bool EHGOLFMIEOH, KPCPOHAAIFO<TSpawnType> JEMODPNNLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x48CEA00", Offset = "0x48CDE00", VA = "0x1848CEA00", Slot = "4")]
	[AsyncStateMachine(typeof(NEKEHLJMAFD<>.HEEPGJACGPF))]
	public override Task<TSpawnType> DNJGMMIDFGL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public readonly struct HFLJCLOJFIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly bool BOBEFMEGCMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly Vector3 DIGEKGMGGBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly Vector3 DPFKDMMBOHD;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6E20E20", Offset = "0x6E20220", VA = "0x186E20E20")]
	public HFLJCLOJFIO(Transform OAPPACMIENK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6E20DF0", Offset = "0x6E201F0", VA = "0x186E20DF0")]
	public HFLJCLOJFIO(Vector3 KENGOPLODLD, Vector3 CLHMEGFDOKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6E20DC0", Offset = "0x6E201C0", VA = "0x186E20DC0")]
	public static HFLJCLOJFIO ANLGIKBMHBN()
	{
		return default(HFLJCLOJFIO);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6E20E90", Offset = "0x6E20290", VA = "0x186E20E90")]
	private HFLJCLOJFIO(bool APNJFJKPMPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct KBHILINMFIP<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public TNode CBOEKECPLIA;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x44F8380", Offset = "0x44F7780", VA = "0x1844F8380")]
	public KBHILINMFIP(TNode CBOEKECPLIA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct BBBGBGGBKIH<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public TNode LJAINIGFIAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public KHJNEJJECND MLKDOKNPKBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly bool OFHAMLIHBLH;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5223E90", Offset = "0x5223290", VA = "0x185223E90")]
	public BBBGBGGBKIH(TNode LJAINIGFIAE, KHJNEJJECND MLKDOKNPKBD, bool EHGOLFMIEOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface FIHHIICDLEK<TNode>
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MLMPCNNKPDL([In] KBHILINMFIP<TNode> NPAHLEOIFIB);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CCAEMGLPLGG([In] BBBGBGGBKIH<TNode> DHPDHABAGCG);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PKELJHACLBP();
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class JFADMAGJLEJ<TNode> : BFJMPBGBOJP<FIHHIICDLEK<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3B4C4D0", Offset = "0x3B4B8D0", VA = "0x183B4C4D0")]
	public JFADMAGJLEJ(FIHHIICDLEK<TNode> JEMODPNNLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3B5F370", Offset = "0x3B5E770", VA = "0x183B5F370", Slot = "4")]
	public override bool DNJGMMIDFGL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class DBPMOGLHIIH<TNode> : BFJMPBGBOJP<FIHHIICDLEK<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly BBBGBGGBKIH<TNode> DHPDHABAGCG;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5C92200", Offset = "0x5C91600", VA = "0x185C92200")]
	public DBPMOGLHIIH(TNode LJAINIGFIAE, KHJNEJJECND MLKDOKNPKBD, FIHHIICDLEK<TNode> JEMODPNNLCP, bool EHGOLFMIEOH = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x41637B0", Offset = "0x4162BB0", VA = "0x1841637B0", Slot = "4")]
	public override bool DNJGMMIDFGL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class CBOCHGBFIJM<TNode> : BFJMPBGBOJP<FIHHIICDLEK<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly KBHILINMFIP<TNode> NPAHLEOIFIB;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x548B4C0", Offset = "0x548A8C0", VA = "0x18548B4C0")]
	public CBOCHGBFIJM(TNode FBHOHAEFHAB, FIHHIICDLEK<TNode> JEMODPNNLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3B8FC10", Offset = "0x3B8F010", VA = "0x183B8FC10", Slot = "4")]
	public override bool DNJGMMIDFGL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct COMLLHPPFAJ<TSpawnInfo> where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public TSpawnInfo DDGCIHFGBMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public Vector3 CLHMEGFDOKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Quaternion MDJOMEFJFHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public float KFNOLBCIBOH;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5A79290", Offset = "0x5A78690", VA = "0x185A79290")]
	public COMLLHPPFAJ(TSpawnInfo DDGCIHFGBMH, Vector3 CLHMEGFDOKF, Quaternion MDJOMEFJFHD, float KFNOLBCIBOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface HDHDNMBDJOJ<TSpawnType, TSpawnInfo>
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> KAPGFDONENB([In] COMLLHPPFAJ<TSpawnInfo> FHLNIJLONDF, CancellationToken NBBCMDKGJKI);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class DADIJHIFOPD<TSpawnType, TSpawnInfo> : KOJOMBLLECK<HDHDNMBDJOJ<TSpawnType, TSpawnInfo>, TSpawnType> where TSpawnType : notnull where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly COMLLHPPFAJ<TSpawnInfo> CJLBFJEOAOD;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5C89B20", Offset = "0x5C88F20", VA = "0x185C89B20")]
	public DADIJHIFOPD(TSpawnInfo EDCANJIMAAO, Vector3 CLHMEGFDOKF, Quaternion MDJOMEFJFHD, float KFNOLBCIBOH, HDHDNMBDJOJ<TSpawnType, TSpawnInfo> JEMODPNNLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x3FD2540", Offset = "0x3FD1940", VA = "0x183FD2540", Slot = "4")]
	public override Task<TSpawnType> DNJGMMIDFGL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct NBBMAFMJJPG<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly IEnumerable<TData> EMDFJJLABKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly bool OFHAMLIHBLH;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x48B4EB0", Offset = "0x48B42B0", VA = "0x1848B4EB0")]
	public NBBMAFMJJPG(IEnumerable<TData> MMMAPKKENHO, bool EHGOLFMIEOH = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface KKCLBCAFLFN<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<FENNEGIAEFC> MPMHNPPALED([In] NBBMAFMJJPG<TData> IEEKGDIPBGA, CancellationToken NBBCMDKGJKI);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public class AEDHACEHBHA<TData> : KOJOMBLLECK<KKCLBCAFLFN<TData>, FENNEGIAEFC> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly NBBMAFMJJPG<TData> NFJLMKDPPPH;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x3FD2620", Offset = "0x3FD1A20", VA = "0x183FD2620")]
	public AEDHACEHBHA(IEnumerable<TData> MMMAPKKENHO, bool EHGOLFMIEOH, KKCLBCAFLFN<TData> JEMODPNNLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x3FD2540", Offset = "0x3FD1940", VA = "0x183FD2540", Slot = "4")]
	public override Task<FENNEGIAEFC> DNJGMMIDFGL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct EIGPHEDDIEP<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public readonly T KDGMCPCFIID;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x3B78780", Offset = "0x3B77B80", VA = "0x183B78780")]
	public EIGPHEDDIEP(T DENLKCOBAMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface KFLILOGAIGM<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MLMPCNNKPDL([In] EIGPHEDDIEP<T> IAKGBMKPLOJ);

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CCAEMGLPLGG();
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface MNIBMIDDHHO<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DNJGMMIDFGL([In] EBFGOEDGHGO<T> LHEPMPKDLOI);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct EBFGOEDGHGO<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public readonly T KDGMCPCFIID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public readonly bool HEGOCHHBIFG;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x3B4C000", Offset = "0x3B4B400", VA = "0x183B4C000")]
	public EBFGOEDGHGO(T DENLKCOBAMD, bool JGBLBCLOIAG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class ENCNDGIDEIB<T> : BFJMPBGBOJP<KFLILOGAIGM<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x3B4C4D0", Offset = "0x3B4B8D0", VA = "0x183B4C4D0")]
	public ENCNDGIDEIB(KFLILOGAIGM<T> JEMODPNNLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x3BAA760", Offset = "0x3BA9B60", VA = "0x183BAA760", Slot = "4")]
	public override bool DNJGMMIDFGL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class NCGABCLEKFJ<T> : BFJMPBGBOJP<KFLILOGAIGM<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly EIGPHEDDIEP<T> IAKGBMKPLOJ;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x48B7080", Offset = "0x48B6480", VA = "0x1848B7080")]
	public NCGABCLEKFJ(T KDGMCPCFIID, KFLILOGAIGM<T> JEMODPNNLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x3B8FC10", Offset = "0x3B8F010", VA = "0x183B8FC10", Slot = "4")]
	public override bool DNJGMMIDFGL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class MLEBPDAACMK<T> : BFJMPBGBOJP<MNIBMIDDHHO<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly EBFGOEDGHGO<T> LHEPMPKDLOI;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4815EA0", Offset = "0x48152A0", VA = "0x184815EA0")]
	public MLEBPDAACMK(T KDGMCPCFIID, bool JGBLBCLOIAG, MNIBMIDDHHO<T> JEMODPNNLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x3B8FC10", Offset = "0x3B8F010", VA = "0x183B8FC10", Slot = "4")]
	public override bool DNJGMMIDFGL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct GNEPEGKNKPG<TData> where TData : notnull, LPEOMEDGPEC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public IEnumerable<TData> EMDFJJLABKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public bool BOIHLMLAOJB;

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x40BE050", Offset = "0x40BD450", VA = "0x1840BE050")]
	public GNEPEGKNKPG(IEnumerable<TData> ABNACGOJBJO, bool BCOHEAPMOPA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public struct CIPBPELICFI<TData> where TData : notnull, LPEOMEDGPEC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public List<TData> EMDFJJLABKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public List<bool> JLNFLMIDPOM;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x596CFC0", Offset = "0x596C3C0", VA = "0x18596CFC0")]
	public CIPBPELICFI(List<TData> ABNACGOJBJO, List<bool> GKKJAJBOLJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface LPEOMEDGPEC
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool AOGGOFABLDB
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
public interface GLINOLMKDJB<TData> where TData : LPEOMEDGPEC
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DNJGMMIDFGL([In] GNEPEGKNKPG<TData> HMHAMPJMCHA);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DNJGMMIDFGL([In] CIPBPELICFI<TData> HMHAMPJMCHA);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface OCOBONMIGKK<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IAPNONOJINB(T KDGMCPCFIID);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class ELBIFHBGHJA<TData> : BFJMPBGBOJP<GLINOLMKDJB<TData>> where TData : notnull, LPEOMEDGPEC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly GNEPEGKNKPG<TData> HMHAMPJMCHA;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x3B8FCD0", Offset = "0x3B8F0D0", VA = "0x183B8FCD0")]
	public ELBIFHBGHJA(List<TData> MMMAPKKENHO, bool BOIHLMLAOJB, GLINOLMKDJB<TData> JEMODPNNLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x3B8FC10", Offset = "0x3B8F010", VA = "0x183B8FC10", Slot = "4")]
	public override bool DNJGMMIDFGL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class PHGMEFFILFA<TData> : BFJMPBGBOJP<GLINOLMKDJB<TData>> where TData : notnull, LPEOMEDGPEC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly CIPBPELICFI<TData> HMHAMPJMCHA;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x4B1ACB0", Offset = "0x4B1A0B0", VA = "0x184B1ACB0")]
	public PHGMEFFILFA(List<TData> MMMAPKKENHO, List<bool> JLNFLMIDPOM, GLINOLMKDJB<TData> JEMODPNNLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x47E2A80", Offset = "0x47E1E80", VA = "0x1847E2A80", Slot = "4")]
	public override bool DNJGMMIDFGL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface NAJNHHACHNP<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<FENNEGIAEFC> DNJGMMIDFGL(EILMGCDLGDG<TData> GHJFLLHKKMG);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class IDLANPCEFFE<TData> : KOJOMBLLECK<NAJNHHACHNP<TData>, FENNEGIAEFC> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct NKIFGHOCBCM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public AsyncTaskMethodBuilder<FENNEGIAEFC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public IDLANPCEFFE<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter<FENNEGIAEFC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x4906AE0", Offset = "0x4905EE0", VA = "0x184906AE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x4906DD0", Offset = "0x49061D0", VA = "0x184906DD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly EILMGCDLGDG<TData> KEOBKBKCOGK;

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x4235890", Offset = "0x4234C90", VA = "0x184235890")]
	public IDLANPCEFFE(TData BPHOAHKFELB, IReadOnlyList<TData> PPAEDNJDBPA, bool EHGOLFMIEOH, NAJNHHACHNP<TData> JEMODPNNLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x4235790", Offset = "0x4234B90", VA = "0x184235790", Slot = "4")]
	[AsyncStateMachine(typeof(IDLANPCEFFE<>.NKIFGHOCBCM))]
	public override Task<FENNEGIAEFC> DNJGMMIDFGL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public struct EILMGCDLGDG<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public TData CMJGMMDDMFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public IReadOnlyList<TData> OBHHFKODAKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public bool OFHAMLIHBLH;

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x3B7D240", Offset = "0x3B7C640", VA = "0x183B7D240")]
	public EILMGCDLGDG(TData BPHOAHKFELB, IReadOnlyList<TData> PPAEDNJDBPA, bool EHGOLFMIEOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface MLHEKGJILFM<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DNJGMMIDFGL([In] CEGHNEFHIJP<TData> ACPHEONPCBP);
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface IEJEFLMLPBE<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DNJGMMIDFGL([In] HFPMDGOCLHJ<TData> ACPHEONPCBP);
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface MDCKDHKLCAE<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IGAHFJMJPMA([In] LOEKHNJCALG<TData> ACPHEONPCBP);

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CCAEMGLPLGG();
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class MHOMMLEDKPB<TData> : BFJMPBGBOJP<MLHEKGJILFM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly CEGHNEFHIJP<TData> ACPHEONPCBP;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x47E2980", Offset = "0x47E1D80", VA = "0x1847E2980")]
	public MHOMMLEDKPB(IEnumerable<TData> MMMAPKKENHO, JNMGAPGEGHB KLMDPLMNJMP, HHBCGPJFJDH PBHLFFKCLKK, float MFEHENGDBCD, bool EHGOLFMIEOH, MLHEKGJILFM<TData> JEMODPNNLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3B8FC10", Offset = "0x3B8F010", VA = "0x183B8FC10", Slot = "4")]
	public override bool DNJGMMIDFGL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class APDNNFBNJPJ<TData> : BFJMPBGBOJP<IEJEFLMLPBE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly HFPMDGOCLHJ<TData> ACPHEONPCBP;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x41F8FA0", Offset = "0x41F83A0", VA = "0x1841F8FA0")]
	public APDNNFBNJPJ(TData[] MMMAPKKENHO, JNMGAPGEGHB[] KLMDPLMNJMP, HHBCGPJFJDH[] PBHLFFKCLKK, float[] MFEHENGDBCD, IEJEFLMLPBE<TData> JEMODPNNLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x3B7D400", Offset = "0x3B7C800", VA = "0x183B7D400", Slot = "4")]
	public override bool DNJGMMIDFGL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class ECHHFPNMOCF<TData> : BFJMPBGBOJP<MDCKDHKLCAE<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3B4C4D0", Offset = "0x3B4B8D0", VA = "0x183B4C4D0")]
	public ECHHFPNMOCF(MDCKDHKLCAE<TData> JEMODPNNLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3B4ED20", Offset = "0x3B4E120", VA = "0x183B4ED20", Slot = "4")]
	public override bool DNJGMMIDFGL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class EJLPLFEDDCP<TData> : BFJMPBGBOJP<MDCKDHKLCAE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly LOEKHNJCALG<TData> ACPHEONPCBP;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3B7D4C0", Offset = "0x3B7C8C0", VA = "0x183B7D4C0")]
	public EJLPLFEDDCP(IEnumerable<TData> MMMAPKKENHO, JNMGAPGEGHB KLMDPLMNJMP, HHBCGPJFJDH PBHLFFKCLKK, float MFEHENGDBCD, MDCKDHKLCAE<TData> JEMODPNNLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3B7D400", Offset = "0x3B7C800", VA = "0x183B7D400", Slot = "4")]
	public override bool DNJGMMIDFGL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct CEGHNEFHIJP<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public IEnumerable<TData> EMDFJJLABKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public JNMGAPGEGHB BFHKACAHKBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public HHBCGPJFJDH DLKIFPPKHGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public float MFEHENGDBCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public bool EHGOLFMIEOH;

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x54935C0", Offset = "0x54929C0", VA = "0x1854935C0")]
	public CEGHNEFHIJP(IEnumerable<TData> MMMAPKKENHO, JNMGAPGEGHB KLMDPLMNJMP, HHBCGPJFJDH PBHLFFKCLKK, float MFEHENGDBCD, bool EHGOLFMIEOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public struct HFPMDGOCLHJ<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public TData[] EMDFJJLABKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public JNMGAPGEGHB[] BFHKACAHKBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public HHBCGPJFJDH[] DLKIFPPKHGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public float[] MFEHENGDBCD;

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x415AE80", Offset = "0x415A280", VA = "0x18415AE80")]
	public HFPMDGOCLHJ(TData[] MMMAPKKENHO, JNMGAPGEGHB[] KLMDPLMNJMP, HHBCGPJFJDH[] PBHLFFKCLKK, float[] MFEHENGDBCD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public struct LOEKHNJCALG<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public IEnumerable<TData> EMDFJJLABKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public JNMGAPGEGHB BFHKACAHKBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public HHBCGPJFJDH DLKIFPPKHGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public float MFEHENGDBCD;

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x45EE540", Offset = "0x45ED940", VA = "0x1845EE540")]
	public LOEKHNJCALG(IEnumerable<TData> MMMAPKKENHO, JNMGAPGEGHB KLMDPLMNJMP, HHBCGPJFJDH PBHLFFKCLKK, float MFEHENGDBCD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface OKBKBDDJNLH<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IEODODEKFHP([In] OAEFLDFIKBN<TData> IEEKGDIPBGA);

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DHEIGKEOOKO([In] OAEFLDFIKBN<TData> IEEKGDIPBGA);

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NDJGMCPEIIF([In] bool GFCMPHBDFII);

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool KBNECHBIGDE([In] OAEFLDFIKBN<TData> IEEKGDIPBGA);

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KHJJDBMBONJ();

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool HLPDDBIAMPJ([In] TData NEJKIIFAPMG);
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class DKOFCKKHEHP<TData> : BFJMPBGBOJP<OKBKBDDJNLH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly OAEFLDFIKBN<TData> IEEKGDIPBGA;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x5CAACA0", Offset = "0x5CAA0A0", VA = "0x185CAACA0")]
	public DKOFCKKHEHP(List<TData> JHBKFOICCJL, OKBKBDDJNLH<TData> JEMODPNNLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x3B8FC10", Offset = "0x3B8F010", VA = "0x183B8FC10", Slot = "4")]
	public override bool DNJGMMIDFGL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class EBLFILJNFFJ<TData> : BFJMPBGBOJP<OKBKBDDJNLH<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3B4C4D0", Offset = "0x3B4B8D0", VA = "0x183B4C4D0")]
	public EBLFILJNFFJ(OKBKBDDJNLH<TData> JEMODPNNLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3B4C480", Offset = "0x3B4B880", VA = "0x183B4C480", Slot = "4")]
	public override bool DNJGMMIDFGL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class PJPMLBEEPBE<TData> : BFJMPBGBOJP<OKBKBDDJNLH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly bool EHGOLFMIEOH;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x4B24F50", Offset = "0x4B24350", VA = "0x184B24F50")]
	public PJPMLBEEPBE(bool EHGOLFMIEOH, OKBKBDDJNLH<TData> JEMODPNNLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x4B24EF0", Offset = "0x4B242F0", VA = "0x184B24EF0", Slot = "4")]
	public override bool DNJGMMIDFGL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class MHPBCLNPLFO<TData> : BFJMPBGBOJP<OKBKBDDJNLH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly OAEFLDFIKBN<TData> IEEKGDIPBGA;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x47E2B40", Offset = "0x47E1F40", VA = "0x1847E2B40")]
	public MHPBCLNPLFO(List<TData> JHBKFOICCJL, bool EHGOLFMIEOH, OKBKBDDJNLH<TData> JEMODPNNLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x47E2A80", Offset = "0x47E1E80", VA = "0x1847E2A80", Slot = "4")]
	public override bool DNJGMMIDFGL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class GBHHKKFBICJ<TData> : BFJMPBGBOJP<OKBKBDDJNLH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly TData NEJKIIFAPMG;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x4023490", Offset = "0x4022890", VA = "0x184023490")]
	public GBHHKKFBICJ(TData NEJKIIFAPMG, OKBKBDDJNLH<TData> JEMODPNNLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x40233C0", Offset = "0x40227C0", VA = "0x1840233C0", Slot = "4")]
	public override bool DNJGMMIDFGL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class HLGKBLICIIL<TData> : BFJMPBGBOJP<OKBKBDDJNLH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly OAEFLDFIKBN<TData> IEEKGDIPBGA;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x416B080", Offset = "0x416A480", VA = "0x18416B080")]
	public HLGKBLICIIL(IEnumerable<TData> JHBKFOICCJL, OKBKBDDJNLH<TData> JEMODPNNLCP, bool EHGOLFMIEOH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x416AFB0", Offset = "0x416A3B0", VA = "0x18416AFB0", Slot = "4")]
	public override bool DNJGMMIDFGL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public struct OAEFLDFIKBN<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public IEnumerable<TData> EMDFJJLABKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public bool EHGOLFMIEOH;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x49FD6A0", Offset = "0x49FCAA0", VA = "0x1849FD6A0")]
	public OAEFLDFIKBN(IEnumerable<TData> ABNACGOJBJO, bool JBEKKMDOJAK = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface BCGHIJMPFJH
{
	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<FENNEGIAEFC> DNJGMMIDFGL(BOHCPLNJDEO MKIPIJANEGM);
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public class AMEBNCCCKPM : KOJOMBLLECK<BCGHIJMPFJH, FENNEGIAEFC>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private struct EPFOJKJOGNM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public AsyncTaskMethodBuilder<FENNEGIAEFC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public AMEBNCCCKPM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private TaskAwaiter<FENNEGIAEFC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6E20AB0", Offset = "0x6E1FEB0", VA = "0x186E20AB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6E20D20", Offset = "0x6E20120", VA = "0x186E20D20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly BOHCPLNJDEO IGMHHJIPEOC;

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6E205D0", Offset = "0x6E1F9D0", VA = "0x186E205D0")]
	public AMEBNCCCKPM(bool EHGOLFMIEOH, BCGHIJMPFJH JEMODPNNLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6E204E0", Offset = "0x6E1F8E0", VA = "0x186E204E0", Slot = "4")]
	[AsyncStateMachine(typeof(EPFOJKJOGNM))]
	public override Task<FENNEGIAEFC> DNJGMMIDFGL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public struct BOHCPLNJDEO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public bool OFHAMLIHBLH;

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x23E8990", Offset = "0x23E7D90", VA = "0x1823E8990")]
	public BOHCPLNJDEO(bool EHGOLFMIEOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public readonly struct FDPCCNCLDDC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly bool GKEKMPIKNAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly bool AGHOILFLFKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public readonly bool KFNOLBCIBOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public readonly bool EHGOLFMIEOH;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x50EC480", Offset = "0x50EB880", VA = "0x1850EC480")]
	public FDPCCNCLDDC(bool GKEKMPIKNAC, bool AGHOILFLFKD, bool KFNOLBCIBOH, bool EHGOLFMIEOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6E20D90", Offset = "0x6E20190", VA = "0x186E20D90")]
	public FDPCCNCLDDC(bool AGHOILFLFKD, bool EHGOLFMIEOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public interface AJMEPCLDDPI
{
	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HHBLICBLAML(FDPCCNCLDDC EMNMLKKECBD);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HLPOAJOJCNI(FDPCCNCLDDC EMNMLKKECBD);
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class DGIFFONOMAE : BFJMPBGBOJP<AJMEPCLDDPI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly FDPCCNCLDDC EMNMLKKECBD;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6E20910", Offset = "0x6E1FD10", VA = "0x186E20910")]
	public DGIFFONOMAE(bool HGENDDPKHHK, bool AGHOILFLFKD, bool KFNOLBCIBOH, bool EHGOLFMIEOH, AJMEPCLDDPI JEMODPNNLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6E208C0", Offset = "0x6E1FCC0", VA = "0x186E208C0", Slot = "4")]
	public override bool DNJGMMIDFGL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class NBAADEPCHGL : BFJMPBGBOJP<AJMEPCLDDPI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly FDPCCNCLDDC EMNMLKKECBD;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6E21020", Offset = "0x6E20420", VA = "0x186E21020")]
	public NBAADEPCHGL(bool AGHOILFLFKD, bool EHGOLFMIEOH, AJMEPCLDDPI JEMODPNNLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6E20FD0", Offset = "0x6E203D0", VA = "0x186E20FD0", Slot = "4")]
	public override bool DNJGMMIDFGL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public interface PHPAJHHIPPP
{
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DNJGMMIDFGL([In] ONMEIBDJOMG DLDNCJCAOKP);
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class BMMFDBBJKLE : BFJMPBGBOJP<PHPAJHHIPPP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly ONMEIBDJOMG DLDNCJCAOKP;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6E206E0", Offset = "0x6E1FAE0", VA = "0x186E206E0")]
	public BMMFDBBJKLE(Guid[] LJIPFONJPIF, Vector3[] FPNBFOHEABF, Quaternion[] ACGBGFGOFBA, float[] GKLGCJMCGDO, Dictionary<Guid, Vector3> HPEFBMEKAHL, PHPAJHHIPPP JEMODPNNLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6E20630", Offset = "0x6E1FA30", VA = "0x186E20630", Slot = "4")]
	public override bool DNJGMMIDFGL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public interface JGADACANJJC<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MLMPCNNKPDL([In] OBCHLEJDGEG<TData> NPAHLEOIFIB);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IGAHFJMJPMA([In] IEAANPAPLDJ CHHKMDEEDHP);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IGAHFJMJPMA([In] KFMAMHKHGHO CHHKMDEEDHP);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CCAEMGLPLGG();
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class GAOIEFDOHDH<TData> : BFJMPBGBOJP<JGADACANJJC<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3B4C4D0", Offset = "0x3B4B8D0", VA = "0x183B4C4D0")]
	public GAOIEFDOHDH(JGADACANJJC<TData> JEMODPNNLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x4018970", Offset = "0x4017D70", VA = "0x184018970", Slot = "4")]
	public override bool DNJGMMIDFGL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class LOHPNCIIAGA<TData> : BFJMPBGBOJP<JGADACANJJC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly IEAANPAPLDJ JOEAKHPFOBD;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x45EF780", Offset = "0x45EEB80", VA = "0x1845EF780")]
	public LOHPNCIIAGA(Vector3 LEPIBFNIPLK, bool INLEJNBCDJK, JGADACANJJC<TData> JEMODPNNLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x3F38EF0", Offset = "0x3F382F0", VA = "0x183F38EF0", Slot = "4")]
	public override bool DNJGMMIDFGL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class LMGGOLFEFGG<TData> : BFJMPBGBOJP<JGADACANJJC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly KFMAMHKHGHO JOEAKHPFOBD;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x45E2500", Offset = "0x45E1900", VA = "0x1845E2500")]
	public LMGGOLFEFGG(Guid DELEEKDKJBE, int HAJICDLBEKC, Vector3 CLHMEGFDOKF, Quaternion MDJOMEFJFHD, float CBOFEOAGGML, bool INLEJNBCDJK, JGADACANJJC<TData> JEMODPNNLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x45E24A0", Offset = "0x45E18A0", VA = "0x1845E24A0", Slot = "4")]
	public override bool DNJGMMIDFGL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class ODIAEKACEGN<TData> : BFJMPBGBOJP<JGADACANJJC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly OBCHLEJDGEG<TData> JOEAKHPFOBD;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x4A0AD90", Offset = "0x4A0A190", VA = "0x184A0AD90")]
	public ODIAEKACEGN(TData KDGMCPCFIID, bool EHGOLFMIEOH, JGADACANJJC<TData> JEMODPNNLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x3B8FC10", Offset = "0x3B8F010", VA = "0x183B8FC10", Slot = "4")]
	public override bool DNJGMMIDFGL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public struct IEAANPAPLDJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly Vector3 LEPIBFNIPLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public readonly bool INLEJNBCDJK;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6E20F10", Offset = "0x6E20310", VA = "0x186E20F10")]
	public IEAANPAPLDJ(Vector3 LEPIBFNIPLK, bool INLEJNBCDJK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public struct KFMAMHKHGHO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public readonly Guid DELEEKDKJBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public readonly int HAJICDLBEKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public readonly Vector3 CLHMEGFDOKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public readonly Quaternion MDJOMEFJFHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public readonly float CBOFEOAGGML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public readonly bool INLEJNBCDJK;

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6E20F90", Offset = "0x6E20390", VA = "0x186E20F90")]
	public KFMAMHKHGHO(Guid DELEEKDKJBE, int HAJICDLBEKC, Vector3 CLHMEGFDOKF, Quaternion MDJOMEFJFHD, float CBOFEOAGGML, bool INLEJNBCDJK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public struct OBCHLEJDGEG<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public readonly TData KDGMCPCFIID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public readonly bool EHGOLFMIEOH;

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x4A004C0", Offset = "0x49FF8C0", VA = "0x184A004C0")]
	public OBCHLEJDGEG(TData KDGMCPCFIID, bool EHGOLFMIEOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public interface AFALALAIMJH<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DNJGMMIDFGL([In] CFKNHHKBDME<TData> ABFPEFDBAFH);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DNJGMMIDFGL([In] PFJJBBJGAFD<TData> ABFPEFDBAFH);
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public interface AKOJKJIFLAF<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MLMPCNNKPDL([In] IMPJILJIDOC<TData> HDHKLNLFIDN);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IGAHFJMJPMA([In] DCGIMGCOAFI CHHKMDEEDHP);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CCAEMGLPLGG();
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class HGIIODOJDKJ<TData> : BFJMPBGBOJP<AFALALAIMJH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly CFKNHHKBDME<TData> ABFPEFDBAFH;

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x415C270", Offset = "0x415B670", VA = "0x18415C270")]
	public HGIIODOJDKJ(IEnumerable<TData> MMMAPKKENHO, Vector3 JDNMHNKMKGC, bool EHGOLFMIEOH, AFALALAIMJH<TData> JEMODPNNLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x3B8FC10", Offset = "0x3B8F010", VA = "0x183B8FC10", Slot = "4")]
	public override bool DNJGMMIDFGL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class EFLNPHPBIFD<TData> : BFJMPBGBOJP<AKOJKJIFLAF<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x3B4C4D0", Offset = "0x3B4B8D0", VA = "0x183B4C4D0")]
	public EFLNPHPBIFD(AKOJKJIFLAF<TData> JEMODPNNLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x3B5F370", Offset = "0x3B5E770", VA = "0x183B5F370", Slot = "4")]
	public override bool DNJGMMIDFGL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class MKEEKGMJILP<TData> : BFJMPBGBOJP<AKOJKJIFLAF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly IMPJILJIDOC<TData> ABFPEFDBAFH;

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x4805340", Offset = "0x4804740", VA = "0x184805340")]
	public MKEEKGMJILP(IEnumerable<TData> MMMAPKKENHO, bool EHGOLFMIEOH, AKOJKJIFLAF<TData> JEMODPNNLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3B8FC10", Offset = "0x3B8F010", VA = "0x183B8FC10", Slot = "4")]
	public override bool DNJGMMIDFGL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class OAIIIMCNIAE<TData> : BFJMPBGBOJP<AFALALAIMJH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly PFJJBBJGAFD<TData> ABFPEFDBAFH;

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x49FE180", Offset = "0x49FD580", VA = "0x1849FE180")]
	public OAIIIMCNIAE(IEnumerable<TData> MMMAPKKENHO, Vector3 CIMALJANAKE, IIIMFDOPDPM EEEMBBIJANB, bool EHGOLFMIEOH, AFALALAIMJH<TData> JEMODPNNLCP, Space BBOJLKPBMEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x41637B0", Offset = "0x4162BB0", VA = "0x1841637B0", Slot = "4")]
	public override bool DNJGMMIDFGL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public class IOPFAIJFOHB<TData> : BFJMPBGBOJP<AKOJKJIFLAF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly DCGIMGCOAFI ABFPEFDBAFH;

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x4263130", Offset = "0x4262530", VA = "0x184263130")]
	public IOPFAIJFOHB(Vector3 JDNMHNKMKGC, AKOJKJIFLAF<TData> JEMODPNNLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x3F38EF0", Offset = "0x3F382F0", VA = "0x183F38EF0", Slot = "4")]
	public override bool DNJGMMIDFGL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct CFKNHHKBDME<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public readonly IEnumerable<TData> MMMAPKKENHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public readonly Vector3 JDNMHNKMKGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public readonly bool EHGOLFMIEOH;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x58800A0", Offset = "0x587F4A0", VA = "0x1858800A0")]
	public CFKNHHKBDME(IEnumerable<TData> MMMAPKKENHO, Vector3 JDNMHNKMKGC, bool EHGOLFMIEOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct IMPJILJIDOC<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public readonly IEnumerable<TData> MMMAPKKENHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public readonly bool EHGOLFMIEOH;

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x425FBF0", Offset = "0x425EFF0", VA = "0x18425FBF0")]
	public IMPJILJIDOC(IEnumerable<TData> MMMAPKKENHO, bool EHGOLFMIEOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct PFJJBBJGAFD<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public readonly IEnumerable<TData> MMMAPKKENHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public readonly Vector3 CIMALJANAKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly IIIMFDOPDPM EEEMBBIJANB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public readonly bool EHGOLFMIEOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly Space BBOJLKPBMEP;

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x4B190C0", Offset = "0x4B184C0", VA = "0x184B190C0")]
	public PFJJBBJGAFD(IEnumerable<TData> MMMAPKKENHO, Vector3 CIMALJANAKE, IIIMFDOPDPM EEEMBBIJANB, bool EHGOLFMIEOH, Space BBOJLKPBMEP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public struct DCGIMGCOAFI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public readonly Vector3 JDNMHNKMKGC;

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x23E8980", Offset = "0x23E7D80", VA = "0x1823E8980")]
	public DCGIMGCOAFI(Vector3 JDNMHNKMKGC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public enum IIIMFDOPDPM
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
public interface IKGGHGGFIGH
{
	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DNJGMMIDFGL([In] KPICBMPLMPA EPLCDFDNOHH);
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class EPFJEBKAKJN : BFJMPBGBOJP<IKGGHGGFIGH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly KPICBMPLMPA EPLCDFDNOHH;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6E20A50", Offset = "0x6E1FE50", VA = "0x186E20A50")]
	public EPFJEBKAKJN(bool EHGOLFMIEOH, IKGGHGGFIGH JEMODPNNLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6E209A0", Offset = "0x6E1FDA0", VA = "0x186E209A0", Slot = "4")]
	public override bool DNJGMMIDFGL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public readonly struct KPICBMPLMPA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public readonly bool EHGOLFMIEOH;

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x23E8990", Offset = "0x23E7D90", VA = "0x1823E8990")]
	public KPICBMPLMPA(bool EHGOLFMIEOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public interface BACMEMLKBAI<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DNJGMMIDFGL([In] CGHOHBBPKAK<TData> FDIKLCHGFNN);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DNJGMMIDFGL([In] BJOAPMPKLEK<TData> FDIKLCHGFNN);
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public interface CMBFJPJNJKG<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MLMPCNNKPDL([In] CFLGEDNBGKE<TData> NPAHLEOIFIB);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IGAHFJMJPMA([In] IGKIFLEGNIF CHHKMDEEDHP);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CCAEMGLPLGG();
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class DDHDMEKIHEI<TData> : BFJMPBGBOJP<BACMEMLKBAI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly CGHOHBBPKAK<TData> FDIKLCHGFNN;

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5C96AC0", Offset = "0x5C95EC0", VA = "0x185C96AC0")]
	public DDHDMEKIHEI(IEnumerable<TData> MMMAPKKENHO, Quaternion JDNMHNKMKGC, Vector3? BJPFPLJLIEC, bool HOMKPNPDFAP, bool EHGOLFMIEOH, BACMEMLKBAI<TData> JEMODPNNLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x3B8FC10", Offset = "0x3B8F010", VA = "0x183B8FC10", Slot = "4")]
	public override bool DNJGMMIDFGL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class HBHBAELCADG<TData> : BFJMPBGBOJP<CMBFJPJNJKG<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x3B4C4D0", Offset = "0x3B4B8D0", VA = "0x183B4C4D0")]
	public HBHBAELCADG(CMBFJPJNJKG<TData> JEMODPNNLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x3B5F370", Offset = "0x3B5E770", VA = "0x183B5F370", Slot = "4")]
	public override bool DNJGMMIDFGL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class OMNPKAECOHM<TData> : BFJMPBGBOJP<CMBFJPJNJKG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly CFLGEDNBGKE<TData> FDIKLCHGFNN;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x4A19CA0", Offset = "0x4A190A0", VA = "0x184A19CA0")]
	public OMNPKAECOHM(IEnumerable<TData> MMMAPKKENHO, bool EHGOLFMIEOH, CMBFJPJNJKG<TData> JEMODPNNLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x3B8FC10", Offset = "0x3B8F010", VA = "0x183B8FC10", Slot = "4")]
	public override bool DNJGMMIDFGL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class HJFDGDFJPEK<TData> : BFJMPBGBOJP<BACMEMLKBAI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly BJOAPMPKLEK<TData> FDIKLCHGFNN;

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x4163880", Offset = "0x4162C80", VA = "0x184163880")]
	public HJFDGDFJPEK(IEnumerable<TData> MMMAPKKENHO, Quaternion FGNLKIGDBJL, IIIMFDOPDPM MDEBHNLGKKI, Vector3? BJPFPLJLIEC, bool HOMKPNPDFAP, bool EHGOLFMIEOH, Space BBOJLKPBMEP, BACMEMLKBAI<TData> JEMODPNNLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x41637B0", Offset = "0x4162BB0", VA = "0x1841637B0", Slot = "4")]
	public override bool DNJGMMIDFGL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public class MCOMNJJJJEG<TData> : BFJMPBGBOJP<CMBFJPJNJKG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly IGKIFLEGNIF FDIKLCHGFNN;

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x47B8550", Offset = "0x47B7950", VA = "0x1847B8550")]
	public MCOMNJJJJEG(Quaternion JDNMHNKMKGC, Vector3? BJPFPLJLIEC, bool HOMKPNPDFAP, CMBFJPJNJKG<TData> JEMODPNNLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x3F38EF0", Offset = "0x3F382F0", VA = "0x183F38EF0", Slot = "4")]
	public override bool DNJGMMIDFGL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public struct CGHOHBBPKAK<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public readonly IEnumerable<TData> MMMAPKKENHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public readonly Quaternion JDNMHNKMKGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public readonly Vector3? BJPFPLJLIEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public readonly bool HOMKPNPDFAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public readonly bool EHGOLFMIEOH;

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x5880DD0", Offset = "0x58801D0", VA = "0x185880DD0")]
	public CGHOHBBPKAK(IEnumerable<TData> MMMAPKKENHO, Quaternion JDNMHNKMKGC, Vector3? BJPFPLJLIEC, bool HOMKPNPDFAP, bool EHGOLFMIEOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public struct CFLGEDNBGKE<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public readonly IEnumerable<TData> MMMAPKKENHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly bool EHGOLFMIEOH;

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x5880500", Offset = "0x587F900", VA = "0x185880500")]
	public CFLGEDNBGKE(IEnumerable<TData> MMMAPKKENHO, bool EHGOLFMIEOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public struct BJOAPMPKLEK<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public readonly IEnumerable<TData> MMMAPKKENHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public readonly Quaternion FGNLKIGDBJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public readonly IIIMFDOPDPM MDEBHNLGKKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public readonly Vector3? BJPFPLJLIEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public readonly bool HOMKPNPDFAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public readonly bool EHGOLFMIEOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public readonly Space BBOJLKPBMEP;

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x5274230", Offset = "0x5273630", VA = "0x185274230")]
	public BJOAPMPKLEK(IEnumerable<TData> MMMAPKKENHO, Quaternion FGNLKIGDBJL, IIIMFDOPDPM MDEBHNLGKKI, Vector3? BJPFPLJLIEC, bool HOMKPNPDFAP, bool EHGOLFMIEOH, Space BBOJLKPBMEP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public struct IGKIFLEGNIF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public readonly Quaternion JDNMHNKMKGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public readonly Vector3? BJPFPLJLIEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public readonly bool HOMKPNPDFAP;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x5086030", Offset = "0x5085430", VA = "0x185086030")]
	public IGKIFLEGNIF(Quaternion JDNMHNKMKGC, Vector3? BJPFPLJLIEC, bool HOMKPNPDFAP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public interface JONOLBOPEAF<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MLMPCNNKPDL([In] CDNPNEFAMJH<TData> NPAHLEOIFIB);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IGAHFJMJPMA([In] PDAKGOIILAC CHHKMDEEDHP);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IGAHFJMJPMA([In] IEOKGCPJOKI CHHKMDEEDHP);

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IGAHFJMJPMA([In] IEBFFAKAOPN CHHKMDEEDHP);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool CCAEMGLPLGG();
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public class PKJNIBENOMO<TData> : BFJMPBGBOJP<JONOLBOPEAF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly IEBFFAKAOPN JJFIBHAFAPE;

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x4B29470", Offset = "0x4B28870", VA = "0x184B29470")]
	public PKJNIBENOMO(Vector3 BNEJBBMGECJ, float KHDOIBPNKOB, Vector3 BJPFPLJLIEC, bool IOJCFAFGGDL, bool JLNDFGPFKLN, JONOLBOPEAF<TData> JEMODPNNLCP, Space BBOJLKPBMEP = Space.Self)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x4B29410", Offset = "0x4B28810", VA = "0x184B29410", Slot = "4")]
	public override bool DNJGMMIDFGL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class AOHADHGPBFG<TData> : BFJMPBGBOJP<JONOLBOPEAF<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x3B4C4D0", Offset = "0x3B4B8D0", VA = "0x183B4C4D0")]
	public AOHADHGPBFG(JONOLBOPEAF<TData> JEMODPNNLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x41F8DB0", Offset = "0x41F81B0", VA = "0x1841F8DB0", Slot = "4")]
	public override bool DNJGMMIDFGL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class OFBCONKFBOK<TData> : BFJMPBGBOJP<JONOLBOPEAF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly CDNPNEFAMJH<TData> JJFIBHAFAPE;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x4A10110", Offset = "0x4A0F510", VA = "0x184A10110")]
	public OFBCONKFBOK(IEnumerable<TData> MMMAPKKENHO, bool EHGOLFMIEOH, JONOLBOPEAF<TData> JEMODPNNLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x3B8FC10", Offset = "0x3B8F010", VA = "0x183B8FC10", Slot = "4")]
	public override bool DNJGMMIDFGL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class DGLENHMJPKK<TData> : BFJMPBGBOJP<JONOLBOPEAF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly IEOKGCPJOKI JJFIBHAFAPE;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x5CA0BB0", Offset = "0x5C9FFB0", VA = "0x185CA0BB0")]
	public DGLENHMJPKK(float DCPEEOPBCEK, bool OGPPCFBNKGF, Vector3 BJPFPLJLIEC, JONOLBOPEAF<TData> JEMODPNNLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x5CA0AE0", Offset = "0x5C9FEE0", VA = "0x185CA0AE0", Slot = "4")]
	public override bool DNJGMMIDFGL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public class FGFEPKPDEOI<TData> : BFJMPBGBOJP<JONOLBOPEAF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly PDAKGOIILAC JJFIBHAFAPE;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x3F38F50", Offset = "0x3F38350", VA = "0x183F38F50")]
	public FGFEPKPDEOI(float KHDOIBPNKOB, Vector3 BJPFPLJLIEC, JONOLBOPEAF<TData> JEMODPNNLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x3F38EF0", Offset = "0x3F382F0", VA = "0x183F38EF0", Slot = "4")]
	public override bool DNJGMMIDFGL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public struct IEBFFAKAOPN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public readonly Vector3 BNEJBBMGECJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public readonly float KHDOIBPNKOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public readonly Vector3 BJPFPLJLIEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public readonly bool INLEJNBCDJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public readonly Space BBOJLKPBMEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public readonly bool JLNDFGPFKLN;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x6E20F30", Offset = "0x6E20330", VA = "0x186E20F30")]
	public IEBFFAKAOPN(Vector3 BNEJBBMGECJ, float KHDOIBPNKOB, Vector3 BJPFPLJLIEC, bool INLEJNBCDJK, bool EJDIOCCHJDG, Space BBOJLKPBMEP = Space.Self)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct CDNPNEFAMJH<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public readonly IEnumerable<TData> MMMAPKKENHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public readonly bool EHGOLFMIEOH;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x548DF00", Offset = "0x548D300", VA = "0x18548DF00")]
	public CDNPNEFAMJH(IEnumerable<TData> MMMAPKKENHO, bool EHGOLFMIEOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public struct IEOKGCPJOKI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public readonly float DCPEEOPBCEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public readonly bool OGPPCFBNKGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public readonly Vector3 BJPFPLJLIEC;

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6E20F70", Offset = "0x6E20370", VA = "0x186E20F70")]
	public IEOKGCPJOKI(float DCPEEOPBCEK, bool OGPPCFBNKGF, Vector3 BJPFPLJLIEC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct PDAKGOIILAC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public readonly float KHDOIBPNKOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public readonly Vector3 BJPFPLJLIEC;

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x50489E0", Offset = "0x5047DE0", VA = "0x1850489E0")]
	public PDAKGOIILAC(float KHDOIBPNKOB, Vector3 BJPFPLJLIEC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public struct ONMEIBDJOMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public readonly Guid[] MMMAPKKENHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public readonly bool AKAKGLJCMKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public readonly bool KGEGICLJOAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public readonly bool FPNAMOLOKKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public readonly Vector3[] FPNBFOHEABF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public readonly Quaternion[] ACGBGFGOFBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly float[] GKLGCJMCGDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public readonly Dictionary<Guid, Vector3> HPEFBMEKAHL;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6E218D0", Offset = "0x6E20CD0", VA = "0x186E218D0")]
	public ONMEIBDJOMG(Guid[] LJIPFONJPIF, Vector3[] FPNBFOHEABF, Quaternion[] ACGBGFGOFBA, float[] GKLGCJMCGDO, Dictionary<Guid, Vector3> HPEFBMEKAHL, bool AKAKGLJCMKL = true, bool KGEGICLJOAH = true, bool FPNAMOLOKKE = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6E21700", Offset = "0x6E20B00", VA = "0x186E21700")]
	private static void CBIJDPEAOIM(Dictionary<Guid, Vector3> HPEFBMEKAHL, int EFBLKAPEEIO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public static class NBCDKCDMANA
{
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	private struct FBJDNBCDAOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public bool KNIELBDONLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public LBNNADLFMIK KLGGHLHBBKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public LBNNADLFMIK DLIIHADFLAI;
	}

	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private static FBJDNBCDAOE BCFHOKGMLKH;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static CancellationToken ALNILDJDLKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6E212E0", Offset = "0x6E206E0", VA = "0x186E212E0")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	internal static LBNNADLFMIK KLGGHLHBBKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x6E211E0", Offset = "0x6E205E0", VA = "0x186E211E0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x6E21280", Offset = "0x6E20680", VA = "0x186E21280")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6E210A0", Offset = "0x6E204A0", VA = "0x186E210A0")]
	[OAJAKDHKADM.NFPBKDCIEPB]
	internal static void CMJIFNFGFLF(LBNNADLFMIK INNDNDCHNCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6E21300", Offset = "0x6E20700", VA = "0x186E21300")]
	public static void PGLAGHNEHAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6E21190", Offset = "0x6E20590", VA = "0x186E21190")]
	private static LBNNADLFMIK DNEAOOGFOGH(LBNNADLFMIK JDNHBFMLENE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public static class HKJPDJOEHPN
{
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public enum BBLGJLHCDDC
	{
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		ICreationContextObject,
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		Guid
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x2E73FE0", Offset = "0x2E733E0", VA = "0x182E73FE0")]
	public static void KDJCCEBJHDP<T>(T BHCLGMHGMJJ, BBLGJLHCDDC DPOLEDLIAMP) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x2E73F70", Offset = "0x2E73370", VA = "0x182E73F70")]
	public static void KDJCCEBJHDP<T>(T BHCLGMHGMJJ) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x2E74150", Offset = "0x2E73550", VA = "0x182E74150")]
	public static void PACODCNLPCL<T>(T BHCLGMHGMJJ) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x2E73C50", Offset = "0x2E73050", VA = "0x182E73C50")]
	public static T CADKKGPFCDD<T>(BBLGJLHCDDC DPOLEDLIAMP) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x2E73E20", Offset = "0x2E73220", VA = "0x182E73E20")]
	public static bool FAKKNFFMHEG<T>(BBLGJLHCDDC DPOLEDLIAMP, T? COMGLBANFMI, [Out][MaybeNullWhen(false)][NotNullWhen(true)] T FCOOBLACPBN) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x2E74200", Offset = "0x2E73600", VA = "0x182E74200")]
	public static bool PKJEPHGLKKO<T>(BBLGJLHCDDC DPOLEDLIAMP) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x2E73D00", Offset = "0x2E73100", VA = "0x182E73D00")]
	public static T CADKKGPFCDD<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x2E73D60", Offset = "0x2E73160", VA = "0x182E73D60")]
	public static bool FAKKNFFMHEG<T>(T COMGLBANFMI, [Out] T FCOOBLACPBN) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x2E73D00", Offset = "0x2E73100", VA = "0x182E73D00")]
	public static bool PKJEPHGLKKO<T>() where T : class
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
internal static class NHACCFCKEBI
{
	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6E21450", Offset = "0x6E20850", VA = "0x186E21450")]
	public static void OEFFBHGMMPH(IEnumerable NCAEOPCKAMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x2FB7990", Offset = "0x2FB6D90", VA = "0x182FB7990")]
	public static void OEFFBHGMMPH<T>(T[] IGGIDMIPNHL) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x2FB7B70", Offset = "0x2FB6F70", VA = "0x182FB7B70")]
	public static void OEFFBHGMMPH<T>(T GLEGKLPKAOM) where T : notnull, Enum
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
