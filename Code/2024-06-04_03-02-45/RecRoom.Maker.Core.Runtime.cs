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
		[Cpp2IlInjected.Address(RVA = "0x86CBD0", Offset = "0x86B3D0", VA = "0x18086CBD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x68944B0", Offset = "0x6892CB0", VA = "0x1868944B0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x86D840", Offset = "0x86C040", VA = "0x18086D840")]
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
		[Cpp2IlInjected.Address(RVA = "0x86D880", Offset = "0x86C080", VA = "0x18086D880")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface FGDFIANECME<TData, TReturn>
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TReturn OKFAOMDANMD(TData GHDJADLHPAA);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface PGCCIGKJMCN<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ClearHoverTarget(HACEHNIFENN JAJMJIBDMBC);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool SetHoverTarget(TData LFFBLPMMGND, Collider CKOEKELFNIE, HACEHNIFENN JAJMJIBDMBC, [Optional] NIICFFIKABB? BLONINGLEBE);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool TryGetHoverTarget([Out] TData LFFBLPMMGND);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetHoverCollider([Out] Collider CKOEKELFNIE);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface FCEDGCMOODD<TData> : MCMPCFFKPGH, AEKKHDGMIEK<TData>, AOONGAODABF<TData>, ALFCPCBOMOJ<TData>, KOBLAHBLHEC, BFEOGAEAFAP<TData>, MECBGNFBODD, LIFJLPFNFLH
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface BFEOGAEAFAP<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 KAIFHAHFLAN, Vector3 NHPNENOFEDP, float NGOKPHBDKPG, [Out] T KIMDJPOBPHI, [Out] Vector3 ALIALHPGCEM, [Out] Collider CKOEKELFNIE);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 KAIFHAHFLAN, Vector3 NHPNENOFEDP, float ABCHMOADNHD, float NGOKPHBDKPG, T[] DLKBMFLBANI, [Out] Vector3 FOFFOJLIILH, [Out] Collider EJEKMAOKFJM);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 KAIFHAHFLAN, float ABCHMOADNHD, Vector3 DKMEHLLEIFK, T[] DLKBMFLBANI);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetObjectFromColliderInCurrentScope(Collider NEBJBGFEICB, [Out] T LPHLDIMEMNN);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface MCMPCFFKPGH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Bounds MDHKJMKPHDA
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Transform JGJLGGHKBBC
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Bounds EOOKCODCOBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Transform EBKEABBHGIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Vector3 HMHCEPIGLOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool NOCDNAIMNMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void SetSelectionBoundsDirty(bool LPCIIMKEDED = true, int JGEOPCMIKBE = 0);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ShouldHideSelectionBoundsPreview(bool CNHEKNEPPPH, object OECMOOGGOOF);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface LIFJLPFNFLH
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	LFHDLKLNBFG HDEIKAHOKBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface FFBMOCBLKMO
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool HPCJGPIIFOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool EGGLDEMEPDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool KHFDGPGONIL
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
	void TrySetPreviousCloneMapping(Dictionary<Guid, Guid> GHIAAOOGKGP);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface ALFCPCBOMOJ<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool DDBDAIDLAIA
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int KJFBMOAAEFG
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<TData> PNANOJGNHKE
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData ECMCDEIDGLC);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData ECMCDEIDGLC);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface AEKKHDGMIEK<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T GHDJADLHPAA, [Optional] NIICFFIKABB? DCBFCIHPHNB, bool BMMGDGGDDDF = true);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int POAAACAIHKJ, IEnumerable<T> NAJDJIPOFCB, bool BMMGDGGDDDF = true);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int POAAACAIHKJ, IEnumerable<T> NAJDJIPOFCB, NIICFFIKABB DCBFCIHPHNB, bool BMMGDGGDDDF = true);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface MECBGNFBODD
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface KOBLAHBLHEC
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool JNCGFFDAPHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool NPCCDCOPPNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool MAKDBNIHBCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool GGDOOKPNPAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class EKNADKGBHNG<TReceiver> : CKJLPFLMGKP<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3744F50", Offset = "0x3743750", VA = "0x183744F50")]
	public EKNADKGBHNG(TReceiver GALEHIKOJBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class LBGGPGBLCOB<TReceiver, TFromTask> : CKJLPFLMGKP<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3744F50", Offset = "0x3743750", VA = "0x183744F50")]
	public LBGGPGBLCOB(TReceiver GALEHIKOJBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public abstract class CKJLPFLMGKP<TReceiver, TFromExecute> where TReceiver : notnull where TFromExecute : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	protected TReceiver GALEHIKOJBA;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x50719C0", Offset = "0x50701C0", VA = "0x1850719C0")]
	public CKJLPFLMGKP(TReceiver GALEHIKOJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute HHNAPLDDAPJ();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public abstract class CGANPCJGPCC<TReceiver, TResult> : CKJLPFLMGKP<TReceiver, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3744F50", Offset = "0x3743750", VA = "0x183744F50")]
	public CGANPCJGPCC(TReceiver GALEHIKOJBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct HCADFGPDAPA<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public TGroup NAIDAFIEHMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public TData MHMDPDJBONN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public IEnumerable<TData> KELHBNFOLEN;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1E23030", Offset = "0x1E21830", VA = "0x181E23030")]
	public HCADFGPDAPA(TGroup EGEDLIFLLBA, TData FIFOGEFOMBN, IEnumerable<TData> FABGOIAPOJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct NHFGHFKAHLK<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public TGroup NAIDAFIEHMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public IEnumerable<TData> KELHBNFOLEN;

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0xA648B0", Offset = "0xA630B0", VA = "0x180A648B0")]
	public NHFGHFKAHLK(TGroup EGEDLIFLLBA, IEnumerable<TData> FABGOIAPOJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct IHPNJHIKHBP<TGroup> where TGroup : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public TGroup NAIDAFIEHMD;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8EB4C0", Offset = "0x8E9CC0", VA = "0x1808EB4C0")]
	public IHPNJHIKHBP(TGroup EGEDLIFLLBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct PFPLNPFGOEN<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public IEnumerable<TData> KELHBNFOLEN;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x8EB4C0", Offset = "0x8E9CC0", VA = "0x1808EB4C0")]
	public PFPLNPFGOEN(IEnumerable<TData> FABGOIAPOJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface DAHAAHINPOB<TGroup, TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KNPJGNFFBDI NECIGMMILEJ(HCADFGPDAPA<TGroup, TData> LCOBOEBPFKD);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KNPJGNFFBDI FGMIOOJKKAD(HCADFGPDAPA<TGroup, TData> LCOBOEBPFKD);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "2")]
	KNPJGNFFBDI BLJOEJCNLJK(NHFGHFKAHLK<TGroup, TData> LCOBOEBPFKD);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "3")]
	KNPJGNFFBDI DKJKNGGCDHL(IHPNJHIKHBP<TGroup> LCOBOEBPFKD);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface DFGGFLEKGNI<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<KNPJGNFFBDI> NECIGMMILEJ(PFPLNPFGOEN<TData> LCOBOEBPFKD);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class ADBAACABKDB<TGroup, TData> : CGANPCJGPCC<DAHAAHINPOB<TGroup, TData>, KNPJGNFFBDI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly NHFGHFKAHLK<TGroup, TData> LCOBOEBPFKD;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3B8F8D0", Offset = "0x3B8E0D0", VA = "0x183B8F8D0")]
	public ADBAACABKDB(TGroup EGEDLIFLLBA, IEnumerable<TData> FABGOIAPOJI, DAHAAHINPOB<TGroup, TData> GALEHIKOJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3B8F800", Offset = "0x3B8E000", VA = "0x183B8F800", Slot = "4")]
	public override KNPJGNFFBDI HHNAPLDDAPJ()
	{
		return default(KNPJGNFFBDI);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class LKCECDOPGEE<TGroup, TData> : CGANPCJGPCC<DAHAAHINPOB<TGroup, TData>, KNPJGNFFBDI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly HCADFGPDAPA<TGroup, TData> LCOBOEBPFKD;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4147170", Offset = "0x4145970", VA = "0x184147170")]
	public LKCECDOPGEE(TGroup EGEDLIFLLBA, TData IEMNABLHEBM, IEnumerable<TData> FABGOIAPOJI, DAHAAHINPOB<TGroup, TData> GALEHIKOJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4158810", Offset = "0x4157010", VA = "0x184158810", Slot = "4")]
	public override KNPJGNFFBDI HHNAPLDDAPJ()
	{
		return default(KNPJGNFFBDI);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class FEPEFAMDKGG<TGroup, TData> : CGANPCJGPCC<DAHAAHINPOB<TGroup, TData>, KNPJGNFFBDI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly IHPNJHIKHBP<TGroup> LCOBOEBPFKD;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3ADF0F0", Offset = "0x3ADD8F0", VA = "0x183ADF0F0")]
	public FEPEFAMDKGG(TGroup EGEDLIFLLBA, DAHAAHINPOB<TGroup, TData> GALEHIKOJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3ADF020", Offset = "0x3ADD820", VA = "0x183ADF020", Slot = "4")]
	public override KNPJGNFFBDI HHNAPLDDAPJ()
	{
		return default(KNPJGNFFBDI);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class LGDOHDNDBIN<TGroup, TData> : CGANPCJGPCC<DAHAAHINPOB<TGroup, TData>, KNPJGNFFBDI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly HCADFGPDAPA<TGroup, TData> LCOBOEBPFKD;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x4147170", Offset = "0x4145970", VA = "0x184147170")]
	public LGDOHDNDBIN(TGroup EGEDLIFLLBA, TData FIFOGEFOMBN, IEnumerable<TData> FABGOIAPOJI, DAHAAHINPOB<TGroup, TData> GALEHIKOJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4147090", Offset = "0x4145890", VA = "0x184147090", Slot = "4")]
	public override KNPJGNFFBDI HHNAPLDDAPJ()
	{
		return default(KNPJGNFFBDI);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class LOPGJKGKAFC<TData> : LBGGPGBLCOB<DFGGFLEKGNI<TData>, KNPJGNFFBDI> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private struct DMKCIIEBLHB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AsyncTaskMethodBuilder<KNPJGNFFBDI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public LOPGJKGKAFC<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private TaskAwaiter<KNPJGNFFBDI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x57B4CF0", Offset = "0x57B34F0", VA = "0x1857B4CF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x57B4F90", Offset = "0x57B3790", VA = "0x1857B4F90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private PFPLNPFGOEN<TData> LCOBOEBPFKD;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3ADF0F0", Offset = "0x3ADD8F0", VA = "0x183ADF0F0")]
	public LOPGJKGKAFC(IEnumerable<TData> NFGMONHCCLP, DFGGFLEKGNI<TData> GALEHIKOJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x4170EB0", Offset = "0x416F6B0", VA = "0x184170EB0", Slot = "4")]
	[AsyncStateMachine(typeof(LOPGJKGKAFC<>.DMKCIIEBLHB))]
	public override Task<KNPJGNFFBDI> HHNAPLDDAPJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct POBBOLGFMNO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly PNIPAIAMHGB JNLDDICPCLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly bool EMIELLIEACO;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x68948C0", Offset = "0x68930C0", VA = "0x1868948C0")]
	public POBBOLGFMNO(PNIPAIAMHGB OGHJOFAKOMB, bool AFDIAGEEEDI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface KCNCLENKIEO<TSpawnType> where TSpawnType : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> HHNAPLDDAPJ(POBBOLGFMNO AMMDIEMNEJO);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class DNGDJFINBOP<TSpawnType> : LBGGPGBLCOB<KCNCLENKIEO<TSpawnType>, TSpawnType> where TSpawnType : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private struct JIBHICOJCOC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public AsyncTaskMethodBuilder<TSpawnType> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public DNGDJFINBOP<TSpawnType> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskAwaiter<TSpawnType> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x3F9CA60", Offset = "0x3F9B260", VA = "0x183F9CA60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3BDA820", Offset = "0x3BD9020", VA = "0x183BDA820", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly POBBOLGFMNO AMMDIEMNEJO;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x57B56E0", Offset = "0x57B3EE0", VA = "0x1857B56E0")]
	public DNGDJFINBOP(PNIPAIAMHGB OGHJOFAKOMB, bool AFDIAGEEEDI, KCNCLENKIEO<TSpawnType> GALEHIKOJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x57B53B0", Offset = "0x57B3BB0", VA = "0x1857B53B0", Slot = "4")]
	[AsyncStateMachine(typeof(DNGDJFINBOP<>.JIBHICOJCOC))]
	public override Task<TSpawnType> HHNAPLDDAPJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public readonly struct PNIPAIAMHGB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly bool JIMAKGDOBGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly Vector3 MAFNCGJIECE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly Vector3 KIBDPDIBGMM;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x68947A0", Offset = "0x6892FA0", VA = "0x1868947A0")]
	public PNIPAIAMHGB(Transform BOHPEBNODAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6894890", Offset = "0x6893090", VA = "0x186894890")]
	public PNIPAIAMHGB(Vector3 ANAAMNHLGOD, Vector3 GBKEBGLIOFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6894770", Offset = "0x6892F70", VA = "0x186894770")]
	public static PNIPAIAMHGB IEMOCPOOCJG()
	{
		return default(PNIPAIAMHGB);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6894810", Offset = "0x6893010", VA = "0x186894810")]
	private PNIPAIAMHGB(bool PBPDHAFEANO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct EKJCBOGBJGI<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public TNode FGOOPPEIAMC;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x375ED60", Offset = "0x375D560", VA = "0x18375ED60")]
	public EKJCBOGBJGI(TNode FGOOPPEIAMC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct ILKEFGADNFI<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public TNode GLFBIKLLFBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public MBDCCAHMAPM AKJLLLKOBHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly bool EMIELLIEACO;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3D93410", Offset = "0x3D91C10", VA = "0x183D93410")]
	public ILKEFGADNFI(TNode GLFBIKLLFBC, MBDCCAHMAPM AKJLLLKOBHM, bool AFDIAGEEEDI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface DDKGDCNDLEG<TNode>
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AKEDKFOGCMC([In] EKJCBOGBJGI<TNode> MKNABALNEME);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CJDEGLKMAEP([In] ILKEFGADNFI<TNode> ODHDCNOFCAI);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CJHCAKFNDGD();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class MJLDKJBMIJH<TNode> : EKNADKGBHNG<DDKGDCNDLEG<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3744F50", Offset = "0x3743750", VA = "0x183744F50")]
	public MJLDKJBMIJH(DDKGDCNDLEG<TNode> GALEHIKOJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3744F00", Offset = "0x3743700", VA = "0x183744F00", Slot = "4")]
	public override bool HHNAPLDDAPJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class JJEJMIAAPMD<TNode> : EKNADKGBHNG<DDKGDCNDLEG<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly ILKEFGADNFI<TNode> ODHDCNOFCAI;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3FA6050", Offset = "0x3FA4850", VA = "0x183FA6050")]
	public JJEJMIAAPMD(TNode GLFBIKLLFBC, MBDCCAHMAPM AKJLLLKOBHM, DDKGDCNDLEG<TNode> GALEHIKOJBA, bool AFDIAGEEEDI = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3760520", Offset = "0x375ED20", VA = "0x183760520", Slot = "4")]
	public override bool HHNAPLDDAPJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class MAHIALCHPOJ<TNode> : EKNADKGBHNG<DDKGDCNDLEG<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly EKJCBOGBJGI<TNode> MKNABALNEME;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x4334CA0", Offset = "0x43334A0", VA = "0x184334CA0")]
	public MAHIALCHPOJ(TNode PFNLCNOGBAP, DDKGDCNDLEG<TNode> GALEHIKOJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x374FA60", Offset = "0x374E260", VA = "0x18374FA60", Slot = "4")]
	public override bool HHNAPLDDAPJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct BLACJGJFOCJ<TSpawnInfo> where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public TSpawnInfo NPLOENFLFAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public Vector3 GBKEBGLIOFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Quaternion LOMIHBHMPMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public float KEONANJCBKH;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x4D340D0", Offset = "0x4D328D0", VA = "0x184D340D0")]
	public BLACJGJFOCJ(TSpawnInfo NPLOENFLFAM, Vector3 GBKEBGLIOFD, Quaternion LOMIHBHMPMH, float KEONANJCBKH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface ENPAMJBLJDB<TSpawnType, TSpawnInfo>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> ILEGLGHCJIM([In] BLACJGJFOCJ<TSpawnInfo> CBHGDFECJNG, CancellationToken ODNHMAMKFFP);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class BADJEGPLPPK<TSpawnType, TSpawnInfo> : LBGGPGBLCOB<ENPAMJBLJDB<TSpawnType, TSpawnInfo>, TSpawnType> where TSpawnType : notnull where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly BLACJGJFOCJ<TSpawnInfo> EKJLJLJONBC;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x4D12750", Offset = "0x4D10F50", VA = "0x184D12750")]
	public BADJEGPLPPK(TSpawnInfo HPPNLJNNHMC, Vector3 GBKEBGLIOFD, Quaternion LOMIHBHMPMH, float KEONANJCBKH, ENPAMJBLJDB<TSpawnType, TSpawnInfo> GALEHIKOJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3B8F480", Offset = "0x3B8DC80", VA = "0x183B8F480", Slot = "4")]
	public override Task<TSpawnType> HHNAPLDDAPJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct LJDDFBAMMJI<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly IEnumerable<TData> KELHBNFOLEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly bool EMIELLIEACO;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x4152B90", Offset = "0x4151390", VA = "0x184152B90")]
	public LJDDFBAMMJI(IEnumerable<TData> FABGOIAPOJI, bool AFDIAGEEEDI = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface OIKAIPLABLB<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<KNPJGNFFBDI> MBHAMDCHMBD([In] LJDDFBAMMJI<TData> GMEIBDMJEKC, CancellationToken ODNHMAMKFFP);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class ACDNHLKNGKC<TData> : LBGGPGBLCOB<OIKAIPLABLB<TData>, KNPJGNFFBDI> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly LJDDFBAMMJI<TData> KACKJMFALON;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3B8F610", Offset = "0x3B8DE10", VA = "0x183B8F610")]
	public ACDNHLKNGKC(IEnumerable<TData> FABGOIAPOJI, bool AFDIAGEEEDI, OIKAIPLABLB<TData> GALEHIKOJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3B8F480", Offset = "0x3B8DC80", VA = "0x183B8F480", Slot = "4")]
	public override Task<KNPJGNFFBDI> HHNAPLDDAPJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct HIJHHDPANLM<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public readonly T LFFBLPMMGND;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x3CACDB0", Offset = "0x3CAB5B0", VA = "0x183CACDB0")]
	public HIJHHDPANLM(T CKIEJHFFJCP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface HJJONIKNLMN<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AKEDKFOGCMC([In] HIJHHDPANLM<T> ADHFIBOGJEG);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CJDEGLKMAEP();
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface EJDKCDOEHID<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HHNAPLDDAPJ([In] FHMIGKOGKBI<T> EAPCJAGONDI);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct FHMIGKOGKBI<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public readonly T LFFBLPMMGND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public readonly bool GFKPHINCJPH;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x3AE8F60", Offset = "0x3AE7760", VA = "0x183AE8F60")]
	public FHMIGKOGKBI(T CKIEJHFFJCP, bool APLBLGKLOMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class JIBCFIGBCAO<T> : EKNADKGBHNG<HJJONIKNLMN<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x3744F50", Offset = "0x3743750", VA = "0x183744F50")]
	public JIBCFIGBCAO(HJJONIKNLMN<T> GALEHIKOJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x3F9C290", Offset = "0x3F9AA90", VA = "0x183F9C290", Slot = "4")]
	public override bool HHNAPLDDAPJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class HEDICNEGLFF<T> : EKNADKGBHNG<HJJONIKNLMN<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly HIJHHDPANLM<T> ADHFIBOGJEG;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x3CA14F0", Offset = "0x3C9FCF0", VA = "0x183CA14F0")]
	public HEDICNEGLFF(T LFFBLPMMGND, HJJONIKNLMN<T> GALEHIKOJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x374FA60", Offset = "0x374E260", VA = "0x18374FA60", Slot = "4")]
	public override bool HHNAPLDDAPJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class DPOBOJIOGID<T> : EKNADKGBHNG<EJDKCDOEHID<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly FHMIGKOGKBI<T> EAPCJAGONDI;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x57B8880", Offset = "0x57B7080", VA = "0x1857B8880")]
	public DPOBOJIOGID(T LFFBLPMMGND, bool APLBLGKLOMJ, EJDKCDOEHID<T> GALEHIKOJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x374FA60", Offset = "0x374E260", VA = "0x18374FA60", Slot = "4")]
	public override bool HHNAPLDDAPJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct EKJFMIAPOHF<TData> where TData : notnull, PGDFCKDFIJB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public IEnumerable<TData> KELHBNFOLEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public bool PMIHKLJFDEA;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x375EDD0", Offset = "0x375D5D0", VA = "0x18375EDD0")]
	public EKJFMIAPOHF(IEnumerable<TData> MPIIJLGEPLG, bool CBELILAAGOK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct CMGMKBEMPMA<TData> where TData : notnull, PGDFCKDFIJB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public List<TData> KELHBNFOLEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public List<bool> MOPPJCHHJHF;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x507A0E0", Offset = "0x50788E0", VA = "0x18507A0E0")]
	public CMGMKBEMPMA(List<TData> MPIIJLGEPLG, List<bool> KDACNKEMAPO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface PGDFCKDFIJB
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool PEFILMHEENE
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
public interface BALEJCNOMGG<TData> where TData : PGDFCKDFIJB
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HHNAPLDDAPJ([In] EKJFMIAPOHF<TData> AFABPOJDPLL);

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HHNAPLDDAPJ([In] CMGMKBEMPMA<TData> AFABPOJDPLL);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface DAFJFKILCKJ<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DCINBAIKPEJ(T LFFBLPMMGND);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class EHHLNHCOCNO<TData> : EKNADKGBHNG<BALEJCNOMGG<TData>> where TData : notnull, PGDFCKDFIJB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly EKJFMIAPOHF<TData> AFABPOJDPLL;

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x374FB20", Offset = "0x374E320", VA = "0x18374FB20")]
	public EHHLNHCOCNO(List<TData> FABGOIAPOJI, bool PMIHKLJFDEA, BALEJCNOMGG<TData> GALEHIKOJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x374FA60", Offset = "0x374E260", VA = "0x18374FA60", Slot = "4")]
	public override bool HHNAPLDDAPJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class OKMLLFMDHFN<TData> : EKNADKGBHNG<BALEJCNOMGG<TData>> where TData : notnull, PGDFCKDFIJB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly CMGMKBEMPMA<TData> AFABPOJDPLL;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x458CBF0", Offset = "0x458B3F0", VA = "0x18458CBF0")]
	public OKMLLFMDHFN(List<TData> FABGOIAPOJI, List<bool> MOPPJCHHJHF, BALEJCNOMGG<TData> GALEHIKOJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x376BC30", Offset = "0x376A430", VA = "0x18376BC30", Slot = "4")]
	public override bool HHNAPLDDAPJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface LMHAHEBFBFB<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<KNPJGNFFBDI> HHNAPLDDAPJ(KJGFOOGCDFI<TData> IEDLGBPIFBK);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public class FGIELNPLMMM<TData> : LBGGPGBLCOB<LMHAHEBFBFB<TData>, KNPJGNFFBDI> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct BMJMHBNFOJI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public AsyncTaskMethodBuilder<KNPJGNFFBDI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public FGIELNPLMMM<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter<KNPJGNFFBDI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x4D39680", Offset = "0x4D37E80", VA = "0x184D39680", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x4D39970", Offset = "0x4D38170", VA = "0x184D39970", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly KJGFOOGCDFI<TData> KAJAGJLMGKI;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x3AE3F10", Offset = "0x3AE2710", VA = "0x183AE3F10")]
	public FGIELNPLMMM(TData LHAMHENELCN, IReadOnlyList<TData> FPGMGLINFHM, bool AFDIAGEEEDI, LMHAHEBFBFB<TData> GALEHIKOJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x3AE3E10", Offset = "0x3AE2610", VA = "0x183AE3E10", Slot = "4")]
	[AsyncStateMachine(typeof(FGIELNPLMMM<>.BMJMHBNFOJI))]
	public override Task<KNPJGNFFBDI> HHNAPLDDAPJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public struct KJGFOOGCDFI<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public TData CJDPNIHOLJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public IReadOnlyList<TData> PCMJPFBCLBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public bool EMIELLIEACO;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x409F2D0", Offset = "0x409DAD0", VA = "0x18409F2D0")]
	public KJGFOOGCDFI(TData LHAMHENELCN, IReadOnlyList<TData> FPGMGLINFHM, bool AFDIAGEEEDI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface CLIEGGFDPGB<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HHNAPLDDAPJ([In] JCHHNDDKGKN<TData> JLHLGCMCNFJ);
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface OAMLIAOEDPK<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HHNAPLDDAPJ([In] GJHDKOPPJEL<TData> JLHLGCMCNFJ);
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface KIKIIBDGDAG<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PJPFBILACID([In] OLOGDJFHOCA<TData> JLHLGCMCNFJ);

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CJDEGLKMAEP();
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class CMIECHBOGEJ<TData> : EKNADKGBHNG<CLIEGGFDPGB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly JCHHNDDKGKN<TData> JLHLGCMCNFJ;

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x507A5C0", Offset = "0x5078DC0", VA = "0x18507A5C0")]
	public CMIECHBOGEJ(IEnumerable<TData> FABGOIAPOJI, ELABJABMIML NLKAPPNAHLI, EANADOKBABP CLECAFFDEAA, float KGLCINJPDND, bool AFDIAGEEEDI, CLIEGGFDPGB<TData> GALEHIKOJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x374FA60", Offset = "0x374E260", VA = "0x18374FA60", Slot = "4")]
	public override bool HHNAPLDDAPJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class IKGMFIHGDPO<TData> : EKNADKGBHNG<OAMLIAOEDPK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly GJHDKOPPJEL<TData> JLHLGCMCNFJ;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x3D92070", Offset = "0x3D90870", VA = "0x183D92070")]
	public IKGMFIHGDPO(TData[] FABGOIAPOJI, ELABJABMIML[] NLKAPPNAHLI, EANADOKBABP[] CLECAFFDEAA, float[] KGLCINJPDND, OAMLIAOEDPK<TData> GALEHIKOJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3D91EC0", Offset = "0x3D906C0", VA = "0x183D91EC0", Slot = "4")]
	public override bool HHNAPLDDAPJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class KLBMLILMPBM<TData> : EKNADKGBHNG<KIKIIBDGDAG<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3744F50", Offset = "0x3743750", VA = "0x183744F50")]
	public KLBMLILMPBM(KIKIIBDGDAG<TData> GALEHIKOJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x40B3050", Offset = "0x40B1850", VA = "0x1840B3050", Slot = "4")]
	public override bool HHNAPLDDAPJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class DGFHIAEMNJB<TData> : EKNADKGBHNG<KIKIIBDGDAG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly OLOGDJFHOCA<TData> JLHLGCMCNFJ;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x56F2E50", Offset = "0x56F1650", VA = "0x1856F2E50")]
	public DGFHIAEMNJB(IEnumerable<TData> FABGOIAPOJI, ELABJABMIML NLKAPPNAHLI, EANADOKBABP CLECAFFDEAA, float KGLCINJPDND, KIKIIBDGDAG<TData> GALEHIKOJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3D91EC0", Offset = "0x3D906C0", VA = "0x183D91EC0", Slot = "4")]
	public override bool HHNAPLDDAPJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public struct JCHHNDDKGKN<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public IEnumerable<TData> KELHBNFOLEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public ELABJABMIML BJDFJONKEEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public EANADOKBABP OIIHCFBIELL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public float KGLCINJPDND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public bool AFDIAGEEEDI;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3F70120", Offset = "0x3F6E920", VA = "0x183F70120")]
	public JCHHNDDKGKN(IEnumerable<TData> FABGOIAPOJI, ELABJABMIML NLKAPPNAHLI, EANADOKBABP CLECAFFDEAA, float KGLCINJPDND, bool AFDIAGEEEDI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct GJHDKOPPJEL<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public TData[] KELHBNFOLEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public ELABJABMIML[] BJDFJONKEEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public EANADOKBABP[] OIIHCFBIELL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public float[] KGLCINJPDND;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3BDE230", Offset = "0x3BDCA30", VA = "0x183BDE230")]
	public GJHDKOPPJEL(TData[] FABGOIAPOJI, ELABJABMIML[] NLKAPPNAHLI, EANADOKBABP[] CLECAFFDEAA, float[] KGLCINJPDND)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public struct OLOGDJFHOCA<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public IEnumerable<TData> KELHBNFOLEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public ELABJABMIML BJDFJONKEEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public EANADOKBABP OIIHCFBIELL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public float KGLCINJPDND;

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x458ECC0", Offset = "0x458D4C0", VA = "0x18458ECC0")]
	public OLOGDJFHOCA(IEnumerable<TData> FABGOIAPOJI, ELABJABMIML NLKAPPNAHLI, EANADOKBABP CLECAFFDEAA, float KGLCINJPDND)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public interface AOONGAODABF<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BLJOEJCNLJK([In] PJLAHBGGFAE<TData> GMEIBDMJEKC);

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DKJKNGGCDHL([In] PJLAHBGGFAE<TData> GMEIBDMJEKC);

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LMJENJOAJHN([In] bool GENJHLOOJEB);

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool AEFFOEDKNAI([In] PJLAHBGGFAE<TData> GMEIBDMJEKC);

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FLPBHKKACKJ();

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool CANGODNIMLD([In] TData BKLNEIDODHP);
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class EJEBMDKAJKB<TData> : EKNADKGBHNG<AOONGAODABF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly PJLAHBGGFAE<TData> GMEIBDMJEKC;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x375C5A0", Offset = "0x375ADA0", VA = "0x18375C5A0")]
	public EJEBMDKAJKB(List<TData> BFMOHBHIKHF, AOONGAODABF<TData> GALEHIKOJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x374FA60", Offset = "0x374E260", VA = "0x18374FA60", Slot = "4")]
	public override bool HHNAPLDDAPJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class LMPEFCEKJCC<TData> : EKNADKGBHNG<AOONGAODABF<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3744F50", Offset = "0x3743750", VA = "0x183744F50")]
	public LMPEFCEKJCC(AOONGAODABF<TData> GALEHIKOJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x4167380", Offset = "0x4165B80", VA = "0x184167380", Slot = "4")]
	public override bool HHNAPLDDAPJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class CHKJFIONIAM<TData> : EKNADKGBHNG<AOONGAODABF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly bool AFDIAGEEEDI;

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x4F88A00", Offset = "0x4F87200", VA = "0x184F88A00")]
	public CHKJFIONIAM(bool AFDIAGEEEDI, AOONGAODABF<TData> GALEHIKOJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x4F889A0", Offset = "0x4F871A0", VA = "0x184F889A0", Slot = "4")]
	public override bool HHNAPLDDAPJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class ENDPOMIKJJN<TData> : EKNADKGBHNG<AOONGAODABF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly PJLAHBGGFAE<TData> GMEIBDMJEKC;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x376BCF0", Offset = "0x376A4F0", VA = "0x18376BCF0")]
	public ENDPOMIKJJN(List<TData> BFMOHBHIKHF, bool AFDIAGEEEDI, AOONGAODABF<TData> GALEHIKOJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x376BC30", Offset = "0x376A430", VA = "0x18376BC30", Slot = "4")]
	public override bool HHNAPLDDAPJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class FJFBIAPFFPA<TData> : EKNADKGBHNG<AOONGAODABF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly TData BKLNEIDODHP;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3AF8FD0", Offset = "0x3AF77D0", VA = "0x183AF8FD0")]
	public FJFBIAPFFPA(TData BKLNEIDODHP, AOONGAODABF<TData> GALEHIKOJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3AF8E40", Offset = "0x3AF7640", VA = "0x183AF8E40", Slot = "4")]
	public override bool HHNAPLDDAPJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class NLKOIOEHKKM<TData> : EKNADKGBHNG<AOONGAODABF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly PJLAHBGGFAE<TData> GMEIBDMJEKC;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x4462DD0", Offset = "0x44615D0", VA = "0x184462DD0")]
	public NLKOIOEHKKM(IEnumerable<TData> BFMOHBHIKHF, AOONGAODABF<TData> GALEHIKOJBA, bool AFDIAGEEEDI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x4462C50", Offset = "0x4461450", VA = "0x184462C50", Slot = "4")]
	public override bool HHNAPLDDAPJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public struct PJLAHBGGFAE<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public IEnumerable<TData> KELHBNFOLEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public bool AFDIAGEEEDI;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x4665170", Offset = "0x4663970", VA = "0x184665170")]
	public PJLAHBGGFAE(IEnumerable<TData> MPIIJLGEPLG, bool MFAFLILPECD = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public interface IBJPDBGLAOH
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<KNPJGNFFBDI> HHNAPLDDAPJ(HMOJAEKCNJA OHJKNHDAJPH);
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class JKOALOEAOPP : LBGGPGBLCOB<IBJPDBGLAOH, KNPJGNFFBDI>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private struct KPGMHPHMBCN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public AsyncTaskMethodBuilder<KNPJGNFFBDI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public JKOALOEAOPP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private TaskAwaiter<KNPJGNFFBDI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6893F30", Offset = "0x6892730", VA = "0x186893F30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x68941B0", Offset = "0x68929B0", VA = "0x1868941B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly HMOJAEKCNJA CMOEKACLKDH;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6893A60", Offset = "0x6892260", VA = "0x186893A60")]
	public JKOALOEAOPP(bool AFDIAGEEEDI, IBJPDBGLAOH GALEHIKOJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6893970", Offset = "0x6892170", VA = "0x186893970", Slot = "4")]
	[AsyncStateMachine(typeof(KPGMHPHMBCN))]
	public override Task<KNPJGNFFBDI> HHNAPLDDAPJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct HMOJAEKCNJA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public bool EMIELLIEACO;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0xDCDC00", Offset = "0xDCC400", VA = "0x180DCDC00")]
	public HMOJAEKCNJA(bool AFDIAGEEEDI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public readonly struct OCDOAEJBKDJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly bool IDGMKMCOBOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly bool HLCMFFEGMIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public readonly bool KEONANJCBKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public readonly bool AFDIAGEEEDI;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4BB64F0", Offset = "0x4BB4CF0", VA = "0x184BB64F0")]
	public OCDOAEJBKDJ(bool IDGMKMCOBOP, bool HLCMFFEGMIH, bool KEONANJCBKH, bool AFDIAGEEEDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6894530", Offset = "0x6892D30", VA = "0x186894530")]
	public OCDOAEJBKDJ(bool HLCMFFEGMIH, bool AFDIAGEEEDI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface MAEPPFMNAFM
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KPDKJKGFHNP(OCDOAEJBKDJ BMKFMKGOIOJ);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BAGHBIIKMPK(OCDOAEJBKDJ BMKFMKGOIOJ);
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class IBMBCAIDBDN : EKNADKGBHNG<MAEPPFMNAFM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly OCDOAEJBKDJ BMKFMKGOIOJ;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6893790", Offset = "0x6891F90", VA = "0x186893790")]
	public IBMBCAIDBDN(bool MCHMJHAODPL, bool HLCMFFEGMIH, bool KEONANJCBKH, bool AFDIAGEEEDI, MAEPPFMNAFM GALEHIKOJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6893740", Offset = "0x6891F40", VA = "0x186893740", Slot = "4")]
	public override bool HHNAPLDDAPJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class KMGPOAHBBNK : EKNADKGBHNG<MAEPPFMNAFM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly OCDOAEJBKDJ BMKFMKGOIOJ;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6893EB0", Offset = "0x68926B0", VA = "0x186893EB0")]
	public KMGPOAHBBNK(bool HLCMFFEGMIH, bool AFDIAGEEEDI, MAEPPFMNAFM GALEHIKOJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6893E60", Offset = "0x6892660", VA = "0x186893E60", Slot = "4")]
	public override bool HHNAPLDDAPJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public interface FCEJDDGCEPP
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HHNAPLDDAPJ([In] BPLEAKCFBBO JGJPPNIEHIO);
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class MKCHCPMANKD : EKNADKGBHNG<FCEJDDGCEPP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly BPLEAKCFBBO JGJPPNIEHIO;

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x68942D0", Offset = "0x6892AD0", VA = "0x1868942D0")]
	public MKCHCPMANKD(Guid[] HBFKCCHJKHA, Vector3[] CABOKLKJMPK, Quaternion[] JHNIEMNIBGG, float[] NMDKBCOPOHJ, Dictionary<Guid, Vector3> JJLGGMCNGLE, FCEJDDGCEPP GALEHIKOJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6894220", Offset = "0x6892A20", VA = "0x186894220", Slot = "4")]
	public override bool HHNAPLDDAPJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public interface GIKBGMKKKJI<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AKEDKFOGCMC([In] DGAHCOABLMC<TData> MKNABALNEME);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PJPFBILACID([In] FMOOHDNOHDD BCNDDLMKHIJ);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PJPFBILACID([In] HBFEDIOPIJL BCNDDLMKHIJ);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CJDEGLKMAEP();
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class PAECNNFPKBM<TData> : EKNADKGBHNG<GIKBGMKKKJI<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x3744F50", Offset = "0x3743750", VA = "0x183744F50")]
	public PAECNNFPKBM(GIKBGMKKKJI<TData> GALEHIKOJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x4643120", Offset = "0x4641920", VA = "0x184643120", Slot = "4")]
	public override bool HHNAPLDDAPJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class NDLBIOALDPE<TData> : EKNADKGBHNG<GIKBGMKKKJI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly FMOOHDNOHDD JNNBKAANFFM;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x4427170", Offset = "0x4425970", VA = "0x184427170")]
	public NDLBIOALDPE(Vector3 AJNIKBLJHED, bool MKGAOPCGKMF, GIKBGMKKKJI<TData> GALEHIKOJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x3DBF6A0", Offset = "0x3DBDEA0", VA = "0x183DBF6A0", Slot = "4")]
	public override bool HHNAPLDDAPJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class EAIELNMKCKE<TData> : EKNADKGBHNG<GIKBGMKKKJI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly HBFEDIOPIJL JNNBKAANFFM;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x373E850", Offset = "0x373D050", VA = "0x18373E850")]
	public EAIELNMKCKE(Guid DMODHOOBIMO, int JBDLDJOINOF, Vector3 GBKEBGLIOFD, Quaternion LOMIHBHMPMH, float PBKMMDBNFGD, bool MKGAOPCGKMF, GIKBGMKKKJI<TData> GALEHIKOJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x373E7F0", Offset = "0x373CFF0", VA = "0x18373E7F0", Slot = "4")]
	public override bool HHNAPLDDAPJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class NHDFJDILIAM<TData> : EKNADKGBHNG<GIKBGMKKKJI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly DGAHCOABLMC<TData> JNNBKAANFFM;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x442CAA0", Offset = "0x442B2A0", VA = "0x18442CAA0")]
	public NHDFJDILIAM(TData LFFBLPMMGND, bool AFDIAGEEEDI, GIKBGMKKKJI<TData> GALEHIKOJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x374FA60", Offset = "0x374E260", VA = "0x18374FA60", Slot = "4")]
	public override bool HHNAPLDDAPJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public struct FMOOHDNOHDD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly Vector3 AJNIKBLJHED;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public readonly bool MKGAOPCGKMF;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x68936E0", Offset = "0x6891EE0", VA = "0x1868936E0")]
	public FMOOHDNOHDD(Vector3 AJNIKBLJHED, bool MKGAOPCGKMF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public struct HBFEDIOPIJL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public readonly Guid DMODHOOBIMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public readonly int JBDLDJOINOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public readonly Vector3 GBKEBGLIOFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public readonly Quaternion LOMIHBHMPMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public readonly float PBKMMDBNFGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public readonly bool MKGAOPCGKMF;

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6893700", Offset = "0x6891F00", VA = "0x186893700")]
	public HBFEDIOPIJL(Guid DMODHOOBIMO, int JBDLDJOINOF, Vector3 GBKEBGLIOFD, Quaternion LOMIHBHMPMH, float PBKMMDBNFGD, bool MKGAOPCGKMF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public struct DGAHCOABLMC<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public readonly TData LFFBLPMMGND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public readonly bool AFDIAGEEEDI;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x56F2950", Offset = "0x56F1150", VA = "0x1856F2950")]
	public DGAHCOABLMC(TData LFFBLPMMGND, bool AFDIAGEEEDI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public interface MEPONIEACGK<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HHNAPLDDAPJ([In] CDBHLJIFBDG<TData> HDJIADNLIEA);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HHNAPLDDAPJ([In] EBICOMICAOH<TData> HDJIADNLIEA);
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public interface NAIPFEJAHPE<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AKEDKFOGCMC([In] NPFNLLDNEEE<TData> LNNJDKNGHGA);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PJPFBILACID([In] DGAMMNONBDC BCNDDLMKHIJ);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CJDEGLKMAEP();
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class MPOOIDFHJIB<TData> : EKNADKGBHNG<MEPONIEACGK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly CDBHLJIFBDG<TData> HDJIADNLIEA;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x43C7490", Offset = "0x43C5C90", VA = "0x1843C7490")]
	public MPOOIDFHJIB(IEnumerable<TData> FABGOIAPOJI, Vector3 FEPLLIOKCAH, bool AFDIAGEEEDI, MEPONIEACGK<TData> GALEHIKOJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x374FA60", Offset = "0x374E260", VA = "0x18374FA60", Slot = "4")]
	public override bool HHNAPLDDAPJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class EEJDJMHGCCA<TData> : EKNADKGBHNG<NAIPFEJAHPE<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x3744F50", Offset = "0x3743750", VA = "0x183744F50")]
	public EEJDJMHGCCA(NAIPFEJAHPE<TData> GALEHIKOJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x3744F00", Offset = "0x3743700", VA = "0x183744F00", Slot = "4")]
	public override bool HHNAPLDDAPJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class FMPLGHCCKAI<TData> : EKNADKGBHNG<NAIPFEJAHPE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly NPFNLLDNEEE<TData> HDJIADNLIEA;

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x3B056E0", Offset = "0x3B03EE0", VA = "0x183B056E0")]
	public FMPLGHCCKAI(IEnumerable<TData> FABGOIAPOJI, bool AFDIAGEEEDI, NAIPFEJAHPE<TData> GALEHIKOJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x374FA60", Offset = "0x374E260", VA = "0x18374FA60", Slot = "4")]
	public override bool HHNAPLDDAPJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class KMEAOEHFGNG<TData> : EKNADKGBHNG<MEPONIEACGK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly EBICOMICAOH<TData> HDJIADNLIEA;

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x40B30A0", Offset = "0x40B18A0", VA = "0x1840B30A0")]
	public KMEAOEHFGNG(IEnumerable<TData> FABGOIAPOJI, Vector3 ODCMIJPNLGI, BPAJMHECGCC ICAPBFKPEEL, bool AFDIAGEEEDI, MEPONIEACGK<TData> GALEHIKOJBA, Space BFOKAHEPOJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3760520", Offset = "0x375ED20", VA = "0x183760520", Slot = "4")]
	public override bool HHNAPLDDAPJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class OODCJGCNGJD<TData> : EKNADKGBHNG<NAIPFEJAHPE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly DGAMMNONBDC HDJIADNLIEA;

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x45A34F0", Offset = "0x45A1CF0", VA = "0x1845A34F0")]
	public OODCJGCNGJD(Vector3 FEPLLIOKCAH, NAIPFEJAHPE<TData> GALEHIKOJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x3DBF6A0", Offset = "0x3DBDEA0", VA = "0x183DBF6A0", Slot = "4")]
	public override bool HHNAPLDDAPJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct CDBHLJIFBDG<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public readonly IEnumerable<TData> FABGOIAPOJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public readonly Vector3 FEPLLIOKCAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public readonly bool AFDIAGEEEDI;

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x4F6E910", Offset = "0x4F6D110", VA = "0x184F6E910")]
	public CDBHLJIFBDG(IEnumerable<TData> FABGOIAPOJI, Vector3 FEPLLIOKCAH, bool AFDIAGEEEDI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct NPFNLLDNEEE<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public readonly IEnumerable<TData> FABGOIAPOJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public readonly bool AFDIAGEEEDI;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x4466A70", Offset = "0x4465270", VA = "0x184466A70")]
	public NPFNLLDNEEE(IEnumerable<TData> FABGOIAPOJI, bool AFDIAGEEEDI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct EBICOMICAOH<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public readonly IEnumerable<TData> FABGOIAPOJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public readonly Vector3 ODCMIJPNLGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly BPAJMHECGCC ICAPBFKPEEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public readonly bool AFDIAGEEEDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly Space BFOKAHEPOJJ;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x373F270", Offset = "0x373DA70", VA = "0x18373F270")]
	public EBICOMICAOH(IEnumerable<TData> FABGOIAPOJI, Vector3 ODCMIJPNLGI, BPAJMHECGCC ICAPBFKPEEL, bool AFDIAGEEEDI, Space BFOKAHEPOJJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct DGAMMNONBDC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public readonly Vector3 FEPLLIOKCAH;

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x20EA990", Offset = "0x20E9190", VA = "0x1820EA990")]
	public DGAMMNONBDC(Vector3 FEPLLIOKCAH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public enum BPAJMHECGCC
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
public interface AKGGHNMOEMA
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HHNAPLDDAPJ([In] MJDFBMBHHMG OMALKMPELPE);
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public class ILLPGKBOBMI : EKNADKGBHNG<AKGGHNMOEMA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly MJDFBMBHHMG OMALKMPELPE;

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x68938D0", Offset = "0x68920D0", VA = "0x1868938D0")]
	public ILLPGKBOBMI(bool AFDIAGEEEDI, AKGGHNMOEMA GALEHIKOJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6893820", Offset = "0x6892020", VA = "0x186893820", Slot = "4")]
	public override bool HHNAPLDDAPJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public readonly struct MJDFBMBHHMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public readonly bool AFDIAGEEEDI;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0xDCDC00", Offset = "0xDCC400", VA = "0x180DCDC00")]
	public MJDFBMBHHMG(bool AFDIAGEEEDI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public interface ADICAICBAON<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HHNAPLDDAPJ([In] GIOEBNEPLNE<TData> ECBPIDCFGIP);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HHNAPLDDAPJ([In] GMJHNJGMMJH<TData> ECBPIDCFGIP);
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public interface IKMOKMJHKFG<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AKEDKFOGCMC([In] MOFONILGJBK<TData> MKNABALNEME);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PJPFBILACID([In] IBAHKPALJPG BCNDDLMKHIJ);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CJDEGLKMAEP();
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class GLGJBBFGCKJ<TData> : EKNADKGBHNG<ADICAICBAON<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly GIOEBNEPLNE<TData> ECBPIDCFGIP;

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x3BE7D40", Offset = "0x3BE6540", VA = "0x183BE7D40")]
	public GLGJBBFGCKJ(IEnumerable<TData> FABGOIAPOJI, Quaternion FEPLLIOKCAH, Vector3? FLGMGAFFDJD, bool ENKOHIOJKKN, bool AFDIAGEEEDI, ADICAICBAON<TData> GALEHIKOJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x374FA60", Offset = "0x374E260", VA = "0x18374FA60", Slot = "4")]
	public override bool HHNAPLDDAPJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class AFFKGIJCOKA<TData> : EKNADKGBHNG<IKMOKMJHKFG<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x3744F50", Offset = "0x3743750", VA = "0x183744F50")]
	public AFFKGIJCOKA(IKMOKMJHKFG<TData> GALEHIKOJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x3744F00", Offset = "0x3743700", VA = "0x183744F00", Slot = "4")]
	public override bool HHNAPLDDAPJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class AMCFCAJPCBB<TData> : EKNADKGBHNG<IKMOKMJHKFG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly MOFONILGJBK<TData> ECBPIDCFGIP;

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x3C522F0", Offset = "0x3C50AF0", VA = "0x183C522F0")]
	public AMCFCAJPCBB(IEnumerable<TData> FABGOIAPOJI, bool AFDIAGEEEDI, IKMOKMJHKFG<TData> GALEHIKOJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x374FA60", Offset = "0x374E260", VA = "0x18374FA60", Slot = "4")]
	public override bool HHNAPLDDAPJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class EMCOBFHHPML<TData> : EKNADKGBHNG<ADICAICBAON<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly GMJHNJGMMJH<TData> ECBPIDCFGIP;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x37605F0", Offset = "0x375EDF0", VA = "0x1837605F0")]
	public EMCOBFHHPML(IEnumerable<TData> FABGOIAPOJI, Quaternion FNHJNAAKDJJ, BPAJMHECGCC PPLIMCIOABL, Vector3? FLGMGAFFDJD, bool ENKOHIOJKKN, bool AFDIAGEEEDI, Space BFOKAHEPOJJ, ADICAICBAON<TData> GALEHIKOJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x3760520", Offset = "0x375ED20", VA = "0x183760520", Slot = "4")]
	public override bool HHNAPLDDAPJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class BBMHJHMBEEM<TData> : EKNADKGBHNG<IKMOKMJHKFG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly IBAHKPALJPG ECBPIDCFGIP;

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x4D17C80", Offset = "0x4D16480", VA = "0x184D17C80")]
	public BBMHJHMBEEM(Quaternion FEPLLIOKCAH, Vector3? FLGMGAFFDJD, bool ENKOHIOJKKN, IKMOKMJHKFG<TData> GALEHIKOJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x3DBF6A0", Offset = "0x3DBDEA0", VA = "0x183DBF6A0", Slot = "4")]
	public override bool HHNAPLDDAPJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public struct GIOEBNEPLNE<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public readonly IEnumerable<TData> FABGOIAPOJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public readonly Quaternion FEPLLIOKCAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public readonly Vector3? FLGMGAFFDJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public readonly bool ENKOHIOJKKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public readonly bool AFDIAGEEEDI;

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x3BDDC30", Offset = "0x3BDC430", VA = "0x183BDDC30")]
	public GIOEBNEPLNE(IEnumerable<TData> FABGOIAPOJI, Quaternion FEPLLIOKCAH, Vector3? FLGMGAFFDJD, bool ENKOHIOJKKN, bool AFDIAGEEEDI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public struct MOFONILGJBK<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public readonly IEnumerable<TData> FABGOIAPOJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly bool AFDIAGEEEDI;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x43C1A20", Offset = "0x43C0220", VA = "0x1843C1A20")]
	public MOFONILGJBK(IEnumerable<TData> FABGOIAPOJI, bool AFDIAGEEEDI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public struct GMJHNJGMMJH<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public readonly IEnumerable<TData> FABGOIAPOJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public readonly Quaternion FNHJNAAKDJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public readonly BPAJMHECGCC PPLIMCIOABL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public readonly Vector3? FLGMGAFFDJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public readonly bool ENKOHIOJKKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public readonly bool AFDIAGEEEDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public readonly Space BFOKAHEPOJJ;

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x3BE9070", Offset = "0x3BE7870", VA = "0x183BE9070")]
	public GMJHNJGMMJH(IEnumerable<TData> FABGOIAPOJI, Quaternion FNHJNAAKDJJ, BPAJMHECGCC PPLIMCIOABL, Vector3? FLGMGAFFDJD, bool ENKOHIOJKKN, bool AFDIAGEEEDI, Space BFOKAHEPOJJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public struct IBAHKPALJPG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public readonly Quaternion FEPLLIOKCAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public readonly Vector3? FLGMGAFFDJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public readonly bool ENKOHIOJKKN;

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x4B792E0", Offset = "0x4B77AE0", VA = "0x184B792E0")]
	public IBAHKPALJPG(Quaternion FEPLLIOKCAH, Vector3? FLGMGAFFDJD, bool ENKOHIOJKKN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public interface OBMFDHPKJKL<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AKEDKFOGCMC([In] CJLFHIFALNB<TData> MKNABALNEME);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PJPFBILACID([In] CHIGIHBIGMI BCNDDLMKHIJ);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PJPFBILACID([In] DKJNEDMDEJA BCNDDLMKHIJ);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool PJPFBILACID([In] JCEDBBHCCHL BCNDDLMKHIJ);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool CJDEGLKMAEP();
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public class ECCNILGDBGA<TData> : EKNADKGBHNG<OBMFDHPKJKL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly JCEDBBHCCHL HFDOGKPPIHI;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x373F5B0", Offset = "0x373DDB0", VA = "0x18373F5B0")]
	public ECCNILGDBGA(Vector3 PPGGHMEGNCM, float FMCCCFIPNDL, Vector3 FLGMGAFFDJD, bool JKBJNDMNAEM, bool DDJIJAHEGED, OBMFDHPKJKL<TData> GALEHIKOJBA, Space BFOKAHEPOJJ = Space.Self)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x373F550", Offset = "0x373DD50", VA = "0x18373F550", Slot = "4")]
	public override bool HHNAPLDDAPJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public class DBGDHMPKJMA<TData> : EKNADKGBHNG<OBMFDHPKJKL<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x3744F50", Offset = "0x3743750", VA = "0x183744F50")]
	public DBGDHMPKJMA(OBMFDHPKJKL<TData> GALEHIKOJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x56E3470", Offset = "0x56E1C70", VA = "0x1856E3470", Slot = "4")]
	public override bool HHNAPLDDAPJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class OEICJEDIPGK<TData> : EKNADKGBHNG<OBMFDHPKJKL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly CJLFHIFALNB<TData> HFDOGKPPIHI;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x45503A0", Offset = "0x454EBA0", VA = "0x1845503A0")]
	public OEICJEDIPGK(IEnumerable<TData> FABGOIAPOJI, bool AFDIAGEEEDI, OBMFDHPKJKL<TData> GALEHIKOJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x374FA60", Offset = "0x374E260", VA = "0x18374FA60", Slot = "4")]
	public override bool HHNAPLDDAPJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class HCFFFCCLFCJ<TData> : EKNADKGBHNG<OBMFDHPKJKL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly DKJNEDMDEJA HFDOGKPPIHI;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x3C7E980", Offset = "0x3C7D180", VA = "0x183C7E980")]
	public HCFFFCCLFCJ(float LKKHIJKJJLG, bool AJBDGLBJGOA, Vector3 FLGMGAFFDJD, OBMFDHPKJKL<TData> GALEHIKOJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x3C7E8B0", Offset = "0x3C7D0B0", VA = "0x183C7E8B0", Slot = "4")]
	public override bool HHNAPLDDAPJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class IPCDOEMFHAL<TData> : EKNADKGBHNG<OBMFDHPKJKL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly CHIGIHBIGMI HFDOGKPPIHI;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x3DBF700", Offset = "0x3DBDF00", VA = "0x183DBF700")]
	public IPCDOEMFHAL(float FMCCCFIPNDL, Vector3 FLGMGAFFDJD, OBMFDHPKJKL<TData> GALEHIKOJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x3DBF6A0", Offset = "0x3DBDEA0", VA = "0x183DBF6A0", Slot = "4")]
	public override bool HHNAPLDDAPJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public struct JCEDBBHCCHL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public readonly Vector3 PPGGHMEGNCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public readonly float FMCCCFIPNDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public readonly Vector3 FLGMGAFFDJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public readonly bool MKGAOPCGKMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public readonly Space BFOKAHEPOJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public readonly bool DDJIJAHEGED;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x6893930", Offset = "0x6892130", VA = "0x186893930")]
	public JCEDBBHCCHL(Vector3 PPGGHMEGNCM, float FMCCCFIPNDL, Vector3 FLGMGAFFDJD, bool MKGAOPCGKMF, bool KFKOPCELBFP, Space BFOKAHEPOJJ = Space.Self)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public struct CJLFHIFALNB<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public readonly IEnumerable<TData> FABGOIAPOJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public readonly bool AFDIAGEEEDI;

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x4F8D430", Offset = "0x4F8BC30", VA = "0x184F8D430")]
	public CJLFHIFALNB(IEnumerable<TData> FABGOIAPOJI, bool AFDIAGEEEDI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct DKJNEDMDEJA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public readonly float LKKHIJKJJLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public readonly bool AJBDGLBJGOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public readonly Vector3 FLGMGAFFDJD;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x68936C0", Offset = "0x6891EC0", VA = "0x1868936C0")]
	public DKJNEDMDEJA(float LKKHIJKJJLG, bool AJBDGLBJGOA, Vector3 FLGMGAFFDJD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public struct CHIGIHBIGMI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public readonly float FMCCCFIPNDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public readonly Vector3 FLGMGAFFDJD;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x4B53260", Offset = "0x4B51A60", VA = "0x184B53260")]
	public CHIGIHBIGMI(float FMCCCFIPNDL, Vector3 FLGMGAFFDJD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct BPLEAKCFBBO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public readonly Guid[] FABGOIAPOJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public readonly bool JKBHPBJKIGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public readonly bool OGODGKJKNDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public readonly bool CMDKPEAKCGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public readonly Vector3[] CABOKLKJMPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public readonly Quaternion[] JHNIEMNIBGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly float[] NMDKBCOPOHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public readonly Dictionary<Guid, Vector3> JJLGGMCNGLE;

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6893430", Offset = "0x6891C30", VA = "0x186893430")]
	public BPLEAKCFBBO(Guid[] HBFKCCHJKHA, Vector3[] CABOKLKJMPK, Quaternion[] JHNIEMNIBGG, float[] NMDKBCOPOHJ, Dictionary<Guid, Vector3> JJLGGMCNGLE, bool JKBHPBJKIGP = true, bool OGODGKJKNDF = true, bool CMDKPEAKCGF = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x6893260", Offset = "0x6891A60", VA = "0x186893260")]
	private static void HKECCIAMAGJ(Dictionary<Guid, Vector3> JJLGGMCNGLE, int JHIJFNOLIHK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public static class KFAOIGDBPDH
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	private struct FFOPAKPGEML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public bool KNKOLCPPJKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public AANDDJDEEFL DLDDDBNCBEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public AANDDJDEEFL BDFIMPMFJFD;
	}

	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private static FFOPAKPGEML PFFGOJFLGAM;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static CancellationToken KMHMOFNNKFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x6893AC0", Offset = "0x68922C0", VA = "0x186893AC0")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	internal static AANDDJDEEFL DLDDDBNCBEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x6893B90", Offset = "0x6892390", VA = "0x186893B90")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6893B30", Offset = "0x6892330", VA = "0x186893B30")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6893D70", Offset = "0x6892570", VA = "0x186893D70")]
	[ANLGLDAOJJE(KKPEBAHBECP.Room, ELBANFBEGNE.None)]
	private static void OMKIEHKAOHM(AANDDJDEEFL POMPFPOBABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6893C30", Offset = "0x6892430", VA = "0x186893C30")]
	public static void NJEEDNGOJJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6893AE0", Offset = "0x68922E0", VA = "0x186893AE0")]
	private static AANDDJDEEFL EBBJMJMEKBP(AANDDJDEEFL MBIIHOBBHFA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public static class GLIHFOFGNPP
{
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public enum LMJNDDBHEBL
	{
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		ICreationContextObject,
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		Guid
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x2A8FEB0", Offset = "0x2A8E6B0", VA = "0x182A8FEB0")]
	public static void NDBGBOMFLMF<T>(T OFKHAJDAKLA, LMJNDDBHEBL HKAKMPIMEOA) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x2A8FE40", Offset = "0x2A8E640", VA = "0x182A8FE40")]
	public static void NDBGBOMFLMF<T>(T OFKHAJDAKLA) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x2A8FC80", Offset = "0x2A8E480", VA = "0x182A8FC80")]
	public static void LJOFGDNPHEL<T>(T OFKHAJDAKLA) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x2A8FD30", Offset = "0x2A8E530", VA = "0x182A8FD30")]
	public static T NBGKOOJKKKA<T>(LMJNDDBHEBL HKAKMPIMEOA) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x2A8FA70", Offset = "0x2A8E270", VA = "0x182A8FA70")]
	public static bool GIPAEIFMNNK<T>(LMJNDDBHEBL HKAKMPIMEOA, T? BKPMDIOCEMO, [Out][NotNullWhen(true)][MaybeNullWhen(false)] T PAAEBACCKOH) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x2A90020", Offset = "0x2A8E820", VA = "0x182A90020")]
	public static bool OMHAIENIFBJ<T>(LMJNDDBHEBL HKAKMPIMEOA) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x2A8FDE0", Offset = "0x2A8E5E0", VA = "0x182A8FDE0")]
	public static T NBGKOOJKKKA<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x2A8FBC0", Offset = "0x2A8E3C0", VA = "0x182A8FBC0")]
	public static bool GIPAEIFMNNK<T>(T BKPMDIOCEMO, [Out] T PAAEBACCKOH) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x2A8FDE0", Offset = "0x2A8E5E0", VA = "0x182A8FDE0")]
	public static bool OMHAIENIFBJ<T>() where T : class
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
internal static class PLIDFLDKADB
{
	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6894540", Offset = "0x6892D40", VA = "0x186894540")]
	public static void NKMLJFAHBAN(IEnumerable DLBPOPKENJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x2C4F560", Offset = "0x2C4DD60", VA = "0x182C4F560")]
	public static void NKMLJFAHBAN<T>(T[] JAOFFCELONG) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x2C4F650", Offset = "0x2C4DE50", VA = "0x182C4F650")]
	public static void NKMLJFAHBAN<T>(T GNHCOHKDBJO) where T : notnull, Enum
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
