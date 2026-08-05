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
		[Cpp2IlInjected.Address(RVA = "0x78D520", Offset = "0x78C920", VA = "0x18078D520")]
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
		[Cpp2IlInjected.Address(RVA = "0x5CFCF00", Offset = "0x5CFC300", VA = "0x185CFCF00")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x78E300", Offset = "0x78D700", VA = "0x18078E300")]
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
		[Cpp2IlInjected.Address(RVA = "0x78E340", Offset = "0x78D740", VA = "0x18078E340")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface GIAJDHECEPO<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ClearHoverTarget(KGJAOIKPCGJ LEGGCOMJCKC);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool SetHoverTarget(TData ADOGMMPMLJB, Collider IMLHKMGLMMO, KGJAOIKPCGJ LEGGCOMJCKC, [Optional] HKEOIHFAMCC? FDPJJNKKBHO);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool TryGetHoverTarget([Out] TData ADOGMMPMLJB);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface FHNLLFPECDD<TData> : GBNFANIHHBA, JDHPMBDDOCP<TData>, LILDJFMIGLE<TData>, ANJKLLGCACL<TData>, NCBKJJFGHKJ, JIJAJMIIFIC<TData>, CEDKBKBHHEM, HJOPLIANKAL
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface JIJAJMIIFIC<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 PKOLMJEBDFI, Vector3 DDLNIHBIJPM, float FECAAKMJJAF, [Out] T CKNJKEIFHDJ, [Out] Vector3 ILKIFDEHAOL, [Out] Collider IMLHKMGLMMO);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 PKOLMJEBDFI, Vector3 DDLNIHBIJPM, float OOBBLBBDBOL, float FECAAKMJJAF, T[] HHOAFEGNDLI, [Out] Vector3 GCHOEGMINPN, [Out] Collider OLBHFABDLKD);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 PKOLMJEBDFI, float OOBBLBBDBOL, Vector3 FPOCHCLGFOD, T[] HHOAFEGNDLI);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface GBNFANIHHBA
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Bounds HBHLPLPNCCP
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Transform MNHBIFOLCBK
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Bounds JJNAJFCHDOO
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Transform OJICDGADNAP
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Vector3 NNFAFABOLHF
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void SetSelectionBoundsDirty(bool DJDEHDAEIKM = true, int FPNEBHOHILL = 0);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ShouldHideSelectionBoundsPreview(bool LIIPLBIOGNP, object IBLOMPOENGH);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface HJOPLIANKAL
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	HJKDHGFMLBJ GMGFCLJJDHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface ANJKLLGCACL<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool JLEFKDGPLJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	int ILIBFCODLMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	IEnumerable<TData> IGOEKKMGIBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData IBHHDIJNMFI);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData IBHHDIJNMFI);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface JDHPMBDDOCP<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T IBBNLILJNEB, [Optional] HKEOIHFAMCC? FJGJCFHIBJI, bool BOJLONGINFG = true);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int CHEGLPEPHED, IEnumerable<T> APJOAJFDEAI, bool BOJLONGINFG = true);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int CHEGLPEPHED, IEnumerable<T> APJOAJFDEAI, HKEOIHFAMCC FJGJCFHIBJI, bool BOJLONGINFG = true);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface CEDKBKBHHEM
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface NCBKJJFGHKJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool JBFOJKFBCHM
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool KKMJKHJPOLA
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool LDAFGGCNBOP
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool HGEJLOIOPPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class DLPMIOAMOGF<TReceiver> : FFHOGLAGJCD<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x30267D0", Offset = "0x3025BD0", VA = "0x1830267D0")]
	public DLPMIOAMOGF(TReceiver EIDGHHFIPHF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public abstract class PKHHLPMIFOD<TReceiver, TFromTask> : FFHOGLAGJCD<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x30267D0", Offset = "0x3025BD0", VA = "0x1830267D0")]
	public PKHHLPMIFOD(TReceiver EIDGHHFIPHF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class FFHOGLAGJCD<TReceiver, TFromExecute> where TReceiver : notnull where TFromExecute : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	protected TReceiver EIDGHHFIPHF;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x339CFA0", Offset = "0x339C3A0", VA = "0x18339CFA0")]
	public FFHOGLAGJCD(TReceiver EIDGHHFIPHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute HPOJNLGPELL();
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct AHLGNEBNJOA<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public TNode MECECPHOMIA;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x34C58E0", Offset = "0x34C4CE0", VA = "0x1834C58E0")]
	public AHLGNEBNJOA(TNode MECECPHOMIA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct FOPPDKCAMPL<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public TNode KAIKMEAHJJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public CIANDJGBIHC EOPGDGEBKFL;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x33C79E0", Offset = "0x33C6DE0", VA = "0x1833C79E0")]
	public FOPPDKCAMPL(TNode KAIKMEAHJJB, CIANDJGBIHC EOPGDGEBKFL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface FKLDBLDHHEG<TNode>
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FCLOODLBPGH([In] AHLGNEBNJOA<TNode> JIEJFJFPLBO);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HACKHCHBIHD([In] FOPPDKCAMPL<TNode> LGOCFOICOGK);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DCDEPILGOEC();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class FFLAPMEKJOI<TNode> : DLPMIOAMOGF<FKLDBLDHHEG<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x30267D0", Offset = "0x3025BD0", VA = "0x1830267D0")]
	public FFLAPMEKJOI(FKLDBLDHHEG<TNode> EIDGHHFIPHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x339D120", Offset = "0x339C520", VA = "0x18339D120", Slot = "4")]
	public override bool HPOJNLGPELL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class MOPIOANNFMF<TNode> : DLPMIOAMOGF<FKLDBLDHHEG<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly FOPPDKCAMPL<TNode> LGOCFOICOGK;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3B8EB00", Offset = "0x3B8DF00", VA = "0x183B8EB00")]
	public MOPIOANNFMF(TNode KAIKMEAHJJB, CIANDJGBIHC EOPGDGEBKFL, FKLDBLDHHEG<TNode> EIDGHHFIPHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x37A1540", Offset = "0x37A0940", VA = "0x1837A1540", Slot = "4")]
	public override bool HPOJNLGPELL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class DGIEBJMCNFN<TNode> : DLPMIOAMOGF<FKLDBLDHHEG<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly AHLGNEBNJOA<TNode> JIEJFJFPLBO;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4CF2880", Offset = "0x4CF1C80", VA = "0x184CF2880")]
	public DGIEBJMCNFN(TNode CKMMKCCNBGB, FKLDBLDHHEG<TNode> EIDGHHFIPHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x351E9E0", Offset = "0x351DDE0", VA = "0x18351E9E0", Slot = "4")]
	public override bool HPOJNLGPELL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct MOFPBGGDILG<TSpawnInfo> where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public TSpawnInfo NIJIEKDKBBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public Vector3 BAONBICGOEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public Quaternion CKFJFCLIANA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public float IJMHENINMDB;

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0xD15AA0", Offset = "0xD14EA0", VA = "0x180D15AA0")]
	public MOFPBGGDILG(TSpawnInfo NIJIEKDKBBM, Vector3 BAONBICGOEJ, Quaternion CKFJFCLIANA, float IJMHENINMDB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface DBMICMPPICE<TSpawnType, TSpawnInfo>
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> GPEKMGKENBF([In] MOFPBGGDILG<TSpawnInfo> DFMDLPBONHM, CancellationToken OMFABMCIOAC);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class KIOBHAMLGHI<TSpawnType, TSpawnInfo> : PKHHLPMIFOD<DBMICMPPICE<TSpawnType, TSpawnInfo>, TSpawnType> where TSpawnType : notnull where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly MOFPBGGDILG<TSpawnInfo> LHPGBFGMEDK;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3801A90", Offset = "0x3800E90", VA = "0x183801A90")]
	public KIOBHAMLGHI(TSpawnInfo LDOCEOCBMFF, Vector3 BAONBICGOEJ, Quaternion CKFJFCLIANA, float IJMHENINMDB, DBMICMPPICE<TSpawnType, TSpawnInfo> EIDGHHFIPHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x30481A0", Offset = "0x30475A0", VA = "0x1830481A0", Slot = "4")]
	public override Task<TSpawnType> HPOJNLGPELL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public readonly struct CJHLBJCADLJ<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly IEnumerable<TData> MLAPJOGBINK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public readonly bool BDONFLMKLKO;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x4A8A340", Offset = "0x4A89740", VA = "0x184A8A340")]
	public CJHLBJCADLJ(IEnumerable<TData> PLPOAJFHFMP, bool HOCKBKPBHJF = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface CIEEJCICBDP<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<MCJOGGHNNPF> LPFLIJODAIL([In] CJHLBJCADLJ<TData> CIKHFBIIOEN, CancellationToken OMFABMCIOAC);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class EPMHMAPECHP<TData> : PKHHLPMIFOD<CIEEJCICBDP<TData>, MCJOGGHNNPF> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly CJHLBJCADLJ<TData> CJBCMEBGCFN;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3048310", Offset = "0x3047710", VA = "0x183048310")]
	public EPMHMAPECHP(IEnumerable<TData> PLPOAJFHFMP, bool HOCKBKPBHJF, CIEEJCICBDP<TData> EIDGHHFIPHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x30481A0", Offset = "0x30475A0", VA = "0x1830481A0", Slot = "4")]
	public override Task<MCJOGGHNNPF> HPOJNLGPELL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct BHIPJHBDKIA<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly T ADOGMMPMLJB;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4269630", Offset = "0x4268A30", VA = "0x184269630")]
	public BHIPJHBDKIA(T CHNIDFNAGMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface BNOAEGGFAFN<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FCLOODLBPGH([In] BHIPJHBDKIA<T> PKPBNJBFAAC);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HACKHCHBIHD();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface LPEALCAMAJE<T>
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HPOJNLGPELL([In] NKMFNGHBDAC<T> DLHPOMKDFLF);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct NKMFNGHBDAC<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly T ADOGMMPMLJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly bool ABCLECADIJC;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3BE3D90", Offset = "0x3BE3190", VA = "0x183BE3D90")]
	public NKMFNGHBDAC(T CHNIDFNAGMO, bool OEMLEHIMLLI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class KJMAKIJMOBN<T> : DLPMIOAMOGF<BNOAEGGFAFN<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x30267D0", Offset = "0x3025BD0", VA = "0x1830267D0")]
	public KJMAKIJMOBN(BNOAEGGFAFN<T> EIDGHHFIPHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x38022D0", Offset = "0x38016D0", VA = "0x1838022D0", Slot = "4")]
	public override bool HPOJNLGPELL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class HJADGAHNGDA<T> : DLPMIOAMOGF<BNOAEGGFAFN<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly BHIPJHBDKIA<T> PKPBNJBFAAC;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x351EB10", Offset = "0x351DF10", VA = "0x18351EB10")]
	public HJADGAHNGDA(T ADOGMMPMLJB, BNOAEGGFAFN<T> EIDGHHFIPHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x351E9E0", Offset = "0x351DDE0", VA = "0x18351E9E0", Slot = "4")]
	public override bool HPOJNLGPELL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class BAFDCEGEMJP<T> : DLPMIOAMOGF<LPEALCAMAJE<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly NKMFNGHBDAC<T> DLHPOMKDFLF;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x447D0D0", Offset = "0x447C4D0", VA = "0x18447D0D0")]
	public BAFDCEGEMJP(T ADOGMMPMLJB, bool OEMLEHIMLLI, LPEALCAMAJE<T> EIDGHHFIPHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x351E9E0", Offset = "0x351DDE0", VA = "0x18351E9E0", Slot = "4")]
	public override bool HPOJNLGPELL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct KLGGAKNKAEC<TData> where TData : notnull, FALCANCKDII
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public IEnumerable<TData> MLAPJOGBINK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public bool FILDDNLJIJD;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x38294B0", Offset = "0x38288B0", VA = "0x1838294B0")]
	public KLGGAKNKAEC(IEnumerable<TData> CEAKAFIFLJN, bool BEOFKCNAANL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct FKAOIDONKHB<TData> where TData : notnull, FALCANCKDII
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public List<TData> MLAPJOGBINK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public List<bool> GCPMEADOANB;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x33BED00", Offset = "0x33BE100", VA = "0x1833BED00")]
	public FKAOIDONKHB(List<TData> CEAKAFIFLJN, List<bool> GGAAIPDDAHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface FALCANCKDII
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool OEOKMEMMJLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface GKCJJMNCBDN<TData> where TData : FALCANCKDII
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HPOJNLGPELL([In] KLGGAKNKAEC<TData> CLBCCHCHGBC);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HPOJNLGPELL([In] FKAOIDONKHB<TData> CLBCCHCHGBC);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class LBOAFOOGIDK<TData> : DLPMIOAMOGF<GKCJJMNCBDN<TData>> where TData : notnull, FALCANCKDII
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly KLGGAKNKAEC<TData> CLBCCHCHGBC;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x38BF0D0", Offset = "0x38BE4D0", VA = "0x1838BF0D0")]
	public LBOAFOOGIDK(List<TData> PLPOAJFHFMP, bool FILDDNLJIJD, GKCJJMNCBDN<TData> EIDGHHFIPHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x351E9E0", Offset = "0x351DDE0", VA = "0x18351E9E0", Slot = "4")]
	public override bool HPOJNLGPELL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class MEHLEFOCOHO<TData> : DLPMIOAMOGF<GKCJJMNCBDN<TData>> where TData : notnull, FALCANCKDII
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly FKAOIDONKHB<TData> CLBCCHCHGBC;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3B0A2D0", Offset = "0x3B096D0", VA = "0x183B0A2D0")]
	public MEHLEFOCOHO(List<TData> PLPOAJFHFMP, List<bool> GCPMEADOANB, GKCJJMNCBDN<TData> EIDGHHFIPHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3B0A210", Offset = "0x3B09610", VA = "0x183B0A210", Slot = "4")]
	public override bool HPOJNLGPELL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface DJKAMMHFHHN : FALCANCKDII
{
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface COMNNJLKFGO<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<MCJOGGHNNPF> HPOJNLGPELL(CGGDOKLHDEH<TData> FEKJOECBAFG);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class KCNCOAFLEFD<TData> : PKHHLPMIFOD<COMNNJLKFGO<TData>, MCJOGGHNNPF> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct KHHPNIMKHFE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public AsyncTaskMethodBuilder<MCJOGGHNNPF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public KCNCOAFLEFD<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private TaskAwaiter<MCJOGGHNNPF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x3800C70", Offset = "0x3800070", VA = "0x183800C70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x3800F60", Offset = "0x3800360", VA = "0x183800F60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly CGGDOKLHDEH<TData> GHCAOAFNHIE;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x37E3EB0", Offset = "0x37E32B0", VA = "0x1837E3EB0")]
	public KCNCOAFLEFD(TData DLOFMLEJKEF, IReadOnlyList<TData> HAHMDJJNJDC, bool HOCKBKPBHJF, COMNNJLKFGO<TData> EIDGHHFIPHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x37E3DB0", Offset = "0x37E31B0", VA = "0x1837E3DB0", Slot = "4")]
	[AsyncStateMachine(typeof(KCNCOAFLEFD<>.KHHPNIMKHFE))]
	public override Task<MCJOGGHNNPF> HPOJNLGPELL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct CGGDOKLHDEH<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public TData OJGDIJBFGOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public IReadOnlyList<TData> MDBLBPNLJIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public bool BDONFLMKLKO;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x4325500", Offset = "0x4324900", VA = "0x184325500")]
	public CGGDOKLHDEH(TData DLOFMLEJKEF, IReadOnlyList<TData> HAHMDJJNJDC, bool HOCKBKPBHJF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface GOPHIHALFBB<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HPOJNLGPELL([In] KGEBOKFBGCI<TData> FMHGJPCIHPI);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface GFCKGICNBKI<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HPOJNLGPELL([In] PBLNPLAEKDE<TData> FMHGJPCIHPI);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface OHCMDBBANGA<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NDDHFHCLAMA([In] LPKMKKOPKPJ<TData> FMHGJPCIHPI);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HACKHCHBIHD();
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public class BPKGBGIDDIG<TData> : DLPMIOAMOGF<GOPHIHALFBB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly KGEBOKFBGCI<TData> FMHGJPCIHPI;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x45EAE60", Offset = "0x45EA260", VA = "0x1845EAE60")]
	public BPKGBGIDDIG(IEnumerable<TData> PLPOAJFHFMP, NCILIAGLIJH KKBAHNFNJMK, JLNMGILEGED CFMOAHBPGNP, float LAPPFBIDPOH, bool HOCKBKPBHJF, GOPHIHALFBB<TData> EIDGHHFIPHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x351E9E0", Offset = "0x351DDE0", VA = "0x18351E9E0", Slot = "4")]
	public override bool HPOJNLGPELL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class LCJOCOCAGFI<TData> : DLPMIOAMOGF<GFCKGICNBKI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly PBLNPLAEKDE<TData> FMHGJPCIHPI;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x38C1C60", Offset = "0x38C1060", VA = "0x1838C1C60")]
	public LCJOCOCAGFI(TData[] PLPOAJFHFMP, NCILIAGLIJH[] KKBAHNFNJMK, JLNMGILEGED[] CFMOAHBPGNP, float[] LAPPFBIDPOH, GFCKGICNBKI<TData> EIDGHHFIPHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x38C1AD0", Offset = "0x38C0ED0", VA = "0x1838C1AD0", Slot = "4")]
	public override bool HPOJNLGPELL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class BEACPENJFHP<TData> : DLPMIOAMOGF<OHCMDBBANGA<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x30267D0", Offset = "0x3025BD0", VA = "0x1830267D0")]
	public BEACPENJFHP(OHCMDBBANGA<TData> EIDGHHFIPHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x4495720", Offset = "0x4494B20", VA = "0x184495720", Slot = "4")]
	public override bool HPOJNLGPELL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class NLDLMICDNGB<TData> : DLPMIOAMOGF<OHCMDBBANGA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly LPKMKKOPKPJ<TData> FMHGJPCIHPI;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x3BE45A0", Offset = "0x3BE39A0", VA = "0x183BE45A0")]
	public NLDLMICDNGB(IEnumerable<TData> PLPOAJFHFMP, NCILIAGLIJH KKBAHNFNJMK, JLNMGILEGED CFMOAHBPGNP, float LAPPFBIDPOH, OHCMDBBANGA<TData> EIDGHHFIPHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x38C1AD0", Offset = "0x38C0ED0", VA = "0x1838C1AD0", Slot = "4")]
	public override bool HPOJNLGPELL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct KGEBOKFBGCI<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public IEnumerable<TData> MLAPJOGBINK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public NCILIAGLIJH ECDKMOIOOBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public JLNMGILEGED JGPBGJCKBJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public float LAPPFBIDPOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public bool HOCKBKPBHJF;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x37EAB70", Offset = "0x37E9F70", VA = "0x1837EAB70")]
	public KGEBOKFBGCI(IEnumerable<TData> PLPOAJFHFMP, NCILIAGLIJH KKBAHNFNJMK, JLNMGILEGED CFMOAHBPGNP, float LAPPFBIDPOH, bool HOCKBKPBHJF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct PBLNPLAEKDE<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public TData[] MLAPJOGBINK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public NCILIAGLIJH[] ECDKMOIOOBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public JLNMGILEGED[] JGPBGJCKBJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public float[] LAPPFBIDPOH;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3DA3950", Offset = "0x3DA2D50", VA = "0x183DA3950")]
	public PBLNPLAEKDE(TData[] PLPOAJFHFMP, NCILIAGLIJH[] KKBAHNFNJMK, JLNMGILEGED[] CFMOAHBPGNP, float[] LAPPFBIDPOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct LPKMKKOPKPJ<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public IEnumerable<TData> MLAPJOGBINK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public NCILIAGLIJH ECDKMOIOOBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public JLNMGILEGED JGPBGJCKBJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public float LAPPFBIDPOH;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x39322B0", Offset = "0x39316B0", VA = "0x1839322B0")]
	public LPKMKKOPKPJ(IEnumerable<TData> PLPOAJFHFMP, NCILIAGLIJH KKBAHNFNJMK, JLNMGILEGED CFMOAHBPGNP, float LAPPFBIDPOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface LILDJFMIGLE<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HPJICADLBOP([In] INKADMOPEBH<TData> CIKHFBIIOEN);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ICAAIJDJDJG([In] INKADMOPEBH<TData> CIKHFBIIOEN);

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PJPJNMHLCPL([In] bool DLLBHDOGDMM);

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool GLBGLFBGDJI([In] INKADMOPEBH<TData> CIKHFBIIOEN);

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ICPJAKCPBDF();

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool OHINKECPJHH([In] TData FABONHCALBO);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class HJFNEFKPEOG<TData> : DLPMIOAMOGF<LILDJFMIGLE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly INKADMOPEBH<TData> CIKHFBIIOEN;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x351F0B0", Offset = "0x351E4B0", VA = "0x18351F0B0")]
	public HJFNEFKPEOG(List<TData> COIJKGGMHJF, LILDJFMIGLE<TData> EIDGHHFIPHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x351E9E0", Offset = "0x351DDE0", VA = "0x18351E9E0", Slot = "4")]
	public override bool HPOJNLGPELL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class DDHAOPCIGMM<TData> : DLPMIOAMOGF<LILDJFMIGLE<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x30267D0", Offset = "0x3025BD0", VA = "0x1830267D0")]
	public DDHAOPCIGMM(LILDJFMIGLE<TData> EIDGHHFIPHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x4CE3690", Offset = "0x4CE2A90", VA = "0x184CE3690", Slot = "4")]
	public override bool HPOJNLGPELL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class LNIJFLNLNGO<TData> : DLPMIOAMOGF<LILDJFMIGLE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly bool HOCKBKPBHJF;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x391BDA0", Offset = "0x391B1A0", VA = "0x18391BDA0")]
	public LNIJFLNLNGO(bool HOCKBKPBHJF, LILDJFMIGLE<TData> EIDGHHFIPHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x391BD40", Offset = "0x391B140", VA = "0x18391BD40", Slot = "4")]
	public override bool HPOJNLGPELL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class OGNIDMGMJEA<TData> : DLPMIOAMOGF<LILDJFMIGLE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly INKADMOPEBH<TData> CIKHFBIIOEN;

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x3CD4A20", Offset = "0x3CD3E20", VA = "0x183CD4A20")]
	public OGNIDMGMJEA(List<TData> COIJKGGMHJF, bool HOCKBKPBHJF, LILDJFMIGLE<TData> EIDGHHFIPHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x3B0A210", Offset = "0x3B09610", VA = "0x183B0A210", Slot = "4")]
	public override bool HPOJNLGPELL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class AGOGNCACKHO<TData> : DLPMIOAMOGF<LILDJFMIGLE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly TData FABONHCALBO;

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x34BA4E0", Offset = "0x34B98E0", VA = "0x1834BA4E0")]
	public AGOGNCACKHO(TData FABONHCALBO, LILDJFMIGLE<TData> EIDGHHFIPHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x34BA410", Offset = "0x34B9810", VA = "0x1834BA410", Slot = "4")]
	public override bool HPOJNLGPELL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class NDIMNAGJBKJ<TData> : DLPMIOAMOGF<LILDJFMIGLE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly INKADMOPEBH<TData> CIKHFBIIOEN;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x3BCFB00", Offset = "0x3BCEF00", VA = "0x183BCFB00")]
	public NDIMNAGJBKJ(List<TData> COIJKGGMHJF, LILDJFMIGLE<TData> EIDGHHFIPHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x3BCFA30", Offset = "0x3BCEE30", VA = "0x183BCFA30", Slot = "4")]
	public override bool HPOJNLGPELL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public struct INKADMOPEBH<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public IEnumerable<TData> MLAPJOGBINK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public bool HOCKBKPBHJF;

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x35D7C80", Offset = "0x35D7080", VA = "0x1835D7C80")]
	public INKADMOPEBH(IEnumerable<TData> CEAKAFIFLJN, bool OODEHFJIBAK = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface CGBJKPOLMNN
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<MCJOGGHNNPF> HPOJNLGPELL(ALKGGKGNPIF ICDCOKEIBAN);
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class BOEDMMPEPOL : PKHHLPMIFOD<CGBJKPOLMNN, MCJOGGHNNPF>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private struct MFFBMLDCNOF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<MCJOGGHNNPF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public BOEDMMPEPOL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private TaskAwaiter<MCJOGGHNNPF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x5CFCC10", Offset = "0x5CFC010", VA = "0x185CFCC10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x5CFCE90", Offset = "0x5CFC290", VA = "0x185CFCE90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly ALKGGKGNPIF DKGECOAMJOB;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5CFC8D0", Offset = "0x5CFBCD0", VA = "0x185CFC8D0")]
	public BOEDMMPEPOL(bool HOCKBKPBHJF, CGBJKPOLMNN EIDGHHFIPHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5CFC7E0", Offset = "0x5CFBBE0", VA = "0x185CFC7E0", Slot = "4")]
	[AsyncStateMachine(typeof(MFFBMLDCNOF))]
	public override Task<MCJOGGHNNPF> HPOJNLGPELL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public struct ALKGGKGNPIF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public bool BDONFLMKLKO;

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0xB15050", Offset = "0xB14450", VA = "0x180B15050")]
	public ALKGGKGNPIF(bool HOCKBKPBHJF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface PDBGPBHAEJN<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FCLOODLBPGH([In] HCFKPIMKGPH<TData> JIEJFJFPLBO);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NDDHFHCLAMA([In] DNHKDFBGBGL NNJIMPPPPLH);

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NDDHFHCLAMA([In] DBBKHJLOIMG NNJIMPPPPLH);

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HACKHCHBIHD();
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class HNNJNNOAMJL<TData> : DLPMIOAMOGF<PDBGPBHAEJN<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x30267D0", Offset = "0x3025BD0", VA = "0x1830267D0")]
	public HNNJNNOAMJL(PDBGPBHAEJN<TData> EIDGHHFIPHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x3525F40", Offset = "0x3525340", VA = "0x183525F40", Slot = "4")]
	public override bool HPOJNLGPELL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class EEINLNBJJIH<TData> : DLPMIOAMOGF<PDBGPBHAEJN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly DNHKDFBGBGL AHKCPMBBGMI;

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x301FF90", Offset = "0x301F390", VA = "0x18301FF90")]
	public EEINLNBJJIH(Vector3 IKHFBAGBCGA, bool NOADJJPJKEL, PDBGPBHAEJN<TData> EIDGHHFIPHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x301FF30", Offset = "0x301F330", VA = "0x18301FF30", Slot = "4")]
	public override bool HPOJNLGPELL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class JICDJKLDPCG<TData> : DLPMIOAMOGF<PDBGPBHAEJN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly DBBKHJLOIMG AHKCPMBBGMI;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x37A0A70", Offset = "0x379FE70", VA = "0x1837A0A70")]
	public JICDJKLDPCG(Guid KPPIKHHFHLL, int JPEMHHILGGG, Vector3 BAONBICGOEJ, Quaternion CKFJFCLIANA, float ILPHNFDIOJC, bool NOADJJPJKEL, PDBGPBHAEJN<TData> EIDGHHFIPHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x37A0A10", Offset = "0x379FE10", VA = "0x1837A0A10", Slot = "4")]
	public override bool HPOJNLGPELL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class KFHDFMFDAPH<TData> : DLPMIOAMOGF<PDBGPBHAEJN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly HCFKPIMKGPH<TData> AHKCPMBBGMI;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x37EA2F0", Offset = "0x37E96F0", VA = "0x1837EA2F0")]
	public KFHDFMFDAPH(TData ADOGMMPMLJB, bool HOCKBKPBHJF, PDBGPBHAEJN<TData> EIDGHHFIPHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x351E9E0", Offset = "0x351DDE0", VA = "0x18351E9E0", Slot = "4")]
	public override bool HPOJNLGPELL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public struct DNHKDFBGBGL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly Vector3 IKHFBAGBCGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly bool NOADJJPJKEL;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5CFC970", Offset = "0x5CFBD70", VA = "0x185CFC970")]
	public DNHKDFBGBGL(Vector3 IKHFBAGBCGA, bool NOADJJPJKEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct DBBKHJLOIMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly Guid KPPIKHHFHLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly int JPEMHHILGGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly Vector3 BAONBICGOEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly Quaternion CKFJFCLIANA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly float ILPHNFDIOJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly bool NOADJJPJKEL;

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5CFC930", Offset = "0x5CFBD30", VA = "0x185CFC930")]
	public DBBKHJLOIMG(Guid KPPIKHHFHLL, int JPEMHHILGGG, Vector3 BAONBICGOEJ, Quaternion CKFJFCLIANA, float ILPHNFDIOJC, bool NOADJJPJKEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public struct HCFKPIMKGPH<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly TData ADOGMMPMLJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly bool HOCKBKPBHJF;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x34FFD70", Offset = "0x34FF170", VA = "0x1834FFD70")]
	public HCFKPIMKGPH(TData ADOGMMPMLJB, bool HOCKBKPBHJF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public interface OENIPENEGGJ<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HPOJNLGPELL([In] HPDCPIKFADE<TData> LOJFIMKFMOJ);

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HPOJNLGPELL([In] JLMODPOILAG<TData> LOJFIMKFMOJ);
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface ADOAMNEKLED<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FCLOODLBPGH([In] JLNAEODDFLN<TData> NJDGKOHONMH);

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NDDHFHCLAMA([In] APAHJILAAPI NNJIMPPPPLH);

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HACKHCHBIHD();
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class JAPMEKLHIGF<TData> : DLPMIOAMOGF<OENIPENEGGJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly HPDCPIKFADE<TData> LOJFIMKFMOJ;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x376F540", Offset = "0x376E940", VA = "0x18376F540")]
	public JAPMEKLHIGF(IEnumerable<TData> PLPOAJFHFMP, Vector3 IHGMPBKGNPD, bool HOCKBKPBHJF, OENIPENEGGJ<TData> EIDGHHFIPHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x351E9E0", Offset = "0x351DDE0", VA = "0x18351E9E0", Slot = "4")]
	public override bool HPOJNLGPELL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class GMHPEAMHDIF<TData> : DLPMIOAMOGF<ADOAMNEKLED<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x30267D0", Offset = "0x3025BD0", VA = "0x1830267D0")]
	public GMHPEAMHDIF(ADOAMNEKLED<TData> EIDGHHFIPHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x339D120", Offset = "0x339C520", VA = "0x18339D120", Slot = "4")]
	public override bool HPOJNLGPELL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class JJJBDONGJCC<TData> : DLPMIOAMOGF<ADOAMNEKLED<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly JLNAEODDFLN<TData> LOJFIMKFMOJ;

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x37A0C70", Offset = "0x37A0070", VA = "0x1837A0C70")]
	public JJJBDONGJCC(IEnumerable<TData> PLPOAJFHFMP, bool HOCKBKPBHJF, ADOAMNEKLED<TData> EIDGHHFIPHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x351E9E0", Offset = "0x351DDE0", VA = "0x18351E9E0", Slot = "4")]
	public override bool HPOJNLGPELL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class JKMPAHKGDDG<TData> : DLPMIOAMOGF<OENIPENEGGJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly JLMODPOILAG<TData> LOJFIMKFMOJ;

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x37A1610", Offset = "0x37A0A10", VA = "0x1837A1610")]
	public JKMPAHKGDDG(IEnumerable<TData> PLPOAJFHFMP, Vector3 JMKADABIMLJ, DNKKFLDKFMP FFPHAIGHBGG, bool HOCKBKPBHJF, OENIPENEGGJ<TData> EIDGHHFIPHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x37A1540", Offset = "0x37A0940", VA = "0x1837A1540", Slot = "4")]
	public override bool HPOJNLGPELL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class APJCFGFGAPC<TData> : DLPMIOAMOGF<ADOAMNEKLED<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly APAHJILAAPI LOJFIMKFMOJ;

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x35F16E0", Offset = "0x35F0AE0", VA = "0x1835F16E0")]
	public APJCFGFGAPC(Vector3 IHGMPBKGNPD, ADOAMNEKLED<TData> EIDGHHFIPHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x301FF30", Offset = "0x301F330", VA = "0x18301FF30", Slot = "4")]
	public override bool HPOJNLGPELL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public struct HPDCPIKFADE<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public readonly IEnumerable<TData> PLPOAJFHFMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly Vector3 IHGMPBKGNPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly bool HOCKBKPBHJF;

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3538DA0", Offset = "0x35381A0", VA = "0x183538DA0")]
	public HPDCPIKFADE(IEnumerable<TData> PLPOAJFHFMP, Vector3 IHGMPBKGNPD, bool HOCKBKPBHJF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public struct JLNAEODDFLN<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly IEnumerable<TData> PLPOAJFHFMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly bool HOCKBKPBHJF;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x37A1DF0", Offset = "0x37A11F0", VA = "0x1837A1DF0")]
	public JLNAEODDFLN(IEnumerable<TData> PLPOAJFHFMP, bool HOCKBKPBHJF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public struct JLMODPOILAG<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly IEnumerable<TData> PLPOAJFHFMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly Vector3 JMKADABIMLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly DNKKFLDKFMP FFPHAIGHBGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly bool HOCKBKPBHJF;

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x37A1CA0", Offset = "0x37A10A0", VA = "0x1837A1CA0")]
	public JLMODPOILAG(IEnumerable<TData> PLPOAJFHFMP, Vector3 JMKADABIMLJ, DNKKFLDKFMP FFPHAIGHBGG, bool HOCKBKPBHJF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public struct APAHJILAAPI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly Vector3 IHGMPBKGNPD;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x1ED65C0", Offset = "0x1ED59C0", VA = "0x181ED65C0")]
	public APAHJILAAPI(Vector3 IHGMPBKGNPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public enum DNKKFLDKFMP
{
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	XYZ,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	X_only,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	Y_only,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	Z_only
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface MGDEABDDOFH<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HPOJNLGPELL([In] EEBJEPEFGJI<TData> OHDELHEBLPK);

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HPOJNLGPELL([In] OBNPFHINLIK<TData> OHDELHEBLPK);
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface OMGBENAKJPC<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FCLOODLBPGH([In] OOINILMMNHF<TData> JIEJFJFPLBO);

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NDDHFHCLAMA([In] CCOJAPJPIDG NNJIMPPPPLH);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HACKHCHBIHD();
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class PDFAHHGJFDI<TData> : DLPMIOAMOGF<MGDEABDDOFH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly EEBJEPEFGJI<TData> OHDELHEBLPK;

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3DFB180", Offset = "0x3DFA580", VA = "0x183DFB180")]
	public PDFAHHGJFDI(IEnumerable<TData> PLPOAJFHFMP, Quaternion IHGMPBKGNPD, Vector3? NAKFNFPAHOE, bool GPGLGDEGMKB, bool HOCKBKPBHJF, MGDEABDDOFH<TData> EIDGHHFIPHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x351E9E0", Offset = "0x351DDE0", VA = "0x18351E9E0", Slot = "4")]
	public override bool HPOJNLGPELL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class FMKGBINDHIN<TData> : DLPMIOAMOGF<OMGBENAKJPC<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x30267D0", Offset = "0x3025BD0", VA = "0x1830267D0")]
	public FMKGBINDHIN(OMGBENAKJPC<TData> EIDGHHFIPHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x339D120", Offset = "0x339C520", VA = "0x18339D120", Slot = "4")]
	public override bool HPOJNLGPELL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class OCLONKBNNAH<TData> : DLPMIOAMOGF<OMGBENAKJPC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly OOINILMMNHF<TData> OHDELHEBLPK;

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x3CBD340", Offset = "0x3CBC740", VA = "0x183CBD340")]
	public OCLONKBNNAH(IEnumerable<TData> PLPOAJFHFMP, bool HOCKBKPBHJF, OMGBENAKJPC<TData> EIDGHHFIPHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x351E9E0", Offset = "0x351DDE0", VA = "0x18351E9E0", Slot = "4")]
	public override bool HPOJNLGPELL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class KACILLKOHIM<TData> : DLPMIOAMOGF<MGDEABDDOFH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly OBNPFHINLIK<TData> OHDELHEBLPK;

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x37DDEE0", Offset = "0x37DD2E0", VA = "0x1837DDEE0")]
	public KACILLKOHIM(IEnumerable<TData> PLPOAJFHFMP, Quaternion LIPHJIOIMFI, DNKKFLDKFMP LKEHJJPBDHE, Vector3? NAKFNFPAHOE, bool GPGLGDEGMKB, bool HOCKBKPBHJF, MGDEABDDOFH<TData> EIDGHHFIPHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x37A1540", Offset = "0x37A0940", VA = "0x1837A1540", Slot = "4")]
	public override bool HPOJNLGPELL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class LJEHELFLFLD<TData> : DLPMIOAMOGF<OMGBENAKJPC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly CCOJAPJPIDG OHDELHEBLPK;

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x38EE4E0", Offset = "0x38ED8E0", VA = "0x1838EE4E0")]
	public LJEHELFLFLD(Quaternion IHGMPBKGNPD, Vector3? NAKFNFPAHOE, bool GPGLGDEGMKB, OMGBENAKJPC<TData> EIDGHHFIPHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x301FF30", Offset = "0x301F330", VA = "0x18301FF30", Slot = "4")]
	public override bool HPOJNLGPELL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public struct EEBJEPEFGJI<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public readonly IEnumerable<TData> PLPOAJFHFMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly Quaternion IHGMPBKGNPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public readonly Vector3? NAKFNFPAHOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public readonly bool GPGLGDEGMKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public readonly bool HOCKBKPBHJF;

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x301FAE0", Offset = "0x301EEE0", VA = "0x18301FAE0")]
	public EEBJEPEFGJI(IEnumerable<TData> PLPOAJFHFMP, Quaternion IHGMPBKGNPD, Vector3? NAKFNFPAHOE, bool GPGLGDEGMKB, bool HOCKBKPBHJF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public struct OOINILMMNHF<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public readonly IEnumerable<TData> PLPOAJFHFMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public readonly bool HOCKBKPBHJF;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x3D04790", Offset = "0x3D03B90", VA = "0x183D04790")]
	public OOINILMMNHF(IEnumerable<TData> PLPOAJFHFMP, bool HOCKBKPBHJF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public struct OBNPFHINLIK<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public readonly IEnumerable<TData> PLPOAJFHFMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public readonly Quaternion LIPHJIOIMFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public readonly DNKKFLDKFMP LKEHJJPBDHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public readonly Vector3? NAKFNFPAHOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public readonly bool GPGLGDEGMKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public readonly bool HOCKBKPBHJF;

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x3CB7DE0", Offset = "0x3CB71E0", VA = "0x183CB7DE0")]
	public OBNPFHINLIK(IEnumerable<TData> PLPOAJFHFMP, Quaternion LIPHJIOIMFI, DNKKFLDKFMP LKEHJJPBDHE, Vector3? NAKFNFPAHOE, bool GPGLGDEGMKB, bool HOCKBKPBHJF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public struct CCOJAPJPIDG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public readonly Quaternion IHGMPBKGNPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public readonly Vector3? NAKFNFPAHOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public readonly bool GPGLGDEGMKB;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x4308CD0", Offset = "0x43080D0", VA = "0x184308CD0")]
	public CCOJAPJPIDG(Quaternion IHGMPBKGNPD, Vector3? NAKFNFPAHOE, bool GPGLGDEGMKB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public interface JHMIIEEFDHA<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FCLOODLBPGH([In] CPNIEPCKKOD<TData> JIEJFJFPLBO);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NDDHFHCLAMA([In] BJNAHFIHBPH NNJIMPPPPLH);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NDDHFHCLAMA([In] ECFNHKHNHKP NNJIMPPPPLH);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool NDDHFHCLAMA([In] EALOACFPEJK NNJIMPPPPLH);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool HACKHCHBIHD();
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public class OEDPNJJIMLJ<TData> : DLPMIOAMOGF<JHMIIEEFDHA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly EALOACFPEJK JKNEBKIPAPI;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3CC2E10", Offset = "0x3CC2210", VA = "0x183CC2E10")]
	public OEDPNJJIMLJ(Vector3 KKDNMHCGFLC, float ENADKENACNO, Vector3 NAKFNFPAHOE, bool EDEJIMJLFOP, JHMIIEEFDHA<TData> EIDGHHFIPHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3CC2DB0", Offset = "0x3CC21B0", VA = "0x183CC2DB0", Slot = "4")]
	public override bool HPOJNLGPELL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class LIFACHEJLJK<TData> : DLPMIOAMOGF<JHMIIEEFDHA<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x30267D0", Offset = "0x3025BD0", VA = "0x1830267D0")]
	public LIFACHEJLJK(JHMIIEEFDHA<TData> EIDGHHFIPHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x38DDD30", Offset = "0x38DD130", VA = "0x1838DDD30", Slot = "4")]
	public override bool HPOJNLGPELL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public class APCBJAAPPDC<TData> : DLPMIOAMOGF<JHMIIEEFDHA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly CPNIEPCKKOD<TData> JKNEBKIPAPI;

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x35F14B0", Offset = "0x35F08B0", VA = "0x1835F14B0")]
	public APCBJAAPPDC(IEnumerable<TData> PLPOAJFHFMP, bool HOCKBKPBHJF, JHMIIEEFDHA<TData> EIDGHHFIPHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x351E9E0", Offset = "0x351DDE0", VA = "0x18351E9E0", Slot = "4")]
	public override bool HPOJNLGPELL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public class BLBAEGLIBBI<TData> : DLPMIOAMOGF<JHMIIEEFDHA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly ECFNHKHNHKP JKNEBKIPAPI;

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x44B24B0", Offset = "0x44B18B0", VA = "0x1844B24B0")]
	public BLBAEGLIBBI(float KIFFBFMGOLG, bool PHAPMKAFJMK, Vector3 NAKFNFPAHOE, JHMIIEEFDHA<TData> EIDGHHFIPHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x44B23E0", Offset = "0x44B17E0", VA = "0x1844B23E0", Slot = "4")]
	public override bool HPOJNLGPELL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class OHGHICIGCND<TData> : DLPMIOAMOGF<JHMIIEEFDHA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private readonly BJNAHFIHBPH JKNEBKIPAPI;

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x3CD59E0", Offset = "0x3CD4DE0", VA = "0x183CD59E0")]
	public OHGHICIGCND(float ENADKENACNO, Vector3 NAKFNFPAHOE, JHMIIEEFDHA<TData> EIDGHHFIPHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x301FF30", Offset = "0x301F330", VA = "0x18301FF30", Slot = "4")]
	public override bool HPOJNLGPELL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public struct EALOACFPEJK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public readonly Vector3 KKDNMHCGFLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public readonly float ENADKENACNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly Vector3 NAKFNFPAHOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public readonly bool NOADJJPJKEL;

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x5CFC990", Offset = "0x5CFBD90", VA = "0x185CFC990")]
	public EALOACFPEJK(Vector3 KKDNMHCGFLC, float ENADKENACNO, Vector3 NAKFNFPAHOE, bool NOADJJPJKEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public struct CPNIEPCKKOD<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly IEnumerable<TData> PLPOAJFHFMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public readonly bool HOCKBKPBHJF;

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x4A9B2D0", Offset = "0x4A9A6D0", VA = "0x184A9B2D0")]
	public CPNIEPCKKOD(IEnumerable<TData> PLPOAJFHFMP, bool HOCKBKPBHJF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct ECFNHKHNHKP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public readonly float KIFFBFMGOLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public readonly bool PHAPMKAFJMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public readonly Vector3 NAKFNFPAHOE;

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x5CFC9C0", Offset = "0x5CFBDC0", VA = "0x185CFC9C0")]
	public ECFNHKHNHKP(float KIFFBFMGOLG, bool PHAPMKAFJMK, Vector3 NAKFNFPAHOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public struct BJNAHFIHBPH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public readonly float ENADKENACNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public readonly Vector3 NAKFNFPAHOE;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x42EAF20", Offset = "0x42EA320", VA = "0x1842EAF20")]
	public BJNAHFIHBPH(float ENADKENACNO, Vector3 NAKFNFPAHOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public static class BINCNHDLNAE
{
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	private struct EIEOPGAOJMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public bool MMIJCIJDNPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public BFGBHKPNKEI BGKKJADIOFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public BFGBHKPNKEI MPDEMCHGGND;
	}

	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private static EIEOPGAOJMG BMONBIGDDBA;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static CancellationToken GEKALEOKFNL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x5CFC650", Offset = "0x5CFBA50", VA = "0x185CFC650")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	internal static BFGBHKPNKEI BGKKJADIOFD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x5CFC410", Offset = "0x5CFB810", VA = "0x185CFC410")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x5CFC670", Offset = "0x5CFBA70", VA = "0x185CFC670")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5CFC6E0", Offset = "0x5CFBAE0", VA = "0x185CFC6E0")]
	[DCEDJGMCFCN(HKDEIDHACLB.Room, IIPPAMCLFBJ.None)]
	private static void OFBGMIAKKFE(BFGBHKPNKEI JGJBHEDPFCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x5CFC4B0", Offset = "0x5CFB8B0", VA = "0x185CFC4B0")]
	public static void CGCDLMDFFPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x5CFC600", Offset = "0x5CFBA00", VA = "0x185CFC600")]
	private static BFGBHKPNKEI GLLDEMPMFCB(BFGBHKPNKEI FMGMKMDJHPG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public static class NMIBIOMOHOE
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public enum JADPJHDDDHK
	{
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		ICreationContextObject,
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		Guid
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x24E8380", Offset = "0x24E7780", VA = "0x1824E8380")]
	public static void KIOMPOMHOHF<T>(T CLFOAALEFAI, JADPJHDDDHK DJMKKNDNCBM) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x24E8320", Offset = "0x24E7720", VA = "0x1824E8320")]
	public static void KIOMPOMHOHF<T>(T CLFOAALEFAI) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x24E8560", Offset = "0x24E7960", VA = "0x1824E8560")]
	public static void NHANIMIMNMN<T>(T CLFOAALEFAI) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x24E84C0", Offset = "0x24E78C0", VA = "0x1824E84C0")]
	public static T KJBHHOOLCCM<T>(JADPJHDDDHK DJMKKNDNCBM) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x24E82E0", Offset = "0x24E76E0", VA = "0x1824E82E0")]
	public static T KJBHHOOLCCM<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x24E82E0", Offset = "0x24E76E0", VA = "0x1824E82E0")]
	public static bool DHOEELPFIHH<T>() where T : class
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal static class FMAECFAJCAD
{
	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x5CFC9E0", Offset = "0x5CFBDE0", VA = "0x185CFC9E0")]
	public static void PNGOCOKPAGG(IEnumerable BENHOIANLCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x23BA130", Offset = "0x23B9530", VA = "0x1823BA130")]
	public static void PNGOCOKPAGG<T>(T[] FOAJABBKLPB) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x23BA220", Offset = "0x23B9620", VA = "0x1823BA220")]
	public static void PNGOCOKPAGG<T>(T BMDIIPBLIGI) where T : notnull, Enum
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
