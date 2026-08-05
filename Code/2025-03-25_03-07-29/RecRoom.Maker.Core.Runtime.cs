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
		[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
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
		[Cpp2IlInjected.Address(RVA = "0x786D720", Offset = "0x786CB20", VA = "0x18786D720")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9BC6F0", Offset = "0x9BBAF0", VA = "0x1809BC6F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9BC730", Offset = "0x9BBB30", VA = "0x1809BC730")]
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
		[Cpp2IlInjected.Address(RVA = "0x786DA30", Offset = "0x786CE30", VA = "0x18786DA30", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x251F7B0", Offset = "0x251EBB0", VA = "0x18251F7B0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface KEHJAKEMAKF<TData, TReturn>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TReturn KPKGLAPLLDN(TData HAPOBHMBDHP);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface MMCAPNPFJFL<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ClearHoverTarget(EFCDGBGJIMI ILHPOMGPKLE);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool SetHoverTarget(TData JMBMDICGCNK, Collider CPBHAFIKCEO, EFCDGBGJIMI ILHPOMGPKLE, [Optional] LCELNNMJEBA? FOGHKFAFLAL);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool TryGetHoverTarget([Out] TData JMBMDICGCNK);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetHoverCollider([Out] Collider CPBHAFIKCEO);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface FCLADBDHGAB<TData> : IGHGLNHIMNB, OABPEEIGMOD<TData>, EFCIAAACKPC<TData>, LGIGCCJFIMM<TData>, JOMNEAJOKII, IIPPJAOAKCP<TData>, LIKLJOHEINI, CCIAELMOFJA
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface IIPPJAOAKCP<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 JBAEEIKJKPJ, Vector3 DLBKBBJEBDD, float DIHBFHDIEJB, [Out] T NGFIMKEAMPL, [Out] Vector3 IDIIOGOMDHM, [Out] Collider CPBHAFIKCEO);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 JBAEEIKJKPJ, Vector3 DLBKBBJEBDD, float CJPPMDIDMBD, float DIHBFHDIEJB, T[] BGBAKOPHBFJ, [Out] Vector3 OFBLIBMGPGN, [Out] Collider IIGPOHAMDPI);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 JBAEEIKJKPJ, float CJPPMDIDMBD, Vector3 CNHMMCDOPCG, T[] BGBAKOPHBFJ);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetObjectFromColliderInCurrentScope(Collider GMANAPIKCEP, [Out] T MJABADDGLDP);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface IGHGLNHIMNB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Bounds IHPIAKODCLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Transform CMBFGCHDINC
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Bounds IHFHGLFKBAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Transform IIKBJDJEOCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Vector3 JMENIJPHMPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool HKNLEGBMPPI
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
	void SetSelectionBoundsDirty(bool GHIKMLOBACO = true, int EADJNCLBOIO = 0);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ShouldHideSelectionBoundsPreview(bool ONCKJAHOIPH, object HEJFDMJNIGB);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface CCIAELMOFJA
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	OLDENIALAEA JOJDBEEFCEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface LANBCKDEJCG
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool JJNOOLHJLMG
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool INLDMHFJPPL
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool JBHFJNENOIE
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
	void TrySetPreviousCloneMapping(Dictionary<Guid, Guid> FBNLNOAMMFL);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface LGIGCCJFIMM<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool EGAEDNOLNFA
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int CNHOGHAINME
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<TData> JPKMIANLCOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData DENKIGKMPCB);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData DENKIGKMPCB);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface OABPEEIGMOD<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T HAPOBHMBDHP, [Optional] LCELNNMJEBA? JHMECDIEDJJ, bool MGIGNAHECBI = true);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int PPLOBPJCNII, IEnumerable<T> HDDHAKEIJGE, bool MGIGNAHECBI = true);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int PPLOBPJCNII, IEnumerable<T> HDDHAKEIJGE, LCELNNMJEBA JHMECDIEDJJ, bool MGIGNAHECBI = true);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface LIKLJOHEINI
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface JOMNEAJOKII
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool HJHGCOHEBJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool NCHFFPOPBPN
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool MLBALEHIOKP
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool FJEKHPGJHFM
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct NEEGDAMCDPD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public bool DHBELELIAHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public float? BLLNGBPAIHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public float? FHFGFJAMFFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public float? LLNBGDEIHIM;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct GOKIKLKMOLE<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public IEnumerable<TData> IDJPMMJGOAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public NEEGDAMCDPD CCBEBJGPMON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public bool OMDMBKKCEFG;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x483A9E0", Offset = "0x4839DE0", VA = "0x18483A9E0")]
	public GOKIKLKMOLE(IEnumerable<TData> GEFHOPLLDEK, bool NJDHLFEJPDH, float? IKGKHMMLOHM, float? IAJIOGCMJAG, float? JCKFHKFDMFD, bool OMDMBKKCEFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface JDBCIDNCEDB<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MKBKFOOCCNJ([In] GOKIKLKMOLE<TData> JOIGLCNPHIH);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class CLHMJIHKNKN<TData> : MBCMFHMCCBJ<JDBCIDNCEDB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly GOKIKLKMOLE<TData> JOIGLCNPHIH;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x62116C0", Offset = "0x6210AC0", VA = "0x1862116C0")]
	public CLHMJIHKNKN(IEnumerable<TData> GEFHOPLLDEK, bool NJDHLFEJPDH, float? IKGKHMMLOHM, float? IAJIOGCMJAG, float? JCKFHKFDMFD, bool OMDMBKKCEFG, JDBCIDNCEDB<TData> LPKAAAAGEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x41F44C0", Offset = "0x41F38C0", VA = "0x1841F44C0", Slot = "4")]
	public override bool MKBKFOOCCNJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct DNPPFLIGFAO<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public IEnumerable<TData> IDJPMMJGOAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public string EINCAKCDBKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public bool GOOPPKKNANK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public bool OMDMBKKCEFG;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x65FFA10", Offset = "0x65FEE10", VA = "0x1865FFA10")]
	public DNPPFLIGFAO(IEnumerable<TData> GEFHOPLLDEK, string CFKIPPLHIHC, bool EBMDINIDNJI, bool OMDMBKKCEFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface KKIEBCLILKA<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MKBKFOOCCNJ([In] DNPPFLIGFAO<TData> JOIGLCNPHIH);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class CGPOLJFGNDD<TData> : MBCMFHMCCBJ<KKIEBCLILKA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly DNPPFLIGFAO<TData> JOIGLCNPHIH;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x613AE90", Offset = "0x613A290", VA = "0x18613AE90")]
	public CGPOLJFGNDD(IEnumerable<TData> GEFHOPLLDEK, string CFKIPPLHIHC, bool EBMDINIDNJI, bool OMDMBKKCEFG, KKIEBCLILKA<TData> LPKAAAAGEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x41F44C0", Offset = "0x41F38C0", VA = "0x1841F44C0", Slot = "4")]
	public override bool MKBKFOOCCNJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public abstract class MBCMFHMCCBJ<TReceiver> : EECENDFLKGG<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4202E80", Offset = "0x4202280", VA = "0x184202E80")]
	public MBCMFHMCCBJ(TReceiver LPKAAAAGEAF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public abstract class JOADKFGHHPL<TReceiver, TFromTask> : EECENDFLKGG<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4202E80", Offset = "0x4202280", VA = "0x184202E80")]
	public JOADKFGHHPL(TReceiver LPKAAAAGEAF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public abstract class EECENDFLKGG<TReceiver, TFromExecute> where TReceiver : notnull where TFromExecute : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	protected TReceiver LPKAAAAGEAF;

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x426D740", Offset = "0x426CB40", VA = "0x18426D740")]
	public EECENDFLKGG(TReceiver LPKAAAAGEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute MKBKFOOCCNJ();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class JLGJHELMBPG<TReceiver, TResult> : EECENDFLKGG<TReceiver, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4202E80", Offset = "0x4202280", VA = "0x184202E80")]
	public JLGJHELMBPG(TReceiver LPKAAAAGEAF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct NNIPFMJDMOE<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public TGroup DMBCGMMCBFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public TData IDLPANKNPBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public IEnumerable<TData> IDJPMMJGOAF;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2530340", Offset = "0x252F740", VA = "0x182530340")]
	public NNIPFMJDMOE(TGroup FLGLLABOOIB, TData BNAFAPHDNHH, IEnumerable<TData> GEFHOPLLDEK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct KLAKFKEKFIF<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public TGroup DMBCGMMCBFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public IEnumerable<TData> IDJPMMJGOAF;

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x9F9CA0", Offset = "0x9F90A0", VA = "0x1809F9CA0")]
	public KLAKFKEKFIF(TGroup FLGLLABOOIB, IEnumerable<TData> GEFHOPLLDEK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct OENDNDBPOPI<TGroup> where TGroup : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public TGroup DMBCGMMCBFL;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0xC67CE0", Offset = "0xC670E0", VA = "0x180C67CE0")]
	public OENDNDBPOPI(TGroup FLGLLABOOIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct JONCLNOCAAM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public IEnumerable<Guid> IDJPMMJGOAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public Guid ILHAGLDKHAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public readonly bool OMJDPKDKKKH;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x786CA90", Offset = "0x786BE90", VA = "0x18786CA90")]
	public JONCLNOCAAM(IEnumerable<Guid> GEFHOPLLDEK, Guid ICMHLAFAMCB, bool OMDMBKKCEFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct BBCKBOMDCMA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public Guid ILHAGLDKHAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly bool OMJDPKDKKKH;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2418E90", Offset = "0x2418290", VA = "0x182418E90")]
	public BBCKBOMDCMA(Guid ICMHLAFAMCB, bool OMDMBKKCEFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface BJNJAIEKJHM<TGroup, TData>
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KOKHMACPHAG KGNIJHELKPE(NNIPFMJDMOE<TGroup, TData> CNAOKMHMBDP);

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KOKHMACPHAG LGKMDCLILGF(NNIPFMJDMOE<TGroup, TData> CNAOKMHMBDP);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "2")]
	KOKHMACPHAG PIKNLDJBOFJ(KLAKFKEKFIF<TGroup, TData> CNAOKMHMBDP);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "3")]
	KOKHMACPHAG OLBCECMJMFF(OENDNDBPOPI<TGroup> CNAOKMHMBDP);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface PDAOANEKFFC
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<KOKHMACPHAG> KGNIJHELKPE(JONCLNOCAAM CNAOKMHMBDP);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<KOKHMACPHAG> LGKMDCLILGF(BBCKBOMDCMA CNAOKMHMBDP);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class LLKPMKCPHNC<TGroup, TData> : JLGJHELMBPG<BJNJAIEKJHM<TGroup, TData>, KOKHMACPHAG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly KLAKFKEKFIF<TGroup, TData> CNAOKMHMBDP;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x4D900E0", Offset = "0x4D8F4E0", VA = "0x184D900E0")]
	public LLKPMKCPHNC(TGroup FLGLLABOOIB, IEnumerable<TData> GEFHOPLLDEK, BJNJAIEKJHM<TGroup, TData> LPKAAAAGEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x4D90010", Offset = "0x4D8F410", VA = "0x184D90010", Slot = "4")]
	public override KOKHMACPHAG MKBKFOOCCNJ()
	{
		return default(KOKHMACPHAG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class FFGGPMDEJCE<TGroup, TData> : JLGJHELMBPG<BJNJAIEKJHM<TGroup, TData>, KOKHMACPHAG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly NNIPFMJDMOE<TGroup, TData> CNAOKMHMBDP;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x46CC190", Offset = "0x46CB590", VA = "0x1846CC190")]
	public FFGGPMDEJCE(TGroup FLGLLABOOIB, TData OMBOMGNJNFA, IEnumerable<TData> GEFHOPLLDEK, BJNJAIEKJHM<TGroup, TData> LPKAAAAGEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x46CC0C0", Offset = "0x46CB4C0", VA = "0x1846CC0C0", Slot = "4")]
	public override KOKHMACPHAG MKBKFOOCCNJ()
	{
		return default(KOKHMACPHAG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class ALJIDECHPFN<TGroup, TData> : JLGJHELMBPG<BJNJAIEKJHM<TGroup, TData>, KOKHMACPHAG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly OENDNDBPOPI<TGroup> CNAOKMHMBDP;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x4A10010", Offset = "0x4A0F410", VA = "0x184A10010")]
	public ALJIDECHPFN(TGroup FLGLLABOOIB, BJNJAIEKJHM<TGroup, TData> LPKAAAAGEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x4A0FF40", Offset = "0x4A0F340", VA = "0x184A0FF40", Slot = "4")]
	public override KOKHMACPHAG MKBKFOOCCNJ()
	{
		return default(KOKHMACPHAG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class PLNOGMMKGJD<TGroup, TData> : JLGJHELMBPG<BJNJAIEKJHM<TGroup, TData>, KOKHMACPHAG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly NNIPFMJDMOE<TGroup, TData> CNAOKMHMBDP;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x46CC190", Offset = "0x46CB590", VA = "0x1846CC190")]
	public PLNOGMMKGJD(TGroup FLGLLABOOIB, TData BNAFAPHDNHH, IEnumerable<TData> GEFHOPLLDEK, BJNJAIEKJHM<TGroup, TData> LPKAAAAGEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x52EE420", Offset = "0x52ED820", VA = "0x1852EE420", Slot = "4")]
	public override KOKHMACPHAG MKBKFOOCCNJ()
	{
		return default(KOKHMACPHAG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class FJGFFKPNLBG : JOADKFGHHPL<PDAOANEKFFC, KOKHMACPHAG>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct KMLIDMJFBCP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public AsyncTaskMethodBuilder<KOKHMACPHAG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public FJGFFKPNLBG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private TaskAwaiter<KOKHMACPHAG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x786CC80", Offset = "0x786C080", VA = "0x18786CC80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x786CF20", Offset = "0x786C320", VA = "0x18786CF20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private JONCLNOCAAM CNAOKMHMBDP;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x786C1C0", Offset = "0x786B5C0", VA = "0x18786C1C0")]
	public FJGFFKPNLBG(IEnumerable<Guid> FMOIGMBNOMJ, Guid ICMHLAFAMCB, bool OMDMBKKCEFG, PDAOANEKFFC LPKAAAAGEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x786C0D0", Offset = "0x786B4D0", VA = "0x18786C0D0", Slot = "4")]
	[AsyncStateMachine(typeof(KMLIDMJFBCP))]
	public override Task<KOKHMACPHAG> MKBKFOOCCNJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class KAMAIDCCABN : JOADKFGHHPL<PDAOANEKFFC, KOKHMACPHAG>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private struct NFEANBKAEGA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public AsyncTaskMethodBuilder<KOKHMACPHAG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public KAMAIDCCABN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private TaskAwaiter<KOKHMACPHAG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x786D410", Offset = "0x786C810", VA = "0x18786D410", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x786D6B0", Offset = "0x786CAB0", VA = "0x18786D6B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly BBCKBOMDCMA CNAOKMHMBDP;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x786CBC0", Offset = "0x786BFC0", VA = "0x18786CBC0")]
	public KAMAIDCCABN(Guid ICMHLAFAMCB, bool OMDMBKKCEFG, PDAOANEKFFC LPKAAAAGEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x786CAD0", Offset = "0x786BED0", VA = "0x18786CAD0", Slot = "4")]
	[AsyncStateMachine(typeof(NFEANBKAEGA))]
	public override Task<KOKHMACPHAG> MKBKFOOCCNJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public readonly struct IOBELOFEKMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly CNKHCLIKKJD MMCLNIADFED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly bool OMJDPKDKKKH;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x786C840", Offset = "0x786BC40", VA = "0x18786C840")]
	public IOBELOFEKMG(CNKHCLIKKJD CLJAHKGPKEG, bool OMDMBKKCEFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface KFLFMGHGGEA<TSpawnType> where TSpawnType : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> MKBKFOOCCNJ(IOBELOFEKMG JMFGFLHGCGD);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class OMMOJKGJDKP<TSpawnType> : JOADKFGHHPL<KFLFMGHGGEA<TSpawnType>, TSpawnType> where TSpawnType : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct FLICPFHLEMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public AsyncTaskMethodBuilder<TSpawnType> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public OMMOJKGJDKP<TSpawnType> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private TaskAwaiter<TSpawnType> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x4701AE0", Offset = "0x4700EE0", VA = "0x184701AE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x46D7510", Offset = "0x46D6910", VA = "0x1846D7510", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly IOBELOFEKMG JMFGFLHGCGD;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x51E9A10", Offset = "0x51E8E10", VA = "0x1851E9A10")]
	public OMMOJKGJDKP(CNKHCLIKKJD CLJAHKGPKEG, bool OMDMBKKCEFG, KFLFMGHGGEA<TSpawnType> LPKAAAAGEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x51E9710", Offset = "0x51E8B10", VA = "0x1851E9710", Slot = "4")]
	[AsyncStateMachine(typeof(OMMOJKGJDKP<>.FLICPFHLEMI))]
	public override Task<TSpawnType> MKBKFOOCCNJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct CNKHCLIKKJD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public readonly bool EFOPKOBOMLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly Vector3 DNKFDLGOHOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly Vector3 CPGAKMJDLGB;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x786BFB0", Offset = "0x786B3B0", VA = "0x18786BFB0")]
	public CNKHCLIKKJD(Transform CGKCLNDOGGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x786C0A0", Offset = "0x786B4A0", VA = "0x18786C0A0")]
	public CNKHCLIKKJD(Vector3 HAKFDJFOEPG, Vector3 JPKKPDPLAGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x786BF80", Offset = "0x786B380", VA = "0x18786BF80")]
	public static CNKHCLIKKJD IONOGFBINFL()
	{
		return default(CNKHCLIKKJD);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x786C020", Offset = "0x786B420", VA = "0x18786C020")]
	private CNKHCLIKKJD(bool EPHIICPEKEG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct MDLMNPIIODK<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public TNode NIPPAFIJHAA;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x4F68D50", Offset = "0x4F68150", VA = "0x184F68D50")]
	public MDLMNPIIODK(TNode NIPPAFIJHAA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct ENMKLHIOBLI<TNode, TReparentOperations> where TNode : notnull where TReparentOperations : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public TNode GHPFBFMCBLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public TReparentOperations HBLJIAHIEDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public NAIGBHBGBMH PDMAJMDKCCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly bool OMJDPKDKKKH;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x42A0120", Offset = "0x429F520", VA = "0x1842A0120")]
	public ENMKLHIOBLI(TNode GHPFBFMCBLM, TReparentOperations HBLJIAHIEDE, NAIGBHBGBMH PDMAJMDKCCF, bool OMDMBKKCEFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface EIMAMMDCELC<TNode, TReparentOperations>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EEKNOELFGBL([In] MDLMNPIIODK<TNode> KDEJOLKPBNF);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IHDMEEOOPBN([In] ENMKLHIOBLI<TNode, TReparentOperations> FADPADHCOOJ);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BINFMALBDIA();
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class CIPLNPHGNKE<TNode, TReparentOperations> : MBCMFHMCCBJ<EIMAMMDCELC<TNode, TReparentOperations>>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x4202E80", Offset = "0x4202280", VA = "0x184202E80")]
	public CIPLNPHGNKE(EIMAMMDCELC<TNode, TReparentOperations> LPKAAAAGEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x48E77B0", Offset = "0x48E6BB0", VA = "0x1848E77B0", Slot = "4")]
	public override bool MKBKFOOCCNJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class JIGLAJNHEIM<TNode, TReparentOperations> : MBCMFHMCCBJ<EIMAMMDCELC<TNode, TReparentOperations>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly ENMKLHIOBLI<TNode, TReparentOperations> FADPADHCOOJ;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x4BE7620", Offset = "0x4BE6A20", VA = "0x184BE7620")]
	public JIGLAJNHEIM(TNode GHPFBFMCBLM, TReparentOperations HBLJIAHIEDE, NAIGBHBGBMH PDMAJMDKCCF, EIMAMMDCELC<TNode, TReparentOperations> LPKAAAAGEAF, bool OMDMBKKCEFG = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x4202C00", Offset = "0x4202000", VA = "0x184202C00", Slot = "4")]
	public override bool MKBKFOOCCNJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class AMPGKOKOMHC<TNode, TReparentOperations> : MBCMFHMCCBJ<EIMAMMDCELC<TNode, TReparentOperations>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly MDLMNPIIODK<TNode> KDEJOLKPBNF;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x4A1AF50", Offset = "0x4A1A350", VA = "0x184A1AF50")]
	public AMPGKOKOMHC(TNode KPHCAKLEHJP, EIMAMMDCELC<TNode, TReparentOperations> LPKAAAAGEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x41F44C0", Offset = "0x41F38C0", VA = "0x1841F44C0", Slot = "4")]
	public override bool MKBKFOOCCNJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct PEFDAGOODCH<TSpawnInfo> where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public TSpawnInfo CIBOBAMCIJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public Vector3 JPKKPDPLAGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public Quaternion BENMKDDDBDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public float PGJAFHMCBJK;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x52CEED0", Offset = "0x52CE2D0", VA = "0x1852CEED0")]
	public PEFDAGOODCH(TSpawnInfo CIBOBAMCIJM, Vector3 JPKKPDPLAGA, Quaternion BENMKDDDBDG, float PGJAFHMCBJK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface EGDHCJFPKMC<TSpawnType, TSpawnInfo>
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> FDOPEPEOIGD([In] PEFDAGOODCH<TSpawnInfo> GFJIJINIAEC, CancellationToken BLABAMPAGAH);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class ILBDPMCIBCK<TSpawnType, TSpawnInfo> : JOADKFGHHPL<EGDHCJFPKMC<TSpawnType, TSpawnInfo>, TSpawnType> where TSpawnType : notnull where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly PEFDAGOODCH<TSpawnInfo> JOIGLCNPHIH;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x49D71F0", Offset = "0x49D65F0", VA = "0x1849D71F0")]
	public ILBDPMCIBCK(TSpawnInfo INBNHKNAKHH, Vector3 JPKKPDPLAGA, Quaternion BENMKDDDBDG, float PGJAFHMCBJK, EGDHCJFPKMC<TSpawnType, TSpawnInfo> LPKAAAAGEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x49D7000", Offset = "0x49D6400", VA = "0x1849D7000", Slot = "4")]
	public override Task<TSpawnType> MKBKFOOCCNJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public readonly struct GPDMMPJOEJL<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly IEnumerable<TData> IDJPMMJGOAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly bool OMJDPKDKKKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly bool BECDNJPDAIC;

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x483CF30", Offset = "0x483C330", VA = "0x18483CF30")]
	public GPDMMPJOEJL(IEnumerable<TData> GEFHOPLLDEK, bool OMDMBKKCEFG = false, bool NBJLFNJPPDI = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface BBKEHBNIJDP<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<KOKHMACPHAG> JDFHHFKOGND([In] GPDMMPJOEJL<TData> FKBEPPJHANM, CancellationToken BLABAMPAGAH);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class OMOLIMBHKOP<TData> : JOADKFGHHPL<BBKEHBNIJDP<TData>, KOKHMACPHAG> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly GPDMMPJOEJL<TData> HOLFFJAEOBH;

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x51E9AC0", Offset = "0x51E8EC0", VA = "0x1851E9AC0")]
	public OMOLIMBHKOP(IEnumerable<TData> GEFHOPLLDEK, bool OMDMBKKCEFG, BBKEHBNIJDP<TData> LPKAAAAGEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x49D7000", Offset = "0x49D6400", VA = "0x1849D7000", Slot = "4")]
	public override Task<KOKHMACPHAG> MKBKFOOCCNJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct OEFGOOABHJN<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly T JMBMDICGCNK;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x4F5C650", Offset = "0x4F5BA50", VA = "0x184F5C650")]
	public OEFGOOABHJN(T BOMBEJCLFGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface MNOFJADIKDP<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EEKNOELFGBL([In] OEFGOOABHJN<T> MPPFHBOICBK);

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IHDMEEOOPBN();
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface DFBDIKKNAMJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MKBKFOOCCNJ([In] EOJHGNLEMIE<T> ANODFLKKLKC);
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public struct EOJHGNLEMIE<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly T JMBMDICGCNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly bool BLKAKCONDOD;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x42B9D40", Offset = "0x42B9140", VA = "0x1842B9D40")]
	public EOJHGNLEMIE(T BOMBEJCLFGA, bool MJJKIGBHABK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public class GFCGMAEOANB<T> : MBCMFHMCCBJ<MNOFJADIKDP<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x4202E80", Offset = "0x4202280", VA = "0x184202E80")]
	public GFCGMAEOANB(MNOFJADIKDP<T> LPKAAAAGEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x481CF80", Offset = "0x481C380", VA = "0x18481CF80", Slot = "4")]
	public override bool MKBKFOOCCNJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class BAGAGAFAKJC<T> : MBCMFHMCCBJ<MNOFJADIKDP<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly OEFGOOABHJN<T> MPPFHBOICBK;

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5ADA610", Offset = "0x5AD9A10", VA = "0x185ADA610")]
	public BAGAGAFAKJC(T JMBMDICGCNK, MNOFJADIKDP<T> LPKAAAAGEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x41F44C0", Offset = "0x41F38C0", VA = "0x1841F44C0", Slot = "4")]
	public override bool MKBKFOOCCNJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class IMJMCLPJAAH<T> : MBCMFHMCCBJ<DFBDIKKNAMJ<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly EOJHGNLEMIE<T> ANODFLKKLKC;

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x49DB620", Offset = "0x49DAA20", VA = "0x1849DB620")]
	public IMJMCLPJAAH(T JMBMDICGCNK, bool MJJKIGBHABK, DFBDIKKNAMJ<T> LPKAAAAGEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x41F44C0", Offset = "0x41F38C0", VA = "0x1841F44C0", Slot = "4")]
	public override bool MKBKFOOCCNJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public struct LHCAMFKMOAN<TData> where TData : notnull, LNMANJAGALM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public IEnumerable<TData> IDJPMMJGOAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public bool KNLNODOPLLD;

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x4D81B80", Offset = "0x4D80F80", VA = "0x184D81B80")]
	public LHCAMFKMOAN(IEnumerable<TData> INMKPAGHBLL, bool OOFEHLAMEJP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public struct JAGHPGCHOLD<TData> where TData : notnull, LNMANJAGALM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public List<TData> IDJPMMJGOAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public List<bool> IFJNCIMNGNB;

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x4BC7E70", Offset = "0x4BC7270", VA = "0x184BC7E70")]
	public JAGHPGCHOLD(List<TData> INMKPAGHBLL, List<bool> BBIMDGPNBNO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface LNMANJAGALM
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool PGIBMJILBKA
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
public interface CLOLHEEIKCE<TData> where TData : LNMANJAGALM
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MKBKFOOCCNJ([In] LHCAMFKMOAN<TData> OOBNBECFGAN);

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MKBKFOOCCNJ([In] JAGHPGCHOLD<TData> OOBNBECFGAN);
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface MAKGCMDLFOC<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FNMHMLEPHGE(T JMBMDICGCNK);
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class ANLGJEFMMFE<TData> : MBCMFHMCCBJ<CLOLHEEIKCE<TData>> where TData : notnull, LNMANJAGALM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly LHCAMFKMOAN<TData> OOBNBECFGAN;

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x4A1BCF0", Offset = "0x4A1B0F0", VA = "0x184A1BCF0")]
	public ANLGJEFMMFE(List<TData> GEFHOPLLDEK, bool KNLNODOPLLD, CLOLHEEIKCE<TData> LPKAAAAGEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x41F44C0", Offset = "0x41F38C0", VA = "0x1841F44C0", Slot = "4")]
	public override bool MKBKFOOCCNJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class MIAEMLEIHDB<TData> : MBCMFHMCCBJ<CLOLHEEIKCE<TData>> where TData : notnull, LNMANJAGALM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly JAGHPGCHOLD<TData> OOBNBECFGAN;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x4F8CF40", Offset = "0x4F8C340", VA = "0x184F8CF40")]
	public MIAEMLEIHDB(List<TData> GEFHOPLLDEK, List<bool> IFJNCIMNGNB, CLOLHEEIKCE<TData> LPKAAAAGEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x4877E00", Offset = "0x4877200", VA = "0x184877E00", Slot = "4")]
	public override bool MKBKFOOCCNJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public interface IEIIOJEMJPB<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<KOKHMACPHAG> MKBKFOOCCNJ(ADFNANNLAPB<TData> PHBJPJBFOPB);
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public class PIOONDKGFOP<TData> : JOADKFGHHPL<IEIIOJEMJPB<TData>, KOKHMACPHAG> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private struct KGIACFAFLJI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public AsyncTaskMethodBuilder<KOKHMACPHAG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public PIOONDKGFOP<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private TaskAwaiter<KOKHMACPHAG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x4CD17C0", Offset = "0x4CD0BC0", VA = "0x184CD17C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x4CD1AA0", Offset = "0x4CD0EA0", VA = "0x184CD1AA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly ADFNANNLAPB<TData> BNFEGDHLNCB;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x52E1AB0", Offset = "0x52E0EB0", VA = "0x1852E1AB0")]
	public PIOONDKGFOP(TData AOAEIBFEIHH, IReadOnlyList<TData> IGGFNANEKDJ, bool OMDMBKKCEFG, IEIIOJEMJPB<TData> LPKAAAAGEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x52E19B0", Offset = "0x52E0DB0", VA = "0x1852E19B0", Slot = "4")]
	[AsyncStateMachine(typeof(PIOONDKGFOP<>.KGIACFAFLJI))]
	public override Task<KOKHMACPHAG> MKBKFOOCCNJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public struct ADFNANNLAPB<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public TData MDHNGFFLKMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public IReadOnlyList<TData> CHADELJNHCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public bool OMJDPKDKKKH;

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x47F52C0", Offset = "0x47F46C0", VA = "0x1847F52C0")]
	public ADFNANNLAPB(TData AOAEIBFEIHH, IReadOnlyList<TData> IGGFNANEKDJ, bool OMDMBKKCEFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface GMKDHFDBJDA<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MKBKFOOCCNJ([In] KMJAPOHCJGK<TData> IFLEDAAJNAH);
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public interface MEDGPJGNNGK<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MKBKFOOCCNJ([In] KHBFOFMBOPN<TData> IFLEDAAJNAH);
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public interface NAMNDCLEELB<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DDMLLOJPGPC([In] MNBHNOAEMIC<TData> IFLEDAAJNAH);

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IHDMEEOOPBN();
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class CLLADGLMNFP<TData> : MBCMFHMCCBJ<GMKDHFDBJDA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly KMJAPOHCJGK<TData> IFLEDAAJNAH;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6211A60", Offset = "0x6210E60", VA = "0x186211A60")]
	public CLLADGLMNFP(IEnumerable<TData> GEFHOPLLDEK, OCHPJGPHIOB CKANMCILFBE, FECNNNMEDDD KIEAKCEGOFO, float DIOGLFEGGFF, string? CFKIPPLHIHC, bool IMFJLDLHJFP, bool OMDMBKKCEFG, GMKDHFDBJDA<TData> LPKAAAAGEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x41F44C0", Offset = "0x41F38C0", VA = "0x1841F44C0", Slot = "4")]
	public override bool MKBKFOOCCNJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class MLPCFJINFFJ<TData> : MBCMFHMCCBJ<MEDGPJGNNGK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly KHBFOFMBOPN<TData> IFLEDAAJNAH;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x4F9F0F0", Offset = "0x4F9E4F0", VA = "0x184F9F0F0")]
	public MLPCFJINFFJ(TData[] GEFHOPLLDEK, OCHPJGPHIOB[] CKANMCILFBE, FECNNNMEDDD[] KIEAKCEGOFO, float[] DIOGLFEGGFF, MEDGPJGNNGK<TData> LPKAAAAGEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x4F9EF50", Offset = "0x4F9E350", VA = "0x184F9EF50", Slot = "4")]
	public override bool MKBKFOOCCNJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class GKNEHBGCOON<TData> : MBCMFHMCCBJ<NAMNDCLEELB<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x4202E80", Offset = "0x4202280", VA = "0x184202E80")]
	public GKNEHBGCOON(NAMNDCLEELB<TData> LPKAAAAGEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x482D3B0", Offset = "0x482C7B0", VA = "0x18482D3B0", Slot = "4")]
	public override bool MKBKFOOCCNJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class NAIKLMNOGMB<TData> : MBCMFHMCCBJ<NAMNDCLEELB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly MNBHNOAEMIC<TData> IFLEDAAJNAH;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x4FE5610", Offset = "0x4FE4A10", VA = "0x184FE5610")]
	public NAIKLMNOGMB(IEnumerable<TData> GEFHOPLLDEK, OCHPJGPHIOB CKANMCILFBE, FECNNNMEDDD KIEAKCEGOFO, float DIOGLFEGGFF, NAMNDCLEELB<TData> LPKAAAAGEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x4F9EF50", Offset = "0x4F9E350", VA = "0x184F9EF50", Slot = "4")]
	public override bool MKBKFOOCCNJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public struct KMJAPOHCJGK<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public IEnumerable<TData> IDJPMMJGOAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public OCHPJGPHIOB NHAFOJLJLLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public FECNNNMEDDD DHMACONJDOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public float OGGMHHPDKCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public string? EINCAKCDBKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public bool? JNKJFKKAHAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public bool OMJDPKDKKKH;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x4CDF1C0", Offset = "0x4CDE5C0", VA = "0x184CDF1C0")]
	public KMJAPOHCJGK(IEnumerable<TData> GEFHOPLLDEK, OCHPJGPHIOB CKANMCILFBE, FECNNNMEDDD KIEAKCEGOFO, float DIOGLFEGGFF, string? CFKIPPLHIHC, bool? IMFJLDLHJFP, bool OMDMBKKCEFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public struct KHBFOFMBOPN<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public TData[] IDJPMMJGOAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public OCHPJGPHIOB[] NHAFOJLJLLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public FECNNNMEDDD[] DHMACONJDOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public float[] DIOGLFEGGFF;

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x4CD32F0", Offset = "0x4CD26F0", VA = "0x184CD32F0")]
	public KHBFOFMBOPN(TData[] GEFHOPLLDEK, OCHPJGPHIOB[] CKANMCILFBE, FECNNNMEDDD[] KIEAKCEGOFO, float[] DIOGLFEGGFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public struct MNBHNOAEMIC<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public IEnumerable<TData> IDJPMMJGOAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public OCHPJGPHIOB NHAFOJLJLLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public FECNNNMEDDD DHMACONJDOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public float DIOGLFEGGFF;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x4FA3150", Offset = "0x4FA2550", VA = "0x184FA3150")]
	public MNBHNOAEMIC(IEnumerable<TData> GEFHOPLLDEK, OCHPJGPHIOB CKANMCILFBE, FECNNNMEDDD KIEAKCEGOFO, float DIOGLFEGGFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public interface EFCIAAACKPC<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PIKNLDJBOFJ([In] DJEMKDPJEHD<TData> FKBEPPJHANM);

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OLBCECMJMFF([In] DJEMKDPJEHD<TData> FKBEPPJHANM);

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GNFKPMOJOEF([In] bool HCACIPGAKOG);

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool OPPINPCDCHH([In] DJEMKDPJEHD<TData> FKBEPPJHANM);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OPBLHKDMKJO();

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool OHHBMPACLGN([In] TData HAEHCOHJMAF);
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class OFOPPJODOHB<TData> : MBCMFHMCCBJ<EFCIAAACKPC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly DJEMKDPJEHD<TData> FKBEPPJHANM;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x5156F50", Offset = "0x5156350", VA = "0x185156F50")]
	public OFOPPJODOHB(List<TData> OLEAEELGLFO, EFCIAAACKPC<TData> LPKAAAAGEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x41F44C0", Offset = "0x41F38C0", VA = "0x1841F44C0", Slot = "4")]
	public override bool MKBKFOOCCNJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class DBMPBOBMOIM<TData> : MBCMFHMCCBJ<EFCIAAACKPC<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4202E80", Offset = "0x4202280", VA = "0x184202E80")]
	public DBMPBOBMOIM(EFCIAAACKPC<TData> LPKAAAAGEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x65AFA00", Offset = "0x65AEE00", VA = "0x1865AFA00", Slot = "4")]
	public override bool MKBKFOOCCNJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class DDFPBECPFBH<TData> : MBCMFHMCCBJ<EFCIAAACKPC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly bool OMDMBKKCEFG;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x65B3C30", Offset = "0x65B3030", VA = "0x1865B3C30")]
	public DDFPBECPFBH(bool OMDMBKKCEFG, EFCIAAACKPC<TData> LPKAAAAGEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x65B3BD0", Offset = "0x65B2FD0", VA = "0x1865B3BD0", Slot = "4")]
	public override bool MKBKFOOCCNJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class HCLCCFBPHPM<TData> : MBCMFHMCCBJ<EFCIAAACKPC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly DJEMKDPJEHD<TData> FKBEPPJHANM;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x4877F60", Offset = "0x4877360", VA = "0x184877F60")]
	public HCLCCFBPHPM(List<TData> OLEAEELGLFO, bool OMDMBKKCEFG, EFCIAAACKPC<TData> LPKAAAAGEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x4877E00", Offset = "0x4877200", VA = "0x184877E00", Slot = "4")]
	public override bool MKBKFOOCCNJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class FOFFDMDDEDM<TData> : MBCMFHMCCBJ<EFCIAAACKPC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly TData HAEHCOHJMAF;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x4715C30", Offset = "0x4715030", VA = "0x184715C30")]
	public FOFFDMDDEDM(TData HAEHCOHJMAF, EFCIAAACKPC<TData> LPKAAAAGEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x4715AA0", Offset = "0x4714EA0", VA = "0x184715AA0", Slot = "4")]
	public override bool MKBKFOOCCNJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class GONJGLCOHPK<TData> : MBCMFHMCCBJ<EFCIAAACKPC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly DJEMKDPJEHD<TData> FKBEPPJHANM;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x483B1F0", Offset = "0x483A5F0", VA = "0x18483B1F0")]
	public GONJGLCOHPK(IEnumerable<TData> OLEAEELGLFO, EFCIAAACKPC<TData> LPKAAAAGEAF, bool OMDMBKKCEFG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x483B070", Offset = "0x483A470", VA = "0x18483B070", Slot = "4")]
	public override bool MKBKFOOCCNJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public struct DJEMKDPJEHD<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public IEnumerable<TData> IDJPMMJGOAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public bool OMDMBKKCEFG;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x65E9180", Offset = "0x65E8580", VA = "0x1865E9180")]
	public DJEMKDPJEHD(IEnumerable<TData> INMKPAGHBLL, bool BNOGJMNGPBN = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public interface LNFICLFPPFB
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<KOKHMACPHAG> MKBKFOOCCNJ(JEBIKEKBPLP EHGFBLBHMGL);
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class CJFFDAIHCAI : JOADKFGHHPL<LNFICLFPPFB, KOKHMACPHAG>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private struct AIMJHLJHBJP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public AsyncTaskMethodBuilder<KOKHMACPHAG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public CJFFDAIHCAI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private TaskAwaiter<KOKHMACPHAG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x786BA60", Offset = "0x786AE60", VA = "0x18786BA60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x786BCE0", Offset = "0x786B0E0", VA = "0x18786BCE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly JEBIKEKBPLP CFGAJEHJJFH;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x786BF20", Offset = "0x786B320", VA = "0x18786BF20")]
	public CJFFDAIHCAI(bool OMDMBKKCEFG, LNFICLFPPFB LPKAAAAGEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x786BE30", Offset = "0x786B230", VA = "0x18786BE30", Slot = "4")]
	[AsyncStateMachine(typeof(AIMJHLJHBJP))]
	public override Task<KOKHMACPHAG> MKBKFOOCCNJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public struct JEBIKEKBPLP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public bool OMJDPKDKKKH;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x2854050", Offset = "0x2853450", VA = "0x182854050")]
	public JEBIKEKBPLP(bool OMDMBKKCEFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public readonly struct HKGJHOEJNHL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public readonly bool OGOLGFGIPOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public readonly bool HJEGBCNPCIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public readonly bool PGJAFHMCBJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public readonly bool OMDMBKKCEFG;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x58E1610", Offset = "0x58E0A10", VA = "0x1858E1610")]
	public HKGJHOEJNHL(bool OGOLGFGIPOF, bool HJEGBCNPCIM, bool PGJAFHMCBJK, bool OMDMBKKCEFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x786C830", Offset = "0x786BC30", VA = "0x18786C830")]
	public HKGJHOEJNHL(bool HJEGBCNPCIM, bool OMDMBKKCEFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public interface GNDIEPCBALJ
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HDAMMDIBJFI(HKGJHOEJNHL NOPPHMHIMCF);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BDPHBOHJMCE(HKGJHOEJNHL NOPPHMHIMCF);
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class CCBEMIFPKIB : MBCMFHMCCBJ<GNDIEPCBALJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly HKGJHOEJNHL NOPPHMHIMCF;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x786BDA0", Offset = "0x786B1A0", VA = "0x18786BDA0")]
	public CCBEMIFPKIB(bool NPHMCHFKJHC, bool HJEGBCNPCIM, bool PGJAFHMCBJK, bool OMDMBKKCEFG, GNDIEPCBALJ LPKAAAAGEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x786BD50", Offset = "0x786B150", VA = "0x18786BD50", Slot = "4")]
	public override bool MKBKFOOCCNJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public class HIOOOECNMAJ : MBCMFHMCCBJ<GNDIEPCBALJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private readonly HKGJHOEJNHL NOPPHMHIMCF;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x786C7B0", Offset = "0x786BBB0", VA = "0x18786C7B0")]
	public HIOOOECNMAJ(bool HJEGBCNPCIM, bool OMDMBKKCEFG, GNDIEPCBALJ LPKAAAAGEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x786C760", Offset = "0x786BB60", VA = "0x18786C760", Slot = "4")]
	public override bool MKBKFOOCCNJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public interface PDJDDOEADEB
{
	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MKBKFOOCCNJ([In] LEGPCIHFADO NAAAOKDNDAE);
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class PEDEHDMAECO : MBCMFHMCCBJ<PDJDDOEADEB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private readonly LEGPCIHFADO NAAAOKDNDAE;

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x786D850", Offset = "0x786CC50", VA = "0x18786D850")]
	public PEDEHDMAECO(Guid[] NJOIPPLHMOH, Vector3[] LPBHHOOCLKB, Quaternion[] FBJFMJALOAJ, float[] IDPBGLGLENN, Dictionary<Guid, Vector3> PPEGPNDAMMF, PDJDDOEADEB LPKAAAAGEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x786D7A0", Offset = "0x786CBA0", VA = "0x18786D7A0", Slot = "4")]
	public override bool MKBKFOOCCNJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public interface CIGJFMLGDCM<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EEKNOELFGBL([In] GFMNHCJNOED<TData> KDEJOLKPBNF);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DDMLLOJPGPC([In] LNAPMHOACCE BKMPPOEFICK);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DDMLLOJPGPC([In] ACDBGHJGKGI BKMPPOEFICK);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IHDMEEOOPBN();
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class NAKHDDPPLFK<TData> : MBCMFHMCCBJ<CIGJFMLGDCM<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x4202E80", Offset = "0x4202280", VA = "0x184202E80")]
	public NAKHDDPPLFK(CIGJFMLGDCM<TData> LPKAAAAGEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x4FE56F0", Offset = "0x4FE4AF0", VA = "0x184FE56F0", Slot = "4")]
	public override bool MKBKFOOCCNJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class LCMBJCGLMHG<TData> : MBCMFHMCCBJ<CIGJFMLGDCM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly LNAPMHOACCE JDPJBHNJDLL;

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x4D72A40", Offset = "0x4D71E40", VA = "0x184D72A40")]
	public LCMBJCGLMHG(Vector3 KFFBAGLOFPI, bool BFOKBADJFMC, CIGJFMLGDCM<TData> LPKAAAAGEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x4C17D40", Offset = "0x4C17140", VA = "0x184C17D40", Slot = "4")]
	public override bool MKBKFOOCCNJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class KKMNOFAJGHJ<TData> : MBCMFHMCCBJ<CIGJFMLGDCM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly ACDBGHJGKGI JDPJBHNJDLL;

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x4CDBDB0", Offset = "0x4CDB1B0", VA = "0x184CDBDB0")]
	public KKMNOFAJGHJ(Guid CGNFOPBAJJL, int KDCAMOIGIMA, Vector3 JPKKPDPLAGA, Quaternion BENMKDDDBDG, float MCIPFGHOGIP, bool BFOKBADJFMC, CIGJFMLGDCM<TData> LPKAAAAGEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x4CDBD50", Offset = "0x4CDB150", VA = "0x184CDBD50", Slot = "4")]
	public override bool MKBKFOOCCNJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public class ANGFPFCPGNP<TData> : MBCMFHMCCBJ<CIGJFMLGDCM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly GFMNHCJNOED<TData> JDPJBHNJDLL;

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x4A1BBA0", Offset = "0x4A1AFA0", VA = "0x184A1BBA0")]
	public ANGFPFCPGNP(TData JMBMDICGCNK, bool OMDMBKKCEFG, CIGJFMLGDCM<TData> LPKAAAAGEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x41F44C0", Offset = "0x41F38C0", VA = "0x1841F44C0", Slot = "4")]
	public override bool MKBKFOOCCNJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct LNAPMHOACCE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public readonly Vector3 KFFBAGLOFPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public readonly bool BFOKBADJFMC;

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x786D3F0", Offset = "0x786C7F0", VA = "0x18786D3F0")]
	public LNAPMHOACCE(Vector3 KFFBAGLOFPI, bool BFOKBADJFMC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct ACDBGHJGKGI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public readonly Guid CGNFOPBAJJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public readonly int KDCAMOIGIMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public readonly Vector3 JPKKPDPLAGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public readonly Quaternion BENMKDDDBDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public readonly float MCIPFGHOGIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public readonly bool BFOKBADJFMC;

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x786BA20", Offset = "0x786AE20", VA = "0x18786BA20")]
	public ACDBGHJGKGI(Guid CGNFOPBAJJL, int KDCAMOIGIMA, Vector3 JPKKPDPLAGA, Quaternion BENMKDDDBDG, float MCIPFGHOGIP, bool BFOKBADJFMC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct GFMNHCJNOED<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public readonly TData JMBMDICGCNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public readonly bool OMDMBKKCEFG;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x481ECA0", Offset = "0x481E0A0", VA = "0x18481ECA0")]
	public GFMNHCJNOED(TData JMBMDICGCNK, bool OMDMBKKCEFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public interface DNGPEDFEKAO<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MKBKFOOCCNJ([In] JOIKKBNKECM<TData> MDFMAFFMIJD);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MKBKFOOCCNJ([In] IFELHJNMIFH<TData> MDFMAFFMIJD);
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public interface ENCBJAFJHKB<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EEKNOELFGBL([In] EPOGDLGCCKA<TData> BEKOIKNOICH);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DDMLLOJPGPC([In] NLPOKJHKEBM BKMPPOEFICK);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IHDMEEOOPBN();
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public class NPFPFJOKENN<TData> : MBCMFHMCCBJ<DNGPEDFEKAO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly JOIKKBNKECM<TData> MDFMAFFMIJD;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x5056D00", Offset = "0x5056100", VA = "0x185056D00")]
	public NPFPFJOKENN(IEnumerable<TData> GEFHOPLLDEK, Vector3 EMPANEFJGDF, bool OMDMBKKCEFG, DNGPEDFEKAO<TData> LPKAAAAGEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x41F44C0", Offset = "0x41F38C0", VA = "0x1841F44C0", Slot = "4")]
	public override bool MKBKFOOCCNJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class JPLLMMANGHD<TData> : MBCMFHMCCBJ<ENCBJAFJHKB<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x4202E80", Offset = "0x4202280", VA = "0x184202E80")]
	public JPLLMMANGHD(ENCBJAFJHKB<TData> LPKAAAAGEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x48E77B0", Offset = "0x48E6BB0", VA = "0x1848E77B0", Slot = "4")]
	public override bool MKBKFOOCCNJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public class EAIKCDMKAIJ<TData> : MBCMFHMCCBJ<ENCBJAFJHKB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly EPOGDLGCCKA<TData> MDFMAFFMIJD;

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x41F4580", Offset = "0x41F3980", VA = "0x1841F4580")]
	public EAIKCDMKAIJ(IEnumerable<TData> GEFHOPLLDEK, bool OMDMBKKCEFG, ENCBJAFJHKB<TData> LPKAAAAGEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x41F44C0", Offset = "0x41F38C0", VA = "0x1841F44C0", Slot = "4")]
	public override bool MKBKFOOCCNJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public class ECBNGHEPALG<TData> : MBCMFHMCCBJ<DNGPEDFEKAO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly IFELHJNMIFH<TData> MDFMAFFMIJD;

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x4202CD0", Offset = "0x42020D0", VA = "0x184202CD0")]
	public ECBNGHEPALG(IEnumerable<TData> GEFHOPLLDEK, Vector3 CKFCBPOLGIK, IDBEAANMFBO MIDNNIGFEDH, bool OMDMBKKCEFG, DNGPEDFEKAO<TData> LPKAAAAGEAF, Space HJFDKLPLPND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x4202C00", Offset = "0x4202000", VA = "0x184202C00", Slot = "4")]
	public override bool MKBKFOOCCNJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class PIMJCLNBCDI<TData> : MBCMFHMCCBJ<ENCBJAFJHKB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly NLPOKJHKEBM MDFMAFFMIJD;

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x52E1330", Offset = "0x52E0730", VA = "0x1852E1330")]
	public PIMJCLNBCDI(Vector3 EMPANEFJGDF, ENCBJAFJHKB<TData> LPKAAAAGEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x4C17D40", Offset = "0x4C17140", VA = "0x184C17D40", Slot = "4")]
	public override bool MKBKFOOCCNJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public struct JOIKKBNKECM<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public readonly IEnumerable<TData> GEFHOPLLDEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public readonly Vector3 EMPANEFJGDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly bool OMDMBKKCEFG;

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x4C1A460", Offset = "0x4C19860", VA = "0x184C1A460")]
	public JOIKKBNKECM(IEnumerable<TData> GEFHOPLLDEK, Vector3 EMPANEFJGDF, bool OMDMBKKCEFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct EPOGDLGCCKA<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public readonly IEnumerable<TData> GEFHOPLLDEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public readonly bool OMDMBKKCEFG;

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x42BAE40", Offset = "0x42BA240", VA = "0x1842BAE40")]
	public EPOGDLGCCKA(IEnumerable<TData> GEFHOPLLDEK, bool OMDMBKKCEFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public struct IFELHJNMIFH<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public readonly IEnumerable<TData> GEFHOPLLDEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public readonly Vector3 CKFCBPOLGIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public readonly IDBEAANMFBO MIDNNIGFEDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public readonly bool OMDMBKKCEFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public readonly Space HJFDKLPLPND;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x49B8010", Offset = "0x49B7410", VA = "0x1849B8010")]
	public IFELHJNMIFH(IEnumerable<TData> GEFHOPLLDEK, Vector3 CKFCBPOLGIK, IDBEAANMFBO MIDNNIGFEDH, bool OMDMBKKCEFG, Space HJFDKLPLPND)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public struct NLPOKJHKEBM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public readonly Vector3 EMPANEFJGDF;

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0xE14CA0", Offset = "0xE140A0", VA = "0x180E14CA0")]
	public NLPOKJHKEBM(Vector3 EMPANEFJGDF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public enum IDBEAANMFBO
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
public interface AAEEENMHOEN
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MKBKFOOCCNJ([In] AAMBEIGBOHA AJFAAANHHNA);
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public class HBBIPEOHABF : MBCMFHMCCBJ<AAEEENMHOEN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly AAMBEIGBOHA AJFAAANHHNA;

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x786C700", Offset = "0x786BB00", VA = "0x18786C700")]
	public HBBIPEOHABF(bool OMDMBKKCEFG, AAEEENMHOEN LPKAAAAGEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x786C650", Offset = "0x786BA50", VA = "0x18786C650", Slot = "4")]
	public override bool MKBKFOOCCNJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public readonly struct AAMBEIGBOHA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public readonly bool OMDMBKKCEFG;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x2854050", Offset = "0x2853450", VA = "0x182854050")]
	public AAMBEIGBOHA(bool OMDMBKKCEFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public interface PANPKOIBEMG<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MKBKFOOCCNJ([In] NMGAJPGIMND<TData> PJGNCHAOLKP);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MKBKFOOCCNJ([In] BIIGLOFGCAD<TData> PJGNCHAOLKP);
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public interface PGDCOOJCFDG<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EEKNOELFGBL([In] PJMFDEDPNGL<TData> KDEJOLKPBNF);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DDMLLOJPGPC([In] OOJFIBOFLHB BKMPPOEFICK);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IHDMEEOOPBN();
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public class CLGCKPEGGIM<TData> : MBCMFHMCCBJ<PANPKOIBEMG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly NMGAJPGIMND<TData> PJGNCHAOLKP;

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x62115A0", Offset = "0x62109A0", VA = "0x1862115A0")]
	public CLGCKPEGGIM(IEnumerable<TData> GEFHOPLLDEK, Quaternion EMPANEFJGDF, Vector3? GDBFDGLEAJA, bool CANNNKMDENO, bool OMDMBKKCEFG, PANPKOIBEMG<TData> LPKAAAAGEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x41F44C0", Offset = "0x41F38C0", VA = "0x1841F44C0", Slot = "4")]
	public override bool MKBKFOOCCNJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class AJHKGDINLPE<TData> : MBCMFHMCCBJ<PGDCOOJCFDG<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x4202E80", Offset = "0x4202280", VA = "0x184202E80")]
	public AJHKGDINLPE(PGDCOOJCFDG<TData> LPKAAAAGEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x48E77B0", Offset = "0x48E6BB0", VA = "0x1848E77B0", Slot = "4")]
	public override bool MKBKFOOCCNJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class OHFOEDJPAHO<TData> : MBCMFHMCCBJ<PGDCOOJCFDG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly PJMFDEDPNGL<TData> PJGNCHAOLKP;

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x5159BB0", Offset = "0x5158FB0", VA = "0x185159BB0")]
	public OHFOEDJPAHO(IEnumerable<TData> GEFHOPLLDEK, bool OMDMBKKCEFG, PGDCOOJCFDG<TData> LPKAAAAGEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x41F44C0", Offset = "0x41F38C0", VA = "0x1841F44C0", Slot = "4")]
	public override bool MKBKFOOCCNJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class NNBOGEDKGHA<TData> : MBCMFHMCCBJ<PANPKOIBEMG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly BIIGLOFGCAD<TData> PJGNCHAOLKP;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x50381C0", Offset = "0x50375C0", VA = "0x1850381C0")]
	public NNBOGEDKGHA(IEnumerable<TData> GEFHOPLLDEK, Quaternion DIAICBJMMND, IDBEAANMFBO CINNFFKJCLL, Vector3? GDBFDGLEAJA, bool CANNNKMDENO, bool OMDMBKKCEFG, Space HJFDKLPLPND, PANPKOIBEMG<TData> LPKAAAAGEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x4202C00", Offset = "0x4202000", VA = "0x184202C00", Slot = "4")]
	public override bool MKBKFOOCCNJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public class JPGBNKDCLPG<TData> : MBCMFHMCCBJ<PGDCOOJCFDG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private readonly OOJFIBOFLHB PJGNCHAOLKP;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x4C1A7C0", Offset = "0x4C19BC0", VA = "0x184C1A7C0")]
	public JPGBNKDCLPG(Quaternion EMPANEFJGDF, Vector3? GDBFDGLEAJA, bool CANNNKMDENO, PGDCOOJCFDG<TData> LPKAAAAGEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x4C17D40", Offset = "0x4C17140", VA = "0x184C17D40", Slot = "4")]
	public override bool MKBKFOOCCNJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public struct NMGAJPGIMND<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public readonly IEnumerable<TData> GEFHOPLLDEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public readonly Quaternion EMPANEFJGDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public readonly Vector3? GDBFDGLEAJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public readonly bool CANNNKMDENO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public readonly bool OMDMBKKCEFG;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x5036870", Offset = "0x5035C70", VA = "0x185036870")]
	public NMGAJPGIMND(IEnumerable<TData> GEFHOPLLDEK, Quaternion EMPANEFJGDF, Vector3? GDBFDGLEAJA, bool CANNNKMDENO, bool OMDMBKKCEFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct PJMFDEDPNGL<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public readonly IEnumerable<TData> GEFHOPLLDEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public readonly bool OMDMBKKCEFG;

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x52E3CB0", Offset = "0x52E30B0", VA = "0x1852E3CB0")]
	public PJMFDEDPNGL(IEnumerable<TData> GEFHOPLLDEK, bool OMDMBKKCEFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public struct BIIGLOFGCAD<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public readonly IEnumerable<TData> GEFHOPLLDEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public readonly Quaternion DIAICBJMMND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public readonly IDBEAANMFBO CINNFFKJCLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public readonly Vector3? GDBFDGLEAJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public readonly bool CANNNKMDENO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public readonly bool OMDMBKKCEFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public readonly Space HJFDKLPLPND;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x5D61570", Offset = "0x5D60970", VA = "0x185D61570")]
	public BIIGLOFGCAD(IEnumerable<TData> GEFHOPLLDEK, Quaternion DIAICBJMMND, IDBEAANMFBO CINNFFKJCLL, Vector3? GDBFDGLEAJA, bool CANNNKMDENO, bool OMDMBKKCEFG, Space HJFDKLPLPND)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct OOJFIBOFLHB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly Quaternion EMPANEFJGDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public readonly Vector3? GDBFDGLEAJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly bool CANNNKMDENO;

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x58A7650", Offset = "0x58A6A50", VA = "0x1858A7650")]
	public OOJFIBOFLHB(Quaternion EMPANEFJGDF, Vector3? GDBFDGLEAJA, bool CANNNKMDENO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public interface PDPBKJCJOHC<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EEKNOELFGBL([In] NJGDMDFKLFF<TData> KDEJOLKPBNF);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DDMLLOJPGPC([In] LMHHHKGFGHD BKMPPOEFICK);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DDMLLOJPGPC([In] GJHEKEFFKJH BKMPPOEFICK);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DDMLLOJPGPC([In] KEKHMPHHINM BKMPPOEFICK);

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IHDMEEOOPBN();
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public class AJECBCNJLBK<TData> : MBCMFHMCCBJ<PDPBKJCJOHC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private readonly KEKHMPHHINM GDLPFLILGHK;

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x48E6EF0", Offset = "0x48E62F0", VA = "0x1848E6EF0")]
	public AJECBCNJLBK(Vector3 DMCNJLOKFPA, float FJCBEEKIKKN, Vector3 GDBFDGLEAJA, bool BHAOPBKNIEB, bool LNCFIGHNMPO, PDPBKJCJOHC<TData> LPKAAAAGEAF, Space HJFDKLPLPND = Space.Self)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x48E6E90", Offset = "0x48E6290", VA = "0x1848E6E90", Slot = "4")]
	public override bool MKBKFOOCCNJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public class KMIIJHOKDHN<TData> : MBCMFHMCCBJ<PDPBKJCJOHC<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x4202E80", Offset = "0x4202280", VA = "0x184202E80")]
	public KMIIJHOKDHN(PDPBKJCJOHC<TData> LPKAAAAGEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x4CDF170", Offset = "0x4CDE570", VA = "0x184CDF170", Slot = "4")]
	public override bool MKBKFOOCCNJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public class DPMLHDNCDOI<TData> : MBCMFHMCCBJ<PDPBKJCJOHC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private readonly NJGDMDFKLFF<TData> GDLPFLILGHK;

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6600190", Offset = "0x65FF590", VA = "0x186600190")]
	public DPMLHDNCDOI(IEnumerable<TData> GEFHOPLLDEK, bool OMDMBKKCEFG, PDPBKJCJOHC<TData> LPKAAAAGEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x41F44C0", Offset = "0x41F38C0", VA = "0x1841F44C0", Slot = "4")]
	public override bool MKBKFOOCCNJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public class OMELLGBLCLK<TData> : MBCMFHMCCBJ<PDPBKJCJOHC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private readonly GJHEKEFFKJH GDLPFLILGHK;

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x51E4F20", Offset = "0x51E4320", VA = "0x1851E4F20")]
	public OMELLGBLCLK(float LDFLILENFHH, bool KIHHINHMJEI, Vector3 GDBFDGLEAJA, PDPBKJCJOHC<TData> LPKAAAAGEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x51E4E50", Offset = "0x51E4250", VA = "0x1851E4E50", Slot = "4")]
	public override bool MKBKFOOCCNJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public class JNPNAFLNDGL<TData> : MBCMFHMCCBJ<PDPBKJCJOHC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private readonly LMHHHKGFGHD GDLPFLILGHK;

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x4C17DA0", Offset = "0x4C171A0", VA = "0x184C17DA0")]
	public JNPNAFLNDGL(float FJCBEEKIKKN, Vector3 GDBFDGLEAJA, PDPBKJCJOHC<TData> LPKAAAAGEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x4C17D40", Offset = "0x4C17140", VA = "0x184C17D40", Slot = "4")]
	public override bool MKBKFOOCCNJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public struct KEKHMPHHINM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public readonly Vector3 DMCNJLOKFPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public readonly float FJCBEEKIKKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public readonly Vector3 GDBFDGLEAJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public readonly bool BFOKBADJFMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public readonly Space HJFDKLPLPND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public readonly bool LNCFIGHNMPO;

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x786CC40", Offset = "0x786C040", VA = "0x18786CC40")]
	public KEKHMPHHINM(Vector3 DMCNJLOKFPA, float FJCBEEKIKKN, Vector3 GDBFDGLEAJA, bool BFOKBADJFMC, bool NNBFMBDFPJO, Space HJFDKLPLPND = Space.Self)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public struct NJGDMDFKLFF<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public readonly IEnumerable<TData> GEFHOPLLDEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public readonly bool OMDMBKKCEFG;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x5028E40", Offset = "0x5028240", VA = "0x185028E40")]
	public NJGDMDFKLFF(IEnumerable<TData> GEFHOPLLDEK, bool OMDMBKKCEFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public struct GJHEKEFFKJH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public readonly float LDFLILENFHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public readonly bool KIHHINHMJEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public readonly Vector3 GDBFDGLEAJA;

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x786C630", Offset = "0x786BA30", VA = "0x18786C630")]
	public GJHEKEFFKJH(float LDFLILENFHH, bool KIHHINHMJEI, Vector3 GDBFDGLEAJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public struct LMHHHKGFGHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public readonly float FJCBEEKIKKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public readonly Vector3 GDBFDGLEAJA;

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x587B120", Offset = "0x587A520", VA = "0x18587B120")]
	public LMHHHKGFGHD(float FJCBEEKIKKN, Vector3 GDBFDGLEAJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public struct LEGPCIHFADO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public readonly Guid[] GEFHOPLLDEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public readonly bool JNFNHGNNGFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public readonly bool MDMIPJDDNDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public readonly bool MFNMDCFBMHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public readonly Vector3[] LPBHHOOCLKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public readonly Quaternion[] FBJFMJALOAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public readonly float[] IDPBGLGLENN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public readonly Dictionary<Guid, Vector3> PPEGPNDAMMF;

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x786D160", Offset = "0x786C560", VA = "0x18786D160")]
	public LEGPCIHFADO(Guid[] NJOIPPLHMOH, Vector3[] LPBHHOOCLKB, Quaternion[] FBJFMJALOAJ, float[] IDPBGLGLENN, Dictionary<Guid, Vector3> PPEGPNDAMMF, bool JNFNHGNNGFN = true, bool MDMIPJDDNDN = true, bool MFNMDCFBMHC = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x786CF90", Offset = "0x786C390", VA = "0x18786CF90")]
	private static void MGGKLNDOHEO(Dictionary<Guid, Vector3> PPEGPNDAMMF, int NJPMFODLEGN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public static class GIFIOCAMIEG
{
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	private struct FLOACGHDKPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public bool GOKHCHMFEEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public NPIEGGOELNH GLJKILIPJOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public NPIEGGOELNH ABNADMLGOFJ;
	}

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static FLOACGHDKPP LPOMNPCJPNJ;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static CancellationToken OCLINABENBF
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x786C2D0", Offset = "0x786B6D0", VA = "0x18786C2D0")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	internal static NPIEGGOELNH GLJKILIPJOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x786C440", Offset = "0x786B840", VA = "0x18786C440")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x786C4E0", Offset = "0x786B8E0", VA = "0x18786C4E0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x786C540", Offset = "0x786B940", VA = "0x18786C540")]
	[BOBPNFIGGBE.IMBCNFJLKJE]
	internal static void MIDKFNLDDFI(NPIEGGOELNH JFEDMIIEONJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x786C2F0", Offset = "0x786B6F0", VA = "0x18786C2F0")]
	public static void CNJFGCHCFHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x786C280", Offset = "0x786B680", VA = "0x18786C280")]
	private static NPIEGGOELNH APAOBOOMHGJ(NPIEGGOELNH GAGDNMMIJGI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public static class PGGFDDOECOC
{
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	public enum IBFGAABHCGJ
	{
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		ICreationContextObject,
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		Guid
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x37E40C0", Offset = "0x37E34C0", VA = "0x1837E40C0")]
	public static void EMJECBKCCAI<T>(T MOAEMAHGOBD, IBFGAABHCGJ MAIGGPEPIHD) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x37E4050", Offset = "0x37E3450", VA = "0x1837E4050")]
	public static void EMJECBKCCAI<T>(T MOAEMAHGOBD) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x37E42E0", Offset = "0x37E36E0", VA = "0x1837E42E0")]
	public static void MFLGPMDCFCH<T>(T MOAEMAHGOBD) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x37E3E90", Offset = "0x37E3290", VA = "0x1837E3E90")]
	public static T CNKKCIMLPML<T>(IBFGAABHCGJ MAIGGPEPIHD) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x37E3CE0", Offset = "0x37E30E0", VA = "0x1837E3CE0")]
	public static bool CJAKJEKDEBL<T>(IBFGAABHCGJ MAIGGPEPIHD, T? EFNMJKMCHLK, [Out][NotNullWhen(true)][MaybeNullWhen(false)] T HDICGKKEJCG) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x37E3F40", Offset = "0x37E3340", VA = "0x1837E3F40")]
	public static bool DFPJPAMKIHJ<T>(IBFGAABHCGJ MAIGGPEPIHD, [Out][MaybeNullWhen(false)][NotNullWhen(true)] T JFMJHBKHGHD) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x37E4230", Offset = "0x37E3630", VA = "0x1837E4230")]
	public static bool IMAAGEFLLCP<T>(IBFGAABHCGJ MAIGGPEPIHD) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x37E3E30", Offset = "0x37E3230", VA = "0x1837E3E30")]
	public static T CNKKCIMLPML<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x37E3C20", Offset = "0x37E3020", VA = "0x1837E3C20")]
	public static bool CJAKJEKDEBL<T>(T EFNMJKMCHLK, [Out] T HDICGKKEJCG) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x37E3E30", Offset = "0x37E3230", VA = "0x1837E3E30")]
	public static bool IMAAGEFLLCP<T>() where T : class
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
internal static class JAEEKOFHFFK
{
	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x786C860", Offset = "0x786BC60", VA = "0x18786C860")]
	public static void CEFLKDDHFMH(IEnumerable CDPFJOKDOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x3675970", Offset = "0x3674D70", VA = "0x183675970")]
	public static void CEFLKDDHFMH<T>(T[] KCPGIJAPEHH) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x3675B50", Offset = "0x3674F50", VA = "0x183675B50")]
	public static void CEFLKDDHFMH<T>(T KBBLKNKJAHB) where T : notnull, Enum
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
