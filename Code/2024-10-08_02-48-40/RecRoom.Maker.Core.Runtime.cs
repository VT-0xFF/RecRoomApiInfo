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
		[Cpp2IlInjected.Address(RVA = "0x8BF5C0", Offset = "0x8BE7C0", VA = "0x1808BF5C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6CB5370", Offset = "0x6CB4570", VA = "0x186CB5370")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8C0750", Offset = "0x8BF950", VA = "0x1808C0750")]
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
		[Cpp2IlInjected.Address(RVA = "0x8C0790", Offset = "0x8BF990", VA = "0x1808C0790")]
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
	public class _AssemblyIndex : JFBHLNBAFAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6CB5940", Offset = "0x6CB4B40", VA = "0x186CB5940", Slot = "8")]
		public override void KGHJDOOILCG(KCABLKMBKAN registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x63262B0", Offset = "0x63254B0", VA = "0x1863262B0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface NHPDFACLFAA<TData, TReturn>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TReturn BGEEGALPLNI(TData JMJAOKJJFGJ);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface DBHNCBAHPID<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ClearHoverTarget(ALPLJLNJIFK FPJLCEPPNKK);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool SetHoverTarget(TData LCMBJJGJCLO, Collider GIOEPEJPGMH, ALPLJLNJIFK FPJLCEPPNKK, [Optional] HOHGEHFJHLK? HOFBICNMHEP);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool TryGetHoverTarget([Out] TData LCMBJJGJCLO);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetHoverCollider([Out] Collider GIOEPEJPGMH);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface CJCJHBAPNFA<TData> : KIGGDLLHAMC, OEDKEMFPFNM<TData>, NJPJAJNLIBC<TData>, ELJNPAKJFAK<TData>, BPBKONAIAPE, NGKPIEJHCKN<TData>, GLPCJMFLFKI, MIIIMIAMHCM
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface NGKPIEJHCKN<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 BJICPEILKCC, Vector3 BHMBDKAILFL, float ELNHAHMEPIC, [Out] T NJFLFMHHADM, [Out] Vector3 AFGEKCBBBCK, [Out] Collider GIOEPEJPGMH);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 BJICPEILKCC, Vector3 BHMBDKAILFL, float BMLKKPGKONL, float ELNHAHMEPIC, T[] BPPCPDBIMDD, [Out] Vector3 MECJPFAJEDI, [Out] Collider LGGMOACGKKJ);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 BJICPEILKCC, float BMLKKPGKONL, Vector3 OPLMIOGEFEJ, T[] BPPCPDBIMDD);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetObjectFromColliderInCurrentScope(Collider BFABEHHOAAD, [Out] T OMNLDHJPNIO);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface KIGGDLLHAMC
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Bounds ENBJMLLMKDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Transform JNGPFPAPGAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Bounds KHFNCLBODFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Transform IFFCGGMAMJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Vector3 BGKHLPHHCEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool MELDBJPLNEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void SetSelectionBoundsDirty(bool BCDBENGILDP = true, int GEKLIODDBJF = 0);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ShouldHideSelectionBoundsPreview(bool KGLCMHNKAKK, object NIOIDOPDJKO);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface MIIIMIAMHCM
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	OAACCCGABIO DEJGHDGPFDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface MECMOOJBLIA
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool EHBPDMMMDBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool NODNEAMDFAP
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool LJLNBEMADMB
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
	void TrySetPreviousCloneMapping(Dictionary<Guid, Guid> LGOCHIGDNDJ);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface ELJNPAKJFAK<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool NPHCKLGOAFP
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int KMODCEBJODL
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<TData> KOKDELDKBKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData LFDONPLGGIG);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData LFDONPLGGIG);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface OEDKEMFPFNM<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T JMJAOKJJFGJ, [Optional] HOHGEHFJHLK? BABONBDBBHF, bool KDDKLMFJDNA = true);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int NDEFEFEFLCE, IEnumerable<T> GCAMFIGKAKA, bool KDDKLMFJDNA = true);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int NDEFEFEFLCE, IEnumerable<T> GCAMFIGKAKA, HOHGEHFJHLK BABONBDBBHF, bool KDDKLMFJDNA = true);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface GLPCJMFLFKI
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface BPBKONAIAPE
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool EJJPLHEIICG
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool ANHGKLDCMBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool JPEKAGGFGPP
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool NMMOHLDPDOO
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class FHFAMMODNNN<TReceiver> : CFJKBPECAJB<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3AE6630", Offset = "0x3AE5830", VA = "0x183AE6630")]
	public FHFAMMODNNN(TReceiver CDBPAMBCOAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public abstract class NDMEIBIMEJC<TReceiver, TFromTask> : CFJKBPECAJB<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3AE6630", Offset = "0x3AE5830", VA = "0x183AE6630")]
	public NDMEIBIMEJC(TReceiver CDBPAMBCOAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public abstract class CFJKBPECAJB<TReceiver, TFromExecute> where TReceiver : notnull where TFromExecute : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	protected TReceiver CDBPAMBCOAE;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x56CF580", Offset = "0x56CE780", VA = "0x1856CF580")]
	public CFJKBPECAJB(TReceiver CDBPAMBCOAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute OOOLIJIHFCP();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class BIBJAGKOHFF<TReceiver, TResult> : CFJKBPECAJB<TReceiver, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3AE6630", Offset = "0x3AE5830", VA = "0x183AE6630")]
	public BIBJAGKOHFF(TReceiver CDBPAMBCOAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct DMCHNBMBMFE<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public TGroup JOKMMCNGOIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public TData KIKICADPNGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public IEnumerable<TData> PLIEJCLBOLO;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x20E49A0", Offset = "0x20E3BA0", VA = "0x1820E49A0")]
	public DMCHNBMBMFE(TGroup JDJCGPAIHGI, TData EFJBABBAOIA, IEnumerable<TData> NLBDLIHJOEM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct KPLDGEPGMKC<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public TGroup JOKMMCNGOIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public IEnumerable<TData> PLIEJCLBOLO;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0xD62DE0", Offset = "0xD61FE0", VA = "0x180D62DE0")]
	public KPLDGEPGMKC(TGroup JDJCGPAIHGI, IEnumerable<TData> NLBDLIHJOEM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct CEHAEHNDIPP<TGroup> where TGroup : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public TGroup JOKMMCNGOIA;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0xBD6E30", Offset = "0xBD6030", VA = "0x180BD6E30")]
	public CEHAEHNDIPP(TGroup JDJCGPAIHGI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct IBNONFGBFNC<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public IEnumerable<TData> PLIEJCLBOLO;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0xBD6E30", Offset = "0xBD6030", VA = "0x180BD6E30")]
	public IBNONFGBFNC(IEnumerable<TData> NLBDLIHJOEM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface PGKIMHDHNCM<TGroup, TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PFPJIAAGEHN BONPMILMDIF(DMCHNBMBMFE<TGroup, TData> LEGLEFADBFL);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "1")]
	PFPJIAAGEHN JLABMBGEDFH(DMCHNBMBMFE<TGroup, TData> LEGLEFADBFL);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "2")]
	PFPJIAAGEHN AHPICEGDEGO(KPLDGEPGMKC<TGroup, TData> LEGLEFADBFL);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "3")]
	PFPJIAAGEHN DKDHLBIBMMC(CEHAEHNDIPP<TGroup> LEGLEFADBFL);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface IALFHGLCLDP<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<PFPJIAAGEHN> BONPMILMDIF(IBNONFGBFNC<TData> LEGLEFADBFL);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class FIGMEPPKIID<TGroup, TData> : BIBJAGKOHFF<PGKIMHDHNCM<TGroup, TData>, PFPJIAAGEHN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly KPLDGEPGMKC<TGroup, TData> LEGLEFADBFL;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3E99C50", Offset = "0x3E98E50", VA = "0x183E99C50")]
	public FIGMEPPKIID(TGroup JDJCGPAIHGI, IEnumerable<TData> NLBDLIHJOEM, PGKIMHDHNCM<TGroup, TData> CDBPAMBCOAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3E99B90", Offset = "0x3E98D90", VA = "0x183E99B90", Slot = "4")]
	public override PFPJIAAGEHN OOOLIJIHFCP()
	{
		return default(PFPJIAAGEHN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class AAAKPHJPCNL<TGroup, TData> : BIBJAGKOHFF<PGKIMHDHNCM<TGroup, TData>, PFPJIAAGEHN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly DMCHNBMBMFE<TGroup, TData> LEGLEFADBFL;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3EFA540", Offset = "0x3EF9740", VA = "0x183EFA540")]
	public AAAKPHJPCNL(TGroup JDJCGPAIHGI, TData NOKFNGCHCKL, IEnumerable<TData> NLBDLIHJOEM, PGKIMHDHNCM<TGroup, TData> CDBPAMBCOAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3EFA470", Offset = "0x3EF9670", VA = "0x183EFA470", Slot = "4")]
	public override PFPJIAAGEHN OOOLIJIHFCP()
	{
		return default(PFPJIAAGEHN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class DGDNEIEFLPO<TGroup, TData> : BIBJAGKOHFF<PGKIMHDHNCM<TGroup, TData>, PFPJIAAGEHN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly CEHAEHNDIPP<TGroup> LEGLEFADBFL;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x4958C80", Offset = "0x4957E80", VA = "0x184958C80")]
	public DGDNEIEFLPO(TGroup JDJCGPAIHGI, PGKIMHDHNCM<TGroup, TData> CDBPAMBCOAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5B2B4F0", Offset = "0x5B2A6F0", VA = "0x185B2B4F0", Slot = "4")]
	public override PFPJIAAGEHN OOOLIJIHFCP()
	{
		return default(PFPJIAAGEHN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class ONFJBDCNPNL<TGroup, TData> : BIBJAGKOHFF<PGKIMHDHNCM<TGroup, TData>, PFPJIAAGEHN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly DMCHNBMBMFE<TGroup, TData> LEGLEFADBFL;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3EFA540", Offset = "0x3EF9740", VA = "0x183EFA540")]
	public ONFJBDCNPNL(TGroup JDJCGPAIHGI, TData EFJBABBAOIA, IEnumerable<TData> NLBDLIHJOEM, PGKIMHDHNCM<TGroup, TData> CDBPAMBCOAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x4980B20", Offset = "0x497FD20", VA = "0x184980B20", Slot = "4")]
	public override PFPJIAAGEHN OOOLIJIHFCP()
	{
		return default(PFPJIAAGEHN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class CJOMBOOPJLG<TData> : NDMEIBIMEJC<IALFHGLCLDP<TData>, PFPJIAAGEHN> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private struct CJHLDKHBMBE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AsyncTaskMethodBuilder<PFPJIAAGEHN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public CJOMBOOPJLG<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private TaskAwaiter<PFPJIAAGEHN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x57C4BB0", Offset = "0x57C3DB0", VA = "0x1857C4BB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x57C4E50", Offset = "0x57C4050", VA = "0x1857C4E50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private IBNONFGBFNC<TData> LEGLEFADBFL;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x4958C80", Offset = "0x4957E80", VA = "0x184958C80")]
	public CJOMBOOPJLG(IEnumerable<TData> BJAINNIJLOM, IALFHGLCLDP<TData> CDBPAMBCOAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x57C7B00", Offset = "0x57C6D00", VA = "0x1857C7B00", Slot = "4")]
	[AsyncStateMachine(typeof(CJOMBOOPJLG<>.CJHLDKHBMBE))]
	public override Task<PFPJIAAGEHN> OOOLIJIHFCP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public readonly struct KDOKJFJNPLE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly CFJLLHOIEDI CDKIEGHGHHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly bool AFCNOIIPIOP;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6CB51C0", Offset = "0x6CB43C0", VA = "0x186CB51C0")]
	public KDOKJFJNPLE(CFJLLHOIEDI ODAEBKOLOHL, bool NOKDAGHODKC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface ACFMBEDBBFE<TSpawnType> where TSpawnType : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> OOOLIJIHFCP(KDOKJFJNPLE OHPOBJIIKPJ);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class HFCCHHFOEBF<TSpawnType> : NDMEIBIMEJC<ACFMBEDBBFE<TSpawnType>, TSpawnType> where TSpawnType : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private struct NBLMNBAFLND : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public AsyncTaskMethodBuilder<TSpawnType> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public HFCCHHFOEBF<TSpawnType> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskAwaiter<TSpawnType> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x4815060", Offset = "0x4814260", VA = "0x184815060", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x3AF6E80", Offset = "0x3AF6080", VA = "0x183AF6E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly KDOKJFJNPLE OHPOBJIIKPJ;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x401A930", Offset = "0x4019B30", VA = "0x18401A930")]
	public HFCCHHFOEBF(CFJLLHOIEDI ODAEBKOLOHL, bool NOKDAGHODKC, ACFMBEDBBFE<TSpawnType> CDBPAMBCOAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x401A830", Offset = "0x4019A30", VA = "0x18401A830", Slot = "4")]
	[AsyncStateMachine(typeof(HFCCHHFOEBF<>.NBLMNBAFLND))]
	public override Task<TSpawnType> OOOLIJIHFCP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public readonly struct CFJLLHOIEDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly bool OCPFMBAGIGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly Vector3 CNJLAAFJLHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly Vector3 LFHLHOFOIJP;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6CB4D20", Offset = "0x6CB3F20", VA = "0x186CB4D20")]
	public CFJLLHOIEDI(Transform LHEJBBPPNHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6CB4CF0", Offset = "0x6CB3EF0", VA = "0x186CB4CF0")]
	public CFJLLHOIEDI(Vector3 DJCLDHHAKMM, Vector3 FJFKFIAGEPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6CB4CC0", Offset = "0x6CB3EC0", VA = "0x186CB4CC0")]
	public static CFJLLHOIEDI KIEKDHFGNJA()
	{
		return default(CFJLLHOIEDI);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6CB4D90", Offset = "0x6CB3F90", VA = "0x186CB4D90")]
	private CFJLLHOIEDI(bool MOGKABEIMOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct IMLBAEOOLJG<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public TNode KEIEBPDGBBH;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x4183ED0", Offset = "0x41830D0", VA = "0x184183ED0")]
	public IMLBAEOOLJG(TNode KEIEBPDGBBH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct IOGGMKEONCN<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public TNode OPDIHPMPGCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public KHAPFLMAGAM OLDLGOBEJDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly bool AFCNOIIPIOP;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x4184CB0", Offset = "0x4183EB0", VA = "0x184184CB0")]
	public IOGGMKEONCN(TNode OPDIHPMPGCP, KHAPFLMAGAM OLDLGOBEJDI, bool NOKDAGHODKC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface APMFBKCJBLE<TNode>
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IHOAKHFHGHB([In] IMLBAEOOLJG<TNode> AGDDDLAJAAD);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DMDPDGNHGNP([In] IOGGMKEONCN<TNode> LEONEMCAHFN);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JANBCGGAONL();
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class ELOHOPLFGIP<TNode> : FHFAMMODNNN<APMFBKCJBLE<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3AE6630", Offset = "0x3AE5830", VA = "0x183AE6630")]
	public ELOHOPLFGIP(APMFBKCJBLE<TNode> CDBPAMBCOAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3AE65E0", Offset = "0x3AE57E0", VA = "0x183AE65E0", Slot = "4")]
	public override bool OOOLIJIHFCP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class ACOMGCKPKDK<TNode> : FHFAMMODNNN<APMFBKCJBLE<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly IOGGMKEONCN<TNode> LEONEMCAHFN;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3F01740", Offset = "0x3F00940", VA = "0x183F01740")]
	public ACOMGCKPKDK(TNode OPDIHPMPGCP, KHAPFLMAGAM OLDLGOBEJDI, APMFBKCJBLE<TNode> CDBPAMBCOAE, bool NOKDAGHODKC = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3F01680", Offset = "0x3F00880", VA = "0x183F01680", Slot = "4")]
	public override bool OOOLIJIHFCP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class GCBDGELLLLO<TNode> : FHFAMMODNNN<APMFBKCJBLE<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly IMLBAEOOLJG<TNode> AGDDDLAJAAD;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3F5A110", Offset = "0x3F59310", VA = "0x183F5A110")]
	public GCBDGELLLLO(TNode EICJGLJIIFM, APMFBKCJBLE<TNode> CDBPAMBCOAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3AD6F70", Offset = "0x3AD6170", VA = "0x183AD6F70", Slot = "4")]
	public override bool OOOLIJIHFCP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct KLIKEMMJJCG<TSpawnInfo> where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public TSpawnInfo NKOMIPBDCLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public Vector3 FJFKFIAGEPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Quaternion MBMKLLFOFFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public float DKGNMCFDBJD;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x44BB9A0", Offset = "0x44BABA0", VA = "0x1844BB9A0")]
	public KLIKEMMJJCG(TSpawnInfo NKOMIPBDCLM, Vector3 FJFKFIAGEPM, Quaternion MBMKLLFOFFL, float DKGNMCFDBJD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface OMGPAMBPMJK<TSpawnType, TSpawnInfo>
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> BGIIKNMIBDL([In] KLIKEMMJJCG<TSpawnInfo> POPPDGDLGCL, CancellationToken DDNLBFLLCLM);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class PDOGGMKFPDE<TSpawnType, TSpawnInfo> : NDMEIBIMEJC<OMGPAMBPMJK<TSpawnType, TSpawnInfo>, TSpawnType> where TSpawnType : notnull where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly KLIKEMMJJCG<TSpawnInfo> KLDEANCBDEG;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x4A83A00", Offset = "0x4A82C00", VA = "0x184A83A00")]
	public PDOGGMKFPDE(TSpawnInfo HICPMHDIPAJ, Vector3 FJFKFIAGEPM, Quaternion MBMKLLFOFFL, float DKGNMCFDBJD, OMGPAMBPMJK<TSpawnType, TSpawnInfo> CDBPAMBCOAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x4A83920", Offset = "0x4A82B20", VA = "0x184A83920", Slot = "4")]
	public override Task<TSpawnType> OOOLIJIHFCP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct FHMFGLNANKI<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly IEnumerable<TData> PLIEJCLBOLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly bool AFCNOIIPIOP;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3E991E0", Offset = "0x3E983E0", VA = "0x183E991E0")]
	public FHMFGLNANKI(IEnumerable<TData> NLBDLIHJOEM, bool NOKDAGHODKC = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface JFEPCBLDCDJ<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<PFPJIAAGEHN> JLPIBMOBMHJ([In] FHMFGLNANKI<TData> MOEPNMHCEJC, CancellationToken DDNLBFLLCLM);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public class PLCEAKPBLCO<TData> : NDMEIBIMEJC<JFEPCBLDCDJ<TData>, PFPJIAAGEHN> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly FHMFGLNANKI<TData> GMMBPCEKIKG;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x4AB2FA0", Offset = "0x4AB21A0", VA = "0x184AB2FA0")]
	public PLCEAKPBLCO(IEnumerable<TData> NLBDLIHJOEM, bool NOKDAGHODKC, JFEPCBLDCDJ<TData> CDBPAMBCOAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x4A83920", Offset = "0x4A82B20", VA = "0x184A83920", Slot = "4")]
	public override Task<PFPJIAAGEHN> OOOLIJIHFCP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct KFGNHIGKMDN<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public readonly T LCMBJJGJCLO;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x44956D0", Offset = "0x44948D0", VA = "0x1844956D0")]
	public KFGNHIGKMDN(T EJAHMELJFGK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface COCJFHAIAKN<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IHOAKHFHGHB([In] KFGNHIGKMDN<T> FOBAIOLBAIC);

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DMDPDGNHGNP();
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface EJEELEDDFOE<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OOOLIJIHFCP([In] LKPFKCONCAP<T> HBIKOGDBBLB);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct LKPFKCONCAP<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public readonly T LCMBJJGJCLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public readonly bool GNOKOJDLKPM;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x45593E0", Offset = "0x45585E0", VA = "0x1845593E0")]
	public LKPFKCONCAP(T EJAHMELJFGK, bool NKIDPDIBMHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class HEHHPLHDNCE<T> : FHFAMMODNNN<COCJFHAIAKN<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x3AE6630", Offset = "0x3AE5830", VA = "0x183AE6630")]
	public HEHHPLHDNCE(COCJFHAIAKN<T> CDBPAMBCOAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x4019760", Offset = "0x4018960", VA = "0x184019760", Slot = "4")]
	public override bool OOOLIJIHFCP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class ODLKAKEBBNB<T> : FHFAMMODNNN<COCJFHAIAKN<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly KFGNHIGKMDN<T> FOBAIOLBAIC;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x4958BF0", Offset = "0x4957DF0", VA = "0x184958BF0")]
	public ODLKAKEBBNB(T LCMBJJGJCLO, COCJFHAIAKN<T> CDBPAMBCOAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x3AD6F70", Offset = "0x3AD6170", VA = "0x183AD6F70", Slot = "4")]
	public override bool OOOLIJIHFCP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class KIHNEFCCJMN<T> : FHFAMMODNNN<EJEELEDDFOE<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly LKPFKCONCAP<T> HBIKOGDBBLB;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x44A5700", Offset = "0x44A4900", VA = "0x1844A5700")]
	public KIHNEFCCJMN(T LCMBJJGJCLO, bool NKIDPDIBMHN, EJEELEDDFOE<T> CDBPAMBCOAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x3AD6F70", Offset = "0x3AD6170", VA = "0x183AD6F70", Slot = "4")]
	public override bool OOOLIJIHFCP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct JGMAGOKHKHJ<TData> where TData : notnull, APIAJDMBACK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public IEnumerable<TData> PLIEJCLBOLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public bool GIMDJCLDGAH;

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x435B850", Offset = "0x435AA50", VA = "0x18435B850")]
	public JGMAGOKHKHJ(IEnumerable<TData> DIIDIPBOPBK, bool ANIOMAKDPHC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public struct AJLDEBHGMOP<TData> where TData : notnull, APIAJDMBACK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public List<TData> PLIEJCLBOLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public List<bool> KHEJPOHEEHJ;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x3F435C0", Offset = "0x3F427C0", VA = "0x183F435C0")]
	public AJLDEBHGMOP(List<TData> DIIDIPBOPBK, List<bool> OJMCEPHIKOD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface APIAJDMBACK
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool JBILLBKINPH
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
public interface FBEPJFOJOPB<TData> where TData : APIAJDMBACK
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OOOLIJIHFCP([In] JGMAGOKHKHJ<TData> BMELKMLKJFL);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OOOLIJIHFCP([In] AJLDEBHGMOP<TData> BMELKMLKJFL);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface FHPKKBCMFPG<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MCBMDNLMINI(T LCMBJJGJCLO);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class MKBPPAOJLGO<TData> : FHFAMMODNNN<FBEPJFOJOPB<TData>> where TData : notnull, APIAJDMBACK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly JGMAGOKHKHJ<TData> BMELKMLKJFL;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x47B0CE0", Offset = "0x47AFEE0", VA = "0x1847B0CE0")]
	public MKBPPAOJLGO(List<TData> NLBDLIHJOEM, bool GIMDJCLDGAH, FBEPJFOJOPB<TData> CDBPAMBCOAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x3AD6F70", Offset = "0x3AD6170", VA = "0x183AD6F70", Slot = "4")]
	public override bool OOOLIJIHFCP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class MCDKMHOHOJJ<TData> : FHFAMMODNNN<FBEPJFOJOPB<TData>> where TData : notnull, APIAJDMBACK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly AJLDEBHGMOP<TData> BMELKMLKJFL;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x476ECC0", Offset = "0x476DEC0", VA = "0x18476ECC0")]
	public MCDKMHOHOJJ(List<TData> NLBDLIHJOEM, List<bool> KHEJPOHEEHJ, FBEPJFOJOPB<TData> CDBPAMBCOAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x476EC00", Offset = "0x476DE00", VA = "0x18476EC00", Slot = "4")]
	public override bool OOOLIJIHFCP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface AFDHCBFNOLM<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<PFPJIAAGEHN> OOOLIJIHFCP(NLKKNNCEEFL<TData> LNCHCLFLHCA);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class KMKOEBCNPGJ<TData> : NDMEIBIMEJC<AFDHCBFNOLM<TData>, PFPJIAAGEHN> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct DLHGOILPKEF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public AsyncTaskMethodBuilder<PFPJIAAGEHN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public KMKOEBCNPGJ<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter<PFPJIAAGEHN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x5B36D70", Offset = "0x5B35F70", VA = "0x185B36D70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x5B37050", Offset = "0x5B36250", VA = "0x185B37050", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly NLKKNNCEEFL<TData> HNKFAGDHNDK;

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x44BD790", Offset = "0x44BC990", VA = "0x1844BD790")]
	public KMKOEBCNPGJ(TData JBEJOPCJMKH, IReadOnlyList<TData> NLMJKGIHJDL, bool NOKDAGHODKC, AFDHCBFNOLM<TData> CDBPAMBCOAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x44BD690", Offset = "0x44BC890", VA = "0x1844BD690", Slot = "4")]
	[AsyncStateMachine(typeof(KMKOEBCNPGJ<>.DLHGOILPKEF))]
	public override Task<PFPJIAAGEHN> OOOLIJIHFCP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public struct NLKKNNCEEFL<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public TData MJCAHHLILBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public IReadOnlyList<TData> IEEMKGIJIMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public bool AFCNOIIPIOP;

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x48623A0", Offset = "0x48615A0", VA = "0x1848623A0")]
	public NLKKNNCEEFL(TData JBEJOPCJMKH, IReadOnlyList<TData> NLMJKGIHJDL, bool NOKDAGHODKC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface MAMAOJHMNCP<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OOOLIJIHFCP([In] JBJNFHMFCBN<TData> PHDPGCGGNFB);
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface DJGMJJCHKBD<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OOOLIJIHFCP([In] FNEDLIDPFNL<TData> PHDPGCGGNFB);
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface EMMKKDNCEBJ<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KFJCOLINBPK([In] EKKMMIFPFBB<TData> PHDPGCGGNFB);

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DMDPDGNHGNP();
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class EJKIFLAKMFN<TData> : FHFAMMODNNN<MAMAOJHMNCP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly JBJNFHMFCBN<TData> PHDPGCGGNFB;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x3AD7020", Offset = "0x3AD6220", VA = "0x183AD7020")]
	public EJKIFLAKMFN(IEnumerable<TData> NLBDLIHJOEM, PEFOMOGDEAG CIHDHJMCJNM, JDPCAFCBCGO JEDKLDMCCCG, float GNEAKHLPHMG, bool NOKDAGHODKC, MAMAOJHMNCP<TData> CDBPAMBCOAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3AD6F70", Offset = "0x3AD6170", VA = "0x183AD6F70", Slot = "4")]
	public override bool OOOLIJIHFCP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class FKJPEHKBADH<TData> : FHFAMMODNNN<DJGMJJCHKBD<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly FNEDLIDPFNL<TData> PHDPGCGGNFB;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3EA3CE0", Offset = "0x3EA2EE0", VA = "0x183EA3CE0")]
	public FKJPEHKBADH(TData[] NLBDLIHJOEM, PEFOMOGDEAG[] CIHDHJMCJNM, JDPCAFCBCGO[] JEDKLDMCCCG, float[] GNEAKHLPHMG, DJGMJJCHKBD<TData> CDBPAMBCOAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x3EA3B50", Offset = "0x3EA2D50", VA = "0x183EA3B50", Slot = "4")]
	public override bool OOOLIJIHFCP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class FJOPKEOCGKG<TData> : FHFAMMODNNN<EMMKKDNCEBJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3AE6630", Offset = "0x3AE5830", VA = "0x183AE6630")]
	public FJOPKEOCGKG(EMMKKDNCEBJ<TData> CDBPAMBCOAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3EA3950", Offset = "0x3EA2B50", VA = "0x183EA3950", Slot = "4")]
	public override bool OOOLIJIHFCP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class KICIJIKDNCC<TData> : FHFAMMODNNN<EMMKKDNCEBJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly EKKMMIFPFBB<TData> PHDPGCGGNFB;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x44A48D0", Offset = "0x44A3AD0", VA = "0x1844A48D0")]
	public KICIJIKDNCC(IEnumerable<TData> NLBDLIHJOEM, PEFOMOGDEAG CIHDHJMCJNM, JDPCAFCBCGO JEDKLDMCCCG, float GNEAKHLPHMG, EMMKKDNCEBJ<TData> CDBPAMBCOAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3EA3B50", Offset = "0x3EA2D50", VA = "0x183EA3B50", Slot = "4")]
	public override bool OOOLIJIHFCP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct JBJNFHMFCBN<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public IEnumerable<TData> PLIEJCLBOLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public PEFOMOGDEAG NGHCCCHGLCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public JDPCAFCBCGO FJOLPIAIAOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public float GNEAKHLPHMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public bool NOKDAGHODKC;

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x43477B0", Offset = "0x43469B0", VA = "0x1843477B0")]
	public JBJNFHMFCBN(IEnumerable<TData> NLBDLIHJOEM, PEFOMOGDEAG CIHDHJMCJNM, JDPCAFCBCGO JEDKLDMCCCG, float GNEAKHLPHMG, bool NOKDAGHODKC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public struct FNEDLIDPFNL<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public TData[] PLIEJCLBOLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public PEFOMOGDEAG[] NGHCCCHGLCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public JDPCAFCBCGO[] FJOLPIAIAOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public float[] GNEAKHLPHMG;

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3EB44C0", Offset = "0x3EB36C0", VA = "0x183EB44C0")]
	public FNEDLIDPFNL(TData[] NLBDLIHJOEM, PEFOMOGDEAG[] CIHDHJMCJNM, JDPCAFCBCGO[] JEDKLDMCCCG, float[] GNEAKHLPHMG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public struct EKKMMIFPFBB<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public IEnumerable<TData> PLIEJCLBOLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public PEFOMOGDEAG NGHCCCHGLCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public JDPCAFCBCGO FJOLPIAIAOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public float GNEAKHLPHMG;

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3AE5060", Offset = "0x3AE4260", VA = "0x183AE5060")]
	public EKKMMIFPFBB(IEnumerable<TData> NLBDLIHJOEM, PEFOMOGDEAG CIHDHJMCJNM, JDPCAFCBCGO JEDKLDMCCCG, float GNEAKHLPHMG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface NJPJAJNLIBC<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AHPICEGDEGO([In] EFBGHEJDJNM<TData> MOEPNMHCEJC);

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DKDHLBIBMMC([In] EFBGHEJDJNM<TData> MOEPNMHCEJC);

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PIEIMEDLCEM([In] bool OOMBCBNHOGD);

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool ECOLKNPIEDO([In] EFBGHEJDJNM<TData> MOEPNMHCEJC);

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KMHEDENMHNM();

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool CHBJIEAAHPA([In] TData OOPAMBBIEMA);
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class BPFBINEEAHI<TData> : FHFAMMODNNN<NJPJAJNLIBC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly EFBGHEJDJNM<TData> MOEPNMHCEJC;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x52F9A40", Offset = "0x52F8C40", VA = "0x1852F9A40")]
	public BPFBINEEAHI(List<TData> HJAFNJHIFIH, NJPJAJNLIBC<TData> CDBPAMBCOAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x52F9940", Offset = "0x52F8B40", VA = "0x1852F9940", Slot = "4")]
	public override bool OOOLIJIHFCP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class OHJGICEBKPE<TData> : FHFAMMODNNN<NJPJAJNLIBC<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3AE6630", Offset = "0x3AE5830", VA = "0x183AE6630")]
	public OHJGICEBKPE(NJPJAJNLIBC<TData> CDBPAMBCOAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x496AEB0", Offset = "0x496A0B0", VA = "0x18496AEB0", Slot = "4")]
	public override bool OOOLIJIHFCP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class DHMGACEMDKG<TData> : FHFAMMODNNN<NJPJAJNLIBC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly bool NOKDAGHODKC;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5B2DC00", Offset = "0x5B2CE00", VA = "0x185B2DC00")]
	public DHMGACEMDKG(bool NOKDAGHODKC, NJPJAJNLIBC<TData> CDBPAMBCOAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x5B2DBA0", Offset = "0x5B2CDA0", VA = "0x185B2DBA0", Slot = "4")]
	public override bool OOOLIJIHFCP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class NFJOIIPMCAM<TData> : FHFAMMODNNN<NJPJAJNLIBC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly EFBGHEJDJNM<TData> MOEPNMHCEJC;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x482A110", Offset = "0x4829310", VA = "0x18482A110")]
	public NFJOIIPMCAM(List<TData> HJAFNJHIFIH, bool NOKDAGHODKC, NJPJAJNLIBC<TData> CDBPAMBCOAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x476EC00", Offset = "0x476DE00", VA = "0x18476EC00", Slot = "4")]
	public override bool OOOLIJIHFCP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class CMECKINNCNN<TData> : FHFAMMODNNN<NJPJAJNLIBC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly TData OOPAMBBIEMA;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x57C9C10", Offset = "0x57C8E10", VA = "0x1857C9C10")]
	public CMECKINNCNN(TData OOPAMBBIEMA, NJPJAJNLIBC<TData> CDBPAMBCOAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x57C9B50", Offset = "0x57C8D50", VA = "0x1857C9B50", Slot = "4")]
	public override bool OOOLIJIHFCP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class MALKLLGLNBM<TData> : FHFAMMODNNN<NJPJAJNLIBC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly EFBGHEJDJNM<TData> MOEPNMHCEJC;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x475DF50", Offset = "0x475D150", VA = "0x18475DF50")]
	public MALKLLGLNBM(IEnumerable<TData> HJAFNJHIFIH, NJPJAJNLIBC<TData> CDBPAMBCOAE, bool NOKDAGHODKC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x475DDE0", Offset = "0x475CFE0", VA = "0x18475DDE0", Slot = "4")]
	public override bool OOOLIJIHFCP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public struct EFBGHEJDJNM<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public IEnumerable<TData> PLIEJCLBOLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public bool NOKDAGHODKC;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3ACE7F0", Offset = "0x3ACD9F0", VA = "0x183ACE7F0")]
	public EFBGHEJDJNM(IEnumerable<TData> DIIDIPBOPBK, bool JLKKDMBEOCE = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface IJGIOHMMDLD
{
	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<PFPJIAAGEHN> OOOLIJIHFCP(HLJLDGFKAIN IHKHGAMFPKL);
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public class LOACHPELIJG : NDMEIBIMEJC<IJGIOHMMDLD, PFPJIAAGEHN>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private struct BEECPLABBEJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public AsyncTaskMethodBuilder<PFPJIAAGEHN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public LOACHPELIJG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private TaskAwaiter<PFPJIAAGEHN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6CB4900", Offset = "0x6CB3B00", VA = "0x186CB4900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6CB4B70", Offset = "0x6CB3D70", VA = "0x186CB4B70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly HLJLDGFKAIN KNDAPGHOOJI;

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6CB5310", Offset = "0x6CB4510", VA = "0x186CB5310")]
	public LOACHPELIJG(bool NOKDAGHODKC, IJGIOHMMDLD CDBPAMBCOAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6CB5220", Offset = "0x6CB4420", VA = "0x186CB5220", Slot = "4")]
	[AsyncStateMachine(typeof(BEECPLABBEJ))]
	public override Task<PFPJIAAGEHN> OOOLIJIHFCP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public struct HLJLDGFKAIN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public bool AFCNOIIPIOP;

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x23B1980", Offset = "0x23B0B80", VA = "0x1823B1980")]
	public HLJLDGFKAIN(bool NOKDAGHODKC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public readonly struct IMFGIDFPJOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly bool JLHHGMCAOLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly bool NLFHIONDJKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public readonly bool DKGNMCFDBJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public readonly bool NOKDAGHODKC;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x500C2F0", Offset = "0x500B4F0", VA = "0x18500C2F0")]
	public IMFGIDFPJOI(bool JLHHGMCAOLE, bool NLFHIONDJKE, bool DKGNMCFDBJD, bool NOKDAGHODKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6CB4F80", Offset = "0x6CB4180", VA = "0x186CB4F80")]
	public IMFGIDFPJOI(bool NLFHIONDJKE, bool NOKDAGHODKC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public interface OAAOMBAJODH
{
	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EDBFNDAMHPA(IMFGIDFPJOI OFMNHMFBOLC);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool ECMLLINFKKN(IMFGIDFPJOI OFMNHMFBOLC);
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class CBFMMNAFCII : FHFAMMODNNN<OAAOMBAJODH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly IMFGIDFPJOI OFMNHMFBOLC;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6CB4C30", Offset = "0x6CB3E30", VA = "0x186CB4C30")]
	public CBFMMNAFCII(bool PKBNMONECNF, bool NLFHIONDJKE, bool DKGNMCFDBJD, bool NOKDAGHODKC, OAAOMBAJODH CDBPAMBCOAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6CB4BE0", Offset = "0x6CB3DE0", VA = "0x186CB4BE0", Slot = "4")]
	public override bool OOOLIJIHFCP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class PEGCFEJKOML : FHFAMMODNNN<OAAOMBAJODH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly IMFGIDFPJOI OFMNHMFBOLC;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6CB5460", Offset = "0x6CB4660", VA = "0x186CB5460")]
	public PEGCFEJKOML(bool NLFHIONDJKE, bool NOKDAGHODKC, OAAOMBAJODH CDBPAMBCOAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6CB5410", Offset = "0x6CB4610", VA = "0x186CB5410", Slot = "4")]
	public override bool OOOLIJIHFCP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public interface HIIJMDNHADO
{
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OOOLIJIHFCP([In] PIEGBDFAOCO NJMACPGPGJC);
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class ANBMBLEKDEK : FHFAMMODNNN<HIIJMDNHADO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly PIEGBDFAOCO NJMACPGPGJC;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6CB4380", Offset = "0x6CB3580", VA = "0x186CB4380")]
	public ANBMBLEKDEK(Guid[] INHPCLBJLKC, Vector3[] AHDJKPEJNLH, Quaternion[] PIPEEEAPNFJ, float[] MBKBLEGPOFO, Dictionary<Guid, Vector3> LJAEHBMBLGJ, HIIJMDNHADO CDBPAMBCOAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6CB42D0", Offset = "0x6CB34D0", VA = "0x186CB42D0", Slot = "4")]
	public override bool OOOLIJIHFCP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public interface HHBNAIOGNHD<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IHOAKHFHGHB([In] JHGAMGEAHHL<TData> AGDDDLAJAAD);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KFJCOLINBPK([In] IBDFJFFGLMK OJHOKAEJKAA);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KFJCOLINBPK([In] FCGCHPJAAII OJHOKAEJKAA);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DMDPDGNHGNP();
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class ANFEDOGALAO<TData> : FHFAMMODNNN<HHBNAIOGNHD<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3AE6630", Offset = "0x3AE5830", VA = "0x183AE6630")]
	public ANFEDOGALAO(HHBNAIOGNHD<TData> CDBPAMBCOAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x4374640", Offset = "0x4373840", VA = "0x184374640", Slot = "4")]
	public override bool OOOLIJIHFCP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class CACNKMAHDOL<TData> : FHFAMMODNNN<HHBNAIOGNHD<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly IBDFJFFGLMK PGDMHEPCCCF;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x55E84F0", Offset = "0x55E76F0", VA = "0x1855E84F0")]
	public CACNKMAHDOL(Vector3 DMBFENOGELD, bool HGJCPAEMMII, HHBNAIOGNHD<TData> CDBPAMBCOAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x3FC22F0", Offset = "0x3FC14F0", VA = "0x183FC22F0", Slot = "4")]
	public override bool OOOLIJIHFCP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class GBJEJCJEBAL<TData> : FHFAMMODNNN<HHBNAIOGNHD<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly FCGCHPJAAII PGDMHEPCCCF;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x3F59B30", Offset = "0x3F58D30", VA = "0x183F59B30")]
	public GBJEJCJEBAL(Guid ABNGHDHOIMF, int KINMHNEMPOD, Vector3 FJFKFIAGEPM, Quaternion MBMKLLFOFFL, float DLNPAPKJAEH, bool HGJCPAEMMII, HHBNAIOGNHD<TData> CDBPAMBCOAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x3F59AD0", Offset = "0x3F58CD0", VA = "0x183F59AD0", Slot = "4")]
	public override bool OOOLIJIHFCP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class CPKEPJJFMGG<TData> : FHFAMMODNNN<HHBNAIOGNHD<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly JHGAMGEAHHL<TData> PGDMHEPCCCF;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x58AA600", Offset = "0x58A9800", VA = "0x1858AA600")]
	public CPKEPJJFMGG(TData LCMBJJGJCLO, bool NOKDAGHODKC, HHBNAIOGNHD<TData> CDBPAMBCOAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x3AD6F70", Offset = "0x3AD6170", VA = "0x183AD6F70", Slot = "4")]
	public override bool OOOLIJIHFCP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public struct IBDFJFFGLMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly Vector3 DMBFENOGELD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public readonly bool HGJCPAEMMII;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6CB4F60", Offset = "0x6CB4160", VA = "0x186CB4F60")]
	public IBDFJFFGLMK(Vector3 DMBFENOGELD, bool HGJCPAEMMII)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public struct FCGCHPJAAII
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public readonly Guid ABNGHDHOIMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public readonly int KINMHNEMPOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public readonly Vector3 FJFKFIAGEPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public readonly Quaternion MBMKLLFOFFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public readonly float DLNPAPKJAEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public readonly bool HGJCPAEMMII;

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6CB4E10", Offset = "0x6CB4010", VA = "0x186CB4E10")]
	public FCGCHPJAAII(Guid ABNGHDHOIMF, int KINMHNEMPOD, Vector3 FJFKFIAGEPM, Quaternion MBMKLLFOFFL, float DLNPAPKJAEH, bool HGJCPAEMMII)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public struct JHGAMGEAHHL<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public readonly TData LCMBJJGJCLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public readonly bool NOKDAGHODKC;

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x435D300", Offset = "0x435C500", VA = "0x18435D300")]
	public JHGAMGEAHHL(TData LCMBJJGJCLO, bool NOKDAGHODKC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public interface KFFHCEABNMA<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OOOLIJIHFCP([In] CCGHBGKNAIG<TData> FLFJIJNJALB);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OOOLIJIHFCP([In] FLNIAPGLFFE<TData> FLFJIJNJALB);
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public interface MEECEKOIICB<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IHOAKHFHGHB([In] MIPHJGHFGLG<TData> IFECGICHANN);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KFJCOLINBPK([In] KDAEGNNGHJL OJHOKAEJKAA);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DMDPDGNHGNP();
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class AMLAPAHJIEL<TData> : FHFAMMODNNN<KFFHCEABNMA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly CCGHBGKNAIG<TData> FLFJIJNJALB;

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x4373D30", Offset = "0x4372F30", VA = "0x184373D30")]
	public AMLAPAHJIEL(IEnumerable<TData> NLBDLIHJOEM, Vector3 HCJLLDDCACH, bool NOKDAGHODKC, KFFHCEABNMA<TData> CDBPAMBCOAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x3AD6F70", Offset = "0x3AD6170", VA = "0x183AD6F70", Slot = "4")]
	public override bool OOOLIJIHFCP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class EMAHEMBMPPK<TData> : FHFAMMODNNN<MEECEKOIICB<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x3AE6630", Offset = "0x3AE5830", VA = "0x183AE6630")]
	public EMAHEMBMPPK(MEECEKOIICB<TData> CDBPAMBCOAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x3AE65E0", Offset = "0x3AE57E0", VA = "0x183AE65E0", Slot = "4")]
	public override bool OOOLIJIHFCP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class DGPFGFCAPHE<TData> : FHFAMMODNNN<MEECEKOIICB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly MIPHJGHFGLG<TData> FLFJIJNJALB;

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5B2BA40", Offset = "0x5B2AC40", VA = "0x185B2BA40")]
	public DGPFGFCAPHE(IEnumerable<TData> NLBDLIHJOEM, bool NOKDAGHODKC, MEECEKOIICB<TData> CDBPAMBCOAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3AD6F70", Offset = "0x3AD6170", VA = "0x183AD6F70", Slot = "4")]
	public override bool OOOLIJIHFCP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class PFDPKGLBGOI<TData> : FHFAMMODNNN<KFFHCEABNMA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly FLNIAPGLFFE<TData> FLFJIJNJALB;

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x4A8E910", Offset = "0x4A8DB10", VA = "0x184A8E910")]
	public PFDPKGLBGOI(IEnumerable<TData> NLBDLIHJOEM, Vector3 OJHFNCJMNDF, BFJCDFJFHDF PHCIEDLKFBG, bool NOKDAGHODKC, KFFHCEABNMA<TData> CDBPAMBCOAE, Space BPODFPKOALC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x3F01680", Offset = "0x3F00880", VA = "0x183F01680", Slot = "4")]
	public override bool OOOLIJIHFCP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public class OHAFHILGBNI<TData> : FHFAMMODNNN<MEECEKOIICB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly KDAEGNNGHJL FLFJIJNJALB;

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x496AB00", Offset = "0x4969D00", VA = "0x18496AB00")]
	public OHAFHILGBNI(Vector3 HCJLLDDCACH, MEECEKOIICB<TData> CDBPAMBCOAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x3FC22F0", Offset = "0x3FC14F0", VA = "0x183FC22F0", Slot = "4")]
	public override bool OOOLIJIHFCP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct CCGHBGKNAIG<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public readonly IEnumerable<TData> NLBDLIHJOEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public readonly Vector3 HCJLLDDCACH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public readonly bool NOKDAGHODKC;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x56C6E90", Offset = "0x56C6090", VA = "0x1856C6E90")]
	public CCGHBGKNAIG(IEnumerable<TData> NLBDLIHJOEM, Vector3 HCJLLDDCACH, bool NOKDAGHODKC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct MIPHJGHFGLG<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public readonly IEnumerable<TData> NLBDLIHJOEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public readonly bool NOKDAGHODKC;

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x479ABF0", Offset = "0x4799DF0", VA = "0x18479ABF0")]
	public MIPHJGHFGLG(IEnumerable<TData> NLBDLIHJOEM, bool NOKDAGHODKC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct FLNIAPGLFFE<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public readonly IEnumerable<TData> NLBDLIHJOEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public readonly Vector3 OJHFNCJMNDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly BFJCDFJFHDF PHCIEDLKFBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public readonly bool NOKDAGHODKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly Space BPODFPKOALC;

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x3EA8050", Offset = "0x3EA7250", VA = "0x183EA8050")]
	public FLNIAPGLFFE(IEnumerable<TData> NLBDLIHJOEM, Vector3 OJHFNCJMNDF, BFJCDFJFHDF PHCIEDLKFBG, bool NOKDAGHODKC, Space BPODFPKOALC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public struct KDAEGNNGHJL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public readonly Vector3 HCJLLDDCACH;

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x23AF3B0", Offset = "0x23AE5B0", VA = "0x1823AF3B0")]
	public KDAEGNNGHJL(Vector3 HCJLLDDCACH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public enum BFJCDFJFHDF
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
public interface KDPDBJBKKEP
{
	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OOOLIJIHFCP([In] GMMOHEHDIBE GAEDFEFMKKK);
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class GGMJBJFGFAI : FHFAMMODNNN<KDPDBJBKKEP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly GMMOHEHDIBE GAEDFEFMKKK;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6CB4F00", Offset = "0x6CB4100", VA = "0x186CB4F00")]
	public GGMJBJFGFAI(bool NOKDAGHODKC, KDPDBJBKKEP CDBPAMBCOAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6CB4E50", Offset = "0x6CB4050", VA = "0x186CB4E50", Slot = "4")]
	public override bool OOOLIJIHFCP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public readonly struct GMMOHEHDIBE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public readonly bool NOKDAGHODKC;

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x23B1980", Offset = "0x23B0B80", VA = "0x1823B1980")]
	public GMMOHEHDIBE(bool NOKDAGHODKC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public interface EAPBDECGNIC<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OOOLIJIHFCP([In] EDAOJIFLPBN<TData> BNFNNFNGMKL);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OOOLIJIHFCP([In] DGBIMFIBFBN<TData> BNFNNFNGMKL);
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public interface LNLGHFLBDAO<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IHOAKHFHGHB([In] ANGKMFANJDL<TData> AGDDDLAJAAD);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KFJCOLINBPK([In] AOJBECKGCDJ OJHOKAEJKAA);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DMDPDGNHGNP();
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class AGAALHJNJPN<TData> : FHFAMMODNNN<EAPBDECGNIC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly EDAOJIFLPBN<TData> BNFNNFNGMKL;

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x3F32A70", Offset = "0x3F31C70", VA = "0x183F32A70")]
	public AGAALHJNJPN(IEnumerable<TData> NLBDLIHJOEM, Quaternion HCJLLDDCACH, Vector3? JAMBAIIECHH, bool DBMFDKBEKLC, bool NOKDAGHODKC, EAPBDECGNIC<TData> CDBPAMBCOAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x3AD6F70", Offset = "0x3AD6170", VA = "0x183AD6F70", Slot = "4")]
	public override bool OOOLIJIHFCP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class OKIAKIJOFJM<TData> : FHFAMMODNNN<LNLGHFLBDAO<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x3AE6630", Offset = "0x3AE5830", VA = "0x183AE6630")]
	public OKIAKIJOFJM(LNLGHFLBDAO<TData> CDBPAMBCOAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x3AE65E0", Offset = "0x3AE57E0", VA = "0x183AE65E0", Slot = "4")]
	public override bool OOOLIJIHFCP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class OKEMHADGGPN<TData> : FHFAMMODNNN<LNLGHFLBDAO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly ANGKMFANJDL<TData> BNFNNFNGMKL;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x4978E40", Offset = "0x4978040", VA = "0x184978E40")]
	public OKEMHADGGPN(IEnumerable<TData> NLBDLIHJOEM, bool NOKDAGHODKC, LNLGHFLBDAO<TData> CDBPAMBCOAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x3AD6F70", Offset = "0x3AD6170", VA = "0x183AD6F70", Slot = "4")]
	public override bool OOOLIJIHFCP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class NAONOKHKJEB<TData> : FHFAMMODNNN<EAPBDECGNIC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly DGBIMFIBFBN<TData> BNFNNFNGMKL;

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x48121C0", Offset = "0x48113C0", VA = "0x1848121C0")]
	public NAONOKHKJEB(IEnumerable<TData> NLBDLIHJOEM, Quaternion IHAPHFFAIPP, BFJCDFJFHDF JPHCFCDLOFG, Vector3? JAMBAIIECHH, bool DBMFDKBEKLC, bool NOKDAGHODKC, Space BPODFPKOALC, EAPBDECGNIC<TData> CDBPAMBCOAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x3F01680", Offset = "0x3F00880", VA = "0x183F01680", Slot = "4")]
	public override bool OOOLIJIHFCP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public class IIAPPPCGLNA<TData> : FHFAMMODNNN<LNLGHFLBDAO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly AOJBECKGCDJ BNFNNFNGMKL;

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x4175A40", Offset = "0x4174C40", VA = "0x184175A40")]
	public IIAPPPCGLNA(Quaternion HCJLLDDCACH, Vector3? JAMBAIIECHH, bool DBMFDKBEKLC, LNLGHFLBDAO<TData> CDBPAMBCOAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x3FC22F0", Offset = "0x3FC14F0", VA = "0x183FC22F0", Slot = "4")]
	public override bool OOOLIJIHFCP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public struct EDAOJIFLPBN<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public readonly IEnumerable<TData> NLBDLIHJOEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public readonly Quaternion HCJLLDDCACH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public readonly Vector3? JAMBAIIECHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public readonly bool DBMFDKBEKLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public readonly bool NOKDAGHODKC;

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x3ACB520", Offset = "0x3ACA720", VA = "0x183ACB520")]
	public EDAOJIFLPBN(IEnumerable<TData> NLBDLIHJOEM, Quaternion HCJLLDDCACH, Vector3? JAMBAIIECHH, bool DBMFDKBEKLC, bool NOKDAGHODKC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public struct ANGKMFANJDL<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public readonly IEnumerable<TData> NLBDLIHJOEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly bool NOKDAGHODKC;

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x4376110", Offset = "0x4375310", VA = "0x184376110")]
	public ANGKMFANJDL(IEnumerable<TData> NLBDLIHJOEM, bool NOKDAGHODKC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public struct DGBIMFIBFBN<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public readonly IEnumerable<TData> NLBDLIHJOEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public readonly Quaternion IHAPHFFAIPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public readonly BFJCDFJFHDF JPHCFCDLOFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public readonly Vector3? JAMBAIIECHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public readonly bool DBMFDKBEKLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public readonly bool NOKDAGHODKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public readonly Space BPODFPKOALC;

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x5B2B380", Offset = "0x5B2A580", VA = "0x185B2B380")]
	public DGBIMFIBFBN(IEnumerable<TData> NLBDLIHJOEM, Quaternion IHAPHFFAIPP, BFJCDFJFHDF JPHCFCDLOFG, Vector3? JAMBAIIECHH, bool DBMFDKBEKLC, bool NOKDAGHODKC, Space BPODFPKOALC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public struct AOJBECKGCDJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public readonly Quaternion HCJLLDDCACH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public readonly Vector3? JAMBAIIECHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public readonly bool DBMFDKBEKLC;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x4FD0BB0", Offset = "0x4FCFDB0", VA = "0x184FD0BB0")]
	public AOJBECKGCDJ(Quaternion HCJLLDDCACH, Vector3? JAMBAIIECHH, bool DBMFDKBEKLC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public interface ADFJFNMDJCK<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IHOAKHFHGHB([In] FPFBPAIPJBG<TData> AGDDDLAJAAD);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KFJCOLINBPK([In] DNKMPLPODBO OJHOKAEJKAA);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KFJCOLINBPK([In] PDGIGCMLLLI OJHOKAEJKAA);

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool KFJCOLINBPK([In] KGCLHNAPGCF OJHOKAEJKAA);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool DMDPDGNHGNP();
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public class ELBCLGIMAKE<TData> : FHFAMMODNNN<ADFJFNMDJCK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly KGCLHNAPGCF GIDOPCNDKAL;

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x3AE5670", Offset = "0x3AE4870", VA = "0x183AE5670")]
	public ELBCLGIMAKE(Vector3 CODCHGDEFPN, float LLLEKEFAJOE, Vector3 JAMBAIIECHH, bool HBMJIFFIBKB, bool JNLNLHMKFBK, ADFJFNMDJCK<TData> CDBPAMBCOAE, Space BPODFPKOALC = Space.Self)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x3AE5610", Offset = "0x3AE4810", VA = "0x183AE5610", Slot = "4")]
	public override bool OOOLIJIHFCP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class GGCPOIMOLCO<TData> : FHFAMMODNNN<ADFJFNMDJCK<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x3AE6630", Offset = "0x3AE5830", VA = "0x183AE6630")]
	public GGCPOIMOLCO(ADFJFNMDJCK<TData> CDBPAMBCOAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x3F61020", Offset = "0x3F60220", VA = "0x183F61020", Slot = "4")]
	public override bool OOOLIJIHFCP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class GMODPJKONNL<TData> : FHFAMMODNNN<ADFJFNMDJCK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly FPFBPAIPJBG<TData> GIDOPCNDKAL;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x3FC89D0", Offset = "0x3FC7BD0", VA = "0x183FC89D0")]
	public GMODPJKONNL(IEnumerable<TData> NLBDLIHJOEM, bool NOKDAGHODKC, ADFJFNMDJCK<TData> CDBPAMBCOAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x3AD6F70", Offset = "0x3AD6170", VA = "0x183AD6F70", Slot = "4")]
	public override bool OOOLIJIHFCP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class KKIOGFNKDCF<TData> : FHFAMMODNNN<ADFJFNMDJCK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly PDGIGCMLLLI GIDOPCNDKAL;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x44B86F0", Offset = "0x44B78F0", VA = "0x1844B86F0")]
	public KKIOGFNKDCF(float KAAFMJEJJDN, bool CNINEEEIEFH, Vector3 JAMBAIIECHH, ADFJFNMDJCK<TData> CDBPAMBCOAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x44B8630", Offset = "0x44B7830", VA = "0x1844B8630", Slot = "4")]
	public override bool OOOLIJIHFCP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public class GKKNDMDOJKO<TData> : FHFAMMODNNN<ADFJFNMDJCK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly DNKMPLPODBO GIDOPCNDKAL;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x3FC2350", Offset = "0x3FC1550", VA = "0x183FC2350")]
	public GKKNDMDOJKO(float LLLEKEFAJOE, Vector3 JAMBAIIECHH, ADFJFNMDJCK<TData> CDBPAMBCOAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x3FC22F0", Offset = "0x3FC14F0", VA = "0x183FC22F0", Slot = "4")]
	public override bool OOOLIJIHFCP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public struct KGCLHNAPGCF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public readonly Vector3 CODCHGDEFPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public readonly float LLLEKEFAJOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public readonly Vector3 JAMBAIIECHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public readonly bool HGJCPAEMMII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public readonly Space BPODFPKOALC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public readonly bool JNLNLHMKFBK;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x6CB51E0", Offset = "0x6CB43E0", VA = "0x186CB51E0")]
	public KGCLHNAPGCF(Vector3 CODCHGDEFPN, float LLLEKEFAJOE, Vector3 JAMBAIIECHH, bool HGJCPAEMMII, bool HJCOHEIODHN, Space BPODFPKOALC = Space.Self)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct FPFBPAIPJBG<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public readonly IEnumerable<TData> NLBDLIHJOEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public readonly bool NOKDAGHODKC;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x3EB6BD0", Offset = "0x3EB5DD0", VA = "0x183EB6BD0")]
	public FPFBPAIPJBG(IEnumerable<TData> NLBDLIHJOEM, bool NOKDAGHODKC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public struct PDGIGCMLLLI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public readonly float KAAFMJEJJDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public readonly bool CNINEEEIEFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public readonly Vector3 JAMBAIIECHH;

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6CB53F0", Offset = "0x6CB45F0", VA = "0x186CB53F0")]
	public PDGIGCMLLLI(float KAAFMJEJJDN, bool CNINEEEIEFH, Vector3 JAMBAIIECHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct DNKMPLPODBO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public readonly float LLLEKEFAJOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public readonly Vector3 JAMBAIIECHH;

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x4F94670", Offset = "0x4F93870", VA = "0x184F94670")]
	public DNKMPLPODBO(float LLLEKEFAJOE, Vector3 JAMBAIIECHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public struct PIEGBDFAOCO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public readonly Guid[] NLBDLIHJOEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public readonly bool HPMMFLFKIPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public readonly bool ECINPPICNKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public readonly bool BENHHKMNEIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public readonly Vector3[] AHDJKPEJNLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public readonly Quaternion[] PIPEEEAPNFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly float[] MBKBLEGPOFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public readonly Dictionary<Guid, Vector3> LJAEHBMBLGJ;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6CB56B0", Offset = "0x6CB48B0", VA = "0x186CB56B0")]
	public PIEGBDFAOCO(Guid[] INHPCLBJLKC, Vector3[] AHDJKPEJNLH, Quaternion[] PIPEEEAPNFJ, float[] MBKBLEGPOFO, Dictionary<Guid, Vector3> LJAEHBMBLGJ, bool HPMMFLFKIPB = true, bool ECINPPICNKF = true, bool BENHHKMNEIH = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6CB54E0", Offset = "0x6CB46E0", VA = "0x186CB54E0")]
	private static void BKOMKOIFEEP(Dictionary<Guid, Vector3> LJAEHBMBLGJ, int GINCFALLCOL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public static class BBAMNLCAPLJ
{
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	private struct PKOJMLHPNNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public bool OOPNDGHNCJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public KHAIBIPGEJP JBKPNHOPGAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public KHAIBIPGEJP CGPFNEEAADO;
	}

	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private static PKOJMLHPNNA AKIIJMKHMBC;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static CancellationToken HKBIDKOHGID
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6CB46A0", Offset = "0x6CB38A0", VA = "0x186CB46A0")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	internal static KHAIBIPGEJP JBKPNHOPGAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x6CB46C0", Offset = "0x6CB38C0", VA = "0x186CB46C0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x6CB4760", Offset = "0x6CB3960", VA = "0x186CB4760")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6CB4810", Offset = "0x6CB3A10", VA = "0x186CB4810")]
	[NPIOOMADHDK.EDMEHGENIAN]
	internal static void HGOIHNBOMNM(KHAIBIPGEJP PJMIBNPFMKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6CB4560", Offset = "0x6CB3760", VA = "0x186CB4560")]
	public static void AKMCCPCKADJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6CB47C0", Offset = "0x6CB39C0", VA = "0x186CB47C0")]
	private static KHAIBIPGEJP GPBEBMOLAKH(KHAIBIPGEJP GHPPHNJLNMB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public static class NNGLAKLKLLO
{
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public enum GIBJBPCBMPA
	{
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		ICreationContextObject,
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		Guid
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x2F84E60", Offset = "0x2F84060", VA = "0x182F84E60")]
	public static void GGOEMBNKINJ<T>(T PPKIGCGEAEG, GIBJBPCBMPA EIHDAHDDDEG) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x2F84DF0", Offset = "0x2F83FF0", VA = "0x182F84DF0")]
	public static void GGOEMBNKINJ<T>(T PPKIGCGEAEG) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x2F84D40", Offset = "0x2F83F40", VA = "0x182F84D40")]
	public static void CPJFPAEFDOC<T>(T PPKIGCGEAEG) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x2F852F0", Offset = "0x2F844F0", VA = "0x182F852F0")]
	public static T PLOCNKMCLIO<T>(GIBJBPCBMPA EIHDAHDDDEG) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x2F84FD0", Offset = "0x2F841D0", VA = "0x182F84FD0")]
	public static bool HJCFEIDEHAE<T>(GIBJBPCBMPA EIHDAHDDDEG, T? ICLDOKBPCFM, [Out][MaybeNullWhen(false)][NotNullWhen(true)] T ENFMNPEJJLB) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x2F85240", Offset = "0x2F84440", VA = "0x182F85240")]
	public static bool MBGAGCHFPKF<T>(GIBJBPCBMPA EIHDAHDDDEG) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x2F851E0", Offset = "0x2F843E0", VA = "0x182F851E0")]
	public static T PLOCNKMCLIO<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x2F85120", Offset = "0x2F84320", VA = "0x182F85120")]
	public static bool HJCFEIDEHAE<T>(T ICLDOKBPCFM, [Out] T ENFMNPEJJLB) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x2F851E0", Offset = "0x2F843E0", VA = "0x182F851E0")]
	public static bool MBGAGCHFPKF<T>() where T : class
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
internal static class IMHHGJMBEMP
{
	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6CB4F90", Offset = "0x6CB4190", VA = "0x186CB4F90")]
	public static void KKMOAFMHHMI(IEnumerable OKKIHGJICDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x2E5B760", Offset = "0x2E5A960", VA = "0x182E5B760")]
	public static void KKMOAFMHHMI<T>(T[] IEIBCNCHGJN) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x2E5B940", Offset = "0x2E5AB40", VA = "0x182E5B940")]
	public static void KKMOAFMHHMI<T>(T ODDCGAGBKJJ) where T : notnull, Enum
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
