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
		[Cpp2IlInjected.Address(RVA = "0xABFAB0", Offset = "0xABE0B0", VA = "0x180ABFAB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x84BFE10", Offset = "0x84BE410", VA = "0x1884BFE10")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAC0AA0", Offset = "0xABF0A0", VA = "0x180AC0AA0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAC0AE0", Offset = "0xABF0E0", VA = "0x180AC0AE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x84C02D0", Offset = "0x84BE8D0", VA = "0x1884C02D0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2960290", Offset = "0x295E890", VA = "0x182960290")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum FLGJPIENFPA
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	ShowFreeInventionsInR2PaletteSearch
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum IONOGLPFMCL
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	NameAZ,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	NameZA,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	InkCostAsc,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	InkCostDesc,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	Oldest,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	Newest
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface FHLINECMPJK<TData, TReturn>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TReturn OHEMKMOCBNF(TData NDBJJGOPOFO);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface MAAAFOFILGE<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ClearHoverTarget(IKNBAAEIGJB MJMDLEOCBLF);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool SetHoverTarget(TData LKEAKCADNOO, Collider FOIBGJFMCOF, IKNBAAEIGJB MJMDLEOCBLF, [Optional] HPNEHHPMAMF? CPLHFBKKDDB);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool TryGetHoverTarget([Out] TData LKEAKCADNOO);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetHoverCollider([Out] Collider FOIBGJFMCOF);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface JCANLJKFPJJ<TData> : DKKLAHGLDMH, KCEEPDLLHHL<TData>, OFOOBKAOFNP<TData>, DCHJMGEJBLA<TData>, DMKAKGAELNJ, NNJDPNGGPIK<TData>, PMLGCJBKAFF, LKAEOKNEDHF
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface NNJDPNGGPIK<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 COELDBNFGAO, Vector3 FANJPCNJGDA, float LHLABDNDDPG, [Out] T DDKLKMPNGIK, [Out] Vector3 OEFNLBNLBCA, [Out] Collider FOIBGJFMCOF);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 COELDBNFGAO, Vector3 FANJPCNJGDA, float MFOKLFDNHJB, float LHLABDNDDPG, T[] CENHKIDIFFK, [Out] Vector3 DEOBPCOALPK, [Out] Collider BMGJPGDNKMA);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 COELDBNFGAO, float MFOKLFDNHJB, Vector3 CBIOKHGKPPH, T[] CENHKIDIFFK);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetObjectFromColliderInCurrentScope(Collider ABMPKGCACDO, [Out] T DGDOHHCAKKC);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface DKKLAHGLDMH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Bounds FMBLOJDNFHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Transform KONKPNDOOKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Bounds MOLCGIMCKIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Transform BMJFABCIJGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Vector3 OJCPFMIFLBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool FDIBLIDKMHF
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
	void SetSelectionBoundsDirty(bool AMKLFPMHGKJ = true, int MBMOODBEJBN = 0);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ShouldHideSelectionBoundsPreview(bool ECDBJCDCKLO, object HNGIMMGBLII);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface LKAEOKNEDHF
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	HBPNKKOKOOA FJIGMGAAECE
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface GALMHDPFACK
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool FKNDHPMPBIA
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool ENFAOLCGMKF
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool NBEPLGHJGAK
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
	void TrySetPreviousCloneMapping(Dictionary<Guid, Guid> IBEBDLOJOHC);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface DCHJMGEJBLA<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool IPPBFHJCBON
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int CBGCAMKIDBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<TData> IKNNDBANLKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData KGKOGFAMIIC);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData KGKOGFAMIIC);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface KCEEPDLLHHL<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T NDBJJGOPOFO, [Optional] HPNEHHPMAMF? OOEPNBCGDBB, bool CNPHBHHECHH = true);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int FEEKNNBMJMM, IEnumerable<T> KJALALPGBHM, bool CNPHBHHECHH = true);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int FEEKNNBMJMM, IEnumerable<T> KJALALPGBHM, HPNEHHPMAMF OOEPNBCGDBB, bool CNPHBHHECHH = true);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface PMLGCJBKAFF
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface DMKAKGAELNJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool BLAEKHJONPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool GCOCKFGPNAK
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool HBDEMLHPEFP
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool FOOBIBNAALK
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct OAOJMFKHCKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public bool JKJNBKJOKKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public float? BAAJDECCMGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public float? HMBLPJEJKPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public float? IKBMLMHJCNH;
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct EOBMJAFANMJ<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public IEnumerable<TData> DKNBJGMNHBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public OAOJMFKHCKE KMMLIDEJMAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public bool OKLDHMEDEMM;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4A9FF60", Offset = "0x4A9E560", VA = "0x184A9FF60")]
	public EOBMJAFANMJ(IEnumerable<TData> FIEOCAHNJDC, bool HBBHAMJLMIE, float? OGGOAEMANEC, float? KNPJHKKMLOF, float? FIDDJPOFDIP, bool OKLDHMEDEMM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface PKPNKGFENGP<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MGDMFNNFPNM([In] EOBMJAFANMJ<TData> KGIPMLMDBBA);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class JENEHMNGFHA<TData> : JAOBCLCDPHC<PKPNKGFENGP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly EOBMJAFANMJ<TData> KGIPMLMDBBA;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x54AF550", Offset = "0x54ADB50", VA = "0x1854AF550")]
	public JENEHMNGFHA(IEnumerable<TData> FIEOCAHNJDC, bool HBBHAMJLMIE, float? OGGOAEMANEC, float? KNPJHKKMLOF, float? FIDDJPOFDIP, bool OKLDHMEDEMM, PKPNKGFENGP<TData> DCFBCOLBNJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4A433B0", Offset = "0x4A419B0", VA = "0x184A433B0", Slot = "4")]
	public override bool MGDMFNNFPNM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct ILIEMDHMOOO<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public IEnumerable<TData> DKNBJGMNHBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public string GKPCMLDMKLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public bool OCGOADEKJLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public bool OKLDHMEDEMM;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x525C860", Offset = "0x525AE60", VA = "0x18525C860")]
	public ILIEMDHMOOO(IEnumerable<TData> FIEOCAHNJDC, string IFCAGKLINAN, bool OAJOMILONJJ, bool OKLDHMEDEMM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface KMMDAJLAKBL<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MGDMFNNFPNM([In] ILIEMDHMOOO<TData> KGIPMLMDBBA);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class HFHAEOGNJEA<TData> : JAOBCLCDPHC<KMMDAJLAKBL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly ILIEMDHMOOO<TData> KGIPMLMDBBA;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x50B2090", Offset = "0x50B0690", VA = "0x1850B2090")]
	public HFHAEOGNJEA(IEnumerable<TData> FIEOCAHNJDC, string IFCAGKLINAN, bool OAJOMILONJJ, bool OKLDHMEDEMM, KMMDAJLAKBL<TData> DCFBCOLBNJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x4A433B0", Offset = "0x4A419B0", VA = "0x184A433B0", Slot = "4")]
	public override bool MGDMFNNFPNM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public abstract class JAOBCLCDPHC<TReceiver> : GKFDMHNOANA<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4A43560", Offset = "0x4A41B60", VA = "0x184A43560")]
	public JAOBCLCDPHC(TReceiver DCFBCOLBNJL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class HJMEPMDPBEP<TReceiver, TFromTask> : GKFDMHNOANA<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4A43560", Offset = "0x4A41B60", VA = "0x184A43560")]
	public HJMEPMDPBEP(TReceiver DCFBCOLBNJL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class GKFDMHNOANA<TReceiver, TFromExecute> where TReceiver : notnull where TFromExecute : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	protected TReceiver DCFBCOLBNJL;

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4FF4C10", Offset = "0x4FF3210", VA = "0x184FF4C10")]
	public GKFDMHNOANA(TReceiver DCFBCOLBNJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute MGDMFNNFPNM();
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public abstract class BNMJOEMOEGE<TReceiver, TResult> : GKFDMHNOANA<TReceiver, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4A43560", Offset = "0x4A41B60", VA = "0x184A43560")]
	public BNMJOEMOEGE(TReceiver DCFBCOLBNJL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct DIKCOBOJMAH<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public TGroup ECKHHAGPICG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public TData HMONFIDNJIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public IEnumerable<TData> DKNBJGMNHBB;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1E14FD0", Offset = "0x1E135D0", VA = "0x181E14FD0")]
	public DIKCOBOJMAH(TGroup DAAPLLDDBKK, TData EPIPPKLCKKO, IEnumerable<TData> FIEOCAHNJDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct LGGNLHEKMME<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public TGroup ECKHHAGPICG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public IEnumerable<TData> DKNBJGMNHBB;

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0xC41130", Offset = "0xC3F730", VA = "0x180C41130")]
	public LGGNLHEKMME(TGroup DAAPLLDDBKK, IEnumerable<TData> FIEOCAHNJDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct JPEMDLMEPNO<TGroup> where TGroup : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public TGroup ECKHHAGPICG;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0xEB2930", Offset = "0xEB0F30", VA = "0x180EB2930")]
	public JPEMDLMEPNO(TGroup DAAPLLDDBKK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public struct HFEKFJINNDA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public IEnumerable<Guid> DKNBJGMNHBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public Guid BIKFKKIIKLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly bool JPOFGMGDJJE;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x84BEEA0", Offset = "0x84BD4A0", VA = "0x1884BEEA0")]
	public HFEKFJINNDA(IEnumerable<Guid> FIEOCAHNJDC, Guid GCDLAMGOHPD, bool OKLDHMEDEMM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct BFEJPPFDEDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public Guid BIKFKKIIKLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly bool JPOFGMGDJJE;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2940620", Offset = "0x293EC20", VA = "0x182940620")]
	public BFEJPPFDEDL(Guid GCDLAMGOHPD, bool OKLDHMEDEMM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface MDAHAICCKDC<TGroup, TData>
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CMOAIHKBLFN CLLPKICBHII(DIKCOBOJMAH<TGroup, TData> BPCHAKNOJCE);

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CMOAIHKBLFN IGPKFPALLNJ(DIKCOBOJMAH<TGroup, TData> BPCHAKNOJCE);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CMOAIHKBLFN OKDBPDDCCFM(LGGNLHEKMME<TGroup, TData> BPCHAKNOJCE);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CMOAIHKBLFN CPADMLLBACK(JPEMDLMEPNO<TGroup> BPCHAKNOJCE);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface ELMCLMJCPKM
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CMOAIHKBLFN> CLLPKICBHII(HFEKFJINNDA BPCHAKNOJCE);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<CMOAIHKBLFN> IGPKFPALLNJ(BFEJPPFDEDL BPCHAKNOJCE);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class GPBONJJHDHO<TGroup, TData> : BNMJOEMOEGE<MDAHAICCKDC<TGroup, TData>, CMOAIHKBLFN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly LGGNLHEKMME<TGroup, TData> BPCHAKNOJCE;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5072670", Offset = "0x5070C70", VA = "0x185072670")]
	public GPBONJJHDHO(TGroup DAAPLLDDBKK, IEnumerable<TData> FIEOCAHNJDC, MDAHAICCKDC<TGroup, TData> DCFBCOLBNJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x50725A0", Offset = "0x5070BA0", VA = "0x1850725A0", Slot = "4")]
	public override CMOAIHKBLFN MGDMFNNFPNM()
	{
		return default(CMOAIHKBLFN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class MEEBONBLKNJ<TGroup, TData> : BNMJOEMOEGE<MDAHAICCKDC<TGroup, TData>, CMOAIHKBLFN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly DIKCOBOJMAH<TGroup, TData> BPCHAKNOJCE;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5951AB0", Offset = "0x59500B0", VA = "0x185951AB0")]
	public MEEBONBLKNJ(TGroup DAAPLLDDBKK, TData LMFAKONPFNL, IEnumerable<TData> FIEOCAHNJDC, MDAHAICCKDC<TGroup, TData> DCFBCOLBNJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x59519E0", Offset = "0x594FFE0", VA = "0x1859519E0", Slot = "4")]
	public override CMOAIHKBLFN MGDMFNNFPNM()
	{
		return default(CMOAIHKBLFN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class BLGKHDGGNBL<TGroup, TData> : BNMJOEMOEGE<MDAHAICCKDC<TGroup, TData>, CMOAIHKBLFN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly JPEMDLMEPNO<TGroup> BPCHAKNOJCE;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x4A434F0", Offset = "0x4A41AF0", VA = "0x184A434F0")]
	public BLGKHDGGNBL(TGroup DAAPLLDDBKK, MDAHAICCKDC<TGroup, TData> DCFBCOLBNJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6A1A320", Offset = "0x6A18920", VA = "0x186A1A320", Slot = "4")]
	public override CMOAIHKBLFN MGDMFNNFPNM()
	{
		return default(CMOAIHKBLFN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class CCDBEKMKFFH<TGroup, TData> : BNMJOEMOEGE<MDAHAICCKDC<TGroup, TData>, CMOAIHKBLFN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly DIKCOBOJMAH<TGroup, TData> BPCHAKNOJCE;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5951AB0", Offset = "0x59500B0", VA = "0x185951AB0")]
	public CCDBEKMKFFH(TGroup DAAPLLDDBKK, TData EPIPPKLCKKO, IEnumerable<TData> FIEOCAHNJDC, MDAHAICCKDC<TGroup, TData> DCFBCOLBNJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6DC9670", Offset = "0x6DC7C70", VA = "0x186DC9670", Slot = "4")]
	public override CMOAIHKBLFN MGDMFNNFPNM()
	{
		return default(CMOAIHKBLFN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class FIKHADJHHHL : HJMEPMDPBEP<ELMCLMJCPKM, CMOAIHKBLFN>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private struct PGJLIOBPJNP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public AsyncTaskMethodBuilder<CMOAIHKBLFN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public FIKHADJHHHL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private TaskAwaiter<CMOAIHKBLFN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x84BFEF0", Offset = "0x84BE4F0", VA = "0x1884BFEF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x84C0190", Offset = "0x84BE790", VA = "0x1884C0190", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private HFEKFJINNDA BPCHAKNOJCE;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x84BE8F0", Offset = "0x84BCEF0", VA = "0x1884BE8F0")]
	public FIKHADJHHHL(IEnumerable<Guid> IGBAAJGHCEK, Guid GCDLAMGOHPD, bool OKLDHMEDEMM, ELMCLMJCPKM DCFBCOLBNJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x84BE800", Offset = "0x84BCE00", VA = "0x1884BE800", Slot = "4")]
	[AsyncStateMachine(typeof(PGJLIOBPJNP))]
	public override Task<CMOAIHKBLFN> MGDMFNNFPNM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class IPLDFOMOGKM : HJMEPMDPBEP<ELMCLMJCPKM, CMOAIHKBLFN>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private struct NLNCPLOPAOA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public AsyncTaskMethodBuilder<CMOAIHKBLFN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public IPLDFOMOGKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private TaskAwaiter<CMOAIHKBLFN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x84BFB00", Offset = "0x84BE100", VA = "0x1884BFB00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x84BFDA0", Offset = "0x84BE3A0", VA = "0x1884BFDA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly BFEJPPFDEDL BPCHAKNOJCE;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x84BF140", Offset = "0x84BD740", VA = "0x1884BF140")]
	public IPLDFOMOGKM(Guid GCDLAMGOHPD, bool OKLDHMEDEMM, ELMCLMJCPKM DCFBCOLBNJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x84BF050", Offset = "0x84BD650", VA = "0x1884BF050", Slot = "4")]
	[AsyncStateMachine(typeof(NLNCPLOPAOA))]
	public override Task<CMOAIHKBLFN> MGDMFNNFPNM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public readonly struct PFOHJFPEKEE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly KBGMLPIELEB AECPELNHCIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly bool JPOFGMGDJJE;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x84BFED0", Offset = "0x84BE4D0", VA = "0x1884BFED0")]
	public PFOHJFPEKEE(KBGMLPIELEB KKDDPPJPEHA, bool OKLDHMEDEMM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface HCKACBLCMDN<TSpawnType> where TSpawnType : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> MGDMFNNFPNM(PFOHJFPEKEE GMCMIGNGJLP);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class OMGEKPOJMOH<TSpawnType> : HJMEPMDPBEP<HCKACBLCMDN<TSpawnType>, TSpawnType> where TSpawnType : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct CJAJBOJFBAO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public AsyncTaskMethodBuilder<TSpawnType> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public OMGEKPOJMOH<TSpawnType> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<TSpawnType> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6DE4390", Offset = "0x6DE2990", VA = "0x186DE4390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x4F49600", Offset = "0x4F47C00", VA = "0x184F49600", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly PFOHJFPEKEE GMCMIGNGJLP;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5B93490", Offset = "0x5B91A90", VA = "0x185B93490")]
	public OMGEKPOJMOH(KBGMLPIELEB KKDDPPJPEHA, bool OKLDHMEDEMM, HCKACBLCMDN<TSpawnType> DCFBCOLBNJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5B93290", Offset = "0x5B91890", VA = "0x185B93290", Slot = "4")]
	[AsyncStateMachine(typeof(OMGEKPOJMOH<>.CJAJBOJFBAO))]
	public override Task<TSpawnType> MGDMFNNFPNM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public readonly struct KBGMLPIELEB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly bool EMILKLNKKIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly Vector3 DHACPNNANII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly Vector3 IIKJNDDFMGG;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x84BF340", Offset = "0x84BD940", VA = "0x1884BF340")]
	public KBGMLPIELEB(Transform OPIMEJIFKFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x84BF310", Offset = "0x84BD910", VA = "0x1884BF310")]
	public KBGMLPIELEB(Vector3 NNMAALGIDJM, Vector3 AANGPKCDGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x84BF2E0", Offset = "0x84BD8E0", VA = "0x1884BF2E0")]
	public static KBGMLPIELEB JJDCBGIHCCL()
	{
		return default(KBGMLPIELEB);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x84BF3B0", Offset = "0x84BD9B0", VA = "0x1884BF3B0")]
	private KBGMLPIELEB(bool LFIOPBFMFBH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct GMHJLBANBDF<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public TNode PGLOHLNOEAI;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x500E470", Offset = "0x500CA70", VA = "0x18500E470")]
	public GMHJLBANBDF(TNode PGLOHLNOEAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct ENKKNNIBDGN<TNode, TReparentOperations> where TNode : notnull where TReparentOperations : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public TNode FHEIEGBMFAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public TReparentOperations FFKINJPHBPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public IHBGAKMALLJ NIFOLDHMJJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly bool JPOFGMGDJJE;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x4A9C610", Offset = "0x4A9AC10", VA = "0x184A9C610")]
	public ENKKNNIBDGN(TNode FHEIEGBMFAB, TReparentOperations FFKINJPHBPE, IHBGAKMALLJ NIFOLDHMJJK, bool OKLDHMEDEMM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface ENNOICOIPLO<TNode, TReparentOperations>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OPLBIAHNGEB([In] GMHJLBANBDF<TNode> PFLJIFPNBJO);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HAPDHOKJDAH([In] ENKKNNIBDGN<TNode, TReparentOperations> ANIACEHIKAA);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LOOHEGKKOBO();
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class BACCBCDAOPO<TNode, TReparentOperations> : JAOBCLCDPHC<ENNOICOIPLO<TNode, TReparentOperations>>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x4A43560", Offset = "0x4A41B60", VA = "0x184A43560")]
	public BACCBCDAOPO(ENNOICOIPLO<TNode, TReparentOperations> DCFBCOLBNJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x50A3180", Offset = "0x50A1780", VA = "0x1850A3180", Slot = "4")]
	public override bool MGDMFNNFPNM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class CEFPLFOBINE<TNode, TReparentOperations> : JAOBCLCDPHC<ENNOICOIPLO<TNode, TReparentOperations>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly ENKKNNIBDGN<TNode, TReparentOperations> ANIACEHIKAA;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6DCD290", Offset = "0x6DCB890", VA = "0x186DCD290")]
	public CEFPLFOBINE(TNode FHEIEGBMFAB, TReparentOperations FFKINJPHBPE, IHBGAKMALLJ NIFOLDHMJJK, ENNOICOIPLO<TNode, TReparentOperations> DCFBCOLBNJL, bool OKLDHMEDEMM = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x51E44F0", Offset = "0x51E2AF0", VA = "0x1851E44F0", Slot = "4")]
	public override bool MGDMFNNFPNM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class HEBIKANCBLO<TNode, TReparentOperations> : JAOBCLCDPHC<ENNOICOIPLO<TNode, TReparentOperations>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly GMHJLBANBDF<TNode> PFLJIFPNBJO;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x50A6E60", Offset = "0x50A5460", VA = "0x1850A6E60")]
	public HEBIKANCBLO(TNode FEEBALANLPG, ENNOICOIPLO<TNode, TReparentOperations> DCFBCOLBNJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x4A433B0", Offset = "0x4A419B0", VA = "0x184A433B0", Slot = "4")]
	public override bool MGDMFNNFPNM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct BHKIOLHBDJH<TSpawnInfo> where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public TSpawnInfo CHAGHFKLKLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public Vector3 AANGPKCDGHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public Quaternion NEOIPHFFLHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public float ILFCOODFNFF;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6863EF0", Offset = "0x68624F0", VA = "0x186863EF0")]
	public BHKIOLHBDJH(TSpawnInfo CHAGHFKLKLC, Vector3 AANGPKCDGHO, Quaternion NEOIPHFFLHF, float ILFCOODFNFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface OAODNKMLKFF<TSpawnType, TSpawnInfo>
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> NGCANDBDEDI([In] BHKIOLHBDJH<TSpawnInfo> MFEKKKBBLNP, CancellationToken MEKNAIONNND);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class LDJDIALFLCA<TSpawnType, TSpawnInfo> : HJMEPMDPBEP<OAODNKMLKFF<TSpawnType, TSpawnInfo>, TSpawnType> where TSpawnType : notnull where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly BHKIOLHBDJH<TSpawnInfo> KGIPMLMDBBA;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x56D3E10", Offset = "0x56D2410", VA = "0x1856D3E10")]
	public LDJDIALFLCA(TSpawnInfo KDJLEPIOBKK, Vector3 AANGPKCDGHO, Quaternion NEOIPHFFLHF, float ILFCOODFNFF, OAODNKMLKFF<TSpawnType, TSpawnInfo> DCFBCOLBNJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x56D3C30", Offset = "0x56D2230", VA = "0x1856D3C30", Slot = "4")]
	public override Task<TSpawnType> MGDMFNNFPNM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public readonly struct OOBMFIKOGCP<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly IEnumerable<TData> DKNBJGMNHBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly bool JPOFGMGDJJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly bool KFFIGLOEBCE;

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5B9C1C0", Offset = "0x5B9A7C0", VA = "0x185B9C1C0")]
	public OOBMFIKOGCP(IEnumerable<TData> FIEOCAHNJDC, bool OKLDHMEDEMM = false, bool MDDOMGKBDGB = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface PPLOGIDIGMG<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CMOAIHKBLFN> JAKOHEANJEN([In] OOBMFIKOGCP<TData> GJNHKMKILNM, CancellationToken MEKNAIONNND);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class NGMGMFJOJLE<TData> : HJMEPMDPBEP<PPLOGIDIGMG<TData>, CMOAIHKBLFN> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly OOBMFIKOGCP<TData> PMHMKPILEMJ;

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x59E6180", Offset = "0x59E4780", VA = "0x1859E6180")]
	public NGMGMFJOJLE(IEnumerable<TData> FIEOCAHNJDC, bool OKLDHMEDEMM, PPLOGIDIGMG<TData> DCFBCOLBNJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x56D3C30", Offset = "0x56D2230", VA = "0x1856D3C30", Slot = "4")]
	public override Task<CMOAIHKBLFN> MGDMFNNFPNM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct GHLICFNHPII<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly T LKEAKCADNOO;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x4FEE040", Offset = "0x4FEC640", VA = "0x184FEE040")]
	public GHLICFNHPII(T KIDIGAAHAKD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface CEHMKNGPIIG<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OPLBIAHNGEB([In] GHLICFNHPII<T> OPCBAGMDDBN);

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HAPDHOKJDAH();
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface GBJHEOHDEPE<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MGDMFNNFPNM([In] MCEIDPIDADL<T> INFDHLIPBKI);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public struct MCEIDPIDADL<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly T LKEAKCADNOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly bool OOCKDACPCIB;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x59488D0", Offset = "0x5946ED0", VA = "0x1859488D0")]
	public MCEIDPIDADL(T KIDIGAAHAKD, bool JICJBOHKJMM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class ALCIIAMBAGA<T> : JAOBCLCDPHC<CEHMKNGPIIG<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x4A43560", Offset = "0x4A41B60", VA = "0x184A43560")]
	public ALCIIAMBAGA(CEHMKNGPIIG<T> DCFBCOLBNJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5401C10", Offset = "0x5400210", VA = "0x185401C10", Slot = "4")]
	public override bool MGDMFNNFPNM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class EAIPOIMGAJC<T> : JAOBCLCDPHC<CEHMKNGPIIG<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly GHLICFNHPII<T> OPCBAGMDDBN;

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x4A43470", Offset = "0x4A41A70", VA = "0x184A43470")]
	public EAIPOIMGAJC(T LKEAKCADNOO, CEHMKNGPIIG<T> DCFBCOLBNJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x4A433B0", Offset = "0x4A419B0", VA = "0x184A433B0", Slot = "4")]
	public override bool MGDMFNNFPNM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class LGEEKAHHFKF<T> : JAOBCLCDPHC<GBJHEOHDEPE<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly MCEIDPIDADL<T> INFDHLIPBKI;

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5716450", Offset = "0x5714A50", VA = "0x185716450")]
	public LGEEKAHHFKF(T LKEAKCADNOO, bool JICJBOHKJMM, GBJHEOHDEPE<T> DCFBCOLBNJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x4A433B0", Offset = "0x4A419B0", VA = "0x184A433B0", Slot = "4")]
	public override bool MGDMFNNFPNM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public struct GDMGBNNAOPM<TData> where TData : notnull, LKONEEKPAON
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public IEnumerable<TData> DKNBJGMNHBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public bool BINCLNJEELA;

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x4FD7180", Offset = "0x4FD5780", VA = "0x184FD7180")]
	public GDMGBNNAOPM(IEnumerable<TData> CDJCOELMKFK, bool JIDDLOLAJJL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct GLLDCIIHIEI<TData> where TData : notnull, LKONEEKPAON
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public List<TData> DKNBJGMNHBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public List<bool> HFKGOMBEGGA;

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x4FF5C20", Offset = "0x4FF4220", VA = "0x184FF5C20")]
	public GLLDCIIHIEI(List<TData> CDJCOELMKFK, List<bool> KLGALMHDJPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface LKONEEKPAON
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool JLKPABJNDNA
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface BCBLFBKIFJO<TData> where TData : LKONEEKPAON
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MGDMFNNFPNM([In] GDMGBNNAOPM<TData> AIEBNKINJNC);

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MGDMFNNFPNM([In] GLLDCIIHIEI<TData> AIEBNKINJNC);
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface CPIOPBEHOAL<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LLNLOJIGMED(T LKEAKCADNOO);
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class KCGOHCNLPCF<TData> : JAOBCLCDPHC<BCBLFBKIFJO<TData>> where TData : notnull, LKONEEKPAON
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly GDMGBNNAOPM<TData> AIEBNKINJNC;

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x55ADF20", Offset = "0x55AC520", VA = "0x1855ADF20")]
	public KCGOHCNLPCF(List<TData> FIEOCAHNJDC, bool BINCLNJEELA, BCBLFBKIFJO<TData> DCFBCOLBNJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x4A433B0", Offset = "0x4A419B0", VA = "0x184A433B0", Slot = "4")]
	public override bool MGDMFNNFPNM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public class MIDGJLJAFDN<TData> : JAOBCLCDPHC<BCBLFBKIFJO<TData>> where TData : notnull, LKONEEKPAON
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly GLLDCIIHIEI<TData> AIEBNKINJNC;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x596CCE0", Offset = "0x596B2E0", VA = "0x18596CCE0")]
	public MIDGJLJAFDN(List<TData> FIEOCAHNJDC, List<bool> HFKGOMBEGGA, BCBLFBKIFJO<TData> DCFBCOLBNJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x596CC20", Offset = "0x596B220", VA = "0x18596CC20", Slot = "4")]
	public override bool MGDMFNNFPNM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public interface GGBNMDINGCN<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CMOAIHKBLFN> MGDMFNNFPNM(CCHAPOLDGAN<TData> DIKALNJLDKG);
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class DIFEKGLAMFE<TData> : HJMEPMDPBEP<GGBNMDINGCN<TData>, CMOAIHKBLFN> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private struct KBCCEIGLHJH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public AsyncTaskMethodBuilder<CMOAIHKBLFN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public DIFEKGLAMFE<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private TaskAwaiter<CMOAIHKBLFN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x55A8F50", Offset = "0x55A7550", VA = "0x1855A8F50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x55A9240", Offset = "0x55A7840", VA = "0x1855A9240", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly CCHAPOLDGAN<TData> OEALIGLKJEC;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x45A9300", Offset = "0x45A7900", VA = "0x1845A9300")]
	public DIFEKGLAMFE(TData GGDIOJGKKEN, IReadOnlyList<TData> MFJGJLJKNFD, bool OKLDHMEDEMM, GGBNMDINGCN<TData> DCFBCOLBNJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x45A9200", Offset = "0x45A7800", VA = "0x1845A9200", Slot = "4")]
	[AsyncStateMachine(typeof(DIFEKGLAMFE<>.KBCCEIGLHJH))]
	public override Task<CMOAIHKBLFN> MGDMFNNFPNM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public struct CCHAPOLDGAN<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public TData BBOIAKKPDNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public IReadOnlyList<TData> CCINFFKGEJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public bool JPOFGMGDJJE;

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3090A40", Offset = "0x308F040", VA = "0x183090A40")]
	public CCHAPOLDGAN(TData GGDIOJGKKEN, IReadOnlyList<TData> MFJGJLJKNFD, bool OKLDHMEDEMM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public interface DENGJCAALKN<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MGDMFNNFPNM([In] OCBJMEFIFKH<TData> EPLFJCCHPNH);
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface HPLCPHMGAOI<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MGDMFNNFPNM([In] IEGAOKBLAKJ<TData> EPLFJCCHPNH);
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface HFCDPMPECMH<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CMANLIFGJGJ([In] DPICAOPLDDK<TData> EPLFJCCHPNH);

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HAPDHOKJDAH();
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class GHLGOHFLPJC<TData> : JAOBCLCDPHC<DENGJCAALKN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly OCBJMEFIFKH<TData> EPLFJCCHPNH;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x4FEDF00", Offset = "0x4FEC500", VA = "0x184FEDF00")]
	public GHLGOHFLPJC(IEnumerable<TData> FIEOCAHNJDC, JHJALLMJIFB ONDGBPEOGJF, CKIILNPNIGK JKDFAJLFBEL, float BDGPOIHFPOM, string? IFCAGKLINAN, bool PNFMCJDJAGD, bool OKLDHMEDEMM, DENGJCAALKN<TData> DCFBCOLBNJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x4A433B0", Offset = "0x4A419B0", VA = "0x184A433B0", Slot = "4")]
	public override bool MGDMFNNFPNM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class NKIAGLFDJII<TData> : JAOBCLCDPHC<HPLCPHMGAOI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly IEGAOKBLAKJ<TData> EPLFJCCHPNH;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x59F1FF0", Offset = "0x59F05F0", VA = "0x1859F1FF0")]
	public NKIAGLFDJII(TData[] FIEOCAHNJDC, JHJALLMJIFB[] ONDGBPEOGJF, CKIILNPNIGK[] JKDFAJLFBEL, float[] BDGPOIHFPOM, HPLCPHMGAOI<TData> DCFBCOLBNJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x59F1E60", Offset = "0x59F0460", VA = "0x1859F1E60", Slot = "4")]
	public override bool MGDMFNNFPNM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class ACBHJPDDHJO<TData> : JAOBCLCDPHC<HFCDPMPECMH<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x4A43560", Offset = "0x4A41B60", VA = "0x184A43560")]
	public ACBHJPDDHJO(HFCDPMPECMH<TData> DCFBCOLBNJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x51DFE90", Offset = "0x51DE490", VA = "0x1851DFE90", Slot = "4")]
	public override bool MGDMFNNFPNM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class PBDKCIIAODE<TData> : JAOBCLCDPHC<HFCDPMPECMH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly DPICAOPLDDK<TData> EPLFJCCHPNH;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5C55FB0", Offset = "0x5C545B0", VA = "0x185C55FB0")]
	public PBDKCIIAODE(IEnumerable<TData> FIEOCAHNJDC, JHJALLMJIFB ONDGBPEOGJF, CKIILNPNIGK JKDFAJLFBEL, float BDGPOIHFPOM, HFCDPMPECMH<TData> DCFBCOLBNJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x59F1E60", Offset = "0x59F0460", VA = "0x1859F1E60", Slot = "4")]
	public override bool MGDMFNNFPNM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public struct OCBJMEFIFKH<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public IEnumerable<TData> DKNBJGMNHBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public JHJALLMJIFB JIIKHGGPGBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public CKIILNPNIGK OHJGNAFEKGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public float BALIPDKKMHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public string? GKPCMLDMKLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public bool? LIMBIPBLBBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public bool JPOFGMGDJJE;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x5B3A850", Offset = "0x5B38E50", VA = "0x185B3A850")]
	public OCBJMEFIFKH(IEnumerable<TData> FIEOCAHNJDC, JHJALLMJIFB ONDGBPEOGJF, CKIILNPNIGK JKDFAJLFBEL, float BDGPOIHFPOM, string? IFCAGKLINAN, bool? PNFMCJDJAGD, bool OKLDHMEDEMM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct IEGAOKBLAKJ<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public TData[] DKNBJGMNHBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public JHJALLMJIFB[] JIIKHGGPGBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public CKIILNPNIGK[] OHJGNAFEKGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public float[] BDGPOIHFPOM;

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x522D7C0", Offset = "0x522BDC0", VA = "0x18522D7C0")]
	public IEGAOKBLAKJ(TData[] FIEOCAHNJDC, JHJALLMJIFB[] ONDGBPEOGJF, CKIILNPNIGK[] JKDFAJLFBEL, float[] BDGPOIHFPOM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public struct DPICAOPLDDK<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public IEnumerable<TData> DKNBJGMNHBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public JHJALLMJIFB JIIKHGGPGBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public CKIILNPNIGK OHJGNAFEKGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public float BDGPOIHFPOM;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x45CF8E0", Offset = "0x45CDEE0", VA = "0x1845CF8E0")]
	public DPICAOPLDDK(IEnumerable<TData> FIEOCAHNJDC, JHJALLMJIFB ONDGBPEOGJF, CKIILNPNIGK JKDFAJLFBEL, float BDGPOIHFPOM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface OFOOBKAOFNP<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OKDBPDDCCFM([In] GDHKNHGPBME<TData> GJNHKMKILNM);

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CPADMLLBACK([In] GDHKNHGPBME<TData> GJNHKMKILNM);

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NNLDHDJJOLB([In] bool LDACBHCCJMA);

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool ICNBOGCMBFH([In] GDHKNHGPBME<TData> GJNHKMKILNM);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BIPEFAHEPEO();

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool DCCDBEDIEHB([In] TData MMJGCFHJBFH);
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class FGAAMLALPGI<TData> : JAOBCLCDPHC<OFOOBKAOFNP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly GDHKNHGPBME<TData> GJNHKMKILNM;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x4F3B580", Offset = "0x4F39B80", VA = "0x184F3B580")]
	public FGAAMLALPGI(List<TData> HLOMEJLEMOF, OFOOBKAOFNP<TData> DCFBCOLBNJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x4A433B0", Offset = "0x4A419B0", VA = "0x184A433B0", Slot = "4")]
	public override bool MGDMFNNFPNM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class BHMFFJNFMEA<TData> : JAOBCLCDPHC<OFOOBKAOFNP<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4A43560", Offset = "0x4A41B60", VA = "0x184A43560")]
	public BHMFFJNFMEA(OFOOBKAOFNP<TData> DCFBCOLBNJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6863F80", Offset = "0x6862580", VA = "0x186863F80", Slot = "4")]
	public override bool MGDMFNNFPNM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class AGIPHJDIIDJ<TData> : JAOBCLCDPHC<OFOOBKAOFNP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly bool OKLDHMEDEMM;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x53E7300", Offset = "0x53E5900", VA = "0x1853E7300")]
	public AGIPHJDIIDJ(bool OKLDHMEDEMM, OFOOBKAOFNP<TData> DCFBCOLBNJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x53E72A0", Offset = "0x53E58A0", VA = "0x1853E72A0", Slot = "4")]
	public override bool MGDMFNNFPNM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class CCMCKJBBDKF<TData> : JAOBCLCDPHC<OFOOBKAOFNP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly GDHKNHGPBME<TData> GJNHKMKILNM;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6DCA3C0", Offset = "0x6DC89C0", VA = "0x186DCA3C0")]
	public CCMCKJBBDKF(List<TData> HLOMEJLEMOF, bool OKLDHMEDEMM, OFOOBKAOFNP<TData> DCFBCOLBNJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x596CC20", Offset = "0x596B220", VA = "0x18596CC20", Slot = "4")]
	public override bool MGDMFNNFPNM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class HFHHEGLOPMM<TData> : JAOBCLCDPHC<OFOOBKAOFNP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly TData MMJGCFHJBFH;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x50B22E0", Offset = "0x50B08E0", VA = "0x1850B22E0")]
	public HFHHEGLOPMM(TData MMJGCFHJBFH, OFOOBKAOFNP<TData> DCFBCOLBNJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x50B2160", Offset = "0x50B0760", VA = "0x1850B2160", Slot = "4")]
	public override bool MGDMFNNFPNM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class CMLGFPLHKON<TData> : JAOBCLCDPHC<OFOOBKAOFNP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly GDHKNHGPBME<TData> GJNHKMKILNM;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6EC6C70", Offset = "0x6EC5270", VA = "0x186EC6C70")]
	public CMLGFPLHKON(IEnumerable<TData> HLOMEJLEMOF, OFOOBKAOFNP<TData> DCFBCOLBNJL, bool OKLDHMEDEMM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6EC6B00", Offset = "0x6EC5100", VA = "0x186EC6B00", Slot = "4")]
	public override bool MGDMFNNFPNM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public struct GDHKNHGPBME<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public IEnumerable<TData> DKNBJGMNHBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public bool OKLDHMEDEMM;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x4FD6E70", Offset = "0x4FD5470", VA = "0x184FD6E70")]
	public GDHKNHGPBME(IEnumerable<TData> CDJCOELMKFK, bool GADDIJEECEA = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public interface JGFLAGJGNMH
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CMOAIHKBLFN> MGDMFNNFPNM(MDFNOCNIEON KONIHEICECO);
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class HHAKAKEGEKH : HJMEPMDPBEP<JGFLAGJGNMH, CMOAIHKBLFN>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private struct FEPNCMDLEKA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public AsyncTaskMethodBuilder<CMOAIHKBLFN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public HHAKAKEGEKH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private TaskAwaiter<CMOAIHKBLFN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x84BE520", Offset = "0x84BCB20", VA = "0x1884BE520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x84BE790", Offset = "0x84BCD90", VA = "0x1884BE790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly MDFNOCNIEON DFIBHEIADCO;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x84BEFD0", Offset = "0x84BD5D0", VA = "0x1884BEFD0")]
	public HHAKAKEGEKH(bool OKLDHMEDEMM, JGFLAGJGNMH DCFBCOLBNJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x84BEEE0", Offset = "0x84BD4E0", VA = "0x1884BEEE0", Slot = "4")]
	[AsyncStateMachine(typeof(FEPNCMDLEKA))]
	public override Task<CMOAIHKBLFN> MGDMFNNFPNM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public struct MDFNOCNIEON
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public bool JPOFGMGDJJE;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x2D7FA20", Offset = "0x2D7E020", VA = "0x182D7FA20")]
	public MDFNOCNIEON(bool OKLDHMEDEMM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public readonly struct KNDIHLDGDGN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public readonly bool PHKFOIDEEBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public readonly bool IKOIFAOEHME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public readonly bool ILFCOODFNFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public readonly bool OKLDHMEDEMM;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6337980", Offset = "0x6335F80", VA = "0x186337980")]
	public KNDIHLDGDGN(bool PHKFOIDEEBI, bool IKOIFAOEHME, bool ILFCOODFNFF, bool OKLDHMEDEMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x84BF460", Offset = "0x84BDA60", VA = "0x1884BF460")]
	public KNDIHLDGDGN(bool IKOIFAOEHME, bool OKLDHMEDEMM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public interface LIHAIDHJJAH
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ICIFPLGNOCA(KNDIHLDGDGN DPFPNFHHLJC);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DJMEBAHGGGF(KNDIHLDGDGN DPFPNFHHLJC);
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public class JKAOIAPJOJF : JAOBCLCDPHC<LIHAIDHJJAH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly KNDIHLDGDGN DPFPNFHHLJC;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x84BF250", Offset = "0x84BD850", VA = "0x1884BF250")]
	public JKAOIAPJOJF(bool JAHKFPBBGHB, bool IKOIFAOEHME, bool ILFCOODFNFF, bool OKLDHMEDEMM, LIHAIDHJJAH DCFBCOLBNJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x84BF200", Offset = "0x84BD800", VA = "0x1884BF200", Slot = "4")]
	public override bool MGDMFNNFPNM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class PKJCNFPAIKE : JAOBCLCDPHC<LIHAIDHJJAH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly KNDIHLDGDGN DPFPNFHHLJC;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x84C0250", Offset = "0x84BE850", VA = "0x1884C0250")]
	public PKJCNFPAIKE(bool IKOIFAOEHME, bool OKLDHMEDEMM, LIHAIDHJJAH DCFBCOLBNJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x84C0200", Offset = "0x84BE800", VA = "0x1884C0200", Slot = "4")]
	public override bool MGDMFNNFPNM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public interface MGADIFMMDAM
{
	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MGDMFNNFPNM([In] MJMMHKBMDHL BCOKDPIDEAP);
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class BFICHFIAALH : JAOBCLCDPHC<MGADIFMMDAM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly MJMMHKBMDHL BCOKDPIDEAP;

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x84BE340", Offset = "0x84BC940", VA = "0x1884BE340")]
	public BFICHFIAALH(Guid[] LNMGNKDIGIA, Vector3[] EAJHPIDHJNB, Quaternion[] POBBMJNOGFC, float[] CIIAGHPEDBC, Dictionary<Guid, Vector3> CBEGFOEFACF, MGADIFMMDAM DCFBCOLBNJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x84BE290", Offset = "0x84BC890", VA = "0x1884BE290", Slot = "4")]
	public override bool MGDMFNNFPNM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public interface MFEOMEPOOOF<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OPLBIAHNGEB([In] PIEKGFGHDND<TData> PFLJIFPNBJO);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CMANLIFGJGJ([In] KKHCDJFGPAD LAGDMLLMOKI);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CMANLIFGJGJ([In] JFCLJAAIFIE LAGDMLLMOKI);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HAPDHOKJDAH();
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class JGNOILDEPHL<TData> : JAOBCLCDPHC<MFEOMEPOOOF<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x4A43560", Offset = "0x4A41B60", VA = "0x184A43560")]
	public JGNOILDEPHL(MFEOMEPOOOF<TData> DCFBCOLBNJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x54B5D60", Offset = "0x54B4360", VA = "0x1854B5D60", Slot = "4")]
	public override bool MGDMFNNFPNM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public class GFLLGIKFPCD<TData> : JAOBCLCDPHC<MFEOMEPOOOF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly KKHCDJFGPAD MOCBNMDBNJD;

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x4FE0DE0", Offset = "0x4FDF3E0", VA = "0x184FE0DE0")]
	public GFLLGIKFPCD(Vector3 IIGNKECLDHN, bool LGHBDFGOEPE, MFEOMEPOOOF<TData> DCFBCOLBNJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x4FE0D80", Offset = "0x4FDF380", VA = "0x184FE0D80", Slot = "4")]
	public override bool MGDMFNNFPNM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class OHGGHKEHEHE<TData> : JAOBCLCDPHC<MFEOMEPOOOF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly JFCLJAAIFIE MOCBNMDBNJD;

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5B69960", Offset = "0x5B67F60", VA = "0x185B69960")]
	public OHGGHKEHEHE(Guid POFEKCEDMHN, int LEPAEEGOBDO, Vector3 AANGPKCDGHO, Quaternion NEOIPHFFLHF, float OFHHJJPMNHK, bool LGHBDFGOEPE, MFEOMEPOOOF<TData> DCFBCOLBNJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5B69900", Offset = "0x5B67F00", VA = "0x185B69900", Slot = "4")]
	public override bool MGDMFNNFPNM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class MFLADAIJJHJ<TData> : JAOBCLCDPHC<MFEOMEPOOOF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly PIEKGFGHDND<TData> MOCBNMDBNJD;

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5953360", Offset = "0x5951960", VA = "0x185953360")]
	public MFLADAIJJHJ(TData LKEAKCADNOO, bool OKLDHMEDEMM, MFEOMEPOOOF<TData> DCFBCOLBNJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x4A433B0", Offset = "0x4A419B0", VA = "0x184A433B0", Slot = "4")]
	public override bool MGDMFNNFPNM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct KKHCDJFGPAD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public readonly Vector3 IIGNKECLDHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public readonly bool LGHBDFGOEPE;

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x84BF440", Offset = "0x84BDA40", VA = "0x1884BF440")]
	public KKHCDJFGPAD(Vector3 IIGNKECLDHN, bool LGHBDFGOEPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public struct JFCLJAAIFIE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public readonly Guid POFEKCEDMHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public readonly int LEPAEEGOBDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public readonly Vector3 AANGPKCDGHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public readonly Quaternion NEOIPHFFLHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly float OFHHJJPMNHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public readonly bool LGHBDFGOEPE;

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x84BF1C0", Offset = "0x84BD7C0", VA = "0x1884BF1C0")]
	public JFCLJAAIFIE(Guid POFEKCEDMHN, int LEPAEEGOBDO, Vector3 AANGPKCDGHO, Quaternion NEOIPHFFLHF, float OFHHJJPMNHK, bool LGHBDFGOEPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public struct PIEKGFGHDND<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public readonly TData LKEAKCADNOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public readonly bool OKLDHMEDEMM;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x5C71E10", Offset = "0x5C70410", VA = "0x185C71E10")]
	public PIEKGFGHDND(TData LKEAKCADNOO, bool OKLDHMEDEMM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public interface OAEDBEGIGOI<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MGDMFNNFPNM([In] NEGFJHIKOEA<TData> ELGGIOIPAOA);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MGDMFNNFPNM([In] MLKGMIKBKAF<TData> ELGGIOIPAOA);
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public interface LBAMKFCKECG<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OPLBIAHNGEB([In] CBIFACJJHJE<TData> LIHLDBNFLFK);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CMANLIFGJGJ([In] FCELOJLBHKB LAGDMLLMOKI);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HAPDHOKJDAH();
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public class JCCNCKHIOOK<TData> : JAOBCLCDPHC<OAEDBEGIGOI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly NEGFJHIKOEA<TData> ELGGIOIPAOA;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x549F840", Offset = "0x549DE40", VA = "0x18549F840")]
	public JCCNCKHIOOK(IEnumerable<TData> FIEOCAHNJDC, Vector3 DKKMCELMLHG, bool OKLDHMEDEMM, OAEDBEGIGOI<TData> DCFBCOLBNJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x4A433B0", Offset = "0x4A419B0", VA = "0x184A433B0", Slot = "4")]
	public override bool MGDMFNNFPNM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public class HAKPCACCOJD<TData> : JAOBCLCDPHC<LBAMKFCKECG<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x4A43560", Offset = "0x4A41B60", VA = "0x184A43560")]
	public HAKPCACCOJD(LBAMKFCKECG<TData> DCFBCOLBNJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x50A3180", Offset = "0x50A1780", VA = "0x1850A3180", Slot = "4")]
	public override bool MGDMFNNFPNM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class MGBKCLCMGEF<TData> : JAOBCLCDPHC<LBAMKFCKECG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly CBIFACJJHJE<TData> ELGGIOIPAOA;

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5955290", Offset = "0x5953890", VA = "0x185955290")]
	public MGBKCLCMGEF(IEnumerable<TData> FIEOCAHNJDC, bool OKLDHMEDEMM, LBAMKFCKECG<TData> DCFBCOLBNJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x4A433B0", Offset = "0x4A419B0", VA = "0x184A433B0", Slot = "4")]
	public override bool MGDMFNNFPNM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class ADGIJDBJHHA<TData> : JAOBCLCDPHC<OAEDBEGIGOI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly MLKGMIKBKAF<TData> ELGGIOIPAOA;

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x51E45C0", Offset = "0x51E2BC0", VA = "0x1851E45C0")]
	public ADGIJDBJHHA(IEnumerable<TData> FIEOCAHNJDC, Vector3 MCIMMHPBAGH, DMDCOHGKEPG IFCFKANIKNI, bool OKLDHMEDEMM, OAEDBEGIGOI<TData> DCFBCOLBNJL, Space ADGDNGLKHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x51E44F0", Offset = "0x51E2AF0", VA = "0x1851E44F0", Slot = "4")]
	public override bool MGDMFNNFPNM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class CGGNGPGLLHE<TData> : JAOBCLCDPHC<LBAMKFCKECG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly FCELOJLBHKB ELGGIOIPAOA;

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6DDA290", Offset = "0x6DD8890", VA = "0x186DDA290")]
	public CGGNGPGLLHE(Vector3 DKKMCELMLHG, LBAMKFCKECG<TData> DCFBCOLBNJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x4FE0D80", Offset = "0x4FDF380", VA = "0x184FE0D80", Slot = "4")]
	public override bool MGDMFNNFPNM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public struct NEGFJHIKOEA<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public readonly IEnumerable<TData> FIEOCAHNJDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public readonly Vector3 DKKMCELMLHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public readonly bool OKLDHMEDEMM;

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x59D4160", Offset = "0x59D2760", VA = "0x1859D4160")]
	public NEGFJHIKOEA(IEnumerable<TData> FIEOCAHNJDC, Vector3 DKKMCELMLHG, bool OKLDHMEDEMM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public struct CBIFACJJHJE<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public readonly IEnumerable<TData> FIEOCAHNJDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public readonly bool OKLDHMEDEMM;

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6DC59C0", Offset = "0x6DC3FC0", VA = "0x186DC59C0")]
	public CBIFACJJHJE(IEnumerable<TData> FIEOCAHNJDC, bool OKLDHMEDEMM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public struct MLKGMIKBKAF<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public readonly IEnumerable<TData> FIEOCAHNJDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public readonly Vector3 MCIMMHPBAGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public readonly DMDCOHGKEPG IFCFKANIKNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public readonly bool OKLDHMEDEMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public readonly Space ADGDNGLKHFE;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x59743A0", Offset = "0x59729A0", VA = "0x1859743A0")]
	public MLKGMIKBKAF(IEnumerable<TData> FIEOCAHNJDC, Vector3 MCIMMHPBAGH, DMDCOHGKEPG IFCFKANIKNI, bool OKLDHMEDEMM, Space ADGDNGLKHFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public struct FCELOJLBHKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public readonly Vector3 DKKMCELMLHG;

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x2D7BEE0", Offset = "0x2D7A4E0", VA = "0x182D7BEE0")]
	public FCELOJLBHKB(Vector3 DKKMCELMLHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public enum DMDCOHGKEPG
{
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	XYZ,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	X_only,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	Y_only,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	Z_only
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public interface IHCNPCCFFCB
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MGDMFNNFPNM([In] MFEGPHBOMMC LIGCMKGENIO);
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public class GJIPLKEJLNM : JAOBCLCDPHC<IHCNPCCFFCB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private readonly MFEGPHBOMMC LIGCMKGENIO;

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x84BEA60", Offset = "0x84BD060", VA = "0x1884BEA60")]
	public GJIPLKEJLNM(bool OKLDHMEDEMM, IHCNPCCFFCB DCFBCOLBNJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x84BE9B0", Offset = "0x84BCFB0", VA = "0x1884BE9B0", Slot = "4")]
	public override bool MGDMFNNFPNM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public readonly struct MFEGPHBOMMC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public readonly bool OKLDHMEDEMM;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x2D7FA20", Offset = "0x2D7E020", VA = "0x182D7FA20")]
	public MFEGPHBOMMC(bool OKLDHMEDEMM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public interface EOLHJNPEGEL<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MGDMFNNFPNM([In] JAGMEHMHPPI<TData> LLKBCCNGMGC);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MGDMFNNFPNM([In] OEHFDEDJFDM<TData> LLKBCCNGMGC);
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public interface NKOAJIAPKOG<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OPLBIAHNGEB([In] MLMEOFKIHLE<TData> PFLJIFPNBJO);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CMANLIFGJGJ([In] MIINHFDEOAA LAGDMLLMOKI);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HAPDHOKJDAH();
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class JNDDJGHGCFO<TData> : JAOBCLCDPHC<EOLHJNPEGEL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly JAGMEHMHPPI<TData> LLKBCCNGMGC;

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x54F9980", Offset = "0x54F7F80", VA = "0x1854F9980")]
	public JNDDJGHGCFO(IEnumerable<TData> FIEOCAHNJDC, Quaternion DKKMCELMLHG, Vector3? KIIGFGBJJOC, bool NODAIJIPMAD, bool OKLDHMEDEMM, EOLHJNPEGEL<TData> DCFBCOLBNJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x4A433B0", Offset = "0x4A419B0", VA = "0x184A433B0", Slot = "4")]
	public override bool MGDMFNNFPNM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class KCEKGCHFLPB<TData> : JAOBCLCDPHC<NKOAJIAPKOG<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x4A43560", Offset = "0x4A41B60", VA = "0x184A43560")]
	public KCEKGCHFLPB(NKOAJIAPKOG<TData> DCFBCOLBNJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x50A3180", Offset = "0x50A1780", VA = "0x1850A3180", Slot = "4")]
	public override bool MGDMFNNFPNM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public class COPNAMLHIBO<TData> : JAOBCLCDPHC<NKOAJIAPKOG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly MLMEOFKIHLE<TData> LLKBCCNGMGC;

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x6ED0C30", Offset = "0x6ECF230", VA = "0x186ED0C30")]
	public COPNAMLHIBO(IEnumerable<TData> FIEOCAHNJDC, bool OKLDHMEDEMM, NKOAJIAPKOG<TData> DCFBCOLBNJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x4A433B0", Offset = "0x4A419B0", VA = "0x184A433B0", Slot = "4")]
	public override bool MGDMFNNFPNM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public class MCIJCOLLONA<TData> : JAOBCLCDPHC<EOLHJNPEGEL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly OEHFDEDJFDM<TData> LLKBCCNGMGC;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x59490C0", Offset = "0x59476C0", VA = "0x1859490C0")]
	public MCIJCOLLONA(IEnumerable<TData> FIEOCAHNJDC, Quaternion GBCPIPHPNMN, DMDCOHGKEPG DNFDPGKKMFN, Vector3? KIIGFGBJJOC, bool NODAIJIPMAD, bool OKLDHMEDEMM, Space ADGDNGLKHFE, EOLHJNPEGEL<TData> DCFBCOLBNJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x51E44F0", Offset = "0x51E2AF0", VA = "0x1851E44F0", Slot = "4")]
	public override bool MGDMFNNFPNM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public class NKJAOFBLMAM<TData> : JAOBCLCDPHC<NKOAJIAPKOG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly MIINHFDEOAA LLKBCCNGMGC;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x59F2E60", Offset = "0x59F1460", VA = "0x1859F2E60")]
	public NKJAOFBLMAM(Quaternion DKKMCELMLHG, Vector3? KIIGFGBJJOC, bool NODAIJIPMAD, NKOAJIAPKOG<TData> DCFBCOLBNJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x4FE0D80", Offset = "0x4FDF380", VA = "0x184FE0D80", Slot = "4")]
	public override bool MGDMFNNFPNM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public struct JAGMEHMHPPI<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public readonly IEnumerable<TData> FIEOCAHNJDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public readonly Quaternion DKKMCELMLHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public readonly Vector3? KIIGFGBJJOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public readonly bool NODAIJIPMAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly bool OKLDHMEDEMM;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x549C910", Offset = "0x549AF10", VA = "0x18549C910")]
	public JAGMEHMHPPI(IEnumerable<TData> FIEOCAHNJDC, Quaternion DKKMCELMLHG, Vector3? KIIGFGBJJOC, bool NODAIJIPMAD, bool OKLDHMEDEMM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct MLMEOFKIHLE<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public readonly IEnumerable<TData> FIEOCAHNJDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly bool OKLDHMEDEMM;

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x5975770", Offset = "0x5973D70", VA = "0x185975770")]
	public MLMEOFKIHLE(IEnumerable<TData> FIEOCAHNJDC, bool OKLDHMEDEMM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public struct OEHFDEDJFDM<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public readonly IEnumerable<TData> FIEOCAHNJDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public readonly Quaternion GBCPIPHPNMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public readonly DMDCOHGKEPG DNFDPGKKMFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public readonly Vector3? KIIGFGBJJOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public readonly bool NODAIJIPMAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public readonly bool OKLDHMEDEMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public readonly Space ADGDNGLKHFE;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x5B3F180", Offset = "0x5B3D780", VA = "0x185B3F180")]
	public OEHFDEDJFDM(IEnumerable<TData> FIEOCAHNJDC, Quaternion GBCPIPHPNMN, DMDCOHGKEPG DNFDPGKKMFN, Vector3? KIIGFGBJJOC, bool NODAIJIPMAD, bool OKLDHMEDEMM, Space ADGDNGLKHFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public struct MIINHFDEOAA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public readonly Quaternion DKKMCELMLHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public readonly Vector3? KIIGFGBJJOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public readonly bool NODAIJIPMAD;

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x62DD980", Offset = "0x62DBF80", VA = "0x1862DD980")]
	public MIINHFDEOAA(Quaternion DKKMCELMLHG, Vector3? KIIGFGBJJOC, bool NODAIJIPMAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public interface COCBAGKBGGB<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OPLBIAHNGEB([In] KDPIDEJDMOB<TData> PFLJIFPNBJO);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CMANLIFGJGJ([In] IKEEBPOAEGI LAGDMLLMOKI);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CMANLIFGJGJ([In] IBNIBNABPGI LAGDMLLMOKI);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CMANLIFGJGJ([In] PDDPLAHELDN LAGDMLLMOKI);

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool HAPDHOKJDAH();
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public class JIJHHJEEPJH<TData> : JAOBCLCDPHC<COCBAGKBGGB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private readonly PDDPLAHELDN NCIOFPNLFHP;

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x54BE070", Offset = "0x54BC670", VA = "0x1854BE070")]
	public JIJHHJEEPJH(Vector3 MHAEKDMIMEG, float DFPGIFAKBHK, Vector3 KIIGFGBJJOC, bool MNHBMFOMKIL, bool IHIPMLNJFLM, COCBAGKBGGB<TData> DCFBCOLBNJL, Space ADGDNGLKHFE = Space.Self)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x54BE010", Offset = "0x54BC610", VA = "0x1854BE010", Slot = "4")]
	public override bool MGDMFNNFPNM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public class NCIDJKDKMFF<TData> : JAOBCLCDPHC<COCBAGKBGGB<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x4A43560", Offset = "0x4A41B60", VA = "0x184A43560")]
	public NCIDJKDKMFF(COCBAGKBGGB<TData> DCFBCOLBNJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x59CDE10", Offset = "0x59CC410", VA = "0x1859CDE10", Slot = "4")]
	public override bool MGDMFNNFPNM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public class IOECLFFBGPF<TData> : JAOBCLCDPHC<COCBAGKBGGB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly KDPIDEJDMOB<TData> NCIOFPNLFHP;

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x5277880", Offset = "0x5275E80", VA = "0x185277880")]
	public IOECLFFBGPF(IEnumerable<TData> FIEOCAHNJDC, bool OKLDHMEDEMM, COCBAGKBGGB<TData> DCFBCOLBNJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x4A433B0", Offset = "0x4A419B0", VA = "0x184A433B0", Slot = "4")]
	public override bool MGDMFNNFPNM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public class GMEPOHIDEKL<TData> : JAOBCLCDPHC<COCBAGKBGGB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private readonly IBNIBNABPGI NCIOFPNLFHP;

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x500C550", Offset = "0x500AB50", VA = "0x18500C550")]
	public GMEPOHIDEKL(float NPNCNOPDCLJ, bool CNADGMKCLHO, Vector3 KIIGFGBJJOC, COCBAGKBGGB<TData> DCFBCOLBNJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x500C480", Offset = "0x500AA80", VA = "0x18500C480", Slot = "4")]
	public override bool MGDMFNNFPNM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public class ILOMIIDPLMI<TData> : JAOBCLCDPHC<COCBAGKBGGB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly IKEEBPOAEGI NCIOFPNLFHP;

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x525D210", Offset = "0x525B810", VA = "0x18525D210")]
	public ILOMIIDPLMI(float DFPGIFAKBHK, Vector3 KIIGFGBJJOC, COCBAGKBGGB<TData> DCFBCOLBNJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x4FE0D80", Offset = "0x4FDF380", VA = "0x184FE0D80", Slot = "4")]
	public override bool MGDMFNNFPNM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public struct PDDPLAHELDN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public readonly Vector3 MHAEKDMIMEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public readonly float DFPGIFAKBHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public readonly Vector3 KIIGFGBJJOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public readonly bool LGHBDFGOEPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public readonly Space ADGDNGLKHFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public readonly bool IHIPMLNJFLM;

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x84BFE90", Offset = "0x84BE490", VA = "0x1884BFE90")]
	public PDDPLAHELDN(Vector3 MHAEKDMIMEG, float DFPGIFAKBHK, Vector3 KIIGFGBJJOC, bool LGHBDFGOEPE, bool EFJCPPCKOFH, Space ADGDNGLKHFE = Space.Self)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public struct KDPIDEJDMOB<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public readonly IEnumerable<TData> FIEOCAHNJDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public readonly bool OKLDHMEDEMM;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x55B6ED0", Offset = "0x55B54D0", VA = "0x1855B6ED0")]
	public KDPIDEJDMOB(IEnumerable<TData> FIEOCAHNJDC, bool OKLDHMEDEMM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public struct IBNIBNABPGI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public readonly float NPNCNOPDCLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public readonly bool CNADGMKCLHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public readonly Vector3 KIIGFGBJJOC;

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x84BF030", Offset = "0x84BD630", VA = "0x1884BF030")]
	public IBNIBNABPGI(float NPNCNOPDCLJ, bool CNADGMKCLHO, Vector3 KIIGFGBJJOC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public struct IKEEBPOAEGI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public readonly float DFPGIFAKBHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public readonly Vector3 KIIGFGBJJOC;

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x62A0790", Offset = "0x629ED90", VA = "0x1862A0790")]
	public IKEEBPOAEGI(float DFPGIFAKBHK, Vector3 KIIGFGBJJOC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public struct MJMMHKBMDHL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public readonly Guid[] FIEOCAHNJDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public readonly bool KPAKJIFGACG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public readonly bool HMEAGPCDNPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public readonly bool JNBFOAKHGJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public readonly Vector3[] EAJHPIDHJNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public readonly Quaternion[] POBBMJNOGFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public readonly float[] CIIAGHPEDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public readonly Dictionary<Guid, Vector3> CBEGFOEFACF;

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x84BF870", Offset = "0x84BDE70", VA = "0x1884BF870")]
	public MJMMHKBMDHL(Guid[] LNMGNKDIGIA, Vector3[] EAJHPIDHJNB, Quaternion[] POBBMJNOGFC, float[] CIIAGHPEDBC, Dictionary<Guid, Vector3> CBEGFOEFACF, bool KPAKJIFGACG = true, bool HMEAGPCDNPJ = true, bool JNBFOAKHGJE = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x84BF6A0", Offset = "0x84BDCA0", VA = "0x1884BF6A0")]
	private static void FCEOKIGBEEB(Dictionary<Guid, Vector3> CBEGFOEFACF, int HLJEBOEPPEP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public static class GNDCOJNHFPP
{
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	private struct JMOABFFOBFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public bool PLGLDFMDJBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public CFPMHDJNIAH LKBCKBEGNBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public CFPMHDJNIAH BBGFGAPGJGF;
	}

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private static JMOABFFOBFG CMOJKBKFODI;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static CancellationToken CBGNCAEJLOI
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x84BEAC0", Offset = "0x84BD0C0", VA = "0x1884BEAC0")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	internal static CFPMHDJNIAH LKBCKBEGNBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x84BEE00", Offset = "0x84BD400", VA = "0x1884BEE00")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x84BEC90", Offset = "0x84BD290", VA = "0x1884BEC90")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x84BED00", Offset = "0x84BD300", VA = "0x1884BED00")]
	[LAFCEDCMNGK.BFGJFLBGMGB]
	internal static void KHJKENNIAIC(CFPMHDJNIAH LNIBAKMCLAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x84BEB30", Offset = "0x84BD130", VA = "0x1884BEB30")]
	public static void IMGLACMMFNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x84BEAE0", Offset = "0x84BD0E0", VA = "0x1884BEAE0")]
	private static CFPMHDJNIAH HFHGODFHAFA(CFPMHDJNIAH FNADJPNAOOL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public static class EAFHIGMMMAN
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public enum BEFKCHFIJOB
	{
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		ICreationContextObject,
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		Guid
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x3C00670", Offset = "0x3BFEC70", VA = "0x183C00670")]
	public static void LDPLFAKAIGL<T>(T PLKOLLOCKHK, BEFKCHFIJOB EHLAHNIAPLD) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3C00610", Offset = "0x3BFEC10", VA = "0x183C00610")]
	public static void LDPLFAKAIGL<T>(T PLKOLLOCKHK) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x3C00530", Offset = "0x3BFEB30", VA = "0x183C00530")]
	public static void LDPLFAKAIGL<T, TImpl, T>() where T : class where TImpl : notnull, T where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x3C00420", Offset = "0x3BFEA20", VA = "0x183C00420")]
	public static void EOGGJJFBMBE<T>(T PLKOLLOCKHK) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x3C00490", Offset = "0x3BFEA90", VA = "0x183C00490")]
	public static T JLOHDPKHFGN<T>(BEFKCHFIJOB EHLAHNIAPLD) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x3C002F0", Offset = "0x3BFE8F0", VA = "0x183C002F0")]
	public static bool BOHILBMMPDC<T>(BEFKCHFIJOB EHLAHNIAPLD, T? NKIPIAKLGDK, [Out][MaybeNullWhen(false)][NotNullWhen(true)] T APIPGCNMDNH) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x3C00070", Offset = "0x3BFE670", VA = "0x183C00070")]
	public static bool AIGLFKHHBDN<T>(BEFKCHFIJOB EHLAHNIAPLD, [Out][NotNullWhen(true)][MaybeNullWhen(false)] T FPCDILNKBDF) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x3C001B0", Offset = "0x3BFE7B0", VA = "0x183C001B0")]
	public static bool AJPDPNLJPNJ<T>(BEFKCHFIJOB EHLAHNIAPLD) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x3C00170", Offset = "0x3BFE770", VA = "0x183C00170")]
	public static T JLOHDPKHFGN<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x3C00250", Offset = "0x3BFE850", VA = "0x183C00250")]
	public static bool BOHILBMMPDC<T>(T NKIPIAKLGDK, [Out] T APIPGCNMDNH) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x3C00170", Offset = "0x3BFE770", VA = "0x183C00170")]
	public static bool AJPDPNLJPNJ<T>() where T : class
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
internal static class LDNHMIJJCOO
{
	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x84BF470", Offset = "0x84BDA70", VA = "0x1884BF470")]
	public static void FPFKBIMHGPO(IEnumerable JLOLHCDOILB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x3E77780", Offset = "0x3E75D80", VA = "0x183E77780")]
	public static void FPFKBIMHGPO<T>(T[] OHHBFAGELLA) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x3E77960", Offset = "0x3E75F60", VA = "0x183E77960")]
	public static void FPFKBIMHGPO<T>(T FBLLKKIPJDD) where T : notnull, Enum
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
