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
		[Cpp2IlInjected.Address(RVA = "0xAD77F0", Offset = "0xAD61F0", VA = "0x180AD77F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x85528E0", Offset = "0x85512E0", VA = "0x1885528E0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAD85C0", Offset = "0xAD6FC0", VA = "0x180AD85C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD8600", Offset = "0xAD7000", VA = "0x180AD8600")]
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
		[Cpp2IlInjected.Address(RVA = "0x8553110", Offset = "0x8551B10", VA = "0x188553110", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x29CDED0", Offset = "0x29CC8D0", VA = "0x1829CDED0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum HGDMANAMOEH
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	ShowFreeInventionsInR2PaletteSearch
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum MJCLEJBAMDB
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	NameAZ,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	NameZA,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	InkCostAsc,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	InkCostDesc,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	Oldest,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	Newest
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface FKHMPACCILD<TData, TReturn>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TReturn MOHIJKFDEFL(TData PMNHIPACJLN);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface OEGNHNELELK<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ClearHoverTarget(HNNNPPHEKAD EEKGJODEIOH);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool SetHoverTarget(TData JFBLIPHGGPK, Collider CDDKGLFGLCL, HNNNPPHEKAD EEKGJODEIOH, [Optional] KBICEEBHCID? IJEEBNLPFMB);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool TryGetHoverTarget([Out] TData JFBLIPHGGPK);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetHoverCollider([Out] Collider CDDKGLFGLCL);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface LCFGIMJEPHP<TData> : BKBDOPJKFEI, DFIILONKCLD<TData>, HHAJODIMFEH<TData>, LCFFIEPONOC<TData>, GPCBMJNHCAK, CANOAIINAFP<TData>, DNPFNHHAFPD, EDMDDFDPLAK
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface CANOAIINAFP<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 IIBHNKFDNNM, Vector3 HLNPPHJBENM, float EFLCGLGNONM, [Out] T PKLLBOLDNPB, [Out] Vector3 OEAFJNFBBGA, [Out] Collider CDDKGLFGLCL);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 IIBHNKFDNNM, Vector3 HLNPPHJBENM, float FJCMDDHMEOM, float EFLCGLGNONM, T[] JLAAPFHFBMI, [Out] Vector3 FLAKLJHBAKN, [Out] Collider EOIAMHDMPII);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 IIBHNKFDNNM, float FJCMDDHMEOM, Vector3 FNLCNMLAAKN, T[] JLAAPFHFBMI);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetObjectFromColliderInCurrentScope(Collider MFGADJMKIKN, [Out] T EIPECEKLNAK);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface BKBDOPJKFEI
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Bounds GBFCDPJDPAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Transform FKBAFNGEOKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Bounds OFHNFDEECJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Transform HIMALPGNEHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Vector3 BEIOMKJBHNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool EMFOCECDJGH
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
	void SetSelectionBoundsDirty(bool DGDJFDHOJGG = true, int DCDNANOCACJ = 0);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ShouldHideSelectionBoundsPreview(bool FLPAFPEINEO, object MFKHKDDANII);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface EDMDDFDPLAK
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	EBDGCEEEFPM IOENMPAKPGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface PFPELJELIMK
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool MBJGKAGELLC
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool FPKHLLJBDNO
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool OFOHKDLNCIE
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
	void TrySetPreviousCloneMapping(Dictionary<Guid, Guid> IFHFBMLAKOL);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface LCFFIEPONOC<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool EIIKLBOJPPE
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int JPBEGNGHIOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<TData> IDLKLHCIPHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData EOJOFJJBHLN);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData EOJOFJJBHLN);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface DFIILONKCLD<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T PMNHIPACJLN, [Optional] KBICEEBHCID? NNFDIFDOFPE, bool JOELPNCKLHE = true);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int MHMCOJIKNCI, IEnumerable<T> HHHHAPMJLOO, bool JOELPNCKLHE = true);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int MHMCOJIKNCI, IEnumerable<T> HHHHAPMJLOO, KBICEEBHCID NNFDIFDOFPE, bool JOELPNCKLHE = true);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface DNPFNHHAFPD
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface GPCBMJNHCAK
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool PABKEEJCKND
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool LAAGGNKCPDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool JJIMIOHBJOL
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool OBHINLGBOEK
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct AHKANFJOHJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public bool GMPCBLANPGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public float? CLNJGABHCKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public float? JAEBLPGKPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public float? CDLNHICFMFN;
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct DJCFFKFOLBM<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public IEnumerable<TData> NKAJOMAACPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public AHKANFJOHJJ BNJPBJILKDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public bool OHLBPFLIMFI;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x45F8B20", Offset = "0x45F7520", VA = "0x1845F8B20")]
	public DJCFFKFOLBM(IEnumerable<TData> NHDHENDGOCA, bool FIOMOPJBHOI, float? DOJMMLGPGGL, float? FBOHMIMNCKO, float? DMALEFHJEKL, bool OHLBPFLIMFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface BNDDNNCDKAN<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EHJPGICEMNO([In] DJCFFKFOLBM<TData> ALHCDLPBNNA);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class HGJFGLOJOGE<TData> : IOFEFEIHBDC<BNDDNNCDKAN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly DJCFFKFOLBM<TData> ALHCDLPBNNA;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x51B08C0", Offset = "0x51AF2C0", VA = "0x1851B08C0")]
	public HGJFGLOJOGE(IEnumerable<TData> NHDHENDGOCA, bool FIOMOPJBHOI, float? DOJMMLGPGGL, float? FBOHMIMNCKO, float? DMALEFHJEKL, bool OHLBPFLIMFI, BNDDNNCDKAN<TData> DCNLFPCOIJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x45D1270", Offset = "0x45CFC70", VA = "0x1845D1270", Slot = "4")]
	public override bool EHJPGICEMNO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct FEDPFAAIJBJ<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public IEnumerable<TData> NKAJOMAACPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public string PBPJPBFPLHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public bool MIDONKBDJHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public bool OHLBPFLIMFI;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4FBB850", Offset = "0x4FBA250", VA = "0x184FBB850")]
	public FEDPFAAIJBJ(IEnumerable<TData> NHDHENDGOCA, string CGPNBEBFGEL, bool LMEKBMMPLNF, bool OHLBPFLIMFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface OKCLALOAIOD<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EHJPGICEMNO([In] FEDPFAAIJBJ<TData> ALHCDLPBNNA);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class BMFFKNOLAEI<TData> : IOFEFEIHBDC<OKCLALOAIOD<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly FEDPFAAIJBJ<TData> ALHCDLPBNNA;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x677F810", Offset = "0x677E210", VA = "0x18677F810")]
	public BMFFKNOLAEI(IEnumerable<TData> NHDHENDGOCA, string CGPNBEBFGEL, bool LMEKBMMPLNF, bool OHLBPFLIMFI, OKCLALOAIOD<TData> DCNLFPCOIJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x45D1270", Offset = "0x45CFC70", VA = "0x1845D1270", Slot = "4")]
	public override bool EHJPGICEMNO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public abstract class IOFEFEIHBDC<TReceiver> : HFLNBNHPIPK<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4B11270", Offset = "0x4B0FC70", VA = "0x184B11270")]
	public IOFEFEIHBDC(TReceiver DCNLFPCOIJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class GMDHKPCMMBF<TReceiver, TFromTask> : HFLNBNHPIPK<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4B11270", Offset = "0x4B0FC70", VA = "0x184B11270")]
	public GMDHKPCMMBF(TReceiver DCNLFPCOIJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class HFLNBNHPIPK<TReceiver, TFromExecute> where TReceiver : notnull where TFromExecute : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	protected TReceiver DCNLFPCOIJG;

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x51AE070", Offset = "0x51ACA70", VA = "0x1851AE070")]
	public HFLNBNHPIPK(TReceiver DCNLFPCOIJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute EHJPGICEMNO();
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public abstract class IGOFMGEIIKB<TReceiver, TResult> : HFLNBNHPIPK<TReceiver, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4B11270", Offset = "0x4B0FC70", VA = "0x184B11270")]
	public IGOFMGEIIKB(TReceiver DCNLFPCOIJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct JNAAAHDPANN<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public TGroup GOHAPCLPIOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public TData MFANHMKKHGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public IEnumerable<TData> NKAJOMAACPD;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1E7E9B0", Offset = "0x1E7D3B0", VA = "0x181E7E9B0")]
	public JNAAAHDPANN(TGroup GCIKAKMOPKM, TData COHBOBHGKJI, IEnumerable<TData> NHDHENDGOCA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct DIDIPHBCMIA<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public TGroup GOHAPCLPIOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public IEnumerable<TData> NKAJOMAACPD;

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0xC64140", Offset = "0xC62B40", VA = "0x180C64140")]
	public DIDIPHBCMIA(TGroup GCIKAKMOPKM, IEnumerable<TData> NHDHENDGOCA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct FHPBDJDAINA<TGroup> where TGroup : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public TGroup GOHAPCLPIOE;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0xECC590", Offset = "0xECAF90", VA = "0x180ECC590")]
	public FHPBDJDAINA(TGroup GCIKAKMOPKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public struct OHAGMBMFGKM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public IEnumerable<Guid> NKAJOMAACPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public Guid OCNPEOOPLAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly bool GBCOPAILKDO;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x8552960", Offset = "0x8551360", VA = "0x188552960")]
	public OHAGMBMFGKM(IEnumerable<Guid> NHDHENDGOCA, Guid DIGGIEMHECE, bool OHLBPFLIMFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct BLDIPKEFPKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public Guid OCNPEOOPLAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly bool GBCOPAILKDO;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x29A9080", Offset = "0x29A7A80", VA = "0x1829A9080")]
	public BLDIPKEFPKH(Guid DIGGIEMHECE, bool OHLBPFLIMFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface KAHJILLNCBG<TGroup, TData>
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BHJAIHGBCJG MJLJPGMHLIP(JNAAAHDPANN<TGroup, TData> IPIHEHPOENM);

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "1")]
	BHJAIHGBCJG LFGFIOFEDIF(JNAAAHDPANN<TGroup, TData> IPIHEHPOENM);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "2")]
	BHJAIHGBCJG ANBOCFIKCKJ(DIDIPHBCMIA<TGroup, TData> IPIHEHPOENM);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "3")]
	BHJAIHGBCJG FLDNBECNFBL(FHPBDJDAINA<TGroup> IPIHEHPOENM);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface JJPJPLJFIHF
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<BHJAIHGBCJG> MJLJPGMHLIP(OHAGMBMFGKM IPIHEHPOENM);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<BHJAIHGBCJG> LFGFIOFEDIF(BLDIPKEFPKH IPIHEHPOENM);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class GPAGGEPPLBP<TGroup, TData> : IGOFMGEIIKB<KAHJILLNCBG<TGroup, TData>, BHJAIHGBCJG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly DIDIPHBCMIA<TGroup, TData> IPIHEHPOENM;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x515B4D0", Offset = "0x5159ED0", VA = "0x18515B4D0")]
	public GPAGGEPPLBP(TGroup GCIKAKMOPKM, IEnumerable<TData> NHDHENDGOCA, KAHJILLNCBG<TGroup, TData> DCNLFPCOIJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x515B400", Offset = "0x5159E00", VA = "0x18515B400", Slot = "4")]
	public override BHJAIHGBCJG EHJPGICEMNO()
	{
		return default(BHJAIHGBCJG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class FJCLNODKFOE<TGroup, TData> : IGOFMGEIIKB<KAHJILLNCBG<TGroup, TData>, BHJAIHGBCJG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly JNAAAHDPANN<TGroup, TData> IPIHEHPOENM;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x4B2A110", Offset = "0x4B28B10", VA = "0x184B2A110")]
	public FJCLNODKFOE(TGroup GCIKAKMOPKM, TData MAGIEFMJGHA, IEnumerable<TData> NHDHENDGOCA, KAHJILLNCBG<TGroup, TData> DCNLFPCOIJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5000A30", Offset = "0x4FFF430", VA = "0x185000A30", Slot = "4")]
	public override BHJAIHGBCJG EHJPGICEMNO()
	{
		return default(BHJAIHGBCJG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class JNFHCBAFAFJ<TGroup, TData> : IGOFMGEIIKB<KAHJILLNCBG<TGroup, TData>, BHJAIHGBCJG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly FHPBDJDAINA<TGroup> IPIHEHPOENM;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5123190", Offset = "0x5121B90", VA = "0x185123190")]
	public JNFHCBAFAFJ(TGroup GCIKAKMOPKM, KAHJILLNCBG<TGroup, TData> DCNLFPCOIJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x554B470", Offset = "0x5549E70", VA = "0x18554B470", Slot = "4")]
	public override BHJAIHGBCJG EHJPGICEMNO()
	{
		return default(BHJAIHGBCJG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class EIPMDIMJELH<TGroup, TData> : IGOFMGEIIKB<KAHJILLNCBG<TGroup, TData>, BHJAIHGBCJG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly JNAAAHDPANN<TGroup, TData> IPIHEHPOENM;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4B2A110", Offset = "0x4B28B10", VA = "0x184B2A110")]
	public EIPMDIMJELH(TGroup GCIKAKMOPKM, TData COHBOBHGKJI, IEnumerable<TData> NHDHENDGOCA, KAHJILLNCBG<TGroup, TData> DCNLFPCOIJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x4B2A030", Offset = "0x4B28A30", VA = "0x184B2A030", Slot = "4")]
	public override BHJAIHGBCJG EHJPGICEMNO()
	{
		return default(BHJAIHGBCJG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class KBAIDOFMFJH : GMDHKPCMMBF<JJPJPLJFIHF, BHJAIHGBCJG>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private struct OOFMKHGKNBM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public AsyncTaskMethodBuilder<BHJAIHGBCJG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public KBAIDOFMFJH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private TaskAwaiter<BHJAIHGBCJG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x85529A0", Offset = "0x85513A0", VA = "0x1885529A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8552C40", Offset = "0x8551640", VA = "0x188552C40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private OHAGMBMFGKM IPIHEHPOENM;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x8552040", Offset = "0x8550A40", VA = "0x188552040")]
	public KBAIDOFMFJH(IEnumerable<Guid> JNDOKHCGJMM, Guid DIGGIEMHECE, bool OHLBPFLIMFI, JJPJPLJFIHF DCNLFPCOIJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x8551F50", Offset = "0x8550950", VA = "0x188551F50", Slot = "4")]
	[AsyncStateMachine(typeof(OOFMKHGKNBM))]
	public override Task<BHJAIHGBCJG> EHJPGICEMNO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class HIMFBANJCMO : GMDHKPCMMBF<JJPJPLJFIHF, BHJAIHGBCJG>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private struct KELKEEBMHJH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public AsyncTaskMethodBuilder<BHJAIHGBCJG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public HIMFBANJCMO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private TaskAwaiter<BHJAIHGBCJG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8552250", Offset = "0x8550C50", VA = "0x188552250", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x85524F0", Offset = "0x8550EF0", VA = "0x1885524F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly BLDIPKEFPKH IPIHEHPOENM;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x8551E90", Offset = "0x8550890", VA = "0x188551E90")]
	public HIMFBANJCMO(Guid DIGGIEMHECE, bool OHLBPFLIMFI, JJPJPLJFIHF DCNLFPCOIJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x8551DA0", Offset = "0x85507A0", VA = "0x188551DA0", Slot = "4")]
	[AsyncStateMachine(typeof(KELKEEBMHJH))]
	public override Task<BHJAIHGBCJG> EHJPGICEMNO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public readonly struct BPJJHNICCAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly EMFEIIGEJHH JHGAMNNJHED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly bool GBCOPAILKDO;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x85514B0", Offset = "0x854FEB0", VA = "0x1885514B0")]
	public BPJJHNICCAL(EMFEIIGEJHH OLGJLLCPGFF, bool OHLBPFLIMFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface CCDOPMBKHJH<TSpawnType> where TSpawnType : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> EHJPGICEMNO(BPJJHNICCAL IELONEIEGEP);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class HPPLGONBHHA<TSpawnType> : GMDHKPCMMBF<CCDOPMBKHJH<TSpawnType>, TSpawnType> where TSpawnType : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct BLGNOCJPDCM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public AsyncTaskMethodBuilder<TSpawnType> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public HPPLGONBHHA<TSpawnType> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<TSpawnType> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6779080", Offset = "0x6777A80", VA = "0x186779080", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x45F8A80", Offset = "0x45F7480", VA = "0x1845F8A80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly BPJJHNICCAL IELONEIEGEP;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5222DC0", Offset = "0x52217C0", VA = "0x185222DC0")]
	public HPPLGONBHHA(EMFEIIGEJHH OLGJLLCPGFF, bool OHLBPFLIMFI, CCDOPMBKHJH<TSpawnType> DCNLFPCOIJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5222AC0", Offset = "0x52214C0", VA = "0x185222AC0", Slot = "4")]
	[AsyncStateMachine(typeof(HPPLGONBHHA<>.BLGNOCJPDCM))]
	public override Task<TSpawnType> EHJPGICEMNO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public readonly struct EMFEIIGEJHH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly bool KIKPBLGPIJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly Vector3 PBKLLMHCKDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly Vector3 NGNFCFGNCAH;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x8551640", Offset = "0x8550040", VA = "0x188551640")]
	public EMFEIIGEJHH(Transform HIFNPAFONDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x85516B0", Offset = "0x85500B0", VA = "0x1885516B0")]
	public EMFEIIGEJHH(Vector3 BJGHDDIMDNJ, Vector3 KFJFDPLEJOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8551610", Offset = "0x8550010", VA = "0x188551610")]
	public static EMFEIIGEJHH AFCIIKKNNFA()
	{
		return default(EMFEIIGEJHH);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x85516E0", Offset = "0x85500E0", VA = "0x1885516E0")]
	private EMFEIIGEJHH(bool KBFCHDMEBEC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct CHKLLDDLALK<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public TNode NCAPNJODKCO;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6CE1C50", Offset = "0x6CE0650", VA = "0x186CE1C50")]
	public CHKLLDDLALK(TNode NCAPNJODKCO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct GAMKHBPPAGE<TNode, TReparentOperations> where TNode : notnull where TReparentOperations : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public TNode COGKPNKAJMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public TReparentOperations PJMMDGAMGHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public AJCAHHIKMIC ONPODAEKMLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly bool GBCOPAILKDO;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x511BDA0", Offset = "0x511A7A0", VA = "0x18511BDA0")]
	public GAMKHBPPAGE(TNode COGKPNKAJMG, TReparentOperations PJMMDGAMGHG, AJCAHHIKMIC ONPODAEKMLJ, bool OHLBPFLIMFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface GLNOHGDKHID<TNode, TReparentOperations>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FFCOMNCGPMF([In] CHKLLDDLALK<TNode> EBHEFFPCJHL);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CCMLCCPANCC([In] GAMKHBPPAGE<TNode, TReparentOperations> PCJFMLKDKCA);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool EHPIPOJFFAJ();
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class OBMLDMLHMJG<TNode, TReparentOperations> : IOFEFEIHBDC<GLNOHGDKHID<TNode, TReparentOperations>>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x4B11270", Offset = "0x4B0FC70", VA = "0x184B11270")]
	public OBMLDMLHMJG(GLNOHGDKHID<TNode, TReparentOperations> DCNLFPCOIJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x51240A0", Offset = "0x5122AA0", VA = "0x1851240A0", Slot = "4")]
	public override bool EHJPGICEMNO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class PBIANJPADDP<TNode, TReparentOperations> : IOFEFEIHBDC<GLNOHGDKHID<TNode, TReparentOperations>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly GAMKHBPPAGE<TNode, TReparentOperations> PCJFMLKDKCA;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5C8F1E0", Offset = "0x5C8DBE0", VA = "0x185C8F1E0")]
	public PBIANJPADDP(TNode COGKPNKAJMG, TReparentOperations PJMMDGAMGHG, AJCAHHIKMIC ONPODAEKMLJ, GLNOHGDKHID<TNode, TReparentOperations> DCNLFPCOIJG, bool OHLBPFLIMFI = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x4AF1A20", Offset = "0x4AF0420", VA = "0x184AF1A20", Slot = "4")]
	public override bool EHJPGICEMNO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class OHDBIEDOHDA<TNode, TReparentOperations> : IOFEFEIHBDC<GLNOHGDKHID<TNode, TReparentOperations>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly CHKLLDDLALK<TNode> EBHEFFPCJHL;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5BAD9A0", Offset = "0x5BAC3A0", VA = "0x185BAD9A0")]
	public OHDBIEDOHDA(TNode IKFCFDKKPNI, GLNOHGDKHID<TNode, TReparentOperations> DCNLFPCOIJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x45D1270", Offset = "0x45CFC70", VA = "0x1845D1270", Slot = "4")]
	public override bool EHJPGICEMNO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct FBNAAKMDDBF<TSpawnInfo> where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public TSpawnInfo IABPGCGGHCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public Vector3 KFJFDPLEJOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public Quaternion AMHDLJKDJBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public float NIAMAMNMMFM;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x4FAC640", Offset = "0x4FAB040", VA = "0x184FAC640")]
	public FBNAAKMDDBF(TSpawnInfo IABPGCGGHCH, Vector3 KFJFDPLEJOD, Quaternion AMHDLJKDJBK, float NIAMAMNMMFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface CDOBLGLFHCI<TSpawnType, TSpawnInfo>
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> PAKFILFILKD([In] FBNAAKMDDBF<TSpawnInfo> EPBCOFNNACC, CancellationToken AHOMALKMHKK);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class BHMJGONDKOO<TSpawnType, TSpawnInfo> : GMDHKPCMMBF<CDOBLGLFHCI<TSpawnType, TSpawnInfo>, TSpawnType> where TSpawnType : notnull where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly FBNAAKMDDBF<TSpawnInfo> ALHCDLPBNNA;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x676F450", Offset = "0x676DE50", VA = "0x18676F450")]
	public BHMJGONDKOO(TSpawnInfo LCLIOGHHENN, Vector3 KFJFDPLEJOD, Quaternion AMHDLJKDJBK, float NIAMAMNMMFM, CDOBLGLFHCI<TSpawnType, TSpawnInfo> DCNLFPCOIJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5405E20", Offset = "0x5404820", VA = "0x185405E20", Slot = "4")]
	public override Task<TSpawnType> EHJPGICEMNO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public readonly struct BFEBBGAEANK<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly IEnumerable<TData> NKAJOMAACPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly bool GBCOPAILKDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly bool JOBJDBGGKNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly bool HEBHFCGHIAN;

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x668E3B0", Offset = "0x668CDB0", VA = "0x18668E3B0")]
	public BFEBBGAEANK(IEnumerable<TData> NHDHENDGOCA, bool OHLBPFLIMFI = false, bool GPCMCMPMLCG = false, bool PJHDHOFEJIP = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface JKNEADIJAIG<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<BHJAIHGBCJG> MONAKDGEGPJ([In] BFEBBGAEANK<TData> GMHAMEGCEMD, CancellationToken AHOMALKMHKK);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class AJEFLIFNEKN<TData> : GMDHKPCMMBF<JKNEADIJAIG<TData>, BHJAIHGBCJG> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly BFEBBGAEANK<TData> NAOCIGEIPAE;

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5405F00", Offset = "0x5404900", VA = "0x185405F00")]
	public AJEFLIFNEKN(IEnumerable<TData> NHDHENDGOCA, bool OHLBPFLIMFI, JKNEADIJAIG<TData> DCNLFPCOIJG, bool GEBEMOHOLOO = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5405E20", Offset = "0x5404820", VA = "0x185405E20", Slot = "4")]
	public override Task<BHJAIHGBCJG> EHJPGICEMNO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct BKMJBHOALMJ<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly T JFBLIPHGGPK;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x4688EA0", Offset = "0x46878A0", VA = "0x184688EA0")]
	public BKMJBHOALMJ(T MGBBOEMKNIC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface PDDDNBAPOKO<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FFCOMNCGPMF([In] BKMJBHOALMJ<T> OOFGHEEPGCM);

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CCMLCCPANCC();
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface DDKNAGJPBLM<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EHJPGICEMNO([In] DMDACIBPNKN<T> JCPJNGNANHJ);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public struct DMDACIBPNKN<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly T JFBLIPHGGPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly bool GDIENEDBLNC;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x4609620", Offset = "0x4608020", VA = "0x184609620")]
	public DMDACIBPNKN(T MGBBOEMKNIC, bool KKMLACEOGNI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class HAOIHAIHMPH<T> : IOFEFEIHBDC<PDDDNBAPOKO<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x4B11270", Offset = "0x4B0FC70", VA = "0x184B11270")]
	public HAOIHAIHMPH(PDDDNBAPOKO<T> DCNLFPCOIJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x518A590", Offset = "0x5188F90", VA = "0x18518A590", Slot = "4")]
	public override bool EHJPGICEMNO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class GDCKPELDPFH<T> : IOFEFEIHBDC<PDDDNBAPOKO<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly BKMJBHOALMJ<T> OOFGHEEPGCM;

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5123120", Offset = "0x5121B20", VA = "0x185123120")]
	public GDCKPELDPFH(T JFBLIPHGGPK, PDDDNBAPOKO<T> DCNLFPCOIJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x45D1270", Offset = "0x45CFC70", VA = "0x1845D1270", Slot = "4")]
	public override bool EHJPGICEMNO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class AFBBOBDPFJJ<T> : IOFEFEIHBDC<DDKNAGJPBLM<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly DMDACIBPNKN<T> JCPJNGNANHJ;

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5305C70", Offset = "0x5304670", VA = "0x185305C70")]
	public AFBBOBDPFJJ(T JFBLIPHGGPK, bool KKMLACEOGNI, DDKNAGJPBLM<T> DCNLFPCOIJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x45D1270", Offset = "0x45CFC70", VA = "0x1845D1270", Slot = "4")]
	public override bool EHJPGICEMNO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public struct MGJMOLOMDPO<TData> where TData : notnull, OBALFHIEJDB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public IEnumerable<TData> NKAJOMAACPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public bool HFDPJEAIECB;

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x59616D0", Offset = "0x59600D0", VA = "0x1859616D0")]
	public MGJMOLOMDPO(IEnumerable<TData> ONIOHHFPPEB, bool DOIHNAODIOA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct KBPDFGNBFCF<TData> where TData : notnull, OBALFHIEJDB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public List<TData> NKAJOMAACPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public List<bool> GLGHHLJFKNA;

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x563FB50", Offset = "0x563E550", VA = "0x18563FB50")]
	public KBPDFGNBFCF(List<TData> ONIOHHFPPEB, List<bool> EAOAMBOIBLF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface OBALFHIEJDB
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool PJLAMMPOBIO
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface EBGAAPEEBIL<TData> where TData : OBALFHIEJDB
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EHJPGICEMNO([In] MGJMOLOMDPO<TData> MMJMCMGHLPN);

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EHJPGICEMNO([In] KBPDFGNBFCF<TData> MMJMCMGHLPN);
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface IDHMIEMGHPO<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DOAGDBEPICI(T JFBLIPHGGPK);
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class DGMAEDIKGJD<TData> : IOFEFEIHBDC<EBGAAPEEBIL<TData>> where TData : notnull, OBALFHIEJDB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly MGJMOLOMDPO<TData> MMJMCMGHLPN;

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x45EF440", Offset = "0x45EDE40", VA = "0x1845EF440")]
	public DGMAEDIKGJD(List<TData> NHDHENDGOCA, bool HFDPJEAIECB, EBGAAPEEBIL<TData> DCNLFPCOIJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x45D1270", Offset = "0x45CFC70", VA = "0x1845D1270", Slot = "4")]
	public override bool EHJPGICEMNO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public class INJJAFLKCLB<TData> : IOFEFEIHBDC<EBGAAPEEBIL<TData>> where TData : notnull, OBALFHIEJDB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly KBPDFGNBFCF<TData> MMJMCMGHLPN;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x52FB890", Offset = "0x52FA290", VA = "0x1852FB890")]
	public INJJAFLKCLB(List<TData> NHDHENDGOCA, List<bool> GLGHHLJFKNA, EBGAAPEEBIL<TData> DCNLFPCOIJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x52FB7D0", Offset = "0x52FA1D0", VA = "0x1852FB7D0", Slot = "4")]
	public override bool EHJPGICEMNO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public interface FNLADJBDHEJ<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<BHJAIHGBCJG> EHJPGICEMNO(KIIHMIDBIMB<TData> FHKOFIOFAHO);
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class EHFLILLPDPA<TData> : GMDHKPCMMBF<FNLADJBDHEJ<TData>, BHJAIHGBCJG> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private struct IGJBIDIBIGL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public AsyncTaskMethodBuilder<BHJAIHGBCJG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public EHFLILLPDPA<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private TaskAwaiter<BHJAIHGBCJG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x52EB400", Offset = "0x52E9E00", VA = "0x1852EB400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x52EB6F0", Offset = "0x52EA0F0", VA = "0x1852EB6F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly KIIHMIDBIMB<TData> JOLFDIKHHFC;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4B13C80", Offset = "0x4B12680", VA = "0x184B13C80")]
	public EHFLILLPDPA(TData IIDANFBNOAD, IReadOnlyList<TData> NMFAKOGMJMB, bool OHLBPFLIMFI, FNLADJBDHEJ<TData> DCNLFPCOIJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x4B13B80", Offset = "0x4B12580", VA = "0x184B13B80", Slot = "4")]
	[AsyncStateMachine(typeof(EHFLILLPDPA<>.IGJBIDIBIGL))]
	public override Task<BHJAIHGBCJG> EHJPGICEMNO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public struct KIIHMIDBIMB<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public TData NJHHHHNIPGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public IReadOnlyList<TData> EGFGFIHKMCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public bool GBCOPAILKDO;

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x1215D20", Offset = "0x1214720", VA = "0x181215D20")]
	public KIIHMIDBIMB(TData IIDANFBNOAD, IReadOnlyList<TData> NMFAKOGMJMB, bool OHLBPFLIMFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public interface HDPMAEJJJFJ<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EHJPGICEMNO([In] ONIMBFBAAPD<TData> CBCGGGKHJIM);
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface JGHAJJPBKCP<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EHJPGICEMNO([In] DBPDHDBDBEO<TData> CBCGGGKHJIM);
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface MKNINEOFPML<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NLHNMFOGMDM([In] ODHIPEOBMGL<TData> CBCGGGKHJIM);

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CCMLCCPANCC();
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class DAGBKEOCFMC<TData> : IOFEFEIHBDC<HDPMAEJJJFJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly ONIMBFBAAPD<TData> CBCGGGKHJIM;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x45D1330", Offset = "0x45CFD30", VA = "0x1845D1330")]
	public DAGBKEOCFMC(IEnumerable<TData> NHDHENDGOCA, FIHNPCHPOKM EOGEFFOIIOP, MFJKGLKLLDL PJPBFBIEGMK, float CMEKBCKEHIJ, string? CGPNBEBFGEL, bool LFAJACALCKA, bool OHLBPFLIMFI, HDPMAEJJJFJ<TData> DCNLFPCOIJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x45D1270", Offset = "0x45CFC70", VA = "0x1845D1270", Slot = "4")]
	public override bool EHJPGICEMNO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class HGIIJCKJEIP<TData> : IOFEFEIHBDC<JGHAJJPBKCP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly DBPDHDBDBEO<TData> CBCGGGKHJIM;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x51B0720", Offset = "0x51AF120", VA = "0x1851B0720")]
	public HGIIJCKJEIP(TData[] NHDHENDGOCA, FIHNPCHPOKM[] EOGEFFOIIOP, MFJKGLKLLDL[] PJPBFBIEGMK, float[] CMEKBCKEHIJ, JGHAJJPBKCP<TData> DCNLFPCOIJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x45F5E00", Offset = "0x45F4800", VA = "0x1845F5E00", Slot = "4")]
	public override bool EHJPGICEMNO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class KJFNMFIGGED<TData> : IOFEFEIHBDC<MKNINEOFPML<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x4B11270", Offset = "0x4B0FC70", VA = "0x184B11270")]
	public KJFNMFIGGED(MKNINEOFPML<TData> DCNLFPCOIJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5673FD0", Offset = "0x56729D0", VA = "0x185673FD0", Slot = "4")]
	public override bool EHJPGICEMNO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class DHAEFDMJOKM<TData> : IOFEFEIHBDC<MKNINEOFPML<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly ODHIPEOBMGL<TData> CBCGGGKHJIM;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x45F5EC0", Offset = "0x45F48C0", VA = "0x1845F5EC0")]
	public DHAEFDMJOKM(IEnumerable<TData> NHDHENDGOCA, FIHNPCHPOKM EOGEFFOIIOP, MFJKGLKLLDL PJPBFBIEGMK, float CMEKBCKEHIJ, MKNINEOFPML<TData> DCNLFPCOIJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x45F5E00", Offset = "0x45F4800", VA = "0x1845F5E00", Slot = "4")]
	public override bool EHJPGICEMNO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public struct ONIMBFBAAPD<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public IEnumerable<TData> NKAJOMAACPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public FIHNPCHPOKM JCMKCPCHLFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public MFJKGLKLLDL OCAHEHKLJJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public float PCMMDIDGJBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public string? PBPJPBFPLHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public bool? KFMBGLPHIPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public bool GBCOPAILKDO;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x5BC7CE0", Offset = "0x5BC66E0", VA = "0x185BC7CE0")]
	public ONIMBFBAAPD(IEnumerable<TData> NHDHENDGOCA, FIHNPCHPOKM EOGEFFOIIOP, MFJKGLKLLDL PJPBFBIEGMK, float CMEKBCKEHIJ, string? CGPNBEBFGEL, bool? LFAJACALCKA, bool OHLBPFLIMFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct DBPDHDBDBEO<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public TData[] NKAJOMAACPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public FIHNPCHPOKM[] JCMKCPCHLFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public MFJKGLKLLDL[] OCAHEHKLJJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public float[] CMEKBCKEHIJ;

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x45D60F0", Offset = "0x45D4AF0", VA = "0x1845D60F0")]
	public DBPDHDBDBEO(TData[] NHDHENDGOCA, FIHNPCHPOKM[] EOGEFFOIIOP, MFJKGLKLLDL[] PJPBFBIEGMK, float[] CMEKBCKEHIJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public struct ODHIPEOBMGL<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public IEnumerable<TData> NKAJOMAACPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public FIHNPCHPOKM JCMKCPCHLFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public MFJKGLKLLDL OCAHEHKLJJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public float CMEKBCKEHIJ;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x5BA21D0", Offset = "0x5BA0BD0", VA = "0x185BA21D0")]
	public ODHIPEOBMGL(IEnumerable<TData> NHDHENDGOCA, FIHNPCHPOKM EOGEFFOIIOP, MFJKGLKLLDL PJPBFBIEGMK, float CMEKBCKEHIJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface HHAJODIMFEH<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ANBOCFIKCKJ([In] OJBKLLBPLAE<TData> GMHAMEGCEMD);

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FLDNBECNFBL([In] OJBKLLBPLAE<TData> GMHAMEGCEMD);

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LCLBBFFGBNJ([In] bool DJKNLAPOGGG);

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DGFCBDOLPGE([In] OJBKLLBPLAE<TData> GMHAMEGCEMD);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AIBOGDINEHN();

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool DIJECNPGCMO([In] TData CEMLGIEIAFD);
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class FIMJEAAEGFC<TData> : IOFEFEIHBDC<HHAJODIMFEH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly OJBKLLBPLAE<TData> GMHAMEGCEMD;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x4FFC020", Offset = "0x4FFAA20", VA = "0x184FFC020")]
	public FIMJEAAEGFC(List<TData> GLPDKCPPLJM, HHAJODIMFEH<TData> DCNLFPCOIJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x45D1270", Offset = "0x45CFC70", VA = "0x1845D1270", Slot = "4")]
	public override bool EHJPGICEMNO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class CLMGNAODHIC<TData> : IOFEFEIHBDC<HHAJODIMFEH<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4B11270", Offset = "0x4B0FC70", VA = "0x184B11270")]
	public CLMGNAODHIC(HHAJODIMFEH<TData> DCNLFPCOIJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6CEDD00", Offset = "0x6CEC700", VA = "0x186CEDD00", Slot = "4")]
	public override bool EHJPGICEMNO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class IJDENCGJPCL<TData> : IOFEFEIHBDC<HHAJODIMFEH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly bool OHLBPFLIMFI;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x52EFE00", Offset = "0x52EE800", VA = "0x1852EFE00")]
	public IJDENCGJPCL(bool OHLBPFLIMFI, HHAJODIMFEH<TData> DCNLFPCOIJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x52EFDA0", Offset = "0x52EE7A0", VA = "0x1852EFDA0", Slot = "4")]
	public override bool EHJPGICEMNO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class BMHAKENLOFI<TData> : IOFEFEIHBDC<HHAJODIMFEH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly OJBKLLBPLAE<TData> GMHAMEGCEMD;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x677F970", Offset = "0x677E370", VA = "0x18677F970")]
	public BMHAKENLOFI(List<TData> GLPDKCPPLJM, bool OHLBPFLIMFI, HHAJODIMFEH<TData> DCNLFPCOIJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x52FB7D0", Offset = "0x52FA1D0", VA = "0x1852FB7D0", Slot = "4")]
	public override bool EHJPGICEMNO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class IGDPAEJIBDL<TData> : IOFEFEIHBDC<HHAJODIMFEH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly TData CEMLGIEIAFD;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x52E81D0", Offset = "0x52E6BD0", VA = "0x1852E81D0")]
	public IGDPAEJIBDL(TData CEMLGIEIAFD, HHAJODIMFEH<TData> DCNLFPCOIJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x52E8100", Offset = "0x52E6B00", VA = "0x1852E8100", Slot = "4")]
	public override bool EHJPGICEMNO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class GKHKAOABHLH<TData> : IOFEFEIHBDC<HHAJODIMFEH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private readonly OJBKLLBPLAE<TData> GMHAMEGCEMD;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x5130AE0", Offset = "0x512F4E0", VA = "0x185130AE0")]
	public GKHKAOABHLH(IEnumerable<TData> GLPDKCPPLJM, HHAJODIMFEH<TData> DCNLFPCOIJG, bool OHLBPFLIMFI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x5130980", Offset = "0x512F380", VA = "0x185130980", Slot = "4")]
	public override bool EHJPGICEMNO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public struct OJBKLLBPLAE<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public IEnumerable<TData> NKAJOMAACPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public bool OHLBPFLIMFI;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x5BB5F90", Offset = "0x5BB4990", VA = "0x185BB5F90")]
	public OJBKLLBPLAE(IEnumerable<TData> ONIOHHFPPEB, bool GDFJAKEJPFE = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public interface MGLHHLMAPNJ
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<BHJAIHGBCJG> EHJPGICEMNO(NOCAGFEGLOL IGDJCKKOONJ);
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class KBBDLDJBEND : GMDHKPCMMBF<MGLHHLMAPNJ, BHJAIHGBCJG>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private struct FGLKEGPDDJO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public AsyncTaskMethodBuilder<BHJAIHGBCJG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public KBBDLDJBEND <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private TaskAwaiter<BHJAIHGBCJG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x8551AB0", Offset = "0x85504B0", VA = "0x188551AB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8551D20", Offset = "0x8550720", VA = "0x188551D20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private readonly NOCAGFEGLOL NHBHMAIHJMM;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x85521F0", Offset = "0x8550BF0", VA = "0x1885521F0")]
	public KBBDLDJBEND(bool OHLBPFLIMFI, MGLHHLMAPNJ DCNLFPCOIJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x8552100", Offset = "0x8550B00", VA = "0x188552100", Slot = "4")]
	[AsyncStateMachine(typeof(FGLKEGPDDJO))]
	public override Task<BHJAIHGBCJG> EHJPGICEMNO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public struct NOCAGFEGLOL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public bool GBCOPAILKDO;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x2DD8640", Offset = "0x2DD7040", VA = "0x182DD8640")]
	public NOCAGFEGLOL(bool OHLBPFLIMFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public readonly struct GAGPDPKJDEE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public readonly bool CPGNMBHDDNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public readonly bool GJFNJKPEABF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public readonly bool NIAMAMNMMFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public readonly bool OHLBPFLIMFI;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6362370", Offset = "0x6360D70", VA = "0x186362370")]
	public GAGPDPKJDEE(bool CPGNMBHDDNN, bool GJFNJKPEABF, bool NIAMAMNMMFM, bool OHLBPFLIMFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x8551D90", Offset = "0x8550790", VA = "0x188551D90")]
	public GAGPDPKJDEE(bool GJFNJKPEABF, bool OHLBPFLIMFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public interface FIBNBGPHIJN
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NLPIEJLMJCI(GAGPDPKJDEE FLPENIHHBJG);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DLMIKEAKMOB(GAGPDPKJDEE FLPENIHHBJG);
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public class ECBEKIKLKGC : IOFEFEIHBDC<FIBNBGPHIJN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly GAGPDPKJDEE FLPENIHHBJG;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x8551580", Offset = "0x854FF80", VA = "0x188551580")]
	public ECBEKIKLKGC(bool HALOMIKDIAH, bool GJFNJKPEABF, bool NIAMAMNMMFM, bool OHLBPFLIMFI, FIBNBGPHIJN DCNLFPCOIJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x8551530", Offset = "0x854FF30", VA = "0x188551530", Slot = "4")]
	public override bool EHJPGICEMNO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class MJMJADEHECE : IOFEFEIHBDC<FIBNBGPHIJN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly GAGPDPKJDEE FLPENIHHBJG;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x85525D0", Offset = "0x8550FD0", VA = "0x1885525D0")]
	public MJMJADEHECE(bool GJFNJKPEABF, bool OHLBPFLIMFI, FIBNBGPHIJN DCNLFPCOIJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x8552580", Offset = "0x8550F80", VA = "0x188552580", Slot = "4")]
	public override bool EHJPGICEMNO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public interface KBDCFKJGNFP
{
	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EHJPGICEMNO([In] POFLGJLJPGM FMGFHCMBEHB);
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class NPPPHKKBIGG : IOFEFEIHBDC<KBDCFKJGNFP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly POFLGJLJPGM FMGFHCMBEHB;

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x8552700", Offset = "0x8551100", VA = "0x188552700")]
	public NPPPHKKBIGG(Guid[] BGEPPHEDOFM, Vector3[] DIHECIFIECF, Quaternion[] PCOKJDLFECK, float[] DFGJDPHBLKA, Dictionary<Guid, Vector3> AKLIOOPKEEE, KBDCFKJGNFP DCNLFPCOIJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x8552650", Offset = "0x8551050", VA = "0x188552650", Slot = "4")]
	public override bool EHJPGICEMNO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public interface FDPMKMJHPOO<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FFCOMNCGPMF([In] BLOHPIELGBA<TData> EBHEFFPCJHL);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NLHNMFOGMDM([In] LHLJIDODKBA CJACLEMKAMG);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NLHNMFOGMDM([In] DPFLLLKMJNM CJACLEMKAMG);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CCMLCCPANCC();
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class GMCHEKDIEPI<TData> : IOFEFEIHBDC<FDPMKMJHPOO<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x4B11270", Offset = "0x4B0FC70", VA = "0x184B11270")]
	public GMCHEKDIEPI(FDPMKMJHPOO<TData> DCNLFPCOIJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x51365B0", Offset = "0x5134FB0", VA = "0x1851365B0", Slot = "4")]
	public override bool EHJPGICEMNO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public class IDLFHKKACJJ<TData> : IOFEFEIHBDC<FDPMKMJHPOO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly LHLJIDODKBA AHAOFKHLOFM;

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x52D3FD0", Offset = "0x52D29D0", VA = "0x1852D3FD0")]
	public IDLFHKKACJJ(Vector3 BAHFKHANCHG, bool COEPEIBGINM, FDPMKMJHPOO<TData> DCNLFPCOIJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x51942A0", Offset = "0x5192CA0", VA = "0x1851942A0", Slot = "4")]
	public override bool EHJPGICEMNO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class JCALMMIGNCG<TData> : IOFEFEIHBDC<FDPMKMJHPOO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly DPFLLLKMJNM AHAOFKHLOFM;

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5530D80", Offset = "0x552F780", VA = "0x185530D80")]
	public JCALMMIGNCG(Guid NEAEPMLPNLA, int KABGMIEBEFC, Vector3 KFJFDPLEJOD, Quaternion AMHDLJKDJBK, float JBOIDCJHBGG, bool COEPEIBGINM, FDPMKMJHPOO<TData> DCNLFPCOIJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5530D20", Offset = "0x552F720", VA = "0x185530D20", Slot = "4")]
	public override bool EHJPGICEMNO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class OCPIBNBEODH<TData> : IOFEFEIHBDC<FDPMKMJHPOO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly BLOHPIELGBA<TData> AHAOFKHLOFM;

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5B9E3A0", Offset = "0x5B9CDA0", VA = "0x185B9E3A0")]
	public OCPIBNBEODH(TData JFBLIPHGGPK, bool OHLBPFLIMFI, FDPMKMJHPOO<TData> DCNLFPCOIJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x45D1270", Offset = "0x45CFC70", VA = "0x1845D1270", Slot = "4")]
	public override bool EHJPGICEMNO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct LHLJIDODKBA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public readonly Vector3 BAHFKHANCHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public readonly bool COEPEIBGINM;

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x8552560", Offset = "0x8550F60", VA = "0x188552560")]
	public LHLJIDODKBA(Vector3 BAHFKHANCHG, bool COEPEIBGINM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public struct DPFLLLKMJNM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public readonly Guid NEAEPMLPNLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public readonly int KABGMIEBEFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public readonly Vector3 KFJFDPLEJOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly Quaternion AMHDLJKDJBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public readonly float JBOIDCJHBGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public readonly bool COEPEIBGINM;

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x85514F0", Offset = "0x854FEF0", VA = "0x1885514F0")]
	public DPFLLLKMJNM(Guid NEAEPMLPNLA, int KABGMIEBEFC, Vector3 KFJFDPLEJOD, Quaternion AMHDLJKDJBK, float JBOIDCJHBGG, bool COEPEIBGINM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public struct BLOHPIELGBA<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public readonly TData JFBLIPHGGPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public readonly bool OHLBPFLIMFI;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x677C0D0", Offset = "0x677AAD0", VA = "0x18677C0D0")]
	public BLOHPIELGBA(TData JFBLIPHGGPK, bool OHLBPFLIMFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public interface DFFOOFNIFPC<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EHJPGICEMNO([In] PEMPNCPCFON<TData> NJHGKNMKIOH);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EHJPGICEMNO([In] OHFKHNILIBF<TData> NJHGKNMKIOH);
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public interface HGAKIKMEGJO<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FFCOMNCGPMF([In] PMOIFOILEDM<TData> DKLAJANHPJF);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NLHNMFOGMDM([In] NLKHAAILDBO CJACLEMKAMG);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CCMLCCPANCC();
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public class KKBIPELBBJC<TData> : IOFEFEIHBDC<DFFOOFNIFPC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly PEMPNCPCFON<TData> NJHGKNMKIOH;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x56747C0", Offset = "0x56731C0", VA = "0x1856747C0")]
	public KKBIPELBBJC(IEnumerable<TData> NHDHENDGOCA, Vector3 LHMOAKNJHFL, bool OHLBPFLIMFI, DFFOOFNIFPC<TData> DCNLFPCOIJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x45D1270", Offset = "0x45CFC70", VA = "0x1845D1270", Slot = "4")]
	public override bool EHJPGICEMNO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public class CEKEFIIEAGK<TData> : IOFEFEIHBDC<HGAKIKMEGJO<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x4B11270", Offset = "0x4B0FC70", VA = "0x184B11270")]
	public CEKEFIIEAGK(HGAKIKMEGJO<TData> DCNLFPCOIJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x51240A0", Offset = "0x5122AA0", VA = "0x1851240A0", Slot = "4")]
	public override bool EHJPGICEMNO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class BBODGNNGNGG<TData> : IOFEFEIHBDC<HGAKIKMEGJO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly PMOIFOILEDM<TData> NJHGKNMKIOH;

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x667DFB0", Offset = "0x667C9B0", VA = "0x18667DFB0")]
	public BBODGNNGNGG(IEnumerable<TData> NHDHENDGOCA, bool OHLBPFLIMFI, HGAKIKMEGJO<TData> DCNLFPCOIJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x45D1270", Offset = "0x45CFC70", VA = "0x1845D1270", Slot = "4")]
	public override bool EHJPGICEMNO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class EAAIGBBHJKM<TData> : IOFEFEIHBDC<DFFOOFNIFPC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly OHFKHNILIBF<TData> NJHGKNMKIOH;

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x4AF1AF0", Offset = "0x4AF04F0", VA = "0x184AF1AF0")]
	public EAAIGBBHJKM(IEnumerable<TData> NHDHENDGOCA, Vector3 GPODCLFNANH, BNCGLCLJCPJ OILCGDIFJHC, bool OHLBPFLIMFI, DFFOOFNIFPC<TData> DCNLFPCOIJG, Space ONMNLKMFPFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x4AF1A20", Offset = "0x4AF0420", VA = "0x184AF1A20", Slot = "4")]
	public override bool EHJPGICEMNO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class AHFFIBEABDE<TData> : IOFEFEIHBDC<HGAKIKMEGJO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly NLKHAAILDBO NJHGKNMKIOH;

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x53FB1A0", Offset = "0x53F9BA0", VA = "0x1853FB1A0")]
	public AHFFIBEABDE(Vector3 LHMOAKNJHFL, HGAKIKMEGJO<TData> DCNLFPCOIJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x51942A0", Offset = "0x5192CA0", VA = "0x1851942A0", Slot = "4")]
	public override bool EHJPGICEMNO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public struct PEMPNCPCFON<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public readonly IEnumerable<TData> NHDHENDGOCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public readonly Vector3 LHMOAKNJHFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public readonly bool OHLBPFLIMFI;

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x5CA1D20", Offset = "0x5CA0720", VA = "0x185CA1D20")]
	public PEMPNCPCFON(IEnumerable<TData> NHDHENDGOCA, Vector3 LHMOAKNJHFL, bool OHLBPFLIMFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public struct PMOIFOILEDM<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public readonly IEnumerable<TData> NHDHENDGOCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public readonly bool OHLBPFLIMFI;

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x5CC5C70", Offset = "0x5CC4670", VA = "0x185CC5C70")]
	public PMOIFOILEDM(IEnumerable<TData> NHDHENDGOCA, bool OHLBPFLIMFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public struct OHFKHNILIBF<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public readonly IEnumerable<TData> NHDHENDGOCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public readonly Vector3 GPODCLFNANH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public readonly BNCGLCLJCPJ OILCGDIFJHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public readonly bool OHLBPFLIMFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public readonly Space ONMNLKMFPFM;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x5BADCC0", Offset = "0x5BAC6C0", VA = "0x185BADCC0")]
	public OHFKHNILIBF(IEnumerable<TData> NHDHENDGOCA, Vector3 GPODCLFNANH, BNCGLCLJCPJ OILCGDIFJHC, bool OHLBPFLIMFI, Space ONMNLKMFPFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public struct NLKHAAILDBO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public readonly Vector3 LHMOAKNJHFL;

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x2DDA4C0", Offset = "0x2DD8EC0", VA = "0x182DDA4C0")]
	public NLKHAAILDBO(Vector3 LHMOAKNJHFL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public enum BNCGLCLJCPJ
{
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	XYZ,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	X_only,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	Y_only,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	Z_only
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public interface NDGMCBBPKEG
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EHJPGICEMNO([In] JAEBOBMCFAG KLGPCBDCKHD);
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public class FGCNANDFJIA : IOFEFEIHBDC<NDGMCBBPKEG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private readonly JAEBOBMCFAG KLGPCBDCKHD;

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x8551A50", Offset = "0x8550450", VA = "0x188551A50")]
	public FGCNANDFJIA(bool OHLBPFLIMFI, NDGMCBBPKEG DCNLFPCOIJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x85519A0", Offset = "0x85503A0", VA = "0x1885519A0", Slot = "4")]
	public override bool EHJPGICEMNO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public readonly struct JAEBOBMCFAG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public readonly bool OHLBPFLIMFI;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x2DD8640", Offset = "0x2DD7040", VA = "0x182DD8640")]
	public JAEBOBMCFAG(bool OHLBPFLIMFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public interface BNGBEKAKMBP<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EHJPGICEMNO([In] MJCCGIOIMBE<TData> EACMOHKLKEH);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EHJPGICEMNO([In] NNFPEIGHDBI<TData> EACMOHKLKEH);
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public interface GDKKAJALIOG<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FFCOMNCGPMF([In] AIOGNPNMPKH<TData> EBHEFFPCJHL);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NLHNMFOGMDM([In] PPHENGFFFPD CJACLEMKAMG);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CCMLCCPANCC();
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class CIIEIIOHBBK<TData> : IOFEFEIHBDC<BNGBEKAKMBP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly MJCCGIOIMBE<TData> EACMOHKLKEH;

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x6CE4440", Offset = "0x6CE2E40", VA = "0x186CE4440")]
	public CIIEIIOHBBK(IEnumerable<TData> NHDHENDGOCA, Quaternion LHMOAKNJHFL, Vector3? KDBDGOBDHIF, bool KNKBFGEAEBK, bool OHLBPFLIMFI, BNGBEKAKMBP<TData> DCNLFPCOIJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x45D1270", Offset = "0x45CFC70", VA = "0x1845D1270", Slot = "4")]
	public override bool EHJPGICEMNO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class GDKPEGINEMG<TData> : IOFEFEIHBDC<GDKKAJALIOG<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x4B11270", Offset = "0x4B0FC70", VA = "0x184B11270")]
	public GDKPEGINEMG(GDKKAJALIOG<TData> DCNLFPCOIJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x51240A0", Offset = "0x5122AA0", VA = "0x1851240A0", Slot = "4")]
	public override bool EHJPGICEMNO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public class EAJBPFFIJKF<TData> : IOFEFEIHBDC<GDKKAJALIOG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly AIOGNPNMPKH<TData> EACMOHKLKEH;

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x4AF2340", Offset = "0x4AF0D40", VA = "0x184AF2340")]
	public EAJBPFFIJKF(IEnumerable<TData> NHDHENDGOCA, bool OHLBPFLIMFI, GDKKAJALIOG<TData> DCNLFPCOIJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x45D1270", Offset = "0x45CFC70", VA = "0x1845D1270", Slot = "4")]
	public override bool EHJPGICEMNO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public class PKENPMABJHG<TData> : IOFEFEIHBDC<BNGBEKAKMBP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly NNFPEIGHDBI<TData> EACMOHKLKEH;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x5CBED90", Offset = "0x5CBD790", VA = "0x185CBED90")]
	public PKENPMABJHG(IEnumerable<TData> NHDHENDGOCA, Quaternion JPNIBOFIBEB, BNCGLCLJCPJ FJCHNKEGFIB, Vector3? KDBDGOBDHIF, bool KNKBFGEAEBK, bool OHLBPFLIMFI, Space ONMNLKMFPFM, BNGBEKAKMBP<TData> DCNLFPCOIJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x4AF1A20", Offset = "0x4AF0420", VA = "0x184AF1A20", Slot = "4")]
	public override bool EHJPGICEMNO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public class CHPODBJKGND<TData> : IOFEFEIHBDC<GDKKAJALIOG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly PPHENGFFFPD EACMOHKLKEH;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x6CE4200", Offset = "0x6CE2C00", VA = "0x186CE4200")]
	public CHPODBJKGND(Quaternion LHMOAKNJHFL, Vector3? KDBDGOBDHIF, bool KNKBFGEAEBK, GDKKAJALIOG<TData> DCNLFPCOIJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x51942A0", Offset = "0x5192CA0", VA = "0x1851942A0", Slot = "4")]
	public override bool EHJPGICEMNO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public struct MJCCGIOIMBE<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public readonly IEnumerable<TData> NHDHENDGOCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public readonly Quaternion LHMOAKNJHFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public readonly Vector3? KDBDGOBDHIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly bool KNKBFGEAEBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public readonly bool OHLBPFLIMFI;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x596A030", Offset = "0x5968A30", VA = "0x18596A030")]
	public MJCCGIOIMBE(IEnumerable<TData> NHDHENDGOCA, Quaternion LHMOAKNJHFL, Vector3? KDBDGOBDHIF, bool KNKBFGEAEBK, bool OHLBPFLIMFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct AIOGNPNMPKH<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly IEnumerable<TData> NHDHENDGOCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public readonly bool OHLBPFLIMFI;

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x53FDF60", Offset = "0x53FC960", VA = "0x1853FDF60")]
	public AIOGNPNMPKH(IEnumerable<TData> NHDHENDGOCA, bool OHLBPFLIMFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public struct NNFPEIGHDBI<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public readonly IEnumerable<TData> NHDHENDGOCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public readonly Quaternion JPNIBOFIBEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public readonly BNCGLCLJCPJ FJCHNKEGFIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public readonly Vector3? KDBDGOBDHIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public readonly bool KNKBFGEAEBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public readonly bool OHLBPFLIMFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public readonly Space ONMNLKMFPFM;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x5A68520", Offset = "0x5A66F20", VA = "0x185A68520")]
	public NNFPEIGHDBI(IEnumerable<TData> NHDHENDGOCA, Quaternion JPNIBOFIBEB, BNCGLCLJCPJ FJCHNKEGFIB, Vector3? KDBDGOBDHIF, bool KNKBFGEAEBK, bool OHLBPFLIMFI, Space ONMNLKMFPFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public struct PPHENGFFFPD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public readonly Quaternion LHMOAKNJHFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public readonly Vector3? KDBDGOBDHIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public readonly bool KNKBFGEAEBK;

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x6309A50", Offset = "0x6308450", VA = "0x186309A50")]
	public PPHENGFFFPD(Quaternion LHMOAKNJHFL, Vector3? KDBDGOBDHIF, bool KNKBFGEAEBK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public interface EIHGGCJOLGE<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FFCOMNCGPMF([In] PPAFMLHIHBH<TData> EBHEFFPCJHL);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NLHNMFOGMDM([In] PPFOIGPJFEN CJACLEMKAMG);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NLHNMFOGMDM([In] CPOCHPBJBKI CJACLEMKAMG);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool NLHNMFOGMDM([In] IJFJAGMHOFM CJACLEMKAMG);

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool CCMLCCPANCC();
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public class IDKHACDBPCC<TData> : IOFEFEIHBDC<EIHGGCJOLGE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly IJFJAGMHOFM OPHNMFEAHLJ;

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x52D3ED0", Offset = "0x52D28D0", VA = "0x1852D3ED0")]
	public IDKHACDBPCC(Vector3 LNODIFMIAFN, float NMALOKPPLFM, Vector3 KDBDGOBDHIF, bool NJBEGJIOCMM, bool PFNFNJMPCGF, EIHGGCJOLGE<TData> DCNLFPCOIJG, Space ONMNLKMFPFM = Space.Self)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x52D3E70", Offset = "0x52D2870", VA = "0x1852D3E70", Slot = "4")]
	public override bool EHJPGICEMNO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public class BFLIJOAJDAC<TData> : IOFEFEIHBDC<EIHGGCJOLGE<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x4B11270", Offset = "0x4B0FC70", VA = "0x184B11270")]
	public BFLIJOAJDAC(EIHGGCJOLGE<TData> DCNLFPCOIJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6693C60", Offset = "0x6692660", VA = "0x186693C60", Slot = "4")]
	public override bool EHJPGICEMNO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public class CFADMPMAPGK<TData> : IOFEFEIHBDC<EIHGGCJOLGE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private readonly PPAFMLHIHBH<TData> OPHNMFEAHLJ;

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6CD80B0", Offset = "0x6CD6AB0", VA = "0x186CD80B0")]
	public CFADMPMAPGK(IEnumerable<TData> NHDHENDGOCA, bool OHLBPFLIMFI, EIHGGCJOLGE<TData> DCNLFPCOIJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x45D1270", Offset = "0x45CFC70", VA = "0x1845D1270", Slot = "4")]
	public override bool EHJPGICEMNO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public class CIHBODDMDHE<TData> : IOFEFEIHBDC<EIHGGCJOLGE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly CPOCHPBJBKI OPHNMFEAHLJ;

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6CE4390", Offset = "0x6CE2D90", VA = "0x186CE4390")]
	public CIHBODDMDHE(float FLLKCEKFDBD, bool KMHDHHLGFIG, Vector3 KDBDGOBDHIF, EIHGGCJOLGE<TData> DCNLFPCOIJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6CE42C0", Offset = "0x6CE2CC0", VA = "0x186CE42C0", Slot = "4")]
	public override bool EHJPGICEMNO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public class HCDHALJJILO<TData> : IOFEFEIHBDC<EIHGGCJOLGE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private readonly PPFOIGPJFEN OPHNMFEAHLJ;

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x5194300", Offset = "0x5192D00", VA = "0x185194300")]
	public HCDHALJJILO(float NMALOKPPLFM, Vector3 KDBDGOBDHIF, EIHGGCJOLGE<TData> DCNLFPCOIJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x51942A0", Offset = "0x5192CA0", VA = "0x1851942A0", Slot = "4")]
	public override bool EHJPGICEMNO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public struct IJFJAGMHOFM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public readonly Vector3 LNODIFMIAFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public readonly float NMALOKPPLFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public readonly Vector3 KDBDGOBDHIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public readonly bool COEPEIBGINM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public readonly Space ONMNLKMFPFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public readonly bool PFNFNJMPCGF;

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x8551F10", Offset = "0x8550910", VA = "0x188551F10")]
	public IJFJAGMHOFM(Vector3 LNODIFMIAFN, float NMALOKPPLFM, Vector3 KDBDGOBDHIF, bool COEPEIBGINM, bool EJCPMCLNHML, Space ONMNLKMFPFM = Space.Self)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public struct PPAFMLHIHBH<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public readonly IEnumerable<TData> NHDHENDGOCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public readonly bool OHLBPFLIMFI;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x5CD53B0", Offset = "0x5CD3DB0", VA = "0x185CD53B0")]
	public PPAFMLHIHBH(IEnumerable<TData> NHDHENDGOCA, bool OHLBPFLIMFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public struct CPOCHPBJBKI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public readonly float FLLKCEKFDBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public readonly bool KMHDHHLGFIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public readonly Vector3 KDBDGOBDHIF;

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x85514D0", Offset = "0x854FED0", VA = "0x1885514D0")]
	public CPOCHPBJBKI(float FLLKCEKFDBD, bool KMHDHHLGFIG, Vector3 KDBDGOBDHIF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public struct PPFOIGPJFEN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public readonly float NMALOKPPLFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public readonly Vector3 KDBDGOBDHIF;

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x62CD300", Offset = "0x62CBD00", VA = "0x1862CD300")]
	public PPFOIGPJFEN(float NMALOKPPLFM, Vector3 KDBDGOBDHIF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public struct POFLGJLJPGM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public readonly Guid[] NHDHENDGOCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public readonly bool EPGJAOIEHPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public readonly bool PANPAKPOEBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public readonly bool IAHPLNLMLKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public readonly Vector3[] DIHECIFIECF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public readonly Quaternion[] PCOKJDLFECK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public readonly float[] DFGJDPHBLKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public readonly Dictionary<Guid, Vector3> AKLIOOPKEEE;

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x8552E80", Offset = "0x8551880", VA = "0x188552E80")]
	public POFLGJLJPGM(Guid[] BGEPPHEDOFM, Vector3[] DIHECIFIECF, Quaternion[] PCOKJDLFECK, float[] DFGJDPHBLKA, Dictionary<Guid, Vector3> AKLIOOPKEEE, bool EPGJAOIEHPB = true, bool PANPAKPOEBL = true, bool IAHPLNLMLKK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x8552CB0", Offset = "0x85516B0", VA = "0x188552CB0")]
	private static void JGBLGBPODID(Dictionary<Guid, Vector3> AKLIOOPKEEE, int EONPGDPEFJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public static class BLDJNKNKHAN
{
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	private struct AOPLLBOGMFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public bool ECOBIBNCCPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public JBJKIIKOACK PDOJMJHDBJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public JBJKIIKOACK OOCKNNKKOPO;
	}

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static AOPLLBOGMFD GIAAPMGNKKO;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static CancellationToken EBOBALABOOI
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x8551230", Offset = "0x854FC30", VA = "0x188551230")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	internal static JBJKIIKOACK PDOJMJHDBJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x8551190", Offset = "0x854FB90", VA = "0x188551190")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x8551120", Offset = "0x854FB20", VA = "0x188551120")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x8551250", Offset = "0x854FC50", VA = "0x188551250")]
	[DMKNBLIJJON.FPNPBOEMEDG]
	internal static void NJIHGMBMMOP(JBJKIIKOACK DDECMJEEIAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x8551350", Offset = "0x854FD50", VA = "0x188551350")]
	public static void NPPCJNEPLIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x85510D0", Offset = "0x854FAD0", VA = "0x1885510D0")]
	private static JBJKIIKOACK EAMPCKOKEFD(JBJKIIKOACK FIALHPNIOPO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public static class HLHCGFINPPC
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public enum EMNHJDGJALE
	{
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		ICreationContextObject,
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		Guid
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x3DCF240", Offset = "0x3DCDC40", VA = "0x183DCF240")]
	public static void HJFJBOAEKPD<T>(T GMFHHDBKLAN, EMNHJDGJALE DGNODDPLLPC) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3DCF1E0", Offset = "0x3DCDBE0", VA = "0x183DCF1E0")]
	public static void HJFJBOAEKPD<T>(T GMFHHDBKLAN) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x3DCF100", Offset = "0x3DCDB00", VA = "0x183DCF100")]
	public static void HJFJBOAEKPD<T, TImpl, T>() where T : class where TImpl : notnull, T where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x3DCF000", Offset = "0x3DCDA00", VA = "0x183DCF000")]
	public static void COAMELCGILL<T>(T GMFHHDBKLAN) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x3DCF070", Offset = "0x3DCDA70", VA = "0x183DCF070")]
	public static T GFFPJLNAMHB<T>(EMNHJDGJALE DGNODDPLLPC) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x3DCF480", Offset = "0x3DCDE80", VA = "0x183DCF480")]
	public static bool NLKHMGDKJML<T>(EMNHJDGJALE DGNODDPLLPC, T? NLIKMCJNFFJ, [Out][NotNullWhen(true)][MaybeNullWhen(false)] T LIFGJOGEKFO) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x3DCF380", Offset = "0x3DCDD80", VA = "0x183DCF380")]
	public static bool LHDMMIIKKJC<T>(EMNHJDGJALE DGNODDPLLPC, [Out][NotNullWhen(true)][MaybeNullWhen(false)] T KJOJFBHLPEI) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x3DCEF30", Offset = "0x3DCD930", VA = "0x183DCEF30")]
	public static bool ACNDEODDCOA<T>(EMNHJDGJALE DGNODDPLLPC) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x3DCEFC0", Offset = "0x3DCD9C0", VA = "0x183DCEFC0")]
	public static T GFFPJLNAMHB<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x3DCF5B0", Offset = "0x3DCDFB0", VA = "0x183DCF5B0")]
	public static bool NLKHMGDKJML<T>(T NLIKMCJNFFJ, [Out] T LIFGJOGEKFO) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x3DCEFC0", Offset = "0x3DCD9C0", VA = "0x183DCEFC0")]
	public static bool ACNDEODDCOA<T>() where T : class
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
internal static class ENDJKCGKDFN
{
	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x8551770", Offset = "0x8550170", VA = "0x188551770")]
	public static void ADFPPALMAJA(IEnumerable LGAPDHILJMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x3C139C0", Offset = "0x3C123C0", VA = "0x183C139C0")]
	public static void ADFPPALMAJA<T>(T[] BHEONMJLANC) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x3C13BA0", Offset = "0x3C125A0", VA = "0x183C13BA0")]
	public static void ADFPPALMAJA<T>(T OGMIMHJKKEG) where T : notnull, Enum
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
