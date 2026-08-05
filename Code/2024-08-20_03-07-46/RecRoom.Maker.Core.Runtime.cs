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
		[Cpp2IlInjected.Address(RVA = "0x87BDE0", Offset = "0x87ADE0", VA = "0x18087BDE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x69BD020", Offset = "0x69BC020", VA = "0x1869BD020")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x87C700", Offset = "0x87B700", VA = "0x18087C700")]
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
		[Cpp2IlInjected.Address(RVA = "0x87C740", Offset = "0x87B740", VA = "0x18087C740")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface DGPDBEBKOEP<TData, TReturn>
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TReturn OABEHOEGPFD(TData NOPFNIKINJA);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface PILBAPOJFPG<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ClearHoverTarget(NPIEAHGKGOG NPLJFNLONEE);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool SetHoverTarget(TData KAEDHDLBKFF, Collider KHMPKJCGLOO, NPIEAHGKGOG NPLJFNLONEE, [Optional] IEOFDADILNN? KHDAOEOFODE);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool TryGetHoverTarget([Out] TData KAEDHDLBKFF);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetHoverCollider([Out] Collider KHMPKJCGLOO);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface LPNODNCOOLF<TData> : LDMBPDENONK, AOCOBFOEGAI<TData>, NGJBKGBAAPC<TData>, ELPABBKEMBL<TData>, FDDFJACHLBG, HAANIMIGAKP<TData>, DOCKGHBAELK, NIODLACJJHG
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface HAANIMIGAKP<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 MAFKHKANKNB, Vector3 DJAIHLPIJBH, float BIJEBEJFKBC, [Out] T HPGFGPPENDD, [Out] Vector3 GLPBPPIIOOM, [Out] Collider KHMPKJCGLOO);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 MAFKHKANKNB, Vector3 DJAIHLPIJBH, float IMMCDIGLHMJ, float BIJEBEJFKBC, T[] CMMGHJJACNG, [Out] Vector3 FOFCPLOPDJK, [Out] Collider BGOKDBIKGIO);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 MAFKHKANKNB, float IMMCDIGLHMJ, Vector3 GBCKBAJMPPC, T[] CMMGHJJACNG);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetObjectFromColliderInCurrentScope(Collider PEMDJFGIBMG, [Out] T CKGHOANKFHI);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface LDMBPDENONK
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Bounds FMMBHABHPGI
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Transform KEMAPMEPJOP
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Bounds EINHHFMHINB
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Transform FBJPBCAOPLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Vector3 NANJKOPNCDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool EOLMEGJBHDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void SetSelectionBoundsDirty(bool IEECILNFIPP = true, int OBDCMDPFBIF = 0);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ShouldHideSelectionBoundsPreview(bool BAGMJANNAIJ, object DJIBMMAIGPE);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface NIODLACJJHG
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	PEHINEDJEEO CNFDOJLBECF
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface OFJFMCMFDPG
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool HBDFCOFKNEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool IPJIMEKKEEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool BDICJNDBGOA
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
	void TrySetPreviousCloneMapping(Dictionary<Guid, Guid> JCAGLJCAGJK);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface ELPABBKEMBL<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool PJHAAJBGNCK
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int HPMMCMDCIMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<TData> BCDBMJBGJFL
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData LLGHCONMHCJ);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData LLGHCONMHCJ);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface AOCOBFOEGAI<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T NOPFNIKINJA, [Optional] IEOFDADILNN? ODDDGHEKLOB, bool PHPCKOJINJD = true);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int DOPPKGNLPAC, IEnumerable<T> HCHCJEKMPPP, bool PHPCKOJINJD = true);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int DOPPKGNLPAC, IEnumerable<T> HCHCJEKMPPP, IEOFDADILNN ODDDGHEKLOB, bool PHPCKOJINJD = true);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface DOCKGHBAELK
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface FDDFJACHLBG
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool GIHFLFOIDMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool DOGGEDLLPKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool PAOELOKJBHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool LMJKOMHANDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class IDIFDLEKLHF<TReceiver> : JOABBECAAJJ<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3C0FBB0", Offset = "0x3C0EBB0", VA = "0x183C0FBB0")]
	public IDIFDLEKLHF(TReceiver PPGNDOHCHFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class GACOMIAJODA<TReceiver, TFromTask> : JOABBECAAJJ<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3C0FBB0", Offset = "0x3C0EBB0", VA = "0x183C0FBB0")]
	public GACOMIAJODA(TReceiver PPGNDOHCHFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public abstract class JOABBECAAJJ<TReceiver, TFromExecute> where TReceiver : notnull where TFromExecute : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	protected TReceiver PPGNDOHCHFE;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x411B820", Offset = "0x411A820", VA = "0x18411B820")]
	public JOABBECAAJJ(TReceiver PPGNDOHCHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute ODIGKBLPPJN();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public abstract class FMPIOAEEIGI<TReceiver, TResult> : JOABBECAAJJ<TReceiver, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3C0FBB0", Offset = "0x3C0EBB0", VA = "0x183C0FBB0")]
	public FMPIOAEEIGI(TReceiver PPGNDOHCHFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct OJMFFAMEAPM<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public TGroup DNAIOHOLCOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public TData IHHECLINOCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public IEnumerable<TData> MCFCDCEFPIL;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1EED100", Offset = "0x1EEC100", VA = "0x181EED100")]
	public OJMFFAMEAPM(TGroup GAEPCLPMAEJ, TData JIHJACOEFNG, IEnumerable<TData> JMIAMLFMLAO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct AKNGMAPCDBI<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public TGroup DNAIOHOLCOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public IEnumerable<TData> MCFCDCEFPIL;

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0xB852B0", Offset = "0xB842B0", VA = "0x180B852B0")]
	public AKNGMAPCDBI(TGroup GAEPCLPMAEJ, IEnumerable<TData> JMIAMLFMLAO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct KFMNGAMCFOE<TGroup> where TGroup : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public TGroup DNAIOHOLCOK;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0xA111F0", Offset = "0xA101F0", VA = "0x180A111F0")]
	public KFMNGAMCFOE(TGroup GAEPCLPMAEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct JLNEJKKHGPK<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public IEnumerable<TData> MCFCDCEFPIL;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0xA111F0", Offset = "0xA101F0", VA = "0x180A111F0")]
	public JLNEJKKHGPK(IEnumerable<TData> JMIAMLFMLAO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface DEFIEPAOIJN<TGroup, TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PAEGLKIGDFP JPJCGLBIEMM(OJMFFAMEAPM<TGroup, TData> GJOMAKELDOD);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "1")]
	PAEGLKIGDFP FFBPBOGOMGE(OJMFFAMEAPM<TGroup, TData> GJOMAKELDOD);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "2")]
	PAEGLKIGDFP CMCCLKCIDLH(AKNGMAPCDBI<TGroup, TData> GJOMAKELDOD);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "3")]
	PAEGLKIGDFP LBBLEHINHMC(KFMNGAMCFOE<TGroup> GJOMAKELDOD);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface BOCINCEGDGJ<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<PAEGLKIGDFP> JPJCGLBIEMM(JLNEJKKHGPK<TData> GJOMAKELDOD);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class BJPGPIJGFFP<TGroup, TData> : FMPIOAEEIGI<DEFIEPAOIJN<TGroup, TData>, PAEGLKIGDFP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly AKNGMAPCDBI<TGroup, TData> GJOMAKELDOD;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4E98290", Offset = "0x4E97290", VA = "0x184E98290")]
	public BJPGPIJGFFP(TGroup GAEPCLPMAEJ, IEnumerable<TData> JMIAMLFMLAO, DEFIEPAOIJN<TGroup, TData> PPGNDOHCHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4E981C0", Offset = "0x4E971C0", VA = "0x184E981C0", Slot = "4")]
	public override PAEGLKIGDFP ODIGKBLPPJN()
	{
		return default(PAEGLKIGDFP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class KMALOCLDJIF<TGroup, TData> : FMPIOAEEIGI<DEFIEPAOIJN<TGroup, TData>, PAEGLKIGDFP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly OJMFFAMEAPM<TGroup, TData> GJOMAKELDOD;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x38A6930", Offset = "0x38A5930", VA = "0x1838A6930")]
	public KMALOCLDJIF(TGroup GAEPCLPMAEJ, TData DFAMOOJLAFN, IEnumerable<TData> JMIAMLFMLAO, DEFIEPAOIJN<TGroup, TData> PPGNDOHCHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x424E080", Offset = "0x424D080", VA = "0x18424E080", Slot = "4")]
	public override PAEGLKIGDFP ODIGKBLPPJN()
	{
		return default(PAEGLKIGDFP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class MAODNMGAJCG<TGroup, TData> : FMPIOAEEIGI<DEFIEPAOIJN<TGroup, TData>, PAEGLKIGDFP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly KFMNGAMCFOE<TGroup> GJOMAKELDOD;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x44CD990", Offset = "0x44CC990", VA = "0x1844CD990")]
	public MAODNMGAJCG(TGroup GAEPCLPMAEJ, DEFIEPAOIJN<TGroup, TData> PPGNDOHCHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x44CD8D0", Offset = "0x44CC8D0", VA = "0x1844CD8D0", Slot = "4")]
	public override PAEGLKIGDFP ODIGKBLPPJN()
	{
		return default(PAEGLKIGDFP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class EKEFJDDHICB<TGroup, TData> : FMPIOAEEIGI<DEFIEPAOIJN<TGroup, TData>, PAEGLKIGDFP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly OJMFFAMEAPM<TGroup, TData> GJOMAKELDOD;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x38A6930", Offset = "0x38A5930", VA = "0x1838A6930")]
	public EKEFJDDHICB(TGroup GAEPCLPMAEJ, TData JIHJACOEFNG, IEnumerable<TData> JMIAMLFMLAO, DEFIEPAOIJN<TGroup, TData> PPGNDOHCHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x38A6850", Offset = "0x38A5850", VA = "0x1838A6850", Slot = "4")]
	public override PAEGLKIGDFP ODIGKBLPPJN()
	{
		return default(PAEGLKIGDFP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class CDPCIJEJHIE<TData> : GACOMIAJODA<BOCINCEGDGJ<TData>, PAEGLKIGDFP> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private struct ILBLILOCJOO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AsyncTaskMethodBuilder<PAEGLKIGDFP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public CDPCIJEJHIE<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private TaskAwaiter<PAEGLKIGDFP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x3F45B10", Offset = "0x3F44B10", VA = "0x183F45B10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3F45DB0", Offset = "0x3F44DB0", VA = "0x183F45DB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private JLNEJKKHGPK<TData> GJOMAKELDOD;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x44CD990", Offset = "0x44CC990", VA = "0x1844CD990")]
	public CDPCIJEJHIE(IEnumerable<TData> HOKJCLDLDBH, BOCINCEGDGJ<TData> PPGNDOHCHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x51936C0", Offset = "0x51926C0", VA = "0x1851936C0", Slot = "4")]
	[AsyncStateMachine(typeof(CDPCIJEJHIE<>.ILBLILOCJOO))]
	public override Task<PAEGLKIGDFP> ODIGKBLPPJN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct BIKCIBPKFKP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly HONHJBMHFML KALHFLKLLHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly bool JHFNCCPBMEE;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x69BBA00", Offset = "0x69BAA00", VA = "0x1869BBA00")]
	public BIKCIBPKFKP(HONHJBMHFML KEICJNNJJEL, bool KCLJGENDFBO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface NLGCOBOLFEC<TSpawnType> where TSpawnType : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> ODIGKBLPPJN(BIKCIBPKFKP JGALJOBCCGO);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class ODPABFDDALO<TSpawnType> : GACOMIAJODA<NLGCOBOLFEC<TSpawnType>, TSpawnType> where TSpawnType : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private struct EEHIDFGJHJH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public AsyncTaskMethodBuilder<TSpawnType> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public ODPABFDDALO<TSpawnType> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskAwaiter<TSpawnType> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x388EB10", Offset = "0x388DB10", VA = "0x18388EB10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x388F290", Offset = "0x388E290", VA = "0x18388F290", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly BIKCIBPKFKP JGALJOBCCGO;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x46DD5C0", Offset = "0x46DC5C0", VA = "0x1846DD5C0")]
	public ODPABFDDALO(HONHJBMHFML KEICJNNJJEL, bool KCLJGENDFBO, NLGCOBOLFEC<TSpawnType> PPGNDOHCHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x46DD3C0", Offset = "0x46DC3C0", VA = "0x1846DD3C0", Slot = "4")]
	[AsyncStateMachine(typeof(ODPABFDDALO<>.EEHIDFGJHJH))]
	public override Task<TSpawnType> ODIGKBLPPJN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public readonly struct HONHJBMHFML
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly bool MDKAMCDJPMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly Vector3 IAPOJLIJOAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly Vector3 ANCEDMGEKMM;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x69BBF70", Offset = "0x69BAF70", VA = "0x1869BBF70")]
	public HONHJBMHFML(Transform ODDLIICBELA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x69BBFE0", Offset = "0x69BAFE0", VA = "0x1869BBFE0")]
	public HONHJBMHFML(Vector3 NJOPFIOMLFB, Vector3 LLLHNMGEKPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x69BBEB0", Offset = "0x69BAEB0", VA = "0x1869BBEB0")]
	public static HONHJBMHFML DMJCFLNALOI()
	{
		return default(HONHJBMHFML);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x69BBEE0", Offset = "0x69BAEE0", VA = "0x1869BBEE0")]
	private HONHJBMHFML(bool HPMAMJNCCHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct HMNMOAAPEMI<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public TNode MOJHMEFLENF;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3DEDEB0", Offset = "0x3DECEB0", VA = "0x183DEDEB0")]
	public HMNMOAAPEMI(TNode MOJHMEFLENF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct DLLNLLAOHPA<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public TNode KHGGBBOLJHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NAKBEGIPIDJ FBPDEGJBBDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly bool JHFNCCPBMEE;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5877980", Offset = "0x5876980", VA = "0x185877980")]
	public DLLNLLAOHPA(TNode KHGGBBOLJHM, NAKBEGIPIDJ FBPDEGJBBDE, bool KCLJGENDFBO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface DEEPOBGHMJD<TNode>
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KAENBBLCMAG([In] HMNMOAAPEMI<TNode> MIKILJHGJKC);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GAGJFFIAJGC([In] DLLNLLAOHPA<TNode> EGIOAANFBKM);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CHENAFPJKOI();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class GPKNBIHKAHL<TNode> : IDIFDLEKLHF<DEEPOBGHMJD<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3C0FBB0", Offset = "0x3C0EBB0", VA = "0x183C0FBB0")]
	public GPKNBIHKAHL(DEEPOBGHMJD<TNode> PPGNDOHCHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3D996D0", Offset = "0x3D986D0", VA = "0x183D996D0", Slot = "4")]
	public override bool ODIGKBLPPJN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class OMLMIEGLPNB<TNode> : IDIFDLEKLHF<DEEPOBGHMJD<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly DLLNLLAOHPA<TNode> EGIOAANFBKM;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x46F9380", Offset = "0x46F8380", VA = "0x1846F9380")]
	public OMLMIEGLPNB(TNode KHGGBBOLJHM, NAKBEGIPIDJ FBPDEGJBBDE, DEEPOBGHMJD<TNode> PPGNDOHCHFE, bool KCLJGENDFBO = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3D6E050", Offset = "0x3D6D050", VA = "0x183D6E050", Slot = "4")]
	public override bool ODIGKBLPPJN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class ENBMHHKKCJH<TNode> : IDIFDLEKLHF<DEEPOBGHMJD<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly HMNMOAAPEMI<TNode> MIKILJHGJKC;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x38AE030", Offset = "0x38AD030", VA = "0x1838AE030")]
	public ENBMHHKKCJH(TNode CHNKBDKJOCJ, DEEPOBGHMJD<TNode> PPGNDOHCHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x38ADF70", Offset = "0x38ACF70", VA = "0x1838ADF70", Slot = "4")]
	public override bool ODIGKBLPPJN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct FJGFALABNJC<TSpawnInfo> where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public TSpawnInfo CJOKNODFKLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public Vector3 LLLHNMGEKPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Quaternion BCKIPOGEHOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public float FHBDGLOPEKN;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3C40C20", Offset = "0x3C3FC20", VA = "0x183C40C20")]
	public FJGFALABNJC(TSpawnInfo CJOKNODFKLF, Vector3 LLLHNMGEKPM, Quaternion BCKIPOGEHOJ, float FHBDGLOPEKN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface KBHEOOBNDBG<TSpawnType, TSpawnInfo>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> DDHBBOLIMIE([In] FJGFALABNJC<TSpawnInfo> LEICPGBPHFE, CancellationToken LABHBAHABKB);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class EHOPHNIHPPC<TSpawnType, TSpawnInfo> : GACOMIAJODA<KBHEOOBNDBG<TSpawnType, TSpawnInfo>, TSpawnType> where TSpawnType : notnull where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly FJGFALABNJC<TSpawnInfo> DJNIHGJAOCO;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x389C920", Offset = "0x389B920", VA = "0x18389C920")]
	public EHOPHNIHPPC(TSpawnInfo DLNKLOFJDCK, Vector3 LLLHNMGEKPM, Quaternion BCKIPOGEHOJ, float FHBDGLOPEKN, KBHEOOBNDBG<TSpawnType, TSpawnInfo> PPGNDOHCHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x389C720", Offset = "0x389B720", VA = "0x18389C720", Slot = "4")]
	public override Task<TSpawnType> ODIGKBLPPJN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct NDPCJJHAICO<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly IEnumerable<TData> MCFCDCEFPIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly bool JHFNCCPBMEE;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x45D9D80", Offset = "0x45D8D80", VA = "0x1845D9D80")]
	public NDPCJJHAICO(IEnumerable<TData> JMIAMLFMLAO, bool KCLJGENDFBO = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface AHPADFOMFDH<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<PAEGLKIGDFP> DEFDILNJDNH([In] NDPCJJHAICO<TData> HDKBOPLNDCC, CancellationToken LABHBAHABKB);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class NGAEKJFGOOM<TData> : GACOMIAJODA<AHPADFOMFDH<TData>, PAEGLKIGDFP> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly NDPCJJHAICO<TData> PFFLLDJOLKI;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x45E2F60", Offset = "0x45E1F60", VA = "0x1845E2F60")]
	public NGAEKJFGOOM(IEnumerable<TData> JMIAMLFMLAO, bool KCLJGENDFBO, AHPADFOMFDH<TData> PPGNDOHCHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x389C720", Offset = "0x389B720", VA = "0x18389C720", Slot = "4")]
	public override Task<PAEGLKIGDFP> ODIGKBLPPJN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct AEIIHPMMNJN<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public readonly T KAEDHDLBKFF;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x3D02850", Offset = "0x3D01850", VA = "0x183D02850")]
	public AEIIHPMMNJN(T LPLKJOKLABD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface HMOJLHMELPH<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KAENBBLCMAG([In] AEIIHPMMNJN<T> DGOMLIGKFPL);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GAGJFFIAJGC();
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface EHGDMDNKPPE<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ODIGKBLPPJN([In] NGJCBFOCICM<T> IJNLDKEFKND);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct NGJCBFOCICM<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public readonly T KAEDHDLBKFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public readonly bool DMACHEPENEB;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x45E3450", Offset = "0x45E2450", VA = "0x1845E3450")]
	public NGJCBFOCICM(T LPLKJOKLABD, bool HNJDKPMKAJE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class HCNMGLJKGCD<T> : IDIFDLEKLHF<HMOJLHMELPH<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x3C0FBB0", Offset = "0x3C0EBB0", VA = "0x183C0FBB0")]
	public HCNMGLJKGCD(HMOJLHMELPH<T> PPGNDOHCHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x3DC36A0", Offset = "0x3DC26A0", VA = "0x183DC36A0", Slot = "4")]
	public override bool ODIGKBLPPJN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class DGGCDLFLLEG<T> : IDIFDLEKLHF<HMOJLHMELPH<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly AEIIHPMMNJN<T> DGOMLIGKFPL;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5834640", Offset = "0x5833640", VA = "0x185834640")]
	public DGGCDLFLLEG(T KAEDHDLBKFF, HMOJLHMELPH<T> PPGNDOHCHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x38ADF70", Offset = "0x38ACF70", VA = "0x1838ADF70", Slot = "4")]
	public override bool ODIGKBLPPJN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class CDOGHHOMPFL<T> : IDIFDLEKLHF<EHGDMDNKPPE<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly NGJCBFOCICM<T> IJNLDKEFKND;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5193620", Offset = "0x5192620", VA = "0x185193620")]
	public CDOGHHOMPFL(T KAEDHDLBKFF, bool HNJDKPMKAJE, EHGDMDNKPPE<T> PPGNDOHCHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x38ADF70", Offset = "0x38ACF70", VA = "0x1838ADF70", Slot = "4")]
	public override bool ODIGKBLPPJN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct GDPEFIDHKKB<TData> where TData : notnull, CMHKBDLCDPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public IEnumerable<TData> MCFCDCEFPIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public bool ICDGPBBCFIF;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x3D569A0", Offset = "0x3D559A0", VA = "0x183D569A0")]
	public GDPEFIDHKKB(IEnumerable<TData> FEKEEJPJLBM, bool GFAOGDJLHMF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct OFMHCFMMCJD<TData> where TData : notnull, CMHKBDLCDPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public List<TData> MCFCDCEFPIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public List<bool> PCPHFHAFEOD;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x46E45A0", Offset = "0x46E35A0", VA = "0x1846E45A0")]
	public OFMHCFMMCJD(List<TData> FEKEEJPJLBM, List<bool> LDPCIJPGCED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface CMHKBDLCDPM
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool OALNAHANAAF
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
public interface DAABECFIOCB<TData> where TData : CMHKBDLCDPM
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ODIGKBLPPJN([In] GDPEFIDHKKB<TData> ELCPIPCGPMG);

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ODIGKBLPPJN([In] OFMHCFMMCJD<TData> ELCPIPCGPMG);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface AOLCJNNPHJI<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NODPFPHAMHK(T KAEDHDLBKFF);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class IMPCIJAGKIF<TData> : IDIFDLEKLHF<DAABECFIOCB<TData>> where TData : notnull, CMHKBDLCDPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly GDPEFIDHKKB<TData> ELCPIPCGPMG;

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x3F491C0", Offset = "0x3F481C0", VA = "0x183F491C0")]
	public IMPCIJAGKIF(List<TData> JMIAMLFMLAO, bool ICDGPBBCFIF, DAABECFIOCB<TData> PPGNDOHCHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x38ADF70", Offset = "0x38ACF70", VA = "0x1838ADF70", Slot = "4")]
	public override bool ODIGKBLPPJN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class EGNDLKBICJH<TData> : IDIFDLEKLHF<DAABECFIOCB<TData>> where TData : notnull, CMHKBDLCDPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly OFMHCFMMCJD<TData> ELCPIPCGPMG;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x3899A80", Offset = "0x3898A80", VA = "0x183899A80")]
	public EGNDLKBICJH(List<TData> JMIAMLFMLAO, List<bool> PCPHFHAFEOD, DAABECFIOCB<TData> PPGNDOHCHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x38999C0", Offset = "0x38989C0", VA = "0x1838999C0", Slot = "4")]
	public override bool ODIGKBLPPJN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface FDCMOCAMOOJ<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<PAEGLKIGDFP> ODIGKBLPPJN(JEILKHPDILI<TData> BNCGDGOMMGJ);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public class BDPBECJBPLK<TData> : GACOMIAJODA<FDCMOCAMOOJ<TData>, PAEGLKIGDFP> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct GAFFPOIBOLK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public AsyncTaskMethodBuilder<PAEGLKIGDFP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public BDPBECJBPLK<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter<PAEGLKIGDFP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x3D32D80", Offset = "0x3D31D80", VA = "0x183D32D80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x3D33060", Offset = "0x3D32060", VA = "0x183D33060", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly JEILKHPDILI<TData> POKDFMOOFOF;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x4E74BE0", Offset = "0x4E73BE0", VA = "0x184E74BE0")]
	public BDPBECJBPLK(TData AHLKPKHEMEN, IReadOnlyList<TData> INGOCJLNAGD, bool KCLJGENDFBO, FDCMOCAMOOJ<TData> PPGNDOHCHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x4E74AE0", Offset = "0x4E73AE0", VA = "0x184E74AE0", Slot = "4")]
	[AsyncStateMachine(typeof(BDPBECJBPLK<>.GAFFPOIBOLK))]
	public override Task<PAEGLKIGDFP> ODIGKBLPPJN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public struct JEILKHPDILI<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public TData LCKJLFHHMDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public IReadOnlyList<TData> HDGFIALIDLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public bool JHFNCCPBMEE;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x410AF40", Offset = "0x4109F40", VA = "0x18410AF40")]
	public JEILKHPDILI(TData AHLKPKHEMEN, IReadOnlyList<TData> INGOCJLNAGD, bool KCLJGENDFBO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface BKFBKOJKINF<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ODIGKBLPPJN([In] KJBMIGIMOIN<TData> FCFHOJBCNJN);
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface COJIKHJLEIJ<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ODIGKBLPPJN([In] OGFNCPNNMNA<TData> FCFHOJBCNJN);
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface APGMFFCKAFA<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HBAECOJLMFN([In] KGADJFADMFA<TData> FCFHOJBCNJN);

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GAGJFFIAJGC();
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class OBKABOPMJAH<TData> : IDIFDLEKLHF<BKFBKOJKINF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly KJBMIGIMOIN<TData> FCFHOJBCNJN;

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x46D7D90", Offset = "0x46D6D90", VA = "0x1846D7D90")]
	public OBKABOPMJAH(IEnumerable<TData> JMIAMLFMLAO, LCHJIFIKODO NHCEIDKGILJ, INGECIAEFAG JNFDDANGPCP, float MKLAMMDOMAL, bool KCLJGENDFBO, BKFBKOJKINF<TData> PPGNDOHCHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x38ADF70", Offset = "0x38ACF70", VA = "0x1838ADF70", Slot = "4")]
	public override bool ODIGKBLPPJN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class NHOELMLMMON<TData> : IDIFDLEKLHF<COJIKHJLEIJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly OGFNCPNNMNA<TData> FCFHOJBCNJN;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x45E62B0", Offset = "0x45E52B0", VA = "0x1845E62B0")]
	public NHOELMLMMON(TData[] JMIAMLFMLAO, LCHJIFIKODO[] NHCEIDKGILJ, INGECIAEFAG[] JNFDDANGPCP, float[] MKLAMMDOMAL, COJIKHJLEIJ<TData> PPGNDOHCHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x45E61F0", Offset = "0x45E51F0", VA = "0x1845E61F0", Slot = "4")]
	public override bool ODIGKBLPPJN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class LONIKMPNMNC<TData> : IDIFDLEKLHF<APGMFFCKAFA<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3C0FBB0", Offset = "0x3C0EBB0", VA = "0x183C0FBB0")]
	public LONIKMPNMNC(APGMFFCKAFA<TData> PPGNDOHCHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x4312CD0", Offset = "0x4311CD0", VA = "0x184312CD0", Slot = "4")]
	public override bool ODIGKBLPPJN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class DOGDHFGFMNB<TData> : IDIFDLEKLHF<APGMFFCKAFA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly KGADJFADMFA<TData> FCFHOJBCNJN;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5898E80", Offset = "0x5897E80", VA = "0x185898E80")]
	public DOGDHFGFMNB(IEnumerable<TData> JMIAMLFMLAO, LCHJIFIKODO NHCEIDKGILJ, INGECIAEFAG JNFDDANGPCP, float MKLAMMDOMAL, APGMFFCKAFA<TData> PPGNDOHCHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x45E61F0", Offset = "0x45E51F0", VA = "0x1845E61F0", Slot = "4")]
	public override bool ODIGKBLPPJN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public struct KJBMIGIMOIN<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public IEnumerable<TData> MCFCDCEFPIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public LCHJIFIKODO JCCNEGPADMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public INGECIAEFAG DKEDIIKAFLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public float MKLAMMDOMAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public bool KCLJGENDFBO;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4241EE0", Offset = "0x4240EE0", VA = "0x184241EE0")]
	public KJBMIGIMOIN(IEnumerable<TData> JMIAMLFMLAO, LCHJIFIKODO NHCEIDKGILJ, INGECIAEFAG JNFDDANGPCP, float MKLAMMDOMAL, bool KCLJGENDFBO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct OGFNCPNNMNA<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public TData[] MCFCDCEFPIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public LCHJIFIKODO[] JCCNEGPADMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public INGECIAEFAG[] DKEDIIKAFLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public float[] MKLAMMDOMAL;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x46E9500", Offset = "0x46E8500", VA = "0x1846E9500")]
	public OGFNCPNNMNA(TData[] JMIAMLFMLAO, LCHJIFIKODO[] NHCEIDKGILJ, INGECIAEFAG[] JNFDDANGPCP, float[] MKLAMMDOMAL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public struct KGADJFADMFA<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public IEnumerable<TData> MCFCDCEFPIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public LCHJIFIKODO JCCNEGPADMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public INGECIAEFAG DKEDIIKAFLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public float MKLAMMDOMAL;

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x41CAF40", Offset = "0x41C9F40", VA = "0x1841CAF40")]
	public KGADJFADMFA(IEnumerable<TData> JMIAMLFMLAO, LCHJIFIKODO NHCEIDKGILJ, INGECIAEFAG JNFDDANGPCP, float MKLAMMDOMAL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public interface NGJBKGBAAPC<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CMCCLKCIDLH([In] NODELCMPBPJ<TData> HDKBOPLNDCC);

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LBBLEHINHMC([In] NODELCMPBPJ<TData> HDKBOPLNDCC);

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GGGLKJCKHFH([In] bool BMGOLFHNIHE);

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CBLHHPIKDAL([In] NODELCMPBPJ<TData> HDKBOPLNDCC);

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LCOICMBJJMK();

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool NFNEEAPEMOK([In] TData IDOGGEEJGOC);
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class NNNEBLFOKHG<TData> : IDIFDLEKLHF<NGJBKGBAAPC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly NODELCMPBPJ<TData> HDKBOPLNDCC;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x46038F0", Offset = "0x46028F0", VA = "0x1846038F0")]
	public NNNEBLFOKHG(List<TData> AFNCAAOMPCK, NGJBKGBAAPC<TData> PPGNDOHCHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x38ADF70", Offset = "0x38ACF70", VA = "0x1838ADF70", Slot = "4")]
	public override bool ODIGKBLPPJN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class BCPEDPMEMHC<TData> : IDIFDLEKLHF<NGJBKGBAAPC<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3C0FBB0", Offset = "0x3C0EBB0", VA = "0x183C0FBB0")]
	public BCPEDPMEMHC(NGJBKGBAAPC<TData> PPGNDOHCHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x4E73D70", Offset = "0x4E72D70", VA = "0x184E73D70", Slot = "4")]
	public override bool ODIGKBLPPJN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class AMFBHIEEJCK<TData> : IDIFDLEKLHF<NGJBKGBAAPC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly bool KCLJGENDFBO;

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3E28490", Offset = "0x3E27490", VA = "0x183E28490")]
	public AMFBHIEEJCK(bool KCLJGENDFBO, NGJBKGBAAPC<TData> PPGNDOHCHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3E28430", Offset = "0x3E27430", VA = "0x183E28430", Slot = "4")]
	public override bool ODIGKBLPPJN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class FMMMECEIHNB<TData> : IDIFDLEKLHF<NGJBKGBAAPC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly NODELCMPBPJ<TData> HDKBOPLNDCC;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3C8AED0", Offset = "0x3C89ED0", VA = "0x183C8AED0")]
	public FMMMECEIHNB(List<TData> AFNCAAOMPCK, bool KCLJGENDFBO, NGJBKGBAAPC<TData> PPGNDOHCHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x38999C0", Offset = "0x38989C0", VA = "0x1838999C0", Slot = "4")]
	public override bool ODIGKBLPPJN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class ENGNPHJEJBN<TData> : IDIFDLEKLHF<NGJBKGBAAPC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly TData IDOGGEEJGOC;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x38AFC80", Offset = "0x38AEC80", VA = "0x1838AFC80")]
	public ENGNPHJEJBN(TData IDOGGEEJGOC, NGJBKGBAAPC<TData> PPGNDOHCHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x38AFB10", Offset = "0x38AEB10", VA = "0x1838AFB10", Slot = "4")]
	public override bool ODIGKBLPPJN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class AFIDCADOKMG<TData> : IDIFDLEKLHF<NGJBKGBAAPC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly NODELCMPBPJ<TData> HDKBOPLNDCC;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3D05250", Offset = "0x3D04250", VA = "0x183D05250")]
	public AFIDCADOKMG(IEnumerable<TData> AFNCAAOMPCK, NGJBKGBAAPC<TData> PPGNDOHCHFE, bool KCLJGENDFBO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x3D05190", Offset = "0x3D04190", VA = "0x183D05190", Slot = "4")]
	public override bool ODIGKBLPPJN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public struct NODELCMPBPJ<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public IEnumerable<TData> MCFCDCEFPIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public bool KCLJGENDFBO;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x4603D40", Offset = "0x4602D40", VA = "0x184603D40")]
	public NODELCMPBPJ(IEnumerable<TData> FEKEEJPJLBM, bool GHINPIMBNKN = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public interface ENJAJDCMBCO
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<PAEGLKIGDFP> ODIGKBLPPJN(FGIFFJHJEEP KFBONKMPDJB);
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class IALIJAEAOPG : GACOMIAJODA<ENJAJDCMBCO, PAEGLKIGDFP>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private struct KKFFDGELCJC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public AsyncTaskMethodBuilder<PAEGLKIGDFP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public IALIJAEAOPG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private TaskAwaiter<PAEGLKIGDFP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x69BC530", Offset = "0x69BB530", VA = "0x1869BC530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x69BC7B0", Offset = "0x69BB7B0", VA = "0x1869BC7B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly FGIFFJHJEEP GDKPEDIKIGE;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x69BC100", Offset = "0x69BB100", VA = "0x1869BC100")]
	public IALIJAEAOPG(bool KCLJGENDFBO, ENJAJDCMBCO PPGNDOHCHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x69BC010", Offset = "0x69BB010", VA = "0x1869BC010", Slot = "4")]
	[AsyncStateMachine(typeof(KKFFDGELCJC))]
	public override Task<PAEGLKIGDFP> ODIGKBLPPJN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct FGIFFJHJEEP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public bool JHFNCCPBMEE;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x21BB7E0", Offset = "0x21BA7E0", VA = "0x1821BB7E0")]
	public FGIFFJHJEEP(bool KCLJGENDFBO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public readonly struct EHGKJCAMIOL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly bool HINIPMFJOBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly bool KNJPJKJDGBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public readonly bool FHBDGLOPEKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public readonly bool KCLJGENDFBO;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4D0BC10", Offset = "0x4D0AC10", VA = "0x184D0BC10")]
	public EHGKJCAMIOL(bool HINIPMFJOBM, bool KNJPJKJDGBL, bool FHBDGLOPEKN, bool KCLJGENDFBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x69BBD90", Offset = "0x69BAD90", VA = "0x1869BBD90")]
	public EHGKJCAMIOL(bool KNJPJKJDGBL, bool KCLJGENDFBO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface DFHKBMEICAL
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AHKIJPAMMGC(EHGKJCAMIOL ADMCLBHJAGO);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LKBGJGJHHCH(EHGKJCAMIOL ADMCLBHJAGO);
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class BJLMHDMDEPK : IDIFDLEKLHF<DFHKBMEICAL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly EHGKJCAMIOL ADMCLBHJAGO;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x69BBA70", Offset = "0x69BAA70", VA = "0x1869BBA70")]
	public BJLMHDMDEPK(bool DBCCBLKNBHK, bool KNJPJKJDGBL, bool FHBDGLOPEKN, bool KCLJGENDFBO, DFHKBMEICAL PPGNDOHCHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x69BBA20", Offset = "0x69BAA20", VA = "0x1869BBA20", Slot = "4")]
	public override bool ODIGKBLPPJN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class GNLAIICGLHE : IDIFDLEKLHF<DFHKBMEICAL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly EHGKJCAMIOL ADMCLBHJAGO;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x69BBDF0", Offset = "0x69BADF0", VA = "0x1869BBDF0")]
	public GNLAIICGLHE(bool KNJPJKJDGBL, bool KCLJGENDFBO, DFHKBMEICAL PPGNDOHCHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x69BBDA0", Offset = "0x69BADA0", VA = "0x1869BBDA0", Slot = "4")]
	public override bool ODIGKBLPPJN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public interface GHMLIIKAIIH
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ODIGKBLPPJN([In] NBHMECJIMHN PCDBDKHELDF);
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class CHNBPJKNKMD : IDIFDLEKLHF<GHMLIIKAIIH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly NBHMECJIMHN PCDBDKHELDF;

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x69BBBB0", Offset = "0x69BABB0", VA = "0x1869BBBB0")]
	public CHNBPJKNKMD(Guid[] KENHJFPCMDC, Vector3[] LEBPBJGJDOD, Quaternion[] NBIEDIHKICE, float[] AHFDBCFDDLG, Dictionary<Guid, Vector3> OFMDMAHLOKB, GHMLIIKAIIH PPGNDOHCHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x69BBB00", Offset = "0x69BAB00", VA = "0x1869BBB00", Slot = "4")]
	public override bool ODIGKBLPPJN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public interface LINONIIOMGL<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KAENBBLCMAG([In] MLAHNOCAKAC<TData> MIKILJHGJKC);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HBAECOJLMFN([In] KKHLNEJLJAC PDIIGKAKKPG);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HBAECOJLMFN([In] KKGDFPCLIEL PDIIGKAKKPG);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool GAGJFFIAJGC();
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class KDMMPAOJIFI<TData> : IDIFDLEKLHF<LINONIIOMGL<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x3C0FBB0", Offset = "0x3C0EBB0", VA = "0x183C0FBB0")]
	public KDMMPAOJIFI(LINONIIOMGL<TData> PPGNDOHCHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x41C0F00", Offset = "0x41BFF00", VA = "0x1841C0F00", Slot = "4")]
	public override bool ODIGKBLPPJN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class DGAHBPKKAHF<TData> : IDIFDLEKLHF<LINONIIOMGL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly KKHLNEJLJAC CJLPICODGBD;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5834240", Offset = "0x5833240", VA = "0x185834240")]
	public DGAHBPKKAHF(Vector3 CNBGNFPCNBK, bool PAKJBDCIBIP, LINONIIOMGL<TData> PPGNDOHCHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x4116AA0", Offset = "0x4115AA0", VA = "0x184116AA0", Slot = "4")]
	public override bool ODIGKBLPPJN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class OBMEGPBCGFL<TData> : IDIFDLEKLHF<LINONIIOMGL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly KKGDFPCLIEL CJLPICODGBD;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x46D7EE0", Offset = "0x46D6EE0", VA = "0x1846D7EE0")]
	public OBMEGPBCGFL(Guid OEDFLLHHPOC, int HCALFJOJKJO, Vector3 LLLHNMGEKPM, Quaternion BCKIPOGEHOJ, float EGNBICILIGE, bool PAKJBDCIBIP, LINONIIOMGL<TData> PPGNDOHCHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x46D7E80", Offset = "0x46D6E80", VA = "0x1846D7E80", Slot = "4")]
	public override bool ODIGKBLPPJN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class EOKDMFGHNKD<TData> : IDIFDLEKLHF<LINONIIOMGL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly MLAHNOCAKAC<TData> CJLPICODGBD;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x38B6FA0", Offset = "0x38B5FA0", VA = "0x1838B6FA0")]
	public EOKDMFGHNKD(TData KAEDHDLBKFF, bool KCLJGENDFBO, LINONIIOMGL<TData> PPGNDOHCHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x38ADF70", Offset = "0x38ACF70", VA = "0x1838ADF70", Slot = "4")]
	public override bool ODIGKBLPPJN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public struct KKHLNEJLJAC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly Vector3 CNBGNFPCNBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public readonly bool PAKJBDCIBIP;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x69BC860", Offset = "0x69BB860", VA = "0x1869BC860")]
	public KKHLNEJLJAC(Vector3 CNBGNFPCNBK, bool PAKJBDCIBIP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public struct KKGDFPCLIEL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public readonly Guid OEDFLLHHPOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public readonly int HCALFJOJKJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public readonly Vector3 LLLHNMGEKPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public readonly Quaternion BCKIPOGEHOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public readonly float EGNBICILIGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public readonly bool PAKJBDCIBIP;

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x69BC820", Offset = "0x69BB820", VA = "0x1869BC820")]
	public KKGDFPCLIEL(Guid OEDFLLHHPOC, int HCALFJOJKJO, Vector3 LLLHNMGEKPM, Quaternion BCKIPOGEHOJ, float EGNBICILIGE, bool PAKJBDCIBIP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public struct MLAHNOCAKAC<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public readonly TData KAEDHDLBKFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public readonly bool KCLJGENDFBO;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x45024A0", Offset = "0x45014A0", VA = "0x1845024A0")]
	public MLAHNOCAKAC(TData KAEDHDLBKFF, bool KCLJGENDFBO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public interface PAHIGKEPGHG<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ODIGKBLPPJN([In] OKCBKAAHEOP<TData> EBGOHCMAMNE);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool ODIGKBLPPJN([In] IMMPPNFEGFD<TData> EBGOHCMAMNE);
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public interface FNMPKDMLONH<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KAENBBLCMAG([In] GNDGNEGOCLP<TData> CNGMCCLOIPP);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HBAECOJLMFN([In] HNPIMJGAHHH PDIIGKAKKPG);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GAGJFFIAJGC();
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class IIHCHCJDKKG<TData> : IDIFDLEKLHF<PAHIGKEPGHG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly OKCBKAAHEOP<TData> EBGOHCMAMNE;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x3F3B020", Offset = "0x3F3A020", VA = "0x183F3B020")]
	public IIHCHCJDKKG(IEnumerable<TData> JMIAMLFMLAO, Vector3 BHHADNDKDEN, bool KCLJGENDFBO, PAHIGKEPGHG<TData> PPGNDOHCHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x38ADF70", Offset = "0x38ACF70", VA = "0x1838ADF70", Slot = "4")]
	public override bool ODIGKBLPPJN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class ODFKJCBCELH<TData> : IDIFDLEKLHF<FNMPKDMLONH<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x3C0FBB0", Offset = "0x3C0EBB0", VA = "0x183C0FBB0")]
	public ODFKJCBCELH(FNMPKDMLONH<TData> PPGNDOHCHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x3D996D0", Offset = "0x3D986D0", VA = "0x183D996D0", Slot = "4")]
	public override bool ODIGKBLPPJN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class PMLPBHPBGFE<TData> : IDIFDLEKLHF<FNMPKDMLONH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly GNDGNEGOCLP<TData> EBGOHCMAMNE;

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x47AF060", Offset = "0x47AE060", VA = "0x1847AF060")]
	public PMLPBHPBGFE(IEnumerable<TData> JMIAMLFMLAO, bool KCLJGENDFBO, FNMPKDMLONH<TData> PPGNDOHCHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x38ADF70", Offset = "0x38ACF70", VA = "0x1838ADF70", Slot = "4")]
	public override bool ODIGKBLPPJN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class DJHFHCFICLD<TData> : IDIFDLEKLHF<PAHIGKEPGHG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly IMMPPNFEGFD<TData> EBGOHCMAMNE;

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x58729B0", Offset = "0x58719B0", VA = "0x1858729B0")]
	public DJHFHCFICLD(IEnumerable<TData> JMIAMLFMLAO, Vector3 EABLANCICGB, IBAACLNGJHP KMNGJNAANEG, bool KCLJGENDFBO, PAHIGKEPGHG<TData> PPGNDOHCHFE, Space KIPDPNGFPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3D6E050", Offset = "0x3D6D050", VA = "0x183D6E050", Slot = "4")]
	public override bool ODIGKBLPPJN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class OGDJHCPLPDN<TData> : IDIFDLEKLHF<FNMPKDMLONH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly HNPIMJGAHHH EBGOHCMAMNE;

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x46E82E0", Offset = "0x46E72E0", VA = "0x1846E82E0")]
	public OGDJHCPLPDN(Vector3 BHHADNDKDEN, FNMPKDMLONH<TData> PPGNDOHCHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x4116AA0", Offset = "0x4115AA0", VA = "0x184116AA0", Slot = "4")]
	public override bool ODIGKBLPPJN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct OKCBKAAHEOP<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public readonly IEnumerable<TData> JMIAMLFMLAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public readonly Vector3 BHHADNDKDEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public readonly bool KCLJGENDFBO;

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x46F5FD0", Offset = "0x46F4FD0", VA = "0x1846F5FD0")]
	public OKCBKAAHEOP(IEnumerable<TData> JMIAMLFMLAO, Vector3 BHHADNDKDEN, bool KCLJGENDFBO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct GNDGNEGOCLP<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public readonly IEnumerable<TData> JMIAMLFMLAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public readonly bool KCLJGENDFBO;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x3D93860", Offset = "0x3D92860", VA = "0x183D93860")]
	public GNDGNEGOCLP(IEnumerable<TData> JMIAMLFMLAO, bool KCLJGENDFBO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct IMMPPNFEGFD<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public readonly IEnumerable<TData> JMIAMLFMLAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public readonly Vector3 EABLANCICGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly IBAACLNGJHP KMNGJNAANEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public readonly bool KCLJGENDFBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly Space KIPDPNGFPAE;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x3F48F00", Offset = "0x3F47F00", VA = "0x183F48F00")]
	public IMMPPNFEGFD(IEnumerable<TData> JMIAMLFMLAO, Vector3 EABLANCICGB, IBAACLNGJHP KMNGJNAANEG, bool KCLJGENDFBO, Space KIPDPNGFPAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct HNPIMJGAHHH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public readonly Vector3 BHHADNDKDEN;

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x21BCB90", Offset = "0x21BBB90", VA = "0x1821BCB90")]
	public HNPIMJGAHHH(Vector3 BHHADNDKDEN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public enum IBAACLNGJHP
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
public interface NEPBFENCFMB
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ODIGKBLPPJN([In] IOCPIIOBBID JJKDMNFFMNF);
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public class MHGLBOKDAPO : IDIFDLEKLHF<NEPBFENCFMB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly IOCPIIOBBID JJKDMNFFMNF;

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x69BC930", Offset = "0x69BB930", VA = "0x1869BC930")]
	public MHGLBOKDAPO(bool KCLJGENDFBO, NEPBFENCFMB PPGNDOHCHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x69BC880", Offset = "0x69BB880", VA = "0x1869BC880", Slot = "4")]
	public override bool ODIGKBLPPJN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public readonly struct IOCPIIOBBID
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public readonly bool KCLJGENDFBO;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x21BB7E0", Offset = "0x21BA7E0", VA = "0x1821BB7E0")]
	public IOCPIIOBBID(bool KCLJGENDFBO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public interface GEKOKGFDPOL<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ODIGKBLPPJN([In] FJLHDHKBCCE<TData> HBDNIMPPJIO);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool ODIGKBLPPJN([In] OLFAEDHKDLF<TData> HBDNIMPPJIO);
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public interface JEBLILLEKBA<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KAENBBLCMAG([In] HMCDICLJEPE<TData> MIKILJHGJKC);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HBAECOJLMFN([In] HMHLEACJJDD PDIIGKAKKPG);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GAGJFFIAJGC();
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class PEFHDGKAGCP<TData> : IDIFDLEKLHF<GEKOKGFDPOL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly FJLHDHKBCCE<TData> HBDNIMPPJIO;

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x47A2770", Offset = "0x47A1770", VA = "0x1847A2770")]
	public PEFHDGKAGCP(IEnumerable<TData> JMIAMLFMLAO, Quaternion BHHADNDKDEN, Vector3? LCKDNJKBIJA, bool LFMGKIFBCMH, bool KCLJGENDFBO, GEKOKGFDPOL<TData> PPGNDOHCHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x38ADF70", Offset = "0x38ACF70", VA = "0x1838ADF70", Slot = "4")]
	public override bool ODIGKBLPPJN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class PKDCOLBHONF<TData> : IDIFDLEKLHF<JEBLILLEKBA<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x3C0FBB0", Offset = "0x3C0EBB0", VA = "0x183C0FBB0")]
	public PKDCOLBHONF(JEBLILLEKBA<TData> PPGNDOHCHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x3D996D0", Offset = "0x3D986D0", VA = "0x183D996D0", Slot = "4")]
	public override bool ODIGKBLPPJN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class JPIBHGMLBEC<TData> : IDIFDLEKLHF<JEBLILLEKBA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly HMCDICLJEPE<TData> HBDNIMPPJIO;

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x411E2A0", Offset = "0x411D2A0", VA = "0x18411E2A0")]
	public JPIBHGMLBEC(IEnumerable<TData> JMIAMLFMLAO, bool KCLJGENDFBO, JEBLILLEKBA<TData> PPGNDOHCHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x38ADF70", Offset = "0x38ACF70", VA = "0x1838ADF70", Slot = "4")]
	public override bool ODIGKBLPPJN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class GHLKFCKJKAP<TData> : IDIFDLEKLHF<GEKOKGFDPOL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly OLFAEDHKDLF<TData> HBDNIMPPJIO;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x3D6E110", Offset = "0x3D6D110", VA = "0x183D6E110")]
	public GHLKFCKJKAP(IEnumerable<TData> JMIAMLFMLAO, Quaternion PPFBGCFBPGO, IBAACLNGJHP DLOOLIILFPC, Vector3? LCKDNJKBIJA, bool LFMGKIFBCMH, bool KCLJGENDFBO, Space KIPDPNGFPAE, GEKOKGFDPOL<TData> PPGNDOHCHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x3D6E050", Offset = "0x3D6D050", VA = "0x183D6E050", Slot = "4")]
	public override bool ODIGKBLPPJN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class JKFJBEDEFBL<TData> : IDIFDLEKLHF<JEBLILLEKBA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly HMHLEACJJDD HBDNIMPPJIO;

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x4116B00", Offset = "0x4115B00", VA = "0x184116B00")]
	public JKFJBEDEFBL(Quaternion BHHADNDKDEN, Vector3? LCKDNJKBIJA, bool LFMGKIFBCMH, JEBLILLEKBA<TData> PPGNDOHCHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x4116AA0", Offset = "0x4115AA0", VA = "0x184116AA0", Slot = "4")]
	public override bool ODIGKBLPPJN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public struct FJLHDHKBCCE<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public readonly IEnumerable<TData> JMIAMLFMLAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public readonly Quaternion BHHADNDKDEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public readonly Vector3? LCKDNJKBIJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public readonly bool LFMGKIFBCMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public readonly bool KCLJGENDFBO;

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x3C413B0", Offset = "0x3C403B0", VA = "0x183C413B0")]
	public FJLHDHKBCCE(IEnumerable<TData> JMIAMLFMLAO, Quaternion BHHADNDKDEN, Vector3? LCKDNJKBIJA, bool LFMGKIFBCMH, bool KCLJGENDFBO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public struct HMCDICLJEPE<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public readonly IEnumerable<TData> JMIAMLFMLAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly bool KCLJGENDFBO;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x3DEC7C0", Offset = "0x3DEB7C0", VA = "0x183DEC7C0")]
	public HMCDICLJEPE(IEnumerable<TData> JMIAMLFMLAO, bool KCLJGENDFBO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public struct OLFAEDHKDLF<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public readonly IEnumerable<TData> JMIAMLFMLAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public readonly Quaternion PPFBGCFBPGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public readonly IBAACLNGJHP DLOOLIILFPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public readonly Vector3? LCKDNJKBIJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public readonly bool LFMGKIFBCMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public readonly bool KCLJGENDFBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public readonly Space KIPDPNGFPAE;

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x46F84C0", Offset = "0x46F74C0", VA = "0x1846F84C0")]
	public OLFAEDHKDLF(IEnumerable<TData> JMIAMLFMLAO, Quaternion PPFBGCFBPGO, IBAACLNGJHP DLOOLIILFPC, Vector3? LCKDNJKBIJA, bool LFMGKIFBCMH, bool KCLJGENDFBO, Space KIPDPNGFPAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public struct HMHLEACJJDD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public readonly Quaternion BHHADNDKDEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public readonly Vector3? LCKDNJKBIJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public readonly bool LFMGKIFBCMH;

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x4CD3AC0", Offset = "0x4CD2AC0", VA = "0x184CD3AC0")]
	public HMHLEACJJDD(Quaternion BHHADNDKDEN, Vector3? LCKDNJKBIJA, bool LFMGKIFBCMH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public interface HLCDMBJGFJO<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KAENBBLCMAG([In] JACPKPEMBEA<TData> MIKILJHGJKC);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HBAECOJLMFN([In] PJFKJDPLLOB PDIIGKAKKPG);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HBAECOJLMFN([In] OLAEECOIMKC PDIIGKAKKPG);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HBAECOJLMFN([In] HNBGFODAOHN PDIIGKAKKPG);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool GAGJFFIAJGC();
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public class HBHGAMLEJCM<TData> : IDIFDLEKLHF<HLCDMBJGFJO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly HNBGFODAOHN GNKGDDNOJIB;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x3DC1D90", Offset = "0x3DC0D90", VA = "0x183DC1D90")]
	public HBHGAMLEJCM(Vector3 EBFGFEDIEIF, float JOGFACAPCBE, Vector3 LCKDNJKBIJA, bool FPAJDDKKPIE, bool COCLCOOEPCF, HLCDMBJGFJO<TData> PPGNDOHCHFE, Space KIPDPNGFPAE = Space.Self)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x3DC1D30", Offset = "0x3DC0D30", VA = "0x183DC1D30", Slot = "4")]
	public override bool ODIGKBLPPJN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public class NNAIDCBLEKI<TData> : IDIFDLEKLHF<HLCDMBJGFJO<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x3C0FBB0", Offset = "0x3C0EBB0", VA = "0x183C0FBB0")]
	public NNAIDCBLEKI(HLCDMBJGFJO<TData> PPGNDOHCHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x4601F50", Offset = "0x4600F50", VA = "0x184601F50", Slot = "4")]
	public override bool ODIGKBLPPJN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class KDDDLOPNPHI<TData> : IDIFDLEKLHF<HLCDMBJGFJO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly JACPKPEMBEA<TData> GNKGDDNOJIB;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x41C0BF0", Offset = "0x41BFBF0", VA = "0x1841C0BF0")]
	public KDDDLOPNPHI(IEnumerable<TData> JMIAMLFMLAO, bool KCLJGENDFBO, HLCDMBJGFJO<TData> PPGNDOHCHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x38ADF70", Offset = "0x38ACF70", VA = "0x1838ADF70", Slot = "4")]
	public override bool ODIGKBLPPJN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class LCJHFDNMPBE<TData> : IDIFDLEKLHF<HLCDMBJGFJO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly OLAEECOIMKC GNKGDDNOJIB;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x42D97E0", Offset = "0x42D87E0", VA = "0x1842D97E0")]
	public LCJHFDNMPBE(float OINGHDBGGNH, bool ONIJCKEIHOK, Vector3 LCKDNJKBIJA, HLCDMBJGFJO<TData> PPGNDOHCHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x42D9720", Offset = "0x42D8720", VA = "0x1842D9720", Slot = "4")]
	public override bool ODIGKBLPPJN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class ODIINICIKCO<TData> : IDIFDLEKLHF<HLCDMBJGFJO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly PJFKJDPLLOB GNKGDDNOJIB;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x46DCD30", Offset = "0x46DBD30", VA = "0x1846DCD30")]
	public ODIINICIKCO(float JOGFACAPCBE, Vector3 LCKDNJKBIJA, HLCDMBJGFJO<TData> PPGNDOHCHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x4116AA0", Offset = "0x4115AA0", VA = "0x184116AA0", Slot = "4")]
	public override bool ODIGKBLPPJN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public struct HNBGFODAOHN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public readonly Vector3 EBFGFEDIEIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public readonly float JOGFACAPCBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public readonly Vector3 LCKDNJKBIJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public readonly bool PAKJBDCIBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public readonly Space KIPDPNGFPAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public readonly bool COCLCOOEPCF;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x69BBE70", Offset = "0x69BAE70", VA = "0x1869BBE70")]
	public HNBGFODAOHN(Vector3 EBFGFEDIEIF, float JOGFACAPCBE, Vector3 LCKDNJKBIJA, bool PAKJBDCIBIP, bool AKFMMLGENHK, Space KIPDPNGFPAE = Space.Self)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public struct JACPKPEMBEA<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public readonly IEnumerable<TData> JMIAMLFMLAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public readonly bool KCLJGENDFBO;

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x40FB530", Offset = "0x40FA530", VA = "0x1840FB530")]
	public JACPKPEMBEA(IEnumerable<TData> JMIAMLFMLAO, bool KCLJGENDFBO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct OLAEECOIMKC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public readonly float OINGHDBGGNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public readonly bool ONIJCKEIHOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public readonly Vector3 LCKDNJKBIJA;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x69BD0A0", Offset = "0x69BC0A0", VA = "0x1869BD0A0")]
	public OLAEECOIMKC(float OINGHDBGGNH, bool ONIJCKEIHOK, Vector3 LCKDNJKBIJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public struct PJFKJDPLLOB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public readonly float JOGFACAPCBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public readonly Vector3 LCKDNJKBIJA;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x4C8B5D0", Offset = "0x4C8A5D0", VA = "0x184C8B5D0")]
	public PJFKJDPLLOB(float JOGFACAPCBE, Vector3 LCKDNJKBIJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct NBHMECJIMHN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public readonly Guid[] JMIAMLFMLAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public readonly bool LIPLEMMEKIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public readonly bool AGJANNINLGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public readonly bool LLJMPIOEOPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public readonly Vector3[] LEBPBJGJDOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public readonly Quaternion[] NBIEDIHKICE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly float[] AHFDBCFDDLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public readonly Dictionary<Guid, Vector3> OFMDMAHLOKB;

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x69BCB60", Offset = "0x69BBB60", VA = "0x1869BCB60")]
	public NBHMECJIMHN(Guid[] KENHJFPCMDC, Vector3[] LEBPBJGJDOD, Quaternion[] NBIEDIHKICE, float[] AHFDBCFDDLG, Dictionary<Guid, Vector3> OFMDMAHLOKB, bool LIPLEMMEKIJ = true, bool AGJANNINLGN = true, bool LLJMPIOEOPA = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x69BC990", Offset = "0x69BB990", VA = "0x1869BC990")]
	private static void NNCJELELMIH(Dictionary<Guid, Vector3> OFMDMAHLOKB, int CGPPLCLKIPH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public static class IOOHGDBAONE
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	private struct EAGKAHHCGAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public bool NMFMPNBLDDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public NDJGECDCBMH BFNOBIIBIJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public NDJGECDCBMH ELAOLOBHKMP;
	}

	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private static EAGKAHHCGAH BMALOANFNFN;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static CancellationToken JHMMBMAJEJP
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x69BC510", Offset = "0x69BB510", VA = "0x1869BC510")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	internal static NDJGECDCBMH BFNOBIIBIJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x69BC470", Offset = "0x69BB470", VA = "0x1869BC470")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x69BC300", Offset = "0x69BB300", VA = "0x1869BC300")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x69BC370", Offset = "0x69BB370", VA = "0x1869BC370")]
	[ONAOIKEPAJE(NOFONODCPKJ.Room, IKAJKCKEGIH.None)]
	private static void IIPNNHOGOLM(NDJGECDCBMH GKMEOAOAHOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x69BC160", Offset = "0x69BB160", VA = "0x1869BC160")]
	public static void CLDDABPDPLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x69BC2B0", Offset = "0x69BB2B0", VA = "0x1869BC2B0")]
	private static NDJGECDCBMH DGFNIEMKGCJ(NDJGECDCBMH IMNFKMKKLKD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public static class OCMBCAFHDIG
{
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public enum HHLKDJEHNFG
	{
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		ICreationContextObject,
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		Guid
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x2D3C540", Offset = "0x2D3B540", VA = "0x182D3C540")]
	public static void BABGDLGIJFJ<T>(T KCAPGDAGEBJ, HHLKDJEHNFG HNGLFCFOHLI) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x2D3C6A0", Offset = "0x2D3B6A0", VA = "0x182D3C6A0")]
	public static void BABGDLGIJFJ<T>(T KCAPGDAGEBJ) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x2D3C710", Offset = "0x2D3B710", VA = "0x182D3C710")]
	public static void GICPCNLPENH<T>(T KCAPGDAGEBJ) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x2D3C9C0", Offset = "0x2D3B9C0", VA = "0x182D3C9C0")]
	public static T MKHPGHPCCLG<T>(HHLKDJEHNFG HNGLFCFOHLI) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x2D3C7C0", Offset = "0x2D3B7C0", VA = "0x182D3C7C0")]
	public static bool KBNDOKPPALD<T>(HHLKDJEHNFG HNGLFCFOHLI, T? EBEMAOMJGJA, [Out][NotNullWhen(true)][MaybeNullWhen(false)] T MKFCELFDDAF) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x2D3CAD0", Offset = "0x2D3BAD0", VA = "0x182D3CAD0")]
	public static bool POOEFDNAGNJ<T>(HHLKDJEHNFG HNGLFCFOHLI) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x2D3CA70", Offset = "0x2D3BA70", VA = "0x182D3CA70")]
	public static T MKHPGHPCCLG<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x2D3C910", Offset = "0x2D3B910", VA = "0x182D3C910")]
	public static bool KBNDOKPPALD<T>(T EBEMAOMJGJA, [Out] T MKFCELFDDAF) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x2D3CA70", Offset = "0x2D3BA70", VA = "0x182D3CA70")]
	public static bool POOEFDNAGNJ<T>() where T : class
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
internal static class NEAMLKJIJOE
{
	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x69BCDF0", Offset = "0x69BBDF0", VA = "0x1869BCDF0")]
	public static void NOJIIHDKAMK(IEnumerable EFFHOEMGECD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x2D06EA0", Offset = "0x2D05EA0", VA = "0x182D06EA0")]
	public static void NOJIIHDKAMK<T>(T[] IKONNGGNFPH) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x2D06F90", Offset = "0x2D05F90", VA = "0x182D06F90")]
	public static void NOJIIHDKAMK<T>(T EIIABACMOFJ) where T : notnull, Enum
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
