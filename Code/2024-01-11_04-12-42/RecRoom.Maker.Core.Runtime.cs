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
		[Cpp2IlInjected.Address(RVA = "0x7BA380", Offset = "0x7B8D80", VA = "0x1807BA380")]
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
		[Cpp2IlInjected.Address(RVA = "0x5FFE170", Offset = "0x5FFCB70", VA = "0x185FFE170")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7BA560", Offset = "0x7B8F60", VA = "0x1807BA560")]
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
		[Cpp2IlInjected.Address(RVA = "0x7BA5A0", Offset = "0x7B8FA0", VA = "0x1807BA5A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface CINIAJHCKBK<TData, TReturn>
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TReturn CanConnectableObjectBeSelected(TData GKNPKJAGNGH);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface JJDPIIICGNL<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ClearHoverTarget(FFMGPAJMFKH MJKJFCNEABF);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool SetHoverTarget(TData DMFBOAFMPLH, Collider NPKLKEFGKHF, FFMGPAJMFKH MJKJFCNEABF, [Optional] IEFCPPDLNAK? OHCPBOBEAEC);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool TryGetHoverTarget([Out] TData DMFBOAFMPLH);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface HCOKEGILIHO<TData> : JMOOEHFGJHI, NIAELNBJJLO<TData>, FLBHGDGNKKD<TData>, COEOLGHBDGM<TData>, BBCJOGDEBHE, OJDJPPBFBAK<TData>, KCEOEEPHBJM, FAIDOGPOJMB
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface OJDJPPBFBAK<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 LJKGEKDBINO, Vector3 NEGLEJJNHEL, float ECIJIDKCAEE, [Out] T EFIAOGFGDHI, [Out] Vector3 GCMONOAKKHE, [Out] Collider NPKLKEFGKHF);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 LJKGEKDBINO, Vector3 NEGLEJJNHEL, float AJMAPHHJJIJ, float ECIJIDKCAEE, T[] KOPCBHCHMDJ, [Out] Vector3 AEDBDFHPGCD, [Out] Collider HGLFNHDBJCL);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 LJKGEKDBINO, float AJMAPHHJJIJ, Vector3 JOGMKNEIJNH, T[] KOPCBHCHMDJ);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetObjectFromColliderInCurrentScope(Collider BLBJIPJCMAO, [Out] T BNADMDMLHCK);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface JMOOEHFGJHI
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Bounds ILHBPKEKOCG
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Transform DLIDGBGHFAA
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Bounds OOKGCNMCGKL
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Transform JODCMIKDJBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Vector3 GLJAJIJILHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void SetSelectionBoundsDirty(bool PHDDNMGBANA = true, int MCBHFNHEOBK = 0);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ShouldHideSelectionBoundsPreview(bool LPDKODDBGAL, object BDAPLOBBPIE);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface FAIDOGPOJMB
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	BCNLEBGHOIF GGKFJHKGPNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface EELJDCNHGMJ
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool NOIHCBFHKMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool MAICLGHIHMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool AFLBMBKNOGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Dictionary<Guid, Guid> TryGetPreviousCloneMapping();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void TrySetPreviousCloneMapping(Dictionary<Guid, Guid> OLFCNCJEPGF);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface COEOLGHBDGM<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool IHCMAJDONLA
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	int IHBCJOGNGIA
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	IEnumerable<TData> CJPEKALBFJB
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData PPIDKPHGGGP);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData PPIDKPHGGGP);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface NIAELNBJJLO<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T GKNPKJAGNGH, [Optional] IEFCPPDLNAK? BBEBMHMIOHJ, bool GELHKBJEGCB = true);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int MPNHPMPEEBM, IEnumerable<T> OJOEBEILHFP, bool GELHKBJEGCB = true);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int MPNHPMPEEBM, IEnumerable<T> OJOEBEILHFP, IEFCPPDLNAK BBEBMHMIOHJ, bool GELHKBJEGCB = true);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface KCEOEEPHBJM
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface BBCJOGDEBHE
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool MAFIBJKDEMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool KGOEFKOPGBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool FFOOMDAKLDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool EBLNOKMNPJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class PLJJDOJAABD<TReceiver> : DLHJMCKOPDG<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x322C220", Offset = "0x322AC20", VA = "0x18322C220")]
	public PLJJDOJAABD(TReceiver LJKLAGCNGHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class DDNMKBABMEE<TReceiver, TFromTask> : DLHJMCKOPDG<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x322C220", Offset = "0x322AC20", VA = "0x18322C220")]
	public DDNMKBABMEE(TReceiver LJKLAGCNGHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public abstract class DLHJMCKOPDG<TReceiver, TFromExecute> where TReceiver : notnull where TFromExecute : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	protected TReceiver LJKLAGCNGHO;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4F6DE00", Offset = "0x4F6C800", VA = "0x184F6DE00")]
	public DLHJMCKOPDG(TReceiver LJKLAGCNGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute MFAECAIDCEL();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public abstract class EAHDKPBCHDE<TReceiver, TResult> : DLHJMCKOPDG<TReceiver, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x322C220", Offset = "0x322AC20", VA = "0x18322C220")]
	public EAHDKPBCHDE(TReceiver LJKLAGCNGHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct HADCAPANLEL<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public TGroup BKKDCIKFOFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public TData KJIBJOAIHIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public IEnumerable<TData> OIDIOANJLDH;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x1A02720", Offset = "0x1A01120", VA = "0x181A02720")]
	public HADCAPANLEL(TGroup BCJDNIJLOAD, TData PHFMDNEEOFL, IEnumerable<TData> PEPEKFNOBME)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct DHGJDMHHJJB<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public TGroup BKKDCIKFOFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public IEnumerable<TData> OIDIOANJLDH;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x85EBA0", Offset = "0x85D5A0", VA = "0x18085EBA0")]
	public DHGJDMHHJJB(TGroup BCJDNIJLOAD, IEnumerable<TData> PEPEKFNOBME)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct HNBLPHPNBJO<TGroup> where TGroup : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public TGroup BKKDCIKFOFM;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x8C16C0", Offset = "0x8C00C0", VA = "0x1808C16C0")]
	public HNBLPHPNBJO(TGroup BCJDNIJLOAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct ENEEAABIFJK<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public IEnumerable<TData> OIDIOANJLDH;

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8C16C0", Offset = "0x8C00C0", VA = "0x1808C16C0")]
	public ENEEAABIFJK(IEnumerable<TData> PEPEKFNOBME)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface PBOOPLHMDDF<TGroup, TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HHHMDNAOPIN EJPKKADOOBH(HADCAPANLEL<TGroup, TData> HFGMMIOJCON);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HHHMDNAOPIN DPGCLKPDHFB(HADCAPANLEL<TGroup, TData> HFGMMIOJCON);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HHHMDNAOPIN MMCCEOJKICG(DHGJDMHHJJB<TGroup, TData> HFGMMIOJCON);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "3")]
	HHHMDNAOPIN BCBNNPPDIEK(HNBLPHPNBJO<TGroup> HFGMMIOJCON);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface EIKICFEGOFB<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<HHHMDNAOPIN> EJPKKADOOBH(ENEEAABIFJK<TData> HFGMMIOJCON);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class CNPKKGOFJGB<TGroup, TData> : EAHDKPBCHDE<PBOOPLHMDDF<TGroup, TData>, HHHMDNAOPIN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly DHGJDMHHJJB<TGroup, TData> HFGMMIOJCON;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4D8B390", Offset = "0x4D89D90", VA = "0x184D8B390")]
	public CNPKKGOFJGB(TGroup BCJDNIJLOAD, IEnumerable<TData> PEPEKFNOBME, PBOOPLHMDDF<TGroup, TData> LJKLAGCNGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4D8B2C0", Offset = "0x4D89CC0", VA = "0x184D8B2C0", Slot = "4")]
	public override HHHMDNAOPIN MFAECAIDCEL()
	{
		return default(HHHMDNAOPIN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class NKOKBLPGOIB<TGroup, TData> : EAHDKPBCHDE<PBOOPLHMDDF<TGroup, TData>, HHHMDNAOPIN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly HADCAPANLEL<TGroup, TData> HFGMMIOJCON;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x35B2320", Offset = "0x35B0D20", VA = "0x1835B2320")]
	public NKOKBLPGOIB(TGroup BCJDNIJLOAD, TData PKIGGLLDMOI, IEnumerable<TData> PEPEKFNOBME, PBOOPLHMDDF<TGroup, TData> LJKLAGCNGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3E98580", Offset = "0x3E96F80", VA = "0x183E98580", Slot = "4")]
	public override HHHMDNAOPIN MFAECAIDCEL()
	{
		return default(HHHMDNAOPIN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class GAPOBHOHNAK<TGroup, TData> : EAHDKPBCHDE<PBOOPLHMDDF<TGroup, TData>, HHHMDNAOPIN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly HNBLPHPNBJO<TGroup> HFGMMIOJCON;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3699090", Offset = "0x3697A90", VA = "0x183699090")]
	public GAPOBHOHNAK(TGroup BCJDNIJLOAD, PBOOPLHMDDF<TGroup, TData> LJKLAGCNGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3698FC0", Offset = "0x36979C0", VA = "0x183698FC0", Slot = "4")]
	public override HHHMDNAOPIN MFAECAIDCEL()
	{
		return default(HHHMDNAOPIN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class FDLKNDNFFEN<TGroup, TData> : EAHDKPBCHDE<PBOOPLHMDDF<TGroup, TData>, HHHMDNAOPIN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly HADCAPANLEL<TGroup, TData> HFGMMIOJCON;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x35B2320", Offset = "0x35B0D20", VA = "0x1835B2320")]
	public FDLKNDNFFEN(TGroup BCJDNIJLOAD, TData PHFMDNEEOFL, IEnumerable<TData> PEPEKFNOBME, PBOOPLHMDDF<TGroup, TData> LJKLAGCNGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x35B2240", Offset = "0x35B0C40", VA = "0x1835B2240", Slot = "4")]
	public override HHHMDNAOPIN MFAECAIDCEL()
	{
		return default(HHHMDNAOPIN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class JLPAKKKOOIP<TData> : DDNMKBABMEE<EIKICFEGOFB<TData>, HHHMDNAOPIN> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private struct OGDKNINGCHL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AsyncTaskMethodBuilder<HHHMDNAOPIN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public JLPAKKKOOIP<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private TaskAwaiter<HHHMDNAOPIN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x3F7CA90", Offset = "0x3F7B490", VA = "0x183F7CA90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3F7CD30", Offset = "0x3F7B730", VA = "0x183F7CD30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private ENEEAABIFJK<TData> HFGMMIOJCON;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3699090", Offset = "0x3697A90", VA = "0x183699090")]
	public JLPAKKKOOIP(IEnumerable<TData> NHGMPLGFFMM, EIKICFEGOFB<TData> LJKLAGCNGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3A4E7E0", Offset = "0x3A4D1E0", VA = "0x183A4E7E0", Slot = "4")]
	[AsyncStateMachine(typeof(JLPAKKKOOIP<>.OGDKNINGCHL))]
	public override Task<HHHMDNAOPIN> MFAECAIDCEL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct AMFFFCPNGEN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly OKKOKFOEMPO GPLNGDMFGBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly bool LPHKHNHNGPI;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5FFD450", Offset = "0x5FFBE50", VA = "0x185FFD450")]
	public AMFFFCPNGEN(OKKOKFOEMPO IDNNBGFJMFF, bool NELFFOMOLHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface PHGBALBHONL<TSpawnType> where TSpawnType : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> MFAECAIDCEL(AMFFFCPNGEN KOBJIHHDGBJ);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class MNDCBOFDAFB<TSpawnType> : DDNMKBABMEE<PHGBALBHONL<TSpawnType>, TSpawnType> where TSpawnType : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private struct JPJCCCLLNHF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public AsyncTaskMethodBuilder<TSpawnType> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public MNDCBOFDAFB<TSpawnType> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskAwaiter<TSpawnType> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3A66DA0", Offset = "0x3A657A0", VA = "0x183A66DA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3A67500", Offset = "0x3A65F00", VA = "0x183A67500", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly AMFFFCPNGEN KOBJIHHDGBJ;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3DF0780", Offset = "0x3DEF180", VA = "0x183DF0780")]
	public MNDCBOFDAFB(OKKOKFOEMPO IDNNBGFJMFF, bool NELFFOMOLHB, PHGBALBHONL<TSpawnType> LJKLAGCNGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3DF0480", Offset = "0x3DEEE80", VA = "0x183DF0480", Slot = "4")]
	[AsyncStateMachine(typeof(MNDCBOFDAFB<>.JPJCCCLLNHF))]
	public override Task<TSpawnType> MFAECAIDCEL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public readonly struct OKKOKFOEMPO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly bool APPNCNKIIPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly Vector3 PFMKBDDCECO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly Vector3 LMPBAOBONND;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5FFE3B0", Offset = "0x5FFCDB0", VA = "0x185FFE3B0")]
	public OKKOKFOEMPO(Transform AGOILNJOICO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5FFE2F0", Offset = "0x5FFCCF0", VA = "0x185FFE2F0")]
	public OKKOKFOEMPO(Vector3 AJENBHCBECD, Vector3 CJONGNPPIAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5FFE2C0", Offset = "0x5FFCCC0", VA = "0x185FFE2C0")]
	public static OKKOKFOEMPO EGBGIHNMJKJ()
	{
		return default(OKKOKFOEMPO);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5FFE320", Offset = "0x5FFCD20", VA = "0x185FFE320")]
	private OKKOKFOEMPO(bool DONMOHLDPFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct BNFEALHMEGN<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public TNode PKFMCNALANH;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x48FC040", Offset = "0x48FAA40", VA = "0x1848FC040")]
	public BNFEALHMEGN(TNode PKFMCNALANH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct DMELMGHNKCO<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public TNode PNKKJFELINC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public CMKLCDLGDPF BBBLLCBEHAF;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4F71EC0", Offset = "0x4F708C0", VA = "0x184F71EC0")]
	public DMELMGHNKCO(TNode PNKKJFELINC, CMKLCDLGDPF BBBLLCBEHAF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface DEGAJOAFMBP<TNode>
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EJFLFAIKNHK([In] BNFEALHMEGN<TNode> EHICECGANFG);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GEBLAAONJDC([In] DMELMGHNKCO<TNode> JCGOLBFKDJF);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GKCBLOGFFBP();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class DLFNAHIGBBO<TNode> : PLJJDOJAABD<DEGAJOAFMBP<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x322C220", Offset = "0x322AC20", VA = "0x18322C220")]
	public DLFNAHIGBBO(DEGAJOAFMBP<TNode> LJKLAGCNGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3736DE0", Offset = "0x37357E0", VA = "0x183736DE0", Slot = "4")]
	public override bool MFAECAIDCEL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class EALFAJFGKAK<TNode> : PLJJDOJAABD<DEGAJOAFMBP<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly DMELMGHNKCO<TNode> JCGOLBFKDJF;

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x322C4A0", Offset = "0x322AEA0", VA = "0x18322C4A0")]
	public EALFAJFGKAK(TNode PNKKJFELINC, CMKLCDLGDPF BBBLLCBEHAF, DEGAJOAFMBP<TNode> LJKLAGCNGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x322C3D0", Offset = "0x322ADD0", VA = "0x18322C3D0", Slot = "4")]
	public override bool MFAECAIDCEL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class DFDJBGMEBOO<TNode> : PLJJDOJAABD<DEGAJOAFMBP<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly BNFEALHMEGN<TNode> EHICECGANFG;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x4F5CDB0", Offset = "0x4F5B7B0", VA = "0x184F5CDB0")]
	public DFDJBGMEBOO(TNode EHOCDEOCKJJ, DEGAJOAFMBP<TNode> LJKLAGCNGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3258D10", Offset = "0x3257710", VA = "0x183258D10", Slot = "4")]
	public override bool MFAECAIDCEL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct NFKBDPJDPAI<TSpawnInfo> where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public TSpawnInfo EIDGIHGMIJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public Vector3 CJONGNPPIAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public Quaternion KPKKBKKOGOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public float EFPGCAMCJII;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0xE328C0", Offset = "0xE312C0", VA = "0x180E328C0")]
	public NFKBDPJDPAI(TSpawnInfo EIDGIHGMIJA, Vector3 CJONGNPPIAD, Quaternion KPKKBKKOGOG, float EFPGCAMCJII)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface CDABOGBMMLL<TSpawnType, TSpawnInfo>
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> KEGDOPHOEIG([In] NFKBDPJDPAI<TSpawnInfo> IIPKGFKACCM, CancellationToken EAPNOLMLMHM);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class MJCGOMGBGIN<TSpawnType, TSpawnInfo> : DDNMKBABMEE<CDABOGBMMLL<TSpawnType, TSpawnInfo>, TSpawnType> where TSpawnType : notnull where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly NFKBDPJDPAI<TSpawnInfo> BFAMAJEDCBA;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3DE7FE0", Offset = "0x3DE69E0", VA = "0x183DE7FE0")]
	public MJCGOMGBGIN(TSpawnInfo HHGJBMPACFD, Vector3 CJONGNPPIAD, Quaternion KPKKBKKOGOG, float EFPGCAMCJII, CDABOGBMMLL<TSpawnType, TSpawnInfo> LJKLAGCNGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3DE7F00", Offset = "0x3DE6900", VA = "0x183DE7F00", Slot = "4")]
	public override Task<TSpawnType> MFAECAIDCEL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct NHFLMDONGJK<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly IEnumerable<TData> OIDIOANJLDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly bool LPHKHNHNGPI;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3E5A080", Offset = "0x3E58A80", VA = "0x183E5A080")]
	public NHFLMDONGJK(IEnumerable<TData> PEPEKFNOBME, bool NELFFOMOLHB = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface PNDECGMDFIO<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<HHHMDNAOPIN> PELMBHNHICD([In] NHFLMDONGJK<TData> MNHHMNHENDM, CancellationToken EAPNOLMLMHM);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class DOLNFGEGAGO<TData> : DDNMKBABMEE<PNDECGMDFIO<TData>, HHHMDNAOPIN> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly NHFLMDONGJK<TData> OFHMPMDGJFK;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x4F78850", Offset = "0x4F77250", VA = "0x184F78850")]
	public DOLNFGEGAGO(IEnumerable<TData> PEPEKFNOBME, bool NELFFOMOLHB, PNDECGMDFIO<TData> LJKLAGCNGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x3DE7F00", Offset = "0x3DE6900", VA = "0x183DE7F00", Slot = "4")]
	public override Task<HHHMDNAOPIN> MFAECAIDCEL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct HFPHEDPJAGI<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly T DMFBOAFMPLH;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x36F30C0", Offset = "0x36F1AC0", VA = "0x1836F30C0")]
	public HFPHEDPJAGI(T HCIBPLFIHIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface KCIAPEICINA<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EJFLFAIKNHK([In] HFPHEDPJAGI<T> NGIOCAGICJD);

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GEBLAAONJDC();
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface PIFGENMKFEK<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MFAECAIDCEL([In] KAJIPDBKEDC<T> KNMHEAJGBCD);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct KAJIPDBKEDC<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public readonly T DMFBOAFMPLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public readonly bool FAOOEOKBMED;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x3A95F60", Offset = "0x3A94960", VA = "0x183A95F60")]
	public KAJIPDBKEDC(T HCIBPLFIHIN, bool IJHMEFFFOKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class DANNLFAKJFH<T> : PLJJDOJAABD<KCIAPEICINA<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x322C220", Offset = "0x322AC20", VA = "0x18322C220")]
	public DANNLFAKJFH(KCIAPEICINA<T> LJKLAGCNGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x3E2B110", Offset = "0x3E29B10", VA = "0x183E2B110", Slot = "4")]
	public override bool MFAECAIDCEL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class DCAILBEPGBO<T> : PLJJDOJAABD<KCIAPEICINA<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly HFPHEDPJAGI<T> NGIOCAGICJD;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x4F59F30", Offset = "0x4F58930", VA = "0x184F59F30")]
	public DCAILBEPGBO(T DMFBOAFMPLH, KCIAPEICINA<T> LJKLAGCNGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x3258D10", Offset = "0x3257710", VA = "0x183258D10", Slot = "4")]
	public override bool MFAECAIDCEL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class EKCAEFKOPHE<T> : PLJJDOJAABD<PIFGENMKFEK<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly KAJIPDBKEDC<T> KNMHEAJGBCD;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x3258DD0", Offset = "0x32577D0", VA = "0x183258DD0")]
	public EKCAEFKOPHE(T DMFBOAFMPLH, bool IJHMEFFFOKG, PIFGENMKFEK<T> LJKLAGCNGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x3258D10", Offset = "0x3257710", VA = "0x183258D10", Slot = "4")]
	public override bool MFAECAIDCEL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct FICJBODKLNP<TData> where TData : notnull, GDDAFFAHFKP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public IEnumerable<TData> OIDIOANJLDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public bool GBMJGEBBFJK;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x35C1AC0", Offset = "0x35C04C0", VA = "0x1835C1AC0")]
	public FICJBODKLNP(IEnumerable<TData> LDONDLNCMLE, bool CDFKBMOLLMI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct EIFCJGGOBBI<TData> where TData : notnull, GDDAFFAHFKP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public List<TData> OIDIOANJLDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public List<bool> CBOKOGKHAAO;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x324CB20", Offset = "0x324B520", VA = "0x18324CB20")]
	public EIFCJGGOBBI(List<TData> LDONDLNCMLE, List<bool> NPFDIHBKBGI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface GDDAFFAHFKP
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool NHBIOPAJINN
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface EKBOHPNPLNK<TData> where TData : GDDAFFAHFKP
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MFAECAIDCEL([In] FICJBODKLNP<TData> EJHEMHHOOAO);

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MFAECAIDCEL([In] EIFCJGGOBBI<TData> EJHEMHHOOAO);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface HCGLKNGNEFP<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BJKABGNEFGO(T DMFBOAFMPLH);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class ELFOKJLKIFO<TData> : PLJJDOJAABD<EKBOHPNPLNK<TData>> where TData : notnull, GDDAFFAHFKP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly FICJBODKLNP<TData> EJHEMHHOOAO;

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x32610C0", Offset = "0x325FAC0", VA = "0x1832610C0")]
	public ELFOKJLKIFO(List<TData> PEPEKFNOBME, bool GBMJGEBBFJK, EKBOHPNPLNK<TData> LJKLAGCNGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x3258D10", Offset = "0x3257710", VA = "0x183258D10", Slot = "4")]
	public override bool MFAECAIDCEL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class GFOFHKBCOHL<TData> : PLJJDOJAABD<EKBOHPNPLNK<TData>> where TData : notnull, GDDAFFAHFKP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly EIFCJGGOBBI<TData> EJHEMHHOOAO;

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x369FBA0", Offset = "0x369E5A0", VA = "0x18369FBA0")]
	public GFOFHKBCOHL(List<TData> PEPEKFNOBME, List<bool> CBOKOGKHAAO, EKBOHPNPLNK<TData> LJKLAGCNGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x369FAE0", Offset = "0x369E4E0", VA = "0x18369FAE0", Slot = "4")]
	public override bool MFAECAIDCEL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface DJHLGLGLFLB : GDDAFFAHFKP
{
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface DDEMIADLLGB<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<HHHMDNAOPIN> MFAECAIDCEL(ILEIMBOGFPJ<TData> FEAODBOPOFB);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class KEAGHNOOCGI<TData> : DDNMKBABMEE<DDEMIADLLGB<TData>, HHHMDNAOPIN> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct FEDAHMLIGGA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public AsyncTaskMethodBuilder<HHHMDNAOPIN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public KEAGHNOOCGI<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<HHHMDNAOPIN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x35B2A60", Offset = "0x35B1460", VA = "0x1835B2A60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x35B2D50", Offset = "0x35B1750", VA = "0x1835B2D50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly ILEIMBOGFPJ<TData> OAFPBHLMJKO;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x3AD5EF0", Offset = "0x3AD48F0", VA = "0x183AD5EF0")]
	public KEAGHNOOCGI(TData FAKCHPMAINB, IReadOnlyList<TData> NBBLKEIHCMI, bool NELFFOMOLHB, DDEMIADLLGB<TData> LJKLAGCNGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x3AD5DF0", Offset = "0x3AD47F0", VA = "0x183AD5DF0", Slot = "4")]
	[AsyncStateMachine(typeof(KEAGHNOOCGI<>.FEDAHMLIGGA))]
	public override Task<HHHMDNAOPIN> MFAECAIDCEL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public struct ILEIMBOGFPJ<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public TData LOOOCHGJDKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public IReadOnlyList<TData> DCOMOHEOHOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public bool LPHKHNHNGPI;

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x3846050", Offset = "0x3844A50", VA = "0x183846050")]
	public ILEIMBOGFPJ(TData FAKCHPMAINB, IReadOnlyList<TData> NBBLKEIHCMI, bool NELFFOMOLHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface JOMIFGIMEBP<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MFAECAIDCEL([In] GAEKGKAEIAL<TData> AFKMKHPJMDH);
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface DJINOGEAMMM<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MFAECAIDCEL([In] IFIFGNAGMEL<TData> AFKMKHPJMDH);
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface JONDOONDDLO<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GIABKPLKGBK([In] EMOPDNEJJHG<TData> AFKMKHPJMDH);

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GEBLAAONJDC();
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class GEAIEDFODOD<TData> : PLJJDOJAABD<JOMIFGIMEBP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly GAEKGKAEIAL<TData> AFKMKHPJMDH;

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x369B630", Offset = "0x369A030", VA = "0x18369B630")]
	public GEAIEDFODOD(IEnumerable<TData> PEPEKFNOBME, KJHDKLAENAK GJNHDHNOICC, GOPDAHACAJG HEPAJJIBPIF, float CEBLOHPIDNG, bool NELFFOMOLHB, JOMIFGIMEBP<TData> LJKLAGCNGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x3258D10", Offset = "0x3257710", VA = "0x183258D10", Slot = "4")]
	public override bool MFAECAIDCEL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class LIJNGJIEOCO<TData> : PLJJDOJAABD<DJINOGEAMMM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly IFIFGNAGMEL<TData> AFKMKHPJMDH;

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x3BECCF0", Offset = "0x3BEB6F0", VA = "0x183BECCF0")]
	public LIJNGJIEOCO(TData[] PEPEKFNOBME, KJHDKLAENAK[] GJNHDHNOICC, GOPDAHACAJG[] HEPAJJIBPIF, float[] CEBLOHPIDNG, DJINOGEAMMM<TData> LJKLAGCNGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x35E2130", Offset = "0x35E0B30", VA = "0x1835E2130", Slot = "4")]
	public override bool MFAECAIDCEL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class GOGJDMHPINO<TData> : PLJJDOJAABD<JONDOONDDLO<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x322C220", Offset = "0x322AC20", VA = "0x18322C220")]
	public GOGJDMHPINO(JONDOONDDLO<TData> LJKLAGCNGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x36BC300", Offset = "0x36BAD00", VA = "0x1836BC300", Slot = "4")]
	public override bool MFAECAIDCEL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class FPALMNDBBGK<TData> : PLJJDOJAABD<JONDOONDDLO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly EMOPDNEJJHG<TData> AFKMKHPJMDH;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x35E21F0", Offset = "0x35E0BF0", VA = "0x1835E21F0")]
	public FPALMNDBBGK(IEnumerable<TData> PEPEKFNOBME, KJHDKLAENAK GJNHDHNOICC, GOPDAHACAJG HEPAJJIBPIF, float CEBLOHPIDNG, JONDOONDDLO<TData> LJKLAGCNGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x35E2130", Offset = "0x35E0B30", VA = "0x1835E2130", Slot = "4")]
	public override bool MFAECAIDCEL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct GAEKGKAEIAL<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public IEnumerable<TData> OIDIOANJLDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public KJHDKLAENAK LGOIHHCMPPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public GOPDAHACAJG IMHNEIGMPJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public float CEBLOHPIDNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public bool NELFFOMOLHB;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3690020", Offset = "0x368EA20", VA = "0x183690020")]
	public GAEKGKAEIAL(IEnumerable<TData> PEPEKFNOBME, KJHDKLAENAK GJNHDHNOICC, GOPDAHACAJG HEPAJJIBPIF, float CEBLOHPIDNG, bool NELFFOMOLHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public struct IFIFGNAGMEL<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public TData[] OIDIOANJLDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public KJHDKLAENAK[] LGOIHHCMPPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public GOPDAHACAJG[] IMHNEIGMPJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public float[] CEBLOHPIDNG;

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x382B420", Offset = "0x3829E20", VA = "0x18382B420")]
	public IFIFGNAGMEL(TData[] PEPEKFNOBME, KJHDKLAENAK[] GJNHDHNOICC, GOPDAHACAJG[] HEPAJJIBPIF, float[] CEBLOHPIDNG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public struct EMOPDNEJJHG<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public IEnumerable<TData> OIDIOANJLDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public KJHDKLAENAK LGOIHHCMPPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public GOPDAHACAJG IMHNEIGMPJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public float CEBLOHPIDNG;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x326C8A0", Offset = "0x326B2A0", VA = "0x18326C8A0")]
	public EMOPDNEJJHG(IEnumerable<TData> PEPEKFNOBME, KJHDKLAENAK GJNHDHNOICC, GOPDAHACAJG HEPAJJIBPIF, float CEBLOHPIDNG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface FLBHGDGNKKD<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MMCCEOJKICG([In] FFCCOKBKGIL<TData> MNHHMNHENDM);

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BCBNNPPDIEK([In] FFCCOKBKGIL<TData> MNHHMNHENDM);

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MNJLJCIMOEI([In] bool HCEGPLEAJLD);

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DOPKKNDDCOG([In] FFCCOKBKGIL<TData> MNHHMNHENDM);

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PGLFBCPIDNK();

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool NPFNKOCGDLN([In] TData PEDOONJJANB);
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class GGPDFIFENIH<TData> : PLJJDOJAABD<FLBHGDGNKKD<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly FFCCOKBKGIL<TData> MNHHMNHENDM;

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x36AA230", Offset = "0x36A8C30", VA = "0x1836AA230")]
	public GGPDFIFENIH(List<TData> KGDPBJHHKON, FLBHGDGNKKD<TData> LJKLAGCNGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x3258D10", Offset = "0x3257710", VA = "0x183258D10", Slot = "4")]
	public override bool MFAECAIDCEL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class FJNNGMPKOCB<TData> : PLJJDOJAABD<FLBHGDGNKKD<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x322C220", Offset = "0x322AC20", VA = "0x18322C220")]
	public FJNNGMPKOCB(FLBHGDGNKKD<TData> LJKLAGCNGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x35C3400", Offset = "0x35C1E00", VA = "0x1835C3400", Slot = "4")]
	public override bool MFAECAIDCEL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class NPKDBBJEHKI<TData> : PLJJDOJAABD<FLBHGDGNKKD<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly bool NELFFOMOLHB;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3EBB180", Offset = "0x3EB9B80", VA = "0x183EBB180")]
	public NPKDBBJEHKI(bool NELFFOMOLHB, FLBHGDGNKKD<TData> LJKLAGCNGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x3EBB120", Offset = "0x3EB9B20", VA = "0x183EBB120", Slot = "4")]
	public override bool MFAECAIDCEL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class MPAGAIJKJJM<TData> : PLJJDOJAABD<FLBHGDGNKKD<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly FFCCOKBKGIL<TData> MNHHMNHENDM;

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3DF2100", Offset = "0x3DF0B00", VA = "0x183DF2100")]
	public MPAGAIJKJJM(List<TData> KGDPBJHHKON, bool NELFFOMOLHB, FLBHGDGNKKD<TData> LJKLAGCNGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x369FAE0", Offset = "0x369E4E0", VA = "0x18369FAE0", Slot = "4")]
	public override bool MFAECAIDCEL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class EIMEDHGCJFL<TData> : PLJJDOJAABD<FLBHGDGNKKD<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly TData PEDOONJJANB;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3254000", Offset = "0x3252A00", VA = "0x183254000")]
	public EIMEDHGCJFL(TData PEDOONJJANB, FLBHGDGNKKD<TData> LJKLAGCNGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3253F30", Offset = "0x3252930", VA = "0x183253F30", Slot = "4")]
	public override bool MFAECAIDCEL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class HFGFCAADIBL<TData> : PLJJDOJAABD<FLBHGDGNKKD<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly FFCCOKBKGIL<TData> MNHHMNHENDM;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x36F1050", Offset = "0x36EFA50", VA = "0x1836F1050")]
	public HFGFCAADIBL(IEnumerable<TData> KGDPBJHHKON, FLBHGDGNKKD<TData> LJKLAGCNGHO, bool NELFFOMOLHB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x36F0EE0", Offset = "0x36EF8E0", VA = "0x1836F0EE0", Slot = "4")]
	public override bool MFAECAIDCEL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public struct FFCCOKBKGIL<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public IEnumerable<TData> OIDIOANJLDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public bool NELFFOMOLHB;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x35BE460", Offset = "0x35BCE60", VA = "0x1835BE460")]
	public FFCCOKBKGIL(IEnumerable<TData> LDONDLNCMLE, bool AENCJHMFGNB = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface KCBHHDOIMEP
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<HHHMDNAOPIN> MFAECAIDCEL(EIJLGELEBDC PODKMNKOKAH);
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public class MBBEPHPBJDO : DDNMKBABMEE<KCBHHDOIMEP, HHHMDNAOPIN>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private struct LOKLGAHLOME : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public AsyncTaskMethodBuilder<HHHMDNAOPIN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public MBBEPHPBJDO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private TaskAwaiter<HHHMDNAOPIN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x5FFDD30", Offset = "0x5FFC730", VA = "0x185FFDD30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x5FFDFB0", Offset = "0x5FFC9B0", VA = "0x185FFDFB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly EIJLGELEBDC LMLAECAFJMI;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x5FFE110", Offset = "0x5FFCB10", VA = "0x185FFE110")]
	public MBBEPHPBJDO(bool NELFFOMOLHB, KCBHHDOIMEP LJKLAGCNGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x5FFE020", Offset = "0x5FFCA20", VA = "0x185FFE020", Slot = "4")]
	[AsyncStateMachine(typeof(LOKLGAHLOME))]
	public override Task<HHHMDNAOPIN> MFAECAIDCEL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public struct EIJLGELEBDC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public bool LPHKHNHNGPI;

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0xC1A780", Offset = "0xC19180", VA = "0x180C1A780")]
	public EIJLGELEBDC(bool NELFFOMOLHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public readonly struct KBELCHDAHJC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly bool FFIAKOKJHEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly bool LMGKBMONLGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly bool EFPGCAMCJII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public readonly bool NELFFOMOLHB;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x4578DA0", Offset = "0x45777A0", VA = "0x184578DA0")]
	public KBELCHDAHJC(bool FFIAKOKJHEN, bool LMGKBMONLGJ, bool EFPGCAMCJII, bool NELFFOMOLHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x5FFDC10", Offset = "0x5FFC610", VA = "0x185FFDC10")]
	public KBELCHDAHJC(bool LMGKBMONLGJ, bool NELFFOMOLHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public interface AKHFBFHMIKP
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FDPIBFNFGFA(KBELCHDAHJC DGFOPGNOLNI);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MBLILJDMBDC(KBELCHDAHJC DGFOPGNOLNI);
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class BNCKNBHJDFH : PLJJDOJAABD<AKHFBFHMIKP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly KBELCHDAHJC DGFOPGNOLNI;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x5FFD4E0", Offset = "0x5FFBEE0", VA = "0x185FFD4E0")]
	public BNCKNBHJDFH(bool BDCAJJAMFEO, bool LMGKBMONLGJ, bool EFPGCAMCJII, bool NELFFOMOLHB, AKHFBFHMIKP LJKLAGCNGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x5FFD490", Offset = "0x5FFBE90", VA = "0x185FFD490", Slot = "4")]
	public override bool MFAECAIDCEL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class OADOODGOAAE : PLJJDOJAABD<AKHFBFHMIKP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly KBELCHDAHJC DGFOPGNOLNI;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x5FFE240", Offset = "0x5FFCC40", VA = "0x185FFE240")]
	public OADOODGOAAE(bool LMGKBMONLGJ, bool NELFFOMOLHB, AKHFBFHMIKP LJKLAGCNGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5FFE1F0", Offset = "0x5FFCBF0", VA = "0x185FFE1F0", Slot = "4")]
	public override bool MFAECAIDCEL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public interface FLGICJBDKHE<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EJFLFAIKNHK([In] LKLEPJICFJG<TData> EHICECGANFG);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GIABKPLKGBK([In] COFPBPBDJEE ONEJMNMKAOK);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GIABKPLKGBK([In] EGDHPBPHLEO ONEJMNMKAOK);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool GEBLAAONJDC();
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class HEGHIIBAFHO<TData> : PLJJDOJAABD<FLGICJBDKHE<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x322C220", Offset = "0x322AC20", VA = "0x18322C220")]
	public HEGHIIBAFHO(FLGICJBDKHE<TData> LJKLAGCNGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x36F0960", Offset = "0x36EF360", VA = "0x1836F0960", Slot = "4")]
	public override bool MFAECAIDCEL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class KHFFKFHNHAE<TData> : PLJJDOJAABD<FLGICJBDKHE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly COFPBPBDJEE HOJOLCINMJL;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x3AE1880", Offset = "0x3AE0280", VA = "0x183AE1880")]
	public KHFFKFHNHAE(Vector3 HKOGEAMEPIM, bool PPEJPEFKFPI, FLGICJBDKHE<TData> LJKLAGCNGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x3AE1820", Offset = "0x3AE0220", VA = "0x183AE1820", Slot = "4")]
	public override bool MFAECAIDCEL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class PMPNNJEJAIA<TData> : PLJJDOJAABD<FLGICJBDKHE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly EGDHPBPHLEO HOJOLCINMJL;

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x40A3D60", Offset = "0x40A2760", VA = "0x1840A3D60")]
	public PMPNNJEJAIA(Guid DDNBOBOAPFA, int BNALCEABILL, Vector3 CJONGNPPIAD, Quaternion KPKKBKKOGOG, float HDEDKDLDKGD, bool PPEJPEFKFPI, FLGICJBDKHE<TData> LJKLAGCNGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x40A3D00", Offset = "0x40A2700", VA = "0x1840A3D00", Slot = "4")]
	public override bool MFAECAIDCEL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class PICIKMKCEJD<TData> : PLJJDOJAABD<FLGICJBDKHE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly LKLEPJICFJG<TData> HOJOLCINMJL;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x4096130", Offset = "0x4094B30", VA = "0x184096130")]
	public PICIKMKCEJD(TData DMFBOAFMPLH, bool NELFFOMOLHB, FLGICJBDKHE<TData> LJKLAGCNGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3258D10", Offset = "0x3257710", VA = "0x183258D10", Slot = "4")]
	public override bool MFAECAIDCEL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public struct COFPBPBDJEE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public readonly Vector3 HKOGEAMEPIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public readonly bool PPEJPEFKFPI;

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5FFD570", Offset = "0x5FFBF70", VA = "0x185FFD570")]
	public COFPBPBDJEE(Vector3 HKOGEAMEPIM, bool PPEJPEFKFPI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public struct EGDHPBPHLEO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly Guid DDNBOBOAPFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public readonly int BNALCEABILL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public readonly Vector3 CJONGNPPIAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public readonly Quaternion KPKKBKKOGOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public readonly float HDEDKDLDKGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public readonly bool PPEJPEFKFPI;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5FFD590", Offset = "0x5FFBF90", VA = "0x185FFD590")]
	public EGDHPBPHLEO(Guid DDNBOBOAPFA, int BNALCEABILL, Vector3 CJONGNPPIAD, Quaternion KPKKBKKOGOG, float HDEDKDLDKGD, bool PPEJPEFKFPI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public struct LKLEPJICFJG<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public readonly TData DMFBOAFMPLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public readonly bool NELFFOMOLHB;

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x3BEE710", Offset = "0x3BED110", VA = "0x183BEE710")]
	public LKLEPJICFJG(TData DMFBOAFMPLH, bool NELFFOMOLHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public interface OHFDFIPMEBM<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MFAECAIDCEL([In] GMHHJKBIPAK<TData> ABBNGCMNNDN);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MFAECAIDCEL([In] BIKOFBKIPLM<TData> ABBNGCMNNDN);
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public interface LKMMMMMDFPL<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EJFLFAIKNHK([In] IDNJCKMBHPA<TData> FHELDNGEKAD);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GIABKPLKGBK([In] HEALEGJJDNG ONEJMNMKAOK);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GEBLAAONJDC();
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public class PAADCLOADKE<TData> : PLJJDOJAABD<OHFDFIPMEBM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private readonly GMHHJKBIPAK<TData> ABBNGCMNNDN;

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x4057BF0", Offset = "0x40565F0", VA = "0x184057BF0")]
	public PAADCLOADKE(IEnumerable<TData> PEPEKFNOBME, Vector3 MBDNHLCKEFG, bool NELFFOMOLHB, OHFDFIPMEBM<TData> LJKLAGCNGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x3258D10", Offset = "0x3257710", VA = "0x183258D10", Slot = "4")]
	public override bool MFAECAIDCEL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class HHFDPEJGGJL<TData> : PLJJDOJAABD<LKMMMMMDFPL<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x322C220", Offset = "0x322AC20", VA = "0x18322C220")]
	public HHFDPEJGGJL(LKMMMMMDFPL<TData> LJKLAGCNGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x3736DE0", Offset = "0x37357E0", VA = "0x183736DE0", Slot = "4")]
	public override bool MFAECAIDCEL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class NDDDNMCANAJ<TData> : PLJJDOJAABD<LKMMMMMDFPL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly IDNJCKMBHPA<TData> ABBNGCMNNDN;

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x3E39100", Offset = "0x3E37B00", VA = "0x183E39100")]
	public NDDDNMCANAJ(IEnumerable<TData> PEPEKFNOBME, bool NELFFOMOLHB, LKMMMMMDFPL<TData> LJKLAGCNGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x3258D10", Offset = "0x3257710", VA = "0x183258D10", Slot = "4")]
	public override bool MFAECAIDCEL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class MPKNEBDGAHK<TData> : PLJJDOJAABD<OHFDFIPMEBM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly BIKOFBKIPLM<TData> ABBNGCMNNDN;

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x3DFC080", Offset = "0x3DFAA80", VA = "0x183DFC080")]
	public MPKNEBDGAHK(IEnumerable<TData> PEPEKFNOBME, Vector3 BIJKBNBBDDD, DAJEHNCOBFC LICALHMCBMM, bool NELFFOMOLHB, OHFDFIPMEBM<TData> LJKLAGCNGHO, Space JPILGLDMKBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x322C3D0", Offset = "0x322ADD0", VA = "0x18322C3D0", Slot = "4")]
	public override bool MFAECAIDCEL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class BGPEHLHHJPK<TData> : PLJJDOJAABD<LKMMMMMDFPL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly HEALEGJJDNG ABBNGCMNNDN;

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x47247A0", Offset = "0x47231A0", VA = "0x1847247A0")]
	public BGPEHLHHJPK(Vector3 MBDNHLCKEFG, LKMMMMMDFPL<TData> LJKLAGCNGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x3AE1820", Offset = "0x3AE0220", VA = "0x183AE1820", Slot = "4")]
	public override bool MFAECAIDCEL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public struct GMHHJKBIPAK<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public readonly IEnumerable<TData> PEPEKFNOBME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public readonly Vector3 MBDNHLCKEFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public readonly bool NELFFOMOLHB;

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x36BA290", Offset = "0x36B8C90", VA = "0x1836BA290")]
	public GMHHJKBIPAK(IEnumerable<TData> PEPEKFNOBME, Vector3 MBDNHLCKEFG, bool NELFFOMOLHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct IDNJCKMBHPA<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public readonly IEnumerable<TData> PEPEKFNOBME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public readonly bool NELFFOMOLHB;

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x381EC50", Offset = "0x381D650", VA = "0x18381EC50")]
	public IDNJCKMBHPA(IEnumerable<TData> PEPEKFNOBME, bool NELFFOMOLHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct BIKOFBKIPLM<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public readonly IEnumerable<TData> PEPEKFNOBME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public readonly Vector3 BIJKBNBBDDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public readonly DAJEHNCOBFC LICALHMCBMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public readonly bool NELFFOMOLHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly Space JPILGLDMKBK;

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x47FBFC0", Offset = "0x47FA9C0", VA = "0x1847FBFC0")]
	public BIKOFBKIPLM(IEnumerable<TData> PEPEKFNOBME, Vector3 BIJKBNBBDDD, DAJEHNCOBFC LICALHMCBMM, bool NELFFOMOLHB, Space JPILGLDMKBK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct HEALEGJJDNG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public readonly Vector3 MBDNHLCKEFG;

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x2108E50", Offset = "0x2107850", VA = "0x182108E50")]
	public HEALEGJJDNG(Vector3 MBDNHLCKEFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public enum DAJEHNCOBFC
{
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	XYZ,
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	X_only,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	Y_only,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	Z_only
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public interface MCDMIHKBCEK
{
	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MFAECAIDCEL([In] NGLFJEBBNJA KPGBKHAMMLA);
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public class KFNIFCNBJHK : PLJJDOJAABD<MCDMIHKBCEK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly NGLFJEBBNJA KPGBKHAMMLA;

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x5FFDCD0", Offset = "0x5FFC6D0", VA = "0x185FFDCD0")]
	public KFNIFCNBJHK(bool NELFFOMOLHB, MCDMIHKBCEK LJKLAGCNGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x5FFDC20", Offset = "0x5FFC620", VA = "0x185FFDC20", Slot = "4")]
	public override bool MFAECAIDCEL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public readonly struct NGLFJEBBNJA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public readonly bool NELFFOMOLHB;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0xC1A780", Offset = "0xC19180", VA = "0x180C1A780")]
	public NGLFJEBBNJA(bool NELFFOMOLHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public interface JHMLGOKAOID<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MFAECAIDCEL([In] MFPBAIGHLJO<TData> KJJHLHCOMNL);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MFAECAIDCEL([In] AAKKDJDJKPB<TData> KJJHLHCOMNL);
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public interface FNKPAMLBMKC<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EJFLFAIKNHK([In] JIOELAEDAEC<TData> EHICECGANFG);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GIABKPLKGBK([In] DNMAPINNOFG ONEJMNMKAOK);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GEBLAAONJDC();
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public class MOPEDOPJHKN<TData> : PLJJDOJAABD<JHMLGOKAOID<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly MFPBAIGHLJO<TData> KJJHLHCOMNL;

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x3DF1F70", Offset = "0x3DF0970", VA = "0x183DF1F70")]
	public MOPEDOPJHKN(IEnumerable<TData> PEPEKFNOBME, Quaternion MBDNHLCKEFG, Vector3? NKKEDJDLHBM, bool HMNLIKOCEJN, bool NELFFOMOLHB, JHMLGOKAOID<TData> LJKLAGCNGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x3258D10", Offset = "0x3257710", VA = "0x183258D10", Slot = "4")]
	public override bool MFAECAIDCEL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class OABOJIFNIDD<TData> : PLJJDOJAABD<FNKPAMLBMKC<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x322C220", Offset = "0x322AC20", VA = "0x18322C220")]
	public OABOJIFNIDD(FNKPAMLBMKC<TData> LJKLAGCNGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x3736DE0", Offset = "0x37357E0", VA = "0x183736DE0", Slot = "4")]
	public override bool MFAECAIDCEL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class LGGEOMNFIMJ<TData> : PLJJDOJAABD<FNKPAMLBMKC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly JIOELAEDAEC<TData> KJJHLHCOMNL;

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x3BCCC60", Offset = "0x3BCB660", VA = "0x183BCCC60")]
	public LGGEOMNFIMJ(IEnumerable<TData> PEPEKFNOBME, bool NELFFOMOLHB, FNKPAMLBMKC<TData> LJKLAGCNGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x3258D10", Offset = "0x3257710", VA = "0x183258D10", Slot = "4")]
	public override bool MFAECAIDCEL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class NHIJLEALEHI<TData> : PLJJDOJAABD<JHMLGOKAOID<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly AAKKDJDJKPB<TData> KJJHLHCOMNL;

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x3E5A610", Offset = "0x3E59010", VA = "0x183E5A610")]
	public NHIJLEALEHI(IEnumerable<TData> PEPEKFNOBME, Quaternion NBNHHGOKGHE, DAJEHNCOBFC BNFHIBLGAME, Vector3? NKKEDJDLHBM, bool HMNLIKOCEJN, bool NELFFOMOLHB, Space JPILGLDMKBK, JHMLGOKAOID<TData> LJKLAGCNGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x322C3D0", Offset = "0x322ADD0", VA = "0x18322C3D0", Slot = "4")]
	public override bool MFAECAIDCEL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class LGMMNGIBKHN<TData> : PLJJDOJAABD<FNKPAMLBMKC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly DNMAPINNOFG KJJHLHCOMNL;

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x3BD1750", Offset = "0x3BD0150", VA = "0x183BD1750")]
	public LGMMNGIBKHN(Quaternion MBDNHLCKEFG, Vector3? NKKEDJDLHBM, bool HMNLIKOCEJN, FNKPAMLBMKC<TData> LJKLAGCNGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x3AE1820", Offset = "0x3AE0220", VA = "0x183AE1820", Slot = "4")]
	public override bool MFAECAIDCEL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public struct MFPBAIGHLJO<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public readonly IEnumerable<TData> PEPEKFNOBME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public readonly Quaternion MBDNHLCKEFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public readonly Vector3? NKKEDJDLHBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public readonly bool HMNLIKOCEJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public readonly bool NELFFOMOLHB;

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x3DD6910", Offset = "0x3DD5310", VA = "0x183DD6910")]
	public MFPBAIGHLJO(IEnumerable<TData> PEPEKFNOBME, Quaternion MBDNHLCKEFG, Vector3? NKKEDJDLHBM, bool HMNLIKOCEJN, bool NELFFOMOLHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public struct JIOELAEDAEC<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public readonly IEnumerable<TData> PEPEKFNOBME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public readonly bool NELFFOMOLHB;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x3A2F340", Offset = "0x3A2DD40", VA = "0x183A2F340")]
	public JIOELAEDAEC(IEnumerable<TData> PEPEKFNOBME, bool NELFFOMOLHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public struct AAKKDJDJKPB<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public readonly IEnumerable<TData> PEPEKFNOBME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly Quaternion NBNHHGOKGHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public readonly DAJEHNCOBFC BNFHIBLGAME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public readonly Vector3? NKKEDJDLHBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public readonly bool HMNLIKOCEJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public readonly bool NELFFOMOLHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public readonly Space JPILGLDMKBK;

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x3641660", Offset = "0x3640060", VA = "0x183641660")]
	public AAKKDJDJKPB(IEnumerable<TData> PEPEKFNOBME, Quaternion NBNHHGOKGHE, DAJEHNCOBFC BNFHIBLGAME, Vector3? NKKEDJDLHBM, bool HMNLIKOCEJN, bool NELFFOMOLHB, Space JPILGLDMKBK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public struct DNMAPINNOFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public readonly Quaternion MBDNHLCKEFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public readonly Vector3? NKKEDJDLHBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public readonly bool HMNLIKOCEJN;

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x4549350", Offset = "0x4547D50", VA = "0x184549350")]
	public DNMAPINNOFG(Quaternion MBDNHLCKEFG, Vector3? NKKEDJDLHBM, bool HMNLIKOCEJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public interface OGMBIIBHJHM<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EJFLFAIKNHK([In] PPCHPHCHLOH<TData> EHICECGANFG);

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GIABKPLKGBK([In] CLLFOGOHDHO ONEJMNMKAOK);

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GIABKPLKGBK([In] APBFLMLENOD ONEJMNMKAOK);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool GIABKPLKGBK([In] GMCLKELIJMN ONEJMNMKAOK);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool GEBLAAONJDC();
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public class FMINJPGNDIP<TData> : PLJJDOJAABD<OGMBIIBHJHM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly GMCLKELIJMN DNLCGGGCONC;

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x35D49E0", Offset = "0x35D33E0", VA = "0x1835D49E0")]
	public FMINJPGNDIP(Vector3 PPKPHAAPGJD, float LNNEBGNNLBM, Vector3 NKKEDJDLHBM, bool KFJEBEDIGGM, bool GIFOKAKEIKD, OGMBIIBHJHM<TData> LJKLAGCNGHO, Space JPILGLDMKBK = Space.Self)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x35D4980", Offset = "0x35D3380", VA = "0x1835D4980", Slot = "4")]
	public override bool MFAECAIDCEL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public class HPEPCJHCMDI<TData> : PLJJDOJAABD<OGMBIIBHJHM<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x322C220", Offset = "0x322AC20", VA = "0x18322C220")]
	public HPEPCJHCMDI(OGMBIIBHJHM<TData> LJKLAGCNGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x3794060", Offset = "0x3792A60", VA = "0x183794060", Slot = "4")]
	public override bool MFAECAIDCEL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public class AHLBLEMPAEF<TData> : PLJJDOJAABD<OGMBIIBHJHM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly PPCHPHCHLOH<TData> DNLCGGGCONC;

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x3677E80", Offset = "0x3676880", VA = "0x183677E80")]
	public AHLBLEMPAEF(IEnumerable<TData> PEPEKFNOBME, bool NELFFOMOLHB, OGMBIIBHJHM<TData> LJKLAGCNGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x3258D10", Offset = "0x3257710", VA = "0x183258D10", Slot = "4")]
	public override bool MFAECAIDCEL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class PGNIEJOMLID<TData> : PLJJDOJAABD<OGMBIIBHJHM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly APBFLMLENOD DNLCGGGCONC;

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x4093D00", Offset = "0x4092700", VA = "0x184093D00")]
	public PGNIEJOMLID(float NBKGOBGCMFH, bool BFCKEDOAMFE, Vector3 NKKEDJDLHBM, OGMBIIBHJHM<TData> LJKLAGCNGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x4093C30", Offset = "0x4092630", VA = "0x184093C30", Slot = "4")]
	public override bool MFAECAIDCEL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class KPCAPIDPMLO<TData> : PLJJDOJAABD<OGMBIIBHJHM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly CLLFOGOHDHO DNLCGGGCONC;

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x3B47330", Offset = "0x3B45D30", VA = "0x183B47330")]
	public KPCAPIDPMLO(float LNNEBGNNLBM, Vector3 NKKEDJDLHBM, OGMBIIBHJHM<TData> LJKLAGCNGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x3AE1820", Offset = "0x3AE0220", VA = "0x183AE1820", Slot = "4")]
	public override bool MFAECAIDCEL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public struct GMCLKELIJMN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public readonly Vector3 PPKPHAAPGJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public readonly float LNNEBGNNLBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public readonly Vector3 NKKEDJDLHBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public readonly bool PPEJPEFKFPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public readonly Space JPILGLDMKBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public readonly bool GIFOKAKEIKD;

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x5FFD9A0", Offset = "0x5FFC3A0", VA = "0x185FFD9A0")]
	public GMCLKELIJMN(Vector3 PPKPHAAPGJD, float LNNEBGNNLBM, Vector3 NKKEDJDLHBM, bool PPEJPEFKFPI, bool LHKDHDLOEGF, Space JPILGLDMKBK = Space.Self)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public struct PPCHPHCHLOH<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public readonly IEnumerable<TData> PEPEKFNOBME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public readonly bool NELFFOMOLHB;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x40A8A20", Offset = "0x40A7420", VA = "0x1840A8A20")]
	public PPCHPHCHLOH(IEnumerable<TData> PEPEKFNOBME, bool NELFFOMOLHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public struct APBFLMLENOD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public readonly float NBKGOBGCMFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public readonly bool BFCKEDOAMFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public readonly Vector3 NKKEDJDLHBM;

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x5FFD470", Offset = "0x5FFBE70", VA = "0x185FFD470")]
	public APBFLMLENOD(float NBKGOBGCMFH, bool BFCKEDOAMFE, Vector3 NKKEDJDLHBM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct CLLFOGOHDHO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public readonly float LNNEBGNNLBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public readonly Vector3 NKKEDJDLHBM;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x4525C00", Offset = "0x4524600", VA = "0x184525C00")]
	public CLLFOGOHDHO(float LNNEBGNNLBM, Vector3 NKKEDJDLHBM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public static class FANBNBCHFJA
{
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	private struct PJOFNLGBLPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public bool MONEJNGEDEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public AFDLAPABCDH PBBJDBKCNMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public AFDLAPABCDH JAOHAEALPIB;
	}

	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private static PJOFNLGBLPH EMGMKIIHKAN;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static CancellationToken EMDMFNPCAIK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x5FFD980", Offset = "0x5FFC380", VA = "0x185FFD980")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	internal static AFDLAPABCDH PBBJDBKCNMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x5FFD640", Offset = "0x5FFC040", VA = "0x185FFD640")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x5FFD5D0", Offset = "0x5FFBFD0", VA = "0x185FFD5D0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x5FFD830", Offset = "0x5FFC230", VA = "0x185FFD830")]
	[BBBFDPEBAMC(JFAJKKONDHJ.Room, HLEKCCEDPHP.None)]
	private static void JIGGKFLPKDA(AFDLAPABCDH LLOLLHNPGBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x5FFD6E0", Offset = "0x5FFC0E0", VA = "0x185FFD6E0")]
	public static void JGPBMMKLMDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x5FFD930", Offset = "0x5FFC330", VA = "0x185FFD930")]
	private static AFDLAPABCDH LODJJCFFIHE(AFDLAPABCDH JMMFFGICJCF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public static class JKBJOGJIOMI
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public enum MKAENGIAELA
	{
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		ICreationContextObject,
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		Guid
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x267AC60", Offset = "0x2679660", VA = "0x18267AC60")]
	public static void CFBKKMKKHIE<T>(T BDFKMGIHPBP, MKAENGIAELA AKDFFJNHJJN) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x267ADA0", Offset = "0x26797A0", VA = "0x18267ADA0")]
	public static void CFBKKMKKHIE<T>(T BDFKMGIHPBP) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x267AEA0", Offset = "0x26798A0", VA = "0x18267AEA0")]
	public static void IHFLNNIIDHC<T>(T BDFKMGIHPBP) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x267AE00", Offset = "0x2679800", VA = "0x18267AE00")]
	public static T DKMKPEOPLDE<T>(MKAENGIAELA AKDFFJNHJJN) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x267AF10", Offset = "0x2679910", VA = "0x18267AF10")]
	public static bool PPEMIFBBDMG<T>(MKAENGIAELA AKDFFJNHJJN, T IAMPPMBDPPB, [Out] T GBBDLNOJPBN) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x267ABC0", Offset = "0x26795C0", VA = "0x18267ABC0")]
	public static bool AJOAJNNLONH<T>(MKAENGIAELA AKDFFJNHJJN) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x267AB80", Offset = "0x2679580", VA = "0x18267AB80")]
	public static T DKMKPEOPLDE<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x267AB80", Offset = "0x2679580", VA = "0x18267AB80")]
	public static bool AJOAJNNLONH<T>() where T : class
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
internal static class HDAHHCIEDGM
{
	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x5FFD9E0", Offset = "0x5FFC3E0", VA = "0x185FFD9E0")]
	public static void LMJFJKOBLAL(IEnumerable GJNCKFFDJHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x2614290", Offset = "0x2612C90", VA = "0x182614290")]
	public static void LMJFJKOBLAL<T>(T[] BHNHFMPCKPL) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x2614470", Offset = "0x2612E70", VA = "0x182614470")]
	public static void LMJFJKOBLAL<T>(T IPDIFFOOAAI) where T : notnull, Enum
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
