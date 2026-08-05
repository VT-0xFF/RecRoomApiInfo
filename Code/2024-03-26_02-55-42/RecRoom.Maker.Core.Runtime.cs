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
		[Cpp2IlInjected.Address(RVA = "0x7E7D80", Offset = "0x7E7180", VA = "0x1807E7D80")]
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
		[Cpp2IlInjected.Address(RVA = "0x61F78A0", Offset = "0x61F6CA0", VA = "0x1861F78A0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7E8560", Offset = "0x7E7960", VA = "0x1807E8560")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E85A0", Offset = "0x7E79A0", VA = "0x1807E85A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface KFJIBEHIFAI<TData, TReturn>
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TReturn AGNFAEAJNLK(TData LIKEKIACGIL);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface DJBKEOPNBKI<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ClearHoverTarget(JIKJBMAJPLG OCEABMAKHGP);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool SetHoverTarget(TData NDIKGOAJKGJ, Collider JMFEFAKGIAH, JIKJBMAJPLG OCEABMAKHGP, [Optional] MIMGKCKGLLK? HMBFHKNGAME);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool TryGetHoverTarget([Out] TData NDIKGOAJKGJ);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetHoverCollider([Out] Collider JMFEFAKGIAH);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface KPOJBFCKNEL<TData> : POKBOLJGPAH, HAIHJHNPCLH<TData>, KENNFCEBPFD<TData>, KGKGHCIPJMG<TData>, HCKCDMEHLOH, BOFDNAJBJDO<TData>, CMKPFHCHJHA, KJBNMMEHNNC
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface BOFDNAJBJDO<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 GCCJMDLJDKL, Vector3 FOKNCLAMPPK, float KNAMMKAAHOE, [Out] T ECAMJJHNAND, [Out] Vector3 FOPHEJBNCHE, [Out] Collider JMFEFAKGIAH);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 GCCJMDLJDKL, Vector3 FOKNCLAMPPK, float AHGPDIPKBCN, float KNAMMKAAHOE, T[] GNJPFBLBEMN, [Out] Vector3 EDKBIAGLOMD, [Out] Collider NODAPJDJMJB);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 GCCJMDLJDKL, float AHGPDIPKBCN, Vector3 GGKJOABHKID, T[] GNJPFBLBEMN);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetObjectFromColliderInCurrentScope(Collider NCBDOAFFENC, [Out] T FAPPCKPKCFE);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface POKBOLJGPAH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Bounds JELMDPGJLEI
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Transform CLGCOEACACJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Bounds ALLFGAOGBEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Transform EJHONCCBIDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Vector3 NCKNDPOPPCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool PAIKIIOBCDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void SetSelectionBoundsDirty(bool AALHKBHHHMC = true, int EBFILAFPCHC = 0);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ShouldHideSelectionBoundsPreview(bool KJHIJJEMKPL, object ICNJFMMNIKL);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface KJBNMMEHNNC
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	DGHHAMKHKGM HNGKCHGGAND
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface GJMDFLJNJPO
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool PALJLPCBOOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool JCPENLJLGHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool HMBOFCFNAHM
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
	void TrySetPreviousCloneMapping(Dictionary<Guid, Guid> JEFLOMBMMGP);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface KGKGHCIPJMG<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool PDBHKCPNFHN
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int ANLHKIODHIP
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<TData> JBMDKOICOMI
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData LPGJEPJPGGB);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData LPGJEPJPGGB);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface HAIHJHNPCLH<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T LIKEKIACGIL, [Optional] MIMGKCKGLLK? AGFAEGAHBBK, bool LHNBMJBCIOD = true);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int JDBLGKLFJDF, IEnumerable<T> PFBEDJLCFMJ, bool LHNBMJBCIOD = true);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int JDBLGKLFJDF, IEnumerable<T> PFBEDJLCFMJ, MIMGKCKGLLK AGFAEGAHBBK, bool LHNBMJBCIOD = true);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface CMKPFHCHJHA
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface HCKCDMEHLOH
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool CJFFILFDMIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool PBDHKEGOMKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool HOPEJFNDELA
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool NEFEPPGKEEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class PMPNNJNGLDG<TReceiver> : JJJOIPDMGEA<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3377370", Offset = "0x3376770", VA = "0x183377370")]
	public PMPNNJNGLDG(TReceiver MDOBDPHHONK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class CLFJIEIHJCK<TReceiver, TFromTask> : JJJOIPDMGEA<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3377370", Offset = "0x3376770", VA = "0x183377370")]
	public CLFJIEIHJCK(TReceiver MDOBDPHHONK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public abstract class JJJOIPDMGEA<TReceiver, TFromExecute> where TReceiver : notnull where TFromExecute : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	protected TReceiver MDOBDPHHONK;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3BA4A50", Offset = "0x3BA3E50", VA = "0x183BA4A50")]
	public JJJOIPDMGEA(TReceiver MDOBDPHHONK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute HCIKHOJIPGF();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public abstract class NIKAOKNMDLH<TReceiver, TResult> : JJJOIPDMGEA<TReceiver, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3377370", Offset = "0x3376770", VA = "0x183377370")]
	public NIKAOKNMDLH(TReceiver MDOBDPHHONK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct HDAMJKMLOPB<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public TGroup AEAIKLKKJAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public TData DNFIMCLCBAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public IEnumerable<TData> JBFDINPJGEE;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1B13B70", Offset = "0x1B12F70", VA = "0x181B13B70")]
	public HDAMJKMLOPB(TGroup CPGIKOBAGBJ, TData LADJCCFFNAE, IEnumerable<TData> MIJENKHJAPN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct ADLMDLALLIL<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public TGroup AEAIKLKKJAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public IEnumerable<TData> JBFDINPJGEE;

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x90E910", Offset = "0x90DD10", VA = "0x18090E910")]
	public ADLMDLALLIL(TGroup CPGIKOBAGBJ, IEnumerable<TData> MIJENKHJAPN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct IDOEPBGFJMP<TGroup> where TGroup : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public TGroup AEAIKLKKJAH;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x948610", Offset = "0x947A10", VA = "0x180948610")]
	public IDOEPBGFJMP(TGroup CPGIKOBAGBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct HBONKHKMBIG<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public IEnumerable<TData> JBFDINPJGEE;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x948610", Offset = "0x947A10", VA = "0x180948610")]
	public HBONKHKMBIG(IEnumerable<TData> MIJENKHJAPN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface BJBFJOGDICF<TGroup, TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ABMMODGFBCM EPANFCDNDGB(HDAMJKMLOPB<TGroup, TData> EBOHBLFDIHK);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ABMMODGFBCM MCMFDJGCGLJ(HDAMJKMLOPB<TGroup, TData> EBOHBLFDIHK);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ABMMODGFBCM CADKEEJAJCN(ADLMDLALLIL<TGroup, TData> EBOHBLFDIHK);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "3")]
	ABMMODGFBCM NKAOCGOILEE(IDOEPBGFJMP<TGroup> EBOHBLFDIHK);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface PFOMFLIDPLE<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<ABMMODGFBCM> EPANFCDNDGB(HBONKHKMBIG<TData> EBOHBLFDIHK);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class JGLPDNMAEHK<TGroup, TData> : NIKAOKNMDLH<BJBFJOGDICF<TGroup, TData>, ABMMODGFBCM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly ADLMDLALLIL<TGroup, TData> EBOHBLFDIHK;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3B9C4E0", Offset = "0x3B9B8E0", VA = "0x183B9C4E0")]
	public JGLPDNMAEHK(TGroup CPGIKOBAGBJ, IEnumerable<TData> MIJENKHJAPN, BJBFJOGDICF<TGroup, TData> MDOBDPHHONK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3B9C410", Offset = "0x3B9B810", VA = "0x183B9C410", Slot = "4")]
	public override ABMMODGFBCM HCIKHOJIPGF()
	{
		return default(ABMMODGFBCM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class PIBOJEKOKDK<TGroup, TData> : NIKAOKNMDLH<BJBFJOGDICF<TGroup, TData>, ABMMODGFBCM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly HDAMJKMLOPB<TGroup, TData> EBOHBLFDIHK;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x41A1A90", Offset = "0x41A0E90", VA = "0x1841A1A90")]
	public PIBOJEKOKDK(TGroup CPGIKOBAGBJ, TData EEFOIEICDMO, IEnumerable<TData> MIJENKHJAPN, BJBFJOGDICF<TGroup, TData> MDOBDPHHONK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x41A19B0", Offset = "0x41A0DB0", VA = "0x1841A19B0", Slot = "4")]
	public override ABMMODGFBCM HCIKHOJIPGF()
	{
		return default(ABMMODGFBCM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class OEHCFMKPGML<TGroup, TData> : NIKAOKNMDLH<BJBFJOGDICF<TGroup, TData>, ABMMODGFBCM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly IDOEPBGFJMP<TGroup> EBOHBLFDIHK;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3F0EA70", Offset = "0x3F0DE70", VA = "0x183F0EA70")]
	public OEHCFMKPGML(TGroup CPGIKOBAGBJ, BJBFJOGDICF<TGroup, TData> MDOBDPHHONK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x40CD2E0", Offset = "0x40CC6E0", VA = "0x1840CD2E0", Slot = "4")]
	public override ABMMODGFBCM HCIKHOJIPGF()
	{
		return default(ABMMODGFBCM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class DEENKIANJAC<TGroup, TData> : NIKAOKNMDLH<BJBFJOGDICF<TGroup, TData>, ABMMODGFBCM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly HDAMJKMLOPB<TGroup, TData> EBOHBLFDIHK;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x41A1A90", Offset = "0x41A0E90", VA = "0x1841A1A90")]
	public DEENKIANJAC(TGroup CPGIKOBAGBJ, TData LADJCCFFNAE, IEnumerable<TData> MIJENKHJAPN, BJBFJOGDICF<TGroup, TData> MDOBDPHHONK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x50EC270", Offset = "0x50EB670", VA = "0x1850EC270", Slot = "4")]
	public override ABMMODGFBCM HCIKHOJIPGF()
	{
		return default(ABMMODGFBCM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class PPEKNODOMEP<TData> : CLFJIEIHJCK<PFOMFLIDPLE<TData>, ABMMODGFBCM> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private struct IAGIGOCPJEN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AsyncTaskMethodBuilder<ABMMODGFBCM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public PPEKNODOMEP<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private TaskAwaiter<ABMMODGFBCM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x3983450", Offset = "0x3982850", VA = "0x183983450", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x39836F0", Offset = "0x3982AF0", VA = "0x1839836F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private HBONKHKMBIG<TData> EBOHBLFDIHK;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3F0EA70", Offset = "0x3F0DE70", VA = "0x183F0EA70")]
	public PPEKNODOMEP(IEnumerable<TData> OPGCJBACAND, PFOMFLIDPLE<TData> MDOBDPHHONK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x41C9D60", Offset = "0x41C9160", VA = "0x1841C9D60", Slot = "4")]
	[AsyncStateMachine(typeof(PPEKNODOMEP<>.IAGIGOCPJEN))]
	public override Task<ABMMODGFBCM> HCIKHOJIPGF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct MMBFOEBANMD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly GOOIIIHBAIL IDEMFCAFKAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly bool GLMPIEPKEPE;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x61F7880", Offset = "0x61F6C80", VA = "0x1861F7880")]
	public MMBFOEBANMD(GOOIIIHBAIL ADHPDADPGLB, bool NGCHDALJOPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface CCNBFIHNLIC<TSpawnType> where TSpawnType : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> HCIKHOJIPGF(MMBFOEBANMD EMCKCBDGKON);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class LEEKGNBIPFG<TSpawnType> : CLFJIEIHJCK<CCNBFIHNLIC<TSpawnType>, TSpawnType> where TSpawnType : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private struct BKFBGCDKMCL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public AsyncTaskMethodBuilder<TSpawnType> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public LEEKGNBIPFG<TSpawnType> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskAwaiter<TSpawnType> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x48267F0", Offset = "0x4825BF0", VA = "0x1848267F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3D2DDD0", Offset = "0x3D2D1D0", VA = "0x183D2DDD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly MMBFOEBANMD EMCKCBDGKON;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3D11D90", Offset = "0x3D11190", VA = "0x183D11D90")]
	public LEEKGNBIPFG(GOOIIIHBAIL ADHPDADPGLB, bool NGCHDALJOPK, CCNBFIHNLIC<TSpawnType> MDOBDPHHONK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3D11B90", Offset = "0x3D10F90", VA = "0x183D11B90", Slot = "4")]
	[AsyncStateMachine(typeof(LEEKGNBIPFG<>.BKFBGCDKMCL))]
	public override Task<TSpawnType> HCIKHOJIPGF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public readonly struct GOOIIIHBAIL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly bool PDOEAKMLNKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly Vector3 ALCMEJGKNJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly Vector3 COHFCEILEHK;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x61F7210", Offset = "0x61F6610", VA = "0x1861F7210")]
	public GOOIIIHBAIL(Transform BAMIHBPBHGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x61F71E0", Offset = "0x61F65E0", VA = "0x1861F71E0")]
	public GOOIIIHBAIL(Vector3 GCPIJELMKHI, Vector3 CJBHLOLHNJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x61F7120", Offset = "0x61F6520", VA = "0x1861F7120")]
	public static GOOIIIHBAIL KKNGHIBJGCG()
	{
		return default(GOOIIIHBAIL);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x61F7150", Offset = "0x61F6550", VA = "0x1861F7150")]
	private GOOIIIHBAIL(bool LKLKJDEFLCD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct NOMMLMDGLNN<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public TNode AOBINFNMGAE;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4007C10", Offset = "0x4007010", VA = "0x184007C10")]
	public NOMMLMDGLNN(TNode AOBINFNMGAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct BACFPCBKHGJ<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public TNode AFEBIBFIOHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public BLKBHCJNKCK GINHHACFCDM;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x47F8420", Offset = "0x47F7820", VA = "0x1847F8420")]
	public BACFPCBKHGJ(TNode AFEBIBFIOHH, BLKBHCJNKCK GINHHACFCDM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface FCPMHIHLKLH<TNode>
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DDBHCLCKIFD([In] NOMMLMDGLNN<TNode> NIOMOBLKKHL);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IKAOOFJDKID([In] BACFPCBKHGJ<TNode> EKJFANLKJMK);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FAELGOFFGAA();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class JNHCONLEOMG<TNode> : PMPNNJNGLDG<FCPMHIHLKLH<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3377370", Offset = "0x3376770", VA = "0x183377370")]
	public JNHCONLEOMG(FCPMHIHLKLH<TNode> MDOBDPHHONK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x387B4A0", Offset = "0x387A8A0", VA = "0x18387B4A0", Slot = "4")]
	public override bool HCIKHOJIPGF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class MIAFFOFHPMK<TNode> : PMPNNJNGLDG<FCPMHIHLKLH<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly BACFPCBKHGJ<TNode> EKJFANLKJMK;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3F02B10", Offset = "0x3F01F10", VA = "0x183F02B10")]
	public MIAFFOFHPMK(TNode AFEBIBFIOHH, BLKBHCJNKCK GINHHACFCDM, FCPMHIHLKLH<TNode> MDOBDPHHONK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3F02A40", Offset = "0x3F01E40", VA = "0x183F02A40", Slot = "4")]
	public override bool HCIKHOJIPGF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class PLIICKLLNKO<TNode> : PMPNNJNGLDG<FCPMHIHLKLH<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly NOMMLMDGLNN<TNode> NIOMOBLKKHL;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x41B31F0", Offset = "0x41B25F0", VA = "0x1841B31F0")]
	public PLIICKLLNKO(TNode GIKANOHNLAA, FCPMHIHLKLH<TNode> MDOBDPHHONK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x33100F0", Offset = "0x330F4F0", VA = "0x1833100F0", Slot = "4")]
	public override bool HCIKHOJIPGF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct BDGKBMBOFIC<TSpawnInfo> where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public TSpawnInfo JICOGJFIONG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public Vector3 CJBHLOLHNJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public Quaternion APMJJPLCLEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public float FHPLKKAFLOA;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x47FDEE0", Offset = "0x47FD2E0", VA = "0x1847FDEE0")]
	public BDGKBMBOFIC(TSpawnInfo JICOGJFIONG, Vector3 CJBHLOLHNJP, Quaternion APMJJPLCLEP, float FHPLKKAFLOA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface HODCFMOLONN<TSpawnType, TSpawnInfo>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> GJFMNLIJFIM([In] BDGKBMBOFIC<TSpawnInfo> JOIJPAMBBDC, CancellationToken KNKAEBKAEBM);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class PBLHHAPKDMN<TSpawnType, TSpawnInfo> : CLFJIEIHJCK<HODCFMOLONN<TSpawnType, TSpawnInfo>, TSpawnType> where TSpawnType : notnull where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly BDGKBMBOFIC<TSpawnInfo> EGGAPMGLGIF;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x41965B0", Offset = "0x41959B0", VA = "0x1841965B0")]
	public PBLHHAPKDMN(TSpawnInfo LBDIHAIOOAA, Vector3 CJBHLOLHNJP, Quaternion APMJJPLCLEP, float FHPLKKAFLOA, HODCFMOLONN<TSpawnType, TSpawnInfo> MDOBDPHHONK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x41964D0", Offset = "0x41958D0", VA = "0x1841964D0", Slot = "4")]
	public override Task<TSpawnType> HCIKHOJIPGF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct HLBMKBNHLJK<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly IEnumerable<TData> JBFDINPJGEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly bool GLMPIEPKEPE;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x38712F0", Offset = "0x38706F0", VA = "0x1838712F0")]
	public HLBMKBNHLJK(IEnumerable<TData> MIJENKHJAPN, bool NGCHDALJOPK = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface CPPHABMGPNF<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<ABMMODGFBCM> DHPAAILBCKP([In] HLBMKBNHLJK<TData> IMHCGNEOAIE, CancellationToken KNKAEBKAEBM);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class DEMLDGDDBMC<TData> : CLFJIEIHJCK<CPPHABMGPNF<TData>, ABMMODGFBCM> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly HLBMKBNHLJK<TData> NEHHKDHDNIN;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x50EE2B0", Offset = "0x50ED6B0", VA = "0x1850EE2B0")]
	public DEMLDGDDBMC(IEnumerable<TData> MIJENKHJAPN, bool NGCHDALJOPK, CPPHABMGPNF<TData> MDOBDPHHONK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x41964D0", Offset = "0x41958D0", VA = "0x1841964D0", Slot = "4")]
	public override Task<ABMMODGFBCM> HCIKHOJIPGF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct OEKPKKKLCDL<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly T NDIKGOAJKGJ;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x40C6890", Offset = "0x40C5C90", VA = "0x1840C6890")]
	public OEKPKKKLCDL(T OEPHFFNMBOB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface LOIHLOAACFC<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DDBHCLCKIFD([In] OEKPKKKLCDL<T> DMNIIABCOPE);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IKAOOFJDKID();
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface JJPJPOJAOHH<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HCIKHOJIPGF([In] GJCAMANDPFD<T> PCJCBHKDNLE);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct GJCAMANDPFD<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public readonly T NDIKGOAJKGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public readonly bool NBOJGLMJCJE;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x37CBC80", Offset = "0x37CB080", VA = "0x1837CBC80")]
	public GJCAMANDPFD(T OEPHFFNMBOB, bool EEFKJALFOCH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class MGFFMNPMJKI<T> : PMPNNJNGLDG<LOIHLOAACFC<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x3377370", Offset = "0x3376770", VA = "0x183377370")]
	public MGFFMNPMJKI(LOIHLOAACFC<T> MDOBDPHHONK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x3EFC890", Offset = "0x3EFBC90", VA = "0x183EFC890", Slot = "4")]
	public override bool HCIKHOJIPGF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class MLLGIJMKONH<T> : PMPNNJNGLDG<LOIHLOAACFC<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly OEKPKKKLCDL<T> DMNIIABCOPE;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x3F0E9F0", Offset = "0x3F0DDF0", VA = "0x183F0E9F0")]
	public MLLGIJMKONH(T NDIKGOAJKGJ, LOIHLOAACFC<T> MDOBDPHHONK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x33100F0", Offset = "0x330F4F0", VA = "0x1833100F0", Slot = "4")]
	public override bool HCIKHOJIPGF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class JJPEJHHGGBM<T> : PMPNNJNGLDG<JJPJPOJAOHH<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly GJCAMANDPFD<T> PCJCBHKDNLE;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x3BA4C60", Offset = "0x3BA4060", VA = "0x183BA4C60")]
	public JJPEJHHGGBM(T NDIKGOAJKGJ, bool EEFKJALFOCH, JJPJPOJAOHH<T> MDOBDPHHONK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x33100F0", Offset = "0x330F4F0", VA = "0x1833100F0", Slot = "4")]
	public override bool HCIKHOJIPGF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct HEHDHICKHKA<TData> where TData : notnull, JAEEHIPDHCI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public IEnumerable<TData> JBFDINPJGEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public bool PMMFFEIOCBM;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x38524A0", Offset = "0x38518A0", VA = "0x1838524A0")]
	public HEHDHICKHKA(IEnumerable<TData> OCCGOKCDBOH, bool IOELEPBOCKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct INGMNACJFJE<TData> where TData : notnull, JAEEHIPDHCI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public List<TData> JBFDINPJGEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public List<bool> MLPCNFEKFFA;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x39C3400", Offset = "0x39C2800", VA = "0x1839C3400")]
	public INGMNACJFJE(List<TData> OCCGOKCDBOH, List<bool> MNHKHBKKCIF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface JAEEHIPDHCI
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool OPJMJPDCDDJ
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
public interface JLGDDFMJHDB<TData> where TData : JAEEHIPDHCI
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HCIKHOJIPGF([In] HEHDHICKHKA<TData> OKMDECMDCPL);

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HCIKHOJIPGF([In] INGMNACJFJE<TData> OKMDECMDCPL);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface HOINPDIGOGH<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CHBHICPBDJJ(T NDIKGOAJKGJ);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class OEJBANNLNLH<TData> : PMPNNJNGLDG<JLGDDFMJHDB<TData>> where TData : notnull, JAEEHIPDHCI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly HEHDHICKHKA<TData> OKMDECMDCPL;

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x40CD3B0", Offset = "0x40CC7B0", VA = "0x1840CD3B0")]
	public OEJBANNLNLH(List<TData> MIJENKHJAPN, bool PMMFFEIOCBM, JLGDDFMJHDB<TData> MDOBDPHHONK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x33100F0", Offset = "0x330F4F0", VA = "0x1833100F0", Slot = "4")]
	public override bool HCIKHOJIPGF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class GOCHIOOJGLB<TData> : PMPNNJNGLDG<JLGDDFMJHDB<TData>> where TData : notnull, JAEEHIPDHCI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly INGMNACJFJE<TData> OKMDECMDCPL;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x37F0570", Offset = "0x37EF970", VA = "0x1837F0570")]
	public GOCHIOOJGLB(List<TData> MIJENKHJAPN, List<bool> MLPCNFEKFFA, JLGDDFMJHDB<TData> MDOBDPHHONK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x3349E10", Offset = "0x3349210", VA = "0x183349E10", Slot = "4")]
	public override bool HCIKHOJIPGF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface LNJHILHBNIB<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<ABMMODGFBCM> HCIKHOJIPGF(NKMNGIOFKEB<TData> GIEIIPEDDFJ);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public class HHOOLNJKFII<TData> : CLFJIEIHJCK<LNJHILHBNIB<TData>, ABMMODGFBCM> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct GPPPGNKANBP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public AsyncTaskMethodBuilder<ABMMODGFBCM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public HHOOLNJKFII<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<ABMMODGFBCM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x37F5090", Offset = "0x37F4490", VA = "0x1837F5090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x37F5380", Offset = "0x37F4780", VA = "0x1837F5380", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly NKMNGIOFKEB<TData> KCDJOKCCNAG;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x38600C0", Offset = "0x385F4C0", VA = "0x1838600C0")]
	public HHOOLNJKFII(TData IAHNOBIIIPO, IReadOnlyList<TData> ALJGHAIJJHO, bool NGCHDALJOPK, LNJHILHBNIB<TData> MDOBDPHHONK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x385FFC0", Offset = "0x385F3C0", VA = "0x18385FFC0", Slot = "4")]
	[AsyncStateMachine(typeof(HHOOLNJKFII<>.GPPPGNKANBP))]
	public override Task<ABMMODGFBCM> HCIKHOJIPGF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public struct NKMNGIOFKEB<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public TData NDKEHEJIKHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public IReadOnlyList<TData> CGCFBHCNHEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public bool GLMPIEPKEPE;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x3FD33B0", Offset = "0x3FD27B0", VA = "0x183FD33B0")]
	public NKMNGIOFKEB(TData IAHNOBIIIPO, IReadOnlyList<TData> ALJGHAIJJHO, bool NGCHDALJOPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface KLPBIFENEGM<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HCIKHOJIPGF([In] BCLCJEGLDDL<TData> HDFBCDHFFLJ);
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface GOLJAPKDCGI<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HCIKHOJIPGF([In] GMMGHPILFEJ<TData> HDFBCDHFFLJ);
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface MJKIPGDKFEF<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IJDOLGBIDFO([In] APELCAOENPE<TData> HDFBCDHFFLJ);

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IKAOOFJDKID();
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class FOLOIAHEMHN<TData> : PMPNNJNGLDG<KLPBIFENEGM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly BCLCJEGLDDL<TData> HDFBCDHFFLJ;

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x3706730", Offset = "0x3705B30", VA = "0x183706730")]
	public FOLOIAHEMHN(IEnumerable<TData> MIJENKHJAPN, FBOLEMHAAJA MAOKDDLICOE, OGGODFDFKLF GDFHEJJFPNA, float AJGLNFBCOJF, bool NGCHDALJOPK, KLPBIFENEGM<TData> MDOBDPHHONK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x33100F0", Offset = "0x330F4F0", VA = "0x1833100F0", Slot = "4")]
	public override bool HCIKHOJIPGF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class EOFNMKDJNBD<TData> : PMPNNJNGLDG<GOLJAPKDCGI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly GMMGHPILFEJ<TData> HDFBCDHFFLJ;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x336F5E0", Offset = "0x336E9E0", VA = "0x18336F5E0")]
	public EOFNMKDJNBD(TData[] MIJENKHJAPN, FBOLEMHAAJA[] MAOKDDLICOE, OGGODFDFKLF[] GDFHEJJFPNA, float[] AJGLNFBCOJF, GOLJAPKDCGI<TData> MDOBDPHHONK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x336F450", Offset = "0x336E850", VA = "0x18336F450", Slot = "4")]
	public override bool HCIKHOJIPGF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class LADFIOOOANF<TData> : PMPNNJNGLDG<MJKIPGDKFEF<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3377370", Offset = "0x3376770", VA = "0x183377370")]
	public LADFIOOOANF(MJKIPGDKFEF<TData> MDOBDPHHONK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x3D01940", Offset = "0x3D00D40", VA = "0x183D01940", Slot = "4")]
	public override bool HCIKHOJIPGF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class IOBHAHHLODA<TData> : PMPNNJNGLDG<MJKIPGDKFEF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly APELCAOENPE<TData> HDFBCDHFFLJ;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x39C3AE0", Offset = "0x39C2EE0", VA = "0x1839C3AE0")]
	public IOBHAHHLODA(IEnumerable<TData> MIJENKHJAPN, FBOLEMHAAJA MAOKDDLICOE, OGGODFDFKLF GDFHEJJFPNA, float AJGLNFBCOJF, MJKIPGDKFEF<TData> MDOBDPHHONK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x336F450", Offset = "0x336E850", VA = "0x18336F450", Slot = "4")]
	public override bool HCIKHOJIPGF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public struct BCLCJEGLDDL<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public IEnumerable<TData> JBFDINPJGEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public FBOLEMHAAJA IGJMEEEPHJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public OGGODFDFKLF KNLGFHNCIJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public float AJGLNFBCOJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public bool NGCHDALJOPK;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x47FDC60", Offset = "0x47FD060", VA = "0x1847FDC60")]
	public BCLCJEGLDDL(IEnumerable<TData> MIJENKHJAPN, FBOLEMHAAJA MAOKDDLICOE, OGGODFDFKLF GDFHEJJFPNA, float AJGLNFBCOJF, bool NGCHDALJOPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct GMMGHPILFEJ<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public TData[] JBFDINPJGEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public FBOLEMHAAJA[] IGJMEEEPHJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public OGGODFDFKLF[] KNLGFHNCIJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public float[] AJGLNFBCOJF;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x37E6A70", Offset = "0x37E5E70", VA = "0x1837E6A70")]
	public GMMGHPILFEJ(TData[] MIJENKHJAPN, FBOLEMHAAJA[] MAOKDDLICOE, OGGODFDFKLF[] GDFHEJJFPNA, float[] AJGLNFBCOJF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public struct APELCAOENPE<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public IEnumerable<TData> JBFDINPJGEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public FBOLEMHAAJA IGJMEEEPHJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public OGGODFDFKLF KNLGFHNCIJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public float AJGLNFBCOJF;

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3A2B550", Offset = "0x3A2A950", VA = "0x183A2B550")]
	public APELCAOENPE(IEnumerable<TData> MIJENKHJAPN, FBOLEMHAAJA MAOKDDLICOE, OGGODFDFKLF GDFHEJJFPNA, float AJGLNFBCOJF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public interface KENNFCEBPFD<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CADKEEJAJCN([In] HPOJAEBDOJK<TData> IMHCGNEOAIE);

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NKAOCGOILEE([In] HPOJAEBDOJK<TData> IMHCGNEOAIE);

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DGLDDNFLHLO([In] bool BOIJLBBIPDB);

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool GLGIKFHBKFF([In] HPOJAEBDOJK<TData> IMHCGNEOAIE);

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IPIBKIIBFFG();

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool MFGDJNABMNA([In] TData DHOCOKGPKLO);
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class JENIMDHJBPO<TData> : PMPNNJNGLDG<KENNFCEBPFD<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly HPOJAEBDOJK<TData> IMHCGNEOAIE;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x3B5B610", Offset = "0x3B5AA10", VA = "0x183B5B610")]
	public JENIMDHJBPO(List<TData> LEFKIOOOAEA, KENNFCEBPFD<TData> MDOBDPHHONK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x33100F0", Offset = "0x330F4F0", VA = "0x1833100F0", Slot = "4")]
	public override bool HCIKHOJIPGF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class CMEAFJBIAFP<TData> : PMPNNJNGLDG<KENNFCEBPFD<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3377370", Offset = "0x3376770", VA = "0x183377370")]
	public CMEAFJBIAFP(KENNFCEBPFD<TData> MDOBDPHHONK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x4BE31A0", Offset = "0x4BE25A0", VA = "0x184BE31A0", Slot = "4")]
	public override bool HCIKHOJIPGF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class PIGOKOHCIBA<TData> : PMPNNJNGLDG<KENNFCEBPFD<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly bool NGCHDALJOPK;

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x41A6170", Offset = "0x41A5570", VA = "0x1841A6170")]
	public PIGOKOHCIBA(bool NGCHDALJOPK, KENNFCEBPFD<TData> MDOBDPHHONK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x41A6110", Offset = "0x41A5510", VA = "0x1841A6110", Slot = "4")]
	public override bool HCIKHOJIPGF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class EHHECKNCEJH<TData> : PMPNNJNGLDG<KENNFCEBPFD<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly HPOJAEBDOJK<TData> IMHCGNEOAIE;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3349ED0", Offset = "0x33492D0", VA = "0x183349ED0")]
	public EHHECKNCEJH(List<TData> LEFKIOOOAEA, bool NGCHDALJOPK, KENNFCEBPFD<TData> MDOBDPHHONK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3349E10", Offset = "0x3349210", VA = "0x183349E10", Slot = "4")]
	public override bool HCIKHOJIPGF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class JNDKCBIPLHB<TData> : PMPNNJNGLDG<KENNFCEBPFD<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly TData DHOCOKGPKLO;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3BAC1D0", Offset = "0x3BAB5D0", VA = "0x183BAC1D0")]
	public JNDKCBIPLHB(TData DHOCOKGPKLO, KENNFCEBPFD<TData> MDOBDPHHONK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3BAC100", Offset = "0x3BAB500", VA = "0x183BAC100", Slot = "4")]
	public override bool HCIKHOJIPGF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class BEACMNKDEKP<TData> : PMPNNJNGLDG<KENNFCEBPFD<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly HPOJAEBDOJK<TData> IMHCGNEOAIE;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x4802DA0", Offset = "0x48021A0", VA = "0x184802DA0")]
	public BEACMNKDEKP(IEnumerable<TData> LEFKIOOOAEA, KENNFCEBPFD<TData> MDOBDPHHONK, bool NGCHDALJOPK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x4802C30", Offset = "0x4802030", VA = "0x184802C30", Slot = "4")]
	public override bool HCIKHOJIPGF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public struct HPOJAEBDOJK<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public IEnumerable<TData> JBFDINPJGEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public bool NGCHDALJOPK;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x38883E0", Offset = "0x38877E0", VA = "0x1838883E0")]
	public HPOJAEBDOJK(IEnumerable<TData> OCCGOKCDBOH, bool GKEJLDKMEBP = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public interface DNHHLBLIPND
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<ABMMODGFBCM> HCIKHOJIPGF(LNJHJEMIBFD MAOIKNHHKNB);
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class BKFDMAAIDKD : CLFJIEIHJCK<DNHHLBLIPND, ABMMODGFBCM>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private struct ICMMLMGOIIO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public AsyncTaskMethodBuilder<ABMMODGFBCM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public BKFDMAAIDKD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private TaskAwaiter<ABMMODGFBCM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x61F7280", Offset = "0x61F6680", VA = "0x1861F7280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x61F7500", Offset = "0x61F6900", VA = "0x1861F7500", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly LNJHJEMIBFD KNEDHCOIDPG;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x61F6540", Offset = "0x61F5940", VA = "0x1861F6540")]
	public BKFDMAAIDKD(bool NGCHDALJOPK, DNHHLBLIPND MDOBDPHHONK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x61F6450", Offset = "0x61F5850", VA = "0x1861F6450", Slot = "4")]
	[AsyncStateMachine(typeof(ICMMLMGOIIO))]
	public override Task<ABMMODGFBCM> HCIKHOJIPGF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct LNJHJEMIBFD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public bool GLMPIEPKEPE;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0xCB3550", Offset = "0xCB2950", VA = "0x180CB3550")]
	public LNJHJEMIBFD(bool NGCHDALJOPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public readonly struct GBIFLPBPMLC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly bool NBFAJBFOKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly bool KAILBEMLAOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly bool FHPLKKAFLOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public readonly bool NGCHDALJOPK;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x467CF60", Offset = "0x467C360", VA = "0x18467CF60")]
	public GBIFLPBPMLC(bool NBFAJBFOKKF, bool KAILBEMLAOM, bool FHPLKKAFLOA, bool NGCHDALJOPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x61F7040", Offset = "0x61F6440", VA = "0x1861F7040")]
	public GBIFLPBPMLC(bool KAILBEMLAOM, bool NGCHDALJOPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface OCGHNMHMBCI
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PGMIEMFCHFD(GBIFLPBPMLC HMAIJNBAGFJ);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MIBGEFOMCOD(GBIFLPBPMLC HMAIJNBAGFJ);
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class AFNMKANDKCN : PMPNNJNGLDG<OCGHNMHMBCI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly GBIFLPBPMLC HMAIJNBAGFJ;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x61F63C0", Offset = "0x61F57C0", VA = "0x1861F63C0")]
	public AFNMKANDKCN(bool KDNNBEIJOEO, bool KAILBEMLAOM, bool FHPLKKAFLOA, bool NGCHDALJOPK, OCGHNMHMBCI MDOBDPHHONK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x61F6370", Offset = "0x61F5770", VA = "0x1861F6370", Slot = "4")]
	public override bool HCIKHOJIPGF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class GHJEHKCOPBE : PMPNNJNGLDG<OCGHNMHMBCI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly GBIFLPBPMLC HMAIJNBAGFJ;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x61F70A0", Offset = "0x61F64A0", VA = "0x1861F70A0")]
	public GHJEHKCOPBE(bool KAILBEMLAOM, bool NGCHDALJOPK, OCGHNMHMBCI MDOBDPHHONK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x61F7050", Offset = "0x61F6450", VA = "0x1861F7050", Slot = "4")]
	public override bool HCIKHOJIPGF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public interface ALEGAJNPCFJ
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HCIKHOJIPGF([In] FOPKGKMGINH FJINIOKKNKB);
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class KOGGPCHJMJP : PMPNNJNGLDG<ALEGAJNPCFJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly FOPKGKMGINH FJINIOKKNKB;

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x61F7660", Offset = "0x61F6A60", VA = "0x1861F7660")]
	public KOGGPCHJMJP(Guid[] INFCOKJEIEB, Vector3[] HNBOOHGCJGM, Quaternion[] LJHCPGJAPBP, float[] HNGDKJFIDBL, Dictionary<Guid, Vector3> KDEAABOODFF, ALEGAJNPCFJ MDOBDPHHONK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x61F75B0", Offset = "0x61F69B0", VA = "0x1861F75B0", Slot = "4")]
	public override bool HCIKHOJIPGF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public interface CJNDLEJJDNA<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DDBHCLCKIFD([In] MLBHIBLKIGJ<TData> NIOMOBLKKHL);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IJDOLGBIDFO([In] MDCJKKIHMBG NNGDBKJBADP);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IJDOLGBIDFO([In] JHKIKLDKDHH NNGDBKJBADP);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IKAOOFJDKID();
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class LDJIGKIDIKA<TData> : PMPNNJNGLDG<CJNDLEJJDNA<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x3377370", Offset = "0x3376770", VA = "0x183377370")]
	public LDJIGKIDIKA(CJNDLEJJDNA<TData> MDOBDPHHONK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3D11950", Offset = "0x3D10D50", VA = "0x183D11950", Slot = "4")]
	public override bool HCIKHOJIPGF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class ONDCANIICHP<TData> : PMPNNJNGLDG<CJNDLEJJDNA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly MDCJKKIHMBG OBJPEAJLKAP;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x40FBB20", Offset = "0x40FAF20", VA = "0x1840FBB20")]
	public ONDCANIICHP(Vector3 DALBIPKPOHD, bool JOEFPMPPJJJ, CJNDLEJJDNA<TData> MDOBDPHHONK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x36F1D50", Offset = "0x36F1150", VA = "0x1836F1D50", Slot = "4")]
	public override bool HCIKHOJIPGF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class ABKJKDLIOLA<TData> : PMPNNJNGLDG<CJNDLEJJDNA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly JHKIKLDKDHH OBJPEAJLKAP;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x3777040", Offset = "0x3776440", VA = "0x183777040")]
	public ABKJKDLIOLA(Guid FNPIHLAMJLM, int PMLKPJNGBAD, Vector3 CJBHLOLHNJP, Quaternion APMJJPLCLEP, float BOGELENJKDJ, bool JOEFPMPPJJJ, CJNDLEJJDNA<TData> MDOBDPHHONK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x3776FE0", Offset = "0x37763E0", VA = "0x183776FE0", Slot = "4")]
	public override bool HCIKHOJIPGF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class EAAKHKKAOPD<TData> : PMPNNJNGLDG<CJNDLEJJDNA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly MLBHIBLKIGJ<TData> OBJPEAJLKAP;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x33101B0", Offset = "0x330F5B0", VA = "0x1833101B0")]
	public EAAKHKKAOPD(TData NDIKGOAJKGJ, bool NGCHDALJOPK, CJNDLEJJDNA<TData> MDOBDPHHONK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x33100F0", Offset = "0x330F4F0", VA = "0x1833100F0", Slot = "4")]
	public override bool HCIKHOJIPGF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public struct MDCJKKIHMBG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public readonly Vector3 DALBIPKPOHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly bool JOEFPMPPJJJ;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x61F7860", Offset = "0x61F6C60", VA = "0x1861F7860")]
	public MDCJKKIHMBG(Vector3 DALBIPKPOHD, bool JOEFPMPPJJJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public struct JHKIKLDKDHH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public readonly Guid FNPIHLAMJLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public readonly int PMLKPJNGBAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public readonly Vector3 CJBHLOLHNJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public readonly Quaternion APMJJPLCLEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public readonly float BOGELENJKDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public readonly bool JOEFPMPPJJJ;

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x61F7570", Offset = "0x61F6970", VA = "0x1861F7570")]
	public JHKIKLDKDHH(Guid FNPIHLAMJLM, int PMLKPJNGBAD, Vector3 CJBHLOLHNJP, Quaternion APMJJPLCLEP, float BOGELENJKDJ, bool JOEFPMPPJJJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public struct MLBHIBLKIGJ<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public readonly TData NDIKGOAJKGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public readonly bool NGCHDALJOPK;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x3F0CB80", Offset = "0x3F0BF80", VA = "0x183F0CB80")]
	public MLBHIBLKIGJ(TData NDIKGOAJKGJ, bool NGCHDALJOPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public interface MAIPNAGMLKI<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HCIKHOJIPGF([In] IBAADOMBMGG<TData> BECCAJLDJCE);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HCIKHOJIPGF([In] HPHDJLMCMNA<TData> BECCAJLDJCE);
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public interface BHANIPFGBFE<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DDBHCLCKIFD([In] EJNMCJLDDPG<TData> CMJNNICAEOG);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IJDOLGBIDFO([In] DBPMHLLIECH NNGDBKJBADP);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IKAOOFJDKID();
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class HNBLIFMOJDA<TData> : PMPNNJNGLDG<MAIPNAGMLKI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly IBAADOMBMGG<TData> BECCAJLDJCE;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x387CC30", Offset = "0x387C030", VA = "0x18387CC30")]
	public HNBLIFMOJDA(IEnumerable<TData> MIJENKHJAPN, Vector3 EDDDOBBDBNG, bool NGCHDALJOPK, MAIPNAGMLKI<TData> MDOBDPHHONK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x33100F0", Offset = "0x330F4F0", VA = "0x1833100F0", Slot = "4")]
	public override bool HCIKHOJIPGF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class AINHHMKJCJG<TData> : PMPNNJNGLDG<BHANIPFGBFE<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x3377370", Offset = "0x3376770", VA = "0x183377370")]
	public AINHHMKJCJG(BHANIPFGBFE<TData> MDOBDPHHONK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x387B4A0", Offset = "0x387A8A0", VA = "0x18387B4A0", Slot = "4")]
	public override bool HCIKHOJIPGF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class FPCLFCEHHKO<TData> : PMPNNJNGLDG<BHANIPFGBFE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly EJNMCJLDDPG<TData> BECCAJLDJCE;

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x3706FD0", Offset = "0x37063D0", VA = "0x183706FD0")]
	public FPCLFCEHHKO(IEnumerable<TData> MIJENKHJAPN, bool NGCHDALJOPK, BHANIPFGBFE<TData> MDOBDPHHONK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x33100F0", Offset = "0x330F4F0", VA = "0x1833100F0", Slot = "4")]
	public override bool HCIKHOJIPGF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class NLDCHFEAENH<TData> : PMPNNJNGLDG<MAIPNAGMLKI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly HPHDJLMCMNA<TData> BECCAJLDJCE;

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x3FD5A50", Offset = "0x3FD4E50", VA = "0x183FD5A50")]
	public NLDCHFEAENH(IEnumerable<TData> MIJENKHJAPN, Vector3 ILAPGHLIJHH, MDOFMJDKEJN LFENPAKGLJJ, bool NGCHDALJOPK, MAIPNAGMLKI<TData> MDOBDPHHONK, Space CBGFBOEMOLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3F02A40", Offset = "0x3F01E40", VA = "0x183F02A40", Slot = "4")]
	public override bool HCIKHOJIPGF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class KCEPADHHCHL<TData> : PMPNNJNGLDG<BHANIPFGBFE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly DBPMHLLIECH BECCAJLDJCE;

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x3C728D0", Offset = "0x3C71CD0", VA = "0x183C728D0")]
	public KCEPADHHCHL(Vector3 EDDDOBBDBNG, BHANIPFGBFE<TData> MDOBDPHHONK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x36F1D50", Offset = "0x36F1150", VA = "0x1836F1D50", Slot = "4")]
	public override bool HCIKHOJIPGF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct IBAADOMBMGG<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public readonly IEnumerable<TData> MIJENKHJAPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public readonly Vector3 EDDDOBBDBNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public readonly bool NGCHDALJOPK;

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x3990E00", Offset = "0x3990200", VA = "0x183990E00")]
	public IBAADOMBMGG(IEnumerable<TData> MIJENKHJAPN, Vector3 EDDDOBBDBNG, bool NGCHDALJOPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct EJNMCJLDDPG<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public readonly IEnumerable<TData> MIJENKHJAPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public readonly bool NGCHDALJOPK;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x334E350", Offset = "0x334D750", VA = "0x18334E350")]
	public EJNMCJLDDPG(IEnumerable<TData> MIJENKHJAPN, bool NGCHDALJOPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct HPHDJLMCMNA<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public readonly IEnumerable<TData> MIJENKHJAPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public readonly Vector3 ILAPGHLIJHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public readonly MDOFMJDKEJN LFENPAKGLJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly bool NGCHDALJOPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public readonly Space CBGFBOEMOLH;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x38880F0", Offset = "0x38874F0", VA = "0x1838880F0")]
	public HPHDJLMCMNA(IEnumerable<TData> MIJENKHJAPN, Vector3 ILAPGHLIJHH, MDOFMJDKEJN LFENPAKGLJJ, bool NGCHDALJOPK, Space CBGFBOEMOLH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct DBPMHLLIECH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly Vector3 EDDDOBBDBNG;

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x1F5DB30", Offset = "0x1F5CF30", VA = "0x181F5DB30")]
	public DBPMHLLIECH(Vector3 EDDDOBBDBNG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public enum MDOFMJDKEJN
{
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	XYZ,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	X_only,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	Y_only,
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	Z_only
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public interface DOBNPGGGDDF
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HCIKHOJIPGF([In] GEIGHECEKII BNDMHNKNIOE);
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public class OMPCDFLAFJM : PMPNNJNGLDG<DOBNPGGGDDF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly GEIGHECEKII BNDMHNKNIOE;

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x61F79D0", Offset = "0x61F6DD0", VA = "0x1861F79D0")]
	public OMPCDFLAFJM(bool NGCHDALJOPK, DOBNPGGGDDF MDOBDPHHONK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x61F7920", Offset = "0x61F6D20", VA = "0x1861F7920", Slot = "4")]
	public override bool HCIKHOJIPGF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public readonly struct GEIGHECEKII
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public readonly bool NGCHDALJOPK;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0xCB3550", Offset = "0xCB2950", VA = "0x180CB3550")]
	public GEIGHECEKII(bool NGCHDALJOPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public interface AFCKDKJDOGI<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HCIKHOJIPGF([In] JILBLDCKLLP<TData> DLAONJNBPFG);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HCIKHOJIPGF([In] GIMIOBCLJFF<TData> DLAONJNBPFG);
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public interface BOBIDLKNIDA<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DDBHCLCKIFD([In] OBJJDCMONEP<TData> NIOMOBLKKHL);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IJDOLGBIDFO([In] OPIPNFOFKNB NNGDBKJBADP);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IKAOOFJDKID();
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class KKHEOKKHJMB<TData> : PMPNNJNGLDG<AFCKDKJDOGI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly JILBLDCKLLP<TData> DLAONJNBPFG;

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x3C7D4B0", Offset = "0x3C7C8B0", VA = "0x183C7D4B0")]
	public KKHEOKKHJMB(IEnumerable<TData> MIJENKHJAPN, Quaternion EDDDOBBDBNG, Vector3? NOAOANJBLLG, bool KNDCAPCFDCA, bool NGCHDALJOPK, AFCKDKJDOGI<TData> MDOBDPHHONK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x33100F0", Offset = "0x330F4F0", VA = "0x1833100F0", Slot = "4")]
	public override bool HCIKHOJIPGF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class HMAGEFNPNKO<TData> : PMPNNJNGLDG<BOBIDLKNIDA<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x3377370", Offset = "0x3376770", VA = "0x183377370")]
	public HMAGEFNPNKO(BOBIDLKNIDA<TData> MDOBDPHHONK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x387B4A0", Offset = "0x387A8A0", VA = "0x18387B4A0", Slot = "4")]
	public override bool HCIKHOJIPGF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class FNGGCNLBDMN<TData> : PMPNNJNGLDG<BOBIDLKNIDA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly OBJJDCMONEP<TData> DLAONJNBPFG;

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x36F9220", Offset = "0x36F8620", VA = "0x1836F9220")]
	public FNGGCNLBDMN(IEnumerable<TData> MIJENKHJAPN, bool NGCHDALJOPK, BOBIDLKNIDA<TData> MDOBDPHHONK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x33100F0", Offset = "0x330F4F0", VA = "0x1833100F0", Slot = "4")]
	public override bool HCIKHOJIPGF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class CIABENIEJAI<TData> : PMPNNJNGLDG<AFCKDKJDOGI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly GIMIOBCLJFF<TData> DLAONJNBPFG;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x4AEDF70", Offset = "0x4AED370", VA = "0x184AEDF70")]
	public CIABENIEJAI(IEnumerable<TData> MIJENKHJAPN, Quaternion KKGMPONNBDA, MDOFMJDKEJN HBPIOCEOLOO, Vector3? NOAOANJBLLG, bool KNDCAPCFDCA, bool NGCHDALJOPK, Space CBGFBOEMOLH, AFCKDKJDOGI<TData> MDOBDPHHONK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x3F02A40", Offset = "0x3F01E40", VA = "0x183F02A40", Slot = "4")]
	public override bool HCIKHOJIPGF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class FLIPLMAABPE<TData> : PMPNNJNGLDG<BOBIDLKNIDA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly OPIPNFOFKNB DLAONJNBPFG;

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x36F1DB0", Offset = "0x36F11B0", VA = "0x1836F1DB0")]
	public FLIPLMAABPE(Quaternion EDDDOBBDBNG, Vector3? NOAOANJBLLG, bool KNDCAPCFDCA, BOBIDLKNIDA<TData> MDOBDPHHONK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x36F1D50", Offset = "0x36F1150", VA = "0x1836F1D50", Slot = "4")]
	public override bool HCIKHOJIPGF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public struct JILBLDCKLLP<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public readonly IEnumerable<TData> MIJENKHJAPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public readonly Quaternion EDDDOBBDBNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public readonly Vector3? NOAOANJBLLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public readonly bool KNDCAPCFDCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public readonly bool NGCHDALJOPK;

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x3BA2310", Offset = "0x3BA1710", VA = "0x183BA2310")]
	public JILBLDCKLLP(IEnumerable<TData> MIJENKHJAPN, Quaternion EDDDOBBDBNG, Vector3? NOAOANJBLLG, bool KNDCAPCFDCA, bool NGCHDALJOPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public struct OBJJDCMONEP<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public readonly IEnumerable<TData> MIJENKHJAPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public readonly bool NGCHDALJOPK;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x40C5C50", Offset = "0x40C5050", VA = "0x1840C5C50")]
	public OBJJDCMONEP(IEnumerable<TData> MIJENKHJAPN, bool NGCHDALJOPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public struct GIMIOBCLJFF<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly IEnumerable<TData> MIJENKHJAPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public readonly Quaternion KKGMPONNBDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public readonly MDOFMJDKEJN HBPIOCEOLOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public readonly Vector3? NOAOANJBLLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public readonly bool KNDCAPCFDCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public readonly bool NGCHDALJOPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public readonly Space CBGFBOEMOLH;

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x37CAE60", Offset = "0x37CA260", VA = "0x1837CAE60")]
	public GIMIOBCLJFF(IEnumerable<TData> MIJENKHJAPN, Quaternion KKGMPONNBDA, MDOFMJDKEJN HBPIOCEOLOO, Vector3? NOAOANJBLLG, bool KNDCAPCFDCA, bool NGCHDALJOPK, Space CBGFBOEMOLH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public struct OPIPNFOFKNB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public readonly Quaternion EDDDOBBDBNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public readonly Vector3? NOAOANJBLLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public readonly bool KNDCAPCFDCA;

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x4648780", Offset = "0x4647B80", VA = "0x184648780")]
	public OPIPNFOFKNB(Quaternion EDDDOBBDBNG, Vector3? NOAOANJBLLG, bool KNDCAPCFDCA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public interface APIJMJAKEPP<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DDBHCLCKIFD([In] HHPKAJCIKMG<TData> NIOMOBLKKHL);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IJDOLGBIDFO([In] FPMDDCGGGPA NNGDBKJBADP);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IJDOLGBIDFO([In] LFNCFCAMNEK NNGDBKJBADP);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IJDOLGBIDFO([In] EDMANEDICHC NNGDBKJBADP);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IKAOOFJDKID();
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public class BLFAKKLBNPH<TData> : PMPNNJNGLDG<APIJMJAKEPP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly EDMANEDICHC GLDIPLEJBLA;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x4830EE0", Offset = "0x48302E0", VA = "0x184830EE0")]
	public BLFAKKLBNPH(Vector3 PNOGDOLKHNA, float NHGFEEIKBPI, Vector3 NOAOANJBLLG, bool OEHBMHADLGF, bool FBOPOHGABFL, APIJMJAKEPP<TData> MDOBDPHHONK, Space CBGFBOEMOLH = Space.Self)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x4830E80", Offset = "0x4830280", VA = "0x184830E80", Slot = "4")]
	public override bool HCIKHOJIPGF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public class EPECMBEFJKL<TData> : PMPNNJNGLDG<APIJMJAKEPP<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x3377370", Offset = "0x3376770", VA = "0x183377370")]
	public EPECMBEFJKL(APIJMJAKEPP<TData> MDOBDPHHONK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x3377320", Offset = "0x3376720", VA = "0x183377320", Slot = "4")]
	public override bool HCIKHOJIPGF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class NMHDJJKJOID<TData> : PMPNNJNGLDG<APIJMJAKEPP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly HHPKAJCIKMG<TData> GLDIPLEJBLA;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x3FDBC80", Offset = "0x3FDB080", VA = "0x183FDBC80")]
	public NMHDJJKJOID(IEnumerable<TData> MIJENKHJAPN, bool NGCHDALJOPK, APIJMJAKEPP<TData> MDOBDPHHONK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x33100F0", Offset = "0x330F4F0", VA = "0x1833100F0", Slot = "4")]
	public override bool HCIKHOJIPGF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class FCJDBMKOFMD<TData> : PMPNNJNGLDG<APIJMJAKEPP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly LFNCFCAMNEK GLDIPLEJBLA;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x36B5320", Offset = "0x36B4720", VA = "0x1836B5320")]
	public FCJDBMKOFMD(float OALCABFMPFK, bool BOCFGONAKCM, Vector3 NOAOANJBLLG, APIJMJAKEPP<TData> MDOBDPHHONK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x36B5250", Offset = "0x36B4650", VA = "0x1836B5250", Slot = "4")]
	public override bool HCIKHOJIPGF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class HKFMLHEAIPF<TData> : PMPNNJNGLDG<APIJMJAKEPP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly FPMDDCGGGPA GLDIPLEJBLA;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x386E230", Offset = "0x386D630", VA = "0x18386E230")]
	public HKFMLHEAIPF(float NHGFEEIKBPI, Vector3 NOAOANJBLLG, APIJMJAKEPP<TData> MDOBDPHHONK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x36F1D50", Offset = "0x36F1150", VA = "0x1836F1D50", Slot = "4")]
	public override bool HCIKHOJIPGF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public struct EDMANEDICHC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public readonly Vector3 PNOGDOLKHNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public readonly float NHGFEEIKBPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public readonly Vector3 NOAOANJBLLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public readonly bool JOEFPMPPJJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public readonly Space CBGFBOEMOLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public readonly bool FBOPOHGABFL;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x61F6970", Offset = "0x61F5D70", VA = "0x1861F6970")]
	public EDMANEDICHC(Vector3 PNOGDOLKHNA, float NHGFEEIKBPI, Vector3 NOAOANJBLLG, bool JOEFPMPPJJJ, bool PPOMNEFCJPC, Space CBGFBOEMOLH = Space.Self)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public struct HHPKAJCIKMG<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public readonly IEnumerable<TData> MIJENKHJAPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public readonly bool NGCHDALJOPK;

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x38602C0", Offset = "0x385F6C0", VA = "0x1838602C0")]
	public HHPKAJCIKMG(IEnumerable<TData> MIJENKHJAPN, bool NGCHDALJOPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct LFNCFCAMNEK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public readonly float OALCABFMPFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public readonly bool BOCFGONAKCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public readonly Vector3 NOAOANJBLLG;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x61F7840", Offset = "0x61F6C40", VA = "0x1861F7840")]
	public LFNCFCAMNEK(float OALCABFMPFK, bool BOCFGONAKCM, Vector3 NOAOANJBLLG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public struct FPMDDCGGGPA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public readonly float NHGFEEIKBPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public readonly Vector3 NOAOANJBLLG;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x461C260", Offset = "0x461B660", VA = "0x18461C260")]
	public FPMDDCGGGPA(float NHGFEEIKBPI, Vector3 NOAOANJBLLG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct FOPKGKMGINH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public readonly Guid[] MIJENKHJAPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public readonly bool CJCFMCOJDEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public readonly bool JMLJLCHMBIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public readonly bool GPIHGJPHBJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public readonly Vector3[] HNBOOHGCJGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public readonly Quaternion[] LJHCPGJAPBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public readonly float[] HNGDKJFIDBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly Dictionary<Guid, Vector3> KDEAABOODFF;

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x61F6DB0", Offset = "0x61F61B0", VA = "0x1861F6DB0")]
	public FOPKGKMGINH(Guid[] INFCOKJEIEB, Vector3[] HNBOOHGCJGM, Quaternion[] LJHCPGJAPBP, float[] HNGDKJFIDBL, Dictionary<Guid, Vector3> KDEAABOODFF, bool CJCFMCOJDEK = true, bool JMLJLCHMBIN = true, bool GPIHGJPHBJC = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x61F6BE0", Offset = "0x61F5FE0", VA = "0x1861F6BE0")]
	private static void PNKCGANIPLG(Dictionary<Guid, Vector3> KDEAABOODFF, int DNIBCKOLCFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public static class DMFNAADPHPJ
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	private struct IFJKKBMIDAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public bool IHMNKOBMFKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public BNDLKDEPBDF LHCAJBKLMCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public BNDLKDEPBDF BAPGDAGAEPI;
	}

	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private static IFJKKBMIDAM NMLJBHOJHOD;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static CancellationToken IEBLPLMIONB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x61F6950", Offset = "0x61F5D50", VA = "0x1861F6950")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	internal static BNDLKDEPBDF LHCAJBKLMCB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x61F68B0", Offset = "0x61F5CB0", VA = "0x1861F68B0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x61F6840", Offset = "0x61F5C40", VA = "0x1861F6840")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x61F65A0", Offset = "0x61F59A0", VA = "0x1861F65A0")]
	[AMCIKKJLCIB(FDMHFCDINAO.Room, HENHDGEOMOC.None)]
	private static void DNPDJCFPNKL(BNDLKDEPBDF FFIAABONDPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x61F66F0", Offset = "0x61F5AF0", VA = "0x1861F66F0")]
	public static void HIHHBKCGMJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x61F66A0", Offset = "0x61F5AA0", VA = "0x1861F66A0")]
	private static BNDLKDEPBDF GDAHDFMENAM(BNDLKDEPBDF PGBANCNKIFL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public static class AHOJJHLMBOI
{
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public enum IMPKICKKLGI
	{
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		ICreationContextObject,
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		Guid
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x2DB4500", Offset = "0x2DB3900", VA = "0x182DB4500")]
	public static void AJFNJFFBPPD<T>(T DLKEBALDMPC, IMPKICKKLGI NBMJAHOKHAI) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x2DB4640", Offset = "0x2DB3A40", VA = "0x182DB4640")]
	public static void AJFNJFFBPPD<T>(T DLKEBALDMPC) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x2DB4820", Offset = "0x2DB3C20", VA = "0x182DB4820")]
	public static void MLJAONBABCB<T>(T DLKEBALDMPC) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x2DB4780", Offset = "0x2DB3B80", VA = "0x182DB4780")]
	public static T EBLDKANKNCA<T>(IMPKICKKLGI NBMJAHOKHAI) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x2DB4930", Offset = "0x2DB3D30", VA = "0x182DB4930")]
	public static bool OPHEKCAINKH<T>(IMPKICKKLGI NBMJAHOKHAI, T KAPKJNNGOPO, [Out] T NGPCBAGGDOL) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x2DB46E0", Offset = "0x2DB3AE0", VA = "0x182DB46E0")]
	public static bool AJLNMJOBPEO<T>(IMPKICKKLGI NBMJAHOKHAI) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x2DB46A0", Offset = "0x2DB3AA0", VA = "0x182DB46A0")]
	public static T EBLDKANKNCA<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x2DB4890", Offset = "0x2DB3C90", VA = "0x182DB4890")]
	public static bool OPHEKCAINKH<T>(T KAPKJNNGOPO, [Out] T NGPCBAGGDOL) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x2DB46A0", Offset = "0x2DB3AA0", VA = "0x182DB46A0")]
	public static bool AJLNMJOBPEO<T>() where T : class
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
internal static class EGHGIBIMPLA
{
	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x61F69B0", Offset = "0x61F5DB0", VA = "0x1861F69B0")]
	public static void LGMKJMCJCJD(IEnumerable IEDLEJPMCOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x2688900", Offset = "0x2687D00", VA = "0x182688900")]
	public static void LGMKJMCJCJD<T>(T[] KGECIFKDBHF) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x26889F0", Offset = "0x2687DF0", VA = "0x1826889F0")]
	public static void LGMKJMCJCJD<T>(T EKIHNFGMJAF) where T : notnull, Enum
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
