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
		[Cpp2IlInjected.Address(RVA = "0x875650", Offset = "0x874A50", VA = "0x180875650")]
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
		[Cpp2IlInjected.Address(RVA = "0x6938540", Offset = "0x6937940", VA = "0x186938540")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8765E0", Offset = "0x8759E0", VA = "0x1808765E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x876620", Offset = "0x875A20", VA = "0x180876620")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface KALGCKEDJJJ<TData, TReturn>
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TReturn CPIDBHPJDFG(TData LALIGKIKEBM);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface AGDPPMLEEOH<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ClearHoverTarget(IOELDNGKJJG NALKJJCOCLN);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool SetHoverTarget(TData KMCPIOGEAKL, Collider GFALIJGJCNJ, IOELDNGKJJG NALKJJCOCLN, [Optional] FNNEHMDPCHL? LAAJADAICLF);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool TryGetHoverTarget([Out] TData KMCPIOGEAKL);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetHoverCollider([Out] Collider GFALIJGJCNJ);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface MGCIBDNDELA<TData> : ODHHMEDJNCH, IANOBKJBIMP<TData>, LCBGJIOLCFP<TData>, PLEBDHPBHCE<TData>, MGKHCPCCCKD, GGNMKKKCCID<TData>, EIAEOAHPOGN, PMJELIJACME
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface GGNMKKKCCID<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 ONDJJILFCHN, Vector3 EOKIIKENLCD, float LDGBFHOOAML, [Out] T MOBHMONNHJE, [Out] Vector3 JAGNEECKDEN, [Out] Collider GFALIJGJCNJ);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 ONDJJILFCHN, Vector3 EOKIIKENLCD, float LAFFBMEMEKD, float LDGBFHOOAML, T[] FAHGNCHPGAL, [Out] Vector3 DNMKAIAJJOE, [Out] Collider HALGGLHBHDF);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 ONDJJILFCHN, float LAFFBMEMEKD, Vector3 MAPBOLPEHHI, T[] FAHGNCHPGAL);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetObjectFromColliderInCurrentScope(Collider PIBBHKFDPAH, [Out] T GELIJGHDLIJ);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface ODHHMEDJNCH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Bounds JCIOCFJMMJC
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Transform GEHBKKMCLBO
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Bounds JDMKLKEIBDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Transform NFNPCHJGBPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Vector3 EBPNNJECHCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool JENPLACLEPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void SetSelectionBoundsDirty(bool LEOEBHDKFNH = true, int BGAJGNBHLHD = 0);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ShouldHideSelectionBoundsPreview(bool JFFGGJPIEAG, object IAIFDAAIBBN);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface PMJELIJACME
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	IDDBOOGKPOH EKEADLPHBGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface MKHFIFIKNMI
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool DCHBFJFCBKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool LNGKGJBHHDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool DNHIEEKLMHK
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
	void TrySetPreviousCloneMapping(Dictionary<Guid, Guid> FNNIOJLHNPL);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface PLEBDHPBHCE<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool NPPMLACNDGM
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int JDDDAEADEPE
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<TData> MKIHNDIEIKG
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData OFMNHGBOMAP);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData OFMNHGBOMAP);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface IANOBKJBIMP<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T LALIGKIKEBM, [Optional] FNNEHMDPCHL? DJEGNGNMJKL, bool GJDJODPGFFM = true);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int MLMABEGDEJH, IEnumerable<T> DBHKEDICALD, bool GJDJODPGFFM = true);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int MLMABEGDEJH, IEnumerable<T> DBHKEDICALD, FNNEHMDPCHL DJEGNGNMJKL, bool GJDJODPGFFM = true);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface EIAEOAHPOGN
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface MGKHCPCCCKD
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool KLIOEJKMMOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool GKHIJMLAMBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool HCEGOOFKCMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool BGFDJLOMINO
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class LKJJAJLIBPN<TReceiver> : NCILPKMPLNA<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3BFE160", Offset = "0x3BFD560", VA = "0x183BFE160")]
	public LKJJAJLIBPN(TReceiver IFEKGLLMLPF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class CEIAFCAIFPL<TReceiver, TFromTask> : NCILPKMPLNA<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3BFE160", Offset = "0x3BFD560", VA = "0x183BFE160")]
	public CEIAFCAIFPL(TReceiver IFEKGLLMLPF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public abstract class NCILPKMPLNA<TReceiver, TFromExecute> where TReceiver : notnull where TFromExecute : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	protected TReceiver IFEKGLLMLPF;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x44E8C20", Offset = "0x44E8020", VA = "0x1844E8C20")]
	public NCILPKMPLNA(TReceiver IFEKGLLMLPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute NODAGBIOAMB();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public abstract class OJENJNIEIJH<TReceiver, TResult> : NCILPKMPLNA<TReceiver, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3BFE160", Offset = "0x3BFD560", VA = "0x183BFE160")]
	public OJENJNIEIJH(TReceiver IFEKGLLMLPF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct LHKBCFBALBC<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public TGroup MMPBMHOHDOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public TData LFNPILCFBNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public IEnumerable<TData> EKOFBNOPFKD;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1ED7B20", Offset = "0x1ED6F20", VA = "0x181ED7B20")]
	public LHKBCFBALBC(TGroup EKOMHNGAHIN, TData EMMKOPPCNCG, IEnumerable<TData> JHFGNCLBFMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct AFOHALACDAL<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public TGroup MMPBMHOHDOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public IEnumerable<TData> EKOFBNOPFKD;

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0xB83E50", Offset = "0xB83250", VA = "0x180B83E50")]
	public AFOHALACDAL(TGroup EKOMHNGAHIN, IEnumerable<TData> JHFGNCLBFMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct EMAMKDEGBAC<TGroup> where TGroup : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public TGroup MMPBMHOHDOL;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x9FCD70", Offset = "0x9FC170", VA = "0x1809FCD70")]
	public EMAMKDEGBAC(TGroup EKOMHNGAHIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct PLIPGHNOICJ<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public IEnumerable<TData> EKOFBNOPFKD;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x9FCD70", Offset = "0x9FC170", VA = "0x1809FCD70")]
	public PLIPGHNOICJ(IEnumerable<TData> JHFGNCLBFMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface DHJDINMHGEG<TGroup, TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ANBDGDOAINM KENHBNGPMHH(LHKBCFBALBC<TGroup, TData> FLJMIEDPFCL);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ANBDGDOAINM PBJILBOHCHL(LHKBCFBALBC<TGroup, TData> FLJMIEDPFCL);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ANBDGDOAINM KPMPGODCFJP(AFOHALACDAL<TGroup, TData> FLJMIEDPFCL);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "3")]
	ANBDGDOAINM AHPOEOFPKLM(EMAMKDEGBAC<TGroup> FLJMIEDPFCL);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface LDLCLLLFNPG<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<ANBDGDOAINM> KENHBNGPMHH(PLIPGHNOICJ<TData> FLJMIEDPFCL);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class CKHCHGEPDHL<TGroup, TData> : OJENJNIEIJH<DHJDINMHGEG<TGroup, TData>, ANBDGDOAINM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly AFOHALACDAL<TGroup, TData> FLJMIEDPFCL;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5037690", Offset = "0x5036A90", VA = "0x185037690")]
	public CKHCHGEPDHL(TGroup EKOMHNGAHIN, IEnumerable<TData> JHFGNCLBFMN, DHJDINMHGEG<TGroup, TData> IFEKGLLMLPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x50375C0", Offset = "0x50369C0", VA = "0x1850375C0", Slot = "4")]
	public override ANBDGDOAINM NODAGBIOAMB()
	{
		return default(ANBDGDOAINM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class CILDFKJLPDE<TGroup, TData> : OJENJNIEIJH<DHJDINMHGEG<TGroup, TData>, ANBDGDOAINM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly LHKBCFBALBC<TGroup, TData> FLJMIEDPFCL;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x502F670", Offset = "0x502EA70", VA = "0x18502F670")]
	public CILDFKJLPDE(TGroup EKOMHNGAHIN, TData OOMBIJDPPLF, IEnumerable<TData> JHFGNCLBFMN, DHJDINMHGEG<TGroup, TData> IFEKGLLMLPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x502F5A0", Offset = "0x502E9A0", VA = "0x18502F5A0", Slot = "4")]
	public override ANBDGDOAINM NODAGBIOAMB()
	{
		return default(ANBDGDOAINM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class ANBHLLGCBOO<TGroup, TData> : OJENJNIEIJH<DHJDINMHGEG<TGroup, TData>, ANBDGDOAINM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly EMAMKDEGBAC<TGroup> FLJMIEDPFCL;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3D7B8B0", Offset = "0x3D7ACB0", VA = "0x183D7B8B0")]
	public ANBHLLGCBOO(TGroup EKOMHNGAHIN, DHJDINMHGEG<TGroup, TData> IFEKGLLMLPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3D7B7E0", Offset = "0x3D7ABE0", VA = "0x183D7B7E0", Slot = "4")]
	public override ANBDGDOAINM NODAGBIOAMB()
	{
		return default(ANBDGDOAINM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class LBOPICOBBNA<TGroup, TData> : OJENJNIEIJH<DHJDINMHGEG<TGroup, TData>, ANBDGDOAINM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly LHKBCFBALBC<TGroup, TData> FLJMIEDPFCL;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x4229130", Offset = "0x4228530", VA = "0x184229130")]
	public LBOPICOBBNA(TGroup EKOMHNGAHIN, TData EMMKOPPCNCG, IEnumerable<TData> JHFGNCLBFMN, DHJDINMHGEG<TGroup, TData> IFEKGLLMLPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4229050", Offset = "0x4228450", VA = "0x184229050", Slot = "4")]
	public override ANBDGDOAINM NODAGBIOAMB()
	{
		return default(ANBDGDOAINM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class MPMJAIOLBOM<TData> : CEIAFCAIFPL<LDLCLLLFNPG<TData>, ANBDGDOAINM> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private struct LHOGMKPECJC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AsyncTaskMethodBuilder<ANBDGDOAINM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public MPMJAIOLBOM<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private TaskAwaiter<ANBDGDOAINM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x4236080", Offset = "0x4235480", VA = "0x184236080", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x4236320", Offset = "0x4235720", VA = "0x184236320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private PLIPGHNOICJ<TData> FLJMIEDPFCL;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3D7B8B0", Offset = "0x3D7ACB0", VA = "0x183D7B8B0")]
	public MPMJAIOLBOM(IEnumerable<TData> ELOAKPANLEN, LDLCLLLFNPG<TData> IFEKGLLMLPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x448A7C0", Offset = "0x4489BC0", VA = "0x18448A7C0", Slot = "4")]
	[AsyncStateMachine(typeof(MPMJAIOLBOM<>.LHOGMKPECJC))]
	public override Task<ANBDGDOAINM> NODAGBIOAMB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct NDKLDPFFKAJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly MKEHNGEBKNF FABDBFBCMJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly bool FFPCBACKEPK;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6938520", Offset = "0x6937920", VA = "0x186938520")]
	public NDKLDPFFKAJ(MKEHNGEBKNF KKLPIGINHDK, bool EINJIFPLLBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface LLJBHEHJOLB<TSpawnType> where TSpawnType : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> NODAGBIOAMB(NDKLDPFFKAJ GHBOGHECNJD);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class NIANFOKBNKA<TSpawnType> : CEIAFCAIFPL<LLJBHEHJOLB<TSpawnType>, TSpawnType> where TSpawnType : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private struct MAEOIELGGJN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public AsyncTaskMethodBuilder<TSpawnType> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public NIANFOKBNKA<TSpawnType> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskAwaiter<TSpawnType> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x4422A50", Offset = "0x4421E50", VA = "0x184422A50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x4422DF0", Offset = "0x44221F0", VA = "0x184422DF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly NDKLDPFFKAJ GHBOGHECNJD;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x4526A60", Offset = "0x4525E60", VA = "0x184526A60")]
	public NIANFOKBNKA(MKEHNGEBKNF KKLPIGINHDK, bool EINJIFPLLBI, LLJBHEHJOLB<TSpawnType> IFEKGLLMLPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x4526960", Offset = "0x4525D60", VA = "0x184526960", Slot = "4")]
	[AsyncStateMachine(typeof(NIANFOKBNKA<>.MAEOIELGGJN))]
	public override Task<TSpawnType> NODAGBIOAMB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public readonly struct MKEHNGEBKNF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly bool JKCKOEGCJHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly Vector3 APLKKOFGKEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly Vector3 DJODFMOGEFF;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6938020", Offset = "0x6937420", VA = "0x186938020")]
	public MKEHNGEBKNF(Transform LKJGKHMINFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6938090", Offset = "0x6937490", VA = "0x186938090")]
	public MKEHNGEBKNF(Vector3 EKOLOLBNIGP, Vector3 HBGADHMDPAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6937FF0", Offset = "0x69373F0", VA = "0x186937FF0")]
	public static MKEHNGEBKNF KKAHNOCEAJG()
	{
		return default(MKEHNGEBKNF);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x69380C0", Offset = "0x69374C0", VA = "0x1869380C0")]
	private MKEHNGEBKNF(bool KBILPFHCJNN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct JDLDEMALLBN<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public TNode NMBEICELNFL;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x402C830", Offset = "0x402BC30", VA = "0x18402C830")]
	public JDLDEMALLBN(TNode NMBEICELNFL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct PAALNKLNKGA<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public TNode PJNNABKFBMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public GLKLJNJPJNH IBMFAJMFICD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly bool FFPCBACKEPK;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x47C32D0", Offset = "0x47C26D0", VA = "0x1847C32D0")]
	public PAALNKLNKGA(TNode PJNNABKFBMJ, GLKLJNJPJNH IBMFAJMFICD, bool EINJIFPLLBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface OLBEFNFNHAF<TNode>
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JIOEAMAPFFK([In] JDLDEMALLBN<TNode> KMCBLHKNKKF);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool AFPGLACAOAJ([In] PAALNKLNKGA<TNode> MLAIHHILFCK);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FELGMLFAHEC();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class NCLMJIGOPEL<TNode> : LKJJAJLIBPN<OLBEFNFNHAF<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3BFE160", Offset = "0x3BFD560", VA = "0x183BFE160")]
	public NCLMJIGOPEL(OLBEFNFNHAF<TNode> IFEKGLLMLPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x411C7D0", Offset = "0x411BBD0", VA = "0x18411C7D0", Slot = "4")]
	public override bool NODAGBIOAMB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class OPHJNBPMPMM<TNode> : LKJJAJLIBPN<OLBEFNFNHAF<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly PAALNKLNKGA<TNode> MLAIHHILFCK;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x473B360", Offset = "0x473A760", VA = "0x18473B360")]
	public OPHJNBPMPMM(TNode PJNNABKFBMJ, GLKLJNJPJNH IBMFAJMFICD, OLBEFNFNHAF<TNode> IFEKGLLMLPF, bool EINJIFPLLBI = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3C1E850", Offset = "0x3C1DC50", VA = "0x183C1E850", Slot = "4")]
	public override bool NODAGBIOAMB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class BIGKEKJGLPL<TNode> : LKJJAJLIBPN<OLBEFNFNHAF<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly JDLDEMALLBN<TNode> KMCBLHKNKKF;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x4E9DC60", Offset = "0x4E9D060", VA = "0x184E9DC60")]
	public BIGKEKJGLPL(TNode ANGEGEAMNKN, OLBEFNFNHAF<TNode> IFEKGLLMLPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x37E8DA0", Offset = "0x37E81A0", VA = "0x1837E8DA0", Slot = "4")]
	public override bool NODAGBIOAMB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct DADDKCCLDHK<TSpawnInfo> where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public TSpawnInfo NIHJOIIBANO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public Vector3 HBGADHMDPAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Quaternion MGJIDJKDGAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public float MFGJMFBCPKM;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x576CD10", Offset = "0x576C110", VA = "0x18576CD10")]
	public DADDKCCLDHK(TSpawnInfo NIHJOIIBANO, Vector3 HBGADHMDPAD, Quaternion MGJIDJKDGAB, float MFGJMFBCPKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface MGOGDCLMNDD<TSpawnType, TSpawnInfo>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> OKJENLPMJLB([In] DADDKCCLDHK<TSpawnInfo> PAHBKFHDCGK, CancellationToken GNJJGEHBGKC);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class OAAEHICFDEO<TSpawnType, TSpawnInfo> : CEIAFCAIFPL<MGOGDCLMNDD<TSpawnType, TSpawnInfo>, TSpawnType> where TSpawnType : notnull where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly DADDKCCLDHK<TSpawnInfo> JEKDODJMDHN;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x465CAD0", Offset = "0x465BED0", VA = "0x18465CAD0")]
	public OAAEHICFDEO(TSpawnInfo FJPNPCADKKC, Vector3 HBGADHMDPAD, Quaternion MGJIDJKDGAB, float MFGJMFBCPKM, MGOGDCLMNDD<TSpawnType, TSpawnInfo> IFEKGLLMLPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x4423B20", Offset = "0x4422F20", VA = "0x184423B20", Slot = "4")]
	public override Task<TSpawnType> NODAGBIOAMB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct CKPBOBPNOHI<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly IEnumerable<TData> EKOFBNOPFKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly bool FFPCBACKEPK;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5037E50", Offset = "0x5037250", VA = "0x185037E50")]
	public CKPBOBPNOHI(IEnumerable<TData> JHFGNCLBFMN, bool EINJIFPLLBI = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface FFPHDJHLGMD<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<ANBDGDOAINM> ECKPOEFABFC([In] CKPBOBPNOHI<TData> MDGJKDDPIFI, CancellationToken GNJJGEHBGKC);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class MAJDPHONBLO<TData> : CEIAFCAIFPL<FFPHDJHLGMD<TData>, ANBDGDOAINM> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly CKPBOBPNOHI<TData> EPBLNECKCEL;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x4423CA0", Offset = "0x44230A0", VA = "0x184423CA0")]
	public MAJDPHONBLO(IEnumerable<TData> JHFGNCLBFMN, bool EINJIFPLLBI, FFPHDJHLGMD<TData> IFEKGLLMLPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x4423B20", Offset = "0x4422F20", VA = "0x184423B20", Slot = "4")]
	public override Task<ANBDGDOAINM> NODAGBIOAMB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct KEIOJJBBNCM<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public readonly T KMCPIOGEAKL;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x405A3A0", Offset = "0x40597A0", VA = "0x18405A3A0")]
	public KEIOJJBBNCM(T GJPFPLHBMBF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface MHIEOLGKCNH<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JIOEAMAPFFK([In] KEIOJJBBNCM<T> ECOHAFOPOLC);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool AFPGLACAOAJ();
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface PHLGFOLMHIO<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NODAGBIOAMB([In] DHDFLGGEODN<T> JDGMGHAHAHA);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct DHDFLGGEODN<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public readonly T KMCPIOGEAKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public readonly bool EFHOMPMJJNG;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x578BE40", Offset = "0x578B240", VA = "0x18578BE40")]
	public DHDFLGGEODN(T GJPFPLHBMBF, bool AAAMGFKFMLJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class OJBHADJHIKB<T> : LKJJAJLIBPN<MHIEOLGKCNH<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x3BFE160", Offset = "0x3BFD560", VA = "0x183BFE160")]
	public OJBHADJHIKB(MHIEOLGKCNH<T> IFEKGLLMLPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x4706340", Offset = "0x4705740", VA = "0x184706340", Slot = "4")]
	public override bool NODAGBIOAMB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class LBMOJKBMDLN<T> : LKJJAJLIBPN<MHIEOLGKCNH<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly KEIOJJBBNCM<T> ECOHAFOPOLC;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x4228EC0", Offset = "0x42282C0", VA = "0x184228EC0")]
	public LBMOJKBMDLN(T KMCPIOGEAKL, MHIEOLGKCNH<T> IFEKGLLMLPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x37E8DA0", Offset = "0x37E81A0", VA = "0x1837E8DA0", Slot = "4")]
	public override bool NODAGBIOAMB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class MCFPMCIOEAK<T> : LKJJAJLIBPN<PHLGFOLMHIO<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly DHDFLGGEODN<T> JDGMGHAHAHA;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x44285B0", Offset = "0x44279B0", VA = "0x1844285B0")]
	public MCFPMCIOEAK(T KMCPIOGEAKL, bool AAAMGFKFMLJ, PHLGFOLMHIO<T> IFEKGLLMLPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x37E8DA0", Offset = "0x37E81A0", VA = "0x1837E8DA0", Slot = "4")]
	public override bool NODAGBIOAMB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct FGFEMGKKLIE<TData> where TData : notnull, KCAKJAOPOME
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public IEnumerable<TData> EKOFBNOPFKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public bool MBCHGDOPNLP;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x3C10210", Offset = "0x3C0F610", VA = "0x183C10210")]
	public FGFEMGKKLIE(IEnumerable<TData> HFDJCGLECAB, bool JGGEBIHCLEM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct APABOFKHHAL<TData> where TData : notnull, KCAKJAOPOME
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public List<TData> EKOFBNOPFKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public List<bool> AKHELICKKJP;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x3D7D630", Offset = "0x3D7CA30", VA = "0x183D7D630")]
	public APABOFKHHAL(List<TData> HFDJCGLECAB, List<bool> HHDBJNHPCBG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface KCAKJAOPOME
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool JBLGEHABLFM
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
public interface GHIKGONHECJ<TData> where TData : KCAKJAOPOME
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NODAGBIOAMB([In] FGFEMGKKLIE<TData> NPLDCOOLECI);

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NODAGBIOAMB([In] APABOFKHHAL<TData> NPLDCOOLECI);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface JHLHFGMFFIG<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ALILPEDKAJC(T KMCPIOGEAKL);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class FKELHDMBMBL<TData> : LKJJAJLIBPN<GHIKGONHECJ<TData>> where TData : notnull, KCAKJAOPOME
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly FGFEMGKKLIE<TData> NPLDCOOLECI;

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x3C20DA0", Offset = "0x3C201A0", VA = "0x183C20DA0")]
	public FKELHDMBMBL(List<TData> JHFGNCLBFMN, bool MBCHGDOPNLP, GHIKGONHECJ<TData> IFEKGLLMLPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x37E8DA0", Offset = "0x37E81A0", VA = "0x1837E8DA0", Slot = "4")]
	public override bool NODAGBIOAMB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class PPJPEHFGNNM<TData> : LKJJAJLIBPN<GHIKGONHECJ<TData>> where TData : notnull, KCAKJAOPOME
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly APABOFKHHAL<TData> NPLDCOOLECI;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x47F7240", Offset = "0x47F6640", VA = "0x1847F7240")]
	public PPJPEHFGNNM(List<TData> JHFGNCLBFMN, List<bool> AKHELICKKJP, GHIKGONHECJ<TData> IFEKGLLMLPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x4672230", Offset = "0x4671630", VA = "0x184672230", Slot = "4")]
	public override bool NODAGBIOAMB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface PIJNDIMDOPN<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<ANBDGDOAINM> NODAGBIOAMB(MLLNLDOILOK<TData> FGOHNIABOAO);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public class BDAMOHGBJNB<TData> : CEIAFCAIFPL<PIJNDIMDOPN<TData>, ANBDGDOAINM> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct EIGKJGFFGFF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public AsyncTaskMethodBuilder<ANBDGDOAINM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public BDAMOHGBJNB<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter<ANBDGDOAINM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x3808A10", Offset = "0x3807E10", VA = "0x183808A10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x3808CF0", Offset = "0x38080F0", VA = "0x183808CF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly MLLNLDOILOK<TData> FFGGDJDLMKB;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x4E8C410", Offset = "0x4E8B810", VA = "0x184E8C410")]
	public BDAMOHGBJNB(TData GHHKJBJGANB, IReadOnlyList<TData> PHPFFKMCCPM, bool EINJIFPLLBI, PIJNDIMDOPN<TData> IFEKGLLMLPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x4E8C310", Offset = "0x4E8B710", VA = "0x184E8C310", Slot = "4")]
	[AsyncStateMachine(typeof(BDAMOHGBJNB<>.EIGKJGFFGFF))]
	public override Task<ANBDGDOAINM> NODAGBIOAMB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public struct MLLNLDOILOK<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public TData AMPEKLEKEBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public IReadOnlyList<TData> IFKBAPFCCHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public bool FFPCBACKEPK;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x4458D10", Offset = "0x4458110", VA = "0x184458D10")]
	public MLLNLDOILOK(TData GHHKJBJGANB, IReadOnlyList<TData> PHPFFKMCCPM, bool EINJIFPLLBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface INDCIJLOCDN<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NODAGBIOAMB([In] BHOPIHLBPLM<TData> LHKAKMBGJCJ);
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface FCJFPGBJPIA<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NODAGBIOAMB([In] BNEIPLLDNHD<TData> LHKAKMBGJCJ);
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface MDPKENICLPD<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PBEJPLKCIMJ([In] COBCNKPHHLN<TData> LHKAKMBGJCJ);

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AFPGLACAOAJ();
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class KEABIKFOOIM<TData> : LKJJAJLIBPN<INDCIJLOCDN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly BHOPIHLBPLM<TData> LHKAKMBGJCJ;

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x417CC90", Offset = "0x417C090", VA = "0x18417CC90")]
	public KEABIKFOOIM(IEnumerable<TData> JHFGNCLBFMN, PFIKKCHFOII IGDDAGDAAIO, DAJLLIPPJDK JOFMGPCHADM, float LOHDJBCGIAI, bool EINJIFPLLBI, INDCIJLOCDN<TData> IFEKGLLMLPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x37E8DA0", Offset = "0x37E81A0", VA = "0x1837E8DA0", Slot = "4")]
	public override bool NODAGBIOAMB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class MOPEICAFEAO<TData> : LKJJAJLIBPN<FCJFPGBJPIA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly BNEIPLLDNHD<TData> LHKAKMBGJCJ;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x4483C40", Offset = "0x4483040", VA = "0x184483C40")]
	public MOPEICAFEAO(TData[] JHFGNCLBFMN, PFIKKCHFOII[] IGDDAGDAAIO, DAJLLIPPJDK[] JOFMGPCHADM, float[] LOHDJBCGIAI, FCJFPGBJPIA<TData> IFEKGLLMLPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3CFC670", Offset = "0x3CFBA70", VA = "0x183CFC670", Slot = "4")]
	public override bool NODAGBIOAMB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class OIIEANHELFG<TData> : LKJJAJLIBPN<MDPKENICLPD<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3BFE160", Offset = "0x3BFD560", VA = "0x183BFE160")]
	public OIIEANHELFG(MDPKENICLPD<TData> IFEKGLLMLPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x4697810", Offset = "0x4696C10", VA = "0x184697810", Slot = "4")]
	public override bool NODAGBIOAMB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class GCGGDNOJEMK<TData> : LKJJAJLIBPN<MDPKENICLPD<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly COBCNKPHHLN<TData> LHKAKMBGJCJ;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3CFC730", Offset = "0x3CFBB30", VA = "0x183CFC730")]
	public GCGGDNOJEMK(IEnumerable<TData> JHFGNCLBFMN, PFIKKCHFOII IGDDAGDAAIO, DAJLLIPPJDK JOFMGPCHADM, float LOHDJBCGIAI, MDPKENICLPD<TData> IFEKGLLMLPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3CFC670", Offset = "0x3CFBA70", VA = "0x183CFC670", Slot = "4")]
	public override bool NODAGBIOAMB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public struct BHOPIHLBPLM<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public IEnumerable<TData> EKOFBNOPFKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public PFIKKCHFOII NNFOKMMOCCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public DAJLLIPPJDK KEAFBLNCKGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public float LOHDJBCGIAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public bool EINJIFPLLBI;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4E9B6A0", Offset = "0x4E9AAA0", VA = "0x184E9B6A0")]
	public BHOPIHLBPLM(IEnumerable<TData> JHFGNCLBFMN, PFIKKCHFOII IGDDAGDAAIO, DAJLLIPPJDK JOFMGPCHADM, float LOHDJBCGIAI, bool EINJIFPLLBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct BNEIPLLDNHD<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public TData[] EKOFBNOPFKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public PFIKKCHFOII[] NNFOKMMOCCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public DAJLLIPPJDK[] KEAFBLNCKGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public float[] LOHDJBCGIAI;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x4EA47A0", Offset = "0x4EA3BA0", VA = "0x184EA47A0")]
	public BNEIPLLDNHD(TData[] JHFGNCLBFMN, PFIKKCHFOII[] IGDDAGDAAIO, DAJLLIPPJDK[] JOFMGPCHADM, float[] LOHDJBCGIAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public struct COBCNKPHHLN<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public IEnumerable<TData> EKOFBNOPFKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public PFIKKCHFOII NNFOKMMOCCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public DAJLLIPPJDK KEAFBLNCKGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public float LOHDJBCGIAI;

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x503DDA0", Offset = "0x503D1A0", VA = "0x18503DDA0")]
	public COBCNKPHHLN(IEnumerable<TData> JHFGNCLBFMN, PFIKKCHFOII IGDDAGDAAIO, DAJLLIPPJDK JOFMGPCHADM, float LOHDJBCGIAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public interface LCBGJIOLCFP<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KPMPGODCFJP([In] HBEIDKIJJFA<TData> MDGJKDDPIFI);

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AHPOEOFPKLM([In] HBEIDKIJJFA<TData> MDGJKDDPIFI);

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GFLDDNDAFGO([In] bool BBLEHIAKDEG);

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MBNOFAMGABM([In] HBEIDKIJJFA<TData> MDGJKDDPIFI);

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HGAFGAPMFBK();

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool FLGCFCOLGBD([In] TData DICELILBBBN);
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class IGLLDGLHJDB<TData> : LKJJAJLIBPN<LCBGJIOLCFP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly HBEIDKIJJFA<TData> MDGJKDDPIFI;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x3E47470", Offset = "0x3E46870", VA = "0x183E47470")]
	public IGLLDGLHJDB(List<TData> MDKDACOPOHC, LCBGJIOLCFP<TData> IFEKGLLMLPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x37E8DA0", Offset = "0x37E81A0", VA = "0x1837E8DA0", Slot = "4")]
	public override bool NODAGBIOAMB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class OMPJFJOEMGG<TData> : LKJJAJLIBPN<LCBGJIOLCFP<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3BFE160", Offset = "0x3BFD560", VA = "0x183BFE160")]
	public OMPJFJOEMGG(LCBGJIOLCFP<TData> IFEKGLLMLPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x4729660", Offset = "0x4728A60", VA = "0x184729660", Slot = "4")]
	public override bool NODAGBIOAMB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class GGFIEJGGJJI<TData> : LKJJAJLIBPN<LCBGJIOLCFP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly bool EINJIFPLLBI;

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3D0B3D0", Offset = "0x3D0A7D0", VA = "0x183D0B3D0")]
	public GGFIEJGGJJI(bool EINJIFPLLBI, LCBGJIOLCFP<TData> IFEKGLLMLPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3D0B300", Offset = "0x3D0A700", VA = "0x183D0B300", Slot = "4")]
	public override bool NODAGBIOAMB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class OCPHLBGAKLF<TData> : LKJJAJLIBPN<LCBGJIOLCFP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly HBEIDKIJJFA<TData> MDGJKDDPIFI;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x4672390", Offset = "0x4671790", VA = "0x184672390")]
	public OCPHLBGAKLF(List<TData> MDKDACOPOHC, bool EINJIFPLLBI, LCBGJIOLCFP<TData> IFEKGLLMLPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x4672230", Offset = "0x4671630", VA = "0x184672230", Slot = "4")]
	public override bool NODAGBIOAMB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class ANHECENJOLH<TData> : LKJJAJLIBPN<LCBGJIOLCFP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly TData DICELILBBBN;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3D7BEB0", Offset = "0x3D7B2B0", VA = "0x183D7BEB0")]
	public ANHECENJOLH(TData DICELILBBBN, LCBGJIOLCFP<TData> IFEKGLLMLPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3D7BD20", Offset = "0x3D7B120", VA = "0x183D7BD20", Slot = "4")]
	public override bool NODAGBIOAMB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class GFDDBIKMAJP<TData> : LKJJAJLIBPN<LCBGJIOLCFP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly HBEIDKIJJFA<TData> MDGJKDDPIFI;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3D031D0", Offset = "0x3D025D0", VA = "0x183D031D0")]
	public GFDDBIKMAJP(IEnumerable<TData> MDKDACOPOHC, LCBGJIOLCFP<TData> IFEKGLLMLPF, bool EINJIFPLLBI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x3D03100", Offset = "0x3D02500", VA = "0x183D03100", Slot = "4")]
	public override bool NODAGBIOAMB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public struct HBEIDKIJJFA<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public IEnumerable<TData> EKOFBNOPFKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public bool EINJIFPLLBI;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x3D50C40", Offset = "0x3D50040", VA = "0x183D50C40")]
	public HBEIDKIJJFA(IEnumerable<TData> HFDJCGLECAB, bool HDIJMBLBKNH = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public interface BOKMAGOMDAE
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<ANBDGDOAINM> NODAGBIOAMB(GJFCMFDKPAD MGEBCEPBLGK);
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class PGDMEELKHLG : CEIAFCAIFPL<BOKMAGOMDAE, ANBDGDOAINM>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private struct BOHDDEAEGME : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public AsyncTaskMethodBuilder<ANBDGDOAINM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public PGDMEELKHLG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private TaskAwaiter<ANBDGDOAINM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x69373F0", Offset = "0x69367F0", VA = "0x1869373F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6937670", Offset = "0x6936A70", VA = "0x186937670", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly GJFCMFDKPAD PNIOMPKGOEA;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6938940", Offset = "0x6937D40", VA = "0x186938940")]
	public PGDMEELKHLG(bool EINJIFPLLBI, BOKMAGOMDAE IFEKGLLMLPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6938850", Offset = "0x6937C50", VA = "0x186938850", Slot = "4")]
	[AsyncStateMachine(typeof(BOHDDEAEGME))]
	public override Task<ANBDGDOAINM> NODAGBIOAMB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct GJFCMFDKPAD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public bool FFPCBACKEPK;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x21B2C90", Offset = "0x21B2090", VA = "0x1821B2C90")]
	public GJFCMFDKPAD(bool EINJIFPLLBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public readonly struct KALGCOELKPO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly bool COPIDMJKBLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly bool PBBIKHKPBIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public readonly bool MFGJMFBCPKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public readonly bool EINJIFPLLBI;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4D16B40", Offset = "0x4D15F40", VA = "0x184D16B40")]
	public KALGCOELKPO(bool COPIDMJKBLL, bool PBBIKHKPBIC, bool MFGJMFBCPKM, bool EINJIFPLLBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6937EA0", Offset = "0x69372A0", VA = "0x186937EA0")]
	public KALGCOELKPO(bool PBBIKHKPBIC, bool EINJIFPLLBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface MDODJNMNGGA
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FJMCACPNNIN(KALGCOELKPO AOPHDJPNLIO);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PCMLJBHJEMP(KALGCOELKPO AOPHDJPNLIO);
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class MJJEIFLDNEN : LKJJAJLIBPN<MDODJNMNGGA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly KALGCOELKPO AOPHDJPNLIO;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6937F20", Offset = "0x6937320", VA = "0x186937F20")]
	public MJJEIFLDNEN(bool HDODENDDMOJ, bool PBBIKHKPBIC, bool MFGJMFBCPKM, bool EINJIFPLLBI, MDODJNMNGGA IFEKGLLMLPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6937ED0", Offset = "0x69372D0", VA = "0x186937ED0", Slot = "4")]
	public override bool NODAGBIOAMB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class IHMPAHKHGLK : LKJJAJLIBPN<MDODJNMNGGA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly KALGCOELKPO AOPHDJPNLIO;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6937BF0", Offset = "0x6936FF0", VA = "0x186937BF0")]
	public IHMPAHKHGLK(bool PBBIKHKPBIC, bool EINJIFPLLBI, MDODJNMNGGA IFEKGLLMLPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6937BA0", Offset = "0x6936FA0", VA = "0x186937BA0", Slot = "4")]
	public override bool NODAGBIOAMB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public interface DAFHPPDALEI
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NODAGBIOAMB([In] EHPBOBKAOCA ELMFIJMNFBL);
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class OCAADMFCKAA : LKJJAJLIBPN<DAFHPPDALEI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly EHPBOBKAOCA ELMFIJMNFBL;

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6938670", Offset = "0x6937A70", VA = "0x186938670")]
	public OCAADMFCKAA(Guid[] ACKPCJDJCKD, Vector3[] CHBHKICBDCA, Quaternion[] HENHKMBOIOE, float[] PNOMADCBHGA, Dictionary<Guid, Vector3> PGAFIIKCNJA, DAFHPPDALEI IFEKGLLMLPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x69385C0", Offset = "0x69379C0", VA = "0x1869385C0", Slot = "4")]
	public override bool NODAGBIOAMB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public interface IGJEGEAFNCE<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JIOEAMAPFFK([In] DGDHGMBMNIM<TData> KMCBLHKNKKF);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PBEJPLKCIMJ([In] CNAIFHLGECO HCMOPPFNBNI);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PBEJPLKCIMJ([In] IFIPDKMLHBD HCMOPPFNBNI);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool AFPGLACAOAJ();
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class ALLPMPKJOBG<TData> : LKJJAJLIBPN<IGJEGEAFNCE<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x3BFE160", Offset = "0x3BFD560", VA = "0x183BFE160")]
	public ALLPMPKJOBG(IGJEGEAFNCE<TData> IFEKGLLMLPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3D7A4E0", Offset = "0x3D798E0", VA = "0x183D7A4E0", Slot = "4")]
	public override bool NODAGBIOAMB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class FLJPCECMOBE<TData> : LKJJAJLIBPN<IGJEGEAFNCE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly CNAIFHLGECO PEKOJNOIFDO;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3C23D90", Offset = "0x3C23190", VA = "0x183C23D90")]
	public FLJPCECMOBE(Vector3 KIMBBENICLI, bool DCLBLBLIBLP, IGJEGEAFNCE<TData> IFEKGLLMLPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x3C23D30", Offset = "0x3C23130", VA = "0x183C23D30", Slot = "4")]
	public override bool NODAGBIOAMB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class KHNFGFFCCEL<TData> : LKJJAJLIBPN<IGJEGEAFNCE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly IFIPDKMLHBD PEKOJNOIFDO;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x4198AA0", Offset = "0x4197EA0", VA = "0x184198AA0")]
	public KHNFGFFCCEL(Guid GKBKGIKKJLJ, int AGAGKNBDCIG, Vector3 HBGADHMDPAD, Quaternion MGJIDJKDGAB, float JHKMHGJCHGK, bool DCLBLBLIBLP, IGJEGEAFNCE<TData> IFEKGLLMLPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x4198A40", Offset = "0x4197E40", VA = "0x184198A40", Slot = "4")]
	public override bool NODAGBIOAMB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class BAOKPPLHHGB<TData> : LKJJAJLIBPN<IGJEGEAFNCE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly DGDHGMBMNIM<TData> PEKOJNOIFDO;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x4E7E210", Offset = "0x4E7D610", VA = "0x184E7E210")]
	public BAOKPPLHHGB(TData KMCPIOGEAKL, bool EINJIFPLLBI, IGJEGEAFNCE<TData> IFEKGLLMLPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x37E8DA0", Offset = "0x37E81A0", VA = "0x1837E8DA0", Slot = "4")]
	public override bool NODAGBIOAMB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public struct CNAIFHLGECO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly Vector3 KIMBBENICLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public readonly bool DCLBLBLIBLP;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x69376E0", Offset = "0x6936AE0", VA = "0x1869376E0")]
	public CNAIFHLGECO(Vector3 KIMBBENICLI, bool DCLBLBLIBLP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public struct IFIPDKMLHBD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public readonly Guid GKBKGIKKJLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public readonly int AGAGKNBDCIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public readonly Vector3 HBGADHMDPAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public readonly Quaternion MGJIDJKDGAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public readonly float JHKMHGJCHGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public readonly bool DCLBLBLIBLP;

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6937B60", Offset = "0x6936F60", VA = "0x186937B60")]
	public IFIPDKMLHBD(Guid GKBKGIKKJLJ, int AGAGKNBDCIG, Vector3 HBGADHMDPAD, Quaternion MGJIDJKDGAB, float JHKMHGJCHGK, bool DCLBLBLIBLP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public struct DGDHGMBMNIM<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public readonly TData KMCPIOGEAKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public readonly bool EINJIFPLLBI;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x578B880", Offset = "0x578AC80", VA = "0x18578B880")]
	public DGDHGMBMNIM(TData KMCPIOGEAKL, bool EINJIFPLLBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public interface MDKPJMBJGNP<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NODAGBIOAMB([In] JKHKOMLGFDB<TData> DKPDODCADPK);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NODAGBIOAMB([In] PFDJKJMLJPN<TData> DKPDODCADPK);
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public interface PAOIGNMDBIB<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JIOEAMAPFFK([In] MJGDCNGBEDL<TData> GJMPFAFNBGB);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PBEJPLKCIMJ([In] OFIJGKCJJPG HCMOPPFNBNI);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool AFPGLACAOAJ();
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class FEDOEGNHLAA<TData> : LKJJAJLIBPN<MDKPJMBJGNP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly JKHKOMLGFDB<TData> DKPDODCADPK;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x3C08B10", Offset = "0x3C07F10", VA = "0x183C08B10")]
	public FEDOEGNHLAA(IEnumerable<TData> JHFGNCLBFMN, Vector3 IOJBBEJHCPF, bool EINJIFPLLBI, MDKPJMBJGNP<TData> IFEKGLLMLPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x37E8DA0", Offset = "0x37E81A0", VA = "0x1837E8DA0", Slot = "4")]
	public override bool NODAGBIOAMB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class MCPBELOGLKL<TData> : LKJJAJLIBPN<PAOIGNMDBIB<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x3BFE160", Offset = "0x3BFD560", VA = "0x183BFE160")]
	public MCPBELOGLKL(PAOIGNMDBIB<TData> IFEKGLLMLPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x411C7D0", Offset = "0x411BBD0", VA = "0x18411C7D0", Slot = "4")]
	public override bool NODAGBIOAMB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class MKIJJNJEAJL<TData> : LKJJAJLIBPN<PAOIGNMDBIB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly MJGDCNGBEDL<TData> DKPDODCADPK;

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x4455740", Offset = "0x4454B40", VA = "0x184455740")]
	public MKIJJNJEAJL(IEnumerable<TData> JHFGNCLBFMN, bool EINJIFPLLBI, PAOIGNMDBIB<TData> IFEKGLLMLPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x37E8DA0", Offset = "0x37E81A0", VA = "0x1837E8DA0", Slot = "4")]
	public override bool NODAGBIOAMB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class IIMPMONNEIK<TData> : LKJJAJLIBPN<MDKPJMBJGNP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly PFDJKJMLJPN<TData> DKPDODCADPK;

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x3E4E1B0", Offset = "0x3E4D5B0", VA = "0x183E4E1B0")]
	public IIMPMONNEIK(IEnumerable<TData> JHFGNCLBFMN, Vector3 COEFNCADGIM, PDKICBHIEGD OANKHCBHBLJ, bool EINJIFPLLBI, MDKPJMBJGNP<TData> IFEKGLLMLPF, Space BDMACFGHGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3C1E850", Offset = "0x3C1DC50", VA = "0x183C1E850", Slot = "4")]
	public override bool NODAGBIOAMB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class CNKODPFFIDG<TData> : LKJJAJLIBPN<PAOIGNMDBIB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly OFIJGKCJJPG DKPDODCADPK;

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x503B8C0", Offset = "0x503ACC0", VA = "0x18503B8C0")]
	public CNKODPFFIDG(Vector3 IOJBBEJHCPF, PAOIGNMDBIB<TData> IFEKGLLMLPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x3C23D30", Offset = "0x3C23130", VA = "0x183C23D30", Slot = "4")]
	public override bool NODAGBIOAMB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct JKHKOMLGFDB<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public readonly IEnumerable<TData> JHFGNCLBFMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public readonly Vector3 IOJBBEJHCPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public readonly bool EINJIFPLLBI;

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x406C970", Offset = "0x406BD70", VA = "0x18406C970")]
	public JKHKOMLGFDB(IEnumerable<TData> JHFGNCLBFMN, Vector3 IOJBBEJHCPF, bool EINJIFPLLBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct MJGDCNGBEDL<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public readonly IEnumerable<TData> JHFGNCLBFMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public readonly bool EINJIFPLLBI;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x4440CE0", Offset = "0x44400E0", VA = "0x184440CE0")]
	public MJGDCNGBEDL(IEnumerable<TData> JHFGNCLBFMN, bool EINJIFPLLBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct PFDJKJMLJPN<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public readonly IEnumerable<TData> JHFGNCLBFMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public readonly Vector3 COEFNCADGIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly PDKICBHIEGD OANKHCBHBLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public readonly bool EINJIFPLLBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly Space BDMACFGHGLP;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x47D4C10", Offset = "0x47D4010", VA = "0x1847D4C10")]
	public PFDJKJMLJPN(IEnumerable<TData> JHFGNCLBFMN, Vector3 COEFNCADGIM, PDKICBHIEGD OANKHCBHBLJ, bool EINJIFPLLBI, Space BDMACFGHGLP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct OFIJGKCJJPG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public readonly Vector3 IOJBBEJHCPF;

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x21B1F30", Offset = "0x21B1330", VA = "0x1821B1F30")]
	public OFIJGKCJJPG(Vector3 IOJBBEJHCPF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public enum PDKICBHIEGD
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
public interface KDPGOIIINDM
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NODAGBIOAMB([In] DFOIPBKFEJL DPPDFCNICNP);
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public class BGEGPCJHNKE : LKJJAJLIBPN<KDPGOIIINDM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly DFOIPBKFEJL DPPDFCNICNP;

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6937390", Offset = "0x6936790", VA = "0x186937390")]
	public BGEGPCJHNKE(bool EINJIFPLLBI, KDPGOIIINDM IFEKGLLMLPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x69372E0", Offset = "0x69366E0", VA = "0x1869372E0", Slot = "4")]
	public override bool NODAGBIOAMB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public readonly struct DFOIPBKFEJL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public readonly bool EINJIFPLLBI;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x21B2C90", Offset = "0x21B2090", VA = "0x1821B2C90")]
	public DFOIPBKFEJL(bool EINJIFPLLBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public interface HBBMEGLCNEA<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NODAGBIOAMB([In] KEGMONFGMMN<TData> CLBBOOLKBFP);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NODAGBIOAMB([In] IHCAHKPGICC<TData> CLBBOOLKBFP);
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public interface IIBMFGGLFNF<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JIOEAMAPFFK([In] ILAANGFPHND<TData> KMCBLHKNKKF);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PBEJPLKCIMJ([In] AAEBENNHHNG HCMOPPFNBNI);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool AFPGLACAOAJ();
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class ECEFMMKNNNM<TData> : LKJJAJLIBPN<HBBMEGLCNEA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly KEGMONFGMMN<TData> CLBBOOLKBFP;

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x37E8E60", Offset = "0x37E8260", VA = "0x1837E8E60")]
	public ECEFMMKNNNM(IEnumerable<TData> JHFGNCLBFMN, Quaternion IOJBBEJHCPF, Vector3? AIHGHLJLGBL, bool IHAJJCLFAMB, bool EINJIFPLLBI, HBBMEGLCNEA<TData> IFEKGLLMLPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x37E8DA0", Offset = "0x37E81A0", VA = "0x1837E8DA0", Slot = "4")]
	public override bool NODAGBIOAMB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class KAFBKMAAGHO<TData> : LKJJAJLIBPN<IIBMFGGLFNF<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x3BFE160", Offset = "0x3BFD560", VA = "0x183BFE160")]
	public KAFBKMAAGHO(IIBMFGGLFNF<TData> IFEKGLLMLPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x411C7D0", Offset = "0x411BBD0", VA = "0x18411C7D0", Slot = "4")]
	public override bool NODAGBIOAMB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class DAGJJPIPLCP<TData> : LKJJAJLIBPN<IIBMFGGLFNF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly ILAANGFPHND<TData> CLBBOOLKBFP;

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x576CEA0", Offset = "0x576C2A0", VA = "0x18576CEA0")]
	public DAGJJPIPLCP(IEnumerable<TData> JHFGNCLBFMN, bool EINJIFPLLBI, IIBMFGGLFNF<TData> IFEKGLLMLPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x37E8DA0", Offset = "0x37E81A0", VA = "0x1837E8DA0", Slot = "4")]
	public override bool NODAGBIOAMB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class FHKAOCLPDDC<TData> : LKJJAJLIBPN<HBBMEGLCNEA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly IHCAHKPGICC<TData> CLBBOOLKBFP;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x3C1E920", Offset = "0x3C1DD20", VA = "0x183C1E920")]
	public FHKAOCLPDDC(IEnumerable<TData> JHFGNCLBFMN, Quaternion EHENAJNDLDI, PDKICBHIEGD BIIOHNMKCHL, Vector3? AIHGHLJLGBL, bool IHAJJCLFAMB, bool EINJIFPLLBI, Space BDMACFGHGLP, HBBMEGLCNEA<TData> IFEKGLLMLPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x3C1E850", Offset = "0x3C1DC50", VA = "0x183C1E850", Slot = "4")]
	public override bool NODAGBIOAMB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class HNLECKDKPLP<TData> : LKJJAJLIBPN<IIBMFGGLFNF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly AAEBENNHHNG CLBBOOLKBFP;

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x3D9F720", Offset = "0x3D9EB20", VA = "0x183D9F720")]
	public HNLECKDKPLP(Quaternion IOJBBEJHCPF, Vector3? AIHGHLJLGBL, bool IHAJJCLFAMB, IIBMFGGLFNF<TData> IFEKGLLMLPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x3C23D30", Offset = "0x3C23130", VA = "0x183C23D30", Slot = "4")]
	public override bool NODAGBIOAMB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public struct KEGMONFGMMN<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public readonly IEnumerable<TData> JHFGNCLBFMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public readonly Quaternion IOJBBEJHCPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public readonly Vector3? AIHGHLJLGBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public readonly bool IHAJJCLFAMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public readonly bool EINJIFPLLBI;

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x417FE30", Offset = "0x417F230", VA = "0x18417FE30")]
	public KEGMONFGMMN(IEnumerable<TData> JHFGNCLBFMN, Quaternion IOJBBEJHCPF, Vector3? AIHGHLJLGBL, bool IHAJJCLFAMB, bool EINJIFPLLBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public struct ILAANGFPHND<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public readonly IEnumerable<TData> JHFGNCLBFMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly bool EINJIFPLLBI;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x3E72B60", Offset = "0x3E71F60", VA = "0x183E72B60")]
	public ILAANGFPHND(IEnumerable<TData> JHFGNCLBFMN, bool EINJIFPLLBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public struct IHCAHKPGICC<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public readonly IEnumerable<TData> JHFGNCLBFMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public readonly Quaternion EHENAJNDLDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public readonly PDKICBHIEGD BIIOHNMKCHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public readonly Vector3? AIHGHLJLGBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public readonly bool IHAJJCLFAMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public readonly bool EINJIFPLLBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public readonly Space BDMACFGHGLP;

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x3E47530", Offset = "0x3E46930", VA = "0x183E47530")]
	public IHCAHKPGICC(IEnumerable<TData> JHFGNCLBFMN, Quaternion EHENAJNDLDI, PDKICBHIEGD BIIOHNMKCHL, Vector3? AIHGHLJLGBL, bool IHAJJCLFAMB, bool EINJIFPLLBI, Space BDMACFGHGLP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public struct AAEBENNHHNG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public readonly Quaternion IOJBBEJHCPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public readonly Vector3? AIHGHLJLGBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public readonly bool IHAJJCLFAMB;

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x4CF94D0", Offset = "0x4CF88D0", VA = "0x184CF94D0")]
	public AAEBENNHHNG(Quaternion IOJBBEJHCPF, Vector3? AIHGHLJLGBL, bool IHAJJCLFAMB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public interface HCJDMJBMACP<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JIOEAMAPFFK([In] NECLAFOKNMH<TData> KMCBLHKNKKF);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PBEJPLKCIMJ([In] ILGOEIIEPCJ HCMOPPFNBNI);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PBEJPLKCIMJ([In] KJGMILPKAED HCMOPPFNBNI);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool PBEJPLKCIMJ([In] MKBNHMJNPHM HCMOPPFNBNI);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool AFPGLACAOAJ();
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public class PHIEBNGAAIF<TData> : LKJJAJLIBPN<HCJDMJBMACP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly MKBNHMJNPHM JDAMCMOPBCP;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x47D9DE0", Offset = "0x47D91E0", VA = "0x1847D9DE0")]
	public PHIEBNGAAIF(Vector3 JJPIILFCHAC, float GJLNPLOFFPM, Vector3 AIHGHLJLGBL, bool FAFFOKIFNOA, bool GFGBALFCDKI, HCJDMJBMACP<TData> IFEKGLLMLPF, Space BDMACFGHGLP = Space.Self)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x47D9D80", Offset = "0x47D9180", VA = "0x1847D9D80", Slot = "4")]
	public override bool NODAGBIOAMB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public class OOEIJLBNNAF<TData> : LKJJAJLIBPN<HCJDMJBMACP<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x3BFE160", Offset = "0x3BFD560", VA = "0x183BFE160")]
	public OOEIJLBNNAF(HCJDMJBMACP<TData> IFEKGLLMLPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x473A150", Offset = "0x4739550", VA = "0x18473A150", Slot = "4")]
	public override bool NODAGBIOAMB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class MHGODNPBOJA<TData> : LKJJAJLIBPN<HCJDMJBMACP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly NECLAFOKNMH<TData> JDAMCMOPBCP;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x443CC20", Offset = "0x443C020", VA = "0x18443CC20")]
	public MHGODNPBOJA(IEnumerable<TData> JHFGNCLBFMN, bool EINJIFPLLBI, HCJDMJBMACP<TData> IFEKGLLMLPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x37E8DA0", Offset = "0x37E81A0", VA = "0x1837E8DA0", Slot = "4")]
	public override bool NODAGBIOAMB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class IJHKPMOBEIJ<TData> : LKJJAJLIBPN<HCJDMJBMACP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly KJGMILPKAED JDAMCMOPBCP;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x3E721C0", Offset = "0x3E715C0", VA = "0x183E721C0")]
	public IJHKPMOBEIJ(float CJGCONODMEN, bool IIJHOPAOKIF, Vector3 AIHGHLJLGBL, HCJDMJBMACP<TData> IFEKGLLMLPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x3E720F0", Offset = "0x3E714F0", VA = "0x183E720F0", Slot = "4")]
	public override bool NODAGBIOAMB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class HILEFICLHIC<TData> : LKJJAJLIBPN<HCJDMJBMACP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly ILGOEIIEPCJ JDAMCMOPBCP;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x3D607B0", Offset = "0x3D5FBB0", VA = "0x183D607B0")]
	public HILEFICLHIC(float GJLNPLOFFPM, Vector3 AIHGHLJLGBL, HCJDMJBMACP<TData> IFEKGLLMLPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x3C23D30", Offset = "0x3C23130", VA = "0x183C23D30", Slot = "4")]
	public override bool NODAGBIOAMB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public struct MKBNHMJNPHM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public readonly Vector3 JJPIILFCHAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public readonly float GJLNPLOFFPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public readonly Vector3 AIHGHLJLGBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public readonly bool DCLBLBLIBLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public readonly Space BDMACFGHGLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public readonly bool GFGBALFCDKI;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x6937FB0", Offset = "0x69373B0", VA = "0x186937FB0")]
	public MKBNHMJNPHM(Vector3 JJPIILFCHAC, float GJLNPLOFFPM, Vector3 AIHGHLJLGBL, bool DCLBLBLIBLP, bool HIPBMJMLGCP, Space BDMACFGHGLP = Space.Self)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public struct NECLAFOKNMH<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public readonly IEnumerable<TData> JHFGNCLBFMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public readonly bool EINJIFPLLBI;

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x44EBCD0", Offset = "0x44EB0D0", VA = "0x1844EBCD0")]
	public NECLAFOKNMH(IEnumerable<TData> JHFGNCLBFMN, bool EINJIFPLLBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct KJGMILPKAED
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public readonly float CJGCONODMEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public readonly bool IIJHOPAOKIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public readonly Vector3 AIHGHLJLGBL;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x6937EB0", Offset = "0x69372B0", VA = "0x186937EB0")]
	public KJGMILPKAED(float CJGCONODMEN, bool IIJHOPAOKIF, Vector3 AIHGHLJLGBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public struct ILGOEIIEPCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public readonly float GJLNPLOFFPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public readonly Vector3 AIHGHLJLGBL;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x4CBCDA0", Offset = "0x4CBC1A0", VA = "0x184CBCDA0")]
	public ILGOEIIEPCJ(float GJLNPLOFFPM, Vector3 AIHGHLJLGBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct EHPBOBKAOCA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public readonly Guid[] JHFGNCLBFMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public readonly bool LPDCIFIHODB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public readonly bool MGGNINLIAGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public readonly bool LPFENNLGNEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public readonly Vector3[] CHBHKICBDCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public readonly Quaternion[] HENHKMBOIOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly float[] PNOMADCBHGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public readonly Dictionary<Guid, Vector3> PGAFIIKCNJA;

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x69378D0", Offset = "0x6936CD0", VA = "0x1869378D0")]
	public EHPBOBKAOCA(Guid[] ACKPCJDJCKD, Vector3[] CHBHKICBDCA, Quaternion[] HENHKMBOIOE, float[] PNOMADCBHGA, Dictionary<Guid, Vector3> PGAFIIKCNJA, bool LPDCIFIHODB = true, bool MGGNINLIAGO = true, bool LPFENNLGNEC = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x6937700", Offset = "0x6936B00", VA = "0x186937700")]
	private static void BAEHICILNNM(Dictionary<Guid, Vector3> PGAFIIKCNJA, int LCLKCCAFOPO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public static class NCPNJEMPMDB
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	private struct HICEPCOILPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public bool HMFPANHAJGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public NFLAEHJHNPL KIJFELCKAAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public NFLAEHJHNPL OFEICOHHMHA;
	}

	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private static HICEPCOILPL DAJFGDPLPFF;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static CancellationToken OCCFHHIPPPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x6938500", Offset = "0x6937900", VA = "0x186938500")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	internal static NFLAEHJHNPL KIJFELCKAAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x6938460", Offset = "0x6937860", VA = "0x186938460")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x69383F0", Offset = "0x69377F0", VA = "0x1869383F0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x69382F0", Offset = "0x69376F0", VA = "0x1869382F0")]
	[EAMANMFIEOM(LALOBMMKLJJ.Room, NBICBCAKHEI.None)]
	private static void GEKCJCOEJCI(NFLAEHJHNPL JOEPGJGJOHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x69381A0", Offset = "0x69375A0", VA = "0x1869381A0")]
	public static void FCLPPFCBMBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6938150", Offset = "0x6937550", VA = "0x186938150")]
	private static NFLAEHJHNPL DGCCIIFCEDL(NFLAEHJHNPL CBDHDOGPMOJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public static class HDIFJOMAPLA
{
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public enum JNLPNALNGDJ
	{
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		ICreationContextObject,
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		Guid
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x2B76300", Offset = "0x2B75700", VA = "0x182B76300")]
	public static void ANOMMAJGGKM<T>(T GHLPOEBBIHE, JNLPNALNGDJ EPPKBKJHHHJ) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x2B76290", Offset = "0x2B75690", VA = "0x182B76290")]
	public static void ANOMMAJGGKM<T>(T GHLPOEBBIHE) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x2B76470", Offset = "0x2B75870", VA = "0x182B76470")]
	public static void GAAMBJFFMBL<T>(T GHLPOEBBIHE) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x2B76840", Offset = "0x2B75C40", VA = "0x182B76840")]
	public static T PJLOLBBNKPI<T>(JNLPNALNGDJ EPPKBKJHHHJ) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x2B766F0", Offset = "0x2B75AF0", VA = "0x182B766F0")]
	public static bool KPNJANACIKE<T>(JNLPNALNGDJ EPPKBKJHHHJ, T? NDBLMHFMLJJ, [Out][NotNullWhen(true)][MaybeNullWhen(false)] T IGNBEFLMLMJ) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x2B76520", Offset = "0x2B75920", VA = "0x182B76520")]
	public static bool ICOLCNBJBJM<T>(JNLPNALNGDJ EPPKBKJHHHJ) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x2B765D0", Offset = "0x2B759D0", VA = "0x182B765D0")]
	public static T PJLOLBBNKPI<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x2B76630", Offset = "0x2B75A30", VA = "0x182B76630")]
	public static bool KPNJANACIKE<T>(T NDBLMHFMLJJ, [Out] T IGNBEFLMLMJ) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x2B765D0", Offset = "0x2B759D0", VA = "0x182B765D0")]
	public static bool ICOLCNBJBJM<T>() where T : class
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
internal static class IJCHMGNKFAI
{
	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6937C70", Offset = "0x6937070", VA = "0x186937C70")]
	public static void HABKGDNLKGK(IEnumerable CLBKBBJDEJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x2B9C840", Offset = "0x2B9BC40", VA = "0x182B9C840")]
	public static void HABKGDNLKGK<T>(T[] ELFCOFFIPBP) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x2B9CA20", Offset = "0x2B9BE20", VA = "0x182B9CA20")]
	public static void HABKGDNLKGK<T>(T LOBINIIDBBA) where T : notnull, Enum
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
