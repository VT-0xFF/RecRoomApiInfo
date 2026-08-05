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
		[Cpp2IlInjected.Address(RVA = "0xA34C70", Offset = "0xA33670", VA = "0x180A34C70")]
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
		[Cpp2IlInjected.Address(RVA = "0x7DA6690", Offset = "0x7DA5090", VA = "0x187DA6690")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA35A80", Offset = "0xA34480", VA = "0x180A35A80")]
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
		[Cpp2IlInjected.Address(RVA = "0xA35AC0", Offset = "0xA344C0", VA = "0x180A35AC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7DA6A80", Offset = "0x7DA5480", VA = "0x187DA6A80", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2796C60", Offset = "0x2795660", VA = "0x182796C60")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum OJGNGALFKDN
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
public interface DFFMPJCMKBA<TData, TReturn>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TReturn IADOGIPDGKI(TData OJDHMKOBKLD);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface NLCOIMPJLHB<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ClearHoverTarget(HEKDOHFNCOE JMJNHHFDELF);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool SetHoverTarget(TData DKLAGICAOGN, Collider OGFOKMFADIB, HEKDOHFNCOE JMJNHHFDELF, [Optional] LBAACCFPEFG? HGIBHIKNNNL);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool TryGetHoverTarget([Out] TData DKLAGICAOGN);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetHoverCollider([Out] Collider OGFOKMFADIB);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface FBCINEDGBFB<TData> : ENOBLFLJLNJ, FJPEHGENCJB<TData>, NIAJDJDFGPM<TData>, JFADDKKFBPO<TData>, LOLOLFMGGPC, HOMHDPCCCBP<TData>, JHJOFGHPNOG, FLKCNMHIEGO
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface HOMHDPCCCBP<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 CHGCFNILDNG, Vector3 HPCBBMBEKNN, float LCMAOMAPNJJ, [Out] T IOMMGGBCCFM, [Out] Vector3 MHADAGNAHGD, [Out] Collider OGFOKMFADIB);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 CHGCFNILDNG, Vector3 HPCBBMBEKNN, float GLLJGLBMFGH, float LCMAOMAPNJJ, T[] OOPIENAEOLD, [Out] Vector3 LILPDHOCALJ, [Out] Collider GGNOBOGDGFJ);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 CHGCFNILDNG, float GLLJGLBMFGH, Vector3 OGIPOONBKEE, T[] OOPIENAEOLD);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetObjectFromColliderInCurrentScope(Collider PPLEGFHNHEE, [Out] T AFBJIFFDPLC);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface ENOBLFLJLNJ
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Bounds ENBAMAIPOFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Transform JPBBCGCLDAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Bounds ENNDKGAFMJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Transform ONJLGLIAANB
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Vector3 CMKAOLFECEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool PEGLAIJNJKI
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
	void SetSelectionBoundsDirty(bool EDNIFCAIOJK = true, int GDNJKKNLFEG = 0);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ShouldHideSelectionBoundsPreview(bool LBABLIKIHNG, object BECBHDDLOHA);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface FLKCNMHIEGO
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	CNBOOGKDGFE IMNKEIGOKOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface PLLKHHDINLC
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool NKBGJCCJHFH
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool BJFJEGJOCIL
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool GGDIDDHGKNI
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
	void TrySetPreviousCloneMapping(Dictionary<Guid, Guid> OLHPCDOBPON);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface JFADDKKFBPO<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool CAPGALNHCDB
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int MABIEPDNAHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<TData> DBONFDACHNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData HMJJODPHKCG);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData HMJJODPHKCG);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface FJPEHGENCJB<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T OJDHMKOBKLD, [Optional] LBAACCFPEFG? LKIOAPBFPML, bool FKGGBNCALJL = true);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int IMCIONKBBCL, IEnumerable<T> JJJFNOILJGJ, bool FKGGBNCALJL = true);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int IMCIONKBBCL, IEnumerable<T> JJJFNOILJGJ, LBAACCFPEFG LKIOAPBFPML, bool FKGGBNCALJL = true);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface JHJOFGHPNOG
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface LOLOLFMGGPC
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool LGNEMICDGJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool KHHKIDNEOGL
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool FAEEFOHJCPM
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool JJKNHGEHHOG
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct ACOIMGJNPHM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public bool MAEICPBHIJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public float? PHINPLHCHMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public float? EFGJLJFEDGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public float? BEGBHJFPJCE;
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct LAIGFGMKKPH<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public IEnumerable<TData> KEJOHEMLDEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public ACOIMGJNPHM GMEKKELHGNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public bool HFADHEKADMA;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5271390", Offset = "0x526FD90", VA = "0x185271390")]
	public LAIGFGMKKPH(IEnumerable<TData> MPNLMIPKIOI, bool FHHOCKIGJAK, float? LNMCLGAIPPF, float? GMBPOMFEMOJ, float? JKANBPMPFHB, bool HFADHEKADMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface PFOOJBGLJLM<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FGCPOFKMMBC([In] LAIGFGMKKPH<TData> MPEOAHOICFG);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class PMIPNJBEPIM<TData> : LMGNCILJNAP<PFOOJBGLJLM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly LAIGFGMKKPH<TData> MPEOAHOICFG;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x578F2D0", Offset = "0x578DCD0", VA = "0x18578F2D0")]
	public PMIPNJBEPIM(IEnumerable<TData> MPNLMIPKIOI, bool FHHOCKIGJAK, float? LNMCLGAIPPF, float? GMBPOMFEMOJ, float? JKANBPMPFHB, bool HFADHEKADMA, PFOOJBGLJLM<TData> BGDEMBOCEKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4697330", Offset = "0x4695D30", VA = "0x184697330", Slot = "4")]
	public override bool FGCPOFKMMBC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct PMAOAAMOOKA<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public IEnumerable<TData> KEJOHEMLDEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public string OFBOEFOIKKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public bool AGBDJJLLPPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public bool HFADHEKADMA;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x578D0F0", Offset = "0x578BAF0", VA = "0x18578D0F0")]
	public PMAOAAMOOKA(IEnumerable<TData> MPNLMIPKIOI, string NFDALJNLFPM, bool KAAEEPCDCGM, bool HFADHEKADMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface NHHIIGOEJEM<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FGCPOFKMMBC([In] PMAOAAMOOKA<TData> MPEOAHOICFG);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class GIEPKPGEKAA<TData> : LMGNCILJNAP<NHHIIGOEJEM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly PMAOAAMOOKA<TData> MPEOAHOICFG;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4C51C10", Offset = "0x4C50610", VA = "0x184C51C10")]
	public GIEPKPGEKAA(IEnumerable<TData> MPNLMIPKIOI, string NFDALJNLFPM, bool KAAEEPCDCGM, bool HFADHEKADMA, NHHIIGOEJEM<TData> BGDEMBOCEKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x4697330", Offset = "0x4695D30", VA = "0x184697330", Slot = "4")]
	public override bool FGCPOFKMMBC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public abstract class LMGNCILJNAP<TReceiver> : DPAGMLFIPJE<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x468DDF0", Offset = "0x468C7F0", VA = "0x18468DDF0")]
	public LMGNCILJNAP(TReceiver BGDEMBOCEKP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public abstract class COOEBEPEMJB<TReceiver, TFromTask> : DPAGMLFIPJE<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x468DDF0", Offset = "0x468C7F0", VA = "0x18468DDF0")]
	public COOEBEPEMJB(TReceiver BGDEMBOCEKP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class DPAGMLFIPJE<TReceiver, TFromExecute> where TReceiver : notnull where TFromExecute : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	protected TReceiver BGDEMBOCEKP;

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x425E820", Offset = "0x425D220", VA = "0x18425E820")]
	public DPAGMLFIPJE(TReceiver BGDEMBOCEKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute FGCPOFKMMBC();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class NHHMHALPHEG<TReceiver, TResult> : DPAGMLFIPJE<TReceiver, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x468DDF0", Offset = "0x468C7F0", VA = "0x18468DDF0")]
	public NHHMHALPHEG(TReceiver BGDEMBOCEKP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct JFNNGBAKKIL<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public TGroup IPMMFGHCIGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public TData DJABAJENNIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public IEnumerable<TData> KEJOHEMLDEM;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2324650", Offset = "0x2323050", VA = "0x182324650")]
	public JFNNGBAKKIL(TGroup KHBBDKHIDLI, TData JEKMBHEAJII, IEnumerable<TData> MPNLMIPKIOI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct BOIPJMIMODK<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public TGroup IPMMFGHCIGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public IEnumerable<TData> KEJOHEMLDEM;

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0xB64460", Offset = "0xB62E60", VA = "0x180B64460")]
	public BOIPJMIMODK(TGroup KHBBDKHIDLI, IEnumerable<TData> MPNLMIPKIOI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct OEJICCCBCLC<TGroup> where TGroup : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public TGroup IPMMFGHCIGI;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0xDCCB40", Offset = "0xDCB540", VA = "0x180DCCB40")]
	public OEJICCCBCLC(TGroup KHBBDKHIDLI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct HMDKBMHAJIM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public IEnumerable<Guid> KEJOHEMLDEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public Guid DODNOMABOOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly bool LJFFFABIEBJ;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7DA5780", Offset = "0x7DA4180", VA = "0x187DA5780")]
	public HMDKBMHAJIM(IEnumerable<Guid> MPNLMIPKIOI, Guid BDBADPFPEIO, bool HFADHEKADMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public struct BOLHECBFPFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public Guid DODNOMABOOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly bool LJFFFABIEBJ;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x27312E0", Offset = "0x272FCE0", VA = "0x1827312E0")]
	public BOLHECBFPFA(Guid BDBADPFPEIO, bool HFADHEKADMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface BAFNJFNJFLI<TGroup, TData>
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PDJLCPICFNJ JIFBCHOHIGA(JFNNGBAKKIL<TGroup, TData> PJLGOACKEEJ);

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "1")]
	PDJLCPICFNJ GPKIKPLAOPA(JFNNGBAKKIL<TGroup, TData> PJLGOACKEEJ);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "2")]
	PDJLCPICFNJ KPACDHGOGCA(BOIPJMIMODK<TGroup, TData> PJLGOACKEEJ);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "3")]
	PDJLCPICFNJ PMGLLGEDOII(OEJICCCBCLC<TGroup> PJLGOACKEEJ);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface DJGGDKJDCNE
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<PDJLCPICFNJ> JIFBCHOHIGA(HMDKBMHAJIM PJLGOACKEEJ);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<PDJLCPICFNJ> GPKIKPLAOPA(BOLHECBFPFA PJLGOACKEEJ);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class ALIHMOPEACA<TGroup, TData> : NHHMHALPHEG<BAFNJFNJFLI<TGroup, TData>, PDJLCPICFNJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly BOIPJMIMODK<TGroup, TData> PJLGOACKEEJ;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x4F725D0", Offset = "0x4F70FD0", VA = "0x184F725D0")]
	public ALIHMOPEACA(TGroup KHBBDKHIDLI, IEnumerable<TData> MPNLMIPKIOI, BAFNJFNJFLI<TGroup, TData> BGDEMBOCEKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x4F72510", Offset = "0x4F70F10", VA = "0x184F72510", Slot = "4")]
	public override PDJLCPICFNJ FGCPOFKMMBC()
	{
		return default(PDJLCPICFNJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class NECKLOLPHGH<TGroup, TData> : NHHMHALPHEG<BAFNJFNJFLI<TGroup, TData>, PDJLCPICFNJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly JFNNGBAKKIL<TGroup, TData> PJLGOACKEEJ;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x54FEE50", Offset = "0x54FD850", VA = "0x1854FEE50")]
	public NECKLOLPHGH(TGroup KHBBDKHIDLI, TData GPBOMEHLDHN, IEnumerable<TData> MPNLMIPKIOI, BAFNJFNJFLI<TGroup, TData> BGDEMBOCEKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x54FED80", Offset = "0x54FD780", VA = "0x1854FED80", Slot = "4")]
	public override PDJLCPICFNJ FGCPOFKMMBC()
	{
		return default(PDJLCPICFNJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class OIMEAJAMBAH<TGroup, TData> : NHHMHALPHEG<BAFNJFNJFLI<TGroup, TData>, PDJLCPICFNJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly OEJICCCBCLC<TGroup> PJLGOACKEEJ;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5665080", Offset = "0x5663A80", VA = "0x185665080")]
	public OIMEAJAMBAH(TGroup KHBBDKHIDLI, BAFNJFNJFLI<TGroup, TData> BGDEMBOCEKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5664FC0", Offset = "0x56639C0", VA = "0x185664FC0", Slot = "4")]
	public override PDJLCPICFNJ FGCPOFKMMBC()
	{
		return default(PDJLCPICFNJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class CEECHDHJFND<TGroup, TData> : NHHMHALPHEG<BAFNJFNJFLI<TGroup, TData>, PDJLCPICFNJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly JFNNGBAKKIL<TGroup, TData> PJLGOACKEEJ;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x54FEE50", Offset = "0x54FD850", VA = "0x1854FEE50")]
	public CEECHDHJFND(TGroup KHBBDKHIDLI, TData JEKMBHEAJII, IEnumerable<TData> MPNLMIPKIOI, BAFNJFNJFLI<TGroup, TData> BGDEMBOCEKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x64BE5D0", Offset = "0x64BCFD0", VA = "0x1864BE5D0", Slot = "4")]
	public override PDJLCPICFNJ FGCPOFKMMBC()
	{
		return default(PDJLCPICFNJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class ACBGHJCMKBE : COOEBEPEMJB<DJGGDKJDCNE, PDJLCPICFNJ>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct KDFCONKOKCB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public AsyncTaskMethodBuilder<PDJLCPICFNJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public ACBGHJCMKBE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private TaskAwaiter<PDJLCPICFNJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7DA6110", Offset = "0x7DA4B10", VA = "0x187DA6110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7DA63B0", Offset = "0x7DA4DB0", VA = "0x187DA63B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private HMDKBMHAJIM PJLGOACKEEJ;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7DA4B70", Offset = "0x7DA3570", VA = "0x187DA4B70")]
	public ACBGHJCMKBE(IEnumerable<Guid> HLPOJBKJGJK, Guid BDBADPFPEIO, bool HFADHEKADMA, DJGGDKJDCNE BGDEMBOCEKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7DA4A80", Offset = "0x7DA3480", VA = "0x187DA4A80", Slot = "4")]
	[AsyncStateMachine(typeof(KDFCONKOKCB))]
	public override Task<PDJLCPICFNJ> FGCPOFKMMBC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class DEFPGGKEJCB : COOEBEPEMJB<DJGGDKJDCNE, PDJLCPICFNJ>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private struct OJEJMJLIMBL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public AsyncTaskMethodBuilder<PDJLCPICFNJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public DEFPGGKEJCB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private TaskAwaiter<PDJLCPICFNJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7DA6710", Offset = "0x7DA5110", VA = "0x187DA6710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7DA69B0", Offset = "0x7DA53B0", VA = "0x187DA69B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly BOLHECBFPFA PJLGOACKEEJ;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7DA5180", Offset = "0x7DA3B80", VA = "0x187DA5180")]
	public DEFPGGKEJCB(Guid BDBADPFPEIO, bool HFADHEKADMA, DJGGDKJDCNE BGDEMBOCEKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7DA5090", Offset = "0x7DA3A90", VA = "0x187DA5090", Slot = "4")]
	[AsyncStateMachine(typeof(OJEJMJLIMBL))]
	public override Task<PDJLCPICFNJ> FGCPOFKMMBC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public readonly struct OKMIACOEBCP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly DFNDLLFJGND DNGCKILAEPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly bool LJFFFABIEBJ;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7DA6A20", Offset = "0x7DA5420", VA = "0x187DA6A20")]
	public OKMIACOEBCP(DFNDLLFJGND HEMJJACBDLH, bool HFADHEKADMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface MEIINCJCCJG<TSpawnType> where TSpawnType : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> FGCPOFKMMBC(OKMIACOEBCP OJEPCLHCDKD);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class DNNLMPLEPLF<TSpawnType> : COOEBEPEMJB<MEIINCJCCJG<TSpawnType>, TSpawnType> where TSpawnType : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct KKMNGGPFHKM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public AsyncTaskMethodBuilder<TSpawnType> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public DNNLMPLEPLF<TSpawnType> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private TaskAwaiter<TSpawnType> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x51CF1E0", Offset = "0x51CDBE0", VA = "0x1851CF1E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x4C353B0", Offset = "0x4C33DB0", VA = "0x184C353B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly OKMIACOEBCP OJEPCLHCDKD;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6B13140", Offset = "0x6B11B40", VA = "0x186B13140")]
	public DNNLMPLEPLF(DFNDLLFJGND HEMJJACBDLH, bool HFADHEKADMA, MEIINCJCCJG<TSpawnType> BGDEMBOCEKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6B12F60", Offset = "0x6B11960", VA = "0x186B12F60", Slot = "4")]
	[AsyncStateMachine(typeof(DNNLMPLEPLF<>.KKMNGGPFHKM))]
	public override Task<TSpawnType> FGCPOFKMMBC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public readonly struct DFNDLLFJGND
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly bool BLOBCMGJAOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly Vector3 BLIGGEMHGBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly Vector3 ICJIGFAHILA;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7DA5260", Offset = "0x7DA3C60", VA = "0x187DA5260")]
	public DFNDLLFJGND(Transform BCHDOONNMPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7DA5230", Offset = "0x7DA3C30", VA = "0x187DA5230")]
	public DFNDLLFJGND(Vector3 ODJALHAEEDH, Vector3 JFMEMBGKAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7DA5200", Offset = "0x7DA3C00", VA = "0x187DA5200")]
	public static DFNDLLFJGND FDFMDNPNFDC()
	{
		return default(DFNDLLFJGND);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7DA52D0", Offset = "0x7DA3CD0", VA = "0x187DA52D0")]
	private DFNDLLFJGND(bool FHEGPOMHGHF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct LEEJNENDIDK<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public TNode BGNCMHEBHAB;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x52798A0", Offset = "0x52782A0", VA = "0x1852798A0")]
	public LEEJNENDIDK(TNode BGNCMHEBHAB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct LIDKIELGKBJ<TNode, TReparentOperations> where TNode : notnull where TReparentOperations : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public TNode BHJLBLKOCPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public TReparentOperations BOIJJBKLIFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public NMLBMPIGNOL FLIACDBBKLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly bool LJFFFABIEBJ;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x528B590", Offset = "0x5289F90", VA = "0x18528B590")]
	public LIDKIELGKBJ(TNode BHJLBLKOCPJ, TReparentOperations BOIJJBKLIFD, NMLBMPIGNOL FLIACDBBKLL, bool HFADHEKADMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface MIDFCKLCGIP<TNode, TReparentOperations>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EKJNGJPDMHO([In] LEEJNENDIDK<TNode> CFLGPJBECIK);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LEOPFJCGJBA([In] LIDKIELGKBJ<TNode, TReparentOperations> HCOGIANEIEC);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MFLKLOPJJBG();
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class KGLEOBNIDDG<TNode, TReparentOperations> : LMGNCILJNAP<MIDFCKLCGIP<TNode, TReparentOperations>>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x468DDF0", Offset = "0x468C7F0", VA = "0x18468DDF0")]
	public KGLEOBNIDDG(MIDFCKLCGIP<TNode, TReparentOperations> BGDEMBOCEKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x4CF3770", Offset = "0x4CF2170", VA = "0x184CF3770", Slot = "4")]
	public override bool FGCPOFKMMBC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class NJIFGBLDMOA<TNode, TReparentOperations> : LMGNCILJNAP<MIDFCKLCGIP<TNode, TReparentOperations>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly LIDKIELGKBJ<TNode, TReparentOperations> HCOGIANEIEC;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x550F300", Offset = "0x550DD00", VA = "0x18550F300")]
	public NJIFGBLDMOA(TNode BHJLBLKOCPJ, TReparentOperations BOIJJBKLIFD, NMLBMPIGNOL FLIACDBBKLL, MIDFCKLCGIP<TNode, TReparentOperations> BGDEMBOCEKP, bool HFADHEKADMA = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x54ABE50", Offset = "0x54AA850", VA = "0x1854ABE50", Slot = "4")]
	public override bool FGCPOFKMMBC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class MKNAPNNLCFH<TNode, TReparentOperations> : LMGNCILJNAP<MIDFCKLCGIP<TNode, TReparentOperations>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly LEEJNENDIDK<TNode> CFLGPJBECIK;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5497EE0", Offset = "0x54968E0", VA = "0x185497EE0")]
	public MKNAPNNLCFH(TNode FNALNJKNCPP, MIDFCKLCGIP<TNode, TReparentOperations> BGDEMBOCEKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x4697330", Offset = "0x4695D30", VA = "0x184697330", Slot = "4")]
	public override bool FGCPOFKMMBC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct KECONMJNEDI<TSpawnInfo> where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public TSpawnInfo JKEBFPIBCOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public Vector3 JFMEMBGKAOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public Quaternion NGPACIMGGNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public float JAHHKOMJJAE;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x51B0460", Offset = "0x51AEE60", VA = "0x1851B0460")]
	public KECONMJNEDI(TSpawnInfo JKEBFPIBCOC, Vector3 JFMEMBGKAOB, Quaternion NGPACIMGGNA, float JAHHKOMJJAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface FLOGHOPAHGO<TSpawnType, TSpawnInfo>
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> MCJDLCKMNAK([In] KECONMJNEDI<TSpawnInfo> LHLHDNDHMNN, CancellationToken JKPNCAGHEDI);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class HIAGGOFJMMC<TSpawnType, TSpawnInfo> : COOEBEPEMJB<FLOGHOPAHGO<TSpawnType, TSpawnInfo>, TSpawnType> where TSpawnType : notnull where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly KECONMJNEDI<TSpawnInfo> MPEOAHOICFG;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4CF5AC0", Offset = "0x4CF44C0", VA = "0x184CF5AC0")]
	public HIAGGOFJMMC(TSpawnInfo JKJACCAANOF, Vector3 JFMEMBGKAOB, Quaternion NGPACIMGGNA, float JAHHKOMJJAE, FLOGHOPAHGO<TSpawnType, TSpawnInfo> BGDEMBOCEKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4CF58E0", Offset = "0x4CF42E0", VA = "0x184CF58E0", Slot = "4")]
	public override Task<TSpawnType> FGCPOFKMMBC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public readonly struct DPDJACOPLAO<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly IEnumerable<TData> KEJOHEMLDEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly bool LJFFFABIEBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly bool LFDHIGMOIFD;

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x425E9D0", Offset = "0x425D3D0", VA = "0x18425E9D0")]
	public DPDJACOPLAO(IEnumerable<TData> MPNLMIPKIOI, bool HFADHEKADMA = false, bool CKDOFFPPAEK = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface MCIALJGODDA<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<PDJLCPICFNJ> CBLFPGKMPLH([In] DPDJACOPLAO<TData> FCGGNCFIGCA, CancellationToken JKPNCAGHEDI);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class CHOKGIFMCKG<TData> : COOEBEPEMJB<MCIALJGODDA<TData>, PDJLCPICFNJ> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly DPDJACOPLAO<TData> OFFABKLHOKE;

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x65898C0", Offset = "0x65882C0", VA = "0x1865898C0")]
	public CHOKGIFMCKG(IEnumerable<TData> MPNLMIPKIOI, bool HFADHEKADMA, MCIALJGODDA<TData> BGDEMBOCEKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x4CF58E0", Offset = "0x4CF42E0", VA = "0x184CF58E0", Slot = "4")]
	public override Task<PDJLCPICFNJ> FGCPOFKMMBC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public struct KCGEKHHBBJA<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly T DKLAGICAOGN;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x4C870B0", Offset = "0x4C85AB0", VA = "0x184C870B0")]
	public KCGEKHHBBJA(T KBBBLFGIINI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface MPAJHMCJFIJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EKJNGJPDMHO([In] KCGEKHHBBJA<T> NLLDKCIDLGO);

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LEOPFJCGJBA();
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface GLPKDIICJNC<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FGCPOFKMMBC([In] FJNLCBMAHGJ<T> DJCFJLILIGM);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public struct FJNLCBMAHGJ<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly T DKLAGICAOGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly bool CEBAGKABLDC;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x4B4C170", Offset = "0x4B4AB70", VA = "0x184B4C170")]
	public FJNLCBMAHGJ(T KBBBLFGIINI, bool NBCECJLAKKE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class EEFAHIMFMMH<T> : LMGNCILJNAP<MPAJHMCJFIJ<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x468DDF0", Offset = "0x468C7F0", VA = "0x18468DDF0")]
	public EEFAHIMFMMH(MPAJHMCJFIJ<T> BGDEMBOCEKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x468DDA0", Offset = "0x468C7A0", VA = "0x18468DDA0", Slot = "4")]
	public override bool FGCPOFKMMBC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class BMPMKAAMPNB<T> : LMGNCILJNAP<MPAJHMCJFIJ<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly KCGEKHHBBJA<T> NLLDKCIDLGO;

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6202DE0", Offset = "0x62017E0", VA = "0x186202DE0")]
	public BMPMKAAMPNB(T DKLAGICAOGN, MPAJHMCJFIJ<T> BGDEMBOCEKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x4697330", Offset = "0x4695D30", VA = "0x184697330", Slot = "4")]
	public override bool FGCPOFKMMBC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class NFEAGPLJIMA<T> : LMGNCILJNAP<GLPKDIICJNC<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly FJNLCBMAHGJ<T> DJCFJLILIGM;

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x54FF8F0", Offset = "0x54FE2F0", VA = "0x1854FF8F0")]
	public NFEAGPLJIMA(T DKLAGICAOGN, bool NBCECJLAKKE, GLPKDIICJNC<T> BGDEMBOCEKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x4697330", Offset = "0x4695D30", VA = "0x184697330", Slot = "4")]
	public override bool FGCPOFKMMBC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public struct FIHGJEMGGMM<TData> where TData : notnull, DJCMFKJAMHI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public IEnumerable<TData> KEJOHEMLDEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public bool JBLEHNEKABO;

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x4B417D0", Offset = "0x4B401D0", VA = "0x184B417D0")]
	public FIHGJEMGGMM(IEnumerable<TData> NJPPIPOGPOD, bool DOLHMANAIFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public struct NPECHLFBOGK<TData> where TData : notnull, DJCMFKJAMHI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public List<TData> KEJOHEMLDEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public List<bool> DHJJCIBLGBO;

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x55575D0", Offset = "0x5555FD0", VA = "0x1855575D0")]
	public NPECHLFBOGK(List<TData> NJPPIPOGPOD, List<bool> HEDCPDCGGHM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface DJCMFKJAMHI
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool DGAKBIIJBJI
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
public interface EHJLFNKHLFE<TData> where TData : DJCMFKJAMHI
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FGCPOFKMMBC([In] FIHGJEMGGMM<TData> BPJAODKBAAP);

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FGCPOFKMMBC([In] NPECHLFBOGK<TData> BPJAODKBAAP);
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface IAALOGIEODH<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PCIICOJPCPJ(T DKLAGICAOGN);
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class GCIGGEGFHDH<TData> : LMGNCILJNAP<EHJLFNKHLFE<TData>> where TData : notnull, DJCMFKJAMHI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly FIHGJEMGGMM<TData> BPJAODKBAAP;

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x4C324B0", Offset = "0x4C30EB0", VA = "0x184C324B0")]
	public GCIGGEGFHDH(List<TData> MPNLMIPKIOI, bool JBLEHNEKABO, EHJLFNKHLFE<TData> BGDEMBOCEKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x4697330", Offset = "0x4695D30", VA = "0x184697330", Slot = "4")]
	public override bool FGCPOFKMMBC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class KEPODMGPHGB<TData> : LMGNCILJNAP<EHJLFNKHLFE<TData>> where TData : notnull, DJCMFKJAMHI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly NPECHLFBOGK<TData> BPJAODKBAAP;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x51B3A90", Offset = "0x51B2490", VA = "0x1851B3A90")]
	public KEPODMGPHGB(List<TData> MPNLMIPKIOI, List<bool> DHJJCIBLGBO, EHJLFNKHLFE<TData> BGDEMBOCEKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x50C84C0", Offset = "0x50C6EC0", VA = "0x1850C84C0", Slot = "4")]
	public override bool FGCPOFKMMBC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public interface EHCEEHPGFJJ<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<PDJLCPICFNJ> FGCPOFKMMBC(LOBOMFCMDJN<TData> HDPGJFPOMBJ);
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class DLDEJKJMEAI<TData> : COOEBEPEMJB<EHCEEHPGFJJ<TData>, PDJLCPICFNJ> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private struct EPNKFNFAPLA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public AsyncTaskMethodBuilder<PDJLCPICFNJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public DLDEJKJMEAI<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private TaskAwaiter<PDJLCPICFNJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x46F9940", Offset = "0x46F8340", VA = "0x1846F9940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x46F9C20", Offset = "0x46F8620", VA = "0x1846F9C20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly LOBOMFCMDJN<TData> BIMDEGLDPCK;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6AFEFB0", Offset = "0x6AFD9B0", VA = "0x186AFEFB0")]
	public DLDEJKJMEAI(TData DNHHNIHIIOG, IReadOnlyList<TData> LCJOFHOFOHO, bool HFADHEKADMA, EHCEEHPGFJJ<TData> BGDEMBOCEKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6AFEEB0", Offset = "0x6AFD8B0", VA = "0x186AFEEB0", Slot = "4")]
	[AsyncStateMachine(typeof(DLDEJKJMEAI<>.EPNKFNFAPLA))]
	public override Task<PDJLCPICFNJ> FGCPOFKMMBC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct LOBOMFCMDJN<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public TData ANNNHCLAADH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public IReadOnlyList<TData> GKFMCPFDOLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public bool LJFFFABIEBJ;

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2E47320", Offset = "0x2E45D20", VA = "0x182E47320")]
	public LOBOMFCMDJN(TData DNHHNIHIIOG, IReadOnlyList<TData> LCJOFHOFOHO, bool HFADHEKADMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public interface HHAIGFEPMAP<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FGCPOFKMMBC([In] OBBOGAKNGLE<TData> HDEMIFIMCBE);
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public interface BKIKPJOGLGL<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FGCPOFKMMBC([In] NIIAPCMNPFD<TData> HDEMIFIMCBE);
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface ANGIDMPHJHI<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IPOMOADNADA([In] EMCAFGHHEJH<TData> HDEMIFIMCBE);

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LEOPFJCGJBA();
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class FKHDDEFEGCO<TData> : LMGNCILJNAP<HHAIGFEPMAP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly OBBOGAKNGLE<TData> HDEMIFIMCBE;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x4B51130", Offset = "0x4B4FB30", VA = "0x184B51130")]
	public FKHDDEFEGCO(IEnumerable<TData> MPNLMIPKIOI, AOFPBDKJHJG JJNDBAIEAAG, OCLKLGODOEL NJABANIHMHL, float GNGFKAPLEPB, string? NFDALJNLFPM, bool FLFMAFHLFDB, bool HFADHEKADMA, HHAIGFEPMAP<TData> BGDEMBOCEKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x4697330", Offset = "0x4695D30", VA = "0x184697330", Slot = "4")]
	public override bool FGCPOFKMMBC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class BGCDIOPIGNH<TData> : LMGNCILJNAP<BKIKPJOGLGL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly NIIAPCMNPFD<TData> HDEMIFIMCBE;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x610DA10", Offset = "0x610C410", VA = "0x18610DA10")]
	public BGCDIOPIGNH(TData[] MPNLMIPKIOI, AOFPBDKJHJG[] JJNDBAIEAAG, OCLKLGODOEL[] NJABANIHMHL, float[] GNGFKAPLEPB, BKIKPJOGLGL<TData> BGDEMBOCEKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5472D70", Offset = "0x5471770", VA = "0x185472D70", Slot = "4")]
	public override bool FGCPOFKMMBC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class PCBAMGHOAJD<TData> : LMGNCILJNAP<ANGIDMPHJHI<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x468DDF0", Offset = "0x468C7F0", VA = "0x18468DDF0")]
	public PCBAMGHOAJD(ANGIDMPHJHI<TData> BGDEMBOCEKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5756180", Offset = "0x5754B80", VA = "0x185756180", Slot = "4")]
	public override bool FGCPOFKMMBC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class MCAEDNCMMFD<TData> : LMGNCILJNAP<ANGIDMPHJHI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly EMCAFGHHEJH<TData> HDEMIFIMCBE;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5472E20", Offset = "0x5471820", VA = "0x185472E20")]
	public MCAEDNCMMFD(IEnumerable<TData> MPNLMIPKIOI, AOFPBDKJHJG JJNDBAIEAAG, OCLKLGODOEL NJABANIHMHL, float GNGFKAPLEPB, ANGIDMPHJHI<TData> BGDEMBOCEKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x5472D70", Offset = "0x5471770", VA = "0x185472D70", Slot = "4")]
	public override bool FGCPOFKMMBC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public struct OBBOGAKNGLE<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public IEnumerable<TData> KEJOHEMLDEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public AOFPBDKJHJG BMCDLJBPPLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public OCLKLGODOEL BOKLPDEMDBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public float OABPIGFMENH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public string? OFBOEFOIKKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public bool? CLOPLKHOJCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public bool LJFFFABIEBJ;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x56516D0", Offset = "0x56500D0", VA = "0x1856516D0")]
	public OBBOGAKNGLE(IEnumerable<TData> MPNLMIPKIOI, AOFPBDKJHJG JJNDBAIEAAG, OCLKLGODOEL NJABANIHMHL, float GNGFKAPLEPB, string? NFDALJNLFPM, bool? FLFMAFHLFDB, bool HFADHEKADMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public struct NIIAPCMNPFD<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public TData[] KEJOHEMLDEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public AOFPBDKJHJG[] BMCDLJBPPLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public OCLKLGODOEL[] BOKLPDEMDBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public float[] GNGFKAPLEPB;

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x5507C80", Offset = "0x5506680", VA = "0x185507C80")]
	public NIIAPCMNPFD(TData[] MPNLMIPKIOI, AOFPBDKJHJG[] JJNDBAIEAAG, OCLKLGODOEL[] NJABANIHMHL, float[] GNGFKAPLEPB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct EMCAFGHHEJH<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public IEnumerable<TData> KEJOHEMLDEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public AOFPBDKJHJG BMCDLJBPPLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public OCLKLGODOEL BOKLPDEMDBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public float GNGFKAPLEPB;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x46B5650", Offset = "0x46B4050", VA = "0x1846B5650")]
	public EMCAFGHHEJH(IEnumerable<TData> MPNLMIPKIOI, AOFPBDKJHJG JJNDBAIEAAG, OCLKLGODOEL NJABANIHMHL, float GNGFKAPLEPB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface NIAJDJDFGPM<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KPACDHGOGCA([In] MBNIFAFKBCJ<TData> FCGGNCFIGCA);

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PMGLLGEDOII([In] MBNIFAFKBCJ<TData> FCGGNCFIGCA);

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MNFEHBGKJOO([In] bool HNONOKIPFJN);

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool AKMLJDIGGNA([In] MBNIFAFKBCJ<TData> FCGGNCFIGCA);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NNLGIODHFCF();

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool FCCPFICOFDE([In] TData HAGEAKNDEBH);
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class JOJEKMGGDBL<TData> : LMGNCILJNAP<NIAJDJDFGPM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly MBNIFAFKBCJ<TData> FCGGNCFIGCA;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x50C86C0", Offset = "0x50C70C0", VA = "0x1850C86C0")]
	public JOJEKMGGDBL(List<TData> PCNLBIOPFBD, NIAJDJDFGPM<TData> BGDEMBOCEKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x4697330", Offset = "0x4695D30", VA = "0x184697330", Slot = "4")]
	public override bool FGCPOFKMMBC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class AFINODMNMMC<TData> : LMGNCILJNAP<NIAJDJDFGPM<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x468DDF0", Offset = "0x468C7F0", VA = "0x18468DDF0")]
	public AFINODMNMMC(NIAJDJDFGPM<TData> BGDEMBOCEKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x4CA9E60", Offset = "0x4CA8860", VA = "0x184CA9E60", Slot = "4")]
	public override bool FGCPOFKMMBC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class HPMGMAIAGIF<TData> : LMGNCILJNAP<NIAJDJDFGPM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly bool HFADHEKADMA;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x4D11040", Offset = "0x4D0FA40", VA = "0x184D11040")]
	public HPMGMAIAGIF(bool HFADHEKADMA, NIAJDJDFGPM<TData> BGDEMBOCEKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x4D10FE0", Offset = "0x4D0F9E0", VA = "0x184D10FE0", Slot = "4")]
	public override bool FGCPOFKMMBC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class JOAPJIIIBNH<TData> : LMGNCILJNAP<NIAJDJDFGPM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly MBNIFAFKBCJ<TData> FCGGNCFIGCA;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x50C8580", Offset = "0x50C6F80", VA = "0x1850C8580")]
	public JOAPJIIIBNH(List<TData> PCNLBIOPFBD, bool HFADHEKADMA, NIAJDJDFGPM<TData> BGDEMBOCEKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x50C84C0", Offset = "0x50C6EC0", VA = "0x1850C84C0", Slot = "4")]
	public override bool FGCPOFKMMBC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class ELGAOEPMAKK<TData> : LMGNCILJNAP<NIAJDJDFGPM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly TData HAGEAKNDEBH;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x46B2720", Offset = "0x46B1120", VA = "0x1846B2720")]
	public ELGAOEPMAKK(TData HAGEAKNDEBH, NIAJDJDFGPM<TData> BGDEMBOCEKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x46B25B0", Offset = "0x46B0FB0", VA = "0x1846B25B0", Slot = "4")]
	public override bool FGCPOFKMMBC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class ICECKIKICHA<TData> : LMGNCILJNAP<NIAJDJDFGPM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly MBNIFAFKBCJ<TData> FCGGNCFIGCA;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x4DD09D0", Offset = "0x4DCF3D0", VA = "0x184DD09D0")]
	public ICECKIKICHA(IEnumerable<TData> PCNLBIOPFBD, NIAJDJDFGPM<TData> BGDEMBOCEKP, bool HFADHEKADMA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x4DD0910", Offset = "0x4DCF310", VA = "0x184DD0910", Slot = "4")]
	public override bool FGCPOFKMMBC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public struct MBNIFAFKBCJ<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public IEnumerable<TData> KEJOHEMLDEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public bool HFADHEKADMA;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x5472A60", Offset = "0x5471460", VA = "0x185472A60")]
	public MBNIFAFKBCJ(IEnumerable<TData> NJPPIPOGPOD, bool NAKBAMAAGPI = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public interface LCDOCJPNAOJ
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<PDJLCPICFNJ> FGCPOFKMMBC(NAJNAEBOLIO MENKBKCKEKJ);
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class DHDMGMAKCHK : COOEBEPEMJB<LCDOCJPNAOJ, PDJLCPICFNJ>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private struct JCCPNPGDADP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public AsyncTaskMethodBuilder<PDJLCPICFNJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public DHDMGMAKCHK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private TaskAwaiter<PDJLCPICFNJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x7DA5C40", Offset = "0x7DA4640", VA = "0x187DA5C40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7DA5EB0", Offset = "0x7DA48B0", VA = "0x187DA5EB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private readonly NAJNAEBOLIO GMGDANMIMPK;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x7DA5440", Offset = "0x7DA3E40", VA = "0x187DA5440")]
	public DHDMGMAKCHK(bool HFADHEKADMA, LCDOCJPNAOJ BGDEMBOCEKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x7DA5350", Offset = "0x7DA3D50", VA = "0x187DA5350", Slot = "4")]
	[AsyncStateMachine(typeof(JCCPNPGDADP))]
	public override Task<PDJLCPICFNJ> FGCPOFKMMBC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public struct NAJNAEBOLIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public bool LJFFFABIEBJ;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x2B1F0F0", Offset = "0x2B1DAF0", VA = "0x182B1F0F0")]
	public NAJNAEBOLIO(bool HFADHEKADMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public readonly struct FJOFHMLAFHE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public readonly bool GPBOJINDDFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public readonly bool OFAKMJHPGDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public readonly bool JAHHKOMJJAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public readonly bool HFADHEKADMA;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5DC0310", Offset = "0x5DBED10", VA = "0x185DC0310")]
	public FJOFHMLAFHE(bool GPBOJINDDFH, bool OFAKMJHPGDD, bool JAHHKOMJJAE, bool HFADHEKADMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7DA5750", Offset = "0x7DA4150", VA = "0x187DA5750")]
	public FJOFHMLAFHE(bool OFAKMJHPGDD, bool HFADHEKADMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public interface MMKHKLAIALC
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FNEIMHADCDJ(FJOFHMLAFHE IOIMFNAGDNM);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DFMCGACMCAK(FJOFHMLAFHE IOIMFNAGDNM);
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public class JOABDDLHKKC : LMGNCILJNAP<MMKHKLAIALC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly FJOFHMLAFHE IOIMFNAGDNM;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7DA5F70", Offset = "0x7DA4970", VA = "0x187DA5F70")]
	public JOABDDLHKKC(bool MNINMACDPEC, bool OFAKMJHPGDD, bool JAHHKOMJJAE, bool HFADHEKADMA, MMKHKLAIALC BGDEMBOCEKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x7DA5F20", Offset = "0x7DA4920", VA = "0x187DA5F20", Slot = "4")]
	public override bool FGCPOFKMMBC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public class IGLBLEOALHK : LMGNCILJNAP<MMKHKLAIALC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly FJOFHMLAFHE IOIMFNAGDNM;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7DA5810", Offset = "0x7DA4210", VA = "0x187DA5810")]
	public IGLBLEOALHK(bool OFAKMJHPGDD, bool HFADHEKADMA, MMKHKLAIALC BGDEMBOCEKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x7DA57C0", Offset = "0x7DA41C0", VA = "0x187DA57C0", Slot = "4")]
	public override bool FGCPOFKMMBC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public interface HGKEGLFHHOF
{
	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FGCPOFKMMBC([In] AKIEHLGODHI EJBJCPOENDL);
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class FBCKPLFHKDL : LMGNCILJNAP<HGKEGLFHHOF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly AKIEHLGODHI EJBJCPOENDL;

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x7DA5550", Offset = "0x7DA3F50", VA = "0x187DA5550")]
	public FBCKPLFHKDL(Guid[] GADJEIDHAAI, Vector3[] PCOLCMNHBBA, Quaternion[] LPEPAHFKEEC, float[] JAIIEPFCIMA, Dictionary<Guid, Vector3> JCFDIFIKJKO, HGKEGLFHHOF BGDEMBOCEKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7DA54A0", Offset = "0x7DA3EA0", VA = "0x187DA54A0", Slot = "4")]
	public override bool FGCPOFKMMBC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public interface BGBNOHEIDPK<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EKJNGJPDMHO([In] JLMOKAMBNOH<TData> CFLGPJBECIK);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IPOMOADNADA([In] FBHJFODAHAG NBLNEPKODKL);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IPOMOADNADA([In] PAEEOEBKGLO NBLNEPKODKL);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool LEOPFJCGJBA();
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class LIPODOFJJMG<TData> : LMGNCILJNAP<BGBNOHEIDPK<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x468DDF0", Offset = "0x468C7F0", VA = "0x18468DDF0")]
	public LIPODOFJJMG(BGBNOHEIDPK<TData> BGDEMBOCEKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x528F920", Offset = "0x528E320", VA = "0x18528F920", Slot = "4")]
	public override bool FGCPOFKMMBC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class AHJDBIIGJCC<TData> : LMGNCILJNAP<BGBNOHEIDPK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly FBHJFODAHAG FAPDGHPJCEA;

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x4D939F0", Offset = "0x4D923F0", VA = "0x184D939F0")]
	public AHJDBIIGJCC(Vector3 GJMOKLFMMMH, bool PMJMCICMEAD, BGBNOHEIDPK<TData> BGDEMBOCEKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x46B9450", Offset = "0x46B7E50", VA = "0x1846B9450", Slot = "4")]
	public override bool FGCPOFKMMBC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public class LOCCGPJJHIN<TData> : LMGNCILJNAP<BGBNOHEIDPK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly PAEEOEBKGLO FAPDGHPJCEA;

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x52A0560", Offset = "0x529EF60", VA = "0x1852A0560")]
	public LOCCGPJJHIN(Guid KDDKFJELONK, int MNFHMLCLFEB, Vector3 JFMEMBGKAOB, Quaternion NGPACIMGGNA, float BGJJMJPDNJC, bool PMJMCICMEAD, BGBNOHEIDPK<TData> BGDEMBOCEKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x52A0500", Offset = "0x529EF00", VA = "0x1852A0500", Slot = "4")]
	public override bool FGCPOFKMMBC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class OAKCCONOJPM<TData> : LMGNCILJNAP<BGBNOHEIDPK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly JLMOKAMBNOH<TData> FAPDGHPJCEA;

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5651230", Offset = "0x564FC30", VA = "0x185651230")]
	public OAKCCONOJPM(TData DKLAGICAOGN, bool HFADHEKADMA, BGBNOHEIDPK<TData> BGDEMBOCEKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x4697330", Offset = "0x4695D30", VA = "0x184697330", Slot = "4")]
	public override bool FGCPOFKMMBC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct FBHJFODAHAG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public readonly Vector3 GJMOKLFMMMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public readonly bool PMJMCICMEAD;

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7DA5730", Offset = "0x7DA4130", VA = "0x187DA5730")]
	public FBHJFODAHAG(Vector3 GJMOKLFMMMH, bool PMJMCICMEAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct PAEEOEBKGLO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public readonly Guid KDDKFJELONK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public readonly int MNFHMLCLFEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public readonly Vector3 JFMEMBGKAOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public readonly Quaternion NGPACIMGGNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public readonly float BGJJMJPDNJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public readonly bool PMJMCICMEAD;

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7DA6A40", Offset = "0x7DA5440", VA = "0x187DA6A40")]
	public PAEEOEBKGLO(Guid KDDKFJELONK, int MNFHMLCLFEB, Vector3 JFMEMBGKAOB, Quaternion NGPACIMGGNA, float BGJJMJPDNJC, bool PMJMCICMEAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public struct JLMOKAMBNOH<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly TData DKLAGICAOGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public readonly bool HFADHEKADMA;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x50AAF20", Offset = "0x50A9920", VA = "0x1850AAF20")]
	public JLMOKAMBNOH(TData DKLAGICAOGN, bool HFADHEKADMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public interface AIAHEBNKDMO<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FGCPOFKMMBC([In] HCCGDECCFII<TData> BEFCAELDHEB);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FGCPOFKMMBC([In] GOONFMHMJLE<TData> BEFCAELDHEB);
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public interface HAKNIKHOAOG<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EKJNGJPDMHO([In] MDKGDDDGPAN<TData> KMHHPMAPODF);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IPOMOADNADA([In] BDLJDAIEMNN NBLNEPKODKL);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LEOPFJCGJBA();
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class EFPFMJNGJNH<TData> : LMGNCILJNAP<AIAHEBNKDMO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly HCCGDECCFII<TData> BEFCAELDHEB;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x46973E0", Offset = "0x4695DE0", VA = "0x1846973E0")]
	public EFPFMJNGJNH(IEnumerable<TData> MPNLMIPKIOI, Vector3 PODLAJALEHB, bool HFADHEKADMA, AIAHEBNKDMO<TData> BGDEMBOCEKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x4697330", Offset = "0x4695D30", VA = "0x184697330", Slot = "4")]
	public override bool FGCPOFKMMBC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public class OAELEIACBAC<TData> : LMGNCILJNAP<HAKNIKHOAOG<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x468DDF0", Offset = "0x468C7F0", VA = "0x18468DDF0")]
	public OAELEIACBAC(HAKNIKHOAOG<TData> BGDEMBOCEKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x4CF3770", Offset = "0x4CF2170", VA = "0x184CF3770", Slot = "4")]
	public override bool FGCPOFKMMBC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public class NHLLHJNPNOO<TData> : LMGNCILJNAP<HAKNIKHOAOG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly MDKGDDDGPAN<TData> BEFCAELDHEB;

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5504930", Offset = "0x5503330", VA = "0x185504930")]
	public NHLLHJNPNOO(IEnumerable<TData> MPNLMIPKIOI, bool HFADHEKADMA, HAKNIKHOAOG<TData> BGDEMBOCEKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x4697330", Offset = "0x4695D30", VA = "0x184697330", Slot = "4")]
	public override bool FGCPOFKMMBC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class MOLKAFMFOBL<TData> : LMGNCILJNAP<AIAHEBNKDMO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly GOONFMHMJLE<TData> BEFCAELDHEB;

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x54ABF10", Offset = "0x54AA910", VA = "0x1854ABF10")]
	public MOLKAFMFOBL(IEnumerable<TData> MPNLMIPKIOI, Vector3 OLOCPAALKHA, AIFLICKCNPM NGKBINOGCKC, bool HFADHEKADMA, AIAHEBNKDMO<TData> BGDEMBOCEKP, Space DMLKNPAHBGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x54ABE50", Offset = "0x54AA850", VA = "0x1854ABE50", Slot = "4")]
	public override bool FGCPOFKMMBC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class DFDNCCINHCC<TData> : LMGNCILJNAP<HAKNIKHOAOG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly BDLJDAIEMNN BEFCAELDHEB;

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6AEC710", Offset = "0x6AEB110", VA = "0x186AEC710")]
	public DFDNCCINHCC(Vector3 PODLAJALEHB, HAKNIKHOAOG<TData> BGDEMBOCEKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x46B9450", Offset = "0x46B7E50", VA = "0x1846B9450", Slot = "4")]
	public override bool FGCPOFKMMBC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct HCCGDECCFII<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public readonly IEnumerable<TData> MPNLMIPKIOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public readonly Vector3 PODLAJALEHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public readonly bool HFADHEKADMA;

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x4CD73E0", Offset = "0x4CD5DE0", VA = "0x184CD73E0")]
	public HCCGDECCFII(IEnumerable<TData> MPNLMIPKIOI, Vector3 PODLAJALEHB, bool HFADHEKADMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public struct MDKGDDDGPAN<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public readonly IEnumerable<TData> MPNLMIPKIOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public readonly bool HFADHEKADMA;

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x5477F30", Offset = "0x5476930", VA = "0x185477F30")]
	public MDKGDDDGPAN(IEnumerable<TData> MPNLMIPKIOI, bool HFADHEKADMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public struct GOONFMHMJLE<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public readonly IEnumerable<TData> MPNLMIPKIOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public readonly Vector3 OLOCPAALKHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public readonly AIFLICKCNPM NGKBINOGCKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public readonly bool HFADHEKADMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public readonly Space DMLKNPAHBGE;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x4C8BFF0", Offset = "0x4C8A9F0", VA = "0x184C8BFF0")]
	public GOONFMHMJLE(IEnumerable<TData> MPNLMIPKIOI, Vector3 OLOCPAALKHA, AIFLICKCNPM NGKBINOGCKC, bool HFADHEKADMA, Space DMLKNPAHBGE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public struct BDLJDAIEMNN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public readonly Vector3 PODLAJALEHB;

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x2B1F550", Offset = "0x2B1DF50", VA = "0x182B1F550")]
	public BDLJDAIEMNN(Vector3 PODLAJALEHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public enum AIFLICKCNPM
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
public interface MGCEIEEPFAE
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FGCPOFKMMBC([In] KFDPFMJIBCO KCKEHOMGNJP);
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public class KAKMGDMEDAJ : LMGNCILJNAP<MGCEIEEPFAE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private readonly KFDPFMJIBCO KCKEHOMGNJP;

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x7DA60B0", Offset = "0x7DA4AB0", VA = "0x187DA60B0")]
	public KAKMGDMEDAJ(bool HFADHEKADMA, MGCEIEEPFAE BGDEMBOCEKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x7DA6000", Offset = "0x7DA4A00", VA = "0x187DA6000", Slot = "4")]
	public override bool FGCPOFKMMBC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public readonly struct KFDPFMJIBCO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public readonly bool HFADHEKADMA;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x2B1F0F0", Offset = "0x2B1DAF0", VA = "0x182B1F0F0")]
	public KFDPFMJIBCO(bool HFADHEKADMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public interface MKGJANPEJAP<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FGCPOFKMMBC([In] CHJBMOGOFHM<TData> OGOEHDPAECF);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FGCPOFKMMBC([In] ECGPODAIAMM<TData> OGOEHDPAECF);
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public interface DBHBPKDDIHO<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EKJNGJPDMHO([In] OEGNBNFJIBJ<TData> CFLGPJBECIK);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IPOMOADNADA([In] OHIJHJHHEJC NBLNEPKODKL);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LEOPFJCGJBA();
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class PNEPLMHMEGE<TData> : LMGNCILJNAP<MKGJANPEJAP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private readonly CHJBMOGOFHM<TData> OGOEHDPAECF;

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x578F6C0", Offset = "0x578E0C0", VA = "0x18578F6C0")]
	public PNEPLMHMEGE(IEnumerable<TData> MPNLMIPKIOI, Quaternion PODLAJALEHB, Vector3? MDKCFNLIGKH, bool JAKNCHHGNEF, bool HFADHEKADMA, MKGJANPEJAP<TData> BGDEMBOCEKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x4697330", Offset = "0x4695D30", VA = "0x184697330", Slot = "4")]
	public override bool FGCPOFKMMBC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class HHEIFIALGCB<TData> : LMGNCILJNAP<DBHBPKDDIHO<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x468DDF0", Offset = "0x468C7F0", VA = "0x18468DDF0")]
	public HHEIFIALGCB(DBHBPKDDIHO<TData> BGDEMBOCEKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x4CF3770", Offset = "0x4CF2170", VA = "0x184CF3770", Slot = "4")]
	public override bool FGCPOFKMMBC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class GEEADCNJHAJ<TData> : LMGNCILJNAP<DBHBPKDDIHO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private readonly OEGNBNFJIBJ<TData> OGOEHDPAECF;

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x4C33CC0", Offset = "0x4C326C0", VA = "0x184C33CC0")]
	public GEEADCNJHAJ(IEnumerable<TData> MPNLMIPKIOI, bool HFADHEKADMA, DBHBPKDDIHO<TData> BGDEMBOCEKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x4697330", Offset = "0x4695D30", VA = "0x184697330", Slot = "4")]
	public override bool FGCPOFKMMBC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public class PBIEAHJHLFO<TData> : LMGNCILJNAP<MKGJANPEJAP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly ECGPODAIAMM<TData> OGOEHDPAECF;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x5754AD0", Offset = "0x57534D0", VA = "0x185754AD0")]
	public PBIEAHJHLFO(IEnumerable<TData> MPNLMIPKIOI, Quaternion OIPPCFFGNKJ, AIFLICKCNPM GJIBAOGPBFB, Vector3? MDKCFNLIGKH, bool JAKNCHHGNEF, bool HFADHEKADMA, Space DMLKNPAHBGE, MKGJANPEJAP<TData> BGDEMBOCEKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x54ABE50", Offset = "0x54AA850", VA = "0x1854ABE50", Slot = "4")]
	public override bool FGCPOFKMMBC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public class GDGMOJPGNIE<TData> : LMGNCILJNAP<DBHBPKDDIHO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly OHIJHJHHEJC OGOEHDPAECF;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x4C32B70", Offset = "0x4C31570", VA = "0x184C32B70")]
	public GDGMOJPGNIE(Quaternion PODLAJALEHB, Vector3? MDKCFNLIGKH, bool JAKNCHHGNEF, DBHBPKDDIHO<TData> BGDEMBOCEKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x46B9450", Offset = "0x46B7E50", VA = "0x1846B9450", Slot = "4")]
	public override bool FGCPOFKMMBC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct CHJBMOGOFHM<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public readonly IEnumerable<TData> MPNLMIPKIOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public readonly Quaternion PODLAJALEHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public readonly Vector3? MDKCFNLIGKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public readonly bool JAKNCHHGNEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public readonly bool HFADHEKADMA;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x6587E40", Offset = "0x6586840", VA = "0x186587E40")]
	public CHJBMOGOFHM(IEnumerable<TData> MPNLMIPKIOI, Quaternion PODLAJALEHB, Vector3? MDKCFNLIGKH, bool JAKNCHHGNEF, bool HFADHEKADMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public struct OEGNBNFJIBJ<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public readonly IEnumerable<TData> MPNLMIPKIOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly bool HFADHEKADMA;

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x565ABD0", Offset = "0x56595D0", VA = "0x18565ABD0")]
	public OEGNBNFJIBJ(IEnumerable<TData> MPNLMIPKIOI, bool HFADHEKADMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct ECGPODAIAMM<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public readonly IEnumerable<TData> MPNLMIPKIOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly Quaternion OIPPCFFGNKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public readonly AIFLICKCNPM GJIBAOGPBFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public readonly Vector3? MDKCFNLIGKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public readonly bool JAKNCHHGNEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public readonly bool HFADHEKADMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public readonly Space DMLKNPAHBGE;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x46894D0", Offset = "0x4687ED0", VA = "0x1846894D0")]
	public ECGPODAIAMM(IEnumerable<TData> MPNLMIPKIOI, Quaternion OIPPCFFGNKJ, AIFLICKCNPM GJIBAOGPBFB, Vector3? MDKCFNLIGKH, bool JAKNCHHGNEF, bool HFADHEKADMA, Space DMLKNPAHBGE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public struct OHIJHJHHEJC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public readonly Quaternion PODLAJALEHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public readonly Vector3? MDKCFNLIGKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public readonly bool JAKNCHHGNEF;

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x5D67DD0", Offset = "0x5D667D0", VA = "0x185D67DD0")]
	public OHIJHJHHEJC(Quaternion PODLAJALEHB, Vector3? MDKCFNLIGKH, bool JAKNCHHGNEF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public interface JBDGFAKGEPG<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EKJNGJPDMHO([In] JJKJIGJGKNH<TData> CFLGPJBECIK);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IPOMOADNADA([In] LDKILANGBFM NBLNEPKODKL);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IPOMOADNADA([In] GAAOCEDLLIL NBLNEPKODKL);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IPOMOADNADA([In] NLAFFDCOMJB NBLNEPKODKL);

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool LEOPFJCGJBA();
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public class JNMHBLMODFB<TData> : LMGNCILJNAP<JBDGFAKGEPG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private readonly NLAFFDCOMJB DPNEHMMFFNM;

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x50C7840", Offset = "0x50C6240", VA = "0x1850C7840")]
	public JNMHBLMODFB(Vector3 NPHOKMJHNFI, float EMHHPNBMOLH, Vector3 MDKCFNLIGKH, bool JMNBLHFCHAB, bool NNPJDBBGCAJ, JBDGFAKGEPG<TData> BGDEMBOCEKP, Space DMLKNPAHBGE = Space.Self)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x50C77E0", Offset = "0x50C61E0", VA = "0x1850C77E0", Slot = "4")]
	public override bool FGCPOFKMMBC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public class CFAFJIEEKDG<TData> : LMGNCILJNAP<JBDGFAKGEPG<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x468DDF0", Offset = "0x468C7F0", VA = "0x18468DDF0")]
	public CFAFJIEEKDG(JBDGFAKGEPG<TData> BGDEMBOCEKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x64BEC00", Offset = "0x64BD600", VA = "0x1864BEC00", Slot = "4")]
	public override bool FGCPOFKMMBC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public class LEELHNAFIPO<TData> : LMGNCILJNAP<JBDGFAKGEPG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private readonly JJKJIGJGKNH<TData> DPNEHMMFFNM;

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x527ECE0", Offset = "0x527D6E0", VA = "0x18527ECE0")]
	public LEELHNAFIPO(IEnumerable<TData> MPNLMIPKIOI, bool HFADHEKADMA, JBDGFAKGEPG<TData> BGDEMBOCEKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x4697330", Offset = "0x4695D30", VA = "0x184697330", Slot = "4")]
	public override bool FGCPOFKMMBC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public class MCKADLDGFHB<TData> : LMGNCILJNAP<JBDGFAKGEPG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private readonly GAAOCEDLLIL DPNEHMMFFNM;

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x5473760", Offset = "0x5472160", VA = "0x185473760")]
	public MCKADLDGFHB(float PCGMJACFCHK, bool JFKKNHELKIL, Vector3 MDKCFNLIGKH, JBDGFAKGEPG<TData> BGDEMBOCEKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x54736A0", Offset = "0x54720A0", VA = "0x1854736A0", Slot = "4")]
	public override bool FGCPOFKMMBC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public class ENBKOBFEHEG<TData> : LMGNCILJNAP<JBDGFAKGEPG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly LDKILANGBFM DPNEHMMFFNM;

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x46B94B0", Offset = "0x46B7EB0", VA = "0x1846B94B0")]
	public ENBKOBFEHEG(float EMHHPNBMOLH, Vector3 MDKCFNLIGKH, JBDGFAKGEPG<TData> BGDEMBOCEKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x46B9450", Offset = "0x46B7E50", VA = "0x1846B9450", Slot = "4")]
	public override bool FGCPOFKMMBC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public struct NLAFFDCOMJB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public readonly Vector3 NPHOKMJHNFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public readonly float EMHHPNBMOLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public readonly Vector3 MDKCFNLIGKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public readonly bool PMJMCICMEAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public readonly Space DMLKNPAHBGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public readonly bool NNPJDBBGCAJ;

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x7DA6650", Offset = "0x7DA5050", VA = "0x187DA6650")]
	public NLAFFDCOMJB(Vector3 NPHOKMJHNFI, float EMHHPNBMOLH, Vector3 MDKCFNLIGKH, bool PMJMCICMEAD, bool OJFGPLHMMOO, Space DMLKNPAHBGE = Space.Self)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public struct JJKJIGJGKNH<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public readonly IEnumerable<TData> MPNLMIPKIOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public readonly bool HFADHEKADMA;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x509FB90", Offset = "0x509E590", VA = "0x18509FB90")]
	public JJKJIGJGKNH(IEnumerable<TData> MPNLMIPKIOI, bool HFADHEKADMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public struct GAAOCEDLLIL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public readonly float PCGMJACFCHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public readonly bool JFKKNHELKIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public readonly Vector3 MDKCFNLIGKH;

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x7DA5760", Offset = "0x7DA4160", VA = "0x187DA5760")]
	public GAAOCEDLLIL(float PCGMJACFCHK, bool JFKKNHELKIL, Vector3 MDKCFNLIGKH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public struct LDKILANGBFM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public readonly float EMHHPNBMOLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public readonly Vector3 MDKCFNLIGKH;

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x5D211D0", Offset = "0x5D1FBD0", VA = "0x185D211D0")]
	public LDKILANGBFM(float EMHHPNBMOLH, Vector3 MDKCFNLIGKH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public struct AKIEHLGODHI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public readonly Guid[] MPNLMIPKIOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public readonly bool JBOELHHJFLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public readonly bool BLBFEHHEIEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public readonly bool HFPMJINEOHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public readonly Vector3[] PCOLCMNHBBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public readonly Quaternion[] LPEPAHFKEEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public readonly float[] JAIIEPFCIMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public readonly Dictionary<Guid, Vector3> JCFDIFIKJKO;

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x7DA4E00", Offset = "0x7DA3800", VA = "0x187DA4E00")]
	public AKIEHLGODHI(Guid[] GADJEIDHAAI, Vector3[] PCOLCMNHBBA, Quaternion[] LPEPAHFKEEC, float[] JAIIEPFCIMA, Dictionary<Guid, Vector3> JCFDIFIKJKO, bool JBOELHHJFLP = true, bool BLBFEHHEIEP = true, bool HFPMJINEOHM = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7DA4C30", Offset = "0x7DA3630", VA = "0x187DA4C30")]
	private static void EKKEOEPNIBK(Dictionary<Guid, Vector3> JCFDIFIKJKO, int BICIBICPBEH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public static class ILHIAMFDDGL
{
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	private struct NKNNJGNBJCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public bool NFNPCLEFPFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public MHGNCMHMEKD JDALHNAFDDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public MHGNCMHMEKD KODGFFAAIAD;
	}

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private static NKNNJGNBJCO ONGCIGBMPOI;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static CancellationToken MPLMKKLDHKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x7DA5A40", Offset = "0x7DA4440", VA = "0x187DA5A40")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	internal static MHGNCMHMEKD JDALHNAFDDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x7DA5AB0", Offset = "0x7DA44B0", VA = "0x187DA5AB0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x7DA5890", Offset = "0x7DA4290", VA = "0x187DA5890")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x7DA5B50", Offset = "0x7DA4550", VA = "0x187DA5B50")]
	[CGLGNCLDKHN.DPDEAPAPLBM]
	internal static void OFNGDBPMMLB(MHGNCMHMEKD LCPPCGBCCPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x7DA58F0", Offset = "0x7DA42F0", VA = "0x187DA58F0")]
	public static void ALHGHPCNMCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x7DA5A60", Offset = "0x7DA4460", VA = "0x187DA5A60")]
	private static MHGNCMHMEKD JIFCFFCPNLC(MHGNCMHMEKD HOCODGIAFOF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public static class GPNFPDPDKBP
{
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	public enum NBHFDMOJPOB
	{
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		ICreationContextObject,
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		Guid
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x3A79500", Offset = "0x3A77F00", VA = "0x183A79500")]
	public static void HCDBOCHEEGC<T>(T NMGHOHCNINO, NBHFDMOJPOB HHCAOFMCNLG) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3A79640", Offset = "0x3A78040", VA = "0x183A79640")]
	public static void HCDBOCHEEGC<T>(T NMGHOHCNINO) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x3A79420", Offset = "0x3A77E20", VA = "0x183A79420")]
	public static void HCDBOCHEEGC<T, TImpl, T>() where T : class where TImpl : notnull, T where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x3A793B0", Offset = "0x3A77DB0", VA = "0x183A793B0")]
	public static void FEHELHAJGBP<T>(T NMGHOHCNINO) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x3A796A0", Offset = "0x3A780A0", VA = "0x183A796A0")]
	public static T IBPMNADNGOO<T>(NBHFDMOJPOB HHCAOFMCNLG) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x3A79280", Offset = "0x3A77C80", VA = "0x183A79280")]
	public static bool EFEDHOLKNME<T>(NBHFDMOJPOB HHCAOFMCNLG, T? AMMAHNHFGHA, [Out][NotNullWhen(true)][MaybeNullWhen(false)] T GCDIANKPLCE) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x3A79740", Offset = "0x3A78140", VA = "0x183A79740")]
	public static bool PMDKJKFKCBB<T>(NBHFDMOJPOB HHCAOFMCNLG, [Out][NotNullWhen(true)][MaybeNullWhen(false)] T NCMPKIPKHOL) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x3A79140", Offset = "0x3A77B40", VA = "0x183A79140")]
	public static bool CEDIBDPPDJA<T>(NBHFDMOJPOB HHCAOFMCNLG) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x3A79100", Offset = "0x3A77B00", VA = "0x183A79100")]
	public static T IBPMNADNGOO<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x3A791E0", Offset = "0x3A77BE0", VA = "0x183A791E0")]
	public static bool EFEDHOLKNME<T>(T AMMAHNHFGHA, [Out] T GCDIANKPLCE) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x3A79100", Offset = "0x3A77B00", VA = "0x183A79100")]
	public static bool CEDIBDPPDJA<T>() where T : class
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
internal static class LNIHAGFLJDB
{
	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x7DA6420", Offset = "0x7DA4E20", VA = "0x187DA6420")]
	public static void EDICEBCNOFP(IEnumerable IHDCLDJGNHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x3B23540", Offset = "0x3B21F40", VA = "0x183B23540")]
	public static void EDICEBCNOFP<T>(T[] KLDOGKPLNJA) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x3B23720", Offset = "0x3B22120", VA = "0x183B23720")]
	public static void EDICEBCNOFP<T>(T MIMNBICPMMO) where T : notnull, Enum
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
