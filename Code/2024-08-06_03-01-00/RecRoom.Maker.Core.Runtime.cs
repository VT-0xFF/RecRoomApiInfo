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
		[Cpp2IlInjected.Address(RVA = "0x8878E0", Offset = "0x885EE0", VA = "0x1808878E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x69F19F0", Offset = "0x69EFFF0", VA = "0x1869F19F0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x888570", Offset = "0x886B70", VA = "0x180888570")]
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
		[Cpp2IlInjected.Address(RVA = "0x8885B0", Offset = "0x886BB0", VA = "0x1808885B0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface OEMMNEOPEBE<TData, TReturn>
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TReturn BMIOIOBAPBO(TData CDBNFNMIHPK);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface DMKIBBPIHBC<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ClearHoverTarget(KHFGKEKBPIH FMFEPNMLKFJ);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool SetHoverTarget(TData MNAGKONPJOO, Collider OELLJAAPGIM, KHFGKEKBPIH FMFEPNMLKFJ, [Optional] KFFDDLOMHMP? CPINKEOLOFJ);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool TryGetHoverTarget([Out] TData MNAGKONPJOO);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetHoverCollider([Out] Collider OELLJAAPGIM);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface NOCGDDEAMDK<TData> : HOMHALOCEGK, EFGBBJGHAKJ<TData>, IGICFKNAFNA<TData>, FCHICJKPGFH<TData>, MCLHCIOMGBG, EFENDFGPHGI<TData>, HKKBAKPGNBL, AOMEHDEPIDA
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface EFENDFGPHGI<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 PGBFIMCGBLE, Vector3 MJBOPHFMANN, float FJJNLOMPHKA, [Out] T CALFJAFAGHM, [Out] Vector3 MBOHEIBKPOP, [Out] Collider OELLJAAPGIM);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 PGBFIMCGBLE, Vector3 MJBOPHFMANN, float CNPLNMMJDFO, float FJJNLOMPHKA, T[] LJKKFKFOCMO, [Out] Vector3 KPEFFELPEIM, [Out] Collider FFKKGOGLPBH);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 PGBFIMCGBLE, float CNPLNMMJDFO, Vector3 DALFKONMIKC, T[] LJKKFKFOCMO);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetObjectFromColliderInCurrentScope(Collider FGPJCKMOIDG, [Out] T ACAOEPPDIED);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface HOMHALOCEGK
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Bounds OBPHDBAMIKK
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Transform KBOOOHKIFPM
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Bounds JADJDGABMNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Transform KHFCAONEEMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Vector3 COLEFJJJEGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool NCBDIEHAJGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void SetSelectionBoundsDirty(bool EGPFLMFDLDH = true, int MOMOEGPCLHO = 0);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ShouldHideSelectionBoundsPreview(bool PHDMKOIOFHC, object PNPIGCGKNPI);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface AOMEHDEPIDA
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	CLOBMDANPDK NJHGGNPGENG
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface EGABMIOIIMK
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool PIMPGPGEEAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool LLBMINLNNPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool LGGGANJAPJJ
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
	void TrySetPreviousCloneMapping(Dictionary<Guid, Guid> COKJPDGBHPL);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface FCHICJKPGFH<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool BPKJCDDLIKG
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int KCJOGHANCMD
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<TData> FIHGEKDJBCI
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData OKNDMMHNIOK);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData OKNDMMHNIOK);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface EFGBBJGHAKJ<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T CDBNFNMIHPK, [Optional] KFFDDLOMHMP? OFMPHBAACHD, bool NDLCFPGJDHO = true);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int FDDANCOAHOL, IEnumerable<T> FPGPPDPCMGG, bool NDLCFPGJDHO = true);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int FDDANCOAHOL, IEnumerable<T> FPGPPDPCMGG, KFFDDLOMHMP OFMPHBAACHD, bool NDLCFPGJDHO = true);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface HKKBAKPGNBL
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface MCLHCIOMGBG
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool NNOJKFBNCGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool AEBLGDDOMEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool KOPFGMEPICI
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool DLBPNMLBMDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class NBHIDGGBMPP<TReceiver> : CGJBAGDIKPH<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3B6E5F0", Offset = "0x3B6CBF0", VA = "0x183B6E5F0")]
	public NBHIDGGBMPP(TReceiver MPDCNJDLMJC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class DCADHFKMPOF<TReceiver, TFromTask> : CGJBAGDIKPH<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3B6E5F0", Offset = "0x3B6CBF0", VA = "0x183B6E5F0")]
	public DCADHFKMPOF(TReceiver MPDCNJDLMJC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public abstract class CGJBAGDIKPH<TReceiver, TFromExecute> where TReceiver : notnull where TFromExecute : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	protected TReceiver MPDCNJDLMJC;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x50B4A90", Offset = "0x50B3090", VA = "0x1850B4A90")]
	public CGJBAGDIKPH(TReceiver MPDCNJDLMJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute GKIHIBGHNMF();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public abstract class GIJONBNHKOK<TReceiver, TResult> : CGJBAGDIKPH<TReceiver, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3B6E5F0", Offset = "0x3B6CBF0", VA = "0x183B6E5F0")]
	public GIJONBNHKOK(TReceiver MPDCNJDLMJC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct FBADCMMNPBE<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public TGroup HAFCCDDOCML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public TData HIIELDFPMGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public IEnumerable<TData> PPKGGHHBBAL;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1EC98D0", Offset = "0x1EC7ED0", VA = "0x181EC98D0")]
	public FBADCMMNPBE(TGroup AHEBCHPIPMN, TData KNMIFEBINLM, IEnumerable<TData> HHJJPFOBBJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct GCLBAOIJNDH<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public TGroup HAFCCDDOCML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public IEnumerable<TData> PPKGGHHBBAL;

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0xB912D0", Offset = "0xB8F8D0", VA = "0x180B912D0")]
	public GCLBAOIJNDH(TGroup AHEBCHPIPMN, IEnumerable<TData> HHJJPFOBBJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct MOODLEKGFIL<TGroup> where TGroup : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public TGroup HAFCCDDOCML;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0xA150A0", Offset = "0xA136A0", VA = "0x180A150A0")]
	public MOODLEKGFIL(TGroup AHEBCHPIPMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct BDCOCBMLNMN<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public IEnumerable<TData> PPKGGHHBBAL;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0xA150A0", Offset = "0xA136A0", VA = "0x180A150A0")]
	public BDCOCBMLNMN(IEnumerable<TData> HHJJPFOBBJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface IBJEBEBPOJB<TGroup, TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CBKDNGAFKNE EANOPKEFHKG(FBADCMMNPBE<TGroup, TData> DJKBNBHCGJP);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CBKDNGAFKNE BIFFLOGMKAF(FBADCMMNPBE<TGroup, TData> DJKBNBHCGJP);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CBKDNGAFKNE OMBHMGKNEJP(GCLBAOIJNDH<TGroup, TData> DJKBNBHCGJP);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CBKDNGAFKNE CLOBIHFICNB(MOODLEKGFIL<TGroup> DJKBNBHCGJP);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface MCNJCOJGDGM<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CBKDNGAFKNE> EANOPKEFHKG(BDCOCBMLNMN<TData> DJKBNBHCGJP);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class DNBHIDPGHLM<TGroup, TData> : GIJONBNHKOK<IBJEBEBPOJB<TGroup, TData>, CBKDNGAFKNE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly GCLBAOIJNDH<TGroup, TData> DJKBNBHCGJP;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x587C710", Offset = "0x587AD10", VA = "0x18587C710")]
	public DNBHIDPGHLM(TGroup AHEBCHPIPMN, IEnumerable<TData> HHJJPFOBBJG, IBJEBEBPOJB<TGroup, TData> MPDCNJDLMJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x587C640", Offset = "0x587AC40", VA = "0x18587C640", Slot = "4")]
	public override CBKDNGAFKNE GKIHIBGHNMF()
	{
		return default(CBKDNGAFKNE);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class BHOIDOFNGHC<TGroup, TData> : GIJONBNHKOK<IBJEBEBPOJB<TGroup, TData>, CBKDNGAFKNE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly FBADCMMNPBE<TGroup, TData> DJKBNBHCGJP;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3D83930", Offset = "0x3D81F30", VA = "0x183D83930")]
	public BHOIDOFNGHC(TGroup AHEBCHPIPMN, TData DPFGCBLBNGA, IEnumerable<TData> HHJJPFOBBJG, IBJEBEBPOJB<TGroup, TData> MPDCNJDLMJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4F1CD30", Offset = "0x4F1B330", VA = "0x184F1CD30", Slot = "4")]
	public override CBKDNGAFKNE GKIHIBGHNMF()
	{
		return default(CBKDNGAFKNE);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class GCGJJNEKJFK<TGroup, TData> : GIJONBNHKOK<IBJEBEBPOJB<TGroup, TData>, CBKDNGAFKNE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly MOODLEKGFIL<TGroup> DJKBNBHCGJP;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3C83020", Offset = "0x3C81620", VA = "0x183C83020")]
	public GCGJJNEKJFK(TGroup AHEBCHPIPMN, IBJEBEBPOJB<TGroup, TData> MPDCNJDLMJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3CC1B40", Offset = "0x3CC0140", VA = "0x183CC1B40", Slot = "4")]
	public override CBKDNGAFKNE GKIHIBGHNMF()
	{
		return default(CBKDNGAFKNE);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class AMNJNDKHJAG<TGroup, TData> : GIJONBNHKOK<IBJEBEBPOJB<TGroup, TData>, CBKDNGAFKNE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly FBADCMMNPBE<TGroup, TData> DJKBNBHCGJP;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3D83930", Offset = "0x3D81F30", VA = "0x183D83930")]
	public AMNJNDKHJAG(TGroup AHEBCHPIPMN, TData KNMIFEBINLM, IEnumerable<TData> HHJJPFOBBJG, IBJEBEBPOJB<TGroup, TData> MPDCNJDLMJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3D83850", Offset = "0x3D81E50", VA = "0x183D83850", Slot = "4")]
	public override CBKDNGAFKNE GKIHIBGHNMF()
	{
		return default(CBKDNGAFKNE);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class AFAEKIOINMP<TData> : DCADHFKMPOF<MCNJCOJGDGM<TData>, CBKDNGAFKNE> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private struct BCGILLOIPEB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AsyncTaskMethodBuilder<CBKDNGAFKNE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public AFAEKIOINMP<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private TaskAwaiter<CBKDNGAFKNE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x4EDFB50", Offset = "0x4EDE150", VA = "0x184EDFB50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x4EDFDF0", Offset = "0x4EDE3F0", VA = "0x184EDFDF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private BDCOCBMLNMN<TData> DJKBNBHCGJP;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3C83020", Offset = "0x3C81620", VA = "0x183C83020")]
	public AFAEKIOINMP(IEnumerable<TData> GLLKBFCGHHN, MCNJCOJGDGM<TData> MPDCNJDLMJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3C82F20", Offset = "0x3C81520", VA = "0x183C82F20", Slot = "4")]
	[AsyncStateMachine(typeof(AFAEKIOINMP<>.BCGILLOIPEB))]
	public override Task<CBKDNGAFKNE> GKIHIBGHNMF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct NLAFLPIGODL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly LCOLDLLKLAH NBHMFMHOKPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly bool ICHKEEBDLBK;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x69F1880", Offset = "0x69EFE80", VA = "0x1869F1880")]
	public NLAFLPIGODL(LCOLDLLKLAH GIAENJJFOAG, bool OAINHDLPPAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface DBMKNNLDKLO<TSpawnType> where TSpawnType : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> GKIHIBGHNMF(NLAFLPIGODL LDEDKHNBBGP);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class FICBEBOOIHM<TSpawnType> : DCADHFKMPOF<DBMKNNLDKLO<TSpawnType>, TSpawnType> where TSpawnType : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private struct DCMONDGIJJB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public AsyncTaskMethodBuilder<TSpawnType> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public FICBEBOOIHM<TSpawnType> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskAwaiter<TSpawnType> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5861850", Offset = "0x585FE50", VA = "0x185861850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x4507D20", Offset = "0x4506320", VA = "0x184507D20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly NLAFLPIGODL LDEDKHNBBGP;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3B9B970", Offset = "0x3B99F70", VA = "0x183B9B970")]
	public FICBEBOOIHM(LCOLDLLKLAH GIAENJJFOAG, bool OAINHDLPPAE, DBMKNNLDKLO<TSpawnType> MPDCNJDLMJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3B9B860", Offset = "0x3B99E60", VA = "0x183B9B860", Slot = "4")]
	[AsyncStateMachine(typeof(FICBEBOOIHM<>.DCMONDGIJJB))]
	public override Task<TSpawnType> GKIHIBGHNMF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public readonly struct LCOLDLLKLAH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly bool HOBOBNKHFMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly Vector3 OALBAJHBHJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly Vector3 MCOMLLJHBBI;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x69F0FE0", Offset = "0x69EF5E0", VA = "0x1869F0FE0")]
	public LCOLDLLKLAH(Transform HKMGEJNDHDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x69F10D0", Offset = "0x69EF6D0", VA = "0x1869F10D0")]
	public LCOLDLLKLAH(Vector3 FKPHICIEEGL, Vector3 LPBGBJBIAOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x69F0FB0", Offset = "0x69EF5B0", VA = "0x1869F0FB0")]
	public static LCOLDLLKLAH IONHEKLPACN()
	{
		return default(LCOLDLLKLAH);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x69F1050", Offset = "0x69EF650", VA = "0x1869F1050")]
	private LCOLDLLKLAH(bool LELELDNEMJL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct IPBBALMIHAG<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public TNode DKGCBIGKBNC;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3E70980", Offset = "0x3E6EF80", VA = "0x183E70980")]
	public IPBBALMIHAG(TNode DKGCBIGKBNC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct BGAIFELBPNL<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public TNode PEGIPLEENCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public DFFBMFFJNFE GBFIPGLNOPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly bool ICHKEEBDLBK;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x4F0CB00", Offset = "0x4F0B100", VA = "0x184F0CB00")]
	public BGAIFELBPNL(TNode PEGIPLEENCO, DFFBMFFJNFE GBFIPGLNOPC, bool OAINHDLPPAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface FEMNFMLJMKG<TNode>
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CEJEFIOLFLG([In] IPBBALMIHAG<TNode> HCFDHHKPKAA);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DHEHEHLNDFI([In] BGAIFELBPNL<TNode> DLLJIEHEGHI);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool EFEEMOLJGCK();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class MEJDKDCLCOC<TNode> : NBHIDGGBMPP<FEMNFMLJMKG<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3B6E5F0", Offset = "0x3B6CBF0", VA = "0x183B6E5F0")]
	public MEJDKDCLCOC(FEMNFMLJMKG<TNode> MPDCNJDLMJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x44E61F0", Offset = "0x44E47F0", VA = "0x1844E61F0", Slot = "4")]
	public override bool GKIHIBGHNMF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class ODCBIHFJIPF<TNode> : NBHIDGGBMPP<FEMNFMLJMKG<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly BGAIFELBPNL<TNode> DLLJIEHEGHI;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x46D6190", Offset = "0x46D4790", VA = "0x1846D6190")]
	public ODCBIHFJIPF(TNode PEGIPLEENCO, DFFBMFFJNFE GBFIPGLNOPC, FEMNFMLJMKG<TNode> MPDCNJDLMJC, bool OAINHDLPPAE = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3E409C0", Offset = "0x3E3EFC0", VA = "0x183E409C0", Slot = "4")]
	public override bool GKIHIBGHNMF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class JBBANJEHFBL<TNode> : NBHIDGGBMPP<FEMNFMLJMKG<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly IPBBALMIHAG<TNode> HCFDHHKPKAA;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x4003670", Offset = "0x4001C70", VA = "0x184003670")]
	public JBBANJEHFBL(TNode OIFMANPBJIE, FEMNFMLJMKG<TNode> MPDCNJDLMJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3C93B10", Offset = "0x3C92110", VA = "0x183C93B10", Slot = "4")]
	public override bool GKIHIBGHNMF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct NHMAIKBDECH<TSpawnInfo> where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public TSpawnInfo CLBAFLDAIBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public Vector3 LPBGBJBIAOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Quaternion CNNBBFFJNHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public float JAGNHLKKADJ;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x457C480", Offset = "0x457AA80", VA = "0x18457C480")]
	public NHMAIKBDECH(TSpawnInfo CLBAFLDAIBD, Vector3 LPBGBJBIAOJ, Quaternion CNNBBFFJNHM, float JAGNHLKKADJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface LDBALCFJHNL<TSpawnType, TSpawnInfo>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> IHOMBLPIOHO([In] NHMAIKBDECH<TSpawnInfo> JLAABMOPJKD, CancellationToken NNGMAHIDECE);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class HLPJICANJGD<TSpawnType, TSpawnInfo> : DCADHFKMPOF<LDBALCFJHNL<TSpawnType, TSpawnInfo>, TSpawnType> where TSpawnType : notnull where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly NHMAIKBDECH<TSpawnInfo> HCHKMMKNKKB;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3D4DD40", Offset = "0x3D4C340", VA = "0x183D4DD40")]
	public HLPJICANJGD(TSpawnInfo MHCLNPGILCD, Vector3 LPBGBJBIAOJ, Quaternion CNNBBFFJNHM, float JAGNHLKKADJ, LDBALCFJHNL<TSpawnType, TSpawnInfo> MPDCNJDLMJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3D32350", Offset = "0x3D30950", VA = "0x183D32350", Slot = "4")]
	public override Task<TSpawnType> GKIHIBGHNMF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct LDNOJNOFAGB<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly IEnumerable<TData> PPKGGHHBBAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly bool ICHKEEBDLBK;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x429D8A0", Offset = "0x429BEA0", VA = "0x18429D8A0")]
	public LDNOJNOFAGB(IEnumerable<TData> HHJJPFOBBJG, bool OAINHDLPPAE = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface LFAEFFKDCBE<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CBKDNGAFKNE> ANLGCIAIAGI([In] LDNOJNOFAGB<TData> EMNDCAAMLNC, CancellationToken NNGMAHIDECE);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class HCBIADPMMCJ<TData> : DCADHFKMPOF<LFAEFFKDCBE<TData>, CBKDNGAFKNE> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly LDNOJNOFAGB<TData> FDKMCMOKBPM;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3D32430", Offset = "0x3D30A30", VA = "0x183D32430")]
	public HCBIADPMMCJ(IEnumerable<TData> HHJJPFOBBJG, bool OAINHDLPPAE, LFAEFFKDCBE<TData> MPDCNJDLMJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3D32350", Offset = "0x3D30950", VA = "0x183D32350", Slot = "4")]
	public override Task<CBKDNGAFKNE> GKIHIBGHNMF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct HFLJDDHNHMA<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public readonly T MNAGKONPJOO;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x3D39D70", Offset = "0x3D38370", VA = "0x183D39D70")]
	public HFLJDDHNHMA(T GEBDMOIGHIO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface OJDCIGKIAPE<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CEJEFIOLFLG([In] HFLJDDHNHMA<T> COBLECECCLC);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DHEHEHLNDFI();
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface MBIMCBNGMLH<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GKIHIBGHNMF([In] CDJNHCHDFIC<T> AEPEJOJEHCM);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct CDJNHCHDFIC<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public readonly T MNAGKONPJOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public readonly bool ENHICEKEHAO;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x4FC2060", Offset = "0x4FC0660", VA = "0x184FC2060")]
	public CDJNHCHDFIC(T GEBDMOIGHIO, bool PKHLMMMEMMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class GBGLFJNNMNF<T> : NBHIDGGBMPP<OJDCIGKIAPE<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x3B6E5F0", Offset = "0x3B6CBF0", VA = "0x183B6E5F0")]
	public GBGLFJNNMNF(OJDCIGKIAPE<T> MPDCNJDLMJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x3CB31B0", Offset = "0x3CB17B0", VA = "0x183CB31B0", Slot = "4")]
	public override bool GKIHIBGHNMF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class AIANHKNLJGH<T> : NBHIDGGBMPP<OJDCIGKIAPE<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly HFLJDDHNHMA<T> COBLECECCLC;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x3C93BD0", Offset = "0x3C921D0", VA = "0x183C93BD0")]
	public AIANHKNLJGH(T MNAGKONPJOO, OJDCIGKIAPE<T> MPDCNJDLMJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x3C93B10", Offset = "0x3C92110", VA = "0x183C93B10", Slot = "4")]
	public override bool GKIHIBGHNMF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class KFNGOJDEDDA<T> : NBHIDGGBMPP<MBIMCBNGMLH<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly CDJNHCHDFIC<T> AEPEJOJEHCM;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x41DB500", Offset = "0x41D9B00", VA = "0x1841DB500")]
	public KFNGOJDEDDA(T MNAGKONPJOO, bool PKHLMMMEMMD, MBIMCBNGMLH<T> MPDCNJDLMJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x3C93B10", Offset = "0x3C92110", VA = "0x183C93B10", Slot = "4")]
	public override bool GKIHIBGHNMF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct GLHDFDHEAKL<TData> where TData : notnull, EHGGGLKGPHC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public IEnumerable<TData> PPKGGHHBBAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public bool LGDMPGDCCLO;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x3CDF5B0", Offset = "0x3CDDBB0", VA = "0x183CDF5B0")]
	public GLHDFDHEAKL(IEnumerable<TData> GLDOKGPCPOH, bool MBGDDMGFFLC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct GKDFCMFNGMB<TData> where TData : notnull, EHGGGLKGPHC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public List<TData> PPKGGHHBBAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public List<bool> NECMKPEJCOK;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x3CDB970", Offset = "0x3CD9F70", VA = "0x183CDB970")]
	public GKDFCMFNGMB(List<TData> GLDOKGPCPOH, List<bool> MCBIIOJINIP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface EHGGGLKGPHC
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool GCKFDGAGLAE
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
public interface IBCPMMKIHNP<TData> where TData : EHGGGLKGPHC
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GKIHIBGHNMF([In] GLHDFDHEAKL<TData> GIFGEMBJMBP);

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GKIHIBGHNMF([In] GKDFCMFNGMB<TData> GIFGEMBJMBP);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface OKDBLHLEDPK<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OPAJDBNLAPG(T MNAGKONPJOO);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class DMIOMJAIHIJ<TData> : NBHIDGGBMPP<IBCPMMKIHNP<TData>> where TData : notnull, EHGGGLKGPHC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly GLHDFDHEAKL<TData> GIFGEMBJMBP;

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x587C290", Offset = "0x587A890", VA = "0x18587C290")]
	public DMIOMJAIHIJ(List<TData> HHJJPFOBBJG, bool LGDMPGDCCLO, IBCPMMKIHNP<TData> MPDCNJDLMJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x3C93B10", Offset = "0x3C92110", VA = "0x183C93B10", Slot = "4")]
	public override bool GKIHIBGHNMF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class FEKICEOIOKC<TData> : NBHIDGGBMPP<IBCPMMKIHNP<TData>> where TData : notnull, EHGGGLKGPHC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly GKDFCMFNGMB<TData> GIFGEMBJMBP;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x3B894A0", Offset = "0x3B87AA0", VA = "0x183B894A0")]
	public FEKICEOIOKC(List<TData> HHJJPFOBBJG, List<bool> NECMKPEJCOK, IBCPMMKIHNP<TData> MPDCNJDLMJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x3B893E0", Offset = "0x3B879E0", VA = "0x183B893E0", Slot = "4")]
	public override bool GKIHIBGHNMF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface OEFHOEOJJMN<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CBKDNGAFKNE> GKIHIBGHNMF(HJDEAJPEGNM<TData> OONBGPJFCLH);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public class IEOCJPGOIHN<TData> : DCADHFKMPOF<OEFHOEOJJMN<TData>, CBKDNGAFKNE> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct CNDMDNCIJHB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public AsyncTaskMethodBuilder<CBKDNGAFKNE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public IEOCJPGOIHN<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter<CBKDNGAFKNE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x51BAA10", Offset = "0x51B9010", VA = "0x1851BAA10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x51BAD00", Offset = "0x51B9300", VA = "0x1851BAD00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly HJDEAJPEGNM<TData> DAEDDNLGKCO;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x3E10090", Offset = "0x3E0E690", VA = "0x183E10090")]
	public IEOCJPGOIHN(TData LGKFEAAJLLI, IReadOnlyList<TData> FHOHLPNEAFG, bool OAINHDLPPAE, OEFHOEOJJMN<TData> MPDCNJDLMJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x3E0FF90", Offset = "0x3E0E590", VA = "0x183E0FF90", Slot = "4")]
	[AsyncStateMachine(typeof(IEOCJPGOIHN<>.CNDMDNCIJHB))]
	public override Task<CBKDNGAFKNE> GKIHIBGHNMF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public struct HJDEAJPEGNM<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public TData NDNAFIDGFBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public IReadOnlyList<TData> IAIMCIEJJFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public bool ICHKEEBDLBK;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x3D49B00", Offset = "0x3D48100", VA = "0x183D49B00")]
	public HJDEAJPEGNM(TData LGKFEAAJLLI, IReadOnlyList<TData> FHOHLPNEAFG, bool OAINHDLPPAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface BAACHDLOKGM<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GKIHIBGHNMF([In] PJKPJOJFNDM<TData> KPPACONBGDD);
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface HIMHMHIDAID<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GKIHIBGHNMF([In] NJDAKFGMFCD<TData> KPPACONBGDD);
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface PFEDIJMLOEP<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MPIPKFHOMFG([In] HONFEKGEOMO<TData> KPPACONBGDD);

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DHEHEHLNDFI();
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class PPPCEIJEFJO<TData> : NBHIDGGBMPP<BAACHDLOKGM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly PJKPJOJFNDM<TData> KPPACONBGDD;

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x483E3C0", Offset = "0x483C9C0", VA = "0x18483E3C0")]
	public PPPCEIJEFJO(IEnumerable<TData> HHJJPFOBBJG, PLGBGKAMJFI KOEHPNBNNJJ, EGJFKDKPBEB JFOAGNGANHG, float KCHIPHPGPKO, bool OAINHDLPPAE, BAACHDLOKGM<TData> MPDCNJDLMJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x3C93B10", Offset = "0x3C92110", VA = "0x183C93B10", Slot = "4")]
	public override bool GKIHIBGHNMF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class DIFMKBBNMNI<TData> : NBHIDGGBMPP<HIMHMHIDAID<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly NJDAKFGMFCD<TData> KPPACONBGDD;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x586BD50", Offset = "0x586A350", VA = "0x18586BD50")]
	public DIFMKBBNMNI(TData[] HHJJPFOBBJG, PLGBGKAMJFI[] KOEHPNBNNJJ, EGJFKDKPBEB[] JFOAGNGANHG, float[] KCHIPHPGPKO, HIMHMHIDAID<TData> MPDCNJDLMJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x42E0B20", Offset = "0x42DF120", VA = "0x1842E0B20", Slot = "4")]
	public override bool GKIHIBGHNMF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class DICEDONEDDF<TData> : NBHIDGGBMPP<PFEDIJMLOEP<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3B6E5F0", Offset = "0x3B6CBF0", VA = "0x183B6E5F0")]
	public DICEDONEDDF(PFEDIJMLOEP<TData> MPDCNJDLMJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x58697D0", Offset = "0x5867DD0", VA = "0x1858697D0", Slot = "4")]
	public override bool GKIHIBGHNMF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class LLGLAJPEKHF<TData> : NBHIDGGBMPP<PFEDIJMLOEP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly HONFEKGEOMO<TData> KPPACONBGDD;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x42E0BE0", Offset = "0x42DF1E0", VA = "0x1842E0BE0")]
	public LLGLAJPEKHF(IEnumerable<TData> HHJJPFOBBJG, PLGBGKAMJFI KOEHPNBNNJJ, EGJFKDKPBEB JFOAGNGANHG, float KCHIPHPGPKO, PFEDIJMLOEP<TData> MPDCNJDLMJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x42E0B20", Offset = "0x42DF120", VA = "0x1842E0B20", Slot = "4")]
	public override bool GKIHIBGHNMF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public struct PJKPJOJFNDM<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public IEnumerable<TData> PPKGGHHBBAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public PLGBGKAMJFI JPJGHOKCIDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public EGJFKDKPBEB CNCBBBNCHFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public float KCHIPHPGPKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public bool OAINHDLPPAE;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x481DE30", Offset = "0x481C430", VA = "0x18481DE30")]
	public PJKPJOJFNDM(IEnumerable<TData> HHJJPFOBBJG, PLGBGKAMJFI KOEHPNBNNJJ, EGJFKDKPBEB JFOAGNGANHG, float KCHIPHPGPKO, bool OAINHDLPPAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct NJDAKFGMFCD<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public TData[] PPKGGHHBBAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public PLGBGKAMJFI[] JPJGHOKCIDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public EGJFKDKPBEB[] CNCBBBNCHFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public float[] KCHIPHPGPKO;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x457DF10", Offset = "0x457C510", VA = "0x18457DF10")]
	public NJDAKFGMFCD(TData[] HHJJPFOBBJG, PLGBGKAMJFI[] KOEHPNBNNJJ, EGJFKDKPBEB[] JFOAGNGANHG, float[] KCHIPHPGPKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public struct HONFEKGEOMO<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public IEnumerable<TData> PPKGGHHBBAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public PLGBGKAMJFI JPJGHOKCIDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public EGJFKDKPBEB CNCBBBNCHFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public float KCHIPHPGPKO;

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3D517A0", Offset = "0x3D4FDA0", VA = "0x183D517A0")]
	public HONFEKGEOMO(IEnumerable<TData> HHJJPFOBBJG, PLGBGKAMJFI KOEHPNBNNJJ, EGJFKDKPBEB JFOAGNGANHG, float KCHIPHPGPKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public interface IGICFKNAFNA<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OMBHMGKNEJP([In] FDOBHFHNDJI<TData> EMNDCAAMLNC);

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CLOBIHFICNB([In] FDOBHFHNDJI<TData> EMNDCAAMLNC);

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OEMFHCAONME([In] bool CDEKLKLGHAE);

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MIFJJMLNMJA([In] FDOBHFHNDJI<TData> EMNDCAAMLNC);

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EMJHCCKHFFH();

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool PDBPICKBLNF([In] TData GNFAGGNNKLJ);
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class GONIKDPBMIP<TData> : NBHIDGGBMPP<IGICFKNAFNA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly FDOBHFHNDJI<TData> EMNDCAAMLNC;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x3CF51C0", Offset = "0x3CF37C0", VA = "0x183CF51C0")]
	public GONIKDPBMIP(List<TData> HBAHAFEIFCB, IGICFKNAFNA<TData> MPDCNJDLMJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3C93B10", Offset = "0x3C92110", VA = "0x183C93B10", Slot = "4")]
	public override bool GKIHIBGHNMF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class MCACFFBAEPO<TData> : NBHIDGGBMPP<IGICFKNAFNA<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3B6E5F0", Offset = "0x3B6CBF0", VA = "0x183B6E5F0")]
	public MCACFFBAEPO(IGICFKNAFNA<TData> MPDCNJDLMJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x44E3B90", Offset = "0x44E2190", VA = "0x1844E3B90", Slot = "4")]
	public override bool GKIHIBGHNMF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class KFLBLALGNJL<TData> : NBHIDGGBMPP<IGICFKNAFNA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly bool OAINHDLPPAE;

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x41D7650", Offset = "0x41D5C50", VA = "0x1841D7650")]
	public KFLBLALGNJL(bool OAINHDLPPAE, IGICFKNAFNA<TData> MPDCNJDLMJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x41D75F0", Offset = "0x41D5BF0", VA = "0x1841D75F0", Slot = "4")]
	public override bool GKIHIBGHNMF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class GCKIIPJBCNB<TData> : NBHIDGGBMPP<IGICFKNAFNA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly FDOBHFHNDJI<TData> EMNDCAAMLNC;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3CC1C10", Offset = "0x3CC0210", VA = "0x183CC1C10")]
	public GCKIIPJBCNB(List<TData> HBAHAFEIFCB, bool OAINHDLPPAE, IGICFKNAFNA<TData> MPDCNJDLMJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3B893E0", Offset = "0x3B879E0", VA = "0x183B893E0", Slot = "4")]
	public override bool GKIHIBGHNMF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class FHCIHAGAEHL<TData> : NBHIDGGBMPP<IGICFKNAFNA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly TData GNFAGGNNKLJ;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3B8BA60", Offset = "0x3B8A060", VA = "0x183B8BA60")]
	public FHCIHAGAEHL(TData GNFAGGNNKLJ, IGICFKNAFNA<TData> MPDCNJDLMJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3B8B990", Offset = "0x3B89F90", VA = "0x183B8B990", Slot = "4")]
	public override bool GKIHIBGHNMF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class ODDKEKPJKMP<TData> : NBHIDGGBMPP<IGICFKNAFNA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly FDOBHFHNDJI<TData> EMNDCAAMLNC;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x46D6320", Offset = "0x46D4920", VA = "0x1846D6320")]
	public ODDKEKPJKMP(IEnumerable<TData> HBAHAFEIFCB, IGICFKNAFNA<TData> MPDCNJDLMJC, bool OAINHDLPPAE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x46D6250", Offset = "0x46D4850", VA = "0x1846D6250", Slot = "4")]
	public override bool GKIHIBGHNMF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public struct FDOBHFHNDJI<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public IEnumerable<TData> PPKGGHHBBAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public bool OAINHDLPPAE;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x3B88760", Offset = "0x3B86D60", VA = "0x183B88760")]
	public FDOBHFHNDJI(IEnumerable<TData> GLDOKGPCPOH, bool NGBOFPIPBIP = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public interface HJICJDJEKHD
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CBKDNGAFKNE> GKIHIBGHNMF(KBPIOJHMIOO HPJOIBFMLAM);
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class NNMNMMHJFEH : DCADHFKMPOF<HJICJDJEKHD, CBKDNGAFKNE>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private struct MLDHOAALEEK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public AsyncTaskMethodBuilder<CBKDNGAFKNE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public NNMNMMHJFEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private TaskAwaiter<CBKDNGAFKNE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x69F15A0", Offset = "0x69EFBA0", VA = "0x1869F15A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x69F1810", Offset = "0x69EFE10", VA = "0x1869F1810", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly KBPIOJHMIOO GJKNDJCIIHD;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x69F1990", Offset = "0x69EFF90", VA = "0x1869F1990")]
	public NNMNMMHJFEH(bool OAINHDLPPAE, HJICJDJEKHD MPDCNJDLMJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x69F18A0", Offset = "0x69EFEA0", VA = "0x1869F18A0", Slot = "4")]
	[AsyncStateMachine(typeof(MLDHOAALEEK))]
	public override Task<CBKDNGAFKNE> GKIHIBGHNMF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct KBPIOJHMIOO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public bool ICHKEEBDLBK;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x21A1BB0", Offset = "0x21A01B0", VA = "0x1821A1BB0")]
	public KBPIOJHMIOO(bool OAINHDLPPAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public readonly struct KHKIEOJACOB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly bool GMLFBLBKLKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly bool MAPNLENLHJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public readonly bool JAGNHLKKADJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public readonly bool OAINHDLPPAE;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4DC8620", Offset = "0x4DC6C20", VA = "0x184DC8620")]
	public KHKIEOJACOB(bool GMLFBLBKLKE, bool MAPNLENLHJL, bool JAGNHLKKADJ, bool OAINHDLPPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x69F0FA0", Offset = "0x69EF5A0", VA = "0x1869F0FA0")]
	public KHKIEOJACOB(bool MAPNLENLHJL, bool OAINHDLPPAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface FNMLFLDGMFJ
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PFMPCADCAMM(KHKIEOJACOB FGBCMPJADLG);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FCAOCPEKDPM(KHKIEOJACOB FGBCMPJADLG);
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class IJPDMHFLKPG : NBHIDGGBMPP<FNMLFLDGMFJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly KHKIEOJACOB FGBCMPJADLG;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x69F0940", Offset = "0x69EEF40", VA = "0x1869F0940")]
	public IJPDMHFLKPG(bool OGKACMCCFIL, bool MAPNLENLHJL, bool JAGNHLKKADJ, bool OAINHDLPPAE, FNMLFLDGMFJ MPDCNJDLMJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x69F08F0", Offset = "0x69EEEF0", VA = "0x1869F08F0", Slot = "4")]
	public override bool GKIHIBGHNMF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class HEANOEEMGHM : NBHIDGGBMPP<FNMLFLDGMFJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly KHKIEOJACOB FGBCMPJADLG;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x69F0830", Offset = "0x69EEE30", VA = "0x1869F0830")]
	public HEANOEEMGHM(bool MAPNLENLHJL, bool OAINHDLPPAE, FNMLFLDGMFJ MPDCNJDLMJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x69F07E0", Offset = "0x69EEDE0", VA = "0x1869F07E0", Slot = "4")]
	public override bool GKIHIBGHNMF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public interface FNFMFFLMNJF
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GKIHIBGHNMF([In] LFPMIMBDIEM ILOEDHFOLDE);
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class CMEOHFPPCNL : NBHIDGGBMPP<FNFMFFLMNJF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly LFPMIMBDIEM ILOEDHFOLDE;

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x69F04D0", Offset = "0x69EEAD0", VA = "0x1869F04D0")]
	public CMEOHFPPCNL(Guid[] FJCMFCFCLFD, Vector3[] EPEMDDHEPAK, Quaternion[] KCKKEGFBJNG, float[] KKFLOMBFPOC, Dictionary<Guid, Vector3> HKPIKHJGJEH, FNFMFFLMNJF MPDCNJDLMJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x69F0420", Offset = "0x69EEA20", VA = "0x1869F0420", Slot = "4")]
	public override bool GKIHIBGHNMF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public interface ICNDEEMPCFO<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CEJEFIOLFLG([In] MKBLAFIADPF<TData> HCFDHHKPKAA);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MPIPKFHOMFG([In] AAAFKFFGOIL LHOCHLCABMG);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MPIPKFHOMFG([In] MGDKMFOEKIL LHOCHLCABMG);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DHEHEHLNDFI();
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class LPGFGOIEFIB<TData> : NBHIDGGBMPP<ICNDEEMPCFO<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x3B6E5F0", Offset = "0x3B6CBF0", VA = "0x183B6E5F0")]
	public LPGFGOIEFIB(ICNDEEMPCFO<TData> MPDCNJDLMJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x4309260", Offset = "0x4307860", VA = "0x184309260", Slot = "4")]
	public override bool GKIHIBGHNMF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class IFLHJIOOLFB<TData> : NBHIDGGBMPP<ICNDEEMPCFO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly AAAFKFFGOIL BJGEADAMCLP;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3E17AA0", Offset = "0x3E160A0", VA = "0x183E17AA0")]
	public IFLHJIOOLFB(Vector3 HBAEOAOHFOM, bool BCEEBEBIKFO, ICNDEEMPCFO<TData> MPDCNJDLMJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x37EADD0", Offset = "0x37E93D0", VA = "0x1837EADD0", Slot = "4")]
	public override bool GKIHIBGHNMF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class HIKFNMAADAC<TData> : NBHIDGGBMPP<ICNDEEMPCFO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly MGDKMFOEKIL BJGEADAMCLP;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x3D491B0", Offset = "0x3D477B0", VA = "0x183D491B0")]
	public HIKFNMAADAC(Guid LDGCIOLLING, int EBDMAJMOJLN, Vector3 LPBGBJBIAOJ, Quaternion CNNBBFFJNHM, float PIBBFIKNNCO, bool BCEEBEBIKFO, ICNDEEMPCFO<TData> MPDCNJDLMJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x3D49150", Offset = "0x3D47750", VA = "0x183D49150", Slot = "4")]
	public override bool GKIHIBGHNMF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class OKAGMEIFPLD<TData> : NBHIDGGBMPP<ICNDEEMPCFO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly MKBLAFIADPF<TData> BJGEADAMCLP;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x46E9460", Offset = "0x46E7A60", VA = "0x1846E9460")]
	public OKAGMEIFPLD(TData MNAGKONPJOO, bool OAINHDLPPAE, ICNDEEMPCFO<TData> MPDCNJDLMJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x3C93B10", Offset = "0x3C92110", VA = "0x183C93B10", Slot = "4")]
	public override bool GKIHIBGHNMF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public struct AAAFKFFGOIL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly Vector3 HBAEOAOHFOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public readonly bool BCEEBEBIKFO;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x69F0400", Offset = "0x69EEA00", VA = "0x1869F0400")]
	public AAAFKFFGOIL(Vector3 HBAEOAOHFOM, bool BCEEBEBIKFO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public struct MGDKMFOEKIL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public readonly Guid LDGCIOLLING;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public readonly int EBDMAJMOJLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public readonly Vector3 LPBGBJBIAOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public readonly Quaternion CNNBBFFJNHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public readonly float PIBBFIKNNCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public readonly bool BCEEBEBIKFO;

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x69F1560", Offset = "0x69EFB60", VA = "0x1869F1560")]
	public MGDKMFOEKIL(Guid LDGCIOLLING, int EBDMAJMOJLN, Vector3 LPBGBJBIAOJ, Quaternion CNNBBFFJNHM, float PIBBFIKNNCO, bool BCEEBEBIKFO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public struct MKBLAFIADPF<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public readonly TData MNAGKONPJOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public readonly bool OAINHDLPPAE;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x4504FF0", Offset = "0x45035F0", VA = "0x184504FF0")]
	public MKBLAFIADPF(TData MNAGKONPJOO, bool OAINHDLPPAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public interface AOHGOCENEAJ<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GKIHIBGHNMF([In] IHCFMAJENGD<TData> OKMECLDHLOG);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GKIHIBGHNMF([In] BHHBMMKMOME<TData> OKMECLDHLOG);
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public interface BAGOCLFJLGL<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CEJEFIOLFLG([In] IOLMLKBNGGI<TData> GDGEJODCDFM);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MPIPKFHOMFG([In] EAIFDPKOCJK LHOCHLCABMG);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DHEHEHLNDFI();
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class MHBCBHDOLNA<TData> : NBHIDGGBMPP<AOHGOCENEAJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly IHCFMAJENGD<TData> OKMECLDHLOG;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x44F7730", Offset = "0x44F5D30", VA = "0x1844F7730")]
	public MHBCBHDOLNA(IEnumerable<TData> HHJJPFOBBJG, Vector3 KOKPFBBMKOH, bool OAINHDLPPAE, AOHGOCENEAJ<TData> MPDCNJDLMJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x3C93B10", Offset = "0x3C92110", VA = "0x183C93B10", Slot = "4")]
	public override bool GKIHIBGHNMF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class OANFOCAAOFL<TData> : NBHIDGGBMPP<BAGOCLFJLGL<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x3B6E5F0", Offset = "0x3B6CBF0", VA = "0x183B6E5F0")]
	public OANFOCAAOFL(BAGOCLFJLGL<TData> MPDCNJDLMJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x44E61F0", Offset = "0x44E47F0", VA = "0x1844E61F0", Slot = "4")]
	public override bool GKIHIBGHNMF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class DMOODBFGAJK<TData> : NBHIDGGBMPP<BAGOCLFJLGL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly IOLMLKBNGGI<TData> OKMECLDHLOG;

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x587C590", Offset = "0x587AB90", VA = "0x18587C590")]
	public DMOODBFGAJK(IEnumerable<TData> HHJJPFOBBJG, bool OAINHDLPPAE, BAGOCLFJLGL<TData> MPDCNJDLMJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x3C93B10", Offset = "0x3C92110", VA = "0x183C93B10", Slot = "4")]
	public override bool GKIHIBGHNMF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class BCPHNHIINAB<TData> : NBHIDGGBMPP<AOHGOCENEAJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly BHHBMMKMOME<TData> OKMECLDHLOG;

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x4EDFE60", Offset = "0x4EDE460", VA = "0x184EDFE60")]
	public BCPHNHIINAB(IEnumerable<TData> HHJJPFOBBJG, Vector3 OMHHFJOMHDK, COICGOODDKN GFKNEAMCPEH, bool OAINHDLPPAE, AOHGOCENEAJ<TData> MPDCNJDLMJC, Space LMIOGLEIHOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3E409C0", Offset = "0x3E3EFC0", VA = "0x183E409C0", Slot = "4")]
	public override bool GKIHIBGHNMF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class EGHPOPLABOE<TData> : NBHIDGGBMPP<BAGOCLFJLGL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly EAIFDPKOCJK OKMECLDHLOG;

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x37EAE30", Offset = "0x37E9430", VA = "0x1837EAE30")]
	public EGHPOPLABOE(Vector3 KOKPFBBMKOH, BAGOCLFJLGL<TData> MPDCNJDLMJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x37EADD0", Offset = "0x37E93D0", VA = "0x1837EADD0", Slot = "4")]
	public override bool GKIHIBGHNMF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct IHCFMAJENGD<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public readonly IEnumerable<TData> HHJJPFOBBJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public readonly Vector3 KOKPFBBMKOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public readonly bool OAINHDLPPAE;

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x3E39620", Offset = "0x3E37C20", VA = "0x183E39620")]
	public IHCFMAJENGD(IEnumerable<TData> HHJJPFOBBJG, Vector3 KOKPFBBMKOH, bool OAINHDLPPAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct IOLMLKBNGGI<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public readonly IEnumerable<TData> HHJJPFOBBJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public readonly bool OAINHDLPPAE;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x3E702C0", Offset = "0x3E6E8C0", VA = "0x183E702C0")]
	public IOLMLKBNGGI(IEnumerable<TData> HHJJPFOBBJG, bool OAINHDLPPAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct BHHBMMKMOME<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public readonly IEnumerable<TData> HHJJPFOBBJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public readonly Vector3 OMHHFJOMHDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly COICGOODDKN GFKNEAMCPEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public readonly bool OAINHDLPPAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly Space LMIOGLEIHOC;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x4F12E70", Offset = "0x4F11470", VA = "0x184F12E70")]
	public BHHBMMKMOME(IEnumerable<TData> HHJJPFOBBJG, Vector3 OMHHFJOMHDK, COICGOODDKN GFKNEAMCPEH, bool OAINHDLPPAE, Space LMIOGLEIHOC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct EAIFDPKOCJK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public readonly Vector3 KOKPFBBMKOH;

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x21A1A00", Offset = "0x21A0000", VA = "0x1821A1A00")]
	public EAIFDPKOCJK(Vector3 KOKPFBBMKOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public enum COICGOODDKN
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
public interface MIJOBFDPFPE
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GKIHIBGHNMF([In] KJKONPONEGP OKDBGMLCIPE);
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public class DLIHPMIMHPO : NBHIDGGBMPP<MIJOBFDPFPE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly KJKONPONEGP OKDBGMLCIPE;

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x69F0760", Offset = "0x69EED60", VA = "0x1869F0760")]
	public DLIHPMIMHPO(bool OAINHDLPPAE, MIJOBFDPFPE MPDCNJDLMJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x69F06B0", Offset = "0x69EECB0", VA = "0x1869F06B0", Slot = "4")]
	public override bool GKIHIBGHNMF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public readonly struct KJKONPONEGP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public readonly bool OAINHDLPPAE;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x21A1BB0", Offset = "0x21A01B0", VA = "0x1821A1BB0")]
	public KJKONPONEGP(bool OAINHDLPPAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public interface BEDEOKGKLIC<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GKIHIBGHNMF([In] MMOECPHCEKO<TData> AGGJEFLBANL);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GKIHIBGHNMF([In] JMFIPHFLNBI<TData> AGGJEFLBANL);
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public interface MHDAMKKCLAA<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CEJEFIOLFLG([In] DCPCOIOLPKK<TData> HCFDHHKPKAA);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MPIPKFHOMFG([In] DBNJINNFFPP LHOCHLCABMG);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DHEHEHLNDFI();
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class GNMHMNPDEDC<TData> : NBHIDGGBMPP<BEDEOKGKLIC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly MMOECPHCEKO<TData> AGGJEFLBANL;

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x3CF1650", Offset = "0x3CEFC50", VA = "0x183CF1650")]
	public GNMHMNPDEDC(IEnumerable<TData> HHJJPFOBBJG, Quaternion KOKPFBBMKOH, Vector3? JJHIHCJHPDO, bool KOGMAPCECCM, bool OAINHDLPPAE, BEDEOKGKLIC<TData> MPDCNJDLMJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x3C93B10", Offset = "0x3C92110", VA = "0x183C93B10", Slot = "4")]
	public override bool GKIHIBGHNMF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class DEIMNMFBHAL<TData> : NBHIDGGBMPP<MHDAMKKCLAA<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x3B6E5F0", Offset = "0x3B6CBF0", VA = "0x183B6E5F0")]
	public DEIMNMFBHAL(MHDAMKKCLAA<TData> MPDCNJDLMJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x44E61F0", Offset = "0x44E47F0", VA = "0x1844E61F0", Slot = "4")]
	public override bool GKIHIBGHNMF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class BGPAPBMPAHO<TData> : NBHIDGGBMPP<MHDAMKKCLAA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly DCPCOIOLPKK<TData> AGGJEFLBANL;

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x4F10C50", Offset = "0x4F0F250", VA = "0x184F10C50")]
	public BGPAPBMPAHO(IEnumerable<TData> HHJJPFOBBJG, bool OAINHDLPPAE, MHDAMKKCLAA<TData> MPDCNJDLMJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x3C93B10", Offset = "0x3C92110", VA = "0x183C93B10", Slot = "4")]
	public override bool GKIHIBGHNMF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class IIJJGNKPLOI<TData> : NBHIDGGBMPP<BEDEOKGKLIC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly JMFIPHFLNBI<TData> AGGJEFLBANL;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x3E40A90", Offset = "0x3E3F090", VA = "0x183E40A90")]
	public IIJJGNKPLOI(IEnumerable<TData> HHJJPFOBBJG, Quaternion KNKMDIONIIB, COICGOODDKN DDBAPPHANGK, Vector3? JJHIHCJHPDO, bool KOGMAPCECCM, bool OAINHDLPPAE, Space LMIOGLEIHOC, BEDEOKGKLIC<TData> MPDCNJDLMJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x3E409C0", Offset = "0x3E3EFC0", VA = "0x183E409C0", Slot = "4")]
	public override bool GKIHIBGHNMF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class PDFNCMJHICJ<TData> : NBHIDGGBMPP<MHDAMKKCLAA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly DBNJINNFFPP AGGJEFLBANL;

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x480C390", Offset = "0x480A990", VA = "0x18480C390")]
	public PDFNCMJHICJ(Quaternion KOKPFBBMKOH, Vector3? JJHIHCJHPDO, bool KOGMAPCECCM, MHDAMKKCLAA<TData> MPDCNJDLMJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x37EADD0", Offset = "0x37E93D0", VA = "0x1837EADD0", Slot = "4")]
	public override bool GKIHIBGHNMF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public struct MMOECPHCEKO<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public readonly IEnumerable<TData> HHJJPFOBBJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public readonly Quaternion KOKPFBBMKOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public readonly Vector3? JJHIHCJHPDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public readonly bool KOGMAPCECCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public readonly bool OAINHDLPPAE;

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x450BB30", Offset = "0x450A130", VA = "0x18450BB30")]
	public MMOECPHCEKO(IEnumerable<TData> HHJJPFOBBJG, Quaternion KOKPFBBMKOH, Vector3? JJHIHCJHPDO, bool KOGMAPCECCM, bool OAINHDLPPAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public struct DCPCOIOLPKK<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public readonly IEnumerable<TData> HHJJPFOBBJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly bool OAINHDLPPAE;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x5862630", Offset = "0x5860C30", VA = "0x185862630")]
	public DCPCOIOLPKK(IEnumerable<TData> HHJJPFOBBJG, bool OAINHDLPPAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public struct JMFIPHFLNBI<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public readonly IEnumerable<TData> HHJJPFOBBJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public readonly Quaternion KNKMDIONIIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public readonly COICGOODDKN DDBAPPHANGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public readonly Vector3? JJHIHCJHPDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public readonly bool KOGMAPCECCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public readonly bool OAINHDLPPAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public readonly Space LMIOGLEIHOC;

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x40F7590", Offset = "0x40F5B90", VA = "0x1840F7590")]
	public JMFIPHFLNBI(IEnumerable<TData> HHJJPFOBBJG, Quaternion KNKMDIONIIB, COICGOODDKN DDBAPPHANGK, Vector3? JJHIHCJHPDO, bool KOGMAPCECCM, bool OAINHDLPPAE, Space LMIOGLEIHOC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public struct DBNJINNFFPP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public readonly Quaternion KOKPFBBMKOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public readonly Vector3? JJHIHCJHPDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public readonly bool KOGMAPCECCM;

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x4D638D0", Offset = "0x4D61ED0", VA = "0x184D638D0")]
	public DBNJINNFFPP(Quaternion KOKPFBBMKOH, Vector3? JJHIHCJHPDO, bool KOGMAPCECCM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public interface HBOOKAAMHOH<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CEJEFIOLFLG([In] IJHGAFKMFOH<TData> HCFDHHKPKAA);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MPIPKFHOMFG([In] BAOLFGMIFKB LHOCHLCABMG);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MPIPKFHOMFG([In] EAFAKMGNNGG LHOCHLCABMG);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MPIPKFHOMFG([In] HENJPPAIICE LHOCHLCABMG);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool DHEHEHLNDFI();
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public class KFIGMLBAOOI<TData> : NBHIDGGBMPP<HBOOKAAMHOH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly HENJPPAIICE NDEAJNNDEMO;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x41D73D0", Offset = "0x41D59D0", VA = "0x1841D73D0")]
	public KFIGMLBAOOI(Vector3 ABJBPLEKEJD, float PMPLECFBFFL, Vector3 JJHIHCJHPDO, bool OGJBPLIIPLN, bool NMFPDKMCCAP, HBOOKAAMHOH<TData> MPDCNJDLMJC, Space LMIOGLEIHOC = Space.Self)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x41D7370", Offset = "0x41D5970", VA = "0x1841D7370", Slot = "4")]
	public override bool GKIHIBGHNMF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public class LMGDEOILNDC<TData> : NBHIDGGBMPP<HBOOKAAMHOH<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x3B6E5F0", Offset = "0x3B6CBF0", VA = "0x183B6E5F0")]
	public LMGDEOILNDC(HBOOKAAMHOH<TData> MPDCNJDLMJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x42E27E0", Offset = "0x42E0DE0", VA = "0x1842E27E0", Slot = "4")]
	public override bool GKIHIBGHNMF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class OLMMOOPIHFL<TData> : NBHIDGGBMPP<HBOOKAAMHOH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly IJHGAFKMFOH<TData> NDEAJNNDEMO;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x472FD00", Offset = "0x472E300", VA = "0x18472FD00")]
	public OLMMOOPIHFL(IEnumerable<TData> HHJJPFOBBJG, bool OAINHDLPPAE, HBOOKAAMHOH<TData> MPDCNJDLMJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x3C93B10", Offset = "0x3C92110", VA = "0x183C93B10", Slot = "4")]
	public override bool GKIHIBGHNMF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class NMKHDKPKPFD<TData> : NBHIDGGBMPP<HBOOKAAMHOH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly EAFAKMGNNGG NDEAJNNDEMO;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x4595AC0", Offset = "0x45940C0", VA = "0x184595AC0")]
	public NMKHDKPKPFD(float HDGBCNMBBJF, bool AGGFDHAIMEE, Vector3 JJHIHCJHPDO, HBOOKAAMHOH<TData> MPDCNJDLMJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x45959F0", Offset = "0x4593FF0", VA = "0x1845959F0", Slot = "4")]
	public override bool GKIHIBGHNMF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class GOBMIDHJPLE<TData> : NBHIDGGBMPP<HBOOKAAMHOH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly BAOLFGMIFKB NDEAJNNDEMO;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x3CF1B10", Offset = "0x3CF0110", VA = "0x183CF1B10")]
	public GOBMIDHJPLE(float PMPLECFBFFL, Vector3 JJHIHCJHPDO, HBOOKAAMHOH<TData> MPDCNJDLMJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x37EADD0", Offset = "0x37E93D0", VA = "0x1837EADD0", Slot = "4")]
	public override bool GKIHIBGHNMF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public struct HENJPPAIICE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public readonly Vector3 ABJBPLEKEJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public readonly float PMPLECFBFFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public readonly Vector3 JJHIHCJHPDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public readonly bool BCEEBEBIKFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public readonly Space LMIOGLEIHOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public readonly bool NMFPDKMCCAP;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x69F08B0", Offset = "0x69EEEB0", VA = "0x1869F08B0")]
	public HENJPPAIICE(Vector3 ABJBPLEKEJD, float PMPLECFBFFL, Vector3 JJHIHCJHPDO, bool BCEEBEBIKFO, bool CHCJEJADMAJ, Space LMIOGLEIHOC = Space.Self)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public struct IJHGAFKMFOH<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public readonly IEnumerable<TData> HHJJPFOBBJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public readonly bool OAINHDLPPAE;

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x3E4B1A0", Offset = "0x3E497A0", VA = "0x183E4B1A0")]
	public IJHGAFKMFOH(IEnumerable<TData> HHJJPFOBBJG, bool OAINHDLPPAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct EAFAKMGNNGG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public readonly float HDGBCNMBBJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public readonly bool AGGFDHAIMEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public readonly Vector3 JJHIHCJHPDO;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x69F07C0", Offset = "0x69EEDC0", VA = "0x1869F07C0")]
	public EAFAKMGNNGG(float HDGBCNMBBJF, bool AGGFDHAIMEE, Vector3 JJHIHCJHPDO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public struct BAOLFGMIFKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public readonly float PMPLECFBFFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public readonly Vector3 JJHIHCJHPDO;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x4D36410", Offset = "0x4D34A10", VA = "0x184D36410")]
	public BAOLFGMIFKB(float PMPLECFBFFL, Vector3 JJHIHCJHPDO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct LFPMIMBDIEM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public readonly Guid[] HHJJPFOBBJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public readonly bool IHCCGAMMFKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public readonly bool PKGJKLIOGCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public readonly bool FGLAKODMHKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public readonly Vector3[] EPEMDDHEPAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public readonly Quaternion[] KCKKEGFBJNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly float[] KKFLOMBFPOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public readonly Dictionary<Guid, Vector3> HKPIKHJGJEH;

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x69F12D0", Offset = "0x69EF8D0", VA = "0x1869F12D0")]
	public LFPMIMBDIEM(Guid[] FJCMFCFCLFD, Vector3[] EPEMDDHEPAK, Quaternion[] KCKKEGFBJNG, float[] KKFLOMBFPOC, Dictionary<Guid, Vector3> HKPIKHJGJEH, bool IHCCGAMMFKB = true, bool PKGJKLIOGCD = true, bool FGLAKODMHKO = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x69F1100", Offset = "0x69EF700", VA = "0x1869F1100")]
	private static void PLMONPBHNMA(Dictionary<Guid, Vector3> HKPIKHJGJEH, int GDJKAIBMMOO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public static class JPGIOGEKLJC
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	private struct BOAJLLAFLLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public bool LBJEOLDBIOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public JJHPIOCMJGA OBFCFHGMNAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public JJHPIOCMJGA LPEKCJGAIPG;
	}

	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private static BOAJLLAFLLM ALEMHNFIHCN;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static CancellationToken AKAKJLCCBBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x69F0D40", Offset = "0x69EF340", VA = "0x1869F0D40")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	internal static JJHPIOCMJGA OBFCFHGMNAE
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x69F0E10", Offset = "0x69EF410", VA = "0x1869F0E10")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x69F0DB0", Offset = "0x69EF3B0", VA = "0x1869F0DB0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x69F0EB0", Offset = "0x69EF4B0", VA = "0x1869F0EB0")]
	[CCEDJDOPMOE(GIKFHLNFMKF.Room, CFIDNIINJOK.None)]
	private static void MLANPAMCCDJ(JJHPIOCMJGA EDMMPFIBGCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x69F0C00", Offset = "0x69EF200", VA = "0x1869F0C00")]
	public static void BOPCGMPFNGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x69F0D60", Offset = "0x69EF360", VA = "0x1869F0D60")]
	private static JJHPIOCMJGA HKHKFMMAAMC(JJHPIOCMJGA LICOOADAAEP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public static class DIPDPPEFCCN
{
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public enum EDDCOFNHBPC
	{
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		ICreationContextObject,
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		Guid
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x29AB010", Offset = "0x29A9610", VA = "0x1829AB010")]
	public static void DEMKBLPNIKJ<T>(T GCEDGJIKNEO, EDDCOFNHBPC BDKLEMDNAFL) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x29AAFA0", Offset = "0x29A95A0", VA = "0x1829AAFA0")]
	public static void DEMKBLPNIKJ<T>(T GCEDGJIKNEO) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x29AB230", Offset = "0x29A9830", VA = "0x1829AB230")]
	public static void MFCHOLIJFLM<T>(T GCEDGJIKNEO) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x29AACE0", Offset = "0x29A92E0", VA = "0x1829AACE0")]
	public static T BJJBEHDKBAF<T>(EDDCOFNHBPC BDKLEMDNAFL) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x29AAD90", Offset = "0x29A9390", VA = "0x1829AAD90")]
	public static bool CBPJGMGJFOI<T>(EDDCOFNHBPC BDKLEMDNAFL, T? CPNPIPIEHNM, [Out][NotNullWhen(true)][MaybeNullWhen(false)] T AKGFLBHCIDL) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x29AB180", Offset = "0x29A9780", VA = "0x1829AB180")]
	public static bool GOOBNNIMJCD<T>(EDDCOFNHBPC BDKLEMDNAFL) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x29AAC80", Offset = "0x29A9280", VA = "0x1829AAC80")]
	public static T BJJBEHDKBAF<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x29AAEE0", Offset = "0x29A94E0", VA = "0x1829AAEE0")]
	public static bool CBPJGMGJFOI<T>(T CPNPIPIEHNM, [Out] T AKGFLBHCIDL) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x29AAC80", Offset = "0x29A9280", VA = "0x1829AAC80")]
	public static bool GOOBNNIMJCD<T>() where T : class
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
internal static class JMILGFPDGKD
{
	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x69F09D0", Offset = "0x69EEFD0", VA = "0x1869F09D0")]
	public static void FACCFBCPNLK(IEnumerable AGAAPOFCAAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x2BCB1E0", Offset = "0x2BC97E0", VA = "0x182BCB1E0")]
	public static void FACCFBCPNLK<T>(T[] NMHOKLPDKBK) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x2BCB3C0", Offset = "0x2BC99C0", VA = "0x182BCB3C0")]
	public static void FACCFBCPNLK<T>(T FKJJEAOFBOH) where T : notnull, Enum
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
