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
using RecRoom.DataLayer.Registration;
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
		[Cpp2IlInjected.Address(RVA = "0xA336C0", Offset = "0xA324C0", VA = "0x180A336C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7DFAB50", Offset = "0x7DF9950", VA = "0x187DFAB50")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA34390", Offset = "0xA33190", VA = "0x180A34390")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA343D0", Offset = "0xA331D0", VA = "0x180A343D0")]
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
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7DFB080", Offset = "0x7DF9E80", VA = "0x187DFB080", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x26D4E40", Offset = "0x26D3C40", VA = "0x1826D4E40")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum DINLMEFIJHD
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	NameAZ,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	NameZA,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	InkCostAsc,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	InkCostDesc,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Oldest,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Newest
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface ODAGGICCKGP<TData, TReturn>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TReturn IIGGCIKNHEP(TData GLEBGNJJOHG);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface BKMNNBHDGIJ<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ClearHoverTarget(NOMOLJBFMAO INILFODDBCH);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool SetHoverTarget(TData GDCDKMJLKDH, Collider BFJFHFGHLFL, NOMOLJBFMAO INILFODDBCH, [Optional] MNEOPFCLMIK? KMBDGFJDKNA);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool TryGetHoverTarget([Out] TData GDCDKMJLKDH);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetHoverCollider([Out] Collider BFJFHFGHLFL);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface DAJOMBBCFOF<TData> : GMIKEFGIKFD, EKENCJKNMEG<TData>, OEBLCEEELAP<TData>, DEMHLHHDNIH<TData>, LHDEOAHMLGK, KJMDFLMFAHO<TData>, ICNDLGEPNBD, OMPBIMGFADM
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface KJMDFLMFAHO<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 NECPJOOPKDH, Vector3 MACLBEFOGKL, float HBKDKLDLCIL, [Out] T LILIODMFHCA, [Out] Vector3 NJFEDHHEKCM, [Out] Collider BFJFHFGHLFL);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 NECPJOOPKDH, Vector3 MACLBEFOGKL, float DBOLNJEHHJK, float HBKDKLDLCIL, T[] ALKPEGPLIEE, [Out] Vector3 IGLEKBOGPCC, [Out] Collider JJNDCICHGOP);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 NECPJOOPKDH, float DBOLNJEHHJK, Vector3 EGIJNOFPGLD, T[] ALKPEGPLIEE);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetObjectFromColliderInCurrentScope(Collider LMKDHIOMNKO, [Out] T IDLDBPMIDDH);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface GMIKEFGIKFD
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Bounds EIIBADLPDDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Transform MLEICEHANGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Bounds NIENBABLNNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Transform DBEBGKJJHJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Vector3 DEIFLPMHBKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool DLKACPMNPBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void UpdateLocalSelectionBounds();

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void SetSelectionBoundsDirty(bool EECFFLAGLOH = true, int FIDOCNHCGIN = 0);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ShouldHideSelectionBoundsPreview(bool JMFJIMNKOFC, object JLFLGDNCANL);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface OMPBIMGFADM
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	LLEAAEBCCKF HFKLPHJEOOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface EHGFFAJEPHO
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool NMJECDLPKGP
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool GICLAMHJJBE
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool MCGCIBJJKEH
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Dictionary<Guid, Guid> TryGetPreviousCloneMapping();

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void TrySetPreviousCloneMapping(Dictionary<Guid, Guid> BILAOJEAEKA);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface DEMHLHHDNIH<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool GAKNEPGKHIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int DABOGEOMEEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<TData> ODGDCAJJLNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData HHHFHHLBBIL);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData HHHFHHLBBIL);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface EKENCJKNMEG<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T GLEBGNJJOHG, [Optional] MNEOPFCLMIK? IBFIHEMIHJO, bool PABGOHLCBLG = true);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int ALFGNAHPKIG, IEnumerable<T> PFFDFBCPKLN, bool PABGOHLCBLG = true);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int ALFGNAHPKIG, IEnumerable<T> PFFDFBCPKLN, MNEOPFCLMIK IBFIHEMIHJO, bool PABGOHLCBLG = true);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface ICNDLGEPNBD
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface LHDEOAHMLGK
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool EIHGIANDJMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool BDKPHGCBMGK
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool IAINOGAMEIL
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool IAKHLJCKAMP
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct PPKHGOMMIPO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public bool BGEMPBNDKII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public float? PMPCJAIMGMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public float? EKLEEDMAHAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public float? PHGDKKPBPOH;
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct FIMIFJMBMFF<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public IEnumerable<TData> GBBLEMFGOCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public PPKHGOMMIPO KFDICACNJIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public bool JMEPPEPPAHG;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4ACF240", Offset = "0x4ACE040", VA = "0x184ACF240")]
	public FIMIFJMBMFF(IEnumerable<TData> DIGOGLIAEGA, bool INALLKJPOPL, float? NGMONCNGBMJ, float? MIBGBKPCNLH, float? HIFOHDMLFOA, bool JMEPPEPPAHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface MLKBJNFGIHN<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FNJHBOGPDPJ([In] FIMIFJMBMFF<TData> AOGFOJGFMAN);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class NMCOFFFGHFG<TData> : BJPJICGGIOC<MLKBJNFGIHN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly FIMIFJMBMFF<TData> AOGFOJGFMAN;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x54FE9E0", Offset = "0x54FD7E0", VA = "0x1854FE9E0")]
	public NMCOFFFGHFG(IEnumerable<TData> DIGOGLIAEGA, bool INALLKJPOPL, float? NGMONCNGBMJ, float? MIBGBKPCNLH, float? HIFOHDMLFOA, bool JMEPPEPPAHG, MLKBJNFGIHN<TData> HAAEOKEMPKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4B84CF0", Offset = "0x4B83AF0", VA = "0x184B84CF0", Slot = "4")]
	public override bool FNJHBOGPDPJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct LLDMJLELINB<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public IEnumerable<TData> GBBLEMFGOCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public string OGEKIGBBLLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public bool LEHOBINHCCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public bool JMEPPEPPAHG;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x51A1350", Offset = "0x51A0150", VA = "0x1851A1350")]
	public LLDMJLELINB(IEnumerable<TData> DIGOGLIAEGA, string DBCDJMCMAJM, bool OFMOPHMFPGE, bool JMEPPEPPAHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface AMNJGAMJELL<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FNJHBOGPDPJ([In] LLDMJLELINB<TData> AOGFOJGFMAN);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class ICOHJMEJIFC<TData> : BJPJICGGIOC<AMNJGAMJELL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly LLDMJLELINB<TData> AOGFOJGFMAN;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4D2D950", Offset = "0x4D2C750", VA = "0x184D2D950")]
	public ICOHJMEJIFC(IEnumerable<TData> DIGOGLIAEGA, string DBCDJMCMAJM, bool OFMOPHMFPGE, bool JMEPPEPPAHG, AMNJGAMJELL<TData> HAAEOKEMPKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x4B84CF0", Offset = "0x4B83AF0", VA = "0x184B84CF0", Slot = "4")]
	public override bool FNJHBOGPDPJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public abstract class BJPJICGGIOC<TReceiver> : HECAINAPJKJ<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x45F98E0", Offset = "0x45F86E0", VA = "0x1845F98E0")]
	public BJPJICGGIOC(TReceiver HAAEOKEMPKE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public abstract class DIJCELKEAGC<TReceiver, TFromTask> : HECAINAPJKJ<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x45F98E0", Offset = "0x45F86E0", VA = "0x1845F98E0")]
	public DIJCELKEAGC(TReceiver HAAEOKEMPKE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class HECAINAPJKJ<TReceiver, TFromExecute> where TReceiver : notnull where TFromExecute : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	protected TReceiver HAAEOKEMPKE;

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4C1C8B0", Offset = "0x4C1B6B0", VA = "0x184C1C8B0")]
	public HECAINAPJKJ(TReceiver HAAEOKEMPKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute FNJHBOGPDPJ();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class BILJHKFDHCH<TReceiver, TResult> : HECAINAPJKJ<TReceiver, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x45F98E0", Offset = "0x45F86E0", VA = "0x1845F98E0")]
	public BILJHKFDHCH(TReceiver HAAEOKEMPKE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct LNGGDJBKDAO<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public TGroup FONOPDFDMCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public TData NGFNEJLAOIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public IEnumerable<TData> GBBLEMFGOCJ;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x220D9F0", Offset = "0x220C7F0", VA = "0x18220D9F0")]
	public LNGGDJBKDAO(TGroup HJIOIGDNMJB, TData AFOGLKPJEIH, IEnumerable<TData> DIGOGLIAEGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct DECFFDKLJIC<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public TGroup FONOPDFDMCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public IEnumerable<TData> GBBLEMFGOCJ;

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0xAE6A40", Offset = "0xAE5840", VA = "0x180AE6A40")]
	public DECFFDKLJIC(TGroup HJIOIGDNMJB, IEnumerable<TData> DIGOGLIAEGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct DIJJFHFMICL<TGroup> where TGroup : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public TGroup FONOPDFDMCK;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0xD5BCB0", Offset = "0xD5AAB0", VA = "0x180D5BCB0")]
	public DIJJFHFMICL(TGroup HJIOIGDNMJB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct PBJKLMGCIMD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public IEnumerable<Guid> GBBLEMFGOCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public Guid CMDFEOGJPKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly bool MPJEPBJNDHA;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7DFABE0", Offset = "0x7DF99E0", VA = "0x187DFABE0")]
	public PBJKLMGCIMD(IEnumerable<Guid> DIGOGLIAEGA, Guid OPHMFHNEDON, bool JMEPPEPPAHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public struct HPNNDEIMNKG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public Guid CMDFEOGJPKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly bool MPJEPBJNDHA;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x260D990", Offset = "0x260C790", VA = "0x18260D990")]
	public HPNNDEIMNKG(Guid OPHMFHNEDON, bool JMEPPEPPAHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface IFIBAIOJEGE<TGroup, TData>
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DNEBJFFJFJE EFKMHOGGIPJ(LNGGDJBKDAO<TGroup, TData> KOPDOLGGOLP);

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "1")]
	DNEBJFFJFJE ANKLGHCJHEI(LNGGDJBKDAO<TGroup, TData> KOPDOLGGOLP);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DNEBJFFJFJE IDFHCJMGJBF(DECFFDKLJIC<TGroup, TData> KOPDOLGGOLP);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "3")]
	DNEBJFFJFJE HMEMKFMPNAL(DIJJFHFMICL<TGroup> KOPDOLGGOLP);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface MHMKIFJMHFG
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<DNEBJFFJFJE> EFKMHOGGIPJ(PBJKLMGCIMD KOPDOLGGOLP);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<DNEBJFFJFJE> ANKLGHCJHEI(HPNNDEIMNKG KOPDOLGGOLP);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class KAKFOOJPKMC<TGroup, TData> : BILJHKFDHCH<IFIBAIOJEGE<TGroup, TData>, DNEBJFFJFJE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly DECFFDKLJIC<TGroup, TData> KOPDOLGGOLP;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x50922A0", Offset = "0x50910A0", VA = "0x1850922A0")]
	public KAKFOOJPKMC(TGroup HJIOIGDNMJB, IEnumerable<TData> DIGOGLIAEGA, IFIBAIOJEGE<TGroup, TData> HAAEOKEMPKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x50921D0", Offset = "0x5090FD0", VA = "0x1850921D0", Slot = "4")]
	public override DNEBJFFJFJE FNJHBOGPDPJ()
	{
		return default(DNEBJFFJFJE);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class BBJAJOILJHL<TGroup, TData> : BILJHKFDHCH<IFIBAIOJEGE<TGroup, TData>, DNEBJFFJFJE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly LNGGDJBKDAO<TGroup, TData> KOPDOLGGOLP;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x4C2FBF0", Offset = "0x4C2E9F0", VA = "0x184C2FBF0")]
	public BBJAJOILJHL(TGroup HJIOIGDNMJB, TData NEBBMCEALGD, IEnumerable<TData> DIGOGLIAEGA, IFIBAIOJEGE<TGroup, TData> HAAEOKEMPKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x607DB60", Offset = "0x607C960", VA = "0x18607DB60", Slot = "4")]
	public override DNEBJFFJFJE FNJHBOGPDPJ()
	{
		return default(DNEBJFFJFJE);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class JHCLIPGFJGP<TGroup, TData> : BILJHKFDHCH<IFIBAIOJEGE<TGroup, TData>, DNEBJFFJFJE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly DIJJFHFMICL<TGroup> KOPDOLGGOLP;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x4FAD0B0", Offset = "0x4FABEB0", VA = "0x184FAD0B0")]
	public JHCLIPGFJGP(TGroup HJIOIGDNMJB, IFIBAIOJEGE<TGroup, TData> HAAEOKEMPKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x4FACFE0", Offset = "0x4FABDE0", VA = "0x184FACFE0", Slot = "4")]
	public override DNEBJFFJFJE FNJHBOGPDPJ()
	{
		return default(DNEBJFFJFJE);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class HIMCOPGACIF<TGroup, TData> : BILJHKFDHCH<IFIBAIOJEGE<TGroup, TData>, DNEBJFFJFJE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly LNGGDJBKDAO<TGroup, TData> KOPDOLGGOLP;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4C2FBF0", Offset = "0x4C2E9F0", VA = "0x184C2FBF0")]
	public HIMCOPGACIF(TGroup HJIOIGDNMJB, TData AFOGLKPJEIH, IEnumerable<TData> DIGOGLIAEGA, IFIBAIOJEGE<TGroup, TData> HAAEOKEMPKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x4C2FB10", Offset = "0x4C2E910", VA = "0x184C2FB10", Slot = "4")]
	public override DNEBJFFJFJE FNJHBOGPDPJ()
	{
		return default(DNEBJFFJFJE);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class KGPCBMGDFFI : DIJCELKEAGC<MHMKIFJMHFG, DNEBJFFJFJE>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct JIAEFAKDAKD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public AsyncTaskMethodBuilder<DNEBJFFJFJE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public KGPCBMGDFFI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private TaskAwaiter<DNEBJFFJFJE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7DFA260", Offset = "0x7DF9060", VA = "0x187DFA260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7DFA500", Offset = "0x7DF9300", VA = "0x187DFA500", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private PBJKLMGCIMD KOPDOLGGOLP;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7DFA8F0", Offset = "0x7DF96F0", VA = "0x187DFA8F0")]
	public KGPCBMGDFFI(IEnumerable<Guid> KHBPPLADBMC, Guid OPHMFHNEDON, bool JMEPPEPPAHG, MHMKIFJMHFG HAAEOKEMPKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7DFA800", Offset = "0x7DF9600", VA = "0x187DFA800", Slot = "4")]
	[AsyncStateMachine(typeof(JIAEFAKDAKD))]
	public override Task<DNEBJFFJFJE> FNJHBOGPDPJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class BPFJMEBMLDL : DIJCELKEAGC<MHMKIFJMHFG, DNEBJFFJFJE>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private struct HKIIPLGFCLO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public AsyncTaskMethodBuilder<DNEBJFFJFJE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public BPFJMEBMLDL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private TaskAwaiter<DNEBJFFJFJE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7DF9950", Offset = "0x7DF8750", VA = "0x187DF9950", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7DF9BF0", Offset = "0x7DF89F0", VA = "0x187DF9BF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly HPNNDEIMNKG KOPDOLGGOLP;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7DF9200", Offset = "0x7DF8000", VA = "0x187DF9200")]
	public BPFJMEBMLDL(Guid OPHMFHNEDON, bool JMEPPEPPAHG, MHMKIFJMHFG HAAEOKEMPKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7DF9110", Offset = "0x7DF7F10", VA = "0x187DF9110", Slot = "4")]
	[AsyncStateMachine(typeof(HKIIPLGFCLO))]
	public override Task<DNEBJFFJFJE> FNJHBOGPDPJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public readonly struct DHJGAFMKKIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly LOAEIIPHGPN PDHKNIBMAGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly bool MPJEPBJNDHA;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7DF9390", Offset = "0x7DF8190", VA = "0x187DF9390")]
	public DHJGAFMKKIK(LOAEIIPHGPN EENLPJJCNEB, bool JMEPPEPPAHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface HFBMOJFCEBB<TSpawnType> where TSpawnType : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> FNJHBOGPDPJ(DHJGAFMKKIK DIKFLJCHIDA);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class GHKDPOBHBGJ<TSpawnType> : DIJCELKEAGC<HFBMOJFCEBB<TSpawnType>, TSpawnType> where TSpawnType : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct JKKHNPELGEG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public AsyncTaskMethodBuilder<TSpawnType> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public GHKDPOBHBGJ<TSpawnType> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private TaskAwaiter<TSpawnType> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x4FCECA0", Offset = "0x4FCDAA0", VA = "0x184FCECA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x460CAF0", Offset = "0x460B8F0", VA = "0x18460CAF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly DHJGAFMKKIK DIKFLJCHIDA;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x4BC6B00", Offset = "0x4BC5900", VA = "0x184BC6B00")]
	public GHKDPOBHBGJ(LOAEIIPHGPN EENLPJJCNEB, bool JMEPPEPPAHG, HFBMOJFCEBB<TSpawnType> HAAEOKEMPKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x4BC6A00", Offset = "0x4BC5800", VA = "0x184BC6A00", Slot = "4")]
	[AsyncStateMachine(typeof(GHKDPOBHBGJ<>.JKKHNPELGEG))]
	public override Task<TSpawnType> FNJHBOGPDPJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public readonly struct LOAEIIPHGPN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly bool LMELDEDJHEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly Vector3 OFCMOEKBANG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly Vector3 HKMBNCFKKMC;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7DFAA70", Offset = "0x7DF9870", VA = "0x187DFAA70")]
	public LOAEIIPHGPN(Transform MPNJMJCBOEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7DFAAE0", Offset = "0x7DF98E0", VA = "0x187DFAAE0")]
	public LOAEIIPHGPN(Vector3 KODPDAPHGHG, Vector3 NPJPCFKLMHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7DFA9B0", Offset = "0x7DF97B0", VA = "0x187DFA9B0")]
	public static LOAEIIPHGPN LAGKNEOGNDP()
	{
		return default(LOAEIIPHGPN);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7DFA9E0", Offset = "0x7DF97E0", VA = "0x187DFA9E0")]
	private LOAEIIPHGPN(bool KGAFNFODPAK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct HLJJADLIHOD<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public TNode POEIFPMPBOE;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x4C45B70", Offset = "0x4C44970", VA = "0x184C45B70")]
	public HLJJADLIHOD(TNode POEIFPMPBOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct GKANOJJKIFB<TNode, TReparentOperations> where TNode : notnull where TReparentOperations : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public TNode KHMGDHOAEDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public TReparentOperations PBBEJJKFNAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public CIHPFEMHKBA AEANIACEBHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly bool MPJEPBJNDHA;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x4BCFB80", Offset = "0x4BCE980", VA = "0x184BCFB80")]
	public GKANOJJKIFB(TNode KHMGDHOAEDD, TReparentOperations PBBEJJKFNAC, CIHPFEMHKBA AEANIACEBHD, bool JMEPPEPPAHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface BMBCIIAAHMI<TNode, TReparentOperations>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IIACKBPIHBI([In] HLJJADLIHOD<TNode> HBIJNADCAHF);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GAOCPKAHLGO([In] GKANOJJKIFB<TNode, TReparentOperations> OMBLOILCKOA);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CEKCCBFGMEO();
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class COLCCGEMOFA<TNode, TReparentOperations> : BJPJICGGIOC<BMBCIIAAHMI<TNode, TReparentOperations>>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x45F98E0", Offset = "0x45F86E0", VA = "0x1845F98E0")]
	public COLCCGEMOFA(BMBCIIAAHMI<TNode, TReparentOperations> HAAEOKEMPKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x4C42AC0", Offset = "0x4C418C0", VA = "0x184C42AC0", Slot = "4")]
	public override bool FNJHBOGPDPJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class JBGGLBNEGBA<TNode, TReparentOperations> : BJPJICGGIOC<BMBCIIAAHMI<TNode, TReparentOperations>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly GKANOJJKIFB<TNode, TReparentOperations> OMBLOILCKOA;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x4F6A1D0", Offset = "0x4F68FD0", VA = "0x184F6A1D0")]
	public JBGGLBNEGBA(TNode KHMGDHOAEDD, TReparentOperations PBBEJJKFNAC, CIHPFEMHKBA AEANIACEBHD, BMBCIIAAHMI<TNode, TReparentOperations> HAAEOKEMPKE, bool JMEPPEPPAHG = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x4F6A100", Offset = "0x4F68F00", VA = "0x184F6A100", Slot = "4")]
	public override bool FNJHBOGPDPJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class BCMMEKKEAOE<TNode, TReparentOperations> : BJPJICGGIOC<BMBCIIAAHMI<TNode, TReparentOperations>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly HLJJADLIHOD<TNode> HBIJNADCAHF;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x607ED60", Offset = "0x607DB60", VA = "0x18607ED60")]
	public BCMMEKKEAOE(TNode PFIMAAMDKFI, BMBCIIAAHMI<TNode, TReparentOperations> HAAEOKEMPKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x4B84CF0", Offset = "0x4B83AF0", VA = "0x184B84CF0", Slot = "4")]
	public override bool FNJHBOGPDPJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct LALKFGPIFOO<TSpawnInfo> where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public TSpawnInfo KIFLNPPOAFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public Vector3 NPJPCFKLMHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public Quaternion LJIHJJKHDDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public float JCGDFDLNFJA;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5150E00", Offset = "0x514FC00", VA = "0x185150E00")]
	public LALKFGPIFOO(TSpawnInfo KIFLNPPOAFJ, Vector3 NPJPCFKLMHD, Quaternion LJIHJJKHDDH, float JCGDFDLNFJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface ABFHEICCFME<TSpawnType, TSpawnInfo>
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> KBOIHLBGEAG([In] LALKFGPIFOO<TSpawnInfo> NOHJBKLFABK, CancellationToken GHKBKDKNIOM);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class CMPKPOGEMEJ<TSpawnType, TSpawnInfo> : DIJCELKEAGC<ABFHEICCFME<TSpawnType, TSpawnInfo>, TSpawnType> where TSpawnType : notnull where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly LALKFGPIFOO<TSpawnInfo> AOGFOJGFMAN;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6718C70", Offset = "0x6717A70", VA = "0x186718C70")]
	public CMPKPOGEMEJ(TSpawnInfo IHCNGFGMHCF, Vector3 NPJPCFKLMHD, Quaternion LJIHJJKHDDH, float JCGDFDLNFJA, ABFHEICCFME<TSpawnType, TSpawnInfo> HAAEOKEMPKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x45D3160", Offset = "0x45D1F60", VA = "0x1845D3160", Slot = "4")]
	public override Task<TSpawnType> FNJHBOGPDPJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public readonly struct DLICIBFDDLK<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly IEnumerable<TData> GBBLEMFGOCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly bool MPJEPBJNDHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly bool JMGNGEDMCDE;

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6B1F3F0", Offset = "0x6B1E1F0", VA = "0x186B1F3F0")]
	public DLICIBFDDLK(IEnumerable<TData> DIGOGLIAEGA, bool JMEPPEPPAHG = false, bool BGNMFLFOMOK = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface BEFFMJIAJFC<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<DNEBJFFJFJE> GJJBJFDPONE([In] DLICIBFDDLK<TData> NOFJKKBAKGP, CancellationToken GHKBKDKNIOM);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class EBJEEGJDPDO<TData> : DIJCELKEAGC<BEFFMJIAJFC<TData>, DNEBJFFJFJE> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly DLICIBFDDLK<TData> CDNAEELGFKA;

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x45D3240", Offset = "0x45D2040", VA = "0x1845D3240")]
	public EBJEEGJDPDO(IEnumerable<TData> DIGOGLIAEGA, bool JMEPPEPPAHG, BEFFMJIAJFC<TData> HAAEOKEMPKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x45D3160", Offset = "0x45D1F60", VA = "0x1845D3160", Slot = "4")]
	public override Task<DNEBJFFJFJE> FNJHBOGPDPJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public struct FCNIMOPPNHF<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly T GDCDKMJLKDH;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x4A48010", Offset = "0x4A46E10", VA = "0x184A48010")]
	public FCNIMOPPNHF(T GBFMMNKIKKN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface DMIFLFMKFDI<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IIACKBPIHBI([In] FCNIMOPPNHF<T> AIIBGABBMDA);

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GAOCPKAHLGO();
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface ACFMKFPIDIO<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FNJHBOGPDPJ([In] IAEEFONHOAK<T> NIOIFHNMHPF);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public struct IAEEFONHOAK<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly T GDCDKMJLKDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly bool ANNEIBCCAAA;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x4D23960", Offset = "0x4D22760", VA = "0x184D23960")]
	public IAEEFONHOAK(T GBFMMNKIKKN, bool FAOGBFEJMEP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class EGNKAENMAAH<T> : BJPJICGGIOC<DMIFLFMKFDI<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x45F98E0", Offset = "0x45F86E0", VA = "0x1845F98E0")]
	public EGNKAENMAAH(DMIFLFMKFDI<T> HAAEOKEMPKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x45F9890", Offset = "0x45F8690", VA = "0x1845F9890", Slot = "4")]
	public override bool FNJHBOGPDPJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class KGIBLLJEFCA<T> : BJPJICGGIOC<DMIFLFMKFDI<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly FCNIMOPPNHF<T> AIIBGABBMDA;

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x50A64F0", Offset = "0x50A52F0", VA = "0x1850A64F0")]
	public KGIBLLJEFCA(T GDCDKMJLKDH, DMIFLFMKFDI<T> HAAEOKEMPKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x4B84CF0", Offset = "0x4B83AF0", VA = "0x184B84CF0", Slot = "4")]
	public override bool FNJHBOGPDPJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class MOMANHNIHHA<T> : BJPJICGGIOC<ACFMKFPIDIO<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly IAEEFONHOAK<T> NIOIFHNMHPF;

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x53DD960", Offset = "0x53DC760", VA = "0x1853DD960")]
	public MOMANHNIHHA(T GDCDKMJLKDH, bool FAOGBFEJMEP, ACFMKFPIDIO<T> HAAEOKEMPKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x4B84CF0", Offset = "0x4B83AF0", VA = "0x184B84CF0", Slot = "4")]
	public override bool FNJHBOGPDPJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public struct HELNHLFANEB<TData> where TData : notnull, AMJEEOJNFMO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public IEnumerable<TData> GBBLEMFGOCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public bool KOFEGAHPIJG;

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x4C1DD80", Offset = "0x4C1CB80", VA = "0x184C1DD80")]
	public HELNHLFANEB(IEnumerable<TData> OJALGOECFOG, bool ANDAPLGKOHP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public struct OMLJENEHFBD<TData> where TData : notnull, AMJEEOJNFMO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public List<TData> GBBLEMFGOCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public List<bool> FCKKHHAJNBI;

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x56807A0", Offset = "0x567F5A0", VA = "0x1856807A0")]
	public OMLJENEHFBD(List<TData> OJALGOECFOG, List<bool> ADKLNCKBLAB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface AMJEEOJNFMO
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool LHHLNHOCHFO
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface BAFGBOAMGML<TData> where TData : AMJEEOJNFMO
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FNJHBOGPDPJ([In] HELNHLFANEB<TData> FHOGEGAKBIM);

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FNJHBOGPDPJ([In] OMLJENEHFBD<TData> FHOGEGAKBIM);
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface DNIEDILHAFK<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JJGCEPJPLKA(T GDCDKMJLKDH);
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class DACBCECFHJA<TData> : BJPJICGGIOC<BAFGBOAMGML<TData>> where TData : notnull, AMJEEOJNFMO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly HELNHLFANEB<TData> FHOGEGAKBIM;

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6AE2190", Offset = "0x6AE0F90", VA = "0x186AE2190")]
	public DACBCECFHJA(List<TData> DIGOGLIAEGA, bool KOFEGAHPIJG, BAFGBOAMGML<TData> HAAEOKEMPKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x4B84CF0", Offset = "0x4B83AF0", VA = "0x184B84CF0", Slot = "4")]
	public override bool FNJHBOGPDPJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class HMIKNBIKPOC<TData> : BJPJICGGIOC<BAFGBOAMGML<TData>> where TData : notnull, AMJEEOJNFMO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly OMLJENEHFBD<TData> FHOGEGAKBIM;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x4C4E090", Offset = "0x4C4CE90", VA = "0x184C4E090")]
	public HMIKNBIKPOC(List<TData> DIGOGLIAEGA, List<bool> FCKKHHAJNBI, BAFGBOAMGML<TData> HAAEOKEMPKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x4C4DFD0", Offset = "0x4C4CDD0", VA = "0x184C4DFD0", Slot = "4")]
	public override bool FNJHBOGPDPJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public interface BFECOPMKOMD<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<DNEBJFFJFJE> FNJHBOGPDPJ(IMCCCIFMPAH<TData> MGLIJIEFHDA);
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class DADKPMJPCNI<TData> : DIJCELKEAGC<BFECOPMKOMD<TData>, DNEBJFFJFJE> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private struct MMELGKBIMNN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public AsyncTaskMethodBuilder<DNEBJFFJFJE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public DADKPMJPCNI<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private TaskAwaiter<DNEBJFFJFJE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x53D5FF0", Offset = "0x53D4DF0", VA = "0x1853D5FF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x53D62D0", Offset = "0x53D50D0", VA = "0x1853D62D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly IMCCCIFMPAH<TData> FBALLOFDLAM;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6AE2330", Offset = "0x6AE1130", VA = "0x186AE2330")]
	public DADKPMJPCNI(TData FAGEGGKAGMM, IReadOnlyList<TData> CIGFKDDMPOJ, bool JMEPPEPPAHG, BFECOPMKOMD<TData> HAAEOKEMPKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6AE2230", Offset = "0x6AE1030", VA = "0x186AE2230", Slot = "4")]
	[AsyncStateMachine(typeof(DADKPMJPCNI<>.MMELGKBIMNN))]
	public override Task<DNEBJFFJFJE> FNJHBOGPDPJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct IMCCCIFMPAH<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public TData COOBGAADLDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public IReadOnlyList<TData> FINHGNBBJLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public bool MPJEPBJNDHA;

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2D444F0", Offset = "0x2D432F0", VA = "0x182D444F0")]
	public IMCCCIFMPAH(TData FAGEGGKAGMM, IReadOnlyList<TData> CIGFKDDMPOJ, bool JMEPPEPPAHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public interface JLEBNOKHOGM<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FNJHBOGPDPJ([In] EDHEINGDOLO<TData> ECIEJJPAJIE);
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public interface POHIAJPJGPB<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FNJHBOGPDPJ([In] NPNJMDGIJEJ<TData> ECIEJJPAJIE);
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface PJNJIEKMDPB<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AEBHOHBDOID([In] HNIOOOCGLOB<TData> ECIEJJPAJIE);

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GAOCPKAHLGO();
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class POBACCIGDMH<TData> : BJPJICGGIOC<JLEBNOKHOGM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly EDHEINGDOLO<TData> ECIEJJPAJIE;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x57BACB0", Offset = "0x57B9AB0", VA = "0x1857BACB0")]
	public POBACCIGDMH(IEnumerable<TData> DIGOGLIAEGA, FLGDJDIBGKI DEJLIDMJHPI, BDLOEKFKAIO EFCBJICGDPB, float MGKFNAJLFPM, string? DBCDJMCMAJM, bool HMECHKNLIEL, bool JMEPPEPPAHG, JLEBNOKHOGM<TData> HAAEOKEMPKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x4B84CF0", Offset = "0x4B83AF0", VA = "0x184B84CF0", Slot = "4")]
	public override bool FNJHBOGPDPJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class MNCEOBHDBHD<TData> : BJPJICGGIOC<POHIAJPJGPB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly NPNJMDGIJEJ<TData> ECIEJJPAJIE;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x53D7020", Offset = "0x53D5E20", VA = "0x1853D7020")]
	public MNCEOBHDBHD(TData[] DIGOGLIAEGA, FLGDJDIBGKI[] DEJLIDMJHPI, BDLOEKFKAIO[] EFCBJICGDPB, float[] MGKFNAJLFPM, POHIAJPJGPB<TData> HAAEOKEMPKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x51592D0", Offset = "0x51580D0", VA = "0x1851592D0", Slot = "4")]
	public override bool FNJHBOGPDPJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class GABCACBDPBB<TData> : BJPJICGGIOC<PJNJIEKMDPB<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x45F98E0", Offset = "0x45F86E0", VA = "0x1845F98E0")]
	public GABCACBDPBB(PJNJIEKMDPB<TData> HAAEOKEMPKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x4B7B360", Offset = "0x4B7A160", VA = "0x184B7B360", Slot = "4")]
	public override bool FNJHBOGPDPJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class LEMLKDALCEB<TData> : BJPJICGGIOC<PJNJIEKMDPB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly HNIOOOCGLOB<TData> ECIEJJPAJIE;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5159390", Offset = "0x5158190", VA = "0x185159390")]
	public LEMLKDALCEB(IEnumerable<TData> DIGOGLIAEGA, FLGDJDIBGKI DEJLIDMJHPI, BDLOEKFKAIO EFCBJICGDPB, float MGKFNAJLFPM, PJNJIEKMDPB<TData> HAAEOKEMPKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x51592D0", Offset = "0x51580D0", VA = "0x1851592D0", Slot = "4")]
	public override bool FNJHBOGPDPJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public struct EDHEINGDOLO<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public IEnumerable<TData> GBBLEMFGOCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public FLGDJDIBGKI KEMFIGNEAMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public BDLOEKFKAIO HCJHJANFJBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public float DCFNGINFAKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public string? OGEKIGBBLLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public bool? NIDIDNIGABB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public bool MPJEPBJNDHA;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x45D93A0", Offset = "0x45D81A0", VA = "0x1845D93A0")]
	public EDHEINGDOLO(IEnumerable<TData> DIGOGLIAEGA, FLGDJDIBGKI DEJLIDMJHPI, BDLOEKFKAIO EFCBJICGDPB, float MGKFNAJLFPM, string? DBCDJMCMAJM, bool? HMECHKNLIEL, bool JMEPPEPPAHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public struct NPNJMDGIJEJ<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public TData[] GBBLEMFGOCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public FLGDJDIBGKI[] KEMFIGNEAMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public BDLOEKFKAIO[] HCJHJANFJBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public float[] MGKFNAJLFPM;

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x55098C0", Offset = "0x55086C0", VA = "0x1855098C0")]
	public NPNJMDGIJEJ(TData[] DIGOGLIAEGA, FLGDJDIBGKI[] DEJLIDMJHPI, BDLOEKFKAIO[] EFCBJICGDPB, float[] MGKFNAJLFPM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct HNIOOOCGLOB<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public IEnumerable<TData> GBBLEMFGOCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public FLGDJDIBGKI KEMFIGNEAMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public BDLOEKFKAIO HCJHJANFJBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public float MGKFNAJLFPM;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x4C54E50", Offset = "0x4C53C50", VA = "0x184C54E50")]
	public HNIOOOCGLOB(IEnumerable<TData> DIGOGLIAEGA, FLGDJDIBGKI DEJLIDMJHPI, BDLOEKFKAIO EFCBJICGDPB, float MGKFNAJLFPM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface OEBLCEEELAP<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IDFHCJMGJBF([In] IHJNOMLJCCK<TData> NOFJKKBAKGP);

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HMEMKFMPNAL([In] IHJNOMLJCCK<TData> NOFJKKBAKGP);

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EMGLAPIMDGG([In] bool OIHJMDLPIKE);

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MIGDCEAHEGP([In] IHJNOMLJCCK<TData> NOFJKKBAKGP);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NKEHPDCLEBH();

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool LBFFDJLFCCF([In] TData BHALJNIKEAA);
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class OOOMFAINCGP<TData> : BJPJICGGIOC<OEBLCEEELAP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly IHJNOMLJCCK<TData> NOFJKKBAKGP;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x5683640", Offset = "0x5682440", VA = "0x185683640")]
	public OOOMFAINCGP(List<TData> CPGOGHNJEGO, OEBLCEEELAP<TData> HAAEOKEMPKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x4B84CF0", Offset = "0x4B83AF0", VA = "0x184B84CF0", Slot = "4")]
	public override bool FNJHBOGPDPJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class FEGPLFCDJNK<TData> : BJPJICGGIOC<OEBLCEEELAP<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x45F98E0", Offset = "0x45F86E0", VA = "0x1845F98E0")]
	public FEGPLFCDJNK(OEBLCEEELAP<TData> HAAEOKEMPKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x4A4EDE0", Offset = "0x4A4DBE0", VA = "0x184A4EDE0", Slot = "4")]
	public override bool FNJHBOGPDPJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class OLMNMJGIMNI<TData> : BJPJICGGIOC<OEBLCEEELAP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly bool JMEPPEPPAHG;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x56771A0", Offset = "0x5675FA0", VA = "0x1856771A0")]
	public OLMNMJGIMNI(bool JMEPPEPPAHG, OEBLCEEELAP<TData> HAAEOKEMPKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x5677140", Offset = "0x5675F40", VA = "0x185677140", Slot = "4")]
	public override bool FNJHBOGPDPJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class CPHGBKLMDMK<TData> : BJPJICGGIOC<OEBLCEEELAP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly IHJNOMLJCCK<TData> NOFJKKBAKGP;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6720BA0", Offset = "0x671F9A0", VA = "0x186720BA0")]
	public CPHGBKLMDMK(List<TData> CPGOGHNJEGO, bool JMEPPEPPAHG, OEBLCEEELAP<TData> HAAEOKEMPKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x4C4DFD0", Offset = "0x4C4CDD0", VA = "0x184C4DFD0", Slot = "4")]
	public override bool FNJHBOGPDPJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class HGJGCBPJHEC<TData> : BJPJICGGIOC<OEBLCEEELAP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly TData BHALJNIKEAA;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x4C27480", Offset = "0x4C26280", VA = "0x184C27480")]
	public HGJGCBPJHEC(TData BHALJNIKEAA, OEBLCEEELAP<TData> HAAEOKEMPKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x4C272F0", Offset = "0x4C260F0", VA = "0x184C272F0", Slot = "4")]
	public override bool FNJHBOGPDPJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class AJJDFCDMDEO<TData> : BJPJICGGIOC<OEBLCEEELAP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly IHJNOMLJCCK<TData> NOFJKKBAKGP;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x4DC1330", Offset = "0x4DC0130", VA = "0x184DC1330")]
	public AJJDFCDMDEO(IEnumerable<TData> CPGOGHNJEGO, OEBLCEEELAP<TData> HAAEOKEMPKE, bool JMEPPEPPAHG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x4DC1260", Offset = "0x4DC0060", VA = "0x184DC1260", Slot = "4")]
	public override bool FNJHBOGPDPJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public struct IHJNOMLJCCK<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public IEnumerable<TData> GBBLEMFGOCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public bool JMEPPEPPAHG;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x4D3AD20", Offset = "0x4D39B20", VA = "0x184D3AD20")]
	public IHJNOMLJCCK(IEnumerable<TData> OJALGOECFOG, bool BFMCJJFENBP = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public interface NFNHHOFGJFG
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<DNEBJFFJFJE> FNJHBOGPDPJ(FMGMKHPPGJN PACDPMKJOFD);
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class HLDGKEIDHND : DIJCELKEAGC<NFNHHOFGJFG, DNEBJFFJFJE>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private struct GLNGINFCLMP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public AsyncTaskMethodBuilder<DNEBJFFJFJE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public HLDGKEIDHND <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private TaskAwaiter<DNEBJFFJFJE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x7DF93D0", Offset = "0x7DF81D0", VA = "0x187DF93D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7DF9650", Offset = "0x7DF8450", VA = "0x187DF9650", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private readonly FMGMKHPPGJN MMKOHMKBLHN;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x7DF9D50", Offset = "0x7DF8B50", VA = "0x187DF9D50")]
	public HLDGKEIDHND(bool JMEPPEPPAHG, NFNHHOFGJFG HAAEOKEMPKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x7DF9C60", Offset = "0x7DF8A60", VA = "0x187DF9C60", Slot = "4")]
	[AsyncStateMachine(typeof(GLNGINFCLMP))]
	public override Task<DNEBJFFJFJE> FNJHBOGPDPJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public struct FMGMKHPPGJN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public bool MPJEPBJNDHA;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x2A25C90", Offset = "0x2A24A90", VA = "0x182A25C90")]
	public FMGMKHPPGJN(bool JMEPPEPPAHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public readonly struct OEBBGPJHIGM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public readonly bool PGCIACMMIDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public readonly bool GHDPOLNIOGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public readonly bool JCGDFDLNFJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public readonly bool JMEPPEPPAHG;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5E12820", Offset = "0x5E11620", VA = "0x185E12820")]
	public OEBBGPJHIGM(bool PGCIACMMIDI, bool GHDPOLNIOGM, bool JCGDFDLNFJA, bool JMEPPEPPAHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7DFABD0", Offset = "0x7DF99D0", VA = "0x187DFABD0")]
	public OEBBGPJHIGM(bool GHDPOLNIOGM, bool JMEPPEPPAHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public interface HKJFIGMIEKE
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FPJFFLGHDGB(OEBBGPJHIGM JPOBGGMCKAM);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DLNLKGEJLAK(OEBBGPJHIGM JPOBGGMCKAM);
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public class BABMNKEKGFJ : BJPJICGGIOC<HKJFIGMIEKE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly OEBBGPJHIGM JPOBGGMCKAM;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7DF9080", Offset = "0x7DF7E80", VA = "0x187DF9080")]
	public BABMNKEKGFJ(bool MAAFBDAKBJA, bool GHDPOLNIOGM, bool JCGDFDLNFJA, bool JMEPPEPPAHG, HKJFIGMIEKE HAAEOKEMPKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x7DF9030", Offset = "0x7DF7E30", VA = "0x187DF9030", Slot = "4")]
	public override bool FNJHBOGPDPJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public class HMIAEJBGGIE : BJPJICGGIOC<HKJFIGMIEKE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly OEBBGPJHIGM JPOBGGMCKAM;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7DF9E00", Offset = "0x7DF8C00", VA = "0x187DF9E00")]
	public HMIAEJBGGIE(bool GHDPOLNIOGM, bool JMEPPEPPAHG, HKJFIGMIEKE HAAEOKEMPKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x7DF9DB0", Offset = "0x7DF8BB0", VA = "0x187DF9DB0", Slot = "4")]
	public override bool FNJHBOGPDPJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public interface CMOJPGGGAGK
{
	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FNJHBOGPDPJ([In] PMGAHNDEHBO PHEIKLDHFOO);
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class KAIDGENOGCB : BJPJICGGIOC<CMOJPGGGAGK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly PMGAHNDEHBO PHEIKLDHFOO;

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x7DFA620", Offset = "0x7DF9420", VA = "0x187DFA620")]
	public KAIDGENOGCB(Guid[] BEIOGFAOHAA, Vector3[] LKDOKAHHNCE, Quaternion[] PJGNBPJJCOM, float[] MBMJBLEAOJC, Dictionary<Guid, Vector3> ECOFNGGPKMO, CMOJPGGGAGK HAAEOKEMPKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7DFA570", Offset = "0x7DF9370", VA = "0x187DFA570", Slot = "4")]
	public override bool FNJHBOGPDPJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public interface OCHHEMAEMIP<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IIACKBPIHBI([In] JNGKIIHHKKH<TData> HBIJNADCAHF);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool AEBHOHBDOID([In] GBOIAAENJEG HPMPLHHHBOO);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool AEBHOHBDOID([In] HHHLEAKIBDM HPMPLHHHBOO);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool GAOCPKAHLGO();
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class HKDCIGOIEBG<TData> : BJPJICGGIOC<OCHHEMAEMIP<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x45F98E0", Offset = "0x45F86E0", VA = "0x1845F98E0")]
	public HKDCIGOIEBG(OCHHEMAEMIP<TData> HAAEOKEMPKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x4C42780", Offset = "0x4C41580", VA = "0x184C42780", Slot = "4")]
	public override bool FNJHBOGPDPJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class KOHIIEDHEHG<TData> : BJPJICGGIOC<OCHHEMAEMIP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly GBOIAAENJEG HPLBMDOIGFJ;

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x50BFB60", Offset = "0x50BE960", VA = "0x1850BFB60")]
	public KOHIIEDHEHG(Vector3 DCDOONJJJNN, bool FIPPAIGFOPJ, OCHHEMAEMIP<TData> HAAEOKEMPKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x4D33B80", Offset = "0x4D32980", VA = "0x184D33B80", Slot = "4")]
	public override bool FNJHBOGPDPJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public class BLMEGELAAHG<TData> : BJPJICGGIOC<OCHHEMAEMIP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly HHHLEAKIBDM HPLBMDOIGFJ;

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x61719F0", Offset = "0x61707F0", VA = "0x1861719F0")]
	public BLMEGELAAHG(Guid GPNBPMLJMKG, int GLAOLHCPLLG, Vector3 NPJPCFKLMHD, Quaternion LJIHJJKHDDH, float MEHMJKKFJEH, bool FIPPAIGFOPJ, OCHHEMAEMIP<TData> HAAEOKEMPKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6171990", Offset = "0x6170790", VA = "0x186171990", Slot = "4")]
	public override bool FNJHBOGPDPJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class GDHPCFDPIOM<TData> : BJPJICGGIOC<OCHHEMAEMIP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly JNGKIIHHKKH<TData> HPLBMDOIGFJ;

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x4B84E50", Offset = "0x4B83C50", VA = "0x184B84E50")]
	public GDHPCFDPIOM(TData GDCDKMJLKDH, bool JMEPPEPPAHG, OCHHEMAEMIP<TData> HAAEOKEMPKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x4B84CF0", Offset = "0x4B83AF0", VA = "0x184B84CF0", Slot = "4")]
	public override bool FNJHBOGPDPJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct GBOIAAENJEG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public readonly Vector3 DCDOONJJJNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public readonly bool FIPPAIGFOPJ;

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7DF93B0", Offset = "0x7DF81B0", VA = "0x187DF93B0")]
	public GBOIAAENJEG(Vector3 DCDOONJJJNN, bool FIPPAIGFOPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct HHHLEAKIBDM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public readonly Guid GPNBPMLJMKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public readonly int GLAOLHCPLLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public readonly Vector3 NPJPCFKLMHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public readonly Quaternion LJIHJJKHDDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public readonly float MEHMJKKFJEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public readonly bool FIPPAIGFOPJ;

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7DF96E0", Offset = "0x7DF84E0", VA = "0x187DF96E0")]
	public HHHLEAKIBDM(Guid GPNBPMLJMKG, int GLAOLHCPLLG, Vector3 NPJPCFKLMHD, Quaternion LJIHJJKHDDH, float MEHMJKKFJEH, bool FIPPAIGFOPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public struct JNGKIIHHKKH<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly TData GDCDKMJLKDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public readonly bool JMEPPEPPAHG;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x4FD52F0", Offset = "0x4FD40F0", VA = "0x184FD52F0")]
	public JNGKIIHHKKH(TData GDCDKMJLKDH, bool JMEPPEPPAHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public interface AANIAEGNJNB<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FNJHBOGPDPJ([In] ANBDFALBNDO<TData> FLDOKJMNKBH);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FNJHBOGPDPJ([In] PDBLDCKPPJH<TData> FLDOKJMNKBH);
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public interface DMMHNCDMGOM<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IIACKBPIHBI([In] JBGHBKOLDLH<TData> JNPFBIBMGFG);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool AEBHOHBDOID([In] GNDEOLLBCCN HPMPLHHHBOO);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GAOCPKAHLGO();
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class HMKCNCCEBLD<TData> : BJPJICGGIOC<AANIAEGNJNB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly ANBDFALBNDO<TData> FLDOKJMNKBH;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x4C4E130", Offset = "0x4C4CF30", VA = "0x184C4E130")]
	public HMKCNCCEBLD(IEnumerable<TData> DIGOGLIAEGA, Vector3 COKDABBDLBF, bool JMEPPEPPAHG, AANIAEGNJNB<TData> HAAEOKEMPKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x4B84CF0", Offset = "0x4B83AF0", VA = "0x184B84CF0", Slot = "4")]
	public override bool FNJHBOGPDPJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public class HKGKODBOOIH<TData> : BJPJICGGIOC<DMMHNCDMGOM<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x45F98E0", Offset = "0x45F86E0", VA = "0x1845F98E0")]
	public HKGKODBOOIH(DMMHNCDMGOM<TData> HAAEOKEMPKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x4C42AC0", Offset = "0x4C418C0", VA = "0x184C42AC0", Slot = "4")]
	public override bool FNJHBOGPDPJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public class AIHOIMABBMK<TData> : BJPJICGGIOC<DMMHNCDMGOM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly JBGHBKOLDLH<TData> FLDOKJMNKBH;

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x4DC0B70", Offset = "0x4DBF970", VA = "0x184DC0B70")]
	public AIHOIMABBMK(IEnumerable<TData> DIGOGLIAEGA, bool JMEPPEPPAHG, DMMHNCDMGOM<TData> HAAEOKEMPKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x4B84CF0", Offset = "0x4B83AF0", VA = "0x184B84CF0", Slot = "4")]
	public override bool FNJHBOGPDPJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class MNCOMIDNIPE<TData> : BJPJICGGIOC<AANIAEGNJNB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly PDBLDCKPPJH<TData> FLDOKJMNKBH;

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x53D7100", Offset = "0x53D5F00", VA = "0x1853D7100")]
	public MNCOMIDNIPE(IEnumerable<TData> DIGOGLIAEGA, Vector3 LDBBNAHGBGK, OMCGOJMKIBC ACEMDGIKEAN, bool JMEPPEPPAHG, AANIAEGNJNB<TData> HAAEOKEMPKE, Space MKNHFDCLCKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x4F6A100", Offset = "0x4F68F00", VA = "0x184F6A100", Slot = "4")]
	public override bool FNJHBOGPDPJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class IFJPCDBFGGD<TData> : BJPJICGGIOC<DMMHNCDMGOM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly GNDEOLLBCCN FLDOKJMNKBH;

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x4D33BE0", Offset = "0x4D329E0", VA = "0x184D33BE0")]
	public IFJPCDBFGGD(Vector3 COKDABBDLBF, DMMHNCDMGOM<TData> HAAEOKEMPKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x4D33B80", Offset = "0x4D32980", VA = "0x184D33B80", Slot = "4")]
	public override bool FNJHBOGPDPJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct ANBDFALBNDO<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public readonly IEnumerable<TData> DIGOGLIAEGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public readonly Vector3 COKDABBDLBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public readonly bool JMEPPEPPAHG;

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x4E93AB0", Offset = "0x4E928B0", VA = "0x184E93AB0")]
	public ANBDFALBNDO(IEnumerable<TData> DIGOGLIAEGA, Vector3 COKDABBDLBF, bool JMEPPEPPAHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public struct JBGHBKOLDLH<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public readonly IEnumerable<TData> DIGOGLIAEGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public readonly bool JMEPPEPPAHG;

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x4F6A5D0", Offset = "0x4F693D0", VA = "0x184F6A5D0")]
	public JBGHBKOLDLH(IEnumerable<TData> DIGOGLIAEGA, bool JMEPPEPPAHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public struct PDBLDCKPPJH<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public readonly IEnumerable<TData> DIGOGLIAEGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public readonly Vector3 LDBBNAHGBGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public readonly OMCGOJMKIBC ACEMDGIKEAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public readonly bool JMEPPEPPAHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public readonly Space MKNHFDCLCKG;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x576F4F0", Offset = "0x576E2F0", VA = "0x18576F4F0")]
	public PDBLDCKPPJH(IEnumerable<TData> DIGOGLIAEGA, Vector3 LDBBNAHGBGK, OMCGOJMKIBC ACEMDGIKEAN, bool JMEPPEPPAHG, Space MKNHFDCLCKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public struct GNDEOLLBCCN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public readonly Vector3 COKDABBDLBF;

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0xEEE9B0", Offset = "0xEED7B0", VA = "0x180EEE9B0")]
	public GNDEOLLBCCN(Vector3 COKDABBDLBF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public enum OMCGOJMKIBC
{
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	XYZ,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	X_only,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	Y_only,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	Z_only
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public interface HAFKPBBOGDL
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FNJHBOGPDPJ([In] AMBJNKABEFL GJBGHFJKACO);
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public class DEDOEPINKEK : BJPJICGGIOC<HAFKPBBOGDL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private readonly AMBJNKABEFL GJBGHFJKACO;

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x7DF9330", Offset = "0x7DF8130", VA = "0x187DF9330")]
	public DEDOEPINKEK(bool JMEPPEPPAHG, HAFKPBBOGDL HAAEOKEMPKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x7DF9280", Offset = "0x7DF8080", VA = "0x187DF9280", Slot = "4")]
	public override bool FNJHBOGPDPJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public readonly struct AMBJNKABEFL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public readonly bool JMEPPEPPAHG;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x2A25C90", Offset = "0x2A24A90", VA = "0x182A25C90")]
	public AMBJNKABEFL(bool JMEPPEPPAHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public interface GOPHPBOHJAG<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FNJHBOGPDPJ([In] CKHDAMEECGE<TData> CMNICDAPANK);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FNJHBOGPDPJ([In] EHOJCFBPOIO<TData> CMNICDAPANK);
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public interface ANDNMLIOIMF<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IIACKBPIHBI([In] PBHEAKAPDCO<TData> HBIJNADCAHF);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool AEBHOHBDOID([In] GOCIEFOAOLF HPMPLHHHBOO);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GAOCPKAHLGO();
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class ADHHGCFFFEN<TData> : BJPJICGGIOC<GOPHPBOHJAG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private readonly CKHDAMEECGE<TData> CMNICDAPANK;

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x4B9F0F0", Offset = "0x4B9DEF0", VA = "0x184B9F0F0")]
	public ADHHGCFFFEN(IEnumerable<TData> DIGOGLIAEGA, Quaternion COKDABBDLBF, Vector3? LINOCDMEGNO, bool DPCHEHNHHKL, bool JMEPPEPPAHG, GOPHPBOHJAG<TData> HAAEOKEMPKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x4B84CF0", Offset = "0x4B83AF0", VA = "0x184B84CF0", Slot = "4")]
	public override bool FNJHBOGPDPJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class KDKNJNLOPJI<TData> : BJPJICGGIOC<ANDNMLIOIMF<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x45F98E0", Offset = "0x45F86E0", VA = "0x1845F98E0")]
	public KDKNJNLOPJI(ANDNMLIOIMF<TData> HAAEOKEMPKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x4C42AC0", Offset = "0x4C418C0", VA = "0x184C42AC0", Slot = "4")]
	public override bool FNJHBOGPDPJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class POBCAIIKDNH<TData> : BJPJICGGIOC<ANDNMLIOIMF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private readonly PBHEAKAPDCO<TData> CMNICDAPANK;

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x57BB010", Offset = "0x57B9E10", VA = "0x1857BB010")]
	public POBCAIIKDNH(IEnumerable<TData> DIGOGLIAEGA, bool JMEPPEPPAHG, ANDNMLIOIMF<TData> HAAEOKEMPKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x4B84CF0", Offset = "0x4B83AF0", VA = "0x184B84CF0", Slot = "4")]
	public override bool FNJHBOGPDPJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public class KAMEPICDBCI<TData> : BJPJICGGIOC<GOPHPBOHJAG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly EHOJCFBPOIO<TData> CMNICDAPANK;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x5092600", Offset = "0x5091400", VA = "0x185092600")]
	public KAMEPICDBCI(IEnumerable<TData> DIGOGLIAEGA, Quaternion GNOJBGBHDMD, OMCGOJMKIBC IDMANMMJAHC, Vector3? LINOCDMEGNO, bool DPCHEHNHHKL, bool JMEPPEPPAHG, Space MKNHFDCLCKG, GOPHPBOHJAG<TData> HAAEOKEMPKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x4F6A100", Offset = "0x4F68F00", VA = "0x184F6A100", Slot = "4")]
	public override bool FNJHBOGPDPJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public class POKAPAPCFDB<TData> : BJPJICGGIOC<ANDNMLIOIMF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly GOCIEFOAOLF CMNICDAPANK;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x57BE220", Offset = "0x57BD020", VA = "0x1857BE220")]
	public POKAPAPCFDB(Quaternion COKDABBDLBF, Vector3? LINOCDMEGNO, bool DPCHEHNHHKL, ANDNMLIOIMF<TData> HAAEOKEMPKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x4D33B80", Offset = "0x4D32980", VA = "0x184D33B80", Slot = "4")]
	public override bool FNJHBOGPDPJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct CKHDAMEECGE<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public readonly IEnumerable<TData> DIGOGLIAEGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public readonly Quaternion COKDABBDLBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public readonly Vector3? LINOCDMEGNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public readonly bool DPCHEHNHHKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public readonly bool JMEPPEPPAHG;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x6713AD0", Offset = "0x67128D0", VA = "0x186713AD0")]
	public CKHDAMEECGE(IEnumerable<TData> DIGOGLIAEGA, Quaternion COKDABBDLBF, Vector3? LINOCDMEGNO, bool DPCHEHNHHKL, bool JMEPPEPPAHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public struct PBHEAKAPDCO<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public readonly IEnumerable<TData> DIGOGLIAEGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly bool JMEPPEPPAHG;

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x576A4D0", Offset = "0x57692D0", VA = "0x18576A4D0")]
	public PBHEAKAPDCO(IEnumerable<TData> DIGOGLIAEGA, bool JMEPPEPPAHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct EHOJCFBPOIO<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public readonly IEnumerable<TData> DIGOGLIAEGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly Quaternion GNOJBGBHDMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public readonly OMCGOJMKIBC IDMANMMJAHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public readonly Vector3? LINOCDMEGNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public readonly bool DPCHEHNHHKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public readonly bool JMEPPEPPAHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public readonly Space MKNHFDCLCKG;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x460A0A0", Offset = "0x4608EA0", VA = "0x18460A0A0")]
	public EHOJCFBPOIO(IEnumerable<TData> DIGOGLIAEGA, Quaternion GNOJBGBHDMD, OMCGOJMKIBC IDMANMMJAHC, Vector3? LINOCDMEGNO, bool DPCHEHNHHKL, bool JMEPPEPPAHG, Space MKNHFDCLCKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public struct GOCIEFOAOLF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public readonly Quaternion COKDABBDLBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public readonly Vector3? LINOCDMEGNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public readonly bool DPCHEHNHHKL;

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x5DB98A0", Offset = "0x5DB86A0", VA = "0x185DB98A0")]
	public GOCIEFOAOLF(Quaternion COKDABBDLBF, Vector3? LINOCDMEGNO, bool DPCHEHNHHKL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public interface LCCFMJLLEHG<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IIACKBPIHBI([In] JKKCONPFPOH<TData> HBIJNADCAHF);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool AEBHOHBDOID([In] PKOMMJAMIOB HPMPLHHHBOO);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool AEBHOHBDOID([In] GMOEMBEFPBL HPMPLHHHBOO);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool AEBHOHBDOID([In] MJPNONPFBJK HPMPLHHHBOO);

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool GAOCPKAHLGO();
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public class ICENFBOJFKM<TData> : BJPJICGGIOC<LCCFMJLLEHG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private readonly MJPNONPFBJK DBDIHAJNFKE;

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x4D28700", Offset = "0x4D27500", VA = "0x184D28700")]
	public ICENFBOJFKM(Vector3 IIKOCENMFFE, float LILMPFGODPN, Vector3 LINOCDMEGNO, bool HFEBCAOCGCP, bool PIDGFCOABIJ, LCCFMJLLEHG<TData> HAAEOKEMPKE, Space MKNHFDCLCKG = Space.Self)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x4D286A0", Offset = "0x4D274A0", VA = "0x184D286A0", Slot = "4")]
	public override bool FNJHBOGPDPJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public class AHGJBIFJFPO<TData> : BJPJICGGIOC<LCCFMJLLEHG<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x45F98E0", Offset = "0x45F86E0", VA = "0x1845F98E0")]
	public AHGJBIFJFPO(LCCFMJLLEHG<TData> HAAEOKEMPKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x4DBDBE0", Offset = "0x4DBC9E0", VA = "0x184DBDBE0", Slot = "4")]
	public override bool FNJHBOGPDPJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public class DJHEHAKNBJE<TData> : BJPJICGGIOC<LCCFMJLLEHG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private readonly JKKCONPFPOH<TData> DBDIHAJNFKE;

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6B17590", Offset = "0x6B16390", VA = "0x186B17590")]
	public DJHEHAKNBJE(IEnumerable<TData> DIGOGLIAEGA, bool JMEPPEPPAHG, LCCFMJLLEHG<TData> HAAEOKEMPKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x4B84CF0", Offset = "0x4B83AF0", VA = "0x184B84CF0", Slot = "4")]
	public override bool FNJHBOGPDPJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public class AHKBHPLOKGP<TData> : BJPJICGGIOC<LCCFMJLLEHG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private readonly GMOEMBEFPBL DBDIHAJNFKE;

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x4DBEC70", Offset = "0x4DBDA70", VA = "0x184DBEC70")]
	public AHKBHPLOKGP(float KCFFJKCLAMD, bool FIGKDHFIDNF, Vector3 LINOCDMEGNO, LCCFMJLLEHG<TData> HAAEOKEMPKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x4DBEBA0", Offset = "0x4DBD9A0", VA = "0x184DBEBA0", Slot = "4")]
	public override bool FNJHBOGPDPJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public class CDKONKDGEOG<TData> : BJPJICGGIOC<LCCFMJLLEHG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly PKOMMJAMIOB DBDIHAJNFKE;

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x654D940", Offset = "0x654C740", VA = "0x18654D940")]
	public CDKONKDGEOG(float LILMPFGODPN, Vector3 LINOCDMEGNO, LCCFMJLLEHG<TData> HAAEOKEMPKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x4D33B80", Offset = "0x4D32980", VA = "0x184D33B80", Slot = "4")]
	public override bool FNJHBOGPDPJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public struct MJPNONPFBJK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public readonly Vector3 IIKOCENMFFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public readonly float LILMPFGODPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public readonly Vector3 LINOCDMEGNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public readonly bool FIPPAIGFOPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public readonly Space MKNHFDCLCKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public readonly bool PIDGFCOABIJ;

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x7DFAB10", Offset = "0x7DF9910", VA = "0x187DFAB10")]
	public MJPNONPFBJK(Vector3 IIKOCENMFFE, float LILMPFGODPN, Vector3 LINOCDMEGNO, bool FIPPAIGFOPJ, bool JHJONAKLGMO, Space MKNHFDCLCKG = Space.Self)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public struct JKKCONPFPOH<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public readonly IEnumerable<TData> DIGOGLIAEGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public readonly bool JMEPPEPPAHG;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x4FCE670", Offset = "0x4FCD470", VA = "0x184FCE670")]
	public JKKCONPFPOH(IEnumerable<TData> DIGOGLIAEGA, bool JMEPPEPPAHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public struct GMOEMBEFPBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public readonly float KCFFJKCLAMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public readonly bool FIGKDHFIDNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public readonly Vector3 LINOCDMEGNO;

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x7DF96C0", Offset = "0x7DF84C0", VA = "0x187DF96C0")]
	public GMOEMBEFPBL(float KCFFJKCLAMD, bool FIGKDHFIDNF, Vector3 LINOCDMEGNO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public struct PKOMMJAMIOB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public readonly float LILMPFGODPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public readonly Vector3 LINOCDMEGNO;

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x5D8B8E0", Offset = "0x5D8A6E0", VA = "0x185D8B8E0")]
	public PKOMMJAMIOB(float LILMPFGODPN, Vector3 LINOCDMEGNO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public struct PMGAHNDEHBO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public readonly Guid[] DIGOGLIAEGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public readonly bool KJLLJFJNGEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public readonly bool NMAFLEKAAJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public readonly bool BNDEJCGCCHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public readonly Vector3[] LKDOKAHHNCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public readonly Quaternion[] PJGNBPJJCOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public readonly float[] MBMJBLEAOJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public readonly Dictionary<Guid, Vector3> ECOFNGGPKMO;

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x7DFADF0", Offset = "0x7DF9BF0", VA = "0x187DFADF0")]
	public PMGAHNDEHBO(Guid[] BEIOGFAOHAA, Vector3[] LKDOKAHHNCE, Quaternion[] PJGNBPJJCOM, float[] MBMJBLEAOJC, Dictionary<Guid, Vector3> ECOFNGGPKMO, bool KJLLJFJNGEL = true, bool NMAFLEKAAJP = true, bool BNDEJCGCCHM = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7DFAC20", Offset = "0x7DF9A20", VA = "0x187DFAC20")]
	private static void ONMNKGIMNDI(Dictionary<Guid, Vector3> ECOFNGGPKMO, int OAGELHPIICE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public static class HPBHLBLOJDH
{
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	private struct BJIPAHAAMJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public bool KBOAGBNFJMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public NAELDDAANND NFNIJIAHECJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public NAELDDAANND NMGJBDIDCLK;
	}

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private static BJIPAHAAMJL GIEIKMDFGDG;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static CancellationToken CCBEJILEEIP
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x7DFA150", Offset = "0x7DF8F50", VA = "0x187DFA150")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	internal static NAELDDAANND NFNIJIAHECJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x7DFA170", Offset = "0x7DF8F70", VA = "0x187DFA170")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x7DF9FE0", Offset = "0x7DF8DE0", VA = "0x187DF9FE0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x7DFA050", Offset = "0x7DF8E50", VA = "0x187DFA050")]
	[ENKLKENGHAE.NBNJEHHIPLL]
	internal static void CLCHOCNLOKB(NAELDDAANND BCJBFOMHILA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x7DF9E80", Offset = "0x7DF8C80", VA = "0x187DF9E80")]
	public static void ANBMJCFGCOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x7DFA210", Offset = "0x7DF9010", VA = "0x187DFA210")]
	private static NAELDDAANND JPNHCLDMDII(NAELDDAANND DKLAAEGCAJG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public static class PMOCBAIFELB
{
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	public enum CHDEPCONOHP
	{
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		ICreationContextObject,
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		Guid
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x3B21DF0", Offset = "0x3B20BF0", VA = "0x183B21DF0")]
	public static void CHALFAMGLPL<T>(T BNOFOIBJLLE, CHDEPCONOHP AAFMBEEMJAC) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3B21F60", Offset = "0x3B20D60", VA = "0x183B21F60")]
	public static void CHALFAMGLPL<T>(T BNOFOIBJLLE) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x3B21CF0", Offset = "0x3B20AF0", VA = "0x183B21CF0")]
	public static void CHALFAMGLPL<T, TImpl, T>() where T : class where TImpl : notnull, T where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x3B21C40", Offset = "0x3B20A40", VA = "0x183B21C40")]
	public static void CGMCLBCBDID<T>(T BNOFOIBJLLE) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x3B22400", Offset = "0x3B21200", VA = "0x183B22400")]
	public static T MBFFDPKOBBN<T>(CHDEPCONOHP AAFMBEEMJAC) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x3B21FD0", Offset = "0x3B20DD0", VA = "0x183B21FD0")]
	public static bool EDIACBOJIPL<T>(CHDEPCONOHP AAFMBEEMJAC, T? GIFOGMJIFCH, [Out][NotNullWhen(true)][MaybeNullWhen(false)] T MAHFABAIFKO) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x3B221E0", Offset = "0x3B20FE0", VA = "0x183B221E0")]
	public static bool HGNFJDKOBHO<T>(CHDEPCONOHP AAFMBEEMJAC, [Out][NotNullWhen(true)][MaybeNullWhen(false)] T EAPLABCBHEG) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x3B22350", Offset = "0x3B21150", VA = "0x183B22350")]
	public static bool JMCNJLBDMIE<T>(CHDEPCONOHP AAFMBEEMJAC) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x3B222F0", Offset = "0x3B210F0", VA = "0x183B222F0")]
	public static T MBFFDPKOBBN<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x3B22120", Offset = "0x3B20F20", VA = "0x183B22120")]
	public static bool EDIACBOJIPL<T>(T GIFOGMJIFCH, [Out] T MAHFABAIFKO) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x3B222F0", Offset = "0x3B210F0", VA = "0x183B222F0")]
	public static bool JMCNJLBDMIE<T>() where T : class
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
internal static class HKCFJCBNFED
{
	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x7DF9720", Offset = "0x7DF8520", VA = "0x187DF9720")]
	public static void EJLLAOKLKFK(IEnumerable LKJOEOOLPFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x39247E0", Offset = "0x39235E0", VA = "0x1839247E0")]
	public static void EJLLAOKLKFK<T>(T[] KNDCNOIHMGO) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x39248D0", Offset = "0x39236D0", VA = "0x1839248D0")]
	public static void EJLLAOKLKFK<T>(T JMDMECFGMML) where T : notnull, Enum
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
