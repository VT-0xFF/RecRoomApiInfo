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
		[Cpp2IlInjected.Address(RVA = "0x7D9A20", Offset = "0x7D8820", VA = "0x1807D9A20")]
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
		[Cpp2IlInjected.Address(RVA = "0x62535C0", Offset = "0x62523C0", VA = "0x1862535C0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7D9DC0", Offset = "0x7D8BC0", VA = "0x1807D9DC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D9E00", Offset = "0x7D8C00", VA = "0x1807D9E00")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface IBMNBKIKKKJ<TData, TReturn>
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TReturn BNHMIEFFOHP(TData EIFMADKIHON);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface JDDDNLCFDKG<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ClearHoverTarget(IGBLHJMBPJG IABBEJMCAEO);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool SetHoverTarget(TData KCDBINENHAL, Collider HKBFBJLAPHP, IGBLHJMBPJG IABBEJMCAEO, [Optional] JLKPHNPIODB? AGBEBNDBEFA);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool TryGetHoverTarget([Out] TData KCDBINENHAL);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetHoverCollider([Out] Collider HKBFBJLAPHP);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface OBHAAHEEIFD<TData> : BPBNJBAMHKE, AIMFOMJMIAO<TData>, ACOAPHGCPPC<TData>, GKNECBKGHGF<TData>, AJPNIHKMJGB, HMNDDBEGIIF<TData>, DCMCKHBNHPB, ELBPJFFIHIC
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface HMNDDBEGIIF<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 GBCFIJMPBKM, Vector3 BCGALFAPEPA, float OGFHDAHPALD, [Out] T FOCAFEPKBPH, [Out] Vector3 NGKANEGEGPK, [Out] Collider HKBFBJLAPHP);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 GBCFIJMPBKM, Vector3 BCGALFAPEPA, float KDOHNNEBEDD, float OGFHDAHPALD, T[] LHKGLDNPOCM, [Out] Vector3 IAOJBLCPCKF, [Out] Collider JKPHOEHLPHI);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 GBCFIJMPBKM, float KDOHNNEBEDD, Vector3 NNANNLJMNAA, T[] LHKGLDNPOCM);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetObjectFromColliderInCurrentScope(Collider PLGNHDMELGA, [Out] T NDAHPJJDELH);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface BPBNJBAMHKE
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Bounds PFCIOOAOMBC
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Transform MKMFIAGJMJL
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Bounds DFCIEFHGDOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Transform BCKMAKOILIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Vector3 KELMFMHOLOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool EFOGFEFDEFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void SetSelectionBoundsDirty(bool HKEHLIKOKIJ = true, int IFEBPJFBFKF = 0);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ShouldHideSelectionBoundsPreview(bool DNGNMKLLGPC, object ADNDMAGEPOK);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface ELBPJFFIHIC
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	BFNGIAHHPKE CGELFGGMGDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface DCBMNHJAIJA
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool ECLGAFOAILO
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool NHDKAFPFIME
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool BCHBGEKILHI
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
	void TrySetPreviousCloneMapping(Dictionary<Guid, Guid> HJDLHJGFMAA);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface GKNECBKGHGF<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool JPHBDCHJBDE
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int NHNGIAILGBH
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<TData> FDLPMAGGDIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData LMLNLGNPIDN);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData LMLNLGNPIDN);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface AIMFOMJMIAO<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T EIFMADKIHON, [Optional] JLKPHNPIODB? DIIKGALEMAO, bool KJNIOOJKLLE = true);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int NJKDAMEBDBN, IEnumerable<T> EAMMFGNDJAM, bool KJNIOOJKLLE = true);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int NJKDAMEBDBN, IEnumerable<T> EAMMFGNDJAM, JLKPHNPIODB DIIKGALEMAO, bool KJNIOOJKLLE = true);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface DCMCKHBNHPB
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface AJPNIHKMJGB
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool GLBJAPHNOCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool KPOCJPHNFKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool EMAOKAFJGBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool HDBJNOCGBBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class NCOGKHHIHEM<TReceiver> : CFFGBOEDMEM<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x346F870", Offset = "0x346E670", VA = "0x18346F870")]
	public NCOGKHHIHEM(TReceiver EEBGPMOCPBC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class PHGAGIGLCCH<TReceiver, TFromTask> : CFFGBOEDMEM<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x346F870", Offset = "0x346E670", VA = "0x18346F870")]
	public PHGAGIGLCCH(TReceiver EEBGPMOCPBC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public abstract class CFFGBOEDMEM<TReceiver, TFromExecute> where TReceiver : notnull where TFromExecute : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	protected TReceiver EEBGPMOCPBC;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4D0DA10", Offset = "0x4D0C810", VA = "0x184D0DA10")]
	public CFFGBOEDMEM(TReceiver EEBGPMOCPBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute HBPDLPEKCDF();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public abstract class FBABKLNNJDB<TReceiver, TResult> : CFFGBOEDMEM<TReceiver, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x346F870", Offset = "0x346E670", VA = "0x18346F870")]
	public FBABKLNNJDB(TReceiver EEBGPMOCPBC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct HPGPLPGMJEO<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public TGroup KMGNPNFJFIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public TData KLFDMPKANAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public IEnumerable<TData> NJFCMHEDEIF;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1B51970", Offset = "0x1B50770", VA = "0x181B51970")]
	public HPGPLPGMJEO(TGroup MOLCGDJAHME, TData IBBKGPOHNKN, IEnumerable<TData> FOEEEFIBAIC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct HNOHLOLKICI<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public TGroup KMGNPNFJFIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public IEnumerable<TData> NJFCMHEDEIF;

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x93C520", Offset = "0x93B320", VA = "0x18093C520")]
	public HNOHLOLKICI(TGroup MOLCGDJAHME, IEnumerable<TData> FOEEEFIBAIC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct MOMMLHADHAD<TGroup> where TGroup : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public TGroup KMGNPNFJFIL;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x93C860", Offset = "0x93B660", VA = "0x18093C860")]
	public MOMMLHADHAD(TGroup MOLCGDJAHME)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct KBLBOEPFNBB<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public IEnumerable<TData> NJFCMHEDEIF;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x93C860", Offset = "0x93B660", VA = "0x18093C860")]
	public KBLBOEPFNBB(IEnumerable<TData> FOEEEFIBAIC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface DLDBIKECFJP<TGroup, TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	APFFHHPPDFB PJIDEHLEMHJ(HPGPLPGMJEO<TGroup, TData> OPCHJADNGJI);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "1")]
	APFFHHPPDFB FJPPODCHCPO(HPGPLPGMJEO<TGroup, TData> OPCHJADNGJI);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "2")]
	APFFHHPPDFB IPNDJIINEKH(HNOHLOLKICI<TGroup, TData> OPCHJADNGJI);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "3")]
	APFFHHPPDFB APHPANJAOBP(MOMMLHADHAD<TGroup> OPCHJADNGJI);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface GOPPKLEIPAM<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<APFFHHPPDFB> PJIDEHLEMHJ(KBLBOEPFNBB<TData> OPCHJADNGJI);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class PNCONHCAGFK<TGroup, TData> : FBABKLNNJDB<DLDBIKECFJP<TGroup, TData>, APFFHHPPDFB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly HNOHLOLKICI<TGroup, TData> OPCHJADNGJI;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x41E25B0", Offset = "0x41E13B0", VA = "0x1841E25B0")]
	public PNCONHCAGFK(TGroup MOLCGDJAHME, IEnumerable<TData> FOEEEFIBAIC, DLDBIKECFJP<TGroup, TData> EEBGPMOCPBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x41E24F0", Offset = "0x41E12F0", VA = "0x1841E24F0", Slot = "4")]
	public override APFFHHPPDFB HBPDLPEKCDF()
	{
		return default(APFFHHPPDFB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class FBGLJAAFIMA<TGroup, TData> : FBABKLNNJDB<DLDBIKECFJP<TGroup, TData>, APFFHHPPDFB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly HPGPLPGMJEO<TGroup, TData> OPCHJADNGJI;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3826D30", Offset = "0x3825B30", VA = "0x183826D30")]
	public FBGLJAAFIMA(TGroup MOLCGDJAHME, TData PLLENCEOENI, IEnumerable<TData> FOEEEFIBAIC, DLDBIKECFJP<TGroup, TData> EEBGPMOCPBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3826C60", Offset = "0x3825A60", VA = "0x183826C60", Slot = "4")]
	public override APFFHHPPDFB HBPDLPEKCDF()
	{
		return default(APFFHHPPDFB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class CGJDPMHOKAN<TGroup, TData> : FBABKLNNJDB<DLDBIKECFJP<TGroup, TData>, APFFHHPPDFB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly MOMMLHADHAD<TGroup> OPCHJADNGJI;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3CDA140", Offset = "0x3CD8F40", VA = "0x183CDA140")]
	public CGJDPMHOKAN(TGroup MOLCGDJAHME, DLDBIKECFJP<TGroup, TData> EEBGPMOCPBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4D21600", Offset = "0x4D20400", VA = "0x184D21600", Slot = "4")]
	public override APFFHHPPDFB HBPDLPEKCDF()
	{
		return default(APFFHHPPDFB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class HJCPIPNCNMO<TGroup, TData> : FBABKLNNJDB<DLDBIKECFJP<TGroup, TData>, APFFHHPPDFB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly HPGPLPGMJEO<TGroup, TData> OPCHJADNGJI;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3826D30", Offset = "0x3825B30", VA = "0x183826D30")]
	public HJCPIPNCNMO(TGroup MOLCGDJAHME, TData IBBKGPOHNKN, IEnumerable<TData> FOEEEFIBAIC, DLDBIKECFJP<TGroup, TData> EEBGPMOCPBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x39C6CA0", Offset = "0x39C5AA0", VA = "0x1839C6CA0", Slot = "4")]
	public override APFFHHPPDFB HBPDLPEKCDF()
	{
		return default(APFFHHPPDFB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class OBKIMOKDDHM<TData> : PHGAGIGLCCH<GOPPKLEIPAM<TData>, APFFHHPPDFB> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private struct BJHBCKODPFL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AsyncTaskMethodBuilder<APFFHHPPDFB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public OBKIMOKDDHM<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private TaskAwaiter<APFFHHPPDFB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x4858000", Offset = "0x4856E00", VA = "0x184858000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x48582A0", Offset = "0x48570A0", VA = "0x1848582A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private KBLBOEPFNBB<TData> OPCHJADNGJI;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3CDA140", Offset = "0x3CD8F40", VA = "0x183CDA140")]
	public OBKIMOKDDHM(IEnumerable<TData> EJNKJPENOOK, GOPPKLEIPAM<TData> EEBGPMOCPBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x40FEC00", Offset = "0x40FDA00", VA = "0x1840FEC00", Slot = "4")]
	[AsyncStateMachine(typeof(OBKIMOKDDHM<>.BJHBCKODPFL))]
	public override Task<APFFHHPPDFB> HBPDLPEKCDF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct HJBAGDPFJKA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly IHFBAELHHCG POHMGFKDBAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly bool JFFIPICCGKD;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6252C30", Offset = "0x6251A30", VA = "0x186252C30")]
	public HJBAGDPFJKA(IHFBAELHHCG OJGCICDDJDC, bool OGIELOAJHBG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface MGFBBHHHINF<TSpawnType> where TSpawnType : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> HBPDLPEKCDF(HJBAGDPFJKA JFDKJMKIMBO);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class AJLEIIEGGDN<TSpawnType> : PHGAGIGLCCH<MGFBBHHHINF<TSpawnType>, TSpawnType> where TSpawnType : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private struct BLELODFMGJC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public AsyncTaskMethodBuilder<TSpawnType> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public AJLEIIEGGDN<TSpawnType> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskAwaiter<TSpawnType> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x48790D0", Offset = "0x4877ED0", VA = "0x1848790D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x4042410", Offset = "0x4041210", VA = "0x184042410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly HJBAGDPFJKA JFDKJMKIMBO;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x39171F0", Offset = "0x3915FF0", VA = "0x1839171F0")]
	public AJLEIIEGGDN(IHFBAELHHCG OJGCICDDJDC, bool OGIELOAJHBG, MGFBBHHHINF<TSpawnType> EEBGPMOCPBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3917010", Offset = "0x3915E10", VA = "0x183917010", Slot = "4")]
	[AsyncStateMachine(typeof(AJLEIIEGGDN<>.BLELODFMGJC))]
	public override Task<TSpawnType> HBPDLPEKCDF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public readonly struct IHFBAELHHCG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly bool GKLCDLEFCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly Vector3 MICEBJPJMGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly Vector3 LDNPGPEOBDD;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6252CB0", Offset = "0x6251AB0", VA = "0x186252CB0")]
	public IHFBAELHHCG(Transform MKBBPDJHLML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6252C80", Offset = "0x6251A80", VA = "0x186252C80")]
	public IHFBAELHHCG(Vector3 ELKFIDDLEIG, Vector3 JPLKOMKCHGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6252C50", Offset = "0x6251A50", VA = "0x186252C50")]
	public static IHFBAELHHCG OGJOLBOGFNJ()
	{
		return default(IHFBAELHHCG);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6252D20", Offset = "0x6251B20", VA = "0x186252D20")]
	private IHFBAELHHCG(bool IIFCBKOCELK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct GPJEFAIAAMC<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public TNode CMHEIPBPNOM;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x397E030", Offset = "0x397CE30", VA = "0x18397E030")]
	public GPJEFAIAAMC(TNode CMHEIPBPNOM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct PHGFEFEOKNE<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public TNode PCNGDFFLMCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public FEKKJBADKLE CHKEFEBDBIL;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x41CDCD0", Offset = "0x41CCAD0", VA = "0x1841CDCD0")]
	public PHGFEFEOKNE(TNode PCNGDFFLMCK, FEKKJBADKLE CHKEFEBDBIL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface PJIPLAPHDHH<TNode>
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MABJAPABEFL([In] GPJEFAIAAMC<TNode> MMGENKFOIMB);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HPNOILLIFAN([In] PHGFEFEOKNE<TNode> NGGGKCHNNJG);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KDJGNELOIAH();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class PMGIHICDAIN<TNode> : NCOGKHHIHEM<PJIPLAPHDHH<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x346F870", Offset = "0x346E670", VA = "0x18346F870")]
	public PMGIHICDAIN(PJIPLAPHDHH<TNode> EEBGPMOCPBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x41E04C0", Offset = "0x41DF2C0", VA = "0x1841E04C0", Slot = "4")]
	public override bool HBPDLPEKCDF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class HMIMDECGILB<TNode> : NCOGKHHIHEM<PJIPLAPHDHH<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly PHGFEFEOKNE<TNode> NGGGKCHNNJG;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x39CDE00", Offset = "0x39CCC00", VA = "0x1839CDE00")]
	public HMIMDECGILB(TNode PCNGDFFLMCK, FEKKJBADKLE CHKEFEBDBIL, PJIPLAPHDHH<TNode> EEBGPMOCPBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3476F90", Offset = "0x3475D90", VA = "0x183476F90", Slot = "4")]
	public override bool HBPDLPEKCDF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class NCEFHNGDOMA<TNode> : NCOGKHHIHEM<PJIPLAPHDHH<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly GPJEFAIAAMC<TNode> MMGENKFOIMB;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3FF8660", Offset = "0x3FF7460", VA = "0x183FF8660")]
	public NCEFHNGDOMA(TNode NMNDLMMHJMD, PJIPLAPHDHH<TNode> EEBGPMOCPBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3946380", Offset = "0x3945180", VA = "0x183946380", Slot = "4")]
	public override bool HBPDLPEKCDF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct BNKNCFEPFFK<TSpawnInfo> where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public TSpawnInfo HEJJPIKEIGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public Vector3 JPLKOMKCHGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public Quaternion IHHAEIJMAPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public float HDBPIAOAHOC;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x488A4F0", Offset = "0x48892F0", VA = "0x18488A4F0")]
	public BNKNCFEPFFK(TSpawnInfo HEJJPIKEIGH, Vector3 JPLKOMKCHGP, Quaternion IHHAEIJMAPE, float HDBPIAOAHOC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface HPNEOINMOJK<TSpawnType, TSpawnInfo>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> HIGKIAHCKIL([In] BNKNCFEPFFK<TSpawnInfo> ENNMKICPNED, CancellationToken KANPDHELHMD);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class CNFJJIKNBEF<TSpawnType, TSpawnInfo> : PHGAGIGLCCH<HPNEOINMOJK<TSpawnType, TSpawnInfo>, TSpawnType> where TSpawnType : notnull where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly BNKNCFEPFFK<TSpawnInfo> GOFCIAANDLN;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x4E00620", Offset = "0x4DFF420", VA = "0x184E00620")]
	public CNFJJIKNBEF(TSpawnInfo CIHBFLLCLEJ, Vector3 JPLKOMKCHGP, Quaternion IHHAEIJMAPE, float HDBPIAOAHOC, HPNEOINMOJK<TSpawnType, TSpawnInfo> EEBGPMOCPBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x4E00440", Offset = "0x4DFF240", VA = "0x184E00440", Slot = "4")]
	public override Task<TSpawnType> HBPDLPEKCDF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct KHFNCPBAKKB<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly IEnumerable<TData> NJFCMHEDEIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly bool JFFIPICCGKD;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x3D07D40", Offset = "0x3D06B40", VA = "0x183D07D40")]
	public KHFNCPBAKKB(IEnumerable<TData> FOEEEFIBAIC, bool OGIELOAJHBG = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface KBPDFBEJJFE<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<APFFHHPPDFB> LLFDPMLEAFP([In] KHFNCPBAKKB<TData> LNDJKANCJDG, CancellationToken KANPDHELHMD);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class DGAMPOLEDKN<TData> : PHGAGIGLCCH<KBPDFBEJJFE<TData>, APFFHHPPDFB> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly KHFNCPBAKKB<TData> GJINBFIPOAM;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x513E060", Offset = "0x513CE60", VA = "0x18513E060")]
	public DGAMPOLEDKN(IEnumerable<TData> FOEEEFIBAIC, bool OGIELOAJHBG, KBPDFBEJJFE<TData> EEBGPMOCPBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x4E00440", Offset = "0x4DFF240", VA = "0x184E00440", Slot = "4")]
	public override Task<APFFHHPPDFB> HBPDLPEKCDF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct AOCBPIGGJIN<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly T KCDBINENHAL;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x3923300", Offset = "0x3922100", VA = "0x183923300")]
	public AOCBPIGGJIN(T CAFGDPCLOOL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface KIEMCCDAJDD<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MABJAPABEFL([In] AOCBPIGGJIN<T> KIODNBGMBEO);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HPNOILLIFAN();
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface LKPEIIKICBE<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HBPDLPEKCDF([In] CCKOKIPDFHD<T> ANDOLLGBECI);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct CCKOKIPDFHD<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public readonly T KCDBINENHAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public readonly bool AKNNMNCCNNP;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x4C3F820", Offset = "0x4C3E620", VA = "0x184C3F820")]
	public CCKOKIPDFHD(T CAFGDPCLOOL, bool BNDNLJDIJGK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class JBNNMCHJDNC<T> : NCOGKHHIHEM<KIEMCCDAJDD<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x346F870", Offset = "0x346E670", VA = "0x18346F870")]
	public JBNNMCHJDNC(KIEMCCDAJDD<T> EEBGPMOCPBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x3C194C0", Offset = "0x3C182C0", VA = "0x183C194C0", Slot = "4")]
	public override bool HBPDLPEKCDF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class KABNLBABBCK<T> : NCOGKHHIHEM<KIEMCCDAJDD<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly AOCBPIGGJIN<T> KIODNBGMBEO;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x3CDA1B0", Offset = "0x3CD8FB0", VA = "0x183CDA1B0")]
	public KABNLBABBCK(T KCDBINENHAL, KIEMCCDAJDD<T> EEBGPMOCPBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x3946380", Offset = "0x3945180", VA = "0x183946380", Slot = "4")]
	public override bool HBPDLPEKCDF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class KGLOBLJELPK<T> : NCOGKHHIHEM<LKPEIIKICBE<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly CCKOKIPDFHD<T> ANDOLLGBECI;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x3CECEB0", Offset = "0x3CEBCB0", VA = "0x183CECEB0")]
	public KGLOBLJELPK(T KCDBINENHAL, bool BNDNLJDIJGK, LKPEIIKICBE<T> EEBGPMOCPBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x3946380", Offset = "0x3945180", VA = "0x183946380", Slot = "4")]
	public override bool HBPDLPEKCDF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct FFEPINBDNJN<TData> where TData : notnull, DGFOPIGPMPD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public IEnumerable<TData> NJFCMHEDEIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public bool JKFEGADPJFN;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x3832D50", Offset = "0x3831B50", VA = "0x183832D50")]
	public FFEPINBDNJN(IEnumerable<TData> BKLIBLHEKLJ, bool IGHFGJLKFHA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct MEMOKIIPBMG<TData> where TData : notnull, DGFOPIGPMPD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public List<TData> NJFCMHEDEIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public List<bool> CBPJILICIFO;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x3F86DC0", Offset = "0x3F85BC0", VA = "0x183F86DC0")]
	public MEMOKIIPBMG(List<TData> BKLIBLHEKLJ, List<bool> CDPBFNCBBFA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface DGFOPIGPMPD
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool EOKMHJBDKEK
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
public interface MJHAHFIPKCK<TData> where TData : DGFOPIGPMPD
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HBPDLPEKCDF([In] FFEPINBDNJN<TData> BOAOIIPIALP);

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HBPDLPEKCDF([In] MEMOKIIPBMG<TData> BOAOIIPIALP);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface AFOPKJFCLNK<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HLHDDDILNNI(T KCDBINENHAL);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class JJHEGPAFPBC<TData> : NCOGKHHIHEM<MJHAHFIPKCK<TData>> where TData : notnull, DGFOPIGPMPD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly FFEPINBDNJN<TData> BOAOIIPIALP;

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x3C3F680", Offset = "0x3C3E480", VA = "0x183C3F680")]
	public JJHEGPAFPBC(List<TData> FOEEEFIBAIC, bool JKFEGADPJFN, MJHAHFIPKCK<TData> EEBGPMOCPBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x3946380", Offset = "0x3945180", VA = "0x183946380", Slot = "4")]
	public override bool HBPDLPEKCDF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class POCHEHNIMFF<TData> : NCOGKHHIHEM<MJHAHFIPKCK<TData>> where TData : notnull, DGFOPIGPMPD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly MEMOKIIPBMG<TData> BOAOIIPIALP;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x423A940", Offset = "0x4239740", VA = "0x18423A940")]
	public POCHEHNIMFF(List<TData> FOEEEFIBAIC, List<bool> CBPJILICIFO, MJHAHFIPKCK<TData> EEBGPMOCPBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x423A890", Offset = "0x4239690", VA = "0x18423A890", Slot = "4")]
	public override bool HBPDLPEKCDF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface FLAFODHFDIG<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<APFFHHPPDFB> HBPDLPEKCDF(KKLHEOOAEOO<TData> EKJKCNDECHG);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public class HEFIOAEOKCE<TData> : PHGAGIGLCCH<FLAFODHFDIG<TData>, APFFHHPPDFB> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct OPMIPFLAFEL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public AsyncTaskMethodBuilder<APFFHHPPDFB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public HEFIOAEOKCE<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<APFFHHPPDFB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x412EB80", Offset = "0x412D980", VA = "0x18412EB80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x412EE60", Offset = "0x412DC60", VA = "0x18412EE60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly KKLHEOOAEOO<TData> KFFCGBEJIJD;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x39BA540", Offset = "0x39B9340", VA = "0x1839BA540")]
	public HEFIOAEOKCE(TData EMDIKLAHEPI, IReadOnlyList<TData> KBKMOFFBCDC, bool OGIELOAJHBG, FLAFODHFDIG<TData> EEBGPMOCPBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x39BA440", Offset = "0x39B9240", VA = "0x1839BA440", Slot = "4")]
	[AsyncStateMachine(typeof(HEFIOAEOKCE<>.OPMIPFLAFEL))]
	public override Task<APFFHHPPDFB> HBPDLPEKCDF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public struct KKLHEOOAEOO<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public TData LCIMMNFAPIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public IReadOnlyList<TData> ICONONCKPCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public bool JFFIPICCGKD;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x3D13E20", Offset = "0x3D12C20", VA = "0x183D13E20")]
	public KKLHEOOAEOO(TData EMDIKLAHEPI, IReadOnlyList<TData> KBKMOFFBCDC, bool OGIELOAJHBG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface EGOBHOMOJOP<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HBPDLPEKCDF([In] HPDAEMEMPGN<TData> LEBPEGENGPE);
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface NAAFANKBPDH<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HBPDLPEKCDF([In] BECBFNCMFGB<TData> LEBPEGENGPE);
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface JFFDGCJKMIE<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JCCMNCDOJHK([In] MHKIIKCMBGP<TData> LEBPEGENGPE);

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HPNOILLIFAN();
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class KOACPKLPOCE<TData> : NCOGKHHIHEM<EGOBHOMOJOP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly HPDAEMEMPGN<TData> LEBPEGENGPE;

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x3D33DA0", Offset = "0x3D32BA0", VA = "0x183D33DA0")]
	public KOACPKLPOCE(IEnumerable<TData> FOEEEFIBAIC, ENPFFMMLNID BGJPICBMDGJ, BDMIKMCNHMH LKFHNDFBKCD, float MDGKNLINNEF, bool OGIELOAJHBG, EGOBHOMOJOP<TData> EEBGPMOCPBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x3946380", Offset = "0x3945180", VA = "0x183946380", Slot = "4")]
	public override bool HBPDLPEKCDF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class JKOBEPHOEPA<TData> : NCOGKHHIHEM<NAAFANKBPDH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly BECBFNCMFGB<TData> LEBPEGENGPE;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x3C45630", Offset = "0x3C44430", VA = "0x183C45630")]
	public JKOBEPHOEPA(TData[] FOEEEFIBAIC, ENPFFMMLNID[] BGJPICBMDGJ, BDMIKMCNHMH[] LKFHNDFBKCD, float[] MDGKNLINNEF, NAAFANKBPDH<TData> EEBGPMOCPBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3C454C0", Offset = "0x3C442C0", VA = "0x183C454C0", Slot = "4")]
	public override bool HBPDLPEKCDF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class CJJGHLFLFLF<TData> : NCOGKHHIHEM<JFFDGCJKMIE<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x346F870", Offset = "0x346E670", VA = "0x18346F870")]
	public CJJGHLFLFLF(JFFDGCJKMIE<TData> EEBGPMOCPBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x4DF7D40", Offset = "0x4DF6B40", VA = "0x184DF7D40", Slot = "4")]
	public override bool HBPDLPEKCDF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class CFOJMGFJDFH<TData> : NCOGKHHIHEM<JFFDGCJKMIE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly MHKIIKCMBGP<TData> LEBPEGENGPE;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x4D115D0", Offset = "0x4D103D0", VA = "0x184D115D0")]
	public CFOJMGFJDFH(IEnumerable<TData> FOEEEFIBAIC, ENPFFMMLNID BGJPICBMDGJ, BDMIKMCNHMH LKFHNDFBKCD, float MDGKNLINNEF, JFFDGCJKMIE<TData> EEBGPMOCPBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3C454C0", Offset = "0x3C442C0", VA = "0x183C454C0", Slot = "4")]
	public override bool HBPDLPEKCDF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public struct HPDAEMEMPGN<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public IEnumerable<TData> NJFCMHEDEIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public ENPFFMMLNID HMNOCMLJBFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public BDMIKMCNHMH MHCLJLHGBOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public float MDGKNLINNEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public bool OGIELOAJHBG;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x39DF970", Offset = "0x39DE770", VA = "0x1839DF970")]
	public HPDAEMEMPGN(IEnumerable<TData> FOEEEFIBAIC, ENPFFMMLNID BGJPICBMDGJ, BDMIKMCNHMH LKFHNDFBKCD, float MDGKNLINNEF, bool OGIELOAJHBG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct BECBFNCMFGB<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public TData[] NJFCMHEDEIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public ENPFFMMLNID[] HMNOCMLJBFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public BDMIKMCNHMH[] MHCLJLHGBOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public float[] MDGKNLINNEF;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x483A700", Offset = "0x4839500", VA = "0x18483A700")]
	public BECBFNCMFGB(TData[] FOEEEFIBAIC, ENPFFMMLNID[] BGJPICBMDGJ, BDMIKMCNHMH[] LKFHNDFBKCD, float[] MDGKNLINNEF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public struct MHKIIKCMBGP<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public IEnumerable<TData> NJFCMHEDEIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public ENPFFMMLNID HMNOCMLJBFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public BDMIKMCNHMH MHCLJLHGBOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public float MDGKNLINNEF;

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3FA10F0", Offset = "0x3F9FEF0", VA = "0x183FA10F0")]
	public MHKIIKCMBGP(IEnumerable<TData> FOEEEFIBAIC, ENPFFMMLNID BGJPICBMDGJ, BDMIKMCNHMH LKFHNDFBKCD, float MDGKNLINNEF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public interface ACOAPHGCPPC<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IPNDJIINEKH([In] CNICFAPFCBN<TData> LNDJKANCJDG);

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void APHPANJAOBP([In] CNICFAPFCBN<TData> LNDJKANCJDG);

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IBEPHJBIDHL([In] bool CBBOODJKFBO);

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CEJHCAPCGJG([In] CNICFAPFCBN<TData> LNDJKANCJDG);

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NHONEJGNMBD();

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool EJIHJCOHMBO([In] TData ADDAFIFMABC);
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class JIJEMGJLIID<TData> : NCOGKHHIHEM<ACOAPHGCPPC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly CNICFAPFCBN<TData> LNDJKANCJDG;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x3C32FD0", Offset = "0x3C31DD0", VA = "0x183C32FD0")]
	public JIJEMGJLIID(List<TData> OMJAEJKGFAD, ACOAPHGCPPC<TData> EEBGPMOCPBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3946380", Offset = "0x3945180", VA = "0x183946380", Slot = "4")]
	public override bool HBPDLPEKCDF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class AEAJMOPIMDI<TData> : NCOGKHHIHEM<ACOAPHGCPPC<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x346F870", Offset = "0x346E670", VA = "0x18346F870")]
	public AEAJMOPIMDI(ACOAPHGCPPC<TData> EEBGPMOCPBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x38E2920", Offset = "0x38E1720", VA = "0x1838E2920", Slot = "4")]
	public override bool HBPDLPEKCDF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class EGDHHNLHBCK<TData> : NCOGKHHIHEM<ACOAPHGCPPC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly bool OGIELOAJHBG;

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3482F90", Offset = "0x3481D90", VA = "0x183482F90")]
	public EGDHHNLHBCK(bool OGIELOAJHBG, ACOAPHGCPPC<TData> EEBGPMOCPBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3482F30", Offset = "0x3481D30", VA = "0x183482F30", Slot = "4")]
	public override bool HBPDLPEKCDF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class PPJBOENEIJL<TData> : NCOGKHHIHEM<ACOAPHGCPPC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly CNICFAPFCBN<TData> LNDJKANCJDG;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x4241310", Offset = "0x4240110", VA = "0x184241310")]
	public PPJBOENEIJL(List<TData> OMJAEJKGFAD, bool OGIELOAJHBG, ACOAPHGCPPC<TData> EEBGPMOCPBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x423A890", Offset = "0x4239690", VA = "0x18423A890", Slot = "4")]
	public override bool HBPDLPEKCDF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class ALMODDDFCHN<TData> : NCOGKHHIHEM<ACOAPHGCPPC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly TData ADDAFIFMABC;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x391C170", Offset = "0x391AF70", VA = "0x18391C170")]
	public ALMODDDFCHN(TData ADDAFIFMABC, ACOAPHGCPPC<TData> EEBGPMOCPBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x391C000", Offset = "0x391AE00", VA = "0x18391C000", Slot = "4")]
	public override bool HBPDLPEKCDF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class GDCGOOOIJHD<TData> : NCOGKHHIHEM<ACOAPHGCPPC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly CNICFAPFCBN<TData> LNDJKANCJDG;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x38FF430", Offset = "0x38FE230", VA = "0x1838FF430")]
	public GDCGOOOIJHD(IEnumerable<TData> OMJAEJKGFAD, ACOAPHGCPPC<TData> EEBGPMOCPBC, bool OGIELOAJHBG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x38FF2D0", Offset = "0x38FE0D0", VA = "0x1838FF2D0", Slot = "4")]
	public override bool HBPDLPEKCDF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public struct CNICFAPFCBN<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public IEnumerable<TData> NJFCMHEDEIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public bool OGIELOAJHBG;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x4E01110", Offset = "0x4DFFF10", VA = "0x184E01110")]
	public CNICFAPFCBN(IEnumerable<TData> BKLIBLHEKLJ, bool CNGNFFALBNP = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public interface KOEMJLNBKCL
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<APFFHHPPDFB> HBPDLPEKCDF(KGBKCGLNBDI HIBMMNFLKJD);
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class HIMJIGOOGKJ : PHGAGIGLCCH<KOEMJLNBKCL, APFFHHPPDFB>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private struct PDGJBFLFIAC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public AsyncTaskMethodBuilder<APFFHHPPDFB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public HIMJIGOOGKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private TaskAwaiter<APFFHHPPDFB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6253870", Offset = "0x6252670", VA = "0x186253870", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6253AE0", Offset = "0x62528E0", VA = "0x186253AE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly KGBKCGLNBDI NPAKJECLKGL;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6252BD0", Offset = "0x62519D0", VA = "0x186252BD0")]
	public HIMJIGOOGKJ(bool OGIELOAJHBG, KOEMJLNBKCL EEBGPMOCPBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6252AE0", Offset = "0x62518E0", VA = "0x186252AE0", Slot = "4")]
	[AsyncStateMachine(typeof(PDGJBFLFIAC))]
	public override Task<APFFHHPPDFB> HBPDLPEKCDF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct KGBKCGLNBDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public bool JFFIPICCGKD;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0xCAAFD0", Offset = "0xCA9DD0", VA = "0x180CAAFD0")]
	public KGBKCGLNBDI(bool OGIELOAJHBG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public readonly struct FFLKLJDMGIF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly bool IGEJJOJJEEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly bool KJAJLAFECKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly bool HDBPIAOAHOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public readonly bool OGIELOAJHBG;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x46EFBE0", Offset = "0x46EE9E0", VA = "0x1846EFBE0")]
	public FFLKLJDMGIF(bool IGEJJOJJEEJ, bool KJAJLAFECKF, bool HDBPIAOAHOC, bool OGIELOAJHBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6252980", Offset = "0x6251780", VA = "0x186252980")]
	public FFLKLJDMGIF(bool KJAJLAFECKF, bool OGIELOAJHBG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface KOGEAOJHLEB
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PNFJNAKNNML(FFLKLJDMGIF HMDFJLHCANG);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FMKHLJLCGNB(FFLKLJDMGIF HMDFJLHCANG);
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class PHAECHHAMNL : NCOGKHHIHEM<KOGEAOJHLEB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly FFLKLJDMGIF HMDFJLHCANG;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6253BA0", Offset = "0x62529A0", VA = "0x186253BA0")]
	public PHAECHHAMNL(bool AFOLJDADEON, bool KJAJLAFECKF, bool HDBPIAOAHOC, bool OGIELOAJHBG, KOGEAOJHLEB EEBGPMOCPBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6253B50", Offset = "0x6252950", VA = "0x186253B50", Slot = "4")]
	public override bool HBPDLPEKCDF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class PNMMFNFDOIM : NCOGKHHIHEM<KOGEAOJHLEB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly FFLKLJDMGIF HMDFJLHCANG;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6253C80", Offset = "0x6252A80", VA = "0x186253C80")]
	public PNMMFNFDOIM(bool KJAJLAFECKF, bool OGIELOAJHBG, KOGEAOJHLEB EEBGPMOCPBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6253C30", Offset = "0x6252A30", VA = "0x186253C30", Slot = "4")]
	public override bool HBPDLPEKCDF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public interface JGBOPDIHKJM
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HBPDLPEKCDF([In] MMDBOAIIJEI BGJABMPMFKF);
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class CMJJJCHHDFM : NCOGKHHIHEM<JGBOPDIHKJM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly MMDBOAIIJEI BGJABMPMFKF;

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6252740", Offset = "0x6251540", VA = "0x186252740")]
	public CMJJJCHHDFM(Guid[] BPEHGMILEED, Vector3[] DNCJDPLAOPE, Quaternion[] HLNLKCKOLED, float[] HCBEKDPDKJL, Dictionary<Guid, Vector3> PCCNKLGCLEH, JGBOPDIHKJM EEBGPMOCPBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6252690", Offset = "0x6251490", VA = "0x186252690", Slot = "4")]
	public override bool HBPDLPEKCDF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public interface BIIKKDKPELB<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MABJAPABEFL([In] LJGEONDCJPO<TData> MMGENKFOIMB);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JCCMNCDOJHK([In] CNCFKNABOCP ELKDIIGHFIL);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JCCMNCDOJHK([In] EPPGBHIFDKM ELKDIIGHFIL);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HPNOILLIFAN();
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class KEPAGHHEEMM<TData> : NCOGKHHIHEM<BIIKKDKPELB<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x346F870", Offset = "0x346E670", VA = "0x18346F870")]
	public KEPAGHHEEMM(BIIKKDKPELB<TData> EEBGPMOCPBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3CE6FB0", Offset = "0x3CE5DB0", VA = "0x183CE6FB0", Slot = "4")]
	public override bool HBPDLPEKCDF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class NFOHOMNCMLK<TData> : NCOGKHHIHEM<BIIKKDKPELB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly CNCFKNABOCP MPJJBKOMBIA;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x401C200", Offset = "0x401B000", VA = "0x18401C200")]
	public NFOHOMNCMLK(Vector3 MJNNCHHFFJK, bool IGCOODHLNFG, BIIKKDKPELB<TData> EEBGPMOCPBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x39178A0", Offset = "0x39166A0", VA = "0x1839178A0", Slot = "4")]
	public override bool HBPDLPEKCDF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class LAKEJGEEOOL<TData> : NCOGKHHIHEM<BIIKKDKPELB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly EPPGBHIFDKM MPJJBKOMBIA;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x3DA61D0", Offset = "0x3DA4FD0", VA = "0x183DA61D0")]
	public LAKEJGEEOOL(Guid HBGJHIOHDLE, int AELAKOMEEDP, Vector3 JPLKOMKCHGP, Quaternion IHHAEIJMAPE, float KOHJDCIMHLK, bool IGCOODHLNFG, BIIKKDKPELB<TData> EEBGPMOCPBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x3DA6170", Offset = "0x3DA4F70", VA = "0x183DA6170", Slot = "4")]
	public override bool HBPDLPEKCDF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class JMNOOJKHBNG<TData> : NCOGKHHIHEM<BIIKKDKPELB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly LJGEONDCJPO<TData> MPJJBKOMBIA;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x3C53740", Offset = "0x3C52540", VA = "0x183C53740")]
	public JMNOOJKHBNG(TData KCDBINENHAL, bool OGIELOAJHBG, BIIKKDKPELB<TData> EEBGPMOCPBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x3946380", Offset = "0x3945180", VA = "0x183946380", Slot = "4")]
	public override bool HBPDLPEKCDF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public struct CNCFKNABOCP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public readonly Vector3 MJNNCHHFFJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly bool IGCOODHLNFG;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x6252920", Offset = "0x6251720", VA = "0x186252920")]
	public CNCFKNABOCP(Vector3 MJNNCHHFFJK, bool IGCOODHLNFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public struct EPPGBHIFDKM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public readonly Guid HBGJHIOHDLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public readonly int AELAKOMEEDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public readonly Vector3 JPLKOMKCHGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public readonly Quaternion IHHAEIJMAPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public readonly float KOHJDCIMHLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public readonly bool IGCOODHLNFG;

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6252940", Offset = "0x6251740", VA = "0x186252940")]
	public EPPGBHIFDKM(Guid HBGJHIOHDLE, int AELAKOMEEDP, Vector3 JPLKOMKCHGP, Quaternion IHHAEIJMAPE, float KOHJDCIMHLK, bool IGCOODHLNFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public struct LJGEONDCJPO<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public readonly TData KCDBINENHAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public readonly bool OGIELOAJHBG;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x3DC6710", Offset = "0x3DC5510", VA = "0x183DC6710")]
	public LJGEONDCJPO(TData KCDBINENHAL, bool OGIELOAJHBG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public interface FHGLNEHOHBG<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HBPDLPEKCDF([In] LOGICAJFGEF<TData> KOAJBNECEJJ);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HBPDLPEKCDF([In] FDOHIFBGKLK<TData> KOAJBNECEJJ);
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public interface GHBHELNFAEB<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MABJAPABEFL([In] AHHMFGMBMBC<TData> HEHFHFFMJCA);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JCCMNCDOJHK([In] GMGGLIFINIC ELKDIIGHFIL);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HPNOILLIFAN();
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class BHOOIMJNGFF<TData> : NCOGKHHIHEM<FHGLNEHOHBG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly LOGICAJFGEF<TData> KOAJBNECEJJ;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x4856CA0", Offset = "0x4855AA0", VA = "0x184856CA0")]
	public BHOOIMJNGFF(IEnumerable<TData> FOEEEFIBAIC, Vector3 JNHOOAHBGDP, bool OGIELOAJHBG, FHGLNEHOHBG<TData> EEBGPMOCPBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x3946380", Offset = "0x3945180", VA = "0x183946380", Slot = "4")]
	public override bool HBPDLPEKCDF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class LEEDKBDNNHK<TData> : NCOGKHHIHEM<GHBHELNFAEB<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x346F870", Offset = "0x346E670", VA = "0x18346F870")]
	public LEEDKBDNNHK(GHBHELNFAEB<TData> EEBGPMOCPBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x38E28D0", Offset = "0x38E16D0", VA = "0x1838E28D0", Slot = "4")]
	public override bool HBPDLPEKCDF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class GILOGOHLCOO<TData> : NCOGKHHIHEM<GHBHELNFAEB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly AHHMFGMBMBC<TData> KOAJBNECEJJ;

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x39464C0", Offset = "0x39452C0", VA = "0x1839464C0")]
	public GILOGOHLCOO(IEnumerable<TData> FOEEEFIBAIC, bool OGIELOAJHBG, GHBHELNFAEB<TData> EEBGPMOCPBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x3946380", Offset = "0x3945180", VA = "0x183946380", Slot = "4")]
	public override bool HBPDLPEKCDF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class ECJPIDEJGAA<TData> : NCOGKHHIHEM<FHGLNEHOHBG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly FDOHIFBGKLK<TData> KOAJBNECEJJ;

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x3477050", Offset = "0x3475E50", VA = "0x183477050")]
	public ECJPIDEJGAA(IEnumerable<TData> FOEEEFIBAIC, Vector3 DJHCDKJEMCL, OLDNBDKMBDJ AKMNGPLAGLG, bool OGIELOAJHBG, FHGLNEHOHBG<TData> EEBGPMOCPBC, Space JJGNKAOCGAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3476F90", Offset = "0x3475D90", VA = "0x183476F90", Slot = "4")]
	public override bool HBPDLPEKCDF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class MIENJKIJMGI<TData> : NCOGKHHIHEM<GHBHELNFAEB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly GMGGLIFINIC KOAJBNECEJJ;

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x3FA3A80", Offset = "0x3FA2880", VA = "0x183FA3A80")]
	public MIENJKIJMGI(Vector3 JNHOOAHBGDP, GHBHELNFAEB<TData> EEBGPMOCPBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x39178A0", Offset = "0x39166A0", VA = "0x1839178A0", Slot = "4")]
	public override bool HBPDLPEKCDF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct LOGICAJFGEF<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public readonly IEnumerable<TData> FOEEEFIBAIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public readonly Vector3 JNHOOAHBGDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public readonly bool OGIELOAJHBG;

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x3DCD540", Offset = "0x3DCC340", VA = "0x183DCD540")]
	public LOGICAJFGEF(IEnumerable<TData> FOEEEFIBAIC, Vector3 JNHOOAHBGDP, bool OGIELOAJHBG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct AHHMFGMBMBC<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public readonly IEnumerable<TData> FOEEEFIBAIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public readonly bool OGIELOAJHBG;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x390E560", Offset = "0x390D360", VA = "0x18390E560")]
	public AHHMFGMBMBC(IEnumerable<TData> FOEEEFIBAIC, bool OGIELOAJHBG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct FDOHIFBGKLK<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public readonly IEnumerable<TData> FOEEEFIBAIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public readonly Vector3 DJHCDKJEMCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public readonly OLDNBDKMBDJ AKMNGPLAGLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly bool OGIELOAJHBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public readonly Space JJGNKAOCGAL;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x382E820", Offset = "0x382D620", VA = "0x18382E820")]
	public FDOHIFBGKLK(IEnumerable<TData> FOEEEFIBAIC, Vector3 DJHCDKJEMCL, OLDNBDKMBDJ AKMNGPLAGLG, bool OGIELOAJHBG, Space JJGNKAOCGAL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct GMGGLIFINIC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly Vector3 JNHOOAHBGDP;

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x1FD0EE0", Offset = "0x1FCFCE0", VA = "0x181FD0EE0")]
	public GMGGLIFINIC(Vector3 JNHOOAHBGDP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public enum OLDNBDKMBDJ
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
public interface GECHAJHAPMM
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HBPDLPEKCDF([In] POPIMPDIJFD GCHCHHMPCNG);
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public class HGDKHMNDNGL : NCOGKHHIHEM<GECHAJHAPMM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly POPIMPDIJFD GCHCHHMPCNG;

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6252A80", Offset = "0x6251880", VA = "0x186252A80")]
	public HGDKHMNDNGL(bool OGIELOAJHBG, GECHAJHAPMM EEBGPMOCPBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x62529D0", Offset = "0x62517D0", VA = "0x1862529D0", Slot = "4")]
	public override bool HBPDLPEKCDF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public readonly struct POPIMPDIJFD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public readonly bool OGIELOAJHBG;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0xCAAFD0", Offset = "0xCA9DD0", VA = "0x180CAAFD0")]
	public POPIMPDIJFD(bool OGIELOAJHBG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public interface GCEOGPGFHEN<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HBPDLPEKCDF([In] DGFMMIFJINJ<TData> OLBGDBLJPAA);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HBPDLPEKCDF([In] NLJOPCHHNJA<TData> OLBGDBLJPAA);
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public interface KAOKBMIEOLP<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MABJAPABEFL([In] DHDKHGFALKH<TData> MMGENKFOIMB);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JCCMNCDOJHK([In] BEMFHJBLBOK ELKDIIGHFIL);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HPNOILLIFAN();
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class NIIBNIEAKIO<TData> : NCOGKHHIHEM<GCEOGPGFHEN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly DGFMMIFJINJ<TData> OLBGDBLJPAA;

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x4027070", Offset = "0x4025E70", VA = "0x184027070")]
	public NIIBNIEAKIO(IEnumerable<TData> FOEEEFIBAIC, Quaternion JNHOOAHBGDP, Vector3? IDIPKHKFDHH, bool MLDNHBNCGNN, bool OGIELOAJHBG, GCEOGPGFHEN<TData> EEBGPMOCPBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x3946380", Offset = "0x3945180", VA = "0x183946380", Slot = "4")]
	public override bool HBPDLPEKCDF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class ADPGMBFHPCK<TData> : NCOGKHHIHEM<KAOKBMIEOLP<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x346F870", Offset = "0x346E670", VA = "0x18346F870")]
	public ADPGMBFHPCK(KAOKBMIEOLP<TData> EEBGPMOCPBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x38E28D0", Offset = "0x38E16D0", VA = "0x1838E28D0", Slot = "4")]
	public override bool HBPDLPEKCDF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class OINFMIAJABI<TData> : NCOGKHHIHEM<KAOKBMIEOLP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly DHDKHGFALKH<TData> OLBGDBLJPAA;

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x4110B80", Offset = "0x410F980", VA = "0x184110B80")]
	public OINFMIAJABI(IEnumerable<TData> FOEEEFIBAIC, bool OGIELOAJHBG, KAOKBMIEOLP<TData> EEBGPMOCPBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x3946380", Offset = "0x3945180", VA = "0x183946380", Slot = "4")]
	public override bool HBPDLPEKCDF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class ADBOOIGHBOJ<TData> : NCOGKHHIHEM<GCEOGPGFHEN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly NLJOPCHHNJA<TData> OLBGDBLJPAA;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x38E1380", Offset = "0x38E0180", VA = "0x1838E1380")]
	public ADBOOIGHBOJ(IEnumerable<TData> FOEEEFIBAIC, Quaternion BBGCPFFJLKM, OLDNBDKMBDJ DMGCJMAMJDF, Vector3? IDIPKHKFDHH, bool MLDNHBNCGNN, bool OGIELOAJHBG, Space JJGNKAOCGAL, GCEOGPGFHEN<TData> EEBGPMOCPBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x3476F90", Offset = "0x3475D90", VA = "0x183476F90", Slot = "4")]
	public override bool HBPDLPEKCDF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class AKNCOABCHBA<TData> : NCOGKHHIHEM<KAOKBMIEOLP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly BEMFHJBLBOK OLBGDBLJPAA;

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x3917900", Offset = "0x3916700", VA = "0x183917900")]
	public AKNCOABCHBA(Quaternion JNHOOAHBGDP, Vector3? IDIPKHKFDHH, bool MLDNHBNCGNN, KAOKBMIEOLP<TData> EEBGPMOCPBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x39178A0", Offset = "0x39166A0", VA = "0x1839178A0", Slot = "4")]
	public override bool HBPDLPEKCDF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public struct DGFMMIFJINJ<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public readonly IEnumerable<TData> FOEEEFIBAIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public readonly Quaternion JNHOOAHBGDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public readonly Vector3? IDIPKHKFDHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public readonly bool MLDNHBNCGNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public readonly bool OGIELOAJHBG;

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x5140E10", Offset = "0x513FC10", VA = "0x185140E10")]
	public DGFMMIFJINJ(IEnumerable<TData> FOEEEFIBAIC, Quaternion JNHOOAHBGDP, Vector3? IDIPKHKFDHH, bool MLDNHBNCGNN, bool OGIELOAJHBG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public struct DHDKHGFALKH<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public readonly IEnumerable<TData> FOEEEFIBAIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public readonly bool OGIELOAJHBG;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x51494E0", Offset = "0x51482E0", VA = "0x1851494E0")]
	public DHDKHGFALKH(IEnumerable<TData> FOEEEFIBAIC, bool OGIELOAJHBG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public struct NLJOPCHHNJA<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly IEnumerable<TData> FOEEEFIBAIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public readonly Quaternion BBGCPFFJLKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public readonly OLDNBDKMBDJ DMGCJMAMJDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public readonly Vector3? IDIPKHKFDHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public readonly bool MLDNHBNCGNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public readonly bool OGIELOAJHBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public readonly Space JJGNKAOCGAL;

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x4042990", Offset = "0x4041790", VA = "0x184042990")]
	public NLJOPCHHNJA(IEnumerable<TData> FOEEEFIBAIC, Quaternion BBGCPFFJLKM, OLDNBDKMBDJ DMGCJMAMJDF, Vector3? IDIPKHKFDHH, bool MLDNHBNCGNN, bool OGIELOAJHBG, Space JJGNKAOCGAL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public struct BEMFHJBLBOK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public readonly Quaternion JNHOOAHBGDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public readonly Vector3? IDIPKHKFDHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public readonly bool MLDNHBNCGNN;

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x46BD720", Offset = "0x46BC520", VA = "0x1846BD720")]
	public BEMFHJBLBOK(Quaternion JNHOOAHBGDP, Vector3? IDIPKHKFDHH, bool MLDNHBNCGNN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public interface ODADBBOJHLA<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MABJAPABEFL([In] DLKMGGMDOPA<TData> MMGENKFOIMB);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JCCMNCDOJHK([In] KMBOCLKBGHC ELKDIIGHFIL);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JCCMNCDOJHK([In] MAEBKIKAGDM ELKDIIGHFIL);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JCCMNCDOJHK([In] FPCFIPGALOA ELKDIIGHFIL);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool HPNOILLIFAN();
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public class POLBNOLAIEG<TData> : NCOGKHHIHEM<ODADBBOJHLA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly FPCFIPGALOA GAPCFKPCHAJ;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x423AD50", Offset = "0x4239B50", VA = "0x18423AD50")]
	public POLBNOLAIEG(Vector3 KDDEMPDLBBK, float HGBKJEFLNMD, Vector3 IDIPKHKFDHH, bool ICJIJKNNIHD, bool NKOFMLNHBIG, ODADBBOJHLA<TData> EEBGPMOCPBC, Space JJGNKAOCGAL = Space.Self)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x423ACF0", Offset = "0x4239AF0", VA = "0x18423ACF0", Slot = "4")]
	public override bool HBPDLPEKCDF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public class HDMEDKIBPDA<TData> : NCOGKHHIHEM<ODADBBOJHLA<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x346F870", Offset = "0x346E670", VA = "0x18346F870")]
	public HDMEDKIBPDA(ODADBBOJHLA<TData> EEBGPMOCPBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x39B4F90", Offset = "0x39B3D90", VA = "0x1839B4F90", Slot = "4")]
	public override bool HBPDLPEKCDF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class OIGKMIELHJK<TData> : NCOGKHHIHEM<ODADBBOJHLA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly DLKMGGMDOPA<TData> GAPCFKPCHAJ;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x410B700", Offset = "0x410A500", VA = "0x18410B700")]
	public OIGKMIELHJK(IEnumerable<TData> FOEEEFIBAIC, bool OGIELOAJHBG, ODADBBOJHLA<TData> EEBGPMOCPBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x3946380", Offset = "0x3945180", VA = "0x183946380", Slot = "4")]
	public override bool HBPDLPEKCDF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class ELFAHDLGPMA<TData> : NCOGKHHIHEM<ODADBBOJHLA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly MAEBKIKAGDM GAPCFKPCHAJ;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x3497740", Offset = "0x3496540", VA = "0x183497740")]
	public ELFAHDLGPMA(float JJCGOCFLABO, bool DDFDNMHHMIA, Vector3 IDIPKHKFDHH, ODADBBOJHLA<TData> EEBGPMOCPBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x3497680", Offset = "0x3496480", VA = "0x183497680", Slot = "4")]
	public override bool HBPDLPEKCDF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class NHGEJGHCGDD<TData> : NCOGKHHIHEM<ODADBBOJHLA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly KMBOCLKBGHC GAPCFKPCHAJ;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x4025E50", Offset = "0x4024C50", VA = "0x184025E50")]
	public NHGEJGHCGDD(float HGBKJEFLNMD, Vector3 IDIPKHKFDHH, ODADBBOJHLA<TData> EEBGPMOCPBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x39178A0", Offset = "0x39166A0", VA = "0x1839178A0", Slot = "4")]
	public override bool HBPDLPEKCDF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public struct FPCFIPGALOA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public readonly Vector3 KDDEMPDLBBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public readonly float HGBKJEFLNMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public readonly Vector3 IDIPKHKFDHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public readonly bool IGCOODHLNFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public readonly Space JJGNKAOCGAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public readonly bool NKOFMLNHBIG;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x6252990", Offset = "0x6251790", VA = "0x186252990")]
	public FPCFIPGALOA(Vector3 KDDEMPDLBBK, float HGBKJEFLNMD, Vector3 IDIPKHKFDHH, bool IGCOODHLNFG, bool JAAILIFGDCP, Space JJGNKAOCGAL = Space.Self)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public struct DLKMGGMDOPA<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public readonly IEnumerable<TData> FOEEEFIBAIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public readonly bool OGIELOAJHBG;

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x515D780", Offset = "0x515C580", VA = "0x18515D780")]
	public DLKMGGMDOPA(IEnumerable<TData> FOEEEFIBAIC, bool OGIELOAJHBG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct MAEBKIKAGDM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public readonly float JJCGOCFLABO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public readonly bool DDFDNMHHMIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public readonly Vector3 IDIPKHKFDHH;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x6253140", Offset = "0x6251F40", VA = "0x186253140")]
	public MAEBKIKAGDM(float JJCGOCFLABO, bool DDFDNMHHMIA, Vector3 IDIPKHKFDHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public struct KMBOCLKBGHC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public readonly float HGBKJEFLNMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public readonly Vector3 IDIPKHKFDHH;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x4675A50", Offset = "0x4674850", VA = "0x184675A50")]
	public KMBOCLKBGHC(float HGBKJEFLNMD, Vector3 IDIPKHKFDHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct MMDBOAIIJEI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public readonly Guid[] FOEEEFIBAIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public readonly bool LHGMDEOKGBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public readonly bool PFLHHLNJMDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public readonly bool BEBGHLECOPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public readonly Vector3[] DNCJDPLAOPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public readonly Quaternion[] HLNLKCKOLED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public readonly float[] HCBEKDPDKJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly Dictionary<Guid, Vector3> PCCNKLGCLEH;

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6253330", Offset = "0x6252130", VA = "0x186253330")]
	public MMDBOAIIJEI(Guid[] BPEHGMILEED, Vector3[] DNCJDPLAOPE, Quaternion[] HLNLKCKOLED, float[] HCBEKDPDKJL, Dictionary<Guid, Vector3> PCCNKLGCLEH, bool LHGMDEOKGBG = true, bool PFLHHLNJMDE = true, bool BEBGHLECOPE = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x6253160", Offset = "0x6251F60", VA = "0x186253160")]
	private static void KHCAEAKAMIM(Dictionary<Guid, Vector3> PCCNKLGCLEH, int BCMCELHGAIF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public static class ILKDAMBMBOD
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	private struct HPLCPDJCJEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public bool BMLHGMDNLHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public NAINNGGFMLM HAEBKGMHLHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public NAINNGGFMLM PBGNJLLJLGP;
	}

	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private static HPLCPDJCJEO NGBBAGPLIJJ;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static CancellationToken IIDPGEKHGAK
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x6252DA0", Offset = "0x6251BA0", VA = "0x186252DA0")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	internal static NAINNGGFMLM HAEBKGMHLHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x6252F00", Offset = "0x6251D00", VA = "0x186252F00")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6252FA0", Offset = "0x6251DA0", VA = "0x186252FA0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6253000", Offset = "0x6251E00", VA = "0x186253000")]
	[DPHBJKOLDBD(FMOBJKPMAGC.Room, OHNOEEJKPCM.None)]
	private static void MLGMKBAPDEI(NAINNGGFMLM OIPPBFBOKNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6252DC0", Offset = "0x6251BC0", VA = "0x186252DC0")]
	public static void HJOLGBAAIAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x62530F0", Offset = "0x6251EF0", VA = "0x1862530F0")]
	private static NAINNGGFMLM NAOPBMJONLF(NAINNGGFMLM NCOAFEMCDOP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public static class PNODABDHPPN
{
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public enum CMDFDACOGJE
	{
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		ICreationContextObject,
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		Guid
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x2A58B10", Offset = "0x2A57910", VA = "0x182A58B10")]
	public static void MBPIFLBFJJC<T>(T LOMIFCBLBKN, CMDFDACOGJE DDEINLAGLLL) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x2A58C50", Offset = "0x2A57A50", VA = "0x182A58C50")]
	public static void MBPIFLBFJJC<T>(T LOMIFCBLBKN) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x2A58750", Offset = "0x2A57550", VA = "0x182A58750")]
	public static void BIFBKNAOPHE<T>(T LOMIFCBLBKN) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x2A587C0", Offset = "0x2A575C0", VA = "0x182A587C0")]
	public static T DJGCEJBDGHO<T>(CMDFDACOGJE DDEINLAGLLL) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x2A589E0", Offset = "0x2A577E0", VA = "0x182A589E0")]
	public static bool HIBEGIGNEIP<T>(CMDFDACOGJE DDEINLAGLLL, T ILPGEGKDJML, [Out] T IKPDGBJMJBF) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x2A588A0", Offset = "0x2A576A0", VA = "0x182A588A0")]
	public static bool EAHCBFENANP<T>(CMDFDACOGJE DDEINLAGLLL) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x2A58860", Offset = "0x2A57660", VA = "0x182A58860")]
	public static T DJGCEJBDGHO<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x2A58940", Offset = "0x2A57740", VA = "0x182A58940")]
	public static bool HIBEGIGNEIP<T>(T ILPGEGKDJML, [Out] T IKPDGBJMJBF) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x2A58860", Offset = "0x2A57660", VA = "0x182A58860")]
	public static bool EAHCBFENANP<T>() where T : class
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
internal static class PCLOAIIMNCE
{
	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6253640", Offset = "0x6252440", VA = "0x186253640")]
	public static void NPOBPHEKEAJ(IEnumerable CLKGDHFKCAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x2A4C900", Offset = "0x2A4B700", VA = "0x182A4C900")]
	public static void NPOBPHEKEAJ<T>(T[] OKLABKDOFAF) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x2A4CAE0", Offset = "0x2A4B8E0", VA = "0x182A4CAE0")]
	public static void NPOBPHEKEAJ<T>(T GOCCBDNGINL) where T : notnull, Enum
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
