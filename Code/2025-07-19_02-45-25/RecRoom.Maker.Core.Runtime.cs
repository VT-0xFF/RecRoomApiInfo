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
		[Cpp2IlInjected.Address(RVA = "0xA8A800", Offset = "0xA89800", VA = "0x180A8A800")]
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
		[Cpp2IlInjected.Address(RVA = "0x81CF430", Offset = "0x81CE430", VA = "0x1881CF430")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA8B7C0", Offset = "0xA8A7C0", VA = "0x180A8B7C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA8B800", Offset = "0xA8A800", VA = "0x180A8B800")]
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
		[Cpp2IlInjected.Address(RVA = "0x81CF7E0", Offset = "0x81CE7E0", VA = "0x1881CF7E0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x28D9760", Offset = "0x28D8760", VA = "0x1828D9760")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum OEKJKDLBDAA
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	ShowFreeInventionsInR2PaletteSearch
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum KNBDLEGMDAP
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	NameAZ,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	NameZA,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	InkCostAsc,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	InkCostDesc,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	Oldest,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	Newest
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface FNIOLGCIBCC<TData, TReturn>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TReturn LDPEJKGIHBC(TData PGIOEBKALDP);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface AEIMMKMJFIA<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ClearHoverTarget(FGNANMBDCMP DMGNFNHDFGA);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool SetHoverTarget(TData AOJAHPGAGPO, Collider CPAJNCPNAED, FGNANMBDCMP DMGNFNHDFGA, [Optional] CIMLIBKMPND? DLMKAJMGHDA);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool TryGetHoverTarget([Out] TData AOJAHPGAGPO);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetHoverCollider([Out] Collider CPAJNCPNAED);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface KGCFGILBPAK<TData> : HNOLEBEPGOC, BDAHDKOFLKJ<TData>, ELEHGDKEBJM<TData>, AFELMFOKHHJ<TData>, HANPGAGAHBM, GBEDCPJAIBI<TData>, JHJAIKLICDK, EMLKINGDLCL
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface GBEDCPJAIBI<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 NAOOBLMKEHE, Vector3 NBFEGPDMMPI, float OAGBEPAKAEK, [Out] T BOBDLIJPMEP, [Out] Vector3 EJIMJILGCHC, [Out] Collider CPAJNCPNAED);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 NAOOBLMKEHE, Vector3 NBFEGPDMMPI, float MGKJAAGOBCA, float OAGBEPAKAEK, T[] KEHOCOIGIGI, [Out] Vector3 LMFHEOKIHIH, [Out] Collider EHOKLKNMGKD);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 NAOOBLMKEHE, float MGKJAAGOBCA, Vector3 FHHIKKDECAN, T[] KEHOCOIGIGI);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetObjectFromColliderInCurrentScope(Collider EPMKKDPDDLB, [Out] T AKMLKJOFNCF);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface HNOLEBEPGOC
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Bounds MHIJNJDDCEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Transform DDIFMMCJOJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Bounds CFLAIBAMJPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Transform GAIGGIGDNMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Vector3 KCPGOPHDION
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool CCOEODOFLNM
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
	void SetSelectionBoundsDirty(bool LMKOMPDKDBA = true, int LMODHPMHPMB = 0);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ShouldHideSelectionBoundsPreview(bool FDJOPAMPPOD, object GFDDDAIMFOH);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface EMLKINGDLCL
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	LELKCPPPMEI JMHBPBALFGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface OIPOEJBLMFE
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool NFNNINHMLFI
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool EPEMCIAKAHE
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool AGCLMKINGHD
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
	void TrySetPreviousCloneMapping(Dictionary<Guid, Guid> KOJNBBIEPKN);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface AFELMFOKHHJ<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool BDCJPFHEJHC
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int LGBCMMIIACP
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<TData> IDKOJJKBNIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData ADPMEPGEIDH);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData ADPMEPGEIDH);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface BDAHDKOFLKJ<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T PGIOEBKALDP, [Optional] CIMLIBKMPND? PJBEBIJGJFC, bool HDNKMBBEBEJ = true);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int MFFPIAPMHCN, IEnumerable<T> FDPOMIPCBPJ, bool HDNKMBBEBEJ = true);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int MFFPIAPMHCN, IEnumerable<T> FDPOMIPCBPJ, CIMLIBKMPND PJBEBIJGJFC, bool HDNKMBBEBEJ = true);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface JHJAIKLICDK
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface HANPGAGAHBM
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool HDGCMMAMBPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool MHFIIEINLFI
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool MAFGDAGHKPE
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool PHOPNENGFPA
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct HCCLBNNNCBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public bool CMMMKADOMDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public float? DGJJPCKLNHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public float? EKIOPEJEOEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public float? OANDCGEOAMP;
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct OABBHAIPBCG<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public IEnumerable<TData> FKMKCBFHJDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public HCCLBNNNCBF GGOFBLLIDNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public bool NJCEAHNEDJG;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x58938F0", Offset = "0x58928F0", VA = "0x1858938F0")]
	public OABBHAIPBCG(IEnumerable<TData> FCIMPODEJPB, bool DNLKEFBJEOL, float? KLMOGMOAEPA, float? GHPPGCHDHHL, float? OCGBLFPICDH, bool NJCEAHNEDJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface JGPDIBLPCBP<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JOCGPOALKCE([In] OABBHAIPBCG<TData> DELLHDJPKBE);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class IEMPOCGKFGE<TData> : EHECGHCLKHG<JGPDIBLPCBP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly OABBHAIPBCG<TData> DELLHDJPKBE;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5013B40", Offset = "0x5012B40", VA = "0x185013B40")]
	public IEMPOCGKFGE(IEnumerable<TData> FCIMPODEJPB, bool DNLKEFBJEOL, float? KLMOGMOAEPA, float? GHPPGCHDHHL, float? OCGBLFPICDH, bool NJCEAHNEDJG, JGPDIBLPCBP<TData> GEBKONJKJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4908AE0", Offset = "0x4907AE0", VA = "0x184908AE0", Slot = "4")]
	public override bool JOCGPOALKCE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct JGMBMFLJAAH<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public IEnumerable<TData> FKMKCBFHJDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public string CHIILACPAMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public bool MJBPLNOGCBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public bool NJCEAHNEDJG;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x52A7F90", Offset = "0x52A6F90", VA = "0x1852A7F90")]
	public JGMBMFLJAAH(IEnumerable<TData> FCIMPODEJPB, string IMHEEBEEIJH, bool DHDIIAFJMKD, bool NJCEAHNEDJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface AGANOFIOBHM<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JOCGPOALKCE([In] JGMBMFLJAAH<TData> DELLHDJPKBE);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class BHPFCAKHKAP<TData> : EHECGHCLKHG<AGANOFIOBHM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly JGMBMFLJAAH<TData> DELLHDJPKBE;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x643C330", Offset = "0x643B330", VA = "0x18643C330")]
	public BHPFCAKHKAP(IEnumerable<TData> FCIMPODEJPB, string IMHEEBEEIJH, bool DHDIIAFJMKD, bool NJCEAHNEDJG, AGANOFIOBHM<TData> GEBKONJKJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x4908AE0", Offset = "0x4907AE0", VA = "0x184908AE0", Slot = "4")]
	public override bool JOCGPOALKCE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public abstract class EHECGHCLKHG<TReceiver> : HKDEAAMDCDI<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4901E10", Offset = "0x4900E10", VA = "0x184901E10")]
	public EHECGHCLKHG(TReceiver GEBKONJKJPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class JLOAHGICFCG<TReceiver, TFromTask> : HKDEAAMDCDI<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4901E10", Offset = "0x4900E10", VA = "0x184901E10")]
	public JLOAHGICFCG(TReceiver GEBKONJKJPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class HKDEAAMDCDI<TReceiver, TFromExecute> where TReceiver : notnull where TFromExecute : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	protected TReceiver GEBKONJKJPJ;

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4F4B390", Offset = "0x4F4A390", VA = "0x184F4B390")]
	public HKDEAAMDCDI(TReceiver GEBKONJKJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute JOCGPOALKCE();
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public abstract class DLAAMFHGGLF<TReceiver, TResult> : HKDEAAMDCDI<TReceiver, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4901E10", Offset = "0x4900E10", VA = "0x184901E10")]
	public DLAAMFHGGLF(TReceiver GEBKONJKJPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct DCFHCCKHANI<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public TGroup NDGJMEEAIPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public TData MMCKLJGBJAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public IEnumerable<TData> FKMKCBFHJDG;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1D9D9A0", Offset = "0x1D9C9A0", VA = "0x181D9D9A0")]
	public DCFHCCKHANI(TGroup NIJIOMOEPJH, TData OBCDKOLHBJM, IEnumerable<TData> FCIMPODEJPB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct LLLBNLBFBJH<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public TGroup NDGJMEEAIPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public IEnumerable<TData> FKMKCBFHJDG;

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0xBDB810", Offset = "0xBDA810", VA = "0x180BDB810")]
	public LLLBNLBFBJH(TGroup NIJIOMOEPJH, IEnumerable<TData> FCIMPODEJPB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct CEBEANJDGMD<TGroup> where TGroup : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public TGroup NDGJMEEAIPK;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0xE50960", Offset = "0xE4F960", VA = "0x180E50960")]
	public CEBEANJDGMD(TGroup NIJIOMOEPJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public struct BPFJKOIAKNJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public IEnumerable<Guid> FKMKCBFHJDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public Guid HCGFCMBJMNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly bool AJOLOGKMKGO;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x81CD7B0", Offset = "0x81CC7B0", VA = "0x1881CD7B0")]
	public BPFJKOIAKNJ(IEnumerable<Guid> FCIMPODEJPB, Guid LOPJIOBNBPD, bool NJCEAHNEDJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct DFBCEHGKKLO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public Guid HCGFCMBJMNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly bool AJOLOGKMKGO;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2899510", Offset = "0x2898510", VA = "0x182899510")]
	public DFBCEHGKKLO(Guid LOPJIOBNBPD, bool NJCEAHNEDJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface LHKMHBKOPNJ<TGroup, TData>
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BFHGLCFOFPD MMPHNNPPIPO(DCFHCCKHANI<TGroup, TData> ADGBMGAGACA);

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "1")]
	BFHGLCFOFPD LENLPADDFLF(DCFHCCKHANI<TGroup, TData> ADGBMGAGACA);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "2")]
	BFHGLCFOFPD JNIBLJANGLJ(LLLBNLBFBJH<TGroup, TData> ADGBMGAGACA);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "3")]
	BFHGLCFOFPD IMIMBNLAOPO(CEBEANJDGMD<TGroup> ADGBMGAGACA);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface LMCBAKPEOME
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<BFHGLCFOFPD> MMPHNNPPIPO(BPFJKOIAKNJ ADGBMGAGACA);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<BFHGLCFOFPD> LENLPADDFLF(DFBCEHGKKLO ADGBMGAGACA);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class NMPOGKEMACB<TGroup, TData> : DLAAMFHGGLF<LHKMHBKOPNJ<TGroup, TData>, BFHGLCFOFPD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly LLLBNLBFBJH<TGroup, TData> ADGBMGAGACA;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x579B650", Offset = "0x579A650", VA = "0x18579B650")]
	public NMPOGKEMACB(TGroup NIJIOMOEPJH, IEnumerable<TData> FCIMPODEJPB, LHKMHBKOPNJ<TGroup, TData> GEBKONJKJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x579B580", Offset = "0x579A580", VA = "0x18579B580", Slot = "4")]
	public override BFHGLCFOFPD JOCGPOALKCE()
	{
		return default(BFHGLCFOFPD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class NLJFLMJIGLF<TGroup, TData> : DLAAMFHGGLF<LHKMHBKOPNJ<TGroup, TData>, BFHGLCFOFPD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly DCFHCCKHANI<TGroup, TData> ADGBMGAGACA;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x4900590", Offset = "0x48FF590", VA = "0x184900590")]
	public NLJFLMJIGLF(TGroup NIJIOMOEPJH, TData BIMJOKLPPIP, IEnumerable<TData> FCIMPODEJPB, LHKMHBKOPNJ<TGroup, TData> GEBKONJKJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x57984F0", Offset = "0x57974F0", VA = "0x1857984F0", Slot = "4")]
	public override BFHGLCFOFPD JOCGPOALKCE()
	{
		return default(BFHGLCFOFPD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class DGCKEMBAKOH<TGroup, TData> : DLAAMFHGGLF<LHKMHBKOPNJ<TGroup, TData>, BFHGLCFOFPD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly CEBEANJDGMD<TGroup> ADGBMGAGACA;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x4D7EBA0", Offset = "0x4D7DBA0", VA = "0x184D7EBA0")]
	public DGCKEMBAKOH(TGroup NIJIOMOEPJH, LHKMHBKOPNJ<TGroup, TData> GEBKONJKJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6E8F5C0", Offset = "0x6E8E5C0", VA = "0x186E8F5C0", Slot = "4")]
	public override BFHGLCFOFPD JOCGPOALKCE()
	{
		return default(BFHGLCFOFPD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class EGFPNPBKLKP<TGroup, TData> : DLAAMFHGGLF<LHKMHBKOPNJ<TGroup, TData>, BFHGLCFOFPD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly DCFHCCKHANI<TGroup, TData> ADGBMGAGACA;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4900590", Offset = "0x48FF590", VA = "0x184900590")]
	public EGFPNPBKLKP(TGroup NIJIOMOEPJH, TData OBCDKOLHBJM, IEnumerable<TData> FCIMPODEJPB, LHKMHBKOPNJ<TGroup, TData> GEBKONJKJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x49004B0", Offset = "0x48FF4B0", VA = "0x1849004B0", Slot = "4")]
	public override BFHGLCFOFPD JOCGPOALKCE()
	{
		return default(BFHGLCFOFPD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class LEFBLPAHBFA : JLOAHGICFCG<LMCBAKPEOME, BFHGLCFOFPD>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private struct GMDBHMMCFIP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public AsyncTaskMethodBuilder<BFHGLCFOFPD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public LEFBLPAHBFA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private TaskAwaiter<BFHGLCFOFPD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x81CE510", Offset = "0x81CD510", VA = "0x1881CE510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x81CE7A0", Offset = "0x81CD7A0", VA = "0x1881CE7A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private BPFJKOIAKNJ ADGBMGAGACA;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x81CEE00", Offset = "0x81CDE00", VA = "0x1881CEE00")]
	public LEFBLPAHBFA(IEnumerable<Guid> BDJJHOEHDGN, Guid LOPJIOBNBPD, bool NJCEAHNEDJG, LMCBAKPEOME GEBKONJKJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x81CED10", Offset = "0x81CDD10", VA = "0x1881CED10", Slot = "4")]
	[AsyncStateMachine(typeof(GMDBHMMCFIP))]
	public override Task<BFHGLCFOFPD> JOCGPOALKCE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class NEPBOCKIKCN : JLOAHGICFCG<LMCBAKPEOME, BFHGLCFOFPD>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private struct PAKJKFDIAFE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public AsyncTaskMethodBuilder<BFHGLCFOFPD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public NEPBOCKIKCN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private TaskAwaiter<BFHGLCFOFPD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x81CF4D0", Offset = "0x81CE4D0", VA = "0x1881CF4D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x81CF770", Offset = "0x81CE770", VA = "0x1881CF770", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly DFBCEHGKKLO ADGBMGAGACA;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x81CF3B0", Offset = "0x81CE3B0", VA = "0x1881CF3B0")]
	public NEPBOCKIKCN(Guid LOPJIOBNBPD, bool NJCEAHNEDJG, LMCBAKPEOME GEBKONJKJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x81CF2C0", Offset = "0x81CE2C0", VA = "0x1881CF2C0", Slot = "4")]
	[AsyncStateMachine(typeof(PAKJKFDIAFE))]
	public override Task<BFHGLCFOFPD> JOCGPOALKCE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public readonly struct LHCAIIJEBHI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly JJBHKPKMOGF ODOOAJGNJON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly bool AJOLOGKMKGO;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x81CEEC0", Offset = "0x81CDEC0", VA = "0x1881CEEC0")]
	public LHCAIIJEBHI(JJBHKPKMOGF EKBIEHLJCGH, bool NJCEAHNEDJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface NJJEFECFAHA<TSpawnType> where TSpawnType : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> JOCGPOALKCE(LHCAIIJEBHI CMEDMGFPIEG);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class JGBHGOLCBJG<TSpawnType> : JLOAHGICFCG<NJJEFECFAHA<TSpawnType>, TSpawnType> where TSpawnType : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct GAKEFGAOABE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public AsyncTaskMethodBuilder<TSpawnType> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public JGBHGOLCBJG<TSpawnType> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<TSpawnType> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x4E493C0", Offset = "0x4E483C0", VA = "0x184E493C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x48F9E20", Offset = "0x48F8E20", VA = "0x1848F9E20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly LHCAIIJEBHI CMEDMGFPIEG;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x52A3A40", Offset = "0x52A2A40", VA = "0x1852A3A40")]
	public JGBHGOLCBJG(JJBHKPKMOGF EKBIEHLJCGH, bool NJCEAHNEDJG, NJJEFECFAHA<TSpawnType> GEBKONJKJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x52A3950", Offset = "0x52A2950", VA = "0x1852A3950", Slot = "4")]
	[AsyncStateMachine(typeof(JGBHGOLCBJG<>.GAKEFGAOABE))]
	public override Task<TSpawnType> JOCGPOALKCE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public readonly struct JJBHKPKMOGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly bool MIDIKNCHHAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly Vector3 GIPGOILGKPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly Vector3 JILMILDHLCJ;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x81CE980", Offset = "0x81CD980", VA = "0x1881CE980")]
	public JJBHKPKMOGF(Transform COJHHKFENHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x81CE950", Offset = "0x81CD950", VA = "0x1881CE950")]
	public JJBHKPKMOGF(Vector3 PNJPAIKKPPF, Vector3 EBGKGBGFPOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x81CE920", Offset = "0x81CD920", VA = "0x1881CE920")]
	public static JJBHKPKMOGF AABAGJPEDHJ()
	{
		return default(JJBHKPKMOGF);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x81CE9F0", Offset = "0x81CD9F0", VA = "0x1881CE9F0")]
	private JJBHKPKMOGF(bool FINNLDJGGLO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct JHNMFAGKAJF<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public TNode LPGNPCPHAPK;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x52A9D70", Offset = "0x52A8D70", VA = "0x1852A9D70")]
	public JHNMFAGKAJF(TNode LPGNPCPHAPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct CIMEMNBNAMP<TNode, TReparentOperations> where TNode : notnull where TReparentOperations : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public TNode NPPDIJKAHKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public TReparentOperations CLFMNJEADNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public IBBFDIBANKC CHLLALGHHIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly bool AJOLOGKMKGO;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x68BCF60", Offset = "0x68BBF60", VA = "0x1868BCF60")]
	public CIMEMNBNAMP(TNode NPPDIJKAHKL, TReparentOperations CLFMNJEADNN, IBBFDIBANKC CHLLALGHHIN, bool NJCEAHNEDJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface LGCNNJONCLN<TNode, TReparentOperations>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FBJMOPMKPGH([In] JHNMFAGKAJF<TNode> BAEHDCBMGMJ);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EBGGKGOCOOB([In] CIMEMNBNAMP<TNode, TReparentOperations> PNAMABPOGNO);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HANPHCKLOAL();
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class GLFIKECPKGJ<TNode, TReparentOperations> : EHECGHCLKHG<LGCNNJONCLN<TNode, TReparentOperations>>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x4901E10", Offset = "0x4900E10", VA = "0x184901E10")]
	public GLFIKECPKGJ(LGCNNJONCLN<TNode, TReparentOperations> GEBKONJKJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x4ED0F50", Offset = "0x4ECFF50", VA = "0x184ED0F50", Slot = "4")]
	public override bool JOCGPOALKCE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class IJGCJNPDDAJ<TNode, TReparentOperations> : EHECGHCLKHG<LGCNNJONCLN<TNode, TReparentOperations>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly CIMEMNBNAMP<TNode, TReparentOperations> PNAMABPOGNO;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5023E20", Offset = "0x5022E20", VA = "0x185023E20")]
	public IJGCJNPDDAJ(TNode NPPDIJKAHKL, TReparentOperations CLFMNJEADNN, IBBFDIBANKC CHLLALGHHIN, LGCNNJONCLN<TNode, TReparentOperations> GEBKONJKJPJ, bool NJCEAHNEDJG = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5023D60", Offset = "0x5022D60", VA = "0x185023D60", Slot = "4")]
	public override bool JOCGPOALKCE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class DLABGBFCEEB<TNode, TReparentOperations> : EHECGHCLKHG<LGCNNJONCLN<TNode, TReparentOperations>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly JHNMFAGKAJF<TNode> BAEHDCBMGMJ;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6E9F480", Offset = "0x6E9E480", VA = "0x186E9F480")]
	public DLABGBFCEEB(TNode CFJJBMDFAPE, LGCNNJONCLN<TNode, TReparentOperations> GEBKONJKJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x4908AE0", Offset = "0x4907AE0", VA = "0x184908AE0", Slot = "4")]
	public override bool JOCGPOALKCE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct DMKLLPKLGKJ<TSpawnInfo> where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public TSpawnInfo AILGCOIKPHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public Vector3 EBGKGBGFPOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public Quaternion KDHLIJMPIFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public float AJNABLFIHCD;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x4498CF0", Offset = "0x4497CF0", VA = "0x184498CF0")]
	public DMKLLPKLGKJ(TSpawnInfo AILGCOIKPHA, Vector3 EBGKGBGFPOC, Quaternion KDHLIJMPIFF, float AJNABLFIHCD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface JBFAMNFHIPK<TSpawnType, TSpawnInfo>
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> AGLDDOGIKPB([In] DMKLLPKLGKJ<TSpawnInfo> AGKKICPFMOF, CancellationToken KGALDHLEDNC);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class ELNMIHIIDON<TSpawnType, TSpawnInfo> : JLOAHGICFCG<JBFAMNFHIPK<TSpawnType, TSpawnInfo>, TSpawnType> where TSpawnType : notnull where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly DMKLLPKLGKJ<TSpawnInfo> DELLHDJPKBE;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x49195D0", Offset = "0x49185D0", VA = "0x1849195D0")]
	public ELNMIHIIDON(TSpawnInfo MALJHMFHMDB, Vector3 EBGKGBGFPOC, Quaternion KDHLIJMPIFF, float AJNABLFIHCD, JBFAMNFHIPK<TSpawnType, TSpawnInfo> GEBKONJKJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x49193F0", Offset = "0x49183F0", VA = "0x1849193F0", Slot = "4")]
	public override Task<TSpawnType> JOCGPOALKCE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public readonly struct NADPLLGOELA<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly IEnumerable<TData> FKMKCBFHJDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly bool AJOLOGKMKGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly bool ABGLJBPLKDM;

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5751110", Offset = "0x5750110", VA = "0x185751110")]
	public NADPLLGOELA(IEnumerable<TData> FCIMPODEJPB, bool NJCEAHNEDJG = false, bool NMGNFJCMCEE = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface OFAFCEIFPCD<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<BFHGLCFOFPD> ANDMMAEOBOP([In] NADPLLGOELA<TData> HOPKICELPAP, CancellationToken KGALDHLEDNC);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class IFPFBCMJGFJ<TData> : JLOAHGICFCG<OFAFCEIFPCD<TData>, BFHGLCFOFPD> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly NADPLLGOELA<TData> CKLNINAGBLP;

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5018570", Offset = "0x5017570", VA = "0x185018570")]
	public IFPFBCMJGFJ(IEnumerable<TData> FCIMPODEJPB, bool NJCEAHNEDJG, OFAFCEIFPCD<TData> GEBKONJKJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x49193F0", Offset = "0x49183F0", VA = "0x1849193F0", Slot = "4")]
	public override Task<BFHGLCFOFPD> JOCGPOALKCE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct EENMMJMGAOA<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly T AOJAHPGAGPO;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x48F8580", Offset = "0x48F7580", VA = "0x1848F8580")]
	public EENMMJMGAOA(T PINPNHCPINF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface HFGOABIJIPM<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FBJMOPMKPGH([In] EENMMJMGAOA<T> DDJFNJKJPOG);

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EBGGKGOCOOB();
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface PCPGEAGCHIF<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JOCGPOALKCE([In] IJIAEGONMIF<T> LMPNMLKMHHH);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public struct IJIAEGONMIF<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly T AOJAHPGAGPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly bool JBCJKFDNDIE;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5023EF0", Offset = "0x5022EF0", VA = "0x185023EF0")]
	public IJIAEGONMIF(T PINPNHCPINF, bool FLGLPLFICNP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class IJFMDOJMOCH<T> : EHECGHCLKHG<HFGOABIJIPM<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x4901E10", Offset = "0x4900E10", VA = "0x184901E10")]
	public IJFMDOJMOCH(HFGOABIJIPM<T> GEBKONJKJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5023D10", Offset = "0x5022D10", VA = "0x185023D10", Slot = "4")]
	public override bool JOCGPOALKCE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class FDHELNELEFK<T> : EHECGHCLKHG<HFGOABIJIPM<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly EENMMJMGAOA<T> DDJFNJKJPOG;

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x4D7EB20", Offset = "0x4D7DB20", VA = "0x184D7EB20")]
	public FDHELNELEFK(T AOJAHPGAGPO, HFGOABIJIPM<T> GEBKONJKJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x4908AE0", Offset = "0x4907AE0", VA = "0x184908AE0", Slot = "4")]
	public override bool JOCGPOALKCE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class GHKCFJKGKKA<T> : EHECGHCLKHG<PCPGEAGCHIF<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly IJIAEGONMIF<T> LMPNMLKMHHH;

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x4EB8EB0", Offset = "0x4EB7EB0", VA = "0x184EB8EB0")]
	public GHKCFJKGKKA(T AOJAHPGAGPO, bool FLGLPLFICNP, PCPGEAGCHIF<T> GEBKONJKJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x4908AE0", Offset = "0x4907AE0", VA = "0x184908AE0", Slot = "4")]
	public override bool JOCGPOALKCE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public struct BGKLFLHPODB<TData> where TData : notnull, DPCKEEHMHBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public IEnumerable<TData> FKMKCBFHJDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public bool OCFNIDBIIKA;

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6433B60", Offset = "0x6432B60", VA = "0x186433B60")]
	public BGKLFLHPODB(IEnumerable<TData> IBGCEBPGLEI, bool CNBPEDNBLOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct ANIAPOPIEBJ<TData> where TData : notnull, DPCKEEHMHBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public List<TData> FKMKCBFHJDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public List<bool> IAIIDHDHEML;

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x527CD20", Offset = "0x527BD20", VA = "0x18527CD20")]
	public ANIAPOPIEBJ(List<TData> IBGCEBPGLEI, List<bool> JABDILELOLF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface DPCKEEHMHBN
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool KJLELLAHLBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface EPBLODHJKMD<TData> where TData : DPCKEEHMHBN
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JOCGPOALKCE([In] BGKLFLHPODB<TData> EOHCGBGPPAK);

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JOCGPOALKCE([In] ANIAPOPIEBJ<TData> EOHCGBGPPAK);
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface DBMJEBJMKEF<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ICHBFBALCDF(T AOJAHPGAGPO);
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class MNPNHJBPFNC<TData> : EHECGHCLKHG<EPBLODHJKMD<TData>> where TData : notnull, DPCKEEHMHBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly BGKLFLHPODB<TData> EOHCGBGPPAK;

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x56F8FB0", Offset = "0x56F7FB0", VA = "0x1856F8FB0")]
	public MNPNHJBPFNC(List<TData> FCIMPODEJPB, bool OCFNIDBIIKA, EPBLODHJKMD<TData> GEBKONJKJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x4908AE0", Offset = "0x4907AE0", VA = "0x184908AE0", Slot = "4")]
	public override bool JOCGPOALKCE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public class BJJJLMPHKNJ<TData> : EHECGHCLKHG<EPBLODHJKMD<TData>> where TData : notnull, DPCKEEHMHBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly ANIAPOPIEBJ<TData> EOHCGBGPPAK;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x643CBB0", Offset = "0x643BBB0", VA = "0x18643CBB0")]
	public BJJJLMPHKNJ(List<TData> FCIMPODEJPB, List<bool> IAIIDHDHEML, EPBLODHJKMD<TData> GEBKONJKJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x4F57450", Offset = "0x4F56450", VA = "0x184F57450", Slot = "4")]
	public override bool JOCGPOALKCE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public interface CENGBCGJOPB<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<BFHGLCFOFPD> JOCGPOALKCE(BLFGFEKNHNE<TData> FMJEBNCHEFK);
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class AJOJIOCDNFD<TData> : JLOAHGICFCG<CENGBCGJOPB<TData>, BFHGLCFOFPD> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private struct JDIJFKBMNAN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public AsyncTaskMethodBuilder<BFHGLCFOFPD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public AJOJIOCDNFD<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private TaskAwaiter<BFHGLCFOFPD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x5299880", Offset = "0x5298880", VA = "0x185299880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5299B60", Offset = "0x5298B60", VA = "0x185299B60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly BLFGFEKNHNE<TData> GNOHCHEJFFO;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x526C610", Offset = "0x526B610", VA = "0x18526C610")]
	public AJOJIOCDNFD(TData NNHLPIAGKDN, IReadOnlyList<TData> KDDONLHLICH, bool NJCEAHNEDJG, CENGBCGJOPB<TData> GEBKONJKJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x526C510", Offset = "0x526B510", VA = "0x18526C510", Slot = "4")]
	[AsyncStateMachine(typeof(AJOJIOCDNFD<>.JDIJFKBMNAN))]
	public override Task<BFHGLCFOFPD> JOCGPOALKCE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public struct BLFGFEKNHNE<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public TData EFOCLFPEKJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public IReadOnlyList<TData> DDCNFLEAPKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public bool AJOLOGKMKGO;

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2FC10F0", Offset = "0x2FC00F0", VA = "0x182FC10F0")]
	public BLFGFEKNHNE(TData NNHLPIAGKDN, IReadOnlyList<TData> KDDONLHLICH, bool NJCEAHNEDJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public interface OIABIKBEHKN<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JOCGPOALKCE([In] FDFAEBONKJJ<TData> AFFFHLNLOIJ);
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface JBOIBEFFJJB<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JOCGPOALKCE([In] APFKMOLNCIB<TData> AFFFHLNLOIJ);
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface INAHPDDAALI<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LDBPPKHHAFO([In] AHCHAKLFPBD<TData> AFFFHLNLOIJ);

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EBGGKGOCOOB();
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class EJGGOPPIGFD<TData> : EHECGHCLKHG<OIABIKBEHKN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly FDFAEBONKJJ<TData> AFFFHLNLOIJ;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x4908BA0", Offset = "0x4907BA0", VA = "0x184908BA0")]
	public EJGGOPPIGFD(IEnumerable<TData> FCIMPODEJPB, KOGANNKCGHD AHIICABHHJO, DOKJMPJMCCI JNBIMACAHOC, float GFBPONDLNBA, string? IMHEEBEEIJH, bool CCFCLJPAAIL, bool NJCEAHNEDJG, OIABIKBEHKN<TData> GEBKONJKJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x4908AE0", Offset = "0x4907AE0", VA = "0x184908AE0", Slot = "4")]
	public override bool JOCGPOALKCE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class OLCEPNKMMAA<TData> : EHECGHCLKHG<JBOIBEFFJJB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly APFKMOLNCIB<TData> AFFFHLNLOIJ;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x594AAA0", Offset = "0x5949AA0", VA = "0x18594AAA0")]
	public OLCEPNKMMAA(TData[] FCIMPODEJPB, KOGANNKCGHD[] AHIICABHHJO, DOKJMPJMCCI[] JNBIMACAHOC, float[] GFBPONDLNBA, JBOIBEFFJJB<TData> GEBKONJKJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x48EA230", Offset = "0x48E9230", VA = "0x1848EA230", Slot = "4")]
	public override bool JOCGPOALKCE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class LMHNINEOFCP<TData> : EHECGHCLKHG<INAHPDDAALI<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x4901E10", Offset = "0x4900E10", VA = "0x184901E10")]
	public LMHNINEOFCP(INAHPDDAALI<TData> GEBKONJKJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x54B86A0", Offset = "0x54B76A0", VA = "0x1854B86A0", Slot = "4")]
	public override bool JOCGPOALKCE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class ECGCEMDAEOB<TData> : EHECGHCLKHG<INAHPDDAALI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly AHCHAKLFPBD<TData> AFFFHLNLOIJ;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x48EA2F0", Offset = "0x48E92F0", VA = "0x1848EA2F0")]
	public ECGCEMDAEOB(IEnumerable<TData> FCIMPODEJPB, KOGANNKCGHD AHIICABHHJO, DOKJMPJMCCI JNBIMACAHOC, float GFBPONDLNBA, INAHPDDAALI<TData> GEBKONJKJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x48EA230", Offset = "0x48E9230", VA = "0x1848EA230", Slot = "4")]
	public override bool JOCGPOALKCE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public struct FDFAEBONKJJ<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public IEnumerable<TData> FKMKCBFHJDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public KOGANNKCGHD CHNEPDKGONI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public DOKJMPJMCCI AGLIMLFKBOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public float DNKGEMIKELB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public string? CHIILACPAMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public bool? ACNGGPFBGAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public bool AJOLOGKMKGO;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x4D7E1F0", Offset = "0x4D7D1F0", VA = "0x184D7E1F0")]
	public FDFAEBONKJJ(IEnumerable<TData> FCIMPODEJPB, KOGANNKCGHD AHIICABHHJO, DOKJMPJMCCI JNBIMACAHOC, float GFBPONDLNBA, string? IMHEEBEEIJH, bool? CCFCLJPAAIL, bool NJCEAHNEDJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct APFKMOLNCIB<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public TData[] FKMKCBFHJDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public KOGANNKCGHD[] CHNEPDKGONI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public DOKJMPJMCCI[] AGLIMLFKBOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public float[] GFBPONDLNBA;

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x5371730", Offset = "0x5370730", VA = "0x185371730")]
	public APFKMOLNCIB(TData[] FCIMPODEJPB, KOGANNKCGHD[] AHIICABHHJO, DOKJMPJMCCI[] JNBIMACAHOC, float[] GFBPONDLNBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public struct AHCHAKLFPBD<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public IEnumerable<TData> FKMKCBFHJDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public KOGANNKCGHD CHNEPDKGONI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public DOKJMPJMCCI AGLIMLFKBOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public float GFBPONDLNBA;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x519A8E0", Offset = "0x51998E0", VA = "0x18519A8E0")]
	public AHCHAKLFPBD(IEnumerable<TData> FCIMPODEJPB, KOGANNKCGHD AHIICABHHJO, DOKJMPJMCCI JNBIMACAHOC, float GFBPONDLNBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface ELEHGDKEBJM<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JNIBLJANGLJ([In] JPEFAHAMCBC<TData> HOPKICELPAP);

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IMIMBNLAOPO([In] JPEFAHAMCBC<TData> HOPKICELPAP);

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ADDMMJFJICO([In] bool MHJLIGMLCOK);

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool AAGHFHDOIBE([In] JPEFAHAMCBC<TData> HOPKICELPAP);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DPNOCMELEEB();

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool OBHAFCLLNMB([In] TData GOGJAMKFBDG);
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class ACKEJBDECHI<TData> : EHECGHCLKHG<ELEHGDKEBJM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly JPEFAHAMCBC<TData> HOPKICELPAP;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x50CAF70", Offset = "0x50C9F70", VA = "0x1850CAF70")]
	public ACKEJBDECHI(List<TData> NKOHPCLOFJA, ELEHGDKEBJM<TData> GEBKONJKJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x4908AE0", Offset = "0x4907AE0", VA = "0x184908AE0", Slot = "4")]
	public override bool JOCGPOALKCE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class HICDIJIMGEN<TData> : EHECGHCLKHG<ELEHGDKEBJM<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4901E10", Offset = "0x4900E10", VA = "0x184901E10")]
	public HICDIJIMGEN(ELEHGDKEBJM<TData> GEBKONJKJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x4F46EC0", Offset = "0x4F45EC0", VA = "0x184F46EC0", Slot = "4")]
	public override bool JOCGPOALKCE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class BACHIDHOKLB<TData> : EHECGHCLKHG<ELEHGDKEBJM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly bool NJCEAHNEDJG;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x633ACC0", Offset = "0x6339CC0", VA = "0x18633ACC0")]
	public BACHIDHOKLB(bool NJCEAHNEDJG, ELEHGDKEBJM<TData> GEBKONJKJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x633AC60", Offset = "0x6339C60", VA = "0x18633AC60", Slot = "4")]
	public override bool JOCGPOALKCE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class HPMHEDLNOKF<TData> : EHECGHCLKHG<ELEHGDKEBJM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly JPEFAHAMCBC<TData> HOPKICELPAP;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x4F575A0", Offset = "0x4F565A0", VA = "0x184F575A0")]
	public HPMHEDLNOKF(List<TData> NKOHPCLOFJA, bool NJCEAHNEDJG, ELEHGDKEBJM<TData> GEBKONJKJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x4F57450", Offset = "0x4F56450", VA = "0x184F57450", Slot = "4")]
	public override bool JOCGPOALKCE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class FFHBKCNFKMO<TData> : EHECGHCLKHG<ELEHGDKEBJM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly TData GOGJAMKFBDG;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x4D8B260", Offset = "0x4D8A260", VA = "0x184D8B260")]
	public FFHBKCNFKMO(TData GOGJAMKFBDG, ELEHGDKEBJM<TData> GEBKONJKJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x4D8B1A0", Offset = "0x4D8A1A0", VA = "0x184D8B1A0", Slot = "4")]
	public override bool JOCGPOALKCE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class OOCHCDBLNML<TData> : EHECGHCLKHG<ELEHGDKEBJM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly JPEFAHAMCBC<TData> HOPKICELPAP;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x595ADC0", Offset = "0x5959DC0", VA = "0x18595ADC0")]
	public OOCHCDBLNML(IEnumerable<TData> NKOHPCLOFJA, ELEHGDKEBJM<TData> GEBKONJKJPJ, bool NJCEAHNEDJG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x595AC60", Offset = "0x5959C60", VA = "0x18595AC60", Slot = "4")]
	public override bool JOCGPOALKCE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public struct JPEFAHAMCBC<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public IEnumerable<TData> FKMKCBFHJDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public bool NJCEAHNEDJG;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x52E6110", Offset = "0x52E5110", VA = "0x1852E6110")]
	public JPEFAHAMCBC(IEnumerable<TData> IBGCEBPGLEI, bool IOHACEEAICM = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public interface IEOMDJGNGOL
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<BFHGLCFOFPD> JOCGPOALKCE(LPMFCNMPJMG HBMJEJALBLJ);
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class ECAIMDNGMOG : JLOAHGICFCG<IEOMDJGNGOL, BFHGLCFOFPD>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private struct FKCFLOEFKDJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public AsyncTaskMethodBuilder<BFHGLCFOFPD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public ECAIMDNGMOG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private TaskAwaiter<BFHGLCFOFPD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x81CE1E0", Offset = "0x81CD1E0", VA = "0x1881CE1E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x81CE460", Offset = "0x81CD460", VA = "0x1881CE460", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly LPMFCNMPJMG FCHMNEIHEOM;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x81CE140", Offset = "0x81CD140", VA = "0x1881CE140")]
	public ECAIMDNGMOG(bool NJCEAHNEDJG, IEOMDJGNGOL GEBKONJKJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x81CE050", Offset = "0x81CD050", VA = "0x1881CE050", Slot = "4")]
	[AsyncStateMachine(typeof(FKCFLOEFKDJ))]
	public override Task<BFHGLCFOFPD> JOCGPOALKCE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public struct LPMFCNMPJMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public bool AJOLOGKMKGO;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x2C8B000", Offset = "0x2C8A000", VA = "0x182C8B000")]
	public LPMFCNMPJMG(bool NJCEAHNEDJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public readonly struct AGCGLEPOEDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public readonly bool NHNDLDPIMDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public readonly bool JFNEJFCKJIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public readonly bool AJNABLFIHCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public readonly bool NJCEAHNEDJG;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x60CA8B0", Offset = "0x60C98B0", VA = "0x1860CA8B0")]
	public AGCGLEPOEDI(bool NHNDLDPIMDA, bool JFNEJFCKJIA, bool AJNABLFIHCD, bool NJCEAHNEDJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x81CD7A0", Offset = "0x81CC7A0", VA = "0x1881CD7A0")]
	public AGCGLEPOEDI(bool JFNEJFCKJIA, bool NJCEAHNEDJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public interface LNIJPHJHMBD
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DEJNCKDBGGA(AGCGLEPOEDI FKAMGFPAMCL);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HJJIKPDJKJB(AGCGLEPOEDI FKAMGFPAMCL);
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public class MOHFMNDIMBH : EHECGHCLKHG<LNIJPHJHMBD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly AGCGLEPOEDI FKAMGFPAMCL;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x81CF000", Offset = "0x81CE000", VA = "0x1881CF000")]
	public MOHFMNDIMBH(bool PLPGMCABFBF, bool JFNEJFCKJIA, bool AJNABLFIHCD, bool NJCEAHNEDJG, LNIJPHJHMBD GEBKONJKJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x81CEFB0", Offset = "0x81CDFB0", VA = "0x1881CEFB0", Slot = "4")]
	public override bool JOCGPOALKCE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class MMEFJLGAPCL : EHECGHCLKHG<LNIJPHJHMBD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly AGCGLEPOEDI FKAMGFPAMCL;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x81CEF30", Offset = "0x81CDF30", VA = "0x1881CEF30")]
	public MMEFJLGAPCL(bool JFNEJFCKJIA, bool NJCEAHNEDJG, LNIJPHJHMBD GEBKONJKJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x81CEEE0", Offset = "0x81CDEE0", VA = "0x1881CEEE0", Slot = "4")]
	public override bool JOCGPOALKCE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public interface OKMBAIKIEED
{
	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JOCGPOALKCE([In] DBBDMDLDABN DAOCLDAAMKC);
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class LDGELBEGIOB : EHECGHCLKHG<OKMBAIKIEED>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly DBBDMDLDABN DAOCLDAAMKC;

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x81CEB30", Offset = "0x81CDB30", VA = "0x1881CEB30")]
	public LDGELBEGIOB(Guid[] MLEIKHEGNBM, Vector3[] HDJDLKKIIKP, Quaternion[] BKGLLPMIMMK, float[] HOMOEBJEMCC, Dictionary<Guid, Vector3> LNACJCABAPK, OKMBAIKIEED GEBKONJKJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x81CEA80", Offset = "0x81CDA80", VA = "0x1881CEA80", Slot = "4")]
	public override bool JOCGPOALKCE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public interface HFMLAJJIPKI<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FBJMOPMKPGH([In] NAPPNNJDMKN<TData> BAEHDCBMGMJ);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LDBPPKHHAFO([In] OEPGJGCEDJB FKEGAGPCDCK);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LDBPPKHHAFO([In] GGDODCJKCEI FKEGAGPCDCK);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool EBGGKGOCOOB();
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class DKNPHAOJNJL<TData> : EHECGHCLKHG<HFMLAJJIPKI<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x4901E10", Offset = "0x4900E10", VA = "0x184901E10")]
	public DKNPHAOJNJL(HFMLAJJIPKI<TData> GEBKONJKJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x6E9F430", Offset = "0x6E9E430", VA = "0x186E9F430", Slot = "4")]
	public override bool JOCGPOALKCE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public class EFDKKPLBCKN<TData> : EHECGHCLKHG<HFMLAJJIPKI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly OEPGJGCEDJB KGGOIGDFMJN;

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x48F8D60", Offset = "0x48F7D60", VA = "0x1848F8D60")]
	public EFDKKPLBCKN(Vector3 EPGBKGAEMCA, bool APOIPINAKCF, HFMLAJJIPKI<TData> GEBKONJKJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x48F8D00", Offset = "0x48F7D00", VA = "0x1848F8D00", Slot = "4")]
	public override bool JOCGPOALKCE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class CLKEKENLKJC<TData> : EHECGHCLKHG<HFMLAJJIPKI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly GGDODCJKCEI KGGOIGDFMJN;

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x698D890", Offset = "0x698C890", VA = "0x18698D890")]
	public CLKEKENLKJC(Guid GLKOBOIGMOC, int HLGKMAPOEBE, Vector3 EBGKGBGFPOC, Quaternion KDHLIJMPIFF, float MGJGIJAADIJ, bool APOIPINAKCF, HFMLAJJIPKI<TData> GEBKONJKJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x698D830", Offset = "0x698C830", VA = "0x18698D830", Slot = "4")]
	public override bool JOCGPOALKCE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class JCNJCHMEMKO<TData> : EHECGHCLKHG<HFMLAJJIPKI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly NAPPNNJDMKN<TData> KGGOIGDFMJN;

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5298F40", Offset = "0x5297F40", VA = "0x185298F40")]
	public JCNJCHMEMKO(TData AOJAHPGAGPO, bool NJCEAHNEDJG, HFMLAJJIPKI<TData> GEBKONJKJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x4908AE0", Offset = "0x4907AE0", VA = "0x184908AE0", Slot = "4")]
	public override bool JOCGPOALKCE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct OEPGJGCEDJB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public readonly Vector3 EPGBKGAEMCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public readonly bool APOIPINAKCF;

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x81CF4B0", Offset = "0x81CE4B0", VA = "0x1881CF4B0")]
	public OEPGJGCEDJB(Vector3 EPGBKGAEMCA, bool APOIPINAKCF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public struct GGDODCJKCEI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public readonly Guid GLKOBOIGMOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public readonly int HLGKMAPOEBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public readonly Vector3 EBGKGBGFPOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public readonly Quaternion KDHLIJMPIFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly float MGJGIJAADIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public readonly bool APOIPINAKCF;

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x81CE4D0", Offset = "0x81CD4D0", VA = "0x1881CE4D0")]
	public GGDODCJKCEI(Guid GLKOBOIGMOC, int HLGKMAPOEBE, Vector3 EBGKGBGFPOC, Quaternion KDHLIJMPIFF, float MGJGIJAADIJ, bool APOIPINAKCF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public struct NAPPNNJDMKN<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public readonly TData AOJAHPGAGPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public readonly bool NJCEAHNEDJG;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x57532E0", Offset = "0x57522E0", VA = "0x1857532E0")]
	public NAPPNNJDMKN(TData AOJAHPGAGPO, bool NJCEAHNEDJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public interface KLDMEKAONPA<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JOCGPOALKCE([In] CONOBEOFCPM<TData> JHECGNEDGNJ);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JOCGPOALKCE([In] BGFDJCPCCBN<TData> JHECGNEDGNJ);
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public interface LMFFOCMDNNI<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FBJMOPMKPGH([In] MIEDDLFAPLA<TData> LKECALAOLHE);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LDBPPKHHAFO([In] ANHHPNDCDGK FKEGAGPCDCK);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool EBGGKGOCOOB();
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public class GEGCECCDOCJ<TData> : EHECGHCLKHG<KLDMEKAONPA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly CONOBEOFCPM<TData> JHECGNEDGNJ;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x4EA5360", Offset = "0x4EA4360", VA = "0x184EA5360")]
	public GEGCECCDOCJ(IEnumerable<TData> FCIMPODEJPB, Vector3 LPJPMFKNJIJ, bool NJCEAHNEDJG, KLDMEKAONPA<TData> GEBKONJKJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x4908AE0", Offset = "0x4907AE0", VA = "0x184908AE0", Slot = "4")]
	public override bool JOCGPOALKCE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public class OJOCCONNPMA<TData> : EHECGHCLKHG<LMFFOCMDNNI<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x4901E10", Offset = "0x4900E10", VA = "0x184901E10")]
	public OJOCCONNPMA(LMFFOCMDNNI<TData> GEBKONJKJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x4ED0F50", Offset = "0x4ECFF50", VA = "0x184ED0F50", Slot = "4")]
	public override bool JOCGPOALKCE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class MPNOJDPHEHM<TData> : EHECGHCLKHG<LMFFOCMDNNI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly MIEDDLFAPLA<TData> JHECGNEDGNJ;

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5715B80", Offset = "0x5714B80", VA = "0x185715B80")]
	public MPNOJDPHEHM(IEnumerable<TData> FCIMPODEJPB, bool NJCEAHNEDJG, LMFFOCMDNNI<TData> GEBKONJKJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x4908AE0", Offset = "0x4907AE0", VA = "0x184908AE0", Slot = "4")]
	public override bool JOCGPOALKCE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class AFPJDNDIFFJ<TData> : EHECGHCLKHG<KLDMEKAONPA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly BGFDJCPCCBN<TData> JHECGNEDGNJ;

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x5199D20", Offset = "0x5198D20", VA = "0x185199D20")]
	public AFPJDNDIFFJ(IEnumerable<TData> FCIMPODEJPB, Vector3 GOIANEMEIAO, CNINAPHKEDC DBCMGPMOEGB, bool NJCEAHNEDJG, KLDMEKAONPA<TData> GEBKONJKJPJ, Space KKDHNGJEIJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5023D60", Offset = "0x5022D60", VA = "0x185023D60", Slot = "4")]
	public override bool JOCGPOALKCE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class HOFPKIFIHGP<TData> : EHECGHCLKHG<LMFFOCMDNNI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly ANHHPNDCDGK JHECGNEDGNJ;

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x4F54630", Offset = "0x4F53630", VA = "0x184F54630")]
	public HOFPKIFIHGP(Vector3 LPJPMFKNJIJ, LMFFOCMDNNI<TData> GEBKONJKJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x48F8D00", Offset = "0x48F7D00", VA = "0x1848F8D00", Slot = "4")]
	public override bool JOCGPOALKCE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public struct CONOBEOFCPM<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public readonly IEnumerable<TData> FCIMPODEJPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public readonly Vector3 LPJPMFKNJIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public readonly bool NJCEAHNEDJG;

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6995980", Offset = "0x6994980", VA = "0x186995980")]
	public CONOBEOFCPM(IEnumerable<TData> FCIMPODEJPB, Vector3 LPJPMFKNJIJ, bool NJCEAHNEDJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public struct MIEDDLFAPLA<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public readonly IEnumerable<TData> FCIMPODEJPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public readonly bool NJCEAHNEDJG;

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x56D8720", Offset = "0x56D7720", VA = "0x1856D8720")]
	public MIEDDLFAPLA(IEnumerable<TData> FCIMPODEJPB, bool NJCEAHNEDJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public struct BGFDJCPCCBN<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public readonly IEnumerable<TData> FCIMPODEJPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public readonly Vector3 GOIANEMEIAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public readonly CNINAPHKEDC DBCMGPMOEGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public readonly bool NJCEAHNEDJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public readonly Space KKDHNGJEIJN;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x6432BD0", Offset = "0x6431BD0", VA = "0x186432BD0")]
	public BGFDJCPCCBN(IEnumerable<TData> FCIMPODEJPB, Vector3 GOIANEMEIAO, CNINAPHKEDC DBCMGPMOEGB, bool NJCEAHNEDJG, Space KKDHNGJEIJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public struct ANHHPNDCDGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public readonly Vector3 LPJPMFKNJIJ;

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x2C8AE40", Offset = "0x2C89E40", VA = "0x182C8AE40")]
	public ANHHPNDCDGK(Vector3 LPJPMFKNJIJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public enum CNINAPHKEDC
{
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	XYZ,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	X_only,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	Y_only,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	Z_only
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public interface GFIINJIHNMO
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JOCGPOALKCE([In] KLLAJFDPADM FLNGOAMNJMO);
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public class IGPLKBFLFLB : EHECGHCLKHG<GFIINJIHNMO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private readonly KLLAJFDPADM FLNGOAMNJMO;

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x81CE8C0", Offset = "0x81CD8C0", VA = "0x1881CE8C0")]
	public IGPLKBFLFLB(bool NJCEAHNEDJG, GFIINJIHNMO GEBKONJKJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x81CE810", Offset = "0x81CD810", VA = "0x1881CE810", Slot = "4")]
	public override bool JOCGPOALKCE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public readonly struct KLLAJFDPADM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public readonly bool NJCEAHNEDJG;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x2C8B000", Offset = "0x2C8A000", VA = "0x182C8B000")]
	public KLLAJFDPADM(bool NJCEAHNEDJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public interface IOGOLOOPJFD<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JOCGPOALKCE([In] ACPHMJODIFF<TData> OPCKLFACGMC);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JOCGPOALKCE([In] AGJDAIDKDOF<TData> OPCKLFACGMC);
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public interface AHHLGCBGKDJ<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FBJMOPMKPGH([In] MMDFNPOIJEG<TData> BAEHDCBMGMJ);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LDBPPKHHAFO([In] NNEHNONBNPO FKEGAGPCDCK);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool EBGGKGOCOOB();
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class JCMJLKEBIIF<TData> : EHECGHCLKHG<IOGOLOOPJFD<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly ACPHMJODIFF<TData> OPCKLFACGMC;

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x5296770", Offset = "0x5295770", VA = "0x185296770")]
	public JCMJLKEBIIF(IEnumerable<TData> FCIMPODEJPB, Quaternion LPJPMFKNJIJ, Vector3? HNGJENLJJGB, bool JLABINECGOA, bool NJCEAHNEDJG, IOGOLOOPJFD<TData> GEBKONJKJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x4908AE0", Offset = "0x4907AE0", VA = "0x184908AE0", Slot = "4")]
	public override bool JOCGPOALKCE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class NONBPLJBODN<TData> : EHECGHCLKHG<AHHLGCBGKDJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x4901E10", Offset = "0x4900E10", VA = "0x184901E10")]
	public NONBPLJBODN(AHHLGCBGKDJ<TData> GEBKONJKJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x4ED0F50", Offset = "0x4ECFF50", VA = "0x184ED0F50", Slot = "4")]
	public override bool JOCGPOALKCE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public class LHFOCIKNPKL<TData> : EHECGHCLKHG<AHHLGCBGKDJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly MMDFNPOIJEG<TData> OPCKLFACGMC;

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x5478AC0", Offset = "0x5477AC0", VA = "0x185478AC0")]
	public LHFOCIKNPKL(IEnumerable<TData> FCIMPODEJPB, bool NJCEAHNEDJG, AHHLGCBGKDJ<TData> GEBKONJKJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x4908AE0", Offset = "0x4907AE0", VA = "0x184908AE0", Slot = "4")]
	public override bool JOCGPOALKCE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public class DDAPGKAONIE<TData> : EHECGHCLKHG<IOGOLOOPJFD<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly AGJDAIDKDOF<TData> OPCKLFACGMC;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x6E80ED0", Offset = "0x6E7FED0", VA = "0x186E80ED0")]
	public DDAPGKAONIE(IEnumerable<TData> FCIMPODEJPB, Quaternion DKKFLBOPGNB, CNINAPHKEDC FKHOHJICEHG, Vector3? HNGJENLJJGB, bool JLABINECGOA, bool NJCEAHNEDJG, Space KKDHNGJEIJN, IOGOLOOPJFD<TData> GEBKONJKJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x5023D60", Offset = "0x5022D60", VA = "0x185023D60", Slot = "4")]
	public override bool JOCGPOALKCE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public class ABKNLFFCHBG<TData> : EHECGHCLKHG<AHHLGCBGKDJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly NNEHNONBNPO OPCKLFACGMC;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x50C5030", Offset = "0x50C4030", VA = "0x1850C5030")]
	public ABKNLFFCHBG(Quaternion LPJPMFKNJIJ, Vector3? HNGJENLJJGB, bool JLABINECGOA, AHHLGCBGKDJ<TData> GEBKONJKJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x48F8D00", Offset = "0x48F7D00", VA = "0x1848F8D00", Slot = "4")]
	public override bool JOCGPOALKCE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public struct ACPHMJODIFF<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public readonly IEnumerable<TData> FCIMPODEJPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public readonly Quaternion LPJPMFKNJIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public readonly Vector3? HNGJENLJJGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public readonly bool JLABINECGOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly bool NJCEAHNEDJG;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x50CB780", Offset = "0x50CA780", VA = "0x1850CB780")]
	public ACPHMJODIFF(IEnumerable<TData> FCIMPODEJPB, Quaternion LPJPMFKNJIJ, Vector3? HNGJENLJJGB, bool JLABINECGOA, bool NJCEAHNEDJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct MMDFNPOIJEG<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public readonly IEnumerable<TData> FCIMPODEJPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly bool NJCEAHNEDJG;

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x56E8A10", Offset = "0x56E7A10", VA = "0x1856E8A10")]
	public MMDFNPOIJEG(IEnumerable<TData> FCIMPODEJPB, bool NJCEAHNEDJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public struct AGJDAIDKDOF<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public readonly IEnumerable<TData> FCIMPODEJPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public readonly Quaternion DKKFLBOPGNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public readonly CNINAPHKEDC FKHOHJICEHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public readonly Vector3? HNGJENLJJGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public readonly bool JLABINECGOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public readonly bool NJCEAHNEDJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public readonly Space KKDHNGJEIJN;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x5199F80", Offset = "0x5198F80", VA = "0x185199F80")]
	public AGJDAIDKDOF(IEnumerable<TData> FCIMPODEJPB, Quaternion DKKFLBOPGNB, CNINAPHKEDC FKHOHJICEHG, Vector3? HNGJENLJJGB, bool JLABINECGOA, bool NJCEAHNEDJG, Space KKDHNGJEIJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public struct NNEHNONBNPO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public readonly Quaternion LPJPMFKNJIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public readonly Vector3? HNGJENLJJGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public readonly bool JLABINECGOA;

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x60912E0", Offset = "0x60902E0", VA = "0x1860912E0")]
	public NNEHNONBNPO(Quaternion LPJPMFKNJIJ, Vector3? HNGJENLJJGB, bool JLABINECGOA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public interface KFKDJHBCGKG<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FBJMOPMKPGH([In] HMADMPHBOKD<TData> BAEHDCBMGMJ);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LDBPPKHHAFO([In] DLFKEOMKDDC FKEGAGPCDCK);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LDBPPKHHAFO([In] EAEJANNKALA FKEGAGPCDCK);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool LDBPPKHHAFO([In] EOICFGKMKBI FKEGAGPCDCK);

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool EBGGKGOCOOB();
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public class DDNEOMFPILG<TData> : EHECGHCLKHG<KFKDJHBCGKG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private readonly EOICFGKMKBI OCADIDFOPME;

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6E862A0", Offset = "0x6E852A0", VA = "0x186E862A0")]
	public DDNEOMFPILG(Vector3 AAGIEPKOFEE, float IOPKIIHMCNB, Vector3 HNGJENLJJGB, bool HLGHDHMIFOJ, bool LIEAKJDPIPC, KFKDJHBCGKG<TData> GEBKONJKJPJ, Space KKDHNGJEIJN = Space.Self)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6E86240", Offset = "0x6E85240", VA = "0x186E86240", Slot = "4")]
	public override bool JOCGPOALKCE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public class DJLJAGNBOGE<TData> : EHECGHCLKHG<KFKDJHBCGKG<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x4901E10", Offset = "0x4900E10", VA = "0x184901E10")]
	public DJLJAGNBOGE(KFKDJHBCGKG<TData> GEBKONJKJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6E9C4F0", Offset = "0x6E9B4F0", VA = "0x186E9C4F0", Slot = "4")]
	public override bool JOCGPOALKCE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public class PPOPJNNIEPI<TData> : EHECGHCLKHG<KFKDJHBCGKG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly HMADMPHBOKD<TData> OCADIDFOPME;

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x5A87A00", Offset = "0x5A86A00", VA = "0x185A87A00")]
	public PPOPJNNIEPI(IEnumerable<TData> FCIMPODEJPB, bool NJCEAHNEDJG, KFKDJHBCGKG<TData> GEBKONJKJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x4908AE0", Offset = "0x4907AE0", VA = "0x184908AE0", Slot = "4")]
	public override bool JOCGPOALKCE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public class LFAJGFHOMHP<TData> : EHECGHCLKHG<KFKDJHBCGKG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private readonly EAEJANNKALA OCADIDFOPME;

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x5470270", Offset = "0x546F270", VA = "0x185470270")]
	public LFAJGFHOMHP(float OJNOIEMMNDP, bool AGKGHNHDGCG, Vector3 HNGJENLJJGB, KFKDJHBCGKG<TData> GEBKONJKJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x54701B0", Offset = "0x546F1B0", VA = "0x1854701B0", Slot = "4")]
	public override bool JOCGPOALKCE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public class FHAEODBHEGL<TData> : EHECGHCLKHG<KFKDJHBCGKG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly DLFKEOMKDDC OCADIDFOPME;

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x4D8D6F0", Offset = "0x4D8C6F0", VA = "0x184D8D6F0")]
	public FHAEODBHEGL(float IOPKIIHMCNB, Vector3 HNGJENLJJGB, KFKDJHBCGKG<TData> GEBKONJKJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x48F8D00", Offset = "0x48F7D00", VA = "0x1848F8D00", Slot = "4")]
	public override bool JOCGPOALKCE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public struct EOICFGKMKBI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public readonly Vector3 AAGIEPKOFEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public readonly float IOPKIIHMCNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public readonly Vector3 HNGJENLJJGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public readonly bool APOIPINAKCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public readonly Space KKDHNGJEIJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public readonly bool LIEAKJDPIPC;

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x81CE1A0", Offset = "0x81CD1A0", VA = "0x1881CE1A0")]
	public EOICFGKMKBI(Vector3 AAGIEPKOFEE, float IOPKIIHMCNB, Vector3 HNGJENLJJGB, bool APOIPINAKCF, bool NIDOKKCBANP, Space KKDHNGJEIJN = Space.Self)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public struct HMADMPHBOKD<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public readonly IEnumerable<TData> FCIMPODEJPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public readonly bool NJCEAHNEDJG;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x4F50EF0", Offset = "0x4F4FEF0", VA = "0x184F50EF0")]
	public HMADMPHBOKD(IEnumerable<TData> FCIMPODEJPB, bool NJCEAHNEDJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public struct EAEJANNKALA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public readonly float OJNOIEMMNDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public readonly bool AGKGHNHDGCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public readonly Vector3 HNGJENLJJGB;

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x81CE030", Offset = "0x81CD030", VA = "0x1881CE030")]
	public EAEJANNKALA(float OJNOIEMMNDP, bool AGKGHNHDGCG, Vector3 HNGJENLJJGB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public struct DLFKEOMKDDC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public readonly float IOPKIIHMCNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public readonly Vector3 HNGJENLJJGB;

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x604F860", Offset = "0x604E860", VA = "0x18604F860")]
	public DLFKEOMKDDC(float IOPKIIHMCNB, Vector3 HNGJENLJJGB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public struct DBBDMDLDABN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public readonly Guid[] FCIMPODEJPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public readonly bool FEDNKGCPPEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public readonly bool MDAGBKENGKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public readonly bool HDNJJGIPKFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public readonly Vector3[] HDJDLKKIIKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public readonly Quaternion[] BKGLLPMIMMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public readonly float[] HOMOEBJEMCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public readonly Dictionary<Guid, Vector3> LNACJCABAPK;

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x81CDDA0", Offset = "0x81CCDA0", VA = "0x1881CDDA0")]
	public DBBDMDLDABN(Guid[] MLEIKHEGNBM, Vector3[] HDJDLKKIIKP, Quaternion[] BKGLLPMIMMK, float[] HOMOEBJEMCC, Dictionary<Guid, Vector3> LNACJCABAPK, bool FEDNKGCPPEA = true, bool MDAGBKENGKN = true, bool HDNJJGIPKFN = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x81CDBD0", Offset = "0x81CCBD0", VA = "0x1881CDBD0")]
	private static void BKNGAMFMAAE(Dictionary<Guid, Vector3> LNACJCABAPK, int NCBCEOPLGNL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public static class CEDDLHKLPOL
{
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	private struct FDIOCKHGFEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public bool LNMKMKKFLEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public CBHAAKGBAOP NGGLOIFBLJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public CBHAAKGBAOP BDIABHLJOFA;
	}

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private static FDIOCKHGFEF NFFKENLAHDJ;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static CancellationToken PGBJGODECMH
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x81CDAA0", Offset = "0x81CCAA0", VA = "0x1881CDAA0")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	internal static CBHAAKGBAOP NGGLOIFBLJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x81CDB30", Offset = "0x81CCB30", VA = "0x1881CDB30")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x81CDAC0", Offset = "0x81CCAC0", VA = "0x1881CDAC0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x81CD950", Offset = "0x81CC950", VA = "0x1881CD950")]
	[GOMLKAICHII.BCJFEFEABPB]
	internal static void CFEDANGKIBL(CBHAAKGBAOP ODPMPAIKOBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x81CD7F0", Offset = "0x81CC7F0", VA = "0x1881CD7F0")]
	public static void AEEGGHAFLLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x81CDA50", Offset = "0x81CCA50", VA = "0x1881CDA50")]
	private static CBHAAKGBAOP DCLJNCKFJNO(CBHAAKGBAOP CGIAOEFMJHN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public static class FAPILMGPDNI
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public enum JALOCMIBDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		ICreationContextObject,
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		Guid
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x3C2D8B0", Offset = "0x3C2C8B0", VA = "0x183C2D8B0")]
	public static void NPAJAOHKEEC<T>(T KLKDHLJDBBB, JALOCMIBDNJ BJLNCBFOGNL) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3C2D9F0", Offset = "0x3C2C9F0", VA = "0x183C2D9F0")]
	public static void NPAJAOHKEEC<T>(T KLKDHLJDBBB) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x3C2D7D0", Offset = "0x3C2C7D0", VA = "0x183C2D7D0")]
	public static void NPAJAOHKEEC<T, TImpl, T>() where T : class where TImpl : notnull, T where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x3C2DA50", Offset = "0x3C2CA50", VA = "0x183C2DA50")]
	public static void OHPBDJFEANF<T>(T KLKDHLJDBBB) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x3C2D730", Offset = "0x3C2C730", VA = "0x183C2D730")]
	public static T LMKONLJOAEP<T>(JALOCMIBDNJ BJLNCBFOGNL) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x3C2D520", Offset = "0x3C2C520", VA = "0x183C2D520")]
	public static bool HOOMFBIAHPE<T>(JALOCMIBDNJ BJLNCBFOGNL, T? LKDLKJDHOGL, [Out][MaybeNullWhen(false)][NotNullWhen(true)] T FHMBHENIEGP) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x3C2DAC0", Offset = "0x3C2CAC0", VA = "0x183C2DAC0")]
	public static bool PHIGOFGEJFD<T>(JALOCMIBDNJ BJLNCBFOGNL, [Out][NotNullWhen(true)][MaybeNullWhen(false)] T DDKBNFLPGKK) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x3C2DBC0", Offset = "0x3C2CBC0", VA = "0x183C2DBC0")]
	public static bool PNPPINBFKFK<T>(JALOCMIBDNJ BJLNCBFOGNL) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x3C2D6F0", Offset = "0x3C2C6F0", VA = "0x183C2D6F0")]
	public static T LMKONLJOAEP<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x3C2D650", Offset = "0x3C2C650", VA = "0x183C2D650")]
	public static bool HOOMFBIAHPE<T>(T LKDLKJDHOGL, [Out] T FHMBHENIEGP) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x3C2D6F0", Offset = "0x3C2C6F0", VA = "0x183C2D6F0")]
	public static bool PNPPINBFKFK<T>() where T : class
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
internal static class MPMKHNDOPCB
{
	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x81CF090", Offset = "0x81CE090", VA = "0x1881CF090")]
	public static void FAAEGOGCOIG(IEnumerable JHCPJPFFKMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x3D961A0", Offset = "0x3D951A0", VA = "0x183D961A0")]
	public static void FAAEGOGCOIG<T>(T[] MFIJBPNIELL) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x3D96290", Offset = "0x3D95290", VA = "0x183D96290")]
	public static void FAAEGOGCOIG<T>(T EINBKGFECKN) where T : notnull, Enum
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
