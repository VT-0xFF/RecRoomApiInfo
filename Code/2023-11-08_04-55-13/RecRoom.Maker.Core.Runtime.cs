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
		[Cpp2IlInjected.Address(RVA = "0x7997A0", Offset = "0x7985A0", VA = "0x1807997A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5E15DA0", Offset = "0x5E14BA0", VA = "0x185E15DA0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x799B60", Offset = "0x798960", VA = "0x180799B60")]
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
		[Cpp2IlInjected.Address(RVA = "0x799BA0", Offset = "0x7989A0", VA = "0x180799BA0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface EINCFOPBPLD<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ClearHoverTarget(JBKCGJEEEJG CICKLDJELGN);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool SetHoverTarget(TData PODCKBKAANA, Collider OCHNGLAIGEL, JBKCGJEEEJG CICKLDJELGN, [Optional] FDCNBJCCLMM? IIJIJNBNFFG);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool TryGetHoverTarget([Out] TData PODCKBKAANA);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface KGKKNENOILA<TData> : EFNGHHNBAIE, EECOBGAKCJH<TData>, JIEIJFJMBBN<TData>, BJKHIMGLBEH<TData>, GDPEKJDPMCB, JONBKBIBGIE<TData>, MGHLDLGNCCA, ICGHCIOBDMH
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface JONBKBIBGIE<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 CEBNDLLNOFI, Vector3 NJLPJDHGIMB, float PABLLIHNBKD, [Out] T NJGHAPFDOJN, [Out] Vector3 DCOIJPLFMFC, [Out] Collider OCHNGLAIGEL);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 CEBNDLLNOFI, Vector3 NJLPJDHGIMB, float IICKOOCLDCN, float PABLLIHNBKD, T[] FIKNAFMINCN, [Out] Vector3 GLMLJJHHEOM, [Out] Collider DGEENGHDJOM);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 CEBNDLLNOFI, float IICKOOCLDCN, Vector3 NICLMPBICMA, T[] FIKNAFMINCN);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface EFNGHHNBAIE
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Bounds BPDCKBPIKOL
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Transform KMBMHDBBNHE
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Bounds APEDMLKKCIC
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Transform FJIIOMGNKEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Vector3 KEPPGMBHDND
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void SetSelectionBoundsDirty(bool JAEFLMCAPNP = true, int MKBJNECGGLP = 0);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ShouldHideSelectionBoundsPreview(bool HGEPEEOMEHN, object HOBAPMCPFML);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface ICGHCIOBDMH
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	INNFNKFCEKE HJMFPBMBJAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface BJKHIMGLBEH<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool GNCCGGEJDPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	int EIEOKDFFKPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	IEnumerable<TData> JEPKADEAPKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData DAPKCDOOBFC);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData DAPKCDOOBFC);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface EECOBGAKCJH<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T KANAGAAAGHJ, [Optional] FDCNBJCCLMM? OMGAFDEMCOG, bool NODDOBBOEMP = true);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int PDNIMDHODLH, IEnumerable<T> BOOJGGDCEKE, bool NODDOBBOEMP = true);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int PDNIMDHODLH, IEnumerable<T> BOOJGGDCEKE, FDCNBJCCLMM OMGAFDEMCOG, bool NODDOBBOEMP = true);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface MGHLDLGNCCA
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface GDPEKJDPMCB
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool BFGBEKMPEHB
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool CIPGBEFEIOC
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool AHDBCEOBOMH
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool OOAEKPDNAOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class EBJFCNIJLMP<TReceiver> : LBBJMHBKBHC<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x30CE240", Offset = "0x30CD040", VA = "0x1830CE240")]
	public EBJFCNIJLMP(TReceiver IOKGEJINEJL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public abstract class BAPGLOBLCJM<TReceiver, TFromTask> : LBBJMHBKBHC<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x30CE240", Offset = "0x30CD040", VA = "0x1830CE240")]
	public BAPGLOBLCJM(TReceiver IOKGEJINEJL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class LBBJMHBKBHC<TReceiver, TFromExecute> where TReceiver : notnull where TFromExecute : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	protected TReceiver IOKGEJINEJL;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3AA11A0", Offset = "0x3A9FFA0", VA = "0x183AA11A0")]
	public LBBJMHBKBHC(TReceiver IOKGEJINEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute CJPLMBELNJP();
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class AKDHJONKJJJ<TReceiver, TResult> : LBBJMHBKBHC<TReceiver, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x30CE240", Offset = "0x30CD040", VA = "0x1830CE240")]
	public AKDHJONKJJJ(TReceiver IOKGEJINEJL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct KCAMNHOLAOK<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public TGroup CFNJECPBFPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public TData EAOEBBEDOMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public IEnumerable<TData> IKOGMKDGFOP;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x19743C0", Offset = "0x19731C0", VA = "0x1819743C0")]
	public KCAMNHOLAOK(TGroup BJJPCCPCPBB, TData BOAKPGJMBGE, IEnumerable<TData> GBDGHJFJEFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct JCIIMOOMGKA<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public TGroup CFNJECPBFPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public IEnumerable<TData> IKOGMKDGFOP;

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x801630", Offset = "0x800430", VA = "0x180801630")]
	public JCIIMOOMGKA(TGroup BJJPCCPCPBB, IEnumerable<TData> GBDGHJFJEFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct AEIFEAAFCKF<TGroup> where TGroup : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public TGroup CFNJECPBFPF;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x83D460", Offset = "0x83C260", VA = "0x18083D460")]
	public AEIFEAAFCKF(TGroup BJJPCCPCPBB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct LPIKOHAPDBI<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public IEnumerable<TData> IKOGMKDGFOP;

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x83D460", Offset = "0x83C260", VA = "0x18083D460")]
	public LPIKOHAPDBI(IEnumerable<TData> GBDGHJFJEFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface NKFCFCIBOAB<TGroup, TData>
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EGBCHOJPEFI EBLJDHPAFCP(KCAMNHOLAOK<TGroup, TData> AHHFNDDMDHJ);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	EGBCHOJPEFI CJPGIJPLGHL(KCAMNHOLAOK<TGroup, TData> AHHFNDDMDHJ);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EGBCHOJPEFI CLAAIAKOLDB(JCIIMOOMGKA<TGroup, TData> AHHFNDDMDHJ);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	EGBCHOJPEFI NDEEHBJOIBG(AEIFEAAFCKF<TGroup> AHHFNDDMDHJ);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface GPMCIJHPALG<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<EGBCHOJPEFI> EBLJDHPAFCP(LPIKOHAPDBI<TData> AHHFNDDMDHJ);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class DDPGGIFIPGE<TGroup, TData> : AKDHJONKJJJ<NKFCFCIBOAB<TGroup, TData>, EGBCHOJPEFI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly JCIIMOOMGKA<TGroup, TData> AHHFNDDMDHJ;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4D7A1E0", Offset = "0x4D78FE0", VA = "0x184D7A1E0")]
	public DDPGGIFIPGE(TGroup BJJPCCPCPBB, IEnumerable<TData> GBDGHJFJEFH, NKFCFCIBOAB<TGroup, TData> IOKGEJINEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4D7A110", Offset = "0x4D78F10", VA = "0x184D7A110", Slot = "4")]
	public override EGBCHOJPEFI CJPLMBELNJP()
	{
		return default(EGBCHOJPEFI);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class LGCOGCGLDKE<TGroup, TData> : AKDHJONKJJJ<NKFCFCIBOAB<TGroup, TData>, EGBCHOJPEFI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly KCAMNHOLAOK<TGroup, TData> AHHFNDDMDHJ;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3AB3CF0", Offset = "0x3AB2AF0", VA = "0x183AB3CF0")]
	public LGCOGCGLDKE(TGroup BJJPCCPCPBB, TData DIFBGFEHJNK, IEnumerable<TData> GBDGHJFJEFH, NKFCFCIBOAB<TGroup, TData> IOKGEJINEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3AB3C10", Offset = "0x3AB2A10", VA = "0x183AB3C10", Slot = "4")]
	public override EGBCHOJPEFI CJPLMBELNJP()
	{
		return default(EGBCHOJPEFI);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class NCAAOPEJJJB<TGroup, TData> : AKDHJONKJJJ<NKFCFCIBOAB<TGroup, TData>, EGBCHOJPEFI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly AEIFEAAFCKF<TGroup> AHHFNDDMDHJ;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3A36010", Offset = "0x3A34E10", VA = "0x183A36010")]
	public NCAAOPEJJJB(TGroup BJJPCCPCPBB, NKFCFCIBOAB<TGroup, TData> IOKGEJINEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3D000E0", Offset = "0x3CFEEE0", VA = "0x183D000E0", Slot = "4")]
	public override EGBCHOJPEFI CJPLMBELNJP()
	{
		return default(EGBCHOJPEFI);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class BKCKKDGNDKE<TGroup, TData> : AKDHJONKJJJ<NKFCFCIBOAB<TGroup, TData>, EGBCHOJPEFI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly KCAMNHOLAOK<TGroup, TData> AHHFNDDMDHJ;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3AB3CF0", Offset = "0x3AB2AF0", VA = "0x183AB3CF0")]
	public BKCKKDGNDKE(TGroup BJJPCCPCPBB, TData BOAKPGJMBGE, IEnumerable<TData> GBDGHJFJEFH, NKFCFCIBOAB<TGroup, TData> IOKGEJINEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x45F6E40", Offset = "0x45F5C40", VA = "0x1845F6E40", Slot = "4")]
	public override EGBCHOJPEFI CJPLMBELNJP()
	{
		return default(EGBCHOJPEFI);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class KFEOOJPJEKA<TData> : BAPGLOBLCJM<GPMCIJHPALG<TData>, EGBCHOJPEFI> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct MPENGONBFEM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AsyncTaskMethodBuilder<EGBCHOJPEFI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public KFEOOJPJEKA<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private TaskAwaiter<EGBCHOJPEFI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3CC8A30", Offset = "0x3CC7830", VA = "0x183CC8A30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3CC8CD0", Offset = "0x3CC7AD0", VA = "0x183CC8CD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private LPIKOHAPDBI<TData> AHHFNDDMDHJ;

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3A36010", Offset = "0x3A34E10", VA = "0x183A36010")]
	public KFEOOJPJEKA(IEnumerable<TData> FHFHDGLCPKN, GPMCIJHPALG<TData> IOKGEJINEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3A35F10", Offset = "0x3A34D10", VA = "0x183A35F10", Slot = "4")]
	[AsyncStateMachine(typeof(KFEOOJPJEKA<>.MPENGONBFEM))]
	public override Task<EGBCHOJPEFI> CJPLMBELNJP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct GAFNOGFLHHM<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public TNode EMOFIBKGPPF;

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x351A9F0", Offset = "0x35197F0", VA = "0x18351A9F0")]
	public GAFNOGFLHHM(TNode EMOFIBKGPPF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct EGPGPEMBHBL<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public TNode HFLAJPBPNGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public KJOBOFJHMIO BMMDJIMGKPP;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x30EA510", Offset = "0x30E9310", VA = "0x1830EA510")]
	public EGPGPEMBHBL(TNode HFLAJPBPNGF, KJOBOFJHMIO BMMDJIMGKPP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface ELAJPAABAHE<TNode>
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LHMNHFHCHPH([In] GAFNOGFLHHM<TNode> CCNPJACADJA);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KECKAPNEMPC([In] EGPGPEMBHBL<TNode> BGFGHOGOMBH);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DGBEAPBKDKP();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class OGFFHKIKDEM<TNode> : EBJFCNIJLMP<ELAJPAABAHE<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x30CE240", Offset = "0x30CD040", VA = "0x1830CE240")]
	public OGFFHKIKDEM(ELAJPAABAHE<TNode> IOKGEJINEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3DE42F0", Offset = "0x3DE30F0", VA = "0x183DE42F0", Slot = "4")]
	public override bool CJPLMBELNJP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class HFNCPDMDJMB<TNode> : EBJFCNIJLMP<ELAJPAABAHE<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly EGPGPEMBHBL<TNode> BGFGHOGOMBH;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x363A5D0", Offset = "0x36393D0", VA = "0x18363A5D0")]
	public HFNCPDMDJMB(TNode HFLAJPBPNGF, KJOBOFJHMIO BMMDJIMGKPP, ELAJPAABAHE<TNode> IOKGEJINEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x363A500", Offset = "0x3639300", VA = "0x18363A500", Slot = "4")]
	public override bool CJPLMBELNJP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class NDBNAOLAJCN<TNode> : EBJFCNIJLMP<ELAJPAABAHE<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly GAFNOGFLHHM<TNode> CCNPJACADJA;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3D081A0", Offset = "0x3D06FA0", VA = "0x183D081A0")]
	public NDBNAOLAJCN(TNode BPGMHHKEEOP, ELAJPAABAHE<TNode> IOKGEJINEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x30CFDC0", Offset = "0x30CEBC0", VA = "0x1830CFDC0", Slot = "4")]
	public override bool CJPLMBELNJP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct IGDELJCCOFG<TSpawnInfo> where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public TSpawnInfo LFAMMODDJNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public Vector3 LMGPBOPOFGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public Quaternion BPBCJFMFECG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public float OINLNNPPPEB;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0xDB4490", Offset = "0xDB3290", VA = "0x180DB4490")]
	public IGDELJCCOFG(TSpawnInfo LFAMMODDJNG, Vector3 LMGPBOPOFGA, Quaternion BPBCJFMFECG, float OINLNNPPPEB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface LLJLAHNBHHC<TSpawnType, TSpawnInfo>
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> BCKOCMBCPEJ([In] IGDELJCCOFG<TSpawnInfo> FJDKEFLGGAO, CancellationToken ELPOPHCEGNN);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class GANAOLPNFFA<TSpawnType, TSpawnInfo> : BAPGLOBLCJM<LLJLAHNBHHC<TSpawnType, TSpawnInfo>, TSpawnType> where TSpawnType : notnull where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly IGDELJCCOFG<TSpawnInfo> BONEGMDLPMG;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3523540", Offset = "0x3522340", VA = "0x183523540")]
	public GANAOLPNFFA(TSpawnInfo AMHFHJLGDLG, Vector3 LMGPBOPOFGA, Quaternion BPBCJFMFECG, float OINLNNPPPEB, LLJLAHNBHHC<TSpawnType, TSpawnInfo> IOKGEJINEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3523370", Offset = "0x3522170", VA = "0x183523370", Slot = "4")]
	public override Task<TSpawnType> CJPLMBELNJP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public readonly struct FGENFHJKLDE<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly IEnumerable<TData> IKOGMKDGFOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly bool LAHMEEMDLBD;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x343B410", Offset = "0x343A210", VA = "0x18343B410")]
	public FGENFHJKLDE(IEnumerable<TData> GBDGHJFJEFH, bool PFPMHCDNCFF = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface KNIMKOAMNHJ<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<EGBCHOJPEFI> ILBGBDMLGLH([In] FGENFHJKLDE<TData> FLPIBCMIMKO, CancellationToken ELPOPHCEGNN);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class IIMBCJALEBF<TData> : BAPGLOBLCJM<KNIMKOAMNHJ<TData>, EGBCHOJPEFI> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly FGENFHJKLDE<TData> DEHMJGEKENB;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x375A230", Offset = "0x3759030", VA = "0x18375A230")]
	public IIMBCJALEBF(IEnumerable<TData> GBDGHJFJEFH, bool PFPMHCDNCFF, KNIMKOAMNHJ<TData> IOKGEJINEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3523370", Offset = "0x3522170", VA = "0x183523370", Slot = "4")]
	public override Task<EGBCHOJPEFI> CJPLMBELNJP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct EPHCGJILNPO<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly T PODCKBKAANA;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3101FC0", Offset = "0x3100DC0", VA = "0x183101FC0")]
	public EPHCGJILNPO(T FGNJEPPIFFN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface DMIFECMCKKH<T>
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LHMNHFHCHPH([In] EPHCGJILNPO<T> FMOIBCOLJLP);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KECKAPNEMPC();
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface IIMOOJPNIMF<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CJPLMBELNJP([In] BDALKHJLGBL<T> HIDEFGBFHHA);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public struct BDALKHJLGBL<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly T PODCKBKAANA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly bool DDHFAGIFPFE;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x455E700", Offset = "0x455D500", VA = "0x18455E700")]
	public BDALKHJLGBL(T FGNJEPPIFFN, bool IFICGLGLGFA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class IKKHDBJDKFB<T> : EBJFCNIJLMP<DMIFECMCKKH<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x30CE240", Offset = "0x30CD040", VA = "0x1830CE240")]
	public IKKHDBJDKFB(DMIFECMCKKH<T> IOKGEJINEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x375ED60", Offset = "0x375DB60", VA = "0x18375ED60", Slot = "4")]
	public override bool CJPLMBELNJP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class MBLJOJGOFGI<T> : EBJFCNIJLMP<DMIFECMCKKH<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly EPHCGJILNPO<T> FMOIBCOLJLP;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3C940F0", Offset = "0x3C92EF0", VA = "0x183C940F0")]
	public MBLJOJGOFGI(T PODCKBKAANA, DMIFECMCKKH<T> IOKGEJINEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x30CFDC0", Offset = "0x30CEBC0", VA = "0x1830CFDC0", Slot = "4")]
	public override bool CJPLMBELNJP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class BOCAJBMFFBD<T> : EBJFCNIJLMP<IIMOOJPNIMF<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly BDALKHJLGBL<T> HIDEFGBFHHA;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x46DF100", Offset = "0x46DDF00", VA = "0x1846DF100")]
	public BOCAJBMFFBD(T PODCKBKAANA, bool IFICGLGLGFA, IIMOOJPNIMF<T> IOKGEJINEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x30CFDC0", Offset = "0x30CEBC0", VA = "0x1830CFDC0", Slot = "4")]
	public override bool CJPLMBELNJP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct PPOMNDHBBED<TData> where TData : notnull, FIDIKPDPAFF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public IEnumerable<TData> IKOGMKDGFOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public bool ELIEDMCFEBG;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3F11740", Offset = "0x3F10540", VA = "0x183F11740")]
	public PPOMNDHBBED(IEnumerable<TData> AMKELKCBNHF, bool DHIBAPBJGBP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct JJNGBOCNGMI<TData> where TData : notnull, FIDIKPDPAFF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public List<TData> IKOGMKDGFOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public List<bool> HANBJBOJBMF;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x39B6F00", Offset = "0x39B5D00", VA = "0x1839B6F00")]
	public JJNGBOCNGMI(List<TData> AMKELKCBNHF, List<bool> ODMMHOAOKED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface FIDIKPDPAFF
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool FHPDMFJPNJP
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
public interface MHBLBDLDJGF<TData> where TData : FIDIKPDPAFF
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CJPLMBELNJP([In] PPOMNDHBBED<TData> PIOEGKDMENO);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CJPLMBELNJP([In] JJNGBOCNGMI<TData> PIOEGKDMENO);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class DKGCPOILGFO<TData> : EBJFCNIJLMP<MHBLBDLDJGF<TData>> where TData : notnull, FIDIKPDPAFF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly PPOMNDHBBED<TData> PIOEGKDMENO;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x4DA0340", Offset = "0x4D9F140", VA = "0x184DA0340")]
	public DKGCPOILGFO(List<TData> GBDGHJFJEFH, bool ELIEDMCFEBG, MHBLBDLDJGF<TData> IOKGEJINEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x30CFDC0", Offset = "0x30CEBC0", VA = "0x1830CFDC0", Slot = "4")]
	public override bool CJPLMBELNJP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class MLOGFNCGMPB<TData> : EBJFCNIJLMP<MHBLBDLDJGF<TData>> where TData : notnull, FIDIKPDPAFF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly JJNGBOCNGMI<TData> PIOEGKDMENO;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x3CC4420", Offset = "0x3CC3220", VA = "0x183CC4420")]
	public MLOGFNCGMPB(List<TData> GBDGHJFJEFH, List<bool> HANBJBOJBMF, MHBLBDLDJGF<TData> IOKGEJINEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x3CC4360", Offset = "0x3CC3160", VA = "0x183CC4360", Slot = "4")]
	public override bool CJPLMBELNJP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface HNAEPJHPBKM : FIDIKPDPAFF
{
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface HOJBLEHPIJM<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<EGBCHOJPEFI> CJPLMBELNJP(OIIFHGDJMCH<TData> MBBNILAKDAL);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class HCMPMGFEFHJ<TData> : BAPGLOBLCJM<HOJBLEHPIJM<TData>, EGBCHOJPEFI> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct NOJDGOLJPBB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public AsyncTaskMethodBuilder<EGBCHOJPEFI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public HCMPMGFEFHJ<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private TaskAwaiter<EGBCHOJPEFI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x3D31A00", Offset = "0x3D30800", VA = "0x183D31A00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x3D31CF0", Offset = "0x3D30AF0", VA = "0x183D31CF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly OIIFHGDJMCH<TData> EPJHALGFCHD;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x362C450", Offset = "0x362B250", VA = "0x18362C450")]
	public HCMPMGFEFHJ(TData OJAJPBGEJBK, IReadOnlyList<TData> IONLBEHAFOG, bool PFPMHCDNCFF, HOJBLEHPIJM<TData> IOKGEJINEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x362C350", Offset = "0x362B150", VA = "0x18362C350", Slot = "4")]
	[AsyncStateMachine(typeof(HCMPMGFEFHJ<>.NOJDGOLJPBB))]
	public override Task<EGBCHOJPEFI> CJPLMBELNJP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public struct OIIFHGDJMCH<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public TData OBAKEKEAHLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public IReadOnlyList<TData> LDDEHHJBPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public bool LAHMEEMDLBD;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x3DEFDD0", Offset = "0x3DEEBD0", VA = "0x183DEFDD0")]
	public OIIFHGDJMCH(TData OJAJPBGEJBK, IReadOnlyList<TData> IONLBEHAFOG, bool PFPMHCDNCFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface IALCCKHLDPL<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CJPLMBELNJP([In] MOMBJLFGCBO<TData> DPFFIDOHOLC);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface GKGIEBMMINO<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CJPLMBELNJP([In] FIPEHEPIHGN<TData> DPFFIDOHOLC);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface JANMMNFKFPH<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BGHAHDKPDKP([In] LMKELJBKAHE<TData> DPFFIDOHOLC);

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KECKAPNEMPC();
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class PDGFGBNEFDE<TData> : EBJFCNIJLMP<IALCCKHLDPL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly MOMBJLFGCBO<TData> DPFFIDOHOLC;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x3EBC2D0", Offset = "0x3EBB0D0", VA = "0x183EBC2D0")]
	public PDGFGBNEFDE(IEnumerable<TData> GBDGHJFJEFH, CJOLIHLGMIO HBLLOHAOGDJ, KBEEIDBACKN EACDLEEFOLG, float CGEMCKCFGAM, bool PFPMHCDNCFF, IALCCKHLDPL<TData> IOKGEJINEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x30CFDC0", Offset = "0x30CEBC0", VA = "0x1830CFDC0", Slot = "4")]
	public override bool CJPLMBELNJP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public class LJKCIKMBEEL<TData> : EBJFCNIJLMP<GKGIEBMMINO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly FIPEHEPIHGN<TData> DPFFIDOHOLC;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x3ABA0F0", Offset = "0x3AB8EF0", VA = "0x183ABA0F0")]
	public LJKCIKMBEEL(TData[] GBDGHJFJEFH, CJOLIHLGMIO[] HBLLOHAOGDJ, KBEEIDBACKN[] EACDLEEFOLG, float[] CGEMCKCFGAM, GKGIEBMMINO<TData> IOKGEJINEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x3649040", Offset = "0x3647E40", VA = "0x183649040", Slot = "4")]
	public override bool CJPLMBELNJP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class LMEIJNEFJKB<TData> : EBJFCNIJLMP<JANMMNFKFPH<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x30CE240", Offset = "0x30CD040", VA = "0x1830CE240")]
	public LMEIJNEFJKB(JANMMNFKFPH<TData> IOKGEJINEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x3ACAB40", Offset = "0x3AC9940", VA = "0x183ACAB40", Slot = "4")]
	public override bool CJPLMBELNJP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class HHKOJCLBJOL<TData> : EBJFCNIJLMP<JANMMNFKFPH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly LMKELJBKAHE<TData> DPFFIDOHOLC;

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x3649100", Offset = "0x3647F00", VA = "0x183649100")]
	public HHKOJCLBJOL(IEnumerable<TData> GBDGHJFJEFH, CJOLIHLGMIO HBLLOHAOGDJ, KBEEIDBACKN EACDLEEFOLG, float CGEMCKCFGAM, JANMMNFKFPH<TData> IOKGEJINEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x3649040", Offset = "0x3647E40", VA = "0x183649040", Slot = "4")]
	public override bool CJPLMBELNJP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public struct MOMBJLFGCBO<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public IEnumerable<TData> IKOGMKDGFOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public CJOLIHLGMIO PLFNHDOOCAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public KBEEIDBACKN MEMOPEABICF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public float CGEMCKCFGAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public bool PFPMHCDNCFF;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x3CC87B0", Offset = "0x3CC75B0", VA = "0x183CC87B0")]
	public MOMBJLFGCBO(IEnumerable<TData> GBDGHJFJEFH, CJOLIHLGMIO HBLLOHAOGDJ, KBEEIDBACKN EACDLEEFOLG, float CGEMCKCFGAM, bool PFPMHCDNCFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public struct FIPEHEPIHGN<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public TData[] IKOGMKDGFOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public CJOLIHLGMIO[] PLFNHDOOCAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public KBEEIDBACKN[] MEMOPEABICF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public float[] CGEMCKCFGAM;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x3454DA0", Offset = "0x3453BA0", VA = "0x183454DA0")]
	public FIPEHEPIHGN(TData[] GBDGHJFJEFH, CJOLIHLGMIO[] HBLLOHAOGDJ, KBEEIDBACKN[] EACDLEEFOLG, float[] CGEMCKCFGAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public struct LMKELJBKAHE<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public IEnumerable<TData> IKOGMKDGFOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public CJOLIHLGMIO PLFNHDOOCAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public KBEEIDBACKN MEMOPEABICF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public float CGEMCKCFGAM;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x3ACB9E0", Offset = "0x3ACA7E0", VA = "0x183ACB9E0")]
	public LMKELJBKAHE(IEnumerable<TData> GBDGHJFJEFH, CJOLIHLGMIO HBLLOHAOGDJ, KBEEIDBACKN EACDLEEFOLG, float CGEMCKCFGAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface JIEIJFJMBBN<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CLAAIAKOLDB([In] JLMCDJGFLDC<TData> FLPIBCMIMKO);

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NDEEHBJOIBG([In] JLMCDJGFLDC<TData> FLPIBCMIMKO);

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HBAMCCOPEPB([In] bool OJONEIFMENJ);

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JGJIDKMHPOB([In] JLMCDJGFLDC<TData> FLPIBCMIMKO);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EGKFCGFNBFA();

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool KPNAHJFHHIJ([In] TData DOBDAOIIIEM);
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class BFINOLGJIMD<TData> : EBJFCNIJLMP<JIEIJFJMBBN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly JLMCDJGFLDC<TData> FLPIBCMIMKO;

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x4567790", Offset = "0x4566590", VA = "0x184567790")]
	public BFINOLGJIMD(List<TData> BLKANEONNOI, JIEIJFJMBBN<TData> IOKGEJINEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x30CFDC0", Offset = "0x30CEBC0", VA = "0x1830CFDC0", Slot = "4")]
	public override bool CJPLMBELNJP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class LANOGINJEEE<TData> : EBJFCNIJLMP<JIEIJFJMBBN<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x30CE240", Offset = "0x30CD040", VA = "0x1830CE240")]
	public LANOGINJEEE(JIEIJFJMBBN<TData> IOKGEJINEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x3AA0910", Offset = "0x3A9F710", VA = "0x183AA0910", Slot = "4")]
	public override bool CJPLMBELNJP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class KNDANCMCNHP<TData> : EBJFCNIJLMP<JIEIJFJMBBN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly bool PFPMHCDNCFF;

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x3A44970", Offset = "0x3A43770", VA = "0x183A44970")]
	public KNDANCMCNHP(bool PFPMHCDNCFF, JIEIJFJMBBN<TData> IOKGEJINEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x3A44910", Offset = "0x3A43710", VA = "0x183A44910", Slot = "4")]
	public override bool CJPLMBELNJP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class NANIJFAIANK<TData> : EBJFCNIJLMP<JIEIJFJMBBN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly JLMCDJGFLDC<TData> FLPIBCMIMKO;

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3CFF9C0", Offset = "0x3CFE7C0", VA = "0x183CFF9C0")]
	public NANIJFAIANK(List<TData> BLKANEONNOI, bool PFPMHCDNCFF, JIEIJFJMBBN<TData> IOKGEJINEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3CC4360", Offset = "0x3CC3160", VA = "0x183CC4360", Slot = "4")]
	public override bool CJPLMBELNJP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public class LAOOCIEAOBB<TData> : EBJFCNIJLMP<JIEIJFJMBBN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly TData DOBDAOIIIEM;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x3AA0AE0", Offset = "0x3A9F8E0", VA = "0x183AA0AE0")]
	public LAOOCIEAOBB(TData DOBDAOIIIEM, JIEIJFJMBBN<TData> IOKGEJINEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3AA0960", Offset = "0x3A9F760", VA = "0x183AA0960", Slot = "4")]
	public override bool CJPLMBELNJP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class JINLIKBDGCN<TData> : EBJFCNIJLMP<JIEIJFJMBBN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly JLMCDJGFLDC<TData> FLPIBCMIMKO;

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3954CE0", Offset = "0x3953AE0", VA = "0x183954CE0")]
	public JINLIKBDGCN(List<TData> BLKANEONNOI, JIEIJFJMBBN<TData> IOKGEJINEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3954B80", Offset = "0x3953980", VA = "0x183954B80", Slot = "4")]
	public override bool CJPLMBELNJP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public struct JLMCDJGFLDC<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public IEnumerable<TData> IKOGMKDGFOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public bool PFPMHCDNCFF;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x39BDCB0", Offset = "0x39BCAB0", VA = "0x1839BDCB0")]
	public JLMCDJGFLDC(IEnumerable<TData> AMKELKCBNHF, bool DIPAPPHOFFN = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface IENJCHPELDO
{
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<EGBCHOJPEFI> CJPLMBELNJP(CGJFBCNGLCJ JLNJMOLNDBB);
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class MPENKFLLMHP : BAPGLOBLCJM<IENJCHPELDO, EGBCHOJPEFI>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private struct OHNNIHFIBLN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public AsyncTaskMethodBuilder<EGBCHOJPEFI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public MPENKFLLMHP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private TaskAwaiter<EGBCHOJPEFI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x5E161F0", Offset = "0x5E14FF0", VA = "0x185E161F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x5E16470", Offset = "0x5E15270", VA = "0x185E16470", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly CGJFBCNGLCJ LFFGAOHGOBM;

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5E15D40", Offset = "0x5E14B40", VA = "0x185E15D40")]
	public MPENKFLLMHP(bool PFPMHCDNCFF, IENJCHPELDO IOKGEJINEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5E15C50", Offset = "0x5E14A50", VA = "0x185E15C50", Slot = "4")]
	[AsyncStateMachine(typeof(OHNNIHFIBLN))]
	public override Task<EGBCHOJPEFI> CJPLMBELNJP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public struct CGJFBCNGLCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public bool LAHMEEMDLBD;

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0xBA4570", Offset = "0xBA3370", VA = "0x180BA4570")]
	public CGJFBCNGLCJ(bool PFPMHCDNCFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface EHIPONAKIFC<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LHMNHFHCHPH([In] GPNNCHECOIH<TData> CCNPJACADJA);

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BGHAHDKPDKP([In] EKFEPKABMLL EINIPDIKHMO);

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BGHAHDKPDKP([In] MCMCFLOKIOF EINIPDIKHMO);

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool KECKAPNEMPC();
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class LIFHGMFPKBI<TData> : EBJFCNIJLMP<EHIPONAKIFC<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x30CE240", Offset = "0x30CD040", VA = "0x1830CE240")]
	public LIFHGMFPKBI(EHIPONAKIFC<TData> IOKGEJINEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3AB9640", Offset = "0x3AB8440", VA = "0x183AB9640", Slot = "4")]
	public override bool CJPLMBELNJP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class LALIHPDEMKC<TData> : EBJFCNIJLMP<EHIPONAKIFC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly EKFEPKABMLL KJOGKCEMKMM;

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3AA0880", Offset = "0x3A9F680", VA = "0x183AA0880")]
	public LALIHPDEMKC(Vector3 AMEFMLGFKOI, bool IGFNNGAKOKO, EHIPONAKIFC<TData> IOKGEJINEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x342ED80", Offset = "0x342DB80", VA = "0x18342ED80", Slot = "4")]
	public override bool CJPLMBELNJP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class AJKLJCIIBLJ<TData> : EBJFCNIJLMP<EHIPONAKIFC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly MCMCFLOKIOF KJOGKCEMKMM;

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x37B3B10", Offset = "0x37B2910", VA = "0x1837B3B10")]
	public AJKLJCIIBLJ(Guid PALJAKHKHFO, int NGIPPLLBEKC, Vector3 LMGPBOPOFGA, Quaternion BPBCJFMFECG, float CMBCKFHIOMK, bool IGFNNGAKOKO, EHIPONAKIFC<TData> IOKGEJINEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x37B3AB0", Offset = "0x37B28B0", VA = "0x1837B3AB0", Slot = "4")]
	public override bool CJPLMBELNJP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class PCCKKJNCNKE<TData> : EBJFCNIJLMP<EHIPONAKIFC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly GPNNCHECOIH<TData> KJOGKCEMKMM;

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3EBB060", Offset = "0x3EB9E60", VA = "0x183EBB060")]
	public PCCKKJNCNKE(TData PODCKBKAANA, bool PFPMHCDNCFF, EHIPONAKIFC<TData> IOKGEJINEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x30CFDC0", Offset = "0x30CEBC0", VA = "0x1830CFDC0", Slot = "4")]
	public override bool CJPLMBELNJP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public struct EKFEPKABMLL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly Vector3 AMEFMLGFKOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly bool IGFNNGAKOKO;

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x5E15960", Offset = "0x5E14760", VA = "0x185E15960")]
	public EKFEPKABMLL(Vector3 AMEFMLGFKOI, bool IGFNNGAKOKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct MCMCFLOKIOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly Guid PALJAKHKHFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly int NGIPPLLBEKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly Vector3 LMGPBOPOFGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly Quaternion BPBCJFMFECG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly float CMBCKFHIOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly bool IGFNNGAKOKO;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x5E15C10", Offset = "0x5E14A10", VA = "0x185E15C10")]
	public MCMCFLOKIOF(Guid PALJAKHKHFO, int NGIPPLLBEKC, Vector3 LMGPBOPOFGA, Quaternion BPBCJFMFECG, float CMBCKFHIOMK, bool IGFNNGAKOKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public struct GPNNCHECOIH<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly TData PODCKBKAANA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly bool PFPMHCDNCFF;

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3600050", Offset = "0x35FEE50", VA = "0x183600050")]
	public GPNNCHECOIH(TData PODCKBKAANA, bool PFPMHCDNCFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface AHCGKOPNNFN<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CJPLMBELNJP([In] KOHNCEMCJAG<TData> BEBMGAOPDGH);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CJPLMBELNJP([In] AGJHJAPBBFO<TData> BEBMGAOPDGH);
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public interface FBKOIDJENNC<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LHMNHFHCHPH([In] LOBHLLFNOHH<TData> NGNCGBHOFDJ);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BGHAHDKPDKP([In] LJIDKBONMBO EINIPDIKHMO);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KECKAPNEMPC();
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class GEFLBNPCILJ<TData> : EBJFCNIJLMP<AHCGKOPNNFN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly KOHNCEMCJAG<TData> BEBMGAOPDGH;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x35B6AB0", Offset = "0x35B58B0", VA = "0x1835B6AB0")]
	public GEFLBNPCILJ(IEnumerable<TData> GBDGHJFJEFH, Vector3 MHAGDLNFHIB, bool PFPMHCDNCFF, AHCGKOPNNFN<TData> IOKGEJINEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x30CFDC0", Offset = "0x30CEBC0", VA = "0x1830CFDC0", Slot = "4")]
	public override bool CJPLMBELNJP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class DMLFEHDJIBF<TData> : EBJFCNIJLMP<FBKOIDJENNC<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x30CE240", Offset = "0x30CD040", VA = "0x1830CE240")]
	public DMLFEHDJIBF(FBKOIDJENNC<TData> IOKGEJINEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x3DE42F0", Offset = "0x3DE30F0", VA = "0x183DE42F0", Slot = "4")]
	public override bool CJPLMBELNJP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class BAIEDCFOELA<TData> : EBJFCNIJLMP<FBKOIDJENNC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly LOBHLLFNOHH<TData> BEBMGAOPDGH;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x4557540", Offset = "0x4556340", VA = "0x184557540")]
	public BAIEDCFOELA(IEnumerable<TData> GBDGHJFJEFH, bool PFPMHCDNCFF, FBKOIDJENNC<TData> IOKGEJINEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x30CFDC0", Offset = "0x30CEBC0", VA = "0x1830CFDC0", Slot = "4")]
	public override bool CJPLMBELNJP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class OCKAIIPINEP<TData> : EBJFCNIJLMP<AHCGKOPNNFN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly AGJHJAPBBFO<TData> BEBMGAOPDGH;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x3DDE5D0", Offset = "0x3DDD3D0", VA = "0x183DDE5D0")]
	public OCKAIIPINEP(IEnumerable<TData> GBDGHJFJEFH, Vector3 NMELHIMBHNF, NPBPGLBMPCO EBJABIKJMNJ, bool PFPMHCDNCFF, AHCGKOPNNFN<TData> IOKGEJINEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x363A500", Offset = "0x3639300", VA = "0x18363A500", Slot = "4")]
	public override bool CJPLMBELNJP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class FCOLCPODMHF<TData> : EBJFCNIJLMP<FBKOIDJENNC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly LJIDKBONMBO BEBMGAOPDGH;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x342EDE0", Offset = "0x342DBE0", VA = "0x18342EDE0")]
	public FCOLCPODMHF(Vector3 MHAGDLNFHIB, FBKOIDJENNC<TData> IOKGEJINEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x342ED80", Offset = "0x342DB80", VA = "0x18342ED80", Slot = "4")]
	public override bool CJPLMBELNJP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public struct KOHNCEMCJAG<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public readonly IEnumerable<TData> GBDGHJFJEFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public readonly Vector3 MHAGDLNFHIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public readonly bool PFPMHCDNCFF;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x3A46720", Offset = "0x3A45520", VA = "0x183A46720")]
	public KOHNCEMCJAG(IEnumerable<TData> GBDGHJFJEFH, Vector3 MHAGDLNFHIB, bool PFPMHCDNCFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public struct LOBHLLFNOHH<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public readonly IEnumerable<TData> GBDGHJFJEFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly bool PFPMHCDNCFF;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x3ACE590", Offset = "0x3ACD390", VA = "0x183ACE590")]
	public LOBHLLFNOHH(IEnumerable<TData> GBDGHJFJEFH, bool PFPMHCDNCFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public struct AGJHJAPBBFO<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public readonly IEnumerable<TData> GBDGHJFJEFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public readonly Vector3 NMELHIMBHNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public readonly NPBPGLBMPCO EBJABIKJMNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public readonly bool PFPMHCDNCFF;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x37A54F0", Offset = "0x37A42F0", VA = "0x1837A54F0")]
	public AGJHJAPBBFO(IEnumerable<TData> GBDGHJFJEFH, Vector3 NMELHIMBHNF, NPBPGLBMPCO EBJABIKJMNJ, bool PFPMHCDNCFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public struct LJIDKBONMBO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public readonly Vector3 MHAGDLNFHIB;

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x2004C20", Offset = "0x2003A20", VA = "0x182004C20")]
	public LJIDKBONMBO(Vector3 MHAGDLNFHIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public enum NPBPGLBMPCO
{
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	XYZ,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	X_only,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	Y_only,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	Z_only
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public interface KCMIPPFOOBL<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CJPLMBELNJP([In] GDEJIMOEPNP<TData> OEFFFBLCCOH);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CJPLMBELNJP([In] KFKFCJKNNLK<TData> OEFFFBLCCOH);
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public interface GOGAGDGLLOH<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LHMNHFHCHPH([In] DEAEODCICCC<TData> CCNPJACADJA);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BGHAHDKPDKP([In] JCJEGKCDBNH EINIPDIKHMO);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KECKAPNEMPC();
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public class ECIDBHIMOLD<TData> : EBJFCNIJLMP<KCMIPPFOOBL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly GDEJIMOEPNP<TData> OEFFFBLCCOH;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x30CFE80", Offset = "0x30CEC80", VA = "0x1830CFE80")]
	public ECIDBHIMOLD(IEnumerable<TData> GBDGHJFJEFH, Quaternion MHAGDLNFHIB, Vector3? BLICAPGDGNN, bool CIAPCOGIBLC, bool PFPMHCDNCFF, KCMIPPFOOBL<TData> IOKGEJINEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x30CFDC0", Offset = "0x30CEBC0", VA = "0x1830CFDC0", Slot = "4")]
	public override bool CJPLMBELNJP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class PAHMAIJCCJG<TData> : EBJFCNIJLMP<GOGAGDGLLOH<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x30CE240", Offset = "0x30CD040", VA = "0x1830CE240")]
	public PAHMAIJCCJG(GOGAGDGLLOH<TData> IOKGEJINEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x3DE42F0", Offset = "0x3DE30F0", VA = "0x183DE42F0", Slot = "4")]
	public override bool CJPLMBELNJP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class JDMOLNDGBGF<TData> : EBJFCNIJLMP<GOGAGDGLLOH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly DEAEODCICCC<TData> OEFFFBLCCOH;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x3948B00", Offset = "0x3947900", VA = "0x183948B00")]
	public JDMOLNDGBGF(IEnumerable<TData> GBDGHJFJEFH, bool PFPMHCDNCFF, GOGAGDGLLOH<TData> IOKGEJINEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x30CFDC0", Offset = "0x30CEBC0", VA = "0x1830CFDC0", Slot = "4")]
	public override bool CJPLMBELNJP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class CFOMBPNFEAO<TData> : EBJFCNIJLMP<KCMIPPFOOBL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly KFKFCJKNNLK<TData> OEFFFBLCCOH;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x49B5F10", Offset = "0x49B4D10", VA = "0x1849B5F10")]
	public CFOMBPNFEAO(IEnumerable<TData> GBDGHJFJEFH, Quaternion OBGGFGNIFHK, NPBPGLBMPCO BNAIMGFBGPA, Vector3? BLICAPGDGNN, bool CIAPCOGIBLC, bool PFPMHCDNCFF, KCMIPPFOOBL<TData> IOKGEJINEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x363A500", Offset = "0x3639300", VA = "0x18363A500", Slot = "4")]
	public override bool CJPLMBELNJP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class NBKDJBEGDMP<TData> : EBJFCNIJLMP<GOGAGDGLLOH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly JCJEGKCDBNH OEFFFBLCCOH;

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x3CFFEF0", Offset = "0x3CFECF0", VA = "0x183CFFEF0")]
	public NBKDJBEGDMP(Quaternion MHAGDLNFHIB, Vector3? BLICAPGDGNN, bool CIAPCOGIBLC, GOGAGDGLLOH<TData> IOKGEJINEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x342ED80", Offset = "0x342DB80", VA = "0x18342ED80", Slot = "4")]
	public override bool CJPLMBELNJP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public struct GDEJIMOEPNP<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public readonly IEnumerable<TData> GBDGHJFJEFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public readonly Quaternion MHAGDLNFHIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public readonly Vector3? BLICAPGDGNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public readonly bool CIAPCOGIBLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public readonly bool PFPMHCDNCFF;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x3579C70", Offset = "0x3578A70", VA = "0x183579C70")]
	public GDEJIMOEPNP(IEnumerable<TData> GBDGHJFJEFH, Quaternion MHAGDLNFHIB, Vector3? BLICAPGDGNN, bool CIAPCOGIBLC, bool PFPMHCDNCFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct DEAEODCICCC<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public readonly IEnumerable<TData> GBDGHJFJEFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly bool PFPMHCDNCFF;

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x4D7A270", Offset = "0x4D79070", VA = "0x184D7A270")]
	public DEAEODCICCC(IEnumerable<TData> GBDGHJFJEFH, bool PFPMHCDNCFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct KFKFCJKNNLK<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public readonly IEnumerable<TData> GBDGHJFJEFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly Quaternion OBGGFGNIFHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public readonly NPBPGLBMPCO BNAIMGFBGPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public readonly Vector3? BLICAPGDGNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public readonly bool CIAPCOGIBLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public readonly bool PFPMHCDNCFF;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x3A37560", Offset = "0x3A36360", VA = "0x183A37560")]
	public KFKFCJKNNLK(IEnumerable<TData> GBDGHJFJEFH, Quaternion OBGGFGNIFHK, NPBPGLBMPCO BNAIMGFBGPA, Vector3? BLICAPGDGNN, bool CIAPCOGIBLC, bool PFPMHCDNCFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct JCJEGKCDBNH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public readonly Quaternion MHAGDLNFHIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public readonly Vector3? BLICAPGDGNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public readonly bool CIAPCOGIBLC;

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x43A8DC0", Offset = "0x43A7BC0", VA = "0x1843A8DC0")]
	public JCJEGKCDBNH(Quaternion MHAGDLNFHIB, Vector3? BLICAPGDGNN, bool CIAPCOGIBLC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public interface AENOGDAALHL<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LHMNHFHCHPH([In] KFEKBCBHKND<TData> CCNPJACADJA);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BGHAHDKPDKP([In] HJGAAAKEPDL EINIPDIKHMO);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BGHAHDKPDKP([In] HBKEACJHGKE EINIPDIKHMO);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool BGHAHDKPDKP([In] KEBKJJLNIOA EINIPDIKHMO);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool KECKAPNEMPC();
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public class HGFCNOKHMGB<TData> : EBJFCNIJLMP<AENOGDAALHL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly KEBKJJLNIOA PDGNDHBFINI;

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3642530", Offset = "0x3641330", VA = "0x183642530")]
	public HGFCNOKHMGB(Vector3 GFGAIIIAAPM, float LKLBEHBFPBB, Vector3 BLICAPGDGNN, bool HIFMJKENNED, bool MNPFKMNDKBN, AENOGDAALHL<TData> IOKGEJINEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x36424D0", Offset = "0x36412D0", VA = "0x1836424D0", Slot = "4")]
	public override bool CJPLMBELNJP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public class BPADPAPGGFN<TData> : EBJFCNIJLMP<AENOGDAALHL<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x30CE240", Offset = "0x30CD040", VA = "0x1830CE240")]
	public BPADPAPGGFN(AENOGDAALHL<TData> IOKGEJINEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x46EAAB0", Offset = "0x46E98B0", VA = "0x1846EAAB0", Slot = "4")]
	public override bool CJPLMBELNJP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public class IBHNFAFDEFB<TData> : EBJFCNIJLMP<AENOGDAALHL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly KFEKBCBHKND<TData> PDGNDHBFINI;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x37249F0", Offset = "0x37237F0", VA = "0x1837249F0")]
	public IBHNFAFDEFB(IEnumerable<TData> GBDGHJFJEFH, bool PFPMHCDNCFF, AENOGDAALHL<TData> IOKGEJINEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x30CFDC0", Offset = "0x30CEBC0", VA = "0x1830CFDC0", Slot = "4")]
	public override bool CJPLMBELNJP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class JAMGDKFCGBD<TData> : EBJFCNIJLMP<AENOGDAALHL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly HBKEACJHGKE PDGNDHBFINI;

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x3915450", Offset = "0x3914250", VA = "0x183915450")]
	public JAMGDKFCGBD(float CHAHMPHBEHF, bool CKHDBNOMHLI, Vector3 BLICAPGDGNN, AENOGDAALHL<TData> IOKGEJINEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x3915380", Offset = "0x3914180", VA = "0x183915380", Slot = "4")]
	public override bool CJPLMBELNJP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public class LLAOEEBMPID<TData> : EBJFCNIJLMP<AENOGDAALHL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly HJGAAAKEPDL PDGNDHBFINI;

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x3AC5CF0", Offset = "0x3AC4AF0", VA = "0x183AC5CF0")]
	public LLAOEEBMPID(float LKLBEHBFPBB, Vector3 BLICAPGDGNN, AENOGDAALHL<TData> IOKGEJINEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x342ED80", Offset = "0x342DB80", VA = "0x18342ED80", Slot = "4")]
	public override bool CJPLMBELNJP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct KEBKJJLNIOA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public readonly Vector3 GFGAIIIAAPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public readonly float LKLBEHBFPBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public readonly Vector3 BLICAPGDGNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public readonly bool IGFNNGAKOKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public readonly bool MNPFKMNDKBN;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x5E15BD0", Offset = "0x5E149D0", VA = "0x185E15BD0")]
	public KEBKJJLNIOA(Vector3 GFGAIIIAAPM, float LKLBEHBFPBB, Vector3 BLICAPGDGNN, bool IGFNNGAKOKO, bool KAAEODCNDLK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public struct KFEKBCBHKND<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public readonly IEnumerable<TData> GBDGHJFJEFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public readonly bool PFPMHCDNCFF;

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x3A358D0", Offset = "0x3A346D0", VA = "0x183A358D0")]
	public KFEKBCBHKND(IEnumerable<TData> GBDGHJFJEFH, bool PFPMHCDNCFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public struct HBKEACJHGKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly float CHAHMPHBEHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public readonly bool CKHDBNOMHLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public readonly Vector3 BLICAPGDGNN;

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x5E15BB0", Offset = "0x5E149B0", VA = "0x185E15BB0")]
	public HBKEACJHGKE(float CHAHMPHBEHF, bool CKHDBNOMHLI, Vector3 BLICAPGDGNN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct HJGAAAKEPDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public readonly float LKLBEHBFPBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public readonly Vector3 BLICAPGDGNN;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x43855E0", Offset = "0x43843E0", VA = "0x1843855E0")]
	public HJGAAAKEPDL(float LKLBEHBFPBB, Vector3 BLICAPGDGNN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public static class OBLOGDGOAKL
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	private struct MBKCCIGECAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public bool DNHELIHABCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public KIDCBAFLGEK NLOHJKGMKAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public KIDCBAFLGEK OHLMAAHEMAG;
	}

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static MBKCCIGECAI FJAGJHGPBDL;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static CancellationToken IDCBGCHLKGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x5E15F20", Offset = "0x5E14D20", VA = "0x185E15F20")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	internal static KIDCBAFLGEK NLOHJKGMKAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x5E15F40", Offset = "0x5E14D40", VA = "0x185E15F40")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x5E16180", Offset = "0x5E14F80", VA = "0x185E16180")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5E15E20", Offset = "0x5E14C20", VA = "0x185E15E20")]
	[IBKPEPPEMNJ(INBBGMADPCI.Room, MIBJABCBNEH.None)]
	private static void BJNGLCECMKE(KIDCBAFLGEK EDGGANIBCGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5E15FE0", Offset = "0x5E14DE0", VA = "0x185E15FE0")]
	public static void KICOEKABIEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x5E16130", Offset = "0x5E14F30", VA = "0x185E16130")]
	private static KIDCBAFLGEK NBFMCFMBHFE(KIDCBAFLGEK KCGPCMINGIH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public static class CAPAJKKPGAG
{
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public enum NFFLJMAJOOM
	{
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		ICreationContextObject,
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		Guid
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x23108E0", Offset = "0x230F6E0", VA = "0x1823108E0")]
	public static void EPJAJOBBIBM<T>(T PCALNAMFDCK, NFFLJMAJOOM AOPDMLJGEMB) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x2310880", Offset = "0x230F680", VA = "0x182310880")]
	public static void EPJAJOBBIBM<T>(T PCALNAMFDCK) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x2310AC0", Offset = "0x230F8C0", VA = "0x182310AC0")]
	public static void NOFDEFLEJEK<T>(T PCALNAMFDCK) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x2310A20", Offset = "0x230F820", VA = "0x182310A20")]
	public static T HFNEOIKDHBA<T>(NFFLJMAJOOM AOPDMLJGEMB) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x23107A0", Offset = "0x230F5A0", VA = "0x1823107A0")]
	public static bool EKHJCHMIBDF<T>(NFFLJMAJOOM AOPDMLJGEMB) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x2310840", Offset = "0x230F640", VA = "0x182310840")]
	public static T HFNEOIKDHBA<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x2310840", Offset = "0x230F640", VA = "0x182310840")]
	public static bool EKHJCHMIBDF<T>() where T : class
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
internal static class GBOENADOMJC
{
	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x5E15980", Offset = "0x5E14780", VA = "0x185E15980")]
	public static void CJLPFCJIJLP(IEnumerable KIFCOLGCJBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x24EE6A0", Offset = "0x24ED4A0", VA = "0x1824EE6A0")]
	public static void CJLPFCJIJLP<T>(T[] LPMIAHOCPLL) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x24EE790", Offset = "0x24ED590", VA = "0x1824EE790")]
	public static void CJLPFCJIJLP<T>(T AONAOKPLIKJ) where T : notnull, Enum
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
