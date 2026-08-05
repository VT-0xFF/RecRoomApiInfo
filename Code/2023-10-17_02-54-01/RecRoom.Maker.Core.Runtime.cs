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
		[Cpp2IlInjected.Address(RVA = "0x78CB70", Offset = "0x78B370", VA = "0x18078CB70")]
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
		[Cpp2IlInjected.Address(RVA = "0x5D02AA0", Offset = "0x5D012A0", VA = "0x185D02AA0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x78D440", Offset = "0x78BC40", VA = "0x18078D440")]
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
		[Cpp2IlInjected.Address(RVA = "0x78D480", Offset = "0x78BC80", VA = "0x18078D480")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface HHKIMDBAIIL<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ClearHoverTarget(IPCCGGHPPBB MALCGCJDOHD);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool SetHoverTarget(TData KMJKCJJHEFM, Collider BJIDMFJACFC, IPCCGGHPPBB MALCGCJDOHD, [Optional] BCDACAGAFEG? GKHLBLMODFO);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool TryGetHoverTarget([Out] TData KMJKCJJHEFM);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface BNHJFPGBCHL<TData> : EBHKBHMLECJ, GFDJNOLIGCF<TData>, GLCLHBCMBPA<TData>, ENGHPCHBHIA<TData>, LHHMHOJEPDH, DEFLAAKELHF<TData>, PDNCJJEBAHK, OCBCHPCKAHC
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface DEFLAAKELHF<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 DPIMNMEPENP, Vector3 GJMNPFFBJPA, float LNHOFLIBFND, [Out] T MPJJMBLGPID, [Out] Vector3 BGKIELOLGGM, [Out] Collider BJIDMFJACFC);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 DPIMNMEPENP, Vector3 GJMNPFFBJPA, float HFEGPHIFHDA, float LNHOFLIBFND, T[] KEIAELBFNEF, [Out] Vector3 NPBANJPIIFP, [Out] Collider AMKBPDAIDFK);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 DPIMNMEPENP, float HFEGPHIFHDA, Vector3 HJDGPIBKHKI, T[] KEIAELBFNEF);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface EBHKBHMLECJ
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Bounds DPBOLCLPKIF
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Transform DNMLCMCDCKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Bounds ACKBLBAHKNO
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Transform KBANMDEJKCG
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Vector3 LLEAAGEKMLI
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void SetSelectionBoundsDirty(bool DGMPHEPPMEI = true, int JKPOFCEFENH = 0);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ShouldHideSelectionBoundsPreview(bool LFDEBLNHEHD, object KIAKEGJPMAL);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface OCBCHPCKAHC
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	BJPMGBAMGNN NOFEDCJBFLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface ENGHPCHBHIA<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool AMCFLECDBGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	int GMEJJALMFOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	IEnumerable<TData> GPBJOKLBHMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData BBKHFDEMMEH);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData BBKHFDEMMEH);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface GFDJNOLIGCF<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T CBBCDNDPNHF, [Optional] BCDACAGAFEG? KBLMGJFMDNH, bool COPLJHEKJOD = true);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int EHGKBCBKPCI, IEnumerable<T> ANFFPMOOHGF, bool COPLJHEKJOD = true);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int EHGKBCBKPCI, IEnumerable<T> ANFFPMOOHGF, BCDACAGAFEG KBLMGJFMDNH, bool COPLJHEKJOD = true);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface PDNCJJEBAHK
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface LHHMHOJEPDH
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool LOFGCLJMIGH
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool PJPDIJPLGBO
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool LAGCPBEHANM
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool IJFALOCDFEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class PBANJEPAJDJ<TReceiver> : DGOMDGIOHLH<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3055D30", Offset = "0x3054530", VA = "0x183055D30")]
	public PBANJEPAJDJ(TReceiver PPKFMHJLLNO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public abstract class GGDGOIKHKCM<TReceiver, TFromTask> : DGOMDGIOHLH<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3055D30", Offset = "0x3054530", VA = "0x183055D30")]
	public GGDGOIKHKCM(TReceiver PPKFMHJLLNO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class DGOMDGIOHLH<TReceiver, TFromExecute> where TReceiver : notnull where TFromExecute : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	protected TReceiver PPKFMHJLLNO;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4D17BC0", Offset = "0x4D163C0", VA = "0x184D17BC0")]
	public DGOMDGIOHLH(TReceiver PPKFMHJLLNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute HPKKAMDMNCC();
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct LJKEKBHHFFC<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public TNode OBIBJHMMOFH;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3923E20", Offset = "0x3922620", VA = "0x183923E20")]
	public LJKEKBHHFFC(TNode OBIBJHMMOFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct KJKLDEENPFP<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public TNode GBEBKALIKKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public KDPMNIECBBO KBEJFFKGFIA;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x387A390", Offset = "0x3878B90", VA = "0x18387A390")]
	public KJKLDEENPFP(TNode GBEBKALIKKN, KDPMNIECBBO KBEJFFKGFIA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface HBPGHLCPEJN<TNode>
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AINHPANKAGK([In] LJKEKBHHFFC<TNode> HBLHPPGCLHC);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LIOCMBIGIBG([In] KJKLDEENPFP<TNode> DFLKPMOAENK);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GOIAFMLNEEP();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class LKHFBDAHIDE<TNode> : PBANJEPAJDJ<HBPGHLCPEJN<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3055D30", Offset = "0x3054530", VA = "0x183055D30")]
	public LKHFBDAHIDE(HBPGHLCPEJN<TNode> PPKFMHJLLNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3907240", Offset = "0x3905A40", VA = "0x183907240", Slot = "4")]
	public override bool HPKKAMDMNCC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class OOPLKJOAJLC<TNode> : PBANJEPAJDJ<HBPGHLCPEJN<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly KJKLDEENPFP<TNode> DFLKPMOAENK;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3D1B620", Offset = "0x3D19E20", VA = "0x183D1B620")]
	public OOPLKJOAJLC(TNode GBEBKALIKKN, KDPMNIECBBO KBEJFFKGFIA, HBPGHLCPEJN<TNode> PPKFMHJLLNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3624420", Offset = "0x3622C20", VA = "0x183624420", Slot = "4")]
	public override bool HPKKAMDMNCC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class OLDHEBHOCGI<TNode> : PBANJEPAJDJ<HBPGHLCPEJN<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly LJKEKBHHFFC<TNode> HBLHPPGCLHC;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3CEBA10", Offset = "0x3CEA210", VA = "0x183CEBA10")]
	public OLDHEBHOCGI(TNode HJJMDFJDDLA, HBPGHLCPEJN<TNode> PPKFMHJLLNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3057C50", Offset = "0x3056450", VA = "0x183057C50", Slot = "4")]
	public override bool HPKKAMDMNCC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct KDIAHKPHCHI<TSpawnInfo> where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public TSpawnInfo ADHLBGDIPBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public Vector3 MCLBBPPAHAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public Quaternion OHMBDAJNEIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public float DCPNEEKOHBH;

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0xD5AF20", Offset = "0xD59720", VA = "0x180D5AF20")]
	public KDIAHKPHCHI(TSpawnInfo ADHLBGDIPBI, Vector3 MCLBBPPAHAP, Quaternion OHMBDAJNEIJ, float DCPNEEKOHBH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface FHGOEHGMNOF<TSpawnType, TSpawnInfo>
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> ONDKNMKBLKN([In] KDIAHKPHCHI<TSpawnInfo> MLAEDNACHJD, CancellationToken EHCFBFBFEDH);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class JPALBMKEMBI<TSpawnType, TSpawnInfo> : GGDGOIKHKCM<FHGOEHGMNOF<TSpawnType, TSpawnInfo>, TSpawnType> where TSpawnType : notnull where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly KDIAHKPHCHI<TSpawnInfo> CCBNPDAGICC;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3829880", Offset = "0x3828080", VA = "0x183829880")]
	public JPALBMKEMBI(TSpawnInfo BEDMCKNGEIA, Vector3 MCLBBPPAHAP, Quaternion OHMBDAJNEIJ, float DCPNEEKOHBH, FHGOEHGMNOF<TSpawnType, TSpawnInfo> PPKFMHJLLNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x38296B0", Offset = "0x3827EB0", VA = "0x1838296B0", Slot = "4")]
	public override Task<TSpawnType> HPKKAMDMNCC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public readonly struct NHFCDAEKODE<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly IEnumerable<TData> MFDFBFIICMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public readonly bool GPCHHHOJJOM;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3BBF4C0", Offset = "0x3BBDCC0", VA = "0x183BBF4C0")]
	public NHFCDAEKODE(IEnumerable<TData> AHJOPNICLKF, bool BJBNPAGLLJM = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface PAJEOFHLHDN<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<PAPOFIBDOFD> JFKNLAAJLDI([In] NHFCDAEKODE<TData> GAAKHIHBGMB, CancellationToken EHCFBFBFEDH);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class DOJCFNPIDBL<TData> : GGDGOIKHKCM<PAJEOFHLHDN<TData>, PAPOFIBDOFD> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly NHFCDAEKODE<TData> NFELKNFCBFI;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4D202A0", Offset = "0x4D1EAA0", VA = "0x184D202A0")]
	public DOJCFNPIDBL(IEnumerable<TData> AHJOPNICLKF, bool BJBNPAGLLJM, PAJEOFHLHDN<TData> PPKFMHJLLNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x38296B0", Offset = "0x3827EB0", VA = "0x1838296B0", Slot = "4")]
	public override Task<PAPOFIBDOFD> HPKKAMDMNCC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct IBMFFJGCBJA<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly T KMJKCJJHEFM;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3620D50", Offset = "0x361F550", VA = "0x183620D50")]
	public IBMFFJGCBJA(T KEEDAFGBEKP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface JDILJAFNCOF<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AINHPANKAGK([In] IBMFFJGCBJA<T> PGDJNJJOEGC);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LIOCMBIGIBG();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface HOLGDPMFJOK<T>
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HPKKAMDMNCC([In] CCANJEDALDL<T> NOLLNBKCPPM);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct CCANJEDALDL<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly T KMJKCJJHEFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly bool KLBOOEHBCAF;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4A86C90", Offset = "0x4A85490", VA = "0x184A86C90")]
	public CCANJEDALDL(T KEEDAFGBEKP, bool IMDLBKPFDEM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class BBCLDBHEJFA<T> : PBANJEPAJDJ<JDILJAFNCOF<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3055D30", Offset = "0x3054530", VA = "0x183055D30")]
	public BBCLDBHEJFA(JDILJAFNCOF<T> PPKFMHJLLNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3B847B0", Offset = "0x3B82FB0", VA = "0x183B847B0", Slot = "4")]
	public override bool HPKKAMDMNCC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class OPJIIAENEGH<T> : PBANJEPAJDJ<JDILJAFNCOF<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly IBMFFJGCBJA<T> PGDJNJJOEGC;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3D1B6B0", Offset = "0x3D19EB0", VA = "0x183D1B6B0")]
	public OPJIIAENEGH(T KMJKCJJHEFM, JDILJAFNCOF<T> PPKFMHJLLNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3057C50", Offset = "0x3056450", VA = "0x183057C50", Slot = "4")]
	public override bool HPKKAMDMNCC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class GABFMDIDGAI<T> : PBANJEPAJDJ<HOLGDPMFJOK<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly CCANJEDALDL<T> NOLLNBKCPPM;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x34CA140", Offset = "0x34C8940", VA = "0x1834CA140")]
	public GABFMDIDGAI(T KMJKCJJHEFM, bool IMDLBKPFDEM, HOLGDPMFJOK<T> PPKFMHJLLNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3057C50", Offset = "0x3056450", VA = "0x183057C50", Slot = "4")]
	public override bool HPKKAMDMNCC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct BNHBMBONMAC<TData> where TData : notnull, LHIBJFPCMLD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public IEnumerable<TData> MFDFBFIICMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public bool OGNFDOKFNDP;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4893550", Offset = "0x4891D50", VA = "0x184893550")]
	public BNHBMBONMAC(IEnumerable<TData> KGKEPJIEJIJ, bool MJAFOIBKOLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct CBGHPINPBIN<TData> where TData : notnull, LHIBJFPCMLD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public List<TData> MFDFBFIICMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public List<bool> BPJCCPDDEDI;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4A85290", Offset = "0x4A83A90", VA = "0x184A85290")]
	public CBGHPINPBIN(List<TData> KGKEPJIEJIJ, List<bool> BNCPODDHLDI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface LHIBJFPCMLD
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool CPBONOIHLMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface EBMLPDGMJFH<TData> where TData : LHIBJFPCMLD
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HPKKAMDMNCC([In] BNHBMBONMAC<TData> AFJDBGOEJOP);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HPKKAMDMNCC([In] CBGHPINPBIN<TData> AFJDBGOEJOP);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class JDBPNNBNJAB<TData> : PBANJEPAJDJ<EBMLPDGMJFH<TData>> where TData : notnull, LHIBJFPCMLD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly BNHBMBONMAC<TData> AFJDBGOEJOP;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x37E6C40", Offset = "0x37E5440", VA = "0x1837E6C40")]
	public JDBPNNBNJAB(List<TData> AHJOPNICLKF, bool OGNFDOKFNDP, EBMLPDGMJFH<TData> PPKFMHJLLNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3057C50", Offset = "0x3056450", VA = "0x183057C50", Slot = "4")]
	public override bool HPKKAMDMNCC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class IJMNDCLBCFF<TData> : PBANJEPAJDJ<EBMLPDGMJFH<TData>> where TData : notnull, LHIBJFPCMLD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly CBGHPINPBIN<TData> AFJDBGOEJOP;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3648AF0", Offset = "0x36472F0", VA = "0x183648AF0")]
	public IJMNDCLBCFF(List<TData> AHJOPNICLKF, List<bool> BPJCCPDDEDI, EBMLPDGMJFH<TData> PPKFMHJLLNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3648A30", Offset = "0x3647230", VA = "0x183648A30", Slot = "4")]
	public override bool HPKKAMDMNCC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface IJDFDCKFHFC : LHIBJFPCMLD
{
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface FCGPMBNKPAO<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<PAPOFIBDOFD> HPKKAMDMNCC(BODMBFKHPCC<TData> KAOCPMDADHH);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class JGLFEFILIIK<TData> : GGDGOIKHKCM<FCGPMBNKPAO<TData>, PAPOFIBDOFD> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct EJDGCDEKFEC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public AsyncTaskMethodBuilder<PAPOFIBDOFD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public JGLFEFILIIK<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private TaskAwaiter<PAPOFIBDOFD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x3072F80", Offset = "0x3071780", VA = "0x183072F80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x3073270", Offset = "0x3071A70", VA = "0x183073270", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly BODMBFKHPCC<TData> NCKKMHEOICD;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x37F6640", Offset = "0x37F4E40", VA = "0x1837F6640")]
	public JGLFEFILIIK(TData EIJNICONLJD, IReadOnlyList<TData> DNKKHADOIPF, bool BJBNPAGLLJM, FCGPMBNKPAO<TData> PPKFMHJLLNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x37F6540", Offset = "0x37F4D40", VA = "0x1837F6540", Slot = "4")]
	[AsyncStateMachine(typeof(JGLFEFILIIK<>.EJDGCDEKFEC))]
	public override Task<PAPOFIBDOFD> HPKKAMDMNCC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct BODMBFKHPCC<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public TData DDGHBKAKPHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public IReadOnlyList<TData> MILKCKMJNKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public bool GPCHHHOJJOM;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x42718F0", Offset = "0x42700F0", VA = "0x1842718F0")]
	public BODMBFKHPCC(TData EIJNICONLJD, IReadOnlyList<TData> DNKKHADOIPF, bool BJBNPAGLLJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface KEPPFEPEKCK<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HPKKAMDMNCC([In] EHMHCONMHOI<TData> FDJFCNNMGJO);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface FNLJMDKCJIO<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HPKKAMDMNCC([In] KIFCLGDBGJB<TData> FDJFCNNMGJO);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface IPEHJKELAJO<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PHKPJABPGII([In] BDADDAIMDIP<TData> FDJFCNNMGJO);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LIOCMBIGIBG();
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public class PKHBHPIGFDM<TData> : PBANJEPAJDJ<KEPPFEPEKCK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly EHMHCONMHOI<TData> FDJFCNNMGJO;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3DBA090", Offset = "0x3DB8890", VA = "0x183DBA090")]
	public PKHBHPIGFDM(IEnumerable<TData> AHJOPNICLKF, JEDEOHKCICL MOJKBHCPNEF, OFBGHIABOOI JGLFCCBLACF, float IMLDEPNDAFE, bool BJBNPAGLLJM, KEPPFEPEKCK<TData> PPKFMHJLLNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3057C50", Offset = "0x3056450", VA = "0x183057C50", Slot = "4")]
	public override bool HPKKAMDMNCC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class CPFJJPCKJIA<TData> : PBANJEPAJDJ<FNLJMDKCJIO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly KIFCLGDBGJB<TData> FDJFCNNMGJO;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x4B7D120", Offset = "0x4B7B920", VA = "0x184B7D120")]
	public CPFJJPCKJIA(TData[] AHJOPNICLKF, JEDEOHKCICL[] MOJKBHCPNEF, OFBGHIABOOI[] JGLFCCBLACF, float[] IMLDEPNDAFE, FNLJMDKCJIO<TData> PPKFMHJLLNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x4A98970", Offset = "0x4A97170", VA = "0x184A98970", Slot = "4")]
	public override bool HPKKAMDMNCC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class ODGNDDMHOIB<TData> : PBANJEPAJDJ<IPEHJKELAJO<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3055D30", Offset = "0x3054530", VA = "0x183055D30")]
	public ODGNDDMHOIB(IPEHJKELAJO<TData> PPKFMHJLLNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3CCC640", Offset = "0x3CCAE40", VA = "0x183CCC640", Slot = "4")]
	public override bool HPKKAMDMNCC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class CDBAEGLKLGJ<TData> : PBANJEPAJDJ<IPEHJKELAJO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly BDADDAIMDIP<TData> FDJFCNNMGJO;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x4A98A30", Offset = "0x4A97230", VA = "0x184A98A30")]
	public CDBAEGLKLGJ(IEnumerable<TData> AHJOPNICLKF, JEDEOHKCICL MOJKBHCPNEF, OFBGHIABOOI JGLFCCBLACF, float IMLDEPNDAFE, IPEHJKELAJO<TData> PPKFMHJLLNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x4A98970", Offset = "0x4A97170", VA = "0x184A98970", Slot = "4")]
	public override bool HPKKAMDMNCC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct EHMHCONMHOI<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public IEnumerable<TData> MFDFBFIICMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public JEDEOHKCICL LMLJLPKFPPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public OFBGHIABOOI LBHOMMLGFDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public float IMLDEPNDAFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public bool BJBNPAGLLJM;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3070910", Offset = "0x306F110", VA = "0x183070910")]
	public EHMHCONMHOI(IEnumerable<TData> AHJOPNICLKF, JEDEOHKCICL MOJKBHCPNEF, OFBGHIABOOI JGLFCCBLACF, float IMLDEPNDAFE, bool BJBNPAGLLJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct KIFCLGDBGJB<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public TData[] MFDFBFIICMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public JEDEOHKCICL[] LMLJLPKFPPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public OFBGHIABOOI[] LBHOMMLGFDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public float[] IMLDEPNDAFE;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x38768D0", Offset = "0x38750D0", VA = "0x1838768D0")]
	public KIFCLGDBGJB(TData[] AHJOPNICLKF, JEDEOHKCICL[] MOJKBHCPNEF, OFBGHIABOOI[] JGLFCCBLACF, float[] IMLDEPNDAFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct BDADDAIMDIP<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public IEnumerable<TData> MFDFBFIICMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public JEDEOHKCICL LMLJLPKFPPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public OFBGHIABOOI LBHOMMLGFDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public float IMLDEPNDAFE;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x43E7410", Offset = "0x43E5C10", VA = "0x1843E7410")]
	public BDADDAIMDIP(IEnumerable<TData> AHJOPNICLKF, JEDEOHKCICL MOJKBHCPNEF, OFBGHIABOOI JGLFCCBLACF, float IMLDEPNDAFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface GLCLHBCMBPA<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JGIKNFKMGOD([In] CLNHCOLJMGC<TData> GAAKHIHBGMB);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FCPLMCDOPMI([In] CLNHCOLJMGC<TData> GAAKHIHBGMB);

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LGPAIFGHPMC([In] bool IOJEDAEKFJL);

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool ODEIDKPIHLK([In] CLNHCOLJMGC<TData> GAAKHIHBGMB);

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IAILIAPJGKL();

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool FKBKFGELPLG([In] TData NPILHMOKCII);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class FGAPCPKEALM<TData> : PBANJEPAJDJ<GLCLHBCMBPA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly CLNHCOLJMGC<TData> GAAKHIHBGMB;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x340E2A0", Offset = "0x340CAA0", VA = "0x18340E2A0")]
	public FGAPCPKEALM(List<TData> GINKMKLCKOH, GLCLHBCMBPA<TData> PPKFMHJLLNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x3057C50", Offset = "0x3056450", VA = "0x183057C50", Slot = "4")]
	public override bool HPKKAMDMNCC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class GGKGLLDGEMA<TData> : PBANJEPAJDJ<GLCLHBCMBPA<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x3055D30", Offset = "0x3054530", VA = "0x183055D30")]
	public GGKGLLDGEMA(GLCLHBCMBPA<TData> PPKFMHJLLNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x34E0290", Offset = "0x34DEA90", VA = "0x1834E0290", Slot = "4")]
	public override bool HPKKAMDMNCC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class EOGABGNMBMC<TData> : PBANJEPAJDJ<GLCLHBCMBPA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly bool BJBNPAGLLJM;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x30A4860", Offset = "0x30A3060", VA = "0x1830A4860")]
	public EOGABGNMBMC(bool BJBNPAGLLJM, GLCLHBCMBPA<TData> PPKFMHJLLNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x30A4800", Offset = "0x30A3000", VA = "0x1830A4800", Slot = "4")]
	public override bool HPKKAMDMNCC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class JDAGDHHCJIH<TData> : PBANJEPAJDJ<GLCLHBCMBPA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly CLNHCOLJMGC<TData> GAAKHIHBGMB;

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x37E6BB0", Offset = "0x37E53B0", VA = "0x1837E6BB0")]
	public JDAGDHHCJIH(List<TData> GINKMKLCKOH, bool BJBNPAGLLJM, GLCLHBCMBPA<TData> PPKFMHJLLNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x3648A30", Offset = "0x3647230", VA = "0x183648A30", Slot = "4")]
	public override bool HPKKAMDMNCC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class OFEHIJIENBC<TData> : PBANJEPAJDJ<GLCLHBCMBPA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly TData NPILHMOKCII;

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x3CD3D30", Offset = "0x3CD2530", VA = "0x183CD3D30")]
	public OFEHIJIENBC(TData NPILHMOKCII, GLCLHBCMBPA<TData> PPKFMHJLLNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x3CD3C60", Offset = "0x3CD2460", VA = "0x183CD3C60", Slot = "4")]
	public override bool HPKKAMDMNCC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class ILIOBDPNAEP<TData> : PBANJEPAJDJ<GLCLHBCMBPA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly CLNHCOLJMGC<TData> GAAKHIHBGMB;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x364FAF0", Offset = "0x364E2F0", VA = "0x18364FAF0")]
	public ILIOBDPNAEP(List<TData> GINKMKLCKOH, GLCLHBCMBPA<TData> PPKFMHJLLNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x364F990", Offset = "0x364E190", VA = "0x18364F990", Slot = "4")]
	public override bool HPKKAMDMNCC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public struct CLNHCOLJMGC<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public IEnumerable<TData> MFDFBFIICMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public bool BJBNPAGLLJM;

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x4B71EC0", Offset = "0x4B706C0", VA = "0x184B71EC0")]
	public CLNHCOLJMGC(IEnumerable<TData> KGKEPJIEJIJ, bool KECOCAPHCOB = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface GFHCKBPHNOP
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<PAPOFIBDOFD> HPKKAMDMNCC(GKOJIEIFACF DDGJLJIOAOO);
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class MLHPCNIFGCP : GGDGOIKHKCM<GFHCKBPHNOP, PAPOFIBDOFD>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private struct IKIKBOLOEIH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<PAPOFIBDOFD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public MLHPCNIFGCP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private TaskAwaiter<PAPOFIBDOFD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x5D025F0", Offset = "0x5D00DF0", VA = "0x185D025F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x5D02870", Offset = "0x5D01070", VA = "0x185D02870", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly GKOJIEIFACF EJFMHAIFHPK;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5D02A00", Offset = "0x5D01200", VA = "0x185D02A00")]
	public MLHPCNIFGCP(bool BJBNPAGLLJM, GFHCKBPHNOP PPKFMHJLLNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5D02910", Offset = "0x5D01110", VA = "0x185D02910", Slot = "4")]
	[AsyncStateMachine(typeof(IKIKBOLOEIH))]
	public override Task<PAPOFIBDOFD> HPKKAMDMNCC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public struct GKOJIEIFACF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public bool GPCHHHOJJOM;

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0xB25330", Offset = "0xB23B30", VA = "0x180B25330")]
	public GKOJIEIFACF(bool BJBNPAGLLJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface NKLPBDKKNCK<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AINHPANKAGK([In] EMGBGEGHENM<TData> HBLHPPGCLHC);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PHKPJABPGII([In] EAHPBNOMLOB HMBBAMECGIP);

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PHKPJABPGII([In] MMOCEEFILIG HMBBAMECGIP);

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool LIOCMBIGIBG();
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class FJOJOJJAEFI<TData> : PBANJEPAJDJ<NKLPBDKKNCK<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x3055D30", Offset = "0x3054530", VA = "0x183055D30")]
	public FJOJOJJAEFI(NKLPBDKKNCK<TData> PPKFMHJLLNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x3422B60", Offset = "0x3421360", VA = "0x183422B60", Slot = "4")]
	public override bool HPKKAMDMNCC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class NAMKADICGCI<TData> : PBANJEPAJDJ<NKLPBDKKNCK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly EAHPBNOMLOB MDAGLMANODG;

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x3B96D80", Offset = "0x3B95580", VA = "0x183B96D80")]
	public NAMKADICGCI(Vector3 AOOJMJBPKBH, bool GKJDIPIJNKF, NKLPBDKKNCK<TData> PPKFMHJLLNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x3AF0E50", Offset = "0x3AEF650", VA = "0x183AF0E50", Slot = "4")]
	public override bool HPKKAMDMNCC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class JEMLHDFNPBB<TData> : PBANJEPAJDJ<NKLPBDKKNCK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly MMOCEEFILIG MDAGLMANODG;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x37F0650", Offset = "0x37EEE50", VA = "0x1837F0650")]
	public JEMLHDFNPBB(Guid GJPJPMIBLHC, int LFEFGCGCIAG, Vector3 MCLBBPPAHAP, Quaternion OHMBDAJNEIJ, float PNEBFNHCLKM, bool GKJDIPIJNKF, NKLPBDKKNCK<TData> PPKFMHJLLNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x37F05F0", Offset = "0x37EEDF0", VA = "0x1837F05F0", Slot = "4")]
	public override bool HPKKAMDMNCC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class EDCDDFDKHKE<TData> : PBANJEPAJDJ<NKLPBDKKNCK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly EMGBGEGHENM<TData> MDAGLMANODG;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3057D10", Offset = "0x3056510", VA = "0x183057D10")]
	public EDCDDFDKHKE(TData KMJKCJJHEFM, bool BJBNPAGLLJM, NKLPBDKKNCK<TData> PPKFMHJLLNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x3057C50", Offset = "0x3056450", VA = "0x183057C50", Slot = "4")]
	public override bool HPKKAMDMNCC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public struct EAHPBNOMLOB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly Vector3 AOOJMJBPKBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly bool GKJDIPIJNKF;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5D023A0", Offset = "0x5D00BA0", VA = "0x185D023A0")]
	public EAHPBNOMLOB(Vector3 AOOJMJBPKBH, bool GKJDIPIJNKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct MMOCEEFILIG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly Guid GJPJPMIBLHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly int LFEFGCGCIAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly Vector3 MCLBBPPAHAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly Quaternion OHMBDAJNEIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly float PNEBFNHCLKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly bool GKJDIPIJNKF;

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5D02A60", Offset = "0x5D01260", VA = "0x185D02A60")]
	public MMOCEEFILIG(Guid GJPJPMIBLHC, int LFEFGCGCIAG, Vector3 MCLBBPPAHAP, Quaternion OHMBDAJNEIJ, float PNEBFNHCLKM, bool GKJDIPIJNKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public struct EMGBGEGHENM<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly TData KMJKCJJHEFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly bool BJBNPAGLLJM;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x309D450", Offset = "0x309BC50", VA = "0x18309D450")]
	public EMGBGEGHENM(TData KMJKCJJHEFM, bool BJBNPAGLLJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public interface KCMBLLDCFPL<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HPKKAMDMNCC([In] PHKFPKJDCJK<TData> GHBCHHNPEOF);

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HPKKAMDMNCC([In] BOENLHMLACL<TData> GHBCHHNPEOF);
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface GOJLCOLIGMA<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AINHPANKAGK([In] PNCMLBBOFCD<TData> JEGAKCKDNDB);

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PHKPJABPGII([In] FJLAIKJHCMF HMBBAMECGIP);

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LIOCMBIGIBG();
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class PBMBDMLCBIC<TData> : PBANJEPAJDJ<KCMBLLDCFPL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly PHKFPKJDCJK<TData> GHBCHHNPEOF;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x3DA3840", Offset = "0x3DA2040", VA = "0x183DA3840")]
	public PBMBDMLCBIC(IEnumerable<TData> AHJOPNICLKF, Vector3 MAAOFEBIKAF, bool BJBNPAGLLJM, KCMBLLDCFPL<TData> PPKFMHJLLNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x3057C50", Offset = "0x3056450", VA = "0x183057C50", Slot = "4")]
	public override bool HPKKAMDMNCC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class LAOLNEOAMMC<TData> : PBANJEPAJDJ<GOJLCOLIGMA<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x3055D30", Offset = "0x3054530", VA = "0x183055D30")]
	public LAOLNEOAMMC(GOJLCOLIGMA<TData> PPKFMHJLLNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x3907240", Offset = "0x3905A40", VA = "0x183907240", Slot = "4")]
	public override bool HPKKAMDMNCC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class ILPIKAFNMFA<TData> : PBANJEPAJDJ<GOJLCOLIGMA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly PNCMLBBOFCD<TData> GHBCHHNPEOF;

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3650DB0", Offset = "0x364F5B0", VA = "0x183650DB0")]
	public ILPIKAFNMFA(IEnumerable<TData> AHJOPNICLKF, bool BJBNPAGLLJM, GOJLCOLIGMA<TData> PPKFMHJLLNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3057C50", Offset = "0x3056450", VA = "0x183057C50", Slot = "4")]
	public override bool HPKKAMDMNCC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class ICOAPEANGMA<TData> : PBANJEPAJDJ<KCMBLLDCFPL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly BOENLHMLACL<TData> GHBCHHNPEOF;

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x36244F0", Offset = "0x3622CF0", VA = "0x1836244F0")]
	public ICOAPEANGMA(IEnumerable<TData> AHJOPNICLKF, Vector3 OGOIHAMBBGB, NPPIDMBFKHD ABMIAJHBEDB, bool BJBNPAGLLJM, KCMBLLDCFPL<TData> PPKFMHJLLNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3624420", Offset = "0x3622C20", VA = "0x183624420", Slot = "4")]
	public override bool HPKKAMDMNCC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class CJCOCGAPOAJ<TData> : PBANJEPAJDJ<GOJLCOLIGMA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly FJLAIKJHCMF GHBCHHNPEOF;

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x4B56850", Offset = "0x4B55050", VA = "0x184B56850")]
	public CJCOCGAPOAJ(Vector3 MAAOFEBIKAF, GOJLCOLIGMA<TData> PPKFMHJLLNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3AF0E50", Offset = "0x3AEF650", VA = "0x183AF0E50", Slot = "4")]
	public override bool HPKKAMDMNCC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public struct PHKFPKJDCJK<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public readonly IEnumerable<TData> AHJOPNICLKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly Vector3 MAAOFEBIKAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly bool BJBNPAGLLJM;

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3DA9E10", Offset = "0x3DA8610", VA = "0x183DA9E10")]
	public PHKFPKJDCJK(IEnumerable<TData> AHJOPNICLKF, Vector3 MAAOFEBIKAF, bool BJBNPAGLLJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public struct PNCMLBBOFCD<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly IEnumerable<TData> AHJOPNICLKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly bool BJBNPAGLLJM;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3DCF790", Offset = "0x3DCDF90", VA = "0x183DCF790")]
	public PNCMLBBOFCD(IEnumerable<TData> AHJOPNICLKF, bool BJBNPAGLLJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public struct BOENLHMLACL<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly IEnumerable<TData> AHJOPNICLKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly Vector3 OGOIHAMBBGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly NPPIDMBFKHD ABMIAJHBEDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly bool BJBNPAGLLJM;

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x4894150", Offset = "0x4892950", VA = "0x184894150")]
	public BOENLHMLACL(IEnumerable<TData> AHJOPNICLKF, Vector3 OGOIHAMBBGB, NPPIDMBFKHD ABMIAJHBEDB, bool BJBNPAGLLJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public struct FJLAIKJHCMF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly Vector3 MAAOFEBIKAF;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x1F0C100", Offset = "0x1F0A900", VA = "0x181F0C100")]
	public FJLAIKJHCMF(Vector3 MAAOFEBIKAF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public enum NPPIDMBFKHD
{
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	XYZ,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	X_only,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	Y_only,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	Z_only
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface KJPKJMLACPI<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HPKKAMDMNCC([In] OOLINMHABNK<TData> JDNGEMGAJOJ);

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HPKKAMDMNCC([In] KAPNDBIFLBG<TData> JDNGEMGAJOJ);
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface BLAPCJNAGJB<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AINHPANKAGK([In] HCFPBDJDOHL<TData> HBLHPPGCLHC);

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PHKPJABPGII([In] OGJHAFMOGJF HMBBAMECGIP);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LIOCMBIGIBG();
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class GOKFICBAHJD<TData> : PBANJEPAJDJ<KJPKJMLACPI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly OOLINMHABNK<TData> JDNGEMGAJOJ;

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3505AD0", Offset = "0x35042D0", VA = "0x183505AD0")]
	public GOKFICBAHJD(IEnumerable<TData> AHJOPNICLKF, Quaternion MAAOFEBIKAF, Vector3? BLBHEGPGEKD, bool CCOIGHGMIFA, bool BJBNPAGLLJM, KJPKJMLACPI<TData> PPKFMHJLLNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3057C50", Offset = "0x3056450", VA = "0x183057C50", Slot = "4")]
	public override bool HPKKAMDMNCC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class NOGJFCLCOCL<TData> : PBANJEPAJDJ<BLAPCJNAGJB<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3055D30", Offset = "0x3054530", VA = "0x183055D30")]
	public NOGJFCLCOCL(BLAPCJNAGJB<TData> PPKFMHJLLNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x3907240", Offset = "0x3905A40", VA = "0x183907240", Slot = "4")]
	public override bool HPKKAMDMNCC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class GEPIMADGACH<TData> : PBANJEPAJDJ<BLAPCJNAGJB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly HCFPBDJDOHL<TData> JDNGEMGAJOJ;

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x34D5530", Offset = "0x34D3D30", VA = "0x1834D5530")]
	public GEPIMADGACH(IEnumerable<TData> AHJOPNICLKF, bool BJBNPAGLLJM, BLAPCJNAGJB<TData> PPKFMHJLLNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x3057C50", Offset = "0x3056450", VA = "0x183057C50", Slot = "4")]
	public override bool HPKKAMDMNCC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class INMDBFKHIDH<TData> : PBANJEPAJDJ<KJPKJMLACPI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly KAPNDBIFLBG<TData> JDNGEMGAJOJ;

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x365DC70", Offset = "0x365C470", VA = "0x18365DC70")]
	public INMDBFKHIDH(IEnumerable<TData> AHJOPNICLKF, Quaternion EGDIDFGFBAN, NPPIDMBFKHD BNHCKDNHBNP, Vector3? BLBHEGPGEKD, bool CCOIGHGMIFA, bool BJBNPAGLLJM, KJPKJMLACPI<TData> PPKFMHJLLNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x3624420", Offset = "0x3622C20", VA = "0x183624420", Slot = "4")]
	public override bool HPKKAMDMNCC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class MNCCGCFMJIC<TData> : PBANJEPAJDJ<BLAPCJNAGJB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly OGJHAFMOGJF JDNGEMGAJOJ;

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x3B46D40", Offset = "0x3B45540", VA = "0x183B46D40")]
	public MNCCGCFMJIC(Quaternion MAAOFEBIKAF, Vector3? BLBHEGPGEKD, bool CCOIGHGMIFA, BLAPCJNAGJB<TData> PPKFMHJLLNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x3AF0E50", Offset = "0x3AEF650", VA = "0x183AF0E50", Slot = "4")]
	public override bool HPKKAMDMNCC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public struct OOLINMHABNK<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public readonly IEnumerable<TData> AHJOPNICLKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly Quaternion MAAOFEBIKAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public readonly Vector3? BLBHEGPGEKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public readonly bool CCOIGHGMIFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public readonly bool BJBNPAGLLJM;

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3CF7280", Offset = "0x3CF5A80", VA = "0x183CF7280")]
	public OOLINMHABNK(IEnumerable<TData> AHJOPNICLKF, Quaternion MAAOFEBIKAF, Vector3? BLBHEGPGEKD, bool CCOIGHGMIFA, bool BJBNPAGLLJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public struct HCFPBDJDOHL<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public readonly IEnumerable<TData> AHJOPNICLKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public readonly bool BJBNPAGLLJM;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x355FCC0", Offset = "0x355E4C0", VA = "0x18355FCC0")]
	public HCFPBDJDOHL(IEnumerable<TData> AHJOPNICLKF, bool BJBNPAGLLJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public struct KAPNDBIFLBG<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public readonly IEnumerable<TData> AHJOPNICLKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public readonly Quaternion EGDIDFGFBAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public readonly NPPIDMBFKHD BNHCKDNHBNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public readonly Vector3? BLBHEGPGEKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public readonly bool CCOIGHGMIFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public readonly bool BJBNPAGLLJM;

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x38531F0", Offset = "0x38519F0", VA = "0x1838531F0")]
	public KAPNDBIFLBG(IEnumerable<TData> AHJOPNICLKF, Quaternion EGDIDFGFBAN, NPPIDMBFKHD BNHCKDNHBNP, Vector3? BLBHEGPGEKD, bool CCOIGHGMIFA, bool BJBNPAGLLJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public struct OGJHAFMOGJF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public readonly Quaternion MAAOFEBIKAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public readonly Vector3? BLBHEGPGEKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public readonly bool CCOIGHGMIFA;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x4260E10", Offset = "0x425F610", VA = "0x184260E10")]
	public OGJHAFMOGJF(Quaternion MAAOFEBIKAF, Vector3? BLBHEGPGEKD, bool CCOIGHGMIFA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public interface NADNEEGKIOA<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AINHPANKAGK([In] BHFIJLHMJOK<TData> HBLHPPGCLHC);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PHKPJABPGII([In] HKEINIKMGJO HMBBAMECGIP);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PHKPJABPGII([In] OCMJIODLHIG HMBBAMECGIP);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool PHKPJABPGII([In] JFMGNPGAKIJ HMBBAMECGIP);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool LIOCMBIGIBG();
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public class HHKFFNCAOJJ<TData> : PBANJEPAJDJ<NADNEEGKIOA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly JFMGNPGAKIJ HBEJGLDPHOK;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x35902E0", Offset = "0x358EAE0", VA = "0x1835902E0")]
	public HHKFFNCAOJJ(Vector3 ECBKLHLLIEA, float JJLGAOMIEEO, Vector3 BLBHEGPGEKD, bool IKMFOFBAECM, NADNEEGKIOA<TData> PPKFMHJLLNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3590280", Offset = "0x358EA80", VA = "0x183590280", Slot = "4")]
	public override bool HPKKAMDMNCC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class JKENOBEDELN<TData> : PBANJEPAJDJ<NADNEEGKIOA<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x3055D30", Offset = "0x3054530", VA = "0x183055D30")]
	public JKENOBEDELN(NADNEEGKIOA<TData> PPKFMHJLLNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x3816E40", Offset = "0x3815640", VA = "0x183816E40", Slot = "4")]
	public override bool HPKKAMDMNCC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public class LLCNHKLCHAO<TData> : PBANJEPAJDJ<NADNEEGKIOA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly BHFIJLHMJOK<TData> HBEJGLDPHOK;

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x39249F0", Offset = "0x39231F0", VA = "0x1839249F0")]
	public LLCNHKLCHAO(IEnumerable<TData> AHJOPNICLKF, bool BJBNPAGLLJM, NADNEEGKIOA<TData> PPKFMHJLLNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x3057C50", Offset = "0x3056450", VA = "0x183057C50", Slot = "4")]
	public override bool HPKKAMDMNCC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public class AKNKNGOKMDE<TData> : PBANJEPAJDJ<NADNEEGKIOA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly OCMJIODLHIG HBEJGLDPHOK;

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x352F3D0", Offset = "0x352DBD0", VA = "0x18352F3D0")]
	public AKNKNGOKMDE(float IHPAPLFEGGL, bool ECEIIGLBOFJ, Vector3 BLBHEGPGEKD, NADNEEGKIOA<TData> PPKFMHJLLNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x352F300", Offset = "0x352DB00", VA = "0x18352F300", Slot = "4")]
	public override bool HPKKAMDMNCC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class MEPLOBIFEAD<TData> : PBANJEPAJDJ<NADNEEGKIOA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private readonly HKEINIKMGJO HBEJGLDPHOK;

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x3AF0EB0", Offset = "0x3AEF6B0", VA = "0x183AF0EB0")]
	public MEPLOBIFEAD(float JJLGAOMIEEO, Vector3 BLBHEGPGEKD, NADNEEGKIOA<TData> PPKFMHJLLNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x3AF0E50", Offset = "0x3AEF650", VA = "0x183AF0E50", Slot = "4")]
	public override bool HPKKAMDMNCC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public struct JFMGNPGAKIJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public readonly Vector3 ECBKLHLLIEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public readonly float JJLGAOMIEEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly Vector3 BLBHEGPGEKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public readonly bool GKJDIPIJNKF;

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x5D028E0", Offset = "0x5D010E0", VA = "0x185D028E0")]
	public JFMGNPGAKIJ(Vector3 ECBKLHLLIEA, float JJLGAOMIEEO, Vector3 BLBHEGPGEKD, bool GKJDIPIJNKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public struct BHFIJLHMJOK<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly IEnumerable<TData> AHJOPNICLKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public readonly bool BJBNPAGLLJM;

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x43F4C40", Offset = "0x43F3440", VA = "0x1843F4C40")]
	public BHFIJLHMJOK(IEnumerable<TData> AHJOPNICLKF, bool BJBNPAGLLJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct OCMJIODLHIG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public readonly float IHPAPLFEGGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public readonly bool ECEIIGLBOFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public readonly Vector3 BLBHEGPGEKD;

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x5D02B20", Offset = "0x5D01320", VA = "0x185D02B20")]
	public OCMJIODLHIG(float IHPAPLFEGGL, bool ECEIIGLBOFJ, Vector3 BLBHEGPGEKD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public struct HKEINIKMGJO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public readonly float JJLGAOMIEEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public readonly Vector3 BLBHEGPGEKD;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x4234600", Offset = "0x4232E00", VA = "0x184234600")]
	public HKEINIKMGJO(float JJLGAOMIEEO, Vector3 BLBHEGPGEKD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public static class PNHEBBHCJEH
{
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	private struct PKLGMIDNFLL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public bool CMBGHDNOOCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public LLKIHBKOOLA PFCFLKDONAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public LLKIHBKOOLA LBCLCBLFLBD;
	}

	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private static PKLGMIDNFLL ODGCOEEBAGM;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static CancellationToken IAKAFKKJDJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x5D02BE0", Offset = "0x5D013E0", VA = "0x185D02BE0")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	internal static LLKIHBKOOLA PFCFLKDONAN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x5D02B40", Offset = "0x5D01340", VA = "0x185D02B40")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x5D02EA0", Offset = "0x5D016A0", VA = "0x185D02EA0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5D02DA0", Offset = "0x5D015A0", VA = "0x185D02DA0")]
	[NJKKEFDLCAD(CEDKDBJGKHF.Room, AFMDLPKJFNK.None)]
	private static void MCAIAAGMENI(LLKIHBKOOLA KLIDILNLAPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x5D02C50", Offset = "0x5D01450", VA = "0x185D02C50")]
	public static void FCKDKLKEHNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x5D02C00", Offset = "0x5D01400", VA = "0x185D02C00")]
	private static LLKIHBKOOLA EFLFDBPICDF(LLKIHBKOOLA LKGGHPMDMAA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public static class PBGDHOENMEE
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public enum DCNKFNMIGIN
	{
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		ICreationContextObject,
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		Guid
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x24E3AC0", Offset = "0x24E22C0", VA = "0x1824E3AC0")]
	public static void COBFFJDOMLI<T>(T IALEADLNNLH, DCNKFNMIGIN GFGNPBCFEMC) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x24E3C00", Offset = "0x24E2400", VA = "0x1824E3C00")]
	public static void COBFFJDOMLI<T>(T IALEADLNNLH) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x24E3A50", Offset = "0x24E2250", VA = "0x1824E3A50")]
	public static void CNMBIDIECMI<T>(T IALEADLNNLH) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x24E3CA0", Offset = "0x24E24A0", VA = "0x1824E3CA0")]
	public static T FBPOFKNEBFB<T>(DCNKFNMIGIN GFGNPBCFEMC) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x24E3C60", Offset = "0x24E2460", VA = "0x1824E3C60")]
	public static T FBPOFKNEBFB<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x24E3C60", Offset = "0x24E2460", VA = "0x1824E3C60")]
	public static bool OIGBAKMEDEG<T>() where T : class
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal static class GJLNIKNIEIJ
{
	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x5D023C0", Offset = "0x5D00BC0", VA = "0x185D023C0")]
	public static void EBDJGEEENMO(IEnumerable BAENPDLOOON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x2364730", Offset = "0x2362F30", VA = "0x182364730")]
	public static void EBDJGEEENMO<T>(T[] INLAJDDNHAO) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x2364910", Offset = "0x2363110", VA = "0x182364910")]
	public static void EBDJGEEENMO<T>(T OKPFOPOABKC) where T : notnull, Enum
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
