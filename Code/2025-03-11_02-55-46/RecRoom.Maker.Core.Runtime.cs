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
		[Cpp2IlInjected.Address(RVA = "0x98FE40", Offset = "0x98F240", VA = "0x18098FE40")]
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
		[Cpp2IlInjected.Address(RVA = "0x763EDA0", Offset = "0x763E1A0", VA = "0x18763EDA0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x990590", Offset = "0x98F990", VA = "0x180990590")]
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
		[Cpp2IlInjected.Address(RVA = "0x9905D0", Offset = "0x98F9D0", VA = "0x1809905D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x763F230", Offset = "0x763E630", VA = "0x18763F230", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2491CF0", Offset = "0x24910F0", VA = "0x182491CF0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface EJAJMEDHOMJ<TData, TReturn>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TReturn IALABAFNEOF(TData NBAMGPFDMIB);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface CIPOFIGBDMI<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ClearHoverTarget(LALJCPDLCEI PFBNJNJJOCF);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool SetHoverTarget(TData GACPILKGIFM, Collider AEBIGIJLBOG, LALJCPDLCEI PFBNJNJJOCF, [Optional] MOCNBIDPOEK? JOOAKLBNMPA);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool TryGetHoverTarget([Out] TData GACPILKGIFM);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetHoverCollider([Out] Collider AEBIGIJLBOG);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface CAELHDDDEEM<TData> : IDGBLKFLEBC, ECPDCOGDCHB<TData>, FPJMDJABBGF<TData>, GMEIMHELEMM<TData>, LCDBMNCAJEH, CLFPKCHMOPH<TData>, PGKPENACCGH, GFFFCOBBAAO
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface CLFPKCHMOPH<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 IJEEJEICDMC, Vector3 HEBBPJGOPIH, float LFDIBKEJEBM, [Out] T LHMHLMGPJCO, [Out] Vector3 JLGCNDOAGAN, [Out] Collider AEBIGIJLBOG);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 IJEEJEICDMC, Vector3 HEBBPJGOPIH, float PEPKLDIBCKP, float LFDIBKEJEBM, T[] NIHHPJEHMIF, [Out] Vector3 FHGAPNNAIOO, [Out] Collider NLMHPMCHCPE);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 IJEEJEICDMC, float PEPKLDIBCKP, Vector3 KJMPOIPKLEF, T[] NIHHPJEHMIF);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetObjectFromColliderInCurrentScope(Collider CFAAIICBIFC, [Out] T LHFKDFPGKLK);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface IDGBLKFLEBC
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Bounds PKEGKBHKHHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Transform HJPLKELPPMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Bounds GBCPKANDKMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Transform CFBCOPCMMAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Vector3 FDAAKEBICHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool DBGBMJBCEHF
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
	void SetSelectionBoundsDirty(bool IFGPDOOPFDK = true, int GHOKFLLAKJB = 0);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ShouldHideSelectionBoundsPreview(bool LJIGBPCCEAL, object OCDOGNMJENC);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface GFFFCOBBAAO
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	EBGLFEEDNOA NIAPECIOGFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface HFCFHPLMFII
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool OEOJELOCFFH
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool JDLHFJKDAAL
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool JOEKPDNOFPP
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
	void TrySetPreviousCloneMapping(Dictionary<Guid, Guid> GNGDMPPCDGA);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface GMEIMHELEMM<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool KAFODMDOKME
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int CPJKHHDLLCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<TData> CKGNKAANKEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData BBKCHLGPMMO);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData BBKCHLGPMMO);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface ECPDCOGDCHB<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T NBAMGPFDMIB, [Optional] MOCNBIDPOEK? BCKCGEMHPKH, bool DPEMHMJIEIA = true);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int LOHPPDCIAAL, IEnumerable<T> PHJGBCENEPG, bool DPEMHMJIEIA = true);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int LOHPPDCIAAL, IEnumerable<T> PHJGBCENEPG, MOCNBIDPOEK BCKCGEMHPKH, bool DPEMHMJIEIA = true);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface PGKPENACCGH
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface LCDBMNCAJEH
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool JBNNMDHEFPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool CAKBNOMBOJL
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool FNMCBAJCEOO
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool OCPCNJDIIAC
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class LFIKCPMBJKA<TReceiver> : IIJBOIBJADH<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x44DA1D0", Offset = "0x44D95D0", VA = "0x1844DA1D0")]
	public LFIKCPMBJKA(TReceiver DGAEDICPJIG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public abstract class AKCEGODIBHA<TReceiver, TFromTask> : IIJBOIBJADH<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x44DA1D0", Offset = "0x44D95D0", VA = "0x1844DA1D0")]
	public AKCEGODIBHA(TReceiver DGAEDICPJIG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public abstract class IIJBOIBJADH<TReceiver, TFromExecute> where TReceiver : notnull where TFromExecute : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	protected TReceiver DGAEDICPJIG;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4813AB0", Offset = "0x4812EB0", VA = "0x184813AB0")]
	public IIJBOIBJADH(TReceiver DGAEDICPJIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute HPGKBBIDPFC();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class MLIOOKFMLOM<TReceiver, TResult> : IIJBOIBJADH<TReceiver, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x44DA1D0", Offset = "0x44D95D0", VA = "0x1844DA1D0")]
	public MLIOOKFMLOM(TReceiver DGAEDICPJIG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct LGDJOIGFHLK<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public TGroup NOCAKIHLKEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public TData JMOGDFLIAAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public IEnumerable<TData> IEMFDIFGOMK;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x24A2810", Offset = "0x24A1C10", VA = "0x1824A2810")]
	public LGDJOIGFHLK(TGroup ONKFGBCBEKF, TData KGPLJAPJJAK, IEnumerable<TData> KMCCOKIFAKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct NPDNLHLLJFA<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public TGroup NOCAKIHLKEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public IEnumerable<TData> IEMFDIFGOMK;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x9CC970", Offset = "0x9CBD70", VA = "0x1809CC970")]
	public NPDNLHLLJFA(TGroup ONKFGBCBEKF, IEnumerable<TData> KMCCOKIFAKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct CBPMHLIEHNP<TGroup> where TGroup : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public TGroup NOCAKIHLKEG;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0xC1B040", Offset = "0xC1A440", VA = "0x180C1B040")]
	public CBPMHLIEHNP(TGroup ONKFGBCBEKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct NDNEBNKIDEE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public IEnumerable<Guid> IEMFDIFGOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public Guid JAJIHNAFAAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public readonly bool DACFMEGNJHK;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x763ED60", Offset = "0x763E160", VA = "0x18763ED60")]
	public NDNEBNKIDEE(IEnumerable<Guid> KMCCOKIFAKF, Guid ECPIPHEMJPF, bool OCIOLGOICIO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct MEOMFHFGGCB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public Guid JAJIHNAFAAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly bool DACFMEGNJHK;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2372500", Offset = "0x2371900", VA = "0x182372500")]
	public MEOMFHFGGCB(Guid ECPIPHEMJPF, bool OCIOLGOICIO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface OCGCKODEEBB<TGroup, TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GCIEBMHHLOK LCKPOLLKDLO(LGDJOIGFHLK<TGroup, TData> FEHMHPGHEMB);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GCIEBMHHLOK OBJDOOJFHLO(LGDJOIGFHLK<TGroup, TData> FEHMHPGHEMB);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GCIEBMHHLOK BALFLFPEFEB(NPDNLHLLJFA<TGroup, TData> FEHMHPGHEMB);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GCIEBMHHLOK NJAGBJLDPPG(CBPMHLIEHNP<TGroup> FEHMHPGHEMB);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface GOEEIBIIHPE
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<GCIEBMHHLOK> LCKPOLLKDLO(NDNEBNKIDEE FEHMHPGHEMB);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<GCIEBMHHLOK> OBJDOOJFHLO(MEOMFHFGGCB FEHMHPGHEMB);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class FIPPCFIANCN<TGroup, TData> : MLIOOKFMLOM<OCGCKODEEBB<TGroup, TData>, GCIEBMHHLOK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly NPDNLHLLJFA<TGroup, TData> FEHMHPGHEMB;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4500CC0", Offset = "0x45000C0", VA = "0x184500CC0")]
	public FIPPCFIANCN(TGroup ONKFGBCBEKF, IEnumerable<TData> KMCCOKIFAKF, OCGCKODEEBB<TGroup, TData> DGAEDICPJIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x4500C00", Offset = "0x4500000", VA = "0x184500C00", Slot = "4")]
	public override GCIEBMHHLOK HPGKBBIDPFC()
	{
		return default(GCIEBMHHLOK);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class AIBLFDGFJIM<TGroup, TData> : MLIOOKFMLOM<OCGCKODEEBB<TGroup, TData>, GCIEBMHHLOK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly LGDJOIGFHLK<TGroup, TData> FEHMHPGHEMB;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4723850", Offset = "0x4722C50", VA = "0x184723850")]
	public AIBLFDGFJIM(TGroup ONKFGBCBEKF, TData PIJNMKGCOHL, IEnumerable<TData> KMCCOKIFAKF, OCGCKODEEBB<TGroup, TData> DGAEDICPJIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x4723780", Offset = "0x4722B80", VA = "0x184723780", Slot = "4")]
	public override GCIEBMHHLOK HPGKBBIDPFC()
	{
		return default(GCIEBMHHLOK);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class OFOPPNKCDKH<TGroup, TData> : MLIOOKFMLOM<OCGCKODEEBB<TGroup, TData>, GCIEBMHHLOK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly CBPMHLIEHNP<TGroup> FEHMHPGHEMB;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x4A28AC0", Offset = "0x4A27EC0", VA = "0x184A28AC0")]
	public OFOPPNKCDKH(TGroup ONKFGBCBEKF, OCGCKODEEBB<TGroup, TData> DGAEDICPJIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x4FA1D00", Offset = "0x4FA1100", VA = "0x184FA1D00", Slot = "4")]
	public override GCIEBMHHLOK HPGKBBIDPFC()
	{
		return default(GCIEBMHHLOK);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class IPODGFEJGNH<TGroup, TData> : MLIOOKFMLOM<OCGCKODEEBB<TGroup, TData>, GCIEBMHHLOK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly LGDJOIGFHLK<TGroup, TData> FEHMHPGHEMB;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4723850", Offset = "0x4722C50", VA = "0x184723850")]
	public IPODGFEJGNH(TGroup ONKFGBCBEKF, TData KGPLJAPJJAK, IEnumerable<TData> KMCCOKIFAKF, OCGCKODEEBB<TGroup, TData> DGAEDICPJIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4844C00", Offset = "0x4844000", VA = "0x184844C00", Slot = "4")]
	public override GCIEBMHHLOK HPGKBBIDPFC()
	{
		return default(GCIEBMHHLOK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class BENNBPPMPNI : AKCEGODIBHA<GOEEIBIIHPE, GCIEBMHHLOK>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private struct ILAHBPMOIDF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public AsyncTaskMethodBuilder<GCIEBMHHLOK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public BENNBPPMPNI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private TaskAwaiter<GCIEBMHHLOK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x763E170", Offset = "0x763D570", VA = "0x18763E170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x763E410", Offset = "0x763D810", VA = "0x18763E410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private NDNEBNKIDEE FEHMHPGHEMB;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x763D6D0", Offset = "0x763CAD0", VA = "0x18763D6D0")]
	public BENNBPPMPNI(IEnumerable<Guid> OHJBECJCJKE, Guid ECPIPHEMJPF, bool OCIOLGOICIO, GOEEIBIIHPE DGAEDICPJIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x763D5E0", Offset = "0x763C9E0", VA = "0x18763D5E0", Slot = "4")]
	[AsyncStateMachine(typeof(ILAHBPMOIDF))]
	public override Task<GCIEBMHHLOK> HPGKBBIDPFC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class FJACEFHCKID : AKCEGODIBHA<GOEEIBIIHPE, GCIEBMHHLOK>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private struct IDNIPNCPDEE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public AsyncTaskMethodBuilder<GCIEBMHHLOK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public FJACEFHCKID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private TaskAwaiter<GCIEBMHHLOK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x763DE60", Offset = "0x763D260", VA = "0x18763DE60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x763E100", Offset = "0x763D500", VA = "0x18763E100", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly MEOMFHFGGCB FEHMHPGHEMB;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x763DCC0", Offset = "0x763D0C0", VA = "0x18763DCC0")]
	public FJACEFHCKID(Guid ECPIPHEMJPF, bool OCIOLGOICIO, GOEEIBIIHPE DGAEDICPJIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x763DBD0", Offset = "0x763CFD0", VA = "0x18763DBD0", Slot = "4")]
	[AsyncStateMachine(typeof(IDNIPNCPDEE))]
	public override Task<GCIEBMHHLOK> HPGKBBIDPFC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public readonly struct JJAFEDIKIFP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly MCDKEDFEOBL BCCKJDGBHLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly bool DACFMEGNJHK;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x763E480", Offset = "0x763D880", VA = "0x18763E480")]
	public JJAFEDIKIFP(MCDKEDFEOBL EJJHIBGMEFJ, bool OCIOLGOICIO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface GPICPPGBLFD<TSpawnType> where TSpawnType : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> HPGKBBIDPFC(JJAFEDIKIFP ADIMCPINHKG);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class OJGJNKCJGMD<TSpawnType> : AKCEGODIBHA<GPICPPGBLFD<TSpawnType>, TSpawnType> where TSpawnType : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private struct AIKKLGACCKO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AsyncTaskMethodBuilder<TSpawnType> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public OJGJNKCJGMD<TSpawnType> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private TaskAwaiter<TSpawnType> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x47245D0", Offset = "0x47239D0", VA = "0x1847245D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x4129310", Offset = "0x4128710", VA = "0x184129310", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly JJAFEDIKIFP ADIMCPINHKG;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x4FAC220", Offset = "0x4FAB620", VA = "0x184FAC220")]
	public OJGJNKCJGMD(MCDKEDFEOBL EJJHIBGMEFJ, bool OCIOLGOICIO, GPICPPGBLFD<TSpawnType> DGAEDICPJIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x4FABF20", Offset = "0x4FAB320", VA = "0x184FABF20", Slot = "4")]
	[AsyncStateMachine(typeof(OJGJNKCJGMD<>.AIKKLGACCKO))]
	public override Task<TSpawnType> HPGKBBIDPFC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public readonly struct MCDKEDFEOBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly bool KBCEECNAHHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly Vector3 CAEGCGLHELG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly Vector3 LLLAMAJMODF;

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x763E9C0", Offset = "0x763DDC0", VA = "0x18763E9C0")]
	public MCDKEDFEOBL(Transform LEJDMBGMGNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x763EA30", Offset = "0x763DE30", VA = "0x18763EA30")]
	public MCDKEDFEOBL(Vector3 BLIFKOEAPLP, Vector3 HJBDDDIFEBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x763E910", Offset = "0x763DD10", VA = "0x18763E910")]
	public static MCDKEDFEOBL ILDFNOMPHGD()
	{
		return default(MCDKEDFEOBL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x763E940", Offset = "0x763DD40", VA = "0x18763E940")]
	private MCDKEDFEOBL(bool JGEEHPPLODP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct MOBFLDAIBDN<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public TNode MDJLIMBFLCE;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x4E1D470", Offset = "0x4E1C870", VA = "0x184E1D470")]
	public MOBFLDAIBDN(TNode MDJLIMBFLCE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct LCIFLNBGFLE<TNode, TReparentOperations> where TNode : notnull where TReparentOperations : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public TNode MJDJJBPDGPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public TReparentOperations BFDPJMLLCMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public GHLGFJPGCGM PIAEKNNENAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly bool DACFMEGNJHK;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x4BD6AE0", Offset = "0x4BD5EE0", VA = "0x184BD6AE0")]
	public LCIFLNBGFLE(TNode MJDJJBPDGPB, TReparentOperations BFDPJMLLCMO, GHLGFJPGCGM PIAEKNNENAM, bool OCIOLGOICIO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface LOCIKDFHEGH<TNode, TReparentOperations>
{
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool COAILNABPLL([In] MOBFLDAIBDN<TNode> CLEDNOCPPPF);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MFIOFDGKELO([In] LCIFLNBGFLE<TNode, TReparentOperations> ICLHKLLOIHH);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HLFIJIOOBKN();
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class IHDINHKLPLA<TNode, TReparentOperations> : LFIKCPMBJKA<LOCIKDFHEGH<TNode, TReparentOperations>>
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x44DA1D0", Offset = "0x44D95D0", VA = "0x1844DA1D0")]
	public IHDINHKLPLA(LOCIKDFHEGH<TNode, TReparentOperations> DGAEDICPJIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x4810F40", Offset = "0x4810340", VA = "0x184810F40", Slot = "4")]
	public override bool HPGKBBIDPFC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class LIBDAHFDFML<TNode, TReparentOperations> : LFIKCPMBJKA<LOCIKDFHEGH<TNode, TReparentOperations>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly LCIFLNBGFLE<TNode, TReparentOperations> ICLHKLLOIHH;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x4C09060", Offset = "0x4C08460", VA = "0x184C09060")]
	public LIBDAHFDFML(TNode MJDJJBPDGPB, TReparentOperations BFDPJMLLCMO, GHLGFJPGCGM PIAEKNNENAM, LOCIKDFHEGH<TNode, TReparentOperations> DGAEDICPJIG, bool OCIOLGOICIO = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x4626930", Offset = "0x4625D30", VA = "0x184626930", Slot = "4")]
	public override bool HPGKBBIDPFC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class AFMOEIHNPHE<TNode, TReparentOperations> : LFIKCPMBJKA<LOCIKDFHEGH<TNode, TReparentOperations>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly MOBFLDAIBDN<TNode> CLEDNOCPPPF;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x463C3C0", Offset = "0x463B7C0", VA = "0x18463C3C0")]
	public AFMOEIHNPHE(TNode JMJOPAAMCIC, LOCIKDFHEGH<TNode, TReparentOperations> DGAEDICPJIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x4125650", Offset = "0x4124A50", VA = "0x184125650", Slot = "4")]
	public override bool HPGKBBIDPFC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct DMLNBCFFBOH<TSpawnInfo> where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public TSpawnInfo DJEBKHFGKKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public Vector3 HJBDDDIFEBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public Quaternion NBFJKGINHEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public float JKHHCOODJNJ;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x640CEB0", Offset = "0x640C2B0", VA = "0x18640CEB0")]
	public DMLNBCFFBOH(TSpawnInfo DJEBKHFGKKI, Vector3 HJBDDDIFEBJ, Quaternion NBFJKGINHEC, float JKHHCOODJNJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface EBKNKKONHBK<TSpawnType, TSpawnInfo>
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> LJHJGDKOOCG([In] DMLNBCFFBOH<TSpawnInfo> CJMCBEFAOLF, CancellationToken MLAPMBKLAOF);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public class CKFMCIEANOM<TSpawnType, TSpawnInfo> : AKCEGODIBHA<EBKNKKONHBK<TSpawnType, TSpawnInfo>, TSpawnType> where TSpawnType : notnull where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly DMLNBCFFBOH<TSpawnInfo> BKIADHLGJLK;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x615CFF0", Offset = "0x615C3F0", VA = "0x18615CFF0")]
	public CKFMCIEANOM(TSpawnInfo JAJJFDPPFCP, Vector3 HJBDDDIFEBJ, Quaternion NBFJKGINHEC, float JKHHCOODJNJ, EBKNKKONHBK<TSpawnType, TSpawnInfo> DGAEDICPJIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x4C0D6B0", Offset = "0x4C0CAB0", VA = "0x184C0D6B0", Slot = "4")]
	public override Task<TSpawnType> HPGKBBIDPFC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public readonly struct LFGMLFBDLMD<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly IEnumerable<TData> IEMFDIFGOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly bool DACFMEGNJHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly bool PCFBBFDPJDO;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x4BE81F0", Offset = "0x4BE75F0", VA = "0x184BE81F0")]
	public LFGMLFBDLMD(IEnumerable<TData> KMCCOKIFAKF, bool OCIOLGOICIO = false, bool GPLJGCMJOPG = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface HMNJBKPAHJE<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<GCIEBMHHLOK> AJBIALDMLHK([In] LFGMLFBDLMD<TData> JCEDOLCNPPA, CancellationToken MLAPMBKLAOF);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class LKMEACIBOHG<TData> : AKCEGODIBHA<HMNJBKPAHJE<TData>, GCIEBMHHLOK> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly LFGMLFBDLMD<TData> PHGMCKDHPEA;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x4C0D840", Offset = "0x4C0CC40", VA = "0x184C0D840")]
	public LKMEACIBOHG(IEnumerable<TData> KMCCOKIFAKF, bool OCIOLGOICIO, HMNJBKPAHJE<TData> DGAEDICPJIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x4C0D6B0", Offset = "0x4C0CAB0", VA = "0x184C0D6B0", Slot = "4")]
	public override Task<GCIEBMHHLOK> HPGKBBIDPFC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct NMOHLDNJGFP<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly T GACPILKGIFM;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x4C15970", Offset = "0x4C14D70", VA = "0x184C15970")]
	public NMOHLDNJGFP(T HAEMAALIGIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface PENKIHKMBFC<T>
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool COAILNABPLL([In] NMOHLDNJGFP<T> CGNMHHLOHHD);

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MFIOFDGKELO();
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface LLGAFLAKPDC<T>
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HPGKBBIDPFC([In] CEJEKKCJPAE<T> PMOCGDBCECH);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct CEJEKKCJPAE<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly T GACPILKGIFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly bool NLKOEKFPILE;

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6072200", Offset = "0x6071600", VA = "0x186072200")]
	public CEJEKKCJPAE(T HAEMAALIGIH, bool NMGKLAAIBFO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class NFFNKAFKLGF<T> : LFIKCPMBJKA<PENKIHKMBFC<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x44DA1D0", Offset = "0x44D95D0", VA = "0x1844DA1D0")]
	public NFFNKAFKLGF(PENKIHKMBFC<T> DGAEDICPJIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x4E81D90", Offset = "0x4E81190", VA = "0x184E81D90", Slot = "4")]
	public override bool HPGKBBIDPFC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class JLADHKFEEKC<T> : LFIKCPMBJKA<PENKIHKMBFC<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly NMOHLDNJGFP<T> CGNMHHLOHHD;

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x4A28A30", Offset = "0x4A27E30", VA = "0x184A28A30")]
	public JLADHKFEEKC(T GACPILKGIFM, PENKIHKMBFC<T> DGAEDICPJIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x4125650", Offset = "0x4124A50", VA = "0x184125650", Slot = "4")]
	public override bool HPGKBBIDPFC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class CAGLFEBJNAD<T> : LFIKCPMBJKA<LLGAFLAKPDC<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly CEJEKKCJPAE<T> PMOCGDBCECH;

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x60645B0", Offset = "0x60639B0", VA = "0x1860645B0")]
	public CAGLFEBJNAD(T GACPILKGIFM, bool NMGKLAAIBFO, LLGAFLAKPDC<T> DGAEDICPJIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x4125650", Offset = "0x4124A50", VA = "0x184125650", Slot = "4")]
	public override bool HPGKBBIDPFC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct APKFEJKAAMD<TData> where TData : notnull, BHDDMKMHIJN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public IEnumerable<TData> IEMFDIFGOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public bool FIDCHIGHEAG;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x4871870", Offset = "0x4870C70", VA = "0x184871870")]
	public APKFEJKAAMD(IEnumerable<TData> CDOEHDKHEAB, bool EOLFIHADNKH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public struct OHAOFGGIDIL<TData> where TData : notnull, BHDDMKMHIJN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public List<TData> IEMFDIFGOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public List<bool> EAHIDJLMOGB;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x4FA2D90", Offset = "0x4FA2190", VA = "0x184FA2D90")]
	public OHAOFGGIDIL(List<TData> CDOEHDKHEAB, List<bool> IFBDGGOJOPP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface BHDDMKMHIJN
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool FIHJHENNHII
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface JADHJEDMICM<TData> where TData : BHDDMKMHIJN
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HPGKBBIDPFC([In] APKFEJKAAMD<TData> DNGEFLNDNFP);

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HPGKBBIDPFC([In] OHAOFGGIDIL<TData> DNGEFLNDNFP);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface BNMMCEHHBFN<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EJBKDMFMNNJ(T GACPILKGIFM);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class IFAHNMLLNOL<TData> : LFIKCPMBJKA<JADHJEDMICM<TData>> where TData : notnull, BHDDMKMHIJN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly APKFEJKAAMD<TData> DNGEFLNDNFP;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x480C410", Offset = "0x480B810", VA = "0x18480C410")]
	public IFAHNMLLNOL(List<TData> KMCCOKIFAKF, bool FIDCHIGHEAG, JADHJEDMICM<TData> DGAEDICPJIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x4125650", Offset = "0x4124A50", VA = "0x184125650", Slot = "4")]
	public override bool HPGKBBIDPFC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class EAHLOFCKKGK<TData> : LFIKCPMBJKA<JADHJEDMICM<TData>> where TData : notnull, BHDDMKMHIJN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly OHAOFGGIDIL<TData> DNGEFLNDNFP;

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x40E23A0", Offset = "0x40E17A0", VA = "0x1840E23A0")]
	public EAHLOFCKKGK(List<TData> KMCCOKIFAKF, List<bool> EAHIDJLMOGB, JADHJEDMICM<TData> DGAEDICPJIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x40E22E0", Offset = "0x40E16E0", VA = "0x1840E22E0", Slot = "4")]
	public override bool HPGKBBIDPFC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface CJGNOPCJIKD<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<GCIEBMHHLOK> HPGKBBIDPFC(AKHNLFLHBMC<TData> OENOJCNPENH);
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class EMAIBMDJMBB<TData> : AKCEGODIBHA<CJGNOPCJIKD<TData>, GCIEBMHHLOK> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct PEEJHJJPCCF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public AsyncTaskMethodBuilder<GCIEBMHHLOK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public EMAIBMDJMBB<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter<GCIEBMHHLOK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x508EC00", Offset = "0x508E000", VA = "0x18508EC00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x508EEE0", Offset = "0x508E2E0", VA = "0x18508EEE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly AKHNLFLHBMC<TData> GANMLHLNMFF;

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x412FAF0", Offset = "0x412EEF0", VA = "0x18412FAF0")]
	public EMAIBMDJMBB(TData AJLAEFMEEDI, IReadOnlyList<TData> IJAOGDHMDCL, bool OCIOLGOICIO, CJGNOPCJIKD<TData> DGAEDICPJIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x412F9F0", Offset = "0x412EDF0", VA = "0x18412F9F0", Slot = "4")]
	[AsyncStateMachine(typeof(EMAIBMDJMBB<>.PEEJHJJPCCF))]
	public override Task<GCIEBMHHLOK> HPGKBBIDPFC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct AKHNLFLHBMC<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public TData GAFLGLHDIKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public IReadOnlyList<TData> LKEHOEFPFKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public bool DACFMEGNJHK;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x47366B0", Offset = "0x4735AB0", VA = "0x1847366B0")]
	public AKHNLFLHBMC(TData AJLAEFMEEDI, IReadOnlyList<TData> IJAOGDHMDCL, bool OCIOLGOICIO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface MKHOEIAKBJB<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HPGKBBIDPFC([In] FCACCMMIHNF<TData> IADNHNOCGDC);
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface CLPMIAHLBHG<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HPGKBBIDPFC([In] EPLLOJFHCJC<TData> IADNHNOCGDC);
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface NNDMKLOLCME<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MPMEFAGHJLK([In] NHFMEGAGKEI<TData> IADNHNOCGDC);

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MFIOFDGKELO();
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class KMHPIKEKNGM<TData> : LFIKCPMBJKA<MKHOEIAKBJB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly FCACCMMIHNF<TData> IADNHNOCGDC;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x4B3F420", Offset = "0x4B3E820", VA = "0x184B3F420")]
	public KMHPIKEKNGM(IEnumerable<TData> KMCCOKIFAKF, KJLMKLABEMK MLLLJKFOPGI, KOCPEJPPMDN GIEDFKFHBFF, float ILNCJACLHFE, bool OCIOLGOICIO, MKHOEIAKBJB<TData> DGAEDICPJIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x4125650", Offset = "0x4124A50", VA = "0x184125650", Slot = "4")]
	public override bool HPGKBBIDPFC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public class COMEDGJFLAC<TData> : LFIKCPMBJKA<CLPMIAHLBHG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly EPLLOJFHCJC<TData> IADNHNOCGDC;

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x620D770", Offset = "0x620CB70", VA = "0x18620D770")]
	public COMEDGJFLAC(TData[] KMCCOKIFAKF, KJLMKLABEMK[] MLLLJKFOPGI, KOCPEJPPMDN[] GIEDFKFHBFF, float[] ILNCJACLHFE, CLPMIAHLBHG<TData> DGAEDICPJIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x4A43900", Offset = "0x4A42D00", VA = "0x184A43900", Slot = "4")]
	public override bool HPGKBBIDPFC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class GNBAHBMIFIM<TData> : LFIKCPMBJKA<NNDMKLOLCME<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x44DA1D0", Offset = "0x44D95D0", VA = "0x1844DA1D0")]
	public GNBAHBMIFIM(NNDMKLOLCME<TData> DGAEDICPJIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x46C3240", Offset = "0x46C2640", VA = "0x1846C3240", Slot = "4")]
	public override bool HPGKBBIDPFC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class JPPAOEPOAMA<TData> : LFIKCPMBJKA<NNDMKLOLCME<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private readonly NHFMEGAGKEI<TData> IADNHNOCGDC;

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x4A439B0", Offset = "0x4A42DB0", VA = "0x184A439B0")]
	public JPPAOEPOAMA(IEnumerable<TData> KMCCOKIFAKF, KJLMKLABEMK MLLLJKFOPGI, KOCPEJPPMDN GIEDFKFHBFF, float ILNCJACLHFE, NNDMKLOLCME<TData> DGAEDICPJIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x4A43900", Offset = "0x4A42D00", VA = "0x184A43900", Slot = "4")]
	public override bool HPGKBBIDPFC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct FCACCMMIHNF<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public IEnumerable<TData> IEMFDIFGOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public KJLMKLABEMK HCJHNHMBDDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public KOCPEJPPMDN AAJNLIMEBFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public float ILNCJACLHFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public bool OCIOLGOICIO;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x44EC570", Offset = "0x44EB970", VA = "0x1844EC570")]
	public FCACCMMIHNF(IEnumerable<TData> KMCCOKIFAKF, KJLMKLABEMK MLLLJKFOPGI, KOCPEJPPMDN GIEDFKFHBFF, float ILNCJACLHFE, bool OCIOLGOICIO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public struct EPLLOJFHCJC<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public TData[] IEMFDIFGOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public KJLMKLABEMK[] HCJHNHMBDDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public KOCPEJPPMDN[] AAJNLIMEBFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public float[] ILNCJACLHFE;

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x414FB90", Offset = "0x414EF90", VA = "0x18414FB90")]
	public EPLLOJFHCJC(TData[] KMCCOKIFAKF, KJLMKLABEMK[] MLLLJKFOPGI, KOCPEJPPMDN[] GIEDFKFHBFF, float[] ILNCJACLHFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct NHFMEGAGKEI<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public IEnumerable<TData> IEMFDIFGOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public KJLMKLABEMK HCJHNHMBDDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public KOCPEJPPMDN AAJNLIMEBFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public float ILNCJACLHFE;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x4E883F0", Offset = "0x4E877F0", VA = "0x184E883F0")]
	public NHFMEGAGKEI(IEnumerable<TData> KMCCOKIFAKF, KJLMKLABEMK MLLLJKFOPGI, KOCPEJPPMDN GIEDFKFHBFF, float ILNCJACLHFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface FPJMDJABBGF<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BALFLFPEFEB([In] GFDGBGPFMBH<TData> JCEDOLCNPPA);

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NJAGBJLDPPG([In] GFDGBGPFMBH<TData> JCEDOLCNPPA);

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DMAAKFNHAPF([In] bool MONIHCHHBOG);

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DHOBALHLCKL([In] GFDGBGPFMBH<TData> JCEDOLCNPPA);

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ONGOFLPBJAJ();

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool FAHGEBKDENO([In] TData ABNFNBCPJFE);
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class DMHBKILMIAO<TData> : LFIKCPMBJKA<FPJMDJABBGF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly GFDGBGPFMBH<TData> JCEDOLCNPPA;

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x640C2F0", Offset = "0x640B6F0", VA = "0x18640C2F0")]
	public DMHBKILMIAO(List<TData> GONANEIKMGH, FPJMDJABBGF<TData> DGAEDICPJIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x4125650", Offset = "0x4124A50", VA = "0x184125650", Slot = "4")]
	public override bool HPGKBBIDPFC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class BFALOCMHFPL<TData> : LFIKCPMBJKA<FPJMDJABBGF<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x44DA1D0", Offset = "0x44D95D0", VA = "0x1844DA1D0")]
	public BFALOCMHFPL(FPJMDJABBGF<TData> DGAEDICPJIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x5BA4B50", Offset = "0x5BA3F50", VA = "0x185BA4B50", Slot = "4")]
	public override bool HPGKBBIDPFC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class JCPIIDGDCJA<TData> : LFIKCPMBJKA<FPJMDJABBGF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly bool OCIOLGOICIO;

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x49FBC80", Offset = "0x49FB080", VA = "0x1849FBC80")]
	public JCPIIDGDCJA(bool OCIOLGOICIO, FPJMDJABBGF<TData> DGAEDICPJIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x49FBC20", Offset = "0x49FB020", VA = "0x1849FBC20", Slot = "4")]
	public override bool HPGKBBIDPFC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class LKMBJOBGCLA<TData> : LFIKCPMBJKA<FPJMDJABBGF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly GFDGBGPFMBH<TData> JCEDOLCNPPA;

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x4C0D610", Offset = "0x4C0CA10", VA = "0x184C0D610")]
	public LKMBJOBGCLA(List<TData> GONANEIKMGH, bool OCIOLGOICIO, FPJMDJABBGF<TData> DGAEDICPJIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x40E22E0", Offset = "0x40E16E0", VA = "0x1840E22E0", Slot = "4")]
	public override bool HPGKBBIDPFC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class IFOLCHBMNGF<TData> : LFIKCPMBJKA<FPJMDJABBGF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly TData ABNFNBCPJFE;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x480D500", Offset = "0x480C900", VA = "0x18480D500")]
	public IFOLCHBMNGF(TData ABNFNBCPJFE, FPJMDJABBGF<TData> DGAEDICPJIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x480D380", Offset = "0x480C780", VA = "0x18480D380", Slot = "4")]
	public override bool HPGKBBIDPFC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public class ACMNHFJIJCE<TData> : LFIKCPMBJKA<FPJMDJABBGF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly GFDGBGPFMBH<TData> JCEDOLCNPPA;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x462AE80", Offset = "0x462A280", VA = "0x18462AE80")]
	public ACMNHFJIJCE(IEnumerable<TData> GONANEIKMGH, FPJMDJABBGF<TData> DGAEDICPJIG, bool OCIOLGOICIO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x462AD10", Offset = "0x462A110", VA = "0x18462AD10", Slot = "4")]
	public override bool HPGKBBIDPFC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct GFDGBGPFMBH<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public IEnumerable<TData> IEMFDIFGOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public bool OCIOLGOICIO;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x46640D0", Offset = "0x46634D0", VA = "0x1846640D0")]
	public GFDGBGPFMBH(IEnumerable<TData> CDOEHDKHEAB, bool DMGEMJFDAHD = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface JODCGFHOGLD
{
	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<GCIEBMHHLOK> HPGKBBIDPFC(KLJIPOOIJGF EPOPCNPEDEO);
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class BGNLAOALODM : AKCEGODIBHA<JODCGFHOGLD, GCIEBMHHLOK>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private struct MPDPFJHDDOE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public AsyncTaskMethodBuilder<GCIEBMHHLOK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public BGNLAOALODM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private TaskAwaiter<GCIEBMHHLOK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x763EA80", Offset = "0x763DE80", VA = "0x18763EA80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x763ECF0", Offset = "0x763E0F0", VA = "0x18763ECF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly KLJIPOOIJGF JDHPCCDJEPE;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x763D880", Offset = "0x763CC80", VA = "0x18763D880")]
	public BGNLAOALODM(bool OCIOLGOICIO, JODCGFHOGLD DGAEDICPJIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x763D790", Offset = "0x763CB90", VA = "0x18763D790", Slot = "4")]
	[AsyncStateMachine(typeof(MPDPFJHDDOE))]
	public override Task<GCIEBMHHLOK> HPGKBBIDPFC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public struct KLJIPOOIJGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public bool DACFMEGNJHK;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x27C2F60", Offset = "0x27C2360", VA = "0x1827C2F60")]
	public KLJIPOOIJGF(bool OCIOLGOICIO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public readonly struct KAJFGINAPPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public readonly bool HEINJDIKIHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public readonly bool CNMHCFDKIOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public readonly bool JKHHCOODJNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public readonly bool OCIOLGOICIO;

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x56AA600", Offset = "0x56A9A00", VA = "0x1856AA600")]
	public KAJFGINAPPC(bool HEINJDIKIHC, bool CNMHCFDKIOA, bool JKHHCOODJNJ, bool OCIOLGOICIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x763E4A0", Offset = "0x763D8A0", VA = "0x18763E4A0")]
	public KAJFGINAPPC(bool CNMHCFDKIOA, bool OCIOLGOICIO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public interface AFKFFOPDAGP
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IGIJJKIHIHA(KAJFGINAPPC LGBINGEMFAH);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EHAABMDHCMC(KAJFGINAPPC LGBINGEMFAH);
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class IAHJEJJOBHC : LFIKCPMBJKA<AFKFFOPDAGP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly KAJFGINAPPC LGBINGEMFAH;

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x763DDD0", Offset = "0x763D1D0", VA = "0x18763DDD0")]
	public IAHJEJJOBHC(bool NCNOHDPHPJB, bool CNMHCFDKIOA, bool JKHHCOODJNJ, bool OCIOLGOICIO, AFKFFOPDAGP DGAEDICPJIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x763DD80", Offset = "0x763D180", VA = "0x18763DD80", Slot = "4")]
	public override bool HPGKBBIDPFC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class OACLFMDFKDI : LFIKCPMBJKA<AFKFFOPDAGP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly KAJFGINAPPC LGBINGEMFAH;

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x763EE70", Offset = "0x763E270", VA = "0x18763EE70")]
	public OACLFMDFKDI(bool CNMHCFDKIOA, bool OCIOLGOICIO, AFKFFOPDAGP DGAEDICPJIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x763EE20", Offset = "0x763E220", VA = "0x18763EE20", Slot = "4")]
	public override bool HPGKBBIDPFC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public interface HBMHOJDKIHC
{
	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HPGKBBIDPFC([In] LLAOJPCPBKF BKEDAFLGEEC);
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class FGGENDJBOOI : LFIKCPMBJKA<HBMHOJDKIHC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly LLAOJPCPBKF BKEDAFLGEEC;

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x763D9F0", Offset = "0x763CDF0", VA = "0x18763D9F0")]
	public FGGENDJBOOI(Guid[] CPFPMNOPPIP, Vector3[] AENMKEFKKPG, Quaternion[] PGJBCMBHBLA, float[] HNNAJJLJDKD, Dictionary<Guid, Vector3> BHNIGBAKDFF, HBMHOJDKIHC DGAEDICPJIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x763D940", Offset = "0x763CD40", VA = "0x18763D940", Slot = "4")]
	public override bool HPGKBBIDPFC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public interface DBKOAPLEPAK<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool COAILNABPLL([In] MFFNNKJMCGO<TData> CLEDNOCPPPF);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MPMEFAGHJLK([In] MKIJJFJEHEI IBEMJPKNFAD);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MPMEFAGHJLK([In] GGLGODNJFJF IBEMJPKNFAD);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MFIOFDGKELO();
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class GFFIEDHHPIH<TData> : LFIKCPMBJKA<DBKOAPLEPAK<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x44DA1D0", Offset = "0x44D95D0", VA = "0x1844DA1D0")]
	public GFFIEDHHPIH(DBKOAPLEPAK<TData> DGAEDICPJIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x4665850", Offset = "0x4664C50", VA = "0x184665850", Slot = "4")]
	public override bool HPGKBBIDPFC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public class HPMJKLOCKED<TData> : LFIKCPMBJKA<DBKOAPLEPAK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private readonly MKIJJFJEHEI NPJEOFHGPBP;

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x475D7A0", Offset = "0x475CBA0", VA = "0x18475D7A0")]
	public HPMJKLOCKED(Vector3 GBDBEEJPEPL, bool MIOHMOMEHEL, DBKOAPLEPAK<TData> DGAEDICPJIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x4652430", Offset = "0x4651830", VA = "0x184652430", Slot = "4")]
	public override bool HPGKBBIDPFC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class OOELGBLPPLB<TData> : LFIKCPMBJKA<DBKOAPLEPAK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly GGLGODNJFJF NPJEOFHGPBP;

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x4FDD4A0", Offset = "0x4FDC8A0", VA = "0x184FDD4A0")]
	public OOELGBLPPLB(Guid DPBHPPMCCJG, int FFCBHHABFJN, Vector3 HJBDDDIFEBJ, Quaternion NBFJKGINHEC, float EJOLINDBPPE, bool MIOHMOMEHEL, DBKOAPLEPAK<TData> DGAEDICPJIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x4FDD440", Offset = "0x4FDC840", VA = "0x184FDD440", Slot = "4")]
	public override bool HPGKBBIDPFC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public class CMMDIPDGMFL<TData> : LFIKCPMBJKA<DBKOAPLEPAK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly MFFNNKJMCGO<TData> NPJEOFHGPBP;

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x6163330", Offset = "0x6162730", VA = "0x186163330")]
	public CMMDIPDGMFL(TData GACPILKGIFM, bool OCIOLGOICIO, DBKOAPLEPAK<TData> DGAEDICPJIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x4125650", Offset = "0x4124A50", VA = "0x184125650", Slot = "4")]
	public override bool HPGKBBIDPFC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public struct MKIJJFJEHEI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public readonly Vector3 GBDBEEJPEPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public readonly bool MIOHMOMEHEL;

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x763EA60", Offset = "0x763DE60", VA = "0x18763EA60")]
	public MKIJJFJEHEI(Vector3 GBDBEEJPEPL, bool MIOHMOMEHEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public struct GGLGODNJFJF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public readonly Guid DPBHPPMCCJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public readonly int FFCBHHABFJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public readonly Vector3 HJBDDDIFEBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public readonly Quaternion NBFJKGINHEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public readonly float EJOLINDBPPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public readonly bool MIOHMOMEHEL;

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x763DD40", Offset = "0x763D140", VA = "0x18763DD40")]
	public GGLGODNJFJF(Guid DPBHPPMCCJG, int FFCBHHABFJN, Vector3 HJBDDDIFEBJ, Quaternion NBFJKGINHEC, float EJOLINDBPPE, bool MIOHMOMEHEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public struct MFFNNKJMCGO<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public readonly TData GACPILKGIFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public readonly bool OCIOLGOICIO;

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x4DFD3B0", Offset = "0x4DFC7B0", VA = "0x184DFD3B0")]
	public MFFNNKJMCGO(TData GACPILKGIFM, bool OCIOLGOICIO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public interface FECLHNNEFBE<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HPGKBBIDPFC([In] BKIJHBGFEIM<TData> IHCHKFNJGFA);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HPGKBBIDPFC([In] PJHFBGKJLKL<TData> IHCHKFNJGFA);
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public interface IMPDFFFONON<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool COAILNABPLL([In] DAJODOJCIKA<TData> DJJGKJELLCL);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MPMEFAGHJLK([In] ALJKJNKIBEF IBEMJPKNFAD);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MFIOFDGKELO();
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class GLPMHILKKFI<TData> : LFIKCPMBJKA<FECLHNNEFBE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private readonly BKIJHBGFEIM<TData> IHCHKFNJGFA;

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x4679290", Offset = "0x4678690", VA = "0x184679290")]
	public GLPMHILKKFI(IEnumerable<TData> KMCCOKIFAKF, Vector3 AJHPBOGADGL, bool OCIOLGOICIO, FECLHNNEFBE<TData> DGAEDICPJIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x4125650", Offset = "0x4124A50", VA = "0x184125650", Slot = "4")]
	public override bool HPGKBBIDPFC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public class PCBIBFFLAJO<TData> : LFIKCPMBJKA<IMPDFFFONON<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x44DA1D0", Offset = "0x44D95D0", VA = "0x1844DA1D0")]
	public PCBIBFFLAJO(IMPDFFFONON<TData> DGAEDICPJIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x4810F40", Offset = "0x4810340", VA = "0x184810F40", Slot = "4")]
	public override bool HPGKBBIDPFC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class OPDCNMJMOBD<TData> : LFIKCPMBJKA<IMPDFFFONON<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private readonly DAJODOJCIKA<TData> IHCHKFNJGFA;

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x4FDE790", Offset = "0x4FDDB90", VA = "0x184FDE790")]
	public OPDCNMJMOBD(IEnumerable<TData> KMCCOKIFAKF, bool OCIOLGOICIO, IMPDFFFONON<TData> DGAEDICPJIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x4125650", Offset = "0x4124A50", VA = "0x184125650", Slot = "4")]
	public override bool HPGKBBIDPFC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class AAEPBEPLKEM<TData> : LFIKCPMBJKA<FECLHNNEFBE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly PJHFBGKJLKL<TData> IHCHKFNJGFA;

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x46269F0", Offset = "0x4625DF0", VA = "0x1846269F0")]
	public AAEPBEPLKEM(IEnumerable<TData> KMCCOKIFAKF, Vector3 CLBCECLFDEE, JKJAMGJICDL JPHNEBMIABF, bool OCIOLGOICIO, FECLHNNEFBE<TData> DGAEDICPJIG, Space CPFKJMBMNJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x4626930", Offset = "0x4625D30", VA = "0x184626930", Slot = "4")]
	public override bool HPGKBBIDPFC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class OHCDOALABPO<TData> : LFIKCPMBJKA<IMPDFFFONON<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly ALJKJNKIBEF IHCHKFNJGFA;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x4FA3250", Offset = "0x4FA2650", VA = "0x184FA3250")]
	public OHCDOALABPO(Vector3 AJHPBOGADGL, IMPDFFFONON<TData> DGAEDICPJIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x4652430", Offset = "0x4651830", VA = "0x184652430", Slot = "4")]
	public override bool HPGKBBIDPFC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public struct BKIJHBGFEIM<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public readonly IEnumerable<TData> KMCCOKIFAKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public readonly Vector3 AJHPBOGADGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public readonly bool OCIOLGOICIO;

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x5CAD790", Offset = "0x5CACB90", VA = "0x185CAD790")]
	public BKIJHBGFEIM(IEnumerable<TData> KMCCOKIFAKF, Vector3 AJHPBOGADGL, bool OCIOLGOICIO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public struct DAJODOJCIKA<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public readonly IEnumerable<TData> KMCCOKIFAKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public readonly bool OCIOLGOICIO;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x63E0B70", Offset = "0x63DFF70", VA = "0x1863E0B70")]
	public DAJODOJCIKA(IEnumerable<TData> KMCCOKIFAKF, bool OCIOLGOICIO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public struct PJHFBGKJLKL<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public readonly IEnumerable<TData> KMCCOKIFAKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public readonly Vector3 CLBCECLFDEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public readonly JKJAMGJICDL JPHNEBMIABF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public readonly bool OCIOLGOICIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public readonly Space CPFKJMBMNJF;

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x50A6230", Offset = "0x50A5630", VA = "0x1850A6230")]
	public PJHFBGKJLKL(IEnumerable<TData> KMCCOKIFAKF, Vector3 CLBCECLFDEE, JKJAMGJICDL JPHNEBMIABF, bool OCIOLGOICIO, Space CPFKJMBMNJF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public struct ALJKJNKIBEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public readonly Vector3 AJHPBOGADGL;

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x27C31D0", Offset = "0x27C25D0", VA = "0x1827C31D0")]
	public ALJKJNKIBEF(Vector3 AJHPBOGADGL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public enum JKJAMGJICDL
{
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	XYZ,
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	X_only,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	Y_only,
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	Z_only
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public interface MOEFGKBHKCA
{
	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HPGKBBIDPFC([In] KKFHFIBBPFL OPPGPCCDFLI);
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class OLIBBPPNDHG : LFIKCPMBJKA<MOEFGKBHKCA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly KKFHFIBBPFL OPPGPCCDFLI;

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x763EFA0", Offset = "0x763E3A0", VA = "0x18763EFA0")]
	public OLIBBPPNDHG(bool OCIOLGOICIO, MOEFGKBHKCA DGAEDICPJIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x763EEF0", Offset = "0x763E2F0", VA = "0x18763EEF0", Slot = "4")]
	public override bool HPGKBBIDPFC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public readonly struct KKFHFIBBPFL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly bool OCIOLGOICIO;

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x27C2F60", Offset = "0x27C2360", VA = "0x1827C2F60")]
	public KKFHFIBBPFL(bool OCIOLGOICIO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public interface PEAEJBDDOGJ<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HPGKBBIDPFC([In] ADDCKPCDLKC<TData> FDJJIJHLECN);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HPGKBBIDPFC([In] EIFEFNBIPOB<TData> FDJJIJHLECN);
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public interface HFEBFJLBDBH<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool COAILNABPLL([In] GJFHONENMOI<TData> CLEDNOCPPPF);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MPMEFAGHJLK([In] CCJJNGLDIGF IBEMJPKNFAD);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MFIOFDGKELO();
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class EKDJKOOPDHE<TData> : LFIKCPMBJKA<PEAEJBDDOGJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly ADDCKPCDLKC<TData> FDJJIJHLECN;

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x4125700", Offset = "0x4124B00", VA = "0x184125700")]
	public EKDJKOOPDHE(IEnumerable<TData> KMCCOKIFAKF, Quaternion AJHPBOGADGL, Vector3? ECBGHMHHGPH, bool FALAKMFKKAM, bool OCIOLGOICIO, PEAEJBDDOGJ<TData> DGAEDICPJIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x4125650", Offset = "0x4124A50", VA = "0x184125650", Slot = "4")]
	public override bool HPGKBBIDPFC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public class KHBGPFICIOK<TData> : LFIKCPMBJKA<HFEBFJLBDBH<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x44DA1D0", Offset = "0x44D95D0", VA = "0x1844DA1D0")]
	public KHBGPFICIOK(HFEBFJLBDBH<TData> DGAEDICPJIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x4810F40", Offset = "0x4810340", VA = "0x184810F40", Slot = "4")]
	public override bool HPGKBBIDPFC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public class HNMHOMKFOFD<TData> : LFIKCPMBJKA<HFEBFJLBDBH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly GJFHONENMOI<TData> FDJJIJHLECN;

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x4758460", Offset = "0x4757860", VA = "0x184758460")]
	public HNMHOMKFOFD(IEnumerable<TData> KMCCOKIFAKF, bool OCIOLGOICIO, HFEBFJLBDBH<TData> DGAEDICPJIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x4125650", Offset = "0x4124A50", VA = "0x184125650", Slot = "4")]
	public override bool HPGKBBIDPFC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public class JMNKHPKHBHH<TData> : LFIKCPMBJKA<PEAEJBDDOGJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly EIFEFNBIPOB<TData> FDJJIJHLECN;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x4A34990", Offset = "0x4A33D90", VA = "0x184A34990")]
	public JMNKHPKHBHH(IEnumerable<TData> KMCCOKIFAKF, Quaternion LMBGEFNEGCC, JKJAMGJICDL LENDIEMPIMO, Vector3? ECBGHMHHGPH, bool FALAKMFKKAM, bool OCIOLGOICIO, Space CPFKJMBMNJF, PEAEJBDDOGJ<TData> DGAEDICPJIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x4626930", Offset = "0x4625D30", VA = "0x184626930", Slot = "4")]
	public override bool HPGKBBIDPFC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public class GCHBPBDLDPJ<TData> : LFIKCPMBJKA<HFEBFJLBDBH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly CCJJNGLDIGF FDJJIJHLECN;

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x4652490", Offset = "0x4651890", VA = "0x184652490")]
	public GCHBPBDLDPJ(Quaternion AJHPBOGADGL, Vector3? ECBGHMHHGPH, bool FALAKMFKKAM, HFEBFJLBDBH<TData> DGAEDICPJIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x4652430", Offset = "0x4651830", VA = "0x184652430", Slot = "4")]
	public override bool HPGKBBIDPFC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public struct ADDCKPCDLKC<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public readonly IEnumerable<TData> KMCCOKIFAKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public readonly Quaternion AJHPBOGADGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public readonly Vector3? ECBGHMHHGPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public readonly bool FALAKMFKKAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public readonly bool OCIOLGOICIO;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x462B4B0", Offset = "0x462A8B0", VA = "0x18462B4B0")]
	public ADDCKPCDLKC(IEnumerable<TData> KMCCOKIFAKF, Quaternion AJHPBOGADGL, Vector3? ECBGHMHHGPH, bool FALAKMFKKAM, bool OCIOLGOICIO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public struct GJFHONENMOI<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public readonly IEnumerable<TData> KMCCOKIFAKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public readonly bool OCIOLGOICIO;

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x466FD60", Offset = "0x466F160", VA = "0x18466FD60")]
	public GJFHONENMOI(IEnumerable<TData> KMCCOKIFAKF, bool OCIOLGOICIO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public struct EIFEFNBIPOB<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public readonly IEnumerable<TData> KMCCOKIFAKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public readonly Quaternion LMBGEFNEGCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public readonly JKJAMGJICDL LENDIEMPIMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public readonly Vector3? ECBGHMHHGPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public readonly bool FALAKMFKKAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public readonly bool OCIOLGOICIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public readonly Space CPFKJMBMNJF;

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x411FBD0", Offset = "0x411EFD0", VA = "0x18411FBD0")]
	public EIFEFNBIPOB(IEnumerable<TData> KMCCOKIFAKF, Quaternion LMBGEFNEGCC, JKJAMGJICDL LENDIEMPIMO, Vector3? ECBGHMHHGPH, bool FALAKMFKKAM, bool OCIOLGOICIO, Space CPFKJMBMNJF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public struct CCJJNGLDIGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public readonly Quaternion AJHPBOGADGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public readonly Vector3? ECBGHMHHGPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public readonly bool FALAKMFKKAM;

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x5657C50", Offset = "0x5657050", VA = "0x185657C50")]
	public CCJJNGLDIGF(Quaternion AJHPBOGADGL, Vector3? ECBGHMHHGPH, bool FALAKMFKKAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public interface IPDPBAJGBGO<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool COAILNABPLL([In] IPNILHCMKMF<TData> CLEDNOCPPPF);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MPMEFAGHJLK([In] LPMPELDHEAA IBEMJPKNFAD);

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MPMEFAGHJLK([In] DOOLNDJHHHE IBEMJPKNFAD);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MPMEFAGHJLK([In] EPPIAJHFCEM IBEMJPKNFAD);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool MFIOFDGKELO();
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class FJDNCLAPONC<TData> : LFIKCPMBJKA<IPDPBAJGBGO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private readonly EPPIAJHFCEM ALNLOJNKLJG;

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x4500FE0", Offset = "0x45003E0", VA = "0x184500FE0")]
	public FJDNCLAPONC(Vector3 AHDBGHGKMEM, float KELBOIHJCBN, Vector3 ECBGHMHHGPH, bool MAJOLLKHJDJ, bool DNBAOGFOOMK, IPDPBAJGBGO<TData> DGAEDICPJIG, Space CPFKJMBMNJF = Space.Self)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x4500F80", Offset = "0x4500380", VA = "0x184500F80", Slot = "4")]
	public override bool HPGKBBIDPFC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public class IIKJMPPMPFO<TData> : LFIKCPMBJKA<IPDPBAJGBGO<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x44DA1D0", Offset = "0x44D95D0", VA = "0x1844DA1D0")]
	public IIKJMPPMPFO(IPDPBAJGBGO<TData> DGAEDICPJIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x4813DC0", Offset = "0x48131C0", VA = "0x184813DC0", Slot = "4")]
	public override bool HPGKBBIDPFC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public class AELNLFMCGGO<TData> : LFIKCPMBJKA<IPDPBAJGBGO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private readonly IPNILHCMKMF<TData> ALNLOJNKLJG;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x462C720", Offset = "0x462BB20", VA = "0x18462C720")]
	public AELNLFMCGGO(IEnumerable<TData> KMCCOKIFAKF, bool OCIOLGOICIO, IPDPBAJGBGO<TData> DGAEDICPJIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x4125650", Offset = "0x4124A50", VA = "0x184125650", Slot = "4")]
	public override bool HPGKBBIDPFC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public class OHLPCBBLNLO<TData> : LFIKCPMBJKA<IPDPBAJGBGO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private readonly DOOLNDJHHHE ALNLOJNKLJG;

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x4FA59B0", Offset = "0x4FA4DB0", VA = "0x184FA59B0")]
	public OHLPCBBLNLO(float AJBPFGFHJOP, bool CAEHKCPNAGB, Vector3 ECBGHMHHGPH, IPDPBAJGBGO<TData> DGAEDICPJIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x4FA58F0", Offset = "0x4FA4CF0", VA = "0x184FA58F0", Slot = "4")]
	public override bool HPGKBBIDPFC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public class LNKAAICCANH<TData> : LFIKCPMBJKA<IPDPBAJGBGO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private readonly LPMPELDHEAA ALNLOJNKLJG;

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x4C1BE60", Offset = "0x4C1B260", VA = "0x184C1BE60")]
	public LNKAAICCANH(float KELBOIHJCBN, Vector3 ECBGHMHHGPH, IPDPBAJGBGO<TData> DGAEDICPJIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x4652430", Offset = "0x4651830", VA = "0x184652430", Slot = "4")]
	public override bool HPGKBBIDPFC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct EPPIAJHFCEM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public readonly Vector3 AHDBGHGKMEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public readonly float KELBOIHJCBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public readonly Vector3 ECBGHMHHGPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public readonly bool MIOHMOMEHEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public readonly Space CPFKJMBMNJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public readonly bool DNBAOGFOOMK;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x763D900", Offset = "0x763CD00", VA = "0x18763D900")]
	public EPPIAJHFCEM(Vector3 AHDBGHGKMEM, float KELBOIHJCBN, Vector3 ECBGHMHHGPH, bool MIOHMOMEHEL, bool CBKDECDGGCN, Space CPFKJMBMNJF = Space.Self)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public struct IPNILHCMKMF<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public readonly IEnumerable<TData> KMCCOKIFAKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public readonly bool OCIOLGOICIO;

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x48448F0", Offset = "0x4843CF0", VA = "0x1848448F0")]
	public IPNILHCMKMF(IEnumerable<TData> KMCCOKIFAKF, bool OCIOLGOICIO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public struct DOOLNDJHHHE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly float AJBPFGFHJOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public readonly bool CAEHKCPNAGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly Vector3 ECBGHMHHGPH;

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x763D8E0", Offset = "0x763CCE0", VA = "0x18763D8E0")]
	public DOOLNDJHHHE(float AJBPFGFHJOP, bool CAEHKCPNAGB, Vector3 ECBGHMHHGPH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public struct LPMPELDHEAA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public readonly float KELBOIHJCBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public readonly Vector3 ECBGHMHHGPH;

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x561A8B0", Offset = "0x5619CB0", VA = "0x18561A8B0")]
	public LPMPELDHEAA(float KELBOIHJCBN, Vector3 ECBGHMHHGPH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public struct LLAOJPCPBKF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public readonly Guid[] KMCCOKIFAKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public readonly bool PDGNLBAAPMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public readonly bool EINAJOHMKGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public readonly bool LCOILFAGAEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public readonly Vector3[] AENMKEFKKPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public readonly Quaternion[] PGJBCMBHBLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public readonly float[] HNNAJJLJDKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public readonly Dictionary<Guid, Vector3> BHNIGBAKDFF;

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x763E680", Offset = "0x763DA80", VA = "0x18763E680")]
	public LLAOJPCPBKF(Guid[] CPFPMNOPPIP, Vector3[] AENMKEFKKPG, Quaternion[] PGJBCMBHBLA, float[] HNNAJJLJDKD, Dictionary<Guid, Vector3> BHNIGBAKDFF, bool PDGNLBAAPMF = true, bool EINAJOHMKGG = true, bool LCOILFAGAEN = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x763E4B0", Offset = "0x763D8B0", VA = "0x18763E4B0")]
	private static void GLLPCFAGDGA(Dictionary<Guid, Vector3> BHNIGBAKDFF, int CNAIPKHGBDF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public static class AKBECBHEAKI
{
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	private struct DHDKPHKBPOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public bool MIPCGELADED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public LEPFMCICNAK CNNOMCHMBBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public LEPFMCICNAK OOCPDOAMEOB;
	}

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static DHDKPHKBPOK ACHGEGMIMLA;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static CancellationToken FIOEPLBHCNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x763D230", Offset = "0x763C630", VA = "0x18763D230")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	internal static LEPFMCICNAK CNNOMCHMBBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x763D340", Offset = "0x763C740", VA = "0x18763D340")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x763D530", Offset = "0x763C930", VA = "0x18763D530")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x763D250", Offset = "0x763C650", VA = "0x18763D250")]
	[AEDFFNEEAKJ.LPKEDHFAMMA]
	internal static void HCFGACKFDEN(LEPFMCICNAK GADCCAIHFJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x763D3E0", Offset = "0x763C7E0", VA = "0x18763D3E0")]
	public static void HKGADJFONBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x763D590", Offset = "0x763C990", VA = "0x18763D590")]
	private static LEPFMCICNAK OHKGOLMFGCO(LEPFMCICNAK IAJOALFPCDG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public static class NOBEOFJECJJ
{
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public enum BEABCACDNMJ
	{
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		ICreationContextObject,
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		Guid
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x362AFD0", Offset = "0x362A3D0", VA = "0x18362AFD0")]
	public static void CHGFNKMOACM<T>(T HCADPGAHONO, BEABCACDNMJ ANONBNLNHHL) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x362AF60", Offset = "0x362A360", VA = "0x18362AF60")]
	public static void CHGFNKMOACM<T>(T HCADPGAHONO) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x362B250", Offset = "0x362A650", VA = "0x18362B250")]
	public static void JDOBILOICBB<T>(T HCADPGAHONO) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x362B140", Offset = "0x362A540", VA = "0x18362B140")]
	public static T FCPELJIOJPN<T>(BEABCACDNMJ ANONBNLNHHL) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x362B3C0", Offset = "0x362A7C0", VA = "0x18362B3C0")]
	public static bool MGNAAKJADEG<T>(BEABCACDNMJ ANONBNLNHHL, T? OCMEDBPNPGO, [Out][MaybeNullWhen(false)][NotNullWhen(true)] T KBLONLKHCGD) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x362AE50", Offset = "0x362A250", VA = "0x18362AE50")]
	public static bool AJJJHFEBDMC<T>(BEABCACDNMJ ANONBNLNHHL, [Out][MaybeNullWhen(false)][NotNullWhen(true)] T MMFLLEGJGFJ) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x362B510", Offset = "0x362A910", VA = "0x18362B510")]
	public static bool PMFMEAIFBEE<T>(BEABCACDNMJ ANONBNLNHHL) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x362B1F0", Offset = "0x362A5F0", VA = "0x18362B1F0")]
	public static T FCPELJIOJPN<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x362B300", Offset = "0x362A700", VA = "0x18362B300")]
	public static bool MGNAAKJADEG<T>(T OCMEDBPNPGO, [Out] T KBLONLKHCGD) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x362B1F0", Offset = "0x362A5F0", VA = "0x18362B1F0")]
	public static bool PMFMEAIFBEE<T>() where T : class
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
internal static class POHLEDHNEOP
{
	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x763F000", Offset = "0x763E400", VA = "0x18763F000")]
	public static void KMHBKMIMNJF(IEnumerable CEBOCBIKDHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x36721A0", Offset = "0x36715A0", VA = "0x1836721A0")]
	public static void KMHBKMIMNJF<T>(T[] PHAPILEGACC) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x3672290", Offset = "0x3671690", VA = "0x183672290")]
	public static void KMHBKMIMNJF<T>(T BJDHLMBEIKG) where T : notnull, Enum
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
