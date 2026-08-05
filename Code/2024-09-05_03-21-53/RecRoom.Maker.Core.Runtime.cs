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
		[Cpp2IlInjected.Address(RVA = "0x8AE600", Offset = "0x8AD000", VA = "0x1808AE600")]
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
		[Cpp2IlInjected.Address(RVA = "0x6BECBB0", Offset = "0x6BEB5B0", VA = "0x186BECBB0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8AEC90", Offset = "0x8AD690", VA = "0x1808AEC90")]
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
		[Cpp2IlInjected.Address(RVA = "0x8AECD0", Offset = "0x8AD6D0", VA = "0x1808AECD0")]
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
	public class _AssemblyIndex : MGJKNLCKGOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6BED0E0", Offset = "0x6BEBAE0", VA = "0x186BED0E0", Slot = "8")]
		public override void KLIFGJHDPHO(DIMDGJNLMOK registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6283490", Offset = "0x6281E90", VA = "0x186283490")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface HBNJNPHPEBC<TData, TReturn>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TReturn LCJJCLCBPNA(TData GIGIFGONEAO);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface PBPDIPNGOKO<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ClearHoverTarget(DOIOEPGFFGB FIHGJCIFJCH);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool SetHoverTarget(TData IPOCAIFIKHJ, Collider HJBDNFOPIHB, DOIOEPGFFGB FIHGJCIFJCH, [Optional] NIDBICOIDOK? KGHFKGPPHPE);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool TryGetHoverTarget([Out] TData IPOCAIFIKHJ);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetHoverCollider([Out] Collider HJBDNFOPIHB);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface AGCAKNKBFLP<TData> : EOHOFLCDBIG, LGMHDHALIAI<TData>, EOIMIFAMIPJ<TData>, OHFINODNEID<TData>, KNGMBECFHEF, FBMOPFHEMHA<TData>, IJFEHCAGJPI, PEKCKNMFOKI
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface FBMOPFHEMHA<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 OBDNGCBKBFA, Vector3 IMGPFEFAFKM, float NGBAMCDGGDI, [Out] T NICDBJLFHAI, [Out] Vector3 KJHCMAIMJCM, [Out] Collider HJBDNFOPIHB);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 OBDNGCBKBFA, Vector3 IMGPFEFAFKM, float CGDBIEEBIEE, float NGBAMCDGGDI, T[] NCGLMBAHAAG, [Out] Vector3 AGOAPDEMGGK, [Out] Collider NBNGEDOGDLC);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 OBDNGCBKBFA, float CGDBIEEBIEE, Vector3 HELCBDFOKPF, T[] NCGLMBAHAAG);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetObjectFromColliderInCurrentScope(Collider IHHPCPOLGKB, [Out] T OGMNBJFAOOJ);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface EOHOFLCDBIG
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Bounds CPCHFGIFAFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Transform LMOCAGCLOBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Bounds JNEDEKNDDBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Transform FHEINIGLEHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Vector3 GIBELPOIKNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool IJNPOCKNIMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void SetSelectionBoundsDirty(bool NDBABDLMHEM = true, int EEAMFJLACPB = 0);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ShouldHideSelectionBoundsPreview(bool PGNKDHLIGPK, object KLGLJKMNAIM);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface PEKCKNMFOKI
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	PLAJPLAPENK JEMBABDCMGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface GCOFOMDBCGE
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool NJOEDFPDELE
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool JFGPKHMGEFD
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool OHLDLKMDEBE
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
	void TrySetPreviousCloneMapping(Dictionary<Guid, Guid> PDOGIDDCLGK);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface OHFINODNEID<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool IJBMCHFFOFN
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int PAPKHCBCPCC
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<TData> ALAHBBANJAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData EDKOAHIAMMF);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData EDKOAHIAMMF);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface LGMHDHALIAI<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T GIGIFGONEAO, [Optional] NIDBICOIDOK? GHFGJIAINPB, bool DOAAIPKEFNL = true);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int KFBJHPBJLOG, IEnumerable<T> INKGKKGJGID, bool DOAAIPKEFNL = true);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int KFBJHPBJLOG, IEnumerable<T> INKGKKGJGID, NIDBICOIDOK GHFGJIAINPB, bool DOAAIPKEFNL = true);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface IJFEHCAGJPI
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface KNGMBECFHEF
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool PNMINCNPJJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool DPLNLNINGPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool AGGHNCOHDAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool MOCLMACGMLK
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class LEABKBEFKMB<TReceiver> : PKOOLPINHAM<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x39A25C0", Offset = "0x39A0FC0", VA = "0x1839A25C0")]
	public LEABKBEFKMB(TReceiver BKEICMBDHGB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public abstract class EKMFMIFFFIL<TReceiver, TFromTask> : PKOOLPINHAM<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x39A25C0", Offset = "0x39A0FC0", VA = "0x1839A25C0")]
	public EKMFMIFFFIL(TReceiver BKEICMBDHGB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public abstract class PKOOLPINHAM<TReceiver, TFromExecute> where TReceiver : notnull where TFromExecute : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	protected TReceiver BKEICMBDHGB;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x49365F0", Offset = "0x4934FF0", VA = "0x1849365F0")]
	public PKOOLPINHAM(TReceiver BKEICMBDHGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute AAPMEMGCMFN();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class HBKEFJAJICA<TReceiver, TResult> : PKOOLPINHAM<TReceiver, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x39A25C0", Offset = "0x39A0FC0", VA = "0x1839A25C0")]
	public HBKEFJAJICA(TReceiver BKEICMBDHGB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct NJKMKKBMBOM<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public TGroup JJAAPBELFHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public TData KKIBLHMACBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public IEnumerable<TData> JIAFNAJCNAH;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x1F98250", Offset = "0x1F96C50", VA = "0x181F98250")]
	public NJKMKKBMBOM(TGroup GEOKDDLKFLK, TData KLAJCPHOHCD, IEnumerable<TData> CEMCGBKNJIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct MMLMGGAOLJP<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public TGroup JJAAPBELFHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public IEnumerable<TData> JIAFNAJCNAH;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0xC4E920", Offset = "0xC4D320", VA = "0x180C4E920")]
	public MMLMGGAOLJP(TGroup GEOKDDLKFLK, IEnumerable<TData> CEMCGBKNJIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct KNKBOPALNPE<TGroup> where TGroup : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public TGroup JJAAPBELFHO;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0xACCA10", Offset = "0xACB410", VA = "0x180ACCA10")]
	public KNKBOPALNPE(TGroup GEOKDDLKFLK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct OJBMECLILAM<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public IEnumerable<TData> JIAFNAJCNAH;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0xACCA10", Offset = "0xACB410", VA = "0x180ACCA10")]
	public OJBMECLILAM(IEnumerable<TData> CEMCGBKNJIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface ALCGEMOFMFL<TGroup, TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GAMEJNKMGHP ACINGPPMDOM(NJKMKKBMBOM<TGroup, TData> NKHNFDMIFBN);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GAMEJNKMGHP IBHFPDMBFKJ(NJKMKKBMBOM<TGroup, TData> NKHNFDMIFBN);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GAMEJNKMGHP OHEIJEHMIEN(MMLMGGAOLJP<TGroup, TData> NKHNFDMIFBN);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GAMEJNKMGHP ECFJPFJBPHN(KNKBOPALNPE<TGroup> NKHNFDMIFBN);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface DGMBHNAAPMF<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<GAMEJNKMGHP> ACINGPPMDOM(OJBMECLILAM<TData> NKHNFDMIFBN);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class OJLCJOBFJKB<TGroup, TData> : HBKEFJAJICA<ALCGEMOFMFL<TGroup, TData>, GAMEJNKMGHP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly MMLMGGAOLJP<TGroup, TData> NKHNFDMIFBN;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4842970", Offset = "0x4841370", VA = "0x184842970")]
	public OJLCJOBFJKB(TGroup GEOKDDLKFLK, IEnumerable<TData> CEMCGBKNJIN, ALCGEMOFMFL<TGroup, TData> BKEICMBDHGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x48428A0", Offset = "0x48412A0", VA = "0x1848428A0", Slot = "4")]
	public override GAMEJNKMGHP AAPMEMGCMFN()
	{
		return default(GAMEJNKMGHP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class JAIHIKGFFKM<TGroup, TData> : HBKEFJAJICA<ALCGEMOFMFL<TGroup, TData>, GAMEJNKMGHP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly NJKMKKBMBOM<TGroup, TData> NKHNFDMIFBN;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x397C330", Offset = "0x397AD30", VA = "0x18397C330")]
	public JAIHIKGFFKM(TGroup GEOKDDLKFLK, TData ANHCJBGBLFK, IEnumerable<TData> CEMCGBKNJIN, ALCGEMOFMFL<TGroup, TData> BKEICMBDHGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x41F6170", Offset = "0x41F4B70", VA = "0x1841F6170", Slot = "4")]
	public override GAMEJNKMGHP AAPMEMGCMFN()
	{
		return default(GAMEJNKMGHP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class DAHGLPKKMJP<TGroup, TData> : HBKEFJAJICA<ALCGEMOFMFL<TGroup, TData>, GAMEJNKMGHP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly KNKBOPALNPE<TGroup> NKHNFDMIFBN;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x46BBF30", Offset = "0x46BA930", VA = "0x1846BBF30")]
	public DAHGLPKKMJP(TGroup GEOKDDLKFLK, ALCGEMOFMFL<TGroup, TData> BKEICMBDHGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5A3F150", Offset = "0x5A3DB50", VA = "0x185A3F150", Slot = "4")]
	public override GAMEJNKMGHP AAPMEMGCMFN()
	{
		return default(GAMEJNKMGHP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class EJKGNHAEPCL<TGroup, TData> : HBKEFJAJICA<ALCGEMOFMFL<TGroup, TData>, GAMEJNKMGHP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly NJKMKKBMBOM<TGroup, TData> NKHNFDMIFBN;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x397C330", Offset = "0x397AD30", VA = "0x18397C330")]
	public EJKGNHAEPCL(TGroup GEOKDDLKFLK, TData KLAJCPHOHCD, IEnumerable<TData> CEMCGBKNJIN, ALCGEMOFMFL<TGroup, TData> BKEICMBDHGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x397C250", Offset = "0x397AC50", VA = "0x18397C250", Slot = "4")]
	public override GAMEJNKMGHP AAPMEMGCMFN()
	{
		return default(GAMEJNKMGHP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class NJBIOEFKLDD<TData> : EKMFMIFFFIL<DGMBHNAAPMF<TData>, GAMEJNKMGHP> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private struct GKEOFPIFLFL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AsyncTaskMethodBuilder<GAMEJNKMGHP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public NJBIOEFKLDD<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private TaskAwaiter<GAMEJNKMGHP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3E2E720", Offset = "0x3E2D120", VA = "0x183E2E720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x3E2E9C0", Offset = "0x3E2D3C0", VA = "0x183E2E9C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private OJBMECLILAM<TData> NKHNFDMIFBN;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x46BBF30", Offset = "0x46BA930", VA = "0x1846BBF30")]
	public NJBIOEFKLDD(IEnumerable<TData> APCJJDJNCPL, DGMBHNAAPMF<TData> BKEICMBDHGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x46BBE30", Offset = "0x46BA830", VA = "0x1846BBE30", Slot = "4")]
	[AsyncStateMachine(typeof(NJBIOEFKLDD<>.GKEOFPIFLFL))]
	public override Task<GAMEJNKMGHP> AAPMEMGCMFN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public readonly struct DOKPGJKGJEA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly LGDIMMDMMNF DGLFJHIEFJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly bool LCLPBAJPBHF;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6BEC370", Offset = "0x6BEAD70", VA = "0x186BEC370")]
	public DOKPGJKGJEA(LGDIMMDMMNF BLCOOHGAPGO, bool LONBMPLGMMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface DOIHKMLMIJD<TSpawnType> where TSpawnType : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> AAPMEMGCMFN(DOKPGJKGJEA NGINCGBOEHJ);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class JILOFPHCDJH<TSpawnType> : EKMFMIFFFIL<DOIHKMLMIJD<TSpawnType>, TSpawnType> where TSpawnType : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private struct LGNJDOLNKDG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public AsyncTaskMethodBuilder<TSpawnType> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public JILOFPHCDJH<TSpawnType> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskAwaiter<TSpawnType> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x4423250", Offset = "0x4421C50", VA = "0x184423250", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x3D67E50", Offset = "0x3D66850", VA = "0x183D67E50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly DOKPGJKGJEA NGINCGBOEHJ;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x4230710", Offset = "0x422F110", VA = "0x184230710")]
	public JILOFPHCDJH(LGDIMMDMMNF BLCOOHGAPGO, bool LONBMPLGMMN, DOIHKMLMIJD<TSpawnType> BKEICMBDHGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x4230600", Offset = "0x422F000", VA = "0x184230600", Slot = "4")]
	[AsyncStateMachine(typeof(JILOFPHCDJH<>.LGNJDOLNKDG))]
	public override Task<TSpawnType> AAPMEMGCMFN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public readonly struct LGDIMMDMMNF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly bool IGGGMAFJKHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly Vector3 KHMPGKCHOLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly Vector3 FDBNADNMDNI;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6BEC4B0", Offset = "0x6BEAEB0", VA = "0x186BEC4B0")]
	public LGDIMMDMMNF(Transform KFEBNCNJGFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6BEC480", Offset = "0x6BEAE80", VA = "0x186BEC480")]
	public LGDIMMDMMNF(Vector3 BELBOBCMBGH, Vector3 BJDHDJCINFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6BEC3D0", Offset = "0x6BEADD0", VA = "0x186BEC3D0")]
	public static LGDIMMDMMNF LNLMPMKCFAD()
	{
		return default(LGDIMMDMMNF);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6BEC400", Offset = "0x6BEAE00", VA = "0x186BEC400")]
	private LGDIMMDMMNF(bool BLECKDKDHAN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct IOFCIIMMCOH<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public TNode NOALKHDGKHL;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x402CB10", Offset = "0x402B510", VA = "0x18402CB10")]
	public IOFCIIMMCOH(TNode NOALKHDGKHL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct HJCCFMABNGH<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public TNode LHJHIAJAMEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public EHEDAMAIAIC PHJFIEHIMJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly bool LCLPBAJPBHF;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3EE9A00", Offset = "0x3EE8400", VA = "0x183EE9A00")]
	public HJCCFMABNGH(TNode LHJHIAJAMEL, EHEDAMAIAIC PHJFIEHIMJH, bool LONBMPLGMMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface HKMFEGODEHP<TNode>
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IKMBLGNCIEM([In] IOFCIIMMCOH<TNode> AHOFICMMCPN);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KBFALDMMEKL([In] HJCCFMABNGH<TNode> HMGDOEDNEKI);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GPBIAHAIJNJ();
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class DFPIJLMCPIB<TNode> : LEABKBEFKMB<HKMFEGODEHP<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x39A25C0", Offset = "0x39A0FC0", VA = "0x1839A25C0")]
	public DFPIJLMCPIB(HKMFEGODEHP<TNode> BKEICMBDHGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3E0A3B0", Offset = "0x3E08DB0", VA = "0x183E0A3B0", Slot = "4")]
	public override bool AAPMEMGCMFN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class MEEFODLLEKG<TNode> : LEABKBEFKMB<HKMFEGODEHP<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly HJCCFMABNGH<TNode> HMGDOEDNEKI;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x460CF90", Offset = "0x460B990", VA = "0x18460CF90")]
	public MEEFODLLEKG(TNode LHJHIAJAMEL, EHEDAMAIAIC PHJFIEHIMJH, HKMFEGODEHP<TNode> BKEICMBDHGB, bool LONBMPLGMMN = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x460CED0", Offset = "0x460B8D0", VA = "0x18460CED0", Slot = "4")]
	public override bool AAPMEMGCMFN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class LHOOCMLMPHD<TNode> : LEABKBEFKMB<HKMFEGODEHP<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly IOFCIIMMCOH<TNode> AHOFICMMCPN;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x442F2C0", Offset = "0x442DCC0", VA = "0x18442F2C0")]
	public LHOOCMLMPHD(TNode OLJMGJHFCKP, HKMFEGODEHP<TNode> BKEICMBDHGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x396B640", Offset = "0x396A040", VA = "0x18396B640", Slot = "4")]
	public override bool AAPMEMGCMFN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct BFHMLIGLKNL<TSpawnInfo> where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public TSpawnInfo ALFLIJJACOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public Vector3 BJDHDJCINFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Quaternion FJFNLINEAKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public float ADJNFMJNIAA;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5008880", Offset = "0x5007280", VA = "0x185008880")]
	public BFHMLIGLKNL(TSpawnInfo ALFLIJJACOG, Vector3 BJDHDJCINFH, Quaternion FJFNLINEAKI, float ADJNFMJNIAA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface NIIMKOLMDIA<TSpawnType, TSpawnInfo>
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> AADBKBJBEIL([In] BFHMLIGLKNL<TSpawnInfo> MIGFHFEPILI, CancellationToken OGJIGALEPCA);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class FAFIOOLIPMC<TSpawnType, TSpawnInfo> : EKMFMIFFFIL<NIIMKOLMDIA<TSpawnType, TSpawnInfo>, TSpawnType> where TSpawnType : notnull where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly BFHMLIGLKNL<TSpawnInfo> EBIJIHILGPC;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x3D18810", Offset = "0x3D17210", VA = "0x183D18810")]
	public FAFIOOLIPMC(TSpawnInfo FDDDAHDDFIC, Vector3 BJDHDJCINFH, Quaternion FJFNLINEAKI, float ADJNFMJNIAA, NIIMKOLMDIA<TSpawnType, TSpawnInfo> BKEICMBDHGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x3D18610", Offset = "0x3D17010", VA = "0x183D18610", Slot = "4")]
	public override Task<TSpawnType> AAPMEMGCMFN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct HGEHHEJCOFG<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly IEnumerable<TData> JIAFNAJCNAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly bool LCLPBAJPBHF;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3ED44A0", Offset = "0x3ED2EA0", VA = "0x183ED44A0")]
	public HGEHHEJCOFG(IEnumerable<TData> CEMCGBKNJIN, bool LONBMPLGMMN = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface AFGJFINBCDG<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<GAMEJNKMGHP> NBGGANFJIBG([In] HGEHHEJCOFG<TData> AJOMGNFKBEI, CancellationToken OGJIGALEPCA);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public class CBJOKMIHNPE<TData> : EKMFMIFFFIL<AFGJFINBCDG<TData>, GAMEJNKMGHP> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly HGEHHEJCOFG<TData> DKJJKJKOFNP;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5110AA0", Offset = "0x510F4A0", VA = "0x185110AA0")]
	public CBJOKMIHNPE(IEnumerable<TData> CEMCGBKNJIN, bool LONBMPLGMMN, AFGJFINBCDG<TData> BKEICMBDHGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x3D18610", Offset = "0x3D17010", VA = "0x183D18610", Slot = "4")]
	public override Task<GAMEJNKMGHP> AAPMEMGCMFN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct MDDNHAJLFON<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public readonly T IPOCAIFIKHJ;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x460A410", Offset = "0x4608E10", VA = "0x18460A410")]
	public MDDNHAJLFON(T MJKGLBKDJGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface IGNBAANHOPE<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IKMBLGNCIEM([In] MDDNHAJLFON<T> BELNCNFBHOJ);

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KBFALDMMEKL();
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface CDECOGGGBGE<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AAPMEMGCMFN([In] GDFOGDHICED<T> DCLEBMFFJMG);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct GDFOGDHICED<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public readonly T IPOCAIFIKHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public readonly bool LIAGEGPINAN;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x3E08FC0", Offset = "0x3E079C0", VA = "0x183E08FC0")]
	public GDFOGDHICED(T MJKGLBKDJGP, bool IIMKONEEJKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class OLCKFHOBHEK<T> : LEABKBEFKMB<IGNBAANHOPE<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x39A25C0", Offset = "0x39A0FC0", VA = "0x1839A25C0")]
	public OLCKFHOBHEK(IGNBAANHOPE<T> BKEICMBDHGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x48451C0", Offset = "0x4843BC0", VA = "0x1848451C0", Slot = "4")]
	public override bool AAPMEMGCMFN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class BHEDFCEFOKK<T> : LEABKBEFKMB<IGNBAANHOPE<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly MDDNHAJLFON<T> BELNCNFBHOJ;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x500B110", Offset = "0x5009B10", VA = "0x18500B110")]
	public BHEDFCEFOKK(T IPOCAIFIKHJ, IGNBAANHOPE<T> BKEICMBDHGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x396B640", Offset = "0x396A040", VA = "0x18396B640", Slot = "4")]
	public override bool AAPMEMGCMFN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class JNBCHJNEGLC<T> : LEABKBEFKMB<CDECOGGGBGE<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly GDFOGDHICED<T> DCLEBMFFJMG;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4239B60", Offset = "0x4238560", VA = "0x184239B60")]
	public JNBCHJNEGLC(T IPOCAIFIKHJ, bool IIMKONEEJKM, CDECOGGGBGE<T> BKEICMBDHGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x396B640", Offset = "0x396A040", VA = "0x18396B640", Slot = "4")]
	public override bool AAPMEMGCMFN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct MEHCOHGFONE<TData> where TData : notnull, AKMBBINLMIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public IEnumerable<TData> JIAFNAJCNAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public bool CLACJDEBKCO;

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x460D050", Offset = "0x460BA50", VA = "0x18460D050")]
	public MEHCOHGFONE(IEnumerable<TData> MJEGFGFNGAG, bool NBCEBCBHEHL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public struct OBLIMDHPCFI<TData> where TData : notnull, AKMBBINLMIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public List<TData> JIAFNAJCNAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public List<bool> CLJKGOLCFIH;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x481A690", Offset = "0x4819090", VA = "0x18481A690")]
	public OBLIMDHPCFI(List<TData> MJEGFGFNGAG, List<bool> FMKLIEBJFLB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface AKMBBINLMIO
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool JLGLGJKPEKP
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
public interface OPANAOAAEMP<TData> where TData : AKMBBINLMIO
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AAPMEMGCMFN([In] MEHCOHGFONE<TData> IDKBPGEHKOO);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AAPMEMGCMFN([In] OBLIMDHPCFI<TData> IDKBPGEHKOO);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface ECCPAEHMHFL<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ICLEKAALCJD(T IPOCAIFIKHJ);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class EHPAIDDOJJJ<TData> : LEABKBEFKMB<OPANAOAAEMP<TData>> where TData : notnull, AKMBBINLMIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly MEHCOHGFONE<TData> IDKBPGEHKOO;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x396B700", Offset = "0x396A100", VA = "0x18396B700")]
	public EHPAIDDOJJJ(List<TData> CEMCGBKNJIN, bool CLACJDEBKCO, OPANAOAAEMP<TData> BKEICMBDHGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x396B640", Offset = "0x396A040", VA = "0x18396B640", Slot = "4")]
	public override bool AAPMEMGCMFN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class NFGMJFALBOF<TData> : LEABKBEFKMB<OPANAOAAEMP<TData>> where TData : notnull, AKMBBINLMIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly OBLIMDHPCFI<TData> IDKBPGEHKOO;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x46AA8F0", Offset = "0x46A92F0", VA = "0x1846AA8F0")]
	public NFGMJFALBOF(List<TData> CEMCGBKNJIN, List<bool> CLJKGOLCFIH, OPANAOAAEMP<TData> BKEICMBDHGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x3D2F570", Offset = "0x3D2DF70", VA = "0x183D2F570", Slot = "4")]
	public override bool AAPMEMGCMFN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface AABHBNAKFME<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<GAMEJNKMGHP> AAPMEMGCMFN(GCIPPEPNJBG<TData> MAJPNCBNLAB);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class PGLMGKMGIEO<TData> : EKMFMIFFFIL<AABHBNAKFME<TData>, GAMEJNKMGHP> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct EOHCJKNEHMO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public AsyncTaskMethodBuilder<GAMEJNKMGHP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public PGLMGKMGIEO<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter<GAMEJNKMGHP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x39AF7C0", Offset = "0x39AE1C0", VA = "0x1839AF7C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x39AFAA0", Offset = "0x39AE4A0", VA = "0x1839AFAA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly GCIPPEPNJBG<TData> JILPHKNEBBM;

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x49269A0", Offset = "0x49253A0", VA = "0x1849269A0")]
	public PGLMGKMGIEO(TData OKBKCNFEHCI, IReadOnlyList<TData> BKIKKHGDJHP, bool LONBMPLGMMN, AABHBNAKFME<TData> BKEICMBDHGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x49268A0", Offset = "0x49252A0", VA = "0x1849268A0", Slot = "4")]
	[AsyncStateMachine(typeof(PGLMGKMGIEO<>.EOHCJKNEHMO))]
	public override Task<GAMEJNKMGHP> AAPMEMGCMFN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public struct GCIPPEPNJBG<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public TData OBJHNGMJLAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public IReadOnlyList<TData> OEACBHPGENJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public bool LCLPBAJPBHF;

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x3E08220", Offset = "0x3E06C20", VA = "0x183E08220")]
	public GCIPPEPNJBG(TData OKBKCNFEHCI, IReadOnlyList<TData> BKIKKHGDJHP, bool LONBMPLGMMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface PIPLFJABDPP<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AAPMEMGCMFN([In] HMMMKPBIBJA<TData> LBMFFKHLANB);
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface PFCDPEODMHJ<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AAPMEMGCMFN([In] EICBINKFFKP<TData> LBMFFKHLANB);
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface HPNFNJFBHNG<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MHCILAPBCNH([In] NGIPHPKGKDK<TData> LBMFFKHLANB);

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KBFALDMMEKL();
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class MNMIIBAOKPE<TData> : LEABKBEFKMB<PIPLFJABDPP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly HMMMKPBIBJA<TData> LBMFFKHLANB;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x46302E0", Offset = "0x462ECE0", VA = "0x1846302E0")]
	public MNMIIBAOKPE(IEnumerable<TData> CEMCGBKNJIN, KKGOBCNALDK BLBBBKOLGJG, DCLHCFNCEDH MLMFHAHBCEC, float IAODJOBPBOG, bool LONBMPLGMMN, PIPLFJABDPP<TData> BKEICMBDHGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x396B640", Offset = "0x396A040", VA = "0x18396B640", Slot = "4")]
	public override bool AAPMEMGCMFN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class BEDNEKPELGP<TData> : LEABKBEFKMB<PFCDPEODMHJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly EICBINKFFKP<TData> LBMFFKHLANB;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5002DA0", Offset = "0x50017A0", VA = "0x185002DA0")]
	public BEDNEKPELGP(TData[] CEMCGBKNJIN, KKGOBCNALDK[] BLBBBKOLGJG, DCLHCFNCEDH[] MLMFHAHBCEC, float[] IAODJOBPBOG, PFCDPEODMHJ<TData> BKEICMBDHGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x402C1D0", Offset = "0x402ABD0", VA = "0x18402C1D0", Slot = "4")]
	public override bool AAPMEMGCMFN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class ALHAGDGOMIG<TData> : LEABKBEFKMB<HPNFNJFBHNG<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x39A25C0", Offset = "0x39A0FC0", VA = "0x1839A25C0")]
	public ALHAGDGOMIG(HPNFNJFBHNG<TData> BKEICMBDHGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3DE65F0", Offset = "0x3DE4FF0", VA = "0x183DE65F0", Slot = "4")]
	public override bool AAPMEMGCMFN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class INODHFIAFAA<TData> : LEABKBEFKMB<HPNFNJFBHNG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly NGIPHPKGKDK<TData> LBMFFKHLANB;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x402C290", Offset = "0x402AC90", VA = "0x18402C290")]
	public INODHFIAFAA(IEnumerable<TData> CEMCGBKNJIN, KKGOBCNALDK BLBBBKOLGJG, DCLHCFNCEDH MLMFHAHBCEC, float IAODJOBPBOG, HPNFNJFBHNG<TData> BKEICMBDHGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x402C1D0", Offset = "0x402ABD0", VA = "0x18402C1D0", Slot = "4")]
	public override bool AAPMEMGCMFN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct HMMMKPBIBJA<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public IEnumerable<TData> JIAFNAJCNAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public KKGOBCNALDK OAKOGEMAGKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public DCLHCFNCEDH CKDAEMELGPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public float IAODJOBPBOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public bool LONBMPLGMMN;

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3EF2730", Offset = "0x3EF1130", VA = "0x183EF2730")]
	public HMMMKPBIBJA(IEnumerable<TData> CEMCGBKNJIN, KKGOBCNALDK BLBBBKOLGJG, DCLHCFNCEDH MLMFHAHBCEC, float IAODJOBPBOG, bool LONBMPLGMMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public struct EICBINKFFKP<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public TData[] JIAFNAJCNAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public KKGOBCNALDK[] OAKOGEMAGKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public DCLHCFNCEDH[] CKDAEMELGPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public float[] IAODJOBPBOG;

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x39721B0", Offset = "0x3970BB0", VA = "0x1839721B0")]
	public EICBINKFFKP(TData[] CEMCGBKNJIN, KKGOBCNALDK[] BLBBBKOLGJG, DCLHCFNCEDH[] MLMFHAHBCEC, float[] IAODJOBPBOG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public struct NGIPHPKGKDK<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public IEnumerable<TData> JIAFNAJCNAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public KKGOBCNALDK OAKOGEMAGKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public DCLHCFNCEDH CKDAEMELGPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public float IAODJOBPBOG;

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x46AC920", Offset = "0x46AB320", VA = "0x1846AC920")]
	public NGIPHPKGKDK(IEnumerable<TData> CEMCGBKNJIN, KKGOBCNALDK BLBBBKOLGJG, DCLHCFNCEDH MLMFHAHBCEC, float IAODJOBPBOG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface EOIMIFAMIPJ<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OHEIJEHMIEN([In] BKKADHOOJEH<TData> AJOMGNFKBEI);

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ECFJPFJBPHN([In] BKKADHOOJEH<TData> AJOMGNFKBEI);

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OKGILOCOEDA([In] bool BFNMCJANPDE);

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool OHDOMMJELGC([In] BKKADHOOJEH<TData> AJOMGNFKBEI);

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CNAGMBKMFBN();

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool OPDJGINLLPL([In] TData NPEHNADIECI);
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class EPFEMFGOCCD<TData> : LEABKBEFKMB<EOIMIFAMIPJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly BKKADHOOJEH<TData> AJOMGNFKBEI;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x39B03D0", Offset = "0x39AEDD0", VA = "0x1839B03D0")]
	public EPFEMFGOCCD(List<TData> HLHNGAOBAAJ, EOIMIFAMIPJ<TData> BKEICMBDHGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x396B640", Offset = "0x396A040", VA = "0x18396B640", Slot = "4")]
	public override bool AAPMEMGCMFN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class OHPBBEFFGCI<TData> : LEABKBEFKMB<EOIMIFAMIPJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x39A25C0", Offset = "0x39A0FC0", VA = "0x1839A25C0")]
	public OHPBBEFFGCI(EOIMIFAMIPJ<TData> BKEICMBDHGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x4840270", Offset = "0x483EC70", VA = "0x184840270", Slot = "4")]
	public override bool AAPMEMGCMFN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class FPENCLGKIFP<TData> : LEABKBEFKMB<EOIMIFAMIPJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly bool LONBMPLGMMN;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3D6EA20", Offset = "0x3D6D420", VA = "0x183D6EA20")]
	public FPENCLGKIFP(bool LONBMPLGMMN, EOIMIFAMIPJ<TData> BKEICMBDHGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3D6E9C0", Offset = "0x3D6D3C0", VA = "0x183D6E9C0", Slot = "4")]
	public override bool AAPMEMGCMFN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class FCGBNGIDLGO<TData> : LEABKBEFKMB<EOIMIFAMIPJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly BKKADHOOJEH<TData> AJOMGNFKBEI;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3D2F6E0", Offset = "0x3D2E0E0", VA = "0x183D2F6E0")]
	public FCGBNGIDLGO(List<TData> HLHNGAOBAAJ, bool LONBMPLGMMN, EOIMIFAMIPJ<TData> BKEICMBDHGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3D2F570", Offset = "0x3D2DF70", VA = "0x183D2F570", Slot = "4")]
	public override bool AAPMEMGCMFN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class ADGEEGBNPBD<TData> : LEABKBEFKMB<EOIMIFAMIPJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly TData NPEHNADIECI;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3DC4190", Offset = "0x3DC2B90", VA = "0x183DC4190")]
	public ADGEEGBNPBD(TData NPEHNADIECI, EOIMIFAMIPJ<TData> BKEICMBDHGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x3DC40D0", Offset = "0x3DC2AD0", VA = "0x183DC40D0", Slot = "4")]
	public override bool AAPMEMGCMFN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class MFIAOJGNNHK<TData> : LEABKBEFKMB<EOIMIFAMIPJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly BKKADHOOJEH<TData> AJOMGNFKBEI;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x4613600", Offset = "0x4612000", VA = "0x184613600")]
	public MFIAOJGNNHK(IEnumerable<TData> HLHNGAOBAAJ, EOIMIFAMIPJ<TData> BKEICMBDHGB, bool LONBMPLGMMN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x4613490", Offset = "0x4611E90", VA = "0x184613490", Slot = "4")]
	public override bool AAPMEMGCMFN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public struct BKKADHOOJEH<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public IEnumerable<TData> JIAFNAJCNAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public bool LONBMPLGMMN;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x5063800", Offset = "0x5062200", VA = "0x185063800")]
	public BKKADHOOJEH(IEnumerable<TData> MJEGFGFNGAG, bool PPNAPADGAPF = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface LLEHFMHKEEH
{
	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<GAMEJNKMGHP> AAPMEMGCMFN(BNKJJFOCNFF ENFOKIJNDFB);
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public class MFMIHPLLLDO : EKMFMIFFFIL<LLEHFMHKEEH, GAMEJNKMGHP>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private struct CHLCNKMDCAK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public AsyncTaskMethodBuilder<GAMEJNKMGHP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public MFMIHPLLLDO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private TaskAwaiter<GAMEJNKMGHP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6BEBF90", Offset = "0x6BEA990", VA = "0x186BEBF90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6BEC210", Offset = "0x6BEAC10", VA = "0x186BEC210", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly BNKJJFOCNFF HOJOFBPLGMM;

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6BEC8C0", Offset = "0x6BEB2C0", VA = "0x186BEC8C0")]
	public MFMIHPLLLDO(bool LONBMPLGMMN, LLEHFMHKEEH BKEICMBDHGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6BEC7D0", Offset = "0x6BEB1D0", VA = "0x186BEC7D0", Slot = "4")]
	[AsyncStateMachine(typeof(CHLCNKMDCAK))]
	public override Task<GAMEJNKMGHP> AAPMEMGCMFN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public struct BNKJJFOCNFF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public bool LCLPBAJPBHF;

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x225C3B0", Offset = "0x225ADB0", VA = "0x18225C3B0")]
	public BNKJJFOCNFF(bool LONBMPLGMMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public readonly struct DICACPOOKGD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly bool AHNJANIOFEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly bool AEHFIJFLJBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public readonly bool ADJNFMJNIAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public readonly bool LONBMPLGMMN;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x4EC3C10", Offset = "0x4EC2610", VA = "0x184EC3C10")]
	public DICACPOOKGD(bool AHNJANIOFEN, bool AEHFIJFLJBI, bool ADJNFMJNIAA, bool LONBMPLGMMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6BEC280", Offset = "0x6BEAC80", VA = "0x186BEC280")]
	public DICACPOOKGD(bool AEHFIJFLJBI, bool LONBMPLGMMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public interface NDFLEDPAPAA
{
	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FEMBBIHACOK(DICACPOOKGD CPICCOCIDKC);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool AIHAJIIOIGD(DICACPOOKGD CPICCOCIDKC);
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class DNJIAKICOFH : LEABKBEFKMB<NDFLEDPAPAA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly DICACPOOKGD CPICCOCIDKC;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6BEC2E0", Offset = "0x6BEACE0", VA = "0x186BEC2E0")]
	public DNJIAKICOFH(bool JKDLLOIHFGK, bool AEHFIJFLJBI, bool ADJNFMJNIAA, bool LONBMPLGMMN, NDFLEDPAPAA BKEICMBDHGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6BEC290", Offset = "0x6BEAC90", VA = "0x186BEC290", Slot = "4")]
	public override bool AAPMEMGCMFN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class ANEEIOANABN : LEABKBEFKMB<NDFLEDPAPAA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly DICACPOOKGD CPICCOCIDKC;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6BEBAB0", Offset = "0x6BEA4B0", VA = "0x186BEBAB0")]
	public ANEEIOANABN(bool AEHFIJFLJBI, bool LONBMPLGMMN, NDFLEDPAPAA BKEICMBDHGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6BEBA60", Offset = "0x6BEA460", VA = "0x186BEBA60", Slot = "4")]
	public override bool AAPMEMGCMFN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public interface EOFLLGHGDCE
{
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AAPMEMGCMFN([In] ANGEKJIIKOJ DBHGJAAHAKP);
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class LOPBLKGKJBN : LEABKBEFKMB<EOFLLGHGDCE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly ANGEKJIIKOJ DBHGJAAHAKP;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6BEC5D0", Offset = "0x6BEAFD0", VA = "0x186BEC5D0")]
	public LOPBLKGKJBN(Guid[] LDAPENPAMCE, Vector3[] IGHLHPNKDJG, Quaternion[] EIKHHFBBGOA, float[] KDNBBBGDGJC, Dictionary<Guid, Vector3> BCJDPIKEDEI, EOFLLGHGDCE BKEICMBDHGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6BEC520", Offset = "0x6BEAF20", VA = "0x186BEC520", Slot = "4")]
	public override bool AAPMEMGCMFN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public interface CNONEJOGKPH<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IKMBLGNCIEM([In] OOJNGNOPFPI<TData> AHOFICMMCPN);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MHCILAPBCNH([In] MFMDCIBEDMP MKCNMPJIDKG);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MHCILAPBCNH([In] IIPOBBNFNJC MKCNMPJIDKG);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool KBFALDMMEKL();
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class DMFHMNFECCK<TData> : LEABKBEFKMB<CNONEJOGKPH<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x39A25C0", Offset = "0x39A0FC0", VA = "0x1839A25C0")]
	public DMFHMNFECCK(CNONEJOGKPH<TData> BKEICMBDHGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5A77670", Offset = "0x5A76070", VA = "0x185A77670", Slot = "4")]
	public override bool AAPMEMGCMFN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class BIGELEPEEGL<TData> : LEABKBEFKMB<CNONEJOGKPH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly MFMDCIBEDMP IJCJCCOOPEL;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5052D20", Offset = "0x5051720", VA = "0x185052D20")]
	public BIGELEPEEGL(Vector3 DNJHJGHLPBK, bool FKOEGJPINIE, CNONEJOGKPH<TData> BKEICMBDHGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x3D312A0", Offset = "0x3D2FCA0", VA = "0x183D312A0", Slot = "4")]
	public override bool AAPMEMGCMFN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class OKONBGONAPD<TData> : LEABKBEFKMB<CNONEJOGKPH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly IIPOBBNFNJC IJCJCCOOPEL;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x4845080", Offset = "0x4843A80", VA = "0x184845080")]
	public OKONBGONAPD(Guid MHKINGDOFKG, int EBDDHAPIAHH, Vector3 BJDHDJCINFH, Quaternion FJFNLINEAKI, float MNBMJJFKKCE, bool FKOEGJPINIE, CNONEJOGKPH<TData> BKEICMBDHGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x4845020", Offset = "0x4843A20", VA = "0x184845020", Slot = "4")]
	public override bool AAPMEMGCMFN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class CJPHGMBOBIP<TData> : LEABKBEFKMB<CNONEJOGKPH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly OOJNGNOPFPI<TData> IJCJCCOOPEL;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x5440340", Offset = "0x543ED40", VA = "0x185440340")]
	public CJPHGMBOBIP(TData IPOCAIFIKHJ, bool LONBMPLGMMN, CNONEJOGKPH<TData> BKEICMBDHGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x396B640", Offset = "0x396A040", VA = "0x18396B640", Slot = "4")]
	public override bool AAPMEMGCMFN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public struct MFMDCIBEDMP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly Vector3 DNJHJGHLPBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public readonly bool FKOEGJPINIE;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6BEC7B0", Offset = "0x6BEB1B0", VA = "0x186BEC7B0")]
	public MFMDCIBEDMP(Vector3 DNJHJGHLPBK, bool FKOEGJPINIE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public struct IIPOBBNFNJC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public readonly Guid MHKINGDOFKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public readonly int EBDDHAPIAHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public readonly Vector3 BJDHDJCINFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public readonly Quaternion FJFNLINEAKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public readonly float MNBMJJFKKCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public readonly bool FKOEGJPINIE;

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6BEC390", Offset = "0x6BEAD90", VA = "0x186BEC390")]
	public IIPOBBNFNJC(Guid MHKINGDOFKG, int EBDDHAPIAHH, Vector3 BJDHDJCINFH, Quaternion FJFNLINEAKI, float MNBMJJFKKCE, bool FKOEGJPINIE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public struct OOJNGNOPFPI<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public readonly TData IPOCAIFIKHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public readonly bool LONBMPLGMMN;

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x4864140", Offset = "0x4862B40", VA = "0x184864140")]
	public OOJNGNOPFPI(TData IPOCAIFIKHJ, bool LONBMPLGMMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public interface FANDDKFDNIB<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AAPMEMGCMFN([In] ADGBGPOFNEG<TData> DFMDIIOOHIH);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool AAPMEMGCMFN([In] AMICCBDALFE<TData> DFMDIIOOHIH);
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public interface FEFPIAALMOI<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IKMBLGNCIEM([In] DHLHFOIBGAL<TData> DKIKJMIJGDG);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MHCILAPBCNH([In] KFNPDCGDENL MKCNMPJIDKG);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KBFALDMMEKL();
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class OHABPLCNIDN<TData> : LEABKBEFKMB<FANDDKFDNIB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly ADGBGPOFNEG<TData> DFMDIIOOHIH;

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x483AD70", Offset = "0x4839770", VA = "0x18483AD70")]
	public OHABPLCNIDN(IEnumerable<TData> CEMCGBKNJIN, Vector3 HMJPLBDDPMG, bool LONBMPLGMMN, FANDDKFDNIB<TData> BKEICMBDHGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x396B640", Offset = "0x396A040", VA = "0x18396B640", Slot = "4")]
	public override bool AAPMEMGCMFN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class LNHPEMACNCA<TData> : LEABKBEFKMB<FEFPIAALMOI<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x39A25C0", Offset = "0x39A0FC0", VA = "0x1839A25C0")]
	public LNHPEMACNCA(FEFPIAALMOI<TData> BKEICMBDHGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x3E0A3B0", Offset = "0x3E08DB0", VA = "0x183E0A3B0", Slot = "4")]
	public override bool AAPMEMGCMFN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class LDCLKKNBCNL<TData> : LEABKBEFKMB<FEFPIAALMOI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly DHLHFOIBGAL<TData> DFMDIIOOHIH;

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x441D5C0", Offset = "0x441BFC0", VA = "0x18441D5C0")]
	public LDCLKKNBCNL(IEnumerable<TData> CEMCGBKNJIN, bool LONBMPLGMMN, FEFPIAALMOI<TData> BKEICMBDHGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x396B640", Offset = "0x396A040", VA = "0x18396B640", Slot = "4")]
	public override bool AAPMEMGCMFN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class CAOJBMMLGPD<TData> : LEABKBEFKMB<FANDDKFDNIB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly AMICCBDALFE<TData> DFMDIIOOHIH;

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x510F2A0", Offset = "0x510DCA0", VA = "0x18510F2A0")]
	public CAOJBMMLGPD(IEnumerable<TData> CEMCGBKNJIN, Vector3 CJOCKJDPJGP, KEEIMJEHLDG NEELFOHIDOG, bool LONBMPLGMMN, FANDDKFDNIB<TData> BKEICMBDHGB, Space LLOCDBEDPDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x460CED0", Offset = "0x460B8D0", VA = "0x18460CED0", Slot = "4")]
	public override bool AAPMEMGCMFN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public class FDBHCCDFEDM<TData> : LEABKBEFKMB<FEFPIAALMOI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly KFNPDCGDENL DFMDIIOOHIH;

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x3D31300", Offset = "0x3D2FD00", VA = "0x183D31300")]
	public FDBHCCDFEDM(Vector3 HMJPLBDDPMG, FEFPIAALMOI<TData> BKEICMBDHGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x3D312A0", Offset = "0x3D2FCA0", VA = "0x183D312A0", Slot = "4")]
	public override bool AAPMEMGCMFN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct ADGBGPOFNEG<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public readonly IEnumerable<TData> CEMCGBKNJIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public readonly Vector3 HMJPLBDDPMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public readonly bool LONBMPLGMMN;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x3DC3FA0", Offset = "0x3DC29A0", VA = "0x183DC3FA0")]
	public ADGBGPOFNEG(IEnumerable<TData> CEMCGBKNJIN, Vector3 HMJPLBDDPMG, bool LONBMPLGMMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct DHLHFOIBGAL<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public readonly IEnumerable<TData> CEMCGBKNJIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public readonly bool LONBMPLGMMN;

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x5A62850", Offset = "0x5A61250", VA = "0x185A62850")]
	public DHLHFOIBGAL(IEnumerable<TData> CEMCGBKNJIN, bool LONBMPLGMMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct AMICCBDALFE<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public readonly IEnumerable<TData> CEMCGBKNJIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public readonly Vector3 CJOCKJDPJGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly KEEIMJEHLDG NEELFOHIDOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public readonly bool LONBMPLGMMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly Space LLOCDBEDPDF;

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x3DEFD40", Offset = "0x3DEE740", VA = "0x183DEFD40")]
	public AMICCBDALFE(IEnumerable<TData> CEMCGBKNJIN, Vector3 CJOCKJDPJGP, KEEIMJEHLDG NEELFOHIDOG, bool LONBMPLGMMN, Space LLOCDBEDPDF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public struct KFNPDCGDENL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public readonly Vector3 HMJPLBDDPMG;

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x225DC00", Offset = "0x225C600", VA = "0x18225DC00")]
	public KFNPDCGDENL(Vector3 HMJPLBDDPMG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public enum KEEIMJEHLDG
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
public interface INMKBMGJFNA
{
	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AAPMEMGCMFN([In] EHMEIPALAIF MGKCJKOKGIL);
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class PKMBODBFLNO : LEABKBEFKMB<INMKBMGJFNA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly EHMEIPALAIF MGKCJKOKGIL;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6BED080", Offset = "0x6BEBA80", VA = "0x186BED080")]
	public PKMBODBFLNO(bool LONBMPLGMMN, INMKBMGJFNA BKEICMBDHGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6BECFD0", Offset = "0x6BEB9D0", VA = "0x186BECFD0", Slot = "4")]
	public override bool AAPMEMGCMFN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public readonly struct EHMEIPALAIF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public readonly bool LONBMPLGMMN;

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x225C3B0", Offset = "0x225ADB0", VA = "0x18225C3B0")]
	public EHMEIPALAIF(bool LONBMPLGMMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public interface FCJCOOLPDJK<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AAPMEMGCMFN([In] CAFGBLGFHKO<TData> IPNNPHOPOEM);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool AAPMEMGCMFN([In] PGGNKGMFHLD<TData> IPNNPHOPOEM);
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public interface NHJIGAEBNPG<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IKMBLGNCIEM([In] CHCKFDBPAOL<TData> AHOFICMMCPN);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MHCILAPBCNH([In] PLBOJBFGPKC MKCNMPJIDKG);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KBFALDMMEKL();
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class ELEHMPMFKKA<TData> : LEABKBEFKMB<FCJCOOLPDJK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly CAFGBLGFHKO<TData> IPNNPHOPOEM;

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x39A2C50", Offset = "0x39A1650", VA = "0x1839A2C50")]
	public ELEHMPMFKKA(IEnumerable<TData> CEMCGBKNJIN, Quaternion HMJPLBDDPMG, Vector3? DLANLDIMMOF, bool LAGCBKFDFLL, bool LONBMPLGMMN, FCJCOOLPDJK<TData> BKEICMBDHGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x396B640", Offset = "0x396A040", VA = "0x18396B640", Slot = "4")]
	public override bool AAPMEMGCMFN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class GDOACJJPNBC<TData> : LEABKBEFKMB<NHJIGAEBNPG<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x39A25C0", Offset = "0x39A0FC0", VA = "0x1839A25C0")]
	public GDOACJJPNBC(NHJIGAEBNPG<TData> BKEICMBDHGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x3E0A3B0", Offset = "0x3E08DB0", VA = "0x183E0A3B0", Slot = "4")]
	public override bool AAPMEMGCMFN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class HDOPJHLBNIK<TData> : LEABKBEFKMB<NHJIGAEBNPG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly CHCKFDBPAOL<TData> IPNNPHOPOEM;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x3ECEA80", Offset = "0x3ECD480", VA = "0x183ECEA80")]
	public HDOPJHLBNIK(IEnumerable<TData> CEMCGBKNJIN, bool LONBMPLGMMN, NHJIGAEBNPG<TData> BKEICMBDHGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x396B640", Offset = "0x396A040", VA = "0x18396B640", Slot = "4")]
	public override bool AAPMEMGCMFN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class NNGJDACHFAH<TData> : LEABKBEFKMB<FCJCOOLPDJK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly PGGNKGMFHLD<TData> IPNNPHOPOEM;

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x46CE8E0", Offset = "0x46CD2E0", VA = "0x1846CE8E0")]
	public NNGJDACHFAH(IEnumerable<TData> CEMCGBKNJIN, Quaternion DEEEKODDHGP, KEEIMJEHLDG AEOGPIJBKJK, Vector3? DLANLDIMMOF, bool LAGCBKFDFLL, bool LONBMPLGMMN, Space LLOCDBEDPDF, FCJCOOLPDJK<TData> BKEICMBDHGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x460CED0", Offset = "0x460B8D0", VA = "0x18460CED0", Slot = "4")]
	public override bool AAPMEMGCMFN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public class MLPFNPKINME<TData> : LEABKBEFKMB<NHJIGAEBNPG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly PLBOJBFGPKC IPNNPHOPOEM;

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x462BE70", Offset = "0x462A870", VA = "0x18462BE70")]
	public MLPFNPKINME(Quaternion HMJPLBDDPMG, Vector3? DLANLDIMMOF, bool LAGCBKFDFLL, NHJIGAEBNPG<TData> BKEICMBDHGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x3D312A0", Offset = "0x3D2FCA0", VA = "0x183D312A0", Slot = "4")]
	public override bool AAPMEMGCMFN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public struct CAFGBLGFHKO<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public readonly IEnumerable<TData> CEMCGBKNJIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public readonly Quaternion HMJPLBDDPMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public readonly Vector3? DLANLDIMMOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public readonly bool LAGCBKFDFLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public readonly bool LONBMPLGMMN;

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x510F0E0", Offset = "0x510DAE0", VA = "0x18510F0E0")]
	public CAFGBLGFHKO(IEnumerable<TData> CEMCGBKNJIN, Quaternion HMJPLBDDPMG, Vector3? DLANLDIMMOF, bool LAGCBKFDFLL, bool LONBMPLGMMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public struct CHCKFDBPAOL<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public readonly IEnumerable<TData> CEMCGBKNJIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly bool LONBMPLGMMN;

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x5439810", Offset = "0x5438210", VA = "0x185439810")]
	public CHCKFDBPAOL(IEnumerable<TData> CEMCGBKNJIN, bool LONBMPLGMMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public struct PGGNKGMFHLD<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public readonly IEnumerable<TData> CEMCGBKNJIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public readonly Quaternion DEEEKODDHGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public readonly KEEIMJEHLDG AEOGPIJBKJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public readonly Vector3? DLANLDIMMOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public readonly bool LAGCBKFDFLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public readonly bool LONBMPLGMMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public readonly Space LLOCDBEDPDF;

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x4925E10", Offset = "0x4924810", VA = "0x184925E10")]
	public PGGNKGMFHLD(IEnumerable<TData> CEMCGBKNJIN, Quaternion DEEEKODDHGP, KEEIMJEHLDG AEOGPIJBKJK, Vector3? DLANLDIMMOF, bool LAGCBKFDFLL, bool LONBMPLGMMN, Space LLOCDBEDPDF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public struct PLBOJBFGPKC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public readonly Quaternion HMJPLBDDPMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public readonly Vector3? DLANLDIMMOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public readonly bool LAGCBKFDFLL;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x4E879C0", Offset = "0x4E863C0", VA = "0x184E879C0")]
	public PLBOJBFGPKC(Quaternion HMJPLBDDPMG, Vector3? DLANLDIMMOF, bool LAGCBKFDFLL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public interface COHKAAGPJGM<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IKMBLGNCIEM([In] GMEMDGHLLNL<TData> AHOFICMMCPN);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MHCILAPBCNH([In] GNGDCJBPDEG MKCNMPJIDKG);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MHCILAPBCNH([In] NHHOBBGICIE MKCNMPJIDKG);

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MHCILAPBCNH([In] MJOHJNOIEEJ MKCNMPJIDKG);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool KBFALDMMEKL();
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public class FFLCBHCEDDK<TData> : LEABKBEFKMB<COHKAAGPJGM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly MJOHJNOIEEJ DGOJKGNGBJL;

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x3D429C0", Offset = "0x3D413C0", VA = "0x183D429C0")]
	public FFLCBHCEDDK(Vector3 FINMJBHBJJK, float EHGIEAAFJMP, Vector3 DLANLDIMMOF, bool DGNLAKEIGAD, bool GAMLANKLHCJ, COHKAAGPJGM<TData> BKEICMBDHGB, Space LLOCDBEDPDF = Space.Self)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x3D42960", Offset = "0x3D41360", VA = "0x183D42960", Slot = "4")]
	public override bool AAPMEMGCMFN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class LMILPAFBCPG<TData> : LEABKBEFKMB<COHKAAGPJGM<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x39A25C0", Offset = "0x39A0FC0", VA = "0x1839A25C0")]
	public LMILPAFBCPG(COHKAAGPJGM<TData> BKEICMBDHGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x443E0F0", Offset = "0x443CAF0", VA = "0x18443E0F0", Slot = "4")]
	public override bool AAPMEMGCMFN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class JCECBOLMOCH<TData> : LEABKBEFKMB<COHKAAGPJGM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly GMEMDGHLLNL<TData> DGOJKGNGBJL;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x41FE3D0", Offset = "0x41FCDD0", VA = "0x1841FE3D0")]
	public JCECBOLMOCH(IEnumerable<TData> CEMCGBKNJIN, bool LONBMPLGMMN, COHKAAGPJGM<TData> BKEICMBDHGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x396B640", Offset = "0x396A040", VA = "0x18396B640", Slot = "4")]
	public override bool AAPMEMGCMFN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class KLODCGODJCJ<TData> : LEABKBEFKMB<COHKAAGPJGM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly NHHOBBGICIE DGOJKGNGBJL;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x438DD60", Offset = "0x438C760", VA = "0x18438DD60")]
	public KLODCGODJCJ(float CHCNDKOLLNF, bool PNACCHOFCEN, Vector3 DLANLDIMMOF, COHKAAGPJGM<TData> BKEICMBDHGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x438DCA0", Offset = "0x438C6A0", VA = "0x18438DCA0", Slot = "4")]
	public override bool AAPMEMGCMFN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public class HIFAIGNCOGN<TData> : LEABKBEFKMB<COHKAAGPJGM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly GNGDCJBPDEG DGOJKGNGBJL;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x3EE58E0", Offset = "0x3EE42E0", VA = "0x183EE58E0")]
	public HIFAIGNCOGN(float EHGIEAAFJMP, Vector3 DLANLDIMMOF, COHKAAGPJGM<TData> BKEICMBDHGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x3D312A0", Offset = "0x3D2FCA0", VA = "0x183D312A0", Slot = "4")]
	public override bool AAPMEMGCMFN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public struct MJOHJNOIEEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public readonly Vector3 FINMJBHBJJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public readonly float EHGIEAAFJMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public readonly Vector3 DLANLDIMMOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public readonly bool FKOEGJPINIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public readonly Space LLOCDBEDPDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public readonly bool GAMLANKLHCJ;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x6BEC920", Offset = "0x6BEB320", VA = "0x186BEC920")]
	public MJOHJNOIEEJ(Vector3 FINMJBHBJJK, float EHGIEAAFJMP, Vector3 DLANLDIMMOF, bool FKOEGJPINIE, bool DLAJNFAEFEC, Space LLOCDBEDPDF = Space.Self)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct GMEMDGHLLNL<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public readonly IEnumerable<TData> CEMCGBKNJIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public readonly bool LONBMPLGMMN;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x3E31B20", Offset = "0x3E30520", VA = "0x183E31B20")]
	public GMEMDGHLLNL(IEnumerable<TData> CEMCGBKNJIN, bool LONBMPLGMMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public struct NHHOBBGICIE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public readonly float CHCNDKOLLNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public readonly bool PNACCHOFCEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public readonly Vector3 DLANLDIMMOF;

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6BEC960", Offset = "0x6BEB360", VA = "0x186BEC960")]
	public NHHOBBGICIE(float CHCNDKOLLNF, bool PNACCHOFCEN, Vector3 DLANLDIMMOF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct GNGDCJBPDEG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public readonly float EHGIEAAFJMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public readonly Vector3 DLANLDIMMOF;

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x4E61960", Offset = "0x4E60360", VA = "0x184E61960")]
	public GNGDCJBPDEG(float EHGIEAAFJMP, Vector3 DLANLDIMMOF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public struct ANGEKJIIKOJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public readonly Guid[] CEMCGBKNJIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public readonly bool ABKALILABEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public readonly bool HCGAAMECILO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public readonly bool EKJCKJJANIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public readonly Vector3[] IGHLHPNKDJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public readonly Quaternion[] EIKHHFBBGOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly float[] KDNBBBGDGJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public readonly Dictionary<Guid, Vector3> BCJDPIKEDEI;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6BEBD00", Offset = "0x6BEA700", VA = "0x186BEBD00")]
	public ANGEKJIIKOJ(Guid[] LDAPENPAMCE, Vector3[] IGHLHPNKDJG, Quaternion[] EIKHHFBBGOA, float[] KDNBBBGDGJC, Dictionary<Guid, Vector3> BCJDPIKEDEI, bool ABKALILABEC = true, bool HCGAAMECILO = true, bool EKJCKJJANIB = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6BEBB30", Offset = "0x6BEA530", VA = "0x186BEBB30")]
	private static void EHHJEIJEMHG(Dictionary<Guid, Vector3> BCJDPIKEDEI, int AGMDNJBDIHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public static class OGNPLKDHIBF
{
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	private struct ENDBDBHABEA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public bool CCMANKGFMID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public APIKLLPBEEI DHDKIOCADCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public APIKLLPBEEI HHHIIJKDAPH;
	}

	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private static ENDBDBHABEA JBEGPGEHFNM;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static CancellationToken FHCIEHPBAPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6BECC30", Offset = "0x6BEB630", VA = "0x186BECC30")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	internal static APIKLLPBEEI DHDKIOCADCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x6BECDF0", Offset = "0x6BEB7F0", VA = "0x186BECDF0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x6BECD90", Offset = "0x6BEB790", VA = "0x186BECD90")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6BECE90", Offset = "0x6BEB890", VA = "0x186BECE90")]
	[POCMGODEOKB.HFEKBIAFIHM]
	internal static void IIODECBGFBD(APIKLLPBEEI KIEDFCFBCBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6BECC50", Offset = "0x6BEB650", VA = "0x186BECC50")]
	public static void CGBFLDMMJFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6BECF80", Offset = "0x6BEB980", VA = "0x186BECF80")]
	private static APIKLLPBEEI KCAGKEPDLFI(APIKLLPBEEI BPCIMENMBAL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public static class JDHJCJJFIDP
{
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public enum MFIJFLKNHOF
	{
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		ICreationContextObject,
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		Guid
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x2CF81D0", Offset = "0x2CF6BD0", VA = "0x182CF81D0")]
	public static void HGBKEEEFIFH<T>(T NKEOLIFBNFG, MFIJFLKNHOF NNCMOPPBEEE) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x2CF8160", Offset = "0x2CF6B60", VA = "0x182CF8160")]
	public static void HGBKEEEFIFH<T>(T NKEOLIFBNFG) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x2CF80B0", Offset = "0x2CF6AB0", VA = "0x182CF80B0")]
	public static void GKNKKKLOBFE<T>(T NKEOLIFBNFG) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x2CF8540", Offset = "0x2CF6F40", VA = "0x182CF8540")]
	public static T PHNOCPFLPNG<T>(MFIJFLKNHOF NNCMOPPBEEE) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x2CF8330", Offset = "0x2CF6D30", VA = "0x182CF8330")]
	public static bool MJGHNDKEOOO<T>(MFIJFLKNHOF NNCMOPPBEEE, T? IMKJMAOAJPC, [Out][MaybeNullWhen(false)][NotNullWhen(true)] T JAKCDOIPMKB) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x2CF8000", Offset = "0x2CF6A00", VA = "0x182CF8000")]
	public static bool DFMKNIJMKAD<T>(MFIJFLKNHOF NNCMOPPBEEE) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x2CF7FA0", Offset = "0x2CF69A0", VA = "0x182CF7FA0")]
	public static T PHNOCPFLPNG<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x2CF8480", Offset = "0x2CF6E80", VA = "0x182CF8480")]
	public static bool MJGHNDKEOOO<T>(T IMKJMAOAJPC, [Out] T JAKCDOIPMKB) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x2CF7FA0", Offset = "0x2CF69A0", VA = "0x182CF7FA0")]
	public static bool DFMKNIJMKAD<T>() where T : class
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
internal static class NONOILIKODO
{
	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6BEC980", Offset = "0x6BEB380", VA = "0x186BEC980")]
	public static void OJKFLELBCEC(IEnumerable KJBMEIGLOCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x2DC7730", Offset = "0x2DC6130", VA = "0x182DC7730")]
	public static void OJKFLELBCEC<T>(T[] FNCIFDCGDBA) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x2DC7820", Offset = "0x2DC6220", VA = "0x182DC7820")]
	public static void OJKFLELBCEC<T>(T NPGBIOOADNL) where T : notnull, Enum
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
