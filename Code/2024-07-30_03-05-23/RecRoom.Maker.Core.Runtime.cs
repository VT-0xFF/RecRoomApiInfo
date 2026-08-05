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
		[Cpp2IlInjected.Address(RVA = "0x890970", Offset = "0x88EF70", VA = "0x180890970")]
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
		[Cpp2IlInjected.Address(RVA = "0x6A47E20", Offset = "0x6A46420", VA = "0x186A47E20")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8917F0", Offset = "0x88FDF0", VA = "0x1808917F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x891830", Offset = "0x88FE30", VA = "0x180891830")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface MKGHNIOACMB<TData, TReturn>
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TReturn AMAIHBOMBHF(TData NJKKPOFFNNJ);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface MDPOKDHCMHH<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ClearHoverTarget(EFKMLAPHGAB LHLKINBPHFC);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool SetHoverTarget(TData PABFDMCLKCE, Collider ANBIBNPLABL, EFKMLAPHGAB LHLKINBPHFC, [Optional] IAHLCGIKAIA? IENLNNEKPMF);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool TryGetHoverTarget([Out] TData PABFDMCLKCE);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetHoverCollider([Out] Collider ANBIBNPLABL);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface IJJCCCOBOBL<TData> : FBEOHEIPHJO, JFJFLIDBLCM<TData>, GIKFDLBCJGB<TData>, HJJOJCEKONJ<TData>, LNCBKFCJMGE, MHNJACCDMPE<TData>, OLEPODKEHEL, GNINDNJFOCK
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface MHNJACCDMPE<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 BKCDIKNOEPB, Vector3 GKDEFPHJFPJ, float KPAPKDHNJLJ, [Out] T OGJIPLGLGGP, [Out] Vector3 NBFIDDJPJKO, [Out] Collider ANBIBNPLABL);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 BKCDIKNOEPB, Vector3 GKDEFPHJFPJ, float LNFOPPJEOAE, float KPAPKDHNJLJ, T[] ADDFBGIJDCC, [Out] Vector3 DOIOAEFGEFH, [Out] Collider MMGNDMLNNKB);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 BKCDIKNOEPB, float LNFOPPJEOAE, Vector3 FJGGFMLGDOI, T[] ADDFBGIJDCC);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetObjectFromColliderInCurrentScope(Collider LHLDOGJGFAN, [Out] T GFKBPKONJJF);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface FBEOHEIPHJO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Bounds LJFGJGLCILD
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Transform LEJIMPGKLPP
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Bounds PICPGBENBCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Transform HOPDKALLMAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Vector3 BGCIELJKBGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool NOECPANGCEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void SetSelectionBoundsDirty(bool BMJGAOAKPDE = true, int FIIGFOPIDKD = 0);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ShouldHideSelectionBoundsPreview(bool NPHJJFJDPCK, object NJLOKHEKBBE);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface GNINDNJFOCK
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	AOBPFOPEJNG FODOBKJPKBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface KOLFCLMFPIH
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool FPGHOJFGIPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool LKHABNIEGEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool JMHIIBKNHLA
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
	void TrySetPreviousCloneMapping(Dictionary<Guid, Guid> FMJDLMOKCMK);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface HJJOJCEKONJ<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool BAHLFBFEBNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int PPHCLMCBIHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<TData> HJOAKEIDFCD
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData JAGONPFFNPO);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData JAGONPFFNPO);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface JFJFLIDBLCM<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T NJKKPOFFNNJ, [Optional] IAHLCGIKAIA? KLJCIEFJLHJ, bool BGEFHPACLDA = true);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int BMKFLHFENBJ, IEnumerable<T> HFCJLCCNCMK, bool BGEFHPACLDA = true);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int BMKFLHFENBJ, IEnumerable<T> HFCJLCCNCMK, IAHLCGIKAIA KLJCIEFJLHJ, bool BGEFHPACLDA = true);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface OLEPODKEHEL
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface LNCBKFCJMGE
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool KFEPKAIAHHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool KHENAEHBPAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool NEABMGMEHCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool BDPEDKBHELM
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class DJAFAIHICGI<TReceiver> : LEMFOMIHDEO<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3856220", Offset = "0x3854820", VA = "0x183856220")]
	public DJAFAIHICGI(TReceiver DOCMHCDNIBE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class KBFMJLNEJIC<TReceiver, TFromTask> : LEMFOMIHDEO<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3856220", Offset = "0x3854820", VA = "0x183856220")]
	public KBFMJLNEJIC(TReceiver DOCMHCDNIBE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public abstract class LEMFOMIHDEO<TReceiver, TFromExecute> where TReceiver : notnull where TFromExecute : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	protected TReceiver DOCMHCDNIBE;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x42C9760", Offset = "0x42C7D60", VA = "0x1842C9760")]
	public LEMFOMIHDEO(TReceiver DOCMHCDNIBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute PAIJEEONJHA();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public abstract class ECHIHDEDKBC<TReceiver, TResult> : LEMFOMIHDEO<TReceiver, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3856220", Offset = "0x3854820", VA = "0x183856220")]
	public ECHIHDEDKBC(TReceiver DOCMHCDNIBE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct JPMPCAIGNPI<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public TGroup CKFEDCJMKDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public TData JDIBMPFLALC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public IEnumerable<TData> CJOBDIHGHBI;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1EE1420", Offset = "0x1EDFA20", VA = "0x181EE1420")]
	public JPMPCAIGNPI(TGroup FGACHNAEGID, TData KEECEJCCDOL, IEnumerable<TData> ILFGEKKFINP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct DHIPFDBGBFB<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public TGroup CKFEDCJMKDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public IEnumerable<TData> CJOBDIHGHBI;

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0xAED250", Offset = "0xAEB850", VA = "0x180AED250")]
	public DHIPFDBGBFB(TGroup FGACHNAEGID, IEnumerable<TData> ILFGEKKFINP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct KMHOJFKIAEE<TGroup> where TGroup : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public TGroup CKFEDCJMKDH;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x958AF0", Offset = "0x9570F0", VA = "0x180958AF0")]
	public KMHOJFKIAEE(TGroup FGACHNAEGID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct JOMBHNBINBG<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public IEnumerable<TData> CJOBDIHGHBI;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x958AF0", Offset = "0x9570F0", VA = "0x180958AF0")]
	public JOMBHNBINBG(IEnumerable<TData> ILFGEKKFINP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface IKBKAHCDMMB<TGroup, TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CEFEGMEDEOF KCACLJHDLGH(JPMPCAIGNPI<TGroup, TData> NKFACFPILOC);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CEFEGMEDEOF EMKJGPJIDHA(JPMPCAIGNPI<TGroup, TData> NKFACFPILOC);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CEFEGMEDEOF OOJPDHCPFAB(DHIPFDBGBFB<TGroup, TData> NKFACFPILOC);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CEFEGMEDEOF JLBLHBEHPDI(KMHOJFKIAEE<TGroup> NKFACFPILOC);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface PDHOCFGBPKM<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CEFEGMEDEOF> KCACLJHDLGH(JOMBHNBINBG<TData> NKFACFPILOC);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class LCPIPPBDPBP<TGroup, TData> : ECHIHDEDKBC<IKBKAHCDMMB<TGroup, TData>, CEFEGMEDEOF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly DHIPFDBGBFB<TGroup, TData> NKFACFPILOC;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x42BA7A0", Offset = "0x42B8DA0", VA = "0x1842BA7A0")]
	public LCPIPPBDPBP(TGroup FGACHNAEGID, IEnumerable<TData> ILFGEKKFINP, IKBKAHCDMMB<TGroup, TData> DOCMHCDNIBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x42BA6D0", Offset = "0x42B8CD0", VA = "0x1842BA6D0", Slot = "4")]
	public override CEFEGMEDEOF PAIJEEONJHA()
	{
		return default(CEFEGMEDEOF);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class FICMHHNOCDI<TGroup, TData> : ECHIHDEDKBC<IKBKAHCDMMB<TGroup, TData>, CEFEGMEDEOF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly JPMPCAIGNPI<TGroup, TData> NKFACFPILOC;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3854E60", Offset = "0x3853460", VA = "0x183854E60")]
	public FICMHHNOCDI(TGroup FGACHNAEGID, TData FOJBKCOLOEC, IEnumerable<TData> ILFGEKKFINP, IKBKAHCDMMB<TGroup, TData> DOCMHCDNIBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3C1B360", Offset = "0x3C19960", VA = "0x183C1B360", Slot = "4")]
	public override CEFEGMEDEOF PAIJEEONJHA()
	{
		return default(CEFEGMEDEOF);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class FOJCPMJEHOG<TGroup, TData> : ECHIHDEDKBC<IKBKAHCDMMB<TGroup, TData>, CEFEGMEDEOF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly KMHOJFKIAEE<TGroup> NKFACFPILOC;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3C58500", Offset = "0x3C56B00", VA = "0x183C58500")]
	public FOJCPMJEHOG(TGroup FGACHNAEGID, IKBKAHCDMMB<TGroup, TData> DOCMHCDNIBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3C58430", Offset = "0x3C56A30", VA = "0x183C58430", Slot = "4")]
	public override CEFEGMEDEOF PAIJEEONJHA()
	{
		return default(CEFEGMEDEOF);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class EBEAAAFGIKL<TGroup, TData> : ECHIHDEDKBC<IKBKAHCDMMB<TGroup, TData>, CEFEGMEDEOF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly JPMPCAIGNPI<TGroup, TData> NKFACFPILOC;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3854E60", Offset = "0x3853460", VA = "0x183854E60")]
	public EBEAAAFGIKL(TGroup FGACHNAEGID, TData KEECEJCCDOL, IEnumerable<TData> ILFGEKKFINP, IKBKAHCDMMB<TGroup, TData> DOCMHCDNIBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3854D80", Offset = "0x3853380", VA = "0x183854D80", Slot = "4")]
	public override CEFEGMEDEOF PAIJEEONJHA()
	{
		return default(CEFEGMEDEOF);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class JJLPNLPHGLO<TData> : KBFMJLNEJIC<PDHOCFGBPKM<TData>, CEFEGMEDEOF> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private struct LIICODCPGDE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AsyncTaskMethodBuilder<CEFEGMEDEOF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public JJLPNLPHGLO<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private TaskAwaiter<CEFEGMEDEOF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x42DE2A0", Offset = "0x42DC8A0", VA = "0x1842DE2A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x42DE540", Offset = "0x42DCB40", VA = "0x1842DE540", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private JOMBHNBINBG<TData> NKFACFPILOC;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3C58500", Offset = "0x3C56B00", VA = "0x183C58500")]
	public JJLPNLPHGLO(IEnumerable<TData> LCJFFJNFMMA, PDHOCFGBPKM<TData> DOCMHCDNIBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x4092D90", Offset = "0x4091390", VA = "0x184092D90", Slot = "4")]
	[AsyncStateMachine(typeof(JJLPNLPHGLO<>.LIICODCPGDE))]
	public override Task<CEFEGMEDEOF> PAIJEEONJHA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct GIGDECOHOJH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly INAEDPKDOKP JLHBCBDFNGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly bool DLCFFECCNPF;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6A472E0", Offset = "0x6A458E0", VA = "0x186A472E0")]
	public GIGDECOHOJH(INAEDPKDOKP CLNGHGCPNAF, bool KFIKDEFKMNJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface NKGIEGMNNIE<TSpawnType> where TSpawnType : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> PAIJEEONJHA(GIGDECOHOJH HJNCDNGCBOJ);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class GELFKIEJFHO<TSpawnType> : KBFMJLNEJIC<NKGIEGMNNIE<TSpawnType>, TSpawnType> where TSpawnType : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private struct ALCIAABICJP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public AsyncTaskMethodBuilder<TSpawnType> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public GELFKIEJFHO<TSpawnType> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskAwaiter<TSpawnType> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x3D79FB0", Offset = "0x3D785B0", VA = "0x183D79FB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3D6D4D0", Offset = "0x3D6BAD0", VA = "0x183D6D4D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly GIGDECOHOJH HJNCDNGCBOJ;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3D09F10", Offset = "0x3D08510", VA = "0x183D09F10")]
	public GELFKIEJFHO(INAEDPKDOKP CLNGHGCPNAF, bool KFIKDEFKMNJ, NKGIEGMNNIE<TSpawnType> DOCMHCDNIBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3D09CF0", Offset = "0x3D082F0", VA = "0x183D09CF0", Slot = "4")]
	[AsyncStateMachine(typeof(GELFKIEJFHO<>.ALCIAABICJP))]
	public override Task<TSpawnType> PAIJEEONJHA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public readonly struct INAEDPKDOKP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly bool MHGMAANAIDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly Vector3 JCJMLJKLEPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly Vector3 GJMAELHLBKD;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6A47980", Offset = "0x6A45F80", VA = "0x186A47980")]
	public INAEDPKDOKP(Transform MANLGHHOJFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6A479F0", Offset = "0x6A45FF0", VA = "0x186A479F0")]
	public INAEDPKDOKP(Vector3 MHHLIPGJMOK, Vector3 MCPNOOFMAHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6A478C0", Offset = "0x6A45EC0", VA = "0x186A478C0")]
	public static INAEDPKDOKP KHNFAICPGCH()
	{
		return default(INAEDPKDOKP);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6A478F0", Offset = "0x6A45EF0", VA = "0x186A478F0")]
	private INAEDPKDOKP(bool PCAADCGOBKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct PEEJGNOAMCN<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public TNode PPKGABOKFEO;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x47AC2A0", Offset = "0x47AA8A0", VA = "0x1847AC2A0")]
	public PEEJGNOAMCN(TNode PPKGABOKFEO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct FEFIFHPPLIF<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public TNode EGEFNIGADGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public BMLKENOHBCD HDPGOJCNFKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly bool DLCFFECCNPF;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3C11050", Offset = "0x3C0F650", VA = "0x183C11050")]
	public FEFIFHPPLIF(TNode EGEFNIGADGG, BMLKENOHBCD HDPGOJCNFKO, bool KFIKDEFKMNJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface BNAJJPPOJPH<TNode>
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FGJEPHNGIEF([In] PEEJGNOAMCN<TNode> ODOBECMGEFN);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GEDKDNJNJGD([In] FEFIFHPPLIF<TNode> EGCCCEGFNCG);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool ANPLKAKHLDB();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class JCMHOPGHBBJ<TNode> : DJAFAIHICGI<BNAJJPPOJPH<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3856220", Offset = "0x3854820", VA = "0x183856220")]
	public JCMHOPGHBBJ(BNAJJPPOJPH<TNode> DOCMHCDNIBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x407BCE0", Offset = "0x407A2E0", VA = "0x18407BCE0", Slot = "4")]
	public override bool PAIJEEONJHA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class PMNEFGCNPPL<TNode> : DJAFAIHICGI<BNAJJPPOJPH<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly FEFIFHPPLIF<TNode> EGCCCEGFNCG;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x47FD160", Offset = "0x47FB760", VA = "0x1847FD160")]
	public PMNEFGCNPPL(TNode EGEFNIGADGG, BMLKENOHBCD HDPGOJCNFKO, BNAJJPPOJPH<TNode> DOCMHCDNIBE, bool KFIKDEFKMNJ = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x41C59B0", Offset = "0x41C3FB0", VA = "0x1841C59B0", Slot = "4")]
	public override bool PAIJEEONJHA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class POCGMOFDBDB<TNode> : DJAFAIHICGI<BNAJJPPOJPH<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly PEEJGNOAMCN<TNode> ODOBECMGEFN;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x4802610", Offset = "0x4800C10", VA = "0x184802610")]
	public POCGMOFDBDB(TNode EBBGGBMGPHO, BNAJJPPOJPH<TNode> DOCMHCDNIBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3C114D0", Offset = "0x3C0FAD0", VA = "0x183C114D0", Slot = "4")]
	public override bool PAIJEEONJHA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct PHJHIECDEJG<TSpawnInfo> where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public TSpawnInfo HLKNHHKNJGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public Vector3 MCPNOOFMAHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Quaternion GLKHDAMNPBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public float ICLEOPHCOMM;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x47EA9B0", Offset = "0x47E8FB0", VA = "0x1847EA9B0")]
	public PHJHIECDEJG(TSpawnInfo HLKNHHKNJGB, Vector3 MCPNOOFMAHG, Quaternion GLKHDAMNPBA, float ICLEOPHCOMM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface JGFOBOENOII<TSpawnType, TSpawnInfo>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> FPEANCKNBLD([In] PHJHIECDEJG<TSpawnInfo> KPILEDPCPEA, CancellationToken FIMAIPEFOAM);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class PFAKILNDHAJ<TSpawnType, TSpawnInfo> : KBFMJLNEJIC<JGFOBOENOII<TSpawnType, TSpawnInfo>, TSpawnType> where TSpawnType : notnull where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly PHJHIECDEJG<TSpawnInfo> CNKOAIGMGCF;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x47AE650", Offset = "0x47ACC50", VA = "0x1847AE650")]
	public PFAKILNDHAJ(TSpawnInfo BLPHNADMIAE, Vector3 MCPNOOFMAHG, Quaternion GLKHDAMNPBA, float ICLEOPHCOMM, JGFOBOENOII<TSpawnType, TSpawnInfo> DOCMHCDNIBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3D3C490", Offset = "0x3D3AA90", VA = "0x183D3C490", Slot = "4")]
	public override Task<TSpawnType> PAIJEEONJHA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct PHINCOOPACE<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly IEnumerable<TData> CJOBDIHGHBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly bool DLCFFECCNPF;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x47EA640", Offset = "0x47E8C40", VA = "0x1847EA640")]
	public PHINCOOPACE(IEnumerable<TData> ILFGEKKFINP, bool KFIKDEFKMNJ = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface GDMNGIFHBPA<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CEFEGMEDEOF> FJOAOOPLGCM([In] PHINCOOPACE<TData> GFOEHNHDFHP, CancellationToken FIMAIPEFOAM);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class GPFLEHCCIPM<TData> : KBFMJLNEJIC<GDMNGIFHBPA<TData>, CEFEGMEDEOF> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly PHINCOOPACE<TData> KPCFNHGHAIH;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3D3C570", Offset = "0x3D3AB70", VA = "0x183D3C570")]
	public GPFLEHCCIPM(IEnumerable<TData> ILFGEKKFINP, bool KFIKDEFKMNJ, GDMNGIFHBPA<TData> DOCMHCDNIBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3D3C490", Offset = "0x3D3AA90", VA = "0x183D3C490", Slot = "4")]
	public override Task<CEFEGMEDEOF> PAIJEEONJHA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct PNMJONNIDPG<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public readonly T PABFDMCLKCE;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x3C29710", Offset = "0x3C27D10", VA = "0x183C29710")]
	public PNMJONNIDPG(T BLFNOMEOPJP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface FHHGJJCCMMD<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FGJEPHNGIEF([In] PNMJONNIDPG<T> DPLNCPJFPHH);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GEDKDNJNJGD();
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface FJFBNFLBGKC<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PAIJEEONJHA([In] MPBJHONEGNN<T> PPIHBJFHNLK);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct MPBJHONEGNN<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public readonly T PABFDMCLKCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public readonly bool GINKPAEHGNE;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x44F8970", Offset = "0x44F6F70", VA = "0x1844F8970")]
	public MPBJHONEGNN(T BLFNOMEOPJP, bool NHICEADJLEG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class KLHPLBCMJFH<T> : DJAFAIHICGI<FHHGJJCCMMD<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x3856220", Offset = "0x3854820", VA = "0x183856220")]
	public KLHPLBCMJFH(FHHGJJCCMMD<T> DOCMHCDNIBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x41C03A0", Offset = "0x41BE9A0", VA = "0x1841C03A0", Slot = "4")]
	public override bool PAIJEEONJHA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class ALLBMMGEHKN<T> : DJAFAIHICGI<FHHGJJCCMMD<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly PNMJONNIDPG<T> DPLNCPJFPHH;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x3D7C1A0", Offset = "0x3D7A7A0", VA = "0x183D7C1A0")]
	public ALLBMMGEHKN(T PABFDMCLKCE, FHHGJJCCMMD<T> DOCMHCDNIBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x3C114D0", Offset = "0x3C0FAD0", VA = "0x183C114D0", Slot = "4")]
	public override bool PAIJEEONJHA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class BBEHOLBNALA<T> : DJAFAIHICGI<FJFBNFLBGKC<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly MPBJHONEGNN<T> PPIHBJFHNLK;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x4EBE2D0", Offset = "0x4EBC8D0", VA = "0x184EBE2D0")]
	public BBEHOLBNALA(T PABFDMCLKCE, bool NHICEADJLEG, FJFBNFLBGKC<T> DOCMHCDNIBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x3C114D0", Offset = "0x3C0FAD0", VA = "0x183C114D0", Slot = "4")]
	public override bool PAIJEEONJHA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct DCONHLFHNFO<TData> where TData : notnull, HKNLFGDMNPB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public IEnumerable<TData> CJOBDIHGHBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public bool KEKKEEOMEKA;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x58B5540", Offset = "0x58B3B40", VA = "0x1858B5540")]
	public DCONHLFHNFO(IEnumerable<TData> AELBIIIMCED, bool OIDLNCIIDKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct CCKHHDKIFDC<TData> where TData : notnull, HKNLFGDMNPB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public List<TData> CJOBDIHGHBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public List<bool> BFEBEHNBJNC;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x528F100", Offset = "0x528D700", VA = "0x18528F100")]
	public CCKHHDKIFDC(List<TData> AELBIIIMCED, List<bool> HOIGACAOHNP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface HKNLFGDMNPB
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool GNCBPPBDBCF
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
public interface OEAMFOPDIKO<TData> where TData : HKNLFGDMNPB
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PAIJEEONJHA([In] DCONHLFHNFO<TData> LILKINLFOEI);

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PAIJEEONJHA([In] CCKHHDKIFDC<TData> LILKINLFOEI);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface ELJNEMBDIJM<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KPMHPBHPPLG(T PABFDMCLKCE);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class MELJDEHOOOJ<TData> : DJAFAIHICGI<OEAMFOPDIKO<TData>> where TData : notnull, HKNLFGDMNPB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly DCONHLFHNFO<TData> LILKINLFOEI;

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x44C5B20", Offset = "0x44C4120", VA = "0x1844C5B20")]
	public MELJDEHOOOJ(List<TData> ILFGEKKFINP, bool KEKKEEOMEKA, OEAMFOPDIKO<TData> DOCMHCDNIBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x3C114D0", Offset = "0x3C0FAD0", VA = "0x183C114D0", Slot = "4")]
	public override bool PAIJEEONJHA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class GFPOKECBJEE<TData> : DJAFAIHICGI<OEAMFOPDIKO<TData>> where TData : notnull, HKNLFGDMNPB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly CCKHHDKIFDC<TData> LILKINLFOEI;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x3D0B040", Offset = "0x3D09640", VA = "0x183D0B040")]
	public GFPOKECBJEE(List<TData> ILFGEKKFINP, List<bool> BFEBEHNBJNC, OEAMFOPDIKO<TData> DOCMHCDNIBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x3D0AF80", Offset = "0x3D09580", VA = "0x183D0AF80", Slot = "4")]
	public override bool PAIJEEONJHA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface CNGFBJPLOAP<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CEFEGMEDEOF> PAIJEEONJHA(HEICIMDCDLG<TData> JLFIIADFHKG);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public class NNCDHMBIJCA<TData> : KBFMJLNEJIC<CNGFBJPLOAP<TData>, CEFEGMEDEOF> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct DJKLNELILEK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public AsyncTaskMethodBuilder<CEFEGMEDEOF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public NNCDHMBIJCA<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter<CEFEGMEDEOF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x58D47F0", Offset = "0x58D2DF0", VA = "0x1858D47F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x58D4AE0", Offset = "0x58D30E0", VA = "0x1858D4AE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly HEICIMDCDLG<TData> BOIMHGGMEPC;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x45D7B80", Offset = "0x45D6180", VA = "0x1845D7B80")]
	public NNCDHMBIJCA(TData KLJJEPKAJCH, IReadOnlyList<TData> MLCLKCHNAHG, bool KFIKDEFKMNJ, CNGFBJPLOAP<TData> DOCMHCDNIBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x45D7A80", Offset = "0x45D6080", VA = "0x1845D7A80", Slot = "4")]
	[AsyncStateMachine(typeof(NNCDHMBIJCA<>.DJKLNELILEK))]
	public override Task<CEFEGMEDEOF> PAIJEEONJHA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public struct HEICIMDCDLG<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public TData DCGEHPNNIAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public IReadOnlyList<TData> KKKKCNMDNCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public bool DLCFFECCNPF;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x3D98140", Offset = "0x3D96740", VA = "0x183D98140")]
	public HEICIMDCDLG(TData KLJJEPKAJCH, IReadOnlyList<TData> MLCLKCHNAHG, bool KFIKDEFKMNJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface JLGODCJEKPA<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PAIJEEONJHA([In] BJOILNKMCBG<TData> MAJDHCDGPMH);
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface KMNAAOPHFHL<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PAIJEEONJHA([In] JCFKHIDBPCC<TData> MAJDHCDGPMH);
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface INELGBDIPAJ<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NOODLALNNPF([In] HOCOMLLILNJ<TData> MAJDHCDGPMH);

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GEDKDNJNJGD();
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class FGLGJJJBDFM<TData> : DJAFAIHICGI<JLGODCJEKPA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly BJOILNKMCBG<TData> MAJDHCDGPMH;

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x3C17000", Offset = "0x3C15600", VA = "0x183C17000")]
	public FGLGJJJBDFM(IEnumerable<TData> ILFGEKKFINP, LKAPLOLHAAI PHHAMGLLFIF, EEFKMEOHOJA OLKLLNJBJND, float PLMJACIOEKG, bool KFIKDEFKMNJ, JLGODCJEKPA<TData> DOCMHCDNIBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x3C114D0", Offset = "0x3C0FAD0", VA = "0x183C114D0", Slot = "4")]
	public override bool PAIJEEONJHA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class PILIAGOKPDH<TData> : DJAFAIHICGI<KMNAAOPHFHL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly JCFKHIDBPCC<TData> MAJDHCDGPMH;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x47F4080", Offset = "0x47F2680", VA = "0x1847F4080")]
	public PILIAGOKPDH(TData[] ILFGEKKFINP, LKAPLOLHAAI[] PHHAMGLLFIF, EEFKMEOHOJA[] OLKLLNJBJND, float[] PLMJACIOEKG, KMNAAOPHFHL<TData> DOCMHCDNIBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x4198B80", Offset = "0x4197180", VA = "0x184198B80", Slot = "4")]
	public override bool PAIJEEONJHA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class NOBONABKJBM<TData> : DJAFAIHICGI<INELGBDIPAJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3856220", Offset = "0x3854820", VA = "0x183856220")]
	public NOBONABKJBM(INELGBDIPAJ<TData> DOCMHCDNIBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x45DD000", Offset = "0x45DB600", VA = "0x1845DD000", Slot = "4")]
	public override bool PAIJEEONJHA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class KHGGLIGFAAN<TData> : DJAFAIHICGI<INELGBDIPAJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly HOCOMLLILNJ<TData> MAJDHCDGPMH;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x4198C40", Offset = "0x4197240", VA = "0x184198C40")]
	public KHGGLIGFAAN(IEnumerable<TData> ILFGEKKFINP, LKAPLOLHAAI PHHAMGLLFIF, EEFKMEOHOJA OLKLLNJBJND, float PLMJACIOEKG, INELGBDIPAJ<TData> DOCMHCDNIBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x4198B80", Offset = "0x4197180", VA = "0x184198B80", Slot = "4")]
	public override bool PAIJEEONJHA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public struct BJOILNKMCBG<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public IEnumerable<TData> CJOBDIHGHBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public LKAPLOLHAAI MPMBBOKEEJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public EEFKMEOHOJA JOEAPFOLGBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public float PLMJACIOEKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public bool KFIKDEFKMNJ;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4F222C0", Offset = "0x4F208C0", VA = "0x184F222C0")]
	public BJOILNKMCBG(IEnumerable<TData> ILFGEKKFINP, LKAPLOLHAAI PHHAMGLLFIF, EEFKMEOHOJA OLKLLNJBJND, float PLMJACIOEKG, bool KFIKDEFKMNJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct JCFKHIDBPCC<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public TData[] CJOBDIHGHBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public LKAPLOLHAAI[] MPMBBOKEEJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public EEFKMEOHOJA[] JOEAPFOLGBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public float[] PLMJACIOEKG;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x407A510", Offset = "0x4078B10", VA = "0x18407A510")]
	public JCFKHIDBPCC(TData[] ILFGEKKFINP, LKAPLOLHAAI[] PHHAMGLLFIF, EEFKMEOHOJA[] OLKLLNJBJND, float[] PLMJACIOEKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public struct HOCOMLLILNJ<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public IEnumerable<TData> CJOBDIHGHBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public LKAPLOLHAAI MPMBBOKEEJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public EEFKMEOHOJA JOEAPFOLGBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public float PLMJACIOEKG;

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3DB4310", Offset = "0x3DB2910", VA = "0x183DB4310")]
	public HOCOMLLILNJ(IEnumerable<TData> ILFGEKKFINP, LKAPLOLHAAI PHHAMGLLFIF, EEFKMEOHOJA OLKLLNJBJND, float PLMJACIOEKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public interface GIKFDLBCJGB<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OOJPDHCPFAB([In] LPECFKIHDDN<TData> GFOEHNHDFHP);

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JLBLHBEHPDI([In] LPECFKIHDDN<TData> GFOEHNHDFHP);

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HBHMLADCKBP([In] bool IKOIJMOAKIF);

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool ALMJKHFKMLA([In] LPECFKIHDDN<TData> GFOEHNHDFHP);

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AIHKPFENLNI();

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool KHNFDNAAABI([In] TData MHINBGGOJGA);
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class MCKCFJCNGIH<TData> : DJAFAIHICGI<GIKFDLBCJGB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly LPECFKIHDDN<TData> GFOEHNHDFHP;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x44BC380", Offset = "0x44BA980", VA = "0x1844BC380")]
	public MCKCFJCNGIH(List<TData> DOCJELGKFHE, GIKFDLBCJGB<TData> DOCMHCDNIBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3C114D0", Offset = "0x3C0FAD0", VA = "0x183C114D0", Slot = "4")]
	public override bool PAIJEEONJHA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class DAJGKACGKMA<TData> : DJAFAIHICGI<GIKFDLBCJGB<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3856220", Offset = "0x3854820", VA = "0x183856220")]
	public DAJGKACGKMA(GIKFDLBCJGB<TData> DOCMHCDNIBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x58A7EA0", Offset = "0x58A64A0", VA = "0x1858A7EA0", Slot = "4")]
	public override bool PAIJEEONJHA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class EMJPODKECHF<TData> : DJAFAIHICGI<GIKFDLBCJGB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly bool KFIKDEFKMNJ;

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x388A4F0", Offset = "0x3888AF0", VA = "0x18388A4F0")]
	public EMJPODKECHF(bool KFIKDEFKMNJ, GIKFDLBCJGB<TData> DOCMHCDNIBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x388A490", Offset = "0x3888A90", VA = "0x18388A490", Slot = "4")]
	public override bool PAIJEEONJHA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class KIICDCNLFDD<TData> : DJAFAIHICGI<GIKFDLBCJGB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly LPECFKIHDDN<TData> GFOEHNHDFHP;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x41B5420", Offset = "0x41B3A20", VA = "0x1841B5420")]
	public KIICDCNLFDD(List<TData> DOCJELGKFHE, bool KFIKDEFKMNJ, GIKFDLBCJGB<TData> DOCMHCDNIBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3D0AF80", Offset = "0x3D09580", VA = "0x183D0AF80", Slot = "4")]
	public override bool PAIJEEONJHA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class PFCBLGECEOF<TData> : DJAFAIHICGI<GIKFDLBCJGB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly TData MHINBGGOJGA;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x47AEA10", Offset = "0x47AD010", VA = "0x1847AEA10")]
	public PFCBLGECEOF(TData MHINBGGOJGA, GIKFDLBCJGB<TData> DOCMHCDNIBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x47AE880", Offset = "0x47ACE80", VA = "0x1847AE880", Slot = "4")]
	public override bool PAIJEEONJHA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class KHHCDOFLKLE<TData> : DJAFAIHICGI<GIKFDLBCJGB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly LPECFKIHDDN<TData> GFOEHNHDFHP;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x4198E00", Offset = "0x4197400", VA = "0x184198E00")]
	public KHHCDOFLKLE(IEnumerable<TData> DOCJELGKFHE, GIKFDLBCJGB<TData> DOCMHCDNIBE, bool KFIKDEFKMNJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x4198D30", Offset = "0x4197330", VA = "0x184198D30", Slot = "4")]
	public override bool PAIJEEONJHA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public struct LPECFKIHDDN<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public IEnumerable<TData> CJOBDIHGHBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public bool KFIKDEFKMNJ;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x42EE8F0", Offset = "0x42ECEF0", VA = "0x1842EE8F0")]
	public LPECFKIHDDN(IEnumerable<TData> AELBIIIMCED, bool LNLCNNIJNEG = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public interface OHNILDOJMMO
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CEFEGMEDEOF> PAIJEEONJHA(CFGOELHPDLO IMNDPEJHOOF);
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class IGCEOCKGELB : KBFMJLNEJIC<OHNILDOJMMO, CEFEGMEDEOF>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private struct AJNNHHFKKCD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public AsyncTaskMethodBuilder<CEFEGMEDEOF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public IGCEOCKGELB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private TaskAwaiter<CEFEGMEDEOF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6A46800", Offset = "0x6A44E00", VA = "0x186A46800", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6A46A80", Offset = "0x6A45080", VA = "0x186A46A80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly CFGOELHPDLO MLCEADLPFIM;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6A475D0", Offset = "0x6A45BD0", VA = "0x186A475D0")]
	public IGCEOCKGELB(bool KFIKDEFKMNJ, OHNILDOJMMO DOCMHCDNIBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6A474E0", Offset = "0x6A45AE0", VA = "0x186A474E0", Slot = "4")]
	[AsyncStateMachine(typeof(AJNNHHFKKCD))]
	public override Task<CEFEGMEDEOF> PAIJEEONJHA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct CFGOELHPDLO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public bool DLCFFECCNPF;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x21B0DF0", Offset = "0x21AF3F0", VA = "0x1821B0DF0")]
	public CFGOELHPDLO(bool KFIKDEFKMNJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public readonly struct NAEAHLMGJLD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly bool FEKHNLKJAGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly bool IOBPOKOAONI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public readonly bool ICLEOPHCOMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public readonly bool KFIKDEFKMNJ;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4D53140", Offset = "0x4D51740", VA = "0x184D53140")]
	public NAEAHLMGJLD(bool FEKHNLKJAGL, bool IOBPOKOAONI, bool ICLEOPHCOMM, bool KFIKDEFKMNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6A47E10", Offset = "0x6A46410", VA = "0x186A47E10")]
	public NAEAHLMGJLD(bool IOBPOKOAONI, bool KFIKDEFKMNJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface CJFDLKPKNDD
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BHNPLIBGCGE(NAEAHLMGJLD DCMBELNNMJO);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LGHFJFBHMJL(NAEAHLMGJLD DCMBELNNMJO);
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class ANNAJJCHJPG : DJAFAIHICGI<CJFDLKPKNDD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly NAEAHLMGJLD DCMBELNNMJO;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6A46B40", Offset = "0x6A45140", VA = "0x186A46B40")]
	public ANNAJJCHJPG(bool AFJHLFMCCIJ, bool IOBPOKOAONI, bool ICLEOPHCOMM, bool KFIKDEFKMNJ, CJFDLKPKNDD DOCMHCDNIBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6A46AF0", Offset = "0x6A450F0", VA = "0x186A46AF0", Slot = "4")]
	public override bool PAIJEEONJHA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class HGAHMKLHGID : DJAFAIHICGI<CJFDLKPKNDD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly NAEAHLMGJLD DCMBELNNMJO;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6A47350", Offset = "0x6A45950", VA = "0x186A47350")]
	public HGAHMKLHGID(bool IOBPOKOAONI, bool KFIKDEFKMNJ, CJFDLKPKNDD DOCMHCDNIBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6A47300", Offset = "0x6A45900", VA = "0x186A47300", Slot = "4")]
	public override bool PAIJEEONJHA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public interface NMKIKIGFCGG
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PAIJEEONJHA([In] CHEBLIMMOHF CCCMNGKFBKI);
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class IIJDEIGFJMN : DJAFAIHICGI<NMKIKIGFCGG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly CHEBLIMMOHF CCCMNGKFBKI;

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6A476E0", Offset = "0x6A45CE0", VA = "0x186A476E0")]
	public IIJDEIGFJMN(Guid[] KBBGGEFOAJI, Vector3[] BPNPNNCOAHG, Quaternion[] PJAOOCFICAM, float[] MMNBFGNHDPH, Dictionary<Guid, Vector3> KLIOBDBIGOL, NMKIKIGFCGG DOCMHCDNIBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6A47630", Offset = "0x6A45C30", VA = "0x186A47630", Slot = "4")]
	public override bool PAIJEEONJHA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public interface PAOLJAOFCIM<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FGJEPHNGIEF([In] JNALPFLJMCB<TData> ODOBECMGEFN);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NOODLALNNPF([In] AFDDIGGLNDC FOJIFOEHEBO);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NOODLALNNPF([In] CCBNPACMADN FOJIFOEHEBO);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool GEDKDNJNJGD();
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class PLOACONOPKI<TData> : DJAFAIHICGI<PAOLJAOFCIM<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x3856220", Offset = "0x3854820", VA = "0x183856220")]
	public PLOACONOPKI(PAOLJAOFCIM<TData> DOCMHCDNIBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x47FBD90", Offset = "0x47FA390", VA = "0x1847FBD90", Slot = "4")]
	public override bool PAIJEEONJHA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class NFJIDEMBPFH<TData> : DJAFAIHICGI<PAOLJAOFCIM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly AFDDIGGLNDC MPFKCBNIHLK;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x4563DA0", Offset = "0x45623A0", VA = "0x184563DA0")]
	public NFJIDEMBPFH(Vector3 KIBBHJOOJPJ, bool BMNFIPJIBEL, PAOLJAOFCIM<TData> DOCMHCDNIBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x42CB750", Offset = "0x42C9D50", VA = "0x1842CB750", Slot = "4")]
	public override bool PAIJEEONJHA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class GLNICLIBMEB<TData> : DJAFAIHICGI<PAOLJAOFCIM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly CCBNPACMADN MPFKCBNIHLK;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x3D36A10", Offset = "0x3D35010", VA = "0x183D36A10")]
	public GLNICLIBMEB(Guid LFFEAJIMKND, int PDMMEDBMFPP, Vector3 MCPNOOFMAHG, Quaternion GLKHDAMNPBA, float PKDKCKJPOHP, bool BMNFIPJIBEL, PAOLJAOFCIM<TData> DOCMHCDNIBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x3D369B0", Offset = "0x3D34FB0", VA = "0x183D369B0", Slot = "4")]
	public override bool PAIJEEONJHA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class OOLHPLEEIEN<TData> : DJAFAIHICGI<PAOLJAOFCIM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly JNALPFLJMCB<TData> MPFKCBNIHLK;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x46FA900", Offset = "0x46F8F00", VA = "0x1846FA900")]
	public OOLHPLEEIEN(TData PABFDMCLKCE, bool KFIKDEFKMNJ, PAOLJAOFCIM<TData> DOCMHCDNIBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x3C114D0", Offset = "0x3C0FAD0", VA = "0x183C114D0", Slot = "4")]
	public override bool PAIJEEONJHA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public struct AFDDIGGLNDC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly Vector3 KIBBHJOOJPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public readonly bool BMNFIPJIBEL;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x6A467E0", Offset = "0x6A44DE0", VA = "0x186A467E0")]
	public AFDDIGGLNDC(Vector3 KIBBHJOOJPJ, bool BMNFIPJIBEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public struct CCBNPACMADN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public readonly Guid LFFEAJIMKND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public readonly int PDMMEDBMFPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public readonly Vector3 MCPNOOFMAHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public readonly Quaternion GLKHDAMNPBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public readonly float PKDKCKJPOHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public readonly bool BMNFIPJIBEL;

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6A46E00", Offset = "0x6A45400", VA = "0x186A46E00")]
	public CCBNPACMADN(Guid LFFEAJIMKND, int PDMMEDBMFPP, Vector3 MCPNOOFMAHG, Quaternion GLKHDAMNPBA, float PKDKCKJPOHP, bool BMNFIPJIBEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public struct JNALPFLJMCB<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public readonly TData PABFDMCLKCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public readonly bool KFIKDEFKMNJ;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x40A3380", Offset = "0x40A1980", VA = "0x1840A3380")]
	public JNALPFLJMCB(TData PABFDMCLKCE, bool KFIKDEFKMNJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public interface DHCKJNNCHDJ<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PAIJEEONJHA([In] KFEPLODCHHH<TData> LGPCIGDIJGP);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PAIJEEONJHA([In] LGHFGLNMNPL<TData> LGPCIGDIJGP);
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public interface GPCFELKMHDC<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FGJEPHNGIEF([In] JPLEILDPFEH<TData> LBLNBKNNKAL);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NOODLALNNPF([In] NPHACHBHOAJ FOJIFOEHEBO);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GEDKDNJNJGD();
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class BCHGFDKNLAI<TData> : DJAFAIHICGI<DHCKJNNCHDJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly KFEPLODCHHH<TData> LGPCIGDIJGP;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x4EC3280", Offset = "0x4EC1880", VA = "0x184EC3280")]
	public BCHGFDKNLAI(IEnumerable<TData> ILFGEKKFINP, Vector3 COIJLFHHCNB, bool KFIKDEFKMNJ, DHCKJNNCHDJ<TData> DOCMHCDNIBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x3C114D0", Offset = "0x3C0FAD0", VA = "0x183C114D0", Slot = "4")]
	public override bool PAIJEEONJHA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class OLDJNIJCIAL<TData> : DJAFAIHICGI<GPCFELKMHDC<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x3856220", Offset = "0x3854820", VA = "0x183856220")]
	public OLDJNIJCIAL(GPCFELKMHDC<TData> DOCMHCDNIBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x407BCE0", Offset = "0x407A2E0", VA = "0x18407BCE0", Slot = "4")]
	public override bool PAIJEEONJHA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class MCBKECNOMEG<TData> : DJAFAIHICGI<GPCFELKMHDC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly JPLEILDPFEH<TData> LGPCIGDIJGP;

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x44B4FC0", Offset = "0x44B35C0", VA = "0x1844B4FC0")]
	public MCBKECNOMEG(IEnumerable<TData> ILFGEKKFINP, bool KFIKDEFKMNJ, GPCFELKMHDC<TData> DOCMHCDNIBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x3C114D0", Offset = "0x3C0FAD0", VA = "0x183C114D0", Slot = "4")]
	public override bool PAIJEEONJHA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class KMLDOGNMIDF<TData> : DJAFAIHICGI<DHCKJNNCHDJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly LGHFGLNMNPL<TData> LGPCIGDIJGP;

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x41C5A80", Offset = "0x41C4080", VA = "0x1841C5A80")]
	public KMLDOGNMIDF(IEnumerable<TData> ILFGEKKFINP, Vector3 MJPOAHEGGND, IKLKEEEFDFE IPHODNKJOOP, bool KFIKDEFKMNJ, DHCKJNNCHDJ<TData> DOCMHCDNIBE, Space NLHHIOECOBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x41C59B0", Offset = "0x41C3FB0", VA = "0x1841C59B0", Slot = "4")]
	public override bool PAIJEEONJHA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class LFIFAIDJIHH<TData> : DJAFAIHICGI<GPCFELKMHDC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly NPHACHBHOAJ LGPCIGDIJGP;

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x42CB7B0", Offset = "0x42C9DB0", VA = "0x1842CB7B0")]
	public LFIFAIDJIHH(Vector3 COIJLFHHCNB, GPCFELKMHDC<TData> DOCMHCDNIBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x42CB750", Offset = "0x42C9D50", VA = "0x1842CB750", Slot = "4")]
	public override bool PAIJEEONJHA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct KFEPLODCHHH<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public readonly IEnumerable<TData> ILFGEKKFINP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public readonly Vector3 COIJLFHHCNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public readonly bool KFIKDEFKMNJ;

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x41888D0", Offset = "0x4186ED0", VA = "0x1841888D0")]
	public KFEPLODCHHH(IEnumerable<TData> ILFGEKKFINP, Vector3 COIJLFHHCNB, bool KFIKDEFKMNJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct JPLEILDPFEH<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public readonly IEnumerable<TData> ILFGEKKFINP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public readonly bool KFIKDEFKMNJ;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x40BE070", Offset = "0x40BC670", VA = "0x1840BE070")]
	public JPLEILDPFEH(IEnumerable<TData> ILFGEKKFINP, bool KFIKDEFKMNJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct LGHFGLNMNPL<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public readonly IEnumerable<TData> ILFGEKKFINP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public readonly Vector3 MJPOAHEGGND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly IKLKEEEFDFE IPHODNKJOOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public readonly bool KFIKDEFKMNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly Space NLHHIOECOBA;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x42D0070", Offset = "0x42CE670", VA = "0x1842D0070")]
	public LGHFGLNMNPL(IEnumerable<TData> ILFGEKKFINP, Vector3 MJPOAHEGGND, IKLKEEEFDFE IPHODNKJOOP, bool KFIKDEFKMNJ, Space NLHHIOECOBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct NPHACHBHOAJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public readonly Vector3 COIJLFHHCNB;

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x21B0E00", Offset = "0x21AF400", VA = "0x1821B0E00")]
	public NPHACHBHOAJ(Vector3 COIJLFHHCNB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public enum IKLKEEEFDFE
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
public interface MDLEJDPDKNO
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PAIJEEONJHA([In] DILHGAPCBHB CPANCIBOALP);
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public class IEGIAOBKGKN : DJAFAIHICGI<MDLEJDPDKNO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly DILHGAPCBHB CPANCIBOALP;

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6A47480", Offset = "0x6A45A80", VA = "0x186A47480")]
	public IEGIAOBKGKN(bool KFIKDEFKMNJ, MDLEJDPDKNO DOCMHCDNIBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6A473D0", Offset = "0x6A459D0", VA = "0x186A473D0", Slot = "4")]
	public override bool PAIJEEONJHA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public readonly struct DILHGAPCBHB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public readonly bool KFIKDEFKMNJ;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x21B0DF0", Offset = "0x21AF3F0", VA = "0x1821B0DF0")]
	public DILHGAPCBHB(bool KFIKDEFKMNJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public interface EKPKODEFGPC<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PAIJEEONJHA([In] OEDIKFJDFIC<TData> JHKGCFBONGA);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PAIJEEONJHA([In] HNKPEOCNMNO<TData> JHKGCFBONGA);
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public interface MOFAOKFECON<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FGJEPHNGIEF([In] LGKGOKOCJAN<TData> ODOBECMGEFN);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NOODLALNNPF([In] ICBNJDGEAAA FOJIFOEHEBO);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GEDKDNJNJGD();
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class JIEJADFOODD<TData> : DJAFAIHICGI<EKPKODEFGPC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly OEDIKFJDFIC<TData> JHKGCFBONGA;

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x4091A50", Offset = "0x4090050", VA = "0x184091A50")]
	public JIEJADFOODD(IEnumerable<TData> ILFGEKKFINP, Quaternion COIJLFHHCNB, Vector3? EAGODCJNBBL, bool CICHHBHCEGA, bool KFIKDEFKMNJ, EKPKODEFGPC<TData> DOCMHCDNIBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x3C114D0", Offset = "0x3C0FAD0", VA = "0x183C114D0", Slot = "4")]
	public override bool PAIJEEONJHA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class MIGKHHOJIBG<TData> : DJAFAIHICGI<MOFAOKFECON<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x3856220", Offset = "0x3854820", VA = "0x183856220")]
	public MIGKHHOJIBG(MOFAOKFECON<TData> DOCMHCDNIBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x407BCE0", Offset = "0x407A2E0", VA = "0x18407BCE0", Slot = "4")]
	public override bool PAIJEEONJHA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class PAECKEPGEJG<TData> : DJAFAIHICGI<MOFAOKFECON<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly LGKGOKOCJAN<TData> JHKGCFBONGA;

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x478EC70", Offset = "0x478D270", VA = "0x18478EC70")]
	public PAECKEPGEJG(IEnumerable<TData> ILFGEKKFINP, bool KFIKDEFKMNJ, MOFAOKFECON<TData> DOCMHCDNIBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x3C114D0", Offset = "0x3C0FAD0", VA = "0x183C114D0", Slot = "4")]
	public override bool PAIJEEONJHA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class MNFEJCLOJBO<TData> : DJAFAIHICGI<EKPKODEFGPC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly HNKPEOCNMNO<TData> JHKGCFBONGA;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x44F2AF0", Offset = "0x44F10F0", VA = "0x1844F2AF0")]
	public MNFEJCLOJBO(IEnumerable<TData> ILFGEKKFINP, Quaternion OBAHGDOINKO, IKLKEEEFDFE NGAIENOPAPC, Vector3? EAGODCJNBBL, bool CICHHBHCEGA, bool KFIKDEFKMNJ, Space NLHHIOECOBA, EKPKODEFGPC<TData> DOCMHCDNIBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x41C59B0", Offset = "0x41C3FB0", VA = "0x1841C59B0", Slot = "4")]
	public override bool PAIJEEONJHA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class OPGCPEDLJCI<TData> : DJAFAIHICGI<MOFAOKFECON<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly ICBNJDGEAAA JHKGCFBONGA;

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x46FF450", Offset = "0x46FDA50", VA = "0x1846FF450")]
	public OPGCPEDLJCI(Quaternion COIJLFHHCNB, Vector3? EAGODCJNBBL, bool CICHHBHCEGA, MOFAOKFECON<TData> DOCMHCDNIBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x42CB750", Offset = "0x42C9D50", VA = "0x1842CB750", Slot = "4")]
	public override bool PAIJEEONJHA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public struct OEDIKFJDFIC<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public readonly IEnumerable<TData> ILFGEKKFINP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public readonly Quaternion COIJLFHHCNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public readonly Vector3? EAGODCJNBBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public readonly bool CICHHBHCEGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public readonly bool KFIKDEFKMNJ;

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x46C90F0", Offset = "0x46C76F0", VA = "0x1846C90F0")]
	public OEDIKFJDFIC(IEnumerable<TData> ILFGEKKFINP, Quaternion COIJLFHHCNB, Vector3? EAGODCJNBBL, bool CICHHBHCEGA, bool KFIKDEFKMNJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public struct LGKGOKOCJAN<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public readonly IEnumerable<TData> ILFGEKKFINP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly bool KFIKDEFKMNJ;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x42D1E20", Offset = "0x42D0420", VA = "0x1842D1E20")]
	public LGKGOKOCJAN(IEnumerable<TData> ILFGEKKFINP, bool KFIKDEFKMNJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public struct HNKPEOCNMNO<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public readonly IEnumerable<TData> ILFGEKKFINP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public readonly Quaternion OBAHGDOINKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public readonly IKLKEEEFDFE NGAIENOPAPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public readonly Vector3? EAGODCJNBBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public readonly bool CICHHBHCEGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public readonly bool KFIKDEFKMNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public readonly Space NLHHIOECOBA;

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x3DB3DD0", Offset = "0x3DB23D0", VA = "0x183DB3DD0")]
	public HNKPEOCNMNO(IEnumerable<TData> ILFGEKKFINP, Quaternion OBAHGDOINKO, IKLKEEEFDFE NGAIENOPAPC, Vector3? EAGODCJNBBL, bool CICHHBHCEGA, bool KFIKDEFKMNJ, Space NLHHIOECOBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public struct ICBNJDGEAAA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public readonly Quaternion COIJLFHHCNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public readonly Vector3? EAGODCJNBBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public readonly bool CICHHBHCEGA;

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x4D15BC0", Offset = "0x4D141C0", VA = "0x184D15BC0")]
	public ICBNJDGEAAA(Quaternion COIJLFHHCNB, Vector3? EAGODCJNBBL, bool CICHHBHCEGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public interface NPOGDNFBPMP<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FGJEPHNGIEF([In] DODJFAAGGMI<TData> ODOBECMGEFN);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NOODLALNNPF([In] AGECLDJNJHF FOJIFOEHEBO);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NOODLALNNPF([In] LCPHCOKMAHG FOJIFOEHEBO);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool NOODLALNNPF([In] GIFECGBHGOC FOJIFOEHEBO);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool GEDKDNJNJGD();
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public class NPNNHNLNKLK<TData> : DJAFAIHICGI<NPOGDNFBPMP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly GIFECGBHGOC LOGKNDJOJJA;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x45E2260", Offset = "0x45E0860", VA = "0x1845E2260")]
	public NPNNHNLNKLK(Vector3 HEAFBLHGEHC, float FEMHAGNJCKL, Vector3 EAGODCJNBBL, bool IEJFNAHPKKH, bool KIBGEHDFDBN, NPOGDNFBPMP<TData> DOCMHCDNIBE, Space NLHHIOECOBA = Space.Self)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x45E2200", Offset = "0x45E0800", VA = "0x1845E2200", Slot = "4")]
	public override bool PAIJEEONJHA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public class OFOFPHHBNLE<TData> : DJAFAIHICGI<NPOGDNFBPMP<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x3856220", Offset = "0x3854820", VA = "0x183856220")]
	public OFOFPHHBNLE(NPOGDNFBPMP<TData> DOCMHCDNIBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x46CE970", Offset = "0x46CCF70", VA = "0x1846CE970", Slot = "4")]
	public override bool PAIJEEONJHA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class FEIKDAGHCON<TData> : DJAFAIHICGI<NPOGDNFBPMP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly DODJFAAGGMI<TData> LOGKNDJOJJA;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x3C11590", Offset = "0x3C0FB90", VA = "0x183C11590")]
	public FEIKDAGHCON(IEnumerable<TData> ILFGEKKFINP, bool KFIKDEFKMNJ, NPOGDNFBPMP<TData> DOCMHCDNIBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x3C114D0", Offset = "0x3C0FAD0", VA = "0x183C114D0", Slot = "4")]
	public override bool PAIJEEONJHA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class JPKHFMKIKMF<TData> : DJAFAIHICGI<NPOGDNFBPMP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly LCPHCOKMAHG LOGKNDJOJJA;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x40BDC70", Offset = "0x40BC270", VA = "0x1840BDC70")]
	public JPKHFMKIKMF(float MHMOLFHOAPG, bool LEICAKJMGDH, Vector3 EAGODCJNBBL, NPOGDNFBPMP<TData> DOCMHCDNIBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x40BDBA0", Offset = "0x40BC1A0", VA = "0x1840BDBA0", Slot = "4")]
	public override bool PAIJEEONJHA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class PGAIPEOCJGP<TData> : DJAFAIHICGI<NPOGDNFBPMP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly AGECLDJNJHF LOGKNDJOJJA;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x47B9ED0", Offset = "0x47B84D0", VA = "0x1847B9ED0")]
	public PGAIPEOCJGP(float FEMHAGNJCKL, Vector3 EAGODCJNBBL, NPOGDNFBPMP<TData> DOCMHCDNIBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x42CB750", Offset = "0x42C9D50", VA = "0x1842CB750", Slot = "4")]
	public override bool PAIJEEONJHA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public struct GIFECGBHGOC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public readonly Vector3 HEAFBLHGEHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public readonly float FEMHAGNJCKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public readonly Vector3 EAGODCJNBBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public readonly bool BMNFIPJIBEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public readonly Space NLHHIOECOBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public readonly bool KIBGEHDFDBN;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x6A472A0", Offset = "0x6A458A0", VA = "0x186A472A0")]
	public GIFECGBHGOC(Vector3 HEAFBLHGEHC, float FEMHAGNJCKL, Vector3 EAGODCJNBBL, bool BMNFIPJIBEL, bool EDHELFEFFLB, Space NLHHIOECOBA = Space.Self)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public struct DODJFAAGGMI<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public readonly IEnumerable<TData> ILFGEKKFINP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public readonly bool KFIKDEFKMNJ;

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x58EA240", Offset = "0x58E8840", VA = "0x1858EA240")]
	public DODJFAAGGMI(IEnumerable<TData> ILFGEKKFINP, bool KFIKDEFKMNJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct LCPHCOKMAHG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public readonly float MHMOLFHOAPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public readonly bool LEICAKJMGDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public readonly Vector3 EAGODCJNBBL;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x6A47A20", Offset = "0x6A46020", VA = "0x186A47A20")]
	public LCPHCOKMAHG(float MHMOLFHOAPG, bool LEICAKJMGDH, Vector3 EAGODCJNBBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public struct AGECLDJNJHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public readonly float FEMHAGNJCKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public readonly Vector3 EAGODCJNBBL;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x4CE50D0", Offset = "0x4CE36D0", VA = "0x184CE50D0")]
	public AGECLDJNJHF(float FEMHAGNJCKL, Vector3 EAGODCJNBBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct CHEBLIMMOHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public readonly Guid[] ILFGEKKFINP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public readonly bool HJEGOHALPOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public readonly bool JKGJCHHAPDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public readonly bool HHFHPGCOHFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public readonly Vector3[] BPNPNNCOAHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public readonly Quaternion[] PJAOOCFICAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly float[] MMNBFGNHDPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public readonly Dictionary<Guid, Vector3> KLIOBDBIGOL;

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6A47010", Offset = "0x6A45610", VA = "0x186A47010")]
	public CHEBLIMMOHF(Guid[] KBBGGEFOAJI, Vector3[] BPNPNNCOAHG, Quaternion[] PJAOOCFICAM, float[] MMNBFGNHDPH, Dictionary<Guid, Vector3> KLIOBDBIGOL, bool HJEGOHALPOE = true, bool JKGJCHHAPDJ = true, bool HHFHPGCOHFD = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x6A46E40", Offset = "0x6A45440", VA = "0x186A46E40")]
	private static void MKGMPHMDLNI(Dictionary<Guid, Vector3> KLIOBDBIGOL, int PBDDDOGMOMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public static class LICBHKPLCDF
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	private struct CJDOMHMECAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public bool MMJAMPDOBEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public GLOPJKBGAFG JBKNALDDBEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public GLOPJKBGAFG MINCOJEKHAI;
	}

	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private static CJDOMHMECAH DLDHPJEIIMK;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static CancellationToken LDPKNPINICA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x6A47A40", Offset = "0x6A46040", VA = "0x186A47A40")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	internal static GLOPJKBGAFG JBKNALDDBEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x6A47B60", Offset = "0x6A46160", VA = "0x186A47B60")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6A47C00", Offset = "0x6A46200", VA = "0x186A47C00")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6A47A60", Offset = "0x6A46060", VA = "0x186A47A60")]
	[ILMJIPMJHLC(LIEKAGJMIGB.Room, IAFNNCJJPGN.None)]
	private static void ENMGGHMAIPC(GLOPJKBGAFG JJCEEIMMDLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6A47CC0", Offset = "0x6A462C0", VA = "0x186A47CC0")]
	public static void LJOBMJGJKLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6A47C70", Offset = "0x6A46270", VA = "0x186A47C70")]
	private static GLOPJKBGAFG LDCFBNPDKOP(GLOPJKBGAFG EFCPBEBIJHK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public static class LOLMGLMAEOM
{
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public enum EFBKNMBADHE
	{
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		ICreationContextObject,
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		Guid
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x2C5CB20", Offset = "0x2C5B120", VA = "0x182C5CB20")]
	public static void DELIOMDPBMJ<T>(T ADJKKNJDKEH, EFBKNMBADHE GOAECDHCJMK) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x2C5CAB0", Offset = "0x2C5B0B0", VA = "0x182C5CAB0")]
	public static void DELIOMDPBMJ<T>(T ADJKKNJDKEH) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x2C5CFB0", Offset = "0x2C5B5B0", VA = "0x182C5CFB0")]
	public static void IFCJKJNHEIA<T>(T ADJKKNJDKEH) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x2C5CEA0", Offset = "0x2C5B4A0", VA = "0x182C5CEA0")]
	public static T FOHHCFMHKPE<T>(EFBKNMBADHE GOAECDHCJMK) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x2C5CD50", Offset = "0x2C5B350", VA = "0x182C5CD50")]
	public static bool EGCGJKFAAFH<T>(EFBKNMBADHE GOAECDHCJMK, T? EFGCKJHHCCJ, [Out][NotNullWhen(true)][MaybeNullWhen(false)] T GOEMLIMJKHL) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x2C5D060", Offset = "0x2C5B660", VA = "0x182C5D060")]
	public static bool LEGDPALAHDJ<T>(EFBKNMBADHE GOAECDHCJMK) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x2C5CF50", Offset = "0x2C5B550", VA = "0x182C5CF50")]
	public static T FOHHCFMHKPE<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x2C5CC90", Offset = "0x2C5B290", VA = "0x182C5CC90")]
	public static bool EGCGJKFAAFH<T>(T EFGCKJHHCCJ, [Out] T GOEMLIMJKHL) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x2C5CF50", Offset = "0x2C5B550", VA = "0x182C5CF50")]
	public static bool LEGDPALAHDJ<T>() where T : class
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
internal static class BPGOPEIODEK
{
	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6A46BD0", Offset = "0x6A451D0", VA = "0x186A46BD0")]
	public static void HOLCMCJONOG(IEnumerable KOIKDJBNAGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x293CDE0", Offset = "0x293B3E0", VA = "0x18293CDE0")]
	public static void HOLCMCJONOG<T>(T[] FAJBEEIFFCK) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x293CFC0", Offset = "0x293B5C0", VA = "0x18293CFC0")]
	public static void HOLCMCJONOG<T>(T ANPOJJGGDDM) where T : notnull, Enum
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
