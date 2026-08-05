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
		[Cpp2IlInjected.Address(RVA = "0xA82AE0", Offset = "0xA818E0", VA = "0x180A82AE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8119BC0", Offset = "0x81189C0", VA = "0x188119BC0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA838A0", Offset = "0xA826A0", VA = "0x180A838A0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA838E0", Offset = "0xA826E0", VA = "0x180A838E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8119F50", Offset = "0x8118D50", VA = "0x188119F50", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x286F3E0", Offset = "0x286E1E0", VA = "0x18286F3E0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum CNLKBOHLAFI
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	ShowFreeInventionsInR2PaletteSearch
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum EPBBLGCDGEJ
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
public interface KKAEACFJALC<TData, TReturn>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TReturn BGABMIKICIM(TData MKPNGAKJFMP);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface LAAHCGNHDPI<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ClearHoverTarget(JCMOMJHEABP EDIOHJAEEAH);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool SetHoverTarget(TData IMBAOPHEODM, Collider BMOOADDPJCL, JCMOMJHEABP EDIOHJAEEAH, [Optional] CKJLKPAHMFI? KOALNIJHMCJ);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool TryGetHoverTarget([Out] TData IMBAOPHEODM);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetHoverCollider([Out] Collider BMOOADDPJCL);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface BBGGGOINMBI<TData> : FBDBJKMFHPA, AAKEPAHJKKC<TData>, ABMJOJGJNEJ<TData>, MGCCCKHONNC<TData>, HJPPOBHEHMK, ENIAMNBONMP<TData>, CKGEIDAGKLF, LCAIFFCNCAI
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface ENIAMNBONMP<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 JKBPBEFFDAH, Vector3 NCJMIJBPLIB, float NGOCCMOBNDC, [Out] T IEKEFCKBNNI, [Out] Vector3 PELHLKFJKCE, [Out] Collider BMOOADDPJCL);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 JKBPBEFFDAH, Vector3 NCJMIJBPLIB, float EPCFKMFIKKG, float NGOCCMOBNDC, T[] OCECBEKLFNN, [Out] Vector3 LMFCBMOGFII, [Out] Collider BDOIDMCDNME);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 JKBPBEFFDAH, float EPCFKMFIKKG, Vector3 PKMJIDOKCPJ, T[] OCECBEKLFNN);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetObjectFromColliderInCurrentScope(Collider AKMFHNGACJK, [Out] T MNGNNHIODAL);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface FBDBJKMFHPA
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Bounds JHNPAJNCCBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Transform OGGHCLDAMAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Bounds DPHFEDDLEPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Transform IIDHPDCILHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Vector3 MCOODBGHBKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool PGJPCNGLBBG
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
	void SetSelectionBoundsDirty(bool HHBIONBDFBJ = true, int BKLJLCCGCCE = 0);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ShouldHideSelectionBoundsPreview(bool LHNIIAPLGBE, object OCGDLEBGIMO);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface LCAIFFCNCAI
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	EPBKGABEMJJ BNCHLIEEAOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface AANAIJEIFEF
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool ELMPEFFKLNC
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool KPCBBLJAOGE
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool MFFMDJLHGAC
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
	void TrySetPreviousCloneMapping(Dictionary<Guid, Guid> HBIJIBHIKLH);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface MGCCCKHONNC<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool BKNOAHIEPMA
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int CGCFNCBAHKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<TData> HNJBLJHIABP
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData EHKDLJBBGDB);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData EHKDLJBBGDB);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface AAKEPAHJKKC<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T MKPNGAKJFMP, [Optional] CKJLKPAHMFI? KMKJPPGBBCA, bool NCGKIHPGNIN = true);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int LJEIHABMGGI, IEnumerable<T> PPBFCAAOABF, bool NCGKIHPGNIN = true);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int LJEIHABMGGI, IEnumerable<T> PPBFCAAOABF, CKJLKPAHMFI KMKJPPGBBCA, bool NCGKIHPGNIN = true);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface CKGEIDAGKLF
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface HJPPOBHEHMK
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool DDFJEAFJCKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool APCJHBKADEA
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool MGNDCNLAKGH
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool IDOGDMMPLNB
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct KEKMNGHMDNL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public bool AIGIKLCEHGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public float? LEAINBELBLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public float? FLAKGGBFGKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public float? JGKHPJHOBOL;
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct CPDCDAKGDMD<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public IEnumerable<TData> CPIFAHNDOPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public KEKMNGHMDNL PPJIEIMHMMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public bool BKJIDHCCBMN;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x68E4620", Offset = "0x68E3420", VA = "0x1868E4620")]
	public CPDCDAKGDMD(IEnumerable<TData> POIMBCOJFJM, bool GLHDJKEBIGE, float? CJJBKIJFJFP, float? FANOBLNBIII, float? EHAMHPAGDIN, bool BKJIDHCCBMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface IPNFCEBHHBL<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BFLCGMAIILH([In] CPDCDAKGDMD<TData> ENDEOBGIMGA);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class CMNJHGGNKLL<TData> : CFCKCAJKCHC<IPNFCEBHHBL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly CPDCDAKGDMD<TData> ENDEOBGIMGA;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x68DC030", Offset = "0x68DAE30", VA = "0x1868DC030")]
	public CMNJHGGNKLL(IEnumerable<TData> POIMBCOJFJM, bool GLHDJKEBIGE, float? CJJBKIJFJFP, float? FANOBLNBIII, float? EHAMHPAGDIN, bool BKJIDHCCBMN, IPNFCEBHHBL<TData> JBODBHEGPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4811340", Offset = "0x4810140", VA = "0x184811340", Slot = "4")]
	public override bool BFLCGMAIILH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct AOLLLHAJIBF<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public IEnumerable<TData> CPIFAHNDOPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public string POFMCMPHBJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public bool JNGKBPAAKLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public bool BKJIDHCCBMN;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x50C93B0", Offset = "0x50C81B0", VA = "0x1850C93B0")]
	public AOLLLHAJIBF(IEnumerable<TData> POIMBCOJFJM, string GKJABGINPJG, bool BLJNGPBCBIK, bool BKJIDHCCBMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface KBLNIFDLNPL<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BFLCGMAIILH([In] AOLLLHAJIBF<TData> ENDEOBGIMGA);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class CHOOGPOECKC<TData> : CFCKCAJKCHC<KBLNIFDLNPL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly AOLLLHAJIBF<TData> ENDEOBGIMGA;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x67E6320", Offset = "0x67E5120", VA = "0x1867E6320")]
	public CHOOGPOECKC(IEnumerable<TData> POIMBCOJFJM, string GKJABGINPJG, bool BLJNGPBCBIK, bool BKJIDHCCBMN, KBLNIFDLNPL<TData> JBODBHEGPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x4811340", Offset = "0x4810140", VA = "0x184811340", Slot = "4")]
	public override bool BFLCGMAIILH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public abstract class CFCKCAJKCHC<TReceiver> : AMIMGNAEHFP<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4C88B70", Offset = "0x4C87970", VA = "0x184C88B70")]
	public CFCKCAJKCHC(TReceiver JBODBHEGPEF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class OCBFOOLPHBP<TReceiver, TFromTask> : AMIMGNAEHFP<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4C88B70", Offset = "0x4C87970", VA = "0x184C88B70")]
	public OCBFOOLPHBP(TReceiver JBODBHEGPEF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class AMIMGNAEHFP<TReceiver, TFromExecute> where TReceiver : notnull where TFromExecute : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	protected TReceiver JBODBHEGPEF;

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x50BBC80", Offset = "0x50BAA80", VA = "0x1850BBC80")]
	public AMIMGNAEHFP(TReceiver JBODBHEGPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute BFLCGMAIILH();
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public abstract class POLBECELDBC<TReceiver, TResult> : AMIMGNAEHFP<TReceiver, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4C88B70", Offset = "0x4C87970", VA = "0x184C88B70")]
	public POLBECELDBC(TReceiver JBODBHEGPEF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct OMELIFBGEAL<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public TGroup IGBIPDGALJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public TData KJGCFMOLKGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public IEnumerable<TData> CPIFAHNDOPF;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1D416E0", Offset = "0x1D404E0", VA = "0x181D416E0")]
	public OMELIFBGEAL(TGroup CGALOHLFCOF, TData PNAMNEPAOON, IEnumerable<TData> POIMBCOJFJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct DPCDAPAMCEO<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public TGroup IGBIPDGALJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public IEnumerable<TData> CPIFAHNDOPF;

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0xBC8270", Offset = "0xBC7070", VA = "0x180BC8270")]
	public DPCDAPAMCEO(TGroup CGALOHLFCOF, IEnumerable<TData> POIMBCOJFJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct FJNMIOKLLIO<TGroup> where TGroup : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public TGroup IGBIPDGALJO;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0xE3B7E0", Offset = "0xE3A5E0", VA = "0x180E3B7E0")]
	public FJNMIOKLLIO(TGroup CGALOHLFCOF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public struct HIKPDIDAKHC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public IEnumerable<Guid> CPIFAHNDOPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public Guid EMGOMHFMCCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly bool NKIDMMLLDJO;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x81194F0", Offset = "0x81182F0", VA = "0x1881194F0")]
	public HIKPDIDAKHC(IEnumerable<Guid> POIMBCOJFJM, Guid POBMLBDCHMJ, bool BKJIDHCCBMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct BAAILMNHIPP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public Guid EMGOMHFMCCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly bool NKIDMMLLDJO;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2833A90", Offset = "0x2832890", VA = "0x182833A90")]
	public BAAILMNHIPP(Guid POBMLBDCHMJ, bool BKJIDHCCBMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface PKEHBPBAFLB<TGroup, TData>
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MGECJCILIOI OANBHMDPBMB(OMELIFBGEAL<TGroup, TData> FFMBGHKJBKJ);

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MGECJCILIOI EPPOKGNGDFI(OMELIFBGEAL<TGroup, TData> FFMBGHKJBKJ);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MGECJCILIOI GFBLNDEFKDC(DPCDAPAMCEO<TGroup, TData> FFMBGHKJBKJ);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MGECJCILIOI CMECBOODHLI(FJNMIOKLLIO<TGroup> FFMBGHKJBKJ);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface HMOLCLAPFMK
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<MGECJCILIOI> OANBHMDPBMB(HIKPDIDAKHC FFMBGHKJBKJ);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<MGECJCILIOI> EPPOKGNGDFI(BAAILMNHIPP FFMBGHKJBKJ);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class JPOGGAFKOAD<TGroup, TData> : POLBECELDBC<PKEHBPBAFLB<TGroup, TData>, MGECJCILIOI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly DPCDAPAMCEO<TGroup, TData> FFMBGHKJBKJ;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x51F8D70", Offset = "0x51F7B70", VA = "0x1851F8D70")]
	public JPOGGAFKOAD(TGroup CGALOHLFCOF, IEnumerable<TData> POIMBCOJFJM, PKEHBPBAFLB<TGroup, TData> JBODBHEGPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x51F8CA0", Offset = "0x51F7AA0", VA = "0x1851F8CA0", Slot = "4")]
	public override MGECJCILIOI BFLCGMAIILH()
	{
		return default(MGECJCILIOI);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class MBLAHADEPPO<TGroup, TData> : POLBECELDBC<PKEHBPBAFLB<TGroup, TData>, MGECJCILIOI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly OMELIFBGEAL<TGroup, TData> FFMBGHKJBKJ;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x483AB50", Offset = "0x4839950", VA = "0x18483AB50")]
	public MBLAHADEPPO(TGroup CGALOHLFCOF, TData FPMOGKBJEHA, IEnumerable<TData> POIMBCOJFJM, PKEHBPBAFLB<TGroup, TData> JBODBHEGPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x56512F0", Offset = "0x56500F0", VA = "0x1856512F0", Slot = "4")]
	public override MGECJCILIOI BFLCGMAIILH()
	{
		return default(MGECJCILIOI);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class HGFDKEAOMJO<TGroup, TData> : POLBECELDBC<PKEHBPBAFLB<TGroup, TData>, MGECJCILIOI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly FJNMIOKLLIO<TGroup> FFMBGHKJBKJ;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x4824100", Offset = "0x4822F00", VA = "0x184824100")]
	public HGFDKEAOMJO(TGroup CGALOHLFCOF, PKEHBPBAFLB<TGroup, TData> JBODBHEGPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x4E20260", Offset = "0x4E1F060", VA = "0x184E20260", Slot = "4")]
	public override MGECJCILIOI BFLCGMAIILH()
	{
		return default(MGECJCILIOI);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class EMEAECGKIOA<TGroup, TData> : POLBECELDBC<PKEHBPBAFLB<TGroup, TData>, MGECJCILIOI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly OMELIFBGEAL<TGroup, TData> FFMBGHKJBKJ;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x483AB50", Offset = "0x4839950", VA = "0x18483AB50")]
	public EMEAECGKIOA(TGroup CGALOHLFCOF, TData PNAMNEPAOON, IEnumerable<TData> POIMBCOJFJM, PKEHBPBAFLB<TGroup, TData> JBODBHEGPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x483AA70", Offset = "0x4839870", VA = "0x18483AA70", Slot = "4")]
	public override MGECJCILIOI BFLCGMAIILH()
	{
		return default(MGECJCILIOI);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class DJAPJNFLAHP : OCBFOOLPHBP<HMOLCLAPFMK, MGECJCILIOI>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private struct OFGEHAHAPOK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public AsyncTaskMethodBuilder<MGECJCILIOI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public DJAPJNFLAHP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private TaskAwaiter<MGECJCILIOI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8119C40", Offset = "0x8118A40", VA = "0x188119C40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8119EE0", Offset = "0x8118CE0", VA = "0x188119EE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private HIKPDIDAKHC FFMBGHKJBKJ;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x8118F60", Offset = "0x8117D60", VA = "0x188118F60")]
	public DJAPJNFLAHP(IEnumerable<Guid> NLBDICIHNOO, Guid POBMLBDCHMJ, bool BKJIDHCCBMN, HMOLCLAPFMK JBODBHEGPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x8118E70", Offset = "0x8117C70", VA = "0x188118E70", Slot = "4")]
	[AsyncStateMachine(typeof(OFGEHAHAPOK))]
	public override Task<MGECJCILIOI> BFLCGMAIILH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class GKPCHOCKLMH : OCBFOOLPHBP<HMOLCLAPFMK, MGECJCILIOI>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private struct LCNNIPMJOLL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public AsyncTaskMethodBuilder<MGECJCILIOI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public GKPCHOCKLMH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private TaskAwaiter<MGECJCILIOI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8119740", Offset = "0x8118540", VA = "0x188119740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x81199E0", Offset = "0x81187E0", VA = "0x1881199E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly BAAILMNHIPP FFMBGHKJBKJ;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x8119240", Offset = "0x8118040", VA = "0x188119240")]
	public GKPCHOCKLMH(Guid POBMLBDCHMJ, bool BKJIDHCCBMN, HMOLCLAPFMK JBODBHEGPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x8119150", Offset = "0x8117F50", VA = "0x188119150", Slot = "4")]
	[AsyncStateMachine(typeof(LCNNIPMJOLL))]
	public override Task<MGECJCILIOI> BFLCGMAIILH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public readonly struct FCPMHKMEBGH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly MJJCHDEFLOO EFGAIJGOLIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly bool NKIDMMLLDJO;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x8119060", Offset = "0x8117E60", VA = "0x188119060")]
	public FCPMHKMEBGH(MJJCHDEFLOO ALFJPAOGOAF, bool BKJIDHCCBMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface HHPEPLGEFME<TSpawnType> where TSpawnType : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> BFLCGMAIILH(FCPMHKMEBGH LAFPBAJEIMG);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class HEPIIDANIEC<TSpawnType> : OCBFOOLPHBP<HHPEPLGEFME<TSpawnType>, TSpawnType> where TSpawnType : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct BDAGEKNADJF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public AsyncTaskMethodBuilder<TSpawnType> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public HEPIIDANIEC<TSpawnType> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<TSpawnType> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x624EA00", Offset = "0x624D800", VA = "0x18624EA00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x4814330", Offset = "0x4813130", VA = "0x184814330", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly FCPMHKMEBGH LAFPBAJEIMG;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x4E1EE00", Offset = "0x4E1DC00", VA = "0x184E1EE00")]
	public HEPIIDANIEC(MJJCHDEFLOO ALFJPAOGOAF, bool BKJIDHCCBMN, HHPEPLGEFME<TSpawnType> JBODBHEGPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x4E1EB00", Offset = "0x4E1D900", VA = "0x184E1EB00", Slot = "4")]
	[AsyncStateMachine(typeof(HEPIIDANIEC<>.BDAGEKNADJF))]
	public override Task<TSpawnType> BFLCGMAIILH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public readonly struct MJJCHDEFLOO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly bool MEABCEJNKBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly Vector3 INBOMLEDLJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly Vector3 BKNMJONCLIJ;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x8119B50", Offset = "0x8118950", VA = "0x188119B50")]
	public MJJCHDEFLOO(Transform ECGNFNJIFON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8119A90", Offset = "0x8118890", VA = "0x188119A90")]
	public MJJCHDEFLOO(Vector3 LCJFLGICHDD, Vector3 EMECBHNHILC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8119A60", Offset = "0x8118860", VA = "0x188119A60")]
	public static MJJCHDEFLOO AJBMEKOGIKE()
	{
		return default(MJJCHDEFLOO);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8119AC0", Offset = "0x81188C0", VA = "0x188119AC0")]
	private MJJCHDEFLOO(bool JNBGHDPIPDB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct KLLEFFLJFCA<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public TNode BMEDLCFKLND;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x52E6CD0", Offset = "0x52E5AD0", VA = "0x1852E6CD0")]
	public KLLEFFLJFCA(TNode BMEDLCFKLND)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct DBFNOCECAPN<TNode, TReparentOperations> where TNode : notnull where TReparentOperations : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public TNode PNKCGMJBCAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public TReparentOperations MGMIGNAEADN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public JPPFOBHFGAG KGDIKAMMLPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly bool NKIDMMLLDJO;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6DC50C0", Offset = "0x6DC3EC0", VA = "0x186DC50C0")]
	public DBFNOCECAPN(TNode PNKCGMJBCAN, TReparentOperations MGMIGNAEADN, JPPFOBHFGAG KGDIKAMMLPG, bool BKJIDHCCBMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface HIFGANDMEKB<TNode, TReparentOperations>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BOJOFBDJIJO([In] KLLEFFLJFCA<TNode> KPFGCDGEJGH);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GGIMOPEPJGO([In] DBFNOCECAPN<TNode, TReparentOperations> BBMDOFMNEKL);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JCEIGPKMHDM();
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class HKAFDNHFEKN<TNode, TReparentOperations> : CFCKCAJKCHC<HIFGANDMEKB<TNode, TReparentOperations>>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x4C88B70", Offset = "0x4C87970", VA = "0x184C88B70")]
	public HKAFDNHFEKN(HIFGANDMEKB<TNode, TReparentOperations> JBODBHEGPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x4D7F5B0", Offset = "0x4D7E3B0", VA = "0x184D7F5B0", Slot = "4")]
	public override bool BFLCGMAIILH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class JHIEHMLAKBJ<TNode, TReparentOperations> : CFCKCAJKCHC<HIFGANDMEKB<TNode, TReparentOperations>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly DBFNOCECAPN<TNode, TReparentOperations> BBMDOFMNEKL;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x51A9240", Offset = "0x51A8040", VA = "0x1851A9240")]
	public JHIEHMLAKBJ(TNode PNKCGMJBCAN, TReparentOperations MGMIGNAEADN, JPPFOBHFGAG KGDIKAMMLPG, HIFGANDMEKB<TNode, TReparentOperations> JBODBHEGPEF, bool BKJIDHCCBMN = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x51A9170", Offset = "0x51A7F70", VA = "0x1851A9170", Slot = "4")]
	public override bool BFLCGMAIILH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class LHGAOMEOLCF<TNode, TReparentOperations> : CFCKCAJKCHC<HIFGANDMEKB<TNode, TReparentOperations>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly KLLEFFLJFCA<TNode> KPFGCDGEJGH;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5425B00", Offset = "0x5424900", VA = "0x185425B00")]
	public LHGAOMEOLCF(TNode AEAGFGNCODJ, HIFGANDMEKB<TNode, TReparentOperations> JBODBHEGPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x4811340", Offset = "0x4810140", VA = "0x184811340", Slot = "4")]
	public override bool BFLCGMAIILH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct CKOMHEDFNLF<TSpawnInfo> where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public TSpawnInfo IJMEEEMOAFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public Vector3 EMECBHNHILC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public Quaternion NOLDGDLLBBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public float AMJKMJIBGNI;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x68034B0", Offset = "0x68022B0", VA = "0x1868034B0")]
	public CKOMHEDFNLF(TSpawnInfo IJMEEEMOAFB, Vector3 EMECBHNHILC, Quaternion NOLDGDLLBBL, float AMJKMJIBGNI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface OHBDEEGACAF<TSpawnType, TSpawnInfo>
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> PGMHGHLKEFN([In] CKOMHEDFNLF<TSpawnInfo> FKMALPPJHPK, CancellationToken HIMDFBHMPLL);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class MOJFGINALEG<TSpawnType, TSpawnInfo> : OCBFOOLPHBP<OHBDEEGACAF<TSpawnType, TSpawnInfo>, TSpawnType> where TSpawnType : notnull where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly CKOMHEDFNLF<TSpawnInfo> ENDEOBGIMGA;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x568A2E0", Offset = "0x56890E0", VA = "0x18568A2E0")]
	public MOJFGINALEG(TSpawnInfo DILPDMDGKDD, Vector3 EMECBHNHILC, Quaternion NOLDGDLLBBL, float AMJKMJIBGNI, OHBDEEGACAF<TSpawnType, TSpawnInfo> JBODBHEGPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x568A100", Offset = "0x5688F00", VA = "0x18568A100", Slot = "4")]
	public override Task<TSpawnType> BFLCGMAIILH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public readonly struct FPPFJFEJIFM<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly IEnumerable<TData> CPIFAHNDOPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly bool NKIDMMLLDJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly bool EGOJHHGFJEE;

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x4CE5DB0", Offset = "0x4CE4BB0", VA = "0x184CE5DB0")]
	public FPPFJFEJIFM(IEnumerable<TData> POIMBCOJFJM, bool BKJIDHCCBMN = false, bool NOJFOOMFAOO = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface ACNOPPDPPIK<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<MGECJCILIOI> LJINCNKJDGN([In] FPPFJFEJIFM<TData> PFKHGKJJPJK, CancellationToken HIMDFBHMPLL);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class DHJECCOBIMI<TData> : OCBFOOLPHBP<ACNOPPDPPIK<TData>, MGECJCILIOI> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly FPPFJFEJIFM<TData> JLAMABNCCFJ;

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6DE71B0", Offset = "0x6DE5FB0", VA = "0x186DE71B0")]
	public DHJECCOBIMI(IEnumerable<TData> POIMBCOJFJM, bool BKJIDHCCBMN, ACNOPPDPPIK<TData> JBODBHEGPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x568A100", Offset = "0x5688F00", VA = "0x18568A100", Slot = "4")]
	public override Task<MGECJCILIOI> BFLCGMAIILH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct PKOPCCGKDKL<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly T IMBAOPHEODM;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x4F0DDB0", Offset = "0x4F0CBB0", VA = "0x184F0DDB0")]
	public PKOPCCGKDKL(T NEPKHECPKIO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface PFOEMBKKBCP<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BOJOFBDJIJO([In] PKOPCCGKDKL<T> GNOOGFCOFJA);

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GGIMOPEPJGO();
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface MNOALIJGGCB<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BFLCGMAIILH([In] FBPDJLEMENJ<T> PKFKDMPFAJA);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public struct FBPDJLEMENJ<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly T IMBAOPHEODM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly bool PJEKLODBEAO;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x4C94630", Offset = "0x4C93430", VA = "0x184C94630")]
	public FBPDJLEMENJ(T NEPKHECPKIO, bool APNBOJAFJCI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class IEAJJKEBHKI<T> : CFCKCAJKCHC<PFOEMBKKBCP<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x4C88B70", Offset = "0x4C87970", VA = "0x184C88B70")]
	public IEAJJKEBHKI(PFOEMBKKBCP<T> JBODBHEGPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x4F14860", Offset = "0x4F13660", VA = "0x184F14860", Slot = "4")]
	public override bool BFLCGMAIILH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class EIBBPEIEJKB<T> : CFCKCAJKCHC<PFOEMBKKBCP<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly PKOPCCGKDKL<T> GNOOGFCOFJA;

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x4824170", Offset = "0x4822F70", VA = "0x184824170")]
	public EIBBPEIEJKB(T IMBAOPHEODM, PFOEMBKKBCP<T> JBODBHEGPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x4811340", Offset = "0x4810140", VA = "0x184811340", Slot = "4")]
	public override bool BFLCGMAIILH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class NFAOGABIMCE<T> : CFCKCAJKCHC<MNOALIJGGCB<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly FBPDJLEMENJ<T> PKFKDMPFAJA;

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x56D6A60", Offset = "0x56D5860", VA = "0x1856D6A60")]
	public NFAOGABIMCE(T IMBAOPHEODM, bool APNBOJAFJCI, MNOALIJGGCB<T> JBODBHEGPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x4811340", Offset = "0x4810140", VA = "0x184811340", Slot = "4")]
	public override bool BFLCGMAIILH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public struct FAJMDODBOMC<TData> where TData : notnull, NBFOLJDGKNO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public IEnumerable<TData> CPIFAHNDOPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public bool MLCJGBJIKGO;

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x4C8DFF0", Offset = "0x4C8CDF0", VA = "0x184C8DFF0")]
	public FAJMDODBOMC(IEnumerable<TData> HFFALMDOJNI, bool JKFHMIEABEK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct PMDHANHCFMA<TData> where TData : notnull, NBFOLJDGKNO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public List<TData> CPIFAHNDOPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public List<bool> AOPGEMEDNGN;

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x59CB890", Offset = "0x59CA690", VA = "0x1859CB890")]
	public PMDHANHCFMA(List<TData> HFFALMDOJNI, List<bool> MIIAPPADAGL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface NBFOLJDGKNO
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool NLBBMOPNOJF
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
public interface KMJOFJMHFDA<TData> where TData : NBFOLJDGKNO
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BFLCGMAIILH([In] FAJMDODBOMC<TData> GOKKEJIGOLI);

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BFLCGMAIILH([In] PMDHANHCFMA<TData> GOKKEJIGOLI);
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface LKJBJCPBPEH<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NBJJPFOHNDB(T IMBAOPHEODM);
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class ANALADJEKCC<TData> : CFCKCAJKCHC<KMJOFJMHFDA<TData>> where TData : notnull, NBFOLJDGKNO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly FAJMDODBOMC<TData> GOKKEJIGOLI;

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x50BFC90", Offset = "0x50BEA90", VA = "0x1850BFC90")]
	public ANALADJEKCC(List<TData> POIMBCOJFJM, bool MLCJGBJIKGO, KMJOFJMHFDA<TData> JBODBHEGPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x4811340", Offset = "0x4810140", VA = "0x184811340", Slot = "4")]
	public override bool BFLCGMAIILH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public class CDEPOFALPAB<TData> : CFCKCAJKCHC<KMJOFJMHFDA<TData>> where TData : notnull, NBFOLJDGKNO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly PMDHANHCFMA<TData> GOKKEJIGOLI;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6709210", Offset = "0x6708010", VA = "0x186709210")]
	public CDEPOFALPAB(List<TData> POIMBCOJFJM, List<bool> AOPGEMEDNGN, KMJOFJMHFDA<TData> JBODBHEGPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6709150", Offset = "0x6707F50", VA = "0x186709150", Slot = "4")]
	public override bool BFLCGMAIILH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public interface BDEMILEHIEE<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<MGECJCILIOI> BFLCGMAIILH(BFLNIJAAOOI<TData> JMNCPKLKNHI);
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class AANGIHCHOGC<TData> : OCBFOOLPHBP<BDEMILEHIEE<TData>, MGECJCILIOI> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private struct OCDBGGDNBKI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public AsyncTaskMethodBuilder<MGECJCILIOI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public AANGIHCHOGC<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private TaskAwaiter<MGECJCILIOI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x5845A60", Offset = "0x5844860", VA = "0x185845A60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5845D50", Offset = "0x5844B50", VA = "0x185845D50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly BFLNIJAAOOI<TData> COFDONBPEIO;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4E9F020", Offset = "0x4E9DE20", VA = "0x184E9F020")]
	public AANGIHCHOGC(TData DEPPHMAJHDP, IReadOnlyList<TData> PKDNHLIKDBC, bool BKJIDHCCBMN, BDEMILEHIEE<TData> JBODBHEGPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x4E9EF20", Offset = "0x4E9DD20", VA = "0x184E9EF20", Slot = "4")]
	[AsyncStateMachine(typeof(AANGIHCHOGC<>.OCDBGGDNBKI))]
	public override Task<MGECJCILIOI> BFLCGMAIILH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public struct BFLNIJAAOOI<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public TData INLMJGOGBCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public IReadOnlyList<TData> PCACNDLIOHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public bool NKIDMMLLDJO;

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2F24580", Offset = "0x2F23380", VA = "0x182F24580")]
	public BFLNIJAAOOI(TData DEPPHMAJHDP, IReadOnlyList<TData> PKDNHLIKDBC, bool BKJIDHCCBMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public interface BHJADOBKLNC<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BFLCGMAIILH([In] EEMCDMPBOJD<TData> JFFPPCFJCLM);
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface CMDNOCHJAMG<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BFLCGMAIILH([In] CDKJMAKKKHJ<TData> JFFPPCFJCLM);
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface GLCLEDNEHAC<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DDNBFJLBJLF([In] NCGFAFONONB<TData> JFFPPCFJCLM);

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GGIMOPEPJGO();
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class AJCBPKLOEJB<TData> : CFCKCAJKCHC<BHJADOBKLNC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly EEMCDMPBOJD<TData> JFFPPCFJCLM;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x4FE3220", Offset = "0x4FE2020", VA = "0x184FE3220")]
	public AJCBPKLOEJB(IEnumerable<TData> POIMBCOJFJM, AOKFBPFAEAA PFKMCINIKNC, PLHKBDHNDHI KKBOKCGIENM, float HHOICDFCKKO, string? GKJABGINPJG, bool BGBMGFKBBHL, bool BKJIDHCCBMN, BHJADOBKLNC<TData> JBODBHEGPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x4811340", Offset = "0x4810140", VA = "0x184811340", Slot = "4")]
	public override bool BFLCGMAIILH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class PPGMFOLIKIG<TData> : CFCKCAJKCHC<CMDNOCHJAMG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly CDKJMAKKKHJ<TData> JFFPPCFJCLM;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x59D0490", Offset = "0x59CF290", VA = "0x1859D0490")]
	public PPGMFOLIKIG(TData[] POIMBCOJFJM, AOKFBPFAEAA[] PFKMCINIKNC, PLHKBDHNDHI[] KKBOKCGIENM, float[] HHOICDFCKKO, CMDNOCHJAMG<TData> JBODBHEGPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x570BC80", Offset = "0x570AA80", VA = "0x18570BC80", Slot = "4")]
	public override bool BFLCGMAIILH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class DPIPJJCLLOE<TData> : CFCKCAJKCHC<GLCLEDNEHAC<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x4C88B70", Offset = "0x4C87970", VA = "0x184C88B70")]
	public DPIPJJCLLOE(GLCLEDNEHAC<TData> JBODBHEGPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6E247B0", Offset = "0x6E235B0", VA = "0x186E247B0", Slot = "4")]
	public override bool BFLCGMAIILH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class NMBCGPGIADP<TData> : CFCKCAJKCHC<GLCLEDNEHAC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly NCGFAFONONB<TData> JFFPPCFJCLM;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x570BD40", Offset = "0x570AB40", VA = "0x18570BD40")]
	public NMBCGPGIADP(IEnumerable<TData> POIMBCOJFJM, AOKFBPFAEAA PFKMCINIKNC, PLHKBDHNDHI KKBOKCGIENM, float HHOICDFCKKO, GLCLEDNEHAC<TData> JBODBHEGPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x570BC80", Offset = "0x570AA80", VA = "0x18570BC80", Slot = "4")]
	public override bool BFLCGMAIILH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public struct EEMCDMPBOJD<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public IEnumerable<TData> CPIFAHNDOPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public AOKFBPFAEAA JEKBJHDPEMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public PLHKBDHNDHI OHKKCFOKAEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public float DBMGMMPBOML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public string? POFMCMPHBJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public bool? JMOAJFPBBAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public bool NKIDMMLLDJO;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x48143D0", Offset = "0x48131D0", VA = "0x1848143D0")]
	public EEMCDMPBOJD(IEnumerable<TData> POIMBCOJFJM, AOKFBPFAEAA PFKMCINIKNC, PLHKBDHNDHI KKBOKCGIENM, float HHOICDFCKKO, string? GKJABGINPJG, bool? BGBMGFKBBHL, bool BKJIDHCCBMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct CDKJMAKKKHJ<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public TData[] CPIFAHNDOPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public AOKFBPFAEAA[] JEKBJHDPEMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public PLHKBDHNDHI[] OHKKCFOKAEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public float[] HHOICDFCKKO;

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x670A030", Offset = "0x6708E30", VA = "0x18670A030")]
	public CDKJMAKKKHJ(TData[] POIMBCOJFJM, AOKFBPFAEAA[] PFKMCINIKNC, PLHKBDHNDHI[] KKBOKCGIENM, float[] HHOICDFCKKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public struct NCGFAFONONB<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public IEnumerable<TData> CPIFAHNDOPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public AOKFBPFAEAA JEKBJHDPEMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public PLHKBDHNDHI OHKKCFOKAEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public float HHOICDFCKKO;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x56D1700", Offset = "0x56D0500", VA = "0x1856D1700")]
	public NCGFAFONONB(IEnumerable<TData> POIMBCOJFJM, AOKFBPFAEAA PFKMCINIKNC, PLHKBDHNDHI KKBOKCGIENM, float HHOICDFCKKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface ABMJOJGJNEJ<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GFBLNDEFKDC([In] CCDDDEPCBIP<TData> PFKHGKJJPJK);

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CMECBOODHLI([In] CCDDDEPCBIP<TData> PFKHGKJJPJK);

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MKKAMGPILCJ([In] bool CICHBLIKABH);

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JLAPMPIMHEB([In] CCDDDEPCBIP<TData> PFKHGKJJPJK);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AEHFDBLFDDF();

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool FNPFDLAJHLJ([In] TData BOHNAEMOBFE);
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class INPJCNFAJAA<TData> : CFCKCAJKCHC<ABMJOJGJNEJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly CCDDDEPCBIP<TData> PFKHGKJJPJK;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x4F7A580", Offset = "0x4F79380", VA = "0x184F7A580")]
	public INPJCNFAJAA(List<TData> HPGGKMKJGLJ, ABMJOJGJNEJ<TData> JBODBHEGPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x4811340", Offset = "0x4810140", VA = "0x184811340", Slot = "4")]
	public override bool BFLCGMAIILH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class FFOAMAKKIBP<TData> : CFCKCAJKCHC<ABMJOJGJNEJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4C88B70", Offset = "0x4C87970", VA = "0x184C88B70")]
	public FFOAMAKKIBP(ABMJOJGJNEJ<TData> JBODBHEGPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x4CA7700", Offset = "0x4CA6500", VA = "0x184CA7700", Slot = "4")]
	public override bool BFLCGMAIILH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class EIOLDCLCLME<TData> : CFCKCAJKCHC<ABMJOJGJNEJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly bool BKJIDHCCBMN;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x48299C0", Offset = "0x48287C0", VA = "0x1848299C0")]
	public EIOLDCLCLME(bool BKJIDHCCBMN, ABMJOJGJNEJ<TData> JBODBHEGPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x4829960", Offset = "0x4828760", VA = "0x184829960", Slot = "4")]
	public override bool BFLCGMAIILH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class DLNDMLBPOON<TData> : CFCKCAJKCHC<ABMJOJGJNEJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly CCDDDEPCBIP<TData> PFKHGKJJPJK;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6E09830", Offset = "0x6E08630", VA = "0x186E09830")]
	public DLNDMLBPOON(List<TData> HPGGKMKJGLJ, bool BKJIDHCCBMN, ABMJOJGJNEJ<TData> JBODBHEGPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6709150", Offset = "0x6707F50", VA = "0x186709150", Slot = "4")]
	public override bool BFLCGMAIILH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class DPJKGCPEAFM<TData> : CFCKCAJKCHC<ABMJOJGJNEJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly TData BOHNAEMOBFE;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6E24980", Offset = "0x6E23780", VA = "0x186E24980")]
	public DPJKGCPEAFM(TData BOHNAEMOBFE, ABMJOJGJNEJ<TData> JBODBHEGPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6E24800", Offset = "0x6E23600", VA = "0x186E24800", Slot = "4")]
	public override bool BFLCGMAIILH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class FIOHAFFPOMD<TData> : CFCKCAJKCHC<ABMJOJGJNEJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly CCDDDEPCBIP<TData> PFKHGKJJPJK;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x4CB9030", Offset = "0x4CB7E30", VA = "0x184CB9030")]
	public FIOHAFFPOMD(IEnumerable<TData> HPGGKMKJGLJ, ABMJOJGJNEJ<TData> JBODBHEGPEF, bool BKJIDHCCBMN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x4CB8EC0", Offset = "0x4CB7CC0", VA = "0x184CB8EC0", Slot = "4")]
	public override bool BFLCGMAIILH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public struct CCDDDEPCBIP<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public IEnumerable<TData> CPIFAHNDOPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public bool BKJIDHCCBMN;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6708230", Offset = "0x6707030", VA = "0x186708230")]
	public CCDDDEPCBIP(IEnumerable<TData> HFFALMDOJNI, bool CEMMMFIBCPN = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public interface CNCGCLHJBHD
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<MGECJCILIOI> BFLCGMAIILH(ADGNFCBLAID COLBACBLBLA);
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class CLENOMNNMCF : OCBFOOLPHBP<CNCGCLHJBHD, MGECJCILIOI>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private struct BJACKMKGFPP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public AsyncTaskMethodBuilder<MGECJCILIOI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public CLENOMNNMCF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private TaskAwaiter<MGECJCILIOI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x8118660", Offset = "0x8117460", VA = "0x188118660", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x81188D0", Offset = "0x81176D0", VA = "0x1881188D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly ADGNFCBLAID JABEBJODPHL;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x8118E10", Offset = "0x8117C10", VA = "0x188118E10")]
	public CLENOMNNMCF(bool BKJIDHCCBMN, CNCGCLHJBHD JBODBHEGPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x8118D20", Offset = "0x8117B20", VA = "0x188118D20", Slot = "4")]
	[AsyncStateMachine(typeof(BJACKMKGFPP))]
	public override Task<MGECJCILIOI> BFLCGMAIILH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public struct ADGNFCBLAID
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public bool NKIDMMLLDJO;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x2C0E250", Offset = "0x2C0D050", VA = "0x182C0E250")]
	public ADGNFCBLAID(bool BKJIDHCCBMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public readonly struct LMLFOKMHFFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public readonly bool AEHNEHJCNEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public readonly bool NHGCMMMEALE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public readonly bool AMJKMJIBGNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public readonly bool BKJIDHCCBMN;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6032940", Offset = "0x6031740", VA = "0x186032940")]
	public LMLFOKMHFFG(bool AEHNEHJCNEO, bool NHGCMMMEALE, bool AMJKMJIBGNI, bool BKJIDHCCBMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x8119A50", Offset = "0x8118850", VA = "0x188119A50")]
	public LMLFOKMHFFG(bool NHGCMMMEALE, bool BKJIDHCCBMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public interface KANJHHFLOBA
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KMFCIPDDJMG(LMLFOKMHFFG KLBALEHPNDC);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GECDFEMKFCD(LMLFOKMHFFG KLBALEHPNDC);
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public class JBAIIOCGKGK : CFCKCAJKCHC<KANJHHFLOBA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly LMLFOKMHFFG KLBALEHPNDC;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x81195A0", Offset = "0x81183A0", VA = "0x1881195A0")]
	public JBAIIOCGKGK(bool OLPMPAIMKPI, bool NHGCMMMEALE, bool AMJKMJIBGNI, bool BKJIDHCCBMN, KANJHHFLOBA JBODBHEGPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x8119550", Offset = "0x8118350", VA = "0x188119550", Slot = "4")]
	public override bool BFLCGMAIILH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class GHKKCGNJJPG : CFCKCAJKCHC<KANJHHFLOBA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly LMLFOKMHFFG KLBALEHPNDC;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x81190D0", Offset = "0x8117ED0", VA = "0x1881190D0")]
	public GHKKCGNJJPG(bool NHGCMMMEALE, bool BKJIDHCCBMN, KANJHHFLOBA JBODBHEGPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x8119080", Offset = "0x8117E80", VA = "0x188119080", Slot = "4")]
	public override bool BFLCGMAIILH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public interface IOLCBCDNCBN
{
	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BFLCGMAIILH([In] BEDJLODBOIH AGCILJDOHKH);
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class BAPMKEOOEJO : CFCKCAJKCHC<IOLCBCDNCBN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly BEDJLODBOIH AGCILJDOHKH;

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x8118020", Offset = "0x8116E20", VA = "0x188118020")]
	public BAPMKEOOEJO(Guid[] IJBGNFPMJGC, Vector3[] FEIJPGONCAA, Quaternion[] BBNIGIMEEAM, float[] PKPABBHDCPJ, Dictionary<Guid, Vector3> DELFOGIDMID, IOLCBCDNCBN JBODBHEGPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x8117F70", Offset = "0x8116D70", VA = "0x188117F70", Slot = "4")]
	public override bool BFLCGMAIILH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public interface EDECAABFNNE<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BOJOFBDJIJO([In] EDONLPMKBCI<TData> KPFGCDGEJGH);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DDNBFJLBJLF([In] AOCHCMOGEKN AECIDCBIEJK);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DDNBFJLBJLF([In] BADBNPDHJKC AECIDCBIEJK);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool GGIMOPEPJGO();
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class HOKJKCEBLFJ<TData> : CFCKCAJKCHC<EDECAABFNNE<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x4C88B70", Offset = "0x4C87970", VA = "0x184C88B70")]
	public HOKJKCEBLFJ(EDECAABFNNE<TData> JBODBHEGPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x4E47750", Offset = "0x4E46550", VA = "0x184E47750", Slot = "4")]
	public override bool BFLCGMAIILH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public class GKNEFHBIHNG<TData> : CFCKCAJKCHC<EDECAABFNNE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly AOCHCMOGEKN LNANEFNNCKH;

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x4D9B670", Offset = "0x4D9A470", VA = "0x184D9B670")]
	public GKNEFHBIHNG(Vector3 FOFNIAOJNLK, bool LHEEJJNNHIC, EDECAABFNNE<TData> JBODBHEGPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x4D9B610", Offset = "0x4D9A410", VA = "0x184D9B610", Slot = "4")]
	public override bool BFLCGMAIILH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class IIFCEKGHGOH<TData> : CFCKCAJKCHC<EDECAABFNNE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly BADBNPDHJKC LNANEFNNCKH;

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x4F1EEB0", Offset = "0x4F1DCB0", VA = "0x184F1EEB0")]
	public IIFCEKGHGOH(Guid OMJGBFLMECJ, int CKFKPOAGPKN, Vector3 EMECBHNHILC, Quaternion NOLDGDLLBBL, float LNLGAMEGNNM, bool LHEEJJNNHIC, EDECAABFNNE<TData> JBODBHEGPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x4F1EE50", Offset = "0x4F1DC50", VA = "0x184F1EE50", Slot = "4")]
	public override bool BFLCGMAIILH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class GJAEPFCAKBN<TData> : CFCKCAJKCHC<EDECAABFNNE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly EDONLPMKBCI<TData> LNANEFNNCKH;

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x4D944D0", Offset = "0x4D932D0", VA = "0x184D944D0")]
	public GJAEPFCAKBN(TData IMBAOPHEODM, bool BKJIDHCCBMN, EDECAABFNNE<TData> JBODBHEGPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x4811340", Offset = "0x4810140", VA = "0x184811340", Slot = "4")]
	public override bool BFLCGMAIILH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct AOCHCMOGEKN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public readonly Vector3 FOFNIAOJNLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public readonly bool LHEEJJNNHIC;

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x8117F10", Offset = "0x8116D10", VA = "0x188117F10")]
	public AOCHCMOGEKN(Vector3 FOFNIAOJNLK, bool LHEEJJNNHIC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public struct BADBNPDHJKC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public readonly Guid OMJGBFLMECJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public readonly int CKFKPOAGPKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public readonly Vector3 EMECBHNHILC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public readonly Quaternion NOLDGDLLBBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly float LNLGAMEGNNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public readonly bool LHEEJJNNHIC;

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x8117F30", Offset = "0x8116D30", VA = "0x188117F30")]
	public BADBNPDHJKC(Guid OMJGBFLMECJ, int CKFKPOAGPKN, Vector3 EMECBHNHILC, Quaternion NOLDGDLLBBL, float LNLGAMEGNNM, bool LHEEJJNNHIC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public struct EDONLPMKBCI<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public readonly TData IMBAOPHEODM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public readonly bool BKJIDHCCBMN;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x480FE10", Offset = "0x480EC10", VA = "0x18480FE10")]
	public EDONLPMKBCI(TData IMBAOPHEODM, bool BKJIDHCCBMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public interface FMMICKBKGKH<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BFLCGMAIILH([In] IIDCGEDLFPB<TData> GHDLOELMJDN);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BFLCGMAIILH([In] KOMFJDDPMNE<TData> GHDLOELMJDN);
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public interface EPKKANICPOD<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BOJOFBDJIJO([In] HPFKPJPFFHM<TData> NMKOBOEDGHG);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DDNBFJLBJLF([In] DNBDIDIKAHN AECIDCBIEJK);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GGIMOPEPJGO();
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public class LGFFIBEGFNK<TData> : CFCKCAJKCHC<FMMICKBKGKH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly IIDCGEDLFPB<TData> GHDLOELMJDN;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x5424560", Offset = "0x5423360", VA = "0x185424560")]
	public LGFFIBEGFNK(IEnumerable<TData> POIMBCOJFJM, Vector3 JOKKKLCJOPA, bool BKJIDHCCBMN, FMMICKBKGKH<TData> JBODBHEGPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x4811340", Offset = "0x4810140", VA = "0x184811340", Slot = "4")]
	public override bool BFLCGMAIILH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public class GEPLKJPCJNM<TData> : CFCKCAJKCHC<EPKKANICPOD<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x4C88B70", Offset = "0x4C87970", VA = "0x184C88B70")]
	public GEPLKJPCJNM(EPKKANICPOD<TData> JBODBHEGPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x4D7F5B0", Offset = "0x4D7E3B0", VA = "0x184D7F5B0", Slot = "4")]
	public override bool BFLCGMAIILH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class ANOOFJIIJCK<TData> : CFCKCAJKCHC<EPKKANICPOD<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly HPFKPJPFFHM<TData> GHDLOELMJDN;

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x50C7D80", Offset = "0x50C6B80", VA = "0x1850C7D80")]
	public ANOOFJIIJCK(IEnumerable<TData> POIMBCOJFJM, bool BKJIDHCCBMN, EPKKANICPOD<TData> JBODBHEGPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x4811340", Offset = "0x4810140", VA = "0x184811340", Slot = "4")]
	public override bool BFLCGMAIILH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class DNBMKBDHGAH<TData> : CFCKCAJKCHC<FMMICKBKGKH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly KOMFJDDPMNE<TData> GHDLOELMJDN;

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6E1A290", Offset = "0x6E19090", VA = "0x186E1A290")]
	public DNBMKBDHGAH(IEnumerable<TData> POIMBCOJFJM, Vector3 FHHOLMLKAJA, HOFIJEOBLGB MEFGPKGECJA, bool BKJIDHCCBMN, FMMICKBKGKH<TData> JBODBHEGPEF, Space JIDGGLOJNHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x51A9170", Offset = "0x51A7F70", VA = "0x1851A9170", Slot = "4")]
	public override bool BFLCGMAIILH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class BGHCLEMJOOD<TData> : CFCKCAJKCHC<EPKKANICPOD<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly DNBDIDIKAHN GHDLOELMJDN;

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6254360", Offset = "0x6253160", VA = "0x186254360")]
	public BGHCLEMJOOD(Vector3 JOKKKLCJOPA, EPKKANICPOD<TData> JBODBHEGPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x4D9B610", Offset = "0x4D9A410", VA = "0x184D9B610", Slot = "4")]
	public override bool BFLCGMAIILH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public struct IIDCGEDLFPB<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public readonly IEnumerable<TData> POIMBCOJFJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public readonly Vector3 JOKKKLCJOPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public readonly bool BKJIDHCCBMN;

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x4F1E3C0", Offset = "0x4F1D1C0", VA = "0x184F1E3C0")]
	public IIDCGEDLFPB(IEnumerable<TData> POIMBCOJFJM, Vector3 JOKKKLCJOPA, bool BKJIDHCCBMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public struct HPFKPJPFFHM<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public readonly IEnumerable<TData> POIMBCOJFJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public readonly bool BKJIDHCCBMN;

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x4E49670", Offset = "0x4E48470", VA = "0x184E49670")]
	public HPFKPJPFFHM(IEnumerable<TData> POIMBCOJFJM, bool BKJIDHCCBMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public struct KOMFJDDPMNE<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public readonly IEnumerable<TData> POIMBCOJFJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public readonly Vector3 FHHOLMLKAJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public readonly HOFIJEOBLGB MEFGPKGECJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public readonly bool BKJIDHCCBMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public readonly Space JIDGGLOJNHI;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x52F51A0", Offset = "0x52F3FA0", VA = "0x1852F51A0")]
	public KOMFJDDPMNE(IEnumerable<TData> POIMBCOJFJM, Vector3 FHHOLMLKAJA, HOFIJEOBLGB MEFGPKGECJA, bool BKJIDHCCBMN, Space JIDGGLOJNHI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public struct DNBDIDIKAHN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public readonly Vector3 JOKKKLCJOPA;

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x2C0E260", Offset = "0x2C0D060", VA = "0x182C0E260")]
	public DNBDIDIKAHN(Vector3 JOKKKLCJOPA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public enum HOFIJEOBLGB
{
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	XYZ,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	X_only,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	Y_only,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	Z_only
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public interface BPALJPLLFKI
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BFLCGMAIILH([In] HBKHALBCFJH EFGNKNPFMBD);
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public class JMPKBFLDILE : CFCKCAJKCHC<BPALJPLLFKI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private readonly HBKHALBCFJH EFGNKNPFMBD;

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x81196E0", Offset = "0x81184E0", VA = "0x1881196E0")]
	public JMPKBFLDILE(bool BKJIDHCCBMN, BPALJPLLFKI JBODBHEGPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x8119630", Offset = "0x8118430", VA = "0x188119630", Slot = "4")]
	public override bool BFLCGMAIILH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public readonly struct HBKHALBCFJH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public readonly bool BKJIDHCCBMN;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x2C0E250", Offset = "0x2C0D050", VA = "0x182C0E250")]
	public HBKHALBCFJH(bool BKJIDHCCBMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public interface IPNDPDCJJBG<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BFLCGMAIILH([In] DKAJLAJLGKP<TData> FLCPKMMKENJ);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BFLCGMAIILH([In] AIKKPEMPMGA<TData> FLCPKMMKENJ);
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public interface CDEEACAFEAN<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BOJOFBDJIJO([In] EBAHFFJHCIK<TData> KPFGCDGEJGH);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DDNBFJLBJLF([In] DJLIIFBBBGJ AECIDCBIEJK);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GGIMOPEPJGO();
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class EEFBJKCLHNB<TData> : CFCKCAJKCHC<IPNDPDCJJBG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly DKAJLAJLGKP<TData> FLCPKMMKENJ;

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x4811400", Offset = "0x4810200", VA = "0x184811400")]
	public EEFBJKCLHNB(IEnumerable<TData> POIMBCOJFJM, Quaternion JOKKKLCJOPA, Vector3? KKHLIDBOFEJ, bool HCDMEBBFHPE, bool BKJIDHCCBMN, IPNDPDCJJBG<TData> JBODBHEGPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x4811340", Offset = "0x4810140", VA = "0x184811340", Slot = "4")]
	public override bool BFLCGMAIILH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class IAMOCLFDMMB<TData> : CFCKCAJKCHC<CDEEACAFEAN<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x4C88B70", Offset = "0x4C87970", VA = "0x184C88B70")]
	public IAMOCLFDMMB(CDEEACAFEAN<TData> JBODBHEGPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x4D7F5B0", Offset = "0x4D7E3B0", VA = "0x184D7F5B0", Slot = "4")]
	public override bool BFLCGMAIILH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public class FDBOLFGNEAF<TData> : CFCKCAJKCHC<CDEEACAFEAN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly EBAHFFJHCIK<TData> FLCPKMMKENJ;

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x4C9E1C0", Offset = "0x4C9CFC0", VA = "0x184C9E1C0")]
	public FDBOLFGNEAF(IEnumerable<TData> POIMBCOJFJM, bool BKJIDHCCBMN, CDEEACAFEAN<TData> JBODBHEGPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x4811340", Offset = "0x4810140", VA = "0x184811340", Slot = "4")]
	public override bool BFLCGMAIILH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public class MPDPPECKIJJ<TData> : CFCKCAJKCHC<IPNDPDCJJBG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly AIKKPEMPMGA<TData> FLCPKMMKENJ;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x568AF70", Offset = "0x5689D70", VA = "0x18568AF70")]
	public MPDPPECKIJJ(IEnumerable<TData> POIMBCOJFJM, Quaternion GPIBIOCOFLD, HOFIJEOBLGB BABJHDGLLCB, Vector3? KKHLIDBOFEJ, bool HCDMEBBFHPE, bool BKJIDHCCBMN, Space JIDGGLOJNHI, IPNDPDCJJBG<TData> JBODBHEGPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x51A9170", Offset = "0x51A7F70", VA = "0x1851A9170", Slot = "4")]
	public override bool BFLCGMAIILH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public class DBAOKIOIFJL<TData> : CFCKCAJKCHC<CDEEACAFEAN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly DJLIIFBBBGJ FLCPKMMKENJ;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x6DBE070", Offset = "0x6DBCE70", VA = "0x186DBE070")]
	public DBAOKIOIFJL(Quaternion JOKKKLCJOPA, Vector3? KKHLIDBOFEJ, bool HCDMEBBFHPE, CDEEACAFEAN<TData> JBODBHEGPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x4D9B610", Offset = "0x4D9A410", VA = "0x184D9B610", Slot = "4")]
	public override bool BFLCGMAIILH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public struct DKAJLAJLGKP<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public readonly IEnumerable<TData> POIMBCOJFJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public readonly Quaternion JOKKKLCJOPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public readonly Vector3? KKHLIDBOFEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public readonly bool HCDMEBBFHPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly bool BKJIDHCCBMN;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x6E07ED0", Offset = "0x6E06CD0", VA = "0x186E07ED0")]
	public DKAJLAJLGKP(IEnumerable<TData> POIMBCOJFJM, Quaternion JOKKKLCJOPA, Vector3? KKHLIDBOFEJ, bool HCDMEBBFHPE, bool BKJIDHCCBMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct EBAHFFJHCIK<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public readonly IEnumerable<TData> POIMBCOJFJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly bool BKJIDHCCBMN;

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x47FFB00", Offset = "0x47FE900", VA = "0x1847FFB00")]
	public EBAHFFJHCIK(IEnumerable<TData> POIMBCOJFJM, bool BKJIDHCCBMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public struct AIKKPEMPMGA<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public readonly IEnumerable<TData> POIMBCOJFJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public readonly Quaternion GPIBIOCOFLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public readonly HOFIJEOBLGB BABJHDGLLCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public readonly Vector3? KKHLIDBOFEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public readonly bool HCDMEBBFHPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public readonly bool BKJIDHCCBMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public readonly Space JIDGGLOJNHI;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x4FE17C0", Offset = "0x4FE05C0", VA = "0x184FE17C0")]
	public AIKKPEMPMGA(IEnumerable<TData> POIMBCOJFJM, Quaternion GPIBIOCOFLD, HOFIJEOBLGB BABJHDGLLCB, Vector3? KKHLIDBOFEJ, bool HCDMEBBFHPE, bool BKJIDHCCBMN, Space JIDGGLOJNHI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public struct DJLIIFBBBGJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public readonly Quaternion JOKKKLCJOPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public readonly Vector3? KKHLIDBOFEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public readonly bool HCDMEBBFHPE;

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x5FD9D80", Offset = "0x5FD8B80", VA = "0x185FD9D80")]
	public DJLIIFBBBGJ(Quaternion JOKKKLCJOPA, Vector3? KKHLIDBOFEJ, bool HCDMEBBFHPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public interface MLMKFPALDPP<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BOJOFBDJIJO([In] AAHDPNLGPDA<TData> KPFGCDGEJGH);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DDNBFJLBJLF([In] GJLDJIBCFML AECIDCBIEJK);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DDNBFJLBJLF([In] HLKAIPLBKKN AECIDCBIEJK);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DDNBFJLBJLF([In] DNLKHPJNJIE AECIDCBIEJK);

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool GGIMOPEPJGO();
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public class GPHLOOCDFDJ<TData> : CFCKCAJKCHC<MLMKFPALDPP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private readonly DNLKHPJNJIE CIMMLFLIAGD;

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x4DD87D0", Offset = "0x4DD75D0", VA = "0x184DD87D0")]
	public GPHLOOCDFDJ(Vector3 ICCPJDDHLFE, float PGBCNNCAMLP, Vector3 KKHLIDBOFEJ, bool LKFKBCPFHDE, bool NFFLEFGLNPO, MLMKFPALDPP<TData> JBODBHEGPEF, Space JIDGGLOJNHI = Space.Self)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x4DD8770", Offset = "0x4DD7570", VA = "0x184DD8770", Slot = "4")]
	public override bool BFLCGMAIILH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public class AHPJJKLLDKL<TData> : CFCKCAJKCHC<MLMKFPALDPP<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x4C88B70", Offset = "0x4C87970", VA = "0x184C88B70")]
	public AHPJJKLLDKL(MLMKFPALDPP<TData> JBODBHEGPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x4FDF660", Offset = "0x4FDE460", VA = "0x184FDF660", Slot = "4")]
	public override bool BFLCGMAIILH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public class JEICAOAMGIH<TData> : CFCKCAJKCHC<MLMKFPALDPP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly AAHDPNLGPDA<TData> CIMMLFLIAGD;

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x5191840", Offset = "0x5190640", VA = "0x185191840")]
	public JEICAOAMGIH(IEnumerable<TData> POIMBCOJFJM, bool BKJIDHCCBMN, MLMKFPALDPP<TData> JBODBHEGPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x4811340", Offset = "0x4810140", VA = "0x184811340", Slot = "4")]
	public override bool BFLCGMAIILH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public class FEOLEBPDIFB<TData> : CFCKCAJKCHC<MLMKFPALDPP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private readonly HLKAIPLBKKN CIMMLFLIAGD;

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x4CA4010", Offset = "0x4CA2E10", VA = "0x184CA4010")]
	public FEOLEBPDIFB(float BEIKFGGDDNN, bool ODLHKGEGAOH, Vector3 KKHLIDBOFEJ, MLMKFPALDPP<TData> JBODBHEGPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x4CA3F40", Offset = "0x4CA2D40", VA = "0x184CA3F40", Slot = "4")]
	public override bool BFLCGMAIILH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public class LNABKDEOCOK<TData> : CFCKCAJKCHC<MLMKFPALDPP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly GJLDJIBCFML CIMMLFLIAGD;

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x548D560", Offset = "0x548C360", VA = "0x18548D560")]
	public LNABKDEOCOK(float PGBCNNCAMLP, Vector3 KKHLIDBOFEJ, MLMKFPALDPP<TData> JBODBHEGPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x548D490", Offset = "0x548C290", VA = "0x18548D490", Slot = "4")]
	public override bool BFLCGMAIILH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public struct DNLKHPJNJIE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public readonly Vector3 ICCPJDDHLFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public readonly float PGBCNNCAMLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public readonly Vector3 KKHLIDBOFEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public readonly bool LHEEJJNNHIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public readonly Space JIDGGLOJNHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public readonly bool NFFLEFGLNPO;

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x8119020", Offset = "0x8117E20", VA = "0x188119020")]
	public DNLKHPJNJIE(Vector3 ICCPJDDHLFE, float PGBCNNCAMLP, Vector3 KKHLIDBOFEJ, bool LHEEJJNNHIC, bool OLEGICAIGMD, Space JIDGGLOJNHI = Space.Self)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public struct AAHDPNLGPDA<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public readonly IEnumerable<TData> POIMBCOJFJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public readonly bool BKJIDHCCBMN;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x4E9EC00", Offset = "0x4E9DA00", VA = "0x184E9EC00")]
	public AAHDPNLGPDA(IEnumerable<TData> POIMBCOJFJM, bool BKJIDHCCBMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public struct HLKAIPLBKKN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public readonly float BEIKFGGDDNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public readonly bool ODLHKGEGAOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public readonly Vector3 KKHLIDBOFEJ;

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x8119530", Offset = "0x8118330", VA = "0x188119530")]
	public HLKAIPLBKKN(float BEIKFGGDDNN, bool ODLHKGEGAOH, Vector3 KKHLIDBOFEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public struct GJLDJIBCFML
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public readonly float PGBCNNCAMLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public readonly Vector3 KKHLIDBOFEJ;

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x5F9BF20", Offset = "0x5F9AD20", VA = "0x185F9BF20")]
	public GJLDJIBCFML(float PGBCNNCAMLP, Vector3 KKHLIDBOFEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public struct BEDJLODBOIH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public readonly Guid[] POIMBCOJFJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public readonly bool KBHCINEJGOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public readonly bool IEOLMPMPHGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public readonly bool APJKADPKHJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public readonly Vector3[] FEIJPGONCAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public readonly Quaternion[] BBNIGIMEEAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public readonly float[] PKPABBHDCPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public readonly Dictionary<Guid, Vector3> DELFOGIDMID;

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x81183D0", Offset = "0x81171D0", VA = "0x1881183D0")]
	public BEDJLODBOIH(Guid[] IJBGNFPMJGC, Vector3[] FEIJPGONCAA, Quaternion[] BBNIGIMEEAM, float[] PKPABBHDCPJ, Dictionary<Guid, Vector3> DELFOGIDMID, bool KBHCINEJGOO = true, bool IEOLMPMPHGF = true, bool APJKADPKHJL = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x8118200", Offset = "0x8117000", VA = "0x188118200")]
	private static void LBIOJBJGLDK(Dictionary<Guid, Vector3> DELFOGIDMID, int EDLEONMOLJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public static class CDLCJCBGBEJ
{
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	private struct BEJBCBMOJHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public bool KBBFFJLNHAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public LOAHJOOKLEP KHJENMFPGJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public LOAHJOOKLEP PMAPPCLLDLK;
	}

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private static BEJBCBMOJHK KEAIPBODOLI;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static CancellationToken CJNIBOMEOPL
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x8118BA0", Offset = "0x81179A0", VA = "0x188118BA0")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	internal static LOAHJOOKLEP KHJENMFPGJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x81189B0", Offset = "0x81177B0", VA = "0x1881189B0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x8118940", Offset = "0x8117740", VA = "0x188118940")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x8118AA0", Offset = "0x81178A0", VA = "0x188118AA0")]
	[ONLJNMLDJBD.CLIPOMEJNOE]
	internal static void JFAOHENDPOF(LOAHJOOKLEP DHLDMNCCNHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x8118BC0", Offset = "0x81179C0", VA = "0x188118BC0")]
	public static void PLDNCIPNLFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x8118A50", Offset = "0x8117850", VA = "0x188118A50")]
	private static LOAHJOOKLEP IICGKHBAFEN(LOAHJOOKLEP MIBEBGFMJBL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public static class MJGHFPDCKHM
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public enum OHGGIONINKG
	{
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		ICreationContextObject,
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		Guid
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x3C9D060", Offset = "0x3C9BE60", VA = "0x183C9D060")]
	public static void CLAAHNDEPDF<T>(T GBACACMKFBG, OHGGIONINKG DGPNPBEKOOD) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3C9D1A0", Offset = "0x3C9BFA0", VA = "0x183C9D1A0")]
	public static void CLAAHNDEPDF<T>(T GBACACMKFBG) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x3C9CF80", Offset = "0x3C9BD80", VA = "0x183C9CF80")]
	public static void CLAAHNDEPDF<T, TImpl, T>() where T : class where TImpl : notnull, T where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x3C9D200", Offset = "0x3C9C000", VA = "0x183C9D200")]
	public static void FBHNBLEPGNH<T>(T GBACACMKFBG) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x3C9D520", Offset = "0x3C9C320", VA = "0x183C9D520")]
	public static T LHCLHJGACJJ<T>(OHGGIONINKG DGPNPBEKOOD) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x3C9D270", Offset = "0x3C9C070", VA = "0x183C9D270")]
	public static bool GNHMKAHECGG<T>(OHGGIONINKG DGPNPBEKOOD, T? HOMMBJLIHJO, [Out][MaybeNullWhen(false)][NotNullWhen(true)] T GEBBPHIDJKP) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x3C9D5C0", Offset = "0x3C9C3C0", VA = "0x183C9D5C0")]
	public static bool NAKOPGLKIEH<T>(OHGGIONINKG DGPNPBEKOOD, [Out][NotNullWhen(true)][MaybeNullWhen(false)] T CEHDPJOBFJL) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x3C9D440", Offset = "0x3C9C240", VA = "0x183C9D440")]
	public static bool JAMMIFBEHCD<T>(OHGGIONINKG DGPNPBEKOOD) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x3C9D4E0", Offset = "0x3C9C2E0", VA = "0x183C9D4E0")]
	public static T LHCLHJGACJJ<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x3C9D3A0", Offset = "0x3C9C1A0", VA = "0x183C9D3A0")]
	public static bool GNHMKAHECGG<T>(T HOMMBJLIHJO, [Out] T GEBBPHIDJKP) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x3C9D4E0", Offset = "0x3C9C2E0", VA = "0x183C9D4E0")]
	public static bool JAMMIFBEHCD<T>() where T : class
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
internal static class GLPONFEJGKJ
{
	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x81192C0", Offset = "0x81180C0", VA = "0x1881192C0")]
	public static void AKCPKDCEBGJ(IEnumerable FHHFKEIPMHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x3B897D0", Offset = "0x3B885D0", VA = "0x183B897D0")]
	public static void AKCPKDCEBGJ<T>(T[] COPOPHFGNFG) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x3B898C0", Offset = "0x3B886C0", VA = "0x183B898C0")]
	public static void AKCPKDCEBGJ<T>(T HECBCEDKAOK) where T : notnull, Enum
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
