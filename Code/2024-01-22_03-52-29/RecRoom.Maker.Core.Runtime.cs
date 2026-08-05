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
		[Cpp2IlInjected.Address(RVA = "0x7BAB50", Offset = "0x7B9F50", VA = "0x1807BAB50")]
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
		[Cpp2IlInjected.Address(RVA = "0x603CFF0", Offset = "0x603C3F0", VA = "0x18603CFF0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7BB450", Offset = "0x7BA850", VA = "0x1807BB450")]
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
		[Cpp2IlInjected.Address(RVA = "0x7BB490", Offset = "0x7BA890", VA = "0x1807BB490")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface NCOKNPOGPFE<TData, TReturn>
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TReturn CanConnectableObjectBeSelected(TData DFFBALIDCLL);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface NDFAIENNNFJ<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ClearHoverTarget(JFBHHNKHEEC CONNFNFBPCF);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool SetHoverTarget(TData GOOANMNBGEP, Collider JFKHHGKNLJJ, JFBHHNKHEEC CONNFNFBPCF, [Optional] JABODDDNBPD? JEAAJBDDEAD);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool TryGetHoverTarget([Out] TData GOOANMNBGEP);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetHoverCollider([Out] Collider JFKHHGKNLJJ);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface EKCAACGMHMH<TData> : MGAPAOICHKB, LELDKLPHOKO<TData>, DNGGKOIPLBG<TData>, JNADEBBMGAD<TData>, FGDCNMKDJEC, OHODMECMPPE<TData>, MNJOJNOBCNL, EMKLILFEOHC
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface OHODMECMPPE<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 KNAFBGNLKFP, Vector3 PLJNLCOFMBP, float IPFKFHJNJJM, [Out] T IKMLOEKFPND, [Out] Vector3 NCADKBFFIKN, [Out] Collider JFKHHGKNLJJ);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 KNAFBGNLKFP, Vector3 PLJNLCOFMBP, float FOPDPOGLEKI, float IPFKFHJNJJM, T[] GAHCIKHILCK, [Out] Vector3 CADPJGHLCPN, [Out] Collider ALKAIBBBFEE);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 KNAFBGNLKFP, float FOPDPOGLEKI, Vector3 OFCPDCHGJEB, T[] GAHCIKHILCK);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetObjectFromColliderInCurrentScope(Collider OHBBEBBKENI, [Out] T MOPCGFMBJPH);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface MGAPAOICHKB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Bounds IFGKGENOONA
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Transform JEPBIMEFODB
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Bounds IMGCHNLHALI
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Transform EOEOBPLAHOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Vector3 OEAMNPLPCBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void SetSelectionBoundsDirty(bool CFNDEPFGPIB = true, int PMKGNJEPPMG = 0);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ShouldHideSelectionBoundsPreview(bool PPCLNFNMBMJ, object KNOHBODGPLL);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface EMKLILFEOHC
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	DECPPMKECOG HADKMCIONIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface LOBHDJMMAKO
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool ACGNDKNPJDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool DCMPIGOJAEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool KOCNDCGJPJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Dictionary<Guid, Guid> TryGetPreviousCloneMapping();

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void TrySetPreviousCloneMapping(Dictionary<Guid, Guid> GMIPGMBGHIC);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface JNADEBBMGAD<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool EFKJPBJFFKK
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	int DLLKIHEHKEE
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	IEnumerable<TData> CLJMIBFCKGG
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData JCBFPBHHLOH);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData JCBFPBHHLOH);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface LELDKLPHOKO<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T DFFBALIDCLL, [Optional] JABODDDNBPD? LENMFDEEMDE, bool JMMAGNKAJFC = true);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int GNHCGOJHAJG, IEnumerable<T> LCHLOMPFKPL, bool JMMAGNKAJFC = true);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int GNHCGOJHAJG, IEnumerable<T> LCHLOMPFKPL, JABODDDNBPD LENMFDEEMDE, bool JMMAGNKAJFC = true);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface MNJOJNOBCNL
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface FGDCNMKDJEC
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool MOADLPBNBOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool ONOPDIAAPCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool NIKGGMAKAHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool AKNBBHNPNLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class LHHIKFJKDLF<TReceiver> : KGJPOOJGOOJ<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x32BEEA0", Offset = "0x32BE2A0", VA = "0x1832BEEA0")]
	public LHHIKFJKDLF(TReceiver PBGFHGDDDAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class LHMDAGIIKCD<TReceiver, TFromTask> : KGJPOOJGOOJ<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x32BEEA0", Offset = "0x32BE2A0", VA = "0x1832BEEA0")]
	public LHMDAGIIKCD(TReceiver PBGFHGDDDAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public abstract class KGJPOOJGOOJ<TReceiver, TFromExecute> where TReceiver : notnull where TFromExecute : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	protected TReceiver PBGFHGDDDAM;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3B38820", Offset = "0x3B37C20", VA = "0x183B38820")]
	public KGJPOOJGOOJ(TReceiver PBGFHGDDDAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute GMCNCCAGNOA();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public abstract class PPPMPFIOPPJ<TReceiver, TResult> : KGJPOOJGOOJ<TReceiver, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x32BEEA0", Offset = "0x32BE2A0", VA = "0x1832BEEA0")]
	public PPPMPFIOPPJ(TReceiver PBGFHGDDDAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct APHGAEHJCNC<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public TGroup KLAICPLMJAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public TData IEODGODEPPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public IEnumerable<TData> IOOFFMGIJDK;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x1A0F540", Offset = "0x1A0E940", VA = "0x181A0F540")]
	public APHGAEHJCNC(TGroup IJFEMADGGPM, TData JIFELMPFPKD, IEnumerable<TData> EMDPAFGGEJP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct KLJBPNNFABN<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public TGroup KLAICPLMJAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public IEnumerable<TData> IOOFFMGIJDK;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x863610", Offset = "0x862A10", VA = "0x180863610")]
	public KLJBPNNFABN(TGroup IJFEMADGGPM, IEnumerable<TData> EMDPAFGGEJP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct NABPNFELCJP<TGroup> where TGroup : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public TGroup KLAICPLMJAM;

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8BCA20", Offset = "0x8BBE20", VA = "0x1808BCA20")]
	public NABPNFELCJP(TGroup IJFEMADGGPM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct GNFLCJBPLCK<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public IEnumerable<TData> IOOFFMGIJDK;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8BCA20", Offset = "0x8BBE20", VA = "0x1808BCA20")]
	public GNFLCJBPLCK(IEnumerable<TData> EMDPAFGGEJP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface DKNEPPAPEPC<TGroup, TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LNKNLDCMGEE ODCAICDBBCA(APHGAEHJCNC<TGroup, TData> DGCBMGDIFLK);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LNKNLDCMGEE NFGFFJKICBD(APHGAEHJCNC<TGroup, TData> DGCBMGDIFLK);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "2")]
	LNKNLDCMGEE OGCNKNMIIJP(KLJBPNNFABN<TGroup, TData> DGCBMGDIFLK);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "3")]
	LNKNLDCMGEE AHDJAELBGKB(NABPNFELCJP<TGroup> DGCBMGDIFLK);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface MFBJMHFLHHC<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<LNKNLDCMGEE> ODCAICDBBCA(GNFLCJBPLCK<TData> DGCBMGDIFLK);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class PMMICCNKPLA<TGroup, TData> : PPPMPFIOPPJ<DKNEPPAPEPC<TGroup, TData>, LNKNLDCMGEE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly KLJBPNNFABN<TGroup, TData> DGCBMGDIFLK;

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4080C10", Offset = "0x4080010", VA = "0x184080C10")]
	public PMMICCNKPLA(TGroup IJFEMADGGPM, IEnumerable<TData> EMDPAFGGEJP, DKNEPPAPEPC<TGroup, TData> PBGFHGDDDAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4080B40", Offset = "0x407FF40", VA = "0x184080B40", Slot = "4")]
	public override LNKNLDCMGEE GMCNCCAGNOA()
	{
		return default(LNKNLDCMGEE);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class CNHNCJKMALP<TGroup, TData> : PPPMPFIOPPJ<DKNEPPAPEPC<TGroup, TData>, LNKNLDCMGEE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly APHGAEHJCNC<TGroup, TData> DGCBMGDIFLK;

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x374C520", Offset = "0x374B920", VA = "0x18374C520")]
	public CNHNCJKMALP(TGroup IJFEMADGGPM, TData PNAHOJKBLFH, IEnumerable<TData> EMDPAFGGEJP, DKNEPPAPEPC<TGroup, TData> PBGFHGDDDAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4C829E0", Offset = "0x4C81DE0", VA = "0x184C829E0", Slot = "4")]
	public override LNKNLDCMGEE GMCNCCAGNOA()
	{
		return default(LNKNLDCMGEE);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class NFPFMIBFAKE<TGroup, TData> : PPPMPFIOPPJ<DKNEPPAPEPC<TGroup, TData>, LNKNLDCMGEE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly NABPNFELCJP<TGroup> DGCBMGDIFLK;

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3E909E0", Offset = "0x3E8FDE0", VA = "0x183E909E0")]
	public NFPFMIBFAKE(TGroup IJFEMADGGPM, DKNEPPAPEPC<TGroup, TData> PBGFHGDDDAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3E90910", Offset = "0x3E8FD10", VA = "0x183E90910", Slot = "4")]
	public override LNKNLDCMGEE GMCNCCAGNOA()
	{
		return default(LNKNLDCMGEE);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class AHCILADCLDK<TGroup, TData> : PPPMPFIOPPJ<DKNEPPAPEPC<TGroup, TData>, LNKNLDCMGEE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly APHGAEHJCNC<TGroup, TData> DGCBMGDIFLK;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x374C520", Offset = "0x374B920", VA = "0x18374C520")]
	public AHCILADCLDK(TGroup IJFEMADGGPM, TData JIFELMPFPKD, IEnumerable<TData> EMDPAFGGEJP, DKNEPPAPEPC<TGroup, TData> PBGFHGDDDAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x374C440", Offset = "0x374B840", VA = "0x18374C440", Slot = "4")]
	public override LNKNLDCMGEE GMCNCCAGNOA()
	{
		return default(LNKNLDCMGEE);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class BPNOINAPFME<TData> : LHMDAGIIKCD<MFBJMHFLHHC<TData>, LNKNLDCMGEE> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private struct MGMIPDCGGHN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AsyncTaskMethodBuilder<LNKNLDCMGEE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public BPNOINAPFME<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private TaskAwaiter<LNKNLDCMGEE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3E035C0", Offset = "0x3E029C0", VA = "0x183E035C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x3E03860", Offset = "0x3E02C60", VA = "0x183E03860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private GNFLCJBPLCK<TData> DGCBMGDIFLK;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3E909E0", Offset = "0x3E8FDE0", VA = "0x183E909E0")]
	public BPNOINAPFME(IEnumerable<TData> OFIBDIKMICK, MFBJMHFLHHC<TData> PBGFHGDDDAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x47C30C0", Offset = "0x47C24C0", VA = "0x1847C30C0", Slot = "4")]
	[AsyncStateMachine(typeof(BPNOINAPFME<>.MGMIPDCGGHN))]
	public override Task<LNKNLDCMGEE> GMCNCCAGNOA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct PLAHFBCAFCL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly NAKIJNGAOBK MJLAJBOGPHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly bool NOIONHPNMDG;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x603D1C0", Offset = "0x603C5C0", VA = "0x18603D1C0")]
	public PLAHFBCAFCL(NAKIJNGAOBK DDACDPGPCOA, bool AJAMJHCJEFP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface LBLGOBHFMPA<TSpawnType> where TSpawnType : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> GMCNCCAGNOA(PLAHFBCAFCL DNMOBEHCCIO);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class CMKPIGLDCHA<TSpawnType> : LHMDAGIIKCD<LBLGOBHFMPA<TSpawnType>, TSpawnType> where TSpawnType : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private struct NBHKLAJKOCE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public AsyncTaskMethodBuilder<TSpawnType> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public CMKPIGLDCHA<TSpawnType> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskAwaiter<TSpawnType> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3E71570", Offset = "0x3E70970", VA = "0x183E71570", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x3E71980", Offset = "0x3E70D80", VA = "0x183E71980", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly PLAHFBCAFCL DNMOBEHCCIO;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x4C7B8D0", Offset = "0x4C7ACD0", VA = "0x184C7B8D0")]
	public CMKPIGLDCHA(NAKIJNGAOBK DDACDPGPCOA, bool AJAMJHCJEFP, LBLGOBHFMPA<TSpawnType> PBGFHGDDDAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x4C7B6D0", Offset = "0x4C7AAD0", VA = "0x184C7B6D0", Slot = "4")]
	[AsyncStateMachine(typeof(CMKPIGLDCHA<>.NBHKLAJKOCE))]
	public override Task<TSpawnType> GMCNCCAGNOA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public readonly struct NAKIJNGAOBK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly bool HPEIDMDMCCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly Vector3 OJGIAAAKMFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly Vector3 CNEKGDKGHGE;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x603CBB0", Offset = "0x603BFB0", VA = "0x18603CBB0")]
	public NAKIJNGAOBK(Transform IODHOKDMBFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x603CB80", Offset = "0x603BF80", VA = "0x18603CB80")]
	public NAKIJNGAOBK(Vector3 KELADLMJIOC, Vector3 BCGGHPIMKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x603CAC0", Offset = "0x603BEC0", VA = "0x18603CAC0")]
	public static NAKIJNGAOBK BKBFLDHHCMN()
	{
		return default(NAKIJNGAOBK);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x603CAF0", Offset = "0x603BEF0", VA = "0x18603CAF0")]
	private NAKIJNGAOBK(bool LJCGAEJHLNA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct HGCOBNPIFPM<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public TNode LEGKPKILPGL;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x381CBD0", Offset = "0x381BFD0", VA = "0x18381CBD0")]
	public HGCOBNPIFPM(TNode LEGKPKILPGL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct HMCCHIMNOGH<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public TNode JMIKNGLIHLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public JNDMMHEMLOG JOFOIMLGHFJ;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3831C60", Offset = "0x3831060", VA = "0x183831C60")]
	public HMCCHIMNOGH(TNode JMIKNGLIHLN, JNDMMHEMLOG JOFOIMLGHFJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface BNBODHDHHBH<TNode>
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MJCPBPHOANG([In] HGCOBNPIFPM<TNode> JMDJEIMPJJK);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DCMLPECPOJM([In] HMCCHIMNOGH<TNode> ICEDPLHCFCM);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LHMOGDBLFAE();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class DDINCJKPOIA<TNode> : LHHIKFJKDLF<BNBODHDHHBH<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x32BEEA0", Offset = "0x32BE2A0", VA = "0x1832BEEA0")]
	public DDINCJKPOIA(BNBODHDHHBH<TNode> PBGFHGDDDAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3829B80", Offset = "0x3828F80", VA = "0x183829B80", Slot = "4")]
	public override bool GMCNCCAGNOA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class HIHIMOIJEDL<TNode> : LHHIKFJKDLF<BNBODHDHHBH<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly HMCCHIMNOGH<TNode> ICEDPLHCFCM;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3826150", Offset = "0x3825550", VA = "0x183826150")]
	public HIHIMOIJEDL(TNode JMIKNGLIHLN, JNDMMHEMLOG JOFOIMLGHFJ, BNBODHDHHBH<TNode> PBGFHGDDDAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x32E3850", Offset = "0x32E2C50", VA = "0x1832E3850", Slot = "4")]
	public override bool GMCNCCAGNOA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class HFILOPBKCEA<TNode> : LHHIKFJKDLF<BNBODHDHHBH<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly HGCOBNPIFPM<TNode> JMDJEIMPJJK;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x381C530", Offset = "0x381B930", VA = "0x18381C530")]
	public HFILOPBKCEA(TNode KLKFBJNFADJ, BNBODHDHHBH<TNode> PBGFHGDDDAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x32B4850", Offset = "0x32B3C50", VA = "0x1832B4850", Slot = "4")]
	public override bool GMCNCCAGNOA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct DBDCGOCDINP<TSpawnInfo> where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public TSpawnInfo MFAPCJJMLOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public Vector3 BCGGHPIMKDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public Quaternion GIJALKLADPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public float GLDPLANNJMB;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0xE2D2B0", Offset = "0xE2C6B0", VA = "0x180E2D2B0")]
	public DBDCGOCDINP(TSpawnInfo MFAPCJJMLOF, Vector3 BCGGHPIMKDA, Quaternion GIJALKLADPN, float GLDPLANNJMB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface IEKCPELDKNF<TSpawnType, TSpawnInfo>
{
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> BHPEAPMKEAN([In] DBDCGOCDINP<TSpawnInfo> KGDOMHFFCIP, CancellationToken HHHPDCGPCML);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class FBIODIAGGFG<TSpawnType, TSpawnInfo> : LHMDAGIIKCD<IEKCPELDKNF<TSpawnType, TSpawnInfo>, TSpawnType> where TSpawnType : notnull where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly DBDCGOCDINP<TSpawnInfo> CNLJFDAGKBD;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x363EFA0", Offset = "0x363E3A0", VA = "0x18363EFA0")]
	public FBIODIAGGFG(TSpawnInfo LFLJBMJBAMH, Vector3 BCGGHPIMKDA, Quaternion GIJALKLADPN, float GLDPLANNJMB, IEKCPELDKNF<TSpawnType, TSpawnInfo> PBGFHGDDDAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x363ECD0", Offset = "0x363E0D0", VA = "0x18363ECD0", Slot = "4")]
	public override Task<TSpawnType> GMCNCCAGNOA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct AIEMNINBNDD<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly IEnumerable<TData> IOOFFMGIJDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly bool NOIONHPNMDG;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x374E110", Offset = "0x374D510", VA = "0x18374E110")]
	public AIEMNINBNDD(IEnumerable<TData> EMDPAFGGEJP, bool AJAMJHCJEFP = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface OLOMNEPBIDN<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<LNKNLDCMGEE> DFEAPAFDHGN([In] AIEMNINBNDD<TData> ECCFEMAMODC, CancellationToken HHHPDCGPCML);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class GEMLJHBFEDO<TData> : LHMDAGIIKCD<OLOMNEPBIDN<TData>, LNKNLDCMGEE> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly AIEMNINBNDD<TData> GFDDDAFBMJI;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x3776390", Offset = "0x3775790", VA = "0x183776390")]
	public GEMLJHBFEDO(IEnumerable<TData> EMDPAFGGEJP, bool AJAMJHCJEFP, OLOMNEPBIDN<TData> PBGFHGDDDAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x363ECD0", Offset = "0x363E0D0", VA = "0x18363ECD0", Slot = "4")]
	public override Task<LNKNLDCMGEE> GMCNCCAGNOA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct NPDKJMFOOOG<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly T GOOANMNBGEP;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3B75810", Offset = "0x3B74C10", VA = "0x183B75810")]
	public NPDKJMFOOOG(T OJONPJNCLBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface ELJBBKIBDMK<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MJCPBPHOANG([In] NPDKJMFOOOG<T> JIDJDFCKBEM);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DCMLPECPOJM();
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface APJFIOHHJAN<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GMCNCCAGNOA([In] HCAHPKEBAMG<T> KPHIKNODINH);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct HCAHPKEBAMG<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public readonly T GOOANMNBGEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public readonly bool LDLAPLNCJMJ;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x3807930", Offset = "0x3806D30", VA = "0x183807930")]
	public HCAHPKEBAMG(T OJONPJNCLBL, bool ONEMGIBFOJJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class HEPEPKELGMN<T> : LHHIKFJKDLF<ELJBBKIBDMK<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x32BEEA0", Offset = "0x32BE2A0", VA = "0x1832BEEA0")]
	public HEPEPKELGMN(ELJBBKIBDMK<T> PBGFHGDDDAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x381AE30", Offset = "0x381A230", VA = "0x18381AE30", Slot = "4")]
	public override bool GMCNCCAGNOA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class PAIOEAFOBBA<T> : LHHIKFJKDLF<ELJBBKIBDMK<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly NPDKJMFOOOG<T> JIDJDFCKBEM;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x4046290", Offset = "0x4045690", VA = "0x184046290")]
	public PAIOEAFOBBA(T GOOANMNBGEP, ELJBBKIBDMK<T> PBGFHGDDDAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x32B4850", Offset = "0x32B3C50", VA = "0x1832B4850", Slot = "4")]
	public override bool GMCNCCAGNOA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class OPPCICOAHIJ<T> : LHHIKFJKDLF<APJFIOHHJAN<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly HCAHPKEBAMG<T> KPHIKNODINH;

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x3FADFE0", Offset = "0x3FAD3E0", VA = "0x183FADFE0")]
	public OPPCICOAHIJ(T GOOANMNBGEP, bool ONEMGIBFOJJ, APJFIOHHJAN<T> PBGFHGDDDAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x32B4850", Offset = "0x32B3C50", VA = "0x1832B4850", Slot = "4")]
	public override bool GMCNCCAGNOA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct IPEOAKEIPNN<TData> where TData : notnull, MKBFOIBGODA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public IEnumerable<TData> IOOFFMGIJDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public bool KMNHGGLBEMG;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x392B2A0", Offset = "0x392A6A0", VA = "0x18392B2A0")]
	public IPEOAKEIPNN(IEnumerable<TData> PFOGMIIIECO, bool KIOMHBDABMG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct ICNFLPOLHAL<TData> where TData : notnull, MKBFOIBGODA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public List<TData> IOOFFMGIJDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public List<bool> MLOMMHBJFAG;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x38D99B0", Offset = "0x38D8DB0", VA = "0x1838D99B0")]
	public ICNFLPOLHAL(List<TData> PFOGMIIIECO, List<bool> JDFNOABMDHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface MKBFOIBGODA
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool GCCOLJBBIII
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface HIHGAAGMIDL<TData> where TData : MKBFOIBGODA
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GMCNCCAGNOA([In] IPEOAKEIPNN<TData> LCALHCJNOAD);

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GMCNCCAGNOA([In] ICNFLPOLHAL<TData> LCALHCJNOAD);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface AOECNNIECKK<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EOLKCJMMFEG(T GOOANMNBGEP);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class LEGEEMHHKOA<TData> : LHHIKFJKDLF<HIHGAAGMIDL<TData>> where TData : notnull, MKBFOIBGODA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly IPEOAKEIPNN<TData> LCALHCJNOAD;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x3BFBE80", Offset = "0x3BFB280", VA = "0x183BFBE80")]
	public LEGEEMHHKOA(List<TData> EMDPAFGGEJP, bool KMNHGGLBEMG, HIHGAAGMIDL<TData> PBGFHGDDDAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x32B4850", Offset = "0x32B3C50", VA = "0x1832B4850", Slot = "4")]
	public override bool GMCNCCAGNOA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class HFCMJEPEJIN<TData> : LHHIKFJKDLF<HIHGAAGMIDL<TData>> where TData : notnull, MKBFOIBGODA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly ICNFLPOLHAL<TData> LCALHCJNOAD;

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x381C4A0", Offset = "0x381B8A0", VA = "0x18381C4A0")]
	public HFCMJEPEJIN(List<TData> EMDPAFGGEJP, List<bool> MLOMMHBJFAG, HIHGAAGMIDL<TData> PBGFHGDDDAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x3808380", Offset = "0x3807780", VA = "0x183808380", Slot = "4")]
	public override bool GMCNCCAGNOA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface KAJKHGBPKLK : MKBFOIBGODA
{
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface IMAJPMNDOHC<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<LNKNLDCMGEE> GMCNCCAGNOA(HGHBBMLLFAI<TData> ELLMEKCAKIF);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class MNBHBNAGMGA<TData> : LHMDAGIIKCD<IMAJPMNDOHC<TData>, LNKNLDCMGEE> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct AJGLBJEBPAF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public AsyncTaskMethodBuilder<LNKNLDCMGEE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public MNBHBNAGMGA<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<LNKNLDCMGEE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x374FFB0", Offset = "0x374F3B0", VA = "0x18374FFB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x37502A0", Offset = "0x374F6A0", VA = "0x1837502A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly HGHBBMLLFAI<TData> JNGJADLKOHG;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x3E13BA0", Offset = "0x3E12FA0", VA = "0x183E13BA0")]
	public MNBHBNAGMGA(TData KOEEGEOEOAL, IReadOnlyList<TData> HLPGHKHPJHC, bool AJAMJHCJEFP, IMAJPMNDOHC<TData> PBGFHGDDDAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x3E13AA0", Offset = "0x3E12EA0", VA = "0x183E13AA0", Slot = "4")]
	[AsyncStateMachine(typeof(MNBHBNAGMGA<>.AJGLBJEBPAF))]
	public override Task<LNKNLDCMGEE> GMCNCCAGNOA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public struct HGHBBMLLFAI<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public TData GEKLLIIELNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public IReadOnlyList<TData> GLJDMAGHBNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public bool NOIONHPNMDG;

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x381D190", Offset = "0x381C590", VA = "0x18381D190")]
	public HGHBBMLLFAI(TData KOEEGEOEOAL, IReadOnlyList<TData> HLPGHKHPJHC, bool AJAMJHCJEFP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface JLJMANLNNDJ<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GMCNCCAGNOA([In] IIPDOFDIPPB<TData> OGNAGJCBMAB);
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface MBKPGBEADFJ<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GMCNCCAGNOA([In] POBPLKNNEEF<TData> OGNAGJCBMAB);
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface CHAJGNGBHBM<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MCDPLIHKKIC([In] PONFOOPLFAL<TData> OGNAGJCBMAB);

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DCMLPECPOJM();
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class GPGPMDMMMEL<TData> : LHHIKFJKDLF<JLJMANLNNDJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly IIPDOFDIPPB<TData> OGNAGJCBMAB;

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x37D8BB0", Offset = "0x37D7FB0", VA = "0x1837D8BB0")]
	public GPGPMDMMMEL(IEnumerable<TData> EMDPAFGGEJP, OJHIPOOMDJF JKOGDMNIBNM, HDPKBMCAODL DELNJNDMHJJ, float MCCCMMHNMOG, bool AJAMJHCJEFP, JLJMANLNNDJ<TData> PBGFHGDDDAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x32B4850", Offset = "0x32B3C50", VA = "0x1832B4850", Slot = "4")]
	public override bool GMCNCCAGNOA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class HHMDPNCIOPB<TData> : LHHIKFJKDLF<MBKPGBEADFJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly POBPLKNNEEF<TData> OGNAGJCBMAB;

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x381DA20", Offset = "0x381CE20", VA = "0x18381DA20")]
	public HHMDPNCIOPB(TData[] EMDPAFGGEJP, OJHIPOOMDJF[] JKOGDMNIBNM, HDPKBMCAODL[] DELNJNDMHJJ, float[] MCCCMMHNMOG, MBKPGBEADFJ<TData> PBGFHGDDDAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x381D960", Offset = "0x381CD60", VA = "0x18381D960", Slot = "4")]
	public override bool GMCNCCAGNOA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class JNHOAJAIFOE<TData> : LHHIKFJKDLF<CHAJGNGBHBM<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x32BEEA0", Offset = "0x32BE2A0", VA = "0x1832BEEA0")]
	public JNHOAJAIFOE(CHAJGNGBHBM<TData> PBGFHGDDDAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3AE3F90", Offset = "0x3AE3390", VA = "0x183AE3F90", Slot = "4")]
	public override bool GMCNCCAGNOA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class BKNIHMHJLEF<TData> : LHHIKFJKDLF<CHAJGNGBHBM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly PONFOOPLFAL<TData> OGNAGJCBMAB;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x4713FB0", Offset = "0x47133B0", VA = "0x184713FB0")]
	public BKNIHMHJLEF(IEnumerable<TData> EMDPAFGGEJP, OJHIPOOMDJF JKOGDMNIBNM, HDPKBMCAODL DELNJNDMHJJ, float MCCCMMHNMOG, CHAJGNGBHBM<TData> PBGFHGDDDAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x381D960", Offset = "0x381CD60", VA = "0x18381D960", Slot = "4")]
	public override bool GMCNCCAGNOA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct IIPDOFDIPPB<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public IEnumerable<TData> IOOFFMGIJDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public OJHIPOOMDJF JPJAEGPCJKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public HDPKBMCAODL AEACPPPKIAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public float MCCCMMHNMOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public bool AJAMJHCJEFP;

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x38E4280", Offset = "0x38E3680", VA = "0x1838E4280")]
	public IIPDOFDIPPB(IEnumerable<TData> EMDPAFGGEJP, OJHIPOOMDJF JKOGDMNIBNM, HDPKBMCAODL DELNJNDMHJJ, float MCCCMMHNMOG, bool AJAMJHCJEFP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public struct POBPLKNNEEF<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public TData[] IOOFFMGIJDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public OJHIPOOMDJF[] JPJAEGPCJKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public HDPKBMCAODL[] AEACPPPKIAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public float[] MCCCMMHNMOG;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4086A00", Offset = "0x4085E00", VA = "0x184086A00")]
	public POBPLKNNEEF(TData[] EMDPAFGGEJP, OJHIPOOMDJF[] JKOGDMNIBNM, HDPKBMCAODL[] DELNJNDMHJJ, float[] MCCCMMHNMOG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public struct PONFOOPLFAL<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public IEnumerable<TData> IOOFFMGIJDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public OJHIPOOMDJF JPJAEGPCJKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public HDPKBMCAODL AEACPPPKIAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public float MCCCMMHNMOG;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x4088D10", Offset = "0x4088110", VA = "0x184088D10")]
	public PONFOOPLFAL(IEnumerable<TData> EMDPAFGGEJP, OJHIPOOMDJF JKOGDMNIBNM, HDPKBMCAODL DELNJNDMHJJ, float MCCCMMHNMOG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface DNGGKOIPLBG<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OGCNKNMIIJP([In] MOCHBJKPHDF<TData> ECCFEMAMODC);

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AHDJAELBGKB([In] MOCHBJKPHDF<TData> ECCFEMAMODC);

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JGEFEOMGINJ([In] bool JFAJOHABDCD);

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HOOPHFENOAD([In] MOCHBJKPHDF<TData> ECCFEMAMODC);

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DAHMPGLFCLE();

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool PJCFFDCIKAN([In] TData JMNKNMKKDCA);
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class EGDLFKHIGOL<TData> : LHHIKFJKDLF<DNGGKOIPLBG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly MOCHBJKPHDF<TData> ECCFEMAMODC;

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x32B4910", Offset = "0x32B3D10", VA = "0x1832B4910")]
	public EGDLFKHIGOL(List<TData> MEKGNJLOKAF, DNGGKOIPLBG<TData> PBGFHGDDDAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x32B4850", Offset = "0x32B3C50", VA = "0x1832B4850", Slot = "4")]
	public override bool GMCNCCAGNOA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class HCLEDFJCIKI<TData> : LHHIKFJKDLF<DNGGKOIPLBG<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x32BEEA0", Offset = "0x32BE2A0", VA = "0x1832BEEA0")]
	public HCLEDFJCIKI(DNGGKOIPLBG<TData> PBGFHGDDDAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3809170", Offset = "0x3808570", VA = "0x183809170", Slot = "4")]
	public override bool GMCNCCAGNOA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class HKFIOMOAKNM<TData> : LHHIKFJKDLF<DNGGKOIPLBG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly bool AJAMJHCJEFP;

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x382A700", Offset = "0x3829B00", VA = "0x18382A700")]
	public HKFIOMOAKNM(bool AJAMJHCJEFP, DNGGKOIPLBG<TData> PBGFHGDDDAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x382A6A0", Offset = "0x3829AA0", VA = "0x18382A6A0", Slot = "4")]
	public override bool GMCNCCAGNOA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class HCECLGFCJJH<TData> : LHHIKFJKDLF<DNGGKOIPLBG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly MOCHBJKPHDF<TData> ECCFEMAMODC;

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x38084D0", Offset = "0x38078D0", VA = "0x1838084D0")]
	public HCECLGFCJJH(List<TData> MEKGNJLOKAF, bool AJAMJHCJEFP, DNGGKOIPLBG<TData> PBGFHGDDDAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3808380", Offset = "0x3807780", VA = "0x183808380", Slot = "4")]
	public override bool GMCNCCAGNOA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class KJOPDOELPGD<TData> : LHHIKFJKDLF<DNGGKOIPLBG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly TData JMNKNMKKDCA;

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3B51850", Offset = "0x3B50C50", VA = "0x183B51850")]
	public KJOPDOELPGD(TData JMNKNMKKDCA, DNGGKOIPLBG<TData> PBGFHGDDDAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3B516D0", Offset = "0x3B50AD0", VA = "0x183B516D0", Slot = "4")]
	public override bool GMCNCCAGNOA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class OHLHMMNMNMF<TData> : LHHIKFJKDLF<DNGGKOIPLBG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly MOCHBJKPHDF<TData> ECCFEMAMODC;

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3FA1FF0", Offset = "0x3FA13F0", VA = "0x183FA1FF0")]
	public OHLHMMNMNMF(IEnumerable<TData> MEKGNJLOKAF, DNGGKOIPLBG<TData> PBGFHGDDDAM, bool AJAMJHCJEFP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3FA1E80", Offset = "0x3FA1280", VA = "0x183FA1E80", Slot = "4")]
	public override bool GMCNCCAGNOA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public struct MOCHBJKPHDF<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public IEnumerable<TData> IOOFFMGIJDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public bool AJAMJHCJEFP;

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x3E187A0", Offset = "0x3E17BA0", VA = "0x183E187A0")]
	public MOCHBJKPHDF(IEnumerable<TData> PFOGMIIIECO, bool AKHLMMBMIJN = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface EOABOKDINPL
{
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<LNKNLDCMGEE> GMCNCCAGNOA(HHJIPIEAKEB IMNPKACJNAI);
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public class PCNOBPCCJCL : LHMDAGIIKCD<EOABOKDINPL, LNKNLDCMGEE>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private struct LGFOMLOGDBG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public AsyncTaskMethodBuilder<LNKNLDCMGEE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public PCNOBPCCJCL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private TaskAwaiter<LNKNLDCMGEE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x603C6A0", Offset = "0x603BAA0", VA = "0x18603C6A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x603C920", Offset = "0x603BD20", VA = "0x18603C920", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly HHJIPIEAKEB KPKPCPAGGOE;

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x603D160", Offset = "0x603C560", VA = "0x18603D160")]
	public PCNOBPCCJCL(bool AJAMJHCJEFP, EOABOKDINPL PBGFHGDDDAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x603D070", Offset = "0x603C470", VA = "0x18603D070", Slot = "4")]
	[AsyncStateMachine(typeof(LGFOMLOGDBG))]
	public override Task<LNKNLDCMGEE> GMCNCCAGNOA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public struct HHJIPIEAKEB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public bool NOIONHPNMDG;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0xC213A0", Offset = "0xC207A0", VA = "0x180C213A0")]
	public HHJIPIEAKEB(bool AJAMJHCJEFP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public readonly struct KGGECGDIHAI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly bool CJFBBHNMPML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly bool LOKDCNOOHJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly bool GLDPLANNJMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public readonly bool AJAMJHCJEFP;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x455EB90", Offset = "0x455DF90", VA = "0x18455EB90")]
	public KGGECGDIHAI(bool CJFBBHNMPML, bool LOKDCNOOHJC, bool GLDPLANNJMB, bool AJAMJHCJEFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x603C690", Offset = "0x603BA90", VA = "0x18603C690")]
	public KGGECGDIHAI(bool LOKDCNOOHJC, bool AJAMJHCJEFP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public interface JNABBOBBNII
{
	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KKOKDHAHINJ(KGGECGDIHAI NNBLHJEJACB);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HAOGCOJNPHI(KGGECGDIHAI NNBLHJEJACB);
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class BCMILOJNOML : LHHIKFJKDLF<JNABBOBBNII>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly KGGECGDIHAI NNBLHJEJACB;

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x603C260", Offset = "0x603B660", VA = "0x18603C260")]
	public BCMILOJNOML(bool FIFLCPFGAIF, bool LOKDCNOOHJC, bool GLDPLANNJMB, bool AJAMJHCJEFP, JNABBOBBNII PBGFHGDDDAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x603C210", Offset = "0x603B610", VA = "0x18603C210", Slot = "4")]
	public override bool GMCNCCAGNOA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class CGOKDBENMHP : LHHIKFJKDLF<JNABBOBBNII>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly KGGECGDIHAI NNBLHJEJACB;

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x603C340", Offset = "0x603B740", VA = "0x18603C340")]
	public CGOKDBENMHP(bool LOKDCNOOHJC, bool AJAMJHCJEFP, JNABBOBBNII PBGFHGDDDAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x603C2F0", Offset = "0x603B6F0", VA = "0x18603C2F0", Slot = "4")]
	public override bool GMCNCCAGNOA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public interface FONLKPEBBKE<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MJCPBPHOANG([In] BMLPFEJDNCB<TData> JMDJEIMPJJK);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MCDPLIHKKIC([In] HJGNEOHLODG OFDFKCNHHIN);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MCDPLIHKKIC([In] IPJPFFIAEJA OFDFKCNHHIN);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DCMLPECPOJM();
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class JNCLAIJHMHP<TData> : LHHIKFJKDLF<FONLKPEBBKE<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x32BEEA0", Offset = "0x32BE2A0", VA = "0x1832BEEA0")]
	public JNCLAIJHMHP(FONLKPEBBKE<TData> PBGFHGDDDAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x3AE2FD0", Offset = "0x3AE23D0", VA = "0x183AE2FD0", Slot = "4")]
	public override bool GMCNCCAGNOA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class CDOMIAOFGPP<TData> : LHHIKFJKDLF<FONLKPEBBKE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly HJGNEOHLODG DKEGOCLFFKO;

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x49C7170", Offset = "0x49C6570", VA = "0x1849C7170")]
	public CDOMIAOFGPP(Vector3 EHMDIMPBOIG, bool AIJJOGIIJCB, FONLKPEBBKE<TData> PBGFHGDDDAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x38209F0", Offset = "0x381FDF0", VA = "0x1838209F0", Slot = "4")]
	public override bool GMCNCCAGNOA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class MGBLLAENBPJ<TData> : LHHIKFJKDLF<FONLKPEBBKE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly IPJPFFIAEJA DKEGOCLFFKO;

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x3E02F80", Offset = "0x3E02380", VA = "0x183E02F80")]
	public MGBLLAENBPJ(Guid KDIFOCGLPOP, int FGBBDGJMFEH, Vector3 BCGGHPIMKDA, Quaternion GIJALKLADPN, float MJHNLFCGBDF, bool AIJJOGIIJCB, FONLKPEBBKE<TData> PBGFHGDDDAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3E02F20", Offset = "0x3E02320", VA = "0x183E02F20", Slot = "4")]
	public override bool GMCNCCAGNOA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class CGOEFBOHLEA<TData> : LHHIKFJKDLF<FONLKPEBBKE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly BMLPFEJDNCB<TData> DKEGOCLFFKO;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x4AA0FF0", Offset = "0x4AA03F0", VA = "0x184AA0FF0")]
	public CGOEFBOHLEA(TData GOOANMNBGEP, bool AJAMJHCJEFP, FONLKPEBBKE<TData> PBGFHGDDDAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x32B4850", Offset = "0x32B3C50", VA = "0x1832B4850", Slot = "4")]
	public override bool GMCNCCAGNOA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public struct HJGNEOHLODG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public readonly Vector3 EHMDIMPBOIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public readonly bool AIJJOGIIJCB;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x603C3C0", Offset = "0x603B7C0", VA = "0x18603C3C0")]
	public HJGNEOHLODG(Vector3 EHMDIMPBOIG, bool AIJJOGIIJCB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public struct IPJPFFIAEJA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly Guid KDIFOCGLPOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public readonly int FGBBDGJMFEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public readonly Vector3 BCGGHPIMKDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public readonly Quaternion GIJALKLADPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public readonly float MJHNLFCGBDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public readonly bool AIJJOGIIJCB;

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x603C420", Offset = "0x603B820", VA = "0x18603C420")]
	public IPJPFFIAEJA(Guid KDIFOCGLPOP, int FGBBDGJMFEH, Vector3 BCGGHPIMKDA, Quaternion GIJALKLADPN, float MJHNLFCGBDF, bool AIJJOGIIJCB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public struct BMLPFEJDNCB<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public readonly TData GOOANMNBGEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public readonly bool AJAMJHCJEFP;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x471A320", Offset = "0x4719720", VA = "0x18471A320")]
	public BMLPFEJDNCB(TData GOOANMNBGEP, bool AJAMJHCJEFP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public interface BNKLHBJLODG<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GMCNCCAGNOA([In] CKIJKGOHDCJ<TData> GLKINEHGGJF);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GMCNCCAGNOA([In] GILLBOFDJIK<TData> GLKINEHGGJF);
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public interface OLJFNJDLJJF<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MJCPBPHOANG([In] HKFPDCFJKPM<TData> PJODKMGKNLC);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MCDPLIHKKIC([In] DJGGCHNEGGG OFDFKCNHHIN);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DCMLPECPOJM();
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public class LBEKDDAJOCC<TData> : LHHIKFJKDLF<BNKLHBJLODG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private readonly CKIJKGOHDCJ<TData> GLKINEHGGJF;

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x3BF5240", Offset = "0x3BF4640", VA = "0x183BF5240")]
	public LBEKDDAJOCC(IEnumerable<TData> EMDPAFGGEJP, Vector3 ADOBNBCMBKF, bool AJAMJHCJEFP, BNKLHBJLODG<TData> PBGFHGDDDAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x32B4850", Offset = "0x32B3C50", VA = "0x1832B4850", Slot = "4")]
	public override bool GMCNCCAGNOA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class HJHIGDJOIBM<TData> : LHHIKFJKDLF<OLJFNJDLJJF<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x32BEEA0", Offset = "0x32BE2A0", VA = "0x1832BEEA0")]
	public HJHIGDJOIBM(OLJFNJDLJJF<TData> PBGFHGDDDAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x3829B80", Offset = "0x3828F80", VA = "0x183829B80", Slot = "4")]
	public override bool GMCNCCAGNOA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class LBCCMMCGKMP<TData> : LHHIKFJKDLF<OLJFNJDLJJF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly HKFPDCFJKPM<TData> GLKINEHGGJF;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x3BEEC20", Offset = "0x3BEE020", VA = "0x183BEEC20")]
	public LBCCMMCGKMP(IEnumerable<TData> EMDPAFGGEJP, bool AJAMJHCJEFP, OLJFNJDLJJF<TData> PBGFHGDDDAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x32B4850", Offset = "0x32B3C50", VA = "0x1832B4850", Slot = "4")]
	public override bool GMCNCCAGNOA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class ELMLHOFENMH<TData> : LHHIKFJKDLF<BNKLHBJLODG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly GILLBOFDJIK<TData> GLKINEHGGJF;

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x32E3920", Offset = "0x32E2D20", VA = "0x1832E3920")]
	public ELMLHOFENMH(IEnumerable<TData> EMDPAFGGEJP, Vector3 CHIHOFNKAHL, PHDNBMDMCJI FDCEGDAJOPG, bool AJAMJHCJEFP, BNKLHBJLODG<TData> PBGFHGDDDAM, Space MFLONLJEIJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x32E3850", Offset = "0x32E2C50", VA = "0x1832E3850", Slot = "4")]
	public override bool GMCNCCAGNOA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class HHOPGGHANJE<TData> : LHHIKFJKDLF<OLJFNJDLJJF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly DJGGCHNEGGG GLKINEHGGJF;

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x3820A50", Offset = "0x381FE50", VA = "0x183820A50")]
	public HHOPGGHANJE(Vector3 ADOBNBCMBKF, OLJFNJDLJJF<TData> PBGFHGDDDAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x38209F0", Offset = "0x381FDF0", VA = "0x1838209F0", Slot = "4")]
	public override bool GMCNCCAGNOA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public struct CKIJKGOHDCJ<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public readonly IEnumerable<TData> EMDPAFGGEJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public readonly Vector3 ADOBNBCMBKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public readonly bool AJAMJHCJEFP;

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x4BB25E0", Offset = "0x4BB19E0", VA = "0x184BB25E0")]
	public CKIJKGOHDCJ(IEnumerable<TData> EMDPAFGGEJP, Vector3 ADOBNBCMBKF, bool AJAMJHCJEFP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct HKFPDCFJKPM<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public readonly IEnumerable<TData> EMDPAFGGEJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public readonly bool AJAMJHCJEFP;

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x382A750", Offset = "0x3829B50", VA = "0x18382A750")]
	public HKFPDCFJKPM(IEnumerable<TData> EMDPAFGGEJP, bool AJAMJHCJEFP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct GILLBOFDJIK<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public readonly IEnumerable<TData> EMDPAFGGEJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public readonly Vector3 CHIHOFNKAHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public readonly PHDNBMDMCJI FDCEGDAJOPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public readonly bool AJAMJHCJEFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly Space MFLONLJEIJP;

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x3780D10", Offset = "0x3780110", VA = "0x183780D10")]
	public GILLBOFDJIK(IEnumerable<TData> EMDPAFGGEJP, Vector3 CHIHOFNKAHL, PHDNBMDMCJI FDCEGDAJOPG, bool AJAMJHCJEFP, Space MFLONLJEIJP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct DJGGCHNEGGG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public readonly Vector3 ADOBNBCMBKF;

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x212E3B0", Offset = "0x212D7B0", VA = "0x18212E3B0")]
	public DJGGCHNEGGG(Vector3 ADOBNBCMBKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public enum PHDNBMDMCJI
{
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	XYZ,
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	X_only,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	Y_only,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	Z_only
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public interface FDCGKIFNHAO
{
	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GMCNCCAGNOA([In] EPPNCJGPJLN HCEBGLFIGJG);
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public class LNLIOKMNBLP : LHHIKFJKDLF<FDCGKIFNHAO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly EPPNCJGPJLN HCEBGLFIGJG;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x603CA60", Offset = "0x603BE60", VA = "0x18603CA60")]
	public LNLIOKMNBLP(bool AJAMJHCJEFP, FDCGKIFNHAO PBGFHGDDDAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x603C9B0", Offset = "0x603BDB0", VA = "0x18603C9B0", Slot = "4")]
	public override bool GMCNCCAGNOA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public readonly struct EPPNCJGPJLN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public readonly bool AJAMJHCJEFP;

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0xC213A0", Offset = "0xC207A0", VA = "0x180C213A0")]
	public EPPNCJGPJLN(bool AJAMJHCJEFP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public interface CMBMGFKEDHJ<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GMCNCCAGNOA([In] HIHOFFFBHFE<TData> IAGIDELNMLK);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GMCNCCAGNOA([In] AAAKEKHMJDL<TData> IAGIDELNMLK);
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public interface BLOIKMGCPOF<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MJCPBPHOANG([In] KBBDOJAKIKB<TData> JMDJEIMPJJK);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MCDPLIHKKIC([In] NIKDMCJACDO OFDFKCNHHIN);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DCMLPECPOJM();
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public class ONFDGEPHONF<TData> : LHHIKFJKDLF<CMBMGFKEDHJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly HIHOFFFBHFE<TData> IAGIDELNMLK;

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x3FAA880", Offset = "0x3FA9C80", VA = "0x183FAA880")]
	public ONFDGEPHONF(IEnumerable<TData> EMDPAFGGEJP, Quaternion ADOBNBCMBKF, Vector3? DCBBILBIMGN, bool ILCEIJNLBNB, bool AJAMJHCJEFP, CMBMGFKEDHJ<TData> PBGFHGDDDAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x32B4850", Offset = "0x32B3C50", VA = "0x1832B4850", Slot = "4")]
	public override bool GMCNCCAGNOA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class IOELNCOGFNM<TData> : LHHIKFJKDLF<BLOIKMGCPOF<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x32BEEA0", Offset = "0x32BE2A0", VA = "0x1832BEEA0")]
	public IOELNCOGFNM(BLOIKMGCPOF<TData> PBGFHGDDDAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x3829B80", Offset = "0x3828F80", VA = "0x183829B80", Slot = "4")]
	public override bool GMCNCCAGNOA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class NIAPDKLILFN<TData> : LHHIKFJKDLF<BLOIKMGCPOF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly KBBDOJAKIKB<TData> IAGIDELNMLK;

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x3E9AFD0", Offset = "0x3E9A3D0", VA = "0x183E9AFD0")]
	public NIAPDKLILFN(IEnumerable<TData> EMDPAFGGEJP, bool AJAMJHCJEFP, BLOIKMGCPOF<TData> PBGFHGDDDAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x32B4850", Offset = "0x32B3C50", VA = "0x1832B4850", Slot = "4")]
	public override bool GMCNCCAGNOA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class OGNDCBJNIDC<TData> : LHHIKFJKDLF<CMBMGFKEDHJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly AAAKEKHMJDL<TData> IAGIDELNMLK;

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x3F97280", Offset = "0x3F96680", VA = "0x183F97280")]
	public OGNDCBJNIDC(IEnumerable<TData> EMDPAFGGEJP, Quaternion BHPMBNCGBNG, PHDNBMDMCJI MBGHLGEGONL, Vector3? DCBBILBIMGN, bool ILCEIJNLBNB, bool AJAMJHCJEFP, Space MFLONLJEIJP, CMBMGFKEDHJ<TData> PBGFHGDDDAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x32E3850", Offset = "0x32E2C50", VA = "0x1832E3850", Slot = "4")]
	public override bool GMCNCCAGNOA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class OMBKDOJNCFJ<TData> : LHHIKFJKDLF<BLOIKMGCPOF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly NIKDMCJACDO IAGIDELNMLK;

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x3FA8DE0", Offset = "0x3FA81E0", VA = "0x183FA8DE0")]
	public OMBKDOJNCFJ(Quaternion ADOBNBCMBKF, Vector3? DCBBILBIMGN, bool ILCEIJNLBNB, BLOIKMGCPOF<TData> PBGFHGDDDAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x38209F0", Offset = "0x381FDF0", VA = "0x1838209F0", Slot = "4")]
	public override bool GMCNCCAGNOA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public struct HIHOFFFBHFE<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public readonly IEnumerable<TData> EMDPAFGGEJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public readonly Quaternion ADOBNBCMBKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public readonly Vector3? DCBBILBIMGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public readonly bool ILCEIJNLBNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public readonly bool AJAMJHCJEFP;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x38261E0", Offset = "0x38255E0", VA = "0x1838261E0")]
	public HIHOFFFBHFE(IEnumerable<TData> EMDPAFGGEJP, Quaternion ADOBNBCMBKF, Vector3? DCBBILBIMGN, bool ILCEIJNLBNB, bool AJAMJHCJEFP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public struct KBBDOJAKIKB<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public readonly IEnumerable<TData> EMDPAFGGEJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public readonly bool AJAMJHCJEFP;

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x3B27290", Offset = "0x3B26690", VA = "0x183B27290")]
	public KBBDOJAKIKB(IEnumerable<TData> EMDPAFGGEJP, bool AJAMJHCJEFP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public struct AAAKEKHMJDL<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public readonly IEnumerable<TData> EMDPAFGGEJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly Quaternion BHPMBNCGBNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public readonly PHDNBMDMCJI MBGHLGEGONL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public readonly Vector3? DCBBILBIMGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public readonly bool ILCEIJNLBNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public readonly bool AJAMJHCJEFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public readonly Space MFLONLJEIJP;

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x3713DF0", Offset = "0x37131F0", VA = "0x183713DF0")]
	public AAAKEKHMJDL(IEnumerable<TData> EMDPAFGGEJP, Quaternion BHPMBNCGBNG, PHDNBMDMCJI MBGHLGEGONL, Vector3? DCBBILBIMGN, bool ILCEIJNLBNB, bool AJAMJHCJEFP, Space MFLONLJEIJP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public struct NIKDMCJACDO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public readonly Quaternion ADOBNBCMBKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public readonly Vector3? DCBBILBIMGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public readonly bool ILCEIJNLBNB;

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x4524B70", Offset = "0x4523F70", VA = "0x184524B70")]
	public NIKDMCJACDO(Quaternion ADOBNBCMBKF, Vector3? DCBBILBIMGN, bool ILCEIJNLBNB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public interface FCMBPEEFHHP<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MJCPBPHOANG([In] OCODOOAGOGH<TData> JMDJEIMPJJK);

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MCDPLIHKKIC([In] AHKAHOFOJIG OFDFKCNHHIN);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MCDPLIHKKIC([In] LKGGAIEKCJJ OFDFKCNHHIN);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MCDPLIHKKIC([In] IEFPJGDDEFF OFDFKCNHHIN);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool DCMLPECPOJM();
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public class DAOCEFLGGOH<TData> : LHHIKFJKDLF<FCMBPEEFHHP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly IEFPJGDDEFF HKNCGIDKEPN;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x4F85550", Offset = "0x4F84950", VA = "0x184F85550")]
	public DAOCEFLGGOH(Vector3 PNDGJGPKOFG, float GLJGILHBCKJ, Vector3 DCBBILBIMGN, bool IMKBJCNGAFH, bool BGCNIECHHAM, FCMBPEEFHHP<TData> PBGFHGDDDAM, Space MFLONLJEIJP = Space.Self)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x4F854F0", Offset = "0x4F848F0", VA = "0x184F854F0", Slot = "4")]
	public override bool GMCNCCAGNOA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public class DAMJCBNICEJ<TData> : LHHIKFJKDLF<FCMBPEEFHHP<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x32BEEA0", Offset = "0x32BE2A0", VA = "0x1832BEEA0")]
	public DAMJCBNICEJ(FCMBPEEFHHP<TData> PBGFHGDDDAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x4F854A0", Offset = "0x4F848A0", VA = "0x184F854A0", Slot = "4")]
	public override bool GMCNCCAGNOA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public class HEMNAGMJJNE<TData> : LHHIKFJKDLF<FCMBPEEFHHP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly OCODOOAGOGH<TData> HKNCGIDKEPN;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x381ADA0", Offset = "0x381A1A0", VA = "0x18381ADA0")]
	public HEMNAGMJJNE(IEnumerable<TData> EMDPAFGGEJP, bool AJAMJHCJEFP, FCMBPEEFHHP<TData> PBGFHGDDDAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x32B4850", Offset = "0x32B3C50", VA = "0x1832B4850", Slot = "4")]
	public override bool GMCNCCAGNOA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class IDCBFNAPGJI<TData> : LHHIKFJKDLF<FCMBPEEFHHP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly LKGGAIEKCJJ HKNCGIDKEPN;

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x38DA960", Offset = "0x38D9D60", VA = "0x1838DA960")]
	public IDCBFNAPGJI(float GPJPLAKFHNN, bool HPNGMLMEIHA, Vector3 DCBBILBIMGN, FCMBPEEFHHP<TData> PBGFHGDDDAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x38DA890", Offset = "0x38D9C90", VA = "0x1838DA890", Slot = "4")]
	public override bool GMCNCCAGNOA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class NEDLMDPNNKM<TData> : LHHIKFJKDLF<FCMBPEEFHHP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly AHKAHOFOJIG HKNCGIDKEPN;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x3E8B0D0", Offset = "0x3E8A4D0", VA = "0x183E8B0D0")]
	public NEDLMDPNNKM(float GLJGILHBCKJ, Vector3 DCBBILBIMGN, FCMBPEEFHHP<TData> PBGFHGDDDAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x38209F0", Offset = "0x381FDF0", VA = "0x1838209F0", Slot = "4")]
	public override bool GMCNCCAGNOA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public struct IEFPJGDDEFF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public readonly Vector3 PNDGJGPKOFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public readonly float GLJGILHBCKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public readonly Vector3 DCBBILBIMGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public readonly bool AIJJOGIIJCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public readonly Space MFLONLJEIJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public readonly bool BGCNIECHHAM;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x603C3E0", Offset = "0x603B7E0", VA = "0x18603C3E0")]
	public IEFPJGDDEFF(Vector3 PNDGJGPKOFG, float GLJGILHBCKJ, Vector3 DCBBILBIMGN, bool AIJJOGIIJCB, bool NOMEJBKFFEP, Space MFLONLJEIJP = Space.Self)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public struct OCODOOAGOGH<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public readonly IEnumerable<TData> EMDPAFGGEJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public readonly bool AJAMJHCJEFP;

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x3F84860", Offset = "0x3F83C60", VA = "0x183F84860")]
	public OCODOOAGOGH(IEnumerable<TData> EMDPAFGGEJP, bool AJAMJHCJEFP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public struct LKGGAIEKCJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public readonly float GPJPLAKFHNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public readonly bool HPNGMLMEIHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public readonly Vector3 DCBBILBIMGN;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x603C990", Offset = "0x603BD90", VA = "0x18603C990")]
	public LKGGAIEKCJJ(float GPJPLAKFHNN, bool HPNGMLMEIHA, Vector3 DCBBILBIMGN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct AHKAHOFOJIG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public readonly float GLJGILHBCKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public readonly Vector3 DCBBILBIMGN;

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x45069F0", Offset = "0x4505DF0", VA = "0x1845069F0")]
	public AHKAHOFOJIG(float GLJGILHBCKJ, Vector3 DCBBILBIMGN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public static class NBLEJFFFICA
{
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	private struct IKAFCJIGHFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public bool CAKFEMINNDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public DFNLNAANFCD OPBPFDLHMBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public DFNLNAANFCD OEMGLLOCHJD;
	}

	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private static IKAFCJIGHFJ MKLIPFECMEN;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static CancellationToken GPJHEAJLCIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x603CD70", Offset = "0x603C170", VA = "0x18603CD70")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	internal static DFNLNAANFCD OPBPFDLHMBN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x603CDE0", Offset = "0x603C1E0", VA = "0x18603CDE0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x603CE80", Offset = "0x603C280", VA = "0x18603CE80")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x603CEF0", Offset = "0x603C2F0", VA = "0x18603CEF0")]
	[ABIGJEDBLLA(DFKMKBBAPPA.Room, BMBIBJGPNHE.None)]
	private static void NHAHOPJBKBB(DFNLNAANFCD EBCMHIIAEJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x603CC20", Offset = "0x603C020", VA = "0x18603CC20")]
	public static void AIKIIHKLAJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x603CD90", Offset = "0x603C190", VA = "0x18603CD90")]
	private static DFNLNAANFCD CLBEPMGIGCH(DFNLNAANFCD OLCELFOCNFE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public static class LJJLLBOLMJG
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public enum KLAKHLLNFMI
	{
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		ICreationContextObject,
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		Guid
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x26B2C30", Offset = "0x26B2030", VA = "0x1826B2C30")]
	public static void MAFFLFFEFLK<T>(T JDMDDMDPEKF, KLAKHLLNFMI KHENBEDBKDI) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x26B2D70", Offset = "0x26B2170", VA = "0x1826B2D70")]
	public static void MAFFLFFEFLK<T>(T JDMDDMDPEKF) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x26B2DD0", Offset = "0x26B21D0", VA = "0x1826B2DD0")]
	public static void NMOIEMNKLJG<T>(T JDMDDMDPEKF) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x26B2B90", Offset = "0x26B1F90", VA = "0x1826B2B90")]
	public static T LBFOALNGCEO<T>(KLAKHLLNFMI KHENBEDBKDI) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x26B2A60", Offset = "0x26B1E60", VA = "0x1826B2A60")]
	public static bool KBIKFGCAMJG<T>(KLAKHLLNFMI KHENBEDBKDI, T OCIFHLKMFJA, [Out] T JAEDNDEIOAL) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x26B2980", Offset = "0x26B1D80", VA = "0x1826B2980")]
	public static bool JPLANABBPPI<T>(KLAKHLLNFMI KHENBEDBKDI) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x26B2A20", Offset = "0x26B1E20", VA = "0x1826B2A20")]
	public static T LBFOALNGCEO<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x26B2A20", Offset = "0x26B1E20", VA = "0x1826B2A20")]
	public static bool JPLANABBPPI<T>() where T : class
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
internal static class JEHPNIOBMJM
{
	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x603C460", Offset = "0x603B860", VA = "0x18603C460")]
	public static void CJEICBAALJA(IEnumerable BPBJIKDNINF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x26621D0", Offset = "0x26615D0", VA = "0x1826621D0")]
	public static void CJEICBAALJA<T>(T[] CBCBEPHCJOP) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x26623B0", Offset = "0x26617B0", VA = "0x1826623B0")]
	public static void CJEICBAALJA<T>(T ADBOOOJIIPK) where T : notnull, Enum
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
