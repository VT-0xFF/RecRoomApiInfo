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
		[Cpp2IlInjected.Address(RVA = "0x78C450", Offset = "0x78B250", VA = "0x18078C450")]
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
		[Cpp2IlInjected.Address(RVA = "0x5D02AD0", Offset = "0x5D018D0", VA = "0x185D02AD0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x78C910", Offset = "0x78B710", VA = "0x18078C910")]
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
		[Cpp2IlInjected.Address(RVA = "0x78C950", Offset = "0x78B750", VA = "0x18078C950")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface AGLOMLMFIDJ<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ClearHoverTarget(HHBHGLEIDCB HINEAEMFAII);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool SetHoverTarget(TData CJKEIGLKDDB, Collider OGBKNMCLIKJ, HHBHGLEIDCB HINEAEMFAII, [Optional] NBDHLNCBJFN? DEMOCHAHEKD);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool TryGetHoverTarget([Out] TData CJKEIGLKDDB);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface EJFENPOMEJF<TData> : HJJDAFLJNAE, IFBANAIHPIB<TData>, DJKEKNEGLJD<TData>, EHBPGIIOKHC<TData>, HKKFDACEKND, DHGHFEODEAC<TData>, OBDGEEAABGA, OBNDALPFEED
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface DHGHFEODEAC<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 JLBMPBJBLDH, Vector3 IELHLOGPMDL, float NGLNDDJFMFL, [Out] T BKNNCIOLEAJ, [Out] Vector3 JOPLANPIGLH, [Out] Collider OGBKNMCLIKJ);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 JLBMPBJBLDH, Vector3 IELHLOGPMDL, float NMAHCGGEGBC, float NGLNDDJFMFL, T[] CEOKANMJCPI, [Out] Vector3 LAGOLHHPGJL, [Out] Collider AJBBLMDJKKL);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 JLBMPBJBLDH, float NMAHCGGEGBC, Vector3 LHHFCELNBLO, T[] CEOKANMJCPI);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface HJJDAFLJNAE
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Bounds PMAIOPJGGJE
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Transform KBDIFIOIKHI
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Bounds GHMAKEJOGNF
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Transform HBBHKADKPHO
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Vector3 MIFHMJHBFIL
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void SetSelectionBoundsDirty(bool OMPLABDEIGO = true, int KECJNOPIEBK = 0);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ShouldHideSelectionBoundsPreview(bool AEPPGCIFKFA, object PFKLELGAJPH);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface OBNDALPFEED
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	ECJBBEDPNJE MDMFFMKENBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface EHBPGIIOKHC<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool GJGJPNKLONA
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	int IMJCHAKCCPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	IEnumerable<TData> AMDFNNGAEOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData PEGAJFMFKFI);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData PEGAJFMFKFI);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface IFBANAIHPIB<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T HBDENJGMDDF, [Optional] NBDHLNCBJFN? ABJDJAMBLGG, bool GPPCDBIGHGJ = true);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int HLFCMANHPKF, IEnumerable<T> CAMGNALCBNB, bool GPPCDBIGHGJ = true);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int HLFCMANHPKF, IEnumerable<T> CAMGNALCBNB, NBDHLNCBJFN ABJDJAMBLGG, bool GPPCDBIGHGJ = true);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface OBDGEEAABGA
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface HKKFDACEKND
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool NOHIMBJCOJA
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool NIPCOEKAOIL
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool HEAKJPJKHCE
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool GIHHAGFOMDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class IHEBIHKNKML<TReceiver> : MGNDKIPFDLG<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x30212C0", Offset = "0x30200C0", VA = "0x1830212C0")]
	public IHEBIHKNKML(TReceiver ACKIIDNLPEH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public abstract class IHBKHGBCANK<TReceiver, TFromTask> : MGNDKIPFDLG<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x30212C0", Offset = "0x30200C0", VA = "0x1830212C0")]
	public IHBKHGBCANK(TReceiver ACKIIDNLPEH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class MGNDKIPFDLG<TReceiver, TFromExecute> where TReceiver : notnull where TFromExecute : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	protected TReceiver ACKIIDNLPEH;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3B28B40", Offset = "0x3B27940", VA = "0x183B28B40")]
	public MGNDKIPFDLG(TReceiver ACKIIDNLPEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute FEFPMOEDJPP();
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct MPMAPGLEJDE<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public TNode HHAEEFPFHBB;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3B7AEA0", Offset = "0x3B79CA0", VA = "0x183B7AEA0")]
	public MPMAPGLEJDE(TNode HHAEEFPFHBB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct KJDJCKDDPKD<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public TNode DEAECBMPHAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public ABGKNGDBBEG HBFELBINAND;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3898A80", Offset = "0x3897880", VA = "0x183898A80")]
	public KJDJCKDDPKD(TNode DEAECBMPHAK, ABGKNGDBBEG HBFELBINAND)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface IHJDJMPABLG<TNode>
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HNKNNCKKOBK([In] MPMAPGLEJDE<TNode> DHNHNCCFGHM);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GLNNKOFIICD([In] KJDJCKDDPKD<TNode> GGHEDIHDNIG);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MLMDFINGFDL();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class NMGLDCGAOHH<TNode> : IHEBIHKNKML<IHJDJMPABLG<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x30212C0", Offset = "0x30200C0", VA = "0x1830212C0")]
	public NMGLDCGAOHH(IHJDJMPABLG<TNode> ACKIIDNLPEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3580C80", Offset = "0x357FA80", VA = "0x183580C80", Slot = "4")]
	public override bool FEFPMOEDJPP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class IKAEFJAFACB<TNode> : IHEBIHKNKML<IHJDJMPABLG<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly KJDJCKDDPKD<TNode> GGHEDIHDNIG;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x36835E0", Offset = "0x36823E0", VA = "0x1836835E0")]
	public IKAEFJAFACB(TNode DEAECBMPHAK, ABGKNGDBBEG HBFELBINAND, IHJDJMPABLG<TNode> ACKIIDNLPEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x365CD60", Offset = "0x365BB60", VA = "0x18365CD60", Slot = "4")]
	public override bool FEFPMOEDJPP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class NLNBLGMJEGD<TNode> : IHEBIHKNKML<IHJDJMPABLG<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly MPMAPGLEJDE<TNode> DHNHNCCFGHM;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3BE4020", Offset = "0x3BE2E20", VA = "0x183BE4020")]
	public NLNBLGMJEGD(TNode JAGBBGGBFDK, IHJDJMPABLG<TNode> ACKIIDNLPEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x33DAE00", Offset = "0x33D9C00", VA = "0x1833DAE00", Slot = "4")]
	public override bool FEFPMOEDJPP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct ODIIFDICAFD<TSpawnInfo> where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public TSpawnInfo AKKIANMJGIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public Vector3 AILFIIEAPKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public Quaternion GIBIBDOGOLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public float GBJGBGCFEKM;

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0xD50400", Offset = "0xD4F200", VA = "0x180D50400")]
	public ODIIFDICAFD(TSpawnInfo AKKIANMJGIK, Vector3 AILFIIEAPKM, Quaternion GIBIBDOGOLL, float GBJGBGCFEKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface HHJPJHAOLPL<TSpawnType, TSpawnInfo>
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> LMMNNPDLLDN([In] ODIIFDICAFD<TSpawnInfo> DBGMLBHEFEK, CancellationToken BIBHFGFDEGJ);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class EKFHMGAACGJ<TSpawnType, TSpawnInfo> : IHBKHGBCANK<HHJPJHAOLPL<TSpawnType, TSpawnInfo>, TSpawnType> where TSpawnType : notnull where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly ODIIFDICAFD<TSpawnInfo> HGIPKCLMBHH;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3060A10", Offset = "0x305F810", VA = "0x183060A10")]
	public EKFHMGAACGJ(TSpawnInfo DFHKLMPENPG, Vector3 AILFIIEAPKM, Quaternion GIBIBDOGOLL, float GBJGBGCFEKM, HHJPJHAOLPL<TSpawnType, TSpawnInfo> ACKIIDNLPEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3060930", Offset = "0x305F730", VA = "0x183060930", Slot = "4")]
	public override Task<TSpawnType> FEFPMOEDJPP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public readonly struct OLDKDFLCJFK<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly IEnumerable<TData> BPCPFBINHIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public readonly bool KPBPNKKAKPD;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3D2F080", Offset = "0x3D2DE80", VA = "0x183D2F080")]
	public OLDKDFLCJFK(IEnumerable<TData> KMBJFBAPJAJ, bool MMCNBOKILPH = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface AKKCFFILMPF<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<PMFGGLHKBIM> GPGGFNJOIDD([In] OLDKDFLCJFK<TData> MILHOGPLHGP, CancellationToken BIBHFGFDEGJ);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class HMCKNOPNNGM<TData> : IHBKHGBCANK<AKKCFFILMPF<TData>, PMFGGLHKBIM> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly OLDKDFLCJFK<TData> HPACKJOMCJE;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x35A84B0", Offset = "0x35A72B0", VA = "0x1835A84B0")]
	public HMCKNOPNNGM(IEnumerable<TData> KMBJFBAPJAJ, bool MMCNBOKILPH, AKKCFFILMPF<TData> ACKIIDNLPEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3060930", Offset = "0x305F730", VA = "0x183060930", Slot = "4")]
	public override Task<PMFGGLHKBIM> FEFPMOEDJPP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct DNOHDAGNOIJ<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly T CJKEIGLKDDB;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x41F7D50", Offset = "0x41F6B50", VA = "0x1841F7D50")]
	public DNOHDAGNOIJ(T OKALHNELMLE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface HPHJCEGGFEN<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HNKNNCKKOBK([In] DNOHDAGNOIJ<T> NCEEDCGBNJG);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GLNNKOFIICD();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface JNBFDLLFDFB<T>
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FEFPMOEDJPP([In] FBPAJLAIAEI<T> EOLHKFJPOFF);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct FBPAJLAIAEI<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly T CJKEIGLKDDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly bool BLFHKECEMIK;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x33CE330", Offset = "0x33CD130", VA = "0x1833CE330")]
	public FBPAJLAIAEI(T OKALHNELMLE, bool DOOPPIGJAAB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class FOAPMEGEKDD<T> : IHEBIHKNKML<HPHJCEGGFEN<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x30212C0", Offset = "0x30200C0", VA = "0x1830212C0")]
	public FOAPMEGEKDD(HPHJCEGGFEN<T> ACKIIDNLPEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3409F10", Offset = "0x3408D10", VA = "0x183409F10", Slot = "4")]
	public override bool FEFPMOEDJPP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class ACCDHODIHNL<T> : IHEBIHKNKML<HPHJCEGGFEN<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly DNOHDAGNOIJ<T> NCEEDCGBNJG;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3459280", Offset = "0x3458080", VA = "0x183459280")]
	public ACCDHODIHNL(T CJKEIGLKDDB, HPHJCEGGFEN<T> ACKIIDNLPEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x33DAE00", Offset = "0x33D9C00", VA = "0x1833DAE00", Slot = "4")]
	public override bool FEFPMOEDJPP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class FHIKBNKHLLD<T> : IHEBIHKNKML<JNBFDLLFDFB<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly FBPAJLAIAEI<T> EOLHKFJPOFF;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x33DAEC0", Offset = "0x33D9CC0", VA = "0x1833DAEC0")]
	public FHIKBNKHLLD(T CJKEIGLKDDB, bool DOOPPIGJAAB, JNBFDLLFDFB<T> ACKIIDNLPEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x33DAE00", Offset = "0x33D9C00", VA = "0x1833DAE00", Slot = "4")]
	public override bool FEFPMOEDJPP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct LPPPHMPFHAJ<TData> where TData : notnull, DAMAGGHJDLA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public IEnumerable<TData> BPCPFBINHIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public bool JBIKIFBADNE;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3963DA0", Offset = "0x3962BA0", VA = "0x183963DA0")]
	public LPPPHMPFHAJ(IEnumerable<TData> DFJNEHGMLFD, bool NGPMNEHPOOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct NFMPBDDMLLJ<TData> where TData : notnull, DAMAGGHJDLA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public List<TData> BPCPFBINHIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public List<bool> OMEDOLNMGNP;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3BC6DC0", Offset = "0x3BC5BC0", VA = "0x183BC6DC0")]
	public NFMPBDDMLLJ(List<TData> DFJNEHGMLFD, List<bool> KHGMOLJAMEH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface DAMAGGHJDLA
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool ANMLONKNDHC
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
public interface PPOHOKDDFNC<TData> where TData : DAMAGGHJDLA
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FEFPMOEDJPP([In] LPPPHMPFHAJ<TData> NFIFPGGGIPF);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FEFPMOEDJPP([In] NFMPBDDMLLJ<TData> NFIFPGGGIPF);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class ABGMDJKIFCJ<TData> : IHEBIHKNKML<PPOHOKDDFNC<TData>> where TData : notnull, DAMAGGHJDLA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly LPPPHMPFHAJ<TData> NFIFPGGGIPF;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3457B40", Offset = "0x3456940", VA = "0x183457B40")]
	public ABGMDJKIFCJ(List<TData> KMBJFBAPJAJ, bool JBIKIFBADNE, PPOHOKDDFNC<TData> ACKIIDNLPEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x33DAE00", Offset = "0x33D9C00", VA = "0x1833DAE00", Slot = "4")]
	public override bool FEFPMOEDJPP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class LEFPNMMEFHI<TData> : IHEBIHKNKML<PPOHOKDDFNC<TData>> where TData : notnull, DAMAGGHJDLA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly NFMPBDDMLLJ<TData> NFIFPGGGIPF;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x393DB40", Offset = "0x393C940", VA = "0x18393DB40")]
	public LEFPNMMEFHI(List<TData> KMBJFBAPJAJ, List<bool> OMEDOLNMGNP, PPOHOKDDFNC<TData> ACKIIDNLPEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x393DA80", Offset = "0x393C880", VA = "0x18393DA80", Slot = "4")]
	public override bool FEFPMOEDJPP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface HGKJBDONPAD : DAMAGGHJDLA
{
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface EHMHGPHOGLH<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<PMFGGLHKBIM> FEFPMOEDJPP(OMLAAMGHODF<TData> AIIBLEOEHDI);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class GLELPIALMAC<TData> : IHBKHGBCANK<EHMHGPHOGLH<TData>, PMFGGLHKBIM> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct KOAKLMOHGKL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public AsyncTaskMethodBuilder<PMFGGLHKBIM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public GLELPIALMAC<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private TaskAwaiter<PMFGGLHKBIM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x38ADAD0", Offset = "0x38AC8D0", VA = "0x1838ADAD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x38ADDC0", Offset = "0x38ACBC0", VA = "0x1838ADDC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly OMLAAMGHODF<TData> FLLCHACCPDO;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x34C9930", Offset = "0x34C8730", VA = "0x1834C9930")]
	public GLELPIALMAC(TData HMAMFEOOBOA, IReadOnlyList<TData> BDLJHDDHOON, bool MMCNBOKILPH, EHMHGPHOGLH<TData> ACKIIDNLPEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x34C9830", Offset = "0x34C8630", VA = "0x1834C9830", Slot = "4")]
	[AsyncStateMachine(typeof(GLELPIALMAC<>.KOAKLMOHGKL))]
	public override Task<PMFGGLHKBIM> FEFPMOEDJPP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct OMLAAMGHODF<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public TData GLAPAMKAIBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public IReadOnlyList<TData> MKEDMLCKHAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public bool KPBPNKKAKPD;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3D39A10", Offset = "0x3D38810", VA = "0x183D39A10")]
	public OMLAAMGHODF(TData HMAMFEOOBOA, IReadOnlyList<TData> BDLJHDDHOON, bool MMCNBOKILPH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface EKJOCGPCFPO<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FEFPMOEDJPP([In] AEGNIADLEMF<TData> APDFNNJCNPP);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface AGDPMGPFOFF<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FEFPMOEDJPP([In] HDCPLPCFJJD<TData> APDFNNJCNPP);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface LFDOHBAILED<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EGOFLCCOAMN([In] AGEDLMIPEDN<TData> APDFNNJCNPP);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GLNNKOFIICD();
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public class LHJNIHDJFKL<TData> : IHEBIHKNKML<EKJOCGPCFPO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly AEGNIADLEMF<TData> APDFNNJCNPP;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3947020", Offset = "0x3945E20", VA = "0x183947020")]
	public LHJNIHDJFKL(IEnumerable<TData> KMBJFBAPJAJ, BFHLAJAHGLH BJLKCDOCMJA, OCALJDDBKKL DDNJBDIAIEB, float MFFNJELLFOL, bool MMCNBOKILPH, EKJOCGPCFPO<TData> ACKIIDNLPEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x33DAE00", Offset = "0x33D9C00", VA = "0x1833DAE00", Slot = "4")]
	public override bool FEFPMOEDJPP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class LJMGOGHDANC<TData> : IHEBIHKNKML<AGDPMGPFOFF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly HDCPLPCFJJD<TData> APDFNNJCNPP;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3954260", Offset = "0x3953060", VA = "0x183954260")]
	public LJMGOGHDANC(TData[] KMBJFBAPJAJ, BFHLAJAHGLH[] BJLKCDOCMJA, OCALJDDBKKL[] DDNJBDIAIEB, float[] MFFNJELLFOL, AGDPMGPFOFF<TData> ACKIIDNLPEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3894B90", Offset = "0x3893990", VA = "0x183894B90", Slot = "4")]
	public override bool FEFPMOEDJPP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class GNIPBLHJGNF<TData> : IHEBIHKNKML<LFDOHBAILED<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x30212C0", Offset = "0x30200C0", VA = "0x1830212C0")]
	public GNIPBLHJGNF(LFDOHBAILED<TData> ACKIIDNLPEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x34E00C0", Offset = "0x34DEEC0", VA = "0x1834E00C0", Slot = "4")]
	public override bool FEFPMOEDJPP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class KFPDLOLOCBG<TData> : IHEBIHKNKML<LFDOHBAILED<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly AGEDLMIPEDN<TData> APDFNNJCNPP;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x3894C50", Offset = "0x3893A50", VA = "0x183894C50")]
	public KFPDLOLOCBG(IEnumerable<TData> KMBJFBAPJAJ, BFHLAJAHGLH BJLKCDOCMJA, OCALJDDBKKL DDNJBDIAIEB, float MFFNJELLFOL, LFDOHBAILED<TData> ACKIIDNLPEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x3894B90", Offset = "0x3893990", VA = "0x183894B90", Slot = "4")]
	public override bool FEFPMOEDJPP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct AEGNIADLEMF<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public IEnumerable<TData> BPCPFBINHIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public BFHLAJAHGLH MKICFNHIEHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public OCALJDDBKKL CCNKODIFEIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public float MFFNJELLFOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public bool MMCNBOKILPH;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3460B50", Offset = "0x345F950", VA = "0x183460B50")]
	public AEGNIADLEMF(IEnumerable<TData> KMBJFBAPJAJ, BFHLAJAHGLH BJLKCDOCMJA, OCALJDDBKKL DDNJBDIAIEB, float MFFNJELLFOL, bool MMCNBOKILPH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct HDCPLPCFJJD<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public TData[] BPCPFBINHIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public BFHLAJAHGLH[] MKICFNHIEHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public OCALJDDBKKL[] CCNKODIFEIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public float[] MFFNJELLFOL;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x356EDB0", Offset = "0x356DBB0", VA = "0x18356EDB0")]
	public HDCPLPCFJJD(TData[] KMBJFBAPJAJ, BFHLAJAHGLH[] BJLKCDOCMJA, OCALJDDBKKL[] DDNJBDIAIEB, float[] MFFNJELLFOL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct AGEDLMIPEDN<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public IEnumerable<TData> BPCPFBINHIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public BFHLAJAHGLH MKICFNHIEHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public OCALJDDBKKL CCNKODIFEIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public float MFFNJELLFOL;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x3488690", Offset = "0x3487490", VA = "0x183488690")]
	public AGEDLMIPEDN(IEnumerable<TData> KMBJFBAPJAJ, BFHLAJAHGLH BJLKCDOCMJA, OCALJDDBKKL DDNJBDIAIEB, float MFFNJELLFOL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface DJKEKNEGLJD<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MMACJIEGMEG([In] HLCHGPDGDGK<TData> MILHOGPLHGP);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CDOBKKOOICI([In] HLCHGPDGDGK<TData> MILHOGPLHGP);

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OAHOHGHOGPB([In] bool FFMCJGODGEN);

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool KMLAOCOHGNF([In] HLCHGPDGDGK<TData> MILHOGPLHGP);

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BBHNKPCKIPB();

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool ADDGMJDMHBN([In] TData MDDOMNBENCJ);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class NLFDJMDKLOP<TData> : IHEBIHKNKML<DJKEKNEGLJD<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly HLCHGPDGDGK<TData> MILHOGPLHGP;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x3BE38D0", Offset = "0x3BE26D0", VA = "0x183BE38D0")]
	public NLFDJMDKLOP(List<TData> LJMPIGIKCCJ, DJKEKNEGLJD<TData> ACKIIDNLPEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x33DAE00", Offset = "0x33D9C00", VA = "0x1833DAE00", Slot = "4")]
	public override bool FEFPMOEDJPP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class KNLMMMJLEKA<TData> : IHEBIHKNKML<DJKEKNEGLJD<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x30212C0", Offset = "0x30200C0", VA = "0x1830212C0")]
	public KNLMMMJLEKA(DJKEKNEGLJD<TData> ACKIIDNLPEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x38A7A50", Offset = "0x38A6850", VA = "0x1838A7A50", Slot = "4")]
	public override bool FEFPMOEDJPP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class HHIOMLLDNPL<TData> : IHEBIHKNKML<DJKEKNEGLJD<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly bool MMCNBOKILPH;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x3580C30", Offset = "0x357FA30", VA = "0x183580C30")]
	public HHIOMLLDNPL(bool MMCNBOKILPH, DJKEKNEGLJD<TData> ACKIIDNLPEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x3580BD0", Offset = "0x357F9D0", VA = "0x183580BD0", Slot = "4")]
	public override bool FEFPMOEDJPP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class NGKPAMGIBFA<TData> : IHEBIHKNKML<DJKEKNEGLJD<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly HLCHGPDGDGK<TData> MILHOGPLHGP;

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x3BD1100", Offset = "0x3BCFF00", VA = "0x183BD1100")]
	public NGKPAMGIBFA(List<TData> LJMPIGIKCCJ, bool MMCNBOKILPH, DJKEKNEGLJD<TData> ACKIIDNLPEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x393DA80", Offset = "0x393C880", VA = "0x18393DA80", Slot = "4")]
	public override bool FEFPMOEDJPP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class KBIALNJLFIG<TData> : IHEBIHKNKML<DJKEKNEGLJD<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly TData MDDOMNBENCJ;

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x386EC00", Offset = "0x386DA00", VA = "0x18386EC00")]
	public KBIALNJLFIG(TData MDDOMNBENCJ, DJKEKNEGLJD<TData> ACKIIDNLPEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x386EA80", Offset = "0x386D880", VA = "0x18386EA80", Slot = "4")]
	public override bool FEFPMOEDJPP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class FGDBKKBKNKD<TData> : IHEBIHKNKML<DJKEKNEGLJD<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly HLCHGPDGDGK<TData> MILHOGPLHGP;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x33D27C0", Offset = "0x33D15C0", VA = "0x1833D27C0")]
	public FGDBKKBKNKD(List<TData> LJMPIGIKCCJ, DJKEKNEGLJD<TData> ACKIIDNLPEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x33D26F0", Offset = "0x33D14F0", VA = "0x1833D26F0", Slot = "4")]
	public override bool FEFPMOEDJPP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public struct HLCHGPDGDGK<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public IEnumerable<TData> BPCPFBINHIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public bool MMCNBOKILPH;

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x359C8F0", Offset = "0x359B6F0", VA = "0x18359C8F0")]
	public HLCHGPDGDGK(IEnumerable<TData> DFJNEHGMLFD, bool IJMLBFKHNAK = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface CMOENGNJCGI
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<PMFGGLHKBIM> FEFPMOEDJPP(FBEJKHMLJHK NNLDPADFFAG);
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class HJGKMMDHHBE : IHBKHGBCANK<CMOENGNJCGI, PMFGGLHKBIM>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private struct AIEEPOKONCA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<PMFGGLHKBIM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public HJGKMMDHHBE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private TaskAwaiter<PMFGGLHKBIM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x5D02030", Offset = "0x5D00E30", VA = "0x185D02030", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x5D022B0", Offset = "0x5D010B0", VA = "0x185D022B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly FBEJKHMLJHK DGBIABNJBPJ;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5D02840", Offset = "0x5D01640", VA = "0x185D02840")]
	public HJGKMMDHHBE(bool MMCNBOKILPH, CMOENGNJCGI ACKIIDNLPEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5D02750", Offset = "0x5D01550", VA = "0x185D02750", Slot = "4")]
	[AsyncStateMachine(typeof(AIEEPOKONCA))]
	public override Task<PMFGGLHKBIM> FEFPMOEDJPP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public struct FBEJKHMLJHK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public bool KPBPNKKAKPD;

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0xB2E170", Offset = "0xB2CF70", VA = "0x180B2E170")]
	public FBEJKHMLJHK(bool MMCNBOKILPH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface ONLJGCPDHBL<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HNKNNCKKOBK([In] PADHGKIIIFI<TData> DHNHNCCFGHM);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EGOFLCCOAMN([In] OGJPKLOOMPP MKKMLHFHKBI);

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool EGOFLCCOAMN([In] GBHMFINNGFB MKKMLHFHKBI);

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool GLNNKOFIICD();
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class DKLAJPKCHFA<TData> : IHEBIHKNKML<ONLJGCPDHBL<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x30212C0", Offset = "0x30200C0", VA = "0x1830212C0")]
	public DKLAJPKCHFA(ONLJGCPDHBL<TData> ACKIIDNLPEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x4CF7070", Offset = "0x4CF5E70", VA = "0x184CF7070", Slot = "4")]
	public override bool FEFPMOEDJPP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class NFKMIKBEDOK<TData> : IHEBIHKNKML<ONLJGCPDHBL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly OGJPKLOOMPP CKPOEAGMECJ;

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x3BC6A90", Offset = "0x3BC5890", VA = "0x183BC6A90")]
	public NFKMIKBEDOK(Vector3 OPFEKLMGIGA, bool PIPMIBJNCBF, ONLJGCPDHBL<TData> ACKIIDNLPEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x34888D0", Offset = "0x34876D0", VA = "0x1834888D0", Slot = "4")]
	public override bool FEFPMOEDJPP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class MNCBHNNFOKH<TData> : IHEBIHKNKML<ONLJGCPDHBL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly GBHMFINNGFB CKPOEAGMECJ;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x3B745F0", Offset = "0x3B733F0", VA = "0x183B745F0")]
	public MNCBHNNFOKH(Guid JJKLDDEKHFP, int DOJILIOCHKM, Vector3 AILFIIEAPKM, Quaternion GIBIBDOGOLL, float OMKKAIJAKIM, bool PIPMIBJNCBF, ONLJGCPDHBL<TData> ACKIIDNLPEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3B74590", Offset = "0x3B73390", VA = "0x183B74590", Slot = "4")]
	public override bool FEFPMOEDJPP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class ANOOPLADLKF<TData> : IHEBIHKNKML<ONLJGCPDHBL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly PADHGKIIIFI<TData> CKPOEAGMECJ;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3525C60", Offset = "0x3524A60", VA = "0x183525C60")]
	public ANOOPLADLKF(TData CJKEIGLKDDB, bool MMCNBOKILPH, ONLJGCPDHBL<TData> ACKIIDNLPEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x33DAE00", Offset = "0x33D9C00", VA = "0x1833DAE00", Slot = "4")]
	public override bool FEFPMOEDJPP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public struct OGJPKLOOMPP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly Vector3 OPFEKLMGIGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly bool PIPMIBJNCBF;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5D02B50", Offset = "0x5D01950", VA = "0x185D02B50")]
	public OGJPKLOOMPP(Vector3 OPFEKLMGIGA, bool PIPMIBJNCBF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct GBHMFINNGFB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly Guid JJKLDDEKHFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly int DOJILIOCHKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly Vector3 AILFIIEAPKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly Quaternion GIBIBDOGOLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly float OMKKAIJAKIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly bool PIPMIBJNCBF;

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5D026F0", Offset = "0x5D014F0", VA = "0x185D026F0")]
	public GBHMFINNGFB(Guid JJKLDDEKHFP, int DOJILIOCHKM, Vector3 AILFIIEAPKM, Quaternion GIBIBDOGOLL, float OMKKAIJAKIM, bool PIPMIBJNCBF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public struct PADHGKIIIFI<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly TData CJKEIGLKDDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly bool MMCNBOKILPH;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3DC56B0", Offset = "0x3DC44B0", VA = "0x183DC56B0")]
	public PADHGKIIIFI(TData CJKEIGLKDDB, bool MMCNBOKILPH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public interface EHKDOJHNMIA<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FEFPMOEDJPP([In] CNJONDMMHLI<TData> BPKODBFBNEK);

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FEFPMOEDJPP([In] CCBKHBMMJHJ<TData> BPKODBFBNEK);
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface COEMHKNJDDA<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HNKNNCKKOBK([In] OPIGNGJFHCP<TData> OKNHJEHDKIH);

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EGOFLCCOAMN([In] CMJHKGOFEGD MKKMLHFHKBI);

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GLNNKOFIICD();
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class BFFJJEGCMML<TData> : IHEBIHKNKML<EHKDOJHNMIA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly CNJONDMMHLI<TData> BPKODBFBNEK;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x443F5D0", Offset = "0x443E3D0", VA = "0x18443F5D0")]
	public BFFJJEGCMML(IEnumerable<TData> KMBJFBAPJAJ, Vector3 HAEPDEGPIFC, bool MMCNBOKILPH, EHKDOJHNMIA<TData> ACKIIDNLPEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x33DAE00", Offset = "0x33D9C00", VA = "0x1833DAE00", Slot = "4")]
	public override bool FEFPMOEDJPP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class HHMCCFFKCFH<TData> : IHEBIHKNKML<COEMHKNJDDA<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x30212C0", Offset = "0x30200C0", VA = "0x1830212C0")]
	public HHMCCFFKCFH(COEMHKNJDDA<TData> ACKIIDNLPEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x3580C80", Offset = "0x357FA80", VA = "0x183580C80", Slot = "4")]
	public override bool FEFPMOEDJPP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class DLNJJMHHKOP<TData> : IHEBIHKNKML<COEMHKNJDDA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly OPIGNGJFHCP<TData> BPKODBFBNEK;

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x4D04E50", Offset = "0x4D03C50", VA = "0x184D04E50")]
	public DLNJJMHHKOP(IEnumerable<TData> KMBJFBAPJAJ, bool MMCNBOKILPH, COEMHKNJDDA<TData> ACKIIDNLPEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x33DAE00", Offset = "0x33D9C00", VA = "0x1833DAE00", Slot = "4")]
	public override bool FEFPMOEDJPP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class IHELKIBLOJB<TData> : IHEBIHKNKML<EHKDOJHNMIA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly CCBKHBMMJHJ<TData> BPKODBFBNEK;

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x365CE30", Offset = "0x365BC30", VA = "0x18365CE30")]
	public IHELKIBLOJB(IEnumerable<TData> KMBJFBAPJAJ, Vector3 APLDMBEPKOO, DOLAOIPNDLC MIHDBFBMGBO, bool MMCNBOKILPH, EHKDOJHNMIA<TData> ACKIIDNLPEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x365CD60", Offset = "0x365BB60", VA = "0x18365CD60", Slot = "4")]
	public override bool FEFPMOEDJPP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class KLNDGECIHAK<TData> : IHEBIHKNKML<COEMHKNJDDA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly CMJHKGOFEGD BPKODBFBNEK;

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x38A1DD0", Offset = "0x38A0BD0", VA = "0x1838A1DD0")]
	public KLNDGECIHAK(Vector3 HAEPDEGPIFC, COEMHKNJDDA<TData> ACKIIDNLPEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x34888D0", Offset = "0x34876D0", VA = "0x1834888D0", Slot = "4")]
	public override bool FEFPMOEDJPP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public struct CNJONDMMHLI<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public readonly IEnumerable<TData> KMBJFBAPJAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly Vector3 HAEPDEGPIFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly bool MMCNBOKILPH;

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x4B2E7D0", Offset = "0x4B2D5D0", VA = "0x184B2E7D0")]
	public CNJONDMMHLI(IEnumerable<TData> KMBJFBAPJAJ, Vector3 HAEPDEGPIFC, bool MMCNBOKILPH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public struct OPIGNGJFHCP<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly IEnumerable<TData> KMBJFBAPJAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly bool MMCNBOKILPH;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3D3CE00", Offset = "0x3D3BC00", VA = "0x183D3CE00")]
	public OPIGNGJFHCP(IEnumerable<TData> KMBJFBAPJAJ, bool MMCNBOKILPH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public struct CCBKHBMMJHJ<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly IEnumerable<TData> KMBJFBAPJAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly Vector3 APLDMBEPKOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly DOLAOIPNDLC MIHDBFBMGBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly bool MMCNBOKILPH;

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x4730E70", Offset = "0x472FC70", VA = "0x184730E70")]
	public CCBKHBMMJHJ(IEnumerable<TData> KMBJFBAPJAJ, Vector3 APLDMBEPKOO, DOLAOIPNDLC MIHDBFBMGBO, bool MMCNBOKILPH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public struct CMJHKGOFEGD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly Vector3 HAEPDEGPIFC;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x1EF5200", Offset = "0x1EF4000", VA = "0x181EF5200")]
	public CMJHKGOFEGD(Vector3 HAEPDEGPIFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public enum DOLAOIPNDLC
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
public interface FLKBMKCHDBP<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FEFPMOEDJPP([In] ACIKPANKEMA<TData> HPLHMAJPCIG);

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FEFPMOEDJPP([In] NFMJOFBIOMM<TData> HPLHMAJPCIG);
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface KAPJNLAAHHJ<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HNKNNCKKOBK([In] OICEKCGPEPP<TData> DHNHNCCFGHM);

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EGOFLCCOAMN([In] ALBEGGECGDG MKKMLHFHKBI);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GLNNKOFIICD();
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class KKACIPAIPCE<TData> : IHEBIHKNKML<FLKBMKCHDBP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly ACIKPANKEMA<TData> HPLHMAJPCIG;

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x389BB10", Offset = "0x389A910", VA = "0x18389BB10")]
	public KKACIPAIPCE(IEnumerable<TData> KMBJFBAPJAJ, Quaternion HAEPDEGPIFC, Vector3? PENADEIKJOO, bool LOLGMGCGFCC, bool MMCNBOKILPH, FLKBMKCHDBP<TData> ACKIIDNLPEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x33DAE00", Offset = "0x33D9C00", VA = "0x1833DAE00", Slot = "4")]
	public override bool FEFPMOEDJPP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class KGBABJAMNEH<TData> : IHEBIHKNKML<KAPJNLAAHHJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x30212C0", Offset = "0x30200C0", VA = "0x1830212C0")]
	public KGBABJAMNEH(KAPJNLAAHHJ<TData> ACKIIDNLPEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x3580C80", Offset = "0x357FA80", VA = "0x183580C80", Slot = "4")]
	public override bool FEFPMOEDJPP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class DOJNIHLPHIN<TData> : IHEBIHKNKML<KAPJNLAAHHJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly OICEKCGPEPP<TData> HPLHMAJPCIG;

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x4D210F0", Offset = "0x4D1FEF0", VA = "0x184D210F0")]
	public DOJNIHLPHIN(IEnumerable<TData> KMBJFBAPJAJ, bool MMCNBOKILPH, KAPJNLAAHHJ<TData> ACKIIDNLPEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x33DAE00", Offset = "0x33D9C00", VA = "0x1833DAE00", Slot = "4")]
	public override bool FEFPMOEDJPP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class BHPMDABHBJF<TData> : IHEBIHKNKML<FLKBMKCHDBP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly NFMJOFBIOMM<TData> HPLHMAJPCIG;

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x4441ED0", Offset = "0x4440CD0", VA = "0x184441ED0")]
	public BHPMDABHBJF(IEnumerable<TData> KMBJFBAPJAJ, Quaternion FCDFDCKEEJI, DOLAOIPNDLC JBIACAELMGK, Vector3? PENADEIKJOO, bool LOLGMGCGFCC, bool MMCNBOKILPH, FLKBMKCHDBP<TData> ACKIIDNLPEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x365CD60", Offset = "0x365BB60", VA = "0x18365CD60", Slot = "4")]
	public override bool FEFPMOEDJPP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class AGGGNJKBNMN<TData> : IHEBIHKNKML<KAPJNLAAHHJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly ALBEGGECGDG HPLHMAJPCIG;

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x3488930", Offset = "0x3487730", VA = "0x183488930")]
	public AGGGNJKBNMN(Quaternion HAEPDEGPIFC, Vector3? PENADEIKJOO, bool LOLGMGCGFCC, KAPJNLAAHHJ<TData> ACKIIDNLPEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x34888D0", Offset = "0x34876D0", VA = "0x1834888D0", Slot = "4")]
	public override bool FEFPMOEDJPP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public struct ACIKPANKEMA<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public readonly IEnumerable<TData> KMBJFBAPJAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly Quaternion HAEPDEGPIFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public readonly Vector3? PENADEIKJOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public readonly bool LOLGMGCGFCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public readonly bool MMCNBOKILPH;

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3459FC0", Offset = "0x3458DC0", VA = "0x183459FC0")]
	public ACIKPANKEMA(IEnumerable<TData> KMBJFBAPJAJ, Quaternion HAEPDEGPIFC, Vector3? PENADEIKJOO, bool LOLGMGCGFCC, bool MMCNBOKILPH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public struct OICEKCGPEPP<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public readonly IEnumerable<TData> KMBJFBAPJAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public readonly bool MMCNBOKILPH;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x3D247B0", Offset = "0x3D235B0", VA = "0x183D247B0")]
	public OICEKCGPEPP(IEnumerable<TData> KMBJFBAPJAJ, bool MMCNBOKILPH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public struct NFMJOFBIOMM<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public readonly IEnumerable<TData> KMBJFBAPJAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public readonly Quaternion FCDFDCKEEJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public readonly DOLAOIPNDLC JBIACAELMGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public readonly Vector3? PENADEIKJOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public readonly bool LOLGMGCGFCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public readonly bool MMCNBOKILPH;

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x3BC6B20", Offset = "0x3BC5920", VA = "0x183BC6B20")]
	public NFMJOFBIOMM(IEnumerable<TData> KMBJFBAPJAJ, Quaternion FCDFDCKEEJI, DOLAOIPNDLC JBIACAELMGK, Vector3? PENADEIKJOO, bool LOLGMGCGFCC, bool MMCNBOKILPH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public struct ALBEGGECGDG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public readonly Quaternion HAEPDEGPIFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public readonly Vector3? PENADEIKJOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public readonly bool LOLGMGCGFCC;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x42A5400", Offset = "0x42A4200", VA = "0x1842A5400")]
	public ALBEGGECGDG(Quaternion HAEPDEGPIFC, Vector3? PENADEIKJOO, bool LOLGMGCGFCC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public interface NKFLLODLCDH<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HNKNNCKKOBK([In] BAHIANPBPJF<TData> DHNHNCCFGHM);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EGOFLCCOAMN([In] EFCIIFEOCPP MKKMLHFHKBI);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool EGOFLCCOAMN([In] HACBNCGLNJG MKKMLHFHKBI);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool EGOFLCCOAMN([In] OJOBFHLAAOB MKKMLHFHKBI);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool GLNNKOFIICD();
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public class FOBGEGLFNDI<TData> : IHEBIHKNKML<NKFLLODLCDH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly OJOBFHLAAOB KEOBNFEGKEE;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3409FC0", Offset = "0x3408DC0", VA = "0x183409FC0")]
	public FOBGEGLFNDI(Vector3 FDBCGADDFOK, float OFPMODDPBDG, Vector3 PENADEIKJOO, bool KCJFANGGKGK, NKFLLODLCDH<TData> ACKIIDNLPEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3409F60", Offset = "0x3408D60", VA = "0x183409F60", Slot = "4")]
	public override bool FEFPMOEDJPP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class IBLINNNFGMK<TData> : IHEBIHKNKML<NKFLLODLCDH<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x30212C0", Offset = "0x30200C0", VA = "0x1830212C0")]
	public IBLINNNFGMK(NKFLLODLCDH<TData> ACKIIDNLPEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x3644F70", Offset = "0x3643D70", VA = "0x183644F70", Slot = "4")]
	public override bool FEFPMOEDJPP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public class GGKOEEEIDPH<TData> : IHEBIHKNKML<NKFLLODLCDH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly BAHIANPBPJF<TData> KEOBNFEGKEE;

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x34B5B00", Offset = "0x34B4900", VA = "0x1834B5B00")]
	public GGKOEEEIDPH(IEnumerable<TData> KMBJFBAPJAJ, bool MMCNBOKILPH, NKFLLODLCDH<TData> ACKIIDNLPEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x33DAE00", Offset = "0x33D9C00", VA = "0x1833DAE00", Slot = "4")]
	public override bool FEFPMOEDJPP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public class BNMGFMPEHKF<TData> : IHEBIHKNKML<NKFLLODLCDH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly HACBNCGLNJG KEOBNFEGKEE;

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x444B520", Offset = "0x444A320", VA = "0x18444B520")]
	public BNMGFMPEHKF(float LMDFPCOBEEE, bool IJOCGMMBBOG, Vector3 PENADEIKJOO, NKFLLODLCDH<TData> ACKIIDNLPEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x444B450", Offset = "0x444A250", VA = "0x18444B450", Slot = "4")]
	public override bool FEFPMOEDJPP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class DHHCHEHIOHH<TData> : IHEBIHKNKML<NKFLLODLCDH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private readonly EFCIIFEOCPP KEOBNFEGKEE;

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x4CD6020", Offset = "0x4CD4E20", VA = "0x184CD6020")]
	public DHHCHEHIOHH(float OFPMODDPBDG, Vector3 PENADEIKJOO, NKFLLODLCDH<TData> ACKIIDNLPEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x34888D0", Offset = "0x34876D0", VA = "0x1834888D0", Slot = "4")]
	public override bool FEFPMOEDJPP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public struct OJOBFHLAAOB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public readonly Vector3 FDBCGADDFOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public readonly float OFPMODDPBDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly Vector3 PENADEIKJOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public readonly bool PIPMIBJNCBF;

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x5D02B70", Offset = "0x5D01970", VA = "0x185D02B70")]
	public OJOBFHLAAOB(Vector3 FDBCGADDFOK, float OFPMODDPBDG, Vector3 PENADEIKJOO, bool PIPMIBJNCBF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public struct BAHIANPBPJF<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly IEnumerable<TData> KMBJFBAPJAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public readonly bool MMCNBOKILPH;

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x44367E0", Offset = "0x44355E0", VA = "0x1844367E0")]
	public BAHIANPBPJF(IEnumerable<TData> KMBJFBAPJAJ, bool MMCNBOKILPH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct HACBNCGLNJG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public readonly float LMDFPCOBEEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public readonly bool IJOCGMMBBOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public readonly Vector3 PENADEIKJOO;

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x5D02730", Offset = "0x5D01530", VA = "0x185D02730")]
	public HACBNCGLNJG(float LMDFPCOBEEE, bool IJOCGMMBBOG, Vector3 PENADEIKJOO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public struct EFCIIFEOCPP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public readonly float OFPMODDPBDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public readonly Vector3 PENADEIKJOO;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x427F0B0", Offset = "0x427DEB0", VA = "0x18427F0B0")]
	public EFCIIFEOCPP(float OFPMODDPBDG, Vector3 PENADEIKJOO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public static class DOCICDNIDPJ
{
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	private struct JEMGGMNLFPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public bool ECDICLMGIII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public OILPPPCALMB PEFHMNHDLLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public OILPPPCALMB OGIMICICCFM;
	}

	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private static JEMGGMNLFPM DABLIOGOPMN;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static CancellationToken BAEJCEDKNMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x5D026D0", Offset = "0x5D014D0", VA = "0x185D026D0")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	internal static OILPPPCALMB PEFHMNHDLLH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x5D024E0", Offset = "0x5D012E0", VA = "0x185D024E0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x5D02470", Offset = "0x5D01270", VA = "0x185D02470")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5D02580", Offset = "0x5D01380", VA = "0x185D02580")]
	[GAPOPKHLLNB(KLEBEPKJPOL.Room, OGJCEJIMIKL.None)]
	private static void GOLHEJOKLGP(OILPPPCALMB HKFDAJEJLFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x5D02320", Offset = "0x5D01120", VA = "0x185D02320")]
	public static void AOMGIBAKPFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x5D02680", Offset = "0x5D01480", VA = "0x185D02680")]
	private static OILPPPCALMB OGKAMDNAFHE(OILPPPCALMB LCEHHHGNPPG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public static class JHKHPCGDGCG
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public enum OBCKIPOHGIO
	{
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		ICreationContextObject,
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		Guid
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x23C03B0", Offset = "0x23BF1B0", VA = "0x1823C03B0")]
	public static void NOHIOPHCBIE<T>(T JGOGHBIKMPG, OBCKIPOHGIO PEMNIEMPPLO) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x23C04F0", Offset = "0x23BF2F0", VA = "0x1823C04F0")]
	public static void NOHIOPHCBIE<T>(T JGOGHBIKMPG) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x23C0340", Offset = "0x23BF140", VA = "0x1823C0340")]
	public static void NHHIFMBNBNK<T>(T JGOGHBIKMPG) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x23C0550", Offset = "0x23BF350", VA = "0x1823C0550")]
	public static T OMJIHOMPBMI<T>(OBCKIPOHGIO PEMNIEMPPLO) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x23C05F0", Offset = "0x23BF3F0", VA = "0x1823C05F0")]
	public static T OMJIHOMPBMI<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x23C05F0", Offset = "0x23BF3F0", VA = "0x1823C05F0")]
	public static bool PPFGLGIBIMA<T>() where T : class
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal static class NIHMNMJLMPL
{
	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x5D028A0", Offset = "0x5D016A0", VA = "0x185D028A0")]
	public static void CNPGLKABFND(IEnumerable PMLMGHABEPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x24D0B00", Offset = "0x24CF900", VA = "0x1824D0B00")]
	public static void CNPGLKABFND<T>(T[] FNIMPMJDPGM) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x24D0BF0", Offset = "0x24CF9F0", VA = "0x1824D0BF0")]
	public static void CNPGLKABFND<T>(T JAEAMOHJHNM) where T : notnull, Enum
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
