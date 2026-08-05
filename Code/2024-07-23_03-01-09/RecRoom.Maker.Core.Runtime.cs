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
		[Cpp2IlInjected.Address(RVA = "0x87C5D0", Offset = "0x87B7D0", VA = "0x18087C5D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6934040", Offset = "0x6933240", VA = "0x186934040")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x87D8D0", Offset = "0x87CAD0", VA = "0x18087D8D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x87D910", Offset = "0x87CB10", VA = "0x18087D910")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface EFNKGCCPOMM<TData, TReturn>
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TReturn KNAMOEELNEM(TData MEAFIMADMKA);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface CMAAKKDLBFD<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ClearHoverTarget(LCIMADDMNJK EBDNEHAMLPD);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool SetHoverTarget(TData CGKANMHMCOJ, Collider LKJCLDJFADD, LCIMADDMNJK EBDNEHAMLPD, [Optional] BCGPGMMDBCL? CGOJMBKAODP);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool TryGetHoverTarget([Out] TData CGKANMHMCOJ);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetHoverCollider([Out] Collider LKJCLDJFADD);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface OBKGCADPMOG<TData> : NFMLCDPFOBD, BAFGOCDPCPB<TData>, JNDONBIPJHI<TData>, DJGPOANJFFK<TData>, JLIDPBGEKFN, BJFIELNBPGL<TData>, CMDKKOENKKC, INNAMHHEKNH
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface BJFIELNBPGL<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 MNCFLKFGCKD, Vector3 FCBGHELDCII, float BKKDIDJOENO, [Out] T CEAPMLKABIK, [Out] Vector3 ONIACCFGFKC, [Out] Collider LKJCLDJFADD);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 MNCFLKFGCKD, Vector3 FCBGHELDCII, float IKNBGJIOLFN, float BKKDIDJOENO, T[] FOKHEGBLMPD, [Out] Vector3 NAEPBAELHIE, [Out] Collider LNPFJMPIAAO);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 MNCFLKFGCKD, float IKNBGJIOLFN, Vector3 DPEDLBLCEEE, T[] FOKHEGBLMPD);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetObjectFromColliderInCurrentScope(Collider LKIKJGEBEHP, [Out] T CAENHLLLLMH);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface NFMLCDPFOBD
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Bounds LHICCFFAAMC
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Transform GKNIFNBNOOD
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Bounds JGMGLHGAELO
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Transform JLKFILKHBJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Vector3 BNBKKLBLACN
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool HBIJJKCOAHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void SetSelectionBoundsDirty(bool BEDDACEANCB = true, int HBLIFLBHKPF = 0);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ShouldHideSelectionBoundsPreview(bool NKAGDBODKJE, object EOCJCEFCOOA);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface INNAMHHEKNH
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	EHODCIMNDCH CNAEIJJFMND
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface CLJJKLCHBOC
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool KDEMPFIMNPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool CNHJANCCPLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool EDPGMOBGBCI
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
	void TrySetPreviousCloneMapping(Dictionary<Guid, Guid> OHMEKHBNFIA);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface DJGPOANJFFK<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool LHAOAFIKFHP
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int DPGOHACKAGK
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<TData> MKIAGEMPJGP
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData JNHGHHKKNBB);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData JNHGHHKKNBB);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface BAFGOCDPCPB<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T MEAFIMADMKA, [Optional] BCGPGMMDBCL? AHGKEHOFKKH, bool ADKCABKIMNP = true);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int IHGHLPOONHD, IEnumerable<T> HNFHFEEOANA, bool ADKCABKIMNP = true);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int IHGHLPOONHD, IEnumerable<T> HNFHFEEOANA, BCGPGMMDBCL AHGKEHOFKKH, bool ADKCABKIMNP = true);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface CMDKKOENKKC
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface JLIDPBGEKFN
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool PBPBNDKBMND
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool JNPCDKACAJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool PFDNONEMLBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool OLCJAAEEKBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class MPLCCFJEIBC<TReceiver> : DGFLINFDMLL<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3B77FE0", Offset = "0x3B771E0", VA = "0x183B77FE0")]
	public MPLCCFJEIBC(TReceiver JGBHEKHPCJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class ANCACNFNMBL<TReceiver, TFromTask> : DGFLINFDMLL<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3B77FE0", Offset = "0x3B771E0", VA = "0x183B77FE0")]
	public ANCACNFNMBL(TReceiver JGBHEKHPCJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public abstract class DGFLINFDMLL<TReceiver, TFromExecute> where TReceiver : notnull where TFromExecute : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	protected TReceiver JGBHEKHPCJH;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5764E90", Offset = "0x5764090", VA = "0x185764E90")]
	public DGFLINFDMLL(TReceiver JGBHEKHPCJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute MHMACPKANBJ();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public abstract class IHPPJFDEIAP<TReceiver, TResult> : DGFLINFDMLL<TReceiver, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3B77FE0", Offset = "0x3B771E0", VA = "0x183B77FE0")]
	public IHPPJFDEIAP(TReceiver JGBHEKHPCJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct ILDBLJHHBNO<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public TGroup OCNMMBPGLEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public TData AIKLIDODFOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public IEnumerable<TData> PKPFIJFKJFC;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1EB3A20", Offset = "0x1EB2C20", VA = "0x181EB3A20")]
	public ILDBLJHHBNO(TGroup NDLEFBGLFHN, TData PANHNMCDPHD, IEnumerable<TData> DAOAKLHKOJP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct NFDMNGBJOGG<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public TGroup OCNMMBPGLEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public IEnumerable<TData> PKPFIJFKJFC;

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0xAB26B0", Offset = "0xAB18B0", VA = "0x180AB26B0")]
	public NFDMNGBJOGG(TGroup NDLEFBGLFHN, IEnumerable<TData> DAOAKLHKOJP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct FECEACJOFAM<TGroup> where TGroup : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public TGroup OCNMMBPGLEG;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x927530", Offset = "0x926730", VA = "0x180927530")]
	public FECEACJOFAM(TGroup NDLEFBGLFHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct BNDOCPLMCEB<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public IEnumerable<TData> PKPFIJFKJFC;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x927530", Offset = "0x926730", VA = "0x180927530")]
	public BNDOCPLMCEB(IEnumerable<TData> DAOAKLHKOJP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface AALPCOIGLNB<TGroup, TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MBPHFKAHBDA FJKNANJPHGE(ILDBLJHHBNO<TGroup, TData> JLLJCNJHCDE);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MBPHFKAHBDA JMJEBJJBMKA(ILDBLJHHBNO<TGroup, TData> JLLJCNJHCDE);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MBPHFKAHBDA KFPJMBOOEIL(NFDMNGBJOGG<TGroup, TData> JLLJCNJHCDE);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MBPHFKAHBDA GJKFOMNFGIL(FECEACJOFAM<TGroup> JLLJCNJHCDE);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface IPBKADJPOLG<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<MBPHFKAHBDA> FJKNANJPHGE(BNDOCPLMCEB<TData> JLLJCNJHCDE);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class AGIAKBJEIFF<TGroup, TData> : IHPPJFDEIAP<AALPCOIGLNB<TGroup, TData>, MBPHFKAHBDA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly NFDMNGBJOGG<TGroup, TData> JLLJCNJHCDE;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3C73040", Offset = "0x3C72240", VA = "0x183C73040")]
	public AGIAKBJEIFF(TGroup NDLEFBGLFHN, IEnumerable<TData> DAOAKLHKOJP, AALPCOIGLNB<TGroup, TData> JGBHEKHPCJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3C72F70", Offset = "0x3C72170", VA = "0x183C72F70", Slot = "4")]
	public override MBPHFKAHBDA MHMACPKANBJ()
	{
		return default(MBPHFKAHBDA);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class MJCKFLEBIBL<TGroup, TData> : IHPPJFDEIAP<AALPCOIGLNB<TGroup, TData>, MBPHFKAHBDA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly ILDBLJHHBNO<TGroup, TData> JLLJCNJHCDE;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3CAE780", Offset = "0x3CAD980", VA = "0x183CAE780")]
	public MJCKFLEBIBL(TGroup NDLEFBGLFHN, TData ELNBGCCHNNA, IEnumerable<TData> DAOAKLHKOJP, AALPCOIGLNB<TGroup, TData> JGBHEKHPCJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x44ABA60", Offset = "0x44AAC60", VA = "0x1844ABA60", Slot = "4")]
	public override MBPHFKAHBDA MHMACPKANBJ()
	{
		return default(MBPHFKAHBDA);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class BMCOALGHMII<TGroup, TData> : IHPPJFDEIAP<AALPCOIGLNB<TGroup, TData>, MBPHFKAHBDA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly FECEACJOFAM<TGroup> JLLJCNJHCDE;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3C65D10", Offset = "0x3C64F10", VA = "0x183C65D10")]
	public BMCOALGHMII(TGroup NDLEFBGLFHN, AALPCOIGLNB<TGroup, TData> JGBHEKHPCJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4E79580", Offset = "0x4E78780", VA = "0x184E79580", Slot = "4")]
	public override MBPHFKAHBDA MHMACPKANBJ()
	{
		return default(MBPHFKAHBDA);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class GBJONLAJPOO<TGroup, TData> : IHPPJFDEIAP<AALPCOIGLNB<TGroup, TData>, MBPHFKAHBDA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly ILDBLJHHBNO<TGroup, TData> JLLJCNJHCDE;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3CAE780", Offset = "0x3CAD980", VA = "0x183CAE780")]
	public GBJONLAJPOO(TGroup NDLEFBGLFHN, TData PANHNMCDPHD, IEnumerable<TData> DAOAKLHKOJP, AALPCOIGLNB<TGroup, TData> JGBHEKHPCJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3CAE6A0", Offset = "0x3CAD8A0", VA = "0x183CAE6A0", Slot = "4")]
	public override MBPHFKAHBDA MHMACPKANBJ()
	{
		return default(MBPHFKAHBDA);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class BEDAAKEOKMK<TData> : ANCACNFNMBL<IPBKADJPOLG<TData>, MBPHFKAHBDA> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private struct EAPCPOPIMFB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AsyncTaskMethodBuilder<MBPHFKAHBDA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public BEDAAKEOKMK<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private TaskAwaiter<MBPHFKAHBDA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x37E4FA0", Offset = "0x37E41A0", VA = "0x1837E4FA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x37E5240", Offset = "0x37E4440", VA = "0x1837E5240", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private BNDOCPLMCEB<TData> JLLJCNJHCDE;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3C65D10", Offset = "0x3C64F10", VA = "0x183C65D10")]
	public BEDAAKEOKMK(IEnumerable<TData> PONJJADJKNM, IPBKADJPOLG<TData> JGBHEKHPCJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x4E18E10", Offset = "0x4E18010", VA = "0x184E18E10", Slot = "4")]
	[AsyncStateMachine(typeof(BEDAAKEOKMK<>.EAPCPOPIMFB))]
	public override Task<MBPHFKAHBDA> MHMACPKANBJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct OMLHACBGKDM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly ADEMCCFAMAC LDLGFMCPBKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly bool ECDPJAICEBH;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x69340C0", Offset = "0x69332C0", VA = "0x1869340C0")]
	public OMLHACBGKDM(ADEMCCFAMAC PKLJNIOHBDN, bool ICKBFDJMHAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface OFONNBNMIFK<TSpawnType> where TSpawnType : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> MHMACPKANBJ(OMLHACBGKDM JFAFCFECMAK);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class KDGPKJDDDOA<TSpawnType> : ANCACNFNMBL<OFONNBNMIFK<TSpawnType>, TSpawnType> where TSpawnType : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private struct JMCBNDIOMGF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public AsyncTaskMethodBuilder<TSpawnType> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public KDGPKJDDDOA<TSpawnType> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskAwaiter<TSpawnType> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x40BAE60", Offset = "0x40BA060", VA = "0x1840BAE60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x40BB5E0", Offset = "0x40BA7E0", VA = "0x1840BB5E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly OMLHACBGKDM JFAFCFECMAK;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x41807B0", Offset = "0x417F9B0", VA = "0x1841807B0")]
	public KDGPKJDDDOA(ADEMCCFAMAC PKLJNIOHBDN, bool ICKBFDJMHAM, OFONNBNMIFK<TSpawnType> JGBHEKHPCJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x41805B0", Offset = "0x417F7B0", VA = "0x1841805B0", Slot = "4")]
	[AsyncStateMachine(typeof(KDGPKJDDDOA<>.JMCBNDIOMGF))]
	public override Task<TSpawnType> MHMACPKANBJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public readonly struct ADEMCCFAMAC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly bool NPCGMAONJAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly Vector3 HIKGGMOMAFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly Vector3 PHJFFHJCDOD;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6932F40", Offset = "0x6932140", VA = "0x186932F40")]
	public ADEMCCFAMAC(Transform NKMFGHABALJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6932F10", Offset = "0x6932110", VA = "0x186932F10")]
	public ADEMCCFAMAC(Vector3 NFFLDAHKGKD, Vector3 HGDCPNGLIKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6932EE0", Offset = "0x69320E0", VA = "0x186932EE0")]
	public static ADEMCCFAMAC IJDMAMHKEEG()
	{
		return default(ADEMCCFAMAC);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6932FB0", Offset = "0x69321B0", VA = "0x186932FB0")]
	private ADEMCCFAMAC(bool MPDAKJKJBHK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct HKMIMPHIKIC<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public TNode PMEFMMPKIJP;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3D3E8B0", Offset = "0x3D3DAB0", VA = "0x183D3E8B0")]
	public HKMIMPHIKIC(TNode PMEFMMPKIJP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct LOHIHNFNHCL<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public TNode GBFFCNOEMBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public GDANCJFAIKC COKKIDACABK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly bool ECDPJAICEBH;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x42AB920", Offset = "0x42AAB20", VA = "0x1842AB920")]
	public LOHIHNFNHCL(TNode GBFFCNOEMBI, GDANCJFAIKC COKKIDACABK, bool ICKBFDJMHAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface KONBGGLEBDL<TNode>
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PMKBIBIDAOD([In] HKMIMPHIKIC<TNode> EGPNMAEBJKB);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NLMPBMFAOCI([In] LOHIHNFNHCL<TNode> OPKIIKFDIMF);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KJPDMMCNMMK();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class JNKABCELNMN<TNode> : MPLCCFJEIBC<KONBGGLEBDL<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3B77FE0", Offset = "0x3B771E0", VA = "0x183B77FE0")]
	public JNKABCELNMN(KONBGGLEBDL<TNode> JGBHEKHPCJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x40BA5A0", Offset = "0x40B97A0", VA = "0x1840BA5A0", Slot = "4")]
	public override bool MHMACPKANBJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class NAHLNJHIKGN<TNode> : MPLCCFJEIBC<KONBGGLEBDL<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly LOHIHNFNHCL<TNode> OPKIIKFDIMF;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x450B4B0", Offset = "0x450A6B0", VA = "0x18450B4B0")]
	public NAHLNJHIKGN(TNode GBFFCNOEMBI, GDANCJFAIKC COKKIDACABK, KONBGGLEBDL<TNode> JGBHEKHPCJH, bool ICKBFDJMHAM = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3C98920", Offset = "0x3C97B20", VA = "0x183C98920", Slot = "4")]
	public override bool MHMACPKANBJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class LOCBLLONBGH<TNode> : MPLCCFJEIBC<KONBGGLEBDL<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly HKMIMPHIKIC<TNode> EGPNMAEBJKB;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x42AA810", Offset = "0x42A9A10", VA = "0x1842AA810")]
	public LOCBLLONBGH(TNode MAGHFDICLEF, KONBGGLEBDL<TNode> JGBHEKHPCJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3C65BC0", Offset = "0x3C64DC0", VA = "0x183C65BC0", Slot = "4")]
	public override bool MHMACPKANBJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct GKNMKDGMHMB<TSpawnInfo> where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public TSpawnInfo HPPFOOOAGCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public Vector3 HGDCPNGLIKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Quaternion LCDJINCAHMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public float CDPPGBMBKAI;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3CD5380", Offset = "0x3CD4580", VA = "0x183CD5380")]
	public GKNMKDGMHMB(TSpawnInfo HPPFOOOAGCD, Vector3 HGDCPNGLIKJ, Quaternion LCDJINCAHMD, float CDPPGBMBKAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface LHDEEODGCLO<TSpawnType, TSpawnInfo>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> IPIHFLOLIKP([In] GKNMKDGMHMB<TSpawnInfo> LIPKMEEIAPD, CancellationToken MPLGBOFHPLM);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class NMOPMLPHCAF<TSpawnType, TSpawnInfo> : ANCACNFNMBL<LHDEEODGCLO<TSpawnType, TSpawnInfo>, TSpawnType> where TSpawnType : notnull where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly GKNMKDGMHMB<TSpawnInfo> FJCOFFFFCFE;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x4542920", Offset = "0x4541B20", VA = "0x184542920")]
	public NMOPMLPHCAF(TSpawnInfo GDAKDEIOKPA, Vector3 HGDCPNGLIKJ, Quaternion LCDJINCAHMD, float CDPPGBMBKAI, LHDEEODGCLO<TSpawnType, TSpawnInfo> JGBHEKHPCJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x37FB4E0", Offset = "0x37FA6E0", VA = "0x1837FB4E0", Slot = "4")]
	public override Task<TSpawnType> MHMACPKANBJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct JJGKMEPACLA<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly IEnumerable<TData> PKPFIJFKJFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly bool ECDPJAICEBH;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x40B8930", Offset = "0x40B7B30", VA = "0x1840B8930")]
	public JJGKMEPACLA(IEnumerable<TData> DAOAKLHKOJP, bool ICKBFDJMHAM = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface KKMLJEHOAEE<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<MBPHFKAHBDA> NJJFKJJENPM([In] JJGKMEPACLA<TData> LNHPCLOOINL, CancellationToken MPLGBOFHPLM);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class EJOFNNKOMJB<TData> : ANCACNFNMBL<KKMLJEHOAEE<TData>, MBPHFKAHBDA> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly JJGKMEPACLA<TData> FCNLILLFGOK;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x37FB660", Offset = "0x37FA860", VA = "0x1837FB660")]
	public EJOFNNKOMJB(IEnumerable<TData> DAOAKLHKOJP, bool ICKBFDJMHAM, KKMLJEHOAEE<TData> JGBHEKHPCJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x37FB4E0", Offset = "0x37FA6E0", VA = "0x1837FB4E0", Slot = "4")]
	public override Task<MBPHFKAHBDA> MHMACPKANBJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct CHPPKHHJLPH<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public readonly T CGKANMHMCOJ;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x4BD0260", Offset = "0x4BCF460", VA = "0x184BD0260")]
	public CHPPKHHJLPH(T CBHOMCFMBNO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface EJFEJCIBLBD<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PMKBIBIDAOD([In] CHPPKHHJLPH<T> KFPKHLALBGI);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NLMPBMFAOCI();
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface OLFMEBFOAPF<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MHMACPKANBJ([In] ANPBLDNLHND<T> BHGHKFBMJGE);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct ANPBLDNLHND<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public readonly T CGKANMHMCOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public readonly bool GKBAGEPADEO;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x3C9D190", Offset = "0x3C9C390", VA = "0x183C9D190")]
	public ANPBLDNLHND(T CBHOMCFMBNO, bool JEDMGNPHHLC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class MLDDILLKDDH<T> : MPLCCFJEIBC<EJFEJCIBLBD<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x3B77FE0", Offset = "0x3B771E0", VA = "0x183B77FE0")]
	public MLDDILLKDDH(EJFEJCIBLBD<T> JGBHEKHPCJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x44AEC30", Offset = "0x44ADE30", VA = "0x1844AEC30", Slot = "4")]
	public override bool MHMACPKANBJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class ABILNFEAOOH<T> : MPLCCFJEIBC<EJFEJCIBLBD<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly CHPPKHHJLPH<T> KFPKHLALBGI;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x3C65C80", Offset = "0x3C64E80", VA = "0x183C65C80")]
	public ABILNFEAOOH(T CGKANMHMCOJ, EJFEJCIBLBD<T> JGBHEKHPCJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x3C65BC0", Offset = "0x3C64DC0", VA = "0x183C65BC0", Slot = "4")]
	public override bool MHMACPKANBJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class GHLMBKBAGLJ<T> : MPLCCFJEIBC<OLFMEBFOAPF<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly ANPBLDNLHND<T> BHGHKFBMJGE;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x3CD12C0", Offset = "0x3CD04C0", VA = "0x183CD12C0")]
	public GHLMBKBAGLJ(T CGKANMHMCOJ, bool JEDMGNPHHLC, OLFMEBFOAPF<T> JGBHEKHPCJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x3C65BC0", Offset = "0x3C64DC0", VA = "0x183C65BC0", Slot = "4")]
	public override bool MHMACPKANBJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct OABEAJBPENA<TData> where TData : notnull, LBGCFBLOJCL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public IEnumerable<TData> PKPFIJFKJFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public bool FJANIEEFIIE;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4616980", Offset = "0x4615B80", VA = "0x184616980")]
	public OABEAJBPENA(IEnumerable<TData> KECKJMIIBIG, bool GOJBOODIPLG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct JPGFHKOABLP<TData> where TData : notnull, LBGCFBLOJCL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public List<TData> PKPFIJFKJFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public List<bool> CPOHMBGJLLO;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x40C9520", Offset = "0x40C8720", VA = "0x1840C9520")]
	public JPGFHKOABLP(List<TData> KECKJMIIBIG, List<bool> OCBFKIOEGBK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface LBGCFBLOJCL
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool COEAHMBAKNE
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
public interface MNPIJKOMJNP<TData> where TData : LBGCFBLOJCL
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MHMACPKANBJ([In] OABEAJBPENA<TData> BCHLMKMNMIE);

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MHMACPKANBJ([In] JPGFHKOABLP<TData> BCHLMKMNMIE);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface NHFPGGGGADD<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OOCPLBCLGFN(T CGKANMHMCOJ);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class MGNJKPINDCC<TData> : MPLCCFJEIBC<MNPIJKOMJNP<TData>> where TData : notnull, LBGCFBLOJCL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly OABEAJBPENA<TData> BCHLMKMNMIE;

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x44A7C10", Offset = "0x44A6E10", VA = "0x1844A7C10")]
	public MGNJKPINDCC(List<TData> DAOAKLHKOJP, bool FJANIEEFIIE, MNPIJKOMJNP<TData> JGBHEKHPCJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x3C65BC0", Offset = "0x3C64DC0", VA = "0x183C65BC0", Slot = "4")]
	public override bool MHMACPKANBJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class JACMLCJMPMD<TData> : MPLCCFJEIBC<MNPIJKOMJNP<TData>> where TData : notnull, LBGCFBLOJCL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly JPGFHKOABLP<TData> BCHLMKMNMIE;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x4098EB0", Offset = "0x40980B0", VA = "0x184098EB0")]
	public JACMLCJMPMD(List<TData> DAOAKLHKOJP, List<bool> CPOHMBGJLLO, MNPIJKOMJNP<TData> JGBHEKHPCJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x4098DF0", Offset = "0x4097FF0", VA = "0x184098DF0", Slot = "4")]
	public override bool MHMACPKANBJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface FOGOHHCBCLG<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<MBPHFKAHBDA> MHMACPKANBJ(HFEJEOPJMKA<TData> JCBAPIJMACM);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public class FIEICEHFCND<TData> : ANCACNFNMBL<FOGOHHCBCLG<TData>, MBPHFKAHBDA> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct JMDHCOOIHMK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public AsyncTaskMethodBuilder<MBPHFKAHBDA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public FIEICEHFCND<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter<MBPHFKAHBDA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x40BB670", Offset = "0x40BA870", VA = "0x1840BB670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x40BB950", Offset = "0x40BAB50", VA = "0x1840BB950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly HFEJEOPJMKA<TData> DAMACGPJLMJ;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x3BEF780", Offset = "0x3BEE980", VA = "0x183BEF780")]
	public FIEICEHFCND(TData GICECCKPGNJ, IReadOnlyList<TData> DJGIIJGMCGJ, bool ICKBFDJMHAM, FOGOHHCBCLG<TData> JGBHEKHPCJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x3BEF680", Offset = "0x3BEE880", VA = "0x183BEF680", Slot = "4")]
	[AsyncStateMachine(typeof(FIEICEHFCND<>.JMDHCOOIHMK))]
	public override Task<MBPHFKAHBDA> MHMACPKANBJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public struct HFEJEOPJMKA<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public TData GDENGLHFDEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public IReadOnlyList<TData> ICFKGLDEALM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public bool ECDPJAICEBH;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x3D1A680", Offset = "0x3D19880", VA = "0x183D1A680")]
	public HFEJEOPJMKA(TData GICECCKPGNJ, IReadOnlyList<TData> DJGIIJGMCGJ, bool ICKBFDJMHAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface LGFAGBLLLNH<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MHMACPKANBJ([In] ECAIOCGJEME<TData> BEPKGCIPFML);
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface APJHBBCBEFH<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MHMACPKANBJ([In] DNBLGAEEMCO<TData> BEPKGCIPFML);
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface FDMGNCHNCHI<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NCFDLBJAECD([In] PADGMLBDJID<TData> BEPKGCIPFML);

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NLMPBMFAOCI();
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class KACGDONABOC<TData> : MPLCCFJEIBC<LGFAGBLLLNH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly ECAIOCGJEME<TData> BEPKGCIPFML;

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x4176890", Offset = "0x4175A90", VA = "0x184176890")]
	public KACGDONABOC(IEnumerable<TData> DAOAKLHKOJP, IEBHIHOELNJ KIJNHGNFMMA, ONPJCPBADJL GIIKGEKINDH, float LKLDNMFNIIN, bool ICKBFDJMHAM, LGFAGBLLLNH<TData> JGBHEKHPCJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x3C65BC0", Offset = "0x3C64DC0", VA = "0x183C65BC0", Slot = "4")]
	public override bool MHMACPKANBJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class AOKOBLCBNFG<TData> : MPLCCFJEIBC<APJHBBCBEFH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly DNBLGAEEMCO<TData> BEPKGCIPFML;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x3C9DF60", Offset = "0x3C9D160", VA = "0x183C9DF60")]
	public AOKOBLCBNFG(TData[] DAOAKLHKOJP, IEBHIHOELNJ[] KIJNHGNFMMA, ONPJCPBADJL[] GIIKGEKINDH, float[] LKLDNMFNIIN, APJHBBCBEFH<TData> JGBHEKHPCJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3C9DEA0", Offset = "0x3C9D0A0", VA = "0x183C9DEA0", Slot = "4")]
	public override bool MHMACPKANBJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class BIODOGGAPDF<TData> : MPLCCFJEIBC<FDMGNCHNCHI<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3B77FE0", Offset = "0x3B771E0", VA = "0x183B77FE0")]
	public BIODOGGAPDF(FDMGNCHNCHI<TData> JGBHEKHPCJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x4E41DD0", Offset = "0x4E40FD0", VA = "0x184E41DD0", Slot = "4")]
	public override bool MHMACPKANBJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class GCIGNHMIFFC<TData> : MPLCCFJEIBC<FDMGNCHNCHI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly PADGMLBDJID<TData> BEPKGCIPFML;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3CB1CD0", Offset = "0x3CB0ED0", VA = "0x183CB1CD0")]
	public GCIGNHMIFFC(IEnumerable<TData> DAOAKLHKOJP, IEBHIHOELNJ KIJNHGNFMMA, ONPJCPBADJL GIIKGEKINDH, float LKLDNMFNIIN, FDMGNCHNCHI<TData> JGBHEKHPCJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3C9DEA0", Offset = "0x3C9D0A0", VA = "0x183C9DEA0", Slot = "4")]
	public override bool MHMACPKANBJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public struct ECAIOCGJEME<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public IEnumerable<TData> PKPFIJFKJFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public IEBHIHOELNJ GMOFENMBBNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public ONPJCPBADJL KHHANACNIEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public float LKLDNMFNIIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public bool ICKBFDJMHAM;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x37E7590", Offset = "0x37E6790", VA = "0x1837E7590")]
	public ECAIOCGJEME(IEnumerable<TData> DAOAKLHKOJP, IEBHIHOELNJ KIJNHGNFMMA, ONPJCPBADJL GIIKGEKINDH, float LKLDNMFNIIN, bool ICKBFDJMHAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct DNBLGAEEMCO<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public TData[] PKPFIJFKJFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public IEBHIHOELNJ[] GMOFENMBBNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public ONPJCPBADJL[] KHHANACNIEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public float[] LKLDNMFNIIN;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x578FCB0", Offset = "0x578EEB0", VA = "0x18578FCB0")]
	public DNBLGAEEMCO(TData[] DAOAKLHKOJP, IEBHIHOELNJ[] KIJNHGNFMMA, ONPJCPBADJL[] GIIKGEKINDH, float[] LKLDNMFNIIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public struct PADGMLBDJID<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public IEnumerable<TData> PKPFIJFKJFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public IEBHIHOELNJ GMOFENMBBNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public ONPJCPBADJL KHHANACNIEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public float LKLDNMFNIIN;

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x4753990", Offset = "0x4752B90", VA = "0x184753990")]
	public PADGMLBDJID(IEnumerable<TData> DAOAKLHKOJP, IEBHIHOELNJ KIJNHGNFMMA, ONPJCPBADJL GIIKGEKINDH, float LKLDNMFNIIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public interface JNDONBIPJHI<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KFPJMBOOEIL([In] JPFELJHAKBP<TData> LNHPCLOOINL);

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GJKFOMNFGIL([In] JPFELJHAKBP<TData> LNHPCLOOINL);

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LHFDGMPNMLP([In] bool LANHKFPEAJN);

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IDNPJCDOJDP([In] JPFELJHAKBP<TData> LNHPCLOOINL);

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NKHNENGMEGP();

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool LHNIMBHLFPJ([In] TData ENAIEPHGJHL);
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class DHKKJCIHPBI<TData> : MPLCCFJEIBC<JNDONBIPJHI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly JPFELJHAKBP<TData> LNHPCLOOINL;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5768DF0", Offset = "0x5767FF0", VA = "0x185768DF0")]
	public DHKKJCIHPBI(List<TData> FDPJMKODKPJ, JNDONBIPJHI<TData> JGBHEKHPCJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3C65BC0", Offset = "0x3C64DC0", VA = "0x183C65BC0", Slot = "4")]
	public override bool MHMACPKANBJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class MFMPLAILHDH<TData> : MPLCCFJEIBC<JNDONBIPJHI<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3B77FE0", Offset = "0x3B771E0", VA = "0x183B77FE0")]
	public MFMPLAILHDH(JNDONBIPJHI<TData> JGBHEKHPCJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x44A5C10", Offset = "0x44A4E10", VA = "0x1844A5C10", Slot = "4")]
	public override bool MHMACPKANBJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class MCNHFBMHAHE<TData> : MPLCCFJEIBC<JNDONBIPJHI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly bool ICKBFDJMHAM;

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x4491ED0", Offset = "0x44910D0", VA = "0x184491ED0")]
	public MCNHFBMHAHE(bool ICKBFDJMHAM, JNDONBIPJHI<TData> JGBHEKHPCJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x4491E70", Offset = "0x4491070", VA = "0x184491E70", Slot = "4")]
	public override bool MHMACPKANBJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class ONENLCOCGEF<TData> : MPLCCFJEIBC<JNDONBIPJHI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly JPFELJHAKBP<TData> LNHPCLOOINL;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x46B61D0", Offset = "0x46B53D0", VA = "0x1846B61D0")]
	public ONENLCOCGEF(List<TData> FDPJMKODKPJ, bool ICKBFDJMHAM, JNDONBIPJHI<TData> JGBHEKHPCJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x4098DF0", Offset = "0x4097FF0", VA = "0x184098DF0", Slot = "4")]
	public override bool MHMACPKANBJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class NLOHNMFKOIP<TData> : MPLCCFJEIBC<JNDONBIPJHI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly TData ENAIEPHGJHL;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x4541190", Offset = "0x4540390", VA = "0x184541190")]
	public NLOHNMFKOIP(TData ENAIEPHGJHL, JNDONBIPJHI<TData> JGBHEKHPCJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x45410D0", Offset = "0x45402D0", VA = "0x1845410D0", Slot = "4")]
	public override bool MHMACPKANBJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class CCGIDCKHKKF<TData> : MPLCCFJEIBC<JNDONBIPJHI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly JPFELJHAKBP<TData> LNHPCLOOINL;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x5020E00", Offset = "0x5020000", VA = "0x185020E00")]
	public CCGIDCKHKKF(IEnumerable<TData> FDPJMKODKPJ, JNDONBIPJHI<TData> JGBHEKHPCJH, bool ICKBFDJMHAM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x5020C90", Offset = "0x501FE90", VA = "0x185020C90", Slot = "4")]
	public override bool MHMACPKANBJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public struct JPFELJHAKBP<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public IEnumerable<TData> PKPFIJFKJFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public bool ICKBFDJMHAM;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x40C9210", Offset = "0x40C8410", VA = "0x1840C9210")]
	public JPFELJHAKBP(IEnumerable<TData> KECKJMIIBIG, bool KOPDBAKHFMH = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public interface MDOKGBDFNAC
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<MBPHFKAHBDA> MHMACPKANBJ(HOOACOENDBC JHGHOPPOKKA);
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class BIILNGAFNPE : ANCACNFNMBL<MDOKGBDFNAC, MBPHFKAHBDA>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private struct LALMNEDLMNJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public AsyncTaskMethodBuilder<MBPHFKAHBDA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public BIILNGAFNPE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private TaskAwaiter<MBPHFKAHBDA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6933D10", Offset = "0x6932F10", VA = "0x186933D10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6933F90", Offset = "0x6933190", VA = "0x186933F90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly HOOACOENDBC MAHCEEJIBAP;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x69332A0", Offset = "0x69324A0", VA = "0x1869332A0")]
	public BIILNGAFNPE(bool ICKBFDJMHAM, MDOKGBDFNAC JGBHEKHPCJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x69331B0", Offset = "0x69323B0", VA = "0x1869331B0", Slot = "4")]
	[AsyncStateMachine(typeof(LALMNEDLMNJ))]
	public override Task<MBPHFKAHBDA> MHMACPKANBJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct HOOACOENDBC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public bool ECDPJAICEBH;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x217A0A0", Offset = "0x21792A0", VA = "0x18217A0A0")]
	public HOOACOENDBC(bool ICKBFDJMHAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public readonly struct JHLFFKLBDNI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly bool PDJKNBGNJMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly bool ICCLKMDOGAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public readonly bool CDPPGBMBKAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public readonly bool ICKBFDJMHAM;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4CD4C70", Offset = "0x4CD3E70", VA = "0x184CD4C70")]
	public JHLFFKLBDNI(bool PDJKNBGNJMA, bool ICCLKMDOGAK, bool CDPPGBMBKAI, bool ICKBFDJMHAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6933C20", Offset = "0x6932E20", VA = "0x186933C20")]
	public JHLFFKLBDNI(bool ICCLKMDOGAK, bool ICKBFDJMHAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface IAOBGOONBMJ
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KMDMMILLIKF(JHLFFKLBDNI CDENHMEAJDI);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KBCPPHEOCEP(JHLFFKLBDNI CDENHMEAJDI);
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class KPJCIMJEAFG : MPLCCFJEIBC<IAOBGOONBMJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly JHLFFKLBDNI CDENHMEAJDI;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6933C80", Offset = "0x6932E80", VA = "0x186933C80")]
	public KPJCIMJEAFG(bool FMAJPAMCPCL, bool ICCLKMDOGAK, bool CDPPGBMBKAI, bool ICKBFDJMHAM, IAOBGOONBMJ JGBHEKHPCJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6933C30", Offset = "0x6932E30", VA = "0x186933C30", Slot = "4")]
	public override bool MHMACPKANBJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class FFHJBMBNDJO : MPLCCFJEIBC<IAOBGOONBMJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly JHLFFKLBDNI CDENHMEAJDI;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6933B80", Offset = "0x6932D80", VA = "0x186933B80")]
	public FFHJBMBNDJO(bool ICCLKMDOGAK, bool ICKBFDJMHAM, IAOBGOONBMJ JGBHEKHPCJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6933B30", Offset = "0x6932D30", VA = "0x186933B30", Slot = "4")]
	public override bool MHMACPKANBJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public interface HGEDKOOAEOL
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MHMACPKANBJ([In] ECNJOJAKMKA JIPBKMKNIIL);
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class ABEEFHOCELK : MPLCCFJEIBC<HGEDKOOAEOL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly ECNJOJAKMKA JIPBKMKNIIL;

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6932D00", Offset = "0x6931F00", VA = "0x186932D00")]
	public ABEEFHOCELK(Guid[] GKPDKIBFIPB, Vector3[] AKBGHODCILL, Quaternion[] HJGHGHMJHDC, float[] LLHAAJHEAOL, Dictionary<Guid, Vector3> HFEEIDEHBGE, HGEDKOOAEOL JGBHEKHPCJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6932C50", Offset = "0x6931E50", VA = "0x186932C50", Slot = "4")]
	public override bool MHMACPKANBJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public interface ICDFIDOADNM<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PMKBIBIDAOD([In] HNONFECGPHM<TData> EGPNMAEBJKB);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NCFDLBJAECD([In] HBPFFFILEMF BLOGBAAPLIH);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NCFDLBJAECD([In] AJANKAGNKAC BLOGBAAPLIH);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool NLMPBMFAOCI();
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class NINAPHBPFEM<TData> : MPLCCFJEIBC<ICDFIDOADNM<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x3B77FE0", Offset = "0x3B771E0", VA = "0x183B77FE0")]
	public NINAPHBPFEM(ICDFIDOADNM<TData> JGBHEKHPCJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x452CA90", Offset = "0x452BC90", VA = "0x18452CA90", Slot = "4")]
	public override bool MHMACPKANBJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class LPOIJHLLBOH<TData> : MPLCCFJEIBC<ICDFIDOADNM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly HBPFFFILEMF EJHNAAOJOOB;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x42AFA90", Offset = "0x42AEC90", VA = "0x1842AFA90")]
	public LPOIJHLLBOH(Vector3 FACOLELGOBD, bool BOINHNBBNNI, ICDFIDOADNM<TData> JGBHEKHPCJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x4245840", Offset = "0x4244A40", VA = "0x184245840", Slot = "4")]
	public override bool MHMACPKANBJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class IBFPOOJPIOM<TData> : MPLCCFJEIBC<ICDFIDOADNM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly AJANKAGNKAC EJHNAAOJOOB;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x3E2F110", Offset = "0x3E2E310", VA = "0x183E2F110")]
	public IBFPOOJPIOM(Guid PCJIJJPJEJN, int DHNLEFJCEAH, Vector3 HGDCPNGLIKJ, Quaternion LCDJINCAHMD, float EOGPEOAFBNO, bool BOINHNBBNNI, ICDFIDOADNM<TData> JGBHEKHPCJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x3E2F0B0", Offset = "0x3E2E2B0", VA = "0x183E2F0B0", Slot = "4")]
	public override bool MHMACPKANBJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class KALGHDDLJJH<TData> : MPLCCFJEIBC<ICDFIDOADNM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly HNONFECGPHM<TData> EJHNAAOJOOB;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x4176D10", Offset = "0x4175F10", VA = "0x184176D10")]
	public KALGHDDLJJH(TData CGKANMHMCOJ, bool ICKBFDJMHAM, ICDFIDOADNM<TData> JGBHEKHPCJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x3C65BC0", Offset = "0x3C64DC0", VA = "0x183C65BC0", Slot = "4")]
	public override bool MHMACPKANBJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public struct HBPFFFILEMF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly Vector3 FACOLELGOBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public readonly bool BOINHNBBNNI;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x6933C00", Offset = "0x6932E00", VA = "0x186933C00")]
	public HBPFFFILEMF(Vector3 FACOLELGOBD, bool BOINHNBBNNI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public struct AJANKAGNKAC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public readonly Guid PCJIJJPJEJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public readonly int DHNLEFJCEAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public readonly Vector3 HGDCPNGLIKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public readonly Quaternion LCDJINCAHMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public readonly float EOGPEOAFBNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public readonly bool BOINHNBBNNI;

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6933040", Offset = "0x6932240", VA = "0x186933040")]
	public AJANKAGNKAC(Guid PCJIJJPJEJN, int DHNLEFJCEAH, Vector3 HGDCPNGLIKJ, Quaternion LCDJINCAHMD, float EOGPEOAFBNO, bool BOINHNBBNNI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public struct HNONFECGPHM<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public readonly TData CGKANMHMCOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public readonly bool ICKBFDJMHAM;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x3D61590", Offset = "0x3D60790", VA = "0x183D61590")]
	public HNONFECGPHM(TData CGKANMHMCOJ, bool ICKBFDJMHAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public interface OKFGGPCBPEN<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MHMACPKANBJ([In] FBADICAECGB<TData> IABHDFPNPKD);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MHMACPKANBJ([In] HJJJEFNIKGD<TData> IABHDFPNPKD);
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public interface LNMPDNNLMLC<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PMKBIBIDAOD([In] CNGPPFCNLCB<TData> ADDOEBNPGCB);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NCFDLBJAECD([In] JBKNEGKPONE BLOGBAAPLIH);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NLMPBMFAOCI();
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class NKBLJGNBOMP<TData> : MPLCCFJEIBC<OKFGGPCBPEN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly FBADICAECGB<TData> IABHDFPNPKD;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x4530130", Offset = "0x452F330", VA = "0x184530130")]
	public NKBLJGNBOMP(IEnumerable<TData> DAOAKLHKOJP, Vector3 HPNDGHBCIPB, bool ICKBFDJMHAM, OKFGGPCBPEN<TData> JGBHEKHPCJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x3C65BC0", Offset = "0x3C64DC0", VA = "0x183C65BC0", Slot = "4")]
	public override bool MHMACPKANBJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class JLEJBLHEMNM<TData> : MPLCCFJEIBC<LNMPDNNLMLC<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x3B77FE0", Offset = "0x3B771E0", VA = "0x183B77FE0")]
	public JLEJBLHEMNM(LNMPDNNLMLC<TData> JGBHEKHPCJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x40BA5A0", Offset = "0x40B97A0", VA = "0x1840BA5A0", Slot = "4")]
	public override bool MHMACPKANBJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class ANEAAHILAGP<TData> : MPLCCFJEIBC<LNMPDNNLMLC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly CNGPPFCNLCB<TData> IABHDFPNPKD;

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x3C9AD40", Offset = "0x3C99F40", VA = "0x183C9AD40")]
	public ANEAAHILAGP(IEnumerable<TData> DAOAKLHKOJP, bool ICKBFDJMHAM, LNMPDNNLMLC<TData> JGBHEKHPCJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x3C65BC0", Offset = "0x3C64DC0", VA = "0x183C65BC0", Slot = "4")]
	public override bool MHMACPKANBJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class AKOIBIEJEOO<TData> : MPLCCFJEIBC<OKFGGPCBPEN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly HJJJEFNIKGD<TData> IABHDFPNPKD;

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x3C989E0", Offset = "0x3C97BE0", VA = "0x183C989E0")]
	public AKOIBIEJEOO(IEnumerable<TData> DAOAKLHKOJP, Vector3 IIGHHCBJGJE, LJKJBNGKKNA BGPCMFEDLKF, bool ICKBFDJMHAM, OKFGGPCBPEN<TData> JGBHEKHPCJH, Space EKLPOPINKNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3C98920", Offset = "0x3C97B20", VA = "0x183C98920", Slot = "4")]
	public override bool MHMACPKANBJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class OMECHJJDNIA<TData> : MPLCCFJEIBC<LNMPDNNLMLC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly JBKNEGKPONE IABHDFPNPKD;

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x46B2F30", Offset = "0x46B2130", VA = "0x1846B2F30")]
	public OMECHJJDNIA(Vector3 HPNDGHBCIPB, LNMPDNNLMLC<TData> JGBHEKHPCJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x4245840", Offset = "0x4244A40", VA = "0x184245840", Slot = "4")]
	public override bool MHMACPKANBJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct FBADICAECGB<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public readonly IEnumerable<TData> DAOAKLHKOJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public readonly Vector3 HPNDGHBCIPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public readonly bool ICKBFDJMHAM;

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x3B7DB00", Offset = "0x3B7CD00", VA = "0x183B7DB00")]
	public FBADICAECGB(IEnumerable<TData> DAOAKLHKOJP, Vector3 HPNDGHBCIPB, bool ICKBFDJMHAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct CNGPPFCNLCB<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public readonly IEnumerable<TData> DAOAKLHKOJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public readonly bool ICKBFDJMHAM;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x51FD920", Offset = "0x51FCB20", VA = "0x1851FD920")]
	public CNGPPFCNLCB(IEnumerable<TData> DAOAKLHKOJP, bool ICKBFDJMHAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct HJJJEFNIKGD<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public readonly IEnumerable<TData> DAOAKLHKOJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public readonly Vector3 IIGHHCBJGJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly LJKJBNGKKNA BGPCMFEDLKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public readonly bool ICKBFDJMHAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly Space EKLPOPINKNL;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x3D37030", Offset = "0x3D36230", VA = "0x183D37030")]
	public HJJJEFNIKGD(IEnumerable<TData> DAOAKLHKOJP, Vector3 IIGHHCBJGJE, LJKJBNGKKNA BGPCMFEDLKF, bool ICKBFDJMHAM, Space EKLPOPINKNL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct JBKNEGKPONE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public readonly Vector3 HPNDGHBCIPB;

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x217A0B0", Offset = "0x21792B0", VA = "0x18217A0B0")]
	public JBKNEGKPONE(Vector3 HPNDGHBCIPB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public enum LJKJBNGKKNA
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
[Cpp2IlInjected.Token(Token = "0x2000073")]
public interface OJIEGIKADAJ
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MHMACPKANBJ([In] KJAEBOJOAHA ENGOGJAJEEF);
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public class AJIMHJKGBKF : MPLCCFJEIBC<OJIEGIKADAJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly KJAEBOJOAHA ENGOGJAJEEF;

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6933130", Offset = "0x6932330", VA = "0x186933130")]
	public AJIMHJKGBKF(bool ICKBFDJMHAM, OJIEGIKADAJ JGBHEKHPCJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6933080", Offset = "0x6932280", VA = "0x186933080", Slot = "4")]
	public override bool MHMACPKANBJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public readonly struct KJAEBOJOAHA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public readonly bool ICKBFDJMHAM;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x217A0A0", Offset = "0x21792A0", VA = "0x18217A0A0")]
	public KJAEBOJOAHA(bool ICKBFDJMHAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public interface JINDGPHJCMK<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MHMACPKANBJ([In] LOBEJMDNCPJ<TData> GJIAHCCFDHD);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MHMACPKANBJ([In] EMGMJFOIIGF<TData> GJIAHCCFDHD);
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public interface DGDJFONIFEB<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PMKBIBIDAOD([In] AEOHKHDPBDC<TData> EGPNMAEBJKB);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NCFDLBJAECD([In] NFODCBINHPC BLOGBAAPLIH);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NLMPBMFAOCI();
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class BPBHOEIMPLG<TData> : MPLCCFJEIBC<JINDGPHJCMK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly LOBEJMDNCPJ<TData> GJIAHCCFDHD;

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x4E8CD80", Offset = "0x4E8BF80", VA = "0x184E8CD80")]
	public BPBHOEIMPLG(IEnumerable<TData> DAOAKLHKOJP, Quaternion HPNDGHBCIPB, Vector3? CKBFLHILBLD, bool CMDFLPOHHHA, bool ICKBFDJMHAM, JINDGPHJCMK<TData> JGBHEKHPCJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x3C65BC0", Offset = "0x3C64DC0", VA = "0x183C65BC0", Slot = "4")]
	public override bool MHMACPKANBJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class LBHNDMOHPOM<TData> : MPLCCFJEIBC<DGDJFONIFEB<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x3B77FE0", Offset = "0x3B771E0", VA = "0x183B77FE0")]
	public LBHNDMOHPOM(DGDJFONIFEB<TData> JGBHEKHPCJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x40BA5A0", Offset = "0x40B97A0", VA = "0x1840BA5A0", Slot = "4")]
	public override bool MHMACPKANBJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class HDIFOFKKOEC<TData> : MPLCCFJEIBC<DGDJFONIFEB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly AEOHKHDPBDC<TData> GJIAHCCFDHD;

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x3D19C20", Offset = "0x3D18E20", VA = "0x183D19C20")]
	public HDIFOFKKOEC(IEnumerable<TData> DAOAKLHKOJP, bool ICKBFDJMHAM, DGDJFONIFEB<TData> JGBHEKHPCJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x3C65BC0", Offset = "0x3C64DC0", VA = "0x183C65BC0", Slot = "4")]
	public override bool MHMACPKANBJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class DGEGCFADHJJ<TData> : MPLCCFJEIBC<JINDGPHJCMK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly EMGMJFOIIGF<TData> GJIAHCCFDHD;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x5764CB0", Offset = "0x5763EB0", VA = "0x185764CB0")]
	public DGEGCFADHJJ(IEnumerable<TData> DAOAKLHKOJP, Quaternion ONNKAJNPEEG, LJKJBNGKKNA KJMAMGCLNDL, Vector3? CKBFLHILBLD, bool CMDFLPOHHHA, bool ICKBFDJMHAM, Space EKLPOPINKNL, JINDGPHJCMK<TData> JGBHEKHPCJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x3C98920", Offset = "0x3C97B20", VA = "0x183C98920", Slot = "4")]
	public override bool MHMACPKANBJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class DJJHBOCLKHO<TData> : MPLCCFJEIBC<DGDJFONIFEB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly NFODCBINHPC GJIAHCCFDHD;

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x5784700", Offset = "0x5783900", VA = "0x185784700")]
	public DJJHBOCLKHO(Quaternion HPNDGHBCIPB, Vector3? CKBFLHILBLD, bool CMDFLPOHHHA, DGDJFONIFEB<TData> JGBHEKHPCJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x4245840", Offset = "0x4244A40", VA = "0x184245840", Slot = "4")]
	public override bool MHMACPKANBJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public struct LOBEJMDNCPJ<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public readonly IEnumerable<TData> DAOAKLHKOJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public readonly Quaternion HPNDGHBCIPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public readonly Vector3? CKBFLHILBLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public readonly bool CMDFLPOHHHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public readonly bool ICKBFDJMHAM;

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x42AA6E0", Offset = "0x42A98E0", VA = "0x1842AA6E0")]
	public LOBEJMDNCPJ(IEnumerable<TData> DAOAKLHKOJP, Quaternion HPNDGHBCIPB, Vector3? CKBFLHILBLD, bool CMDFLPOHHHA, bool ICKBFDJMHAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public struct AEOHKHDPBDC<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public readonly IEnumerable<TData> DAOAKLHKOJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly bool ICKBFDJMHAM;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x3C684B0", Offset = "0x3C676B0", VA = "0x183C684B0")]
	public AEOHKHDPBDC(IEnumerable<TData> DAOAKLHKOJP, bool ICKBFDJMHAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public struct EMGMJFOIIGF<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public readonly IEnumerable<TData> DAOAKLHKOJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public readonly Quaternion ONNKAJNPEEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public readonly LJKJBNGKKNA KJMAMGCLNDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public readonly Vector3? CKBFLHILBLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public readonly bool CMDFLPOHHHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public readonly bool ICKBFDJMHAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public readonly Space EKLPOPINKNL;

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x38147E0", Offset = "0x38139E0", VA = "0x1838147E0")]
	public EMGMJFOIIGF(IEnumerable<TData> DAOAKLHKOJP, Quaternion ONNKAJNPEEG, LJKJBNGKKNA KJMAMGCLNDL, Vector3? CKBFLHILBLD, bool CMDFLPOHHHA, bool ICKBFDJMHAM, Space EKLPOPINKNL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public struct NFODCBINHPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public readonly Quaternion HPNDGHBCIPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public readonly Vector3? CKBFLHILBLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public readonly bool CMDFLPOHHHA;

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x4C99F00", Offset = "0x4C99100", VA = "0x184C99F00")]
	public NFODCBINHPC(Quaternion HPNDGHBCIPB, Vector3? CKBFLHILBLD, bool CMDFLPOHHHA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public interface JHGKJNIPPIP<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PMKBIBIDAOD([In] PCPLBAKNJCA<TData> EGPNMAEBJKB);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NCFDLBJAECD([In] EHFCHOJDIKE BLOGBAAPLIH);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NCFDLBJAECD([In] BBADLHONFOP BLOGBAAPLIH);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool NCFDLBJAECD([In] MFJBNOCMEKA BLOGBAAPLIH);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool NLMPBMFAOCI();
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public class LGAAGDCHFFE<TData> : MPLCCFJEIBC<JHGKJNIPPIP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly MFJBNOCMEKA PNAGPMNBPDC;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x424B160", Offset = "0x424A360", VA = "0x18424B160")]
	public LGAAGDCHFFE(Vector3 KNMCPENGJAE, float BONLJCBABLI, Vector3 CKBFLHILBLD, bool OLNBDIMJBDB, bool DPGDEJJAHGF, JHGKJNIPPIP<TData> JGBHEKHPCJH, Space EKLPOPINKNL = Space.Self)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x424B100", Offset = "0x424A300", VA = "0x18424B100", Slot = "4")]
	public override bool MHMACPKANBJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public class ILGEPFEIBGM<TData> : MPLCCFJEIBC<JHGKJNIPPIP<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x3B77FE0", Offset = "0x3B771E0", VA = "0x183B77FE0")]
	public ILGEPFEIBGM(JHGKJNIPPIP<TData> JGBHEKHPCJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x3EDBA30", Offset = "0x3EDAC30", VA = "0x183EDBA30", Slot = "4")]
	public override bool MHMACPKANBJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class JAGMOEJOJHB<TData> : MPLCCFJEIBC<JHGKJNIPPIP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly PCPLBAKNJCA<TData> PNAGPMNBPDC;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x4099540", Offset = "0x4098740", VA = "0x184099540")]
	public JAGMOEJOJHB(IEnumerable<TData> DAOAKLHKOJP, bool ICKBFDJMHAM, JHGKJNIPPIP<TData> JGBHEKHPCJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x3C65BC0", Offset = "0x3C64DC0", VA = "0x183C65BC0", Slot = "4")]
	public override bool MHMACPKANBJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class AHMHKOELIMF<TData> : MPLCCFJEIBC<JHGKJNIPPIP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly BBADLHONFOP PNAGPMNBPDC;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x3C81300", Offset = "0x3C80500", VA = "0x183C81300")]
	public AHMHKOELIMF(float ACDBAGBHIDO, bool KJCKFEPGCFK, Vector3 CKBFLHILBLD, JHGKJNIPPIP<TData> JGBHEKHPCJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x3C81240", Offset = "0x3C80440", VA = "0x183C81240", Slot = "4")]
	public override bool MHMACPKANBJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class LEKGFPNBOGA<TData> : MPLCCFJEIBC<JHGKJNIPPIP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly EHFCHOJDIKE PNAGPMNBPDC;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x42458A0", Offset = "0x4244AA0", VA = "0x1842458A0")]
	public LEKGFPNBOGA(float BONLJCBABLI, Vector3 CKBFLHILBLD, JHGKJNIPPIP<TData> JGBHEKHPCJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x4245840", Offset = "0x4244A40", VA = "0x184245840", Slot = "4")]
	public override bool MHMACPKANBJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public struct MFJBNOCMEKA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public readonly Vector3 KNMCPENGJAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public readonly float BONLJCBABLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public readonly Vector3 CKBFLHILBLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public readonly bool BOINHNBBNNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public readonly Space EKLPOPINKNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public readonly bool DPGDEJJAHGF;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x6934000", Offset = "0x6933200", VA = "0x186934000")]
	public MFJBNOCMEKA(Vector3 KNMCPENGJAE, float BONLJCBABLI, Vector3 CKBFLHILBLD, bool BOINHNBBNNI, bool NGCADJBJMCK, Space EKLPOPINKNL = Space.Self)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public struct PCPLBAKNJCA<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public readonly IEnumerable<TData> DAOAKLHKOJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public readonly bool ICKBFDJMHAM;

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x4768A10", Offset = "0x4767C10", VA = "0x184768A10")]
	public PCPLBAKNJCA(IEnumerable<TData> DAOAKLHKOJP, bool ICKBFDJMHAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct BBADLHONFOP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public readonly float ACDBAGBHIDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public readonly bool KJCKFEPGCFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public readonly Vector3 CKBFLHILBLD;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x6933190", Offset = "0x6932390", VA = "0x186933190")]
	public BBADLHONFOP(float ACDBAGBHIDO, bool KJCKFEPGCFK, Vector3 CKBFLHILBLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public struct EHFCHOJDIKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public readonly float BONLJCBABLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public readonly Vector3 CKBFLHILBLD;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x4C712C0", Offset = "0x4C704C0", VA = "0x184C712C0")]
	public EHFCHOJDIKE(float BONLJCBABLI, Vector3 CKBFLHILBLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct ECNJOJAKMKA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public readonly Guid[] DAOAKLHKOJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public readonly bool ODGCIIINHNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public readonly bool GEIHOEKOBHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public readonly bool JPPPDIAHJCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public readonly Vector3[] AKBGHODCILL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public readonly Quaternion[] HJGHGHMJHDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly float[] LLHAAJHEAOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public readonly Dictionary<Guid, Vector3> HFEEIDEHBGE;

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x69338A0", Offset = "0x6932AA0", VA = "0x1869338A0")]
	public ECNJOJAKMKA(Guid[] GKPDKIBFIPB, Vector3[] AKBGHODCILL, Quaternion[] HJGHGHMJHDC, float[] LLHAAJHEAOL, Dictionary<Guid, Vector3> HFEEIDEHBGE, bool ODGCIIINHNI = true, bool GEIHOEKOBHB = true, bool JPPPDIAHJCG = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x69336D0", Offset = "0x69328D0", VA = "0x1869336D0")]
	private static void OJNEHOPJEJO(Dictionary<Guid, Vector3> HFEEIDEHBGE, int KKIHNJLFOLK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public static class DJMAHCMPHAH
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	private struct GIGEODNGHCE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public bool JNCLDJEAFJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public INCIOHANCNE HDLDKNAIPCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public INCIOHANCNE PEBFNECJDNO;
	}

	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private static GIGEODNGHCE GFPFEGKKJAF;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static CancellationToken JDBBABFONDC
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x6933300", Offset = "0x6932500", VA = "0x186933300")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	internal static INCIOHANCNE HDLDKNAIPCE
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x69334E0", Offset = "0x69326E0", VA = "0x1869334E0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6933320", Offset = "0x6932520", VA = "0x186933320")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x69333E0", Offset = "0x69325E0", VA = "0x1869333E0")]
	[GDGALFJPCGE(JAFPILLCEJB.Room, JMIPDAHBNNG.None)]
	private static void JNAGAGBOGMF(INCIOHANCNE CMLAJLGBHCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6933580", Offset = "0x6932780", VA = "0x186933580")]
	public static void MJPMKPPBJPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6933390", Offset = "0x6932590", VA = "0x186933390")]
	private static INCIOHANCNE EAHKIMMMHCG(INCIOHANCNE OOEKFBLDDAA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public static class IJPCGIDEOPG
{
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public enum OFAGMNOACLA
	{
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		ICreationContextObject,
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		Guid
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x2BB7A60", Offset = "0x2BB6C60", VA = "0x182BB7A60")]
	public static void EFIIGCKICPL<T>(T BOLGDNNEFAC, OFAGMNOACLA NCMHJNKFAGH) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x2BB7BC0", Offset = "0x2BB6DC0", VA = "0x182BB7BC0")]
	public static void EFIIGCKICPL<T>(T BOLGDNNEFAC) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x2BB78A0", Offset = "0x2BB6AA0", VA = "0x182BB78A0")]
	public static void BGPABAEABKP<T>(T BOLGDNNEFAC) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x2BB7E30", Offset = "0x2BB7030", VA = "0x182BB7E30")]
	public static T JMJOGDIBBHK<T>(OFAGMNOACLA NCMHJNKFAGH) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x2BB7CE0", Offset = "0x2BB6EE0", VA = "0x182BB7CE0")]
	public static bool FFKNBABIJFJ<T>(OFAGMNOACLA NCMHJNKFAGH, T? FCOADHDJBOF, [Out][NotNullWhen(true)][MaybeNullWhen(false)] T ICGMOBLFFME) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x2BB79B0", Offset = "0x2BB6BB0", VA = "0x182BB79B0")]
	public static bool CPABBPGCOEO<T>(OFAGMNOACLA NCMHJNKFAGH) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x2BB7950", Offset = "0x2BB6B50", VA = "0x182BB7950")]
	public static T JMJOGDIBBHK<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x2BB7C30", Offset = "0x2BB6E30", VA = "0x182BB7C30")]
	public static bool FFKNBABIJFJ<T>(T FCOADHDJBOF, [Out] T ICGMOBLFFME) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x2BB7950", Offset = "0x2BB6B50", VA = "0x182BB7950")]
	public static bool CPABBPGCOEO<T>() where T : class
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
internal static class OONFKPKOHFP
{
	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x69340E0", Offset = "0x69332E0", VA = "0x1869340E0")]
	public static void AHCIJHMLPDJ(IEnumerable HKKJHHAHAPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x2CCD130", Offset = "0x2CCC330", VA = "0x182CCD130")]
	public static void AHCIJHMLPDJ<T>(T[] PFKJAOOHGBN) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x2CCD220", Offset = "0x2CCC420", VA = "0x182CCD220")]
	public static void AHCIJHMLPDJ<T>(T NKEPPGPEFAC) where T : notnull, Enum
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
