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
		[Cpp2IlInjected.Address(RVA = "0x9827A0", Offset = "0x9813A0", VA = "0x1809827A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x74FEFC0", Offset = "0x74FDBC0", VA = "0x1874FEFC0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9836D0", Offset = "0x9822D0", VA = "0x1809836D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x983710", Offset = "0x982310", VA = "0x180983710")]
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
		[Cpp2IlInjected.Address(RVA = "0x74FF060", Offset = "0x74FDC60", VA = "0x1874FF060", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x240ECE0", Offset = "0x240D8E0", VA = "0x18240ECE0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface PIFDMAIFGKJ<TData, TReturn>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TReturn LOMCCEAKCDK(TData CFMCKCBBBKK);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface CPDFIPPLMFC<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ClearHoverTarget(APJOALEHJND FCJKIGPIMCK);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool SetHoverTarget(TData EJGAMJDEIEL, Collider NEGBGHBIJLI, APJOALEHJND FCJKIGPIMCK, [Optional] JCPBLDHJLEF? IOKKENJPDAN);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool TryGetHoverTarget([Out] TData EJGAMJDEIEL);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetHoverCollider([Out] Collider NEGBGHBIJLI);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface FNNBECIMAMC<TData> : EFDIMEJJBOI, KJBJNHHIHGK<TData>, HEPIAOPEBCH<TData>, BMCMKFHIFAB<TData>, BLHBEHEADCM, FHOGHCFCDMD<TData>, KBDMACMJKLL, IFBHBOBECKK
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface FHOGHCFCDMD<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 FIJLHFKGIID, Vector3 JJPEELBONAL, float JOBEKHJDCMI, [Out] T AGJBDIOOIBL, [Out] Vector3 EMCEAGFEJPJ, [Out] Collider NEGBGHBIJLI);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 FIJLHFKGIID, Vector3 JJPEELBONAL, float OCMHEEGPGIO, float JOBEKHJDCMI, T[] IKGLIGEKFDF, [Out] Vector3 IIILHLDNKNM, [Out] Collider CMKNMOJGDIO);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 FIJLHFKGIID, float OCMHEEGPGIO, Vector3 FPEELFGCNJB, T[] IKGLIGEKFDF);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetObjectFromColliderInCurrentScope(Collider IFONAJCBDBF, [Out] T MOLHGMNPNNJ);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface EFDIMEJJBOI
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Bounds KODLNMHFFEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Transform IGCPCLCEOJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Bounds HPLCNMNEFFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Transform COCBJNIAKFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Vector3 EILDONIKPID
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool MIGONOOCBMF
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
	void SetSelectionBoundsDirty(bool GEIOLEMCKLJ = true, int HAOOFDOEPEA = 0);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ShouldHideSelectionBoundsPreview(bool FKJHIBDCCFP, object IKLHDHMJFFL);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface IFBHBOBECKK
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	NCEKLMPIJLO NOALGIEMILA
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface NPLCJGMGGGO
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool DMAHLAPLFMH
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool FDPANHCINEI
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool ELNFJKBDHGF
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
	void TrySetPreviousCloneMapping(Dictionary<Guid, Guid> IPEHMDAEOOJ);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface BMCMKFHIFAB<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool KAOIIPHPDFF
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int EBBEGPFKEGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<TData> IIEJPLKCPGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData HLGDOFMLIOK);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData HLGDOFMLIOK);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface KJBJNHHIHGK<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T CFMCKCBBBKK, [Optional] JCPBLDHJLEF? PELCJAFICFI, bool JPBPJBKICGL = true);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int EBDKDADIOBA, IEnumerable<T> LCMFCDHANCJ, bool JPBPJBKICGL = true);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int EBDKDADIOBA, IEnumerable<T> LCMFCDHANCJ, JCPBLDHJLEF PELCJAFICFI, bool JPBPJBKICGL = true);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface KBDMACMJKLL
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface BLHBEHEADCM
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool MMCBMONPBFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool BMOBIJJEKPN
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool PIICBJDDMHF
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool OPBDAFEMIPL
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class PFDNGMGPLJJ<TReceiver> : LKMKBFCHODJ<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3FC0A50", Offset = "0x3FBF650", VA = "0x183FC0A50")]
	public PFDNGMGPLJJ(TReceiver JHNAPAEKPAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public abstract class AHONDFKHOFD<TReceiver, TFromTask> : LKMKBFCHODJ<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3FC0A50", Offset = "0x3FBF650", VA = "0x183FC0A50")]
	public AHONDFKHOFD(TReceiver JHNAPAEKPAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public abstract class LKMKBFCHODJ<TReceiver, TFromExecute> where TReceiver : notnull where TFromExecute : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	protected TReceiver JHNAPAEKPAE;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4B3F7F0", Offset = "0x4B3E3F0", VA = "0x184B3F7F0")]
	public LKMKBFCHODJ(TReceiver JHNAPAEKPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute DOIAJGGJPHE();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class CMGLJCGNNHG<TReceiver, TResult> : LKMKBFCHODJ<TReceiver, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3FC0A50", Offset = "0x3FBF650", VA = "0x183FC0A50")]
	public CMGLJCGNNHG(TReceiver JHNAPAEKPAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct FFGLNAEKCNO<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public TGroup JPJBOKDFJBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public TData NOHNAAJMGED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public IEnumerable<TData> CLICJENOKMF;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x241F880", Offset = "0x241E480", VA = "0x18241F880")]
	public FFGLNAEKCNO(TGroup ELOKDPJPHAI, TData BHOAPNPJKBM, IEnumerable<TData> DPFJOFOCPMI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct DKGDIBLJLEI<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public TGroup JPJBOKDFJBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public IEnumerable<TData> CLICJENOKMF;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x9DD890", Offset = "0x9DC490", VA = "0x1809DD890")]
	public DKGDIBLJLEI(TGroup ELOKDPJPHAI, IEnumerable<TData> DPFJOFOCPMI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct GIHCGJIPPMP<TGroup> where TGroup : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public TGroup JPJBOKDFJBO;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0xBDB470", Offset = "0xBDA070", VA = "0x180BDB470")]
	public GIHCGJIPPMP(TGroup ELOKDPJPHAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct FHHKCDAOODD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public IEnumerable<Guid> CLICJENOKMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public Guid JMHHCJFLGBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public readonly bool PGHKFDFOLLP;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x74FDBA0", Offset = "0x74FC7A0", VA = "0x1874FDBA0")]
	public FHHKCDAOODD(IEnumerable<Guid> DPFJOFOCPMI, Guid JAJDEJICBLH, bool CAPNHDNJPAG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct PLLOFNEAEEE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public Guid JMHHCJFLGBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly bool PGHKFDFOLLP;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x228A450", Offset = "0x2289050", VA = "0x18228A450")]
	public PLLOFNEAEEE(Guid JAJDEJICBLH, bool CAPNHDNJPAG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface CNEHLDKLELE<TGroup, TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PIOJPIDCLBF PCOIKKAGLAO(FFGLNAEKCNO<TGroup, TData> IOBGPFAGOBB);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "1")]
	PIOJPIDCLBF BLLCCIGLLGA(FFGLNAEKCNO<TGroup, TData> IOBGPFAGOBB);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "2")]
	PIOJPIDCLBF ACLBJEKPPOC(DKGDIBLJLEI<TGroup, TData> IOBGPFAGOBB);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	PIOJPIDCLBF JFJMKFMAEAB(GIHCGJIPPMP<TGroup> IOBGPFAGOBB);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface EFODJJJKLJL
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<PIOJPIDCLBF> PCOIKKAGLAO(FHHKCDAOODD IOBGPFAGOBB);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<PIOJPIDCLBF> BLLCCIGLLGA(PLLOFNEAEEE IOBGPFAGOBB);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class ECCLBLJLAPB<TGroup, TData> : CMGLJCGNNHG<CNEHLDKLELE<TGroup, TData>, PIOJPIDCLBF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly DKGDIBLJLEI<TGroup, TData> IOBGPFAGOBB;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3FB2EA0", Offset = "0x3FB1AA0", VA = "0x183FB2EA0")]
	public ECCLBLJLAPB(TGroup ELOKDPJPHAI, IEnumerable<TData> DPFJOFOCPMI, CNEHLDKLELE<TGroup, TData> JHNAPAEKPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3FB2DD0", Offset = "0x3FB19D0", VA = "0x183FB2DD0", Slot = "4")]
	public override PIOJPIDCLBF DOIAJGGJPHE()
	{
		return default(PIOJPIDCLBF);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class FKNJBELGOOD<TGroup, TData> : CMGLJCGNNHG<CNEHLDKLELE<TGroup, TData>, PIOJPIDCLBF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly FFGLNAEKCNO<TGroup, TData> IOBGPFAGOBB;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4413F90", Offset = "0x4412B90", VA = "0x184413F90")]
	public FKNJBELGOOD(TGroup ELOKDPJPHAI, TData MONNJCGEDLK, IEnumerable<TData> DPFJOFOCPMI, CNEHLDKLELE<TGroup, TData> JHNAPAEKPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x4413EC0", Offset = "0x4412AC0", VA = "0x184413EC0", Slot = "4")]
	public override PIOJPIDCLBF DOIAJGGJPHE()
	{
		return default(PIOJPIDCLBF);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class KICDAOFOFMB<TGroup, TData> : CMGLJCGNNHG<CNEHLDKLELE<TGroup, TData>, PIOJPIDCLBF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly GIHCGJIPPMP<TGroup> IOBGPFAGOBB;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x4394140", Offset = "0x4392D40", VA = "0x184394140")]
	public KICDAOFOFMB(TGroup ELOKDPJPHAI, CNEHLDKLELE<TGroup, TData> JHNAPAEKPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x4A6DD10", Offset = "0x4A6C910", VA = "0x184A6DD10", Slot = "4")]
	public override PIOJPIDCLBF DOIAJGGJPHE()
	{
		return default(PIOJPIDCLBF);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class ADHCMOCICFN<TGroup, TData> : CMGLJCGNNHG<CNEHLDKLELE<TGroup, TData>, PIOJPIDCLBF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly FFGLNAEKCNO<TGroup, TData> IOBGPFAGOBB;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4413F90", Offset = "0x4412B90", VA = "0x184413F90")]
	public ADHCMOCICFN(TGroup ELOKDPJPHAI, TData BHOAPNPJKBM, IEnumerable<TData> DPFJOFOCPMI, CNEHLDKLELE<TGroup, TData> JHNAPAEKPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4546BC0", Offset = "0x45457C0", VA = "0x184546BC0", Slot = "4")]
	public override PIOJPIDCLBF DOIAJGGJPHE()
	{
		return default(PIOJPIDCLBF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class LHJGBNABBDK : AHONDFKHOFD<EFODJJJKLJL, PIOJPIDCLBF>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private struct DKBHOADNLHA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public AsyncTaskMethodBuilder<PIOJPIDCLBF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public LHJGBNABBDK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private TaskAwaiter<PIOJPIDCLBF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x74FD430", Offset = "0x74FC030", VA = "0x1874FD430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x74FD6C0", Offset = "0x74FC2C0", VA = "0x1874FD6C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private FHHKCDAOODD IOBGPFAGOBB;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x74FEBB0", Offset = "0x74FD7B0", VA = "0x1874FEBB0")]
	public LHJGBNABBDK(IEnumerable<Guid> GGHLKFDDIJF, Guid JAJDEJICBLH, bool CAPNHDNJPAG, EFODJJJKLJL JHNAPAEKPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x74FEAC0", Offset = "0x74FD6C0", VA = "0x1874FEAC0", Slot = "4")]
	[AsyncStateMachine(typeof(DKBHOADNLHA))]
	public override Task<PIOJPIDCLBF> DOIAJGGJPHE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class KIKAPCDLHOP : AHONDFKHOFD<EFODJJJKLJL, PIOJPIDCLBF>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private struct MGIPEOKDFMN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public AsyncTaskMethodBuilder<PIOJPIDCLBF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public KIKAPCDLHOP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private TaskAwaiter<PIOJPIDCLBF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x74FEC70", Offset = "0x74FD870", VA = "0x1874FEC70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x74FEF10", Offset = "0x74FDB10", VA = "0x1874FEF10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly PLLOFNEAEEE IOBGPFAGOBB;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x74FE7B0", Offset = "0x74FD3B0", VA = "0x1874FE7B0")]
	public KIKAPCDLHOP(Guid JAJDEJICBLH, bool CAPNHDNJPAG, EFODJJJKLJL JHNAPAEKPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x74FE6C0", Offset = "0x74FD2C0", VA = "0x1874FE6C0", Slot = "4")]
	[AsyncStateMachine(typeof(MGIPEOKDFMN))]
	public override Task<PIOJPIDCLBF> DOIAJGGJPHE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public readonly struct ECFJOGCFGAG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly EEMHAPGHBFN LAAINKJFLHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly bool PGHKFDFOLLP;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x74FD960", Offset = "0x74FC560", VA = "0x1874FD960")]
	public ECFJOGCFGAG(EEMHAPGHBFN BANLPDDMGFB, bool CAPNHDNJPAG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface BIEHEIBJJEN<TSpawnType> where TSpawnType : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> DOIAJGGJPHE(ECFJOGCFGAG FLCIMKBIBHP);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class AJFMDFEDNBM<TSpawnType> : AHONDFKHOFD<BIEHEIBJJEN<TSpawnType>, TSpawnType> where TSpawnType : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private struct ILDKNGAFKDB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AsyncTaskMethodBuilder<TSpawnType> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public AJFMDFEDNBM<TSpawnType> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private TaskAwaiter<TSpawnType> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x470A020", Offset = "0x4708C20", VA = "0x18470A020", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x4006FB0", Offset = "0x4005BB0", VA = "0x184006FB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly ECFJOGCFGAG FLCIMKBIBHP;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x4670880", Offset = "0x466F480", VA = "0x184670880")]
	public AJFMDFEDNBM(EEMHAPGHBFN BANLPDDMGFB, bool CAPNHDNJPAG, BIEHEIBJJEN<TSpawnType> JHNAPAEKPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x4670770", Offset = "0x466F370", VA = "0x184670770", Slot = "4")]
	[AsyncStateMachine(typeof(AJFMDFEDNBM<>.ILDKNGAFKDB))]
	public override Task<TSpawnType> DOIAJGGJPHE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public readonly struct EEMHAPGHBFN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly bool LPDFOMOFAMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly Vector3 PPMOPOJLBMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly Vector3 JCCKFLFINHG;

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x74FDA60", Offset = "0x74FC660", VA = "0x1874FDA60")]
	public EEMHAPGHBFN(Transform GOJPOCADDGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x74FDA30", Offset = "0x74FC630", VA = "0x1874FDA30")]
	public EEMHAPGHBFN(Vector3 HKFKAONALCJ, Vector3 FCININPMBGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x74FD980", Offset = "0x74FC580", VA = "0x1874FD980")]
	public static EEMHAPGHBFN JNBLFNDBNCH()
	{
		return default(EEMHAPGHBFN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x74FD9B0", Offset = "0x74FC5B0", VA = "0x1874FD9B0")]
	private EEMHAPGHBFN(bool PIGAMPEEIMI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct PNBEFGKHMPI<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public TNode IDDIHGAIHFF;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5074360", Offset = "0x5072F60", VA = "0x185074360")]
	public PNBEFGKHMPI(TNode IDDIHGAIHFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct APEDKMMIADI<TNode, TReparentOperations> where TNode : notnull where TReparentOperations : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public TNode HPFMHMAADHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public TReparentOperations PCCDBCHBPFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public IIAHLDDEEBG CFOPMOGANGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly bool PGHKFDFOLLP;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x477D6C0", Offset = "0x477C2C0", VA = "0x18477D6C0")]
	public APEDKMMIADI(TNode HPFMHMAADHN, TReparentOperations PCCDBCHBPFI, IIAHLDDEEBG CFOPMOGANGI, bool CAPNHDNJPAG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface GOCFEPGCILN<TNode, TReparentOperations>
{
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KOHHNODLOCO([In] PNBEFGKHMPI<TNode> GDDFHOFKHIE);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IIJCBFPOBIJ([In] APEDKMMIADI<TNode, TReparentOperations> EMLNMDLMAJK);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HCANDMPPIAK();
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class MBANNCJNLBH<TNode, TReparentOperations> : PFDNGMGPLJJ<GOCFEPGCILN<TNode, TReparentOperations>>
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3FC0A50", Offset = "0x3FBF650", VA = "0x183FC0A50")]
	public MBANNCJNLBH(GOCFEPGCILN<TNode, TReparentOperations> JHNAPAEKPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x454A6D0", Offset = "0x45492D0", VA = "0x18454A6D0", Slot = "4")]
	public override bool DOIAJGGJPHE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class LHIKFCEDMAO<TNode, TReparentOperations> : PFDNGMGPLJJ<GOCFEPGCILN<TNode, TReparentOperations>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly APEDKMMIADI<TNode, TReparentOperations> EMLNMDLMAJK;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x4B34D00", Offset = "0x4B33900", VA = "0x184B34D00")]
	public LHIKFCEDMAO(TNode HPFMHMAADHN, TReparentOperations PCCDBCHBPFI, IIAHLDDEEBG CFOPMOGANGI, GOCFEPGCILN<TNode, TReparentOperations> JHNAPAEKPAE, bool CAPNHDNJPAG = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x48D49D0", Offset = "0x48D35D0", VA = "0x1848D49D0", Slot = "4")]
	public override bool DOIAJGGJPHE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class MJIOFPKPCNB<TNode, TReparentOperations> : PFDNGMGPLJJ<GOCFEPGCILN<TNode, TReparentOperations>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly PNBEFGKHMPI<TNode> GDDFHOFKHIE;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x4D77A10", Offset = "0x4D76610", VA = "0x184D77A10")]
	public MJIOFPKPCNB(TNode LBDOGNBMMNJ, GOCFEPGCILN<TNode, TReparentOperations> JHNAPAEKPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x3FF2DF0", Offset = "0x3FF19F0", VA = "0x183FF2DF0", Slot = "4")]
	public override bool DOIAJGGJPHE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct CNEPKLCIHIG<TSpawnInfo> where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public TSpawnInfo GKDKGCLKLMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public Vector3 FCININPMBGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public Quaternion APLHHNGOEFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public float PCNANBOKIPD;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5BA9B60", Offset = "0x5BA8760", VA = "0x185BA9B60")]
	public CNEPKLCIHIG(TSpawnInfo GKDKGCLKLMH, Vector3 FCININPMBGJ, Quaternion APLHHNGOEFP, float PCNANBOKIPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface GEOHJPADOKC<TSpawnType, TSpawnInfo>
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> KBDHCJGPKLN([In] CNEPKLCIHIG<TSpawnInfo> BNNIHJEHOHF, CancellationToken NAOIMKEDKEJ);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public class FMNECALPKHP<TSpawnType, TSpawnInfo> : AHONDFKHOFD<GEOHJPADOKC<TSpawnType, TSpawnInfo>, TSpawnType> where TSpawnType : notnull where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly CNEPKLCIHIG<TSpawnInfo> IGPONJDPFGI;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x441B330", Offset = "0x4419F30", VA = "0x18441B330")]
	public FMNECALPKHP(TSpawnInfo GCKANECBGBI, Vector3 FCININPMBGJ, Quaternion APLHHNGOEFP, float PCNANBOKIPD, GEOHJPADOKC<TSpawnType, TSpawnInfo> JHNAPAEKPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x441B130", Offset = "0x4419D30", VA = "0x18441B130", Slot = "4")]
	public override Task<TSpawnType> DOIAJGGJPHE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public readonly struct GDGBPLCOAIO<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly IEnumerable<TData> CLICJENOKMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly bool PGHKFDFOLLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly bool NMLNPJHDILJ;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x44C0AC0", Offset = "0x44BF6C0", VA = "0x1844C0AC0")]
	public GDGBPLCOAIO(IEnumerable<TData> DPFJOFOCPMI, bool CAPNHDNJPAG = false, bool NKGFHMOIMAA = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface NOIAGMEFKBF<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<PIOJPIDCLBF> FMJCKHKMKCO([In] GDGBPLCOAIO<TData> DIFEMLDAFBP, CancellationToken NAOIMKEDKEJ);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class ICJHDEDONBG<TData> : AHONDFKHOFD<NOIAGMEFKBF<TData>, PIOJPIDCLBF> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly GDGBPLCOAIO<TData> KCKKOIHNDPE;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x46E8630", Offset = "0x46E7230", VA = "0x1846E8630")]
	public ICJHDEDONBG(IEnumerable<TData> DPFJOFOCPMI, bool CAPNHDNJPAG, NOIAGMEFKBF<TData> JHNAPAEKPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x441B130", Offset = "0x4419D30", VA = "0x18441B130", Slot = "4")]
	public override Task<PIOJPIDCLBF> DOIAJGGJPHE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct BHLABPJAOCF<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly T EJGAMJDEIEL;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5515F10", Offset = "0x5514B10", VA = "0x185515F10")]
	public BHLABPJAOCF(T HDAHIHLHPLK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface FMIHCILOLFE<T>
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KOHHNODLOCO([In] BHLABPJAOCF<T> CHIJFBGMPIA);

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IIJCBFPOBIJ();
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface JDIDIDKCINO<T>
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DOIAJGGJPHE([In] GFEDAKEEJIK<T> HIAOAKFBJCO);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct GFEDAKEEJIK<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly T EJGAMJDEIEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly bool CPMBJNCAADP;

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x44C2FD0", Offset = "0x44C1BD0", VA = "0x1844C2FD0")]
	public GFEDAKEEJIK(T HDAHIHLHPLK, bool CIJBGKCFEEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class LJFKONGJGEH<T> : PFDNGMGPLJJ<FMIHCILOLFE<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x3FC0A50", Offset = "0x3FBF650", VA = "0x183FC0A50")]
	public LJFKONGJGEH(FMIHCILOLFE<T> JHNAPAEKPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x4B3C3B0", Offset = "0x4B3AFB0", VA = "0x184B3C3B0", Slot = "4")]
	public override bool DOIAJGGJPHE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class FGFCMOEOIPK<T> : PFDNGMGPLJJ<FMIHCILOLFE<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly BHLABPJAOCF<T> CHIJFBGMPIA;

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x43941C0", Offset = "0x4392DC0", VA = "0x1843941C0")]
	public FGFCMOEOIPK(T EJGAMJDEIEL, FMIHCILOLFE<T> JHNAPAEKPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x3FF2DF0", Offset = "0x3FF19F0", VA = "0x183FF2DF0", Slot = "4")]
	public override bool DOIAJGGJPHE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class CIJIFBNPCOK<T> : PFDNGMGPLJJ<JDIDIDKCINO<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly GFEDAKEEJIK<T> HIAOAKFBJCO;

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5AB29E0", Offset = "0x5AB15E0", VA = "0x185AB29E0")]
	public CIJIFBNPCOK(T EJGAMJDEIEL, bool CIJBGKCFEEA, JDIDIDKCINO<T> JHNAPAEKPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x3FF2DF0", Offset = "0x3FF19F0", VA = "0x183FF2DF0", Slot = "4")]
	public override bool DOIAJGGJPHE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct BLCMFCADODJ<TData> where TData : notnull, JDGFCGEBCAB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public IEnumerable<TData> CLICJENOKMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public bool KACNPEMDPIF;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x580AEA0", Offset = "0x5809AA0", VA = "0x18580AEA0")]
	public BLCMFCADODJ(IEnumerable<TData> KCAIGABNMOG, bool LNBICLGGBLN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public struct ODLNJCMNJNM<TData> where TData : notnull, JDGFCGEBCAB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public List<TData> CLICJENOKMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public List<bool> GEDBIANGMKO;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x4F71050", Offset = "0x4F6FC50", VA = "0x184F71050")]
	public ODLNJCMNJNM(List<TData> KCAIGABNMOG, List<bool> DACHNIPPNKC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface JDGFCGEBCAB
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool OFFNHBGMDMH
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
public interface DKOFJPIOOPA<TData> where TData : JDGFCGEBCAB
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DOIAJGGJPHE([In] BLCMFCADODJ<TData> FLIFLLOHFND);

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DOIAJGGJPHE([In] ODLNJCMNJNM<TData> FLIFLLOHFND);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface ELDKEPHJHLL<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PPJHEEFEJOO(T EJGAMJDEIEL);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class NFFOOKDCOEI<TData> : PFDNGMGPLJJ<DKOFJPIOOPA<TData>> where TData : notnull, JDGFCGEBCAB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly BLCMFCADODJ<TData> FLIFLLOHFND;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x4DF2CB0", Offset = "0x4DF18B0", VA = "0x184DF2CB0")]
	public NFFOOKDCOEI(List<TData> DPFJOFOCPMI, bool KACNPEMDPIF, DKOFJPIOOPA<TData> JHNAPAEKPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x3FF2DF0", Offset = "0x3FF19F0", VA = "0x183FF2DF0", Slot = "4")]
	public override bool DOIAJGGJPHE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class FHBCBDBNFIH<TData> : PFDNGMGPLJJ<DKOFJPIOOPA<TData>> where TData : notnull, JDGFCGEBCAB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly ODLNJCMNJNM<TData> FLIFLLOHFND;

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x4394CC0", Offset = "0x43938C0", VA = "0x184394CC0")]
	public FHBCBDBNFIH(List<TData> DPFJOFOCPMI, List<bool> GEDBIANGMKO, DKOFJPIOOPA<TData> JHNAPAEKPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x4394C00", Offset = "0x4393800", VA = "0x184394C00", Slot = "4")]
	public override bool DOIAJGGJPHE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface KLOGGDJPLNK<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<PIOJPIDCLBF> DOIAJGGJPHE(CHFCLPEEAFN<TData> ILJDFIIPEIC);
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class CJNGEKLLOGD<TData> : AHONDFKHOFD<KLOGGDJPLNK<TData>, PIOJPIDCLBF> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct FMJNEFBNKJL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public AsyncTaskMethodBuilder<PIOJPIDCLBF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public CJNGEKLLOGD<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter<PIOJPIDCLBF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x441A260", Offset = "0x4418E60", VA = "0x18441A260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x441A540", Offset = "0x4419140", VA = "0x18441A540", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly CHFCLPEEAFN<TData> DKGPEAPGCLI;

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x5B97A20", Offset = "0x5B96620", VA = "0x185B97A20")]
	public CJNGEKLLOGD(TData FEAMCGJHCFE, IReadOnlyList<TData> FAJGNJPHIGF, bool CAPNHDNJPAG, KLOGGDJPLNK<TData> JHNAPAEKPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5B97920", Offset = "0x5B96520", VA = "0x185B97920", Slot = "4")]
	[AsyncStateMachine(typeof(CJNGEKLLOGD<>.FMJNEFBNKJL))]
	public override Task<PIOJPIDCLBF> DOIAJGGJPHE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct CHFCLPEEAFN<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public TData KHDPDOKFJHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public IReadOnlyList<TData> PMGCFHAENGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public bool PGHKFDFOLLP;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5636990", Offset = "0x5635590", VA = "0x185636990")]
	public CHFCLPEEAFN(TData FEAMCGJHCFE, IReadOnlyList<TData> FAJGNJPHIGF, bool CAPNHDNJPAG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface NIMHGMNPHPN<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DOIAJGGJPHE([In] OIPMBOINGMD<TData> LJCFNFBNEHO);
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface BDJBHNAKCMP<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DOIAJGGJPHE([In] HEEKGDONENL<TData> LJCFNFBNEHO);
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface LIBEDLFJHHC<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IKLNMOCHLDI([In] OHOMONECLIL<TData> LJCFNFBNEHO);

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IIJCBFPOBIJ();
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class OGOJFLMCCLF<TData> : PFDNGMGPLJJ<NIMHGMNPHPN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly OIPMBOINGMD<TData> LJCFNFBNEHO;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x4F7B3D0", Offset = "0x4F79FD0", VA = "0x184F7B3D0")]
	public OGOJFLMCCLF(IEnumerable<TData> DPFJOFOCPMI, IIENBPKDKHB PFOKHHCFPNE, DLFEHIBNHLA LBEFIBKFEIP, float PAELBJKLMOH, bool CAPNHDNJPAG, NIMHGMNPHPN<TData> JHNAPAEKPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3FF2DF0", Offset = "0x3FF19F0", VA = "0x183FF2DF0", Slot = "4")]
	public override bool DOIAJGGJPHE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public class MCLMDAPLGBK<TData> : PFDNGMGPLJJ<BDJBHNAKCMP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly HEEKGDONENL<TData> LJCFNFBNEHO;

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x4D3ACB0", Offset = "0x4D398B0", VA = "0x184D3ACB0")]
	public MCLMDAPLGBK(TData[] DPFJOFOCPMI, IIENBPKDKHB[] PFOKHHCFPNE, DLFEHIBNHLA[] LBEFIBKFEIP, float[] PAELBJKLMOH, BDJBHNAKCMP<TData> JHNAPAEKPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x463CC70", Offset = "0x463B870", VA = "0x18463CC70", Slot = "4")]
	public override bool DOIAJGGJPHE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class OFGMAOKNEMP<TData> : PFDNGMGPLJJ<LIBEDLFJHHC<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x3FC0A50", Offset = "0x3FBF650", VA = "0x183FC0A50")]
	public OFGMAOKNEMP(LIBEDLFJHHC<TData> JHNAPAEKPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x4F77FC0", Offset = "0x4F76BC0", VA = "0x184F77FC0", Slot = "4")]
	public override bool DOIAJGGJPHE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class HNCMMJIMECJ<TData> : PFDNGMGPLJJ<LIBEDLFJHHC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private readonly OHOMONECLIL<TData> LJCFNFBNEHO;

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x463CD30", Offset = "0x463B930", VA = "0x18463CD30")]
	public HNCMMJIMECJ(IEnumerable<TData> DPFJOFOCPMI, IIENBPKDKHB PFOKHHCFPNE, DLFEHIBNHLA LBEFIBKFEIP, float PAELBJKLMOH, LIBEDLFJHHC<TData> JHNAPAEKPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x463CC70", Offset = "0x463B870", VA = "0x18463CC70", Slot = "4")]
	public override bool DOIAJGGJPHE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct OIPMBOINGMD<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public IEnumerable<TData> CLICJENOKMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public IIENBPKDKHB HDIDGNBMAFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public DLFEHIBNHLA IAFLIEJMLFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public float PAELBJKLMOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public bool CAPNHDNJPAG;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x4F83300", Offset = "0x4F81F00", VA = "0x184F83300")]
	public OIPMBOINGMD(IEnumerable<TData> DPFJOFOCPMI, IIENBPKDKHB PFOKHHCFPNE, DLFEHIBNHLA LBEFIBKFEIP, float PAELBJKLMOH, bool CAPNHDNJPAG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public struct HEEKGDONENL<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public TData[] CLICJENOKMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public IIENBPKDKHB[] HDIDGNBMAFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public DLFEHIBNHLA[] IAFLIEJMLFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public float[] PAELBJKLMOH;

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x458CD70", Offset = "0x458B970", VA = "0x18458CD70")]
	public HEEKGDONENL(TData[] DPFJOFOCPMI, IIENBPKDKHB[] PFOKHHCFPNE, DLFEHIBNHLA[] LBEFIBKFEIP, float[] PAELBJKLMOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct OHOMONECLIL<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public IEnumerable<TData> CLICJENOKMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public IIENBPKDKHB HDIDGNBMAFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public DLFEHIBNHLA IAFLIEJMLFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public float PAELBJKLMOH;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x4F7CB70", Offset = "0x4F7B770", VA = "0x184F7CB70")]
	public OHOMONECLIL(IEnumerable<TData> DPFJOFOCPMI, IIENBPKDKHB PFOKHHCFPNE, DLFEHIBNHLA LBEFIBKFEIP, float PAELBJKLMOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface HEPIAOPEBCH<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ACLBJEKPPOC([In] FDIAPECLNIG<TData> DIFEMLDAFBP);

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JFJMKFMAEAB([In] FDIAPECLNIG<TData> DIFEMLDAFBP);

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MNAFEKEBNAK([In] bool BOKEBBKNPPD);

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MNFHPGGMDMO([In] FDIAPECLNIG<TData> DIFEMLDAFBP);

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KKFLEJNDOPM();

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool FDKOEAOLKNA([In] TData DIOMOHJEEOK);
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class NBDDDECEMLA<TData> : PFDNGMGPLJJ<HEPIAOPEBCH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly FDIAPECLNIG<TData> DIFEMLDAFBP;

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x4DE8910", Offset = "0x4DE7510", VA = "0x184DE8910")]
	public NBDDDECEMLA(List<TData> BIGGBEIOJHJ, HEPIAOPEBCH<TData> JHNAPAEKPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3FF2DF0", Offset = "0x3FF19F0", VA = "0x183FF2DF0", Slot = "4")]
	public override bool DOIAJGGJPHE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class IAJECCFJCEO<TData> : PFDNGMGPLJJ<HEPIAOPEBCH<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x3FC0A50", Offset = "0x3FBF650", VA = "0x183FC0A50")]
	public IAJECCFJCEO(HEPIAOPEBCH<TData> JHNAPAEKPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x46E4560", Offset = "0x46E3160", VA = "0x1846E4560", Slot = "4")]
	public override bool DOIAJGGJPHE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class PNBMIPIAHKA<TData> : PFDNGMGPLJJ<HEPIAOPEBCH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly bool CAPNHDNJPAG;

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x5076200", Offset = "0x5074E00", VA = "0x185076200")]
	public PNBMIPIAHKA(bool CAPNHDNJPAG, HEPIAOPEBCH<TData> JHNAPAEKPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x50761A0", Offset = "0x5074DA0", VA = "0x1850761A0", Slot = "4")]
	public override bool DOIAJGGJPHE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class HNLBBGOFCBF<TData> : PFDNGMGPLJJ<HEPIAOPEBCH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly FDIAPECLNIG<TData> DIFEMLDAFBP;

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x463CF20", Offset = "0x463BB20", VA = "0x18463CF20")]
	public HNLBBGOFCBF(List<TData> BIGGBEIOJHJ, bool CAPNHDNJPAG, HEPIAOPEBCH<TData> JHNAPAEKPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x4394C00", Offset = "0x4393800", VA = "0x184394C00", Slot = "4")]
	public override bool DOIAJGGJPHE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class FACKKFPIEAF<TData> : PFDNGMGPLJJ<HEPIAOPEBCH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly TData DIOMOHJEEOK;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x43880F0", Offset = "0x4386CF0", VA = "0x1843880F0")]
	public FACKKFPIEAF(TData DIOMOHJEEOK, HEPIAOPEBCH<TData> JHNAPAEKPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x4387F70", Offset = "0x4386B70", VA = "0x184387F70", Slot = "4")]
	public override bool DOIAJGGJPHE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public class IIKACELCFLA<TData> : PFDNGMGPLJJ<HEPIAOPEBCH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly FDIAPECLNIG<TData> DIFEMLDAFBP;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x47060E0", Offset = "0x4704CE0", VA = "0x1847060E0")]
	public IIKACELCFLA(IEnumerable<TData> BIGGBEIOJHJ, HEPIAOPEBCH<TData> JHNAPAEKPAE, bool CAPNHDNJPAG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x4706020", Offset = "0x4704C20", VA = "0x184706020", Slot = "4")]
	public override bool DOIAJGGJPHE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct FDIAPECLNIG<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public IEnumerable<TData> CLICJENOKMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public bool CAPNHDNJPAG;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x438DCE0", Offset = "0x438C8E0", VA = "0x18438DCE0")]
	public FDIAPECLNIG(IEnumerable<TData> KCAIGABNMOG, bool FGBAFBJLLPF = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface ANJLGLIMKMC
{
	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<PIOJPIDCLBF> DOIAJGGJPHE(ILBKJONILOF EOKHMIPHKEN);
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class DNGCCMBNLCP : AHONDFKHOFD<ANJLGLIMKMC, PIOJPIDCLBF>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private struct JKPCGFFPOJH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public AsyncTaskMethodBuilder<PIOJPIDCLBF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public DNGCCMBNLCP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private TaskAwaiter<PIOJPIDCLBF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x74FE390", Offset = "0x74FCF90", VA = "0x1874FE390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x74FE610", Offset = "0x74FD210", VA = "0x1874FE610", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly ILBKJONILOF GLMGAEPOEBN;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x74FD900", Offset = "0x74FC500", VA = "0x1874FD900")]
	public DNGCCMBNLCP(bool CAPNHDNJPAG, ANJLGLIMKMC JHNAPAEKPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x74FD810", Offset = "0x74FC410", VA = "0x1874FD810", Slot = "4")]
	[AsyncStateMachine(typeof(JKPCGFFPOJH))]
	public override Task<PIOJPIDCLBF> DOIAJGGJPHE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public struct ILBKJONILOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public bool PGHKFDFOLLP;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x271C880", Offset = "0x271B480", VA = "0x18271C880")]
	public ILBKJONILOF(bool CAPNHDNJPAG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public readonly struct HBFKGHJGIBI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public readonly bool KFJNFGCBLEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public readonly bool IFDEIONOFGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public readonly bool PCNANBOKIPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public readonly bool CAPNHDNJPAG;

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x566D7C0", Offset = "0x566C3C0", VA = "0x18566D7C0")]
	public HBFKGHJGIBI(bool KFJNFGCBLEF, bool IFDEIONOFGJ, bool PCNANBOKIPD, bool CAPNHDNJPAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x74FE040", Offset = "0x74FCC40", VA = "0x1874FE040")]
	public HBFKGHJGIBI(bool IFDEIONOFGJ, bool CAPNHDNJPAG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public interface LDKGEBFPKKI
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EGLLMFGDNNC(HBFKGHJGIBI EHCPCLLAPNE);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool ONCGLLJNPBD(HBFKGHJGIBI EHCPCLLAPNE);
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class DLJJLJDDBOH : PFDNGMGPLJJ<LDKGEBFPKKI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly HBFKGHJGIBI EHCPCLLAPNE;

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x74FD780", Offset = "0x74FC380", VA = "0x1874FD780")]
	public DLJJLJDDBOH(bool FDCDPIOJPOG, bool IFDEIONOFGJ, bool PCNANBOKIPD, bool CAPNHDNJPAG, LDKGEBFPKKI JHNAPAEKPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x74FD730", Offset = "0x74FC330", VA = "0x1874FD730", Slot = "4")]
	public override bool DOIAJGGJPHE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class EJADHDGDCBK : PFDNGMGPLJJ<LDKGEBFPKKI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly HBFKGHJGIBI EHCPCLLAPNE;

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x74FDB20", Offset = "0x74FC720", VA = "0x1874FDB20")]
	public EJADHDGDCBK(bool IFDEIONOFGJ, bool CAPNHDNJPAG, LDKGEBFPKKI JHNAPAEKPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x74FDAD0", Offset = "0x74FC6D0", VA = "0x1874FDAD0", Slot = "4")]
	public override bool DOIAJGGJPHE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public interface BCLODAPBJBI
{
	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DOIAJGGJPHE([In] GFNHNFEKHLF PGENAEJCAMN);
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class LEFEKLIKMIC : PFDNGMGPLJJ<BCLODAPBJBI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly GFNHNFEKHLF PGENAEJCAMN;

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x74FE8E0", Offset = "0x74FD4E0", VA = "0x1874FE8E0")]
	public LEFEKLIKMIC(Guid[] HOPBABMBNED, Vector3[] ODJIHJOEBAB, Quaternion[] IHKIFPNNJHK, float[] FENKGJFANKC, Dictionary<Guid, Vector3> KMOMIOICJCI, BCLODAPBJBI JHNAPAEKPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x74FE830", Offset = "0x74FD430", VA = "0x1874FE830", Slot = "4")]
	public override bool DOIAJGGJPHE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public interface OGJFCLFFIKO<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KOHHNODLOCO([In] KMKENBFKDLK<TData> GDDFHOFKHIE);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IKLNMOCHLDI([In] AHONGEJJMLD GDBFFDLMOMO);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IKLNMOCHLDI([In] MMAJJPBHDNK GDBFFDLMOMO);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IIJCBFPOBIJ();
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class HJFHOGEOAFN<TData> : PFDNGMGPLJJ<OGJFCLFFIKO<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x3FC0A50", Offset = "0x3FBF650", VA = "0x183FC0A50")]
	public HJFHOGEOAFN(OGJFCLFFIKO<TData> JHNAPAEKPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x462CAD0", Offset = "0x462B6D0", VA = "0x18462CAD0", Slot = "4")]
	public override bool DOIAJGGJPHE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public class DGENHPELKON<TData> : PFDNGMGPLJJ<OGJFCLFFIKO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private readonly AHONGEJJMLD NAIJEEJLMII;

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x63055C0", Offset = "0x63041C0", VA = "0x1863055C0")]
	public DGENHPELKON(Vector3 FDBNEJFKPGF, bool HKPDGNFCNPL, OGJFCLFFIKO<TData> JHNAPAEKPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x4004E60", Offset = "0x4003A60", VA = "0x184004E60", Slot = "4")]
	public override bool DOIAJGGJPHE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class IIACGMEDPDH<TData> : PFDNGMGPLJJ<OGJFCLFFIKO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly MMAJJPBHDNK NAIJEEJLMII;

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x46FE5E0", Offset = "0x46FD1E0", VA = "0x1846FE5E0")]
	public IIACGMEDPDH(Guid NKBEFGKFLKC, int BIEEMEKMINN, Vector3 FCININPMBGJ, Quaternion APLHHNGOEFP, float GHONGHPPDGL, bool HKPDGNFCNPL, OGJFCLFFIKO<TData> JHNAPAEKPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x46FE580", Offset = "0x46FD180", VA = "0x1846FE580", Slot = "4")]
	public override bool DOIAJGGJPHE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public class EMNBJAGELPI<TData> : PFDNGMGPLJJ<OGJFCLFFIKO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly KMKENBFKDLK<TData> NAIJEEJLMII;

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x3FF2F60", Offset = "0x3FF1B60", VA = "0x183FF2F60")]
	public EMNBJAGELPI(TData EJGAMJDEIEL, bool CAPNHDNJPAG, OGJFCLFFIKO<TData> JHNAPAEKPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x3FF2DF0", Offset = "0x3FF19F0", VA = "0x183FF2DF0", Slot = "4")]
	public override bool DOIAJGGJPHE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public struct AHONGEJJMLD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public readonly Vector3 FDBNEJFKPGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public readonly bool HKPDGNFCNPL;

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x74FD410", Offset = "0x74FC010", VA = "0x1874FD410")]
	public AHONGEJJMLD(Vector3 FDBNEJFKPGF, bool HKPDGNFCNPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public struct MMAJJPBHDNK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public readonly Guid NKBEFGKFLKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public readonly int BIEEMEKMINN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public readonly Vector3 FCININPMBGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public readonly Quaternion APLHHNGOEFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public readonly float GHONGHPPDGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public readonly bool HKPDGNFCNPL;

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x74FEF80", Offset = "0x74FDB80", VA = "0x1874FEF80")]
	public MMAJJPBHDNK(Guid NKBEFGKFLKC, int BIEEMEKMINN, Vector3 FCININPMBGJ, Quaternion APLHHNGOEFP, float GHONGHPPDGL, bool HKPDGNFCNPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public struct KMKENBFKDLK<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public readonly TData EJGAMJDEIEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public readonly bool CAPNHDNJPAG;

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x4A7B150", Offset = "0x4A79D50", VA = "0x184A7B150")]
	public KMKENBFKDLK(TData EJGAMJDEIEL, bool CAPNHDNJPAG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public interface AKBDMAMGNDA<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DOIAJGGJPHE([In] ABMOJFLNDFE<TData> OCKKOOKNFLG);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DOIAJGGJPHE([In] DCGLPJCOFGN<TData> OCKKOOKNFLG);
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public interface CHLMLAOPOJB<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KOHHNODLOCO([In] BLMJHMPBIDB<TData> IDMMAPGPOIN);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IKLNMOCHLDI([In] NODLEGMGHIE GDBFFDLMOMO);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IIJCBFPOBIJ();
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class MJHMEBHBFNO<TData> : PFDNGMGPLJJ<AKBDMAMGNDA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private readonly ABMOJFLNDFE<TData> OCKKOOKNFLG;

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x4D77920", Offset = "0x4D76520", VA = "0x184D77920")]
	public MJHMEBHBFNO(IEnumerable<TData> DPFJOFOCPMI, Vector3 OPDKHONBCPH, bool CAPNHDNJPAG, AKBDMAMGNDA<TData> JHNAPAEKPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x3FF2DF0", Offset = "0x3FF19F0", VA = "0x183FF2DF0", Slot = "4")]
	public override bool DOIAJGGJPHE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public class NIOPACGFCJC<TData> : PFDNGMGPLJJ<CHLMLAOPOJB<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x3FC0A50", Offset = "0x3FBF650", VA = "0x183FC0A50")]
	public NIOPACGFCJC(CHLMLAOPOJB<TData> JHNAPAEKPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x454A6D0", Offset = "0x45492D0", VA = "0x18454A6D0", Slot = "4")]
	public override bool DOIAJGGJPHE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class KFMBDJNMLMJ<TData> : PFDNGMGPLJJ<CHLMLAOPOJB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private readonly BLMJHMPBIDB<TData> OCKKOOKNFLG;

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x4A4C9E0", Offset = "0x4A4B5E0", VA = "0x184A4C9E0")]
	public KFMBDJNMLMJ(IEnumerable<TData> DPFJOFOCPMI, bool CAPNHDNJPAG, CHLMLAOPOJB<TData> JHNAPAEKPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x3FF2DF0", Offset = "0x3FF19F0", VA = "0x183FF2DF0", Slot = "4")]
	public override bool DOIAJGGJPHE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class JABFBEPJLEH<TData> : PFDNGMGPLJJ<AKBDMAMGNDA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly DCGLPJCOFGN<TData> OCKKOOKNFLG;

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x48D4A90", Offset = "0x48D3690", VA = "0x1848D4A90")]
	public JABFBEPJLEH(IEnumerable<TData> DPFJOFOCPMI, Vector3 OIHJMDPBPDG, HMBMOIJACOC KAPBHKJEILC, bool CAPNHDNJPAG, AKBDMAMGNDA<TData> JHNAPAEKPAE, Space EMPOKENPKIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x48D49D0", Offset = "0x48D35D0", VA = "0x1848D49D0", Slot = "4")]
	public override bool DOIAJGGJPHE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class GLJDGFFPAAA<TData> : PFDNGMGPLJJ<CHLMLAOPOJB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly NODLEGMGHIE OCKKOOKNFLG;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x44E0060", Offset = "0x44DEC60", VA = "0x1844E0060")]
	public GLJDGFFPAAA(Vector3 OPDKHONBCPH, CHLMLAOPOJB<TData> JHNAPAEKPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x4004E60", Offset = "0x4003A60", VA = "0x184004E60", Slot = "4")]
	public override bool DOIAJGGJPHE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public struct ABMOJFLNDFE<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public readonly IEnumerable<TData> DPFJOFOCPMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public readonly Vector3 OPDKHONBCPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public readonly bool CAPNHDNJPAG;

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x4541880", Offset = "0x4540480", VA = "0x184541880")]
	public ABMOJFLNDFE(IEnumerable<TData> DPFJOFOCPMI, Vector3 OPDKHONBCPH, bool CAPNHDNJPAG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public struct BLMJHMPBIDB<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public readonly IEnumerable<TData> DPFJOFOCPMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public readonly bool CAPNHDNJPAG;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5811740", Offset = "0x5810340", VA = "0x185811740")]
	public BLMJHMPBIDB(IEnumerable<TData> DPFJOFOCPMI, bool CAPNHDNJPAG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public struct DCGLPJCOFGN<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public readonly IEnumerable<TData> DPFJOFOCPMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public readonly Vector3 OIHJMDPBPDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public readonly HMBMOIJACOC KAPBHKJEILC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public readonly bool CAPNHDNJPAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public readonly Space EMPOKENPKIP;

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x62F6BB0", Offset = "0x62F57B0", VA = "0x1862F6BB0")]
	public DCGLPJCOFGN(IEnumerable<TData> DPFJOFOCPMI, Vector3 OIHJMDPBPDG, HMBMOIJACOC KAPBHKJEILC, bool CAPNHDNJPAG, Space EMPOKENPKIP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public struct NODLEGMGHIE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public readonly Vector3 OPDKHONBCPH;

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x271DD40", Offset = "0x271C940", VA = "0x18271DD40")]
	public NODLEGMGHIE(Vector3 OPDKHONBCPH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public enum HMBMOIJACOC
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
public interface IEJANEKBPCP
{
	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DOIAJGGJPHE([In] GLBBPBOEJNF DJNEIONDAFO);
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class HIPCDLKMHBN : PFDNGMGPLJJ<IEJANEKBPCP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly GLBBPBOEJNF DJNEIONDAFO;

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x74FE100", Offset = "0x74FCD00", VA = "0x1874FE100")]
	public HIPCDLKMHBN(bool CAPNHDNJPAG, IEJANEKBPCP JHNAPAEKPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x74FE050", Offset = "0x74FCC50", VA = "0x1874FE050", Slot = "4")]
	public override bool DOIAJGGJPHE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public readonly struct GLBBPBOEJNF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly bool CAPNHDNJPAG;

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x271C880", Offset = "0x271B480", VA = "0x18271C880")]
	public GLBBPBOEJNF(bool CAPNHDNJPAG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public interface MOKIINLBEHA<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DOIAJGGJPHE([In] LDHMNAOFBLG<TData> HIJFHPGLJNM);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DOIAJGGJPHE([In] NMCBNLHDKNI<TData> HIJFHPGLJNM);
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public interface FMDACEHGDLO<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KOHHNODLOCO([In] KNOOPMJMIDG<TData> GDDFHOFKHIE);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IKLNMOCHLDI([In] LPLCMAPDCLA GDBFFDLMOMO);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IIJCBFPOBIJ();
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class PIBLJDLLLBJ<TData> : PFDNGMGPLJJ<MOKIINLBEHA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly LDHMNAOFBLG<TData> HIJFHPGLJNM;

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x5047440", Offset = "0x5046040", VA = "0x185047440")]
	public PIBLJDLLLBJ(IEnumerable<TData> DPFJOFOCPMI, Quaternion OPDKHONBCPH, Vector3? HMOFKGMLGMD, bool IPKAJACGEKJ, bool CAPNHDNJPAG, MOKIINLBEHA<TData> JHNAPAEKPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x3FF2DF0", Offset = "0x3FF19F0", VA = "0x183FF2DF0", Slot = "4")]
	public override bool DOIAJGGJPHE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public class ADNHIEPHLOE<TData> : PFDNGMGPLJJ<FMDACEHGDLO<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x3FC0A50", Offset = "0x3FBF650", VA = "0x183FC0A50")]
	public ADNHIEPHLOE(FMDACEHGDLO<TData> JHNAPAEKPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x454A6D0", Offset = "0x45492D0", VA = "0x18454A6D0", Slot = "4")]
	public override bool DOIAJGGJPHE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public class KNNHOFPNBKL<TData> : PFDNGMGPLJJ<FMDACEHGDLO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly KNOOPMJMIDG<TData> HIJFHPGLJNM;

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x4A825F0", Offset = "0x4A811F0", VA = "0x184A825F0")]
	public KNNHOFPNBKL(IEnumerable<TData> DPFJOFOCPMI, bool CAPNHDNJPAG, FMDACEHGDLO<TData> JHNAPAEKPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x3FF2DF0", Offset = "0x3FF19F0", VA = "0x183FF2DF0", Slot = "4")]
	public override bool DOIAJGGJPHE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public class LAHCKENKIFB<TData> : PFDNGMGPLJJ<MOKIINLBEHA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly NMCBNLHDKNI<TData> HIJFHPGLJNM;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x4B10830", Offset = "0x4B0F430", VA = "0x184B10830")]
	public LAHCKENKIFB(IEnumerable<TData> DPFJOFOCPMI, Quaternion CDOEMNLBFNP, HMBMOIJACOC LGJJFDDDLDF, Vector3? HMOFKGMLGMD, bool IPKAJACGEKJ, bool CAPNHDNJPAG, Space EMPOKENPKIP, MOKIINLBEHA<TData> JHNAPAEKPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x48D49D0", Offset = "0x48D35D0", VA = "0x1848D49D0", Slot = "4")]
	public override bool DOIAJGGJPHE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public class KBIKJJKIKIG<TData> : PFDNGMGPLJJ<FMDACEHGDLO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly LPLCMAPDCLA HIJFHPGLJNM;

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x4A06540", Offset = "0x4A05140", VA = "0x184A06540")]
	public KBIKJJKIKIG(Quaternion OPDKHONBCPH, Vector3? HMOFKGMLGMD, bool IPKAJACGEKJ, FMDACEHGDLO<TData> JHNAPAEKPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x4004E60", Offset = "0x4003A60", VA = "0x184004E60", Slot = "4")]
	public override bool DOIAJGGJPHE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public struct LDHMNAOFBLG<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public readonly IEnumerable<TData> DPFJOFOCPMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public readonly Quaternion OPDKHONBCPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public readonly Vector3? HMOFKGMLGMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public readonly bool IPKAJACGEKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public readonly bool CAPNHDNJPAG;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x4B20D00", Offset = "0x4B1F900", VA = "0x184B20D00")]
	public LDHMNAOFBLG(IEnumerable<TData> DPFJOFOCPMI, Quaternion OPDKHONBCPH, Vector3? HMOFKGMLGMD, bool IPKAJACGEKJ, bool CAPNHDNJPAG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public struct KNOOPMJMIDG<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public readonly IEnumerable<TData> DPFJOFOCPMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public readonly bool CAPNHDNJPAG;

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x4A82B90", Offset = "0x4A81790", VA = "0x184A82B90")]
	public KNOOPMJMIDG(IEnumerable<TData> DPFJOFOCPMI, bool CAPNHDNJPAG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public struct NMCBNLHDKNI<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public readonly IEnumerable<TData> DPFJOFOCPMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public readonly Quaternion CDOEMNLBFNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public readonly HMBMOIJACOC LGJJFDDDLDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public readonly Vector3? HMOFKGMLGMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public readonly bool IPKAJACGEKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public readonly bool CAPNHDNJPAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public readonly Space EMPOKENPKIP;

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x4E5EB00", Offset = "0x4E5D700", VA = "0x184E5EB00")]
	public NMCBNLHDKNI(IEnumerable<TData> DPFJOFOCPMI, Quaternion CDOEMNLBFNP, HMBMOIJACOC LGJJFDDDLDF, Vector3? HMOFKGMLGMD, bool IPKAJACGEKJ, bool CAPNHDNJPAG, Space EMPOKENPKIP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public struct LPLCMAPDCLA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public readonly Quaternion OPDKHONBCPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public readonly Vector3? HMOFKGMLGMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public readonly bool IPKAJACGEKJ;

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x5619930", Offset = "0x5618530", VA = "0x185619930")]
	public LPLCMAPDCLA(Quaternion OPDKHONBCPH, Vector3? HMOFKGMLGMD, bool IPKAJACGEKJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public interface KHJFAIABNPA<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KOHHNODLOCO([In] MLEAGMHMDJC<TData> GDDFHOFKHIE);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IKLNMOCHLDI([In] HAAAAGCGDEL GDBFFDLMOMO);

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IKLNMOCHLDI([In] OLBBILMHDPM GDBFFDLMOMO);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IKLNMOCHLDI([In] JLICJGDKAEK GDBFFDLMOMO);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IIJCBFPOBIJ();
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class LCIJCMCPNOA<TData> : PFDNGMGPLJJ<KHJFAIABNPA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private readonly JLICJGDKAEK NDJGPJEBOHB;

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x4B203C0", Offset = "0x4B1EFC0", VA = "0x184B203C0")]
	public LCIJCMCPNOA(Vector3 IJKEMGFMCHL, float BPPKCFHOFCL, Vector3 HMOFKGMLGMD, bool KJMPAJJEEKB, bool EGGNBMJGEFI, KHJFAIABNPA<TData> JHNAPAEKPAE, Space EMPOKENPKIP = Space.Self)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x4B20360", Offset = "0x4B1EF60", VA = "0x184B20360", Slot = "4")]
	public override bool DOIAJGGJPHE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public class KHKAFPOKBDO<TData> : PFDNGMGPLJJ<KHJFAIABNPA<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x3FC0A50", Offset = "0x3FBF650", VA = "0x183FC0A50")]
	public KHKAFPOKBDO(KHJFAIABNPA<TData> JHNAPAEKPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x4A6C7D0", Offset = "0x4A6B3D0", VA = "0x184A6C7D0", Slot = "4")]
	public override bool DOIAJGGJPHE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public class HFCIDIGICEK<TData> : PFDNGMGPLJJ<KHJFAIABNPA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private readonly MLEAGMHMDJC<TData> NDJGPJEBOHB;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x458FE30", Offset = "0x458EA30", VA = "0x18458FE30")]
	public HFCIDIGICEK(IEnumerable<TData> DPFJOFOCPMI, bool CAPNHDNJPAG, KHJFAIABNPA<TData> JHNAPAEKPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x3FF2DF0", Offset = "0x3FF19F0", VA = "0x183FF2DF0", Slot = "4")]
	public override bool DOIAJGGJPHE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public class KKKLNCMMCAJ<TData> : PFDNGMGPLJJ<KHJFAIABNPA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private readonly OLBBILMHDPM NDJGPJEBOHB;

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x4A71A20", Offset = "0x4A70620", VA = "0x184A71A20")]
	public KKKLNCMMCAJ(float EFHIFNKOFFF, bool KINHNDBBOAK, Vector3 HMOFKGMLGMD, KHJFAIABNPA<TData> JHNAPAEKPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x4A71960", Offset = "0x4A70560", VA = "0x184A71960", Slot = "4")]
	public override bool DOIAJGGJPHE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public class ENPOHELGAMH<TData> : PFDNGMGPLJJ<KHJFAIABNPA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private readonly HAAAAGCGDEL NDJGPJEBOHB;

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x4004EC0", Offset = "0x4003AC0", VA = "0x184004EC0")]
	public ENPOHELGAMH(float BPPKCFHOFCL, Vector3 HMOFKGMLGMD, KHJFAIABNPA<TData> JHNAPAEKPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x4004E60", Offset = "0x4003A60", VA = "0x184004E60", Slot = "4")]
	public override bool DOIAJGGJPHE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct JLICJGDKAEK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public readonly Vector3 IJKEMGFMCHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public readonly float BPPKCFHOFCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public readonly Vector3 HMOFKGMLGMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public readonly bool HKPDGNFCNPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public readonly Space EMPOKENPKIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public readonly bool EGGNBMJGEFI;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x74FE680", Offset = "0x74FD280", VA = "0x1874FE680")]
	public JLICJGDKAEK(Vector3 IJKEMGFMCHL, float BPPKCFHOFCL, Vector3 HMOFKGMLGMD, bool HKPDGNFCNPL, bool JKHAAOEGHMC, Space EMPOKENPKIP = Space.Self)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public struct MLEAGMHMDJC<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public readonly IEnumerable<TData> DPFJOFOCPMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public readonly bool CAPNHDNJPAG;

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x4D85B20", Offset = "0x4D84720", VA = "0x184D85B20")]
	public MLEAGMHMDJC(IEnumerable<TData> DPFJOFOCPMI, bool CAPNHDNJPAG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public struct OLBBILMHDPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly float EFHIFNKOFFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public readonly bool KINHNDBBOAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly Vector3 HMOFKGMLGMD;

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x74FF040", Offset = "0x74FDC40", VA = "0x1874FF040")]
	public OLBBILMHDPM(float EFHIFNKOFFF, bool KINHNDBBOAK, Vector3 HMOFKGMLGMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public struct HAAAAGCGDEL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public readonly float BPPKCFHOFCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public readonly Vector3 HMOFKGMLGMD;

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x55DB280", Offset = "0x55D9E80", VA = "0x1855DB280")]
	public HAAAAGCGDEL(float BPPKCFHOFCL, Vector3 HMOFKGMLGMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public struct GFNHNFEKHLF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public readonly Guid[] DPFJOFOCPMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public readonly bool CGEKKDDDFHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public readonly bool CCPGHCNKBAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public readonly bool NLHHIFAAPPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public readonly Vector3[] ODJIHJOEBAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public readonly Quaternion[] IHKIFPNNJHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public readonly float[] FENKGJFANKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public readonly Dictionary<Guid, Vector3> KMOMIOICJCI;

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x74FDDB0", Offset = "0x74FC9B0", VA = "0x1874FDDB0")]
	public GFNHNFEKHLF(Guid[] HOPBABMBNED, Vector3[] ODJIHJOEBAB, Quaternion[] IHKIFPNNJHK, float[] FENKGJFANKC, Dictionary<Guid, Vector3> KMOMIOICJCI, bool CGEKKDDDFHE = true, bool CCPGHCNKBAN = true, bool NLHHIFAAPPP = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x74FDBE0", Offset = "0x74FC7E0", VA = "0x1874FDBE0")]
	private static void PIIFDOLLHCP(Dictionary<Guid, Vector3> KMOMIOICJCI, int HGGNEFAKBII)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public static class ADFKKFJPKGB
{
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	private struct LADIFFEMCPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public bool PJFEKAOLPBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public KPLLBHIBBNH DNOIHHONCFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public KPLLBHIBBNH CKCPNMKCPNB;
	}

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static LADIFFEMCPB INDJJGABMPH;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static CancellationToken MOKNDENEOMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x74FD390", Offset = "0x74FBF90", VA = "0x1874FD390")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	internal static KPLLBHIBBNH DNOIHHONCFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x74FD150", Offset = "0x74FBD50", VA = "0x1874FD150")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x74FD3B0", Offset = "0x74FBFB0", VA = "0x1874FD3B0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x74FD060", Offset = "0x74FBC60", VA = "0x1874FD060")]
	[DMDJPIBKEJJ.BGJJNCECJDH]
	internal static void AEFNPIEJNPP(KPLLBHIBBNH HKECEIPEFME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x74FD240", Offset = "0x74FBE40", VA = "0x1874FD240")]
	public static void EDPJFJHBEFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x74FD1F0", Offset = "0x74FBDF0", VA = "0x1874FD1F0")]
	private static KPLLBHIBBNH BIHHMOLNNMO(KPLLBHIBBNH LNIINKOLAGG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public static class DKOLCOJHFCP
{
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public enum BGPCJMOHHJO
	{
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		ICreationContextObject,
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		Guid
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x31A9440", Offset = "0x31A8040", VA = "0x1831A9440")]
	public static void ICKBGBNAAEO<T>(T ONEEJFNLBJF, BGPCJMOHHJO ADFFEBFOCBD) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x31A95A0", Offset = "0x31A81A0", VA = "0x1831A95A0")]
	public static void ICKBGBNAAEO<T>(T ONEEJFNLBJF) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x31A9390", Offset = "0x31A7F90", VA = "0x1831A9390")]
	public static void DLINADOALNK<T>(T ONEEJFNLBJF) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x31A9780", Offset = "0x31A8380", VA = "0x1831A9780")]
	public static T IMOGIGFHIEP<T>(BGPCJMOHHJO ADFFEBFOCBD) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x31A98F0", Offset = "0x31A84F0", VA = "0x1831A98F0")]
	public static bool KDJMJGJDKMN<T>(BGPCJMOHHJO ADFFEBFOCBD, T? GNIMLCICABF, [Out][MaybeNullWhen(false)][NotNullWhen(true)] T DGIMJINELLK) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x31A9610", Offset = "0x31A8210", VA = "0x1831A9610")]
	public static bool IHLJECCLPBI<T>(BGPCJMOHHJO ADFFEBFOCBD, [Out][MaybeNullWhen(false)][NotNullWhen(true)] T PAPEBHHLGPL) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x31A9A40", Offset = "0x31A8640", VA = "0x1831A9A40")]
	public static bool PAAAKJJGLBE<T>(BGPCJMOHHJO ADFFEBFOCBD) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x31A9720", Offset = "0x31A8320", VA = "0x1831A9720")]
	public static T IMOGIGFHIEP<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x31A9830", Offset = "0x31A8430", VA = "0x1831A9830")]
	public static bool KDJMJGJDKMN<T>(T GNIMLCICABF, [Out] T DGIMJINELLK) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x31A9720", Offset = "0x31A8320", VA = "0x1831A9720")]
	public static bool PAAAKJJGLBE<T>() where T : class
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
internal static class JDCFBJLIBHF
{
	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x74FE160", Offset = "0x74FCD60", VA = "0x1874FE160")]
	public static void CIKLJKHJCEH(IEnumerable CLHJANNABBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x33F66A0", Offset = "0x33F52A0", VA = "0x1833F66A0")]
	public static void CIKLJKHJCEH<T>(T[] CPOMPIIIEGC) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x33F6880", Offset = "0x33F5480", VA = "0x1833F6880")]
	public static void CIKLJKHJCEH<T>(T HLFIFJFGNJJ) where T : notnull, Enum
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
