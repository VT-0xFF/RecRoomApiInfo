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
		[Cpp2IlInjected.Address(RVA = "0x79B610", Offset = "0x79AA10", VA = "0x18079B610")]
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
		[Cpp2IlInjected.Address(RVA = "0x5E3ADE0", Offset = "0x5E3A1E0", VA = "0x185E3ADE0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x79C170", Offset = "0x79B570", VA = "0x18079C170")]
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
		[Cpp2IlInjected.Address(RVA = "0x79C1B0", Offset = "0x79B5B0", VA = "0x18079C1B0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface KCNEHBMHMBA<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ClearHoverTarget(KKJFJLIMGLO DILMPJMFJDD);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool SetHoverTarget(TData OPJDDCOPPHE, Collider ALIDPDAOCOK, KKJFJLIMGLO DILMPJMFJDD, [Optional] JOCLECOGMBP? OCMCPBDCEMH);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool TryGetHoverTarget([Out] TData OPJDDCOPPHE);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface LIEFLKOEFIL<TData> : MLINCGCBMIK, PLGLOMLDMFC<TData>, LNOPHFFBJGO<TData>, LHNBHOACIEM<TData>, MNLBPAEOGJP, IIEOFNANMHP<TData>, MABNADAEKGM, AFFBBLMMPHC
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface IIEOFNANMHP<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 EIGNGOOKPHI, Vector3 MOLHDBHIKBL, float MEOGMCFNILK, [Out] T GELEGOCJKPK, [Out] Vector3 LOHPPNNCIGG, [Out] Collider ALIDPDAOCOK);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 EIGNGOOKPHI, Vector3 MOLHDBHIKBL, float CGPNIAHOCPP, float MEOGMCFNILK, T[] JCCPMNHEDJK, [Out] Vector3 NPEOOPPNJGN, [Out] Collider MBBOBPBFPOF);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 EIGNGOOKPHI, float CGPNIAHOCPP, Vector3 MPLLJBCOAKB, T[] JCCPMNHEDJK);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface MLINCGCBMIK
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Bounds GFPMLLCIBMK
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Transform LOIDPNLDDMI
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Bounds DPCGMHHJFGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Transform FFPNMEDHCPH
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Vector3 IFKAINBEJFI
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void SetSelectionBoundsDirty(bool JAJNKMIKGEA = true, int CJICPAHEHAC = 0);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ShouldHideSelectionBoundsPreview(bool NHJNEAPJEFD, object NOEAHPPKHNC);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface AFFBBLMMPHC
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	FCJKIAIKOOM DPHCIPLOMCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface LHNBHOACIEM<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool LJELKLBLLAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	int CKLJPFBMDCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	IEnumerable<TData> CIFFIENFMNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData EDPLJLLHNEJ);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData EDPLJLLHNEJ);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface PLGLOMLDMFC<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T ECLCDMJMICA, [Optional] JOCLECOGMBP? IFAKMPHDBCJ, bool OMFIDGCDMKA = true);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int APAKJDHFMCK, IEnumerable<T> NNCDPJOIJPE, bool OMFIDGCDMKA = true);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int APAKJDHFMCK, IEnumerable<T> NNCDPJOIJPE, JOCLECOGMBP IFAKMPHDBCJ, bool OMFIDGCDMKA = true);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface MABNADAEKGM
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface MNLBPAEOGJP
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool EFIPFNIEFKH
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool ILLPFDIILFI
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool MFNAMJOBGDE
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool MFGKHPEEJAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class KKBHHGFLGBP<TReceiver> : LGPNEEPCMJH<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x30E3F50", Offset = "0x30E3350", VA = "0x1830E3F50")]
	public KKBHHGFLGBP(TReceiver DDJGFIBIACD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public abstract class DFMPCMCKNHH<TReceiver, TFromTask> : LGPNEEPCMJH<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x30E3F50", Offset = "0x30E3350", VA = "0x1830E3F50")]
	public DFMPCMCKNHH(TReceiver DDJGFIBIACD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class LGPNEEPCMJH<TReceiver, TFromExecute> where TReceiver : notnull where TFromExecute : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	protected TReceiver DDJGFIBIACD;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3A90C80", Offset = "0x3A90080", VA = "0x183A90C80")]
	public LGPNEEPCMJH(TReceiver DDJGFIBIACD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute FHGLKLGOEFB();
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class NKPKONBLNME<TReceiver, TResult> : LGPNEEPCMJH<TReceiver, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x30E3F50", Offset = "0x30E3350", VA = "0x1830E3F50")]
	public NKPKONBLNME(TReceiver DDJGFIBIACD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct GCNIFNNJCJG<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public TGroup KELPFMDOJGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public TData IKFKBJDCAOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public IEnumerable<TData> BEBNMDLEBJL;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x19B45D0", Offset = "0x19B39D0", VA = "0x1819B45D0")]
	public GCNIFNNJCJG(TGroup NGDPFBEHGKP, TData DIGKPNNANHA, IEnumerable<TData> PABLMNKGJOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct LMOPFMFMKCD<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public TGroup KELPFMDOJGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public IEnumerable<TData> BEBNMDLEBJL;

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x82CA80", Offset = "0x82BE80", VA = "0x18082CA80")]
	public LMOPFMFMKCD(TGroup NGDPFBEHGKP, IEnumerable<TData> PABLMNKGJOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct NOJEHBIMMCG<TGroup> where TGroup : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public TGroup KELPFMDOJGC;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x871B00", Offset = "0x870F00", VA = "0x180871B00")]
	public NOJEHBIMMCG(TGroup NGDPFBEHGKP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct OOLGKOGFKIP<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public IEnumerable<TData> BEBNMDLEBJL;

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x871B00", Offset = "0x870F00", VA = "0x180871B00")]
	public OOLGKOGFKIP(IEnumerable<TData> PABLMNKGJOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface IOMJLBNFOLN<TGroup, TData>
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PCFOHALKECO HJFIBMKEJNG(GCNIFNNJCJG<TGroup, TData> PDFLJJLJMDD);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	PCFOHALKECO APNEKBHALBA(GCNIFNNJCJG<TGroup, TData> PDFLJJLJMDD);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	PCFOHALKECO NLGMMJKAEOF(LMOPFMFMKCD<TGroup, TData> PDFLJJLJMDD);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	PCFOHALKECO ENNEKPHCADB(NOJEHBIMMCG<TGroup> PDFLJJLJMDD);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface JAEFBDKKHAD<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<PCFOHALKECO> HJFIBMKEJNG(OOLGKOGFKIP<TData> PDFLJJLJMDD);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class DLNEEINBINK<TGroup, TData> : NKPKONBLNME<IOMJLBNFOLN<TGroup, TData>, PCFOHALKECO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly LMOPFMFMKCD<TGroup, TData> PDFLJJLJMDD;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4DE4740", Offset = "0x4DE3B40", VA = "0x184DE4740")]
	public DLNEEINBINK(TGroup NGDPFBEHGKP, IEnumerable<TData> PABLMNKGJOH, IOMJLBNFOLN<TGroup, TData> DDJGFIBIACD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4DE4670", Offset = "0x4DE3A70", VA = "0x184DE4670", Slot = "4")]
	public override PCFOHALKECO FHGLKLGOEFB()
	{
		return default(PCFOHALKECO);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class HGENDPDEACO<TGroup, TData> : NKPKONBLNME<IOMJLBNFOLN<TGroup, TData>, PCFOHALKECO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly GCNIFNNJCJG<TGroup, TData> PDFLJJLJMDD;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x35DFD90", Offset = "0x35DF190", VA = "0x1835DFD90")]
	public HGENDPDEACO(TGroup NGDPFBEHGKP, TData JBGLEFNOGFL, IEnumerable<TData> PABLMNKGJOH, IOMJLBNFOLN<TGroup, TData> DDJGFIBIACD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x35DFCB0", Offset = "0x35DF0B0", VA = "0x1835DFCB0", Slot = "4")]
	public override PCFOHALKECO FHGLKLGOEFB()
	{
		return default(PCFOHALKECO);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class INBIHGPIGPK<TGroup, TData> : NKPKONBLNME<IOMJLBNFOLN<TGroup, TData>, PCFOHALKECO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly NOJEHBIMMCG<TGroup> PDFLJJLJMDD;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3609DE0", Offset = "0x36091E0", VA = "0x183609DE0")]
	public INBIHGPIGPK(TGroup NGDPFBEHGKP, IOMJLBNFOLN<TGroup, TData> DDJGFIBIACD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x37692D0", Offset = "0x37686D0", VA = "0x1837692D0", Slot = "4")]
	public override PCFOHALKECO FHGLKLGOEFB()
	{
		return default(PCFOHALKECO);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class BBJHGKNIPDB<TGroup, TData> : NKPKONBLNME<IOMJLBNFOLN<TGroup, TData>, PCFOHALKECO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly GCNIFNNJCJG<TGroup, TData> PDFLJJLJMDD;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x35DFD90", Offset = "0x35DF190", VA = "0x1835DFD90")]
	public BBJHGKNIPDB(TGroup NGDPFBEHGKP, TData DIGKPNNANHA, IEnumerable<TData> PABLMNKGJOH, IOMJLBNFOLN<TGroup, TData> DDJGFIBIACD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x453EA10", Offset = "0x453DE10", VA = "0x18453EA10", Slot = "4")]
	public override PCFOHALKECO FHGLKLGOEFB()
	{
		return default(PCFOHALKECO);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class HKILEGIFNFJ<TData> : DFMPCMCKNHH<JAEFBDKKHAD<TData>, PCFOHALKECO> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct FJAAEEAOBEO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AsyncTaskMethodBuilder<PCFOHALKECO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public HKILEGIFNFJ<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private TaskAwaiter<PCFOHALKECO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3470910", Offset = "0x346FD10", VA = "0x183470910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3470BB0", Offset = "0x346FFB0", VA = "0x183470BB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private OOLGKOGFKIP<TData> PDFLJJLJMDD;

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3609DE0", Offset = "0x36091E0", VA = "0x183609DE0")]
	public HKILEGIFNFJ(IEnumerable<TData> BNGOJFELOJG, JAEFBDKKHAD<TData> DDJGFIBIACD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3609CE0", Offset = "0x36090E0", VA = "0x183609CE0", Slot = "4")]
	[AsyncStateMachine(typeof(HKILEGIFNFJ<>.FJAAEEAOBEO))]
	public override Task<PCFOHALKECO> FHGLKLGOEFB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct JKFMKBGECOL<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public TNode HMIIEMENPAN;

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x39055E0", Offset = "0x39049E0", VA = "0x1839055E0")]
	public JKFMKBGECOL(TNode HMIIEMENPAN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct AEFGLEOAFBK<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public TNode CGGIFLKCAJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public FAMFHNAFIEF FOFBILBIBJG;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x35593E0", Offset = "0x35587E0", VA = "0x1835593E0")]
	public AEFGLEOAFBK(TNode CGGIFLKCAJJ, FAMFHNAFIEF FOFBILBIBJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface KGFBDIOFCJN<TNode>
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BPKMHMFEJFK([In] JKFMKBGECOL<TNode> EADHFLILLLC);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MMOJNMENFBJ([In] AEFGLEOAFBK<TNode> BEPPCNFCMDM);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BKGNHAFGNNM();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class NGCBICCICDM<TNode> : KKBHHGFLGBP<KGFBDIOFCJN<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x30E3F50", Offset = "0x30E3350", VA = "0x1830E3F50")]
	public NGCBICCICDM(KGFBDIOFCJN<TNode> DDJGFIBIACD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3A90DA0", Offset = "0x3A901A0", VA = "0x183A90DA0", Slot = "4")]
	public override bool FHGLKLGOEFB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class PEPDDBAFBGL<TNode> : KKBHHGFLGBP<KGFBDIOFCJN<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly AEFGLEOAFBK<TNode> BEPPCNFCMDM;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3EC8B10", Offset = "0x3EC7F10", VA = "0x183EC8B10")]
	public PEPDDBAFBGL(TNode CGGIFLKCAJJ, FAMFHNAFIEF FOFBILBIBJG, KGFBDIOFCJN<TNode> DDJGFIBIACD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3EC8A40", Offset = "0x3EC7E40", VA = "0x183EC8A40", Slot = "4")]
	public override bool FHGLKLGOEFB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class COHFDEAJFDP<TNode> : KKBHHGFLGBP<KGFBDIOFCJN<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly JKFMKBGECOL<TNode> EADHFLILLLC;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4914910", Offset = "0x4913D10", VA = "0x184914910")]
	public COHFDEAJFDP(TNode HBEOMACHNNA, KGFBDIOFCJN<TNode> DDJGFIBIACD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3580BB0", Offset = "0x357FFB0", VA = "0x183580BB0", Slot = "4")]
	public override bool FHGLKLGOEFB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct HPIEJLOBPLP<TSpawnInfo> where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public TSpawnInfo KDNLDFJKJEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public Vector3 JCADPOBEOPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public Quaternion KCLDFAAPKAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public float HHEJIMODBII;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0xDEE650", Offset = "0xDEDA50", VA = "0x180DEE650")]
	public HPIEJLOBPLP(TSpawnInfo KDNLDFJKJEA, Vector3 JCADPOBEOPO, Quaternion KCLDFAAPKAB, float HHEJIMODBII)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface LADFKABEJIJ<TSpawnType, TSpawnInfo>
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> AFIGMLCIOAK([In] HPIEJLOBPLP<TSpawnInfo> NPEANAEDHKN, CancellationToken EANFAKGANNH);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class LGDJDJNLBDP<TSpawnType, TSpawnInfo> : DFMPCMCKNHH<LADFKABEJIJ<TSpawnType, TSpawnInfo>, TSpawnType> where TSpawnType : notnull where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly HPIEJLOBPLP<TSpawnInfo> IFILEFKNBLN;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3A8D990", Offset = "0x3A8CD90", VA = "0x183A8D990")]
	public LGDJDJNLBDP(TSpawnInfo BAOHOHCKMPK, Vector3 JCADPOBEOPO, Quaternion KCLDFAAPKAB, float HHEJIMODBII, LADFKABEJIJ<TSpawnType, TSpawnInfo> DDJGFIBIACD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3A8D7B0", Offset = "0x3A8CBB0", VA = "0x183A8D7B0", Slot = "4")]
	public override Task<TSpawnType> FHGLKLGOEFB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public readonly struct KLIGLJCJHNL<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly IEnumerable<TData> BEBNMDLEBJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly bool AEOAGFPBCHL;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x39C53B0", Offset = "0x39C47B0", VA = "0x1839C53B0")]
	public KLIGLJCJHNL(IEnumerable<TData> PABLMNKGJOH, bool MLEFOMDEBKM = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface ECICBHFMBAP<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<PCFOHALKECO> LEHAGEAJMHD([In] KLIGLJCJHNL<TData> ALEKPBKNIFA, CancellationToken EANFAKGANNH);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class OBKNECIBEDA<TData> : DFMPCMCKNHH<ECICBHFMBAP<TData>, PCFOHALKECO> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly KLIGLJCJHNL<TData> PBEADOKNMDG;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3DE87F0", Offset = "0x3DE7BF0", VA = "0x183DE87F0")]
	public OBKNECIBEDA(IEnumerable<TData> PABLMNKGJOH, bool MLEFOMDEBKM, ECICBHFMBAP<TData> DDJGFIBIACD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3A8D7B0", Offset = "0x3A8CBB0", VA = "0x183A8D7B0", Slot = "4")]
	public override Task<PCFOHALKECO> FHGLKLGOEFB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct GLMNPPNMPOO<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly T OPJDDCOPPHE;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3553850", Offset = "0x3552C50", VA = "0x183553850")]
	public GLMNPPNMPOO(T FBHMKPFPPFA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface BHJMFHHBPPG<T>
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BPKMHMFEJFK([In] GLMNPPNMPOO<T> LHLOLEAKDPE);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MMOJNMENFBJ();
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface NMHBFPFNLON<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FHGLKLGOEFB([In] COKEPIJGEJA<T> FMPNGJHAKHO);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public struct COKEPIJGEJA<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly T OPJDDCOPPHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly bool LPEEMLGGIND;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x4914D20", Offset = "0x4914120", VA = "0x184914D20")]
	public COKEPIJGEJA(T FBHMKPFPPFA, bool FCMDNDAJOGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class JMLLIBDLLPK<T> : KKBHHGFLGBP<BHJMFHHBPPG<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x30E3F50", Offset = "0x30E3350", VA = "0x1830E3F50")]
	public JMLLIBDLLPK(BHJMFHHBPPG<T> DDJGFIBIACD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3912B30", Offset = "0x3911F30", VA = "0x183912B30", Slot = "4")]
	public override bool FHGLKLGOEFB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class NGEJHCMEABM<T> : KKBHHGFLGBP<BHJMFHHBPPG<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly GLMNPPNMPOO<T> LHLOLEAKDPE;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3D26250", Offset = "0x3D25650", VA = "0x183D26250")]
	public NGEJHCMEABM(T OPJDDCOPPHE, BHJMFHHBPPG<T> DDJGFIBIACD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3580BB0", Offset = "0x357FFB0", VA = "0x183580BB0", Slot = "4")]
	public override bool FHGLKLGOEFB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class JOCGJNJELCB<T> : KKBHHGFLGBP<NMHBFPFNLON<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly COKEPIJGEJA<T> FMPNGJHAKHO;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3913F00", Offset = "0x3913300", VA = "0x183913F00")]
	public JOCGJNJELCB(T OPJDDCOPPHE, bool FCMDNDAJOGP, NMHBFPFNLON<T> DDJGFIBIACD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3580BB0", Offset = "0x357FFB0", VA = "0x183580BB0", Slot = "4")]
	public override bool FHGLKLGOEFB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct NDNCNCEAICC<TData> where TData : notnull, IBKEJLELNNH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public IEnumerable<TData> BEBNMDLEBJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public bool LDDIIFKHAGN;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3D20DE0", Offset = "0x3D201E0", VA = "0x183D20DE0")]
	public NDNCNCEAICC(IEnumerable<TData> JLHELGFCJOF, bool DAOJCMICFFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct JCOOINOCEDC<TData> where TData : notnull, IBKEJLELNNH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public List<TData> BEBNMDLEBJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public List<bool> OFDHLEBHGKH;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x38E56A0", Offset = "0x38E4AA0", VA = "0x1838E56A0")]
	public JCOOINOCEDC(List<TData> JLHELGFCJOF, List<bool> BFONIPEPOMM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface IBKEJLELNNH
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool MLILDEKGJLJ
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
public interface LBKNJKFKNBN<TData> where TData : IBKEJLELNNH
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FHGLKLGOEFB([In] NDNCNCEAICC<TData> LHPGDIEBOJB);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FHGLKLGOEFB([In] JCOOINOCEDC<TData> LHPGDIEBOJB);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class GOKKPNNADAA<TData> : KKBHHGFLGBP<LBKNJKFKNBN<TData>> where TData : notnull, IBKEJLELNNH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly NDNCNCEAICC<TData> LHPGDIEBOJB;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3580C70", Offset = "0x3580070", VA = "0x183580C70")]
	public GOKKPNNADAA(List<TData> PABLMNKGJOH, bool LDDIIFKHAGN, LBKNJKFKNBN<TData> DDJGFIBIACD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3580BB0", Offset = "0x357FFB0", VA = "0x183580BB0", Slot = "4")]
	public override bool FHGLKLGOEFB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class DPLIKMKBNHD<TData> : KKBHHGFLGBP<LBKNJKFKNBN<TData>> where TData : notnull, IBKEJLELNNH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly JCOOINOCEDC<TData> LHPGDIEBOJB;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x4DECF60", Offset = "0x4DEC360", VA = "0x184DECF60")]
	public DPLIKMKBNHD(List<TData> PABLMNKGJOH, List<bool> OFDHLEBHGKH, LBKNJKFKNBN<TData> DDJGFIBIACD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x39C4240", Offset = "0x39C3640", VA = "0x1839C4240", Slot = "4")]
	public override bool FHGLKLGOEFB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface LMGKJONOOLA : IBKEJLELNNH
{
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface PFEHFJFIPJA<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<PCFOHALKECO> FHGLKLGOEFB(CAGMDGDKOMJ<TData> EABIIOIIGGP);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class GEJKDHMIOBF<TData> : DFMPCMCKNHH<PFEHFJFIPJA<TData>, PCFOHALKECO> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct GFBNGJGJEID : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public AsyncTaskMethodBuilder<PCFOHALKECO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public GEJKDHMIOBF<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private TaskAwaiter<PCFOHALKECO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x3539DE0", Offset = "0x35391E0", VA = "0x183539DE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x353A0D0", Offset = "0x35394D0", VA = "0x18353A0D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly CAGMDGDKOMJ<TData> DGFMCJLNNPB;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x3531CA0", Offset = "0x35310A0", VA = "0x183531CA0")]
	public GEJKDHMIOBF(TData HKHCIKPDECJ, IReadOnlyList<TData> IEMCKOMAFAC, bool MLEFOMDEBKM, PFEHFJFIPJA<TData> DDJGFIBIACD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x3531BA0", Offset = "0x3530FA0", VA = "0x183531BA0", Slot = "4")]
	[AsyncStateMachine(typeof(GEJKDHMIOBF<>.GFBNGJGJEID))]
	public override Task<PCFOHALKECO> FHGLKLGOEFB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public struct CAGMDGDKOMJ<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public TData AGLJLHDBCOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public IReadOnlyList<TData> PGAPCBFFKNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public bool AEOAGFPBCHL;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x43E28F0", Offset = "0x43E1CF0", VA = "0x1843E28F0")]
	public CAGMDGDKOMJ(TData HKHCIKPDECJ, IReadOnlyList<TData> IEMCKOMAFAC, bool MLEFOMDEBKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface DAGDCKMBOAI<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FHGLKLGOEFB([In] OOHOFNGEOEJ<TData> KJFPJDGBCNM);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface GBMAFJDNANN<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FHGLKLGOEFB([In] NOKOKNIMMKE<TData> KJFPJDGBCNM);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface CJGCFIJIBOF<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DFEBAFCDOCM([In] JBKNEECPNNJ<TData> KJFPJDGBCNM);

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MMOJNMENFBJ();
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class HPGLKNMBFDJ<TData> : KKBHHGFLGBP<DAGDCKMBOAI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly OOHOFNGEOEJ<TData> KJFPJDGBCNM;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x361FC40", Offset = "0x361F040", VA = "0x18361FC40")]
	public HPGLKNMBFDJ(IEnumerable<TData> PABLMNKGJOH, LNOFJHOKDOO DDJLPLIEHMO, DIEEJLIEICO OLONCOMGJHB, float IPBNNOPMDEB, bool MLEFOMDEBKM, DAGDCKMBOAI<TData> DDJGFIBIACD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x3580BB0", Offset = "0x357FFB0", VA = "0x183580BB0", Slot = "4")]
	public override bool FHGLKLGOEFB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public class OLADGKGNFHB<TData> : KKBHHGFLGBP<GBMAFJDNANN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly NOKOKNIMMKE<TData> KJFPJDGBCNM;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x3E16210", Offset = "0x3E15610", VA = "0x183E16210")]
	public OLADGKGNFHB(TData[] PABLMNKGJOH, LNOFJHOKDOO[] DDJLPLIEHMO, DIEEJLIEICO[] OLONCOMGJHB, float[] IPBNNOPMDEB, GBMAFJDNANN<TData> DDJGFIBIACD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x3E16150", Offset = "0x3E15550", VA = "0x183E16150", Slot = "4")]
	public override bool FHGLKLGOEFB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class MGFKNIBHHPJ<TData> : KKBHHGFLGBP<CJGCFIJIBOF<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x30E3F50", Offset = "0x30E3350", VA = "0x1830E3F50")]
	public MGFKNIBHHPJ(CJGCFIJIBOF<TData> DDJGFIBIACD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x3CC3110", Offset = "0x3CC2510", VA = "0x183CC3110", Slot = "4")]
	public override bool FHGLKLGOEFB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class OPEPAIKLGMF<TData> : KKBHHGFLGBP<CJGCFIJIBOF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly JBKNEECPNNJ<TData> KJFPJDGBCNM;

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x3E1E920", Offset = "0x3E1DD20", VA = "0x183E1E920")]
	public OPEPAIKLGMF(IEnumerable<TData> PABLMNKGJOH, LNOFJHOKDOO DDJLPLIEHMO, DIEEJLIEICO OLONCOMGJHB, float IPBNNOPMDEB, CJGCFIJIBOF<TData> DDJGFIBIACD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x3E16150", Offset = "0x3E15550", VA = "0x183E16150", Slot = "4")]
	public override bool FHGLKLGOEFB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public struct OOHOFNGEOEJ<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public IEnumerable<TData> BEBNMDLEBJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public LNOFJHOKDOO EGNDENEKJIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public DIEEJLIEICO LFJDLLMANNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public float IPBNNOPMDEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public bool MLEFOMDEBKM;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x3E1BC30", Offset = "0x3E1B030", VA = "0x183E1BC30")]
	public OOHOFNGEOEJ(IEnumerable<TData> PABLMNKGJOH, LNOFJHOKDOO DDJLPLIEHMO, DIEEJLIEICO OLONCOMGJHB, float IPBNNOPMDEB, bool MLEFOMDEBKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public struct NOKOKNIMMKE<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public TData[] BEBNMDLEBJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public LNOFJHOKDOO[] EGNDENEKJIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public DIEEJLIEICO[] LFJDLLMANNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public float[] IPBNNOPMDEB;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x3D34D40", Offset = "0x3D34140", VA = "0x183D34D40")]
	public NOKOKNIMMKE(TData[] PABLMNKGJOH, LNOFJHOKDOO[] DDJLPLIEHMO, DIEEJLIEICO[] OLONCOMGJHB, float[] IPBNNOPMDEB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public struct JBKNEECPNNJ<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public IEnumerable<TData> BEBNMDLEBJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public LNOFJHOKDOO EGNDENEKJIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public DIEEJLIEICO LFJDLLMANNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public float IPBNNOPMDEB;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x38DF7A0", Offset = "0x38DEBA0", VA = "0x1838DF7A0")]
	public JBKNEECPNNJ(IEnumerable<TData> PABLMNKGJOH, LNOFJHOKDOO DDJLPLIEHMO, DIEEJLIEICO OLONCOMGJHB, float IPBNNOPMDEB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface LNOPHFFBJGO<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NLGMMJKAEOF([In] GDEPBIKFPGB<TData> ALEKPBKNIFA);

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ENNEKPHCADB([In] GDEPBIKFPGB<TData> ALEKPBKNIFA);

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BEEMLOMGMKP([In] bool KDOLHFPAFKM);

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool BLAGAFMJKEA([In] GDEPBIKFPGB<TData> ALEKPBKNIFA);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BNKCBJHCBHP();

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool INCEMPEBOLB([In] TData BIJGJMKKAJP);
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class PNBODODGCJF<TData> : KKBHHGFLGBP<LNOPHFFBJGO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly GDEPBIKFPGB<TData> ALEKPBKNIFA;

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x3F22050", Offset = "0x3F21450", VA = "0x183F22050")]
	public PNBODODGCJF(List<TData> JAAOHPHONMJ, LNOPHFFBJGO<TData> DDJGFIBIACD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x3F21FF0", Offset = "0x3F213F0", VA = "0x183F21FF0", Slot = "4")]
	public override bool FHGLKLGOEFB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class BBIOGPEMKMK<TData> : KKBHHGFLGBP<LNOPHFFBJGO<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x30E3F50", Offset = "0x30E3350", VA = "0x1830E3F50")]
	public BBIOGPEMKMK(LNOPHFFBJGO<TData> DDJGFIBIACD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x453E9C0", Offset = "0x453DDC0", VA = "0x18453E9C0", Slot = "4")]
	public override bool FHGLKLGOEFB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class CFFPDLNCHPC<TData> : KKBHHGFLGBP<LNOPHFFBJGO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly bool MLEFOMDEBKM;

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x4806F70", Offset = "0x4806370", VA = "0x184806F70")]
	public CFFPDLNCHPC(bool MLEFOMDEBKM, LNOPHFFBJGO<TData> DDJGFIBIACD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x4806F10", Offset = "0x4806310", VA = "0x184806F10", Slot = "4")]
	public override bool FHGLKLGOEFB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class KIMCABLCDCJ<TData> : KKBHHGFLGBP<LNOPHFFBJGO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly GDEPBIKFPGB<TData> ALEKPBKNIFA;

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x39C4300", Offset = "0x39C3700", VA = "0x1839C4300")]
	public KIMCABLCDCJ(List<TData> JAAOHPHONMJ, bool MLEFOMDEBKM, LNOPHFFBJGO<TData> DDJGFIBIACD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x39C4240", Offset = "0x39C3640", VA = "0x1839C4240", Slot = "4")]
	public override bool FHGLKLGOEFB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public class AOJJLOOLAML<TData> : KKBHHGFLGBP<LNOPHFFBJGO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly TData BIJGJMKKAJP;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x366F9D0", Offset = "0x366EDD0", VA = "0x18366F9D0")]
	public AOJJLOOLAML(TData BIJGJMKKAJP, LNOPHFFBJGO<TData> DDJGFIBIACD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x366F850", Offset = "0x366EC50", VA = "0x18366F850", Slot = "4")]
	public override bool FHGLKLGOEFB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class PKPAKGOEEGD<TData> : KKBHHGFLGBP<LNOPHFFBJGO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly GDEPBIKFPGB<TData> ALEKPBKNIFA;

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3F1F2A0", Offset = "0x3F1E6A0", VA = "0x183F1F2A0")]
	public PKPAKGOEEGD(List<TData> JAAOHPHONMJ, LNOPHFFBJGO<TData> DDJGFIBIACD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3F1F240", Offset = "0x3F1E640", VA = "0x183F1F240", Slot = "4")]
	public override bool FHGLKLGOEFB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public struct GDEPBIKFPGB<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public IEnumerable<TData> BEBNMDLEBJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public bool MLEFOMDEBKM;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x352A360", Offset = "0x3529760", VA = "0x18352A360")]
	public GDEPBIKFPGB(IEnumerable<TData> JLHELGFCJOF, bool KFBNEOFFDDK = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface EPEPDABIDCB
{
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<PCFOHALKECO> FHGLKLGOEFB(CEGENHOABBA DFKLCHGPGLA);
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class LBBKBHHGNFK : DFMPCMCKNHH<EPEPDABIDCB, PCFOHALKECO>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private struct JLNFNKFLADJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public AsyncTaskMethodBuilder<PCFOHALKECO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public LBBKBHHGNFK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private TaskAwaiter<PCFOHALKECO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x5E3A980", Offset = "0x5E39D80", VA = "0x185E3A980", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x5E3AC00", Offset = "0x5E3A000", VA = "0x185E3AC00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly CEGENHOABBA MLFKPDNNDGK;

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5E3AD60", Offset = "0x5E3A160", VA = "0x185E3AD60")]
	public LBBKBHHGNFK(bool MLEFOMDEBKM, EPEPDABIDCB DDJGFIBIACD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5E3AC70", Offset = "0x5E3A070", VA = "0x185E3AC70", Slot = "4")]
	[AsyncStateMachine(typeof(JLNFNKFLADJ))]
	public override Task<PCFOHALKECO> FHGLKLGOEFB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public struct CEGENHOABBA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public bool AEOAGFPBCHL;

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0xBDD970", Offset = "0xBDCD70", VA = "0x180BDD970")]
	public CEGENHOABBA(bool MLEFOMDEBKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface ABDLPOPNCAN<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BPKMHMFEJFK([In] NKPJFFEMLDG<TData> EADHFLILLLC);

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DFEBAFCDOCM([In] MMCHCLKMDIM DJICAKIOGHE);

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DFEBAFCDOCM([In] GHFEICKNCLM DJICAKIOGHE);

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MMOJNMENFBJ();
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class OBLNDIBEFHN<TData> : KKBHHGFLGBP<ABDLPOPNCAN<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x30E3F50", Offset = "0x30E3350", VA = "0x1830E3F50")]
	public OBLNDIBEFHN(ABDLPOPNCAN<TData> DDJGFIBIACD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3DE8880", Offset = "0x3DE7C80", VA = "0x183DE8880", Slot = "4")]
	public override bool FHGLKLGOEFB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class LIOABBAFFME<TData> : KKBHHGFLGBP<ABDLPOPNCAN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly MMCHCLKMDIM DMDOGKELJMO;

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3A993E0", Offset = "0x3A987E0", VA = "0x183A993E0")]
	public LIOABBAFFME(Vector3 CFLMCJICLBN, bool JANGJPLNEHB, ABDLPOPNCAN<TData> DDJGFIBIACD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3602840", Offset = "0x3601C40", VA = "0x183602840", Slot = "4")]
	public override bool FHGLKLGOEFB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class KCKAMAJPCNH<TData> : KKBHHGFLGBP<ABDLPOPNCAN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly GHFEICKNCLM DMDOGKELJMO;

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3961A30", Offset = "0x3960E30", VA = "0x183961A30")]
	public KCKAMAJPCNH(Guid GGDAHDHMNIP, int DIENMHDGFGP, Vector3 JCADPOBEOPO, Quaternion KCLDFAAPKAB, float PFKJICHCDMG, bool JANGJPLNEHB, ABDLPOPNCAN<TData> DDJGFIBIACD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x39619D0", Offset = "0x3960DD0", VA = "0x1839619D0", Slot = "4")]
	public override bool FHGLKLGOEFB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class MKDDMJLOIII<TData> : KKBHHGFLGBP<ABDLPOPNCAN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly NKPJFFEMLDG<TData> DMDOGKELJMO;

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3CCAAF0", Offset = "0x3CC9EF0", VA = "0x183CCAAF0")]
	public MKDDMJLOIII(TData OPJDDCOPPHE, bool MLEFOMDEBKM, ABDLPOPNCAN<TData> DDJGFIBIACD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3580BB0", Offset = "0x357FFB0", VA = "0x183580BB0", Slot = "4")]
	public override bool FHGLKLGOEFB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public struct MMCHCLKMDIM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly Vector3 CFLMCJICLBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly bool JANGJPLNEHB;

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x5E3ADC0", Offset = "0x5E3A1C0", VA = "0x185E3ADC0")]
	public MMCHCLKMDIM(Vector3 CFLMCJICLBN, bool JANGJPLNEHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct GHFEICKNCLM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly Guid GGDAHDHMNIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly int DIENMHDGFGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly Vector3 JCADPOBEOPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly Quaternion KCLDFAAPKAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly float PFKJICHCDMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly bool JANGJPLNEHB;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x5E3A710", Offset = "0x5E39B10", VA = "0x185E3A710")]
	public GHFEICKNCLM(Guid GGDAHDHMNIP, int DIENMHDGFGP, Vector3 JCADPOBEOPO, Quaternion KCLDFAAPKAB, float PFKJICHCDMG, bool JANGJPLNEHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public struct NKPJFFEMLDG<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly TData OPJDDCOPPHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly bool MLEFOMDEBKM;

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3D30BF0", Offset = "0x3D2FFF0", VA = "0x183D30BF0")]
	public NKPJFFEMLDG(TData OPJDDCOPPHE, bool MLEFOMDEBKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface CKKCPNEFJHA<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FHGLKLGOEFB([In] MMJDMJJCLGA<TData> BOLDCAGILOL);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FHGLKLGOEFB([In] PCMMOOPOFNK<TData> BOLDCAGILOL);
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public interface LPMFMHDHBHO<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BPKMHMFEJFK([In] BPONMAFBELI<TData> DCCEILGFBFD);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DFEBAFCDOCM([In] BJIBHDDPIEJ DJICAKIOGHE);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MMOJNMENFBJ();
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class DDMGKKDAOON<TData> : KKBHHGFLGBP<CKKCPNEFJHA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly MMJDMJJCLGA<TData> BOLDCAGILOL;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4DB9B20", Offset = "0x4DB8F20", VA = "0x184DB9B20")]
	public DDMGKKDAOON(IEnumerable<TData> PABLMNKGJOH, Vector3 DONKNPELNOA, bool MLEFOMDEBKM, CKKCPNEFJHA<TData> DDJGFIBIACD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x3580BB0", Offset = "0x357FFB0", VA = "0x183580BB0", Slot = "4")]
	public override bool FHGLKLGOEFB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class COELLHJCEDG<TData> : KKBHHGFLGBP<LPMFMHDHBHO<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x30E3F50", Offset = "0x30E3350", VA = "0x1830E3F50")]
	public COELLHJCEDG(LPMFMHDHBHO<TData> DDJGFIBIACD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x3A90DA0", Offset = "0x3A901A0", VA = "0x183A90DA0", Slot = "4")]
	public override bool FHGLKLGOEFB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class HMMDMLDLOKA<TData> : KKBHHGFLGBP<LPMFMHDHBHO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly BPONMAFBELI<TData> BOLDCAGILOL;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x3618D90", Offset = "0x3618190", VA = "0x183618D90")]
	public HMMDMLDLOKA(IEnumerable<TData> PABLMNKGJOH, bool MLEFOMDEBKM, LPMFMHDHBHO<TData> DDJGFIBIACD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x3580BB0", Offset = "0x357FFB0", VA = "0x183580BB0", Slot = "4")]
	public override bool FHGLKLGOEFB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class PHKEDCHFHMC<TData> : KKBHHGFLGBP<CKKCPNEFJHA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly PCMMOOPOFNK<TData> BOLDCAGILOL;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x3F14940", Offset = "0x3F13D40", VA = "0x183F14940")]
	public PHKEDCHFHMC(IEnumerable<TData> PABLMNKGJOH, Vector3 HLDDMBGPPHN, HIEBHJJKAMM IMHNCPCAMEI, bool MLEFOMDEBKM, CKKCPNEFJHA<TData> DDJGFIBIACD, Space FMJNCFCCJFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3EC8A40", Offset = "0x3EC7E40", VA = "0x183EC8A40", Slot = "4")]
	public override bool FHGLKLGOEFB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class HPAKEBJNDFG<TData> : KKBHHGFLGBP<LPMFMHDHBHO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly BJIBHDDPIEJ BOLDCAGILOL;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x361FB70", Offset = "0x361EF70", VA = "0x18361FB70")]
	public HPAKEBJNDFG(Vector3 DONKNPELNOA, LPMFMHDHBHO<TData> DDJGFIBIACD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x3602840", Offset = "0x3601C40", VA = "0x183602840", Slot = "4")]
	public override bool FHGLKLGOEFB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public struct MMJDMJJCLGA<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public readonly IEnumerable<TData> PABLMNKGJOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public readonly Vector3 DONKNPELNOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public readonly bool MLEFOMDEBKM;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x3CE0190", Offset = "0x3CDF590", VA = "0x183CE0190")]
	public MMJDMJJCLGA(IEnumerable<TData> PABLMNKGJOH, Vector3 DONKNPELNOA, bool MLEFOMDEBKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public struct BPONMAFBELI<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public readonly IEnumerable<TData> PABLMNKGJOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly bool MLEFOMDEBKM;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x45900A0", Offset = "0x458F4A0", VA = "0x1845900A0")]
	public BPONMAFBELI(IEnumerable<TData> PABLMNKGJOH, bool MLEFOMDEBKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public struct PCMMOOPOFNK<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public readonly IEnumerable<TData> PABLMNKGJOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public readonly Vector3 HLDDMBGPPHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public readonly HIEBHJJKAMM IMHNCPCAMEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public readonly bool MLEFOMDEBKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public readonly Space FMJNCFCCJFK;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x3EC1B60", Offset = "0x3EC0F60", VA = "0x183EC1B60")]
	public PCMMOOPOFNK(IEnumerable<TData> PABLMNKGJOH, Vector3 HLDDMBGPPHN, HIEBHJJKAMM IMHNCPCAMEI, bool MLEFOMDEBKM, Space FMJNCFCCJFK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public struct BJIBHDDPIEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public readonly Vector3 DONKNPELNOA;

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x201F740", Offset = "0x201EB40", VA = "0x18201F740")]
	public BJIBHDDPIEJ(Vector3 DONKNPELNOA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public enum HIEBHJJKAMM
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
public interface LMKENFDJCGJ<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FHGLKLGOEFB([In] LMCHHKBJAAN<TData> OECCFPMEEMC);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FHGLKLGOEFB([In] HMENHNAJAEO<TData> OECCFPMEEMC);
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public interface NBBIFPELELB<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BPKMHMFEJFK([In] LMBMIMCHGAC<TData> EADHFLILLLC);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DFEBAFCDOCM([In] MGEGMKCOFCM DJICAKIOGHE);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MMOJNMENFBJ();
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public class LEEEOECDMBI<TData> : KKBHHGFLGBP<LMKENFDJCGJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly LMCHHKBJAAN<TData> OECCFPMEEMC;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x3A72630", Offset = "0x3A71A30", VA = "0x183A72630")]
	public LEEEOECDMBI(IEnumerable<TData> PABLMNKGJOH, Quaternion DONKNPELNOA, Vector3? CJFJPLAMBCB, bool IEBLJKKPGCL, bool MLEFOMDEBKM, LMKENFDJCGJ<TData> DDJGFIBIACD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x3580BB0", Offset = "0x357FFB0", VA = "0x183580BB0", Slot = "4")]
	public override bool FHGLKLGOEFB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class LHFBKLGIEPI<TData> : KKBHHGFLGBP<NBBIFPELELB<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x30E3F50", Offset = "0x30E3350", VA = "0x1830E3F50")]
	public LHFBKLGIEPI(NBBIFPELELB<TData> DDJGFIBIACD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x3A90DA0", Offset = "0x3A901A0", VA = "0x183A90DA0", Slot = "4")]
	public override bool FHGLKLGOEFB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class HPHEKFBMKJD<TData> : KKBHHGFLGBP<NBBIFPELELB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly LMBMIMCHGAC<TData> OECCFPMEEMC;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x361FD20", Offset = "0x361F120", VA = "0x18361FD20")]
	public HPHEKFBMKJD(IEnumerable<TData> PABLMNKGJOH, bool MLEFOMDEBKM, NBBIFPELELB<TData> DDJGFIBIACD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x3580BB0", Offset = "0x357FFB0", VA = "0x183580BB0", Slot = "4")]
	public override bool FHGLKLGOEFB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class DHBLKBHPCCI<TData> : KKBHHGFLGBP<LMKENFDJCGJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly HMENHNAJAEO<TData> OECCFPMEEMC;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x4DCF500", Offset = "0x4DCE900", VA = "0x184DCF500")]
	public DHBLKBHPCCI(IEnumerable<TData> PABLMNKGJOH, Quaternion LKCCACCAEKI, HIEBHJJKAMM JKBKFEPHKON, Vector3? CJFJPLAMBCB, bool IEBLJKKPGCL, bool MLEFOMDEBKM, Space FMJNCFCCJFK, LMKENFDJCGJ<TData> DDJGFIBIACD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x3EC8A40", Offset = "0x3EC7E40", VA = "0x183EC8A40", Slot = "4")]
	public override bool FHGLKLGOEFB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class LBPIBLMHOGP<TData> : KKBHHGFLGBP<NBBIFPELELB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly MGEGMKCOFCM OECCFPMEEMC;

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x3A69400", Offset = "0x3A68800", VA = "0x183A69400")]
	public LBPIBLMHOGP(Quaternion DONKNPELNOA, Vector3? CJFJPLAMBCB, bool IEBLJKKPGCL, NBBIFPELELB<TData> DDJGFIBIACD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x3602840", Offset = "0x3601C40", VA = "0x183602840", Slot = "4")]
	public override bool FHGLKLGOEFB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public struct LMCHHKBJAAN<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public readonly IEnumerable<TData> PABLMNKGJOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public readonly Quaternion DONKNPELNOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public readonly Vector3? CJFJPLAMBCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public readonly bool IEBLJKKPGCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public readonly bool MLEFOMDEBKM;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x3AA9C30", Offset = "0x3AA9030", VA = "0x183AA9C30")]
	public LMCHHKBJAAN(IEnumerable<TData> PABLMNKGJOH, Quaternion DONKNPELNOA, Vector3? CJFJPLAMBCB, bool IEBLJKKPGCL, bool MLEFOMDEBKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct LMBMIMCHGAC<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly IEnumerable<TData> PABLMNKGJOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public readonly bool MLEFOMDEBKM;

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x3AA95F0", Offset = "0x3AA89F0", VA = "0x183AA95F0")]
	public LMBMIMCHGAC(IEnumerable<TData> PABLMNKGJOH, bool MLEFOMDEBKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct HMENHNAJAEO<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly IEnumerable<TData> PABLMNKGJOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public readonly Quaternion LKCCACCAEKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public readonly HIEBHJJKAMM JKBKFEPHKON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public readonly Vector3? CJFJPLAMBCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public readonly bool IEBLJKKPGCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public readonly bool MLEFOMDEBKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public readonly Space FMJNCFCCJFK;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x3612B20", Offset = "0x3611F20", VA = "0x183612B20")]
	public HMENHNAJAEO(IEnumerable<TData> PABLMNKGJOH, Quaternion LKCCACCAEKI, HIEBHJJKAMM JKBKFEPHKON, Vector3? CJFJPLAMBCB, bool IEBLJKKPGCL, bool MLEFOMDEBKM, Space FMJNCFCCJFK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct MGEGMKCOFCM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public readonly Quaternion DONKNPELNOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public readonly Vector3? CJFJPLAMBCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public readonly bool IEBLJKKPGCL;

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x43C1660", Offset = "0x43C0A60", VA = "0x1843C1660")]
	public MGEGMKCOFCM(Quaternion DONKNPELNOA, Vector3? CJFJPLAMBCB, bool IEBLJKKPGCL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public interface OBHDAKENJAK<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BPKMHMFEJFK([In] EFPFGAFAMPF<TData> EADHFLILLLC);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DFEBAFCDOCM([In] MMKDKIKKBMO DJICAKIOGHE);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DFEBAFCDOCM([In] ELHDALAIHCA DJICAKIOGHE);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DFEBAFCDOCM([In] BBOOKFHGDLJ DJICAKIOGHE);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool MMOJNMENFBJ();
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public class LBKLEGCJHON<TData> : KKBHHGFLGBP<OBHDAKENJAK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly BBOOKFHGDLJ GNPPFOIGEPC;

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3A692F0", Offset = "0x3A686F0", VA = "0x183A692F0")]
	public LBKLEGCJHON(Vector3 DFHBLFHGGJO, float KMHALLDFFIA, Vector3 CJFJPLAMBCB, bool ANLAAHLKPFP, bool PPJCAHNDCII, OBHDAKENJAK<TData> DDJGFIBIACD, Space FMJNCFCCJFK = Space.Self)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x3A69290", Offset = "0x3A68690", VA = "0x183A69290", Slot = "4")]
	public override bool FHGLKLGOEFB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public class ELBBJGEHLKE<TData> : KKBHHGFLGBP<OBHDAKENJAK<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x30E3F50", Offset = "0x30E3350", VA = "0x1830E3F50")]
	public ELBBJGEHLKE(OBHDAKENJAK<TData> DDJGFIBIACD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x3102710", Offset = "0x3101B10", VA = "0x183102710", Slot = "4")]
	public override bool FHGLKLGOEFB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public class IHDIHOOCJOP<TData> : KKBHHGFLGBP<OBHDAKENJAK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly EFPFGAFAMPF<TData> GNPPFOIGEPC;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x3759CB0", Offset = "0x37590B0", VA = "0x183759CB0")]
	public IHDIHOOCJOP(IEnumerable<TData> PABLMNKGJOH, bool MLEFOMDEBKM, OBHDAKENJAK<TData> DDJGFIBIACD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x3580BB0", Offset = "0x357FFB0", VA = "0x183580BB0", Slot = "4")]
	public override bool FHGLKLGOEFB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class KDHIFFKGHOO<TData> : KKBHHGFLGBP<OBHDAKENJAK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly ELHDALAIHCA GNPPFOIGEPC;

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x396B4F0", Offset = "0x396A8F0", VA = "0x18396B4F0")]
	public KDHIFFKGHOO(float POLGFCHEFFJ, bool LKAKOHAEMPH, Vector3 CJFJPLAMBCB, OBHDAKENJAK<TData> DDJGFIBIACD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x396B420", Offset = "0x396A820", VA = "0x18396B420", Slot = "4")]
	public override bool FHGLKLGOEFB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public class HJIHPCJJAGM<TData> : KKBHHGFLGBP<OBHDAKENJAK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly MMKDKIKKBMO GNPPFOIGEPC;

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x36028A0", Offset = "0x3601CA0", VA = "0x1836028A0")]
	public HJIHPCJJAGM(float KMHALLDFFIA, Vector3 CJFJPLAMBCB, OBHDAKENJAK<TData> DDJGFIBIACD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x3602840", Offset = "0x3601C40", VA = "0x183602840", Slot = "4")]
	public override bool FHGLKLGOEFB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct BBOOKFHGDLJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public readonly Vector3 DFHBLFHGGJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public readonly float KMHALLDFFIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public readonly Vector3 CJFJPLAMBCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public readonly bool JANGJPLNEHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public readonly Space FMJNCFCCJFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly bool PPJCAHNDCII;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x5E3A2E0", Offset = "0x5E396E0", VA = "0x185E3A2E0")]
	public BBOOKFHGDLJ(Vector3 DFHBLFHGGJO, float KMHALLDFFIA, Vector3 CJFJPLAMBCB, bool JANGJPLNEHB, bool PICMANLEBMN, Space FMJNCFCCJFK = Space.Self)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public struct EFPFGAFAMPF<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public readonly IEnumerable<TData> PABLMNKGJOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public readonly bool MLEFOMDEBKM;

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x30F3010", Offset = "0x30F2410", VA = "0x1830F3010")]
	public EFPFGAFAMPF(IEnumerable<TData> PABLMNKGJOH, bool MLEFOMDEBKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public struct ELHDALAIHCA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public readonly float POLGFCHEFFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public readonly bool LKAKOHAEMPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public readonly Vector3 CJFJPLAMBCB;

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x5E3A320", Offset = "0x5E39720", VA = "0x185E3A320")]
	public ELHDALAIHCA(float POLGFCHEFFJ, bool LKAKOHAEMPH, Vector3 CJFJPLAMBCB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct MMKDKIKKBMO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public readonly float KMHALLDFFIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public readonly Vector3 CJFJPLAMBCB;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x4399C20", Offset = "0x4399020", VA = "0x184399C20")]
	public MMKDKIKKBMO(float KMHALLDFFIA, Vector3 CJFJPLAMBCB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public static class FHOBEJMOPNI
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	private struct LGKKGBMBBLG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public bool NFIFFLIIHGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public DIBCBJLEDOH JGOPCOKGGCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public DIBCBJLEDOH KJMDNFPKGLK;
	}

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private static LGKKGBMBBLG CMCCKLLEFMD;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static CancellationToken INBGIIILFEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x5E3A5F0", Offset = "0x5E399F0", VA = "0x185E3A5F0")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	internal static DIBCBJLEDOH JGOPCOKGGCN
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x5E3A400", Offset = "0x5E39800", VA = "0x185E3A400")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x5E3A390", Offset = "0x5E39790", VA = "0x185E3A390")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5E3A610", Offset = "0x5E39A10", VA = "0x185E3A610")]
	[JMGGEKJCAGA(IHKKALDEJFL.Room, PLCOHLLKCIG.None)]
	private static void PFOPFDLGLMI(DIBCBJLEDOH OBNIKDJNKCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5E3A4A0", Offset = "0x5E398A0", VA = "0x185E3A4A0")]
	public static void MADHOJJNIDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x5E3A340", Offset = "0x5E39740", VA = "0x185E3A340")]
	private static DIBCBJLEDOH CKLFLEBLOBJ(DIBCBJLEDOH MAJPGMDBMIO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public static class IMHDPFJMPCC
{
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public enum BEDFCBBKDBH
	{
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		ICreationContextObject,
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		Guid
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x2546AB0", Offset = "0x2545EB0", VA = "0x182546AB0")]
	public static void EEPFMOBKLGC<T>(T OJEBKBIJNNG, BEDFCBBKDBH LFLAEPCPMDG) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x2546BF0", Offset = "0x2545FF0", VA = "0x182546BF0")]
	public static void EEPFMOBKLGC<T>(T OJEBKBIJNNG) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x2546DD0", Offset = "0x25461D0", VA = "0x182546DD0")]
	public static void HMNOMCCOOCA<T>(T OJEBKBIJNNG) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x2546C50", Offset = "0x2546050", VA = "0x182546C50")]
	public static T EHGHEBAOCHM<T>(BEDFCBBKDBH LFLAEPCPMDG) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x2546D30", Offset = "0x2546130", VA = "0x182546D30")]
	public static bool FNPALEEBJOJ<T>(BEDFCBBKDBH LFLAEPCPMDG) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x2546CF0", Offset = "0x25460F0", VA = "0x182546CF0")]
	public static T EHGHEBAOCHM<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x2546CF0", Offset = "0x25460F0", VA = "0x182546CF0")]
	public static bool FNPALEEBJOJ<T>() where T : class
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
internal static class JBDFPKKALMH
{
	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x5E3A750", Offset = "0x5E39B50", VA = "0x185E3A750")]
	public static void OCLKKAPNGDI(IEnumerable DKGMIODFIAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x25544C0", Offset = "0x25538C0", VA = "0x1825544C0")]
	public static void OCLKKAPNGDI<T>(T[] NCABOBFFNFK) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x25546A0", Offset = "0x2553AA0", VA = "0x1825546A0")]
	public static void OCLKKAPNGDI<T>(T PNHGPNJINIO) where T : notnull, Enum
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
