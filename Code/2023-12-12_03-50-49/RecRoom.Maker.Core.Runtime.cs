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
		[Cpp2IlInjected.Address(RVA = "0x79C400", Offset = "0x79AC00", VA = "0x18079C400")]
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
		[Cpp2IlInjected.Address(RVA = "0x5E39950", Offset = "0x5E38150", VA = "0x185E39950")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x79CCC0", Offset = "0x79B4C0", VA = "0x18079CCC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x79CD00", Offset = "0x79B500", VA = "0x18079CD00")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface PICAOMPBHDP<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ClearHoverTarget(DOOAAHEHOJN OEJJNNELIDK);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool SetHoverTarget(TData MAKBFCPADHF, Collider DNBKKOLJEPA, DOOAAHEHOJN OEJJNNELIDK, [Optional] OECNPGLBOAO? CLHGADOPHPJ);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool TryGetHoverTarget([Out] TData MAKBFCPADHF);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface DPDBGJACDKL<TData> : IMCOBHHDPMF, OMONCMALCNK<TData>, DELKDMBDLMJ<TData>, IDAFHGHHEIG<TData>, FPJPHMMLDIJ, OCGDMEMPJAI<TData>, IIJGPEOEEBM, HCODGIADGGK
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface OCGDMEMPJAI<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 LNINLMPACDM, Vector3 HDJKLLNHJHP, float EMBKCPDDBCB, [Out] T GAGGBEHAMHB, [Out] Vector3 DLAFKMHPLDL, [Out] Collider DNBKKOLJEPA);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 LNINLMPACDM, Vector3 HDJKLLNHJHP, float CJPDBJDBLLJ, float EMBKCPDDBCB, T[] AOBHBAGHBFN, [Out] Vector3 HLIBBMICJFD, [Out] Collider DCFFDJDCMGH);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 LNINLMPACDM, float CJPDBJDBLLJ, Vector3 NCPFAILKPON, T[] AOBHBAGHBFN);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface IMCOBHHDPMF
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Bounds ANACFAENDNI
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Transform OIHBCNBMNGL
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Bounds EBDIPJNAFHB
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Transform PGJIJCBCMCM
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Vector3 OJGDFAGIFAF
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void SetSelectionBoundsDirty(bool BCIAPKHOCHM = true, int AIEEBPNIBKB = 0);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ShouldHideSelectionBoundsPreview(bool BDOOAJABHAL, object JECMOKMEJED);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface HCODGIADGGK
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	LJECGABKDKN BEIKDMNKFOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface IDAFHGHHEIG<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool BOOBMOLFDCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	int HIECLOMLDID
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	IEnumerable<TData> KHFMOOFOEKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData BPGGEPDHIDJ);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData BPGGEPDHIDJ);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface OMONCMALCNK<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T BEKFGDCEJDH, [Optional] OECNPGLBOAO? LOFOCAHJJCH, bool MHCKDONHNBO = true);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int PPKDCOOCBKP, IEnumerable<T> GPLKMEDKCNA, bool MHCKDONHNBO = true);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int PPKDCOOCBKP, IEnumerable<T> GPLKMEDKCNA, OECNPGLBOAO LOFOCAHJJCH, bool MHCKDONHNBO = true);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface IIJGPEOEEBM
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface FPJPHMMLDIJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool DOIGGEPGKNE
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool BMBFEJNHDLM
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool DFBGIEPLGMN
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool MLPAEIHOONA
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class NDPCHFEFDNA<TReceiver> : HHDKGJFCHAG<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x30FBF80", Offset = "0x30FA780", VA = "0x1830FBF80")]
	public NDPCHFEFDNA(TReceiver ALHPLCFGAFB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public abstract class AKMLKJHMAIA<TReceiver, TFromTask> : HHDKGJFCHAG<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x30FBF80", Offset = "0x30FA780", VA = "0x1830FBF80")]
	public AKMLKJHMAIA(TReceiver ALHPLCFGAFB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class HHDKGJFCHAG<TReceiver, TFromExecute> where TReceiver : notnull where TFromExecute : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	protected TReceiver ALHPLCFGAFB;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x359C5F0", Offset = "0x359ADF0", VA = "0x18359C5F0")]
	public HHDKGJFCHAG(TReceiver ALHPLCFGAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute GEGMGBLEPCF();
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class IAHCJFHFIGB<TReceiver, TResult> : HHDKGJFCHAG<TReceiver, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x30FBF80", Offset = "0x30FA780", VA = "0x1830FBF80")]
	public IAHCJFHFIGB(TReceiver ALHPLCFGAFB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct HHGEGMGBFDJ<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public TGroup EHMOGDIKHKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public TData LKIDMJDIJKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public IEnumerable<TData> FBDCMOLPPJC;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x19B1780", Offset = "0x19AFF80", VA = "0x1819B1780")]
	public HHGEGMGBFDJ(TGroup NCEBMIEFCLJ, TData HCMGIBECNMH, IEnumerable<TData> HPEIGDGIAOC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct HGPMLIPOKHH<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public TGroup EHMOGDIKHKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public IEnumerable<TData> FBDCMOLPPJC;

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8384B0", Offset = "0x836CB0", VA = "0x1808384B0")]
	public HGPMLIPOKHH(TGroup NCEBMIEFCLJ, IEnumerable<TData> HPEIGDGIAOC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct LLLJPOCHPNE<TGroup> where TGroup : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public TGroup EHMOGDIKHKO;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x873730", Offset = "0x871F30", VA = "0x180873730")]
	public LLLJPOCHPNE(TGroup NCEBMIEFCLJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct IBFMCMEPGJI<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public IEnumerable<TData> FBDCMOLPPJC;

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x873730", Offset = "0x871F30", VA = "0x180873730")]
	public IBFMCMEPGJI(IEnumerable<TData> HPEIGDGIAOC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface FBDKDCHGIHB<TGroup, TData>
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GBHPOFKIHBL MANDILDMHKE(HHGEGMGBFDJ<TGroup, TData> KBIGHBJOABD);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GBHPOFKIHBL EBCJOPOCMAD(HHGEGMGBFDJ<TGroup, TData> KBIGHBJOABD);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GBHPOFKIHBL AILLEMHPNGM(HGPMLIPOKHH<TGroup, TData> KBIGHBJOABD);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GBHPOFKIHBL DLNCICLFEBH(LLLJPOCHPNE<TGroup> KBIGHBJOABD);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface HFFFAAMDHCA<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<GBHPOFKIHBL> MANDILDMHKE(IBFMCMEPGJI<TData> KBIGHBJOABD);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class NIEHFBHONPJ<TGroup, TData> : IAHCJFHFIGB<FBDKDCHGIHB<TGroup, TData>, GBHPOFKIHBL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly HGPMLIPOKHH<TGroup, TData> KBIGHBJOABD;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3D27540", Offset = "0x3D25D40", VA = "0x183D27540")]
	public NIEHFBHONPJ(TGroup NCEBMIEFCLJ, IEnumerable<TData> HPEIGDGIAOC, FBDKDCHGIHB<TGroup, TData> ALHPLCFGAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3D27470", Offset = "0x3D25C70", VA = "0x183D27470", Slot = "4")]
	public override GBHPOFKIHBL GEGMGBLEPCF()
	{
		return default(GBHPOFKIHBL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class EDNGLNLJDBB<TGroup, TData> : IAHCJFHFIGB<FBDKDCHGIHB<TGroup, TData>, GBHPOFKIHBL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly HHGEGMGBFDJ<TGroup, TData> KBIGHBJOABD;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x30FAA20", Offset = "0x30F9220", VA = "0x1830FAA20")]
	public EDNGLNLJDBB(TGroup NCEBMIEFCLJ, TData DMOJGECCLEB, IEnumerable<TData> HPEIGDGIAOC, FBDKDCHGIHB<TGroup, TData> ALHPLCFGAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x30FA940", Offset = "0x30F9140", VA = "0x1830FA940", Slot = "4")]
	public override GBHPOFKIHBL GEGMGBLEPCF()
	{
		return default(GBHPOFKIHBL);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class FDBINKOKJIG<TGroup, TData> : IAHCJFHFIGB<FBDKDCHGIHB<TGroup, TData>, GBHPOFKIHBL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly LLLJPOCHPNE<TGroup> KBIGHBJOABD;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3452B50", Offset = "0x3451350", VA = "0x183452B50")]
	public FDBINKOKJIG(TGroup NCEBMIEFCLJ, FBDKDCHGIHB<TGroup, TData> ALHPLCFGAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3452A80", Offset = "0x3451280", VA = "0x183452A80", Slot = "4")]
	public override GBHPOFKIHBL GEGMGBLEPCF()
	{
		return default(GBHPOFKIHBL);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class AAKEMBCKNCB<TGroup, TData> : IAHCJFHFIGB<FBDKDCHGIHB<TGroup, TData>, GBHPOFKIHBL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly HHGEGMGBFDJ<TGroup, TData> KBIGHBJOABD;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x30FAA20", Offset = "0x30F9220", VA = "0x1830FAA20")]
	public AAKEMBCKNCB(TGroup NCEBMIEFCLJ, TData HCMGIBECNMH, IEnumerable<TData> HPEIGDGIAOC, FBDKDCHGIHB<TGroup, TData> ALHPLCFGAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x34EFBC0", Offset = "0x34EE3C0", VA = "0x1834EFBC0", Slot = "4")]
	public override GBHPOFKIHBL GEGMGBLEPCF()
	{
		return default(GBHPOFKIHBL);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class DFCIDCCFBPL<TData> : AKMLKJHMAIA<HFFFAAMDHCA<TData>, GBHPOFKIHBL> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct GKAJGHOOICI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AsyncTaskMethodBuilder<GBHPOFKIHBL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public DFCIDCCFBPL<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private TaskAwaiter<GBHPOFKIHBL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3523380", Offset = "0x3521B80", VA = "0x183523380", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3523620", Offset = "0x3521E20", VA = "0x183523620", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private IBFMCMEPGJI<TData> KBIGHBJOABD;

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3452B50", Offset = "0x3451350", VA = "0x183452B50")]
	public DFCIDCCFBPL(IEnumerable<TData> BKGHBFKAEFH, HFFFAAMDHCA<TData> ALHPLCFGAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4DD1EE0", Offset = "0x4DD06E0", VA = "0x184DD1EE0", Slot = "4")]
	[AsyncStateMachine(typeof(DFCIDCCFBPL<>.GKAJGHOOICI))]
	public override Task<GBHPOFKIHBL> GEGMGBLEPCF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct HNCAIHEFPIA<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public TNode MFJOLFFOKJE;

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x35CB780", Offset = "0x35C9F80", VA = "0x1835CB780")]
	public HNCAIHEFPIA(TNode MFJOLFFOKJE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct GGPFHBNOENE<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public TNode CMPPIJCIHCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public BLGPBFCPLML MJMOHDIDGCD;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x351C5C0", Offset = "0x351ADC0", VA = "0x18351C5C0")]
	public GGPFHBNOENE(TNode CMPPIJCIHCA, BLGPBFCPLML MJMOHDIDGCD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface HLIGCKBPMJO<TNode>
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NCGPAAGHNNN([In] HNCAIHEFPIA<TNode> JMGDIAIJNIK);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DKDLADICFOO([In] GGPFHBNOENE<TNode> HCHCLBMHFND);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LICLOJGNNPO();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class GALGKMEILLK<TNode> : NDPCHFEFDNA<HLIGCKBPMJO<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x30FBF80", Offset = "0x30FA780", VA = "0x1830FBF80")]
	public GALGKMEILLK(HLIGCKBPMJO<TNode> ALHPLCFGAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x35144E0", Offset = "0x3512CE0", VA = "0x1835144E0", Slot = "4")]
	public override bool GEGMGBLEPCF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class AAFCPACGGNH<TNode> : NDPCHFEFDNA<HLIGCKBPMJO<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly GGPFHBNOENE<TNode> HCHCLBMHFND;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x34EECA0", Offset = "0x34ED4A0", VA = "0x1834EECA0")]
	public AAFCPACGGNH(TNode CMPPIJCIHCA, BLGPBFCPLML MJMOHDIDGCD, HLIGCKBPMJO<TNode> ALHPLCFGAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x34EEBD0", Offset = "0x34ED3D0", VA = "0x1834EEBD0", Slot = "4")]
	public override bool GEGMGBLEPCF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class MBOABMCPNJM<TNode> : NDPCHFEFDNA<HLIGCKBPMJO<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly HNCAIHEFPIA<TNode> JMGDIAIJNIK;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3C466C0", Offset = "0x3C44EC0", VA = "0x183C466C0")]
	public MBOABMCPNJM(TNode GFCDAGJCMAK, HLIGCKBPMJO<TNode> ALHPLCFGAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x31083A0", Offset = "0x3106BA0", VA = "0x1831083A0", Slot = "4")]
	public override bool GEGMGBLEPCF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct BMHMLECFCDM<TSpawnInfo> where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public TSpawnInfo ANEMKMMLIAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public Vector3 FLFCGPFDCMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public Quaternion JOBDANNFLEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public float AMKKNHFCFKO;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0xDF2560", Offset = "0xDF0D60", VA = "0x180DF2560")]
	public BMHMLECFCDM(TSpawnInfo ANEMKMMLIAL, Vector3 FLFCGPFDCMD, Quaternion JOBDANNFLEE, float AMKKNHFCFKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface GICOBFMBIML<TSpawnType, TSpawnInfo>
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> MEFENKLJCNA([In] BMHMLECFCDM<TSpawnInfo> FGIOFKHOIMI, CancellationToken GANAOLJLMGA);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class JOKOCOABLEM<TSpawnType, TSpawnInfo> : AKMLKJHMAIA<GICOBFMBIML<TSpawnType, TSpawnInfo>, TSpawnType> where TSpawnType : notnull where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly BMHMLECFCDM<TSpawnInfo> ILIHAHINKGC;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x38B37B0", Offset = "0x38B1FB0", VA = "0x1838B37B0")]
	public JOKOCOABLEM(TSpawnInfo FFFJCJPCIEN, Vector3 FLFCGPFDCMD, Quaternion JOBDANNFLEE, float AMKKNHFCFKO, GICOBFMBIML<TSpawnType, TSpawnInfo> ALHPLCFGAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x38B36D0", Offset = "0x38B1ED0", VA = "0x1838B36D0", Slot = "4")]
	public override Task<TSpawnType> GEGMGBLEPCF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public readonly struct NMGMFICMCPL<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly IEnumerable<TData> FBDCMOLPPJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly bool FBILDFDGIFO;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3D3E530", Offset = "0x3D3CD30", VA = "0x183D3E530")]
	public NMGMFICMCPL(IEnumerable<TData> HPEIGDGIAOC, bool FDBHCCKAJGN = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface LHJGNDBBPND<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<GBHPOFKIHBL> IOPPOBPONEM([In] NMGMFICMCPL<TData> PFOODLPKBPG, CancellationToken GANAOLJLMGA);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class PBMLKBBFGDB<TData> : AKMLKJHMAIA<LHJGNDBBPND<TData>, GBHPOFKIHBL> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly NMGMFICMCPL<TData> GHJJDKHBNLL;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3EE2E60", Offset = "0x3EE1660", VA = "0x183EE2E60")]
	public PBMLKBBFGDB(IEnumerable<TData> HPEIGDGIAOC, bool FDBHCCKAJGN, LHJGNDBBPND<TData> ALHPLCFGAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x38B36D0", Offset = "0x38B1ED0", VA = "0x1838B36D0", Slot = "4")]
	public override Task<GBHPOFKIHBL> GEGMGBLEPCF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct LJMEBGKGGOP<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly T MAKBFCPADHF;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x39D2660", Offset = "0x39D0E60", VA = "0x1839D2660")]
	public LJMEBGKGGOP(T IKANPOGALKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface ACIDIFFIMBA<T>
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NCGPAAGHNNN([In] LJMEBGKGGOP<T> PLPHAGJKJIM);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DKDLADICFOO();
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface KLLEAKIBAEB<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GEGMGBLEPCF([In] KHIAOCHEBDA<T> FFIKLAGIDOE);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public struct KHIAOCHEBDA<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly T MAKBFCPADHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly bool EPLIJPGFBBH;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x38FBE50", Offset = "0x38FA650", VA = "0x1838FBE50")]
	public KHIAOCHEBDA(T IKANPOGALKF, bool LFBIOFMFILL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class CFCDGLCDEII<T> : NDPCHFEFDNA<ACIDIFFIMBA<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x30FBF80", Offset = "0x30FA780", VA = "0x1830FBF80")]
	public CFCDGLCDEII(ACIDIFFIMBA<T> ALHPLCFGAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3CE7440", Offset = "0x3CE5C40", VA = "0x183CE7440", Slot = "4")]
	public override bool GEGMGBLEPCF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class PALIKJBBOFH<T> : NDPCHFEFDNA<ACIDIFFIMBA<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly LJMEBGKGGOP<T> PLPHAGJKJIM;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3ED6470", Offset = "0x3ED4C70", VA = "0x183ED6470")]
	public PALIKJBBOFH(T MAKBFCPADHF, ACIDIFFIMBA<T> ALHPLCFGAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x31083A0", Offset = "0x3106BA0", VA = "0x1831083A0", Slot = "4")]
	public override bool GEGMGBLEPCF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class FBHNNKMEIDG<T> : NDPCHFEFDNA<KLLEAKIBAEB<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly KHIAOCHEBDA<T> FFIKLAGIDOE;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3451C80", Offset = "0x3450480", VA = "0x183451C80")]
	public FBHNNKMEIDG(T MAKBFCPADHF, bool LFBIOFMFILL, KLLEAKIBAEB<T> ALHPLCFGAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x31083A0", Offset = "0x3106BA0", VA = "0x1831083A0", Slot = "4")]
	public override bool GEGMGBLEPCF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct GFLHBDOMADP<TData> where TData : notnull, MMHOCMHBDGD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public IEnumerable<TData> FBDCMOLPPJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public bool KPPGAHKCECN;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x351C260", Offset = "0x351AA60", VA = "0x18351C260")]
	public GFLHBDOMADP(IEnumerable<TData> DJFENPHHAHE, bool IGFOLMDCEHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct ADDHGOBILDG<TData> where TData : notnull, MMHOCMHBDGD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public List<TData> FBDCMOLPPJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public List<bool> DCNOLICHHPC;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3545EA0", Offset = "0x35446A0", VA = "0x183545EA0")]
	public ADDHGOBILDG(List<TData> DJFENPHHAHE, List<bool> APCMEECGALD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface MMHOCMHBDGD
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool NEFCFFEJLDH
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface IDGINDHHCAC<TData> where TData : MMHOCMHBDGD
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GEGMGBLEPCF([In] GFLHBDOMADP<TData> CFKACLBIIEJ);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GEGMGBLEPCF([In] ADDHGOBILDG<TData> CFKACLBIIEJ);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class HPLFAPJBBJF<TData> : NDPCHFEFDNA<IDGINDHHCAC<TData>> where TData : notnull, MMHOCMHBDGD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly GFLHBDOMADP<TData> CFKACLBIIEJ;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x35F3FE0", Offset = "0x35F27E0", VA = "0x1835F3FE0")]
	public HPLFAPJBBJF(List<TData> HPEIGDGIAOC, bool KPPGAHKCECN, IDGINDHHCAC<TData> ALHPLCFGAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x31083A0", Offset = "0x3106BA0", VA = "0x1831083A0", Slot = "4")]
	public override bool GEGMGBLEPCF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class CJGMKHKIIJO<TData> : NDPCHFEFDNA<IDGINDHHCAC<TData>> where TData : notnull, MMHOCMHBDGD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly ADDHGOBILDG<TData> CFKACLBIIEJ;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x49CFF20", Offset = "0x49CE720", VA = "0x1849CFF20")]
	public CJGMKHKIIJO(List<TData> HPEIGDGIAOC, List<bool> DCNOLICHHPC, IDGINDHHCAC<TData> ALHPLCFGAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x311CAE0", Offset = "0x311B2E0", VA = "0x18311CAE0", Slot = "4")]
	public override bool GEGMGBLEPCF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface DIKHIGMNPKE : MMHOCMHBDGD
{
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface CDAFCINMGDI<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<GBHPOFKIHBL> GEGMGBLEPCF(KJCENCAMABG<TData> MCMLFGDHKEO);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class BHLLFFGFANN<TData> : AKMLKJHMAIA<CDAFCINMGDI<TData>, GBHPOFKIHBL> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct KBKFCCJGGOD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public AsyncTaskMethodBuilder<GBHPOFKIHBL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public BHLLFFGFANN<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private TaskAwaiter<GBHPOFKIHBL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x38E1EC0", Offset = "0x38E06C0", VA = "0x1838E1EC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x38E21B0", Offset = "0x38E09B0", VA = "0x1838E21B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly KJCENCAMABG<TData> CFMJDKOGEMC;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x4591EB0", Offset = "0x45906B0", VA = "0x184591EB0")]
	public BHLLFFGFANN(TData KDDCOKGKPAM, IReadOnlyList<TData> FANLODHIKHE, bool FDBHCCKAJGN, CDAFCINMGDI<TData> ALHPLCFGAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x4591DB0", Offset = "0x45905B0", VA = "0x184591DB0", Slot = "4")]
	[AsyncStateMachine(typeof(BHLLFFGFANN<>.KBKFCCJGGOD))]
	public override Task<GBHPOFKIHBL> GEGMGBLEPCF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public struct KJCENCAMABG<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public TData GCCFNFOGLAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public IReadOnlyList<TData> NEHDPKGDOFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public bool FBILDFDGIFO;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x3902EA0", Offset = "0x39016A0", VA = "0x183902EA0")]
	public KJCENCAMABG(TData KDDCOKGKPAM, IReadOnlyList<TData> FANLODHIKHE, bool FDBHCCKAJGN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface ICMDIFAACJC<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GEGMGBLEPCF([In] BGNJLNOGKCO<TData> HAGLJKJHENK);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface MGLMGLOFEGJ<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GEGMGBLEPCF([In] FKINEPPFIPL<TData> HAGLJKJHENK);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface OCEKBEINENP<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HHBHLKHJDPG([In] IDCMNFIJEKD<TData> HAGLJKJHENK);

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DKDLADICFOO();
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class LAMKAEIFDJK<TData> : NDPCHFEFDNA<ICMDIFAACJC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly BGNJLNOGKCO<TData> HAGLJKJHENK;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x39D2FD0", Offset = "0x39D17D0", VA = "0x1839D2FD0")]
	public LAMKAEIFDJK(IEnumerable<TData> HPEIGDGIAOC, COINANOKBFO NGHDCCDAAOH, FDNDCPGLHNO ECIAJACKHCB, float NFNFBBBPDDF, bool FDBHCCKAJGN, ICMDIFAACJC<TData> ALHPLCFGAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x31083A0", Offset = "0x3106BA0", VA = "0x1831083A0", Slot = "4")]
	public override bool GEGMGBLEPCF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public class JMNMJLNLMAP<TData> : NDPCHFEFDNA<MGLMGLOFEGJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly FKINEPPFIPL<TData> HAGLJKJHENK;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x38B1480", Offset = "0x38AFC80", VA = "0x1838B1480")]
	public JMNMJLNLMAP(TData[] HPEIGDGIAOC, COINANOKBFO[] NGHDCCDAAOH, FDNDCPGLHNO[] ECIAJACKHCB, float[] NFNFBBBPDDF, MGLMGLOFEGJ<TData> ALHPLCFGAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x38B12F0", Offset = "0x38AFAF0", VA = "0x1838B12F0", Slot = "4")]
	public override bool GEGMGBLEPCF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class OPLPCJHAPND<TData> : NDPCHFEFDNA<OCEKBEINENP<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x30FBF80", Offset = "0x30FA780", VA = "0x1830FBF80")]
	public OPLPCJHAPND(OCEKBEINENP<TData> ALHPLCFGAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x3E4DE80", Offset = "0x3E4C680", VA = "0x183E4DE80", Slot = "4")]
	public override bool GEGMGBLEPCF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class CCBILEGEMAB<TData> : NDPCHFEFDNA<OCEKBEINENP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly IDCMNFIJEKD<TData> HAGLJKJHENK;

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x48DBEF0", Offset = "0x48DA6F0", VA = "0x1848DBEF0")]
	public CCBILEGEMAB(IEnumerable<TData> HPEIGDGIAOC, COINANOKBFO NGHDCCDAAOH, FDNDCPGLHNO ECIAJACKHCB, float NFNFBBBPDDF, OCEKBEINENP<TData> ALHPLCFGAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x38B12F0", Offset = "0x38AFAF0", VA = "0x1838B12F0", Slot = "4")]
	public override bool GEGMGBLEPCF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public struct BGNJLNOGKCO<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public IEnumerable<TData> FBDCMOLPPJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public COINANOKBFO MKBLHDKPDIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public FDNDCPGLHNO BJPJLDLBNBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public float NFNFBBBPDDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public bool FDBHCCKAJGN;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x458C2F0", Offset = "0x458AAF0", VA = "0x18458C2F0")]
	public BGNJLNOGKCO(IEnumerable<TData> HPEIGDGIAOC, COINANOKBFO NGHDCCDAAOH, FDNDCPGLHNO ECIAJACKHCB, float NFNFBBBPDDF, bool FDBHCCKAJGN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public struct FKINEPPFIPL<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public TData[] FBDCMOLPPJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public COINANOKBFO[] MKBLHDKPDIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public FDNDCPGLHNO[] BJPJLDLBNBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public float[] NFNFBBBPDDF;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x347B760", Offset = "0x3479F60", VA = "0x18347B760")]
	public FKINEPPFIPL(TData[] HPEIGDGIAOC, COINANOKBFO[] NGHDCCDAAOH, FDNDCPGLHNO[] ECIAJACKHCB, float[] NFNFBBBPDDF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public struct IDCMNFIJEKD<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public IEnumerable<TData> FBDCMOLPPJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public COINANOKBFO MKBLHDKPDIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public FDNDCPGLHNO BJPJLDLBNBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public float NFNFBBBPDDF;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x368B6A0", Offset = "0x3689EA0", VA = "0x18368B6A0")]
	public IDCMNFIJEKD(IEnumerable<TData> HPEIGDGIAOC, COINANOKBFO NGHDCCDAAOH, FDNDCPGLHNO ECIAJACKHCB, float NFNFBBBPDDF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface DELKDMBDLMJ<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AILLEMHPNGM([In] HLJPKCPEGIO<TData> PFOODLPKBPG);

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DLNCICLFEBH([In] HLJPKCPEGIO<TData> PFOODLPKBPG);

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EFLMGHFPGMB([In] bool HDFIPMOKMEL);

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IADOKECBCOO([In] HLJPKCPEGIO<TData> PFOODLPKBPG);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PPGHOPBFILA();

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool GPFCONDAHBE([In] TData GJDDBOEGFFF);
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class BOOOLEPBJKO<TData> : NDPCHFEFDNA<DELKDMBDLMJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly HLJPKCPEGIO<TData> PFOODLPKBPG;

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x4607500", Offset = "0x4605D00", VA = "0x184607500")]
	public BOOOLEPBJKO(List<TData> BGOMBENDKBO, DELKDMBDLMJ<TData> ALHPLCFGAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x31083A0", Offset = "0x3106BA0", VA = "0x1831083A0", Slot = "4")]
	public override bool GEGMGBLEPCF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class HKEOJPPMCDL<TData> : NDPCHFEFDNA<DELKDMBDLMJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x30FBF80", Offset = "0x30FA780", VA = "0x1830FBF80")]
	public HKEOJPPMCDL(DELKDMBDLMJ<TData> ALHPLCFGAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x35A6B50", Offset = "0x35A5350", VA = "0x1835A6B50", Slot = "4")]
	public override bool GEGMGBLEPCF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class OEHGOLIOPFO<TData> : NDPCHFEFDNA<DELKDMBDLMJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly bool FDBHCCKAJGN;

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x3E053E0", Offset = "0x3E03BE0", VA = "0x183E053E0")]
	public OEHGOLIOPFO(bool FDBHCCKAJGN, DELKDMBDLMJ<TData> ALHPLCFGAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x3E05380", Offset = "0x3E03B80", VA = "0x183E05380", Slot = "4")]
	public override bool GEGMGBLEPCF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class EMOIPPFKIBB<TData> : NDPCHFEFDNA<DELKDMBDLMJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly HLJPKCPEGIO<TData> PFOODLPKBPG;

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x311CC30", Offset = "0x311B430", VA = "0x18311CC30")]
	public EMOIPPFKIBB(List<TData> BGOMBENDKBO, bool FDBHCCKAJGN, DELKDMBDLMJ<TData> ALHPLCFGAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x311CAE0", Offset = "0x311B2E0", VA = "0x18311CAE0", Slot = "4")]
	public override bool GEGMGBLEPCF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public class EAJLMKJGAKC<TData> : NDPCHFEFDNA<DELKDMBDLMJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly TData GJDDBOEGFFF;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x30EAC80", Offset = "0x30E9480", VA = "0x1830EAC80")]
	public EAJLMKJGAKC(TData GJDDBOEGFFF, DELKDMBDLMJ<TData> ALHPLCFGAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x30EABB0", Offset = "0x30E93B0", VA = "0x1830EABB0", Slot = "4")]
	public override bool GEGMGBLEPCF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class CIENLBMAKBP<TData> : NDPCHFEFDNA<DELKDMBDLMJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly HLJPKCPEGIO<TData> PFOODLPKBPG;

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x49CF8A0", Offset = "0x49CE0A0", VA = "0x1849CF8A0")]
	public CIENLBMAKBP(List<TData> BGOMBENDKBO, DELKDMBDLMJ<TData> ALHPLCFGAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x49CF7D0", Offset = "0x49CDFD0", VA = "0x1849CF7D0", Slot = "4")]
	public override bool GEGMGBLEPCF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public struct HLJPKCPEGIO<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public IEnumerable<TData> FBDCMOLPPJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public bool FDBHCCKAJGN;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x35C67F0", Offset = "0x35C4FF0", VA = "0x1835C67F0")]
	public HLJPKCPEGIO(IEnumerable<TData> DJFENPHHAHE, bool ENOCCENGBNC = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface FGGAPGCHNGH
{
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<GBHPOFKIHBL> GEGMGBLEPCF(OGNBCCNIKDF OAJAOGCMHAM);
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class KDPEMLDBGCK : AKMLKJHMAIA<FGGAPGCHNGH, GBHPOFKIHBL>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private struct KBMMBPFPOPI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public AsyncTaskMethodBuilder<GBHPOFKIHBL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public KDPEMLDBGCK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private TaskAwaiter<GBHPOFKIHBL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x5E39260", Offset = "0x5E37A60", VA = "0x185E39260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x5E394E0", Offset = "0x5E37CE0", VA = "0x185E394E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly OGNBCCNIKDF HOGEGKMMAMF;

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5E39640", Offset = "0x5E37E40", VA = "0x185E39640")]
	public KDPEMLDBGCK(bool FDBHCCKAJGN, FGGAPGCHNGH ALHPLCFGAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5E39550", Offset = "0x5E37D50", VA = "0x185E39550", Slot = "4")]
	[AsyncStateMachine(typeof(KBMMBPFPOPI))]
	public override Task<GBHPOFKIHBL> GEGMGBLEPCF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public struct OGNBCCNIKDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public bool FBILDFDGIFO;

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0xBD0370", Offset = "0xBCEB70", VA = "0x180BD0370")]
	public OGNBCCNIKDF(bool FDBHCCKAJGN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface IINBPNLOICD<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NCGPAAGHNNN([In] IILBDPCOOFN<TData> JMGDIAIJNIK);

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HHBHLKHJDPG([In] BKNGIAEPENF PKGPLLEJMCO);

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HHBHLKHJDPG([In] KOIGHIAJNAI PKGPLLEJMCO);

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DKDLADICFOO();
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class IAIGHGMBELL<TData> : NDPCHFEFDNA<IINBPNLOICD<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x30FBF80", Offset = "0x30FA780", VA = "0x1830FBF80")]
	public IAIGHGMBELL(IINBPNLOICD<TData> ALHPLCFGAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3685190", Offset = "0x3683990", VA = "0x183685190", Slot = "4")]
	public override bool GEGMGBLEPCF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class OJHPHEHJCGE<TData> : NDPCHFEFDNA<IINBPNLOICD<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly BKNGIAEPENF LDNOIELMGIO;

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3E1AF20", Offset = "0x3E19720", VA = "0x183E1AF20")]
	public OJHPHEHJCGE(Vector3 KNJPPKCDFLF, bool NINDIMKKMMJ, IINBPNLOICD<TData> ALHPLCFGAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x385C660", Offset = "0x385AE60", VA = "0x18385C660", Slot = "4")]
	public override bool GEGMGBLEPCF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class MJIMMMBMCDD<TData> : NDPCHFEFDNA<IINBPNLOICD<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly KOIGHIAJNAI LDNOIELMGIO;

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3C9BE80", Offset = "0x3C9A680", VA = "0x183C9BE80")]
	public MJIMMMBMCDD(Guid HJOAPEGMMPN, int EAHCFBMNNCF, Vector3 FLFCGPFDCMD, Quaternion JOBDANNFLEE, float EHFGJJPBLJP, bool NINDIMKKMMJ, IINBPNLOICD<TData> ALHPLCFGAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3C9BE20", Offset = "0x3C9A620", VA = "0x183C9BE20", Slot = "4")]
	public override bool GEGMGBLEPCF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class GEBNAIOEHDB<TData> : NDPCHFEFDNA<IINBPNLOICD<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly IILBDPCOOFN<TData> LDNOIELMGIO;

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x351AFE0", Offset = "0x35197E0", VA = "0x18351AFE0")]
	public GEBNAIOEHDB(TData MAKBFCPADHF, bool FDBHCCKAJGN, IINBPNLOICD<TData> ALHPLCFGAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x31083A0", Offset = "0x3106BA0", VA = "0x1831083A0", Slot = "4")]
	public override bool GEGMGBLEPCF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public struct BKNGIAEPENF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly Vector3 KNJPPKCDFLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly bool NINDIMKKMMJ;

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x5E39220", Offset = "0x5E37A20", VA = "0x185E39220")]
	public BKNGIAEPENF(Vector3 KNJPPKCDFLF, bool NINDIMKKMMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct KOIGHIAJNAI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly Guid HJOAPEGMMPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly int EAHCFBMNNCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly Vector3 FLFCGPFDCMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly Quaternion JOBDANNFLEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly float EHFGJJPBLJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly bool NINDIMKKMMJ;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x5E396A0", Offset = "0x5E37EA0", VA = "0x185E396A0")]
	public KOIGHIAJNAI(Guid HJOAPEGMMPN, int EAHCFBMNNCF, Vector3 FLFCGPFDCMD, Quaternion JOBDANNFLEE, float EHFGJJPBLJP, bool NINDIMKKMMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public struct IILBDPCOOFN<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly TData MAKBFCPADHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly bool FDBHCCKAJGN;

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x36B8F60", Offset = "0x36B7760", VA = "0x1836B8F60")]
	public IILBDPCOOFN(TData MAKBFCPADHF, bool FDBHCCKAJGN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface HODEDAAKPPE<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GEGMGBLEPCF([In] POAOAKABMFM<TData> PAHHDEBNPJO);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GEGMGBLEPCF([In] JAHHFBGODLI<TData> PAHHDEBNPJO);
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public interface IDCGLKAOHBP<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NCGPAAGHNNN([In] DPCOPLPPMCA<TData> PGCLMCDOIHA);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HHBHLKHJDPG([In] GKBPOODBJNM PKGPLLEJMCO);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DKDLADICFOO();
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class FNGDOBPMKME<TData> : NDPCHFEFDNA<HODEDAAKPPE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly POAOAKABMFM<TData> PAHHDEBNPJO;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x34868F0", Offset = "0x34850F0", VA = "0x1834868F0")]
	public FNGDOBPMKME(IEnumerable<TData> HPEIGDGIAOC, Vector3 DBBMGOFALAM, bool FDBHCCKAJGN, HODEDAAKPPE<TData> ALHPLCFGAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x31083A0", Offset = "0x3106BA0", VA = "0x1831083A0", Slot = "4")]
	public override bool GEGMGBLEPCF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class IHIDAAMKGCL<TData> : NDPCHFEFDNA<IDCGLKAOHBP<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x30FBF80", Offset = "0x30FA780", VA = "0x1830FBF80")]
	public IHIDAAMKGCL(IDCGLKAOHBP<TData> ALHPLCFGAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x35144E0", Offset = "0x3512CE0", VA = "0x1835144E0", Slot = "4")]
	public override bool GEGMGBLEPCF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class EIOOFGPHDCI<TData> : NDPCHFEFDNA<IDCGLKAOHBP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly DPCOPLPPMCA<TData> PAHHDEBNPJO;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x3108460", Offset = "0x3106C60", VA = "0x183108460")]
	public EIOOFGPHDCI(IEnumerable<TData> HPEIGDGIAOC, bool FDBHCCKAJGN, IDCGLKAOHBP<TData> ALHPLCFGAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x31083A0", Offset = "0x3106BA0", VA = "0x1831083A0", Slot = "4")]
	public override bool GEGMGBLEPCF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class OHNEBFABBMN<TData> : NDPCHFEFDNA<HODEDAAKPPE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly JAHHFBGODLI<TData> PAHHDEBNPJO;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x3E13C10", Offset = "0x3E12410", VA = "0x183E13C10")]
	public OHNEBFABBMN(IEnumerable<TData> HPEIGDGIAOC, Vector3 FDMEEMMKIKN, LPOKJCPILOL PHNOEEMCOFA, bool FDBHCCKAJGN, HODEDAAKPPE<TData> ALHPLCFGAFB, Space MHKPMIADMKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x34EEBD0", Offset = "0x34ED3D0", VA = "0x1834EEBD0", Slot = "4")]
	public override bool GEGMGBLEPCF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class NNGMEMINDLB<TData> : NDPCHFEFDNA<IDCGLKAOHBP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly GKBPOODBJNM PAHHDEBNPJO;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x3D442C0", Offset = "0x3D42AC0", VA = "0x183D442C0")]
	public NNGMEMINDLB(Vector3 DBBMGOFALAM, IDCGLKAOHBP<TData> ALHPLCFGAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x385C660", Offset = "0x385AE60", VA = "0x18385C660", Slot = "4")]
	public override bool GEGMGBLEPCF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public struct POAOAKABMFM<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public readonly IEnumerable<TData> HPEIGDGIAOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public readonly Vector3 DBBMGOFALAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public readonly bool FDBHCCKAJGN;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x3F1DF80", Offset = "0x3F1C780", VA = "0x183F1DF80")]
	public POAOAKABMFM(IEnumerable<TData> HPEIGDGIAOC, Vector3 DBBMGOFALAM, bool FDBHCCKAJGN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public struct DPCOPLPPMCA<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public readonly IEnumerable<TData> HPEIGDGIAOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly bool FDBHCCKAJGN;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x4DF1EA0", Offset = "0x4DF06A0", VA = "0x184DF1EA0")]
	public DPCOPLPPMCA(IEnumerable<TData> HPEIGDGIAOC, bool FDBHCCKAJGN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public struct JAHHFBGODLI<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public readonly IEnumerable<TData> HPEIGDGIAOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public readonly Vector3 FDMEEMMKIKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public readonly LPOKJCPILOL PHNOEEMCOFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public readonly bool FDBHCCKAJGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public readonly Space MHKPMIADMKM;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x385C790", Offset = "0x385AF90", VA = "0x18385C790")]
	public JAHHFBGODLI(IEnumerable<TData> HPEIGDGIAOC, Vector3 FDMEEMMKIKN, LPOKJCPILOL PHNOEEMCOFA, bool FDBHCCKAJGN, Space MHKPMIADMKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public struct GKBPOODBJNM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public readonly Vector3 DBBMGOFALAM;

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x201C460", Offset = "0x201AC60", VA = "0x18201C460")]
	public GKBPOODBJNM(Vector3 DBBMGOFALAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public enum LPOKJCPILOL
{
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	XYZ,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	X_only,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	Y_only,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	Z_only
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public interface JHDBBPKFEJC<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GEGMGBLEPCF([In] LCGLPEOAGIM<TData> ECMCEBKEBKB);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GEGMGBLEPCF([In] COLKBOBDGBF<TData> ECMCEBKEBKB);
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public interface NCMJLHFCLHF<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NCGPAAGHNNN([In] DKPIOCFCDDK<TData> JMGDIAIJNIK);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HHBHLKHJDPG([In] NOMJHNMMMEM PKGPLLEJMCO);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DKDLADICFOO();
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public class LCEDKNBNGJA<TData> : NDPCHFEFDNA<JHDBBPKFEJC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly LCGLPEOAGIM<TData> ECMCEBKEBKB;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x39ED900", Offset = "0x39EC100", VA = "0x1839ED900")]
	public LCEDKNBNGJA(IEnumerable<TData> HPEIGDGIAOC, Quaternion DBBMGOFALAM, Vector3? NBGAIONEHHC, bool LNHAGMOKAJD, bool FDBHCCKAJGN, JHDBBPKFEJC<TData> ALHPLCFGAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x31083A0", Offset = "0x3106BA0", VA = "0x1831083A0", Slot = "4")]
	public override bool GEGMGBLEPCF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class OKJKMHOGGPN<TData> : NDPCHFEFDNA<NCMJLHFCLHF<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x30FBF80", Offset = "0x30FA780", VA = "0x1830FBF80")]
	public OKJKMHOGGPN(NCMJLHFCLHF<TData> ALHPLCFGAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x35144E0", Offset = "0x3512CE0", VA = "0x1835144E0", Slot = "4")]
	public override bool GEGMGBLEPCF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class MDHNIFNKAKK<TData> : NDPCHFEFDNA<NCMJLHFCLHF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly DKPIOCFCDDK<TData> ECMCEBKEBKB;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x3C47780", Offset = "0x3C45F80", VA = "0x183C47780")]
	public MDHNIFNKAKK(IEnumerable<TData> HPEIGDGIAOC, bool FDBHCCKAJGN, NCMJLHFCLHF<TData> ALHPLCFGAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x31083A0", Offset = "0x3106BA0", VA = "0x1831083A0", Slot = "4")]
	public override bool GEGMGBLEPCF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class LKHMGFIAALG<TData> : NDPCHFEFDNA<JHDBBPKFEJC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly COLKBOBDGBF<TData> ECMCEBKEBKB;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x3A6DE70", Offset = "0x3A6C670", VA = "0x183A6DE70")]
	public LKHMGFIAALG(IEnumerable<TData> HPEIGDGIAOC, Quaternion GCCLACCEIPN, LPOKJCPILOL MNBAPDBEFBK, Vector3? NBGAIONEHHC, bool LNHAGMOKAJD, bool FDBHCCKAJGN, Space MHKPMIADMKM, JHDBBPKFEJC<TData> ALHPLCFGAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x34EEBD0", Offset = "0x34ED3D0", VA = "0x1834EEBD0", Slot = "4")]
	public override bool GEGMGBLEPCF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class JAEPKNOLKJM<TData> : NDPCHFEFDNA<NCMJLHFCLHF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly NOMJHNMMMEM ECMCEBKEBKB;

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x385C6C0", Offset = "0x385AEC0", VA = "0x18385C6C0")]
	public JAEPKNOLKJM(Quaternion DBBMGOFALAM, Vector3? NBGAIONEHHC, bool LNHAGMOKAJD, NCMJLHFCLHF<TData> ALHPLCFGAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x385C660", Offset = "0x385AE60", VA = "0x18385C660", Slot = "4")]
	public override bool GEGMGBLEPCF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public struct LCGLPEOAGIM<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public readonly IEnumerable<TData> HPEIGDGIAOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public readonly Quaternion DBBMGOFALAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public readonly Vector3? NBGAIONEHHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public readonly bool LNHAGMOKAJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public readonly bool FDBHCCKAJGN;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x39EE5F0", Offset = "0x39ECDF0", VA = "0x1839EE5F0")]
	public LCGLPEOAGIM(IEnumerable<TData> HPEIGDGIAOC, Quaternion DBBMGOFALAM, Vector3? NBGAIONEHHC, bool LNHAGMOKAJD, bool FDBHCCKAJGN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct DKPIOCFCDDK<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly IEnumerable<TData> HPEIGDGIAOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public readonly bool FDBHCCKAJGN;

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x4DDE5B0", Offset = "0x4DDCDB0", VA = "0x184DDE5B0")]
	public DKPIOCFCDDK(IEnumerable<TData> HPEIGDGIAOC, bool FDBHCCKAJGN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct COLKBOBDGBF<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly IEnumerable<TData> HPEIGDGIAOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public readonly Quaternion GCCLACCEIPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public readonly LPOKJCPILOL MNBAPDBEFBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public readonly Vector3? NBGAIONEHHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public readonly bool LNHAGMOKAJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public readonly bool FDBHCCKAJGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public readonly Space MHKPMIADMKM;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x4A9C040", Offset = "0x4A9A840", VA = "0x184A9C040")]
	public COLKBOBDGBF(IEnumerable<TData> HPEIGDGIAOC, Quaternion GCCLACCEIPN, LPOKJCPILOL MNBAPDBEFBK, Vector3? NBGAIONEHHC, bool LNHAGMOKAJD, bool FDBHCCKAJGN, Space MHKPMIADMKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct NOMJHNMMMEM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public readonly Quaternion DBBMGOFALAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public readonly Vector3? NBGAIONEHHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public readonly bool LNHAGMOKAJD;

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x43C2860", Offset = "0x43C1060", VA = "0x1843C2860")]
	public NOMJHNMMMEM(Quaternion DBBMGOFALAM, Vector3? NBGAIONEHHC, bool LNHAGMOKAJD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public interface MLGBDOKANLK<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NCGPAAGHNNN([In] HCBPGFBKHMO<TData> JMGDIAIJNIK);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HHBHLKHJDPG([In] MOACJFDDHAM PKGPLLEJMCO);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HHBHLKHJDPG([In] GCFKKBKIMIO PKGPLLEJMCO);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HHBHLKHJDPG([In] LKCEGANLBND PKGPLLEJMCO);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool DKDLADICFOO();
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public class GFHDOFOENLD<TData> : NDPCHFEFDNA<MLGBDOKANLK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly LKCEGANLBND DBGKACGMBCL;

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x351C150", Offset = "0x351A950", VA = "0x18351C150")]
	public GFHDOFOENLD(Vector3 PNODONIONNP, float HOEPBGDAMOC, Vector3 NBGAIONEHHC, bool OIJFLILLEAO, bool DGBEEHIEINB, MLGBDOKANLK<TData> ALHPLCFGAFB, Space MHKPMIADMKM = Space.Self)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x351C0F0", Offset = "0x351A8F0", VA = "0x18351C0F0", Slot = "4")]
	public override bool GEGMGBLEPCF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public class ICFPICIGNNC<TData> : NDPCHFEFDNA<MLGBDOKANLK<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x30FBF80", Offset = "0x30FA780", VA = "0x1830FBF80")]
	public ICFPICIGNNC(MLGBDOKANLK<TData> ALHPLCFGAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x368A420", Offset = "0x3688C20", VA = "0x18368A420", Slot = "4")]
	public override bool GEGMGBLEPCF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public class JKFFKPJGDKH<TData> : NDPCHFEFDNA<MLGBDOKANLK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly HCBPGFBKHMO<TData> DBGKACGMBCL;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x38A5470", Offset = "0x38A3C70", VA = "0x1838A5470")]
	public JKFFKPJGDKH(IEnumerable<TData> HPEIGDGIAOC, bool FDBHCCKAJGN, MLGBDOKANLK<TData> ALHPLCFGAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x31083A0", Offset = "0x3106BA0", VA = "0x1831083A0", Slot = "4")]
	public override bool GEGMGBLEPCF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class EDMIGEJJPFA<TData> : NDPCHFEFDNA<MLGBDOKANLK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly GCFKKBKIMIO DBGKACGMBCL;

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x30FA410", Offset = "0x30F8C10", VA = "0x1830FA410")]
	public EDMIGEJJPFA(float DLEJJCIPJAM, bool OCHFPDOAAON, Vector3 NBGAIONEHHC, MLGBDOKANLK<TData> ALHPLCFGAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x30FA340", Offset = "0x30F8B40", VA = "0x1830FA340", Slot = "4")]
	public override bool GEGMGBLEPCF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public class PFBNODFGEKE<TData> : NDPCHFEFDNA<MLGBDOKANLK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly MOACJFDDHAM DBGKACGMBCL;

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x3EF1A10", Offset = "0x3EF0210", VA = "0x183EF1A10")]
	public PFBNODFGEKE(float HOEPBGDAMOC, Vector3 NBGAIONEHHC, MLGBDOKANLK<TData> ALHPLCFGAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x385C660", Offset = "0x385AE60", VA = "0x18385C660", Slot = "4")]
	public override bool GEGMGBLEPCF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct LKCEGANLBND
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public readonly Vector3 PNODONIONNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public readonly float HOEPBGDAMOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public readonly Vector3 NBGAIONEHHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public readonly bool NINDIMKKMMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public readonly Space MHKPMIADMKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly bool DGBEEHIEINB;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x5E396E0", Offset = "0x5E37EE0", VA = "0x185E396E0")]
	public LKCEGANLBND(Vector3 PNODONIONNP, float HOEPBGDAMOC, Vector3 NBGAIONEHHC, bool NINDIMKKMMJ, bool CKPPMMMOAHM, Space MHKPMIADMKM = Space.Self)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public struct HCBPGFBKHMO<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public readonly IEnumerable<TData> HPEIGDGIAOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public readonly bool FDBHCCKAJGN;

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x358B670", Offset = "0x3589E70", VA = "0x18358B670")]
	public HCBPGFBKHMO(IEnumerable<TData> HPEIGDGIAOC, bool FDBHCCKAJGN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public struct GCFKKBKIMIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public readonly float DLEJJCIPJAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public readonly bool OCHFPDOAAON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public readonly Vector3 NBGAIONEHHC;

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x5E39240", Offset = "0x5E37A40", VA = "0x185E39240")]
	public GCFKKBKIMIO(float DLEJJCIPJAM, bool OCHFPDOAAON, Vector3 NBGAIONEHHC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct MOACJFDDHAM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public readonly float HOEPBGDAMOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public readonly Vector3 NBGAIONEHHC;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x439AFF0", Offset = "0x43997F0", VA = "0x18439AFF0")]
	public MOACJFDDHAM(float HOEPBGDAMOC, Vector3 NBGAIONEHHC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public static class BDKBAJKPHIM
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	private struct HPGKBAMHPLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public bool ECBIIBFFLAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public PHIPPCBHDOE LOMJOEIIJAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public PHIPPCBHDOE PDFIAIHMCMP;
	}

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private static HPGKBAMHPLF DFACJKNFEKI;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static CancellationToken GEFKAGHCNOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x5E39200", Offset = "0x5E37A00", VA = "0x185E39200")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	internal static PHIPPCBHDOE LOMJOEIIJAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x5E39010", Offset = "0x5E37810", VA = "0x185E39010")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x5E38E50", Offset = "0x5E37650", VA = "0x185E38E50")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5E390B0", Offset = "0x5E378B0", VA = "0x185E390B0")]
	[IOOPNJKFHOG(JJAMOFEKMEH.Room, FICJCHGEBPC.None)]
	private static void LAKLFGALIHP(PHIPPCBHDOE FKLPNLKKCIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5E38EC0", Offset = "0x5E376C0", VA = "0x185E38EC0")]
	public static void EINJMPIPEHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x5E391B0", Offset = "0x5E379B0", VA = "0x185E391B0")]
	private static PHIPPCBHDOE MFMBEEMNPGH(PHIPPCBHDOE JPFLHFFBHBM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public static class JEHFLMJOKAD
{
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public enum KMMNDIAMOPK
	{
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		ICreationContextObject,
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		Guid
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x253A4D0", Offset = "0x2538CD0", VA = "0x18253A4D0")]
	public static void IEAADMGFJFG<T>(T PIOFGCGEFCD, KMMNDIAMOPK HJNJPNKDEFH) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x253A610", Offset = "0x2538E10", VA = "0x18253A610")]
	public static void IEAADMGFJFG<T>(T PIOFGCGEFCD) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x253A670", Offset = "0x2538E70", VA = "0x18253A670")]
	public static void KHIIHMAAFAB<T>(T PIOFGCGEFCD) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x253A430", Offset = "0x2538C30", VA = "0x18253A430")]
	public static T BGCBNLKDELI<T>(KMMNDIAMOPK HJNJPNKDEFH) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x253A390", Offset = "0x2538B90", VA = "0x18253A390")]
	public static bool AOJPLNELAOE<T>(KMMNDIAMOPK HJNJPNKDEFH) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x253A350", Offset = "0x2538B50", VA = "0x18253A350")]
	public static T BGCBNLKDELI<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x253A350", Offset = "0x2538B50", VA = "0x18253A350")]
	public static bool AOJPLNELAOE<T>() where T : class
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
internal static class MLKFMBFJENP
{
	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x5E39720", Offset = "0x5E37F20", VA = "0x185E39720")]
	public static void PDONDHMODAF(IEnumerable JNDAOPBNJMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x25AD230", Offset = "0x25ABA30", VA = "0x1825AD230")]
	public static void PDONDHMODAF<T>(T[] CMKNCDNHDNA) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x25AD410", Offset = "0x25ABC10", VA = "0x1825AD410")]
	public static void PDONDHMODAF<T>(T EMCGBONIADL) where T : notnull, Enum
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
