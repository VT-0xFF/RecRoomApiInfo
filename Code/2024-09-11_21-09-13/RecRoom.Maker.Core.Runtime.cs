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
		[Cpp2IlInjected.Address(RVA = "0x8AF980", Offset = "0x8ADF80", VA = "0x1808AF980")]
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
		[Cpp2IlInjected.Address(RVA = "0x6BAE9D0", Offset = "0x6BACFD0", VA = "0x186BAE9D0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8B0AE0", Offset = "0x8AF0E0", VA = "0x1808B0AE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8B0B20", Offset = "0x8AF120", VA = "0x1808B0B20")]
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
		[Cpp2IlInjected.Address(RVA = "0x6BAEB40", Offset = "0x6BAD140", VA = "0x186BAEB40", Slot = "8")]
		public override void BHEMPDPJNII(CGCPPALGHJA registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x624B890", Offset = "0x6249E90", VA = "0x18624B890")]
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
	[Cpp2IlInjected.Address(RVA = "0x39405E0", Offset = "0x393EBE0", VA = "0x1839405E0")]
	public DJNDKCDAAHM(TReceiver PHPEHEJEKBD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public abstract class JJIFBBHEAMJ<TReceiver, TFromTask> : LLPJLFJPBLF<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x39405E0", Offset = "0x393EBE0", VA = "0x1839405E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x440E590", Offset = "0x440CB90", VA = "0x18440E590")]
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
	[Cpp2IlInjected.Address(RVA = "0x39405E0", Offset = "0x393EBE0", VA = "0x1839405E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x1F9E640", Offset = "0x1F9CC40", VA = "0x181F9E640")]
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
	[Cpp2IlInjected.Address(RVA = "0xC51880", Offset = "0xC4FE80", VA = "0x180C51880")]
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
	[Cpp2IlInjected.Address(RVA = "0xAB30F0", Offset = "0xAB16F0", VA = "0x180AB30F0")]
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
	[Cpp2IlInjected.Address(RVA = "0xAB30F0", Offset = "0xAB16F0", VA = "0x180AB30F0")]
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
	[Cpp2IlInjected.Address(RVA = "0x43F4E70", Offset = "0x43F3470", VA = "0x1843F4E70")]
	public LCALBNLNDEK(TGroup NCEGBMIAJEF, IEnumerable<TData> NAEIKHBKANO, DKLDLFBBJHM<TGroup, TData> PHPEHEJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x43F4DA0", Offset = "0x43F33A0", VA = "0x1843F4DA0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3D078C0", Offset = "0x3D05EC0", VA = "0x183D078C0")]
	public FDJGNGHOAEM(TGroup NCEGBMIAJEF, TData APFOBEGFAOC, IEnumerable<TData> NAEIKHBKANO, DKLDLFBBJHM<TGroup, TData> PHPEHEJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3D077E0", Offset = "0x3D05DE0", VA = "0x183D077E0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3E93CF0", Offset = "0x3E922F0", VA = "0x183E93CF0")]
	public JOHBKMIPCFD(TGroup NCEGBMIAJEF, DKLDLFBBJHM<TGroup, TData> PHPEHEJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4256580", Offset = "0x4254B80", VA = "0x184256580", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3D078C0", Offset = "0x3D05EC0", VA = "0x183D078C0")]
	public NDFCNMHDLDB(TGroup NCEGBMIAJEF, TData LFAMFLPLNFK, IEnumerable<TData> NAEIKHBKANO, DKLDLFBBJHM<TGroup, TData> PHPEHEJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x4707010", Offset = "0x4705610", VA = "0x184707010", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x472FA20", Offset = "0x472E020", VA = "0x18472FA20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x472FCC0", Offset = "0x472E2C0", VA = "0x18472FCC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private ODOHNJAEFCF<TData> NMJGBDOLDBM;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3E93CF0", Offset = "0x3E922F0", VA = "0x183E93CF0")]
	public HPLAIMDLAKA(IEnumerable<TData> MIFIMIHHDDC, NBEAGJIMDPG<TData> PHPEHEJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3E93BF0", Offset = "0x3E921F0", VA = "0x183E93BF0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x6BAE4C0", Offset = "0x6BACAC0", VA = "0x186BAE4C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x482E620", Offset = "0x482CC20", VA = "0x18482E620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x3DECDB0", Offset = "0x3DEB3B0", VA = "0x183DECDB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly LEJBENFPHMH AMPHDAIMDFF;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3E6D080", Offset = "0x3E6B680", VA = "0x183E6D080")]
	public HDMBCKAODHN(LEDHPLDKCBM BDHDJKJOCOK, bool ENLKAJGAAEM, FBOOGALOKAN<TSpawnType> PHPEHEJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3E6CE60", Offset = "0x3E6B460", VA = "0x183E6CE60", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x6BAE450", Offset = "0x6BACA50", VA = "0x186BAE450")]
	public LEDHPLDKCBM(Transform BCGMOFHEDEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6BAE3A0", Offset = "0x6BAC9A0", VA = "0x186BAE3A0")]
	public LEDHPLDKCBM(Vector3 DBBPPLLNKOD, Vector3 LEELMECKGCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6BAE370", Offset = "0x6BAC970", VA = "0x186BAE370")]
	public static LEDHPLDKCBM HMDPNAMIDEL()
	{
		return default(LEDHPLDKCBM);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6BAE3D0", Offset = "0x6BAC9D0", VA = "0x186BAE3D0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3D07EC0", Offset = "0x3D064C0", VA = "0x183D07EC0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3FF0940", Offset = "0x3FEEF40", VA = "0x183FF0940")]
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
	[Cpp2IlInjected.Address(RVA = "0x39405E0", Offset = "0x393EBE0", VA = "0x1839405E0")]
	public AJIICIDLGGJ(PFALCEBKNAJ<TNode> PHPEHEJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3D079A0", Offset = "0x3D05FA0", VA = "0x183D079A0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x431DD80", Offset = "0x431C380", VA = "0x18431DD80")]
	public KAIKJEGDPPG(TNode OFPEBPJLGHE, DKDGHFLDLKN HPHFOHGFMEM, PFALCEBKNAJ<TNode> PHPEHEJEKBD, bool ENLKAJGAAEM = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3E69480", Offset = "0x3E67A80", VA = "0x183E69480", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x48143C0", Offset = "0x48129C0", VA = "0x1848143C0")]
	public OCMKHHICGBF(TNode HCNONHPKMKM, PFALCEBKNAJ<TNode> PHPEHEJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3DE5CB0", Offset = "0x3DE42B0", VA = "0x183DE5CB0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x5A6F2F0", Offset = "0x5A6D8F0", VA = "0x185A6F2F0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3F4D210", Offset = "0x3F4B810", VA = "0x183F4D210")]
	public IBLOFAIAIGM(TSpawnInfo MCHOALBFHAM, Vector3 LEELMECKGCG, Quaternion JOLHFCINNMA, float DKEHAFKGJAC, AHAGBNMLPIB<TSpawnType, TSpawnInfo> PHPEHEJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x3F49680", Offset = "0x3F47C80", VA = "0x183F49680", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x431E3E0", Offset = "0x431C9E0", VA = "0x18431E3E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3F49810", Offset = "0x3F47E10", VA = "0x183F49810")]
	public IBBMIHGJLCF(IEnumerable<TData> NAEIKHBKANO, bool ENLKAJGAAEM, DADJMAOJOEI<TData> PHPEHEJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x3F49680", Offset = "0x3F47C80", VA = "0x183F49680", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3D076E0", Offset = "0x3D05CE0", VA = "0x183D076E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x4725C40", Offset = "0x4724240", VA = "0x184725C40")]
	public NJDOKFOPIDI(T MGENGMJJMGD, bool HBOCBJNGLMI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class PNMEFJMJOMJ<T> : DJNDKCDAAHM<LMKFHJAGMII<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x39405E0", Offset = "0x393EBE0", VA = "0x1839405E0")]
	public PNMEFJMJOMJ(LMKFHJAGMII<T> PHPEHEJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x4947CA0", Offset = "0x49462A0", VA = "0x184947CA0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x503ACE0", Offset = "0x50392E0", VA = "0x18503ACE0")]
	public BFNINGCKOIA(T LLMCGMPLMBL, LMKFHJAGMII<T> PHPEHEJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x3DE5CB0", Offset = "0x3DE42B0", VA = "0x183DE5CB0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3DE5D70", Offset = "0x3DE4370", VA = "0x183DE5D70")]
	public GGCFLFLFMHE(T LLMCGMPLMBL, bool HBOCBJNGLMI, BGPMDABPHKF<T> PHPEHEJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x3DE5CB0", Offset = "0x3DE42B0", VA = "0x183DE5CB0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x482ADB0", Offset = "0x48293B0", VA = "0x18482ADB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3F515A0", Offset = "0x3F4FBA0", VA = "0x183F515A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3F77C50", Offset = "0x3F76250", VA = "0x183F77C50")]
	public IEPJGHPNPIM(List<TData> NAEIKHBKANO, bool LPNGAPNMNKI, IOEJBLLFCMN<TData> PHPEHEJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x3DE5CB0", Offset = "0x3DE42B0", VA = "0x183DE5CB0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x46B6CC0", Offset = "0x46B52C0", VA = "0x1846B6CC0")]
	public MOBHIFIFIHI(List<TData> NAEIKHBKANO, List<bool> FEFADEFPFKH, IOEJBLLFCMN<TData> PHPEHEJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x3F20AD0", Offset = "0x3F1F0D0", VA = "0x183F20AD0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x4188770", Offset = "0x4186D70", VA = "0x184188770", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x4188A60", Offset = "0x4187060", VA = "0x184188A60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly NHBEJAILOBJ<TData> PGIJOHEJBGK;

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5A3C5A0", Offset = "0x5A3ABA0", VA = "0x185A3C5A0")]
	public DALDCEKAMBA(TData BJBJFCCPMME, IReadOnlyList<TData> MDJDELBDKOB, bool ENLKAJGAAEM, KLLNBAEJOHN<TData> PHPEHEJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5A3C4A0", Offset = "0x5A3AAA0", VA = "0x185A3C4A0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x471BD20", Offset = "0x471A320", VA = "0x18471BD20")]
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
	[Cpp2IlInjected.Address(RVA = "0x3E8CD50", Offset = "0x3E8B350", VA = "0x183E8CD50")]
	public HNNCBPHEBLO(IEnumerable<TData> NAEIKHBKANO, MNJGJKEDHBM FEHNKBJAMFH, KLGCHNJKBIE KFGOIEOLDHF, float OAKBDDLJNNB, bool ENLKAJGAAEM, IOGNJDBKJHH<TData> PHPEHEJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3DE5CB0", Offset = "0x3DE42B0", VA = "0x183DE5CB0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x472FEE0", Offset = "0x472E4E0", VA = "0x18472FEE0")]
	public NNLMIIEMNMN(TData[] NAEIKHBKANO, MNJGJKEDHBM[] FEHNKBJAMFH, KLGCHNJKBIE[] KFGOIEOLDHF, float[] OAKBDDLJNNB, OGKOIEODPMC<TData> PHPEHEJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x472FD30", Offset = "0x472E330", VA = "0x18472FD30", Slot = "4")]
	public override bool FMNDAIGJPOF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class OEOHMHFPJEL<TData> : DJNDKCDAAHM<HILALNBKGJP<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x39405E0", Offset = "0x393EBE0", VA = "0x1839405E0")]
	public OEOHMHFPJEL(HILALNBKGJP<TData> PHPEHEJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x481BFB0", Offset = "0x481A5B0", VA = "0x18481BFB0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x490D2D0", Offset = "0x490B8D0", VA = "0x18490D2D0")]
	public PDALBJLHJNN(IEnumerable<TData> NAEIKHBKANO, MNJGJKEDHBM FEHNKBJAMFH, KLGCHNJKBIE KFGOIEOLDHF, float OAKBDDLJNNB, HILALNBKGJP<TData> PHPEHEJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x472FD30", Offset = "0x472E330", VA = "0x18472FD30", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x5797830", Offset = "0x5795E30", VA = "0x185797830")]
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
	[Cpp2IlInjected.Address(RVA = "0x3DB0400", Offset = "0x3DAEA00", VA = "0x183DB0400")]
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
	[Cpp2IlInjected.Address(RVA = "0x393CE10", Offset = "0x393B410", VA = "0x18393CE10")]
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
	[Cpp2IlInjected.Address(RVA = "0x509DE60", Offset = "0x509C460", VA = "0x18509DE60")]
	public BLBGBLBMGHC(List<TData> KCIKOPILENN, KJJKOKPHNMK<TData> PHPEHEJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x3DE5CB0", Offset = "0x3DE42B0", VA = "0x183DE5CB0", Slot = "4")]
	public override bool FMNDAIGJPOF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class DPIDDNNPHGD<TData> : DJNDKCDAAHM<KJJKOKPHNMK<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x39405E0", Offset = "0x393EBE0", VA = "0x1839405E0")]
	public DPIDDNNPHGD(KJJKOKPHNMK<TData> PHPEHEJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5A74C40", Offset = "0x5A73240", VA = "0x185A74C40", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x55B2C70", Offset = "0x55B1270", VA = "0x1855B2C70")]
	public CJBCNNKPEAG(bool ENLKAJGAAEM, KJJKOKPHNMK<TData> PHPEHEJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x55B2C10", Offset = "0x55B1210", VA = "0x1855B2C10", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3F20C40", Offset = "0x3F1F240", VA = "0x183F20C40")]
	public ANFJJBGKPKJ(List<TData> KCIKOPILENN, bool ENLKAJGAAEM, KJJKOKPHNMK<TData> PHPEHEJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3F20AD0", Offset = "0x3F1F0D0", VA = "0x183F20AD0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x41BC1C0", Offset = "0x41BA7C0", VA = "0x1841BC1C0")]
	public JGBGFCAFBKC(TData JINPPKBPCKA, KJJKOKPHNMK<TData> PHPEHEJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x41BC0F0", Offset = "0x41BA6F0", VA = "0x1841BC0F0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x5A66790", Offset = "0x5A64D90", VA = "0x185A66790")]
	public DJGECBPJHBD(IEnumerable<TData> KCIKOPILENN, KJJKOKPHNMK<TData> PHPEHEJEKBD, bool ENLKAJGAAEM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x5A66610", Offset = "0x5A64C10", VA = "0x185A66610", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x53C7A90", Offset = "0x53C6090", VA = "0x1853C7A90")]
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
		[Cpp2IlInjected.Address(RVA = "0x6BAD4C0", Offset = "0x6BABAC0", VA = "0x186BAD4C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6BAD740", Offset = "0x6BABD40", VA = "0x186BAD740", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly LJNLKDKOEDA HOGIIHLPKIP;

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6BAE5D0", Offset = "0x6BACBD0", VA = "0x186BAE5D0")]
	public LMLNEGFGGLM(bool ENLKAJGAAEM, POCMDEFBAAI PHPEHEJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6BAE4E0", Offset = "0x6BACAE0", VA = "0x186BAE4E0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2266760", Offset = "0x2264D60", VA = "0x182266760")]
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
	[Cpp2IlInjected.Address(RVA = "0x4EC6820", Offset = "0x4EC4E20", VA = "0x184EC6820")]
	public JFNFOOPIPOB(bool EFCOMLCAJLK, bool MCKNEJCAOIE, bool DKEHAFKGJAC, bool ENLKAJGAAEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6BAE320", Offset = "0x6BAC920", VA = "0x186BAE320")]
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
	[Cpp2IlInjected.Address(RVA = "0x6BAE290", Offset = "0x6BAC890", VA = "0x186BAE290")]
	public IOOCHEAEOCP(bool FLDLBOHKNDN, bool MCKNEJCAOIE, bool DKEHAFKGJAC, bool ENLKAJGAAEM, IBIOHFCHEHD PHPEHEJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6BAE240", Offset = "0x6BAC840", VA = "0x186BAE240", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x6BAEAA0", Offset = "0x6BAD0A0", VA = "0x186BAEAA0")]
	public OPEJMCKIDCM(bool MCKNEJCAOIE, bool ENLKAJGAAEM, IBIOHFCHEHD PHPEHEJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6BAEA50", Offset = "0x6BAD050", VA = "0x186BAEA50", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x6BADAD0", Offset = "0x6BAC0D0", VA = "0x186BADAD0")]
	public FPEBOPOCHGP(Guid[] EKBKLBHDPEB, Vector3[] CPPOKDBIIIP, Quaternion[] HNALGINPMEC, float[] GEHPEBPKHBF, Dictionary<Guid, Vector3> IGEPELELIMK, FJLNPPPIAJA PHPEHEJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6BADA20", Offset = "0x6BAC020", VA = "0x186BADA20", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x39405E0", Offset = "0x393EBE0", VA = "0x1839405E0")]
	public MGAKDDBNLPH(GGDJONENLKL<TData> PHPEHEJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x46934D0", Offset = "0x4691AD0", VA = "0x1846934D0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x4368BF0", Offset = "0x43671F0", VA = "0x184368BF0")]
	public KLLJHJBMBAL(Vector3 JDGGOBODEOO, bool CBJDJPHAOLA, GGDJONENLKL<TData> PHPEHEJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x41AB5D0", Offset = "0x41A9BD0", VA = "0x1841AB5D0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x46F95C0", Offset = "0x46F7BC0", VA = "0x1846F95C0")]
	public NAFJGGFNDDD(Guid NAAHKPOKOMC, int HGFDMIDEFHN, Vector3 LEELMECKGCG, Quaternion JOLHFCINNMA, float PPAGJHCGANB, bool CBJDJPHAOLA, GGDJONENLKL<TData> PHPEHEJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x46F9560", Offset = "0x46F7B60", VA = "0x1846F9560", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x43F4F20", Offset = "0x43F3520", VA = "0x1843F4F20")]
	public LDODNAJHCFM(TData LLMCGMPLMBL, bool ENLKAJGAAEM, GGDJONENLKL<TData> PHPEHEJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x3DE5CB0", Offset = "0x3DE42B0", VA = "0x183DE5CB0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x6BAEB20", Offset = "0x6BAD120", VA = "0x186BAEB20")]
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
	[Cpp2IlInjected.Address(RVA = "0x6BAE330", Offset = "0x6BAC930", VA = "0x186BAE330")]
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
	[Cpp2IlInjected.Address(RVA = "0x3DE9C10", Offset = "0x3DE8210", VA = "0x183DE9C10")]
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
	[Cpp2IlInjected.Address(RVA = "0x56AF430", Offset = "0x56ADA30", VA = "0x1856AF430")]
	public CKKPONHNIOL(IEnumerable<TData> NAEIKHBKANO, Vector3 CDEGGCBDLFK, bool ENLKAJGAAEM, ENOGPOCAFNI<TData> PHPEHEJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x3DE5CB0", Offset = "0x3DE42B0", VA = "0x183DE5CB0", Slot = "4")]
	public override bool FMNDAIGJPOF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class FDKBPPAOMHF<TData> : DJNDKCDAAHM<GJJHBAIALFI<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x39405E0", Offset = "0x393EBE0", VA = "0x1839405E0")]
	public FDKBPPAOMHF(GJJHBAIALFI<TData> PHPEHEJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x3D079A0", Offset = "0x3D05FA0", VA = "0x183D079A0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3E69BC0", Offset = "0x3E681C0", VA = "0x183E69BC0")]
	public HCHFGKOLKEL(IEnumerable<TData> NAEIKHBKANO, bool ENLKAJGAAEM, GJJHBAIALFI<TData> PHPEHEJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3DE5CB0", Offset = "0x3DE42B0", VA = "0x183DE5CB0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x4372A10", Offset = "0x4371010", VA = "0x184372A10")]
	public KPGKEMGFGHE(IEnumerable<TData> NAEIKHBKANO, Vector3 LBELJPDGLMH, IBBFLOMADMA NKOAJBLEBLN, bool ENLKAJGAAEM, ENOGPOCAFNI<TData> PHPEHEJEKBD, Space CJMHLAPHANN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x3E69480", Offset = "0x3E67A80", VA = "0x183E69480", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x41AB630", Offset = "0x41A9C30", VA = "0x1841AB630")]
	public JEPGFJJAMNC(Vector3 CDEGGCBDLFK, GJJHBAIALFI<TData> PHPEHEJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x41AB5D0", Offset = "0x41A9BD0", VA = "0x1841AB5D0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x55B3730", Offset = "0x55B1D30", VA = "0x1855B3730")]
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
	[Cpp2IlInjected.Address(RVA = "0x5A42930", Offset = "0x5A40F30", VA = "0x185A42930")]
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
	[Cpp2IlInjected.Address(RVA = "0x501ED10", Offset = "0x501D310", VA = "0x18501ED10")]
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
	[Cpp2IlInjected.Address(RVA = "0x2266790", Offset = "0x2264D90", VA = "0x182266790")]
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
	[Cpp2IlInjected.Address(RVA = "0x6BADD60", Offset = "0x6BAC360", VA = "0x186BADD60")]
	public HMJEOEGBCDH(bool ENLKAJGAAEM, HGNBPNFDOBO PHPEHEJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6BADCB0", Offset = "0x6BAC2B0", VA = "0x186BADCB0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2266760", Offset = "0x2264D60", VA = "0x182266760")]
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
	[Cpp2IlInjected.Address(RVA = "0x4725D00", Offset = "0x4724300", VA = "0x184725D00")]
	public NJKHCEDLOAH(IEnumerable<TData> NAEIKHBKANO, Quaternion CDEGGCBDLFK, Vector3? GHOLPLKOFIA, bool HEKPOIOONOK, bool ENLKAJGAAEM, BHICAOKBBPN<TData> PHPEHEJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x3DE5CB0", Offset = "0x3DE42B0", VA = "0x183DE5CB0", Slot = "4")]
	public override bool FMNDAIGJPOF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class BNPMDNEFIIE<TData> : DJNDKCDAAHM<FEKPAPDDHAL<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x39405E0", Offset = "0x393EBE0", VA = "0x1839405E0")]
	public BNPMDNEFIIE(FEKPAPDDHAL<TData> PHPEHEJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x3D079A0", Offset = "0x3D05FA0", VA = "0x183D079A0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x43486B0", Offset = "0x4346CB0", VA = "0x1843486B0")]
	public KEOCOJJIJNO(IEnumerable<TData> NAEIKHBKANO, bool ENLKAJGAAEM, FEKPAPDDHAL<TData> PHPEHEJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x3DE5CB0", Offset = "0x3DE42B0", VA = "0x183DE5CB0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3E69550", Offset = "0x3E67B50", VA = "0x183E69550")]
	public HBOCMMBNNHK(IEnumerable<TData> NAEIKHBKANO, Quaternion PIPOCGEFJAK, IBBFLOMADMA DFKJKPDNFJN, Vector3? GHOLPLKOFIA, bool HEKPOIOONOK, bool ENLKAJGAAEM, Space CJMHLAPHANN, BHICAOKBBPN<TData> PHPEHEJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x3E69480", Offset = "0x3E67A80", VA = "0x183E69480", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x4824590", Offset = "0x4822B90", VA = "0x184824590")]
	public OHOKDNEJHMO(Quaternion CDEGGCBDLFK, Vector3? GHOLPLKOFIA, bool HEKPOIOONOK, FEKPAPDDHAL<TData> PHPEHEJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x41AB5D0", Offset = "0x41A9BD0", VA = "0x1841AB5D0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x49553D0", Offset = "0x49539D0", VA = "0x1849553D0")]
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
	[Cpp2IlInjected.Address(RVA = "0x43688C0", Offset = "0x4366EC0", VA = "0x1843688C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x43F4A60", Offset = "0x43F3060", VA = "0x1843F4A60")]
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
	[Cpp2IlInjected.Address(RVA = "0x4E8BFF0", Offset = "0x4E8A5F0", VA = "0x184E8BFF0")]
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
	[Cpp2IlInjected.Address(RVA = "0x4707D50", Offset = "0x4706350", VA = "0x184707D50")]
	public NELKEJHKLHK(Vector3 KJHAEBMDFGG, float OADJCOEBHOM, Vector3 GHOLPLKOFIA, bool FAIIENMKBCM, bool FBFONEECAJK, NLHNOKKCLKJ<TData> PHPEHEJEKBD, Space CJMHLAPHANN = Space.Self)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x4707CF0", Offset = "0x47062F0", VA = "0x184707CF0", Slot = "4")]
	public override bool FMNDAIGJPOF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class EENGDJFLAKG<TData> : DJNDKCDAAHM<NLHNOKKCLKJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x39405E0", Offset = "0x393EBE0", VA = "0x1839405E0")]
	public EENGDJFLAKG(NLHNOKKCLKJ<TData> PHPEHEJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x3940590", Offset = "0x393EB90", VA = "0x183940590", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x471A250", Offset = "0x4718850", VA = "0x18471A250")]
	public NGOJKGPIKBF(IEnumerable<TData> NAEIKHBKANO, bool ENLKAJGAAEM, NLHNOKKCLKJ<TData> PHPEHEJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x3DE5CB0", Offset = "0x3DE42B0", VA = "0x183DE5CB0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x39404C0", Offset = "0x393EAC0", VA = "0x1839404C0")]
	public EELMEAPKONI(float PICAIHEBLBD, bool FFHDGCIMOLE, Vector3 GHOLPLKOFIA, NLHNOKKCLKJ<TData> PHPEHEJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x39403F0", Offset = "0x393E9F0", VA = "0x1839403F0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x5A521C0", Offset = "0x5A507C0", VA = "0x185A521C0")]
	public DFNNCBHNOFI(float OADJCOEBHOM, Vector3 GHOLPLKOFIA, NLHNOKKCLKJ<TData> PHPEHEJEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x41AB5D0", Offset = "0x41A9BD0", VA = "0x1841AB5D0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x6BAD7B0", Offset = "0x6BABDB0", VA = "0x186BAD7B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x4367F30", Offset = "0x4366530", VA = "0x184367F30")]
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
	[Cpp2IlInjected.Address(RVA = "0x6BAE220", Offset = "0x6BAC820", VA = "0x186BAE220")]
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
	[Cpp2IlInjected.Address(RVA = "0x4E4D480", Offset = "0x4E4BA80", VA = "0x184E4D480")]
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
	[Cpp2IlInjected.Address(RVA = "0x6BADF90", Offset = "0x6BAC590", VA = "0x186BADF90")]
	public ICGIECGCFPK(Guid[] EKBKLBHDPEB, Vector3[] CPPOKDBIIIP, Quaternion[] HNALGINPMEC, float[] GEHPEBPKHBF, Dictionary<Guid, Vector3> IGEPELELIMK, bool LKIHINAIBDG = true, bool NANCIBFCOGA = true, bool IIKCNCNLAOL = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6BADDC0", Offset = "0x6BAC3C0", VA = "0x186BADDC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6BAE690", Offset = "0x6BACC90", VA = "0x186BAE690")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	internal static JEFLJDHAGDI FNPCHNFJDHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x6BAE840", Offset = "0x6BACE40", VA = "0x186BAE840")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x6BAE630", Offset = "0x6BACC30", VA = "0x186BAE630")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6BAE8E0", Offset = "0x6BACEE0", VA = "0x186BAE8E0")]
	[DJINMBCHLNM.BKIMOKOFNKD]
	internal static void NKGNNKIFAJN(JEFLJDHAGDI JLKEDLLLDMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6BAE700", Offset = "0x6BACD00", VA = "0x186BAE700")]
	public static void LFBMALNLGLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6BAE6B0", Offset = "0x6BACCB0", VA = "0x186BAE6B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2D3F2E0", Offset = "0x2D3D8E0", VA = "0x182D3F2E0")]
	public static void PHGELBKCJPB<T>(T NFEPGHCPILM, IKAMLBDPNIC JLAAKHANEHC) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x2D3F450", Offset = "0x2D3DA50", VA = "0x182D3F450")]
	public static void PHGELBKCJPB<T>(T NFEPGHCPILM) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x2D3EE60", Offset = "0x2D3D460", VA = "0x182D3EE60")]
	public static void FNAJOGHOOPI<T>(T NFEPGHCPILM) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x2D3F230", Offset = "0x2D3D830", VA = "0x182D3F230")]
	public static T PBGHNKGJFJB<T>(IKAMLBDPNIC JLAAKHANEHC) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x2D3F020", Offset = "0x2D3D620", VA = "0x182D3F020")]
	public static bool JLNEIPDMCNA<T>(IKAMLBDPNIC JLAAKHANEHC, T? KHMADKOFDEF, [Out][MaybeNullWhen(false)][NotNullWhen(true)] T MALMIDBFDNC) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x2D3EF70", Offset = "0x2D3D570", VA = "0x182D3EF70")]
	public static bool HKICPDIBELD<T>(IKAMLBDPNIC JLAAKHANEHC) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x2D3EF10", Offset = "0x2D3D510", VA = "0x182D3EF10")]
	public static T PBGHNKGJFJB<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x2D3F170", Offset = "0x2D3D770", VA = "0x182D3F170")]
	public static bool JLNEIPDMCNA<T>(T KHMADKOFDEF, [Out] T MALMIDBFDNC) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x2D3EF10", Offset = "0x2D3D510", VA = "0x182D3EF10")]
	public static bool HKICPDIBELD<T>() where T : class
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
internal static class FNJKBENDKLN
{
	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6BAD7F0", Offset = "0x6BABDF0", VA = "0x186BAD7F0")]
	public static void LCMPOONOCHJ(IEnumerable KKBAGKHGAHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x2CB5140", Offset = "0x2CB3740", VA = "0x182CB5140")]
	public static void LCMPOONOCHJ<T>(T[] DKEEEGEFALD) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x2CB5320", Offset = "0x2CB3920", VA = "0x182CB5320")]
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
