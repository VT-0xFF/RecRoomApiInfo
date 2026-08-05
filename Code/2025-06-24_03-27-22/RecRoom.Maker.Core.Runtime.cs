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
		[Cpp2IlInjected.Address(RVA = "0xA478F0", Offset = "0xA464F0", VA = "0x180A478F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E25220", Offset = "0x7E23E20", VA = "0x187E25220")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA48850", Offset = "0xA47450", VA = "0x180A48850")]
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
		[Cpp2IlInjected.Address(RVA = "0xA48890", Offset = "0xA47490", VA = "0x180A48890")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E25370", Offset = "0x7E23F70", VA = "0x187E25370", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x27CE7F0", Offset = "0x27CD3F0", VA = "0x1827CE7F0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum BLBCNLKFKJL
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
public interface GKNGIMJLLNL<TData, TReturn>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TReturn LCFLBJFHNLH(TData KDKJDFFGNJJ);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface FDCCHAPIDFK<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ClearHoverTarget(MHKGCCKEMJJ HBCLEPJBMCJ);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool SetHoverTarget(TData MDKAAPLMLKG, Collider BABMEHEMFHN, MHKGCCKEMJJ HBCLEPJBMCJ, [Optional] AGAICHLALAG? HCFIKNHKBGP);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool TryGetHoverTarget([Out] TData MDKAAPLMLKG);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetHoverCollider([Out] Collider BABMEHEMFHN);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface CEMCILNKNDD<TData> : NPGNLPMOJAD, CBFOLBDOPOD<TData>, INIGDKBPFHF<TData>, DFPGDHFDHNJ<TData>, GCJHKBBLIHE, IBCBHGFFFDO<TData>, JCBDFLICPOP, FIANPHAOBCC
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface IBCBHGFFFDO<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 NFEAKPLEKJO, Vector3 HLIFPOIPBBB, float KNLGCBPGFKL, [Out] T ONIEECNNMHD, [Out] Vector3 KNMEDANOOLC, [Out] Collider BABMEHEMFHN);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 NFEAKPLEKJO, Vector3 HLIFPOIPBBB, float DOAGHNIOHCM, float KNLGCBPGFKL, T[] DEDCINBNLCF, [Out] Vector3 NJFCMPDMLDO, [Out] Collider CIFEDEADLAO);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 NFEAKPLEKJO, float DOAGHNIOHCM, Vector3 KEKJFGBKANG, T[] DEDCINBNLCF);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetObjectFromColliderInCurrentScope(Collider HNEMFCNMJHE, [Out] T CPHODLGCJPK);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface NPGNLPMOJAD
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Bounds BJPIEPIJGBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Transform FDMGECADOCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Bounds IKLMPCIPJCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Transform OCKOPHHMKPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Vector3 ILONOCHILCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool PPMGHHBFHKA
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
	void SetSelectionBoundsDirty(bool HFBIALACBDJ = true, int ANLAKCDOPKP = 0);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ShouldHideSelectionBoundsPreview(bool BOHJJGIMCMF, object HEDGIMBCGHA);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface FIANPHAOBCC
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	HBAAEHCBNNO CGGOAHNDCEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface PKDMNIHLPJK
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool IMKODCCDPKN
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool DHOFIKEGJBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool MMICMJNBJHD
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
	void TrySetPreviousCloneMapping(Dictionary<Guid, Guid> FKPHBGBPADM);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface DFPGDHFDHNJ<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool PKLNJDPDJGA
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int HIHMPNBBFHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<TData> OLLBGHHLGLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData ONKLOOMCJOM);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData ONKLOOMCJOM);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface CBFOLBDOPOD<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T KDKJDFFGNJJ, [Optional] AGAICHLALAG? FPDMHGECAFI, bool LEMPFLFJOIG = true);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int DPOOEAFKIHD, IEnumerable<T> ALJKILPNDCM, bool LEMPFLFJOIG = true);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int DPOOEAFKIHD, IEnumerable<T> ALJKILPNDCM, AGAICHLALAG FPDMHGECAFI, bool LEMPFLFJOIG = true);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface JCBDFLICPOP
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface GCJHKBBLIHE
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool LNGAKKJCCAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool PJFJDKCEBLP
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool AAEOLHHJFGC
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool GGLCBKOOAGA
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct EGPKKPFBMAN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public bool OOLCENBMEPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public float? PKOPCFBMGEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public float? MJHKMCAMEPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public float? IAGBGKBHAFG;
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct BMGJEAKDHKC<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public IEnumerable<TData> GEPDNODLAKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public EGPKKPFBMAN FCDAPDDDNAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public bool DHHANOMNBBI;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6488EB0", Offset = "0x6487AB0", VA = "0x186488EB0")]
	public BMGJEAKDHKC(IEnumerable<TData> IJOCDKGENOK, bool HGFNDAKLBMJ, float? BBCALHMHJLN, float? BNCKDCNKIDE, float? DKEFJLPHHMH, bool DHHANOMNBBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface JBDCIBKKCIP<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LGHBMANLFPL([In] BMGJEAKDHKC<TData> FABPHEFJGGN);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class BDBNHJIAPJP<TData> : LDAEHMLLPNH<JBDCIBKKCIP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly BMGJEAKDHKC<TData> FABPHEFJGGN;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x61D5950", Offset = "0x61D4550", VA = "0x1861D5950")]
	public BDBNHJIAPJP(IEnumerable<TData> IJOCDKGENOK, bool HGFNDAKLBMJ, float? BBCALHMHJLN, float? BNCKDCNKIDE, float? DKEFJLPHHMH, bool DHHANOMNBBI, JBDCIBKKCIP<TData> ODPFHLHHEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4E74300", Offset = "0x4E72F00", VA = "0x184E74300", Slot = "4")]
	public override bool LGHBMANLFPL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct JHCAAIGLOLK<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public IEnumerable<TData> GEPDNODLAKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public string AEIHCINHOBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public bool IEJLHGCILMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public bool DHHANOMNBBI;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x50F8CF0", Offset = "0x50F78F0", VA = "0x1850F8CF0")]
	public JHCAAIGLOLK(IEnumerable<TData> IJOCDKGENOK, string PJOILBBKCNO, bool LKJALOEGMHJ, bool DHHANOMNBBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface LMKGIAAKOGP<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LGHBMANLFPL([In] JHCAAIGLOLK<TData> FABPHEFJGGN);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class JPKDAPMFGDC<TData> : LDAEHMLLPNH<LMKGIAAKOGP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly JHCAAIGLOLK<TData> FABPHEFJGGN;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5118C10", Offset = "0x5117810", VA = "0x185118C10")]
	public JPKDAPMFGDC(IEnumerable<TData> IJOCDKGENOK, string PJOILBBKCNO, bool LKJALOEGMHJ, bool DHHANOMNBBI, LMKGIAAKOGP<TData> ODPFHLHHEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x4E74300", Offset = "0x4E72F00", VA = "0x184E74300", Slot = "4")]
	public override bool LGHBMANLFPL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public abstract class LDAEHMLLPNH<TReceiver> : DJIMFIHNAHJ<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4738D90", Offset = "0x4737990", VA = "0x184738D90")]
	public LDAEHMLLPNH(TReceiver ODPFHLHHEBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public abstract class BBHGJJLOJDB<TReceiver, TFromTask> : DJIMFIHNAHJ<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4738D90", Offset = "0x4737990", VA = "0x184738D90")]
	public BBHGJJLOJDB(TReceiver ODPFHLHHEBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class DJIMFIHNAHJ<TReceiver, TFromExecute> where TReceiver : notnull where TFromExecute : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	protected TReceiver ODPFHLHHEBI;

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x42A7DA0", Offset = "0x42A69A0", VA = "0x1842A7DA0")]
	public DJIMFIHNAHJ(TReceiver ODPFHLHHEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute LGHBMANLFPL();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class GPAJCMIIHFC<TReceiver, TResult> : DJIMFIHNAHJ<TReceiver, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4738D90", Offset = "0x4737990", VA = "0x184738D90")]
	public GPAJCMIIHFC(TReceiver ODPFHLHHEBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct EPPFENBAKDB<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public TGroup JIKACMGPNDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public TData PHDIKECEIIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public IEnumerable<TData> GEPDNODLAKO;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1C853F0", Offset = "0x1C83FF0", VA = "0x181C853F0")]
	public EPPFENBAKDB(TGroup PLKDHMEAJKH, TData MLILJLIMHNM, IEnumerable<TData> IJOCDKGENOK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct LGIDIABDEOA<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public TGroup JIKACMGPNDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public IEnumerable<TData> GEPDNODLAKO;

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0xB5F450", Offset = "0xB5E050", VA = "0x180B5F450")]
	public LGIDIABDEOA(TGroup PLKDHMEAJKH, IEnumerable<TData> IJOCDKGENOK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct GAHFPKIHCON<TGroup> where TGroup : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public TGroup JIKACMGPNDB;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0xDCEEA0", Offset = "0xDCDAA0", VA = "0x180DCEEA0")]
	public GAHFPKIHCON(TGroup PLKDHMEAJKH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct NOGIPIJFHBH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public IEnumerable<Guid> GEPDNODLAKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public Guid JECJABCFCNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly bool EIBPPAAANCI;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7E251E0", Offset = "0x7E23DE0", VA = "0x187E251E0")]
	public NOGIPIJFHBH(IEnumerable<Guid> IJOCDKGENOK, Guid KOBPDCFBLAL, bool DHHANOMNBBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public struct KKCGJGKOPPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public Guid JECJABCFCNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly bool EIBPPAAANCI;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2763420", Offset = "0x2762020", VA = "0x182763420")]
	public KKCGJGKOPPC(Guid KOBPDCFBLAL, bool DHHANOMNBBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface GHDCMIOOOAG<TGroup, TData>
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FJCIHNLJOBC OAGCCFCNEGO(EPPFENBAKDB<TGroup, TData> IHAPGBKLBNC);

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FJCIHNLJOBC BNILNEONGNK(EPPFENBAKDB<TGroup, TData> IHAPGBKLBNC);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FJCIHNLJOBC JNLGENOPNAO(LGIDIABDEOA<TGroup, TData> IHAPGBKLBNC);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FJCIHNLJOBC GHAFIDKGHCN(GAHFPKIHCON<TGroup> IHAPGBKLBNC);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface FPLLEMAMDOO
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<FJCIHNLJOBC> OAGCCFCNEGO(NOGIPIJFHBH IHAPGBKLBNC);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<FJCIHNLJOBC> BNILNEONGNK(KKCGJGKOPPC IHAPGBKLBNC);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class FDGFBONABPC<TGroup, TData> : GPAJCMIIHFC<GHDCMIOOOAG<TGroup, TData>, FJCIHNLJOBC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly LGIDIABDEOA<TGroup, TData> IHAPGBKLBNC;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x4BEA7E0", Offset = "0x4BE93E0", VA = "0x184BEA7E0")]
	public FDGFBONABPC(TGroup PLKDHMEAJKH, IEnumerable<TData> IJOCDKGENOK, GHDCMIOOOAG<TGroup, TData> ODPFHLHHEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x4BEA710", Offset = "0x4BE9310", VA = "0x184BEA710", Slot = "4")]
	public override FJCIHNLJOBC LGHBMANLFPL()
	{
		return default(FJCIHNLJOBC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class NIDNGIFIIGN<TGroup, TData> : GPAJCMIIHFC<GHDCMIOOOAG<TGroup, TData>, FJCIHNLJOBC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly EPPFENBAKDB<TGroup, TData> IHAPGBKLBNC;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5523130", Offset = "0x5521D30", VA = "0x185523130")]
	public NIDNGIFIIGN(TGroup PLKDHMEAJKH, TData JCDHPBKIPIL, IEnumerable<TData> IJOCDKGENOK, GHDCMIOOOAG<TGroup, TData> ODPFHLHHEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5523060", Offset = "0x5521C60", VA = "0x185523060", Slot = "4")]
	public override FJCIHNLJOBC LGHBMANLFPL()
	{
		return default(FJCIHNLJOBC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class HKFDMJGHHFF<TGroup, TData> : GPAJCMIIHFC<GHDCMIOOOAG<TGroup, TData>, FJCIHNLJOBC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly GAHFPKIHCON<TGroup> IHAPGBKLBNC;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x4DB3C70", Offset = "0x4DB2870", VA = "0x184DB3C70")]
	public HKFDMJGHHFF(TGroup PLKDHMEAJKH, GHDCMIOOOAG<TGroup, TData> ODPFHLHHEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x4DB3BB0", Offset = "0x4DB27B0", VA = "0x184DB3BB0", Slot = "4")]
	public override FJCIHNLJOBC LGHBMANLFPL()
	{
		return default(FJCIHNLJOBC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class NPHFMIHODPE<TGroup, TData> : GPAJCMIIHFC<GHDCMIOOOAG<TGroup, TData>, FJCIHNLJOBC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly EPPFENBAKDB<TGroup, TData> IHAPGBKLBNC;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5523130", Offset = "0x5521D30", VA = "0x185523130")]
	public NPHFMIHODPE(TGroup PLKDHMEAJKH, TData MLILJLIMHNM, IEnumerable<TData> IJOCDKGENOK, GHDCMIOOOAG<TGroup, TData> ODPFHLHHEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5556000", Offset = "0x5554C00", VA = "0x185556000", Slot = "4")]
	public override FJCIHNLJOBC LGHBMANLFPL()
	{
		return default(FJCIHNLJOBC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class IHANCOPEAJF : BBHGJJLOJDB<FPLLEMAMDOO, FJCIHNLJOBC>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct CKCOKOEGMCH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public AsyncTaskMethodBuilder<FJCIHNLJOBC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public IHANCOPEAJF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private TaskAwaiter<FJCIHNLJOBC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7E23910", Offset = "0x7E22510", VA = "0x187E23910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7E23BA0", Offset = "0x7E227A0", VA = "0x187E23BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private NOGIPIJFHBH IHAPGBKLBNC;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7E24490", Offset = "0x7E23090", VA = "0x187E24490")]
	public IHANCOPEAJF(IEnumerable<Guid> GOECNNDDHCG, Guid KOBPDCFBLAL, bool DHHANOMNBBI, FPLLEMAMDOO ODPFHLHHEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7E243A0", Offset = "0x7E22FA0", VA = "0x187E243A0", Slot = "4")]
	[AsyncStateMachine(typeof(CKCOKOEGMCH))]
	public override Task<FJCIHNLJOBC> LGHBMANLFPL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class EGLBNNELPFJ : BBHGJJLOJDB<FPLLEMAMDOO, FJCIHNLJOBC>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private struct CIAKNJPADDN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public AsyncTaskMethodBuilder<FJCIHNLJOBC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public EGLBNNELPFJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private TaskAwaiter<FJCIHNLJOBC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7E23600", Offset = "0x7E22200", VA = "0x187E23600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7E238A0", Offset = "0x7E224A0", VA = "0x187E238A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly KKCGJGKOPPC IHAPGBKLBNC;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7E23E50", Offset = "0x7E22A50", VA = "0x187E23E50")]
	public EGLBNNELPFJ(Guid KOBPDCFBLAL, bool DHHANOMNBBI, FPLLEMAMDOO ODPFHLHHEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7E23D60", Offset = "0x7E22960", VA = "0x187E23D60", Slot = "4")]
	[AsyncStateMachine(typeof(CIAKNJPADDN))]
	public override Task<FJCIHNLJOBC> LGHBMANLFPL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public readonly struct MHOIDEHEGDD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly JNBEOOODFIJ AAOBCOEEBHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly bool EIBPPAAANCI;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7E24F50", Offset = "0x7E23B50", VA = "0x187E24F50")]
	public MHOIDEHEGDD(JNBEOOODFIJ IIBPIJMDJHF, bool DHHANOMNBBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface HPEKELDPCHE<TSpawnType> where TSpawnType : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> LGHBMANLFPL(MHOIDEHEGDD GGAHNFCPOBB);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class BBJHOCGPOIC<TSpawnType> : BBHGJJLOJDB<HPEKELDPCHE<TSpawnType>, TSpawnType> where TSpawnType : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct PEDENNDCLNB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public AsyncTaskMethodBuilder<TSpawnType> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public BBJHOCGPOIC<TSpawnType> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private TaskAwaiter<TSpawnType> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x57CDBE0", Offset = "0x57CC7E0", VA = "0x1857CDBE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x47215F0", Offset = "0x47201F0", VA = "0x1847215F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly MHOIDEHEGDD GGAHNFCPOBB;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x61CE400", Offset = "0x61CD000", VA = "0x1861CE400")]
	public BBJHOCGPOIC(JNBEOOODFIJ IIBPIJMDJHF, bool DHHANOMNBBI, HPEKELDPCHE<TSpawnType> ODPFHLHHEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x61CE220", Offset = "0x61CCE20", VA = "0x1861CE220", Slot = "4")]
	[AsyncStateMachine(typeof(BBJHOCGPOIC<>.PEDENNDCLNB))]
	public override Task<TSpawnType> LGHBMANLFPL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public readonly struct JNBEOOODFIJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly bool ANKLCJHBDGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly Vector3 PJNJOMDHHBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly Vector3 AIFJIFCFPDH;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7E24690", Offset = "0x7E23290", VA = "0x187E24690")]
	public JNBEOOODFIJ(Transform BFEJEKNMNID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7E24780", Offset = "0x7E23380", VA = "0x187E24780")]
	public JNBEOOODFIJ(Vector3 AKLPJIPJBIP, Vector3 IIBJECFMAJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7E24660", Offset = "0x7E23260", VA = "0x187E24660")]
	public static JNBEOOODFIJ KIKIFBKOCFE()
	{
		return default(JNBEOOODFIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7E24700", Offset = "0x7E23300", VA = "0x187E24700")]
	private JNBEOOODFIJ(bool AIPBBOKNCOM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct EAMMIDCAMJK<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public TNode KEPOOKDJHBH;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x470B0F0", Offset = "0x4709CF0", VA = "0x18470B0F0")]
	public EAMMIDCAMJK(TNode KEPOOKDJHBH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct DEFOIMDKBHE<TNode, TReparentOperations> where TNode : notnull where TReparentOperations : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public TNode NOEIFHAFHJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public TReparentOperations HGHBGIBCODK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public ENEKAKPLKCE BBDPNLLICAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly bool EIBPPAAANCI;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6B8B2B0", Offset = "0x6B89EB0", VA = "0x186B8B2B0")]
	public DEFOIMDKBHE(TNode NOEIFHAFHJJ, TReparentOperations HGHBGIBCODK, ENEKAKPLKCE BBDPNLLICAN, bool DHHANOMNBBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface JGJJDPGHMLK<TNode, TReparentOperations>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BDANGPKPFHL([In] EAMMIDCAMJK<TNode> OOFLNINPPJI);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JAEFHHKBGFN([In] DEFOIMDKBHE<TNode, TReparentOperations> CLDHCHMLBCC);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool EPMPLJAOGND();
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class EKIPPEOCFEB<TNode, TReparentOperations> : LDAEHMLLPNH<JGJJDPGHMLK<TNode, TReparentOperations>>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x4738D90", Offset = "0x4737990", VA = "0x184738D90")]
	public EKIPPEOCFEB(JGJJDPGHMLK<TNode, TReparentOperations> ODPFHLHHEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x4738D40", Offset = "0x4737940", VA = "0x184738D40", Slot = "4")]
	public override bool LGHBMANLFPL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class KEEIGKPKIIL<TNode, TReparentOperations> : LDAEHMLLPNH<JGJJDPGHMLK<TNode, TReparentOperations>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly DEFOIMDKBHE<TNode, TReparentOperations> CLDHCHMLBCC;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x51D7C10", Offset = "0x51D6810", VA = "0x1851D7C10")]
	public KEEIGKPKIIL(TNode NOEIFHAFHJJ, TReparentOperations HGHBGIBCODK, ENEKAKPLKCE BBDPNLLICAN, JGJJDPGHMLK<TNode, TReparentOperations> ODPFHLHHEBI, bool DHHANOMNBBI = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x429FEE0", Offset = "0x429EAE0", VA = "0x18429FEE0", Slot = "4")]
	public override bool LGHBMANLFPL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class PAEAJCFGLDA<TNode, TReparentOperations> : LDAEHMLLPNH<JGJJDPGHMLK<TNode, TReparentOperations>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly EAMMIDCAMJK<TNode> OOFLNINPPJI;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5749240", Offset = "0x5747E40", VA = "0x185749240")]
	public PAEAJCFGLDA(TNode NDBGGPMFPAH, JGJJDPGHMLK<TNode, TReparentOperations> ODPFHLHHEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x4E74300", Offset = "0x4E72F00", VA = "0x184E74300", Slot = "4")]
	public override bool LGHBMANLFPL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct HKOPPPCHFNK<TSpawnInfo> where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public TSpawnInfo AJJLNFGBPOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public Vector3 IIBJECFMAJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public Quaternion BFEELDCLMGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public float LHHOCCKJGIB;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x4DB4890", Offset = "0x4DB3490", VA = "0x184DB4890")]
	public HKOPPPCHFNK(TSpawnInfo AJJLNFGBPOJ, Vector3 IIBJECFMAJC, Quaternion BFEELDCLMGM, float LHHOCCKJGIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface IGGHLAKHCEK<TSpawnType, TSpawnInfo>
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> GNBLHHOBDEC([In] HKOPPPCHFNK<TSpawnInfo> AGEFANPKGME, CancellationToken DKKNFNCKCEB);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class NGDIPIHNLHG<TSpawnType, TSpawnInfo> : BBHGJJLOJDB<IGGHLAKHCEK<TSpawnType, TSpawnInfo>, TSpawnType> where TSpawnType : notnull where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly HKOPPPCHFNK<TSpawnInfo> FABPHEFJGGN;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x55218A0", Offset = "0x55204A0", VA = "0x1855218A0")]
	public NGDIPIHNLHG(TSpawnInfo GDGCCLJBDHJ, Vector3 IIBJECFMAJC, Quaternion BFEELDCLMGM, float LHHOCCKJGIB, IGGHLAKHCEK<TSpawnType, TSpawnInfo> ODPFHLHHEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4CE3B80", Offset = "0x4CE2780", VA = "0x184CE3B80", Slot = "4")]
	public override Task<TSpawnType> LGHBMANLFPL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public readonly struct JBGIDCLJMAE<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly IEnumerable<TData> GEPDNODLAKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly bool EIBPPAAANCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly bool COECEAHKKMJ;

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x50ADFD0", Offset = "0x50ACBD0", VA = "0x1850ADFD0")]
	public JBGIDCLJMAE(IEnumerable<TData> IJOCDKGENOK, bool DHHANOMNBBI = false, bool NGBJPNFGJJO = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface CPAIGOGONGH<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<FJCIHNLJOBC> HPBCDAOOLLH([In] JBGIDCLJMAE<TData> JMDDKCFAOHI, CancellationToken DKKNFNCKCEB);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class ADKKMIJNJOG<TData> : BBHGJJLOJDB<CPAIGOGONGH<TData>, FJCIHNLJOBC> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly JBGIDCLJMAE<TData> HDAEEMJKGDE;

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x4CE3CF0", Offset = "0x4CE28F0", VA = "0x184CE3CF0")]
	public ADKKMIJNJOG(IEnumerable<TData> IJOCDKGENOK, bool DHHANOMNBBI, CPAIGOGONGH<TData> ODPFHLHHEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x4CE3B80", Offset = "0x4CE2780", VA = "0x184CE3B80", Slot = "4")]
	public override Task<FJCIHNLJOBC> LGHBMANLFPL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public struct NAJDPKGBPKM<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly T MDKAAPLMLKG;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x47111D0", Offset = "0x470FDD0", VA = "0x1847111D0")]
	public NAJDPKGBPKM(T COCGDBHOFPH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface IDLPEIGLBFK<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BDANGPKPFHL([In] NAJDPKGBPKM<T> BCEDCFEJFBK);

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JAEFHHKBGFN();
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface LDKAHFCGCJC<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LGHBMANLFPL([In] KLKMADGHJFF<T> EIOMFHKIFGF);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public struct KLKMADGHJFF<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly T MDKAAPLMLKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly bool NGMLDMOAHHL;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x51F4FE0", Offset = "0x51F3BE0", VA = "0x1851F4FE0")]
	public KLKMADGHJFF(T COCGDBHOFPH, bool MCFADIAKPKJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class MAPHENAKFPF<T> : LDAEHMLLPNH<IDLPEIGLBFK<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x4738D90", Offset = "0x4737990", VA = "0x184738D90")]
	public MAPHENAKFPF(IDLPEIGLBFK<T> ODPFHLHHEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x54978A0", Offset = "0x54964A0", VA = "0x1854978A0", Slot = "4")]
	public override bool LGHBMANLFPL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class PMGPPLEFNOH<T> : LDAEHMLLPNH<IDLPEIGLBFK<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly NAJDPKGBPKM<T> BCEDCFEJFBK;

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x57E3E50", Offset = "0x57E2A50", VA = "0x1857E3E50")]
	public PMGPPLEFNOH(T MDKAAPLMLKG, IDLPEIGLBFK<T> ODPFHLHHEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x4E74300", Offset = "0x4E72F00", VA = "0x184E74300", Slot = "4")]
	public override bool LGHBMANLFPL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class OCOOBDONECP<T> : LDAEHMLLPNH<LDKAHFCGCJC<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly KLKMADGHJFF<T> EIOMFHKIFGF;

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5658650", Offset = "0x5657250", VA = "0x185658650")]
	public OCOOBDONECP(T MDKAAPLMLKG, bool MCFADIAKPKJ, LDKAHFCGCJC<T> ODPFHLHHEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x4E74300", Offset = "0x4E72F00", VA = "0x184E74300", Slot = "4")]
	public override bool LGHBMANLFPL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public struct JMGKLEHPJOO<TData> where TData : notnull, EIOKGACHLEG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public IEnumerable<TData> GEPDNODLAKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public bool JFFBMJONGFM;

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x510EAC0", Offset = "0x510D6C0", VA = "0x18510EAC0")]
	public JMGKLEHPJOO(IEnumerable<TData> FPFANFDCIGA, bool AJAELLCIJBK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public struct JCJDMNIJIBK<TData> where TData : notnull, EIOKGACHLEG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public List<TData> GEPDNODLAKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public List<bool> KMFNKCMGHOI;

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x50E49D0", Offset = "0x50E35D0", VA = "0x1850E49D0")]
	public JCJDMNIJIBK(List<TData> FPFANFDCIGA, List<bool> EHBIANDNHKH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface EIOKGACHLEG
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool AMCOKLPEMMP
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
public interface NOENEIMHJHG<TData> where TData : EIOKGACHLEG
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LGHBMANLFPL([In] JMGKLEHPJOO<TData> DIPKOINHKKP);

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LGHBMANLFPL([In] JCJDMNIJIBK<TData> DIPKOINHKKP);
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface JCHNMOCECOI<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MKHOILPFMID(T MDKAAPLMLKG);
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class AJMINPHDGPC<TData> : LDAEHMLLPNH<NOENEIMHJHG<TData>> where TData : notnull, EIOKGACHLEG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly JMGKLEHPJOO<TData> DIPKOINHKKP;

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x4F77950", Offset = "0x4F76550", VA = "0x184F77950")]
	public AJMINPHDGPC(List<TData> IJOCDKGENOK, bool JFFBMJONGFM, NOENEIMHJHG<TData> ODPFHLHHEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x4E74300", Offset = "0x4E72F00", VA = "0x184E74300", Slot = "4")]
	public override bool LGHBMANLFPL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class BCCOHLCCNON<TData> : LDAEHMLLPNH<NOENEIMHJHG<TData>> where TData : notnull, EIOKGACHLEG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly JCJDMNIJIBK<TData> DIPKOINHKKP;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x61D1B30", Offset = "0x61D0730", VA = "0x1861D1B30")]
	public BCCOHLCCNON(List<TData> IJOCDKGENOK, List<bool> KMFNKCMGHOI, NOENEIMHJHG<TData> ODPFHLHHEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x61D1A70", Offset = "0x61D0670", VA = "0x1861D1A70", Slot = "4")]
	public override bool LGHBMANLFPL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public interface PDNGNNKKIHG<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<FJCIHNLJOBC> LGHBMANLFPL(PDIDHPKGBGE<TData> PJPBDPLKLKL);
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class DGGDJCDHMJD<TData> : BBHGJJLOJDB<PDNGNNKKIHG<TData>, FJCIHNLJOBC> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private struct PEBGNAPMAJC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public AsyncTaskMethodBuilder<FJCIHNLJOBC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public DGGDJCDHMJD<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private TaskAwaiter<FJCIHNLJOBC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x57C7590", Offset = "0x57C6190", VA = "0x1857C7590", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x57C7870", Offset = "0x57C6470", VA = "0x1857C7870", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly PDIDHPKGBGE<TData> EOIBDDAGMBE;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x429E710", Offset = "0x429D310", VA = "0x18429E710")]
	public DGGDJCDHMJD(TData CNDELGNIOPH, IReadOnlyList<TData> GHBJLOEPJAO, bool DHHANOMNBBI, PDNGNNKKIHG<TData> ODPFHLHHEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x429E610", Offset = "0x429D210", VA = "0x18429E610", Slot = "4")]
	[AsyncStateMachine(typeof(DGGDJCDHMJD<>.PEBGNAPMAJC))]
	public override Task<FJCIHNLJOBC> LGHBMANLFPL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct PDIDHPKGBGE<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public TData DGAIHAPCKMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public IReadOnlyList<TData> LJDPGGMOGGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public bool EIBPPAAANCI;

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2E74DB0", Offset = "0x2E739B0", VA = "0x182E74DB0")]
	public PDIDHPKGBGE(TData CNDELGNIOPH, IReadOnlyList<TData> GHBJLOEPJAO, bool DHHANOMNBBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public interface ECLCKNNEOOI<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LGHBMANLFPL([In] ACMHEKFIGPB<TData> GDEHHEFADLJ);
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public interface GGMJGMPDDEG<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LGHBMANLFPL([In] LLPBEMFILLL<TData> GDEHHEFADLJ);
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface JNKOFCONHHL<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KJJJGOAEKFF([In] LIHLPCJHHIL<TData> GDEHHEFADLJ);

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JAEFHHKBGFN();
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class KLCLMBKKBFJ<TData> : LDAEHMLLPNH<ECLCKNNEOOI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly ACMHEKFIGPB<TData> GDEHHEFADLJ;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x51F4560", Offset = "0x51F3160", VA = "0x1851F4560")]
	public KLCLMBKKBFJ(IEnumerable<TData> IJOCDKGENOK, JLNOJMKJPNC GCKOLKABAJC, IIDDCNCKDDH IMKAMKEPJBL, float PBHJKABEKEB, string? PJOILBBKCNO, bool LBGDDKOEDPE, bool DHHANOMNBBI, ECLCKNNEOOI<TData> ODPFHLHHEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x4E74300", Offset = "0x4E72F00", VA = "0x184E74300", Slot = "4")]
	public override bool LGHBMANLFPL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class GGJKCBLOGEP<TData> : LDAEHMLLPNH<GGMJGMPDDEG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly LLPBEMFILLL<TData> GDEHHEFADLJ;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x4D0F8A0", Offset = "0x4D0E4A0", VA = "0x184D0F8A0")]
	public GGJKCBLOGEP(TData[] IJOCDKGENOK, JLNOJMKJPNC[] GCKOLKABAJC, IIDDCNCKDDH[] IMKAMKEPJBL, float[] PBHJKABEKEB, GGMJGMPDDEG<TData> ODPFHLHHEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x4738EE0", Offset = "0x4737AE0", VA = "0x184738EE0", Slot = "4")]
	public override bool LGHBMANLFPL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class CMJLCBHKGDP<TData> : LDAEHMLLPNH<JNKOFCONHHL<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x4738D90", Offset = "0x4737990", VA = "0x184738D90")]
	public CMJLCBHKGDP(JNKOFCONHHL<TData> ODPFHLHHEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x698E630", Offset = "0x698D230", VA = "0x18698E630", Slot = "4")]
	public override bool LGHBMANLFPL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class EKMNIAMDNBO<TData> : LDAEHMLLPNH<JNKOFCONHHL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly LIHLPCJHHIL<TData> GDEHHEFADLJ;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x4738FA0", Offset = "0x4737BA0", VA = "0x184738FA0")]
	public EKMNIAMDNBO(IEnumerable<TData> IJOCDKGENOK, JLNOJMKJPNC GCKOLKABAJC, IIDDCNCKDDH IMKAMKEPJBL, float PBHJKABEKEB, JNKOFCONHHL<TData> ODPFHLHHEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x4738EE0", Offset = "0x4737AE0", VA = "0x184738EE0", Slot = "4")]
	public override bool LGHBMANLFPL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public struct ACMHEKFIGPB<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public IEnumerable<TData> GEPDNODLAKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public JLNOJMKJPNC NLKOKMDALIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public IIDDCNCKDDH NCKFIMBLHAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public float IKGOEOBCJNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public string? AEIHCINHOBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public bool? KLJOMDLBKPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public bool EIBPPAAANCI;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x4CE1AE0", Offset = "0x4CE06E0", VA = "0x184CE1AE0")]
	public ACMHEKFIGPB(IEnumerable<TData> IJOCDKGENOK, JLNOJMKJPNC GCKOLKABAJC, IIDDCNCKDDH IMKAMKEPJBL, float PBHJKABEKEB, string? PJOILBBKCNO, bool? LBGDDKOEDPE, bool DHHANOMNBBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public struct LLPBEMFILLL<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public TData[] GEPDNODLAKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public JLNOJMKJPNC[] NLKOKMDALIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public IIDDCNCKDDH[] NCKFIMBLHAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public float[] PBHJKABEKEB;

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x52C4150", Offset = "0x52C2D50", VA = "0x1852C4150")]
	public LLPBEMFILLL(TData[] IJOCDKGENOK, JLNOJMKJPNC[] GCKOLKABAJC, IIDDCNCKDDH[] IMKAMKEPJBL, float[] PBHJKABEKEB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct LIHLPCJHHIL<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public IEnumerable<TData> GEPDNODLAKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public JLNOJMKJPNC NLKOKMDALIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public IIDDCNCKDDH NCKFIMBLHAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public float PBHJKABEKEB;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x52BE7F0", Offset = "0x52BD3F0", VA = "0x1852BE7F0")]
	public LIHLPCJHHIL(IEnumerable<TData> IJOCDKGENOK, JLNOJMKJPNC GCKOLKABAJC, IIDDCNCKDDH IMKAMKEPJBL, float PBHJKABEKEB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface INIGDKBPFHF<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JNLGENOPNAO([In] BPMAODMNPMM<TData> JMDDKCFAOHI);

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GHAFIDKGHCN([In] BPMAODMNPMM<TData> JMDDKCFAOHI);

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HAFKGNKCOHK([In] bool KEIKFDDDPMC);

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool GMHJBOKHCKJ([In] BPMAODMNPMM<TData> JMDDKCFAOHI);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HIFPNLOFOPG();

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool MBIMFKBOHHM([In] TData PHDHIHJJKOG);
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class CLHKDBCPEMH<TData> : LDAEHMLLPNH<INIGDKBPFHF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly BPMAODMNPMM<TData> JMDDKCFAOHI;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x698B370", Offset = "0x6989F70", VA = "0x18698B370")]
	public CLHKDBCPEMH(List<TData> OGLPOFDOMIH, INIGDKBPFHF<TData> ODPFHLHHEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x4E74300", Offset = "0x4E72F00", VA = "0x184E74300", Slot = "4")]
	public override bool LGHBMANLFPL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class NDMGONCLEMJ<TData> : LDAEHMLLPNH<INIGDKBPFHF<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4738D90", Offset = "0x4737990", VA = "0x184738D90")]
	public NDMGONCLEMJ(INIGDKBPFHF<TData> ODPFHLHHEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x551DE50", Offset = "0x551CA50", VA = "0x18551DE50", Slot = "4")]
	public override bool LGHBMANLFPL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class MIEJKDJLAOF<TData> : LDAEHMLLPNH<INIGDKBPFHF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly bool DHHANOMNBBI;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x54C0580", Offset = "0x54BF180", VA = "0x1854C0580")]
	public MIEJKDJLAOF(bool DHHANOMNBBI, INIGDKBPFHF<TData> ODPFHLHHEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x54C0520", Offset = "0x54BF120", VA = "0x1854C0520", Slot = "4")]
	public override bool LGHBMANLFPL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class BJIGLMHAKCO<TData> : LDAEHMLLPNH<INIGDKBPFHF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly BPMAODMNPMM<TData> JMDDKCFAOHI;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x64775B0", Offset = "0x64761B0", VA = "0x1864775B0")]
	public BJIGLMHAKCO(List<TData> OGLPOFDOMIH, bool DHHANOMNBBI, INIGDKBPFHF<TData> ODPFHLHHEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x61D1A70", Offset = "0x61D0670", VA = "0x1861D1A70", Slot = "4")]
	public override bool LGHBMANLFPL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class JCJEEOGFFEN<TData> : LDAEHMLLPNH<INIGDKBPFHF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly TData PHDHIHJJKOG;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x50E4FD0", Offset = "0x50E3BD0", VA = "0x1850E4FD0")]
	public JCJEEOGFFEN(TData PHDHIHJJKOG, INIGDKBPFHF<TData> ODPFHLHHEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x50E4E60", Offset = "0x50E3A60", VA = "0x1850E4E60", Slot = "4")]
	public override bool LGHBMANLFPL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class DMIDFDHEJGC<TData> : LDAEHMLLPNH<INIGDKBPFHF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly BPMAODMNPMM<TData> JMDDKCFAOHI;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x42CB7D0", Offset = "0x42CA3D0", VA = "0x1842CB7D0")]
	public DMIDFDHEJGC(IEnumerable<TData> OGLPOFDOMIH, INIGDKBPFHF<TData> ODPFHLHHEBI, bool DHHANOMNBBI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x42CB670", Offset = "0x42CA270", VA = "0x1842CB670", Slot = "4")]
	public override bool LGHBMANLFPL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public struct BPMAODMNPMM<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public IEnumerable<TData> GEPDNODLAKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public bool DHHANOMNBBI;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6625D10", Offset = "0x6624910", VA = "0x186625D10")]
	public BPMAODMNPMM(IEnumerable<TData> FPFANFDCIGA, bool NHFNEOGKGAN = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public interface OHHOJPKGALP
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<FJCIHNLJOBC> LGHBMANLFPL(BOIJDLAIMNF MJMAADDAPPE);
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class DDAJMIKCKFH : BBHGJJLOJDB<OHHOJPKGALP, FJCIHNLJOBC>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private struct LFEKNJCHGFB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public AsyncTaskMethodBuilder<FJCIHNLJOBC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public DDAJMIKCKFH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private TaskAwaiter<FJCIHNLJOBC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x7E247B0", Offset = "0x7E233B0", VA = "0x187E247B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7E24A30", Offset = "0x7E23630", VA = "0x187E24A30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private readonly BOIJDLAIMNF JHGDKEHDJBN;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x7E23D00", Offset = "0x7E22900", VA = "0x187E23D00")]
	public DDAJMIKCKFH(bool DHHANOMNBBI, OHHOJPKGALP ODPFHLHHEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x7E23C10", Offset = "0x7E22810", VA = "0x187E23C10", Slot = "4")]
	[AsyncStateMachine(typeof(LFEKNJCHGFB))]
	public override Task<FJCIHNLJOBC> LGHBMANLFPL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public struct BOIJDLAIMNF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public bool EIBPPAAANCI;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x2B6C480", Offset = "0x2B6B080", VA = "0x182B6C480")]
	public BOIJDLAIMNF(bool DHHANOMNBBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public readonly struct HMEMFDECCJB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public readonly bool JOKJNNKCKOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public readonly bool KNOMKGHLGKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public readonly bool LHHOCCKJGIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public readonly bool DHHANOMNBBI;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5E13150", Offset = "0x5E11D50", VA = "0x185E13150")]
	public HMEMFDECCJB(bool JOKJNNKCKOI, bool KNOMKGHLGKK, bool LHHOCCKJGIB, bool DHHANOMNBBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7E24390", Offset = "0x7E22F90", VA = "0x187E24390")]
	public HMEMFDECCJB(bool KNOMKGHLGKK, bool DHHANOMNBBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public interface DJNPCMOBIKA
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BBDGNCMADAC(HMEMFDECCJB HBGMIDCAMGN);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PONCBPJBFME(HMEMFDECCJB HBGMIDCAMGN);
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public class MEEIBIMBGEF : LDAEHMLLPNH<DJNPCMOBIKA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly HMEMFDECCJB HBGMIDCAMGN;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7E24EC0", Offset = "0x7E23AC0", VA = "0x187E24EC0")]
	public MEEIBIMBGEF(bool NMIBCHFJGAE, bool KNOMKGHLGKK, bool LHHOCCKJGIB, bool DHHANOMNBBI, DJNPCMOBIKA ODPFHLHHEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x7E24E70", Offset = "0x7E23A70", VA = "0x187E24E70", Slot = "4")]
	public override bool LGHBMANLFPL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public class PADCBHLBKKD : LDAEHMLLPNH<DJNPCMOBIKA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly HMEMFDECCJB HBGMIDCAMGN;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7E252F0", Offset = "0x7E23EF0", VA = "0x187E252F0")]
	public PADCBHLBKKD(bool KNOMKGHLGKK, bool DHHANOMNBBI, DJNPCMOBIKA ODPFHLHHEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x7E252A0", Offset = "0x7E23EA0", VA = "0x187E252A0", Slot = "4")]
	public override bool LGHBMANLFPL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public interface ILNKGGIPOGK
{
	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LGHBMANLFPL([In] EHKOBILODJM OLODBJAMCNF);
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class AIALINNDEJF : LDAEHMLLPNH<ILNKGGIPOGK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly EHKOBILODJM OLODBJAMCNF;

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x7E23420", Offset = "0x7E22020", VA = "0x187E23420")]
	public AIALINNDEJF(Guid[] DBABNOKPHJO, Vector3[] MELBCIANJAL, Quaternion[] AOOLDADPHOF, float[] OCNCEPFONGG, Dictionary<Guid, Vector3> ODLIIDOKCCH, ILNKGGIPOGK ODPFHLHHEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7E23370", Offset = "0x7E21F70", VA = "0x187E23370", Slot = "4")]
	public override bool LGHBMANLFPL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public interface ADGMGDOPNFB<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BDANGPKPFHL([In] HKCJMDMPIGG<TData> OOFLNINPPJI);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KJJJGOAEKFF([In] GEBMPMBAJNK NCKDEHCKPOK);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KJJJGOAEKFF([In] HINIJHLKGLN NCKDEHCKPOK);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JAEFHHKBGFN();
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class AGABIHIBGCM<TData> : LDAEHMLLPNH<ADGMGDOPNFB<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x4738D90", Offset = "0x4737990", VA = "0x184738D90")]
	public AGABIHIBGCM(ADGMGDOPNFB<TData> ODPFHLHHEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x4D64CB0", Offset = "0x4D638B0", VA = "0x184D64CB0", Slot = "4")]
	public override bool LGHBMANLFPL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class HJOKPLLHKFN<TData> : LDAEHMLLPNH<ADGMGDOPNFB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly GEBMPMBAJNK DNFMGCDKCHP;

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x4DAFD50", Offset = "0x4DAE950", VA = "0x184DAFD50")]
	public HJOKPLLHKFN(Vector3 BBEBAHDJNGL, bool JJPBAHBHHEB, ADGMGDOPNFB<TData> ODPFHLHHEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x42A0A90", Offset = "0x429F690", VA = "0x1842A0A90", Slot = "4")]
	public override bool LGHBMANLFPL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public class BJAPJFLLNHA<TData> : LDAEHMLLPNH<ADGMGDOPNFB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly HINIJHLKGLN DNFMGCDKCHP;

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6475DE0", Offset = "0x64749E0", VA = "0x186475DE0")]
	public BJAPJFLLNHA(Guid MHBMELJANLD, int EMMACFPOKFB, Vector3 IIBJECFMAJC, Quaternion BFEELDCLMGM, float HPDHPFDMAAO, bool JJPBAHBHHEB, ADGMGDOPNFB<TData> ODPFHLHHEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6475D80", Offset = "0x6474980", VA = "0x186475D80", Slot = "4")]
	public override bool LGHBMANLFPL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class ODCMEKOALLO<TData> : LDAEHMLLPNH<ADGMGDOPNFB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly HKCJMDMPIGG<TData> DNFMGCDKCHP;

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5658F30", Offset = "0x5657B30", VA = "0x185658F30")]
	public ODCMEKOALLO(TData MDKAAPLMLKG, bool DHHANOMNBBI, ADGMGDOPNFB<TData> ODPFHLHHEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x4E74300", Offset = "0x4E72F00", VA = "0x184E74300", Slot = "4")]
	public override bool LGHBMANLFPL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct GEBMPMBAJNK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public readonly Vector3 BBEBAHDJNGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public readonly bool JJPBAHBHHEB;

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7E24330", Offset = "0x7E22F30", VA = "0x187E24330")]
	public GEBMPMBAJNK(Vector3 BBEBAHDJNGL, bool JJPBAHBHHEB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct HINIJHLKGLN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public readonly Guid MHBMELJANLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public readonly int EMMACFPOKFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public readonly Vector3 IIBJECFMAJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public readonly Quaternion BFEELDCLMGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public readonly float HPDHPFDMAAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public readonly bool JJPBAHBHHEB;

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7E24350", Offset = "0x7E22F50", VA = "0x187E24350")]
	public HINIJHLKGLN(Guid MHBMELJANLD, int EMMACFPOKFB, Vector3 IIBJECFMAJC, Quaternion BFEELDCLMGM, float HPDHPFDMAAO, bool JJPBAHBHHEB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public struct HKCJMDMPIGG<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly TData MDKAAPLMLKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public readonly bool DHHANOMNBBI;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x4DAFE90", Offset = "0x4DAEA90", VA = "0x184DAFE90")]
	public HKCJMDMPIGG(TData MDKAAPLMLKG, bool DHHANOMNBBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public interface DHLAAENIOAE<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LGHBMANLFPL([In] HCFCBKFMBFA<TData> KPBPFGINGOA);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LGHBMANLFPL([In] OILFMNBLDBD<TData> KPBPFGINGOA);
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public interface BADPNMJJOCD<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BDANGPKPFHL([In] GNGBBBGOBND<TData> BHNMODHGDGL);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KJJJGOAEKFF([In] IHMFGCFIFIF NCKDEHCKPOK);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JAEFHHKBGFN();
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class OMLGJAPKKMN<TData> : LDAEHMLLPNH<DHLAAENIOAE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly HCFCBKFMBFA<TData> KPBPFGINGOA;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x5687460", Offset = "0x5686060", VA = "0x185687460")]
	public OMLGJAPKKMN(IEnumerable<TData> IJOCDKGENOK, Vector3 FCNPJIOBKHG, bool DHHANOMNBBI, DHLAAENIOAE<TData> ODPFHLHHEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x4E74300", Offset = "0x4E72F00", VA = "0x184E74300", Slot = "4")]
	public override bool LGHBMANLFPL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public class NECJJFBFIFI<TData> : LDAEHMLLPNH<BADPNMJJOCD<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x4738D90", Offset = "0x4737990", VA = "0x184738D90")]
	public NECJJFBFIFI(BADPNMJJOCD<TData> ODPFHLHHEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x4738D40", Offset = "0x4737940", VA = "0x184738D40", Slot = "4")]
	public override bool LGHBMANLFPL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public class NKLBMHIFLNN<TData> : LDAEHMLLPNH<BADPNMJJOCD<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly GNGBBBGOBND<TData> KPBPFGINGOA;

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5527F30", Offset = "0x5526B30", VA = "0x185527F30")]
	public NKLBMHIFLNN(IEnumerable<TData> IJOCDKGENOK, bool DHHANOMNBBI, BADPNMJJOCD<TData> ODPFHLHHEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x4E74300", Offset = "0x4E72F00", VA = "0x184E74300", Slot = "4")]
	public override bool LGHBMANLFPL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class DCNNJPMMPFO<TData> : LDAEHMLLPNH<DHLAAENIOAE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly OILFMNBLDBD<TData> KPBPFGINGOA;

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6B83D80", Offset = "0x6B82980", VA = "0x186B83D80")]
	public DCNNJPMMPFO(IEnumerable<TData> IJOCDKGENOK, Vector3 OOONJFMHCHL, AMBFFADNCBG OHECEMEKJOK, bool DHHANOMNBBI, DHLAAENIOAE<TData> ODPFHLHHEBI, Space JCICOIHHFFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x429FEE0", Offset = "0x429EAE0", VA = "0x18429FEE0", Slot = "4")]
	public override bool LGHBMANLFPL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class GNHKHEIMHEM<TData> : LDAEHMLLPNH<BADPNMJJOCD<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly IHMFGCFIFIF KPBPFGINGOA;

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x4D300B0", Offset = "0x4D2ECB0", VA = "0x184D300B0")]
	public GNHKHEIMHEM(Vector3 FCNPJIOBKHG, BADPNMJJOCD<TData> ODPFHLHHEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x42A0A90", Offset = "0x429F690", VA = "0x1842A0A90", Slot = "4")]
	public override bool LGHBMANLFPL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct HCFCBKFMBFA<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public readonly IEnumerable<TData> IJOCDKGENOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public readonly Vector3 FCNPJIOBKHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public readonly bool DHHANOMNBBI;

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x4D88710", Offset = "0x4D87310", VA = "0x184D88710")]
	public HCFCBKFMBFA(IEnumerable<TData> IJOCDKGENOK, Vector3 FCNPJIOBKHG, bool DHHANOMNBBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public struct GNGBBBGOBND<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public readonly IEnumerable<TData> IJOCDKGENOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public readonly bool DHHANOMNBBI;

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x4D2FAB0", Offset = "0x4D2E6B0", VA = "0x184D2FAB0")]
	public GNGBBBGOBND(IEnumerable<TData> IJOCDKGENOK, bool DHHANOMNBBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public struct OILFMNBLDBD<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public readonly IEnumerable<TData> IJOCDKGENOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public readonly Vector3 OOONJFMHCHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public readonly AMBFFADNCBG OHECEMEKJOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public readonly bool DHHANOMNBBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public readonly Space JCICOIHHFFI;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x566B0F0", Offset = "0x5669CF0", VA = "0x18566B0F0")]
	public OILFMNBLDBD(IEnumerable<TData> IJOCDKGENOK, Vector3 OOONJFMHCHL, AMBFFADNCBG OHECEMEKJOK, bool DHHANOMNBBI, Space JCICOIHHFFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public struct IHMFGCFIFIF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public readonly Vector3 FCNPJIOBKHG;

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x2B6B480", Offset = "0x2B6A080", VA = "0x182B6B480")]
	public IHMFGCFIFIF(Vector3 FCNPJIOBKHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public enum AMBFFADNCBG
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
public interface PMBLEJFOOCD
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LGHBMANLFPL([In] AABGDJGIJKB LOALJMNCLLI);
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public class JDLMGJGPCFI : LDAEHMLLPNH<PMBLEJFOOCD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private readonly AABGDJGIJKB LOALJMNCLLI;

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x7E24600", Offset = "0x7E23200", VA = "0x187E24600")]
	public JDLMGJGPCFI(bool DHHANOMNBBI, PMBLEJFOOCD ODPFHLHHEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x7E24550", Offset = "0x7E23150", VA = "0x187E24550", Slot = "4")]
	public override bool LGHBMANLFPL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public readonly struct AABGDJGIJKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public readonly bool DHHANOMNBBI;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x2B6C480", Offset = "0x2B6B080", VA = "0x182B6C480")]
	public AABGDJGIJKB(bool DHHANOMNBBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public interface KGIDGMLEALM<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LGHBMANLFPL([In] MLFFJOPLPLD<TData> LAHBIIIFIJO);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LGHBMANLFPL([In] JAFMKOENHIN<TData> LAHBIIIFIJO);
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public interface KEGIJJNBBGF<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BDANGPKPFHL([In] NAMHDFMBEHF<TData> OOFLNINPPJI);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KJJJGOAEKFF([In] EFLOMNHIKEF NCKDEHCKPOK);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JAEFHHKBGFN();
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class CJLBPOCHNAI<TData> : LDAEHMLLPNH<KGIDGMLEALM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private readonly MLFFJOPLPLD<TData> LAHBIIIFIJO;

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x69865D0", Offset = "0x69851D0", VA = "0x1869865D0")]
	public CJLBPOCHNAI(IEnumerable<TData> IJOCDKGENOK, Quaternion FCNPJIOBKHG, Vector3? KCIGMHCCENJ, bool ICLHGPNLEKI, bool DHHANOMNBBI, KGIDGMLEALM<TData> ODPFHLHHEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x4E74300", Offset = "0x4E72F00", VA = "0x184E74300", Slot = "4")]
	public override bool LGHBMANLFPL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class FCCFJKOLNPF<TData> : LDAEHMLLPNH<KEGIJJNBBGF<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x4738D90", Offset = "0x4737990", VA = "0x184738D90")]
	public FCCFJKOLNPF(KEGIJJNBBGF<TData> ODPFHLHHEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x4738D40", Offset = "0x4737940", VA = "0x184738D40", Slot = "4")]
	public override bool LGHBMANLFPL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class OCCDBEPLBBI<TData> : LDAEHMLLPNH<KEGIJJNBBGF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private readonly NAMHDFMBEHF<TData> LAHBIIIFIJO;

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x56578B0", Offset = "0x56564B0", VA = "0x1856578B0")]
	public OCCDBEPLBBI(IEnumerable<TData> IJOCDKGENOK, bool DHHANOMNBBI, KEGIJJNBBGF<TData> ODPFHLHHEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x4E74300", Offset = "0x4E72F00", VA = "0x184E74300", Slot = "4")]
	public override bool LGHBMANLFPL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public class DHAEMPFAOMM<TData> : LDAEHMLLPNH<KGIDGMLEALM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly JAFMKOENHIN<TData> LAHBIIIFIJO;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x429FFA0", Offset = "0x429EBA0", VA = "0x18429FFA0")]
	public DHAEMPFAOMM(IEnumerable<TData> IJOCDKGENOK, Quaternion HBMMMHHEJMJ, AMBFFADNCBG DAFMFILCLJH, Vector3? KCIGMHCCENJ, bool ICLHGPNLEKI, bool DHHANOMNBBI, Space JCICOIHHFFI, KGIDGMLEALM<TData> ODPFHLHHEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x429FEE0", Offset = "0x429EAE0", VA = "0x18429FEE0", Slot = "4")]
	public override bool LGHBMANLFPL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public class GEKKHELEKKC<TData> : LDAEHMLLPNH<KEGIJJNBBGF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly EFLOMNHIKEF LAHBIIIFIJO;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x4D09380", Offset = "0x4D07F80", VA = "0x184D09380")]
	public GEKKHELEKKC(Quaternion FCNPJIOBKHG, Vector3? KCIGMHCCENJ, bool ICLHGPNLEKI, KEGIJJNBBGF<TData> ODPFHLHHEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x42A0A90", Offset = "0x429F690", VA = "0x1842A0A90", Slot = "4")]
	public override bool LGHBMANLFPL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct MLFFJOPLPLD<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public readonly IEnumerable<TData> IJOCDKGENOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public readonly Quaternion FCNPJIOBKHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public readonly Vector3? KCIGMHCCENJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public readonly bool ICLHGPNLEKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public readonly bool DHHANOMNBBI;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x54C7520", Offset = "0x54C6120", VA = "0x1854C7520")]
	public MLFFJOPLPLD(IEnumerable<TData> IJOCDKGENOK, Quaternion FCNPJIOBKHG, Vector3? KCIGMHCCENJ, bool ICLHGPNLEKI, bool DHHANOMNBBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public struct NAMHDFMBEHF<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public readonly IEnumerable<TData> IJOCDKGENOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly bool DHHANOMNBBI;

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x55157F0", Offset = "0x55143F0", VA = "0x1855157F0")]
	public NAMHDFMBEHF(IEnumerable<TData> IJOCDKGENOK, bool DHHANOMNBBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct JAFMKOENHIN<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public readonly IEnumerable<TData> IJOCDKGENOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly Quaternion HBMMMHHEJMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public readonly AMBFFADNCBG DAFMFILCLJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public readonly Vector3? KCIGMHCCENJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public readonly bool ICLHGPNLEKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public readonly bool DHHANOMNBBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public readonly Space JCICOIHHFFI;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x50A1090", Offset = "0x509FC90", VA = "0x1850A1090")]
	public JAFMKOENHIN(IEnumerable<TData> IJOCDKGENOK, Quaternion HBMMMHHEJMJ, AMBFFADNCBG DAFMFILCLJH, Vector3? KCIGMHCCENJ, bool ICLHGPNLEKI, bool DHHANOMNBBI, Space JCICOIHHFFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public struct EFLOMNHIKEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public readonly Quaternion FCNPJIOBKHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public readonly Vector3? KCIGMHCCENJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public readonly bool ICLHGPNLEKI;

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x5DD9FC0", Offset = "0x5DD8BC0", VA = "0x185DD9FC0")]
	public EFLOMNHIKEF(Quaternion FCNPJIOBKHG, Vector3? KCIGMHCCENJ, bool ICLHGPNLEKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public interface GPCCMDAHGBL<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BDANGPKPFHL([In] HJEEDHMDAEG<TData> OOFLNINPPJI);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KJJJGOAEKFF([In] EBIBHGMIBED NCKDEHCKPOK);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KJJJGOAEKFF([In] LIPJLOMEJOK NCKDEHCKPOK);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool KJJJGOAEKFF([In] NMIOBGIKBJL NCKDEHCKPOK);

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool JAEFHHKBGFN();
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public class FEBKEIKHKKM<TData> : LDAEHMLLPNH<GPCCMDAHGBL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private readonly NMIOBGIKBJL CCNAFAGOGGP;

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x4BECFC0", Offset = "0x4BEBBC0", VA = "0x184BECFC0")]
	public FEBKEIKHKKM(Vector3 NFINHHHCDHH, float NPEKDNBDINN, Vector3 KCIGMHCCENJ, bool MLJMOIONPEN, bool DCJLGFPJJAD, GPCCMDAHGBL<TData> ODPFHLHHEBI, Space JCICOIHHFFI = Space.Self)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x4BECF60", Offset = "0x4BEBB60", VA = "0x184BECF60", Slot = "4")]
	public override bool LGHBMANLFPL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public class ONECAENLEIO<TData> : LDAEHMLLPNH<GPCCMDAHGBL<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x4738D90", Offset = "0x4737990", VA = "0x184738D90")]
	public ONECAENLEIO(GPCCMDAHGBL<TData> ODPFHLHHEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x5695540", Offset = "0x5694140", VA = "0x185695540", Slot = "4")]
	public override bool LGHBMANLFPL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public class IFMGEODPCAL<TData> : LDAEHMLLPNH<GPCCMDAHGBL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private readonly HJEEDHMDAEG<TData> CCNAFAGOGGP;

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x4E74450", Offset = "0x4E73050", VA = "0x184E74450")]
	public IFMGEODPCAL(IEnumerable<TData> IJOCDKGENOK, bool DHHANOMNBBI, GPCCMDAHGBL<TData> ODPFHLHHEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x4E74300", Offset = "0x4E72F00", VA = "0x184E74300", Slot = "4")]
	public override bool LGHBMANLFPL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public class GKAEGPMAKLO<TData> : LDAEHMLLPNH<GPCCMDAHGBL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private readonly LIPJLOMEJOK CCNAFAGOGGP;

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x4D16CF0", Offset = "0x4D158F0", VA = "0x184D16CF0")]
	public GKAEGPMAKLO(float IPMNGOGHHDE, bool ONECODEHBND, Vector3 KCIGMHCCENJ, GPCCMDAHGBL<TData> ODPFHLHHEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x4D16C30", Offset = "0x4D15830", VA = "0x184D16C30", Slot = "4")]
	public override bool LGHBMANLFPL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public class DIBOPCMBIEE<TData> : LDAEHMLLPNH<GPCCMDAHGBL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly EBIBHGMIBED CCNAFAGOGGP;

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x42A0AF0", Offset = "0x429F6F0", VA = "0x1842A0AF0")]
	public DIBOPCMBIEE(float NPEKDNBDINN, Vector3 KCIGMHCCENJ, GPCCMDAHGBL<TData> ODPFHLHHEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x42A0A90", Offset = "0x429F690", VA = "0x1842A0A90", Slot = "4")]
	public override bool LGHBMANLFPL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public struct NMIOBGIKBJL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public readonly Vector3 NFINHHHCDHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public readonly float NPEKDNBDINN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public readonly Vector3 KCIGMHCCENJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public readonly bool JJPBAHBHHEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public readonly Space JCICOIHHFFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public readonly bool DCJLGFPJJAD;

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x7E251A0", Offset = "0x7E23DA0", VA = "0x187E251A0")]
	public NMIOBGIKBJL(Vector3 NFINHHHCDHH, float NPEKDNBDINN, Vector3 KCIGMHCCENJ, bool JJPBAHBHHEB, bool DJHDADGKDLN, Space JCICOIHHFFI = Space.Self)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public struct HJEEDHMDAEG<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public readonly IEnumerable<TData> IJOCDKGENOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public readonly bool DHHANOMNBBI;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x4DAF4A0", Offset = "0x4DAE0A0", VA = "0x184DAF4A0")]
	public HJEEDHMDAEG(IEnumerable<TData> IJOCDKGENOK, bool DHHANOMNBBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public struct LIPJLOMEJOK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public readonly float IPMNGOGHHDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public readonly bool ONECODEHBND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public readonly Vector3 KCIGMHCCENJ;

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x7E24AA0", Offset = "0x7E236A0", VA = "0x187E24AA0")]
	public LIPJLOMEJOK(float IPMNGOGHHDE, bool ONECODEHBND, Vector3 KCIGMHCCENJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public struct EBIBHGMIBED
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public readonly float NPEKDNBDINN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public readonly Vector3 KCIGMHCCENJ;

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x5D9A490", Offset = "0x5D99090", VA = "0x185D9A490")]
	public EBIBHGMIBED(float NPEKDNBDINN, Vector3 KCIGMHCCENJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public struct EHKOBILODJM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public readonly Guid[] IJOCDKGENOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public readonly bool IELEIJDDOAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public readonly bool LAEHIMFNGGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public readonly bool CGHNIBGNFIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public readonly Vector3[] MELBCIANJAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public readonly Quaternion[] AOOLDADPHOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public readonly float[] OCNCEPFONGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public readonly Dictionary<Guid, Vector3> ODLIIDOKCCH;

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x7E240A0", Offset = "0x7E22CA0", VA = "0x187E240A0")]
	public EHKOBILODJM(Guid[] DBABNOKPHJO, Vector3[] MELBCIANJAL, Quaternion[] AOOLDADPHOF, float[] OCNCEPFONGG, Dictionary<Guid, Vector3> ODLIIDOKCCH, bool IELEIJDDOAL = true, bool LAEHIMFNGGK = true, bool CGHNIBGNFIH = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7E23ED0", Offset = "0x7E22AD0", VA = "0x187E23ED0")]
	private static void LPDALCKJKPP(Dictionary<Guid, Vector3> ODLIIDOKCCH, int BENECPLONLJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public static class MCGFBBEJOLO
{
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	private struct IBDDEDMEBEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public bool NKGIAPOMHGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public PFGPAPHADOM HJDFIGODBDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public PFGPAPHADOM IKPKFBKFLGN;
	}

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private static IBDDEDMEBEI CNKMKOIJHBL;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static CancellationToken KCBLNLMAMKI
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x7E24AC0", Offset = "0x7E236C0", VA = "0x187E24AC0")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	internal static PFGPAPHADOM HJDFIGODBDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x7E24AE0", Offset = "0x7E236E0", VA = "0x187E24AE0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x7E24CC0", Offset = "0x7E238C0", VA = "0x187E24CC0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x7E24B80", Offset = "0x7E23780", VA = "0x187E24B80")]
	[IGNGJLOKDFM.NGODLIIFCIB]
	internal static void FPIMJJMHECA(PFGPAPHADOM OJDMLNFOHGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x7E24D20", Offset = "0x7E23920", VA = "0x187E24D20")]
	public static void NFHAHJGCAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x7E24C70", Offset = "0x7E23870", VA = "0x187E24C70")]
	private static PFGPAPHADOM JAIEOBEJHIP(PFGPAPHADOM OPPNLIGHFDB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public static class EGFOHOLGCJH
{
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	public enum COMPKIHMIMD
	{
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		ICreationContextObject,
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		Guid
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x390C1C0", Offset = "0x390ADC0", VA = "0x18390C1C0")]
	public static void CHBMIIAAHGL<T>(T KLHINJJCPGC, COMPKIHMIMD OPOPAMPKKGD) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x390C160", Offset = "0x390AD60", VA = "0x18390C160")]
	public static void CHBMIIAAHGL<T>(T KLHINJJCPGC) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x390C080", Offset = "0x390AC80", VA = "0x18390C080")]
	public static void CHBMIIAAHGL<T, TImpl, T>() where T : class where TImpl : notnull, T where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x390C300", Offset = "0x390AF00", VA = "0x18390C300")]
	public static void DELJELPIEBK<T>(T KLHINJJCPGC) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x390C3B0", Offset = "0x390AFB0", VA = "0x18390C3B0")]
	public static T LBDBFELEJGA<T>(COMPKIHMIMD OPOPAMPKKGD) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x390C590", Offset = "0x390B190", VA = "0x18390C590")]
	public static bool OMPOHNEBOIH<T>(COMPKIHMIMD OPOPAMPKKGD, T? PAGDOLJEGMI, [Out][NotNullWhen(true)][MaybeNullWhen(false)] T GCICCPALKDD) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x390BF80", Offset = "0x390AB80", VA = "0x18390BF80")]
	public static bool AILJPPIPHAF<T>(COMPKIHMIMD OPOPAMPKKGD, [Out][NotNullWhen(true)][MaybeNullWhen(false)] T HBOHKGBBPPF) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x390C450", Offset = "0x390B050", VA = "0x18390C450")]
	public static bool MDOELMBDGJK<T>(COMPKIHMIMD OPOPAMPKKGD) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x390C370", Offset = "0x390AF70", VA = "0x18390C370")]
	public static T LBDBFELEJGA<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x390C4F0", Offset = "0x390B0F0", VA = "0x18390C4F0")]
	public static bool OMPOHNEBOIH<T>(T PAGDOLJEGMI, [Out] T GCICCPALKDD) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x390C370", Offset = "0x390AF70", VA = "0x18390C370")]
	public static bool MDOELMBDGJK<T>() where T : class
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
internal static class NJBDFFDINFD
{
	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x7E24F70", Offset = "0x7E23B70", VA = "0x187E24F70")]
	public static void BNKEOKLCNLF(IEnumerable AECJEHIIHIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x3C3FFF0", Offset = "0x3C3EBF0", VA = "0x183C3FFF0")]
	public static void BNKEOKLCNLF<T>(T[] IKALPCJBCLK) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x3C401D0", Offset = "0x3C3EDD0", VA = "0x183C401D0")]
	public static void BNKEOKLCNLF<T>(T NBOMHMDCNPE) where T : notnull, Enum
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
