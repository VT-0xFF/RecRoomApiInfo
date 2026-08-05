using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
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
		[Cpp2IlInjected.Address(RVA = "0x7E5660", Offset = "0x7E4660", VA = "0x1807E5660")]
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
		[Cpp2IlInjected.Address(RVA = "0x61CC010", Offset = "0x61CB010", VA = "0x1861CC010")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7E62B0", Offset = "0x7E52B0", VA = "0x1807E62B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E62F0", Offset = "0x7E52F0", VA = "0x1807E62F0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface OBMHGPBAAON<TData, TReturn>
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TReturn GNGFKEANKDC(TData FGOCJODIEMI);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface JKDNALAFLFA<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ClearHoverTarget(HFEDJLHGAIF BNPEDECBJLE);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool SetHoverTarget(TData PGJBCOPPFBK, Collider KHFDPPDIAJD, HFEDJLHGAIF BNPEDECBJLE, [Optional] LHNKIGKONBG? HGHCJKLBFGH);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool TryGetHoverTarget([Out] TData PGJBCOPPFBK);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetHoverCollider([Out] Collider KHFDPPDIAJD);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface CKCKKAGMBJF<TData> : BIOKBJEKHFG, HDIAONBAOLL<TData>, MBECHCLDEDC<TData>, AGDKBBECNEM<TData>, DNMIMBOHFID, LCLKMEAPJJO<TData>, MKDNECMJCDH, AJGAGBPBOCP
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface LCLKMEAPJJO<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 HOMMOCALEDP, Vector3 PKIECLPJPAP, float GPIGMBNIAGJ, [Out] T GIBFFPFHJJA, [Out] Vector3 NLENLLDODNJ, [Out] Collider KHFDPPDIAJD);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 HOMMOCALEDP, Vector3 PKIECLPJPAP, float JBKFPNMOFBP, float GPIGMBNIAGJ, T[] OGANCOCEGCL, [Out] Vector3 ABILHAABMBA, [Out] Collider GMOACPKJJBL);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 HOMMOCALEDP, float JBKFPNMOFBP, Vector3 HBNHOLGKBHC, T[] OGANCOCEGCL);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetObjectFromColliderInCurrentScope(Collider OFBJNFFGPJP, [Out] T EMAJKEHFJOI);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface BIOKBJEKHFG
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Bounds BEJPLMFPFNB
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Transform CJOINMIPCJI
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Bounds MDJHNOIOBEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Transform FCABAEPGBOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Vector3 OACJNBEOIMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool MGFOBGCKPGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void SetSelectionBoundsDirty(bool LFAHFBEJIAO = true, int NJAIGNKIJOF = 0);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ShouldHideSelectionBoundsPreview(bool KNCPKAMPGAD, object OGACLNNOKDA);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface AJGAGBPBOCP
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	LHMMLLGDOFK HGDOJFMHGNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface OFIMKJAPHNA
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool GEPBNGAIGKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool NJPMKJDBEKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool PAPJFNFDMCK
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
	void TrySetPreviousCloneMapping(Dictionary<Guid, Guid> OABOPCPOCLJ);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface AGDKBBECNEM<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool KLIFDAPINIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int NMBCAHANLDE
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<TData> BEKJDCDCIHN
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData OBBILAKFCOH);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData OBBILAKFCOH);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface HDIAONBAOLL<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T FGOCJODIEMI, [Optional] LHNKIGKONBG? GDBAAAMILCG, bool LDKEHMLAMFN = true);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int FBDNKGNOEFD, IEnumerable<T> DKPNELDIPIB, bool LDKEHMLAMFN = true);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int FBDNKGNOEFD, IEnumerable<T> DKPNELDIPIB, LHNKIGKONBG GDBAAAMILCG, bool LDKEHMLAMFN = true);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface MKDNECMJCDH
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface DNMIMBOHFID
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool JPJPGPLGJKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool GCFPMPNLIDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool BOBHFHEJAPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool FKCGKPLCHGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class MEFIGKAMFEO<TReceiver> : GNIOLMPJCAP<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3659660", Offset = "0x3658660", VA = "0x183659660")]
	public MEFIGKAMFEO(TReceiver ACNOIKBCAAG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class FFNBNPBMMGG<TReceiver, TFromTask> : GNIOLMPJCAP<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3659660", Offset = "0x3658660", VA = "0x183659660")]
	public FFNBNPBMMGG(TReceiver ACNOIKBCAAG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public abstract class GNIOLMPJCAP<TReceiver, TFromExecute> where TReceiver : notnull where TFromExecute : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	protected TReceiver ACNOIKBCAAG;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3768C40", Offset = "0x3767C40", VA = "0x183768C40")]
	public GNIOLMPJCAP(TReceiver ACNOIKBCAAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute GFBEOFOOLCA();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public abstract class MMJNBPKMDAE<TReceiver, TResult> : GNIOLMPJCAP<TReceiver, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3659660", Offset = "0x3658660", VA = "0x183659660")]
	public MMJNBPKMDAE(TReceiver ACNOIKBCAAG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct GGEGHADCKLB<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public TGroup EEDEPBOCNOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public TData NJCHDAMHBEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public IEnumerable<TData> DLIALBOAHMI;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1B04740", Offset = "0x1B03740", VA = "0x181B04740")]
	public GGEGHADCKLB(TGroup AFGEKLLBHEO, TData DBOEDNAMIFH, IEnumerable<TData> FDDNHPOOAMG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct HPGNHPDFBMP<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public TGroup EEDEPBOCNOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public IEnumerable<TData> DLIALBOAHMI;

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x909C10", Offset = "0x908C10", VA = "0x180909C10")]
	public HPGNHPDFBMP(TGroup AFGEKLLBHEO, IEnumerable<TData> FDDNHPOOAMG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct EMGFMEEJNHG<TGroup> where TGroup : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public TGroup EEDEPBOCNOL;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x9452D0", Offset = "0x9442D0", VA = "0x1809452D0")]
	public EMGFMEEJNHG(TGroup AFGEKLLBHEO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct CBMHBMJPJHO<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public IEnumerable<TData> DLIALBOAHMI;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x9452D0", Offset = "0x9442D0", VA = "0x1809452D0")]
	public CBMHBMJPJHO(IEnumerable<TData> FDDNHPOOAMG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface IFNKACAHGFH<TGroup, TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NANAKHAEKCF LGDKKLALGEM(GGEGHADCKLB<TGroup, TData> FPBGMDDADHP);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NANAKHAEKCF PFBBKLJBCEH(GGEGHADCKLB<TGroup, TData> FPBGMDDADHP);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NANAKHAEKCF JELCEKIBAPB(HPGNHPDFBMP<TGroup, TData> FPBGMDDADHP);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NANAKHAEKCF EGBOAFJECJJ(EMGFMEEJNHG<TGroup> FPBGMDDADHP);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface LFHDHDNGCMM<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<NANAKHAEKCF> LGDKKLALGEM(CBMHBMJPJHO<TData> FPBGMDDADHP);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class MPFLMNBAEFF<TGroup, TData> : MMJNBPKMDAE<IFNKACAHGFH<TGroup, TData>, NANAKHAEKCF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly HPGNHPDFBMP<TGroup, TData> FPBGMDDADHP;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3EE1830", Offset = "0x3EE0830", VA = "0x183EE1830")]
	public MPFLMNBAEFF(TGroup AFGEKLLBHEO, IEnumerable<TData> FDDNHPOOAMG, IFNKACAHGFH<TGroup, TData> ACNOIKBCAAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3EE1760", Offset = "0x3EE0760", VA = "0x183EE1760", Slot = "4")]
	public override NANAKHAEKCF GFBEOFOOLCA()
	{
		return default(NANAKHAEKCF);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class CEHDFDAEMFG<TGroup, TData> : MMJNBPKMDAE<IFNKACAHGFH<TGroup, TData>, NANAKHAEKCF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly GGEGHADCKLB<TGroup, TData> FPBGMDDADHP;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4BAB760", Offset = "0x4BAA760", VA = "0x184BAB760")]
	public CEHDFDAEMFG(TGroup AFGEKLLBHEO, TData NEGOEJOAFPD, IEnumerable<TData> FDDNHPOOAMG, IFNKACAHGFH<TGroup, TData> ACNOIKBCAAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4C8D9F0", Offset = "0x4C8C9F0", VA = "0x184C8D9F0", Slot = "4")]
	public override NANAKHAEKCF GFBEOFOOLCA()
	{
		return default(NANAKHAEKCF);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class CIKALEGKNLD<TGroup, TData> : MMJNBPKMDAE<IFNKACAHGFH<TGroup, TData>, NANAKHAEKCF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly EMGFMEEJNHG<TGroup> FPBGMDDADHP;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x332EF90", Offset = "0x332DF90", VA = "0x18332EF90")]
	public CIKALEGKNLD(TGroup AFGEKLLBHEO, IFNKACAHGFH<TGroup, TData> ACNOIKBCAAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4C96860", Offset = "0x4C95860", VA = "0x184C96860", Slot = "4")]
	public override NANAKHAEKCF GFBEOFOOLCA()
	{
		return default(NANAKHAEKCF);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class CDAKEBMFLIM<TGroup, TData> : MMJNBPKMDAE<IFNKACAHGFH<TGroup, TData>, NANAKHAEKCF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly GGEGHADCKLB<TGroup, TData> FPBGMDDADHP;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x4BAB760", Offset = "0x4BAA760", VA = "0x184BAB760")]
	public CDAKEBMFLIM(TGroup AFGEKLLBHEO, TData DBOEDNAMIFH, IEnumerable<TData> FDDNHPOOAMG, IFNKACAHGFH<TGroup, TData> ACNOIKBCAAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4BAB680", Offset = "0x4BAA680", VA = "0x184BAB680", Slot = "4")]
	public override NANAKHAEKCF GFBEOFOOLCA()
	{
		return default(NANAKHAEKCF);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class ENOOEPCMEIK<TData> : FFNBNPBMMGG<LFHDHDNGCMM<TData>, NANAKHAEKCF> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private struct FPOAIGBAFAF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AsyncTaskMethodBuilder<NANAKHAEKCF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public ENOOEPCMEIK<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private TaskAwaiter<NANAKHAEKCF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x36A0B10", Offset = "0x369FB10", VA = "0x1836A0B10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x36A0DB0", Offset = "0x369FDB0", VA = "0x1836A0DB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private CBMHBMJPJHO<TData> FPBGMDDADHP;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x332EF90", Offset = "0x332DF90", VA = "0x18332EF90")]
	public ENOOEPCMEIK(IEnumerable<TData> EFJDKHIAGGA, LFHDHDNGCMM<TData> ACNOIKBCAAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x332EE90", Offset = "0x332DE90", VA = "0x18332EE90", Slot = "4")]
	[AsyncStateMachine(typeof(ENOOEPCMEIK<>.FPOAIGBAFAF))]
	public override Task<NANAKHAEKCF> GFBEOFOOLCA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct NDODEDCAHMP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly ELEDPLPKIIC GLJALCPPPEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly bool GOLGNDLEPFG;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x61CBF10", Offset = "0x61CAF10", VA = "0x1861CBF10")]
	public NDODEDCAHMP(ELEDPLPKIIC MNDOPDNIPPO, bool CJGFLNDCBLP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface JOANGKDMCOJ<TSpawnType> where TSpawnType : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> GFBEOFOOLCA(NDODEDCAHMP JPMNLHEJNKF);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class NHEDIFBOGIP<TSpawnType> : FFNBNPBMMGG<JOANGKDMCOJ<TSpawnType>, TSpawnType> where TSpawnType : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private struct AKOEICBIPHB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public AsyncTaskMethodBuilder<TSpawnType> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public NHEDIFBOGIP<TSpawnType> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskAwaiter<TSpawnType> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x37ADAC0", Offset = "0x37ACAC0", VA = "0x1837ADAC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x37AE280", Offset = "0x37AD280", VA = "0x1837AE280", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly NDODEDCAHMP JPMNLHEJNKF;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3F485C0", Offset = "0x3F475C0", VA = "0x183F485C0")]
	public NHEDIFBOGIP(ELEDPLPKIIC MNDOPDNIPPO, bool CJGFLNDCBLP, JOANGKDMCOJ<TSpawnType> ACNOIKBCAAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3F483C0", Offset = "0x3F473C0", VA = "0x183F483C0", Slot = "4")]
	[AsyncStateMachine(typeof(NHEDIFBOGIP<>.AKOEICBIPHB))]
	public override Task<TSpawnType> GFBEOFOOLCA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public readonly struct ELEDPLPKIIC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly bool DKBKPAKFFHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly Vector3 KKFGCCACIAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly Vector3 CIKPOOKMMOE;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x61CB570", Offset = "0x61CA570", VA = "0x1861CB570")]
	public ELEDPLPKIIC(Transform JDJEGOOLBEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x61CB540", Offset = "0x61CA540", VA = "0x1861CB540")]
	public ELEDPLPKIIC(Vector3 JEPJKJIDLAI, Vector3 PKDBIHBDKOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x61CB480", Offset = "0x61CA480", VA = "0x1861CB480")]
	public static ELEDPLPKIIC INLJCENBBKM()
	{
		return default(ELEDPLPKIIC);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x61CB4B0", Offset = "0x61CA4B0", VA = "0x1861CB4B0")]
	private ELEDPLPKIIC(bool HFLGJJKJFOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct MLOIPLJOIGK<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public TNode IFILDNLGNKF;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3ED7920", Offset = "0x3ED6920", VA = "0x183ED7920")]
	public MLOIPLJOIGK(TNode IFILDNLGNKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct JOEODJDGIHF<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public TNode BABHPJEIFPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public BJMHHGMJNCC IPOAPNFIBMF;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3B5B710", Offset = "0x3B5A710", VA = "0x183B5B710")]
	public JOEODJDGIHF(TNode BABHPJEIFPF, BJMHHGMJNCC IPOAPNFIBMF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface HJLOHAKPEBG<TNode>
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KEKPGOLGEML([In] MLOIPLJOIGK<TNode> OKBDPBMAJJF);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DCMLAPMCMPB([In] JOEODJDGIHF<TNode> PBHDPOKNMKL);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FLCPIJEMLFA();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class ALJLEOHGBOO<TNode> : MEFIGKAMFEO<HJLOHAKPEBG<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3659660", Offset = "0x3658660", VA = "0x183659660")]
	public ALJLEOHGBOO(HJLOHAKPEBG<TNode> ACNOIKBCAAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3737E90", Offset = "0x3736E90", VA = "0x183737E90", Slot = "4")]
	public override bool GFBEOFOOLCA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class PPDANCAOLPG<TNode> : MEFIGKAMFEO<HJLOHAKPEBG<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly JOEODJDGIHF<TNode> PBHDPOKNMKL;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x4165100", Offset = "0x4164100", VA = "0x184165100")]
	public PPDANCAOLPG(TNode BABHPJEIFPF, BJMHHGMJNCC IPOAPNFIBMF, HJLOHAKPEBG<TNode> ACNOIKBCAAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3673610", Offset = "0x3672610", VA = "0x183673610", Slot = "4")]
	public override bool GFBEOFOOLCA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class LMNJOKBHKPG<TNode> : MEFIGKAMFEO<HJLOHAKPEBG<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly MLOIPLJOIGK<TNode> OKBDPBMAJJF;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3CFA700", Offset = "0x3CF9700", VA = "0x183CFA700")]
	public LMNJOKBHKPG(TNode CBMJMGKFIGK, HJLOHAKPEBG<TNode> ACNOIKBCAAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x367BCB0", Offset = "0x367ACB0", VA = "0x18367BCB0", Slot = "4")]
	public override bool GFBEOFOOLCA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct DDDBEOCFDAI<TSpawnInfo> where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public TSpawnInfo JKDIDMIBGDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public Vector3 PKDBIHBDKOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public Quaternion GOAHENPPMCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public float LIDGFFGHMOF;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x50AD370", Offset = "0x50AC370", VA = "0x1850AD370")]
	public DDDBEOCFDAI(TSpawnInfo JKDIDMIBGDL, Vector3 PKDBIHBDKOO, Quaternion GOAHENPPMCD, float LIDGFFGHMOF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface AILMHLHLHNA<TSpawnType, TSpawnInfo>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> EFNDKMPCNFL([In] DDDBEOCFDAI<TSpawnInfo> MPAKHPDIOLI, CancellationToken JMJKFNJJBHM);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class OICGMHLFDFI<TSpawnType, TSpawnInfo> : FFNBNPBMMGG<AILMHLHLHNA<TSpawnType, TSpawnInfo>, TSpawnType> where TSpawnType : notnull where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly DDDBEOCFDAI<TSpawnInfo> AFBHAGBGAAM;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x4078F40", Offset = "0x4077F40", VA = "0x184078F40")]
	public OICGMHLFDFI(TSpawnInfo BPHHMNDEHND, Vector3 PKDBIHBDKOO, Quaternion GOAHENPPMCD, float LIDGFFGHMOF, AILMHLHLHNA<TSpawnType, TSpawnInfo> ACNOIKBCAAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x4078D60", Offset = "0x4077D60", VA = "0x184078D60", Slot = "4")]
	public override Task<TSpawnType> GFBEOFOOLCA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct LNHCCBKLBMG<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly IEnumerable<TData> DLIALBOAHMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly bool GOLGNDLEPFG;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x3D010D0", Offset = "0x3D000D0", VA = "0x183D010D0")]
	public LNHCCBKLBMG(IEnumerable<TData> FDDNHPOOAMG, bool CJGFLNDCBLP = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface MEMNONHHJHM<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<NANAKHAEKCF> LGKBMHPDEBC([In] LNHCCBKLBMG<TData> FELJIIKOAKN, CancellationToken JMJKFNJJBHM);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class DPNMDCPIDFH<TData> : FFNBNPBMMGG<MEMNONHHJHM<TData>, NANAKHAEKCF> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly LNHCCBKLBMG<TData> JHAPDNPLCJF;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x50F2820", Offset = "0x50F1820", VA = "0x1850F2820")]
	public DPNMDCPIDFH(IEnumerable<TData> FDDNHPOOAMG, bool CJGFLNDCBLP, MEMNONHHJHM<TData> ACNOIKBCAAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x4078D60", Offset = "0x4077D60", VA = "0x184078D60", Slot = "4")]
	public override Task<NANAKHAEKCF> GFBEOFOOLCA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct DLKKFKIBMLM<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly T PGJBCOPPFBK;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x3329770", Offset = "0x3328770", VA = "0x183329770")]
	public DLKKFKIBMLM(T PDACAGBMOPA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface KDDGNGCMLLN<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KEKPGOLGEML([In] DLKKFKIBMLM<T> BEIGFEMHNDD);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DCMLAPMCMPB();
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface NAJANIKAMEE<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GFBEOFOOLCA([In] LLIIMGCKFBL<T> ONGJMLHLIII);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct LLIIMGCKFBL<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public readonly T PGJBCOPPFBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public readonly bool JJONNAIOBNB;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x3CF71C0", Offset = "0x3CF61C0", VA = "0x183CF71C0")]
	public LLIIMGCKFBL(T PDACAGBMOPA, bool IAGPAOINGHK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class DLODCKCKLAK<T> : MEFIGKAMFEO<KDDGNGCMLLN<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x3659660", Offset = "0x3658660", VA = "0x183659660")]
	public DLODCKCKLAK(KDDGNGCMLLN<T> ACNOIKBCAAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x50D1780", Offset = "0x50D0780", VA = "0x1850D1780", Slot = "4")]
	public override bool GFBEOFOOLCA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class CMJHFIIALGE<T> : MEFIGKAMFEO<KDDGNGCMLLN<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly DLKKFKIBMLM<T> BEIGFEMHNDD;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x4D69A70", Offset = "0x4D68A70", VA = "0x184D69A70")]
	public CMJHFIIALGE(T PGJBCOPPFBK, KDDGNGCMLLN<T> ACNOIKBCAAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x367BCB0", Offset = "0x367ACB0", VA = "0x18367BCB0", Slot = "4")]
	public override bool GFBEOFOOLCA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class MJACPIJEKAC<T> : MEFIGKAMFEO<NAJANIKAMEE<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly LLIIMGCKFBL<T> ONGJMLHLIII;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x3ED09C0", Offset = "0x3ECF9C0", VA = "0x183ED09C0")]
	public MJACPIJEKAC(T PGJBCOPPFBK, bool IAGPAOINGHK, NAJANIKAMEE<T> ACNOIKBCAAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x367BCB0", Offset = "0x367ACB0", VA = "0x18367BCB0", Slot = "4")]
	public override bool GFBEOFOOLCA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct DEBBBLBIAEA<TData> where TData : notnull, IJKFGIHGFJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public IEnumerable<TData> DLIALBOAHMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public bool PFCMIFCKLGM;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x50B7810", Offset = "0x50B6810", VA = "0x1850B7810")]
	public DEBBBLBIAEA(IEnumerable<TData> ELMKFDJLEOE, bool MJMBHIGOBGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct LCHEDKEINLI<TData> where TData : notnull, IJKFGIHGFJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public List<TData> DLIALBOAHMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public List<bool> JALPOCMLKKN;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x3CE29E0", Offset = "0x3CE19E0", VA = "0x183CE29E0")]
	public LCHEDKEINLI(List<TData> ELMKFDJLEOE, List<bool> ILDAPCFKKDO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface IJKFGIHGFJJ
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool MPLPBBFHDBC
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
public interface OIKKHCMCLMP<TData> where TData : IJKFGIHGFJJ
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GFBEOFOOLCA([In] DEBBBLBIAEA<TData> ADAKJOLCCHN);

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GFBEOFOOLCA([In] LCHEDKEINLI<TData> ADAKJOLCCHN);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface FMIOKFEINHC<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NLGNKLKCFBD(T PGJBCOPPFBK);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class KPOBBPLBLOB<TData> : MEFIGKAMFEO<OIKKHCMCLMP<TData>> where TData : notnull, IJKFGIHGFJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly DEBBBLBIAEA<TData> ADAKJOLCCHN;

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x3C52500", Offset = "0x3C51500", VA = "0x183C52500")]
	public KPOBBPLBLOB(List<TData> FDDNHPOOAMG, bool PFCMIFCKLGM, OIKKHCMCLMP<TData> ACNOIKBCAAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x367BCB0", Offset = "0x367ACB0", VA = "0x18367BCB0", Slot = "4")]
	public override bool GFBEOFOOLCA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class NDLDIOJBEBA<TData> : MEFIGKAMFEO<OIKKHCMCLMP<TData>> where TData : notnull, IJKFGIHGFJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly LCHEDKEINLI<TData> ADAKJOLCCHN;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x3F43520", Offset = "0x3F42520", VA = "0x183F43520")]
	public NDLDIOJBEBA(List<TData> FDDNHPOOAMG, List<bool> JALPOCMLKKN, OIKKHCMCLMP<TData> ACNOIKBCAAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x3C3CD30", Offset = "0x3C3BD30", VA = "0x183C3CD30", Slot = "4")]
	public override bool GFBEOFOOLCA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface CHBDKJJPKFI<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<NANAKHAEKCF> GFBEOFOOLCA(APILPCCHAFI<TData> HCICIHEPIND);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public class HNGABPFEJJF<TData> : FFNBNPBMMGG<CHBDKJJPKFI<TData>, NANAKHAEKCF> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct NKALBDPIIIB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public AsyncTaskMethodBuilder<NANAKHAEKCF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public HNGABPFEJJF<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<NANAKHAEKCF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x3F892F0", Offset = "0x3F882F0", VA = "0x183F892F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x3F895E0", Offset = "0x3F885E0", VA = "0x183F895E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly APILPCCHAFI<TData> COIODOCMLFB;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x37EF000", Offset = "0x37EE000", VA = "0x1837EF000")]
	public HNGABPFEJJF(TData ONOJICNCNLC, IReadOnlyList<TData> PMBPPOLDAMM, bool CJGFLNDCBLP, CHBDKJJPKFI<TData> ACNOIKBCAAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x37EEF00", Offset = "0x37EDF00", VA = "0x1837EEF00", Slot = "4")]
	[AsyncStateMachine(typeof(HNGABPFEJJF<>.NKALBDPIIIB))]
	public override Task<NANAKHAEKCF> GFBEOFOOLCA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public struct APILPCCHAFI<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public TData DPDFLIPLBHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public IReadOnlyList<TData> LGGFLOIHOHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public bool GOLGNDLEPFG;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x38E64B0", Offset = "0x38E54B0", VA = "0x1838E64B0")]
	public APILPCCHAFI(TData ONOJICNCNLC, IReadOnlyList<TData> PMBPPOLDAMM, bool CJGFLNDCBLP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface LAHBPJKJEPN<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GFBEOFOOLCA([In] DPDCFHEIILO<TData> MMBJDPJNJGO);
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface GHGMNKCPHGM<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GFBEOFOOLCA([In] GODLOMFOJIC<TData> MMBJDPJNJGO);
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface PGIPHOCOPML<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DHOLNDIEEFG([In] PGEGGIEEBAB<TData> MMBJDPJNJGO);

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DCMLAPMCMPB();
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class DCLIKAAOGHD<TData> : MEFIGKAMFEO<LAHBPJKJEPN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly DPDCFHEIILO<TData> MMBJDPJNJGO;

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x50AC060", Offset = "0x50AB060", VA = "0x1850AC060")]
	public DCLIKAAOGHD(IEnumerable<TData> FDDNHPOOAMG, JGMDHPBNOFM DDCPEHLFHPM, KPJPNECGJII BKIIKPMMAIB, float DNFBEOILIMJ, bool CJGFLNDCBLP, LAHBPJKJEPN<TData> ACNOIKBCAAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x367BCB0", Offset = "0x367ACB0", VA = "0x18367BCB0", Slot = "4")]
	public override bool GFBEOFOOLCA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class GDLMMDIBEGL<TData> : MEFIGKAMFEO<GHGMNKCPHGM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly GODLOMFOJIC<TData> MMBJDPJNJGO;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x3740D90", Offset = "0x373FD90", VA = "0x183740D90")]
	public GDLMMDIBEGL(TData[] FDDNHPOOAMG, JGMDHPBNOFM[] DDCPEHLFHPM, KPJPNECGJII[] BKIIKPMMAIB, float[] DNFBEOILIMJ, GHGMNKCPHGM<TData> ACNOIKBCAAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3740C00", Offset = "0x373FC00", VA = "0x183740C00", Slot = "4")]
	public override bool GFBEOFOOLCA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class FNGNMDLLKDO<TData> : MEFIGKAMFEO<PGIPHOCOPML<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3659660", Offset = "0x3658660", VA = "0x183659660")]
	public FNGNMDLLKDO(PGIPHOCOPML<TData> ACNOIKBCAAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x3697AD0", Offset = "0x3696AD0", VA = "0x183697AD0", Slot = "4")]
	public override bool GFBEOFOOLCA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class BGEJGJADAID<TData> : MEFIGKAMFEO<PGIPHOCOPML<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly PGEGGIEEBAB<TData> MMBJDPJNJGO;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x47ACC30", Offset = "0x47ABC30", VA = "0x1847ACC30")]
	public BGEJGJADAID(IEnumerable<TData> FDDNHPOOAMG, JGMDHPBNOFM DDCPEHLFHPM, KPJPNECGJII BKIIKPMMAIB, float DNFBEOILIMJ, PGIPHOCOPML<TData> ACNOIKBCAAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3740C00", Offset = "0x373FC00", VA = "0x183740C00", Slot = "4")]
	public override bool GFBEOFOOLCA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public struct DPDCFHEIILO<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public IEnumerable<TData> DLIALBOAHMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public JGMDHPBNOFM LFFGDKFENIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public KPJPNECGJII LEOHDFJHIJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public float DNFBEOILIMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public bool CJGFLNDCBLP;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x50F1C00", Offset = "0x50F0C00", VA = "0x1850F1C00")]
	public DPDCFHEIILO(IEnumerable<TData> FDDNHPOOAMG, JGMDHPBNOFM DDCPEHLFHPM, KPJPNECGJII BKIIKPMMAIB, float DNFBEOILIMJ, bool CJGFLNDCBLP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct GODLOMFOJIC<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public TData[] DLIALBOAHMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public JGMDHPBNOFM[] LFFGDKFENIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public KPJPNECGJII[] LEOHDFJHIJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public float[] DNFBEOILIMJ;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3769C60", Offset = "0x3768C60", VA = "0x183769C60")]
	public GODLOMFOJIC(TData[] FDDNHPOOAMG, JGMDHPBNOFM[] DDCPEHLFHPM, KPJPNECGJII[] BKIIKPMMAIB, float[] DNFBEOILIMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public struct PGEGGIEEBAB<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public IEnumerable<TData> DLIALBOAHMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public JGMDHPBNOFM LFFGDKFENIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public KPJPNECGJII LEOHDFJHIJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public float DNFBEOILIMJ;

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x4148190", Offset = "0x4147190", VA = "0x184148190")]
	public PGEGGIEEBAB(IEnumerable<TData> FDDNHPOOAMG, JGMDHPBNOFM DDCPEHLFHPM, KPJPNECGJII BKIIKPMMAIB, float DNFBEOILIMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public interface MBECHCLDEDC<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JELCEKIBAPB([In] NPJEKFOOBNC<TData> FELJIIKOAKN);

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EGBOAFJECJJ([In] NPJEKFOOBNC<TData> FELJIIKOAKN);

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GGAODAEEAAD([In] bool MNHEJLFHBAD);

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool GCFKPKDHNPO([In] NPJEKFOOBNC<TData> FELJIIKOAKN);

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KBNOOGGEINJ();

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool BBDLELBNLMB([In] TData EFIOLIKBHLM);
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class LFBNKGELHLF<TData> : MEFIGKAMFEO<MBECHCLDEDC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly NPJEKFOOBNC<TData> FELJIIKOAKN;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x3CE6920", Offset = "0x3CE5920", VA = "0x183CE6920")]
	public LFBNKGELHLF(List<TData> OAAIPIKOOLB, MBECHCLDEDC<TData> ACNOIKBCAAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x367BCB0", Offset = "0x367ACB0", VA = "0x18367BCB0", Slot = "4")]
	public override bool GFBEOFOOLCA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class CIEADEOGKCF<TData> : MEFIGKAMFEO<MBECHCLDEDC<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3659660", Offset = "0x3658660", VA = "0x183659660")]
	public CIEADEOGKCF(MBECHCLDEDC<TData> ACNOIKBCAAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x4C96810", Offset = "0x4C95810", VA = "0x184C96810", Slot = "4")]
	public override bool GFBEOFOOLCA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class NGGHBNNAAPL<TData> : MEFIGKAMFEO<MBECHCLDEDC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly bool CJGFLNDCBLP;

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3F475C0", Offset = "0x3F465C0", VA = "0x183F475C0")]
	public NGGHBNNAAPL(bool CJGFLNDCBLP, MBECHCLDEDC<TData> ACNOIKBCAAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3F47560", Offset = "0x3F46560", VA = "0x183F47560", Slot = "4")]
	public override bool GFBEOFOOLCA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class KMBFNNADNPP<TData> : MEFIGKAMFEO<MBECHCLDEDC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly NPJEKFOOBNC<TData> FELJIIKOAKN;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3C3CDF0", Offset = "0x3C3BDF0", VA = "0x183C3CDF0")]
	public KMBFNNADNPP(List<TData> OAAIPIKOOLB, bool CJGFLNDCBLP, MBECHCLDEDC<TData> ACNOIKBCAAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3C3CD30", Offset = "0x3C3BD30", VA = "0x183C3CD30", Slot = "4")]
	public override bool GFBEOFOOLCA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class MMJNMOJPCFE<TData> : MEFIGKAMFEO<MBECHCLDEDC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly TData EFIOLIKBHLM;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3ED7AC0", Offset = "0x3ED6AC0", VA = "0x183ED7AC0")]
	public MMJNMOJPCFE(TData EFIOLIKBHLM, MBECHCLDEDC<TData> ACNOIKBCAAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3ED7990", Offset = "0x3ED6990", VA = "0x183ED7990", Slot = "4")]
	public override bool GFBEOFOOLCA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class JDLMJEPFLAI<TData> : MEFIGKAMFEO<MBECHCLDEDC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly NPJEKFOOBNC<TData> FELJIIKOAKN;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3B36380", Offset = "0x3B35380", VA = "0x183B36380")]
	public JDLMJEPFLAI(IEnumerable<TData> OAAIPIKOOLB, MBECHCLDEDC<TData> ACNOIKBCAAG, bool CJGFLNDCBLP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x3B36210", Offset = "0x3B35210", VA = "0x183B36210", Slot = "4")]
	public override bool GFBEOFOOLCA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public struct NPJEKFOOBNC<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public IEnumerable<TData> DLIALBOAHMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public bool CJGFLNDCBLP;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x3FA7370", Offset = "0x3FA6370", VA = "0x183FA7370")]
	public NPJEKFOOBNC(IEnumerable<TData> ELMKFDJLEOE, bool IHGGLHDBMGA = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public interface LHCKNFGKHOD
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<NANAKHAEKCF> GFBEOFOOLCA(DGKJBIEACPD HLAPFOGDFFJ);
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class FKEKNMBLFBF : FFNBNPBMMGG<LHCKNFGKHOD, NANAKHAEKCF>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private struct PDOJDFIOLEM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public AsyncTaskMethodBuilder<NANAKHAEKCF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public FKEKNMBLFBF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private TaskAwaiter<NANAKHAEKCF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x61CC090", Offset = "0x61CB090", VA = "0x1861CC090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x61CC310", Offset = "0x61CB310", VA = "0x1861CC310", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly DGKJBIEACPD ALFBCLOACNC;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x61CB6D0", Offset = "0x61CA6D0", VA = "0x1861CB6D0")]
	public FKEKNMBLFBF(bool CJGFLNDCBLP, LHCKNFGKHOD ACNOIKBCAAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x61CB5E0", Offset = "0x61CA5E0", VA = "0x1861CB5E0", Slot = "4")]
	[AsyncStateMachine(typeof(PDOJDFIOLEM))]
	public override Task<NANAKHAEKCF> GFBEOFOOLCA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct DGKJBIEACPD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public bool GOLGNDLEPFG;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0xCB5E60", Offset = "0xCB4E60", VA = "0x180CB5E60")]
	public DGKJBIEACPD(bool CJGFLNDCBLP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public readonly struct HGJJJEBJKHB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly bool JDJIDMIAIGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly bool DICEDNFHACJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly bool LIDGFFGHMOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public readonly bool CJGFLNDCBLP;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x461F5A0", Offset = "0x461E5A0", VA = "0x18461F5A0")]
	public HGJJJEBJKHB(bool JDJIDMIAIGA, bool DICEDNFHACJ, bool LIDGFFGHMOF, bool CJGFLNDCBLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x61CB790", Offset = "0x61CA790", VA = "0x1861CB790")]
	public HGJJJEBJKHB(bool DICEDNFHACJ, bool CJGFLNDCBLP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface HDLPNBCOAEJ
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EFHFBEINABC(HGJJJEBJKHB OKNDDLJHJCJ);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OJPHONLFFJL(HGJJJEBJKHB OKNDDLJHJCJ);
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class NIGLEGMJDEL : MEFIGKAMFEO<HDLPNBCOAEJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly HGJJJEBJKHB OKNDDLJHJCJ;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x61CBF80", Offset = "0x61CAF80", VA = "0x1861CBF80")]
	public NIGLEGMJDEL(bool NJKBLELAEGN, bool DICEDNFHACJ, bool LIDGFFGHMOF, bool CJGFLNDCBLP, HDLPNBCOAEJ ACNOIKBCAAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x61CBF30", Offset = "0x61CAF30", VA = "0x1861CBF30", Slot = "4")]
	public override bool GFBEOFOOLCA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class HHAGEELIHLO : MEFIGKAMFEO<HDLPNBCOAEJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly HGJJJEBJKHB OKNDDLJHJCJ;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x61CB7F0", Offset = "0x61CA7F0", VA = "0x1861CB7F0")]
	public HHAGEELIHLO(bool DICEDNFHACJ, bool CJGFLNDCBLP, HDLPNBCOAEJ ACNOIKBCAAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x61CB7A0", Offset = "0x61CA7A0", VA = "0x1861CB7A0", Slot = "4")]
	public override bool GFBEOFOOLCA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public interface GDMDIJJIAAB
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GFBEOFOOLCA([In] BNLMMBBFLBH OBKAPOBPDJJ);
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class JAGIINGBJDN : MEFIGKAMFEO<GDMDIJJIAAB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly BNLMMBBFLBH OBKAPOBPDJJ;

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x61CB960", Offset = "0x61CA960", VA = "0x1861CB960")]
	public JAGIINGBJDN(Guid[] LCPNHDBJDPG, Vector3[] PJCIMGMNFBB, Quaternion[] NLBOEGPMMBL, float[] NHHGDNAIFKH, Dictionary<Guid, Vector3> POEOLPCAFBF, GDMDIJJIAAB ACNOIKBCAAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x61CB8B0", Offset = "0x61CA8B0", VA = "0x1861CB8B0", Slot = "4")]
	public override bool GFBEOFOOLCA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public interface DKKOPBMLGDE<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KEKPGOLGEML([In] LJODAGNGEOI<TData> OKBDPBMAJJF);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DHOLNDIEEFG([In] GLPEPLBGLDO EEFHAOKMAPF);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DHOLNDIEEFG([In] GIEDEDILNPD EEFHAOKMAPF);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DCMLAPMCMPB();
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class DNGKPJJEHBL<TData> : MEFIGKAMFEO<DKKOPBMLGDE<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x3659660", Offset = "0x3658660", VA = "0x183659660")]
	public DNGKPJJEHBL(DKKOPBMLGDE<TData> ACNOIKBCAAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x50DE750", Offset = "0x50DD750", VA = "0x1850DE750", Slot = "4")]
	public override bool GFBEOFOOLCA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class GHFCLINBAOA<TData> : MEFIGKAMFEO<DKKOPBMLGDE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly GLPEPLBGLDO NHPEKJIJBOA;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x374B6B0", Offset = "0x374A6B0", VA = "0x18374B6B0")]
	public GHFCLINBAOA(Vector3 HNOLGCBDOOC, bool JLFCIIGDMBK, DKKOPBMLGDE<TData> ACNOIKBCAAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x374B650", Offset = "0x374A650", VA = "0x18374B650", Slot = "4")]
	public override bool GFBEOFOOLCA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class ABLOLCDOKJC<TData> : MEFIGKAMFEO<DKKOPBMLGDE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly GIEDEDILNPD NHPEKJIJBOA;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x3719180", Offset = "0x3718180", VA = "0x183719180")]
	public ABLOLCDOKJC(Guid LBILLNFGMCC, int GCDIELAOHNA, Vector3 PKDBIHBDKOO, Quaternion GOAHENPPMCD, float ELLOHCJLFKF, bool JLFCIIGDMBK, DKKOPBMLGDE<TData> ACNOIKBCAAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x3719120", Offset = "0x3718120", VA = "0x183719120", Slot = "4")]
	public override bool GFBEOFOOLCA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class HJJIGFKNJLF<TData> : MEFIGKAMFEO<DKKOPBMLGDE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly LJODAGNGEOI<TData> NHPEKJIJBOA;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x37D9BC0", Offset = "0x37D8BC0", VA = "0x1837D9BC0")]
	public HJJIGFKNJLF(TData PGJBCOPPFBK, bool CJGFLNDCBLP, DKKOPBMLGDE<TData> ACNOIKBCAAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x367BCB0", Offset = "0x367ACB0", VA = "0x18367BCB0", Slot = "4")]
	public override bool GFBEOFOOLCA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public struct GLPEPLBGLDO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public readonly Vector3 HNOLGCBDOOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly bool JLFCIIGDMBK;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x61CB770", Offset = "0x61CA770", VA = "0x1861CB770")]
	public GLPEPLBGLDO(Vector3 HNOLGCBDOOC, bool JLFCIIGDMBK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public struct GIEDEDILNPD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public readonly Guid LBILLNFGMCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public readonly int GCDIELAOHNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public readonly Vector3 PKDBIHBDKOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public readonly Quaternion GOAHENPPMCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public readonly float ELLOHCJLFKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public readonly bool JLFCIIGDMBK;

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x61CB730", Offset = "0x61CA730", VA = "0x1861CB730")]
	public GIEDEDILNPD(Guid LBILLNFGMCC, int GCDIELAOHNA, Vector3 PKDBIHBDKOO, Quaternion GOAHENPPMCD, float ELLOHCJLFKF, bool JLFCIIGDMBK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public struct LJODAGNGEOI<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public readonly TData PGJBCOPPFBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public readonly bool CJGFLNDCBLP;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x3CF1C70", Offset = "0x3CF0C70", VA = "0x183CF1C70")]
	public LJODAGNGEOI(TData PGJBCOPPFBK, bool CJGFLNDCBLP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public interface GOOGJMHKLCP<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GFBEOFOOLCA([In] KHFJAIHBMJF<TData> EJEBLKLDHMM);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GFBEOFOOLCA([In] LGMKFOENOGN<TData> EJEBLKLDHMM);
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public interface EECGJKHHEPD<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KEKPGOLGEML([In] LFKKDDDFOJH<TData> HLHNJHDKDHD);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DHOLNDIEEFG([In] ECELKKMJHAK EEFHAOKMAPF);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DCMLAPMCMPB();
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class ONMONLJPBDI<TData> : MEFIGKAMFEO<GOOGJMHKLCP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly KHFJAIHBMJF<TData> EJEBLKLDHMM;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x4088DB0", Offset = "0x4087DB0", VA = "0x184088DB0")]
	public ONMONLJPBDI(IEnumerable<TData> FDDNHPOOAMG, Vector3 ACPJJAHGAHK, bool CJGFLNDCBLP, GOOGJMHKLCP<TData> ACNOIKBCAAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x367BCB0", Offset = "0x367ACB0", VA = "0x18367BCB0", Slot = "4")]
	public override bool GFBEOFOOLCA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class GBODEMODPDJ<TData> : MEFIGKAMFEO<EECGJKHHEPD<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x3659660", Offset = "0x3658660", VA = "0x183659660")]
	public GBODEMODPDJ(EECGJKHHEPD<TData> ACNOIKBCAAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x3737E90", Offset = "0x3736E90", VA = "0x183737E90", Slot = "4")]
	public override bool GFBEOFOOLCA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class ODJBDOAHFEM<TData> : MEFIGKAMFEO<EECGJKHHEPD<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly LFKKDDDFOJH<TData> EJEBLKLDHMM;

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x4070650", Offset = "0x406F650", VA = "0x184070650")]
	public ODJBDOAHFEM(IEnumerable<TData> FDDNHPOOAMG, bool CJGFLNDCBLP, EECGJKHHEPD<TData> ACNOIKBCAAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x367BCB0", Offset = "0x367ACB0", VA = "0x18367BCB0", Slot = "4")]
	public override bool GFBEOFOOLCA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class FGNDDMDKJKB<TData> : MEFIGKAMFEO<GOOGJMHKLCP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly LGMKFOENOGN<TData> EJEBLKLDHMM;

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x36736E0", Offset = "0x36726E0", VA = "0x1836736E0")]
	public FGNDDMDKJKB(IEnumerable<TData> FDDNHPOOAMG, Vector3 FPALOBNOLKM, PFLPDOOCCKH IICNDOGHAGH, bool CJGFLNDCBLP, GOOGJMHKLCP<TData> ACNOIKBCAAG, Space HPLOPFNOBLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3673610", Offset = "0x3672610", VA = "0x183673610", Slot = "4")]
	public override bool GFBEOFOOLCA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class IGLPLPOJCOG<TData> : MEFIGKAMFEO<EECGJKHHEPD<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly ECELKKMJHAK EJEBLKLDHMM;

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x3931F00", Offset = "0x3930F00", VA = "0x183931F00")]
	public IGLPLPOJCOG(Vector3 ACPJJAHGAHK, EECGJKHHEPD<TData> ACNOIKBCAAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x374B650", Offset = "0x374A650", VA = "0x18374B650", Slot = "4")]
	public override bool GFBEOFOOLCA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct KHFJAIHBMJF<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public readonly IEnumerable<TData> FDDNHPOOAMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public readonly Vector3 ACPJJAHGAHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public readonly bool CJGFLNDCBLP;

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x3C1EB60", Offset = "0x3C1DB60", VA = "0x183C1EB60")]
	public KHFJAIHBMJF(IEnumerable<TData> FDDNHPOOAMG, Vector3 ACPJJAHGAHK, bool CJGFLNDCBLP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct LFKKDDDFOJH<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public readonly IEnumerable<TData> FDDNHPOOAMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public readonly bool CJGFLNDCBLP;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x3CE76F0", Offset = "0x3CE66F0", VA = "0x183CE76F0")]
	public LFKKDDDFOJH(IEnumerable<TData> FDDNHPOOAMG, bool CJGFLNDCBLP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct LGMKFOENOGN<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public readonly IEnumerable<TData> FDDNHPOOAMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public readonly Vector3 FPALOBNOLKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public readonly PFLPDOOCCKH IICNDOGHAGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly bool CJGFLNDCBLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public readonly Space HPLOPFNOBLM;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x3CEA9D0", Offset = "0x3CE99D0", VA = "0x183CEA9D0")]
	public LGMKFOENOGN(IEnumerable<TData> FDDNHPOOAMG, Vector3 FPALOBNOLKM, PFLPDOOCCKH IICNDOGHAGH, bool CJGFLNDCBLP, Space HPLOPFNOBLM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct ECELKKMJHAK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly Vector3 ACPJJAHGAHK;

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x1F54280", Offset = "0x1F53280", VA = "0x181F54280")]
	public ECELKKMJHAK(Vector3 ACPJJAHGAHK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public enum PFLPDOOCCKH
{
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	XYZ,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	X_only,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	Y_only,
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	Z_only
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public interface MMPLOONPKEM
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GFBEOFOOLCA([In] LODCFGJAGCJ AMOOOKMIBHB);
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public class EBBPLAJNPKH : MEFIGKAMFEO<MMPLOONPKEM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly LODCFGJAGCJ AMOOOKMIBHB;

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x61CB1F0", Offset = "0x61CA1F0", VA = "0x1861CB1F0")]
	public EBBPLAJNPKH(bool CJGFLNDCBLP, MMPLOONPKEM ACNOIKBCAAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x61CB140", Offset = "0x61CA140", VA = "0x1861CB140", Slot = "4")]
	public override bool GFBEOFOOLCA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public readonly struct LODCFGJAGCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public readonly bool CJGFLNDCBLP;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0xCB5E60", Offset = "0xCB4E60", VA = "0x180CB5E60")]
	public LODCFGJAGCJ(bool CJGFLNDCBLP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public interface KEPAKEAJAPA<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GFBEOFOOLCA([In] OLJNPCJMJGK<TData> GKCGCOALCKF);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GFBEOFOOLCA([In] AKOFCDGEBBL<TData> GKCGCOALCKF);
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public interface FCBBPCLPIHC<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KEKPGOLGEML([In] IGECKCMGALJ<TData> OKBDPBMAJJF);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DHOLNDIEEFG([In] GJNCICNLPDP EEFHAOKMAPF);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DCMLAPMCMPB();
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class KLKNMCOBNLG<TData> : MEFIGKAMFEO<KEPAKEAJAPA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly OLJNPCJMJGK<TData> GKCGCOALCKF;

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x3C3CB10", Offset = "0x3C3BB10", VA = "0x183C3CB10")]
	public KLKNMCOBNLG(IEnumerable<TData> FDDNHPOOAMG, Quaternion ACPJJAHGAHK, Vector3? ONGIHMFDBEP, bool LHLAINLBFNN, bool CJGFLNDCBLP, KEPAKEAJAPA<TData> ACNOIKBCAAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x367BCB0", Offset = "0x367ACB0", VA = "0x18367BCB0", Slot = "4")]
	public override bool GFBEOFOOLCA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class APJDEKLOFCD<TData> : MEFIGKAMFEO<FCBBPCLPIHC<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x3659660", Offset = "0x3658660", VA = "0x183659660")]
	public APJDEKLOFCD(FCBBPCLPIHC<TData> ACNOIKBCAAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x3737E90", Offset = "0x3736E90", VA = "0x183737E90", Slot = "4")]
	public override bool GFBEOFOOLCA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class BFLEOMHMKBN<TData> : MEFIGKAMFEO<FCBBPCLPIHC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly IGECKCMGALJ<TData> GKCGCOALCKF;

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x47AC3A0", Offset = "0x47AB3A0", VA = "0x1847AC3A0")]
	public BFLEOMHMKBN(IEnumerable<TData> FDDNHPOOAMG, bool CJGFLNDCBLP, FCBBPCLPIHC<TData> ACNOIKBCAAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x367BCB0", Offset = "0x367ACB0", VA = "0x18367BCB0", Slot = "4")]
	public override bool GFBEOFOOLCA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class GIGHGDLLOAG<TData> : MEFIGKAMFEO<KEPAKEAJAPA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly AKOFCDGEBBL<TData> GKCGCOALCKF;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x3758B30", Offset = "0x3757B30", VA = "0x183758B30")]
	public GIGHGDLLOAG(IEnumerable<TData> FDDNHPOOAMG, Quaternion BJGCHNMAADN, PFLPDOOCCKH MPFEFBBNCGF, Vector3? ONGIHMFDBEP, bool LHLAINLBFNN, bool CJGFLNDCBLP, Space HPLOPFNOBLM, KEPAKEAJAPA<TData> ACNOIKBCAAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x3673610", Offset = "0x3672610", VA = "0x183673610", Slot = "4")]
	public override bool GFBEOFOOLCA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class PBHFDFHCJJF<TData> : MEFIGKAMFEO<FCBBPCLPIHC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly GJNCICNLPDP GKCGCOALCKF;

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x412C0A0", Offset = "0x412B0A0", VA = "0x18412C0A0")]
	public PBHFDFHCJJF(Quaternion ACPJJAHGAHK, Vector3? ONGIHMFDBEP, bool LHLAINLBFNN, FCBBPCLPIHC<TData> ACNOIKBCAAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x374B650", Offset = "0x374A650", VA = "0x18374B650", Slot = "4")]
	public override bool GFBEOFOOLCA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public struct OLJNPCJMJGK<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public readonly IEnumerable<TData> FDDNHPOOAMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public readonly Quaternion ACPJJAHGAHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public readonly Vector3? ONGIHMFDBEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public readonly bool LHLAINLBFNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public readonly bool CJGFLNDCBLP;

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x407C660", Offset = "0x407B660", VA = "0x18407C660")]
	public OLJNPCJMJGK(IEnumerable<TData> FDDNHPOOAMG, Quaternion ACPJJAHGAHK, Vector3? ONGIHMFDBEP, bool LHLAINLBFNN, bool CJGFLNDCBLP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public struct IGECKCMGALJ<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public readonly IEnumerable<TData> FDDNHPOOAMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public readonly bool CJGFLNDCBLP;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x392FBC0", Offset = "0x392EBC0", VA = "0x18392FBC0")]
	public IGECKCMGALJ(IEnumerable<TData> FDDNHPOOAMG, bool CJGFLNDCBLP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public struct AKOFCDGEBBL<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly IEnumerable<TData> FDDNHPOOAMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public readonly Quaternion BJGCHNMAADN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public readonly PFLPDOOCCKH MPFEFBBNCGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public readonly Vector3? ONGIHMFDBEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public readonly bool LHLAINLBFNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public readonly bool CJGFLNDCBLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public readonly Space HPLOPFNOBLM;

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x37AE320", Offset = "0x37AD320", VA = "0x1837AE320")]
	public AKOFCDGEBBL(IEnumerable<TData> FDDNHPOOAMG, Quaternion BJGCHNMAADN, PFLPDOOCCKH MPFEFBBNCGF, Vector3? ONGIHMFDBEP, bool LHLAINLBFNN, bool CJGFLNDCBLP, Space HPLOPFNOBLM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public struct GJNCICNLPDP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public readonly Quaternion ACPJJAHGAHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public readonly Vector3? ONGIHMFDBEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public readonly bool LHLAINLBFNN;

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x45DC350", Offset = "0x45DB350", VA = "0x1845DC350")]
	public GJNCICNLPDP(Quaternion ACPJJAHGAHK, Vector3? ONGIHMFDBEP, bool LHLAINLBFNN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public interface HNNDCJNDHLI<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KEKPGOLGEML([In] EOBDOJKLNIG<TData> OKBDPBMAJJF);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DHOLNDIEEFG([In] BNLBEOCGMMG EEFHAOKMAPF);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DHOLNDIEEFG([In] DDKEADFOGGO EEFHAOKMAPF);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DHOLNDIEEFG([In] IDNNPPAOPDL EEFHAOKMAPF);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool DCMLAPMCMPB();
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public class OIOFCHPOCOB<TData> : MEFIGKAMFEO<HNNDCJNDHLI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly IDNNPPAOPDL FBLLHLAOFMK;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x407A120", Offset = "0x4079120", VA = "0x18407A120")]
	public OIOFCHPOCOB(Vector3 GJFIKANGJIK, float PDPMLJHIDGN, Vector3 ONGIHMFDBEP, bool JGLKDMEADFL, bool PBFNCOJGBEF, HNNDCJNDHLI<TData> ACNOIKBCAAG, Space HPLOPFNOBLM = Space.Self)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x407A0C0", Offset = "0x40790C0", VA = "0x18407A0C0", Slot = "4")]
	public override bool GFBEOFOOLCA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public class BJMKGNJIIHD<TData> : MEFIGKAMFEO<HNNDCJNDHLI<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x3659660", Offset = "0x3658660", VA = "0x183659660")]
	public BJMKGNJIIHD(HNNDCJNDHLI<TData> ACNOIKBCAAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x47BA0F0", Offset = "0x47B90F0", VA = "0x1847BA0F0", Slot = "4")]
	public override bool GFBEOFOOLCA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class FJDHNFFLCFI<TData> : MEFIGKAMFEO<HNNDCJNDHLI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly EOBDOJKLNIG<TData> FBLLHLAOFMK;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x367BD70", Offset = "0x367AD70", VA = "0x18367BD70")]
	public FJDHNFFLCFI(IEnumerable<TData> FDDNHPOOAMG, bool CJGFLNDCBLP, HNNDCJNDHLI<TData> ACNOIKBCAAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x367BCB0", Offset = "0x367ACB0", VA = "0x18367BCB0", Slot = "4")]
	public override bool GFBEOFOOLCA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class KDMCNMPKLDI<TData> : MEFIGKAMFEO<HNNDCJNDHLI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly DDKEADFOGGO FBLLHLAOFMK;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x3BF2DE0", Offset = "0x3BF1DE0", VA = "0x183BF2DE0")]
	public KDMCNMPKLDI(float APANNIFEPLN, bool HHFCKJEPCHF, Vector3 ONGIHMFDBEP, HNNDCJNDHLI<TData> ACNOIKBCAAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x3BF2D10", Offset = "0x3BF1D10", VA = "0x183BF2D10", Slot = "4")]
	public override bool GFBEOFOOLCA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class POFCHJBBBOM<TData> : MEFIGKAMFEO<HNNDCJNDHLI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly BNLBEOCGMMG FBLLHLAOFMK;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x4163A20", Offset = "0x4162A20", VA = "0x184163A20")]
	public POFCHJBBBOM(float PDPMLJHIDGN, Vector3 ONGIHMFDBEP, HNNDCJNDHLI<TData> ACNOIKBCAAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x374B650", Offset = "0x374A650", VA = "0x18374B650", Slot = "4")]
	public override bool GFBEOFOOLCA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public struct IDNNPPAOPDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public readonly Vector3 GJFIKANGJIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public readonly float PDPMLJHIDGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public readonly Vector3 ONGIHMFDBEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public readonly bool JLFCIIGDMBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public readonly Space HPLOPFNOBLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public readonly bool PBFNCOJGBEF;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x61CB870", Offset = "0x61CA870", VA = "0x1861CB870")]
	public IDNNPPAOPDL(Vector3 GJFIKANGJIK, float PDPMLJHIDGN, Vector3 ONGIHMFDBEP, bool JLFCIIGDMBK, bool FHABNAOEONA, Space HPLOPFNOBLM = Space.Self)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public struct EOBDOJKLNIG<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public readonly IEnumerable<TData> FDDNHPOOAMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public readonly bool CJGFLNDCBLP;

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x332F320", Offset = "0x332E320", VA = "0x18332F320")]
	public EOBDOJKLNIG(IEnumerable<TData> FDDNHPOOAMG, bool CJGFLNDCBLP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct DDKEADFOGGO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public readonly float APANNIFEPLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public readonly bool HHFCKJEPCHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public readonly Vector3 ONGIHMFDBEP;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x61CB120", Offset = "0x61CA120", VA = "0x1861CB120")]
	public DDKEADFOGGO(float APANNIFEPLN, bool HHFCKJEPCHF, Vector3 ONGIHMFDBEP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public struct BNLBEOCGMMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public readonly float PDPMLJHIDGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public readonly Vector3 ONGIHMFDBEP;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x45B6290", Offset = "0x45B5290", VA = "0x1845B6290")]
	public BNLBEOCGMMG(float PDPMLJHIDGN, Vector3 ONGIHMFDBEP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct BNLMMBBFLBH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public readonly Guid[] FDDNHPOOAMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public readonly bool CJBJPMPDCDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public readonly bool MKIGDHFPDPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public readonly bool CKFGDGCGMPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public readonly Vector3[] PJCIMGMNFBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public readonly Quaternion[] NLBOEGPMMBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public readonly float[] NHHGDNAIFKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly Dictionary<Guid, Vector3> POEOLPCAFBF;

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x61CAE90", Offset = "0x61C9E90", VA = "0x1861CAE90")]
	public BNLMMBBFLBH(Guid[] LCPNHDBJDPG, Vector3[] PJCIMGMNFBB, Quaternion[] NLBOEGPMMBL, float[] NHHGDNAIFKH, Dictionary<Guid, Vector3> POEOLPCAFBF, bool CJBJPMPDCDP = true, bool MKIGDHFPDPP = true, bool CKFGDGCGMPP = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x61CACC0", Offset = "0x61C9CC0", VA = "0x1861CACC0")]
	private static void DABBOLCKLLL(Dictionary<Guid, Vector3> POEOLPCAFBF, int NDKNMLPDNPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public static class KKANIPEBFFK
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	private struct MIHMFGOANFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public bool DHGHEPDABDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public ONGJLMJLNJA FFFKFLNEBJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public ONGJLMJLNJA DENEECDIEOE;
	}

	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private static MIHMFGOANFM CDMKFHFONNN;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static CancellationToken NGDGLKKPIHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x61CBEF0", Offset = "0x61CAEF0", VA = "0x1861CBEF0")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	internal static ONGJLMJLNJA FFFKFLNEBJG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x61CBD90", Offset = "0x61CAD90", VA = "0x1861CBD90")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x61CBE30", Offset = "0x61CAE30", VA = "0x1861CBE30")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x61CBC90", Offset = "0x61CAC90", VA = "0x1861CBC90")]
	[KEBGMDILACL(LNECJMDANHH.Room, JMIJNHPDBML.None)]
	private static void GEBKLPBPLPI(ONGJLMJLNJA EOHBAFOAHHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x61CBB40", Offset = "0x61CAB40", VA = "0x1861CBB40")]
	public static void FPNJJPKFGNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x61CBEA0", Offset = "0x61CAEA0", VA = "0x1861CBEA0")]
	private static ONGJLMJLNJA MKONLNCADMF(ONGJLMJLNJA JGFBGCNJAEI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public static class DMNCHIKIALH
{
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public enum ENNJBCLFMNB
	{
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		ICreationContextObject,
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		Guid
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x2643B60", Offset = "0x2642B60", VA = "0x182643B60")]
	public static void ILEJMPJHAAP<T>(T LMOHAHGFEGM, ENNJBCLFMNB IKHOLAJCJOG) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x2643CA0", Offset = "0x2642CA0", VA = "0x182643CA0")]
	public static void ILEJMPJHAAP<T>(T LMOHAHGFEGM) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x2643AF0", Offset = "0x2642AF0", VA = "0x182643AF0")]
	public static void EDOPHLDMLJD<T>(T LMOHAHGFEGM) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x2643FB0", Offset = "0x2642FB0", VA = "0x182643FB0")]
	public static T LNKEGHLMDOM<T>(ENNJBCLFMNB IKHOLAJCJOG) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x2643D00", Offset = "0x2642D00", VA = "0x182643D00")]
	public static bool JJJFCLPJGOG<T>(ENNJBCLFMNB IKHOLAJCJOG, T BBMFDCMOICG, [Out] T EJBIJNCCDFG) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x2643F10", Offset = "0x2642F10", VA = "0x182643F10")]
	public static bool KMKOOAALLDL<T>(ENNJBCLFMNB IKHOLAJCJOG) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x2643ED0", Offset = "0x2642ED0", VA = "0x182643ED0")]
	public static T LNKEGHLMDOM<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x2643E30", Offset = "0x2642E30", VA = "0x182643E30")]
	public static bool JJJFCLPJGOG<T>(T BBMFDCMOICG, [Out] T EJBIJNCCDFG) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x2643ED0", Offset = "0x2642ED0", VA = "0x182643ED0")]
	public static bool KMKOOAALLDL<T>() where T : class
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
internal static class EEHAMPEDPBL
{
	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x61CB250", Offset = "0x61CA250", VA = "0x1861CB250")]
	public static void FOKGFJMMBCA(IEnumerable KKBLHGDHICE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x266FED0", Offset = "0x266EED0", VA = "0x18266FED0")]
	public static void FOKGFJMMBCA<T>(T[] IJPOMPNGBEF) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x266FFC0", Offset = "0x266EFC0", VA = "0x18266FFC0")]
	public static void FOKGFJMMBCA<T>(T PDPILKIDIPM) where T : notnull, Enum
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
