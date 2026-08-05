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
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7B833C0", Offset = "0x7B81BC0", VA = "0x187B833C0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA09330", Offset = "0xA07B30", VA = "0x180A09330")]
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
		[Cpp2IlInjected.Address(RVA = "0xA09370", Offset = "0xA07B70", VA = "0x180A09370")]
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
		[Cpp2IlInjected.Address(RVA = "0x7B835C0", Offset = "0x7B81DC0", VA = "0x187B835C0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2612DF0", Offset = "0x26115F0", VA = "0x182612DF0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface POKOCHOLEHC<TData, TReturn>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TReturn NCJDDPKIAAB(TData PNHCNFOFAFI);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface DILKIMFOCND<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ClearHoverTarget(KLEINPMDINN MFPLILPACGK);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool SetHoverTarget(TData ALLFIKNKLHM, Collider OLFFCMGLGOF, KLEINPMDINN MFPLILPACGK, [Optional] HFLHFCIMFNP? KJNNKIANJBF);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool TryGetHoverTarget([Out] TData ALLFIKNKLHM);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetHoverCollider([Out] Collider OLFFCMGLGOF);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface KIAMNLMLCOO<TData> : MOKFCBOFELJ, EDIEKMHKAFE<TData>, IHNDBLKDMMN<TData>, FKNHGOOJOKI<TData>, FOLDDJFHNPP, ALOBEFCBFJK<TData>, ENFMOEJFPPG, CEIDOFPEKHO
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface ALOBEFCBFJK<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 HBMCBDFIIOP, Vector3 ELEEIMOLKDP, float ECLNGJKMDDA, [Out] T COKHOLJMBLG, [Out] Vector3 EJCPPNNDACB, [Out] Collider OLFFCMGLGOF);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 HBMCBDFIIOP, Vector3 ELEEIMOLKDP, float BJIDFDPMJAP, float ECLNGJKMDDA, T[] FDALIKJGKNJ, [Out] Vector3 HFJPBGIGEBJ, [Out] Collider HFDKGCPAGKB);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 HBMCBDFIIOP, float BJIDFDPMJAP, Vector3 HEIKIPCPAGD, T[] FDALIKJGKNJ);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetObjectFromColliderInCurrentScope(Collider BMLEIFODCAD, [Out] T IMDOPDJFIIE);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface MOKFCBOFELJ
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Bounds HIFAMJBODFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Transform LJAJKNLIAEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Bounds IHPJPJHKFHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Transform JGEILPIGBDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Vector3 JJENGGMNGPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool EFFDGDGFMEL
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
	void SetSelectionBoundsDirty(bool PKCDNHAGMNH = true, int DEEEKDKLAJE = 0);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ShouldHideSelectionBoundsPreview(bool PKPFMEAMMEJ, object JILOCOLKOMJ);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface CEIDOFPEKHO
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	FIEKIAHLEMJ EDOHKNIJFAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface OLLGFKPAJIC
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool EGFCEINHJLM
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool DHLMPNNPPFF
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool LMOMHPNFBBL
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
	void TrySetPreviousCloneMapping(Dictionary<Guid, Guid> IEOKOODCIGM);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface FKNHGOOJOKI<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool KKOIINLAFAE
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int IOJKHLAPMKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<TData> HKCAIODILEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData BLFLGKHLJNB);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData BLFLGKHLJNB);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface EDIEKMHKAFE<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T PNHCNFOFAFI, [Optional] HFLHFCIMFNP? POCCMBPNGEN, bool NHKBCMBEMEM = true);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int PCFOAHIEPDL, IEnumerable<T> PIBKMLFALDL, bool NHKBCMBEMEM = true);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int PCFOAHIEPDL, IEnumerable<T> PIBKMLFALDL, HFLHFCIMFNP POCCMBPNGEN, bool NHKBCMBEMEM = true);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface ENFMOEJFPPG
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface FOLDDJFHNPP
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool KEAODJMEOMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool MPOLODCAMMP
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool MOBMBGAOGGC
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool BKGJOFALPLC
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct BBJJNMINOHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public bool AJLGOHLDMBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public float? EMBCOGMDCKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public float? KALELABMGAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public float? FJEOACKEJEG;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct JDOLCHCDAEE<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public IEnumerable<TData> IBPJMGNOBOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public BBJJNMINOHP BOMLANFBMPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public bool BBNCMLHJDFE;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4D64010", Offset = "0x4D62810", VA = "0x184D64010")]
	public JDOLCHCDAEE(IEnumerable<TData> LEHOHGGIOBE, bool NLOCNBEDOKN, float? FDJJBIMHDAL, float? LPANGBAAEHJ, float? ACIDHGIAMOJ, bool BBNCMLHJDFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface HGJGADGIPOH<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FIJDKNIDPMK([In] JDOLCHCDAEE<TData> FHMAIKMLNLH);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class IHDOFNHNGMI<TData> : DLEPKENPGJD<HGJGADGIPOH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly JDOLCHCDAEE<TData> FHMAIKMLNLH;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4B74450", Offset = "0x4B72C50", VA = "0x184B74450")]
	public IHDOFNHNGMI(IEnumerable<TData> LEHOHGGIOBE, bool NLOCNBEDOKN, float? FDJJBIMHDAL, float? LPANGBAAEHJ, float? ACIDHGIAMOJ, bool BBNCMLHJDFE, HGJGADGIPOH<TData> KEEAPFDDBLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x43EB5E0", Offset = "0x43E9DE0", VA = "0x1843EB5E0", Slot = "4")]
	public override bool FIJDKNIDPMK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct OIIIKJDEMLF<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public IEnumerable<TData> IBPJMGNOBOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public string GFJBHKHMHCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public bool DIPEBFBGHGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public bool BBNCMLHJDFE;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5473AB0", Offset = "0x54722B0", VA = "0x185473AB0")]
	public OIIIKJDEMLF(IEnumerable<TData> LEHOHGGIOBE, string LJANIECHELJ, bool NPNDFGKEILN, bool BBNCMLHJDFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface ABNHLIPDOHD<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FIJDKNIDPMK([In] OIIIKJDEMLF<TData> FHMAIKMLNLH);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class HPMDAAKNBKD<TData> : DLEPKENPGJD<ABNHLIPDOHD<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly OIIIKJDEMLF<TData> FHMAIKMLNLH;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4A9FDD0", Offset = "0x4A9E5D0", VA = "0x184A9FDD0")]
	public HPMDAAKNBKD(IEnumerable<TData> LEHOHGGIOBE, string LJANIECHELJ, bool NPNDFGKEILN, bool BBNCMLHJDFE, ABNHLIPDOHD<TData> KEEAPFDDBLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x43EB5E0", Offset = "0x43E9DE0", VA = "0x1843EB5E0", Slot = "4")]
	public override bool FIJDKNIDPMK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public abstract class DLEPKENPGJD<TReceiver> : CEAPDIGGODO<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x43E20D0", Offset = "0x43E08D0", VA = "0x1843E20D0")]
	public DLEPKENPGJD(TReceiver KEEAPFDDBLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public abstract class PIHCJJPOKAH<TReceiver, TFromTask> : CEAPDIGGODO<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x43E20D0", Offset = "0x43E08D0", VA = "0x1843E20D0")]
	public PIHCJJPOKAH(TReceiver KEEAPFDDBLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public abstract class CEAPDIGGODO<TReceiver, TFromExecute> where TReceiver : notnull where TFromExecute : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	protected TReceiver KEEAPFDDBLD;

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x630D900", Offset = "0x630C100", VA = "0x18630D900")]
	public CEAPDIGGODO(TReceiver KEEAPFDDBLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute FIJDKNIDPMK();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class HNGODMMGNBA<TReceiver, TResult> : CEAPDIGGODO<TReceiver, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x43E20D0", Offset = "0x43E08D0", VA = "0x1843E20D0")]
	public HNGODMMGNBA(TReceiver KEEAPFDDBLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct FDBABFBEDMM<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public TGroup OLAIJDFEJBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public TData FEHNBNKAPDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public IEnumerable<TData> IBPJMGNOBOG;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2623900", Offset = "0x2622100", VA = "0x182623900")]
	public FDBABFBEDMM(TGroup IGCPBHHJAAC, TData GAOLHOHIIEG, IEnumerable<TData> LEHOHGGIOBE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct GHNNCBAHLAI<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public TGroup OLAIJDFEJBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public IEnumerable<TData> IBPJMGNOBOG;

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0xA81780", Offset = "0xA7FF80", VA = "0x180A81780")]
	public GHNNCBAHLAI(TGroup IGCPBHHJAAC, IEnumerable<TData> LEHOHGGIOBE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct LLIGGGMLIDB<TGroup> where TGroup : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public TGroup OLAIJDFEJBB;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0xCEDE50", Offset = "0xCEC650", VA = "0x180CEDE50")]
	public LLIGGGMLIDB(TGroup IGCPBHHJAAC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct MEBOLJIFDLP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public IEnumerable<Guid> IBPJMGNOBOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public Guid ELOFGNAEKPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public readonly bool HLEFLIFOBLF;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7B82F20", Offset = "0x7B81720", VA = "0x187B82F20")]
	public MEBOLJIFDLP(IEnumerable<Guid> LEHOHGGIOBE, Guid HICHHNGCDAI, bool BBNCMLHJDFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct HCNHBCGJBGJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public Guid ELOFGNAEKPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly bool HLEFLIFOBLF;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2534A00", Offset = "0x2533200", VA = "0x182534A00")]
	public HCNHBCGJBGJ(Guid HICHHNGCDAI, bool BBNCMLHJDFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface CECEHEJMMME<TGroup, TData>
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GBAGLFMEAKA JAEGMDMLDBH(FDBABFBEDMM<TGroup, TData> MHGHNFENCGJ);

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GBAGLFMEAKA OONEKADJGAO(FDBABFBEDMM<TGroup, TData> MHGHNFENCGJ);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GBAGLFMEAKA NDNONMDFPGN(GHNNCBAHLAI<TGroup, TData> MHGHNFENCGJ);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GBAGLFMEAKA NLNBFNBOGCJ(LLIGGGMLIDB<TGroup> MHGHNFENCGJ);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface GMILGDIHDLE
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<GBAGLFMEAKA> JAEGMDMLDBH(MEBOLJIFDLP MHGHNFENCGJ);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<GBAGLFMEAKA> OONEKADJGAO(HCNHBCGJBGJ MHGHNFENCGJ);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class KJIBDALBDNC<TGroup, TData> : HNGODMMGNBA<CECEHEJMMME<TGroup, TData>, GBAGLFMEAKA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly GHNNCBAHLAI<TGroup, TData> MHGHNFENCGJ;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x4F2B9D0", Offset = "0x4F2A1D0", VA = "0x184F2B9D0")]
	public KJIBDALBDNC(TGroup IGCPBHHJAAC, IEnumerable<TData> LEHOHGGIOBE, CECEHEJMMME<TGroup, TData> KEEAPFDDBLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x4F2B900", Offset = "0x4F2A100", VA = "0x184F2B900", Slot = "4")]
	public override GBAGLFMEAKA FIJDKNIDPMK()
	{
		return default(GBAGLFMEAKA);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class OOCBAOMKKBB<TGroup, TData> : HNGODMMGNBA<CECEHEJMMME<TGroup, TData>, GBAGLFMEAKA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly FDBABFBEDMM<TGroup, TData> MHGHNFENCGJ;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x4B79D00", Offset = "0x4B78500", VA = "0x184B79D00")]
	public OOCBAOMKKBB(TGroup IGCPBHHJAAC, TData FFCNFODBECI, IEnumerable<TData> LEHOHGGIOBE, CECEHEJMMME<TGroup, TData> KEEAPFDDBLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5484640", Offset = "0x5482E40", VA = "0x185484640", Slot = "4")]
	public override GBAGLFMEAKA FIJDKNIDPMK()
	{
		return default(GBAGLFMEAKA);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class NPMIODGPBCH<TGroup, TData> : HNGODMMGNBA<CECEHEJMMME<TGroup, TData>, GBAGLFMEAKA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly LLIGGGMLIDB<TGroup> MHGHNFENCGJ;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x4A55480", Offset = "0x4A53C80", VA = "0x184A55480")]
	public NPMIODGPBCH(TGroup IGCPBHHJAAC, CECEHEJMMME<TGroup, TData> KEEAPFDDBLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x535B310", Offset = "0x5359B10", VA = "0x18535B310", Slot = "4")]
	public override GBAGLFMEAKA FIJDKNIDPMK()
	{
		return default(GBAGLFMEAKA);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class IJECHGLPNBI<TGroup, TData> : HNGODMMGNBA<CECEHEJMMME<TGroup, TData>, GBAGLFMEAKA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly FDBABFBEDMM<TGroup, TData> MHGHNFENCGJ;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4B79D00", Offset = "0x4B78500", VA = "0x184B79D00")]
	public IJECHGLPNBI(TGroup IGCPBHHJAAC, TData GAOLHOHIIEG, IEnumerable<TData> LEHOHGGIOBE, CECEHEJMMME<TGroup, TData> KEEAPFDDBLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x4B79C20", Offset = "0x4B78420", VA = "0x184B79C20", Slot = "4")]
	public override GBAGLFMEAKA FIJDKNIDPMK()
	{
		return default(GBAGLFMEAKA);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class GOAMBEOEELG : PIHCJJPOKAH<GMILGDIHDLE, GBAGLFMEAKA>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct DFADGLHJGKD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public AsyncTaskMethodBuilder<GBAGLFMEAKA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public GOAMBEOEELG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private TaskAwaiter<GBAGLFMEAKA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7B81F40", Offset = "0x7B80740", VA = "0x187B81F40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7B821D0", Offset = "0x7B809D0", VA = "0x187B821D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private MEBOLJIFDLP MHGHNFENCGJ;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7B826B0", Offset = "0x7B80EB0", VA = "0x187B826B0")]
	public GOAMBEOEELG(IEnumerable<Guid> KIKIFPMKONA, Guid HICHHNGCDAI, bool BBNCMLHJDFE, GMILGDIHDLE KEEAPFDDBLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7B825C0", Offset = "0x7B80DC0", VA = "0x187B825C0", Slot = "4")]
	[AsyncStateMachine(typeof(DFADGLHJGKD))]
	public override Task<GBAGLFMEAKA> FIJDKNIDPMK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class OGEEMDHONDN : PIHCJJPOKAH<GMILGDIHDLE, GBAGLFMEAKA>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private struct HBIELMADKLD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public AsyncTaskMethodBuilder<GBAGLFMEAKA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public OGEEMDHONDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private TaskAwaiter<GBAGLFMEAKA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7B82A60", Offset = "0x7B81260", VA = "0x187B82A60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7B82D00", Offset = "0x7B81500", VA = "0x187B82D00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly HCNHBCGJBGJ MHGHNFENCGJ;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7B83530", Offset = "0x7B81D30", VA = "0x187B83530")]
	public OGEEMDHONDN(Guid HICHHNGCDAI, bool BBNCMLHJDFE, GMILGDIHDLE KEEAPFDDBLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7B83440", Offset = "0x7B81C40", VA = "0x187B83440", Slot = "4")]
	[AsyncStateMachine(typeof(HBIELMADKLD))]
	public override Task<GBAGLFMEAKA> FIJDKNIDPMK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public readonly struct JGFAGIDHNBA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly DEBJHCGPJPF AOGPCNCLALO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly bool HLEFLIFOBLF;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7B82F00", Offset = "0x7B81700", VA = "0x187B82F00")]
	public JGFAGIDHNBA(DEBJHCGPJPF OKBCDAKOECL, bool BBNCMLHJDFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface BPGGJDLPCNB<TSpawnType> where TSpawnType : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> FIJDKNIDPMK(JGFAGIDHNBA GGHHHKCPKJL);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class NGDBOGOOOOF<TSpawnType> : PIHCJJPOKAH<BPGGJDLPCNB<TSpawnType>, TSpawnType> where TSpawnType : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct DGKLEJFGMEJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public AsyncTaskMethodBuilder<TSpawnType> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public NGDBOGOOOOF<TSpawnType> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private TaskAwaiter<TSpawnType> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x68D0E10", Offset = "0x68CF610", VA = "0x1868D0E10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x44398E0", Offset = "0x44380E0", VA = "0x1844398E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly JGFAGIDHNBA GGHHHKCPKJL;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x52FDF70", Offset = "0x52FC770", VA = "0x1852FDF70")]
	public NGDBOGOOOOF(DEBJHCGPJPF OKBCDAKOECL, bool BBNCMLHJDFE, BPGGJDLPCNB<TSpawnType> KEEAPFDDBLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x52FDE70", Offset = "0x52FC670", VA = "0x1852FDE70", Slot = "4")]
	[AsyncStateMachine(typeof(NGDBOGOOOOF<>.DGKLEJFGMEJ))]
	public override Task<TSpawnType> FIJDKNIDPMK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct DEBJHCGPJPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public readonly bool FKELGMFKHKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly Vector3 FEAICKLKFBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly Vector3 COFBFGOOFOF;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7B81E20", Offset = "0x7B80620", VA = "0x187B81E20")]
	public DEBJHCGPJPF(Transform IOJJMJHLNJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7B81E90", Offset = "0x7B80690", VA = "0x187B81E90")]
	public DEBJHCGPJPF(Vector3 GLANACDLEOF, Vector3 NCGKJMOKFAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7B81DF0", Offset = "0x7B805F0", VA = "0x187B81DF0")]
	public static DEBJHCGPJPF LMNLEEHCNJH()
	{
		return default(DEBJHCGPJPF);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7B81EC0", Offset = "0x7B806C0", VA = "0x187B81EC0")]
	private DEBJHCGPJPF(bool GBDMLNENLBB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct CPDBHODFNOG<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public TNode AOIKBJJJNKA;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x64E2CB0", Offset = "0x64E14B0", VA = "0x1864E2CB0")]
	public CPDBHODFNOG(TNode AOIKBJJJNKA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct GHENCBDAPEM<TNode, TReparentOperations> where TNode : notnull where TReparentOperations : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public TNode NOBOOEHMCFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public TReparentOperations DPEIIMPOCDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public JIBNCODMNHL FEDFPAIOLKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly bool HLEFLIFOBLF;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x4998810", Offset = "0x4997010", VA = "0x184998810")]
	public GHENCBDAPEM(TNode NOBOOEHMCFC, TReparentOperations DPEIIMPOCDC, JIBNCODMNHL FEDFPAIOLKJ, bool BBNCMLHJDFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface CHEIOIDHLLN<TNode, TReparentOperations>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CLEBBPGCIFP([In] CPDBHODFNOG<TNode> NEAENAGGDHN);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CMOHAIJMEPJ([In] GHENCBDAPEM<TNode, TReparentOperations> KLKJDJEOFNC);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KFMMPKJCLGA();
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class EBOIBMHDFHG<TNode, TReparentOperations> : DLEPKENPGJD<CHEIOIDHLLN<TNode, TReparentOperations>>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x43E20D0", Offset = "0x43E08D0", VA = "0x1843E20D0")]
	public EBOIBMHDFHG(CHEIOIDHLLN<TNode, TReparentOperations> KEEAPFDDBLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x43E2080", Offset = "0x43E0880", VA = "0x1843E2080", Slot = "4")]
	public override bool FIJDKNIDPMK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class AHFAEDBEIGF<TNode, TReparentOperations> : DLEPKENPGJD<CHEIOIDHLLN<TNode, TReparentOperations>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly GHENCBDAPEM<TNode, TReparentOperations> KLKJDJEOFNC;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x49E8DF0", Offset = "0x49E75F0", VA = "0x1849E8DF0")]
	public AHFAEDBEIGF(TNode NOBOOEHMCFC, TReparentOperations DPEIIMPOCDC, JIBNCODMNHL FEDFPAIOLKJ, CHEIOIDHLLN<TNode, TReparentOperations> KEEAPFDDBLD, bool BBNCMLHJDFE = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x48C6230", Offset = "0x48C4A30", VA = "0x1848C6230", Slot = "4")]
	public override bool FIJDKNIDPMK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class CADGPPLNCEC<TNode, TReparentOperations> : DLEPKENPGJD<CHEIOIDHLLN<TNode, TReparentOperations>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly CPDBHODFNOG<TNode> NEAENAGGDHN;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x63002B0", Offset = "0x62FEAB0", VA = "0x1863002B0")]
	public CADGPPLNCEC(TNode AKEJKDHNHKJ, CHEIOIDHLLN<TNode, TReparentOperations> KEEAPFDDBLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x43EB5E0", Offset = "0x43E9DE0", VA = "0x1843EB5E0", Slot = "4")]
	public override bool FIJDKNIDPMK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct GPPNGIKOHKL<TSpawnInfo> where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public TSpawnInfo LKMKALBGPMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public Vector3 NCGKJMOKFAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public Quaternion PMHMEKBKJJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public float EGLHBCAIJLF;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x49DE2D0", Offset = "0x49DCAD0", VA = "0x1849DE2D0")]
	public GPPNGIKOHKL(TSpawnInfo LKMKALBGPMM, Vector3 NCGKJMOKFAF, Quaternion PMHMEKBKJJA, float EGLHBCAIJLF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface IOHLBFINPOP<TSpawnType, TSpawnInfo>
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> FBHJHKCJJIJ([In] GPPNGIKOHKL<TSpawnInfo> HAIAFHIOJLP, CancellationToken DNHBNMHIDAC);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class OBNMKHMLECI<TSpawnType, TSpawnInfo> : PIHCJJPOKAH<IOHLBFINPOP<TSpawnType, TSpawnInfo>, TSpawnType> where TSpawnType : notnull where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly GPPNGIKOHKL<TSpawnInfo> FHMAIKMLNLH;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x545A3E0", Offset = "0x5458BE0", VA = "0x18545A3E0")]
	public OBNMKHMLECI(TSpawnInfo IODJDHHFDFI, Vector3 NCGKJMOKFAF, Quaternion PMHMEKBKJJA, float EGLHBCAIJLF, IOHLBFINPOP<TSpawnType, TSpawnInfo> KEEAPFDDBLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x52DCD80", Offset = "0x52DB580", VA = "0x1852DCD80", Slot = "4")]
	public override Task<TSpawnType> FIJDKNIDPMK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public readonly struct OECBACBIAIO<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly IEnumerable<TData> IBPJMGNOBOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly bool HLEFLIFOBLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly bool IBIPLPDGKDK;

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5466E10", Offset = "0x5465610", VA = "0x185466E10")]
	public OECBACBIAIO(IEnumerable<TData> LEHOHGGIOBE, bool BBNCMLHJDFE = false, bool NLNGGCFJHCE = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface ADILBIECMEI<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<GBAGLFMEAKA> DKNGGBLNMEK([In] OECBACBIAIO<TData> IKBJBCJNPOG, CancellationToken DNHBNMHIDAC);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class NCAJHBEAFEN<TData> : PIHCJJPOKAH<ADILBIECMEI<TData>, GBAGLFMEAKA> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly OECBACBIAIO<TData> KKDKCIIKDMO;

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x52DCF10", Offset = "0x52DB710", VA = "0x1852DCF10")]
	public NCAJHBEAFEN(IEnumerable<TData> LEHOHGGIOBE, bool BBNCMLHJDFE, ADILBIECMEI<TData> KEEAPFDDBLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x52DCD80", Offset = "0x52DB580", VA = "0x1852DCD80", Slot = "4")]
	public override Task<GBAGLFMEAKA> FIJDKNIDPMK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct KHCMLPPDJND<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly T ALLFIKNKLHM;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x4F05600", Offset = "0x4F03E00", VA = "0x184F05600")]
	public KHCMLPPDJND(T EGCOPCIOIHJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface DDEEMFFBIAD<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CLEBBPGCIFP([In] KHCMLPPDJND<T> PKIOENFMOKD);

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CMOHAIJMEPJ();
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface MEOLNBAMDAA<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FIJDKNIDPMK([In] CDDNNIFFPBN<T> ECEFJANCLMC);
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public struct CDDNNIFFPBN<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly T ALLFIKNKLHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly bool CDOEGOHGMAA;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x630C950", Offset = "0x630B150", VA = "0x18630C950")]
	public CDDNNIFFPBN(T EGCOPCIOIHJ, bool HOMBCGCLEFK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public class FOKKPLMFPJF<T> : DLEPKENPGJD<DDEEMFFBIAD<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x43E20D0", Offset = "0x43E08D0", VA = "0x1843E20D0")]
	public FOKKPLMFPJF(DDEEMFFBIAD<T> KEEAPFDDBLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x48E84A0", Offset = "0x48E6CA0", VA = "0x1848E84A0", Slot = "4")]
	public override bool FIJDKNIDPMK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class HIMEMOCFAKE<T> : DLEPKENPGJD<DDEEMFFBIAD<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly KHCMLPPDJND<T> PKIOENFMOKD;

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x4A55500", Offset = "0x4A53D00", VA = "0x184A55500")]
	public HIMEMOCFAKE(T ALLFIKNKLHM, DDEEMFFBIAD<T> KEEAPFDDBLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x43EB5E0", Offset = "0x43E9DE0", VA = "0x1843EB5E0", Slot = "4")]
	public override bool FIJDKNIDPMK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class MJPLBPFPMJA<T> : DLEPKENPGJD<MEOLNBAMDAA<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly CDDNNIFFPBN<T> ECEFJANCLMC;

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5213DF0", Offset = "0x52125F0", VA = "0x185213DF0")]
	public MJPLBPFPMJA(T ALLFIKNKLHM, bool HOMBCGCLEFK, MEOLNBAMDAA<T> KEEAPFDDBLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x43EB5E0", Offset = "0x43E9DE0", VA = "0x1843EB5E0", Slot = "4")]
	public override bool FIJDKNIDPMK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public struct IAJNIDGFOIK<TData> where TData : notnull, FPIEFBHPPHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public IEnumerable<TData> IBPJMGNOBOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public bool DMLOAFMDFNG;

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x4B50240", Offset = "0x4B4EA40", VA = "0x184B50240")]
	public IAJNIDGFOIK(IEnumerable<TData> KOAKIKFCIIH, bool BDHCGDBPPGM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public struct OOIPJMCHCNO<TData> where TData : notnull, FPIEFBHPPHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public List<TData> IBPJMGNOBOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public List<bool> NFPDBLPCNFJ;

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x548B460", Offset = "0x5489C60", VA = "0x18548B460")]
	public OOIPJMCHCNO(List<TData> KOAKIKFCIIH, List<bool> CDOLOLHHLPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface FPIEFBHPPHP
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool MGCBGDDMCMN
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
public interface LJNIHPGMMIJ<TData> where TData : FPIEFBHPPHP
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FIJDKNIDPMK([In] IAJNIDGFOIK<TData> BPHLBJAMMGC);

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FIJDKNIDPMK([In] OOIPJMCHCNO<TData> BPHLBJAMMGC);
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface DKGABFMMLNC<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DHMFGLGPLHH(T ALLFIKNKLHM);
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class KOANFABNFDI<TData> : DLEPKENPGJD<LJNIHPGMMIJ<TData>> where TData : notnull, FPIEFBHPPHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly IAJNIDGFOIK<TData> BPHLBJAMMGC;

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x4F40860", Offset = "0x4F3F060", VA = "0x184F40860")]
	public KOANFABNFDI(List<TData> LEHOHGGIOBE, bool DMLOAFMDFNG, LJNIHPGMMIJ<TData> KEEAPFDDBLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x43EB5E0", Offset = "0x43E9DE0", VA = "0x1843EB5E0", Slot = "4")]
	public override bool FIJDKNIDPMK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class PEAEFEEBLDB<TData> : DLEPKENPGJD<LJNIHPGMMIJ<TData>> where TData : notnull, FPIEFBHPPHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly OOIPJMCHCNO<TData> BPHLBJAMMGC;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x55508E0", Offset = "0x554F0E0", VA = "0x1855508E0")]
	public PEAEFEEBLDB(List<TData> LEHOHGGIOBE, List<bool> NFPDBLPCNFJ, LJNIHPGMMIJ<TData> KEEAPFDDBLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5300D80", Offset = "0x52FF580", VA = "0x185300D80", Slot = "4")]
	public override bool FIJDKNIDPMK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public interface OODDKFCFGLI<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<GBAGLFMEAKA> FIJDKNIDPMK(IDOAHPGEDKM<TData> JPPCJDJDKIB);
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public class HBGNBHHCMBF<TData> : PIHCJJPOKAH<OODDKFCFGLI<TData>, GBAGLFMEAKA> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private struct PPBKCPFDADP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public AsyncTaskMethodBuilder<GBAGLFMEAKA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public HBGNBHHCMBF<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private TaskAwaiter<GBAGLFMEAKA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x558C0B0", Offset = "0x558A8B0", VA = "0x18558C0B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x558C390", Offset = "0x558AB90", VA = "0x18558C390", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly IDOAHPGEDKM<TData> CDDCFFKDMIO;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4A2E9C0", Offset = "0x4A2D1C0", VA = "0x184A2E9C0")]
	public HBGNBHHCMBF(TData OIGKMBLGCGI, IReadOnlyList<TData> IDFNDFAGMIJ, bool BBNCMLHJDFE, OODDKFCFGLI<TData> KEEAPFDDBLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x4A2E8C0", Offset = "0x4A2D0C0", VA = "0x184A2E8C0", Slot = "4")]
	[AsyncStateMachine(typeof(HBGNBHHCMBF<>.PPBKCPFDADP))]
	public override Task<GBAGLFMEAKA> FIJDKNIDPMK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public struct IDOAHPGEDKM<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public TData GBKNOAPJMHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public IReadOnlyList<TData> JBHIIDJDPGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public bool HLEFLIFOBLF;

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2C466C0", Offset = "0x2C44EC0", VA = "0x182C466C0")]
	public IDOAHPGEDKM(TData OIGKMBLGCGI, IReadOnlyList<TData> IDFNDFAGMIJ, bool BBNCMLHJDFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface HEFCMJAFBEP<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FIJDKNIDPMK([In] GDPNBBCMEKF<TData> LELBHPCFAHC);
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public interface DAIBCJCBKAK<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FIJDKNIDPMK([In] CNCELFEPOHL<TData> LELBHPCFAHC);
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public interface JLJIHJPLEJP<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FNMCCHGPIKI([In] PIKLOBLDACN<TData> LELBHPCFAHC);

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CMOHAIJMEPJ();
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class DJKCNBHBJOO<TData> : DLEPKENPGJD<HEFCMJAFBEP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly GDPNBBCMEKF<TData> LELBHPCFAHC;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x68D69E0", Offset = "0x68D51E0", VA = "0x1868D69E0")]
	public DJKCNBHBJOO(IEnumerable<TData> LEHOHGGIOBE, CGKMKJEAANA AGNHOOELDII, KLEDGCGHKKL OALKCGACMLD, float FAIAGJPDHEJ, string? LJANIECHELJ, bool KHAPGJKIFPP, bool BBNCMLHJDFE, HEFCMJAFBEP<TData> KEEAPFDDBLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x43EB5E0", Offset = "0x43E9DE0", VA = "0x1843EB5E0", Slot = "4")]
	public override bool FIJDKNIDPMK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class POOAGHOCAEN<TData> : DLEPKENPGJD<DAIBCJCBKAK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly CNCELFEPOHL<TData> LELBHPCFAHC;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x558BFD0", Offset = "0x558A7D0", VA = "0x18558BFD0")]
	public POOAGHOCAEN(TData[] LEHOHGGIOBE, CGKMKJEAANA[] AGNHOOELDII, KLEDGCGHKKL[] OALKCGACMLD, float[] FAIAGJPDHEJ, DAIBCJCBKAK<TData> KEEAPFDDBLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x4D5B690", Offset = "0x4D59E90", VA = "0x184D5B690", Slot = "4")]
	public override bool FIJDKNIDPMK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class PKPPHKBBFAH<TData> : DLEPKENPGJD<JLJIHJPLEJP<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x43E20D0", Offset = "0x43E08D0", VA = "0x1843E20D0")]
	public PKPPHKBBFAH(JLJIHJPLEJP<TData> KEEAPFDDBLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5576070", Offset = "0x5574870", VA = "0x185576070", Slot = "4")]
	public override bool FIJDKNIDPMK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class JCLPEAJAFFF<TData> : DLEPKENPGJD<JLJIHJPLEJP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly PIKLOBLDACN<TData> LELBHPCFAHC;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x4D5B750", Offset = "0x4D59F50", VA = "0x184D5B750")]
	public JCLPEAJAFFF(IEnumerable<TData> LEHOHGGIOBE, CGKMKJEAANA AGNHOOELDII, KLEDGCGHKKL OALKCGACMLD, float FAIAGJPDHEJ, JLJIHJPLEJP<TData> KEEAPFDDBLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x4D5B690", Offset = "0x4D59E90", VA = "0x184D5B690", Slot = "4")]
	public override bool FIJDKNIDPMK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public struct GDPNBBCMEKF<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public IEnumerable<TData> IBPJMGNOBOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public CGKMKJEAANA GEHPAEKDJGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public KLEDGCGHKKL AHJGKHIHKBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public float FKJMKHIOOMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public string? GFJBHKHMHCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public bool? LEHGOPEDJPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public bool HLEFLIFOBLF;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x498A230", Offset = "0x4988A30", VA = "0x18498A230")]
	public GDPNBBCMEKF(IEnumerable<TData> LEHOHGGIOBE, CGKMKJEAANA AGNHOOELDII, KLEDGCGHKKL OALKCGACMLD, float FAIAGJPDHEJ, string? LJANIECHELJ, bool? KHAPGJKIFPP, bool BBNCMLHJDFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public struct CNCELFEPOHL<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public TData[] IBPJMGNOBOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public CGKMKJEAANA[] GEHPAEKDJGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public KLEDGCGHKKL[] AHJGKHIHKBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public float[] FAIAGJPDHEJ;

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x64DD5D0", Offset = "0x64DBDD0", VA = "0x1864DD5D0")]
	public CNCELFEPOHL(TData[] LEHOHGGIOBE, CGKMKJEAANA[] AGNHOOELDII, KLEDGCGHKKL[] OALKCGACMLD, float[] FAIAGJPDHEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public struct PIKLOBLDACN<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public IEnumerable<TData> IBPJMGNOBOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public CGKMKJEAANA GEHPAEKDJGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public KLEDGCGHKKL AHJGKHIHKBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public float FAIAGJPDHEJ;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x55600B0", Offset = "0x555E8B0", VA = "0x1855600B0")]
	public PIKLOBLDACN(IEnumerable<TData> LEHOHGGIOBE, CGKMKJEAANA AGNHOOELDII, KLEDGCGHKKL OALKCGACMLD, float FAIAGJPDHEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public interface IHNDBLKDMMN<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NDNONMDFPGN([In] NEPNLMGGNII<TData> IKBJBCJNPOG);

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NLNBFNBOGCJ([In] NEPNLMGGNII<TData> IKBJBCJNPOG);

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DFKBLMLMNFK([In] bool BGAJPDALLNP);

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool LPEPOPCMAIF([In] NEPNLMGGNII<TData> IKBJBCJNPOG);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ALKLCJFGFAJ();

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool CANLLIPKEHC([In] TData GOHGGEGJPCC);
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class OIHHLHDMBKG<TData> : DLEPKENPGJD<IHNDBLKDMMN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly NEPNLMGGNII<TData> IKBJBCJNPOG;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x5473970", Offset = "0x5472170", VA = "0x185473970")]
	public OIHHLHDMBKG(List<TData> ECFHLCJLIHE, IHNDBLKDMMN<TData> KEEAPFDDBLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x43EB5E0", Offset = "0x43E9DE0", VA = "0x1843EB5E0", Slot = "4")]
	public override bool FIJDKNIDPMK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class BACEIMMDLCP<TData> : DLEPKENPGJD<IHNDBLKDMMN<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x43E20D0", Offset = "0x43E08D0", VA = "0x1843E20D0")]
	public BACEIMMDLCP(IHNDBLKDMMN<TData> KEEAPFDDBLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x5D911F0", Offset = "0x5D8F9F0", VA = "0x185D911F0", Slot = "4")]
	public override bool FIJDKNIDPMK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class PAHHBCPEJCE<TData> : DLEPKENPGJD<IHNDBLKDMMN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly bool BBNCMLHJDFE;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x553D3D0", Offset = "0x553BBD0", VA = "0x18553D3D0")]
	public PAHHBCPEJCE(bool BBNCMLHJDFE, IHNDBLKDMMN<TData> KEEAPFDDBLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x553D370", Offset = "0x553BB70", VA = "0x18553D370", Slot = "4")]
	public override bool FIJDKNIDPMK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class NHBCDNPNHOD<TData> : DLEPKENPGJD<IHNDBLKDMMN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly NEPNLMGGNII<TData> IKBJBCJNPOG;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x5300EE0", Offset = "0x52FF6E0", VA = "0x185300EE0")]
	public NHBCDNPNHOD(List<TData> ECFHLCJLIHE, bool BBNCMLHJDFE, IHNDBLKDMMN<TData> KEEAPFDDBLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5300D80", Offset = "0x52FF580", VA = "0x185300D80", Slot = "4")]
	public override bool FIJDKNIDPMK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class EBKFHIJNNOK<TData> : DLEPKENPGJD<IHNDBLKDMMN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly TData GOHGGEGJPCC;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x43E06C0", Offset = "0x43DEEC0", VA = "0x1843E06C0")]
	public EBKFHIJNNOK(TData GOHGGEGJPCC, IHNDBLKDMMN<TData> KEEAPFDDBLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x43E0540", Offset = "0x43DED40", VA = "0x1843E0540", Slot = "4")]
	public override bool FIJDKNIDPMK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class EGEPKODLFBI<TData> : DLEPKENPGJD<IHNDBLKDMMN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly NEPNLMGGNII<TData> IKBJBCJNPOG;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x43F6910", Offset = "0x43F5110", VA = "0x1843F6910")]
	public EGEPKODLFBI(IEnumerable<TData> ECFHLCJLIHE, IHNDBLKDMMN<TData> KEEAPFDDBLD, bool BBNCMLHJDFE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x43F67A0", Offset = "0x43F4FA0", VA = "0x1843F67A0", Slot = "4")]
	public override bool FIJDKNIDPMK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public struct NEPNLMGGNII<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public IEnumerable<TData> IBPJMGNOBOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public bool BBNCMLHJDFE;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x52FC700", Offset = "0x52FAF00", VA = "0x1852FC700")]
	public NEPNLMGGNII(IEnumerable<TData> KOAKIKFCIIH, bool NFJFECDJGLB = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public interface JBMMCKJCHPF
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<GBAGLFMEAKA> FIJDKNIDPMK(ODOIJDAFDDL JCBIKEDECBB);
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class HOPOMAFHHBF : PIHCJJPOKAH<JBMMCKJCHPF, GBAGLFMEAKA>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private struct HABBFBCGFEE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public AsyncTaskMethodBuilder<GBAGLFMEAKA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public HOPOMAFHHBF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private TaskAwaiter<GBAGLFMEAKA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x7B82770", Offset = "0x7B80F70", VA = "0x187B82770", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7B829F0", Offset = "0x7B811F0", VA = "0x187B829F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly ODOIJDAFDDL CPBACEPIIFJ;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x7B82E60", Offset = "0x7B81660", VA = "0x187B82E60")]
	public HOPOMAFHHBF(bool BBNCMLHJDFE, JBMMCKJCHPF KEEAPFDDBLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x7B82D70", Offset = "0x7B81570", VA = "0x187B82D70", Slot = "4")]
	[AsyncStateMachine(typeof(HABBFBCGFEE))]
	public override Task<GBAGLFMEAKA> FIJDKNIDPMK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public struct ODOIJDAFDDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public bool HLEFLIFOBLF;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x2976410", Offset = "0x2974C10", VA = "0x182976410")]
	public ODOIJDAFDDL(bool BBNCMLHJDFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public readonly struct OKAEGEPAFJA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public readonly bool DOELHPFBHPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public readonly bool AJLOBDOHDJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public readonly bool EGLHBCAIJLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public readonly bool BBNCMLHJDFE;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5BBDBB0", Offset = "0x5BBC3B0", VA = "0x185BBDBB0")]
	public OKAEGEPAFJA(bool DOELHPFBHPP, bool AJLOBDOHDJI, bool EGLHBCAIJLF, bool BBNCMLHJDFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7B835B0", Offset = "0x7B81DB0", VA = "0x187B835B0")]
	public OKAEGEPAFJA(bool AJLOBDOHDJI, bool BBNCMLHJDFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public interface KHIMDJCKKBP
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FJMLFELCDEI(OKAEGEPAFJA ANFHJJKKFNM);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JGFLGDFOALG(OKAEGEPAFJA ANFHJJKKFNM);
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class COGMEKBFCIB : DLEPKENPGJD<KHIMDJCKKBP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly OKAEGEPAFJA ANFHJJKKFNM;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7B81D60", Offset = "0x7B80560", VA = "0x187B81D60")]
	public COGMEKBFCIB(bool POFBAOBKAGL, bool AJLOBDOHDJI, bool EGLHBCAIJLF, bool BBNCMLHJDFE, KHIMDJCKKBP KEEAPFDDBLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x7B81D10", Offset = "0x7B80510", VA = "0x187B81D10", Slot = "4")]
	public override bool FIJDKNIDPMK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public class EJBHMABBLOB : DLEPKENPGJD<KHIMDJCKKBP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private readonly OKAEGEPAFJA ANFHJJKKFNM;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7B82540", Offset = "0x7B80D40", VA = "0x187B82540")]
	public EJBHMABBLOB(bool AJLOBDOHDJI, bool BBNCMLHJDFE, KHIMDJCKKBP KEEAPFDDBLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x7B824F0", Offset = "0x7B80CF0", VA = "0x187B824F0", Slot = "4")]
	public override bool FIJDKNIDPMK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public interface PPABNPGJMME
{
	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FIJDKNIDPMK([In] NIAOIBNEGHM OFGBJANMKAO);
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class DHBEBKKLKNL : DLEPKENPGJD<PPABNPGJMME>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private readonly NIAOIBNEGHM OFGBJANMKAO;

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x7B822F0", Offset = "0x7B80AF0", VA = "0x187B822F0")]
	public DHBEBKKLKNL(Guid[] GALEJKACMBA, Vector3[] DKGIBCAMBPD, Quaternion[] KOHBNBLEDJG, float[] JBGKKDPIJFN, Dictionary<Guid, Vector3> IMDCBGJLOMJ, PPABNPGJMME KEEAPFDDBLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7B82240", Offset = "0x7B80A40", VA = "0x187B82240", Slot = "4")]
	public override bool FIJDKNIDPMK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public interface FNCLCPKDFFH<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CLEBBPGCIFP([In] KADKNCKIMAI<TData> NEAENAGGDHN);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FNMCCHGPIKI([In] EBELGENCCBB JJPJOFGFFOH);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FNMCCHGPIKI([In] CJJEDDPCEEH JJPJOFGFFOH);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CMOHAIJMEPJ();
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class AMJAKPELIMC<TData> : DLEPKENPGJD<FNCLCPKDFFH<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x43E20D0", Offset = "0x43E08D0", VA = "0x1843E20D0")]
	public AMJAKPELIMC(FNCLCPKDFFH<TData> KEEAPFDDBLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x49F6910", Offset = "0x49F5110", VA = "0x1849F6910", Slot = "4")]
	public override bool FIJDKNIDPMK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class AHOLMHIGEHP<TData> : DLEPKENPGJD<FNCLCPKDFFH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly EBELGENCCBB AALMHCCNDBC;

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x49E96F0", Offset = "0x49E7EF0", VA = "0x1849E96F0")]
	public AHOLMHIGEHP(Vector3 BGAKCOIKIDA, bool FAOCOKDLBID, FNCLCPKDFFH<TData> KEEAPFDDBLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x49E9690", Offset = "0x49E7E90", VA = "0x1849E9690", Slot = "4")]
	public override bool FIJDKNIDPMK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class LJLLDMLJJGN<TData> : DLEPKENPGJD<FNCLCPKDFFH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly CJJEDDPCEEH AALMHCCNDBC;

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x4FE3570", Offset = "0x4FE1D70", VA = "0x184FE3570")]
	public LJLLDMLJJGN(Guid JJIADHMBCIG, int FPEOONOJHML, Vector3 NCGKJMOKFAF, Quaternion PMHMEKBKJJA, float BCDEDKPOOJB, bool FAOCOKDLBID, FNCLCPKDFFH<TData> KEEAPFDDBLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x4FE3510", Offset = "0x4FE1D10", VA = "0x184FE3510", Slot = "4")]
	public override bool FIJDKNIDPMK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public class MAENCJOJIGG<TData> : DLEPKENPGJD<FNCLCPKDFFH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly KADKNCKIMAI<TData> AALMHCCNDBC;

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x51E9160", Offset = "0x51E7960", VA = "0x1851E9160")]
	public MAENCJOJIGG(TData ALLFIKNKLHM, bool BBNCMLHJDFE, FNCLCPKDFFH<TData> KEEAPFDDBLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x43EB5E0", Offset = "0x43E9DE0", VA = "0x1843EB5E0", Slot = "4")]
	public override bool FIJDKNIDPMK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct EBELGENCCBB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public readonly Vector3 BGAKCOIKIDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public readonly bool FAOCOKDLBID;

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7B824D0", Offset = "0x7B80CD0", VA = "0x187B824D0")]
	public EBELGENCCBB(Vector3 BGAKCOIKIDA, bool FAOCOKDLBID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct CJJEDDPCEEH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public readonly Guid JJIADHMBCIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public readonly int FPEOONOJHML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public readonly Vector3 NCGKJMOKFAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public readonly Quaternion PMHMEKBKJJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public readonly float BCDEDKPOOJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public readonly bool FAOCOKDLBID;

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7B81CD0", Offset = "0x7B804D0", VA = "0x187B81CD0")]
	public CJJEDDPCEEH(Guid JJIADHMBCIG, int FPEOONOJHML, Vector3 NCGKJMOKFAF, Quaternion PMHMEKBKJJA, float BCDEDKPOOJB, bool FAOCOKDLBID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct KADKNCKIMAI<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public readonly TData ALLFIKNKLHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public readonly bool BBNCMLHJDFE;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x4EE9670", Offset = "0x4EE7E70", VA = "0x184EE9670")]
	public KADKNCKIMAI(TData ALLFIKNKLHM, bool BBNCMLHJDFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public interface LNCJKONOKPP<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FIJDKNIDPMK([In] NALBHOPNJHP<TData> PHLFFBLEFOA);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FIJDKNIDPMK([In] MLKGBNBFHGH<TData> PHLFFBLEFOA);
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public interface EBDEFOAOFGL<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CLEBBPGCIFP([In] OGMPAHHJONJ<TData> DCHIIHMHAFH);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FNMCCHGPIKI([In] CLKICCIEBFG JJPJOFGFFOH);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CMOHAIJMEPJ();
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public class AAGOHAFBFOB<TData> : DLEPKENPGJD<LNCJKONOKPP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly NALBHOPNJHP<TData> PHLFFBLEFOA;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x495A8E0", Offset = "0x49590E0", VA = "0x18495A8E0")]
	public AAGOHAFBFOB(IEnumerable<TData> LEHOHGGIOBE, Vector3 JLEOMMKHIKK, bool BBNCMLHJDFE, LNCJKONOKPP<TData> KEEAPFDDBLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x43EB5E0", Offset = "0x43E9DE0", VA = "0x1843EB5E0", Slot = "4")]
	public override bool FIJDKNIDPMK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class CDNFLJPPKLB<TData> : DLEPKENPGJD<EBDEFOAOFGL<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x43E20D0", Offset = "0x43E08D0", VA = "0x1843E20D0")]
	public CDNFLJPPKLB(EBDEFOAOFGL<TData> KEEAPFDDBLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x43E2080", Offset = "0x43E0880", VA = "0x1843E2080", Slot = "4")]
	public override bool FIJDKNIDPMK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public class MIIMHFHHPDP<TData> : DLEPKENPGJD<EBDEFOAOFGL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly OGMPAHHJONJ<TData> PHLFFBLEFOA;

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x520D2C0", Offset = "0x520BAC0", VA = "0x18520D2C0")]
	public MIIMHFHHPDP(IEnumerable<TData> LEHOHGGIOBE, bool BBNCMLHJDFE, EBDEFOAOFGL<TData> KEEAPFDDBLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x43EB5E0", Offset = "0x43E9DE0", VA = "0x1843EB5E0", Slot = "4")]
	public override bool FIJDKNIDPMK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public class FHDOJPFFGIA<TData> : DLEPKENPGJD<LNCJKONOKPP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly MLKGBNBFHGH<TData> PHLFFBLEFOA;

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x48C62F0", Offset = "0x48C4AF0", VA = "0x1848C62F0")]
	public FHDOJPFFGIA(IEnumerable<TData> LEHOHGGIOBE, Vector3 EMMDMJEDLCH, FICEGAJEHEA MHNOCHKNLAE, bool BBNCMLHJDFE, LNCJKONOKPP<TData> KEEAPFDDBLD, Space AFJHDCHPHDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x48C6230", Offset = "0x48C4A30", VA = "0x1848C6230", Slot = "4")]
	public override bool FIJDKNIDPMK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class DKAPDPAGGBE<TData> : DLEPKENPGJD<EBDEFOAOFGL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly CLKICCIEBFG PHLFFBLEFOA;

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x68DC990", Offset = "0x68DB190", VA = "0x1868DC990")]
	public DKAPDPAGGBE(Vector3 JLEOMMKHIKK, EBDEFOAOFGL<TData> KEEAPFDDBLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x49E9690", Offset = "0x49E7E90", VA = "0x1849E9690", Slot = "4")]
	public override bool FIJDKNIDPMK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public struct NALBHOPNJHP<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public readonly IEnumerable<TData> LEHOHGGIOBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public readonly Vector3 JLEOMMKHIKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly bool BBNCMLHJDFE;

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x52D87B0", Offset = "0x52D6FB0", VA = "0x1852D87B0")]
	public NALBHOPNJHP(IEnumerable<TData> LEHOHGGIOBE, Vector3 JLEOMMKHIKK, bool BBNCMLHJDFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct OGMPAHHJONJ<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public readonly IEnumerable<TData> LEHOHGGIOBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public readonly bool BBNCMLHJDFE;

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x5472260", Offset = "0x5470A60", VA = "0x185472260")]
	public OGMPAHHJONJ(IEnumerable<TData> LEHOHGGIOBE, bool BBNCMLHJDFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public struct MLKGBNBFHGH<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public readonly IEnumerable<TData> LEHOHGGIOBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public readonly Vector3 EMMDMJEDLCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public readonly FICEGAJEHEA MHNOCHKNLAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public readonly bool BBNCMLHJDFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public readonly Space AFJHDCHPHDA;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x52939A0", Offset = "0x52921A0", VA = "0x1852939A0")]
	public MLKGBNBFHGH(IEnumerable<TData> LEHOHGGIOBE, Vector3 EMMDMJEDLCH, FICEGAJEHEA MHNOCHKNLAE, bool BBNCMLHJDFE, Space AFJHDCHPHDA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public struct CLKICCIEBFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public readonly Vector3 JLEOMMKHIKK;

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0xE9C410", Offset = "0xE9AC10", VA = "0x180E9C410")]
	public CLKICCIEBFG(Vector3 JLEOMMKHIKK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public enum FICEGAJEHEA
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
public interface NIGGOELFEAD
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FIJDKNIDPMK([In] DBPJAPFKCMM ILMCPBOAAHP);
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public class CDEDPEDPKJA : DLEPKENPGJD<NIGGOELFEAD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly DBPJAPFKCMM ILMCPBOAAHP;

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x7B81C70", Offset = "0x7B80470", VA = "0x187B81C70")]
	public CDEDPEDPKJA(bool BBNCMLHJDFE, NIGGOELFEAD KEEAPFDDBLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x7B81BC0", Offset = "0x7B803C0", VA = "0x187B81BC0", Slot = "4")]
	public override bool FIJDKNIDPMK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public readonly struct DBPJAPFKCMM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public readonly bool BBNCMLHJDFE;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x2976410", Offset = "0x2974C10", VA = "0x182976410")]
	public DBPJAPFKCMM(bool BBNCMLHJDFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public interface GEAFLOMDMHH<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FIJDKNIDPMK([In] PKENDOKKHAP<TData> CEPBMBOIHKF);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FIJDKNIDPMK([In] AJFJEAHCDGD<TData> CEPBMBOIHKF);
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public interface KFDCIGCHFGF<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CLEBBPGCIFP([In] LDLHGECJLOA<TData> NEAENAGGDHN);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FNMCCHGPIKI([In] EBHIAHCJGHE JJPJOFGFFOH);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CMOHAIJMEPJ();
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public class CIKBIGIFGKK<TData> : DLEPKENPGJD<GEAFLOMDMHH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly PKENDOKKHAP<TData> CEPBMBOIHKF;

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x63F3380", Offset = "0x63F1B80", VA = "0x1863F3380")]
	public CIKBIGIFGKK(IEnumerable<TData> LEHOHGGIOBE, Quaternion JLEOMMKHIKK, Vector3? BDBEFCOIHBG, bool HDIAOJMPCMP, bool BBNCMLHJDFE, GEAFLOMDMHH<TData> KEEAPFDDBLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x43EB5E0", Offset = "0x43E9DE0", VA = "0x1843EB5E0", Slot = "4")]
	public override bool FIJDKNIDPMK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class DBAFDCLHEBC<TData> : DLEPKENPGJD<KFDCIGCHFGF<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x43E20D0", Offset = "0x43E08D0", VA = "0x1843E20D0")]
	public DBAFDCLHEBC(KFDCIGCHFGF<TData> KEEAPFDDBLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x43E2080", Offset = "0x43E0880", VA = "0x1843E2080", Slot = "4")]
	public override bool FIJDKNIDPMK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class DCEMBBLFCIM<TData> : DLEPKENPGJD<KFDCIGCHFGF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly LDLHGECJLOA<TData> CEPBMBOIHKF;

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x68BB670", Offset = "0x68B9E70", VA = "0x1868BB670")]
	public DCEMBBLFCIM(IEnumerable<TData> LEHOHGGIOBE, bool BBNCMLHJDFE, KFDCIGCHFGF<TData> KEEAPFDDBLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x43EB5E0", Offset = "0x43E9DE0", VA = "0x1843EB5E0", Slot = "4")]
	public override bool FIJDKNIDPMK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class OLOEKOBDJNJ<TData> : DLEPKENPGJD<GEAFLOMDMHH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly AJFJEAHCDGD<TData> CEPBMBOIHKF;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x547BB90", Offset = "0x547A390", VA = "0x18547BB90")]
	public OLOEKOBDJNJ(IEnumerable<TData> LEHOHGGIOBE, Quaternion OHFFPKACAED, FICEGAJEHEA CBMKMGDKEOF, Vector3? BDBEFCOIHBG, bool HDIAOJMPCMP, bool BBNCMLHJDFE, Space AFJHDCHPHDA, GEAFLOMDMHH<TData> KEEAPFDDBLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x48C6230", Offset = "0x48C4A30", VA = "0x1848C6230", Slot = "4")]
	public override bool FIJDKNIDPMK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public class HAHFAJGOHCB<TData> : DLEPKENPGJD<KFDCIGCHFGF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private readonly EBHIAHCJGHE CEPBMBOIHKF;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x4A29F10", Offset = "0x4A28710", VA = "0x184A29F10")]
	public HAHFAJGOHCB(Quaternion JLEOMMKHIKK, Vector3? BDBEFCOIHBG, bool HDIAOJMPCMP, KFDCIGCHFGF<TData> KEEAPFDDBLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x49E9690", Offset = "0x49E7E90", VA = "0x1849E9690", Slot = "4")]
	public override bool FIJDKNIDPMK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public struct PKENDOKKHAP<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public readonly IEnumerable<TData> LEHOHGGIOBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public readonly Quaternion JLEOMMKHIKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public readonly Vector3? BDBEFCOIHBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public readonly bool HDIAOJMPCMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public readonly bool BBNCMLHJDFE;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x5574350", Offset = "0x5572B50", VA = "0x185574350")]
	public PKENDOKKHAP(IEnumerable<TData> LEHOHGGIOBE, Quaternion JLEOMMKHIKK, Vector3? BDBEFCOIHBG, bool HDIAOJMPCMP, bool BBNCMLHJDFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct LDLHGECJLOA<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public readonly IEnumerable<TData> LEHOHGGIOBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public readonly bool BBNCMLHJDFE;

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x4FDB520", Offset = "0x4FD9D20", VA = "0x184FDB520")]
	public LDLHGECJLOA(IEnumerable<TData> LEHOHGGIOBE, bool BBNCMLHJDFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public struct AJFJEAHCDGD<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public readonly IEnumerable<TData> LEHOHGGIOBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public readonly Quaternion OHFFPKACAED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public readonly FICEGAJEHEA CBMKMGDKEOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public readonly Vector3? BDBEFCOIHBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public readonly bool HDIAOJMPCMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public readonly bool BBNCMLHJDFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public readonly Space AFJHDCHPHDA;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x49EC790", Offset = "0x49EAF90", VA = "0x1849EC790")]
	public AJFJEAHCDGD(IEnumerable<TData> LEHOHGGIOBE, Quaternion OHFFPKACAED, FICEGAJEHEA CBMKMGDKEOF, Vector3? BDBEFCOIHBG, bool HDIAOJMPCMP, bool BBNCMLHJDFE, Space AFJHDCHPHDA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct EBHIAHCJGHE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly Quaternion JLEOMMKHIKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public readonly Vector3? BDBEFCOIHBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly bool HDIAOJMPCMP;

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x5B7B6D0", Offset = "0x5B79ED0", VA = "0x185B7B6D0")]
	public EBHIAHCJGHE(Quaternion JLEOMMKHIKK, Vector3? BDBEFCOIHBG, bool HDIAOJMPCMP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public interface FLOPBIFKBNC<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CLEBBPGCIFP([In] DDNFHMEEFEA<TData> NEAENAGGDHN);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FNMCCHGPIKI([In] HCAAIHMKGGA JJPJOFGFFOH);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FNMCCHGPIKI([In] AJIBPIMAMHG JJPJOFGFFOH);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool FNMCCHGPIKI([In] IMJKKKICEGB JJPJOFGFFOH);

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool CMOHAIJMEPJ();
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public class DHPNKJIDMEH<TData> : DLEPKENPGJD<FLOPBIFKBNC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private readonly IMJKKKICEGB BLJMBBPBMLC;

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x68D4610", Offset = "0x68D2E10", VA = "0x1868D4610")]
	public DHPNKJIDMEH(Vector3 EMKOBPLNDIN, float PPDPODCGICD, Vector3 BDBEFCOIHBG, bool GGFMGODOHKH, bool ICAPKMNNJBP, FLOPBIFKBNC<TData> KEEAPFDDBLD, Space AFJHDCHPHDA = Space.Self)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x68D45B0", Offset = "0x68D2DB0", VA = "0x1868D45B0", Slot = "4")]
	public override bool FIJDKNIDPMK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public class LAOGLMAHKGJ<TData> : DLEPKENPGJD<FLOPBIFKBNC<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x43E20D0", Offset = "0x43E08D0", VA = "0x1843E20D0")]
	public LAOGLMAHKGJ(FLOPBIFKBNC<TData> KEEAPFDDBLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x4FC7680", Offset = "0x4FC5E80", VA = "0x184FC7680", Slot = "4")]
	public override bool FIJDKNIDPMK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public class EEJMLFHLAKE<TData> : DLEPKENPGJD<FLOPBIFKBNC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private readonly DDNFHMEEFEA<TData> BLJMBBPBMLC;

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x43EB6A0", Offset = "0x43E9EA0", VA = "0x1843EB6A0")]
	public EEJMLFHLAKE(IEnumerable<TData> LEHOHGGIOBE, bool BBNCMLHJDFE, FLOPBIFKBNC<TData> KEEAPFDDBLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x43EB5E0", Offset = "0x43E9DE0", VA = "0x1843EB5E0", Slot = "4")]
	public override bool FIJDKNIDPMK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public class CEFANJLECEJ<TData> : DLEPKENPGJD<FLOPBIFKBNC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private readonly AJIBPIMAMHG BLJMBBPBMLC;

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x630DB40", Offset = "0x630C340", VA = "0x18630DB40")]
	public CEFANJLECEJ(float OLKKJMACELJ, bool JMIGGMPOEKJ, Vector3 BDBEFCOIHBG, FLOPBIFKBNC<TData> KEEAPFDDBLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x630DA80", Offset = "0x630C280", VA = "0x18630DA80", Slot = "4")]
	public override bool FIJDKNIDPMK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public class BFKPBIIIBOM<TData> : DLEPKENPGJD<FLOPBIFKBNC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private readonly HCAAIHMKGGA BLJMBBPBMLC;

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x5E24860", Offset = "0x5E23060", VA = "0x185E24860")]
	public BFKPBIIIBOM(float PPDPODCGICD, Vector3 BDBEFCOIHBG, FLOPBIFKBNC<TData> KEEAPFDDBLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x49E9690", Offset = "0x49E7E90", VA = "0x1849E9690", Slot = "4")]
	public override bool FIJDKNIDPMK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public struct IMJKKKICEGB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public readonly Vector3 EMKOBPLNDIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public readonly float PPDPODCGICD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public readonly Vector3 BDBEFCOIHBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public readonly bool FAOCOKDLBID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public readonly Space AFJHDCHPHDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public readonly bool ICAPKMNNJBP;

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x7B82EC0", Offset = "0x7B816C0", VA = "0x187B82EC0")]
	public IMJKKKICEGB(Vector3 EMKOBPLNDIN, float PPDPODCGICD, Vector3 BDBEFCOIHBG, bool FAOCOKDLBID, bool GOJIEDMDBDK, Space AFJHDCHPHDA = Space.Self)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public struct DDNFHMEEFEA<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public readonly IEnumerable<TData> LEHOHGGIOBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public readonly bool BBNCMLHJDFE;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x68C3530", Offset = "0x68C1D30", VA = "0x1868C3530")]
	public DDNFHMEEFEA(IEnumerable<TData> LEHOHGGIOBE, bool BBNCMLHJDFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public struct AJIBPIMAMHG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public readonly float OLKKJMACELJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public readonly bool JMIGGMPOEKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public readonly Vector3 BDBEFCOIHBG;

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x7B815C0", Offset = "0x7B7FDC0", VA = "0x187B815C0")]
	public AJIBPIMAMHG(float OLKKJMACELJ, bool JMIGGMPOEKJ, Vector3 BDBEFCOIHBG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public struct HCAAIHMKGGA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public readonly float PPDPODCGICD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public readonly Vector3 BDBEFCOIHBG;

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x5B3E930", Offset = "0x5B3D130", VA = "0x185B3E930")]
	public HCAAIHMKGGA(float PPDPODCGICD, Vector3 BDBEFCOIHBG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public struct NIAOIBNEGHM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public readonly Guid[] LEHOHGGIOBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public readonly bool BDJMEOFFJDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public readonly bool OCFJIAPDENA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public readonly bool PBHHHJNBGIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public readonly Vector3[] DKGIBCAMBPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public readonly Quaternion[] KOHBNBLEDJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public readonly float[] JBGKKDPIJFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public readonly Dictionary<Guid, Vector3> IMDCBGJLOMJ;

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x7B83130", Offset = "0x7B81930", VA = "0x187B83130")]
	public NIAOIBNEGHM(Guid[] GALEJKACMBA, Vector3[] DKGIBCAMBPD, Quaternion[] KOHBNBLEDJG, float[] JBGKKDPIJFN, Dictionary<Guid, Vector3> IMDCBGJLOMJ, bool BDJMEOFFJDD = true, bool OCFJIAPDENA = true, bool PBHHHJNBGIF = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7B82F60", Offset = "0x7B81760", VA = "0x187B82F60")]
	private static void NBNEGCOEODF(Dictionary<Guid, Vector3> IMDCBGJLOMJ, int AMNAMGKDDIL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public static class AKPPNIPDLIJ
{
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	private struct PAEBLGIIEJB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public bool PABKHGDMMPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public HHDGAAFLDEF LGKEMEBACIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public HHDGAAFLDEF JFHBJGCDFGE;
	}

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static PAEBLGIIEJB ICHEFELFNMO;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static CancellationToken AKDFEJKGFPO
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x7B81680", Offset = "0x7B7FE80", VA = "0x187B81680")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	internal static HHDGAAFLDEF LGKEMEBACIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x7B815E0", Offset = "0x7B7FDE0", VA = "0x187B815E0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x7B816F0", Offset = "0x7B7FEF0", VA = "0x187B816F0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x7B81750", Offset = "0x7B7FF50", VA = "0x187B81750")]
	[PJMOOJOMMCC.JJBJMJNFHOJ]
	internal static void OHIEJCAALDD(HHDGAAFLDEF HDGLKNGDLDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x7B81840", Offset = "0x7B80040", VA = "0x187B81840")]
	public static void OMPDHJNPJPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x7B816A0", Offset = "0x7B7FEA0", VA = "0x187B816A0")]
	private static HHDGAAFLDEF KBBLBFEMLFL(HHDGAAFLDEF BDBANPDIJIA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public static class GBOAOFHCKIB
{
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	public enum BFILBKBMAAN
	{
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		ICreationContextObject,
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		Guid
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x3793DF0", Offset = "0x37925F0", VA = "0x183793DF0")]
	public static void MBKFFKHFMKN<T>(T CHKHGNKGCIE, BFILBKBMAAN PIJHKCJDAHO) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3793D80", Offset = "0x3792580", VA = "0x183793D80")]
	public static void MBKFFKHFMKN<T>(T CHKHGNKGCIE) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x3793C90", Offset = "0x3792490", VA = "0x183793C90")]
	public static void MBKFFKHFMKN<T, TImpl, T>() where T : class where TImpl : notnull, T where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x3793F50", Offset = "0x3792750", VA = "0x183793F50")]
	public static void MLNMBDGNHKN<T>(T CHKHGNKGCIE) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x3793B30", Offset = "0x3792330", VA = "0x183793B30")]
	public static T EFPADONOPCC<T>(BFILBKBMAAN PIJHKCJDAHO) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x3794000", Offset = "0x3792800", VA = "0x183794000")]
	public static bool MMIGFMCEJDL<T>(BFILBKBMAAN PIJHKCJDAHO, T? JEMLHACHFID, [Out][MaybeNullWhen(false)][NotNullWhen(true)] T LPGKGMNDCPD) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x3794210", Offset = "0x3792A10", VA = "0x183794210")]
	public static bool NOJOFAOIEMO<T>(BFILBKBMAAN PIJHKCJDAHO, [Out][NotNullWhen(true)][MaybeNullWhen(false)] T PHPGFBPGAEL) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x3793BE0", Offset = "0x37923E0", VA = "0x183793BE0")]
	public static bool IHKDDKJIHGH<T>(BFILBKBMAAN PIJHKCJDAHO) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x3793AD0", Offset = "0x37922D0", VA = "0x183793AD0")]
	public static T EFPADONOPCC<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x3794150", Offset = "0x3792950", VA = "0x183794150")]
	public static bool MMIGFMCEJDL<T>(T JEMLHACHFID, [Out] T LPGKGMNDCPD) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x3793AD0", Offset = "0x37922D0", VA = "0x183793AD0")]
	public static bool IHKDDKJIHGH<T>() where T : class
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
internal static class BDOACDMNFCI
{
	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x7B81990", Offset = "0x7B80190", VA = "0x187B81990")]
	public static void DOGDJALACEO(IEnumerable CBKJNGNCPGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x34FFF50", Offset = "0x34FE750", VA = "0x1834FFF50")]
	public static void DOGDJALACEO<T>(T[] CPIDEKBKOPO) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x3500040", Offset = "0x34FE840", VA = "0x183500040")]
	public static void DOGDJALACEO<T>(T IPCBOKHNPCP) where T : notnull, Enum
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
