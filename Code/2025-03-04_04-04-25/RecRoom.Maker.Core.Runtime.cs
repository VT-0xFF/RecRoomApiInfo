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
		[Cpp2IlInjected.Address(RVA = "0x97B910", Offset = "0x979F10", VA = "0x18097B910")]
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
		[Cpp2IlInjected.Address(RVA = "0x75585C0", Offset = "0x7556BC0", VA = "0x1875585C0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x97C6E0", Offset = "0x97ACE0", VA = "0x18097C6E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x97C720", Offset = "0x97AD20", VA = "0x18097C720")]
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
		[Cpp2IlInjected.Address(RVA = "0x7558E80", Offset = "0x7557480", VA = "0x187558E80", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x245DCB0", Offset = "0x245C2B0", VA = "0x18245DCB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x404AD70", Offset = "0x4049370", VA = "0x18404AD70")]
	public APFKPLKBAOH(TReceiver ODAGIILJBBF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public abstract class NJOIHIKKOPK<TReceiver, TFromTask> : NFFHPBAPHBA<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x404AD70", Offset = "0x4049370", VA = "0x18404AD70")]
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
	[Cpp2IlInjected.Address(RVA = "0x4E985D0", Offset = "0x4E96BD0", VA = "0x184E985D0")]
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
	[Cpp2IlInjected.Address(RVA = "0x404AD70", Offset = "0x4049370", VA = "0x18404AD70")]
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
	[Cpp2IlInjected.Address(RVA = "0x246E9F0", Offset = "0x246CFF0", VA = "0x18246E9F0")]
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
	[Cpp2IlInjected.Address(RVA = "0x9B2EC0", Offset = "0x9B14C0", VA = "0x1809B2EC0")]
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
	[Cpp2IlInjected.Address(RVA = "0xBD5420", Offset = "0xBD3A20", VA = "0x180BD5420")]
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
	[Cpp2IlInjected.Address(RVA = "0x75573C0", Offset = "0x75559C0", VA = "0x1875573C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x22D2220", Offset = "0x22D0820", VA = "0x1822D2220")]
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
	[Cpp2IlInjected.Address(RVA = "0x4061C50", Offset = "0x4060250", VA = "0x184061C50")]
	public EJCAPDAILOM(TGroup LLKLEGPHLKE, IEnumerable<TData> FCIJLKLJIPE, NFHHNBDKLAC<TGroup, TData> ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x4061B80", Offset = "0x4060180", VA = "0x184061B80", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x44CBBF0", Offset = "0x44CA1F0", VA = "0x1844CBBF0")]
	public GBEDBKKFIOH(TGroup LLKLEGPHLKE, TData FDAEKEPGKDB, IEnumerable<TData> FCIJLKLJIPE, NFHHNBDKLAC<TGroup, TData> ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x44CBB20", Offset = "0x44CA120", VA = "0x1844CBB20", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x4048000", Offset = "0x4046600", VA = "0x184048000")]
	public EAJDLEKCEDA(TGroup LLKLEGPHLKE, NFHHNBDKLAC<TGroup, TData> ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x4047F40", Offset = "0x4046540", VA = "0x184047F40", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x44CBBF0", Offset = "0x44CA1F0", VA = "0x1844CBBF0")]
	public IELPLHMMMMD(TGroup LLKLEGPHLKE, TData LILLILCKGGB, IEnumerable<TData> FCIJLKLJIPE, NFHHNBDKLAC<TGroup, TData> ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4776EE0", Offset = "0x47754E0", VA = "0x184776EE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x75570C0", Offset = "0x75556C0", VA = "0x1875570C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7557350", Offset = "0x7555950", VA = "0x187557350", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private DAJMIEACADO PPGANHCEOKO;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7557E00", Offset = "0x7556400", VA = "0x187557E00")]
	public HEEEILMCGLA(IEnumerable<Guid> HAOLHJJKIIE, Guid KOHCBOMIKFA, bool BHEKIOBLFOL, MDCEEALKPEH ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7557D10", Offset = "0x7556310", VA = "0x187557D10", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x7557EC0", Offset = "0x75564C0", VA = "0x187557EC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7558160", Offset = "0x7556760", VA = "0x187558160", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly OKIFHLPEGBK PPGANHCEOKO;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7558730", Offset = "0x7556D30", VA = "0x187558730")]
	public OLPCIMJMJJP(Guid KOHCBOMIKFA, bool BHEKIOBLFOL, MDCEEALKPEH ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7558640", Offset = "0x7556C40", VA = "0x187558640", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x7557CD0", Offset = "0x75562D0", VA = "0x187557CD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x4FEB030", Offset = "0x4FE9630", VA = "0x184FEB030", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x4439A20", Offset = "0x4438020", VA = "0x184439A20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly HAKMDCKLAPO MCMDEPLHMAJ;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6302050", Offset = "0x6300650", VA = "0x186302050")]
	public DFHPEFPEGIE(BKMAHIJIAJO OOIEKBGEBJE, bool BHEKIOBLFOL, KOIKEELCBLC<TSpawnType> ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6301D50", Offset = "0x6300350", VA = "0x186301D50", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x7556F70", Offset = "0x7555570", VA = "0x187556F70")]
	public BKMAHIJIAJO(Transform EMAHOHDKPIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7556F40", Offset = "0x7555540", VA = "0x187556F40")]
	public BKMAHIJIAJO(Vector3 FGKLFPNFOKI, Vector3 NDADPNJPMFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7556E80", Offset = "0x7555480", VA = "0x187556E80")]
	public static BKMAHIJIAJO KKJJGGFFFGK()
	{
		return default(BKMAHIJIAJO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7556EB0", Offset = "0x75554B0", VA = "0x187556EB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x500DE70", Offset = "0x500C470", VA = "0x18500DE70")]
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
	[Cpp2IlInjected.Address(RVA = "0x4791960", Offset = "0x478FF60", VA = "0x184791960")]
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
	[Cpp2IlInjected.Address(RVA = "0x404AD70", Offset = "0x4049370", VA = "0x18404AD70")]
	public GPDMPPLNHOI(OCBMIBJKPHL<TNode, TReparentOperations> ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x45BFAD0", Offset = "0x45BE0D0", VA = "0x1845BFAD0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x4A981A0", Offset = "0x4A967A0", VA = "0x184A981A0")]
	public KBMMNFEMMEE(TNode LDFDPDALOOA, TReparentOperations LIJHANBCGEB, OOAEPBFJOGI ECBBIOKIOEM, OCBMIBJKPHL<TNode, TReparentOperations> ODAGIILJBBF, bool BHEKIOBLFOL = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x4A980E0", Offset = "0x4A966E0", VA = "0x184A980E0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x47D0610", Offset = "0x47CEC10", VA = "0x1847D0610")]
	public AFHIFGMFBJB(TNode LKCMDFMIPFB, OCBMIBJKPHL<TNode, TReparentOperations> ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x44152D0", Offset = "0x44138D0", VA = "0x1844152D0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x51086C0", Offset = "0x5106CC0", VA = "0x1851086C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x4FEB8C0", Offset = "0x4FE9EC0", VA = "0x184FEB8C0")]
	public ODNBDFAHBCA(TSpawnInfo PBEKJKIAFOA, Vector3 NDADPNJPMFO, Quaternion MLMNPOCKAAE, float JJCKONKIIAI, EJOBKNOBJKO<TSpawnType, TSpawnInfo> ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x49C9320", Offset = "0x49C7920", VA = "0x1849C9320", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x43FD640", Offset = "0x43FBC40", VA = "0x1843FD640")]
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
	[Cpp2IlInjected.Address(RVA = "0x49C94B0", Offset = "0x49C7AB0", VA = "0x1849C94B0")]
	public JFLOBLNHENG(IEnumerable<TData> FCIJLKLJIPE, bool BHEKIOBLFOL, AFNKBGBDIFD<TData> ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x49C9320", Offset = "0x49C7920", VA = "0x1849C9320", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x46821B0", Offset = "0x46807B0", VA = "0x1846821B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x441D1D0", Offset = "0x441B7D0", VA = "0x18441D1D0")]
	public FFJNNFIGDJH(T GHCOFKNEAHE, bool JCEAEDIKDGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class FBBPDEKGHJD<T> : APFKPLKBAOH<IMNNGKPIIHL<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x404AD70", Offset = "0x4049370", VA = "0x18404AD70")]
	public FBBPDEKGHJD(IMNNGKPIIHL<T> ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x440FFB0", Offset = "0x440E5B0", VA = "0x18440FFB0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x4415390", Offset = "0x4413990", VA = "0x184415390")]
	public FCNLFGOOOGC(T MOCLCNOAHKF, IMNNGKPIIHL<T> ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x44152D0", Offset = "0x44138D0", VA = "0x1844152D0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x58AB0A0", Offset = "0x58A96A0", VA = "0x1858AB0A0")]
	public BJOHDEJLFIM(T MOCLCNOAHKF, bool JCEAEDIKDGF, LHCEMLBGAFI<T> ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x44152D0", Offset = "0x44138D0", VA = "0x1844152D0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x589B350", Offset = "0x5899950", VA = "0x18589B350")]
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
	[Cpp2IlInjected.Address(RVA = "0x510ACA0", Offset = "0x51092A0", VA = "0x18510ACA0")]
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
	[Cpp2IlInjected.Address(RVA = "0x4672C20", Offset = "0x4671220", VA = "0x184672C20")]
	public ABEGKGEOCKH(List<TData> FCIJLKLJIPE, bool GMMJGLHECAF, DGHHLPOMDLG<TData> ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x44152D0", Offset = "0x44138D0", VA = "0x1844152D0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x49CF520", Offset = "0x49CDB20", VA = "0x1849CF520")]
	public JIPCKBFEGHB(List<TData> FCIJLKLJIPE, List<bool> FKLHNKDMLNB, DGHHLPOMDLG<TData> ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x4555E10", Offset = "0x4554410", VA = "0x184555E10", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x4786F10", Offset = "0x4785510", VA = "0x184786F10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x47871F0", Offset = "0x47857F0", VA = "0x1847871F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly DONHGFFPGCF<TData> EBHLNLLOHGG;

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x4AC1BE0", Offset = "0x4AC01E0", VA = "0x184AC1BE0")]
	public KKOJBPPKNDN(TData NIKIICPONPG, IReadOnlyList<TData> LIABPJFBJFH, bool BHEKIOBLFOL, AGAOHOLGDMP<TData> ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x4AC1AE0", Offset = "0x4AC00E0", VA = "0x184AC1AE0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x56C09A0", Offset = "0x56BEFA0", VA = "0x1856C09A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x589EDC0", Offset = "0x589D3C0", VA = "0x18589EDC0")]
	public BFAMOOLCGMO(IEnumerable<TData> FCIJLKLJIPE, MONBNMPFMMO NHCBHMJDLHA, CEHJAJCAOIA HJCEHLILOIG, float LNCPFBAGODO, bool BHEKIOBLFOL, GOBKINNKHBO<TData> ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x44152D0", Offset = "0x44138D0", VA = "0x1844152D0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x4AA87C0", Offset = "0x4AA6DC0", VA = "0x184AA87C0")]
	public KEJOELPLIND(TData[] FCIJLKLJIPE, MONBNMPFMMO[] NHCBHMJDLHA, CEHJAJCAOIA[] HJCEHLILOIG, float[] LNCPFBAGODO, LNLLDFMBGOJ<TData> ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x4AA8620", Offset = "0x4AA6C20", VA = "0x184AA8620", Slot = "4")]
	public override bool JIBIDAAECFI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class KLJGCKGILGM<TData> : APFKPLKBAOH<LINHBCNPHLB<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x404AD70", Offset = "0x4049370", VA = "0x18404AD70")]
	public KLJGCKGILGM(LINHBCNPHLB<TData> ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x4AC2740", Offset = "0x4AC0D40", VA = "0x184AC2740", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x4BAF390", Offset = "0x4BAD990", VA = "0x184BAF390")]
	public LCANKANCGJD(IEnumerable<TData> FCIJLKLJIPE, MONBNMPFMMO NHCBHMJDLHA, CEHJAJCAOIA HJCEHLILOIG, float LNCPFBAGODO, LINHBCNPHLB<TData> ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x4AA8620", Offset = "0x4AA6C20", VA = "0x184AA8620", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x407DFB0", Offset = "0x407C5B0", VA = "0x18407DFB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5A622E0", Offset = "0x5A608E0", VA = "0x185A622E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x49C7370", Offset = "0x49C5970", VA = "0x1849C7370")]
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
	[Cpp2IlInjected.Address(RVA = "0x5108CF0", Offset = "0x51072F0", VA = "0x185108CF0")]
	public PKDNNNDDMAN(List<TData> FDMJAFAEFBP, MJKCLLBEJHF<TData> ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x44152D0", Offset = "0x44138D0", VA = "0x1844152D0", Slot = "4")]
	public override bool JIBIDAAECFI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class OJGJJPIJOFI<TData> : APFKPLKBAOH<MJKCLLBEJHF<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x404AD70", Offset = "0x4049370", VA = "0x18404AD70")]
	public OJGJJPIJOFI(MJKCLLBEJHF<TData> ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x500F670", Offset = "0x500DC70", VA = "0x18500F670", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x4AC2280", Offset = "0x4AC0880", VA = "0x184AC2280")]
	public KLDMNJGOHBG(bool BHEKIOBLFOL, MJKCLLBEJHF<TData> ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x4AC2220", Offset = "0x4AC0820", VA = "0x184AC2220", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x4555ED0", Offset = "0x45544D0", VA = "0x184555ED0")]
	public GHABIMGNCIK(List<TData> FDMJAFAEFBP, bool BHEKIOBLFOL, MJKCLLBEJHF<TData> ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x4555E10", Offset = "0x4554410", VA = "0x184555E10", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x63276E0", Offset = "0x6325CE0", VA = "0x1863276E0")]
	public DNCAJEFHJHC(TData JIOJOECFEAH, MJKCLLBEJHF<TData> ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6327620", Offset = "0x6325C20", VA = "0x186327620", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x4FEE0C0", Offset = "0x4FEC6C0", VA = "0x184FEE0C0")]
	public OEMGKHCABFP(IEnumerable<TData> FDMJAFAEFBP, MJKCLLBEJHF<TData> ODAGIILJBBF, bool BHEKIOBLFOL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x4FEDF50", Offset = "0x4FEC550", VA = "0x184FEDF50", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x47D89B0", Offset = "0x47D6FB0", VA = "0x1847D89B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x75582C0", Offset = "0x75568C0", VA = "0x1875582C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7558540", Offset = "0x7556B40", VA = "0x187558540", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly PFCEBMLNCMA JHLMOBFJHIO;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x75574F0", Offset = "0x7555AF0", VA = "0x1875574F0")]
	public DCMPPMAFFEE(bool BHEKIOBLFOL, HLKHGJOOAHP ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7557400", Offset = "0x7555A00", VA = "0x187557400", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x27743C0", Offset = "0x27729C0", VA = "0x1827743C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x56DDB10", Offset = "0x56DC110", VA = "0x1856DDB10")]
	public MJJNNHFJKNJ(bool JCDGAMLKJPI, bool JFKELDAANDC, bool JJCKONKIIAI, bool BHEKIOBLFOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x75585B0", Offset = "0x7556BB0", VA = "0x1875585B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x7557030", Offset = "0x7555630", VA = "0x187557030")]
	public CDIMOKAGNID(bool EJNLPEDOMDD, bool JFKELDAANDC, bool JJCKONKIIAI, bool BHEKIOBLFOL, IIBPHHAGENJ ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x7556FE0", Offset = "0x75555E0", VA = "0x187556FE0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x7558220", Offset = "0x7556820", VA = "0x187558220")]
	public LDMOAANOJKJ(bool JFKELDAANDC, bool BHEKIOBLFOL, IIBPHHAGENJ ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x75581D0", Offset = "0x75567D0", VA = "0x1875581D0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x7557710", Offset = "0x7555D10", VA = "0x187557710")]
	public EANMMOAEKAN(Guid[] NHBKKNDCMHL, Vector3[] JHJNMCGMILB, Quaternion[] BNCHPEOHGHC, float[] FNPOJCFIKHB, Dictionary<Guid, Vector3> EPMILFMHIFA, EFKHBLLIHBD ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x7557660", Offset = "0x7555C60", VA = "0x187557660", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x404AD70", Offset = "0x4049370", VA = "0x18404AD70")]
	public LFNIDPINNEA(PIKLKELJPME<TData> ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x4BB9790", Offset = "0x4BB7D90", VA = "0x184BB9790", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x4682320", Offset = "0x4680920", VA = "0x184682320")]
	public HIGEKPJPIHB(Vector3 KDBPBMFFBHM, bool MFIJLIIOKLA, PIKLKELJPME<TData> ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x4629010", Offset = "0x4627610", VA = "0x184629010", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x477B640", Offset = "0x4779C40", VA = "0x18477B640")]
	public IJLDINCEFLO(Guid INNIACIGJGO, int EAHKFAJBNDN, Vector3 NDADPNJPMFO, Quaternion MLMNPOCKAAE, float PMGAIALCDAG, bool MFIJLIIOKLA, PIKLKELJPME<TData> ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x477B5E0", Offset = "0x4779BE0", VA = "0x18477B5E0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x4BC1260", Offset = "0x4BBF860", VA = "0x184BC1260")]
	public LJINBMADKON(TData MOCLCNOAHKF, bool BHEKIOBLFOL, PIKLKELJPME<TData> ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x44152D0", Offset = "0x44138D0", VA = "0x1844152D0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x75582A0", Offset = "0x75568A0", VA = "0x1875582A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x7556E40", Offset = "0x7555440", VA = "0x187556E40")]
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
	[Cpp2IlInjected.Address(RVA = "0x46834E0", Offset = "0x4681AE0", VA = "0x1846834E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x46C14E0", Offset = "0x46BFAE0", VA = "0x1846C14E0")]
	public HOBNNNHDPAJ(IEnumerable<TData> FCIJLKLJIPE, Vector3 GHDIDJJLJAK, bool BHEKIOBLFOL, LPELIFJNJKO<TData> ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x44152D0", Offset = "0x44138D0", VA = "0x1844152D0", Slot = "4")]
	public override bool JIBIDAAECFI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public class EGIFFLEBCML<TData> : APFKPLKBAOH<GIJHBDKCPKM<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x404AD70", Offset = "0x4049370", VA = "0x18404AD70")]
	public EGIFFLEBCML(GIJHBDKCPKM<TData> ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x4051860", Offset = "0x404FE60", VA = "0x184051860", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x4AA5350", Offset = "0x4AA3950", VA = "0x184AA5350")]
	public KDJIIFGJCDM(IEnumerable<TData> FCIJLKLJIPE, bool BHEKIOBLFOL, GIJHBDKCPKM<TData> ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x44152D0", Offset = "0x44138D0", VA = "0x1844152D0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x50DE3D0", Offset = "0x50DC9D0", VA = "0x1850DE3D0")]
	public PCPJCMJADFL(IEnumerable<TData> FCIJLKLJIPE, Vector3 OHBCAHOCLPG, NAIDIGPBPEK DIMKICFLMCM, bool BHEKIOBLFOL, LPELIFJNJKO<TData> ODAGIILJBBF, Space CHHAIGMFKIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x4A980E0", Offset = "0x4A966E0", VA = "0x184A980E0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x4629070", Offset = "0x4627670", VA = "0x184629070")]
	public HDIAJFAMFBJ(Vector3 GHDIDJJLJAK, GIJHBDKCPKM<TData> ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x4629010", Offset = "0x4627610", VA = "0x184629010", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x4439B70", Offset = "0x4438170", VA = "0x184439B70")]
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
	[Cpp2IlInjected.Address(RVA = "0x4AA0550", Offset = "0x4A9EB50", VA = "0x184AA0550")]
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
	[Cpp2IlInjected.Address(RVA = "0x6316050", Offset = "0x6314650", VA = "0x186316050")]
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
	[Cpp2IlInjected.Address(RVA = "0x2771E00", Offset = "0x2770400", VA = "0x182771E00")]
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
	[Cpp2IlInjected.Address(RVA = "0x7557600", Offset = "0x7555C00", VA = "0x187557600")]
	public DLJODGKHHEG(bool BHEKIOBLFOL, PBNDOMECIHF ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x7557550", Offset = "0x7555B50", VA = "0x187557550", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x27743C0", Offset = "0x27729C0", VA = "0x1827743C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5B5B6F0", Offset = "0x5B59CF0", VA = "0x185B5B6F0")]
	public CIADGNMIHCI(IEnumerable<TData> FCIJLKLJIPE, Quaternion GHDIDJJLJAK, Vector3? PFPJOCBCLPN, bool KECMBEKJKLO, bool BHEKIOBLFOL, CMEBMCLJBAN<TData> ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x44152D0", Offset = "0x44138D0", VA = "0x1844152D0", Slot = "4")]
	public override bool JIBIDAAECFI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public class LAJKEKKKELF<TData> : APFKPLKBAOH<AIOBHPCMCHM<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x404AD70", Offset = "0x4049370", VA = "0x18404AD70")]
	public LAJKEKKKELF(AIOBHPCMCHM<TData> ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x4051860", Offset = "0x404FE60", VA = "0x184051860", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x4E943D0", Offset = "0x4E929D0", VA = "0x184E943D0")]
	public NEFKEELJOIK(IEnumerable<TData> FCIJLKLJIPE, bool BHEKIOBLFOL, AIOBHPCMCHM<TData> ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x44152D0", Offset = "0x44138D0", VA = "0x1844152D0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x58A0130", Offset = "0x589E730", VA = "0x1858A0130")]
	public BHIIBFCKICD(IEnumerable<TData> FCIJLKLJIPE, Quaternion ELHCBGJDCKK, NAIDIGPBPEK AMPDIBGMJDM, Vector3? PFPJOCBCLPN, bool KECMBEKJKLO, bool BHEKIOBLFOL, Space CHHAIGMFKIM, CMEBMCLJBAN<TData> ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x4A980E0", Offset = "0x4A966E0", VA = "0x184A980E0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x49CAF90", Offset = "0x49C9590", VA = "0x1849CAF90")]
	public JGCENEGHJON(Quaternion GHDIDJJLJAK, Vector3? PFPJOCBCLPN, bool KECMBEKJKLO, AIOBHPCMCHM<TData> ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x4629010", Offset = "0x4627610", VA = "0x184629010", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x4E3A1F0", Offset = "0x4E387F0", VA = "0x184E3A1F0")]
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
	[Cpp2IlInjected.Address(RVA = "0x4058EF0", Offset = "0x40574F0", VA = "0x184058EF0")]
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
	[Cpp2IlInjected.Address(RVA = "0x4634770", Offset = "0x4632D70", VA = "0x184634770")]
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
	[Cpp2IlInjected.Address(RVA = "0x56A4510", Offset = "0x56A2B10", VA = "0x1856A4510")]
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
	[Cpp2IlInjected.Address(RVA = "0x40531A0", Offset = "0x40517A0", VA = "0x1840531A0")]
	public EGNCBBDGLCH(Vector3 PBPLHPNBBPK, float AJFLFDACHCD, Vector3 PFPJOCBCLPN, bool JCLDHAECIGL, bool DGECMGHCIBI, FJDGOPGEOFH<TData> ODAGIILJBBF, Space CHHAIGMFKIM = Space.Self)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x4053140", Offset = "0x4051740", VA = "0x184053140", Slot = "4")]
	public override bool JIBIDAAECFI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public class ACGPOCGAECI<TData> : APFKPLKBAOH<FJDGOPGEOFH<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x404AD70", Offset = "0x4049370", VA = "0x18404AD70")]
	public ACGPOCGAECI(FJDGOPGEOFH<TData> ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x47C70F0", Offset = "0x47C56F0", VA = "0x1847C70F0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x4DD69B0", Offset = "0x4DD4FB0", VA = "0x184DD69B0")]
	public MIBEHNAKJKI(IEnumerable<TData> FCIJLKLJIPE, bool BHEKIOBLFOL, FJDGOPGEOFH<TData> ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x44152D0", Offset = "0x44138D0", VA = "0x1844152D0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x4557F60", Offset = "0x4556560", VA = "0x184557F60")]
	public GIPGGLBOMOK(float PDAFHLKCKLD, bool NPJKLKFPNJD, Vector3 PFPJOCBCLPN, FJDGOPGEOFH<TData> ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x4557EA0", Offset = "0x45564A0", VA = "0x184557EA0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x46998D0", Offset = "0x4697ED0", VA = "0x1846998D0")]
	public HMBMGOKPEJI(float AJFLFDACHCD, Vector3 PFPJOCBCLPN, FJDGOPGEOFH<TData> ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x4629010", Offset = "0x4627610", VA = "0x184629010", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x75587B0", Offset = "0x7556DB0", VA = "0x1875587B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x510D6C0", Offset = "0x510BCC0", VA = "0x18510D6C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x7557CF0", Offset = "0x75562F0", VA = "0x187557CF0")]
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
	[Cpp2IlInjected.Address(RVA = "0x567C120", Offset = "0x567A720", VA = "0x18567C120")]
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
	[Cpp2IlInjected.Address(RVA = "0x75589C0", Offset = "0x7556FC0", VA = "0x1875589C0")]
	public PEKECMMPKPE(Guid[] NHBKKNDCMHL, Vector3[] JHJNMCGMILB, Quaternion[] BNCHPEOHGHC, float[] FNPOJCFIKHB, Dictionary<Guid, Vector3> EPMILFMHIFA, bool NBJAIMCPKJM = true, bool LCOLBJKEOJG = true, bool ANHFDCFDAGJ = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x75587F0", Offset = "0x7556DF0", VA = "0x1875587F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x75578F0", Offset = "0x7555EF0", VA = "0x1875578F0")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	internal static GFKEMDIOCPC GJEBDKBIJEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x75579D0", Offset = "0x7555FD0", VA = "0x1875579D0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7557910", Offset = "0x7555F10", VA = "0x187557910")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x7557BD0", Offset = "0x75561D0", VA = "0x187557BD0")]
	[HLOHOCOKELO.JGEFFJBDHJI]
	internal static void NADFCFLHLDK(GFKEMDIOCPC PMNANPLKDCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x7557A70", Offset = "0x7556070", VA = "0x187557A70")]
	public static void KLOHADBCHCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x7557980", Offset = "0x7555F80", VA = "0x187557980")]
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
	[Cpp2IlInjected.Address(RVA = "0x34C7CE0", Offset = "0x34C62E0", VA = "0x1834C7CE0")]
	public static void GBNLDNGBKHP<T>(T AIHLLHKMGGB, MJBCINFIDIK BMIPLDLMPCD) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x34C7E40", Offset = "0x34C6440", VA = "0x1834C7E40")]
	public static void GBNLDNGBKHP<T>(T AIHLLHKMGGB) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x34C7FC0", Offset = "0x34C65C0", VA = "0x1834C7FC0")]
	public static void IMCNCJIHOCG<T>(T AIHLLHKMGGB) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x34C8070", Offset = "0x34C6670", VA = "0x1834C8070")]
	public static T NPPDIJEBOHO<T>(MJBCINFIDIK BMIPLDLMPCD) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x34C7AD0", Offset = "0x34C60D0", VA = "0x1834C7AD0")]
	public static bool FKKNKLKECHH<T>(MJBCINFIDIK BMIPLDLMPCD, T? LGBOOPLIFEM, [Out][MaybeNullWhen(false)][NotNullWhen(true)] T HNOCBKHMABF) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x34C7EB0", Offset = "0x34C64B0", VA = "0x1834C7EB0")]
	public static bool HMBPMHFJJBO<T>(MJBCINFIDIK BMIPLDLMPCD, [Out][MaybeNullWhen(false)][NotNullWhen(true)] T EKDDOCEMONB) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x34C79C0", Offset = "0x34C5FC0", VA = "0x1834C79C0")]
	public static bool BMMDOMLIOEA<T>(MJBCINFIDIK BMIPLDLMPCD) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x34C7A70", Offset = "0x34C6070", VA = "0x1834C7A70")]
	public static T NPPDIJEBOHO<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x34C7C20", Offset = "0x34C6220", VA = "0x1834C7C20")]
	public static bool FKKNKLKECHH<T>(T LGBOOPLIFEM, [Out] T HNOCBKHMABF) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x34C7A70", Offset = "0x34C6070", VA = "0x1834C7A70")]
	public static bool BMMDOMLIOEA<T>() where T : class
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
internal static class PMHEDBGNKOH
{
	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x7558C50", Offset = "0x7557250", VA = "0x187558C50")]
	public static void KDADILCLMPO(IEnumerable MIBGPEMJMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x36125E0", Offset = "0x3610BE0", VA = "0x1836125E0")]
	public static void KDADILCLMPO<T>(T[] CJFOOLJEHLK) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x36127C0", Offset = "0x3610DC0", VA = "0x1836127C0")]
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
