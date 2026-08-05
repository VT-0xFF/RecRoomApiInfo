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
		[Cpp2IlInjected.Address(RVA = "0x788D90", Offset = "0x787B90", VA = "0x180788D90")]
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
		[Cpp2IlInjected.Address(RVA = "0x5CAAB60", Offset = "0x5CA9960", VA = "0x185CAAB60")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x789560", Offset = "0x788360", VA = "0x180789560")]
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
		[Cpp2IlInjected.Address(RVA = "0x7895A0", Offset = "0x7883A0", VA = "0x1807895A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface AHANLMINCOP<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ClearHoverTarget(DNGMLDAPJJD AGAPMPJHFJO);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool SetHoverTarget(TData PABBJIBBIGE, Collider AHCMBLCCIKM, DNGMLDAPJJD AGAPMPJHFJO, [Optional] JNCHCNKNJAN? LOBAMKJJLHH);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool TryGetHoverTarget([Out] TData PABBJIBBIGE);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface DDFGANNNHKC<TData> : IDOHMFKJFGI, KLPGCDNIHIM<TData>, DFFHHDPPNCE<TData>, JIOHAKOLEAF<TData>, GGPKPPCCHHH, MJOEIDFLFEB<TData>, HGKJLEHDPFK, LBMONJMBDMJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface MJOEIDFLFEB<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 IEGMKHJBCLL, Vector3 EFMDODKKOAD, float HGECKMNELOA, [Out] T BNIHCAKMCHE, [Out] Vector3 KLOEFMJMFBC, [Out] Collider AHCMBLCCIKM);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 IEGMKHJBCLL, Vector3 EFMDODKKOAD, float CNHEKJHACAH, float HGECKMNELOA, T[] PIBJMIDPEAD, [Out] Vector3 EBFKDBEEFBH, [Out] Collider ENPFGGBCKEI);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 IEGMKHJBCLL, float CNHEKJHACAH, Vector3 IKPLBLEPHJJ, T[] PIBJMIDPEAD);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface IDOHMFKJFGI
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Bounds IPCLNAOLBPP
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Transform ALHPHPNNIOA
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Bounds KFCMELIIIKB
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Transform NFKLMAHCEOP
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Vector3 MCDKIDEJIJM
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void SetSelectionBoundsDirty(bool MNEBJJBPLIF = true, int DFAFMDICNIH = 0);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ShouldHideSelectionBoundsPreview(bool JDPMNHACOAO, object EKDHBKMFLGI);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface LBMONJMBDMJ
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	HJOHDOIHOEL ECILLLMFHAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface JIOHAKOLEAF<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool IMPHAEPBKPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	int OKOOIJELMAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	IEnumerable<TData> PLKJGIPOALA
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData LCDPCJGMPFF);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData LCDPCJGMPFF);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface KLPGCDNIHIM<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T DGPHOMINFCK, [Optional] JNCHCNKNJAN? OBGIGCODDBD, bool MCMHMBGPAKO = true);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int NENAAIFMEME, IEnumerable<T> KEALJPCKHHL, bool MCMHMBGPAKO = true);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int NENAAIFMEME, IEnumerable<T> KEALJPCKHHL, JNCHCNKNJAN OBGIGCODDBD, bool MCMHMBGPAKO = true);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface HGKJLEHDPFK
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface GGPKPPCCHHH
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool HOBMLKLOPHI
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool DLGEJLKPNIM
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool GAJBCGDALDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool DCPBKJLIAEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class LPGKDEDBIGH<TReceiver> : DCPBDPHBKMP<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x303D350", Offset = "0x303C150", VA = "0x18303D350")]
	public LPGKDEDBIGH(TReceiver ELGGIPNHKGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public abstract class PJKCMLDHHHF<TReceiver, TFromTask> : DCPBDPHBKMP<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x303D350", Offset = "0x303C150", VA = "0x18303D350")]
	public PJKCMLDHHHF(TReceiver ELGGIPNHKGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class DCPBDPHBKMP<TReceiver, TFromExecute> where TReceiver : notnull where TFromExecute : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	protected TReceiver ELGGIPNHKGA;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4C47A20", Offset = "0x4C46820", VA = "0x184C47A20")]
	public DCPBDPHBKMP(TReceiver ELGGIPNHKGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute PKCLAOPMEIK();
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class JJCFLJODKMH<TReceiver, TResult> : DCPBDPHBKMP<TReceiver, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x303D350", Offset = "0x303C150", VA = "0x18303D350")]
	public JJCFLJODKMH(TReceiver ELGGIPNHKGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct OEKALAHGKAF<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public TGroup CENGHCMJJOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public TData EBKANCBPBIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public IEnumerable<TData> GJMJPCJAOOE;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x18E5E20", Offset = "0x18E4C20", VA = "0x1818E5E20")]
	public OEKALAHGKAF(TGroup AOHMIKCOBLJ, TData EICOIADOGOI, IEnumerable<TData> CIADNPCNFAC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct IHLEOGIHEPJ<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public TGroup CENGHCMJJOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public IEnumerable<TData> GJMJPCJAOOE;

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7E8680", Offset = "0x7E7480", VA = "0x1807E8680")]
	public IHLEOGIHEPJ(TGroup AOHMIKCOBLJ, IEnumerable<TData> CIADNPCNFAC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct NJJEJLGNAKN<TGroup> where TGroup : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public TGroup CENGHCMJJOJ;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7EB650", Offset = "0x7EA450", VA = "0x1807EB650")]
	public NJJEJLGNAKN(TGroup AOHMIKCOBLJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct KMJOCLAMODA<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public IEnumerable<TData> GJMJPCJAOOE;

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7EB650", Offset = "0x7EA450", VA = "0x1807EB650")]
	public KMJOCLAMODA(IEnumerable<TData> CIADNPCNFAC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface NIOLFJLFPPK<TGroup, TData>
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ABLFIOHECPN MCPNDMDACPB(OEKALAHGKAF<TGroup, TData> OAFJHONBKLG);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ABLFIOHECPN OBMEGIJICEN(OEKALAHGKAF<TGroup, TData> OAFJHONBKLG);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ABLFIOHECPN DGBJLJELEOL(IHLEOGIHEPJ<TGroup, TData> OAFJHONBKLG);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	ABLFIOHECPN LEPOBOCJKNF(NJJEJLGNAKN<TGroup> OAFJHONBKLG);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface NKDIIKEGDCG<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<ABLFIOHECPN> MCPNDMDACPB(KMJOCLAMODA<TData> OAFJHONBKLG);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class DEJDMBKGPOF<TGroup, TData> : JJCFLJODKMH<NIOLFJLFPPK<TGroup, TData>, ABLFIOHECPN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly IHLEOGIHEPJ<TGroup, TData> OAFJHONBKLG;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4C4FBA0", Offset = "0x4C4E9A0", VA = "0x184C4FBA0")]
	public DEJDMBKGPOF(TGroup AOHMIKCOBLJ, IEnumerable<TData> CIADNPCNFAC, NIOLFJLFPPK<TGroup, TData> ELGGIPNHKGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4C4FAD0", Offset = "0x4C4E8D0", VA = "0x184C4FAD0", Slot = "4")]
	public override ABLFIOHECPN PKCLAOPMEIK()
	{
		return default(ABLFIOHECPN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class DPIHNIFELNF<TGroup, TData> : JJCFLJODKMH<NIOLFJLFPPK<TGroup, TData>, ABLFIOHECPN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly OEKALAHGKAF<TGroup, TData> OAFJHONBKLG;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3994E80", Offset = "0x3993C80", VA = "0x183994E80")]
	public DPIHNIFELNF(TGroup AOHMIKCOBLJ, TData KPJBAELHFEI, IEnumerable<TData> CIADNPCNFAC, NIOLFJLFPPK<TGroup, TData> ELGGIPNHKGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x4C9C730", Offset = "0x4C9B530", VA = "0x184C9C730", Slot = "4")]
	public override ABLFIOHECPN PKCLAOPMEIK()
	{
		return default(ABLFIOHECPN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class HLBCBBNAPPF<TGroup, TData> : JJCFLJODKMH<NIOLFJLFPPK<TGroup, TData>, ABLFIOHECPN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly NJJEJLGNAKN<TGroup> OAFJHONBKLG;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3479000", Offset = "0x3477E00", VA = "0x183479000")]
	public HLBCBBNAPPF(TGroup AOHMIKCOBLJ, NIOLFJLFPPK<TGroup, TData> ELGGIPNHKGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x35E8770", Offset = "0x35E7570", VA = "0x1835E8770", Slot = "4")]
	public override ABLFIOHECPN PKCLAOPMEIK()
	{
		return default(ABLFIOHECPN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class LMMBLGEHEGO<TGroup, TData> : JJCFLJODKMH<NIOLFJLFPPK<TGroup, TData>, ABLFIOHECPN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly OEKALAHGKAF<TGroup, TData> OAFJHONBKLG;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3994E80", Offset = "0x3993C80", VA = "0x183994E80")]
	public LMMBLGEHEGO(TGroup AOHMIKCOBLJ, TData EICOIADOGOI, IEnumerable<TData> CIADNPCNFAC, NIOLFJLFPPK<TGroup, TData> ELGGIPNHKGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3994DA0", Offset = "0x3993BA0", VA = "0x183994DA0", Slot = "4")]
	public override ABLFIOHECPN PKCLAOPMEIK()
	{
		return default(ABLFIOHECPN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class GALIFMLPKDM<TData> : PJKCMLDHHHF<NKDIIKEGDCG<TData>, ABLFIOHECPN> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct BJEJGJHLIMA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AsyncTaskMethodBuilder<ABLFIOHECPN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public GALIFMLPKDM<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private TaskAwaiter<ABLFIOHECPN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x4494CA0", Offset = "0x4493AA0", VA = "0x184494CA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x4494F40", Offset = "0x4493D40", VA = "0x184494F40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private KMJOCLAMODA<TData> OAFJHONBKLG;

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3479000", Offset = "0x3477E00", VA = "0x183479000")]
	public GALIFMLPKDM(IEnumerable<TData> NPLGJFGPGKI, NKDIIKEGDCG<TData> ELGGIPNHKGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3478F00", Offset = "0x3477D00", VA = "0x183478F00", Slot = "4")]
	[AsyncStateMachine(typeof(GALIFMLPKDM<>.BJEJGJHLIMA))]
	public override Task<ABLFIOHECPN> PKCLAOPMEIK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct LEGGIPKGJOO<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public TNode GFKHIMDMJHK;

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x397A9F0", Offset = "0x39797F0", VA = "0x18397A9F0")]
	public LEGGIPKGJOO(TNode GFKHIMDMJHK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct DKLPPHGFJBE<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public TNode DBKEFMCMDCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public AMPPFGDODDJ FNOPJJHGGBK;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4C83290", Offset = "0x4C82090", VA = "0x184C83290")]
	public DKLPPHGFJBE(TNode DBKEFMCMDCP, AMPPFGDODDJ FNOPJJHGGBK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface OGEBGIKDKOC<TNode>
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LFOPGGPPAFB([In] LEGGIPKGJOO<TNode> PIJFIEABAOB);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HAIIJKHMOJG([In] DKLPPHGFJBE<TNode> KFBAFFECHIF);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HDMIKPNCGFI();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class HOCOFPIMLIN<TNode> : LPGKDEDBIGH<OGEBGIKDKOC<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x303D350", Offset = "0x303C150", VA = "0x18303D350")]
	public HOCOFPIMLIN(OGEBGIKDKOC<TNode> ELGGIPNHKGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x35EC170", Offset = "0x35EAF70", VA = "0x1835EC170", Slot = "4")]
	public override bool PKCLAOPMEIK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class OANIPMKPPGC<TNode> : LPGKDEDBIGH<OGEBGIKDKOC<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly DKLPPHGFJBE<TNode> KFBAFFECHIF;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3CC3180", Offset = "0x3CC1F80", VA = "0x183CC3180")]
	public OANIPMKPPGC(TNode DBKEFMCMDCP, AMPPFGDODDJ FNOPJJHGGBK, OGEBGIKDKOC<TNode> ELGGIPNHKGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3B63C60", Offset = "0x3B62A60", VA = "0x183B63C60", Slot = "4")]
	public override bool PKCLAOPMEIK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class NHFMNOKCBCP<TNode> : LPGKDEDBIGH<OGEBGIKDKOC<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly LEGGIPKGJOO<TNode> PIJFIEABAOB;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3BE8060", Offset = "0x3BE6E60", VA = "0x183BE8060")]
	public NHFMNOKCBCP(TNode CHLDGMGGBIJ, OGEBGIKDKOC<TNode> ELGGIPNHKGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3382EC0", Offset = "0x3381CC0", VA = "0x183382EC0", Slot = "4")]
	public override bool PKCLAOPMEIK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct LFEAGMIAKMM<TSpawnInfo> where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public TSpawnInfo KKGKKNPJCBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public Vector3 CMKBDFOJBFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public Quaternion ALADLBOMNEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public float KLPLLOPDNNO;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0xD6CA10", Offset = "0xD6B810", VA = "0x180D6CA10")]
	public LFEAGMIAKMM(TSpawnInfo KKGKKNPJCBC, Vector3 CMKBDFOJBFE, Quaternion ALADLBOMNEP, float KLPLLOPDNNO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface MCFOOGIFLEH<TSpawnType, TSpawnInfo>
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> CIDAFODEPPF([In] LFEAGMIAKMM<TSpawnInfo> PGNBMJKKEIB, CancellationToken BCCDJHNACKO);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class BHDIFKHNNPJ<TSpawnType, TSpawnInfo> : PJKCMLDHHHF<MCFOOGIFLEH<TSpawnType, TSpawnInfo>, TSpawnType> where TSpawnType : notnull where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly LFEAGMIAKMM<TSpawnInfo> MEALCFKPKME;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x4494090", Offset = "0x4492E90", VA = "0x184494090")]
	public BHDIFKHNNPJ(TSpawnInfo JCLLHBHIFLM, Vector3 CMKBDFOJBFE, Quaternion ALADLBOMNEP, float KLPLLOPDNNO, MCFOOGIFLEH<TSpawnType, TSpawnInfo> ELGGIPNHKGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x34A7E10", Offset = "0x34A6C10", VA = "0x1834A7E10", Slot = "4")]
	public override Task<TSpawnType> PKCLAOPMEIK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public readonly struct KJEMEGKGGBD<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly IEnumerable<TData> GJMJPCJAOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly bool ALJNEMCFFNF;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x38C27A0", Offset = "0x38C15A0", VA = "0x1838C27A0")]
	public KJEMEGKGGBD(IEnumerable<TData> CIADNPCNFAC, bool ODACDEHJFCB = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface HEJAFKEBBBF<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<ABLFIOHECPN> IANHFKEKBMD([In] KJEMEGKGGBD<TData> JFBDCIEFOKF, CancellationToken BCCDJHNACKO);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class AHBIINBJHOG<TData> : PJKCMLDHHHF<HEJAFKEBBBF<TData>, ABLFIOHECPN> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly KJEMEGKGGBD<TData> OPELCPOBFEI;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x34A7F80", Offset = "0x34A6D80", VA = "0x1834A7F80")]
	public AHBIINBJHOG(IEnumerable<TData> CIADNPCNFAC, bool ODACDEHJFCB, HEJAFKEBBBF<TData> ELGGIPNHKGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x34A7E10", Offset = "0x34A6C10", VA = "0x1834A7E10", Slot = "4")]
	public override Task<ABLFIOHECPN> PKCLAOPMEIK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct IMCALGHPNJJ<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly T PABBJIBBIGE;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x36A4FB0", Offset = "0x36A3DB0", VA = "0x1836A4FB0")]
	public IMCALGHPNJJ(T MAEJOBFMMEE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface BABCGNAMIDO<T>
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LFOPGGPPAFB([In] IMCALGHPNJJ<T> OJODLMJHFKD);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HAIIJKHMOJG();
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface EIDPDFCDHLH<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PKCLAOPMEIK([In] GCIFOEEKAMF<T> JBFNMEFDHJF);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public struct GCIFOEEKAMF<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly T PABBJIBBIGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly bool LDLOOLANAAD;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x347C2B0", Offset = "0x347B0B0", VA = "0x18347C2B0")]
	public GCIFOEEKAMF(T MAEJOBFMMEE, bool PAJJGMJNDJB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class OJCPGADBKPA<T> : LPGKDEDBIGH<BABCGNAMIDO<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x303D350", Offset = "0x303C150", VA = "0x18303D350")]
	public OJCPGADBKPA(BABCGNAMIDO<T> ELGGIPNHKGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3BC4820", Offset = "0x3BC3620", VA = "0x183BC4820", Slot = "4")]
	public override bool PKCLAOPMEIK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class AMIEPONLMLB<T> : LPGKDEDBIGH<BABCGNAMIDO<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly IMCALGHPNJJ<T> OJODLMJHFKD;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x34BC530", Offset = "0x34BB330", VA = "0x1834BC530")]
	public AMIEPONLMLB(T PABBJIBBIGE, BABCGNAMIDO<T> ELGGIPNHKGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3382EC0", Offset = "0x3381CC0", VA = "0x183382EC0", Slot = "4")]
	public override bool PKCLAOPMEIK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class BCKEODAJEPM<T> : LPGKDEDBIGH<EIDPDFCDHLH<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly GCIFOEEKAMF<T> JBFNMEFDHJF;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x4431A00", Offset = "0x4430800", VA = "0x184431A00")]
	public BCKEODAJEPM(T PABBJIBBIGE, bool PAJJGMJNDJB, EIDPDFCDHLH<T> ELGGIPNHKGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3382EC0", Offset = "0x3381CC0", VA = "0x183382EC0", Slot = "4")]
	public override bool PKCLAOPMEIK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct HBAIAHFHMOK<TData> where TData : notnull, BCOKDEDMOCH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public IEnumerable<TData> GJMJPCJAOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public bool BGJDHBGKFML;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x35A9510", Offset = "0x35A8310", VA = "0x1835A9510")]
	public HBAIAHFHMOK(IEnumerable<TData> INPPCHNKBEG, bool OGCIMBGCBJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct AJAJGHNCKOJ<TData> where TData : notnull, BCOKDEDMOCH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public List<TData> GJMJPCJAOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public List<bool> LDMOEJCBOHG;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x34AB190", Offset = "0x34A9F90", VA = "0x1834AB190")]
	public AJAJGHNCKOJ(List<TData> INPPCHNKBEG, List<bool> LFCOEEIBKIL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface BCOKDEDMOCH
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool MGJMHDKLKMJ
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
public interface OJDMFLNDCBH<TData> where TData : BCOKDEDMOCH
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PKCLAOPMEIK([In] HBAIAHFHMOK<TData> DCGJCMJHDKG);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PKCLAOPMEIK([In] AJAJGHNCKOJ<TData> DCGJCMJHDKG);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class BGCNNFJBLMI<TData> : LPGKDEDBIGH<OJDMFLNDCBH<TData>> where TData : notnull, BCOKDEDMOCH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly HBAIAHFHMOK<TData> DCGJCMJHDKG;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x4491620", Offset = "0x4490420", VA = "0x184491620")]
	public BGCNNFJBLMI(List<TData> CIADNPCNFAC, bool BGJDHBGKFML, OJDMFLNDCBH<TData> ELGGIPNHKGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3382EC0", Offset = "0x3381CC0", VA = "0x183382EC0", Slot = "4")]
	public override bool PKCLAOPMEIK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class DAFIGCMNDIE<TData> : LPGKDEDBIGH<OJDMFLNDCBH<TData>> where TData : notnull, BCOKDEDMOCH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly AJAJGHNCKOJ<TData> DCGJCMJHDKG;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x4C40960", Offset = "0x4C3F760", VA = "0x184C40960")]
	public DAFIGCMNDIE(List<TData> CIADNPCNFAC, List<bool> LDMOEJCBOHG, OJDMFLNDCBH<TData> ELGGIPNHKGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x3CC2FA0", Offset = "0x3CC1DA0", VA = "0x183CC2FA0", Slot = "4")]
	public override bool PKCLAOPMEIK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface NMAPJEKGOEH : BCOKDEDMOCH
{
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface OBOIBLGELMI<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<ABLFIOHECPN> PKCLAOPMEIK(ELJANLEEOIE<TData> DHDGNMGKPAG);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class KAMLHEFFILF<TData> : PJKCMLDHHHF<OBOIBLGELMI<TData>, ABLFIOHECPN> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct FPFBBKBEEPC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public AsyncTaskMethodBuilder<ABLFIOHECPN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public KAMLHEFFILF<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private TaskAwaiter<ABLFIOHECPN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x33D83D0", Offset = "0x33D71D0", VA = "0x1833D83D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x33D86C0", Offset = "0x33D74C0", VA = "0x1833D86C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly ELJANLEEOIE<TData> HLNMHFKLDJI;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x388FEC0", Offset = "0x388ECC0", VA = "0x18388FEC0")]
	public KAMLHEFFILF(TData IDCKLOLDJMG, IReadOnlyList<TData> CCOFONBAKHC, bool ODACDEHJFCB, OBOIBLGELMI<TData> ELGGIPNHKGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x388FDC0", Offset = "0x388EBC0", VA = "0x18388FDC0", Slot = "4")]
	[AsyncStateMachine(typeof(KAMLHEFFILF<>.FPFBBKBEEPC))]
	public override Task<ABLFIOHECPN> PKCLAOPMEIK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public struct ELJANLEEOIE<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public TData KFFEEEPCJLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public IReadOnlyList<TData> BMNFJMJDLCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public bool ALJNEMCFFNF;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x3045490", Offset = "0x3044290", VA = "0x183045490")]
	public ELJANLEEOIE(TData IDCKLOLDJMG, IReadOnlyList<TData> CCOFONBAKHC, bool ODACDEHJFCB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface LFIIELCDJBJ<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PKCLAOPMEIK([In] DCMKIGHDGJN<TData> NKPGJKMJHOE);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface KFFEBAFGEGA<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PKCLAOPMEIK([In] CJILNCENBLG<TData> NKPGJKMJHOE);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface KAJHMAGILGF<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HIKDKFFIPPB([In] KCIIHLBLGKA<TData> NKPGJKMJHOE);

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HAIIJKHMOJG();
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class CEGIKPDOPGP<TData> : LPGKDEDBIGH<LFIIELCDJBJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly DCMKIGHDGJN<TData> NKPGJKMJHOE;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4781D20", Offset = "0x4780B20", VA = "0x184781D20")]
	public CEGIKPDOPGP(IEnumerable<TData> CIADNPCNFAC, EOPEADBJLDL CEPDKAIKDOH, GPGAJMFGKJB PMPKGHHPFNJ, float NCDIDBGNDBD, bool ODACDEHJFCB, LFIIELCDJBJ<TData> ELGGIPNHKGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x3382EC0", Offset = "0x3381CC0", VA = "0x183382EC0", Slot = "4")]
	public override bool PKCLAOPMEIK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public class BCEHJBKJEDA<TData> : LPGKDEDBIGH<KFFEBAFGEGA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly CJILNCENBLG<TData> NKPGJKMJHOE;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x4431930", Offset = "0x4430730", VA = "0x184431930")]
	public BCEHJBKJEDA(TData[] CIADNPCNFAC, EOPEADBJLDL[] CEPDKAIKDOH, GPGAJMFGKJB[] PMPKGHHPFNJ, float[] NCDIDBGNDBD, KFFEBAFGEGA<TData> ELGGIPNHKGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x3DE5370", Offset = "0x3DE4170", VA = "0x183DE5370", Slot = "4")]
	public override bool PKCLAOPMEIK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class GFMGPICEFIL<TData> : LPGKDEDBIGH<KAJHMAGILGF<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x303D350", Offset = "0x303C150", VA = "0x18303D350")]
	public GFMGPICEFIL(KAJHMAGILGF<TData> ELGGIPNHKGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x348C870", Offset = "0x348B670", VA = "0x18348C870", Slot = "4")]
	public override bool PKCLAOPMEIK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class POCABDPDHON<TData> : LPGKDEDBIGH<KAJHMAGILGF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly KCIIHLBLGKA<TData> NKPGJKMJHOE;

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x3DE5430", Offset = "0x3DE4230", VA = "0x183DE5430")]
	public POCABDPDHON(IEnumerable<TData> CIADNPCNFAC, EOPEADBJLDL CEPDKAIKDOH, GPGAJMFGKJB PMPKGHHPFNJ, float NCDIDBGNDBD, KAJHMAGILGF<TData> ELGGIPNHKGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x3DE5370", Offset = "0x3DE4170", VA = "0x183DE5370", Slot = "4")]
	public override bool PKCLAOPMEIK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public struct DCMKIGHDGJN<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public IEnumerable<TData> GJMJPCJAOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public EOPEADBJLDL OJAODFKIAIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public GPGAJMFGKJB OAPOMEHPDKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public float NCDIDBGNDBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public bool ODACDEHJFCB;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x4C44150", Offset = "0x4C42F50", VA = "0x184C44150")]
	public DCMKIGHDGJN(IEnumerable<TData> CIADNPCNFAC, EOPEADBJLDL CEPDKAIKDOH, GPGAJMFGKJB PMPKGHHPFNJ, float NCDIDBGNDBD, bool ODACDEHJFCB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public struct CJILNCENBLG<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public TData[] GJMJPCJAOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public EOPEADBJLDL[] OJAODFKIAIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public GPGAJMFGKJB[] OAPOMEHPDKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public float[] NCDIDBGNDBD;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x49549A0", Offset = "0x49537A0", VA = "0x1849549A0")]
	public CJILNCENBLG(TData[] CIADNPCNFAC, EOPEADBJLDL[] CEPDKAIKDOH, GPGAJMFGKJB[] PMPKGHHPFNJ, float[] NCDIDBGNDBD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public struct KCIIHLBLGKA<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public IEnumerable<TData> GJMJPCJAOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public EOPEADBJLDL OJAODFKIAIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public GPGAJMFGKJB OAPOMEHPDKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public float NCDIDBGNDBD;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x3896140", Offset = "0x3894F40", VA = "0x183896140")]
	public KCIIHLBLGKA(IEnumerable<TData> CIADNPCNFAC, EOPEADBJLDL CEPDKAIKDOH, GPGAJMFGKJB PMPKGHHPFNJ, float NCDIDBGNDBD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface DFFHHDPPNCE<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DGBJLJELEOL([In] PAGGNCPNLOG<TData> JFBDCIEFOKF);

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LEPOBOCJKNF([In] PAGGNCPNLOG<TData> JFBDCIEFOKF);

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MGFKKLGKONN([In] bool KLDHKBBHBMK);

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool NIBGEGGLBKP([In] PAGGNCPNLOG<TData> JFBDCIEFOKF);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JPGLDIONFBP();

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool ADEOHOLDIJD([In] TData GDCHBKJGPLF);
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class GJBHKILMHPD<TData> : LPGKDEDBIGH<DFFHHDPPNCE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly PAGGNCPNLOG<TData> JFBDCIEFOKF;

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x3526310", Offset = "0x3525110", VA = "0x183526310")]
	public GJBHKILMHPD(List<TData> DNHCBADCFIB, DFFHHDPPNCE<TData> ELGGIPNHKGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x3382EC0", Offset = "0x3381CC0", VA = "0x183382EC0", Slot = "4")]
	public override bool PKCLAOPMEIK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class NAAGAPMNFMI<TData> : LPGKDEDBIGH<DFFHHDPPNCE<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x303D350", Offset = "0x303C150", VA = "0x18303D350")]
	public NAAGAPMNFMI(DFFHHDPPNCE<TData> ELGGIPNHKGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x3BCEB30", Offset = "0x3BCD930", VA = "0x183BCEB30", Slot = "4")]
	public override bool PKCLAOPMEIK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class FFEHOGDIHGP<TData> : LPGKDEDBIGH<DFFHHDPPNCE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly bool ODACDEHJFCB;

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x33A2820", Offset = "0x33A1620", VA = "0x1833A2820")]
	public FFEHOGDIHGP(bool ODACDEHJFCB, DFFHHDPPNCE<TData> ELGGIPNHKGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x33A27C0", Offset = "0x33A15C0", VA = "0x1833A27C0", Slot = "4")]
	public override bool PKCLAOPMEIK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class OANBDOCIEFJ<TData> : LPGKDEDBIGH<DFFHHDPPNCE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly PAGGNCPNLOG<TData> JFBDCIEFOKF;

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3CC30F0", Offset = "0x3CC1EF0", VA = "0x183CC30F0")]
	public OANBDOCIEFJ(List<TData> DNHCBADCFIB, bool ODACDEHJFCB, DFFHHDPPNCE<TData> ELGGIPNHKGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3CC2FA0", Offset = "0x3CC1DA0", VA = "0x183CC2FA0", Slot = "4")]
	public override bool PKCLAOPMEIK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public class CEGHFIMGEJG<TData> : LPGKDEDBIGH<DFFHHDPPNCE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly TData GDCHBKJGPLF;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x4781C20", Offset = "0x4780A20", VA = "0x184781C20")]
	public CEGHFIMGEJG(TData GDCHBKJGPLF, DFFHHDPPNCE<TData> ELGGIPNHKGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x4781B50", Offset = "0x4780950", VA = "0x184781B50", Slot = "4")]
	public override bool PKCLAOPMEIK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class HAMICDFPKCH<TData> : LPGKDEDBIGH<DFFHHDPPNCE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly PAGGNCPNLOG<TData> JFBDCIEFOKF;

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x35A8DE0", Offset = "0x35A7BE0", VA = "0x1835A8DE0")]
	public HAMICDFPKCH(List<TData> DNHCBADCFIB, DFFHHDPPNCE<TData> ELGGIPNHKGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x35A8C80", Offset = "0x35A7A80", VA = "0x1835A8C80", Slot = "4")]
	public override bool PKCLAOPMEIK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public struct PAGGNCPNLOG<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public IEnumerable<TData> GJMJPCJAOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public bool ODACDEHJFCB;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3D73C10", Offset = "0x3D72A10", VA = "0x183D73C10")]
	public PAGGNCPNLOG(IEnumerable<TData> INPPCHNKBEG, bool AFGCDCMCFBO = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface DGOLNFFDKKJ
{
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<ABLFIOHECPN> PKCLAOPMEIK(DMPOHPAEOOJ GMGPGNILHEB);
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class OJHEIHEFLEH : PJKCMLDHHHF<DGOLNFFDKKJ, ABLFIOHECPN>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private struct NEDBEBFMNCK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public AsyncTaskMethodBuilder<ABLFIOHECPN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public OJHEIHEFLEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private TaskAwaiter<ABLFIOHECPN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x5CAA870", Offset = "0x5CA9670", VA = "0x185CAA870", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x5CAAAF0", Offset = "0x5CA98F0", VA = "0x185CAAAF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly DMPOHPAEOOJ JDBGGCIALDN;

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5CAACD0", Offset = "0x5CA9AD0", VA = "0x185CAACD0")]
	public OJHEIHEFLEH(bool ODACDEHJFCB, DGOLNFFDKKJ ELGGIPNHKGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5CAABE0", Offset = "0x5CA99E0", VA = "0x185CAABE0", Slot = "4")]
	[AsyncStateMachine(typeof(NEDBEBFMNCK))]
	public override Task<ABLFIOHECPN> PKCLAOPMEIK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public struct DMPOHPAEOOJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public bool ALJNEMCFFNF;

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0xB50F00", Offset = "0xB4FD00", VA = "0x180B50F00")]
	public DMPOHPAEOOJ(bool ODACDEHJFCB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface CMFMBAABLHH<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LFOPGGPPAFB([In] FDILBIHOHCO<TData> PIJFIEABAOB);

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HIKDKFFIPPB([In] CIKNOBPICIM CAHKDCLCLCB);

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HIKDKFFIPPB([In] FEPEMIOGIED CAHKDCLCLCB);

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HAIIJKHMOJG();
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class NOAMKHHMECI<TData> : LPGKDEDBIGH<CMFMBAABLHH<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x303D350", Offset = "0x303C150", VA = "0x18303D350")]
	public NOAMKHHMECI(CMFMBAABLHH<TData> ELGGIPNHKGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3BF79E0", Offset = "0x3BF67E0", VA = "0x183BF79E0", Slot = "4")]
	public override bool PKCLAOPMEIK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class NHLKEPENDDG<TData> : LPGKDEDBIGH<CMFMBAABLHH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly CIKNOBPICIM FGHICMEEJFK;

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3BE93A0", Offset = "0x3BE81A0", VA = "0x183BE93A0")]
	public NHLKEPENDDG(Vector3 GCGIILKMAOG, bool JOJABGHPGPJ, CMFMBAABLHH<TData> ELGGIPNHKGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3BE9340", Offset = "0x3BE8140", VA = "0x183BE9340", Slot = "4")]
	public override bool PKCLAOPMEIK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class MNNMIDEIHLG<TData> : LPGKDEDBIGH<CMFMBAABLHH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly FEPEMIOGIED FGHICMEEJFK;

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3B93BD0", Offset = "0x3B929D0", VA = "0x183B93BD0")]
	public MNNMIDEIHLG(Guid NOPLMCBHDHD, int OCMJNDDMDAL, Vector3 CMKBDFOJBFE, Quaternion ALADLBOMNEP, float HMBCCKMGEBH, bool JOJABGHPGPJ, CMFMBAABLHH<TData> ELGGIPNHKGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3B93B70", Offset = "0x3B92970", VA = "0x183B93B70", Slot = "4")]
	public override bool PKCLAOPMEIK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class DDAMKNIMOBA<TData> : LPGKDEDBIGH<CMFMBAABLHH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly FDILBIHOHCO<TData> FGHICMEEJFK;

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x4C47BD0", Offset = "0x4C469D0", VA = "0x184C47BD0")]
	public DDAMKNIMOBA(TData PABBJIBBIGE, bool ODACDEHJFCB, CMFMBAABLHH<TData> ELGGIPNHKGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3382EC0", Offset = "0x3381CC0", VA = "0x183382EC0", Slot = "4")]
	public override bool PKCLAOPMEIK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public struct CIKNOBPICIM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly Vector3 GCGIILKMAOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly bool JOJABGHPGPJ;

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x5CAA590", Offset = "0x5CA9390", VA = "0x185CAA590")]
	public CIKNOBPICIM(Vector3 GCGIILKMAOG, bool JOJABGHPGPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct FEPEMIOGIED
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly Guid NOPLMCBHDHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly int OCMJNDDMDAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly Vector3 CMKBDFOJBFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly Quaternion ALADLBOMNEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly float HMBCCKMGEBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly bool JOJABGHPGPJ;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x5CAA7E0", Offset = "0x5CA95E0", VA = "0x185CAA7E0")]
	public FEPEMIOGIED(Guid NOPLMCBHDHD, int OCMJNDDMDAL, Vector3 CMKBDFOJBFE, Quaternion ALADLBOMNEP, float HMBCCKMGEBH, bool JOJABGHPGPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public struct FDILBIHOHCO<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly TData PABBJIBBIGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly bool ODACDEHJFCB;

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x33970E0", Offset = "0x3395EE0", VA = "0x1833970E0")]
	public FDILBIHOHCO(TData PABBJIBBIGE, bool ODACDEHJFCB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface INJNOCOLELI<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PKCLAOPMEIK([In] JGJJECICLID<TData> IAMGCHJOINJ);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PKCLAOPMEIK([In] ONHJCNBEFEC<TData> IAMGCHJOINJ);
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public interface JOEJIODKCAB<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LFOPGGPPAFB([In] MENHMNADDKF<TData> DDAEFFBDMLL);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HIKDKFFIPPB([In] LBOPDJLIDCP CAHKDCLCLCB);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HAIIJKHMOJG();
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class JFAMCHCAEIL<TData> : LPGKDEDBIGH<INJNOCOLELI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly JGJJECICLID<TData> IAMGCHJOINJ;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x384BEF0", Offset = "0x384ACF0", VA = "0x18384BEF0")]
	public JFAMCHCAEIL(IEnumerable<TData> CIADNPCNFAC, Vector3 OJMJECCKLJK, bool ODACDEHJFCB, INJNOCOLELI<TData> ELGGIPNHKGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x3382EC0", Offset = "0x3381CC0", VA = "0x183382EC0", Slot = "4")]
	public override bool PKCLAOPMEIK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class PFEFDKEEBFA<TData> : LPGKDEDBIGH<JOEJIODKCAB<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x303D350", Offset = "0x303C150", VA = "0x18303D350")]
	public PFEFDKEEBFA(JOEJIODKCAB<TData> ELGGIPNHKGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x35EC170", Offset = "0x35EAF70", VA = "0x1835EC170", Slot = "4")]
	public override bool PKCLAOPMEIK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class FBBCKCJPAJN<TData> : LPGKDEDBIGH<JOEJIODKCAB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly MENHMNADDKF<TData> IAMGCHJOINJ;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x3382F80", Offset = "0x3381D80", VA = "0x183382F80")]
	public FBBCKCJPAJN(IEnumerable<TData> CIADNPCNFAC, bool ODACDEHJFCB, JOEJIODKCAB<TData> ELGGIPNHKGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x3382EC0", Offset = "0x3381CC0", VA = "0x183382EC0", Slot = "4")]
	public override bool PKCLAOPMEIK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class NHFPALELFOM<TData> : LPGKDEDBIGH<INJNOCOLELI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly ONHJCNBEFEC<TData> IAMGCHJOINJ;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x3BE80F0", Offset = "0x3BE6EF0", VA = "0x183BE80F0")]
	public NHFPALELFOM(IEnumerable<TData> CIADNPCNFAC, Vector3 ILHJGKNNIJN, IMJCJACDKMA AOMCEDIMMDH, bool ODACDEHJFCB, INJNOCOLELI<TData> ELGGIPNHKGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3B63C60", Offset = "0x3B62A60", VA = "0x183B63C60", Slot = "4")]
	public override bool PKCLAOPMEIK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class NOLBMAMEKFL<TData> : LPGKDEDBIGH<JOEJIODKCAB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly LBOPDJLIDCP IAMGCHJOINJ;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x3BF8740", Offset = "0x3BF7540", VA = "0x183BF8740")]
	public NOLBMAMEKFL(Vector3 OJMJECCKLJK, JOEJIODKCAB<TData> ELGGIPNHKGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x3BE9340", Offset = "0x3BE8140", VA = "0x183BE9340", Slot = "4")]
	public override bool PKCLAOPMEIK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public struct JGJJECICLID<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public readonly IEnumerable<TData> CIADNPCNFAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public readonly Vector3 OJMJECCKLJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public readonly bool ODACDEHJFCB;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x3855120", Offset = "0x3853F20", VA = "0x183855120")]
	public JGJJECICLID(IEnumerable<TData> CIADNPCNFAC, Vector3 OJMJECCKLJK, bool ODACDEHJFCB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public struct MENHMNADDKF<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public readonly IEnumerable<TData> CIADNPCNFAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly bool ODACDEHJFCB;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x3B5BF10", Offset = "0x3B5AD10", VA = "0x183B5BF10")]
	public MENHMNADDKF(IEnumerable<TData> CIADNPCNFAC, bool ODACDEHJFCB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public struct ONHJCNBEFEC<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public readonly IEnumerable<TData> CIADNPCNFAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public readonly Vector3 ILHJGKNNIJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public readonly IMJCJACDKMA AOMCEDIMMDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public readonly bool ODACDEHJFCB;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x3CE8C40", Offset = "0x3CE7A40", VA = "0x183CE8C40")]
	public ONHJCNBEFEC(IEnumerable<TData> CIADNPCNFAC, Vector3 ILHJGKNNIJN, IMJCJACDKMA AOMCEDIMMDH, bool ODACDEHJFCB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public struct LBOPDJLIDCP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public readonly Vector3 OJMJECCKLJK;

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x1F4F780", Offset = "0x1F4E580", VA = "0x181F4F780")]
	public LBOPDJLIDCP(Vector3 OJMJECCKLJK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public enum IMJCJACDKMA
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
public interface DLABFNHCLEJ<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PKCLAOPMEIK([In] FMLLCICJPKL<TData> ILHHAOPHEGB);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PKCLAOPMEIK([In] AJGKKGAHBCP<TData> ILHHAOPHEGB);
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public interface HMNJNAAOPNI<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LFOPGGPPAFB([In] FLAIGPBCMHO<TData> PIJFIEABAOB);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HIKDKFFIPPB([In] FJPLDFPIPDE CAHKDCLCLCB);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HAIIJKHMOJG();
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public class FIKOCGBHNMJ<TData> : LPGKDEDBIGH<DLABFNHCLEJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly FMLLCICJPKL<TData> ILHHAOPHEGB;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x33B6AB0", Offset = "0x33B58B0", VA = "0x1833B6AB0")]
	public FIKOCGBHNMJ(IEnumerable<TData> CIADNPCNFAC, Quaternion OJMJECCKLJK, Vector3? IJEAMNBEJBA, bool FNDACAJIMGE, bool ODACDEHJFCB, DLABFNHCLEJ<TData> ELGGIPNHKGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x3382EC0", Offset = "0x3381CC0", VA = "0x183382EC0", Slot = "4")]
	public override bool PKCLAOPMEIK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class LEFENFADEKN<TData> : LPGKDEDBIGH<HMNJNAAOPNI<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x303D350", Offset = "0x303C150", VA = "0x18303D350")]
	public LEFENFADEKN(HMNJNAAOPNI<TData> ELGGIPNHKGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x35EC170", Offset = "0x35EAF70", VA = "0x1835EC170", Slot = "4")]
	public override bool PKCLAOPMEIK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class MPGHPDMICLH<TData> : LPGKDEDBIGH<HMNJNAAOPNI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly FLAIGPBCMHO<TData> ILHHAOPHEGB;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x3B9C8D0", Offset = "0x3B9B6D0", VA = "0x183B9C8D0")]
	public MPGHPDMICLH(IEnumerable<TData> CIADNPCNFAC, bool ODACDEHJFCB, HMNJNAAOPNI<TData> ELGGIPNHKGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x3382EC0", Offset = "0x3381CC0", VA = "0x183382EC0", Slot = "4")]
	public override bool PKCLAOPMEIK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class MFEHGHDNDDO<TData> : LPGKDEDBIGH<DLABFNHCLEJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly AJGKKGAHBCP<TData> ILHHAOPHEGB;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x3B63D30", Offset = "0x3B62B30", VA = "0x183B63D30")]
	public MFEHGHDNDDO(IEnumerable<TData> CIADNPCNFAC, Quaternion MEJEPMKGHCB, IMJCJACDKMA JPCFIECHOMF, Vector3? IJEAMNBEJBA, bool FNDACAJIMGE, bool ODACDEHJFCB, DLABFNHCLEJ<TData> ELGGIPNHKGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x3B63C60", Offset = "0x3B62A60", VA = "0x183B63C60", Slot = "4")]
	public override bool PKCLAOPMEIK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class BBPGMMDBOMJ<TData> : LPGKDEDBIGH<HMNJNAAOPNI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly FJPLDFPIPDE ILHHAOPHEGB;

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x441B560", Offset = "0x441A360", VA = "0x18441B560")]
	public BBPGMMDBOMJ(Quaternion OJMJECCKLJK, Vector3? IJEAMNBEJBA, bool FNDACAJIMGE, HMNJNAAOPNI<TData> ELGGIPNHKGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x3BE9340", Offset = "0x3BE8140", VA = "0x183BE9340", Slot = "4")]
	public override bool PKCLAOPMEIK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public struct FMLLCICJPKL<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public readonly IEnumerable<TData> CIADNPCNFAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public readonly Quaternion OJMJECCKLJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public readonly Vector3? IJEAMNBEJBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public readonly bool FNDACAJIMGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public readonly bool ODACDEHJFCB;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x33C5FA0", Offset = "0x33C4DA0", VA = "0x1833C5FA0")]
	public FMLLCICJPKL(IEnumerable<TData> CIADNPCNFAC, Quaternion OJMJECCKLJK, Vector3? IJEAMNBEJBA, bool FNDACAJIMGE, bool ODACDEHJFCB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct FLAIGPBCMHO<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public readonly IEnumerable<TData> CIADNPCNFAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly bool ODACDEHJFCB;

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x33BED40", Offset = "0x33BDB40", VA = "0x1833BED40")]
	public FLAIGPBCMHO(IEnumerable<TData> CIADNPCNFAC, bool ODACDEHJFCB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct AJGKKGAHBCP<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public readonly IEnumerable<TData> CIADNPCNFAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly Quaternion MEJEPMKGHCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public readonly IMJCJACDKMA JPCFIECHOMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public readonly Vector3? IJEAMNBEJBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public readonly bool FNDACAJIMGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public readonly bool ODACDEHJFCB;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x34B1D10", Offset = "0x34B0B10", VA = "0x1834B1D10")]
	public AJGKKGAHBCP(IEnumerable<TData> CIADNPCNFAC, Quaternion MEJEPMKGHCB, IMJCJACDKMA JPCFIECHOMF, Vector3? IJEAMNBEJBA, bool FNDACAJIMGE, bool ODACDEHJFCB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct FJPLDFPIPDE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public readonly Quaternion OJMJECCKLJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public readonly Vector3? IJEAMNBEJBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public readonly bool FNDACAJIMGE;

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x42938F0", Offset = "0x42926F0", VA = "0x1842938F0")]
	public FJPLDFPIPDE(Quaternion OJMJECCKLJK, Vector3? IJEAMNBEJBA, bool FNDACAJIMGE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public interface JCBDJGMPOOC<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LFOPGGPPAFB([In] EMGJKOFJNNN<TData> PIJFIEABAOB);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HIKDKFFIPPB([In] NDGIHOCBEJC CAHKDCLCLCB);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HIKDKFFIPPB([In] LDIADIAIBGK CAHKDCLCLCB);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HIKDKFFIPPB([In] HHAMLCGDKHG CAHKDCLCLCB);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool HAIIJKHMOJG();
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public class ILHHADAHPHH<TData> : LPGKDEDBIGH<JCBDJGMPOOC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly HHAMLCGDKHG FIPGCAECICN;

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x36A4D90", Offset = "0x36A3B90", VA = "0x1836A4D90")]
	public ILHHADAHPHH(Vector3 HFPHMJOOHPD, float DGEJJEICPCE, Vector3 IJEAMNBEJBA, bool ECAOEMGKBKL, JCBDJGMPOOC<TData> ELGGIPNHKGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x36A4D30", Offset = "0x36A3B30", VA = "0x1836A4D30", Slot = "4")]
	public override bool PKCLAOPMEIK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public class NNKDJPFEHOP<TData> : LPGKDEDBIGH<JCBDJGMPOOC<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x303D350", Offset = "0x303C150", VA = "0x18303D350")]
	public NNKDJPFEHOP(JCBDJGMPOOC<TData> ELGGIPNHKGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x3BF7760", Offset = "0x3BF6560", VA = "0x183BF7760", Slot = "4")]
	public override bool PKCLAOPMEIK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public class KBIIPINPMFC<TData> : LPGKDEDBIGH<JCBDJGMPOOC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly EMGJKOFJNNN<TData> FIPGCAECICN;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x3894040", Offset = "0x3892E40", VA = "0x183894040")]
	public KBIIPINPMFC(IEnumerable<TData> CIADNPCNFAC, bool ODACDEHJFCB, JCBDJGMPOOC<TData> ELGGIPNHKGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x3382EC0", Offset = "0x3381CC0", VA = "0x183382EC0", Slot = "4")]
	public override bool PKCLAOPMEIK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class LBMIDBEKEMG<TData> : LPGKDEDBIGH<JCBDJGMPOOC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly LDIADIAIBGK FIPGCAECICN;

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x3951910", Offset = "0x3950710", VA = "0x183951910")]
	public LBMIDBEKEMG(float JKLMCOHELLH, bool ADLPAINCJFD, Vector3 IJEAMNBEJBA, JCBDJGMPOOC<TData> ELGGIPNHKGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x3951840", Offset = "0x3950640", VA = "0x183951840", Slot = "4")]
	public override bool PKCLAOPMEIK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public class DDKCEPFPNNB<TData> : LPGKDEDBIGH<JCBDJGMPOOC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly NDGIHOCBEJC FIPGCAECICN;

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x4C49290", Offset = "0x4C48090", VA = "0x184C49290")]
	public DDKCEPFPNNB(float DGEJJEICPCE, Vector3 IJEAMNBEJBA, JCBDJGMPOOC<TData> ELGGIPNHKGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x3BE9340", Offset = "0x3BE8140", VA = "0x183BE9340", Slot = "4")]
	public override bool PKCLAOPMEIK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct HHAMLCGDKHG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public readonly Vector3 HFPHMJOOHPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public readonly float DGEJJEICPCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public readonly Vector3 IJEAMNBEJBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public readonly bool JOJABGHPGPJ;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x5CAA820", Offset = "0x5CA9620", VA = "0x185CAA820")]
	public HHAMLCGDKHG(Vector3 HFPHMJOOHPD, float DGEJJEICPCE, Vector3 IJEAMNBEJBA, bool JOJABGHPGPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public struct EMGJKOFJNNN<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public readonly IEnumerable<TData> CIADNPCNFAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public readonly bool ODACDEHJFCB;

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x304A340", Offset = "0x3049140", VA = "0x18304A340")]
	public EMGJKOFJNNN(IEnumerable<TData> CIADNPCNFAC, bool ODACDEHJFCB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public struct LDIADIAIBGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public readonly float JKLMCOHELLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly bool ADLPAINCJFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public readonly Vector3 IJEAMNBEJBA;

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x5CAA850", Offset = "0x5CA9650", VA = "0x185CAA850")]
	public LDIADIAIBGK(float JKLMCOHELLH, bool ADLPAINCJFD, Vector3 IJEAMNBEJBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct NDGIHOCBEJC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public readonly float DGEJJEICPCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public readonly Vector3 IJEAMNBEJBA;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x42696F0", Offset = "0x42684F0", VA = "0x1842696F0")]
	public NDGIHOCBEJC(float DGEJJEICPCE, Vector3 IJEAMNBEJBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public static class AFKOADBIFKN
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	private struct JIEEMANEICP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public bool EHHHLLKBKEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public NNIGDKDCOBN FCKGNOCODEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public NNIGDKDCOBN KGPJFDGIOMG;
	}

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private static JIEEMANEICP FDFDOBPBLEA;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static CancellationToken GNCLJIFHECE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x5CAA4D0", Offset = "0x5CA92D0", VA = "0x185CAA4D0")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	internal static NNIGDKDCOBN FCKGNOCODEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x5CAA4F0", Offset = "0x5CA92F0", VA = "0x185CAA4F0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x5CAA1C0", Offset = "0x5CA8FC0", VA = "0x185CAA1C0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5CAA280", Offset = "0x5CA9080", VA = "0x185CAA280")]
	[DJDJPHIPNFL(KHJICKDGEOE.Room, IEJLPKKICHC.None)]
	private static void HLLKMDBMGOC(NNIGDKDCOBN PMFAGBHCNBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5CAA380", Offset = "0x5CA9180", VA = "0x185CAA380")]
	public static void LJDFGIJMKMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x5CAA230", Offset = "0x5CA9030", VA = "0x185CAA230")]
	private static NNIGDKDCOBN HLKJLBKJMHH(NNIGDKDCOBN AKMLFNCIJHN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public static class LKGIDPLJOHG
{
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public enum PBDKBEPABLI
	{
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		ICreationContextObject,
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		Guid
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x2458100", Offset = "0x2456F00", VA = "0x182458100")]
	public static void BNFOCCCFKOC<T>(T BBDPDFCKIOF, PBDKBEPABLI FLHOFPAHPKL) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x2458240", Offset = "0x2457040", VA = "0x182458240")]
	public static void BNFOCCCFKOC<T>(T BBDPDFCKIOF) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x2458420", Offset = "0x2457220", VA = "0x182458420")]
	public static void KHFHFOCCLHE<T>(T BBDPDFCKIOF) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x2458380", Offset = "0x2457180", VA = "0x182458380")]
	public static T HAMDPAFEPLN<T>(PBDKBEPABLI FLHOFPAHPKL) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x24582E0", Offset = "0x24570E0", VA = "0x1824582E0")]
	public static bool EDGIJGLBIJI<T>(PBDKBEPABLI FLHOFPAHPKL) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x24582A0", Offset = "0x24570A0", VA = "0x1824582A0")]
	public static T HAMDPAFEPLN<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x24582A0", Offset = "0x24570A0", VA = "0x1824582A0")]
	public static bool EDGIJGLBIJI<T>() where T : class
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
internal static class EHPKJCBJLPG
{
	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x5CAA5B0", Offset = "0x5CA93B0", VA = "0x185CAA5B0")]
	public static void FJIHOGFKINJ(IEnumerable EGDFOCDPMDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x2249980", Offset = "0x2248780", VA = "0x182249980")]
	public static void FJIHOGFKINJ<T>(T[] OBEMKDLNKLE) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x2249A70", Offset = "0x2248870", VA = "0x182249A70")]
	public static void FJIHOGFKINJ<T>(T JLNEIALFDLF) where T : notnull, Enum
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
