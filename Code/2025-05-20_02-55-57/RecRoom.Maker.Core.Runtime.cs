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
		[Cpp2IlInjected.Address(RVA = "0xA1A8A0", Offset = "0xA19AA0", VA = "0x180A1A8A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CF1E00", Offset = "0x7CF1000", VA = "0x187CF1E00")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA1B770", Offset = "0xA1A970", VA = "0x180A1B770")]
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
		[Cpp2IlInjected.Address(RVA = "0xA1B7B0", Offset = "0xA1A9B0", VA = "0x180A1B7B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CF2340", Offset = "0x7CF1540", VA = "0x187CF2340", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2675970", Offset = "0x2674B70", VA = "0x182675970")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface LBFGPLPNEFE<TData, TReturn>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TReturn DKDJKONMJKN(TData DBCLNEGBNLN);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface IIFPLHEOPPO<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ClearHoverTarget(CJFCFAPFFAG JDKCHJAENGF);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool SetHoverTarget(TData PJNHLGGHCLG, Collider KOEENBDOIKL, CJFCFAPFFAG JDKCHJAENGF, [Optional] LIGLMNBGNIO? HKEAEPNCNLH);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool TryGetHoverTarget([Out] TData PJNHLGGHCLG);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetHoverCollider([Out] Collider KOEENBDOIKL);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface IJEAGDLHLAM<TData> : ICDBDDAIGOD, INABOCFHLNA<TData>, CFCCALDKEBP<TData>, NAFCJJMJIAP<TData>, ECKLFCMPAGG, IJDMKGGAEGP<TData>, LPMEHLIMJMJ, KIFGBFJKDMO
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface IJDMKGGAEGP<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 CGNCLEEPDED, Vector3 ACBMNMFGAEN, float BMKHJPOEOBG, [Out] T OOPFNHJOAFM, [Out] Vector3 EBDHHIEJDBO, [Out] Collider KOEENBDOIKL);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 CGNCLEEPDED, Vector3 ACBMNMFGAEN, float BLJBJPDFCOB, float BMKHJPOEOBG, T[] HJFAFLGMGPP, [Out] Vector3 APAGCAGDBPJ, [Out] Collider EAEGDIMJGOJ);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 CGNCLEEPDED, float BLJBJPDFCOB, Vector3 KKFMNMEGOCK, T[] HJFAFLGMGPP);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetObjectFromColliderInCurrentScope(Collider NKJGEEFAAOO, [Out] T GEHMMFHFKMK);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface ICDBDDAIGOD
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Bounds IMADIJPDBCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Transform LHIOLBLLGLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Bounds JIJFFMOAABF
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Transform KOOEBHKIIAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Vector3 FGGHBOKLCJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool NLCACANEAEP
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
	void SetSelectionBoundsDirty(bool KCGKCJJBNDD = true, int DJMEDLGJAFG = 0);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ShouldHideSelectionBoundsPreview(bool BPENGBOBBNO, object PPOILDCNBFL);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface KIFGBFJKDMO
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	JGNOJICCDHE OCKKFDAFHFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface NNCFMCILIGM
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool HHFBMFHBDAF
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool KLLFJLOEGHC
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool LJHDILLAKFO
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
	void TrySetPreviousCloneMapping(Dictionary<Guid, Guid> CKMFNHNKNGL);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface NAFCJJMJIAP<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool HFLCFIIDHKA
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int OMHGCEOAIEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<TData> FLLOPPFCKEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData CKEIAGIGCJK);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData CKEIAGIGCJK);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface INABOCFHLNA<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T DBCLNEGBNLN, [Optional] LIGLMNBGNIO? CFHFANILNME, bool MLABEOJGHDF = true);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int KIFHGDECLNI, IEnumerable<T> NBJCMBDDGEE, bool MLABEOJGHDF = true);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int KIFHGDECLNI, IEnumerable<T> NBJCMBDDGEE, LIGLMNBGNIO CFHFANILNME, bool MLABEOJGHDF = true);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface LPMEHLIMJMJ
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface ECKLFCMPAGG
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool DMECFOIDKME
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool AJOOMHODHAP
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool DEMBPFBFDBB
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool ECEKBDEHFFB
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct BGFMBDCIEJG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public bool MDHDJCKNKEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public float? JFMEGKALLCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public float? EFFHDDBFPLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public float? FBLNOBCFLIG;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct GEDCIPKFEIH<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public IEnumerable<TData> KAHCMEPMEED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public BGFMBDCIEJG NNFEBEMODOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public bool BOKBLILDCBK;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4A53FB0", Offset = "0x4A531B0", VA = "0x184A53FB0")]
	public GEDCIPKFEIH(IEnumerable<TData> FOPOBHMOIDG, bool DOKLPKEAOLF, float? NGLEIKEDDJC, float? IKOPOIHFBKC, float? NFEJNNPNEMN, bool BOKBLILDCBK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface BMALEBGNKJC<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LKPFOCCLOAA([In] GEDCIPKFEIH<TData> EFGHMCKPMHN);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class LCNDFKKPOGD<TData> : KKGILOLFGKM<BMALEBGNKJC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly GEDCIPKFEIH<TData> EFGHMCKPMHN;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x50BE2B0", Offset = "0x50BD4B0", VA = "0x1850BE2B0")]
	public LCNDFKKPOGD(IEnumerable<TData> FOPOBHMOIDG, bool DOKLPKEAOLF, float? NGLEIKEDDJC, float? IKOPOIHFBKC, float? NFEJNNPNEMN, bool BOKBLILDCBK, BMALEBGNKJC<TData> IJKONPKDHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4539610", Offset = "0x4538810", VA = "0x184539610", Slot = "4")]
	public override bool LKPFOCCLOAA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct HDEIFNEABMN<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public IEnumerable<TData> KAHCMEPMEED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public string EOLKJMPOLOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public bool HJCMIHFKEJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public bool BOKBLILDCBK;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4B12070", Offset = "0x4B11270", VA = "0x184B12070")]
	public HDEIFNEABMN(IEnumerable<TData> FOPOBHMOIDG, string GGCHPOGNGCI, bool CDFOOMOHCIK, bool BOKBLILDCBK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface MHPLPLHGEMF<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LKPFOCCLOAA([In] HDEIFNEABMN<TData> EFGHMCKPMHN);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class LPFPKLIGIGD<TData> : KKGILOLFGKM<MHPLPLHGEMF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly HDEIFNEABMN<TData> EFGHMCKPMHN;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x50FEEE0", Offset = "0x50FE0E0", VA = "0x1850FEEE0")]
	public LPFPKLIGIGD(IEnumerable<TData> FOPOBHMOIDG, string GGCHPOGNGCI, bool CDFOOMOHCIK, bool BOKBLILDCBK, MHPLPLHGEMF<TData> IJKONPKDHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x4539610", Offset = "0x4538810", VA = "0x184539610", Slot = "4")]
	public override bool LKPFOCCLOAA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public abstract class KKGILOLFGKM<TReceiver> : FKHICOLHBLE<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4521740", Offset = "0x4520940", VA = "0x184521740")]
	public KKGILOLFGKM(TReceiver IJKONPKDHEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public abstract class NNGGDCOAAAI<TReceiver, TFromTask> : FKHICOLHBLE<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4521740", Offset = "0x4520940", VA = "0x184521740")]
	public NNGGDCOAAAI(TReceiver IJKONPKDHEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public abstract class FKHICOLHBLE<TReceiver, TFromExecute> where TReceiver : notnull where TFromExecute : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	protected TReceiver IJKONPKDHEA;

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x49AD900", Offset = "0x49ACB00", VA = "0x1849AD900")]
	public FKHICOLHBLE(TReceiver IJKONPKDHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute LKPFOCCLOAA();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class KPLGBJNGEPG<TReceiver, TResult> : FKHICOLHBLE<TReceiver, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4521740", Offset = "0x4520940", VA = "0x184521740")]
	public KPLGBJNGEPG(TReceiver IJKONPKDHEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct DFHBNHOKEOP<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public TGroup GCJPIHCJHGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public TData ECNEGBAAMOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public IEnumerable<TData> KAHCMEPMEED;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x21B1B00", Offset = "0x21B0D00", VA = "0x1821B1B00")]
	public DFHBNHOKEOP(TGroup FIJKEDAKHED, TData CLPENBNNHID, IEnumerable<TData> FOPOBHMOIDG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct MKIGHLOEONN<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public TGroup GCJPIHCJHGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public IEnumerable<TData> KAHCMEPMEED;

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0xAE1FD0", Offset = "0xAE11D0", VA = "0x180AE1FD0")]
	public MKIGHLOEONN(TGroup FIJKEDAKHED, IEnumerable<TData> FOPOBHMOIDG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct FDBEOJLMKMN<TGroup> where TGroup : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public TGroup GCJPIHCJHGM;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0xD42160", Offset = "0xD41360", VA = "0x180D42160")]
	public FDBEOJLMKMN(TGroup FIJKEDAKHED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct LGCKIIACCNH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public IEnumerable<Guid> KAHCMEPMEED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public Guid PJKMMIEHMOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public readonly bool DEBJLIDAIOA;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7CF17D0", Offset = "0x7CF09D0", VA = "0x187CF17D0")]
	public LGCKIIACCNH(IEnumerable<Guid> FOPOBHMOIDG, Guid NEHHMBCJKJC, bool BOKBLILDCBK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct GGOCGLGMDBG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public Guid PJKMMIEHMOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly bool DEBJLIDAIOA;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x25A2400", Offset = "0x25A1600", VA = "0x1825A2400")]
	public GGOCGLGMDBG(Guid NEHHMBCJKJC, bool BOKBLILDCBK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface HCJNAIHNIJP<TGroup, TData>
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MLGBCCCJIBB FHACDAHHHPJ(DFHBNHOKEOP<TGroup, TData> PNJDOEBPJHK);

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MLGBCCCJIBB KLBKJOKOMFB(DFHBNHOKEOP<TGroup, TData> PNJDOEBPJHK);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MLGBCCCJIBB MCOGCEJBPGE(MKIGHLOEONN<TGroup, TData> PNJDOEBPJHK);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MLGBCCCJIBB MFGACHPHIJB(FDBEOJLMKMN<TGroup> PNJDOEBPJHK);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface FAHENMHIDBI
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<MLGBCCCJIBB> FHACDAHHHPJ(LGCKIIACCNH PNJDOEBPJHK);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<MLGBCCCJIBB> KLBKJOKOMFB(GGOCGLGMDBG PNJDOEBPJHK);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class PLAJOOBBOCD<TGroup, TData> : KPLGBJNGEPG<HCJNAIHNIJP<TGroup, TData>, MLGBCCCJIBB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly MKIGHLOEONN<TGroup, TData> PNJDOEBPJHK;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5634C80", Offset = "0x5633E80", VA = "0x185634C80")]
	public PLAJOOBBOCD(TGroup FIJKEDAKHED, IEnumerable<TData> FOPOBHMOIDG, HCJNAIHNIJP<TGroup, TData> IJKONPKDHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x5634BB0", Offset = "0x5633DB0", VA = "0x185634BB0", Slot = "4")]
	public override MLGBCCCJIBB LKPFOCCLOAA()
	{
		return default(MLGBCCCJIBB);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class GMLKGAIGBLM<TGroup, TData> : KPLGBJNGEPG<HCJNAIHNIJP<TGroup, TData>, MLGBCCCJIBB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly DFHBNHOKEOP<TGroup, TData> PNJDOEBPJHK;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x4A997C0", Offset = "0x4A989C0", VA = "0x184A997C0")]
	public GMLKGAIGBLM(TGroup FIJKEDAKHED, TData OOMAAIANMGF, IEnumerable<TData> FOPOBHMOIDG, HCJNAIHNIJP<TGroup, TData> IJKONPKDHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x4A996F0", Offset = "0x4A988F0", VA = "0x184A996F0", Slot = "4")]
	public override MLGBCCCJIBB LKPFOCCLOAA()
	{
		return default(MLGBCCCJIBB);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class GIJLLLNJOJI<TGroup, TData> : KPLGBJNGEPG<HCJNAIHNIJP<TGroup, TData>, MLGBCCCJIBB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly FDBEOJLMKMN<TGroup> PNJDOEBPJHK;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x4A6F230", Offset = "0x4A6E430", VA = "0x184A6F230")]
	public GIJLLLNJOJI(TGroup FIJKEDAKHED, HCJNAIHNIJP<TGroup, TData> IJKONPKDHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x4A6F170", Offset = "0x4A6E370", VA = "0x184A6F170", Slot = "4")]
	public override MLGBCCCJIBB LKPFOCCLOAA()
	{
		return default(MLGBCCCJIBB);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class PLJNNKKOHJN<TGroup, TData> : KPLGBJNGEPG<HCJNAIHNIJP<TGroup, TData>, MLGBCCCJIBB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly DFHBNHOKEOP<TGroup, TData> PNJDOEBPJHK;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4A997C0", Offset = "0x4A989C0", VA = "0x184A997C0")]
	public PLJNNKKOHJN(TGroup FIJKEDAKHED, TData CLPENBNNHID, IEnumerable<TData> FOPOBHMOIDG, HCJNAIHNIJP<TGroup, TData> IJKONPKDHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5635F90", Offset = "0x5635190", VA = "0x185635F90", Slot = "4")]
	public override MLGBCCCJIBB LKPFOCCLOAA()
	{
		return default(MLGBCCCJIBB);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class IILEPDNKFLO : NNGGDCOAAAI<FAHENMHIDBI, MLGBCCCJIBB>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct DIBEDKOKEFO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public AsyncTaskMethodBuilder<MLGBCCCJIBB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public IILEPDNKFLO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private TaskAwaiter<MLGBCCCJIBB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7CF0C00", Offset = "0x7CEFE00", VA = "0x187CF0C00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7CF0E90", Offset = "0x7CF0090", VA = "0x187CF0E90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private LGCKIIACCNH PNJDOEBPJHK;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7CF1330", Offset = "0x7CF0530", VA = "0x187CF1330")]
	public IILEPDNKFLO(IEnumerable<Guid> ECJJPHPBKCM, Guid NEHHMBCJKJC, bool BOKBLILDCBK, FAHENMHIDBI IJKONPKDHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7CF1240", Offset = "0x7CF0440", VA = "0x187CF1240", Slot = "4")]
	[AsyncStateMachine(typeof(DIBEDKOKEFO))]
	public override Task<MLGBCCCJIBB> LKPFOCCLOAA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class NCELDOEBFIM : NNGGDCOAAAI<FAHENMHIDBI, MLGBCCCJIBB>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private struct APANIKEOHAL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public AsyncTaskMethodBuilder<MLGBCCCJIBB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public NCELDOEBFIM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private TaskAwaiter<MLGBCCCJIBB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7CF0530", Offset = "0x7CEF730", VA = "0x187CF0530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7CF07D0", Offset = "0x7CEF9D0", VA = "0x187CF07D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly GGOCGLGMDBG PNJDOEBPJHK;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7CF19D0", Offset = "0x7CF0BD0", VA = "0x187CF19D0")]
	public NCELDOEBFIM(Guid NEHHMBCJKJC, bool BOKBLILDCBK, FAHENMHIDBI IJKONPKDHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7CF18E0", Offset = "0x7CF0AE0", VA = "0x187CF18E0", Slot = "4")]
	[AsyncStateMachine(typeof(APANIKEOHAL))]
	public override Task<MLGBCCCJIBB> LKPFOCCLOAA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public readonly struct FKODICGAJIM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly JPCMKCCFLBC CHPEPDNJAGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly bool DEBJLIDAIOA;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7CF1210", Offset = "0x7CF0410", VA = "0x187CF1210")]
	public FKODICGAJIM(JPCMKCCFLBC OMHJAPKOGDI, bool BOKBLILDCBK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface OJNMJFCPMHA<TSpawnType> where TSpawnType : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> LKPFOCCLOAA(FKODICGAJIM LFGNMEICMDC);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class JLAAGMOCMHO<TSpawnType> : NNGGDCOAAAI<OJNMJFCPMHA<TSpawnType>, TSpawnType> where TSpawnType : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct IGEJHLHHEEB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public AsyncTaskMethodBuilder<TSpawnType> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public JLAAGMOCMHO<TSpawnType> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private TaskAwaiter<TSpawnType> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x4C811B0", Offset = "0x4C803B0", VA = "0x184C811B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x4545730", Offset = "0x4544930", VA = "0x184545730", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly FKODICGAJIM LFGNMEICMDC;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x4EFFB10", Offset = "0x4EFED10", VA = "0x184EFFB10")]
	public JLAAGMOCMHO(JPCMKCCFLBC OMHJAPKOGDI, bool BOKBLILDCBK, OJNMJFCPMHA<TSpawnType> IJKONPKDHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x4EFF910", Offset = "0x4EFEB10", VA = "0x184EFF910", Slot = "4")]
	[AsyncStateMachine(typeof(JLAAGMOCMHO<>.IGEJHLHHEEB))]
	public override Task<TSpawnType> LKPFOCCLOAA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct JPCMKCCFLBC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public readonly bool NBCGMFHPOII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly Vector3 INPOALGOLAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly Vector3 PHGICKGLDGM;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7CF14A0", Offset = "0x7CF06A0", VA = "0x187CF14A0")]
	public JPCMKCCFLBC(Transform CMFFJIHPBMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7CF1510", Offset = "0x7CF0710", VA = "0x187CF1510")]
	public JPCMKCCFLBC(Vector3 PLEIILPBIGD, Vector3 BJHAAAPCKLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7CF13F0", Offset = "0x7CF05F0", VA = "0x187CF13F0")]
	public static JPCMKCCFLBC GIAPJGILOPE()
	{
		return default(JPCMKCCFLBC);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7CF1420", Offset = "0x7CF0620", VA = "0x187CF1420")]
	private JPCMKCCFLBC(bool LECPGGDPOBF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct CHICEJFMLPD<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public TNode OOAPLNGFIOP;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x65405A0", Offset = "0x653F7A0", VA = "0x1865405A0")]
	public CHICEJFMLPD(TNode OOAPLNGFIOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct OAELAMEFCFD<TNode, TReparentOperations> where TNode : notnull where TReparentOperations : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public TNode OGMKKHDIIMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public TReparentOperations KKPKKEJNMII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public ADIIJIMJPGJ PLLMAFFBFLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly bool DEBJLIDAIOA;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x54B5AF0", Offset = "0x54B4CF0", VA = "0x1854B5AF0")]
	public OAELAMEFCFD(TNode OGMKKHDIIMP, TReparentOperations KKPKKEJNMII, ADIIJIMJPGJ PLLMAFFBFLG, bool BOKBLILDCBK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface JANHOMMIBOL<TNode, TReparentOperations>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool POHHBJBEPBG([In] CHICEJFMLPD<TNode> CKPAHPOIEMD);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JKAOFPKJBBB([In] OAELAMEFCFD<TNode, TReparentOperations> BJHFJKCHNBP);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LNAAEBBGAJG();
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class FODDJFLGALK<TNode, TReparentOperations> : KKGILOLFGKM<JANHOMMIBOL<TNode, TReparentOperations>>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x4521740", Offset = "0x4520940", VA = "0x184521740")]
	public FODDJFLGALK(JANHOMMIBOL<TNode, TReparentOperations> IJKONPKDHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x45216F0", Offset = "0x45208F0", VA = "0x1845216F0", Slot = "4")]
	public override bool LKPFOCCLOAA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class IGOCCGINPOM<TNode, TReparentOperations> : KKGILOLFGKM<JANHOMMIBOL<TNode, TReparentOperations>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly OAELAMEFCFD<TNode, TReparentOperations> BJHFJKCHNBP;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x4C81CD0", Offset = "0x4C80ED0", VA = "0x184C81CD0")]
	public IGOCCGINPOM(TNode OGMKKHDIIMP, TReparentOperations KKPKKEJNMII, ADIIJIMJPGJ PLLMAFFBFLG, JANHOMMIBOL<TNode, TReparentOperations> IJKONPKDHEA, bool BOKBLILDCBK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x45445C0", Offset = "0x45437C0", VA = "0x1845445C0", Slot = "4")]
	public override bool LKPFOCCLOAA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class ICLLNFBLIMJ<TNode, TReparentOperations> : KKGILOLFGKM<JANHOMMIBOL<TNode, TReparentOperations>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly CHICEJFMLPD<TNode> CKPAHPOIEMD;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x4C6F7F0", Offset = "0x4C6E9F0", VA = "0x184C6F7F0")]
	public ICLLNFBLIMJ(TNode GLAKDMCNDAA, JANHOMMIBOL<TNode, TReparentOperations> IJKONPKDHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x4539610", Offset = "0x4538810", VA = "0x184539610", Slot = "4")]
	public override bool LKPFOCCLOAA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct MNFIHDKBLOO<TSpawnInfo> where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public TSpawnInfo DNNCHJBLOJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public Vector3 BJHAAAPCKLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public Quaternion PANMBKPFLFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public float MMIJFAFPOOH;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5327380", Offset = "0x5326580", VA = "0x185327380")]
	public MNFIHDKBLOO(TSpawnInfo DNNCHJBLOJM, Vector3 BJHAAAPCKLC, Quaternion PANMBKPFLFA, float MMIJFAFPOOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface BFDLJBOFICB<TSpawnType, TSpawnInfo>
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> HELPGNOGPIG([In] MNFIHDKBLOO<TSpawnInfo> DIBPAMMOFOC, CancellationToken HCELDNOKOAM);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class OJBAFAEELHD<TSpawnType, TSpawnInfo> : NNGGDCOAAAI<BFDLJBOFICB<TSpawnType, TSpawnInfo>, TSpawnType> where TSpawnType : notnull where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly MNFIHDKBLOO<TSpawnInfo> EFGHMCKPMHN;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x55371B0", Offset = "0x55363B0", VA = "0x1855371B0")]
	public OJBAFAEELHD(TSpawnInfo OLGOIALKHAC, Vector3 BJHAAAPCKLC, Quaternion PANMBKPFLFA, float MMIJFAFPOOH, BFDLJBOFICB<TSpawnType, TSpawnInfo> IJKONPKDHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5004730", Offset = "0x5003930", VA = "0x185004730", Slot = "4")]
	public override Task<TSpawnType> LKPFOCCLOAA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public readonly struct BFNLIAFCHHO<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly IEnumerable<TData> KAHCMEPMEED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly bool DEBJLIDAIOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly bool LLDFCACKJIO;

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5E84E80", Offset = "0x5E84080", VA = "0x185E84E80")]
	public BFNLIAFCHHO(IEnumerable<TData> FOPOBHMOIDG, bool BOKBLILDCBK = false, bool FLDNPDCAFBE = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface KPFJBFJOJBJ<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<MLGBCCCJIBB> OFEACHLHGOM([In] BFNLIAFCHHO<TData> DMAHEEHKDHN, CancellationToken HCELDNOKOAM);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class KFJAMGAFIEJ<TData> : NNGGDCOAAAI<KPFJBFJOJBJ<TData>, MLGBCCCJIBB> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly BFNLIAFCHHO<TData> ELEEONEKOEG;

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x50048C0", Offset = "0x5003AC0", VA = "0x1850048C0")]
	public KFJAMGAFIEJ(IEnumerable<TData> FOPOBHMOIDG, bool BOKBLILDCBK, KPFJBFJOJBJ<TData> IJKONPKDHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5004730", Offset = "0x5003930", VA = "0x185004730", Slot = "4")]
	public override Task<MLGBCCCJIBB> LKPFOCCLOAA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct OHFMDLFPOMO<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly T PJNHLGGHCLG;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x52C89D0", Offset = "0x52C7BD0", VA = "0x1852C89D0")]
	public OHFMDLFPOMO(T KEONCEGLGGL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface BLEELJHNOLN<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool POHHBJBEPBG([In] OHFMDLFPOMO<T> NOJDHDBFMIK);

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JKAOFPKJBBB();
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface OFMELBNAGPD<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LKPFOCCLOAA([In] PIIIGPMMBBO<T> LMFDCAMLKNK);
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public struct PIIIGPMMBBO<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly T PJNHLGGHCLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly bool IFAGCFKFOFB;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x562B750", Offset = "0x562A950", VA = "0x18562B750")]
	public PIIIGPMMBBO(T KEONCEGLGGL, bool MJIOFONEBCE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public class FPEFJKBKEIP<T> : KKGILOLFGKM<BLEELJHNOLN<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x4521740", Offset = "0x4520940", VA = "0x184521740")]
	public FPEFJKBKEIP(BLEELJHNOLN<T> IJKONPKDHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x49B43D0", Offset = "0x49B35D0", VA = "0x1849B43D0", Slot = "4")]
	public override bool LKPFOCCLOAA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class HJCDNPHIJGD<T> : KKGILOLFGKM<BLEELJHNOLN<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly OHFMDLFPOMO<T> NOJDHDBFMIK;

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x4B9A080", Offset = "0x4B99280", VA = "0x184B9A080")]
	public HJCDNPHIJGD(T PJNHLGGHCLG, BLEELJHNOLN<T> IJKONPKDHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x4539610", Offset = "0x4538810", VA = "0x184539610", Slot = "4")]
	public override bool LKPFOCCLOAA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class GIMGNJLJAGH<T> : KKGILOLFGKM<OFMELBNAGPD<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly PIIIGPMMBBO<T> LMFDCAMLKNK;

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x4A6F370", Offset = "0x4A6E570", VA = "0x184A6F370")]
	public GIMGNJLJAGH(T PJNHLGGHCLG, bool MJIOFONEBCE, OFMELBNAGPD<T> IJKONPKDHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x4539610", Offset = "0x4538810", VA = "0x184539610", Slot = "4")]
	public override bool LKPFOCCLOAA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public struct BECOKLDEPHJ<TData> where TData : notnull, JNAKOIAIFBO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public IEnumerable<TData> KAHCMEPMEED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public bool KOIMFBEDPGP;

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5E7E950", Offset = "0x5E7DB50", VA = "0x185E7E950")]
	public BECOKLDEPHJ(IEnumerable<TData> KNBHEMBJLAL, bool BBNFOLAEDNK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public struct GFEOAMGCHJG<TData> where TData : notnull, JNAKOIAIFBO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public List<TData> KAHCMEPMEED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public List<bool> BOKFOMNONMO;

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x4A59100", Offset = "0x4A58300", VA = "0x184A59100")]
	public GFEOAMGCHJG(List<TData> KNBHEMBJLAL, List<bool> IHLFOFNKKKP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface JNAKOIAIFBO
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool MOLMFLNHFDM
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
public interface IPNMLLFAKIB<TData> where TData : JNAKOIAIFBO
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LKPFOCCLOAA([In] BECOKLDEPHJ<TData> NDJBPBHPGDG);

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LKPFOCCLOAA([In] GFEOAMGCHJG<TData> NDJBPBHPGDG);
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface PLMIMEJJIKH<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BNHCKHDJAGM(T PJNHLGGHCLG);
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class DAGCFJBOKNE<TData> : KKGILOLFGKM<IPNMLLFAKIB<TData>> where TData : notnull, JNAKOIAIFBO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly BECOKLDEPHJ<TData> NDJBPBHPGDG;

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x69C6BB0", Offset = "0x69C5DB0", VA = "0x1869C6BB0")]
	public DAGCFJBOKNE(List<TData> FOPOBHMOIDG, bool KOIMFBEDPGP, IPNMLLFAKIB<TData> IJKONPKDHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x4539610", Offset = "0x4538810", VA = "0x184539610", Slot = "4")]
	public override bool LKPFOCCLOAA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class OHLNENJKEKI<TData> : KKGILOLFGKM<IPNMLLFAKIB<TData>> where TData : notnull, JNAKOIAIFBO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly GFEOAMGCHJG<TData> NDJBPBHPGDG;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5535010", Offset = "0x5534210", VA = "0x185535010")]
	public OHLNENJKEKI(List<TData> FOPOBHMOIDG, List<bool> BOKFOMNONMO, IPNMLLFAKIB<TData> IJKONPKDHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x49ADA20", Offset = "0x49ACC20", VA = "0x1849ADA20", Slot = "4")]
	public override bool LKPFOCCLOAA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public interface CAOHAGJHKOL<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<MLGBCCCJIBB> LKPFOCCLOAA(DGIEMOKAIOG<TData> PKPCGNJCCFM);
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public class HPJCLPIPIND<TData> : NNGGDCOAAAI<CAOHAGJHKOL<TData>, MLGBCCCJIBB> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private struct MGEGILBBCJN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public AsyncTaskMethodBuilder<MLGBCCCJIBB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public HPJCLPIPIND<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private TaskAwaiter<MLGBCCCJIBB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x52DC5E0", Offset = "0x52DB7E0", VA = "0x1852DC5E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x52DC8C0", Offset = "0x52DBAC0", VA = "0x1852DC8C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly DGIEMOKAIOG<TData> DLMACHOALGN;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4BBA440", Offset = "0x4BB9640", VA = "0x184BBA440")]
	public HPJCLPIPIND(TData NLCCIIGNKEM, IReadOnlyList<TData> DLGGIMJENLF, bool BOKBLILDCBK, CAOHAGJHKOL<TData> IJKONPKDHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x4BBA340", Offset = "0x4BB9540", VA = "0x184BBA340", Slot = "4")]
	[AsyncStateMachine(typeof(HPJCLPIPIND<>.MGEGILBBCJN))]
	public override Task<MLGBCCCJIBB> LKPFOCCLOAA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public struct DGIEMOKAIOG<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public TData MHLKBLPPDJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public IReadOnlyList<TData> ODJCHFNIGAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public bool DEBJLIDAIOA;

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2CC3100", Offset = "0x2CC2300", VA = "0x182CC3100")]
	public DGIEMOKAIOG(TData NLCCIIGNKEM, IReadOnlyList<TData> DLGGIMJENLF, bool BOKBLILDCBK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface JIKOJNAIABE<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LKPFOCCLOAA([In] OFPOJBAIJDP<TData> KNAAGGBODHO);
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public interface OAGCGNHNAOA<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LKPFOCCLOAA([In] OBAGGKMHAGD<TData> KNAAGGBODHO);
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public interface DGHLFJKJPOG<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OODDLKANNKM([In] IBDGIHFHGEK<TData> KNAAGGBODHO);

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JKAOFPKJBBB();
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class NJGKLOMOGPF<TData> : KKGILOLFGKM<JIKOJNAIABE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly OFPOJBAIJDP<TData> KNAAGGBODHO;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x539B690", Offset = "0x539A890", VA = "0x18539B690")]
	public NJGKLOMOGPF(IEnumerable<TData> FOPOBHMOIDG, EPEJMPHDPHB EKKMKLFENBL, KBHAGNPMANG OHHEKLKCMJA, float FFHLABDMDPM, string? GGCHPOGNGCI, bool BFAFIHHNLJM, bool BOKBLILDCBK, JIKOJNAIABE<TData> IJKONPKDHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x4539610", Offset = "0x4538810", VA = "0x184539610", Slot = "4")]
	public override bool LKPFOCCLOAA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class DECCOKMMFGB<TData> : KKGILOLFGKM<OAGCGNHNAOA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly OBAGGKMHAGD<TData> KNAAGGBODHO;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6A17D00", Offset = "0x6A16F00", VA = "0x186A17D00")]
	public DECCOKMMFGB(TData[] FOPOBHMOIDG, EPEJMPHDPHB[] EKKMKLFENBL, KBHAGNPMANG[] OHHEKLKCMJA, float[] FFHLABDMDPM, OAGCGNHNAOA<TData> IJKONPKDHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x49B4640", Offset = "0x49B3840", VA = "0x1849B4640", Slot = "4")]
	public override bool LKPFOCCLOAA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class OJKNOABCOOM<TData> : KKGILOLFGKM<DGHLFJKJPOG<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x4521740", Offset = "0x4520940", VA = "0x184521740")]
	public OJKNOABCOOM(DGHLFJKJPOG<TData> IJKONPKDHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x55388B0", Offset = "0x5537AB0", VA = "0x1855388B0", Slot = "4")]
	public override bool LKPFOCCLOAA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class FPMJBMPAMHG<TData> : KKGILOLFGKM<DGHLFJKJPOG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly IBDGIHFHGEK<TData> KNAAGGBODHO;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x49B4700", Offset = "0x49B3900", VA = "0x1849B4700")]
	public FPMJBMPAMHG(IEnumerable<TData> FOPOBHMOIDG, EPEJMPHDPHB EKKMKLFENBL, KBHAGNPMANG OHHEKLKCMJA, float FFHLABDMDPM, DGHLFJKJPOG<TData> IJKONPKDHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x49B4640", Offset = "0x49B3840", VA = "0x1849B4640", Slot = "4")]
	public override bool LKPFOCCLOAA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public struct OFPOJBAIJDP<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public IEnumerable<TData> KAHCMEPMEED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public EPEJMPHDPHB NLNHPPFMCIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public KBHAGNPMANG HKJLLEFIMBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public float BFACDLAHFBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public string? EOLKJMPOLOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public bool? CPCCOIKPBFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public bool DEBJLIDAIOA;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x5533670", Offset = "0x5532870", VA = "0x185533670")]
	public OFPOJBAIJDP(IEnumerable<TData> FOPOBHMOIDG, EPEJMPHDPHB EKKMKLFENBL, KBHAGNPMANG OHHEKLKCMJA, float FFHLABDMDPM, string? GGCHPOGNGCI, bool? BFAFIHHNLJM, bool BOKBLILDCBK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public struct OBAGGKMHAGD<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public TData[] KAHCMEPMEED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public EPEJMPHDPHB[] NLNHPPFMCIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public KBHAGNPMANG[] HKJLLEFIMBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public float[] FFHLABDMDPM;

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x54BD040", Offset = "0x54BC240", VA = "0x1854BD040")]
	public OBAGGKMHAGD(TData[] FOPOBHMOIDG, EPEJMPHDPHB[] EKKMKLFENBL, KBHAGNPMANG[] OHHEKLKCMJA, float[] FFHLABDMDPM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public struct IBDGIHFHGEK<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public IEnumerable<TData> KAHCMEPMEED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public EPEJMPHDPHB NLNHPPFMCIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public KBHAGNPMANG HKJLLEFIMBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public float FFHLABDMDPM;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x4C6D6D0", Offset = "0x4C6C8D0", VA = "0x184C6D6D0")]
	public IBDGIHFHGEK(IEnumerable<TData> FOPOBHMOIDG, EPEJMPHDPHB EKKMKLFENBL, KBHAGNPMANG OHHEKLKCMJA, float FFHLABDMDPM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public interface CFCCALDKEBP<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MCOGCEJBPGE([In] OLMIMPNOAFD<TData> DMAHEEHKDHN);

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MFGACHPHIJB([In] OLMIMPNOAFD<TData> DMAHEEHKDHN);

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ICGAKFCKAHL([In] bool DADAPLNKNMC);

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool GBJONLMPJGK([In] OLMIMPNOAFD<TData> DMAHEEHKDHN);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OMBMDALKCNL();

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool KIFBEJLHCLF([In] TData DPKKKJOJFBA);
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class GADGDGCNDIG<TData> : KKGILOLFGKM<CFCCALDKEBP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly OLMIMPNOAFD<TData> DMAHEEHKDHN;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x4A4B2E0", Offset = "0x4A4A4E0", VA = "0x184A4B2E0")]
	public GADGDGCNDIG(List<TData> FOLAIIIFFFP, CFCCALDKEBP<TData> IJKONPKDHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x4539610", Offset = "0x4538810", VA = "0x184539610", Slot = "4")]
	public override bool LKPFOCCLOAA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class DBDIABHJNEI<TData> : KKGILOLFGKM<CFCCALDKEBP<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4521740", Offset = "0x4520940", VA = "0x184521740")]
	public DBDIABHJNEI(CFCCALDKEBP<TData> IJKONPKDHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x69CE530", Offset = "0x69CD730", VA = "0x1869CE530", Slot = "4")]
	public override bool LKPFOCCLOAA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class KELGNHPBKHK<TData> : KKGILOLFGKM<CFCCALDKEBP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly bool BOKBLILDCBK;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x50014C0", Offset = "0x50006C0", VA = "0x1850014C0")]
	public KELGNHPBKHK(bool BOKBLILDCBK, CFCCALDKEBP<TData> IJKONPKDHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x5001460", Offset = "0x5000660", VA = "0x185001460", Slot = "4")]
	public override bool LKPFOCCLOAA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class FKNPMAFOKIL<TData> : KKGILOLFGKM<CFCCALDKEBP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly OLMIMPNOAFD<TData> DMAHEEHKDHN;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x49ADAE0", Offset = "0x49ACCE0", VA = "0x1849ADAE0")]
	public FKNPMAFOKIL(List<TData> FOLAIIIFFFP, bool BOKBLILDCBK, CFCCALDKEBP<TData> IJKONPKDHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x49ADA20", Offset = "0x49ACC20", VA = "0x1849ADA20", Slot = "4")]
	public override bool LKPFOCCLOAA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class CKGHBDIGAEE<TData> : KKGILOLFGKM<CFCCALDKEBP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly TData DPKKKJOJFBA;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x65504F0", Offset = "0x654F6F0", VA = "0x1865504F0")]
	public CKGHBDIGAEE(TData DPKKKJOJFBA, CFCCALDKEBP<TData> IJKONPKDHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6550370", Offset = "0x654F570", VA = "0x186550370", Slot = "4")]
	public override bool LKPFOCCLOAA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class HOJJJOHEIBJ<TData> : KKGILOLFGKM<CFCCALDKEBP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly OLMIMPNOAFD<TData> DMAHEEHKDHN;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x4BBA1E0", Offset = "0x4BB93E0", VA = "0x184BBA1E0")]
	public HOJJJOHEIBJ(IEnumerable<TData> FOLAIIIFFFP, CFCCALDKEBP<TData> IJKONPKDHEA, bool BOKBLILDCBK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x4BBA120", Offset = "0x4BB9320", VA = "0x184BBA120", Slot = "4")]
	public override bool LKPFOCCLOAA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public struct OLMIMPNOAFD<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public IEnumerable<TData> KAHCMEPMEED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public bool BOKBLILDCBK;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x5539DD0", Offset = "0x5538FD0", VA = "0x185539DD0")]
	public OLMIMPNOAFD(IEnumerable<TData> KNBHEMBJLAL, bool JBMPPFPGMDA = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public interface JEDLIMKHGLE
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<MLGBCCCJIBB> LKPFOCCLOAA(DBNAJNKHEGJ FLIHOPKDBAF);
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class CFCDAEOHEKE : NNGGDCOAAAI<JEDLIMKHGLE, MLGBCCCJIBB>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private struct EHNIMLDDAMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public AsyncTaskMethodBuilder<MLGBCCCJIBB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public CFCDAEOHEKE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private TaskAwaiter<MLGBCCCJIBB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x7CF0F20", Offset = "0x7CF0120", VA = "0x187CF0F20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7CF11A0", Offset = "0x7CF03A0", VA = "0x187CF11A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly DBNAJNKHEGJ MIGFCHHGDII;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x7CF0BA0", Offset = "0x7CEFDA0", VA = "0x187CF0BA0")]
	public CFCDAEOHEKE(bool BOKBLILDCBK, JEDLIMKHGLE IJKONPKDHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x7CF0AB0", Offset = "0x7CEFCB0", VA = "0x187CF0AB0", Slot = "4")]
	[AsyncStateMachine(typeof(EHNIMLDDAMI))]
	public override Task<MLGBCCCJIBB> LKPFOCCLOAA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public struct DBNAJNKHEGJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public bool DEBJLIDAIOA;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x29E56C0", Offset = "0x29E48C0", VA = "0x1829E56C0")]
	public DBNAJNKHEGJ(bool BOKBLILDCBK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public readonly struct GFPHMHNKELK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public readonly bool OHBKFMOLENA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public readonly bool NNIOKAIEOGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public readonly bool MMIJFAFPOOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public readonly bool BOKBLILDCBK;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5C8C2C0", Offset = "0x5C8B4C0", VA = "0x185C8C2C0")]
	public GFPHMHNKELK(bool OHBKFMOLENA, bool NNIOKAIEOGL, bool MMIJFAFPOOH, bool BOKBLILDCBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7CF1230", Offset = "0x7CF0430", VA = "0x187CF1230")]
	public GFPHMHNKELK(bool NNIOKAIEOGL, bool BOKBLILDCBK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public interface PMEGMLBMEKK
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LBMBIBOEHKA(GFPHMHNKELK FEMILCLACCI);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FNFIGIGFMJM(GFPHMHNKELK FEMILCLACCI);
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class ALGJIENAIMD : KKGILOLFGKM<PMEGMLBMEKK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly GFPHMHNKELK FEMILCLACCI;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7CF04A0", Offset = "0x7CEF6A0", VA = "0x187CF04A0")]
	public ALGJIENAIMD(bool PMPOHKBNMIB, bool NNIOKAIEOGL, bool MMIJFAFPOOH, bool BOKBLILDCBK, PMEGMLBMEKK IJKONPKDHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x7CF0450", Offset = "0x7CEF650", VA = "0x187CF0450", Slot = "4")]
	public override bool LKPFOCCLOAA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public class MBMOADAGAHJ : KKGILOLFGKM<PMEGMLBMEKK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private readonly GFPHMHNKELK FEMILCLACCI;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7CF1860", Offset = "0x7CF0A60", VA = "0x187CF1860")]
	public MBMOADAGAHJ(bool NNIOKAIEOGL, bool BOKBLILDCBK, PMEGMLBMEKK IJKONPKDHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x7CF1810", Offset = "0x7CF0A10", VA = "0x187CF1810", Slot = "4")]
	public override bool LKPFOCCLOAA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public interface FILJBLHKDNP
{
	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LKPFOCCLOAA([In] OMPBLMPNOHI KKJLOCMOIDI);
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class KKELCIJAOHJ : KKGILOLFGKM<FILJBLHKDNP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private readonly OMPBLMPNOHI KKJLOCMOIDI;

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x7CF15F0", Offset = "0x7CF07F0", VA = "0x187CF15F0")]
	public KKELCIJAOHJ(Guid[] JKFPOHPIFFB, Vector3[] BFDJINHBJLF, Quaternion[] DGDFKMKPLGB, float[] HHGMMPNGPFG, Dictionary<Guid, Vector3> NBBHNNIGFFN, FILJBLHKDNP IJKONPKDHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7CF1540", Offset = "0x7CF0740", VA = "0x187CF1540", Slot = "4")]
	public override bool LKPFOCCLOAA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public interface GPIFADEOJDI<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool POHHBJBEPBG([In] AGBOBAMDHHL<TData> CKPAHPOIEMD);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OODDLKANNKM([In] EAFMONAECJM LIMCMBIBGHD);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool OODDLKANNKM([In] OAAGIGIGHAI LIMCMBIBGHD);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JKAOFPKJBBB();
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class DOLFLPNGJJA<TData> : KKGILOLFGKM<GPIFADEOJDI<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x4521740", Offset = "0x4520940", VA = "0x184521740")]
	public DOLFLPNGJJA(GPIFADEOJDI<TData> IJKONPKDHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x6A2E880", Offset = "0x6A2DA80", VA = "0x186A2E880", Slot = "4")]
	public override bool LKPFOCCLOAA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class KOCJAHEMHPO<TData> : KKGILOLFGKM<GPIFADEOJDI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly EAFMONAECJM APLLEDMEPCK;

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x5024260", Offset = "0x5023460", VA = "0x185024260")]
	public KOCJAHEMHPO(Vector3 KDILABEDEJF, bool CDGCJBPOJLO, GPIFADEOJDI<TData> IJKONPKDHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x4545820", Offset = "0x4544A20", VA = "0x184545820", Slot = "4")]
	public override bool LKPFOCCLOAA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class AAMOPMFGLLD<TData> : KKGILOLFGKM<GPIFADEOJDI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly OAAGIGIGHAI APLLEDMEPCK;

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x4A240F0", Offset = "0x4A232F0", VA = "0x184A240F0")]
	public AAMOPMFGLLD(Guid FFJOBAIECJC, int NIBICIJAIGM, Vector3 BJHAAAPCKLC, Quaternion PANMBKPFLFA, float IHBIKJPLAHJ, bool CDGCJBPOJLO, GPIFADEOJDI<TData> IJKONPKDHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x4A24090", Offset = "0x4A23290", VA = "0x184A24090", Slot = "4")]
	public override bool LKPFOCCLOAA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public class NHELAOCILNE<TData> : KKGILOLFGKM<GPIFADEOJDI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly AGBOBAMDHHL<TData> APLLEDMEPCK;

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x538D5C0", Offset = "0x538C7C0", VA = "0x18538D5C0")]
	public NHELAOCILNE(TData PJNHLGGHCLG, bool BOKBLILDCBK, GPIFADEOJDI<TData> IJKONPKDHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x4539610", Offset = "0x4538810", VA = "0x184539610", Slot = "4")]
	public override bool LKPFOCCLOAA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct EAFMONAECJM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public readonly Vector3 KDILABEDEJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public readonly bool CDGCJBPOJLO;

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7CF0F00", Offset = "0x7CF0100", VA = "0x187CF0F00")]
	public EAFMONAECJM(Vector3 KDILABEDEJF, bool CDGCJBPOJLO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct OAAGIGIGHAI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public readonly Guid FFJOBAIECJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public readonly int NIBICIJAIGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public readonly Vector3 BJHAAAPCKLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public readonly Quaternion PANMBKPFLFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public readonly float IHBIKJPLAHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public readonly bool CDGCJBPOJLO;

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7CF1E80", Offset = "0x7CF1080", VA = "0x187CF1E80")]
	public OAAGIGIGHAI(Guid FFJOBAIECJC, int NIBICIJAIGM, Vector3 BJHAAAPCKLC, Quaternion PANMBKPFLFA, float IHBIKJPLAHJ, bool CDGCJBPOJLO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct AGBOBAMDHHL<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public readonly TData PJNHLGGHCLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public readonly bool BOKBLILDCBK;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x4A86CA0", Offset = "0x4A85EA0", VA = "0x184A86CA0")]
	public AGBOBAMDHHL(TData PJNHLGGHCLG, bool BOKBLILDCBK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public interface CIFJJMIMBNF<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LKPFOCCLOAA([In] EJLHOHGKKLJ<TData> GKAMMHJEENO);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LKPFOCCLOAA([In] COEIEGDEBHC<TData> GKAMMHJEENO);
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public interface FDOPOHNJJGD<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool POHHBJBEPBG([In] BLKHLGJPMDO<TData> FAFCKDMIHLO);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OODDLKANNKM([In] NLMHEPIIDOP LIMCMBIBGHD);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JKAOFPKJBBB();
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public class EKFGICHGCFM<TData> : KKGILOLFGKM<CIFJJMIMBNF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly EJLHOHGKKLJ<TData> GKAMMHJEENO;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x45396D0", Offset = "0x45388D0", VA = "0x1845396D0")]
	public EKFGICHGCFM(IEnumerable<TData> FOPOBHMOIDG, Vector3 LPDJIOCKEMA, bool BOKBLILDCBK, CIFJJMIMBNF<TData> IJKONPKDHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x4539610", Offset = "0x4538810", VA = "0x184539610", Slot = "4")]
	public override bool LKPFOCCLOAA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class EBEDJMBBGLI<TData> : KKGILOLFGKM<FDOPOHNJJGD<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x4521740", Offset = "0x4520940", VA = "0x184521740")]
	public EBEDJMBBGLI(FDOPOHNJJGD<TData> IJKONPKDHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x45216F0", Offset = "0x45208F0", VA = "0x1845216F0", Slot = "4")]
	public override bool LKPFOCCLOAA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public class MHAEDBKGMMA<TData> : KKGILOLFGKM<FDOPOHNJJGD<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly BLKHLGJPMDO<TData> GKAMMHJEENO;

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x52DE2C0", Offset = "0x52DD4C0", VA = "0x1852DE2C0")]
	public MHAEDBKGMMA(IEnumerable<TData> FOPOBHMOIDG, bool BOKBLILDCBK, FDOPOHNJJGD<TData> IJKONPKDHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x4539610", Offset = "0x4538810", VA = "0x184539610", Slot = "4")]
	public override bool LKPFOCCLOAA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public class ENLPCEPEMIE<TData> : KKGILOLFGKM<CIFJJMIMBNF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly COEIEGDEBHC<TData> GKAMMHJEENO;

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x4544680", Offset = "0x4543880", VA = "0x184544680")]
	public ENLPCEPEMIE(IEnumerable<TData> FOPOBHMOIDG, Vector3 ENBBGKGICCB, FGLNDEAJFFC GHABPJMFNID, bool BOKBLILDCBK, CIFJJMIMBNF<TData> IJKONPKDHEA, Space GGMBBKFGNFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x45445C0", Offset = "0x45437C0", VA = "0x1845445C0", Slot = "4")]
	public override bool LKPFOCCLOAA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class EODPLDABAEN<TData> : KKGILOLFGKM<FDOPOHNJJGD<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly NLMHEPIIDOP GKAMMHJEENO;

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x4545880", Offset = "0x4544A80", VA = "0x184545880")]
	public EODPLDABAEN(Vector3 LPDJIOCKEMA, FDOPOHNJJGD<TData> IJKONPKDHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x4545820", Offset = "0x4544A20", VA = "0x184545820", Slot = "4")]
	public override bool LKPFOCCLOAA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public struct EJLHOHGKKLJ<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public readonly IEnumerable<TData> FOPOBHMOIDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public readonly Vector3 LPDJIOCKEMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly bool BOKBLILDCBK;

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x4538B10", Offset = "0x4537D10", VA = "0x184538B10")]
	public EJLHOHGKKLJ(IEnumerable<TData> FOPOBHMOIDG, Vector3 LPDJIOCKEMA, bool BOKBLILDCBK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct BLKHLGJPMDO<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public readonly IEnumerable<TData> FOPOBHMOIDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public readonly bool BOKBLILDCBK;

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x605D580", Offset = "0x605C780", VA = "0x18605D580")]
	public BLKHLGJPMDO(IEnumerable<TData> FOPOBHMOIDG, bool BOKBLILDCBK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public struct COEIEGDEBHC<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public readonly IEnumerable<TData> FOPOBHMOIDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public readonly Vector3 ENBBGKGICCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public readonly FGLNDEAJFFC GHABPJMFNID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public readonly bool BOKBLILDCBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public readonly Space GGMBBKFGNFP;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x663CA30", Offset = "0x663BC30", VA = "0x18663CA30")]
	public COEIEGDEBHC(IEnumerable<TData> FOPOBHMOIDG, Vector3 ENBBGKGICCB, FGLNDEAJFFC GHABPJMFNID, bool BOKBLILDCBK, Space GGMBBKFGNFP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public struct NLMHEPIIDOP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public readonly Vector3 LPDJIOCKEMA;

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0xECBC20", Offset = "0xECAE20", VA = "0x180ECBC20")]
	public NLMHEPIIDOP(Vector3 LPDJIOCKEMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public enum FGLNDEAJFFC
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
public interface CKJJJDCJEAE
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LKPFOCCLOAA([In] OMIKDCNIKGG KIOFKCIPOLC);
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public class ACOHPCJBDJI : KKGILOLFGKM<CKJJJDCJEAE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly OMIKDCNIKGG KIOFKCIPOLC;

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x7CF03F0", Offset = "0x7CEF5F0", VA = "0x187CF03F0")]
	public ACOHPCJBDJI(bool BOKBLILDCBK, CKJJJDCJEAE IJKONPKDHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x7CF0340", Offset = "0x7CEF540", VA = "0x187CF0340", Slot = "4")]
	public override bool LKPFOCCLOAA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public readonly struct OMIKDCNIKGG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public readonly bool BOKBLILDCBK;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x29E56C0", Offset = "0x29E48C0", VA = "0x1829E56C0")]
	public OMIKDCNIKGG(bool BOKBLILDCBK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public interface NAGMMGHPBIM<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LKPFOCCLOAA([In] CKIJJGIJBIF<TData> NPJFKOFDPAH);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LKPFOCCLOAA([In] NIICLADNEBP<TData> NPJFKOFDPAH);
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public interface BNJJBPACLMJ<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool POHHBJBEPBG([In] FCBFNHJCFPP<TData> CKPAHPOIEMD);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OODDLKANNKM([In] GDHCGFACFGK LIMCMBIBGHD);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JKAOFPKJBBB();
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public class OFCKEBBEJJG<TData> : KKGILOLFGKM<NAGMMGHPBIM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly CKIJJGIJBIF<TData> NPJFKOFDPAH;

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x54CA730", Offset = "0x54C9930", VA = "0x1854CA730")]
	public OFCKEBBEJJG(IEnumerable<TData> FOPOBHMOIDG, Quaternion LPDJIOCKEMA, Vector3? ANCLADHNABJ, bool INKCIJGGMEN, bool BOKBLILDCBK, NAGMMGHPBIM<TData> IJKONPKDHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x4539610", Offset = "0x4538810", VA = "0x184539610", Slot = "4")]
	public override bool LKPFOCCLOAA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class BKDAFCGMBNB<TData> : KKGILOLFGKM<BNJJBPACLMJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x4521740", Offset = "0x4520940", VA = "0x184521740")]
	public BKDAFCGMBNB(BNJJBPACLMJ<TData> IJKONPKDHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x45216F0", Offset = "0x45208F0", VA = "0x1845216F0", Slot = "4")]
	public override bool LKPFOCCLOAA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class BNBLMKJPCAL<TData> : KKGILOLFGKM<BNJJBPACLMJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly FCBFNHJCFPP<TData> NPJFKOFDPAH;

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x605F570", Offset = "0x605E770", VA = "0x18605F570")]
	public BNBLMKJPCAL(IEnumerable<TData> FOPOBHMOIDG, bool BOKBLILDCBK, BNJJBPACLMJ<TData> IJKONPKDHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x4539610", Offset = "0x4538810", VA = "0x184539610", Slot = "4")]
	public override bool LKPFOCCLOAA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class PEGKNPCHOBM<TData> : KKGILOLFGKM<NAGMMGHPBIM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly NIICLADNEBP<TData> NPJFKOFDPAH;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x560D1E0", Offset = "0x560C3E0", VA = "0x18560D1E0")]
	public PEGKNPCHOBM(IEnumerable<TData> FOPOBHMOIDG, Quaternion BMGOOJLNKEF, FGLNDEAJFFC ILKNEPHOCPA, Vector3? ANCLADHNABJ, bool INKCIJGGMEN, bool BOKBLILDCBK, Space GGMBBKFGNFP, NAGMMGHPBIM<TData> IJKONPKDHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x45445C0", Offset = "0x45437C0", VA = "0x1845445C0", Slot = "4")]
	public override bool LKPFOCCLOAA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public class POGGIFHNKHD<TData> : KKGILOLFGKM<BNJJBPACLMJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private readonly GDHCGFACFGK NPJFKOFDPAH;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x563CC00", Offset = "0x563BE00", VA = "0x18563CC00")]
	public POGGIFHNKHD(Quaternion LPDJIOCKEMA, Vector3? ANCLADHNABJ, bool INKCIJGGMEN, BNJJBPACLMJ<TData> IJKONPKDHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x4545820", Offset = "0x4544A20", VA = "0x184545820", Slot = "4")]
	public override bool LKPFOCCLOAA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public struct CKIJJGIJBIF<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public readonly IEnumerable<TData> FOPOBHMOIDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public readonly Quaternion LPDJIOCKEMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public readonly Vector3? ANCLADHNABJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public readonly bool INKCIJGGMEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public readonly bool BOKBLILDCBK;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x662E460", Offset = "0x662D660", VA = "0x18662E460")]
	public CKIJJGIJBIF(IEnumerable<TData> FOPOBHMOIDG, Quaternion LPDJIOCKEMA, Vector3? ANCLADHNABJ, bool INKCIJGGMEN, bool BOKBLILDCBK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct FCBFNHJCFPP<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public readonly IEnumerable<TData> FOPOBHMOIDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public readonly bool BOKBLILDCBK;

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x498ED60", Offset = "0x498DF60", VA = "0x18498ED60")]
	public FCBFNHJCFPP(IEnumerable<TData> FOPOBHMOIDG, bool BOKBLILDCBK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public struct NIICLADNEBP<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public readonly IEnumerable<TData> FOPOBHMOIDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public readonly Quaternion BMGOOJLNKEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public readonly FGLNDEAJFFC ILKNEPHOCPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public readonly Vector3? ANCLADHNABJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public readonly bool INKCIJGGMEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public readonly bool BOKBLILDCBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public readonly Space GGMBBKFGNFP;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x5397E60", Offset = "0x5397060", VA = "0x185397E60")]
	public NIICLADNEBP(IEnumerable<TData> FOPOBHMOIDG, Quaternion BMGOOJLNKEF, FGLNDEAJFFC ILKNEPHOCPA, Vector3? ANCLADHNABJ, bool INKCIJGGMEN, bool BOKBLILDCBK, Space GGMBBKFGNFP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct GDHCGFACFGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly Quaternion LPDJIOCKEMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public readonly Vector3? ANCLADHNABJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly bool INKCIJGGMEN;

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x5C517E0", Offset = "0x5C509E0", VA = "0x185C517E0")]
	public GDHCGFACFGK(Quaternion LPDJIOCKEMA, Vector3? ANCLADHNABJ, bool INKCIJGGMEN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public interface AEGIHPIJONP<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool POHHBJBEPBG([In] GGMODDENOOC<TData> CKPAHPOIEMD);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OODDLKANNKM([In] JEMAHGHHMPL LIMCMBIBGHD);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool OODDLKANNKM([In] ONPGBAJGKFC LIMCMBIBGHD);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool OODDLKANNKM([In] BGAKOMKJAOM LIMCMBIBGHD);

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool JKAOFPKJBBB();
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public class JFDHLKIFENN<TData> : KKGILOLFGKM<AEGIHPIJONP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private readonly BGAKOMKJAOM CKNHHNBFDFF;

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x4EB7E00", Offset = "0x4EB7000", VA = "0x184EB7E00")]
	public JFDHLKIFENN(Vector3 KENPLCCFIPJ, float PFEJJJDICMM, Vector3 ANCLADHNABJ, bool POCKFCOKNHJ, bool KCJELLJMIPO, AEGIHPIJONP<TData> IJKONPKDHEA, Space GGMBBKFGNFP = Space.Self)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x4EB7DA0", Offset = "0x4EB6FA0", VA = "0x184EB7DA0", Slot = "4")]
	public override bool LKPFOCCLOAA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public class FKFFNAOKMAL<TData> : KKGILOLFGKM<AEGIHPIJONP<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x4521740", Offset = "0x4520940", VA = "0x184521740")]
	public FKFFNAOKMAL(AEGIHPIJONP<TData> IJKONPKDHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x49AD820", Offset = "0x49ACA20", VA = "0x1849AD820", Slot = "4")]
	public override bool LKPFOCCLOAA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public class GHHIPMBFHJE<TData> : KKGILOLFGKM<AEGIHPIJONP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private readonly GGMODDENOOC<TData> CKNHHNBFDFF;

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x4A6B710", Offset = "0x4A6A910", VA = "0x184A6B710")]
	public GHHIPMBFHJE(IEnumerable<TData> FOPOBHMOIDG, bool BOKBLILDCBK, AEGIHPIJONP<TData> IJKONPKDHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x4539610", Offset = "0x4538810", VA = "0x184539610", Slot = "4")]
	public override bool LKPFOCCLOAA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public class JADEBJDILFM<TData> : KKGILOLFGKM<AEGIHPIJONP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private readonly ONPGBAJGKFC CKNHHNBFDFF;

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x4E795F0", Offset = "0x4E787F0", VA = "0x184E795F0")]
	public JADEBJDILFM(float JCCHIKPEKEB, bool CKCLBAJBMOI, Vector3 ANCLADHNABJ, AEGIHPIJONP<TData> IJKONPKDHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x4E79530", Offset = "0x4E78730", VA = "0x184E79530", Slot = "4")]
	public override bool LKPFOCCLOAA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public class LIFOAPILECG<TData> : KKGILOLFGKM<AEGIHPIJONP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private readonly JEMAHGHHMPL CKNHHNBFDFF;

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x50D28A0", Offset = "0x50D1AA0", VA = "0x1850D28A0")]
	public LIFOAPILECG(float PFEJJJDICMM, Vector3 ANCLADHNABJ, AEGIHPIJONP<TData> IJKONPKDHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x4545820", Offset = "0x4544A20", VA = "0x184545820", Slot = "4")]
	public override bool LKPFOCCLOAA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public struct BGAKOMKJAOM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public readonly Vector3 KENPLCCFIPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public readonly float PFEJJJDICMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public readonly Vector3 ANCLADHNABJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public readonly bool CDGCJBPOJLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public readonly Space GGMBBKFGNFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public readonly bool KCJELLJMIPO;

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x7CF0840", Offset = "0x7CEFA40", VA = "0x187CF0840")]
	public BGAKOMKJAOM(Vector3 KENPLCCFIPJ, float PFEJJJDICMM, Vector3 ANCLADHNABJ, bool CDGCJBPOJLO, bool OAAEAHCOICJ, Space GGMBBKFGNFP = Space.Self)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public struct GGMODDENOOC<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public readonly IEnumerable<TData> FOPOBHMOIDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public readonly bool BOKBLILDCBK;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x4A67240", Offset = "0x4A66440", VA = "0x184A67240")]
	public GGMODDENOOC(IEnumerable<TData> FOPOBHMOIDG, bool BOKBLILDCBK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public struct ONPGBAJGKFC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public readonly float JCCHIKPEKEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public readonly bool CKCLBAJBMOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public readonly Vector3 ANCLADHNABJ;

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x7CF2320", Offset = "0x7CF1520", VA = "0x187CF2320")]
	public ONPGBAJGKFC(float JCCHIKPEKEB, bool CKCLBAJBMOI, Vector3 ANCLADHNABJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public struct JEMAHGHHMPL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public readonly float PFEJJJDICMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public readonly Vector3 ANCLADHNABJ;

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x5C0BED0", Offset = "0x5C0B0D0", VA = "0x185C0BED0")]
	public JEMAHGHHMPL(float PFEJJJDICMM, Vector3 ANCLADHNABJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public struct OMPBLMPNOHI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public readonly Guid[] FOPOBHMOIDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public readonly bool PAFHPBGDHAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public readonly bool KNPFPODMMHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public readonly bool GPAHDGJAHOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public readonly Vector3[] BFDJINHBJLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public readonly Quaternion[] DGDFKMKPLGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public readonly float[] HHGMMPNGPFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public readonly Dictionary<Guid, Vector3> NBBHNNIGFFN;

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x7CF2090", Offset = "0x7CF1290", VA = "0x187CF2090")]
	public OMPBLMPNOHI(Guid[] JKFPOHPIFFB, Vector3[] BFDJINHBJLF, Quaternion[] DGDFKMKPLGB, float[] HHGMMPNGPFG, Dictionary<Guid, Vector3> NBBHNNIGFFN, bool PAFHPBGDHAM = true, bool KNPFPODMMHL = true, bool GPAHDGJAHOP = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7CF1EC0", Offset = "0x7CF10C0", VA = "0x187CF1EC0")]
	private static void JOFBHNFLKKE(Dictionary<Guid, Vector3> NBBHNNIGFFN, int EIGAAKOPBDF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public static class NEMFJAPLGEI
{
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	private struct AIIKAIHDIPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public bool FAAKPCGHFMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public HILJAABEPDC LKMNPKLONEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public HILJAABEPDC HBEIKGLFOLG;
	}

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static AIIKAIHDIPO BEMNFGAMIKH;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static CancellationToken EIFJDLIJOPL
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x7CF1C90", Offset = "0x7CF0E90", VA = "0x187CF1C90")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	internal static HILJAABEPDC LKMNPKLONEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x7CF1CB0", Offset = "0x7CF0EB0", VA = "0x187CF1CB0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x7CF1D50", Offset = "0x7CF0F50", VA = "0x187CF1D50")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x7CF1BA0", Offset = "0x7CF0DA0", VA = "0x187CF1BA0")]
	[DBIDCJGLKKO.IJEBINAOMBK]
	internal static void IMCKJCIKHAK(HILJAABEPDC NOMBELPEBEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x7CF1A50", Offset = "0x7CF0C50", VA = "0x187CF1A50")]
	public static void AJIPEHIHHNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x7CF1DB0", Offset = "0x7CF0FB0", VA = "0x187CF1DB0")]
	private static HILJAABEPDC MHEMBLMHBKH(HILJAABEPDC EHJIEHKGOBN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public static class KMKDDDPLFKP
{
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	public enum IIMNKKCPFCH
	{
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		ICreationContextObject,
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		Guid
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x38B5E80", Offset = "0x38B5080", VA = "0x1838B5E80")]
	public static void JOPOIHMONGF<T>(T BJFPHBLMMJE, IIMNKKCPFCH EDLOHJEBKFM) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x38B5E10", Offset = "0x38B5010", VA = "0x1838B5E10")]
	public static void JOPOIHMONGF<T>(T BJFPHBLMMJE) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x38B5D20", Offset = "0x38B4F20", VA = "0x1838B5D20")]
	public static void JOPOIHMONGF<T, TImpl, T>() where T : class where TImpl : notnull, T where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x38B5FE0", Offset = "0x38B51E0", VA = "0x1838B5FE0")]
	public static void LKFENBBPMEL<T>(T BJFPHBLMMJE) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x38B5BC0", Offset = "0x38B4DC0", VA = "0x1838B5BC0")]
	public static T HKFPFFCEPKK<T>(IIMNKKCPFCH EDLOHJEBKFM) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x38B6090", Offset = "0x38B5290", VA = "0x1838B6090")]
	public static bool LONOHHPMJJI<T>(IIMNKKCPFCH EDLOHJEBKFM, T? MBODEDIHJMP, [Out][MaybeNullWhen(false)][NotNullWhen(true)] T OIPAMAGKCJD) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x38B5A50", Offset = "0x38B4C50", VA = "0x1838B5A50")]
	public static bool BLEFKAIJDGE<T>(IIMNKKCPFCH EDLOHJEBKFM, [Out][NotNullWhen(true)][MaybeNullWhen(false)] T NJPELEHGFLF) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x38B5C70", Offset = "0x38B4E70", VA = "0x1838B5C70")]
	public static bool JDFNKDDKEPC<T>(IIMNKKCPFCH EDLOHJEBKFM) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x38B5B60", Offset = "0x38B4D60", VA = "0x1838B5B60")]
	public static T HKFPFFCEPKK<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x38B61E0", Offset = "0x38B53E0", VA = "0x1838B61E0")]
	public static bool LONOHHPMJJI<T>(T MBODEDIHJMP, [Out] T OIPAMAGKCJD) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x38B5B60", Offset = "0x38B4D60", VA = "0x1838B5B60")]
	public static bool JDFNKDDKEPC<T>() where T : class
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
internal static class BICCOPKFHHN
{
	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x7CF0880", Offset = "0x7CEFA80", VA = "0x187CF0880")]
	public static void ADAHMMOFABI(IEnumerable BILGLLGDPJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x35B6310", Offset = "0x35B5510", VA = "0x1835B6310")]
	public static void ADAHMMOFABI<T>(T[] CABEAFGDMFF) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x35B6400", Offset = "0x35B5600", VA = "0x1835B6400")]
	public static void ADAHMMOFABI<T>(T EJKIDBDKPMD) where T : notnull, Enum
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
