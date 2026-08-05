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
		[Cpp2IlInjected.Address(RVA = "0x890220", Offset = "0x88EE20", VA = "0x180890220")]
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
		[Cpp2IlInjected.Address(RVA = "0x6A11790", Offset = "0x6A10390", VA = "0x186A11790")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x890890", Offset = "0x88F490", VA = "0x180890890")]
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
		[Cpp2IlInjected.Address(RVA = "0x8908D0", Offset = "0x88F4D0", VA = "0x1808908D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface HODFMLJNDIM<TData, TReturn>
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TReturn BIKHFAAINOO(TData APKAFMDACKK);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface LALMHNLELEO<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ClearHoverTarget(FJMBEENKNHE AFGGLAMLNKB);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool SetHoverTarget(TData EEOLDJILHGA, Collider LDEJOGIIDND, FJMBEENKNHE AFGGLAMLNKB, [Optional] FKPBJOFDNBG? EAEDEENEACG);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool TryGetHoverTarget([Out] TData EEOLDJILHGA);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetHoverCollider([Out] Collider LDEJOGIIDND);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface MAMIBEEBPCG<TData> : GNOAGNMOFAI, JEIKEBHLJIN<TData>, KLMGBEKJIFC<TData>, ENFCIDLMFFM<TData>, KPKCOJKDLAE, FALKBPMOOJH<TData>, HIGMKCHDCJN, JPPLGKPDPFI
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface FALKBPMOOJH<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 PPDGJCIMLMA, Vector3 MLCEOGMBLFG, float DIPNJIGHAJA, [Out] T OIBIPCCGHKO, [Out] Vector3 BNPCBADHAGO, [Out] Collider LDEJOGIIDND);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 PPDGJCIMLMA, Vector3 MLCEOGMBLFG, float BOKMIICHMJE, float DIPNJIGHAJA, T[] GEHJGHGJAIE, [Out] Vector3 ODIMCMIMDGM, [Out] Collider KLAPIIANDLP);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 PPDGJCIMLMA, float BOKMIICHMJE, Vector3 GFPAHGJJPLC, T[] GEHJGHGJAIE);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetObjectFromColliderInCurrentScope(Collider PENEDLAGBJG, [Out] T MEADKGBNJLJ);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface GNOAGNMOFAI
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Bounds FOFDHOLKGHM
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Transform EMGJLFMEJCN
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Bounds LGLOKHFIDJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Transform EGACMDAEHEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Vector3 KMODBBHDADJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool ODANGCMMAJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void SetSelectionBoundsDirty(bool GDMGMNJNJDD = true, int KNDOKHAFKPD = 0);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ShouldHideSelectionBoundsPreview(bool LOAHPLKNOBG, object GBENACPKFNA);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface JPPLGKPDPFI
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	MMAIJBDFGNK OMPAGBHNJCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface IILFFLPPFIO
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool MAAAFDIJJOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool DEMCGBOFDKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool GDCFFFEHFJL
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
	void TrySetPreviousCloneMapping(Dictionary<Guid, Guid> IAPNHBMNEGB);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface ENFCIDLMFFM<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool HJBDIEMPPKM
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int JDMMFOJOMNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<TData> MNLFOGIGELI
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData NLEFMACAEAP);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData NLEFMACAEAP);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface JEIKEBHLJIN<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T APKAFMDACKK, [Optional] FKPBJOFDNBG? FJNHLGEPLMK, bool FIHHNFLMFLB = true);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int LLHINFJPPOH, IEnumerable<T> MBGIGHKLPLH, bool FIHHNFLMFLB = true);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int LLHINFJPPOH, IEnumerable<T> MBGIGHKLPLH, FKPBJOFDNBG FJNHLGEPLMK, bool FIHHNFLMFLB = true);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface HIGMKCHDCJN
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface KPKCOJKDLAE
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool KHJJFICLJKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool OIHOBECANMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool PIIAJCBKDHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool OHFJEDBCFPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class DBNHDBHBNJM<TReceiver> : OPHAOCDKHHG<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3846AE0", Offset = "0x38456E0", VA = "0x183846AE0")]
	public DBNHDBHBNJM(TReceiver LFPNEAKNDGE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class AEACOGLNCFO<TReceiver, TFromTask> : OPHAOCDKHHG<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3846AE0", Offset = "0x38456E0", VA = "0x183846AE0")]
	public AEACOGLNCFO(TReceiver LFPNEAKNDGE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public abstract class OPHAOCDKHHG<TReceiver, TFromExecute> where TReceiver : notnull where TFromExecute : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	protected TReceiver LFPNEAKNDGE;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x46C5F30", Offset = "0x46C4B30", VA = "0x1846C5F30")]
	public OPHAOCDKHHG(TReceiver LFPNEAKNDGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute INOEKLCMBOB();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public abstract class INGMDLBMJMF<TReceiver, TResult> : OPHAOCDKHHG<TReceiver, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3846AE0", Offset = "0x38456E0", VA = "0x183846AE0")]
	public INGMDLBMJMF(TReceiver LFPNEAKNDGE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct LHLBFGKOLLC<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public TGroup KOHJKJPJFPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public TData FKEMOONBACF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public IEnumerable<TData> MNPEAMBPLLH;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1EBB470", Offset = "0x1EBA070", VA = "0x181EBB470")]
	public LHLBFGKOLLC(TGroup DPOOCBLDMDB, TData EPDAEIEMLAB, IEnumerable<TData> KIFDDEHNJMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct BJLLNBNOAAK<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public TGroup KOHJKJPJFPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public IEnumerable<TData> MNPEAMBPLLH;

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0xAC5C80", Offset = "0xAC4880", VA = "0x180AC5C80")]
	public BJLLNBNOAAK(TGroup DPOOCBLDMDB, IEnumerable<TData> KIFDDEHNJMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct AOHEFEHCCAN<TGroup> where TGroup : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public TGroup KOHJKJPJFPN;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x9403F0", Offset = "0x93EFF0", VA = "0x1809403F0")]
	public AOHEFEHCCAN(TGroup DPOOCBLDMDB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct NEAHFDFJDDJ<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public IEnumerable<TData> MNPEAMBPLLH;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x9403F0", Offset = "0x93EFF0", VA = "0x1809403F0")]
	public NEAHFDFJDDJ(IEnumerable<TData> KIFDDEHNJMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface BNDLBGJJPEL<TGroup, TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DBLAAKPDHMG MJCEMCAKPHA(LHLBFGKOLLC<TGroup, TData> EOBANIKBEOC);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "1")]
	DBLAAKPDHMG JKPMPIACGAJ(LHLBFGKOLLC<TGroup, TData> EOBANIKBEOC);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DBLAAKPDHMG DGDHCCBPAAA(BJLLNBNOAAK<TGroup, TData> EOBANIKBEOC);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "3")]
	DBLAAKPDHMG ENLFHEKAFAF(AOHEFEHCCAN<TGroup> EOBANIKBEOC);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface CBDMFKMNCOJ<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<DBLAAKPDHMG> MJCEMCAKPHA(NEAHFDFJDDJ<TData> EOBANIKBEOC);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class BIDNDHMJBMG<TGroup, TData> : INGMDLBMJMF<BNDLBGJJPEL<TGroup, TData>, DBLAAKPDHMG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly BJLLNBNOAAK<TGroup, TData> EOBANIKBEOC;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4E78D50", Offset = "0x4E77950", VA = "0x184E78D50")]
	public BIDNDHMJBMG(TGroup DPOOCBLDMDB, IEnumerable<TData> KIFDDEHNJMO, BNDLBGJJPEL<TGroup, TData> LFPNEAKNDGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4E78C80", Offset = "0x4E77880", VA = "0x184E78C80", Slot = "4")]
	public override DBLAAKPDHMG INOEKLCMBOB()
	{
		return default(DBLAAKPDHMG);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class JBHNEHKGDLG<TGroup, TData> : INGMDLBMJMF<BNDLBGJJPEL<TGroup, TData>, DBLAAKPDHMG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly LHLBFGKOLLC<TGroup, TData> EOBANIKBEOC;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4079DF0", Offset = "0x40789F0", VA = "0x184079DF0")]
	public JBHNEHKGDLG(TGroup DPOOCBLDMDB, TData JMBINNIFIKO, IEnumerable<TData> KIFDDEHNJMO, BNDLBGJJPEL<TGroup, TData> LFPNEAKNDGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4079D20", Offset = "0x4078920", VA = "0x184079D20", Slot = "4")]
	public override DBLAAKPDHMG INOEKLCMBOB()
	{
		return default(DBLAAKPDHMG);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class LGDDNPMFJLA<TGroup, TData> : INGMDLBMJMF<BNDLBGJJPEL<TGroup, TData>, DBLAAKPDHMG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly AOHEFEHCCAN<TGroup> EOBANIKBEOC;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3822AA0", Offset = "0x38216A0", VA = "0x183822AA0")]
	public LGDDNPMFJLA(TGroup DPOOCBLDMDB, BNDLBGJJPEL<TGroup, TData> LFPNEAKNDGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4258740", Offset = "0x4257340", VA = "0x184258740", Slot = "4")]
	public override DBLAAKPDHMG INOEKLCMBOB()
	{
		return default(DBLAAKPDHMG);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class BDKPJOKGLGF<TGroup, TData> : INGMDLBMJMF<BNDLBGJJPEL<TGroup, TData>, DBLAAKPDHMG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly LHLBFGKOLLC<TGroup, TData> EOBANIKBEOC;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x4079DF0", Offset = "0x40789F0", VA = "0x184079DF0")]
	public BDKPJOKGLGF(TGroup DPOOCBLDMDB, TData EPDAEIEMLAB, IEnumerable<TData> KIFDDEHNJMO, BNDLBGJJPEL<TGroup, TData> LFPNEAKNDGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4E67710", Offset = "0x4E66310", VA = "0x184E67710", Slot = "4")]
	public override DBLAAKPDHMG INOEKLCMBOB()
	{
		return default(DBLAAKPDHMG);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class JNPICPHJNGD<TData> : AEACOGLNCFO<CBDMFKMNCOJ<TData>, DBLAAKPDHMG> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private struct FBCKFHDLGIJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AsyncTaskMethodBuilder<DBLAAKPDHMG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public JNPICPHJNGD<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private TaskAwaiter<DBLAAKPDHMG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x3BC0420", Offset = "0x3BBF020", VA = "0x183BC0420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3BC06C0", Offset = "0x3BBF2C0", VA = "0x183BC06C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private NEAHFDFJDDJ<TData> EOBANIKBEOC;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3822AA0", Offset = "0x38216A0", VA = "0x183822AA0")]
	public JNPICPHJNGD(IEnumerable<TData> BNMHKGLADAK, CBDMFKMNCOJ<TData> LFPNEAKNDGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x40D5320", Offset = "0x40D3F20", VA = "0x1840D5320", Slot = "4")]
	[AsyncStateMachine(typeof(JNPICPHJNGD<>.FBCKFHDLGIJ))]
	public override Task<DBLAAKPDHMG> INOEKLCMBOB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct GOLLBIMCCGI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly HFFKMJIGOBN ICKFIHLBFCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly bool OONAPEKKEGN;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6A10C50", Offset = "0x6A0F850", VA = "0x186A10C50")]
	public GOLLBIMCCGI(HFFKMJIGOBN EGKDOPNNPGF, bool KBOEFGONAJK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface HHJINKENGAC<TSpawnType> where TSpawnType : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> INOEKLCMBOB(GOLLBIMCCGI NFBIBOPJNPH);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class HCGOOMOMKAA<TSpawnType> : AEACOGLNCFO<HHJINKENGAC<TSpawnType>, TSpawnType> where TSpawnType : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private struct COOPMIDKICH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public AsyncTaskMethodBuilder<TSpawnType> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public HCGOOMOMKAA<TSpawnType> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskAwaiter<TSpawnType> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x56B4210", Offset = "0x56B2E10", VA = "0x1856B4210", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x56A9A80", Offset = "0x56A8680", VA = "0x1856A9A80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly GOLLBIMCCGI NFBIBOPJNPH;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3DB21C0", Offset = "0x3DB0DC0", VA = "0x183DB21C0")]
	public HCGOOMOMKAA(HFFKMJIGOBN EGKDOPNNPGF, bool KBOEFGONAJK, HHJINKENGAC<TSpawnType> LFPNEAKNDGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3DB20B0", Offset = "0x3DB0CB0", VA = "0x183DB20B0", Slot = "4")]
	[AsyncStateMachine(typeof(HCGOOMOMKAA<>.COOPMIDKICH))]
	public override Task<TSpawnType> INOEKLCMBOB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public readonly struct HFFKMJIGOBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly bool PDKKDLBMFFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly Vector3 LMJIJFLGJLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly Vector3 MMKDAECKHPD;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6A10D60", Offset = "0x6A0F960", VA = "0x186A10D60")]
	public HFFKMJIGOBN(Transform JGMHKFLGIIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6A10CA0", Offset = "0x6A0F8A0", VA = "0x186A10CA0")]
	public HFFKMJIGOBN(Vector3 BCLJLGDCOIN, Vector3 DCDKACDAEIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6A10C70", Offset = "0x6A0F870", VA = "0x186A10C70")]
	public static HFFKMJIGOBN LIMAJKMFJNK()
	{
		return default(HFFKMJIGOBN);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6A10CD0", Offset = "0x6A0F8D0", VA = "0x186A10CD0")]
	private HFFKMJIGOBN(bool FGNECJEAHEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct BMAJCKOOHDC<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public TNode DJNCPNBOCOI;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4E90C40", Offset = "0x4E8F840", VA = "0x184E90C40")]
	public BMAJCKOOHDC(TNode DJNCPNBOCOI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct NPIFOFOFOAG<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public TNode PBNJPJMOMNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public DKGHNNOKOHL PANONIKLOED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly bool OONAPEKKEGN;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x453B180", Offset = "0x4539D80", VA = "0x18453B180")]
	public NPIFOFOFOAG(TNode PBNJPJMOMNG, DKGHNNOKOHL PANONIKLOED, bool KBOEFGONAJK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface EELAPCCDJNG<TNode>
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CNNFICBJBPF([In] BMAJCKOOHDC<TNode> MNJMBIFMPOD);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OLCEOFMHAED([In] NPIFOFOFOAG<TNode> ELJDJNFOIJH);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DNOFENKNGHL();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class MAEOPJOBLAB<TNode> : DBNHDBHBNJM<EELAPCCDJNG<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3846AE0", Offset = "0x38456E0", VA = "0x183846AE0")]
	public MAEOPJOBLAB(EELAPCCDJNG<TNode> LFPNEAKNDGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x44640A0", Offset = "0x4462CA0", VA = "0x1844640A0", Slot = "4")]
	public override bool INOEKLCMBOB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class OMCJFLAGHBL<TNode> : DBNHDBHBNJM<EELAPCCDJNG<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly NPIFOFOFOAG<TNode> ELJDJNFOIJH;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x46C0E30", Offset = "0x46BFA30", VA = "0x1846C0E30")]
	public OMCJFLAGHBL(TNode PBNJPJMOMNG, DKGHNNOKOHL PANONIKLOED, EELAPCCDJNG<TNode> LFPNEAKNDGE, bool KBOEFGONAJK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3E97500", Offset = "0x3E96100", VA = "0x183E97500", Slot = "4")]
	public override bool INOEKLCMBOB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class NLCBJDDPBPE<TNode> : DBNHDBHBNJM<EELAPCCDJNG<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly BMAJCKOOHDC<TNode> MNJMBIFMPOD;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x4522860", Offset = "0x4521460", VA = "0x184522860")]
	public NLCBJDDPBPE(TNode MOOILPEBPIH, EELAPCCDJNG<TNode> LFPNEAKNDGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3822950", Offset = "0x3821550", VA = "0x183822950", Slot = "4")]
	public override bool INOEKLCMBOB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct AILKDJOLGBM<TSpawnInfo> where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public TSpawnInfo ILNOHDPOHIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public Vector3 DCDKACDAEIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Quaternion GPEICHFGELO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public float DANMJNNJDHD;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3D30E70", Offset = "0x3D2FA70", VA = "0x183D30E70")]
	public AILKDJOLGBM(TSpawnInfo ILNOHDPOHIG, Vector3 DCDKACDAEIJ, Quaternion GPEICHFGELO, float DANMJNNJDHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface GFOCLLHNOMD<TSpawnType, TSpawnInfo>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> GHDFDPPCFLD([In] AILKDJOLGBM<TSpawnInfo> FCDIKHNMCBH, CancellationToken PPKBAEMFIMG);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class FINLILLANGD<TSpawnType, TSpawnInfo> : AEACOGLNCFO<GFOCLLHNOMD<TSpawnType, TSpawnInfo>, TSpawnType> where TSpawnType : notnull where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly AILKDJOLGBM<TSpawnInfo> OHIOFOHNMPI;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3C20960", Offset = "0x3C1F560", VA = "0x183C20960")]
	public FINLILLANGD(TSpawnInfo BBIFMHOCIBF, Vector3 DCDKACDAEIJ, Quaternion GPEICHFGELO, float DANMJNNJDHD, GFOCLLHNOMD<TSpawnType, TSpawnInfo> LFPNEAKNDGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3C20880", Offset = "0x3C1F480", VA = "0x183C20880", Slot = "4")]
	public override Task<TSpawnType> INOEKLCMBOB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct BLPFFAPDEHJ<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly IEnumerable<TData> MNPEAMBPLLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly bool OONAPEKKEGN;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x4E90930", Offset = "0x4E8F530", VA = "0x184E90930")]
	public BLPFFAPDEHJ(IEnumerable<TData> KIFDDEHNJMO, bool KBOEFGONAJK = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface JPBDLKAACKK<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<DBLAAKPDHMG> EDJJFFKPELK([In] BLPFFAPDEHJ<TData> EECKLMKLMAM, CancellationToken PPKBAEMFIMG);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class LJBEJBNGNEC<TData> : AEACOGLNCFO<JPBDLKAACKK<TData>, DBLAAKPDHMG> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly BLPFFAPDEHJ<TData> MONFFCLPAGP;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x427DB40", Offset = "0x427C740", VA = "0x18427DB40")]
	public LJBEJBNGNEC(IEnumerable<TData> KIFDDEHNJMO, bool KBOEFGONAJK, JPBDLKAACKK<TData> LFPNEAKNDGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3C20880", Offset = "0x3C1F480", VA = "0x183C20880", Slot = "4")]
	public override Task<DBLAAKPDHMG> INOEKLCMBOB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct IGKCJNANPPF<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public readonly T EEOLDJILHGA;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x3EA9210", Offset = "0x3EA7E10", VA = "0x183EA9210")]
	public IGKCJNANPPF(T MKKJGBBIBMM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface FDLOBAAOBMA<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CNNFICBJBPF([In] IGKCJNANPPF<T> ILEKCMBPANI);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OLCEOFMHAED();
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface JBCFMJOHGIO<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool INOEKLCMBOB([In] JHHGCLDEGJC<T> GIMPHFFGHNM);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct JHHGCLDEGJC<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public readonly T EEOLDJILHGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public readonly bool JCKNPOKCFJM;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x4094C30", Offset = "0x4093830", VA = "0x184094C30")]
	public JHHGCLDEGJC(T MKKJGBBIBMM, bool PDBADPOAOBN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class FAHKINFDMPE<T> : DBNHDBHBNJM<FDLOBAAOBMA<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x3846AE0", Offset = "0x38456E0", VA = "0x183846AE0")]
	public FAHKINFDMPE(FDLOBAAOBMA<T> LFPNEAKNDGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x3BBF560", Offset = "0x3BBE160", VA = "0x183BBF560", Slot = "4")]
	public override bool INOEKLCMBOB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class EAJMLAPFKII<T> : DBNHDBHBNJM<FDLOBAAOBMA<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly IGKCJNANPPF<T> ILEKCMBPANI;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x3822A10", Offset = "0x3821610", VA = "0x183822A10")]
	public EAJMLAPFKII(T EEOLDJILHGA, FDLOBAAOBMA<T> LFPNEAKNDGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x3822950", Offset = "0x3821550", VA = "0x183822950", Slot = "4")]
	public override bool INOEKLCMBOB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class JIDLOGCFPLJ<T> : DBNHDBHBNJM<JBCFMJOHGIO<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly JHHGCLDEGJC<T> GIMPHFFGHNM;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x40A3D40", Offset = "0x40A2940", VA = "0x1840A3D40")]
	public JIDLOGCFPLJ(T EEOLDJILHGA, bool PDBADPOAOBN, JBCFMJOHGIO<T> LFPNEAKNDGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x3822950", Offset = "0x3821550", VA = "0x183822950", Slot = "4")]
	public override bool INOEKLCMBOB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct FOAJKBHHOCP<TData> where TData : notnull, JGLBMPHKOPL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public IEnumerable<TData> MNPEAMBPLLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public bool INAIKMLMEEI;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x3C35CE0", Offset = "0x3C348E0", VA = "0x183C35CE0")]
	public FOAJKBHHOCP(IEnumerable<TData> MGKHIJOEFHI, bool MGHLHNOOBHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct DGDFODLCDHD<TData> where TData : notnull, JGLBMPHKOPL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public List<TData> MNPEAMBPLLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public List<bool> FGDPHEOCMNE;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x589D710", Offset = "0x589C310", VA = "0x18589D710")]
	public DGDFODLCDHD(List<TData> MGKHIJOEFHI, List<bool> BCHKOBIJPCF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface JGLBMPHKOPL
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool ABHIODLOPIB
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
public interface CGFHLPPNKAM<TData> where TData : JGLBMPHKOPL
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool INOEKLCMBOB([In] FOAJKBHHOCP<TData> JFGLFBHIABF);

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void INOEKLCMBOB([In] DGDFODLCDHD<TData> JFGLFBHIABF);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface KDOILIFAAKJ<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ECFLBLFEOIO(T EEOLDJILHGA);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class PHIEKGECLJL<TData> : DBNHDBHBNJM<CGFHLPPNKAM<TData>> where TData : notnull, JGLBMPHKOPL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly FOAJKBHHOCP<TData> JFGLFBHIABF;

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x478E520", Offset = "0x478D120", VA = "0x18478E520")]
	public PHIEKGECLJL(List<TData> KIFDDEHNJMO, bool INAIKMLMEEI, CGFHLPPNKAM<TData> LFPNEAKNDGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x3822950", Offset = "0x3821550", VA = "0x183822950", Slot = "4")]
	public override bool INOEKLCMBOB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class MHOIABNIAOD<TData> : DBNHDBHBNJM<CGFHLPPNKAM<TData>> where TData : notnull, JGLBMPHKOPL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly DGDFODLCDHD<TData> JFGLFBHIABF;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x448C360", Offset = "0x448AF60", VA = "0x18448C360")]
	public MHOIABNIAOD(List<TData> KIFDDEHNJMO, List<bool> FGDPHEOCMNE, CGFHLPPNKAM<TData> LFPNEAKNDGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x448C2A0", Offset = "0x448AEA0", VA = "0x18448C2A0", Slot = "4")]
	public override bool INOEKLCMBOB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface JJKICNGMGPM<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<DBLAAKPDHMG> INOEKLCMBOB(ODKAGALBNKL<TData> FNFHCABDACO);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public class IDBEFBPONKB<TData> : AEACOGLNCFO<JJKICNGMGPM<TData>, DBLAAKPDHMG> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct GFFBKFJAOAG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public AsyncTaskMethodBuilder<DBLAAKPDHMG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public IDBEFBPONKB<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter<DBLAAKPDHMG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x3D4A620", Offset = "0x3D49220", VA = "0x183D4A620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x3D4A900", Offset = "0x3D49500", VA = "0x183D4A900", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly ODKAGALBNKL<TData> KECKEMGGOHJ;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x3E93890", Offset = "0x3E92490", VA = "0x183E93890")]
	public IDBEFBPONKB(TData GNOKGDOBGOP, IReadOnlyList<TData> LDHAKBFGIBA, bool KBOEFGONAJK, JJKICNGMGPM<TData> LFPNEAKNDGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x3E93790", Offset = "0x3E92390", VA = "0x183E93790", Slot = "4")]
	[AsyncStateMachine(typeof(IDBEFBPONKB<>.GFFBKFJAOAG))]
	public override Task<DBLAAKPDHMG> INOEKLCMBOB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public struct ODKAGALBNKL<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public TData IGHFAFNCELM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public IReadOnlyList<TData> CPDJKMHMCPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public bool OONAPEKKEGN;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x46482F0", Offset = "0x4646EF0", VA = "0x1846482F0")]
	public ODKAGALBNKL(TData GNOKGDOBGOP, IReadOnlyList<TData> LDHAKBFGIBA, bool KBOEFGONAJK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface MIDPDADHMJD<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool INOEKLCMBOB([In] PBIHECIAJLF<TData> JGHKEFGDAFI);
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface HKOACJDMLEC<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void INOEKLCMBOB([In] IPDGBELDNAE<TData> JGHKEFGDAFI);
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface FFEKOBBNLCN<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EHLLCEGGPCC([In] CIILENMKLBB<TData> JGHKEFGDAFI);

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OLCEOFMHAED();
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class DICMPFDKICG<TData> : DBNHDBHBNJM<MIDPDADHMJD<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly PBIHECIAJLF<TData> JGHKEFGDAFI;

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x58A61F0", Offset = "0x58A4DF0", VA = "0x1858A61F0")]
	public DICMPFDKICG(IEnumerable<TData> KIFDDEHNJMO, HKBPBGOBHLL NMMFNOOBBFO, EDECMMJDBEJ DMGEDCGOKIM, float HJJLIEMBCMI, bool KBOEFGONAJK, MIDPDADHMJD<TData> LFPNEAKNDGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x3822950", Offset = "0x3821550", VA = "0x183822950", Slot = "4")]
	public override bool INOEKLCMBOB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class KNOIOLIHPKN<TData> : DBNHDBHBNJM<HKOACJDMLEC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly IPDGBELDNAE<TData> JGHKEFGDAFI;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x41CFE70", Offset = "0x41CEA70", VA = "0x1841CFE70")]
	public KNOIOLIHPKN(TData[] KIFDDEHNJMO, HKBPBGOBHLL[] NMMFNOOBBFO, EDECMMJDBEJ[] DMGEDCGOKIM, float[] HJJLIEMBCMI, HKOACJDMLEC<TData> LFPNEAKNDGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3DEF600", Offset = "0x3DEE200", VA = "0x183DEF600", Slot = "4")]
	public override bool INOEKLCMBOB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class DBHNKPJDAAN<TData> : DBNHDBHBNJM<FFEKOBBNLCN<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3846AE0", Offset = "0x38456E0", VA = "0x183846AE0")]
	public DBHNKPJDAAN(FFEKOBBNLCN<TData> LFPNEAKNDGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x587A060", Offset = "0x5878C60", VA = "0x18587A060", Slot = "4")]
	public override bool INOEKLCMBOB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class HPEPBPCBMPH<TData> : DBNHDBHBNJM<FFEKOBBNLCN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly CIILENMKLBB<TData> JGHKEFGDAFI;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3DEF6C0", Offset = "0x3DEE2C0", VA = "0x183DEF6C0")]
	public HPEPBPCBMPH(IEnumerable<TData> KIFDDEHNJMO, HKBPBGOBHLL NMMFNOOBBFO, EDECMMJDBEJ DMGEDCGOKIM, float HJJLIEMBCMI, FFEKOBBNLCN<TData> LFPNEAKNDGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3DEF600", Offset = "0x3DEE200", VA = "0x183DEF600", Slot = "4")]
	public override bool INOEKLCMBOB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public struct PBIHECIAJLF<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public IEnumerable<TData> MNPEAMBPLLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public HKBPBGOBHLL LNDJCPFPLEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public EDECMMJDBEJ HGAKPOFCKHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public float HJJLIEMBCMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public bool KBOEFGONAJK;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x47588E0", Offset = "0x47574E0", VA = "0x1847588E0")]
	public PBIHECIAJLF(IEnumerable<TData> KIFDDEHNJMO, HKBPBGOBHLL NMMFNOOBBFO, EDECMMJDBEJ DMGEDCGOKIM, float HJJLIEMBCMI, bool KBOEFGONAJK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct IPDGBELDNAE<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public TData[] MNPEAMBPLLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public HKBPBGOBHLL[] LNDJCPFPLEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public EDECMMJDBEJ[] HGAKPOFCKHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public float[] HJJLIEMBCMI;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3EC9BE0", Offset = "0x3EC87E0", VA = "0x183EC9BE0")]
	public IPDGBELDNAE(TData[] KIFDDEHNJMO, HKBPBGOBHLL[] NMMFNOOBBFO, EDECMMJDBEJ[] DMGEDCGOKIM, float[] HJJLIEMBCMI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public struct CIILENMKLBB<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public IEnumerable<TData> MNPEAMBPLLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public HKBPBGOBHLL LNDJCPFPLEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public EDECMMJDBEJ HGAKPOFCKHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public float HJJLIEMBCMI;

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x56719D0", Offset = "0x56705D0", VA = "0x1856719D0")]
	public CIILENMKLBB(IEnumerable<TData> KIFDDEHNJMO, HKBPBGOBHLL NMMFNOOBBFO, EDECMMJDBEJ DMGEDCGOKIM, float HJJLIEMBCMI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public interface KLMGBEKJIFC<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DGDHCCBPAAA([In] KNLMFHIPNKH<TData> EECKLMKLMAM);

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ENLFHEKAFAF([In] KNLMFHIPNKH<TData> EECKLMKLMAM);

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HDCHEOACMMJ([In] bool HHIDGKBFMPN);

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool INHJKEIGEBO([In] KNLMFHIPNKH<TData> EECKLMKLMAM);

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MPCNIBNIGHC();

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool BOELDBHLPOE([In] TData NCJHNAGJPHP);
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class HNMDGHJFNLA<TData> : DBNHDBHBNJM<KLMGBEKJIFC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly KNLMFHIPNKH<TData> EECKLMKLMAM;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x3DE9F50", Offset = "0x3DE8B50", VA = "0x183DE9F50")]
	public HNMDGHJFNLA(List<TData> JMDINDKMKCB, KLMGBEKJIFC<TData> LFPNEAKNDGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3822950", Offset = "0x3821550", VA = "0x183822950", Slot = "4")]
	public override bool INOEKLCMBOB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class FFEPMOCAFCO<TData> : DBNHDBHBNJM<KLMGBEKJIFC<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3846AE0", Offset = "0x38456E0", VA = "0x183846AE0")]
	public FFEPMOCAFCO(KLMGBEKJIFC<TData> LFPNEAKNDGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x3C116D0", Offset = "0x3C102D0", VA = "0x183C116D0", Slot = "4")]
	public override bool INOEKLCMBOB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class NLBGEKELFGI<TData> : DBNHDBHBNJM<KLMGBEKJIFC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly bool KBOEFGONAJK;

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x4522800", Offset = "0x4521400", VA = "0x184522800")]
	public NLBGEKELFGI(bool KBOEFGONAJK, KLMGBEKJIFC<TData> LFPNEAKNDGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x45227A0", Offset = "0x45213A0", VA = "0x1845227A0", Slot = "4")]
	public override bool INOEKLCMBOB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class BAFBLBJJMIC<TData> : DBNHDBHBNJM<KLMGBEKJIFC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly KNLMFHIPNKH<TData> EECKLMKLMAM;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x4E536B0", Offset = "0x4E522B0", VA = "0x184E536B0")]
	public BAFBLBJJMIC(List<TData> JMDINDKMKCB, bool KBOEFGONAJK, KLMGBEKJIFC<TData> LFPNEAKNDGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x448C2A0", Offset = "0x448AEA0", VA = "0x18448C2A0", Slot = "4")]
	public override bool INOEKLCMBOB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class KDPCBNHGIPD<TData> : DBNHDBHBNJM<KLMGBEKJIFC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly TData NCJHNAGJPHP;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x41A81E0", Offset = "0x41A6DE0", VA = "0x1841A81E0")]
	public KDPCBNHGIPD(TData NCJHNAGJPHP, KLMGBEKJIFC<TData> LFPNEAKNDGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x41A8120", Offset = "0x41A6D20", VA = "0x1841A8120", Slot = "4")]
	public override bool INOEKLCMBOB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class DCCEGINCLIJ<TData> : DBNHDBHBNJM<KLMGBEKJIFC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly KNLMFHIPNKH<TData> EECKLMKLMAM;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x587E3A0", Offset = "0x587CFA0", VA = "0x18587E3A0")]
	public DCCEGINCLIJ(IEnumerable<TData> JMDINDKMKCB, KLMGBEKJIFC<TData> LFPNEAKNDGE, bool KBOEFGONAJK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x587E2E0", Offset = "0x587CEE0", VA = "0x18587E2E0", Slot = "4")]
	public override bool INOEKLCMBOB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public struct KNLMFHIPNKH<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public IEnumerable<TData> MNPEAMBPLLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public bool KBOEFGONAJK;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x41CF080", Offset = "0x41CDC80", VA = "0x1841CF080")]
	public KNLMFHIPNKH(IEnumerable<TData> MGKHIJOEFHI, bool IBCJAJJEDEC = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public interface CJBALHIGKEJ
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<DBLAAKPDHMG> INOEKLCMBOB(EPAFKPBDPIE HNHBMJHEDNM);
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class AMMHHFCNELL : AEACOGLNCFO<CJBALHIGKEJ, DBLAAKPDHMG>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private struct DBGDPKLGGDB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public AsyncTaskMethodBuilder<DBLAAKPDHMG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public AMMHHFCNELL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private TaskAwaiter<DBLAAKPDHMG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6A10840", Offset = "0x6A0F440", VA = "0x186A10840", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6A10AB0", Offset = "0x6A0F6B0", VA = "0x186A10AB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly EPAFKPBDPIE KJLFHDDJLCH;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6A106C0", Offset = "0x6A0F2C0", VA = "0x186A106C0")]
	public AMMHHFCNELL(bool KBOEFGONAJK, CJBALHIGKEJ LFPNEAKNDGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6A105D0", Offset = "0x6A0F1D0", VA = "0x186A105D0", Slot = "4")]
	[AsyncStateMachine(typeof(DBGDPKLGGDB))]
	public override Task<DBLAAKPDHMG> INOEKLCMBOB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct EPAFKPBDPIE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public bool OONAPEKKEGN;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x217CC00", Offset = "0x217B800", VA = "0x18217CC00")]
	public EPAFKPBDPIE(bool KBOEFGONAJK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public readonly struct OJEJPIPEFML
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly bool LHPBMLMJBLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly bool CFCDBKGKMIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public readonly bool DANMJNNJDHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public readonly bool KBOEFGONAJK;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4D05F10", Offset = "0x4D04B10", VA = "0x184D05F10")]
	public OJEJPIPEFML(bool LHPBMLMJBLD, bool CFCDBKGKMIC, bool DANMJNNJDHD, bool KBOEFGONAJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6A11810", Offset = "0x6A10410", VA = "0x186A11810")]
	public OJEJPIPEFML(bool CFCDBKGKMIC, bool KBOEFGONAJK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface ADDEEICOBOI
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ACGBNCELAHH(OJEJPIPEFML IPGJHANJJOB);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NJFKNKGGHOJ(OJEJPIPEFML IPGJHANJJOB);
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class CHNAFDBCMPB : DBNHDBHBNJM<ADDEEICOBOI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly OJEJPIPEFML IPGJHANJJOB;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6A107B0", Offset = "0x6A0F3B0", VA = "0x186A107B0")]
	public CHNAFDBCMPB(bool MENBKJEFCNP, bool CFCDBKGKMIC, bool DANMJNNJDHD, bool KBOEFGONAJK, ADDEEICOBOI LFPNEAKNDGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6A10760", Offset = "0x6A0F360", VA = "0x186A10760", Slot = "4")]
	public override bool INOEKLCMBOB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class NFLLLIOADNJ : DBNHDBHBNJM<ADDEEICOBOI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly OJEJPIPEFML IPGJHANJJOB;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6A11710", Offset = "0x6A10310", VA = "0x186A11710")]
	public NFLLLIOADNJ(bool CFCDBKGKMIC, bool KBOEFGONAJK, ADDEEICOBOI LFPNEAKNDGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6A116C0", Offset = "0x6A102C0", VA = "0x186A116C0", Slot = "4")]
	public override bool INOEKLCMBOB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public interface PEJGFLPICHF
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void INOEKLCMBOB([In] OLPIKKCLOFN NMOLBFEGAJH);
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class KDAECMKJCAC : DBNHDBHBNJM<PEJGFLPICHF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly OLPIKKCLOFN NMOLBFEGAJH;

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6A10E80", Offset = "0x6A0FA80", VA = "0x186A10E80")]
	public KDAECMKJCAC(Guid[] AMJMPLNKBDA, Vector3[] ONOJCPMFEIG, Quaternion[] CKMPDNBPBMJ, float[] MANCPPKFKEC, Dictionary<Guid, Vector3> HMLJLFDGEKE, PEJGFLPICHF LFPNEAKNDGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6A10DD0", Offset = "0x6A0F9D0", VA = "0x186A10DD0", Slot = "4")]
	public override bool INOEKLCMBOB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public interface EBMNHEBLEBH<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CNNFICBJBPF([In] POAOMCBGBJB<TData> MNJMBIFMPOD);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EHLLCEGGPCC([In] MKPNJPGKGEC CMOLLAGJBMB);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool EHLLCEGGPCC([In] MJMJBGPMMLM CMOLLAGJBMB);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool OLCEOFMHAED();
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class OEOLOLANGKM<TData> : DBNHDBHBNJM<EBMNHEBLEBH<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x3846AE0", Offset = "0x38456E0", VA = "0x183846AE0")]
	public OEOLOLANGKM(EBMNHEBLEBH<TData> LFPNEAKNDGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x4654470", Offset = "0x4653070", VA = "0x184654470", Slot = "4")]
	public override bool INOEKLCMBOB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class AEBBPMDEDKD<TData> : DBNHDBHBNJM<EBMNHEBLEBH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly MKPNJPGKGEC CIHKEFHMFEE;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3CEA900", Offset = "0x3CE9500", VA = "0x183CEA900")]
	public AEBBPMDEDKD(Vector3 DNGJKKFGKGC, bool GGDJKLHEEGM, EBMNHEBLEBH<TData> LFPNEAKNDGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x382A270", Offset = "0x3828E70", VA = "0x18382A270", Slot = "4")]
	public override bool INOEKLCMBOB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class PKPEIIPODNE<TData> : DBNHDBHBNJM<EBMNHEBLEBH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly MJMJBGPMMLM CIHKEFHMFEE;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x47A5D70", Offset = "0x47A4970", VA = "0x1847A5D70")]
	public PKPEIIPODNE(Guid OGKBBPPFMBJ, int BAEBMIBABAE, Vector3 DCDKACDAEIJ, Quaternion GPEICHFGELO, float KBOADMDLFLD, bool GGDJKLHEEGM, EBMNHEBLEBH<TData> LFPNEAKNDGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x47A5D10", Offset = "0x47A4910", VA = "0x1847A5D10", Slot = "4")]
	public override bool INOEKLCMBOB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class OJMCBAFJGPM<TData> : DBNHDBHBNJM<EBMNHEBLEBH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly POAOMCBGBJB<TData> CIHKEFHMFEE;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x46A4350", Offset = "0x46A2F50", VA = "0x1846A4350")]
	public OJMCBAFJGPM(TData EEOLDJILHGA, bool KBOEFGONAJK, EBMNHEBLEBH<TData> LFPNEAKNDGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x3822950", Offset = "0x3821550", VA = "0x183822950", Slot = "4")]
	public override bool INOEKLCMBOB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public struct MKPNJPGKGEC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly Vector3 DNGJKKFGKGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public readonly bool GGDJKLHEEGM;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x6A116A0", Offset = "0x6A102A0", VA = "0x186A116A0")]
	public MKPNJPGKGEC(Vector3 DNGJKKFGKGC, bool GGDJKLHEEGM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public struct MJMJBGPMMLM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public readonly Guid OGKBBPPFMBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public readonly int BAEBMIBABAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public readonly Vector3 DCDKACDAEIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public readonly Quaternion GPEICHFGELO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public readonly float KBOADMDLFLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public readonly bool GGDJKLHEEGM;

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6A11660", Offset = "0x6A10260", VA = "0x186A11660")]
	public MJMJBGPMMLM(Guid OGKBBPPFMBJ, int BAEBMIBABAE, Vector3 DCDKACDAEIJ, Quaternion GPEICHFGELO, float KBOADMDLFLD, bool GGDJKLHEEGM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public struct POAOMCBGBJB<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public readonly TData EEOLDJILHGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public readonly bool KBOEFGONAJK;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x47AC440", Offset = "0x47AB040", VA = "0x1847AC440")]
	public POAOMCBGBJB(TData EEOLDJILHGA, bool KBOEFGONAJK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public interface LNLCPPAFHHF<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool INOEKLCMBOB([In] GGEOJGBKMEO<TData> BCMFMDPPNNO);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool INOEKLCMBOB([In] AEGGOLKAOJC<TData> BCMFMDPPNNO);
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public interface NIPLDBFDEKH<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CNNFICBJBPF([In] AIJOJIKPLHM<TData> DFJPNDIKCKN);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EHLLCEGGPCC([In] AMJLNGOPIOB CMOLLAGJBMB);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool OLCEOFMHAED();
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class JGEFCOJBGJE<TData> : DBNHDBHBNJM<LNLCPPAFHHF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly GGEOJGBKMEO<TData> BCMFMDPPNNO;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x4090830", Offset = "0x408F430", VA = "0x184090830")]
	public JGEFCOJBGJE(IEnumerable<TData> KIFDDEHNJMO, Vector3 LONNNHNDHMH, bool KBOEFGONAJK, LNLCPPAFHHF<TData> LFPNEAKNDGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x3822950", Offset = "0x3821550", VA = "0x183822950", Slot = "4")]
	public override bool INOEKLCMBOB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class CPODEAAOEIF<TData> : DBNHDBHBNJM<NIPLDBFDEKH<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x3846AE0", Offset = "0x38456E0", VA = "0x183846AE0")]
	public CPODEAAOEIF(NIPLDBFDEKH<TData> LFPNEAKNDGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x44640A0", Offset = "0x4462CA0", VA = "0x1844640A0", Slot = "4")]
	public override bool INOEKLCMBOB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class MHBBGBMKMIL<TData> : DBNHDBHBNJM<NIPLDBFDEKH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly AIJOJIKPLHM<TData> BCMFMDPPNNO;

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x448BC60", Offset = "0x448A860", VA = "0x18448BC60")]
	public MHBBGBMKMIL(IEnumerable<TData> KIFDDEHNJMO, bool KBOEFGONAJK, NIPLDBFDEKH<TData> LFPNEAKNDGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x3822950", Offset = "0x3821550", VA = "0x183822950", Slot = "4")]
	public override bool INOEKLCMBOB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class IEDDDDJPJFF<TData> : DBNHDBHBNJM<LNLCPPAFHHF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly AEGGOLKAOJC<TData> BCMFMDPPNNO;

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x3E975C0", Offset = "0x3E961C0", VA = "0x183E975C0")]
	public IEDDDDJPJFF(IEnumerable<TData> KIFDDEHNJMO, Vector3 BNGKJGEEDKC, EHNEJDFMAFL LCEEMPJCLIA, bool KBOEFGONAJK, LNLCPPAFHHF<TData> LFPNEAKNDGE, Space OAMLHMLPNJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3E97500", Offset = "0x3E96100", VA = "0x183E97500", Slot = "4")]
	public override bool INOEKLCMBOB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class DMFIEOHGDPI<TData> : DBNHDBHBNJM<NIPLDBFDEKH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly AMJLNGOPIOB BCMFMDPPNNO;

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x58D8310", Offset = "0x58D6F10", VA = "0x1858D8310")]
	public DMFIEOHGDPI(Vector3 LONNNHNDHMH, NIPLDBFDEKH<TData> LFPNEAKNDGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x382A270", Offset = "0x3828E70", VA = "0x18382A270", Slot = "4")]
	public override bool INOEKLCMBOB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct GGEOJGBKMEO<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public readonly IEnumerable<TData> KIFDDEHNJMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public readonly Vector3 LONNNHNDHMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public readonly bool KBOEFGONAJK;

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x3D4B430", Offset = "0x3D4A030", VA = "0x183D4B430")]
	public GGEOJGBKMEO(IEnumerable<TData> KIFDDEHNJMO, Vector3 LONNNHNDHMH, bool KBOEFGONAJK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct AIJOJIKPLHM<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public readonly IEnumerable<TData> KIFDDEHNJMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public readonly bool KBOEFGONAJK;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x3D14BB0", Offset = "0x3D137B0", VA = "0x183D14BB0")]
	public AIJOJIKPLHM(IEnumerable<TData> KIFDDEHNJMO, bool KBOEFGONAJK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct AEGGOLKAOJC<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public readonly IEnumerable<TData> KIFDDEHNJMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public readonly Vector3 BNGKJGEEDKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly EHNEJDFMAFL LCEEMPJCLIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public readonly bool KBOEFGONAJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly Space OAMLHMLPNJK;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x3CED1F0", Offset = "0x3CEBDF0", VA = "0x183CED1F0")]
	public AEGGOLKAOJC(IEnumerable<TData> KIFDDEHNJMO, Vector3 BNGKJGEEDKC, EHNEJDFMAFL LCEEMPJCLIA, bool KBOEFGONAJK, Space OAMLHMLPNJK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct AMJLNGOPIOB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public readonly Vector3 LONNNHNDHMH;

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x217EA10", Offset = "0x217D610", VA = "0x18217EA10")]
	public AMJLNGOPIOB(Vector3 LONNNHNDHMH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public enum EHNEJDFMAFL
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
public interface LJFMEGGNCKC
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool INOEKLCMBOB([In] OIPIEEJGJIA CHLOHJNJPFJ);
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public class DGEFEKBEHFP : DBNHDBHBNJM<LJFMEGGNCKC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly OIPIEEJGJIA CHLOHJNJPFJ;

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6A10BD0", Offset = "0x6A0F7D0", VA = "0x186A10BD0")]
	public DGEFEKBEHFP(bool KBOEFGONAJK, LJFMEGGNCKC LFPNEAKNDGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6A10B20", Offset = "0x6A0F720", VA = "0x186A10B20", Slot = "4")]
	public override bool INOEKLCMBOB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public readonly struct OIPIEEJGJIA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public readonly bool KBOEFGONAJK;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x217CC00", Offset = "0x217B800", VA = "0x18217CC00")]
	public OIPIEEJGJIA(bool KBOEFGONAJK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public interface PCPAPJBBNED<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool INOEKLCMBOB([In] FFFLIIOHMNL<TData> ENJFAMDHKPB);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool INOEKLCMBOB([In] LBJEKEDGBKD<TData> ENJFAMDHKPB);
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public interface DCINKFAGEMC<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CNNFICBJBPF([In] DFNALFCBBCF<TData> MNJMBIFMPOD);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EHLLCEGGPCC([In] JKIJMPBMIGG CMOLLAGJBMB);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool OLCEOFMHAED();
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class LMBNFPEGFBO<TData> : DBNHDBHBNJM<PCPAPJBBNED<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly FFFLIIOHMNL<TData> ENJFAMDHKPB;

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x4287C60", Offset = "0x4286860", VA = "0x184287C60")]
	public LMBNFPEGFBO(IEnumerable<TData> KIFDDEHNJMO, Quaternion LONNNHNDHMH, Vector3? IIKODPOMIBN, bool BCBGGLGAACE, bool KBOEFGONAJK, PCPAPJBBNED<TData> LFPNEAKNDGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x3822950", Offset = "0x3821550", VA = "0x183822950", Slot = "4")]
	public override bool INOEKLCMBOB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class DLDCFICEOCP<TData> : DBNHDBHBNJM<DCINKFAGEMC<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x3846AE0", Offset = "0x38456E0", VA = "0x183846AE0")]
	public DLDCFICEOCP(DCINKFAGEMC<TData> LFPNEAKNDGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x44640A0", Offset = "0x4462CA0", VA = "0x1844640A0", Slot = "4")]
	public override bool INOEKLCMBOB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class JHAFHCNMGAM<TData> : DBNHDBHBNJM<DCINKFAGEMC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly DFNALFCBBCF<TData> ENJFAMDHKPB;

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x40922A0", Offset = "0x4090EA0", VA = "0x1840922A0")]
	public JHAFHCNMGAM(IEnumerable<TData> KIFDDEHNJMO, bool KBOEFGONAJK, DCINKFAGEMC<TData> LFPNEAKNDGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x3822950", Offset = "0x3821550", VA = "0x183822950", Slot = "4")]
	public override bool INOEKLCMBOB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class LGEKPANIAKO<TData> : DBNHDBHBNJM<PCPAPJBBNED<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly LBJEKEDGBKD<TData> ENJFAMDHKPB;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x4258800", Offset = "0x4257400", VA = "0x184258800")]
	public LGEKPANIAKO(IEnumerable<TData> KIFDDEHNJMO, Quaternion ELLKBNBKBOH, EHNEJDFMAFL AKAJNICACBP, Vector3? IIKODPOMIBN, bool BCBGGLGAACE, bool KBOEFGONAJK, Space OAMLHMLPNJK, PCPAPJBBNED<TData> LFPNEAKNDGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x3E97500", Offset = "0x3E96100", VA = "0x183E97500", Slot = "4")]
	public override bool INOEKLCMBOB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class LIFKPGCKLCB<TData> : DBNHDBHBNJM<DCINKFAGEMC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly JKIJMPBMIGG ENJFAMDHKPB;

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x4277A10", Offset = "0x4276610", VA = "0x184277A10")]
	public LIFKPGCKLCB(Quaternion LONNNHNDHMH, Vector3? IIKODPOMIBN, bool BCBGGLGAACE, DCINKFAGEMC<TData> LFPNEAKNDGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x382A270", Offset = "0x3828E70", VA = "0x18382A270", Slot = "4")]
	public override bool INOEKLCMBOB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public struct FFFLIIOHMNL<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public readonly IEnumerable<TData> KIFDDEHNJMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public readonly Quaternion LONNNHNDHMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public readonly Vector3? IIKODPOMIBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public readonly bool BCBGGLGAACE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public readonly bool KBOEFGONAJK;

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x3C11720", Offset = "0x3C10320", VA = "0x183C11720")]
	public FFFLIIOHMNL(IEnumerable<TData> KIFDDEHNJMO, Quaternion LONNNHNDHMH, Vector3? IIKODPOMIBN, bool BCBGGLGAACE, bool KBOEFGONAJK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public struct DFNALFCBBCF<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public readonly IEnumerable<TData> KIFDDEHNJMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly bool KBOEFGONAJK;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x5896DE0", Offset = "0x58959E0", VA = "0x185896DE0")]
	public DFNALFCBBCF(IEnumerable<TData> KIFDDEHNJMO, bool KBOEFGONAJK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public struct LBJEKEDGBKD<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public readonly IEnumerable<TData> KIFDDEHNJMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public readonly Quaternion ELLKBNBKBOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public readonly EHNEJDFMAFL AKAJNICACBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public readonly Vector3? IIKODPOMIBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public readonly bool BCBGGLGAACE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public readonly bool KBOEFGONAJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public readonly Space OAMLHMLPNJK;

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x4245720", Offset = "0x4244320", VA = "0x184245720")]
	public LBJEKEDGBKD(IEnumerable<TData> KIFDDEHNJMO, Quaternion ELLKBNBKBOH, EHNEJDFMAFL AKAJNICACBP, Vector3? IIKODPOMIBN, bool BCBGGLGAACE, bool KBOEFGONAJK, Space OAMLHMLPNJK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public struct JKIJMPBMIGG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public readonly Quaternion LONNNHNDHMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public readonly Vector3? IIKODPOMIBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public readonly bool BCBGGLGAACE;

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x4CC9A50", Offset = "0x4CC8650", VA = "0x184CC9A50")]
	public JKIJMPBMIGG(Quaternion LONNNHNDHMH, Vector3? IIKODPOMIBN, bool BCBGGLGAACE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public interface CLCEFFOBLNM<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CNNFICBJBPF([In] JMPLMABFNEJ<TData> MNJMBIFMPOD);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EHLLCEGGPCC([In] OJHDEIOGLJG CMOLLAGJBMB);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool EHLLCEGGPCC([In] GGAMIGHNCLI CMOLLAGJBMB);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool EHLLCEGGPCC([In] ANLMHALMPDJ CMOLLAGJBMB);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool OLCEOFMHAED();
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public class ANAFGKKFDDF<TData> : DBNHDBHBNJM<CLCEFFOBLNM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly ANLMHALMPDJ LECBLJIOLKF;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x3D40C30", Offset = "0x3D3F830", VA = "0x183D40C30")]
	public ANAFGKKFDDF(Vector3 GKJKPKCGDCO, float GMIJCBEMLNL, Vector3 IIKODPOMIBN, bool LMFGMJOPOFB, bool LMANCFCEMFF, CLCEFFOBLNM<TData> LFPNEAKNDGE, Space OAMLHMLPNJK = Space.Self)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x3D40BD0", Offset = "0x3D3F7D0", VA = "0x183D40BD0", Slot = "4")]
	public override bool INOEKLCMBOB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public class DAJAIHLLDHF<TData> : DBNHDBHBNJM<CLCEFFOBLNM<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x3846AE0", Offset = "0x38456E0", VA = "0x183846AE0")]
	public DAJAIHLLDHF(CLCEFFOBLNM<TData> LFPNEAKNDGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x5879A30", Offset = "0x5878630", VA = "0x185879A30", Slot = "4")]
	public override bool INOEKLCMBOB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class BNLEBNCIJIF<TData> : DBNHDBHBNJM<CLCEFFOBLNM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly JMPLMABFNEJ<TData> LECBLJIOLKF;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x4EB9E10", Offset = "0x4EB8A10", VA = "0x184EB9E10")]
	public BNLEBNCIJIF(IEnumerable<TData> KIFDDEHNJMO, bool KBOEFGONAJK, CLCEFFOBLNM<TData> LFPNEAKNDGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x3822950", Offset = "0x3821550", VA = "0x183822950", Slot = "4")]
	public override bool INOEKLCMBOB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class IHECFPKGCOH<TData> : DBNHDBHBNJM<CLCEFFOBLNM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly GGAMIGHNCLI LECBLJIOLKF;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x3EA9E00", Offset = "0x3EA8A00", VA = "0x183EA9E00")]
	public IHECFPKGCOH(float AHLJKKIJOAF, bool CPCJMCLBENK, Vector3 IIKODPOMIBN, CLCEFFOBLNM<TData> LFPNEAKNDGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x3EA9D40", Offset = "0x3EA8940", VA = "0x183EA9D40", Slot = "4")]
	public override bool INOEKLCMBOB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class EBPNKOJLPDG<TData> : DBNHDBHBNJM<CLCEFFOBLNM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly OJHDEIOGLJG LECBLJIOLKF;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x382A2D0", Offset = "0x3828ED0", VA = "0x18382A2D0")]
	public EBPNKOJLPDG(float GMIJCBEMLNL, Vector3 IIKODPOMIBN, CLCEFFOBLNM<TData> LFPNEAKNDGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x382A270", Offset = "0x3828E70", VA = "0x18382A270", Slot = "4")]
	public override bool INOEKLCMBOB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public struct ANLMHALMPDJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public readonly Vector3 GKJKPKCGDCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public readonly float GMIJCBEMLNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public readonly Vector3 IIKODPOMIBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public readonly bool GGDJKLHEEGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public readonly Space OAMLHMLPNJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public readonly bool LMANCFCEMFF;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x6A10720", Offset = "0x6A0F320", VA = "0x186A10720")]
	public ANLMHALMPDJ(Vector3 GKJKPKCGDCO, float GMIJCBEMLNL, Vector3 IIKODPOMIBN, bool GGDJKLHEEGM, bool KOHGOPFOOPF, Space OAMLHMLPNJK = Space.Self)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public struct JMPLMABFNEJ<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public readonly IEnumerable<TData> KIFDDEHNJMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public readonly bool KBOEFGONAJK;

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x40D3670", Offset = "0x40D2270", VA = "0x1840D3670")]
	public JMPLMABFNEJ(IEnumerable<TData> KIFDDEHNJMO, bool KBOEFGONAJK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct GGAMIGHNCLI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public readonly float AHLJKKIJOAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public readonly bool CPCJMCLBENK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public readonly Vector3 IIKODPOMIBN;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x6A10C30", Offset = "0x6A0F830", VA = "0x186A10C30")]
	public GGAMIGHNCLI(float AHLJKKIJOAF, bool CPCJMCLBENK, Vector3 IIKODPOMIBN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public struct OJHDEIOGLJG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public readonly float GMIJCBEMLNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public readonly Vector3 IIKODPOMIBN;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x4CA00F0", Offset = "0x4C9ECF0", VA = "0x184CA00F0")]
	public OJHDEIOGLJG(float GMIJCBEMLNL, Vector3 IIKODPOMIBN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct OLPIKKCLOFN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public readonly Guid[] KIFDDEHNJMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public readonly bool ENCINOMDKAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public readonly bool JJBENCAMJCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public readonly bool KPCEONHMLDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public readonly Vector3[] ONOJCPMFEIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public readonly Quaternion[] CKMPDNBPBMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly float[] MANCPPKFKEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public readonly Dictionary<Guid, Vector3> HMLJLFDGEKE;

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6A119F0", Offset = "0x6A105F0", VA = "0x186A119F0")]
	public OLPIKKCLOFN(Guid[] AMJMPLNKBDA, Vector3[] ONOJCPMFEIG, Quaternion[] CKMPDNBPBMJ, float[] MANCPPKFKEC, Dictionary<Guid, Vector3> HMLJLFDGEKE, bool ENCINOMDKAN = true, bool JJBENCAMJCJ = true, bool KPCEONHMLDI = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x6A11820", Offset = "0x6A10420", VA = "0x186A11820")]
	private static void KDJCCOLJFKA(Dictionary<Guid, Vector3> HMLJLFDGEKE, int LLKBEFFGGNM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public static class KPNHJIJHJMH
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	private struct LNJBKLIAGAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public bool MAOOCKPMCCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public IMEOEBHKJNP OOOIPIFJPBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public IMEOEBHKJNP EDFCLEIDAOD;
	}

	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private static LNJBKLIAGAF JNANGBGALNN;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static CancellationToken LBCCJNPCCPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x6A11380", Offset = "0x6A0FF80", VA = "0x186A11380")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	internal static IMEOEBHKJNP OOOIPIFJPBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x6A11290", Offset = "0x6A0FE90", VA = "0x186A11290")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6A113A0", Offset = "0x6A0FFA0", VA = "0x186A113A0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6A11560", Offset = "0x6A10160", VA = "0x186A11560")]
	[DHOHFCLMOGD(OBGPNJNCONH.Room, IDHBAGABJJA.None)]
	private static void PNCOJBGCPOD(IMEOEBHKJNP DFBNHBPCGGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6A11410", Offset = "0x6A10010", VA = "0x186A11410")]
	public static void LEJCELDJPNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6A11330", Offset = "0x6A0FF30", VA = "0x186A11330")]
	private static IMEOEBHKJNP ECHBFCLBGHF(IMEOEBHKJNP OKGJNNFLBCE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public static class IKJCHGOLPBC
{
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public enum NJGCMJJLKEH
	{
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		ICreationContextObject,
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		Guid
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x2B7DDE0", Offset = "0x2B7C9E0", VA = "0x182B7DDE0")]
	public static void NNONMLNBFBI<T>(T AGABHBIFGBH, NJGCMJJLKEH HGPIKDLKBHO) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x2B7DF40", Offset = "0x2B7CB40", VA = "0x182B7DF40")]
	public static void NNONMLNBFBI<T>(T AGABHBIFGBH) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x2B7E060", Offset = "0x2B7CC60", VA = "0x182B7E060")]
	public static void PILFCBOMFOE<T>(T AGABHBIFGBH) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x2B7DFB0", Offset = "0x2B7CBB0", VA = "0x182B7DFB0")]
	public static T OIPGNBHOLEB<T>(NJGCMJJLKEH HGPIKDLKBHO) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x2B7DC90", Offset = "0x2B7C890", VA = "0x182B7DC90")]
	public static bool LPJAHGPAPEL<T>(NJGCMJJLKEH HGPIKDLKBHO, T? MNALMKGIPME, [Out][NotNullWhen(true)][MaybeNullWhen(false)] T OLENEPKHFIL) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x2B7DAD0", Offset = "0x2B7C6D0", VA = "0x182B7DAD0")]
	public static bool HLGNJKNNJGO<T>(NJGCMJJLKEH HGPIKDLKBHO) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x2B7DB80", Offset = "0x2B7C780", VA = "0x182B7DB80")]
	public static T OIPGNBHOLEB<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x2B7DBE0", Offset = "0x2B7C7E0", VA = "0x182B7DBE0")]
	public static bool LPJAHGPAPEL<T>(T MNALMKGIPME, [Out] T OLENEPKHFIL) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x2B7DB80", Offset = "0x2B7C780", VA = "0x182B7DB80")]
	public static bool HLGNJKNNJGO<T>() where T : class
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
internal static class KPFOKOIJCDP
{
	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6A11060", Offset = "0x6A0FC60", VA = "0x186A11060")]
	public static void KJCLOCFBDOP(IEnumerable HABCIGFGFHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x2BF9BF0", Offset = "0x2BF87F0", VA = "0x182BF9BF0")]
	public static void KJCLOCFBDOP<T>(T[] DKCMKELIAPN) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x2BF9DD0", Offset = "0x2BF89D0", VA = "0x182BF9DD0")]
	public static void KJCLOCFBDOP<T>(T CLDDKGECHDK) where T : notnull, Enum
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
