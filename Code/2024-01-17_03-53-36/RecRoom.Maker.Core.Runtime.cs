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
		[Cpp2IlInjected.Address(RVA = "0x7B83D0", Offset = "0x7B71D0", VA = "0x1807B83D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5FFF940", Offset = "0x5FFE740", VA = "0x185FFF940")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7B9560", Offset = "0x7B8360", VA = "0x1807B9560")]
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
		[Cpp2IlInjected.Address(RVA = "0x7B95A0", Offset = "0x7B83A0", VA = "0x1807B95A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface BFKLPIOIGJN<TData, TReturn>
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TReturn CanConnectableObjectBeSelected(TData FGANJEAKCMA);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface POLGKDEHLIA<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ClearHoverTarget(MLOHOBEINDO JNNHANIEBBN);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool SetHoverTarget(TData KEENMLGJEKM, Collider OAFGFOFBMPB, MLOHOBEINDO JNNHANIEBBN, [Optional] KNHELCDDNIE? KODMBNLHDEC);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool TryGetHoverTarget([Out] TData KEENMLGJEKM);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface FDJLLGPPNMN<TData> : AHILFMNNFNO, OABAIALJLLA<TData>, DDIPAJLLOLI<TData>, BMNFDKHHKLP<TData>, AANCDOEFKNG, OIDLBDFDGNH<TData>, BAHBDIBKKFA, PNDNPLGOLAN
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface OIDLBDFDGNH<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 NFOKGMLFMMM, Vector3 MIEHBOELEKH, float HABIICFCBMI, [Out] T KFCNEHFAKHH, [Out] Vector3 MECNMJMGGIF, [Out] Collider OAFGFOFBMPB);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 NFOKGMLFMMM, Vector3 MIEHBOELEKH, float LGHGFMICOAG, float HABIICFCBMI, T[] IFDHFAFINDE, [Out] Vector3 ILJLPEGOBOP, [Out] Collider LFLDBBDFBFD);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 NFOKGMLFMMM, float LGHGFMICOAG, Vector3 CGJCLAPEMHG, T[] IFDHFAFINDE);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetObjectFromColliderInCurrentScope(Collider AJPMBIIODOF, [Out] T HOMDHCBIBKJ);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface AHILFMNNFNO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Bounds AGEKGFBLHDL
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Transform LINMKELMDEL
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Bounds OOODKFAHOBP
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Transform HOFLIOLKDPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Vector3 MEGAONNMKDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void SetSelectionBoundsDirty(bool JBLHHECIMMN = true, int NMLANGDKHOD = 0);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ShouldHideSelectionBoundsPreview(bool LDJOAPMHDJO, object CGFEMNMBCOK);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface PNDNPLGOLAN
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	AHOMABILGKI JDCPCMPAGJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface CMCLFHLNBFE
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool ACEBJKCGGAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool KGJADHKIFBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool BBJMKNFFCMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Dictionary<Guid, Guid> TryGetPreviousCloneMapping();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void TrySetPreviousCloneMapping(Dictionary<Guid, Guid> APCCMDIAPAC);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface BMNFDKHHKLP<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool JGHFAOLBJLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	int KJEMEMABJEP
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	IEnumerable<TData> KEGMMFBNAND
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData KMBHPJEIFIH);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData KMBHPJEIFIH);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface OABAIALJLLA<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T FGANJEAKCMA, [Optional] KNHELCDDNIE? HEFDDONEHGO, bool PPIGGLEPFLN = true);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int KGLOPMIHJGF, IEnumerable<T> OMEDBFOCFBP, bool PPIGGLEPFLN = true);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int KGLOPMIHJGF, IEnumerable<T> OMEDBFOCFBP, KNHELCDDNIE HEFDDONEHGO, bool PPIGGLEPFLN = true);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface BAHBDIBKKFA
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface AANCDOEFKNG
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool GCLGHBEHLCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool OGNFEMFLDIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool BMDFIJDPMDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool JGEEKAPAHAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class DDHODHGFFLN<TReceiver> : DJGCEEGLADF<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3246060", Offset = "0x3244E60", VA = "0x183246060")]
	public DDHODHGFFLN(TReceiver COLDMGBKDHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class GBKMKMOIKNM<TReceiver, TFromTask> : DJGCEEGLADF<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3246060", Offset = "0x3244E60", VA = "0x183246060")]
	public GBKMKMOIKNM(TReceiver COLDMGBKDHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public abstract class DJGCEEGLADF<TReceiver, TFromExecute> where TReceiver : notnull where TFromExecute : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	protected TReceiver COLDMGBKDHN;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4F62830", Offset = "0x4F61630", VA = "0x184F62830")]
	public DJGCEEGLADF(TReceiver COLDMGBKDHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute NHHKCLMLLGE();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public abstract class GLNOAILHHIC<TReceiver, TResult> : DJGCEEGLADF<TReceiver, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3246060", Offset = "0x3244E60", VA = "0x183246060")]
	public GLNOAILHHIC(TReceiver COLDMGBKDHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct ECGNIJBBMMM<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public TGroup FCHFDMOMGBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public TData ACIABBOBNLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public IEnumerable<TData> JKMBDHHLJNE;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x1A0B350", Offset = "0x1A0A150", VA = "0x181A0B350")]
	public ECGNIJBBMMM(TGroup IDJBHIMLINA, TData JKGCAKKPKCL, IEnumerable<TData> DOHLICONIOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct OICDHMAHOIB<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public TGroup FCHFDMOMGBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public IEnumerable<TData> JKMBDHHLJNE;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x862170", Offset = "0x860F70", VA = "0x180862170")]
	public OICDHMAHOIB(TGroup IDJBHIMLINA, IEnumerable<TData> DOHLICONIOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct IGEGKLEEFHD<TGroup> where TGroup : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public TGroup FCHFDMOMGBP;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x8C4200", Offset = "0x8C3000", VA = "0x1808C4200")]
	public IGEGKLEEFHD(TGroup IDJBHIMLINA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct GILKJLPDDEK<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public IEnumerable<TData> JKMBDHHLJNE;

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8C4200", Offset = "0x8C3000", VA = "0x1808C4200")]
	public GILKJLPDDEK(IEnumerable<TData> DOHLICONIOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface JKFOLDMPGNF<TGroup, TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GAKOPPADKKB OKLAEGAFOCH(ECGNIJBBMMM<TGroup, TData> MAKJPHAHIML);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GAKOPPADKKB HNKBAEKACNO(ECGNIJBBMMM<TGroup, TData> MAKJPHAHIML);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GAKOPPADKKB EMMCHJLDOHJ(OICDHMAHOIB<TGroup, TData> MAKJPHAHIML);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GAKOPPADKKB HIEDJPPGFLG(IGEGKLEEFHD<TGroup> MAKJPHAHIML);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface LHOJIHLOOGG<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<GAKOPPADKKB> OKLAEGAFOCH(GILKJLPDDEK<TData> MAKJPHAHIML);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class NICGLOJPFDI<TGroup, TData> : GLNOAILHHIC<JKFOLDMPGNF<TGroup, TData>, GAKOPPADKKB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly OICDHMAHOIB<TGroup, TData> MAKJPHAHIML;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3DF5E00", Offset = "0x3DF4C00", VA = "0x183DF5E00")]
	public NICGLOJPFDI(TGroup IDJBHIMLINA, IEnumerable<TData> DOHLICONIOE, JKFOLDMPGNF<TGroup, TData> COLDMGBKDHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3DF5D30", Offset = "0x3DF4B30", VA = "0x183DF5D30", Slot = "4")]
	public override GAKOPPADKKB NHHKCLMLLGE()
	{
		return default(GAKOPPADKKB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class POBKNMHCGMM<TGroup, TData> : GLNOAILHHIC<JKFOLDMPGNF<TGroup, TData>, GAKOPPADKKB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly ECGNIJBBMMM<TGroup, TData> MAKJPHAHIML;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3AAFC10", Offset = "0x3AAEA10", VA = "0x183AAFC10")]
	public POBKNMHCGMM(TGroup IDJBHIMLINA, TData MGACAGKDMNJ, IEnumerable<TData> DOHLICONIOE, JKFOLDMPGNF<TGroup, TData> COLDMGBKDHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x40535A0", Offset = "0x40523A0", VA = "0x1840535A0", Slot = "4")]
	public override GAKOPPADKKB NHHKCLMLLGE()
	{
		return default(GAKOPPADKKB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class BDLHFGKDAND<TGroup, TData> : GLNOAILHHIC<JKFOLDMPGNF<TGroup, TData>, GAKOPPADKKB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly IGEGKLEEFHD<TGroup> MAKJPHAHIML;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3251300", Offset = "0x3250100", VA = "0x183251300")]
	public BDLHFGKDAND(TGroup IDJBHIMLINA, JKFOLDMPGNF<TGroup, TData> COLDMGBKDHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x46856F0", Offset = "0x46844F0", VA = "0x1846856F0", Slot = "4")]
	public override GAKOPPADKKB NHHKCLMLLGE()
	{
		return default(GAKOPPADKKB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class KKKMIFOHOKM<TGroup, TData> : GLNOAILHHIC<JKFOLDMPGNF<TGroup, TData>, GAKOPPADKKB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly ECGNIJBBMMM<TGroup, TData> MAKJPHAHIML;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3AAFC10", Offset = "0x3AAEA10", VA = "0x183AAFC10")]
	public KKKMIFOHOKM(TGroup IDJBHIMLINA, TData JKGCAKKPKCL, IEnumerable<TData> DOHLICONIOE, JKFOLDMPGNF<TGroup, TData> COLDMGBKDHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3AAFB30", Offset = "0x3AAE930", VA = "0x183AAFB30", Slot = "4")]
	public override GAKOPPADKKB NHHKCLMLLGE()
	{
		return default(GAKOPPADKKB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class GEIBLANEFBJ<TData> : GBKMKMOIKNM<LHOJIHLOOGG<TData>, GAKOPPADKKB> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private struct OPCBEKNINLA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AsyncTaskMethodBuilder<GAKOPPADKKB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public GEIBLANEFBJ<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private TaskAwaiter<GAKOPPADKKB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x3EFD7E0", Offset = "0x3EFC5E0", VA = "0x183EFD7E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3EFDA80", Offset = "0x3EFC880", VA = "0x183EFDA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private GILKJLPDDEK<TData> MAKJPHAHIML;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3251300", Offset = "0x3250100", VA = "0x183251300")]
	public GEIBLANEFBJ(IEnumerable<TData> BJKMAPLBIME, LHOJIHLOOGG<TData> COLDMGBKDHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x36D2110", Offset = "0x36D0F10", VA = "0x1836D2110", Slot = "4")]
	[AsyncStateMachine(typeof(GEIBLANEFBJ<>.OPCBEKNINLA))]
	public override Task<GAKOPPADKKB> NHHKCLMLLGE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct ONIMKCNBDLD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly KBHDDCOHDCN FNELAOLOGFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly bool AHOFPFHHLFB;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5FFF9E0", Offset = "0x5FFE7E0", VA = "0x185FFF9E0")]
	public ONIMKCNBDLD(KBHDDCOHDCN OEONMKMJDNK, bool KCLMAAHKDOO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface NJGFNKGENDN<TSpawnType> where TSpawnType : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> NHHKCLMLLGE(ONIMKCNBDLD CLLMOIOKLNG);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class FHEIOIOGILP<TSpawnType> : GBKMKMOIKNM<NJGFNKGENDN<TSpawnType>, TSpawnType> where TSpawnType : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private struct EKCEODLMLLF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public AsyncTaskMethodBuilder<TSpawnType> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public FHEIOIOGILP<TSpawnType> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskAwaiter<TSpawnType> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3250DF0", Offset = "0x324FBF0", VA = "0x183250DF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x32511A0", Offset = "0x324FFA0", VA = "0x1832511A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly ONIMKCNBDLD CLLMOIOKLNG;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x35FFCF0", Offset = "0x35FEAF0", VA = "0x1835FFCF0")]
	public FHEIOIOGILP(KBHDDCOHDCN OEONMKMJDNK, bool KCLMAAHKDOO, NJGFNKGENDN<TSpawnType> COLDMGBKDHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x35FFBF0", Offset = "0x35FE9F0", VA = "0x1835FFBF0", Slot = "4")]
	[AsyncStateMachine(typeof(FHEIOIOGILP<>.EKCEODLMLLF))]
	public override Task<TSpawnType> NHHKCLMLLGE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public readonly struct KBHDDCOHDCN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly bool HFHMLOPGLPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly Vector3 JKBAMAFHNGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly Vector3 DPEPKOKDODP;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5FFF480", Offset = "0x5FFE280", VA = "0x185FFF480")]
	public KBHDDCOHDCN(Transform DJLPMPMLIEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5FFF450", Offset = "0x5FFE250", VA = "0x185FFF450")]
	public KBHDDCOHDCN(Vector3 ONELACJMJNO, Vector3 MHFADBEELBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5FFF390", Offset = "0x5FFE190", VA = "0x185FFF390")]
	public static KBHDDCOHDCN OOCHANHCIPJ()
	{
		return default(KBHDDCOHDCN);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5FFF3C0", Offset = "0x5FFE1C0", VA = "0x185FFF3C0")]
	private KBHDDCOHDCN(bool CGLHKJCCMAG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct KJDEPLDNEMA<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public TNode HOMHLLCDBIF;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3AA9750", Offset = "0x3AA8550", VA = "0x183AA9750")]
	public KJDEPLDNEMA(TNode HOMHLLCDBIF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct CMEFEHBOPOP<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public TNode CFPKKCMAIOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public DDIGBCNLMFJ NHGMLNECEOO;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4AD4860", Offset = "0x4AD3660", VA = "0x184AD4860")]
	public CMEFEHBOPOP(TNode CFPKKCMAIOH, DDIGBCNLMFJ NHGMLNECEOO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface OKBJEAOMMDG<TNode>
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NJJBJLDKJIO([In] KJDEPLDNEMA<TNode> JBKIHOEKDIM);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PKKEAMBAALO([In] CMEFEHBOPOP<TNode> AMGENPFJHOK);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HEGBKBBNDIC();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class KCMLJIOCBPA<TNode> : DDHODHGFFLN<OKBJEAOMMDG<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3246060", Offset = "0x3244E60", VA = "0x183246060")]
	public KCMLJIOCBPA(OKBJEAOMMDG<TNode> COLDMGBKDHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x36E24C0", Offset = "0x36E12C0", VA = "0x1836E24C0", Slot = "4")]
	public override bool NHHKCLMLLGE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class LBNGLJOKGIN<TNode> : DDHODHGFFLN<OKBJEAOMMDG<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly CMEFEHBOPOP<TNode> AMGENPFJHOK;

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3B2CD40", Offset = "0x3B2BB40", VA = "0x183B2CD40")]
	public LBNGLJOKGIN(TNode CFPKKCMAIOH, DDIGBCNLMFJ NHGMLNECEOO, OKBJEAOMMDG<TNode> COLDMGBKDHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3B2CC70", Offset = "0x3B2BA70", VA = "0x183B2CC70", Slot = "4")]
	public override bool NHHKCLMLLGE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class FDJIGMNNCCA<TNode> : DDHODHGFFLN<OKBJEAOMMDG<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly KJDEPLDNEMA<TNode> JBKIHOEKDIM;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x35E4CC0", Offset = "0x35E3AC0", VA = "0x1835E4CC0")]
	public FDJIGMNNCCA(TNode OJKJKEABJJN, OKBJEAOMMDG<TNode> COLDMGBKDHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3251240", Offset = "0x3250040", VA = "0x183251240", Slot = "4")]
	public override bool NHHKCLMLLGE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct NDCEAKKJOAP<TSpawnInfo> where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public TSpawnInfo GJAAJCPACLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public Vector3 MHFADBEELBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public Quaternion NJBEEEBFFMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public float OPIINMIIKCC;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0xE29240", Offset = "0xE28040", VA = "0x180E29240")]
	public NDCEAKKJOAP(TSpawnInfo GJAAJCPACLO, Vector3 MHFADBEELBD, Quaternion NJBEEEBFFMP, float OPIINMIIKCC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface FNKIIMEAHBG<TSpawnType, TSpawnInfo>
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> CBEAGGGKLBI([In] NDCEAKKJOAP<TSpawnInfo> IBLKDJJPCGK, CancellationToken EHAEIHNIHFM);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class KNLOCKBHACM<TSpawnType, TSpawnInfo> : GBKMKMOIKNM<FNKIIMEAHBG<TSpawnType, TSpawnInfo>, TSpawnType> where TSpawnType : notnull where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly NDCEAKKJOAP<TSpawnInfo> DJELKPGJPKM;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3ABAA50", Offset = "0x3AB9850", VA = "0x183ABAA50")]
	public KNLOCKBHACM(TSpawnInfo PJNIPIICEMI, Vector3 MHFADBEELBD, Quaternion NJBEEEBFFMP, float OPIINMIIKCC, FNKIIMEAHBG<TSpawnType, TSpawnInfo> COLDMGBKDHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3ABA970", Offset = "0x3AB9770", VA = "0x183ABA970", Slot = "4")]
	public override Task<TSpawnType> NHHKCLMLLGE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct HODPIJNIDFD<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly IEnumerable<TData> JKMBDHHLJNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly bool AHOFPFHHLFB;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x375DDD0", Offset = "0x375CBD0", VA = "0x18375DDD0")]
	public HODPIJNIDFD(IEnumerable<TData> DOHLICONIOE, bool KCLMAAHKDOO = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface DHIKGBNAEHP<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<GAKOPPADKKB> MLBCCNMLOKD([In] HODPIJNIDFD<TData> DBJOEKEKCFO, CancellationToken EHAEIHNIHFM);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class MECFIHEKMOC<TData> : GBKMKMOIKNM<DHIKGBNAEHP<TData>, GAKOPPADKKB> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly HODPIJNIDFD<TData> OMOLEENJADI;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x3D4C7D0", Offset = "0x3D4B5D0", VA = "0x183D4C7D0")]
	public MECFIHEKMOC(IEnumerable<TData> DOHLICONIOE, bool KCLMAAHKDOO, DHIKGBNAEHP<TData> COLDMGBKDHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x3ABA970", Offset = "0x3AB9770", VA = "0x183ABA970", Slot = "4")]
	public override Task<GAKOPPADKKB> NHHKCLMLLGE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct LEKJMAFALHK<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly T KEENMLGJEKM;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3B42530", Offset = "0x3B41330", VA = "0x183B42530")]
	public LEKJMAFALHK(T GHPFKKDBCEE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface JOJEGKCLEBE<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NJJBJLDKJIO([In] LEKJMAFALHK<T> GOPJANEKKGF);

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PKKEAMBAALO();
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface OJJGPHBCMHO<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NHHKCLMLLGE([In] PAMNKNGKJBI<T> KOHCOBPEELI);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct PAMNKNGKJBI<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public readonly T KEENMLGJEKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public readonly bool FGHPFLAGOCG;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x3F88540", Offset = "0x3F87340", VA = "0x183F88540")]
	public PAMNKNGKJBI(T GHPFKKDBCEE, bool OGHCPPMAMME)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class BPBKDMLCFDG<T> : DDHODHGFFLN<JOJEGKCLEBE<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x3246060", Offset = "0x3244E60", VA = "0x183246060")]
	public BPBKDMLCFDG(JOJEGKCLEBE<T> COLDMGBKDHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x3DD4090", Offset = "0x3DD2E90", VA = "0x183DD4090", Slot = "4")]
	public override bool NHHKCLMLLGE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class EKCNLKABHFK<T> : DDHODHGFFLN<JOJEGKCLEBE<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly LEKJMAFALHK<T> GOPJANEKKGF;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x3251370", Offset = "0x3250170", VA = "0x183251370")]
	public EKCNLKABHFK(T KEENMLGJEKM, JOJEGKCLEBE<T> COLDMGBKDHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x3251240", Offset = "0x3250040", VA = "0x183251240", Slot = "4")]
	public override bool NHHKCLMLLGE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class FPJHJJNAABN<T> : DDHODHGFFLN<OJJGPHBCMHO<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly PAMNKNGKJBI<T> KOHCOBPEELI;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x36289B0", Offset = "0x36277B0", VA = "0x1836289B0")]
	public FPJHJJNAABN(T KEENMLGJEKM, bool OGHCPPMAMME, OJJGPHBCMHO<T> COLDMGBKDHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x3251240", Offset = "0x3250040", VA = "0x183251240", Slot = "4")]
	public override bool NHHKCLMLLGE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct JIPFDBGCHPD<TData> where TData : notnull, ODOFDPMGPFK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public IEnumerable<TData> JKMBDHHLJNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public bool GDAIKGBKCCD;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x3A03D30", Offset = "0x3A02B30", VA = "0x183A03D30")]
	public JIPFDBGCHPD(IEnumerable<TData> BBLIJOPIHLH, bool HLCILILPOFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct DCKGPGKFNDM<TData> where TData : notnull, ODOFDPMGPFK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public List<TData> JKMBDHHLJNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public List<bool> AMAOFJNINDJ;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x4F37110", Offset = "0x4F35F10", VA = "0x184F37110")]
	public DCKGPGKFNDM(List<TData> BBLIJOPIHLH, List<bool> KFHHMDDNGDG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface ODOFDPMGPFK
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool DJAFMGDLEIO
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface NKNBMEBJDMK<TData> where TData : ODOFDPMGPFK
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NHHKCLMLLGE([In] JIPFDBGCHPD<TData> IBNNLMHFCFC);

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NHHKCLMLLGE([In] DCKGPGKFNDM<TData> IBNNLMHFCFC);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface PPPCOOOGEHH<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NAHPMKBOGOH(T KEENMLGJEKM);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class CFJBBHOMFBE<TData> : DDHODHGFFLN<NKNBMEBJDMK<TData>> where TData : notnull, ODOFDPMGPFK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly JIPFDBGCHPD<TData> IBNNLMHFCFC;

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x47FEE80", Offset = "0x47FDC80", VA = "0x1847FEE80")]
	public CFJBBHOMFBE(List<TData> DOHLICONIOE, bool GDAIKGBKCCD, NKNBMEBJDMK<TData> COLDMGBKDHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x3251240", Offset = "0x3250040", VA = "0x183251240", Slot = "4")]
	public override bool NHHKCLMLLGE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class HBGEJKJIAJJ<TData> : DDHODHGFFLN<NKNBMEBJDMK<TData>> where TData : notnull, ODOFDPMGPFK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly DCKGPGKFNDM<TData> IBNNLMHFCFC;

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x3731690", Offset = "0x3730490", VA = "0x183731690")]
	public HBGEJKJIAJJ(List<TData> DOHLICONIOE, List<bool> AMAOFJNINDJ, NKNBMEBJDMK<TData> COLDMGBKDHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x37315D0", Offset = "0x37303D0", VA = "0x1837315D0", Slot = "4")]
	public override bool NHHKCLMLLGE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface HJFKFDCPFDL : ODOFDPMGPFK
{
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface LDGAFHEOFDA<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<GAKOPPADKKB> NHHKCLMLLGE(DDDMPEJIJMO<TData> BNNGOFBNPPI);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class LGJEKBDDGLO<TData> : GBKMKMOIKNM<LDGAFHEOFDA<TData>, GAKOPPADKKB> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct GEBDKPLPPNA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public AsyncTaskMethodBuilder<GAKOPPADKKB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public LGJEKBDDGLO<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<GAKOPPADKKB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x36D1DB0", Offset = "0x36D0BB0", VA = "0x1836D1DB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x36D20A0", Offset = "0x36D0EA0", VA = "0x1836D20A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly DDDMPEJIJMO<TData> GLDAKMAAIPD;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x3B47390", Offset = "0x3B46190", VA = "0x183B47390")]
	public LGJEKBDDGLO(TData AHJIACMOFDC, IReadOnlyList<TData> JDDALLPJFMC, bool KCLMAAHKDOO, LDGAFHEOFDA<TData> COLDMGBKDHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x3B47290", Offset = "0x3B46090", VA = "0x183B47290", Slot = "4")]
	[AsyncStateMachine(typeof(LGJEKBDDGLO<>.GEBDKPLPPNA))]
	public override Task<GAKOPPADKKB> NHHKCLMLLGE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public struct DDDMPEJIJMO<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public TData GGGHIHGKKNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public IReadOnlyList<TData> GNNJFGJPFLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public bool AHOFPFHHLFB;

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x450D700", Offset = "0x450C500", VA = "0x18450D700")]
	public DDDMPEJIJMO(TData AHJIACMOFDC, IReadOnlyList<TData> JDDALLPJFMC, bool KCLMAAHKDOO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface KCGNLDMDCDA<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NHHKCLMLLGE([In] ABAPODIFDFF<TData> IKEHKEDBGLA);
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface FKCODILDOOM<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NHHKCLMLLGE([In] DJOIABELHOL<TData> IKEHKEDBGLA);
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface LBHPGLKIBDP<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OAFEHELAKDL([In] NEMIHIAFOPD<TData> IKEHKEDBGLA);

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PKKEAMBAALO();
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class KOGEKBHPLNH<TData> : DDHODHGFFLN<KCGNLDMDCDA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly ABAPODIFDFF<TData> IKEHKEDBGLA;

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x3ABB1A0", Offset = "0x3AB9FA0", VA = "0x183ABB1A0")]
	public KOGEKBHPLNH(IEnumerable<TData> DOHLICONIOE, NECAOGBKGLK PIPDACHFJNO, BGLMPIENKHC ELKLKFMLCMF, float COKLKNNDCEN, bool KCLMAAHKDOO, KCGNLDMDCDA<TData> COLDMGBKDHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x3251240", Offset = "0x3250040", VA = "0x183251240", Slot = "4")]
	public override bool NHHKCLMLLGE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class DBADGGPKLND<TData> : DDHODHGFFLN<FKCODILDOOM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly DJOIABELHOL<TData> IKEHKEDBGLA;

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x4F083A0", Offset = "0x4F071A0", VA = "0x184F083A0")]
	public DBADGGPKLND(TData[] DOHLICONIOE, NECAOGBKGLK[] PIPDACHFJNO, BGLMPIENKHC[] ELKLKFMLCMF, float[] COKLKNNDCEN, FKCODILDOOM<TData> COLDMGBKDHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x36F0B00", Offset = "0x36EF900", VA = "0x1836F0B00", Slot = "4")]
	public override bool NHHKCLMLLGE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class MGJGJOEOPKF<TData> : DDHODHGFFLN<LBHPGLKIBDP<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x3246060", Offset = "0x3244E60", VA = "0x183246060")]
	public MGJGJOEOPKF(LBHPGLKIBDP<TData> COLDMGBKDHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3D668B0", Offset = "0x3D656B0", VA = "0x183D668B0", Slot = "4")]
	public override bool NHHKCLMLLGE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class GLDDDJKHIBA<TData> : DDHODHGFFLN<LBHPGLKIBDP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly NEMIHIAFOPD<TData> IKEHKEDBGLA;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x36F0BC0", Offset = "0x36EF9C0", VA = "0x1836F0BC0")]
	public GLDDDJKHIBA(IEnumerable<TData> DOHLICONIOE, NECAOGBKGLK PIPDACHFJNO, BGLMPIENKHC ELKLKFMLCMF, float COKLKNNDCEN, LBHPGLKIBDP<TData> COLDMGBKDHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x36F0B00", Offset = "0x36EF900", VA = "0x1836F0B00", Slot = "4")]
	public override bool NHHKCLMLLGE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct ABAPODIFDFF<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public IEnumerable<TData> JKMBDHHLJNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public NECAOGBKGLK KCAFBEKNJJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public BGLMPIENKHC GMHLOAKCMDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public float COKLKNNDCEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public bool KCLMAAHKDOO;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x367BB90", Offset = "0x367A990", VA = "0x18367BB90")]
	public ABAPODIFDFF(IEnumerable<TData> DOHLICONIOE, NECAOGBKGLK PIPDACHFJNO, BGLMPIENKHC ELKLKFMLCMF, float COKLKNNDCEN, bool KCLMAAHKDOO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public struct DJOIABELHOL<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public TData[] JKMBDHHLJNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public NECAOGBKGLK[] KCAFBEKNJJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public BGLMPIENKHC[] GMHLOAKCMDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public float[] COKLKNNDCEN;

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x4F63600", Offset = "0x4F62400", VA = "0x184F63600")]
	public DJOIABELHOL(TData[] DOHLICONIOE, NECAOGBKGLK[] PIPDACHFJNO, BGLMPIENKHC[] ELKLKFMLCMF, float[] COKLKNNDCEN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public struct NEMIHIAFOPD<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public IEnumerable<TData> JKMBDHHLJNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public NECAOGBKGLK KCAFBEKNJJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public BGLMPIENKHC GMHLOAKCMDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public float COKLKNNDCEN;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3DEDB50", Offset = "0x3DEC950", VA = "0x183DEDB50")]
	public NEMIHIAFOPD(IEnumerable<TData> DOHLICONIOE, NECAOGBKGLK PIPDACHFJNO, BGLMPIENKHC ELKLKFMLCMF, float COKLKNNDCEN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface DDIPAJLLOLI<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EMMCHJLDOHJ([In] FHILJJKMAOH<TData> DBJOEKEKCFO);

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HIEDJPPGFLG([In] FHILJJKMAOH<TData> DBJOEKEKCFO);

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BAENKBMLCOL([In] bool OEIIBNDKIPA);

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DGNGOEEDCND([In] FHILJJKMAOH<TData> DBJOEKEKCFO);

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BGMFMLOAOBG();

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool MNNEHFIOAAB([In] TData DONHPBPAAEM);
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class EPMHEOHDPOO<TData> : DDHODHGFFLN<DDIPAJLLOLI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly FHILJJKMAOH<TData> DBJOEKEKCFO;

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x32A15A0", Offset = "0x32A03A0", VA = "0x1832A15A0")]
	public EPMHEOHDPOO(List<TData> PNAEPBNICFF, DDIPAJLLOLI<TData> COLDMGBKDHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x3251240", Offset = "0x3250040", VA = "0x183251240", Slot = "4")]
	public override bool NHHKCLMLLGE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class LKCKNKBGFFD<TData> : DDHODHGFFLN<DDIPAJLLOLI<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x3246060", Offset = "0x3244E60", VA = "0x183246060")]
	public LKCKNKBGFFD(DDIPAJLLOLI<TData> COLDMGBKDHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3B534B0", Offset = "0x3B522B0", VA = "0x183B534B0", Slot = "4")]
	public override bool NHHKCLMLLGE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class CGAEJICHDPM<TData> : DDHODHGFFLN<DDIPAJLLOLI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly bool KCLMAAHKDOO;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x48F4D90", Offset = "0x48F3B90", VA = "0x1848F4D90")]
	public CGAEJICHDPM(bool KCLMAAHKDOO, DDIPAJLLOLI<TData> COLDMGBKDHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x48F4D30", Offset = "0x48F3B30", VA = "0x1848F4D30", Slot = "4")]
	public override bool NHHKCLMLLGE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class ODOOLKIHNFB<TData> : DDHODHGFFLN<DDIPAJLLOLI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly FHILJJKMAOH<TData> DBJOEKEKCFO;

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3EE45F0", Offset = "0x3EE33F0", VA = "0x183EE45F0")]
	public ODOOLKIHNFB(List<TData> PNAEPBNICFF, bool KCLMAAHKDOO, DDIPAJLLOLI<TData> COLDMGBKDHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x37315D0", Offset = "0x37303D0", VA = "0x1837315D0", Slot = "4")]
	public override bool NHHKCLMLLGE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class GLNALOINEHD<TData> : DDHODHGFFLN<DDIPAJLLOLI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly TData DONHPBPAAEM;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x36F1520", Offset = "0x36F0320", VA = "0x1836F1520")]
	public GLNALOINEHD(TData DONHPBPAAEM, DDIPAJLLOLI<TData> COLDMGBKDHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x36F1450", Offset = "0x36F0250", VA = "0x1836F1450", Slot = "4")]
	public override bool NHHKCLMLLGE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class ADCOIJMEFPF<TData> : DDHODHGFFLN<DDIPAJLLOLI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly FHILJJKMAOH<TData> DBJOEKEKCFO;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3681950", Offset = "0x3680750", VA = "0x183681950")]
	public ADCOIJMEFPF(IEnumerable<TData> PNAEPBNICFF, DDIPAJLLOLI<TData> COLDMGBKDHN, bool KCLMAAHKDOO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3681880", Offset = "0x3680680", VA = "0x183681880", Slot = "4")]
	public override bool NHHKCLMLLGE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public struct FHILJJKMAOH<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public IEnumerable<TData> JKMBDHHLJNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public bool KCLMAAHKDOO;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x35FFD90", Offset = "0x35FEB90", VA = "0x1835FFD90")]
	public FHILJJKMAOH(IEnumerable<TData> BBLIJOPIHLH, bool AJGHKMMGEGL = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface GMPJICPKEGJ
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<GAKOPPADKKB> NHHKCLMLLGE(COJHFBMEPKH IGDFICDJAOE);
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public class MLKKCDNKKOD : GBKMKMOIKNM<GMPJICPKEGJ, GAKOPPADKKB>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private struct GAHGJPJLHOB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public AsyncTaskMethodBuilder<GAKOPPADKKB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public MLKKCDNKKOD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private TaskAwaiter<GAKOPPADKKB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x5FFEC70", Offset = "0x5FFDA70", VA = "0x185FFEC70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x5FFEEF0", Offset = "0x5FFDCF0", VA = "0x185FFEEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly COJHFBMEPKH ECGLKKPJOMH;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x5FFF810", Offset = "0x5FFE610", VA = "0x185FFF810")]
	public MLKKCDNKKOD(bool KCLMAAHKDOO, GMPJICPKEGJ COLDMGBKDHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x5FFF720", Offset = "0x5FFE520", VA = "0x185FFF720", Slot = "4")]
	[AsyncStateMachine(typeof(GAHGJPJLHOB))]
	public override Task<GAKOPPADKKB> NHHKCLMLLGE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public struct COJHFBMEPKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public bool AHOFPFHHLFB;

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0xC0EF90", Offset = "0xC0DD90", VA = "0x180C0EF90")]
	public COJHFBMEPKH(bool KCLMAAHKDOO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public readonly struct DMHMNNLKPBI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly bool BDAMJDJKBIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly bool FJEDEEJPFKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly bool OPIINMIIKCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public readonly bool KCLMAAHKDOO;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x45214F0", Offset = "0x45202F0", VA = "0x1845214F0")]
	public DMHMNNLKPBI(bool BDAMJDJKBIF, bool FJEDEEJPFKG, bool OPIINMIIKCC, bool KCLMAAHKDOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x5FFEC20", Offset = "0x5FFDA20", VA = "0x185FFEC20")]
	public DMHMNNLKPBI(bool FJEDEEJPFKG, bool KCLMAAHKDOO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public interface LEKBCLMLFOD
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OPHAEOKJEJI(DMHMNNLKPBI CHGPFEBOEKH);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DNGNCFDODLG(DMHMNNLKPBI CHGPFEBOEKH);
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class PMBDCDGDAJG : DDHODHGFFLN<LEKBCLMLFOD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly DMHMNNLKPBI CHGPFEBOEKH;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x5FFFA50", Offset = "0x5FFE850", VA = "0x185FFFA50")]
	public PMBDCDGDAJG(bool OKMCACLMLOF, bool FJEDEEJPFKG, bool OPIINMIIKCC, bool KCLMAAHKDOO, LEKBCLMLFOD COLDMGBKDHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x5FFFA00", Offset = "0x5FFE800", VA = "0x185FFFA00", Slot = "4")]
	public override bool NHHKCLMLLGE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class MOPJPOFHMKB : DDHODHGFFLN<LEKBCLMLFOD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly DMHMNNLKPBI CHGPFEBOEKH;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x5FFF8C0", Offset = "0x5FFE6C0", VA = "0x185FFF8C0")]
	public MOPJPOFHMKB(bool FJEDEEJPFKG, bool KCLMAAHKDOO, LEKBCLMLFOD COLDMGBKDHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5FFF870", Offset = "0x5FFE670", VA = "0x185FFF870", Slot = "4")]
	public override bool NHHKCLMLLGE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public interface HEONFNPCILB<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NJJBJLDKJIO([In] EJPLHOAKEBA<TData> JBKIHOEKDIM);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OAFEHELAKDL([In] OAHDANJNNIO IMLGHGBHIMC);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool OAFEHELAKDL([In] EMENEIMKLBG IMLGHGBHIMC);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool PKKEAMBAALO();
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class KFJNOMOMPGD<TData> : DDHODHGFFLN<HEONFNPCILB<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x3246060", Offset = "0x3244E60", VA = "0x183246060")]
	public KFJNOMOMPGD(HEONFNPCILB<TData> COLDMGBKDHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x3A98670", Offset = "0x3A97470", VA = "0x183A98670", Slot = "4")]
	public override bool NHHKCLMLLGE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class OIFJEMINDNE<TData> : DDHODHGFFLN<HEONFNPCILB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly OAHDANJNNIO CJPBMMDONBF;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x3EF3910", Offset = "0x3EF2710", VA = "0x183EF3910")]
	public OIFJEMINDNE(Vector3 LECMFJECOHP, bool CKCBBHEINCI, HEONFNPCILB<TData> COLDMGBKDHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x36B90E0", Offset = "0x36B7EE0", VA = "0x1836B90E0", Slot = "4")]
	public override bool NHHKCLMLLGE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class KFABPLAKBAB<TData> : DDHODHGFFLN<HEONFNPCILB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly EMENEIMKLBG CJPBMMDONBF;

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x3A95790", Offset = "0x3A94590", VA = "0x183A95790")]
	public KFABPLAKBAB(Guid LIDEBADHILD, int HPLKFBKKIBG, Vector3 MHFADBEELBD, Quaternion NJBEEEBFFMP, float GBGAAPIAACD, bool CKCBBHEINCI, HEONFNPCILB<TData> COLDMGBKDHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x3A95730", Offset = "0x3A94530", VA = "0x183A95730", Slot = "4")]
	public override bool NHHKCLMLLGE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class CNGJJFPALPG<TData> : DDHODHGFFLN<HEONFNPCILB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly EJPLHOAKEBA<TData> CJPBMMDONBF;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x4BA6500", Offset = "0x4BA5300", VA = "0x184BA6500")]
	public CNGJJFPALPG(TData KEENMLGJEKM, bool KCLMAAHKDOO, HEONFNPCILB<TData> COLDMGBKDHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3251240", Offset = "0x3250040", VA = "0x183251240", Slot = "4")]
	public override bool NHHKCLMLLGE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public struct OAHDANJNNIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public readonly Vector3 LECMFJECOHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public readonly bool CKCBBHEINCI;

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5FFF9C0", Offset = "0x5FFE7C0", VA = "0x185FFF9C0")]
	public OAHDANJNNIO(Vector3 LECMFJECOHP, bool CKCBBHEINCI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public struct EMENEIMKLBG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly Guid LIDEBADHILD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public readonly int HPLKFBKKIBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public readonly Vector3 MHFADBEELBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public readonly Quaternion NJBEEEBFFMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public readonly float GBGAAPIAACD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public readonly bool CKCBBHEINCI;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5FFEC30", Offset = "0x5FFDA30", VA = "0x185FFEC30")]
	public EMENEIMKLBG(Guid LIDEBADHILD, int HPLKFBKKIBG, Vector3 MHFADBEELBD, Quaternion NJBEEEBFFMP, float GBGAAPIAACD, bool CKCBBHEINCI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public struct EJPLHOAKEBA<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public readonly TData KEENMLGJEKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public readonly bool KCLMAAHKDOO;

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x3250500", Offset = "0x324F300", VA = "0x183250500")]
	public EJPLHOAKEBA(TData KEENMLGJEKM, bool KCLMAAHKDOO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public interface NFIOJLJFKID<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NHHKCLMLLGE([In] EEBLAEGPGAD<TData> KKIOILGHLCA);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NHHKCLMLLGE([In] IKAHOHNJJLL<TData> KKIOILGHLCA);
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public interface LLLGJOOAABC<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NJJBJLDKJIO([In] PAHKMMMHMOA<TData> JKFELJICDGG);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OAFEHELAKDL([In] DHMGGLCGKLL IMLGHGBHIMC);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PKKEAMBAALO();
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public class IMJCBFMOJKB<TData> : DDHODHGFFLN<NFIOJLJFKID<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private readonly EEBLAEGPGAD<TData> KKIOILGHLCA;

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x3814640", Offset = "0x3813440", VA = "0x183814640")]
	public IMJCBFMOJKB(IEnumerable<TData> DOHLICONIOE, Vector3 IEBFPKLGAFB, bool KCLMAAHKDOO, NFIOJLJFKID<TData> COLDMGBKDHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x3251240", Offset = "0x3250040", VA = "0x183251240", Slot = "4")]
	public override bool NHHKCLMLLGE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class GHJHEOBKOJN<TData> : DDHODHGFFLN<LLLGJOOAABC<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x3246060", Offset = "0x3244E60", VA = "0x183246060")]
	public GHJHEOBKOJN(LLLGJOOAABC<TData> COLDMGBKDHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x36E24C0", Offset = "0x36E12C0", VA = "0x1836E24C0", Slot = "4")]
	public override bool NHHKCLMLLGE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class AEKBGIOAMHF<TData> : DDHODHGFFLN<LLLGJOOAABC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly PAHKMMMHMOA<TData> KKIOILGHLCA;

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x368AD60", Offset = "0x3689B60", VA = "0x18368AD60")]
	public AEKBGIOAMHF(IEnumerable<TData> DOHLICONIOE, bool KCLMAAHKDOO, LLLGJOOAABC<TData> COLDMGBKDHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x3251240", Offset = "0x3250040", VA = "0x183251240", Slot = "4")]
	public override bool NHHKCLMLLGE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class POAEJHOPNAI<TData> : DDHODHGFFLN<NFIOJLJFKID<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly IKAHOHNJJLL<TData> KKIOILGHLCA;

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x40534B0", Offset = "0x40522B0", VA = "0x1840534B0")]
	public POAEJHOPNAI(IEnumerable<TData> DOHLICONIOE, Vector3 DJLEJOOHEGF, IIFCDBDBPJO HLDNDFCINCA, bool KCLMAAHKDOO, NFIOJLJFKID<TData> COLDMGBKDHN, Space FDPANGJGIFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x3B2CC70", Offset = "0x3B2BA70", VA = "0x183B2CC70", Slot = "4")]
	public override bool NHHKCLMLLGE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class DAPLLLDJGLM<TData> : DDHODHGFFLN<LLLGJOOAABC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly DHMGGLCGKLL KKIOILGHLCA;

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x4F08350", Offset = "0x4F07150", VA = "0x184F08350")]
	public DAPLLLDJGLM(Vector3 IEBFPKLGAFB, LLLGJOOAABC<TData> COLDMGBKDHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x36B90E0", Offset = "0x36B7EE0", VA = "0x1836B90E0", Slot = "4")]
	public override bool NHHKCLMLLGE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public struct EEBLAEGPGAD<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public readonly IEnumerable<TData> DOHLICONIOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public readonly Vector3 IEBFPKLGAFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public readonly bool KCLMAAHKDOO;

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x3242700", Offset = "0x3241500", VA = "0x183242700")]
	public EEBLAEGPGAD(IEnumerable<TData> DOHLICONIOE, Vector3 IEBFPKLGAFB, bool KCLMAAHKDOO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct PAHKMMMHMOA<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public readonly IEnumerable<TData> DOHLICONIOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public readonly bool KCLMAAHKDOO;

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x3F86A80", Offset = "0x3F85880", VA = "0x183F86A80")]
	public PAHKMMMHMOA(IEnumerable<TData> DOHLICONIOE, bool KCLMAAHKDOO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct IKAHOHNJJLL<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public readonly IEnumerable<TData> DOHLICONIOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public readonly Vector3 DJLEJOOHEGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public readonly IIFCDBDBPJO HLDNDFCINCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public readonly bool KCLMAAHKDOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly Space FDPANGJGIFC;

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3812F50", Offset = "0x3811D50", VA = "0x183812F50")]
	public IKAHOHNJJLL(IEnumerable<TData> DOHLICONIOE, Vector3 DJLEJOOHEGF, IIFCDBDBPJO HLDNDFCINCA, bool KCLMAAHKDOO, Space FDPANGJGIFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct DHMGGLCGKLL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public readonly Vector3 IEBFPKLGAFB;

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x21141F0", Offset = "0x2112FF0", VA = "0x1821141F0")]
	public DHMGGLCGKLL(Vector3 IEBFPKLGAFB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public enum IIFCDBDBPJO
{
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	XYZ,
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	X_only,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	Y_only,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	Z_only
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public interface PHBPCNCCELD
{
	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NHHKCLMLLGE([In] OGCCNEOPJNO NEAHFMDKNCK);
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public class CBDNJNMFFPM : DDHODHGFFLN<PHBPCNCCELD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly OGCCNEOPJNO NEAHFMDKNCK;

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x5FFEBC0", Offset = "0x5FFD9C0", VA = "0x185FFEBC0")]
	public CBDNJNMFFPM(bool KCLMAAHKDOO, PHBPCNCCELD COLDMGBKDHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x5FFEB10", Offset = "0x5FFD910", VA = "0x185FFEB10", Slot = "4")]
	public override bool NHHKCLMLLGE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public readonly struct OGCCNEOPJNO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public readonly bool KCLMAAHKDOO;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0xC0EF90", Offset = "0xC0DD90", VA = "0x180C0EF90")]
	public OGCCNEOPJNO(bool KCLMAAHKDOO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public interface EKGPJIFBEFM<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NHHKCLMLLGE([In] CPADFNOPBGB<TData> JGGGHHBIONB);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NHHKCLMLLGE([In] CFBJIAFPHCM<TData> JGGGHHBIONB);
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public interface NNMLLBOJOGE<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NJJBJLDKJIO([In] IIFODCAAOEF<TData> JBKIHOEKDIM);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OAFEHELAKDL([In] NFMKJMPHNPO IMLGHGBHIMC);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PKKEAMBAALO();
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public class IIECKMGMHFD<TData> : DDHODHGFFLN<EKGPJIFBEFM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly CPADFNOPBGB<TData> JGGGHHBIONB;

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x3811440", Offset = "0x3810240", VA = "0x183811440")]
	public IIECKMGMHFD(IEnumerable<TData> DOHLICONIOE, Quaternion IEBFPKLGAFB, Vector3? GKOLJLPOIIK, bool PGFDEFDFLEG, bool KCLMAAHKDOO, EKGPJIFBEFM<TData> COLDMGBKDHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x3251240", Offset = "0x3250040", VA = "0x183251240", Slot = "4")]
	public override bool NHHKCLMLLGE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class BBMAFCJKCEO<TData> : DDHODHGFFLN<NNMLLBOJOGE<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x3246060", Offset = "0x3244E60", VA = "0x183246060")]
	public BBMAFCJKCEO(NNMLLBOJOGE<TData> COLDMGBKDHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x36E24C0", Offset = "0x36E12C0", VA = "0x1836E24C0", Slot = "4")]
	public override bool NHHKCLMLLGE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class NBDCKJAIODH<TData> : DDHODHGFFLN<NNMLLBOJOGE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly IIFODCAAOEF<TData> JGGGHHBIONB;

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x3DE7470", Offset = "0x3DE6270", VA = "0x183DE7470")]
	public NBDCKJAIODH(IEnumerable<TData> DOHLICONIOE, bool KCLMAAHKDOO, NNMLLBOJOGE<TData> COLDMGBKDHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x3251240", Offset = "0x3250040", VA = "0x183251240", Slot = "4")]
	public override bool NHHKCLMLLGE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class OPHNBGIDKIL<TData> : DDHODHGFFLN<EKGPJIFBEFM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly CFBJIAFPHCM<TData> JGGGHHBIONB;

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x3EFDB70", Offset = "0x3EFC970", VA = "0x183EFDB70")]
	public OPHNBGIDKIL(IEnumerable<TData> DOHLICONIOE, Quaternion CFPEKKLDDKB, IIFCDBDBPJO HDFJECEBDGL, Vector3? GKOLJLPOIIK, bool PGFDEFDFLEG, bool KCLMAAHKDOO, Space FDPANGJGIFC, EKGPJIFBEFM<TData> COLDMGBKDHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x3B2CC70", Offset = "0x3B2BA70", VA = "0x183B2CC70", Slot = "4")]
	public override bool NHHKCLMLLGE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class APPPBGGPKLP<TData> : DDHODHGFFLN<NNMLLBOJOGE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly NFMKJMPHNPO JGGGHHBIONB;

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x36B9140", Offset = "0x36B7F40", VA = "0x1836B9140")]
	public APPPBGGPKLP(Quaternion IEBFPKLGAFB, Vector3? GKOLJLPOIIK, bool PGFDEFDFLEG, NNMLLBOJOGE<TData> COLDMGBKDHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x36B90E0", Offset = "0x36B7EE0", VA = "0x1836B90E0", Slot = "4")]
	public override bool NHHKCLMLLGE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public struct CPADFNOPBGB<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public readonly IEnumerable<TData> DOHLICONIOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public readonly Quaternion IEBFPKLGAFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public readonly Vector3? GKOLJLPOIIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public readonly bool PGFDEFDFLEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public readonly bool KCLMAAHKDOO;

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x4BA9270", Offset = "0x4BA8070", VA = "0x184BA9270")]
	public CPADFNOPBGB(IEnumerable<TData> DOHLICONIOE, Quaternion IEBFPKLGAFB, Vector3? GKOLJLPOIIK, bool PGFDEFDFLEG, bool KCLMAAHKDOO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public struct IIFODCAAOEF<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public readonly IEnumerable<TData> DOHLICONIOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public readonly bool KCLMAAHKDOO;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x3811540", Offset = "0x3810340", VA = "0x183811540")]
	public IIFODCAAOEF(IEnumerable<TData> DOHLICONIOE, bool KCLMAAHKDOO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public struct CFBJIAFPHCM<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public readonly IEnumerable<TData> DOHLICONIOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly Quaternion CFPEKKLDDKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public readonly IIFCDBDBPJO HDFJECEBDGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public readonly Vector3? GKOLJLPOIIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public readonly bool PGFDEFDFLEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public readonly bool KCLMAAHKDOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public readonly Space FDPANGJGIFC;

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x47FDB70", Offset = "0x47FC970", VA = "0x1847FDB70")]
	public CFBJIAFPHCM(IEnumerable<TData> DOHLICONIOE, Quaternion CFPEKKLDDKB, IIFCDBDBPJO HDFJECEBDGL, Vector3? GKOLJLPOIIK, bool PGFDEFDFLEG, bool KCLMAAHKDOO, Space FDPANGJGIFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public struct NFMKJMPHNPO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public readonly Quaternion IEBFPKLGAFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public readonly Vector3? GKOLJLPOIIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public readonly bool PGFDEFDFLEG;

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x44F1A10", Offset = "0x44F0810", VA = "0x1844F1A10")]
	public NFMKJMPHNPO(Quaternion IEBFPKLGAFB, Vector3? GKOLJLPOIIK, bool PGFDEFDFLEG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public interface OJECHIMFHIL<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NJJBJLDKJIO([In] NLPGIFHFAKL<TData> JBKIHOEKDIM);

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OAFEHELAKDL([In] KPMOPFGKJNK IMLGHGBHIMC);

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool OAFEHELAKDL([In] JOOLJCOEACK IMLGHGBHIMC);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool OAFEHELAKDL([In] IIIJGKACFBC IMLGHGBHIMC);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool PKKEAMBAALO();
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public class MHDKCGFBHAH<TData> : DDHODHGFFLN<OJECHIMFHIL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly IIIJGKACFBC IFKIDNNIBAG;

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x3D675F0", Offset = "0x3D663F0", VA = "0x183D675F0")]
	public MHDKCGFBHAH(Vector3 LLBEBIBPLAN, float HEJLHBONEPM, Vector3 GKOLJLPOIIK, bool ONEDJIOHDCP, bool FGGBGFAOELF, OJECHIMFHIL<TData> COLDMGBKDHN, Space FDPANGJGIFC = Space.Self)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x3D67590", Offset = "0x3D66390", VA = "0x183D67590", Slot = "4")]
	public override bool NHHKCLMLLGE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public class EHCCEGFLHKE<TData> : DDHODHGFFLN<OJECHIMFHIL<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x3246060", Offset = "0x3244E60", VA = "0x183246060")]
	public EHCCEGFLHKE(OJECHIMFHIL<TData> COLDMGBKDHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x3246010", Offset = "0x3244E10", VA = "0x183246010", Slot = "4")]
	public override bool NHHKCLMLLGE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public class JCBCGAIJHIA<TData> : DDHODHGFFLN<OJECHIMFHIL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly NLPGIFHFAKL<TData> IFKIDNNIBAG;

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x39A5A10", Offset = "0x39A4810", VA = "0x1839A5A10")]
	public JCBCGAIJHIA(IEnumerable<TData> DOHLICONIOE, bool KCLMAAHKDOO, OJECHIMFHIL<TData> COLDMGBKDHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x3251240", Offset = "0x3250040", VA = "0x183251240", Slot = "4")]
	public override bool NHHKCLMLLGE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class MALNMINOHHH<TData> : DDHODHGFFLN<OJECHIMFHIL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly JOOLJCOEACK IFKIDNNIBAG;

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x3D39C50", Offset = "0x3D38A50", VA = "0x183D39C50")]
	public MALNMINOHHH(float BJADMNLADEB, bool GFEDMIDAGOP, Vector3 GKOLJLPOIIK, OJECHIMFHIL<TData> COLDMGBKDHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x3D39B80", Offset = "0x3D38980", VA = "0x183D39B80", Slot = "4")]
	public override bool NHHKCLMLLGE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class CJGDAHPDMKB<TData> : DDHODHGFFLN<OJECHIMFHIL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly KPMOPFGKJNK IFKIDNNIBAG;

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x49D4520", Offset = "0x49D3320", VA = "0x1849D4520")]
	public CJGDAHPDMKB(float HEJLHBONEPM, Vector3 GKOLJLPOIIK, OJECHIMFHIL<TData> COLDMGBKDHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x36B90E0", Offset = "0x36B7EE0", VA = "0x1836B90E0", Slot = "4")]
	public override bool NHHKCLMLLGE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public struct IIIJGKACFBC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public readonly Vector3 LLBEBIBPLAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public readonly float HEJLHBONEPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public readonly Vector3 GKOLJLPOIIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public readonly bool CKCBBHEINCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public readonly Space FDPANGJGIFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public readonly bool FGGBGFAOELF;

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x5FFF330", Offset = "0x5FFE130", VA = "0x185FFF330")]
	public IIIJGKACFBC(Vector3 LLBEBIBPLAN, float HEJLHBONEPM, Vector3 GKOLJLPOIIK, bool CKCBBHEINCI, bool HIGPCEBEEKC, Space FDPANGJGIFC = Space.Self)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public struct NLPGIFHFAKL<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public readonly IEnumerable<TData> DOHLICONIOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public readonly bool KCLMAAHKDOO;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x3E04A60", Offset = "0x3E03860", VA = "0x183E04A60")]
	public NLPGIFHFAKL(IEnumerable<TData> DOHLICONIOE, bool KCLMAAHKDOO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public struct JOOLJCOEACK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public readonly float BJADMNLADEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public readonly bool GFEDMIDAGOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public readonly Vector3 GKOLJLPOIIK;

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x5FFF370", Offset = "0x5FFE170", VA = "0x185FFF370")]
	public JOOLJCOEACK(float BJADMNLADEB, bool GFEDMIDAGOP, Vector3 GKOLJLPOIIK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct KPMOPFGKJNK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public readonly float HEJLHBONEPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public readonly Vector3 GKOLJLPOIIK;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x44CE3F0", Offset = "0x44CD1F0", VA = "0x1844CE3F0")]
	public KPMOPFGKJNK(float HEJLHBONEPM, Vector3 GKOLJLPOIIK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public static class GCAFMKLAAHC
{
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	private struct GFNGKFAMOKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public bool CDNKACCJKIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public LPFNGCMIAEC FGHHNKKBOOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public LPFNGCMIAEC BEJNAPDFMCO;
	}

	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private static GFNGKFAMOKB JCMLFPCDAEI;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static CancellationToken ICKCHNHLJOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x5FFF170", Offset = "0x5FFDF70", VA = "0x185FFF170")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	internal static LPFNGCMIAEC FGHHNKKBOOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x5FFF060", Offset = "0x5FFDE60", VA = "0x185FFF060")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x5FFF100", Offset = "0x5FFDF00", VA = "0x185FFF100")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x5FFEF60", Offset = "0x5FFDD60", VA = "0x185FFEF60")]
	[OKINHFAHPEJ(OBFBFIBMGDJ.Room, FNGNILODNLI.None)]
	private static void ANEDGJPLFNN(LPFNGCMIAEC MCDHABILLAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x5FFF190", Offset = "0x5FFDF90", VA = "0x185FFF190")]
	public static void KGLPDGAIIAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x5FFF2E0", Offset = "0x5FFE0E0", VA = "0x185FFF2E0")]
	private static LPFNGCMIAEC LDKJHEHINKB(LPFNGCMIAEC INEDFHCCMAN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public static class AAEBDBDNJDB
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public enum GDAEBGEGNCE
	{
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		ICreationContextObject,
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		Guid
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x2C217E0", Offset = "0x2C205E0", VA = "0x182C217E0")]
	public static void BNFNBDGAEKM<T>(T PICGAENFGAG, GDAEBGEGNCE HJCFEPLFGPG) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x2C21780", Offset = "0x2C20580", VA = "0x182C21780")]
	public static void BNFNBDGAEKM<T>(T PICGAENFGAG) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x2C21920", Offset = "0x2C20720", VA = "0x182C21920")]
	public static void FNNPEOCDGID<T>(T PICGAENFGAG) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x2C21BA0", Offset = "0x2C209A0", VA = "0x182C21BA0")]
	public static T NAKCAFGMIJA<T>(GDAEBGEGNCE HJCFEPLFGPG) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x2C21990", Offset = "0x2C20790", VA = "0x182C21990")]
	public static bool GDDNGOCDKHE<T>(GDAEBGEGNCE HJCFEPLFGPG, T NNEBJIDDEJO, [Out] T OEMHMOAGIMP) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x2C21B00", Offset = "0x2C20900", VA = "0x182C21B00")]
	public static bool GMBEFCFOGKH<T>(GDAEBGEGNCE HJCFEPLFGPG) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x2C21AC0", Offset = "0x2C208C0", VA = "0x182C21AC0")]
	public static T NAKCAFGMIJA<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x2C21AC0", Offset = "0x2C208C0", VA = "0x182C21AC0")]
	public static bool GMBEFCFOGKH<T>() where T : class
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
internal static class LMIDEEMGAFK
{
	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x5FFF4F0", Offset = "0x5FFE2F0", VA = "0x185FFF4F0")]
	public static void MBGNNBFPAAP(IEnumerable DCPEMOIBFLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x2646C90", Offset = "0x2645A90", VA = "0x182646C90")]
	public static void MBGNNBFPAAP<T>(T[] IPODKPLEDFE) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x2646E70", Offset = "0x2645C70", VA = "0x182646E70")]
	public static void MBGNNBFPAAP<T>(T ECHPJMAFKIL) where T : notnull, Enum
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
