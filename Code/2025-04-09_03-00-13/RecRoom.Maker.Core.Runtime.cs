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
		[Cpp2IlInjected.Address(RVA = "0x9D4820", Offset = "0x9D3C20", VA = "0x1809D4820")]
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
		[Cpp2IlInjected.Address(RVA = "0x792CCE0", Offset = "0x792C0E0", VA = "0x18792CCE0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9D5490", Offset = "0x9D4890", VA = "0x1809D5490")]
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
		[Cpp2IlInjected.Address(RVA = "0x9D54D0", Offset = "0x9D48D0", VA = "0x1809D54D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x792D2E0", Offset = "0x792C6E0", VA = "0x18792D2E0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2553680", Offset = "0x2552A80", VA = "0x182553680")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface FAKBODHJBMP<TData, TReturn>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TReturn NEANEINCJOD(TData BLFGIKOAKOL);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface MEBBJFBBDEI<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ClearHoverTarget(DJCDBLMPNIE PJMCPKCEMAE);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool SetHoverTarget(TData IGICHEAKAKH, Collider LLHKIOPLDMB, DJCDBLMPNIE PJMCPKCEMAE, [Optional] NIBPFMHDCCB? GCEKFPGNJLL);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool TryGetHoverTarget([Out] TData IGICHEAKAKH);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetHoverCollider([Out] Collider LLHKIOPLDMB);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface DDIMHAMHDML<TData> : DNAEFDDLBFC, BGHGCMCFAGC<TData>, FHILBNMJLGJ<TData>, LMOOLAHNPDK<TData>, EKDJOBLBGMC, MGJINPBPIMH<TData>, AEICGMOADPE, DHPIEDIFOLN
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface MGJINPBPIMH<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 NEGIIJCCHAL, Vector3 GOMJGIJPEPD, float KGELMMBOFHJ, [Out] T MNNBHCALAIG, [Out] Vector3 CIAKNDFGKBD, [Out] Collider LLHKIOPLDMB);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 NEGIIJCCHAL, Vector3 GOMJGIJPEPD, float HKAEOOANMJJ, float KGELMMBOFHJ, T[] OGMIAGGBOPP, [Out] Vector3 EBFOHJHNGGJ, [Out] Collider HLMKPJJEJPL);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 NEGIIJCCHAL, float HKAEOOANMJJ, Vector3 COPADOMAPEL, T[] OGMIAGGBOPP);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetObjectFromColliderInCurrentScope(Collider COGBCPCJGAA, [Out] T HPJFMCKKFMK);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface DNAEFDDLBFC
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Bounds FECOGDEGBGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Transform NEMOPLMGAGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Bounds EGLPODDALFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Transform BCLHCIJDKBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Vector3 BNHIGPCNIGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool KPOOLCLJKKK
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
	void SetSelectionBoundsDirty(bool CLNFNFOMNHK = true, int JDKIHHOHDDD = 0);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ShouldHideSelectionBoundsPreview(bool KDLOAMNAMOH, object HHGPJKKLNIG);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface DHPIEDIFOLN
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	OPNNLJDPBAB FOKJAJMDDIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface NHHCCOEMJBD
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool LABMGDALJMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool IFFOIKHAOPH
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool BBJPOIAGMEB
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
	void TrySetPreviousCloneMapping(Dictionary<Guid, Guid> NPGOAKFIFBB);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface LMOOLAHNPDK<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool APNIEKGLLFE
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int EPDLABFBKGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<TData> OFEHLGGLFFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData MGCEJOCCONP);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData MGCEJOCCONP);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface BGHGCMCFAGC<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T BLFGIKOAKOL, [Optional] NIBPFMHDCCB? DOPPEDALNIC, bool INDPJIDFGMK = true);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int ECKHNAPCKGD, IEnumerable<T> IEOJDMIKIIG, bool INDPJIDFGMK = true);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int ECKHNAPCKGD, IEnumerable<T> IEOJDMIKIIG, NIBPFMHDCCB DOPPEDALNIC, bool INDPJIDFGMK = true);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface AEICGMOADPE
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface EKDJOBLBGMC
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool ILCOLJHOIOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool IFKCEDMCANP
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool BGHMFIBLAEA
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool PKMCAIJBCLD
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct MDPNNCLFKDK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public bool FPBHMPNHKLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public float? PFJHEOPFGIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public float? BDNHEEGIGHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public float? HACCOHLENFK;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct EMDEKLMJPEM<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public IEnumerable<TData> DMBPEFCLKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public MDPNNCLFKDK PFKMLPENIHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public bool GPJBGKLGEDC;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x42E8270", Offset = "0x42E7670", VA = "0x1842E8270")]
	public EMDEKLMJPEM(IEnumerable<TData> KJACNMKOEKF, bool DMONPJPMCGM, float? DPNHOIMLBHB, float? KEDOGBHAGPB, float? AHBMKJGKFFI, bool GPJBGKLGEDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface KOAHFOANJDB<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ADOFNKOFPAL([In] EMDEKLMJPEM<TData> BPKDFLJLPAA);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class KHLPBGFHNAA<TData> : JGNDFEMADJE<KOAHFOANJDB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly EMDEKLMJPEM<TData> BPKDFLJLPAA;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4D90860", Offset = "0x4D8FC60", VA = "0x184D90860")]
	public KHLPBGFHNAA(IEnumerable<TData> KJACNMKOEKF, bool DMONPJPMCGM, float? DPNHOIMLBHB, float? KEDOGBHAGPB, float? AHBMKJGKFFI, bool GPJBGKLGEDC, KOAHFOANJDB<TData> IIOEMENEBDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x475A120", Offset = "0x4759520", VA = "0x18475A120", Slot = "4")]
	public override bool ADOFNKOFPAL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct NGLJEEFPKNB<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public IEnumerable<TData> DMBPEFCLKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public string OLBGIJNAOGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public bool LLMPIIDHLFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public bool GPJBGKLGEDC;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x50E9470", Offset = "0x50E8870", VA = "0x1850E9470")]
	public NGLJEEFPKNB(IEnumerable<TData> KJACNMKOEKF, string KIINNOIMCAK, bool KFJNNFNNFGI, bool GPJBGKLGEDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface HLPHMKLIHHA<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ADOFNKOFPAL([In] NGLJEEFPKNB<TData> BPKDFLJLPAA);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class NMLFEIOCHHH<TData> : JGNDFEMADJE<HLPHMKLIHHA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly NGLJEEFPKNB<TData> BPKDFLJLPAA;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x51057C0", Offset = "0x5104BC0", VA = "0x1851057C0")]
	public NMLFEIOCHHH(IEnumerable<TData> KJACNMKOEKF, string KIINNOIMCAK, bool KFJNNFNNFGI, bool GPJBGKLGEDC, HLPHMKLIHHA<TData> IIOEMENEBDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x475A120", Offset = "0x4759520", VA = "0x18475A120", Slot = "4")]
	public override bool ADOFNKOFPAL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public abstract class JGNDFEMADJE<TReceiver> : GEHABHNKPBB<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x42DD2E0", Offset = "0x42DC6E0", VA = "0x1842DD2E0")]
	public JGNDFEMADJE(TReceiver IIOEMENEBDK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public abstract class IFNOOIADOGG<TReceiver, TFromTask> : GEHABHNKPBB<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x42DD2E0", Offset = "0x42DC6E0", VA = "0x1842DD2E0")]
	public IFNOOIADOGG(TReceiver IIOEMENEBDK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public abstract class GEHABHNKPBB<TReceiver, TFromExecute> where TReceiver : notnull where TFromExecute : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	protected TReceiver IIOEMENEBDK;

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x484A980", Offset = "0x4849D80", VA = "0x18484A980")]
	public GEHABHNKPBB(TReceiver IIOEMENEBDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute ADOFNKOFPAL();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class BNLIEEEAFFJ<TReceiver, TResult> : GEHABHNKPBB<TReceiver, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x42DD2E0", Offset = "0x42DC6E0", VA = "0x1842DD2E0")]
	public BNLIEEEAFFJ(TReceiver IIOEMENEBDK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct CFJAKIHFDNM<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public TGroup HMJCNIFDPJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public TData GGLKLJFLHEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public IEnumerable<TData> DMBPEFCLKKF;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2564190", Offset = "0x2563590", VA = "0x182564190")]
	public CFJAKIHFDNM(TGroup IDIMMEOBHAH, TData DGFJFFAFOLN, IEnumerable<TData> KJACNMKOEKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct JDIEJNNJOLG<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public TGroup HMJCNIFDPJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public IEnumerable<TData> DMBPEFCLKKF;

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0xA3D2B0", Offset = "0xA3C6B0", VA = "0x180A3D2B0")]
	public JDIEJNNJOLG(TGroup IDIMMEOBHAH, IEnumerable<TData> KJACNMKOEKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct BBNEMGHDKNC<TGroup> where TGroup : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public TGroup HMJCNIFDPJD;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0xC747D0", Offset = "0xC73BD0", VA = "0x180C747D0")]
	public BBNEMGHDKNC(TGroup IDIMMEOBHAH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct GEFMNNLDMHI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public IEnumerable<Guid> DMBPEFCLKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public Guid JIBAKHFKIAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public readonly bool CELBKAMAFLP;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x792BA10", Offset = "0x792AE10", VA = "0x18792BA10")]
	public GEFMNNLDMHI(IEnumerable<Guid> KJACNMKOEKF, Guid CIMGPOKLJHF, bool GPJBGKLGEDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct ODDBLDPMECD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public Guid JIBAKHFKIAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly bool CELBKAMAFLP;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2444BE0", Offset = "0x2443FE0", VA = "0x182444BE0")]
	public ODDBLDPMECD(Guid CIMGPOKLJHF, bool GPJBGKLGEDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface AIJKDCFDOJJ<TGroup, TData>
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IODGJBJINJG NJHHFCDOPEI(CFJAKIHFDNM<TGroup, TData> EBEJIEOBFMG);

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IODGJBJINJG MIIEFPCJLIO(CFJAKIHFDNM<TGroup, TData> EBEJIEOBFMG);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IODGJBJINJG DCHBOBHDLPD(JDIEJNNJOLG<TGroup, TData> EBEJIEOBFMG);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IODGJBJINJG COEMACMOCAF(BBNEMGHDKNC<TGroup> EBEJIEOBFMG);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface KMPGLHCOPGA
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IODGJBJINJG> NJHHFCDOPEI(GEFMNNLDMHI EBEJIEOBFMG);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<IODGJBJINJG> MIIEFPCJLIO(ODDBLDPMECD EBEJIEOBFMG);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class DPDNIJNLMHH<TGroup, TData> : BNLIEEEAFFJ<AIJKDCFDOJJ<TGroup, TData>, IODGJBJINJG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly JDIEJNNJOLG<TGroup, TData> EBEJIEOBFMG;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x66FF930", Offset = "0x66FED30", VA = "0x1866FF930")]
	public DPDNIJNLMHH(TGroup IDIMMEOBHAH, IEnumerable<TData> KJACNMKOEKF, AIJKDCFDOJJ<TGroup, TData> IIOEMENEBDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x66FF870", Offset = "0x66FEC70", VA = "0x1866FF870", Slot = "4")]
	public override IODGJBJINJG ADOFNKOFPAL()
	{
		return default(IODGJBJINJG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class IPLDEBMJNDP<TGroup, TData> : BNLIEEEAFFJ<AIJKDCFDOJJ<TGroup, TData>, IODGJBJINJG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly CFJAKIHFDNM<TGroup, TData> EBEJIEOBFMG;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x4A32B10", Offset = "0x4A31F10", VA = "0x184A32B10")]
	public IPLDEBMJNDP(TGroup IDIMMEOBHAH, TData KLMFCBGFGOL, IEnumerable<TData> KJACNMKOEKF, AIJKDCFDOJJ<TGroup, TData> IIOEMENEBDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x4A32A40", Offset = "0x4A31E40", VA = "0x184A32A40", Slot = "4")]
	public override IODGJBJINJG ADOFNKOFPAL()
	{
		return default(IODGJBJINJG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class BKDIDGMEMAM<TGroup, TData> : BNLIEEEAFFJ<AIJKDCFDOJJ<TGroup, TData>, IODGJBJINJG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly BBNEMGHDKNC<TGroup> EBEJIEOBFMG;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5219B80", Offset = "0x5218F80", VA = "0x185219B80")]
	public BKDIDGMEMAM(TGroup IDIMMEOBHAH, AIJKDCFDOJJ<TGroup, TData> IIOEMENEBDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5F353C0", Offset = "0x5F347C0", VA = "0x185F353C0", Slot = "4")]
	public override IODGJBJINJG ADOFNKOFPAL()
	{
		return default(IODGJBJINJG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class NEHKILJBACN<TGroup, TData> : BNLIEEEAFFJ<AIJKDCFDOJJ<TGroup, TData>, IODGJBJINJG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly CFJAKIHFDNM<TGroup, TData> EBEJIEOBFMG;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4A32B10", Offset = "0x4A31F10", VA = "0x184A32B10")]
	public NEHKILJBACN(TGroup IDIMMEOBHAH, TData DGFJFFAFOLN, IEnumerable<TData> KJACNMKOEKF, AIJKDCFDOJJ<TGroup, TData> IIOEMENEBDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x50DDCC0", Offset = "0x50DD0C0", VA = "0x1850DDCC0", Slot = "4")]
	public override IODGJBJINJG ADOFNKOFPAL()
	{
		return default(IODGJBJINJG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class OCFBOIDJPBD : IFNOOIADOGG<KMPGLHCOPGA, IODGJBJINJG>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct KIKPCECGCFJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public AsyncTaskMethodBuilder<IODGJBJINJG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public OCFBOIDJPBD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private TaskAwaiter<IODGJBJINJG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x792C360", Offset = "0x792B760", VA = "0x18792C360", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x792C600", Offset = "0x792BA00", VA = "0x18792C600", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private GEFMNNLDMHI EBEJIEOBFMG;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x792CE70", Offset = "0x792C270", VA = "0x18792CE70")]
	public OCFBOIDJPBD(IEnumerable<Guid> FDCBMBDJBFJ, Guid CIMGPOKLJHF, bool GPJBGKLGEDC, KMPGLHCOPGA IIOEMENEBDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x792CD80", Offset = "0x792C180", VA = "0x18792CD80", Slot = "4")]
	[AsyncStateMachine(typeof(KIKPCECGCFJ))]
	public override Task<IODGJBJINJG> ADOFNKOFPAL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class CJHBHFPDNPE : IFNOOIADOGG<KMPGLHCOPGA, IODGJBJINJG>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private struct KDFDINNILML : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public AsyncTaskMethodBuilder<IODGJBJINJG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public CJHBHFPDNPE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private TaskAwaiter<IODGJBJINJG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x792C050", Offset = "0x792B450", VA = "0x18792C050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x792C2F0", Offset = "0x792B6F0", VA = "0x18792C2F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly ODDBLDPMECD EBEJIEOBFMG;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x792B410", Offset = "0x792A810", VA = "0x18792B410")]
	public CJHBHFPDNPE(Guid CIMGPOKLJHF, bool GPJBGKLGEDC, KMPGLHCOPGA IIOEMENEBDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x792B320", Offset = "0x792A720", VA = "0x18792B320", Slot = "4")]
	[AsyncStateMachine(typeof(KDFDINNILML))]
	public override Task<IODGJBJINJG> ADOFNKOFPAL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public readonly struct CEEBHJCLKCP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly ILIMMHMFDKD GGENMIOOJBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly bool CELBKAMAFLP;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x792B300", Offset = "0x792A700", VA = "0x18792B300")]
	public CEEBHJCLKCP(ILIMMHMFDKD HCJBNHGDAIO, bool GPJBGKLGEDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface BJAFAAJIGBE<TSpawnType> where TSpawnType : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> ADOFNKOFPAL(CEEBHJCLKCP PGIPFDEALJO);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class ABIPNEHKMGF<TSpawnType> : IFNOOIADOGG<BJAFAAJIGBE<TSpawnType>, TSpawnType> where TSpawnType : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct MHDKGCEFPKB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public AsyncTaskMethodBuilder<TSpawnType> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public ABIPNEHKMGF<TSpawnType> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private TaskAwaiter<TSpawnType> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x505EB40", Offset = "0x505DF40", VA = "0x18505EB40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x491ADA0", Offset = "0x491A1A0", VA = "0x18491ADA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly CEEBHJCLKCP PGIPFDEALJO;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x47FD800", Offset = "0x47FCC00", VA = "0x1847FD800")]
	public ABIPNEHKMGF(ILIMMHMFDKD HCJBNHGDAIO, bool GPJBGKLGEDC, BJAFAAJIGBE<TSpawnType> IIOEMENEBDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x47FD600", Offset = "0x47FCA00", VA = "0x1847FD600", Slot = "4")]
	[AsyncStateMachine(typeof(ABIPNEHKMGF<>.MHDKGCEFPKB))]
	public override Task<TSpawnType> ADOFNKOFPAL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct ILIMMHMFDKD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public readonly bool OEHNOKDHAAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly Vector3 AMADFFADGCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly Vector3 KLIFIKMFFNL;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x792BBD0", Offset = "0x792AFD0", VA = "0x18792BBD0")]
	public ILIMMHMFDKD(Transform KDKGFIDEIOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x792BCC0", Offset = "0x792B0C0", VA = "0x18792BCC0")]
	public ILIMMHMFDKD(Vector3 BELINKGJHGO, Vector3 INHMOEHIHAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x792BBA0", Offset = "0x792AFA0", VA = "0x18792BBA0")]
	public static ILIMMHMFDKD IPLKNPADEBH()
	{
		return default(ILIMMHMFDKD);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x792BC40", Offset = "0x792B040", VA = "0x18792BC40")]
	private ILIMMHMFDKD(bool AAAOFJKNLPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct DFHIHOKIONB<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public TNode BMAFFKKOHGL;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x66D71D0", Offset = "0x66D65D0", VA = "0x1866D71D0")]
	public DFHIHOKIONB(TNode BMAFFKKOHGL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct KENFJELKLAJ<TNode, TReparentOperations> where TNode : notnull where TReparentOperations : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public TNode DDFKFJHDDNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public TReparentOperations MHBDFEKPNNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public LHICOJKGJJJ LAKEFJBCNED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly bool CELBKAMAFLP;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x4D78960", Offset = "0x4D77D60", VA = "0x184D78960")]
	public KENFJELKLAJ(TNode DDFKFJHDDNC, TReparentOperations MHBDFEKPNNK, LHICOJKGJJJ LAKEFJBCNED, bool GPJBGKLGEDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface POAIOMKJMPL<TNode, TReparentOperations>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DIMEPCIPGBI([In] DFHIHOKIONB<TNode> DNAFHCNLLLC);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CJLJNDDFGIC([In] KENFJELKLAJ<TNode, TReparentOperations> HFFIOBMDPPD);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BPHHMLGFIKN();
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class MAFLEPOMEFH<TNode, TReparentOperations> : JGNDFEMADJE<POAIOMKJMPL<TNode, TReparentOperations>>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x42DD2E0", Offset = "0x42DC6E0", VA = "0x1842DD2E0")]
	public MAFLEPOMEFH(POAIOMKJMPL<TNode, TReparentOperations> IIOEMENEBDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x4A19AC0", Offset = "0x4A18EC0", VA = "0x184A19AC0", Slot = "4")]
	public override bool ADOFNKOFPAL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class FAGIHFFEEIB<TNode, TReparentOperations> : JGNDFEMADJE<POAIOMKJMPL<TNode, TReparentOperations>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly KENFJELKLAJ<TNode, TReparentOperations> HFFIOBMDPPD;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x47005D0", Offset = "0x46FF9D0", VA = "0x1847005D0")]
	public FAGIHFFEEIB(TNode DDFKFJHDDNC, TReparentOperations MHBDFEKPNNK, LHICOJKGJJJ LAKEFJBCNED, POAIOMKJMPL<TNode, TReparentOperations> IIOEMENEBDK, bool GPJBGKLGEDC = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x4700510", Offset = "0x46FF910", VA = "0x184700510", Slot = "4")]
	public override bool ADOFNKOFPAL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class NMICBKEBLJI<TNode, TReparentOperations> : JGNDFEMADJE<POAIOMKJMPL<TNode, TReparentOperations>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly DFHIHOKIONB<TNode> DNAFHCNLLLC;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5104710", Offset = "0x5103B10", VA = "0x185104710")]
	public NMICBKEBLJI(TNode DNELIIPNJMH, POAIOMKJMPL<TNode, TReparentOperations> IIOEMENEBDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x475A120", Offset = "0x4759520", VA = "0x18475A120", Slot = "4")]
	public override bool ADOFNKOFPAL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct LHDGPNCPMGO<TSpawnInfo> where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public TSpawnInfo BPIGHAADCKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public Vector3 INHMOEHIHAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public Quaternion AJFJKBHPFHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public float KJPCKOGHHCN;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x4E67BB0", Offset = "0x4E66FB0", VA = "0x184E67BB0")]
	public LHDGPNCPMGO(TSpawnInfo BPIGHAADCKH, Vector3 INHMOEHIHAJ, Quaternion AJFJKBHPFHG, float KJPCKOGHHCN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface KAKFHAOLLCK<TSpawnType, TSpawnInfo>
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> EDGGCBPJMBE([In] LHDGPNCPMGO<TSpawnInfo> MHEOGDKIJBL, CancellationToken LMNHDKIFBOH);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class IAEEEFFHIKH<TSpawnType, TSpawnInfo> : IFNOOIADOGG<KAKFHAOLLCK<TSpawnType, TSpawnInfo>, TSpawnType> where TSpawnType : notnull where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly LHDGPNCPMGO<TSpawnInfo> BPKDFLJLPAA;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x49E4F30", Offset = "0x49E4330", VA = "0x1849E4F30")]
	public IAEEEFFHIKH(TSpawnInfo EFEKPHIFKPM, Vector3 INHMOEHIHAJ, Quaternion AJFJKBHPFHG, float KJPCKOGHHCN, KAKFHAOLLCK<TSpawnType, TSpawnInfo> IIOEMENEBDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x430A1A0", Offset = "0x43095A0", VA = "0x18430A1A0", Slot = "4")]
	public override Task<TSpawnType> ADOFNKOFPAL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public readonly struct BHILBLONKBH<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly IEnumerable<TData> DMBPEFCLKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly bool CELBKAMAFLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly bool DJBDIOIIACP;

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5F22570", Offset = "0x5F21970", VA = "0x185F22570")]
	public BHILBLONKBH(IEnumerable<TData> KJACNMKOEKF, bool GPJBGKLGEDC = false, bool JBHBOEKNHJI = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface CNHBLAFMDCE<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IODGJBJINJG> NJGOBOPJGNF([In] BHILBLONKBH<TData> EJADPOCNOIM, CancellationToken LMNHDKIFBOH);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class EPAOOBMOCOG<TData> : IFNOOIADOGG<CNHBLAFMDCE<TData>, IODGJBJINJG> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly BHILBLONKBH<TData> NGABEGOBJJG;

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x430A280", Offset = "0x4309680", VA = "0x18430A280")]
	public EPAOOBMOCOG(IEnumerable<TData> KJACNMKOEKF, bool GPJBGKLGEDC, CNHBLAFMDCE<TData> IIOEMENEBDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x430A1A0", Offset = "0x43095A0", VA = "0x18430A1A0", Slot = "4")]
	public override Task<IODGJBJINJG> ADOFNKOFPAL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct JCLJKPGNIBN<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly T IGICHEAKAKH;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x4BF8B20", Offset = "0x4BF7F20", VA = "0x184BF8B20")]
	public JCLJKPGNIBN(T DNPOBEPEFIM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface APPKAFHOOBE<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DIMEPCIPGBI([In] JCLJKPGNIBN<T> INKABFNGOBD);

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CJLJNDDFGIC();
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface ELOMJLFFHKB<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ADOFNKOFPAL([In] DLKIBPGKFDI<T> PFHLMEEIPIO);
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public struct DLKIBPGKFDI<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly T IGICHEAKAKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly bool ODGOKLEGPHA;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x66FA4D0", Offset = "0x66F98D0", VA = "0x1866FA4D0")]
	public DLKIBPGKFDI(T DNPOBEPEFIM, bool PBGGELMPJKH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public class JCJKFMLFNDE<T> : JGNDFEMADJE<APPKAFHOOBE<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x42DD2E0", Offset = "0x42DC6E0", VA = "0x1842DD2E0")]
	public JCJKFMLFNDE(APPKAFHOOBE<T> IIOEMENEBDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x4BF8AD0", Offset = "0x4BF7ED0", VA = "0x184BF8AD0", Slot = "4")]
	public override bool ADOFNKOFPAL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class OHDFFCOIBIH<T> : JGNDFEMADJE<APPKAFHOOBE<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly JCLJKPGNIBN<T> INKABFNGOBD;

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5219AF0", Offset = "0x5218EF0", VA = "0x185219AF0")]
	public OHDFFCOIBIH(T IGICHEAKAKH, APPKAFHOOBE<T> IIOEMENEBDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x475A120", Offset = "0x4759520", VA = "0x18475A120", Slot = "4")]
	public override bool ADOFNKOFPAL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class FHPCGBPHOPL<T> : JGNDFEMADJE<ELOMJLFFHKB<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly DLKIBPGKFDI<T> PFHLMEEIPIO;

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x475A1D0", Offset = "0x47595D0", VA = "0x18475A1D0")]
	public FHPCGBPHOPL(T IGICHEAKAKH, bool PBGGELMPJKH, ELOMJLFFHKB<T> IIOEMENEBDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x475A120", Offset = "0x4759520", VA = "0x18475A120", Slot = "4")]
	public override bool ADOFNKOFPAL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public struct BINFGDKEFKG<TData> where TData : notnull, CDEPAPPCKJA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public IEnumerable<TData> DMBPEFCLKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public bool KGBLMJPAEBE;

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5F25A20", Offset = "0x5F24E20", VA = "0x185F25A20")]
	public BINFGDKEFKG(IEnumerable<TData> PKANDCELKLC, bool PPEJJCOHAHI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public struct OLLDHNPBGLK<TData> where TData : notnull, CDEPAPPCKJA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public List<TData> DMBPEFCLKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public List<bool> KBIOPALCADK;

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5229260", Offset = "0x5228660", VA = "0x185229260")]
	public OLLDHNPBGLK(List<TData> PKANDCELKLC, List<bool> EFGGCBGJCFJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface CDEPAPPCKJA
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool AMFCADDDHOI
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface HMJKLBNPHIB<TData> where TData : CDEPAPPCKJA
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ADOFNKOFPAL([In] BINFGDKEFKG<TData> NDLJDPPHGHJ);

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ADOFNKOFPAL([In] OLLDHNPBGLK<TData> NDLJDPPHGHJ);
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface BFEPJEFOPAL<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MCPGPLBGNLB(T IGICHEAKAKH);
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class KAALJIDMFEP<TData> : JGNDFEMADJE<HMJKLBNPHIB<TData>> where TData : notnull, CDEPAPPCKJA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly BINFGDKEFKG<TData> NDLJDPPHGHJ;

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x4D6B950", Offset = "0x4D6AD50", VA = "0x184D6B950")]
	public KAALJIDMFEP(List<TData> KJACNMKOEKF, bool KGBLMJPAEBE, HMJKLBNPHIB<TData> IIOEMENEBDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x475A120", Offset = "0x4759520", VA = "0x18475A120", Slot = "4")]
	public override bool ADOFNKOFPAL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class GCPOPAMAMFH<TData> : JGNDFEMADJE<HMJKLBNPHIB<TData>> where TData : notnull, CDEPAPPCKJA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly OLLDHNPBGLK<TData> NDLJDPPHGHJ;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x4822E00", Offset = "0x4822200", VA = "0x184822E00")]
	public GCPOPAMAMFH(List<TData> KJACNMKOEKF, List<bool> KBIOPALCADK, HMJKLBNPHIB<TData> IIOEMENEBDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x4822D40", Offset = "0x4822140", VA = "0x184822D40", Slot = "4")]
	public override bool ADOFNKOFPAL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public interface HLDDFHPEJHA<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IODGJBJINJG> ADOFNKOFPAL(DDEEPPGKGBD<TData> KMHLGKOCFGK);
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public class CBCELGMPKGK<TData> : IFNOOIADOGG<HLDDFHPEJHA<TData>, IODGJBJINJG> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private struct ACEPPEOBBFB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public AsyncTaskMethodBuilder<IODGJBJINJG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public CBCELGMPKGK<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private TaskAwaiter<IODGJBJINJG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x4803500", Offset = "0x4802900", VA = "0x184803500", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x48037E0", Offset = "0x4802BE0", VA = "0x1848037E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly DDEEPPGKGBD<TData> MNEKNGLMAHF;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x62F7570", Offset = "0x62F6970", VA = "0x1862F7570")]
	public CBCELGMPKGK(TData OPPNBHJDPMI, IReadOnlyList<TData> IIFFOMJMHFE, bool GPJBGKLGEDC, HLDDFHPEJHA<TData> IIOEMENEBDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x62F7470", Offset = "0x62F6870", VA = "0x1862F7470", Slot = "4")]
	[AsyncStateMachine(typeof(CBCELGMPKGK<>.ACEPPEOBBFB))]
	public override Task<IODGJBJINJG> ADOFNKOFPAL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public struct DDEEPPGKGBD<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public TData KKIJLOGJELH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public IReadOnlyList<TData> MIJDHEFCGMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public bool CELBKAMAFLP;

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5941C80", Offset = "0x5941080", VA = "0x185941C80")]
	public DDEEPPGKGBD(TData OPPNBHJDPMI, IReadOnlyList<TData> IIFFOMJMHFE, bool GPJBGKLGEDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface LHHIDHFLGGD<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ADOFNKOFPAL([In] ECOEDAAOIJI<TData> FCLKMMKLCOI);
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public interface IFJDGEINFHD<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ADOFNKOFPAL([In] BNPPOMCDKHA<TData> FCLKMMKLCOI);
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public interface DGFGDPCBMPF<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FAAMMMJEOKL([In] FCGOCMCCGAF<TData> FCLKMMKLCOI);

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CJLJNDDFGIC();
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class HHEHEDJINIK<TData> : JGNDFEMADJE<LHHIDHFLGGD<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly ECOEDAAOIJI<TData> FCLKMMKLCOI;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x4908370", Offset = "0x4907770", VA = "0x184908370")]
	public HHEHEDJINIK(IEnumerable<TData> KJACNMKOEKF, HHGCLPMBJBD ODFBFMBMBOG, PDDOBMNCGIK ANOGJJADLNE, float DFDHCIFLIEL, string? KIINNOIMCAK, bool GPMLLACBKOJ, bool GPJBGKLGEDC, LHHIDHFLGGD<TData> IIOEMENEBDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x475A120", Offset = "0x4759520", VA = "0x18475A120", Slot = "4")]
	public override bool ADOFNKOFPAL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class HKOBFLDIGLF<TData> : JGNDFEMADJE<IFJDGEINFHD<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly BNPPOMCDKHA<TData> FCLKMMKLCOI;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x491F560", Offset = "0x491E960", VA = "0x18491F560")]
	public HKOBFLDIGLF(TData[] KJACNMKOEKF, HHGCLPMBJBD[] ODFBFMBMBOG, PDDOBMNCGIK[] ANOGJJADLNE, float[] DFDHCIFLIEL, IFJDGEINFHD<TData> IIOEMENEBDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x48D80D0", Offset = "0x48D74D0", VA = "0x1848D80D0", Slot = "4")]
	public override bool ADOFNKOFPAL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class KFEEAOHKNOD<TData> : JGNDFEMADJE<DGFGDPCBMPF<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x42DD2E0", Offset = "0x42DC6E0", VA = "0x1842DD2E0")]
	public KFEEAOHKNOD(DGFGDPCBMPF<TData> IIOEMENEBDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x4D79300", Offset = "0x4D78700", VA = "0x184D79300", Slot = "4")]
	public override bool ADOFNKOFPAL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class AHENJNBABDG<TData> : JGNDFEMADJE<DGFGDPCBMPF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly FCGOCMCCGAF<TData> FCLKMMKLCOI;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x48D8180", Offset = "0x48D7580", VA = "0x1848D8180")]
	public AHENJNBABDG(IEnumerable<TData> KJACNMKOEKF, HHGCLPMBJBD ODFBFMBMBOG, PDDOBMNCGIK ANOGJJADLNE, float DFDHCIFLIEL, DGFGDPCBMPF<TData> IIOEMENEBDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x48D80D0", Offset = "0x48D74D0", VA = "0x1848D80D0", Slot = "4")]
	public override bool ADOFNKOFPAL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public struct ECOEDAAOIJI<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public IEnumerable<TData> DMBPEFCLKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public HHGCLPMBJBD BANAMCLKDPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public PDDOBMNCGIK MEFOBPAMFDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public float FKEGODKMFLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public string? OLBGIJNAOGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public bool? GJDPENCLCDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public bool CELBKAMAFLP;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x42CF6B0", Offset = "0x42CEAB0", VA = "0x1842CF6B0")]
	public ECOEDAAOIJI(IEnumerable<TData> KJACNMKOEKF, HHGCLPMBJBD ODFBFMBMBOG, PDDOBMNCGIK ANOGJJADLNE, float DFDHCIFLIEL, string? KIINNOIMCAK, bool? GPMLLACBKOJ, bool GPJBGKLGEDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public struct BNPPOMCDKHA<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public TData[] DMBPEFCLKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public HHGCLPMBJBD[] BANAMCLKDPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public PDDOBMNCGIK[] MEFOBPAMFDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public float[] DFDHCIFLIEL;

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6016790", Offset = "0x6015B90", VA = "0x186016790")]
	public BNPPOMCDKHA(TData[] KJACNMKOEKF, HHGCLPMBJBD[] ODFBFMBMBOG, PDDOBMNCGIK[] ANOGJJADLNE, float[] DFDHCIFLIEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public struct FCGOCMCCGAF<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public IEnumerable<TData> DMBPEFCLKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public HHGCLPMBJBD BANAMCLKDPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public PDDOBMNCGIK MEFOBPAMFDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public float DFDHCIFLIEL;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x4713D20", Offset = "0x4713120", VA = "0x184713D20")]
	public FCGOCMCCGAF(IEnumerable<TData> KJACNMKOEKF, HHGCLPMBJBD ODFBFMBMBOG, PDDOBMNCGIK ANOGJJADLNE, float DFDHCIFLIEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public interface FHILBNMJLGJ<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DCHBOBHDLPD([In] JOACNICLPDC<TData> EJADPOCNOIM);

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void COEMACMOCAF([In] JOACNICLPDC<TData> EJADPOCNOIM);

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ENLLHAMLCBP([In] bool MMEHKJKHBHC);

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool NJJAGEGLCFC([In] JOACNICLPDC<TData> EJADPOCNOIM);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HCBBEIJACIA();

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool LCKCKMGNEDD([In] TData DLMJMCOANIF);
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class DPFHBKHBNHL<TData> : JGNDFEMADJE<FHILBNMJLGJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly JOACNICLPDC<TData> EJADPOCNOIM;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x66FFA70", Offset = "0x66FEE70", VA = "0x1866FFA70")]
	public DPFHBKHBNHL(List<TData> KKIPPMFKGPH, FHILBNMJLGJ<TData> IIOEMENEBDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x475A120", Offset = "0x4759520", VA = "0x18475A120", Slot = "4")]
	public override bool ADOFNKOFPAL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class EENOBPPPMHL<TData> : JGNDFEMADJE<FHILBNMJLGJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x42DD2E0", Offset = "0x42DC6E0", VA = "0x1842DD2E0")]
	public EENOBPPPMHL(FHILBNMJLGJ<TData> IIOEMENEBDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x42DD290", Offset = "0x42DC690", VA = "0x1842DD290", Slot = "4")]
	public override bool ADOFNKOFPAL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class ANJACCOCIED<TData> : JGNDFEMADJE<FHILBNMJLGJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly bool GPJBGKLGEDC;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x49FCAC0", Offset = "0x49FBEC0", VA = "0x1849FCAC0")]
	public ANJACCOCIED(bool GPJBGKLGEDC, FHILBNMJLGJ<TData> IIOEMENEBDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x49FCA60", Offset = "0x49FBE60", VA = "0x1849FCA60", Slot = "4")]
	public override bool ADOFNKOFPAL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class IGJJGACHFCD<TData> : JGNDFEMADJE<FHILBNMJLGJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly JOACNICLPDC<TData> EJADPOCNOIM;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x4A138D0", Offset = "0x4A12CD0", VA = "0x184A138D0")]
	public IGJJGACHFCD(List<TData> KKIPPMFKGPH, bool GPJBGKLGEDC, FHILBNMJLGJ<TData> IIOEMENEBDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x4822D40", Offset = "0x4822140", VA = "0x184822D40", Slot = "4")]
	public override bool ADOFNKOFPAL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class MJEJMNFHPGO<TData> : JGNDFEMADJE<FHILBNMJLGJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly TData DLMJMCOANIF;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x5061340", Offset = "0x5060740", VA = "0x185061340")]
	public MJEJMNFHPGO(TData DLMJMCOANIF, FHILBNMJLGJ<TData> IIOEMENEBDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x5061280", Offset = "0x5060680", VA = "0x185061280", Slot = "4")]
	public override bool ADOFNKOFPAL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class KPBBGNELFBO<TData> : JGNDFEMADJE<FHILBNMJLGJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly JOACNICLPDC<TData> EJADPOCNOIM;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x4DCDEA0", Offset = "0x4DCD2A0", VA = "0x184DCDEA0")]
	public KPBBGNELFBO(IEnumerable<TData> KKIPPMFKGPH, FHILBNMJLGJ<TData> IIOEMENEBDK, bool GPJBGKLGEDC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x4DCDDE0", Offset = "0x4DCD1E0", VA = "0x184DCDDE0", Slot = "4")]
	public override bool ADOFNKOFPAL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public struct JOACNICLPDC<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public IEnumerable<TData> DMBPEFCLKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public bool GPJBGKLGEDC;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x4C8D3B0", Offset = "0x4C8C7B0", VA = "0x184C8D3B0")]
	public JOACNICLPDC(IEnumerable<TData> PKANDCELKLC, bool KEKPGLLFBOB = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public interface GPIKEBNGDIB
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IODGJBJINJG> ADOFNKOFPAL(JOHJCAHJLBE HPDIHEGNFFI);
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class GJGNLFPCCMP : IFNOOIADOGG<GPIKEBNGDIB, IODGJBJINJG>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private struct MJEJAKEEKDF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public AsyncTaskMethodBuilder<IODGJBJINJG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public GJGNLFPCCMP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private TaskAwaiter<IODGJBJINJG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x792C8F0", Offset = "0x792BCF0", VA = "0x18792C8F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x792CB60", Offset = "0x792BF60", VA = "0x18792CB60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly JOHJCAHJLBE PIEJEGAGOGA;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x792BB40", Offset = "0x792AF40", VA = "0x18792BB40")]
	public GJGNLFPCCMP(bool GPJBGKLGEDC, GPIKEBNGDIB IIOEMENEBDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x792BA50", Offset = "0x792AE50", VA = "0x18792BA50", Slot = "4")]
	[AsyncStateMachine(typeof(MJEJAKEEKDF))]
	public override Task<IODGJBJINJG> ADOFNKOFPAL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public struct JOHJCAHJLBE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public bool CELBKAMAFLP;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x28634A0", Offset = "0x28628A0", VA = "0x1828634A0")]
	public JOHJCAHJLBE(bool GPJBGKLGEDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public readonly struct LKBEIIBACBA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public readonly bool HIAAMMEKFGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public readonly bool FEONNMEOEEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public readonly bool KJPCKOGHHCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public readonly bool GPJBGKLGEDC;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x59638E0", Offset = "0x5962CE0", VA = "0x1859638E0")]
	public LKBEIIBACBA(bool HIAAMMEKFGG, bool FEONNMEOEEJ, bool KJPCKOGHHCN, bool GPJBGKLGEDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x792C8A0", Offset = "0x792BCA0", VA = "0x18792C8A0")]
	public LKBEIIBACBA(bool FEONNMEOEEJ, bool GPJBGKLGEDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public interface AHDBPGDEMDF
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FEFIIOJDDJA(LKBEIIBACBA ODMFMFKDGJA);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool AGENGFNGHEP(LKBEIIBACBA ODMFMFKDGJA);
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class EBDDAGNKCLP : JGNDFEMADJE<AHDBPGDEMDF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly LKBEIIBACBA ODMFMFKDGJA;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x792B940", Offset = "0x792AD40", VA = "0x18792B940")]
	public EBDDAGNKCLP(bool KHDOKFIGIID, bool FEONNMEOEEJ, bool KJPCKOGHHCN, bool GPJBGKLGEDC, AHDBPGDEMDF IIOEMENEBDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x792B8F0", Offset = "0x792ACF0", VA = "0x18792B8F0", Slot = "4")]
	public override bool ADOFNKOFPAL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public class JDCFINKPFDE : JGNDFEMADJE<AHDBPGDEMDF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private readonly LKBEIIBACBA ODMFMFKDGJA;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x792BD40", Offset = "0x792B140", VA = "0x18792BD40")]
	public JDCFINKPFDE(bool FEONNMEOEEJ, bool GPJBGKLGEDC, AHDBPGDEMDF IIOEMENEBDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x792BCF0", Offset = "0x792B0F0", VA = "0x18792BCF0", Slot = "4")]
	public override bool ADOFNKOFPAL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public interface FBBDILNFHPL
{
	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ADOFNKOFPAL([In] DKGBINGDPMM EGKCBDPDOCD);
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class KANEFPPHOMJ : JGNDFEMADJE<FBBDILNFHPL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private readonly DKGBINGDPMM EGKCBDPDOCD;

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x792BE70", Offset = "0x792B270", VA = "0x18792BE70")]
	public KANEFPPHOMJ(Guid[] BFBDJHKNNMN, Vector3[] NEPJAEMANGF, Quaternion[] MAGMMPNCJCE, float[] PBCFAKAKPHE, Dictionary<Guid, Vector3> FFIAKGFKMDC, FBBDILNFHPL IIOEMENEBDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x792BDC0", Offset = "0x792B1C0", VA = "0x18792BDC0", Slot = "4")]
	public override bool ADOFNKOFPAL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public interface OIBBAOILKLA<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DIMEPCIPGBI([In] FHEECCPJMGA<TData> DNAFHCNLLLC);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FAAMMMJEOKL([In] CDBABKKCLPI KGBGOHFNDPC);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FAAMMMJEOKL([In] MILOMFEGBLO KGBGOHFNDPC);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CJLJNDDFGIC();
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class IEDPIMIFAIK<TData> : JGNDFEMADJE<OIBBAOILKLA<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x42DD2E0", Offset = "0x42DC6E0", VA = "0x1842DD2E0")]
	public IEDPIMIFAIK(OIBBAOILKLA<TData> IIOEMENEBDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x4A04D50", Offset = "0x4A04150", VA = "0x184A04D50", Slot = "4")]
	public override bool ADOFNKOFPAL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class JDJHJOMFELO<TData> : JGNDFEMADJE<OIBBAOILKLA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly CDBABKKCLPI GACKJLOLKDG;

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x4C00670", Offset = "0x4BFFA70", VA = "0x184C00670")]
	public JDJHJOMFELO(Vector3 LLJMMAENFNL, bool JKLFNIAJAKL, OIBBAOILKLA<TData> IIOEMENEBDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x42E0540", Offset = "0x42DF940", VA = "0x1842E0540", Slot = "4")]
	public override bool ADOFNKOFPAL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class LIPKFKJLHMF<TData> : JGNDFEMADJE<OIBBAOILKLA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly MILOMFEGBLO GACKJLOLKDG;

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x4E6A700", Offset = "0x4E69B00", VA = "0x184E6A700")]
	public LIPKFKJLHMF(Guid FKADBDGPOIG, int CJFNAFNJJLB, Vector3 INHMOEHIHAJ, Quaternion AJFJKBHPFHG, float JAINCGFCEKN, bool JKLFNIAJAKL, OIBBAOILKLA<TData> IIOEMENEBDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x4E6A6A0", Offset = "0x4E69AA0", VA = "0x184E6A6A0", Slot = "4")]
	public override bool ADOFNKOFPAL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public class LFCDLOFHDOI<TData> : JGNDFEMADJE<OIBBAOILKLA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly FHEECCPJMGA<TData> GACKJLOLKDG;

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x4E5E650", Offset = "0x4E5DA50", VA = "0x184E5E650")]
	public LFCDLOFHDOI(TData IGICHEAKAKH, bool GPJBGKLGEDC, OIBBAOILKLA<TData> IIOEMENEBDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x475A120", Offset = "0x4759520", VA = "0x18475A120", Slot = "4")]
	public override bool ADOFNKOFPAL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct CDBABKKCLPI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public readonly Vector3 LLJMMAENFNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public readonly bool JKLFNIAJAKL;

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x792B2E0", Offset = "0x792A6E0", VA = "0x18792B2E0")]
	public CDBABKKCLPI(Vector3 LLJMMAENFNL, bool JKLFNIAJAKL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct MILOMFEGBLO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public readonly Guid FKADBDGPOIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public readonly int CJFNAFNJJLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public readonly Vector3 INHMOEHIHAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public readonly Quaternion AJFJKBHPFHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public readonly float JAINCGFCEKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public readonly bool JKLFNIAJAKL;

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x792C8B0", Offset = "0x792BCB0", VA = "0x18792C8B0")]
	public MILOMFEGBLO(Guid FKADBDGPOIG, int CJFNAFNJJLB, Vector3 INHMOEHIHAJ, Quaternion AJFJKBHPFHG, float JAINCGFCEKN, bool JKLFNIAJAKL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct FHEECCPJMGA<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public readonly TData IGICHEAKAKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public readonly bool GPJBGKLGEDC;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x47556D0", Offset = "0x4754AD0", VA = "0x1847556D0")]
	public FHEECCPJMGA(TData IGICHEAKAKH, bool GPJBGKLGEDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public interface DFFEPDBKMOG<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ADOFNKOFPAL([In] LENHMOLNOMI<TData> ACOHHOJOEBL);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool ADOFNKOFPAL([In] CLIEPAFMIIF<TData> ACOHHOJOEBL);
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public interface LOABJBDLPLO<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DIMEPCIPGBI([In] NPCHKHCDINI<TData> HBPMGKFDOMJ);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FAAMMMJEOKL([In] OIPJNNBMDFG KGBGOHFNDPC);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CJLJNDDFGIC();
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public class MPIMMBNCLAD<TData> : JGNDFEMADJE<DFFEPDBKMOG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly LENHMOLNOMI<TData> ACOHHOJOEBL;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x50924E0", Offset = "0x50918E0", VA = "0x1850924E0")]
	public MPIMMBNCLAD(IEnumerable<TData> KJACNMKOEKF, Vector3 KEABHNKJEJL, bool GPJBGKLGEDC, DFFEPDBKMOG<TData> IIOEMENEBDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x475A120", Offset = "0x4759520", VA = "0x18475A120", Slot = "4")]
	public override bool ADOFNKOFPAL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class OFLBMDAENCD<TData> : JGNDFEMADJE<LOABJBDLPLO<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x42DD2E0", Offset = "0x42DC6E0", VA = "0x1842DD2E0")]
	public OFLBMDAENCD(LOABJBDLPLO<TData> IIOEMENEBDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x4A19AC0", Offset = "0x4A18EC0", VA = "0x184A19AC0", Slot = "4")]
	public override bool ADOFNKOFPAL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public class FNKEGOEHIII<TData> : JGNDFEMADJE<LOABJBDLPLO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly NPCHKHCDINI<TData> ACOHHOJOEBL;

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x4781710", Offset = "0x4780B10", VA = "0x184781710")]
	public FNKEGOEHIII(IEnumerable<TData> KJACNMKOEKF, bool GPJBGKLGEDC, LOABJBDLPLO<TData> IIOEMENEBDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x475A120", Offset = "0x4759520", VA = "0x18475A120", Slot = "4")]
	public override bool ADOFNKOFPAL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public class FIDLCEBANBH<TData> : JGNDFEMADJE<DFFEPDBKMOG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly CLIEPAFMIIF<TData> ACOHHOJOEBL;

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x475C6B0", Offset = "0x475BAB0", VA = "0x18475C6B0")]
	public FIDLCEBANBH(IEnumerable<TData> KJACNMKOEKF, Vector3 LAMBJIGHILG, PMELDKIKMIE OALABDCOOMK, bool GPJBGKLGEDC, DFFEPDBKMOG<TData> IIOEMENEBDK, Space HLKADIEGIFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x4700510", Offset = "0x46FF910", VA = "0x184700510", Slot = "4")]
	public override bool ADOFNKOFPAL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class HFGHCBFKFKB<TData> : JGNDFEMADJE<LOABJBDLPLO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly OIPJNNBMDFG ACOHHOJOEBL;

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x48FFA40", Offset = "0x48FEE40", VA = "0x1848FFA40")]
	public HFGHCBFKFKB(Vector3 KEABHNKJEJL, LOABJBDLPLO<TData> IIOEMENEBDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x42E0540", Offset = "0x42DF940", VA = "0x1842E0540", Slot = "4")]
	public override bool ADOFNKOFPAL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public struct LENHMOLNOMI<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public readonly IEnumerable<TData> KJACNMKOEKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public readonly Vector3 KEABHNKJEJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly bool GPJBGKLGEDC;

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x4E5DDF0", Offset = "0x4E5D1F0", VA = "0x184E5DDF0")]
	public LENHMOLNOMI(IEnumerable<TData> KJACNMKOEKF, Vector3 KEABHNKJEJL, bool GPJBGKLGEDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct NPCHKHCDINI<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public readonly IEnumerable<TData> KJACNMKOEKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public readonly bool GPJBGKLGEDC;

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x510E990", Offset = "0x510DD90", VA = "0x18510E990")]
	public NPCHKHCDINI(IEnumerable<TData> KJACNMKOEKF, bool GPJBGKLGEDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public struct CLIEPAFMIIF<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public readonly IEnumerable<TData> KJACNMKOEKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public readonly Vector3 LAMBJIGHILG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public readonly PMELDKIKMIE OALABDCOOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public readonly bool GPJBGKLGEDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public readonly Space HLKADIEGIFF;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x63FBF00", Offset = "0x63FB300", VA = "0x1863FBF00")]
	public CLIEPAFMIIF(IEnumerable<TData> KJACNMKOEKF, Vector3 LAMBJIGHILG, PMELDKIKMIE OALABDCOOMK, bool GPJBGKLGEDC, Space HLKADIEGIFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public struct OIPJNNBMDFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public readonly Vector3 KEABHNKJEJL;

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0xE09E60", Offset = "0xE09260", VA = "0x180E09E60")]
	public OIPJNNBMDFG(Vector3 KEABHNKJEJL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public enum PMELDKIKMIE
{
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	XYZ,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	X_only,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	Y_only,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	Z_only
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public interface DJAAINBDNHH
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ADOFNKOFPAL([In] MNKHBHOKMIA KOGKHNMDOFJ);
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public class NJLFKDMIBGM : JGNDFEMADJE<DJAAINBDNHH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly MNKHBHOKMIA KOGKHNMDOFJ;

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x792CC80", Offset = "0x792C080", VA = "0x18792CC80")]
	public NJLFKDMIBGM(bool GPJBGKLGEDC, DJAAINBDNHH IIOEMENEBDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x792CBD0", Offset = "0x792BFD0", VA = "0x18792CBD0", Slot = "4")]
	public override bool ADOFNKOFPAL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public readonly struct MNKHBHOKMIA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public readonly bool GPJBGKLGEDC;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x28634A0", Offset = "0x28628A0", VA = "0x1828634A0")]
	public MNKHBHOKMIA(bool GPJBGKLGEDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public interface JJMJFPPKMKO<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ADOFNKOFPAL([In] KBBGHILHNNJ<TData> BJCPMGCPBPH);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool ADOFNKOFPAL([In] HIAIIOJFKID<TData> BJCPMGCPBPH);
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public interface CPLGPJLMEDD<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DIMEPCIPGBI([In] LBCEHHABIGA<TData> DNAFHCNLLLC);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FAAMMMJEOKL([In] HOJJLBLAMJM KGBGOHFNDPC);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CJLJNDDFGIC();
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public class FNJCEPCFFKD<TData> : JGNDFEMADJE<JJMJFPPKMKO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly KBBGHILHNNJ<TData> BJCPMGCPBPH;

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x4781140", Offset = "0x4780540", VA = "0x184781140")]
	public FNJCEPCFFKD(IEnumerable<TData> KJACNMKOEKF, Quaternion KEABHNKJEJL, Vector3? EBNIDNBAAPA, bool IIMGLMPAKKK, bool GPJBGKLGEDC, JJMJFPPKMKO<TData> IIOEMENEBDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x475A120", Offset = "0x4759520", VA = "0x18475A120", Slot = "4")]
	public override bool ADOFNKOFPAL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class IILHGEINFNC<TData> : JGNDFEMADJE<CPLGPJLMEDD<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x42DD2E0", Offset = "0x42DC6E0", VA = "0x1842DD2E0")]
	public IILHGEINFNC(CPLGPJLMEDD<TData> IIOEMENEBDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x4A19AC0", Offset = "0x4A18EC0", VA = "0x184A19AC0", Slot = "4")]
	public override bool ADOFNKOFPAL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class HDAGEIBIIMH<TData> : JGNDFEMADJE<CPLGPJLMEDD<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly LBCEHHABIGA<TData> BJCPMGCPBPH;

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x48FB680", Offset = "0x48FAA80", VA = "0x1848FB680")]
	public HDAGEIBIIMH(IEnumerable<TData> KJACNMKOEKF, bool GPJBGKLGEDC, CPLGPJLMEDD<TData> IIOEMENEBDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x475A120", Offset = "0x4759520", VA = "0x18475A120", Slot = "4")]
	public override bool ADOFNKOFPAL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class FNPIOEOIBBP<TData> : JGNDFEMADJE<JJMJFPPKMKO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly HIAIIOJFKID<TData> BJCPMGCPBPH;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x4781850", Offset = "0x4780C50", VA = "0x184781850")]
	public FNPIOEOIBBP(IEnumerable<TData> KJACNMKOEKF, Quaternion JFPGIHEJAKG, PMELDKIKMIE LJEBHDBMHDL, Vector3? EBNIDNBAAPA, bool IIMGLMPAKKK, bool GPJBGKLGEDC, Space HLKADIEGIFF, JJMJFPPKMKO<TData> IIOEMENEBDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x4700510", Offset = "0x46FF910", VA = "0x184700510", Slot = "4")]
	public override bool ADOFNKOFPAL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public class EGNFBMNCGIF<TData> : JGNDFEMADJE<CPLGPJLMEDD<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private readonly HOJJLBLAMJM BJCPMGCPBPH;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x42E05A0", Offset = "0x42DF9A0", VA = "0x1842E05A0")]
	public EGNFBMNCGIF(Quaternion KEABHNKJEJL, Vector3? EBNIDNBAAPA, bool IIMGLMPAKKK, CPLGPJLMEDD<TData> IIOEMENEBDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x42E0540", Offset = "0x42DF940", VA = "0x1842E0540", Slot = "4")]
	public override bool ADOFNKOFPAL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public struct KBBGHILHNNJ<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public readonly IEnumerable<TData> KJACNMKOEKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public readonly Quaternion KEABHNKJEJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public readonly Vector3? EBNIDNBAAPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public readonly bool IIMGLMPAKKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public readonly bool GPJBGKLGEDC;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x4D6E7A0", Offset = "0x4D6DBA0", VA = "0x184D6E7A0")]
	public KBBGHILHNNJ(IEnumerable<TData> KJACNMKOEKF, Quaternion KEABHNKJEJL, Vector3? EBNIDNBAAPA, bool IIMGLMPAKKK, bool GPJBGKLGEDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct LBCEHHABIGA<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public readonly IEnumerable<TData> KJACNMKOEKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public readonly bool GPJBGKLGEDC;

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x4E4A570", Offset = "0x4E49970", VA = "0x184E4A570")]
	public LBCEHHABIGA(IEnumerable<TData> KJACNMKOEKF, bool GPJBGKLGEDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public struct HIAIIOJFKID<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public readonly IEnumerable<TData> KJACNMKOEKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public readonly Quaternion JFPGIHEJAKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public readonly PMELDKIKMIE LJEBHDBMHDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public readonly Vector3? EBNIDNBAAPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public readonly bool IIMGLMPAKKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public readonly bool GPJBGKLGEDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public readonly Space HLKADIEGIFF;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x4909770", Offset = "0x4908B70", VA = "0x184909770")]
	public HIAIIOJFKID(IEnumerable<TData> KJACNMKOEKF, Quaternion JFPGIHEJAKG, PMELDKIKMIE LJEBHDBMHDL, Vector3? EBNIDNBAAPA, bool IIMGLMPAKKK, bool GPJBGKLGEDC, Space HLKADIEGIFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct HOJJLBLAMJM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly Quaternion KEABHNKJEJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public readonly Vector3? EBNIDNBAAPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly bool IIMGLMPAKKK;

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x590C760", Offset = "0x590BB60", VA = "0x18590C760")]
	public HOJJLBLAMJM(Quaternion KEABHNKJEJL, Vector3? EBNIDNBAAPA, bool IIMGLMPAKKK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public interface JPINFMPIMEH<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DIMEPCIPGBI([In] EFPBIJKODHF<TData> DNAFHCNLLLC);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FAAMMMJEOKL([In] IAKDBOOKOOM KGBGOHFNDPC);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FAAMMMJEOKL([In] OAAOINPOBII KGBGOHFNDPC);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool FAAMMMJEOKL([In] EOHNPNGJNIF KGBGOHFNDPC);

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool CJLJNDDFGIC();
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public class OGBJOKPPHKK<TData> : JGNDFEMADJE<JPINFMPIMEH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private readonly EOHNPNGJNIF CGBEACDPHBE;

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x5213B10", Offset = "0x5212F10", VA = "0x185213B10")]
	public OGBJOKPPHKK(Vector3 NLGMAOKFEML, float KMDFDGNLAGC, Vector3 EBNIDNBAAPA, bool NNKMHLIHKPO, bool DAKGFJFBGMG, JPINFMPIMEH<TData> IIOEMENEBDK, Space HLKADIEGIFF = Space.Self)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x5213AB0", Offset = "0x5212EB0", VA = "0x185213AB0", Slot = "4")]
	public override bool ADOFNKOFPAL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public class IMIBANDOLGH<TData> : JGNDFEMADJE<JPINFMPIMEH<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x42DD2E0", Offset = "0x42DC6E0", VA = "0x1842DD2E0")]
	public IMIBANDOLGH(JPINFMPIMEH<TData> IIOEMENEBDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x4A26A10", Offset = "0x4A25E10", VA = "0x184A26A10", Slot = "4")]
	public override bool ADOFNKOFPAL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public class FOFFBJGLHFB<TData> : JGNDFEMADJE<JPINFMPIMEH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private readonly EFPBIJKODHF<TData> CGBEACDPHBE;

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x4781A40", Offset = "0x4780E40", VA = "0x184781A40")]
	public FOFFBJGLHFB(IEnumerable<TData> KJACNMKOEKF, bool GPJBGKLGEDC, JPINFMPIMEH<TData> IIOEMENEBDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x475A120", Offset = "0x4759520", VA = "0x18475A120", Slot = "4")]
	public override bool ADOFNKOFPAL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public class NPJIBKGEHHF<TData> : JGNDFEMADJE<JPINFMPIMEH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private readonly OAAOINPOBII CGBEACDPHBE;

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x510F080", Offset = "0x510E480", VA = "0x18510F080")]
	public NPJIBKGEHHF(float BDBGGONLKAF, bool HELGCDKCFJI, Vector3 EBNIDNBAAPA, JPINFMPIMEH<TData> IIOEMENEBDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x510EFC0", Offset = "0x510E3C0", VA = "0x18510EFC0", Slot = "4")]
	public override bool ADOFNKOFPAL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public class LPIGMLELPGP<TData> : JGNDFEMADJE<JPINFMPIMEH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private readonly IAKDBOOKOOM CGBEACDPHBE;

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x4E80F70", Offset = "0x4E80370", VA = "0x184E80F70")]
	public LPIGMLELPGP(float KMDFDGNLAGC, Vector3 EBNIDNBAAPA, JPINFMPIMEH<TData> IIOEMENEBDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x42E0540", Offset = "0x42DF940", VA = "0x1842E0540", Slot = "4")]
	public override bool ADOFNKOFPAL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public struct EOHNPNGJNIF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public readonly Vector3 NLGMAOKFEML;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public readonly float KMDFDGNLAGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public readonly Vector3 EBNIDNBAAPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public readonly bool JKLFNIAJAKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public readonly Space HLKADIEGIFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public readonly bool DAKGFJFBGMG;

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x792B9D0", Offset = "0x792ADD0", VA = "0x18792B9D0")]
	public EOHNPNGJNIF(Vector3 NLGMAOKFEML, float KMDFDGNLAGC, Vector3 EBNIDNBAAPA, bool JKLFNIAJAKL, bool DKJHEKGFEFL, Space HLKADIEGIFF = Space.Self)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public struct EFPBIJKODHF<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public readonly IEnumerable<TData> KJACNMKOEKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public readonly bool GPJBGKLGEDC;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x42DF0D0", Offset = "0x42DE4D0", VA = "0x1842DF0D0")]
	public EFPBIJKODHF(IEnumerable<TData> KJACNMKOEKF, bool GPJBGKLGEDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public struct OAAOINPOBII
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public readonly float BDBGGONLKAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public readonly bool HELGCDKCFJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public readonly Vector3 EBNIDNBAAPA;

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x792CD60", Offset = "0x792C160", VA = "0x18792CD60")]
	public OAAOINPOBII(float BDBGGONLKAF, bool HELGCDKCFJI, Vector3 EBNIDNBAAPA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public struct IAKDBOOKOOM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public readonly float KMDFDGNLAGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public readonly Vector3 EBNIDNBAAPA;

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x58E2300", Offset = "0x58E1700", VA = "0x1858E2300")]
	public IAKDBOOKOOM(float KMDFDGNLAGC, Vector3 EBNIDNBAAPA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public struct DKGBINGDPMM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public readonly Guid[] KJACNMKOEKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public readonly bool DBMEMEOPIOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public readonly bool FMMBANIKLNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public readonly bool FLENHAJMAPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public readonly Vector3[] NEPJAEMANGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public readonly Quaternion[] MAGMMPNCJCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public readonly float[] PBCFAKAKPHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public readonly Dictionary<Guid, Vector3> FFIAKGFKMDC;

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x792B660", Offset = "0x792AA60", VA = "0x18792B660")]
	public DKGBINGDPMM(Guid[] BFBDJHKNNMN, Vector3[] NEPJAEMANGF, Quaternion[] MAGMMPNCJCE, float[] PBCFAKAKPHE, Dictionary<Guid, Vector3> FFIAKGFKMDC, bool DBMEMEOPIOO = true, bool FMMBANIKLNA = true, bool FLENHAJMAPA = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x792B490", Offset = "0x792A890", VA = "0x18792B490")]
	private static void KIGEIBDJPCP(Dictionary<Guid, Vector3> FFIAKGFKMDC, int KAHDEDJBCDB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public static class PNKMKLCJOLO
{
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	private struct FFMAGMHJKGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public bool LMLKBFEHCMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public DHLGDCALOEP BPBHJEDHMPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public DHLGDCALOEP CMDFOGMPJNK;
	}

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static FFMAGMHJKGC BCEJJFNLADJ;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static CancellationToken IFEMJINDLEO
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x792D1D0", Offset = "0x792C5D0", VA = "0x18792D1D0")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	internal static DHLGDCALOEP BPBHJEDHMPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x792CF30", Offset = "0x792C330", VA = "0x18792CF30")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x792D170", Offset = "0x792C570", VA = "0x18792D170")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x792D1F0", Offset = "0x792C5F0", VA = "0x18792D1F0")]
	[NOCPMGCIOME.FDFINDJJAOF]
	internal static void OPNOJEPKKPP(DHLGDCALOEP CNMOKPGFOGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x792D020", Offset = "0x792C420", VA = "0x18792D020")]
	public static void GCJCJGLHJHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x792CFD0", Offset = "0x792C3D0", VA = "0x18792CFD0")]
	private static DHLGDCALOEP FBIKAFBJDML(DHLGDCALOEP GFGIBNLEFOJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public static class DNNNDBFFBEJ
{
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	public enum KDIGOHAPNGL
	{
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		ICreationContextObject,
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		Guid
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x345D5D0", Offset = "0x345C9D0", VA = "0x18345D5D0")]
	public static void DBFKHOLFJGB<T>(T JJKLCHMKBKA, KDIGOHAPNGL HAFNBBNOLPO) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x345D740", Offset = "0x345CB40", VA = "0x18345D740")]
	public static void DBFKHOLFJGB<T>(T JJKLCHMKBKA) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x345DBE0", Offset = "0x345CFE0", VA = "0x18345DBE0")]
	public static void NHMNIBAJNLJ<T>(T JJKLCHMKBKA) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x345DAD0", Offset = "0x345CED0", VA = "0x18345DAD0")]
	public static T IOLMGDEDCOJ<T>(KDIGOHAPNGL HAFNBBNOLPO) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x345D7B0", Offset = "0x345CBB0", VA = "0x18345D7B0")]
	public static bool GLKKFIAAGGI<T>(KDIGOHAPNGL HAFNBBNOLPO, T? LAEOOACFMOO, [Out][NotNullWhen(true)][MaybeNullWhen(false)] T OIGLGFONIBN) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x345D9C0", Offset = "0x345CDC0", VA = "0x18345D9C0")]
	public static bool HKCGDJOOGIH<T>(KDIGOHAPNGL HAFNBBNOLPO, [Out][MaybeNullWhen(false)][NotNullWhen(true)] T CJCPCKBMPFN) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x345DC90", Offset = "0x345D090", VA = "0x18345DC90")]
	public static bool NMJMIBNPAKK<T>(KDIGOHAPNGL HAFNBBNOLPO) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x345DB80", Offset = "0x345CF80", VA = "0x18345DB80")]
	public static T IOLMGDEDCOJ<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x345D900", Offset = "0x345CD00", VA = "0x18345D900")]
	public static bool GLKKFIAAGGI<T>(T LAEOOACFMOO, [Out] T OIGLGFONIBN) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x345DB80", Offset = "0x345CF80", VA = "0x18345DB80")]
	public static bool NMJMIBNPAKK<T>() where T : class
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
internal static class KNLLEGNODFE
{
	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x792C670", Offset = "0x792BA70", VA = "0x18792C670")]
	public static void FKHOGLDCOLF(IEnumerable MMFKJCOOJAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x36E1F20", Offset = "0x36E1320", VA = "0x1836E1F20")]
	public static void FKHOGLDCOLF<T>(T[] LLPLHOOOAEB) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x36E2100", Offset = "0x36E1500", VA = "0x1836E2100")]
	public static void FKHOGLDCOLF<T>(T OEAPKNBFGIB) where T : notnull, Enum
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
