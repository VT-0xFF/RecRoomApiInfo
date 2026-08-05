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
		[Cpp2IlInjected.Address(RVA = "0xA2B980", Offset = "0xA2AB80", VA = "0x180A2B980")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CB2730", Offset = "0x7CB1930", VA = "0x187CB2730")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA2C560", Offset = "0xA2B760", VA = "0x180A2C560")]
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
		[Cpp2IlInjected.Address(RVA = "0xA2C5A0", Offset = "0xA2B7A0", VA = "0x180A2C5A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CB2D30", Offset = "0x7CB1F30", VA = "0x187CB2D30", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x274B560", Offset = "0x274A760", VA = "0x18274B560")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum PNMOLJIHOMJ
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	NameAZ,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	NameZA,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	InkCostAsc,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	InkCostDesc,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Oldest,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Newest
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface MFEHDDFJMCH<TData, TReturn>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TReturn MMFKPDFDDNB(TData KFMNDOMPAMC);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface IOGODNHMPHN<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ClearHoverTarget(CFBOHJABBND BFJOJAAHPGA);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool SetHoverTarget(TData LBPEJPMBIKP, Collider OBEOLIKGMPM, CFBOHJABBND BFJOJAAHPGA, [Optional] CHMGPECIKJJ? EBPPDJJALJI);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool TryGetHoverTarget([Out] TData LBPEJPMBIKP);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetHoverCollider([Out] Collider OBEOLIKGMPM);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface LFEFAHACEOE<TData> : DMOFFACPOKO, CEAMMONDCNI<TData>, EEMPGFDMKGK<TData>, JMLNHMHHKCD<TData>, EPELKOLKNBM, CAHFHNEIFLD<TData>, CLMENJOHMDN, GFIJEPOKEEP
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface CAHFHNEIFLD<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 JJNJIAILJKL, Vector3 JBACNGDELHL, float ADBCFFBIBMG, [Out] T AJFLCMHLIHL, [Out] Vector3 JEFJGJJMNGO, [Out] Collider OBEOLIKGMPM);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 JJNJIAILJKL, Vector3 JBACNGDELHL, float NGPAEGFCLJG, float ADBCFFBIBMG, T[] NNCEDEJMGCM, [Out] Vector3 GKDNPDOLIFG, [Out] Collider FHKBPABKDOA);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 JJNJIAILJKL, float NGPAEGFCLJG, Vector3 LPNJLMJBDKG, T[] NNCEDEJMGCM);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetObjectFromColliderInCurrentScope(Collider GNJLDOJGEEN, [Out] T PNDMJOBLPFI);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface DMOFFACPOKO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Bounds JMKGOPKFDIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Transform PGLJONGKCOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Bounds KMLLNPIIKDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Transform FAACOAPKGOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Vector3 JIMDGBOMMFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool EPCOMMAHDLP
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
	void SetSelectionBoundsDirty(bool HLADGMIOEII = true, int LHCONPAJJPH = 0);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ShouldHideSelectionBoundsPreview(bool LAOIJGFKDJP, object CCLFNPCGNED);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface GFIJEPOKEEP
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	EPHHEFDKGKL GCKBODEBFHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface MNDBNDOEDFB
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool JJCONEAFAFM
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool MMMIFEPNBHG
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool BLFEBCIJKJN
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
	void TrySetPreviousCloneMapping(Dictionary<Guid, Guid> OCOILJGFHMA);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface JMLNHMHHKCD<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool GFGLFIGBBNK
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int ABMIADOGFIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<TData> ELAEOCAKIDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData LHNFJLFIPMG);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData LHNFJLFIPMG);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface CEAMMONDCNI<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T KFMNDOMPAMC, [Optional] CHMGPECIKJJ? LANBPNACLHP, bool LBIDABNJPEH = true);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int OCEHNHGKKJH, IEnumerable<T> FKMJIBCPIPI, bool LBIDABNJPEH = true);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int OCEHNHGKKJH, IEnumerable<T> FKMJIBCPIPI, CHMGPECIKJJ LANBPNACLHP, bool LBIDABNJPEH = true);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface CLMENJOHMDN
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface EPELKOLKNBM
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool PBNCPGNBGOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool ELALOMKJOIA
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool DHIEELKLFON
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool MCJKHJAJACE
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct DEOGJGIBLIN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public bool EEKIBCJBNIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public float? ELNPCEENJHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public float? DHDCAMHJJHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public float? GLBDLGJKHKM;
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct HIBDKDBKGOK<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public IEnumerable<TData> NHNONNLNCGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public DEOGJGIBLIN NFPGPBMMJFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public bool IKOKGKJFJBL;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4CA8490", Offset = "0x4CA7690", VA = "0x184CA8490")]
	public HIBDKDBKGOK(IEnumerable<TData> FBNDONAGNIN, bool GOMJKGFNIPI, float? AKEEEPHNNMB, float? CFPNMKPLIJH, float? PIIGFHCECGF, bool IKOKGKJFJBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface BFLLCGDKKHO<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FAIPCIDKNKC([In] HIBDKDBKGOK<TData> CCEPNMMABPI);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class MLDPAIKBPDI<TData> : MIILPANGGCA<BFLLCGDKKHO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly HIBDKDBKGOK<TData> CCEPNMMABPI;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x542A620", Offset = "0x5429820", VA = "0x18542A620")]
	public MLDPAIKBPDI(IEnumerable<TData> FBNDONAGNIN, bool GOMJKGFNIPI, float? AKEEEPHNNMB, float? CFPNMKPLIJH, float? PIIGFHCECGF, bool IKOKGKJFJBL, BFLLCGDKKHO<TData> NHMNHKCABDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4B321F0", Offset = "0x4B313F0", VA = "0x184B321F0", Slot = "4")]
	public override bool FAIPCIDKNKC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct IEAHEDPJNGK<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public IEnumerable<TData> NHNONNLNCGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public string IKDJHDDNPBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public bool OACGFJLEBPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public bool IKOKGKJFJBL;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4DAC500", Offset = "0x4DAB700", VA = "0x184DAC500")]
	public IEAHEDPJNGK(IEnumerable<TData> FBNDONAGNIN, string OFLIHBONFIK, bool JNONMDKOCIL, bool IKOKGKJFJBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface MMIPACMJBBK<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FAIPCIDKNKC([In] IEAHEDPJNGK<TData> CCEPNMMABPI);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class GCBDDMAGMAA<TData> : MIILPANGGCA<MMIPACMJBBK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly IEAHEDPJNGK<TData> CCEPNMMABPI;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4BF0B00", Offset = "0x4BEFD00", VA = "0x184BF0B00")]
	public GCBDDMAGMAA(IEnumerable<TData> FBNDONAGNIN, string OFLIHBONFIK, bool JNONMDKOCIL, bool IKOKGKJFJBL, MMIPACMJBBK<TData> NHMNHKCABDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x4B321F0", Offset = "0x4B313F0", VA = "0x184B321F0", Slot = "4")]
	public override bool FAIPCIDKNKC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public abstract class MIILPANGGCA<TReceiver> : FBOKJNOIBNC<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4201740", Offset = "0x4200940", VA = "0x184201740")]
	public MIILPANGGCA(TReceiver NHMNHKCABDL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public abstract class POCFOKOPGPJ<TReceiver, TFromTask> : FBOKJNOIBNC<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4201740", Offset = "0x4200940", VA = "0x184201740")]
	public POCFOKOPGPJ(TReceiver NHMNHKCABDL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class FBOKJNOIBNC<TReceiver, TFromExecute> where TReceiver : notnull where TFromExecute : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	protected TReceiver NHMNHKCABDL;

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4B224C0", Offset = "0x4B216C0", VA = "0x184B224C0")]
	public FBOKJNOIBNC(TReceiver NHMNHKCABDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute FAIPCIDKNKC();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class MEEGCABCPOE<TReceiver, TResult> : FBOKJNOIBNC<TReceiver, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4201740", Offset = "0x4200940", VA = "0x184201740")]
	public MEEGCABCPOE(TReceiver NHMNHKCABDL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct KDFAGONOEKN<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public TGroup KIFAPJCHMMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public TData KABDFDKMMIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public IEnumerable<TData> NHNONNLNCGI;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x22BF070", Offset = "0x22BE270", VA = "0x1822BF070")]
	public KDFAGONOEKN(TGroup CLFCKBKDJMM, TData GGGBBKKFDDA, IEnumerable<TData> FBNDONAGNIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct BMBHEHBAJGF<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public TGroup KIFAPJCHMMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public IEnumerable<TData> NHNONNLNCGI;

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0xB268B0", Offset = "0xB25AB0", VA = "0x180B268B0")]
	public BMBHEHBAJGF(TGroup CLFCKBKDJMM, IEnumerable<TData> FBNDONAGNIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct OJGGJPELHJE<TGroup> where TGroup : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public TGroup KIFAPJCHMMM;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0xD91890", Offset = "0xD90A90", VA = "0x180D91890")]
	public OJGGJPELHJE(TGroup CLFCKBKDJMM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct PBNLBOFKELP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public IEnumerable<Guid> NHNONNLNCGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public Guid HALFDJLIJFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly bool MINPJDGPDIP;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7CB29E0", Offset = "0x7CB1BE0", VA = "0x187CB29E0")]
	public PBNLBOFKELP(IEnumerable<Guid> FBNDONAGNIN, Guid FLGKMFBPAHD, bool IKOKGKJFJBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public struct LMBFALCHLPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public Guid HALFDJLIJFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly bool MINPJDGPDIP;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x26D0E10", Offset = "0x26D0010", VA = "0x1826D0E10")]
	public LMBFALCHLPC(Guid FLGKMFBPAHD, bool IKOKGKJFJBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface IKKEGAOGMKH<TGroup, TData>
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HKNGFJMBJPH LLCNGENIIGD(KDFAGONOEKN<TGroup, TData> PCHGPHKHMNG);

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HKNGFJMBJPH BEHIKNIEGLM(KDFAGONOEKN<TGroup, TData> PCHGPHKHMNG);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HKNGFJMBJPH LGMCPMIDFDP(BMBHEHBAJGF<TGroup, TData> PCHGPHKHMNG);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "3")]
	HKNGFJMBJPH IIIBNOGCMLP(OJGGJPELHJE<TGroup> PCHGPHKHMNG);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface OCENEMLHAEP
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<HKNGFJMBJPH> LLCNGENIIGD(PBNLBOFKELP PCHGPHKHMNG);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<HKNGFJMBJPH> BEHIKNIEGLM(LMBFALCHLPC PCHGPHKHMNG);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class DDNJFFMIFNP<TGroup, TData> : MEEGCABCPOE<IKKEGAOGMKH<TGroup, TData>, HKNGFJMBJPH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly BMBHEHBAJGF<TGroup, TData> PCHGPHKHMNG;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x4205FB0", Offset = "0x42051B0", VA = "0x184205FB0")]
	public DDNJFFMIFNP(TGroup CLFCKBKDJMM, IEnumerable<TData> FBNDONAGNIN, IKKEGAOGMKH<TGroup, TData> NHMNHKCABDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x4205EE0", Offset = "0x42050E0", VA = "0x184205EE0", Slot = "4")]
	public override HKNGFJMBJPH FAIPCIDKNKC()
	{
		return default(HKNGFJMBJPH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class GELADFFHFFH<TGroup, TData> : MEEGCABCPOE<IKKEGAOGMKH<TGroup, TData>, HKNGFJMBJPH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly KDFAGONOEKN<TGroup, TData> PCHGPHKHMNG;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x4BFB8C0", Offset = "0x4BFAAC0", VA = "0x184BFB8C0")]
	public GELADFFHFFH(TGroup CLFCKBKDJMM, TData PFDBPKBKMGP, IEnumerable<TData> FBNDONAGNIN, IKKEGAOGMKH<TGroup, TData> NHMNHKCABDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x4BFB7F0", Offset = "0x4BFA9F0", VA = "0x184BFB7F0", Slot = "4")]
	public override HKNGFJMBJPH FAIPCIDKNKC()
	{
		return default(HKNGFJMBJPH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class DNJMAHHMBLJ<TGroup, TData> : MEEGCABCPOE<IKKEGAOGMKH<TGroup, TData>, HKNGFJMBJPH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly OJGGJPELHJE<TGroup> PCHGPHKHMNG;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x4235B90", Offset = "0x4234D90", VA = "0x184235B90")]
	public DNJMAHHMBLJ(TGroup CLFCKBKDJMM, IKKEGAOGMKH<TGroup, TData> NHMNHKCABDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x4235AC0", Offset = "0x4234CC0", VA = "0x184235AC0", Slot = "4")]
	public override HKNGFJMBJPH FAIPCIDKNKC()
	{
		return default(HKNGFJMBJPH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class BGCPCFHCCHL<TGroup, TData> : MEEGCABCPOE<IKKEGAOGMKH<TGroup, TData>, HKNGFJMBJPH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly KDFAGONOEKN<TGroup, TData> PCHGPHKHMNG;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4BFB8C0", Offset = "0x4BFAAC0", VA = "0x184BFB8C0")]
	public BGCPCFHCCHL(TGroup CLFCKBKDJMM, TData GGGBBKKFDDA, IEnumerable<TData> FBNDONAGNIN, IKKEGAOGMKH<TGroup, TData> NHMNHKCABDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6193920", Offset = "0x6192B20", VA = "0x186193920", Slot = "4")]
	public override HKNGFJMBJPH FAIPCIDKNKC()
	{
		return default(HKNGFJMBJPH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class BLKMCINFAMO : POCFOKOPGPJ<OCENEMLHAEP, HKNGFJMBJPH>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct JFBKDLBJIEA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public AsyncTaskMethodBuilder<HKNGFJMBJPH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public BLKMCINFAMO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private TaskAwaiter<HKNGFJMBJPH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7CB1990", Offset = "0x7CB0B90", VA = "0x187CB1990", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7CB1C30", Offset = "0x7CB0E30", VA = "0x187CB1C30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private PBNLBOFKELP PCHGPHKHMNG;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7CB0E10", Offset = "0x7CB0010", VA = "0x187CB0E10")]
	public BLKMCINFAMO(IEnumerable<Guid> IJIEGOMHNGE, Guid FLGKMFBPAHD, bool IKOKGKJFJBL, OCENEMLHAEP NHMNHKCABDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7CB0D20", Offset = "0x7CAFF20", VA = "0x187CB0D20", Slot = "4")]
	[AsyncStateMachine(typeof(JFBKDLBJIEA))]
	public override Task<HKNGFJMBJPH> FAIPCIDKNKC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class CLOJIABMAJP : POCFOKOPGPJ<OCENEMLHAEP, HKNGFJMBJPH>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private struct PNEOOPAOHDP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public AsyncTaskMethodBuilder<HKNGFJMBJPH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public CLOJIABMAJP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private TaskAwaiter<HKNGFJMBJPH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7CB2A20", Offset = "0x7CB1C20", VA = "0x187CB2A20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7CB2CC0", Offset = "0x7CB1EC0", VA = "0x187CB2CC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly LMBFALCHLPC PCHGPHKHMNG;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7CB13A0", Offset = "0x7CB05A0", VA = "0x187CB13A0")]
	public CLOJIABMAJP(Guid FLGKMFBPAHD, bool IKOKGKJFJBL, OCENEMLHAEP NHMNHKCABDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7CB12B0", Offset = "0x7CB04B0", VA = "0x187CB12B0", Slot = "4")]
	[AsyncStateMachine(typeof(PNEOOPAOHDP))]
	public override Task<HKNGFJMBJPH> FAIPCIDKNKC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public readonly struct HAPJCGEIFPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly PADBIPDHKNP HGKHFHEDOMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly bool MINPJDGPDIP;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7CB1930", Offset = "0x7CB0B30", VA = "0x187CB1930")]
	public HAPJCGEIFPE(PADBIPDHKNP AIPMNPADAKI, bool IKOKGKJFJBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface POCOJFFMMMG<TSpawnType> where TSpawnType : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> FAIPCIDKNKC(HAPJCGEIFPE PAMKIFGCPNO);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class CDKCABCEJBG<TSpawnType> : POCFOKOPGPJ<POCOJFFMMMG<TSpawnType>, TSpawnType> where TSpawnType : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct IPKOEBKFMHA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public AsyncTaskMethodBuilder<TSpawnType> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public CDKCABCEJBG<TSpawnType> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private TaskAwaiter<TSpawnType> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x4E118A0", Offset = "0x4E10AA0", VA = "0x184E118A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x46586B0", Offset = "0x46578B0", VA = "0x1846586B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly HAPJCGEIFPE PAMKIFGCPNO;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x66CB920", Offset = "0x66CAB20", VA = "0x1866CB920")]
	public CDKCABCEJBG(PADBIPDHKNP AIPMNPADAKI, bool IKOKGKJFJBL, POCOJFFMMMG<TSpawnType> NHMNHKCABDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x66CB830", Offset = "0x66CAA30", VA = "0x1866CB830", Slot = "4")]
	[AsyncStateMachine(typeof(CDKCABCEJBG<>.IPKOEBKFMHA))]
	public override Task<TSpawnType> FAIPCIDKNKC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public readonly struct PADBIPDHKNP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly bool HDIMGIEGILF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly Vector3 NEBGJALNIOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly Vector3 MILMNOPOIGD;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7CB28F0", Offset = "0x7CB1AF0", VA = "0x187CB28F0")]
	public PADBIPDHKNP(Transform MIMMEBCGEMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7CB28C0", Offset = "0x7CB1AC0", VA = "0x187CB28C0")]
	public PADBIPDHKNP(Vector3 BNGNHOGLPHP, Vector3 FICCENLPJEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7CB2890", Offset = "0x7CB1A90", VA = "0x187CB2890")]
	public static PADBIPDHKNP EDIKNCAPOAM()
	{
		return default(PADBIPDHKNP);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7CB2960", Offset = "0x7CB1B60", VA = "0x187CB2960")]
	private PADBIPDHKNP(bool HHCKKDEDDEC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct FLGIGHEFMOF<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public TNode GCPKEIEMJPB;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x4B3D060", Offset = "0x4B3C260", VA = "0x184B3D060")]
	public FLGIGHEFMOF(TNode GCPKEIEMJPB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct KFMPABIPBFC<TNode, TReparentOperations> where TNode : notnull where TReparentOperations : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public TNode NPCPHOEDHLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public TReparentOperations ABCHDHAPLGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public JDLAMNJKGPP HFECCJFACEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly bool MINPJDGPDIP;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x512D3B0", Offset = "0x512C5B0", VA = "0x18512D3B0")]
	public KFMPABIPBFC(TNode NPCPHOEDHLH, TReparentOperations ABCHDHAPLGM, JDLAMNJKGPP HFECCJFACEK, bool IKOKGKJFJBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface HLMIPBMGCBE<TNode, TReparentOperations>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PCCAEOANCEJ([In] FLGIGHEFMOF<TNode> LGOFNLALPGI);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FAKCAAKBAED([In] KFMPABIPBFC<TNode, TReparentOperations> MIFLDGDAMIO);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BNGHDEJMPIG();
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class DJJBMLMADMK<TNode, TReparentOperations> : MIILPANGGCA<HLMIPBMGCBE<TNode, TReparentOperations>>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x4201740", Offset = "0x4200940", VA = "0x184201740")]
	public DJJBMLMADMK(HLMIPBMGCBE<TNode, TReparentOperations> NHMNHKCABDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x42140C0", Offset = "0x42132C0", VA = "0x1842140C0", Slot = "4")]
	public override bool FAIPCIDKNKC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class OLOCGAMJPMG<TNode, TReparentOperations> : MIILPANGGCA<HLMIPBMGCBE<TNode, TReparentOperations>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly KFMPABIPBFC<TNode, TReparentOperations> MIFLDGDAMIO;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x562C2B0", Offset = "0x562B4B0", VA = "0x18562C2B0")]
	public OLOCGAMJPMG(TNode NPCPHOEDHLH, TReparentOperations ABCHDHAPLGM, JDLAMNJKGPP HFECCJFACEK, HLMIPBMGCBE<TNode, TReparentOperations> NHMNHKCABDL, bool IKOKGKJFJBL = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x542E140", Offset = "0x542D340", VA = "0x18542E140", Slot = "4")]
	public override bool FAIPCIDKNKC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class FFIPOBKCHBP<TNode, TReparentOperations> : MIILPANGGCA<HLMIPBMGCBE<TNode, TReparentOperations>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly FLGIGHEFMOF<TNode> LGOFNLALPGI;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x4B322B0", Offset = "0x4B314B0", VA = "0x184B322B0")]
	public FFIPOBKCHBP(TNode GILBMKCOHCE, HLMIPBMGCBE<TNode, TReparentOperations> NHMNHKCABDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x4B321F0", Offset = "0x4B313F0", VA = "0x184B321F0", Slot = "4")]
	public override bool FAIPCIDKNKC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct FDHDJEPMOLK<TSpawnInfo> where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public TSpawnInfo DAEFAIAKPGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public Vector3 FICCENLPJEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public Quaternion NDOBKEDDJAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public float GPOEDAABNAL;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x4B2EE30", Offset = "0x4B2E030", VA = "0x184B2EE30")]
	public FDHDJEPMOLK(TSpawnInfo DAEFAIAKPGM, Vector3 FICCENLPJEL, Quaternion NDOBKEDDJAJ, float GPOEDAABNAL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface ELCKELHOBAN<TSpawnType, TSpawnInfo>
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> ANLGIIBKFHO([In] FDHDJEPMOLK<TSpawnInfo> ADEMKFFHBLI, CancellationToken FHBCOAHILMJ);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class FOFOFKHDIGD<TSpawnType, TSpawnInfo> : POCFOKOPGPJ<ELCKELHOBAN<TSpawnType, TSpawnInfo>, TSpawnType> where TSpawnType : notnull where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly FDHDJEPMOLK<TSpawnInfo> CCEPNMMABPI;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4B45CA0", Offset = "0x4B44EA0", VA = "0x184B45CA0")]
	public FOFOFKHDIGD(TSpawnInfo OIBPOFPBDPA, Vector3 FICCENLPJEL, Quaternion NDOBKEDDJAJ, float GPOEDAABNAL, ELCKELHOBAN<TSpawnType, TSpawnInfo> NHMNHKCABDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x46E00E0", Offset = "0x46DF2E0", VA = "0x1846E00E0", Slot = "4")]
	public override Task<TSpawnType> FAIPCIDKNKC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public readonly struct IEEGNDDJGHB<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly IEnumerable<TData> NHNONNLNCGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly bool MINPJDGPDIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly bool ILAOBMIOBKG;

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x4DAE6B0", Offset = "0x4DAD8B0", VA = "0x184DAE6B0")]
	public IEEGNDDJGHB(IEnumerable<TData> FBNDONAGNIN, bool IKOKGKJFJBL = false, bool FODPNJCCFLN = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface CKJHHPBJDBP<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<HKNGFJMBJPH> CFLDPJEHGDE([In] IEEGNDDJGHB<TData> DOJPNIGFKGB, CancellationToken FHBCOAHILMJ);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class ENACDBMKCJO<TData> : POCFOKOPGPJ<CKJHHPBJDBP<TData>, HKNGFJMBJPH> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly IEEGNDDJGHB<TData> JHEDHELLHKP;

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x46E0250", Offset = "0x46DF450", VA = "0x1846E0250")]
	public ENACDBMKCJO(IEnumerable<TData> FBNDONAGNIN, bool IKOKGKJFJBL, CKJHHPBJDBP<TData> NHMNHKCABDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x46E00E0", Offset = "0x46DF2E0", VA = "0x1846E00E0", Slot = "4")]
	public override Task<HKNGFJMBJPH> FAIPCIDKNKC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public struct LLONJFEEFHL<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly T LBPEJPMBIKP;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x521FDF0", Offset = "0x521EFF0", VA = "0x18521FDF0")]
	public LLONJFEEFHL(T HEHPLNNEOHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface IDGAAIPLCGD<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PCCAEOANCEJ([In] LLONJFEEFHL<T> NOHCFELINDK);

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FAKCAAKBAED();
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface GNKNOICIFNM<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FAIPCIDKNKC([In] FBIPJGIHNHJ<T> KNKPKHBADBM);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public struct FBIPJGIHNHJ<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly T LBPEJPMBIKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly bool FNHCNCLFPGE;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x4B22190", Offset = "0x4B21390", VA = "0x184B22190")]
	public FBIPJGIHNHJ(T HEHPLNNEOHD, bool BJGBCGDCHEI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class PGGJNIKNLJE<T> : MIILPANGGCA<IDGAAIPLCGD<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x4201740", Offset = "0x4200940", VA = "0x184201740")]
	public PGGJNIKNLJE(IDGAAIPLCGD<T> NHMNHKCABDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x56E7BA0", Offset = "0x56E6DA0", VA = "0x1856E7BA0", Slot = "4")]
	public override bool FAIPCIDKNKC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class LLPOFCHPIED<T> : MIILPANGGCA<IDGAAIPLCGD<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly LLONJFEEFHL<T> NOHCFELINDK;

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5221040", Offset = "0x5220240", VA = "0x185221040")]
	public LLPOFCHPIED(T LBPEJPMBIKP, IDGAAIPLCGD<T> NHMNHKCABDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x4B321F0", Offset = "0x4B313F0", VA = "0x184B321F0", Slot = "4")]
	public override bool FAIPCIDKNKC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class ABGODICLBPD<T> : MIILPANGGCA<GNKNOICIFNM<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly FBIPJGIHNHJ<T> KNKPKHBADBM;

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x4BB5A80", Offset = "0x4BB4C80", VA = "0x184BB5A80")]
	public ABGODICLBPD(T LBPEJPMBIKP, bool BJGBCGDCHEI, GNKNOICIFNM<T> NHMNHKCABDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x4B321F0", Offset = "0x4B313F0", VA = "0x184B321F0", Slot = "4")]
	public override bool FAIPCIDKNKC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public struct AFIBEBOLFNE<TData> where TData : notnull, FOPOBCMIAJC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public IEnumerable<TData> NHNONNLNCGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public bool GHJGJCBEFCO;

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x4E4B430", Offset = "0x4E4A630", VA = "0x184E4B430")]
	public AFIBEBOLFNE(IEnumerable<TData> GFFENHAIMEC, bool BEJGPHMIFMF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public struct DDDNNPNNNEA<TData> where TData : notnull, FOPOBCMIAJC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public List<TData> NHNONNLNCGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public List<bool> HKKDLEPMNMN;

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x42019F0", Offset = "0x4200BF0", VA = "0x1842019F0")]
	public DDDNNPNNNEA(List<TData> GFFENHAIMEC, List<bool> ICEFPMBAPDN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface FOPOBCMIAJC
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool IEJKAIGKMEN
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface DNPOOCIFLGM<TData> where TData : FOPOBCMIAJC
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FAIPCIDKNKC([In] AFIBEBOLFNE<TData> JDKPHBBMKNM);

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FAIPCIDKNKC([In] DDDNNPNNNEA<TData> JDKPHBBMKNM);
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface GEAOGNHPPGI<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GPFAAHMGALB(T LBPEJPMBIKP);
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class PJOGDLCHEJO<TData> : MIILPANGGCA<DNPOOCIFLGM<TData>> where TData : notnull, FOPOBCMIAJC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly AFIBEBOLFNE<TData> JDKPHBBMKNM;

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x56F7ED0", Offset = "0x56F70D0", VA = "0x1856F7ED0")]
	public PJOGDLCHEJO(List<TData> FBNDONAGNIN, bool GHJGJCBEFCO, DNPOOCIFLGM<TData> NHMNHKCABDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x4B321F0", Offset = "0x4B313F0", VA = "0x184B321F0", Slot = "4")]
	public override bool FAIPCIDKNKC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class OAEJBNDPHOF<TData> : MIILPANGGCA<DNPOOCIFLGM<TData>> where TData : notnull, FOPOBCMIAJC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly DDDNNPNNNEA<TData> JDKPHBBMKNM;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x55F96D0", Offset = "0x55F88D0", VA = "0x1855F96D0")]
	public OAEJBNDPHOF(List<TData> FBNDONAGNIN, List<bool> HKKDLEPMNMN, DNPOOCIFLGM<TData> NHMNHKCABDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x55F9610", Offset = "0x55F8810", VA = "0x1855F9610", Slot = "4")]
	public override bool FAIPCIDKNKC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public interface BJLNAHBKDFA<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<HKNGFJMBJPH> FAIPCIDKNKC(HMFJDIGDHNF<TData> CMGPIACFKAI);
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class DJLKHKBOFLD<TData> : POCFOKOPGPJ<BJLNAHBKDFA<TData>, HKNGFJMBJPH> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private struct BOKHIHAPCGH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public AsyncTaskMethodBuilder<HKNGFJMBJPH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public DJLKHKBOFLD<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private TaskAwaiter<HKNGFJMBJPH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x63421A0", Offset = "0x63413A0", VA = "0x1863421A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6342480", Offset = "0x6341680", VA = "0x186342480", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly HMFJDIGDHNF<TData> NIFJLHLDCHL;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x42172A0", Offset = "0x42164A0", VA = "0x1842172A0")]
	public DJLKHKBOFLD(TData JLOKGJBCEAA, IReadOnlyList<TData> NALNANPLMKJ, bool IKOKGKJFJBL, BJLNAHBKDFA<TData> NHMNHKCABDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x42171A0", Offset = "0x42163A0", VA = "0x1842171A0", Slot = "4")]
	[AsyncStateMachine(typeof(DJLKHKBOFLD<>.BOKHIHAPCGH))]
	public override Task<HKNGFJMBJPH> FAIPCIDKNKC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct HMFJDIGDHNF<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public TData MHLEIPIFNCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public IReadOnlyList<TData> ADKKMBPPLEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public bool MINPJDGPDIP;

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2DCF3F0", Offset = "0x2DCE5F0", VA = "0x182DCF3F0")]
	public HMFJDIGDHNF(TData JLOKGJBCEAA, IReadOnlyList<TData> NALNANPLMKJ, bool IKOKGKJFJBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public interface KMGOGGLGCBM<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FAIPCIDKNKC([In] DMBBEPOBOJO<TData> DGFMDLGNJOD);
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public interface FPMGPGLDMHL<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FAIPCIDKNKC([In] LKBOLKBPLKN<TData> DGFMDLGNJOD);
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface EBJDOIBCBMA<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JLDMIDANIBJ([In] ELNFPMDCHPD<TData> DGFMDLGNJOD);

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FAKCAAKBAED();
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class NMKDCBJJMAF<TData> : MIILPANGGCA<KMGOGGLGCBM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly DMBBEPOBOJO<TData> DGFMDLGNJOD;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x54A63E0", Offset = "0x54A55E0", VA = "0x1854A63E0")]
	public NMKDCBJJMAF(IEnumerable<TData> FBNDONAGNIN, IPAPAOLOGOE NEMIFEKMDAI, JMKIOIDBFKN ADKDGJDNNAD, float EMKPAGDHIHO, string? OFLIHBONFIK, bool OHLOBEFBMGF, bool IKOKGKJFJBL, KMGOGGLGCBM<TData> NHMNHKCABDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x4B321F0", Offset = "0x4B313F0", VA = "0x184B321F0", Slot = "4")]
	public override bool FAIPCIDKNKC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class LKNKPPEHCOP<TData> : MIILPANGGCA<FPMGPGLDMHL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly LKBOLKBPLKN<TData> DGFMDLGNJOD;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x521CE10", Offset = "0x521C010", VA = "0x18521CE10")]
	public LKNKPPEHCOP(TData[] FBNDONAGNIN, IPAPAOLOGOE[] NEMIFEKMDAI, JMKIOIDBFKN[] ADKDGJDNNAD, float[] EMKPAGDHIHO, FPMGPGLDMHL<TData> NHMNHKCABDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x513BB20", Offset = "0x513AD20", VA = "0x18513BB20", Slot = "4")]
	public override bool FAIPCIDKNKC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class BNKHEOPGHDG<TData> : MIILPANGGCA<EBJDOIBCBMA<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x4201740", Offset = "0x4200940", VA = "0x184201740")]
	public BNKHEOPGHDG(EBJDOIBCBMA<TData> NHMNHKCABDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x633E870", Offset = "0x633DA70", VA = "0x18633E870", Slot = "4")]
	public override bool FAIPCIDKNKC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class KKJDMEFGJML<TData> : MIILPANGGCA<EBJDOIBCBMA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly ELNFPMDCHPD<TData> DGFMDLGNJOD;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x513BBE0", Offset = "0x513ADE0", VA = "0x18513BBE0")]
	public KKJDMEFGJML(IEnumerable<TData> FBNDONAGNIN, IPAPAOLOGOE NEMIFEKMDAI, JMKIOIDBFKN ADKDGJDNNAD, float EMKPAGDHIHO, EBJDOIBCBMA<TData> NHMNHKCABDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x513BB20", Offset = "0x513AD20", VA = "0x18513BB20", Slot = "4")]
	public override bool FAIPCIDKNKC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public struct DMBBEPOBOJO<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public IEnumerable<TData> NHNONNLNCGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public IPAPAOLOGOE IDDHCGFKLED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public JMKIOIDBFKN MLKDHMPMIKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public float ICLFNBIPKFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public string? IKDJHDDNPBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public bool? JBAOHKBIMPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public bool MINPJDGPDIP;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x422AB10", Offset = "0x4229D10", VA = "0x18422AB10")]
	public DMBBEPOBOJO(IEnumerable<TData> FBNDONAGNIN, IPAPAOLOGOE NEMIFEKMDAI, JMKIOIDBFKN ADKDGJDNNAD, float EMKPAGDHIHO, string? OFLIHBONFIK, bool? OHLOBEFBMGF, bool IKOKGKJFJBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public struct LKBOLKBPLKN<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public TData[] NHNONNLNCGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public IPAPAOLOGOE[] IDDHCGFKLED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public JMKIOIDBFKN[] MLKDHMPMIKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public float[] EMKPAGDHIHO;

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x521BB90", Offset = "0x521AD90", VA = "0x18521BB90")]
	public LKBOLKBPLKN(TData[] FBNDONAGNIN, IPAPAOLOGOE[] NEMIFEKMDAI, JMKIOIDBFKN[] ADKDGJDNNAD, float[] EMKPAGDHIHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct ELNFPMDCHPD<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public IEnumerable<TData> NHNONNLNCGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public IPAPAOLOGOE IDDHCGFKLED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public JMKIOIDBFKN MLKDHMPMIKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public float EMKPAGDHIHO;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x46DF9E0", Offset = "0x46DEBE0", VA = "0x1846DF9E0")]
	public ELNFPMDCHPD(IEnumerable<TData> FBNDONAGNIN, IPAPAOLOGOE NEMIFEKMDAI, JMKIOIDBFKN ADKDGJDNNAD, float EMKPAGDHIHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface EEMPGFDMKGK<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LGMCPMIDFDP([In] BEBFAHEJOPD<TData> DOJPNIGFKGB);

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IIIBNOGCMLP([In] BEBFAHEJOPD<TData> DOJPNIGFKGB);

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MKAFKDKOOJF([In] bool CJNCBKLICKN);

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool ENOJOALJHGA([In] BEBFAHEJOPD<TData> DOJPNIGFKGB);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JGKBPPGAFFF();

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool DKPNEDLMLHJ([In] TData GLBDCINLOEF);
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class AIGBIMJOFAF<TData> : MIILPANGGCA<EEMPGFDMKGK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly BEBFAHEJOPD<TData> DOJPNIGFKGB;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x4F28CE0", Offset = "0x4F27EE0", VA = "0x184F28CE0")]
	public AIGBIMJOFAF(List<TData> ICAAOCBKPPE, EEMPGFDMKGK<TData> NHMNHKCABDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x4B321F0", Offset = "0x4B313F0", VA = "0x184B321F0", Slot = "4")]
	public override bool FAIPCIDKNKC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class KOHGFGDHDDF<TData> : MIILPANGGCA<EEMPGFDMKGK<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4201740", Offset = "0x4200940", VA = "0x184201740")]
	public KOHGFGDHDDF(EEMPGFDMKGK<TData> NHMNHKCABDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x5168200", Offset = "0x5167400", VA = "0x185168200", Slot = "4")]
	public override bool FAIPCIDKNKC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class DNCDLDINDBO<TData> : MIILPANGGCA<EEMPGFDMKGK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly bool IKOKGKJFJBL;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x42322D0", Offset = "0x42314D0", VA = "0x1842322D0")]
	public DNCDLDINDBO(bool IKOKGKJFJBL, EEMPGFDMKGK<TData> NHMNHKCABDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x4232270", Offset = "0x4231470", VA = "0x184232270", Slot = "4")]
	public override bool FAIPCIDKNKC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class CMGDCCEODKG<TData> : MIILPANGGCA<EEMPGFDMKGK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly BEBFAHEJOPD<TData> DOJPNIGFKGB;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6872740", Offset = "0x6871940", VA = "0x186872740")]
	public CMGDCCEODKG(List<TData> ICAAOCBKPPE, bool IKOKGKJFJBL, EEMPGFDMKGK<TData> NHMNHKCABDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x55F9610", Offset = "0x55F8810", VA = "0x1855F9610", Slot = "4")]
	public override bool FAIPCIDKNKC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class MHBHBCOIAJH<TData> : MIILPANGGCA<EEMPGFDMKGK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly TData GLBDCINLOEF;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x5409850", Offset = "0x5408A50", VA = "0x185409850")]
	public MHBHBCOIAJH(TData GLBDCINLOEF, EEMPGFDMKGK<TData> NHMNHKCABDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x54096D0", Offset = "0x54088D0", VA = "0x1854096D0", Slot = "4")]
	public override bool FAIPCIDKNKC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class HBMLCLCAKKO<TData> : MIILPANGGCA<EEMPGFDMKGK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly BEBFAHEJOPD<TData> DOJPNIGFKGB;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x4C97260", Offset = "0x4C96460", VA = "0x184C97260")]
	public HBMLCLCAKKO(IEnumerable<TData> ICAAOCBKPPE, EEMPGFDMKGK<TData> NHMNHKCABDL, bool IKOKGKJFJBL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x4C97190", Offset = "0x4C96390", VA = "0x184C97190", Slot = "4")]
	public override bool FAIPCIDKNKC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public struct BEBFAHEJOPD<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public IEnumerable<TData> NHNONNLNCGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public bool IKOKGKJFJBL;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x618F890", Offset = "0x618EA90", VA = "0x18618F890")]
	public BEBFAHEJOPD(IEnumerable<TData> GFFENHAIMEC, bool OBMCMOFGFJO = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public interface EILGGFLFLGE
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<HKNGFJMBJPH> FAIPCIDKNKC(JFCLPEMDCPM FKDKGMPGNJM);
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class GFPAFAJFHNH : POCFOKOPGPJ<EILGGFLFLGE, HKNGFJMBJPH>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private struct BMCNKNBFIAE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public AsyncTaskMethodBuilder<HKNGFJMBJPH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public GFPAFAJFHNH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private TaskAwaiter<HKNGFJMBJPH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x7CB0ED0", Offset = "0x7CB00D0", VA = "0x187CB0ED0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7CB1150", Offset = "0x7CB0350", VA = "0x187CB1150", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private readonly JFCLPEMDCPM APHFDHDEPHM;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x7CB17A0", Offset = "0x7CB09A0", VA = "0x187CB17A0")]
	public GFPAFAJFHNH(bool IKOKGKJFJBL, EILGGFLFLGE NHMNHKCABDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x7CB16B0", Offset = "0x7CB08B0", VA = "0x187CB16B0", Slot = "4")]
	[AsyncStateMachine(typeof(BMCNKNBFIAE))]
	public override Task<HKNGFJMBJPH> FAIPCIDKNKC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public struct JFCLPEMDCPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public bool MINPJDGPDIP;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x2ACF3E0", Offset = "0x2ACE5E0", VA = "0x182ACF3E0")]
	public JFCLPEMDCPM(bool IKOKGKJFJBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public readonly struct KEKGCKCPDDJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public readonly bool MEPBCHABLHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public readonly bool EGNKEELPJIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public readonly bool GPOEDAABNAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public readonly bool IKOKGKJFJBL;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5D24F60", Offset = "0x5D24160", VA = "0x185D24F60")]
	public KEKGCKCPDDJ(bool MEPBCHABLHD, bool EGNKEELPJIF, bool GPOEDAABNAL, bool IKOKGKJFJBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7CB1ED0", Offset = "0x7CB10D0", VA = "0x187CB1ED0")]
	public KEKGCKCPDDJ(bool EGNKEELPJIF, bool IKOKGKJFJBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public interface PDHPGDEKIAP
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JEMJLFCFEMO(KEKGCKCPDDJ KCKBHCFGENB);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool AJODOHENBJE(KEKGCKCPDDJ KCKBHCFGENB);
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public class OLADMOJIODP : MIILPANGGCA<PDHPGDEKIAP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly KEKGCKCPDDJ KCKBHCFGENB;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7CB2800", Offset = "0x7CB1A00", VA = "0x187CB2800")]
	public OLADMOJIODP(bool JGOMLHGOKKB, bool EGNKEELPJIF, bool GPOEDAABNAL, bool IKOKGKJFJBL, PDHPGDEKIAP NHMNHKCABDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x7CB27B0", Offset = "0x7CB19B0", VA = "0x187CB27B0", Slot = "4")]
	public override bool FAIPCIDKNKC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public class CLBIBENOLCP : MIILPANGGCA<PDHPGDEKIAP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly KEKGCKCPDDJ KCKBHCFGENB;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7CB1230", Offset = "0x7CB0430", VA = "0x187CB1230")]
	public CLBIBENOLCP(bool EGNKEELPJIF, bool IKOKGKJFJBL, PDHPGDEKIAP NHMNHKCABDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x7CB11E0", Offset = "0x7CB03E0", VA = "0x187CB11E0", Slot = "4")]
	public override bool FAIPCIDKNKC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public interface JKJOEGGDPGH
{
	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FAIPCIDKNKC([In] MGEOOJNIHDG FMOELFFEFMF);
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class DBIEDAHKJNN : MIILPANGGCA<JKJOEGGDPGH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly MGEOOJNIHDG FMOELFFEFMF;

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x7CB14D0", Offset = "0x7CB06D0", VA = "0x187CB14D0")]
	public DBIEDAHKJNN(Guid[] DBLFJEJOGBI, Vector3[] KOHBBKHIEFL, Quaternion[] KMDNAPKCOLC, float[] KHOCNHMDJOH, Dictionary<Guid, Vector3> LLEKPKNDGEL, JKJOEGGDPGH NHMNHKCABDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7CB1420", Offset = "0x7CB0620", VA = "0x187CB1420", Slot = "4")]
	public override bool FAIPCIDKNKC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public interface PEFNNFKLFND<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PCCAEOANCEJ([In] CAKKIMKNOJM<TData> LGOFNLALPGI);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JLDMIDANIBJ([In] CGPNCNALEOP CILMDMFIIGG);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JLDMIDANIBJ([In] LDPCOMACDAG CILMDMFIIGG);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool FAKCAAKBAED();
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class HBIEPPBIKGA<TData> : MIILPANGGCA<PEFNNFKLFND<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x4201740", Offset = "0x4200940", VA = "0x184201740")]
	public HBIEPPBIKGA(PEFNNFKLFND<TData> NHMNHKCABDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x4C97140", Offset = "0x4C96340", VA = "0x184C97140", Slot = "4")]
	public override bool FAIPCIDKNKC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class DIBCKCIFIDD<TData> : MIILPANGGCA<PEFNNFKLFND<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly CGPNCNALEOP PLLJJJKAFDI;

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x42114D0", Offset = "0x42106D0", VA = "0x1842114D0")]
	public DIBCKCIFIDD(Vector3 OMIIHJJPMLA, bool BDOBJJDDIDP, PEFNNFKLFND<TData> NHMNHKCABDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x4200240", Offset = "0x41FF440", VA = "0x184200240", Slot = "4")]
	public override bool FAIPCIDKNKC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public class NPNMKFEMLPI<TData> : MIILPANGGCA<PEFNNFKLFND<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly LDPCOMACDAG PLLJJJKAFDI;

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x54AFC00", Offset = "0x54AEE00", VA = "0x1854AFC00")]
	public NPNMKFEMLPI(Guid ONGOBHPDKAP, int CMDFFDAPDIB, Vector3 FICCENLPJEL, Quaternion NDOBKEDDJAJ, float DKGEGBLOEHH, bool BDOBJJDDIDP, PEFNNFKLFND<TData> NHMNHKCABDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x54AFBA0", Offset = "0x54AEDA0", VA = "0x1854AFBA0", Slot = "4")]
	public override bool FAIPCIDKNKC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class IMABDAFNHKI<TData> : MIILPANGGCA<PEFNNFKLFND<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly CAKKIMKNOJM<TData> PLLJJJKAFDI;

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x4DFAF50", Offset = "0x4DFA150", VA = "0x184DFAF50")]
	public IMABDAFNHKI(TData LBPEJPMBIKP, bool IKOKGKJFJBL, PEFNNFKLFND<TData> NHMNHKCABDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x4B321F0", Offset = "0x4B313F0", VA = "0x184B321F0", Slot = "4")]
	public override bool FAIPCIDKNKC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct CGPNCNALEOP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public readonly Vector3 OMIIHJJPMLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public readonly bool BDOBJJDDIDP;

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7CB11C0", Offset = "0x7CB03C0", VA = "0x187CB11C0")]
	public CGPNCNALEOP(Vector3 OMIIHJJPMLA, bool BDOBJJDDIDP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct LDPCOMACDAG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public readonly Guid ONGOBHPDKAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public readonly int CMDFFDAPDIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public readonly Vector3 FICCENLPJEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public readonly Quaternion NDOBKEDDJAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public readonly float DKGEGBLOEHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public readonly bool BDOBJJDDIDP;

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7CB1EE0", Offset = "0x7CB10E0", VA = "0x187CB1EE0")]
	public LDPCOMACDAG(Guid ONGOBHPDKAP, int CMDFFDAPDIB, Vector3 FICCENLPJEL, Quaternion NDOBKEDDJAJ, float DKGEGBLOEHH, bool BDOBJJDDIDP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public struct CAKKIMKNOJM<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly TData LBPEJPMBIKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public readonly bool IKOKGKJFJBL;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x65EDC00", Offset = "0x65ECE00", VA = "0x1865EDC00")]
	public CAKKIMKNOJM(TData LBPEJPMBIKP, bool IKOKGKJFJBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public interface AHODPGAHFKD<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FAIPCIDKNKC([In] BLPKDJKHIEO<TData> INHFKEMMEPH);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FAIPCIDKNKC([In] PHAOHGGGAEO<TData> INHFKEMMEPH);
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public interface LBLICOPCHAN<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PCCAEOANCEJ([In] HDCILMILPIJ<TData> ANLIAJPJFIN);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JLDMIDANIBJ([In] HOBHFDIFGKD CILMDMFIIGG);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FAKCAAKBAED();
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class AMIEMKLNFBE<TData> : MIILPANGGCA<AHODPGAHFKD<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly BLPKDJKHIEO<TData> INHFKEMMEPH;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x5010960", Offset = "0x500FB60", VA = "0x185010960")]
	public AMIEMKLNFBE(IEnumerable<TData> FBNDONAGNIN, Vector3 IGDBEHCDBML, bool IKOKGKJFJBL, AHODPGAHFKD<TData> NHMNHKCABDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x4B321F0", Offset = "0x4B313F0", VA = "0x184B321F0", Slot = "4")]
	public override bool FAIPCIDKNKC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public class BNKDJJLAJJH<TData> : MIILPANGGCA<LBLICOPCHAN<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x4201740", Offset = "0x4200940", VA = "0x184201740")]
	public BNKDJJLAJJH(LBLICOPCHAN<TData> NHMNHKCABDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x42140C0", Offset = "0x42132C0", VA = "0x1842140C0", Slot = "4")]
	public override bool FAIPCIDKNKC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public class APCKOFHPJLO<TData> : MIILPANGGCA<LBLICOPCHAN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly HDCILMILPIJ<TData> INHFKEMMEPH;

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x501EE60", Offset = "0x501E060", VA = "0x18501EE60")]
	public APCKOFHPJLO(IEnumerable<TData> FBNDONAGNIN, bool IKOKGKJFJBL, LBLICOPCHAN<TData> NHMNHKCABDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x4B321F0", Offset = "0x4B313F0", VA = "0x184B321F0", Slot = "4")]
	public override bool FAIPCIDKNKC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class PELBOGNPOGE<TData> : MIILPANGGCA<AHODPGAHFKD<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly PHAOHGGGAEO<TData> INHFKEMMEPH;

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x56E6720", Offset = "0x56E5920", VA = "0x1856E6720")]
	public PELBOGNPOGE(IEnumerable<TData> FBNDONAGNIN, Vector3 DDDCKEGLKNF, KNEFAIJDCDO EBFNPOBJLGF, bool IKOKGKJFJBL, AHODPGAHFKD<TData> NHMNHKCABDL, Space ELMELNLNKLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x542E140", Offset = "0x542D340", VA = "0x18542E140", Slot = "4")]
	public override bool FAIPCIDKNKC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class DEBLPOBFFIF<TData> : MIILPANGGCA<LBLICOPCHAN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly HOBHFDIFGKD INHFKEMMEPH;

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x4206430", Offset = "0x4205630", VA = "0x184206430")]
	public DEBLPOBFFIF(Vector3 IGDBEHCDBML, LBLICOPCHAN<TData> NHMNHKCABDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x4200240", Offset = "0x41FF440", VA = "0x184200240", Slot = "4")]
	public override bool FAIPCIDKNKC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct BLPKDJKHIEO<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public readonly IEnumerable<TData> FBNDONAGNIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public readonly Vector3 IGDBEHCDBML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public readonly bool IKOKGKJFJBL;

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x62749D0", Offset = "0x6273BD0", VA = "0x1862749D0")]
	public BLPKDJKHIEO(IEnumerable<TData> FBNDONAGNIN, Vector3 IGDBEHCDBML, bool IKOKGKJFJBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public struct HDCILMILPIJ<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public readonly IEnumerable<TData> FBNDONAGNIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public readonly bool IKOKGKJFJBL;

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x4C999C0", Offset = "0x4C98BC0", VA = "0x184C999C0")]
	public HDCILMILPIJ(IEnumerable<TData> FBNDONAGNIN, bool IKOKGKJFJBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public struct PHAOHGGGAEO<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public readonly IEnumerable<TData> FBNDONAGNIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public readonly Vector3 DDDCKEGLKNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public readonly KNEFAIJDCDO EBFNPOBJLGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public readonly bool IKOKGKJFJBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public readonly Space ELMELNLNKLH;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x56E8290", Offset = "0x56E7490", VA = "0x1856E8290")]
	public PHAOHGGGAEO(IEnumerable<TData> FBNDONAGNIN, Vector3 DDDCKEGLKNF, KNEFAIJDCDO EBFNPOBJLGF, bool IKOKGKJFJBL, Space ELMELNLNKLH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public struct HOBHFDIFGKD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public readonly Vector3 IGDBEHCDBML;

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x2ACF310", Offset = "0x2ACE510", VA = "0x182ACF310")]
	public HOBHFDIFGKD(Vector3 IGDBEHCDBML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public enum KNEFAIJDCDO
{
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	XYZ,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	X_only,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	Y_only,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	Z_only
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public interface NNFBGENBDNE
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FAIPCIDKNKC([In] DKAEBEJMGCN BMJDEKJKKLF);
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public class GNJFPBMBBOK : MIILPANGGCA<NNFBGENBDNE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private readonly DKAEBEJMGCN BMJDEKJKKLF;

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x7CB18D0", Offset = "0x7CB0AD0", VA = "0x187CB18D0")]
	public GNJFPBMBBOK(bool IKOKGKJFJBL, NNFBGENBDNE NHMNHKCABDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x7CB1820", Offset = "0x7CB0A20", VA = "0x187CB1820", Slot = "4")]
	public override bool FAIPCIDKNKC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public readonly struct DKAEBEJMGCN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public readonly bool IKOKGKJFJBL;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x2ACF3E0", Offset = "0x2ACE5E0", VA = "0x182ACF3E0")]
	public DKAEBEJMGCN(bool IKOKGKJFJBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public interface AIGMCEHGKDN<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FAIPCIDKNKC([In] FJNAFOCNFHM<TData> PAOOFPCOIDO);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FAIPCIDKNKC([In] OCBPGHEJLCO<TData> PAOOFPCOIDO);
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public interface IBEMIJFNHIO<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PCCAEOANCEJ([In] BKBPFKJBGKM<TData> LGOFNLALPGI);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JLDMIDANIBJ([In] FJIMEBIAODL CILMDMFIIGG);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FAKCAAKBAED();
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class CNECKPAABAI<TData> : MIILPANGGCA<AIGMCEHGKDN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private readonly FJNAFOCNFHM<TData> PAOOFPCOIDO;

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x6875240", Offset = "0x6874440", VA = "0x186875240")]
	public CNECKPAABAI(IEnumerable<TData> FBNDONAGNIN, Quaternion IGDBEHCDBML, Vector3? ANKBJKMBFDI, bool DOJBCMLHKJG, bool IKOKGKJFJBL, AIGMCEHGKDN<TData> NHMNHKCABDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x4B321F0", Offset = "0x4B313F0", VA = "0x184B321F0", Slot = "4")]
	public override bool FAIPCIDKNKC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class NPEIOODLKMD<TData> : MIILPANGGCA<IBEMIJFNHIO<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x4201740", Offset = "0x4200940", VA = "0x184201740")]
	public NPEIOODLKMD(IBEMIJFNHIO<TData> NHMNHKCABDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x42140C0", Offset = "0x42132C0", VA = "0x1842140C0", Slot = "4")]
	public override bool FAIPCIDKNKC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class OBNAIFPPBFC<TData> : MIILPANGGCA<IBEMIJFNHIO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private readonly BKBPFKJBGKM<TData> PAOOFPCOIDO;

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x55FDE40", Offset = "0x55FD040", VA = "0x1855FDE40")]
	public OBNAIFPPBFC(IEnumerable<TData> FBNDONAGNIN, bool IKOKGKJFJBL, IBEMIJFNHIO<TData> NHMNHKCABDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x4B321F0", Offset = "0x4B313F0", VA = "0x184B321F0", Slot = "4")]
	public override bool FAIPCIDKNKC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public class MNKJNFKBEOD<TData> : MIILPANGGCA<AIGMCEHGKDN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly OCBPGHEJLCO<TData> PAOOFPCOIDO;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x542E210", Offset = "0x542D410", VA = "0x18542E210")]
	public MNKJNFKBEOD(IEnumerable<TData> FBNDONAGNIN, Quaternion BJKLBKAGMEH, KNEFAIJDCDO LDKCFJJKMDN, Vector3? ANKBJKMBFDI, bool DOJBCMLHKJG, bool IKOKGKJFJBL, Space ELMELNLNKLH, AIGMCEHGKDN<TData> NHMNHKCABDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x542E140", Offset = "0x542D340", VA = "0x18542E140", Slot = "4")]
	public override bool FAIPCIDKNKC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public class OPODBKFHELF<TData> : MIILPANGGCA<IBEMIJFNHIO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly FJIMEBIAODL PAOOFPCOIDO;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x5634C80", Offset = "0x5633E80", VA = "0x185634C80")]
	public OPODBKFHELF(Quaternion IGDBEHCDBML, Vector3? ANKBJKMBFDI, bool DOJBCMLHKJG, IBEMIJFNHIO<TData> NHMNHKCABDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x4200240", Offset = "0x41FF440", VA = "0x184200240", Slot = "4")]
	public override bool FAIPCIDKNKC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct FJNAFOCNFHM<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public readonly IEnumerable<TData> FBNDONAGNIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public readonly Quaternion IGDBEHCDBML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public readonly Vector3? ANKBJKMBFDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public readonly bool DOJBCMLHKJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public readonly bool IKOKGKJFJBL;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x4B395F0", Offset = "0x4B387F0", VA = "0x184B395F0")]
	public FJNAFOCNFHM(IEnumerable<TData> FBNDONAGNIN, Quaternion IGDBEHCDBML, Vector3? ANKBJKMBFDI, bool DOJBCMLHKJG, bool IKOKGKJFJBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public struct BKBPFKJBGKM<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public readonly IEnumerable<TData> FBNDONAGNIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly bool IKOKGKJFJBL;

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x61A25B0", Offset = "0x61A17B0", VA = "0x1861A25B0")]
	public BKBPFKJBGKM(IEnumerable<TData> FBNDONAGNIN, bool IKOKGKJFJBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct OCBPGHEJLCO<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public readonly IEnumerable<TData> FBNDONAGNIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly Quaternion BJKLBKAGMEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public readonly KNEFAIJDCDO LDKCFJJKMDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public readonly Vector3? ANKBJKMBFDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public readonly bool DOJBCMLHKJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public readonly bool IKOKGKJFJBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public readonly Space ELMELNLNKLH;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x55FE700", Offset = "0x55FD900", VA = "0x1855FE700")]
	public OCBPGHEJLCO(IEnumerable<TData> FBNDONAGNIN, Quaternion BJKLBKAGMEH, KNEFAIJDCDO LDKCFJJKMDN, Vector3? ANKBJKMBFDI, bool DOJBCMLHKJG, bool IKOKGKJFJBL, Space ELMELNLNKLH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public struct FJIMEBIAODL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public readonly Quaternion IGDBEHCDBML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public readonly Vector3? ANKBJKMBFDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public readonly bool DOJBCMLHKJG;

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x5CDBB70", Offset = "0x5CDAD70", VA = "0x185CDBB70")]
	public FJIMEBIAODL(Quaternion IGDBEHCDBML, Vector3? ANKBJKMBFDI, bool DOJBCMLHKJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public interface IAHDKJNEANA<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PCCAEOANCEJ([In] OKHHACLHAAE<TData> LGOFNLALPGI);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JLDMIDANIBJ([In] KEOOMGKDELC CILMDMFIIGG);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JLDMIDANIBJ([In] GNINHEBAHCE CILMDMFIIGG);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JLDMIDANIBJ([In] IIFAOPFJGLD CILMDMFIIGG);

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool FAKCAAKBAED();
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public class KCPDGGPGBII<TData> : MIILPANGGCA<IAHDKJNEANA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private readonly IIFAOPFJGLD OLPHONFIEHP;

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x51295E0", Offset = "0x51287E0", VA = "0x1851295E0")]
	public KCPDGGPGBII(Vector3 MNMOKABEJBK, float CHCCCCJIGOE, Vector3 ANKBJKMBFDI, bool KEFHCKPFPMJ, bool DOAPFLLIIMH, IAHDKJNEANA<TData> NHMNHKCABDL, Space ELMELNLNKLH = Space.Self)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x5129580", Offset = "0x5128780", VA = "0x185129580", Slot = "4")]
	public override bool FAIPCIDKNKC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public class OPHBEOMHLJM<TData> : MIILPANGGCA<IAHDKJNEANA<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x4201740", Offset = "0x4200940", VA = "0x184201740")]
	public OPHBEOMHLJM(IAHDKJNEANA<TData> NHMNHKCABDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x5634AF0", Offset = "0x5633CF0", VA = "0x185634AF0", Slot = "4")]
	public override bool FAIPCIDKNKC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public class PEGJOLPMKHM<TData> : MIILPANGGCA<IAHDKJNEANA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private readonly OKHHACLHAAE<TData> OLPHONFIEHP;

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x56E6520", Offset = "0x56E5720", VA = "0x1856E6520")]
	public PEGJOLPMKHM(IEnumerable<TData> FBNDONAGNIN, bool IKOKGKJFJBL, IAHDKJNEANA<TData> NHMNHKCABDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x4B321F0", Offset = "0x4B313F0", VA = "0x184B321F0", Slot = "4")]
	public override bool FAIPCIDKNKC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public class BEAIBAIBAJO<TData> : MIILPANGGCA<IAHDKJNEANA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private readonly GNINHEBAHCE OLPHONFIEHP;

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x60C79B0", Offset = "0x60C6BB0", VA = "0x1860C79B0")]
	public BEAIBAIBAJO(float BANLMPNABNJ, bool AOIMMBCJOMA, Vector3 ANKBJKMBFDI, IAHDKJNEANA<TData> NHMNHKCABDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x60C78E0", Offset = "0x60C6AE0", VA = "0x1860C78E0", Slot = "4")]
	public override bool FAIPCIDKNKC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public class DCMDPIGMGAK<TData> : MIILPANGGCA<IAHDKJNEANA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly KEOOMGKDELC OLPHONFIEHP;

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x42002A0", Offset = "0x41FF4A0", VA = "0x1842002A0")]
	public DCMDPIGMGAK(float CHCCCCJIGOE, Vector3 ANKBJKMBFDI, IAHDKJNEANA<TData> NHMNHKCABDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x4200240", Offset = "0x41FF440", VA = "0x184200240", Slot = "4")]
	public override bool FAIPCIDKNKC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public struct IIFAOPFJGLD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public readonly Vector3 MNMOKABEJBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public readonly float CHCCCCJIGOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public readonly Vector3 ANKBJKMBFDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public readonly bool BDOBJJDDIDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public readonly Space ELMELNLNKLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public readonly bool DOAPFLLIIMH;

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x7CB1950", Offset = "0x7CB0B50", VA = "0x187CB1950")]
	public IIFAOPFJGLD(Vector3 MNMOKABEJBK, float CHCCCCJIGOE, Vector3 ANKBJKMBFDI, bool BDOBJJDDIDP, bool GMJLOCDEDDB, Space ELMELNLNKLH = Space.Self)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public struct OKHHACLHAAE<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public readonly IEnumerable<TData> FBNDONAGNIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public readonly bool IKOKGKJFJBL;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x561C7F0", Offset = "0x561B9F0", VA = "0x18561C7F0")]
	public OKHHACLHAAE(IEnumerable<TData> FBNDONAGNIN, bool IKOKGKJFJBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public struct GNINHEBAHCE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public readonly float BANLMPNABNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public readonly bool AOIMMBCJOMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public readonly Vector3 ANKBJKMBFDI;

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x7CB1800", Offset = "0x7CB0A00", VA = "0x187CB1800")]
	public GNINHEBAHCE(float BANLMPNABNJ, bool AOIMMBCJOMA, Vector3 ANKBJKMBFDI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public struct KEOOMGKDELC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public readonly float CHCCCCJIGOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public readonly Vector3 ANKBJKMBFDI;

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x5CA0180", Offset = "0x5C9F380", VA = "0x185CA0180")]
	public KEOOMGKDELC(float CHCCCCJIGOE, Vector3 ANKBJKMBFDI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public struct MGEOOJNIHDG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public readonly Guid[] FBNDONAGNIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public readonly bool ELPLNJIHDFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public readonly bool PBMONCBMIID;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public readonly bool ODMAEDJDALM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public readonly Vector3[] KOHBBKHIEFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public readonly Quaternion[] KMDNAPKCOLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public readonly float[] KHOCNHMDJOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public readonly Dictionary<Guid, Vector3> LLEKPKNDGEL;

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x7CB20F0", Offset = "0x7CB12F0", VA = "0x187CB20F0")]
	public MGEOOJNIHDG(Guid[] DBLFJEJOGBI, Vector3[] KOHBBKHIEFL, Quaternion[] KMDNAPKCOLC, float[] KHOCNHMDJOH, Dictionary<Guid, Vector3> LLEKPKNDGEL, bool ELPLNJIHDFB = true, bool PBMONCBMIID = true, bool ODMAEDJDALM = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7CB1F20", Offset = "0x7CB1120", VA = "0x187CB1F20")]
	private static void MIFLPLIDMCE(Dictionary<Guid, Vector3> LLEKPKNDGEL, int AEBOIICOKOM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public static class NMABAOKJBJM
{
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	private struct KECALOHEFKD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public bool NKJMHLHGNOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public FJCFOKJAKFO MNODBJDILJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public FJCFOKJAKFO LBAGCFEAHMO;
	}

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private static KECALOHEFKD FFDIGKAKBNA;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static CancellationToken KIHNHODFIPC
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x7CB2380", Offset = "0x7CB1580", VA = "0x187CB2380")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	internal static FJCFOKJAKFO MNODBJDILJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x7CB25E0", Offset = "0x7CB17E0", VA = "0x187CB25E0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x7CB2680", Offset = "0x7CB1880", VA = "0x187CB2680")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x7CB24F0", Offset = "0x7CB16F0", VA = "0x187CB24F0")]
	[MGCKGAIBEHC.JIJDPEMKHNE]
	internal static void JEGDMFJDHHB(FJCFOKJAKFO FIBHCOFAFBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x7CB23A0", Offset = "0x7CB15A0", VA = "0x187CB23A0")]
	public static void DNFMCNPCKDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x7CB26E0", Offset = "0x7CB18E0", VA = "0x187CB26E0")]
	private static FJCFOKJAKFO OEFLMPCINDJ(FJCFOKJAKFO KFHCLEDGFOD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public static class IAHAPGJANPJ
{
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	public enum AGGNCCIFJFN
	{
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		ICreationContextObject,
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		Guid
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x3A42AF0", Offset = "0x3A41CF0", VA = "0x183A42AF0")]
	public static void DDKCEMBCJCD<T>(T CAABJDKAONG, AGGNCCIFJFN GDHKDBJPDLG) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3A42A90", Offset = "0x3A41C90", VA = "0x183A42A90")]
	public static void DDKCEMBCJCD<T>(T CAABJDKAONG) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x3A429B0", Offset = "0x3A41BB0", VA = "0x183A429B0")]
	public static void DDKCEMBCJCD<T, TImpl, T>() where T : class where TImpl : notnull, T where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x3A42940", Offset = "0x3A41B40", VA = "0x183A42940")]
	public static void CCBCCBBLNHE<T>(T CAABJDKAONG) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x3A42860", Offset = "0x3A41A60", VA = "0x183A42860")]
	public static T AFHCIICHJIO<T>(AGGNCCIFJFN GDHKDBJPDLG) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x3A42DD0", Offset = "0x3A41FD0", VA = "0x183A42DD0")]
	public static bool LHFIILLJKMI<T>(AGGNCCIFJFN GDHKDBJPDLG, T? MCKODODHENC, [Out][NotNullWhen(true)][MaybeNullWhen(false)] T FAJDLAHHOMA) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x3A42CD0", Offset = "0x3A41ED0", VA = "0x183A42CD0")]
	public static bool JDFHINLOIDO<T>(AGGNCCIFJFN GDHKDBJPDLG, [Out][NotNullWhen(true)][MaybeNullWhen(false)] T MAIECGMOKCJ) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x3A42C30", Offset = "0x3A41E30", VA = "0x183A42C30")]
	public static bool DPKEOELHDCI<T>(AGGNCCIFJFN GDHKDBJPDLG) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x3A42900", Offset = "0x3A41B00", VA = "0x183A42900")]
	public static T AFHCIICHJIO<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x3A42F00", Offset = "0x3A42100", VA = "0x183A42F00")]
	public static bool LHFIILLJKMI<T>(T MCKODODHENC, [Out] T FAJDLAHHOMA) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x3A42900", Offset = "0x3A41B00", VA = "0x183A42900")]
	public static bool DPKEOELHDCI<T>() where T : class
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
internal static class KALGIIBEMBJ
{
	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x7CB1CA0", Offset = "0x7CB0EA0", VA = "0x187CB1CA0")]
	public static void DHMFMDNHKFB(IEnumerable HMOKJIEPKLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x3A9B6B0", Offset = "0x3A9A8B0", VA = "0x183A9B6B0")]
	public static void DHMFMDNHKFB<T>(T[] KBILCKNPAKO) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x3A9B890", Offset = "0x3A9AA90", VA = "0x183A9B890")]
	public static void DHMFMDNHKFB<T>(T GDKPICOHMLK) where T : notnull, Enum
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
