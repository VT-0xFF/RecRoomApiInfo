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
		[Cpp2IlInjected.Address(RVA = "0x8C1980", Offset = "0x8C0380", VA = "0x1808C1980")]
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
		[Cpp2IlInjected.Address(RVA = "0x6C95C60", Offset = "0x6C94660", VA = "0x186C95C60")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8C2AE0", Offset = "0x8C14E0", VA = "0x1808C2AE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8C2B20", Offset = "0x8C1520", VA = "0x1808C2B20")]
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
	public class _AssemblyIndex : PBJLLMOALLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6C95DD0", Offset = "0x6C947D0", VA = "0x186C95DD0", Slot = "8")]
		public override void BHEMPDPJNII(CGCPPALGHJA registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x632F010", Offset = "0x632DA10", VA = "0x18632F010")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface PKCHAJMEPDB<TData, TReturn>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TReturn LHPPDJHAOKE(TData GHMNBJIOGAM);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface IHAEKAAEOHM<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ClearHoverTarget(DBKMHBIOEGM CMCJBNOCKCN);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool SetHoverTarget(TData LLMCGMPLMBL, Collider PEOELCKOOGC, DBKMHBIOEGM CMCJBNOCKCN, [Optional] CEKFCLEOOAA? DOLOAMOPLGI);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool TryGetHoverTarget([Out] TData LLMCGMPLMBL);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetHoverCollider([Out] Collider PEOELCKOOGC);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface OOJNKGKHBEG<TData> : JBNMMIGNDOH, DHCAILKKCFF<TData>, KJJKOKPHNMK<TData>, CPDFBLPGPME<TData>, AIEILFPFGPL, EAENHHGLING<TData>, OLEAOCKEBLB, GGENJEAEEGD
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface EAENHHGLING<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 LHEBMMKGLMP, Vector3 JFCINBHKCNC, float KEEIEBHGPIH, [Out] T GGEHHGACHAN, [Out] Vector3 AMMMPGEIJLF, [Out] Collider PEOELCKOOGC);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 LHEBMMKGLMP, Vector3 JFCINBHKCNC, float KKAGHANEDHB, float KEEIEBHGPIH, T[] LEHEBHHDPJM, [Out] Vector3 HMGJGOHGAEM, [Out] Collider BFOJEBCGJPK);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 LHEBMMKGLMP, float KKAGHANEDHB, Vector3 FLMOCFJNAIB, T[] LEHEBHHDPJM);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetObjectFromColliderInCurrentScope(Collider MKIOBPJJEPP, [Out] T PHCDPEBOLME);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface JBNMMIGNDOH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Bounds BFDFMEOJIJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Transform GJDIDJPFKGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Bounds FJEJECEKGLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Transform GOPKLHMKNHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Vector3 DMMGCJCHHBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool CPDGJEIAEHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void SetSelectionBoundsDirty(bool BLPABAHBBJB = true, int FFEOLBBKOOC = 0);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ShouldHideSelectionBoundsPreview(bool PPIPGMOCCKM, object FLLNLBHFENG);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface GGENJEAEEGD
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	GHNLMGKLHKE JGJGFOEPLOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface FJBFHDHLNEE
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool PLFGBDJNHGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool KJNILIAIDIA
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool LNMLHFKFFCL
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Dictionary<Guid, Guid> TryGetPreviousCloneMapping();

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void TrySetPreviousCloneMapping(Dictionary<Guid, Guid> NPBLCENKKGI);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface CPDFBLPGPME<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool AMLGKDPBNHP
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int MNGINNPFGMB
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<TData> ENECNDPABFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData IFNDNLEGMFO);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData IFNDNLEGMFO);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface DHCAILKKCFF<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T GHMNBJIOGAM, [Optional] CEKFCLEOOAA? IFNKPCOLBOF, bool AEIKLAFAOKG = true);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int FIGHABPEBPG, IEnumerable<T> PBOBDMHLHMC, bool AEIKLAFAOKG = true);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int FIGHABPEBPG, IEnumerable<T> PBOBDMHLHMC, CEKFCLEOOAA IFNKPCOLBOF, bool AEIKLAFAOKG = true);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface OLEAOCKEBLB
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface AIEILFPFGPL
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool CACCADDCJID
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool JAKHCLLBEKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool JKHANPPHMAM
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool AEEELDHPLKE
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class DJNDKCDAAHM<TReceiver> : LLPJLFJPBLF<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3A157B0", Offset = "0x3A141B0", VA = "0x183A157B0")]
	public DJNDKCDAAHM(TReceiver PHPEHEJEKBD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public abstract class JJIFBBHEAMJ<TReceiver, TFromTask> : LLPJLFJPBLF<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3A157B0", Offset = "0x3A141B0", VA = "0x183A157B0")]
	public JJIFBBHEAMJ(TReceiver PHPEHEJEKBD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public abstract class LLPJLFJPBLF<TReceiver, TFromExecute> where TReceiver : notnull where TFromExecute : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	protected TReceiver PHPEHEJEKBD;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x44E5450", Offset = "0x44E3E50", VA = "0x1844E5450")]
	public LLPJLFJPBLF(TReceiver PHPEHEJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute FMNDAIGJPOF();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class IJLHHKOHNJD<TReceiver, TResult> : LLPJLFJPBLF<TReceiver, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3A157B0", Offset = "0x3A141B0", VA = "0x183A157B0")]
	public IJLHHKOHNJD(TReceiver PHPEHEJEKBD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct ILNOBBIBJGI<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public TGroup IHHODKJAEFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public TData GCNCNIIJEBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public IEnumerable<TData> LDCCJLDEHNG;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x203F510", Offset = "0x203DF10", VA = "0x18203F510")]
	public ILNOBBIBJGI(TGroup NCEGBMIAJEF, TData LFAMFLPLNFK, IEnumerable<TData> NAEIKHBKANO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct GJABFOOPJGC<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public TGroup IHHODKJAEFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public IEnumerable<TData> LDCCJLDEHNG;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0xD09E10", Offset = "0xD08810", VA = "0x180D09E10")]
	public GJABFOOPJGC(TGroup NCEGBMIAJEF, IEnumerable<TData> NAEIKHBKANO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct LBGHKGLJGEL<TGroup> where TGroup : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public TGroup IHHODKJAEFH;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0xB66C60", Offset = "0xB65660", VA = "0x180B66C60")]
	public LBGHKGLJGEL(TGroup NCEGBMIAJEF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct ODOHNJAEFCF<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public IEnumerable<TData> LDCCJLDEHNG;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0xB66C60", Offset = "0xB65660", VA = "0x180B66C60")]
	public ODOHNJAEFCF(IEnumerable<TData> NAEIKHBKANO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface DKLDLFBBJHM<TGroup, TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ONIBINKDEPM OGKLCJFDFJM(ILNOBBIBJGI<TGroup, TData> NMJGBDOLDBM);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ONIBINKDEPM FHJDCENGMDO(ILNOBBIBJGI<TGroup, TData> NMJGBDOLDBM);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ONIBINKDEPM EPLBLNBFGPM(GJABFOOPJGC<TGroup, TData> NMJGBDOLDBM);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "3")]
	ONIBINKDEPM PANNAHNGKLD(LBGHKGLJGEL<TGroup> NMJGBDOLDBM);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface NBEAGJIMDPG<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<ONIBINKDEPM> OGKLCJFDFJM(ODOHNJAEFCF<TData> NMJGBDOLDBM);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class LCALBNLNDEK<TGroup, TData> : IJLHHKOHNJD<DKLDLFBBJHM<TGroup, TData>, ONIBINKDEPM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly GJABFOOPJGC<TGroup, TData> NMJGBDOLDBM;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x44CBD30", Offset = "0x44CA730", VA = "0x1844CBD30")]
	public LCALBNLNDEK(TGroup NCEGBMIAJEF, IEnumerable<TData> NAEIKHBKANO, DKLDLFBBJHM<TGroup, TData> PHPEHEJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x44CBC60", Offset = "0x44CA660", VA = "0x1844CBC60", Slot = "4")]
	public override ONIBINKDEPM FMNDAIGJPOF()
	{
		return default(ONIBINKDEPM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class FDJGNGHOAEM<TGroup, TData> : IJLHHKOHNJD<DKLDLFBBJHM<TGroup, TData>, ONIBINKDEPM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly ILNOBBIBJGI<TGroup, TData> NMJGBDOLDBM;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3DDA180", Offset = "0x3DD8B80", VA = "0x183DDA180")]
	public FDJGNGHOAEM(TGroup NCEGBMIAJEF, TData APFOBEGFAOC, IEnumerable<TData> NAEIKHBKANO, DKLDLFBBJHM<TGroup, TData> PHPEHEJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3DDA0A0", Offset = "0x3DD8AA0", VA = "0x183DDA0A0", Slot = "4")]
	public override ONIBINKDEPM FMNDAIGJPOF()
	{
		return default(ONIBINKDEPM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class JOHBKMIPCFD<TGroup, TData> : IJLHHKOHNJD<DKLDLFBBJHM<TGroup, TData>, ONIBINKDEPM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly LBGHKGLJGEL<TGroup> NMJGBDOLDBM;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3F5BD10", Offset = "0x3F5A710", VA = "0x183F5BD10")]
	public JOHBKMIPCFD(TGroup NCEGBMIAJEF, DKLDLFBBJHM<TGroup, TData> PHPEHEJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4328D70", Offset = "0x4327770", VA = "0x184328D70", Slot = "4")]
	public override ONIBINKDEPM FMNDAIGJPOF()
	{
		return default(ONIBINKDEPM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class NDFCNMHDLDB<TGroup, TData> : IJLHHKOHNJD<DKLDLFBBJHM<TGroup, TData>, ONIBINKDEPM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly ILNOBBIBJGI<TGroup, TData> NMJGBDOLDBM;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3DDA180", Offset = "0x3DD8B80", VA = "0x183DDA180")]
	public NDFCNMHDLDB(TGroup NCEGBMIAJEF, TData LFAMFLPLNFK, IEnumerable<TData> NAEIKHBKANO, DKLDLFBBJHM<TGroup, TData> PHPEHEJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x47DD7A0", Offset = "0x47DC1A0", VA = "0x1847DD7A0", Slot = "4")]
	public override ONIBINKDEPM FMNDAIGJPOF()
	{
		return default(ONIBINKDEPM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class HPLAIMDLAKA<TData> : JJIFBBHEAMJ<NBEAGJIMDPG<TData>, ONIBINKDEPM> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private struct NNJNHFBMELJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AsyncTaskMethodBuilder<ONIBINKDEPM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public HPLAIMDLAKA<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private TaskAwaiter<ONIBINKDEPM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x48060B0", Offset = "0x4804AB0", VA = "0x1848060B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x4806350", Offset = "0x4804D50", VA = "0x184806350", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private ODOHNJAEFCF<TData> NMJGBDOLDBM;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3F5BD10", Offset = "0x3F5A710", VA = "0x183F5BD10")]
	public HPLAIMDLAKA(IEnumerable<TData> MIFIMIHHDDC, NBEAGJIMDPG<TData> PHPEHEJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3F5BC10", Offset = "0x3F5A610", VA = "0x183F5BC10", Slot = "4")]
	[AsyncStateMachine(typeof(HPLAIMDLAKA<>.NNJNHFBMELJ))]
	public override Task<ONIBINKDEPM> FMNDAIGJPOF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public readonly struct LEJBENFPHMH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly LEDHPLDKCBM LDDAGLMFIOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly bool FOBGCGAHEAL;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6C95750", Offset = "0x6C94150", VA = "0x186C95750")]
	public LEJBENFPHMH(LEDHPLDKCBM BDHDJKJOCOK, bool ENLKAJGAAEM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface FBOOGALOKAN<TSpawnType> where TSpawnType : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> FMNDAIGJPOF(LEJBENFPHMH AMPHDAIMDFF);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class HDMBCKAODHN<TSpawnType> : JJIFBBHEAMJ<FBOOGALOKAN<TSpawnType>, TSpawnType> where TSpawnType : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private struct OLJLONMONKA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public AsyncTaskMethodBuilder<TSpawnType> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public HDMBCKAODHN<TSpawnType> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskAwaiter<TSpawnType> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x4902200", Offset = "0x4900C00", VA = "0x184902200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x3E12FA0", Offset = "0x3E119A0", VA = "0x183E12FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly LEJBENFPHMH AMPHDAIMDFF;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3F34EB0", Offset = "0x3F338B0", VA = "0x183F34EB0")]
	public HDMBCKAODHN(LEDHPLDKCBM BDHDJKJOCOK, bool ENLKAJGAAEM, FBOOGALOKAN<TSpawnType> PHPEHEJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3F34C90", Offset = "0x3F33690", VA = "0x183F34C90", Slot = "4")]
	[AsyncStateMachine(typeof(HDMBCKAODHN<>.OLJLONMONKA))]
	public override Task<TSpawnType> FMNDAIGJPOF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public readonly struct LEDHPLDKCBM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly bool DGMPJKDNBGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly Vector3 CNEDOCPBIID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly Vector3 EHFBMINIGFL;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6C956E0", Offset = "0x6C940E0", VA = "0x186C956E0")]
	public LEDHPLDKCBM(Transform BCGMOFHEDEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6C95630", Offset = "0x6C94030", VA = "0x186C95630")]
	public LEDHPLDKCBM(Vector3 DBBPPLLNKOD, Vector3 LEELMECKGCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6C95600", Offset = "0x6C94000", VA = "0x186C95600")]
	public static LEDHPLDKCBM HMDPNAMIDEL()
	{
		return default(LEDHPLDKCBM);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6C95660", Offset = "0x6C94060", VA = "0x186C95660")]
	private LEDHPLDKCBM(bool GMEPBOKBNBF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct FDLKDFNBENO<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public TNode BMGCIPBAPOC;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x3DDA700", Offset = "0x3DD9100", VA = "0x183DDA700")]
	public FDLKDFNBENO(TNode BMGCIPBAPOC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct IPPBFBIBPFI<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public TNode OFPEBPJLGHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public DKDGHFLDLKN HPHFOHGFMEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly bool FOBGCGAHEAL;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x40C20F0", Offset = "0x40C0AF0", VA = "0x1840C20F0")]
	public IPPBFBIBPFI(TNode OFPEBPJLGHE, DKDGHFLDLKN HPHFOHGFMEM, bool ENLKAJGAAEM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface PFALCEBKNAJ<TNode>
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NAKLOJIIBOD([In] FDLKDFNBENO<TNode> CFDLPGBHFDI);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OINDHDDEHOP([In] IPPBFBIBPFI<TNode> MCOICLLLMLA);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KFEJLHPHPDJ();
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class AJIICIDLGGJ<TNode> : DJNDKCDAAHM<PFALCEBKNAJ<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3A157B0", Offset = "0x3A141B0", VA = "0x183A157B0")]
	public AJIICIDLGGJ(PFALCEBKNAJ<TNode> PHPEHEJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3DDA260", Offset = "0x3DD8C60", VA = "0x183DDA260", Slot = "4")]
	public override bool FMNDAIGJPOF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class KAIKJEGDPPG<TNode> : DJNDKCDAAHM<PFALCEBKNAJ<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly IPPBFBIBPFI<TNode> MCOICLLLMLA;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x43F2940", Offset = "0x43F1340", VA = "0x1843F2940")]
	public KAIKJEGDPPG(TNode OFPEBPJLGHE, DKDGHFLDLKN HPHFOHGFMEM, PFALCEBKNAJ<TNode> PHPEHEJEKBD, bool ENLKAJGAAEM = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3F312B0", Offset = "0x3F2FCB0", VA = "0x183F312B0", Slot = "4")]
	public override bool FMNDAIGJPOF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class OCMKHHICGBF<TNode> : DJNDKCDAAHM<PFALCEBKNAJ<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly FDLKDFNBENO<TNode> CFDLPGBHFDI;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x48E82F0", Offset = "0x48E6CF0", VA = "0x1848E82F0")]
	public OCMKHHICGBF(TNode HCNONHPKMKM, PFALCEBKNAJ<TNode> PHPEHEJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3ED44C0", Offset = "0x3ED2EC0", VA = "0x183ED44C0", Slot = "4")]
	public override bool FMNDAIGJPOF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct DNHEBOEHAEN<TSpawnInfo> where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public TSpawnInfo JKIGBEGKPNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public Vector3 LEELMECKGCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Quaternion JOLHFCINNMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public float DKEHAFKGJAC;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5B57B20", Offset = "0x5B56520", VA = "0x185B57B20")]
	public DNHEBOEHAEN(TSpawnInfo JKIGBEGKPNO, Vector3 LEELMECKGCG, Quaternion JOLHFCINNMA, float DKEHAFKGJAC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface AHAGBNMLPIB<TSpawnType, TSpawnInfo>
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> GLCPHJCGLJD([In] DNHEBOEHAEN<TSpawnInfo> POFILNPEPBI, CancellationToken IONNNJNKLMJ);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class IBLOFAIAIGM<TSpawnType, TSpawnInfo> : JJIFBBHEAMJ<AHAGBNMLPIB<TSpawnType, TSpawnInfo>, TSpawnType> where TSpawnType : notnull where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly DNHEBOEHAEN<TSpawnInfo> AAAOIGBEBAB;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x401D5B0", Offset = "0x401BFB0", VA = "0x18401D5B0")]
	public IBLOFAIAIGM(TSpawnInfo MCHOALBFHAM, Vector3 LEELMECKGCG, Quaternion JOLHFCINNMA, float DKEHAFKGJAC, AHAGBNMLPIB<TSpawnType, TSpawnInfo> PHPEHEJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x4019A20", Offset = "0x4018420", VA = "0x184019A20", Slot = "4")]
	public override Task<TSpawnType> FMNDAIGJPOF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct KALDEEOLANM<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly IEnumerable<TData> LDCCJLDEHNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly bool FOBGCGAHEAL;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x43F2FA0", Offset = "0x43F19A0", VA = "0x1843F2FA0")]
	public KALDEEOLANM(IEnumerable<TData> NAEIKHBKANO, bool ENLKAJGAAEM = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface DADJMAOJOEI<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<ONIBINKDEPM> PPDILIOPLEH([In] KALDEEOLANM<TData> KNKGPGKFLGH, CancellationToken IONNNJNKLMJ);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public class IBBMIHGJLCF<TData> : JJIFBBHEAMJ<DADJMAOJOEI<TData>, ONIBINKDEPM> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly KALDEEOLANM<TData> KIBMDOEAGFP;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x4019BB0", Offset = "0x40185B0", VA = "0x184019BB0")]
	public IBBMIHGJLCF(IEnumerable<TData> NAEIKHBKANO, bool ENLKAJGAAEM, DADJMAOJOEI<TData> PHPEHEJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x4019A20", Offset = "0x4018420", VA = "0x184019A20", Slot = "4")]
	public override Task<ONIBINKDEPM> FMNDAIGJPOF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct AIPHAEAILLD<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public readonly T LLMCGMPLMBL;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x3DD9FA0", Offset = "0x3DD89A0", VA = "0x183DD9FA0")]
	public AIPHAEAILLD(T MGENGMJJMGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface LMKFHJAGMII<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NAKLOJIIBOD([In] AIPHAEAILLD<T> CEHPCEEKGOM);

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OINDHDDEHOP();
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface BGPMDABPHKF<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FMNDAIGJPOF([In] NJDOKFOPIDI<T> EDBLMGGPJAH);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct NJDOKFOPIDI<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public readonly T LLMCGMPLMBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public readonly bool BCFBOHHHHLM;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x47FC3F0", Offset = "0x47FADF0", VA = "0x1847FC3F0")]
	public NJDOKFOPIDI(T MGENGMJJMGD, bool HBOCBJNGLMI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class PNMEFJMJOMJ<T> : DJNDKCDAAHM<LMKFHJAGMII<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x3A157B0", Offset = "0x3A141B0", VA = "0x183A157B0")]
	public PNMEFJMJOMJ(LMKFHJAGMII<T> PHPEHEJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x4A20010", Offset = "0x4A1EA10", VA = "0x184A20010", Slot = "4")]
	public override bool FMNDAIGJPOF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class BFNINGCKOIA<T> : DJNDKCDAAHM<LMKFHJAGMII<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly AIPHAEAILLD<T> CEHPCEEKGOM;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x511DCD0", Offset = "0x511C6D0", VA = "0x18511DCD0")]
	public BFNINGCKOIA(T LLMCGMPLMBL, LMKFHJAGMII<T> PHPEHEJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x3ED44C0", Offset = "0x3ED2EC0", VA = "0x183ED44C0", Slot = "4")]
	public override bool FMNDAIGJPOF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class GGCFLFLFMHE<T> : DJNDKCDAAHM<BGPMDABPHKF<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly NJDOKFOPIDI<T> EDBLMGGPJAH;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x3ED4580", Offset = "0x3ED2F80", VA = "0x183ED4580")]
	public GGCFLFLFMHE(T LLMCGMPLMBL, bool HBOCBJNGLMI, BGPMDABPHKF<T> PHPEHEJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x3ED44C0", Offset = "0x3ED2EC0", VA = "0x183ED44C0", Slot = "4")]
	public override bool FMNDAIGJPOF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct OKICAPBGAGF<TData> where TData : notnull, FBOAPOKHBJG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public IEnumerable<TData> LDCCJLDEHNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public bool LPNGAPNMNKI;

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x48FE990", Offset = "0x48FD390", VA = "0x1848FE990")]
	public OKICAPBGAGF(IEnumerable<TData> JNFNFHDNKIK, bool MOMDFAIKIHC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public struct IDIJNIHACFA<TData> where TData : notnull, FBOAPOKHBJG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public List<TData> LDCCJLDEHNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public List<bool> FEFADEFPFKH;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x4021940", Offset = "0x4020340", VA = "0x184021940")]
	public IDIJNIHACFA(List<TData> JNFNFHDNKIK, List<bool> LNBEBMKDCIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface FBOAPOKHBJG
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool OFGHIEMBGIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface IOEJBLLFCMN<TData> where TData : FBOAPOKHBJG
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FMNDAIGJPOF([In] OKICAPBGAGF<TData> GMHBFCBKBDA);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FMNDAIGJPOF([In] IDIJNIHACFA<TData> GMHBFCBKBDA);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface BLENLDJMNBB<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DEHHKMCNAGP(T LLMCGMPLMBL);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class IEPJGHPNPIM<TData> : DJNDKCDAAHM<IOEJBLLFCMN<TData>> where TData : notnull, FBOAPOKHBJG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly OKICAPBGAGF<TData> GMHBFCBKBDA;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x4048380", Offset = "0x4046D80", VA = "0x184048380")]
	public IEPJGHPNPIM(List<TData> NAEIKHBKANO, bool LPNGAPNMNKI, IOEJBLLFCMN<TData> PHPEHEJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x3ED44C0", Offset = "0x3ED2EC0", VA = "0x183ED44C0", Slot = "4")]
	public override bool FMNDAIGJPOF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class MOBHIFIFIHI<TData> : DJNDKCDAAHM<IOEJBLLFCMN<TData>> where TData : notnull, FBOAPOKHBJG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly IDIJNIHACFA<TData> GMHBFCBKBDA;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x478D670", Offset = "0x478C070", VA = "0x18478D670")]
	public MOBHIFIFIHI(List<TData> NAEIKHBKANO, List<bool> FEFADEFPFKH, IOEJBLLFCMN<TData> PHPEHEJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x3FD5B30", Offset = "0x3FD4530", VA = "0x183FD5B30", Slot = "4")]
	public override bool FMNDAIGJPOF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface KLLNBAEJOHN<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<ONIBINKDEPM> FMNDAIGJPOF(NHBEJAILOBJ<TData> OEGIAHPGFDD);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class DALDCEKAMBA<TData> : JJIFBBHEAMJ<KLLNBAEJOHN<TData>, ONIBINKDEPM> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct JAOHJNEIAOB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public AsyncTaskMethodBuilder<ONIBINKDEPM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public DALDCEKAMBA<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter<ONIBINKDEPM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x4260100", Offset = "0x425EB00", VA = "0x184260100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x42603F0", Offset = "0x425EDF0", VA = "0x1842603F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly NHBEJAILOBJ<TData> PGIJOHEJBGK;

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5B256C0", Offset = "0x5B240C0", VA = "0x185B256C0")]
	public DALDCEKAMBA(TData BJBJFCCPMME, IReadOnlyList<TData> MDJDELBDKOB, bool ENLKAJGAAEM, KLLNBAEJOHN<TData> PHPEHEJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5B255C0", Offset = "0x5B23FC0", VA = "0x185B255C0", Slot = "4")]
	[AsyncStateMachine(typeof(DALDCEKAMBA<>.JAOHJNEIAOB))]
	public override Task<ONIBINKDEPM> FMNDAIGJPOF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public struct NHBEJAILOBJ<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public TData JPJNABKAKFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public IReadOnlyList<TData> HCJBNJHMKGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public bool FOBGCGAHEAL;

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x47F2510", Offset = "0x47F0F10", VA = "0x1847F2510")]
	public NHBEJAILOBJ(TData BJBJFCCPMME, IReadOnlyList<TData> MDJDELBDKOB, bool ENLKAJGAAEM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface IOGNJDBKJHH<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FMNDAIGJPOF([In] COKCLMMOPFP<TData> PFLFGKENJIM);
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface OGKOIEODPMC<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FMNDAIGJPOF([In] AHKBAGKFJHF<TData> PFLFGKENJIM);
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface HILALNBKGJP<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LNEJJGNMJJI([In] EBFANBKJIDF<TData> PFLFGKENJIM);

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OINDHDDEHOP();
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class HNNCBPHEBLO<TData> : DJNDKCDAAHM<IOGNJDBKJHH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly COKCLMMOPFP<TData> PFLFGKENJIM;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x3F55B60", Offset = "0x3F54560", VA = "0x183F55B60")]
	public HNNCBPHEBLO(IEnumerable<TData> NAEIKHBKANO, MNJGJKEDHBM FEHNKBJAMFH, KLGCHNJKBIE KFGOIEOLDHF, float OAKBDDLJNNB, bool ENLKAJGAAEM, IOGNJDBKJHH<TData> PHPEHEJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3ED44C0", Offset = "0x3ED2EC0", VA = "0x183ED44C0", Slot = "4")]
	public override bool FMNDAIGJPOF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class NNLMIIEMNMN<TData> : DJNDKCDAAHM<OGKOIEODPMC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly AHKBAGKFJHF<TData> PFLFGKENJIM;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x4806570", Offset = "0x4804F70", VA = "0x184806570")]
	public NNLMIIEMNMN(TData[] NAEIKHBKANO, MNJGJKEDHBM[] FEHNKBJAMFH, KLGCHNJKBIE[] KFGOIEOLDHF, float[] OAKBDDLJNNB, OGKOIEODPMC<TData> PHPEHEJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x48063C0", Offset = "0x4804DC0", VA = "0x1848063C0", Slot = "4")]
	public override bool FMNDAIGJPOF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class OEOHMHFPJEL<TData> : DJNDKCDAAHM<HILALNBKGJP<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3A157B0", Offset = "0x3A141B0", VA = "0x183A157B0")]
	public OEOHMHFPJEL(HILALNBKGJP<TData> PHPEHEJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x48EFA70", Offset = "0x48EE470", VA = "0x1848EFA70", Slot = "4")]
	public override bool FMNDAIGJPOF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class PDALBJLHJNN<TData> : DJNDKCDAAHM<HILALNBKGJP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly EBFANBKJIDF<TData> PFLFGKENJIM;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x49E3D30", Offset = "0x49E2730", VA = "0x1849E3D30")]
	public PDALBJLHJNN(IEnumerable<TData> NAEIKHBKANO, MNJGJKEDHBM FEHNKBJAMFH, KLGCHNJKBIE KFGOIEOLDHF, float OAKBDDLJNNB, HILALNBKGJP<TData> PHPEHEJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x48063C0", Offset = "0x4804DC0", VA = "0x1848063C0", Slot = "4")]
	public override bool FMNDAIGJPOF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct COKCLMMOPFP<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public IEnumerable<TData> LDCCJLDEHNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public MNJGJKEDHBM EGMBGINKKJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public KLGCHNJKBIE NJBPHLKMEIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public float OAKBDDLJNNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public bool ENLKAJGAAEM;

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5862420", Offset = "0x5860E20", VA = "0x185862420")]
	public COKCLMMOPFP(IEnumerable<TData> NAEIKHBKANO, MNJGJKEDHBM FEHNKBJAMFH, KLGCHNJKBIE KFGOIEOLDHF, float OAKBDDLJNNB, bool ENLKAJGAAEM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public struct AHKBAGKFJHF<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public TData[] LDCCJLDEHNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public MNJGJKEDHBM[] EGMBGINKKJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public KLGCHNJKBIE[] NJBPHLKMEIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public float[] OAKBDDLJNNB;

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3E85D70", Offset = "0x3E84770", VA = "0x183E85D70")]
	public AHKBAGKFJHF(TData[] NAEIKHBKANO, MNJGJKEDHBM[] FEHNKBJAMFH, KLGCHNJKBIE[] KFGOIEOLDHF, float[] OAKBDDLJNNB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public struct EBFANBKJIDF<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public IEnumerable<TData> LDCCJLDEHNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public MNJGJKEDHBM EGMBGINKKJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public KLGCHNJKBIE NJBPHLKMEIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public float OAKBDDLJNNB;

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3A11FE0", Offset = "0x3A109E0", VA = "0x183A11FE0")]
	public EBFANBKJIDF(IEnumerable<TData> NAEIKHBKANO, MNJGJKEDHBM FEHNKBJAMFH, KLGCHNJKBIE KFGOIEOLDHF, float OAKBDDLJNNB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface KJJKOKPHNMK<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EPLBLNBFGPM([In] CBDEPFHJMIJ<TData> KNKGPGKFLGH);

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PANNAHNGKLD([In] CBDEPFHJMIJ<TData> KNKGPGKFLGH);

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JNAONFODAJM([In] bool HNGALEAPMAJ);

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JBIDDDBPFGF([In] CBDEPFHJMIJ<TData> KNKGPGKFLGH);

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NKFFGNEMMDG();

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool IIHHLEPMAHI([In] TData JINPPKBPCKA);
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class BLBGBLBMGHC<TData> : DJNDKCDAAHM<KJJKOKPHNMK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly CBDEPFHJMIJ<TData> KNKGPGKFLGH;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x5181620", Offset = "0x5180020", VA = "0x185181620")]
	public BLBGBLBMGHC(List<TData> KCIKOPILENN, KJJKOKPHNMK<TData> PHPEHEJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x3ED44C0", Offset = "0x3ED2EC0", VA = "0x183ED44C0", Slot = "4")]
	public override bool FMNDAIGJPOF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class DPIDDNNPHGD<TData> : DJNDKCDAAHM<KJJKOKPHNMK<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3A157B0", Offset = "0x3A141B0", VA = "0x183A157B0")]
	public DPIDDNNPHGD(KJJKOKPHNMK<TData> PHPEHEJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5B5D490", Offset = "0x5B5BE90", VA = "0x185B5D490", Slot = "4")]
	public override bool FMNDAIGJPOF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class CJBCNNKPEAG<TData> : DJNDKCDAAHM<KJJKOKPHNMK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly bool ENLKAJGAAEM;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5681040", Offset = "0x567FA40", VA = "0x185681040")]
	public CJBCNNKPEAG(bool ENLKAJGAAEM, KJJKOKPHNMK<TData> PHPEHEJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x5680FE0", Offset = "0x567F9E0", VA = "0x185680FE0", Slot = "4")]
	public override bool FMNDAIGJPOF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class ANFJJBGKPKJ<TData> : DJNDKCDAAHM<KJJKOKPHNMK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly CBDEPFHJMIJ<TData> KNKGPGKFLGH;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3FD5CA0", Offset = "0x3FD46A0", VA = "0x183FD5CA0")]
	public ANFJJBGKPKJ(List<TData> KCIKOPILENN, bool ENLKAJGAAEM, KJJKOKPHNMK<TData> PHPEHEJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3FD5B30", Offset = "0x3FD4530", VA = "0x183FD5B30", Slot = "4")]
	public override bool FMNDAIGJPOF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class JGBGFCAFBKC<TData> : DJNDKCDAAHM<KJJKOKPHNMK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly TData JINPPKBPCKA;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x4295030", Offset = "0x4293A30", VA = "0x184295030")]
	public JGBGFCAFBKC(TData JINPPKBPCKA, KJJKOKPHNMK<TData> PHPEHEJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x4294F60", Offset = "0x4293960", VA = "0x184294F60", Slot = "4")]
	public override bool FMNDAIGJPOF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class DJGECBPJHBD<TData> : DJNDKCDAAHM<KJJKOKPHNMK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly CBDEPFHJMIJ<TData> KNKGPGKFLGH;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x5B4F8B0", Offset = "0x5B4E2B0", VA = "0x185B4F8B0")]
	public DJGECBPJHBD(IEnumerable<TData> KCIKOPILENN, KJJKOKPHNMK<TData> PHPEHEJEKBD, bool ENLKAJGAAEM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x5B4F730", Offset = "0x5B4E130", VA = "0x185B4F730", Slot = "4")]
	public override bool FMNDAIGJPOF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public struct CBDEPFHJMIJ<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public IEnumerable<TData> LDCCJLDEHNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public bool ENLKAJGAAEM;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x5491FE0", Offset = "0x54909E0", VA = "0x185491FE0")]
	public CBDEPFHJMIJ(IEnumerable<TData> JNFNFHDNKIK, bool MAEJOPALFBN = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface POCMDEFBAAI
{
	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<ONIBINKDEPM> FMNDAIGJPOF(LJNLKDKOEDA ALJFJHLKJFK);
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public class LMLNEGFGGLM : JJIFBBHEAMJ<POCMDEFBAAI, ONIBINKDEPM>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private struct AOOCFGHBKPK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public AsyncTaskMethodBuilder<ONIBINKDEPM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public LMLNEGFGGLM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private TaskAwaiter<ONIBINKDEPM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6C94750", Offset = "0x6C93150", VA = "0x186C94750", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6C949D0", Offset = "0x6C933D0", VA = "0x186C949D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly LJNLKDKOEDA HOGIIHLPKIP;

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6C95860", Offset = "0x6C94260", VA = "0x186C95860")]
	public LMLNEGFGGLM(bool ENLKAJGAAEM, POCMDEFBAAI PHPEHEJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6C95770", Offset = "0x6C94170", VA = "0x186C95770", Slot = "4")]
	[AsyncStateMachine(typeof(AOOCFGHBKPK))]
	public override Task<ONIBINKDEPM> FMNDAIGJPOF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public struct LJNLKDKOEDA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public bool FOBGCGAHEAL;

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x2309290", Offset = "0x2307C90", VA = "0x182309290")]
	public LJNLKDKOEDA(bool ENLKAJGAAEM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public readonly struct JFNFOOPIPOB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly bool EFCOMLCAJLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly bool MCKNEJCAOIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public readonly bool DKEHAFKGJAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public readonly bool ENLKAJGAAEM;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x4F95D80", Offset = "0x4F94780", VA = "0x184F95D80")]
	public JFNFOOPIPOB(bool EFCOMLCAJLK, bool MCKNEJCAOIE, bool DKEHAFKGJAC, bool ENLKAJGAAEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6C955B0", Offset = "0x6C93FB0", VA = "0x186C955B0")]
	public JFNFOOPIPOB(bool MCKNEJCAOIE, bool ENLKAJGAAEM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public interface IBIOHFCHEHD
{
	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PGOEOLNOBBC(JFNFOOPIPOB PHNDAOFALCE);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NBEEDNKDGLE(JFNFOOPIPOB PHNDAOFALCE);
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class IOOCHEAEOCP : DJNDKCDAAHM<IBIOHFCHEHD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly JFNFOOPIPOB PHNDAOFALCE;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6C95520", Offset = "0x6C93F20", VA = "0x186C95520")]
	public IOOCHEAEOCP(bool FLDLBOHKNDN, bool MCKNEJCAOIE, bool DKEHAFKGJAC, bool ENLKAJGAAEM, IBIOHFCHEHD PHPEHEJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6C954D0", Offset = "0x6C93ED0", VA = "0x186C954D0", Slot = "4")]
	public override bool FMNDAIGJPOF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class OPEJMCKIDCM : DJNDKCDAAHM<IBIOHFCHEHD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly JFNFOOPIPOB PHNDAOFALCE;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6C95D30", Offset = "0x6C94730", VA = "0x186C95D30")]
	public OPEJMCKIDCM(bool MCKNEJCAOIE, bool ENLKAJGAAEM, IBIOHFCHEHD PHPEHEJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6C95CE0", Offset = "0x6C946E0", VA = "0x186C95CE0", Slot = "4")]
	public override bool FMNDAIGJPOF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public interface FJLNPPPIAJA
{
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FMNDAIGJPOF([In] ICGIECGCFPK EMGBLGFCIGE);
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class FPEBOPOCHGP : DJNDKCDAAHM<FJLNPPPIAJA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly ICGIECGCFPK EMGBLGFCIGE;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6C94D60", Offset = "0x6C93760", VA = "0x186C94D60")]
	public FPEBOPOCHGP(Guid[] EKBKLBHDPEB, Vector3[] CPPOKDBIIIP, Quaternion[] HNALGINPMEC, float[] GEHPEBPKHBF, Dictionary<Guid, Vector3> IGEPELELIMK, FJLNPPPIAJA PHPEHEJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6C94CB0", Offset = "0x6C936B0", VA = "0x186C94CB0", Slot = "4")]
	public override bool FMNDAIGJPOF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public interface GGDJONENLKL<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NAKLOJIIBOD([In] GHKFGALKKFJ<TData> CFDLPGBHFDI);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LNEJJGNMJJI([In] PBCHHDDHOHI MLDGIMIMKMC);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LNEJJGNMJJI([In] LAEEGHECGID MLDGIMIMKMC);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool OINDHDDEHOP();
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class MGAKDDBNLPH<TData> : DJNDKCDAAHM<GGDJONENLKL<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3A157B0", Offset = "0x3A141B0", VA = "0x183A157B0")]
	public MGAKDDBNLPH(GGDJONENLKL<TData> PHPEHEJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x4769E20", Offset = "0x4768820", VA = "0x184769E20", Slot = "4")]
	public override bool FMNDAIGJPOF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class KLLJHJBMBAL<TData> : DJNDKCDAAHM<GGDJONENLKL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly PBCHHDDHOHI BMGDPEADMHK;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x443DC60", Offset = "0x443C660", VA = "0x18443DC60")]
	public KLLJHJBMBAL(Vector3 JDGGOBODEOO, bool CBJDJPHAOLA, GGDJONENLKL<TData> PHPEHEJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x4283730", Offset = "0x4282130", VA = "0x184283730", Slot = "4")]
	public override bool FMNDAIGJPOF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class NAFJGGFNDDD<TData> : DJNDKCDAAHM<GGDJONENLKL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly LAEEGHECGID BMGDPEADMHK;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x47CFD50", Offset = "0x47CE750", VA = "0x1847CFD50")]
	public NAFJGGFNDDD(Guid NAAHKPOKOMC, int HGFDMIDEFHN, Vector3 LEELMECKGCG, Quaternion JOLHFCINNMA, float PPAGJHCGANB, bool CBJDJPHAOLA, GGDJONENLKL<TData> PHPEHEJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x47CFCF0", Offset = "0x47CE6F0", VA = "0x1847CFCF0", Slot = "4")]
	public override bool FMNDAIGJPOF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class LDODNAJHCFM<TData> : DJNDKCDAAHM<GGDJONENLKL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly GHKFGALKKFJ<TData> BMGDPEADMHK;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x44CBDE0", Offset = "0x44CA7E0", VA = "0x1844CBDE0")]
	public LDODNAJHCFM(TData LLMCGMPLMBL, bool ENLKAJGAAEM, GGDJONENLKL<TData> PHPEHEJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x3ED44C0", Offset = "0x3ED2EC0", VA = "0x183ED44C0", Slot = "4")]
	public override bool FMNDAIGJPOF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public struct PBCHHDDHOHI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly Vector3 JDGGOBODEOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public readonly bool CBJDJPHAOLA;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6C95DB0", Offset = "0x6C947B0", VA = "0x186C95DB0")]
	public PBCHHDDHOHI(Vector3 JDGGOBODEOO, bool CBJDJPHAOLA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public struct LAEEGHECGID
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public readonly Guid NAAHKPOKOMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public readonly int HGFDMIDEFHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public readonly Vector3 LEELMECKGCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public readonly Quaternion JOLHFCINNMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public readonly float PPAGJHCGANB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public readonly bool CBJDJPHAOLA;

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6C955C0", Offset = "0x6C93FC0", VA = "0x186C955C0")]
	public LAEEGHECGID(Guid NAAHKPOKOMC, int HGFDMIDEFHN, Vector3 LEELMECKGCG, Quaternion JOLHFCINNMA, float PPAGJHCGANB, bool CBJDJPHAOLA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public struct GHKFGALKKFJ<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public readonly TData LLMCGMPLMBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public readonly bool ENLKAJGAAEM;

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x3ED7ED0", Offset = "0x3ED68D0", VA = "0x183ED7ED0")]
	public GHKFGALKKFJ(TData LLMCGMPLMBL, bool ENLKAJGAAEM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public interface ENOGPOCAFNI<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FMNDAIGJPOF([In] CKDNAACIKAJ<TData> JCBEGKDNJOH);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FMNDAIGJPOF([In] BAKJHHGKJHM<TData> JCBEGKDNJOH);
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public interface GJJHBAIALFI<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NAKLOJIIBOD([In] DCAGFFJLOFI<TData> EILKEKNMHJA);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LNEJJGNMJJI([In] NHKOBOCLCMI MLDGIMIMKMC);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool OINDHDDEHOP();
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class CKKPONHNIOL<TData> : DJNDKCDAAHM<ENOGPOCAFNI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly CKDNAACIKAJ<TData> JCBEGKDNJOH;

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x577C8A0", Offset = "0x577B2A0", VA = "0x18577C8A0")]
	public CKKPONHNIOL(IEnumerable<TData> NAEIKHBKANO, Vector3 CDEGGCBDLFK, bool ENLKAJGAAEM, ENOGPOCAFNI<TData> PHPEHEJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x3ED44C0", Offset = "0x3ED2EC0", VA = "0x183ED44C0", Slot = "4")]
	public override bool FMNDAIGJPOF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class FDKBPPAOMHF<TData> : DJNDKCDAAHM<GJJHBAIALFI<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x3A157B0", Offset = "0x3A141B0", VA = "0x183A157B0")]
	public FDKBPPAOMHF(GJJHBAIALFI<TData> PHPEHEJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x3DDA260", Offset = "0x3DD8C60", VA = "0x183DDA260", Slot = "4")]
	public override bool FMNDAIGJPOF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class HCHFGKOLKEL<TData> : DJNDKCDAAHM<GJJHBAIALFI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly DCAGFFJLOFI<TData> JCBEGKDNJOH;

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x3F319F0", Offset = "0x3F303F0", VA = "0x183F319F0")]
	public HCHFGKOLKEL(IEnumerable<TData> NAEIKHBKANO, bool ENLKAJGAAEM, GJJHBAIALFI<TData> PHPEHEJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3ED44C0", Offset = "0x3ED2EC0", VA = "0x183ED44C0", Slot = "4")]
	public override bool FMNDAIGJPOF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class KPGKEMGFGHE<TData> : DJNDKCDAAHM<ENOGPOCAFNI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly BAKJHHGKJHM<TData> JCBEGKDNJOH;

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x44479D0", Offset = "0x44463D0", VA = "0x1844479D0")]
	public KPGKEMGFGHE(IEnumerable<TData> NAEIKHBKANO, Vector3 LBELJPDGLMH, IBBFLOMADMA NKOAJBLEBLN, bool ENLKAJGAAEM, ENOGPOCAFNI<TData> PHPEHEJEKBD, Space CJMHLAPHANN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x3F312B0", Offset = "0x3F2FCB0", VA = "0x183F312B0", Slot = "4")]
	public override bool FMNDAIGJPOF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public class JEPGFJJAMNC<TData> : DJNDKCDAAHM<GJJHBAIALFI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly NHKOBOCLCMI JCBEGKDNJOH;

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x4283790", Offset = "0x4282190", VA = "0x184283790")]
	public JEPGFJJAMNC(Vector3 CDEGGCBDLFK, GJJHBAIALFI<TData> PHPEHEJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x4283730", Offset = "0x4282130", VA = "0x184283730", Slot = "4")]
	public override bool FMNDAIGJPOF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct CKDNAACIKAJ<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public readonly IEnumerable<TData> NAEIKHBKANO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public readonly Vector3 CDEGGCBDLFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public readonly bool ENLKAJGAAEM;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x5681990", Offset = "0x5680390", VA = "0x185681990")]
	public CKDNAACIKAJ(IEnumerable<TData> NAEIKHBKANO, Vector3 CDEGGCBDLFK, bool ENLKAJGAAEM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct DCAGFFJLOFI<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public readonly IEnumerable<TData> NAEIKHBKANO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public readonly bool ENLKAJGAAEM;

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x5B2BA50", Offset = "0x5B2A450", VA = "0x185B2BA50")]
	public DCAGFFJLOFI(IEnumerable<TData> NAEIKHBKANO, bool ENLKAJGAAEM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct BAKJHHGKJHM<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public readonly IEnumerable<TData> NAEIKHBKANO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public readonly Vector3 LBELJPDGLMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly IBBFLOMADMA NKOAJBLEBLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public readonly bool ENLKAJGAAEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly Space CJMHLAPHANN;

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x50FEE70", Offset = "0x50FD870", VA = "0x1850FEE70")]
	public BAKJHHGKJHM(IEnumerable<TData> NAEIKHBKANO, Vector3 LBELJPDGLMH, IBBFLOMADMA NKOAJBLEBLN, bool ENLKAJGAAEM, Space CJMHLAPHANN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public struct NHKOBOCLCMI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public readonly Vector3 CDEGGCBDLFK;

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x23092C0", Offset = "0x2307CC0", VA = "0x1823092C0")]
	public NHKOBOCLCMI(Vector3 CDEGGCBDLFK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public enum IBBFLOMADMA
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
[Cpp2IlInjected.Token(Token = "0x2000074")]
public interface HGNBPNFDOBO
{
	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FMNDAIGJPOF([In] JAJAKNENFJP BEBPIPFFJGH);
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class HMJEOEGBCDH : DJNDKCDAAHM<HGNBPNFDOBO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly JAJAKNENFJP BEBPIPFFJGH;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6C94FF0", Offset = "0x6C939F0", VA = "0x186C94FF0")]
	public HMJEOEGBCDH(bool ENLKAJGAAEM, HGNBPNFDOBO PHPEHEJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6C94F40", Offset = "0x6C93940", VA = "0x186C94F40", Slot = "4")]
	public override bool FMNDAIGJPOF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public readonly struct JAJAKNENFJP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public readonly bool ENLKAJGAAEM;

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x2309290", Offset = "0x2307C90", VA = "0x182309290")]
	public JAJAKNENFJP(bool ENLKAJGAAEM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public interface BHICAOKBBPN<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FMNDAIGJPOF([In] PPDGHJABPLO<TData> GAJEJHEONIB);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FMNDAIGJPOF([In] LBOHEHMABEM<TData> GAJEJHEONIB);
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public interface FEKPAPDDHAL<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NAKLOJIIBOD([In] KLKINGDKILF<TData> CFDLPGBHFDI);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LNEJJGNMJJI([In] NLKDCGCMFHG MLDGIMIMKMC);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool OINDHDDEHOP();
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class NJKHCEDLOAH<TData> : DJNDKCDAAHM<BHICAOKBBPN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly PPDGHJABPLO<TData> GAJEJHEONIB;

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x47FC4B0", Offset = "0x47FAEB0", VA = "0x1847FC4B0")]
	public NJKHCEDLOAH(IEnumerable<TData> NAEIKHBKANO, Quaternion CDEGGCBDLFK, Vector3? GHOLPLKOFIA, bool HEKPOIOONOK, bool ENLKAJGAAEM, BHICAOKBBPN<TData> PHPEHEJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x3ED44C0", Offset = "0x3ED2EC0", VA = "0x183ED44C0", Slot = "4")]
	public override bool FMNDAIGJPOF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class BNPMDNEFIIE<TData> : DJNDKCDAAHM<FEKPAPDDHAL<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x3A157B0", Offset = "0x3A141B0", VA = "0x183A157B0")]
	public BNPMDNEFIIE(FEKPAPDDHAL<TData> PHPEHEJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x3DDA260", Offset = "0x3DD8C60", VA = "0x183DDA260", Slot = "4")]
	public override bool FMNDAIGJPOF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class KEOCOJJIJNO<TData> : DJNDKCDAAHM<FEKPAPDDHAL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly KLKINGDKILF<TData> GAJEJHEONIB;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x441D250", Offset = "0x441BC50", VA = "0x18441D250")]
	public KEOCOJJIJNO(IEnumerable<TData> NAEIKHBKANO, bool ENLKAJGAAEM, FEKPAPDDHAL<TData> PHPEHEJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x3ED44C0", Offset = "0x3ED2EC0", VA = "0x183ED44C0", Slot = "4")]
	public override bool FMNDAIGJPOF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class HBOCMMBNNHK<TData> : DJNDKCDAAHM<BHICAOKBBPN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly LBOHEHMABEM<TData> GAJEJHEONIB;

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x3F31380", Offset = "0x3F2FD80", VA = "0x183F31380")]
	public HBOCMMBNNHK(IEnumerable<TData> NAEIKHBKANO, Quaternion PIPOCGEFJAK, IBBFLOMADMA DFKJKPDNFJN, Vector3? GHOLPLKOFIA, bool HEKPOIOONOK, bool ENLKAJGAAEM, Space CJMHLAPHANN, BHICAOKBBPN<TData> PHPEHEJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x3F312B0", Offset = "0x3F2FCB0", VA = "0x183F312B0", Slot = "4")]
	public override bool FMNDAIGJPOF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public class OHOKDNEJHMO<TData> : DJNDKCDAAHM<FEKPAPDDHAL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly NLKDCGCMFHG GAJEJHEONIB;

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x48F7850", Offset = "0x48F6250", VA = "0x1848F7850")]
	public OHOKDNEJHMO(Quaternion CDEGGCBDLFK, Vector3? GHOLPLKOFIA, bool HEKPOIOONOK, FEKPAPDDHAL<TData> PHPEHEJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x4283730", Offset = "0x4282130", VA = "0x184283730", Slot = "4")]
	public override bool FMNDAIGJPOF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public struct PPDGHJABPLO<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public readonly IEnumerable<TData> NAEIKHBKANO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public readonly Quaternion CDEGGCBDLFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public readonly Vector3? GHOLPLKOFIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public readonly bool HEKPOIOONOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public readonly bool ENLKAJGAAEM;

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x4A2D740", Offset = "0x4A2C140", VA = "0x184A2D740")]
	public PPDGHJABPLO(IEnumerable<TData> NAEIKHBKANO, Quaternion CDEGGCBDLFK, Vector3? GHOLPLKOFIA, bool HEKPOIOONOK, bool ENLKAJGAAEM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public struct KLKINGDKILF<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public readonly IEnumerable<TData> NAEIKHBKANO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly bool ENLKAJGAAEM;

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x443D930", Offset = "0x443C330", VA = "0x18443D930")]
	public KLKINGDKILF(IEnumerable<TData> NAEIKHBKANO, bool ENLKAJGAAEM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public struct LBOHEHMABEM<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public readonly IEnumerable<TData> NAEIKHBKANO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public readonly Quaternion PIPOCGEFJAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public readonly IBBFLOMADMA DFKJKPDNFJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public readonly Vector3? GHOLPLKOFIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public readonly bool HEKPOIOONOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public readonly bool ENLKAJGAAEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public readonly Space CJMHLAPHANN;

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x44CB920", Offset = "0x44CA320", VA = "0x1844CB920")]
	public LBOHEHMABEM(IEnumerable<TData> NAEIKHBKANO, Quaternion PIPOCGEFJAK, IBBFLOMADMA DFKJKPDNFJN, Vector3? GHOLPLKOFIA, bool HEKPOIOONOK, bool ENLKAJGAAEM, Space CJMHLAPHANN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public struct NLKDCGCMFHG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public readonly Quaternion CDEGGCBDLFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public readonly Vector3? GHOLPLKOFIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public readonly bool HEKPOIOONOK;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x4F5A030", Offset = "0x4F58A30", VA = "0x184F5A030")]
	public NLKDCGCMFHG(Quaternion CDEGGCBDLFK, Vector3? GHOLPLKOFIA, bool HEKPOIOONOK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public interface NLHNOKKCLKJ<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NAKLOJIIBOD([In] KLKCABAKLHN<TData> CFDLPGBHFDI);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LNEJJGNMJJI([In] GFCMHOFGOJM MLDGIMIMKMC);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LNEJJGNMJJI([In] ICKJDEGJAMD MLDGIMIMKMC);

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool LNEJJGNMJJI([In] ENAAIIEDEKE MLDGIMIMKMC);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool OINDHDDEHOP();
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public class NELKEJHKLHK<TData> : DJNDKCDAAHM<NLHNOKKCLKJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly ENAAIIEDEKE EMAJBHIMBMO;

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x47DE4E0", Offset = "0x47DCEE0", VA = "0x1847DE4E0")]
	public NELKEJHKLHK(Vector3 KJHAEBMDFGG, float OADJCOEBHOM, Vector3 GHOLPLKOFIA, bool FAIIENMKBCM, bool FBFONEECAJK, NLHNOKKCLKJ<TData> PHPEHEJEKBD, Space CJMHLAPHANN = Space.Self)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x47DE480", Offset = "0x47DCE80", VA = "0x1847DE480", Slot = "4")]
	public override bool FMNDAIGJPOF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class EENGDJFLAKG<TData> : DJNDKCDAAHM<NLHNOKKCLKJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x3A157B0", Offset = "0x3A141B0", VA = "0x183A157B0")]
	public EENGDJFLAKG(NLHNOKKCLKJ<TData> PHPEHEJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x3A15760", Offset = "0x3A14160", VA = "0x183A15760", Slot = "4")]
	public override bool FMNDAIGJPOF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class NGOJKGPIKBF<TData> : DJNDKCDAAHM<NLHNOKKCLKJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly KLKCABAKLHN<TData> EMAJBHIMBMO;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x47F0A40", Offset = "0x47EF440", VA = "0x1847F0A40")]
	public NGOJKGPIKBF(IEnumerable<TData> NAEIKHBKANO, bool ENLKAJGAAEM, NLHNOKKCLKJ<TData> PHPEHEJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x3ED44C0", Offset = "0x3ED2EC0", VA = "0x183ED44C0", Slot = "4")]
	public override bool FMNDAIGJPOF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class EELMEAPKONI<TData> : DJNDKCDAAHM<NLHNOKKCLKJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly ICKJDEGJAMD EMAJBHIMBMO;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x3A15690", Offset = "0x3A14090", VA = "0x183A15690")]
	public EELMEAPKONI(float PICAIHEBLBD, bool FFHDGCIMOLE, Vector3 GHOLPLKOFIA, NLHNOKKCLKJ<TData> PHPEHEJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x3A155C0", Offset = "0x3A13FC0", VA = "0x183A155C0", Slot = "4")]
	public override bool FMNDAIGJPOF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public class DFNNCBHNOFI<TData> : DJNDKCDAAHM<NLHNOKKCLKJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly GFCMHOFGOJM EMAJBHIMBMO;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x5B3B220", Offset = "0x5B39C20", VA = "0x185B3B220")]
	public DFNNCBHNOFI(float OADJCOEBHOM, Vector3 GHOLPLKOFIA, NLHNOKKCLKJ<TData> PHPEHEJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x4283730", Offset = "0x4282130", VA = "0x184283730", Slot = "4")]
	public override bool FMNDAIGJPOF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public struct ENAAIIEDEKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public readonly Vector3 KJHAEBMDFGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public readonly float OADJCOEBHOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public readonly Vector3 GHOLPLKOFIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public readonly bool CBJDJPHAOLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public readonly Space CJMHLAPHANN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public readonly bool FBFONEECAJK;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x6C94A40", Offset = "0x6C93440", VA = "0x186C94A40")]
	public ENAAIIEDEKE(Vector3 KJHAEBMDFGG, float OADJCOEBHOM, Vector3 GHOLPLKOFIA, bool CBJDJPHAOLA, bool GPKEKAALJBC, Space CJMHLAPHANN = Space.Self)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct KLKCABAKLHN<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public readonly IEnumerable<TData> NAEIKHBKANO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public readonly bool ENLKAJGAAEM;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x443CFA0", Offset = "0x443B9A0", VA = "0x18443CFA0")]
	public KLKCABAKLHN(IEnumerable<TData> NAEIKHBKANO, bool ENLKAJGAAEM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public struct ICKJDEGJAMD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public readonly float PICAIHEBLBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public readonly bool FFHDGCIMOLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public readonly Vector3 GHOLPLKOFIA;

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6C954B0", Offset = "0x6C93EB0", VA = "0x186C954B0")]
	public ICKJDEGJAMD(float PICAIHEBLBD, bool FFHDGCIMOLE, Vector3 GHOLPLKOFIA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct GFCMHOFGOJM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public readonly float OADJCOEBHOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public readonly Vector3 GHOLPLKOFIA;

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x4F1D000", Offset = "0x4F1BA00", VA = "0x184F1D000")]
	public GFCMHOFGOJM(float OADJCOEBHOM, Vector3 GHOLPLKOFIA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public struct ICGIECGCFPK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public readonly Guid[] NAEIKHBKANO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public readonly bool LKIHINAIBDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public readonly bool NANCIBFCOGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public readonly bool IIKCNCNLAOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public readonly Vector3[] CPPOKDBIIIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public readonly Quaternion[] HNALGINPMEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly float[] GEHPEBPKHBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public readonly Dictionary<Guid, Vector3> IGEPELELIMK;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6C95220", Offset = "0x6C93C20", VA = "0x186C95220")]
	public ICGIECGCFPK(Guid[] EKBKLBHDPEB, Vector3[] CPPOKDBIIIP, Quaternion[] HNALGINPMEC, float[] GEHPEBPKHBF, Dictionary<Guid, Vector3> IGEPELELIMK, bool LKIHINAIBDG = true, bool NANCIBFCOGA = true, bool IIKCNCNLAOL = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6C95050", Offset = "0x6C93A50", VA = "0x186C95050")]
	private static void JDDFJENAGLK(Dictionary<Guid, Vector3> IGEPELELIMK, int DENFBPAJGBP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public static class NMCGLJEAAKL
{
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	private struct LMMOFFKPMPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public bool JPFNBPGCEFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public JEFLJDHAGDI FNPCHNFJDHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public JEFLJDHAGDI BOBIGMMOLFP;
	}

	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private static LMMOFFKPMPM IPJJHDPMPLM;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static CancellationToken EMEGGONDJAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6C95920", Offset = "0x6C94320", VA = "0x186C95920")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	internal static JEFLJDHAGDI FNPCHNFJDHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x6C95AD0", Offset = "0x6C944D0", VA = "0x186C95AD0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x6C958C0", Offset = "0x6C942C0", VA = "0x186C958C0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6C95B70", Offset = "0x6C94570", VA = "0x186C95B70")]
	[DJINMBCHLNM.BKIMOKOFNKD]
	internal static void NKGNNKIFAJN(JEFLJDHAGDI JLKEDLLLDMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6C95990", Offset = "0x6C94390", VA = "0x186C95990")]
	public static void LFBMALNLGLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6C95940", Offset = "0x6C94340", VA = "0x186C95940")]
	private static JEFLJDHAGDI LECDHLNEJAG(JEFLJDHAGDI BFDGPCILEGN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public static class JEFICNGPHGI
{
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public enum IKAMLBDPNIC
	{
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		ICreationContextObject,
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		Guid
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x2E1EA90", Offset = "0x2E1D490", VA = "0x182E1EA90")]
	public static void PHGELBKCJPB<T>(T NFEPGHCPILM, IKAMLBDPNIC JLAAKHANEHC) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x2E1EC00", Offset = "0x2E1D600", VA = "0x182E1EC00")]
	public static void PHGELBKCJPB<T>(T NFEPGHCPILM) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x2E1E610", Offset = "0x2E1D010", VA = "0x182E1E610")]
	public static void FNAJOGHOOPI<T>(T NFEPGHCPILM) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x2E1E9E0", Offset = "0x2E1D3E0", VA = "0x182E1E9E0")]
	public static T PBGHNKGJFJB<T>(IKAMLBDPNIC JLAAKHANEHC) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x2E1E7D0", Offset = "0x2E1D1D0", VA = "0x182E1E7D0")]
	public static bool JLNEIPDMCNA<T>(IKAMLBDPNIC JLAAKHANEHC, T? KHMADKOFDEF, [Out][MaybeNullWhen(false)][NotNullWhen(true)] T MALMIDBFDNC) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x2E1E720", Offset = "0x2E1D120", VA = "0x182E1E720")]
	public static bool HKICPDIBELD<T>(IKAMLBDPNIC JLAAKHANEHC) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x2E1E6C0", Offset = "0x2E1D0C0", VA = "0x182E1E6C0")]
	public static T PBGHNKGJFJB<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x2E1E920", Offset = "0x2E1D320", VA = "0x182E1E920")]
	public static bool JLNEIPDMCNA<T>(T KHMADKOFDEF, [Out] T MALMIDBFDNC) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x2E1E6C0", Offset = "0x2E1D0C0", VA = "0x182E1E6C0")]
	public static bool HKICPDIBELD<T>() where T : class
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
internal static class FNJKBENDKLN
{
	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6C94A80", Offset = "0x6C93480", VA = "0x186C94A80")]
	public static void LCMPOONOCHJ(IEnumerable KKBAGKHGAHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x2D9D110", Offset = "0x2D9BB10", VA = "0x182D9D110")]
	public static void LCMPOONOCHJ<T>(T[] DKEEEGEFALD) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x2D9D2F0", Offset = "0x2D9BCF0", VA = "0x182D9D2F0")]
	public static void LCMPOONOCHJ<T>(T HBEFBGGFFKD) where T : notnull, Enum
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
