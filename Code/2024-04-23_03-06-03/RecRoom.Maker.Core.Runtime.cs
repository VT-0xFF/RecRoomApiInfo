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
		[Cpp2IlInjected.Address(RVA = "0x7EACF0", Offset = "0x7E9CF0", VA = "0x1807EACF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x62EF1E0", Offset = "0x62EE1E0", VA = "0x1862EF1E0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7EB340", Offset = "0x7EA340", VA = "0x1807EB340")]
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
		[Cpp2IlInjected.Address(RVA = "0x7EB380", Offset = "0x7EA380", VA = "0x1807EB380")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface MMICOKGNAFJ<TData, TReturn>
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TReturn IHENCJOEBLE(TData KDEEPMDJGFD);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface POIKBMJPLBC<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ClearHoverTarget(COCPKEFGEBC MPEALPEKKLN);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool SetHoverTarget(TData AOHFGFEGDPB, Collider GFBONKEMLBC, COCPKEFGEBC MPEALPEKKLN, [Optional] MKFOLIFJABD? DDOOHMNPBBA);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool TryGetHoverTarget([Out] TData AOHFGFEGDPB);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetHoverCollider([Out] Collider GFBONKEMLBC);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface PGPDKGBAGCH<TData> : POABBONBEIB, KHDPJNACKFL<TData>, ADPDBIBGICI<TData>, HMJPAFEMFDL<TData>, ECPLKLCHCDD, GHHAMLOFBAP<TData>, LMEKLCBPLCN, PHFIJDCMANK
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface GHHAMLOFBAP<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 OHFPFGNFPGI, Vector3 PFFNCAKFCDH, float MPDLEMGFFNF, [Out] T NKAMGECDHPB, [Out] Vector3 AEBIFJBFHGO, [Out] Collider GFBONKEMLBC);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 OHFPFGNFPGI, Vector3 PFFNCAKFCDH, float PGJIDOGFBLI, float MPDLEMGFFNF, T[] LFEJNNBNDDG, [Out] Vector3 BDGMONEAJCA, [Out] Collider EECEGLHGPLG);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 OHFPFGNFPGI, float PGJIDOGFBLI, Vector3 OKPGONDEPEG, T[] LFEJNNBNDDG);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetObjectFromColliderInCurrentScope(Collider MDIOCJFNBPC, [Out] T LGKLGFNHIAH);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface POABBONBEIB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Bounds HKHBGJMHGFE
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Transform AAEJKBKIILB
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Bounds CLDBCCBFKKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Transform IPEDHMFHNKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Vector3 BNLBDFJBFAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool BHBAGGMMCJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void SetSelectionBoundsDirty(bool MEEGBJHKOBI = true, int LJEDPMEMCJE = 0);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ShouldHideSelectionBoundsPreview(bool HLDIIPKIGIO, object KONODCHOCOG);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface PHFIJDCMANK
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	ONDMBBPPJJI CNMIAMNIBME
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface KCMKIGNBENF
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool FPHKJKPPPEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool DACNDGKLAHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool GDKKFLNMPLK
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
	void TrySetPreviousCloneMapping(Dictionary<Guid, Guid> DODLIPFLCJE);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface HMJPAFEMFDL<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool IEJEKACLCMO
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int LOPNNEONEBA
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<TData> KKBKMHFAFJA
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData LLMAIFIKIOC);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData LLMAIFIKIOC);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface KHDPJNACKFL<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T KDEEPMDJGFD, [Optional] MKFOLIFJABD? AHFIKOMACCN, bool IGJLHFIMGJI = true);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int MJMIIGGLEFB, IEnumerable<T> HHJEEBMPICI, bool IGJLHFIMGJI = true);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int MJMIIGGLEFB, IEnumerable<T> HHJEEBMPICI, MKFOLIFJABD AHFIKOMACCN, bool IGJLHFIMGJI = true);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface LMEKLCBPLCN
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface ECPLKLCHCDD
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool CBJCEOEGMLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool DBJELDMMCEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool MOPGMNGOPCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool OANJCNGMHKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class AMMFPDJEDIB<TReceiver> : NEOMOPMBGCB<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x350BAA0", Offset = "0x350AAA0", VA = "0x18350BAA0")]
	public AMMFPDJEDIB(TReceiver DKHAKCOFILG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class HFHBBADNFCM<TReceiver, TFromTask> : NEOMOPMBGCB<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x350BAA0", Offset = "0x350AAA0", VA = "0x18350BAA0")]
	public HFHBBADNFCM(TReceiver DKHAKCOFILG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public abstract class NEOMOPMBGCB<TReceiver, TFromExecute> where TReceiver : notnull where TFromExecute : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	protected TReceiver DKHAKCOFILG;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x40B8CF0", Offset = "0x40B7CF0", VA = "0x1840B8CF0")]
	public NEOMOPMBGCB(TReceiver DKHAKCOFILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute EEKCMCCINIG();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public abstract class HKGOKGIDENA<TReceiver, TResult> : NEOMOPMBGCB<TReceiver, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x350BAA0", Offset = "0x350AAA0", VA = "0x18350BAA0")]
	public HKGOKGIDENA(TReceiver DKHAKCOFILG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct GIADIKEOMKP<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public TGroup APOJLEALMJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public TData MJHFFGLCJAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public IEnumerable<TData> OPNHOFHKANP;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1B5AC20", Offset = "0x1B59C20", VA = "0x181B5AC20")]
	public GIADIKEOMKP(TGroup EFJLOMOOPGF, TData FLIDKKLFOBP, IEnumerable<TData> GMJHBPMJMAN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct BDLCENHKKAL<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public TGroup APOJLEALMJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public IEnumerable<TData> OPNHOFHKANP;

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x948150", Offset = "0x947150", VA = "0x180948150")]
	public BDLCENHKKAL(TGroup EFJLOMOOPGF, IEnumerable<TData> GMJHBPMJMAN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct BPMGGECKCEM<TGroup> where TGroup : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public TGroup APOJLEALMJE;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x94ABA0", Offset = "0x949BA0", VA = "0x18094ABA0")]
	public BPMGGECKCEM(TGroup EFJLOMOOPGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct PILHIOCEPNL<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public IEnumerable<TData> OPNHOFHKANP;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x94ABA0", Offset = "0x949BA0", VA = "0x18094ABA0")]
	public PILHIOCEPNL(IEnumerable<TData> GMJHBPMJMAN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface NKNNCCMNCPA<TGroup, TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IBNHNBGBCNP EPMKOELKJHI(GIADIKEOMKP<TGroup, TData> IJNIJGJEBLE);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IBNHNBGBCNP DMLKDOHHHKI(GIADIKEOMKP<TGroup, TData> IJNIJGJEBLE);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IBNHNBGBCNP DJICJPOGFNC(BDLCENHKKAL<TGroup, TData> IJNIJGJEBLE);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IBNHNBGBCNP EHHKMFICLMF(BPMGGECKCEM<TGroup> IJNIJGJEBLE);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface AKKPOHCHPBC<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IBNHNBGBCNP> EPMKOELKJHI(PILHIOCEPNL<TData> IJNIJGJEBLE);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class NBMGMOOLCNJ<TGroup, TData> : HKGOKGIDENA<NKNNCCMNCPA<TGroup, TData>, IBNHNBGBCNP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly BDLCENHKKAL<TGroup, TData> IJNIJGJEBLE;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x40A7E90", Offset = "0x40A6E90", VA = "0x1840A7E90")]
	public NBMGMOOLCNJ(TGroup EFJLOMOOPGF, IEnumerable<TData> GMJHBPMJMAN, NKNNCCMNCPA<TGroup, TData> DKHAKCOFILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x40A7DC0", Offset = "0x40A6DC0", VA = "0x1840A7DC0", Slot = "4")]
	public override IBNHNBGBCNP EEKCMCCINIG()
	{
		return default(IBNHNBGBCNP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class LNOJLHEJFOI<TGroup, TData> : HKGOKGIDENA<NKNNCCMNCPA<TGroup, TData>, IBNHNBGBCNP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly GIADIKEOMKP<TGroup, TData> IJNIJGJEBLE;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3E55970", Offset = "0x3E54970", VA = "0x183E55970")]
	public LNOJLHEJFOI(TGroup EFJLOMOOPGF, TData LHGOCOIOAJP, IEnumerable<TData> GMJHBPMJMAN, NKNNCCMNCPA<TGroup, TData> DKHAKCOFILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3E55890", Offset = "0x3E54890", VA = "0x183E55890", Slot = "4")]
	public override IBNHNBGBCNP EEKCMCCINIG()
	{
		return default(IBNHNBGBCNP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class NHBCECIELKJ<TGroup, TData> : HKGOKGIDENA<NKNNCCMNCPA<TGroup, TData>, IBNHNBGBCNP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly BPMGGECKCEM<TGroup> IJNIJGJEBLE;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3CCE530", Offset = "0x3CCD530", VA = "0x183CCE530")]
	public NHBCECIELKJ(TGroup EFJLOMOOPGF, NKNNCCMNCPA<TGroup, TData> DKHAKCOFILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x40BADC0", Offset = "0x40B9DC0", VA = "0x1840BADC0", Slot = "4")]
	public override IBNHNBGBCNP EEKCMCCINIG()
	{
		return default(IBNHNBGBCNP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class OLFEJBMPLNF<TGroup, TData> : HKGOKGIDENA<NKNNCCMNCPA<TGroup, TData>, IBNHNBGBCNP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly GIADIKEOMKP<TGroup, TData> IJNIJGJEBLE;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3E55970", Offset = "0x3E54970", VA = "0x183E55970")]
	public OLFEJBMPLNF(TGroup EFJLOMOOPGF, TData FLIDKKLFOBP, IEnumerable<TData> GMJHBPMJMAN, NKNNCCMNCPA<TGroup, TData> DKHAKCOFILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x41E5800", Offset = "0x41E4800", VA = "0x1841E5800", Slot = "4")]
	public override IBNHNBGBCNP EEKCMCCINIG()
	{
		return default(IBNHNBGBCNP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class JGAEECMHOFJ<TData> : HFHBBADNFCM<AKKPOHCHPBC<TData>, IBNHNBGBCNP> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private struct MBFLNJHBMFB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AsyncTaskMethodBuilder<IBNHNBGBCNP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public JGAEECMHOFJ<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private TaskAwaiter<IBNHNBGBCNP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x40188D0", Offset = "0x40178D0", VA = "0x1840188D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x4018B70", Offset = "0x4017B70", VA = "0x184018B70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private PILHIOCEPNL<TData> IJNIJGJEBLE;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3CCE530", Offset = "0x3CCD530", VA = "0x183CCE530")]
	public JGAEECMHOFJ(IEnumerable<TData> JHPPFPPCKLO, AKKPOHCHPBC<TData> DKHAKCOFILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3CCE430", Offset = "0x3CCD430", VA = "0x183CCE430", Slot = "4")]
	[AsyncStateMachine(typeof(JGAEECMHOFJ<>.MBFLNJHBMFB))]
	public override Task<IBNHNBGBCNP> EEKCMCCINIG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct JNIKHFMIPGH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly IDAPKMJMMJG KFLCMPFIMBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly bool AKCOMFKGAGO;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x62EF0D0", Offset = "0x62EE0D0", VA = "0x1862EF0D0")]
	public JNIKHFMIPGH(IDAPKMJMMJG PCBAHEGEPJH, bool PNBDEMDBJNH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface DODNDACCMGJ<TSpawnType> where TSpawnType : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> EEKCMCCINIG(JNIKHFMIPGH NDBFFFAJCDC);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class BBDANGCOBLK<TSpawnType> : HFHBBADNFCM<DODNDACCMGJ<TSpawnType>, TSpawnType> where TSpawnType : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private struct AOJAMKPGMHF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public AsyncTaskMethodBuilder<TSpawnType> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public BBDANGCOBLK<TSpawnType> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskAwaiter<TSpawnType> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x3B784D0", Offset = "0x3B774D0", VA = "0x183B784D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x39431A0", Offset = "0x39421A0", VA = "0x1839431A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly JNIKHFMIPGH NDBFFFAJCDC;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x48DD110", Offset = "0x48DC110", VA = "0x1848DD110")]
	public BBDANGCOBLK(IDAPKMJMMJG PCBAHEGEPJH, bool PNBDEMDBJNH, DODNDACCMGJ<TSpawnType> DKHAKCOFILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x48DCF10", Offset = "0x48DBF10", VA = "0x1848DCF10", Slot = "4")]
	[AsyncStateMachine(typeof(BBDANGCOBLK<>.AOJAMKPGMHF))]
	public override Task<TSpawnType> EEKCMCCINIG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public readonly struct IDAPKMJMMJG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly bool NGOOPJDGGJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly Vector3 DDDAMLFHNGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly Vector3 IGEPLDPOGMF;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x62EE960", Offset = "0x62ED960", VA = "0x1862EE960")]
	public IDAPKMJMMJG(Transform LAGKCKHAEMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x62EE930", Offset = "0x62ED930", VA = "0x1862EE930")]
	public IDAPKMJMMJG(Vector3 KMBEHGBELJC, Vector3 BJIKBOECFPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x62EE870", Offset = "0x62ED870", VA = "0x1862EE870")]
	public static IDAPKMJMMJG HKOPKLJMPAD()
	{
		return default(IDAPKMJMMJG);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x62EE8A0", Offset = "0x62ED8A0", VA = "0x1862EE8A0")]
	private IDAPKMJMMJG(bool JGHEEFGNOOA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct LDCBOPKMIJA<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public TNode FADDIALJMAB;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3E1EA20", Offset = "0x3E1DA20", VA = "0x183E1EA20")]
	public LDCBOPKMIJA(TNode FADDIALJMAB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct NLEFHGBLDKM<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public TNode LJEMNIABJBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public EOCGKFMJJKA AAHFBMENKEK;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x40C0540", Offset = "0x40BF540", VA = "0x1840C0540")]
	public NLEFHGBLDKM(TNode LJEMNIABJBF, EOCGKFMJJKA AAHFBMENKEK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface DJJAEBGFFID<TNode>
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BGOMPMGGFDG([In] LDCBOPKMIJA<TNode> IIAJBFHCLGF);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HMLILPEBCIF([In] NLEFHGBLDKM<TNode> NNGECADGPIA);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FFENOIGJJCH();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class EGHBMEIHIFF<TNode> : AMMFPDJEDIB<DJJAEBGFFID<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x350BAA0", Offset = "0x350AAA0", VA = "0x18350BAA0")]
	public EGHBMEIHIFF(DJJAEBGFFID<TNode> DKHAKCOFILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x350B9E0", Offset = "0x350A9E0", VA = "0x18350B9E0", Slot = "4")]
	public override bool EEKCMCCINIG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class PJCCGBOLAAB<TNode> : AMMFPDJEDIB<DJJAEBGFFID<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly NLEFHGBLDKM<TNode> NNGECADGPIA;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x4294C10", Offset = "0x4293C10", VA = "0x184294C10")]
	public PJCCGBOLAAB(TNode LJEMNIABJBF, EOCGKFMJJKA AAHFBMENKEK, DJJAEBGFFID<TNode> DKHAKCOFILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x394B130", Offset = "0x394A130", VA = "0x18394B130", Slot = "4")]
	public override bool EEKCMCCINIG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class BLFDDHDCBIG<TNode> : AMMFPDJEDIB<DJJAEBGFFID<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly LDCBOPKMIJA<TNode> IIAJBFHCLGF;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x4905650", Offset = "0x4904650", VA = "0x184905650")]
	public BLFDDHDCBIG(TNode MCIJCAMPKHD, DJJAEBGFFID<TNode> DKHAKCOFILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x39A48F0", Offset = "0x39A38F0", VA = "0x1839A48F0", Slot = "4")]
	public override bool EEKCMCCINIG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct GGJKGNHMLIL<TSpawnInfo> where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public TSpawnInfo PICLDLJPBJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public Vector3 BJIKBOECFPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public Quaternion CKCOAEGKOKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public float GJBNAOHDFNK;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x39A01E0", Offset = "0x399F1E0", VA = "0x1839A01E0")]
	public GGJKGNHMLIL(TSpawnInfo PICLDLJPBJJ, Vector3 BJIKBOECFPB, Quaternion CKCOAEGKOKA, float GJBNAOHDFNK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface OELHOBGKDJA<TSpawnType, TSpawnInfo>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> JEBFNFBLMKE([In] GGJKGNHMLIL<TSpawnInfo> GBIGLIOBHCM, CancellationToken GHLJDIEPICD);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class MNMKCCODBIB<TSpawnType, TSpawnInfo> : HFHBBADNFCM<OELHOBGKDJA<TSpawnType, TSpawnInfo>, TSpawnType> where TSpawnType : notnull where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly GGJKGNHMLIL<TSpawnInfo> JMCMGAGCLNF;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x405A880", Offset = "0x4059880", VA = "0x18405A880")]
	public MNMKCCODBIB(TSpawnInfo DGMPLJAAIFO, Vector3 BJIKBOECFPB, Quaternion CKCOAEGKOKA, float GJBNAOHDFNK, OELHOBGKDJA<TSpawnType, TSpawnInfo> DKHAKCOFILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x405A6A0", Offset = "0x40596A0", VA = "0x18405A6A0", Slot = "4")]
	public override Task<TSpawnType> EEKCMCCINIG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct GPJOILONHAA<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly IEnumerable<TData> OPNHOFHKANP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly bool AKCOMFKGAGO;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x39D9D80", Offset = "0x39D8D80", VA = "0x1839D9D80")]
	public GPJOILONHAA(IEnumerable<TData> GMJHBPMJMAN, bool PNBDEMDBJNH = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface CLCFMKCIKCH<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IBNHNBGBCNP> NLOKBLLBALA([In] GPJOILONHAA<TData> BDMGGILPPBB, CancellationToken GHLJDIEPICD);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class BBMNNBDDCPG<TData> : HFHBBADNFCM<CLCFMKCIKCH<TData>, IBNHNBGBCNP> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly GPJOILONHAA<TData> DKHOFELJDHA;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x48DE790", Offset = "0x48DD790", VA = "0x1848DE790")]
	public BBMNNBDDCPG(IEnumerable<TData> GMJHBPMJMAN, bool PNBDEMDBJNH, CLCFMKCIKCH<TData> DKHAKCOFILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x405A6A0", Offset = "0x40596A0", VA = "0x18405A6A0", Slot = "4")]
	public override Task<IBNHNBGBCNP> EEKCMCCINIG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct KJLPOMPIOGB<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly T AOHFGFEGDPB;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x3899A10", Offset = "0x3898A10", VA = "0x183899A10")]
	public KJLPOMPIOGB(T FGBJAIDJLPI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface FMJJJGAELOL<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BGOMPMGGFDG([In] KJLPOMPIOGB<T> MJPNDIIBKAN);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HMLILPEBCIF();
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface GBDJNIMPIPI<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EEKCMCCINIG([In] LHOBPFFJIDO<T> FJNLMCDHGGA);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct LHOBPFFJIDO<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public readonly T AOHFGFEGDPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public readonly bool AKOFMPMBGKO;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x3E377A0", Offset = "0x3E367A0", VA = "0x183E377A0")]
	public LHOBPFFJIDO(T FGBJAIDJLPI, bool PDKFJMKIMIE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class PCJKCABCNFF<T> : AMMFPDJEDIB<FMJJJGAELOL<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x350BAA0", Offset = "0x350AAA0", VA = "0x18350BAA0")]
	public PCJKCABCNFF(FMJJJGAELOL<T> DKHAKCOFILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x4280DF0", Offset = "0x427FDF0", VA = "0x184280DF0", Slot = "4")]
	public override bool EEKCMCCINIG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class CCINHBMJEBP<T> : AMMFPDJEDIB<FMJJJGAELOL<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly KJLPOMPIOGB<T> MJPNDIIBKAN;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x4BDE8E0", Offset = "0x4BDD8E0", VA = "0x184BDE8E0")]
	public CCINHBMJEBP(T AOHFGFEGDPB, FMJJJGAELOL<T> DKHAKCOFILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x39A48F0", Offset = "0x39A38F0", VA = "0x1839A48F0", Slot = "4")]
	public override bool EEKCMCCINIG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class OELAJDLOMEM<T> : AMMFPDJEDIB<GBDJNIMPIPI<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly LHOBPFFJIDO<T> FJNLMCDHGGA;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x41A1030", Offset = "0x41A0030", VA = "0x1841A1030")]
	public OELAJDLOMEM(T AOHFGFEGDPB, bool PDKFJMKIMIE, GBDJNIMPIPI<T> DKHAKCOFILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x39A48F0", Offset = "0x39A38F0", VA = "0x1839A48F0", Slot = "4")]
	public override bool EEKCMCCINIG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct EDDNDBILKOJ<TData> where TData : notnull, JGJPEGDBOFC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public IEnumerable<TData> OPNHOFHKANP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public bool FDHBNGICIJG;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x34E3C10", Offset = "0x34E2C10", VA = "0x1834E3C10")]
	public EDDNDBILKOJ(IEnumerable<TData> OMJPCHMAIFH, bool EAENIFGPIFJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct GCEEIPMGOGB<TData> where TData : notnull, JGJPEGDBOFC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public List<TData> OPNHOFHKANP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public List<bool> ELDAAEFDNKH;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x39972C0", Offset = "0x39962C0", VA = "0x1839972C0")]
	public GCEEIPMGOGB(List<TData> OMJPCHMAIFH, List<bool> MPELPBAFBFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface JGJPEGDBOFC
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool JEKONFNAILE
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
public interface KKCJFGHOCON<TData> where TData : JGJPEGDBOFC
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EEKCMCCINIG([In] EDDNDBILKOJ<TData> ABEPKMKIGEI);

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EEKCMCCINIG([In] GCEEIPMGOGB<TData> ABEPKMKIGEI);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface PDFHBPGHMMA<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DNHHEBBGJOM(T AOHFGFEGDPB);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class DFABEJEKLIJ<TData> : AMMFPDJEDIB<KKCJFGHOCON<TData>> where TData : notnull, JGJPEGDBOFC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly EDDNDBILKOJ<TData> ABEPKMKIGEI;

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x51E8020", Offset = "0x51E7020", VA = "0x1851E8020")]
	public DFABEJEKLIJ(List<TData> GMJHBPMJMAN, bool FDHBNGICIJG, KKCJFGHOCON<TData> DKHAKCOFILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x39A48F0", Offset = "0x39A38F0", VA = "0x1839A48F0", Slot = "4")]
	public override bool EEKCMCCINIG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class CINACCBDAPD<TData> : AMMFPDJEDIB<KKCJFGHOCON<TData>> where TData : notnull, JGJPEGDBOFC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly GCEEIPMGOGB<TData> ABEPKMKIGEI;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x4CB00C0", Offset = "0x4CAF0C0", VA = "0x184CB00C0")]
	public CINACCBDAPD(List<TData> GMJHBPMJMAN, List<bool> ELDAAEFDNKH, KKCJFGHOCON<TData> DKHAKCOFILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x404B5D0", Offset = "0x404A5D0", VA = "0x18404B5D0", Slot = "4")]
	public override bool EEKCMCCINIG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface OIFECBBIPCB<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IBNHNBGBCNP> EEKCMCCINIG(HOAPOFOFEBB<TData> ANBCMBPENPM);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public class CDGCPCKKGGL<TData> : HFHBBADNFCM<OIFECBBIPCB<TData>, IBNHNBGBCNP> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct OCCAOCCJJDF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public AsyncTaskMethodBuilder<IBNHNBGBCNP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public CDGCPCKKGGL<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<IBNHNBGBCNP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x419C120", Offset = "0x419B120", VA = "0x18419C120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x419C410", Offset = "0x419B410", VA = "0x18419C410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly HOAPOFOFEBB<TData> NMJEFCIEOIF;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x4BE3940", Offset = "0x4BE2940", VA = "0x184BE3940")]
	public CDGCPCKKGGL(TData EMDGAOFCNGM, IReadOnlyList<TData> IJHOPGNIMLO, bool PNBDEMDBJNH, OIFECBBIPCB<TData> DKHAKCOFILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x4BE3840", Offset = "0x4BE2840", VA = "0x184BE3840", Slot = "4")]
	[AsyncStateMachine(typeof(CDGCPCKKGGL<>.OCCAOCCJJDF))]
	public override Task<IBNHNBGBCNP> EEKCMCCINIG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public struct HOAPOFOFEBB<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public TData LMPPBEMPOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public IReadOnlyList<TData> DNGMFOMKKEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public bool AKCOMFKGAGO;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x3A44600", Offset = "0x3A43600", VA = "0x183A44600")]
	public HOAPOFOFEBB(TData EMDGAOFCNGM, IReadOnlyList<TData> IJHOPGNIMLO, bool PNBDEMDBJNH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface FBNNPGMOCFN<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EEKCMCCINIG([In] FJJJELHCKOF<TData> GKNKELPPIPA);
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface OEPHLCBELBO<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EEKCMCCINIG([In] DLMCOIMJMFN<TData> GKNKELPPIPA);
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface HEDDEBFFNNE<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DEFOCPIAKPE([In] EHDGJMOEMCI<TData> GKNKELPPIPA);

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HMLILPEBCIF();
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class GIHAPLFEBNK<TData> : AMMFPDJEDIB<FBNNPGMOCFN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly FJJJELHCKOF<TData> GKNKELPPIPA;

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x39A49B0", Offset = "0x39A39B0", VA = "0x1839A49B0")]
	public GIHAPLFEBNK(IEnumerable<TData> GMJHBPMJMAN, BPMNKHLKDDH IODHIPGGADP, DEJBNHJMHIH JANOPPPMNPE, float LAPDMPAFKJD, bool PNBDEMDBJNH, FBNNPGMOCFN<TData> DKHAKCOFILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x39A48F0", Offset = "0x39A38F0", VA = "0x1839A48F0", Slot = "4")]
	public override bool EEKCMCCINIG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class LNBMKIADFAO<TData> : AMMFPDJEDIB<OEPHLCBELBO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly DLMCOIMJMFN<TData> GKNKELPPIPA;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x3E4BE20", Offset = "0x3E4AE20", VA = "0x183E4BE20")]
	public LNBMKIADFAO(TData[] GMJHBPMJMAN, BPMNKHLKDDH[] IODHIPGGADP, DEJBNHJMHIH[] JANOPPPMNPE, float[] LAPDMPAFKJD, OEPHLCBELBO<TData> DKHAKCOFILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x350F240", Offset = "0x350E240", VA = "0x18350F240", Slot = "4")]
	public override bool EEKCMCCINIG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class LLFNCLGKGDO<TData> : AMMFPDJEDIB<HEDDEBFFNNE<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x350BAA0", Offset = "0x350AAA0", VA = "0x18350BAA0")]
	public LLFNCLGKGDO(HEDDEBFFNNE<TData> DKHAKCOFILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x3E3DD20", Offset = "0x3E3CD20", VA = "0x183E3DD20", Slot = "4")]
	public override bool EEKCMCCINIG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class EHEAJBCLEHN<TData> : AMMFPDJEDIB<HEDDEBFFNNE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly EHDGJMOEMCI<TData> GKNKELPPIPA;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x350F300", Offset = "0x350E300", VA = "0x18350F300")]
	public EHEAJBCLEHN(IEnumerable<TData> GMJHBPMJMAN, BPMNKHLKDDH IODHIPGGADP, DEJBNHJMHIH JANOPPPMNPE, float LAPDMPAFKJD, HEDDEBFFNNE<TData> DKHAKCOFILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x350F240", Offset = "0x350E240", VA = "0x18350F240", Slot = "4")]
	public override bool EEKCMCCINIG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public struct FJJJELHCKOF<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public IEnumerable<TData> OPNHOFHKANP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public BPMNKHLKDDH FBIBJOLBPGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public DEJBNHJMHIH CEALGPHFCPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public float LAPDMPAFKJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public bool PNBDEMDBJNH;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x389A120", Offset = "0x3899120", VA = "0x18389A120")]
	public FJJJELHCKOF(IEnumerable<TData> GMJHBPMJMAN, BPMNKHLKDDH IODHIPGGADP, DEJBNHJMHIH JANOPPPMNPE, float LAPDMPAFKJD, bool PNBDEMDBJNH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct DLMCOIMJMFN<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public TData[] OPNHOFHKANP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public BPMNKHLKDDH[] FBIBJOLBPGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public DEJBNHJMHIH[] CEALGPHFCPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public float[] LAPDMPAFKJD;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x520FF70", Offset = "0x520EF70", VA = "0x18520FF70")]
	public DLMCOIMJMFN(TData[] GMJHBPMJMAN, BPMNKHLKDDH[] IODHIPGGADP, DEJBNHJMHIH[] JANOPPPMNPE, float[] LAPDMPAFKJD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public struct EHDGJMOEMCI<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public IEnumerable<TData> OPNHOFHKANP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public BPMNKHLKDDH FBIBJOLBPGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public DEJBNHJMHIH CEALGPHFCPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public float LAPDMPAFKJD;

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x350F130", Offset = "0x350E130", VA = "0x18350F130")]
	public EHDGJMOEMCI(IEnumerable<TData> GMJHBPMJMAN, BPMNKHLKDDH IODHIPGGADP, DEJBNHJMHIH JANOPPPMNPE, float LAPDMPAFKJD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public interface ADPDBIBGICI<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DJICJPOGFNC([In] GJCLCELNMPJ<TData> BDMGGILPPBB);

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EHHKMFICLMF([In] GJCLCELNMPJ<TData> BDMGGILPPBB);

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JGEMPOHCBGB([In] bool EEPEDPILLMJ);

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IMPFGDKDMLM([In] GJCLCELNMPJ<TData> BDMGGILPPBB);

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BMFLHKLIEMM();

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool LHKPMOFEBIF([In] TData DCCCEPMFEKP);
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class GKLKKPGFFGP<TData> : AMMFPDJEDIB<ADPDBIBGICI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly GJCLCELNMPJ<TData> BDMGGILPPBB;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x39BB920", Offset = "0x39BA920", VA = "0x1839BB920")]
	public GKLKKPGFFGP(List<TData> DCGPAEFOGCA, ADPDBIBGICI<TData> DKHAKCOFILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x39A48F0", Offset = "0x39A38F0", VA = "0x1839A48F0", Slot = "4")]
	public override bool EEKCMCCINIG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class PILIAMPLLMD<TData> : AMMFPDJEDIB<ADPDBIBGICI<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x350BAA0", Offset = "0x350AAA0", VA = "0x18350BAA0")]
	public PILIAMPLLMD(ADPDBIBGICI<TData> DKHAKCOFILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x4294A70", Offset = "0x4293A70", VA = "0x184294A70", Slot = "4")]
	public override bool EEKCMCCINIG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class OLMPHDMINPC<TData> : AMMFPDJEDIB<ADPDBIBGICI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly bool PNBDEMDBJNH;

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x41EA540", Offset = "0x41E9540", VA = "0x1841EA540")]
	public OLMPHDMINPC(bool PNBDEMDBJNH, ADPDBIBGICI<TData> DKHAKCOFILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x41EA4E0", Offset = "0x41E94E0", VA = "0x1841EA4E0", Slot = "4")]
	public override bool EEKCMCCINIG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class MLEBMHCDMPG<TData> : AMMFPDJEDIB<ADPDBIBGICI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly GJCLCELNMPJ<TData> BDMGGILPPBB;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x404B690", Offset = "0x404A690", VA = "0x18404B690")]
	public MLEBMHCDMPG(List<TData> DCGPAEFOGCA, bool PNBDEMDBJNH, ADPDBIBGICI<TData> DKHAKCOFILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x404B5D0", Offset = "0x404A5D0", VA = "0x18404B5D0", Slot = "4")]
	public override bool EEKCMCCINIG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class EDHOHAACKJJ<TData> : AMMFPDJEDIB<ADPDBIBGICI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly TData DCCCEPMFEKP;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x34E4330", Offset = "0x34E3330", VA = "0x1834E4330")]
	public EDHOHAACKJJ(TData DCCCEPMFEKP, ADPDBIBGICI<TData> DKHAKCOFILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x34E41B0", Offset = "0x34E31B0", VA = "0x1834E41B0", Slot = "4")]
	public override bool EEKCMCCINIG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class CPGGBKLPJBG<TData> : AMMFPDJEDIB<ADPDBIBGICI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly GJCLCELNMPJ<TData> BDMGGILPPBB;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x5045310", Offset = "0x5044310", VA = "0x185045310")]
	public CPGGBKLPJBG(IEnumerable<TData> DCGPAEFOGCA, ADPDBIBGICI<TData> DKHAKCOFILG, bool PNBDEMDBJNH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x5045240", Offset = "0x5044240", VA = "0x185045240", Slot = "4")]
	public override bool EEKCMCCINIG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public struct GJCLCELNMPJ<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public IEnumerable<TData> OPNHOFHKANP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public bool PNBDEMDBJNH;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x39A68D0", Offset = "0x39A58D0", VA = "0x1839A68D0")]
	public GJCLCELNMPJ(IEnumerable<TData> OMJPCHMAIFH, bool GDIAFPKMLEK = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public interface EMEFAGANPJB
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IBNHNBGBCNP> EEKCMCCINIG(EKLKHHCBJFB HDIOLEPGKKO);
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class ONCMNBNGBPL : HFHBBADNFCM<EMEFAGANPJB, IBNHNBGBCNP>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private struct IHOHNKMEHEL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public AsyncTaskMethodBuilder<IBNHNBGBCNP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public ONCMNBNGBPL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private TaskAwaiter<IBNHNBGBCNP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x62EE9D0", Offset = "0x62ED9D0", VA = "0x1862EE9D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x62EEC50", Offset = "0x62EDC50", VA = "0x1862EEC50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly EKLKHHCBJFB HFCIEIGAKCD;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x62EF690", Offset = "0x62EE690", VA = "0x1862EF690")]
	public ONCMNBNGBPL(bool PNBDEMDBJNH, EMEFAGANPJB DKHAKCOFILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x62EF5A0", Offset = "0x62EE5A0", VA = "0x1862EF5A0", Slot = "4")]
	[AsyncStateMachine(typeof(IHOHNKMEHEL))]
	public override Task<IBNHNBGBCNP> EEKCMCCINIG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct EKLKHHCBJFB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public bool AKCOMFKGAGO;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0xCBCF40", Offset = "0xCBBF40", VA = "0x180CBCF40")]
	public EKLKHHCBJFB(bool PNBDEMDBJNH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public readonly struct CLDEPPDCIGE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly bool GGAGFOFDPIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly bool MGNMDOMLMDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly bool GJBNAOHDFNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public readonly bool PNBDEMDBJNH;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x476F9A0", Offset = "0x476E9A0", VA = "0x18476F9A0")]
	public CLDEPPDCIGE(bool GGAGFOFDPIC, bool MGNMDOMLMDA, bool GJBNAOHDFNK, bool PNBDEMDBJNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x62EE090", Offset = "0x62ED090", VA = "0x1862EE090")]
	public CLDEPPDCIGE(bool MGNMDOMLMDA, bool PNBDEMDBJNH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface KMOKNMMCEDA
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EFKIFLBJMHA(CLDEPPDCIGE PBLHBJNMNLL);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IDFNKLOJCPK(CLDEPPDCIGE PBLHBJNMNLL);
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class FFKNJAJHMPN : AMMFPDJEDIB<KMOKNMMCEDA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly CLDEPPDCIGE PBLHBJNMNLL;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x62EE550", Offset = "0x62ED550", VA = "0x1862EE550")]
	public FFKNJAJHMPN(bool JKAOMNONHAG, bool MGNMDOMLMDA, bool GJBNAOHDFNK, bool PNBDEMDBJNH, KMOKNMMCEDA DKHAKCOFILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x62EE500", Offset = "0x62ED500", VA = "0x1862EE500", Slot = "4")]
	public override bool EEKCMCCINIG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class KGPNJODKGME : AMMFPDJEDIB<KMOKNMMCEDA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly CLDEPPDCIGE PBLHBJNMNLL;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x62EF140", Offset = "0x62EE140", VA = "0x1862EF140")]
	public KGPNJODKGME(bool MGNMDOMLMDA, bool PNBDEMDBJNH, KMOKNMMCEDA DKHAKCOFILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x62EF0F0", Offset = "0x62EE0F0", VA = "0x1862EF0F0", Slot = "4")]
	public override bool EEKCMCCINIG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public interface DNPMNMACCMB
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EEKCMCCINIG([In] EPDPHJOKKII ECEENNMBEPM);
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class GGMDMAFIKCG : AMMFPDJEDIB<DNPMNMACCMB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly EPDPHJOKKII ECEENNMBEPM;

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x62EE690", Offset = "0x62ED690", VA = "0x1862EE690")]
	public GGMDMAFIKCG(Guid[] JJDEOCFOELO, Vector3[] AJALEAGBOEA, Quaternion[] FLFOLFMPNGK, float[] DKAAMAJLPIL, Dictionary<Guid, Vector3> MBOGPHBPECI, DNPMNMACCMB DKHAKCOFILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x62EE5E0", Offset = "0x62ED5E0", VA = "0x1862EE5E0", Slot = "4")]
	public override bool EEKCMCCINIG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public interface CNFBIODICKK<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BGOMPMGGFDG([In] CCKKKBAOJIH<TData> IIAJBFHCLGF);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DEFOCPIAKPE([In] LOHEGIAKMMB GOLMNJHPDHL);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DEFOCPIAKPE([In] BDKHJNMIJNF GOLMNJHPDHL);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HMLILPEBCIF();
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class HIMILIHCPHN<TData> : AMMFPDJEDIB<CNFBIODICKK<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x350BAA0", Offset = "0x350AAA0", VA = "0x18350BAA0")]
	public HIMILIHCPHN(CNFBIODICKK<TData> DKHAKCOFILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3A10EB0", Offset = "0x3A0FEB0", VA = "0x183A10EB0", Slot = "4")]
	public override bool EEKCMCCINIG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class EOJBEMLNDKM<TData> : AMMFPDJEDIB<CNFBIODICKK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly LOHEGIAKMMB MMKEPMFJOLH;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3538380", Offset = "0x3537380", VA = "0x183538380")]
	public EOJBEMLNDKM(Vector3 KHCDBBPLMOB, bool HMPEJMJFDBD, CNFBIODICKK<TData> DKHAKCOFILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x3538320", Offset = "0x3537320", VA = "0x183538320", Slot = "4")]
	public override bool EEKCMCCINIG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class HNOGCPKKBIM<TData> : AMMFPDJEDIB<CNFBIODICKK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly BDKHJNMIJNF MMKEPMFJOLH;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x3A44420", Offset = "0x3A43420", VA = "0x183A44420")]
	public HNOGCPKKBIM(Guid LPPGPEDKCDC, int GPEHCABDGEJ, Vector3 BJIKBOECFPB, Quaternion CKCOAEGKOKA, float LIIEEBDEIFN, bool HMPEJMJFDBD, CNFBIODICKK<TData> DKHAKCOFILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x3A443C0", Offset = "0x3A433C0", VA = "0x183A443C0", Slot = "4")]
	public override bool EEKCMCCINIG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class NFIHPDDCBEN<TData> : AMMFPDJEDIB<CNFBIODICKK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly CCKKKBAOJIH<TData> MMKEPMFJOLH;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x40B8F00", Offset = "0x40B7F00", VA = "0x1840B8F00")]
	public NFIHPDDCBEN(TData AOHFGFEGDPB, bool PNBDEMDBJNH, CNFBIODICKK<TData> DKHAKCOFILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x39A48F0", Offset = "0x39A38F0", VA = "0x1839A48F0", Slot = "4")]
	public override bool EEKCMCCINIG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public struct LOHEGIAKMMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public readonly Vector3 KHCDBBPLMOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly bool HMPEJMJFDBD;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x62EF1C0", Offset = "0x62EE1C0", VA = "0x1862EF1C0")]
	public LOHEGIAKMMB(Vector3 KHCDBBPLMOB, bool HMPEJMJFDBD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public struct BDKHJNMIJNF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public readonly Guid LPPGPEDKCDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public readonly int GPEHCABDGEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public readonly Vector3 BJIKBOECFPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public readonly Quaternion CKCOAEGKOKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public readonly float LIIEEBDEIFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public readonly bool HMPEJMJFDBD;

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x62EE030", Offset = "0x62ED030", VA = "0x1862EE030")]
	public BDKHJNMIJNF(Guid LPPGPEDKCDC, int GPEHCABDGEJ, Vector3 BJIKBOECFPB, Quaternion CKCOAEGKOKA, float LIIEEBDEIFN, bool HMPEJMJFDBD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public struct CCKKKBAOJIH<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public readonly TData AOHFGFEGDPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public readonly bool PNBDEMDBJNH;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x4BDEA20", Offset = "0x4BDDA20", VA = "0x184BDEA20")]
	public CCKKKBAOJIH(TData AOHFGFEGDPB, bool PNBDEMDBJNH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public interface OODEFLLHDFK<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EEKCMCCINIG([In] HHHLCCKNKBC<TData> JNCMGFDKIMI);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EEKCMCCINIG([In] NJJFFAGIPND<TData> JNCMGFDKIMI);
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public interface LAPLHHDOFJO<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BGOMPMGGFDG([In] FNFEFFHDNDL<TData> CBPHAOJPJOJ);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DEFOCPIAKPE([In] ECIHEGBNHCI GOLMNJHPDHL);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HMLILPEBCIF();
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class OADBAHKAMGB<TData> : AMMFPDJEDIB<OODEFLLHDFK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly HHHLCCKNKBC<TData> JNCMGFDKIMI;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x4177040", Offset = "0x4176040", VA = "0x184177040")]
	public OADBAHKAMGB(IEnumerable<TData> GMJHBPMJMAN, Vector3 LHJJMMGEJOL, bool PNBDEMDBJNH, OODEFLLHDFK<TData> DKHAKCOFILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x39A48F0", Offset = "0x39A38F0", VA = "0x1839A48F0", Slot = "4")]
	public override bool EEKCMCCINIG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class KCKJICFIAGM<TData> : AMMFPDJEDIB<LAPLHHDOFJO<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x350BAA0", Offset = "0x350AAA0", VA = "0x18350BAA0")]
	public KCKJICFIAGM(LAPLHHDOFJO<TData> DKHAKCOFILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x3D5C070", Offset = "0x3D5B070", VA = "0x183D5C070", Slot = "4")]
	public override bool EEKCMCCINIG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class KHIJCLPEABK<TData> : AMMFPDJEDIB<LAPLHHDOFJO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly FNFEFFHDNDL<TData> JNCMGFDKIMI;

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x3D85E10", Offset = "0x3D84E10", VA = "0x183D85E10")]
	public KHIJCLPEABK(IEnumerable<TData> GMJHBPMJMAN, bool PNBDEMDBJNH, LAPLHHDOFJO<TData> DKHAKCOFILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x39A48F0", Offset = "0x39A38F0", VA = "0x1839A48F0", Slot = "4")]
	public override bool EEKCMCCINIG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class ADEDEMDKPHD<TData> : AMMFPDJEDIB<OODEFLLHDFK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly NJJFFAGIPND<TData> JNCMGFDKIMI;

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x394B200", Offset = "0x394A200", VA = "0x18394B200")]
	public ADEDEMDKPHD(IEnumerable<TData> GMJHBPMJMAN, Vector3 DFPEEEJCLOG, FOEKDIOCBHL GAEBMCGLNEF, bool PNBDEMDBJNH, OODEFLLHDFK<TData> DKHAKCOFILG, Space GIJIFHPHGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x394B130", Offset = "0x394A130", VA = "0x18394B130", Slot = "4")]
	public override bool EEKCMCCINIG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class AMABLAGHIEG<TData> : AMMFPDJEDIB<LAPLHHDOFJO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly ECIHEGBNHCI JNCMGFDKIMI;

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x3B684C0", Offset = "0x3B674C0", VA = "0x183B684C0")]
	public AMABLAGHIEG(Vector3 LHJJMMGEJOL, LAPLHHDOFJO<TData> DKHAKCOFILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x3538320", Offset = "0x3537320", VA = "0x183538320", Slot = "4")]
	public override bool EEKCMCCINIG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct HHHLCCKNKBC<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public readonly IEnumerable<TData> GMJHBPMJMAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public readonly Vector3 LHJJMMGEJOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public readonly bool PNBDEMDBJNH;

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x3A10D90", Offset = "0x3A0FD90", VA = "0x183A10D90")]
	public HHHLCCKNKBC(IEnumerable<TData> GMJHBPMJMAN, Vector3 LHJJMMGEJOL, bool PNBDEMDBJNH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct FNFEFFHDNDL<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public readonly IEnumerable<TData> GMJHBPMJMAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public readonly bool PNBDEMDBJNH;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x38A8D00", Offset = "0x38A7D00", VA = "0x1838A8D00")]
	public FNFEFFHDNDL(IEnumerable<TData> GMJHBPMJMAN, bool PNBDEMDBJNH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct NJJFFAGIPND<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public readonly IEnumerable<TData> GMJHBPMJMAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public readonly Vector3 DFPEEEJCLOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public readonly FOEKDIOCBHL GAEBMCGLNEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly bool PNBDEMDBJNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public readonly Space GIJIFHPHGCH;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x40BD660", Offset = "0x40BC660", VA = "0x1840BD660")]
	public NJJFFAGIPND(IEnumerable<TData> GMJHBPMJMAN, Vector3 DFPEEEJCLOG, FOEKDIOCBHL GAEBMCGLNEF, bool PNBDEMDBJNH, Space GIJIFHPHGCH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct ECIHEGBNHCI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly Vector3 LHJJMMGEJOL;

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x1FD4D00", Offset = "0x1FD3D00", VA = "0x181FD4D00")]
	public ECIHEGBNHCI(Vector3 LHJJMMGEJOL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public enum FOEKDIOCBHL
{
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	XYZ,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	X_only,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	Y_only,
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	Z_only
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public interface JFEHKHICDAP
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EEKCMCCINIG([In] NMHDKEFMHGE LBIELPLCIMI);
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public class OAHFACKHDIE : AMMFPDJEDIB<JFEHKHICDAP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly NMHDKEFMHGE LBIELPLCIMI;

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x62EF310", Offset = "0x62EE310", VA = "0x1862EF310")]
	public OAHFACKHDIE(bool PNBDEMDBJNH, JFEHKHICDAP DKHAKCOFILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x62EF260", Offset = "0x62EE260", VA = "0x1862EF260", Slot = "4")]
	public override bool EEKCMCCINIG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public readonly struct NMHDKEFMHGE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public readonly bool PNBDEMDBJNH;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0xCBCF40", Offset = "0xCBBF40", VA = "0x180CBCF40")]
	public NMHDKEFMHGE(bool PNBDEMDBJNH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public interface HLCMGFIILAP<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EEKCMCCINIG([In] EPHIOFDMHJK<TData> LKIAEIDEJOO);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EEKCMCCINIG([In] FCHGNEEHHOJ<TData> LKIAEIDEJOO);
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public interface HJHKGOHJKHG<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BGOMPMGGFDG([In] CHGLFHODAEN<TData> IIAJBFHCLGF);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DEFOCPIAKPE([In] CDOPEKOCLBA GOLMNJHPDHL);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HMLILPEBCIF();
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class HPGALNIBLJC<TData> : AMMFPDJEDIB<HLCMGFIILAP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly EPHIOFDMHJK<TData> LKIAEIDEJOO;

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x3A44FE0", Offset = "0x3A43FE0", VA = "0x183A44FE0")]
	public HPGALNIBLJC(IEnumerable<TData> GMJHBPMJMAN, Quaternion LHJJMMGEJOL, Vector3? FPCHMCKPKLJ, bool KJCOEEPODDG, bool PNBDEMDBJNH, HLCMGFIILAP<TData> DKHAKCOFILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x39A48F0", Offset = "0x39A38F0", VA = "0x1839A48F0", Slot = "4")]
	public override bool EEKCMCCINIG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class CBBCGLKHDCJ<TData> : AMMFPDJEDIB<HJHKGOHJKHG<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x350BAA0", Offset = "0x350AAA0", VA = "0x18350BAA0")]
	public CBBCGLKHDCJ(HJHKGOHJKHG<TData> DKHAKCOFILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x3D5C070", Offset = "0x3D5B070", VA = "0x183D5C070", Slot = "4")]
	public override bool EEKCMCCINIG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class PPGPEOHEPLK<TData> : AMMFPDJEDIB<HJHKGOHJKHG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly CHGLFHODAEN<TData> LKIAEIDEJOO;

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x429F560", Offset = "0x429E560", VA = "0x18429F560")]
	public PPGPEOHEPLK(IEnumerable<TData> GMJHBPMJMAN, bool PNBDEMDBJNH, HJHKGOHJKHG<TData> DKHAKCOFILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x39A48F0", Offset = "0x39A38F0", VA = "0x1839A48F0", Slot = "4")]
	public override bool EEKCMCCINIG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class HFEHFILKAIC<TData> : AMMFPDJEDIB<HLCMGFIILAP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly FCHGNEEHHOJ<TData> LKIAEIDEJOO;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x3A0BE10", Offset = "0x3A0AE10", VA = "0x183A0BE10")]
	public HFEHFILKAIC(IEnumerable<TData> GMJHBPMJMAN, Quaternion KHEFMFCHIAM, FOEKDIOCBHL CNGDCEELFJF, Vector3? FPCHMCKPKLJ, bool KJCOEEPODDG, bool PNBDEMDBJNH, Space GIJIFHPHGCH, HLCMGFIILAP<TData> DKHAKCOFILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x394B130", Offset = "0x394A130", VA = "0x18394B130", Slot = "4")]
	public override bool EEKCMCCINIG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class BOCDPADFDIH<TData> : AMMFPDJEDIB<HJHKGOHJKHG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly CDOPEKOCLBA LKIAEIDEJOO;

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x4924670", Offset = "0x4923670", VA = "0x184924670")]
	public BOCDPADFDIH(Quaternion LHJJMMGEJOL, Vector3? FPCHMCKPKLJ, bool KJCOEEPODDG, HJHKGOHJKHG<TData> DKHAKCOFILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x3538320", Offset = "0x3537320", VA = "0x183538320", Slot = "4")]
	public override bool EEKCMCCINIG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public struct EPHIOFDMHJK<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public readonly IEnumerable<TData> GMJHBPMJMAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public readonly Quaternion LHJJMMGEJOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public readonly Vector3? FPCHMCKPKLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public readonly bool KJCOEEPODDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public readonly bool PNBDEMDBJNH;

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x353B220", Offset = "0x353A220", VA = "0x18353B220")]
	public EPHIOFDMHJK(IEnumerable<TData> GMJHBPMJMAN, Quaternion LHJJMMGEJOL, Vector3? FPCHMCKPKLJ, bool KJCOEEPODDG, bool PNBDEMDBJNH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public struct CHGLFHODAEN<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public readonly IEnumerable<TData> GMJHBPMJMAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public readonly bool PNBDEMDBJNH;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x4CAA800", Offset = "0x4CA9800", VA = "0x184CAA800")]
	public CHGLFHODAEN(IEnumerable<TData> GMJHBPMJMAN, bool PNBDEMDBJNH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public struct FCHGNEEHHOJ<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly IEnumerable<TData> GMJHBPMJMAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public readonly Quaternion KHEFMFCHIAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public readonly FOEKDIOCBHL CNGDCEELFJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public readonly Vector3? FPCHMCKPKLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public readonly bool KJCOEEPODDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public readonly bool PNBDEMDBJNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public readonly Space GIJIFHPHGCH;

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x3884CA0", Offset = "0x3883CA0", VA = "0x183884CA0")]
	public FCHGNEEHHOJ(IEnumerable<TData> GMJHBPMJMAN, Quaternion KHEFMFCHIAM, FOEKDIOCBHL CNGDCEELFJF, Vector3? FPCHMCKPKLJ, bool KJCOEEPODDG, bool PNBDEMDBJNH, Space GIJIFHPHGCH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public struct CDOPEKOCLBA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public readonly Quaternion LHJJMMGEJOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public readonly Vector3? FPCHMCKPKLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public readonly bool KJCOEEPODDG;

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x473C170", Offset = "0x473B170", VA = "0x18473C170")]
	public CDOPEKOCLBA(Quaternion LHJJMMGEJOL, Vector3? FPCHMCKPKLJ, bool KJCOEEPODDG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public interface OLIHKJLKGOD<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BGOMPMGGFDG([In] ALDPLBAHAIK<TData> IIAJBFHCLGF);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DEFOCPIAKPE([In] MLBNOAEBLIM GOLMNJHPDHL);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DEFOCPIAKPE([In] BOFPPHLJFLE GOLMNJHPDHL);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DEFOCPIAKPE([In] JDPMLFHEGFL GOLMNJHPDHL);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool HMLILPEBCIF();
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public class HCKICPLBBFO<TData> : AMMFPDJEDIB<OLIHKJLKGOD<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly JDPMLFHEGFL HHNPHCONMMO;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x3A05B30", Offset = "0x3A04B30", VA = "0x183A05B30")]
	public HCKICPLBBFO(Vector3 IEHIEBBOEOM, float FOHBFABOGNJ, Vector3 FPCHMCKPKLJ, bool GPLAPIBHILO, bool HOFDPCFOGLF, OLIHKJLKGOD<TData> DKHAKCOFILG, Space GIJIFHPHGCH = Space.Self)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x3A05AD0", Offset = "0x3A04AD0", VA = "0x183A05AD0", Slot = "4")]
	public override bool EEKCMCCINIG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public class ELEPIHCHMNC<TData> : AMMFPDJEDIB<OLIHKJLKGOD<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x350BAA0", Offset = "0x350AAA0", VA = "0x18350BAA0")]
	public ELEPIHCHMNC(OLIHKJLKGOD<TData> DKHAKCOFILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x35186A0", Offset = "0x35176A0", VA = "0x1835186A0", Slot = "4")]
	public override bool EEKCMCCINIG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class JPIJLIOEPPJ<TData> : AMMFPDJEDIB<OLIHKJLKGOD<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly ALDPLBAHAIK<TData> HHNPHCONMMO;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x3D19CB0", Offset = "0x3D18CB0", VA = "0x183D19CB0")]
	public JPIJLIOEPPJ(IEnumerable<TData> GMJHBPMJMAN, bool PNBDEMDBJNH, OLIHKJLKGOD<TData> DKHAKCOFILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x39A48F0", Offset = "0x39A38F0", VA = "0x1839A48F0", Slot = "4")]
	public override bool EEKCMCCINIG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class LMPLKFFJPAP<TData> : AMMFPDJEDIB<OLIHKJLKGOD<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly BOFPPHLJFLE HHNPHCONMMO;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x3E4BD70", Offset = "0x3E4AD70", VA = "0x183E4BD70")]
	public LMPLKFFJPAP(float LACBFJFLNBN, bool AIPLNFHEMOH, Vector3 FPCHMCKPKLJ, OLIHKJLKGOD<TData> DKHAKCOFILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x3E4BCA0", Offset = "0x3E4ACA0", VA = "0x183E4BCA0", Slot = "4")]
	public override bool EEKCMCCINIG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class JCCAOPGODFG<TData> : AMMFPDJEDIB<OLIHKJLKGOD<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly MLBNOAEBLIM HHNPHCONMMO;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x3CC5160", Offset = "0x3CC4160", VA = "0x183CC5160")]
	public JCCAOPGODFG(float FOHBFABOGNJ, Vector3 FPCHMCKPKLJ, OLIHKJLKGOD<TData> DKHAKCOFILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x3538320", Offset = "0x3537320", VA = "0x183538320", Slot = "4")]
	public override bool EEKCMCCINIG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public struct JDPMLFHEGFL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public readonly Vector3 IEHIEBBOEOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public readonly float FOHBFABOGNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public readonly Vector3 FPCHMCKPKLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public readonly bool HMPEJMJFDBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public readonly Space GIJIFHPHGCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public readonly bool HOFDPCFOGLF;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x62EECC0", Offset = "0x62EDCC0", VA = "0x1862EECC0")]
	public JDPMLFHEGFL(Vector3 IEHIEBBOEOM, float FOHBFABOGNJ, Vector3 FPCHMCKPKLJ, bool HMPEJMJFDBD, bool KMLHJEEHOEJ, Space GIJIFHPHGCH = Space.Self)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public struct ALDPLBAHAIK<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public readonly IEnumerable<TData> GMJHBPMJMAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public readonly bool PNBDEMDBJNH;

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x3B675C0", Offset = "0x3B665C0", VA = "0x183B675C0")]
	public ALDPLBAHAIK(IEnumerable<TData> GMJHBPMJMAN, bool PNBDEMDBJNH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct BOFPPHLJFLE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public readonly float LACBFJFLNBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public readonly bool AIPLNFHEMOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public readonly Vector3 FPCHMCKPKLJ;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x62EE070", Offset = "0x62ED070", VA = "0x1862EE070")]
	public BOFPPHLJFLE(float LACBFJFLNBN, bool AIPLNFHEMOH, Vector3 FPCHMCKPKLJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public struct MLBNOAEBLIM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public readonly float FOHBFABOGNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public readonly Vector3 FPCHMCKPKLJ;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x46F13D0", Offset = "0x46F03D0", VA = "0x1846F13D0")]
	public MLBNOAEBLIM(float FOHBFABOGNJ, Vector3 FPCHMCKPKLJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct EPDPHJOKKII
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public readonly Guid[] GMJHBPMJMAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public readonly bool MCDEGGDGBJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public readonly bool DKIEOAJLBBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public readonly bool EPGDHLDBNLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public readonly Vector3[] AJALEAGBOEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public readonly Quaternion[] FLFOLFMPNGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public readonly float[] DKAAMAJLPIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly Dictionary<Guid, Vector3> MBOGPHBPECI;

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x62EE270", Offset = "0x62ED270", VA = "0x1862EE270")]
	public EPDPHJOKKII(Guid[] JJDEOCFOELO, Vector3[] AJALEAGBOEA, Quaternion[] FLFOLFMPNGK, float[] DKAAMAJLPIL, Dictionary<Guid, Vector3> MBOGPHBPECI, bool MCDEGGDGBJB = true, bool DKIEOAJLBBP = true, bool EPGDHLDBNLM = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x62EE0A0", Offset = "0x62ED0A0", VA = "0x1862EE0A0")]
	private static void CIGFFKKPKDB(Dictionary<Guid, Vector3> MBOGPHBPECI, int NIIKPMOEHBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public static class JFFCOCGALKB
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	private struct ODCADHONAGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public bool MHIMPHJKGEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public OIEDECFCIPC FKPNFGEALPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public OIEDECFCIPC KDLMGACNDLE;
	}

	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private static ODCADHONAGL IGFIPIBIDNN;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static CancellationToken NIOCJKBAALO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x62EF0B0", Offset = "0x62EE0B0", VA = "0x1862EF0B0")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	internal static OIEDECFCIPC FKPNFGEALPB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x62EED00", Offset = "0x62EDD00", VA = "0x1862EED00")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x62EF040", Offset = "0x62EE040", VA = "0x1862EF040")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x62EEDF0", Offset = "0x62EDDF0", VA = "0x1862EEDF0")]
	[ILJDPBHFAFI(ENLFMENACGP.Room, DIDBPCEENMM.None)]
	private static void KEGGACMAHBN(OIEDECFCIPC LHDJCLMGGIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x62EEEF0", Offset = "0x62EDEF0", VA = "0x1862EEEF0")]
	public static void KNIDJLMEEBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x62EEDA0", Offset = "0x62EDDA0", VA = "0x1862EEDA0")]
	private static OIEDECFCIPC HGCMGNLJNNA(OIEDECFCIPC NNLLFEJPNEF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public static class MAMHCGFNIMF
{
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public enum PMAAALIAFNP
	{
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		ICreationContextObject,
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		Guid
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x2973350", Offset = "0x2972350", VA = "0x182973350")]
	public static void JNIODHGPNDF<T>(T ILCIGJJMCEH, PMAAALIAFNP KBCNAJKPHNL) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x2973490", Offset = "0x2972490", VA = "0x182973490")]
	public static void JNIODHGPNDF<T>(T ILCIGJJMCEH) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x2973590", Offset = "0x2972590", VA = "0x182973590")]
	public static void OAAAAOMFCJP<T>(T ILCIGJJMCEH) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x29732B0", Offset = "0x29722B0", VA = "0x1829732B0")]
	public static T HBEPMKJLJFA<T>(PMAAALIAFNP KBCNAJKPHNL) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x2973140", Offset = "0x2972140", VA = "0x182973140")]
	public static bool FINPNHLFMNL<T>(PMAAALIAFNP KBCNAJKPHNL, T HPGDBMLLGLE, [Out] T FCOALFGLOIC) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x29734F0", Offset = "0x29724F0", VA = "0x1829734F0")]
	public static bool LOJEKLFDICI<T>(PMAAALIAFNP KBCNAJKPHNL) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x2973270", Offset = "0x2972270", VA = "0x182973270")]
	public static T HBEPMKJLJFA<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x29730A0", Offset = "0x29720A0", VA = "0x1829730A0")]
	public static bool FINPNHLFMNL<T>(T HPGDBMLLGLE, [Out] T FCOALFGLOIC) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x2973270", Offset = "0x2972270", VA = "0x182973270")]
	public static bool LOJEKLFDICI<T>() where T : class
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
internal static class OKMOMHNKLPN
{
	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x62EF370", Offset = "0x62EE370", VA = "0x1862EF370")]
	public static void FKNFDKPGKAL(IEnumerable MCGMOGJPBFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x2A448E0", Offset = "0x2A438E0", VA = "0x182A448E0")]
	public static void FKNFDKPGKAL<T>(T[] PAFIMPMPKHD) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x2A449D0", Offset = "0x2A439D0", VA = "0x182A449D0")]
	public static void FKNFDKPGKAL<T>(T PAFEMMFOAKC) where T : notnull, Enum
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
