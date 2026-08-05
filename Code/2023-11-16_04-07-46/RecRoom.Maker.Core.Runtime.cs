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
		[Cpp2IlInjected.Address(RVA = "0x79A600", Offset = "0x799600", VA = "0x18079A600")]
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
		[Cpp2IlInjected.Address(RVA = "0x5E1CF50", Offset = "0x5E1BF50", VA = "0x185E1CF50")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x79B560", Offset = "0x79A560", VA = "0x18079B560")]
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
		[Cpp2IlInjected.Address(RVA = "0x79B5A0", Offset = "0x79A5A0", VA = "0x18079B5A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface ADCBHBOBAAM<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ClearHoverTarget(NCIKDJELFHE KIPJKMCEMCK);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool SetHoverTarget(TData MNNJBJHGADP, Collider MONNDBHEELF, NCIKDJELFHE KIPJKMCEMCK, [Optional] CLOECILAMCC? PCFFPDABFMA);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool TryGetHoverTarget([Out] TData MNNJBJHGADP);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface HEIGLAINPDA<TData> : IGLCLGHMJHA, APPMPIIAJJM<TData>, OKLPDLCJHMI<TData>, NJEFJGAHLAE<TData>, DOCGKMDDFMM, MGJGFCMJHPI<TData>, PBPLPNHFLEN, BKANFDKLEBK
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface MGJGFCMJHPI<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 MJEJBDJGGLA, Vector3 AKNDOLIKNGM, float IBOJBDBEJBJ, [Out] T INAADDICKNP, [Out] Vector3 HJFFJBHFHPF, [Out] Collider MONNDBHEELF);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 MJEJBDJGGLA, Vector3 AKNDOLIKNGM, float FMMIFKCFHPI, float IBOJBDBEJBJ, T[] AKPJKBMAGHL, [Out] Vector3 DCEBBBNDLDI, [Out] Collider MCPNADFNDOC);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 MJEJBDJGGLA, float FMMIFKCFHPI, Vector3 MCBIMPAOLMF, T[] AKPJKBMAGHL);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface IGLCLGHMJHA
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Bounds NALAKMGDOJF
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Transform GJAHMPFMLMI
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Bounds LPFJNBMJOMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Transform MMCIFLHPPOL
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Vector3 INENDHINNMM
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void SetSelectionBoundsDirty(bool DDODOOFLKJF = true, int BINNOBDDADG = 0);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ShouldHideSelectionBoundsPreview(bool DMDMACKPGCN, object PDIBILKHEBM);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface BKANFDKLEBK
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	DNHICBJBOMM MDIAIICNJPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface NJEFJGAHLAE<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool ELCPOEMNKKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	int AGLMBMMPPLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	IEnumerable<TData> ICMNNJCNAGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData NIFCHCHHAAG);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData NIFCHCHHAAG);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface APPMPIIAJJM<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T GPCHHCACPPJ, [Optional] CLOECILAMCC? AADFGDGLCCB, bool LEAPPHLBPCF = true);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int AGLAJIDEGHD, IEnumerable<T> AJJNJLOIDBF, bool LEAPPHLBPCF = true);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int AGLAJIDEGHD, IEnumerable<T> AJJNJLOIDBF, CLOECILAMCC AADFGDGLCCB, bool LEAPPHLBPCF = true);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface PBPLPNHFLEN
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface DOCGKMDDFMM
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool IMPHOIDGGOH
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool EHGNLIOJJMB
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool DHABIONPHHN
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool FKBBIIHGIOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class EPIPOMCLEBF<TReceiver> : KCNKJDEGPJD<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x30CDDA0", Offset = "0x30CCDA0", VA = "0x1830CDDA0")]
	public EPIPOMCLEBF(TReceiver HGHAJEHCOAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public abstract class OMANGCHAJOC<TReceiver, TFromTask> : KCNKJDEGPJD<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x30CDDA0", Offset = "0x30CCDA0", VA = "0x1830CDDA0")]
	public OMANGCHAJOC(TReceiver HGHAJEHCOAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class KCNKJDEGPJD<TReceiver, TFromExecute> where TReceiver : notnull where TFromExecute : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	protected TReceiver HGHAJEHCOAJ;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x394DBA0", Offset = "0x394CBA0", VA = "0x18394DBA0")]
	public KCNKJDEGPJD(TReceiver HGHAJEHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute PCIFAKAHGKL();
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class CKILGPMLKHJ<TReceiver, TResult> : KCNKJDEGPJD<TReceiver, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x30CDDA0", Offset = "0x30CCDA0", VA = "0x1830CDDA0")]
	public CKILGPMLKHJ(TReceiver HGHAJEHCOAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct OLABOBCCKJA<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public TGroup OBNEAGJBKEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public TData LDFIPCCCBDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public IEnumerable<TData> FKJLGLKDLDJ;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x1973EE0", Offset = "0x1972EE0", VA = "0x181973EE0")]
	public OLABOBCCKJA(TGroup OENCHMFLHCE, TData OGEHPCCLFJB, IEnumerable<TData> INDNPMHDJNH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct FHAMBOPNGIP<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public TGroup OBNEAGJBKEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public IEnumerable<TData> FKJLGLKDLDJ;

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7F7E80", Offset = "0x7F6E80", VA = "0x1807F7E80")]
	public FHAMBOPNGIP(TGroup OENCHMFLHCE, IEnumerable<TData> INDNPMHDJNH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct LMNBENHPIOL<TGroup> where TGroup : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public TGroup OBNEAGJBKEL;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x8436A0", Offset = "0x8426A0", VA = "0x1808436A0")]
	public LMNBENHPIOL(TGroup OENCHMFLHCE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct IHIGDIAIOPJ<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public IEnumerable<TData> FKJLGLKDLDJ;

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x8436A0", Offset = "0x8426A0", VA = "0x1808436A0")]
	public IHIGDIAIOPJ(IEnumerable<TData> INDNPMHDJNH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface OFMMOKMJEMB<TGroup, TData>
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OPMPOHFDGJG FKBIBFIDBFH(OLABOBCCKJA<TGroup, TData> DGCPBDNECCG);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OPMPOHFDGJG DCGOIAEANMP(OLABOBCCKJA<TGroup, TData> DGCPBDNECCG);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	OPMPOHFDGJG HLGKGBIGBNF(FHAMBOPNGIP<TGroup, TData> DGCPBDNECCG);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	OPMPOHFDGJG BBCPPCNFIFE(LMNBENHPIOL<TGroup> DGCPBDNECCG);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface LOMAKKBJAOA<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<OPMPOHFDGJG> FKBIBFIDBFH(IHIGDIAIOPJ<TData> DGCPBDNECCG);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class JFGAKJGIAPA<TGroup, TData> : CKILGPMLKHJ<OFMMOKMJEMB<TGroup, TData>, OPMPOHFDGJG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly FHAMBOPNGIP<TGroup, TData> DGCPBDNECCG;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x38D7000", Offset = "0x38D6000", VA = "0x1838D7000")]
	public JFGAKJGIAPA(TGroup OENCHMFLHCE, IEnumerable<TData> INDNPMHDJNH, OFMMOKMJEMB<TGroup, TData> HGHAJEHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x38D6F30", Offset = "0x38D5F30", VA = "0x1838D6F30", Slot = "4")]
	public override OPMPOHFDGJG PCIFAKAHGKL()
	{
		return default(OPMPOHFDGJG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class JJBEBCCHIBD<TGroup, TData> : CKILGPMLKHJ<OFMMOKMJEMB<TGroup, TData>, OPMPOHFDGJG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly OLABOBCCKJA<TGroup, TData> DGCPBDNECCG;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x38E6CF0", Offset = "0x38E5CF0", VA = "0x1838E6CF0")]
	public JJBEBCCHIBD(TGroup OENCHMFLHCE, TData DHHICIBNJAB, IEnumerable<TData> INDNPMHDJNH, OFMMOKMJEMB<TGroup, TData> HGHAJEHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x38E6C10", Offset = "0x38E5C10", VA = "0x1838E6C10", Slot = "4")]
	public override OPMPOHFDGJG PCIFAKAHGKL()
	{
		return default(OPMPOHFDGJG);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class CKPAHGAILLG<TGroup, TData> : CKILGPMLKHJ<OFMMOKMJEMB<TGroup, TData>, OPMPOHFDGJG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly LMNBENHPIOL<TGroup> DGCPBDNECCG;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x39D07A0", Offset = "0x39CF7A0", VA = "0x1839D07A0")]
	public CKPAHGAILLG(TGroup OENCHMFLHCE, OFMMOKMJEMB<TGroup, TData> HGHAJEHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x48D7070", Offset = "0x48D6070", VA = "0x1848D7070", Slot = "4")]
	public override OPMPOHFDGJG PCIFAKAHGKL()
	{
		return default(OPMPOHFDGJG);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class CLLGCHJGMAJ<TGroup, TData> : CKILGPMLKHJ<OFMMOKMJEMB<TGroup, TData>, OPMPOHFDGJG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly OLABOBCCKJA<TGroup, TData> DGCPBDNECCG;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x38E6CF0", Offset = "0x38E5CF0", VA = "0x1838E6CF0")]
	public CLLGCHJGMAJ(TGroup OENCHMFLHCE, TData OGEHPCCLFJB, IEnumerable<TData> INDNPMHDJNH, OFMMOKMJEMB<TGroup, TData> HGHAJEHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x48D7CA0", Offset = "0x48D6CA0", VA = "0x1848D7CA0", Slot = "4")]
	public override OPMPOHFDGJG PCIFAKAHGKL()
	{
		return default(OPMPOHFDGJG);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class DBCGKBGCKBH<TData> : OMANGCHAJOC<LOMAKKBJAOA<TData>, OPMPOHFDGJG> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct DOBLCMNCOHD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AsyncTaskMethodBuilder<OPMPOHFDGJG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public DBCGKBGCKBH<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private TaskAwaiter<OPMPOHFDGJG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x4DD1920", Offset = "0x4DD0920", VA = "0x184DD1920", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x4DD1BC0", Offset = "0x4DD0BC0", VA = "0x184DD1BC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private IHIGDIAIOPJ<TData> DGCPBDNECCG;

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x39D07A0", Offset = "0x39CF7A0", VA = "0x1839D07A0")]
	public DBCGKBGCKBH(IEnumerable<TData> FKIFCCKANMK, LOMAKKBJAOA<TData> HGHAJEHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4D865B0", Offset = "0x4D855B0", VA = "0x184D865B0", Slot = "4")]
	[AsyncStateMachine(typeof(DBCGKBGCKBH<>.DOBLCMNCOHD))]
	public override Task<OPMPOHFDGJG> PCIFAKAHGKL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct APILFDAMPEM<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public TNode HPHIDHOOBLL;

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x366D670", Offset = "0x366C670", VA = "0x18366D670")]
	public APILFDAMPEM(TNode HPHIDHOOBLL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct NGGAJLBMJBG<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public TNode EBPBCHIPBFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public IHIICPLHEGC IJNBAGPABPJ;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3D19580", Offset = "0x3D18580", VA = "0x183D19580")]
	public NGGAJLBMJBG(TNode EBPBCHIPBFM, IHIICPLHEGC IJNBAGPABPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface IMDKNGFPCNF<TNode>
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BCPPALABPCB([In] APILFDAMPEM<TNode> EOOLINIBDGF);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KBMIPHGIJNO([In] NGGAJLBMJBG<TNode> MNMLGNLMMDJ);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MCEOGAPABIE();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class IIPFDOCCAHL<TNode> : EPIPOMCLEBF<IMDKNGFPCNF<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x30CDDA0", Offset = "0x30CCDA0", VA = "0x1830CDDA0")]
	public IIPFDOCCAHL(IMDKNGFPCNF<TNode> HGHAJEHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x37467A0", Offset = "0x37457A0", VA = "0x1837467A0", Slot = "4")]
	public override bool PCIFAKAHGKL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class NHMIEPMKNHH<TNode> : EPIPOMCLEBF<IMDKNGFPCNF<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly NGGAJLBMJBG<TNode> MNMLGNLMMDJ;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3D1EFC0", Offset = "0x3D1DFC0", VA = "0x183D1EFC0")]
	public NHMIEPMKNHH(TNode EBPBCHIPBFM, IHIICPLHEGC IJNBAGPABPJ, IMDKNGFPCNF<TNode> HGHAJEHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3628920", Offset = "0x3627920", VA = "0x183628920", Slot = "4")]
	public override bool PCIFAKAHGKL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class EGLHMMDKMBI<TNode> : EPIPOMCLEBF<IMDKNGFPCNF<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly APILFDAMPEM<TNode> EOOLINIBDGF;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x30FD6E0", Offset = "0x30FC6E0", VA = "0x1830FD6E0")]
	public EGLHMMDKMBI(TNode IKIDMGNLFHO, IMDKNGFPCNF<TNode> HGHAJEHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x30FD620", Offset = "0x30FC620", VA = "0x1830FD620", Slot = "4")]
	public override bool PCIFAKAHGKL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct LAODANAKMEM<TSpawnInfo> where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public TSpawnInfo NKEGKIHJHMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public Vector3 LPGLCEHEHMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public Quaternion LGOFCBEILGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public float EKPAHLHAMGH;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0xDB18C0", Offset = "0xDB08C0", VA = "0x180DB18C0")]
	public LAODANAKMEM(TSpawnInfo NKEGKIHJHMP, Vector3 LPGLCEHEHMC, Quaternion LGOFCBEILGM, float EKPAHLHAMGH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface DBEIAMBMKHO<TSpawnType, TSpawnInfo>
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> JACPLDOHCFF([In] LAODANAKMEM<TSpawnInfo> JFMNDFKPCEF, CancellationToken JEBPNJAPHEL);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class BEAJBHMKPHG<TSpawnType, TSpawnInfo> : OMANGCHAJOC<DBEIAMBMKHO<TSpawnType, TSpawnInfo>, TSpawnType> where TSpawnType : notnull where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly LAODANAKMEM<TSpawnInfo> IEECDEJOFJP;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x452FC60", Offset = "0x452EC60", VA = "0x18452FC60")]
	public BEAJBHMKPHG(TSpawnInfo FLMDGMABPNP, Vector3 LPGLCEHEHMC, Quaternion LGOFCBEILGM, float EKPAHLHAMGH, DBEIAMBMKHO<TSpawnType, TSpawnInfo> HGHAJEHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x452FB80", Offset = "0x452EB80", VA = "0x18452FB80", Slot = "4")]
	public override Task<TSpawnType> PCIFAKAHGKL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public readonly struct HDHHMNMHKIP<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly IEnumerable<TData> FKJLGLKDLDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly bool KKOCCGALHPP;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x35E9E40", Offset = "0x35E8E40", VA = "0x1835E9E40")]
	public HDHHMNMHKIP(IEnumerable<TData> INDNPMHDJNH, bool LPHNLBKHJED = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface FGAJDIBDHCC<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<OPMPOHFDGJG> CGONOFDPIFN([In] HDHHMNMHKIP<TData> IKFJAFJJPFM, CancellationToken JEBPNJAPHEL);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class CGICOBJJPNG<TData> : OMANGCHAJOC<FGAJDIBDHCC<TData>, OPMPOHFDGJG> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly HDHHMNMHKIP<TData> CJNOPIEFLCK;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x47F8BC0", Offset = "0x47F7BC0", VA = "0x1847F8BC0")]
	public CGICOBJJPNG(IEnumerable<TData> INDNPMHDJNH, bool LPHNLBKHJED, FGAJDIBDHCC<TData> HGHAJEHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x452FB80", Offset = "0x452EB80", VA = "0x18452FB80", Slot = "4")]
	public override Task<OPMPOHFDGJG> PCIFAKAHGKL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct GBOPIHCCHFP<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly T MNNJBJHGADP;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x34FD340", Offset = "0x34FC340", VA = "0x1834FD340")]
	public GBOPIHCCHFP(T LABCIGEAGDJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface DMOCIOMBAHB<T>
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BCPPALABPCB([In] GBOPIHCCHFP<T> HMGCNLAHIGC);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KBMIPHGIJNO();
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface GAKHPJJBIJI<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PCIFAKAHGKL([In] LGDBCGADKFD<T> PCNJMMIEDFC);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public struct LGDBCGADKFD<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly T MNNJBJHGADP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly bool JMMNGHOBOPG;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3A7EEF0", Offset = "0x3A7DEF0", VA = "0x183A7EEF0")]
	public LGDBCGADKFD(T LABCIGEAGDJ, bool IJCIEBJDKGH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class EAPNBMGMDKP<T> : EPIPOMCLEBF<DMOCIOMBAHB<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x30CDDA0", Offset = "0x30CCDA0", VA = "0x1830CDDA0")]
	public EAPNBMGMDKP(DMOCIOMBAHB<T> HGHAJEHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x30CDD50", Offset = "0x30CCD50", VA = "0x1830CDD50", Slot = "4")]
	public override bool PCIFAKAHGKL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class KJPCGHGDAHF<T> : EPIPOMCLEBF<DMOCIOMBAHB<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly GBOPIHCCHFP<T> HMGCNLAHIGC;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x39D0720", Offset = "0x39CF720", VA = "0x1839D0720")]
	public KJPCGHGDAHF(T MNNJBJHGADP, DMOCIOMBAHB<T> HGHAJEHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x30FD620", Offset = "0x30FC620", VA = "0x1830FD620", Slot = "4")]
	public override bool PCIFAKAHGKL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class JLBNLHKPJKO<T> : EPIPOMCLEBF<GAKHPJJBIJI<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly LGDBCGADKFD<T> PCNJMMIEDFC;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x38F1D30", Offset = "0x38F0D30", VA = "0x1838F1D30")]
	public JLBNLHKPJKO(T MNNJBJHGADP, bool IJCIEBJDKGH, GAKHPJJBIJI<T> HGHAJEHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x30FD620", Offset = "0x30FC620", VA = "0x1830FD620", Slot = "4")]
	public override bool PCIFAKAHGKL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct FLLEOMFAICA<TData> where TData : notnull, COENCKGDPBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public IEnumerable<TData> FKJLGLKDLDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public bool GFJLELLHJML;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3469D30", Offset = "0x3468D30", VA = "0x183469D30")]
	public FLLEOMFAICA(IEnumerable<TData> CPCKGOKIICE, bool FABLOHKNLDF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct HNEGBGFJOCG<TData> where TData : notnull, COENCKGDPBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public List<TData> FKJLGLKDLDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public List<bool> GNDODCEFHNP;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3698CE0", Offset = "0x3697CE0", VA = "0x183698CE0")]
	public HNEGBGFJOCG(List<TData> CPCKGOKIICE, List<bool> HLLPPKMGKML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface COENCKGDPBF
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool NNDCGILEGBA
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface LKNANBEGBPD<TData> where TData : COENCKGDPBF
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PCIFAKAHGKL([In] FLLEOMFAICA<TData> EJMJABIFOLG);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PCIFAKAHGKL([In] HNEGBGFJOCG<TData> EJMJABIFOLG);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class IANENKOELJI<TData> : EPIPOMCLEBF<LKNANBEGBPD<TData>> where TData : notnull, COENCKGDPBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly FLLEOMFAICA<TData> EJMJABIFOLG;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x371AAB0", Offset = "0x3719AB0", VA = "0x18371AAB0")]
	public IANENKOELJI(List<TData> INDNPMHDJNH, bool GFJLELLHJML, LKNANBEGBPD<TData> HGHAJEHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x30FD620", Offset = "0x30FC620", VA = "0x1830FD620", Slot = "4")]
	public override bool PCIFAKAHGKL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class CJEFLMKFENK<TData> : EPIPOMCLEBF<LKNANBEGBPD<TData>> where TData : notnull, COENCKGDPBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly HNEGBGFJOCG<TData> EJMJABIFOLG;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x48D5500", Offset = "0x48D4500", VA = "0x1848D5500")]
	public CJEFLMKFENK(List<TData> INDNPMHDJNH, List<bool> GNDODCEFHNP, LKNANBEGBPD<TData> HGHAJEHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x48D5440", Offset = "0x48D4440", VA = "0x1848D5440", Slot = "4")]
	public override bool PCIFAKAHGKL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface AGPPLLGCJKE : COENCKGDPBF
{
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface DKHABEKEGED<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<OPMPOHFDGJG> PCIFAKAHGKL(EPIAAFFJJNJ<TData> LMGDNEGDOAL);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class EEEDFFDHCBD<TData> : OMANGCHAJOC<DKHABEKEGED<TData>, OPMPOHFDGJG> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct AHBNJOJBNLH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public AsyncTaskMethodBuilder<OPMPOHFDGJG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public EEEDFFDHCBD<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private TaskAwaiter<OPMPOHFDGJG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x355C230", Offset = "0x355B230", VA = "0x18355C230", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x355C520", Offset = "0x355B520", VA = "0x18355C520", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly EPIAAFFJJNJ<TData> IFCBIPKDMNM;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x30F26F0", Offset = "0x30F16F0", VA = "0x1830F26F0")]
	public EEEDFFDHCBD(TData OEKKKNCNJJC, IReadOnlyList<TData> DHIAKIKIEFO, bool LPHNLBKHJED, DKHABEKEGED<TData> HGHAJEHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x30F25F0", Offset = "0x30F15F0", VA = "0x1830F25F0", Slot = "4")]
	[AsyncStateMachine(typeof(EEEDFFDHCBD<>.AHBNJOJBNLH))]
	public override Task<OPMPOHFDGJG> PCIFAKAHGKL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public struct EPIAAFFJJNJ<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public TData OGIHPJCILHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public IReadOnlyList<TData> AINNMAOECDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public bool KKOCCGALHPP;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x311F0B0", Offset = "0x311E0B0", VA = "0x18311F0B0")]
	public EPIAAFFJJNJ(TData OEKKKNCNJJC, IReadOnlyList<TData> DHIAKIKIEFO, bool LPHNLBKHJED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface JMHIOFJPFFH<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PCIFAKAHGKL([In] IMCDKLGODDH<TData> KNKAMCAHGAF);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface EBKGKNMCINL<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PCIFAKAHGKL([In] MEHJDEMCKAF<TData> KNKAMCAHGAF);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface EMJMFDOIIJM<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LPNHCMONGHI([In] JPKGGHHLEGI<TData> KNKAMCAHGAF);

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KBMIPHGIJNO();
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class OFNGBMCHFIJ<TData> : EPIPOMCLEBF<JMHIOFJPFFH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly IMCDKLGODDH<TData> KNKAMCAHGAF;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x3DFDFF0", Offset = "0x3DFCFF0", VA = "0x183DFDFF0")]
	public OFNGBMCHFIJ(IEnumerable<TData> INDNPMHDJNH, DICKJAHDJCD NGFEKFKHCIJ, ONHJKJKPMHM DMOCGBANHDO, float PKDODMJFILO, bool LPHNLBKHJED, JMHIOFJPFFH<TData> HGHAJEHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x30FD620", Offset = "0x30FC620", VA = "0x1830FD620", Slot = "4")]
	public override bool PCIFAKAHGKL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public class HPGKOIJEBCN<TData> : EPIPOMCLEBF<EBKGKNMCINL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly MEHJDEMCKAF<TData> KNKAMCAHGAF;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x36A07B0", Offset = "0x369F7B0", VA = "0x1836A07B0")]
	public HPGKOIJEBCN(TData[] INDNPMHDJNH, DICKJAHDJCD[] NGFEKFKHCIJ, ONHJKJKPMHM[] DMOCGBANHDO, float[] PKDODMJFILO, EBKGKNMCINL<TData> HGHAJEHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x36A06F0", Offset = "0x369F6F0", VA = "0x1836A06F0", Slot = "4")]
	public override bool PCIFAKAHGKL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class AHEMAGMAKDP<TData> : EPIPOMCLEBF<EMJMFDOIIJM<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x30CDDA0", Offset = "0x30CCDA0", VA = "0x1830CDDA0")]
	public AHEMAGMAKDP(EMJMFDOIIJM<TData> HGHAJEHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x355DBC0", Offset = "0x355CBC0", VA = "0x18355DBC0", Slot = "4")]
	public override bool PCIFAKAHGKL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class HPNNBAIEPGH<TData> : EPIPOMCLEBF<EMJMFDOIIJM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly JPKGGHHLEGI<TData> KNKAMCAHGAF;

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x36A4010", Offset = "0x36A3010", VA = "0x1836A4010")]
	public HPNNBAIEPGH(IEnumerable<TData> INDNPMHDJNH, DICKJAHDJCD NGFEKFKHCIJ, ONHJKJKPMHM DMOCGBANHDO, float PKDODMJFILO, EMJMFDOIIJM<TData> HGHAJEHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x36A06F0", Offset = "0x369F6F0", VA = "0x1836A06F0", Slot = "4")]
	public override bool PCIFAKAHGKL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public struct IMCDKLGODDH<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public IEnumerable<TData> FKJLGLKDLDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public DICKJAHDJCD IHLMLKJIBLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public ONHJKJKPMHM KKDJAMMHCNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public float PKDODMJFILO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public bool LPHNLBKHJED;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x37510E0", Offset = "0x37500E0", VA = "0x1837510E0")]
	public IMCDKLGODDH(IEnumerable<TData> INDNPMHDJNH, DICKJAHDJCD NGFEKFKHCIJ, ONHJKJKPMHM DMOCGBANHDO, float PKDODMJFILO, bool LPHNLBKHJED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public struct MEHJDEMCKAF<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public TData[] FKJLGLKDLDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public DICKJAHDJCD[] IHLMLKJIBLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public ONHJKJKPMHM[] KKDJAMMHCNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public float[] PKDODMJFILO;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x3C77610", Offset = "0x3C76610", VA = "0x183C77610")]
	public MEHJDEMCKAF(TData[] INDNPMHDJNH, DICKJAHDJCD[] NGFEKFKHCIJ, ONHJKJKPMHM[] DMOCGBANHDO, float[] PKDODMJFILO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public struct JPKGGHHLEGI<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public IEnumerable<TData> FKJLGLKDLDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public DICKJAHDJCD IHLMLKJIBLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public ONHJKJKPMHM KKDJAMMHCNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public float PKDODMJFILO;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x390EAE0", Offset = "0x390DAE0", VA = "0x18390EAE0")]
	public JPKGGHHLEGI(IEnumerable<TData> INDNPMHDJNH, DICKJAHDJCD NGFEKFKHCIJ, ONHJKJKPMHM DMOCGBANHDO, float PKDODMJFILO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface OKLPDLCJHMI<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HLGKGBIGBNF([In] FFHPNBLEJLJ<TData> IKFJAFJJPFM);

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BBCPPCNFIFE([In] FFHPNBLEJLJ<TData> IKFJAFJJPFM);

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ANBAKDIJONC([In] bool KPFAJMODCBB);

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool GNCECJCIIJE([In] FFHPNBLEJLJ<TData> IKFJAFJJPFM);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MKBEGFCBKEE();

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool PBBOKHBGAPA([In] TData MALGGJGAEPP);
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class NOCICGNBFAG<TData> : EPIPOMCLEBF<OKLPDLCJHMI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly FFHPNBLEJLJ<TData> IKFJAFJJPFM;

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x3D35A10", Offset = "0x3D34A10", VA = "0x183D35A10")]
	public NOCICGNBFAG(List<TData> LCMMFGCFNCG, OKLPDLCJHMI<TData> HGHAJEHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x30FD620", Offset = "0x30FC620", VA = "0x1830FD620", Slot = "4")]
	public override bool PCIFAKAHGKL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class BDNHNPLEDHI<TData> : EPIPOMCLEBF<OKLPDLCJHMI<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x30CDDA0", Offset = "0x30CCDA0", VA = "0x1830CDDA0")]
	public BDNHNPLEDHI(OKLPDLCJHMI<TData> HGHAJEHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x452FB30", Offset = "0x452EB30", VA = "0x18452FB30", Slot = "4")]
	public override bool PCIFAKAHGKL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class EPLFCPGKNAP<TData> : EPIPOMCLEBF<OKLPDLCJHMI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly bool LPHNLBKHJED;

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x3121150", Offset = "0x3120150", VA = "0x183121150")]
	public EPLFCPGKNAP(bool LPHNLBKHJED, OKLPDLCJHMI<TData> HGHAJEHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x31210F0", Offset = "0x31200F0", VA = "0x1831210F0", Slot = "4")]
	public override bool PCIFAKAHGKL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class DMHFNOGIPED<TData> : EPIPOMCLEBF<OKLPDLCJHMI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly FFHPNBLEJLJ<TData> IKFJAFJJPFM;

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x4DCB060", Offset = "0x4DCA060", VA = "0x184DCB060")]
	public DMHFNOGIPED(List<TData> LCMMFGCFNCG, bool LPHNLBKHJED, OKLPDLCJHMI<TData> HGHAJEHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x48D5440", Offset = "0x48D4440", VA = "0x1848D5440", Slot = "4")]
	public override bool PCIFAKAHGKL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public class CLBJMEALCKI<TData> : EPIPOMCLEBF<OKLPDLCJHMI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly TData MALGGJGAEPP;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x48D7690", Offset = "0x48D6690", VA = "0x1848D7690")]
	public CLBJMEALCKI(TData MALGGJGAEPP, OKLPDLCJHMI<TData> HGHAJEHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x48D75C0", Offset = "0x48D65C0", VA = "0x1848D75C0", Slot = "4")]
	public override bool PCIFAKAHGKL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class GCCINHOHJDJ<TData> : EPIPOMCLEBF<OKLPDLCJHMI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly FFHPNBLEJLJ<TData> IKFJAFJJPFM;

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x34FD4C0", Offset = "0x34FC4C0", VA = "0x1834FD4C0")]
	public GCCINHOHJDJ(List<TData> LCMMFGCFNCG, OKLPDLCJHMI<TData> HGHAJEHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x34FD360", Offset = "0x34FC360", VA = "0x1834FD360", Slot = "4")]
	public override bool PCIFAKAHGKL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public struct FFHPNBLEJLJ<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public IEnumerable<TData> FKJLGLKDLDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public bool LPHNLBKHJED;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3456BE0", Offset = "0x3455BE0", VA = "0x183456BE0")]
	public FFHPNBLEJLJ(IEnumerable<TData> CPCKGOKIICE, bool MPBNAHLHOJN = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface NCDBCNPLOLJ
{
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<OPMPOHFDGJG> PCIFAKAHGKL(HLFJNEHFGJD KIEKIHEKAKL);
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class GPBEFGGJEFK : OMANGCHAJOC<NCDBCNPLOLJ, OPMPOHFDGJG>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private struct FEKECFANGON : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public AsyncTaskMethodBuilder<OPMPOHFDGJG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public GPBEFGGJEFK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private TaskAwaiter<OPMPOHFDGJG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x5E1C6E0", Offset = "0x5E1B6E0", VA = "0x185E1C6E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x5E1C960", Offset = "0x5E1B960", VA = "0x185E1C960", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly HLFJNEHFGJD LLDOGKGLGIO;

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5E1CB00", Offset = "0x5E1BB00", VA = "0x185E1CB00")]
	public GPBEFGGJEFK(bool LPHNLBKHJED, NCDBCNPLOLJ HGHAJEHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5E1CA10", Offset = "0x5E1BA10", VA = "0x185E1CA10", Slot = "4")]
	[AsyncStateMachine(typeof(FEKECFANGON))]
	public override Task<OPMPOHFDGJG> PCIFAKAHGKL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public struct HLFJNEHFGJD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public bool KKOCCGALHPP;

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0xBAF9F0", Offset = "0xBAE9F0", VA = "0x180BAF9F0")]
	public HLFJNEHFGJD(bool LPHNLBKHJED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface ICIAAMPEKCC<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BCPPALABPCB([In] FDAGACBOJNI<TData> EOOLINIBDGF);

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LPNHCMONGHI([In] DEKCAONNIFE JCAODMCJNEC);

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LPNHCMONGHI([In] OEKBIKLHELE JCAODMCJNEC);

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool KBMIPHGIJNO();
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class LKJCMLNLGNJ<TData> : EPIPOMCLEBF<ICIAAMPEKCC<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x30CDDA0", Offset = "0x30CCDA0", VA = "0x1830CDDA0")]
	public LKJCMLNLGNJ(ICIAAMPEKCC<TData> HGHAJEHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3A90DE0", Offset = "0x3A8FDE0", VA = "0x183A90DE0", Slot = "4")]
	public override bool PCIFAKAHGKL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class DEAOGJLFDJG<TData> : EPIPOMCLEBF<ICIAAMPEKCC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly DEKCAONNIFE HJCNCAPCEIP;

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x4DA1250", Offset = "0x4DA0250", VA = "0x184DA1250")]
	public DEAOGJLFDJG(Vector3 NFCOEGDJOOE, bool EHCPPADJIBJ, ICIAAMPEKCC<TData> HGHAJEHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x30F2510", Offset = "0x30F1510", VA = "0x1830F2510", Slot = "4")]
	public override bool PCIFAKAHGKL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class FDCMCNALJBG<TData> : EPIPOMCLEBF<ICIAAMPEKCC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly OEKBIKLHELE HJCNCAPCEIP;

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x344AF40", Offset = "0x3449F40", VA = "0x18344AF40")]
	public FDCMCNALJBG(Guid MKPMDFNDBGM, int NFJIPMHILEL, Vector3 LPGLCEHEHMC, Quaternion LGOFCBEILGM, float PEBOEKHAPLP, bool EHCPPADJIBJ, ICIAAMPEKCC<TData> HGHAJEHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x344AEE0", Offset = "0x3449EE0", VA = "0x18344AEE0", Slot = "4")]
	public override bool PCIFAKAHGKL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class FLODHKNHNKO<TData> : EPIPOMCLEBF<ICIAAMPEKCC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly FDAGACBOJNI<TData> HJCNCAPCEIP;

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x346A030", Offset = "0x3469030", VA = "0x18346A030")]
	public FLODHKNHNKO(TData MNNJBJHGADP, bool LPHNLBKHJED, ICIAAMPEKCC<TData> HGHAJEHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x30FD620", Offset = "0x30FC620", VA = "0x1830FD620", Slot = "4")]
	public override bool PCIFAKAHGKL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public struct DEKCAONNIFE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly Vector3 NFCOEGDJOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly bool EHCPPADJIBJ;

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x5E1C490", Offset = "0x5E1B490", VA = "0x185E1C490")]
	public DEKCAONNIFE(Vector3 NFCOEGDJOOE, bool EHCPPADJIBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct OEKBIKLHELE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly Guid MKPMDFNDBGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly int NFJIPMHILEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly Vector3 LPGLCEHEHMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly Quaternion LGOFCBEILGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly float PEBOEKHAPLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly bool EHCPPADJIBJ;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x5E1CFD0", Offset = "0x5E1BFD0", VA = "0x185E1CFD0")]
	public OEKBIKLHELE(Guid MKPMDFNDBGM, int NFJIPMHILEL, Vector3 LPGLCEHEHMC, Quaternion LGOFCBEILGM, float PEBOEKHAPLP, bool EHCPPADJIBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public struct FDAGACBOJNI<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly TData MNNJBJHGADP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly bool LPHNLBKHJED;

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x344AA90", Offset = "0x3449A90", VA = "0x18344AA90")]
	public FDAGACBOJNI(TData MNNJBJHGADP, bool LPHNLBKHJED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface ONKALNJPAHI<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PCIFAKAHGKL([In] HKNIHHOCANF<TData> LNMBGMDEMHP);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PCIFAKAHGKL([In] FHLEFMHBOAD<TData> LNMBGMDEMHP);
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public interface BFDGPGFHBPF<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BCPPALABPCB([In] MMJMODGPAJI<TData> DMJMLDBOAPH);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LPNHCMONGHI([In] HCFAPDFNECG JCAODMCJNEC);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KBMIPHGIJNO();
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class BLHBCLKINLN<TData> : EPIPOMCLEBF<ONKALNJPAHI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly HKNIHHOCANF<TData> LNMBGMDEMHP;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4571010", Offset = "0x4570010", VA = "0x184571010")]
	public BLHBCLKINLN(IEnumerable<TData> INDNPMHDJNH, Vector3 HDBCHEOGMOF, bool LPHNLBKHJED, ONKALNJPAHI<TData> HGHAJEHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x30FD620", Offset = "0x30FC620", VA = "0x1830FD620", Slot = "4")]
	public override bool PCIFAKAHGKL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class IDNGLFCPFNF<TData> : EPIPOMCLEBF<BFDGPGFHBPF<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x30CDDA0", Offset = "0x30CCDA0", VA = "0x1830CDDA0")]
	public IDNGLFCPFNF(BFDGPGFHBPF<TData> HGHAJEHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x372BA70", Offset = "0x372AA70", VA = "0x18372BA70", Slot = "4")]
	public override bool PCIFAKAHGKL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class IEGHHEAKBDJ<TData> : EPIPOMCLEBF<BFDGPGFHBPF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly MMJMODGPAJI<TData> LNMBGMDEMHP;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x37317F0", Offset = "0x37307F0", VA = "0x1837317F0")]
	public IEGHHEAKBDJ(IEnumerable<TData> INDNPMHDJNH, bool LPHNLBKHJED, BFDGPGFHBPF<TData> HGHAJEHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x30FD620", Offset = "0x30FC620", VA = "0x1830FD620", Slot = "4")]
	public override bool PCIFAKAHGKL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class KAFOAENHFKE<TData> : EPIPOMCLEBF<ONKALNJPAHI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly FHLEFMHBOAD<TData> LNMBGMDEMHP;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x3949DD0", Offset = "0x3948DD0", VA = "0x183949DD0")]
	public KAFOAENHFKE(IEnumerable<TData> INDNPMHDJNH, Vector3 OJDKDEBJCMG, JGLBGDHEENG CDEPKCIBFIL, bool LPHNLBKHJED, ONKALNJPAHI<TData> HGHAJEHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3628920", Offset = "0x3627920", VA = "0x183628920", Slot = "4")]
	public override bool PCIFAKAHGKL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class DDLJFNJAAOH<TData> : EPIPOMCLEBF<BFDGPGFHBPF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly HCFAPDFNECG LNMBGMDEMHP;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x4DA1200", Offset = "0x4DA0200", VA = "0x184DA1200")]
	public DDLJFNJAAOH(Vector3 HDBCHEOGMOF, BFDGPGFHBPF<TData> HGHAJEHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x30F2510", Offset = "0x30F1510", VA = "0x1830F2510", Slot = "4")]
	public override bool PCIFAKAHGKL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public struct HKNIHHOCANF<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public readonly IEnumerable<TData> INDNPMHDJNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public readonly Vector3 HDBCHEOGMOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public readonly bool LPHNLBKHJED;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x36291B0", Offset = "0x36281B0", VA = "0x1836291B0")]
	public HKNIHHOCANF(IEnumerable<TData> INDNPMHDJNH, Vector3 HDBCHEOGMOF, bool LPHNLBKHJED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public struct MMJMODGPAJI<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public readonly IEnumerable<TData> INDNPMHDJNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly bool LPHNLBKHJED;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x3CBB870", Offset = "0x3CBA870", VA = "0x183CBB870")]
	public MMJMODGPAJI(IEnumerable<TData> INDNPMHDJNH, bool LPHNLBKHJED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public struct FHLEFMHBOAD<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public readonly IEnumerable<TData> INDNPMHDJNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public readonly Vector3 OJDKDEBJCMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public readonly JGLBGDHEENG CDEPKCIBFIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public readonly bool LPHNLBKHJED;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x345E380", Offset = "0x345D380", VA = "0x18345E380")]
	public FHLEFMHBOAD(IEnumerable<TData> INDNPMHDJNH, Vector3 OJDKDEBJCMG, JGLBGDHEENG CDEPKCIBFIL, bool LPHNLBKHJED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public struct HCFAPDFNECG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public readonly Vector3 HDBCHEOGMOF;

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x200F640", Offset = "0x200E640", VA = "0x18200F640")]
	public HCFAPDFNECG(Vector3 HDBCHEOGMOF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public enum JGLBGDHEENG
{
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	XYZ,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	X_only,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	Y_only,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	Z_only
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public interface DEBODFGBJFI<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PCIFAKAHGKL([In] KJFMMFPOFFG<TData> GCGEIGMFKJK);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PCIFAKAHGKL([In] BCFBNNCGAHK<TData> GCGEIGMFKJK);
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public interface AAAEBAKODIC<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BCPPALABPCB([In] GHIGELBNACL<TData> EOOLINIBDGF);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LPNHCMONGHI([In] JHCBNDGEEDE JCAODMCJNEC);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KBMIPHGIJNO();
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public class LNLPAMBAPNI<TData> : EPIPOMCLEBF<DEBODFGBJFI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly KJFMMFPOFFG<TData> GCGEIGMFKJK;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x3A961F0", Offset = "0x3A951F0", VA = "0x183A961F0")]
	public LNLPAMBAPNI(IEnumerable<TData> INDNPMHDJNH, Quaternion HDBCHEOGMOF, Vector3? MHJDEGBDOML, bool MHLMGDCFNKF, bool LPHNLBKHJED, DEBODFGBJFI<TData> HGHAJEHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x30FD620", Offset = "0x30FC620", VA = "0x1830FD620", Slot = "4")]
	public override bool PCIFAKAHGKL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class PIKJJHIDPFL<TData> : EPIPOMCLEBF<AAAEBAKODIC<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x30CDDA0", Offset = "0x30CCDA0", VA = "0x1830CDDA0")]
	public PIKJJHIDPFL(AAAEBAKODIC<TData> HGHAJEHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x372BA70", Offset = "0x372AA70", VA = "0x18372BA70", Slot = "4")]
	public override bool PCIFAKAHGKL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class LIBBMFALNCF<TData> : EPIPOMCLEBF<AAAEBAKODIC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly GHIGELBNACL<TData> GCGEIGMFKJK;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x3A815B0", Offset = "0x3A805B0", VA = "0x183A815B0")]
	public LIBBMFALNCF(IEnumerable<TData> INDNPMHDJNH, bool LPHNLBKHJED, AAAEBAKODIC<TData> HGHAJEHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x30FD620", Offset = "0x30FC620", VA = "0x1830FD620", Slot = "4")]
	public override bool PCIFAKAHGKL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class HKCCGIDHHLI<TData> : EPIPOMCLEBF<DEBODFGBJFI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly BCFBNNCGAHK<TData> GCGEIGMFKJK;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x36289F0", Offset = "0x36279F0", VA = "0x1836289F0")]
	public HKCCGIDHHLI(IEnumerable<TData> INDNPMHDJNH, Quaternion PCPDBGCOFMA, JGLBGDHEENG MNABADPBJDJ, Vector3? MHJDEGBDOML, bool MHLMGDCFNKF, bool LPHNLBKHJED, DEBODFGBJFI<TData> HGHAJEHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x3628920", Offset = "0x3627920", VA = "0x183628920", Slot = "4")]
	public override bool PCIFAKAHGKL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class PNMPEMBFAGH<TData> : EPIPOMCLEBF<AAAEBAKODIC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly JHCBNDGEEDE GCGEIGMFKJK;

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x3ECBB10", Offset = "0x3ECAB10", VA = "0x183ECBB10")]
	public PNMPEMBFAGH(Quaternion HDBCHEOGMOF, Vector3? MHJDEGBDOML, bool MHLMGDCFNKF, AAAEBAKODIC<TData> HGHAJEHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x30F2510", Offset = "0x30F1510", VA = "0x1830F2510", Slot = "4")]
	public override bool PCIFAKAHGKL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public struct KJFMMFPOFFG<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public readonly IEnumerable<TData> INDNPMHDJNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public readonly Quaternion HDBCHEOGMOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public readonly Vector3? MHJDEGBDOML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public readonly bool MHLMGDCFNKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public readonly bool LPHNLBKHJED;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x396E170", Offset = "0x396D170", VA = "0x18396E170")]
	public KJFMMFPOFFG(IEnumerable<TData> INDNPMHDJNH, Quaternion HDBCHEOGMOF, Vector3? MHJDEGBDOML, bool MHLMGDCFNKF, bool LPHNLBKHJED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct GHIGELBNACL<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public readonly IEnumerable<TData> INDNPMHDJNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly bool LPHNLBKHJED;

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x351C360", Offset = "0x351B360", VA = "0x18351C360")]
	public GHIGELBNACL(IEnumerable<TData> INDNPMHDJNH, bool LPHNLBKHJED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct BCFBNNCGAHK<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public readonly IEnumerable<TData> INDNPMHDJNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly Quaternion PCPDBGCOFMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public readonly JGLBGDHEENG MNABADPBJDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public readonly Vector3? MHJDEGBDOML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public readonly bool MHLMGDCFNKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public readonly bool LPHNLBKHJED;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x452B190", Offset = "0x452A190", VA = "0x18452B190")]
	public BCFBNNCGAHK(IEnumerable<TData> INDNPMHDJNH, Quaternion PCPDBGCOFMA, JGLBGDHEENG MNABADPBJDJ, Vector3? MHJDEGBDOML, bool MHLMGDCFNKF, bool LPHNLBKHJED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct JHCBNDGEEDE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public readonly Quaternion HDBCHEOGMOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public readonly Vector3? MHJDEGBDOML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public readonly bool MHLMGDCFNKF;

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x43B1090", Offset = "0x43B0090", VA = "0x1843B1090")]
	public JHCBNDGEEDE(Quaternion HDBCHEOGMOF, Vector3? MHJDEGBDOML, bool MHLMGDCFNKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public interface PKMKDHBOGDI<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BCPPALABPCB([In] OOLLCLIGCCB<TData> EOOLINIBDGF);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LPNHCMONGHI([In] GEIPCKCOAIB JCAODMCJNEC);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LPNHCMONGHI([In] HNKLOJNFCJG JCAODMCJNEC);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool LPNHCMONGHI([In] GEGAGGNEJAP JCAODMCJNEC);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool KBMIPHGIJNO();
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public class JMMEGAPGOOB<TData> : EPIPOMCLEBF<PKMKDHBOGDI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly GEGAGGNEJAP ALPMKGLBFJJ;

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x38F8940", Offset = "0x38F7940", VA = "0x1838F8940")]
	public JMMEGAPGOOB(Vector3 FEGFKIGBDDF, float MGEAGKCABGB, Vector3 MHJDEGBDOML, bool IPJGCJPOIEO, bool CDPDIMGBMOD, PKMKDHBOGDI<TData> HGHAJEHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x38F88E0", Offset = "0x38F78E0", VA = "0x1838F88E0", Slot = "4")]
	public override bool PCIFAKAHGKL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public class MNOIFAOLDBP<TData> : EPIPOMCLEBF<PKMKDHBOGDI<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x30CDDA0", Offset = "0x30CCDA0", VA = "0x1830CDDA0")]
	public MNOIFAOLDBP(PKMKDHBOGDI<TData> HGHAJEHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x3CBC0F0", Offset = "0x3CBB0F0", VA = "0x183CBC0F0", Slot = "4")]
	public override bool PCIFAKAHGKL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public class JEFFMGHMAOB<TData> : EPIPOMCLEBF<PKMKDHBOGDI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly OOLLCLIGCCB<TData> ALPMKGLBFJJ;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x38D1230", Offset = "0x38D0230", VA = "0x1838D1230")]
	public JEFFMGHMAOB(IEnumerable<TData> INDNPMHDJNH, bool LPHNLBKHJED, PKMKDHBOGDI<TData> HGHAJEHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x30FD620", Offset = "0x30FC620", VA = "0x1830FD620", Slot = "4")]
	public override bool PCIFAKAHGKL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class GGMADBLBBGH<TData> : EPIPOMCLEBF<PKMKDHBOGDI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly HNKLOJNFCJG ALPMKGLBFJJ;

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x3519740", Offset = "0x3518740", VA = "0x183519740")]
	public GGMADBLBBGH(float KGKAPMHDNGE, bool FFCCHMDLNGL, Vector3 MHJDEGBDOML, PKMKDHBOGDI<TData> HGHAJEHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x3519670", Offset = "0x3518670", VA = "0x183519670", Slot = "4")]
	public override bool PCIFAKAHGKL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public class EDPIJDHEFJL<TData> : EPIPOMCLEBF<PKMKDHBOGDI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly GEIPCKCOAIB ALPMKGLBFJJ;

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x30F2570", Offset = "0x30F1570", VA = "0x1830F2570")]
	public EDPIJDHEFJL(float MGEAGKCABGB, Vector3 MHJDEGBDOML, PKMKDHBOGDI<TData> HGHAJEHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x30F2510", Offset = "0x30F1510", VA = "0x1830F2510", Slot = "4")]
	public override bool PCIFAKAHGKL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct GEGAGGNEJAP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public readonly Vector3 FEGFKIGBDDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public readonly float MGEAGKCABGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public readonly Vector3 MHJDEGBDOML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public readonly bool EHCPPADJIBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public readonly bool CDPDIMGBMOD;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x5E1C9D0", Offset = "0x5E1B9D0", VA = "0x185E1C9D0")]
	public GEGAGGNEJAP(Vector3 FEGFKIGBDDF, float MGEAGKCABGB, Vector3 MHJDEGBDOML, bool EHCPPADJIBJ, bool JEBLFCKNIIC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public struct OOLLCLIGCCB<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public readonly IEnumerable<TData> INDNPMHDJNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public readonly bool LPHNLBKHJED;

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x3E0EEE0", Offset = "0x3E0DEE0", VA = "0x183E0EEE0")]
	public OOLLCLIGCCB(IEnumerable<TData> INDNPMHDJNH, bool LPHNLBKHJED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public struct HNKLOJNFCJG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly float KGKAPMHDNGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public readonly bool FFCCHMDLNGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public readonly Vector3 MHJDEGBDOML;

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x5E1CB60", Offset = "0x5E1BB60", VA = "0x185E1CB60")]
	public HNKLOJNFCJG(float KGKAPMHDNGE, bool FFCCHMDLNGL, Vector3 MHJDEGBDOML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct GEIPCKCOAIB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public readonly float MGEAGKCABGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public readonly Vector3 MHJDEGBDOML;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x4389610", Offset = "0x4388610", VA = "0x184389610")]
	public GEIPCKCOAIB(float MGEAGKCABGB, Vector3 MHJDEGBDOML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public static class KLONJBDIABO
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	private struct DEPHMAFFAFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public bool DMHNKLOCHJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public EIABFOFJCDK MBPNABCEDJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public EIABFOFJCDK CCHLNOCIBAM;
	}

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static DEPHMAFFAFA KKELOBHCKNO;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static CancellationToken LEONAHFDKDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x5E1CF30", Offset = "0x5E1BF30", VA = "0x185E1CF30")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	internal static EIABFOFJCDK MBPNABCEDJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x5E1CC40", Offset = "0x5E1BC40", VA = "0x185E1CC40")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x5E1CB80", Offset = "0x5E1BB80", VA = "0x185E1CB80")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5E1CCE0", Offset = "0x5E1BCE0", VA = "0x185E1CCE0")]
	[PKDJMILODMH(OPHHJIDIAGK.Room, OMIAJJHDDGO.None)]
	private static void MANCEHNPLLH(EIABFOFJCDK KKBFNOCDCAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5E1CDE0", Offset = "0x5E1BDE0", VA = "0x185E1CDE0")]
	public static void OFPJBAGGFGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x5E1CBF0", Offset = "0x5E1BBF0", VA = "0x185E1CBF0")]
	private static EIABFOFJCDK GIKKGNCCENI(EIABFOFJCDK BKLFELEFPAL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public static class CBHKIPBNGHL
{
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public enum JJMHCPLFMOO
	{
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		ICreationContextObject,
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		Guid
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x231D4D0", Offset = "0x231C4D0", VA = "0x18231D4D0")]
	public static void MEGNBPMCAOH<T>(T PBJLMCDEAOF, JJMHCPLFMOO CFGJPNBLNDJ) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x231D470", Offset = "0x231C470", VA = "0x18231D470")]
	public static void MEGNBPMCAOH<T>(T PBJLMCDEAOF) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x231D400", Offset = "0x231C400", VA = "0x18231D400")]
	public static void KJBFNKIJOEH<T>(T PBJLMCDEAOF) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x231D360", Offset = "0x231C360", VA = "0x18231D360")]
	public static T GJNMDDLIIAA<T>(JJMHCPLFMOO CFGJPNBLNDJ) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x231D280", Offset = "0x231C280", VA = "0x18231D280")]
	public static bool DOCOACDFHGI<T>(JJMHCPLFMOO CFGJPNBLNDJ) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x231D320", Offset = "0x231C320", VA = "0x18231D320")]
	public static T GJNMDDLIIAA<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x231D320", Offset = "0x231C320", VA = "0x18231D320")]
	public static bool DOCOACDFHGI<T>() where T : class
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
internal static class EOLDMLJBKNE
{
	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x5E1C4B0", Offset = "0x5E1B4B0", VA = "0x185E1C4B0")]
	public static void JCGEABOKJFB(IEnumerable HDDLEJBOBIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x23C51E0", Offset = "0x23C41E0", VA = "0x1823C51E0")]
	public static void JCGEABOKJFB<T>(T[] FHOLKIOOKFG) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x23C52D0", Offset = "0x23C42D0", VA = "0x1823C52D0")]
	public static void JCGEABOKJFB<T>(T KFLFOHECPON) where T : notnull, Enum
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
