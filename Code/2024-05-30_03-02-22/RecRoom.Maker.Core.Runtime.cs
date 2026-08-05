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
		[Cpp2IlInjected.Address(RVA = "0x7F2B00", Offset = "0x7F1D00", VA = "0x1807F2B00")]
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
		[Cpp2IlInjected.Address(RVA = "0x643B330", Offset = "0x643A530", VA = "0x18643B330")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7F3A00", Offset = "0x7F2C00", VA = "0x1807F3A00")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F3A40", Offset = "0x7F2C40", VA = "0x1807F3A40")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface CHKBBDIIIBO<TData, TReturn>
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TReturn IMCCCNNEEHB(TData CDJAKLIPEBF);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface HKNPLCNPLGF<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ClearHoverTarget(MDKLHHPMEED HJDAILCBLCE);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool SetHoverTarget(TData FMEDEJNEJHJ, Collider MGMKJCGNGJJ, MDKLHHPMEED HJDAILCBLCE, [Optional] IGEOLMBFFAJ? ABCJJKJCKLN);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool TryGetHoverTarget([Out] TData FMEDEJNEJHJ);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetHoverCollider([Out] Collider MGMKJCGNGJJ);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface DMJLDOGFCGE<TData> : PONOJOJBCKD, GEJDGEPKPJD<TData>, KHLIAKOGBJP<TData>, BHLCLPLJHJG<TData>, DLJPEKCKFCG, KJEACPOBOHH<TData>, JJOAEIKJIMD, CMCOHLMBCKO
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface KJEACPOBOHH<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 LEDLONHHKMC, Vector3 GDLGHHBOJHM, float DLJLDGNAIFD, [Out] T EFNDOPAFCBL, [Out] Vector3 PJJKNLBLCFJ, [Out] Collider MGMKJCGNGJJ);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 LEDLONHHKMC, Vector3 GDLGHHBOJHM, float BOCEOMGEFJO, float DLJLDGNAIFD, T[] NEDEDEAPFMC, [Out] Vector3 MABCIFIGOIH, [Out] Collider HGNMPPFOLEE);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 LEDLONHHKMC, float BOCEOMGEFJO, Vector3 BCEOOIPDCGL, T[] NEDEDEAPFMC);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetObjectFromColliderInCurrentScope(Collider MJPKEDNHCHC, [Out] T ABHKOAJGDED);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface PONOJOJBCKD
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Bounds CCBNDBOANDM
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Transform LBJLEHJJBJP
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Bounds BPOEIKGDHHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Transform LGNJJDONCLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Vector3 ALLLMKJGCLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool AGHBLMIDOJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void SetSelectionBoundsDirty(bool COBHHHBKDJN = true, int CIBOOOMNLAL = 0);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ShouldHideSelectionBoundsPreview(bool OFDAAOMLCAF, object CEFPPEHCFCF);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface CMCOHLMBCKO
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	OJHEJHCKNBB JOKEJBGOHBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface MGICCNBFNCO
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool NGOBLFIBFPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool JEFJMKHHEDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool OMKCFBMPBGF
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
	void TrySetPreviousCloneMapping(Dictionary<Guid, Guid> MJNCHEEDLHA);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface BHLCLPLJHJG<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool NONNPOBIHGN
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int MECMNLPHDBB
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<TData> OBIFNNILJED
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData OIJOJELHKIF);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData OIJOJELHKIF);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface GEJDGEPKPJD<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T CDJAKLIPEBF, [Optional] IGEOLMBFFAJ? CLCCJLMKKCB, bool GFFPCCFNKJH = true);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int BIFLOKBJAPK, IEnumerable<T> IANBIIFLGNN, bool GFFPCCFNKJH = true);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int BIFLOKBJAPK, IEnumerable<T> IANBIIFLGNN, IGEOLMBFFAJ CLCCJLMKKCB, bool GFFPCCFNKJH = true);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface JJOAEIKJIMD
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface DLJPEKCKFCG
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool HKNFFONNALK
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool BJBFEAOOAKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool OIFNPNNEOHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool DMGCLOKJFOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class NCJHEEOPOGO<TReceiver> : MLELBHHPLMN<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x355E660", Offset = "0x355D860", VA = "0x18355E660")]
	public NCJHEEOPOGO(TReceiver LHADPJODGJC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class HMHHGMEMAHP<TReceiver, TFromTask> : MLELBHHPLMN<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x355E660", Offset = "0x355D860", VA = "0x18355E660")]
	public HMHHGMEMAHP(TReceiver LHADPJODGJC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public abstract class MLELBHHPLMN<TReceiver, TFromExecute> where TReceiver : notnull where TFromExecute : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	protected TReceiver LHADPJODGJC;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x41457A0", Offset = "0x41449A0", VA = "0x1841457A0")]
	public MLELBHHPLMN(TReceiver LHADPJODGJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute DMDKHAOOBDK();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public abstract class KIKHKGDDMBO<TReceiver, TResult> : MLELBHHPLMN<TReceiver, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x355E660", Offset = "0x355D860", VA = "0x18355E660")]
	public KIKHKGDDMBO(TReceiver LHADPJODGJC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct DNIPPALMLCI<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public TGroup LKHKACCJAKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public TData EPOPGPKBENJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public IEnumerable<TData> DODFFDDDEGP;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1DAA420", Offset = "0x1DA9620", VA = "0x181DAA420")]
	public DNIPPALMLCI(TGroup JLEIJNDJNHM, TData IALFHEDLLHI, IEnumerable<TData> JNKNIGGBIIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct HCKILLDOCPJ<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public TGroup LKHKACCJAKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public IEnumerable<TData> DODFFDDDEGP;

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x9FB690", Offset = "0x9FA890", VA = "0x1809FB690")]
	public HCKILLDOCPJ(TGroup JLEIJNDJNHM, IEnumerable<TData> JNKNIGGBIIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct BEDGCIBOFIJ<TGroup> where TGroup : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public TGroup LKHKACCJAKE;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x877820", Offset = "0x876A20", VA = "0x180877820")]
	public BEDGCIBOFIJ(TGroup JLEIJNDJNHM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct OAIEJKLELHK<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public IEnumerable<TData> DODFFDDDEGP;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x877820", Offset = "0x876A20", VA = "0x180877820")]
	public OAIEJKLELHK(IEnumerable<TData> JNKNIGGBIIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface DGPGPBGBBOM<TGroup, TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ONMHMDCEDHJ BKMIBPLLBKO(DNIPPALMLCI<TGroup, TData> PLHOGPLJPED);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ONMHMDCEDHJ ABHHOGFCDOP(DNIPPALMLCI<TGroup, TData> PLHOGPLJPED);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ONMHMDCEDHJ FELGCGJNKCG(HCKILLDOCPJ<TGroup, TData> PLHOGPLJPED);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "3")]
	ONMHMDCEDHJ PIOPNAAFGFB(BEDGCIBOFIJ<TGroup> PLHOGPLJPED);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface COCNONDLCEN<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<ONMHMDCEDHJ> BKMIBPLLBKO(OAIEJKLELHK<TData> PLHOGPLJPED);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class EKMBMADAGIO<TGroup, TData> : KIKHKGDDMBO<DGPGPBGBBOM<TGroup, TData>, ONMHMDCEDHJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly HCKILLDOCPJ<TGroup, TData> PLHOGPLJPED;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x358DDD0", Offset = "0x358CFD0", VA = "0x18358DDD0")]
	public EKMBMADAGIO(TGroup JLEIJNDJNHM, IEnumerable<TData> JNKNIGGBIIN, DGPGPBGBBOM<TGroup, TData> LHADPJODGJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x358DD10", Offset = "0x358CF10", VA = "0x18358DD10", Slot = "4")]
	public override ONMHMDCEDHJ DMDKHAOOBDK()
	{
		return default(ONMHMDCEDHJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class ICFCKHPKCHA<TGroup, TData> : KIKHKGDDMBO<DGPGPBGBBOM<TGroup, TData>, ONMHMDCEDHJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly DNIPPALMLCI<TGroup, TData> PLHOGPLJPED;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3B046A0", Offset = "0x3B038A0", VA = "0x183B046A0")]
	public ICFCKHPKCHA(TGroup JLEIJNDJNHM, TData OBCJHKPEPOH, IEnumerable<TData> JNKNIGGBIIN, DGPGPBGBBOM<TGroup, TData> LHADPJODGJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3B045D0", Offset = "0x3B037D0", VA = "0x183B045D0", Slot = "4")]
	public override ONMHMDCEDHJ DMDKHAOOBDK()
	{
		return default(ONMHMDCEDHJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class MEAJPNEFDGL<TGroup, TData> : KIKHKGDDMBO<DGPGPBGBBOM<TGroup, TData>, ONMHMDCEDHJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly BEDGCIBOFIJ<TGroup> PLHOGPLJPED;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3B16B60", Offset = "0x3B15D60", VA = "0x183B16B60")]
	public MEAJPNEFDGL(TGroup JLEIJNDJNHM, DGPGPBGBBOM<TGroup, TData> LHADPJODGJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4130940", Offset = "0x412FB40", VA = "0x184130940", Slot = "4")]
	public override ONMHMDCEDHJ DMDKHAOOBDK()
	{
		return default(ONMHMDCEDHJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class BOINBHCEMBL<TGroup, TData> : KIKHKGDDMBO<DGPGPBGBBOM<TGroup, TData>, ONMHMDCEDHJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly DNIPPALMLCI<TGroup, TData> PLHOGPLJPED;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3B046A0", Offset = "0x3B038A0", VA = "0x183B046A0")]
	public BOINBHCEMBL(TGroup JLEIJNDJNHM, TData IALFHEDLLHI, IEnumerable<TData> JNKNIGGBIIN, DGPGPBGBBOM<TGroup, TData> LHADPJODGJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4BF3340", Offset = "0x4BF2540", VA = "0x184BF3340", Slot = "4")]
	public override ONMHMDCEDHJ DMDKHAOOBDK()
	{
		return default(ONMHMDCEDHJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class IHACHCOBFJC<TData> : HMHHGMEMAHP<COCNONDLCEN<TData>, ONMHMDCEDHJ> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private struct HALIHMOOAMP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AsyncTaskMethodBuilder<ONMHMDCEDHJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public IHACHCOBFJC<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private TaskAwaiter<ONMHMDCEDHJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x3A1DCB0", Offset = "0x3A1CEB0", VA = "0x183A1DCB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3A1DF50", Offset = "0x3A1D150", VA = "0x183A1DF50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private OAIEJKLELHK<TData> PLHOGPLJPED;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3B16B60", Offset = "0x3B15D60", VA = "0x183B16B60")]
	public IHACHCOBFJC(IEnumerable<TData> FCLNGJGLOBB, COCNONDLCEN<TData> LHADPJODGJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3B16A60", Offset = "0x3B15C60", VA = "0x183B16A60", Slot = "4")]
	[AsyncStateMachine(typeof(IHACHCOBFJC<>.HALIHMOOAMP))]
	public override Task<ONMHMDCEDHJ> DMDKHAOOBDK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct GIJPFPMGIBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly MEPBPDHMMEP KBANBGBDOKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly bool HAKHFKOLDPI;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x643A5A0", Offset = "0x64397A0", VA = "0x18643A5A0")]
	public GIJPFPMGIBF(MEPBPDHMMEP FEFNMHLMBAE, bool NCANHGDFCGO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface IKGLDJOAEOH<TSpawnType> where TSpawnType : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> DMDKHAOOBDK(GIJPFPMGIBF EMCFDEGPHGM);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class HDKNOGKIMPI<TSpawnType> : HMHHGMEMAHP<IKGLDJOAEOH<TSpawnType>, TSpawnType> where TSpawnType : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private struct CKDHMHGHIPO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public AsyncTaskMethodBuilder<TSpawnType> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public HDKNOGKIMPI<TSpawnType> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskAwaiter<TSpawnType> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x505DD90", Offset = "0x505CF90", VA = "0x18505DD90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x4292740", Offset = "0x4291940", VA = "0x184292740", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly GIJPFPMGIBF EMCFDEGPHGM;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3A2CF30", Offset = "0x3A2C130", VA = "0x183A2CF30")]
	public HDKNOGKIMPI(MEPBPDHMMEP FEFNMHLMBAE, bool NCANHGDFCGO, IKGLDJOAEOH<TSpawnType> LHADPJODGJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3A2CE40", Offset = "0x3A2C040", VA = "0x183A2CE40", Slot = "4")]
	[AsyncStateMachine(typeof(HDKNOGKIMPI<>.CKDHMHGHIPO))]
	public override Task<TSpawnType> DMDKHAOOBDK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public readonly struct MEPBPDHMMEP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly bool PABOBDEPMID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly Vector3 BONJNMKEEEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly Vector3 HFHFPGFAPOG;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x643AC50", Offset = "0x6439E50", VA = "0x18643AC50")]
	public MEPBPDHMMEP(Transform DJNMFAODMHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x643AD50", Offset = "0x6439F50", VA = "0x18643AD50")]
	public MEPBPDHMMEP(Vector3 BGIIKDPIDDB, Vector3 CAOOPLKANIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x643AC20", Offset = "0x6439E20", VA = "0x18643AC20")]
	public static MEPBPDHMMEP CIALDCDEGDF()
	{
		return default(MEPBPDHMMEP);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x643ACC0", Offset = "0x6439EC0", VA = "0x18643ACC0")]
	private MEPBPDHMMEP(bool GMDMMDDHLCE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct BMDNMOMJBBD<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public TNode CDKFINPFKFA;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4B027B0", Offset = "0x4B019B0", VA = "0x184B027B0")]
	public BMDNMOMJBBD(TNode CDKFINPFKFA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct BAOHODIIGNE<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public TNode PCIGCHDCEGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public GPBDEFKAJBP BCIBKDDNIHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly bool HAKHFKOLDPI;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x4A44840", Offset = "0x4A43A40", VA = "0x184A44840")]
	public BAOHODIIGNE(TNode PCIGCHDCEGB, GPBDEFKAJBP BCIBKDDNIHP, bool NCANHGDFCGO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface LNAGANAPIKP<TNode>
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PBGKKLGOEBM([In] BMDNMOMJBBD<TNode> JFOAMFMCPFP);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KNNHGPLDMEM([In] BAOHODIIGNE<TNode> AJDOGLDCMPL);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool ADLDFHADNPA();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class BBILOOOJHNE<TNode> : NCJHEEOPOGO<LNAGANAPIKP<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x355E660", Offset = "0x355D860", VA = "0x18355E660")]
	public BBILOOOJHNE(LNAGANAPIKP<TNode> LHADPJODGJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3EC3610", Offset = "0x3EC2810", VA = "0x183EC3610", Slot = "4")]
	public override bool DMDKHAOOBDK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class AMLAFHBKENB<TNode> : NCJHEEOPOGO<LNAGANAPIKP<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly BAOHODIIGNE<TNode> AJDOGLDCMPL;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3D643D0", Offset = "0x3D635D0", VA = "0x183D643D0")]
	public AMLAFHBKENB(TNode PCIGCHDCEGB, GPBDEFKAJBP BCIBKDDNIHP, LNAGANAPIKP<TNode> LHADPJODGJC, bool NCANHGDFCGO = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x39E34E0", Offset = "0x39E26E0", VA = "0x1839E34E0", Slot = "4")]
	public override bool DMDKHAOOBDK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class AEENPNCGIJA<TNode> : NCJHEEOPOGO<LNAGANAPIKP<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly BMDNMOMJBBD<TNode> JFOAMFMCPFP;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3BA7A20", Offset = "0x3BA6C20", VA = "0x183BA7A20")]
	public AEENPNCGIJA(TNode OKPMIHCAFPC, LNAGANAPIKP<TNode> LHADPJODGJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3902FB0", Offset = "0x39021B0", VA = "0x183902FB0", Slot = "4")]
	public override bool DMDKHAOOBDK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct EMAPKNAMOBE<TSpawnInfo> where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public TSpawnInfo GMGOEBKHHFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public Vector3 CAOOPLKANIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Quaternion JCCMNAMJFGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public float MGKBJKPBCFA;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3597A60", Offset = "0x3596C60", VA = "0x183597A60")]
	public EMAPKNAMOBE(TSpawnInfo GMGOEBKHHFE, Vector3 CAOOPLKANIG, Quaternion JCCMNAMJFGM, float MGKBJKPBCFA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface LBFAFEOMBBK<TSpawnType, TSpawnInfo>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> GGHDBIIFNCI([In] EMAPKNAMOBE<TSpawnInfo> ENINDNLGDGC, CancellationToken GILHKFNDIJP);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class FKNCKIIMEME<TSpawnType, TSpawnInfo> : HMHHGMEMAHP<LBFAFEOMBBK<TSpawnType, TSpawnInfo>, TSpawnType> where TSpawnType : notnull where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly EMAPKNAMOBE<TSpawnInfo> NEAMBEFDODM;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3919D00", Offset = "0x3918F00", VA = "0x183919D00")]
	public FKNCKIIMEME(TSpawnInfo PDAAAAIEKII, Vector3 CAOOPLKANIG, Quaternion JCCMNAMJFGM, float MGKBJKPBCFA, LBFAFEOMBBK<TSpawnType, TSpawnInfo> LHADPJODGJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3919B20", Offset = "0x3918D20", VA = "0x183919B20", Slot = "4")]
	public override Task<TSpawnType> DMDKHAOOBDK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct JHEBPFHJNJM<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly IEnumerable<TData> DODFFDDDEGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly bool HAKHFKOLDPI;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x3D4FD20", Offset = "0x3D4EF20", VA = "0x183D4FD20")]
	public JHEBPFHJNJM(IEnumerable<TData> JNKNIGGBIIN, bool NCANHGDFCGO = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface EIHIMNOGDGJ<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<ONMHMDCEDHJ> BLAFDJIIMIB([In] JHEBPFHJNJM<TData> MKHOLNHKKIF, CancellationToken GILHKFNDIJP);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class LKHBBMBPCCH<TData> : HMHHGMEMAHP<EIHIMNOGDGJ<TData>, ONMHMDCEDHJ> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly JHEBPFHJNJM<TData> LHMMKFEGLHD;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3F627B0", Offset = "0x3F619B0", VA = "0x183F627B0")]
	public LKHBBMBPCCH(IEnumerable<TData> JNKNIGGBIIN, bool NCANHGDFCGO, EIHIMNOGDGJ<TData> LHADPJODGJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3919B20", Offset = "0x3918D20", VA = "0x183919B20", Slot = "4")]
	public override Task<ONMHMDCEDHJ> DMDKHAOOBDK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct GMELFEKFBGF<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public readonly T FMEDEJNEJHJ;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x39DD920", Offset = "0x39DCB20", VA = "0x1839DD920")]
	public GMELFEKFBGF(T OOBEAJAKBKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface HAAJMADBLED<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PBGKKLGOEBM([In] GMELFEKFBGF<T> PNOEPAMCKBN);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KNNHGPLDMEM();
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface FKHEIODNJBH<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DMDKHAOOBDK([In] GFACJCDJMMH<T> GBCAOHBHHFP);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct GFACJCDJMMH<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public readonly T FMEDEJNEJHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public readonly bool HMJBJENLAAL;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x39C8010", Offset = "0x39C7210", VA = "0x1839C8010")]
	public GFACJCDJMMH(T OOBEAJAKBKF, bool HCAHCFPNIDD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class EHHMKHJKGNO<T> : NCJHEEOPOGO<HAAJMADBLED<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x355E660", Offset = "0x355D860", VA = "0x18355E660")]
	public EHHMKHJKGNO(HAAJMADBLED<T> LHADPJODGJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x3574140", Offset = "0x3573340", VA = "0x183574140", Slot = "4")]
	public override bool DMDKHAOOBDK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class OFGIJADJFMA<T> : NCJHEEOPOGO<HAAJMADBLED<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly GMELFEKFBGF<T> PNOEPAMCKBN;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x428F6F0", Offset = "0x428E8F0", VA = "0x18428F6F0")]
	public OFGIJADJFMA(T FMEDEJNEJHJ, HAAJMADBLED<T> LHADPJODGJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x3902FB0", Offset = "0x39021B0", VA = "0x183902FB0", Slot = "4")]
	public override bool DMDKHAOOBDK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class GBGGJCNGCHD<T> : NCJHEEOPOGO<FKHEIODNJBH<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly GFACJCDJMMH<T> GBCAOHBHHFP;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x39A5C00", Offset = "0x39A4E00", VA = "0x1839A5C00")]
	public GBGGJCNGCHD(T FMEDEJNEJHJ, bool HCAHCFPNIDD, FKHEIODNJBH<T> LHADPJODGJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x3902FB0", Offset = "0x39021B0", VA = "0x183902FB0", Slot = "4")]
	public override bool DMDKHAOOBDK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct OAHAAPOKODP<TData> where TData : notnull, DCNHBMGFPPB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public IEnumerable<TData> DODFFDDDEGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public bool DJMGNHHMGEM;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x427F8A0", Offset = "0x427EAA0", VA = "0x18427F8A0")]
	public OAHAAPOKODP(IEnumerable<TData> JMOJLGPOJMG, bool OJJIMHPAPGB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct FPCFDGIMIDA<TData> where TData : notnull, DCNHBMGFPPB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public List<TData> DODFFDDDEGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public List<bool> OCGNHDDJDLN;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x3927780", Offset = "0x3926980", VA = "0x183927780")]
	public FPCFDGIMIDA(List<TData> JMOJLGPOJMG, List<bool> OGJEMHHHAKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface DCNHBMGFPPB
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool OMGIPHIGFGJ
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
public interface IOGCPGHMAMF<TData> where TData : DCNHBMGFPPB
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DMDKHAOOBDK([In] OAHAAPOKODP<TData> LLJIDKFNCFF);

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DMDKHAOOBDK([In] FPCFDGIMIDA<TData> LLJIDKFNCFF);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface EBHHADAEKLA<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JOPFDOAMMGJ(T FMEDEJNEJHJ);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class DMGBKOOLAND<TData> : NCJHEEOPOGO<IOGCPGHMAMF<TData>> where TData : notnull, DCNHBMGFPPB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly OAHAAPOKODP<TData> LLJIDKFNCFF;

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5347F10", Offset = "0x5347110", VA = "0x185347F10")]
	public DMGBKOOLAND(List<TData> JNKNIGGBIIN, bool DJMGNHHMGEM, IOGCPGHMAMF<TData> LHADPJODGJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x3902FB0", Offset = "0x39021B0", VA = "0x183902FB0", Slot = "4")]
	public override bool DMDKHAOOBDK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class JBGMJJAIHMM<TData> : NCJHEEOPOGO<IOGCPGHMAMF<TData>> where TData : notnull, DCNHBMGFPPB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly FPCFDGIMIDA<TData> LLJIDKFNCFF;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x3CE7C90", Offset = "0x3CE6E90", VA = "0x183CE7C90")]
	public JBGMJJAIHMM(List<TData> JNKNIGGBIIN, List<bool> OCGNHDDJDLN, IOGCPGHMAMF<TData> LHADPJODGJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x3CE7BE0", Offset = "0x3CE6DE0", VA = "0x183CE7BE0", Slot = "4")]
	public override bool DMDKHAOOBDK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface KOFFPKDIDHC<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<ONMHMDCEDHJ> DMDKHAOOBDK(IPIBNEGNKIP<TData> OIEJIFLMOLE);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public class JOGNLHEHGCG<TData> : HMHHGMEMAHP<KOFFPKDIDHC<TData>, ONMHMDCEDHJ> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct HIBLNDKLHGP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public AsyncTaskMethodBuilder<ONMHMDCEDHJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public JOGNLHEHGCG<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter<ONMHMDCEDHJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x3A3ECC0", Offset = "0x3A3DEC0", VA = "0x183A3ECC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x3A3EFA0", Offset = "0x3A3E1A0", VA = "0x183A3EFA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly IPIBNEGNKIP<TData> ACBDPKLPCEM;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x3D9B5F0", Offset = "0x3D9A7F0", VA = "0x183D9B5F0")]
	public JOGNLHEHGCG(TData GJNKAIPGFOL, IReadOnlyList<TData> KCDKABAKBAC, bool NCANHGDFCGO, KOFFPKDIDHC<TData> LHADPJODGJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x3D9B4F0", Offset = "0x3D9A6F0", VA = "0x183D9B4F0", Slot = "4")]
	[AsyncStateMachine(typeof(JOGNLHEHGCG<>.HIBLNDKLHGP))]
	public override Task<ONMHMDCEDHJ> DMDKHAOOBDK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public struct IPIBNEGNKIP<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public TData DIMFEMKFHBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public IReadOnlyList<TData> LCKKMBICAII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public bool HAKHFKOLDPI;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x3B3AA50", Offset = "0x3B39C50", VA = "0x183B3AA50")]
	public IPIBNEGNKIP(TData GJNKAIPGFOL, IReadOnlyList<TData> KCDKABAKBAC, bool NCANHGDFCGO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface JGEJICAECOG<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DMDKHAOOBDK([In] CFHNMCDMJMC<TData> DFMDNKFFGCD);
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface KFIOBFHCHPI<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DMDKHAOOBDK([In] LBFFKHCCGKH<TData> DFMDNKFFGCD);
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface IHAPDCNLPAI<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AJECOLDIGPA([In] FFHPKDDOEMN<TData> DFMDNKFFGCD);

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KNNHGPLDMEM();
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class OJLGBKCAOPF<TData> : NCJHEEOPOGO<JGEJICAECOG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly CFHNMCDMJMC<TData> DFMDNKFFGCD;

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x4297340", Offset = "0x4296540", VA = "0x184297340")]
	public OJLGBKCAOPF(IEnumerable<TData> JNKNIGGBIIN, AEMMBGBKIIN LHAAJEOMGEG, OFBMKGPINAP OOHAKCENEJE, float DJBCABFODEO, bool NCANHGDFCGO, JGEJICAECOG<TData> LHADPJODGJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x3902FB0", Offset = "0x39021B0", VA = "0x183902FB0", Slot = "4")]
	public override bool DMDKHAOOBDK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class EMJGIAEJKKD<TData> : NCJHEEOPOGO<KFIOBFHCHPI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly LBFFKHCCGKH<TData> DFMDNKFFGCD;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x35994A0", Offset = "0x35986A0", VA = "0x1835994A0")]
	public EMJGIAEJKKD(TData[] JNKNIGGBIIN, AEMMBGBKIIN[] LHAAJEOMGEG, OFBMKGPINAP[] OOHAKCENEJE, float[] DJBCABFODEO, KFIOBFHCHPI<TData> LHADPJODGJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x35993F0", Offset = "0x35985F0", VA = "0x1835993F0", Slot = "4")]
	public override bool DMDKHAOOBDK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class ILJGDOLDOOO<TData> : NCJHEEOPOGO<IHAPDCNLPAI<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x355E660", Offset = "0x355D860", VA = "0x18355E660")]
	public ILJGDOLDOOO(IHAPDCNLPAI<TData> LHADPJODGJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x3B203A0", Offset = "0x3B1F5A0", VA = "0x183B203A0", Slot = "4")]
	public override bool DMDKHAOOBDK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class IENPNEIGHJO<TData> : NCJHEEOPOGO<IHAPDCNLPAI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly FFHPKDDOEMN<TData> DFMDNKFFGCD;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3B09E20", Offset = "0x3B09020", VA = "0x183B09E20")]
	public IENPNEIGHJO(IEnumerable<TData> JNKNIGGBIIN, AEMMBGBKIIN LHAAJEOMGEG, OFBMKGPINAP OOHAKCENEJE, float DJBCABFODEO, IHAPDCNLPAI<TData> LHADPJODGJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x35993F0", Offset = "0x35985F0", VA = "0x1835993F0", Slot = "4")]
	public override bool DMDKHAOOBDK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public struct CFHNMCDMJMC<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public IEnumerable<TData> DODFFDDDEGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public AEMMBGBKIIN HJNOELOMHDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public OFBMKGPINAP COFJHALALNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public float DJBCABFODEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public bool NCANHGDFCGO;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4F7D4D0", Offset = "0x4F7C6D0", VA = "0x184F7D4D0")]
	public CFHNMCDMJMC(IEnumerable<TData> JNKNIGGBIIN, AEMMBGBKIIN LHAAJEOMGEG, OFBMKGPINAP OOHAKCENEJE, float DJBCABFODEO, bool NCANHGDFCGO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct LBFFKHCCGKH<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public TData[] DODFFDDDEGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public AEMMBGBKIIN[] HJNOELOMHDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public OFBMKGPINAP[] COFJHALALNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public float[] DJBCABFODEO;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3F2EAF0", Offset = "0x3F2DCF0", VA = "0x183F2EAF0")]
	public LBFFKHCCGKH(TData[] JNKNIGGBIIN, AEMMBGBKIIN[] LHAAJEOMGEG, OFBMKGPINAP[] OOHAKCENEJE, float[] DJBCABFODEO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public struct FFHPKDDOEMN<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public IEnumerable<TData> DODFFDDDEGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public AEMMBGBKIIN HJNOELOMHDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public OFBMKGPINAP COFJHALALNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public float DJBCABFODEO;

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3905310", Offset = "0x3904510", VA = "0x183905310")]
	public FFHPKDDOEMN(IEnumerable<TData> JNKNIGGBIIN, AEMMBGBKIIN LHAAJEOMGEG, OFBMKGPINAP OOHAKCENEJE, float DJBCABFODEO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public interface KHLIAKOGBJP<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FELGCGJNKCG([In] HOAMBCNIHGF<TData> MKHOLNHKKIF);

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PIOPNAAFGFB([In] HOAMBCNIHGF<TData> MKHOLNHKKIF);

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OBMMDKEGAOH([In] bool FLHFGMIJBDG);

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool KMAFKKLGCFF([In] HOAMBCNIHGF<TData> MKHOLNHKKIF);

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GDJLIKFFJFH();

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool FCNJOCPBMAF([In] TData HDGFIMAHLOI);
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class FDPAFNMAKIG<TData> : NCJHEEOPOGO<KHLIAKOGBJP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly HOAMBCNIHGF<TData> MKHOLNHKKIF;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x3903060", Offset = "0x3902260", VA = "0x183903060")]
	public FDPAFNMAKIG(List<TData> GECPOPGBBAH, KHLIAKOGBJP<TData> LHADPJODGJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3902FB0", Offset = "0x39021B0", VA = "0x183902FB0", Slot = "4")]
	public override bool DMDKHAOOBDK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class EAFOEABLGCE<TData> : NCJHEEOPOGO<KHLIAKOGBJP<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x355E660", Offset = "0x355D860", VA = "0x18355E660")]
	public EAFOEABLGCE(KHLIAKOGBJP<TData> LHADPJODGJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x355E610", Offset = "0x355D810", VA = "0x18355E610", Slot = "4")]
	public override bool DMDKHAOOBDK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class GCHINPOEBJO<TData> : NCJHEEOPOGO<KHLIAKOGBJP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly bool NCANHGDFCGO;

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x39B73D0", Offset = "0x39B65D0", VA = "0x1839B73D0")]
	public GCHINPOEBJO(bool NCANHGDFCGO, KHLIAKOGBJP<TData> LHADPJODGJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x39B7370", Offset = "0x39B6570", VA = "0x1839B7370", Slot = "4")]
	public override bool DMDKHAOOBDK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class JKGBBIIJNOL<TData> : NCJHEEOPOGO<KHLIAKOGBJP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly HOAMBCNIHGF<TData> MKHOLNHKKIF;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3D5BFC0", Offset = "0x3D5B1C0", VA = "0x183D5BFC0")]
	public JKGBBIIJNOL(List<TData> GECPOPGBBAH, bool NCANHGDFCGO, KHLIAKOGBJP<TData> LHADPJODGJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3CE7BE0", Offset = "0x3CE6DE0", VA = "0x183CE7BE0", Slot = "4")]
	public override bool DMDKHAOOBDK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class FCMHNNBHBFK<TData> : NCJHEEOPOGO<KHLIAKOGBJP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly TData HDGFIMAHLOI;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x38F74D0", Offset = "0x38F66D0", VA = "0x1838F74D0")]
	public FCMHNNBHBFK(TData HDGFIMAHLOI, KHLIAKOGBJP<TData> LHADPJODGJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x38F7360", Offset = "0x38F6560", VA = "0x1838F7360", Slot = "4")]
	public override bool DMDKHAOOBDK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class CLBBKNOFAJN<TData> : NCJHEEOPOGO<KHLIAKOGBJP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly HOAMBCNIHGF<TData> MKHOLNHKKIF;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x5061660", Offset = "0x5060860", VA = "0x185061660")]
	public CLBBKNOFAJN(IEnumerable<TData> GECPOPGBBAH, KHLIAKOGBJP<TData> LHADPJODGJC, bool NCANHGDFCGO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x50615A0", Offset = "0x50607A0", VA = "0x1850615A0", Slot = "4")]
	public override bool DMDKHAOOBDK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public struct HOAMBCNIHGF<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public IEnumerable<TData> DODFFDDDEGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public bool NCANHGDFCGO;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x3A57F20", Offset = "0x3A57120", VA = "0x183A57F20")]
	public HOAMBCNIHGF(IEnumerable<TData> JMOJLGPOJMG, bool OECHNNFCPPK = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public interface IBBBNHLLODH
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<ONMHMDCEDHJ> DMDKHAOOBDK(LNJPLPBCHID HMDCOIIGLLO);
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class NFAALGGBKEF : HMHHGMEMAHP<IBBBNHLLODH, ONMHMDCEDHJ>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private struct DLNBHPEGPGI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public AsyncTaskMethodBuilder<ONMHMDCEDHJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public NFAALGGBKEF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private TaskAwaiter<ONMHMDCEDHJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x643A090", Offset = "0x6439290", VA = "0x18643A090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x643A300", Offset = "0x6439500", VA = "0x18643A300", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly LNJPLPBCHID ECDGLEANJEC;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x643B2D0", Offset = "0x643A4D0", VA = "0x18643B2D0")]
	public NFAALGGBKEF(bool NCANHGDFCGO, IBBBNHLLODH LHADPJODGJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x643B1E0", Offset = "0x643A3E0", VA = "0x18643B1E0", Slot = "4")]
	[AsyncStateMachine(typeof(DLNBHPEGPGI))]
	public override Task<ONMHMDCEDHJ> DMDKHAOOBDK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct LNJPLPBCHID
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public bool HAKHFKOLDPI;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0xD65FE0", Offset = "0xD651E0", VA = "0x180D65FE0")]
	public LNJPLPBCHID(bool NCANHGDFCGO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public readonly struct CHLFBGGBBLE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly bool BOHPKDJELPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly bool BCPBLECOLGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public readonly bool MGKBJKPBCFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public readonly bool NCANHGDFCGO;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x48A1220", Offset = "0x48A0420", VA = "0x1848A1220")]
	public CHLFBGGBBLE(bool BOHPKDJELPN, bool BCPBLECOLGA, bool MGKBJKPBCFA, bool NCANHGDFCGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x643A060", Offset = "0x6439260", VA = "0x18643A060")]
	public CHLFBGGBBLE(bool BCPBLECOLGA, bool NCANHGDFCGO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface HMINPDBHLLB
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HOGFCEIEBDO(CHLFBGGBBLE OCJHCMFNKCP);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DDOJGEHFGNB(CHLFBGGBBLE OCJHCMFNKCP);
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class GKAIHFEOIKH : NCJHEEOPOGO<HMINPDBHLLB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly CHLFBGGBBLE OCJHCMFNKCP;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x643A610", Offset = "0x6439810", VA = "0x18643A610")]
	public GKAIHFEOIKH(bool HANHCEFMJDD, bool BCPBLECOLGA, bool MGKBJKPBCFA, bool NCANHGDFCGO, HMINPDBHLLB LHADPJODGJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x643A5C0", Offset = "0x64397C0", VA = "0x18643A5C0", Slot = "4")]
	public override bool DMDKHAOOBDK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class CHKCCBKDAIN : NCJHEEOPOGO<HMINPDBHLLB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly CHLFBGGBBLE OCJHCMFNKCP;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6439FE0", Offset = "0x64391E0", VA = "0x186439FE0")]
	public CHKCCBKDAIN(bool BCPBLECOLGA, bool NCANHGDFCGO, HMINPDBHLLB LHADPJODGJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6439F90", Offset = "0x6439190", VA = "0x186439F90", Slot = "4")]
	public override bool DMDKHAOOBDK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public interface OIPJGKMJAKL
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DMDKHAOOBDK([In] MOMAFPBOGDB HMNLMCLNGOP);
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class AJOMPMGPDBB : NCJHEEOPOGO<OIPJGKMJAKL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly MOMAFPBOGDB HMNLMCLNGOP;

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6439DB0", Offset = "0x6438FB0", VA = "0x186439DB0")]
	public AJOMPMGPDBB(Guid[] MKDHMCOKKHN, Vector3[] BFGEHOMOBBA, Quaternion[] JLGOCKAACEC, float[] CLMONHGDDNI, Dictionary<Guid, Vector3> KFNLNFDCMLB, OIPJGKMJAKL LHADPJODGJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6439D00", Offset = "0x6438F00", VA = "0x186439D00", Slot = "4")]
	public override bool DMDKHAOOBDK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public interface BBKHGCMHJPK<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PBGKKLGOEBM([In] LIMOFNPACGP<TData> JFOAMFMCPFP);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool AJECOLDIGPA([In] ILEFNOLADNH NIHNKIGOCKL);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool AJECOLDIGPA([In] JDCEPPMNICH NIHNKIGOCKL);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool KNNHGPLDMEM();
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class IMPJPHLGAJL<TData> : NCJHEEOPOGO<BBKHGCMHJPK<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x355E660", Offset = "0x355D860", VA = "0x18355E660")]
	public IMPJPHLGAJL(BBKHGCMHJPK<TData> LHADPJODGJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3B27DF0", Offset = "0x3B26FF0", VA = "0x183B27DF0", Slot = "4")]
	public override bool DMDKHAOOBDK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class KABKCFJIKBB<TData> : NCJHEEOPOGO<BBKHGCMHJPK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly ILEFNOLADNH ACEKDMPAFMA;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3E2BF00", Offset = "0x3E2B100", VA = "0x183E2BF00")]
	public KABKCFJIKBB(Vector3 HKCDPMHBCAL, bool HBPINFFILEO, BBKHGCMHJPK<TData> LHADPJODGJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x3981520", Offset = "0x3980720", VA = "0x183981520", Slot = "4")]
	public override bool DMDKHAOOBDK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class JABPNOGMCCK<TData> : NCJHEEOPOGO<BBKHGCMHJPK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly JDCEPPMNICH ACEKDMPAFMA;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x3CDCD40", Offset = "0x3CDBF40", VA = "0x183CDCD40")]
	public JABPNOGMCCK(Guid CHKINLHKELD, int PMNHOLIPOMJ, Vector3 CAOOPLKANIG, Quaternion JCCMNAMJFGM, float HMEOAAPKBEC, bool HBPINFFILEO, BBKHGCMHJPK<TData> LHADPJODGJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x3CDCCE0", Offset = "0x3CDBEE0", VA = "0x183CDCCE0", Slot = "4")]
	public override bool DMDKHAOOBDK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class IKOECGOMIFG<TData> : NCJHEEOPOGO<BBKHGCMHJPK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly LIMOFNPACGP<TData> ACEKDMPAFMA;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x3B20200", Offset = "0x3B1F400", VA = "0x183B20200")]
	public IKOECGOMIFG(TData FMEDEJNEJHJ, bool NCANHGDFCGO, BBKHGCMHJPK<TData> LHADPJODGJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x3902FB0", Offset = "0x39021B0", VA = "0x183902FB0", Slot = "4")]
	public override bool DMDKHAOOBDK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public struct ILEFNOLADNH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly Vector3 HKCDPMHBCAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public readonly bool HBPINFFILEO;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x643A6E0", Offset = "0x64398E0", VA = "0x18643A6E0")]
	public ILEFNOLADNH(Vector3 HKCDPMHBCAL, bool HBPINFFILEO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public struct JDCEPPMNICH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public readonly Guid CHKINLHKELD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public readonly int PMNHOLIPOMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public readonly Vector3 CAOOPLKANIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public readonly Quaternion JCCMNAMJFGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public readonly float HMEOAAPKBEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public readonly bool HBPINFFILEO;

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x643AAD0", Offset = "0x6439CD0", VA = "0x18643AAD0")]
	public JDCEPPMNICH(Guid CHKINLHKELD, int PMNHOLIPOMJ, Vector3 CAOOPLKANIG, Quaternion JCCMNAMJFGM, float HMEOAAPKBEC, bool HBPINFFILEO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public struct LIMOFNPACGP<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public readonly TData FMEDEJNEJHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public readonly bool NCANHGDFCGO;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x3F57830", Offset = "0x3F56A30", VA = "0x183F57830")]
	public LIMOFNPACGP(TData FMEDEJNEJHJ, bool NCANHGDFCGO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public interface ONPAFELDFBC<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DMDKHAOOBDK([In] PHIJFKIBANN<TData> KPHCMCMCMDG);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DMDKHAOOBDK([In] OHOFBDHDOED<TData> KPHCMCMCMDG);
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public interface OGJMDDKKOCE<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PBGKKLGOEBM([In] CJGNJMPLKNF<TData> CCODKHGNPID);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool AJECOLDIGPA([In] BFIGFACGMKO NIHNKIGOCKL);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KNNHGPLDMEM();
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class PBENMKGHALH<TData> : NCJHEEOPOGO<ONPAFELDFBC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly PHIJFKIBANN<TData> KPHCMCMCMDG;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x43A0280", Offset = "0x439F480", VA = "0x1843A0280")]
	public PBENMKGHALH(IEnumerable<TData> JNKNIGGBIIN, Vector3 GOFEJNIIHDH, bool NCANHGDFCGO, ONPAFELDFBC<TData> LHADPJODGJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x3902FB0", Offset = "0x39021B0", VA = "0x183902FB0", Slot = "4")]
	public override bool DMDKHAOOBDK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class MPIIPLGKIPI<TData> : NCJHEEOPOGO<OGJMDDKKOCE<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x355E660", Offset = "0x355D860", VA = "0x18355E660")]
	public MPIIPLGKIPI(OGJMDDKKOCE<TData> LHADPJODGJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x3EC3610", Offset = "0x3EC2810", VA = "0x183EC3610", Slot = "4")]
	public override bool DMDKHAOOBDK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class GIAMEGCCPPP<TData> : NCJHEEOPOGO<OGJMDDKKOCE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly CJGNJMPLKNF<TData> KPHCMCMCMDG;

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x39D4FE0", Offset = "0x39D41E0", VA = "0x1839D4FE0")]
	public GIAMEGCCPPP(IEnumerable<TData> JNKNIGGBIIN, bool NCANHGDFCGO, OGJMDDKKOCE<TData> LHADPJODGJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x3902FB0", Offset = "0x39021B0", VA = "0x183902FB0", Slot = "4")]
	public override bool DMDKHAOOBDK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class GNCNJALDMPI<TData> : NCJHEEOPOGO<ONPAFELDFBC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly OHOFBDHDOED<TData> KPHCMCMCMDG;

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x39E35A0", Offset = "0x39E27A0", VA = "0x1839E35A0")]
	public GNCNJALDMPI(IEnumerable<TData> JNKNIGGBIIN, Vector3 FOFFOLHPDNF, MPCLBFIJPHB DFFCJANLHIP, bool NCANHGDFCGO, ONPAFELDFBC<TData> LHADPJODGJC, Space BJNLKKBNEON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x39E34E0", Offset = "0x39E26E0", VA = "0x1839E34E0", Slot = "4")]
	public override bool DMDKHAOOBDK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class AACDAGHJEOO<TData> : NCJHEEOPOGO<OGJMDDKKOCE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly BFIGFACGMKO KPHCMCMCMDG;

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x3981580", Offset = "0x3980780", VA = "0x183981580")]
	public AACDAGHJEOO(Vector3 GOFEJNIIHDH, OGJMDDKKOCE<TData> LHADPJODGJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x3981520", Offset = "0x3980720", VA = "0x183981520", Slot = "4")]
	public override bool DMDKHAOOBDK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct PHIJFKIBANN<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public readonly IEnumerable<TData> JNKNIGGBIIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public readonly Vector3 GOFEJNIIHDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public readonly bool NCANHGDFCGO;

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x43B2520", Offset = "0x43B1720", VA = "0x1843B2520")]
	public PHIJFKIBANN(IEnumerable<TData> JNKNIGGBIIN, Vector3 GOFEJNIIHDH, bool NCANHGDFCGO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct CJGNJMPLKNF<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public readonly IEnumerable<TData> JNKNIGGBIIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public readonly bool NCANHGDFCGO;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x505CB40", Offset = "0x505BD40", VA = "0x18505CB40")]
	public CJGNJMPLKNF(IEnumerable<TData> JNKNIGGBIIN, bool NCANHGDFCGO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct OHOFBDHDOED<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public readonly IEnumerable<TData> JNKNIGGBIIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public readonly Vector3 FOFFOLHPDNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly MPCLBFIJPHB DFFCJANLHIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public readonly bool NCANHGDFCGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly Space BJNLKKBNEON;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x4296260", Offset = "0x4295460", VA = "0x184296260")]
	public OHOFBDHDOED(IEnumerable<TData> JNKNIGGBIIN, Vector3 FOFFOLHPDNF, MPCLBFIJPHB DFFCJANLHIP, bool NCANHGDFCGO, Space BJNLKKBNEON)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct BFIGFACGMKO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public readonly Vector3 GOFEJNIIHDH;

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x205C070", Offset = "0x205B270", VA = "0x18205C070")]
	public BFIGFACGMKO(Vector3 GOFEJNIIHDH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public enum MPCLBFIJPHB
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
public interface LIGIGGLEJPD
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DMDKHAOOBDK([In] ABCBAHIJIBI EOCPGJIPJHH);
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public class JJCAMJEPDJC : NCJHEEOPOGO<LIGIGGLEJPD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly ABCBAHIJIBI EOCPGJIPJHH;

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x643ABC0", Offset = "0x6439DC0", VA = "0x18643ABC0")]
	public JJCAMJEPDJC(bool NCANHGDFCGO, LIGIGGLEJPD LHADPJODGJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x643AB10", Offset = "0x6439D10", VA = "0x18643AB10", Slot = "4")]
	public override bool DMDKHAOOBDK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public readonly struct ABCBAHIJIBI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public readonly bool NCANHGDFCGO;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0xD65FE0", Offset = "0xD651E0", VA = "0x180D65FE0")]
	public ABCBAHIJIBI(bool NCANHGDFCGO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public interface NJMCAIPDEKL<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DMDKHAOOBDK([In] BOJKDJGMBOG<TData> ENPCKJNDOJI);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DMDKHAOOBDK([In] MFJJANBFALH<TData> ENPCKJNDOJI);
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public interface PEAAJADHKLO<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PBGKKLGOEBM([In] FANGHADIMEE<TData> JFOAMFMCPFP);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool AJECOLDIGPA([In] BJJJBMMLJFI NIHNKIGOCKL);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KNNHGPLDMEM();
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class CKFHAKEGNKO<TData> : NCJHEEOPOGO<NJMCAIPDEKL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly BOJKDJGMBOG<TData> ENPCKJNDOJI;

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x505F0C0", Offset = "0x505E2C0", VA = "0x18505F0C0")]
	public CKFHAKEGNKO(IEnumerable<TData> JNKNIGGBIIN, Quaternion GOFEJNIIHDH, Vector3? HBDJFFKGPLM, bool FFNICIFPIDK, bool NCANHGDFCGO, NJMCAIPDEKL<TData> LHADPJODGJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x3902FB0", Offset = "0x39021B0", VA = "0x183902FB0", Slot = "4")]
	public override bool DMDKHAOOBDK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class KOKIMENLMMH<TData> : NCJHEEOPOGO<PEAAJADHKLO<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x355E660", Offset = "0x355D860", VA = "0x18355E660")]
	public KOKIMENLMMH(PEAAJADHKLO<TData> LHADPJODGJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x3EC3610", Offset = "0x3EC2810", VA = "0x183EC3610", Slot = "4")]
	public override bool DMDKHAOOBDK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class MCNFIGGGDEM<TData> : NCJHEEOPOGO<PEAAJADHKLO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly FANGHADIMEE<TData> ENPCKJNDOJI;

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x412EDC0", Offset = "0x412DFC0", VA = "0x18412EDC0")]
	public MCNFIGGGDEM(IEnumerable<TData> JNKNIGGBIIN, bool NCANHGDFCGO, PEAAJADHKLO<TData> LHADPJODGJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x3902FB0", Offset = "0x39021B0", VA = "0x183902FB0", Slot = "4")]
	public override bool DMDKHAOOBDK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class DBMFPEJKLKA<TData> : NCJHEEOPOGO<NJMCAIPDEKL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly MFJJANBFALH<TData> ENPCKJNDOJI;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x531EF30", Offset = "0x531E130", VA = "0x18531EF30")]
	public DBMFPEJKLKA(IEnumerable<TData> JNKNIGGBIIN, Quaternion BBNIHMHOFKE, MPCLBFIJPHB AEOJHEBJHGP, Vector3? HBDJFFKGPLM, bool FFNICIFPIDK, bool NCANHGDFCGO, Space BJNLKKBNEON, NJMCAIPDEKL<TData> LHADPJODGJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x39E34E0", Offset = "0x39E26E0", VA = "0x1839E34E0", Slot = "4")]
	public override bool DMDKHAOOBDK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class MFFOJCPKFAE<TData> : NCJHEEOPOGO<PEAAJADHKLO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly BJJJBMMLJFI ENPCKJNDOJI;

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x4131440", Offset = "0x4130640", VA = "0x184131440")]
	public MFFOJCPKFAE(Quaternion GOFEJNIIHDH, Vector3? HBDJFFKGPLM, bool FFNICIFPIDK, PEAAJADHKLO<TData> LHADPJODGJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x3981520", Offset = "0x3980720", VA = "0x183981520", Slot = "4")]
	public override bool DMDKHAOOBDK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public struct BOJKDJGMBOG<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public readonly IEnumerable<TData> JNKNIGGBIIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public readonly Quaternion GOFEJNIIHDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public readonly Vector3? HBDJFFKGPLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public readonly bool FFNICIFPIDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public readonly bool NCANHGDFCGO;

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x4BF3420", Offset = "0x4BF2620", VA = "0x184BF3420")]
	public BOJKDJGMBOG(IEnumerable<TData> JNKNIGGBIIN, Quaternion GOFEJNIIHDH, Vector3? HBDJFFKGPLM, bool FFNICIFPIDK, bool NCANHGDFCGO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public struct FANGHADIMEE<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public readonly IEnumerable<TData> JNKNIGGBIIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly bool NCANHGDFCGO;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x38E5A30", Offset = "0x38E4C30", VA = "0x1838E5A30")]
	public FANGHADIMEE(IEnumerable<TData> JNKNIGGBIIN, bool NCANHGDFCGO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public struct MFJJANBFALH<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public readonly IEnumerable<TData> JNKNIGGBIIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public readonly Quaternion BBNIHMHOFKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public readonly MPCLBFIJPHB AEOJHEBJHGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public readonly Vector3? HBDJFFKGPLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public readonly bool FFNICIFPIDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public readonly bool NCANHGDFCGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public readonly Space BJNLKKBNEON;

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x4131650", Offset = "0x4130850", VA = "0x184131650")]
	public MFJJANBFALH(IEnumerable<TData> JNKNIGGBIIN, Quaternion BBNIHMHOFKE, MPCLBFIJPHB AEOJHEBJHGP, Vector3? HBDJFFKGPLM, bool FFNICIFPIDK, bool NCANHGDFCGO, Space BJNLKKBNEON)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public struct BJJJBMMLJFI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public readonly Quaternion GOFEJNIIHDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public readonly Vector3? HBDJFFKGPLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public readonly bool FFNICIFPIDK;

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x4884F90", Offset = "0x4884190", VA = "0x184884F90")]
	public BJJJBMMLJFI(Quaternion GOFEJNIIHDH, Vector3? HBDJFFKGPLM, bool FFNICIFPIDK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public interface CDCACANHFDI<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PBGKKLGOEBM([In] HLCFLGFHNNO<TData> JFOAMFMCPFP);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool AJECOLDIGPA([In] IEPBNIJNDHM NIHNKIGOCKL);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool AJECOLDIGPA([In] DKJHFKFHMEE NIHNKIGOCKL);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool AJECOLDIGPA([In] GPOLPJBDKPF NIHNKIGOCKL);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool KNNHGPLDMEM();
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public class NLIEELJDLCA<TData> : NCJHEEOPOGO<CDCACANHFDI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly GPOLPJBDKPF NKJCBFKCBNF;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x41BDFF0", Offset = "0x41BD1F0", VA = "0x1841BDFF0")]
	public NLIEELJDLCA(Vector3 HJNGKEEOGLK, float ONKBHOLJPKL, Vector3 HBDJFFKGPLM, bool NEANPIJNGAK, bool GNLLJNHAHIP, CDCACANHFDI<TData> LHADPJODGJC, Space BJNLKKBNEON = Space.Self)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x41BDF90", Offset = "0x41BD190", VA = "0x1841BDF90", Slot = "4")]
	public override bool DMDKHAOOBDK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public class FBAGMOBAOHF<TData> : NCJHEEOPOGO<CDCACANHFDI<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x355E660", Offset = "0x355D860", VA = "0x18355E660")]
	public FBAGMOBAOHF(CDCACANHFDI<TData> LHADPJODGJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x38E6030", Offset = "0x38E5230", VA = "0x1838E6030", Slot = "4")]
	public override bool DMDKHAOOBDK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class HPOBHFAGPPP<TData> : NCJHEEOPOGO<CDCACANHFDI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly HLCFLGFHNNO<TData> NKJCBFKCBNF;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x3A5ED50", Offset = "0x3A5DF50", VA = "0x183A5ED50")]
	public HPOBHFAGPPP(IEnumerable<TData> JNKNIGGBIIN, bool NCANHGDFCGO, CDCACANHFDI<TData> LHADPJODGJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x3902FB0", Offset = "0x39021B0", VA = "0x183902FB0", Slot = "4")]
	public override bool DMDKHAOOBDK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class BBDFKNDIOHD<TData> : NCJHEEOPOGO<CDCACANHFDI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly DKJHFKFHMEE NKJCBFKCBNF;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x4A45170", Offset = "0x4A44370", VA = "0x184A45170")]
	public BBDFKNDIOHD(float HGJMMOJLPML, bool JADPAKEAOEP, Vector3 HBDJFFKGPLM, CDCACANHFDI<TData> LHADPJODGJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x4A450B0", Offset = "0x4A442B0", VA = "0x184A450B0", Slot = "4")]
	public override bool DMDKHAOOBDK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class DMADKAPGAEI<TData> : NCJHEEOPOGO<CDCACANHFDI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly IEPBNIJNDHM NKJCBFKCBNF;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x5347D50", Offset = "0x5346F50", VA = "0x185347D50")]
	public DMADKAPGAEI(float ONKBHOLJPKL, Vector3 HBDJFFKGPLM, CDCACANHFDI<TData> LHADPJODGJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x3981520", Offset = "0x3980720", VA = "0x183981520", Slot = "4")]
	public override bool DMDKHAOOBDK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public struct GPOLPJBDKPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public readonly Vector3 HJNGKEEOGLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public readonly float ONKBHOLJPKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public readonly Vector3 HBDJFFKGPLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public readonly bool HBPINFFILEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public readonly Space BJNLKKBNEON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public readonly bool GNLLJNHAHIP;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x643A6A0", Offset = "0x64398A0", VA = "0x18643A6A0")]
	public GPOLPJBDKPF(Vector3 HJNGKEEOGLK, float ONKBHOLJPKL, Vector3 HBDJFFKGPLM, bool HBPINFFILEO, bool NBJBODLBKFP, Space BJNLKKBNEON = Space.Self)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public struct HLCFLGFHNNO<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public readonly IEnumerable<TData> JNKNIGGBIIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public readonly bool NCANHGDFCGO;

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x3A49880", Offset = "0x3A48A80", VA = "0x183A49880")]
	public HLCFLGFHNNO(IEnumerable<TData> JNKNIGGBIIN, bool NCANHGDFCGO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct DKJHFKFHMEE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public readonly float HGJMMOJLPML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public readonly bool JADPAKEAOEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public readonly Vector3 HBDJFFKGPLM;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x643A070", Offset = "0x6439270", VA = "0x18643A070")]
	public DKJHFKFHMEE(float HGJMMOJLPML, bool JADPAKEAOEP, Vector3 HBDJFFKGPLM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public struct IEPBNIJNDHM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public readonly float ONKBHOLJPKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public readonly Vector3 HBDJFFKGPLM;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x483CBA0", Offset = "0x483BDA0", VA = "0x18483CBA0")]
	public IEPBNIJNDHM(float ONKBHOLJPKL, Vector3 HBDJFFKGPLM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct MOMAFPBOGDB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public readonly Guid[] JNKNIGGBIIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public readonly bool KGKFBIKPBDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public readonly bool PNJLDNNJFFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public readonly bool KCIDBILLPNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public readonly Vector3[] BFGEHOMOBBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public readonly Quaternion[] JLGOCKAACEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly float[] CLMONHGDDNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public readonly Dictionary<Guid, Vector3> KFNLNFDCMLB;

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x643AF50", Offset = "0x643A150", VA = "0x18643AF50")]
	public MOMAFPBOGDB(Guid[] MKDHMCOKKHN, Vector3[] BFGEHOMOBBA, Quaternion[] JLGOCKAACEC, float[] CLMONHGDDNI, Dictionary<Guid, Vector3> KFNLNFDCMLB, bool KGKFBIKPBDE = true, bool PNJLDNNJFFI = true, bool KCIDBILLPNH = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x643AD80", Offset = "0x6439F80", VA = "0x18643AD80")]
	private static void BPEBLJOMHCN(Dictionary<Guid, Vector3> KFNLNFDCMLB, int PBEHFOMNEFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public static class IMJDPAPDHJJ
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	private struct GKPFLPPDJGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public bool CJCALDHOAFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public EHGDBDLIOFB OLAKLAJIBMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public EHGDBDLIOFB FFOLBHNHPII;
	}

	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private static GKPFLPPDJGP JMPCJEALKKE;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static CancellationToken OAHBNCBFAHC
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x643A9B0", Offset = "0x6439BB0", VA = "0x18643A9B0")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	internal static EHGDBDLIOFB OLAKLAJIBMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x643A700", Offset = "0x6439900", VA = "0x18643A700")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x643A940", Offset = "0x6439B40", VA = "0x18643A940")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x643A9D0", Offset = "0x6439BD0", VA = "0x18643A9D0")]
	[JIMPHGEJKMA(NFKMIHJOIMG.Room, CLDBMEKPFFP.None)]
	private static void IKGBAOHJGCA(EHGDBDLIOFB NMNJDOEPKNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x643A7F0", Offset = "0x64399F0", VA = "0x18643A7F0")]
	public static void CFPPHLPBNAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x643A7A0", Offset = "0x64399A0", VA = "0x18643A7A0")]
	private static EHGDBDLIOFB BJOMEIHFDDP(EHGDBDLIOFB OLJBABBKGFK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public static class LJDAHPJLAAD
{
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public enum NMALECHMJHK
	{
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		ICreationContextObject,
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		Guid
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x2A360B0", Offset = "0x2A352B0", VA = "0x182A360B0")]
	public static void DILJLHIAKJI<T>(T PNLOKOBAKEP, NMALECHMJHK HHJOOHJDNNM) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x2A36050", Offset = "0x2A35250", VA = "0x182A36050")]
	public static void DILJLHIAKJI<T>(T PNLOKOBAKEP) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x2A361F0", Offset = "0x2A353F0", VA = "0x182A361F0")]
	public static void HBGEDFELOOI<T>(T PNLOKOBAKEP) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x2A36260", Offset = "0x2A35460", VA = "0x182A36260")]
	public static T JIBGFLOLNJM<T>(NMALECHMJHK HHJOOHJDNNM) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x2A35F20", Offset = "0x2A35120", VA = "0x182A35F20")]
	public static bool AAGKBFDKAOO<T>(NMALECHMJHK HHJOOHJDNNM, T ACGGLAPBHJC, [Out] T JOAEADMDDKA) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x2A36340", Offset = "0x2A35540", VA = "0x182A36340")]
	public static bool KHKAOJINPDH<T>(NMALECHMJHK HHJOOHJDNNM) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x2A36300", Offset = "0x2A35500", VA = "0x182A36300")]
	public static T JIBGFLOLNJM<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x2A35E80", Offset = "0x2A35080", VA = "0x182A35E80")]
	public static bool AAGKBFDKAOO<T>(T ACGGLAPBHJC, [Out] T JOAEADMDDKA) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x2A36300", Offset = "0x2A35500", VA = "0x182A36300")]
	public static bool KHKAOJINPDH<T>() where T : class
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
internal static class FCPPBNLBFLA
{
	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x643A370", Offset = "0x6439570", VA = "0x18643A370")]
	public static void ACPMHCOGPFK(IEnumerable JMADLIHGBBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x294EEC0", Offset = "0x294E0C0", VA = "0x18294EEC0")]
	public static void ACPMHCOGPFK<T>(T[] HPGKNFECNHG) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x294EFB0", Offset = "0x294E1B0", VA = "0x18294EFB0")]
	public static void ACPMHCOGPFK<T>(T GAPFLOIFLPD) where T : notnull, Enum
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
