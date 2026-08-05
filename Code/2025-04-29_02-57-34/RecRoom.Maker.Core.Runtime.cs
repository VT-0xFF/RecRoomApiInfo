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
		[Cpp2IlInjected.Address(RVA = "0x9F4500", Offset = "0x9F3900", VA = "0x1809F4500")]
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
		[Cpp2IlInjected.Address(RVA = "0x7B58550", Offset = "0x7B57950", VA = "0x187B58550")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9F5340", Offset = "0x9F4740", VA = "0x1809F5340")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F5380", Offset = "0x9F4780", VA = "0x1809F5380")]
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
		[Cpp2IlInjected.Address(RVA = "0x7B586F0", Offset = "0x7B57AF0", VA = "0x187B586F0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x25D0340", Offset = "0x25CF740", VA = "0x1825D0340")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface FFKGLKNKDOL<TData, TReturn>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TReturn GPGPGCMEAID(TData KLANNNFBLNB);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface GOMFPMEPHFA<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ClearHoverTarget(KIMALGAAEBM NBGNIGEADFJ);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool SetHoverTarget(TData EJCNBBIIFBE, Collider KGBHGCLBAPD, KIMALGAAEBM NBGNIGEADFJ, [Optional] PDIICNIPGKM? HNAEBFPHJHB);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool TryGetHoverTarget([Out] TData EJCNBBIIFBE);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetHoverCollider([Out] Collider KGBHGCLBAPD);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface CFOFIGGBNPF<TData> : HOHKJGIIDKE, DMMCIPJHAIE<TData>, IIFLNNIMBEE<TData>, JEFCCDINLKL<TData>, LFJIMNLCFLC, JELNKLPAGAM<TData>, HIOJBHFGOJI, AACLCEKDINO
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface JELNKLPAGAM<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 JBGLGLFDDMH, Vector3 DJMLEJBBDGG, float IJIIMBMEDNE, [Out] T DEKKAJKKCOK, [Out] Vector3 HHINPLEJLOH, [Out] Collider KGBHGCLBAPD);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 JBGLGLFDDMH, Vector3 DJMLEJBBDGG, float FODPFBANEBL, float IJIIMBMEDNE, T[] ADPALPDHCGM, [Out] Vector3 INLFEJKAPGK, [Out] Collider GLINHDNJNKM);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 JBGLGLFDDMH, float FODPFBANEBL, Vector3 AKIOIEAOMIO, T[] ADPALPDHCGM);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetObjectFromColliderInCurrentScope(Collider MHJFLJOPCBJ, [Out] T DLOHHAGEBGE);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface HOHKJGIIDKE
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Bounds DMMKPJADFKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Transform NGAHGPKMNJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Bounds ADPPLJAKAJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Transform CKBGAPCDNLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Vector3 IOCHPGDKBFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool MEECONOEGGA
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
	void SetSelectionBoundsDirty(bool BOPNNABBHHE = true, int BEPCIAPBJOG = 0);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ShouldHideSelectionBoundsPreview(bool BAKJAFGJGJA, object PAHPIGHLKFG);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface AACLCEKDINO
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	KFBDEOPEKLE CDBCMJPEAAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface ABFGPGIPJGM
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool PBPLJHLANJN
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool HONMLLEGJJB
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool ELIINABAHKF
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
	void TrySetPreviousCloneMapping(Dictionary<Guid, Guid> HICNCOPMBJE);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface JEFCCDINLKL<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool IEFGOEOLGMP
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int MCLBIKOPGFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<TData> GGPIAIDINPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData NNAMOJMJBHC);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData NNAMOJMJBHC);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface DMMCIPJHAIE<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T KLANNNFBLNB, [Optional] PDIICNIPGKM? JPIKKNDHDGO, bool GHPJBFBJLEK = true);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int PCGLBCNIEAP, IEnumerable<T> ILMOMHGFJFP, bool GHPJBFBJLEK = true);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int PCGLBCNIEAP, IEnumerable<T> ILMOMHGFJFP, PDIICNIPGKM JPIKKNDHDGO, bool GHPJBFBJLEK = true);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface HIOJBHFGOJI
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface LFJIMNLCFLC
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool OGEOCHPIOGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool OIIHAJMCBHC
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool KDECHIMLGFD
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool LKNHJKLEFOL
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct NFGKMCFMIPA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public bool PKBEBHBKPNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public float? MFDJPDGLHMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public float? HAANNFPOLBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public float? BHCMIAKLOCM;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct OMECCMGFKLM<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public IEnumerable<TData> MFEIEAGJALF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public NFGKMCFMIPA PPGDEOGMPMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public bool LJNKHBBIILP;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x53716E0", Offset = "0x5370AE0", VA = "0x1853716E0")]
	public OMECCMGFKLM(IEnumerable<TData> MKLPEMJHLAF, bool IJGDBIKHMCB, float? IPLFHNHJCGH, float? OGPEFHDLAJP, float? EEDIKIHBDLK, bool LJNKHBBIILP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface CMNFLKBEDKO<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NBMDPHCGIHP([In] OMECCMGFKLM<TData> KBIBHMCLJNL);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class APHONGFOGIM<TData> : GEKBENFILHF<CMNFLKBEDKO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly OMECCMGFKLM<TData> KBIBHMCLJNL;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4CA4CD0", Offset = "0x4CA40D0", VA = "0x184CA4CD0")]
	public APHONGFOGIM(IEnumerable<TData> MKLPEMJHLAF, bool IJGDBIKHMCB, float? IPLFHNHJCGH, float? OGPEFHDLAJP, float? EEDIKIHBDLK, bool LJNKHBBIILP, CMNFLKBEDKO<TData> JKOBGLOJMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4380140", Offset = "0x437F540", VA = "0x184380140", Slot = "4")]
	public override bool NBMDPHCGIHP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct ODEIANEFCBP<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public IEnumerable<TData> MFEIEAGJALF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public string AJINEAMGDGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public bool OJHGIODFFGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public bool LJNKHBBIILP;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x53355E0", Offset = "0x53349E0", VA = "0x1853355E0")]
	public ODEIANEFCBP(IEnumerable<TData> MKLPEMJHLAF, string FMJPEADOCOC, bool DLGNKDHHKEE, bool LJNKHBBIILP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface GAHKFJFMJGM<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NBMDPHCGIHP([In] ODEIANEFCBP<TData> KBIBHMCLJNL);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class GKDAIHCHKPO<TData> : GEKBENFILHF<GAHKFJFMJGM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly ODEIANEFCBP<TData> KBIBHMCLJNL;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x48C2DB0", Offset = "0x48C21B0", VA = "0x1848C2DB0")]
	public GKDAIHCHKPO(IEnumerable<TData> MKLPEMJHLAF, string FMJPEADOCOC, bool DLGNKDHHKEE, bool LJNKHBBIILP, GAHKFJFMJGM<TData> JKOBGLOJMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x4380140", Offset = "0x437F540", VA = "0x184380140", Slot = "4")]
	public override bool NBMDPHCGIHP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public abstract class GEKBENFILHF<TReceiver> : DBGEBHFIGJM<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x47C3890", Offset = "0x47C2C90", VA = "0x1847C3890")]
	public GEKBENFILHF(TReceiver JKOBGLOJMAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public abstract class GKKKNENBILO<TReceiver, TFromTask> : DBGEBHFIGJM<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x47C3890", Offset = "0x47C2C90", VA = "0x1847C3890")]
	public GKKKNENBILO(TReceiver JKOBGLOJMAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public abstract class DBGEBHFIGJM<TReceiver, TFromExecute> where TReceiver : notnull where TFromExecute : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	protected TReceiver JKOBGLOJMAJ;

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6878800", Offset = "0x6877C00", VA = "0x186878800")]
	public DBGEBHFIGJM(TReceiver JKOBGLOJMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute NBMDPHCGIHP();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class HFGGOEPHNJA<TReceiver, TResult> : DBGEBHFIGJM<TReceiver, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x47C3890", Offset = "0x47C2C90", VA = "0x1847C3890")]
	public HFGGOEPHNJA(TReceiver JKOBGLOJMAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct IJCNENCJCDF<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public TGroup GJCHJJLGCPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public TData AJGGGLKHLBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public IEnumerable<TData> MFEIEAGJALF;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x25E1080", Offset = "0x25E0480", VA = "0x1825E1080")]
	public IJCNENCJCDF(TGroup ALDMMGOAJDF, TData NNMDGLIAICO, IEnumerable<TData> MKLPEMJHLAF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct MKBPOMPOPLH<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public TGroup GJCHJJLGCPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public IEnumerable<TData> MFEIEAGJALF;

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0xA813A0", Offset = "0xA807A0", VA = "0x180A813A0")]
	public MKBPOMPOPLH(TGroup ALDMMGOAJDF, IEnumerable<TData> MKLPEMJHLAF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct IDBNOGGCGLP<TGroup> where TGroup : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public TGroup GJCHJJLGCPG;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0xCE6E00", Offset = "0xCE6200", VA = "0x180CE6E00")]
	public IDBNOGGCGLP(TGroup ALDMMGOAJDF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct GMNKHAHABIN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public IEnumerable<Guid> MFEIEAGJALF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public Guid NPAFALPMJOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public readonly bool LOCNMJLFKLI;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7B576F0", Offset = "0x7B56AF0", VA = "0x187B576F0")]
	public GMNKHAHABIN(IEnumerable<Guid> MKLPEMJHLAF, Guid MPAHHEHMCIK, bool LJNKHBBIILP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct DKHOJJEFCEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public Guid NPAFALPMJOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly bool LOCNMJLFKLI;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x24F8490", Offset = "0x24F7890", VA = "0x1824F8490")]
	public DKHOJJEFCEF(Guid MPAHHEHMCIK, bool LJNKHBBIILP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface HAFECLEOMFB<TGroup, TData>
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GEIHOCLKBBC NANNAAGACLB(IJCNENCJCDF<TGroup, TData> NANDPAABAOA);

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GEIHOCLKBBC DNPKBCMMBMA(IJCNENCJCDF<TGroup, TData> NANDPAABAOA);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GEIHOCLKBBC OLEDGCKMFML(MKBPOMPOPLH<TGroup, TData> NANDPAABAOA);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GEIHOCLKBBC FADNCIJHMED(IDBNOGGCGLP<TGroup> NANDPAABAOA);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface FDJNIJDBMNH
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<GEIHOCLKBBC> NANNAAGACLB(GMNKHAHABIN NANDPAABAOA);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<GEIHOCLKBBC> DNPKBCMMBMA(DKHOJJEFCEF NANDPAABAOA);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class CMAIMECPPGN<TGroup, TData> : HFGGOEPHNJA<HAFECLEOMFB<TGroup, TData>, GEIHOCLKBBC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly MKBPOMPOPLH<TGroup, TData> NANDPAABAOA;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6632650", Offset = "0x6631A50", VA = "0x186632650")]
	public CMAIMECPPGN(TGroup ALDMMGOAJDF, IEnumerable<TData> MKLPEMJHLAF, HAFECLEOMFB<TGroup, TData> JKOBGLOJMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6632580", Offset = "0x6631980", VA = "0x186632580", Slot = "4")]
	public override GEIHOCLKBBC NBMDPHCGIHP()
	{
		return default(GEIHOCLKBBC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class OBAMFNHJMFG<TGroup, TData> : HFGGOEPHNJA<HAFECLEOMFB<TGroup, TData>, GEIHOCLKBBC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly IJCNENCJCDF<TGroup, TData> NANDPAABAOA;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x532E710", Offset = "0x532DB10", VA = "0x18532E710")]
	public OBAMFNHJMFG(TGroup ALDMMGOAJDF, TData PHCMHFKLLOK, IEnumerable<TData> MKLPEMJHLAF, HAFECLEOMFB<TGroup, TData> JKOBGLOJMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x532E630", Offset = "0x532DA30", VA = "0x18532E630", Slot = "4")]
	public override GEIHOCLKBBC NBMDPHCGIHP()
	{
		return default(GEIHOCLKBBC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class GBLDKFAKDFO<TGroup, TData> : HFGGOEPHNJA<HAFECLEOMFB<TGroup, TData>, GEIHOCLKBBC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly IDBNOGGCGLP<TGroup> NANDPAABAOA;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x488BEB0", Offset = "0x488B2B0", VA = "0x18488BEB0")]
	public GBLDKFAKDFO(TGroup ALDMMGOAJDF, HAFECLEOMFB<TGroup, TData> JKOBGLOJMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x488BDE0", Offset = "0x488B1E0", VA = "0x18488BDE0", Slot = "4")]
	public override GEIHOCLKBBC NBMDPHCGIHP()
	{
		return default(GEIHOCLKBBC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class OCHBBDHLEAN<TGroup, TData> : HFGGOEPHNJA<HAFECLEOMFB<TGroup, TData>, GEIHOCLKBBC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly IJCNENCJCDF<TGroup, TData> NANDPAABAOA;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x532E710", Offset = "0x532DB10", VA = "0x18532E710")]
	public OCHBBDHLEAN(TGroup ALDMMGOAJDF, TData NNMDGLIAICO, IEnumerable<TData> MKLPEMJHLAF, HAFECLEOMFB<TGroup, TData> JKOBGLOJMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5330CC0", Offset = "0x53300C0", VA = "0x185330CC0", Slot = "4")]
	public override GEIHOCLKBBC NBMDPHCGIHP()
	{
		return default(GEIHOCLKBBC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class LIFMBKDAJKD : GKKKNENBILO<FDJNIJDBMNH, GEIHOCLKBBC>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct DEGKMLJHHIN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public AsyncTaskMethodBuilder<GEIHOCLKBBC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public LIFMBKDAJKD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private TaskAwaiter<GEIHOCLKBBC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7B56CB0", Offset = "0x7B560B0", VA = "0x187B56CB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7B56F50", Offset = "0x7B56350", VA = "0x187B56F50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private GMNKHAHABIN NANDPAABAOA;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7B58160", Offset = "0x7B57560", VA = "0x187B58160")]
	public LIFMBKDAJKD(IEnumerable<Guid> GCGJMHNPIEE, Guid MPAHHEHMCIK, bool LJNKHBBIILP, FDJNIJDBMNH JKOBGLOJMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7B58070", Offset = "0x7B57470", VA = "0x187B58070", Slot = "4")]
	[AsyncStateMachine(typeof(DEGKMLJHHIN))]
	public override Task<GEIHOCLKBBC> NBMDPHCGIHP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class ABMELEHPOEN : GKKKNENBILO<FDJNIJDBMNH, GEIHOCLKBBC>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private struct EHADHPCGLCE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public AsyncTaskMethodBuilder<GEIHOCLKBBC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public ABMELEHPOEN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private TaskAwaiter<GEIHOCLKBBC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7B56FE0", Offset = "0x7B563E0", VA = "0x187B56FE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7B57280", Offset = "0x7B56680", VA = "0x187B57280", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly DKHOJJEFCEF NANDPAABAOA;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7B56790", Offset = "0x7B55B90", VA = "0x187B56790")]
	public ABMELEHPOEN(Guid MPAHHEHMCIK, bool LJNKHBBIILP, FDJNIJDBMNH JKOBGLOJMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7B566A0", Offset = "0x7B55AA0", VA = "0x187B566A0", Slot = "4")]
	[AsyncStateMachine(typeof(EHADHPCGLCE))]
	public override Task<GEIHOCLKBBC> NBMDPHCGIHP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public readonly struct MDHBCILJMEA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly LFEEPLIPOFA LOEPLHNBHKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly bool LOCNMJLFKLI;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7B58220", Offset = "0x7B57620", VA = "0x187B58220")]
	public MDHBCILJMEA(LFEEPLIPOFA HOLDCGGHHNA, bool LJNKHBBIILP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface DAIOFIKNPCC<TSpawnType> where TSpawnType : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> NBMDPHCGIHP(MDHBCILJMEA LCJFCENLLNH);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class MGPLFEDCOLP<TSpawnType> : GKKKNENBILO<DAIOFIKNPCC<TSpawnType>, TSpawnType> where TSpawnType : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct HJAIKKEFMOO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public AsyncTaskMethodBuilder<TSpawnType> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public MGPLFEDCOLP<TSpawnType> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private TaskAwaiter<TSpawnType> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x4928890", Offset = "0x4927C90", VA = "0x184928890", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x43BE940", Offset = "0x43BDD40", VA = "0x1843BE940", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly MDHBCILJMEA LCJFCENLLNH;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x50BEEF0", Offset = "0x50BE2F0", VA = "0x1850BEEF0")]
	public MGPLFEDCOLP(LFEEPLIPOFA HOLDCGGHHNA, bool LJNKHBBIILP, DAIOFIKNPCC<TSpawnType> JKOBGLOJMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x50BECD0", Offset = "0x50BE0D0", VA = "0x1850BECD0", Slot = "4")]
	[AsyncStateMachine(typeof(MGPLFEDCOLP<>.HJAIKKEFMOO))]
	public override Task<TSpawnType> NBMDPHCGIHP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct LFEEPLIPOFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public readonly bool MKKKDNADOIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly Vector3 BGEOGBAFMGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly Vector3 KHAINEMBOCD;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7B58000", Offset = "0x7B57400", VA = "0x187B58000")]
	public LFEEPLIPOFA(Transform IFDGLJHMPPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7B57FD0", Offset = "0x7B573D0", VA = "0x187B57FD0")]
	public LFEEPLIPOFA(Vector3 KBGACFDBMJG, Vector3 KBPOHLLNAIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7B57F10", Offset = "0x7B57310", VA = "0x187B57F10")]
	public static LFEEPLIPOFA LEEDLDCPNEM()
	{
		return default(LFEEPLIPOFA);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7B57F40", Offset = "0x7B57340", VA = "0x187B57F40")]
	private LFEEPLIPOFA(bool BFFJGJKNBFA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct NICLIICNOBF<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public TNode IHCGNFCKMJH;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x51ACEA0", Offset = "0x51AC2A0", VA = "0x1851ACEA0")]
	public NICLIICNOBF(TNode IHCGNFCKMJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct CGFMPDPCOIJ<TNode, TReparentOperations> where TNode : notnull where TReparentOperations : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public TNode DBNLEGDLJHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public TReparentOperations OCIIMNCNPDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public DJBGOFIKOJN BCNCACFKAKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly bool LOCNMJLFKLI;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6473F50", Offset = "0x6473350", VA = "0x186473F50")]
	public CGFMPDPCOIJ(TNode DBNLEGDLJHI, TReparentOperations OCIIMNCNPDO, DJBGOFIKOJN BCNCACFKAKF, bool LJNKHBBIILP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface MEPJCGGHMDE<TNode, TReparentOperations>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AFEBBMKCHIF([In] NICLIICNOBF<TNode> NNFGPAHLGMN);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CAAHHEPMDDL([In] CGFMPDPCOIJ<TNode, TReparentOperations> LGEPIKCDOLM);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MEHIEMJEJKJ();
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class BFBHMGBJLHH<TNode, TReparentOperations> : GEKBENFILHF<MEPJCGGHMDE<TNode, TReparentOperations>>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x47C3890", Offset = "0x47C2C90", VA = "0x1847C3890")]
	public BFBHMGBJLHH(MEPJCGGHMDE<TNode, TReparentOperations> JKOBGLOJMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x4C96310", Offset = "0x4C95710", VA = "0x184C96310", Slot = "4")]
	public override bool NBMDPHCGIHP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class NFDDKHIJOIK<TNode, TReparentOperations> : GEKBENFILHF<MEPJCGGHMDE<TNode, TReparentOperations>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly CGFMPDPCOIJ<TNode, TReparentOperations> LGEPIKCDOLM;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5193B90", Offset = "0x5192F90", VA = "0x185193B90")]
	public NFDDKHIJOIK(TNode DBNLEGDLJHI, TReparentOperations OCIIMNCNPDO, DJBGOFIKOJN BCNCACFKAKF, MEPJCGGHMDE<TNode, TReparentOperations> JKOBGLOJMAJ, bool LJNKHBBIILP = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x437FF10", Offset = "0x437F310", VA = "0x18437FF10", Slot = "4")]
	public override bool NBMDPHCGIHP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class CGCAIEKLMIG<TNode, TReparentOperations> : GEKBENFILHF<MEPJCGGHMDE<TNode, TReparentOperations>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly NICLIICNOBF<TNode> NNFGPAHLGMN;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6473170", Offset = "0x6472570", VA = "0x186473170")]
	public CGCAIEKLMIG(TNode BJJHCECMDHO, MEPJCGGHMDE<TNode, TReparentOperations> JKOBGLOJMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x4380140", Offset = "0x437F540", VA = "0x184380140", Slot = "4")]
	public override bool NBMDPHCGIHP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct IENHJCCPNBG<TSpawnInfo> where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public TSpawnInfo NPHDAJCNDKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public Vector3 KBPOHLLNAIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public Quaternion PNEDBEMJDJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public float KPABPLHPKDL;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x4A4FD30", Offset = "0x4A4F130", VA = "0x184A4FD30")]
	public IENHJCCPNBG(TSpawnInfo NPHDAJCNDKA, Vector3 KBPOHLLNAIG, Quaternion PNEDBEMJDJJ, float KPABPLHPKDL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface GKDAKGDCKBP<TSpawnType, TSpawnInfo>
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> HEDFGHJDMHA([In] IENHJCCPNBG<TSpawnInfo> HFGJPCKBHIH, CancellationToken JDDHIJBJNHP);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class FGGMODIGDIN<TSpawnType, TSpawnInfo> : GKKKNENBILO<GKDAKGDCKBP<TSpawnType, TSpawnInfo>, TSpawnType> where TSpawnType : notnull where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly IENHJCCPNBG<TSpawnInfo> KBIBHMCLJNL;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x47D7FA0", Offset = "0x47D73A0", VA = "0x1847D7FA0")]
	public FGGMODIGDIN(TSpawnInfo POECIEKLMKA, Vector3 KBPOHLLNAIG, Quaternion PNEDBEMJDJJ, float KPABPLHPKDL, GKDAKGDCKBP<TSpawnType, TSpawnInfo> JKOBGLOJMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x47D7EC0", Offset = "0x47D72C0", VA = "0x1847D7EC0", Slot = "4")]
	public override Task<TSpawnType> NBMDPHCGIHP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public readonly struct POLBOLEHINC<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly IEnumerable<TData> MFEIEAGJALF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly bool LOCNMJLFKLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly bool HIENNLLCJMH;

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x54CB520", Offset = "0x54CA920", VA = "0x1854CB520")]
	public POLBOLEHINC(IEnumerable<TData> MKLPEMJHLAF, bool LJNKHBBIILP = false, bool PAENJKDMBBJ = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface AIJOHKOFONN<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<GEIHOCLKBBC> FBFMABHMEBB([In] POLBOLEHINC<TData> KLKBBBLAOOL, CancellationToken JDDHIJBJNHP);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class AAEBAEPNHMA<TData> : GKKKNENBILO<AIJOHKOFONN<TData>, GEIHOCLKBBC> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly POLBOLEHINC<TData> HAAABBMOOBG;

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x48674B0", Offset = "0x48668B0", VA = "0x1848674B0")]
	public AAEBAEPNHMA(IEnumerable<TData> MKLPEMJHLAF, bool LJNKHBBIILP, AIJOHKOFONN<TData> JKOBGLOJMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x47D7EC0", Offset = "0x47D72C0", VA = "0x1847D7EC0", Slot = "4")]
	public override Task<GEIHOCLKBBC> NBMDPHCGIHP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct BLEHCEINKPF<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly T EJCNBBIIFBE;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x4A4D230", Offset = "0x4A4C630", VA = "0x184A4D230")]
	public BLEHCEINKPF(T CCCAFEEMCEO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface FLCGGJNCIPI<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AFEBBMKCHIF([In] BLEHCEINKPF<T> ABFPPBLKOED);

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CAAHHEPMDDL();
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface OLCMGGGMEPK<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NBMDPHCGIHP([In] NJBEPIDDKMC<T> INECJKEOKGJ);
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public struct NJBEPIDDKMC<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly T EJCNBBIIFBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly bool OIMBHNLNIPO;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x521E5D0", Offset = "0x521D9D0", VA = "0x18521E5D0")]
	public NJBEPIDDKMC(T CCCAFEEMCEO, bool AEAPFGHECDF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public class DEOMDHJBKON<T> : GEKBENFILHF<FLCGGJNCIPI<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x47C3890", Offset = "0x47C2C90", VA = "0x1847C3890")]
	public DEOMDHJBKON(FLCGGJNCIPI<T> JKOBGLOJMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x688BFF0", Offset = "0x688B3F0", VA = "0x18688BFF0", Slot = "4")]
	public override bool NBMDPHCGIHP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class KLOOMPNJGAI<T> : GEKBENFILHF<FLCGGJNCIPI<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly BLEHCEINKPF<T> ABFPPBLKOED;

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x4E06AA0", Offset = "0x4E05EA0", VA = "0x184E06AA0")]
	public KLOOMPNJGAI(T EJCNBBIIFBE, FLCGGJNCIPI<T> JKOBGLOJMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x4380140", Offset = "0x437F540", VA = "0x184380140", Slot = "4")]
	public override bool NBMDPHCGIHP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class EBFJCHCKFAC<T> : GEKBENFILHF<OLCMGGGMEPK<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly NJBEPIDDKMC<T> INECJKEOKGJ;

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x4380200", Offset = "0x437F600", VA = "0x184380200")]
	public EBFJCHCKFAC(T EJCNBBIIFBE, bool AEAPFGHECDF, OLCMGGGMEPK<T> JKOBGLOJMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x4380140", Offset = "0x437F540", VA = "0x184380140", Slot = "4")]
	public override bool NBMDPHCGIHP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public struct NAJMEPKNJMD<TData> where TData : notnull, LNMMAIDPFEM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public IEnumerable<TData> MFEIEAGJALF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public bool NOFEFEMMAOB;

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5153220", Offset = "0x5152620", VA = "0x185153220")]
	public NAJMEPKNJMD(IEnumerable<TData> AHJKJCFPFKM, bool BMNHAEGMEJC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public struct PCLIPDAFGEE<TData> where TData : notnull, LNMMAIDPFEM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public List<TData> MFEIEAGJALF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public List<bool> GNJFNIGBEEN;

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x547E880", Offset = "0x547DC80", VA = "0x18547E880")]
	public PCLIPDAFGEE(List<TData> AHJKJCFPFKM, List<bool> ALHEPAKBGMC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface LNMMAIDPFEM
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool FABOCOMIFHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface KNEAADLJMPI<TData> where TData : LNMMAIDPFEM
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NBMDPHCGIHP([In] NAJMEPKNJMD<TData> HMMJNGJMNHH);

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NBMDPHCGIHP([In] PCLIPDAFGEE<TData> HMMJNGJMNHH);
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface OAOMMNDPOLB<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OFNBLOCDAOA(T EJCNBBIIFBE);
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class ACHBLEEANPC<TData> : GEKBENFILHF<KNEAADLJMPI<TData>> where TData : notnull, LNMMAIDPFEM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly NAJMEPKNJMD<TData> HMMJNGJMNHH;

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x48A48D0", Offset = "0x48A3CD0", VA = "0x1848A48D0")]
	public ACHBLEEANPC(List<TData> MKLPEMJHLAF, bool NOFEFEMMAOB, KNEAADLJMPI<TData> JKOBGLOJMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x4380140", Offset = "0x437F540", VA = "0x184380140", Slot = "4")]
	public override bool NBMDPHCGIHP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class LLLEPKJEBIB<TData> : GEKBENFILHF<KNEAADLJMPI<TData>> where TData : notnull, LNMMAIDPFEM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly PCLIPDAFGEE<TData> HMMJNGJMNHH;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x4ECCD90", Offset = "0x4ECC190", VA = "0x184ECCD90")]
	public LLLEPKJEBIB(List<TData> MKLPEMJHLAF, List<bool> GNJFNIGBEEN, KNEAADLJMPI<TData> JKOBGLOJMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x4ECCCD0", Offset = "0x4ECC0D0", VA = "0x184ECCCD0", Slot = "4")]
	public override bool NBMDPHCGIHP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public interface JLLCHCHFGOP<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<GEIHOCLKBBC> NBMDPHCGIHP(KNNJKABAHBP<TData> DINDOFKACOC);
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public class CJFGKMJKJLG<TData> : GKKKNENBILO<JLLCHCHFGOP<TData>, GEIHOCLKBBC> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private struct LIGJBBNNDFE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public AsyncTaskMethodBuilder<GEIHOCLKBBC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public CJFGKMJKJLG<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private TaskAwaiter<GEIHOCLKBBC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x4EB9EE0", Offset = "0x4EB92E0", VA = "0x184EB9EE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x4EBA1D0", Offset = "0x4EB95D0", VA = "0x184EBA1D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly KNNJKABAHBP<TData> JEEJBODJECE;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6578D50", Offset = "0x6578150", VA = "0x186578D50")]
	public CJFGKMJKJLG(TData OMJOGELBHGM, IReadOnlyList<TData> MNJEGDHFPMC, bool LJNKHBBIILP, JLLCHCHFGOP<TData> JKOBGLOJMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6578C50", Offset = "0x6578050", VA = "0x186578C50", Slot = "4")]
	[AsyncStateMachine(typeof(CJFGKMJKJLG<>.LIGJBBNNDFE))]
	public override Task<GEIHOCLKBBC> NBMDPHCGIHP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public struct KNNJKABAHBP<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public TData NMHIHGPPMLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public IReadOnlyList<TData> CJCCKBKCJDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public bool LOCNMJLFKLI;

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x4E15510", Offset = "0x4E14910", VA = "0x184E15510")]
	public KNNJKABAHBP(TData OMJOGELBHGM, IReadOnlyList<TData> MNJEGDHFPMC, bool LJNKHBBIILP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface FIBGEGAHDBJ<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NBMDPHCGIHP([In] MIFCHHFIFOK<TData> AAPDDNFBKPE);
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public interface MFFNOCKJMKF<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NBMDPHCGIHP([In] PPIOHOMICIM<TData> AAPDDNFBKPE);
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public interface BBAGMDEKGMP<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CLEKCGOPNLD([In] LMDNELDPLKH<TData> AAPDDNFBKPE);

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CAAHHEPMDDL();
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class LHFIOMCKPEF<TData> : GEKBENFILHF<FIBGEGAHDBJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly MIFCHHFIFOK<TData> AAPDDNFBKPE;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x4EB9C60", Offset = "0x4EB9060", VA = "0x184EB9C60")]
	public LHFIOMCKPEF(IEnumerable<TData> MKLPEMJHLAF, ADLIHGEBFFL JLFKDHGAEDA, MCPAODJHNLK FFHFAEDNMPG, float CGHLPACFJDK, string? FMJPEADOCOC, bool DKLAGCIBJBJ, bool LJNKHBBIILP, FIBGEGAHDBJ<TData> JKOBGLOJMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x4380140", Offset = "0x437F540", VA = "0x184380140", Slot = "4")]
	public override bool NBMDPHCGIHP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class PNLCBAFEOKI<TData> : GEKBENFILHF<MFFNOCKJMKF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly PPIOHOMICIM<TData> AAPDDNFBKPE;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x54C1DE0", Offset = "0x54C11E0", VA = "0x1854C1DE0")]
	public PNLCBAFEOKI(TData[] MKLPEMJHLAF, ADLIHGEBFFL[] JLFKDHGAEDA, MCPAODJHNLK[] FFHFAEDNMPG, float[] CGHLPACFJDK, MFFNOCKJMKF<TData> JKOBGLOJMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x4BCCD10", Offset = "0x4BCC110", VA = "0x184BCCD10", Slot = "4")]
	public override bool NBMDPHCGIHP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class CAMIEILBOLA<TData> : GEKBENFILHF<BBAGMDEKGMP<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x47C3890", Offset = "0x47C2C90", VA = "0x1847C3890")]
	public CAMIEILBOLA(BBAGMDEKGMP<TData> JKOBGLOJMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x637BEF0", Offset = "0x637B2F0", VA = "0x18637BEF0", Slot = "4")]
	public override bool NBMDPHCGIHP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class AKMNJMBCCOK<TData> : GEKBENFILHF<BBAGMDEKGMP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly LMDNELDPLKH<TData> AAPDDNFBKPE;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x4BCCDD0", Offset = "0x4BCC1D0", VA = "0x184BCCDD0")]
	public AKMNJMBCCOK(IEnumerable<TData> MKLPEMJHLAF, ADLIHGEBFFL JLFKDHGAEDA, MCPAODJHNLK FFHFAEDNMPG, float CGHLPACFJDK, BBAGMDEKGMP<TData> JKOBGLOJMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x4BCCD10", Offset = "0x4BCC110", VA = "0x184BCCD10", Slot = "4")]
	public override bool NBMDPHCGIHP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public struct MIFCHHFIFOK<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public IEnumerable<TData> MFEIEAGJALF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public ADLIHGEBFFL GCPEOPHCDFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public MCPAODJHNLK KGJJNNOKCEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public float KPHDBNLAJIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public string? AJINEAMGDGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public bool? CNLFIILHPIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public bool LOCNMJLFKLI;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x50C4930", Offset = "0x50C3D30", VA = "0x1850C4930")]
	public MIFCHHFIFOK(IEnumerable<TData> MKLPEMJHLAF, ADLIHGEBFFL JLFKDHGAEDA, MCPAODJHNLK FFHFAEDNMPG, float CGHLPACFJDK, string? FMJPEADOCOC, bool? DKLAGCIBJBJ, bool LJNKHBBIILP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public struct PPIOHOMICIM<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public TData[] MFEIEAGJALF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public ADLIHGEBFFL[] GCPEOPHCDFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public MCPAODJHNLK[] KGJJNNOKCEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public float[] CGHLPACFJDK;

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x54CE4C0", Offset = "0x54CD8C0", VA = "0x1854CE4C0")]
	public PPIOHOMICIM(TData[] MKLPEMJHLAF, ADLIHGEBFFL[] JLFKDHGAEDA, MCPAODJHNLK[] FFHFAEDNMPG, float[] CGHLPACFJDK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public struct LMDNELDPLKH<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public IEnumerable<TData> MFEIEAGJALF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public ADLIHGEBFFL GCPEOPHCDFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public MCPAODJHNLK KGJJNNOKCEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public float CGHLPACFJDK;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x4ECDD40", Offset = "0x4ECD140", VA = "0x184ECDD40")]
	public LMDNELDPLKH(IEnumerable<TData> MKLPEMJHLAF, ADLIHGEBFFL JLFKDHGAEDA, MCPAODJHNLK FFHFAEDNMPG, float CGHLPACFJDK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public interface IIFLNNIMBEE<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OLEDGCKMFML([In] MIKEJCOAOCO<TData> KLKBBBLAOOL);

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FADNCIJHMED([In] MIKEJCOAOCO<TData> KLKBBBLAOOL);

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IKLKFJOOHOB([In] bool DLBOODEKIDD);

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HGPHLFFELFD([In] MIKEJCOAOCO<TData> KLKBBBLAOOL);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LHPMBPCJPEI();

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool KDGCADGAJKA([In] TData LLDKPABHKPN);
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class KAEKKLOFPNA<TData> : GEKBENFILHF<IIFLNNIMBEE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly MIKEJCOAOCO<TData> KLKBBBLAOOL;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x4D724E0", Offset = "0x4D718E0", VA = "0x184D724E0")]
	public KAEKKLOFPNA(List<TData> IMPJLIJJJPO, IIFLNNIMBEE<TData> JKOBGLOJMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x4380140", Offset = "0x437F540", VA = "0x184380140", Slot = "4")]
	public override bool NBMDPHCGIHP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class DHFNDBLKFGP<TData> : GEKBENFILHF<IIFLNNIMBEE<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x47C3890", Offset = "0x47C2C90", VA = "0x1847C3890")]
	public DHFNDBLKFGP(IIFLNNIMBEE<TData> JKOBGLOJMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x68934C0", Offset = "0x68928C0", VA = "0x1868934C0", Slot = "4")]
	public override bool NBMDPHCGIHP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class DKPKHCJGMGI<TData> : GEKBENFILHF<IIFLNNIMBEE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly bool LJNKHBBIILP;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x68E1D30", Offset = "0x68E1130", VA = "0x1868E1D30")]
	public DKPKHCJGMGI(bool LJNKHBBIILP, IIFLNNIMBEE<TData> JKOBGLOJMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x68E1CD0", Offset = "0x68E10D0", VA = "0x1868E1CD0", Slot = "4")]
	public override bool NBMDPHCGIHP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class CLLJMBJCCGF<TData> : GEKBENFILHF<IIFLNNIMBEE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly MIKEJCOAOCO<TData> KLKBBBLAOOL;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6632430", Offset = "0x6631830", VA = "0x186632430")]
	public CLLJMBJCCGF(List<TData> IMPJLIJJJPO, bool LJNKHBBIILP, IIFLNNIMBEE<TData> JKOBGLOJMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x4ECCCD0", Offset = "0x4ECC0D0", VA = "0x184ECCCD0", Slot = "4")]
	public override bool NBMDPHCGIHP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class HLLGGMMPPDO<TData> : GEKBENFILHF<IIFLNNIMBEE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly TData LLDKPABHKPN;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x4966170", Offset = "0x4965570", VA = "0x184966170")]
	public HLLGGMMPPDO(TData LLDKPABHKPN, IIFLNNIMBEE<TData> JKOBGLOJMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x49660A0", Offset = "0x49654A0", VA = "0x1849660A0", Slot = "4")]
	public override bool NBMDPHCGIHP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class OFFPOEOLNMB<TData> : GEKBENFILHF<IIFLNNIMBEE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly MIKEJCOAOCO<TData> KLKBBBLAOOL;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x533CC10", Offset = "0x533C010", VA = "0x18533CC10")]
	public OFFPOEOLNMB(IEnumerable<TData> IMPJLIJJJPO, IIFLNNIMBEE<TData> JKOBGLOJMAJ, bool LJNKHBBIILP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x533CA90", Offset = "0x533BE90", VA = "0x18533CA90", Slot = "4")]
	public override bool NBMDPHCGIHP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public struct MIKEJCOAOCO<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public IEnumerable<TData> MFEIEAGJALF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public bool LJNKHBBIILP;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x50C6190", Offset = "0x50C5590", VA = "0x1850C6190")]
	public MIKEJCOAOCO(IEnumerable<TData> AHJKJCFPFKM, bool NCFHHEGMGKP = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public interface DNHPHJNAOCM
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<GEIHOCLKBBC> NBMDPHCGIHP(CJHFADCLPBG IIOLNMPEPCL);
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class IJPCLIEJPIL : GKKKNENBILO<DNHPHJNAOCM, GEIHOCLKBBC>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private struct IFOBKENLLNL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public AsyncTaskMethodBuilder<GEIHOCLKBBC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public IJPCLIEJPIL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private TaskAwaiter<GEIHOCLKBBC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x7B57730", Offset = "0x7B56B30", VA = "0x187B57730", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7B579B0", Offset = "0x7B56DB0", VA = "0x187B579B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly CJHFADCLPBG IOJDKANMDML;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x7B57B10", Offset = "0x7B56F10", VA = "0x187B57B10")]
	public IJPCLIEJPIL(bool LJNKHBBIILP, DNHPHJNAOCM JKOBGLOJMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x7B57A20", Offset = "0x7B56E20", VA = "0x187B57A20", Slot = "4")]
	[AsyncStateMachine(typeof(IFOBKENLLNL))]
	public override Task<GEIHOCLKBBC> NBMDPHCGIHP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public struct CJHFADCLPBG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public bool LOCNMJLFKLI;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x28EC7F0", Offset = "0x28EBBF0", VA = "0x1828EC7F0")]
	public CJHFADCLPBG(bool LJNKHBBIILP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public readonly struct PKPAFNDBIPH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public readonly bool JEFFBKIOIJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public readonly bool JCGFPLLBOAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public readonly bool KPABPLHPKDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public readonly bool LJNKHBBIILP;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5B0CED0", Offset = "0x5B0C2D0", VA = "0x185B0CED0")]
	public PKPAFNDBIPH(bool JEFFBKIOIJJ, bool JCGFPLLBOAO, bool KPABPLHPKDL, bool LJNKHBBIILP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7B586E0", Offset = "0x7B57AE0", VA = "0x187B586E0")]
	public PKPAFNDBIPH(bool JCGFPLLBOAO, bool LJNKHBBIILP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public interface BIEODEEDMFK
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CJKCOKJIBJA(PKPAFNDBIPH PJMJIOPNEBB);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PMDMAIINLLG(PKPAFNDBIPH PJMJIOPNEBB);
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class MJACEANFDEL : GEKBENFILHF<BIEODEEDMFK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly PKPAFNDBIPH PJMJIOPNEBB;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7B58290", Offset = "0x7B57690", VA = "0x187B58290")]
	public MJACEANFDEL(bool NIBJBBEPHBE, bool JCGFPLLBOAO, bool KPABPLHPKDL, bool LJNKHBBIILP, BIEODEEDMFK JKOBGLOJMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x7B58240", Offset = "0x7B57640", VA = "0x187B58240", Slot = "4")]
	public override bool NBMDPHCGIHP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public class PJCJKOKKOMH : GEKBENFILHF<BIEODEEDMFK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private readonly PKPAFNDBIPH PJMJIOPNEBB;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7B58660", Offset = "0x7B57A60", VA = "0x187B58660")]
	public PJCJKOKKOMH(bool JCGFPLLBOAO, bool LJNKHBBIILP, BIEODEEDMFK JKOBGLOJMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x7B58610", Offset = "0x7B57A10", VA = "0x187B58610", Slot = "4")]
	public override bool NBMDPHCGIHP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public interface JOHBFPMAIID
{
	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NBMDPHCGIHP([In] ANCOAFCHNHC FBENEOLDEIG);
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class IMDJNPHINPC : GEKBENFILHF<JOHBFPMAIID>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private readonly ANCOAFCHNHC FBENEOLDEIG;

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x7B57C20", Offset = "0x7B57020", VA = "0x187B57C20")]
	public IMDJNPHINPC(Guid[] MJFNPPBFAPI, Vector3[] PNDHPFCEJFN, Quaternion[] LMEIIKFBENM, float[] NCNHNJNIPKN, Dictionary<Guid, Vector3> LJPBCPFKPAB, JOHBFPMAIID JKOBGLOJMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7B57B70", Offset = "0x7B56F70", VA = "0x187B57B70", Slot = "4")]
	public override bool NBMDPHCGIHP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public interface KEPKENCFGBN<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AFEBBMKCHIF([In] NKOLNMHEBJP<TData> NNFGPAHLGMN);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CLEKCGOPNLD([In] EPIDPIHFGEL BIALCEKEJEJ);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CLEKCGOPNLD([In] OMPBDNJOEPL BIALCEKEJEJ);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CAAHHEPMDDL();
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class FIEBFFCICDK<TData> : GEKBENFILHF<KEPKENCFGBN<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x47C3890", Offset = "0x47C2C90", VA = "0x1847C3890")]
	public FIEBFFCICDK(KEPKENCFGBN<TData> JKOBGLOJMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x47DB6B0", Offset = "0x47DAAB0", VA = "0x1847DB6B0", Slot = "4")]
	public override bool NBMDPHCGIHP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class LNDMHCAMFOO<TData> : GEKBENFILHF<KEPKENCFGBN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly EPIDPIHFGEL OJJPCCMMFFL;

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x4ED39E0", Offset = "0x4ED2DE0", VA = "0x184ED39E0")]
	public LNDMHCAMFOO(Vector3 BBKHEJMMMCN, bool KLKPCOIMFEO, KEPKENCFGBN<TData> JKOBGLOJMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x439E240", Offset = "0x439D640", VA = "0x18439E240", Slot = "4")]
	public override bool NBMDPHCGIHP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class FLCJMDEDDBI<TData> : GEKBENFILHF<KEPKENCFGBN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly OMPBDNJOEPL OJJPCCMMFFL;

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x47E8FF0", Offset = "0x47E83F0", VA = "0x1847E8FF0")]
	public FLCJMDEDDBI(Guid OGAAGHNOFEN, int COPLIEINKOF, Vector3 KBPOHLLNAIG, Quaternion PNEDBEMJDJJ, float PPFBOIIFNHM, bool KLKPCOIMFEO, KEPKENCFGBN<TData> JKOBGLOJMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x47E8F90", Offset = "0x47E8390", VA = "0x1847E8F90", Slot = "4")]
	public override bool NBMDPHCGIHP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public class BFLGNPJNNJG<TData> : GEKBENFILHF<KEPKENCFGBN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly NKOLNMHEBJP<TData> OJJPCCMMFFL;

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5F904C0", Offset = "0x5F8F8C0", VA = "0x185F904C0")]
	public BFLGNPJNNJG(TData EJCNBBIIFBE, bool LJNKHBBIILP, KEPKENCFGBN<TData> JKOBGLOJMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x4380140", Offset = "0x437F540", VA = "0x184380140", Slot = "4")]
	public override bool NBMDPHCGIHP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct EPIDPIHFGEL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public readonly Vector3 BBKHEJMMMCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public readonly bool KLKPCOIMFEO;

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7B576D0", Offset = "0x7B56AD0", VA = "0x187B576D0")]
	public EPIDPIHFGEL(Vector3 BBKHEJMMMCN, bool KLKPCOIMFEO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct OMPBDNJOEPL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public readonly Guid OGAAGHNOFEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public readonly int COPLIEINKOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public readonly Vector3 KBPOHLLNAIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public readonly Quaternion PNEDBEMJDJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public readonly float PPFBOIIFNHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public readonly bool KLKPCOIMFEO;

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7B585D0", Offset = "0x7B579D0", VA = "0x187B585D0")]
	public OMPBDNJOEPL(Guid OGAAGHNOFEN, int COPLIEINKOF, Vector3 KBPOHLLNAIG, Quaternion PNEDBEMJDJJ, float PPFBOIIFNHM, bool KLKPCOIMFEO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct NKOLNMHEBJP<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public readonly TData EJCNBBIIFBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public readonly bool LJNKHBBIILP;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x5224390", Offset = "0x5223790", VA = "0x185224390")]
	public NKOLNMHEBJP(TData EJCNBBIIFBE, bool LJNKHBBIILP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public interface EJNKHGDDPCK<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NBMDPHCGIHP([In] OBNBCLNKOLJ<TData> ICPPGIKHBFM);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NBMDPHCGIHP([In] PHJIPGDEGFD<TData> ICPPGIKHBFM);
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public interface EHKDNDKJGME<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AFEBBMKCHIF([In] NPPGFNFLIPL<TData> KLCDGFPDKEN);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CLEKCGOPNLD([In] LGJDBEIFKEK BIALCEKEJEJ);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CAAHHEPMDDL();
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public class AGNIHAGKINB<TData> : GEKBENFILHF<EJNKHGDDPCK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly OBNBCLNKOLJ<TData> ICPPGIKHBFM;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x4BB8F10", Offset = "0x4BB8310", VA = "0x184BB8F10")]
	public AGNIHAGKINB(IEnumerable<TData> MKLPEMJHLAF, Vector3 HDLFKKIOHMP, bool LJNKHBBIILP, EJNKHGDDPCK<TData> JKOBGLOJMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x4380140", Offset = "0x437F540", VA = "0x184380140", Slot = "4")]
	public override bool NBMDPHCGIHP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class AMIDBCINPML<TData> : GEKBENFILHF<EHKDNDKJGME<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x47C3890", Offset = "0x47C2C90", VA = "0x1847C3890")]
	public AMIDBCINPML(EHKDNDKJGME<TData> JKOBGLOJMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x4C96310", Offset = "0x4C95710", VA = "0x184C96310", Slot = "4")]
	public override bool NBMDPHCGIHP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public class FLDPDIJEHGL<TData> : GEKBENFILHF<EHKDNDKJGME<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly NPPGFNFLIPL<TData> ICPPGIKHBFM;

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x47E9130", Offset = "0x47E8530", VA = "0x1847E9130")]
	public FLDPDIJEHGL(IEnumerable<TData> MKLPEMJHLAF, bool LJNKHBBIILP, EHKDNDKJGME<TData> JKOBGLOJMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x4380140", Offset = "0x437F540", VA = "0x184380140", Slot = "4")]
	public override bool NBMDPHCGIHP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public class PCFNNHPGIHL<TData> : GEKBENFILHF<EJNKHGDDPCK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly PHJIPGDEGFD<TData> ICPPGIKHBFM;

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x547A4A0", Offset = "0x54798A0", VA = "0x18547A4A0")]
	public PCFNNHPGIHL(IEnumerable<TData> MKLPEMJHLAF, Vector3 CJDLEDDMLFF, BLJAOIGGFIH MJFDPPFOEOO, bool LJNKHBBIILP, EJNKHGDDPCK<TData> JKOBGLOJMAJ, Space PJBDGDDPBAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x437FF10", Offset = "0x437F310", VA = "0x18437FF10", Slot = "4")]
	public override bool NBMDPHCGIHP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class BKCNIAAKPEO<TData> : GEKBENFILHF<EHKDNDKJGME<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly LGJDBEIFKEK ICPPGIKHBFM;

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6077300", Offset = "0x6076700", VA = "0x186077300")]
	public BKCNIAAKPEO(Vector3 HDLFKKIOHMP, EHKDNDKJGME<TData> JKOBGLOJMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x439E240", Offset = "0x439D640", VA = "0x18439E240", Slot = "4")]
	public override bool NBMDPHCGIHP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public struct OBNBCLNKOLJ<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public readonly IEnumerable<TData> MKLPEMJHLAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public readonly Vector3 HDLFKKIOHMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly bool LJNKHBBIILP;

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x53303E0", Offset = "0x532F7E0", VA = "0x1853303E0")]
	public OBNBCLNKOLJ(IEnumerable<TData> MKLPEMJHLAF, Vector3 HDLFKKIOHMP, bool LJNKHBBIILP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct NPPGFNFLIPL<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public readonly IEnumerable<TData> MKLPEMJHLAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public readonly bool LJNKHBBIILP;

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x52321C0", Offset = "0x52315C0", VA = "0x1852321C0")]
	public NPPGFNFLIPL(IEnumerable<TData> MKLPEMJHLAF, bool LJNKHBBIILP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public struct PHJIPGDEGFD<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public readonly IEnumerable<TData> MKLPEMJHLAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public readonly Vector3 CJDLEDDMLFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public readonly BLJAOIGGFIH MJFDPPFOEOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public readonly bool LJNKHBBIILP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public readonly Space PJBDGDDPBAM;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x54A4640", Offset = "0x54A3A40", VA = "0x1854A4640")]
	public PHJIPGDEGFD(IEnumerable<TData> MKLPEMJHLAF, Vector3 CJDLEDDMLFF, BLJAOIGGFIH MJFDPPFOEOO, bool LJNKHBBIILP, Space PJBDGDDPBAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public struct LGJDBEIFKEK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public readonly Vector3 HDLFKKIOHMP;

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0xE8CFE0", Offset = "0xE8C3E0", VA = "0x180E8CFE0")]
	public LGJDBEIFKEK(Vector3 HDLFKKIOHMP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public enum BLJAOIGGFIH
{
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	XYZ,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	X_only,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	Y_only,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	Z_only
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public interface JDKNFCHMFNG
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NBMDPHCGIHP([In] BJAOHNAEKCL JAJMHCFNIKD);
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public class KBKLHEJGFDM : GEKBENFILHF<JDKNFCHMFNG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly BJAOHNAEKCL JAJMHCFNIKD;

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x7B57EB0", Offset = "0x7B572B0", VA = "0x187B57EB0")]
	public KBKLHEJGFDM(bool LJNKHBBIILP, JDKNFCHMFNG JKOBGLOJMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x7B57E00", Offset = "0x7B57200", VA = "0x187B57E00", Slot = "4")]
	public override bool NBMDPHCGIHP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public readonly struct BJAOHNAEKCL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public readonly bool LJNKHBBIILP;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x28EC7F0", Offset = "0x28EBBF0", VA = "0x1828EC7F0")]
	public BJAOHNAEKCL(bool LJNKHBBIILP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public interface AEINOJAMOPM<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NBMDPHCGIHP([In] HFLODMPNMKF<TData> DOPDCPPFJII);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NBMDPHCGIHP([In] NJHCKEONIJO<TData> DOPDCPPFJII);
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public interface JDOHGNCHKCG<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AFEBBMKCHIF([In] IFIONMDJMJD<TData> NNFGPAHLGMN);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CLEKCGOPNLD([In] NMBHDFMOGMI BIALCEKEJEJ);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CAAHHEPMDDL();
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public class BCJLCKCFLED<TData> : GEKBENFILHF<AEINOJAMOPM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly HFLODMPNMKF<TData> DOPDCPPFJII;

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x5E9C860", Offset = "0x5E9BC60", VA = "0x185E9C860")]
	public BCJLCKCFLED(IEnumerable<TData> MKLPEMJHLAF, Quaternion HDLFKKIOHMP, Vector3? MPFKHNODENM, bool EMPHKIDLCCM, bool LJNKHBBIILP, AEINOJAMOPM<TData> JKOBGLOJMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x4380140", Offset = "0x437F540", VA = "0x184380140", Slot = "4")]
	public override bool NBMDPHCGIHP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class OCGCKPNJHHA<TData> : GEKBENFILHF<JDOHGNCHKCG<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x47C3890", Offset = "0x47C2C90", VA = "0x1847C3890")]
	public OCGCKPNJHHA(JDOHGNCHKCG<TData> JKOBGLOJMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x4C96310", Offset = "0x4C95710", VA = "0x184C96310", Slot = "4")]
	public override bool NBMDPHCGIHP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class KKFDBGCNDNB<TData> : GEKBENFILHF<JDOHGNCHKCG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly IFIONMDJMJD<TData> DOPDCPPFJII;

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x4E01B90", Offset = "0x4E00F90", VA = "0x184E01B90")]
	public KKFDBGCNDNB(IEnumerable<TData> MKLPEMJHLAF, bool LJNKHBBIILP, JDOHGNCHKCG<TData> JKOBGLOJMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x4380140", Offset = "0x437F540", VA = "0x184380140", Slot = "4")]
	public override bool NBMDPHCGIHP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class EBEIGAJCHNN<TData> : GEKBENFILHF<AEINOJAMOPM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly NJHCKEONIJO<TData> DOPDCPPFJII;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x437FFE0", Offset = "0x437F3E0", VA = "0x18437FFE0")]
	public EBEIGAJCHNN(IEnumerable<TData> MKLPEMJHLAF, Quaternion BDNPFELCEHA, BLJAOIGGFIH JILDFFOKNLB, Vector3? MPFKHNODENM, bool EMPHKIDLCCM, bool LJNKHBBIILP, Space PJBDGDDPBAM, AEINOJAMOPM<TData> JKOBGLOJMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x437FF10", Offset = "0x437F310", VA = "0x18437FF10", Slot = "4")]
	public override bool NBMDPHCGIHP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public class EIDDBMAEONN<TData> : GEKBENFILHF<JDOHGNCHKCG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private readonly NMBHDFMOGMI DOPDCPPFJII;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x439E2A0", Offset = "0x439D6A0", VA = "0x18439E2A0")]
	public EIDDBMAEONN(Quaternion HDLFKKIOHMP, Vector3? MPFKHNODENM, bool EMPHKIDLCCM, JDOHGNCHKCG<TData> JKOBGLOJMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x439E240", Offset = "0x439D640", VA = "0x18439E240", Slot = "4")]
	public override bool NBMDPHCGIHP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public struct HFLODMPNMKF<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public readonly IEnumerable<TData> MKLPEMJHLAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public readonly Quaternion HDLFKKIOHMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public readonly Vector3? MPFKHNODENM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public readonly bool EMPHKIDLCCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public readonly bool LJNKHBBIILP;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x4920370", Offset = "0x491F770", VA = "0x184920370")]
	public HFLODMPNMKF(IEnumerable<TData> MKLPEMJHLAF, Quaternion HDLFKKIOHMP, Vector3? MPFKHNODENM, bool EMPHKIDLCCM, bool LJNKHBBIILP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct IFIONMDJMJD<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public readonly IEnumerable<TData> MKLPEMJHLAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public readonly bool LJNKHBBIILP;

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x4A529C0", Offset = "0x4A51DC0", VA = "0x184A529C0")]
	public IFIONMDJMJD(IEnumerable<TData> MKLPEMJHLAF, bool LJNKHBBIILP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public struct NJHCKEONIJO<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public readonly IEnumerable<TData> MKLPEMJHLAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public readonly Quaternion BDNPFELCEHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public readonly BLJAOIGGFIH JILDFFOKNLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public readonly Vector3? MPFKHNODENM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public readonly bool EMPHKIDLCCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public readonly bool LJNKHBBIILP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public readonly Space PJBDGDDPBAM;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x5222050", Offset = "0x5221450", VA = "0x185222050")]
	public NJHCKEONIJO(IEnumerable<TData> MKLPEMJHLAF, Quaternion BDNPFELCEHA, BLJAOIGGFIH JILDFFOKNLB, Vector3? MPFKHNODENM, bool EMPHKIDLCCM, bool LJNKHBBIILP, Space PJBDGDDPBAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct NMBHDFMOGMI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly Quaternion HDLFKKIOHMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public readonly Vector3? MPFKHNODENM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly bool EMPHKIDLCCM;

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x5AD1780", Offset = "0x5AD0B80", VA = "0x185AD1780")]
	public NMBHDFMOGMI(Quaternion HDLFKKIOHMP, Vector3? MPFKHNODENM, bool EMPHKIDLCCM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public interface AAOLCDNEEBH<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AFEBBMKCHIF([In] EMLJGFGFFFF<TData> NNFGPAHLGMN);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CLEKCGOPNLD([In] FBOFGDMLFBJ BIALCEKEJEJ);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CLEKCGOPNLD([In] DFAKIFKBOCD BIALCEKEJEJ);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CLEKCGOPNLD([In] APLPBELONPK BIALCEKEJEJ);

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool CAAHHEPMDDL();
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public class BILHLPGOFKE<TData> : GEKBENFILHF<AAOLCDNEEBH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private readonly APLPBELONPK FBGCJPJMPJJ;

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x60764B0", Offset = "0x60758B0", VA = "0x1860764B0")]
	public BILHLPGOFKE(Vector3 KCBDFNDFLGB, float BIPFCDNOGAF, Vector3 MPFKHNODENM, bool EJIIJCNGENH, bool FAPGIGGPPMA, AAOLCDNEEBH<TData> JKOBGLOJMAJ, Space PJBDGDDPBAM = Space.Self)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6076450", Offset = "0x6075850", VA = "0x186076450", Slot = "4")]
	public override bool NBMDPHCGIHP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public class HBKAGDJPNGA<TData> : GEKBENFILHF<AAOLCDNEEBH<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x47C3890", Offset = "0x47C2C90", VA = "0x1847C3890")]
	public HBKAGDJPNGA(AAOLCDNEEBH<TData> JKOBGLOJMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x490DB60", Offset = "0x490CF60", VA = "0x18490DB60", Slot = "4")]
	public override bool NBMDPHCGIHP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public class MLPDOJMENCP<TData> : GEKBENFILHF<AAOLCDNEEBH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private readonly EMLJGFGFFFF<TData> FBGCJPJMPJJ;

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x50DF040", Offset = "0x50DE440", VA = "0x1850DF040")]
	public MLPDOJMENCP(IEnumerable<TData> MKLPEMJHLAF, bool LJNKHBBIILP, AAOLCDNEEBH<TData> JKOBGLOJMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x4380140", Offset = "0x437F540", VA = "0x184380140", Slot = "4")]
	public override bool NBMDPHCGIHP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public class AACCPAJHGAB<TData> : GEKBENFILHF<AAOLCDNEEBH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private readonly DFAKIFKBOCD FBGCJPJMPJJ;

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x4867320", Offset = "0x4866720", VA = "0x184867320")]
	public AACCPAJHGAB(float CHLKPDFELIN, bool BPDNACBBCKH, Vector3 MPFKHNODENM, AAOLCDNEEBH<TData> JKOBGLOJMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x4867250", Offset = "0x4866650", VA = "0x184867250", Slot = "4")]
	public override bool NBMDPHCGIHP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public class COCKPEKOHHB<TData> : GEKBENFILHF<AAOLCDNEEBH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private readonly FBOFGDMLFBJ FBGCJPJMPJJ;

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x66340E0", Offset = "0x66334E0", VA = "0x1866340E0")]
	public COCKPEKOHHB(float BIPFCDNOGAF, Vector3 MPFKHNODENM, AAOLCDNEEBH<TData> JKOBGLOJMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x439E240", Offset = "0x439D640", VA = "0x18439E240", Slot = "4")]
	public override bool NBMDPHCGIHP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public struct APLPBELONPK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public readonly Vector3 KCBDFNDFLGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public readonly float BIPFCDNOGAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public readonly Vector3 MPFKHNODENM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public readonly bool KLKPCOIMFEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public readonly Space PJBDGDDPBAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public readonly bool FAPGIGGPPMA;

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x7B56C70", Offset = "0x7B56070", VA = "0x187B56C70")]
	public APLPBELONPK(Vector3 KCBDFNDFLGB, float BIPFCDNOGAF, Vector3 MPFKHNODENM, bool KLKPCOIMFEO, bool FDDAMAAPKID, Space PJBDGDDPBAM = Space.Self)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public struct EMLJGFGFFFF<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public readonly IEnumerable<TData> MKLPEMJHLAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public readonly bool LJNKHBBIILP;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x43AF1C0", Offset = "0x43AE5C0", VA = "0x1843AF1C0")]
	public EMLJGFGFFFF(IEnumerable<TData> MKLPEMJHLAF, bool LJNKHBBIILP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public struct DFAKIFKBOCD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public readonly float CHLKPDFELIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public readonly bool BPDNACBBCKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public readonly Vector3 MPFKHNODENM;

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x7B56FC0", Offset = "0x7B563C0", VA = "0x187B56FC0")]
	public DFAKIFKBOCD(float CHLKPDFELIN, bool BPDNACBBCKH, Vector3 MPFKHNODENM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public struct FBOFGDMLFBJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public readonly float BIPFCDNOGAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public readonly Vector3 MPFKHNODENM;

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x5A8A990", Offset = "0x5A89D90", VA = "0x185A8A990")]
	public FBOFGDMLFBJ(float BIPFCDNOGAF, Vector3 MPFKHNODENM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public struct ANCOAFCHNHC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public readonly Guid[] MKLPEMJHLAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public readonly bool CFMJAPHHMLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public readonly bool COLGACAJGHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public readonly bool IBOIOLICPBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public readonly Vector3[] PNDHPFCEJFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public readonly Quaternion[] LMEIIKFBENM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public readonly float[] NCNHNJNIPKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public readonly Dictionary<Guid, Vector3> LJPBCPFKPAB;

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x7B569E0", Offset = "0x7B55DE0", VA = "0x187B569E0")]
	public ANCOAFCHNHC(Guid[] MJFNPPBFAPI, Vector3[] PNDHPFCEJFN, Quaternion[] LMEIIKFBENM, float[] NCNHNJNIPKN, Dictionary<Guid, Vector3> LJPBCPFKPAB, bool CFMJAPHHMLD = true, bool COLGACAJGHM = true, bool IBOIOLICPBP = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7B56810", Offset = "0x7B55C10", VA = "0x187B56810")]
	private static void HGENFCDDGLL(Dictionary<Guid, Vector3> LJPBCPFKPAB, int LNEIOACKPJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public static class EMINECGNDPM
{
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	private struct CFKMPBMAIBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public bool EGJPGEKFIPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public NPCGGDCACLM PGDHIHIMLOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public NPCGGDCACLM BBEJDECINNO;
	}

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static CFKMPBMAIBA FADAAMEAAJE;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static CancellationToken BJEHHDHHFKA
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x7B572F0", Offset = "0x7B566F0", VA = "0x187B572F0")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	internal static NPCGGDCACLM PGDHIHIMLOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x7B57380", Offset = "0x7B56780", VA = "0x187B57380")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x7B57310", Offset = "0x7B56710", VA = "0x187B57310")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x7B57580", Offset = "0x7B56980", VA = "0x187B57580")]
	[ACPGCKDGGJH.OGKIIIOLJPE]
	internal static void JFPDPLCMAPE(NPCGGDCACLM OOENCJIOEIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x7B57420", Offset = "0x7B56820", VA = "0x187B57420")]
	public static void ICMDEPLACPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x7B57680", Offset = "0x7B56A80", VA = "0x187B57680")]
	private static NPCGGDCACLM JJCNKBOHFNN(NPCGGDCACLM GBALDODBKFK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public static class PNKKFLAOEKJ
{
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	public enum PLNLLPCFCOA
	{
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		ICreationContextObject,
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		Guid
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x38C4F90", Offset = "0x38C4390", VA = "0x1838C4F90")]
	public static void CMMMFHJAKEI<T>(T KBMKBMHFKMO, PLNLLPCFCOA KHNCICOHHHJ) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x38C5100", Offset = "0x38C4500", VA = "0x1838C5100")]
	public static void CMMMFHJAKEI<T>(T KBMKBMHFKMO) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x38C4EE0", Offset = "0x38C42E0", VA = "0x1838C4EE0")]
	public static void AKLBKPBBLGC<T>(T KBMKBMHFKMO) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x38C5170", Offset = "0x38C4570", VA = "0x1838C5170")]
	public static T DANLDNLMJMK<T>(PLNLLPCFCOA KHNCICOHHHJ) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x38C4CD0", Offset = "0x38C40D0", VA = "0x1838C4CD0")]
	public static bool ACKDGLPEIGD<T>(PLNLLPCFCOA KHNCICOHHHJ, T? FPLDGBFCBEL, [Out][NotNullWhen(true)][MaybeNullWhen(false)] T JMFILIBLKIC) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x38C5330", Offset = "0x38C4730", VA = "0x1838C5330")]
	public static bool OKBJBDLBOGO<T>(PLNLLPCFCOA KHNCICOHHHJ, [Out][MaybeNullWhen(false)][NotNullWhen(true)] T KOINCEHAMDA) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x38C5280", Offset = "0x38C4680", VA = "0x1838C5280")]
	public static bool HMFCICIKCLE<T>(PLNLLPCFCOA KHNCICOHHHJ) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x38C5220", Offset = "0x38C4620", VA = "0x1838C5220")]
	public static T DANLDNLMJMK<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x38C4E20", Offset = "0x38C4220", VA = "0x1838C4E20")]
	public static bool ACKDGLPEIGD<T>(T FPLDGBFCBEL, [Out] T JMFILIBLKIC) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x38C5220", Offset = "0x38C4620", VA = "0x1838C5220")]
	public static bool HMFCICIKCLE<T>() where T : class
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
internal static class MNCFMNCGMME
{
	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x7B58320", Offset = "0x7B57720", VA = "0x187B58320")]
	public static void LDBAKCOJBAD(IEnumerable FGLJHGEFKGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x37C8810", Offset = "0x37C7C10", VA = "0x1837C8810")]
	public static void LDBAKCOJBAD<T>(T[] IMLJIFPAFGH) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x37C89F0", Offset = "0x37C7DF0", VA = "0x1837C89F0")]
	public static void LDBAKCOJBAD<T>(T AGBLNABJHCB) where T : notnull, Enum
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
