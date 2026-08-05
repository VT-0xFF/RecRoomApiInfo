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
		[Cpp2IlInjected.Address(RVA = "0x9748B0", Offset = "0x973CB0", VA = "0x1809748B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x74BA140", Offset = "0x74B9540", VA = "0x1874BA140")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x975680", Offset = "0x974A80", VA = "0x180975680")]
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
		[Cpp2IlInjected.Address(RVA = "0x9756C0", Offset = "0x974AC0", VA = "0x1809756C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x74BAA00", Offset = "0x74B9E00", VA = "0x1874BAA00", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x242AF30", Offset = "0x242A330", VA = "0x18242AF30")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface DBJFCNICGCJ<TData, TReturn>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TReturn GKOFEBKAANE(TData GMFKPONAANG);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface HIEDNAJINLG<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ClearHoverTarget(OMONIDCOLJB JHMOFPIIAKI);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool SetHoverTarget(TData MOCLCNOAHKF, Collider BMBBAAJOKFM, OMONIDCOLJB JHMOFPIIAKI, [Optional] FFCHMNNCDPE? POGNHBKDBAH);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool TryGetHoverTarget([Out] TData MOCLCNOAHKF);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetHoverCollider([Out] Collider BMBBAAJOKFM);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface MLLGHGAMEPL<TData> : FOGHGJGLNMO, DOAJOMMHNIF<TData>, MJKCLLBEJHF<TData>, APINGFJHPJI<TData>, KMOEGELFECH, HOEFDGODEJM<TData>, JALKEELFFIF, CPEMLPBHIAM
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface HOEFDGODEJM<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 IGFMIOBPFAL, Vector3 BNCGOADGBEC, float HIAAOMCAGFP, [Out] T LDLPLJPLJCD, [Out] Vector3 JDPCGGHMFPF, [Out] Collider BMBBAAJOKFM);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 IGFMIOBPFAL, Vector3 BNCGOADGBEC, float BJAGHCKHOKF, float HIAAOMCAGFP, T[] FMIDENFDDDG, [Out] Vector3 MFFEGNILKLN, [Out] Collider BJNJJGMHNCC);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 IGFMIOBPFAL, float BJAGHCKHOKF, Vector3 PPDDPBKIBAE, T[] FMIDENFDDDG);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetObjectFromColliderInCurrentScope(Collider FAEGMNIAGDM, [Out] T GJPAKPAKEOL);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface FOGHGJGLNMO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Bounds NPEIDINCOCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Transform OLPDLLCAFJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Bounds HCCLABBMMAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Transform EKPKFBOHGLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Vector3 LKACDLNFCAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool LCIGAGJEJFM
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
	void SetSelectionBoundsDirty(bool EACLEAEDIJB = true, int MMPPNCLBDKH = 0);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ShouldHideSelectionBoundsPreview(bool KCDGNFENFPD, object LAAJFAFNFCN);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface CPEMLPBHIAM
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	FKDOIPNGGAF KGNCLJPKMEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface PLJFHFPDFMD
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool HCIJFELFMCE
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool PNLJEGPPNMG
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool BALPAGIMKGH
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
	void TrySetPreviousCloneMapping(Dictionary<Guid, Guid> IJJOOJFPOML);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface APINGFJHPJI<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool KMMDOAJEGFF
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int OFMFPEFMKGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<TData> AGHNIGAAJAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData MBDDOPABDGG);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData MBDDOPABDGG);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface DOAJOMMHNIF<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T GMFKPONAANG, [Optional] FFCHMNNCDPE? BANIDBBGDNO, bool KFBJAJACJIN = true);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int BBEJNKBNMID, IEnumerable<T> NIDCHMBGOBI, bool KFBJAJACJIN = true);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int BBEJNKBNMID, IEnumerable<T> NIDCHMBGOBI, FFCHMNNCDPE BANIDBBGDNO, bool KFBJAJACJIN = true);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface JALKEELFFIF
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface KMOEGELFECH
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool HAFMGNHFFEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool MGJKINPJLBG
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool ANDABPFCPME
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool DABJLGIOGGF
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class APFKPLKBAOH<TReceiver> : NFFHPBAPHBA<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3FF8470", Offset = "0x3FF7870", VA = "0x183FF8470")]
	public APFKPLKBAOH(TReceiver ODAGIILJBBF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public abstract class NJOIHIKKOPK<TReceiver, TFromTask> : NFFHPBAPHBA<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3FF8470", Offset = "0x3FF7870", VA = "0x183FF8470")]
	public NJOIHIKKOPK(TReceiver ODAGIILJBBF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public abstract class NFFHPBAPHBA<TReceiver, TFromExecute> where TReceiver : notnull where TFromExecute : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	protected TReceiver ODAGIILJBBF;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4E2DFC0", Offset = "0x4E2D3C0", VA = "0x184E2DFC0")]
	public NFFHPBAPHBA(TReceiver ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute JIBIDAAECFI();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class EDBNFEPEJEP<TReceiver, TResult> : NFFHPBAPHBA<TReceiver, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3FF8470", Offset = "0x3FF7870", VA = "0x183FF8470")]
	public EDBNFEPEJEP(TReceiver ODAGIILJBBF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct LHGHGGBJAKF<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public TGroup BBFEANLHGCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public TData GGNIKGMJJBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public IEnumerable<TData> EFBEKGMECAD;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x243BC70", Offset = "0x243B070", VA = "0x18243BC70")]
	public LHGHGGBJAKF(TGroup LLKLEGPHLKE, TData LILLILCKGGB, IEnumerable<TData> FCIJLKLJIPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct CMCKJJJICMD<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public TGroup BBFEANLHGCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public IEnumerable<TData> EFBEKGMECAD;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x9AB3A0", Offset = "0x9AA7A0", VA = "0x1809AB3A0")]
	public CMCKJJJICMD(TGroup LLKLEGPHLKE, IEnumerable<TData> FCIJLKLJIPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct GEBDNENHDMN<TGroup> where TGroup : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public TGroup BBFEANLHGCD;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0xBCD900", Offset = "0xBCCD00", VA = "0x180BCD900")]
	public GEBDNENHDMN(TGroup LLKLEGPHLKE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct DAJMIEACADO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public IEnumerable<Guid> EFBEKGMECAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public Guid CICENEANDEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public readonly bool MADOFDBLEBP;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x74B8F40", Offset = "0x74B8340", VA = "0x1874B8F40")]
	public DAJMIEACADO(IEnumerable<Guid> FCIJLKLJIPE, Guid KOHCBOMIKFA, bool BHEKIOBLFOL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct OKIFHLPEGBK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public Guid CICENEANDEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly bool MADOFDBLEBP;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x229FD70", Offset = "0x229F170", VA = "0x18229FD70")]
	public OKIFHLPEGBK(Guid KOHCBOMIKFA, bool BHEKIOBLFOL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface NFHHNBDKLAC<TGroup, TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CCHDMNHDKNA EHENKNGCLIE(LHGHGGBJAKF<TGroup, TData> PPGANHCEOKO);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CCHDMNHDKNA HBLDCBJCEHN(LHGHGGBJAKF<TGroup, TData> PPGANHCEOKO);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CCHDMNHDKNA FEKKFLCOIBA(CMCKJJJICMD<TGroup, TData> PPGANHCEOKO);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CCHDMNHDKNA LBDEDOJFLIF(GEBDNENHDMN<TGroup> PPGANHCEOKO);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface MDCEEALKPEH
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CCHDMNHDKNA> EHENKNGCLIE(DAJMIEACADO PPGANHCEOKO);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<CCHDMNHDKNA> HBLDCBJCEHN(OKIFHLPEGBK PPGANHCEOKO);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class EJCAPDAILOM<TGroup, TData> : EDBNFEPEJEP<NFHHNBDKLAC<TGroup, TData>, CCHDMNHDKNA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly CMCKJJJICMD<TGroup, TData> PPGANHCEOKO;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x400EFD0", Offset = "0x400E3D0", VA = "0x18400EFD0")]
	public EJCAPDAILOM(TGroup LLKLEGPHLKE, IEnumerable<TData> FCIJLKLJIPE, NFHHNBDKLAC<TGroup, TData> ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x400EF00", Offset = "0x400E300", VA = "0x18400EF00", Slot = "4")]
	public override CCHDMNHDKNA JIBIDAAECFI()
	{
		return default(CCHDMNHDKNA);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class GBEDBKKFIOH<TGroup, TData> : EDBNFEPEJEP<NFHHNBDKLAC<TGroup, TData>, CCHDMNHDKNA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly LHGHGGBJAKF<TGroup, TData> PPGANHCEOKO;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4472610", Offset = "0x4471A10", VA = "0x184472610")]
	public GBEDBKKFIOH(TGroup LLKLEGPHLKE, TData FDAEKEPGKDB, IEnumerable<TData> FCIJLKLJIPE, NFHHNBDKLAC<TGroup, TData> ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x4472540", Offset = "0x4471940", VA = "0x184472540", Slot = "4")]
	public override CCHDMNHDKNA JIBIDAAECFI()
	{
		return default(CCHDMNHDKNA);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class EAJDLEKCEDA<TGroup, TData> : EDBNFEPEJEP<NFHHNBDKLAC<TGroup, TData>, CCHDMNHDKNA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly GEBDNENHDMN<TGroup> PPGANHCEOKO;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3FF5B90", Offset = "0x3FF4F90", VA = "0x183FF5B90")]
	public EAJDLEKCEDA(TGroup LLKLEGPHLKE, NFHHNBDKLAC<TGroup, TData> ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3FF5AD0", Offset = "0x3FF4ED0", VA = "0x183FF5AD0", Slot = "4")]
	public override CCHDMNHDKNA JIBIDAAECFI()
	{
		return default(CCHDMNHDKNA);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class IELPLHMMMMD<TGroup, TData> : EDBNFEPEJEP<NFHHNBDKLAC<TGroup, TData>, CCHDMNHDKNA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly LHGHGGBJAKF<TGroup, TData> PPGANHCEOKO;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4472610", Offset = "0x4471A10", VA = "0x184472610")]
	public IELPLHMMMMD(TGroup LLKLEGPHLKE, TData LILLILCKGGB, IEnumerable<TData> FCIJLKLJIPE, NFHHNBDKLAC<TGroup, TData> ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x471DB30", Offset = "0x471CF30", VA = "0x18471DB30", Slot = "4")]
	public override CCHDMNHDKNA JIBIDAAECFI()
	{
		return default(CCHDMNHDKNA);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class HEEEILMCGLA : NJOIHIKKOPK<MDCEEALKPEH, CCHDMNHDKNA>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private struct CNDHNFCDOOL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public AsyncTaskMethodBuilder<CCHDMNHDKNA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public HEEEILMCGLA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private TaskAwaiter<CCHDMNHDKNA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x74B8C40", Offset = "0x74B8040", VA = "0x1874B8C40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x74B8ED0", Offset = "0x74B82D0", VA = "0x1874B8ED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private DAJMIEACADO PPGANHCEOKO;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x74B9980", Offset = "0x74B8D80", VA = "0x1874B9980")]
	public HEEEILMCGLA(IEnumerable<Guid> HAOLHJJKIIE, Guid KOHCBOMIKFA, bool BHEKIOBLFOL, MDCEEALKPEH ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x74B9890", Offset = "0x74B8C90", VA = "0x1874B9890", Slot = "4")]
	[AsyncStateMachine(typeof(CNDHNFCDOOL))]
	public override Task<CCHDMNHDKNA> JIBIDAAECFI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class OLPCIMJMJJP : NJOIHIKKOPK<MDCEEALKPEH, CCHDMNHDKNA>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private struct JCHMIDAOBFD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public AsyncTaskMethodBuilder<CCHDMNHDKNA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public OLPCIMJMJJP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private TaskAwaiter<CCHDMNHDKNA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x74B9A40", Offset = "0x74B8E40", VA = "0x1874B9A40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x74B9CE0", Offset = "0x74B90E0", VA = "0x1874B9CE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly OKIFHLPEGBK PPGANHCEOKO;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x74BA2B0", Offset = "0x74B96B0", VA = "0x1874BA2B0")]
	public OLPCIMJMJJP(Guid KOHCBOMIKFA, bool BHEKIOBLFOL, MDCEEALKPEH ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x74BA1C0", Offset = "0x74B95C0", VA = "0x1874BA1C0", Slot = "4")]
	[AsyncStateMachine(typeof(JCHMIDAOBFD))]
	public override Task<CCHDMNHDKNA> JIBIDAAECFI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public readonly struct HAKMDCKLAPO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly BKMAHIJIAJO DHIJANDJFAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly bool MADOFDBLEBP;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x74B9850", Offset = "0x74B8C50", VA = "0x1874B9850")]
	public HAKMDCKLAPO(BKMAHIJIAJO OOIEKBGEBJE, bool BHEKIOBLFOL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface KOIKEELCBLC<TSpawnType> where TSpawnType : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> JIBIDAAECFI(HAKMDCKLAPO MCMDEPLHMAJ);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class DFHPEFPEGIE<TSpawnType> : NJOIHIKKOPK<KOIKEELCBLC<TSpawnType>, TSpawnType> where TSpawnType : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private struct ODHINGGPHAH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AsyncTaskMethodBuilder<TSpawnType> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public DFHPEFPEGIE<TSpawnType> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private TaskAwaiter<TSpawnType> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x4F8C570", Offset = "0x4F8B970", VA = "0x184F8C570", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x43DFE40", Offset = "0x43DF240", VA = "0x1843DFE40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly HAKMDCKLAPO MCMDEPLHMAJ;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6299E80", Offset = "0x6299280", VA = "0x186299E80")]
	public DFHPEFPEGIE(BKMAHIJIAJO OOIEKBGEBJE, bool BHEKIOBLFOL, KOIKEELCBLC<TSpawnType> ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6299B80", Offset = "0x6298F80", VA = "0x186299B80", Slot = "4")]
	[AsyncStateMachine(typeof(DFHPEFPEGIE<>.ODHINGGPHAH))]
	public override Task<TSpawnType> JIBIDAAECFI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public readonly struct BKMAHIJIAJO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly bool BCEMLBLHBEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly Vector3 CEPDBDAPIFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly Vector3 NAMOIOBECGF;

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x74B8AF0", Offset = "0x74B7EF0", VA = "0x1874B8AF0")]
	public BKMAHIJIAJO(Transform EMAHOHDKPIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x74B8AC0", Offset = "0x74B7EC0", VA = "0x1874B8AC0")]
	public BKMAHIJIAJO(Vector3 FGKLFPNFOKI, Vector3 NDADPNJPMFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x74B8A00", Offset = "0x74B7E00", VA = "0x1874B8A00")]
	public static BKMAHIJIAJO KKJJGGFFFGK()
	{
		return default(BKMAHIJIAJO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x74B8A30", Offset = "0x74B7E30", VA = "0x1874B8A30")]
	private BKMAHIJIAJO(bool AEFODGEFNMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct OIPEFLHENIE<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public TNode BOBONDBMNEE;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x4FAF390", Offset = "0x4FAE790", VA = "0x184FAF390")]
	public OIPEFLHENIE(TNode BOBONDBMNEE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct INPFEENBNKH<TNode, TReparentOperations> where TNode : notnull where TReparentOperations : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public TNode LDFDPDALOOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public TReparentOperations LIJHANBCGEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public OOAEPBFJOGI ECBBIOKIOEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly bool MADOFDBLEBP;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x4738580", Offset = "0x4737980", VA = "0x184738580")]
	public INPFEENBNKH(TNode LDFDPDALOOA, TReparentOperations LIJHANBCGEB, OOAEPBFJOGI ECBBIOKIOEM, bool BHEKIOBLFOL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface OCBMIBJKPHL<TNode, TReparentOperations>
{
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BFKPNIEFKBE([In] OIPEFLHENIE<TNode> ELLJOKHFCGH);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KKEJHABJOGM([In] INPFEENBNKH<TNode, TReparentOperations> IINBEIBLMIH);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HFGGBLFJPOB();
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class GPDMPPLNHOI<TNode, TReparentOperations> : APFKPLKBAOH<OCBMIBJKPHL<TNode, TReparentOperations>>
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3FF8470", Offset = "0x3FF7870", VA = "0x183FF8470")]
	public GPDMPPLNHOI(OCBMIBJKPHL<TNode, TReparentOperations> ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x4565E60", Offset = "0x4565260", VA = "0x184565E60", Slot = "4")]
	public override bool JIBIDAAECFI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class KBMMNFEMMEE<TNode, TReparentOperations> : APFKPLKBAOH<OCBMIBJKPHL<TNode, TReparentOperations>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly INPFEENBNKH<TNode, TReparentOperations> IINBEIBLMIH;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x4A3B0D0", Offset = "0x4A3A4D0", VA = "0x184A3B0D0")]
	public KBMMNFEMMEE(TNode LDFDPDALOOA, TReparentOperations LIJHANBCGEB, OOAEPBFJOGI ECBBIOKIOEM, OCBMIBJKPHL<TNode, TReparentOperations> ODAGIILJBBF, bool BHEKIOBLFOL = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x4A3B010", Offset = "0x4A3A410", VA = "0x184A3B010", Slot = "4")]
	public override bool JIBIDAAECFI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class AFHIFGMFBJB<TNode, TReparentOperations> : APFKPLKBAOH<OCBMIBJKPHL<TNode, TReparentOperations>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly OIPEFLHENIE<TNode> ELLJOKHFCGH;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x479B6A0", Offset = "0x479AAA0", VA = "0x18479B6A0")]
	public AFHIFGMFBJB(TNode LKCMDFMIPFB, OCBMIBJKPHL<TNode, TReparentOperations> ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x43BBEE0", Offset = "0x43BB2E0", VA = "0x1843BBEE0", Slot = "4")]
	public override bool JIBIDAAECFI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct PJEANCCKAMG<TSpawnInfo> where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public TSpawnInfo FAEFOBFELLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public Vector3 NDADPNJPMFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public Quaternion MLMNPOCKAAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public float JJCKONKIIAI;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x50AA0B0", Offset = "0x50A94B0", VA = "0x1850AA0B0")]
	public PJEANCCKAMG(TSpawnInfo FAEFOBFELLM, Vector3 NDADPNJPMFO, Quaternion MLMNPOCKAAE, float JJCKONKIIAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface EJOBKNOBJKO<TSpawnType, TSpawnInfo>
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> NLCJAEMBPLF([In] PJEANCCKAMG<TSpawnInfo> CLIGGJKGFPP, CancellationToken LAEIHJHNGEK);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public class ODNBDFAHBCA<TSpawnType, TSpawnInfo> : NJOIHIKKOPK<EJOBKNOBJKO<TSpawnType, TSpawnInfo>, TSpawnType> where TSpawnType : notnull where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly PJEANCCKAMG<TSpawnInfo> JIEBKPCGKFF;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x4F8CE00", Offset = "0x4F8C200", VA = "0x184F8CE00")]
	public ODNBDFAHBCA(TSpawnInfo PBEKJKIAFOA, Vector3 NDADPNJPMFO, Quaternion MLMNPOCKAAE, float JJCKONKIIAI, EJOBKNOBJKO<TSpawnType, TSpawnInfo> ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x496D920", Offset = "0x496CD20", VA = "0x18496D920", Slot = "4")]
	public override Task<TSpawnType> JIBIDAAECFI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public readonly struct FACJGADPOFL<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly IEnumerable<TData> EFBEKGMECAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly bool MADOFDBLEBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly bool NHCFFOLGEFI;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x43A4190", Offset = "0x43A3590", VA = "0x1843A4190")]
	public FACJGADPOFL(IEnumerable<TData> FCIJLKLJIPE, bool BHEKIOBLFOL = false, bool NEFBOFDKGBG = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface AFNKBGBDIFD<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CCHDMNHDKNA> CCOMNNDCLLA([In] FACJGADPOFL<TData> NEMECGHCBCB, CancellationToken LAEIHJHNGEK);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class JFLOBLNHENG<TData> : NJOIHIKKOPK<AFNKBGBDIFD<TData>, CCHDMNHDKNA> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly FACJGADPOFL<TData> MOMKPAMNGOO;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x496DAB0", Offset = "0x496CEB0", VA = "0x18496DAB0")]
	public JFLOBLNHENG(IEnumerable<TData> FCIJLKLJIPE, bool BHEKIOBLFOL, AFNKBGBDIFD<TData> ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x496D920", Offset = "0x496CD20", VA = "0x18496D920", Slot = "4")]
	public override Task<CCHDMNHDKNA> JIBIDAAECFI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct HIDLJGJKANO<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly T MOCLCNOAHKF;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x46184C0", Offset = "0x46178C0", VA = "0x1846184C0")]
	public HIDLJGJKANO(T GHCOFKNEAHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface IMNNGKPIIHL<T>
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BFKPNIEFKBE([In] HIDLJGJKANO<T> AJIPJHHDIPP);

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KKEJHABJOGM();
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface LHCEMLBGAFI<T>
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JIBIDAAECFI([In] FFJNNFIGDJH<T> EPNLEONGDCK);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct FFJNNFIGDJH<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly T MOCLCNOAHKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly bool FKHBJPOBFBH;

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x43C3DE0", Offset = "0x43C31E0", VA = "0x1843C3DE0")]
	public FFJNNFIGDJH(T GHCOFKNEAHE, bool JCEAEDIKDGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class FBBPDEKGHJD<T> : APFKPLKBAOH<IMNNGKPIIHL<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x3FF8470", Offset = "0x3FF7870", VA = "0x183FF8470")]
	public FBBPDEKGHJD(IMNNGKPIIHL<T> ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x43B6880", Offset = "0x43B5C80", VA = "0x1843B6880", Slot = "4")]
	public override bool JIBIDAAECFI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class FCNLFGOOOGC<T> : APFKPLKBAOH<IMNNGKPIIHL<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly HIDLJGJKANO<T> AJIPJHHDIPP;

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x43BBFA0", Offset = "0x43BB3A0", VA = "0x1843BBFA0")]
	public FCNLFGOOOGC(T MOCLCNOAHKF, IMNNGKPIIHL<T> ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x43BBEE0", Offset = "0x43BB2E0", VA = "0x1843BBEE0", Slot = "4")]
	public override bool JIBIDAAECFI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class BJOHDEJLFIM<T> : APFKPLKBAOH<LHCEMLBGAFI<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly FFJNNFIGDJH<T> EPNLEONGDCK;

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x58477B0", Offset = "0x5846BB0", VA = "0x1858477B0")]
	public BJOHDEJLFIM(T MOCLCNOAHKF, bool JCEAEDIKDGF, LHCEMLBGAFI<T> ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x43BBEE0", Offset = "0x43BB2E0", VA = "0x1843BBEE0", Slot = "4")]
	public override bool JIBIDAAECFI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct BCJHIGGCKND<TData> where TData : notnull, BOJHALLHPHJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public IEnumerable<TData> EFBEKGMECAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public bool GMMJGLHECAF;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5837A60", Offset = "0x5836E60", VA = "0x185837A60")]
	public BCJHIGGCKND(IEnumerable<TData> CMAMCLJHGBJ, bool JEDKPIGMJPC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public struct PLEDMBBIMIM<TData> where TData : notnull, BOJHALLHPHJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public List<TData> EFBEKGMECAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public List<bool> FKLHNKDMLNB;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x50AC690", Offset = "0x50ABA90", VA = "0x1850AC690")]
	public PLEDMBBIMIM(List<TData> CMAMCLJHGBJ, List<bool> LFJJLNCAOBB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface BOJHALLHPHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool HCKEMBJGEMC
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
public interface DGHHLPOMDLG<TData> where TData : BOJHALLHPHJ
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JIBIDAAECFI([In] BCJHIGGCKND<TData> LBDHJDJNADF);

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JIBIDAAECFI([In] PLEDMBBIMIM<TData> LBDHJDJNADF);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface BFNLILMEIMO<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JMMNBNLAOBJ(T MOCLCNOAHKF);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class ABEGKGEOCKH<TData> : APFKPLKBAOH<DGHHLPOMDLG<TData>> where TData : notnull, BOJHALLHPHJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly BCJHIGGCKND<TData> LBDHJDJNADF;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x463EF90", Offset = "0x463E390", VA = "0x18463EF90")]
	public ABEGKGEOCKH(List<TData> FCIJLKLJIPE, bool GMMJGLHECAF, DGHHLPOMDLG<TData> ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x43BBEE0", Offset = "0x43BB2E0", VA = "0x1843BBEE0", Slot = "4")]
	public override bool JIBIDAAECFI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class JIPCKBFEGHB<TData> : APFKPLKBAOH<DGHHLPOMDLG<TData>> where TData : notnull, BOJHALLHPHJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly PLEDMBBIMIM<TData> LBDHJDJNADF;

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x4973B20", Offset = "0x4972F20", VA = "0x184973B20")]
	public JIPCKBFEGHB(List<TData> FCIJLKLJIPE, List<bool> FKLHNKDMLNB, DGHHLPOMDLG<TData> ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x44FC790", Offset = "0x44FBB90", VA = "0x1844FC790", Slot = "4")]
	public override bool JIBIDAAECFI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface AGAOHOLGDMP<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CCHDMNHDKNA> JIBIDAAECFI(DONHGFFPGCF<TData> AMFKNIEECAJ);
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class KKOJBPPKNDN<TData> : NJOIHIKKOPK<AGAOHOLGDMP<TData>, CCHDMNHDKNA> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct ILHKGJKIFDO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public AsyncTaskMethodBuilder<CCHDMNHDKNA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public KKOJBPPKNDN<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter<CCHDMNHDKNA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x472DB30", Offset = "0x472CF30", VA = "0x18472DB30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x472DE10", Offset = "0x472D210", VA = "0x18472DE10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly DONHGFFPGCF<TData> EBHLNLLOHGG;

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x4A65A80", Offset = "0x4A64E80", VA = "0x184A65A80")]
	public KKOJBPPKNDN(TData NIKIICPONPG, IReadOnlyList<TData> LIABPJFBJFH, bool BHEKIOBLFOL, AGAOHOLGDMP<TData> ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x4A65980", Offset = "0x4A64D80", VA = "0x184A65980", Slot = "4")]
	[AsyncStateMachine(typeof(KKOJBPPKNDN<>.ILHKGJKIFDO))]
	public override Task<CCHDMNHDKNA> JIBIDAAECFI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct DONHGFFPGCF<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public TData NKNMLPCCMDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public IReadOnlyList<TData> FANPMDABJOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public bool MADOFDBLEBP;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5662900", Offset = "0x5661D00", VA = "0x185662900")]
	public DONHGFFPGCF(TData NIKIICPONPG, IReadOnlyList<TData> LIABPJFBJFH, bool BHEKIOBLFOL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface GOBKINNKHBO<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JIBIDAAECFI([In] EPJBFABDOHK<TData> MMAGMJFACHF);
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface LNLLDFMBGOJ<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JIBIDAAECFI([In] CAEKDJEDBLO<TData> MMAGMJFACHF);
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface LINHBCNPHLB<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CJNJCCNDNJO([In] JEHALADLFOE<TData> MMAGMJFACHF);

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KKEJHABJOGM();
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class BFAMOOLCGMO<TData> : APFKPLKBAOH<GOBKINNKHBO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly EPJBFABDOHK<TData> MMAGMJFACHF;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x583B4D0", Offset = "0x583A8D0", VA = "0x18583B4D0")]
	public BFAMOOLCGMO(IEnumerable<TData> FCIJLKLJIPE, MONBNMPFMMO NHCBHMJDLHA, CEHJAJCAOIA HJCEHLILOIG, float LNCPFBAGODO, bool BHEKIOBLFOL, GOBKINNKHBO<TData> ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x43BBEE0", Offset = "0x43BB2E0", VA = "0x1843BBEE0", Slot = "4")]
	public override bool JIBIDAAECFI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public class KEJOELPLIND<TData> : APFKPLKBAOH<LNLLDFMBGOJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly CAEKDJEDBLO<TData> MMAGMJFACHF;

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x4A4B430", Offset = "0x4A4A830", VA = "0x184A4B430")]
	public KEJOELPLIND(TData[] FCIJLKLJIPE, MONBNMPFMMO[] NHCBHMJDLHA, CEHJAJCAOIA[] HJCEHLILOIG, float[] LNCPFBAGODO, LNLLDFMBGOJ<TData> ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x4A4B290", Offset = "0x4A4A690", VA = "0x184A4B290", Slot = "4")]
	public override bool JIBIDAAECFI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class KLJGCKGILGM<TData> : APFKPLKBAOH<LINHBCNPHLB<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x3FF8470", Offset = "0x3FF7870", VA = "0x183FF8470")]
	public KLJGCKGILGM(LINHBCNPHLB<TData> ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x4A665E0", Offset = "0x4A659E0", VA = "0x184A665E0", Slot = "4")]
	public override bool JIBIDAAECFI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class LCANKANCGJD<TData> : APFKPLKBAOH<LINHBCNPHLB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private readonly JEHALADLFOE<TData> MMAGMJFACHF;

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x4B525C0", Offset = "0x4B519C0", VA = "0x184B525C0")]
	public LCANKANCGJD(IEnumerable<TData> FCIJLKLJIPE, MONBNMPFMMO NHCBHMJDLHA, CEHJAJCAOIA HJCEHLILOIG, float LNCPFBAGODO, LINHBCNPHLB<TData> ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x4A4B290", Offset = "0x4A4A690", VA = "0x184A4B290", Slot = "4")]
	public override bool JIBIDAAECFI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct EPJBFABDOHK<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public IEnumerable<TData> EFBEKGMECAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public MONBNMPFMMO GKMLNPEPKPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public CEHJAJCAOIA IAODGAIPHAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public float LNCPFBAGODO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public bool BHEKIOBLFOL;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x402B330", Offset = "0x402A730", VA = "0x18402B330")]
	public EPJBFABDOHK(IEnumerable<TData> FCIJLKLJIPE, MONBNMPFMMO NHCBHMJDLHA, CEHJAJCAOIA HJCEHLILOIG, float LNCPFBAGODO, bool BHEKIOBLFOL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public struct CAEKDJEDBLO<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public TData[] EFBEKGMECAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public MONBNMPFMMO[] GKMLNPEPKPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public CEHJAJCAOIA[] IAODGAIPHAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public float[] LNCPFBAGODO;

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x5946E10", Offset = "0x5946210", VA = "0x185946E10")]
	public CAEKDJEDBLO(TData[] FCIJLKLJIPE, MONBNMPFMMO[] NHCBHMJDLHA, CEHJAJCAOIA[] HJCEHLILOIG, float[] LNCPFBAGODO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct JEHALADLFOE<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public IEnumerable<TData> EFBEKGMECAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public MONBNMPFMMO GKMLNPEPKPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public CEHJAJCAOIA IAODGAIPHAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public float LNCPFBAGODO;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x496B9B0", Offset = "0x496ADB0", VA = "0x18496B9B0")]
	public JEHALADLFOE(IEnumerable<TData> FCIJLKLJIPE, MONBNMPFMMO NHCBHMJDLHA, CEHJAJCAOIA HJCEHLILOIG, float LNCPFBAGODO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface MJKCLLBEJHF<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FEKKFLCOIBA([In] AIKEPEHKGAM<TData> NEMECGHCBCB);

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LBDEDOJFLIF([In] AIKEPEHKGAM<TData> NEMECGHCBCB);

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EHOGKIOEEMK([In] bool OIFDIMICHKD);

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool GNOLMELCOKI([In] AIKEPEHKGAM<TData> NEMECGHCBCB);

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IHOFOPGNGML();

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool MDAEBHJHLKD([In] TData JIOJOECFEAH);
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class PKDNNNDDMAN<TData> : APFKPLKBAOH<MJKCLLBEJHF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly AIKEPEHKGAM<TData> NEMECGHCBCB;

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x50AA6E0", Offset = "0x50A9AE0", VA = "0x1850AA6E0")]
	public PKDNNNDDMAN(List<TData> FDMJAFAEFBP, MJKCLLBEJHF<TData> ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x43BBEE0", Offset = "0x43BB2E0", VA = "0x1843BBEE0", Slot = "4")]
	public override bool JIBIDAAECFI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class OJGJJPIJOFI<TData> : APFKPLKBAOH<MJKCLLBEJHF<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x3FF8470", Offset = "0x3FF7870", VA = "0x183FF8470")]
	public OJGJJPIJOFI(MJKCLLBEJHF<TData> ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x4FB0B90", Offset = "0x4FAFF90", VA = "0x184FB0B90", Slot = "4")]
	public override bool JIBIDAAECFI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class KLDMNJGOHBG<TData> : APFKPLKBAOH<MJKCLLBEJHF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly bool BHEKIOBLFOL;

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x4A66120", Offset = "0x4A65520", VA = "0x184A66120")]
	public KLDMNJGOHBG(bool BHEKIOBLFOL, MJKCLLBEJHF<TData> ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x4A660C0", Offset = "0x4A654C0", VA = "0x184A660C0", Slot = "4")]
	public override bool JIBIDAAECFI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class GHABIMGNCIK<TData> : APFKPLKBAOH<MJKCLLBEJHF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly AIKEPEHKGAM<TData> NEMECGHCBCB;

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x44FC850", Offset = "0x44FBC50", VA = "0x1844FC850")]
	public GHABIMGNCIK(List<TData> FDMJAFAEFBP, bool BHEKIOBLFOL, MJKCLLBEJHF<TData> ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x44FC790", Offset = "0x44FBB90", VA = "0x1844FC790", Slot = "4")]
	public override bool JIBIDAAECFI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class DNCAJEFHJHC<TData> : APFKPLKBAOH<MJKCLLBEJHF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly TData JIOJOECFEAH;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x62BF570", Offset = "0x62BE970", VA = "0x1862BF570")]
	public DNCAJEFHJHC(TData JIOJOECFEAH, MJKCLLBEJHF<TData> ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x62BF4B0", Offset = "0x62BE8B0", VA = "0x1862BF4B0", Slot = "4")]
	public override bool JIBIDAAECFI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public class OEMGKHCABFP<TData> : APFKPLKBAOH<MJKCLLBEJHF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly AIKEPEHKGAM<TData> NEMECGHCBCB;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4F8F5D0", Offset = "0x4F8E9D0", VA = "0x184F8F5D0")]
	public OEMGKHCABFP(IEnumerable<TData> FDMJAFAEFBP, MJKCLLBEJHF<TData> ODAGIILJBBF, bool BHEKIOBLFOL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x4F8F460", Offset = "0x4F8E860", VA = "0x184F8F460", Slot = "4")]
	public override bool JIBIDAAECFI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct AIKEPEHKGAM<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public IEnumerable<TData> EFBEKGMECAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public bool BHEKIOBLFOL;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x47A3A40", Offset = "0x47A2E40", VA = "0x1847A3A40")]
	public AIKEPEHKGAM(IEnumerable<TData> CMAMCLJHGBJ, bool CHPKOHBOLGM = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface HLKHGJOOAHP
{
	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CCHDMNHDKNA> JIBIDAAECFI(PFCEBMLNCMA JNDEMAOAHMP);
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class DCMPPMAFFEE : NJOIHIKKOPK<HLKHGJOOAHP, CCHDMNHDKNA>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private struct LPBDGPNGBIO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public AsyncTaskMethodBuilder<CCHDMNHDKNA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public DCMPPMAFFEE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private TaskAwaiter<CCHDMNHDKNA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x74B9E40", Offset = "0x74B9240", VA = "0x1874B9E40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x74BA0C0", Offset = "0x74B94C0", VA = "0x1874BA0C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly PFCEBMLNCMA JHLMOBFJHIO;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x74B9070", Offset = "0x74B8470", VA = "0x1874B9070")]
	public DCMPPMAFFEE(bool BHEKIOBLFOL, HLKHGJOOAHP ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x74B8F80", Offset = "0x74B8380", VA = "0x1874B8F80", Slot = "4")]
	[AsyncStateMachine(typeof(LPBDGPNGBIO))]
	public override Task<CCHDMNHDKNA> JIBIDAAECFI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public struct PFCEBMLNCMA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public bool MADOFDBLEBP;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x2740760", Offset = "0x273FB60", VA = "0x182740760")]
	public PFCEBMLNCMA(bool BHEKIOBLFOL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public readonly struct MJJNNHFJKNJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public readonly bool JCDGAMLKJPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public readonly bool JFKELDAANDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public readonly bool JJCKONKIIAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public readonly bool BHEKIOBLFOL;

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x5681930", Offset = "0x5680D30", VA = "0x185681930")]
	public MJJNNHFJKNJ(bool JCDGAMLKJPI, bool JFKELDAANDC, bool JJCKONKIIAI, bool BHEKIOBLFOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x74BA130", Offset = "0x74B9530", VA = "0x1874BA130")]
	public MJJNNHFJKNJ(bool JFKELDAANDC, bool BHEKIOBLFOL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public interface IIBPHHAGENJ
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EIGLJNCJGMN(MJJNNHFJKNJ HAGFPDKGFFO);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MHLBKNKPDDI(MJJNNHFJKNJ HAGFPDKGFFO);
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class CDIMOKAGNID : APFKPLKBAOH<IIBPHHAGENJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly MJJNNHFJKNJ HAGFPDKGFFO;

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x74B8BB0", Offset = "0x74B7FB0", VA = "0x1874B8BB0")]
	public CDIMOKAGNID(bool EJNLPEDOMDD, bool JFKELDAANDC, bool JJCKONKIIAI, bool BHEKIOBLFOL, IIBPHHAGENJ ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x74B8B60", Offset = "0x74B7F60", VA = "0x1874B8B60", Slot = "4")]
	public override bool JIBIDAAECFI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class LDMOAANOJKJ : APFKPLKBAOH<IIBPHHAGENJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly MJJNNHFJKNJ HAGFPDKGFFO;

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x74B9DA0", Offset = "0x74B91A0", VA = "0x1874B9DA0")]
	public LDMOAANOJKJ(bool JFKELDAANDC, bool BHEKIOBLFOL, IIBPHHAGENJ ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x74B9D50", Offset = "0x74B9150", VA = "0x1874B9D50", Slot = "4")]
	public override bool JIBIDAAECFI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public interface EFKHBLLIHBD
{
	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JIBIDAAECFI([In] PEKECMMPKPE MBKPEFICFIN);
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class EANMMOAEKAN : APFKPLKBAOH<EFKHBLLIHBD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly PEKECMMPKPE MBKPEFICFIN;

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x74B9290", Offset = "0x74B8690", VA = "0x1874B9290")]
	public EANMMOAEKAN(Guid[] NHBKKNDCMHL, Vector3[] JHJNMCGMILB, Quaternion[] BNCHPEOHGHC, float[] FNPOJCFIKHB, Dictionary<Guid, Vector3> EPMILFMHIFA, EFKHBLLIHBD ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x74B91E0", Offset = "0x74B85E0", VA = "0x1874B91E0", Slot = "4")]
	public override bool JIBIDAAECFI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public interface PIKLKELJPME<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BFKPNIEFKBE([In] HIPNIAFAGKP<TData> ELLJOKHFCGH);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CJNJCCNDNJO([In] LGBMFNCJBFA HFFOGJKNMBE);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CJNJCCNDNJO([In] BDIADNMBMNM HFFOGJKNMBE);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool KKEJHABJOGM();
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class LFNIDPINNEA<TData> : APFKPLKBAOH<PIKLKELJPME<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x3FF8470", Offset = "0x3FF7870", VA = "0x183FF8470")]
	public LFNIDPINNEA(PIKLKELJPME<TData> ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x4B5C780", Offset = "0x4B5BB80", VA = "0x184B5C780", Slot = "4")]
	public override bool JIBIDAAECFI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public class HIGEKPJPIHB<TData> : APFKPLKBAOH<PIKLKELJPME<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private readonly LGBMFNCJBFA KNLGIGFKNLG;

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x4618630", Offset = "0x4617A30", VA = "0x184618630")]
	public HIGEKPJPIHB(Vector3 KDBPBMFFBHM, bool MFIJLIIOKLA, PIKLKELJPME<TData> ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x45CF090", Offset = "0x45CE490", VA = "0x1845CF090", Slot = "4")]
	public override bool JIBIDAAECFI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class IJLDINCEFLO<TData> : APFKPLKBAOH<PIKLKELJPME<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly BDIADNMBMNM KNLGIGFKNLG;

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x4722290", Offset = "0x4721690", VA = "0x184722290")]
	public IJLDINCEFLO(Guid INNIACIGJGO, int EAHKFAJBNDN, Vector3 NDADPNJPMFO, Quaternion MLMNPOCKAAE, float PMGAIALCDAG, bool MFIJLIIOKLA, PIKLKELJPME<TData> ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x4722230", Offset = "0x4721630", VA = "0x184722230", Slot = "4")]
	public override bool JIBIDAAECFI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public class LJINBMADKON<TData> : APFKPLKBAOH<PIKLKELJPME<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly HIPNIAFAGKP<TData> KNLGIGFKNLG;

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x4B64490", Offset = "0x4B63890", VA = "0x184B64490")]
	public LJINBMADKON(TData MOCLCNOAHKF, bool BHEKIOBLFOL, PIKLKELJPME<TData> ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x43BBEE0", Offset = "0x43BB2E0", VA = "0x1843BBEE0", Slot = "4")]
	public override bool JIBIDAAECFI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public struct LGBMFNCJBFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public readonly Vector3 KDBPBMFFBHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public readonly bool MFIJLIIOKLA;

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x74B9E20", Offset = "0x74B9220", VA = "0x1874B9E20")]
	public LGBMFNCJBFA(Vector3 KDBPBMFFBHM, bool MFIJLIIOKLA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public struct BDIADNMBMNM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public readonly Guid INNIACIGJGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public readonly int EAHKFAJBNDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public readonly Vector3 NDADPNJPMFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public readonly Quaternion MLMNPOCKAAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public readonly float PMGAIALCDAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public readonly bool MFIJLIIOKLA;

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x74B89C0", Offset = "0x74B7DC0", VA = "0x1874B89C0")]
	public BDIADNMBMNM(Guid INNIACIGJGO, int EAHKFAJBNDN, Vector3 NDADPNJPMFO, Quaternion MLMNPOCKAAE, float PMGAIALCDAG, bool MFIJLIIOKLA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public struct HIPNIAFAGKP<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public readonly TData MOCLCNOAHKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public readonly bool BHEKIOBLFOL;

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x4619960", Offset = "0x4618D60", VA = "0x184619960")]
	public HIPNIAFAGKP(TData MOCLCNOAHKF, bool BHEKIOBLFOL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public interface LPELIFJNJKO<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JIBIDAAECFI([In] FOGKLGIFPLC<TData> HICIHEGJDGC);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JIBIDAAECFI([In] DIGHLAKBKKL<TData> HICIHEGJDGC);
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public interface GIJHBDKCPKM<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BFKPNIEFKBE([In] KDHDBHGNOGN<TData> AMIJCPNIIDN);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CJNJCCNDNJO([In] JOGFHEDEFKE HFFOGJKNMBE);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KKEJHABJOGM();
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class HOBNNNHDPAJ<TData> : APFKPLKBAOH<LPELIFJNJKO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private readonly FOGKLGIFPLC<TData> HICIHEGJDGC;

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x46680D0", Offset = "0x46674D0", VA = "0x1846680D0")]
	public HOBNNNHDPAJ(IEnumerable<TData> FCIJLKLJIPE, Vector3 GHDIDJJLJAK, bool BHEKIOBLFOL, LPELIFJNJKO<TData> ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x43BBEE0", Offset = "0x43BB2E0", VA = "0x1843BBEE0", Slot = "4")]
	public override bool JIBIDAAECFI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public class EGIFFLEBCML<TData> : APFKPLKBAOH<GIJHBDKCPKM<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x3FF8470", Offset = "0x3FF7870", VA = "0x183FF8470")]
	public EGIFFLEBCML(GIJHBDKCPKM<TData> ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x3FFEBE0", Offset = "0x3FFDFE0", VA = "0x183FFEBE0", Slot = "4")]
	public override bool JIBIDAAECFI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class KDJIIFGJCDM<TData> : APFKPLKBAOH<GIJHBDKCPKM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private readonly KDHDBHGNOGN<TData> HICIHEGJDGC;

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x4A47FC0", Offset = "0x4A473C0", VA = "0x184A47FC0")]
	public KDJIIFGJCDM(IEnumerable<TData> FCIJLKLJIPE, bool BHEKIOBLFOL, GIJHBDKCPKM<TData> ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x43BBEE0", Offset = "0x43BB2E0", VA = "0x1843BBEE0", Slot = "4")]
	public override bool JIBIDAAECFI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class PCPJCMJADFL<TData> : APFKPLKBAOH<LPELIFJNJKO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly DIGHLAKBKKL<TData> HICIHEGJDGC;

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x507FD90", Offset = "0x507F190", VA = "0x18507FD90")]
	public PCPJCMJADFL(IEnumerable<TData> FCIJLKLJIPE, Vector3 OHBCAHOCLPG, NAIDIGPBPEK DIMKICFLMCM, bool BHEKIOBLFOL, LPELIFJNJKO<TData> ODAGIILJBBF, Space CHHAIGMFKIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x4A3B010", Offset = "0x4A3A410", VA = "0x184A3B010", Slot = "4")]
	public override bool JIBIDAAECFI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class HDIAJFAMFBJ<TData> : APFKPLKBAOH<GIJHBDKCPKM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly JOGFHEDEFKE HICIHEGJDGC;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x45CF0F0", Offset = "0x45CE4F0", VA = "0x1845CF0F0")]
	public HDIAJFAMFBJ(Vector3 GHDIDJJLJAK, GIJHBDKCPKM<TData> ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x45CF090", Offset = "0x45CE490", VA = "0x1845CF090", Slot = "4")]
	public override bool JIBIDAAECFI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public struct FOGKLGIFPLC<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public readonly IEnumerable<TData> FCIJLKLJIPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public readonly Vector3 GHDIDJJLJAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public readonly bool BHEKIOBLFOL;

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x43DFF90", Offset = "0x43DF390", VA = "0x1843DFF90")]
	public FOGKLGIFPLC(IEnumerable<TData> FCIJLKLJIPE, Vector3 GHDIDJJLJAK, bool BHEKIOBLFOL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public struct KDHDBHGNOGN<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public readonly IEnumerable<TData> FCIJLKLJIPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public readonly bool BHEKIOBLFOL;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x4A43210", Offset = "0x4A42610", VA = "0x184A43210")]
	public KDHDBHGNOGN(IEnumerable<TData> FCIJLKLJIPE, bool BHEKIOBLFOL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public struct DIGHLAKBKKL<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public readonly IEnumerable<TData> FCIJLKLJIPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public readonly Vector3 OHBCAHOCLPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public readonly NAIDIGPBPEK DIMKICFLMCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public readonly bool BHEKIOBLFOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public readonly Space CHHAIGMFKIM;

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x62ADE80", Offset = "0x62AD280", VA = "0x1862ADE80")]
	public DIGHLAKBKKL(IEnumerable<TData> FCIJLKLJIPE, Vector3 OHBCAHOCLPG, NAIDIGPBPEK DIMKICFLMCM, bool BHEKIOBLFOL, Space CHHAIGMFKIM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public struct JOGFHEDEFKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public readonly Vector3 GHDIDJJLJAK;

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x273E1A0", Offset = "0x273D5A0", VA = "0x18273E1A0")]
	public JOGFHEDEFKE(Vector3 GHDIDJJLJAK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public enum NAIDIGPBPEK
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
public interface PBNDOMECIHF
{
	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JIBIDAAECFI([In] NFGGIBIICKB HBBHJLKOADI);
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class DLJODGKHHEG : APFKPLKBAOH<PBNDOMECIHF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly NFGGIBIICKB HBBHJLKOADI;

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x74B9180", Offset = "0x74B8580", VA = "0x1874B9180")]
	public DLJODGKHHEG(bool BHEKIOBLFOL, PBNDOMECIHF ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x74B90D0", Offset = "0x74B84D0", VA = "0x1874B90D0", Slot = "4")]
	public override bool JIBIDAAECFI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public readonly struct NFGGIBIICKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly bool BHEKIOBLFOL;

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x2740760", Offset = "0x273FB60", VA = "0x182740760")]
	public NFGGIBIICKB(bool BHEKIOBLFOL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public interface CMEBMCLJBAN<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JIBIDAAECFI([In] MPAMJPPJGIJ<TData> IJMAILKIHOO);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JIBIDAAECFI([In] HFKJIEAGIHB<TData> IJMAILKIHOO);
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public interface AIOBHPCMCHM<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BFKPNIEFKBE([In] EHOPBIBGENL<TData> ELLJOKHFCGH);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CJNJCCNDNJO([In] OKAJJLFKGEC HFFOGJKNMBE);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KKEJHABJOGM();
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class CIADGNMIHCI<TData> : APFKPLKBAOH<CMEBMCLJBAN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly MPAMJPPJGIJ<TData> IJMAILKIHOO;

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x5A41970", Offset = "0x5A40D70", VA = "0x185A41970")]
	public CIADGNMIHCI(IEnumerable<TData> FCIJLKLJIPE, Quaternion GHDIDJJLJAK, Vector3? PFPJOCBCLPN, bool KECMBEKJKLO, bool BHEKIOBLFOL, CMEBMCLJBAN<TData> ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x43BBEE0", Offset = "0x43BB2E0", VA = "0x1843BBEE0", Slot = "4")]
	public override bool JIBIDAAECFI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public class LAJKEKKKELF<TData> : APFKPLKBAOH<AIOBHPCMCHM<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x3FF8470", Offset = "0x3FF7870", VA = "0x183FF8470")]
	public LAJKEKKKELF(AIOBHPCMCHM<TData> ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x3FFEBE0", Offset = "0x3FFDFE0", VA = "0x183FFEBE0", Slot = "4")]
	public override bool JIBIDAAECFI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public class NEFKEELJOIK<TData> : APFKPLKBAOH<AIOBHPCMCHM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly EHOPBIBGENL<TData> IJMAILKIHOO;

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x4E29DC0", Offset = "0x4E291C0", VA = "0x184E29DC0")]
	public NEFKEELJOIK(IEnumerable<TData> FCIJLKLJIPE, bool BHEKIOBLFOL, AIOBHPCMCHM<TData> ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x43BBEE0", Offset = "0x43BB2E0", VA = "0x1843BBEE0", Slot = "4")]
	public override bool JIBIDAAECFI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public class BHIIBFCKICD<TData> : APFKPLKBAOH<CMEBMCLJBAN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly HFKJIEAGIHB<TData> IJMAILKIHOO;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x583C840", Offset = "0x583BC40", VA = "0x18583C840")]
	public BHIIBFCKICD(IEnumerable<TData> FCIJLKLJIPE, Quaternion ELHCBGJDCKK, NAIDIGPBPEK AMPDIBGMJDM, Vector3? PFPJOCBCLPN, bool KECMBEKJKLO, bool BHEKIOBLFOL, Space CHHAIGMFKIM, CMEBMCLJBAN<TData> ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x4A3B010", Offset = "0x4A3A410", VA = "0x184A3B010", Slot = "4")]
	public override bool JIBIDAAECFI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public class JGCENEGHJON<TData> : APFKPLKBAOH<AIOBHPCMCHM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly OKAJJLFKGEC IJMAILKIHOO;

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x496F590", Offset = "0x496E990", VA = "0x18496F590")]
	public JGCENEGHJON(Quaternion GHDIDJJLJAK, Vector3? PFPJOCBCLPN, bool KECMBEKJKLO, AIOBHPCMCHM<TData> ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x45CF090", Offset = "0x45CE490", VA = "0x1845CF090", Slot = "4")]
	public override bool JIBIDAAECFI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public struct MPAMJPPJGIJ<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public readonly IEnumerable<TData> FCIJLKLJIPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public readonly Quaternion GHDIDJJLJAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public readonly Vector3? PFPJOCBCLPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public readonly bool KECMBEKJKLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public readonly bool BHEKIOBLFOL;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x4DDC6B0", Offset = "0x4DDBAB0", VA = "0x184DDC6B0")]
	public MPAMJPPJGIJ(IEnumerable<TData> FCIJLKLJIPE, Quaternion GHDIDJJLJAK, Vector3? PFPJOCBCLPN, bool KECMBEKJKLO, bool BHEKIOBLFOL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public struct EHOPBIBGENL<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public readonly IEnumerable<TData> FCIJLKLJIPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public readonly bool BHEKIOBLFOL;

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x4006270", Offset = "0x4005670", VA = "0x184006270")]
	public EHOPBIBGENL(IEnumerable<TData> FCIJLKLJIPE, bool BHEKIOBLFOL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public struct HFKJIEAGIHB<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public readonly IEnumerable<TData> FCIJLKLJIPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public readonly Quaternion ELHCBGJDCKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public readonly NAIDIGPBPEK AMPDIBGMJDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public readonly Vector3? PFPJOCBCLPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public readonly bool KECMBEKJKLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public readonly bool BHEKIOBLFOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public readonly Space CHHAIGMFKIM;

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x45DA7F0", Offset = "0x45D9BF0", VA = "0x1845DA7F0")]
	public HFKJIEAGIHB(IEnumerable<TData> FCIJLKLJIPE, Quaternion ELHCBGJDCKK, NAIDIGPBPEK AMPDIBGMJDM, Vector3? PFPJOCBCLPN, bool KECMBEKJKLO, bool BHEKIOBLFOL, Space CHHAIGMFKIM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public struct OKAJJLFKGEC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public readonly Quaternion GHDIDJJLJAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public readonly Vector3? PFPJOCBCLPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public readonly bool KECMBEKJKLO;

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x5647720", Offset = "0x5646B20", VA = "0x185647720")]
	public OKAJJLFKGEC(Quaternion GHDIDJJLJAK, Vector3? PFPJOCBCLPN, bool KECMBEKJKLO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public interface FJDGOPGEOFH<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BFKPNIEFKBE([In] PNDAFEPPLLA<TData> ELLJOKHFCGH);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CJNJCCNDNJO([In] NNBDCPBJILD HFFOGJKNMBE);

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CJNJCCNDNJO([In] HCJMCFJNAJE HFFOGJKNMBE);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CJNJCCNDNJO([In] PEBOEDCMGFO HFFOGJKNMBE);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool KKEJHABJOGM();
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class EGNCBBDGLCH<TData> : APFKPLKBAOH<FJDGOPGEOFH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private readonly PEBOEDCMGFO PAKJJFHAOAG;

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x4000520", Offset = "0x3FFF920", VA = "0x184000520")]
	public EGNCBBDGLCH(Vector3 PBPLHPNBBPK, float AJFLFDACHCD, Vector3 PFPJOCBCLPN, bool JCLDHAECIGL, bool DGECMGHCIBI, FJDGOPGEOFH<TData> ODAGIILJBBF, Space CHHAIGMFKIM = Space.Self)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x40004C0", Offset = "0x3FFF8C0", VA = "0x1840004C0", Slot = "4")]
	public override bool JIBIDAAECFI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public class ACGPOCGAECI<TData> : APFKPLKBAOH<FJDGOPGEOFH<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x3FF8470", Offset = "0x3FF7870", VA = "0x183FF8470")]
	public ACGPOCGAECI(FJDGOPGEOFH<TData> ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x4792180", Offset = "0x4791580", VA = "0x184792180", Slot = "4")]
	public override bool JIBIDAAECFI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public class MIBEHNAKJKI<TData> : APFKPLKBAOH<FJDGOPGEOFH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private readonly PNDAFEPPLLA<TData> PAKJJFHAOAG;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x4D78F70", Offset = "0x4D78370", VA = "0x184D78F70")]
	public MIBEHNAKJKI(IEnumerable<TData> FCIJLKLJIPE, bool BHEKIOBLFOL, FJDGOPGEOFH<TData> ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x43BBEE0", Offset = "0x43BB2E0", VA = "0x1843BBEE0", Slot = "4")]
	public override bool JIBIDAAECFI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public class GIPGGLBOMOK<TData> : APFKPLKBAOH<FJDGOPGEOFH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private readonly HCJMCFJNAJE PAKJJFHAOAG;

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x44FE890", Offset = "0x44FDC90", VA = "0x1844FE890")]
	public GIPGGLBOMOK(float PDAFHLKCKLD, bool NPJKLKFPNJD, Vector3 PFPJOCBCLPN, FJDGOPGEOFH<TData> ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x44FE7D0", Offset = "0x44FDBD0", VA = "0x1844FE7D0", Slot = "4")]
	public override bool JIBIDAAECFI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public class HMBMGOKPEJI<TData> : APFKPLKBAOH<FJDGOPGEOFH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private readonly NNBDCPBJILD PAKJJFHAOAG;

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x462FD50", Offset = "0x462F150", VA = "0x18462FD50")]
	public HMBMGOKPEJI(float AJFLFDACHCD, Vector3 PFPJOCBCLPN, FJDGOPGEOFH<TData> ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x45CF090", Offset = "0x45CE490", VA = "0x1845CF090", Slot = "4")]
	public override bool JIBIDAAECFI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct PEBOEDCMGFO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public readonly Vector3 PBPLHPNBBPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public readonly float AJFLFDACHCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public readonly Vector3 PFPJOCBCLPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public readonly bool MFIJLIIOKLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public readonly Space CHHAIGMFKIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public readonly bool DGECMGHCIBI;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x74BA330", Offset = "0x74B9730", VA = "0x1874BA330")]
	public PEBOEDCMGFO(Vector3 PBPLHPNBBPK, float AJFLFDACHCD, Vector3 PFPJOCBCLPN, bool MFIJLIIOKLA, bool AFKONLHNHHD, Space CHHAIGMFKIM = Space.Self)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public struct PNDAFEPPLLA<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public readonly IEnumerable<TData> FCIJLKLJIPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public readonly bool BHEKIOBLFOL;

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x50AF0B0", Offset = "0x50AE4B0", VA = "0x1850AF0B0")]
	public PNDAFEPPLLA(IEnumerable<TData> FCIJLKLJIPE, bool BHEKIOBLFOL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public struct HCJMCFJNAJE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly float PDAFHLKCKLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public readonly bool NPJKLKFPNJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly Vector3 PFPJOCBCLPN;

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x74B9870", Offset = "0x74B8C70", VA = "0x1874B9870")]
	public HCJMCFJNAJE(float PDAFHLKCKLD, bool NPJKLKFPNJD, Vector3 PFPJOCBCLPN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public struct NNBDCPBJILD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public readonly float AJFLFDACHCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public readonly Vector3 PFPJOCBCLPN;

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x560C4E0", Offset = "0x560B8E0", VA = "0x18560C4E0")]
	public NNBDCPBJILD(float AJFLFDACHCD, Vector3 PFPJOCBCLPN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public struct PEKECMMPKPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public readonly Guid[] FCIJLKLJIPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public readonly bool NBJAIMCPKJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public readonly bool LCOLBJKEOJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public readonly bool ANHFDCFDAGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public readonly Vector3[] JHJNMCGMILB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public readonly Quaternion[] BNCHPEOHGHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public readonly float[] FNPOJCFIKHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public readonly Dictionary<Guid, Vector3> EPMILFMHIFA;

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x74BA540", Offset = "0x74B9940", VA = "0x1874BA540")]
	public PEKECMMPKPE(Guid[] NHBKKNDCMHL, Vector3[] JHJNMCGMILB, Quaternion[] BNCHPEOHGHC, float[] FNPOJCFIKHB, Dictionary<Guid, Vector3> EPMILFMHIFA, bool NBJAIMCPKJM = true, bool LCOLBJKEOJG = true, bool ANHFDCFDAGJ = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x74BA370", Offset = "0x74B9770", VA = "0x1874BA370")]
	private static void ABADDHBFCMJ(Dictionary<Guid, Vector3> EPMILFMHIFA, int JJKOODBGBNE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public static class FCLBEIGFFNJ
{
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	private struct OPFPGOFAKKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public bool DGIKMNKDLAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public GFKEMDIOCPC GJEBDKBIJEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public GFKEMDIOCPC CILHLGFKJJF;
	}

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static OPFPGOFAKKE KBEMACPJAGJ;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static CancellationToken FGEHPLBEBHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x74B9470", Offset = "0x74B8870", VA = "0x1874B9470")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	internal static GFKEMDIOCPC GJEBDKBIJEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x74B9550", Offset = "0x74B8950", VA = "0x1874B9550")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x74B9490", Offset = "0x74B8890", VA = "0x1874B9490")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x74B9750", Offset = "0x74B8B50", VA = "0x1874B9750")]
	[HLOHOCOKELO.JGEFFJBDHJI]
	internal static void NADFCFLHLDK(GFKEMDIOCPC PMNANPLKDCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x74B95F0", Offset = "0x74B89F0", VA = "0x1874B95F0")]
	public static void KLOHADBCHCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x74B9500", Offset = "0x74B8900", VA = "0x1874B9500")]
	private static GFKEMDIOCPC ICBOADJOEDF(GFKEMDIOCPC MJDEJLBGNCP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public static class LEJAKJKOMKC
{
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public enum MJBCINFIDIK
	{
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		ICreationContextObject,
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		Guid
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x347D180", Offset = "0x347C580", VA = "0x18347D180")]
	public static void GBNLDNGBKHP<T>(T AIHLLHKMGGB, MJBCINFIDIK BMIPLDLMPCD) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x347D2E0", Offset = "0x347C6E0", VA = "0x18347D2E0")]
	public static void GBNLDNGBKHP<T>(T AIHLLHKMGGB) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x347D460", Offset = "0x347C860", VA = "0x18347D460")]
	public static void IMCNCJIHOCG<T>(T AIHLLHKMGGB) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x347D510", Offset = "0x347C910", VA = "0x18347D510")]
	public static T NPPDIJEBOHO<T>(MJBCINFIDIK BMIPLDLMPCD) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x347CF70", Offset = "0x347C370", VA = "0x18347CF70")]
	public static bool FKKNKLKECHH<T>(MJBCINFIDIK BMIPLDLMPCD, T? LGBOOPLIFEM, [Out][MaybeNullWhen(false)][NotNullWhen(true)] T HNOCBKHMABF) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x347D350", Offset = "0x347C750", VA = "0x18347D350")]
	public static bool HMBPMHFJJBO<T>(MJBCINFIDIK BMIPLDLMPCD, [Out][MaybeNullWhen(false)][NotNullWhen(true)] T EKDDOCEMONB) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x347CE60", Offset = "0x347C260", VA = "0x18347CE60")]
	public static bool BMMDOMLIOEA<T>(MJBCINFIDIK BMIPLDLMPCD) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x347CF10", Offset = "0x347C310", VA = "0x18347CF10")]
	public static T NPPDIJEBOHO<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x347D0C0", Offset = "0x347C4C0", VA = "0x18347D0C0")]
	public static bool FKKNKLKECHH<T>(T LGBOOPLIFEM, [Out] T HNOCBKHMABF) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x347CF10", Offset = "0x347C310", VA = "0x18347CF10")]
	public static bool BMMDOMLIOEA<T>() where T : class
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
internal static class PMHEDBGNKOH
{
	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x74BA7D0", Offset = "0x74B9BD0", VA = "0x1874BA7D0")]
	public static void KDADILCLMPO(IEnumerable MIBGPEMJMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x35CE910", Offset = "0x35CDD10", VA = "0x1835CE910")]
	public static void KDADILCLMPO<T>(T[] CJFOOLJEHLK) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x35CEAF0", Offset = "0x35CDEF0", VA = "0x1835CEAF0")]
	public static void KDADILCLMPO<T>(T JJFHAAOAACO) where T : notnull, Enum
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
