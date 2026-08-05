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
		[Cpp2IlInjected.Address(RVA = "0x91D620", Offset = "0x91C820", VA = "0x18091D620")]
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
		[Cpp2IlInjected.Address(RVA = "0x726F390", Offset = "0x726E590", VA = "0x18726F390")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x91E490", Offset = "0x91D690", VA = "0x18091E490")]
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
		[Cpp2IlInjected.Address(RVA = "0x91E4D0", Offset = "0x91D6D0", VA = "0x18091E4D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x726F7F0", Offset = "0x726E9F0", VA = "0x18726F7F0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x23EA930", Offset = "0x23E9B30", VA = "0x1823EA930")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface LHBJGDENPJM<TData, TReturn>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TReturn GNJJMODIABD(TData LCACGJDNDHA);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface ODNMLPHPMJH<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ClearHoverTarget(EPBDOFLKFLE PCFMHLJNMCP);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool SetHoverTarget(TData MKMPLOHPJDC, Collider AKGIMBFMKEK, EPBDOFLKFLE PCFMHLJNMCP, [Optional] JHEIHPJJONE? EJMOHPPJKPN);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool TryGetHoverTarget([Out] TData MKMPLOHPJDC);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetHoverCollider([Out] Collider AKGIMBFMKEK);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface IMIGEHMFPOF<TData> : MPMNEHGDIHJ, AADAGHNOIHF<TData>, OMNMMNDOCPB<TData>, NFGHFGJGPEL<TData>, GKFGIJDFCJJ, DMEDGLOEKLB<TData>, LCKFBHNHPBL, MGHJMEJIKHP
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface DMEDGLOEKLB<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 KGJLHKKBBFC, Vector3 BDIPLNMOFCC, float ABBGAHJHLCA, [Out] T HKBIKGFOMBK, [Out] Vector3 IDOBPLJJHDN, [Out] Collider AKGIMBFMKEK);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 KGJLHKKBBFC, Vector3 BDIPLNMOFCC, float FLEMNLDDPBE, float ABBGAHJHLCA, T[] MOFPLIIFNJK, [Out] Vector3 JMGJPFKDLKC, [Out] Collider INNINCKEOAK);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 KGJLHKKBBFC, float FLEMNLDDPBE, Vector3 HLMNKMNEBAO, T[] MOFPLIIFNJK);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetObjectFromColliderInCurrentScope(Collider GIBMJBECLPO, [Out] T HMPDBGDJDGK);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface MPMNEHGDIHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Bounds NAHDDNBPMJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Transform IBKJLJCMNKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Bounds AAHOEMIHCAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Transform GKDOIAHIDGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Vector3 EJDFBCBCFKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool CHLJODIMLEO
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
	void SetSelectionBoundsDirty(bool EIMODBDHGAJ = true, int AEDALGBEFKF = 0);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ShouldHideSelectionBoundsPreview(bool KGDABPAPOFB, object BCOHKLCJCPM);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface MGHJMEJIKHP
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	AEJLNDNFINA MAFLJLDFBAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface DAFONJJKLPA
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool GFACBKDCAIM
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool APFHAEEFHLD
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool FNONGKHPMEN
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
	void TrySetPreviousCloneMapping(Dictionary<Guid, Guid> INJNHJIGHEM);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface NFGHFGJGPEL<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool ODKPJPGKDPC
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int IEKPNGKLAAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<TData> BAJOBJCKJAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData OCLIEIADJMI);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData OCLIEIADJMI);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface AADAGHNOIHF<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T LCACGJDNDHA, [Optional] JHEIHPJJONE? EIHFAHFNELO, bool LDBHECPOIPN = true);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int EOKNBJLIKEG, IEnumerable<T> GOBDOGBALID, bool LDBHECPOIPN = true);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int EOKNBJLIKEG, IEnumerable<T> GOBDOGBALID, JHEIHPJJONE EIHFAHFNELO, bool LDBHECPOIPN = true);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface LCKFBHNHPBL
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface GKFGIJDFCJJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool LHCKNEFAGDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool ONLLDJKMGCO
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool LDIKNEIOGPP
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool JDBHNJOFMMF
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class HBFOFCDDDAL<TReceiver> : AFPMEEJNJLJ<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x42CB080", Offset = "0x42CA280", VA = "0x1842CB080")]
	public HBFOFCDDDAL(TReceiver LFLGFFHCMEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public abstract class KBCLEHEPCBP<TReceiver, TFromTask> : AFPMEEJNJLJ<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x42CB080", Offset = "0x42CA280", VA = "0x1842CB080")]
	public KBCLEHEPCBP(TReceiver LFLGFFHCMEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public abstract class AFPMEEJNJLJ<TReceiver, TFromExecute> where TReceiver : notnull where TFromExecute : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	protected TReceiver LFLGFFHCMEJ;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4420FF0", Offset = "0x44201F0", VA = "0x184420FF0")]
	public AFPMEEJNJLJ(TReceiver LFLGFFHCMEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute OPAIAFJGAEK();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class BDJIINPCHLJ<TReceiver, TResult> : AFPMEEJNJLJ<TReceiver, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x42CB080", Offset = "0x42CA280", VA = "0x1842CB080")]
	public BDJIINPCHLJ(TReceiver LFLGFFHCMEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct ODNPDLOCMEB<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public TGroup BMBDMCCJNAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public TData GKAKMBAJBGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public IEnumerable<TData> LNLNBFBEIAM;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x23FB600", Offset = "0x23FA800", VA = "0x1823FB600")]
	public ODNPDLOCMEB(TGroup NHEPIDMAFME, TData BEJNADPLJJM, IEnumerable<TData> MHDKMAGHJOG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct IGCNJKCDNJG<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public TGroup BMBDMCCJNAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public IEnumerable<TData> LNLNBFBEIAM;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x982390", Offset = "0x981590", VA = "0x180982390")]
	public IGCNJKCDNJG(TGroup NHEPIDMAFME, IEnumerable<TData> MHDKMAGHJOG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct BOCALEKMLIL<TGroup> where TGroup : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public TGroup BMBDMCCJNAH;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0xBC2740", Offset = "0xBC1940", VA = "0x180BC2740")]
	public BOCALEKMLIL(TGroup NHEPIDMAFME)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct FFHKDGHFFBO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public IEnumerable<Guid> LNLNBFBEIAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public Guid HCIGJNFCBHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public readonly bool PNPCDLAONAC;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x726E500", Offset = "0x726D700", VA = "0x18726E500")]
	public FFHKDGHFFBO(IEnumerable<Guid> MHDKMAGHJOG, Guid CMBLHJGJOGC, bool KEIJFMPDHPB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct EANLDMCCHLJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public Guid HCIGJNFCBHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly bool PNPCDLAONAC;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x225A6C0", Offset = "0x22598C0", VA = "0x18225A6C0")]
	public EANLDMCCHLJ(Guid CMBLHJGJOGC, bool KEIJFMPDHPB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface HFBKCIMPCKA<TGroup, TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FJEJONHLFLD EJCFFPIFGPP(ODNPDLOCMEB<TGroup, TData> BPKIICBANPI);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FJEJONHLFLD EEEBKKIGOHD(ODNPDLOCMEB<TGroup, TData> BPKIICBANPI);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FJEJONHLFLD DKJLHEDFHEM(IGCNJKCDNJG<TGroup, TData> BPKIICBANPI);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FJEJONHLFLD AODJAHIGGMI(BOCALEKMLIL<TGroup> BPKIICBANPI);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface NLOEIJBADCH
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<FJEJONHLFLD> EJCFFPIFGPP(FFHKDGHFFBO BPKIICBANPI);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<FJEJONHLFLD> EEEBKKIGOHD(EANLDMCCHLJ BPKIICBANPI);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class AOGIKDNNGDH<TGroup, TData> : BDJIINPCHLJ<HFBKCIMPCKA<TGroup, TData>, FJEJONHLFLD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly IGCNJKCDNJG<TGroup, TData> BPKIICBANPI;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4538830", Offset = "0x4537A30", VA = "0x184538830")]
	public AOGIKDNNGDH(TGroup NHEPIDMAFME, IEnumerable<TData> MHDKMAGHJOG, HFBKCIMPCKA<TGroup, TData> LFLGFFHCMEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x4538770", Offset = "0x4537970", VA = "0x184538770", Slot = "4")]
	public override FJEJONHLFLD OPAIAFJGAEK()
	{
		return default(FJEJONHLFLD);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class GJMEPAELPCG<TGroup, TData> : BDJIINPCHLJ<HFBKCIMPCKA<TGroup, TData>, FJEJONHLFLD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly ODNPDLOCMEB<TGroup, TData> BPKIICBANPI;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4446BB0", Offset = "0x4445DB0", VA = "0x184446BB0")]
	public GJMEPAELPCG(TGroup NHEPIDMAFME, TData BHKLHJPHAND, IEnumerable<TData> MHDKMAGHJOG, HFBKCIMPCKA<TGroup, TData> LFLGFFHCMEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x4456720", Offset = "0x4455920", VA = "0x184456720", Slot = "4")]
	public override FJEJONHLFLD OPAIAFJGAEK()
	{
		return default(FJEJONHLFLD);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class HOBOMKDPMOL<TGroup, TData> : BDJIINPCHLJ<HFBKCIMPCKA<TGroup, TData>, FJEJONHLFLD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly BOCALEKMLIL<TGroup> BPKIICBANPI;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x44EEEA0", Offset = "0x44EE0A0", VA = "0x1844EEEA0")]
	public HOBOMKDPMOL(TGroup NHEPIDMAFME, HFBKCIMPCKA<TGroup, TData> LFLGFFHCMEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x44EEDE0", Offset = "0x44EDFE0", VA = "0x1844EEDE0", Slot = "4")]
	public override FJEJONHLFLD OPAIAFJGAEK()
	{
		return default(FJEJONHLFLD);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class GJDHLEFPGMG<TGroup, TData> : BDJIINPCHLJ<HFBKCIMPCKA<TGroup, TData>, FJEJONHLFLD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly ODNPDLOCMEB<TGroup, TData> BPKIICBANPI;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4446BB0", Offset = "0x4445DB0", VA = "0x184446BB0")]
	public GJDHLEFPGMG(TGroup NHEPIDMAFME, TData BEJNADPLJJM, IEnumerable<TData> MHDKMAGHJOG, HFBKCIMPCKA<TGroup, TData> LFLGFFHCMEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4446AD0", Offset = "0x4445CD0", VA = "0x184446AD0", Slot = "4")]
	public override FJEJONHLFLD OPAIAFJGAEK()
	{
		return default(FJEJONHLFLD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class NENPADHGCDC : KBCLEHEPCBP<NLOEIJBADCH, FJEJONHLFLD>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private struct GHAFBFAIDOP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public AsyncTaskMethodBuilder<FJEJONHLFLD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public NENPADHGCDC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private TaskAwaiter<FJEJONHLFLD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x726E7F0", Offset = "0x726D9F0", VA = "0x18726E7F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x726EA80", Offset = "0x726DC80", VA = "0x18726EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private FFHKDGHFFBO BPKIICBANPI;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x726F2B0", Offset = "0x726E4B0", VA = "0x18726F2B0")]
	public NENPADHGCDC(IEnumerable<Guid> HGKBEFMPNIO, Guid CMBLHJGJOGC, bool KEIJFMPDHPB, NLOEIJBADCH LFLGFFHCMEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x726F1C0", Offset = "0x726E3C0", VA = "0x18726F1C0", Slot = "4")]
	[AsyncStateMachine(typeof(GHAFBFAIDOP))]
	public override Task<FJEJONHLFLD> OPAIAFJGAEK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class CIADLEOMBEA : KBCLEHEPCBP<NLOEIJBADCH, FJEJONHLFLD>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private struct CDKIJIMHNMF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public AsyncTaskMethodBuilder<FJEJONHLFLD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public CIADLEOMBEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private TaskAwaiter<FJEJONHLFLD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x726DFB0", Offset = "0x726D1B0", VA = "0x18726DFB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x726E250", Offset = "0x726D450", VA = "0x18726E250", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly EANLDMCCHLJ BPKIICBANPI;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x726E3B0", Offset = "0x726D5B0", VA = "0x18726E3B0")]
	public CIADLEOMBEA(Guid CMBLHJGJOGC, bool KEIJFMPDHPB, NLOEIJBADCH LFLGFFHCMEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x726E2C0", Offset = "0x726D4C0", VA = "0x18726E2C0", Slot = "4")]
	[AsyncStateMachine(typeof(CDKIJIMHNMF))]
	public override Task<FJEJONHLFLD> OPAIAFJGAEK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public readonly struct NFGPFCKOLLP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly MEDEIHIFIGM NAIBHLAHKOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly bool PNPCDLAONAC;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x726F370", Offset = "0x726E570", VA = "0x18726F370")]
	public NFGPFCKOLLP(MEDEIHIFIGM HJEBCJPJKOD, bool KEIJFMPDHPB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface PPIMHODMBCA<TSpawnType> where TSpawnType : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> OPAIAFJGAEK(NFGPFCKOLLP JIOLJDOKHBI);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class BCEPHBLDMKH<TSpawnType> : KBCLEHEPCBP<PPIMHODMBCA<TSpawnType>, TSpawnType> where TSpawnType : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private struct KJIDDGOIGPF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AsyncTaskMethodBuilder<TSpawnType> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public BCEPHBLDMKH<TSpawnType> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private TaskAwaiter<TSpawnType> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x4943EF0", Offset = "0x49430F0", VA = "0x184943EF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x3ECE780", Offset = "0x3ECD980", VA = "0x183ECE780", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly NFGPFCKOLLP JIOLJDOKHBI;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5632A80", Offset = "0x5631C80", VA = "0x185632A80")]
	public BCEPHBLDMKH(MEDEIHIFIGM HJEBCJPJKOD, bool KEIJFMPDHPB, PPIMHODMBCA<TSpawnType> LFLGFFHCMEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5632980", Offset = "0x5631B80", VA = "0x185632980", Slot = "4")]
	[AsyncStateMachine(typeof(BCEPHBLDMKH<>.KJIDDGOIGPF))]
	public override Task<TSpawnType> OPAIAFJGAEK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public readonly struct MEDEIHIFIGM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly bool IABADNPJLHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly Vector3 HEEFGJFKPPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly Vector3 FJKLEJNIMLK;

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x726F090", Offset = "0x726E290", VA = "0x18726F090")]
	public MEDEIHIFIGM(Transform GALGIDFCJLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x726F100", Offset = "0x726E300", VA = "0x18726F100")]
	public MEDEIHIFIGM(Vector3 LAOLFCMCDHJ, Vector3 FCKJMOMOHAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x726F060", Offset = "0x726E260", VA = "0x18726F060")]
	public static MEDEIHIFIGM JAGPIMIGLNJ()
	{
		return default(MEDEIHIFIGM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x726F130", Offset = "0x726E330", VA = "0x18726F130")]
	private MEDEIHIFIGM(bool BIDPNDNOJFB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct EACLBNNOLLJ<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public TNode FAIICEIOLKK;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3ECAED0", Offset = "0x3ECA0D0", VA = "0x183ECAED0")]
	public EACLBNNOLLJ(TNode FAIICEIOLKK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct ANFNLDMMHEK<TNode, TReparentOperations> where TNode : notnull where TReparentOperations : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public TNode PDBFKNONEBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public TReparentOperations CPIDNONHHGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public JBEEPBMKHMC CIBOKLFMALP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly bool PNPCDLAONAC;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x4537800", Offset = "0x4536A00", VA = "0x184537800")]
	public ANFNLDMMHEK(TNode PDBFKNONEBD, TReparentOperations CPIDNONHHGE, JBEEPBMKHMC CIBOKLFMALP, bool KEIJFMPDHPB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface KBJCEMDDJDG<TNode, TReparentOperations>
{
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BMGHIFFOFOF([In] EACLBNNOLLJ<TNode> PLMCDOHFGBJ);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HMBKHFDGGKB([In] ANFNLDMMHEK<TNode, TReparentOperations> GMGKLLDOEPO);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JDLDPJGEDFA();
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class KGJPALHOOIB<TNode, TReparentOperations> : HBFOFCDDDAL<KBJCEMDDJDG<TNode, TReparentOperations>>
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x42CB080", Offset = "0x42CA280", VA = "0x1842CB080")]
	public KGJPALHOOIB(KBJCEMDDJDG<TNode, TReparentOperations> LFLGFFHCMEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x44D61A0", Offset = "0x44D53A0", VA = "0x1844D61A0", Slot = "4")]
	public override bool OPAIAFJGAEK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class CBCBEAGEAKN<TNode, TReparentOperations> : HBFOFCDDDAL<KBJCEMDDJDG<TNode, TReparentOperations>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly ANFNLDMMHEK<TNode, TReparentOperations> GMGKLLDOEPO;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x56DFE10", Offset = "0x56DF010", VA = "0x1856DFE10")]
	public CBCBEAGEAKN(TNode PDBFKNONEBD, TReparentOperations CPIDNONHHGE, JBEEPBMKHMC CIBOKLFMALP, KBJCEMDDJDG<TNode, TReparentOperations> LFLGFFHCMEJ, bool KEIJFMPDHPB = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x4BFEDC0", Offset = "0x4BFDFC0", VA = "0x184BFEDC0", Slot = "4")]
	public override bool OPAIAFJGAEK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class NLHOPDCKJPA<TNode, TReparentOperations> : HBFOFCDDDAL<KBJCEMDDJDG<TNode, TReparentOperations>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly EACLBNNOLLJ<TNode> PLMCDOHFGBJ;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x4C8C060", Offset = "0x4C8B260", VA = "0x184C8C060")]
	public NLHOPDCKJPA(TNode MLIMHLHIDPH, KBJCEMDDJDG<TNode, TReparentOperations> LFLGFFHCMEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x3F1FE00", Offset = "0x3F1F000", VA = "0x183F1FE00", Slot = "4")]
	public override bool OPAIAFJGAEK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct PHMPFNDKIHN<TSpawnInfo> where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public TSpawnInfo DAJFNEAJKCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public Vector3 FCKJMOMOHAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public Quaternion EGIHDGHICMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public float KGBNKPFPEFM;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x4F38AD0", Offset = "0x4F37CD0", VA = "0x184F38AD0")]
	public PHMPFNDKIHN(TSpawnInfo DAJFNEAJKCB, Vector3 FCKJMOMOHAE, Quaternion EGIHDGHICMO, float KGBNKPFPEFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface KEHFBLGIIKO<TSpawnType, TSpawnInfo>
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> EKBHNHOLCJG([In] PHMPFNDKIHN<TSpawnInfo> ODNKMKLALNG, CancellationToken BGEKICMONBE);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public class MBEBEGJLMEI<TSpawnType, TSpawnInfo> : KBCLEHEPCBP<KEHFBLGIIKO<TSpawnType, TSpawnInfo>, TSpawnType> where TSpawnType : notnull where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly PHMPFNDKIHN<TSpawnInfo> OKBEKNPNPIM;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x4BDA410", Offset = "0x4BD9610", VA = "0x184BDA410")]
	public MBEBEGJLMEI(TSpawnInfo FIEALJAFBGP, Vector3 FCKJMOMOHAE, Quaternion EGIHDGHICMO, float KGBNKPFPEFM, KEHFBLGIIKO<TSpawnType, TSpawnInfo> LFLGFFHCMEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x4820C20", Offset = "0x481FE20", VA = "0x184820C20", Slot = "4")]
	public override Task<TSpawnType> OPAIAFJGAEK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public readonly struct LPCJDNKHIKF<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly IEnumerable<TData> LNLNBFBEIAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly bool PNPCDLAONAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly bool FPKKGCOBKOD;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x4A0F250", Offset = "0x4A0E450", VA = "0x184A0F250")]
	public LPCJDNKHIKF(IEnumerable<TData> MHDKMAGHJOG, bool KEIJFMPDHPB = false, bool PHFDLLHFHBK = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface IAMJDPFBDJM<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<FJEJONHLFLD> OOBOBGOBOCC([In] LPCJDNKHIKF<TData> AJAMLGKFLMG, CancellationToken BGEKICMONBE);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class JELJJNFHKKN<TData> : KBCLEHEPCBP<IAMJDPFBDJM<TData>, FJEJONHLFLD> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly LPCJDNKHIKF<TData> HMFHGOPNJFO;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x4820DB0", Offset = "0x481FFB0", VA = "0x184820DB0")]
	public JELJJNFHKKN(IEnumerable<TData> MHDKMAGHJOG, bool KEIJFMPDHPB, IAMJDPFBDJM<TData> LFLGFFHCMEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x4820C20", Offset = "0x481FE20", VA = "0x184820C20", Slot = "4")]
	public override Task<FJEJONHLFLD> OPAIAFJGAEK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct OMMPFNBDMDF<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly T MKMPLOHPJDC;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x4E3FC80", Offset = "0x4E3EE80", VA = "0x184E3FC80")]
	public OMMPFNBDMDF(T NACAEJHDKFK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface DDFAMACOHHI<T>
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BMGHIFFOFOF([In] OMMPFNBDMDF<T> BAAGBBHLDLL);

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HMBKHFDGGKB();
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface KBCDBEBGNKN<T>
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OPAIAFJGAEK([In] GKEFCFFCOJG<T> AKHABDKNGKC);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct GKEFCFFCOJG<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly T MKMPLOHPJDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly bool CGDHNFHAPBL;

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x44573D0", Offset = "0x44565D0", VA = "0x1844573D0")]
	public GKEFCFFCOJG(T NACAEJHDKFK, bool MNCPMMFJKOI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class HCEHBNODODP<T> : HBFOFCDDDAL<DDFAMACOHHI<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x42CB080", Offset = "0x42CA280", VA = "0x1842CB080")]
	public HCEHBNODODP(DDFAMACOHHI<T> LFLGFFHCMEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x44C0150", Offset = "0x44BF350", VA = "0x1844C0150", Slot = "4")]
	public override bool OPAIAFJGAEK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class LDBBDFIMNCM<T> : HBFOFCDDDAL<DDFAMACOHHI<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly OMMPFNBDMDF<T> BAAGBBHLDLL;

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x49D4170", Offset = "0x49D3370", VA = "0x1849D4170")]
	public LDBBDFIMNCM(T MKMPLOHPJDC, DDFAMACOHHI<T> LFLGFFHCMEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x3F1FE00", Offset = "0x3F1F000", VA = "0x183F1FE00", Slot = "4")]
	public override bool OPAIAFJGAEK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class NIGFAGOCCJG<T> : HBFOFCDDDAL<KBCDBEBGNKN<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly GKEFCFFCOJG<T> AKHABDKNGKC;

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x4C82AB0", Offset = "0x4C81CB0", VA = "0x184C82AB0")]
	public NIGFAGOCCJG(T MKMPLOHPJDC, bool MNCPMMFJKOI, KBCDBEBGNKN<T> LFLGFFHCMEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x3F1FE00", Offset = "0x3F1F000", VA = "0x183F1FE00", Slot = "4")]
	public override bool OPAIAFJGAEK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct NCIFFOKHHKG<TData> where TData : notnull, BFAOOLHKJOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public IEnumerable<TData> LNLNBFBEIAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public bool FOPEHAEJOBI;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x4C6B910", Offset = "0x4C6AB10", VA = "0x184C6B910")]
	public NCIFFOKHHKG(IEnumerable<TData> JGMOJBKCECC, bool ENMGKHBDNNH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public struct BCFNFJPGLHN<TData> where TData : notnull, BFAOOLHKJOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public List<TData> LNLNBFBEIAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public List<bool> NHBLCHFEMKN;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5632B30", Offset = "0x5631D30", VA = "0x185632B30")]
	public BCFNFJPGLHN(List<TData> JGMOJBKCECC, List<bool> JKBJMEDMCGM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface BFAOOLHKJOI
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool LFMKCLLEKLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface LJKDDKDEFGE<TData> where TData : BFAOOLHKJOI
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OPAIAFJGAEK([In] NCIFFOKHHKG<TData> MFDNKPBMKJB);

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OPAIAFJGAEK([In] BCFNFJPGLHN<TData> MFDNKPBMKJB);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface CGEDGDMDEGO<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IJNKOGMGPPI(T MKMPLOHPJDC);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class KIJMMGPDJON<TData> : HBFOFCDDDAL<LJKDDKDEFGE<TData>> where TData : notnull, BFAOOLHKJOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly NCIFFOKHHKG<TData> MFDNKPBMKJB;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x4942E20", Offset = "0x4942020", VA = "0x184942E20")]
	public KIJMMGPDJON(List<TData> MHDKMAGHJOG, bool FOPEHAEJOBI, LJKDDKDEFGE<TData> LFLGFFHCMEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x3F1FE00", Offset = "0x3F1F000", VA = "0x183F1FE00", Slot = "4")]
	public override bool OPAIAFJGAEK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class MKLBDCEHPEG<TData> : HBFOFCDDDAL<LJKDDKDEFGE<TData>> where TData : notnull, BFAOOLHKJOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly BCFNFJPGLHN<TData> MFDNKPBMKJB;

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x4C01DF0", Offset = "0x4C00FF0", VA = "0x184C01DF0")]
	public MKLBDCEHPEG(List<TData> MHDKMAGHJOG, List<bool> NHBLCHFEMKN, LJKDDKDEFGE<TData> LFLGFFHCMEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x4C01D40", Offset = "0x4C00F40", VA = "0x184C01D40", Slot = "4")]
	public override bool OPAIAFJGAEK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface CPJDPILKJBK<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<FJEJONHLFLD> OPAIAFJGAEK(CCBDHOAMIDD<TData> PHJLENPNEAP);
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class NBIDJOFNPAN<TData> : KBCLEHEPCBP<CPJDPILKJBK<TData>, FJEJONHLFLD> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct AJBBOHFNHLF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public AsyncTaskMethodBuilder<FJEJONHLFLD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public NBIDJOFNPAN<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter<FJEJONHLFLD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x452E620", Offset = "0x452D820", VA = "0x18452E620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x452E900", Offset = "0x452DB00", VA = "0x18452E900", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly CCBDHOAMIDD<TData> BHCPONCPJKB;

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x4C65DB0", Offset = "0x4C64FB0", VA = "0x184C65DB0")]
	public NBIDJOFNPAN(TData LKILGDOPEJH, IReadOnlyList<TData> LFNLFOBAFIF, bool KEIJFMPDHPB, CPJDPILKJBK<TData> LFLGFFHCMEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x4C65CB0", Offset = "0x4C64EB0", VA = "0x184C65CB0", Slot = "4")]
	[AsyncStateMachine(typeof(NBIDJOFNPAN<>.AJBBOHFNHLF))]
	public override Task<FJEJONHLFLD> OPAIAFJGAEK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct CCBDHOAMIDD<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public TData FJPJKJDCKHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public IReadOnlyList<TData> NEEOMKGKPDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public bool PNPCDLAONAC;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x54AD240", Offset = "0x54AC440", VA = "0x1854AD240")]
	public CCBDHOAMIDD(TData LKILGDOPEJH, IReadOnlyList<TData> LFNLFOBAFIF, bool KEIJFMPDHPB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface KDABOIMLCOM<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OPAIAFJGAEK([In] ELAHOGPNBJF<TData> NHPBALHJMOO);
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface IDNJKOKDLHL<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OPAIAFJGAEK([In] HBGPPKHCLFL<TData> NHPBALHJMOO);
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface DGGFGNBNDBP<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AFCEBCPDKNI([In] HICFHMIJMDB<TData> NHPBALHJMOO);

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HMBKHFDGGKB();
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class LJKMOLBJFEI<TData> : HBFOFCDDDAL<KDABOIMLCOM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly ELAHOGPNBJF<TData> NHPBALHJMOO;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x49FF9D0", Offset = "0x49FEBD0", VA = "0x1849FF9D0")]
	public LJKMOLBJFEI(IEnumerable<TData> MHDKMAGHJOG, HOLOGFIEFDN HCHFCFNLIAI, DIABBMOAIAG HGJFBFIMOOD, float GEEPLGPHMLO, bool KEIJFMPDHPB, KDABOIMLCOM<TData> LFLGFFHCMEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3F1FE00", Offset = "0x3F1F000", VA = "0x183F1FE00", Slot = "4")]
	public override bool OPAIAFJGAEK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public class IMIKGMLFGAH<TData> : HBFOFCDDDAL<IDNJKOKDLHL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly HBGPPKHCLFL<TData> NHPBALHJMOO;

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x4653A40", Offset = "0x4652C40", VA = "0x184653A40")]
	public IMIKGMLFGAH(TData[] MHDKMAGHJOG, HOLOGFIEFDN[] HCHFCFNLIAI, DIABBMOAIAG[] HGJFBFIMOOD, float[] GEEPLGPHMLO, IDNJKOKDLHL<TData> LFLGFFHCMEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x4653990", Offset = "0x4652B90", VA = "0x184653990", Slot = "4")]
	public override bool OPAIAFJGAEK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class PIBEOEINHEK<TData> : HBFOFCDDDAL<DGGFGNBNDBP<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x42CB080", Offset = "0x42CA280", VA = "0x1842CB080")]
	public PIBEOEINHEK(DGGFGNBNDBP<TData> LFLGFFHCMEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x4F38B60", Offset = "0x4F37D60", VA = "0x184F38B60", Slot = "4")]
	public override bool OPAIAFJGAEK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class DAGODJOGIKC<TData> : HBFOFCDDDAL<DGGFGNBNDBP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private readonly HICFHMIJMDB<TData> NHPBALHJMOO;

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x604DB60", Offset = "0x604CD60", VA = "0x18604DB60")]
	public DAGODJOGIKC(IEnumerable<TData> MHDKMAGHJOG, HOLOGFIEFDN HCHFCFNLIAI, DIABBMOAIAG HGJFBFIMOOD, float GEEPLGPHMLO, DGGFGNBNDBP<TData> LFLGFFHCMEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x4653990", Offset = "0x4652B90", VA = "0x184653990", Slot = "4")]
	public override bool OPAIAFJGAEK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct ELAHOGPNBJF<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public IEnumerable<TData> LNLNBFBEIAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public HOLOGFIEFDN GOJFOHDEPKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public DIABBMOAIAG JFIBOJKBAAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public float GEEPLGPHMLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public bool KEIJFMPDHPB;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x3F1FFF0", Offset = "0x3F1F1F0", VA = "0x183F1FFF0")]
	public ELAHOGPNBJF(IEnumerable<TData> MHDKMAGHJOG, HOLOGFIEFDN HCHFCFNLIAI, DIABBMOAIAG HGJFBFIMOOD, float GEEPLGPHMLO, bool KEIJFMPDHPB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public struct HBGPPKHCLFL<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public TData[] LNLNBFBEIAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public HOLOGFIEFDN[] GOJFOHDEPKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public DIABBMOAIAG[] JFIBOJKBAAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public float[] GEEPLGPHMLO;

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x448D360", Offset = "0x448C560", VA = "0x18448D360")]
	public HBGPPKHCLFL(TData[] MHDKMAGHJOG, HOLOGFIEFDN[] HCHFCFNLIAI, DIABBMOAIAG[] HGJFBFIMOOD, float[] GEEPLGPHMLO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct HICFHMIJMDB<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public IEnumerable<TData> LNLNBFBEIAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public HOLOGFIEFDN GOJFOHDEPKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public DIABBMOAIAG JFIBOJKBAAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public float GEEPLGPHMLO;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x44DD650", Offset = "0x44DC850", VA = "0x1844DD650")]
	public HICFHMIJMDB(IEnumerable<TData> MHDKMAGHJOG, HOLOGFIEFDN HCHFCFNLIAI, DIABBMOAIAG HGJFBFIMOOD, float GEEPLGPHMLO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface OMNMMNDOCPB<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DKJLHEDFHEM([In] ECICADGLEGO<TData> AJAMLGKFLMG);

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AODJAHIGGMI([In] ECICADGLEGO<TData> AJAMLGKFLMG);

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JAFACJKBNBK([In] bool CAFPICNIFLO);

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CHJAHJJKKBM([In] ECICADGLEGO<TData> AJAMLGKFLMG);

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OBLPDLLJPJK();

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool DEPHMJILAIJ([In] TData LECGOGEFKBH);
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class EKPIFFAFDDK<TData> : HBFOFCDDDAL<OMNMMNDOCPB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly ECICADGLEGO<TData> AJAMLGKFLMG;

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3F1FEB0", Offset = "0x3F1F0B0", VA = "0x183F1FEB0")]
	public EKPIFFAFDDK(List<TData> GIJCPEPCKMK, OMNMMNDOCPB<TData> LFLGFFHCMEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3F1FE00", Offset = "0x3F1F000", VA = "0x183F1FE00", Slot = "4")]
	public override bool OPAIAFJGAEK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class GLDNFMPBOGM<TData> : HBFOFCDDDAL<OMNMMNDOCPB<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x42CB080", Offset = "0x42CA280", VA = "0x1842CB080")]
	public GLDNFMPBOGM(OMNMMNDOCPB<TData> LFLGFFHCMEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x445C0E0", Offset = "0x445B2E0", VA = "0x18445C0E0", Slot = "4")]
	public override bool OPAIAFJGAEK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class EMCNKPJBIJG<TData> : HBFOFCDDDAL<OMNMMNDOCPB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly bool KEIJFMPDHPB;

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3F22370", Offset = "0x3F21570", VA = "0x183F22370")]
	public EMCNKPJBIJG(bool KEIJFMPDHPB, OMNMMNDOCPB<TData> LFLGFFHCMEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3F22310", Offset = "0x3F21510", VA = "0x183F22310", Slot = "4")]
	public override bool OPAIAFJGAEK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class DCLLOAOGPGF<TData> : HBFOFCDDDAL<OMNMMNDOCPB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly ECICADGLEGO<TData> AJAMLGKFLMG;

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x60548B0", Offset = "0x6053AB0", VA = "0x1860548B0")]
	public DCLLOAOGPGF(List<TData> GIJCPEPCKMK, bool KEIJFMPDHPB, OMNMMNDOCPB<TData> LFLGFFHCMEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x4C01D40", Offset = "0x4C00F40", VA = "0x184C01D40", Slot = "4")]
	public override bool OPAIAFJGAEK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class NMHIAIFKNIG<TData> : HBFOFCDDDAL<OMNMMNDOCPB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly TData LECGOGEFKBH;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x4C9BAC0", Offset = "0x4C9ACC0", VA = "0x184C9BAC0")]
	public NMHIAIFKNIG(TData LECGOGEFKBH, OMNMMNDOCPB<TData> LFLGFFHCMEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x4C9B940", Offset = "0x4C9AB40", VA = "0x184C9B940", Slot = "4")]
	public override bool OPAIAFJGAEK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public class AOMPOMAEHED<TData> : HBFOFCDDDAL<OMNMMNDOCPB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly ECICADGLEGO<TData> AJAMLGKFLMG;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x453BDB0", Offset = "0x453AFB0", VA = "0x18453BDB0")]
	public AOMPOMAEHED(IEnumerable<TData> GIJCPEPCKMK, OMNMMNDOCPB<TData> LFLGFFHCMEJ, bool KEIJFMPDHPB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x453BCF0", Offset = "0x453AEF0", VA = "0x18453BCF0", Slot = "4")]
	public override bool OPAIAFJGAEK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct ECICADGLEGO<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public IEnumerable<TData> LNLNBFBEIAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public bool KEIJFMPDHPB;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x3EE74A0", Offset = "0x3EE66A0", VA = "0x183EE74A0")]
	public ECICADGLEGO(IEnumerable<TData> JGMOJBKCECC, bool HKAOEGECCKG = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface HLLCCAPGILH
{
	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<FJEJONHLFLD> OPAIAFJGAEK(HFDJFGLPGJB JNKENEKEBDH);
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class HGILKCBFCKP : KBCLEHEPCBP<HLLCCAPGILH, FJEJONHLFLD>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private struct GIBHKGIAOLM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public AsyncTaskMethodBuilder<FJEJONHLFLD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public HGILKCBFCKP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private TaskAwaiter<FJEJONHLFLD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x726EAF0", Offset = "0x726DCF0", VA = "0x18726EAF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x726ED60", Offset = "0x726DF60", VA = "0x18726ED60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly HFDJFGLPGJB MEPMEOFKMKM;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x726EEC0", Offset = "0x726E0C0", VA = "0x18726EEC0")]
	public HGILKCBFCKP(bool KEIJFMPDHPB, HLLCCAPGILH LFLGFFHCMEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x726EDD0", Offset = "0x726DFD0", VA = "0x18726EDD0", Slot = "4")]
	[AsyncStateMachine(typeof(GIBHKGIAOLM))]
	public override Task<FJEJONHLFLD> OPAIAFJGAEK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public struct HFDJFGLPGJB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public bool PNPCDLAONAC;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x26FF1B0", Offset = "0x26FE3B0", VA = "0x1826FF1B0")]
	public HFDJFGLPGJB(bool KEIJFMPDHPB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public readonly struct BLPFIHOJPNB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public readonly bool ODMLIJKGCGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public readonly bool EMIIABILEPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public readonly bool KGBNKPFPEFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public readonly bool KEIJFMPDHPB;

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x54CC500", Offset = "0x54CB700", VA = "0x1854CC500")]
	public BLPFIHOJPNB(bool ODMLIJKGCGJ, bool EMIIABILEPJ, bool KGBNKPFPEFM, bool KEIJFMPDHPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x726DB40", Offset = "0x726CD40", VA = "0x18726DB40")]
	public BLPFIHOJPNB(bool EMIIABILEPJ, bool KEIJFMPDHPB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public interface CBODDBJOPKJ
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IODCHOLIKDD(BLPFIHOJPNB HOFOJMFILEN);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KICLMEAAHGK(BLPFIHOJPNB HOFOJMFILEN);
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class LBAMGNJDDCC : HBFOFCDDDAL<CBODDBJOPKJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly BLPFIHOJPNB HOFOJMFILEN;

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x726EFD0", Offset = "0x726E1D0", VA = "0x18726EFD0")]
	public LBAMGNJDDCC(bool MCPAEAAAAAM, bool EMIIABILEPJ, bool KGBNKPFPEFM, bool KEIJFMPDHPB, CBODDBJOPKJ LFLGFFHCMEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x726EF80", Offset = "0x726E180", VA = "0x18726EF80", Slot = "4")]
	public override bool OPAIAFJGAEK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class EJJBBEHIKDA : HBFOFCDDDAL<CBODDBJOPKJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly BLPFIHOJPNB HOFOJMFILEN;

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x726E480", Offset = "0x726D680", VA = "0x18726E480")]
	public EJJBBEHIKDA(bool EMIIABILEPJ, bool KEIJFMPDHPB, CBODDBJOPKJ LFLGFFHCMEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x726E430", Offset = "0x726D630", VA = "0x18726E430", Slot = "4")]
	public override bool OPAIAFJGAEK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public interface JDLMPAONION
{
	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OPAIAFJGAEK([In] CDBONCBAMHP FDBFKDKCDHA);
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class FGJOBBNLNPG : HBFOFCDDDAL<JDLMPAONION>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly CDBONCBAMHP FDBFKDKCDHA;

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x726E5F0", Offset = "0x726D7F0", VA = "0x18726E5F0")]
	public FGJOBBNLNPG(Guid[] GHLFFMAPCGJ, Vector3[] ELNHNGMHBEL, Quaternion[] BDPBEHEBCMG, float[] KLIIKKKFIDM, Dictionary<Guid, Vector3> JFGIMDFPIMF, JDLMPAONION LFLGFFHCMEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x726E540", Offset = "0x726D740", VA = "0x18726E540", Slot = "4")]
	public override bool OPAIAFJGAEK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public interface GJEPMEOKJOH<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BMGHIFFOFOF([In] IAIGDHLIOBN<TData> PLMCDOHFGBJ);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool AFCEBCPDKNI([In] IHADFOHIDPG AHIIOFJMMKE);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool AFCEBCPDKNI([In] IHBNKLNOHGO AHIIOFJMMKE);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HMBKHFDGGKB();
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class CLBFKBAHHHK<TData> : HBFOFCDDDAL<GJEPMEOKJOH<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x42CB080", Offset = "0x42CA280", VA = "0x1842CB080")]
	public CLBFKBAHHHK(GJEPMEOKJOH<TData> LFLGFFHCMEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x5880B40", Offset = "0x587FD40", VA = "0x185880B40", Slot = "4")]
	public override bool OPAIAFJGAEK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public class DAMHIFBENBG<TData> : HBFOFCDDDAL<GJEPMEOKJOH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private readonly IHADFOHIDPG DJBNAMCOGDD;

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x604DFD0", Offset = "0x604D1D0", VA = "0x18604DFD0")]
	public DAMHIFBENBG(Vector3 GKHDPFOKELB, bool FGCIDCOCING, GJEPMEOKJOH<TData> LFLGFFHCMEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x4532790", Offset = "0x4531990", VA = "0x184532790", Slot = "4")]
	public override bool OPAIAFJGAEK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class BCGHJGNBHFL<TData> : HBFOFCDDDAL<GJEPMEOKJOH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly IHBNKLNOHGO DJBNAMCOGDD;

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x5633050", Offset = "0x5632250", VA = "0x185633050")]
	public BCGHJGNBHFL(Guid IICNHOPKJFD, int CPLNODNGKGB, Vector3 FCKJMOMOHAE, Quaternion EGIHDGHICMO, float COBBNHPDFBH, bool FGCIDCOCING, GJEPMEOKJOH<TData> LFLGFFHCMEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x5632FF0", Offset = "0x56321F0", VA = "0x185632FF0", Slot = "4")]
	public override bool OPAIAFJGAEK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public class PKBHPGJBALD<TData> : HBFOFCDDDAL<GJEPMEOKJOH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly IAIGDHLIOBN<TData> DJBNAMCOGDD;

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x4F3E530", Offset = "0x4F3D730", VA = "0x184F3E530")]
	public PKBHPGJBALD(TData MKMPLOHPJDC, bool KEIJFMPDHPB, GJEPMEOKJOH<TData> LFLGFFHCMEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x3F1FE00", Offset = "0x3F1F000", VA = "0x183F1FE00", Slot = "4")]
	public override bool OPAIAFJGAEK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public struct IHADFOHIDPG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public readonly Vector3 GKHDPFOKELB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public readonly bool FGCIDCOCING;

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x726EF20", Offset = "0x726E120", VA = "0x18726EF20")]
	public IHADFOHIDPG(Vector3 GKHDPFOKELB, bool FGCIDCOCING)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public struct IHBNKLNOHGO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public readonly Guid IICNHOPKJFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public readonly int CPLNODNGKGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public readonly Vector3 FCKJMOMOHAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public readonly Quaternion EGIHDGHICMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public readonly float COBBNHPDFBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public readonly bool FGCIDCOCING;

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x726EF40", Offset = "0x726E140", VA = "0x18726EF40")]
	public IHBNKLNOHGO(Guid IICNHOPKJFD, int CPLNODNGKGB, Vector3 FCKJMOMOHAE, Quaternion EGIHDGHICMO, float COBBNHPDFBH, bool FGCIDCOCING)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public struct IAIGDHLIOBN<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public readonly TData MKMPLOHPJDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public readonly bool KEIJFMPDHPB;

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x45A6390", Offset = "0x45A5590", VA = "0x1845A6390")]
	public IAIGDHLIOBN(TData MKMPLOHPJDC, bool KEIJFMPDHPB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public interface GIHHEGLDICG<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OPAIAFJGAEK([In] HCCGHBDAPAM<TData> OLCOKEGOKMG);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OPAIAFJGAEK([In] NCDPOFNALHA<TData> OLCOKEGOKMG);
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public interface GFMOLONGKPE<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BMGHIFFOFOF([In] JKBMOGBMDEM<TData> MMECOLEKEPF);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool AFCEBCPDKNI([In] IMNFKHHJJIC AHIIOFJMMKE);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HMBKHFDGGKB();
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class LCKCJEEDBAP<TData> : HBFOFCDDDAL<GIHHEGLDICG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private readonly HCCGHBDAPAM<TData> OLCOKEGOKMG;

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x49D3FC0", Offset = "0x49D31C0", VA = "0x1849D3FC0")]
	public LCKCJEEDBAP(IEnumerable<TData> MHDKMAGHJOG, Vector3 AJGGHNHDHHD, bool KEIJFMPDHPB, GIHHEGLDICG<TData> LFLGFFHCMEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x3F1FE00", Offset = "0x3F1F000", VA = "0x183F1FE00", Slot = "4")]
	public override bool OPAIAFJGAEK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public class MIBGKMJBLHN<TData> : HBFOFCDDDAL<GFMOLONGKPE<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x42CB080", Offset = "0x42CA280", VA = "0x1842CB080")]
	public MIBGKMJBLHN(GFMOLONGKPE<TData> LFLGFFHCMEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x44D61A0", Offset = "0x44D53A0", VA = "0x1844D61A0", Slot = "4")]
	public override bool OPAIAFJGAEK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class APOLAIKFIDF<TData> : HBFOFCDDDAL<GFMOLONGKPE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private readonly JKBMOGBMDEM<TData> OLCOKEGOKMG;

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x4546D10", Offset = "0x4545F10", VA = "0x184546D10")]
	public APOLAIKFIDF(IEnumerable<TData> MHDKMAGHJOG, bool KEIJFMPDHPB, GFMOLONGKPE<TData> LFLGFFHCMEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x3F1FE00", Offset = "0x3F1F000", VA = "0x183F1FE00", Slot = "4")]
	public override bool OPAIAFJGAEK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class MKECDLBLFJB<TData> : HBFOFCDDDAL<GIHHEGLDICG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly NCDPOFNALHA<TData> OLCOKEGOKMG;

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x4BFEE80", Offset = "0x4BFE080", VA = "0x184BFEE80")]
	public MKECDLBLFJB(IEnumerable<TData> MHDKMAGHJOG, Vector3 GNGBKOHADKO, KFKFHOGIOJO CJLNGFGAGHI, bool KEIJFMPDHPB, GIHHEGLDICG<TData> LFLGFFHCMEJ, Space KEJPNIANEJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x4BFEDC0", Offset = "0x4BFDFC0", VA = "0x184BFEDC0", Slot = "4")]
	public override bool OPAIAFJGAEK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class OABGEIABHBP<TData> : HBFOFCDDDAL<GFMOLONGKPE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly IMNFKHHJJIC OLCOKEGOKMG;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x4D83130", Offset = "0x4D82330", VA = "0x184D83130")]
	public OABGEIABHBP(Vector3 AJGGHNHDHHD, GFMOLONGKPE<TData> LFLGFFHCMEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x4532790", Offset = "0x4531990", VA = "0x184532790", Slot = "4")]
	public override bool OPAIAFJGAEK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public struct HCCGHBDAPAM<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public readonly IEnumerable<TData> MHDKMAGHJOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public readonly Vector3 AJGGHNHDHHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public readonly bool KEIJFMPDHPB;

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x44BEED0", Offset = "0x44BE0D0", VA = "0x1844BEED0")]
	public HCCGHBDAPAM(IEnumerable<TData> MHDKMAGHJOG, Vector3 AJGGHNHDHHD, bool KEIJFMPDHPB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public struct JKBMOGBMDEM<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public readonly IEnumerable<TData> MHDKMAGHJOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public readonly bool KEIJFMPDHPB;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x4831D70", Offset = "0x4830F70", VA = "0x184831D70")]
	public JKBMOGBMDEM(IEnumerable<TData> MHDKMAGHJOG, bool KEIJFMPDHPB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public struct NCDPOFNALHA<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public readonly IEnumerable<TData> MHDKMAGHJOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public readonly Vector3 GNGBKOHADKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public readonly KFKFHOGIOJO CJLNGFGAGHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public readonly bool KEIJFMPDHPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public readonly Space KEJPNIANEJH;

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x4C6B5C0", Offset = "0x4C6A7C0", VA = "0x184C6B5C0")]
	public NCDPOFNALHA(IEnumerable<TData> MHDKMAGHJOG, Vector3 GNGBKOHADKO, KFKFHOGIOJO CJLNGFGAGHI, bool KEIJFMPDHPB, Space KEJPNIANEJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public struct IMNFKHHJJIC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public readonly Vector3 AJGGHNHDHHD;

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x26FFFA0", Offset = "0x26FF1A0", VA = "0x1826FFFA0")]
	public IMNFKHHJJIC(Vector3 AJGGHNHDHHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public enum KFKFHOGIOJO
{
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	XYZ,
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	X_only,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	Y_only,
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	Z_only
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public interface GGHADJKKLBE
{
	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OPAIAFJGAEK([In] PPDKHJEMOBB KJJDABBALIP);
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class AKLNNNCGHOC : HBFOFCDDDAL<GGHADJKKLBE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly PPDKHJEMOBB KJJDABBALIP;

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x726D870", Offset = "0x726CA70", VA = "0x18726D870")]
	public AKLNNNCGHOC(bool KEIJFMPDHPB, GGHADJKKLBE LFLGFFHCMEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x726D7C0", Offset = "0x726C9C0", VA = "0x18726D7C0", Slot = "4")]
	public override bool OPAIAFJGAEK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public readonly struct PPDKHJEMOBB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly bool KEIJFMPDHPB;

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x26FF1B0", Offset = "0x26FE3B0", VA = "0x1826FF1B0")]
	public PPDKHJEMOBB(bool KEIJFMPDHPB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public interface APJPEBHLJKF<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OPAIAFJGAEK([In] JPBPIMODBLD<TData> HDADHANPIGK);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OPAIAFJGAEK([In] CNBHAJFJIHK<TData> HDADHANPIGK);
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public interface CLCDGFIEKAP<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BMGHIFFOFOF([In] MBJELIPGPEA<TData> PLMCDOHFGBJ);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool AFCEBCPDKNI([In] AINNLNILOEE AHIIOFJMMKE);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HMBKHFDGGKB();
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class NPAMFHOBJOA<TData> : HBFOFCDDDAL<APJPEBHLJKF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly JPBPIMODBLD<TData> HDADHANPIGK;

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x4CAE0B0", Offset = "0x4CAD2B0", VA = "0x184CAE0B0")]
	public NPAMFHOBJOA(IEnumerable<TData> MHDKMAGHJOG, Quaternion AJGGHNHDHHD, Vector3? LIEAMMNKIAF, bool PPENODMNMKK, bool KEIJFMPDHPB, APJPEBHLJKF<TData> LFLGFFHCMEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x3F1FE00", Offset = "0x3F1F000", VA = "0x183F1FE00", Slot = "4")]
	public override bool OPAIAFJGAEK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public class HGGEIKCNKPA<TData> : HBFOFCDDDAL<CLCDGFIEKAP<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x42CB080", Offset = "0x42CA280", VA = "0x1842CB080")]
	public HGGEIKCNKPA(CLCDGFIEKAP<TData> LFLGFFHCMEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x44D61A0", Offset = "0x44D53A0", VA = "0x1844D61A0", Slot = "4")]
	public override bool OPAIAFJGAEK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public class DHKLCJLLHNN<TData> : HBFOFCDDDAL<CLCDGFIEKAP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly MBJELIPGPEA<TData> HDADHANPIGK;

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x6077100", Offset = "0x6076300", VA = "0x186077100")]
	public DHKLCJLLHNN(IEnumerable<TData> MHDKMAGHJOG, bool KEIJFMPDHPB, CLCDGFIEKAP<TData> LFLGFFHCMEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x3F1FE00", Offset = "0x3F1F000", VA = "0x183F1FE00", Slot = "4")]
	public override bool OPAIAFJGAEK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public class MLLOODPONFB<TData> : HBFOFCDDDAL<APJPEBHLJKF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly CNBHAJFJIHK<TData> HDADHANPIGK;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x4C1C8E0", Offset = "0x4C1BAE0", VA = "0x184C1C8E0")]
	public MLLOODPONFB(IEnumerable<TData> MHDKMAGHJOG, Quaternion GBCIPCKNBEA, KFKFHOGIOJO LPKOBJEOCLG, Vector3? LIEAMMNKIAF, bool PPENODMNMKK, bool KEIJFMPDHPB, Space KEJPNIANEJH, APJPEBHLJKF<TData> LFLGFFHCMEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x4BFEDC0", Offset = "0x4BFDFC0", VA = "0x184BFEDC0", Slot = "4")]
	public override bool OPAIAFJGAEK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public class NHJPFCKKENH<TData> : HBFOFCDDDAL<CLCDGFIEKAP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly AINNLNILOEE HDADHANPIGK;

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x4C7A980", Offset = "0x4C79B80", VA = "0x184C7A980")]
	public NHJPFCKKENH(Quaternion AJGGHNHDHHD, Vector3? LIEAMMNKIAF, bool PPENODMNMKK, CLCDGFIEKAP<TData> LFLGFFHCMEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x4532790", Offset = "0x4531990", VA = "0x184532790", Slot = "4")]
	public override bool OPAIAFJGAEK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public struct JPBPIMODBLD<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public readonly IEnumerable<TData> MHDKMAGHJOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public readonly Quaternion AJGGHNHDHHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public readonly Vector3? LIEAMMNKIAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public readonly bool PPENODMNMKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public readonly bool KEIJFMPDHPB;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x484C400", Offset = "0x484B600", VA = "0x18484C400")]
	public JPBPIMODBLD(IEnumerable<TData> MHDKMAGHJOG, Quaternion AJGGHNHDHHD, Vector3? LIEAMMNKIAF, bool PPENODMNMKK, bool KEIJFMPDHPB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public struct MBJELIPGPEA<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public readonly IEnumerable<TData> MHDKMAGHJOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public readonly bool KEIJFMPDHPB;

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x4BDA510", Offset = "0x4BD9710", VA = "0x184BDA510")]
	public MBJELIPGPEA(IEnumerable<TData> MHDKMAGHJOG, bool KEIJFMPDHPB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public struct CNBHAJFJIHK<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public readonly IEnumerable<TData> MHDKMAGHJOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public readonly Quaternion GBCIPCKNBEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public readonly KFKFHOGIOJO LPKOBJEOCLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public readonly Vector3? LIEAMMNKIAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public readonly bool PPENODMNMKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public readonly bool KEIJFMPDHPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public readonly Space KEJPNIANEJH;

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x5886E70", Offset = "0x5886070", VA = "0x185886E70")]
	public CNBHAJFJIHK(IEnumerable<TData> MHDKMAGHJOG, Quaternion GBCIPCKNBEA, KFKFHOGIOJO LPKOBJEOCLG, Vector3? LIEAMMNKIAF, bool PPENODMNMKK, bool KEIJFMPDHPB, Space KEJPNIANEJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public struct AINNLNILOEE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public readonly Quaternion AJGGHNHDHHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public readonly Vector3? LIEAMMNKIAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public readonly bool PPENODMNMKK;

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x54914E0", Offset = "0x54906E0", VA = "0x1854914E0")]
	public AINNLNILOEE(Quaternion AJGGHNHDHHD, Vector3? LIEAMMNKIAF, bool PPENODMNMKK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public interface BGIMLNJEIIO<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BMGHIFFOFOF([In] COLMAPKHMOA<TData> PLMCDOHFGBJ);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool AFCEBCPDKNI([In] NAJEOLMMCKM AHIIOFJMMKE);

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool AFCEBCPDKNI([In] FHBBCDPDGAN AHIIOFJMMKE);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool AFCEBCPDKNI([In] AMOHKMLODDD AHIIOFJMMKE);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool HMBKHFDGGKB();
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class OEJJGIPNABD<TData> : HBFOFCDDDAL<BGIMLNJEIIO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private readonly AMOHKMLODDD AJIMCEEKGIJ;

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x4D9CC00", Offset = "0x4D9BE00", VA = "0x184D9CC00")]
	public OEJJGIPNABD(Vector3 OBPNBDCEEGP, float DDDEDIGFCFH, Vector3 LIEAMMNKIAF, bool ALNDGLMOAFN, bool GPJEMHAOFDM, BGIMLNJEIIO<TData> LFLGFFHCMEJ, Space KEJPNIANEJH = Space.Self)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x4D9CBA0", Offset = "0x4D9BDA0", VA = "0x184D9CBA0", Slot = "4")]
	public override bool OPAIAFJGAEK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public class OIIFJIMFGCO<TData> : HBFOFCDDDAL<BGIMLNJEIIO<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x42CB080", Offset = "0x42CA280", VA = "0x1842CB080")]
	public OIIFJIMFGCO(BGIMLNJEIIO<TData> LFLGFFHCMEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x4DC0020", Offset = "0x4DBF220", VA = "0x184DC0020", Slot = "4")]
	public override bool OPAIAFJGAEK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public class MAFOLIMNAOM<TData> : HBFOFCDDDAL<BGIMLNJEIIO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private readonly COLMAPKHMOA<TData> AJIMCEEKGIJ;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x4BD9420", Offset = "0x4BD8620", VA = "0x184BD9420")]
	public MAFOLIMNAOM(IEnumerable<TData> MHDKMAGHJOG, bool KEIJFMPDHPB, BGIMLNJEIIO<TData> LFLGFFHCMEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x3F1FE00", Offset = "0x3F1F000", VA = "0x183F1FE00", Slot = "4")]
	public override bool OPAIAFJGAEK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public class IFOFNOLKFAP<TData> : HBFOFCDDDAL<BGIMLNJEIIO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private readonly FHBBCDPDGAN AJIMCEEKGIJ;

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x461D7C0", Offset = "0x461C9C0", VA = "0x18461D7C0")]
	public IFOFNOLKFAP(float LJKMDMBGHKM, bool FHDIHACJEKC, Vector3 LIEAMMNKIAF, BGIMLNJEIIO<TData> LFLGFFHCMEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x461D700", Offset = "0x461C900", VA = "0x18461D700", Slot = "4")]
	public override bool OPAIAFJGAEK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public class AKAIMBCBOLO<TData> : HBFOFCDDDAL<BGIMLNJEIIO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private readonly NAJEOLMMCKM AJIMCEEKGIJ;

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x45327F0", Offset = "0x45319F0", VA = "0x1845327F0")]
	public AKAIMBCBOLO(float DDDEDIGFCFH, Vector3 LIEAMMNKIAF, BGIMLNJEIIO<TData> LFLGFFHCMEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x4532790", Offset = "0x4531990", VA = "0x184532790", Slot = "4")]
	public override bool OPAIAFJGAEK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct AMOHKMLODDD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public readonly Vector3 OBPNBDCEEGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public readonly float DDDEDIGFCFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public readonly Vector3 LIEAMMNKIAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public readonly bool FGCIDCOCING;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public readonly Space KEJPNIANEJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public readonly bool GPJEMHAOFDM;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x726D8D0", Offset = "0x726CAD0", VA = "0x18726D8D0")]
	public AMOHKMLODDD(Vector3 OBPNBDCEEGP, float DDDEDIGFCFH, Vector3 LIEAMMNKIAF, bool FGCIDCOCING, bool CKPNKOHBHFA, Space KEJPNIANEJH = Space.Self)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public struct COLMAPKHMOA<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public readonly IEnumerable<TData> MHDKMAGHJOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public readonly bool KEIJFMPDHPB;

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x588DF80", Offset = "0x588D180", VA = "0x18588DF80")]
	public COLMAPKHMOA(IEnumerable<TData> MHDKMAGHJOG, bool KEIJFMPDHPB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public struct FHBBCDPDGAN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly float LJKMDMBGHKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public readonly bool FHDIHACJEKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly Vector3 LIEAMMNKIAF;

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x726E7D0", Offset = "0x726D9D0", VA = "0x18726E7D0")]
	public FHBBCDPDGAN(float LJKMDMBGHKM, bool FHDIHACJEKC, Vector3 LIEAMMNKIAF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public struct NAJEOLMMCKM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public readonly float DDDEDIGFCFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public readonly Vector3 LIEAMMNKIAF;

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x5462AD0", Offset = "0x5461CD0", VA = "0x185462AD0")]
	public NAJEOLMMCKM(float DDDEDIGFCFH, Vector3 LIEAMMNKIAF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public struct CDBONCBAMHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public readonly Guid[] MHDKMAGHJOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public readonly bool NHHHKANMKDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public readonly bool FMFCKBAHDKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public readonly bool HPINOPDJING;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public readonly Vector3[] ELNHNGMHBEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public readonly Quaternion[] BDPBEHEBCMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public readonly float[] KLIIKKKFIDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public readonly Dictionary<Guid, Vector3> JFGIMDFPIMF;

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x726DD20", Offset = "0x726CF20", VA = "0x18726DD20")]
	public CDBONCBAMHP(Guid[] GHLFFMAPCGJ, Vector3[] ELNHNGMHBEL, Quaternion[] BDPBEHEBCMG, float[] KLIIKKKFIDM, Dictionary<Guid, Vector3> JFGIMDFPIMF, bool NHHHKANMKDP = true, bool FMFCKBAHDKA = true, bool HPINOPDJING = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x726DB50", Offset = "0x726CD50", VA = "0x18726DB50")]
	private static void GAPDEIFBAJP(Dictionary<Guid, Vector3> JFGIMDFPIMF, int GMMIIPFPBOJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public static class PKCBGPGNNKP
{
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	private struct PDIMHIPDGEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public bool ANKHFENLGCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public JBPONICDCIO EDAJPGPJGAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public JBPONICDCIO EIBJACEJMBG;
	}

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static PDIMHIPDGEH KMFNIBEPKJE;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static CancellationToken PACGCGGMHMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x726F410", Offset = "0x726E610", VA = "0x18726F410")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	internal static JBPONICDCIO EDAJPGPJGAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x726F5F0", Offset = "0x726E7F0", VA = "0x18726F5F0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x726F480", Offset = "0x726E680", VA = "0x18726F480")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x726F4F0", Offset = "0x726E6F0", VA = "0x18726F4F0")]
	[NAOGKPPNIGE.MIHKMKENDLB]
	internal static void NINIBBDHOGI(JBPONICDCIO CMHGPNGCPGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x726F690", Offset = "0x726E890", VA = "0x18726F690")]
	public static void OKECIINHNOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x726F430", Offset = "0x726E630", VA = "0x18726F430")]
	private static JBPONICDCIO HIJPINHMGOH(JBPONICDCIO KBFOJKJCKFK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public static class AFHOEOIMLIG
{
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public enum BFAJKIBIMLN
	{
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		ICreationContextObject,
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		Guid
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x39EBE90", Offset = "0x39EB090", VA = "0x1839EBE90")]
	public static void BAKINOCACKD<T>(T IEFGENALBBO, BFAJKIBIMLN MDOOANEGCAH) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x39EBFF0", Offset = "0x39EB1F0", VA = "0x1839EBFF0")]
	public static void BAKINOCACKD<T>(T IEFGENALBBO) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x39EBDE0", Offset = "0x39EAFE0", VA = "0x1839EBDE0")]
	public static void ADHAOFBFDKP<T>(T IEFGENALBBO) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x39EC060", Offset = "0x39EB260", VA = "0x1839EC060")]
	public static T BGMHNJIJIDG<T>(BFAJKIBIMLN MDOOANEGCAH) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x39EC110", Offset = "0x39EB310", VA = "0x1839EC110")]
	public static bool IDIICCOBMBP<T>(BFAJKIBIMLN MDOOANEGCAH, T? DENBHPABKPC, [Out][MaybeNullWhen(false)][NotNullWhen(true)] T EPCODJBGIJE) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x39EBD30", Offset = "0x39EAF30", VA = "0x1839EBD30")]
	public static bool AAKLAKAMIDK<T>(BFAJKIBIMLN MDOOANEGCAH) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x39EBCD0", Offset = "0x39EAED0", VA = "0x1839EBCD0")]
	public static T BGMHNJIJIDG<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x39EC260", Offset = "0x39EB460", VA = "0x1839EC260")]
	public static bool IDIICCOBMBP<T>(T DENBHPABKPC, [Out] T EPCODJBGIJE) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x39EBCD0", Offset = "0x39EAED0", VA = "0x1839EBCD0")]
	public static bool AAKLAKAMIDK<T>() where T : class
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
internal static class BAMAJINGBND
{
	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x726D910", Offset = "0x726CB10", VA = "0x18726D910")]
	public static void FGPFFLNDJCG(IEnumerable MEIJGFJFHHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x304AD70", Offset = "0x3049F70", VA = "0x18304AD70")]
	public static void FGPFFLNDJCG<T>(T[] HCOCCGHLKNN) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x304AF50", Offset = "0x304A150", VA = "0x18304AF50")]
	public static void FGPFFLNDJCG<T>(T NEBBNLAKKGH) where T : notnull, Enum
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
