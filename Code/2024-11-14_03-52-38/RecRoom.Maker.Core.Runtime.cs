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
		[Cpp2IlInjected.Address(RVA = "0x8C5550", Offset = "0x8C4950", VA = "0x1808C5550")]
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
		[Cpp2IlInjected.Address(RVA = "0x6D9BF30", Offset = "0x6D9B330", VA = "0x186D9BF30")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8C5B80", Offset = "0x8C4F80", VA = "0x1808C5B80")]
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
		[Cpp2IlInjected.Address(RVA = "0x8C5BC0", Offset = "0x8C4FC0", VA = "0x1808C5BC0")]
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
	public class _AssemblyIndex : KNLEODIDJOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6D9C410", Offset = "0x6D9B810", VA = "0x186D9C410", Slot = "8")]
		public override void LFFFLDDGBMJ(GFPLBLFDLJF registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x63F5FE0", Offset = "0x63F53E0", VA = "0x1863F5FE0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface IKDNNJDALKH<TData, TReturn>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TReturn ABDCMCAJNHO(TData FAKGLFFOLFI);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface ECKLHIICHNP<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ClearHoverTarget(KOIDIKILJEF FLDCMHIPPEN);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool SetHoverTarget(TData KLACLBHAHNL, Collider JACKAFJJIGE, KOIDIKILJEF FLDCMHIPPEN, [Optional] KIOGMPNODIM? FEIBOAGJFLA);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool TryGetHoverTarget([Out] TData KLACLBHAHNL);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetHoverCollider([Out] Collider JACKAFJJIGE);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface NFGPHANDCLO<TData> : DLGAMNINMJN, EEAKPEGKOJJ<TData>, PLFHOJFIJDI<TData>, OOBAHBHBEED<TData>, APFFGBLPKIG, FKNADMNNLND<TData>, JEFKBCGLHHF, FMBGIOCGNHJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface FKNADMNNLND<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 IPEFBOEAIHM, Vector3 KACCFANBELL, float ILHNKLAHFJF, [Out] T AJIEMCNIFKC, [Out] Vector3 BACLCAMMMLA, [Out] Collider JACKAFJJIGE);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 IPEFBOEAIHM, Vector3 KACCFANBELL, float CKOGHMJOAKK, float ILHNKLAHFJF, T[] EAJAAFHNLGF, [Out] Vector3 PEDIIBABBGJ, [Out] Collider NJJKGCIBFJH);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 IPEFBOEAIHM, float CKOGHMJOAKK, Vector3 MMFCCNFEBAE, T[] EAJAAFHNLGF);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetObjectFromColliderInCurrentScope(Collider MDNMKBEKHHF, [Out] T NOOFIKAPKKL);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface DLGAMNINMJN
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Bounds BKFEGEEJCDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Transform HDDABKNKAPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Bounds ICCFOJNBAOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Transform BODDDCMINGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Vector3 BJEAHPBBDFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool DOFDADNKHGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void SetSelectionBoundsDirty(bool LODOLLABGDL = true, int CFLFOEADOOE = 0);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ShouldHideSelectionBoundsPreview(bool OPKCGKKIJCN, object CFGHNHCDKCN);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface FMBGIOCGNHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	BDDIJCFMLKF GCPFGKHCHHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface PLCLEKFJNOA
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool FOGANOLPPCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool JGCHGKJADAO
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool CPCCHCCAMBK
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
	void TrySetPreviousCloneMapping(Dictionary<Guid, Guid> PAKOKJMLGEI);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface OOBAHBHBEED<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool BILCMBGFLIA
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int OFELGMPHFGK
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<TData> IAJACCIEHDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData DHLKAMHBBEP);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData DHLKAMHBBEP);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface EEAKPEGKOJJ<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T FAKGLFFOLFI, [Optional] KIOGMPNODIM? DHKNECJEDNE, bool FACBDDNMFPB = true);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int GMOPHNCDIJO, IEnumerable<T> JEDMGKEPJJK, bool FACBDDNMFPB = true);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int GMOPHNCDIJO, IEnumerable<T> JEDMGKEPJJK, KIOGMPNODIM DHKNECJEDNE, bool FACBDDNMFPB = true);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface JEFKBCGLHHF
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface APFFGBLPKIG
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool DLJMGGCONKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool BDEINKHKJMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool FHHNCPECCHM
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool GEKHHFPAJKA
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class NIILOPJNIJJ<TReceiver> : JOKIPHIPMGG<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3B9C890", Offset = "0x3B9BC90", VA = "0x183B9C890")]
	public NIILOPJNIJJ(TReceiver PDCCDIALKJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public abstract class GJHCCMNNJEO<TReceiver, TFromTask> : JOKIPHIPMGG<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3B9C890", Offset = "0x3B9BC90", VA = "0x183B9C890")]
	public GJHCCMNNJEO(TReceiver PDCCDIALKJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public abstract class JOKIPHIPMGG<TReceiver, TFromExecute> where TReceiver : notnull where TFromExecute : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	protected TReceiver PDCCDIALKJH;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x44446E0", Offset = "0x4443AE0", VA = "0x1844446E0")]
	public JOKIPHIPMGG(TReceiver PDCCDIALKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute EFGADDMOLKO();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class FIABEOPHIOI<TReceiver, TResult> : JOKIPHIPMGG<TReceiver, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3B9C890", Offset = "0x3B9BC90", VA = "0x183B9C890")]
	public FIABEOPHIOI(TReceiver PDCCDIALKJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct OBEAIOAHCPH<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public TGroup CPFFFCGKFNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public TData IGEMKHBEMDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public IEnumerable<TData> HIGGNELFJBK;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x215CBB0", Offset = "0x215BFB0", VA = "0x18215CBB0")]
	public OBEAIOAHCPH(TGroup PGGLJGLHAIH, TData PNGBIPKJNBL, IEnumerable<TData> MFINDIDCLCA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct FHKOPMGKEFD<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public TGroup CPFFFCGKFNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public IEnumerable<TData> HIGGNELFJBK;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0xDEC7B0", Offset = "0xDEBBB0", VA = "0x180DEC7B0")]
	public FHKOPMGKEFD(TGroup PGGLJGLHAIH, IEnumerable<TData> MFINDIDCLCA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct NFNCCIMICAD<TGroup> where TGroup : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public TGroup CPFFFCGKFNI;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x948260", Offset = "0x947660", VA = "0x180948260")]
	public NFNCCIMICAD(TGroup PGGLJGLHAIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct LHBBBKIIGKG<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public IEnumerable<TData> HIGGNELFJBK;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x948260", Offset = "0x947660", VA = "0x180948260")]
	public LHBBBKIIGKG(IEnumerable<TData> MFINDIDCLCA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface BDLMFFJFPMK<TGroup, TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KABJOCJGPGN GBCGMECGHKF(OBEAIOAHCPH<TGroup, TData> OPKADFIGBCF);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KABJOCJGPGN LMMPPPBBNKJ(OBEAIOAHCPH<TGroup, TData> OPKADFIGBCF);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "2")]
	KABJOCJGPGN LPPBCCGCIIH(FHKOPMGKEFD<TGroup, TData> OPKADFIGBCF);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "3")]
	KABJOCJGPGN GKKLJKBNMMI(NFNCCIMICAD<TGroup> OPKADFIGBCF);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface NBMDEKGEBNM<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<KABJOCJGPGN> GBCGMECGHKF(LHBBBKIIGKG<TData> OPKADFIGBCF);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class EEOANGCFEFO<TGroup, TData> : FIABEOPHIOI<BDLMFFJFPMK<TGroup, TData>, KABJOCJGPGN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly FHKOPMGKEFD<TGroup, TData> OPKADFIGBCF;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3B95260", Offset = "0x3B94660", VA = "0x183B95260")]
	public EEOANGCFEFO(TGroup PGGLJGLHAIH, IEnumerable<TData> MFINDIDCLCA, BDLMFFJFPMK<TGroup, TData> PDCCDIALKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3B951A0", Offset = "0x3B945A0", VA = "0x183B951A0", Slot = "4")]
	public override KABJOCJGPGN EFGADDMOLKO()
	{
		return default(KABJOCJGPGN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class LIOILPNHJGN<TGroup, TData> : FIABEOPHIOI<BDLMFFJFPMK<TGroup, TData>, KABJOCJGPGN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly OBEAIOAHCPH<TGroup, TData> OPKADFIGBCF;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3F4FCE0", Offset = "0x3F4F0E0", VA = "0x183F4FCE0")]
	public LIOILPNHJGN(TGroup PGGLJGLHAIH, TData MHLMKDHMNCE, IEnumerable<TData> MFINDIDCLCA, BDLMFFJFPMK<TGroup, TData> PDCCDIALKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4630A50", Offset = "0x462FE50", VA = "0x184630A50", Slot = "4")]
	public override KABJOCJGPGN EFGADDMOLKO()
	{
		return default(KABJOCJGPGN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class EHOCKHMIICB<TGroup, TData> : FIABEOPHIOI<BDLMFFJFPMK<TGroup, TData>, KABJOCJGPGN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly NFNCCIMICAD<TGroup> OPKADFIGBCF;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3B98990", Offset = "0x3B97D90", VA = "0x183B98990")]
	public EHOCKHMIICB(TGroup PGGLJGLHAIH, BDLMFFJFPMK<TGroup, TData> PDCCDIALKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3B988D0", Offset = "0x3B97CD0", VA = "0x183B988D0", Slot = "4")]
	public override KABJOCJGPGN EFGADDMOLKO()
	{
		return default(KABJOCJGPGN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class FMJDCAHPHPH<TGroup, TData> : FIABEOPHIOI<BDLMFFJFPMK<TGroup, TData>, KABJOCJGPGN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly OBEAIOAHCPH<TGroup, TData> OPKADFIGBCF;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3F4FCE0", Offset = "0x3F4F0E0", VA = "0x183F4FCE0")]
	public FMJDCAHPHPH(TGroup PGGLJGLHAIH, TData PNGBIPKJNBL, IEnumerable<TData> MFINDIDCLCA, BDLMFFJFPMK<TGroup, TData> PDCCDIALKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3F4FC00", Offset = "0x3F4F000", VA = "0x183F4FC00", Slot = "4")]
	public override KABJOCJGPGN EFGADDMOLKO()
	{
		return default(KABJOCJGPGN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class BJOPAJIEOHG<TData> : GJHCCMNNJEO<NBMDEKGEBNM<TData>, KABJOCJGPGN> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private struct IEJADCJPDMM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AsyncTaskMethodBuilder<KABJOCJGPGN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public BJOPAJIEOHG<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private TaskAwaiter<KABJOCJGPGN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x4208B00", Offset = "0x4207F00", VA = "0x184208B00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x4208DA0", Offset = "0x42081A0", VA = "0x184208DA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private LHBBBKIIGKG<TData> OPKADFIGBCF;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3B98990", Offset = "0x3B97D90", VA = "0x183B98990")]
	public BJOPAJIEOHG(IEnumerable<TData> PCOJGFIOJAO, NBMDEKGEBNM<TData> PDCCDIALKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5253C10", Offset = "0x5253010", VA = "0x185253C10", Slot = "4")]
	[AsyncStateMachine(typeof(BJOPAJIEOHG<>.IEJADCJPDMM))]
	public override Task<KABJOCJGPGN> EFGADDMOLKO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public readonly struct KKPEIJOIKGM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly NOGAKIBHGAG HADHEABDLHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly bool HLEJMGMJJKF;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6D9B8D0", Offset = "0x6D9ACD0", VA = "0x186D9B8D0")]
	public KKPEIJOIKGM(NOGAKIBHGAG MNHHECAIMCJ, bool HGNGHAPBFEP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface PLEEMPONDGB<TSpawnType> where TSpawnType : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> EFGADDMOLKO(KKPEIJOIKGM KDDKAMAMIFC);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class LBEPFEHNDPF<TSpawnType> : GJHCCMNNJEO<PLEEMPONDGB<TSpawnType>, TSpawnType> where TSpawnType : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private struct MHDIGHAPFEC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public AsyncTaskMethodBuilder<TSpawnType> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public LBEPFEHNDPF<TSpawnType> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskAwaiter<TSpawnType> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x48CB2C0", Offset = "0x48CA6C0", VA = "0x1848CB2C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x4001890", Offset = "0x4000C90", VA = "0x184001890", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly KKPEIJOIKGM KDDKAMAMIFC;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x45DF9F0", Offset = "0x45DEDF0", VA = "0x1845DF9F0")]
	public LBEPFEHNDPF(NOGAKIBHGAG MNHHECAIMCJ, bool HGNGHAPBFEP, PLEEMPONDGB<TSpawnType> PDCCDIALKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x45DF8F0", Offset = "0x45DECF0", VA = "0x1845DF8F0", Slot = "4")]
	[AsyncStateMachine(typeof(LBEPFEHNDPF<>.MHDIGHAPFEC))]
	public override Task<TSpawnType> EFGADDMOLKO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public readonly struct NOGAKIBHGAG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly bool ADDKHOFMGKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly Vector3 GIMIAIDDGOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly Vector3 NOBECIHIBBE;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6D9BEC0", Offset = "0x6D9B2C0", VA = "0x186D9BEC0")]
	public NOGAKIBHGAG(Transform GBFKKEEIIAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6D9BE90", Offset = "0x6D9B290", VA = "0x186D9BE90")]
	public NOGAKIBHGAG(Vector3 HAGCLANLPAD, Vector3 OGKCMCMHLOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6D9BDD0", Offset = "0x6D9B1D0", VA = "0x186D9BDD0")]
	public static NOGAKIBHGAG ODIIDDIDEDO()
	{
		return default(NOGAKIBHGAG);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6D9BE00", Offset = "0x6D9B200", VA = "0x186D9BE00")]
	private NOGAKIBHGAG(bool MNJHGELAGLM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct MGOKCGEABIF<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public TNode NBIDGIHJGNK;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x48CA5B0", Offset = "0x48C99B0", VA = "0x1848CA5B0")]
	public MGOKCGEABIF(TNode NBIDGIHJGNK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct HGNJFMIEJLF<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public TNode DHEEFJOFPIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public IGLNIABPFCI DNLOBPOLEAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly bool HLEJMGMJJKF;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x414B0B0", Offset = "0x414A4B0", VA = "0x18414B0B0")]
	public HGNJFMIEJLF(TNode DHEEFJOFPIK, IGLNIABPFCI DNLOBPOLEAB, bool HGNGHAPBFEP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface GBEEEDICNHP<TNode>
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HAEKJLCBCPK([In] MGOKCGEABIF<TNode> MKKFFFNGOGF);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GFLDMFCKJKL([In] HGNJFMIEJLF<TNode> LGGDMLPHBCE);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CGJPOIOCPJF();
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class HHFGEAIDOIO<TNode> : NIILOPJNIJJ<GBEEEDICNHP<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3B9C890", Offset = "0x3B9BC90", VA = "0x183B9C890")]
	public HHFGEAIDOIO(GBEEEDICNHP<TNode> PDCCDIALKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3B9C840", Offset = "0x3B9BC40", VA = "0x183B9C840", Slot = "4")]
	public override bool EFGADDMOLKO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class FCIOHMCGKBO<TNode> : NIILOPJNIJJ<GBEEEDICNHP<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly HGNJFMIEJLF<TNode> LGGDMLPHBCE;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3F1FCE0", Offset = "0x3F1F0E0", VA = "0x183F1FCE0")]
	public FCIOHMCGKBO(TNode DHEEFJOFPIK, IGLNIABPFCI DNLOBPOLEAB, GBEEEDICNHP<TNode> PDCCDIALKJH, bool HGNGHAPBFEP = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3F1FC20", Offset = "0x3F1F020", VA = "0x183F1FC20", Slot = "4")]
	public override bool EFGADDMOLKO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class CDBNFBGIPKJ<TNode> : NIILOPJNIJJ<GBEEEDICNHP<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly MGOKCGEABIF<TNode> MKKFFFNGOGF;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x553D790", Offset = "0x553CB90", VA = "0x18553D790")]
	public CDBNFBGIPKJ(TNode BFBDAOELHHP, GBEEEDICNHP<TNode> PDCCDIALKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3F1F150", Offset = "0x3F1E550", VA = "0x183F1F150", Slot = "4")]
	public override bool EFGADDMOLKO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct NJHMIKHLBII<TSpawnInfo> where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public TSpawnInfo GAMJMIONPHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public Vector3 OGKCMCMHLOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Quaternion GEMHEIIKJKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public float EAEIAKHGPAC;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x4955150", Offset = "0x4954550", VA = "0x184955150")]
	public NJHMIKHLBII(TSpawnInfo GAMJMIONPHO, Vector3 OGKCMCMHLOD, Quaternion GEMHEIIKJKD, float EAEIAKHGPAC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface OJDNLKANJJH<TSpawnType, TSpawnInfo>
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> AILKMMFNCBO([In] NJHMIKHLBII<TSpawnInfo> ODCHNADMNFD, CancellationToken GBOOEEMCFEA);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class FDABNAMFENJ<TSpawnType, TSpawnInfo> : GJHCCMNNJEO<OJDNLKANJJH<TSpawnType, TSpawnInfo>, TSpawnType> where TSpawnType : notnull where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly NJHMIKHLBII<TSpawnInfo> KCHFAPGLICB;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x3F20230", Offset = "0x3F1F630", VA = "0x183F20230")]
	public FDABNAMFENJ(TSpawnInfo PMLLIEJEAON, Vector3 OGKCMCMHLOD, Quaternion GEMHEIIKJKD, float EAEIAKHGPAC, OJDNLKANJJH<TSpawnType, TSpawnInfo> PDCCDIALKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x3F20040", Offset = "0x3F1F440", VA = "0x183F20040", Slot = "4")]
	public override Task<TSpawnType> EFGADDMOLKO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct FFLABGHKBGP<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly IEnumerable<TData> HIGGNELFJBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly bool HLEJMGMJJKF;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3F388E0", Offset = "0x3F37CE0", VA = "0x183F388E0")]
	public FFLABGHKBGP(IEnumerable<TData> MFINDIDCLCA, bool HGNGHAPBFEP = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface MMMGCOBEBHB<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<KABJOCJGPGN> PKNKFEPMCLO([In] FFLABGHKBGP<TData> HDEDIFBOCBI, CancellationToken GBOOEEMCFEA);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public class HIDPGJMHGNI<TData> : GJHCCMNNJEO<MMMGCOBEBHB<TData>, KABJOCJGPGN> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly FFLABGHKBGP<TData> KNJCNJAPHJA;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x4155610", Offset = "0x4154A10", VA = "0x184155610")]
	public HIDPGJMHGNI(IEnumerable<TData> MFINDIDCLCA, bool HGNGHAPBFEP, MMMGCOBEBHB<TData> PDCCDIALKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x3F20040", Offset = "0x3F1F440", VA = "0x183F20040", Slot = "4")]
	public override Task<KABJOCJGPGN> EFGADDMOLKO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct OCGIKHDBOPB<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public readonly T KLACLBHAHNL;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x43DB640", Offset = "0x43DAA40", VA = "0x1843DB640")]
	public OCGIKHDBOPB(T EIKPBDLLJPP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface NCGBEPBFJME<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HAEKJLCBCPK([In] OCGIKHDBOPB<T> OBKCKIPDEAG);

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GFLDMFCKJKL();
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface BBOJBPCPGKJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EFGADDMOLKO([In] NBJIGEILHJK<T> EFPCDMIGJCB);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct NBJIGEILHJK<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public readonly T KLACLBHAHNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public readonly bool AMCNMNBNFHL;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x492EAF0", Offset = "0x492DEF0", VA = "0x18492EAF0")]
	public NBJIGEILHJK(T EIKPBDLLJPP, bool DELPDJBAHJL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class BAFCJDGCBJJ<T> : NIILOPJNIJJ<NCGBEPBFJME<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x3B9C890", Offset = "0x3B9BC90", VA = "0x183B9C890")]
	public BAFCJDGCBJJ(NCGBEPBFJME<T> PDCCDIALKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5216640", Offset = "0x5215A40", VA = "0x185216640", Slot = "4")]
	public override bool EFGADDMOLKO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class BBNHOJPNONM<T> : NIILOPJNIJJ<NCGBEPBFJME<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly OCGIKHDBOPB<T> OBKCKIPDEAG;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x521CE30", Offset = "0x521C230", VA = "0x18521CE30")]
	public BBNHOJPNONM(T KLACLBHAHNL, NCGBEPBFJME<T> PDCCDIALKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x3F1F150", Offset = "0x3F1E550", VA = "0x183F1F150", Slot = "4")]
	public override bool EFGADDMOLKO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class LLCCJAFJNLJ<T> : NIILOPJNIJJ<BBOJBPCPGKJ<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly NBJIGEILHJK<T> EFPCDMIGJCB;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4671C50", Offset = "0x4671050", VA = "0x184671C50")]
	public LLCCJAFJNLJ(T KLACLBHAHNL, bool DELPDJBAHJL, BBOJBPCPGKJ<T> PDCCDIALKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x3F1F150", Offset = "0x3F1E550", VA = "0x183F1F150", Slot = "4")]
	public override bool EFGADDMOLKO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct ODHLMEDJNGB<TData> where TData : notnull, MCMPNJHBGBI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public IEnumerable<TData> HIGGNELFJBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public bool JGAIAMBHHDA;

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x4A4A730", Offset = "0x4A49B30", VA = "0x184A4A730")]
	public ODHLMEDJNGB(IEnumerable<TData> FJMCNGNLPDK, bool DFBNKJHJEHK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public struct KHPAHILMCLJ<TData> where TData : notnull, MCMPNJHBGBI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public List<TData> HIGGNELFJBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public List<bool> LBFKEEDAALD;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x4520D80", Offset = "0x4520180", VA = "0x184520D80")]
	public KHPAHILMCLJ(List<TData> FJMCNGNLPDK, List<bool> AGCHEBOKCME)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface MCMPNJHBGBI
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool OPHAICBOGDM
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
public interface PLIIICADGJD<TData> where TData : MCMPNJHBGBI
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EFGADDMOLKO([In] ODHLMEDJNGB<TData> HFKLGBGIPGD);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EFGADDMOLKO([In] KHPAHILMCLJ<TData> HFKLGBGIPGD);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface DJAGDJDDGLO<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MNEBOKAJGHO(T KLACLBHAHNL);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class FCFLFBJIPCH<TData> : NIILOPJNIJJ<PLIIICADGJD<TData>> where TData : notnull, MCMPNJHBGBI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly ODHLMEDJNGB<TData> HFKLGBGIPGD;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x3F1F200", Offset = "0x3F1E600", VA = "0x183F1F200")]
	public FCFLFBJIPCH(List<TData> MFINDIDCLCA, bool JGAIAMBHHDA, PLIIICADGJD<TData> PDCCDIALKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x3F1F150", Offset = "0x3F1E550", VA = "0x183F1F150", Slot = "4")]
	public override bool EFGADDMOLKO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class NLMMJMBKFCN<TData> : NIILOPJNIJJ<PLIIICADGJD<TData>> where TData : notnull, MCMPNJHBGBI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly KHPAHILMCLJ<TData> HFKLGBGIPGD;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x495E7C0", Offset = "0x495DBC0", VA = "0x18495E7C0")]
	public NLMMJMBKFCN(List<TData> MFINDIDCLCA, List<bool> LBFKEEDAALD, PLIIICADGJD<TData> PDCCDIALKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x3FC2330", Offset = "0x3FC1730", VA = "0x183FC2330", Slot = "4")]
	public override bool EFGADDMOLKO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface MGGLLEGMKEE<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<KABJOCJGPGN> EFGADDMOLKO(BEHMEECJBHH<TData> DEAEKDHMOCA);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class OPHOKCMCLCM<TData> : GJHCCMNNJEO<MGGLLEGMKEE<TData>, KABJOCJGPGN> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct OAEAKMOKGPN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public AsyncTaskMethodBuilder<KABJOCJGPGN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public OPHOKCMCLCM<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter<KABJOCJGPGN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x4A41AA0", Offset = "0x4A40EA0", VA = "0x184A41AA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x4A41D80", Offset = "0x4A41180", VA = "0x184A41D80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly BEHMEECJBHH<TData> IGICKHFJFIK;

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x4A86E90", Offset = "0x4A86290", VA = "0x184A86E90")]
	public OPHOKCMCLCM(TData HFAJLFMOEPI, IReadOnlyList<TData> HACHPBJEKNP, bool HGNGHAPBFEP, MGGLLEGMKEE<TData> PDCCDIALKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x4A86D90", Offset = "0x4A86190", VA = "0x184A86D90", Slot = "4")]
	[AsyncStateMachine(typeof(OPHOKCMCLCM<>.OAEAKMOKGPN))]
	public override Task<KABJOCJGPGN> EFGADDMOLKO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public struct BEHMEECJBHH<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public TData DODKNMNENBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public IReadOnlyList<TData> CCLBGGPNELF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public bool HLEJMGMJJKF;

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x508D580", Offset = "0x508C980", VA = "0x18508D580")]
	public BEHMEECJBHH(TData HFAJLFMOEPI, IReadOnlyList<TData> HACHPBJEKNP, bool HGNGHAPBFEP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface EIPAPJNEBMH<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EFGADDMOLKO([In] MJGOPGFLCEG<TData> DGGEDLEAKKP);
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface HNNPLKEDOBN<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EFGADDMOLKO([In] DOBLAAEGFCD<TData> DGGEDLEAKKP);
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface NGJFEHEGPPK<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HPDHPGPKBLP([In] DDEOCLHLOBE<TData> DGGEDLEAKKP);

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GFLDMFCKJKL();
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class MAKIDCJEJKM<TData> : NIILOPJNIJJ<EIPAPJNEBMH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly MJGOPGFLCEG<TData> DGGEDLEAKKP;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x484F730", Offset = "0x484EB30", VA = "0x18484F730")]
	public MAKIDCJEJKM(IEnumerable<TData> MFINDIDCLCA, AKOJIOOPBLE FKCCOIADMAE, OLABBNEBBFP JAEJMKKLMIE, float EDKDHNIJFBC, bool HGNGHAPBFEP, EIPAPJNEBMH<TData> PDCCDIALKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3F1F150", Offset = "0x3F1E550", VA = "0x183F1F150", Slot = "4")]
	public override bool EFGADDMOLKO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class EHJHNLDHDLN<TData> : NIILOPJNIJJ<HNNPLKEDOBN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly DOBLAAEGFCD<TData> DGGEDLEAKKP;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3B972B0", Offset = "0x3B966B0", VA = "0x183B972B0")]
	public EHJHNLDHDLN(TData[] MFINDIDCLCA, AKOJIOOPBLE[] FKCCOIADMAE, OLABBNEBBFP[] JAEJMKKLMIE, float[] EDKDHNIJFBC, HNNPLKEDOBN<TData> PDCCDIALKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x3B97200", Offset = "0x3B96600", VA = "0x183B97200", Slot = "4")]
	public override bool EFGADDMOLKO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class GNHMECPMMFI<TData> : NIILOPJNIJJ<NGJFEHEGPPK<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3B9C890", Offset = "0x3B9BC90", VA = "0x183B9C890")]
	public GNHMECPMMFI(NGJFEHEGPPK<TData> PDCCDIALKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x407B610", Offset = "0x407AA10", VA = "0x18407B610", Slot = "4")]
	public override bool EFGADDMOLKO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class HCENLNMFLHD<TData> : NIILOPJNIJJ<NGJFEHEGPPK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly DDEOCLHLOBE<TData> DGGEDLEAKKP;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4129AD0", Offset = "0x4128ED0", VA = "0x184129AD0")]
	public HCENLNMFLHD(IEnumerable<TData> MFINDIDCLCA, AKOJIOOPBLE FKCCOIADMAE, OLABBNEBBFP JAEJMKKLMIE, float EDKDHNIJFBC, NGJFEHEGPPK<TData> PDCCDIALKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3B97200", Offset = "0x3B96600", VA = "0x183B97200", Slot = "4")]
	public override bool EFGADDMOLKO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct MJGOPGFLCEG<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public IEnumerable<TData> HIGGNELFJBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public AKOJIOOPBLE HNPECLDCLPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public OLABBNEBBFP NOGBAHLMMMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public float EDKDHNIJFBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public bool HGNGHAPBFEP;

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x48D0C40", Offset = "0x48D0040", VA = "0x1848D0C40")]
	public MJGOPGFLCEG(IEnumerable<TData> MFINDIDCLCA, AKOJIOOPBLE FKCCOIADMAE, OLABBNEBBFP JAEJMKKLMIE, float EDKDHNIJFBC, bool HGNGHAPBFEP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public struct DOBLAAEGFCD<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public TData[] HIGGNELFJBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public AKOJIOOPBLE[] HNPECLDCLPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public OLABBNEBBFP[] NOGBAHLMMMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public float[] EDKDHNIJFBC;

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5C18AC0", Offset = "0x5C17EC0", VA = "0x185C18AC0")]
	public DOBLAAEGFCD(TData[] MFINDIDCLCA, AKOJIOOPBLE[] FKCCOIADMAE, OLABBNEBBFP[] JAEJMKKLMIE, float[] EDKDHNIJFBC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public struct DDEOCLHLOBE<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public IEnumerable<TData> HIGGNELFJBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public AKOJIOOPBLE HNPECLDCLPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public OLABBNEBBFP NOGBAHLMMMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public float EDKDHNIJFBC;

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5BE7ED0", Offset = "0x5BE72D0", VA = "0x185BE7ED0")]
	public DDEOCLHLOBE(IEnumerable<TData> MFINDIDCLCA, AKOJIOOPBLE FKCCOIADMAE, OLABBNEBBFP JAEJMKKLMIE, float EDKDHNIJFBC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface PLFHOJFIJDI<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LPPBCCGCIIH([In] KFMCDGOGIMP<TData> HDEDIFBOCBI);

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GKKLJKBNMMI([In] KFMCDGOGIMP<TData> HDEDIFBOCBI);

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void COFGHENPEOA([In] bool GJLCMLDJAGM);

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CFFOFDPDMNP([In] KFMCDGOGIMP<TData> HDEDIFBOCBI);

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MNFMEKDMPHO();

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool MNEPFJCLOCP([In] TData DKACCJLBPEK);
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class NBHJMINJCBK<TData> : NIILOPJNIJJ<PLFHOJFIJDI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly KFMCDGOGIMP<TData> HDEDIFBOCBI;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x492E140", Offset = "0x492D540", VA = "0x18492E140")]
	public NBHJMINJCBK(List<TData> AKAPKCMHDAP, PLFHOJFIJDI<TData> PDCCDIALKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x3F1F150", Offset = "0x3F1E550", VA = "0x183F1F150", Slot = "4")]
	public override bool EFGADDMOLKO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class JIAODILIHOE<TData> : NIILOPJNIJJ<PLFHOJFIJDI<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3B9C890", Offset = "0x3B9BC90", VA = "0x183B9C890")]
	public JIAODILIHOE(PLFHOJFIJDI<TData> PDCCDIALKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x442C890", Offset = "0x442BC90", VA = "0x18442C890", Slot = "4")]
	public override bool EFGADDMOLKO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class HEEBFCAKLBI<TData> : NIILOPJNIJJ<PLFHOJFIJDI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly bool HGNGHAPBFEP;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x412E5F0", Offset = "0x412D9F0", VA = "0x18412E5F0")]
	public HEEBFCAKLBI(bool HGNGHAPBFEP, PLFHOJFIJDI<TData> PDCCDIALKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x412E590", Offset = "0x412D990", VA = "0x18412E590", Slot = "4")]
	public override bool EFGADDMOLKO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class ADLCNPFKAHM<TData> : NIILOPJNIJJ<PLFHOJFIJDI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly KFMCDGOGIMP<TData> HDEDIFBOCBI;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3FC2490", Offset = "0x3FC1890", VA = "0x183FC2490")]
	public ADLCNPFKAHM(List<TData> AKAPKCMHDAP, bool HGNGHAPBFEP, PLFHOJFIJDI<TData> PDCCDIALKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3FC2330", Offset = "0x3FC1730", VA = "0x183FC2330", Slot = "4")]
	public override bool EFGADDMOLKO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class AECLPCHHOOM<TData> : NIILOPJNIJJ<PLFHOJFIJDI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly TData DKACCJLBPEK;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3FC26B0", Offset = "0x3FC1AB0", VA = "0x183FC26B0")]
	public AECLPCHHOOM(TData DKACCJLBPEK, PLFHOJFIJDI<TData> PDCCDIALKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x3FC2530", Offset = "0x3FC1930", VA = "0x183FC2530", Slot = "4")]
	public override bool EFGADDMOLKO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class BDLFEAFDPMB<TData> : NIILOPJNIJJ<PLFHOJFIJDI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly KFMCDGOGIMP<TData> HDEDIFBOCBI;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x522E2D0", Offset = "0x522D6D0", VA = "0x18522E2D0")]
	public BDLFEAFDPMB(IEnumerable<TData> AKAPKCMHDAP, PLFHOJFIJDI<TData> PDCCDIALKJH, bool HGNGHAPBFEP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x522E160", Offset = "0x522D560", VA = "0x18522E160", Slot = "4")]
	public override bool EFGADDMOLKO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public struct KFMCDGOGIMP<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public IEnumerable<TData> HIGGNELFJBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public bool HGNGHAPBFEP;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x44FE5F0", Offset = "0x44FD9F0", VA = "0x1844FE5F0")]
	public KFMCDGOGIMP(IEnumerable<TData> FJMCNGNLPDK, bool DGEGJIPFIBK = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface ICBPIKCAHJG
{
	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<KABJOCJGPGN> EFGADDMOLKO(DHJELLJLHLI LCAFDBABLOP);
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public class DDGPFKJDIHI : GJHCCMNNJEO<ICBPIKCAHJG, KABJOCJGPGN>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private struct FMNABJLFLHB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public AsyncTaskMethodBuilder<KABJOCJGPGN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public DDGPFKJDIHI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private TaskAwaiter<KABJOCJGPGN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6D9AFD0", Offset = "0x6D9A3D0", VA = "0x186D9AFD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6D9B240", Offset = "0x6D9A640", VA = "0x186D9B240", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly DHJELLJLHLI DDAJJDAOOAH;

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6D9AE40", Offset = "0x6D9A240", VA = "0x186D9AE40")]
	public DDGPFKJDIHI(bool HGNGHAPBFEP, ICBPIKCAHJG PDCCDIALKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6D9AD50", Offset = "0x6D9A150", VA = "0x186D9AD50", Slot = "4")]
	[AsyncStateMachine(typeof(FMNABJLFLHB))]
	public override Task<KABJOCJGPGN> EFGADDMOLKO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public struct DHJELLJLHLI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public bool HLEJMGMJJKF;

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x2431B30", Offset = "0x2430F30", VA = "0x182431B30")]
	public DHJELLJLHLI(bool HGNGHAPBFEP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public readonly struct KCIEONNOAJE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly bool AEOJLILNFKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly bool LMEPCEMMGNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public readonly bool EAEIAKHGPAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public readonly bool HGNGHAPBFEP;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x50AB9C0", Offset = "0x50AADC0", VA = "0x1850AB9C0")]
	public KCIEONNOAJE(bool AEOJLILNFKE, bool LMEPCEMMGNI, bool EAEIAKHGPAC, bool HGNGHAPBFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6D9B8C0", Offset = "0x6D9ACC0", VA = "0x186D9B8C0")]
	public KCIEONNOAJE(bool LMEPCEMMGNI, bool HGNGHAPBFEP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public interface NFLNHEOJEDP
{
	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CIEEBLFDBOE(KCIEONNOAJE EOPPFNGFLAF);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EELHOOHGHBD(KCIEONNOAJE EOPPFNGFLAF);
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class LNOMBEAFICK : NIILOPJNIJJ<NFLNHEOJEDP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly KCIEONNOAJE EOPPFNGFLAF;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6D9BD40", Offset = "0x6D9B140", VA = "0x186D9BD40")]
	public LNOMBEAFICK(bool JGDFNKEDOMO, bool LMEPCEMMGNI, bool EAEIAKHGPAC, bool HGNGHAPBFEP, NFLNHEOJEDP PDCCDIALKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6D9BCF0", Offset = "0x6D9B0F0", VA = "0x186D9BCF0", Slot = "4")]
	public override bool EFGADDMOLKO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class INCMDCGNFDL : NIILOPJNIJJ<NFLNHEOJEDP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly KCIEONNOAJE EOPPFNGFLAF;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6D9B840", Offset = "0x6D9AC40", VA = "0x186D9B840")]
	public INCMDCGNFDL(bool LMEPCEMMGNI, bool HGNGHAPBFEP, NFLNHEOJEDP PDCCDIALKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6D9B7F0", Offset = "0x6D9ABF0", VA = "0x186D9B7F0", Slot = "4")]
	public override bool EFGADDMOLKO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public interface MAMFALHEGKH
{
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EFGADDMOLKO([In] PDCNIMGPGOM HGMDCBGHOPA);
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class GBNBEFOIAIA : NIILOPJNIJJ<MAMFALHEGKH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly PDCNIMGPGOM HGMDCBGHOPA;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6D9B590", Offset = "0x6D9A990", VA = "0x186D9B590")]
	public GBNBEFOIAIA(Guid[] OBJICMNGFJI, Vector3[] AEJPGHGNHOG, Quaternion[] NKJILMGKFJD, float[] OPMEAOANBED, Dictionary<Guid, Vector3> CKFLGNBAKHG, MAMFALHEGKH PDCCDIALKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6D9B4E0", Offset = "0x6D9A8E0", VA = "0x186D9B4E0", Slot = "4")]
	public override bool EFGADDMOLKO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public interface AOHGNPANELI<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HAEKJLCBCPK([In] FGPFLIHFLGO<TData> MKKFFFNGOGF);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HPDHPGPKBLP([In] LJFJOCONDFC ECGIOLBMBFH);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HPDHPGPKBLP([In] HCJIKHANGCK ECGIOLBMBFH);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool GFLDMFCKJKL();
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class JLBLNDFJEMO<TData> : NIILOPJNIJJ<AOHGNPANELI<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3B9C890", Offset = "0x3B9BC90", VA = "0x183B9C890")]
	public JLBLNDFJEMO(AOHGNPANELI<TData> PDCCDIALKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x4434870", Offset = "0x4433C70", VA = "0x184434870", Slot = "4")]
	public override bool EFGADDMOLKO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class HOLNJOHMHGD<TData> : NIILOPJNIJJ<AOHGNPANELI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly LJFJOCONDFC IBCMMDBCBCI;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x4167A20", Offset = "0x4166E20", VA = "0x184167A20")]
	public HOLNJOHMHGD(Vector3 IFABKDGCMHP, bool EIOIHLBAPCD, AOHGNPANELI<TData> PDCCDIALKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x4051710", Offset = "0x4050B10", VA = "0x184051710", Slot = "4")]
	public override bool EFGADDMOLKO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class AFOIGCNLLJE<TData> : NIILOPJNIJJ<AOHGNPANELI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly HCJIKHANGCK IBCMMDBCBCI;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x3FDD300", Offset = "0x3FDC700", VA = "0x183FDD300")]
	public AFOIGCNLLJE(Guid FHGKPIKMLJI, int OBFJPFHENMC, Vector3 OGKCMCMHLOD, Quaternion GEMHEIIKJKD, float JBJFBPBLEOH, bool EIOIHLBAPCD, AOHGNPANELI<TData> PDCCDIALKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x3FDD2A0", Offset = "0x3FDC6A0", VA = "0x183FDD2A0", Slot = "4")]
	public override bool EFGADDMOLKO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class NLJDNHDIBNG<TData> : NIILOPJNIJJ<AOHGNPANELI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly FGPFLIHFLGO<TData> IBCMMDBCBCI;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x495E3C0", Offset = "0x495D7C0", VA = "0x18495E3C0")]
	public NLJDNHDIBNG(TData KLACLBHAHNL, bool HGNGHAPBFEP, AOHGNPANELI<TData> PDCCDIALKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x3F1F150", Offset = "0x3F1E550", VA = "0x183F1F150", Slot = "4")]
	public override bool EFGADDMOLKO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public struct LJFJOCONDFC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly Vector3 IFABKDGCMHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public readonly bool EIOIHLBAPCD;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6D9BCD0", Offset = "0x6D9B0D0", VA = "0x186D9BCD0")]
	public LJFJOCONDFC(Vector3 IFABKDGCMHP, bool EIOIHLBAPCD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public struct HCJIKHANGCK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public readonly Guid FHGKPIKMLJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public readonly int OBFJPFHENMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public readonly Vector3 OGKCMCMHLOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public readonly Quaternion GEMHEIIKJKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public readonly float JBJFBPBLEOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public readonly bool EIOIHLBAPCD;

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6D9B770", Offset = "0x6D9AB70", VA = "0x186D9B770")]
	public HCJIKHANGCK(Guid FHGKPIKMLJI, int OBFJPFHENMC, Vector3 OGKCMCMHLOD, Quaternion GEMHEIIKJKD, float JBJFBPBLEOH, bool EIOIHLBAPCD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public struct FGPFLIHFLGO<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public readonly TData KLACLBHAHNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public readonly bool HGNGHAPBFEP;

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x3F3CDA0", Offset = "0x3F3C1A0", VA = "0x183F3CDA0")]
	public FGPFLIHFLGO(TData KLACLBHAHNL, bool HGNGHAPBFEP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public interface GHJMDPPEANC<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EFGADDMOLKO([In] MJHIAKAKHEE<TData> KOKIHOGELFO);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EFGADDMOLKO([In] EMCIAGPBFCH<TData> KOKIHOGELFO);
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public interface BEKJDCKKILL<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HAEKJLCBCPK([In] NGHCAELHCKP<TData> KEJJNHDOMDM);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HPDHPGPKBLP([In] GLNFBOPPMJF ECGIOLBMBFH);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GFLDMFCKJKL();
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class MGHKENBICDH<TData> : NIILOPJNIJJ<GHJMDPPEANC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly MJHIAKAKHEE<TData> KOKIHOGELFO;

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x48C4B30", Offset = "0x48C3F30", VA = "0x1848C4B30")]
	public MGHKENBICDH(IEnumerable<TData> MFINDIDCLCA, Vector3 BKNMBOHGKOK, bool HGNGHAPBFEP, GHJMDPPEANC<TData> PDCCDIALKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x3F1F150", Offset = "0x3F1E550", VA = "0x183F1F150", Slot = "4")]
	public override bool EFGADDMOLKO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class MDJLEGKONNA<TData> : NIILOPJNIJJ<BEKJDCKKILL<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x3B9C890", Offset = "0x3B9BC90", VA = "0x183B9C890")]
	public MDJLEGKONNA(BEKJDCKKILL<TData> PDCCDIALKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x3B9C840", Offset = "0x3B9BC40", VA = "0x183B9C840", Slot = "4")]
	public override bool EFGADDMOLKO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class PJJJKANMEOD<TData> : NIILOPJNIJJ<BEKJDCKKILL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly NGHCAELHCKP<TData> KOKIHOGELFO;

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x4B3DBF0", Offset = "0x4B3CFF0", VA = "0x184B3DBF0")]
	public PJJJKANMEOD(IEnumerable<TData> MFINDIDCLCA, bool HGNGHAPBFEP, BEKJDCKKILL<TData> PDCCDIALKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3F1F150", Offset = "0x3F1E550", VA = "0x183F1F150", Slot = "4")]
	public override bool EFGADDMOLKO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class IMEPOMCJKBH<TData> : NIILOPJNIJJ<GHJMDPPEANC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly EMCIAGPBFCH<TData> KOKIHOGELFO;

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x423A720", Offset = "0x4239B20", VA = "0x18423A720")]
	public IMEPOMCJKBH(IEnumerable<TData> MFINDIDCLCA, Vector3 IFEKGBNNLOL, KKDGNJDBBEK JIAGHINHCKP, bool HGNGHAPBFEP, GHJMDPPEANC<TData> PDCCDIALKJH, Space FPDADAFPMML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x3F1FC20", Offset = "0x3F1F020", VA = "0x183F1FC20", Slot = "4")]
	public override bool EFGADDMOLKO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public class LCNNENCKHLP<TData> : NIILOPJNIJJ<BEKJDCKKILL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly GLNFBOPPMJF KOKIHOGELFO;

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x45E1600", Offset = "0x45E0A00", VA = "0x1845E1600")]
	public LCNNENCKHLP(Vector3 BKNMBOHGKOK, BEKJDCKKILL<TData> PDCCDIALKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x4051710", Offset = "0x4050B10", VA = "0x184051710", Slot = "4")]
	public override bool EFGADDMOLKO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct MJHIAKAKHEE<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public readonly IEnumerable<TData> MFINDIDCLCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public readonly Vector3 BKNMBOHGKOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public readonly bool HGNGHAPBFEP;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x48D0D70", Offset = "0x48D0170", VA = "0x1848D0D70")]
	public MJHIAKAKHEE(IEnumerable<TData> MFINDIDCLCA, Vector3 BKNMBOHGKOK, bool HGNGHAPBFEP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct NGHCAELHCKP<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public readonly IEnumerable<TData> MFINDIDCLCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public readonly bool HGNGHAPBFEP;

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x4948B60", Offset = "0x4947F60", VA = "0x184948B60")]
	public NGHCAELHCKP(IEnumerable<TData> MFINDIDCLCA, bool HGNGHAPBFEP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct EMCIAGPBFCH<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public readonly IEnumerable<TData> MFINDIDCLCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public readonly Vector3 IFEKGBNNLOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly KKDGNJDBBEK JIAGHINHCKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public readonly bool HGNGHAPBFEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly Space FPDADAFPMML;

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x3BAB1F0", Offset = "0x3BAA5F0", VA = "0x183BAB1F0")]
	public EMCIAGPBFCH(IEnumerable<TData> MFINDIDCLCA, Vector3 IFEKGBNNLOL, KKDGNJDBBEK JIAGHINHCKP, bool HGNGHAPBFEP, Space FPDADAFPMML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public struct GLNFBOPPMJF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public readonly Vector3 BKNMBOHGKOK;

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x2431870", Offset = "0x2430C70", VA = "0x182431870")]
	public GLNFBOPPMJF(Vector3 BKNMBOHGKOK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public enum KKDGNJDBBEK
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
public interface MPBKKPPOJIP
{
	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EFGADDMOLKO([In] BACCFEPNOEM DHODPHJPBDJ);
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class DDKFNABKMFL : NIILOPJNIJJ<MPBKKPPOJIP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly BACCFEPNOEM DHODPHJPBDJ;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6D9AF50", Offset = "0x6D9A350", VA = "0x186D9AF50")]
	public DDKFNABKMFL(bool HGNGHAPBFEP, MPBKKPPOJIP PDCCDIALKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6D9AEA0", Offset = "0x6D9A2A0", VA = "0x186D9AEA0", Slot = "4")]
	public override bool EFGADDMOLKO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public readonly struct BACCFEPNOEM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public readonly bool HGNGHAPBFEP;

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x2431B30", Offset = "0x2430F30", VA = "0x182431B30")]
	public BACCFEPNOEM(bool HGNGHAPBFEP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public interface JJEFLJNNODH<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EFGADDMOLKO([In] LHIJHKAPFCB<TData> DPMADKKIEFB);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EFGADDMOLKO([In] JKDMHBNFGKJ<TData> DPMADKKIEFB);
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public interface MOGMKJINCAG<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HAEKJLCBCPK([In] JFMHAPKMKNF<TData> MKKFFFNGOGF);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HPDHPGPKBLP([In] MEEHKNJDMCK ECGIOLBMBFH);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GFLDMFCKJKL();
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class BBIKHDGBJNO<TData> : NIILOPJNIJJ<JJEFLJNNODH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly LHIJHKAPFCB<TData> DPMADKKIEFB;

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x52191A0", Offset = "0x52185A0", VA = "0x1852191A0")]
	public BBIKHDGBJNO(IEnumerable<TData> MFINDIDCLCA, Quaternion BKNMBOHGKOK, Vector3? FHEDADKBMPL, bool DCEIAAIPMIB, bool HGNGHAPBFEP, JJEFLJNNODH<TData> PDCCDIALKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x3F1F150", Offset = "0x3F1E550", VA = "0x183F1F150", Slot = "4")]
	public override bool EFGADDMOLKO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class EJEDLNDGIOD<TData> : NIILOPJNIJJ<MOGMKJINCAG<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x3B9C890", Offset = "0x3B9BC90", VA = "0x183B9C890")]
	public EJEDLNDGIOD(MOGMKJINCAG<TData> PDCCDIALKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x3B9C840", Offset = "0x3B9BC40", VA = "0x183B9C840", Slot = "4")]
	public override bool EFGADDMOLKO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class APENICFECBE<TData> : NIILOPJNIJJ<MOGMKJINCAG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly JFMHAPKMKNF<TData> DPMADKKIEFB;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x421B440", Offset = "0x421A840", VA = "0x18421B440")]
	public APENICFECBE(IEnumerable<TData> MFINDIDCLCA, bool HGNGHAPBFEP, MOGMKJINCAG<TData> PDCCDIALKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x3F1F150", Offset = "0x3F1E550", VA = "0x183F1F150", Slot = "4")]
	public override bool EFGADDMOLKO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class CBANDIKOKJB<TData> : NIILOPJNIJJ<JJEFLJNNODH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly JKDMHBNFGKJ<TData> DPMADKKIEFB;

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x544DF70", Offset = "0x544D370", VA = "0x18544DF70")]
	public CBANDIKOKJB(IEnumerable<TData> MFINDIDCLCA, Quaternion PFIIJNABFJM, KKDGNJDBBEK LAIDMIAKKGO, Vector3? FHEDADKBMPL, bool DCEIAAIPMIB, bool HGNGHAPBFEP, Space FPDADAFPMML, JJEFLJNNODH<TData> PDCCDIALKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x3F1FC20", Offset = "0x3F1F020", VA = "0x183F1FC20", Slot = "4")]
	public override bool EFGADDMOLKO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public class GINKFELMIGD<TData> : NIILOPJNIJJ<MOGMKJINCAG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly MEEHKNJDMCK DPMADKKIEFB;

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x4051770", Offset = "0x4050B70", VA = "0x184051770")]
	public GINKFELMIGD(Quaternion BKNMBOHGKOK, Vector3? FHEDADKBMPL, bool DCEIAAIPMIB, MOGMKJINCAG<TData> PDCCDIALKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x4051710", Offset = "0x4050B10", VA = "0x184051710", Slot = "4")]
	public override bool EFGADDMOLKO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public struct LHIJHKAPFCB<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public readonly IEnumerable<TData> MFINDIDCLCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public readonly Quaternion BKNMBOHGKOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public readonly Vector3? FHEDADKBMPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public readonly bool DCEIAAIPMIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public readonly bool HGNGHAPBFEP;

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x4607BF0", Offset = "0x4606FF0", VA = "0x184607BF0")]
	public LHIJHKAPFCB(IEnumerable<TData> MFINDIDCLCA, Quaternion BKNMBOHGKOK, Vector3? FHEDADKBMPL, bool DCEIAAIPMIB, bool HGNGHAPBFEP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public struct JFMHAPKMKNF<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public readonly IEnumerable<TData> MFINDIDCLCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly bool HGNGHAPBFEP;

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x43E85C0", Offset = "0x43E79C0", VA = "0x1843E85C0")]
	public JFMHAPKMKNF(IEnumerable<TData> MFINDIDCLCA, bool HGNGHAPBFEP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public struct JKDMHBNFGKJ<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public readonly IEnumerable<TData> MFINDIDCLCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public readonly Quaternion PFIIJNABFJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public readonly KKDGNJDBBEK LAIDMIAKKGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public readonly Vector3? FHEDADKBMPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public readonly bool DCEIAAIPMIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public readonly bool HGNGHAPBFEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public readonly Space FPDADAFPMML;

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x4430C10", Offset = "0x4430010", VA = "0x184430C10")]
	public JKDMHBNFGKJ(IEnumerable<TData> MFINDIDCLCA, Quaternion PFIIJNABFJM, KKDGNJDBBEK LAIDMIAKKGO, Vector3? FHEDADKBMPL, bool DCEIAAIPMIB, bool HGNGHAPBFEP, Space FPDADAFPMML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public struct MEEHKNJDMCK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public readonly Quaternion BKNMBOHGKOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public readonly Vector3? FHEDADKBMPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public readonly bool DCEIAAIPMIB;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x505E240", Offset = "0x505D640", VA = "0x18505E240")]
	public MEEHKNJDMCK(Quaternion BKNMBOHGKOK, Vector3? FHEDADKBMPL, bool DCEIAAIPMIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public interface NMIBKKABKLK<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HAEKJLCBCPK([In] HDNKENCKPHJ<TData> MKKFFFNGOGF);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HPDHPGPKBLP([In] MJKAFEKDBPH ECGIOLBMBFH);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HPDHPGPKBLP([In] FDEBKCKNGOI ECGIOLBMBFH);

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HPDHPGPKBLP([In] HJNAIJAIAMA ECGIOLBMBFH);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool GFLDMFCKJKL();
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public class GFILPHIAIKD<TData> : NIILOPJNIJJ<NMIBKKABKLK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly HJNAIJAIAMA JELOCIPLOGO;

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x4044D60", Offset = "0x4044160", VA = "0x184044D60")]
	public GFILPHIAIKD(Vector3 GDMIBONJIJP, float LOJPFHOMPIH, Vector3 FHEDADKBMPL, bool ANAIHFOMCEB, bool IEHDIHFLMNA, NMIBKKABKLK<TData> PDCCDIALKJH, Space FPDADAFPMML = Space.Self)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x4044D00", Offset = "0x4044100", VA = "0x184044D00", Slot = "4")]
	public override bool EFGADDMOLKO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class LFOAEEJIOGE<TData> : NIILOPJNIJJ<NMIBKKABKLK<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x3B9C890", Offset = "0x3B9BC90", VA = "0x183B9C890")]
	public LFOAEEJIOGE(NMIBKKABKLK<TData> PDCCDIALKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x45ED2C0", Offset = "0x45EC6C0", VA = "0x1845ED2C0", Slot = "4")]
	public override bool EFGADDMOLKO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class LLNABOBGALF<TData> : NIILOPJNIJJ<NMIBKKABKLK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly HDNKENCKPHJ<TData> JELOCIPLOGO;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x4677CC0", Offset = "0x46770C0", VA = "0x184677CC0")]
	public LLNABOBGALF(IEnumerable<TData> MFINDIDCLCA, bool HGNGHAPBFEP, NMIBKKABKLK<TData> PDCCDIALKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x3F1F150", Offset = "0x3F1E550", VA = "0x183F1F150", Slot = "4")]
	public override bool EFGADDMOLKO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class HGJFBBHANDO<TData> : NIILOPJNIJJ<NMIBKKABKLK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly FDEBKCKNGOI JELOCIPLOGO;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x414AFF0", Offset = "0x414A3F0", VA = "0x18414AFF0")]
	public HGJFBBHANDO(float PGLMHHCODLN, bool AOMHHMIKCIA, Vector3 FHEDADKBMPL, NMIBKKABKLK<TData> PDCCDIALKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x414AF30", Offset = "0x414A330", VA = "0x18414AF30", Slot = "4")]
	public override bool EFGADDMOLKO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public class NJJMLEDPMPG<TData> : NIILOPJNIJJ<NMIBKKABKLK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly MJKAFEKDBPH JELOCIPLOGO;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x4955180", Offset = "0x4954580", VA = "0x184955180")]
	public NJJMLEDPMPG(float LOJPFHOMPIH, Vector3 FHEDADKBMPL, NMIBKKABKLK<TData> PDCCDIALKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x4051710", Offset = "0x4050B10", VA = "0x184051710", Slot = "4")]
	public override bool EFGADDMOLKO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public struct HJNAIJAIAMA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public readonly Vector3 GDMIBONJIJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public readonly float LOJPFHOMPIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public readonly Vector3 FHEDADKBMPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public readonly bool EIOIHLBAPCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public readonly Space FPDADAFPMML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public readonly bool IEHDIHFLMNA;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x6D9B7B0", Offset = "0x6D9ABB0", VA = "0x186D9B7B0")]
	public HJNAIJAIAMA(Vector3 GDMIBONJIJP, float LOJPFHOMPIH, Vector3 FHEDADKBMPL, bool EIOIHLBAPCD, bool BLDDMMDPKNH, Space FPDADAFPMML = Space.Self)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct HDNKENCKPHJ<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public readonly IEnumerable<TData> MFINDIDCLCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public readonly bool HGNGHAPBFEP;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x412C120", Offset = "0x412B520", VA = "0x18412C120")]
	public HDNKENCKPHJ(IEnumerable<TData> MFINDIDCLCA, bool HGNGHAPBFEP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public struct FDEBKCKNGOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public readonly float PGLMHHCODLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public readonly bool AOMHHMIKCIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public readonly Vector3 FHEDADKBMPL;

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6D9AFB0", Offset = "0x6D9A3B0", VA = "0x186D9AFB0")]
	public FDEBKCKNGOI(float PGLMHHCODLN, bool AOMHHMIKCIA, Vector3 FHEDADKBMPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct MJKAFEKDBPH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public readonly float LOJPFHOMPIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public readonly Vector3 FHEDADKBMPL;

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x50316C0", Offset = "0x5030AC0", VA = "0x1850316C0")]
	public MJKAFEKDBPH(float LOJPFHOMPIH, Vector3 FHEDADKBMPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public struct PDCNIMGPGOM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public readonly Guid[] MFINDIDCLCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public readonly bool KHIGONNFAJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public readonly bool FHJMLDAJMHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public readonly bool EPBKHGFKLAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public readonly Vector3[] AEJPGHGNHOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public readonly Quaternion[] NKJILMGKFJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly float[] OPMEAOANBED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public readonly Dictionary<Guid, Vector3> CKFLGNBAKHG;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6D9C180", Offset = "0x6D9B580", VA = "0x186D9C180")]
	public PDCNIMGPGOM(Guid[] OBJICMNGFJI, Vector3[] AEJPGHGNHOG, Quaternion[] NKJILMGKFJD, float[] OPMEAOANBED, Dictionary<Guid, Vector3> CKFLGNBAKHG, bool KHIGONNFAJN = true, bool FHJMLDAJMHG = true, bool EPBKHGFKLAE = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6D9BFB0", Offset = "0x6D9B3B0", VA = "0x186D9BFB0")]
	private static void DFKNHOAOELI(Dictionary<Guid, Vector3> CKFLGNBAKHG, int EKBJAACONED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public static class KPLBFOMIIDD
{
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	private struct NDBNBOABLMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public bool IGPBOADCNFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public MCLDCOGKKML PBFKJHLDCLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public MCLDCOGKKML PHIGNPEOCPF;
	}

	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private static NDBNBOABLMI KFEHGBPFBHD;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static CancellationToken JIBAHPJFCKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6D9B990", Offset = "0x6D9AD90", VA = "0x186D9B990")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	internal static MCLDCOGKKML PBFKJHLDCLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x6D9B8F0", Offset = "0x6D9ACF0", VA = "0x186D9B8F0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x6D9BA00", Offset = "0x6D9AE00", VA = "0x186D9BA00")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6D9BA70", Offset = "0x6D9AE70", VA = "0x186D9BA70")]
	[GOEIKLHOLGG.MKEGAHCPJHM]
	internal static void IMCINAOJNGK(MCLDCOGKKML KDBCHBJHHOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6D9BB70", Offset = "0x6D9AF70", VA = "0x186D9BB70")]
	public static void PGGELGPJGKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6D9B9B0", Offset = "0x6D9ADB0", VA = "0x186D9B9B0")]
	private static MCLDCOGKKML DMOKOCHJPKN(MCLDCOGKKML NPCCAEGKJNF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public static class IKMGIOPHDKA
{
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public enum BGNJINNDOEG
	{
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		ICreationContextObject,
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		Guid
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x2EECB10", Offset = "0x2EEBF10", VA = "0x182EECB10")]
	public static void PJLDEGNPBCB<T>(T NAEMIMNOMOI, BGNJINNDOEG EKNPHEPNHJD) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x2EECC80", Offset = "0x2EEC080", VA = "0x182EECC80")]
	public static void PJLDEGNPBCB<T>(T NAEMIMNOMOI) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x2EEC690", Offset = "0x2EEBA90", VA = "0x182EEC690")]
	public static void FCIPPANCGEN<T>(T NAEMIMNOMOI) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x2EEC740", Offset = "0x2EEBB40", VA = "0x182EEC740")]
	public static T GEKLBPFDDHO<T>(BGNJINNDOEG EKNPHEPNHJD) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x2EEC910", Offset = "0x2EEBD10", VA = "0x182EEC910")]
	public static bool IELONOIKEDC<T>(BGNJINNDOEG EKNPHEPNHJD, T? FGLEALLIGPD, [Out][MaybeNullWhen(false)][NotNullWhen(true)] T OLEEHDHLPIM) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x2EECA60", Offset = "0x2EEBE60", VA = "0x182EECA60")]
	public static bool OKPDOKKJAMB<T>(BGNJINNDOEG EKNPHEPNHJD) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x2EEC7F0", Offset = "0x2EEBBF0", VA = "0x182EEC7F0")]
	public static T GEKLBPFDDHO<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x2EEC850", Offset = "0x2EEBC50", VA = "0x182EEC850")]
	public static bool IELONOIKEDC<T>(T FGLEALLIGPD, [Out] T OLEEHDHLPIM) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x2EEC7F0", Offset = "0x2EEBBF0", VA = "0x182EEC7F0")]
	public static bool OKPDOKKJAMB<T>() where T : class
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
internal static class FOGOALFMPFF
{
	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6D9B2B0", Offset = "0x6D9A6B0", VA = "0x186D9B2B0")]
	public static void JCGOEDLHPKJ(IEnumerable PCOKDBCIIJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x2EA0CB0", Offset = "0x2EA00B0", VA = "0x182EA0CB0")]
	public static void JCGOEDLHPKJ<T>(T[] EFKOIGFMOHD) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x2EA0E90", Offset = "0x2EA0290", VA = "0x182EA0E90")]
	public static void JCGOEDLHPKJ<T>(T LFKMIMEIEKO) where T : notnull, Enum
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
